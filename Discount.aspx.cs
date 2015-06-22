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
/// To display the existing discounts , display of average rating , To check the authentication to display further pages.  
/// </summary>
public partial class _Default : System.Web.UI.Page
{
    InsertData obj = new InsertData();
    string sid = string.Empty;
    int id;
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["connectionstring"]);
    DateTime current = DateTime.Now.Date;
    protected void Page_Load(object sender, EventArgs e)
    {
        ddlPageSize.Visible = false;
        if (!IsPostBack)
        {
            BindGrid();
            rating();
        }

        
       

        //Binding existing discounts from the database
        SqlDataAdapter da1 = new SqlDataAdapter("select id,company_name,event_desc,Category,city,event_startdate,event_enddate from modulesdata where module='Discounts' and event_enddate>='" + current + "' and ApprovedStatus=1",con);
        DataSet ds = new DataSet();
        da1.Fill(ds, "modulesdata");
        DataList1.DataSource = ds;
        DataList1.DataBind();
    }

    /// <summary>
    /// Applying paging in the form
    /// </summary>
    PagedDataSource pds = new PagedDataSource();
    public void BindGrid()
    {

        SqlDataAdapter da = new SqlDataAdapter("select id,event_desc,company_name,Category,city,event_startdate,event_enddate from modulesdata where module='Discounts' and event_enddate>='" + current + "' and ApprovedStatus=1", con);
        DataTable dt = new DataTable();
        da.Fill(dt);
        Session["id"] = id;
        pds.DataSource = dt.DefaultView;
        pds.AllowPaging = true;
        pds.PageSize = 3;
        //pds.PageSize = Convert.ToInt16(ddlPageSize.SelectedValue);
        pds.CurrentPageIndex = CurrentPage;
        lnkbtnNext.Enabled = !pds.IsLastPage;
        lnkbtnPrevious.Enabled = !pds.IsFirstPage;
        DataList1.DataSource = pds;
        DataList1.DataBind();
        doPaging();
    }
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
    private void doPaging()
    {
        DataTable dt = new DataTable();
        dt.Columns.Add("PageIndex");
        dt.Columns.Add("PageText");
        for (int i = 0; i < pds.PageCount; i++)
        {
            DataRow dr = dt.NewRow();
            dr[0] = i;
            dr[1] = i + 1;
            dt.Rows.Add(dr);
        }
        dlPaging.DataSource = dt;
        dlPaging.DataBind();
    }

    protected void dlPaging_ItemCommand(object source, DataListCommandEventArgs e)
    {
        if (e.CommandName.Equals("lnkbtnPaging"))
        {
            CurrentPage = Convert.ToInt16(e.CommandArgument.ToString());
            BindGrid();
        }
    }
    protected void lnkbtnPrevious_Click1(object sender, EventArgs e)
    {
        CurrentPage -= 1;
        BindGrid();
    }
    protected void lnkbtnNext_Click1(object sender, EventArgs e)
    {
        CurrentPage += 1;
        BindGrid();
    }
    protected void ddlPageSize_SelectedIndexChanged(object sender, EventArgs e)
    {
        CurrentPage = 0;
        BindGrid();
    }
    protected void dlPaging_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        LinkButton lnkbtnPage = (LinkButton)e.Item.FindControl("lnkbtnPaging");
        if (lnkbtnPage.CommandArgument.ToString() == CurrentPage.ToString())
        {
            lnkbtnPage.Enabled = false;
            lnkbtnPage.Font.Bold = true;
        }
    }


    protected void DataList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    

    

    /// <summary>
    /// To calculate and display the overall rating interms of star images
    /// </summary>
    public void rating()
    {
        int total = 0;
       
        con.Open();
        SqlCommand cmd = new SqlCommand("select Stars_Rating from postreview", con);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        da.Fill(dt);
        con.Close();

        if (dt.Rows.Count > 0)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                total += Convert.ToInt32(dt.Rows[i][0].ToString());
            }
            int average = total / (dt.Rows.Count);
            avgrating.CurrentRating = average;


            lbl1rate.Text = dt.Rows.Count + " " + " user(s) rated this site ";
        }

    }

    
}





   

   
