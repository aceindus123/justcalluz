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
using System.Drawing;


public partial class admin_site_exceptions : System.Web.UI.Page
{
    SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    SqlCommand cmd, cmddel;
    string strScript;
    string date = DateTime.Now.ToShortDateString();
    int testid, statusid;
    string UserId;
    string designation;
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
        if (!IsPostBack)
        {
            BindReview();
        }
    }
    public void BindReview()
    {
        sqlConnection.Open();
        string Record_Count = string.Empty;
        string str = "select * from jcalluz_exception order by Excep_id desc";
        cmd = new SqlCommand(str, sqlConnection);
        DataSet dsreview = new DataSet();
        SqlDataAdapter ada = new SqlDataAdapter(str, sqlConnection);
        ada.Fill(dsreview);
        //dlReview.DataSource = dsreview;
        //dlReview.DataBind();
        PagedDataSource objPds = new PagedDataSource();
        if (!dsreview.Tables[0].Rows.Count.Equals(0))
        {
            objPds.DataSource = dsreview.Tables[0].DefaultView;
            objPds.AllowPaging = true;
            objPds.PageSize = 6;
            objPds.CurrentPageIndex = CurrentPage;
            lblCurrentPage.Text = "Page: " + (CurrentPage + 1).ToString() + " of " + objPds.PageCount.ToString();
            // Disable Prev or Next buttons if necessary
            cmdPrev.Enabled = !objPds.IsFirstPage;
            cmdNext.Enabled = !objPds.IsLastPage;
            dlReview.DataKeyField = "Excep_id";
            dlReview.DataSource = objPds;
            dlReview.DataBind();
        }

    }

    protected void cmdPrev_Click(object sender, EventArgs e)
    {
        CurrentPage -= 1;
        BindReview();
    }
    protected void cmdNext_Click(object sender, EventArgs e)
    {
        CurrentPage += 1;
        BindReview();
    }
    public int CurrentPage
    {
        get
        {
            object o = this.ViewState["_CurrentPage"];
            if (o == null)
                return 0;
            else
                return (int)o;
        }
        set
        {
            this.ViewState["_CurrentPage"] = value;
        }
    }

    protected void dlReview_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        Label lblstat = (Label)e.Item.FindControl("lblstatus");
        Label lblrname = (Label)e.Item.FindControl("lblname");
        Label lblreview = (Label)e.Item.FindControl("lblview");
        Label postdate = (Label)e.Item.FindControl("lbldate");
        Label pg = (Label)e.Item.FindControl("lblpg");
        Label line = (Label)e.Item.FindControl("lblline");
        LinkButton lnkactivate = (LinkButton)e.Item.FindControl("lnkact");
        LinkButton lnkdeactivate = (LinkButton)e.Item.FindControl("lnkdeact");


        if (lblstat.Text != null)
        {
            if (lblstat.Text == "2")
            {
                lblreview.ForeColor = Color.Silver;
                postdate.ForeColor = Color.Silver;
                pg.ForeColor = Color.Silver;
                line.ForeColor = Color.Silver;
                lnkactivate.Visible = false;
                lnkdeactivate.Visible = true;
                lblstat.Text = "Solved";
                
            }
            else
            {
                lblreview.ForeColor = Color.Black;
                postdate.ForeColor = Color.Gray;
                pg.ForeColor = Color.Black;
                line.ForeColor = Color.Black;
                lnkactivate.Visible = true;
                lnkdeactivate.Visible = false;
                lblstat.Text = "Unsolved";
            }
        }
    }
    protected void activate_command(object sender, CommandEventArgs e)
    {
        testid = Convert.ToInt32(e.CommandArgument.ToString());
        statusid = 1;
        changestatus(statusid, testid);
        Response.Redirect("site_exceptions.aspx");
    }
    protected void deactivate_command(object sender, CommandEventArgs e)
    {
        testid = Convert.ToInt32(e.CommandArgument.ToString());
        statusid = 2;
        changestatus(statusid, testid);
        Response.Redirect("site_exceptions.aspx");
    }
    public void changestatus(int status, int id)
    {
        sqlConnection.Open();
        SqlCommand cmdstatus = new SqlCommand("exception_status", sqlConnection);
        cmdstatus.CommandType = CommandType.StoredProcedure;
        cmdstatus.Parameters.AddWithValue("@status", status);
        cmdstatus.Parameters.AddWithValue("@id", id);
        cmdstatus.ExecuteNonQuery();
        sqlConnection.Close();
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
