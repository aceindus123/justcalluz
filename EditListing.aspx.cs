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
using System.Collections.Generic;

public partial class EditListing : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    int id;
    string businame;
    string qry;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["id"] != null)
        {
            id = Convert.ToInt16(Request.QueryString["id"]);
        }
        if (Request.QueryString["cname"] != null)
        {
            businame = Request.QueryString["cname"].ToString();
        }
       lblbusiness.Text = "'" + businame + "'";
       txtBName.Text = businame;
       txtBName.ReadOnly = true;
       txtBName.Enabled = true;
       txtBName.BackColor = System.Drawing.Color.White;
        if(!IsPostBack)
        {
            qry = "select * from modulesdata where company_name='" + businame + "'and id=" + id;
            con.Open();
            SqlCommand cmd=new SqlCommand(qry,con);
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                txtLMark.Text = dr["land_mark"].ToString();
                txtArea.Text = dr["Area"].ToString();
                txtCity.Text = dr["City"].ToString();
                txtState.Text = dr["State"].ToString();
                txtStreet.Text = dr["address"].ToString();
                txtBuilding.Text = dr["State"].ToString();
                txtCountry.Text = "India";
                ddlPCode.SelectedItem.Text = dr["Pincode"].ToString();
            }
            con.Close();
        }
    }
    [System.Web.Script.Services.ScriptMethod()]
    [System.Web.Services.WebMethod]
    public static List<string> Getcities(string prefixText)
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
        SqlCommand cmd = new SqlCommand("select distinct CityName from Pincodes where CityName like @Name+'%'", con);
        cmd.Parameters.AddWithValue("@Name", prefixText);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        da.Fill(dt);
        List<string> citynames = new List<string>();
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            citynames.Add(dt.Rows[i][0].ToString());
        }
        return citynames;
    }
    protected void txtCity_TextChanged(object sender, EventArgs e)
    {
        string qry = "select distinct Pincode from pincodes where CityName='" + txtCity.Text + "'";
        con.Open();
        SqlDataAdapter da = new SqlDataAdapter(qry,con);
        DataSet ds = new DataSet();
        da.Fill(ds);
        ddlPCode.DataSource = ds;
        ddlPCode.DataTextField = "Pincode";
        ddlPCode.DataValueField = "Pincode";
        ddlPCode.DataBind();
        con.Close();
        
        con.Open();
        SqlCommand cmd = new SqlCommand("select State from Pincodes where CityName='" + txtCity.Text + "'",con);
        SqlDataReader dr = cmd.ExecuteReader();
        while (dr.Read())
        {
            txtState.Text = dr["State"].ToString();
        }
        con.Close();
        txtCountry.Text = "India";
       
    }
}
