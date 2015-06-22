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
/// To view profile of the user
/// </summary>
public partial class admin_Admin_Profile : System.Web.UI.Page
{
    //making connection
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    //declaration of variables and creation of objects for classes
    Int32 Id;
    bool t;
    string UserId;
    DataSet ds = new DataSet();
    WebAdminCreation obj = new WebAdminCreation();
    string strScript;
    string FirstName;
    string LastName;
    string EmailId;
    
    string B;
    string BPost;
    string BEdit;
    string BDel;
    string BView;
    string BApr;

    string B2B;
    string B2BPost;
    string B2BEdit;
    string B2BDel;
    string B2BView;
    string B2BApr;

    string Eve;
    string EvePost;
    string EveEdit;
    string EveDel;
    string EveView;
    string EveApr;

    string Dis;
    string DisPost;
    string DisEdit;
    string DisDel;
    string DisView;
    string DisApr;

    string Job;
    string JobPost;
    string JobEdit;
    string JobDel;
    string JobView;
    string JobApr;

    string LS;
    string LSPost;
    string LSEdit;
    string LSDel;
    string LSView;
    string LSApr;

    string Careers;
    string CareersPost;
    string CareersEdit;
    string CareersDel;
    string CareersView;

    string UInfo;

    string FL;
    string FLPost;
    string FLEdit;
    string FLDel;
    string FLView;
    string FLApr;

    string Ads;
    string AdsPost;
    string AdsEdit;
    string AdsDel;
    string AdsView;

    string Movies;
    string MoviesPost;
    string MoviesEdit;
    string MoviesDel;
    string MoviesView;

    string CT;
    string CTPost;
    string CTEdit;
    string CTDel;
    string CTView;

    string MS;
    string MSPost;
    string MSEdit;
    string MSDel;
    string MSView;

    string ss;
    string sspost, ssedit, ssdel, ssview;

    string wp, wppost, wpedit, wpdel, wpview;

    string csr, csrpost, csredit, csrdel, csrview;

