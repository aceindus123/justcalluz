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
/// class To edit more information for the category of city trends
/// </summary>
public partial class admin_Admin_EditCTMoreInfo : System.Web.UI.Page
{
    //creation of object for class and declaration of variables
    string UserId;
    Int32 moreId;
    CityTrendsCS obj = new CityTrendsCS();
    DataSet ds = new DataSet();
    string MITitle;
    string MIDesc;
    Int32 ctId;
    string strScript;
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
        moreId = Convert.ToInt32(Request.QueryString["MoreId"].ToString());
        // loads the page without postbacking the values
        if (!IsPostBack)
        {
            ds = obj.GetMoreInfoParticular(moreId);
            if (!ds.Tables[0].Rows.Count.Equals(0))
            {
                MITitle = ds.Tables[0].Rows[0]["MTitle"].ToString();
                MIDesc = ds.Tables[0].Rows[0]["MInfo"].ToString();
                ctId = Convert.ToInt32(ds.Tables[0].Rows[0]["ctId"].ToString());
            }
            txtTitle.Text = MITitle;
            txtDesc.Text = MIDesc;                    
        }       
    }  
    /// <summary>
    /// click event to update more info
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void BtnUpdateMore_Click(object sender, EventArgs e)
    {
        obj.mctMId = moreId;
        obj.mctMInfoTitle = Convert.ToString(txtTitle.Text);
        obj.mctMInfoDesc = Convert.ToString(txtDesc.Text);
        bool t = obj.ToEditCTMoreInfo(obj.mctMInfoTitle, obj.mctMInfoDesc, obj.mctMId);
        strScript = "alert('More information is updated successfully');location.replace('Admin_ToEditCityTrends.aspx?CtId=" + ctId + "');";
        Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
    }
    /// <summary>
    /// To cancel update
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void cancelbutton_Click(object sender, EventArgs e)
    {
        
    }
    /// <summary>
    /// click event to insert link for a text selected in textbox
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void imgBtnLink_Click(object sender, ImageClickEventArgs e)
    {               
        //txtDesc.Attributes.Add("onfocus", "getSelText();");
        ModalPopupExtender1.Show();
    }
    protected void  BtnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("Admin_ToEditCityTrends.aspx?CtId=" + ctId);
    }

}
