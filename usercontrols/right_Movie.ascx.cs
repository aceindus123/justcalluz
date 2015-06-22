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
public partial class usercontrols_right_Movie : System.Web.UI.UserControl
{
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["connectionstring"]);
    MoviesCS obj1 = new MoviesCS();
    InsertData obj = new InsertData();
    static string excep_page = "right_Movie.ascx";
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            con.Open();
            SqlDataAdapter daright = new SqlDataAdapter("select * from Movies", con);
            DataSet dsright = new DataSet();
            daright.Fill(dsright);

            DataTable dt = dsright.Tables[0];
            String[] keycolumns = new String[] { "Movie_Language" };

            RemoveDuplicates(dt, keycolumns); // Here UserName is Column name of table
            //RemoveDuplicateRows(dt, "Movie_Name", "Movie_Language");
            dlMovieslangright.DataSource = dsright;
            dlMovieslangright.DataBind();
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
    protected DataSet getMovies(string Movielang)
    {
        DataSet dsrightmovie = new DataSet();
        try
        {
            SqlDataAdapter darightmovies = new SqlDataAdapter("select distinct(Movie_Name),Movie_Language from Movies where Movie_Language='" + Movielang + "'and Movie_Type='Currently Showing' or Movie_Type='Forth Comming'", con);
            
            darightmovies.Fill(dsrightmovie);
            
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
        return dsrightmovie;
    }

    protected void dlMovieslangright_ItemCommand(object source, DataListCommandEventArgs e)
    {
        //Response.Redirect("Movies.aspx");
    }
    protected void getfilm(object sender, CommandEventArgs e)
    {
        try
        {
            string[] arguments = new string[2];
            arguments = e.CommandArgument.ToString().Split(',');
            Response.RedirectToRoute("rgtmovies", new { mname = arguments[0], mlang = arguments[1], movid = "movid" });
           //redirect("Movies.aspx?mname=" + arguments[0] + "&mlang=" + arguments[1] + "&movid=movid",false);
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
}
