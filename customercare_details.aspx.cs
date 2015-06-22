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
using JustCallUsData.Data;
using System.Data.SqlClient;
using System.Web.Routing;

public partial class customercare_details : System.Web.UI.Page
{
    DataCS obj1 = new DataCS();
    InsertData obj = new InsertData();
    static string excep_page = "customercare_details.aspx";
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["connectionstring"]);
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
           
            string city = Convert.ToString(Page.RouteData.Values["city"].ToString());
            string cmp = Convert.ToString(Page.RouteData.Values["cmpname"].ToString());
            string area = Convert.ToString(Page.RouteData.Values["area"].ToString());
            DataSet dscustom = new DataSet();
            dscustom = obj1.custom(cmp, area, city);
            if (dscustom.Tables[0].Rows.Count > 1)
            {
                dlcustomerlist.DataSource = dscustom;
                dlcustomerlist.DataBind();
                ver_img.Visible = false;
                ver_msg.Visible = false;
                ver_msg1.Visible = false;
            }
            else
            {
                dlcustomerlist.DataSource = dscustom;
                dlcustomerlist.DataBind();
                ver_img.Visible = true;
                ver_msg.Visible = true;
                ver_msg1.Visible = true;
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
 }
    //protected void company_det(object sender, CommandEventArgs e)
    //{
    //     int id = Convert.ToInt32(e.CommandArgument.ToString());
    //        DataSet dsdetails = new DataSet();
    //        dsdetails = obj1.custom_det(id);
    //        dlcustomerlist.DataSource = dsdetails;
    //        dlcustomerlist.DataBind();
    //        ver_img.Visible = true;
    //        ver_msg.Visible = true;
    //        ver_msg1.Visible = true;
        
    //}
   
}
