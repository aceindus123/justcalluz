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
using System.Collections.Specialized;
using System.Reflection;
using System.Collections.Generic;
using System.Web.Routing;
using System.Web.Script.Services;
using System.Web.Services;


public partial class Hotels : System.Web.UI.Page
{
    DataSet ds = new DataSet();
    DataSet dscities = new DataSet();
    DataSet pophotels = new DataSet();
    InsertData obj = new InsertData();
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    SqlDataAdapter da;
    string pageid = "Hotels";
    static string excep_page = "Hotels.aspx";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            try
            {
                ds = obj.bindPopotherCities();
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    dlpopcities.DataSource = ds;
                    dlpopcities.DataBind();
                }
                if (!IsPostBack)
                {
                    txtSelectCity.Text = "Hyderabad";
                    Label10.Text = txtSelectCity.Text;
                    lblpcity.Text = txtSelectCity.Text;
                    Session["city"] = txtSelectCity.Text;
                    dscities = obj.search_bindcities("A");
                    dl_bindcities.DataSource = dscities;
                    dl_bindcities.DataBind();
                    pophotels = obj.gethotels(txtSelectCity.Text);
                    if (pophotels.Tables[0].Rows.Count > 0)
                    {
                        DataTable dtpophotels = pophotels.Tables[0];
                        String[] keycolumns = new String[] { "company_name", "address" };
                        RemoveDuplicates(dtpophotels, keycolumns);
                        dlpophotels.DataSource = pophotels;
                        dlpophotels.DataBind();
                    }
                }
            }
            catch (Exception ex)
            {
                obj.insert_exception(ex, excep_page);
                Response.Redirect("HttpErrorPage.aspx");
            }
        }


    }
    protected void lnktocompany(object sender, CommandEventArgs e)
    {
        try
        {
            string[] cmds = e.CommandArgument.ToString().Split(',');
            string area = "null";
            string compname = cmds[0].Trim();
            //compname = compname.Replace(" ", "-");
            //compname = compname.Replace(".", "Dot");
            //compname = compname.Replace("/", "-");
            //compname = compname.Replace("_", "-");
            //compname = compname.Replace("%20", "-");
            if (compname.Contains("&"))
            {
                compname = compname.Replace("&", "amprcent");
            }
            if (compname.Contains(" "))
            {
                compname = compname.Replace(" ", "space");
            }
            if (compname.Contains("."))
            {
                compname = compname.Replace(".", "Dot");
            }
            if (compname.Contains("/"))
            {
                compname = compname.Replace("/", "slash");
            }
            if (compname.Contains("_"))
            {
                compname = compname.Replace("_", "undrscore");
            }
            if (compname.Contains("-"))
            {
                compname = compname.Replace("-", "hypen");
            }
           // redirect("linkresults.aspx?pageid=" + pageid + "&city=" + cmds[1] + "&compname=" + Server.UrlEncode(cmds[0]) + "&area=" + area, false);
            Response.RedirectToRoute("H_linkresults", new { pageid = pageid, city = cmds[1], compname = compname, area = area });

        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }

    }
    protected void get_city(object sender, CommandEventArgs e)
    {
        try
        {
            string pre = e.CommandArgument.ToString();
            dscities = obj.search_bindcities(pre);
            dl_bindcities.DataSource = dscities;
            dl_bindcities.DataBind();
            pop_search.Show();
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void selectcity(object sender, CommandEventArgs e)
    {
        try
        {
            txtSelectCity.Text = e.CommandArgument.ToString();
            Session["city"] = txtSelectCity.Text;
            Label10.Text = txtSelectCity.Text;
            pophotels = obj.gethotels(txtSelectCity.Text);
            dlpophotels.DataSource = pophotels;
            dlpophotels.DataBind();
            lblpcity.Text = txtSelectCity.Text;
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }

    }
    protected void hdnValue_ValueChanged(object sender, EventArgs e)
    {
        try
        {
            string[] cmpname = txtSearchFor.Text.Split('(', ')');
            txtSearchFor.Text = cmpname[0];
            if (cmpname[1] == "+")
            {
                txtWhereIn.Text = "";
            }
            else
                txtWhereIn.Text = cmpname[1];
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
   
    [System.Web.Script.Services.ScriptMethod()]
    [System.Web.Services.WebMethod(EnableSession = true)]
    public static List<string> GetAreas(string prefixText)
     {
        try
        {
            string city = HttpContext.Current.Session["city"].ToString();
            List<string> cmpnames = new List<string>();
            SqlConnection con1 = new SqlConnection(ConfigurationManager.AppSettings["connectionstring"]);
            con1.Open();
            SqlCommand cmpcmd = new SqlCommand("select distinct area,City from modulesdata where City='" + city + "'and Area like @name+'%' and ApprovedStatus=1", con1);
            cmpcmd.Parameters.AddWithValue("@name", prefixText);
            SqlDataAdapter da = new SqlDataAdapter(cmpcmd);
            DataTable dtcmp = new DataTable();
            da.Fill(dtcmp);
            for (int i = 0; i < dtcmp.Rows.Count; i++)
            {
                cmpnames.Add(dtcmp.Rows[i]["Area"].ToString());

            }
            return cmpnames;
        }
        catch (Exception e)
        {
            Label lblexception = new Label();
            lblexception.Text = e.Message;
            return null;
        }

    }
    static private DataTable RemoveDuplicates(DataTable tbl, String[] keyColumns)
    {
        InsertData obj = new InsertData();
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
            Hotels hobj = new Hotels();
            obj.insert_exception(ex, excep_page);
            hobj.redirect("HttpErrorPage.aspx",false);
        }
        return tbl;
    }

    static private DataRow[] FindDups(DataTable tbl, int sourceNdx, String[] keyColumns)
    {
        InsertData obj = new InsertData();
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
            Hotels hobj = new Hotels();
            obj.insert_exception(ex, excep_page);
            hobj.redirect("HttpErrorPage.aspx", false);
        }
        return (DataRow[])retVal.ToArray(typeof(DataRow));
    }

    static private bool IsDup(DataRow sourceRow, DataRow targetRow, String[] keyColumns)
    {
        InsertData obj = new InsertData();
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
            Hotels hobj = new Hotels();
            obj.insert_exception(ex, excep_page);
            hobj.redirect("HttpErrorPage.aspx", false);
        }
        return retVal;
    }
    protected void BtnSearch_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            string compname, city, area;
            compname = txtSearchFor.Text;
            if (compname.Contains("&"))
            {
                compname = compname.Replace("&", "amprcent");
            }
            if (compname.Contains(" "))
            {
                compname = compname.Replace(" ", "space");
            }
            if (compname.Contains("."))
            {
                compname = compname.Replace(".", "Dot");
            }
            if (compname.Contains("/"))
            {
                compname = compname.Replace("/", "slash");
            }
            if (compname.Contains("_"))
            {
                compname = compname.Replace("_", "undrscore");
            }
            if (compname.Contains("-"))
            {
                compname = compname.Replace("-", "hypen");
            }
            city = txtSelectCity.Text;
            if (txtWhereIn.Text == "")
            {
                txtWhereIn.Text = "null";
            }
            area = txtWhereIn.Text;
            if (area != "null")
            {
                // redirect("linkresults.aspx?pageid=" + pageid + "&city=" + city + "&compname=" + Server.UrlEncode(compname) + "&area=" + area,false);
                Response.RedirectToRoute("H_linkresults", new { pageid = pageid, city = city, compname = compname, area = area });
            }
            else
            {
                // redirect("linkresults.aspx?pageid=" + pageid + "&city=" + city + "&compname=" + Server.UrlEncode(compname) + "&area=" + area,false);
                Response.RedirectToRoute("H_linkresults", new { pageid = pageid, city = city, compname = compname, area = area });

            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    [System.Web.Script.Services.ScriptMethod()]
    [System.Web.Services.WebMethod(EnableSession = true)]
    public static List<string> GetHotels(string prefixText)
    {
        try
        {
            string city = HttpContext.Current.Session["city"].ToString();

            List<string> cmpnames = new List<string>();
            SqlConnection con1 = new SqlConnection(ConfigurationManager.AppSettings["connectionstring"]);
            con1.Open();
            SqlCommand cmpcmd = new SqlCommand("select distinct Category,company_name,area,City from modulesdata where (Category='5 Star Hotels' or Category='Luxury Restaurants' or Category='Hotels & Resorts' or Category='Restaurant & Pubs' or Category='Resorts') and (City='" + city + "') and (company_name like @name+'%' or Category like @name+'%') and ApprovedStatus=1", con1);
            cmpcmd.Parameters.AddWithValue("@name", prefixText);
            SqlDataAdapter da = new SqlDataAdapter(cmpcmd);
            DataTable dtcmp = new DataTable();
            da.Fill(dtcmp);

            String[] keycolumns = new String[] { "Category" };

            RemoveDuplicates(dtcmp, keycolumns); // Here UserName is Column name of table
            //RemoveDuplicateRows(dt, "Movie_Name", "Movie_Language");
            for (int i = 0; i < dtcmp.Rows.Count; i++)
            {
                cmpnames.Add(dtcmp.Rows[i]["company_name"].ToString() + "(" + dtcmp.Rows[i]["area"].ToString() + ")");
                cmpnames.Add(dtcmp.Rows[i]["Category"].ToString() + "(+)");

            }
            return cmpnames;
        }
        catch (Exception e)
        {
            Label lblexception = new Label();
            lblexception.Text = e.Message;
            return null;
        }

    }
    //[WebMethod]
    //[ScriptMethod(ResponseFormat = ResponseFormat.Json)]
    //public static List<string> GetCompanyName(string pre)
    //{
    //    string city = HttpContext.Current.Session["city"].ToString();
    //    List<string> allCompanyName1 = new List<string>();
    //    var allCompanyName;
    //    using (jcalluzEntities dc = new jcalluzEntities())
    //    {
    //        // select distinct Category,company_name,area,City from modulesdata where (Category='5 Star Hotels' or Category='Luxury Restaurants' or Category='Hotels & Resorts' or Category='Restaurant & Pubs' or Category='Resorts') and (City='" + city + "') and (company_name like @name+'%' or Category like @name+'%') and ApprovedStatus=1"
    //        allCompanyName = (from a in dc.ModulesDatas
    //                          where a.company_name.StartsWith(pre) && a.City == city && a.ApprovedStatus == 1
    //                          select new { a.company_name, a.Category }).ToList();
    //    }
    //    return allCompanyName;
    //}
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

