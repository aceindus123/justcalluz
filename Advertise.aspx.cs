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
using System.Net.NetworkInformation;
using System.Web.Routing;

public partial class Advertise : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    //Creation of Insert data class object
    InsertData obj = new InsertData();
    string strScript;
    static string excep_page = "Advertise.aspx";
    /// <summary>
    /// Executes when ever a page loads
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Page_Load(object sender, EventArgs e)
    {
        ccjoin.Visible = true;
        string uid = Convert.ToString(Session["USERID"]);
        string upwd = Convert.ToString(Session["PASSWORD"]);
        string RegType = Convert.ToString(Session["RegType"]);
        DataSet dsUserDetails = new DataSet();
        string UserId = Convert.ToString(Session["USERID"]);
        try
        {
            //To check status of User Id and registration type statuses
            if (UserId != "" && RegType == "Business")
            {
                // it will stays in the same page
            }
            else if (UserId != "" && RegType == "Individual")
            {
                //redirect("AuthenticationMsg.aspx?msg=Advertise", false);
                Response.RedirectToRoute("AuthenticationMsg", new { msg = "Advertise" });
            }
            else
            {
                //After login into the account it will go Post ad
                //redirect("signin.aspx?Qname=AdvertiseWithUs", false);
                Response.RedirectToRoute("Signin", new { Qname = "Advertise" });
            }
            //To load the page without postbacking the values
            if (!Page.IsPostBack)
            {
                //trbrandname.Visible = false;
                DataCS data = new DataCS();
                //To bind Categories
                //data.FillCategory(ddlCategory);
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
            //string Connection = ConfigurationManager.AppSettings["ConnectionString"];
            //SqlConnection oCon = new SqlConnection(Connection);
            //string s = "select id,cat from subcatageory where maincat= '" + Categoty_Name + "'";
            //SqlCommand cmd = new SqlCommand( "select id,cat from subcatageory where maincat= '" + Categoty_Name + "'", oCon);
            //oCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("select id,cat from subcatageory where maincat= '" + Categoty_Name + "'", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "SubCategory");
            ddlSubCat.DataSource = ds.Tables["SubCategory"];
            ddlSubCat.DataValueField = "cat";
            ddlSubCat.DataTextField = "cat";
            ddlSubCat.DataBind();
            ddlSubCat.Items.Insert(0, "Select Sub Category");
           // oCon.Close();
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
    //public void fillBrand(string Brand_Name)
    //{
    //    try
    //    {
    //        string Connection = ConfigurationManager.AppSettings["ConnectionString"];
    //        SqlConnection oCon = new SqlConnection(Connection);
    //        string s = "select id,SubCategeory from Lifestyle where Categeory= '" + Brand_Name + "'";
    //        SqlCommand cmd = new SqlCommand(s, oCon);
    //        oCon.Open();
    //        SqlDataAdapter da = new SqlDataAdapter(s, oCon);
    //        DataSet ds = new DataSet();
    //        da.Fill(ds, "SubCategory");
    //        ddlSubCat.DataSource = ds.Tables["SubCategory"];
    //        ddlSubCat.DataValueField = "SubCategeory";
    //        ddlSubCat.DataTextField = "SubCategeory";
    //        ddlSubCat.DataBind();
    //        ddlSubCat.Items.Insert(0, "Select Brand");
    //        oCon.Close();
    //    }
    //    catch (Exception ex)
    //    {
    //        lblMessage.Text = ex.Message.ToString();
    //    }
    //}
    public void fillB2BSubCategories(string Categoty_Name)
    {
        try
        {
            //string Connection = ConfigurationManager.AppSettings["ConnectionString"];
            //SqlConnection oCon = new SqlConnection(Connection);
            //string s = "select id,cat from B2BCategories where maincat= '" + Categoty_Name + "'";
           // SqlCommand cmd = new SqlCommand(s, oCon);
            //oCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("select id,cat from B2BCategories where maincat= '" + Categoty_Name + "'", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "SubCategory");
            ddlSubCat.DataSource = ds.Tables["SubCategory"];
            ddlSubCat.DataValueField = "cat";
            ddlSubCat.DataTextField = "cat";
            ddlSubCat.DataBind();
            ddlSubCat.Items.Insert(0, "Select Sub Category");
            //oCon.Close();
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
            //string Connection = ConfigurationManager.AppSettings["ConnectionString"];
           // SqlConnection oCon = new SqlConnection(Connection);
            //string s = "select city_Id,city_name from Cities where state_name= '" + StateName + "'";
           // SqlCommand cmd = new SqlCommand(s, oCon);
           // oCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("select city_Id,city_name from Cities where state_name= '" + StateName + "'", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Cities");
            //DlCities.SelectedIndex = 0;

            ddlCity.DataSource = ds.Tables["Cities"];
            ddlCity.DataValueField = "city_name";
            ddlCity.DataTextField = "city_name";
            ddlCity.DataBind();
            ddlCity.Items.Insert(0, "Select City");
           // oCon.Close();
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
    protected void ddlCatType_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (ddlCatType.SelectedValue == "Category")
            {
                string Categoty_Type = Convert.ToString(ddlCatType.SelectedValue);
                DataCS data = new DataCS();
                //To bind Categories
                data.FillCategory(ddlCategory);
            }
            else if (ddlCatType.SelectedValue == "B2B Category")
            {
                string Categoty_Type = Convert.ToString(ddlCatType.SelectedValue);
                DataCS data = new DataCS();
                //To bind Categories
                data.FillB2BCategory(ddlCategory);
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
                if (ddlCatType.SelectedValue == "Category")
                {
                    string Categoty_Name = Convert.ToString(ddlCategory.SelectedValue);
                    fillSubCategories(Categoty_Name);
                }
                else if (ddlCatType.SelectedValue == "B2B Category")
                {
                    string Cat_Name = Convert.ToString(ddlCategory.SelectedValue);
                    fillB2BSubCategories(Cat_Name);
                }
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
    /// Executes whenever category drop down selection changed
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    //protected void ddlSubCat_SelectedIndexChanged(object sender, EventArgs e)
    //{
    //    if (ddlSubCat.SelectedIndex != 0)
    //    {
    //        string statement = "select * from Lifestyle where Categeory='" + ddlSubCat.SelectedValue + "'";
    //        SqlDataAdapter adabrand = new SqlDataAdapter(statement, con);
    //        DataSet dsbrand = new DataSet();
    //        adabrand.Fill(dsbrand);
    //        if (!dsbrand.Tables[0].Rows.Count.Equals(0))
    //        {
    //            string brand_Name = Convert.ToString(ddlSubCat.SelectedValue);
    //            fillBrand(brand_Name);
    //        }
    //        else
    //        {
    //            ddlBrandName.Visible = false;
    //            ddlBrandName.Items.Clear();
    //            //ddlBrandName.Items.Insert(0,"Select Brand");
    //        }
    //        //else
    //        //{
    //        //    ddlSubCat.Items.Clear();
    //        //    ddlSubCat.Items.Insert(0, "Select Sub Category");
    //        //}
    //    }

    //}
    /// <summary>
    /// Executes whenever sub category drop down selection changed
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
    protected void ImgBtnAgreeToPost_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            ccjoin.ValidateCaptcha(txtvid.Text);
            // If condition executes when you entered invalid capcha otherwise executes else statements
            if (!ccjoin.UserValidated)
            {
                strScript = "alert('You have to enter as like in the image.');";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                //Inform user that his input was wrong ...
                txtvid.Text = "";
                return;

            }
            else
            {
                try
                {
                   // SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
                    DataSet ds = new DataSet();
                    string fname = txtfname.Text.ToString();
                    string email = txtemail.Text.ToString();
                    string mob = txtcode.Text.ToString() + txtmob.Text.ToString();
                    string lanl = txtlanl.Text.ToString();
                    string bname = txtbname.Text.ToString();
                    string bProfile = txtbProfile.Text.ToString();
                    string kob = ddlCategory.SelectedValue;
                    string spec = ddlSubCat.SelectedValue;
                    string web = txtweb.Text.ToString();
                    string addr = txtaddr.Text.ToString();
                    string lanmark = txtlanmark.Text.ToString();
                    string Area = txtArea.Text.ToString();
                    string PinCode = txtPincode.Text.ToString();
                    string city = ddlCity.SelectedValue;
                    string state = ddlState.SelectedValue;
                    string Fax = txtFax.Text.ToString();
                    string UserId = Convert.ToString(Session["USERID"]);
                    string Mod = ddlCatType.SelectedValue;
                    //string Brand = ddlBrandName.SelectedValue;
                    string CatSub = string.Empty;
                    //if (ddlBrandName.SelectedIndex != 0)
                    //{
                    //    CatSub = ddlSubCat.SelectedValue + "-" + ddlBrandName.SelectedValue;
                    //}
                    //else
                    //{
                    //    CatSub = "";
                    //}
                    //string mob1 = txtmob1.Text.ToString();
                    //string lanl1 = txtlan1.Text.ToString();
                    //string sia = txtsia.Text.ToString();
                    //string vid = txtvid.Text.ToString();    
                    DateTime postdate = DateTime.Now.Date;
                    DateTime expdate = (postdate.AddDays(Convert.ToDouble(30)));
                   // con.Open();
                    ds = obj.insert_Advertiseform(fname, email, mob, lanl, bname, bProfile, kob, spec, web, addr, lanmark, Area, city, state, UserId, PinCode, Mod, postdate, expdate, Fax);

                    DataSet dsUName = new DataSet();
                    string query = "select * from register where email='" + UserId + "'";
                    SqlDataAdapter adaUName = new SqlDataAdapter(query, con);
                    adaUName.Fill(dsUName, "Register");
                    DataView dtview2 = dsUName.Tables[0].DefaultView;
                    if (!dsUName.Tables[0].Rows.Count.Equals(0))
                    {
                        string UFName = dsUName.Tables[0].Rows[0]["name"].ToString();
                        string ULName = dsUName.Tables[0].Rows[0]["LastName"].ToString();
                        SendMail(UserId, UFName, ULName, bname, bProfile, kob, spec, fname, email, mob, lanl, addr, lanmark, Area, web, PinCode, city, state);
                    }
                    //con.Close();
                    txtaddr.Text = "";
                    txtArea.Text = "";
                    txtbname.Text = "";
                    txtbProfile.Text = "";
                    txtemail.Text = "";
                    txtFax.Text = "";
                    txtfname.Text = "";
                    txtlanl.Text = "";
                    txtlanmark.Text = "";
                    txtmob.Text = "";
                    txtPincode.Text = "";
                    txtvid.Text = "";
                    txtweb.Text = "";
                    ddlCategory.SelectedIndex = 0;
                    ddlCatType.SelectedIndex = 0;
                    ddlCity.SelectedIndex = 0;
                    ddlState.SelectedIndex = 0;
                    ddlSubCat.SelectedIndex = 0;
                    string strScript = "";
                    string getID = "select top 1 id from Modulesdata where UserLoginId='" + UserId + "' order by id desc";
                                SqlDataAdapter adaId = new SqlDataAdapter(getID, con);
                                DataSet dsId = new DataSet();
                                adaId.Fill(dsId);
                                if (!dsId.Tables[0].Rows.Count.Equals(0))
                                {
                                    string dId = dsId.Tables[0].Rows[0]["id"].ToString();
                                    strScript = "alert('Your Business has been Posted successfully. Please wait for the approval');location.replace('Advertise-" + dId + "');";//location.replace('Advertise_Edit.aspx?did=" + dId + "#HRO')
                                    Page.ClientScript.RegisterStartupScript(this.GetType(), "alertbox", strScript, true);
                                }
                }
                catch (Exception ex)
                {
                    obj.insert_exception(ex, excep_page);
                    Response.Redirect("HttpErrorPage.aspx");
                }
                //catch (Exception ex)
                //{
                //    ex.ToString();

                //}
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    /// <summary>
    /// To send mail whenever authenticated user post their advertisement
    /// </summary>
    /// <param name="UserEmailId"></param>
    /// <param name="UFName"></param>
    /// <param name="ULName"></param>
    /// <param name="BusinessName"></param>
    /// <param name="BProfile"></param>
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
    private void SendMail(string UserEmailId, string UFName, string ULName, string BusinessName, string BProfile, string KOB, string Spec, string FName, string Email, string Mob, string PhNo, string Address, string LandMark, string Area, string URL, string Pncode, string City, string State)
    {
        try
        {
            string Msg = "";

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
        //catch (Exception ex)
        //{
        //    lblerror.Text = ex.Message;
        //}
    }
    /// <summary>
    /// To refresh the Captcha control
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
 }

