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
using System.IO;
/// <summary>
/// Class to update posted data
/// </summary>
public partial class admin_Admin_EditCatData : System.Web.UI.Page
{
    public string swfFileName;
    string Str;
    bool t;
    DataCS data = new DataCS();
    //Making Connection
    SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    SqlDataReader dr;
    DataSet dsGetLogo = new DataSet();
    DataSet dsGetPhoto = new DataSet();
    DataSet dsvideo = new DataSet();
    //Declaration of variables
    Int16 Did = 0;
    string Module = string.Empty;
    string Cat = string.Empty;
    string SubCat = string.Empty;
    string OtherSubCat = string.Empty;
    string State = string.Empty;
    string City = string.Empty;
    string Area = string.Empty;
    string CompanyName = string.Empty;
    string JobIndustry = string.Empty;
    string JobFunArea = string.Empty;
    string JobRole = string.Empty;
    string JobQualification = string.Empty;
    string Age = string.Empty;
    string JobExp = string.Empty;
    string JobSal = string.Empty;
    string JobDesc = string.Empty;
    string JobSkills = string.Empty;
    string JobExpiry = string.Empty;
    string JCDCompanyProfile = string.Empty;
    string EveName = string.Empty;
    string EvePlace = string.Empty;
    string EveDiStartDate;
    string EveDiEndDate;
    string EveDiDetails = string.Empty;
    string EveDiTime = string.Empty;
    string Address = string.Empty;
    string LandMark = string.Empty;
    string Pincode = string.Empty;
    string ContactPerson = string.Empty;
    string EmailId = string.Empty;
    string Mobile = string.Empty;
    string Phone = string.Empty;
    string Fax = string.Empty;
    string Website = string.Empty;
    DateTime StartDate;
    DateTime EndDate;
    DateTime JobExpiryDate;
    string EventDurationType;
    string edStartdate;
    string edEnddate;
    string jexpiry;
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
    string strScript = "";
    char[] separatorcomma = new char[] { ',' };
    char[] separatorspace = new char[] { ' ' };
    string imgLogoName;
    string ImgLogoContentType;
    string imgPhotoName;
    string imgName;
    string imgPhotoContentType;
    string VideoName;
    string VideoContentType;
    string strScripts = "";
    string UserId;
    string Caption;
    string mob_no = string.Empty;
    /// <summary>
    /// Executes whenever page loads
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Page_Load(object sender, EventArgs e)
    {
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
        rangevalStartDate.ErrorMessage = " Please select " + System.DateTime.Now.ToShortDateString() + " Onwards and till " + System.DateTime.Now.AddDays(90).ToShortDateString();
        rangevalEndDate.ErrorMessage = " Please select " + System.DateTime.Now.ToShortDateString() + " Onwards and till " + System.DateTime.Now.AddDays(365).ToShortDateString();
        rangevalStartDate.MinimumValue = System.DateTime.Now.ToShortDateString();
        rangevalStartDate.MaximumValue = System.DateTime.Now.AddDays(90).ToShortDateString();
        rangevalEndDate.MinimumValue = System.DateTime.Now.ToShortDateString();
        rangevalEndDate.MaximumValue = System.DateTime.Now.AddDays(365).ToShortDateString();
        rangeValJobExpire.MinimumValue = System.DateTime.Now.ToShortDateString();
        rangeValJobExpire.MaximumValue = System.DateTime.Now.AddDays(90).ToShortDateString();
        rangeValJobExpire.ErrorMessage = " Please select " + System.DateTime.Now.ToShortDateString() + " Onwards and till " + System.DateTime.Now.AddDays(90).ToShortDateString();
        if (Request.QueryString["did"] != null)
        {
            Did = Convert.ToInt16(Request.QueryString["did"]);            
        }
        // To execute the code without postbacking the page values
        if (!IsPostBack)
        {
            string mod_no = string.Empty;
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
            DataSet dsCyear = new DataSet();
            dsCyear = data.GetCurrentYear();
            string currentyear = "";
           
            if (!dsCyear.Tables[0].Rows.Count.Equals(0))
            {
                currentyear = dsCyear.Tables[0].Rows[0]["cyear"].ToString();
            }
            DataSet dsYear = new DataSet();
            dsYear = data.GetEstablishedyear(currentyear);
            if (!dsYear.Tables[0].Rows.Count.Equals(0))
            {
                data.FillCompEstablishYr(ddlYearEstab);
            }
            else
            {
                data.InsertCurrentYear(currentyear);
                data.FillCompEstablishYr(ddlYearEstab);
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
            //To bind Modules
            string BPost = Convert.ToString(Session["BPost"]);
            if (BPost == "1")
            {
                ddlModule.Items.Add("Category");

            }

            string B2BPost = Convert.ToString(Session["B2BPost"]);
            if (B2BPost == "1")
            {
                ddlModule.Items.Add("B2B Category");

            }
            string EvePost = Convert.ToString(Session["EvePost"]);
            if (EvePost == "1")
            {
                ddlModule.Items.Add("Events");

            }
            string DisPost = Convert.ToString(Session["DisPost"]);
            if (DisPost == "1")
            {
                ddlModule.Items.Add("Discounts");

            }
            string JobPost = Convert.ToString(Session["JobPost"]);
            if (JobPost == "1")
            {
                ddlModule.Items.Add("Jobs");

            }
            string LSPost = Convert.ToString(Session["LSPost"]);
            if (LSPost == "1")
            {
                ddlModule.Items.Add("LifeStyle");

            }
            string FLPost = Convert.ToString(Session["FLPost"]);
            if (FLPost == "1")
            {
                ddlModule.Items.Add("FreeListing");
            }
            //To fill the States in the form
            data.FillStates(ddlState);
            //To bind Industries
            data.FillIndustry(ddlJIndustry);
            //To bind Funtional Area
            data.FillFunctionalArea(ddlJFunArea);
            //To open connection
            connection.Open();
            string s = "select * from ModulesData where id =" + Did;
            SqlCommand cmd = new SqlCommand(s, connection);
            //To execute the command and kept in sql data reader
            dr = cmd.ExecuteReader();

            // reading data from the data reader and bounding those values to the corresponding fields in the form
            while (dr.Read())
            {
                Module = Convert.ToString(dr["module"]);
                Cat = Convert.ToString(dr["Category"]);
                SubCat = Convert.ToString(dr["SubCategory"]);
                OtherSubCat = Convert.ToString(dr["Other_SubCat"]);
                State = Convert.ToString(dr["State"]);
                City = Convert.ToString(dr["City"]);
                CompanyName = Convert.ToString(dr["company_name"]);
                JobIndustry = Convert.ToString(dr["job_industry"]);
                JobFunArea = Convert.ToString(dr["job_functional_area"]);
                JobRole = Convert.ToString(dr["job_role"]);
                JobQualification = Convert.ToString(dr["job_Qualification"]);
                Age = Convert.ToString(dr["Age"]);
                JobExp = Convert.ToString(dr["job_exp"]);
                JobSal = Convert.ToString(dr["job_sal"]);
                JobDesc = Convert.ToString(dr["job_desc"]);
                JobSkills = Convert.ToString(dr["job_keyskills"]);
                JobExpiry = Convert.ToString(dr["Job_ExpiryDate"]);
                JCDCompanyProfile = Convert.ToString(dr["company_profile"]);
                EveName = Convert.ToString(dr["event_name"]);
                EvePlace = Convert.ToString(dr["event_Place"]);
                EveDiStartDate = Convert.ToString(dr["event_startdate"]);
                EveDiEndDate = Convert.ToString(dr["event_enddate"]);
                EveDiDetails = Convert.ToString(dr["event_desc"]);
                EveDiTime = Convert.ToString(dr["event_time"]);
                Address = Convert.ToString(dr["address"]);
                LandMark = Convert.ToString(dr["land_mark"]);
                Pincode = Convert.ToString(dr["Pincode"]);
                ContactPerson = Convert.ToString(dr["contact_person"]);
                EmailId = Convert.ToString(dr["emailid"]);
                string Mob = Convert.ToString(dr["mob"]);
                if (Mob != "")
                {
                    string mobile = Mob.Substring(0, 1);
                    if (mobile == "+")
                    {
                        int len = Mob.Length;
                        mob_no = Mob.Substring(3, len - 3);
                    }
                    else if (mobile == "0")
                    {
                        int len = Mob.Length;
                        mob_no = Mob.Substring(1, len - 1);
                    }
                    Mobile = mob_no;
                }
                Phone = Convert.ToString(dr["landphno"]);
                Fax = Convert.ToString(dr["fax"]);
                Website = Convert.ToString(dr["Website"]);
                Area = Convert.ToString(dr["Area"]);
                EventDurationType = Convert.ToString(dr["evedi_DurationType"]);
            }
            if (Module == "Events")
            {
                trUploadPhoto.Visible = false;
                trdisplayPhotos.Visible = false;
                trMoreInfo.Visible = false;
            }
            else if (Module == "Discounts")
            {
                trUploadPhoto.Visible = true;
                trdisplayPhotos.Visible = false;
                trMoreInfo.Visible = true;
            }
            else if (Module == "Jobs")
            {
                trUploadPhoto.Visible = false;
                trdisplayPhotos.Visible = false;
                trMoreInfo.Visible = false;
            }
            else
            {
                trUploadPhoto.Visible = true;
                trdisplayPhotos.Visible = true;
                trMoreInfo.Visible = true;
            }
            connection.Close();
            // To bound database Module value to the Module Dropdown list
            for (int i = 0; i < ddlModule.Items.Count; i++)
            {
                if (ddlModule.Items[i].Value == Module.ToString())
                {
                    ddlModule.SelectedValue = ddlModule.Items[i].Value;
                    break;
                }
            }

            //Calling function To fill Categories
            if (Module == "LifeStyle")
            {
                data.FillLifeStyleCategory(ddlCategory);
            }
            else if (Module == "B2B Category")
            {
                //To bind Categories
                data.FillB2BCategory(ddlCategory);
            }
            else if (Module == "FreeListing")
            {
                //To bind Categories
                data.FillFreeListing(ddlCategory);
            }
            else
            {
                fillCategories(Module);
            }
            // To bound database Category value to the Category Dropdown list
            for (int i = 0; i < ddlCategory.Items.Count; i++)
            {
                if (ddlCategory.Items[i].Value == Cat.ToString())
                {
                    ddlCategory.SelectedValue = ddlCategory.Items[i].Value;
                    break;
                }
                else
                {
                    ddlCategory.SelectedIndex = 0;
                }
            }

            if (Module == "LifeStyle")
            {
                string statement = "select * from Lifestyle where Categeory='" + ddlCategory.SelectedValue + "'";
                connection.Open();
                SqlDataAdapter adabrand = new SqlDataAdapter(statement, connection);
                DataSet dsbrand = new DataSet();
                adabrand.Fill(dsbrand);
                connection.Close();
                if (!dsbrand.Tables[0].Rows.Count.Equals(0))
                {
                    trSubCat.Visible = true;
                    fillLifeStyleSubCat(Cat);
                }
                else
                {
                    trSubCat.Visible = false;
                    ddlSubCat.Items.Clear();
                    ddlSubCat.Items.Insert(0, "Select SubCategory");
                }
            }
            else if (Module == "B2B Category")
            {
                string statement1 = "select * from B2BCategories where maincat='" + ddlCategory.SelectedValue + "'";
                connection.Open();
                SqlDataAdapter adab2b = new SqlDataAdapter(statement1, connection);
                DataSet dsb2b = new DataSet();
                adab2b.Fill(dsb2b);
                connection.Close();
                if (!dsb2b.Tables[0].Rows.Count.Equals(0))
                {

                    trSubCat.Visible = true;
                    fillB2BSubCategories(Cat);
                }
                else
                {
                    trSubCat.Visible = false;
                    ddlSubCat.Items.Clear();
                    ddlSubCat.Items.Insert(0, "Select SubCategory");
                }
            }
            else if (Module == "FreeListing")
            {
                lblCompanyname.Text = "Title";
                lblCompProfile.Text = "Description";               
                string statement0 = "select * from FreeListing_SubCat where Cat='" + ddlCategory.SelectedValue + "'";
                connection.Open();
                SqlDataAdapter adFL = new SqlDataAdapter(statement0, connection);
                DataSet dsFL = new DataSet();
                adFL.Fill(dsFL);
                connection.Close();
                if (!dsFL.Tables[0].Rows.Count.Equals(0))
                {
                    trSubCat.Visible = true;
                    fillFLSubCategories(Cat);
                }
                else
                {
                    trSubCat.Visible = false;
                    ddlSubCat.Items.Clear();
                    ddlSubCat.Items.Insert(0, "Select SubCategory");
                }
            }
            else
            {

                string statement2 = "select * from subcatageory where maincat='" + ddlCategory.SelectedValue + "'";
                connection.Open();
                SqlDataAdapter adacat = new SqlDataAdapter(statement2, connection);
                DataSet dscat = new DataSet();
                adacat.Fill(dscat);
                connection.Close();
                if (!dscat.Tables[0].Rows.Count.Equals(0))
                {
                    trSubCat.Visible = true;
                    fillSubCategories(Cat);
                }
                else
                {
                    trSubCat.Visible = false;
                    ddlSubCat.Items.Clear();
                    ddlSubCat.Items.Insert(0, "Select SubCategory");
                }
            }
            //Calling function To fill sub categories
            //fillSubCategories(Categ);
            // To bound database sub category value to the sub category Dropdown list
            for (int i = 0; i < ddlSubCat.Items.Count; i++)
            {
                if (ddlSubCat.Items[i].Value == SubCat.ToString())
                {
                    ddlSubCat.SelectedValue = ddlSubCat.Items[i].Value;
                    break;
                }
                else
                {
                    ddlSubCat.SelectedIndex = 0;
                }
            }
            for (int i = 0; i < ddlDurationType.Items.Count; i++)
            {
                if (ddlDurationType.Items[i].Value == EventDurationType.ToString())
                {
                    ddlDurationType.SelectedValue = ddlDurationType.Items[i].Value;
                    break;
                }
                else
                {
                    ddlDurationType.SelectedIndex = 0;
                }
            }
            // To bound database state value to the State Dropdown list
            for (int i = 0; i < ddlState.Items.Count; i++)
            {
                if (ddlState.Items[i].Value == State.ToString())
                {
                    ddlState.SelectedValue = ddlState.Items[i].Value;
                    break;
                }
            }

            //Calling function To fill cities
            fillCities(State);
            // To bound database city value to the city Dropdown list
            for (int i = 0; i < ddlCity.Items.Count; i++)
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
            string Exp = "";
            // To bound database exp value to the exp Dropdown list
            for (int i = 0; i < ddlExp.Items.Count; i++)
            {
                if (ddlExp.Items[i].Value == JobExp.ToString())
                {
                    ddlExp.SelectedValue = ddlExp.Items[i].Value;
                    break;
                }
                else
                {
                    ddlExp.SelectedValue = "Experience";
                    txtJExp.Text = JobExp.ToString();
                }
            }
            for (int i = 0; i < ddlJIndustry.Items.Count; i++)
            {
                if (ddlJIndustry.Items[i].Value == JobIndustry.ToString())
                {
                    ddlJIndustry.SelectedValue = ddlJIndustry.Items[i].Value;
                    break;
                }
                else
                {
                    ddlJIndustry.SelectedIndex = 0;
                }
            }
            for (int i = 0; i < ddlJFunArea.Items.Count; i++)
            {
                if (ddlJFunArea.Items[i].Value == JobFunArea.ToString())
                {
                    ddlJFunArea.SelectedValue = ddlJFunArea.Items[i].Value;
                    break;
                }
                else
                {
                    ddlJFunArea.SelectedIndex = 0;
                }
            }


            txtOthers.Text = OtherSubCat.ToString();
            txtCompanyname.Text = CompanyName.ToString();
            txtJRole.Text = JobRole.ToString();
            txtJQual.Text = JobQualification.ToString();
            txtAge.Text = Age.ToString();
            txtJSal.Text = JobSal.ToString();
            txtJobDesc.Text = JobDesc.ToString();
            txtJkeyskills.Text = JobSkills.ToString();
            string format = "MM/dd/yyyy";
            if (JobExpiry != "")
            {
                JobExpiryDate = Convert.ToDateTime(JobExpiry);
                jexpiry = JobExpiryDate.ToString(format);
            }
            else
            {
                jexpiry = JobExpiry;
            }
            txtJobExpire.Text = jexpiry.ToString();
            txtCompanyProfile.Text = JCDCompanyProfile.ToString();
            txtEveName.Text = EveName.ToString();
            txtEvePlace.Text = EvePlace.ToString();

            if (EveDiStartDate != "")
            {
                StartDate = Convert.ToDateTime(EveDiStartDate);
                edStartdate = StartDate.ToString(format);
            }
            else
            {
                edStartdate = EveDiStartDate;
            }
            txtEveDiStartDate.Text = edStartdate.ToString();
            if (EveDiEndDate != "")
            {
                EndDate = Convert.ToDateTime(EveDiEndDate);
                edEnddate = EndDate.ToString(format);
            }
            else
            {
                edEnddate = EveDiEndDate;
            }
            txtEveDiEndDate.Text = edEnddate.ToString();
            txtEveDiDesc.Text = EveDiDetails.ToString();
            txtEveDiTime.Text = EveDiTime.ToString();
            txtaddr.Text = Address.ToString();
            txtLandMark.Text = LandMark.ToString();
            txtContPerson.Text = ContactPerson.ToString();
            txtemail.Text = EmailId.ToString();
            txtph.Text = Phone.ToString();
            txtmobile.Text = Mobile.ToString();
            txtFax.Text = Fax.ToString();
            txtWebsite.Text = Website.ToString();
            txtPinCode.Text = Pincode.ToString();
            txtArea.Text = Area.ToString();
            connection.Close();
            string query = "select * from AddMoreInfo where dataid=" + Did;
            SqlDataAdapter adacount = new SqlDataAdapter(query, connection);
            DataSet dscount = new DataSet();
            connection.Open();
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
                    if (ddlMonday.Items[i].Value == Monday.ToString())
                    {
                        ddlMonday.SelectedValue = ddlMonday.Items[i].Value;
                        break;
                    }
                }
                Tuesday = dscount.Tables[0].Rows[0]["Tuesday"].ToString();
                for (int i = 0; i < ddlMonday.Items.Count; i++)
                {
                    if (ddlTuesday.Items[i].Value == Tuesday.ToString())
                    {
                        ddlTuesday.SelectedValue = ddlTuesday.Items[i].Value;
                        break;
                    }
                }
                Wednesday = dscount.Tables[0].Rows[0]["Wednesday"].ToString();
                for (int i = 0; i < ddlMonday.Items.Count; i++)
                {
                    if (ddlWednesday.Items[i].Value == Wednesday.ToString())
                    {
                        ddlWednesday.SelectedValue = ddlWednesday.Items[i].Value;
                        break;
                    }
                }
                Thursday = dscount.Tables[0].Rows[0]["Thursday"].ToString();
                for (int i = 0; i < ddlMonday.Items.Count; i++)
                {
                    if (ddlThursday.Items[i].Value == Thursday.ToString())
                    {
                        ddlThursday.SelectedValue = ddlThursday.Items[i].Value;
                        break;
                    }
                }
                Friday = dscount.Tables[0].Rows[0]["Friday"].ToString();
                for (int i = 0; i < ddlMonday.Items.Count; i++)
                {
                    if (ddlFriday.Items[i].Value == Friday.ToString())
                    {
                        ddlFriday.SelectedValue = ddlFriday.Items[i].Value;
                        break;
                    }
                }
                Satday = dscount.Tables[0].Rows[0]["Saturday"].ToString();
                for (int i = 0; i < ddlMonday.Items.Count; i++)
                {
                    if (ddlSaturday.Items[i].Value == Satday.ToString())
                    {
                        ddlSaturday.SelectedValue = ddlSaturday.Items[i].Value;
                        break;
                    }
                }
                Sunday = dscount.Tables[0].Rows[0]["Sunday"].ToString();
                for (int i = 0; i < ddlMonday.Items.Count; i++)
                {
                    if (ddlSunday.Items[i].Value == Sunday.ToString())
                    {
                        ddlSunday.SelectedValue = ddlSunday.Items[i].Value;
                        break;
                    }
                }
                Payment = dscount.Tables[0].Rows[0]["PaymentMode"].ToString();
                char[] separator = new char[] { ',' };

                string[] strSplitArr = Payment.Split(separator);
                foreach (string arrstrr in strSplitArr)
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
                for (int i = 0; i < ddlNoofEmp.Items.Count; i++)
                {
                    if (ddlNoofEmp.Items[i].Value == noOfEmp.ToString())
                    {
                        ddlNoofEmp.SelectedValue = ddlNoofEmp.Items[i].Value;
                        break;
                    }
                }
                for (int i = 0; i < ddlYearEstab.Items.Count; i++)
                {
                    if (ddlYearEstab.Items[i].Value == YrEst.ToString())
                    {
                        ddlYearEstab.SelectedValue = ddlYearEstab.Items[i].Value;
                        break;
                    }
                }
                txtCertifi.Text = Certification.ToString();
                txtProf_Assoc.Text = Prof_Assoc.ToString();
                txtAdtInfo.Text = AdtInfo.ToString();

                MonDur = dscount.Tables[0].Rows[0]["Mon_Dur"].ToString();
                if (MonDur != "")
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

                TuesDur = dscount.Tables[0].Rows[0]["Tues_Dur"].ToString();
                if (TuesDur != "")
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

                WedDur = dscount.Tables[0].Rows[0]["Wed_Dur"].ToString();
                if (WedDur != "")
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
                ThursDur = dscount.Tables[0].Rows[0]["Thurs_Dur"].ToString();
                if (ThursDur != "")
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
                FriDur = dscount.Tables[0].Rows[0]["Fri_Dur"].ToString();
                if (FriDur != "")
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
                SatDur = dscount.Tables[0].Rows[0]["Satur_Dur"].ToString();
                if (SatDur != "")
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
                SunDur = dscount.Tables[0].Rows[0]["Sun_Dur"].ToString();
                if (SunDur != "")
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
                AdtInfo = dscount.Tables[0].Rows[0]["AdditionalInfo"].ToString();
                txtAdtInfo.Text = AdtInfo;

            }
            else
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
            // To bound Logo
            dsGetLogo = data.getLogo(Did);
            if (!dsGetLogo.Tables[0].Rows.Count.Equals(0))
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
            //To bind Photos
            dsGetPhoto = data.getPhotos(Did);
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
                lblNoPhotos.Text = "No Photos are available.Please Upload";
            }
            //BindVedio();

