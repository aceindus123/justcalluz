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
using AjaxControlToolkit;
using CallUsCareers.career;
/// <summary>
/// To display Careers
/// </summary>
public partial class admin_Admin_Careers : System.Web.UI.Page
{
    // Making Sql Connection
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    //Creating Object
    DataSet ds = new DataSet();
    Binddata obj = new Binddata();
    CareersCS career = new CareersCS();
    //Declaration of variables
    string JobTitle;
    Int16 JobId;
    string JExpireDate;
    string NewJExpire;
    string UserId;
    string strScripts;
    string CareersEdit;
    string CareersDel;
    Int32 Id;
    string designation;
    /// <summary>
    /// Executes whenever page loads
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Page_Load(object sender, EventArgs e)
    {
        // Checking Status of Login
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
        CareersEdit = Convert.ToString(Session["CareersEdit"]);
        CareersDel = Convert.ToString(Session["CareersDel"]);
        // loads the page without postbacking the values
        if (!IsPostBack)
        {           
            ItemsGet();

        }
    }
    /// <summary>
    /// To get Careers Posted 
    /// </summary>
    private void ItemsGet()
    {    
        //to open sql connection
        con.Open();
        //to fill dataset        
        ds = obj.bindAdminCareers();        
        DataView dtView = ds.Tables[0].DefaultView;
        //Condition to check dataset has files or not. If dataset has files it enters into if part or it enters into else part
        if (!ds.Tables[0].Rows.Count.Equals(0))
        {
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                DataTable dt = ds.Tables[0];
                //if (i == 6)
                //{
                //    dt.Rows[i].Delete();
                //}

                if (Convert.ToString(ds.Tables[0].Rows[i]["JobId"].ToString()) == "" || Convert.ToString(ds.Tables[0].Rows[i]["JobId"].ToString()) == null)
                {
                    dt.Rows[i].Delete();
                }
                else
                {

                }
            }
            //Binding grid with database values
            ViewGrid.DataSource = ds;
            ViewGrid.DataBind();
            //GridVisibilityConditions();
            lblrecords.Text = "Note:"+"<br/>"+"To View the Applications click on the number present in No. of Applicants column"+"<br/>"+"To View Careers in detail please click on Job Title";
        }
        else
        {
            lblMessage.Text = "No Careers to Display";
        }
        //to close connection
        con.Close();
    }    
    /// <summary>
    /// To pop up a window for extending of the job availability of careers using modal popup extender
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lnkExtend(object sender, CommandEventArgs e)
    {
        //To get the perticular job id from grid view
        Int16 Id = Convert.ToInt16(e.CommandArgument.ToString());
        //Fill dataset 
        con.Open();
        ds = obj.bindAdminCareersDetais(Id);
        if (!ds.Tables[0].Rows.Count.Equals(0))
        {
            JobTitle = ds.Tables[0].Rows[0]["title"].ToString();           
        }
        con.Close();
        lblId.Text = Id.ToString(); 
        lblJobTitle.Text = JobTitle; 
        //To show modal pop up extender              
        ModalPopupExtender1.Show();               
    }
    /// <summary>
    /// To view the Number of applications for a particular career
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lnkViewApplications(object sender, CommandEventArgs e)
    {
        Int16 jobId = Convert.ToInt16(e.CommandArgument.ToString());
        Response.Redirect("Admin_CareersAplications.aspx?jobid=" + jobId);
    }
    /// <summary>
    /// To extend the job availability of a particular career by entering no. of days of extension
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void submitbutton_Click(object sender, EventArgs e)
    {
        //To get careers job id
        JobId = Convert.ToInt16(lblId.Text.ToString());
        //To open connection
        con.Open();
        //To fill dataset
        ds = obj.bindAdminCareersDetais(JobId);
        if (!ds.Tables[0].Rows.Count.Equals(0))
        {
          JExpireDate = ds.Tables[0].Rows[0]["expire_date"].ToString();
        }
        con.Close();
        string noofdays = txtNoofDays.Text.ToString(); ;
        string qry = "update jcalluzcareers set expire_date=(select DATEADD(dd," + noofdays + ",expire_date)) where jobid=" + JobId;
        SqlCommand cmd = new SqlCommand(qry, con);
        //To open connection
        con.Open();
        //To execute command
        cmd.ExecuteNonQuery();
        //To close connection
        con.Close();      
        txtNoofDays.Text = "";
        //Alert
        strScripts = "alert('Job Extended Successfully');location.replace('Admin_Careers.aspx');";
        Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScripts, true);
    }
    /// <summary>
    /// To cacel the extension of job availability
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void cancelbutton_Click(object sender, EventArgs e)
    {
          
    }
    /// <summary>
    /// For paging
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void ViewGrid_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        ViewGrid.PageIndex = e.NewPageIndex;
        ItemsGet();
    }
    /// <summary>
    /// To edit careers
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lnkEdit_Click(object sender, EventArgs e)
    {
        foreach (GridViewRow gvrow in ViewGrid.Rows)
        {
            CheckBox chk = (CheckBox)gvrow.FindControl("CheckBoxreq");
            if (chk != null & chk.Checked)
            {
                Id = Convert.ToInt32(ViewGrid.DataKeys[gvrow.RowIndex].Value.ToString());
            }
        }
        Response.Redirect("Admin_CareersEdit.aspx?cid=" + Id);
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
    /// <summary>
    /// Visibility conditions for the columns of grid view
    /// </summary>
    //public void GridVisibilityConditions()
    //{
    //    if (CareersEdit == "1")
    //    {
    //        ViewGrid.Columns[8].Visible = true;
    //    }
    //    else
    //    {
    //        ViewGrid.Columns[8].Visible = false;
    //    }
    //    if (CareersDel == "1")
    //    {
    //        ViewGrid.Columns[10].Visible = true;
    //    }
    //    else
    //    {
    //        ViewGrid.Columns[10].Visible = false;
    //    }
    //}
    /// <summary>
    /// To delete record of careers by passing respective Id
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lnkDelete_Click(object sender, EventArgs e)
    {
        
        foreach (GridViewRow gvrow in ViewGrid.Rows)
        {
            CheckBox chk = (CheckBox)gvrow.FindControl("CheckBoxreq");
            if (chk != null & chk.Checked)
            {
                Id = Convert.ToInt32(ViewGrid.DataKeys[gvrow.RowIndex].Value.ToString());
            }
        }
        
        Int32 status = career.DeleteCareers(Id);
        if (status <= 1)
        {
            strScripts = "alert('Career deleted Successfully');location.replace('Admin_Careers.aspx');";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScripts, true);
        }
    }
   
}
