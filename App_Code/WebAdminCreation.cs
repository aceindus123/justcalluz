using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;
using IndusAbroad.DataAccessLayer;
/// <summary>
/// Summary description for WebAdminCreation
/// </summary>
public class WebAdminCreation
{
    SqlConnection con=new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    public DataAccess obj = new DataAccess();
	public WebAdminCreation()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    private Int32 Id;
    private string FirstName;
    private string LastName;
    private string EmailId;
    private string Password;
    private int Status;
    private string AdminType;
    private string Country;
    private string UserId;
    private string Address;   
    private string Phone;   
    private string Mobile;   


    private int B;
    private int BPost;
    private int BEdit;
    private int BDel;
    private int BView;
    private int BApr;

    private int B2B;
    private int B2BPost;
    private int B2BEdit;
    private int B2BDel;
    private int B2BView;
    private int B2BApr;

    private int Eve;
    private int EvePost;
    private int EveEdit;
    private int EveDel;
    private int EveView;
    private int EveApr;

    private int Dis;
    private int DisPost;
    private int DisEdit;
    private int DisDel;
    private int DisView;
    private int DisApr;

    private int Job;
    private int JobPost;
    private int JobEdit;
    private int JobDel;
    private int JobView;
    private int JobApr;

    private int LS;
    private int LSPost;
    private int LSEdit;
    private int LSDel;
    private int LSView;
    private int LSApr;

    private int Careers;
    private int CareersPost;
    private int CareersEdit;
    private int CareersDel;
    private int CareersView;
    private int CareersApr;
    private int UInfo;
    private int FL;
    private int FLPost;
    private int FLEdit;
    private int FLDel;
    private int FLView;
    private int FLApr;

    private int Ads;
    private int AdsPost;
    private int AdsEdit;
    private int AdsDel;
    private int AdsView;

    private int Movies;
    private int MoviesPost;
    private int MoviesEdit;
    private int MoviesDel;
    private int MoviesView;

    private int CT;
    private int CTPost;
    private int CTEdit;
    private int CTDel;
    private int CTView;

    private int MS;
    private int MSPost;
    private int MSEdit;
    private int MSDel;
    private int MSView;

    private int wp, wppost, wpedit, wpdel, wpview;
    private int ss, sspost, ssedit, ssdel, ssview;
    private int csr, csrpost, csredit, csrdel, csrview;
    private int snf, snfpost, snfdel;
    private int splnk, splnkpost, splnkedit, splnkdel, splnkview;
    private int test, ccare, excep;

    public Int32 aId
    {
        get { return Id; }
        set { Id = value; }
    }
    public string WFirstName
    {
        get { return FirstName; }
        set { FirstName = value; }
    }
    public string WLastName
    {
        get { return LastName; }
        set { LastName = value; }
    }
    public string WEmailId
    {
        get { return EmailId; }
        set { EmailId = value; }
    }
    public string WPassword
    {
        get { return Password; }
        set { Password = value; }
    }
    public int aStatus
    {
        get { return Status; }
        set { Status = value; }
    }

    public string WAdminType
    {
        get { return AdminType; }
        set { AdminType = value; }
    }
    public string WCountry
    {
        get { return Country; }
        set { Country = value; }
    }

    public string WUserId
    {
        get { return UserId; }
        set { UserId = value; }
    }
    public string WAddress
    {
        get { return Address; }
        set { Address = value; }
    }
    public string WPhone
    {
        get { return Phone; }
        set { Phone = value; }
    }
    public string WMobile
    {
        get { return Mobile; }
        set { Mobile = value; }
    }
    public int aB
    {
        get { return B; }
        set { B = value; }
    }
    public int aBPost
    {
        get { return BPost; }
        set { BPost = value; }
    }
    public int aBDel
    {
        get { return BDel; }
        set { BDel = value; }
    }
    public int aBEdit
    {
        get { return BEdit; }
        set { BEdit = value; }
    }
    public int aBView
    {
        get { return BView; }
        set { BView = value; }
    }
    public int aBApr
    {
        get { return BApr; }
        set { BApr = value; }
    }

    public int aB2B
    {
        get { return B2B; }
        set { B2B = value; }
    }
    public int aB2BApr
    {
        get { return B2BApr; }
        set { B2BApr = value; }
    }
    public int aB2BDel
    {
        get { return B2BDel; }
        set { B2BDel = value; }
    }
    public int aB2BEdit
    {
        get { return B2BEdit; }
        set { B2BEdit = value; }
    }
    public int aB2BPost
    {
        get { return B2BPost; }
        set { B2BPost = value; }
    }
    public int aB2BView
    {
        get { return B2BView; }
        set { B2BView = value; }
    }

