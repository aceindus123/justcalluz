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


public partial class tv_ads : System.Web.UI.Page
{
    public string swfFileName;
    int total, rates;
    AdsCS obj1 = new AdsCS();
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    static string pageid;
    string date, address, ad;
    DateTime post_date;
    InsertData obj = new InsertData();
    static string excep_page = "tv_ads.aspx";
    protected void Page_Load(object sender, EventArgs e)
       {
        if (!IsPostBack)
        {
            try
            {
                tblrate.Visible = true;
                string content_image = "AB Ad Films(New)";
                string lang = "Telugu";
                bindimages(content_image, lang);
                Bindata(content_image);
                rating();
                bindlang(content_image);
                if (!IsPostBack)
                {

                    if (Convert.ToString(Page.RouteData.Values["subad"]) != null)
                    {
                        try
                        {
                            string cont_image = Convert.ToString(Page.RouteData.Values["subad"]);
                            if (cont_image == "AB Ad Films(New)")
                            {
                                pageid = "AB Ad Films(New)";
                                bindimages(cont_image, lang);
                                Bindata(cont_image);
                                bindlang(cont_image);
                            }
                            else if (cont_image == "AB Ad Films")
                            {
                                pageid = "AB Ad Films";
                                bindimages(cont_image, lang);
                                Bindata(cont_image);
                                bindlang(cont_image);
                            }
                            else if (cont_image == "Others")
                            {
                                bindimages(cont_image, lang);
                                bindlang(cont_image);
                            }
                        }
                        catch (Exception ex)
                        {
                            obj.insert_exception(ex, excep_page);
                            Response.Redirect("HttpErrorPage.aspx");
                        }
                    }
                    else
                    {
                        pageid = "AB Ad Films(New)";
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
    protected void bindlang(string content_image)
    {
        try
        {
            DataSet dslang = obj1.tvad_lang(content_image);
            dllang.DataSource = dslang;
            dllang.DataBind();
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void bindimages(string content_image, string lang)
    {
        try
        {
            DataSet dsimage = new DataSet();
            dsimage = obj1.bindtvads(content_image, lang);
            dlimages.DataSource = dsimage;
            dlimages.DataBind();
            lblcat.Text = content_image;
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
             
    private void Bindata(string pageid)
    {
        try
        {
            string qry = "Select * from Adreviews where pageid='" + pageid + "' order by id desc";
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
           // con.Open();
            date = DateTime.Now.ToString();
            SqlCommand cmd = new SqlCommand("Sp_Adreviews", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Name", txtname.Text);
            cmd.Parameters.AddWithValue("@Email", txtemail.Text);
            cmd.Parameters.AddWithValue("@Comments", txtcomments.Text);
            cmd.Parameters.AddWithValue("@pageid", pageid);
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
            string strscript = "alert('Thank you ! You have successfully posted the review',true)";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strscript, true);
            Bindata(pageid);
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void imgplaybtn(object sender, CommandEventArgs e)
    {
        try
        {
            int id = Convert.ToInt32(e.CommandArgument);
            SqlDataAdapter da = new SqlDataAdapter("select * from Ads where adId=" + id, con);
            DataSet dsvideo = new DataSet();
            da.Fill(dsvideo);
            if (!dsvideo.Tables[0].Rows.Count.Equals(0))
            {
                string videoname = dsvideo.Tables[0].Rows[0]["Content_Name"].ToString();
                swfFileName = "../Ads/" + videoname;
            }

        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
        //catch (Exception ex)
        //{
        //    this.Response.Write(ex.ToString());
        //}
    }
    //public string TvAds(object lang)
    //{
    //    string url = "";
    //    try
    //    {
    //        string language = Convert.ToString(lang);
    //        if (Convert.ToString(Request.QueryString["subad"]) != null)
    //        {
    //            string contad_image = Convert.ToString(Request.QueryString["subad"]);
    //            if (contad_image == "AB Ad Films (New)")
    //            {
    //                bindimages(contad_image, language);
    //            }
    //            else if (contad_image == "AB Ad Films")
    //            {
    //                bindimages(contad_image, language);
    //            }
    //            else if (contad_image == "Others")
    //            {
    //                bindimages(contad_image, language);
    //            }
    //        }
    //        else
    //        {
    //            string contad_image = "AB Ad Films (New)";
    //            bindimages(contad_image, language);
    //        }
    //        url = "~/tv_ads.aspx";
    //    }
    //    catch (Exception ex)
    //    {
    //        obj.insert_exception(ex, excep_page);
    //        Response.Redirect("HttpErrorPage.aspx");
    //    }
    //    return url;
    //}
    protected string TvAds(object lang)
    {
        string language = Convert.ToString(lang);
        if (Convert.ToString(Page.RouteData.Values["subad"]) != null)
        {
            string contad_image = Convert.ToString(Page.RouteData.Values["subad"]);
            if (contad_image == "AB Ad Films(New)")
            {
                bindimages(contad_image, language);
            }
            else if (contad_image == "AB Ad Films")
            {
                bindimages(contad_image, language);
            }
            else if (contad_image == "Others")
            {
                bindimages(contad_image, language);
            }
        }
        else
        {
            string contad_image = "AB Ad Films(New)";
            bindimages(contad_image, language);
        }
        return Page.GetRouteUrl("Ads");
    }
    protected void rate(string subad)
    {
        try
        {

            SqlCommand cmd = new SqlCommand("select Star_Rating from Tvad_Reviews where AdsubType='" + subad + "'", con);
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
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
            
    }
    public void rating()
    {
        try
        {
            if (Convert.ToString(Page.RouteData.Values["subad"]) != null)
            {
                string subad = Convert.ToString(Page.RouteData.Values["subad"]);
                if (subad == "Others")
                {
                    tblrate.Visible = false;
                }
                else
                {
                    rate(subad);
                }
            }
            else
            {
                string subad = "AB Ad Films(New)";
                rate(subad);
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
            rates = Convert.ToInt32(e.Value);
            ad = lblcat.Text;
            address = HttpContext.Current.Request.UserHostAddress.ToString();
            post_date = DateTime.Now;
            //perdate = DateTime.Now.AddHours(24);
            DataSet dsrate = new DataSet();
            dsrate = obj1.tvad_rate(address, ad);
            if (!dsrate.Tables[0].Rows.Count.Equals(0))
            {
                lbladmsg.Text = "You have already rated for this item";
            }
            else
            {
                
                SqlCommand cmd = new SqlCommand("insert_adrate", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@AdsubType", SqlDbType.NVarChar).Value = "AB Ad Films";
                cmd.Parameters.AddWithValue("@Star_Rating", SqlDbType.Int).Value = rates;
                cmd.Parameters.AddWithValue("@Ip_address", SqlDbType.NVarChar).Value = address;
                cmd.Parameters.AddWithValue("@post_date", SqlDbType.NVarChar).Value = post_date;
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
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    //public void BindVedio()
    //{
    //    try
    //    {
    //        SqlDataAdapter da = new SqlDataAdapter("select * from Vedios where dataid='" + Did + "'", connection);
    //        da.Fill(dsvideo);
    //        if (!dsvideo.Tables[0].Rows.Count.Equals(0))
    //        {
    //            string videoname = dsvideo.Tables[0].Rows[0]["VedioName"].ToString();
    //            swfFileName = "~/Videos/" + videoname;
    //        }
    //        else
    //        {
    //            lblNoVideos.Text = "No Vedio Available to play. Please Upload";
    //        }
    //    }

    //    catch (Exception ex)
    //    {
    //        this.Response.Write(ex.ToString());
    //    }

    //}    
}
