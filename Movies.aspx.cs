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
using System.IO;
using System.Net;
using System.Web.Routing;

public partial class Movies : System.Web.UI.Page
{
    string qry;
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    DataSet ds = new DataSet();
    static string mov_name, mov_lang;
    InsertData obj = new InsertData();
    static string excep_page = "Movies.aspx";
    protected void Page_Load(object sender, EventArgs e)
    {
        dlsearchmovies.Visible=false;
        lblmsg.Visible = false;
        try
        {
            if (Convert.ToString(Session["searchmovies"]) == "")
            {
                movies();

            }
            else if (Convert.ToString(Page.RouteData.Values["movid"]) != "")
            {
                movies();
                //string mname = Request.QueryString["mname"].ToString();
                //string mlang = Request.QueryString["mlang"].ToString();
                //DataSet dsright = new DataSet();
                //string mov_name = Convert.ToString(Request.QueryString["mname"]);
                //string mov_lang = Convert.ToString(Request.QueryString["mlang"]);
                //string right_qry = "select m.*, count(dataid)as record_count from PostReview as p " +
                //    "right outer join Movies as m on m.HallId=p.dataid where m.Movie_Name='" + mov_name + "'and m.Movie_Language='" + mov_lang + "'" +
                //    "group by m.mid,m.Movie_Name,m.Movie_Language,m.Movie_Type," +
                //    "m.CinemaHall_Name,m.Timings,m.City,m.State,m.HallId,m.URL,m.PostDate,m.Area,m.Certify,m.Movie_Desc,m.PostedBy " +
                //     "order by mid desc";
                //SqlDataAdapter adaright = new SqlDataAdapter(right_qry, con);
                ////DataTable dtright = new DataTable();
                //adaright.Fill(dsright, "Records1");
                //if (!dsright.Tables[0].Rows.Count.Equals(0))
                //{
                //    DataTable dtright = dsright.Tables["Records1"];
                //    String[] keycolumns = new String[] { "Movie_Name", "Movie_Language" };

                //    RemoveDuplicates(dtright, keycolumns); // Here UserName is Column name of table
                //    //RemoveDuplicateRows(dt, "Movie_Name", "Movie_Language");
                //    dlMovies.DataSource = dsright;
                //    dlMovies.DataBind();
                //}
            }
            else
            {
                dlMovies.Visible = false;
                dlsearchmovies.Visible = true;
                DataSet dsmovie = new DataSet();
                dsmovie = (DataSet)Session["searchmovies"];
                if (!dsmovie.Tables[0].Rows.Count.Equals(0))
                {
                    DataTable dt1 = dsmovie.Tables[0];
                    String[] keycolumns = new String[] { "Movie_Name", "Movie_Language" };

                    RemoveDuplicates(dt1, keycolumns); // Here UserName is Column name of table
                    dlsearchmovies.DataSource = dsmovie;
                    dlsearchmovies.DataBind();
                }
                else
                {
                    lblmsg.Visible = true;
                }
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
  
    }
    public void GetMovies()
    {
        try
        {
            qry = "select m.*, count(dataid)as record_count from PostReview as p " +
                    "right outer join Movies as m on m.HallId=p.dataid " +
                    "group by m.mid,m.Movie_Name,m.Movie_Language,m.Movie_Type," +
                    "m.CinemaHall_Name,m.Timings,m.City,m.State,m.HallId,m.URL,m.PostDate,m.Area,m.Certify,m.Movie_Desc,m.PostedBy " +
                     "order by mid desc";
            SqlDataAdapter ada = new SqlDataAdapter(qry, con);
            DataTable dt1 = new DataTable();
            ada.Fill(ds, "Records1");
            if (!ds.Tables[0].Rows.Count.Equals(0))
            {
                DataTable dt = ds.Tables["Records1"];
                String[] keycolumns = new String[] { "Movie_Name", "Movie_Language" };

                RemoveDuplicates(dt, keycolumns); // Here UserName is Column name of table
                //RemoveDuplicateRows(dt, "Movie_Name", "Movie_Language");
                dlMovies.DataSource = ds;
                dlMovies.DataBind();

            }
            else
            {
                lblmsg.Visible = true;
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }

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
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
        return tbl;
    }

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
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
        return (DataRow[])retVal.ToArray(typeof(DataRow));
    }

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
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
        return retVal;
    }
    protected DataSet getHalls(string moviename, string movieLang)
    {
        DataSet ds1 = new DataSet();
        try
        {
            //DataTable dt = new DataTable();
            string qry11 = "select m.*, count(dataid)as record_count from PostReview as p " +
                    "right outer join Movies as m on m.HallId=p.dataid " +
                    "where m.Movie_Name='" + moviename + "' and m.Movie_Language='" + movieLang + "' " +
                    "group by m.mid,m.Movie_Name,m.Movie_Language,m.Movie_Type," +
                    "m.CinemaHall_Name,m.Timings,m.City,m.State,m.HallId,m.URL,m.PostDate,m.Area,m.Certify,m.Movie_Desc,m.PostedBy " +
                    "order by mid desc";
            //string qry1 = "select S* from Movies where Movie_Name='" + moviename + "' and Movie_Language='" + movieLang + "' order by mid";
            
            SqlDataAdapter ada1 = new SqlDataAdapter(qry11, con);
            ada1.Fill(ds1);
            if (ds1.Tables[0].Rows.Count.Equals(0))
            {
                lblmsg.Visible = false;
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
        return ds1;
    }
    protected void lnkGoHallInfo(object sender, CommandEventArgs e)
    {
        try
        {
            //string tname = Convert.ToString(Session["Hallname"]);
            string[] args = new string[2];
            args = e.CommandArgument.ToString().Split(',');
            Int32 Id = Convert.ToInt32(args[1]);
           // redirect("sessionstore.aspx?id=" + Id + "&tname=" + args[0],false);
            Response.RedirectToRoute("sessionstore_movies", new { id = Id, tname = args[0] });
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
        
    }
    protected void dlMovieInfo_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        Label lblURL = (Label)e.Item.FindControl("lblURL");
        ImageButton lnkURL = (ImageButton)e.Item.FindControl("lnkBtnURL");
        if (lblURL != null)
        {
            try
            {
                if (lblURL.Text != "")
                {
                    lnkURL.Visible = true;
                }
                else
                {
                    lnkURL.Visible = false;
                }
            }
            catch (Exception ex)
            {
                obj.insert_exception(ex, excep_page);
                Response.Redirect("HttpErrorPage.aspx");
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
        try
        {
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
            Label testSpan1 = (Label)e.Item.FindControl("testSpan1");
            if (testSpan1 != null)
            {
                testSpan1.Style.Add("width", result + "px");
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
        //testSpan0.Style.Add("width", result + "px");
        con.Close();
    }

    protected void dlmovies_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        try
        {
            //con.Open();
            Label Movname = (Label)e.Item.FindControl("Movie_name");
            Label movlang = (Label)e.Item.FindControl("Movie_Language");
            Label mcity = (Label)e.Item.FindControl("mcity");
            if (Movname != null && movlang != null && mcity != null)
            {
                string mname = Movname.Text;
                string mlang = movlang.Text;
                string city = mcity.Text;
                SqlCommand cmd1 = new SqlCommand("Select count(rid) as NumberOfUsers,sum(Stars_Rating) as Total from Movie_Reviews where Movie_Name='" + mname + "'and Movie_Language='" + mlang + "'", con);
                SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                float count = 0, rating = 0, result = 0;
                if (Convert.ToInt32(dt1.Rows[0]["NumberOfUsers"].ToString()) != 0)
                {
                    count = float.Parse(dt1.Rows[0]["NumberOfUsers"].ToString());
                    rating = float.Parse(dt1.Rows[0]["Total"].ToString());
                    result = Convert.ToInt32(Math.Ceiling((rating / count) * 18));
                    //avgrating.InnerText = Math.Round((rating / count), 1).ToString();

                }
                else
                {
                    //avgrating.InnerText = "0";
                }
                Label testSpan0 = (Label)e.Item.FindControl("testSpan0");
                if (testSpan0 != null)
                {
                    testSpan0.Style.Add("width", result + "px");
                }
            }

            //con.Close();
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void imgsendmail(object sender, CommandEventArgs e)
    {
        try
        {
            string[] movie = e.CommandArgument.ToString().Split(',');
            mov_name = movie[0];
            mov_lang = movie[1];
            dlMovies.Visible = true;
            dlsearchmovies.Visible = false;
            modpopupmail.Show();
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    //protected void imgsend_Click(object sender, ImageClickEventArgs e)
    //{
    //    dlMovies.Visible = false;
    //    dlsearchmovies.Visible = true;
    //    modpopupmail.Show();
    //}
    protected void imggo_Click(object sender, ImageClickEventArgs e)
    {
        string name = txtname.Text;
        string mob = txtmob.Text;
        string mail = txtmail.Text;
        string strScript = "";
        try
        {
            if (mob != "" || mail != "")
            {
                if (mail != "")
                {
                    StringWriter sw = new StringWriter();
                    HtmlTextWriter htw = new HtmlTextWriter(sw);
                    Server.Execute("Movie_mails.aspx?moviename=" + mov_name + "&movielanguage=" + mov_lang + "&name=" + name, htw);
                    //Server.Execute("MovieMail-" + mov_name + "-" + mov_lang + "-" + name, htw);
                    Mail.sendmail("info@aceindus.in", mail, "Movie_mails.aspx", sw.ToString());
                    strScript = "alert('Your Mail is Sent Successfully.');";
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                    txtmail.Text = "";
                    txtmob.Text = "";
                    txtname.Text = "";
                }
                else if (mob != "")
                {

                }
            }
            else
            {
                strScript = "alert('Please Enter either mobile number or email id .');";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);

            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }

    }
    public void movies()
    {
        //string mname = Request.QueryString["mname"].ToString();
        //string mlang = Request.QueryString["mlang"].ToString();
        string mname = Convert.ToString(Page.RouteData.Values["mname"]);
        string mlang = Convert.ToString(Page.RouteData.Values["mlang"]);
        try
        {
            if (mname != "null" && mlang != "null")
            {
                DataSet dsright = new DataSet();
                string mov_name = Convert.ToString(Page.RouteData.Values["mname"]);
                string mov_lang = Convert.ToString(Page.RouteData.Values["mlang"]);
                string right_qry = "select m.*, count(dataid)as record_count from PostReview as p " +
                    "right outer join Movies as m on m.HallId=p.dataid where m.Movie_Name='" + mov_name + "'and m.Movie_Language='" + mov_lang + "'" +
                    "group by m.mid,m.Movie_Name,m.Movie_Language,m.Movie_Type," +
                    "m.CinemaHall_Name,m.Timings,m.City,m.State,m.HallId,m.URL,m.PostDate,m.Area,m.Certify,m.Movie_Desc,m.PostedBy " +
                     "order by mid desc";
                SqlDataAdapter adaright = new SqlDataAdapter(right_qry, con);
                //DataTable dtright = new DataTable();
                adaright.Fill(dsright, "Records1");
                if (!dsright.Tables[0].Rows.Count.Equals(0))
                {
                    DataTable dtright = dsright.Tables["Records1"];
                    String[] keycolumns = new String[] { "Movie_Name", "Movie_Language" };

                    RemoveDuplicates(dtright, keycolumns); // Here UserName is Column name of table
                    //RemoveDuplicateRows(dt, "Movie_Name", "Movie_Language");
                    dlMovies.DataSource = dsright;
                    dlMovies.DataBind();
                }
                else
                {
                    lblmsg.Visible = false;
                }
            }

            else
            {
                GetMovies();
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    public void redirect(string url, bool val)
    {
        if (!val)
        {
            HttpContext.Current.Response.Redirect(url, false);
            HttpContext.Current.ApplicationInstance.CompleteRequest();
        }
        else
        {
            HttpContext.Current.Server.ClearError();
            HttpContext.Current.Response.Redirect(url, false);
            HttpContext.Current.Server.ClearError();
        }

    }
    protected string GetRatingUrl(object name, object lang)
    {
        string movlang = lang.ToString();
        string movname = name.ToString();
        return Page.GetRouteUrl("PostReview", new { mname = movname, mlang = movlang });
    }
    protected string GetMReviewUrl(object name, object lang, object city)
    {
        string movlang = lang.ToString();
        string movname = name.ToString();
        string movCity = city.ToString();
        return Page.GetRouteUrl("MovieReview", new { mname = movname, mlang = movlang, mcity = movCity });
    }

   
}
