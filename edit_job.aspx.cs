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
using System.Collections.Generic;
using JustCallUsData.Data;
using System.Net;
using System.Net.NetworkInformation;
using System.Web.Routing;


/// <summary>
/// To bind and update the posted job
/// </summary>
public partial class edit_job : System.Web.UI.Page
{
    DataCS data = new DataCS();
    InsertData obj = new InsertData();
    static string excep_page = "edit_job.aspx"; 
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    string strScript = string.Empty;
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

                    //redirect("AuthenticationMsg.aspx?msg=Jobs",false);
                    Response.RedirectToRoute("AuthenticationMsg", new { msg = "Jobs" });


                }

                else
                   // redirect("signin.aspx?Qname=Editjob",false);
                    Response.RedirectToRoute("Signin", new { Qname = "Editjob" });

            }
            catch (Exception ex)
            {
                obj.insert_exception(ex, excep_page);
                Response.Redirect("HttpErrorPage.aspx");
            }
       

             ccjoin.Visible = true;
             try
             {
                 // Applying validation on job expiry date
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

                     // Giving max and min values to the range validators at run time
                     rngdate.MinimumValue = Convert.ToDateTime(startdatemin).ToShortDateString();
                     rngdate.MaximumValue = Convert.ToDateTime(startdatemax).ToShortDateString();
                     rngdate.ErrorMessage = " Please select from the date" + " " + Convert.ToDateTime(startdatemin).ToShortDateString() + " To " + Convert.ToDateTime(startdatemax).ToShortDateString();

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
                //To bind Industries
                data.FillIndustry(ddlind);
                //To bind Funtional Area
                data.FillFunctionalArea(ddlfunarea);

                Binddetails();
                ViewState["previouspage"] = Request.UrlReferrer;

            }
      
    }

    /// <summary>
    /// To bind the data from the database
    /// </summary>
    protected void Binddetails()
    {
        try
        {
            string mob_no = string.Empty;
            Int32 jid  = Convert.ToInt32(Page.RouteData.Values["id"]);
           // Int32 jid = Convert.ToInt32(Page.RouteData.Values["cname"]);
           // con.Open();
            SqlCommand cmd = new SqlCommand("viewjob", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", jid);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            //con.Close();
            if (ds.Tables.Count > 0 && !ds.Tables[2].Rows.Count.Equals(0))
            {
                string cat = ds.Tables[2].Rows[0]["Category"].ToString();
                string subcat = ds.Tables[2].Rows[0]["SubCategory"].ToString();
                string state = ds.Tables[2].Rows[0]["State"].ToString();
                string city = ds.Tables[2].Rows[0]["City"].ToString();
                string exp = ds.Tables[2].Rows[0]["job_exp"].ToString();
                string industry = ds.Tables[2].Rows[0]["job_industry"].ToString();
                string funarea = ds.Tables[2].Rows[0]["job_functional_area"].ToString();
                txtarea.Text = ds.Tables[2].Rows[0]["Area"].ToString();
                txtcmp.Text = ds.Tables[2].Rows[0]["company_name"].ToString();
                txtrol.Text = ds.Tables[2].Rows[0]["job_role"].ToString();
                txtqul.Text = ds.Tables[2].Rows[0]["job_Qualification"].ToString();
                txtage.Text = ds.Tables[2].Rows[0]["Age"].ToString();
                if (ds.Tables[2].Rows[0]["job_exp"].ToString() != "Fresher")
                {
                    txtexp.Visible = true;
                    txtexp.Text = ds.Tables[2].Rows[0]["job_exp"].ToString();
                }
                else
                    txtexp.Visible = false;
                txtsal.Text = ds.Tables[2].Rows[0]["job_sal"].ToString();
                txtdesc.Text = ds.Tables[2].Rows[0]["job_desc"].ToString();
                txtkey.Text = ds.Tables[2].Rows[0]["job_keyskills"].ToString();
                txtexpiry.Text = ds.Tables[2].Rows[0]["Job_ExpiryDate"].ToString();
                txtprf.Text = ds.Tables[2].Rows[0]["company_profile"].ToString();
                txtadd.Text = ds.Tables[2].Rows[0]["address"].ToString();
                txtlndm.Text = ds.Tables[2].Rows[0]["land_mark"].ToString();
                string Mob = ds.Tables[2].Rows[0]["mob"].ToString();
                string mobile = Mob.Substring(0, 1);
                if (mobile == "+")
                {
                    mob_no = Mob.Substring(3, 10);
                }
                else if (mobile == "0")
                {
                    mob_no = Mob.Substring(0, 10);
                }
                txtmob.Text = mob_no;
                txtph.Text = ds.Tables[2].Rows[0]["landphno"].ToString();
                txtfax.Text = ds.Tables[2].Rows[0]["fax"].ToString();
                txtweb.Text = ds.Tables[2].Rows[0]["Website"].ToString();
                txtcntp.Text = ds.Tables[2].Rows[0]["contact_person"].ToString();
                txtemail.Text = ds.Tables[2].Rows[0]["emailid"].ToString();
                txtpin.Text = ds.Tables[2].Rows[0]["pincode"].ToString();
                string filename = ds.Tables[2].Rows[0]["ImageName"].ToString();
                imgReviewer.ImageUrl = "~/Logos\\" + filename;
                //for (int i = 0; i < ddlexp.Items.Count; i++)
                //{
                if (txtexp.Visible)
                {
                    ddlexp.SelectedValue = ddlexp.Items[2].Value;
                }
                else
                {
                    ddlexp.SelectedValue = ddlexp.Items[1].Value;
                }
                //}
                for (int i = 0; i < ddlind.Items.Count; i++)
                {
                    if (ddlind.Items[i].Text == industry.ToString())
                    {
                        ddlind.SelectedValue = ddlind.Items[i].Value;
                        break;
                    }
                }
                for (int i = 0; i < ddlfunarea.Items.Count; i++)
                {
                    if (ddlfunarea.Items[i].Text == funarea.ToString())
                    {
                        ddlfunarea.SelectedValue = ddlfunarea.Items[i].Value;
                        break;
                    }
                }
                for (int i = 0; i < ddlcat.Items.Count; i++)
                {
                    if (ddlcat.Items[i].Text == cat.ToString())
                    {
                        ddlcat.SelectedValue = ddlcat.Items[i].Value;
                        break;
                    }
                    else
                    {
                        ddlcat.SelectedIndex = 0;
                    }
                }
                Bindsubcatdropdown(cat);
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


            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void ddlcat_selectedindexchanged(object sender, EventArgs e)
    {
        try
        {
            string catg = ddlcat.SelectedItem.ToString();
            Bindsubcatdropdown(catg);
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
            //con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from categories where Module='Jobs'", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            //con.Close();
            ddlcat.DataSource = ds;
            ddlcat.DataTextField = "Category";
            ddlcat.DataValueField = "id";
            ddlcat.DataBind();
            ddlcat.Items.Insert(0, "select");
            ddlsubcat.Items.Insert(0, "select");


            ddlexp.Items.Insert(0, "select");
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }

    }
    /// <summary>
    /// To bind the subcategory dropdownlist from the database
    /// </summary>
    protected void Bindsubcatdropdown(string catg)
    {
        try
        {
            //con.Open();

            SqlDataAdapter da = new SqlDataAdapter("Select cat from subcatageory where maincat='" + catg + "'", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "subcategeory");

            //con.Close();
            ddlsubcat.DataSource = ds.Tables["subcategeory"];
            ddlsubcat.DataTextField = "cat";
            ddlsubcat.DataValueField = "cat";
            ddlsubcat.DataBind();
            ddlsubcat.Items.Insert(0, new ListItem("select", "0"));
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }

    /// <summary>
    /// To bind the states dropdownlist from the database
    /// </summary>
    protected void Bindstatedropdown()
    {
        try
        {
            //con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select state_name from states", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
           // con.Close();
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
    /// To bind the cities dropdownlist from the database
    /// </summary>
    protected void Bindcitydropdown(string statename)
    {
        try
        {
            
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
    protected void ddlexp_selectedindexchanged(object sender, EventArgs e)
    {
        try
        {

            if (ddlexp.SelectedIndex == 2)
                txtexp.Visible = true;
            else
                txtexp.Visible = false;
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }

    

    protected void cancelbtn_Click(object sender, ImageClickEventArgs e)
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
    /// To update the job
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
                DateTime pdate = DateTime.Now.Date;
                string userid = Convert.ToString(Session["USERID"]);
                SqlCommand cmd = new SqlCommand("updatejobs", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.CommandText = "postjob";
                cmd.Parameters.Clear();

               Int32 jid = Convert.ToInt32(Page.RouteData.Values["id"]);
               // Int32 jid = Convert.ToInt32(Page.RouteData.Values["cname"]);

                cmd.Parameters.AddWithValue("@id", jid);
                cmd.Parameters.AddWithValue("@Category", ddlcat.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@SubCategory", ddlsubcat.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@State", ddlstate.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@City", ddlcity.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@Area", txtarea.Text);
                cmd.Parameters.AddWithValue("@company_name", txtcmp.Text);
                cmd.Parameters.AddWithValue("@job_industry", ddlind.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@job_functional_area", ddlfunarea.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@job_role", txtrol.Text);
                cmd.Parameters.AddWithValue("@job_Qualification", txtqul.Text);
                cmd.Parameters.AddWithValue("@Age", txtage.Text);
                if (ddlexp.SelectedIndex == 2)
                {
                    cmd.Parameters.AddWithValue("@job_exp", txtexp.Text);
                }
                else
                cmd.Parameters.AddWithValue("@job_exp", ddlexp.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@job_sal", txtsal.Text);
                cmd.Parameters.AddWithValue("@job_desc", txtdesc.Text);
                cmd.Parameters.AddWithValue("@job_keyskills", txtkey.Text);
                cmd.Parameters.AddWithValue("@Job_ExpiryDate", txtexpiry.Text);
                cmd.Parameters.AddWithValue("@company_profile", txtprf.Text);
                cmd.Parameters.AddWithValue("@address", txtadd.Text);
                cmd.Parameters.AddWithValue("@land_mark", txtlndm.Text);
                cmd.Parameters.AddWithValue("@mob", txtmob.Text);
                cmd.Parameters.AddWithValue("@landphno", txtph.Text);
                cmd.Parameters.AddWithValue("@fax", txtfax.Text);
                cmd.Parameters.AddWithValue("@Website", txtweb.Text);
                cmd.Parameters.AddWithValue("@ApprovedStatus", SqlDbType.Int).Value = 3;
                cmd.Parameters.AddWithValue("@contact_person", txtcntp.Text);
                cmd.Parameters.AddWithValue("@emailid", txtemail.Text);
                cmd.Parameters.AddWithValue("@pincode", txtpin.Text);
                cmd.Parameters.AddWithValue("@Status", SqlDbType.Int).Value = 3;
                cmd.Parameters.AddWithValue("@By_EmailId", userid);
                cmd.Parameters.AddWithValue("@Date", pdate);
                cmd.Parameters.AddWithValue("@DataId", jid);
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

                strScript = "alert('Thank you! You have successfully updated the job.');location.replace('viewjob');";//('view_jobs.aspx?id=" + id + "');";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                SendMail(userid);
                ddlcat.SelectedIndex = 0;
                ddlsubcat.SelectedIndex = 0;
                ddlstate.SelectedIndex = 0;
                ddlcity.SelectedIndex = 0;
                ddlexp.SelectedIndex = 0;
                txtadd.Text = "";
                txtage.Text = "";
                txtarea.Text = "";
                txtcmp.Text = "";
                txtcntp.Text = "";
                txtdesc.Text = "";
                txtemail.Text = "";
                txtexp.Text = "";
                txtexpiry.Text = "";
                txtfax.Text = "";
                ddlfunarea.SelectedIndex = 0;
                ddlind.SelectedIndex = 0;
                txtkey.Text = "";
                txtlndm.Text = "";
                txtmob.Text = "";
                txtph.Text = "";
                txtpin.Text = "";
                txtprf.Text = "";
                txtqul.Text = "";
                txtrol.Text = "";
                txtsal.Text = "";
                txtweb.Text = "";
                txtvid.Text = "";
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }

    /// <summary>
    /// sending the mail to intimate about the updated job 
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
            Msg += "You have successfully updated the job " + "<br>For further details please visit our site www.justcalluz.com or call on +9166136226." +
                        "<br><br>Warm Regards," +
                        "<br> Team JustCalluz"; ;
            mm.Subject = "Intimation about the updated job";
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

    protected void btnlogo_Click(object sender, EventArgs e)
    {
        try
        {
            string id = string.Empty;
            id = Convert.ToString(Page.RouteData.Values["id"]);
            string userid = Convert.ToString(Session["USERID"]);
            //con.Open();

            SqlDataAdapter da = new SqlDataAdapter("select id,ImageName,UserLoginId from modulesdata where UserLoginId='" + userid + "' and id='" + id + "'", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            string imagename = ds.Tables[0].Rows[0]["ImageName"].ToString();
            //if (imagename.ToString() == "NULL" || imagename.ToString() == "null" || imagename.ToString() == "0" || imagename.ToString() == "Null" || imagename.ToString() == "")
            if (imagename.ToString() == "0")
            {
                SqlCommand cmd = new SqlCommand("update modulesdata set ImageName=@ImageName,ImagecontentType=@ImageContentType where id='" + id + "'", con);
                if (uploadLogo.HasFile)
                {
                    if (uploadLogo.PostedFile.ContentLength <= 30000)
                    {
                        string filename = System.IO.Path.GetFileName(uploadLogo.PostedFile.FileName);
                        string contenttype = uploadLogo.PostedFile.ContentType;
                        uploadLogo.PostedFile.SaveAs(Server.MapPath("../Logos/" + filename));
                        using (System.Drawing.Image Img = System.Drawing.Image.FromFile(Server.MapPath("../Logos/" + filename)))
                        {

                            if (Img.Width <= 100 && Img.Height <= 75)
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
                            }
                            else
                            {
                                strScript = "alert('sorry! Secified Logo cannot be uploaded , make sure that width=100 and height=75.');";
                                Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                            }
                        }
                    }
                    else
                    {
                        strScript = "alert('sorry! Secified Logo cannot be uploaded , make sure that size is lessthan 30kb.');";
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                    }
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ImageName", SqlDbType.NVarChar).Value = 0;
                    cmd.Parameters.AddWithValue("@ImageContentType", SqlDbType.NVarChar).Value = 0;
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
                }
            }
            else
            {
                strScript = "alert('Are you sure ! to update the existing logo ?');";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
            }
            //moreinfopanel.Visible = true;
            uploadLogo.Enabled = false;
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    [System.Web.Script.Services.ScriptMethod()]
    [System.Web.Services.WebMethod]
    public static List<string> Getcities(string prefixText)
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["connectionstring"]);
        con.Open();
        SqlCommand cmd = new SqlCommand("select * from cities where city_name like @Name+'%'", con);
        cmd.Parameters.AddWithValue("@Name", prefixText);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        da.Fill(dt);
        List<string> citynames = new List<string>();
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            citynames.Add(dt.Rows[i][1].ToString());
        }
        return citynames;
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
