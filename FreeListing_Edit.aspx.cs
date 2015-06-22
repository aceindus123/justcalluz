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
using System.IO;
using System.Web.Routing;

public partial class FreeListing_Edit : System.Web.UI.Page
{
    //To make connection
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    DataSet dsUserAdvData = new DataSet();
    DataCS data = new DataCS();
    DataSet dsGetLogo = new DataSet();
    DataSet dsGetPhoto = new DataSet();
    Int16 Did = 0;
    bool t;
    string script = "";
    string Name = string.Empty;
    string Email = string.Empty;
    string Mob = string.Empty;
    string PhNo = string.Empty;
    string Title = string.Empty;
    string KOB = string.Empty;
    string Speciality = string.Empty;
    string Address = string.Empty;
    string LandMark = string.Empty;
    string Area = string.Empty;
    string Pincode = string.Empty;
    string City = string.Empty;
    string State = string.Empty;
    string WebSite = string.Empty;
    string Specifyifany = string.Empty;
    string UserId = string.Empty;

    string MonDur = "";
    string TuesDur = "";
    string WedDur = "";
    string ThursDur = "";
    string FriDur = "";
    string SatDur = "";
    string SunDur = "";
    string Monday = "";
    string Tuesday = "";
    string Wednesday = "";
    string Thursday = "";
    string Friday = "";
    string Satday = "";
    string Sunday = "";
    string Payment = "";
    string AdtInfo = "";
    string YrEst = "";
    string Prof_Assoc = "";
    string Certification = "";
    string noOfEmp = "";
    char[] separatorcomma = new char[] { ',' };
    char[] separatorspace = new char[] { ' ' };
    string imgLogoName;
    string ImgLogoContentType;
    string imgPhotoName;
    string imgPhotoContentType;
    string VideoName;
    string VideoContentType;
    string strScripts = "";
    string Caption;
    string mob_no = string.Empty;
    InsertData obj = new InsertData();
    static string excep_page = "FreeListing_Edit.aspx";
    string base_dir = System.AppDomain.CurrentDomain.BaseDirectory;

    /// <summary>
    /// Executes whenever page is loading
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            string UserId = Convert.ToString(Session["USERID"]);
            if (UserId != "")
            {
                //Stays into the same page when session has value
            }
            else
            {
                //After login into the account it will go Post ad
                //redirect("signin.aspx?Qname=FreeListing",false);
                Response.RedirectToRoute("Signin", new { Qname = "FreeListing" });

            }

