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

public partial class admin_customer : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["connectionstring"].ToString());
    DataSet dscustomer = new DataSet();
    string UserId;
    string designation;
    PagedDataSource pds = new PagedDataSource();
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
            CustomerDetails();
        }
       
    }
    protected void CustomerDetails()
    {
        con.Open();
        SqlCommand cmd = new SqlCommand("intimateadmin_ccare", con);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlDataAdapter dacustomer = new SqlDataAdapter(cmd);
        dacustomer.Fill(dscustomer);
        DataTable dtcustomers=dscustomer.Tables[0];
        if (dscustomer.Tables[0].Rows.Count > 0)
        {
            pds.DataSource = dtcustomers.DefaultView;
            pds.AllowPaging = true;
            pds.PageSize = 7;
            pds.CurrentPageIndex = CurrentPage;
            lblCurrentPage.Text = "Page: " + (CurrentPage + 1).ToString() + " of " + pds.PageCount.ToString();
            lnkbtnNext.Enabled = !pds.IsLastPage;
            lnkbtnPrevious.Enabled = !pds.IsFirstPage;
            dlcomment.DataSource = pds;
            dlcomment.DataBind();
            lnkbtnNext.Visible = true;
            lnkbtnPrevious.Visible = true;
            lblCurrentPage.Visible = true;
        }
        else
        {
            lblMessage.Text = "No records Available";
        }
        con.Close();
    }
    protected void customerdetails(object sender, CommandEventArgs e)
    {
        int id = Convert.ToInt32(e.CommandArgument.ToString());
        Response.Redirect("customerdetails.aspx?dataid=" + id);
    }
    protected void click_solved(object sender, CommandEventArgs e)
    {
        con.Open();
        int solved_id = Convert.ToInt32(e.CommandArgument.ToString());
        SqlCommand cmdsolved = new SqlCommand("update Report set solved_status=1 where dataid='" + solved_id + "'", con);
        cmdsolved.ExecuteNonQuery();
        con.Close();
        Response.Redirect("customer.aspx");
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
        CustomerDetails();
    }
    /// <summary>
    /// Function to go next page
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lnkbtnNext_Click1(object sender, EventArgs e)
    {
        CurrentPage += 1;
        CustomerDetails();
    }
}
