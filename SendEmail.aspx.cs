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
using JustCallUsData.Data;
using System.Data;
using System.Data.SqlClient;
using System.Web.Routing;

public partial class SendEmail : System.Web.UI.Page
{
    string cat;
    string name;
    string city;
    DataCS obj1 = new DataCS();
    DataSet ds = new DataSet();
    InsertData obj = new InsertData();
    static string excep_page = "SendEmail.aspx";
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {

            //cat = Convert.ToString(Page.RouteData.Values["cat"]);
            //name = Convert.ToString(Page.RouteData.Values["name"]);
            //city = Convert.ToString(Page.RouteData.Values["city"]);

            cat = Convert.ToString(Request.QueryString["cat"]);
            name = Convert.ToString(Request.QueryString["name"]);
            city = Convert.ToString(Request.QueryString["city"]);
            lblCat.Text = cat;
            lblName.Text = name;
            GetData();
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void GetData()
    {
        try
        {
            ds = obj1.GetRequiredData(cat, city);
            DLBindCatData.DataSource = ds;
            DLBindCatData.DataBind();
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void DLBindCatData_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        Label lblDataId = (Label)e.Item.FindControl("lblDataId");
        Label lblnoofratings = (Label)e.Item.FindControl("lblnoofratings");
        Label lblImgName = (Label)e.Item.FindControl("lblImgName");
        Image img = (Image)e.Item.FindControl("imgReviewer");
        if (lblImgName != null)
        {
            try
            {
                if (lblImgName.Text != "")
                {
                    img.Visible = true;
                }
                else
                {
                    img.Visible = false;
                }
            }
            catch (Exception ex)
            {
                obj.insert_exception(ex, excep_page);
                Response.Redirect("HttpErrorPage.aspx");
            }
        }

        if (lblDataId != null)
        {
            try
            {
                string dataId = Convert.ToString(lblDataId.Text);
                SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
                //con.Open();
                SqlCommand cmd = new SqlCommand("Select count(rid) as NumberOfUsers,sum(Stars_Rating) as Total from PostReview where dataid='" + dataId + "'", con);
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
                //Label testSpan0 = (Label)e.Item.FindControl("testSpan0");
                //testSpan0.Style.Add("width", result + "px");
                //testSpan0.Style.Add("width", result + "px");
                //con.Close();
                lblnoofratings.Text = Convert.ToString(count);
            }
            catch (Exception ex)
            {
                obj.insert_exception(ex, excep_page);
                Response.Redirect("HttpErrorPage.aspx");
            }
        }
    }
    //protected string GetCompanyUrl(object id, object cname)
    //{
    //    string compId = id.ToString();
    //    string compName = cname.ToString();
    //    return Page.GetRouteUrl("mailsessionstore", new { id = compId, cname = compName });

    //}
    //protected string GetRatingUrl(object id)
    //{
    //    string Rid = id.ToString();
    //    return Page.GetRouteUrl("mailRating", new { DataId = Rid });
    //}
}
