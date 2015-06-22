using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using JustCallUsData.Data;
/// <summary>
/// class to update white pages data
/// </summary>
public partial class admin_Admin_WhitePagesEdit : System.Web.UI.Page
{

    //making connection
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    //declaration of variables and creation of objects for classes
    DataCS data = new DataCS();
    bool t;
    string strScript;
    DataSet ds = new DataSet();
    DataSet ds1 = new DataSet();
    string city;
    string para1;
    string para2;
    string para3;
    string para4;
    string para5;
    Int32 WpId;
    string UserId;
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
        WpId = Convert.ToInt32(Request.QueryString["wpid"]);
        //loads the page without postbacking the values
        if (!Page.IsPostBack)
        {
            //fill popular cities
            data.FillPopularCities(ddlPopCity);            
            ds = data.BindPerticular_WP(WpId);
            if (!ds.Tables[0].Rows.Count.Equals(0))
            {
                city = ds.Tables[0].Rows[0]["City"].ToString();
                para1 = ds.Tables[0].Rows[0]["Para1"].ToString();
                para2 = ds.Tables[0].Rows[0]["Para2"].ToString();
                para3 = ds.Tables[0].Rows[0]["Para3"].ToString();
                para4 = ds.Tables[0].Rows[0]["Para4"].ToString();
                para5 = ds.Tables[0].Rows[0]["Para5"].ToString();
            }
            for (int i = 0; i < ddlPopCity.Items.Count; i++)
            {
                if (ddlPopCity.Items[i].Value == city.ToString())
                {
                    ddlPopCity.SelectedValue = ddlPopCity.Items[i].Value;
                    break;
                }
            }
            txtPara1.Text = para1;
            txtPara2.Text = para2;
            txtPara3.Text = para3;
            txtPara4.Text = para4;
            txtPara5.Text = para5;

            ds1 = data.getWPCategories(ddlPopCity.SelectedValue);
            lblCity.Text = city;
            if (!ds1.Tables[0].Rows.Count.Equals(0))
            {
                lblRecord.Text = "";
                trcity.Visible = true;
                trrepeater.Visible = true;
                trinfo.Visible = true;
                repeterCategories.DataSource = ds1;
                repeterCategories.DataBind();
            }
            else
            {
                trcity.Visible = true;
                trrepeater.Visible = false;
                trinfo.Visible = false;
                lblRecord.Text = "Not found";
            }
        }
    }
    protected void imgBtnUpdate_Click(object sender, ImageClickEventArgs e)
    {
        data.awpCity = Convert.ToString(ddlPopCity.SelectedValue);
        data.aPara1 = Convert.ToString(txtPara1.Text);
        data.aPara2 = Convert.ToString(txtPara2.Text);
        data.aPara3 = Convert.ToString(txtPara3.Text);
        data.aPara4 = Convert.ToString(txtPara4.Text);
        data.aPara5 = Convert.ToString(txtPara5.Text);
        data.dPostDate = System.DateTime.Now;
        data.dPostedBy = UserId;
        data.awpId = WpId;
        t = data.Update_WhitePagesData(data.awpId, data.aPara1, data.aPara2, data.aPara3, data.aPara4, data.aPara5, data.dPostDate, data.dPostedBy);
        if (t == true)
        {
            strScript = "alert('White Pages Data is updated sucessfully');location.replace('Admin_WhitePages.aspx');";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertbox", strScript, true);
        }
    }
}
