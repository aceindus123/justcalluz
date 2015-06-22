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
using JustCallUsData.Data;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Web.Routing;

public partial class Freelisting : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    InsertData obj = new InsertData();
    string strScript;
    static string excep_page = "Freelisting.aspx";
        /// <summary>
    /// Executes whenever page loads
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            ccjoin.Visible = true;
            string uid = Convert.ToString(Session["USERID"]);
            string upwd = Convert.ToString(Session["PASSWORD"]);
            DataSet dsUserDetails = new DataSet();

            string UserId = Convert.ToString(Session["USERID"]);
            if (UserId != "")
            {
                //if session has value then it stays in the same page
            }
            else
            {
                //After login into the account it will go Post ad
                //redirect("signin.aspx?Qname=FreeListing",false);
                Response.RedirectToRoute("Signin", new { Qname = "FreeListing" });


            }
            //Page loads without postbacking the values
            if (!Page.IsPostBack)
            {
                DataCS data = new DataCS();
                //To bind Categories
                data.FillFreeListCat(ddlCategory);
                //To bind States
                data.FillStates(ddlState);
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }

    }
    /// <summary>
    /// function to fill the sub categories for the respective categories are selected
    /// </summary>
    /// <param name="Categoty_Name"></param>
    public void fillSubCategories(string Categoty_Name)
    {
        try
        {
           SqlDataAdapter da = new SqlDataAdapter("select sid,Sub_Cat from FreeListing_SubCat where Cat= '" + Categoty_Name + "'", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "SubCategory");
            ddlSubCat.DataSource = ds.Tables["SubCategory"];
            ddlSubCat.DataValueField = "Sub_Cat";
            ddlSubCat.DataTextField = "Sub_Cat";
            ddlSubCat.DataBind();
            ddlSubCat.Items.Insert(0, "Select Speciality");
           
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
        //catch (Exception ex)
        //{
        //    lblMessage.Text = ex.Message.ToString();
        //}
    }
    /// To fill the cities for the corresponding States
    /// </summary>
    /// <param name="CountryId"></param>
    public void fillCities(string StateName)
    {
        try
        {
            SqlDataAdapter da = new SqlDataAdapter("select city_Id,city_name from Cities where state_name= '" + StateName + "'", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Cities");
            //DlCities.SelectedIndex = 0;

            ddlCity.DataSource = ds.Tables["Cities"];
            ddlCity.DataValueField = "city_name";
            ddlCity.DataTextField = "city_name";
            ddlCity.DataBind();
            ddlCity.Items.Insert(0, "Select City");
           
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
        //catch (Exception ex)
        //{
        //    lblMessage.Text = ex.Message.ToString();
        //}
    }
    /// <summary>
    /// Executes whenever category drop down selection changed
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void ddlCategory_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (ddlCategory.SelectedIndex != 0)
            {
                string Categoty_Name = Convert.ToString(ddlCategory.SelectedValue);
                fillSubCategories(Categoty_Name);
            }
            else
            {
                ddlSubCat.Items.Clear();
                ddlSubCat.Items.Insert(0, "Select Sub Category");
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    /// <summary>
    ///  Executes whenever sub category drop down selection changed
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void ddlState_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (ddlState.SelectedIndex != 0)
            {
                string State_Name = Convert.ToString(ddlState.SelectedValue);
                fillCities(State_Name);
            }
            else
            {
                ddlCity.Items.Clear();
                ddlCity.Items.Insert(0, "Select City");
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    /// <summary>
    /// To post the form values to the table after clicking button by checking validations
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void imgBtnAgree_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            ccjoin.ValidateCaptcha(txtvid.Text);
            // If condition executes when you entered invalid capcha otherwise executes else statements
            if (!ccjoin.UserValidated)
            {
                strScript = "alert('Your have to enter as like in the image.');";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                //Inform user that his input was wrong ...
                txtvid.Text = "";
                return;

            }
            else
            {
                 //SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
                    DataSet ds = new DataSet();
                    string fname = txtfname.Text.ToString();
                    string email = txtemail.Text.ToString();
                    string mob = txtcode.Text.ToString() + txtmob.Text.ToString();
                    string lanl = txtlanl.Text.ToString();
                    string bname = txtbname.Text.ToString();
                    string kob = ddlCategory.SelectedItem.Value.ToString();
                    string spec = ddlSubCat.SelectedItem.Value.ToString();
                    string web = txtweb.Text.ToString();
                    string addr = txtaddr.Text.ToString();
                    string lanm = txtlanm.Text.ToString();
                    string city = ddlCity.SelectedItem.Value.ToString();
                    string state = ddlState.SelectedItem.Value.ToString();
                    string sia = txtsia.Text.ToString();
                    //string fax = txtFax.Text.ToString();
                    string pincode = txtPincode.Text.ToString();
                    string UserId = Convert.ToString(Session["USERID"]);
                    string Area = txtArea.Text.ToString();
                    //DateTime postdate = DateTime.Now.Date;
                    //DateTime expdate = (postdate.AddDays(Convert.ToDouble(30)));              
                    ds = obj.insert_Freelistingform(fname, email, mob, lanl, bname, kob, spec, web, addr, lanm, city, state, sia, pincode, UserId, Area);

                    DataSet dsUName = new DataSet();
                    string query = "select * from register where email='" + UserId + "'";
                    SqlDataAdapter adaUName = new SqlDataAdapter(query, con);
                    adaUName.Fill(dsUName, "Register");
                    DataView dtview2 = dsUName.Tables[0].DefaultView;
                    if (!dsUName.Tables[0].Rows.Count.Equals(0))
                    {
                        string UFName = dsUName.Tables[0].Rows[0]["name"].ToString();
                        string ULName = dsUName.Tables[0].Rows[0]["LastName"].ToString();
                        //SendMail(UserId, UFName, ULName, bname, kob, spec, fname, email, mob, lanl, addr, lanm, Area, web, pincode, city, state);
                    }
                     string getID = "select top 1 id from Modulesdata where UserLoginId='" + UserId + "' order by id desc";
                                SqlDataAdapter adaId = new SqlDataAdapter(getID, con);
                                DataSet dsId = new DataSet();
                                adaId.Fill(dsId);
                                if (!dsId.Tables[0].Rows.Count.Equals(0))
                                {
                                    string dId = dsId.Tables[0].Rows[0]["id"].ToString();
                                    strScript = "alert('Your Listing has been Posted successfully. Please wait for the approval');location.replace('FreeListing-" + dId + "');";//'FreeListing_Edit.aspx?did=" + dId + "#HRO'
                                    Page.ClientScript.RegisterStartupScript(this.GetType(), "alertbox", strScript, true);
                                }

            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }

    }
    /// <summary>
    /// To send mail whenever authenticated user post their free listing
    /// </summary>
    /// <param name="UserEmailId"></param>
    /// <param name="UFName"></param>
    /// <param name="ULName"></param>
    /// <param name="BusinessName"></param>
    /// <param name="KOB"></param>
    /// <param name="Spec"></param>
    /// <param name="FName"></param>
    /// <param name="Email"></param>
    /// <param name="Mob"></param>
    /// <param name="PhNo"></param>
    /// <param name="Address"></param>
    /// <param name="LandMark"></param>
    /// <param name="Area"></param>
    /// <param name="URL"></param>
    /// <param name="Pncode"></param>
    /// <param name="City"></param>
    /// <param name="State"></param>
    private void SendMail(string UserEmailId, string UFName, string ULName, string BusinessName, string KOB, string Spec, string FName, string Email, string Mob, string PhNo, string Address, string LandMark, string Area, string URL, string Pncode, string City, string State)
    {
        string Msg = "";
        try
        {
            MailMessage mm = new MailMessage();
            //mm.From = new MailAddress("info@aceindus.in");
            mm.From = new MailAddress("info@justcalluz.com");
            mm.To.Add(UserEmailId);
            Msg += "Dear <b>" + UFName + " " + ULName + "</b>," +

                "<br><br>" +
                "Thanks for your interest with Just Call Uz. Please wait for the Approval" +
                //"<br><br> <b>Your Business Details: </b>"+
                //"<br><br>"+
                //"Contact Information: <br>"+

                "<br><br>Warm Regards," +
                "<br> Just Call Uz Team";
            mm.Subject = "Your Business details with Just Call Uz ";
            mm.IsBodyHtml = true;
            mm.Body = Msg;
            SmtpClient smtp = new SmtpClient();
            smtp.Send(mm);
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    /// <summary>
    /// To refresh captcha
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnRefreshCapcha_Click(object sender, EventArgs e)
    {
        try
        {
            UpdatePanel1.Update();
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

