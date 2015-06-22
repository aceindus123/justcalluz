
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
using CallUsRegistration.Registration;
public partial class admin_Default : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    string strScript="";
    string UserId;
    RegistrationCS reg = new RegistrationCS();
    protected void Page_Load(object sender, EventArgs e)
    {
        UserId = Convert.ToString(Session["LogInId"]);
        if (UserId != "")
        {
            //Response.Redirect("Admin_Home.aspx");
        }
        else
        {               
        }
        
    }
    /// <summary>
    /// To Login into admin control
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        DataSet ds = new DataSet();
        string query;
       
        query = "select * from Admin_WebAdminCreation where email='" + txtUserId.Text + "' and password='" + txtPwd.Text + "' and AdminType='" + ddlUsertype.SelectedItem.Text + "' and Country='" + ddlCountry.SelectedItem.Text + "'";
        con.Open();
        SqlDataAdapter ada = new SqlDataAdapter(query, con);
        ada.Fill(ds);
        if (!ds.Tables[0].Rows.Count.Equals(0))
        {
            if (ddlUsertype.SelectedItem.Text == "Admin")
            {
                Session["LogInId"] = Convert.ToString(txtUserId.Text);
                Session["IPaddr"] = HttpContext.Current.Request.UserHostAddress.ToString();
                reg.loginstat = 1;
                reg.pUserid = Convert.ToString(Session["LogInId"]);
                reg.LoginStatus(reg.pUserid, reg.loginstat);
                Session["Designation"] = ddlUsertype.SelectedItem.Text;
                txtUserId.Text = "";
                txtPwd.Text = "";
                ddlCountry.SelectedItem.Text = "Select";
                ddlUsertype.SelectedItem.Text = "Select";
                Response.Redirect("Admin-MainPage.aspx");
            }
            else
            {
                Session["LogInId"] = Convert.ToString(txtUserId.Text);
                Session["IPaddr"] = HttpContext.Current.Request.UserHostAddress.ToString();
                reg.loginstat = 1;
                reg.pUserid = Convert.ToString(Session["LogInId"]);
                reg.LoginStatus(reg.pUserid, reg.loginstat);
                Session["Designation"] = ddlUsertype.SelectedItem.Text;
                txtUserId.Text = "";
                txtPwd.Text = "";
                ddlCountry.SelectedItem.Text = "Select";
                ddlUsertype.SelectedItem.Text = "Select";
                Response.Redirect("Admin_Home.aspx");
            }
        }
        else
        {
            tdmsg.InnerHtml = "Please Enter Correct UserId and Password";
            txtUserId.Text = "";
            txtPwd.Text = "";
        }

        //if (rbtnadmin.Checked == true)
        //{
        //    if (txtUserId.Text != "" && txtPwd.Text != "")
        //    {
        //        query = "select * from Admin_WebAdminCreation where email='" + txtUserId.Text + "' and password='" + txtPwd.Text + "' and AdminType='Admin'";
        //        con.Open();
        //        SqlDataAdapter ada = new SqlDataAdapter(query, con);
        //        ada.Fill(ds);
        //        if (!ds.Tables[0].Rows.Count.Equals(0))
        //        {
        //            Session["LogInId"] = Convert.ToString(txtUserId.Text);
        //            Session["IPaddr"] = HttpContext.Current.Request.UserHostAddress.ToString();
        //            reg.loginstat = 1;
        //            reg.pUserid = Convert.ToString(Session["LogInId"]);
        //            reg.LoginStatus(reg.pUserid, reg.loginstat);
        //            Response.Redirect("Admin_Home.aspx");
        //        }
        //        else
        //        {
        //            tdmsg.InnerHtml = "Please Enter Correct UserId and Password";
        //        }
        //    }
        //    else
        //    {
        //        tdmsg.InnerHtml = "Please Enter Correct UserId and Password";
        //    }
        //}
        //else if (rbtnwebadmin.Checked == true)
        //{
        //    if (txtUserId.Text != "" && txtPwd.Text != "")
        //    {
                
        //        query = "select * from Admin_WebAdminCreation where email='" + txtUserId.Text + "' and password='" + txtPwd.Text + "' and AdminType='WebAdmin' and Status=1";
        //        con.Open();
        //        SqlDataAdapter ada = new SqlDataAdapter(query, con);
        //        ada.Fill(ds);
        //        if (!ds.Tables[0].Rows.Count.Equals(0))
        //        {
        //            Session["LogInId"] = Convert.ToString(txtUserId.Text);
        //            Session["IPaddr"] = HttpContext.Current.Request.UserHostAddress.ToString();
        //            reg.loginstat = 1;
        //            reg.pUserid=Convert.ToString(Session["LogInId"]);
        //            reg.LoginStatus(reg.pUserid, reg.loginstat);
        //            Response.Redirect("Admin_Home.aspx");
        //        }
        //        else
        //        {
        //            tdmsg.InnerHtml = "Please Enter Correct UserId and Password";
        //        }
        //    }
        //    else
        //    {
        //        tdmsg.InnerHtml = "Please Enter Correct UserId and Password";
        //    }

        //}
        //else
        //{
        //    strScript = "alert('Please select Type of the login');";
        //    Page.ClientScript.RegisterStartupScript(this.GetType(), "alertbox", strScript, true);
        //}
        //con.Close();
    }
}
