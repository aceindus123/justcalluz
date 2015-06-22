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

public partial class usercontrols_discountcenter : System.Web.UI.UserControl
{
    InsertData obj = new InsertData();
    string sid = string.Empty;
    int id;
    protected void Page_Load(object sender, EventArgs e)
    {
        ddlPageSize.Visible = false;
        if (!IsPostBack)
        {
            BindGrid();
        }
    }
    PagedDataSource pds = new PagedDataSource();
    public void BindGrid()
    {
        //SqlConnection con = new SqlConnection("Password=Mnhbs@123;Persist Security Info=True;User ID=jcalluz;Initial Catalog=jcalluz;Data Source=jcalluz.db.8035572.hostedresource.com");
        SqlConnection con = new SqlConnection(@"Data Source=ACETECHG06\SQLEXPRESS;Persist Security Info=True;Initial Catalog=sidardh;Integrated security=true;");
        //SqlDataAdapter da = new SqlDataAdapter("Select * from data where cat LIKE '[Comp]uter'", con);
        SqlDataAdapter da = new SqlDataAdapter("select * from post_discount", con);
        DataTable dt = new DataTable();
        da.Fill(dt);
        Session["id"] = id;
        pds.DataSource = dt.DefaultView;
        pds.AllowPaging = true;
        pds.PageSize = Convert.ToInt16(ddlPageSize.SelectedValue);
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
}



