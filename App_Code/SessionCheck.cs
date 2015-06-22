using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

namespace CallUsSession.SessionChecking
{
    /// <summary>
    /// Summary description for SessionCheck
    /// </summary>
    public class SessionCheck : Page
    {
        private static string _redirectUrl;
        public static string RedirectUrl
        {
            get { return _redirectUrl; }
            set { _redirectUrl = value; }
        }

        public SessionCheck()
        {
            //
            // TODO: Add constructor logic here
            //
            _redirectUrl = string.Empty;
        }
    //    [System.Security.Permissions.PermissionSet
    //(System.Security.Permissions.SecurityAction.Demand,
    // Name = "FullTrust")] 
        override protected void OnInit(EventArgs e)
        {
            //initialize our base class (System.Web,UI.Page)            
            base.OnInit(e);
            //check to see if the Session is null (doesnt exist)
            if (Context.Session != null)
            {
                //check the IsNewSession value, this will tell us if the session has been reset.
                //IsNewSession will also let us know if the users session has timed out
                if (Session.IsNewSession)
                {
                    //now we know it's a new session, so we check to see if a cookie is present
                    string cookie = Request.Headers["Cookie"];
                    //now we determine if there is a cookie does it contains what we're looking for
                    if ((null != cookie) && (cookie.IndexOf("USERID") >= 0))
                    {
                        //since it's a new session but a ASP.Net cookie exist we know
                        //the session has expired so we need to redirect them
                        Response.Redirect("Default.aspx?timeout=yes&success=no");
                    }
                }
            }
        }


    }
}
