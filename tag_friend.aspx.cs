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
using System.Data.SqlClient;

public partial class tag_friend : System.Web.UI.Page
{
    SSCS obj1 = new SSCS();
    DataSet ds_tag = new DataSet();
    InsertData obj = new InsertData();
    static string excep_page = "tag_friend.aspx";
    string strscript = string.Empty;
    int regid;
    string uname = string.Empty;
    string uid = string.Empty;
    string upw = string.Empty;
    DataSet dsUserDetails1 = new DataSet();
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    protected void Page_Load(object sender, EventArgs e)
    {
        uid = Convert.ToString(Session["USERID"]);
        upw = Convert.ToString(Session["PASSWORD"]);
        if (uid != "" && upw != "")
        {
            SqlDataAdapter imgtext = new SqlDataAdapter("select id,mob from register where email='" + uid + "'", con);
            imgtext.Fill(dsUserDetails1);
            if (!dsUserDetails1.Tables[0].Rows.Count.Equals(0))
            {
                txtmob.Text = Convert.ToString(dsUserDetails1.Tables[0].Rows[0]["mob"]);
            }
        }

    }

    protected void img_go_Click(object sender, ImageClickEventArgs e)
    {
        try
        {      
               string mob = txtmob.Text;
                ds_tag = obj1.tag_mob(mob);
                if (!ds_tag.Tables[0].Rows.Count.Equals(0))
                {
                    regid = Convert.ToInt32(ds_tag.Tables[0].Rows[0]["id"]);
                    //uname = Convert.ToString(ds_tag.Tables[0].Rows[0]["name"]);
                    //redirect("../commingsoon.aspx",false);
                    // Response.RedirectToRoute("click.html");
                    Response.RedirectToRoute("tag_friends", new { tagid = regid, uname = uname });
                }
                else
                {
                    // redirect("../commingsoon.aspx",false);
                    //Response.RedirectToRoute("commingsoon");
                    strscript = "alert('Invalid mobile number');";
                    ClientScript.RegisterStartupScript(this.GetType(), "alertbox", strscript, true);
                }
           
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
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
}

