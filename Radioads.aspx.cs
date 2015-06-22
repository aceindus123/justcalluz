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
using System.Media;
using System.IO;
using WMPLib;
using System.Web.Routing;

//[System.Security.Permissions.PermissionSet(System.Security.Permissions.SecurityAction.Assert, Unrestricted = true)]
public partial class Radioads : System.Web.UI.Page
{
    public string swfFileName;
    public static string FileName;
    AdsCS obj1 = new AdsCS();
    InsertData obj = new InsertData();
    static string excep_page = "Radioads.aspx";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            try
            {
                string lang = "Telugu";
                DataSet dslang = obj1.radio_lang();
                dlradiolang.DataSource = dslang;
                dlradiolang.DataBind();
                DataSet ds = new DataSet();
                ds = obj1.bindradioads(lang);
                FileName = ds.Tables[0].Rows[0]["Content_Name"].ToString();
                dlradio.DataSource = ds;
                dlradio.DataBind();
            }
            catch (Exception ex)
            {
                obj.insert_exception(ex, excep_page);
                Response.Redirect("HttpErrorPage.aspx");
            }
            
        }

    }
    public string play_radio(object RAds)
    {
        string url = "";
        //try
        //{
            swfFileName = "~/Ads/" + FileName;
            url = Page.GetRouteUrl("Radioads");
        //}
        //catch (Exception ex)
        //{
        //    obj.insert_exception(ex, excep_page);
        //    Response.Redirect("HttpErrorPage.aspx");
        //}
        return url;
    }
    public string GetRLang(object rlang)
    {
        string url = "";
        //try
        //{
            string language = Convert.ToString(rlang.ToString());
            DataSet dsradio = new DataSet();
            dsradio = obj1.bindradioads(language);
            FileName = dsradio.Tables[0].Rows[0]["Content_Name"].ToString();
            dlradio.DataSource = dsradio;
            dlradio.DataBind();
            url = Page.GetRouteUrl("Radioads");
        //}
        //catch (Exception ex)
        //{
        //    obj.insert_exception(ex, excep_page);
        //    Response.Redirect("HttpErrorPage.aspx");
        //}
        return url;
    }
   
}