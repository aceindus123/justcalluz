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
/// <summary>
/// Class to delete voilated data
/// </summary>
public partial class admin_Admin_DeleteCatData : System.Web.UI.Page
{
    string UserId;
    DataCS obj = new DataCS();
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
        string catname = Convert.ToString(Session["CatName"]);
        string modulename = Convert.ToString(Session["Modulename"]);
        usid = Request.QueryString["cid"].ToString();
        bool t;
        // Page loads without postbacking values
        if (!IsPostBack)
        {
            //To make connection
            SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
            obj.pId = Convert.ToInt32(usid);
            t = obj.Data_Delete(obj.pId);
           // t = true;
            if (t == true)
            {
                if (modulename == "Jobs")
                {
                    int id = Convert.ToInt32(Request.QueryString["cid"].ToString());
                    SqlCommand cmdget = new SqlCommand("get_careerid", connection);
                    cmdget.CommandType = CommandType.StoredProcedure;
                    cmdget.Parameters.AddWithValue("@jid", id);
                    DataSet dscareer = new DataSet();
                    SqlDataAdapter dacareer = new SqlDataAdapter(cmdget);
                    dacareer.Fill(dscareer);
                    int cid = Convert.ToInt32(dscareer.Tables[0].Rows[0]["careers_id"].ToString());
                    SqlConnection careercon = new SqlConnection(ConfigurationManager.AppSettings["career_connectionstring"]);
                    careercon.Open();
                    SqlCommand daa = new SqlCommand("Delete rz_postcareers_jobs where p_jobcode=" + cid, careercon);
                    daa.ExecuteNonQuery();
                    careercon.Close();
                    Response.Write("<script type=text/javascript>alert('Record Deleted Sucessfully')</script>");
                   
                 }
                Response.Redirect("Admin_LinkControllerCategory.aspx?cat=" + Server.UrlEncode(catname) + "&mod=" + Server.UrlEncode(modulename));
            }

        }
    }
    /// <summary>
    /// To go admin control home page
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lnkbtnHome_Click(object sender, EventArgs e)
    {
        Response.Redirect("Admin_Home.aspx");
    }
    /// <summary>
    /// To post the data
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lnkbtnPostData_Click(object sender, EventArgs e)
    {
        Response.Redirect("Admin_PostData.aspx");
    }
}
