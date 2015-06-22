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

public partial class user_control_Header_menu : System.Web.UI.UserControl
{
    string userid;
    DataSet ds=new DataSet();
    WebAdminCreation obj = new WebAdminCreation();
    string Fname;
    string Lname;
    string designation;
    protected void Page_Load(object sender, EventArgs e)
    {
        userid = Convert.ToString(Session["LoginId"]);        
        if(!Page.IsPostBack)
        {
            GetAdminDetails();
        }
        if (Session["LoginId"] != null)
        {
            l1.Visible = true;
            l2.Visible = true;
            l2.Text = Convert.ToString(Session["IPaddr"]);
            tdLogout.Visible = true;
            lblName.Text = "Welcome <b>" + Fname + " " + Lname+"</b>";
        }
        else
        {
            l1.Visible = false;
            l2.Visible = false;
            tdLogout.Visible = false;
            lnkProfile.Visible = false;
        }
    }
    protected void lnkProfile_Click(object sender, EventArgs e)
    {        
        Response.Redirect("Admin_Profile.aspx?uid=" + userid);
    }
    private void GetAdminDetails()
    {
        ds = obj.getWebAdminPermissions(userid);
        if (!ds.Tables[0].Rows.Count.Equals(0))
        {
            Fname = ds.Tables[0].Rows[0]["fname"].ToString();
            Lname = ds.Tables[0].Rows[0]["lname"].ToString();
        }
    }
    protected void btnLogo_Click(object sender, ImageClickEventArgs e)
    {
        if (Session["LoginId"] != null)
        {
            designation = Convert.ToString(Session["Designation"]);
            if (designation == "Admin")
            {
                Response.Redirect("Admin-MainPage.aspx");
            }
            else
            {
                Response.Redirect("Admin_Home.aspx");
            }
        }
    }
}
