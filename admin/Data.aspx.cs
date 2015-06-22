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
using System.Collections.Specialized;
using System.Reflection;
using System.Collections.Generic;
using System.Data.SqlClient;

public partial class Data : System.Web.UI.Page
{
    InsertData obj = new InsertData();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    [System.Web.Script.Services.ScriptMethod()]
    [System.Web.Services.WebMethod]
    public static List<string> Searchcatageorylist(string prefixText, int count)
    {
        using (SqlConnection conn = new SqlConnection())
        {
            conn.ConnectionString = ConfigurationManager
                    .ConnectionStrings["sidardhConnectionString"].ConnectionString;
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "select catname from catageorylist where " +
                "catname like @SearchText + '%'";
                cmd.Parameters.AddWithValue("@SearchText", prefixText);
                cmd.Connection = conn;
                conn.Open();
                List<string> customers = new List<string>();
                using (SqlDataReader sdr = cmd.ExecuteReader())
                {
                    while (sdr.Read())
                    {
                        customers.Add(sdr["catname"].ToString());
                    }
                }
                conn.Close();
                return customers;
            }
        }
    }


    protected void bt1submit_Click(object sender, EventArgs e)
    {
        DataSet ds = new DataSet();
        try
        {

            string cname = txtname.Text.ToString();
            string cat = TextBox1.Text.ToString();
            string area = txtarea.Text.ToString();
            string ph = txtph.Text.ToString();
            string mob = txtmobile.Text.ToString();
            string addr = txtaddr.Text.ToString();
            string state = txtstate.Text.ToString();
            string conper = txtcp.Text.ToString();
            string email = txtemail.Text.ToString();
            //DateTime optim = Convert.ToDateTime(txtopt.Text.ToString());
            string city = txtcity.Text.ToString();
            string compdet = txtcomp.Text.ToString();
            ds = obj.insert_data(cname, cat, area, ph, mob, addr, state, conper, email,city,compdet);


        }
        catch (Exception ex)
        {
            ex.ToString();

        }

        DataTable dt = new DataTable();
        SqlConnection connection = new SqlConnection("Password=Mnhbs@123;Persist Security Info=True;User ID=jcalluz;Initial Catalog=jcalluz;Data Source=jcalluz.db.8035572.hostedresource.com");
        
            connection.Open();
            string sqlStatement = "SELECT * FROM data";
            SqlCommand cmd = new SqlCommand(sqlStatement, connection);
            SqlDataAdapter sqlDa = new SqlDataAdapter(cmd);

            sqlDa.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
        }

  
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Edit.aspx");
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Delete.aspx");
    }
    protected void bt2reset_Click(object sender, EventArgs e)
    {
        txtname.Text = "";
        TextBox1.Text = "";
        txtph.Text = "";
        txtarea.Text = "";
        txtph.Text = "";
        txtmobile.Text = "";
        txtaddr.Text = "";
        txtstate.Text = "";
        txtcp.Text = "";
        txtemail.Text = "";
        txtcity.Text = "";
        txtcomp.Text = "";
    }
}
