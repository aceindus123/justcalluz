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
/// <summary>
/// class to view the users of justcalluz.com
/// </summary>
public partial class admin_Admin_RegUsersDetails : System.Web.UI.Page
{
    //making connection and declaration of variable
    string UserId;
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
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
        //loads the page without postbacking the values
        if (!IsPostBack)
        {
            UserDetails();
        }
    }
    /// <summary>
    /// Getting justcalluz.com user details and binding to view
    /// </summary>
    private void UserDetails()
    {
        Int16 Id = Convert.ToInt16(Request.QueryString["rid"]);
        Binddata obj = new Binddata();
        DataSet ds = new DataSet();
        con.Open();
        ds = obj.bindRegisteredusersDetails(Id);
        dlUsersInfo.DataSource = ds;
        dlUsersInfo.DataBind();
        con.Close();
    }
    /// <summary>
    /// Binding datalist dynamically and make visibility conditions
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void dlUsersInfo_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        Label lblRegType = (Label)e.Item.FindControl("lblRegType");
        Label lblBName = (Label)e.Item.FindControl("lblBName");
        Label lblKOB = (Label)e.Item.FindControl("lblKOB");
        Label lblBDesc = (Label)e.Item.FindControl("lblBDesc");
        Label lblAddress = (Label)e.Item.FindControl("lblAddress");
        Label lblLandMark = (Label)e.Item.FindControl("lblLandMark");
        Label lblCity = (Label)e.Item.FindControl("lblCity");
        Label lblState = (Label)e.Item.FindControl("lblState");
        Label lblPincode = (Label)e.Item.FindControl("lblPincode");
        Label lblLandPh = (Label)e.Item.FindControl("lblLandPh");
        Label lblFax = (Label)e.Item.FindControl("lblFax");
        Label lblURL = (Label)e.Item.FindControl("lblURL");

        HtmlTableRow trBInfoHead = (HtmlTableRow)e.Item.FindControl("trBInfoHead");
        HtmlTableRow trBName = (HtmlTableRow)e.Item.FindControl("trBName");
        HtmlTableRow trKOB = (HtmlTableRow)e.Item.FindControl("trKOB");
        HtmlTableRow trBdesc = (HtmlTableRow)e.Item.FindControl("trBdesc");
        HtmlTableRow trAddress = (HtmlTableRow)e.Item.FindControl("trAddress");
        HtmlTableRow trLandMark = (HtmlTableRow)e.Item.FindControl("trLandMark");
        HtmlTableRow trCity = (HtmlTableRow)e.Item.FindControl("trCity");
        HtmlTableRow trState = (HtmlTableRow)e.Item.FindControl("trState");
        HtmlTableRow trPincode = (HtmlTableRow)e.Item.FindControl("trPincode");
        HtmlTableRow trLandPh = (HtmlTableRow)e.Item.FindControl("trLandPh");
        HtmlTableRow trFax = (HtmlTableRow)e.Item.FindControl("trFax");
        HtmlTableRow trURL = (HtmlTableRow)e.Item.FindControl("trURL");

        if (lblRegType != null)
        {
            if (lblRegType.Text == "Individual")
            {
                trAddress.Visible = false;
                trBdesc.Visible = false;
                trBInfoHead.Visible = false;
                trBName.Visible = false;
                trCity.Visible = true;
                trFax.Visible = false;
                trKOB.Visible = false;
                trLandMark.Visible = false;
                trLandPh.Visible = false;
                trPincode.Visible = true;
                trState.Visible = true;
                trURL.Visible = false;
            }
            else if (lblRegType.Text == "Business")
            {
                trAddress.Visible = true;
                trBdesc.Visible = true;
                trBInfoHead.Visible = true;
                trBName.Visible = true;
                trCity.Visible = true;
                trFax.Visible = true;
                trKOB.Visible = true;
                trLandMark.Visible = true;
                trLandPh.Visible = true;
                trPincode.Visible = true;
                trState.Visible = true;
                trURL.Visible = true;
            }
        }
        if (trAddress != null)
        {
            if (lblAddress.Text != "")
            {
                trAddress.Visible = true;
            }
            else
            {
                trAddress.Visible = false;
            }
        }
        if (trFax != null)
        {
            if (lblFax.Text != "")
            {
                trFax.Visible = true;
            }
            else
            {
                trFax.Visible = false;
            }
        }
        if (trLandMark != null)
        {
            if (lblLandMark.Text != "")
            {
                trLandMark.Visible = true;
            }
            else
            {
                trLandMark.Visible = false;
            }
        }
        if (trLandPh != null)
        {
            if (lblLandPh.Text != "")
            {
                trLandPh.Visible = true;
            }
            else
            {
                trLandPh.Visible = false;
            }
        }
        if (trURL != null)
        {
            if (lblURL.Text != "")
            {
                trURL.Visible = true;
            }
            else
            {
                trURL.Visible = false;
            }
        }

    }
}