            // Loads page without postbacking the values
            if (!Page.IsPostBack)
            {
                ModalPopupExtender1.Hide();
                try
                {
                    data.FillHours(ddlMonHrFr);
                    data.FillHours(ddlMonHrT);
                    data.FillMinutes(ddlMonMinFr);
                    data.FillMinutes(ddlMonMinT);
                    data.FillHours(ddlTuesHrFr);
                    data.FillMinutes(ddlTuesMinFr);
                    data.FillHours(ddlTuesHrT);
                    data.FillMinutes(ddlTuesMinT);
                    data.FillHours(ddlWedHrFr);
                    data.FillHours(ddlWedHrT);
                    data.FillMinutes(ddlWedMinFr);
                    data.FillMinutes(ddlWedMinT);
                    data.FillHours(ddlThursHrFr);
                    data.FillHours(ddlThursHrT);
                    data.FillMinutes(ddlThursMinFr);
                    data.FillMinutes(ddlThursMinT);
                    data.FillHours(ddlFriHrFr);
                    data.FillHours(ddlFriHrT);
                    data.FillMinutes(ddlFriMinFr);
                    data.FillMinutes(ddlFriMinT);
                    data.FillHours(ddlSaturHrFr);
                    data.FillHours(ddlSaturHrT);
                    data.FillMinutes(ddlSaturMinFr);
                    data.FillMinutes(ddlSaturMinT);
                    data.FillHours(ddlSunHrFr);
                    data.FillHours(ddlSunHrT);
                    data.FillMinutes(ddlSunMinFr);
                    data.FillMinutes(ddlSunMinT);
                    data.FillCompEstablishYr(ddlYearEstab);
                }
                catch (Exception ex)
                {
                    obj.insert_exception(ex, excep_page);
                    Response.Redirect("HttpErrorPage.aspx");
                }

                DataTable dtMon = new DataTable();
                dtMon = CreateDataTable();
                Session["dtMonday"] = dtMon;

                DataTable dtTues = new DataTable();
                dtTues = CreateDataTable();
                Session["dtTuesday"] = dtTues;

                DataTable dtWed = new DataTable();
                dtWed = CreateDataTable();
                Session["dtWedday"] = dtWed;

                DataTable dtThurs = new DataTable();
                dtThurs = CreateDataTable();
                Session["dtThursday"] = dtThurs;

                DataTable dtFri = new DataTable();
                dtFri = CreateDataTable();
                Session["dtFriday"] = dtFri;

                DataTable dtSatur = new DataTable();
                dtSatur = CreateDataTable();
                Session["dtSaturday"] = dtSatur;

                DataTable dtSun = new DataTable();
                dtSun = CreateDataTable();
                Session["dtSunday"] = dtSun;

                //Initializing the class object DataCS from JustCallUsData Namespace
                data.FillPaymentMode(lstBoxPayment);
                //To fill the States in the form
                data.FillStates(ddlState);
                //To bind Categories
                data.FillFreeListCat(ddlCategory);

                ViewState["previouspage"] = Request.UrlReferrer;
                string dId = Convert.ToString(Page.RouteData.Values["did"]);//DID
               // con.Open();
                Binddata obj1 = new Binddata();
                dsUserAdvData = obj1.bindFreeListingData(dId);
                // To get the values from dataset and assigned them to strings
                if (!dsUserAdvData.Tables[0].Rows.Count.Equals(0))
                {
                    try
                    {
                        Name = dsUserAdvData.Tables[0].Rows[0]["contact_person"].ToString();
                        Email = dsUserAdvData.Tables[0].Rows[0]["emailid"].ToString();
                        Mob = dsUserAdvData.Tables[0].Rows[0]["mob"].ToString();
                        string mobile = Mob.Substring(0, 1);
                        if (mobile == "+")
                        {
                            mob_no = Mob.Substring(3, 10);
                        }
                        else if (mobile == "0")
                        {
                            mob_no = Mob.Substring(1, 10);
                        }
                        PhNo = dsUserAdvData.Tables[0].Rows[0]["landphno"].ToString();
                        Title = dsUserAdvData.Tables[0].Rows[0]["company_name"].ToString();
                        KOB = dsUserAdvData.Tables[0].Rows[0]["Category"].ToString();
                        Speciality = dsUserAdvData.Tables[0].Rows[0]["SubCategory"].ToString();
                        Address = dsUserAdvData.Tables[0].Rows[0]["address"].ToString();
                        LandMark = dsUserAdvData.Tables[0].Rows[0]["land_mark"].ToString();
                        Area = dsUserAdvData.Tables[0].Rows[0]["Area"].ToString();
                        Pincode = dsUserAdvData.Tables[0].Rows[0]["Pincode"].ToString();
                        City = dsUserAdvData.Tables[0].Rows[0]["City"].ToString();
                        State = dsUserAdvData.Tables[0].Rows[0]["State"].ToString();
                        WebSite = dsUserAdvData.Tables[0].Rows[0]["Website"].ToString();
                        Specifyifany = dsUserAdvData.Tables[0].Rows[0]["free_specifany"].ToString();
                        UserId = dsUserAdvData.Tables[0].Rows[0]["UserLoginId"].ToString();
                        Session["UId"] = UserId;
                        // Bounding data base values to the respective fields in the form
                        txtfname.Text = Name;
                        txtemail.Text = Email;
                        txtmob.Text = mob_no;
                        txtlanl.Text = PhNo;
                        txtbname.Text = Title;
                        txtaddr.Text = Address;
                        txtlanmark.Text = LandMark;
                        txtArea.Text = Area;
                        txtPincode.Text = Pincode;
                        txtweb.Text = WebSite;
                        txtsia.Text = Specifyifany;
                    }
                    catch (Exception ex)
                    {
                        obj.insert_exception(ex, excep_page);
                        Response.Redirect("HttpErrorPage.aspx");
                    }
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
                    //Calling function To fill Sub Categories
                    fillSubCategories(KOB);
                    // To bound database Subcategories value to the SubCategory Dropdown list
                    for (int i = 0; i < ddlSubCat.Items.Count; i++)
                    {
                        try
                        {
                            if (ddlSubCat.Items[i].Value == Speciality.ToString())
                            {
                                ddlSubCat.SelectedValue = ddlSubCat.Items[i].Value;
                                break;
                            }
                            else
                            {
                                ddlSubCat.SelectedIndex = 0;
                            }
                        }
                        catch (Exception ex)
                        {
                            obj.insert_exception(ex, excep_page);
                            Response.Redirect("HttpErrorPage.aspx");
                        }
                    }
                }
                //con.Close();
                Did = Convert.ToInt16(Page.RouteData.Values["did"]);//DID
                string query = "select * from AddMoreInfo where dataid=" + Did;
                SqlDataAdapter adacount = new SqlDataAdapter(query, con);
                DataSet dscount = new DataSet();
                //con.Open();
                adacount.Fill(dscount);
                if (!dscount.Tables[0].Rows.Count.Equals(0))
                {
                    btnAddMoreInfo.Visible = false;
                    btnUpdateMoreInfo.Visible = true;
                    Monday = dscount.Tables[0].Rows[0]["Monday"].ToString();
                    AdtInfo = dscount.Tables[0].Rows[0]["AdditionalInfo"].ToString();
                    YrEst = dscount.Tables[0].Rows[0]["Year_Established"].ToString();
                    Prof_Assoc = dscount.Tables[0].Rows[0]["Prof_Assoc"].ToString();
                    Certification = dscount.Tables[0].Rows[0]["certifications"].ToString();
                    noOfEmp = dscount.Tables[0].Rows[0]["No_of_Employees"].ToString();
                    for (int i = 0; i < ddlMonday.Items.Count; i++)
                    {
                        try
                        {
                            if (ddlMonday.Items[i].Value == Monday.ToString())
                            {
                                ddlMonday.SelectedValue = ddlMonday.Items[i].Value;
                                break;
                            }
                        }
                        catch (Exception ex)
                        {
                            obj.insert_exception(ex, excep_page);
                            Response.Redirect("HttpErrorPage.aspx");
                        }
                    }
                    Tuesday = dscount.Tables[0].Rows[0]["Tuesday"].ToString();
                    for (int i = 0; i < ddlMonday.Items.Count; i++)
                    {
                        try
                        {
                            if (ddlTuesday.Items[i].Value == Tuesday.ToString())
                            {
                                ddlTuesday.SelectedValue = ddlTuesday.Items[i].Value;
                                break;
                            }
                        }
                        catch (Exception ex)
                        {
                            obj.insert_exception(ex, excep_page);
                            Response.Redirect("HttpErrorPage.aspx");
                        }
                    }
                    Wednesday = dscount.Tables[0].Rows[0]["Wednesday"].ToString();
                    for (int i = 0; i < ddlMonday.Items.Count; i++)
                    {
                        try
                        {
                            if (ddlWednesday.Items[i].Value == Wednesday.ToString())
                            {
                                ddlWednesday.SelectedValue = ddlWednesday.Items[i].Value;
                                break;
                            }
                        }
                        catch (Exception ex)
                        {
                            obj.insert_exception(ex, excep_page);
                            Response.Redirect("HttpErrorPage.aspx");
                        }
                    }
                    Thursday = dscount.Tables[0].Rows[0]["Thursday"].ToString();
                    for (int i = 0; i < ddlMonday.Items.Count; i++)
                    {
                        try
                        {
                            if (ddlThursday.Items[i].Value == Thursday.ToString())
                            {
                                ddlThursday.SelectedValue = ddlThursday.Items[i].Value;
                                break;
                            }
                        }
                        catch (Exception ex)
                        {
                            obj.insert_exception(ex, excep_page);
                            Response.Redirect("HttpErrorPage.aspx");
                        }
                    }
                    Friday = dscount.Tables[0].Rows[0]["Friday"].ToString();
                    for (int i = 0; i < ddlMonday.Items.Count; i++)
                    {
                        try
                        {
                            if (ddlFriday.Items[i].Value == Friday.ToString())
                            {
                                ddlFriday.SelectedValue = ddlFriday.Items[i].Value;
                                break;
                            }
                        }
                        catch (Exception ex)
                        {
                            obj.insert_exception(ex, excep_page);
                            Response.Redirect("HttpErrorPage.aspx");
                        }
                    }
                    Satday = dscount.Tables[0].Rows[0]["Saturday"].ToString();
                    for (int i = 0; i < ddlMonday.Items.Count; i++)
                    {
                        try
                        {
                            if (ddlSaturday.Items[i].Value == Satday.ToString())
                            {
                                ddlSaturday.SelectedValue = ddlSaturday.Items[i].Value;
                                break;
                            }
                        }
                        catch (Exception ex)
                        {
                            obj.insert_exception(ex, excep_page);
                            Response.Redirect("HttpErrorPage.aspx");
                        }
                    }
                    Sunday = dscount.Tables[0].Rows[0]["Sunday"].ToString();
                    for (int i = 0; i < ddlMonday.Items.Count; i++)
                    {
                        try
                        {
                            if (ddlSunday.Items[i].Value == Sunday.ToString())
                            {
                                ddlSunday.SelectedValue = ddlSunday.Items[i].Value;
                                break;
                            }
                        }
                        catch (Exception ex)
                        {
                            obj.insert_exception(ex, excep_page);
                            Response.Redirect("HttpErrorPage.aspx");
                        }
                    }
                    Payment = dscount.Tables[0].Rows[0]["PaymentMode"].ToString();
                    char[] separator = new char[] { ',' };

                    string[] strSplitArr = Payment.Split(separator);
                    foreach (string arrstrr in strSplitArr)
                    {
                        try
                        {
                            for (int i = 0; i < lstBoxPayment.Items.Count; i++)
                            {
                                if (lstBoxPayment.Items[i].Value == arrstrr)
                                {
                                    lstBoxPayment.Items[i].Selected = true;
                                    break;
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            obj.insert_exception(ex, excep_page);
                            Response.Redirect("HttpErrorPage.aspx");
                        }
                    }
                    for (int i = 0; i < ddlNoofEmp.Items.Count; i++)
                    {
                        try
                        {
                            if (ddlNoofEmp.Items[i].Value == noOfEmp.ToString())
                            {
                                ddlNoofEmp.SelectedValue = ddlNoofEmp.Items[i].Value;
                                break;
                            }
                        }
                        catch (Exception ex)
                        {
                            obj.insert_exception(ex, excep_page);
                            Response.Redirect("HttpErrorPage.aspx");
                        }
                    }
                    for (int i = 0; i < ddlYearEstab.Items.Count; i++)
                    {
                        try
                        {
                            if (ddlYearEstab.Items[i].Value == YrEst.ToString())
                            {
                                ddlYearEstab.SelectedValue = ddlYearEstab.Items[i].Value;
                                break;
                            }
                        }
                        catch (Exception ex)
                        {
                            obj.insert_exception(ex, excep_page);
                            Response.Redirect("HttpErrorPage.aspx");
                        }
                    }
                    txtCertifi.Text = Certification.ToString();
                    txtProf_Assoc.Text = Prof_Assoc.ToString();
                    txtAdtInfo.Text = AdtInfo.ToString();

                    MonDur = dscount.Tables[0].Rows[0]["Mon_Dur"].ToString();
                    if (MonDur != "")
                    {
                        try
                        {
                            lblMonTime.Text = MonDur;
                            string[] strMonDur = MonDur.Split(separatorspace);
                            string[] strMonArr = MonDur.Split(separatorcomma);
                            foreach (string arrstrrMon in strMonArr)
                            {
                                ltrMonTime.Text += arrstrrMon + "<br />";
                            }
                            ddlMonHrFr.Text = strMonDur[0].ToString();
                            ddlMonMinFr.Text = strMonDur[2].ToString();
                            ddlMonType1.Text = strMonDur[3].ToString();
                            ddlMonHrT.Text = strMonDur[5].ToString();
                            ddlMonMinT.Text = strMonDur[7].ToString();
                            ddlMonType2.Text = strMonDur[8].ToString();
                        }
                        catch (Exception ex)
                        {
                            obj.insert_exception(ex, excep_page);
                            Response.Redirect("HttpErrorPage.aspx");
                        }
                    }

                    TuesDur = dscount.Tables[0].Rows[0]["Tues_Dur"].ToString();
                    if (TuesDur != "")
                    {
                        try
                        {
                            lblTuesTime.Text = TuesDur;
                            string[] strTuesDur = TuesDur.Split(separatorspace);
                            string[] strTuesArr = TuesDur.Split(separatorcomma);
                            foreach (string arrstrrTues in strTuesArr)
                            {
                                ltrTuesTime.Text += arrstrrTues + "<br />";
                            }

                            ddlTuesHrFr.Text = strTuesDur[0].ToString();
                            ddlTuesMinFr.Text = strTuesDur[2].ToString();
                            ddlTuesHrT.Text = strTuesDur[5].ToString();
                            ddlTuesMinT.Text = strTuesDur[7].ToString();
                        }
                        catch (Exception ex)
                        {
                            obj.insert_exception(ex, excep_page);
                            Response.Redirect("HttpErrorPage.aspx");
                        }
                    }

                    WedDur = dscount.Tables[0].Rows[0]["Wed_Dur"].ToString();
                    if (WedDur != "")
                    {
                        try
                        {
                            lblWedTime.Text = WedDur;
                            string[] strWedDur = WedDur.Split(separatorspace);
                            string[] strWedArr = WedDur.Split(separatorcomma);
                            foreach (string arrstrrWed in strWedArr)
                            {
                                ltrWedTime.Text += arrstrrWed + "<br />";
                            }

                            ddlWedHrFr.Text = strWedDur[0].ToString();
                            ddlWedMinFr.Text = strWedDur[2].ToString();
                            ddlWedHrT.Text = strWedDur[5].ToString();
                            ddlWedMinT.Text = strWedDur[7].ToString();
                        }
                        catch (Exception ex)
                        {
                            obj.insert_exception(ex, excep_page);
                            Response.Redirect("HttpErrorPage.aspx");
                        }
                    }
                    ThursDur = dscount.Tables[0].Rows[0]["Thurs_Dur"].ToString();
                    if (ThursDur != "")
                    {
                        try
                        {
                            lblThursTime.Text = ThursDur;
                            string[] strThursDur = ThursDur.Split(separatorspace);
                            string[] strThursArr = ThursDur.Split(separatorcomma);
                            foreach (string arrstrrThurs in strThursArr)
                            {
                                ltrThursTime.Text += arrstrrThurs + "<br />";
                            }

                            ddlThursHrFr.Text = strThursDur[0].ToString();
                            ddlThursMinFr.Text = strThursDur[2].ToString();
                            ddlThursHrT.Text = strThursDur[5].ToString();
                            ddlThursMinT.Text = strThursDur[7].ToString();
                        }
                        catch (Exception ex)
                        {
                            obj.insert_exception(ex, excep_page);
                            Response.Redirect("HttpErrorPage.aspx");
                        }
                    }
                    FriDur = dscount.Tables[0].Rows[0]["Fri_Dur"].ToString();
                    if (FriDur != "")
                    {
                        try
                        {
                            lblFriTime.Text = FriDur;
                            string[] strFriDur = FriDur.Split(separatorspace);
                            string[] strFriArr = FriDur.Split(separatorcomma);
                            foreach (string arrstrrFri in strFriArr)
                            {
                                ltrFriTime.Text += arrstrrFri + "<br />";
                            }
                            ddlFriHrFr.Text = strFriDur[0].ToString();
                            ddlFriMinFr.Text = strFriDur[2].ToString();
                            ddlFriHrT.Text = strFriDur[5].ToString();
                            ddlFriMinT.Text = strFriDur[7].ToString();
                        }
                        catch (Exception ex)
                        {
                            obj.insert_exception(ex, excep_page);
                            Response.Redirect("HttpErrorPage.aspx");
                        }
                    }
                    SatDur = dscount.Tables[0].Rows[0]["Satur_Dur"].ToString();
                    if (SatDur != "")
                    {
                        try
                        {
                            lblSaturTime.Text = SatDur;
                            string[] strSatDur = SatDur.Split(separatorspace);
                            string[] strSatArr = SatDur.Split(separatorcomma);
                            foreach (string arrstrrSat in strSatArr)
                            {
                                ltrSaturTime.Text += arrstrrSat + "<br />";
                            }

                            ddlSaturHrFr.Text = strSatDur[0].ToString();
                            ddlSaturMinFr.Text = strSatDur[2].ToString();
                            ddlSaturHrT.Text = strSatDur[5].ToString();
                            ddlSaturMinT.Text = strSatDur[7].ToString();
                        }
                        catch (Exception ex)
                        {
                            obj.insert_exception(ex, excep_page);
                            Response.Redirect("HttpErrorPage.aspx");
                        }
                    }
                    SunDur = dscount.Tables[0].Rows[0]["Sun_Dur"].ToString();
                    if (SunDur != "")
                    {
                        try
                        {
                            lblSunTime.Text = SunDur;
                            string[] strSunDur = SunDur.Split(separatorspace);
                            string[] strSunArr = SunDur.Split(separatorcomma);
                            foreach (string arrstrrSun in strSunArr)
                            {
                                ltrSunTime.Text += arrstrrSun + "<br />";
                            }

                            ddlSunHrFr.Text = strSunDur[0].ToString();
                            ddlSunMinFr.Text = strSunDur[2].ToString();
                            ddlSunHrT.Text = strSunDur[5].ToString();
                            ddlSunMinT.Text = strSunDur[7].ToString();
                        }
                        catch (Exception ex)
                        {
                            obj.insert_exception(ex, excep_page);
                            Response.Redirect("HttpErrorPage.aspx");
                        }
                    }
                    AdtInfo = dscount.Tables[0].Rows[0]["AdditionalInfo"].ToString();
                    txtAdtInfo.Text = AdtInfo;

                }
                else
                {
                    try
                    {
                        btnAddMoreInfo.Visible = true;
                        btnUpdateMoreInfo.Visible = false;
                        trMonDur.Visible = false;
                        trTuesDur.Visible = false;
                        trWedDur.Visible = false;
                        trThursDur.Visible = false;
                        trFriDur.Visible = false;
                        trSatDur.Visible = false;
                        trSunDur.Visible = false;
                        trLstMon.Visible = false;
                        trLstTues.Visible = false;
                        trLstWed.Visible = false;
                        trLstThurs.Visible = false;
                        trLstFri.Visible = false;
                        trLstSatur.Visible = false;
                        trLstSun.Visible = false;
                    }
                    catch (Exception ex)
                    {
                        obj.insert_exception(ex, excep_page);
                        Response.Redirect("HttpErrorPage.aspx");
                    }
                }
                Did = Convert.ToInt16(Page.RouteData.Values["did"]);//DID
                // To bound Logo
                dsGetLogo = data.getLogo(Did);
                if (!dsGetLogo.Tables[0].Rows.Count.Equals(0))
                {
                    try
                    {

                        string logoname = dsGetLogo.Tables[0].Rows[0]["ImageName"].ToString();
                        if (logoname == "0")
                        {
                            lblNoLogo.Visible = true;
                            ddlLogo.Visible = false;
                            lblNoLogo.Text = "No Logo is available.Please Upload";
                        }
                        else if (logoname == "NULL")
                        {
                            lblNoLogo.Visible = true;
                            ddlLogo.Visible = false;
                            lblNoLogo.Text = "No Logo is available.Please Upload";
                        }
                        else if (logoname == "")
                        {
                            lblNoLogo.Visible = true;
                            ddlLogo.Visible = false;
                            lblNoLogo.Text = "No Logo is available.Please Upload";
                        }
                        else
                        {
                            ddlLogo.Visible = true;
                            lblNoLogo.Visible = false;
                            ddlLogo.DataSource = dsGetLogo;
                            ddlLogo.DataBind();
                        }
                    }
                    catch (Exception ex)
                    {
                        obj.insert_exception(ex, excep_page);
                        Response.Redirect("HttpErrorPage.aspx");
                    }

                }
                //To bind Photos
                dsGetPhoto = data.getPhotos(Did);
                try
                {
                    if (!dsGetPhoto.Tables[0].Rows.Count.Equals(0))
                    {
                        dlPhotos.Visible = true;
                        lblNoPhotos.Visible = false;
                        dlPhotos.DataSource = dsGetPhoto;
                        dlPhotos.DataBind();
                    }
                    else
                    {
                        lblNoPhotos.Visible = true;
                        dlPhotos.Visible = false;
                        lblNoPhotos.Text = "No Photo is available.Please Upload";
                    }
                }
                catch (Exception ex)
                {
                    obj.insert_exception(ex, excep_page);
                    Response.Redirect("HttpErrorPage.aspx");
                }
            }

            if (ddlMonday.SelectedValue == "Time Duration")
            {
                trMonDur.Visible = true;

                //if (ltrMonTime.Text == "")
                //{
                //    trLstMon.Visible = false;
                //}
                //else
                //{
                //    trLstMon.Visible = true;
                //}

            }
            else
            {
                trMonDur.Visible = false;
                trLstMon.Visible = false;
            }
            if (ddlTuesday.SelectedValue == "Time Duration")
            {
                trTuesDur.Visible = true;
                //if (ltrTuesTime.Text == "")
                //{
                //    trLstTues.Visible = false;
                //}
                //else
                //{
                //    trLstTues.Visible = true;
                //}
            }
            else
            {
                trTuesDur.Visible = false;
                trLstTues.Visible = false;
            }
            if (ddlWednesday.SelectedValue == "Time Duration")
            {
                trWedDur.Visible = true;
                //if (ltrWedTime.Text == "")
                //{
                //    trLstWed.Visible = false;
                //}
                //else
                //{
                //    trLstWed.Visible = true;
                //}
            }
            else
            {
                trWedDur.Visible = false;
                trLstWed.Visible = false;
            }
            if (ddlThursday.SelectedValue == "Time Duration")
            {
                trThursDur.Visible = true;
                //if (ltrThursTime.Text == "")
                //{
                //    trLstThurs.Visible = false;
                //}
                //else
                //{
                //    trLstThurs.Visible = true;
                //}
            }
            else
            {
                trThursDur.Visible = false;
                trLstThurs.Visible = false;
            }
            if (ddlFriday.SelectedValue == "Time Duration")
            {
                trFriDur.Visible = true;
                //if (ltrFriTime.Text == "")
                //{
                //    trLstFri.Visible = false;
                //}
                //else
                //{
                //    trLstFri.Visible = true;

                //}
            }
            else
            {
                trFriDur.Visible = false;
                trLstFri.Visible = false;
            }
            if (ddlSaturday.SelectedValue == "Time Duration")
            {
                trSatDur.Visible = true;
                //if (ltrSaturTime.Text=="")
                //{
                //    trLstSatur.Visible = false;
                //}
                //else
                //{
                //    trLstSatur.Visible = true;
                //}
            }
            else
            {
                trSatDur.Visible = false;
                trLstSatur.Visible = false;
            }
            if (ddlSunday.SelectedValue == "Time Duration")
            {
                trSunDur.Visible = true;
                //if (ltrSunTime.Text == "")
                //{
                //trLstSun.Visible = false;
                //}
                //else
                //{
                //    trLstSun.Visible = true;
                //}
            }
            else
            {
                trSunDur.Visible = false;
                trLstSun.Visible = false;
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }

       
    }
    /// <summary>
    /// Function To fill subcategories
    /// </summary>
    /// <param name="Categoty_Name"></param>
    public void fillSubCategories(string Categoty_Name)
    {
        try
        {
           // string Connection = ConfigurationManager.AppSettings["ConnectionString"];
           // SqlConnection oCon = new SqlConnection(Connection);
           // string s = "select sid,Sub_Cat from FreeListing_SubCat where Cat= '" + Categoty_Name + "'";
           // SqlCommand cmd = new SqlCommand(s, oCon);
           // oCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("select sid,Sub_Cat from FreeListing_SubCat where Cat= '" + Categoty_Name + "'", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "SubCategory");
            ddlSubCat.DataSource = ds.Tables["SubCategory"];
            ddlSubCat.DataValueField = "Sub_Cat";
            ddlSubCat.DataTextField = "Sub_Cat";
            ddlSubCat.DataBind();
            ddlSubCat.Items.Insert(0, "Select Speciality");
            //oCon.Close();
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    /// To fill the cities for the corresponding States
    /// </summary>
    /// <param name="CountryId"></param>
    public void fillCities(string StateName)
    {
        try
        {
           // string Connection = ConfigurationManager.AppSettings["ConnectionString"];
           // SqlConnection oCon = new SqlConnection(Connection);
           // string s = "select city_Id,city_name from Cities where state_name= '" + StateName + "'";
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
            //oCon.Close();
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    /// <summary>
    /// Executes whenever category drown down selection changed
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
    /// To refresh captcha text
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
    /// <summary>
    /// Function to update form values
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void imgBtnUpdate_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            if (Session["USERID"] != null)
            {
                ccjoin.ValidateCaptcha(txtvid.Text);
                // if captch is not entered correctly if statements will execute otherwise else statements will execute
                if (!ccjoin.UserValidated)
                {
                    script = "alert('Your have to enter as like in the image.');";
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", script, true);
                    //Inform user that his input was wrong ...
                    txtvid.Text = "";
                    return;

                }
                else
                {
                    try
                    {
                        string userId = Convert.ToString(Session["UId"]);
                        DataCS obj = new DataCS();
                        Name = Convert.ToString(txtfname.Text);
                        Email = Convert.ToString(txtemail.Text);
                        Mob = Convert.ToString(txtcode.Text + txtmob.Text);
                        PhNo = Convert.ToString(txtlanl.Text);
                        Title = Convert.ToString(txtbname.Text);
                        KOB = Convert.ToString(ddlCategory.SelectedValue);
                        Speciality = Convert.ToString(ddlSubCat.SelectedValue);
                        Address = Convert.ToString(txtaddr.Text);
                        LandMark = Convert.ToString(txtlanmark.Text);
                        Area = Convert.ToString(txtArea.Text);
                        Pincode = Convert.ToString(txtPincode.Text);
                        City = Convert.ToString(ddlCity.SelectedValue);
                        State = Convert.ToString(ddlState.SelectedValue);
                        WebSite = Convert.ToString(txtweb.Text);
                        Specifyifany = Convert.ToString(txtsia.Text);
                        Int16 dId = Convert.ToInt16(Page.RouteData.Values["did"]);//DID
                        obj.dContact_Person = Name;
                        obj.dEmail = Email;
                        obj.dMobile = Mob;
                        obj.dPhNumber = PhNo;
                        obj.jcdCompany_Name = Title;
                        obj.dCategory = KOB;
                        obj.dSubCategory = Speciality;
                        obj.dAddress = Address;
                        obj.dLandMark = LandMark;
                        obj.dArea = Area;
                        obj.dPinCode = Pincode;
                        obj.dCity = City;
                        obj.dState = State;
                        obj.dWebSite = WebSite;
                        obj.dSpecifyIfAny = Specifyifany;
                        obj.pId = dId;
                        obj.dLoginId = userId;

                        //Updation of data by 3-tier architecure
                        t = obj.FreeListing_Update(obj.pId, obj.dCategory, obj.dSubCategory, obj.dState, obj.dCity, obj.jcdCompany_Name,
                                                obj.dAddress, obj.dLandMark, obj.dContact_Person, obj.dEmail,
                                                obj.dPhNumber, obj.dMobile, obj.dSpecifyIfAny, obj.dArea, obj.dPinCode, obj.dWebSite, obj.dLoginId);

                        DataSet dsUName = new DataSet();
                        string query = "select * from register where email='" + userId + "'";
                        SqlDataAdapter adaUName = new SqlDataAdapter(query, con);
                        adaUName.Fill(dsUName, "Register");
                        DataView dtview2 = dsUName.Tables[0].DefaultView;
                        if (!dsUName.Tables[0].Rows.Count.Equals(0))
                        {
                            string UFName = dsUName.Tables[0].Rows[0]["name"].ToString();
                            string ULName = dsUName.Tables[0].Rows[0]["LastName"].ToString();
                            //SendMail(userId, UFName, ULName, Title, KOB, Speciality, Name, Email, Mob, PhNo, Address, LandMark, Area, WebSite, Pincode, City, State);
                        }
                        //con.Close();
                        Session["FreeListing"] = "FreeListing";
                        userId = userId.Replace("@", "-");
                        userId = userId.Replace(".", "Dot");
                        userId = userId.Replace("_", "Underscore");
                        script = "alert('Your Data has been Updated Sucessfully');location.replace('YourPostings-" + userId + "');";//('ToCheckPostings.aspx?cname=FreeListing&&id=" + userId + "');";
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "alertbox", script, true);
                    }
                    catch (Exception ex)
                    {
                        obj.insert_exception(ex, excep_page);
                        Response.Redirect("HttpErrorPage.aspx");
                    }
                }
            }
            else
            {
                script = "alert('Your session is expired. Please Relogin');location.replace('signin');";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "alertbox", script, true);
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    /// <summary>
    /// To send mail whenever authenticated user update their free listings
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
    /// To cancel the updation
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void imgBtnCancel_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            if (ViewState["previouspage"] != null)
                redirect(ViewState["previouspage"].ToString(),false);
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void btnUploadLogo_Click(object sender, EventArgs e)
    {
        try
        {
            Did = Convert.ToInt16(Page.RouteData.Values["did"]);//DID

            if (uploadLogo.HasFile)
            {
                //Str = uploadLogo.PostedFile.FileName;
                imgLogoName = System.IO.Path.GetFileName(uploadLogo.PostedFile.FileName);
                con.Open();
                dsGetLogo = data.getLogoName(imgLogoName);
                if (!dsGetLogo.Tables[0].Rows.Count.Equals(0))
                {
                    strScripts = "alert('Image name already existed please change Image Name');";
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScripts, true);
                }
                else
                {
                    try
                    {
                        if (uploadLogo.PostedFile.ContentLength < 30000)
                        {
                            //uploadLogo.PostedFile.SaveAs(Server.MapPath("~/Logos/" + imgLogoName));

                            using (System.Drawing.Image Img = System.Drawing.Image.FromStream(uploadLogo.PostedFile.InputStream))
                            {
                                if (Img.Width <= 100 & Img.Height <= 75)
                                {
                                    //string base_dir = System.AppDomain.CurrentDomain.BaseDirectory;
                                    imgLogoName = System.IO.Path.GetFileName(uploadLogo.PostedFile.FileName);
                                    string filepath = base_dir + "Logos/" + imgPhotoName;
                                    uploadLogo.PostedFile.SaveAs(filepath);
                                    ImgLogoContentType = uploadLogo.PostedFile.ContentType;
                                    data.dImgName = imgLogoName;
                                    data.dImgContType = ImgLogoContentType;
                                    data.pId = Did;
                                    t = data.Logo_Update(data.pId, data.dImgName, data.dImgContType);
                                    strScripts = "alert('Your Logo is uploaded Successfully');location.replace('FreeListing-" + Did + "');";
                                    Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScripts, true);
                                }
                                else
                                {
                                    strScripts = "alert('You can not Upload the  Image because dimensions of the image 100 X 75 Exceeds or Depriciate');";
                                    Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScripts, true);
                                }
                            }
                        }
                        else
                        {
                            strScripts = "alert('File size exceeds maximum limit 30KB.');";
                            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScripts, true);
                        }
                    }
                    catch (Exception ex)
                    {
                        obj.insert_exception(ex, excep_page);
                        Response.Redirect("HttpErrorPage.aspx");
                    }
                }
               
            }
            else
            {
                strScripts = "alert('Please browse an Image');";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScripts, true);
            }
            con.Close();
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void btnUploadPhotos_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
           
            Did = Convert.ToInt16(Page.RouteData.Values["did"]);//DID
            if (uploadPhotos.HasFile)
            {
                //Str = uploadLogo.PostedFile.FileName;
                imgPhotoName = System.IO.Path.GetFileName(uploadPhotos.PostedFile.FileName);
                con.Open();
                dsGetPhoto = data.getPhotoName(imgPhotoName);
                if (!dsGetPhoto.Tables[0].Rows.Count.Equals(0))
                {
                    strScripts = "alert('Image name already existed please change Image Name');";
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScripts, true);
                }
                else
                {
                    try
                    {
                        if (uploadPhotos.PostedFile.ContentLength < 30000)
                        {
                            //uploadPhotos.PostedFile.SaveAs(Server.MapPath("~/Photos/" + imgPhotoName));
                            using (System.Drawing.Image Img = System.Drawing.Image.FromStream(uploadPhotos.PostedFile.InputStream))
                            {
                                if (Img.Width <= 250 & Img.Height <= 300)
                                {
                                    
                                    ////Str = uploadLogo.PostedFile.FileName;

                                    imgPhotoName = System.IO.Path.GetFileName(uploadPhotos.PostedFile.FileName);
                                    string filepath = base_dir + "Photos/" + imgPhotoName;
                                    uploadPhotos.SaveAs(filepath);
                                    imgPhotoContentType = uploadPhotos.PostedFile.ContentType;
                                    Caption = txtCaption.Text;
                                    data.dImgName = imgPhotoName;
                                    data.dImgContType = imgPhotoContentType;
                                    data.pId = Did;
                                    data.dCaption = Caption;
                                    t = data.Photo_Insert(data.pId, data.dImgName, data.dImgContType, data.dCaption);
                                    strScripts = "alert('Photo is uploaded Successfully');location.replace('FreeListing-" + Did + "')";
                                    Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScripts, true);
                                    txtCaption.Text = "";
                                }
                                else
                                {
                                    strScripts = "alert('You can not Upload the  Image because dimensions of the image 250 X 300 Exceeds or Depriciate');";
                                    Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScripts, true);

                                }
                            }
                        }
                        else
                        {
                            strScripts = "alert('File size exceeds maximum limit 30KB.');";
                            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScripts, true);
                        }
                    }
                    catch (Exception ex)
                    {
                        obj.insert_exception(ex, excep_page);
                        Response.Redirect("HttpErrorPage.aspx");
                    }
                }

            }
            else
            {
                strScripts = "alert('Please browse an Image');";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScripts, true);
            }
            con.Close();
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void lnkPhotoChangeCaption(object sender, CommandEventArgs e)
    {
        try
        {
            int id = Convert.ToInt32(e.CommandArgument.ToString());
            string getPhotoname = "select * from Photos where id=" + id;
            SqlDataAdapter adaName = new SqlDataAdapter(getPhotoname, con);
            adaName.Fill(dsGetPhoto);
            if (!dsGetPhoto.Tables[0].Rows.Count.Equals(0))
            {
                Caption = dsGetPhoto.Tables[0].Rows[0]["Caption"].ToString();
            }
            //dlCaption.DataSource = dsGetPhoto;
            //dlCaption.DataBind();   
            lblId.Text = Convert.ToString(id);
            txtCaptionNew.Text = Caption;
            ModalPopupExtender1.Show();
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void submitbutton_Click(object sender, EventArgs e)
    {
        try
        {
            Did = Convert.ToInt16(Page.RouteData.Values["did"]);//DID
            string PhotoId = lblId.Text;
            Int32 Id = Convert.ToInt32(PhotoId);
            string qry = "Update Photos set Caption='" + txtCaptionNew.Text + "' where id=" + Id;
            SqlCommand cmdCaption = new SqlCommand(qry, con);
            //con.Open();
            cmdCaption.ExecuteNonQuery();
            //con.Close();
            strScripts = "alert('Caption Changed Successfully');location.replace('FreeListing-" + Did + "');";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScripts, true);
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }

    }
    protected void cancelbutton_Click(object sender, EventArgs e)
    {

    }
    protected void lnkPhotoDelete(object sender, CommandEventArgs e)
    {
        try
        {
            
            string PhotoName;
            int id = Convert.ToInt32(e.CommandArgument.ToString());
            Did = Convert.ToInt16(Page.RouteData.Values["did"]);
            string getPhotoname = "select PhotoName from Photos where id=" + id;
            SqlDataAdapter adaName = new SqlDataAdapter(getPhotoname, con);
            adaName.Fill(dsGetPhoto);
            if (!dsGetPhoto.Tables[0].Rows.Count.Equals(0))
            {
                PhotoName = dsGetPhoto.Tables[0].Rows[0]["PhotoName"].ToString();
                string dir = Server.MapPath("~/Photos/");
                string[] picList = Directory.GetFiles(dir);
                for (int i = 0; i < picList.Length; i++)
                {
                    if (picList[i].Contains(PhotoName))
                    {
                        File.Delete(picList[i]);
                    }
                }
            }
            string qryDelete = "delete from Photos where id=" + id;

            SqlCommand cmdDel = new SqlCommand(qryDelete, con);
            try
            {
                con.Open();
                cmdDel.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                obj.insert_exception(ex, excep_page);
                Response.Redirect("HttpErrorPage.aspx");
            }
            finally
            {
                cmdDel.Dispose();
                con.Close();
            }
            strScripts = "alert('Photo is deleted successfully');location.replace('FreeListing-" + Did + "');";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScripts, true);
            con.Close();
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    //protected void btnUploadVedios_Click(object sender, EventArgs e)
    //{
    //    try
    //    {
    //        Did = Convert.ToInt16(Page.RouteData.Values["did"]);//DID
    //        if (uploadVedios.HasFile)
    //        {
    //            string fileExt = System.IO.Path.GetExtension(uploadVedios.FileName);

    //            //if (fileExt == ".avi")
    //            //{
    //            try
    //            {
    //                VideoName = System.IO.Path.GetFileName(uploadVedios.PostedFile.FileName);
    //                uploadVedios.PostedFile.SaveAs(Server.MapPath("~/Videos/" + VideoName));
    //                //uploadVedios.SaveAs("~/Videos/" + System.IO.Path.GetFileName(uploadVedios.PostedFile.FileName));
    //                //VideoName = System.IO.Path.GetFileName(uploadVedios.PostedFile.FileName);
    //                VideoContentType = uploadVedios.PostedFile.ContentType;
    //                data.dImgName = VideoName;
    //                data.dImgContType = VideoContentType;
    //                data.pId = Did;
    //                t = data.Vedio_Insert(data.pId, data.dImgName, data.dImgContType);
    //                strScripts = "alert('Vedio is uploaded Successfully');location.replace('FreeListing-" + Did + "');";
    //                Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScripts, true);
    //            }
    //            catch (Exception ex)
    //            {
    //                lblException.Text = "ERROR: " + ex.Message.ToString();
    //            }
    //            //}
    //            //else
    //            //{
    //            //    lblException.Text = "Only .avi files allowed!";
    //            //}
    //        }
    //        else
    //        {
    //            lblMessage.Text = "You have not specified a file.";
    //        }
    //        //con.Close();
    //    }
    //    catch (Exception ex)
    //    {
    //        obj.insert_exception(ex, excep_page);
    //        Response.Redirect("HttpErrorPage.aspx");
    //    }
    //}
    protected void lnkMonTimings_Click(object sender, EventArgs e)
    {
        try
        {
            //Working Start
            lblLnkMon.Text = "Clicked";
            trLstMon.Visible = true;
            string TimingMon = "";
            AddDataToTable(this.ddlMonHrFr.Text.Trim(), this.ddlMonMinFr.Text.Trim(), this.ddlMonType1.Text.Trim(), this.ddlMonHrT.Text.Trim(), this.ddlMonMinT.Text.Trim(), this.ddlMonType2.Text.Trim(), (DataTable)Session["dtMonday"]);
            DataTable dtMon = ((DataTable)Session["dtMonday"]);
            if (dtMon.Rows.Count > 0)
            {
                for (int i = 0; i < dtMon.Rows.Count; i++)
                {
                    DataRow rowMon = dtMon.Rows[i];
                    string MonHr_Fr = rowMon["Hr_Fr"].ToString();
                    string MonMin_Fr = rowMon["Min_Fr"].ToString();
                    string MonType_Fr = rowMon["Type_Fr"].ToString();
                    string MonHr_T = rowMon["Hr_T"].ToString();
                    string MonMin_T = rowMon["Min_T"].ToString();
                    string MonType_T = rowMon["Type_T"].ToString();
                    TimingMon = MonHr_Fr + " : " + MonMin_Fr + " " + MonType_Fr + " - " + MonHr_T + " : " + MonMin_T + " " + MonType_T;
                }

                lblMonTime.Text += TimingMon + ",";
            }
            string[] strMonArr = TimingMon.Split(separatorcomma);
            foreach (string arrstrrMon in strMonArr)
            {
                ltrMonTime.Text += arrstrrMon + "<br />";
            }
            //Working End
            if (lblMonTime.Text.Length > 119)
            {
                lnkMonTimings.Disabled = true;
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }

    }
    protected void lnkTuesTimings_Click(object sender, EventArgs e)
    {
        try
        {
            //Working Start
            lblLnkTues.Text = "Clicked";
            trLstTues.Visible = true;
            string TimingTues = "";
            AddDataToTable(this.ddlTuesHrFr.Text.Trim(), this.ddlTuesMinFr.Text.Trim(), this.ddlTuesType1.Text.Trim(), this.ddlTuesHrT.Text.Trim(), this.ddlTuesMinT.Text.Trim(), this.ddlTuesType2.Text.Trim(), (DataTable)Session["dtTuesday"]);
            DataTable dtTues = ((DataTable)Session["dtTuesday"]);
            if (dtTues.Rows.Count > 0)
            {
                for (int i = 0; i < dtTues.Rows.Count; i++)
                {
                    DataRow rowTues = dtTues.Rows[i];
                    string TuesHr_Fr = rowTues["Hr_Fr"].ToString();
                    string TuesMin_Fr = rowTues["Min_Fr"].ToString();
                    string TuesType_Fr = rowTues["Type_Fr"].ToString();
                    string TuesHr_T = rowTues["Hr_T"].ToString();
                    string TuesMin_T = rowTues["Min_T"].ToString();
                    string TuesType_T = rowTues["Type_T"].ToString();
                    TimingTues = TuesHr_Fr + " : " + TuesMin_Fr + " " + TuesType_Fr + " - " + TuesHr_T + " : " + TuesMin_T + " " + TuesType_T;
                }

                lblTuesTime.Text += TimingTues + ",";
            }
            string[] strTuesArr = TimingTues.Split(separatorcomma);
            foreach (string arrstrrTues in strTuesArr)
            {
                ltrTuesTime.Text += arrstrrTues + "<br />";
            }
            //Working End
            if (lblTuesTime.Text.Length > 119)
            {
                lnkTuesTimings.Disabled = true;
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }

    }
    protected void lnkWedTimings_Click(object sender, EventArgs e)
    {
        try
        {
            //Working Start
            lblLnkWed.Text = "Clicked";
            trLstWed.Visible = true;
            string TimingWed = "";
            AddDataToTable(this.ddlWedHrFr.Text.Trim(), this.ddlWedMinFr.Text.Trim(), this.ddlWedType1.Text.Trim(), this.ddlWedHrT.Text.Trim(), this.ddlWedMinT.Text.Trim(), this.ddlWedType2.Text.Trim(), (DataTable)Session["dtWedday"]);
            DataTable dtWed = ((DataTable)Session["dtWedday"]);
            if (dtWed.Rows.Count > 0)
            {
                for (int i = 0; i < dtWed.Rows.Count; i++)
                {
                    DataRow rowWed = dtWed.Rows[i];
                    string WedHr_Fr = rowWed["Hr_Fr"].ToString();
                    string WedMin_Fr = rowWed["Min_Fr"].ToString();
                    string WedType_Fr = rowWed["Type_Fr"].ToString();
                    string WedHr_T = rowWed["Hr_T"].ToString();
                    string WedMin_T = rowWed["Min_T"].ToString();
                    string WedType_T = rowWed["Type_T"].ToString();
                    TimingWed = WedHr_Fr + " : " + WedMin_Fr + " " + WedType_Fr + " - " + WedHr_T + " : " + WedMin_T + " " + WedType_T;
                }

                lblWedTime.Text += TimingWed + ",";
            }
            string[] strWedArr = TimingWed.Split(separatorcomma);
            foreach (string arrstrrWed in strWedArr)
            {
                ltrWedTime.Text += arrstrrWed + "<br />";
            }
            //Working End
            if (lblWedTime.Text.Length > 119)
            {
                lnkWedTimings.Disabled = true;
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }

    }
    protected void lnkThursTimings_Click(object sender, EventArgs e)
    {
        try
        {
            //Working Start
            lblLnkThurs.Text = "Clicked";
            trLstThurs.Visible = true;
            string TimingThurs = "";
            AddDataToTable(this.ddlThursHrFr.Text.Trim(), this.ddlThursMinFr.Text.Trim(), this.ddlThursType1.Text.Trim(), this.ddlThursHrT.Text.Trim(), this.ddlThursMinT.Text.Trim(), this.ddlThursType2.Text.Trim(), (DataTable)Session["dtThursday"]);
            DataTable dtThurs = ((DataTable)Session["dtThursday"]);
            if (dtThurs.Rows.Count > 0)
            {
                for (int i = 0; i < dtThurs.Rows.Count; i++)
                {
                    DataRow rowThurs = dtThurs.Rows[i];
                    string ThursHr_Fr = rowThurs["Hr_Fr"].ToString();
                    string ThursMin_Fr = rowThurs["Min_Fr"].ToString();
                    string ThursType_Fr = rowThurs["Type_Fr"].ToString();
                    string ThursHr_T = rowThurs["Hr_T"].ToString();
                    string ThursMin_T = rowThurs["Min_T"].ToString();
                    string ThursType_T = rowThurs["Type_T"].ToString();
                    TimingThurs = ThursHr_Fr + " : " + ThursMin_Fr + " " + ThursType_Fr + " - " + ThursHr_T + " : " + ThursMin_T + " " + ThursType_T;
                }

                lblThursTime.Text += TimingThurs + ",";
            }
            string[] strThursArr = TimingThurs.Split(separatorcomma);
            foreach (string arrstrrThurs in strThursArr)
            {
                ltrThursTime.Text += arrstrrThurs + "<br />";
            }
            //Working End
            if (lblThursTime.Text.Length > 119)
            {
                lnkThursTimings.Disabled = true;
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }

    }
    protected void lnkFriTimings_Click(object sender, EventArgs e)
    {
        try
        {
            //Working Start
            lblLnkFri.Text = "Clicked";
            trLstFri.Visible = true;
            string TimingFri = "";
            AddDataToTable(this.ddlFriHrFr.Text.Trim(), this.ddlFriMinFr.Text.Trim(), this.ddlFriType1.Text.Trim(), this.ddlFriHrT.Text.Trim(), this.ddlFriMinT.Text.Trim(), this.ddlFriType2.Text.Trim(), (DataTable)Session["dtFriday"]);
            DataTable dtFri = ((DataTable)Session["dtFriday"]);
            if (dtFri.Rows.Count > 0)
            {
                for (int i = 0; i < dtFri.Rows.Count; i++)
                {
                    DataRow rowFri = dtFri.Rows[i];
                    string FriHr_Fr = rowFri["Hr_Fr"].ToString();
                    string FriMin_Fr = rowFri["Min_Fr"].ToString();
                    string FriType_Fr = rowFri["Type_Fr"].ToString();
                    string FriHr_T = rowFri["Hr_T"].ToString();
                    string FriMin_T = rowFri["Min_T"].ToString();
                    string FriType_T = rowFri["Type_T"].ToString();
                    TimingFri = FriHr_Fr + " : " + FriMin_Fr + " " + FriType_Fr + " - " + FriHr_T + " : " + FriMin_T + " " + FriType_T;
                }

                lblFriTime.Text += TimingFri + ",";
            }
            string[] strFriArr = TimingFri.Split(separatorcomma);
            foreach (string arrstrrFri in strFriArr)
            {
                ltrFriTime.Text += arrstrrFri + "<br />";
            }
            //Working End
            if (lblFriTime.Text.Length > 119)
            {
                lnkFriTimings.Disabled = true;
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }

    }
    protected void lnkSaturTimings_Click(object sender, EventArgs e)
    {
        try
        {
            //Working Start
            lblLnkSatur.Text = "Clicked";
            trLstSatur.Visible = true;
            string TimingSatur = "";
            AddDataToTable(this.ddlSaturHrFr.Text.Trim(), this.ddlSaturMinFr.Text.Trim(), this.ddlSaturType1.Text.Trim(), this.ddlSaturHrT.Text.Trim(), this.ddlSaturMinT.Text.Trim(), this.ddlSaturType2.Text.Trim(), (DataTable)Session["dtSaturday"]);
            DataTable dtSatur = ((DataTable)Session["dtSaturday"]);
            if (dtSatur.Rows.Count > 0)
            {
                for (int i = 0; i < dtSatur.Rows.Count; i++)
                {
                    DataRow rowSatur = dtSatur.Rows[i];
                    string SaturHr_Fr = rowSatur["Hr_Fr"].ToString();
                    string SaturMin_Fr = rowSatur["Min_Fr"].ToString();
                    string SaturType_Fr = rowSatur["Type_Fr"].ToString();
                    string SaturHr_T = rowSatur["Hr_T"].ToString();
                    string SaturMin_T = rowSatur["Min_T"].ToString();
                    string SaturType_T = rowSatur["Type_T"].ToString();
                    TimingSatur = SaturHr_Fr + " : " + SaturMin_Fr + " " + SaturType_Fr + " - " + SaturHr_T + " : " + SaturMin_T + " " + SaturType_T;
                }

                lblSaturTime.Text += TimingSatur + ",";
            }
            string[] strSaturArr = TimingSatur.Split(separatorcomma);
            foreach (string arrstrrSatur in strSaturArr)
            {
                ltrSaturTime.Text += arrstrrSatur + "<br />";
            }
            //Working End
            if (lblSaturTime.Text.Length > 119)
            {
                lnkSaturTimings.Disabled = true;
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }

    }
    protected void lnkSunTimings_Click(object sender, EventArgs e)
    {
        try
        {
            //Working Start

            lblLnkSun.Text = "Clicked";
            trLstSun.Visible = true;
            string TimingSun = "";
            AddDataToTable(this.ddlSunHrFr.Text.Trim(), this.ddlSunMinFr.Text.Trim(), this.ddlSunType1.Text.Trim(), this.ddlSunHrT.Text.Trim(), this.ddlSunMinT.Text.Trim(), this.ddlSunType2.Text.Trim(), (DataTable)Session["dtSunday"]);
            DataTable dtSun = ((DataTable)Session["dtSunday"]);
            if (dtSun.Rows.Count > 0)
            {
                for (int i = 0; i < dtSun.Rows.Count; i++)
                {
                    DataRow rowSun = dtSun.Rows[i];
                    string SunHr_Fr = rowSun["Hr_Fr"].ToString();
                    string SunMin_Fr = rowSun["Min_Fr"].ToString();
                    string SunType_Fr = rowSun["Type_Fr"].ToString();
                    string SunHr_T = rowSun["Hr_T"].ToString();
                    string SunMin_T = rowSun["Min_T"].ToString();
                    string SunType_T = rowSun["Type_T"].ToString();
                    TimingSun = SunHr_Fr + " : " + SunMin_Fr + " " + SunType_Fr + " - " + SunHr_T + " : " + SunMin_T + " " + SunType_T;
                }

                lblSunTime.Text += TimingSun + ",";
            }
            string[] strSunArr = TimingSun.Split(separatorcomma);
            foreach (string arrstrrSun in strSunArr)
            {
                ltrSunTime.Text += arrstrrSun + "<br />";
            }
            //Working End
            if (lblSunTime.Text.Length > 119)
            {
                lnkSunTimings.Disabled = true;
            }
            ltrSunTime.Visible = true;
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void lnkBtnClearMonTimings_Click(object sender, EventArgs e)
    {
        try
        {
            lblMonTime.Text = "";
            ltrMonTime.Text = "";
            trLstMon.Visible = false;
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void lnkBtnClearTuesTimings_Click(object sender, EventArgs e)
    {
        try
        {
            lblTuesTime.Text = "";
            ltrTuesTime.Text = "";
            trLstTues.Visible = false;
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void lnkBtnClearWedTimings_Click(object sender, EventArgs e)
    {
        try
        {
            lblWedTime.Text = "";
            ltrWedTime.Text = "";
            trLstWed.Visible = false;
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void lnkBtnClearThursTimings_Click(object sender, EventArgs e)
    {
        try
        {
            lblThursTime.Text = "";
            ltrThursTime.Text = "";
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void lnkBtnClearFriTimings_Click(object sender, EventArgs e)
    {
        try
        {
            lblFriTime.Text = "";
            ltrFriTime.Text = "";
            trLstThurs.Visible = false;
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void lnkBtnClearSatTimings_Click(object sender, EventArgs e)
    {
        try
        {
            lblSaturTime.Text = "";
            ltrSaturTime.Text = "";
            trLstSatur.Visible = false;
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void lnkBtnClearSuntimings_Click(object sender, EventArgs e)
    {
        try
        {
            lblSunTime.Text = "";
            ltrSunTime.Text = "";
            trLstSun.Visible = false;
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void btnAddMoreInfo_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            Did = Convert.ToInt16(Page.RouteData.Values["did"]);
            Conditions();

            data.dMonday = ddlMonday.SelectedValue;
            data.dMon_Dur = MonDur;
            data.dTuesday = ddlTuesday.SelectedValue;
            data.dTues_Dur = TuesDur;
            data.dWednesday = ddlWednesday.SelectedValue;
            data.dWed_Dur = WedDur;
            data.dThursday = ddlThursday.SelectedValue;
            data.dThurs_Dur = ThursDur;
            data.dFriday = ddlFriday.SelectedValue;
            data.dFri_Dur = FriDur;
            data.dSaturday = ddlSaturday.SelectedValue;
            data.dSatur_Dur = SatDur;
            data.dSunday = ddlSunday.SelectedValue;
            data.dSun_Dur = SunDur;
            data.pId = Did;
            data.dPayment = Payment;
            data.dAdtInfo = txtAdtInfo.Text;
            data.dYearEstab = ddlYearEstab.SelectedValue;
            data.dProf_Accosi = txtProf_Assoc.Text;
            data.dcertification = txtCertifi.Text;
            data.dNoofEmp = ddlNoofEmp.SelectedValue;
            
            data.MoreInfo_Insert(data.dMonday, data.dMon_Dur, data.dTuesday, data.dTues_Dur, data.dWednesday, data.dWed_Dur,
                                data.dThursday, data.dThurs_Dur, data.dFriday, data.dFri_Dur, data.dSaturday, data.dSatur_Dur,
                                data.dSunday, data.dSun_Dur, data.pId, data.dPayment, data.dAdtInfo, data.dYearEstab, data.dProf_Accosi, data.dcertification, data.dNoofEmp);
           
            string strScript = ""; 
           // strScript = "alert('Your Additional Information is Posted Successfully');location.replace('FreeListing-" + Did + "');";
            strScript = "alert('Your Additional Information is Posted Successfully');location.replace('Postings-" + Did + "');";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void btnUpdateMoreInfo_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            Did = Convert.ToInt16(Page.RouteData.Values["did"]);
            Conditions();
            data.dMonday = ddlMonday.SelectedValue;
            data.dMon_Dur = MonDur;
            data.dTuesday = ddlTuesday.SelectedValue;
            data.dTues_Dur = TuesDur;
            data.dWednesday = ddlWednesday.SelectedValue;
            data.dWed_Dur = WedDur;
            data.dThursday = ddlThursday.SelectedValue;
            data.dThurs_Dur = ThursDur;
            data.dFriday = ddlFriday.SelectedValue;
            data.dFri_Dur = FriDur;
            data.dSaturday = ddlSaturday.SelectedValue;
            data.dSatur_Dur = SatDur;
            data.dSunday = ddlSunday.SelectedValue;
            data.dSun_Dur = SunDur;
            data.pId = Did;
            data.dPayment = Payment;
            data.dAdtInfo = txtAdtInfo.Text;
            data.dYearEstab = ddlYearEstab.SelectedValue;
            data.dProf_Accosi = txtProf_Assoc.Text;
            data.dcertification = txtCertifi.Text;
            data.dNoofEmp = ddlNoofEmp.SelectedValue;
            
            data.MoreInfo_Update(data.dMonday, data.dMon_Dur, data.dTuesday, data.dTues_Dur, data.dWednesday, data.dWed_Dur,
                                data.dThursday, data.dThurs_Dur, data.dFriday, data.dFri_Dur, data.dSaturday, data.dSatur_Dur,
                                data.dSunday, data.dSun_Dur, data.pId, data.dPayment, data.dAdtInfo, data.dYearEstab, data.dProf_Accosi, data.dcertification, data.dNoofEmp);
            
            string strScript = "";
            strScript = "alert('Your Additional Information is Updated Successfully');location.replace('Postings-" + Did + "');";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void btnSkip_Click(object sender, EventArgs e)
    {
        try
        {
            if (ViewState["previouspage"] != null)
                redirect(ViewState["previouspage"].ToString(),false);
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    private DataTable CreateDataTable()
    {
        DataTable myDataTable = new DataTable();

        DataColumn myDataColumn;

        myDataColumn = new DataColumn();
        try
        {
            myDataColumn.DataType = Type.GetType("System.Int32");
            myDataColumn.ColumnName = "id";
            myDataTable.Columns.Add(myDataColumn);
            //specify it as auto increment field
            myDataColumn.AutoIncrement = true;
            myDataColumn.AutoIncrementSeed = 1;
            myDataColumn.ReadOnly = true;


            myDataColumn = new DataColumn();
            myDataColumn.DataType = Type.GetType("System.String");
            myDataColumn.ColumnName = "Hr_Fr";
            myDataTable.Columns.Add(myDataColumn);

            myDataColumn = new DataColumn();
            myDataColumn.DataType = Type.GetType("System.String");
            myDataColumn.ColumnName = "Min_Fr";
            myDataTable.Columns.Add(myDataColumn);

            myDataColumn = new DataColumn();
            myDataColumn.DataType = Type.GetType("System.String");
            myDataColumn.ColumnName = "Type_Fr";
            myDataTable.Columns.Add(myDataColumn);

            myDataColumn = new DataColumn();
            myDataColumn.DataType = Type.GetType("System.String");
            myDataColumn.ColumnName = "Hr_T";
            myDataTable.Columns.Add(myDataColumn);

            myDataColumn = new DataColumn();
            myDataColumn.DataType = Type.GetType("System.String");
            myDataColumn.ColumnName = "Min_T";
            myDataTable.Columns.Add(myDataColumn);

            myDataColumn = new DataColumn();
            myDataColumn.DataType = Type.GetType("System.String");
            myDataColumn.ColumnName = "Type_T";
            myDataTable.Columns.Add(myDataColumn);
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }


        return myDataTable;
    }
    private void AddDataToTable(string Hr_Fr, string Min_Fr, string Type_Fr, string Hr_T, string Min_T, string Type_T, DataTable myTable)
    {
        try
        {
            DataRow row;
            row = myTable.NewRow();

            row["Hr_Fr"] = Hr_Fr;
            row["Min_Fr"] = Min_Fr;
            row["Type_Fr"] = Type_Fr;
            row["Hr_T"] = Hr_T;
            row["Min_T"] = Min_T;
            row["Type_T"] = Type_T;

            myTable.Rows.Add(row);
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void lnkClearMon_Click(object sender, EventArgs e)
    {
        //lblTimings.Text = "";        
    }
    public void Conditions()
    {
        try
        {
            if (ddlMonday.SelectedValue == "Time Duration")
            {
                try
                {
                    trMonDur.Visible = true;
                    if (ltrMonTime.Text == "")
                    {
                        trLstMon.Visible = false;
                    }
                    else
                    {
                        trLstMon.Visible = true;
                    }
                    if (lblMonTime.Text.Length > 30)
                    {
                        lblLnkMon.Text = "Clicked";
                    }
                    if (lblMonTime.Text.Length > 120)
                    {
                        lnkMonTimings.Disabled = true;
                    }
                    if (lblLnkMon.Text == "Clicked")
                    {
                        MonDur = lblMonTime.Text;
                    }
                    else
                    {
                        lblMonTime.Text = ddlMonHrFr.Text + " : " + ddlMonMinFr.Text + " " + ddlMonType1.Text + " - " + ddlMonHrT.Text + " : " + ddlMonMinT.Text + " " + ddlMonType2.Text + ",";
                        MonDur = lblMonTime.Text;
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
                trMonDur.Visible = false;
                trLstMon.Visible = false;
                MonDur = "";
            }
            if (ddlTuesday.SelectedValue == "Time Duration")
            {
                try
                {
                    trTuesDur.Visible = true;
                    if (ltrTuesTime.Text == "")
                    {
                        trLstTues.Visible = false;
                    }
                    else
                    {
                        trLstTues.Visible = true;
                    }
                    if (lblTuesTime.Text.Length > 30)
                    {
                        lblLnkTues.Text = "Clicked";
                    }
                    if (lblTuesTime.Text.Length > 120)
                    {
                        lnkTuesTimings.Disabled = true;
                    }
                    if (lblLnkTues.Text == "Clicked")
                    {
                        TuesDur = lblTuesTime.Text;
                    }
                    else
                    {
                        lblTuesTime.Text = ddlTuesHrFr.Text + " : " + ddlMonMinFr.Text + " " + ddlTuesType1.Text + " - " + ddlTuesHrT.Text + " : " + ddlTuesMinT.Text + " " + ddlTuesType2.Text + ",";
                        TuesDur = lblTuesTime.Text;
                    }
                }
                catch (Exception ex)
                {
                    obj.insert_exception(ex, excep_page);
                    Response.Redirect("HttpErrorPage.aspx");
                }
                //TuesDur = ddlTuesHrFr.Text + " : " + ddlTuesMinFr.Text + " am - " + ddlTuesHrT.Text + " : " + ddlTuesMinT.Text + " T";
            }
            else
            {
                trTuesDur.Visible = false;
                trLstTues.Visible = false;
                TuesDur = "";
            }
            if (ddlWednesday.SelectedValue == "Time Duration")
            {
                try
                {
                    trWedDur.Visible = true;
                    if (ltrWedTime.Text == "")
                    {
                        trLstWed.Visible = false;
                    }
                    else
                    {
                        trLstWed.Visible = true;
                    }
                    if (lblWedTime.Text.Length > 30)
                    {
                        lblLnkWed.Text = "Clicked";
                    }
                    if (lblWedTime.Text.Length > 120)
                    {
                        lnkWedTimings.Disabled = true;
                    }
                    if (lblLnkWed.Text == "Clicked")
                    {
                        WedDur = lblWedTime.Text;
                    }
                    else
                    {
                        lblWedTime.Text = ddlWedHrFr.Text + " : " + ddlWedMinFr.Text + " " + ddlWedType1.Text + " - " + ddlWedHrT.Text + " : " + ddlWedMinT.Text + " " + ddlWedType2.Text + ",";
                        WedDur = lblWedTime.Text;
                    }
                }
                catch (Exception ex)
                {
                    obj.insert_exception(ex, excep_page);
                    Response.Redirect("HttpErrorPage.aspx");
                }
                //WedDur = ddlWedHrFr.Text + " : " + ddlWedMinFr.Text + " am - " + ddlWedHrT.Text + " : " + ddlWedMinT.Text + " T";
            }
            else
            {
                trWedDur.Visible = false;
                trLstWed.Visible = false;
                WedDur = "";
            }
            if (ddlThursday.SelectedValue == "Time Duration")
            {
                try
                {
                    trThursDur.Visible = true;
                    if (ltrThursTime.Text == "")
                    {
                        trLstThurs.Visible = false;
                    }
                    else
                    {
                        trLstThurs.Visible = true;
                    }
                    if (lblThursTime.Text.Length > 30)
                    {
                        lblLnkThurs.Text = "Clicked";
                    }
                    if (lblThursTime.Text.Length > 120)
                    {
                        lnkThursTimings.Disabled = true;
                    }
                    if (lblLnkThurs.Text == "Clicked")
                    {
                        ThursDur = lblThursTime.Text;
                    }
                    else
                    {
                        lblThursTime.Text = ddlThursHrFr.Text + " : " + ddlThursMinFr.Text + " " + ddlThursType1.Text + " - " + ddlThursHrT.Text + " : " + ddlThursMinT.Text + " " + ddlThursType2.Text + ",";
                        ThursDur = lblThursTime.Text;
                    }
                }
                catch (Exception ex)
                {
                    obj.insert_exception(ex, excep_page);
                    Response.Redirect("HttpErrorPage.aspx");
                }
                //ThursDur = ddlThursHrFr.Text + " : " + ddlThursMinFr.Text + " am - " + ddlThursHrT.Text + " : " + ddlThursMinT.Text + " T";
            }
            else
            {
                trThursDur.Visible = false;
                trLstThurs.Visible = false;
                ThursDur = "";
            }
            if (ddlFriday.SelectedValue == "Time Duration")
            {
                try
                {
                    trFriDur.Visible = true;
                    if (ltrFriTime.Text == "")
                    {
                        trLstFri.Visible = false;
                    }
                    else
                    {
                        trLstFri.Visible = true;
                    }
                    if (lblFriTime.Text.Length > 30)
                    {
                        lblLnkFri.Text = "Clicked";
                    }
                    if (lblFriTime.Text.Length > 120)
                    {
                        lnkFriTimings.Disabled = true;
                    }
                    if (lblLnkFri.Text == "Clicked")
                    {
                        FriDur = lblFriTime.Text;
                    }
                    else
                    {
                        lblFriTime.Text = ddlFriHrFr.Text + " : " + ddlFriMinFr.Text + " " + ddlFriType1.Text + " - " + ddlFriHrT.Text + " : " + ddlFriMinT.Text + " " + ddlFriType2.Text + ",";
                        FriDur = lblFriTime.Text;
                    }
                }
                catch (Exception ex)
                {
                    obj.insert_exception(ex, excep_page);
                    Response.Redirect("HttpErrorPage.aspx");
                }
                //FriDur = ddlFriHrFr.Text + " : " + ddlFriMinFr.Text + " am - " + ddlFriHrT.Text + " : " + ddlFriMinT.Text + " T";
            }
            else
            {
                trFriDur.Visible = false;
                trLstFri.Visible = false;
                FriDur = "";
            }
            if (ddlSaturday.SelectedValue == "Time Duration")
            {
                try
                {
                    trSatDur.Visible = true;
                    if (ltrSaturTime.Text == "")
                    {
                        trLstSatur.Visible = false;
                    }
                    else
                    {
                        trLstSatur.Visible = true;
                    }
                    if (lblSaturTime.Text.Length > 30)
                    {
                        lblLnkSatur.Text = "Clicked";
                    }
                    if (lblSaturTime.Text.Length > 120)
                    {
                        lnkSaturTimings.Disabled = true;
                    }
                    if (lblLnkSatur.Text == "Clicked")
                    {
                        SatDur = lblSaturTime.Text;
                    }
                    else
                    {
                        lblSaturTime.Text = ddlSaturHrFr.Text + " : " + ddlSaturMinFr.Text + " " + ddlSaturType1.Text + " - " + ddlSaturHrT.Text + " : " + ddlSaturMinT.Text + " " + ddlSaturType2.Text + ",";
                        SatDur = lblSaturTime.Text;
                    }
                }
                catch (Exception ex)
                {
                    obj.insert_exception(ex, excep_page);
                    Response.Redirect("HttpErrorPage.aspx");
                }
                //SatDur = ddlSaturHrFr.Text + " : " + ddlSaturMinFr.Text + " am - " + ddlSaturHrT.Text + " : " + ddlSaturMinT.Text + " T";
            }
            else
            {
                trSatDur.Visible = false;
                trLstSatur.Visible = false;
                SatDur = "";
            }
            if (ddlSunday.SelectedValue == "Time Duration")
            {
                try
                {
                    trSunDur.Visible = true;
                    if (ltrSunTime.Text == "")
                    {
                        trLstSun.Visible = false;
                    }
                    else
                    {
                        trLstSun.Visible = true;
                    }
                    if (lblSunTime.Text.Length > 30)
                    {
                        lblLnkSun.Text = "Clicked";
                    }
                    if (lblSunTime.Text.Length > 120)
                    {
                        lnkSunTimings.Disabled = true;
                    }
                    if (lblLnkSun.Text == "Clicked")
                    {
                        SunDur = lblSunTime.Text;
                    }
                    else
                    {
                        lblSunTime.Text = ddlSunHrFr.Text + " : " + ddlSunMinFr.Text + " " + ddlSunType1.Text + " - " + ddlSunHrT.Text + " : " + ddlSunMinT.Text + " " + ddlSunType2.Text + ",";
                        SunDur = lblSunTime.Text;
                    }
                }
                catch (Exception ex)
                {
                    obj.insert_exception(ex, excep_page);
                    Response.Redirect("HttpErrorPage.aspx");
                }
                //SunDur = ddlSunHrFr.Text + " : " + ddlSunMinFr.Text + " am - " + ddlSunHrT.Text + " : " + ddlSunMinT.Text + " T";
            }
            else
            {
                trSunDur.Visible = false;
                trLstSun.Visible = false;
                SunDur = "";
            }
            for (int i = 0; i < lstBoxPayment.Items.Count; i++)      // Select Multiple items from Listbox
            {
                try
                {
                    if (lstBoxPayment.Items[i].Selected == true)
                    {
                        Payment += lstBoxPayment.Items[i].Text + ",";
                    }
                }
                catch (Exception ex)
                {
                    obj.insert_exception(ex, excep_page);
                    Response.Redirect("HttpErrorPage.aspx");
                }
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
