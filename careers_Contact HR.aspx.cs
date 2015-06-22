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
using CallUsCareers.career;
using IndusAbroad.DataAccessLayer;
using System.Drawing;
using System.Collections.Generic;
using System.Web.Routing;

public partial class example6 : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    CareersCS ccs = new CareersCS();
    InsertData obj = new InsertData();
    static string excep_page = "careers_Contact HR.aspx";
    string loc;
    int id;
    string cmpcity = string.Empty;
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            try
            {
                phonedetails.Visible = false;
                compdetails.Visible = false;
                lblDate.Visible = false;
                DataSet ds = new DataSet();
                ds = ccs.Hyd_Location(loc);
                dlloc.DataSource = ds;
                dlloc.DataBind();
                if (Page.RouteData.Values["cityname"] != null)
                {
                    cmpcity = Convert.ToString(Page.RouteData.Values["cityname"].ToString());
                    BindHrInfo();
                }
               
            }
            catch (Exception ex)
            {
                obj.insert_exception(ex, excep_page);
                Response.Redirect("HttpErrorPage.aspx");
            }
        }
    }
    protected void BindHrInfo()
    {
        try
        {
            phonedetails.Visible = true;
            compdetails.Visible = true;
            lblDate.Visible = true;
            DataSet dsEmail = new DataSet();
            dsEmail = ccs.GetEmails(cmpcity);
            dlEmail.DataSource = dsEmail;
            dlEmail.DataBind();
            DataSet dsCntPersonName = new DataSet();
            dsCntPersonName = ccs.GetContpersonName(cmpcity);
            dlContName.DataSource = dsCntPersonName;
            dlContName.DataBind();
            DataSet dsAddress = new DataSet();
            dsAddress = ccs.GetAddressInfo(cmpcity);
            if (!dsAddress.Tables[0].Rows.Count.Equals(0))
            {

                lbladdress1.Text = dsAddress.Tables[0].Rows[0]["comp_address1"].ToString();
                lbladdress2.Text = dsAddress.Tables[0].Rows[0]["comp_address2"].ToString();
                lblcity.Text = dsAddress.Tables[0].Rows[0]["comp_city"].ToString();
                lblstate.Text = dsAddress.Tables[0].Rows[0]["comp_state"].ToString();
                lblcode.Text = dsAddress.Tables[0].Rows[0]["comp_pincode"].ToString();
                lblphonenum.Text = dsAddress.Tables[0].Rows[0]["cont_num"].ToString();
                lblext.Text = dsAddress.Tables[0].Rows[0]["cont_ext"].ToString();
                lblpDate.Text = dsAddress.Tables[0].Rows[0]["time"].ToString();

            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    [System.Web.Script.Services.ScriptMethod()]
    [System.Web.Services.WebMethod]
    public static List<string> Getcities(string prefixText)
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["connectionstring"]);
        con.Open();
        SqlCommand cmd = new SqlCommand("select * from cities where city_name like @Name+'%'", con);
        cmd.Parameters.AddWithValue("@Name", prefixText);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        da.Fill(dt);
        List<string> citynames = new List<string>();
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            citynames.Add(dt.Rows[i][1].ToString());
        }
        return citynames;
    }
    protected string GetUrlCity(object comp_city)
    {
        string compCity = comp_city.ToString();
        return Page.GetRouteUrl("careershr", new { cityname = compCity });
    }
   
}