            if (ddlMonday.SelectedValue == "Time Duration")
            {
                trMonDur.Visible = true;
            }
            else
            {
                trMonDur.Visible = false;
                trLstMon.Visible = false;
            }
            if (ddlTuesday.SelectedValue == "Time Duration")
            {
                trTuesDur.Visible = true;
            }
            else
            {
                trTuesDur.Visible = false;
                trLstTues.Visible = false;
            }
            if (ddlWednesday.SelectedValue == "Time Duration")
            {
                trWedDur.Visible = true;
            }
            else
            {
                trWedDur.Visible = false;
                trLstWed.Visible = false;
            }
            if (ddlThursday.SelectedValue == "Time Duration")
            {
                trThursDur.Visible = true;
            }
            else
            {
                trThursDur.Visible = false;
                trLstThurs.Visible = false;
            }
            if (ddlFriday.SelectedValue == "Time Duration")
            {
                trFriDur.Visible = true;
            }
            else
            {
                trFriDur.Visible = false;
                trLstFri.Visible = false;
            }
            if (ddlSaturday.SelectedValue == "Time Duration")
            {
                trSatDur.Visible = true;
            }
            else
            {
                trSatDur.Visible = false;
                trLstSatur.Visible = false;
            }
            if (ddlSunday.SelectedValue == "Time Duration")
            {
                trSunDur.Visible = true;
            }
            else
            {
                trSunDur.Visible = false;
                trLstSun.Visible = false;
            }

