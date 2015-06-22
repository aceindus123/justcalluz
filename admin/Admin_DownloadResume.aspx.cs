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
using System.IO;
/// <summary>
/// Class to download resume of the job applicant
/// </summary>
public partial class admin_Admin_DownloadResume : System.Web.UI.Page
{
    //Declaration of a variable
    string UserId;
    string strScripts;
    /// <summary>
    /// Executes whenever page loads
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Page_Load(object sender, EventArgs e)
    {
        UserId = Convert.ToString(Session["LogInId"]);
        if (UserId != "")
        {
            // it will stays in the same page
        }

        else
        {
            //After login into the account it will go Post ad
            Response.Redirect("Default.aspx");

        }
        //Getting file name of the document
        string fileName = Convert.ToString(Request.QueryString["name"]);
        //Mensioning the file type                
        Response.ContentType = "application/octet-stream";
        Response.AddHeader("Content-Disposition", "attachment;filename=" + fileName);
        //Retrieving the file from the folder resume
        Response.TransmitFile(Server.MapPath("~/resume/" + fileName));
        Response.End();
                   
    }
}
