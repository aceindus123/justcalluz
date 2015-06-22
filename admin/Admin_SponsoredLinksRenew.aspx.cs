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
/// <summary>
/// Class to renew sponsored links from admin control only
/// </summary>
public partial class admin_Admin_SponsoredLinksRenew : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    Int16 Sid=0;
    SqlDataReader dr;
    string UserId;
    protected void Page_Load(object sender, EventArgs e)
    {
        UserId = Convert.ToString(Session["LogInId"]);
        if (UserId != "")
        {
            // it will stays in the same page
        }

        else
        {
            //After login into the account it will go Post ad
            Response.Redirect("Default.aspx");

        }
    }
    /// <summary>
    /// To renew the sponsored links
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnRenew_Click(object sender, EventArgs e)
    {
       Sid=Convert.ToInt16(Request.QueryString["Id"]);
       con.Open();
       string ExpiryDate=string.Empty;
       string str = "select * from sponseredlinks where id=" + Sid;
       SqlCommand cmd = new SqlCommand(str, con);
       dr = cmd.ExecuteReader();
       while (dr.Read())
       {
           ExpiryDate = Convert.ToString(dr["ExpireDate"]);
           DateTime expDate = DateTime.ParseExact(ExpiryDate, "dd/MM/yyyy",System.Globalization.CultureInfo.CurrentCulture);
           DateTime addExpDate=expDate.AddDays(Convert.ToDouble(txtDays.Text));
           string format = "dd/MM/yyyy";
           string NewExpiryDate=string.Empty;
           NewExpiryDate=addExpDate.ToString(format);
           Session["ExpDate"]=NewExpiryDate;
       }
       con.Close();
       string str1="Update sponseredlinks set ExpireDate=@ExpiryDate where id="+Sid;
       con.Open();
       SqlCommand cmd1=new SqlCommand(str1,con);
       string expireDate=string.Empty;
       expireDate=Convert.ToString(Session["ExpDate"]);
       cmd1.Parameters.AddWithValue("@ExpiryDate",expireDate);
       cmd1.ExecuteNonQuery();
       con.Close();
       string script=string.Empty;
       Response.Redirect("Admin_SponsoredLinks.aspx");
        
    }
    /// <summary>
    /// To go sponsored links home page
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lnkBtnSponsorLinksHome_Click(object sender, EventArgs e)
    {
        Response.Redirect("Admin_SponsoredLinks.aspx");
    }
    /// <summary>
    /// Function to post Sponsored Links
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lnkbtnPostsponslinks_Click(object sender, EventArgs e)
    {
        Response.Redirect("Admin_ToPostSponsoredLinks.aspx");
    }
}
