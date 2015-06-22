using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
/// <summary>
/// To display Ads
/// </summary>
public partial class admin_Admin_Ads : System.Web.UI.Page
{
    //creation of object for class
    AdsCS obj = new AdsCS();
    //Creation of SQl connection
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    //Creating Object
    DataSet ds = new DataSet();
    //Declaration of variables
    string cat;
    string UserId;
    string AdsEdit;
    string AdsDel;
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
        //Getting Web Admin permissions
        AdsEdit = Convert.ToString(Session["AdsEdit"]);
        AdsDel = Convert.ToString(Session["AdsDel"]);
        //loads the page without postbacking the values
        if(!Page.IsPostBack)
        {
            //to fill Ad Types
            obj.FillAdType(ddlAdType);
            if (Request.QueryString["cat"] != null)
            {
                cat = Convert.ToString(Request.QueryString["cat"]);
                ddlAdType.SelectedValue = cat;

            }
            else
            {
               // cat = "TV Ads";
                //ddlAdType.SelectedValue = cat;
                ddlAdType.SelectedValue.Insert(0, "Select Ad Type");
                cat = "";
            }
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
    /// Getting Ads from the database
    ///// </summary>
    private void ItemsGet()
    {
        cat = ddlAdType.SelectedValue;
        if (cat == "Select Ad Type")
        {
            con.Open();
            string statement="select * from Ads";
             SqlDataAdapter imgtext= new SqlDataAdapter(statement, con);
            imgtext.Fill(ds, "Ads");                     
           DataView dtView = ds.Tables[0].DefaultView;
     if (!ds.Tables[0].Rows.Count.Equals(0))
      {

     
     for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
     {
           cat = ds.Tables[0].Rows[0]["AdType"].ToString();

           ViewGrid.Visible = true;
           lblrecordsadsdata.Visible = false;
         GridVisibilityConditions(cat);
         
         //Binding grid with database values
         ViewGrid.DataSource = ds;
         ViewGrid.DataBind();
         btnView.Visible = true;
         btnEdit.Visible = true;
         btnDelete.Visible = true;
         lblMessage.Visible = false;
     }
 }
            con.Close();
        }
           
        else
        {
            
            cat = ddlAdType.SelectedItem.Text;

            DataSet sddata = obj.GetAds(cat);
          //  DataView dtView = sddata.Tables[0].DefaultView;
            //Condition to check dataset has files or not. If dataset has files it enters into if part or it enters into else part
            if (!sddata.Tables[0].Rows.Count.Equals(0))
            {
               
                cat = sddata.Tables[0].Rows[0]["AdType"].ToString();
                ViewGrid.Visible = true;
                GridVisibilityConditions(cat);
                //Binding grid with database values
                ViewGrid.DataSource = sddata;
                ViewGrid.DataBind();
                btnView.Visible = true;
                btnEdit.Visible = true;
                btnDelete.Visible = true;
                lblrecordsadsdata.Visible = false;
            }

        
        else
        {
           // lblMessage.Text = "No Ads to Display";
            lblrecordsadsdata.Text = "<b>Records for the category of Ads  in the " + cat + " module are not found. </b>";
            lblrecordsadsdata.Visible = true;
            ViewGrid.Visible = false;
            btnView.Visible = false;
            btnEdit.Visible = false;
            btnDelete.Visible = false;
            //to open sql connection
          
        }
    }
    }
    /// <summary>
    /// Defining visibility for the columns of the Grid
    /// </summary>
    /// <param name="Cat"></param>
    public void GridVisibilityConditions(string Cat)
    {        
        if (Cat == "TV Ads")
        {
            ViewGrid.Columns[0].Visible = true;
            ViewGrid.Columns[1].Visible = true;
            ViewGrid.Columns[2].Visible = true;
            ViewGrid.Columns[3].Visible = false;
            ViewGrid.Columns[4].Visible = false;
            ViewGrid.Columns[5].Visible = false;
            ViewGrid.Columns[6].Visible = true;
            ViewGrid.Columns[7].Visible = true;
            ViewGrid.Columns[8].Visible = true;
            ViewGrid.Columns[9].Visible = true;            
        }
        else if (Cat == "Radio Ads")
        {
            ViewGrid.Columns[0].Visible = true;
            ViewGrid.Columns[1].Visible = false;
            ViewGrid.Columns[2].Visible = true;
            ViewGrid.Columns[3].Visible = true;
            ViewGrid.Columns[4].Visible = false;
            ViewGrid.Columns[5].Visible = false;
            ViewGrid.Columns[6].Visible = true;
            ViewGrid.Columns[7].Visible = true;
            ViewGrid.Columns[8].Visible = false;
            ViewGrid.Columns[9].Visible = false;
            //ViewGrid.Columns[11].Visible = true;
            //ViewGrid.Columns[12].Visible = true;
        }
        else if (Cat == "Print Ads")
        {
            ViewGrid.Columns[0].Visible = true;
            ViewGrid.Columns[1].Visible = false;
            ViewGrid.Columns[2].Visible = false;
            ViewGrid.Columns[3].Visible = false;
            ViewGrid.Columns[4].Visible = true;
            ViewGrid.Columns[5].Visible = true;
            ViewGrid.Columns[6].Visible = true;
            ViewGrid.Columns[7].Visible = true;
            ViewGrid.Columns[8].Visible = false;
            ViewGrid.Columns[9].Visible = false;
            //ViewGrid.Columns[11].Visible = true;
            //ViewGrid.Columns[12].Visible = true;
        }
        //Checking the permissions for webadmin 
        if (AdsEdit == "1")
        {
            btnEdit.Enabled = true;
        }
        else
        {
            btnEdit.Enabled = false;
        }
        if (AdsDel == "1")
        {
            btnDelete.Enabled = true;
        }
        else
        {
            btnDelete.Enabled = false;
        }
    }
    /// <summary>
    /// executes when selection of ad type is changed
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void ddlAdType_SelectedIndexChanged(object sender, EventArgs e)
    {
      
        //string s = ddlAdType.SelectedItem.Text;
        //cat = ddlAdType.SelectedValue;
        ItemsGet();
    }
    /// <summary>
    /// click event to view ads details
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void ViewDetails_Click(object sender, EventArgs e)
    {
        for (int i = 0; i < ViewGrid.Rows.Count; i++)
        {
            CheckBox cbox = (CheckBox)ViewGrid.Rows[i].FindControl("CheckBoxreq");
            Button btnview = (Button)sender;
            if (cbox.Checked)
            {

               id = Convert.ToInt32(ViewGrid.DataKeys[i].Values[0].ToString());
            }
        }
        Response.Redirect("Admin_AdsEdit.aspx?type=View&adid=" + id);
    }
    /// <summary>
    /// click event to edit ads details
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void EditDetails_Click(object sender, EventArgs e)
    {
        for (int i = 0; i < ViewGrid.Rows.Count; i++)
        {
            CheckBox cbox = (CheckBox)ViewGrid.Rows[i].FindControl("CheckBoxreq");
            Button btnview = (Button)sender;
            if (cbox.Checked)
            {

                id = Convert.ToInt32(ViewGrid.DataKeys[i].Values[0].ToString());
            }
        }
        Response.Redirect("Admin_AdsEdit.aspx?type=Edit&adid=" + id);
    }
    /// <summary>
    /// click event to delete already existed ads
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lnkDelete_Click(object sender, EventArgs e)
    {
        cat = Convert.ToString(ddlAdType.SelectedItem.Text);
        for (int i = 0; i < ViewGrid.Rows.Count; i++)
        {
            CheckBox cbox = (CheckBox)ViewGrid.Rows[i].FindControl("CheckBoxreq");
            if (cbox.Checked)
            {
                id = Convert.ToInt32(ViewGrid.DataKeys[i].Values[0].ToString());
            }
        }
        string qry = "delete from Ads where adid=" + id;
        SqlCommand cmd = new SqlCommand(qry, con);
        con.Open();
       int result=Convert.ToInt32(cmd.ExecuteNonQuery());
        con.Close();
        if (result == 1)
        {
            strScript = "alert('Deleted successfully');location.replace('Admin_Ads.aspx?cat=" + cat + "');";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertbox", strScript, true);
        }
    }
    protected void ViewGrid_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {

            var lblcreatedon = e.Row.FindControl("lblCreatedate") as Label;
            string createdate = lblcreatedon.Text;
            if (createdate == null || createdate == "NULL" || createdate == "")
            {

            }
            else
            {
                lblcreatedon.Text = DateTime.Parse(createdate).ToString("dd MMM yyyy");
            }

        }
    }
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
