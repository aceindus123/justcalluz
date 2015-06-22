using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.IO;
using System.Data;
using System.Configuration;
/// <summary>
/// To delete city trends
/// </summary>
public partial class admin_Admin_DeleteCityTrends : System.Web.UI.Page
{
    //Creation of object for class and declaration of variables
    string UserId;
    string streg = string.Empty;
    Int32 usid;
    string mod;
    DataSet ds = new DataSet();
    CityTrendsCS obj = new CityTrendsCS();
    //To make connection
    SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
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
        usid =Convert.ToInt32(Request.QueryString["mid"].ToString());
        // Page loads without postbacking values
        if (!IsPostBack)
        {
            ds = obj.GetCTrendParticular(usid);
            if (!ds.Tables[0].Rows.Count.Equals(0))
            {
                mod = ds.Tables[0].Rows[0]["mod"].ToString();
            }
            //To open connection
            connection.Open();            
            SqlCommand cmd = new SqlCommand("delete from CityTrends where ctId=" + usid, connection);
            streg = cmd.ExecuteNonQuery().ToString();
            //To close connection
            connection.Close();
            Response.Redirect("Admin_CityTrends.aspx?mod="+mod);

        }
    }
}
