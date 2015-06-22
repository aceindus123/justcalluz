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
using System.Web.Configuration;
using System.Web.SessionState;
using System.Web.Routing;

/// <summary>
/// Class to Signin into their account
/// </summary>
public partial class signin : System.Web.UI.Page
{
    static string excep_page = "signin.aspx";
    InsertData obj = new InsertData();
    SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    /// <summary>
    /// Executes whenever page loads
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            string QName = Convert.ToString(Page.RouteData.Values["Qname"]);
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    /// <summary>
    /// To validate login
    /// </summary>
    /// <param name="email"></param>
    /// <param name="Mob"></param>
    /// <param name="Password"></param>
    /// <returns></returns>
    public int Validate_Login(String email,String Mob,String Password)
    {
        int Results = 0;
        try
        {
            // Making Connection

            SqlCommand cmdselect = new SqlCommand();
            cmdselect.CommandType = CommandType.StoredProcedure;
            cmdselect.CommandText = "[dbo].[loginSP]";
            cmdselect.Parameters.Add("@userid", SqlDbType.VarChar, 50).Value = email;
            cmdselect.Parameters.Add("@mobno", SqlDbType.VarChar, 50).Value = Mob;
            cmdselect.Parameters.Add("@userpwd", SqlDbType.VarChar, 50).Value = Password;
            cmdselect.Parameters.Add("@OutRes", SqlDbType.Int, 4);
            cmdselect.Parameters["@OutRes"].Direction = ParameterDirection.Output;
            cmdselect.Connection = connection;
            try
            {
                //To open connection
                connection.Open();
                cmdselect.ExecuteNonQuery();
                Results = (int)cmdselect.Parameters["@OutRes"].Value;
            }
            catch (SqlException ex)
            {
                //To catch exception
                lblMessage.Text = ex.Message;
            }
            finally
            {
                cmdselect.Dispose();
                if (connection != null)
                {
                    //To close Connection
                    connection.Close();
                }
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
        return Results;

    }
    /// <summary>
    /// Execute when you click on the login after entering username and password
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void imgBtnLogIn_Click(object sender, ImageClickEventArgs e)  
    {
        try
        {
            string str = "select * from register where email='" + txtEmail.Text + "' and password='" + txtPwd.Text + "' and mob='" + txtMob.Text + "'";
            SqlCommand cmd = new SqlCommand(str, connection);
            SqlDataReader dr;
            connection.Open();
            dr = cmd.ExecuteReader();
            string UserName = string.Empty;
            string location = string.Empty;
            string UserId = string.Empty;
            string Email = string.Empty;
            string Status = string.Empty;
            string RegType = string.Empty;
            while (dr.Read())
            {
                UserName = Convert.ToString(dr["name"]);
                Session["UserName"] = UserName;
                location = Convert.ToString(dr["city"]);
                Session["location"] = location;
                UserId = Convert.ToString(dr["id"]);
                Email = Convert.ToString(dr["email"]);
                Status = Convert.ToString(dr["iStatus"]);
                RegType = Convert.ToString(dr["RegType"]);
                Session["RegType"] = RegType;
            }
            connection.Close();
            if (Status == "1")
            {
                int Results = 0;
                //checks username and password values if there are values then validate_Login function will execute 
                //otherwise it shows invalid login
                if (txtEmail.Text != "" && txtMob.Text != "" && txtPwd.Text != "")
                {
                    Results = Validate_Login(txtEmail.Text, txtMob.Text, txtPwd.Text);
                }
                else
                {
                    lblMessage.Text = "Please make sure that the Email Id and the password are Correct";
                }
                if (Results == 1)
                {
                    string catn = Convert.ToString(Page.RouteData.Values["categ"]);
                    Session["USERID"] = txtEmail.Text;
                    Session["Mob"] = txtMob.Text;
                    Session["PASSWORD"] = txtPwd.Text;
                    Session["IPaddr"] = HttpContext.Current.Request.UserHostAddress.ToString();

                    string myHost = System.Net.Dns.GetHostName();

                    // Get the IP from the host name

                    string myIP = System.Net.Dns.GetHostByName(myHost).AddressList[0].ToString();
                    Session["IPAddress"] = myIP.ToString();

                    lblMessage.Text = "Login is Good";
                    // If login is good it goes to the Post Ad page
                    string QName = Convert.ToString(Page.RouteData.Values["Qname"]);
                    string RegisType = Convert.ToString(Session["RegType"]);
                    try
                    {
                        if (QName == "login")
                        {
                            //redirect("Default.aspx", false);
                            Response.RedirectToRoute("HomeRoute");
                        }
                        else if (QName == "Advertise")
                        {
                           // redirect("Advertise.aspx", false);
                            Response.RedirectToRoute("Advertise");

                        }
                        else if (QName == "AdvertiseWithUs")
                        {
                            int id = Convert.ToInt32(Session["AdvId"]);
                            // redirect("Advertise_Edit.aspx?DID="+id+"", false);
                            Response.RedirectToRoute("AdvertiseEdit", new { DID = id });

                        }
                        else if (QName == "jobs")
                        {
                            //redirect("post_job.aspx?cname=jobs", false);
                            Response.RedirectToRoute("PostJob", new { cname = "jobs" });
                        }
                        else if (QName == "Editjob")
                        {
                            //redirect("edit_job.aspx?cname=jobs", false);
                            Response.RedirectToRoute("EditJob", new { cname = "jobs" });
                        }
                        else if (QName == "Events")
                        {
                            //redirect("post_event.aspx?cname=events", false);
                            Response.RedirectToRoute("postEvent", new { cname = "events" });
                        }
                        else if (QName == "Discount")
                        {
                            //redirect("post_discount.aspx?cname=discounts", false);
                            Response.RedirectToRoute("PostDiscount", new { cname = "discounts" });
                        }
                        else if (QName == "ViewDiscount")
                        {
                            //redirect("view_discounts.aspx", false);
                            Response.RedirectToRoute("ViewDiscount");
                        }
                        else if (QName == "ViewBriefDiscount")
                        {
                            //redirect("view_BriefDiscounts.aspx", false);
                            Response.RedirectToRoute("ViewDiscountDetails");
                        }
                        else if (QName == "FreeListing")
                        {
                            //redirect("Freelisting.aspx", false);
                            Response.RedirectToRoute("Free");

                        }
                        else if (QName == "Careers")
                        {
                            //redirect("careers_postresume.aspx", false);
                            Response.RedirectToRoute("PostResume1");
                        }
                        else if (QName == "LifeStyle")
                        {
                            //redirect("post_lifestyle.aspx?cname=LifeStyle", false);
                            Response.RedirectToRoute("PostLife", new { cname = "LifeStyle" });
                        }
                        else if (QName == "EditLifeStyle")
                        {
                            int id = Convert.ToInt32(Session["sid"]);
                            //redirect("edit_LifeStyle.aspx?id=" + id + "&cname=LifeStyle", false);
                            Response.RedirectToRoute("editlife", new { id = id, cname = "LifeStyle" });
                        }
                        else if (QName == "ViewLifeStyle")
                        {
                            //redirect("view_lifestyle_brief.aspx", false);
                            Response.RedirectToRoute("viewLife");

                        }
                        else
                        {
                            //redirect("Default.aspx", false);
                            Response.RedirectToRoute("HomeRoute");
                        }
                    }
                    catch (Exception ex)
                    {
                        obj.insert_exception(ex, excep_page);
                        Response.Redirect("HttpErrorPage.aspx");
                    }
                }
                else
                {
                    lblMessage.Text = "<b>Please make sure that the Email Id and the password are Correct <b>"; lblMessage.ForeColor = System.Drawing.Color.Red;//Dont Give too much information this might tell a hacker what is wrong in the login
                    //lblMsg.Text = "";

                }
            }
            else
            {
                lblMessage.Text = "Invalid Credentials. Please relogin.";
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
        finally
        {
            if (connection != null)
            {
                //To close Connection
                connection.Close();
            }
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
