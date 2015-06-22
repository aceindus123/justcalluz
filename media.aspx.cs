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

public partial class media : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["connectionstring"]);
    MediaCS obj1 = new MediaCS();
    InsertData obj = new InsertData();
    static string excep_page = "media.aspx";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            try
            {
                lblmsg.Visible = false;
                if (Convert.ToString(Page.RouteData.Values["lang"]) != null)
                {
                    try
                    {
                        string lang = Convert.ToString(Page.RouteData.Values["lang"]);
                        DataSet ds = new DataSet();
                        ds = obj1.GetMedia(lang);
                        if (!ds.Tables[0].Rows.Count.Equals(0))
                        {
                            mediagrid.DataSource = ds;
                            mediagrid.DataBind();
                        }
                        else
                        {
                            lblmsg.Visible = true;
                            lblmsg.Text = "Sorry ! No result found";
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
                    try
                    {
                        DataSet ds = new DataSet();
                        ds = obj1.GetMedia("English");
                        if (!ds.Tables[0].Rows.Count.Equals(0))
                        {

                            mediagrid.DataSource = ds;
                            mediagrid.DataBind();
                        }
                        else
                        {
                            lblmsg.Visible = true;
                            lblmsg.Text = "Sorry ! No result found";
                        }
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
    }
    //public string GetUrl(object id)
    //{
    //    string url = "";
    //    try
    //    {
    //        string id1 = Convert.ToString(id);
    //        int count = 0;
    //        DataSet dshit = new DataSet();
    //        dshit = obj1.GetPerticularMedia(id1);
    //        count = Convert.ToInt32(dshit.Tables[0].Rows[0]["Hits"].ToString());
    //        count++;
    //        obj1.increment_hit(count, id1);
    //        url = "../media_details.aspx?id=" + Server.UrlEncode(id1.ToString());
    //    }
    //    catch (Exception ex)
    //    {
    //        obj.insert_exception(ex, excep_page);
    //        Response.Redirect("HttpErrorPage.aspx");
    //    }
    //    return url;
    //}
    protected string GetUrl(object id)
    {
       
            string id1 = Convert.ToString(id.ToString());
            int count = 0;
            DataSet dshit = new DataSet();
            dshit = obj1.GetPerticularMedia(id1);
            count = Convert.ToInt32(dshit.Tables[0].Rows[0]["Hits"].ToString());
            count++;
             obj1.increment_hit(count, id1);
            return Page.GetRouteUrl("media_det", new { id = id1 });
    }
}

