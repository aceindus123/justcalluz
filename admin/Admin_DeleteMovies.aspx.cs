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
/// To delete movies
/// </summary>
public partial class admin_Admin_DeleteMovies : System.Web.UI.Page
{
    //Declaration of variables
    string UserId;
    string streg = string.Empty;
    string usid = string.Empty;
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
        usid = Request.QueryString["mid"].ToString();
        // Page loads without postbacking values
        if (!IsPostBack)
        {
            //To make connection
            SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
            //To open connection
            connection.Open();
            SqlCommand cmd = new SqlCommand("delete from Movies where mid=" + usid, connection);
           // streg = cmd.ExecuteNonQuery().ToString();
            //To close connection
            connection.Close();
            string city, state;
            city = Request.QueryString["City"].ToString();
            state = Request.QueryString["State"].ToString();
            Page.ClientScript.RegisterStartupScript(typeof(Page), "message", "<script type='text/javascript' language='javascript'>alert('Selected record deleted successfully !!!'); window.location('Admin_Movies.aspx?city=" + city + "&state=" + state + "');</script>");
          //  Response.Redirect("Admin_Movies.aspx?city=" + city + "&state=" + state);
        }
    }
}
