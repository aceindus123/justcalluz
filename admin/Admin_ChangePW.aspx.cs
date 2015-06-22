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
/// <summary>
/// To change password of a particular user
/// </summary>
public partial class admin_Admin_ChangePW : System.Web.UI.Page
{
    //making sql connection
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    //declation of variables
    SqlDataAdapter ada;
    string strScript = "";
    string UserId;
    DataSet ds = new DataSet();
    string qry;
    string pwd;
    //creation of object of class
    WebAdminCreation obj = new WebAdminCreation();
    /// <summary>
    /// Executes whenever page loads
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Page_Load(object sender, EventArgs e)
    {
        // Checking Status of Login
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
    }
    /// <summary>
    /// To save new password
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnSave_Click(object sender, EventArgs e)
    {
        //Start Checking validations
        //Checking required field validations
        if (txtoldPW.Text == "")
        {
            lbloldmsg.Text = "Required field cannot be left blank";
        }
        else
        {
            ds = obj.getWebAdminPermissions(UserId);
            if (!ds.Tables[0].Rows.Count.Equals(0))
            {
                pwd = ds.Tables[0].Rows[0]["password"].ToString();
            }
            if (pwd == txtoldPW.Text)
            {
                lbloldmsg.Text = "";
            }
            else
            {
                lbloldmsg.Text = "The password you gave is incorrect. ";
                //txtoldPW.Text = "";
            }
        }
        if (txtnewPW.Text == "")
        {
            lblnewmsg.Text = "Required field cannot be left blank";
        }
        else
        {
            //checking password length
            if (txtnewPW.Text.Length < 8)
            {
                lblnewmsg.Text = " Must have at least 8 characters";
                //txtnewPW.Text = "";
            }
            else
            {
                lblnewmsg.Text = "";            
            }
        }
        if (txtConfirmNewPw.Text == "")
        {
            lblConPW.Text = "Required field cannot be left blank";
        }
        else
        {
            if (txtConfirmNewPw.Text.Length < 8)
            {
                lblConPW.Text = " Must have at least 8 characters";
                //txtConfirmNewPw.Text = "";
            }
            else
            {
                if (txtnewPW.Text != txtConfirmNewPw.Text && txtnewPW.Text != "")
                {
                    lblConPW.Text = "Password do not match.";
                    //txtConfirmNewPw.Text = "";
                }
                else
                {
                    lblConPW.Text = "";
                }
            }
         }
        //End checking validations
        // If all the fields of the form are correct if condition will execute
        if (lblConPW.Text == "" && lblnewmsg.Text == "" && lbloldmsg.Text == "")
        {
            qry = "update Admin_WebAdminCreation set password='" + txtnewPW.Text + "' where email='"+ UserId +"'";
            SqlCommand cmd = new SqlCommand(qry, con);
            //Open sql connection
            con.Open();
            //execute sql command
            cmd.ExecuteNonQuery();
            //Close sql connection
            con.Close();
            //alert if password changed successfully
            strScript = "alert('Password Changed Successfully.');location.replace('Admin_Profile.aspx?uid=" + UserId + "');";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
        }        
    }
    /// <summary>
    /// Cancel change password
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("Admin_Profile.aspx?uid=" + UserId);        
    }    
}