    public int aJobs
    {
        get { return Job; }
        set { Job = value; }
    }
    public int aJobsApr
    {
        get { return JobApr; }
        set { JobApr = value; }
    }
    public int aJobsDel
    {
        get { return JobDel; }
        set { JobDel = value; }
    }
    public int aJobsEdit
    {
        get { return JobEdit; }
        set { JobEdit = value; }
    }
    public int aJobsPost
    {
        get { return JobPost; }
        set { JobPost = value; }
    }
    public int aJobsView
    {
        get { return JobView; }
        set { JobView = value; }
    }
    public int aEve
    {
        get { return Eve; }
        set { Eve = value; }
    }
    public int aEveApr
    {
        get { return EveApr; }
        set { EveApr = value; }
    }
    public int aEveDel
    {
        get { return EveDel; }
        set { EveDel = value; }
    }
    public int aEveEdit
    {
        get { return EveEdit; }
        set { EveEdit = value; }
    }
    public int aEvePost
    {
        get { return EvePost; }
        set { EvePost = value; }
    }
    public int aEveView
    {
        get { return EveView; }
        set { EveView = value; }
    }

    public int aDis
    {
        get { return Dis; }
        set { Dis = value; }
    }
    public int aDisApr
    {
        get { return DisApr; }
        set { DisApr = value; }
    }
    public int aDisDel
    {
        get { return DisDel; }
        set { DisDel = value; }
    }
    public int aDisEdit
    {
        get { return DisEdit; }
        set { DisEdit = value; }
    }
    public int aDisPost
    {
        get { return DisPost; }
        set { DisPost = value; }
    }
    public int aDisView
    {
        get { return DisView; }
        set { DisView = value; }
    }
    public int aLS
    {
        get { return LS; }
        set { LS = value; }
    }
    public int aLSApr
    {
        get { return LSApr; }
        set { LSApr = value; }
    }
    public int aLSDel
    {
        get { return LSDel; }
        set { LSDel = value; }
    }
    public int aLSEdit
    {
        get { return LSEdit; }
        set { LSEdit = value; }
    }
    public int aLSPost
    {
        get { return LSPost; }
        set { LSPost = value; }
    }
    public int aLSView
    {
        get { return LSView; }
        set { LSView = value; }
    }

    public int aCareers
    {
        get { return Careers; }
        set { Careers = value; }
    }
    public int aCareersApr
    {
        get { return CareersApr; }
        set { CareersApr = value; }
    }
    public int aCareersDel
    {
        get { return CareersDel; }
        set { CareersDel = value; }
    }
    public int aCareersEdit
    {
        get { return CareersEdit; }
        set { CareersEdit = value; }
    }
    public int aCareersPost
    {
        get { return CareersPost; }
        set { CareersPost = value; }
    }
    public int aCareersView
    {
        get { return CareersView; }
        set { CareersView = value; }
    }

    
    public int aUInfo
    {
        get { return UInfo; }
        set { UInfo = value; }
    }
    
