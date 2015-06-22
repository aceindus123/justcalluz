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
/// To store the entered details into database when post button is clicked , Calculating and displaying overall rating and sending mail for intimation 
/// </summary>

public partial class post_events : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    string strScript = string.Empty;
    InsertData obj = new InsertData();
    static string excep_page = "post_event.aspx";
    /// <summary>
    /// while posting an event , to check whether user is logged in or not if so , is he registered as Business type ? 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            ccjoin.Visible = true;
            string userid = Convert.ToString(Session["USERID"]);
            string regtype = Convert.ToString(Session["RegType"]);
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


            //Applying validations on dates
            try
            {
                con.Open();
                string getdate = "select startmindate=DATEADD(mi,750,GETDATE()), startdatemax=DATEADD(dd,90,DATEADD(mi,750,GETDATE())),enddatemax=DATEADD(dd,365,DATEADD(mi,750,GETDATE())),jobexpdate=DATEADD(dd,60,DATEADD(mi,750,GETDATE()))";
                SqlDataAdapter ada = new SqlDataAdapter(getdate, con);
                DataSet ds = new DataSet();
                ada.Fill(ds);
                con.Close();
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
                   
                    rngmulti.MinimumValue = Convert.ToDateTime(startdatemin).ToShortDateString();
                    rngmulti.MaximumValue = Convert.ToDateTime(enddatemax).ToShortDateString();
                    rngmulti.ErrorMessage = " You select the date upto " + Convert.ToDateTime(enddatemax).ToShortDateString() + " From " + Convert.ToDateTime(startdatemin).ToShortDateString();



                }


                if (!IsPostBack)
                {
                    Bindcatdropdown();
                    Bindstatedropdown();


                }
            }
            catch (Exception ex)
            {
                obj.insert_exception(ex, excep_page);
                Response.Redirect("HttpErrorPage.aspx");
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }

    }
    /// <summary>
    /// To bind the category dropdownlist from the database
    /// </summary>

    protected void Bindcatdropdown()
    {
        try
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from subcatageory where maincat='Events'", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
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
    /// To bind the state dropdownlist from the database
    /// </summary>
    protected void Bindstatedropdown()
    {
        try
        {

           
            SqlDataAdapter da = new SqlDataAdapter("select state_name from states", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
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
    protected void ddlstate_selectedindexchanged(object sender, EventArgs e)
    {
        try
        {
            string statename = ddlstate.SelectedItem.ToString();
            SqlDataAdapter da = new SqlDataAdapter("select city_name from cities where state_name='" + statename + "'", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
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
    /// <summary>
    /// To store the posted event into the database
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>

    protected void postbtn_Click(object sender, ImageClickEventArgs e)
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
                string subcat = ddlsubcat.SelectedItem.ToString();
                DateTime pdate = DateTime.Now.Date;
                DateTime edate = DateTime.Now.Date.AddDays(Convert.ToDouble(30));
               // con.Open();
                SqlCommand cmd = new SqlCommand("post_event", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.CommandText = "postjob";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@module", SqlDbType.NVarChar).Value = "Events";
                cmd.Parameters.AddWithValue("@UserLoginId", SqlDbType.NVarChar).Value = userid;
                cmd.Parameters.AddWithValue("@Category", SqlDbType.NVarChar).Value = "Events";
                cmd.Parameters.AddWithValue("@SubCategory", ddlsubcat.SelectedItem.ToString());
                //if (ddlsubcat.SelectedValue == "Others")
                //{
                //    cmd.Parameters.AddWithValue("@Other_SubCat", txtsub.Text);
                //}
                //else
                //{
                //    cmd.Parameters.AddWithValue("@Other_SubCat", SqlDbType.NVarChar).Value = "null";
                //}
                ////cmd.Parameters.AddWithValue("@SubCategory", ddlsubcat.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@State", ddlstate.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@City", ddlcity.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@Area", txtarea.Text);
                cmd.Parameters.AddWithValue("@event_name", txtevename.Text);
                cmd.Parameters.AddWithValue("@event_place", txtven.Text);
                cmd.Parameters.AddWithValue("@evedi_DurationType", ddltyp.SelectedItem.ToString());
                if (ddltyp.SelectedIndex == 1)
                {
                    cmd.Parameters.AddWithValue("@event_startdate", txtone.Text);
                    cmd.Parameters.AddWithValue("@event_enddate", SqlDbType.DateTime).Value = DBNull.Value;
                }
                else
                {

                    cmd.Parameters.AddWithValue("@event_startdate", txtone.Text);
                    cmd.Parameters.AddWithValue("@event_enddate", txtmulti.Text);
                }
                cmd.Parameters.AddWithValue("@event_desc", txtdesc.Text);
                cmd.Parameters.AddWithValue("@event_time", txttime.Text);
                cmd.Parameters.AddWithValue("@address", txtadd.Text);
                cmd.Parameters.AddWithValue("@land_mark", txtlndm.Text);
                cmd.Parameters.AddWithValue("@mob", txtcode.Text + txtmob.Text);
                cmd.Parameters.AddWithValue("@landphno", txtph.Text);
                cmd.Parameters.AddWithValue("@fax", txtfax.Text);
                cmd.Parameters.AddWithValue("@Website", txtweb.Text);
                cmd.Parameters.AddWithValue("@ApprovedStatus", SqlDbType.Int).Value = 0;
                cmd.Parameters.AddWithValue("@contact_person", txtcntp.Text);
                cmd.Parameters.AddWithValue("@emailid", txtemail.Text);
                cmd.Parameters.AddWithValue("@pincode", txtpin.Text);
                cmd.Parameters.AddWithValue("@postdate", SqlDbType.DateTime).Value = pdate;
                cmd.Parameters.AddWithValue("@expdate", SqlDbType.DateTime).Value = edate;

                if (photo.HasFile)
                
                    if (photo.PostedFile.ContentLength <= 100000)
                    {
                        string filename = System.IO.Path.GetFileName(photo.PostedFile.FileName);
                        string contenttype = photo.PostedFile.ContentType;
                        photo.PostedFile.SaveAs(Server.MapPath("Event_Images/" + filename));
                        using (System.Drawing.Image Img = System.Drawing.Image.FromFile(Server.MapPath("Event_Images/" + filename)))
                        {

                            if (Img.Width == 250 && Img.Height == 300)
                            {

                                cmd.Parameters.AddWithValue("@ImageName", filename);
                                cmd.Parameters.AddWithValue("@ImageContentType", contenttype);
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
                                strScript = "alert('Thank you! You have successfully posted the event.');";
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
                                txtone.Visible = false;
                                txtmulti.Visible = true;
                                txttime.Text = "";
                                txtevename.Text = "";
                                txtven.Text = "";
                                txtvid.Text = "";
                                txtadd.Text = "";
                                txtlndm.Text = "";
                            }
                            else
                            {

                                strScript = "alert('sorry! Secified invitation cannot be uploaded , make sure that width=250 and height=300.');";
                                Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                                //cmd.Parameters.AddWithValue("@ImageName", SqlDbType.NVarChar).Value = "null";
                                //cmd.Parameters.AddWithValue("@ImageContentType", SqlDbType.NVarChar).Value = "null";
                            }
                        }

                    }
                   else
                    {

                        strScript = "alert('sorry! Make sure that the invitation should be of size lessthan 100kb.');";
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                        //cmd.Parameters.AddWithValue("@ImageName", SqlDbType.NVarChar).Value = "null";
                        //cmd.Parameters.AddWithValue("@ImageContentType", SqlDbType.NVarChar).Value = "null";
                    }
                else
                {
                    
                        if (subcat == "Arts & Crafts")
                        {
                            con.Open();
                            cmd.Parameters.AddWithValue("@ImageName", SqlDbType.NVarChar).Value = "ArtsandCrafts.png";
                            cmd.Parameters.AddWithValue("@ImageContentType", SqlDbType.NVarChar).Value = "image/x-png";
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                        else if (subcat == "AwardCeremonies")
                        {
                            con.Open();
                            cmd.Parameters.AddWithValue("@ImageName", SqlDbType.NVarChar).Value = "AwardCeremonies.png";
                            cmd.Parameters.AddWithValue("@ImageContentType", SqlDbType.NVarChar).Value = "image/x-png";
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                        else if (subcat == "Awards night")
                        {
                            con.Open();
                            cmd.Parameters.AddWithValue("@ImageName", SqlDbType.NVarChar).Value = "Awards-night.png";
                            cmd.Parameters.AddWithValue("@ImageContentType", SqlDbType.NVarChar).Value = "image/x-png";
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                        else if (subcat == "Beauty pageant")
                        {
                            con.Open();
                            cmd.Parameters.AddWithValue("@ImageName", SqlDbType.NVarChar).Value = "Beauty-Pageant.png";
                            cmd.Parameters.AddWithValue("@ImageContentType", SqlDbType.NVarChar).Value = "image/x-png";
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                        else if (subcat == "Birthdays")
                        {
                            con.Open();
                            cmd.Parameters.AddWithValue("@ImageName", SqlDbType.NVarChar).Value = "Birthdays.png";
                            cmd.Parameters.AddWithValue("@ImageContentType", SqlDbType.NVarChar).Value = "image/x-png";
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                        else if (subcat == "Board Meetings")
                        {
                            con.Open();
                            cmd.Parameters.AddWithValue("@ImageName", SqlDbType.NVarChar).Value = "Board-Meetings.png";
                            cmd.Parameters.AddWithValue("@ImageContentType", SqlDbType.NVarChar).Value = "image/x-png";
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                        else if (subcat == "Business Dinners")
                        {
                            con.Open();
                            cmd.Parameters.AddWithValue("@ImageName", SqlDbType.NVarChar).Value = "Business-Dinners.png";
                            cmd.Parameters.AddWithValue("@ImageContentType", SqlDbType.NVarChar).Value = "image/x-png";
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                        else if (subcat == "Community")
                        {
                            con.Open();
                            cmd.Parameters.AddWithValue("@ImageName", SqlDbType.NVarChar).Value = "Community.png";
                            cmd.Parameters.AddWithValue("@ImageContentType", SqlDbType.NVarChar).Value = "image/x-png";
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                        else if (subcat == "Concerts")
                        {
                            con.Open();
                            cmd.Parameters.AddWithValue("@ImageName", SqlDbType.NVarChar).Value = "Concerts.png";
                            cmd.Parameters.AddWithValue("@ImageContentType", SqlDbType.NVarChar).Value = "image/x-png";
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                        else if (subcat == "Conferences")
                        {
                            con.Open();
                            cmd.Parameters.AddWithValue("@ImageName", SqlDbType.NVarChar).Value = "Conferences1.png";
                            cmd.Parameters.AddWithValue("@ImageContentType", SqlDbType.NVarChar).Value = "image/x-png";
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                        else if (subcat == "Educational tours")
                        {
                            con.Open();
                            cmd.Parameters.AddWithValue("@ImageName", SqlDbType.NVarChar).Value = "Educational-tours.png";
                            cmd.Parameters.AddWithValue("@ImageContentType", SqlDbType.NVarChar).Value = "image/x-png";
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                        else if (subcat == "Executive Retreats")
                        {
                            con.Open();
                            cmd.Parameters.AddWithValue("@ImageName", SqlDbType.NVarChar).Value = "Executive-Retreats.png";
                            cmd.Parameters.AddWithValue("@ImageContentType", SqlDbType.NVarChar).Value = "image/x-png";
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                        else if (subcat == "Fashion shows")
                        {
                            con.Open();
                            cmd.Parameters.AddWithValue("@ImageName", SqlDbType.NVarChar).Value = "Fashion-shows.png";
                            cmd.Parameters.AddWithValue("@ImageContentType", SqlDbType.NVarChar).Value = "image/x-png";
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                        else if (subcat == "Food & Drinks")
                        {
                            con.Open();
                            cmd.Parameters.AddWithValue("@ImageName", SqlDbType.NVarChar).Value = "Food-&-Drinks.png";
                            cmd.Parameters.AddWithValue("@ImageContentType", SqlDbType.NVarChar).Value = "image/x-png";
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                        else if (subcat == "Golf Events")
                        {
                            con.Open();
                            cmd.Parameters.AddWithValue("@ImageName", SqlDbType.NVarChar).Value = "Golf-Events.png";
                            cmd.Parameters.AddWithValue("@ImageContentType", SqlDbType.NVarChar).Value = "image/x-png";
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                        else if (subcat == "Graduations")
                        {
                            con.Open();
                            cmd.Parameters.AddWithValue("@ImageName", SqlDbType.NVarChar).Value = "Graduations.png";
                            cmd.Parameters.AddWithValue("@ImageContentType", SqlDbType.NVarChar).Value = "image/x-png";
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                        else if (subcat == "Holiday Occasions")
                        {
                            con.Open();
                            cmd.Parameters.AddWithValue("@ImageName", SqlDbType.NVarChar).Value = "Holiday-Occasions.png";
                            cmd.Parameters.AddWithValue("@ImageContentType", SqlDbType.NVarChar).Value = "image/x-png";
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                        else if (subcat == "Incentive Events")
                        {
                            con.Open();
                            cmd.Parameters.AddWithValue("@ImageName", SqlDbType.NVarChar).Value = "Incentive-Events.png";
                            cmd.Parameters.AddWithValue("@ImageContentType", SqlDbType.NVarChar).Value = "image/x-png";
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                        else if (subcat == "Job Fairs")
                        {
                            con.Open();
                            cmd.Parameters.AddWithValue("@ImageName", SqlDbType.NVarChar).Value = "Job-Fairs.png";
                            cmd.Parameters.AddWithValue("@ImageContentType", SqlDbType.NVarChar).Value = "image/x-png";
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                        else if (subcat == "Music")
                        {
                            con.Open();
                            cmd.Parameters.AddWithValue("@ImageName", SqlDbType.NVarChar).Value = "Music-1.png";
                            cmd.Parameters.AddWithValue("@ImageContentType", SqlDbType.NVarChar).Value = "image/x-png";
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                        else if (subcat == "Networking Events")
                        {
                            con.Open();
                            cmd.Parameters.AddWithValue("@ImageName", SqlDbType.NVarChar).Value = "Networking-Events.png";
                            cmd.Parameters.AddWithValue("@ImageContentType", SqlDbType.NVarChar).Value = "image/x-png";
                            cmd.ExecuteNonQuery();
                        }
                        else if (subcat == "Opening Ceremonies")
                        {
                            con.Open();
                            cmd.Parameters.AddWithValue("@ImageName", SqlDbType.NVarChar).Value = "Opening-Cermonies.png";
                            cmd.Parameters.AddWithValue("@ImageContentType", SqlDbType.NVarChar).Value = "image/x-png";
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                        else if (subcat == "Political rallies")
                        {
                            con.Open();
                            cmd.Parameters.AddWithValue("@ImageName", SqlDbType.NVarChar).Value = "Political-rallies.png";
                            cmd.Parameters.AddWithValue("@ImageContentType", SqlDbType.NVarChar).Value = "image/x-png";
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                        else if (subcat == "Product Launches")
                        {
                            con.Open();
                            cmd.Parameters.AddWithValue("@ImageName", SqlDbType.NVarChar).Value = "Product-Launches.png";
                            cmd.Parameters.AddWithValue("@ImageContentType", SqlDbType.NVarChar).Value = "image/x-png";
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                        else if (subcat == "Sales And Exhibitions")
                        {
                            con.Open();
                            cmd.Parameters.AddWithValue("@ImageName", SqlDbType.NVarChar).Value = "Sales-And-Exhibitions.png";
                            cmd.Parameters.AddWithValue("@ImageContentType", SqlDbType.NVarChar).Value = "image/x-png";
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                        else if (subcat == "Seminars")
                        {
                            con.Open();
                            cmd.Parameters.AddWithValue("@ImageName", SqlDbType.NVarChar).Value = "Seminars.png";
                            cmd.Parameters.AddWithValue("@ImageContentType", SqlDbType.NVarChar).Value = "image/x-png";
                            cmd.ExecuteNonQuery();
                        }
                        else if (subcat == "Shareholder Meetings")
                        {
                            con.Open();
                            cmd.Parameters.AddWithValue("@ImageName", SqlDbType.NVarChar).Value = "Shareholder-Meetings.png";
                            cmd.Parameters.AddWithValue("@ImageContentType", SqlDbType.NVarChar).Value = "image/x-png";
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                        else if (subcat == "Sports events")
                        {
                            con.Open();
                            cmd.Parameters.AddWithValue("@ImageName", SqlDbType.NVarChar).Value = "Sports-events.png";
                            cmd.Parameters.AddWithValue("@ImageContentType", SqlDbType.NVarChar).Value = "image/x-png";
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                        else if (subcat == "Team Building Events")
                        {
                            con.Open();
                            cmd.Parameters.AddWithValue("@ImageName", SqlDbType.NVarChar).Value = "Team-Building-Events.png";
                            cmd.Parameters.AddWithValue("@ImageContentType", SqlDbType.NVarChar).Value = "image/x-png";
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                        else if (subcat == "Theatre")
                        {
                            con.Open();
                            cmd.Parameters.AddWithValue("@ImageName", SqlDbType.NVarChar).Value = "Theatre.png";
                            cmd.Parameters.AddWithValue("@ImageContentType", SqlDbType.NVarChar).Value = "image/x-png";
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                        else if (subcat == "Theme Parties")
                        {
                            con.Open();
                            cmd.Parameters.AddWithValue("@ImageName", SqlDbType.NVarChar).Value = "Theme-Parties.png";
                            cmd.Parameters.AddWithValue("@ImageContentType", SqlDbType.NVarChar).Value = "image/x-png";
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                        else if (subcat == "Trade Fairs")
                        {
                            con.Open();
                            cmd.Parameters.AddWithValue("@ImageName", SqlDbType.NVarChar).Value = "Trade-Fairs.png";
                            cmd.Parameters.AddWithValue("@ImageContentType", SqlDbType.NVarChar).Value = "image/x-png";
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                        else if (subcat == "VIP Events")
                        {
                            con.Open();
                            cmd.Parameters.AddWithValue("@ImageName", SqlDbType.NVarChar).Value = "VIP-Events.png";
                            cmd.Parameters.AddWithValue("@ImageContentType", SqlDbType.NVarChar).Value = "image/x-png";
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                        else if (subcat == "Wedding Anniversaries")
                        {
                            con.Open();
                            cmd.Parameters.AddWithValue("@ImageName", SqlDbType.NVarChar).Value = "Wedding-Anniversaries.png";
                            cmd.Parameters.AddWithValue("@ImageContentType", SqlDbType.NVarChar).Value = "image/x-png";
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                        else if (subcat == "Weddings")
                        {
                            con.Open();
                            cmd.Parameters.AddWithValue("@ImageName", SqlDbType.NVarChar).Value = "Weddings.png";
                            cmd.Parameters.AddWithValue("@ImageContentType", SqlDbType.NVarChar).Value = "image/x-png";
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                        con.Close();
                        strScript = "alert('Thank you! You have successfully posted the event.');";
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
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
                        txtone.Visible = false;
                        txtmulti.Visible = false;
                        txttime.Text = "";
                        txtevename.Text = "";
                        txtven.Text = "";
                        txtvid.Text = "";
                        txtadd.Text = "";
                        txtlndm.Text = "";
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
    /// sending a mail to the corresponding authenticated user to intimate about the posted event
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
            Msg += "You have successfully posted the event , Please wait for the approval " + "<br>For further details please visit our site www.justcalluz.com or call on +9166136226." +
                        "<br><br>Warm Regards," +
                        "<br> Team JustCalluz"; ;
            mm.Subject = "Intimation about posted Event";
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
        //Response.Redirect("Register.aspx?ret=ok");
    }
    protected void cancel_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            //Response.Redirect("Eventshome.aspx");
            //redirect("Events.aspx?cname=events", false);
            Response.RedirectToRoute("Events", new { cname = "events" });
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
