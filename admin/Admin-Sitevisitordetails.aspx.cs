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
/// To display Visitor Details
/// </summary>

public partial class admin_Admin_Sitevisitordetails : System.Web.UI.Page
{
    //creation of object for class
    DataCS obj = new DataCS();
    //Creation of SQl connection
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    //Creating Object
    DataSet ds = new DataSet();
    //Declaration of variables   
    string UserId;
    string strScript = "";
    Int32 id;
    string designation;
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
                        
            ItemsGet();
        }

    }
    /// <summary>
    /// Functionality whenever page changed
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void ViewGrid_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        ViewGrid.PageIndex = e.NewPageIndex;
        ItemsGet();
    }
    /// <summary>
    /// Getting visitor details from the database
    /// </summary>
    private void ItemsGet()
    {
        //to open sql connection
        con.Open();
        //to fill dataset        
        ds = obj.GetVisitorsDetails();
        DataView dtView = ds.Tables[0].DefaultView;
        //Condition to check dataset has files or not. If dataset has files it enters into if part or it enters into else part
        if (!ds.Tables[0].Rows.Count.Equals(0))
        {
           //Binding grid with database values
            ViewGrid.DataSource = ds;
            ViewGrid.DataBind();
        }
       //to close connection
        con.Close();
    }
    /// <summary>
    /// click event to view visitor details
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    //protected void ViewDetails_Click(object sender, EventArgs e)
    //{
    //    for (int i = 0; i < ViewGrid.Rows.Count; i++)
    //    {
    //        CheckBox cbox = (CheckBox)ViewGrid.Rows[i].FindControl("CheckBoxreq");
    //        Button btnview = (Button)sender;
    //        if (cbox.Checked)
    //        {

    //            id = Convert.ToInt32(ViewGrid.DataKeys[i].Values[0].ToString());
    //        }
    //    }
    //    Response.Redirect("Admin-Sitevisitordetails.aspx");
    //}
    /// <summary>
    /// To navigate pase based on Login id
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lnkBack_Click(object sender, EventArgs e)
    {
        if (Session["LoginId"] != null)
        {
            designation = Convert.ToString(Session["Designation"]);
            if (designation == "Admin")
            {
                Response.Redirect("Admin-MainPage.aspx");
            }
            else
            {
                Response.Redirect("Admin_Home.aspx");
            }
        }
    }
}