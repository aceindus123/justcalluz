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

public partial class admin_customerdetails : System.Web.UI.Page
{
    string UserId; 
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["connectionstring"].ToString());
    SqlCommand cmd;
    DataSet dscust = new DataSet();
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
        con.Open();
        int id = Convert.ToInt32(Request.QueryString["dataid"].ToString());
        cmd = new SqlCommand("customerdet", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@dataid", id);
        cmd.ExecuteNonQuery();
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(dscust);
        if (!dscust.Tables[0].Rows.Count.Equals(0))
        {
            lblbnameval.Text = dscust.Tables[0].Rows[0]["name"].ToString();
            lbltypeval.Text = dscust.Tables[0].Rows[0]["RegType"].ToString();
            lbldateval.Text = dscust.Tables[0].Rows[0]["iRegDate"].ToString();
            lblmobval.Text = dscust.Tables[0].Rows[0]["mob"].ToString();
            lblmailval.Text = dscust.Tables[0].Rows[0]["email"].ToString();
            lblcityval.Text = dscust.Tables[0].Rows[0]["city"].ToString();
            lblstateval.Text = dscust.Tables[0].Rows[0]["state"].ToString();
            lblpinval.Text = dscust.Tables[0].Rows[0]["pincode"].ToString();
            lblbnameval.Text = dscust.Tables[0].Rows[0]["bname"].ToString();
            lblkbusinessval.Text = dscust.Tables[0].Rows[0]["kindofbusiness"].ToString();
            lbldesval.Text = dscust.Tables[0].Rows[0]["des"].ToString();
            lblmoduleval.Text = dscust.Tables[0].Rows[0]["module"].ToString();
            lblCategoryval.Text = dscust.Tables[0].Rows[0]["Category"].ToString();
            lblsubcatval.Text = dscust.Tables[0].Rows[0]["SubCategory"].ToString();
            lblStatusval.Text = dscust.Tables[0].Rows[0]["ApprovedStatus"].ToString();
            lblwebsiteval.Text = dscust.Tables[0].Rows[0]["website"].ToString();
            lblfaxval.Text = dscust.Tables[0].Rows[0]["fax"].ToString();
        }
        con.Close();
    }
    protected void linkto_edit(object sender, CommandEventArgs e)
    {
        int did = Convert.ToInt32(dscust.Tables[0].Rows[0]["id"].ToString());
        Response.Redirect("Admin_EditData.aspx?did=" + did);
    }
}
