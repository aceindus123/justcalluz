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
/// Summary description for CityTrendsCS
/// </summary>
public class CityTrendsCS
{
    public DataAccess obj = new DataAccess();
    SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    DataSet ds = new DataSet();
    string script = string.Empty;
	public CityTrendsCS()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    private Int32 Id;
    private string mod;
    private string Cat;
    private string SubCat;
    private string State;
    private string City;    
    private string Title;
    private string Titleentered;
    private string Desc;
    private string Listing;
    private string Listing_Lang_Ids;
    private string SubHeading;
    private string UserId;
    private string Area;
    private DateTime Postdate;
   
    public Int32 ctId
    {
        get { return Id; }
        set { Id = value; }
    }
    public string ctMod
    {
        get { return mod; }
        set { mod = value; }
    }
    public string ctCat
    {
        get { return Cat; }
        set { Cat = value; }
    }
    public string ctSubCat
    {
        get { return SubCat; }
        set { SubCat = value; }
    }
    public string ctState
    {
        get { return State; }
        set { State = value; }
    }
    public string ctCity
    {
        get { return City; }
        set { City = value; }
    }
    public string ctTitle
    {
        get { return Title; }
        set { Title = value; }
    }
    public string ctTitleentered
    {
        get { return Titleentered; }
        set { Titleentered = value; }
    }
    public string ctDesc
    {
        get { return Desc; }
        set { Desc = value; }
    }
    
    public string ctListing
    {
        get { return Listing; }
        set { Listing = value; }
    }
    public string ctListing_Lang_Ids
    {
        get { return Listing_Lang_Ids; }
        set { Listing_Lang_Ids = value; }
    }
    public string ctSubHeading
    {
        get { return SubHeading; }
        set { SubHeading = value; }
    }
    public DateTime ctPostdate
    {
        get { return Postdate; }
        set { Postdate = value; }
    }
    public string ctUserId
    {
        get { return UserId; }
        set { UserId = value; }
    }
    public string ctArea
    {
        get { return Area; }
        set { Area = value; }
    }
    

    //More Info of City Trends
    private Int32 ctMId;
    private string ctMInfoTitle;
    private string ctMInfoDesc;

    public Int32 mctMId
    {
        get { return ctMId; }
        set { ctMId = value; }
    }
    public string mctMInfoTitle
    {
        get { return ctMInfoTitle; }
        set { ctMInfoTitle = value; }
    }
    public string mctMInfoDesc
    {
        get { return ctMInfoDesc; }
        set { ctMInfoDesc = value; }
    }

    //Movie Details
    private string MovieName;
    private string MovieLang;
    private string MovieDesc;

    public string ctMovieName
    {
        get { return MovieName;}
        set {MovieName=value;}
    }
    public string ctMovieLang
    {
        get { return MovieLang;}
        set {MovieLang=value;}
    }
    public string ctMovieDesc
    {
        get { return MovieDesc;}
        set {MovieDesc=value;}
    }
    //Business details
    private Int32 dataid;
    private string BusDesc;
    public Int32 ctdataid
    {
        get { return dataid; }
        set { dataid = value; }
    }
    public string ctBusDesc
    {
        get { return BusDesc; }
        set { BusDesc = value; }
    }


