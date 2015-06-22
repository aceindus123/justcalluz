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
/// Class to delete reviews
/// </summary>
public partial class admin_Admin_DeleteReview : System.Web.UI.Page
{
    string UserId; 
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
        //Declaration of variables
        string streg = string.Empty;
        string usid = string.Empty;
        string dataId=Convert.ToString(Session["DataId"]);
        usid = Request.QueryString["cid"].ToString();
        // Page loads without postbacking form vlues
        if (!IsPostBack)
        {
            //To make connection
            SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
            //To open connection
            connection.Open();
            SqlCommand cmd = new SqlCommand("delete from PostReview where rid=" + usid, connection);
            streg = cmd.ExecuteNonQuery().ToString();
            //To close connection
            connection.Close();
            Response.Redirect("Admin_ViewReviews.aspx?id="+ dataId);
        }
    }
}
