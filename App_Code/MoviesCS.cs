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
/// Summary description for MoviesCS
/// </summary>
public class MoviesCS
{
    public DataAccess obj = new DataAccess();
    SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    DataSet ds = new DataSet();
    string script = string.Empty;
	public MoviesCS()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    // For Cinema Hall
    private Int32 Id;
    private string Cat;
    private string HallName;
    private string Address;
    private string Landmark;
    private string Area;
    private string City;
    private string State;
    private string Pincode;
    private string Mob;
    private string Phno;
    private string Email;
    private string Website;
    private string ImgName;
    private string ImgContentType;
    private DateTime PostDate;
    private DateTime ExpDate;
    private string LoginId;

    public Int32 mId
    {
        get { return Id; }
        set { Id = value; }
    }
    public string mCat
    {
        get { return Cat; }
        set { Cat = value; }
    }
    public string mHallName
    {
        get { return HallName; }
        set { HallName = value; }
    }
    public string mAddress
    {
        get { return Address; }
        set { Address = value; }
    }
    public string mLandmark
    {
        get { return Landmark; }
        set { Landmark = value; }
    }
    public string mArea
    {
        get { return Area; }
        set { Area = value; }
    }
    public string mCity
    {
        get { return City; }
        set { City = value; }
    }
    public string mState
    {
        get { return State; }
        set { State = value; }
    }
    public string mPincode
    {
        get { return Pincode; }
        set { Pincode = value; }
    }
    public string mMob
    {
        get { return Mob; }
        set { Mob = value; }
    }
    public string mPhno
    {
        get { return Phno; }
        set { Phno = value; }
    }
    public string mEmail
    {
        get { return Email; }
        set { Email = value; }
    }
    public string mWebsite
    {
        get { return Website; }
        set { Website = value; }
    }
    public string mImgName
    {
        get { return ImgName; }
        set { ImgName = value; }
    }
    public string mImgContentType
    {
        get { return ImgContentType; }
        set { ImgContentType = value; }
    }
    public DateTime mPostDate
    {
        get { return PostDate; }
        set { PostDate = value; }
    }
    public DateTime mExpDate
    {
        get { return ExpDate; }
        set { ExpDate = value; }
    }
    public string mLoginId
    {
        get { return LoginId; }
        set { LoginId = value; }

    }

