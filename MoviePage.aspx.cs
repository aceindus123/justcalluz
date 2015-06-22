using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using HtmlAgilityPack;
using System.Data;
using System.Data.SqlClient;
using System.Web.Routing;
public partial class MoviePage : System.Web.UI.Page
{
    public string swfFileName;
    public static string city="";
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["connectionstring"]);
    InsertData obj = new InsertData();
    static string excep_page = "MoviePage.aspx";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            bindcities();
          // ddlday.Items.Add(new ListItem("",""));
            ddlday.Items.Insert(0, "Today");
            ddlday.Items.Insert(1, "Tomorrow");
            ddlday.Items.Insert(2, DateTime.Now.AddDays(2).ToString("dddd"));
            ddlday.Items.Insert(3, DateTime.Now.AddDays(3).ToString("dddd"));

            bindmovie(ddlcities.SelectedItem.Text, ddlday.SelectedIndex, ddlmovies.SelectedValue, ddlSort.SelectedValue, ddlgen.SelectedValue);
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
            ddlcities.SelectedValue = "Hyderabad";
            ddlcities.DataBind();
            con.Close();
            ddlday.SelectedValue = "1";
            ddlcities.Items.Insert(0, "select city");
           // ddlcinemahalls.Items.Insert(0, "select Theatre");
            //ddlarea.Items.Insert(0, "Select Area");
          
           // ddlmovies.Items.Insert(0, "Select Movie");
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }

    }
    protected void ddlcities_SelectedIndexChanged(object sender, EventArgs e)
    {
        //try
        //{
        //    con.Open();
        //    string city = ddlcities.SelectedItem.Text;
        //    DataSet ds = new DataSet();
        //    DataSet dshall = new DataSet();
        //    SqlDataAdapter daarea = new SqlDataAdapter("select area from Movie_Areas where city='" + city + "'", con);
        //    SqlDataAdapter dacinemahall = new SqlDataAdapter("select city,company_name from modulesdata where city='" + city + "'and module='" + "movies" + "'", con);
        //    daarea.Fill(ds);
        //    dacinemahall.Fill(dshall);
        //    //ddlcinemahalls.DataSource = dshall;
        //    //ddlcinemahalls.DataTextField = "company_name";
        //    //ddlcinemahalls.DataValueField = "company_name";
        //    //ddlcinemahalls.DataBind();
        //    //ddlcinemahalls.Items.Insert(0, "select Theatre");
        //    //ddlarea.DataSource = ds;
        //    //ddlarea.DataTextField = "area";
        //    //ddlarea.DataValueField = "area";
        //    //ddlarea.DataBind();
        //    //ddlarea.Items.Insert(0, "Select Area");
        //    //ddlmovies.Enabled = true;
        //    ////ddllanguages.Enabled = true;
        //    //ddlarea.Enabled = true;
        //    //ddlcinemahalls.Enabled = true;
        //    //bindlanguages();
        //    //bindmovies();
        //    con.Close();
        //}
        //catch (Exception ex)
        //{
        //    obj.insert_exception(ex, excep_page);
        //    Response.Redirect("HttpErrorPage.aspx");
        //}

    }
    protected void btngo_Click(object sender, EventArgs e)
    {
        if ((txtArea.Text == "") && (ddlcities.SelectedIndex > 0))
            bindmovie(ddlcities.SelectedItem.Text, ddlday.SelectedIndex, ddlmovies.SelectedValue, ddlSort.SelectedValue, ddlgen.SelectedValue); 
        else
            bindmovie(txtArea.Text, ddlday.SelectedIndex, ddlmovies.SelectedValue, ddlSort.SelectedValue, ddlgen.SelectedValue); 
                
    }

    void bindmovie(string city, int date,string time,string sort,string gen)
    {
        try
        {
            if (ddlcities.SelectedValue != "0")
            {
               
                HtmlWeb web = new HtmlWeb();
                HtmlDocument doc;
                if (ddlSort.SelectedValue == "0")
                    doc = web.Load("http://www.google.co.in/movies?near=" + city + "&date=" + date + "&time=" + time + "&sort=" + sort);
                else
                    doc = web.Load("http://www.google.co.in/movies?near=" + city + "&date=" + date + "&time=" + time + "&sort=" + sort + "&genre=" + gen);
                HtmlNode rateNode = doc.DocumentNode.SelectSingleNode("//div[@id='movie_results']");
               
                string rate = rateNode.InnerHtml;

                HtmlAgilityPack.HtmlDocument docs = new HtmlAgilityPack.HtmlDocument();
                doc.LoadHtml(rate);
                //int i = 0;
                foreach (var a in doc.DocumentNode.Descendants("a"))
                {
                    if (a.Attributes["href"].Value.Contains("url?q="))
                    {
                        string r = a.Attributes["href"].Value.Substring(42, 50).TrimStart('/');
                        string[] rr = r.Split('&');

                        string s = "http:" + "//www.youtube.com/embed/" + rr[0];
                        a.Attributes.Remove("href");
                        a.Attributes.Add("style", "cursor:pointer; color:green;");
                        a.Attributes.Add("onclick", "aclick('" + s + "')");
                        //bd1.Attributes.Add("onload", "aclick('" + s + "')");
                    }
                    else if (a.InnerText.Contains("Show more cinemas"))
                    {
                        a.Attributes.Add("style", "display:none;");

                    }
                    else
                    {
                        //string sn = Convert.ToString(++i);
                        //a.Attributes.Add("id", sn);
                        a.Attributes.Add("runat", "server");
                        if (a.Attributes["href"].Value.Contains("tid"))
                        {
                            a.Attributes["href"].Value = "#";
                            a.Attributes.Add("style", "cursor:text;");
                        }
                        else
                        {
                            //NavigateUrl="<%$RouteUrl:RouteName=SearchMore,maincat=Medical Services,cat1=Hospitals and Healthcare,cat2=Chemists And Druggists,cat3=Diagnostics Centres%>"
                            // a.Attributes["href"].Value = "<%$RouteUrl:RouteName=NewMoviesData," + HttpUtility.UrlEncode(a.Attributes["href"].Value.Replace("movies?", "").Replace("&amp;", ",").Replace("mid=", "mid=mvs_" + a.InnerText).Replace("tid=", "mid=hall_" + a.InnerText).TrimStart('/')) + "%>";
                            a.Attributes["href"].Value = "NewMovies-" + HttpUtility.UrlEncode(a.Attributes["href"].Value.Replace("movies?", "").Replace("&amp;", "-").Replace("near=", "").Replace("date=", "").Replace("time=", "").Replace("sort=", "").Replace("genre=", "").Replace("mid=", "mvs_" + a.InnerText.Replace(" ", "abyz") + "-").Replace("tid=", "hall_" + a.InnerText.Replace(" ", "abyz") + "-").TrimStart('/'));
                            //a.Attributes["href"].Value = "NewMovies-" + HttpUtility.UrlEncode(a.Attributes["href"].Value.Replace("movies?", "").Replace("&amp;", "-").Replace("near=", "").Replace("date=", "").Replace("time=", "").Replace("sort=", "").Replace("genre=", "").Replace("mid=", a.InnerText + "-").Replace("tid=", "hall-").TrimStart('/'));
                        }
                    }
                }

                var newContent = doc.DocumentNode.OuterHtml;
                plchldrVideo.InnerHtml = newContent;
                Session["city"] = ddlcities.SelectedItem.Text;

            }
        }
        catch
        {
            if (Session["city"].ToString() != "")
                ddlcities.SelectedValue = Session["city"].ToString();
            ClientScript.RegisterStartupScript(typeof(Page), "message", "<script>alert('Sorry, Selected Location Movies Information Not Available !!!!');</script>");
        }
    }
}