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

public partial class media_details : System.Web.UI.Page
{
    int total = 0;
    MediaCS obj1 = new MediaCS();
    InsertData obj = new InsertData();
    static string excep_page = "media_details.aspx";
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["connectionstring"]);
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            try
            {
               // con.Open();
                string id, papname;
                DataSet ds = new DataSet();
                id = Convert.ToString(Page.RouteData.Values["id"].ToString());
                ds = obj1.GetPerticularMedia(id);
                if (!ds.Tables[0].Rows.Count.Equals(0))
                {
                    string content = ds.Tables[0].Rows[0]["Content_Image"].ToString();
                    imgmedia.ImageUrl = "~/MediaImg/" + content;
                    lbltitle.Text = ds.Tables[0].Rows[0]["Title"].ToString();
                    lbldate.Text = ds.Tables[0].Rows[0]["posted_date"].ToString();
                    lblday.Text = ds.Tables[0].Rows[0]["day"].ToString();
                    papname = ds.Tables[0].Rows[0]["Category"].ToString();
                    if (papname == "Others")
                    {
                        lblname.Text = ds.Tables[0].Rows[0]["OtherCat"].ToString();
                    }
                    else
                    {
                        lblname.Text = papname;
                    }
                }
                Bindata(id);
                rating();
               // con.Close();
            }
            catch (Exception ex)
            {
                obj.insert_exception(ex, excep_page);
                Response.Redirect("HttpErrorPage.aspx");
            }
        }
     }
    protected void rating()
    {
        try
        {
            if (Convert.ToString(Page.RouteData.Values["id"]) != null)
            {
                string subad = Convert.ToString(Page.RouteData.Values["id"]);
                SqlCommand cmd = new SqlCommand("select star_rating from mediaRating where MS_Id='" + subad + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        total += Convert.ToInt32(dt.Rows[i][0].ToString());
                    }
                    int average = total / (dt.Rows.Count);
                    avgrating.CurrentRating = average;
                    lbl1rate.Text = dt.Rows.Count + " " + " user(s) rated this item ";
                }

            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void insert_rating(object sender, AjaxControlToolkit.RatingEventArgs e)
    {
        try
        {
            string id = Convert.ToString(Page.RouteData.Values["id"].ToString());
            int rates = Convert.ToInt32(e.Value);
            //string ad = lblcat.Text;
            string address = HttpContext.Current.Request.UserHostAddress.ToString();
            DateTime post_date = DateTime.Now;
            //perdate = DateTime.Now.AddHours(24);
            DataSet dsrate = new DataSet();
            dsrate = obj1.media_rate(address, id);
            if (!dsrate.Tables[0].Rows.Count.Equals(0))
            {
                lbladmsg.Text = "You have already rated for this item";
            }
            else
            {
                try
                {
                    //con.Open();
                    DataSet dsmedia = new DataSet();
                    int count = 0;
                    int vote = 0;
                    SqlCommand cmd = new SqlCommand("insert_mediarate", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MS_Id", SqlDbType.Int).Value = id;
                    cmd.Parameters.AddWithValue("@star_rating", SqlDbType.Int).Value = rates;
                    cmd.Parameters.AddWithValue("@Ip_address", SqlDbType.NVarChar).Value = address;
                    cmd.Parameters.AddWithValue("@post_date", SqlDbType.NVarChar).Value = post_date;
                    dsmedia = obj1.GetPerticularMedia(id);
                    count = Convert.ToInt32(dsmedia.Tables[0].Rows[0]["Ratings"].ToString());
                    vote = Convert.ToInt32(dsmedia.Tables[0].Rows[0]["Votes"].ToString());
                    count = count + rates;
                    vote++;
                    obj1.increment_rate(count, id, vote);
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
                    lbladmsg.Text = "Thank You ! you have successfully rated the item";
                    rating();
                }
                catch (Exception ex)
                {
                    obj.insert_exception(ex, excep_page);
                    Response.Redirect("HttpErrorPage.aspx");
                }
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    private void Bindata(string id)
    {
        try
        {
            string qry = "Select * from Adreviews where Medid='" + id + "'";
            SqlDataAdapter da = new SqlDataAdapter(qry, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dlreviews.DataSource = ds;
            dlreviews.DataBind();
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
            string strScripts; 
            string id = Convert.ToString(Page.RouteData.Values["id"].ToString());
            DateTime date = DateTime.Now;
            //con.Open();
            SqlCommand cmd = new SqlCommand("media_review", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Name", txtname.Text);
            cmd.Parameters.AddWithValue("@Email", txtemail.Text);
            cmd.Parameters.AddWithValue("@Comments", txtcomments.Text);
            cmd.Parameters.AddWithValue("@Medid", SqlDbType.Int).Value = Convert.ToInt32(id);
            cmd.Parameters.AddWithValue("@postdate", date);
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
            txtcomments.Text = "";
            txtemail.Text = "";
            txtname.Text = "";
            //string strscript = "alert('Thank you ! You have successfully posted the review',true)";
            strScripts = "alert('Thank you ! You have successfully posted the review');location.replace('MediaDetails-" + id + "');";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScripts, true);
            Bindata(id);
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void comment_click(object sender, EventArgs e)
    {
        try
        {
            string id = Convert.ToString(Page.RouteData.Values["id"].ToString());
           // redirect("media_details.aspx?id=" + id + "#tblmediacomment", false);
            Response.RedirectToRoute("media_det", new { id = id });
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
