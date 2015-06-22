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
/// class to delete media speak
/// </summary>
public partial class admin_Admin_MediaDelete : System.Web.UI.Page
{
    //making connection
    SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    //declaration of variables and creation of object for class
    string UserId;
    DataSet ds = new DataSet();
    MediaCS obj = new MediaCS();
    string lang;
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
            ds = obj.GetPerticularMedia(usid); ;
            if (!ds.Tables[0].Rows.Count.Equals(0))
            {
                lang = ds.Tables[0].Rows[0]["LanguageSpeak"].ToString();
            }
            //To open connection
            connection.Open();
            SqlCommand cmd = new SqlCommand("delete from Media_Data where Medid=" + usid, connection);
            streg = cmd.ExecuteNonQuery().ToString();
            //To close connection
            connection.Close();
            Page.ClientScript.RegisterStartupScript(typeof(Page), "message", "<script type='text/javascript' language='javascript'>alert('Selected Record Deleted Successfully !!!'); window.location('Admin_Media.aspx?lang=" + lang + "');</script>");
           // Response.Redirect("Admin_Media.aspx?lang=" + lang);

        }

    }

}
