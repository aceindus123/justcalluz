using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
public partial class admin_Admin_DeleteWP : System.Web.UI.Page
{
    //making connection
    SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    //Creation of object for class and declaration of variables
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
        string streg = string.Empty;
        string usid = string.Empty;
        usid = Request.QueryString["cid"].ToString();
        // Page loads without postbacking values
        if (!IsPostBack)
        {            
            //To open connection
            connection.Open();
            SqlCommand cmd = new SqlCommand("delete from WhitepagesData where wpId=" + usid, connection);
            streg = cmd.ExecuteNonQuery().ToString();
            //To close connection
            connection.Close();
            Page.ClientScript.RegisterStartupScript(typeof(Page), "message", "<script type='text/javascript' language='javascript'>alert('Record Deleted Successfully !!!');window.location('Admin_WhitePages.aspx');</script>");
            //Response.Redirect("Admin_WhitePages.aspx");
        }
    }
}
