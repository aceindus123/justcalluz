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
using System.Web.Routing;

public partial class usercontrols_moviesearch : System.Web.UI.UserControl
{
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["connectionstring"]);
    string strScript = string.Empty;
    static string excep_page = "moviesearch.ascx";
    InsertData obj = new InsertData();
    protected void Page_Load(object sender, EventArgs e)
    {
        
        if (!IsPostBack)
        {
            try
            {
                ddlmovies.Enabled = false;
                ddllanguages.Enabled = false;
                ddlarea.Enabled = false;
                ddlcinemahalls.Enabled = false;
                bindcities();
            }
            catch (Exception ex)
            {
                obj.insert_exception(ex, excep_page);
                Response.Redirect("HttpErrorPage.aspx");
            }
            
        }
    }
    protected void bindcities()
    {
        try
        {
            DataSet dscity = new DataSet();
            con.Open();
            SqlDataAdapter dacities = new SqlDataAdapter("select distinct city from Movie_Areas", con);
            dacities.Fill(dscity);
            ddlcities.DataSource = dscity;
            ddlcities.DataTextField = "city";
            ddlcities.DataValueField = "city";
            ddlcities.DataBind();
            con.Close();

            ddlcities.Items.Insert(0, "select city");
            ddlcinemahalls.Items.Insert(0, "select Theatre");
            ddlarea.Items.Insert(0, "Select Area");
            ddllanguages.Items.Insert(0, "Select Language");
            ddlmovies.Items.Insert(0, "Select Movie");
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
        
    }
    protected void bindlanguages()
    {

        try
        {
            DataSet dslang = new DataSet();
            string city = ddlcities.SelectedItem.Text;
            SqlDataAdapter dalang = new SqlDataAdapter("select Movie_Language from Movies where city='" + city + "'", con);
            dalang.Fill(dslang);
            ddllanguages.DataSource = dslang;
            ddllanguages.DataTextField = "Movie_Language";
            ddllanguages.DataValueField = "Movie_Language";
            DataTable dt = dslang.Tables[0];
            String[] keycolumns = new String[] { "Movie_Language" };

            RemoveDuplicates(dt, keycolumns); // Here UserName is Column name of table

            ddllanguages.DataBind();
            ddllanguages.Items.Insert(0, "Select Language");
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
       
    }
    protected void bindmovies()
    {
        try
        {
            DataSet dsmovie = new DataSet();
            string city = ddlcities.SelectedItem.Text;
            SqlDataAdapter damovies = new SqlDataAdapter("select distinct Movie_Name from movies where city='" + city + "'", con);
            damovies.Fill(dsmovie);
            ddlmovies.DataSource = dsmovie;
            ddlmovies.DataTextField = "Movie_Name";
            ddlmovies.DataValueField = "Movie_Name";
            DataTable dt = dsmovie.Tables[0];
            String[] keycolumns = new String[] { "Movie_Name" };

            RemoveDuplicates(dt, keycolumns); // Here UserName is Column name of table
            ddlmovies.DataBind();
            ddlmovies.Items.Insert(0, "Select Movie");
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
        
    }
    protected void ddlcities_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            con.Open();
            string city = ddlcities.SelectedItem.Text;
            DataSet ds = new DataSet();
            DataSet dshall = new DataSet();
            SqlDataAdapter daarea = new SqlDataAdapter("select area from Movie_Areas where city='" + city + "'", con);
            SqlDataAdapter dacinemahall = new SqlDataAdapter("select city,company_name from modulesdata where city='" + city + "'and module='" + "movies" + "'", con);
            daarea.Fill(ds);
            dacinemahall.Fill(dshall);
            ddlcinemahalls.DataSource = dshall;
            ddlcinemahalls.DataTextField = "company_name";
            ddlcinemahalls.DataValueField = "company_name";
            ddlcinemahalls.DataBind();
            ddlcinemahalls.Items.Insert(0, "select Theatre");
            ddlarea.DataSource = ds;
            ddlarea.DataTextField = "area";
            ddlarea.DataValueField = "area";
            ddlarea.DataBind();
            ddlarea.Items.Insert(0, "Select Area");
            ddlmovies.Enabled = true;
            ddllanguages.Enabled = true;
            ddlarea.Enabled = true;
            ddlcinemahalls.Enabled = true;
            bindlanguages();
            bindmovies();
            con.Close();
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }

    }
    protected void btngo_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            string city = Convert.ToString(ddlcities.SelectedItem);
            string lang = Convert.ToString(ddllanguages.SelectedItem);
            string moviename = Convert.ToString(ddlmovies.SelectedItem);
            string area = Convert.ToString(ddlarea.SelectedItem);
            string theatre = Convert.ToString(ddlcinemahalls.SelectedItem);
            string qry = string.Empty;
            con.Open();
            if (city != "select city" && lang != "Select Language" && moviename != "Select Movie" && area != "Select Area")
            {
                try
                {
                    qry = "select m.*, count(dataid)as record_count from PostReview as p " +
                        "right outer join Movies as m on m.HallId=p.dataid where m.movie_Name='" + moviename + "'and m.Movie_Language='" + lang + "'and m.city='" + city + "'and m.area='" + area + "'" +
                        "group by m.mid,m.Movie_Name,m.Movie_Language,m.Movie_Type," +
                        "m.CinemaHall_Name,m.Timings,m.City,m.State,m.HallId,m.URL,m.PostDate,m.Area,m.Certify,m.Movie_Desc,m.PostedBy " +
                         "order by mid desc";
                    SqlDataAdapter damovies = new SqlDataAdapter(qry, con);
                    DataSet ds = new DataSet();
                    damovies.Fill(ds);
                    Session["searchmovies"] = ds;
                }
                catch (Exception ex)
                {
                    obj.insert_exception(ex, excep_page);
                    Response.Redirect("HttpErrorPage.aspx");
                }
            }
            else if (city != "select city" && lang != "Select Language" && area != "Select Area")
            {
                try
                {
                    qry = "select m.*, count(dataid)as record_count from PostReview as p " +
                        "right outer join Movies as m on m.HallId=p.dataid where m.Movie_Language='" + lang + "'and m.city='" + city + "'and m.area='" + area + "'" +
                        "group by m.mid,m.Movie_Name,m.Movie_Language,m.Movie_Type," +
                        "m.CinemaHall_Name,m.Timings,m.City,m.State,m.HallId,m.URL,m.PostDate,m.Area,m.Certify,m.Movie_Desc,m.PostedBy " +
                         "order by mid desc";
                    SqlDataAdapter damovies = new SqlDataAdapter(qry, con);
                    DataSet ds = new DataSet();
                    damovies.Fill(ds);
                    Session["searchmovies"] = ds;
                }
                catch (Exception ex)
                {
                    obj.insert_exception(ex, excep_page);
                    Response.Redirect("HttpErrorPage.aspx");
                }
            }
            else if (city != "select city" && lang != "Select Language" && moviename != "Select Movie")
            {
                try
                {
                    qry = "select m.*, count(dataid)as record_count from PostReview as p " +
                        "right outer join Movies as m on m.HallId=p.dataid where m.movie_Name='" + moviename + "'and m.Movie_Language='" + lang + "'and m.city='" + city + "'" +
                        "group by m.mid,m.Movie_Name,m.Movie_Language,m.Movie_Type," +
                        "m.CinemaHall_Name,m.Timings,m.City,m.State,m.HallId,m.URL,m.PostDate,m.Area,m.Certify,m.Movie_Desc,m.PostedBy " +
                         "order by mid desc";
                    SqlDataAdapter damovies = new SqlDataAdapter(qry, con);
                    DataSet ds = new DataSet();
                    damovies.Fill(ds);
                    Session["searchmovies"] = ds;
                }
                catch (Exception ex)
                {
                    obj.insert_exception(ex, excep_page);
                    Response.Redirect("HttpErrorPage.aspx");
                }
            }
            else if (city != "select city" && moviename != "Select Movie" && area != "Select Area")
            {
                try
                {
                    qry = "select m.*, count(dataid)as record_count from PostReview as p " +
                        "right outer join Movies as m on m.HallId=p.dataid where m.movie_Name='" + moviename + "'and m.city='" + city + "'and m.area='" + area + "'" +
                        "group by m.mid,m.Movie_Name,m.Movie_Language,m.Movie_Type," +
                        "m.CinemaHall_Name,m.Timings,m.City,m.State,m.HallId,m.URL,m.PostDate,m.Area,m.Certify,m.Movie_Desc,m.PostedBy " +
                         "order by mid desc";
                    SqlDataAdapter damovies = new SqlDataAdapter(qry, con);
                    DataSet ds = new DataSet();
                    damovies.Fill(ds);
                    Session["searchmovies"] = ds;
                }
                catch (Exception ex)
                {
                    obj.insert_exception(ex, excep_page);
                    Response.Redirect("HttpErrorPage.aspx");
                }
            }
            else if (lang != "Select Language" && moviename != "Select Movie")
            {
                try
                {
                    qry = "select m.*, count(dataid)as record_count from PostReview as p " +
                        "right outer join Movies as m on m.HallId=p.dataid where m.movie_Name='" + moviename + "'and m.Movie_Language='" + lang + "'" +
                        "group by m.mid,m.Movie_Name,m.Movie_Language,m.Movie_Type," +
                        "m.CinemaHall_Name,m.Timings,m.City,m.State,m.HallId,m.URL,m.PostDate,m.Area,m.Certify,m.Movie_Desc,m.PostedBy " +
                         "order by mid desc";
                    SqlDataAdapter damovies = new SqlDataAdapter(qry, con);
                    DataSet ds = new DataSet();
                    damovies.Fill(ds);
                    Session["searchmovies"] = ds;
                }
                catch (Exception ex)
                {
                    obj.insert_exception(ex, excep_page);
                    Response.Redirect("HttpErrorPage.aspx");
                }

            }
            else if (city != "select city" && area != "Select Area")
            {
                try
                {
                    qry = "select m.*, count(dataid)as record_count from PostReview as p " +
                        "right outer join Movies as m on m.HallId=p.dataid where m.city='" + city + "'and m.area='" + area + "'" +
                        "group by m.mid,m.Movie_Name,m.Movie_Language,m.Movie_Type," +
                        "m.CinemaHall_Name,m.Timings,m.City,m.State,m.HallId,m.URL,m.PostDate,m.Area,m.Certify,m.Movie_Desc,m.PostedBy " +
                         "order by mid desc";
                    SqlDataAdapter damovies = new SqlDataAdapter(qry, con);
                    DataSet ds = new DataSet();
                    damovies.Fill(ds);
                    Session["searchmovies"] = ds;
                }
                catch (Exception ex)
                {
                    obj.insert_exception(ex, excep_page);
                    Response.Redirect("HttpErrorPage.aspx");
                }
            }
            else if (city != "select city" && lang != "Select Language")
            {
                try
                {
                    qry = "select m.*, count(dataid)as record_count from PostReview as p " +
                        "right outer join Movies as m on m.HallId=p.dataid where m.Movie_Language='" + lang + "'and m.city='" + city + "'" +
                        "group by m.mid,m.Movie_Name,m.Movie_Language,m.Movie_Type," +
                        "m.CinemaHall_Name,m.Timings,m.City,m.State,m.HallId,m.URL,m.PostDate,m.Area,m.Certify,m.Movie_Desc,m.PostedBy " +
                         "order by mid desc";
                    SqlDataAdapter damovies = new SqlDataAdapter(qry, con);
                    DataSet ds = new DataSet();
                    damovies.Fill(ds);
                    Session["searchmovies"] = ds;
                }
                catch (Exception ex)
                {
                    obj.insert_exception(ex, excep_page);
                    Response.Redirect("HttpErrorPage.aspx");
                }
            }
            else if (city != "select city")
            {
                try
                {
                    qry = "select m.*, count(dataid)as record_count from PostReview as p " +
                        "right outer join Movies as m on m.HallId=p.dataid where m.city='" + city + "'" +
                        "group by m.mid,m.Movie_Name,m.Movie_Language,m.Movie_Type," +
                        "m.CinemaHall_Name,m.Timings,m.City,m.State,m.HallId,m.URL,m.PostDate,m.Area,m.Certify,m.Movie_Desc,m.PostedBy " +
                         "order by mid desc";
                    SqlDataAdapter damovies = new SqlDataAdapter(qry, con);
                    DataSet ds = new DataSet();
                    damovies.Fill(ds);
                    Session["searchmovies"] = ds;
                }
                catch (Exception ex)
                {
                    obj.insert_exception(ex, excep_page);
                    Response.Redirect("HttpErrorPage.aspx");
                }
            }
            else if (lang != "Select Language")
            {
                try
                {
                    qry = "select m.*, count(dataid)as record_count from PostReview as p " +
                        "right outer join Movies as m on m.HallId=p.dataid where m.Movie_Language='" + lang + "'" +
                        "group by m.mid,m.Movie_Name,m.Movie_Language,m.Movie_Type," +
                        "m.CinemaHall_Name,m.Timings,m.City,m.State,m.HallId,m.URL,m.PostDate,m.Area,m.Certify,m.Movie_Desc,m.PostedBy " +
                         "order by mid desc";
                    SqlDataAdapter damovies = new SqlDataAdapter(qry, con);
                    DataSet ds = new DataSet();
                    damovies.Fill(ds);
                    Session["searchmovies"] = ds;
                }
                catch (Exception ex)
                {
                    obj.insert_exception(ex, excep_page);
                    Response.Redirect("HttpErrorPage.aspx");
                }
            }
            else if (moviename != "Select Movie")
            {
                try
                {
                    qry = "select m.*, count(dataid)as record_count from PostReview as p " +
                        "right outer join Movies as m on m.HallId=p.dataid where m.movie_Name='" + moviename + "'" +
                        "group by m.mid,m.Movie_Name,m.Movie_Language,m.Movie_Type," +
                        "m.CinemaHall_Name,m.Timings,m.City,m.State,m.HallId,m.URL,m.PostDate,m.Area,m.Certify,m.Movie_Desc,m.PostedBy " +
                         "order by mid desc";
                    SqlDataAdapter damovies = new SqlDataAdapter(qry, con);
                    DataSet ds = new DataSet();
                    damovies.Fill(ds);
                    Session["searchmovies"] = ds;
                }
                catch (Exception ex)
                {
                    obj.insert_exception(ex, excep_page);
                    Response.Redirect("HttpErrorPage.aspx");
                }
            }
            else if (city == "select city" && lang == "Select Language" && moviename == "Select Movie" && area == "Select Area" && theatre == "select Theatre")
            {
                strScript = "alert('Kindly , select any of the provided field to search');";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
            }
            string mname = Convert.ToString(Session["searchmovies"]);
            Response.RedirectToRoute("Movies", new { mname ="null", mlang = "null" });
            //redirect("Movies.aspx",false);
            con.Close();
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }

    }
    protected void hallgo_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            if (ddlcities.SelectedItem.Text != "select city")
            {
                string sname = Convert.ToString(ddlcinemahalls.SelectedItem);
                string qry = string.Empty;
                Int32 sid;
                qry = "select p.id,p.Company_Name,r.CinemaHall_Name from modulesdata p inner join Movies r on p.company_name=r.CinemaHall_Name and p.company_name='" + sname + "'";//tname
                SqlDataAdapter damovies = new SqlDataAdapter(qry, con);
                DataSet ds = new DataSet();
                damovies.Fill(ds);
                sid = Convert.ToInt32(ds.Tables[0].Rows[0]["id"].ToString());
                Response.RedirectToRoute("sessionstore_movies", new { id = sid, tname = sname });
                //redirect("sessionstore.aspx?tname=" + tname + "&id=" + id,false);

            }
            else
            {
                strScript = "alert('Kindly , select any city and corresponding theatre');";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
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
}
