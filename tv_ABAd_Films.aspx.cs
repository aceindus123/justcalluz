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

public partial class tv_ABAd_Films : System.Web.UI.Page
{

    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    string pageid = "TV_ADFILMS";
    string date;
    protected void Page_Load(object sender, EventArgs e)
    {
        Bindata();
    }

    private void Bindata()
    {
        string qry = "Select * from Adreviews where pageid='" + pageid + "'";
        con.Open();
        SqlDataAdapter da = new SqlDataAdapter(qry, con);
        DataSet ds = new DataSet();
        da.Fill(ds);
        dlreviews.DataSource = ds;
        dlreviews.DataBind();
        con.Close();
    }
    protected void submit_Click(object sender, ImageClickEventArgs e)
    {
        
        date = DateTime.Now.ToString();
        con.Open();
        SqlCommand cmd = new SqlCommand("Sp_Adreviews", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@Name", txtname.Text);
        cmd.Parameters.AddWithValue("@Email", txtemail.Text);
        cmd.Parameters.AddWithValue("@Comments", txtcomments.Text);
        cmd.Parameters.AddWithValue("@pageid", pageid);
        cmd.Parameters.AddWithValue("@postdate", date);
        cmd.ExecuteNonQuery();
        con.Close();
        txtcomments.Text = "";
        txtemail.Text = "";
        txtname.Text = "";
        Bindata();
    }
}
