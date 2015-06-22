using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class admin_Admin_SSDelete : System.Web.UI.Page
{
    //making connection
    SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    //Creation of object for class and declaration of variables
    string UserId;
    DataSet ds = new DataSet();
    SSCS obj = new SSCS();
    string city;
    string state;
    string Type;
    protected void Page_Load(object sender, EventArgs e)
    {
        string id = string.Empty;       
        id = Request.QueryString["cid"].ToString();
        // Page loads without postbacking values
        if (!IsPostBack)
        {
            ds = obj.GetSS_byId(id);
            if (!ds.Tables[0].Rows.Count.Equals(0))
            {
                city = ds.Tables[0].Rows[0]["City"].ToString();
                state = ds.Tables[0].Rows[0]["State"].ToString();
                Type = ds.Tables[0].Rows[0]["TypeofSS"].ToString();
            }
            //To open connection
            connection.Open();
            SqlCommand cmd = new SqlCommand("delete from SuccessStories where ssId=" + id, connection);
            cmd.ExecuteNonQuery().ToString();
            //To close connection
            connection.Close();
            string path = "Admin_SuccessStories.aspx?Type=" + Type + "&s=" + state + "&c=" + city ;
            Page.ClientScript.RegisterStartupScript(typeof(Page), "message", "<script type='text/javascript' language='javascript'>alert('Record Deleted Successfully !!!');window.location('" + path + "')</script>");
            //Response.Redirect("Admin_SuccessStories.aspx?Type="+Type+"&s="+state+"&c="+city+"");
        }
    }
}
