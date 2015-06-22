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
/// class to post white pages data
/// </summary>
public partial class admin_Admin_WhitePagesPost : System.Web.UI.Page
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
    string mod;
    string cat;
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
        //loads the page without postbacking the values
        if (!Page.IsPostBack)
        {
            //fill popular cities
            int post = Convert.ToInt32(Session["WPPost"].ToString());
            if (post == 1)
            {

            }
            else
            {
                string str = "alert('Sorry ! You don't have the permissions to post');location.replace('Admin_WhitePages.aspx');";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "alertbox", strScript, true);
            }
            data.FillPopularCities(ddlPopCity);
        }
    }
    /// <summary>
    /// click event to post white pages data
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void imgBtnPost_Click(object sender, ImageClickEventArgs e)
    {
        data.awpCity = Convert.ToString(ddlPopCity.SelectedValue);
        data.aPara1 = Convert.ToString(txtPara1.Text);
        data.aPara2 = Convert.ToString(txtPara2.Text);
        data.aPara3 = Convert.ToString(txtPara3.Text);
        data.aPara4 = Convert.ToString(txtPara4.Text);
        data.aPara5 = Convert.ToString(txtPara5.Text);
        data.dPostDate = System.DateTime.Now;
        data.dPostedBy = UserId;
        t = data.Insert_WhitePagesData(data.awpCity, data.aPara1, data.aPara2, data.aPara3, data.aPara4, data.aPara5,data.dPostDate,data.dPostedBy);
        if (t == true)
        {
            strScript = "alert('White Pages Data is posted sucessfully');location.replace('Admin_WhitePages.aspx');";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertbox", strScript, true);
        }
    }
    /// <summary>
    /// executes whenever popular city selection is changed
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void ddlPopCity_SelectedIndexChanged(object sender, EventArgs e)
    {
        ds = data.getWPCity(ddlPopCity.SelectedValue);
        if (!ds.Tables[0].Rows.Count.Equals(0))
        {
            city = ds.Tables[0].Rows[0]["City"].ToString();
            strScript = "alert('The description for the " + city + " already existed please select other city');";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertbox", strScript, true);
            ddlPopCity.SelectedIndex = 0;
        }
        else
        {
            ds1 = data.getWPCategories(ddlPopCity.SelectedValue);            
            lblCity.Text = Convert.ToString(ddlPopCity.SelectedValue);
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
}
