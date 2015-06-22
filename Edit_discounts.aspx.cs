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
using System.Net.Mail;
using JustCallUsData.Data;
using System.IO;
using System.Collections.Generic;
using System.Net;
using System.Net.NetworkInformation;
using System.Web.Routing;


public partial class Edit_discounts : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    string strScript = string.Empty;
    bool t;
    DataCS data = new DataCS();
    SqlDataAdapter sda;
    Binddata objBd = new Binddata();
    string Categoty_Name = string.Empty;
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
    char[] separatorcomma = new char[] { ',' };
    char[] separatorspace = new char[] { ' ' };
    string imgLogoName;
    string ImgLogoContentType;
    string photoname;
    string photopath;
    string mob_no = string.Empty;
    InsertData obj = new InsertData();
    string id = string.Empty;
    static string excep_page = "Edit_discounts.aspx";
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {

            string userid = Convert.ToString(Session["USERID"]);
            id = Convert.ToString(Page.RouteData.Values["id"].ToString());
            string regtype = Convert.ToString(Session["RegType"]);
            if (userid != "" && regtype == "Business")
            {
            }
            else if (userid != "" && regtype == "Individual")
            {

                Response.RedirectToRoute("AuthenticationMsg", new { msg = "Discount" });//"AuthenticationMsg.aspx?msg=Discount",false)

            }

            else
                Response.RedirectToRoute("Signin", new { Qname = "EditDiscount" });//"signin.aspx?Qname=EditDiscount",false)
       
            ccjoin.Visible = true;
            //Applying validations on dates
            //con.Open();
            try
            {
                string getdate = "select startmindate=DATEADD(mi,750,GETDATE()), startdatemax=DATEADD(dd,90,DATEADD(mi,750,GETDATE())),enddatemax=DATEADD(dd,365,DATEADD(mi,750,GETDATE())),jobexpdate=DATEADD(dd,60,DATEADD(mi,750,GETDATE()))";
                SqlDataAdapter ada = new SqlDataAdapter(getdate, con);
                DataSet ds = new DataSet();
                ada.Fill(ds);
                //con.Close();
                if (!ds.Tables[0].Rows.Count.Equals(0))
                {
                    string startdatemin = ds.Tables[0].Rows[0]["startmindate"].ToString();
                    string startdatemax = ds.Tables[0].Rows[0]["startdatemax"].ToString();
                    string enddatemax = ds.Tables[0].Rows[0]["enddatemax"].ToString();
                    string jobexpdate = ds.Tables[0].Rows[0]["jobexpdate"].ToString();
                    // Giving max and min values to the range validators at run time
                    rngone.MinimumValue = Convert.ToDateTime(startdatemin).ToShortDateString();
                    rngone.MaximumValue = Convert.ToDateTime(startdatemax).ToShortDateString();
                    rngone.ErrorMessage = " Please select from the date" + " " + Convert.ToDateTime(startdatemin).ToShortDateString() + " To " + Convert.ToDateTime(startdatemax).ToShortDateString();
                }
            }
            catch (Exception ex)
            {
                obj.insert_exception(ex, excep_page);
                Response.Redirect("HttpErrorPage.aspx");
            }
            if (!IsPostBack)
            {
               
                BindCatDropdown();
                data.FillStates(ddlstate);
                data.FillCompEstablishYr(ddlyearestblish);
                getphotos();
                Binddetails();
                ViewState["previouspage"] = Request.UrlReferrer;
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
                try
                {
                    DataSet dsLogo = new DataSet();
                    dsLogo = objBd.getViewRecords(id);
                    if (dsLogo.Tables[0].Rows.Count > 0)
                    {
                        imgLogoName = dsLogo.Tables[0].Rows[0]["ImageName"].ToString();
                        ImgLogoContentType = dsLogo.Tables[0].Rows[0]["ImageContentType"].ToString();
                        ImgLogo.ImageUrl = "../Logos/" + imgLogoName;
                        if (imgLogoName != "")
                        {
                            trDisplayLogo.Visible = true;
                            ImgLogo.Visible = true;
                            truploadLogo.Visible = false;
                        }
                        else
                        {
                            trDisplayLogo.Visible = false;
                            truploadLogo.Visible = true;
                            lblLogo.Text = " No logo is available,please upload the logo ";
                        }

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
    public void getphotos()
    {
        try
        {
            int sid = Convert.ToInt32(Page.RouteData.Values["id"]);
            DataSet dsphoto = new DataSet();
            dsphoto = data.getPhotos(sid);
            if (!dsphoto.Tables[0].Rows.Count.Equals(0))
            {
                dlPhoto.DataSource = dsphoto;
                dlPhoto.DataBind();
                con.Close();
            }
            else
            {
                lblMessage.Text = "No Photos are available,Please upload photos";
            }
           
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }


    /// <summary>
    /// To bind the data which is already existed in the database to get modified 
    /// </summary>
     protected void Binddetails()
     {
         try
         {
             int id = Convert.ToInt32(Page.RouteData.Values["id"].ToString());
             SqlCommand cmd = new SqlCommand("viewdiscount", con);
             cmd.CommandType = CommandType.StoredProcedure;
             cmd.Parameters.AddWithValue("@id", id);
             SqlDataAdapter da = new SqlDataAdapter(cmd);
             DataSet ds = new DataSet();
             da.Fill(ds);
             if (!ds.Tables[0].Rows.Count.Equals(0))
             {
                 txtcname.Text = ds.Tables[0].Rows[0]["company_name"].ToString();
                 string cat = ds.Tables[0].Rows[0]["Category"].ToString();
                 string Subcat = ds.Tables[0].Rows[0]["SubCategory"].ToString();
                 string type = ds.Tables[0].Rows[0]["evedi_DurationType"].ToString();
                 try
                 {
                     if (type == "Oneday Discount")
                     {
                         txtone.Visible = true;
                         txtmulti.Visible = false;
                         txtone.Text = ds.Tables[0].Rows[0]["event_startdate"].ToString();

                     }
                     else
                     {
                         txtone.Visible = true;
                         txtmulti.Visible = true;
                         txtone.Text = ds.Tables[0].Rows[0]["event_startdate"].ToString();
                         txtmulti.Text = ds.Tables[0].Rows[0]["event_enddate"].ToString();
                     }
                 }
                 catch (Exception ex)
                 {
                     obj.insert_exception(ex, excep_page);
                     Response.Redirect("HttpErrorPage.aspx");
                 }
                 txtdes.Text = ds.Tables[0].Rows[0]["event_desc"].ToString();
                 txtaddr.Text = ds.Tables[0].Rows[0]["address"].ToString();
                 txtlocality.Text = ds.Tables[0].Rows[0]["Area"].ToString();
                 txtlandmark.Text = ds.Tables[0].Rows[0]["land_mark"].ToString();
                 txttim.Text = ds.Tables[0].Rows[0]["event_time"].ToString();
                 string state = ds.Tables[0].Rows[0]["State"].ToString();
                 string city = ds.Tables[0].Rows[0]["City"].ToString();
                 txtpin.Text = ds.Tables[0].Rows[0]["pincode"].ToString();
                 txtcont.Text = ds.Tables[0].Rows[0]["contact_person"].ToString();
                 string Mob = ds.Tables[0].Rows[0]["mob"].ToString();
                 string mobile = Mob.Substring(0, 1);
                 if (mobile == "+")
                 {
                     mob_no = Mob.Substring(3, 10);
                 }
                 else if (mobile == "0")
                 {
                     mob_no = Mob.Substring(1, 10);
                 }
                 txtmob.Text = mob_no;
                 txtlandline.Text = ds.Tables[0].Rows[0]["landphno"].ToString();
                 txtmail.Text = ds.Tables[0].Rows[0]["emailid"].ToString();
                 txtfax.Text = ds.Tables[0].Rows[0]["fax"].ToString();
                 txtweb.Text = ds.Tables[0].Rows[0]["Website"].ToString();
                 // To display the category dropdown with the value existed in database

                 for (int i = 0; i < ddlCategory.Items.Count; i++)
                 {
                     try
                     {
                         if (ddlCategory.Items[i].Text == cat.ToString())
                         {
                             ddlCategory.SelectedValue = ddlCategory.Items[i].Value;
                             break;
                         }
                         else
                         {
                             ddlCategory.SelectedIndex = 0;
                         }
                     }
                     catch (Exception ex)
                     {
                         obj.insert_exception(ex, excep_page);
                         Response.Redirect("HttpErrorPage.aspx");
                     }
                 }
                 fillSubCategories(cat);
                 //To display the Subcategory dropdown with the value existed in database based on category
                 for (int i = 0; i < ddlSubcat.Items.Count; i++)
                 {
                     try
                     {
                         if (ddlSubcat.Items[i].Text == Subcat.ToString())
                         {
                             ddlSubcat.SelectedValue = ddlSubcat.Items[i].Value;
                             break;
                         }
                         else
                         {
                             ddlSubcat.SelectedIndex = 0;
                         }
                     }
                     catch (Exception ex)
                     {
                         obj.insert_exception(ex, excep_page);
                         Response.Redirect("HttpErrorPage.aspx");
                     }
                 }
                 //To display the type of discount
                 for (int i = 0; i < ddltyp.Items.Count; i++)
                 {
                     try
                     {
                         if (ddltyp.Items[i].Text == type.ToString())
                         {
                             ddltyp.SelectedValue = ddltyp.Items[i].Value;
                             break;
                         }
                         else
                         {
                             ddltyp.SelectedIndex = 0;
                         }
                     }
                     catch (Exception ex)
                     {
                         obj.insert_exception(ex, excep_page);
                         Response.Redirect("HttpErrorPage.aspx");
                     }
                 }
                 // To display the state dropdown with the value existed in database
                 for (int i = 0; i < ddlstate.Items.Count; i++)
                 {
                     try
                     {
                         if (ddlstate.Items[i].Text == state.ToString())
                         {
                             ddlstate.SelectedValue = ddlstate.Items[i].Value;
                             break;
                         }
                         else
                         {
                             ddlstate.SelectedIndex = 0;
                         }
                     }
                     catch (Exception ex)
                     {
                         obj.insert_exception(ex, excep_page);
                         Response.Redirect("HttpErrorPage.aspx");
                     }
                 }
                 bindcity(state);
                 // To display the cities dropdown with the value existed in database
                 for (int i = 0; i < ddlcity.Items.Count; i++)
                 {
                     try
                     {
                         if (ddlcity.Items[i].Text == city.ToString())
                         {
                             ddlcity.SelectedValue = ddlcity.Items[i].Value;
                             break;
                         }
                         else
                         {
                             ddlcity.SelectedIndex = 0;
                         }
                     }
                     catch (Exception ex)
                     {
                         obj.insert_exception(ex, excep_page);
                         Response.Redirect("HttpErrorPage.aspx");
                     }
                 }
                 DataSet dscount = new DataSet();
                 dscount = objBd.GetMoreInfo(id);
                 if (!dscount.Tables[0].Rows.Count.Equals(0))
                 {

                     Monday = dscount.Tables[0].Rows[0]["Monday"].ToString();
                     for (int i = 0; i < ddlMonday.Items.Count; i++)
                     {
                         try
                         {
                             if (ddlMonday.Items[i].Value == Monday.ToString())
                             {
                                 ddlMonday.SelectedValue = ddlMonday.Items[i].Value;
                                 if (Monday == "Time Duration")
                                 {
                                     trMonDur.Visible = true;
                                     trLstMon.Visible = true;
                                 }
                                 else
                                 {
                                     trMonDur.Visible = false;
                                     trLstMon.Visible = false;
                                 }
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
                                 if (Tuesday == "Time Duration")
                                 {
                                     trTuesDur.Visible = true;
                                     trLstTues.Visible = true;
                                 }
                                 else
                                 {
                                     trTuesDur.Visible = false;
                                     trLstTues.Visible = false;
                                 }
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
                                 if (Wednesday == "Time Duration")
                                 {
                                     trWedDur.Visible = true;
                                     trLstWed.Visible = true;
                                 }
                                 else
                                 {
                                     trWedDur.Visible = false;
                                     trLstWed.Visible = false;
                                 }
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
                                 if (Thursday == "Time Duration")
                                 {
                                     trThursDur.Visible = true;
                                     trLstThurs.Visible = true;
                                 }
                                 else
                                 {
                                     trThursDur.Visible = false;
                                     trLstThurs.Visible = false;
                                 }
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
                                 if (Friday == "Time Duration")
                                 {
                                     trFriDur.Visible = true;
                                     trLstFri.Visible = true;
                                 }
                                 else
                                 {
                                     trFriDur.Visible = false;
                                     trLstFri.Visible = false;
                                 }
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
                                 if (Satday == "Time Duration")
                                 {
                                     trSatDur.Visible = true;
                                     trLstSatur.Visible = true;
                                 }
                                 else
                                 {
                                     trSatDur.Visible = false;
                                     trLstSatur.Visible = false;
                                 }
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
                                 if (Sunday == "Time Duration")
                                 {
                                     trSunDur.Visible = true;
                                     trLstSun.Visible = true;
                                 }
                                 else
                                 {
                                     trSunDur.Visible = false;
                                     trLstSun.Visible = false;
                                 }
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
                             for (int i = 0; i < modecheck.Items.Count; i++)
                             {
                                 if (modecheck.Items[i].Value == arrstrr)
                                 {
                                     modecheck.Items[i].Selected = true;
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
                     else
                     {
                         trMonDur.Visible = false;
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
                     else
                     {
                         trTuesDur.Visible = false;
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
                     else
                     {
                         trWedDur.Visible = false;
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
                     else
                     {
                         trThursDur.Visible = false;
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
                     else
                     {
                         trFriDur.Visible = false;
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
                     else
                     {
                         trSatDur.Visible = false;
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
                     else
                     {
                         trSunDur.Visible = false;
                     }
                     AdtInfo = dscount.Tables[0].Rows[0]["AdditionalInfo"].ToString();
                     txtAdtInfo.Text = AdtInfo;
                     string year = dscount.Tables[0].Rows[0]["Year_Established"].ToString();

                     for (int i = 0; i < ddlyearestblish.Items.Count; i++)
                     {
                         try
                         {
                             if (ddlyearestblish.Items[i].Text == year.ToString())
                             {
                                 ddlyearestblish.SelectedValue = ddlyearestblish.Items[i].Value;
                                 break;
                             }
                             else
                             {
                                 ddlyearestblish.SelectedIndex = 0;
                             }
                         }
                         catch (Exception ex)
                         {
                             obj.insert_exception(ex, excep_page);
                             Response.Redirect("HttpErrorPage.aspx");
                         }
                     }

                     txtprofass.Text = dscount.Tables[0].Rows[0]["prof_Assoc"].ToString();
                     txtcertificate.Text = dscount.Tables[0].Rows[0]["certifications"].ToString();
                     txtemp.Text = dscount.Tables[0].Rows[0]["No_of_employees"].ToString();
                 }
                 else
                 {
                     trMonDur.Visible = false;
                     trLstMon.Visible = false;
                     trTuesDur.Visible = false;
                     trLstTues.Visible = false;
                     trWedDur.Visible = false;
                     trLstWed.Visible = false;
                     trThursDur.Visible = false;
                     trLstThurs.Visible = false;
                     trFriDur.Visible = false;
                     trLstFri.Visible = false;
                     trSatDur.Visible = false;
                     trLstSatur.Visible = false;
                     trSunDur.Visible = false;
                     trLstSun.Visible = false;
                 }
             }
         }
         catch (Exception ex)
         {
             obj.insert_exception(ex, excep_page);
             Response.Redirect("HttpErrorPage.aspx");
         }
        
     }
     /// To bind the category dropdownlist from the database 
     public void  BindCatDropdown()
     {
         try
         {
             string Module_Name = "Category";
             DataSet dsCategory = new DataSet();
             dsCategory = objBd.getDiscountCate(Module_Name);
             ddlCategory.DataSource = dsCategory;
             ddlCategory.DataTextField = "Category";
             ddlCategory.DataValueField = "Category";
             ddlCategory.DataBind();
             ddlCategory.Items.Insert(0, "Select Category");
         }
         catch (Exception ex)
         {
             obj.insert_exception(ex, excep_page);
             Response.Redirect("HttpErrorPage.aspx");
         }
     }
    //To bind the Sub category dropdownlist from the database based on category 
     public void fillSubCategories(string Category_Name)
     {
         try
         {
             DataSet dsSubCat = new DataSet();
             dsSubCat = objBd.GetDiscountSubCate(Category_Name);
             ddlSubcat.DataSource = dsSubCat;
             ddlSubcat.DataValueField = "cat";
             ddlSubcat.DataTextField = "cat";
             ddlSubcat.DataBind();
             ddlSubcat.Items.Insert(0, "Select  SubCategory");
         }
         catch (Exception ex)
         {
             obj.insert_exception(ex, excep_page);
             Response.Redirect("HttpErrorPage.aspx");
         }
     }
    /// <summary>
    /// To bind the state dropdownlist from the database 
    protected void ddlstate_selectedindexchanged(object sender, EventArgs e)
    {
        try
        {
            string statename = ddlstate.SelectedItem.ToString();
            bindcity(statename);
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    /// <summary>
    /// To bind the cities dropdownlist from the database 
    /// </summary>
    /// <param name="catg"></param>
    protected void bindcity(string statename)
    {
        try
        {
            DataSet dsCities = new DataSet();
            dsCities = objBd.GetDiscountCities(statename);
            ddlcity.DataSource = dsCities;
            ddlcity.DataTextField = "city_name";
            ddlcity.DataValueField = "city_name";
            ddlcity.DataBind();
            ddlcity.Items.Insert(0, "select");
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
            
    }
    protected void btncancel_Click(object sender, ImageClickEventArgs e)
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
    /// <summary>
    /// To store the updated values into the database
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnupdate_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            //con.Open();
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
                    if ((txtmob.Text != "" || txtlandline.Text != "") && txtvid.Text != "")
                    {
                        string userid = Convert.ToString(Session["USERID"]);
                        int id = Convert.ToInt32(Page.RouteData.Values["id"]);
                        DateTime pdate = DateTime.Now.Date;
                        SqlCommand cmd = new SqlCommand("updatediscount", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@module", SqlDbType.NVarChar).Value = "Discounts";
                        cmd.Parameters.AddWithValue("@UserLoginId", SqlDbType.NVarChar).Value = userid;
                        cmd.Parameters.AddWithValue("@id", SqlDbType.Int).Value = id;
                        cmd.Parameters.AddWithValue("@Category", SqlDbType.NVarChar).Value = ddlCategory.SelectedItem.Text;
                        cmd.Parameters.AddWithValue("@SubCategory", SqlDbType.NVarChar).Value = ddlSubcat.SelectedItem.Text;
                        cmd.Parameters.AddWithValue("@evedi_DurationType", ddltyp.SelectedItem.ToString());
                        if (ddltyp.SelectedIndex == 1)
                        {
                            txtone.Visible = true;
                            txtmulti.Visible = false;
                            cmd.Parameters.AddWithValue("@event_startdate", txtone.Text);
                            cmd.Parameters.AddWithValue("@event_enddate", DBNull.Value);


                        }
                        else
                        {
                            txtone.Visible = true;
                            txtmulti.Visible = false;
                            cmd.Parameters.AddWithValue("@event_startdate", txtone.Text);
                            cmd.Parameters.AddWithValue("@event_enddate", txtmulti.Text);
                        }
                        cmd.Parameters.AddWithValue("@State", SqlDbType.NVarChar).Value = ddlstate.SelectedItem.Text;
                        cmd.Parameters.AddWithValue("@City", SqlDbType.NVarChar).Value = ddlcity.SelectedItem.Text;
                        cmd.Parameters.AddWithValue("@Area", SqlDbType.NVarChar).Value = txtlocality.Text;
                        cmd.Parameters.AddWithValue("@company_name", SqlDbType.NVarChar).Value = txtcname.Text;
                        cmd.Parameters.AddWithValue("@event_desc", SqlDbType.NVarChar).Value = txtdes.Text;
                        cmd.Parameters.AddWithValue("@event_time", SqlDbType.NVarChar).Value = txttim.Text;
                        cmd.Parameters.AddWithValue("@address", SqlDbType.NVarChar).Value = txtaddr.Text;
                        cmd.Parameters.AddWithValue("@land_mark", SqlDbType.NVarChar).Value = txtlandmark.Text;
                        cmd.Parameters.AddWithValue("@mob", SqlDbType.NVarChar).Value = txtcode.Text + txtmob.Text;
                        cmd.Parameters.AddWithValue("@landphno", SqlDbType.NVarChar).Value = txtlandline.Text;
                        cmd.Parameters.AddWithValue("@fax", SqlDbType.NVarChar).Value = txtfax.Text;
                        cmd.Parameters.AddWithValue("@Website", SqlDbType.NVarChar).Value = txtweb.Text;
                        cmd.Parameters.AddWithValue("@ApprovedStatus", SqlDbType.Int).Value = 0;
                        cmd.Parameters.AddWithValue("@contact_person", SqlDbType.NVarChar).Value = txtcont.Text;
                        cmd.Parameters.AddWithValue("@emailid", SqlDbType.NVarChar).Value = txtmail.Text;
                        cmd.Parameters.AddWithValue("@pincode", SqlDbType.NVarChar).Value = txtpin.Text;
                        cmd.Parameters.AddWithValue("@postdate", SqlDbType.DateTime).Value = pdate;
                        cmd.Parameters.AddWithValue("@Status", SqlDbType.Int).Value = 3;
                        cmd.Parameters.AddWithValue("@By_EmailId", userid);
                        cmd.Parameters.AddWithValue("@Date", pdate);
                        cmd.Parameters.AddWithValue("@DataId", id);
                        try
                        {
                            con.Open();
                            cmd.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            obj.insert_exception(ex, excep_page);
                            Response.Redirect("HttpErrorPage.aspx");
                        }
                        finally
                        {
                            cmd.Dispose();
                            if (con != null)
                            {
                                con.Close();
                            }

                        }
                       // SendMail(userid);
                        DataSet dsmoreinfo = new DataSet();
                        dsmoreinfo = objBd.GetCountMoreInfo(id);
                        int count = Convert.ToInt32(dsmoreinfo.Tables[0].Rows[0]["count"].ToString());
                        if (count != 0)
                        {
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
                            data.pId = Convert.ToInt32(id);
                            data.dPayment = Payment;
                            data.dAdtInfo = txtAdtInfo.Text;
                            data.dYearEstab = ddlyearestblish.SelectedValue;
                            data.dProf_Accosi = txtprofass.Text;
                            data.dcertification = txtcertificate.Text;
                            data.dNoofEmp = txtemp.Text;
                            data.MoreInfo_Update(data.dMonday, data.dMon_Dur, data.dTuesday, data.dTues_Dur, data.dWednesday, data.dWed_Dur,
                                                data.dThursday, data.dThurs_Dur, data.dFriday, data.dFri_Dur, data.dSaturday, data.dSatur_Dur,
                                                data.dSunday, data.dSun_Dur, data.pId, data.dPayment, data.dAdtInfo, data.dYearEstab, data.dProf_Accosi,
                                                data.dcertification, data.dNoofEmp);
                            SendMail(userid);
                            strScript = "alert('Your Discount and Additional Information is Updated Successfully');location.replace('ViewDiscount-" + id + "');";//view_BriefDiscounts.aspx?id=" + id + "
                            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                        }
                        else
                        {
                            data.dMonday = ddlMonday.SelectedItem.Text;
                            data.dMon_Dur = MonDur;
                            data.dTuesday = ddlTuesday.SelectedItem.Text;
                            data.dTues_Dur = TuesDur;
                            data.dWednesday = ddlWednesday.SelectedItem.Text;
                            data.dWed_Dur = WedDur;
                            data.dThursday = ddlThursday.SelectedItem.Text;
                            data.dThurs_Dur = ThursDur;
                            data.dFriday = ddlFriday.SelectedItem.Text;
                            data.dFri_Dur = FriDur;
                            data.dSaturday = ddlSaturday.SelectedItem.Text;
                            data.dSatur_Dur = SatDur;
                            data.dSunday = ddlSunday.SelectedItem.Text;
                            data.dSun_Dur = SunDur;
                            data.pId = Convert.ToInt32(id);
                            data.dPayment = Payment;
                            data.dAdtInfo = txtAdtInfo.Text;
                            data.dcertification = txtcertificate.Text;
                            data.dNoofEmp = txtemp.Text;
                            data.dProf_Accosi = txtprofass.Text;
                            data.dYearEstab = ddlyearestblish.SelectedItem.Text;
                            data.MoreInfo_Insert(data.dMonday, data.dMon_Dur, data.dTuesday, data.dTues_Dur, data.dWednesday, data.dWed_Dur,
                                                 data.dThursday, data.dThurs_Dur, data.dFriday, data.dFri_Dur, data.dSaturday, data.dSatur_Dur,
                                                 data.dSunday, data.dSun_Dur, data.pId, data.dPayment, data.dAdtInfo, data.dYearEstab,
                                                 data.dProf_Accosi, data.dcertification, data.dNoofEmp);

                            string strScript = "";
                            strScript = "alert('Your Additional Information is Posted Successfully');location.replace('ViewDiscount-" + id + "');";
                            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);

                        }
                        SendMail(userid);
                        //con.Close();
                    }
                    else
                    {
                        strScript = "alert('Please select mobile number or landline number')";
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
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
    protected void btnLogochange_Click(object sender, EventArgs e)
    {
        try
        {
            truploadLogo.Visible = true;
            trDisplayLogo.Visible = false;
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    /// <summary>
    /// To send the mail reporting the updation of discount done by autheticated user 
    /// </summary>
    /// <param name="userid"></param>
    public void SendMail(string userid)
    {
        try
        {
            string Msg = "";
            MailMessage mm = new MailMessage();
            mm.From = new MailAddress("info@justcalluz.com");
            //mm.To = "test_indus@yahoo.com";
            mm.To.Add(userid);
            Msg += "You have successfully updated the Discount " + "<br>For further details please visit our site www.justcalluz.com or call on +9166136226." +
                        "<br><br>Warm Regards," +
                        "<br> Team JustCalluz"; ;
            mm.Subject = "Intimation about updated Discount";
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
    //protected void view_Click(object sender, ImageClickEventArgs e)
    //{
    //    try
    //    {
    //        Response.RedirectToRoute("ViewDiscount");//"view_discounts.aspx",false
    //    }
    //    catch (Exception ex)
    //    {
    //        obj.insert_exception(ex, excep_page);
    //        Response.Redirect("HttpErrorPage.aspx");
    //    }
    //}
    protected void btnUploadPhotos_Click(object sender, EventArgs e)
    {
        try
        {
            int id = Convert.ToInt32(Page.RouteData.Values["id"]);
            //con.Open();
            DataSet dsphoto = new DataSet();
            dsphoto = objBd.GetPhotoCount(id);
            int count = Convert.ToInt32(dsphoto.Tables[0].Rows[0]["count"]);
            if (count < 5)
            {
                SqlCommand cmd = new SqlCommand("InsertPhotos", con);
                cmd.CommandType = CommandType.StoredProcedure;
                if (uploadPhotos.HasFile)
                {
                    string imgPhotoName = System.IO.Path.GetFileName(uploadPhotos.PostedFile.FileName);
                    dsphoto = data.getPhotoName(imgPhotoName);
                    if (!dsphoto.Tables[0].Rows.Count.Equals(0))
                    {
                        strScript = "alert('Image name already existed please change Image Name');";
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                    }
                    else
                    {
                        if (uploadPhotos.PostedFile.ContentLength <= 100000)
                        {
                            photoname = Path.GetFileName(uploadPhotos.PostedFile.FileName);
                            photopath = uploadPhotos.PostedFile.ContentType;
                            uploadPhotos.PostedFile.SaveAs(Server.MapPath("~/Photos/" + photoname));
                            using (System.Drawing.Image Img = System.Drawing.Image.FromFile(Server.MapPath("~/Photos/" + photoname)))
                            {
                                if (Img.Width <= 250 && Img.Height <= 300)
                                {
                                    cmd.Parameters.AddWithValue("@PhotoName", photoname);
                                    cmd.Parameters.AddWithValue("@PhotoContType", photopath);
                                    cmd.Parameters.AddWithValue("@dId", id);
                                    cmd.Parameters.AddWithValue("@Caption", DBNull.Value);
                                    try
                                    {
                                        con.Open();
                                        cmd.ExecuteNonQuery();
                                    }
                                    catch (Exception ex)
                                    {
                                        obj.insert_exception(ex, excep_page);
                                        Response.Redirect("HttpErrorPage.aspx");
                                    }
                                    finally
                                    {
                                        cmd.Dispose();
                                        if (con !=null)
                                        {
                                            con.Close();
                                        }
                                    }
                                }
                                else
                                {
                                    strScript = "alert('sorry! Specified Photo cannot be uploaded , make sure that width=250 and height=300.');";
                                    Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                                }
                            }
                        }
                        else
                        {
                            strScript = "alert('sorry! Secified Photo cannot be uploaded , make sure that size is lessthan 100kb.');";
                            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                        }
                    }
                }
                else
                {
                    strScript = "alert('Please browse an Image');";
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                }
            }
            else
            {
                strScript = "alert('sorry! You can upload only five photos . so , kindly delete some existing photos inorder to upload new photos');";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
            }
            strScript = "alert('Photo is uploaded successfully');location.replace('EditDiscount-" + id + "-discounts');";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
            //con.Close();
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void lnkdelphoto(object sender, CommandEventArgs e)
    {
        try
        {
            string strScripts;
            DataSet dsGetPhoto = new DataSet();
            string PhotoName;
            int id = Convert.ToInt32(e.CommandArgument.ToString());
            int id1 = Convert.ToInt32(Page.RouteData.Values["id"]);
            dsGetPhoto = data.getPhotos(id);
            if (!dsGetPhoto.Tables[0].Rows.Count.Equals(0))
            {
                PhotoName = dsGetPhoto.Tables[0].Rows[0]["PhotoName"].ToString();
                string dir = Server.MapPath("Photos/");
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
            strScripts = "alert('Photo is deleted successfully');location.replace('EditDiscount-" + id1 + "-discounts');";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScripts, true);
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void lnkMonTimings_Click(object sender, EventArgs e)
    {
        try
        {
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
            ltrMonTime.Visible = true;
            trMonDur.Visible = true;
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
            ltrTuesTime.Visible = true;
            trTuesDur.Visible = true;
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
            ltrWedTime.Visible = true;
            trWedDur.Visible = true;
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
            ltrThursTime.Visible = true;
            trThursDur.Visible = true;
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
            ltrFriTime.Visible = true;
            trFriDur.Visible = true;
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
            ltrSaturTime.Visible = true;
            trSatDur.Visible = true;
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
            trSunDur.Visible = true;
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
    protected void lnkBtnClearSuntimings_Click(object sender, EventArgs e)
    {
        lblSunTime.Text = "";
        ltrSunTime.Text = "";
        trLstSun.Visible = false;
    }
    protected void lnkBtnClearSatTimings_Click(object sender, EventArgs e)
    {
        lblSaturTime.Text = "";
        ltrSaturTime.Text = "";
        trLstSatur.Visible = false;
    }
    protected void lnkBtnClearFriTimings_Click(object sender, EventArgs e)
    {
        lblFriTime.Text = "";
        ltrFriTime.Text = "";
        trLstFri.Visible = false;
    }
    protected void lnkBtnClearThursTimings_Click(object sender, EventArgs e)
    {
        lblThursTime.Text = "";
        ltrThursTime.Text = "";
        trLstThurs.Visible = false;
    }
    protected void lnkBtnClearWedTimings_Click(object sender, EventArgs e)
    {
        lblWedTime.Text = "";
        ltrWedTime.Text = "";
        trLstWed.Visible = false;
    }
    protected void lnkBtnClearTuesTimings_Click(object sender, EventArgs e)
    {
        lblTuesTime.Text = "";
        ltrTuesTime.Text = "";
        trLstTues.Visible = false;
    }
    protected void lnkBtnClearMonTimings_Click(object sender, EventArgs e)
    {
        lblMonTime.Text = "";
        ltrMonTime.Text = "";
        trLstMon.Visible = false;
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

            }
            else
            {
                trSunDur.Visible = false;
                trLstSun.Visible = false;
                SunDur = "";
            }
            //for (int i = 0; i < lstBoxPayment.Items.Count; i++)      // Select Multiple items from Listbox
            //{
            //    if (lstBoxPayment.Items[i].Selected == true)
            //    {
            //        Payment += lstBoxPayment.Items[i].Text + ",";
            //    }
            //}
            for (int i = 0; i < modecheck.Items.Count; i++)
            {
                if (modecheck.Items[i].Selected == true)
                {
                    Payment += modecheck.Items[i].Text + ",";
                }

            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void ddlMonday_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {

            if (ddlMonday.SelectedItem.Text == "Time Duration")
            {
                trMonDur.Visible = true;
            }
            else
            {
                trMonDur.Visible = false;
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void ddlTuesday_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (ddlTuesday.SelectedItem.Text == "Time Duration")
            {
                trTuesDur.Visible = true;

            }
            else
            {
                trTuesDur.Visible = false;
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void ddlWednesday_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (ddlWednesday.SelectedItem.Text == "Time Duration")
            {
                trWedDur.Visible = true;
            }
            else
            {
                trWedDur.Visible = false;
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
      
    }
    protected void ddlThursday_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (ddlThursday.SelectedItem.Text == "Time Duration")
            {
                trThursDur.Visible = true;
            }
            else
            {
                trThursDur.Visible = false;
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void ddlFriday_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (ddlFriday.SelectedItem.Text == "Time Duration")
            {
                trFriDur.Visible = true;
            }
            else
            {
                trFriDur.Visible = false;
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void ddlSaturday_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (ddlSaturday.SelectedItem.Text == "Time Duration")
            {
                trSatDur.Visible = true;
            }
            else
            {
                trSatDur.Visible = false;
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void ddlSunday_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (ddlSunday.SelectedItem.Text == "Time Duration")
            {
                trSunDur.Visible = true;
            }
            else
            {
                trSunDur.Visible = false;
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    [System.Web.Script.Services.ScriptMethod()]
    [System.Web.Services.WebMethod]
    public static List<string> Getcities(string prefixText)
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["connectionstring"]);
        con.Open();
        SqlCommand cmd = new SqlCommand("select * from cities where city_name like @Name+'%'", con);
        cmd.Parameters.AddWithValue("@Name", prefixText);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        da.Fill(dt);
        List<string> citynames = new List<string>();
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            citynames.Add(dt.Rows[i][1].ToString());
        }
        return citynames;
    }

    protected void ddlCategory_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (ddlCategory.SelectedIndex != 0)
            {
                Categoty_Name = Convert.ToString(ddlCategory.SelectedValue);
                fillSubCategories(Categoty_Name);
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void ddltyp_selectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (ddltyp.SelectedIndex == 1)
            {
                txtone.Visible = true;
                txtmulti.Visible = false;
            }
            else
            {
                txtone.Visible = true;
                txtmulti.Visible = true;
            }
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
            string userid = Convert.ToString(Session["USERID"]);

            string id;
            DataSet dsUserId = new DataSet();
            dsUserId = objBd.GetUserId(userid);
            id = dsUserId.Tables[0].Rows[0]["id"].ToString();

            SqlCommand cmd = new SqlCommand("UpdateLogoSP", con);
            cmd.CommandType = CommandType.StoredProcedure;
            if (uploadLogo.HasFile)
            {
                imgLogoName = Path.GetFileName(uploadLogo.PostedFile.FileName);
                DataSet dsLogo = new DataSet();
                dsLogo = data.getLogoName(imgLogoName);
                if (!dsLogo.Tables[0].Rows.Count.Equals(0))
                {
                    strScript = "alert('Image name already existed please change Image Name');";
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                }
                else
                {
                    if (uploadLogo.PostedFile.ContentLength <= 30000)
                    {
                        imgLogoName = Path.GetFileName(uploadLogo.PostedFile.FileName);
                        ImgLogoContentType = uploadLogo.PostedFile.ContentType;
                        uploadLogo.PostedFile.SaveAs(Server.MapPath("~/Logos/" + imgLogoName));
                        using (System.Drawing.Image Img = System.Drawing.Image.FromFile(Server.MapPath("~/Logos/" + imgLogoName)))
                        {

                            if (Img.Width <= 100 && Img.Height <= 75)
                            {
                                cmd.Parameters.AddWithValue("@ImgName", imgLogoName);
                                cmd.Parameters.AddWithValue("@ImgContType", ImgLogoContentType);
                                cmd.Parameters.AddWithValue("@dId", id);
                                try
                                {
                                    con.Open();
                                    cmd.ExecuteNonQuery();
                                    strScript = "alert('Logo is uploaded Successfully');location.replace('EditDiscount-" + id + "-discounts');";
                                    Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                                    uploadLogo.Enabled = false;
                                }
                                catch (Exception ex)
                                {
                                    obj.insert_exception(ex, excep_page);
                                    Response.Redirect("HttpErrorPage.aspx");
                                }
                                finally
                                {
                                    cmd.Dispose();
                                    if (con != null)
                                    {
                                        con.Close();
                                    }
                                }
                            }
                            else
                            {
                                strScript = "alert('sorry! Secified Logo cannot be uploaded , make sure that width=100 and height=75.');";
                                Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                            }
                        }
                    }
                    else
                    {
                        strScript = "alert('sorry! Secified Logo cannot be uploaded , make sure that size is lessthan 30kb.');";
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                    }
                }

            }
            else
            {
                cmd.Parameters.AddWithValue("@ImgName", SqlDbType.NVarChar).Value = 0;
                cmd.Parameters.AddWithValue("@ImgContType", SqlDbType.NVarChar).Value = 0;
                cmd.Parameters.AddWithValue("@dId", SqlDbType.NVarChar).Value = 0;
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    obj.insert_exception(ex, excep_page);
                    Response.Redirect("HttpErrorPage.aspx");
                }
                finally
                {
                    cmd.Dispose();
                    if (con != null)
                    {
                        con.Close();
                    }
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
