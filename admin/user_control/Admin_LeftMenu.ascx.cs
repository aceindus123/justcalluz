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

public partial class usercontrols_WebUserControl : System.Web.UI.UserControl
{
    string LoginId;
    string AdminType;
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
     string CareersApr;

     string BAds;
     string BAdsPost;
     string BAdsEdit;
     string BAdsDel;
     string BAdsView;
     string BAdsApr;

     string UInfo;
     //string UInfoPost;
     //string UInfoEdit;
     //string UInfoDel;
     //string UInfoView;
     string UInfoActDeact;

     string FL;
     string FLPost;
     string FLEdit;
     string FLDel;
     string FLView;
     string FLApr;

     string Ad;
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

     string WP;
     string WPPost;
     string WPEdit;
     string WPDel;
     string WPView;

     string SS;
     string SSPost;
     string SSEdit;
     string SSDel;
     string SSView;

     string CSR;
     string CSRPost;
     string CSREdit;
     string CSRDel;
     string CSRView;

     string SNF;
     string SNFPost;
     string SNFDel;

     string splnk, splnk_post, splnk_edit, splnk_del, splnk_view;

     string test;
     string ccare;
     string excep;

    DataSet ds = new DataSet();
    WebAdminCreation web_admin = new WebAdminCreation();
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    protected void Page_Load(object sender, EventArgs e)
    {
        Binddata obj = new Binddata();
        //To bind categories of Category
        DataSet ds1 = new DataSet();
        con.Open();
        ds1 = obj.bindAdminCategoryCat(); ;        
        dlCat.DataSource = ds1;
        dlCat.DataBind();
        con.Close();
        //To bind categories of Jobs
        DataSet ds2 = new DataSet();
        con.Open();
        ds2 = obj.bindAdminJobsCat(); ;
        dlJobs.DataSource = ds2;
        dlJobs.DataBind();
        con.Close();
        //To bind categories of Events
        DataSet ds3 = new DataSet();
        con.Open();
        ds3 = obj.bindAdminCategoryCat(); ;
        dlDiscounts.DataSource = ds3;
        dlDiscounts.DataBind();
        con.Close();
        //To bind categories of Discounts
        DataSet ds4 = new DataSet();
        con.Open();
        ds4 = obj.bindAdminEventsCat(); ;
        dlEvents.DataSource = ds4;
        dlEvents.DataBind();
        con.Close();

        DataSet ds5 = new DataSet();
        con.Open();
        ds5 = obj.bindAdminB2BCat(); ;
        dlB2Bcat.DataSource = ds5;
        dlB2Bcat.DataBind();
        con.Close();

        DataSet ds6 = new DataSet();
        con.Open();
        ds6 = obj.bindAdminLifeStyle();
        dlLifeStyle.DataSource = ds6;
        dlLifeStyle.DataBind();
        con.Close();

        DataSet ds7 = new DataSet();
        con.Open();
        ds7 = obj.bindAdminFreeListing();
        dlFreeList.DataSource = ds7;
        dlFreeList.DataBind();
        con.Close();
        if (!Page.IsPostBack)
        {
            if (Session["LoginId"] != null)
            {
                GetPermissions();
            }
        }
    }
    protected void lnkViewCategoryData(object sender, CommandEventArgs e)
    {
        string command_argument = (e.CommandArgument).ToString();
        char[] seperator = new char[] { ',' };
        string[] strCatMod = command_argument.Split(seperator);
        string cat = strCatMod[0];
        string mod = strCatMod[1];
        Response.Redirect("Admin_LinkControllerCategory.aspx?cat=" +Server.UrlEncode(cat) + "&mod=" +Server.UrlEncode(mod));
    }
    public void GetPermissions()
    {
        LoginId = Convert.ToString(Session["LoginId"]);
        ds = web_admin.getWebAdminPermissions(LoginId);
        if (!ds.Tables[0].Rows.Count.Equals(0))
        {
            Session.Add(AdminType, ds.Tables[0].Rows[0]["AdminType"].ToString());
            Session.Add("B", ds.Tables[0].Rows[0]["B"].ToString());
            Session.Add("BPost", ds.Tables[0].Rows[0]["BPost"].ToString());
            Session.Add("BEdit", ds.Tables[0].Rows[0]["BEdit"].ToString());
            Session.Add("BDel", ds.Tables[0].Rows[0]["BDel"].ToString());
            Session.Add("BView", ds.Tables[0].Rows[0]["BView"].ToString());
            Session.Add("BApr", ds.Tables[0].Rows[0]["BApr"].ToString());

            Session.Add("B2B", ds.Tables[0].Rows[0]["B2B"].ToString());
            Session.Add("B2BApr", ds.Tables[0].Rows[0]["B2BApr"].ToString());
            Session.Add("B2BDel", ds.Tables[0].Rows[0]["B2BDel"].ToString());
            Session.Add("B2BEdit", ds.Tables[0].Rows[0]["B2BEdit"].ToString());
            Session.Add("B2BPost", ds.Tables[0].Rows[0]["B2BPost"].ToString());
            Session.Add("B2BView", ds.Tables[0].Rows[0]["B2BView"].ToString());

            Session.Add("Eve", ds.Tables[0].Rows[0]["Eve"].ToString());
            Session.Add("EveApr", ds.Tables[0].Rows[0]["EveApr"].ToString());
            Session.Add("EveDel", ds.Tables[0].Rows[0]["EveDel"].ToString());
            Session.Add("EveEdit", ds.Tables[0].Rows[0]["EveEdit"].ToString());
            Session.Add("EvePost", ds.Tables[0].Rows[0]["EvePost"].ToString());
            Session.Add("EveView", ds.Tables[0].Rows[0]["EveView"].ToString());

            Session.Add("Dis", ds.Tables[0].Rows[0]["Dis"].ToString());
            Session.Add("DisApr", ds.Tables[0].Rows[0]["DisApr"].ToString());
            Session.Add("DisDel", ds.Tables[0].Rows[0]["DisDel"].ToString());
            Session.Add("DisEdit", ds.Tables[0].Rows[0]["DisEdit"].ToString());
            Session.Add("DisPost", ds.Tables[0].Rows[0]["DisPost"].ToString());
            Session.Add("DisView", ds.Tables[0].Rows[0]["DisView"].ToString());

            Session.Add("Job", ds.Tables[0].Rows[0]["Job"].ToString());
            Session.Add("JobApr", ds.Tables[0].Rows[0]["JobApr"].ToString());
            Session.Add("JobDel", ds.Tables[0].Rows[0]["JobDel"].ToString());
            Session.Add("JobEdit", ds.Tables[0].Rows[0]["JobEdit"].ToString());
            Session.Add("JobPost", ds.Tables[0].Rows[0]["JobPost"].ToString());
            Session.Add("JobView", ds.Tables[0].Rows[0]["JobView"].ToString());

            Session.Add("LS", ds.Tables[0].Rows[0]["LS"].ToString());
            Session.Add("LSApr", ds.Tables[0].Rows[0]["LSApr"].ToString());
            Session.Add("LSDel", ds.Tables[0].Rows[0]["LSDel"].ToString());
            Session.Add("LSEdit", ds.Tables[0].Rows[0]["LSEdit"].ToString());
            Session.Add("LSPost", ds.Tables[0].Rows[0]["LSPost"].ToString());
            Session.Add("LSView", ds.Tables[0].Rows[0]["LSView"].ToString());

            Session.Add("Careers", ds.Tables[0].Rows[0]["Careers"].ToString());            
            Session.Add("CareersDel", ds.Tables[0].Rows[0]["CareersDel"].ToString());
            Session.Add("CareersEdit", ds.Tables[0].Rows[0]["CareersEdit"].ToString());
            Session.Add("CareersPost", ds.Tables[0].Rows[0]["CareersPost"].ToString());
            Session.Add("CareersView", ds.Tables[0].Rows[0]["CareersView"].ToString());

            Session.Add("UInfo", ds.Tables[0].Rows[0]["UInfo"].ToString());
            Session.Add("UInfoStatus",ds.Tables[0].Rows[0]["Status"].ToString());

            Session.Add("FL", ds.Tables[0].Rows[0]["FL"].ToString());
            Session.Add("FLApr", ds.Tables[0].Rows[0]["FLApprove"].ToString());
            Session.Add("FLDel", ds.Tables[0].Rows[0]["FLDel"].ToString());
            Session.Add("FLEdit", ds.Tables[0].Rows[0]["FLEdit"].ToString());
            Session.Add("FLPost", ds.Tables[0].Rows[0]["FLPost"].ToString());
            Session.Add("FLView", ds.Tables[0].Rows[0]["FLView"].ToString());

            Session.Add("Ads", ds.Tables[0].Rows[0]["Ads"].ToString());
            Session.Add("AdsDel", ds.Tables[0].Rows[0]["AdsDel"].ToString());
            Session.Add("AdsEdit", ds.Tables[0].Rows[0]["AdsEdit"].ToString());
            Session.Add("AdsPost", ds.Tables[0].Rows[0]["AdsPost"].ToString());
            Session.Add("AdsView", ds.Tables[0].Rows[0]["AdsView"].ToString());

            Session.Add("Movies", ds.Tables[0].Rows[0]["Movies"].ToString());
            Session.Add("MoviesDel", ds.Tables[0].Rows[0]["MoviesDel"].ToString());
            Session.Add("MoviesEdit", ds.Tables[0].Rows[0]["MoviesEdit"].ToString());
            Session.Add("MoviesPost", ds.Tables[0].Rows[0]["MoviesPost"].ToString());
            Session.Add("MoviesView", ds.Tables[0].Rows[0]["MoviesView"].ToString());

            Session.Add("CT", ds.Tables[0].Rows[0]["CT"].ToString());
            Session.Add("CTDel", ds.Tables[0].Rows[0]["CTDel"].ToString());
            Session.Add("CTEdit", ds.Tables[0].Rows[0]["CTEdit"].ToString());
            Session.Add("CTPost", ds.Tables[0].Rows[0]["CTPost"].ToString());
            Session.Add("CTView", ds.Tables[0].Rows[0]["CTView"].ToString());

            Session.Add("MS", ds.Tables[0].Rows[0]["MS"].ToString());
            Session.Add("MSDel", ds.Tables[0].Rows[0]["MSDel"].ToString());
            Session.Add("MSEdit", ds.Tables[0].Rows[0]["MSEdit"].ToString());
            Session.Add("MSPost", ds.Tables[0].Rows[0]["MSPost"].ToString());
            Session.Add("MSView", ds.Tables[0].Rows[0]["MSView"].ToString()); 
          
            Session.Add("WP",ds.Tables[0].Rows[0]["WP"].ToString());
            Session.Add("WPPost", ds.Tables[0].Rows[0]["WPpost"].ToString());
            Session.Add("WPEdit", ds.Tables[0].Rows[0]["WPEdit"].ToString());
            Session.Add("WPDel", ds.Tables[0].Rows[0]["WPDel"].ToString());
            Session.Add("WPView", ds.Tables[0].Rows[0]["WPView"].ToString());

            Session.Add("SS", ds.Tables[0].Rows[0]["SS"].ToString());
            Session.Add("SSPost", ds.Tables[0].Rows[0]["SSPost"].ToString());
            Session.Add("SSEdit",ds.Tables[0].Rows[0]["SSEdit"].ToString());
            Session.Add("SSDel",ds.Tables[0].Rows[0]["SSDel"].ToString());
            Session.Add("SSView",ds.Tables[0].Rows[0]["SSView"].ToString());

            Session.Add("CSR",ds.Tables[0].Rows[0]["CSR"].ToString());
            Session.Add("CSRPost",ds.Tables[0].Rows[0]["CSRPost"].ToString());
            Session.Add("CSREdit",ds.Tables[0].Rows[0]["CSREdit"].ToString());
            Session.Add("CSRDel",ds.Tables[0].Rows[0]["CSRDel"].ToString());
            Session.Add("CSRView",ds.Tables[0].Rows[0]["CSRView"].ToString());

            Session.Add("SNF",ds.Tables[0].Rows[0]["SNF"].ToString());
            Session.Add("SNFPost",ds.Tables[0].Rows[0]["SNFPost"].ToString());
            Session.Add("SNFDel",ds.Tables[0].Rows[0]["SNFDel"].ToString());

            Session.Add("sp_lnk", ds.Tables[0].Rows[0]["splnk"].ToString());
            Session.Add("sp_lnkpost", ds.Tables[0].Rows[0]["splnk_post"].ToString());
            Session.Add("sp_lnkedit", ds.Tables[0].Rows[0]["splnk_edit"].ToString());
            Session.Add("sp_lnkdel", ds.Tables[0].Rows[0]["splnk_del"].ToString());
            Session.Add("sp_lnkview", ds.Tables[0].Rows[0]["splnk_view"].ToString());

            Session.Add("test", ds.Tables[0].Rows[0]["test"].ToString());
            Session.Add("ccare", ds.Tables[0].Rows[0]["ccare"].ToString());
            Session.Add("excep", ds.Tables[0].Rows[0]["excep"].ToString());
            
            AdminType = ds.Tables[0].Rows[0]["AdminType"].ToString();
            BPost = ds.Tables[0].Rows[0]["BPost"].ToString();
            B2BPost = ds.Tables[0].Rows[0]["B2BPost"].ToString();
            EvePost = ds.Tables[0].Rows[0]["EvePost"].ToString();
            DisPost = ds.Tables[0].Rows[0]["DisPost"].ToString();
            JobPost = ds.Tables[0].Rows[0]["JobPost"].ToString();
            LSPost = ds.Tables[0].Rows[0]["LSPost"].ToString();

            Careers = ds.Tables[0].Rows[0]["Careers"].ToString();
            UInfo = ds.Tables[0].Rows[0]["UInfo"].ToString();
            BApr = ds.Tables[0].Rows[0]["BApr"].ToString();
            B2BApr = ds.Tables[0].Rows[0]["B2BApr"].ToString();
            EveApr = ds.Tables[0].Rows[0]["EveApr"].ToString();
            DisApr = ds.Tables[0].Rows[0]["DisApr"].ToString();
            JobApr = ds.Tables[0].Rows[0]["JobApr"].ToString();
            LSApr = ds.Tables[0].Rows[0]["LSApr"].ToString();
            BView = ds.Tables[0].Rows[0]["BView"].ToString();
            B2BView = ds.Tables[0].Rows[0]["B2BView"].ToString();
            EveView = ds.Tables[0].Rows[0]["EveView"].ToString();
            DisView = ds.Tables[0].Rows[0]["DisView"].ToString();
            JobView = ds.Tables[0].Rows[0]["JobView"].ToString();
            LSView = ds.Tables[0].Rows[0]["LSView"].ToString();
            Movies = ds.Tables[0].Rows[0]["Movies"].ToString();
            CT = ds.Tables[0].Rows[0]["CT"].ToString();
            MS = ds.Tables[0].Rows[0]["MS"].ToString();
            Ad = ds.Tables[0].Rows[0]["Ads"].ToString();
            FL = ds.Tables[0].Rows[0]["FL"].ToString();
            FLApr = ds.Tables[0].Rows[0]["FLApprove"].ToString();
            FLPost = ds.Tables[0].Rows[0]["FLPost"].ToString(); 
            WP = ds.Tables[0].Rows[0]["WP"].ToString();
            SS = ds.Tables[0].Rows[0]["SS"].ToString();
            CSR = ds.Tables[0].Rows[0]["CSR"].ToString();
            SNF = ds.Tables[0].Rows[0]["SNF"].ToString();
            splnk = ds.Tables[0].Rows[0]["splnk"].ToString();
            test = ds.Tables[0].Rows[0]["test"].ToString();
            ccare = ds.Tables[0].Rows[0]["ccare"].ToString();
            excep = ds.Tables[0].Rows[0]["excep"].ToString();
        }
        ////if (AdminType == "Admin")
        ////{
        ////    webadmin.Visible = true;
        ////}
        //else
        //{
        //    webadmin.Visible = false;
        //}
        if (BPost == "1" || B2BPost == "1" || EvePost == "1" || DisPost == "1" || JobPost == "1" || LSPost == "1" || FLPost == "1")
        {
            postdata.Visible = true;
        }
        else
        {
            postdata.Visible = false;
        }
        if (Careers == "1")
        {
            careers.Visible = true;
        }
        else
        {
            careers.Visible = false;
        }
        if (UInfo == "1")
        {
            usersdata.Visible = true;
        }
        else
        {
            usersdata.Visible = false;
        }
        if (BApr == "1" || B2BApr == "1")
        {
            BB2BAprRej.Visible = true;
        }
        else
        {
            BB2BAprRej.Visible = false;
        }
        if (EveApr == "1")
        {
            EveAprRej.Visible = true;
        }
        else
        {
            EveAprRej.Visible = false;
        }
        if (DisApr == "1")
        {
            DisAprRej.Visible = true;
        }
        else
        {
            DisAprRej.Visible = false;
        }
        if (JobApr == "1")
        {
            JobsAprRej.Visible = true;
        }
        else
        {
            JobsAprRej.Visible = false;
        }
        if (LSApr == "1")
        {
            LSAprRej.Visible = true;
        }
        else
        {
            LSAprRej.Visible = false;
        }
        if (LSView == "1")
        {
            divLifeStyle.Visible = true;
        }
        else
        {
            divLifeStyle.Visible = false;
        }
        if (BView == "1")
        {
            divB.Visible = true;
        }
        else
        {
            divB.Visible = false;
        }
        if (B2BView == "1")
        {
            divB2B.Visible = true;
        }
        else
        {
            divB2B.Visible = false;
        }
        if (EveView == "1")
        {
            divEve.Visible = true;
        }
        else
        {
            divEve.Visible = false;
        }
        if (DisView == "1")
        {
            divDis.Visible = true;
        }
        else
        {
            divDis.Visible = false;
        }
        if (JobView == "1")
        {
            divJobs.Visible = true;
        }
        else
        {
            divJobs.Visible = false;
        }
        if (Ad == "1")
        {
            aAds.Visible = true;
        }
        else
        {
            aAds.Visible = false;
        }
        if (CT == "1")
        {
            acitytrends.Visible = true;
        }
        else
        {
            acitytrends.Visible = false;
        }
        if (Movies == "1")
        {
            amovies.Visible = true;
        }
        else
        {
            amovies.Visible = false;
        }
        if (MS == "1")
        {
            amediaspeak.Visible = true;
        }
        else
        {
            amediaspeak.Visible = false;
        }
        if (FL == "1")
        {
            divFL.Visible = true;
        }
        else
        {
            divFL.Visible = false;
        }
        if (FLApr == "1")
        {
            freelistAprRej.Visible = true;
        }
        else
        {
            freelistAprRej.Visible = false;
        }
        if (WP == "1")
        {
            wp.Visible = true;
        }
        else
        {
            wp.Visible = false;
        }
        if (SS == "1")
        {
            ss.Visible = true;
        }
        else
        {
            ss.Visible = false;
        }
        if (CSR == "1")
        {
            csr.Visible = true;
        }
        else
        {
            csr.Visible = false;
        }
        if (SNF == "1")
        {
            snf.Visible = true;
        }
        else
        {
            snf.Visible = false;
        }
        if (splnk == "1")
        {
            sponlinks.Visible = true;
        }
        else
        {
            sponlinks.Visible = false;
        }
        if (test == "1")
        {
            testimonials.Visible = true;    
        }
        else
        {
            testimonials.Visible = false;
        }
        if (ccare == "1")
        {
            Customer_care.Visible = true;
        }
        else
        {
            Customer_care.Visible = false;
        }
        if (excep == "1")
        {
            Exception.Visible = true;
        }
        else
        {
            Exception.Visible = false;
        }
        if (AdminType == "Admin")
        {
            SiteVisitors.Visible = true;
        }
        else
        {
            SiteVisitors.Visible = false;
        }
        
    }
}
