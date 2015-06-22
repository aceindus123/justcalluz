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
/// To display the data in detailed manner
/// </summary>
public partial class admin_Data_Details : System.Web.UI.Page
{
    DataSet rs;
    SqlDataReader dr;
    string UserId;
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
        if (Request.QueryString["did"] != null)
        {
            Int32 Id = Convert.ToInt32(Request.QueryString["did"]);
            //Database connection string.
            string strConn = ConfigurationManager.AppSettings["ConnectionString"];
            //Make a connection to the Database
            SqlConnection myConn = new SqlConnection(strConn);
            //loads the page without postbacking the values
            if (!Page.IsPostBack)
            {
                try
                {
                    //to open connection
                    myConn.Open();
                    string s = "select *,Post_Date=Convert(varchar,postdate,105) from ModulesData where id =" + Id;
                    SqlCommand cmd = new SqlCommand(s, myConn);
                    //To execute the command and kept in sql data reader
                    dr = cmd.ExecuteReader();
                    string Module = string.Empty;
                    string Cat = string.Empty;
                    string SubCat = string.Empty;
                    string OtherSubCat = string.Empty;
                    string State = string.Empty;
                    string City = string.Empty;
                    string Area = string.Empty;
                    string CompanyName = string.Empty;
                    string CompanyProfile = string.Empty;
                    string JobIndustry = string.Empty;
                    string JobFunArea = string.Empty;
                    string JobRole = string.Empty;
                    string JobQualification = string.Empty;
                    string Age = string.Empty;
                    string JobExp = string.Empty;
                    string JobSal = string.Empty;
                    string JobDesc = string.Empty;
                    string JobSkills = string.Empty;
                    string JCDCompanyProfile = string.Empty;
                    string EveName = string.Empty;
                    string EvePlace = string.Empty;
                    string EveDiStartDate = string.Empty;
                    string EveDiEndDate = string.Empty;
                    string EveDiDetails = string.Empty;
                    string EveDiTime = string.Empty;
                    string Address = string.Empty;
                    string LandMark = string.Empty;
                    string ContactPerson = string.Empty;
                    string EmailId = string.Empty;
                    string Mobile = string.Empty;
                    string Phone = string.Empty;
                    string Fax = string.Empty;
                    string WebSite = string.Empty;
                    string StartDate = string.Empty;
                    string JExpDate = string.Empty;
                    string JobExpDate = string.Empty;
                    string Pincode = string.Empty;
                    // reading data from the data reader and bounding those values to the corresponding fields in the form
                    while (dr.Read())
                    {
                        Module = Convert.ToString(dr["module"]);
                        Session["module"] = Module;
                        Cat = Convert.ToString(dr["Category"]);
                        SubCat = Convert.ToString(dr["SubCategory"]);
                        OtherSubCat = Convert.ToString(dr["Other_SubCat"]);
                        State = Convert.ToString(dr["State"]);
                        City = Convert.ToString(dr["City"]);
                        Area = Convert.ToString(dr["Area"]);
                        CompanyName = Convert.ToString(dr["company_name"]);
                        CompanyProfile = Convert.ToString(dr["company_profile"]);
                        JobIndustry = Convert.ToString(dr["job_industry"]);
                        JobFunArea = Convert.ToString(dr["job_functional_area"]);
                        JobRole = Convert.ToString(dr["job_role"]);
                        JobQualification = Convert.ToString(dr["job_Qualification"]);
                        Age = Convert.ToString(dr["Age"]);
                        JobExp = Convert.ToString(dr["job_exp"]);
                        JobSal = Convert.ToString(dr["job_sal"]);
                        JobDesc = Convert.ToString(dr["job_desc"]);
                        JobSkills = Convert.ToString(dr["job_keyskills"]);
                        JCDCompanyProfile = Convert.ToString(dr["company_profile"]);
                        EveName = Convert.ToString(dr["event_name"]);
                        EvePlace = Convert.ToString(dr["event_Place"]);
                        EveDiStartDate = Convert.ToString(dr["event_startdate"]);
                        EveDiEndDate = Convert.ToString(dr["event_enddate"]);
                        EveDiDetails = Convert.ToString(dr["event_desc"]);
                        EveDiTime = Convert.ToString(dr["event_time"]);
                        Address = Convert.ToString(dr["address"]);
                        LandMark = Convert.ToString(dr["land_mark"]);
                        ContactPerson = Convert.ToString(dr["contact_person"]);
                        EmailId = Convert.ToString(dr["emailid"]);
                        Mobile = Convert.ToString(dr["mob"]);
                        Phone = Convert.ToString(dr["landphno"]);
                        Fax = Convert.ToString(dr["fax"]);
                        WebSite = Convert.ToString(dr["Website"]);
                        StartDate = Convert.ToString(dr["Post_Date"]);
                        JExpDate = Convert.ToString(dr["Job_ExpiryDate"]);
                        Pincode = Convert.ToString(dr["Pincode"]);
                        if (Module == "Jobs")
                        {
                            string format = "dd-MM-yyyy";
                            DateTime j_expdate = (Convert.ToDateTime(JExpDate));
                            JobExpDate = j_expdate.ToString(format);
                        }
                        Session["Cat"] = Cat;
                        Session["SubCat"] = SubCat;
                        Session["Mod"] = Module;
                        Session["CompanyName"] = CompanyName;
                        Session["EveName"] = EveName;
                    }

                    rs = new DataSet();
                    SqlDataAdapter mycommand = new SqlDataAdapter(s, strConn);
                    mycommand.Fill(rs, "reply");
                    if (rs.Tables["reply"].Rows.Count != 0)
                    {
                        lblModule.Text = Module;
                        lblCat.Text = Cat;
                        if (SubCat == "Others")
                        {
                            lblSubCat.Text = OtherSubCat;
                        }
                        else
                        {
                            lblSubCat.Text = SubCat;
                        }
                        lblCompanyName.Text = CompanyName;
                        lblComprofile.Text = CompanyProfile;
                        lblEveName.Text = EveName;
                        lblEvePlace.Text = EvePlace;
                        if (EveDiStartDate != "")
                        {
                            lblEveStartDate.Text = EveDiStartDate;
                        }
                        else
                        {
                            lblEveStartDate.Text = "--nill--";
                        }
                        if (EveDiEndDate != "")
                        {
                            lblEveEndDtae.Text = EveDiEndDate;
                        }
                        else
                        {
                            lblEveEndDtae.Text = "--nill--";
                        }
                        lblEveTime.Text = EveDiTime;
                        lblEveDescription.Text = EveDiDetails;
                        if (EveDiStartDate != "")
                        {
                            lblDisStartDate.Text = EveDiStartDate;
                        }
                        else
                        {
                            lblDisStartDate.Text = "--nill--";
                        }
                        if (EveDiEndDate != "")
                        {
                            lblDisEndDate.Text = EveDiEndDate;
                        }
                        else
                        {
                            lblDisEndDate.Text = "--nill--";
                        }
                        lblDisTime.Text = EveDiTime;
                        lblDisDetails.Text = EveDiDetails;
                        lblAddress.Text = Address;
                        lblArea.Text = Area;
                        lblCity.Text = City;
                        lblState.Text = State;
                        if (LandMark == "")
                        {
                            lblLandMark.Text = "--nill--";
                        }
                        else
                        {
                            lblLandMark.Text = LandMark;
                        }
                        lblContPer.Text = ContactPerson;
                        lblEmail.Text = EmailId;
                        if (Phone == "")
                        {
                            lblPhone.Text = "--nill--";
                        }
                        else
                        {
                            lblPhone.Text = Phone;
                        }
                        lblMobile.Text = Mobile;
                        if (Fax == "")
                        {
                            lblFax.Text = "--nill--";
                        }
                        else
                        {
                            lblFax.Text = Fax;
                        }
                        if (WebSite == "")
                        {
                            lblWebsite.Text = "--nill--";
                        }
                        else
                        {
                            lblWebsite.Text = WebSite;
                        }
                        lblInd.Text = JobIndustry;
                        lblFunArea.Text = JobFunArea;
                        lblRole.Text = JobRole;
                        lblQual.Text = JobQualification;
                        lblAge.Text = Age;
                        lblSkills.Text = JobSkills;
                        lblJobDesc.Text = JobDesc;
                        lblExp.Text = JobExp;
                        lblSal.Text = JobSal;
                        lblJobPost.Text = StartDate;
                        lblJobExpire.Text = JobExpDate;
                        lblMessage.Text = "";
                        lblPinCode.Text = Pincode;

                    }
                    //Conditions to make visibility of fields for a particular module
                    if (Module == "Category")
                    {
                        trDataHeader.Visible = true;
                        trMovieHeader.Visible = false;

                        trMod.Visible = true;
                        trCat.Visible = true;
                        trSubCat.Visible = true;

                        trHEveDetails.Visible = false;
                        trEveName.Visible = false;
                        trEvePlace.Visible = false;
                        trEveStartDate.Visible = false;
                        treveEndsDate.Visible = false;
                        treveTime.Visible = false;
                        treveDescription.Visible = false;

                        trHDisDetails.Visible = false;
                        trdisStartDate.Visible = false;
                        trDisEndDate.Visible = false;
                        trDisTime.Visible = false;
                        trDisDetails.Visible = false;

                        trHCompDetails.Visible = true;
                        trCompName.Visible = true;
                        trComprofile.Visible = true;
                        trAddress.Visible = true;
                        trLandMark.Visible = true;
                        trContPer.Visible = true;
                        trEmail.Visible = true;
                        trMobile.Visible = true;
                        trPhone.Visible = true;
                        trFax.Visible = true;
                        trWebSite.Visible = true;

                        trHJobDetails.Visible = false;
                        trInd.Visible = false;
                        trFunArea.Visible = false;
                        trRole.Visible = false;
                        trQual.Visible = false;
                        trAge.Visible = false;
                        trSkills.Visible = false;
                        trJobDesc.Visible = false;
                        trExp.Visible = false;
                        trSal.Visible = false;
                        trJobPost.Visible = false;
                        trJobExpire.Visible = false;
                        lblComporEveName.Text = CompanyName;
                    }
                    else if (Module == "B2B Category")
                    {
                        trDataHeader.Visible = true;
                        trMovieHeader.Visible = false;

                        trMod.Visible = true;
                        trCat.Visible = true;
                        trSubCat.Visible = true;

                        trHEveDetails.Visible = false;
                        trEveName.Visible = false;
                        trEvePlace.Visible = false;
                        trEveStartDate.Visible = false;
                        treveEndsDate.Visible = false;
                        treveTime.Visible = false;
                        treveDescription.Visible = false;

                        trHDisDetails.Visible = false;
                        trdisStartDate.Visible = false;
                        trDisEndDate.Visible = false;
                        trDisTime.Visible = false;
                        trDisDetails.Visible = false;

                        trHCompDetails.Visible = true;
                        trCompName.Visible = true;
                        trComprofile.Visible = true;
                        trAddress.Visible = true;
                        trLandMark.Visible = true;
                        trContPer.Visible = true;
                        trEmail.Visible = true;
                        trMobile.Visible = true;
                        trPhone.Visible = true;
                        trFax.Visible = true;
                        trWebSite.Visible = true;

                        trHJobDetails.Visible = false;
                        trInd.Visible = false;
                        trFunArea.Visible = false;
                        trRole.Visible = false;
                        trQual.Visible = false;
                        trAge.Visible = false;
                        trSkills.Visible = false;
                        trJobDesc.Visible = false;
                        trExp.Visible = false;
                        trSal.Visible = false;
                        trJobPost.Visible = false;
                        trJobExpire.Visible = false;
                        lblComporEveName.Text = CompanyName;
                    }
                    else if (Module == "FreeListing")
                    {
                        trDataHeader.Visible = true;
                        trMovieHeader.Visible = false;

                        trMod.Visible = true;
                        trCat.Visible = true;
                        trSubCat.Visible = true;

                        trHEveDetails.Visible = false;
                        trEveName.Visible = false;
                        trEvePlace.Visible = false;
                        trEveStartDate.Visible = false;
                        treveEndsDate.Visible = false;
                        treveTime.Visible = false;
                        treveDescription.Visible = false;

                        trHDisDetails.Visible = false;
                        trdisStartDate.Visible = false;
                        trDisEndDate.Visible = false;
                        trDisTime.Visible = false;
                        trDisDetails.Visible = false;

                        trHCompDetails.Visible = true;
                        trCompName.Visible = true;
                        trComprofile.Visible = true;
                        trAddress.Visible = true;
                        trLandMark.Visible = true;
                        trContPer.Visible = true;
                        trEmail.Visible = true;
                        trMobile.Visible = true;
                        trPhone.Visible = true;
                        trFax.Visible = true;
                        trWebSite.Visible = true;

                        trHJobDetails.Visible = false;
                        trInd.Visible = false;
                        trFunArea.Visible = false;
                        trRole.Visible = false;
                        trQual.Visible = false;
                        trAge.Visible = false;
                        trSkills.Visible = false;
                        trJobDesc.Visible = false;
                        trExp.Visible = false;
                        trSal.Visible = false;
                        trJobPost.Visible = false;
                        trJobExpire.Visible = false;
                        lblComporEveName.Text = CompanyName;
                        lblCompHeading.Text = "Title";
                        lblCompanyProfile.Text = "Description";
                        lblCompEveHeading1.Text = "Listing Information";
                    }
                    else if (Module == "Discounts")
                    {
                        trDataHeader.Visible = true;
                        trMovieHeader.Visible = false;

                        trMod.Visible = true;
                        trCat.Visible = true;
                        trSubCat.Visible = true;

                        trHEveDetails.Visible = false;
                        trEveName.Visible = false;
                        trEvePlace.Visible = false;
                        trEveStartDate.Visible = false;
                        treveEndsDate.Visible = false;
                        treveTime.Visible = false;
                        treveDescription.Visible = false;

                        trHDisDetails.Visible = true;
                        trdisStartDate.Visible = true;
                        trDisEndDate.Visible = true;
                        trDisTime.Visible = true;
                        trDisDetails.Visible = true;

                        trHCompDetails.Visible = true;
                        trCompName.Visible = true;
                        trComprofile.Visible = true;
                        trAddress.Visible = true;
                        trLandMark.Visible = true;
                        trContPer.Visible = true;
                        trEmail.Visible = true;
                        trMobile.Visible = true;
                        trPhone.Visible = true;
                        trFax.Visible = true;
                        trWebSite.Visible = true;

                        trHJobDetails.Visible = false;
                        trInd.Visible = false;
                        trFunArea.Visible = false;
                        trRole.Visible = false;
                        trQual.Visible = false;
                        trAge.Visible = false;
                        trSkills.Visible = false;
                        trJobDesc.Visible = false;
                        trExp.Visible = false;
                        trSal.Visible = false;
                        trJobPost.Visible = false;
                        trJobExpire.Visible = false;
                        lblComporEveName.Text = CompanyName;

                    }
                    else if (Module == "Events")
                    {
                        trDataHeader.Visible = true;
                        trMovieHeader.Visible = false;

                        trMod.Visible = true;
                        trCat.Visible = true;
                        trSubCat.Visible = true;

                        trHEveDetails.Visible = true;
                        trEveName.Visible = true;
                        trEvePlace.Visible = true;
                        trEveStartDate.Visible = true;
                        treveEndsDate.Visible = true;
                        treveTime.Visible = true;
                        treveDescription.Visible = true;

                        trHDisDetails.Visible = false;
                        trdisStartDate.Visible = false;
                        trDisEndDate.Visible = false;
                        trDisTime.Visible = false;
                        trDisDetails.Visible = false;

                        trHCompDetails.Visible = false;
                        trCompName.Visible = false;
                        trComprofile.Visible = false;
                        trAddress.Visible = true;
                        trLandMark.Visible = true;
                        trContPer.Visible = true;
                        trEmail.Visible = true;
                        trMobile.Visible = true;
                        trPhone.Visible = true;
                        trFax.Visible = true;
                        trWebSite.Visible = true;

                        trHJobDetails.Visible = false;
                        trInd.Visible = false;
                        trFunArea.Visible = false;
                        trRole.Visible = false;
                        trQual.Visible = false;
                        trAge.Visible = false;
                        trSkills.Visible = false;
                        trJobDesc.Visible = false;
                        trExp.Visible = false;
                        trSal.Visible = false;
                        trJobPost.Visible = false;
                        trJobExpire.Visible = false;

                        lblComporEveName.Text = EveName;
                    }
                    else if (Module == "Jobs")
                    {
                        trDataHeader.Visible = true;
                        trMovieHeader.Visible = false;

                        trMod.Visible = true;
                        trCat.Visible = true;
                        trSubCat.Visible = true;

                        trHEveDetails.Visible = false;
                        trEveName.Visible = false;
                        trEvePlace.Visible = false;
                        trEveStartDate.Visible = false;
                        treveEndsDate.Visible = false;
                        treveTime.Visible = false;
                        treveDescription.Visible = false;

                        trHDisDetails.Visible = false;
                        trdisStartDate.Visible = false;
                        trDisEndDate.Visible = false;
                        trDisTime.Visible = false;
                        trDisDetails.Visible = false;

                        trHCompDetails.Visible = true;
                        trCompName.Visible = true;
                        trComprofile.Visible = true;
                        trAddress.Visible = true;
                        trLandMark.Visible = true;
                        trContPer.Visible = true;
                        trEmail.Visible = true;
                        trMobile.Visible = true;
                        trPhone.Visible = true;
                        trFax.Visible = true;
                        trWebSite.Visible = true;

                        trHJobDetails.Visible = true;
                        trInd.Visible = true;
                        trFunArea.Visible = true;
                        trRole.Visible = true;
                        trQual.Visible = true;
                        trAge.Visible = true;
                        trSkills.Visible = true;
                        trJobDesc.Visible = true;
                        trExp.Visible = true;
                        trSal.Visible = true;
                        trJobPost.Visible = true;
                        trJobExpire.Visible = true;

                        lblComporEveName.Text = CompanyName;
                    }
                    else if (Module == "LifeStyle")
                    {
                        trDataHeader.Visible = true;
                        trMovieHeader.Visible = false;

                        trMod.Visible = true;
                        trCat.Visible = true;
                        trSubCat.Visible = true;

                        trHEveDetails.Visible = false;
                        trEveName.Visible = false;
                        trEvePlace.Visible = false;
                        trEveStartDate.Visible = false;
                        treveEndsDate.Visible = false;
                        treveTime.Visible = false;
                        treveDescription.Visible = false;

                        trHDisDetails.Visible = false;
                        trdisStartDate.Visible = false;
                        trDisEndDate.Visible = false;
                        trDisTime.Visible = false;
                        trDisDetails.Visible = false;

                        trHCompDetails.Visible = true;
                        trCompName.Visible = true;
                        trComprofile.Visible = true;
                        trAddress.Visible = true;
                        trLandMark.Visible = true;
                        trContPer.Visible = true;
                        trEmail.Visible = true;
                        trMobile.Visible = true;
                        trPhone.Visible = true;
                        trFax.Visible = true;
                        trWebSite.Visible = true;

                        trHJobDetails.Visible = false;
                        trInd.Visible = false;
                        trFunArea.Visible = false;
                        trRole.Visible = false;
                        trQual.Visible = false;
                        trAge.Visible = false;
                        trSkills.Visible = false;
                        trJobDesc.Visible = false;
                        trExp.Visible = false;
                        trSal.Visible = false;
                        trJobPost.Visible = false;
                        trJobExpire.Visible = false;
                        lblComporEveName.Text = CompanyName;
                    }
                    else if (Module == "Movies")
                    {
                        trDataHeader.Visible = false;
                        trMovieHeader.Visible = true;

                        trMod.Visible = false;
                        trCat.Visible = false;
                        trSubCat.Visible = true;

                        trHEveDetails.Visible = false;
                        trEveName.Visible = false;
                        trEvePlace.Visible = false;
                        trEveStartDate.Visible = false;
                        treveEndsDate.Visible = false;
                        treveTime.Visible = false;
                        treveDescription.Visible = false;

                        trHDisDetails.Visible = false;
                        trdisStartDate.Visible = false;
                        trDisEndDate.Visible = false;
                        trDisTime.Visible = false;
                        trDisDetails.Visible = false;

                        trHCompDetails.Visible = false;
                        trCompName.Visible = true;
                        lblCompHeading.Text = "Theatre Name";
                        trComprofile.Visible = false;
                        trAddress.Visible = true;
                        trLandMark.Visible = true;
                        trContPer.Visible = false;
                        trEmail.Visible = true;
                        trMobile.Visible = true;
                        trPhone.Visible = true;
                        trFax.Visible = false;
                        trWebSite.Visible = true;

                        trHJobDetails.Visible = false;
                        trInd.Visible = false;
                        trFunArea.Visible = false;
                        trRole.Visible = false;
                        trQual.Visible = false;
                        trAge.Visible = false;
                        trSkills.Visible = false;
                        trJobDesc.Visible = false;
                        trExp.Visible = false;
                        trSal.Visible = false;
                        trJobPost.Visible = false;
                        trJobExpire.Visible = false;
                        lblComporEveName.Text = CompanyName;
                    }

                }
                //To catch exception
                catch (Exception ex)
                {

                    lblMessage.Text = ex.Message.ToString();
                }
                finally
                {
                    if (myConn != null) myConn.Close();
                }

            }
        }
        else
        {
            Response.Redirect("Admin_Home.aspx");
        }

    }
    /// <summary>
    /// To go previous page
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    //protected void ImgBtnBack_Click(object sender, ImageClickEventArgs e)
    //{
    //    string Cat = Convert.ToString(Session["Cat"]);
    //    string SubCat = Convert.ToString(Session["SubCat"]);
    //    string Mod = Convert.ToString(Session["Mod"]);
    //    if (Mod == "Jobs")
    //    {
    //        Response.Redirect("Admin_LinkControllerCategory.aspx?cat=" + Server.UrlEncode(Session["SubCat"].ToString()) + "&mod=" + Server.UrlEncode(Session["Mod"].ToString()));
    //    }
    //    else if (Mod == "Events")
    //    {
    //        Response.Redirect("Admin_LinkControllerCategory.aspx?cat=" + Server.UrlEncode(Session["SubCat"].ToString()) + "&mod=" + Server.UrlEncode(Session["Mod"].ToString()));
    //    }
    //    else if (Mod == "Discounts")
    //    {
    //        Response.Redirect("Admin_LinkControllerCategory.aspx?cat=" + Server.UrlEncode(Session["SubCat"].ToString()) + "&mod=" + Server.UrlEncode(Session["Mod"].ToString()));
    //    }
    //    else if (Mod == "Movies")
    //    {
    //        Response.Redirect("Admin_ViewHallsData.aspx");
    //    }
    //    else
    //    {
    //        Response.Redirect("Admin_LinkControllerCategory.aspx?cat=" + Server.UrlEncode(Session["Cat"].ToString()) + "&mod=" + Server.UrlEncode(Session["Mod"].ToString()));
    //    }
    //}
    /// <summary>
    /// To view reviews
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void ImgBtnViewReview_Click(object sender, EventArgs e)
    {
        string Id = Convert.ToString(Request.QueryString["did"]);
        Response.Redirect("Admin_ViewReviews.aspx?id=" + Id);
    }
    /// <summary>
    /// To view the status of the data i.e, when the data is posted, when it is updated & by whom etc
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void BtnStatus_Click(object sender, EventArgs e)
    {
        string Id = Convert.ToString(Request.QueryString["did"]);
        Response.Redirect("Admin_StatusofDatainDetail.aspx?id=" + Id);
    }
    /// <summary>
    /// To go previous page
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lnkBack_Click(object sender, EventArgs e)
    {
        string Cat = Convert.ToString(Session["Cat"]);
        string SubCat = Convert.ToString(Session["SubCat"]);
        string Mod = Convert.ToString(Session["Mod"]);
        if (Mod == "Jobs")
        {
            Response.Redirect("Admin_LinkControllerCategory.aspx?cat=" + Server.UrlEncode(Session["SubCat"].ToString()) + "&mod=" + Server.UrlEncode(Session["Mod"].ToString()));
        }
        else if (Mod == "Events")
        {
            Response.Redirect("Admin_LinkControllerCategory.aspx?cat=" + Server.UrlEncode(Session["SubCat"].ToString()) + "&mod=" + Server.UrlEncode(Session["Mod"].ToString()));
        }
        else if (Mod == "Discounts")
        {
            Response.Redirect("Admin_LinkControllerCategory.aspx?cat=" + Server.UrlEncode(Session["SubCat"].ToString()) + "&mod=" + Server.UrlEncode(Session["Mod"].ToString()));
        }
        else if (Mod == "Movies")
        {
            Response.Redirect("Admin_ViewHallsData.aspx");
        }
        else
        {
            Response.Redirect("Admin_LinkControllerCategory.aspx?cat=" + Server.UrlEncode(Session["Cat"].ToString()) + "&mod=" + Server.UrlEncode(Session["Mod"].ToString()));
        }
    }
}