    string snf, snfpost, snfdel;
    string splnk, splnkpost, splnkedit, splnkdel, splnkview;
    string test, ccare, excep;

   
    /// <summary>
    /// Executes whenever page loads
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Page_Load(object sender, EventArgs e)
    {
        string user_id = Convert.ToString(Request.QueryString["uid"]);
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
        //loads the page without postbacking the values     
        if (!Page.IsPostBack)
        {
            ds = obj.getWebAdminPermissions(UserId);
            if (!ds.Tables[0].Rows.Count.Equals(0))
            {
                FirstName = ds.Tables[0].Rows[0]["fname"].ToString();
                LastName = ds.Tables[0].Rows[0]["lname"].ToString();
                EmailId = ds.Tables[0].Rows[0]["email"].ToString();
                B = ds.Tables[0].Rows[0]["B"].ToString();
                BApr = ds.Tables[0].Rows[0]["BApr"].ToString();
                BPost = ds.Tables[0].Rows[0]["BPost"].ToString();
                BEdit = ds.Tables[0].Rows[0]["BEdit"].ToString();
                BDel = ds.Tables[0].Rows[0]["BDel"].ToString();
                BView = ds.Tables[0].Rows[0]["BView"].ToString();
                B2B = ds.Tables[0].Rows[0]["B2B"].ToString();
                B2BApr = ds.Tables[0].Rows[0]["B2BApr"].ToString();
                B2BDel = ds.Tables[0].Rows[0]["B2BDel"].ToString();
                B2BEdit = ds.Tables[0].Rows[0]["B2BEdit"].ToString();
                B2BPost = ds.Tables[0].Rows[0]["B2BPost"].ToString();
                B2BView = ds.Tables[0].Rows[0]["B2BView"].ToString();
                Job = ds.Tables[0].Rows[0]["Job"].ToString();
                JobApr = ds.Tables[0].Rows[0]["JobApr"].ToString();
                JobDel = ds.Tables[0].Rows[0]["JobDel"].ToString();
                JobEdit = ds.Tables[0].Rows[0]["JobEdit"].ToString();
                JobPost = ds.Tables[0].Rows[0]["JobPost"].ToString();
                JobView = ds.Tables[0].Rows[0]["JobView"].ToString();
                Eve = ds.Tables[0].Rows[0]["Eve"].ToString();
                EveApr = ds.Tables[0].Rows[0]["EveApr"].ToString();
                EveDel = ds.Tables[0].Rows[0]["EveDel"].ToString();
                EveEdit = ds.Tables[0].Rows[0]["EveEdit"].ToString();
                EvePost = ds.Tables[0].Rows[0]["EvePost"].ToString();
                EveView = ds.Tables[0].Rows[0]["EveView"].ToString();
                Dis = ds.Tables[0].Rows[0]["Dis"].ToString();
                DisApr = ds.Tables[0].Rows[0]["DisApr"].ToString();
                DisDel = ds.Tables[0].Rows[0]["DisDel"].ToString();
                DisEdit = ds.Tables[0].Rows[0]["DisEdit"].ToString();
                DisPost = ds.Tables[0].Rows[0]["DisPost"].ToString();
                DisView = ds.Tables[0].Rows[0]["DisView"].ToString();
                LS = ds.Tables[0].Rows[0]["LS"].ToString();
                LSApr = ds.Tables[0].Rows[0]["LSApr"].ToString();
                LSDel = ds.Tables[0].Rows[0]["LSDel"].ToString();
                LSEdit = ds.Tables[0].Rows[0]["LSEdit"].ToString();
                LSPost = ds.Tables[0].Rows[0]["LSPost"].ToString();
                LSView = ds.Tables[0].Rows[0]["LSView"].ToString();
                Careers = ds.Tables[0].Rows[0]["Careers"].ToString();
                CareersDel = ds.Tables[0].Rows[0]["CareersDel"].ToString();
                CareersEdit = ds.Tables[0].Rows[0]["CareersEdit"].ToString();
                CareersPost = ds.Tables[0].Rows[0]["CareersPost"].ToString();
                CareersView = ds.Tables[0].Rows[0]["CareersView"].ToString();

                UInfo = ds.Tables[0].Rows[0]["UInfo"].ToString();

                FL = ds.Tables[0].Rows[0]["FL"].ToString();
                FLApr = ds.Tables[0].Rows[0]["FLApprove"].ToString();
                FLDel = ds.Tables[0].Rows[0]["FLDel"].ToString();
                FLEdit = ds.Tables[0].Rows[0]["FLEdit"].ToString();
                FLPost = ds.Tables[0].Rows[0]["FLPost"].ToString();
                FLView = ds.Tables[0].Rows[0]["FLView"].ToString();
                Ads = ds.Tables[0].Rows[0]["Ads"].ToString();
                AdsDel = ds.Tables[0].Rows[0]["AdsDel"].ToString();
                AdsEdit = ds.Tables[0].Rows[0]["AdsEdit"].ToString();
                AdsPost = ds.Tables[0].Rows[0]["AdsPost"].ToString();
                AdsView = ds.Tables[0].Rows[0]["AdsView"].ToString();
                Movies = ds.Tables[0].Rows[0]["Movies"].ToString();
                MoviesDel = ds.Tables[0].Rows[0]["MoviesDel"].ToString();
                MoviesEdit = ds.Tables[0].Rows[0]["MoviesEdit"].ToString();
                MoviesPost = ds.Tables[0].Rows[0]["MoviesPost"].ToString();
                MoviesView = ds.Tables[0].Rows[0]["MoviesView"].ToString();
                CT = ds.Tables[0].Rows[0]["CT"].ToString();
                CTDel = ds.Tables[0].Rows[0]["CTDel"].ToString();
                CTEdit = ds.Tables[0].Rows[0]["CTEdit"].ToString();
                CTPost = ds.Tables[0].Rows[0]["CTPost"].ToString();
                CTView = ds.Tables[0].Rows[0]["CTView"].ToString();
                MS = ds.Tables[0].Rows[0]["MS"].ToString();
                MSDel = ds.Tables[0].Rows[0]["MSDel"].ToString();
                MSEdit = ds.Tables[0].Rows[0]["MSEdit"].ToString();
                MSPost = ds.Tables[0].Rows[0]["MSPost"].ToString();
                MSView = ds.Tables[0].Rows[0]["MSView"].ToString();
                wp = ds.Tables[0].Rows[0]["WP"].ToString();
                wppost = ds.Tables[0].Rows[0]["WPPost"].ToString();
                wpedit = ds.Tables[0].Rows[0]["WPEdit"].ToString();
                wpdel = ds.Tables[0].Rows[0]["WPDel"].ToString();
                wpview = ds.Tables[0].Rows[0]["WPView"].ToString();
                ss = ds.Tables[0].Rows[0]["SS"].ToString();
                sspost = ds.Tables[0].Rows[0]["SSPost"].ToString();
                ssedit = ds.Tables[0].Rows[0]["SSEdit"].ToString();
                ssdel = ds.Tables[0].Rows[0]["SSDel"].ToString();
                ssview = ds.Tables[0].Rows[0]["SSView"].ToString();
                csr = ds.Tables[0].Rows[0]["CSR"].ToString();
                csrpost = ds.Tables[0].Rows[0]["CSRPost"].ToString();
                csredit = ds.Tables[0].Rows[0]["CSREdit"].ToString();
                csrdel = ds.Tables[0].Rows[0]["CSRDel"].ToString();
                csrview = ds.Tables[0].Rows[0]["CSRView"].ToString();
                snf = ds.Tables[0].Rows[0]["SNF"].ToString();
                snfpost = ds.Tables[0].Rows[0]["SNFPost"].ToString();
                snfdel = ds.Tables[0].Rows[0]["SNFDel"].ToString();
                splnk = ds.Tables[0].Rows[0]["splnk"].ToString();
                splnkpost = ds.Tables[0].Rows[0]["splnk_post"].ToString();
                splnkedit = ds.Tables[0].Rows[0]["splnk_edit"].ToString();
                splnkdel = ds.Tables[0].Rows[0]["splnk_del"].ToString();
                splnkview = ds.Tables[0].Rows[0]["splnk_view"].ToString();
                test = ds.Tables[0].Rows[0]["test"].ToString();
                ccare = ds.Tables[0].Rows[0]["ccare"].ToString();
                excep = ds.Tables[0].Rows[0]["excep"].ToString();

            }
            lblFName.Text = FirstName;
            lblLName.Text = LastName;
            lblEmail.Text = EmailId;
            if (B == "1")
            {
                rbBYes.Checked = true;
                trIBModule.Visible = true;
            }
            else
            {
                rbBNo.Checked = true;
                trIBModule.Visible = false;
            }
            if (B2B == "1")
            {
                rbB2BYes.Checked = true;
                trIB2BModule.Visible = true;
            }
            else
            {
                rbB2BNo.Checked = true;
                trIB2BModule.Visible = false;
            }
            if (Job == "1")
            {
                rbJobsYes.Checked = true;
                trIJobsModule.Visible = true;
            }
            else
            {
                rbJobsNo.Checked = true;
                trIJobsModule.Visible = false;
            }
            if (Eve == "1")
            {
                rbEveYes.Checked = true;
                trIEveModule.Visible = true;
            }
            else
            {
                rbEveNo.Checked = true;
                trIEveModule.Visible = false;
            }
            if (Dis == "1")
            {
                rbDisYes.Checked = true;
                trIDisModule.Visible = true;
            }
            else
            {
                rbDisNo.Checked = true;
                trIDisModule.Visible = false;
            }
            if (LS == "1")
            {
                rbLSYes.Checked = true;
                trILSModule.Visible = true;
            }
            else
            {
                rbLSNo.Checked = true;
                trILSModule.Visible = false;
            }
            if (Careers == "1")
            {
                rbCareersYes.Checked = true;
                trICareers.Visible = true;
            }
            else
            {
                rbCareersNo.Checked = true;
                trICareers.Visible = false;
            }
            
            if (UInfo == "1")
            {
                rbUInfoYes.Checked = true;
            }
            else
            {
                rbUInfoNo.Checked = true;
            }
            if (FL == "1")
            {
                rbFLYes.Checked = true;
                trFL.Visible = true;
            }
            else
            {
                rbFLNo.Checked = true;
                trFL.Visible = false;
            }
            if (Ads == "1")
            {
                rbAdsYes.Checked = true;
                trAds.Visible = true;
            }
            else
            {
                rbAdsNo.Checked = true;
                trAds.Visible = false;
            }
            if (Movies == "1")
            {
                rbMYes.Checked = true;
                trMovies.Visible = true;
            }
            else
            {
                rbMNo.Checked = true;
                trMovies.Visible = false;
            }
            if (CT == "1")
            {
                rbCTYes.Checked = true;
                trCT.Visible = true;
            }
            else
            {
                rbCTNo.Checked = true;
                trCT.Visible = false;
            }
            if (MS == "1")
            {
                rbMSYes.Checked = true;
                trMS.Visible = true;
            }
            else
            {
                rbMSNo.Checked = true;
                trMS.Visible = false;
            }
            if (wp == "1")
            {
                rbwpyes.Checked = true;
                trwp.Visible = true;
            }
            else
            {
                rbwpno.Checked = true;
                trwp.Visible = false;
            }
            if (ss == "1")
            {
                rbssyes.Checked = true;
                trsuccess.Visible = true;
            }
            else
            {
                rbssno.Checked = true;
                trsuccess.Visible = false;
            }
            if (csr == "1")
            {
                rbcsryes.Checked = true;
                trscr.Visible = true;
            }
            else
            {
                rbcsrno.Checked = true;
                trscr.Visible = false;
            }
            if (snf == "1")
            {
                rbsnfyes.Checked = true;
                trsnf.Visible = true;
            }
            else
            {
                rbsnfno.Checked = true;
                trsnf.Visible = false;
            }
            if (splnk == "1")
            {
                rbslyes.Checked = true;
                trslink.Visible = true;
            }
            else
            {
                rbslno.Checked = true;
                trslink.Visible = false;
            }
            if (excep == "1")
            {
                rbexyes.Checked = true;
            }
            else
            {
                rbexno.Checked = true;
            }

            if(BApr=="1")
            {
                chkbxBApproval.Checked = true;
            }
            else
            {
                chkbxBApproval.Checked=false;
            }
            if(BPost=="1")
            {
                chkbxBPost.Checked = true;
            }
            else
            {
                chkbxBPost.Checked = false;
            }
            if (BEdit == "1")
            {
                chkbxBEdit.Checked = true;
            }
            else
            {
                chkbxBEdit.Checked = false;
            }
            if (BDel == "1")
            {
                chkbxBDel.Checked = true;
            }
            else
            {
                chkbxBDel.Checked = false;
            }
            if (BView == "1")
            {
                chkbxBPreview.Checked = true;
            }
            else
            {
                chkbxBPreview.Checked = false;
            }
            if (B2BApr == "1")
            {
                chkbxB2BApproval.Checked = true;
            }
            else
            {
                chkbxB2BApproval.Checked = false;
            }
            if ( B2BDel== "1")
            {
                chkbxB2BDel.Checked = true;
            }
            else
            {
                chkbxB2BDel.Checked = false;
            }
            if (B2BEdit == "1")
            {
                chkbxB2BEdit.Checked = true;
            }
            else
            {
                chkbxB2BEdit.Checked = false;
            }
            if (B2BPost == "1")
            {
                chkbxB2BPost.Checked = true;
            }
            else
            {
                chkbxB2BPost.Checked = false;
            }
            if (B2BView == "1")
            {
                chkbxB2Bview.Checked = true;
            }
            else
            {
                chkbxB2Bview.Checked = false;
            }
            if (JobApr == "1")
            {
                chkbxJobsApproval.Checked = true;
            }
            else
            {
                chkbxJobsApproval.Checked = false;
            }
            if (JobDel == "1")
            {
                chkbxJobsDel.Checked = true;
            }
            else
            {
                chkbxJobsDel.Checked = false;
            }
            if (JobEdit == "1")
            {
                chkbxJobsEdit.Checked = true;
            }
            else
            {
                chkbxJobsEdit.Checked = false;
            }
            if (JobPost == "1")
            {
                chkbxJobsPost.Checked = true;
            }
            else
            {
                chkbxJobsPost.Checked = false;
            }
            if (JobView == "1")
            {
                chkbxJobsview.Checked = true;
            }
            else
            {
                chkbxJobsview.Checked = false;
            }
            if (EveApr == "1")
            {
                chkbxEveApproval.Checked = true;
            }
            else
            {
                chkbxEveApproval.Checked = false;
            }
            if (EveDel == "1")
            {
                chkbxEveDel.Checked = true;
            }
            else
            {
                chkbxEveDel.Checked = false;
            }
            if (EveEdit == "1")
            {
                chkbxEveEdit.Checked = true;
            }
            else
            {
                chkbxEveEdit.Checked = false;
            }
            if (EvePost == "1")
            {
                chkbxEvePost.Checked = true;
            }
            else
            {
                chkbxEvePost.Checked = false;
            }
            if (EveView == "1")
            {
                chkbxEveview.Checked = true;
            }
            else
            {
                chkbxEveview.Checked = false;
            }
            if (DisApr == "1")
            {
                chkbxDisApproval.Checked = true;
            }
            else
            {
                chkbxDisApproval.Checked = false;
            }
            if (DisDel == "1")
            {
                chkbxDisDel.Checked = true;
            }
            else
            {
                chkbxDisDel.Checked = false;
            }
            if (DisEdit == "1")
            {
                chkbxDisEdit.Checked = true;
            }
            else
            {
                chkbxDisEdit.Checked = false;
            }
            if (DisPost == "1")
            {
                chkbxDisPost.Checked = true;
            }
            else
            {
                chkbxDisPost.Checked = false;
            }
            if (DisView == "1")
            {
                chkbxDisview.Checked = true;
            }
            else
            {
                chkbxDisview.Checked = false;
            }
            if (LSApr == "1")
            {
                chkbxLSApproval.Checked = true;
            }
            else
            {
                chkbxLSApproval.Checked = false;
            }
            if (LSDel == "1")
            {
                chkbxLSDel.Checked = true;
            }
            else
            {
                chkbxLSDel.Checked = false;
            }
            if (LSEdit == "1")
            {
                chkbxLSEdit.Checked = true;
            }
            else
            {
                chkbxLSEdit.Checked = false;
            }
            if (LSPost == "1")
            {
                chkbxLSPost.Checked = true;
            }
            else
            {
                chkbxLSPost.Checked = false;
            }
            if (LSView == "1")
            {
                chkbxLSview.Checked = true;
            }
            else
            {
                chkbxLSview.Checked = false;
            }
            if (CareersDel == "1")
            {
                chkbxCareersDel.Checked = true;
            }
            else
            {
                chkbxCareersDel.Checked = false;
            }
            if (CareersEdit == "1")
            {
                chkbxCareersEdit.Checked = true;
            }
            else
            {
                chkbxCareersEdit.Checked = false;
            }
            if (CareersPost == "1")
            {
                chkbxCareersPost.Checked = true;
            }
            else
            {
                chkbxCareersPost.Checked = false;
            }
            if (CareersView == "1")
            {
                chkbxCareersview.Checked = true;
            }
            else
            {
                chkbxCareersview.Checked = false;
            }
            

            
            if (FLApr == "1")
            {
                chkFLApprove.Checked = true;
            }
            else
            {
                chkFLApprove.Checked = false;
            }
            if (FLDel == "1")
            {
                chkFreelistDelete.Checked = true;
            }
            else
            {
                chkFreelistDelete.Checked = false;
            }
            if (FLEdit == "1")
            {
                chkFreelistEdit.Checked = true;
            }
            else
            {
                chkFreelistEdit.Checked = false;
            }
            if (FLPost == "1")
            {
                chkFreelistPost.Checked = true;
            }
            else
            {
                chkFreelistPost.Checked = false;
            }
            if (FLView == "1")
            {
                chkFreelistView.Checked = true;
            }
            else
            {
                chkFreelistView.Checked = false;
            }
            if (AdsDel == "1")
            {
                chkAdsDelete.Checked = true;
            }
            else
            {
                chkAdsDelete.Checked = false;
            }
            if (AdsEdit == "1")
            {
                chkAdsEdit.Checked = true;
            }
            else
            {
                chkAdsEdit.Checked = false;
            }
            if (AdsPost == "1")
            {
                chkAdsPost.Checked = true;
            }
            else
            {
                chkAdsPost.Checked = false;
            }
            if (AdsView == "1")
            {
                chkAdsView.Checked = true;
            }
            else
            {
                chkAdsView.Checked = false;
            }
            if (MoviesDel == "1")
            {
                chkMoviesDelete.Checked = true;
            }
            else
            {
                chkMoviesDelete.Checked = false;
            }
            if (MoviesEdit == "1")
            {
                chkMoviesEdit.Checked = true;
            }
            else
            {
                chkMoviesEdit.Checked = false;
            }
            if (MoviesPost == "1")
            {
                chkMoviesPost.Checked = true;
            }
            else
            {
                chkMoviesPost.Checked = false;
            }
            if (MoviesView == "1")
            {
                ChkMoviesView.Checked = true;
            }
            else
            {
                ChkMoviesView.Checked = false;
            }
            if (CTDel == "1")
            {
                chkCTDelete.Checked = true;
            }
            else
            {
                chkCTDelete.Checked = false;
            }
            if (CTEdit == "1")
            {
                chkCTEdit.Checked = true;
            }
            else
            {
                chkCTEdit.Checked = false;
            }
            if (CTPost == "1")
            {
                chkCTPost.Checked = true;
            }
            else
            {
                chkCTPost.Checked = false;
            }
            if (CTView == "1")
            {
                chkCTView.Checked = true;
            }
            else
            {
                chkCTView.Checked = false;
            }
            if (MSDel == "1")
            {
                chkMSDelete.Checked = true;
            }
            else
            {
                chkMSDelete.Checked = false;
            }
            if (MSEdit == "1")
            {
                chkMSEdit.Checked = true;
            }
            else
            {
                chkMSEdit.Checked = false;
            }
            if (MSPost == "1")
            {
                chkMSPost.Checked = true;
            }
            else
            {
                chkMSPost.Checked = false;
            }
            if (MSView == "1")
            {
                chkMSView.Checked = true;
            }
            else
            {
                chkMSView.Checked = false;
            }
            if (wppost == "1")
            {
                chkwhitepost.Checked = true;
            }
            else
            {
                chkwhitepost.Checked = false;
            }
            if (wpedit == "1")
            {
                chkwhiteedit.Checked = true;
            }
            else
            {
                chkwhiteedit.Checked = false;
            }
            if (wpdel == "1")
            {
                chkwhitedelete.Checked = true;
            }
            else
            {
                chkwhitedelete.Checked = false;
            }
            if (wpview == "1")
            {
                chkwhitepreview.Checked = true;
            }
            else
            {
                chkwhitepreview.Checked = false;
            }
            if (sspost == "1")
            {
                chksuccesspost.Checked = true;
            }
            else
            {
                chksuccesspost.Checked = false;
            }
            if (ssedit == "1")
            {
                chksuccessedit.Checked = true;
            }
            else
            {
                chksuccessedit.Checked = false;
            }
            if (ssdel == "1")
            {
                chksuccessdelete.Checked = true;
            }
            else
            {
                chksuccessdelete.Checked = false;
            }
            if (ssview == "1")
            {
                chksuccesspreview.Checked = true;
            }
            else
            {
                chksuccesspreview.Checked = false;
            }
            if (csrpost == "1")
            {
                chkcsrpost.Checked = true;
            }
            else
            {
                chkcsrpost.Checked = false;
            }
            if (csredit == "1")
            {
                chkcsredit.Checked = true;
            }
            else
            {
                chkcsredit.Checked = false;
            }
            if (csrdel == "1")
            {
                chkcsrdelete.Checked = true;
            }
            else
            {
                chkcsrdelete.Checked = false;
            }
            if (csrview == "1")
            {
                chkcsrpreview.Checked = true;
            }
            else
            {
                chkcsrpreview.Checked = false;
            }
            if (snfpost == "1")
            {
                chksnpost.Checked = true;
            }
            else
            {
                chksnpost.Checked = false;
            }
            if (snfdel == "1")
            {
                chksnfdelete.Checked = true;
            }
            else
            {
                chksnfdelete.Checked = false;
            }
            if (splnkpost == "1")
            {
                chkslpost.Checked = true;
            }
            else
            {
                chkslpost.Checked = false;
            }
            if (splnkedit == "1")
            {
                chksledit.Checked = true;
            }
            else
            {
                chksledit.Checked = false;
            }
            if (splnkdel == "1")
            {
                chksldel.Checked = true;
            }
            else
            {
                chksldel.Checked = false;
            }
            if (splnkview == "1")
            {
                chkslview.Checked = true;
            }
            else
            {
                chkslview.Checked = false;
            }
            if (test == "1")
            {
                rbtestyes.Checked = true;
            }
            else
            {
                rbtestno.Checked = true;
            }
            if (ccare == "1")
            {
                rbccareyes.Checked = true;
            }
            else
            {
                rbccareno.Checked = true;
            }
            if (excep == "1")
            {
                rbexyes.Checked = true;
            }
            else
            {
                rbexno.Checked = true;
            }
           
        }
        if (rbB2BYes.Checked == true)
        {
            trIB2BModule.Visible = true;
            chkbxB2Bview.Checked = true;
            chkbxB2Bview.Enabled = false;

        }
        else if (rbB2BNo.Checked == true)
        {
            trIB2BModule.Visible = false;
            chkbxB2Bview.Checked = false;
        }
       
        if (rbBYes.Checked == true)
        {
            trIBModule.Visible = true;
            chkbxBPreview.Checked = true;
            chkbxBPreview.Enabled = false;
        }
        else if (rbBNo.Checked == true)
        {
            trIBModule.Visible = false;
            chkbxBPreview.Checked = false;
        }
        if (rbCareersYes.Checked == true)
        {
            trICareers.Visible = true;
            chkbxCareersview.Checked = true;
            chkbxCareersview.Enabled = false;
        }
        else if (rbCareersNo.Checked == true)
        {
            trICareers.Visible = false;
            chkbxCareersview.Checked = false;
        }
        if (rbDisYes.Checked == true)
        {
            trIDisModule.Visible = true;
            chkbxDisview.Checked = true;
            chkbxDisview.Enabled = false;
        }
        else if (rbDisNo.Checked == true)
        {
            trIDisModule.Visible = false;
            chkbxDisview.Checked = false;
        }
        if (rbEveYes.Checked == true)
        {
            trIEveModule.Visible = true;
            chkbxEveview.Checked = true;
            chkbxEveview.Enabled = false;
        }
        else if (rbEveNo.Checked == true)
        {
            trIEveModule.Visible = false;
            chkbxEveview.Checked = false;
        }
        if (rbJobsYes.Checked == true)
        {
            trIJobsModule.Visible = true;
            chkbxJobsview.Checked = true;
            chkbxJobsview.Enabled = false;
        }
        else if (rbJobsNo.Checked == true)
        {
            trIJobsModule.Visible = false;
            chkbxJobsview.Checked = false;
        }
        if (rbLSYes.Checked == true)
        {
            trILSModule.Visible = true;
            chkbxLSview.Checked = true;
            chkbxLSview.Enabled = false;
        }
        else if (rbLSNo.Checked == true)
        {
            trILSModule.Visible = false;
            chkbxLSview.Checked = false;
        }
        if (rbUInfoYes.Checked == true)
        {
           
        }
        else
        {
            
        }
        if (rbMYes.Checked == true)
        {
            trMovies.Visible = true;
            ChkMoviesView.Checked = true;
            ChkMoviesView.Enabled = false;
        }
        else
        {
            trMovies.Visible = false;
            ChkMoviesView.Checked = false;
        }
        if (rbCTYes.Checked == true)
        {
            trCT.Visible = true;
            chkCTView.Checked = true;
            chkCTView.Enabled = false;
        }
        else
        {
            trCT.Visible = false;
            chkCTView.Checked = false;
        }
        if (rbMSYes.Checked == true)
        {
            trMS.Visible = true;
            chkMSView.Checked = true;
            chkMSView.Enabled = false;
        }
        else
        {
            trMS.Visible = false;
            chkMSView.Checked = false;
        }
        if (rbAdsYes.Checked == true)
        {
            trAds.Visible = true;
            chkAdsView.Checked = true;
            chkAdsView.Enabled = false;
        }
        else
        {
            trAds.Visible = false;
            chkAdsView.Checked = false;
        }
        if (rbFLYes.Checked == true)
        {
            trFL.Visible = true;
            chkFreelistView.Checked = true;
            chkFreelistView.Enabled = false;
        }
        else
        {
            trFL.Visible = false;
            chkFreelistView.Checked = false;
        }
        if (rbwpyes.Checked == true)
        {
            trwp.Visible = true;
            chkwhitepreview.Checked = true;
            chkwhitepreview.Enabled = false;
        }
        else
        {
            trwp.Visible = false;
            chkwhitepreview.Checked = false;
        }
        if (rbssyes.Checked == true)
        {
            trsuccess.Visible = true;
            chksuccesspreview.Checked = true;
            chksuccesspreview.Enabled = false;
        }
        else
        {
        trsuccess.Visible = false;
            chksuccesspreview.Checked = false;
        }
        if (rbcsryes.Checked == true)
        {
            trscr.Visible = true;
            chkcsrpreview.Checked = true;
            chkcsrpreview.Enabled = false;
        }
        else
        {
            trscr.Visible = false;
            chkcsrpreview.Enabled = false;
        }
        if (rbsnfyes.Checked == true)
        {
            trsnf.Visible = true;
        }
        else
        {
            trsnf.Visible = false;
        }
        
    
    }    
}
