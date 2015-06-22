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

public partial class usercontrols_Testimonials_Left : System.Web.UI.UserControl
{
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["connectionstring"]);
    protected void Page_Load(object sender, EventArgs e)
    {
        //con.Open();
        //SqlDataAdapter dalang = new SqlDataAdapter("select distinct LanguageSpeak from media_data", con);
        //DataSet dslang = new DataSet();
        //dalang.Fill(dslang);
        //dlmedia.DataSource = dslang;
        //dlmedia.DataBind();
        //con.Close();
    }
    //protected void lnkabnew_Click(object sender, EventArgs e)
    //{
    //    //Response.Redirect("tv_ads.aspx?subad=AB Ad Films (New)");
    //    Response.RedirectToRoute("tvads", new { subad = "AB Ad Films (New)" });
    //}
    //protected void lnkabold_Click(object sender, EventArgs e)
    //{
    //    //Response.Redirect("tv_ads.aspx?subad=AB Ad Films");
    //    Response.RedirectToRoute("tvads", new { subad = "AB Ad Films" });
    //}
    //protected void lnkother_Click(object sender, EventArgs e)
    //{
    //    //Response.Redirect("tv_ads.aspx?subad=Others");
    //    Response.RedirectToRoute("tvads", new { subad = "Others" });
    //}
    //protected void lnkprint_Click(object sender, EventArgs e)
    //{
    //    //Response.Redirect("Tv_Printads.aspx");
    //    Response.RedirectToRoute("printads");
    //}
    //protected void lnkradio_Click(object sender, EventArgs e)
    //{
    //    //Response.Redirect("Radioads.aspx");
    //    Response.RedirectToRoute("Radioads");
    //}
    //protected string bindlang(object language)
    //{
    //    string mlang = language.ToString();
    //    //Response.Redirect("media.aspx?lang=" + lang);
    //    return Page.GetRouteUrl("media", new { lang = mlang });
    //}
    ////protected void title_command(object sender, CommandEventArgs e)
    //protected string title_command(object mid)
    //{
    //    string sid = mid.ToString();
    //    //Response.Redirect("media_details.aspx?id=" + id);
    //    return Page.GetRouteUrl("media_det", new { id = sid });
    //}
    //protected void media_details(object sender, DataListItemEventArgs e)
    //{
    //    DataList dldetails = (DataList)e.Item.FindControl("dltitle");
    //    HyperLink lnkmedia = (HyperLink)e.Item.FindControl("lnklang");
    //    string language = lnkmedia.Text;
    //    if (language == "English" || language == "Hindi")
    //    {
    //        SqlDataAdapter datitle = new SqlDataAdapter("select * from media_data where LanguageSpeak='" + language + "'", con);
    //        DataSet dstitle = new DataSet();
    //        datitle.Fill(dstitle);
    //        dldetails.DataSource = dstitle;
    //        dldetails.DataBind();
    //    }
    //}
}
