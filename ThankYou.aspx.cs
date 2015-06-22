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
using System.Web.Routing;

public partial class ThankYou : System.Web.UI.Page
{
    static string excep_page = "ThankYou.aspx";
    InsertData obj = new InsertData();
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            string msg = Convert.ToString(Page.RouteData.Values["Msg"]);
           
            if (msg == "register")
            {
                lblMsg.Text = "Thank you for registering into just call us." +
                            "<br />You will shortly receive an email; click the link to activate your subscription. Please check your inbox or junk mail folders after 10 minutes." +
                            "<br />For any queries or concerns please write to: support@justcalluz.com" +
                            "<br /><a href=http://www.justcalluz.com/signin> Click here to login </a>";
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }

    }
}
