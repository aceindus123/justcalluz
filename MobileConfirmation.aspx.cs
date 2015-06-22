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
using System.Net;
using System.Web.Routing;

public partial class MobileConfirmation : System.Web.UI.Page
{
    static string excep_page = "MobileConfirmation.aspx";
    InsertData obj = new InsertData();
    //Function to execute whenever page is loading
    string strScript = string.Empty;
    protected void Page_Load(object sender, EventArgs e)
    {
       
    
    }
    protected void imgBtn_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            if (Convert.ToString(Page.RouteData.Values["MobVCode"]) != "")
            {
                lblVCode.Text = Convert.ToString(Page.RouteData.Values["MobVCode"]);
                if (txtVerification.Text == lblVCode.Text)
                {
                    Response.RedirectToRoute("ThankYou", new { Msg = "register" });
                }
                else
                {
                    strScript = "alert('Please enter correct verification code');";
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
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