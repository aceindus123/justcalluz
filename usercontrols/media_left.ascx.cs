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

public partial class usercontrols_media_left : System.Web.UI.UserControl
{
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["connectionstring"]);
    InsertData obj = new InsertData();
    static string excep_page = "media_left.ascx";
    protected void Page_Load(object sender, EventArgs e)
    {
        //if (!IsPostBack)
        //{
        //    try
        //    {
        //        con.Open();
        //        SqlDataAdapter dalang = new SqlDataAdapter("select distinct LanguageSpeak from media_data", con);
        //        DataSet dslang = new DataSet();
        //        dalang.Fill(dslang);
        //        dlmedia.DataSource = dslang;
        //        dlmedia.DataBind();
        //        con.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        obj.insert_exception(ex, excep_page);
        //        Response.Redirect("HttpErrorPage.aspx");
        //    }
        //}
    }
    ////protected void bindlang(object sender, CommandEventArgs e)
    ////{
    ////    try
    ////    {
    ////        string lang = e.CommandArgument.ToString();
    ////        redirect("media.aspx?lang=" + lang,false);
    ////    }
    ////    catch (Exception ex)
    ////    {
    ////        obj.insert_exception(ex, excep_page);
    ////        Response.Redirect("HttpErrorPage.aspx");
    ////    }
    ////}
    ////protected void title_command(object sender, CommandEventArgs e)
    ////{
    ////    try
    ////    {
    ////        string id = e.CommandArgument.ToString();
    ////        redirect("media_details.aspx?id=" + id,false);
    ////    }
    ////    catch (Exception ex)
    ////    {
    ////        obj.insert_exception(ex, excep_page);
    ////        Response.Redirect("HttpErrorPage.aspx");
    ////    }
    ////}
    //protected void media_details(object sender, DataListItemEventArgs e)
    //{
    //    try
    //    {
    //        DataList dldetails = (DataList)e.Item.FindControl("dltitle");
    //        HyperLink lnkmedia = (HyperLink)e.Item.FindControl("lnklang");
    //        string language = lnkmedia.Text;
    //        if (language == "English" || language == "Hindi")
    //        {
    //            SqlDataAdapter datitle = new SqlDataAdapter("select * from media_data where LanguageSpeak='" + language + "'", con);
    //            DataSet dstitle = new DataSet();
    //            datitle.Fill(dstitle);
    //            dldetails.DataSource = dstitle;
    //            dldetails.DataBind();
    //        }
    //    }
    //    catch (Exception ex)
    //    {
    //        obj.insert_exception(ex, excep_page);
    //        Response.Redirect("HttpErrorPage.aspx");
    //    }
    //}
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
    //protected string GetUrlmedia(object category)
    //{
    //    string catname = category.ToString();
    //    return Page.GetRouteUrl("medialang", new { lang = catname });
    //}
    //protected string GetUrlmedia_details(object category)
    //{
    //    string catname = category.ToString();
    //    return Page.GetRouteUrl("media_det", new { id = catname });
    //}
}
