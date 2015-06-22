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
using JustCallUsData.Data;

/// <summary>
/// class to display Movies
/// </summary>
public partial class admin_Admin_Movies : System.Web.UI.Page
{
    //declaration of variables
    string qry;
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    DataSet ds = new DataSet();
    DataCS data = new DataCS();
    string UserId;
    string MoviesEdit;
    string MoviesDel;
    static string City;
    static string State;
    string strScript;
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
        //Get web admin permissions for movies
        MoviesEdit = Convert.ToString(Session["MoviesEdit"]);
        MoviesDel = Convert.ToString(Session["MoviesDel"]);
        // loads the page without postbacking the values
        if (!IsPostBack)
        {
            data.FillStates(ddlState);
            
            GetCinemaHalls();
            GetMovies();
        }
     }
    
    PagedDataSource objPds = new PagedDataSource();
    /// <summary>
    /// Get Movies
    /// </summary>
    public void GetMovies()
    {
        if (Convert.ToString(Request.QueryString["city"]) != null)
        {
            City = Convert.ToString(Request.QueryString["city"]);
            ddlCity.Text = City;
        }
        else
        {
            City = Convert.ToString(ddlCity.SelectedValue);
        }
        if (Convert.ToString(Request.QueryString["state"]) != null)
        {
            State = Convert.ToString(Request.QueryString["state"]);
            ddlState.Text = State;
        }
        else
        {
            State = Convert.ToString(ddlState.SelectedValue);
        }
        if (State != "Select State" && City != "Select City")
        {
            qry = "select m.*, count(dataid)as record_count from PostReview as p " +
                    "right outer join Movies as m on m.HallId=p.dataid " +
                    "where m.City='" + City + "' and m.State='" + State + "' " +
                    "group by m.mid,m.Movie_Name,m.Movie_Language,m.Movie_Type," +
                    "m.CinemaHall_Name,m.Timings,m.City,m.State,m.HallId,m.URL,m.PostDate,m.Area,m.Certify,m.Movie_Desc,m.PostedBy " +
                     "order by mid desc";
            SqlDataAdapter ada = new SqlDataAdapter(qry, con);
            con.Open();
            DataTable dt1 = new DataTable();
            ada.Fill(ds, "Records1");
            con.Close();
            if (!ds.Tables[0].Rows.Count.Equals(0))
            {
                DataTable dt = ds.Tables["Records1"];
                String[] keycolumns = new String[] { "Movie_Name", "Movie_Language" };

                RemoveDuplicates(dt, keycolumns); // Here UserName is Column name of table
                //RemoveDuplicateRows(dt, "Movie_Name", "Movie_Language");
                if (!ds.Tables[0].Rows.Count.Equals(0))
                {
                    objPds.DataSource = ds.Tables[0].DefaultView;
                    objPds.AllowPaging = true;
                    objPds.PageSize = 4;
                    objPds.CurrentPageIndex = CurrentPage1;
                    lblCurrentPage1.Text = "Page: " + (CurrentPage1 + 1).ToString() + " of " + objPds.PageCount.ToString();
                    // Disable Prev or Next buttons if necessary
                    cmdPrev1.Enabled = !objPds.IsFirstPage;
                    cmdNext1.Enabled = !objPds.IsLastPage;
                    dlMovies.DataSource = objPds;
                    dlMovies.DataBind();
                    cmdNext1.Visible = true;
                    cmdPrev1.Visible = true;
                    cmdNext.Visible = false;
                    cmdPrev.Visible = false;
                    dlHalls.Visible = false;
                    dlMovies.Visible = true;
                    lblCurrentPage1.Visible = true;
                    lblCurrentPage.Visible = false;
                }
            }
        }
        else
        {
            if (IsPostBack)
            {
                strScript = "alert('Please select State and City');";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
            }
        }
    }    
    /// <summary>
    /// To remove duplicate values from data table
    /// </summary>
    /// <param name="tbl"></param>
    /// <param name="keyColumns"></param>
    /// <returns></returns>
    private DataTable RemoveDuplicates(DataTable tbl, String[] keyColumns)
    {
        int rowNdx = 0;
        try
        {
            while (rowNdx < tbl.Rows.Count - 1)
            {
                DataRow[] dups = FindDups(tbl, rowNdx, keyColumns);
                if (dups.Length > 0)
                {
                    foreach (DataRow dup in dups)
                    {
                        tbl.Rows.Remove(dup);
                    }
                }
                else
                {
                    rowNdx++;

                }
            }
        }
        catch (Exception ex)
        {

        }
        return tbl;
    }
    /// <summary>
    /// To find duplicate values
    /// </summary>
    /// <param name="tbl"></param>
    /// <param name="sourceNdx"></param>
    /// <param name="keyColumns"></param>
    /// <returns></returns>
    private DataRow[] FindDups(DataTable tbl, int sourceNdx, String[] keyColumns)
    {
        ArrayList retVal = new ArrayList();
        try
        {
            DataRow sourceRow = tbl.Rows[sourceNdx];
            for (int i = sourceNdx + 1; i < tbl.Rows.Count; i++)
            {
                DataRow targetRow = tbl.Rows[i];
                if (IsDup(sourceRow, targetRow, keyColumns))
                {
                    if (retVal.Count.Equals(0))
                        retVal.Add(sourceRow);
                        //retVal.Add(targetRow);
                }
            }
        }
        catch (Exception ex)
        {

        }
        return (DataRow[])retVal.ToArray(typeof(DataRow));
    }
    /// <summary>
    /// Executes when the data row has duplicate
    /// </summary>
    /// <param name="sourceRow"></param>
    /// <param name="targetRow"></param>
    /// <param name="keyColumns"></param>
    /// <returns></returns>
    private bool IsDup(DataRow sourceRow, DataRow targetRow, String[] keyColumns)
    {
        bool retVal = true;
        try
        {
            foreach (String column in keyColumns)
            {
                if (sourceRow.Table.Columns.Contains(column))
                {
                    retVal = retVal && sourceRow[column].Equals(targetRow[column]);
                    if (!retVal) break;
                }
            }
        }
        catch (Exception ex)
        {

        }
        return retVal;
    }
    /// <summary>
    /// Get halls data
    /// </summary>
    /// <param name="moviename"></param>
    /// <param name="movieLang"></param>
    /// <param name="city"></param>
    /// <returns></returns>
    protected DataTable getHalls(string moviename,string movieLang,string city)
    {
        DataTable dt = new DataTable();
        string qry11 = "select m.*, count(dataid)as record_count from PostReview as p " +
                "right outer join Movies as m on m.HallId=p.dataid " +
                "where m.Movie_Name='" + moviename + "' and m.Movie_Language='" + movieLang + "' and City='"+city+"'" +
                "group by m.mid,m.Movie_Name,m.Movie_Language,m.Movie_Type," +
                "m.CinemaHall_Name,m.Timings,m.City,m.State,m.HallId,m.URL,m.PostDate,m.Area,m.Certify,m.Movie_Desc,m.PostedBy " +                
                "order by mid desc";
        string qry1 = "select S* from Movies where Movie_Name='" + moviename + "' and Movie_Language='"+movieLang+"' order by mid";
        DataSet ds1 = new DataSet();
        con.Open();
        SqlDataAdapter ada1 = new SqlDataAdapter(qry11, con);
        ada1.Fill(dt);
        con.Close();
        return dt;
    }
    /// <summary>
    /// click event to go halls information page
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lnkGoHallInfo(object sender, CommandEventArgs e)
    {       
        Int32 Id = Convert.ToInt32(e.CommandArgument.ToString());        
        Response.Redirect("Admin_Data_Details.aspx?did=" + Id);
    }
    /// <summary>
    /// Binding data dynamically
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void dlMovieInfo_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        Label lblURL = (Label)e.Item.FindControl("lblURL");       
        HyperLink hlURL = (HyperLink)e.Item.FindControl("hlURL");
        if (lblURL != null)
        {
            if (lblURL.Text != "")
            {                
                hlURL.Visible = true;               
            }
            else
            {                
                hlURL.Visible = false; 
            }
        }
        Label lblHallId = (Label)e.Item.FindControl("lblHallId");
        string hallid = Convert.ToString(lblHallId.Text);        
        SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
        con.Open();
        SqlCommand cmd = new SqlCommand("Select count(rid) as NumberOfUsers,sum(Stars_Rating) as Total from PostReview where dataid='" + hallid + "'", con);        
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        da.Fill(dt);
        
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
        Label testSpan0 = (Label)e.Item.FindControl("testSpan0");
        testSpan0.Style.Add("width", result + "px");
        //testSpan0.Style.Add("width", result + "px");
        con.Close();
    }
    /// <summary>
    /// To get cinema halls data
    /// </summary>
    public void GetCinemaHalls()
    {
        City = Convert.ToString(ddlCity.SelectedValue);
        State = Convert.ToString(ddlState.SelectedValue);
        if (State != "Select State" && City != "Select City")
        {
            qry = "select m.*, count(dataid)as record_count from PostReview as p " +
                    "right outer join Movies as m on m.HallId=p.dataid " +
                    "where m.City='" + City + "' and m.State='" + State + "' " +
                    "group by m.mid,m.Movie_Name,m.Movie_Language,m.Movie_Type," +
                    "m.CinemaHall_Name,m.Timings,m.City,m.State,m.HallId,m.URL,m.PostDate,m.Area,m.Certify,m.Movie_Desc,m.PostedBy " +
                     "order by mid desc";

        con.Open();
        SqlDataAdapter ada = new SqlDataAdapter(qry, con);
        DataTable dt1 = new DataTable();
        ada.Fill(ds, "Records1");
        con.Close();
        if (!ds.Tables[0].Rows.Count.Equals(0))
        {
            DataTable dt = ds.Tables["Records1"];
            //String[] keycolumns = new String[] { "CinemaHall_Name" };

            String[] keycolumns = new String[] { "CinemaHall_Name", "HallId" };

            RemoveDuplicates(dt, keycolumns);  // Here UserName is Column name of table
            //RemoveDuplicateRows(dt, "Movie_Name", "Movie_Language");
            if (!ds.Tables[0].Rows.Count.Equals(0))
            {
                objPds.DataSource = ds.Tables[0].DefaultView;
                objPds.AllowPaging = true;
                objPds.PageSize =4;
                objPds.CurrentPageIndex = CurrentPage;
                lblCurrentPage.Text = "Page: " + (CurrentPage + 1).ToString() + " of " + objPds.PageCount.ToString();
                // Disable Prev or Next buttons if necessary
                cmdPrev.Enabled = !objPds.IsFirstPage;
                cmdNext.Enabled = !objPds.IsLastPage;
                //dlReport.DataKeyField = "id";
                dlHalls.DataSource = objPds;
                dlHalls.DataBind();
                cmdNext1.Visible = false;
                cmdPrev1.Visible = false;
                cmdNext.Visible = true;
                cmdPrev.Visible = true;
                dlHalls.Visible = true;
                dlMovies.Visible = false;
                lblCurrentPage1.Visible = false;
                lblCurrentPage.Visible = true;
            }
        }
        }
        else
        {
            strScript = "alert('Please select State and City');";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
        }

    }
    /// <summary>
    /// Binding movies dynamically with in the datalist
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void dlMoviesinside_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        Label lblURL = (Label)e.Item.FindControl("lblURL");
        HyperLink hlURL = (HyperLink)e.Item.FindControl("hlURL");
        HtmlTableCell tdEdit = (HtmlTableCell)e.Item.FindControl("tdEdit");
        HtmlTableCell tdDelete = (HtmlTableCell)e.Item.FindControl("tdDelete");
        if (lblURL != null)
        {
            if (lblURL.Text != "")
            {
                hlURL.Visible = true;
            }
            else
            {
                hlURL.Visible = false;
            }
        }
        if (MoviesEdit == "1")
        {
            tdEdit.Visible = true;
        }
        else
        {
            tdEdit.Visible = false;
        }
        if (MoviesDel == "1")
        {
            tdDelete.Visible = true;
        }
        else
        {
            tdDelete.Visible = false;
        }
    }
    protected void dlMovies_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        
        HtmlTableCell tdEd = (HtmlTableCell)e.Item.FindControl("tdEd");
        HtmlTableCell tdDel = (HtmlTableCell)e.Item.FindControl("tdDel");


        if (tdEd != null)
        {
            if (MoviesEdit == "1")
            {
                tdEd.Visible = true;
            }
            else
            {
                tdEd.Visible = false;
            }
        }
        if (tdEd != null)
        {
            if (MoviesDel == "1")
            {
                tdDel.Visible = true;
            }
            else
            {
                tdDel.Visible = false;
            }
        }
    }
    /// <summary>
    /// Get movies
    /// </summary>
    /// <param name="hallname"></param>
    /// <param name="hallid"></param>
    /// <returns></returns>
    protected DataTable getMoviesinside(string hallname,string hallid)
    {
        DataTable dt1 = new DataTable();
        string qry12 = "select m.*, count(dataid)as record_count from PostReview as p " +
                "right outer join Movies as m on m.HallId=p.dataid " +
                "where m.CinemaHall_Name='" + hallname + "' and m.HallId='"+hallid+"'" +
                "group by m.mid,m.Movie_Name,m.Movie_Language,m.Movie_Type," +
                "m.CinemaHall_Name,m.Timings,m.City,m.State,m.HallId,m.URL,m.PostDate,m.Area,m.Certify,m.Movie_Desc,m.PostedBy " +
                "order by mid desc";
        string qry2 = "select * from Movies where CinemaHall_Name='" + hallname + "' order by mid";
        con.Open();
        DataSet ds2 = new DataSet();
        SqlDataAdapter ada2 = new SqlDataAdapter(qry12, con);
        ada2.Fill(dt1);
        con.Close();
        return dt1;
    }
    /// <summary>
    /// To view records based on movies
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lnkViewByMovie_Click(object sender, EventArgs e)
    {        
        GetMovies();        
    }
    /// <summary>
    /// To view records based on cinema halls
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lnkViewByHall_Click(object sender, EventArgs e)
    {
        GetCinemaHalls();       
    }
    /// <summary>
    /// To go previous page
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void cmdPrev_Click(object sender, EventArgs e)
    {
        CurrentPage -= 1;
        GetCinemaHalls();
    }
    /// <summary>
    /// To go next page
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void cmdNext_Click(object sender, EventArgs e)
    {
        CurrentPage += 1;
        GetCinemaHalls();
    }
    /// <summary>
    /// To get the current page status
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
    public int CurrentPage1
    {
        get
        {
            object o = this.ViewState["_CurrentPage1"];
            if (o == null)
                return 0;
            else
                return (int)o;
        }
        set
        {
            this.ViewState["_CurrentPage1"] = value;
        }
    }
    /// <summary>
    /// To go previous page
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void cmdPrev1_Click(object sender, EventArgs e)
    {
        CurrentPage1 -= 1;
        GetMovies();
    }
    /// <summary>
    /// To go next page
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void cmdNext1_Click(object sender, EventArgs e)
    {
        CurrentPage1 += 1;
        GetMovies();
    }
    protected void ddlState_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlState.SelectedIndex != 0)
        {
            string State_Name = Convert.ToString(ddlState.SelectedValue);
            fillCities(State_Name);
        }
        else
        {
            ddlCity.Items.Clear();
            ddlCity.Items.Insert(0, "Select City");
        }
    }
    public void fillCities(string StateName)
    {
        try
        {
            string Connection = ConfigurationManager.AppSettings["ConnectionString"];
            SqlConnection oCon = new SqlConnection(Connection);
            string s = "select city_Id,city_name from Cities where state_name= '" + StateName + "' order by city_name";
            SqlCommand cmd = new SqlCommand(s, oCon);
            oCon.Open();
            SqlDataAdapter da = new SqlDataAdapter(s, oCon);
            DataSet ds = new DataSet();
            da.Fill(ds, "Cities");
            //DlCities.SelectedIndex = 0;

            ddlCity.DataSource = ds.Tables["Cities"];
            ddlCity.DataValueField = "city_name";
            ddlCity.DataTextField = "city_name";
            ddlCity.DataBind();
            ddlCity.Items.Insert(0, "Select City");
            oCon.Close();
        }
        catch (Exception ex)
        {
            lblMessage.Text = ex.Message.ToString();
        }
    }
    protected void lnkBack_Click(object sender, EventArgs e)
    {
        string designation;
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
