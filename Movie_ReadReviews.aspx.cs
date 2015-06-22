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

public partial class Movie_ReadReviews : System.Web.UI.Page
{
    SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    InsertData obj = new InsertData();
    string sid = string.Empty;
    string mname, mlang;
    //int id;
    Binddata obj1 = new Binddata();
    static string excep_page = "Movie_ReadReviews.aspx";
    protected void Page_Load(object sender, EventArgs e)
    {
        lblmsg.Visible = false;
        //Label11.Text = Convert.ToString(Request.QueryString["Movie_Name"]);
        if (!IsPostBack)
        {
            try
            {
                ViewState["PreviousPage"] = Request.UrlReferrer;
                DataSet ds8 = new DataSet();
                sid = Convert.ToString(Page.RouteData.Values["mcity"]);
                mname = Convert.ToString(Page.RouteData.Values["mname"]);
                mlang = Convert.ToString(Page.RouteData.Values["mlang"]);
                Session["Movie_Name"] = mname;
                Session["Movie_Language"] = mlang;
                ds8 = obj1.moviereviews(mname, mlang, sid);
                try
                {
                    if (!ds8.Tables[0].Rows.Count.Equals(0))
                    {
                        reviewdl.DataSource = ds8;
                        reviewdl.DataBind();
                    }
                    else
                    {
                        lblmsg.Visible = true;
                        cmdNext.Visible = false;
                        cmdPrev.Visible = false;
                    }
                }
                catch (Exception ex)
                {
                    obj.insert_exception(ex, excep_page);
                    Response.Redirect("HttpErrorPage.aspx");
                }
                SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
               // con.Open();
                SqlCommand cmd = new SqlCommand("Select count(rid) as NumberOfUsers,sum(Stars_Rating) as Total from Movie_Reviews where Movie_Name='" + mname + "'and Movie_Language='" + mlang + "'", con);
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
                testSpan0.Style.Add("width", result + "px");
            }
            catch (Exception ex)
            {
                obj.insert_exception(ex, excep_page);
                Response.Redirect("HttpErrorPage.aspx");
            }
        } 
    }
    protected void reviewdl_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        try
        {

            Label lbl = (Label)e.Item.FindControl("lblcmp");
            lbl.Text = Convert.ToString(Session["Movie_Name"]);
            lbl.Text += "(" + Convert.ToString(Session["Movie_Language"]) + ")";
            Label lblrate = (Label)e.Item.FindControl("lblrating");
            Label rate = (Label)e.Item.FindControl("rates");
            int rates = Convert.ToInt32(rate.Text);
            for (int i = 0; i < rates; i++)
            {

                lblrate.Text += "<img src=images/ratestar2.png>";
            }
            for (int j = rates; j < 5; j++)
            {
                lblrate.Text += "<img src=images/starash3.png>";
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }


    }
    protected void cmdPrev_Click(object sender, EventArgs e)
    {
        try
        {
            CurrentPage -= 1;
            BindReview();
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    /// <summary>
    /// To go next page
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void cmdNext_Click(object sender, EventArgs e)
    {
        try
        {
            CurrentPage += 1;
            BindReview();
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
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
    protected void btnBack_Click(object sender, EventArgs e)
    {
        try
        {

            if (ViewState["PreviousPage"] != null)
            {
                redirect(ViewState["PreviousPage"].ToString(),false);
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }

    }
    public void BindReview()
    {
        try
        {
            sid = Convert.ToString(Page.RouteData.Values["mcity"]);
            mname = Convert.ToString(Page.RouteData.Values["mname"]);
            mlang = Convert.ToString(Page.RouteData.Values["mlang"]);
           // sqlConnection.Open();
            string Record_Count = string.Empty;
            string str = "Select rid,mob=stuff(rmob,4,5,'*****'),rname,email=stuff(remail,4,6,'****'),rating,review,ImageName,ImageContentType,Stars_Rating from Movie_Reviews where Movie_Name='" + mname + "'and Movie_Language='" + mlang + "' order by rid desc";
            SqlCommand cmd = new SqlCommand(str, sqlConnection);
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
                objPds.PageSize = 3;
                objPds.CurrentPageIndex = CurrentPage;
                lblCurrentPage.Text = "Page: " + (CurrentPage + 1).ToString() + " of " + objPds.PageCount.ToString();
                // Disable Prev or Next buttons if necessary
                cmdPrev.Enabled = !objPds.IsFirstPage;
                cmdNext.Enabled = !objPds.IsLastPage;
                reviewdl.DataKeyField = "rid";
                reviewdl.DataSource = objPds;
                reviewdl.DataBind();
            }
            else
            {
                lblCurrentPage.Text = "No  Reviews  available. Be  the  first  one  to  post  review  for  this  customer.";
                trAllRatingHeading.Visible = false;
                cmdPrev.Visible = false;
                cmdNext.Visible = false;
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void reviewdl_SelectedIndexChanged(object sender, EventArgs e)
    {

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