    public int aFL
    {
        get { return FL; }
        set { FL = value; }
    }
    public int aFLPost
    {
        get { return FLPost; }
        set { FLPost = value; }
    }
    public int aFLEdit
    {
        get { return FLEdit; }
        set { FLEdit = value; }
    }
    public int aFLDel
    {
        get { return FLDel; }
        set { FLDel = value; }
    }
    public int aFLView
    {
        get { return FLView; }
        set { FLView = value; }
    }
    public int aFLApr
    {
        get { return FLApr; }
        set { FLApr = value; }
    }
    public int aAds
    {
        get { return Ads; }
        set { Ads = value; }
    }
    public int aAdsPost
    {
        get { return AdsPost; }
        set { AdsPost = value; }
    }
    public int aAdsEdit
    {
        get { return AdsEdit; }
        set { AdsEdit = value; }
    }
    public int aAdsDel
    {
        get { return AdsDel; }
        set { AdsDel = value; }
    }
    public int aAdsView
    {
        get { return AdsView; }
        set { AdsView = value; }
    }
    public int aMovies
    {
        get { return Movies; }
        set { Movies = value; }
    }
    public int aMoviesPost
    {
        get { return MoviesPost; }
        set { MoviesPost = value; }
    }
    public int aMoviesEdit
    {
        get { return MoviesEdit; }
        set { MoviesEdit = value; }
    }
    public int aMoviesDel
    {
        get { return MoviesDel; }
        set { MoviesDel = value; }
    }
    public int aMoviesView
    {
        get { return MoviesView; }
        set { MoviesView = value; }
    }
    public int aCT
    {
        get { return CT; }
        set { CT = value; }
    }
    public int aCTPost
    {
        get { return CTPost; }
        set { CTPost = value; }
    }
    public int aCTEdit
    {
        get { return CTEdit; }
        set { CTEdit = value; }
    }
    public int aCTDel
    {
        get { return CTDel; }
        set { CTDel = value; }
    }
    public int aCTView
    {
        get { return CTView; }
        set { CTView = value; }
    }
    public int aMS
    {
        get { return MS; }
        set { MS = value; }
    }
    public int aMSPost
    {
        get { return MSPost; }
        set { MSPost = value; }
    }
    public int aMSEdit
    {
        get { return MSEdit; }
        set { MSEdit = value; }
    }
    public int aMSDel
    {
        get { return MSDel; }
        set { MSDel = value; }
    }
    public int aMSView
    {
        get { return MSView; }
        set { MSView = value; }
    }
    public int awp
    {
        get { return wp; }
        set { wp = value; }
    }
    public int awpPost
    {
        get { return wppost; }
        set { wppost = value; }
    }
    public int awpEdit
    {
        get { return wpedit; }
        set { wpedit = value; }
    }
    public int awpDel
    {
        get { return wpdel; }
        set { wpdel = value; }
    }
    public int awpView
    {
        get { return wpview; }
        set { wpview = value; }
    }
    public int ass
    {
        get { return ss; }
        set { ss = value; }
    }
    public int assPost
    {
        get { return sspost; }
        set { sspost = value; }
    }
    public int assEdit
    {
        get { return ssedit; }
        set { ssedit = value; }
    }
    public int assDel
    {
        get { return ssdel; }
        set { ssdel = value; }
    }
    public int assView
    {
        get { return ssview; }
        set { ssview = value; }
    }
    public int acsr
    {
        get { return csr; }
        set { csr = value; }
    }
    public int acsrPost
    {
        get { return csrpost; }
        set { csrpost = value; }
    }
    public int acsrEdit
    {
        get { return csredit; }
        set { csredit = value; }
    }
    public int acsrDel
    {
        get { return csrdel; }
        set { csrdel = value; }
    }
    public int acsrView
    {
        get { return csrview; }
        set { csrview = value; }
    }
    public int asnf
    {
        get { return snf; }
        set { snf = value; }
    }
    public int asnfPost
    {
        get { return snfpost; }
        set { snfpost = value; }
    }
    public int asnfDel
    {
        get { return snfdel; }
        set { snfdel = value; }
    }
    public int asplnk
    {
        get { return splnk; }
        set { splnk = value; }
    }
    public int asplnkpost
    {
        get { return splnkpost; }
        set { splnkpost = value; }
    }
    public int asplnkedit
    {
        get { return splnkedit; }
        set { splnkedit = value; }
    }
    public int asplnkdel
    {
        get { return splnkdel; }
        set { splnkdel = value; }
    }
    public int asplnkview
    {
        get { return splnkview; }
        set { splnkview = value; }
    }
    public int atest
    {
        get { return test; }
        set { splnkview = value; }
    }
    public int accare
    {
        get { return ccare; }
        set { ccare = value; }
    }
    public int aexcep
    {
        get { return excep; }
        set { excep = value; }
    }
    public bool CreateWebAdmin(string FName, string LName, string Email, string Pwd,int B,int BPost,int BEdit,int BDel,int BView,int BApr,
                                int B2B,int B2BPost,int B2BEdit,int B2BDel,int B2BView,int B2BApr,int Eve,int EvePost,int EveEdit,int EveDel,
                                int EveView,int EveApr,int Dis,int DisPost,int DisEdit,int DisDel,int DisView,int DisApr,int Job,int JobPost,
                                int JobEdit,int JobDel,int JobView,int JobApr,int LS,int LSPost,int LSEdit,int LSDel,int LSView,int LSApr,int Careers,
                                int CareersPost,int CareersEdit,int CareersDel,int CareersView,
                                int UInfo,int status,
                                int FL,int FLPost,int FLEdit,int FLDel,int FLView,int FLApr,int Ads,int AdsPost,int AdsEdit,int AdsDel,int AdsView,
                                int Movies,int MoviesPost,int MoviesEdit,int MoviesDel,int MoviesView,int CT,int CTPost,int CTEdit,int CTDel,int CTView,
                                int MS,int MSPost,int MSEdit,int MSDel,int MSView,int wp,int wppost,int wpedit,int wpdel,int wpview,int ss,int sspost,
                                int ssedit,int ssdel,int ssview,int csr,int csrpost,int csredit,int csrdel,int csrview,int snf,int snfpost,int snfdel,
                                int splnk,int splnkpost,int splnkedit,int splnkdel,int splnkview,int test,int ccare,int excep,string admintype, string country,string userid,
                                string addrs,string phno,string mobile)
    {
        con.Open();
        SqlTransaction myTrans = con.BeginTransaction();
        SqlParameter[] parm = new SqlParameter[105];
        parm[0] = new SqlParameter("@fname", SqlDbType.NVarChar);
        parm[0].Value = FName;
        parm[1] = new SqlParameter("@lname", SqlDbType.NVarChar);
        parm[1].Value = LName;
        parm[2] = new SqlParameter("@email", SqlDbType.NVarChar);
        parm[2].Value = Email;
        parm[3] = new SqlParameter("@pwd", SqlDbType.NVarChar);
        parm[3].Value = Pwd;
        parm[4] = new SqlParameter("@B", SqlDbType.Int);
        parm[4].Value = B;
        parm[5] = new SqlParameter("@BPost", SqlDbType.Int);
        parm[5].Value =BPost ;
        parm[6] = new SqlParameter("@BEdit", SqlDbType.Int);
        parm[6].Value = BEdit;
        parm[7] = new SqlParameter("@BDel", SqlDbType.Int);
        parm[7].Value = BDel;
        parm[8] = new SqlParameter("@BView", SqlDbType.Int);
        parm[8].Value = BView;
        parm[9] = new SqlParameter("@BApr", SqlDbType.Int);
        parm[9].Value = BApr;
        parm[10] = new SqlParameter("@B2B", SqlDbType.Int);
        parm[10].Value = B2B;
        parm[11] = new SqlParameter("@B2BApr", SqlDbType.Int);
        parm[11].Value = B2BApr;
        parm[12] = new SqlParameter("@B2BDel", SqlDbType.Int);
        parm[12].Value = B2BDel;
        parm[13] = new SqlParameter("@B2BEdit", SqlDbType.Int);
        parm[13].Value = B2BEdit;
        parm[14] = new SqlParameter("@B2BPost", SqlDbType.Int);
        parm[14].Value = B2BPost;
        parm[15] = new SqlParameter("@B2BView", SqlDbType.Int);
        parm[15].Value = B2BView;
        parm[16] = new SqlParameter("@Job", SqlDbType.Int);
        parm[16].Value = Job;
        parm[17] = new SqlParameter("@JobApr", SqlDbType.Int);
        parm[17].Value = JobApr;
        parm[18] = new SqlParameter("@JobDel", SqlDbType.Int);
        parm[18].Value = JobDel;
        parm[19] = new SqlParameter("@JobEdit", SqlDbType.Int);
        parm[19].Value = JobEdit;
        parm[20] = new SqlParameter("@JobPost", SqlDbType.Int);
        parm[20].Value = JobPost;
        parm[21] = new SqlParameter("@JobView", SqlDbType.Int);
        parm[21].Value = JobView;
        parm[22] = new SqlParameter("@Eve", SqlDbType.Int);
        parm[22].Value = Eve;
        parm[23] = new SqlParameter("@EveApr", SqlDbType.Int);
        parm[23].Value = EveApr;
        parm[24] = new SqlParameter("@EveDel", SqlDbType.Int);
        parm[24].Value = EveDel;
        parm[25] = new SqlParameter("@EveEdit", SqlDbType.Int);
        parm[25].Value = EveEdit;
        parm[26] = new SqlParameter("@EvePost", SqlDbType.Int);
        parm[26].Value = EvePost;
        parm[27] = new SqlParameter("@EveView", SqlDbType.Int);
        parm[27].Value = EveView;
        parm[28] = new SqlParameter("@Dis", SqlDbType.Int);
        parm[28].Value = Dis;
        parm[29] = new SqlParameter("@DisApr", SqlDbType.Int);
        parm[29].Value = DisApr;
        parm[30] = new SqlParameter("@DisDel", SqlDbType.Int);
        parm[30].Value = DisDel;
        parm[31] = new SqlParameter("@DisEdit", SqlDbType.Int);
        parm[31].Value = DisEdit;
        parm[32] = new SqlParameter("@DisPost", SqlDbType.Int);
        parm[32].Value = DisPost;
        parm[33] = new SqlParameter("@DisView", SqlDbType.Int);
        parm[33].Value = DisView;
        parm[34] = new SqlParameter("@LS", SqlDbType.Int);
        parm[34].Value = LS;
        parm[35] = new SqlParameter("@LSApr", SqlDbType.Int);
        parm[35].Value = LSApr;
        parm[36] = new SqlParameter("@LSDel", SqlDbType.Int);
        parm[36].Value = LSDel;
        parm[37] = new SqlParameter("@LSEdit", SqlDbType.Int);
        parm[37].Value = LSEdit;
        parm[38] = new SqlParameter("@LSPost", SqlDbType.Int);
        parm[38].Value = LSPost;
        parm[39] = new SqlParameter("@LSView", SqlDbType.Int);
        parm[39].Value = LSView;
        parm[40] = new SqlParameter("@Careers", SqlDbType.Int);
        parm[40].Value = Careers;
        parm[41] = new SqlParameter("@CareersDel", SqlDbType.Int);
        parm[41].Value = CareersDel;
        parm[42] = new SqlParameter("@CareersEdit", SqlDbType.Int);
        parm[42].Value = CareersEdit;
        parm[43] = new SqlParameter("@CareersPost", SqlDbType.Int);
        parm[43].Value = CareersPost;
        parm[44] = new SqlParameter("@CareersView", SqlDbType.Int);
        parm[44].Value = CareersView;
        parm[45] = new SqlParameter("@UInfo", SqlDbType.Int);
        parm[45].Value = UInfo;
        parm[46] = new SqlParameter("@Status", SqlDbType.Int);
        parm[46].Value = status;
        parm[47] = new SqlParameter("@AdminType", SqlDbType.NVarChar);
        parm[47].Value = admintype;
        parm[48] = new SqlParameter("@FL", SqlDbType.Int);
        parm[48].Value = FL;
        parm[49] = new SqlParameter("@FLPost", SqlDbType.Int);
        parm[49].Value = FLPost;
        parm[50] = new SqlParameter("@FLEdit", SqlDbType.Int);
        parm[50].Value = FLEdit;
        parm[51] = new SqlParameter("@FLDel", SqlDbType.Int);
        parm[51].Value = FLDel;
        parm[52] = new SqlParameter("@FLView", SqlDbType.Int);
        parm[52].Value = FLView;
        parm[53] = new SqlParameter("@FLApr", SqlDbType.Int);
        parm[53].Value = FLApr;
        parm[54] = new SqlParameter("@Ads", SqlDbType.Int);
        parm[54].Value = Ads;
        parm[55] = new SqlParameter("@AdsPost", SqlDbType.Int);
        parm[55].Value = AdsPost;
        parm[56] = new SqlParameter("@AdsEdit", SqlDbType.Int);
        parm[56].Value = AdsEdit;
        parm[57] = new SqlParameter("@AdsDel", SqlDbType.Int);
        parm[57].Value = AdsDel;
        parm[58] = new SqlParameter("@AdsView", SqlDbType.Int);
        parm[58].Value = AdsView;
        parm[59] = new SqlParameter("@Movies", SqlDbType.Int);
        parm[59].Value = Movies;
        parm[60] = new SqlParameter("@MoviesPost", SqlDbType.Int);
        parm[60].Value = MoviesPost;
        parm[61] = new SqlParameter("@MoviesEdit", SqlDbType.Int);
        parm[61].Value = MoviesEdit;
        parm[62] = new SqlParameter("@MoviesDel", SqlDbType.Int);
        parm[62].Value = MoviesDel;
        parm[63] = new SqlParameter("@MoviesView", SqlDbType.Int);
        parm[63].Value = MoviesView;
        parm[64] = new SqlParameter("@CT", SqlDbType.Int);
        parm[64].Value = CT;
        parm[65] = new SqlParameter("@CTPost", SqlDbType.Int);
        parm[65].Value = CTPost;
        parm[66] = new SqlParameter("@CTEdit", SqlDbType.Int);
        parm[66].Value = CTEdit;
        parm[67] = new SqlParameter("@CTDel", SqlDbType.Int);
        parm[67].Value = CTDel;
        parm[68] = new SqlParameter("@CTView", SqlDbType.Int);
        parm[68].Value = CTView;
        parm[69] = new SqlParameter("@MS", SqlDbType.Int);
        parm[69].Value = MS;
        parm[70] = new SqlParameter("@MSPost", SqlDbType.Int);
        parm[70].Value = MSPost;
        parm[71] = new SqlParameter("@MSEdit", SqlDbType.Int);
        parm[71].Value = MSEdit;
        parm[72] = new SqlParameter("@MSDel", SqlDbType.Int);
        parm[72].Value = MSDel;
        parm[73] = new SqlParameter("@MSView", SqlDbType.Int);
        parm[73].Value = MSView;
        parm[74] = new SqlParameter("@WP", SqlDbType.Int);
        parm[74].Value = wp;
        parm[75] = new SqlParameter("@WPpost", SqlDbType.Int);
        parm[75].Value = wppost;
        parm[76] = new SqlParameter("@WPEdit", SqlDbType.Int);
        parm[76].Value = wpedit;
        parm[77] = new SqlParameter("@WPDel", SqlDbType.Int);
        parm[77].Value = wpdel;
        parm[78] = new SqlParameter("@WPView", SqlDbType.Int);
        parm[78].Value = wpview;
        parm[79] = new SqlParameter("@SS", SqlDbType.Int);
        parm[79].Value = ss;
        parm[80] = new SqlParameter("@SSPost", SqlDbType.Int);
        parm[80].Value = sspost;
        parm[81] = new SqlParameter("@SSEdit", SqlDbType.Int);
        parm[81].Value = ssedit;
        parm[82] = new SqlParameter("@SSDel", SqlDbType.Int);
        parm[82].Value = ssdel;
        parm[83] = new SqlParameter("@SSView", SqlDbType.Int);
        parm[83].Value = ssview;
        parm[84] = new SqlParameter("@CSR", SqlDbType.Int);
        parm[84].Value = csr;
        parm[85] = new SqlParameter("@CSRPost", SqlDbType.Int);
        parm[85].Value = csrpost;
        parm[86] = new SqlParameter("@CSREdit", SqlDbType.Int);
        parm[86].Value = csredit;
        parm[87] = new SqlParameter("@CSRDel", SqlDbType.Int);
        parm[87].Value = csrdel;
        parm[88] = new SqlParameter("@CSRView", SqlDbType.Int);
        parm[88].Value = csrview;
        parm[89] = new SqlParameter("@SNF", SqlDbType.Int);
        parm[89].Value = snf;
        parm[90] = new SqlParameter("@SNFPost", SqlDbType.Int);
        parm[90].Value = snfpost;
        parm[91] = new SqlParameter("@SNFDel", SqlDbType.Int);
        parm[91].Value = snfdel;
        parm[92] = new SqlParameter("@splnk", SqlDbType.Int);
        parm[92].Value = splnk;
        parm[93] = new SqlParameter("@splnkpost", SqlDbType.Int);
        parm[93].Value = splnkpost;
        parm[94] = new SqlParameter("@splnkedit", SqlDbType.Int);
        parm[94].Value = splnkedit;
        parm[95] = new SqlParameter("@splnkdel", SqlDbType.Int);
        parm[95].Value = splnkdel;
        parm[96] = new SqlParameter("@splnkview", SqlDbType.Int);
        parm[96].Value = splnkview;
        parm[97] = new SqlParameter("@test", SqlDbType.Int);
        parm[97].Value = test;
        parm[98] = new SqlParameter("@ccare", SqlDbType.Int);
        parm[98].Value = ccare;
        parm[99] = new SqlParameter("@excep", SqlDbType.Int);
        parm[99].Value = excep;
        //parm[98] = new SqlParameter("@AdminType", SqlDbType.Int);
        //parm[98].Value = admintype;
        parm[100] = new SqlParameter("@Country", SqlDbType.NVarChar);
        parm[100].Value = country;
        parm[101] = new SqlParameter("@UserId", SqlDbType.NVarChar);
        parm[101].Value = userid;
        parm[102] = new SqlParameter("@Address", SqlDbType.NVarChar);
        parm[102].Value = addrs;
        parm[103] = new SqlParameter("@Phone", SqlDbType.NVarChar);
        parm[103].Value = phno;
        parm[104] = new SqlParameter("@Mobile", SqlDbType.NVarChar);
        parm[104].Value = mobile;
        DBOperations.ExecuteNonQuery(myTrans, CommandType.StoredProcedure, "AdminWebUser_creation", parm);
        myTrans.Commit();
        con.Close();
        return true;
    }
    public bool Update_WebAdmin(Int32 id, int B, int BPost, int BEdit, int BDel, int BView, int BApr,
                                int B2B, int B2BPost, int B2BEdit, int B2BDel, int B2BView, int B2BApr, int Eve, int EvePost, int EveEdit, int EveDel,
                                int EveView, int EveApr, int Dis, int DisPost, int DisEdit, int DisDel, int DisView, int DisApr, int Job, int JobPost,
                                int JobEdit, int JobDel, int JobView, int JobApr, int LS, int LSPost, int LSEdit, int LSDel, int LSView, int LSApr, int Careers,
                                int CareersPost, int CareersEdit, int CareersDel, int CareersView, int UInfo, 
                                int FL, int FLPost, int FLEdit, int FLDel, int FLView, int FLApr, int Ads, int AdsPost, int AdsEdit, int AdsDel, int AdsView,
                                int Movies, int MoviesPost, int MoviesEdit, int MoviesDel, int MoviesView, int CT, int CTPost, int CTEdit, int CTDel, int CTView,
                                int MS, int MSPost, int MSEdit, int MSDel, int MSView, int wp, int wppost, int wpedit, int wpdel, int wpview, int ss, int sspost,
                                int ssedit, int ssdel, int ssview, int csr, int csrpost, int csredit, int csrdel, int csrview, int snf, int snfpost, int snfdel,
                                int splnk,int splnkpost,int splnkedit,int splnkdel,int splnkview,int test,int ccare,int excep)
    {
        con.Open();
        SqlTransaction myTrans = con.BeginTransaction();
        SqlParameter[] parm = new SqlParameter[95];
        parm[0] = new SqlParameter("@Id", SqlDbType.Int);
        parm[0].Value = id;
        parm[1] = new SqlParameter("@B", SqlDbType.Int);
        parm[1].Value = B;
        parm[2] = new SqlParameter("@BPost", SqlDbType.Int);
        parm[2].Value = BPost;
        parm[3] = new SqlParameter("@BEdit", SqlDbType.Int);
        parm[3].Value = BEdit;
        parm[4] = new SqlParameter("@BDel", SqlDbType.Int);
        parm[4].Value = BDel;
        parm[5] = new SqlParameter("@BView", SqlDbType.Int);
        parm[5].Value = BView;
        parm[6] = new SqlParameter("@BApr", SqlDbType.Int);
        parm[6].Value = BApr;
        parm[7] = new SqlParameter("@B2B", SqlDbType.Int);
        parm[7].Value = B2B;
        parm[8] = new SqlParameter("@B2BApr", SqlDbType.Int);
        parm[8].Value = B2BApr;
        parm[9] = new SqlParameter("@B2BDel", SqlDbType.Int);
        parm[9].Value = B2BDel;
        parm[10] = new SqlParameter("@B2BEdit", SqlDbType.Int);
        parm[10].Value = B2BEdit;
        parm[11] = new SqlParameter("@B2BPost", SqlDbType.Int);
        parm[11].Value = B2BPost;
        parm[12] = new SqlParameter("@B2BView", SqlDbType.Int);
        parm[12].Value = B2BView;
        parm[13] = new SqlParameter("@Job", SqlDbType.Int);
        parm[13].Value = Job;
        parm[14] = new SqlParameter("@JobApr", SqlDbType.Int);
        parm[14].Value = JobApr;
        parm[15] = new SqlParameter("@JobDel", SqlDbType.Int);
        parm[15].Value = JobDel;
        parm[16] = new SqlParameter("@JobEdit", SqlDbType.Int);
        parm[16].Value = JobEdit;
        parm[17] = new SqlParameter("@JobPost", SqlDbType.Int);
        parm[17].Value = JobPost;
        parm[18] = new SqlParameter("@JobView", SqlDbType.Int);
        parm[18].Value = JobView;
        parm[19] = new SqlParameter("@Eve", SqlDbType.Int);
        parm[19].Value = Eve;
        parm[20] = new SqlParameter("@EveApr", SqlDbType.Int);
        parm[20].Value = EveApr;
        parm[21] = new SqlParameter("@EveDel", SqlDbType.Int);
        parm[21].Value = EveDel;
        parm[22] = new SqlParameter("@EveEdit", SqlDbType.Int);
        parm[22].Value = EveEdit;
        parm[23] = new SqlParameter("@EvePost", SqlDbType.Int);
        parm[23].Value = EvePost;
        parm[24] = new SqlParameter("@EveView", SqlDbType.Int);
        parm[24].Value = EveView;
        parm[25] = new SqlParameter("@Dis", SqlDbType.Int);
        parm[25].Value = Dis;
        parm[26] = new SqlParameter("@DisApr", SqlDbType.Int);
        parm[26].Value = DisApr;
        parm[27] = new SqlParameter("@DisDel", SqlDbType.Int);
        parm[27].Value = DisDel;
        parm[28] = new SqlParameter("@DisEdit", SqlDbType.Int);
        parm[28].Value = DisEdit;
        parm[29] = new SqlParameter("@DisPost", SqlDbType.Int);
        parm[29].Value = DisPost;
        parm[30] = new SqlParameter("@DisView", SqlDbType.Int);
        parm[30].Value = DisView;
        parm[31] = new SqlParameter("@LS", SqlDbType.Int);
        parm[31].Value = LS;
        parm[32] = new SqlParameter("@LSApr", SqlDbType.Int);
        parm[32].Value = LSApr;
        parm[33] = new SqlParameter("@LSDel", SqlDbType.Int);
        parm[33].Value = LSDel;
        parm[34] = new SqlParameter("@LSEdit", SqlDbType.Int);
        parm[34].Value = LSEdit;
        parm[35] = new SqlParameter("@LSPost", SqlDbType.Int);
        parm[35].Value = LSPost;
        parm[36] = new SqlParameter("@LSView", SqlDbType.Int);
        parm[36].Value = LSView;
        parm[37] = new SqlParameter("@Careers", SqlDbType.Int);
        parm[37].Value = Careers;
        parm[38] = new SqlParameter("@CareersDel", SqlDbType.Int);
        parm[38].Value = CareersDel;
        parm[39] = new SqlParameter("@CareersEdit", SqlDbType.Int);
        parm[39].Value = CareersEdit;
        parm[40] = new SqlParameter("@CareersPost", SqlDbType.Int);
        parm[40].Value = CareersPost;
        parm[41] = new SqlParameter("@CareersView", SqlDbType.Int);
        parm[41].Value = CareersView;
        parm[42] = new SqlParameter("@UInfo", SqlDbType.Int);
        parm[42].Value = UInfo;
        parm[43] = new SqlParameter("@FL", SqlDbType.Int);
        parm[43].Value = FL;
        parm[44] = new SqlParameter("@FLPost", SqlDbType.Int);
        parm[44].Value = FLPost;
        parm[45] = new SqlParameter("@FLEdit", SqlDbType.Int);
        parm[45].Value = FLEdit;
        parm[46] = new SqlParameter("@FLDel", SqlDbType.Int);
        parm[46].Value = FLDel;
        parm[47] = new SqlParameter("@FLView", SqlDbType.Int);
        parm[47].Value = FLView;
        parm[48] = new SqlParameter("@FLApr", SqlDbType.Int);
        parm[48].Value = FLApr;
        parm[49] = new SqlParameter("@Ads", SqlDbType.Int);
        parm[49].Value = Ads;
        parm[50] = new SqlParameter("@AdsPost", SqlDbType.Int);
        parm[50].Value = AdsPost;
        parm[51] = new SqlParameter("@AdsEdit", SqlDbType.Int);
        parm[51].Value = AdsEdit;
        parm[52] = new SqlParameter("@AdsDel", SqlDbType.Int);
        parm[52].Value = AdsDel;
        parm[53] = new SqlParameter("@AdsView", SqlDbType.Int);
        parm[53].Value = AdsView;
        parm[54] = new SqlParameter("@Movies", SqlDbType.Int);
        parm[54].Value = Movies;
        parm[55] = new SqlParameter("@MoviesPost", SqlDbType.Int);
        parm[55].Value = MoviesPost;
        parm[56] = new SqlParameter("@MoviesEdit", SqlDbType.Int);
        parm[56].Value = MoviesEdit;
        parm[57] = new SqlParameter("@MoviesDel", SqlDbType.Int);
        parm[57].Value = MoviesDel;
        parm[58] = new SqlParameter("@MoviesView", SqlDbType.Int);
        parm[58].Value = MoviesView;
        parm[59] = new SqlParameter("@CT", SqlDbType.Int);
        parm[59].Value = CT;
        parm[60] = new SqlParameter("@CTPost", SqlDbType.Int);
        parm[60].Value = CTPost;
        parm[61] = new SqlParameter("@CTEdit", SqlDbType.Int);
        parm[61].Value = CTEdit;
        parm[62] = new SqlParameter("@CTDel", SqlDbType.Int);
        parm[62].Value = CTDel;
        parm[63] = new SqlParameter("@CTView", SqlDbType.Int);
        parm[63].Value = CTView;
        parm[64] = new SqlParameter("@MS", SqlDbType.Int);
        parm[64].Value = MS;
        parm[65] = new SqlParameter("@MSPost", SqlDbType.Int);
        parm[65].Value = MSPost;
        parm[66] = new SqlParameter("@MSEdit", SqlDbType.Int);
        parm[66].Value = MSEdit;
        parm[67] = new SqlParameter("@MSDel", SqlDbType.Int);
        parm[67].Value = MSDel;
        parm[68] = new SqlParameter("@MSView", SqlDbType.Int);
        parm[68].Value = MSView;
        parm[69] = new SqlParameter("@WP", SqlDbType.Int);
        parm[69].Value = wp;
        parm[70] = new SqlParameter("@WPpost", SqlDbType.Int);
        parm[70].Value = wppost;
        parm[71] = new SqlParameter("@WPEdit", SqlDbType.Int);
        parm[71].Value = wpedit;
        parm[72] = new SqlParameter("@WPDel", SqlDbType.Int);
        parm[72].Value = wpdel;
        parm[73] = new SqlParameter("@WPView", SqlDbType.Int);
        parm[73].Value = wpview;
        parm[74] = new SqlParameter("@SS", SqlDbType.Int);
        parm[74].Value = ss;
        parm[75] = new SqlParameter("@SSpost", SqlDbType.Int);
        parm[75].Value = sspost;
        parm[76] = new SqlParameter("@SSEdit", SqlDbType.Int);
        parm[76].Value = ssedit;
        parm[77] = new SqlParameter("@SSDel", SqlDbType.Int);
        parm[77].Value = ssdel;
        parm[78] = new SqlParameter("@SSView", SqlDbType.Int);
        parm[78].Value = ssview;
        parm[79] = new SqlParameter("@CSR", SqlDbType.Int);
        parm[79].Value = csr;
        parm[80] = new SqlParameter("@CSRPost", SqlDbType.Int);
        parm[80].Value = csrpost;
        parm[81] = new SqlParameter("@CSREdit", SqlDbType.Int);
        parm[81].Value = csredit;
        parm[82] = new SqlParameter("@CSRDel", SqlDbType.Int);
        parm[82].Value = csrdel;
        parm[83] = new SqlParameter("@CSRView", SqlDbType.Int);
        parm[83].Value = csrview;
        parm[84] = new SqlParameter("@SNF", SqlDbType.Int);
        parm[84].Value = snf;
        parm[85] = new SqlParameter("@SNFPost", SqlDbType.Int);
        parm[85].Value = snfpost;
        parm[86] = new SqlParameter("@SNFDel", SqlDbType.Int);
        parm[86].Value = snfdel;
        parm[87] = new SqlParameter("@splnk", SqlDbType.Int);
        parm[87].Value = splnk;
        parm[88] = new SqlParameter("@splnkpost", SqlDbType.Int);
        parm[88].Value = splnkpost;
        parm[89] = new SqlParameter("@splnkedit", SqlDbType.Int);
        parm[89].Value = splnkedit;
        parm[90] = new SqlParameter("@splnkdel", SqlDbType.Int);
        parm[90].Value = splnkdel;
        parm[91] = new SqlParameter("@splnkview", SqlDbType.Int);
        parm[91].Value = splnkview;
        parm[92] = new SqlParameter("@test", SqlDbType.Int);
        parm[92].Value = test;
        parm[93] = new SqlParameter("@ccare", SqlDbType.Int);
        parm[93].Value = ccare;
        parm[94] = new SqlParameter("@excep", SqlDbType.Int);
        parm[94].Value = excep;
        DBOperations.ExecuteNonQuery(myTrans, CommandType.StoredProcedure, "AdminWebUser_Update", parm);
        myTrans.Commit();
        con.Close();
        return true;
    }
    public DataSet getPerticularWebAdminDetails(Int32 WId)
    {
        string qry = "select * from Admin_WebAdminCreation where empid=" + WId;
        DataSet ds = new DataSet();
        ds = obj.ExcuteQry(qry);
        return ds;

    }
    public bool WebAdmin_ChangeStatus(Int32 id, Int32 Status)
    {
        con.Open();
        SqlTransaction myTrans = con.BeginTransaction();
        SqlParameter[] arParms = new SqlParameter[2];

        arParms[0] = new SqlParameter("@waid", SqlDbType.Int);
        arParms[0].Value = id;
        arParms[1] = new SqlParameter("@waStatus", SqlDbType.Int);
        arParms[1].Value = Status;

        DBOperations.ExecuteNonQuery(myTrans, CommandType.StoredProcedure, "[WebAdminChangeStatusSP]", arParms);
        myTrans.Commit();
        con.Close();
        return true;
    }
    public DataSet getWebAdminPermissions(string WId)
    {
        string qry = "select * from Admin_WebAdminCreation where email='" + WId+"'";
        DataSet ds = new DataSet();
        ds = obj.ExcuteQry(qry);
        return ds;

    }
    public DataSet GetParticularUserData(Int32 uid)
    {
        con.Open();
        DataSet ds = new DataSet();
        SqlParameter[] parm = new SqlParameter[1];
        parm[0] = new SqlParameter("@empid", SqlDbType.NVarChar);
        parm[0].Value = uid;
        ds = DBOperations.ExecuteDataset(con, CommandType.StoredProcedure, "GetParticularUserIdData", parm);
        con.Close();
        return ds;
    }
        
}
