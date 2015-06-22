using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Net;
using System.Net.NetworkInformation;
using System.Web.Routing;

/// <summary>
/// To bind the existing data and storing it in the database , Sending mail to report the updation to the corresponding user
/// </summary>
public partial class edit_events : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    string strScript = string.Empty;
    InsertData obj = new InsertData();
    static string excep_page = "edit_events.aspx";
    protected void Page_Load(object sender, EventArgs e)
    {
        string userid = Convert.ToString(Session["USERID"]);
        string regtype = Convert.ToString(Session["RegType"]);
        try
        {
            if (userid != "" && regtype == "Business")
            {


            }

            else if (userid != "" && regtype == "Individual")
            {

                //redirect("AuthenticationMsg.aspx?msg=Events",false);
                Response.RedirectToRoute("AuthenticationMsg", new { msg = "Events" });

            }

            else
                //redirect("signin.aspx?Qname=Events",false);
                Response.RedirectToRoute("Signin", new { Qname = "Events" });
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
        con.Open();
        string getdate = "select startmindate=DATEADD(mi,750,GETDATE()), startdatemax=DATEADD(dd,90,DATEADD(mi,750,GETDATE())),enddatemax=DATEADD(dd,365,DATEADD(mi,750,GETDATE())),jobexpdate=DATEADD(dd,60,DATEADD(mi,750,GETDATE()))";
        SqlDataAdapter ada = new SqlDataAdapter(getdate, con);
        DataSet ds = new DataSet();
        ada.Fill(ds);
        con.Close();
        try
        {

            if (!ds.Tables[0].Rows.Count.Equals(0))
            {
                string startdatemin = ds.Tables[0].Rows[0]["startmindate"].ToString();
                string startdatemax = ds.Tables[0].Rows[0]["startdatemax"].ToString();
                string enddatemax = ds.Tables[0].Rows[0]["enddatemax"].ToString();
                string jobexpdate = ds.Tables[0].Rows[0]["jobexpdate"].ToString();
                // Giving max and min values to the range validators at run time
                rngone.MinimumValue = Convert.ToDateTime(startdatemin).ToShortDateString();
                rngone.MaximumValue = Convert.ToDateTime(startdatemax).ToShortDateString();
                rngone.ErrorMessage = " Please select from the date" + " " + Convert.ToDateTime(startdatemin).ToShortDateString() + " To " + Convert.ToDateTime(startdatemax).ToShortDateString();
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
        if (!IsPostBack)
        {
            Bindcatdropdown();
            Bindstatedropdown();
            Binddetails();
            ViewState["previouspage"] = Request.UrlReferrer;

        }


    }

    /// <summary>
    /// To bind the existing data in database to edit form inorder to modify
    /// </summary>
    protected void Binddetails()
    {
        try
        {
            string mob_no = string.Empty;
            string id = Convert.ToString(Page.RouteData.Values["id"]);
            SqlCommand cmd = new SqlCommand("viewevent", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (!ds.Tables[0].Rows.Count.Equals(0))
            {
                string cat = ds.Tables[0].Rows[0]["Category"].ToString();

                string subcat = ds.Tables[0].Rows[0]["SubCategory"].ToString();
                string state = ds.Tables[0].Rows[0]["State"].ToString();
                string city = ds.Tables[0].Rows[0]["City"].ToString();
                string type = ds.Tables[0].Rows[0]["evedi_DurationType"].ToString();
                txtarea.Text = ds.Tables[0].Rows[0]["Area"].ToString();
                txtevename.Text = ds.Tables[0].Rows[0]["event_name"].ToString();
                txtven.Text = ds.Tables[0].Rows[0]["event_place"].ToString();

                if (type == "One Day Event")
                {
                    txtone.Visible = true;
                    txtmulti.Visible = false;
                    txtone.Text = ds.Tables[0].Rows[0]["event_startdate"].ToString();

                }
                else
                {
                    txtone.Visible = true;
                    txtmulti.Visible = true;
                    txtone.Text = ds.Tables[0].Rows[0]["event_startdate"].ToString();
                    txtmulti.Text = ds.Tables[0].Rows[0]["event_enddate"].ToString();
                }


                txtdesc.Text = ds.Tables[0].Rows[0]["event_desc"].ToString();
                txttime.Text = ds.Tables[0].Rows[0]["event_time"].ToString();

                txtadd.Text = ds.Tables[0].Rows[0]["address"].ToString();
                txtlndm.Text = ds.Tables[0].Rows[0]["land_mark"].ToString();
                string Mob = ds.Tables[0].Rows[0]["mob"].ToString();
                string mobile = Mob.Substring(0, 1);
                if (mobile == "-")
                {
                    mob_no = Mob.Substring(3, 10);
                }
                else if (mobile == "0")
                {
                    mob_no = Mob.Substring(1, 10);
                }
                txtmob.Text = mob_no;
                txtph.Text = ds.Tables[0].Rows[0]["landphno"].ToString();
                txtfax.Text = ds.Tables[0].Rows[0]["fax"].ToString();
                txtweb.Text = ds.Tables[0].Rows[0]["Website"].ToString();
                txtcntp.Text = ds.Tables[0].Rows[0]["contact_person"].ToString();
                txtemail.Text = ds.Tables[0].Rows[0]["emailid"].ToString();
                txtpin.Text = ds.Tables[0].Rows[0]["pincode"].ToString();

                // To display the data in the database in a dropdown


                //for (int i = 0; i < ddlcat.Items.Count; i++)
                //{
                //    if (ddlcat.Items[i].Text == cat.ToString())
                //    {
                //        ddlcat.SelectedValue = ddlcat.Items[i].Value;
                //        break;
                //    }
                //    else
                //    {
                //        ddlcat.SelectedIndex = 0;
                //    }
                //}
                //Bindsubcatdropdown(cat);
                // To display the data in the database in a dropdown
                for (int i = 0; i < ddlsubcat.Items.Count; i++)
                {
                    if (ddlsubcat.Items[i].Text == subcat.ToString())
                    {
                        ddlsubcat.SelectedValue = ddlsubcat.Items[i].Value;
                        break;
                    }
                    else
                    {
                        ddlsubcat.SelectedIndex = 0;
                    }
                }
                // To display the data in the database in a dropdown
                for (int i = 0; i < ddlstate.Items.Count; i++)
                {
                    if (ddlstate.Items[i].Text == state.ToString())
                    {
                        ddlstate.SelectedValue = ddlstate.Items[i].Value;
                        break;
                    }
                    else
                    {
                        ddlstate.SelectedIndex = 0;
                    }
                }
                Bindcitydropdown(state);
                // To display the data in the database in a dropdown
                for (int i = 0; i < ddlcity.Items.Count; i++)
                {
                    if (ddlcity.Items[i].Text == city.ToString())
                    {
                        ddlcity.SelectedValue = ddlcity.Items[i].Value;
                        break;
                    }
                    else
                    {
                        ddlcity.SelectedIndex = 0;
                    }
                }



                for (int i = 0; i < ddltyp.Items.Count; i++)
                {
                    if (ddltyp.Items[i].Text == type.ToString())
                    {
                        ddltyp.SelectedValue = ddltyp.Items[i].Value;
                        break;
                    }
                    {
                        ddltyp.SelectedIndex = 0;
                    }
                }
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }

    //protected void ddlcat_selectedindexchanged(object sender, EventArgs e)
    //{
    //    string catg = ddlcat.SelectedItem.ToString();
    //    Bindsubcatdropdown(catg);

    //}

    /// <summary>
    /// To bind the categories from the database to a dropdownlist
    /// </summary>
    protected void Bindcatdropdown()
    {
        try
        {
            
            SqlDataAdapter da = new SqlDataAdapter("select * from subcatageory where maincat='Events'", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.Close();
            ddlsubcat.DataSource = ds;
            ddlsubcat.DataTextField = "cat";
            ddlsubcat.DataValueField = "id";
            ddlsubcat.DataBind();
            ddlsubcat.Items.Insert(0, "select");
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }


    }

    /// <summary>
    /// To bind the subcategories from the database to a dropdoenlist
    /// </summary>
    //protected void Bindsubcatdropdown(string catg)
    //{
    //    con.Open();
    //    SqlDataAdapter da = new SqlDataAdapter("Select cat from subcatageory where maincat='" + catg + "'", con);
    //    DataSet ds = new DataSet();
    //    da.Fill(ds, "subcategeory");

    //    con.Close();
    //    ddlsubcat.DataSource = ds.Tables["subcategeory"];
    //    ddlsubcat.DataTextField = "cat";
    //    ddlsubcat.DataValueField = "cat";
    //    ddlsubcat.DataBind();
    //    ddlsubcat.Items.Insert(0, new ListItem("select", "0"));
    //}

    /// <summary>
    /// To bind the state from the database to a dropdoenlist
    /// </summary>
    protected void Bindstatedropdown()
    {
        try
        {
            SqlDataAdapter da = new SqlDataAdapter("select state_name from states", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.Close();
            ddlstate.DataSource = ds;
            ddlstate.DataTextField = "state_name";
            ddlstate.DataValueField = "state_name";
            ddlstate.DataBind();
            ddlstate.Items.Insert(0, "select");
            ddlcity.Items.Insert(0, "select");
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }


    }

    /// <summary>
    /// To bind the cities from the database to a dropdoenlist
    /// </summary>
    protected void Bindcitydropdown(string statename)
    {
        try
        {
           
            SqlDataAdapter da = new SqlDataAdapter("select city_name from cities where state_name='" + statename + "'", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.Close();
            ddlcity.DataSource = ds;
            ddlcity.DataTextField = "city_name";
            ddlcity.DataValueField = "city_name";
            ddlcity.DataBind();
            ddlcity.Items.Insert(0, "select");
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }

    }
    protected void ddlstate_selectedindexchanged(object sender, EventArgs e)
    {
        try
        {
            string statename = ddlstate.SelectedItem.ToString();
            Bindcitydropdown(statename);
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }


    }
    protected void ddltyp_selectedindexchanged(object sender, EventArgs e)
    {
        try
        {
            if (ddltyp.SelectedIndex == 1)
            {
                txtone.Visible = true;
                txtmulti.Visible = false;
            }
            else
            {
                txtone.Visible = true;
                txtmulti.Visible = true;
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }

    }
    protected void cancel_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            if (ViewState["previouspage"] != null)
               redirect(ViewState["previouspage"].ToString(),false);
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }

    /// <summary>
    /// To Store the modified data into the database
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void updatebtn_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            ccjoin.ValidateCaptcha(txtvid.Text);
            // If condition executes when you entered invalid capcha otherwise executes else statements
            if (!ccjoin.UserValidated)
            {
                strScript = "alert('You have to enter as like in the image.');";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                //Inform user that his input was wrong ...
                txtvid.Text = "";
                return;

            }
            else
            {
                string userid = Convert.ToString(Session["USERID"]);
                string id = Convert.ToString(Page.RouteData.Values["id"]);
                DateTime pdate = DateTime.Now.Date;
                DateTime edate = DateTime.Now.Date.AddDays(Convert.ToDouble(30));
                SqlCommand cmd = new SqlCommand("updateevent", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.CommandText = "postjob";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);

                cmd.Parameters.AddWithValue("@UserLoginId", SqlDbType.NVarChar).Value = userid;
                cmd.Parameters.AddWithValue("@Category", SqlDbType.NVarChar).Value = "Events";

                cmd.Parameters.AddWithValue("@SubCategory", ddlsubcat.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@State", ddlstate.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@City", ddlcity.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@Area", txtarea.Text);
                cmd.Parameters.AddWithValue("@event_name", txtevename.Text);
                cmd.Parameters.AddWithValue("@event_place", txtven.Text);
                cmd.Parameters.AddWithValue("@evedi_DurationType", ddltyp.SelectedItem.ToString());
                try
                {
                    if (ddltyp.SelectedIndex == 1)
                    {
                        txtone.Visible = true;
                        txtmulti.Visible = false;
                        cmd.Parameters.AddWithValue("@event_startdate", txtone.Text);
                        cmd.Parameters.AddWithValue("@event_enddate", SqlDbType.NVarChar).Value = "";
                    }
                    else
                    {
                        txtone.Visible = true;
                        txtmulti.Visible = false;
                        cmd.Parameters.AddWithValue("@event_startdate", txtone.Text);
                        cmd.Parameters.AddWithValue("@event_enddate", txtmulti.Text);
                    }
                }
                catch (Exception ex)
                {
                    obj.insert_exception(ex, excep_page);
                    Response.Redirect("HttpErrorPage.aspx");
                }
                cmd.Parameters.AddWithValue("@event_desc", txtdesc.Text);
                cmd.Parameters.AddWithValue("@event_time", txttime.Text);
                cmd.Parameters.AddWithValue("@address", txtadd.Text);
                cmd.Parameters.AddWithValue("@land_mark", txtlndm.Text);
                cmd.Parameters.AddWithValue("@mob", txtcode.Text + txtmob.Text);
                cmd.Parameters.AddWithValue("@landphno", txtph.Text);
                cmd.Parameters.AddWithValue("@fax", txtfax.Text);
                cmd.Parameters.AddWithValue("@Website", txtweb.Text);
                cmd.Parameters.AddWithValue("@ApprovedStatus", SqlDbType.Int).Value = 3;
                cmd.Parameters.AddWithValue("@contact_person", txtcntp.Text);
                cmd.Parameters.AddWithValue("@emailid", txtemail.Text);
                cmd.Parameters.AddWithValue("@pincode", txtpin.Text);
                cmd.Parameters.AddWithValue("@postdate", SqlDbType.DateTime).Value = pdate;
                cmd.Parameters.AddWithValue("@expdate", SqlDbType.DateTime).Value = edate;

                if (photo.HasFile)
                {
                    try
                    {
                        string filename = System.IO.Path.GetFileName(photo.PostedFile.FileName);
                        string contenttype = photo.PostedFile.ContentType;
                        photo.PostedFile.SaveAs(Server.MapPath("Event_Images/" + filename));
                        using (System.Drawing.Image Img = System.Drawing.Image.FromFile(Server.MapPath("Event_Images/" + filename)))
                        {

                            if (photo.PostedFile.ContentLength <= 100000 && Img.Width == 250 && Img.Height == 300)
                            {

                                cmd.Parameters.AddWithValue("@ImageName", filename);
                                cmd.Parameters.AddWithValue("@ImageContentType", contenttype);
                                cmd.Parameters.AddWithValue("@Status", SqlDbType.Int).Value = 3;
                                cmd.Parameters.AddWithValue("@By_EmailId", userid);
                                cmd.Parameters.AddWithValue("@Date", pdate);
                                cmd.Parameters.AddWithValue("@DataId", id);
                                try
                                {
                                    con.Open();
                                    cmd.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    obj.insert_exception(ex, excep_page);
                                    Response.Redirect("HttpErrorPage.aspx");
                                }
                                finally
                                {
                                    cmd.Dispose();
                                    con.Close();
                                }
                                SendMail(userid);
                                strScript = "alert('Thank you! You have successfully Updated the event.');";
                                Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                                //ddlcat.SelectedIndex = 0;
                                ddlsubcat.SelectedIndex = 0;
                                ddlstate.SelectedIndex = 0;
                                ddlcity.SelectedIndex = 0;
                                ddltyp.SelectedIndex = 0;
                                txtarea.Text = "";
                                txtcntp.Text = "";
                                txtdesc.Text = "";
                                txtemail.Text = "";
                                txtfax.Text = "";
                                txtmob.Text = "";
                                txtph.Text = "";
                                txtpin.Text = "";
                                txtweb.Text = "";
                                //txtsub.Visible = false;
                                txtone.Visible = false;
                                txtmulti.Visible = false;
                                txttime.Text = "";
                                txtevename.Text = "";
                                txtven.Text = "";
                                txtvid.Text = "";
                                txtadd.Text = "";
                                txtlndm.Text = "";
                            }
                            else
                            {

                                strScript = "alert('sorry! Secified invitation cannot be uploaded , make sure that size is lessthan 100kb width=250 and height=300.');";
                                Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                                //cmd.Parameters.AddWithValue("@ImageName", SqlDbType.NVarChar).Value = "null";
                                //cmd.Parameters.AddWithValue("@ImageContentType", SqlDbType.NVarChar).Value = "null";
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        obj.insert_exception(ex, excep_page);
                        Response.Redirect("HttpErrorPage.aspx");
                    }
                }
                else
                {
                    try
                    {
                        string subcat = ddlsubcat.SelectedItem.Text;
                        if (subcat == "Arts & Crafts")
                        {
                            cmd.Parameters.AddWithValue("@ImageName", SqlDbType.NVarChar).Value = "ArtsandCrafts.png";
                            cmd.Parameters.AddWithValue("@ImageContentType", SqlDbType.NVarChar).Value = "image/x-png";

                        }
                        else if (subcat == "AwardCeremonies")
                        {
                            cmd.Parameters.AddWithValue("@ImageName", SqlDbType.NVarChar).Value = "AwardCeremonies.png";
                            cmd.Parameters.AddWithValue("@ImageContentType", SqlDbType.NVarChar).Value = "image/x-png";

                        }
                        else if (subcat == "Awards night")
                        {
                            cmd.Parameters.AddWithValue("@ImageName", SqlDbType.NVarChar).Value = "Awards-night.png";
                            cmd.Parameters.AddWithValue("@ImageContentType", SqlDbType.NVarChar).Value = "image/x-png";

                        }
                        else if (subcat == "Beauty pageant")
                        {
                            cmd.Parameters.AddWithValue("@ImageName", SqlDbType.NVarChar).Value = "Beauty-Pageant.png";
                            cmd.Parameters.AddWithValue("@ImageContentType", SqlDbType.NVarChar).Value = "image/x-png";

                        }
                        else if (subcat == "Birthdays")
                        {
                            cmd.Parameters.AddWithValue("@ImageName", SqlDbType.NVarChar).Value = "Birthdays.png";
                            cmd.Parameters.AddWithValue("@ImageContentType", SqlDbType.NVarChar).Value = "image/x-png";

                        }
                        else if (subcat == "Board Meetings")
                        {
                            cmd.Parameters.AddWithValue("@ImageName", SqlDbType.NVarChar).Value = "Board-Meetings.png";
                            cmd.Parameters.AddWithValue("@ImageContentType", SqlDbType.NVarChar).Value = "image/x-png";

                        }
                        else if (subcat == "Business Dinners")
                        {
                            cmd.Parameters.AddWithValue("@ImageName", SqlDbType.NVarChar).Value = "Business-Dinners.png";
                            cmd.Parameters.AddWithValue("@ImageContentType", SqlDbType.NVarChar).Value = "image/x-png";

                        }
                        else if (subcat == "Community")
                        {
                            cmd.Parameters.AddWithValue("@ImageName", SqlDbType.NVarChar).Value = "Community.png";
                            cmd.Parameters.AddWithValue("@ImageContentType", SqlDbType.NVarChar).Value = "image/x-png";

                        }
                        else if (subcat == "Concerts")
                        {
                            cmd.Parameters.AddWithValue("@ImageName", SqlDbType.NVarChar).Value = "Concerts.png";
                            cmd.Parameters.AddWithValue("@ImageContentType", SqlDbType.NVarChar).Value = "image/x-png";

                        }
                        else if (subcat == "Conferences")
                        {
                            cmd.Parameters.AddWithValue("@ImageName", SqlDbType.NVarChar).Value = "Conferences1.png";
                            cmd.Parameters.AddWithValue("@ImageContentType", SqlDbType.NVarChar).Value = "image/x-png";

                        }
                        else if (subcat == "Educational tours")
                        {
                            cmd.Parameters.AddWithValue("@ImageName", SqlDbType.NVarChar).Value = "Educational-tours.png";
                            cmd.Parameters.AddWithValue("@ImageContentType", SqlDbType.NVarChar).Value = "image/x-png";

                        }
                        else if (subcat == "Executive Retreats")
                        {
                            cmd.Parameters.AddWithValue("@ImageName", SqlDbType.NVarChar).Value = "Executive-Retreats.png";
                            cmd.Parameters.AddWithValue("@ImageContentType", SqlDbType.NVarChar).Value = "image/x-png";

                        }
                        else if (subcat == "Fashion shows")
                        {
                            cmd.Parameters.AddWithValue("@ImageName", SqlDbType.NVarChar).Value = "Fashion-shows.png";
                            cmd.Parameters.AddWithValue("@ImageContentType", SqlDbType.NVarChar).Value = "image/x-png";

                        }
                        else if (subcat == "Food & Drinks")
                        {
                            cmd.Parameters.AddWithValue("@ImageName", SqlDbType.NVarChar).Value = "Food-&-Drinks.png";
                            cmd.Parameters.AddWithValue("@ImageContentType", SqlDbType.NVarChar).Value = "image/x-png";

                        }
                        else if (subcat == "Golf Events")
                        {
                            cmd.Parameters.AddWithValue("@ImageName", SqlDbType.NVarChar).Value = "Golf-Events.png";
                            cmd.Parameters.AddWithValue("@ImageContentType", SqlDbType.NVarChar).Value = "image/x-png";

                        }
                        else if (subcat == "Graduations")
                        {
                            cmd.Parameters.AddWithValue("@ImageName", SqlDbType.NVarChar).Value = "Graduations.png";
                            cmd.Parameters.AddWithValue("@ImageContentType", SqlDbType.NVarChar).Value = "image/x-png";

                        }
                        else if (subcat == "Holiday Occasions")
                        {
                            cmd.Parameters.AddWithValue("@ImageName", SqlDbType.NVarChar).Value = "Holiday-Occasions.png";
                            cmd.Parameters.AddWithValue("@ImageContentType", SqlDbType.NVarChar).Value = "image/x-png";

                        }
                        else if (subcat == "Incentive Events")
                        {
                            cmd.Parameters.AddWithValue("@ImageName", SqlDbType.NVarChar).Value = "Incentive-Events.png";
                            cmd.Parameters.AddWithValue("@ImageContentType", SqlDbType.NVarChar).Value = "image/x-png";

                        }
                        else if (subcat == "Job Fairs")
                        {
                            cmd.Parameters.AddWithValue("@ImageName", SqlDbType.NVarChar).Value = "Job-Fairs.png";
                            cmd.Parameters.AddWithValue("@ImageContentType", SqlDbType.NVarChar).Value = "image/x-png";

                        }
                        else if (subcat == "Music")
                        {
                            cmd.Parameters.AddWithValue("@ImageName", SqlDbType.NVarChar).Value = "Music-1.png";
                            cmd.Parameters.AddWithValue("@ImageContentType", SqlDbType.NVarChar).Value = "image/x-png";

                        }
                        else if (subcat == "Networking Events")
                        {
                            cmd.Parameters.AddWithValue("@ImageName", SqlDbType.NVarChar).Value = "Networking-Events.png";
                            cmd.Parameters.AddWithValue("@ImageContentType", SqlDbType.NVarChar).Value = "image/x-png";

                        }
                        else if (subcat == "Opening Ceremonies")
                        {
                            cmd.Parameters.AddWithValue("@ImageName", SqlDbType.NVarChar).Value = "Opening-Cermonies.png";
                            cmd.Parameters.AddWithValue("@ImageContentType", SqlDbType.NVarChar).Value = "image/x-png";

                        }
                        else if (subcat == "Political rallies")
                        {
                            cmd.Parameters.AddWithValue("@ImageName", SqlDbType.NVarChar).Value = "Political-rallies.png";
                            cmd.Parameters.AddWithValue("@ImageContentType", SqlDbType.NVarChar).Value = "image/x-png";

                        }
                        else if (subcat == "Product Launches")
                        {
                            cmd.Parameters.AddWithValue("@ImageName", SqlDbType.NVarChar).Value = "Product-Launches.png";
                            cmd.Parameters.AddWithValue("@ImageContentType", SqlDbType.NVarChar).Value = "image/x-png";

                        }
                        else if (subcat == "Sales And Exhibitions")
                        {
                            cmd.Parameters.AddWithValue("@ImageName", SqlDbType.NVarChar).Value = "Sales-And-Exhibitions.png";
                            cmd.Parameters.AddWithValue("@ImageContentType", SqlDbType.NVarChar).Value = "image/x-png";

                        }
                        else if (subcat == "Seminars")
                        {
                            cmd.Parameters.AddWithValue("@ImageName", SqlDbType.NVarChar).Value = "Seminars.png";
                            cmd.Parameters.AddWithValue("@ImageContentType", SqlDbType.NVarChar).Value = "image/x-png";

                        }
                        else if (subcat == "Shareholder Meetings")
                        {
                            cmd.Parameters.AddWithValue("@ImageName", SqlDbType.NVarChar).Value = "Shareholder-Meetings.png";
                            cmd.Parameters.AddWithValue("@ImageContentType", SqlDbType.NVarChar).Value = "image/x-png";

                        }
                        else if (subcat == "Sports events")
                        {
                            cmd.Parameters.AddWithValue("@ImageName", SqlDbType.NVarChar).Value = "Sports-events.png";
                            cmd.Parameters.AddWithValue("@ImageContentType", SqlDbType.NVarChar).Value = "image/x-png";

                        }
                        else if (subcat == "Team Building Events")
                        {
                            cmd.Parameters.AddWithValue("@ImageName", SqlDbType.NVarChar).Value = "Team-Building-Events.png";
                            cmd.Parameters.AddWithValue("@ImageContentType", SqlDbType.NVarChar).Value = "image/x-png";

                        }
                        else if (subcat == "Theatre")
                        {
                            cmd.Parameters.AddWithValue("@ImageName", SqlDbType.NVarChar).Value = "Theatre.png";
                            cmd.Parameters.AddWithValue("@ImageContentType", SqlDbType.NVarChar).Value = "image/x-png";

                        }
                        else if (subcat == "Theme Parties")
                        {
                            cmd.Parameters.AddWithValue("@ImageName", SqlDbType.NVarChar).Value = "Theme-Parties.png";
                            cmd.Parameters.AddWithValue("@ImageContentType", SqlDbType.NVarChar).Value = "image/x-png";

                        }
                        else if (subcat == "Trade Fairs")
                        {
                            cmd.Parameters.AddWithValue("@ImageName", SqlDbType.NVarChar).Value = "Trade-Fairs.png";
                            cmd.Parameters.AddWithValue("@ImageContentType", SqlDbType.NVarChar).Value = "image/x-png";

                        }
                        else if (subcat == "VIP Events")
                        {
                            cmd.Parameters.AddWithValue("@ImageName", SqlDbType.NVarChar).Value = "VIP-Events.png";
                            cmd.Parameters.AddWithValue("@ImageContentType", SqlDbType.NVarChar).Value = "image/x-png";

                        }
                        else if (subcat == "Wedding Anniversaries")
                        {
                            cmd.Parameters.AddWithValue("@ImageName", SqlDbType.NVarChar).Value = "Wedding-Anniversaries.png";
                            cmd.Parameters.AddWithValue("@ImageContentType", SqlDbType.NVarChar).Value = "image/x-png";

                        }
                        else if (subcat == "Weddings")
                        {
                            cmd.Parameters.AddWithValue("@ImageName", SqlDbType.NVarChar).Value = "Weddings.png";
                            cmd.Parameters.AddWithValue("@ImageContentType", SqlDbType.NVarChar).Value = "image/x-png";

                        }

                        cmd.Parameters.AddWithValue("@Status", SqlDbType.Int).Value = 3;
                        cmd.Parameters.AddWithValue("@By_EmailId", userid);
                        cmd.Parameters.AddWithValue("@Date", pdate);
                        cmd.Parameters.AddWithValue("@DataId", id);
                        try
                        {
                            con.Open();
                            cmd.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            obj.insert_exception(ex, excep_page);
                            Response.Redirect("HttpErrorPage.aspx");
                        }
                        finally
                        {
                            cmd.Dispose();
                            con.Close();
                        }
                        SendMail(userid);
                        strScript = "alert('Thank you! You have successfully Updated the event.');location.replace('EventsView')";
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                        //ddlcat.SelectedIndex = 0;
                        ddlsubcat.SelectedIndex = 0;
                        ddlstate.SelectedIndex = 0;
                        ddlcity.SelectedIndex = 0;
                        ddltyp.SelectedIndex = 0;
                        txtarea.Text = "";
                        txtcntp.Text = "";
                        txtdesc.Text = "";
                        txtemail.Text = "";
                        txtfax.Text = "";
                        txtmob.Text = "";
                        txtph.Text = "";
                        txtpin.Text = "";
                        txtweb.Text = "";
                        //txtsub.Visible = false;
                        txtone.Visible = false;
                        txtmulti.Visible = false;
                        txttime.Text = "";
                        txtevename.Text = "";
                        txtven.Text = "";
                        txtvid.Text = "";
                        txtadd.Text = "";
                        txtlndm.Text = "";

                    }
                    catch (Exception ex)
                    {
                        obj.insert_exception(ex, excep_page);
                        Response.Redirect("HttpErrorPage.aspx");
                    }

                }

            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }

    }

    /// <summary>
    /// Intimating about the updated event to the authenticated user via email
    /// </summary>
    /// <param name="userid"></param>
    public void SendMail(string userid)
    {
        try
        {

            string Msg = "";
            MailMessage mm = new MailMessage();
            mm.From = new MailAddress("info@justcalluz.com");
            //mm.To = "test_indus@yahoo.com";
            mm.To.Add(userid);
            Msg += "You have successfully updated the event , Please wait for the approval . " + "<br>For further details please visit our site www.justcalluz.com or call on +9166136226." +
                        "<br><br>Warm Regards," +
                        "<br> Team JustCalluz"; ;
            mm.Subject = "Intimation about Updated Event";
            mm.IsBodyHtml = true;
            mm.Body = Msg;
            SmtpClient smtp = new SmtpClient();
            smtp.Send(mm);
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }


    }
    public void redirect(string url, bool val)
    {
        if (!val)
        {
            HttpContext.Current.Response.Redirect(url, false);
            HttpContext.Current.ApplicationInstance.CompleteRequest();
        }
        else
        {
            HttpContext.Current.Server.ClearError();
            HttpContext.Current.Response.Redirect(url, false);
            HttpContext.Current.Server.ClearError();
        }

    }

}
