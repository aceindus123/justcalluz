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
using System.Net;
using System.Net.NetworkInformation;
using System.Web.Routing;

public partial class jc_reverseauctionMail : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    string cate;
    string city;
    string name;
    DataSet dsRecords = new DataSet();
    InsertData obj = new InsertData();
    char[] q_separator = new char[] { ',' };
    char[] z_separator = new char[] { '0' };
    string catesplit;
    static string excep_page = "jc_reverseauctionMail.aspx";
    protected void Page_Load(object sender, EventArgs e)
    {
        //cate = Convert.ToString(Page.RouteData.Values["cate"].ToString().Trim());
        //city = Convert.ToString(Page.RouteData.Values["city"].ToString().Trim());
        //name = Convert.ToString(Page.RouteData.Values["name"].ToString().Trim());

        cate = Convert.ToString(Request.QueryString["cate"].ToString().Trim());
        city = Convert.ToString(Request.QueryString["city"].ToString().Trim());
        name = Convert.ToString(Request.QueryString["name"].ToString().Trim());
            
            dsRecords = obj.bindJC_TopCmpDetails(cate, city);
            if (dsRecords.Tables[0].Rows.Count > 0)
            {
                dvMail.Visible = true;
                pnlMail.Visible = true;
                lblname.Text = name;
                lblcateName.Text = cate;
                DlCategorymail.DataSource = dsRecords;
                DlCategorymail.DataBind();
            }
            dsRecords.Clear();
      
              
    }
    //protected string GetCompanyUrl(object id,object cname)
    //{
    //    string compId = id.ToString();
    //    string compName = cname.ToString();
    //    return Page.GetRouteUrl("mailsessionstore", new { id = compId, cname = compName });
    //   // return Page.GetRouteUrl("http://www.justcalluz.com/sessionstore", new { id = compId, cname = compName });

    //}
    //protected string GetRatingUrl(object id)
    //{
    //    string Rid = id.ToString();
    //    return Page.GetRouteUrl("mailRating", new { DataId = Rid });
    //   // return Page.GetRouteUrl("http://www.justcalluz.com/PostReviewCat", new { DataId = Rid });
    //}
    protected void DlCategorymail_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        try
        {
            Label lblDataId = (Label)e.Item.FindControl("lblDataId");
            //Label lblLandPhone = (Label)e.Item.FindControl("lblLandPhone");
            if (lblDataId != null)
            {
                string dataId = Convert.ToString(lblDataId.Text);
                SqlCommand cmd = new SqlCommand("Select count(rid) as NumberOfUsers,sum(Stars_Rating) as Total from PostReview where dataid='" + dataId + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                float count = 0, rating = 0, result = 0;
                try
                {
                    if (Convert.ToInt32(dt.Rows[0]["NumberOfUsers"].ToString()) != 0)
                    {
                        count = float.Parse(dt.Rows[0]["NumberOfUsers"].ToString());
                        rating = float.Parse(dt.Rows[0]["Total"].ToString());
                        result = Convert.ToInt32(Math.Ceiling((rating / count) * 18));
                    }
                    else
                    {

                    }
                    HtmlGenericControl span = e.Item.FindControl("testSpan0") as HtmlGenericControl;
                    if (span != null)
                        span.Style.Add("width", result + "px");
                    Label lblRating = (Label)e.Item.FindControl("lblnoofratings");
                    if (lblRating != null)
                        lblRating.Text = Convert.ToString(count);
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
        //if (lblLandPhone != null)
        //{
        //    string Lphno = Convert.ToString(lblLandPhone.Text);
        //    string[] Lphnosplitstr = Lphno.Split(z_separator);
        //    foreach (string Lphnoarry in Lphnosplitstr)
        //    {
        //        lblLandPhone.Text = Lphnoarry;
        //    }
        //}
       
    }
 }
