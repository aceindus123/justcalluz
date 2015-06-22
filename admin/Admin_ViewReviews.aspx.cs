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
/// Class to view reviews
/// </summary>
public partial class admin_Admin_ViewReviews : System.Web.UI.Page
{    
    SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    string UserId;
    /// <summary>
    /// Executes whenever page load occurs.
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
        //Page loads without postbacking form values
        if (!Page.IsPostBack)
        {
            BindReview();
        }
        Int32 Id = Convert.ToInt32(Request.QueryString["id"]);
        SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
        con.Open();
        SqlCommand cmd = new SqlCommand("Select count(rid) as NumberOfUsers,sum(Stars_Rating) as Total from PostReview where dataid='" + Id + "'", con);       
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        da.Fill(dt);
        con.Close();
        float count = 0, rating = 0, result = 0;

        if (Convert.ToInt32(dt.Rows[0]["NumberOfUsers"].ToString()) != 0)
        {
            count = float.Parse(dt.Rows[0]["NumberOfUsers"].ToString());
            rating = float.Parse(dt.Rows[0]["Total"].ToString());
            result = Convert.ToInt32(Math.Ceiling((rating / count) * 18));
            //avgrating.InnerText = Math.Round((rating / count), 1).ToString();

        }
        else
        {
            //avgrating.InnerText = "0";
        }

        testSpan0.Style.Add("width", result + "px");
        con.Close();
    }
    /// <summary>
    /// To bind Reviews
    /// </summary>
    public void BindReview()
    {
        
        Int32 Id = Convert.ToInt32(Request.QueryString["id"]);
        sqlConnection.Open();
        string s = "select * from ModulesData where id =" + Id;
        SqlCommand cmd0 = new SqlCommand(s, sqlConnection);
        //To execute the command and kept in sql data reader
        SqlDataReader dr0;
        dr0 = cmd0.ExecuteReader();
        string CompName = string.Empty;
        string EveName = string.Empty;
        while (dr0.Read())
        {
            CompName = Convert.ToString(dr0["company_name"]);
            EveName = Convert.ToString(dr0["event_name"]);
        }
        dr0.Close();
        //string CompName = Convert.ToString(Session["CompanyName"]);
        //string EveName = Convert.ToString(Session["EveName"]);
        if (CompName != "")
        {
            lblHeading.Text = CompName;
        }
        else if (EveName != "")
        {
            lblHeading.Text = EveName;
        }
        string sid = Convert.ToString(Request.QueryString["id"]);
        Session["DataId"] = sid;        
        string Record_Count = string.Empty;
        string str = "Select rid,rmob,rname,remail,rating,review,ImageName,ImageContentType from PostReview where dataid='" + sid + "'";
        SqlCommand cmd = new SqlCommand(str, sqlConnection);
        DataSet dsreview = new DataSet();
        SqlDataAdapter ada = new SqlDataAdapter(str, sqlConnection);
        ada.Fill(dsreview);
        if (!dsreview.Tables[0].Rows.Count.Equals(0))
        {
            PagedDataSource objPds = new PagedDataSource();
            objPds.DataSource = dsreview.Tables[0].DefaultView;
            objPds.AllowPaging = true;
            objPds.PageSize = 7;
            objPds.CurrentPageIndex = CurrentPage;
            lblCurrentPage.Text = "Page: " + (CurrentPage + 1).ToString() + " of " + objPds.PageCount.ToString();
            // Disable Prev or Next buttons if necessary
            cmdPrev.Enabled = !objPds.IsFirstPage;
            cmdNext.Enabled = !objPds.IsLastPage;
            dlReview.DataKeyField = "rid";
            dlReview.DataSource = objPds;
            dlReview.DataBind();
        }
        else
        {
            lblNotfound.Text = "Are Not Found.";
            lblCurrentPage.Visible = false;
            cmdNext.Visible = false;
            cmdPrev.Visible = false;
        }

        DataSet dsCount = new DataSet();
        string str1 = "select count(*) as record_count from PostReview where dataid='" + sid + "'";
        SqlCommand cmd1 = new SqlCommand(str1, sqlConnection);
        SqlDataReader dr;

        dr = cmd1.ExecuteReader();
        while (dr.Read())
        {
            Record_Count = Convert.ToString(dr["Record_Count"].ToString());

        }
        lblrating.Text = Record_Count;
        sqlConnection.Close();
    }
    /// <summary>
    /// To go previous page
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void cmdPrev_Click(object sender, EventArgs e)
    {
        CurrentPage -= 1;
        BindReview();
    }
    /// <summary>
    /// To go next page
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void cmdNext_Click(object sender, EventArgs e)
    {
        CurrentPage += 1;
        BindReview();
    }
    /// <summary>
    /// To get current page status
    /// </summary>
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
    /// <summary>
    /// To go pevious page
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void imgBtnBack_Click(object sender, ImageClickEventArgs e)
    {
        string sid = Convert.ToString(Request.QueryString["id"]);
        Response.Redirect("Admin_Data_Details.aspx?did=" + sid);
    }
}
