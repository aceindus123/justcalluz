using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using IMDb_Scraper;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Web.Routing;
using System.Configuration;
using HtmlAgilityPack;
public partial class MovieDetails : System.Web.UI.Page
{
    public string swfFileName;
    public static string city = "";
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["connectionstring"]);
    InsertData obj = new InsertData();
    static string excep_page = "MovieDetails.aspx";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Table1.Visible = false;
            bindcities();
            // ddlday.Items.Add(new ListItem("",""));
            ddlday.Items.Insert(0, "Today");
            ddlday.Items.Insert(1, "Tomorrow");
            ddlday.Items.Insert(2, DateTime.Now.AddDays(2).ToString("dddd"));
            ddlday.Items.Insert(3, DateTime.Now.AddDays(3).ToString("dddd"));

            try
            {

                //string s = "Alludu Sreenu";
                string sdata = Page.RouteData.Values["mid"].ToString();
                //if (Page.RouteData.Values["mid"].ToString() != "hall")
                if (sdata.Contains("mvs"))
                {
                    string[] sdats = sdata.Split('_');
                    sdats[1] = sdats[1].Replace("abyz", " ");
                    IMDb movie = new IMDb(sdats[1], true);

                    lbltitle.Text = movie.Title;
                    lblRDate.Text = movie.ReleaseDate;
                    if (movie.Runtime == "")
                        lblruntime.Text = "";
                    else
                        lblruntime.Text = movie.Runtime + " Mins.";
                    //lblRating.Text = movie.Rating;
                    try
                    {
                        Double du = Convert.ToDouble(movie.Rating);
                        rt.CurrentRating = Convert.ToInt32(du) / 2;
                    }
                    catch
                    {
                        rt.CurrentRating = 0;
                    } 

                    //testSpan0.Style.Add("width", movie.Rating + "px");
                    lblvotes.Text = movie.Votes;
                    lblmId.Text = movie.Id;
                    lblMOID.Text = movie.OriginalTitle;
                    loops(movie.Genres, lblMtype);
                    loops(movie.Languages, lblLang);
                    loops(movie.Directors, lblDirectors);
                    loops(movie.Producers, lblProducers);
                    loops(movie.Cast, lblCast);
                    lblSLine.Text = movie.Storyline;
                    lblPlot.Text = movie.Plot;
                    loops(movie.Writers, lblWriters);
                    loops(movie.Musicians, lblMDirec);
                    loops(movie.Editors, lblEditor);
                    loops(movie.Cinematographers, lblCAuto);
                    lblAward.Text = movie.Awards;
                    lblOscars.Text = movie.Oscars;
                    lblNominy.Text = movie.Nominations;
                    loops(movie.Countries, lblcountry);
                    loops(movie.ReleaseDates, lblReDates);
                    imageLoop(movie.MediaImages);
                    if (movie.PosterLarge != "")
                        imglarge.Src = movie.PosterLarge;
                    else if (movie.PosterFull != "")
                        imglarge.Src = movie.PosterFull;
                    else
                    {
                        imglarge.Attributes.Add("width", "250");
                        imglarge.Attributes.Add("height", "150");
                        imglarge.Src = movie.Poster;
                    }

                    // td2.Attributes.Add("style", "background-image:url(" + movie.PosterLarge + ") no-repeat");
                    //for (int i = 0; i < movie.Genres.Count; i++)
                    //{
                    //    lblMtype.Text += movie.Genres[i]+" / ";
                    //}
                    //lblMtype.Text=lblMtype.Text.TrimEnd('/');

                    //Response.Write(movie.Directors[0]);
                    //Response.Write(movie.ReleaseDate);
                    //Image img = new Image();
                    //img.Attributes.Add("src", movie.Poster);
                    //this.Controls.Add(img);


                }
                else
                {
                    string[] sdats = sdata.Split('_');
                    Response.RedirectToRoute("sessionstore_movies", new { id = 0, tname = sdats[1].Replace("abyz"," ") });
                    //Table1.Visible = true;
                    //Table2.Visible = false;
                   
                    //bindmovie(ddlcities.SelectedItem.Text, ddlday.SelectedIndex, ddlmovies.SelectedValue, ddlSort.SelectedValue, ddlgen.SelectedValue);
                }

            }
            catch { }
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

    public void loops(ArrayList cont,Label lbl)
    {
        for (int i = 0; i < cont.Count; i++)
        {
            lbl.Text += " " + cont[i] + ",";
        }
        lbl.Text = lbl.Text.TrimEnd(',');
        lbl.Text = lbl.Text.TrimStart(' ');
    }
    public void imageLoop(ArrayList cont)
    {
        for (int i = 0; i < cont.Count; i++)
        {
            Image img = new Image();
            img.Attributes.Add("src",cont[i].ToString());
            //img.Attributes.Add("src", imgs);
            img.Attributes.Add("width","150");
            img.Attributes.Add("height", "100");
            mediaImg.Controls.Add(img);

        }
       
    }
    protected void btngo_Click(object sender, EventArgs e)
    {
        Table1.Visible = true;
        Table2.Visible = false;
        if ((txtArea.Text == "") && (ddlcities.SelectedIndex > 0))
            bindmovie(ddlcities.SelectedItem.Text, ddlday.SelectedIndex, ddlmovies.SelectedValue, ddlSort.SelectedValue, ddlgen.SelectedValue);
        else
            bindmovie(txtArea.Text, ddlday.SelectedIndex, ddlmovies.SelectedValue, ddlSort.SelectedValue, ddlgen.SelectedValue);

    }

    void bindmovie(string city, int date, string time, string sort, string gen)
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
                // int i = 0;
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
                            // a.Attributes["href"].Value = "<%$RouteUrl:RouteName=NewMoviesData,"+ HttpUtility.UrlEncode(a.Attributes["href"].Value.Replace("movies?", "").Replace("&amp;", ",").Replace("mid=", "mid=mvs_" + a.InnerText).Replace("tid=", "tid=hall_" + a.InnerText).TrimStart('/'))+ "%>";
                            a.Attributes["href"].Value = "NewMovies-" + HttpUtility.UrlEncode(a.Attributes["href"].Value.Replace("movies?", "").Replace("&amp;", "-").Replace("near=", "").Replace("date=", "").Replace("time=", "").Replace("sort=", "").Replace("genre=", "").Replace("mid=", "mvs_" + a.InnerText + "-").Replace("tid=", "hall_" + a.InnerText.Replace(" ", "%20") + "-").TrimStart('/'));
                        }
                        //a.Attributes["href"].Value = "NewMovies-" + HttpUtility.UrlEncode(a.Attributes["href"].Value.Replace("movies?", "").Replace("&amp;", "-").Replace("near=", "").Replace("date=", "").Replace("time=", "").Replace("sort=", "").Replace("genre=", "").Replace("mid=", a.InnerText + "-").Replace("tid=", "hall-").TrimStart('/'));
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