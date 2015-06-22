using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
/// <summary>
/// class to Delete Ad
/// </summary>
public partial class admin_Admin_DeleteAd : System.Web.UI.Page
{
    //making connection
    SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    //Creation of object for class and declaration of variables
    string UserId;
    DataSet ds = new DataSet();
    AdsCS obj = new AdsCS();
    string cat;
    /// <summary>
    /// Executes whenever page loads
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
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
        string streg = string.Empty;
        string usid = string.Empty;       
        usid = Request.QueryString["cid"].ToString();
        // Page loads without postbacking values
        if (!IsPostBack)
        {
            ds = obj.GetPerticularAd(usid);
            if (!ds.Tables[0].Rows.Count.Equals(0))
            {
                cat = ds.Tables[0].Rows[0]["AdType"].ToString();
            }
            //To open connection
            connection.Open();
            SqlCommand cmd = new SqlCommand("delete from Ads where adId=" + usid, connection);
            streg = cmd.ExecuteNonQuery().ToString();
            //To close connection
            connection.Close();
            Response.Redirect("Admin_Ads.aspx?cat="+cat);
        }
    }
}
