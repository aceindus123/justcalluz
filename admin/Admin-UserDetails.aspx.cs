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


/// <summary>
/// class to view users
/// </summary>
public partial class admin_Admin_UserDetails : System.Web.UI.Page
{
    //making connection
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    //declaration of variables and creation of object for class
    bool t;
    string strScript = "";
    WebAdminCreation obj = new WebAdminCreation();
    Int32 status;
    string Email;
    DataSet ds = new DataSet();
    string UserId;
    Int32 id;
    DataSet dsgetUserIdData = new DataSet();

    //edit user details

    Int32 Id;
    string FirstName;
    string LastName;
    string EmailId;
    string Password;

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
        if (!Page.IsPostBack)
        {
            ItemsGet();
        }
        if (BApr == "1" && BDel == "1" && BEdit == "1" && BPost == "1" && BView == "1")
        {
            chkBAll.Checked = true;
        }
        if (B2BApr == "1" && B2BDel == "1" && B2BEdit == "1" && B2BPost == "1" && B2BView == "1")
        {
            chkB2BAll.Checked = true;
        }
        if (JobApr == "1" && JobDel == "1" && JobEdit == "1" && JobPost == "1" && JobView == "1")
        {
            chkJobsAll.Checked = true;
        }
        if (EveApr == "1" && EveDel == "1" && EveEdit == "1" && EvePost == "1" && EveView == "1")
        {
            chkEveAll.Checked = true;
        }
        if (DisApr == "1" && DisDel == "1" && DisEdit == "1" && DisPost == "1" && DisView == "1")
        {
            chkDisAll.Checked = true;
        }
        if (LSApr == "1" && LSDel == "1" && LSEdit == "1" && LSPost == "1" && LSView == "1")
        {
            chkLSAll.Checked = true;
        }
        if (CareersDel == "1" && CareersEdit == "1" && CareersPost == "1" && CareersView == "1")
        {
            chkCareersAll.Checked = true;
        }
        if (FLApr == "1" && FLDel == "1" && FLEdit == "1" && FLPost == "1" && FLView == "1")
        {
            chkFreelistAll.Checked = true;
        }
        if (AdsDel == "1" && AdsEdit == "1" && AdsPost == "1" && AdsView == "1")
        {
            chkAdsAll.Checked = true;
        }
        if (MoviesDel == "1" && MoviesEdit == "1" && MoviesPost == "1" && MoviesView == "1")
        {
            chkMoviesAll.Checked = true;
        }
        if (CTDel == "1" && CTEdit == "1" && CTPost == "1" && CTView == "1")
        {
            chkCTAll.Checked = true;
        }
        if (MSDel == "1" && MSEdit == "1" && MSPost == "1" && MSView == "1")
        {
            chkMSAll.Checked = true;
        }
        if (wppost == "1" && wpedit == "1" && wpdel == "1" && wpview == "1")
        {
            chkwhiteall.Checked = true;
        }
        if (sspost == "1" && ssedit == "1" && ssdel == "1" && ssview == "1")
        {
            chksuccessall.Checked = true;
        }
        if (csrpost == "1" && csrdel == "1" && csredit == "1" && csrview == "1")
        {
            chkcsrall.Checked = true;
        }
        if (snfpost == "1" && snfdel == "1")
        {
            chksnfall.Checked = true;
        }
        if (splnkpost == "1" && splnkedit == "1" && splnkdel == "1" && splnkview == "1")
        {
            chkslall.Checked = true;
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
            chkCareersApproval.Enabled = false;
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
            chkMoviesApproval.Enabled = false;
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
            chkCTApproval.Enabled = false;
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
            chkMSApproval.Enabled = false;
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
            chkAdsApproval.Enabled = false;
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
            chkwhiteApproval.Enabled = false;
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
            chksuccessApproval.Enabled = false;
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
            chkscrApproval.Enabled = false;
        }
        else
        {
            trscr.Visible = false;
            chkcsrpreview.Enabled = false;
        }
        if (rbsnfyes.Checked == true)
        {
            trsnf.Visible = true;
            chksnfApproval.Enabled = false;
            chksnfEdit.Enabled = false;
            chksnfPreview.Enabled = false;
        }
        else
        {
            trsnf.Visible = false;
        }
        if (rbslyes.Checked == true)
        {
            trslink.Visible = true;
            chkslApproval.Enabled = false;
        }
        else
        {
            trslink.Visible = false;
        }
        if (rbUInfoYes.Checked == true)
        {
            trIUInfo.Visible = true;
            chkUInfoAll.Enabled = false;
            chkUInfoActDeact.Enabled = false;
            chkUInfoDel.Enabled = false;
            chkUInfoPost.Enabled = false;
            chkUInfoview.Enabled = false;
            chkUInfoEdit.Enabled = false;

        }
        else
        {
            trIUInfo.Visible = false;
        }
        if (rbtestyes.Checked == true)
        {
            trtest.Visible = true;
            chktestAll.Enabled = false;
            chktesDelete.Enabled = false;
            chktesPreview.Enabled = false;
            chktesEdit.Enabled = false;
            chktesPost.Enabled = false;
            chktestApproval.Enabled = false;
        }
        else
        {
            trtest.Visible = false;
        }
        if (rbccareyes.Checked == true)
        {
            trCustomers.Visible = true;
            chkCustAll.Enabled = false;
            chkcustApproval.Enabled = false;
            chkCustDelete.Enabled = false;
            chkCustEdit.Enabled = false;
            chkCustPost.Enabled = false;
            chkCustPreview.Enabled = false;
        }
        else
        {
            trCustomers.Visible = false;
        }
        if (rbexyes.Checked == true)
        {
            trExceptions.Visible = true;
            chkExceptionsAll.Enabled = false;
            chkExceptionsApproval.Enabled = false;
            chkExceptionsDelete.Enabled = false;
            chkExceptionsEdit.Enabled = false;
            chkExceptionsPost.Enabled = false;
            chkExceptionsPreview.Enabled = false;
        }
        else
        {
            trExceptions.Visible = false;
        }
       

    }
    /// <summary>
    /// Page change
    /// </summary>
    /// <param name="source"></param>
    /// <param name="e"></param>
    protected void ViewGrid_PageIndexChanged(object source, DataGridPageChangedEventArgs e)
    {
        ViewGridWbAdmin.CurrentPageIndex = e.NewPageIndex;
        ItemsGet();
    }
    /// <summary>
    /// To get users data
    /// </summary>
    private void ItemsGet()
    {
        DataSet ds1 = new DataSet();
        string statement = "select *,Case when Status=1 Then 'Active' when Status=0 Then 'Inactive' End WAStatus from Admin_WebAdminCreation";
        con.Open();
        SqlDataAdapter imgtext = new SqlDataAdapter(statement, con);
        imgtext.Fill(ds1, "categoryData");
        DataView dtView = ds1.Tables[0].DefaultView;
        if (!ds1.Tables[0].Rows.Count.Equals(0))
        {
            for (int i = 0; i < ds1.Tables[0].Rows.Count; i++)
            {
                ViewGridWbAdmin.DataSource = ds1;
                ViewGridWbAdmin.DataBind();
            }
        }
        con.Close();

    }
    /// <summary>
    /// click event to view web admin details
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void ViewDetails_Click(object sender, EventArgs e)
    {
        BindUser_Details();
    }
    /// <summary>
    /// method for bind user details
    /// </summary>
    protected void BindUser_Details()
    {
        for (int i = 0; i < ViewGridWbAdmin.Items.Count; i++)
        {
            CheckBox cbox = (CheckBox)ViewGridWbAdmin.Items[i].FindControl("CheckBoxreq");
            if (cbox.Checked)
            {
                id = Convert.ToInt32(ViewGridWbAdmin.DataKeys[i].ToString());
            }
        }
        try
        {
            dsgetUserIdData = obj.GetParticularUserData(id);
            if (!dsgetUserIdData.Tables[0].Rows.Count.Equals(0))
            {
                txtedfname.Text = dsgetUserIdData.Tables[0].Rows[0]["fname"].ToString();
                txtedlname.Text = dsgetUserIdData.Tables[0].Rows[0]["lname"].ToString();
                txtedpwd.Text = dsgetUserIdData.Tables[0].Rows[0]["Password"].ToString();
                txtedaddress.Text = dsgetUserIdData.Tables[0].Rows[0]["Address"].ToString();
                txteduserid.Text = dsgetUserIdData.Tables[0].Rows[0]["UserId"].ToString();
                txtedcontact.Text = dsgetUserIdData.Tables[0].Rows[0]["Phone"].ToString();
                txtedmob.Text = dsgetUserIdData.Tables[0].Rows[0]["Mobile"].ToString();
                txtedmail.Text = dsgetUserIdData.Tables[0].Rows[0]["email"].ToString();
                if (dsgetUserIdData.Tables[0].Rows[0]["AdminType"].ToString() != null)
                {
                    ddleddesgn.ClearSelection();
                    string designation = Convert.ToString(dsgetUserIdData.Tables[0].Rows[0]["AdminType"].ToString());
                    ddleddesgn.Items.FindByText(designation).Selected = true;

                }
                if (dsgetUserIdData.Tables[0].Rows[0]["Country"].ToString() != null)
                {
                    ddledcountry.ClearSelection();
                    string country = Convert.ToString(dsgetUserIdData.Tables[0].Rows[0]["Country"].ToString());
                    ddledcountry.Items.FindByText(country).Selected = true;

                }
            }
            //loads the page without postbacking the values

            ds = obj.getPerticularWebAdminDetails(id);
            if (!ds.Tables[0].Rows.Count.Equals(0))
            {
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

            }
            else
            {

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

            if (BApr == "1")
            {
                chkbxBApproval.Checked = true;
            }
            else
            {
                chkbxBApproval.Checked = false;
            }
            if (BPost == "1")
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
            if (B2BDel == "1")
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

            mpeEditUsersdata.Show();
        }
        catch (Exception ex)
        {
            ex.ToString();
        }
        //Response.Redirect("Admin_WebAdminViewEdit.aspx?Id=" + id);
    }
   
    /// <summary>
    /// click event to delete already existed web admin
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lnkDelete_Click(object sender, EventArgs e)
    {
        for (int i = 0; i < ViewGridWbAdmin.Items.Count; i++)
        {
            CheckBox cbox = (CheckBox)ViewGridWbAdmin.Items[i].FindControl("CheckBoxreq");
            if (cbox.Checked)
            {
                id = Convert.ToInt32(ViewGridWbAdmin.DataKeys[i].ToString());
            }
        }
        string qry = "delete from Admin_WebAdminCreation where empid=" + id;
        SqlCommand cmd = new SqlCommand(qry, con);
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();
        strScript = "alert('Deleted successfully');location.replace('Admin-UserDetails.aspx');";
        Page.ClientScript.RegisterStartupScript(this.GetType(), "alertbox", strScript, true);
    }
    /// <summary>
    /// Binding dynamically
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void ViewGridWbAdmin_ItemDataBound(object sender, DataGridItemEventArgs e)
    {
        if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
        {


            LinkButton lnkStatusChange = (LinkButton)e.Item.FindControl("lnkBtnStatusChange");
            Label lblStatus = (Label)e.Item.FindControl("lblStatus");
            if (lblStatus != null)
            {
                if (lblStatus.Text == "1")
                {
                    lnkStatusChange.Text = "Disabled";
                }
                else if (lblStatus.Text == "0")
                {
                    lnkStatusChange.Text = "Enabled";
                }
            }


            var lblcreatedon = e.Item.FindControl("lblCreatedate") as Label;
            string createdate = lblcreatedon.Text;
            if (createdate == null || createdate == "NULL" || createdate == "")
            {

            }
            else
            {
                lblcreatedon.Text = DateTime.Parse(createdate).ToString("dd MMM yyyy");
            }

        }

        //if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
        //{
        //    //identifying the control in DataGrid
        //    ImageButton imgbtnDelete = (ImageButton)e.Item.FindControl("imgbtnDelete");
        //    //raising javascript confirmationbox whenver user clicks on ImageButton
        //    imgbtnDelete.Attributes.Add("onclick", "javascript:return ConfirmationBox()");
        //} 
    }
    /// <summary>
    /// To activate user
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Activate_Click(object sender, EventArgs e)
    {
        for (int i = 0; i < ViewGridWbAdmin.Items.Count; i++)
        {
            CheckBox cbox = (CheckBox)ViewGridWbAdmin.Items[i].FindControl("CheckBoxreq");
            if (cbox.Checked)
            {
                id = Convert.ToInt32(ViewGridWbAdmin.DataKeys[i].ToString());
            }
        }
        con.Open();
        ds = obj.getPerticularWebAdminDetails(id);
        if (!ds.Tables[0].Rows.Count.Equals(0))
        {
            status = Convert.ToInt32(ds.Tables[0].Rows[0]["Status"].ToString());
            Email = Convert.ToString(ds.Tables[0].Rows[0]["email"].ToString());
            //UFName = Convert.ToString(ds.Tables[0].Rows[0]["name"].ToString());
            //ULName = Convert.ToString(ds.Tables[0].Rows[0]["LastName"].ToString());
            //AId = Convert.ToString(ds.Tables[0].Rows[0]["iActiveId"].ToString());

        }
        if (status == 1)
        {
            //obj.aId = id;
            //obj.aStatus = 0;
            //t = obj.WebAdmin_ChangeStatus(obj.aId, obj.aStatus);
            //SendMail(UFName, ULName, Email, AId, Convert.ToString(reg.pStatus), id);
            strScript = "alert('" + Email + " is already enabled.');location.replace('Admin-UserDetails.aspx');";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);

        }
        else if (status == 0)
        {
            obj.aId = id;
            obj.aStatus = 1;
            t = obj.WebAdmin_ChangeStatus(obj.aId, obj.aStatus);
           // SendMail(UFName, ULName, Email, AId, Convert.ToString(reg.pStatus), id);
            strScript = "alert('" + Email + " is successfully enabled.');location.replace('Admin-UserDetails.aspx');";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
        }
        con.Close();
    }
    /// <summary>
    /// To deactivate user
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Deactivate_Click(object sender, EventArgs e)
    {
        for (int i = 0; i < ViewGridWbAdmin.Items.Count; i++)
        {
            CheckBox cbox = (CheckBox)ViewGridWbAdmin.Items[i].FindControl("CheckBoxreq");
            if (cbox.Checked)
            {
                id = Convert.ToInt32(ViewGridWbAdmin.DataKeys[i].ToString());
            }
        }
        con.Open();
        ds = obj.getPerticularWebAdminDetails(id);
        if (!ds.Tables[0].Rows.Count.Equals(0))
        {
            status = Convert.ToInt32(ds.Tables[0].Rows[0]["Status"].ToString());
            Email = Convert.ToString(ds.Tables[0].Rows[0]["email"].ToString());
            //UFName = Convert.ToString(ds.Tables[0].Rows[0]["name"].ToString());
            //ULName = Convert.ToString(ds.Tables[0].Rows[0]["LastName"].ToString());
            //AId = Convert.ToString(ds.Tables[0].Rows[0]["iActiveId"].ToString());

        }
        if (status == 1)
        {
            obj.aId = id;
            obj.aStatus = 0;
            t = obj.WebAdmin_ChangeStatus(obj.aId, obj.aStatus);
            //SendMail(UFName, ULName, Email, AId, Convert.ToString(reg.pStatus), id);
            strScript = "alert('" + Email + " is successfully disabled.');location.replace('Admin-UserDetails.aspx');";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);

        }
        else if (status == 0)
        {
            //obj.aId = id;
            //obj.aStatus = 1;
            //t = obj.WebAdmin_ChangeStatus(obj.aId, obj.aStatus);
            //SendMail(UFName, ULName, Email, AId, Convert.ToString(reg.pStatus), id);
            strScript = "alert('" + Email + " is already disabled.');location.replace('Admin-UserDetails.aspx');";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
        }
        con.Close();
    }

    /// <summary>
    /// executes when select all check box in business category is changed
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void chkBAll_CheckedChanged(object sender, EventArgs e)
    {
        if (chkBAll.Checked == true)
        {
            chkbxBApproval.Checked = true;
            chkbxBDel.Checked = true;
            chkbxBEdit.Checked = true;
            chkbxBPost.Checked = true;
            chkbxBPreview.Checked = true;
        }
        else
        {
            chkbxBApproval.Checked = false;
            chkbxBDel.Checked = false;
            chkbxBEdit.Checked = false;
            chkbxBPost.Checked = false;
            chkbxBPreview.Checked = true;
        }
    }
    /// <summary>
    /// send mail for created user
    /// </summary>
    /// <param name="userid"></param>
    /// <param name="pwd"></param>
    /// <param name="fname"></param>
    /// <param name="lname"></param>
    /// <param name="desg"></param>
    /// <param name="Email"></param>
    /// <param name="country"></param>
    private void SendMail(string userid, string pwd, string fname, string lname, string desg, string Email, string country)
    {
        string Msg = "";
        try
        {
            MailMessage mm = new MailMessage();
            mm.From = new MailAddress("info@justcalluz.com");
            mm.To.Add(Email);
            Msg += "<table border='0'><tr><td><img src='http://www.justcalluz.com/images/logo1.jpg' alt='Company Logo' /></td></tr><tr><td class='data1'>Dear " + fname + " " + lname + ",</td></tr>"
                + "<tr><td height='10px'></td></tr>"
                + "<tr><td><h4>Your account details are as follows:</h4></td></tr>"
                + "<tr><td><h5>User ID : " + userid + "</h5></td></tr>"
                + "<tr><td><h5>Password : " + pwd + "</h5></td></tr>"
                + "<tr><td>Please login with Your following Details.<a href='http://www.justcalluz.com/admin/'>http://www.justcalluz.com/admin/</a></td></tr>"
                + "<tr><td height='20px'></td></tr>"
                + "<tr><td height='50px'></td></tr>"
                + "<tr><td>Regards,</td></tr>"
                + "</table>";

            mm.Subject = "Your " + desg + " Login Details for JustCallUz.";
            mm.IsBodyHtml = true;
            mm.Body = Msg;
            SmtpClient smtp = new SmtpClient();
            smtp.Send(mm);

        }
        catch (Exception ex)
        {

        }
    }
    /// <summary>
    /// executes when select all check box in B2B category is changed
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void chkB2BAll_CheckedChanged(object sender, EventArgs e)
    {
        if (chkB2BAll.Checked == true)
        {
            chkbxB2BApproval.Checked = true;
            chkbxB2BDel.Checked = true;
            chkbxB2BEdit.Checked = true;
            chkbxB2BPost.Checked = true;
            chkbxB2Bview.Checked = true;
        }
        else
        {
            chkbxB2BApproval.Checked = false;
            chkbxB2BDel.Checked = false;
            chkbxB2BEdit.Checked = false;
            chkbxB2BPost.Checked = false;
            chkbxB2Bview.Checked = true;
        }
    }
    /// <summary>
    /// executes when select all check box in jobs category is changed
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void chkJobsAll_CheckedChanged(object sender, EventArgs e)
    {
        if (chkJobsAll.Checked == true)
        {
            chkbxJobsApproval.Checked = true;
            chkbxJobsDel.Checked = true;
            chkbxJobsEdit.Checked = true;
            chkbxJobsPost.Checked = true;
            chkbxJobsview.Checked = true;
        }
        else
        {
            chkbxJobsApproval.Checked = false;
            chkbxJobsDel.Checked = false;
            chkbxJobsEdit.Checked = false;
            chkbxJobsPost.Checked = false;
            chkbxJobsview.Checked = true;
        }
    }
    /// <summary>
    /// executes when select all check box in event category is changed
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void chkEveAll_CheckedChanged(object sender, EventArgs e)
    {
        if (chkEveAll.Checked == true)
        {
            chkbxEveApproval.Checked = true;
            chkbxEveDel.Checked = true;
            chkbxEveEdit.Checked = true;
            chkbxEvePost.Checked = true;
            chkbxEveview.Checked = true;
        }
        else
        {
            chkbxEveApproval.Checked = false;
            chkbxEveDel.Checked = false;
            chkbxEveEdit.Checked = false;
            chkbxEvePost.Checked = false;
            chkbxEveview.Checked = true;
        }
    }
    /// <summary>
    /// executes when select all check box in discounts category is changed
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void chkDisAll_CheckedChanged(object sender, EventArgs e)
    {
        if (chkDisAll.Checked == true)
        {
            chkbxDisApproval.Checked = true;
            chkbxDisDel.Checked = true;
            chkbxDisEdit.Checked = true;
            chkbxDisPost.Checked = true;
            chkbxDisview.Checked = true;
        }
        else
        {
            chkbxDisApproval.Checked = false;
            chkbxDisDel.Checked = false;
            chkbxDisEdit.Checked = false;
            chkbxDisPost.Checked = false;
            chkbxDisview.Checked = true;
        }
    }
    /// <summary>
    ///  executes when select all check box in life style category is changed
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void chkLSAll_CheckedChanged(object sender, EventArgs e)
    {
        if (chkLSAll.Checked == true)
        {
            chkbxLSApproval.Checked = true;
            chkbxLSDel.Checked = true;
            chkbxLSEdit.Checked = true;
            chkbxLSPost.Checked = true;
            chkbxLSview.Checked = true;
        }
        else
        {
            chkbxLSApproval.Checked = false;
            chkbxLSDel.Checked = false;
            chkbxLSEdit.Checked = false;
            chkbxLSPost.Checked = false;
            chkbxLSview.Checked = true;
        }
    }
    /// <summary>
    /// executes when select all check box in careers category is changed
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void chkCareersAll_CheckedChanged(object sender, EventArgs e)
    {
        if (chkCareersAll.Checked == true)
        {
            chkbxCareersDel.Checked = true;
            chkbxCareersEdit.Checked = true;
            chkbxCareersPost.Checked = true;
            chkbxCareersview.Checked = true;
        }
        else
        {
            chkbxCareersDel.Checked = false;
            chkbxCareersEdit.Checked = false;
            chkbxCareersPost.Checked = false;
            chkbxCareersview.Checked = true;
        }

    }


    /// <summary>
    /// executes when select all check box in movies category is changed
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void chkMoviesAll_CheckedChanged(object sender, EventArgs e)
    {
        if (chkMoviesAll.Checked == true)
        {
            chkMoviesDelete.Checked = true;
            chkMoviesEdit.Checked = true;
            chkMoviesPost.Checked = true;
            ChkMoviesView.Checked = true;
        }
        else
        {
            chkMoviesDelete.Checked = false;
            chkMoviesEdit.Checked = false;
            chkMoviesPost.Checked = false;
            ChkMoviesView.Checked = true;
        }
    }
    /// <summary>
    /// executes when select all check box in city trends category is changed
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void chkCTAll_CheckedChanged(object sender, EventArgs e)
    {
        if (chkCTAll.Checked == true)
        {
            chkCTDelete.Checked = true;
            chkCTEdit.Checked = true;
            chkCTPost.Checked = true;
            chkCTView.Checked = true;
        }
        else
        {
            chkCTDelete.Checked = false;
            chkCTEdit.Checked = false;
            chkCTPost.Checked = false;
            chkCTView.Checked = true;
        }
    }
    /// <summary>
    /// executes when select all check box in media speak category is changed
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void chkMSAll_CheckedChanged(object sender, EventArgs e)
    {
        if (chkMSAll.Checked == true)
        {
            chkMSDelete.Checked = true;
            chkMSEdit.Checked = true;
            chkMSPost.Checked = true;
            chkMSView.Checked = true;
        }
        else
        {
            chkMSDelete.Checked = false;
            chkMSEdit.Checked = false;
            chkMSPost.Checked = false;
            chkMSView.Checked = true;
        }
    }
    /// <summary>
    /// executes when select all check box in Ads category is changed
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void chkAdsAll_CheckedChanged(object sender, EventArgs e)
    {
        if (chkAdsAll.Checked == true)
        {
            chkAdsDelete.Checked = true;
            chkAdsEdit.Checked = true;
            chkAdsPost.Checked = true;
            chkAdsView.Checked = true;
        }
        else
        {
            chkAdsDelete.Checked = false;
            chkAdsEdit.Checked = false;
            chkAdsPost.Checked = false;
            chkAdsView.Checked = true;
        }
    }
    /// <summary>
    /// executes when select all check box in free listing category is changed
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void chkFreelistAll_CheckedChanged(object sender, EventArgs e)
    {
        if (chkFreelistAll.Checked == true)
        {
            chkFreelistDelete.Checked = true;
            chkFreelistEdit.Checked = true;
            chkFreelistPost.Checked = true;
            chkFreelistView.Checked = true;
            chkFLApprove.Checked = true;
        }
        else
        {
            chkFreelistDelete.Checked = false;
            chkFreelistEdit.Checked = false;
            chkFreelistPost.Checked = false;
            chkFreelistView.Checked = true;
            chkFLApprove.Checked = false;
        }
    }
    /// <summary>
    /// executes when select all check box in white pages component is changed
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void chkwhiteall_CheckedChanged(object sender, EventArgs e)
    {
        if (chkwhiteall.Checked == true)
        {
            chkwhitepost.Checked = true;
            chkwhiteedit.Checked = true;
            chkwhitedelete.Checked = true;
            chkwhitepreview.Checked = true;
        }
        else
        {
            chkwhitepost.Checked = false;
            chkwhiteedit.Checked = false;
            chkwhitedelete.Checked = false;
            chkwhitepreview.Checked = false;
        }
    }
    /// <summary>
    /// executes when select all check box in Success stories category is changed
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void chksuccessall_CheckedChanged(object sender, EventArgs e)
    {
        if (chksuccessall.Checked == true)
        {
            chksuccesspost.Checked = true;
            chksuccessedit.Checked = true;
            chksuccessdelete.Checked = true;
            chksuccesspreview.Checked = true;
        }
        else
        {
            chksuccesspost.Checked = false;
            chksuccessedit.Checked = false;
            chksuccessdelete.Checked = false;
            chksuccesspreview.Checked = false;
        }
    }
    /// <summary>
    /// executes when select all check box in Corporate social responsibility got changed
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void chkcsrall_CheckedChanged(object sender, EventArgs e)
    {
        if (chkcsrall.Checked == true)
        {
            chkcsrpost.Checked = true;
            chkcsredit.Checked = true;
            chkcsrdelete.Checked = true;
            chkcsrpreview.Checked = true;
        }
        else
        {
            chkcsrpost.Checked = false;
            chkcsredit.Checked = false;
            chkcsrdelete.Checked = false;
            chkcsrpreview.Checked = false;
        }
    }
    /// <summary>
    /// executes when select all check box in Search not found got changed
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void chksnfall_CheckedChanged(object sender, EventArgs e)
    {
        if (chksnfall.Checked == true)
        {
            chksnpost.Checked = true;
            chksnfdelete.Checked = true;
        }
        else
        {
            chksnpost.Checked = false;
            chksnfdelete.Checked = false;
        }
    }

    protected void chkslall_CheckedChanged(object sender, EventArgs e)
    {
        if (chkslall.Checked == true)
        {
            chkslpost.Checked = true;
            chksledit.Checked = true;
            chksldel.Checked = true;
            chkslview.Checked = true;
        }
        else
        {
            chkslpost.Checked = false;
            chksledit.Checked = false;
            chksldel.Checked = false;
            chkslview.Checked = false;
        }
    }
    /// <summary>
    /// click event to update web admin permissions
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnsave_Click(object sender, EventArgs e)
    {
        if (Session["LoginId"] != null)
        {
            if (rbBYes.Checked == true)
            {
                obj.aB = 1;
                if (chkbxBApproval.Checked == true)
                {
                    obj.aBApr = 1;
                }
                else
                {
                    obj.aBApr = 0;
                }
                if (chkbxBDel.Checked == true)
                {
                    obj.aBDel = 1;
                }
                else
                {
                    obj.aBDel = 0;
                }
                if (chkbxBEdit.Checked == true)
                {
                    obj.aBEdit = 1;
                }
                else
                {
                    obj.aBEdit = 0;
                }
                if (chkbxBPost.Checked == true)
                {
                    obj.aBPost = 1;
                }
                else
                {
                    obj.aBPost = 0;
                }
                if (chkbxBPreview.Checked == true)
                {
                    obj.aBView = 1;
                }
                else
                {
                    obj.aBView = 0;
                }
            }
            else
            {
                obj.aB = 0;
                obj.aBApr = 0;
                obj.aBDel = 0;
                obj.aBEdit = 0;
                obj.aBPost = 0;
                obj.aBView = 0;
            }
            if (rbB2BYes.Checked == true)
            {
                obj.aB2B = 1;
                if (chkbxB2BApproval.Checked == true)
                {
                    obj.aB2BApr = 1;
                }
                else
                {
                    obj.aB2BApr = 0;
                }
                if (chkbxB2BDel.Checked == true)
                {
                    obj.aB2BDel = 1;
                }
                else
                {
                    obj.aB2BDel = 0;
                }
                if (chkbxB2BEdit.Checked == true)
                {
                    obj.aB2BEdit = 1;
                }
                else
                {
                    obj.aB2BEdit = 0;
                }
                if (chkbxB2BPost.Checked == true)
                {
                    obj.aB2BPost = 1;
                }
                else
                {
                    obj.aB2BPost = 0;
                }
                if (chkbxB2Bview.Checked == true)
                {
                    obj.aB2BView = 1;
                }
                else
                {
                    obj.aB2BView = 0;
                }
            }
            else
            {
                obj.aB2B = 0;
                obj.aB2BApr = 0;
                obj.aB2BDel = 0;
                obj.aB2BEdit = 0;
                obj.aB2BPost = 0;
                obj.aB2BView = 0;
            }
            if (rbJobsYes.Checked == true)
            {
                obj.aJobs = 1;
                if (chkbxJobsApproval.Checked == true)
                {
                    obj.aJobsApr = 1;
                }
                else
                {
                    obj.aJobsApr = 0;
                }
                if (chkbxJobsDel.Checked == true)
                {
                    obj.aJobsDel = 1;
                }
                else
                {
                    obj.aJobsDel = 0;
                }
                if (chkbxJobsEdit.Checked == true)
                {
                    obj.aJobsEdit = 1;
                }
                else
                {
                    obj.aJobsEdit = 0;
                }
                if (chkbxJobsPost.Checked == true)
                {
                    obj.aJobsPost = 1;
                }
                else
                {
                    obj.aJobsPost = 0;
                }
                if (chkbxJobsview.Checked == true)
                {
                    obj.aJobsView = 1;
                }
                else
                {
                    obj.aJobsView = 0;
                }
            }
            else
            {
                obj.aJobs = 0;
                obj.aJobsApr = 0;
                obj.aJobsDel = 0;
                obj.aJobsEdit = 0;
                obj.aJobsPost = 0;
                obj.aJobsView = 0;
            }
            if (rbEveYes.Checked == true)
            {
                obj.aEve = 1;
                if (chkbxEveApproval.Checked == true)
                {
                    obj.aEveApr = 1;
                }
                else
                {
                    obj.aEveApr = 0;
                }
                if (chkbxEveDel.Checked == true)
                {
                    obj.aEveDel = 1;
                }
                else
                {
                    obj.aEveDel = 0;
                }
                if (chkbxEveEdit.Checked == true)
                {
                    obj.aEveEdit = 1;
                }
                else
                {
                    obj.aJobsEdit = 0;
                }
                if (chkbxJobsPost.Checked == true)
                {
                    obj.aEvePost = 1;
                }
                else
                {
                    obj.aEvePost = 0;
                }
                if (chkbxEveview.Checked == true)
                {
                    obj.aEveView = 1;
                }
                else
                {
                    obj.aEveView = 0;
                }
            }
            else
            {
                obj.aEve = 0;
                obj.aEveApr = 0;
                obj.aEveDel = 0;
                obj.aEveEdit = 0;
                obj.aEvePost = 0;
                obj.aEveView = 0;
            }
            if (rbDisYes.Checked == true)
            {
                obj.aDis = 1;
                if (chkbxDisApproval.Checked == true)
                {
                    obj.aDisApr = 1;
                }
                else
                {
                    obj.aDisApr = 0;
                }
                if (chkbxDisDel.Checked == true)
                {
                    obj.aDisDel = 1;
                }
                else
                {
                    obj.aDisDel = 0;
                }
                if (chkbxDisEdit.Checked == true)
                {
                    obj.aDisEdit = 1;
                }
                else
                {
                    obj.aDisEdit = 0;
                }
                if (chkbxDisPost.Checked == true)
                {
                    obj.aDisPost = 1;
                }
                else
                {
                    obj.aDisPost = 0;
                }
                if (chkbxDisview.Checked == true)
                {
                    obj.aDisView = 1;
                }
                else
                {
                    obj.aDisView = 0;
                }
            }
            else
            {
                obj.aDis = 0;
                obj.aDisApr = 0;
                obj.aDisDel = 0;
                obj.aDisEdit = 0;
                obj.aDisPost = 0;
                obj.aDisView = 0;
            }
            if (rbLSYes.Checked == true)
            {
                obj.aLS = 1;
                if (chkbxLSApproval.Checked == true)
                {
                    obj.aLSApr = 1;
                }
                else
                {
                    obj.aLSApr = 0;
                }
                if (chkbxLSDel.Checked == true)
                {
                    obj.aLSDel = 1;
                }
                else
                {
                    obj.aLSDel = 0;
                }
                if (chkbxLSEdit.Checked == true)
                {
                    obj.aLSEdit = 1;
                }
                else
                {
                    obj.aLSEdit = 0;
                }
                if (chkbxLSPost.Checked == true)
                {
                    obj.aLSPost = 1;
                }
                else
                {
                    obj.aDisPost = 0;
                }
                if (chkbxLSview.Checked == true)
                {
                    obj.aLSView = 1;
                }
                else
                {
                    obj.aLSView = 0;
                }
            }
            else
            {
                obj.aLS = 0;
                obj.aLSApr = 0;
                obj.aLSDel = 0;
                obj.aLSEdit = 0;
                obj.aLSPost = 0;
                obj.aLSView = 0;
            }
            if (rbCareersYes.Checked == true)
            {
                obj.aCareers = 1;
                if (chkbxCareersDel.Checked == true)
                {
                    obj.aCareersDel = 1;
                }
                else
                {
                    obj.aCareersDel = 0;
                }
                if (chkbxCareersEdit.Checked == true)
                {
                    obj.aCareersEdit = 1;
                }
                else
                {
                    obj.aCareersEdit = 0;
                }
                if (chkbxCareersPost.Checked == true)
                {
                    obj.aCareersPost = 1;
                }
                else
                {
                    obj.aCareersPost = 0;
                }
                if (chkbxCareersview.Checked == true)
                {
                    obj.aCareersView = 1;
                }
                else
                {
                    obj.aCareersView = 0;
                }
            }
            else
            {
                obj.aCareers = 0;
                obj.aCareersDel = 0;
                obj.aCareersEdit = 0;
                obj.aCareersPost = 0;
                obj.aCareersView = 0;
            }

            if (rbUInfoYes.Checked == true)
            {
                obj.aUInfo = 1;

            }
            else
            {
                obj.aUInfo = 0;
            }
            if (rbFLYes.Checked == true)
            {
                obj.aFL = 1;
                if (chkFreelistPost.Checked == true)
                {
                    obj.aFLPost = 1;
                }
                else
                {
                    obj.aFLPost = 0;
                }
                if (chkFreelistEdit.Checked == true)
                {
                    obj.aFLEdit = 1;
                }
                else
                {
                    obj.aFLEdit = 0;
                }
                if (chkFreelistDelete.Checked == true)
                {
                    obj.aFLDel = 1;
                }
                else
                {
                    obj.aFLDel = 0;
                }
                if (chkFreelistView.Checked == true)
                {
                    obj.aFLView = 1;
                }
                else
                {
                    obj.aFLView = 0;
                }
                if (chkFLApprove.Checked == true)
                {
                    obj.aFLApr = 1;
                }
                else
                {
                    obj.aFLApr = 0;
                }
            }
            else
            {
                obj.aFL = 0;
                obj.aFLPost = 0;
                obj.aFLEdit = 0;
                obj.aFLDel = 0;
                obj.aFLView = 0;
                obj.aFLApr = 0;
            }
            if (rbAdsYes.Checked == true)
            {
                obj.aAds = 1;
                if (chkAdsDelete.Checked == true)
                {
                    obj.aAdsDel = 1;
                }
                else
                {
                    obj.aAdsDel = 0;
                }
                if (chkAdsEdit.Checked == true)
                {
                    obj.aAdsEdit = 1;
                }
                else
                {
                    obj.aAdsEdit = 0;
                }
                if (chkAdsPost.Checked == true)
                {
                    obj.aAdsPost = 1;
                }
                else
                {
                    obj.aAdsPost = 0;
                }
                if (chkAdsView.Checked == true)
                {
                    obj.aAdsView = 1;
                }
                else
                {
                    obj.aAdsView = 0;
                }
            }
            else
            {
                obj.aAds = 0;
                obj.aAdsDel = 0;
                obj.aAdsEdit = 0;
                obj.aAdsPost = 0;
                obj.aAdsView = 0;
            }
            if (rbMYes.Checked == true)
            {
                obj.aMovies = 1;
                if (chkMoviesDelete.Checked == true)
                {
                    obj.aMoviesDel = 1;
                }
                else
                {
                    obj.aMoviesDel = 0;
                }
                if (chkMoviesEdit.Checked == true)
                {
                    obj.aMoviesEdit = 1;
                }
                else
                {
                    obj.aMoviesEdit = 0;
                }
                if (chkMoviesPost.Checked == true)
                {
                    obj.aMoviesPost = 1;
                }
                else
                {
                    obj.aMoviesPost = 0;
                }
                if (ChkMoviesView.Checked == true)
                {
                    obj.aMoviesView = 1;
                }
                else
                {
                    obj.aMoviesView = 0;
                }
            }
            else
            {
                obj.aMovies = 0;
                obj.aMoviesDel = 0;
                obj.aMoviesEdit = 0;
                obj.aMoviesPost = 0;
                obj.aMoviesView = 0;
            }
            if (rbCTYes.Checked == true)
            {
                obj.aCT = 1;
                if (chkCTDelete.Checked == true)
                {
                    obj.aCTDel = 1;
                }
                else
                {
                    obj.aCTDel = 0;
                }
                if (chkCTEdit.Checked == true)
                {
                    obj.aCTEdit = 1;
                }
                else
                {
                    obj.aCTEdit = 0;
                }
                if (chkCTPost.Checked == true)
                {
                    obj.aCTPost = 1;
                }
                else
                {
                    obj.aCTPost = 0;
                }
                if (chkCTView.Checked == true)
                {
                    obj.aCTView = 1;
                }
                else
                {
                    obj.aCTView = 0;
                }
            }
            else
            {
                obj.aCT = 0;
                obj.aCTDel = 0;
                obj.aCTEdit = 0;
                obj.aCTPost = 0;
                obj.aCTView = 0;
            }
            if (rbMSYes.Checked == true)
            {
                obj.aMS = 1;
                if (chkMSDelete.Checked == true)
                {
                    obj.aMSDel = 1;
                }
                else
                {
                    obj.aMSDel = 0;
                }
                if (chkMSEdit.Checked == true)
                {
                    obj.aMSEdit = 1;
                }
                else
                {
                    obj.aMSEdit = 0;
                }
                if (chkMSPost.Checked == true)
                {
                    obj.aMSPost = 1;
                }
                else
                {
                    obj.aMSPost = 0;
                }
                if (chkMSView.Checked == true)
                {
                    obj.aMSView = 1;
                }
                else
                {
                    obj.aMSView = 0;
                }
            }
            else
            {
                obj.aMS = 0;
                obj.aMSDel = 0;
                obj.aMSEdit = 0;
                obj.aMSPost = 0;
                obj.aMSView = 0;
            }
            //whitepages
            if (rbwpyes.Checked == true)
            {
                obj.awp = 1;
                if (chkwhitedelete.Checked == true)
                {
                    obj.awpDel = 1;
                }
                else
                {
                    obj.awpDel = 0;
                }
                if (chkwhiteedit.Checked == true)
                {
                    obj.awpEdit = 1;
                }
                else
                {
                    obj.awpEdit = 0;
                }
                if (chkwhitepost.Checked == true)
                {
                    obj.awpPost = 1;
                }
                else
                {
                    obj.awpPost = 0;
                }
                if (chkwhitepreview.Checked == true)
                {
                    obj.awpView = 1;
                }
                else
                {
                    obj.awpView = 0;
                }
            }
            else
            {
                obj.awp = 0;
                obj.awpDel = 0;
                obj.awpEdit = 0;
                obj.awpPost = 0;
                obj.awpView = 0;
            }
            //success stories
            if (rbssyes.Checked == true)
            {
                obj.ass = 1;
                if (chksuccessdelete.Checked == true)
                {
                    obj.assDel = 1;
                }
                else
                {
                    obj.assDel = 0;
                }
                if (chksuccessedit.Checked == true)
                {
                    obj.assEdit = 1;
                }
                else
                {
                    obj.assEdit = 0;
                }
                if (chksuccesspost.Checked == true)
                {
                    obj.assPost = 1;
                }
                else
                {
                    obj.assPost = 0;
                }
                if (chksuccesspreview.Checked == true)
                {
                    obj.assView = 1;
                }
                else
                {
                    obj.assView = 0;
                }
            }
            else
            {
                obj.ass = 0;
                obj.assDel = 0;
                obj.assEdit = 0;
                obj.assPost = 0;
                obj.assView = 0;
            }
            //corporate socila responsibility
            if (rbcsryes.Checked == true)
            {
                obj.acsr = 1;
                if (chkcsrdelete.Checked == true)
                {
                    obj.acsrDel = 1;
                }
                else
                {
                    obj.acsrDel = 0;
                }
                if (chkcsredit.Checked == true)
                {
                    obj.acsrEdit = 1;
                }
                else
                {
                    obj.acsrEdit = 0;
                }
                if (chkcsrpost.Checked == true)
                {
                    obj.acsrPost = 1;
                }
                else
                {
                    obj.acsrPost = 0;
                }
                if (chkcsrpreview.Checked == true)
                {
                    obj.acsrView = 1;
                }
                else
                {
                    obj.acsrView = 0;
                }
            }
            else
            {
                obj.acsr = 0;
                obj.acsrDel = 0;
                obj.acsrEdit = 0;
                obj.acsrPost = 0;
                obj.acsrView = 0;
            }
            //search not found
            if (rbsnfyes.Checked == true)
            {
                obj.asnf = 1;
                if (chksnfdelete.Checked == true)
                {
                    obj.asnfDel = 1;
                }
                else
                {
                    obj.asnfDel = 0;
                }
                if (chksnpost.Checked == true)
                {
                    obj.asnfPost = 1;
                }
                else
                {
                    obj.asnfPost = 0;
                }

            }
            else
            {
                obj.asnf = 0;
                obj.asnfDel = 0;
                obj.asnfPost = 0;
            }
            //sponsered links
            if (rbslyes.Checked == true)
            {
                obj.asplnk = 1;
                if (chksldel.Checked == true)
                {
                    obj.asplnkdel = 1;
                }
                else
                {
                    obj.asplnkdel = 0;
                }
                if (chksledit.Checked == true)
                {
                    obj.asplnkedit = 1;
                }
                else
                {
                    obj.asplnkedit = 0;
                }
                if (chkslpost.Checked == true)
                {
                    obj.asplnkpost = 1;
                }
                else
                {
                    obj.asplnkpost = 0;
                }
                if (chkslview.Checked == true)
                {
                    obj.asplnkview = 1;
                }
                else
                {
                    obj.asplnkview = 0;
                }
            }
            else
            {
                obj.asplnk = 0;
                obj.asplnkdel = 0;
                obj.asplnkedit = 0;
                obj.asplnkpost = 0;
                obj.asplnkview = 0;
            }
            //testimonials
            if (rbtestyes.Checked == true)
            {
                obj.atest = 1;
            }
            else
            {
                obj.atest = 0;
            }
            if (rbccareyes.Checked == true)
            {
                obj.accare = 1;
            }
            else
            {
                obj.accare = 0;
            }
            if (rbexyes.Checked == true)
            {
                obj.aexcep = 1;
            }
            else
            {
                obj.aexcep = 0;
            }
            obj.aStatus = 1;
            for (int i = 0; i < ViewGridWbAdmin.Items.Count; i++)
            {
                CheckBox cbox = (CheckBox)ViewGridWbAdmin.Items[i].FindControl("CheckBoxreq");
                if (cbox.Checked)
                {
                    id = Convert.ToInt32(ViewGridWbAdmin.DataKeys[i].ToString());
                }
            }
            con.Open();
            obj.aId = id;
            t = obj.Update_WebAdmin(obj.aId, obj.aB, obj.aBPost, obj.aBEdit, obj.aBDel, obj.aBView, obj.aB2BApr,
                obj.aB2B, obj.aB2BPost, obj.aB2BEdit, obj.aB2BDel, obj.aB2BView, obj.aB2BApr,
                obj.aEve, obj.aEvePost, obj.aEveEdit, obj.aEveDel, obj.aEveView, obj.aEveApr,
                obj.aDis, obj.aDisPost, obj.aDisEdit, obj.aDisDel, obj.aDisView, obj.aDisApr,
                obj.aJobs, obj.aJobsPost, obj.aJobsEdit, obj.aJobsDel, obj.aJobsView, obj.aJobsApr,
                obj.aLS, obj.aLSPost, obj.aLSEdit, obj.aLSDel, obj.aLSView, obj.aLSApr,
                obj.aCareers, obj.aCareersPost, obj.aCareersEdit, obj.aCareersDel, obj.aCareersView,
                obj.aUInfo,
                obj.aFL, obj.aFLPost, obj.aFLEdit, obj.aFLDel, obj.aFLView, obj.aFLApr,
                obj.aAds, obj.aAdsPost, obj.aAdsEdit, obj.aAdsDel, obj.aAdsView,
                obj.aMovies, obj.aMoviesPost, obj.aMoviesEdit, obj.aMoviesDel, obj.aMoviesView,
                obj.aCT, obj.aCTPost, obj.aCTEdit, obj.aCTDel, obj.aCTView, obj.aMS, obj.aMSPost, obj.aMSEdit, obj.aMSDel, obj.aMSView,
                obj.awp, obj.awpPost, obj.awpEdit, obj.awpDel, obj.awpView, obj.ass, obj.assPost, obj.assEdit, obj.assDel,
                obj.assView, obj.acsr, obj.acsrPost, obj.acsrEdit, obj.acsrDel, obj.acsrView, obj.asnf, obj.asnfPost, obj.asnfDel,
                obj.asplnk, obj.asplnkpost, obj.asplnkedit, obj.asplnkdel, obj.asplnkview, obj.atest, obj.accare, obj.aexcep);
            if (t == true)
            {
                con.Close();
                strScript = "alert('Permissions are Updated Sucessfully');location.replace('Admin-UserDetails.aspx');";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "alertbox", strScript, true);
            }
        }

    }
    /// <summary>
    /// click event to cancel update
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void CancelUpdate_Click(object sender, EventArgs e)
    {
        Response.Redirect("Admin-UserDetails.aspx");
    }
    protected void chkUInfoAll_CheckedChanged(object sender, EventArgs e)
    {

    }
    /// <summary>
    /// To check user id availability
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void txteduserid_TextChanged(object sender, EventArgs e)
    {
        DataSet ds = new DataSet();
        //string qry = "select email from Admin_WebAdminCreation where email='" + txtEmail.Text + lblemailExtension.Text + "'";
        string qry = "select UserId from Admin_WebAdminCreation where UserId='" + txteduserid.Text + "'";
        SqlDataAdapter ada = new SqlDataAdapter(qry, con);
        ada.Fill(ds);
        if (!ds.Tables[0].Rows.Count.Equals(0))
        {
            lblstatus.Text = "User Id Already Exist";
            lblstatus.ForeColor = System.Drawing.Color.Red;
        }
        else
        {
            lblstatus.Text = "User Id Available";
            lblstatus.ForeColor = System.Drawing.Color.Green;
        }
        BindUser_Details();
        
    }
  


   
}