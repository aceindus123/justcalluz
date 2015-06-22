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
/// To post the job , binding data to the dropdownlists
/// </summary>
public partial class post_job : System.Web.UI.Page
{
    DataCS data = new DataCS();
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    string strScript = string.Empty;
    InsertData obj = new InsertData();
    static string excep_page = "post_job.aspx"; 
    /// <summary>
    /// While posting the job ,To check whether the user is loggedin or not if so ,is he is registered as business type ? assuming that may session will get closed.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {

            txtsubcat.Visible = false;
            ccjoin.Visible = true;
            try
            {
                // Applying validation on job expiry date
                string getdate = "select startmindate=DATEADD(mi,750,GETDATE()), startdatemax=DATEADD(dd,90,DATEADD(mi,750,GETDATE())),enddatemax=DATEADD(dd,365,DATEADD(mi,750,GETDATE())),jobexpdate=DATEADD(dd,60,DATEADD(mi,750,GETDATE()))";
                SqlDataAdapter ada = new SqlDataAdapter(getdate, con);
                DataSet ds = new DataSet();
                ada.Fill(ds);
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
            // Checking user authentication
            string userid = Convert.ToString(Session["USERID"]);
            string regtype = Convert.ToString(Session["RegType"]);
            if (userid != "" && regtype == "Business")
            {

            }

            else if (userid != "" && regtype == "Individual")
            {

                //redirect("AuthenticationMsg.aspx?msg=jobs", false);
                Response.RedirectToRoute("AuthenticationMsg", new { msg = "jobs" });


            }

            else
                //redirect("signin.aspx?Qname=jobs", false);
                Response.RedirectToRoute("Signin", new { Qname = "jobs" });

            if (!IsPostBack)
            {
                Bindcatdropdown();
                Bindstatedropdown();
                //To bind Industries
                data.FillIndustry(ddlind);
                //To bind Funtional Area
                data.FillFunctionalArea(ddlfunarea);

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
            SqlDataAdapter da = new SqlDataAdapter("select * from categories where Module='Jobs'", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
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
    protected void ddlcat_selectedindexchanged(object sender, EventArgs e)
    {
        try
        {
            string catg = ddlcat.SelectedItem.ToString();
            SqlDataAdapter da = new SqlDataAdapter("Select cat from subcatageory where maincat='" + catg + "'", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "subcategeory");
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

    protected void ddlsubcat_selectedindexchanged(object sender, EventArgs e)
    {
        try
        {
            if (ddlsubcat.SelectedValue == "Others")
                txtsubcat.Visible = true;
            else
                txtsubcat.Visible = false;
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }

    

    /// <summary>
    /// To post the job
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
                DateTime pdate = DateTime.Now.Date;
                DateTime expdate = DateTime.Now.Date.AddDays(Convert.ToDouble(90));
                SqlCommand cmd = new SqlCommand("postjob", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.CommandText = "postjob";
                //string mod;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@module", SqlDbType.NVarChar).Value = "Jobs";
                cmd.Parameters.AddWithValue("@UserLoginId", SqlDbType.NVarChar).Value = userid;
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
                cmd.Parameters.AddWithValue("@mob", txtcode.Text + txtmob.Text);
                cmd.Parameters.AddWithValue("@landphno", txtph.Text);
                cmd.Parameters.AddWithValue("@fax", txtfax.Text);
                cmd.Parameters.AddWithValue("@Website", txtweb.Text);
                cmd.Parameters.AddWithValue("@ApprovedStatus", SqlDbType.Int).Value = 0;
                cmd.Parameters.AddWithValue("@contact_person", txtcntp.Text);
                cmd.Parameters.AddWithValue("@emailid", txtemail.Text);
                cmd.Parameters.AddWithValue("@pincode", txtpin.Text);
                cmd.Parameters.AddWithValue("@postdate", SqlDbType.DateTime).Value = pdate;
                cmd.Parameters.AddWithValue("@expdate", SqlDbType.DateTime).Value = expdate;
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

                strScript = "alert('Thank you! You have successfully posted the job.');";
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
                txtexp.Visible = false;
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
    /// sending the mail to intimate about the posted job 
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
            Msg += "You have successfully posted the job " + "<br>For further details please visit our site www.justcalluz.com or call on +9166136226." +
                        "<br><br>Warm Regards," +
                        "<br> Team JustCalluz"; ;
            mm.Subject = "Intimation about the posted job";
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

    protected void btnUploadLogo_Click1(object sender, ImageClickEventArgs e)
    {
        try
        {
            string userid = Convert.ToString(Session["USERID"]);
            string id;
            SqlDataAdapter da = new SqlDataAdapter("select top 1 id,UserLoginId from modulesdata where UserLoginId='" + userid + "' order by id desc", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            id = ds.Tables[0].Rows[0]["id"].ToString();

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
                            strScript = "alert('sorry! Secified Logo can't be uploaded , make sure that width=100 and height=75.');";
                            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                        }
                    }
                }
                else
                {
                    strScript = "alert('sorry! Secified Logo can't be uploaded , make sure that size is lessthan 30kb.');";
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

            uploadLogo.Enabled = false;
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    //protected void cancel_Click(object sender, ImageClickEventArgs e)
    //{
    //    try
    //    {
    //        redirect("jobs.aspx?cname=jobs", false);
    //    }
    //    catch (Exception ex)
    //    {
    //        obj.insert_exception(ex, excep_page);
    //        Response.Redirect("HttpErrorPage.aspx");
    //    }
    //}
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
