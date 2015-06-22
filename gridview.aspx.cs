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

public partial class gridview : System.Web.UI.Page
{
    InsertData obj = new InsertData();
    protected void Page_Load(object sender, EventArgs e)
    {
        //GridView1.Visible = false;
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
                cmd.CommandText = "select cat from data where " +
                "cat like @SearchText + '%'";
                cmd.Parameters.AddWithValue("@SearchText", prefixText);
                cmd.Connection = conn;
                conn.Open();
                List<string> customers = new List<string>();
                using (SqlDataReader sdr = cmd.ExecuteReader())
                {
                    while (sdr.Read())
                    {
                        customers.Add(sdr["cat"].ToString());
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
            string city = txtcity.Text.ToString();
            string compdet = txtcomp.Text.ToString();
            ds = obj.insert_data(cname, cat, area, ph, mob, addr, state, conper, email, city, compdet);

            GridView1.Visible = true;
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
    }
    protected void bt2reset_Click(object sender, EventArgs e)
    {
        txtname.Text = "";
        txtarea.Text = "";
        TextBox1.Text = "";
        txtph.Text = "";
        txtstate.Text = "";
        txtmobile.Text = "";
        txtaddr.Text = "";
        txtcp.Text = "";
        txtemail.Text = "";
        txtcomp.Text = "";
    }
}
