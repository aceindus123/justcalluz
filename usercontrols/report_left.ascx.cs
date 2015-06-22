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
using System.Net;
using System.Net.NetworkInformation;

public partial class usercontrols_report_left : System.Web.UI.UserControl
{
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["Connectionstring"]);
    InsertData obj = new InsertData();
    static string excep_page = "report_left.ascx"; 
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        try
        {
            int id = Convert.ToInt32(Session["sid"]);
            Response.RedirectToRoute("PostReviewCat", new { DataId = id, mod = "LifeStyle" });
            //redirect("PostReviewCat.aspx?DataId=" + id + "&mod=LifeStyle",false);
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }

    }
    protected void imgbtnIncorrect_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            string strScript = string.Empty;
            string ipaddress = getipaddress();
            //string physicaladdress = get_physicaladdress();
            DateTime pdate = DateTime.Now;
            int id = Convert.ToInt32(Session["sid"]);
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Report(dataid,Comment,report_type,postdate,IP_Address) values(@dataid,@Comment,@report_type,@postdate,@IP_Address)", con);
            cmd.Parameters.AddWithValue("dataid", SqlDbType.Int).Value = id;
            cmd.Parameters.AddWithValue("Comment", txtrpt.Text);
            cmd.Parameters.AddWithValue("report_type", SqlDbType.NVarChar).Value = "incorrect";
            cmd.Parameters.AddWithValue("postdate", pdate);
            cmd.Parameters.AddWithValue("IP_Address", ipaddress);
            //cmd.Parameters.AddWithValue("PhysicalAddress", physicaladdress);
            cmd.ExecuteNonQuery();
            con.Close();
            strScript = "alert('Thank you.......!');";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }

    }
    protected void imgsubmit1_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            string strscript = string.Empty;
            string ipaddress = getipaddress();
            //string physicaladdress = get_physicaladdress();
            DateTime pdate = DateTime.Now;
            int id = Convert.ToInt32(Session["sid"]);
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Report(Name,Contact_No,Email_Id,Comment,dataid,report_type,postdate,IP_Address) values(@Name,@Contact_No,@Email_Id,@Comment,@dataid,@report_type,@postdate,@IP_Address)", con);
            cmd.Parameters.AddWithValue("Name", txtname.Text);
            cmd.Parameters.AddWithValue("Contact_No", txtcntno.Text);
            cmd.Parameters.AddWithValue("Email_Id", txtmail.Text);
            cmd.Parameters.AddWithValue("Comment", txtcmnt.Text);
            cmd.Parameters.AddWithValue("dataid", SqlDbType.Int).Value = id;
            cmd.Parameters.AddWithValue("report_type", SqlDbType.NVarChar).Value = "abuse";
            cmd.Parameters.AddWithValue("postdate", pdate);
            cmd.Parameters.AddWithValue("IP_Address", ipaddress);
            //cmd.Parameters.AddWithValue("PhysicalAddress", physicaladdress);
            cmd.ExecuteNonQuery();
            con.Close();
            strscript = "alert('Thank You.......!');";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strscript, true);
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }

    protected void lnklife_Click(object sender, EventArgs e)
    {
        try
        {
            //int id = Convert.ToInt32(Session["sid"]);
            Response.RedirectToRoute("PostLife", new { cname = "LifeStyle" });
            //redirect("post_lifestyle.aspx?cname=LifeStyle",false);
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void Imgedit_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            string strscript = string.Empty;
            int sid = Convert.ToInt32(Session["sid"]);
            if (rbown.Checked)
            {
                Response.RedirectToRoute("editlife", new { id = sid, cname = "LifeStyle" });
                //redirect("edit_LifeStyle.aspx?id=" + id + "&cname=LifeStyle",false);
            }
            else if (rbuser.Checked)
            {
                //redirect("User_Edit.aspx?id=" + id + "&cname=LifeStyle",false);
                Response.RedirectToRoute("edituser", new { id = sid, cname = "LifeStyle" });
            }
            else
            {
                strscript = "alert('Please , Select any option to edit');";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBob", strscript, true);
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
        
    }
    protected string getipaddress()
    {
        string ip_add = string.Empty;
        try
        {
            ip_add = Request.ServerVariables["HTTP_X_FORWARDED_FOR"];
            if (ip_add == null)
            {
                ip_add = Request.ServerVariables["REMOTE_ADDR"];
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
        return ip_add;

    }
    //protected string get_physicaladdress()
    //{
    //    NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
    //    string phyadd = string.Empty;
    //    foreach (NetworkInterface adapter in nics)
    //    {
    //        if (phyadd == string.Empty)
    //        {
    //            IPInterfaceProperties properties = adapter.GetIPProperties();
    //            phyadd = adapter.GetPhysicalAddress().ToString();
    //        }
    //    }
    //    return phyadd;
    //}
   
    protected void imgcancel_Click(object sender, ImageClickEventArgs e)
    {

    }
    protected void btnmapsubmit_Click1(object sender, EventArgs e)
    {
        try
        {
            string strScript = string.Empty;
            strScript = "confirm('Are you sure , About this location.');";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "confirmBox", strScript, true);
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
