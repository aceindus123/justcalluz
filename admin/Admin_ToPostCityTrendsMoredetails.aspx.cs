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
using System.IO;
/// <summary>
/// class To post more information for the category of city trends
/// </summary>
public partial class admin_Admin_ToPostCityTrendsMoredetails : System.Web.UI.Page
{
    //making connection
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    //creation of object for class and declaration of variables
    Int32 CtId;
    string UserId;
    CityTrendsCS obj = new CityTrendsCS();
    string mod;
    bool t;
    string strScript;
    DataSet dscount = new DataSet();
    Int32 count;
    string id;
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
        CtId = Convert.ToInt32(Request.QueryString["ctid"]);
        mod = Convert.ToString(Request.QueryString["mod"]);
        dscount = obj.GetMoreInfoCount(CtId);
        if (!dscount.Tables[0].Rows.Count.Equals(0))
        {
            count = Convert.ToInt16(dscount.Tables[0].Rows[0]["moreinfocount"].ToString());
        }
        if (count < 2)
        {

        }
        else
        {
            Response.Redirect("Admin_ToEditCityTrends.aspx?CtId=" + CtId);
            //strScript = "alert('You can post 2 only');location.replace('Admin_CityTrends.aspx?mod=" + mod+"');";
            //Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
        }
    }
    /// <summary>
    /// click event to post more info
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void imgBtnPostMore_Click(object sender, ImageClickEventArgs e)
    {       
        if (count < 3)
        {
            obj.mctMInfoTitle = Convert.ToString(txtTitle.Text);
            obj.mctMInfoDesc = Convert.ToString(txtDesc.Text);
            obj.ctPostdate = DateTime.Now;
            obj.ctUserId = UserId;
            obj.ctMod = mod;
            obj.ctId = CtId;
            t = obj.CityTrendsMoreInfo_Post(obj.mctMInfoTitle, obj.mctMInfoDesc, obj.ctId, obj.ctMod, obj.ctUserId, obj.ctPostdate);
            id = Convert.ToString(CtId);
            if (mod == "Companies")
            {
                strScript = "alert('More details of City Trend in Companies Category is Posted Successfully.');location.replace('Admin_ToPostCityTrendsMoredetails.aspx?ctid=" + CtId + "&mod=" + mod + "');";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
            }
            else if (mod == "Education")
            {
                strScript = "alert('More details of City Trend in Education Category is Posted Successfully.');location.replace('Admin_ToPostCityTrendsMoredetails.aspx?ctid=" + CtId + "&mod=" + mod + "');";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
            }
            else if (mod == "Health")
            {
                strScript = "alert('More details of City Trend in Health Category is Posted Successfully.');location.replace('Admin_ToPostCityTrendsMoredetails.aspx?ctid=" + CtId + "&mod=" + mod + "');";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
            }
            else if (mod == "Hotels & Restaurants")
            {
                strScript = "alert('More details of City Trend in Hotels & Restaurants Category is Posted Successfully.');location.replace('Admin_ToPostCityTrendsMoredetails.aspx?ctid=" + CtId + "&mod=" + mod + "');";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
            }
            else if (mod == "Tours and Travel")
            {
                strScript = "alert('More details of City Trend in Tours and Travel Category is Posted Successfully.');location.replace('Admin_ToPostCityTrendsMoredetails.aspx?ctid=" + CtId + "&mod=" + mod + "');";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
            }
        }       
    }    
    /// <summary>
    /// To cancel posting of more information
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void cancelbutton_Click(object sender, EventArgs e)
    {
        txtLink.Text = "";
        txtLinkTitle.Text = "";
    }
}