    //For Movies
    private Int32 MvId;
    private string Moviename;
    private string MLanguage;
    private string MFor;
    private string TheatreName;
    private string MTimings;
    private string MHallid;
    private string MTheatreURL;
    private string MArea;
    private string MDesc;
    private string MStaus;
    public Int32 mMvId
    {
        get { return MvId; }
        set { MvId = value; }
    }
    public string mMoviename
    {
        get { return Moviename; }
        set { Moviename = value; }

    }
    public string mMLanguage
    {
        get { return MLanguage; }
        set { MLanguage = value; }

    }
    public string mMFor
    {
        get { return MFor; }
        set { MFor = value; }

    }
    public string mTheatreName
    {
        get { return TheatreName; }
        set { TheatreName = value; }

    }
    public string mMTimings
    {
        get { return MTimings; }
        set { MTimings = value; }

    }
    public string mMHallid
    {
        get { return MHallid; }
        set { MHallid = value; }

    }
    public string mMTheatreURL
    {
        get { return MTheatreURL; }
        set { MTheatreURL = value; }

    }
    public string mMArea
    {
        get { return MArea; }
        set { MArea = value; }

    }
    public string mMDesc
    {
        get { return MDesc; }
        set { MDesc = value; }

    }
    public string mMStaus
    {
        get { return MStaus; }
        set { MStaus = value; }

    }
    public bool CinemaHallData_Insert(string Category, string HallName, string Address,
                                string LandMark,string Area, string City,string State,
                                string Pincode, string Email, string PhNumber, string Mobile,
                                string WebSite, DateTime PostDate, DateTime ExpDate,
                                string LoginId, string ImgName, string ImgContentType)
    {
        try
        {
            connection.Open();
            SqlTransaction myTrans = connection.BeginTransaction();
            SqlParameter[] arParms = new SqlParameter[20];

            arParms[0] = new SqlParameter("@mModule", SqlDbType.NVarChar);
            arParms[0].Value = "Movies";
            arParms[1] = new SqlParameter("@mCategory", SqlDbType.NVarChar);
            arParms[1].Value = "Entertainment";
            arParms[2] = new SqlParameter("@mSubCat", SqlDbType.NVarChar);
            arParms[2].Value = Category;
            arParms[3] = new SqlParameter("@mHallName", SqlDbType.NVarChar);
            arParms[3].Value = HallName;
            arParms[4] = new SqlParameter("@mAddress", SqlDbType.NVarChar);
            arParms[4].Value = Address;
            arParms[5] = new SqlParameter("@mLandMark", SqlDbType.NVarChar);
            arParms[5].Value = LandMark;
            arParms[6] = new SqlParameter("@mArea", SqlDbType.NVarChar);
            arParms[6].Value = Area;
            arParms[7] = new SqlParameter("@mCity", SqlDbType.NVarChar);
            arParms[7].Value = City;
            arParms[8] = new SqlParameter("@mState", SqlDbType.NVarChar);
            arParms[8].Value = State;
            arParms[9] = new SqlParameter("@mPincode", SqlDbType.NVarChar);
            arParms[9].Value = Pincode;
            arParms[10] = new SqlParameter("@mEmail", SqlDbType.NVarChar);
            arParms[10].Value = Email;
            arParms[11] = new SqlParameter("@mPhNumber", SqlDbType.NVarChar);
            arParms[11].Value = PhNumber;
            arParms[12] = new SqlParameter("@mMobile", SqlDbType.NVarChar);
            arParms[12].Value = Mobile;
            arParms[13] = new SqlParameter("@mWebSite", SqlDbType.NVarChar);
            arParms[13].Value = WebSite;
            arParms[14] = new SqlParameter("@mLoginId", SqlDbType.NVarChar);
            arParms[14].Value = LoginId;
            arParms[15] = new SqlParameter("@mImgContType", SqlDbType.NVarChar);
            arParms[15].Value = ImgContentType;
            arParms[16] = new SqlParameter("@mImgName", SqlDbType.NVarChar);
            arParms[16].Value = ImgName;
            arParms[17] = new SqlParameter("@mPostDate", SqlDbType.DateTime);
            arParms[17].Value = PostDate;
            arParms[18] = new SqlParameter("@mExpDate", SqlDbType.DateTime);
            arParms[18].Value = ExpDate;
            arParms[19] = new SqlParameter("@mApprovedStatus", SqlDbType.Int);
            arParms[19].Value = "1";
            DBOperations.ExecuteNonQuery(myTrans, CommandType.StoredProcedure, "Movie_InsertCinemaHall", arParms);
            myTrans.Commit();
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        finally
        {
            connection.Close();
        }
        return true;
    }
    public bool CinemaHallData_Update(string Category, string HallName, string Address,
                                string LandMark, string Area, string City, string State,
                                string Pincode, string Email, string PhNumber, string Mobile,
                                string WebSite, DateTime PostDate,
                                string LoginId, string ImgName, string ImgContentType,Int32 mid)
    {
        try
        {
            connection.Open();
            SqlTransaction myTrans = connection.BeginTransaction();
            SqlParameter[] arParms = new SqlParameter[19];

            arParms[0] = new SqlParameter("@mModule", SqlDbType.NVarChar);
            arParms[0].Value = "Movies";
            arParms[1] = new SqlParameter("@mCategory", SqlDbType.NVarChar);
            arParms[1].Value = "Entertainment";
            arParms[2] = new SqlParameter("@mSubCat", SqlDbType.NVarChar);
            arParms[2].Value = Category;
            arParms[3] = new SqlParameter("@mHallName", SqlDbType.NVarChar);
            arParms[3].Value = HallName;
            arParms[4] = new SqlParameter("@mAddress", SqlDbType.NVarChar);
            arParms[4].Value = Address;
            arParms[5] = new SqlParameter("@mLandMark", SqlDbType.NVarChar);
            arParms[5].Value = LandMark;
            arParms[6] = new SqlParameter("@mArea", SqlDbType.NVarChar);
            arParms[6].Value = Area;
            arParms[7] = new SqlParameter("@mCity", SqlDbType.NVarChar);
            arParms[7].Value = City;
            arParms[8] = new SqlParameter("@mState", SqlDbType.NVarChar);
            arParms[8].Value = State;
            arParms[9] = new SqlParameter("@mPincode", SqlDbType.NVarChar);
            arParms[9].Value = Pincode;
            arParms[10] = new SqlParameter("@mEmail", SqlDbType.NVarChar);
            arParms[10].Value = Email;
            arParms[11] = new SqlParameter("@mPhNumber", SqlDbType.NVarChar);
            arParms[11].Value = PhNumber;
            arParms[12] = new SqlParameter("@mMobile", SqlDbType.NVarChar);
            arParms[12].Value = Mobile;
            arParms[13] = new SqlParameter("@mWebSite", SqlDbType.NVarChar);
            arParms[13].Value = WebSite;
            arParms[14] = new SqlParameter("@mImgContType", SqlDbType.NVarChar);
            arParms[14].Value = ImgContentType;
            arParms[15] = new SqlParameter("@mImgName", SqlDbType.NVarChar);
            arParms[15].Value = ImgName;
            arParms[16] = new SqlParameter("@mId", SqlDbType.Int);
            arParms[16].Value = mid;
            arParms[17] = new SqlParameter("@mPostDate", SqlDbType.DateTime);
            arParms[17].Value = PostDate;
            arParms[18] = new SqlParameter("@mloginId", SqlDbType.NVarChar);
            arParms[18].Value = LoginId;

            DBOperations.ExecuteNonQuery(myTrans, CommandType.StoredProcedure, "Movie_UpdateCinemaHall", arParms);
            myTrans.Commit();
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        finally
        {
            connection.Close();
        }
        return true;
    }
    public DataSet GetHallData(Int32 Did)
    {
        try{
        string qry = "select * from ModulesData where id=" + Did;

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet GetData()
    {
        try{
        string qry = "select m.*,Case when m.landphno!='' Then m.landphno else '--' end Phno,Case when m.Website!='' Then m.Website else '--' end web,Case when m.emailid!='' Then m.emailid else '--' end Email,Case when m.ApprovedStatus=1 Then 'Approved' When m.ApprovedStatus=2  Then 'Rejected' When m.ApprovedStatus=3  Then 'Updated' Else 'Posted' End  Status," +
                             "count(dataid)as record_count from PostReview as p full outer join ModulesData as m on m.id=p.dataid  where m.module='Movies'" +
                             "group by m.id,m.module,m.Category,m.SubCategory,m.State,m.City,m.company_name,m.job_industry,m.job_functional_area,m.job_exp,m.job_sal,m.job_desc,m.job_keyskills,m.company_profile," +
                             "m.event_name,m.event_place,m.event_startdate,m.event_enddate,m.event_desc,m.event_time,m.address,m.land_mark,m.contact_person,m.emailid,m.mob,m.landphno,m.fax," +
                             "m.postdate,m.expdate,m.job_role,m.job_Qualification,m.Other_SubCat,m.Area,m.evedi_DurationType,m.Job_ExpiryDate,m.Age,m.Website,m.UserLoginId,m.ApprovedStatus,m.Pincode,m.ImageName,m.ImageContentType,m.free_specifany,m.CatSub,m.map,m.Approved_map order by m.id desc";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public bool Movies_Insert(string MovieName, string MLang, string MFor,
                                string HallName, string Timings, string City, string State,
                                string HallId,string TheatreURL,string MHArea,string MStatus,string MDescription,string PostedBy)
    {
        try
        {
            connection.Open();
            SqlTransaction myTrans = connection.BeginTransaction();
            SqlParameter[] arParms = new SqlParameter[14];

            arParms[0] = new SqlParameter("@mMoviename", SqlDbType.NVarChar);
            arParms[0].Value = MovieName;
            arParms[1] = new SqlParameter("@mMLanguage", SqlDbType.NVarChar);
            arParms[1].Value = MLang;
            arParms[2] = new SqlParameter("@mMFor", SqlDbType.NVarChar);
            arParms[2].Value = MFor;
            arParms[3] = new SqlParameter("@mTheatreName", SqlDbType.NVarChar);
            arParms[3].Value = HallName;
            arParms[4] = new SqlParameter("@mMTimings", SqlDbType.NVarChar);
            arParms[4].Value = Timings;
            arParms[5] = new SqlParameter("@mCity", SqlDbType.NVarChar);
            arParms[5].Value = City;
            arParms[6] = new SqlParameter("@mState", SqlDbType.NVarChar);
            arParms[6].Value = State;
            arParms[7] = new SqlParameter("@mHallId", SqlDbType.NVarChar);
            arParms[7].Value = HallId;
            arParms[8] = new SqlParameter("@mTheatreURL", SqlDbType.NVarChar);
            arParms[8].Value = TheatreURL;
            arParms[9] = new SqlParameter("@mPostDate", SqlDbType.DateTime);
            arParms[9].Value = DateTime.Now;
            arParms[10] = new SqlParameter("@mHArea", SqlDbType.NVarChar);
            arParms[10].Value = MHArea;
            arParms[11] = new SqlParameter("@mMdesc", SqlDbType.NVarChar);
            arParms[11].Value = MDescription;
            arParms[12] = new SqlParameter("@mMStaus", SqlDbType.NVarChar);
            arParms[12].Value = MStatus;
            arParms[13] = new SqlParameter("@mPostedby", SqlDbType.NVarChar);
            arParms[13].Value = PostedBy;
            DBOperations.ExecuteNonQuery(myTrans, CommandType.StoredProcedure, "Movie_Insert", arParms);
            myTrans.Commit();
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        finally
        {
            connection.Close();
        }
        return true;
    }
    public DataSet GetMovies(Int32 Mid)
    {
        try{
        string qry = "select * from Movies where mid=" + Mid;

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public bool Movies_Update(string MovieName, string MLang, string MFor,
                                string HallName, string Timings, string City, string State,
                                string HallId, string TheatreURL, Int32 Id, string MHArea, string MStatus, string MDescription, string PostedBy)
    {
        try
        {
            connection.Open();
            SqlTransaction myTrans = connection.BeginTransaction();
            SqlParameter[] arParms = new SqlParameter[14];

            arParms[0] = new SqlParameter("@mMoviename", SqlDbType.NVarChar);
            arParms[0].Value = MovieName;
            arParms[1] = new SqlParameter("@mMLanguage", SqlDbType.NVarChar);
            arParms[1].Value = MLang;
            arParms[2] = new SqlParameter("@mMFor", SqlDbType.NVarChar);
            arParms[2].Value = MFor;
            arParms[3] = new SqlParameter("@mTheatreName", SqlDbType.NVarChar);
            arParms[3].Value = HallName;
            arParms[4] = new SqlParameter("@mMTimings", SqlDbType.NVarChar);
            arParms[4].Value = MTimings;
            arParms[5] = new SqlParameter("@mCity", SqlDbType.NVarChar);
            arParms[5].Value = City;
            arParms[6] = new SqlParameter("@mState", SqlDbType.NVarChar);
            arParms[6].Value = State;
            arParms[7] = new SqlParameter("@mHallId", SqlDbType.NVarChar);
            arParms[7].Value = HallId;
            arParms[8] = new SqlParameter("@mTheatreURL", SqlDbType.NVarChar);
            arParms[8].Value = TheatreURL;
            arParms[9] = new SqlParameter("@mId", SqlDbType.Int);
            arParms[9].Value = Id;
            arParms[10] = new SqlParameter("@mHArea", SqlDbType.NVarChar);
            arParms[10].Value = MHArea;
            arParms[11] = new SqlParameter("@mMdesc", SqlDbType.NVarChar);
            arParms[11].Value = MDescription;
            arParms[12] = new SqlParameter("@mMStaus", SqlDbType.NVarChar);
            arParms[12].Value = MStatus;
            arParms[13] = new SqlParameter("@mPostedby", SqlDbType.NVarChar);
            arParms[13].Value = PostedBy;

            DBOperations.ExecuteNonQuery(myTrans, CommandType.StoredProcedure, "Movie_Update", arParms);
            myTrans.Commit();
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        finally
        {
            connection.Close();
        }
        return true;
    }
}