    public bool CityTrends_Post(string cModule, string cCategory, string cSubCategory,
                               string cState, string cCity, string cTitle,
                               string cDesc, string cListing, string cListing_Lang_Ids,
                               string cSubHeading, string cPostedBy, DateTime cPostDate, string cArea, string cEnteredTitle)
    {
        try
        {
            connection.Open();
            SqlTransaction myTrans = connection.BeginTransaction();
            SqlParameter[] arParms = new SqlParameter[14];

            arParms[0] = new SqlParameter("@cModule", SqlDbType.NVarChar);
            arParms[0].Value = cModule;
            arParms[1] = new SqlParameter("@cCategory", SqlDbType.NVarChar);
            arParms[1].Value = cCategory;
            arParms[2] = new SqlParameter("@cSubCategory", SqlDbType.NVarChar);
            arParms[2].Value = cSubCategory;
            arParms[3] = new SqlParameter("@cState", SqlDbType.NVarChar);
            arParms[3].Value = cState;
            arParms[4] = new SqlParameter("@cCity", SqlDbType.NVarChar);
            arParms[4].Value = cCity;
            arParms[5] = new SqlParameter("@cTitle", SqlDbType.NVarChar);
            arParms[5].Value = cTitle;
            arParms[6] = new SqlParameter("@cDesc", SqlDbType.NVarChar);
            arParms[6].Value = cDesc;
            arParms[7] = new SqlParameter("@cListing", SqlDbType.NVarChar);
            arParms[7].Value = cListing;
            arParms[8] = new SqlParameter("@cListing_Lang_Ids", SqlDbType.NVarChar);
            arParms[8].Value = cListing_Lang_Ids;
            arParms[9] = new SqlParameter("@cPostDate", SqlDbType.DateTime);
            arParms[9].Value = cPostDate;
            arParms[10] = new SqlParameter("@cSubHeading", SqlDbType.NVarChar);
            arParms[10].Value = cSubHeading;
            arParms[11] = new SqlParameter("@cPostedBy", SqlDbType.NVarChar);
            arParms[11].Value = cPostedBy;
            arParms[12] = new SqlParameter("@cArea", SqlDbType.NVarChar);
            arParms[12].Value = cArea;
            arParms[13] = new SqlParameter("@cEnteredTitle", SqlDbType.NVarChar);
            arParms[13].Value = cEnteredTitle;
            DBOperations.ExecuteNonQuery(myTrans, CommandType.StoredProcedure, "CityTrends_Insert", arParms);
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
    public bool CityTrendsMoreInfo_Post(string CtMoreInfoTitle, string ctMoreInfoDesc, 
                                        Int32 ctId,string ctCategory,
                                        string ctMPostedBy, DateTime ctMPostDate)
    {
        try
        {
            connection.Open();
            SqlTransaction myTrans = connection.BeginTransaction();
            SqlParameter[] arParms = new SqlParameter[6];

            arParms[0] = new SqlParameter("@CtMoreInfoTitle", SqlDbType.NVarChar);
            arParms[0].Value = CtMoreInfoTitle;
            arParms[1] = new SqlParameter("@ctMoreInfoDesc", SqlDbType.NVarChar);
            arParms[1].Value = ctMoreInfoDesc;
            arParms[2] = new SqlParameter("@ctId", SqlDbType.NVarChar);
            arParms[2].Value = ctId;
            arParms[3] = new SqlParameter("@ctCategory", SqlDbType.NVarChar);
            arParms[3].Value = ctCategory;
            arParms[4] = new SqlParameter("@ctMPostDate", SqlDbType.DateTime);
            arParms[4].Value = ctMPostDate;
            arParms[5] = new SqlParameter("@ctMPostedBy", SqlDbType.NVarChar);
            arParms[5].Value = ctMPostedBy;
            DBOperations.ExecuteNonQuery(myTrans, CommandType.StoredProcedure, "CityTrendsMoreInfo_Insert", arParms);
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
    public bool CityTrends_Update(string cModule, string cCategory, string cSubCategory,
                              string cState, string cCity, string cTitle,
                              string cDesc, string cListing, string cListing_Lang_Ids,
                              string cSubHeading, string cPostedBy, DateTime cPostDate, Int32 ctId, string cEnteredTitle)
    {
        try
        {

            connection.Open();
            SqlTransaction myTrans = connection.BeginTransaction();
            SqlParameter[] arParms = new SqlParameter[12];

            arParms[0] = new SqlParameter("@cModule", SqlDbType.NVarChar);
            arParms[0].Value = cModule;
            arParms[1] = new SqlParameter("@cCategory", SqlDbType.NVarChar);
            arParms[1].Value = cCategory;
            arParms[2] = new SqlParameter("@cSubCategory", SqlDbType.NVarChar);
            arParms[2].Value = cSubCategory;
            arParms[3] = new SqlParameter("@cState", SqlDbType.NVarChar);
            arParms[3].Value = cState;
            arParms[4] = new SqlParameter("@cCity", SqlDbType.NVarChar);
            arParms[4].Value = cCity;
            arParms[5] = new SqlParameter("@cTitle", SqlDbType.NVarChar);
            arParms[5].Value = cTitle;
            arParms[6] = new SqlParameter("@cDesc", SqlDbType.NVarChar);
            arParms[6].Value = cDesc;
            arParms[7] = new SqlParameter("@cListing", SqlDbType.NVarChar);
            arParms[7].Value = cListing;
            arParms[8] = new SqlParameter("@cListing_Lang_Ids", SqlDbType.NVarChar);
            arParms[8].Value = cListing_Lang_Ids;
            arParms[9] = new SqlParameter("@cSubHeading", SqlDbType.NVarChar);
            arParms[9].Value = cSubHeading;

            arParms[10] = new SqlParameter("@ctId", SqlDbType.Int);
            arParms[10].Value = ctId;
            arParms[11] = new SqlParameter("@cEnteredTitle", SqlDbType.NVarChar);
            arParms[11].Value = cEnteredTitle;
            DBOperations.ExecuteNonQuery(myTrans, CommandType.StoredProcedure, "CityTrends_Update", arParms);
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
    public DataSet GetCTrends(string Mod)
    {
        try
        {
        string qry = "select *,CONVERT(varchar, Postdate, 106) as posteddate,substring(description,1,500)+' [....]' as Mdesc from CityTrends where mod='"+Mod+"' order by ctId desc";
        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet GetCTrendParticular(Int32 ctId)
    {
        string qry = "select *,CONVERT(varchar, Postdate, 106) as posteddate from CityTrends where ctId="+ctId;
        DataSet ds = new DataSet();
        ds = obj.ExcuteQry(qry);
        return ds;
    }
    public DataSet GetMoreInfoCount(Int32 ctId)
    {
        try{
        string qry = "select count(*) as moreinfocount from CityTrendsMoreInfo where ctId=" + ctId;
        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet GetMovieDistinctDetails(string moviename,string movielang)
    {
        try
        {
        string qry = "select distinct Movie_Desc,Movie_Name,Movie_Language from Movies where Movie_Name='" + moviename + "' and Movie_Language='" + movielang + "'";
        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet GetBusinessDetails(string companyname, string dataid)
    {
        try
        {
        string qry = "select company_name,id,company_profile from ModulesData where company_name='"+companyname+"' and id='"+dataid+"'";
        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet GetMoreInfo(Int32 ctId)
    {
        try
        {
        string qry = "select * from CityTrendsMoreInfo where ctId=" + ctId;
        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet bindCTPopCities()
    {
        try
        {
        string qry = "select * from Popularcities";
        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }

    public DataSet bindCTCategories()
    {
        try
        {
        string qry = "select * from CityTrends_Cat";
        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }

    public DataSet bindCTPosts(string post)
    {
        try
        {
        string qry = "select Top 5 title,ctId from CityTrends where city='" + post + "' order by ctId desc";
         ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }

    public DataSet bindCTTags(string city)
    {
        //try
        //{
       // string qry = "select Distinct(title),ctId from //CityTrends where city='" + city + "'";
         //ds = obj.ExcuteQry(qry);
        //}
        //catch (Exception ex)
        //{
           // script = "<script type=\"text/javascript">
//alert('" + ex.Message + "');</script> ";
        //}
        //return ds;

  
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[1];

            parm[0] = new SqlParameter("@city", city);

            ds = obj.ExecuteSQL("ct_bindtags", parm);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;


    }
    public DataSet bindCTtitles(string city)
    {
        try
        {
        string qry = "select *,CONVERT(varchar, Postdate, 106) as posteddate from CityTrends where city='" + city + "' order by ctId desc";
        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    //public DataSet GetCTTitleDetails(string title)
    //{
    //    try
    //    {
    //        string qry = "select *,CONVERT(varchar, Postdate, 106) as posteddate from CityTrends where title='" + title + "' order by ctId desc";
    //        ds = obj.ExcuteQry(qry);
    //    }
    //    catch (Exception ex)
    //    {
    //        script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
    //    }
    //    return ds;
    //}
    public DataSet GetCTTitleDetails(int tag_id)
    {
        try
        {
            string qry = "select *,CONVERT(varchar, Postdate, 106) as posteddate from CityTrends where ctId=" + tag_id + " order by ctId desc";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Get_popcompanies(string city)
    {
        try
        {
            connection.Open();
            SqlTransaction pop_trans = connection.BeginTransaction();
            SqlParameter[] comp_city = new SqlParameter[1];
            comp_city[0] = new SqlParameter("@city", SqlDbType.NVarChar);
            comp_city[0].Value = city;
            ds = obj.ExcuteQryProc("pop_companies", comp_city);
            pop_trans.Commit();
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        finally
        {
            connection.Close();
        }
        return ds;
    }
    public DataSet Get_PopBusinesses(string city)
    {
        try
        {
            connection.Open();
            SqlTransaction pop_trans = connection.BeginTransaction();
            SqlParameter[] comp_city = new SqlParameter[1];
            comp_city[0] = new SqlParameter("@city", SqlDbType.NVarChar);
            comp_city[0].Value = city;
             ds = obj.ExcuteQryProc("Pop_Businesses", comp_city);
            pop_trans.Commit();
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        finally
        {
            connection.Close();
        }
        return ds;
    }
    public bool ToEditMovieDesc(string ctMName, string ctMLang, string ctMDesc)
    {
        try
        {
            connection.Open();
            SqlTransaction myTrans = connection.BeginTransaction();
            SqlParameter[] arParms = new SqlParameter[3];

            arParms[0] = new SqlParameter("@ctMName", SqlDbType.NVarChar);
            arParms[0].Value = ctMName;
            arParms[1] = new SqlParameter("@ctMLang", SqlDbType.NVarChar);
            arParms[1].Value = ctMLang;
            arParms[2] = new SqlParameter("@ctMDesc", SqlDbType.NVarChar);
            arParms[2].Value = ctMDesc;
            DBOperations.ExecuteNonQuery(myTrans, CommandType.StoredProcedure, "CT_MovieDescUpdate", arParms);
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
    public DataSet GetBusinessInfo(Int32 id)
    {
        try
        {
        string qry = "select * from ModulesData where id=" + id;
        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public bool ToEditCompanyProfile(Int32 ctDataid, string ctCompanyProfile)
    {
        try
        {
            connection.Open();
            SqlTransaction myTrans = connection.BeginTransaction();
            SqlParameter[] arParms = new SqlParameter[2];

            arParms[0] = new SqlParameter("@ctCompanyProfile", SqlDbType.NVarChar);
            arParms[0].Value = ctCompanyProfile;
            arParms[1] = new SqlParameter("@ctDataid", SqlDbType.Int);
            arParms[1].Value = ctDataid;
            DBOperations.ExecuteNonQuery(myTrans, CommandType.StoredProcedure, "CT_BusProfileUpdate", arParms);
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
    public DataSet GetMoreInfoParticular(Int32 moreinfoid)
    {
        try
        {
        string qry = "select * from CityTrendsMoreInfo where ctMoreid=" + moreinfoid;
         ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public bool ToEditCTMoreInfo(string CtMoreInfoTitle, string ctMoreInfoDesc,
                                        Int32 ctMoreId)
    {
        try
        {
            connection.Open();
            SqlTransaction myTrans = connection.BeginTransaction();
            SqlParameter[] arParms = new SqlParameter[3];

            arParms[0] = new SqlParameter("@CtMoreInfoTitle", SqlDbType.NVarChar);
            arParms[0].Value = CtMoreInfoTitle;
            arParms[1] = new SqlParameter("@ctMoreInfoDesc", SqlDbType.NVarChar);
            arParms[1].Value = ctMoreInfoDesc;
            arParms[2] = new SqlParameter("@ctMoreId", SqlDbType.NVarChar);
            arParms[2].Value = ctMoreId;
            DBOperations.ExecuteNonQuery(myTrans, CommandType.StoredProcedure, "CT_MoreInfoUpdate", arParms);
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
