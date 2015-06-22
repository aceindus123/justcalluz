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
/// class to view status of the data like posted by whom or updated by whom and when etc
/// </summary>
public partial class admin_Admin_StatusofDatainDetail : System.Web.UI.Page
{
    //making connection
    SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    string UserId;
    PagedDataSource pds = new PagedDataSource();
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
            GetPostData();
        }
    }    
    /// <summary>
    /// Function to get the data from database when we click on get data button
    /// </summary>
    private void ItemsGet()
    {
        string dId = Convert.ToString(Request.QueryString["id"]);
        DataSet ds = new DataSet();      
        sqlConnection.Open();
        string statement = "select By_EmailId,Date,Statusin=Case When Status=1 Then 'Approved By' when Status=2 Then 'Rejected By' when Status=3 Then 'Updated By' else 'Posted By' End from DataStatus_Details where DataId=" + dId+"  order by id desc";
        SqlDataAdapter imgtext = new SqlDataAdapter(statement, sqlConnection);
        imgtext.Fill(ds, "categoryData");
        DataView dtView = ds.Tables[0].DefaultView;
        if (!ds.Tables[0].Rows.Count.Equals(0))
        {
            //for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            pds.DataSource = ds.Tables[0].DefaultView;
            pds.AllowPaging = true;
            pds.PageSize = 7;
            pds.CurrentPageIndex = CurrentPage;
            lblCurrentPage.Text = "Page: " + (CurrentPage + 1).ToString() + " of " + pds.PageCount.ToString();
            lnkbtnNext.Enabled = !pds.IsLastPage;
            lnkbtnPrevious.Enabled = !pds.IsFirstPage;
            dlStatusDetails.DataSource = ds;
            dlStatusDetails.DataBind();
            lnkbtnNext.Visible = true;
            lnkbtnPrevious.Visible = true;
            lblCurrentPage.Visible = true;
         
        }
        

        DataSet ds1 = new DataSet();
        string qry = "select module,company_name,event_name from ModulesData where id=" + dId;
        SqlDataAdapter ada = new SqlDataAdapter(qry, sqlConnection);
        ada.Fill(ds1);
        if (!ds1.Tables[0].Rows.Count.Equals(0))
        {
            string mod = ds1.Tables[0].Rows[0]["module"].ToString();
            string companyname = ds1.Tables[0].Rows[0]["company_name"].ToString();
            string eventname = ds1.Tables[0].Rows[0]["event_name"].ToString();
            if (mod == "Events")
            {
                lblName.Text = eventname;
                lblName1.Text = mod;
            }
            else
            {
                lblName.Text = companyname;
                lblName1.Text = mod;
            }
        }
        sqlConnection.Close();
    }
    /// <summary>
    /// Get posted data
    /// </summary>
    private void GetPostData()
    {
        string dId = Convert.ToString(Request.QueryString["id"]);
        DataSet ds1 = new DataSet();
        sqlConnection.Open();
        string qry = "select Status='Posted By',module,UserLoginId,postdate from ModulesData where id=" + dId;
        SqlDataAdapter ada = new SqlDataAdapter(qry, sqlConnection);
        ada.Fill(ds1, "categoryData1");
        DataView dtView1 = ds1.Tables[0].DefaultView;
        if (!ds1.Tables[0].Rows.Count.Equals(0))
        {
            //for (int i = 0; i < ds1.Tables[0].Rows.Count; i++)
            //{
            pds.DataSource = ds1.Tables[0].DefaultView;
            pds.AllowPaging = true;
            pds.PageSize = 7;
            pds.CurrentPageIndex = CurrentPage;
            lblCurrentPage.Text = "Page: " + (CurrentPage + 1).ToString() + " of " + pds.PageCount.ToString();
            lnkbtnNext.Enabled = !pds.IsLastPage;
            lnkbtnPrevious.Enabled = !pds.IsFirstPage;
            dlPostDetails.DataSource = pds;
            dlPostDetails.DataBind();
            lnkbtnNext.Visible = true;
            lnkbtnPrevious.Visible = true;
            lblCurrentPage.Visible = true;
            //}
        }
      else
        {
            lblMessage.Text = "No records Available";
        }
        sqlConnection.Close();        
    }
    /// <summary>
    /// To put current page status
    /// </summary>
    public int CurrentPage
    {
        get
        {
            if (this.ViewState["CurrentPage"] == null)
                return 0;
            else
                return Convert.ToInt16(this.ViewState["CurrentPage"].ToString());
        }
        set
        {
            this.ViewState["CurrentPage"] = value;
        }
    }

    /// <summary>
    /// Function to go prevoius page
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lnkbtnPrevious_Click1(object sender, EventArgs e)
    {
        CurrentPage -= 1;
        ItemsGet();
        GetPostData();
    }
    /// <summary>
    /// Function to go next page
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lnkbtnNext_Click1(object sender, EventArgs e)
    {
        CurrentPage += 1;
        ItemsGet();
        GetPostData();
    }
    protected void lnkBack_Click(object sender, EventArgs e)
    {
        int dId = Convert.ToInt32(Request.QueryString["id"]);
        Response.Redirect("Admin_Data_Details.aspx?did=" + dId);
    }
    protected void dlStatusDetails_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                Label lblDte = (Label)e.Item.FindControl("lblDte");
                if (lblDte != null)
                {
                    if (lblDte.Text != "")
                    {
                        lblDte.Text = DateTime.Parse(lblDte.Text).ToString("MMM dd yyyy");
                    }
                }
            
        }
    }
    protected void dlPostDetails_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
        {
            Label lblDte = (Label)e.Item.FindControl("lblDte1");
            if (lblDte != null)
            {
                if (lblDte.Text != "")
                {
                    lblDte.Text = DateTime.Parse(lblDte.Text).ToString("MMM dd yyyy");
                }
            }

        }
    }
}