            VisibilityConditions();
            if (ddlExp.SelectedValue == "Experience")
            {
                trExpOther.Visible = true;
            }
            else
            {
                trExpOther.Visible = false;
            }
            if (ddlSubCat.SelectedValue == "Others")
            {

                trOtherSubCat.Visible = true;
            }
            else
            {
                trOtherSubCat.Visible = false;
            }
            if (lblMonTime.Text.Length > 119)
            {
                lnkMonTimings.Enabled = false;
            }
            connection.Close();
        }
    }
    public void VisibilityConditions()
    {
        if (ddlModule.SelectedValue == "Category")
        {
            trCatandJobs.Visible = true;
            trEventName.Visible = false;
            trEventsPlace.Visible = false;
            trEvDiDesc.Visible = false;
            trEvDiDuration.Visible = false;
            trEvDiEventTime.Visible = false;
            trEvDiStartDate.Visible = false;
            trEndDate.Visible = false;
            trExpOther.Visible = false;
            trJobCat.Visible = true;
            trJobsAge.Visible = false;
            trJobsDesc.Visible = false;
            trJobsExperience.Visible = false;
            trJobsExpiry.Visible = false;
            trJobsFA.Visible = false;
            trJobsInd.Visible = false;
            trJobsQual.Visible = false;
            trJobsRole.Visible = false;
            trJobsSal.Visible = false;
            trJobsSkill.Visible = false;
            trMoreInfo.Visible = true;
            trUploadPhoto.Visible = true;
            trdisplayPhotos.Visible = true;
            //trUploadVedio.Visible = true;
            //trVedioDisplay.Visible = true;
            ddlExp.SelectedIndex = 0;
            ddlJIndustry.SelectedIndex = 0;
            ddlJFunArea.SelectedIndex = 0;

        }
        if (ddlModule.SelectedValue == "FreeListing")
        {
            trCatandJobs.Visible = true;
            trEventName.Visible = false;
            trEventsPlace.Visible = false;
            trEvDiDesc.Visible = false;
            trEvDiDuration.Visible = false;
            trEvDiEventTime.Visible = false;
            trEvDiStartDate.Visible = false;
            trEndDate.Visible = false;
            trExpOther.Visible = false;
            trJobCat.Visible = true;
            trJobsAge.Visible = false;
            trJobsDesc.Visible = false;
            trJobsExperience.Visible = false;
            trJobsExpiry.Visible = false;
            trJobsFA.Visible = false;
            trJobsInd.Visible = false;
            trJobsQual.Visible = false;
            trJobsRole.Visible = false;
            trJobsSal.Visible = false;
            trJobsSkill.Visible = false;           
            ddlExp.SelectedIndex = 0;
            ddlJIndustry.SelectedIndex = 0;
            ddlJFunArea.SelectedIndex = 0;
            trMoreInfo.Visible = false;
            trUploadPhoto.Visible = false;
            //trUploadVedio.Visible = false;
            //trVedioDisplay.Visible = false;
            trdisplayPhotos.Visible = false;
        }
        else if (ddlModule.SelectedValue == "Events")
        {
            trCatandJobs.Visible = false;
            trEventName.Visible = true;
            trEventsPlace.Visible = true;
            trEvDiDesc.Visible = true;
            trEvDiDuration.Visible = true;
            trEvDiEventTime.Visible = true;
            trEvDiStartDate.Visible = true;
            trEndDate.Visible = false;

            trExpOther.Visible = false;
            trJobCat.Visible = false;
            trJobsAge.Visible = false;
            trJobsDesc.Visible = false;
            trJobsExperience.Visible = false;
            trJobsExpiry.Visible = false;
            trJobsFA.Visible = false;
            trJobsInd.Visible = false;
            trJobsQual.Visible = false;
            trJobsRole.Visible = false;
            trJobsSal.Visible = false;
            trJobsSkill.Visible = false;
            trMoreInfo.Visible = false;
            trUploadPhoto.Visible = false;
            trdisplayPhotos.Visible = false;
            //trUploadVedio.Visible = false;
            //trVedioDisplay.Visible = false;
            ddlExp.SelectedIndex = 0;
            ddlJIndustry.SelectedIndex = 0;
            ddlJFunArea.SelectedIndex = 0;
        }
        else if (ddlModule.SelectedValue == "Jobs")
        {
            trCatandJobs.Visible = true;
            trEventName.Visible = false;
            trEventsPlace.Visible = false;
            trEvDiDesc.Visible = false;
            trEvDiDuration.Visible = false;
            trEvDiEventTime.Visible = false;
            trEvDiStartDate.Visible = false;
            trEndDate.Visible = false;

            trExpOther.Visible = false;
            trJobCat.Visible = true;
            trJobsAge.Visible = true;
            trJobsDesc.Visible = true;
            trJobsExperience.Visible = true;
            trJobsExpiry.Visible = true;
            trJobsFA.Visible = true;
            trJobsInd.Visible = true;
            trJobsQual.Visible = true;
            trJobsRole.Visible = true;
            trJobsSal.Visible = true;
            trJobsSkill.Visible = true;
            trMoreInfo.Visible = false;
            trUploadPhoto.Visible = false;
            trdisplayPhotos.Visible = false;
            //trUploadVedio.Visible = false;
            //trVedioDisplay.Visible = false;
        }
        else if (ddlModule.SelectedValue == "Discounts")
        {
            trCatandJobs.Visible = true;
            trEventName.Visible = false;
            trEventsPlace.Visible = false;
            trEvDiDesc.Visible = true;
            trEvDiDuration.Visible = true;
            trEvDiEventTime.Visible = true;
            trEvDiStartDate.Visible = true;
            trEndDate.Visible = false;
            trExpOther.Visible = false;
            trJobCat.Visible = true;
            trJobsAge.Visible = false;
            trJobsDesc.Visible = false;
            trJobsExperience.Visible = false;
            trJobsExpiry.Visible = false;
            trJobsFA.Visible = false;
            trJobsInd.Visible = false;
            trJobsQual.Visible = false;
            trJobsRole.Visible = false;
            trJobsSal.Visible = false;
            trJobsSkill.Visible = false;
            trMoreInfo.Visible = true;
            trUploadPhoto.Visible = true;
            trdisplayPhotos.Visible = true;
            //trUploadVedio.Visible = true;
            //trVedioDisplay.Visible = true;
            ddlExp.SelectedIndex = 0;
            ddlJIndustry.SelectedIndex = 0;
            ddlJFunArea.SelectedIndex = 0;
        }
        else if (ddlModule.SelectedValue == "B2B Category")
        {
            trCatandJobs.Visible = true;
            trEventName.Visible = false;
            trEventsPlace.Visible = false;
            trEvDiDesc.Visible = false;
            trEvDiDuration.Visible = false;
            trEvDiEventTime.Visible = false;
            trEvDiStartDate.Visible = false;
            trEndDate.Visible = false;
            trExpOther.Visible = false;
            trJobCat.Visible = true;
            trJobsAge.Visible = false;
            trJobsDesc.Visible = false;
            trJobsExperience.Visible = false;
            trJobsExpiry.Visible = false;
            trJobsFA.Visible = false;
            trJobsInd.Visible = false;
            trJobsQual.Visible = false;
            trJobsRole.Visible = false;
            trJobsSal.Visible = false;
            trJobsSkill.Visible = false;
            trMoreInfo.Visible = true;
            trUploadPhoto.Visible = true;
            trdisplayPhotos.Visible = true;
            //trUploadVedio.Visible = true;
            //trVedioDisplay.Visible = true;
            ddlExp.SelectedIndex = 0;
            ddlJIndustry.SelectedIndex = 0;
            ddlJFunArea.SelectedIndex = 0;
        }        
        else if (ddlModule.SelectedValue == "LifeStyle")
        {
            trCatandJobs.Visible = true;
            trEventName.Visible = false;
            trEventsPlace.Visible = false;
            trEvDiDesc.Visible = false;
            trEvDiDuration.Visible = false;
            trEvDiEventTime.Visible = false;
            trEvDiStartDate.Visible = false;
            trEndDate.Visible = false;
            trExpOther.Visible = false;
            trJobCat.Visible = true;
            trJobsAge.Visible = false;
            trJobsDesc.Visible = false;
            trJobsExperience.Visible = false;
            trJobsExpiry.Visible = false;
            trJobsFA.Visible = false;
            trJobsInd.Visible = false;
            trJobsQual.Visible = false;
            trJobsRole.Visible = false;
            trJobsSal.Visible = false;
            trJobsSkill.Visible = false;
            trMoreInfo.Visible = true;
            trUploadPhoto.Visible = true;
            trdisplayPhotos.Visible = true;
            //trUploadVedio.Visible = true;
            //trVedioDisplay.Visible = true;
            ddlExp.SelectedIndex = 0;
            ddlJIndustry.SelectedIndex = 0;
            ddlJFunArea.SelectedIndex = 0;
        }
    }
    /// <summary>
    /// To fill categories
    /// </summary>
    /// <param name="Module_Name"></param>
    public void fillCategories(string Module_Name)
    {
        try
        {
            string Connection = ConfigurationManager.AppSettings["ConnectionString"];
            SqlConnection oCon = new SqlConnection(Connection);
            if (Module_Name == "Discounts")
            {
                Module_Name = "Category";
            }
            else
            {
            }            
            string s = "(select Category from Categories where Module= '" + Module_Name + "') except (select Category from Categories where Category='Movies') order by Category";
            SqlCommand cmd = new SqlCommand(s, oCon);
            oCon.Open();
            SqlDataAdapter da = new SqlDataAdapter(s, oCon);
            DataSet ds = new DataSet();
            da.Fill(ds, "Category");
            ddlCategory.DataSource = ds.Tables["Category"];
            ddlCategory.DataValueField = "Category";
            ddlCategory.DataTextField = "Category";
            ddlCategory.DataBind();
            ddlCategory.Items.Insert(0, "Select Category");
            oCon.Close();
        }
        //To catch exception
        catch (Exception ex)
        {
            lblMessage.Text = ex.Message.ToString();
        }
    }
    /// <summary>
    /// To fill B2B categories
    /// </summary>
    /// <param name="Categoty_Name"></param>
    public void fillB2BSubCategories(string Categoty_Name)
    {
        try
        {
            string Connection = ConfigurationManager.AppSettings["ConnectionString"];
            SqlConnection oCon = new SqlConnection(Connection);
            string s = "select id,cat from B2BCategories where maincat= '" + Categoty_Name + "' order by cat";
            SqlCommand cmd = new SqlCommand(s, oCon);
            oCon.Open();
            SqlDataAdapter da = new SqlDataAdapter(s, oCon);
            DataSet ds = new DataSet();
            da.Fill(ds, "SubCategory");
            ddlSubCat.DataSource = ds.Tables["SubCategory"];
            ddlSubCat.DataValueField = "cat";
            ddlSubCat.DataTextField = "cat";
            ddlSubCat.DataBind();
            ddlSubCat.Items.Insert(0, "Select Sub Category");
            oCon.Close();
        }
        catch (Exception ex)
        {
            lblMessage.Text = ex.Message.ToString();
        }
    }
    public void fillFLSubCategories(string Categoty_Name)
    {
        try
        {
            string Connection = ConfigurationManager.AppSettings["ConnectionString"];
            SqlConnection oCon = new SqlConnection(Connection);
            string s = "select sid,Sub_Cat from FreeListing_SubCat where Cat= '" + Categoty_Name + "' order by cat";
            SqlCommand cmd = new SqlCommand(s, oCon);
            oCon.Open();
            SqlDataAdapter da = new SqlDataAdapter(s, oCon);
            DataSet ds = new DataSet();
            da.Fill(ds, "SubCategory");
            ddlSubCat.DataSource = ds.Tables["SubCategory"];
            ddlSubCat.DataValueField = "Sub_Cat";
            ddlSubCat.DataTextField = "Sub_Cat";
            ddlSubCat.DataBind();
            ddlSubCat.Items.Insert(0, "Select Sub Category");
            oCon.Close();
        }
        catch (Exception ex)
        {
            lblMessage.Text = ex.Message.ToString();
        }
    }
    /// <summary>
    /// To fill the sub ctegories for the coreesponding category 
    /// </summary>
    /// <param name="Categoty_Name"></param>
    public void fillSubCategories(string Categoty_Name)
    {
        try
        {
            string Connection = ConfigurationManager.AppSettings["ConnectionString"];
            SqlConnection oCon = new SqlConnection(Connection);
            string s = "select id,cat from subcatageory where maincat= '" + Categoty_Name + "'";
            SqlCommand cmd = new SqlCommand(s, oCon);
            oCon.Open();
            SqlDataAdapter da = new SqlDataAdapter(s, oCon);
            DataSet ds = new DataSet();
            da.Fill(ds, "SubCategory");
            ddlSubCat.DataSource = ds.Tables["SubCategory"];
            ddlSubCat.DataValueField = "cat";
            ddlSubCat.DataTextField = "cat";
            ddlSubCat.DataBind();
            ddlSubCat.Items.Insert(0, "Select Sub Category");
            oCon.Close();
        }
        catch (Exception ex)
        {
            lblMessage.Text = ex.Message.ToString();
        }
    }
    /// <summary>
    /// To fill life style sub categories
    /// </summary>
    /// <param name="Categoty_Name"></param>
    public void fillLifeStyleSubCat(string Categoty_Name)
    {
        try
        {
            string Connection = ConfigurationManager.AppSettings["ConnectionString"];
            SqlConnection oCon = new SqlConnection(Connection);
            string s = "select id,SubCategeory from Lifestyle where Categeory= '" + Categoty_Name + "' order by SubCategeory";
            SqlCommand cmd = new SqlCommand(s, oCon);
            oCon.Open();
            SqlDataAdapter da = new SqlDataAdapter(s, oCon);
            DataSet ds = new DataSet();
            da.Fill(ds, "SubCategory");
            ddlSubCat.DataSource = ds.Tables["SubCategory"];
            ddlSubCat.DataValueField = "SubCategeory";
            ddlSubCat.DataTextField = "SubCategeory";
            ddlSubCat.DataBind();
            ddlSubCat.Items.Insert(0, "Select Sub Category");
            oCon.Close();
        }
        catch (Exception ex)
        {
            lblMessage.Text = ex.Message.ToString();
        }
    }
    /// <summary>
    /// To fill Cities
    /// </summary>
    /// <param name="StateName"></param>
    public void fillCities(string StateName)
    {
        try
        {
            string Connection = ConfigurationManager.AppSettings["ConnectionString"];
            SqlConnection oCon = new SqlConnection(Connection);
            string s = "select city_Id,city_name from Cities where state_name= '" + StateName + "'";
            SqlCommand cmd = new SqlCommand(s, oCon);
            oCon.Open();
            SqlDataAdapter da = new SqlDataAdapter(s, oCon);
            DataSet ds = new DataSet();
            da.Fill(ds, "Cities");
            //DlCities.SelectedIndex = 0;

            ddlCity.DataSource = ds.Tables["Cities"];
            ddlCity.DataValueField = "city_name";
            ddlCity.DataTextField = "city_name";
            ddlCity.DataBind();
            ddlCity.Items.Insert(0, "Select City");
            oCon.Close();
        }
        catch (Exception ex)
        {
            lblMessage.Text = ex.Message.ToString();
        }
    }
    /// <summary>
    /// Executes whenever Module drop down selection changed
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void ddlModule_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlModule.SelectedIndex != 0)
        {
            if (ddlModule.SelectedValue == "LifeStyle")
            {
                data.FillLifeStyleCategory(ddlCategory);
            }
            else if (ddlModule.SelectedValue == "B2B Category")
            {
                string Module_Name = Convert.ToString(ddlModule.SelectedValue);
                DataCS data = new DataCS();
                //To bind Categories
                data.FillB2BCategory(ddlCategory);
            }
            else if (ddlModule.SelectedValue == "FreeListing")
            {
                string Module_Name = Convert.ToString(ddlModule.SelectedValue);
                DataCS data = new DataCS();
                //To bind Categories
                data.FillFreeListing(ddlCategory);
            }
            else
            {
                string Module_Name = Convert.ToString(ddlModule.SelectedValue);
                fillCategories(Module_Name);
            }

        }
        else
        {
            ddlCategory.Items.Clear();
            ddlCategory.Items.Insert(0, "Select Category");
        }
        VisibilityConditions();
    }
    /// <summary>
    /// Executes whenever category drop down selection changed
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void ddlCategory_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlCategory.SelectedIndex != 0)
        {
            string Categoty_Name = Convert.ToString(ddlCategory.SelectedValue);

            if (ddlModule.SelectedValue == "LifeStyle")
            {
                string statement = "select * from Lifestyle where Categeory='" + ddlCategory.SelectedValue + "'";
                connection.Open();
                SqlDataAdapter adabrand = new SqlDataAdapter(statement, connection);
                DataSet dsbrand = new DataSet();
                adabrand.Fill(dsbrand);
                connection.Close();
                if (!dsbrand.Tables[0].Rows.Count.Equals(0))
                {
                    trSubCat.Visible = true;
                    fillLifeStyleSubCat(Categoty_Name);
                }
                else
                {
                    trSubCat.Visible = false;
                    ddlSubCat.Items.Clear();
                    ddlSubCat.Items.Insert(0, "Select SubCategory");
                }
            }
            else if (ddlModule.SelectedValue == "B2B Category")
            {
                string statement1 = "select * from B2BCategories where maincat='" + ddlCategory.SelectedValue + "'";
                connection.Open();
                SqlDataAdapter adab2b = new SqlDataAdapter(statement1, connection);
                DataSet dsb2b = new DataSet();
                adab2b.Fill(dsb2b);
                connection.Close();
                if (!dsb2b.Tables[0].Rows.Count.Equals(0))
                {

                    trSubCat.Visible = true;
                    fillB2BSubCategories(Categoty_Name);
                }
                else
                {
                    trSubCat.Visible = false;
                    ddlSubCat.Items.Clear();
                    ddlSubCat.Items.Insert(0, "Select SubCategory");
                }
            }
            else if (ddlModule.SelectedValue == "FreeListing")
            {
                string statement0 = "select * from FreeListing_SubCat where Cat='" + ddlCategory.SelectedValue + "'";
                connection.Open();
                SqlDataAdapter adFL = new SqlDataAdapter(statement0, connection);
                DataSet dsFL = new DataSet();
                adFL.Fill(dsFL);
                connection.Close();
                if (!dsFL.Tables[0].Rows.Count.Equals(0))
                {
                    trSubCat.Visible = true;
                    fillFLSubCategories(Categoty_Name);
                }
                else
                {
                    trSubCat.Visible = false;
                    ddlSubCat.Items.Clear();
                    ddlSubCat.Items.Insert(0, "Select SubCategory");
                }
            }
            else
            {
                string statement2 = "select * from subcatageory where maincat='" + ddlCategory.SelectedValue + "'";
                connection.Open();
                SqlDataAdapter adacat = new SqlDataAdapter(statement2, connection);
                DataSet dscat = new DataSet();
                adacat.Fill(dscat);
                connection.Close();
                if (!dscat.Tables[0].Rows.Count.Equals(0))
                {                    
                    trSubCat.Visible = true;
                    fillSubCategories(Categoty_Name);
                }
                else
                {
                    trSubCat.Visible = false;
                    ddlSubCat.Items.Clear();
                    ddlSubCat.Items.Insert(0, "Select SubCategory");
                }

            }
        }
        else
        {
            ddlSubCat.Items.Clear();
            ddlSubCat.Items.Insert(0, "Select Sub Category");
        }
    }
    /// <summary>
    /// Executes whenever State drop down selection changed
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void ddlState_SelectedIndexChanged(object sender, EventArgs e)
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
    /// <summary>
    /// Executes whenever Exp drop down selection changed
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void ddlExp_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlExp.SelectedValue == "Experience")
        {
            trExpOther.Visible = true;

        }
        else
        {
            trExpOther.Visible = false;
        }
    }
    /// <summary>
    /// Executes whenever sub category drop down selection changed
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void ddlSubCat_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlSubCat.SelectedValue == "Others")
        {

            trOtherSubCat.Visible = true;
        }
        else
        {
            trOtherSubCat.Visible = false;
        }
    }
    /// <summary>
    /// Function to edit form data
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        DataSet dsUserDetails = new DataSet();
        Module = Convert.ToString(ddlModule.SelectedValue);
        Cat = Convert.ToString(ddlCategory.SelectedValue);
        SubCat = Convert.ToString(ddlSubCat.SelectedValue);
        OtherSubCat = Convert.ToString(txtOthers.Text);
        State = Convert.ToString(ddlState.SelectedValue);
        City = Convert.ToString(ddlCity.SelectedValue);
        Area = Convert.ToString(txtArea.Text);
        CompanyName = Convert.ToString(txtCompanyname.Text);
        JobIndustry = Convert.ToString(ddlJIndustry.Text);
        JobFunArea = Convert.ToString(ddlJFunArea.Text);
        JobRole = Convert.ToString(txtJRole.Text);
        JobQualification = Convert.ToString(txtJQual.Text);
        if (ddlExp.SelectedValue == "Experience")
        {
           JobExp = Convert.ToString(txtJExp.Text);
        }
        else
        {
            JobExp = Convert.ToString(ddlExp.SelectedValue);
        }
        JobSal = Convert.ToString(txtJSal.Text);
        JobDesc = Convert.ToString(txtJobDesc.Text);
        JobSkills = Convert.ToString(txtJkeyskills.Text);
        Age = Convert.ToString(txtAge.Text);
        JCDCompanyProfile = Convert.ToString(txtCompanyProfile.Text);
        if (txtJobExpire.Text != "")
        {
            JobExpiryDate = Convert.ToDateTime(txtJobExpire.Text);
        }
        else
        {
            JobExpiryDate = DateTime.MinValue;
        }              
        EveName = Convert.ToString(txtEveName.Text);
        EvePlace = Convert.ToString(txtEvePlace.Text);
        if (txtEveDiStartDate.Text != "")
        {
            StartDate = Convert.ToDateTime(txtEveDiStartDate.Text);
        }
        else
        {
            StartDate = DateTime.MinValue;
        }
        if (txtEveDiEndDate.Text != "")
        {
            EndDate = Convert.ToDateTime(txtEveDiEndDate.Text);
        }
        else
        {
            EndDate = DateTime.MinValue;
        }       
        EveDiDetails = Convert.ToString(txtEveDiDesc.Text);
        EveDiTime = Convert.ToString(txtEveDiTime.Text);
        Address = Convert.ToString(txtaddr.Text);
        LandMark = Convert.ToString(txtLandMark.Text);
        Pincode = Convert.ToString(txtPinCode.Text);
        ContactPerson = Convert.ToString(txtContPerson.Text);
        EmailId = Convert.ToString(txtemail.Text);
        Phone = Convert.ToString(txtph.Text);
        Mobile = Convert.ToString(txtcode.Text + txtmobile.Text);
        Fax = Convert.ToString(txtFax.Text);
        Website = Convert.ToString(txtWebsite.Text);
        EventDurationType = Convert.ToString(ddlDurationType.SelectedValue);
        string CatSub = string.Empty;        
        if (ddlSubCat.SelectedIndex != 0)
        {
            SubCat = Convert.ToString(ddlSubCat.SelectedValue);
            CatSub = ddlCategory.SelectedValue + "-" + ddlSubCat.SelectedValue;
        }
        else
        {
            SubCat = "";
            CatSub = "";
        } 
        data.pId = Did;
        data.dAddress = Address;
        data.dCategory = Cat;
        data.dCity = City;
        data.dArea = Area;
        data.dContact_Person = ContactPerson;
        data.dEmail = EmailId;
        data.dFaxNo = Fax;
        data.dLandMark = LandMark;
        data.dMobile = Mobile;
        data.dModule = Module;
        data.dPhNumber = Phone;
        data.dState = State;
        data.dSubCategory = SubCat;
        data.dSubCategory_Other = OtherSubCat;
        data.ediDescription = EveDiDetails;
        data.ediEndDate = EndDate;
        data.ediStartDate = StartDate;
        data.ediTimeDuration = EveDiTime;
        data.eEventName = EveName;
        data.eEventPlace = EvePlace;
        data.jcdCompany_Name = CompanyName;
        data.jJob_Expiry = JobExpiryDate;
        data.jcdCompany_Profile = JCDCompanyProfile;
        data.jExp = JobExp;
        data.jAge = Age;
        data.jFun_Area = JobFunArea;
        data.jIndustry = JobIndustry;
        data.jJob_Desc = JobDesc;
        data.jQualification = JobQualification;
        data.jRole = JobRole;
        data.jSal = JobSal;
        data.jSkills = JobSkills;
        data.dWebSite = Website;
        data.dPinCode = Pincode;
        data.dCatSub = CatSub;
        data.ediDurationType = EventDurationType;
        data.dPostDate = DateTime.Now;
        data.dLoginId = UserId;
        // To edit data using 3-tier architecture
        connection.Open();
        t = data.Data_Update(data.pId, data.dModule, data.dCategory, data.dSubCategory, data.dSubCategory_Other, data.dState,
            data.dCity, data.jcdCompany_Name, data.jIndustry, data.jFun_Area, data.jRole, data.jQualification,data.jAge,data.jExp, data.jSal,
            data.jJob_Desc, data.jSkills,data.jJob_Expiry, data.jcdCompany_Profile, data.eEventName, data.eEventPlace, data.ediStartDate,
            data.ediEndDate, data.ediDescription, data.ediTimeDuration, data.dAddress, data.dLandMark,data.dPinCode, data.dContact_Person,
            data.dEmail, data.dPhNumber, data.dMobile, data.dFaxNo,data.dWebSite,data.dCatSub,data.dArea,data.ediDurationType,data.dPostDate,data.dLoginId);
        connection.Close();
        if (Module == "Jobs")
        {
            int id = Convert.ToInt16(Request.QueryString["did"]);
            SqlCommand cmdget = new SqlCommand("get_careerid", connection);
            cmdget.CommandType = CommandType.StoredProcedure;
            cmdget.Parameters.AddWithValue("@jid", id);
            DataSet dscareer = new DataSet();
            SqlDataAdapter dacareer = new SqlDataAdapter(cmdget);
            dacareer.Fill(dscareer);
            string exper = JobExp;
            SqlConnection careercon = new SqlConnection(ConfigurationManager.AppSettings["career_connectionstring"]);
            careercon.Open();
            SqlCommand cmd = new SqlCommand("Update_Postcareers_Jobs", careercon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@p_jobtitle", "With the reference of Justcalluz.com");
            cmd.Parameters.AddWithValue("@p_designation", JobRole);
            cmd.Parameters.AddWithValue("@p_skills", JobSkills);
            if (exper == "Fresher")
            {
                cmd.Parameters.AddWithValue("@p_minexp", 0);
                cmd.Parameters.AddWithValue("@p_maxexp", 0);
            }
            else
            {
                string[] ex = exper.Split('-', ' ');
                cmd.Parameters.AddWithValue("@p_minexp", ex[0]);
                cmd.Parameters.AddWithValue("@p_maxexp", ex[1]);
            }

            if (City == "Hyderabad" || City == "Secunderabad")
            {
                cmd.Parameters.AddWithValue("@p_location", "Hyderabad/Secunderabad,");
                cmd.Parameters.AddWithValue("@p_hiringoff", "Hyderabad/Secunderabad,");
            }
            else
            {
                cmd.Parameters.AddWithValue("@p_location", City + ",");
                cmd.Parameters.AddWithValue("@p_hiringoff", City + ",");
            }
            cmd.Parameters.AddWithValue("@p_ctc", "INR");
            cmd.Parameters.AddWithValue("@p_ctc_lak", "Lakhs");
            cmd.Parameters.AddWithValue("@p_ctc_thous", "Thousands");
            cmd.Parameters.AddWithValue("@p_ctc1_lak", "Lakhs");
            cmd.Parameters.AddWithValue("@p_ctc1_thous", "Thousands");
            cmd.Parameters.AddWithValue("@p_ctc2_hunthous", "select");
            cmd.Parameters.AddWithValue("@p_ctc2_thous", "select");
            cmd.Parameters.AddWithValue("@p_ctc2_hunthous1", "select");
            cmd.Parameters.AddWithValue("@p_ctc2_thous1", "select");
            cmd.Parameters.AddWithValue("@p_ctc_hundthous", "select");
            cmd.Parameters.AddWithValue("@p_ctc_thous1", "select");
            cmd.Parameters.AddWithValue("@p_ctc1_hunthous", "select");
            cmd.Parameters.AddWithValue("@p_ctc1_thous1", "select");
            cmd.Parameters.AddWithValue("@p_hidecandidates", JobSal);
            cmd.Parameters.AddWithValue("@p_perks", "Empty");
            cmd.Parameters.AddWithValue("@p_vacancies", SqlDbType.Int).Value = 1;
            cmd.Parameters.AddWithValue("@p_gender", "Select");
            cmd.Parameters.AddWithValue("@p_farea", JobFunArea);
            cmd.Parameters.AddWithValue("@p_industry", JobIndustry);
            cmd.Parameters.AddWithValue("@p_graduate", "Any Graduate");
            cmd.Parameters.AddWithValue("@p_graduatecours", "Any Specialization");
            cmd.Parameters.AddWithValue("@p_graduatecoursspec", "Graduation Not Required");
            cmd.Parameters.AddWithValue("@p_pg", "Not Required");
            cmd.Parameters.AddWithValue("@p_pgcourse", JobQualification);
            cmd.Parameters.AddWithValue("@p_pgcoursspec", "Post Graduation Not Required");
            cmd.Parameters.AddWithValue("@p_gother", "select");
            cmd.Parameters.AddWithValue("@p_pgother", "select");
            cmd.Parameters.AddWithValue("@p_hirecomp", CompanyName);
            cmd.Parameters.AddWithValue("@p_compname", "Ace Indus Tech Sol India Pvt. Ltd");
            cmd.Parameters.AddWithValue("@p_address", Address);
            cmd.Parameters.AddWithValue("@p_contact", Mobile + "/" + Phone);
            cmd.Parameters.AddWithValue("@p_Executname", ContactPerson);
            cmd.Parameters.AddWithValue("@p_days", "select");
            cmd.Parameters.AddWithValue("@p_times", "select");
            cmd.Parameters.AddWithValue("@p_emailid", EmailId);
            cmd.Parameters.AddWithValue("@p_mail_parameters", "Empty,Empty,Empty,Empty,Empty,Empty,Empty");
            cmd.Parameters.AddWithValue("@p_refcode", "Empty");
            cmd.Parameters.AddWithValue("@p_onekeys", "Empty");
            cmd.Parameters.AddWithValue("@p_allkeys", "Empty");
            cmd.Parameters.AddWithValue("@p_mail_matchparams", "Empty,,Empty,Empty,Empty,Empty");
            cmd.Parameters.AddWithValue("@p_rdo_recvjobs", "Recieve Only Relavent Jobs");
            cmd.Parameters.AddWithValue("@p_rdo_hirecomp", "Hiring Company List");
            cmd.Parameters.AddWithValue("@p_aboutcomp", JCDCompanyProfile);
            cmd.Parameters.AddWithValue("@p_aboutmycomp", "Empty");
            cmd.Parameters.AddWithValue("@p_expiredate", JobExpiryDate);
            cmd.Parameters.AddWithValue("@p_relocatgender", "select");
            cmd.Parameters.AddWithValue("@job_poston", DateTime.Now.Date);
            cmd.Parameters.AddWithValue("@login_id", "jcalluz");
            cmd.Parameters.AddWithValue("@app_received", "Empty");
            cmd.Parameters.AddWithValue("@app_view", "Empty");
            cmd.Parameters.AddWithValue("@p_url", Website);
            cmd.Parameters.AddWithValue("@CompanyLogo", "Empty");
            cmd.Parameters.AddWithValue("@Logopath", "Empty");
            cmd.Parameters.AddWithValue("@p_nonekeys", "Empty");
            cmd.Parameters.AddWithValue("@p_restype", "Key Skills");
            cmd.Parameters.AddWithValue("@p_hiremycomp", CompanyName);
            cmd.Parameters.AddWithValue("@p_jobdescription", JobDesc);
            cmd.Parameters.AddWithValue("@p_desiredprofile", "Empty");
            cmd.Parameters.AddWithValue("@p_status", SqlDbType.Int).Value = 1;
            cmd.Parameters.AddWithValue("@p_jobtype", "company");
            cmd.Parameters.AddWithValue("@p_jobcode", Convert.ToInt32(dscareer.Tables[0].Rows[0]["careers_id"].ToString()));
            cmd.ExecuteNonQuery();
           
        }
        // To display alert message       
        string strScript = "";
        strScript = "alert('Your Data is Updated Successfully'); location.replace('Admin_LinkControllerCategory.aspx?cat=" + Cat + "&mod=" + Module + "');";
        Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
    }
    /// <summary>
    /// Executes whenever duration type drop down selection changed
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void ddlDurationType_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlDurationType.SelectedValue == "One Day Event")
        {
            trEndDate.Visible = false;
        }
        else if (ddlDurationType.SelectedValue == "Multi Day Event")
        {
            trEndDate.Visible = true;
        }
    }
    /// <summary>
    /// To cancel update
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        connection.Open();
        string s = "select * from ModulesData where id =" + Did;
        SqlCommand cmd = new SqlCommand(s, connection);
        //To execute the command and kept in sql data reader
        dr = cmd.ExecuteReader();
        string Module = string.Empty;
        string Cat = string.Empty;
        while (dr.Read())
        {
            Module = Convert.ToString(dr["module"]);
            Cat = Convert.ToString(dr["Category"]);
            SubCat = Convert.ToString(dr["SubCategory"]);

        }
        connection.Close();
        Response.Redirect("Admin_LinkControllerCategory.aspx?cat=" + Server.UrlEncode(Cat) + "&mod=" + Server.UrlEncode(Module) + "&scat=" + Server.UrlEncode(SubCat));
    }
    /// <summary>
    /// To post more information 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnAddMoreInfo_Click(object sender, EventArgs e)
    {        
        Did = Convert.ToInt16(Request.QueryString["did"]);
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
        string mon = Convert.ToString(ddlMonday.SelectedValue);
        string tues = Convert.ToString(ddlTuesday.SelectedValue);
        string wed = Convert.ToString(ddlWednesday.SelectedValue);
        string thurs = Convert.ToString(ddlThursday.SelectedValue);
        string fri = Convert.ToString(ddlFriday.SelectedValue);
        string sat = Convert.ToString(ddlSaturday.SelectedValue);
        string sun = Convert.ToString(ddlSunday.SelectedValue);
        string adinfo=Convert.ToString(txtAdtInfo.Text);
        string yrest=Convert.ToString(ddlYearEstab.SelectedValue);
        string assoc=Convert.ToString(txtProf_Assoc.Text);
        string cert=Convert.ToString(txtCertifi.Text);
        string noemp=Convert.ToString(ddlNoofEmp.SelectedValue);
        connection.Open();
        if (mon!="Select" || tues!="Select" || wed!="Select" || thurs!="Select" || fri!="Select" || sat!="Select" || sun!="Select"  || adinfo!="" || yrest!="Select Year" || assoc!="" || noemp!="Select No of Employees" || Payment!="" || cert!="")
        {
            data.MoreInfo_Insert(data.dMonday, data.dMon_Dur, data.dTuesday, data.dTues_Dur, data.dWednesday, data.dWed_Dur,
                                data.dThursday, data.dThurs_Dur, data.dFriday, data.dFri_Dur, data.dSaturday, data.dSatur_Dur,
                                data.dSunday, data.dSun_Dur, data.pId, data.dPayment, data.dAdtInfo, data.dYearEstab, data.dProf_Accosi, data.dcertification, data.dNoofEmp);
            connection.Close();
            
            strScript = "alert('Your Additional Information is Posted Successfully');location.replace('Admin_EditData.aspx?did=" + Did + "');";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
        }
        else
        {
            strScript = "alert('Please select atleast one to add more information');location.replace('Admin_EditData.aspx?did=" + Did + "#HRO');";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
        }
    }
    /// <summary>
    /// To update more information
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnUpdateMoreInfo_Click(object sender, EventArgs e)
    {
        Did = Convert.ToInt16(Request.QueryString["did"]);
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
        string mon = Convert.ToString(ddlMonday.SelectedValue);
        string tues = Convert.ToString(ddlTuesday.SelectedValue);
        string wed = Convert.ToString(ddlWednesday.SelectedValue);
        string thurs = Convert.ToString(ddlThursday.SelectedValue);
        string fri = Convert.ToString(ddlFriday.SelectedValue);
        string sat = Convert.ToString(ddlSaturday.SelectedValue);
        string sun = Convert.ToString(ddlSunday.SelectedValue);
        string adinfo=Convert.ToString(txtAdtInfo.Text);
        string yrest=Convert.ToString(ddlYearEstab.SelectedValue);
        string assoc=Convert.ToString(txtProf_Assoc.Text);
        string cert=Convert.ToString(txtCertifi.Text);
        string noemp=Convert.ToString(ddlNoofEmp.SelectedValue);        
        if (mon != "Select" || tues != "Select" || wed != "Select" || thurs != "Select" || fri != "Select" || sat != "Select" || sun != "Select" || adinfo != "" || yrest != "Select Year" || assoc != "" || noemp != "Select No of Employees" || Payment != "" || cert != "")
        {
            connection.Open();
            data.MoreInfo_Update(data.dMonday, data.dMon_Dur, data.dTuesday, data.dTues_Dur, data.dWednesday, data.dWed_Dur,
                                data.dThursday, data.dThurs_Dur, data.dFriday, data.dFri_Dur, data.dSaturday, data.dSatur_Dur,
                                data.dSunday, data.dSun_Dur, data.pId, data.dPayment, data.dAdtInfo, data.dYearEstab, data.dProf_Accosi, data.dcertification, data.dNoofEmp);
            connection.Close();
            string strScript = "";
            strScript = "alert('Your Additional Information is Updated Successfully');location.replace('Admin_EditData.aspx?did=" + Did + "');";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
        }
        else
        {
            strScript = "alert('Please select atleast one to add more information');location.replace('Admin_EditData.aspx?did=" + Did + "#HRO');";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
        }
    }
    protected void btnSkip_Click(object sender, EventArgs e)
    {
        Module = Convert.ToString(ddlModule.SelectedValue);
        Cat = Convert.ToString(ddlCategory.SelectedValue);
        Response.Redirect("Admin_LinkControllerCategory.aspx?cat=" + Cat + "&mod=" + Module);
    }
    /// <summary>
    /// data table creation
    /// </summary>
    /// <returns></returns>
    private DataTable CreateDataTable()
    {
        DataTable myDataTable = new DataTable();

        DataColumn myDataColumn;

        myDataColumn = new DataColumn();

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

        return myDataTable;
    }
    /// <summary>
    /// Adding data to the data table
    /// </summary>
    /// <param name="Hr_Fr"></param>
    /// <param name="Min_Fr"></param>
    /// <param name="Type_Fr"></param>
    /// <param name="Hr_T"></param>
    /// <param name="Min_T"></param>
    /// <param name="Type_T"></param>
    /// <param name="myTable"></param>
    private void AddDataToTable(string Hr_Fr, string Min_Fr, string Type_Fr, string Hr_T, string Min_T, string Type_T, DataTable myTable)
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
    /// <summary>
    /// to clear
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lnkClearMon_Click(object sender, EventArgs e)
    {
        //lblTimings.Text = "";        
    }
    /// <summary>
    /// To add more timings on monday
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lnkMonTimings_Click(object sender, EventArgs e)
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
            lnkMonTimings.Enabled = false;
        }

    }
    /// <summary>
    /// To add more timings on tuesday
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lnkTuesTimings_Click(object sender, EventArgs e)
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
            lnkTuesTimings.Enabled = false;
        }

    }
    /// <summary>
    /// To add more timings on wednesday
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lnkWedTimings_Click(object sender, EventArgs e)
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
            lnkWedTimings.Enabled = false;
        }
    }
    /// <summary>
    /// To add more timings on thursday
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lnkThursTimings_Click(object sender, EventArgs e)
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
            lnkThursTimings.Enabled = false;
        }
    }
    /// <summary>
    /// To add more timings on friday
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lnkFriTimings_Click(object sender, EventArgs e)
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
            lnkFriTimings.Enabled = false;
        }
    }
    /// <summary>
    /// To add more timings on saturday
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lnkSaturTimings_Click(object sender, EventArgs e)
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
            lnkSaturTimings.Enabled = false;
        }

    }
    /// <summary>
    /// To add more timings on sunday
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lnkSunTimings_Click(object sender, EventArgs e)
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
            lnkSunTimings.Enabled = false;
        }
        ltrSunTime.Visible = true;
    }
    /// <summary>
    /// to clear monday timings
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lnkBtnClearMonTimings_Click(object sender, EventArgs e)
    {
        lblMonTime.Text = "";
        ltrMonTime.Text = "";
        trLstMon.Visible = false;
    }
    /// <summary>
    /// to clear tuesday timings
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lnkBtnClearTuesTimings_Click(object sender, EventArgs e)
    {
        lblTuesTime.Text = "";
        ltrTuesTime.Text = "";
        trLstTues.Visible = false;
    }
    /// <summary>
    /// to clear wednesday timings
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lnkBtnClearWedTimings_Click(object sender, EventArgs e)
    {
        lblWedTime.Text = "";
        ltrWedTime.Text = "";
        trLstWed.Visible = false;
    }
    /// <summary>
    /// to clear thursday timings
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lnkBtnClearThursTimings_Click(object sender, EventArgs e)
    {
        lblThursTime.Text = "";
        ltrThursTime.Text = "";
        trLstThurs.Visible = false;
    }
    /// <summary>
    /// to clear friday timings
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lnkBtnClearFriTimings_Click(object sender, EventArgs e)
    {
        lblFriTime.Text = "";
        ltrFriTime.Text = "";
        trLstFri.Visible = false;
    }
    /// <summary>
    /// to clear saturday timings
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lnkBtnClearSatTimings_Click(object sender, EventArgs e)
    {
        lblSaturTime.Text = "";
        ltrSaturTime.Text = "";
        trLstSatur.Visible = false;
    }
    /// <summary>
    /// to clear sunday timings
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lnkBtnClearSuntimings_Click(object sender, EventArgs e)
    {
        lblSunTime.Text = "";
        ltrSunTime.Text = "";
        trLstSun.Visible = false;
    }
    /// <summary>
    /// Visibilty conditions assigning values based on conditions
    /// </summary>
    public void Conditions()
    {
        if (ddlMonday.SelectedValue == "Time Duration")
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
                lnkMonTimings.Enabled = false;
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
        else
        {
            trMonDur.Visible = false;
            trLstMon.Visible = false;
            MonDur = "";
        }
        if (ddlTuesday.SelectedValue == "Time Duration")
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
                lnkTuesTimings.Enabled = false;
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
        else
        {
            trTuesDur.Visible = false;
            trLstTues.Visible = false;
            TuesDur = "";
        }
        if (ddlWednesday.SelectedValue == "Time Duration")
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
                lnkWedTimings.Enabled = false;
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
        else
        {
            trWedDur.Visible = false;
            trLstWed.Visible = false;
            WedDur = "";
        }
        if (ddlThursday.SelectedValue == "Time Duration")
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
                lnkThursTimings.Enabled = false;
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
        else
        {
            trThursDur.Visible = false;
            trLstThurs.Visible = false;
            ThursDur = "";
        }
        if (ddlFriday.SelectedValue == "Time Duration")
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
                lnkFriTimings.Enabled = false;
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
        else
        {
            trFriDur.Visible = false;
            trLstFri.Visible = false;
            FriDur = "";
        }
        if (ddlSaturday.SelectedValue == "Time Duration")
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
                lnkSaturTimings.Enabled = false;
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
        else
        {
            trSatDur.Visible = false;
            trLstSatur.Visible = false;
            SatDur = "";
        }
        if (ddlSunday.SelectedValue == "Time Duration")
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
                lnkSunTimings.Enabled = false;
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
        else
        {
            trSunDur.Visible = false;
            trLstSun.Visible = false;
            SunDur = "";
        }
        for (int i = 0; i < lstBoxPayment.Items.Count; i++)      // Select Multiple items from Listbox
        {
            if (lstBoxPayment.Items[i].Selected == true)
            {
                Payment += lstBoxPayment.Items[i].Text + ",";
            }
        }
    }   
    /// <summary>
    /// To upload company logo
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnUploadLogo_Click(object sender, EventArgs e)
    {
        Did = Convert.ToInt16(Request.QueryString["did"]);

        if (uploadLogo.HasFile)
        {
            if (lblLogouploadStatus.Text == "true")
            {
                imgLogoName = System.IO.Path.GetFileName(uploadLogo.PostedFile.FileName);
                connection.Open();
                dsGetLogo = data.getLogoName(imgLogoName);
                if (!dsGetLogo.Tables[0].Rows.Count.Equals(0))
                {
                    Int32 id = Convert.ToInt32(dsGetLogo.Tables[0].Rows[0]["id"].ToString());
                    if (id != Did)
                    {
                        if (uploadLogo.PostedFile.ContentLength < 30000)
                        {
                            using (System.Drawing.Image Img = System.Drawing.Image.FromStream(uploadLogo.PostedFile.InputStream))
                            {
                                if (Img.Width <= 100 & Img.Height <= 75)
                                {
                                    uploadLogo.PostedFile.SaveAs(Server.MapPath("~/Logos/" + imgLogoName));
                                    imgLogoName = System.IO.Path.GetFileName(uploadLogo.PostedFile.FileName);
                                    ImgLogoContentType = uploadLogo.PostedFile.ContentType;
                                    data.dImgName = imgLogoName;
                                    data.dImgContType = ImgLogoContentType;
                                    data.pId = Did;
                                    t = data.Logo_Update(data.pId, data.dImgName, data.dImgContType);
                                    strScripts = "alert('Your Logo is uploaded Successfully');location.replace('Admin_EditData.aspx?did=" + Did + "');";
                                    Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScripts, true);
                                }
                                else
                                {
                                    strScripts = "alert('You can not Upload the  Image because dimensions of the image Exceeds');";
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
                    else
                    {
                        strScripts = "alert('Image name already existed please change Image Name');";
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScripts, true);
                    }

                }
                else
                {
                    if (uploadLogo.PostedFile.ContentLength < 30000)
                    {
                        using (System.Drawing.Image Img = System.Drawing.Image.FromStream(uploadLogo.PostedFile.InputStream))
                        {
                            if (Img.Width <= 100 & Img.Height <= 75)
                            {
                                uploadLogo.PostedFile.SaveAs(Server.MapPath("~/Logos/" + imgLogoName));
                                imgLogoName = System.IO.Path.GetFileName(uploadLogo.PostedFile.FileName);
                                ImgLogoContentType = uploadLogo.PostedFile.ContentType;
                                data.dImgName = imgLogoName;
                                data.dImgContType = ImgLogoContentType;
                                data.pId = Did;
                                t = data.Logo_Update(data.pId, data.dImgName, data.dImgContType);
                                strScripts = "alert('Your Logo is uploaded Successfully');location.replace('Admin_EditData.aspx?did=" + Did + "');";
                                Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScripts, true);
                            }
                            else
                            {
                                strScripts = "alert('You can not Upload the  Image because dimensions of the image Exceeds');";
                                Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScripts, true);
                            }
                        }
                    }
                }
                
                
            }
        }
        else
        {
            strScripts = "alert('Please browse an Image');";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScripts, true);
        }
        connection.Close();
    }
    /// <summary>
    /// To upload company photos
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnUploadPhotos_Click(object sender, EventArgs e)
    {
         
        Did = Convert.ToInt16(Request.QueryString["did"]);
        if (uploadPhotos.HasFile)
        {
            if (lblImageUploadStatus.Text == "true")
            {
                imgPhotoName = System.IO.Path.GetFileName(uploadPhotos.PostedFile.FileName);
                connection.Open();
                dsGetPhoto = data.getPhotoName(imgPhotoName);
                if (!dsGetPhoto.Tables[0].Rows.Count.Equals(0))
                {
                    Int32 id = Convert.ToInt32(dsGetPhoto.Tables[0].Rows[0]["dataid"].ToString());
                  if (id != Did)
                    {
                        if (uploadPhotos.PostedFile.ContentLength < 30000)
                        {
                            using (System.Drawing.Image Img = System.Drawing.Image.FromStream(uploadPhotos.PostedFile.InputStream))
                            {
                                if (Img.Width <= 250 & Img.Height <= 300)
                                {
                                    uploadPhotos.PostedFile.SaveAs(Server.MapPath("~/Photos/" + imgPhotoName));
                                    imgPhotoName = System.IO.Path.GetFileName(uploadPhotos.PostedFile.FileName);
                                    imgPhotoContentType = uploadPhotos.PostedFile.ContentType;
                                    Caption = txtCaption.Text;
                                    data.dImgName = imgPhotoName;
                                    data.dImgContType = imgPhotoContentType;
                                    data.pId = Did;
                                    data.dCaption = Caption;
                                    t = data.Photo_Insert(data.pId, data.dImgName, data.dImgContType, data.dCaption);
                                    strScripts = "alert('Photo is uploaded Successfully');location.replace('Admin_EditData.aspx?did=" + Did + "');";
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
                    else
                    {
                        strScripts = "alert('Image name already existed please change Image Name');";
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScripts, true);
                    }
                   
                    }
                else
                {
                    if (uploadPhotos.PostedFile.ContentLength < 30000)
                    {
                        using (System.Drawing.Image Img = System.Drawing.Image.FromStream(uploadPhotos.PostedFile.InputStream))
                        {
                            if (Img.Width <= 250 & Img.Height <= 300)
                            {
                                uploadPhotos.PostedFile.SaveAs(Server.MapPath("~/Photos/" + imgPhotoName));
                                imgPhotoName = System.IO.Path.GetFileName(uploadPhotos.PostedFile.FileName);
                                imgPhotoContentType = uploadPhotos.PostedFile.ContentType;
                                Caption = txtCaption.Text;
                                data.dImgName = imgPhotoName;
                                data.dImgContType = imgPhotoContentType;
                                data.pId = Did;
                                data.dCaption = Caption;
                                t = data.Photo_Insert(data.pId, data.dImgName, data.dImgContType, data.dCaption);
                                strScripts = "alert('Photo is uploaded Successfully');location.replace('Admin_EditData.aspx?did=" + Did + "');";
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
            }
        }
        else
        {
            strScripts = "alert('Please browse an Image');";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScripts, true);
          
       }
    
       
        
              
        

        connection.Close();
    }
    /// <summary>
    /// To delete a photo
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lnkPhotoDelete(object sender, CommandEventArgs e)
    {
        connection.Open();
        string PhotoName;
        int id = Convert.ToInt32(e.CommandArgument.ToString());
        string getPhotoname = "select PhotoName from Photos where id=" + id;       
        SqlDataAdapter adaName = new SqlDataAdapter(getPhotoname, connection);
        adaName.Fill(dsGetPhoto);        
        if (!dsGetPhoto.Tables[0].Rows.Count.Equals(0))
        {
            PhotoName = dsGetPhoto.Tables[0].Rows[0]["PhotoName"].ToString();           
            string dir = Server.MapPath("~/Photos/");
            string[] picList = Directory.GetFiles(dir);          
            for (int i = 0; i <picList.Length; i++)
                {
                    if (picList[i].Contains(PhotoName))
                    {
                        File.Delete(picList[i]);
                    }
                }          
        }
        string qryDelete = "delete from Photos where id=" + id;       
        SqlCommand cmdDel = new SqlCommand(qryDelete, connection);
        cmdDel.ExecuteNonQuery();        
        connection.Close();
        strScripts = "alert('Photo is deleted successfully');location.replace('Admin_EditData.aspx?did="+id+"');";
        Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScripts, true);
        connection.Close();
    }
    /// <summary>
    /// To pop up a window to change caption for photo
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lnkPhotoChangeCaption(object sender, CommandEventArgs e)
    {          
        int id = Convert.ToInt32(e.CommandArgument.ToString());
        string getPhotoname = "select * from Photos where id=" + id;
        connection.Open();
        SqlDataAdapter adaName = new SqlDataAdapter(getPhotoname, connection);
        adaName.Fill(dsGetPhoto);
        connection.Close();
        if (!dsGetPhoto.Tables[0].Rows.Count.Equals(0))
        {
            Caption = dsGetPhoto.Tables[0].Rows[0]["Caption"].ToString();
        }          
        lblId.Text = Convert.ToString(id);
        txtCaptionNew.Text = Caption;
        ModalPopupExtender1.Show();              
    }
    /// <summary>
    /// To upload videos
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    //protected void btnUploadVedios_Click(object sender, EventArgs e)
    //{
    //    Did = Convert.ToInt16(Request.QueryString["did"]);
    //    connection.Open();
    //    if (uploadVedios.HasFile)
    //    {
    //        string fileExt = System.IO.Path.GetExtension(uploadVedios.FileName);

    //            try
    //            {
    //                VideoName = System.IO.Path.GetFileName(uploadVedios.PostedFile.FileName);                    
    //                uploadVedios.PostedFile.SaveAs(Server.MapPath("~/Videos/" + VideoName));                    
    //                VideoContentType = uploadVedios.PostedFile.ContentType;
    //                data.dImgName = VideoName;
    //                data.dImgContType = VideoContentType;
    //                data.pId = Did;
    //                t = data.Vedio_Insert(data.pId, data.dImgName, data.dImgContType);
    //                strScripts = "alert('Vedio is uploaded Successfully');location.replace('Admin_EditData.aspx?did=" + Did + "');";
    //                Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScripts, true);
    //            }
    //            catch (Exception ex)
    //            {
    //                lblException.Text = "ERROR: " + ex.Message.ToString();
    //            }           
    //    }
    //    else
    //    {
    //        Label1.Text = "You have not specified a file.";
    //    }
    //    connection.Close();
    //}
    /// <summary>
    /// click event to change caption for photo
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void submitbutton_Click(object sender, EventArgs e)
    {
        string PhotoId = lblId.Text;
        Int32 Id = Convert.ToInt32(PhotoId);
        string qry = "Update Photos set Caption='" + txtCaptionNew.Text + "' where id=" + Id;
        SqlCommand cmdCaption = new SqlCommand(qry, connection);
        connection.Open();
        cmdCaption.ExecuteNonQuery();
        connection.Close();
        strScripts = "alert('Caption Changed Successfully');location.replace('Admin_EditData.aspx?did=" + Did + "');";
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScripts, true);
                
    }
    /// <summary>
    /// To cancel changing caption of the photo
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void cancelbutton_Click(object sender, EventArgs e)
    {

    }
    /// <summary>
    /// To bind video
    /// </summary>
    //public void BindVedio()
    //{
    //    try
    //    {
    //        SqlDataAdapter da = new SqlDataAdapter("select * from Vedios where dataid='" + Did + "'", connection);

    //        da.Fill(dsvideo);
    //        if (!dsvideo.Tables[0].Rows.Count.Equals(0))
    //        {
    //            string videoname = dsvideo.Tables[0].Rows[0]["VedioName"].ToString();
    //            swfFileName = "../Videos/" + videoname;
    //        }
    //        else
    //        {
    //            lblNoVideos.Text = "No Vedio Available to play. Please Upload";
    //        }
    //    }

    //    catch (Exception ex)
    //    {
    //        this.Response.Write(ex.ToString());
    //    }
    //}
    protected void CVImgUpload_ServerValidate(object source, ServerValidateEventArgs args)
    {
        string fileext1 = System.IO.Path.GetExtension(uploadPhotos.PostedFile.FileName);
        if (fileext1 == ".gif" || fileext1 == ".jpg" || fileext1 == ".jpeg" || fileext1 == ".GIF" || fileext1 == ".JPG" || fileext1 == ".JPEG")
        {
            lblImageUploadStatus.Text = "true";
            args.IsValid = true;
        }
        else
        {
            lblImageUploadStatus.Text = "false";
            CVImgUpload.ErrorMessage = "Please upload .jpg, .jpeg or .gif files only";
            args.IsValid = false;
        }
    }
    protected void CVLogoUpload_ServerValidate(object source, ServerValidateEventArgs args)
    {
        string fileext1 = System.IO.Path.GetExtension(uploadLogo.PostedFile.FileName);
        if (fileext1 == ".gif" || fileext1 == ".jpg" || fileext1 == ".jpeg" || fileext1 == ".GIF" || fileext1 == ".JPG" || fileext1 == ".JPEG")
        {
            lblLogouploadStatus.Text = "true";
            args.IsValid = true;
        }
        else
        {
            lblLogouploadStatus.Text = "false";
            cvLogo.ErrorMessage = "Please upload .jpg, .jpeg or .gif files only";
            args.IsValid = false;
        }
    }
    //protected void CVVideoUpload_ServerValidate(object source, ServerValidateEventArgs args)
    //{
    //    string fileext = System.IO.Path.GetExtension(uploadVedios.PostedFile.FileName);
    //    if (fileext == ".wmv")
    //    {
    //        lblVedioAudioUploadStatus.Text = "true";
    //        args.IsValid = true;
    //    }
    //    else
    //    {
    //        lblVedioAudioUploadStatus.Text = "false";
    //        CVVideoUpload.ErrorMessage = "Please upload .wmv file only";
    //        args.IsValid = false;
    //    }
    //}
}


