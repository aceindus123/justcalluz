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
using JustCallUsData.Data;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Collections.Generic;
using System.Web.Routing;

public partial class Search_Not_Found : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    InsertData obj = new InsertData();
    string strScript;
    string city = string.Empty;
    string strcat = string.Empty;
    static string excep_page = "Search-Not-Found.aspx";
    /// <summary>
    /// Executes whenever page loads
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            try
            {
                ccjoin.Visible = true;
                if (!Page.IsPostBack)
                {
                    fillCities();
                    if ((Convert.ToString(Page.RouteData.Values["cname"]) != "") && (Convert.ToString(Page.RouteData.Values["city"]) != ""))
                    {
                        strcat = Convert.ToString(Page.RouteData.Values["cname"].ToString());
                        strcat = obj.ReplaceCatnamewithorginalchars(strcat);
                        //strcat = strcat.Replace("-", " ");
                        //strcat = strcat.Replace("Dot", ".");
                        //strcat = strcat.Replace("-", "/");
                        //strcat = strcat.Replace("-", "_");
                        //strcat = strcat.Replace("-", "%20");
                        city = Convert.ToString(Page.RouteData.Values["city"].ToString());
                        lblcat.Text = strcat;
                        lblcity.Text = city;
                        ddlCity.Text = city;
                    }
                    else
                    {
                        tbldata.Visible = false;
                        ddlCity.Enabled = true;
                    }
                }
            }
            catch (Exception ex)
            {
                obj.insert_exception(ex, excep_page);
                Response.Redirect("HttpErrorPage.aspx");
            }
        }
         
    }
    protected void btnRefreshCapcha_Click(object sender, EventArgs e)
    {
        try
        {
            UpdatePanel1.Update();
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    public void fillCities()
    {
        try
        {
            //string Connection = ConfigurationManager.AppSettings["ConnectionString"];
           // SqlConnection oCon = new SqlConnection(Connection);
           // string s = "select city_Id,city_name from Cities";
           // SqlCommand cmd = new SqlCommand(s, oCon);
           // oCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("select city_Id,city_name from Cities", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Cities");
            //DlCities.SelectedIndex = 0;

            ddlCity.DataSource = ds.Tables["Cities"];
            ddlCity.DataValueField = "city_name";
            ddlCity.DataTextField = "city_name";
            ddlCity.DataBind();
            ddlCity.Items.Insert(0, "Select City");
            //oCon.Close();
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
        //catch (Exception ex)
        //{
        //    lblMessage.Text = ex.Message.ToString();
        //}
    }
    protected void imgsubmit_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            ccjoin.ValidateCaptcha(txtvid.Text);
            // If condition executes when you entered invalid capcha otherwise executes else statements
            if (!ccjoin.UserValidated)
            {
                strScript = "alert('Your have to enter as like in the image.');";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                //Inform user that his input was wrong ...
                txtvid.Text = "";
                return;

            }
            else
            {
                try
                {
                    //SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
                    DataSet ds = new DataSet();
                    string city = ddlCity.SelectedItem.Value.ToString();
                    string location = txtlocation.Text.ToString();
                    string name = txtname.Text.ToString();
                    string email = txtemail.Text.ToString();
                    string company = txtcompname.Text.ToString();
                    string product = txtproduct.Text.ToString();
                    string comments = txtcomments.Text.ToString();

                    ds = obj.insert_searchnotfound(city, location, name, email, company, product, comments);
                    SendMail(city, location, name, email, company, product, comments);
                    //con.Close();
                    strScript = "alert('Your data Posted successfully');location.replace('Home')";
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "alertbox", strScript, true);

                }
                catch (Exception ex)
                {
                    obj.insert_exception(ex, excep_page);
                    Response.Redirect("HttpErrorPage.aspx");
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
    /// code for sending mail
    /// </summary>
    /// <param name="UserId"></param>
    /// <param name="city"></param>
    /// <param name="location"></param>
    /// <param name="name"></param>
    /// <param name="email"></param>
    /// <param name="company"></param>
    /// <param name="product"></param>
    /// <param name="comments"></param>
    private void SendMail(string city, string location, string name, string email, string company, string product, string comments)
    {
        try
        {
            string Msg = "";
            MailMessage mm = new MailMessage();
            //mm.From = new MailAddress("info@aceindus.in");
            mm.From = new MailAddress("info@justcalluz.com");
            mm.To.Add(email);
            Msg += "Dear <b>" + name + "</b>," +

                "<br><br>" +
                "Thanks for your interest with Just Call Uz. Please wait for the Approval" +
                "<br><br>Warm Regards," +
                "<br> Just Call Uz Team";
            mm.Subject = "Your Business details with Just Call Uz ";
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
}
