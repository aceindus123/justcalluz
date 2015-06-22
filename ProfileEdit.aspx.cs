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
using CallUsRegistration.Registration;
using System.Web.Routing;

public partial class ProfileEdit : System.Web.UI.Page
{
    // to make  connection
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    DataSet dsUserProfile = new DataSet();
    bool t;
    InsertData obj = new InsertData();
    static string excep_page = "ProfileEdit.aspx";
    string Id = string.Empty;
    string Id1 = string.Empty;
    /// <summary>
    /// Executes whenever page loads
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Page_Load(object sender, EventArgs e)
    {
        // Page loads without post backing the values of the form
        if (!Page.IsPostBack)
        {
            try
            {
                DataCS data = new DataCS();
                //To bind Categories
                data.FillCategory(ddlCategory);
                //To bind States
                data.FillStates(ddlState);

                Id1 = Convert.ToString(Page.RouteData.Values["id"]);
                Id = Convert.ToString(Session["USERID"]);
                // To open connection
                //con.Open();
                // To create object for the class
                Binddata obj1 = new Binddata();
                dsUserProfile = obj1.BindProfile(Id);
                // To get the values from dataset and assigned them to strings
                if (!dsUserProfile.Tables[0].Rows.Count.Equals(0))
                {
                    string BName = dsUserProfile.Tables[0].Rows[0]["bname"].ToString();
                    string KOB = dsUserProfile.Tables[0].Rows[0]["kindofbusiness"].ToString();
                    string BDesc = dsUserProfile.Tables[0].Rows[0]["des"].ToString();
                    string FName = dsUserProfile.Tables[0].Rows[0]["name"].ToString();
                    string LName = dsUserProfile.Tables[0].Rows[0]["LastName"].ToString();
                    string Email = dsUserProfile.Tables[0].Rows[0]["email"].ToString();
                    string City = dsUserProfile.Tables[0].Rows[0]["city"].ToString();
                    string State = dsUserProfile.Tables[0].Rows[0]["state"].ToString();
                    string WebSite = dsUserProfile.Tables[0].Rows[0]["website"].ToString();
                    string Address = dsUserProfile.Tables[0].Rows[0]["addr"].ToString();
                    string LandMark = dsUserProfile.Tables[0].Rows[0]["landmark"].ToString();
                    string Mob = dsUserProfile.Tables[0].Rows[0]["mob"].ToString();
                    string Ph = dsUserProfile.Tables[0].Rows[0]["landline"].ToString();
                    string Fax = dsUserProfile.Tables[0].Rows[0]["fax"].ToString();
                    string PinCode = dsUserProfile.Tables[0].Rows[0]["PinCode"].ToString();
                    string RegType = dsUserProfile.Tables[0].Rows[0]["RegType"].ToString();
                    string rId = dsUserProfile.Tables[0].Rows[0]["id"].ToString();
                    Session["RID"] = rId;
                    // Bounding data base values to the respective fields in the form
                    txtAddress.Text = Address;
                    txtBDesc.Text = BDesc;
                    txtBName.Text = BName;
                    txtEmail.Text = Email;
                    txtFax.Text = Fax;
                    txtLandMark.Text = LandMark;
                    txtMob.Text = Mob;
                    txtFName.Text = FName;
                    txtLName.Text = LName;
                    txtPhNo.Text = Ph;
                    txtPinCode.Text = PinCode;
                    txtWebSite.Text = WebSite;
                    // To bound database state value to the State Dropdown list
                    for (int i = 0; i < ddlState.Items.Count; i++)
                    {
                        try
                        {
                            if (ddlState.Items[i].Value == State.ToString())
                            {
                                ddlState.SelectedValue = ddlState.Items[i].Value;
                                break;
                            }
                        }
                        catch (Exception ex)
                        {
                            obj.insert_exception(ex, excep_page);
                            Response.Redirect("HttpErrorPage.aspx");
                        }
                      
                    }
                    //Calling function To fill cities
                    fillCities(State);
                    // To bound database city value to the City Dropdown list
                    for (int i = 0; i < ddlCity.Items.Count; i++)
                    {
                        try
                        {
                            if (ddlCity.Items[i].Value == City.ToString())
                            {
                                ddlCity.SelectedValue = ddlCity.Items[i].Value;
                                break;
                            }
                            else
                            {
                                ddlCity.SelectedIndex = 0;
                            }
                        }
                        catch (Exception ex)
                        {
                            obj.insert_exception(ex, excep_page);
                            Response.Redirect("HttpErrorPage.aspx");
                        }
                    }
                    //To bound database Category value to the Category Dropdown list
                    for (int i = 0; i < ddlCategory.Items.Count; i++)
                    {
                        try
                        {
                            if (ddlCategory.Items[i].Value == KOB.ToString())
                            {
                                ddlCategory.SelectedValue = ddlCategory.Items[i].Value;
                                break;
                            }
                        }
                        catch (Exception ex)
                        {
                            obj.insert_exception(ex, excep_page);
                            Response.Redirect("HttpErrorPage.aspx");
                        }
                    }

                    if (RegType == "Individual")
                    {
                        try
                        {
                            trFirstName.Visible = true;
                            trLastName.Visible = true;
                            trMobNo.Visible = true;
                            trEmail.Visible = true;
                            trState.Visible = true;
                            trCity.Visible = true;
                            trPincode.Visible = true;
                            trbName.Visible = false;
                            trKOB.Visible = false;
                            trBusDesc.Visible = false;
                            trURL.Visible = false;
                            trAdres.Visible = false;
                            trLmark.Visible = false;
                            trPhNo.Visible = false;
                            trFax.Visible = false;
                            trHeadBus.Visible = false;
                        }
                        catch (Exception ex)
                        {
                            obj.insert_exception(ex, excep_page);
                            Response.Redirect("HttpErrorPage.aspx");
                        }

                    }
                    else if (RegType == "Business")
                    {
                        try
                        {
                            trFirstName.Visible = true;
                            trLastName.Visible = true;
                            trMobNo.Visible = true;
                            trEmail.Visible = true;
                            trState.Visible = true;
                            trCity.Visible = true;
                            trPincode.Visible = true;
                            trbName.Visible = true;
                            trKOB.Visible = true;
                            trBusDesc.Visible = true;
                            trURL.Visible = true;
                            trAdres.Visible = true;
                            trLmark.Visible = true;
                            trPhNo.Visible = true;
                            trFax.Visible = true;
                            trHeadBus.Visible = true;
                        }
                        catch (Exception ex)
                        {
                            obj.insert_exception(ex, excep_page);
                            Response.Redirect("HttpErrorPage.aspx");
                        }
                    }
                }

               // con.Close();
            }
            catch (Exception ex)
            {
                obj.insert_exception(ex, excep_page);
                Response.Redirect("HttpErrorPage.aspx");
            }
        }

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
           // SqlCommand cmd = new SqlCommand(s, con);
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
    /// Executes whenever sub category drown down selection changed
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
    /// Function to go to the page change password 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lnkBtnChangePW_Click(object sender, EventArgs e)
    {
        try
        {
            //redirect("ChangePassword.aspx",false);
            Response.RedirectToRoute("ChangePassword");
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    /// <summary>
    /// Function update Profile
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void ImgBtnUpdate_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            if (Session["USERID"] != null)
            {
                //Creation of object for Registration class
                string sid = Convert.ToString(Session["USERNAME"]);
                RegistrationCS reg = new RegistrationCS();
                string FName = string.Empty;
                string LName = string.Empty;
                string Address = string.Empty;
                string LandMark = string.Empty;
                string State = string.Empty;
                string City = string.Empty;
                string Pincode = string.Empty;
                string PhNo = string.Empty;
                string Fax = string.Empty;
                string BName = string.Empty;
                string BProfile = string.Empty;
                string KOB = string.Empty;
                string website = string.Empty;
                string mobile = string.Empty;
                string email = string.Empty;

                FName = Convert.ToString(txtFName.Text);
                LName = Convert.ToString(txtLName.Text);
                Address = Convert.ToString(txtAddress.Text);
                LandMark = Convert.ToString(txtLandMark.Text);
                State = Convert.ToString(ddlState.SelectedValue);
                City = Convert.ToString(ddlCity.SelectedValue);
                Pincode = Convert.ToString(txtPinCode.Text);
                PhNo = Convert.ToString(txtPhNo.Text);
                Fax = Convert.ToString(txtFax.Text);
                BName = Convert.ToString(txtBName.Text);
                BProfile = Convert.ToString(txtBDesc.Text);
                KOB = Convert.ToString(ddlCategory.SelectedValue);
                website = Convert.ToString(txtWebSite.Text);
                string rid = Convert.ToString(Session["RID"]);
                mobile = Convert.ToString(txtMob.Text);
                email = Convert.ToString(txtEmail.Text);

                reg.pUserid = rid;
                reg.rUserName = FName;
                reg.rLastName = LName;
                reg.rAddress = Address;
                reg.rLandMark = LandMark;
                reg.rState = State;
                reg.rCity = City;
                reg.rPinCode = Pincode;
                reg.rLandLine = PhNo;
                reg.rFax = Fax;
                reg.rBusinessName = BName;
                reg.rDescription = BProfile;
                reg.rKindofBusiness = KOB;
                reg.rWebSite = website;
                reg.rMobile = mobile;
                reg.rEmailId = email;
               // string Id = Convert.ToString(Page.RouteData.Values["id"]);
                t = reg.Profile_Update(reg.pUserid, reg.rUserName, reg.rLastName, reg.rAddress, reg.rLandMark, reg.rState, reg.rCity, reg.rPinCode, reg.rLandLine, reg.rFax, reg.rBusinessName, reg.rDescription, reg.rKindofBusiness, reg.rWebSite, reg.rMobile, reg.rEmailId);
                if (t == true)
                {
                    string strScript = "";
                    //strScript = "alert('Your Profile is Updated Successfully');location.replace('Profile/" + Id + "');";//'MyProfile.aspx?uid=" + Id + "'
                    //Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                    strScript = "alert('Your Profile is Updated Successfully.');location.replace('Profile-" + sid + "');";
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                }
            }
            else
            {
                string strScript = "";
                strScript = "alert('Your session is expired. Please Relogin');location.replace('signin');";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "alertbox", strScript, true);
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }

    /// <summary>
    /// Code to cancel the updation of profile
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void ImgBtnCancel_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            //string Id = Convert.ToString(Page.RouteData.Values["id"]);
            Id1 = Convert.ToString(Page.RouteData.Values["id"]);
            if (Session["USERID"] != null)
            {
                //redirect("MyProfile.aspx?uid=" + Id,false);
                Response.RedirectToRoute("profile", new { uid = Id1 });
            }
            else
            {
                string strScript = "";
                strScript = "alert('Your session is expired. Please Relogin');location.replace('signin');";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "alertbox", strScript, true);
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void lnkBtnCancel_Click(object sender, EventArgs e)
    {
        try
        {
            //string Id = Convert.ToString(Page.RouteData.Values["id"]);
            Id1 = Convert.ToString(Page.RouteData.Values["id"]);
            if (Session["USERID"] != null)
            {
                //redirect("MyProfile.aspx?uid=" + Id, false);
                Response.RedirectToRoute("profile", new { uid = Id1 });
            }
            else
            {
                string strScript = "";
                strScript = "alert('Your session is expired. Please Relogin');location.replace('signin');";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "alertbox", strScript, true);
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
   
}
