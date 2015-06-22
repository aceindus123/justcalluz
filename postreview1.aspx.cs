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
using System.Web.Routing;

public partial class postreview : System.Web.UI.Page
{
  
    InsertData obj = new InsertData();
    string sid = string.Empty;
    string moviename, movielanguage;
    int id;
    string rate;
    Binddata obj1 = new Binddata(); 
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    static int rated;
    static string excep_page = "postreview1.aspx";
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            moviename = Convert.ToString(Page.RouteData.Values["mname"]);
            movielanguage = Convert.ToString(Page.RouteData.Values["mlang"]);
            txtrev.Text = moviename + "(" + movielanguage + ")";

            if (!IsPostBack)
            {
                ViewState["previouspage"] = Request.UrlReferrer;
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }

    }
    protected void RatingControlChanged(object sender, AjaxControlToolkit.RatingEventArgs e)
    {
        try
        {
            //rated =e.Value. ratingcnt.CurrentRating;
            rated = Convert.ToInt32(e.Value);
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }

    protected void submit_Click(object sender, ImageClickEventArgs e)
    {
        try
        {

            //con.Open();
            moviename = Convert.ToString(Page.RouteData.Values["mname"]);
            movielanguage = Convert.ToString(Page.RouteData.Values["mlang"]);
            string pdate = DateTime.Now.ToShortDateString();
            string str = "insert into movie_reviews(rating,rname,remail,rmob,review,ImageName,ImageContentType,Img_Caption,City,Stars_Rating,Movie_name,Movie_Language,postdate) values(@rating,@rname,@remail,@rmob,@review,@ImageName,@ImageContentType,@Img_Caption,@City,@Stars_Rating,@Movie_name,@Movie_Language,@postdate)";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.Parameters.AddWithValue("@Movie_name", SqlDbType.VarChar).Value = moviename;
            cmd.Parameters.AddWithValue("Movie_Language", SqlDbType.VarChar).Value = movielanguage;
            cmd.Parameters.AddWithValue("@Stars_Rating", rated);
            cmd.Parameters.AddWithValue("@postdate", SqlDbType.DateTime).Value = pdate;
            cmd.Parameters.AddWithValue("@rname", txtname.Text);
            cmd.Parameters.AddWithValue("@remail", txtid.Text);
            cmd.Parameters.AddWithValue("@Img_Caption", txtcap.Text);
            cmd.Parameters.AddWithValue("@rmob", txtno.Text);
            cmd.Parameters.AddWithValue("@review", txtreview.Text);
            cmd.Parameters.AddWithValue("@City", txtcity.Text);
            try
            {
                if (rated == 5)
                {
                    rate = "Excellent";

                }
                else if (rated == 4)
                {
                    rate = "Very Good";

                }
                else if (rated == 3)
                {
                    rate = "Good";
                }

                else if (rated == 2)
                {
                    rate = "Average";

                }
                else if (rated == 1)
                {
                    rate = "Poor";
                }
            }
            catch (Exception ex)
            {
                obj.insert_exception(ex, excep_page);
                Response.Redirect("HttpErrorPage.aspx");
            }
            cmd.Parameters.AddWithValue("@rating", rate);

            //if (photo.PostedFile.ContentType.ToLower().StartsWith("image") && photo.HasFile)
            try
            {
                if (photo.HasFile)
                {
                    //string savelocation = Server.MapPath("Review_Images/");
                    //string fileextension = System.IO.Path.GetExtension(photo.FileName);
                    string filename = System.IO.Path.GetFileName(photo.PostedFile.FileName);
                    string contenttype = photo.PostedFile.ContentType;
                    //string savepath = savelocation + filename + fileextension;
                    photo.PostedFile.SaveAs(Server.MapPath("../Review_Images/" + filename));
                    cmd.Parameters.AddWithValue("@ImageName", filename);
                    cmd.Parameters.AddWithValue("@ImageContentType", contenttype);
                }

                else
                {
                    string filename = "he.gif";
                    string imgContentType = "image/gif";
                    cmd.Parameters.AddWithValue("@ImageName", filename);
                    cmd.Parameters.AddWithValue("@ImageContentType", imgContentType);
                }

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    obj.insert_exception(ex, excep_page);
                    Response.Redirect("HttpErrorPage.aspx");
                }
                finally
                {
                    cmd.Dispose();
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                obj.insert_exception(ex, excep_page);
                Response.Redirect("HttpErrorPage.aspx");
            }


            string strScript = string.Empty;
            strScript = "alert('Thank you! You have successfully posted the review.');location.replace('" + ViewState["previouspage"].ToString() + "');";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
            txtcap.Text = "";
            txtid.Text = "";
            txtname.Text = "";
            txtno.Text = "";
            txtrev.Text = "";
            txtreview.Text = "";
            txtcity.Text = "";
            //if (ViewState["previouspage"] != null)
            //{
            //    Response.Redirect(ViewState["previouspage"].ToString());
            //}
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
        
    }
    protected void back_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            if (ViewState["previouspage"] != null)
            {
                redirect(ViewState["previouspage"].ToString(),false);
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
}

