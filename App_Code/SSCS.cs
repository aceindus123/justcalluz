using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using IndusAbroad.DataAccessLayer;
using System.Text;
/// <summary>
/// Summary description for SSCS
/// </summary>
public class SSCS
{
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    public DataAccess obj = new DataAccess();    
    string qry;
    DataSet ds = new DataSet();
    DataSet dsfratings = new DataSet();
    string script = string.Empty;

	public SSCS()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    private Int32 SSId;
    private string TypeofSS;
	private string CompanyName;
	private string Category;
	private string City;
    private string State;
	private string PName;
	private string PDesg;
	private string SMonth;
	private string SYear;
	private string FirstYear;
	private string CurrentYear;
	private string PartnerSpeak;
	private string PhotoName;
	private string PhotoContentType;
	private string VideoName;
	private string VideoContentType;
	private DateTime Postdate;
    private string Postedby;
    private Int32 DataId;

    public Int32 aSSId
    {
        get { return SSId; }
        set { SSId = value; }
    }
    public string aTypeofSS
    {
        get { return TypeofSS; }
        set { TypeofSS = value; }
    }
    public string aCompanyName
    {
        get { return CompanyName; }
        set { CompanyName = value; }
    }
    public string aCategory
    {
        get { return Category; }
        set { Category = value; }
    }
    public string aCity
    {
        get { return City; }
        set { City = value; }
    }
    public string aState
    {
        get { return State; }
        set { State = value; }
    }
    public string aPName
    {
        get { return PName; }
        set { PName = value; }
    }
    public string aPDesg
    {
        get { return PDesg; }
        set { PDesg = value; }
    }
    public string aSMonth
    {
        get { return SMonth; }
        set { SMonth = value; }
    }
    public string aSYear
    {
        get { return SYear; }
        set { SYear = value; }
    }
    public string aFirstYear
    {
        get { return FirstYear; }
        set { FirstYear = value; }
    }
    public string aCurrentYear
    {
        get { return CurrentYear; }
        set { CurrentYear = value; }
    }
    public string aPartnerSpeak
    {
        get { return PartnerSpeak; }
        set { PartnerSpeak = value; }
    }
    public string aPhotoName
    {
        get { return PhotoName; }
        set { PhotoName = value; }
    }
    public string aPhotoContentType
    {
        get { return PhotoContentType; }
        set { PhotoContentType = value; }
    }
    public string aVideoName
    {
        get { return VideoName; }
        set { VideoName = value; }
    }
    public string aVideoContentType
    {
        get { return VideoContentType; }
        set { VideoContentType = value; }
    }
    public DateTime aPostdate
    {
        get { return Postdate; }
        set { Postdate = value; }
    }
    public string aPostedby
    {
        get { return Postedby; }
        set { Postedby = value; }
    }
    public Int32 aDataId
    {
        get { return DataId; }
        set { DataId = value; }
    }

    public bool PostSS(string TypeofSS,string CompanyName,string Category,string City,string PName,
                       string PDesg,string SMonth,string SYear,string FirstYear,string CurrentYear,
                       string PartnerSpeak,string PhotoName,string PhotoContentType,DateTime Postdate,string Postedby,Int32 DataId,string State)
    {
        try
        {
            con.Open();
            SqlTransaction myTrans = con.BeginTransaction();
            SqlParameter[] parms = new SqlParameter[17];
            parms[0] = new SqlParameter("@TypeofSS", SqlDbType.NVarChar);
            parms[0].Value = TypeofSS;
            parms[1] = new SqlParameter("@CompanyName", SqlDbType.NVarChar);
            parms[1].Value = CompanyName;
            parms[2] = new SqlParameter("@Category", SqlDbType.NVarChar);
            parms[2].Value = Category;
            parms[3] = new SqlParameter("@City", SqlDbType.NVarChar);
            parms[3].Value = City;
            parms[4] = new SqlParameter("@PName", SqlDbType.NVarChar);
            parms[4].Value = PName;
            parms[5] = new SqlParameter("@PDesg", SqlDbType.NVarChar);
            parms[5].Value = PDesg;
            parms[6] = new SqlParameter("@SMonth", SqlDbType.NVarChar);
            parms[6].Value = SMonth;
            parms[7] = new SqlParameter("@SYear", SqlDbType.NVarChar);
            parms[7].Value = SYear;
            parms[8] = new SqlParameter("@FirstYear", SqlDbType.NVarChar);
            parms[8].Value = FirstYear;
            parms[9] = new SqlParameter("@CurrentYear", SqlDbType.NVarChar);
            parms[9].Value = CurrentYear;
            parms[10] = new SqlParameter("@PartnerSpeak", SqlDbType.NVarChar);
            parms[10].Value = PartnerSpeak;
            parms[11] = new SqlParameter("@PhotoName", SqlDbType.NVarChar);
            parms[11].Value = PhotoName;
            parms[12] = new SqlParameter("@PhotoContentType", SqlDbType.NVarChar);
            parms[12].Value = PhotoContentType;
            parms[13] = new SqlParameter("@Postdate", SqlDbType.DateTime);
            parms[13].Value = Postdate;
            parms[14] = new SqlParameter("@Postedby", SqlDbType.NVarChar);
            parms[14].Value = Postedby;
            parms[15] = new SqlParameter("@DataId", SqlDbType.Int);
            parms[15].Value = DataId;
            parms[16] = new SqlParameter("@State", SqlDbType.NVarChar);
            parms[16].Value = State;

            DBOperations.ExecuteNonQuery(myTrans, CommandType.StoredProcedure, "PostSS_SP", parms);
            myTrans.Commit();
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        finally
        {
            con.Close();
        }
        return true;
    }

    public bool UpdateSS(string TypeofSS, string CompanyName, string Category, string City, string PName,
                      string PDesg, string SMonth, string SYear, string FirstYear, string CurrentYear,
                      string PartnerSpeak, string PhotoName, string PhotoContentType, DateTime Postdate, string Postedby, Int32 DataId, string State,Int32 ssId)
    {
        try
        {
            con.Open();
            SqlTransaction myTrans = con.BeginTransaction();
            SqlParameter[] parms = new SqlParameter[18];
            parms[0] = new SqlParameter("@TypeofSS", SqlDbType.NVarChar);
            parms[0].Value = TypeofSS;
            parms[1] = new SqlParameter("@CompanyName", SqlDbType.NVarChar);
            parms[1].Value = CompanyName;
            parms[2] = new SqlParameter("@Category", SqlDbType.NVarChar);
            parms[2].Value = Category;
            parms[3] = new SqlParameter("@City", SqlDbType.NVarChar);
            parms[3].Value = City;
            parms[4] = new SqlParameter("@PName", SqlDbType.NVarChar);
            parms[4].Value = PName;
            parms[5] = new SqlParameter("@PDesg", SqlDbType.NVarChar);
            parms[5].Value = PDesg;
            parms[6] = new SqlParameter("@SMonth", SqlDbType.NVarChar);
            parms[6].Value = SMonth;
            parms[7] = new SqlParameter("@SYear", SqlDbType.NVarChar);
            parms[7].Value = SYear;
            parms[8] = new SqlParameter("@FirstYear", SqlDbType.NVarChar);
            parms[8].Value = FirstYear;
            parms[9] = new SqlParameter("@CurrentYear", SqlDbType.NVarChar);
            parms[9].Value = CurrentYear;
            parms[10] = new SqlParameter("@PartnerSpeak", SqlDbType.NVarChar);
            parms[10].Value = PartnerSpeak;
            parms[11] = new SqlParameter("@PhotoName", SqlDbType.NVarChar);
            parms[11].Value = PhotoName;
            parms[12] = new SqlParameter("@PhotoContentType", SqlDbType.NVarChar);
            parms[12].Value = PhotoContentType;
            parms[13] = new SqlParameter("@Postdate", SqlDbType.DateTime);
            parms[13].Value = Postdate;
            parms[14] = new SqlParameter("@Postedby", SqlDbType.NVarChar);
            parms[14].Value = Postedby;
            parms[15] = new SqlParameter("@DataId", SqlDbType.Int);
            parms[15].Value = DataId;
            parms[16] = new SqlParameter("@State", SqlDbType.NVarChar);
            parms[16].Value = State;
            parms[17] = new SqlParameter("@ssId", SqlDbType.NVarChar);
            parms[17].Value = ssId;

            DBOperations.ExecuteNonQuery(myTrans, CommandType.StoredProcedure, "UpdateSS_SP", parms);
            myTrans.Commit();
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        finally
        {
            con.Close();
        }
        return true;
    }
    public bool PostSSVideos(string TypeofSS, string CompanyName, string Category, string City, string PName,
                             string PDesg, string SMonth, string SYear,string PhotoName, string PhotoContentType,
                             string VideoName,string VideoContentType,
                             DateTime Postdate, string Postedby, Int32 DataId,string State)
    {
        try
        {
            con.Open();
            SqlTransaction myTrans = con.BeginTransaction();
            SqlParameter[] parms = new SqlParameter[16];
            parms[0] = new SqlParameter("@TypeofSS", SqlDbType.NVarChar);
            parms[0].Value = TypeofSS;
            parms[1] = new SqlParameter("@CompanyName", SqlDbType.NVarChar);
            parms[1].Value = CompanyName;
            parms[2] = new SqlParameter("@Category", SqlDbType.NVarChar);
            parms[2].Value = Category;
            parms[3] = new SqlParameter("@City", SqlDbType.NVarChar);
            parms[3].Value = City;
            parms[4] = new SqlParameter("@PName", SqlDbType.NVarChar);
            parms[4].Value = PName;
            parms[5] = new SqlParameter("@PDesg", SqlDbType.NVarChar);
            parms[5].Value = PDesg;
            parms[6] = new SqlParameter("@SMonth", SqlDbType.NVarChar);
            parms[6].Value = SMonth;
            parms[7] = new SqlParameter("@SYear", SqlDbType.NVarChar);
            parms[7].Value = SYear;
            parms[8] = new SqlParameter("@PhotoName", SqlDbType.NVarChar);
            parms[8].Value = PhotoName;
            parms[9] = new SqlParameter("@PhotoContentType", SqlDbType.NVarChar);
            parms[9].Value = PhotoContentType;
            parms[10] = new SqlParameter("@VideoName", SqlDbType.NVarChar);
            parms[10].Value = VideoName;
            parms[11] = new SqlParameter("@VideoContentType", SqlDbType.NVarChar);
            parms[11].Value = VideoContentType;
            parms[12] = new SqlParameter("@Postdate", SqlDbType.DateTime);
            parms[12].Value = Postdate;
            parms[13] = new SqlParameter("@Postedby", SqlDbType.NVarChar);
            parms[13].Value = Postedby;
            parms[14] = new SqlParameter("@DataId", SqlDbType.Int);
            parms[14].Value = DataId;
            parms[15] = new SqlParameter("@State", SqlDbType.NVarChar);
            parms[15].Value = State;

            DBOperations.ExecuteNonQuery(myTrans, CommandType.StoredProcedure, "PostSSVideo_SP", parms);
            myTrans.Commit();
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        finally
        {
            con.Close();
        }
        return true;
    }
    public bool UpdateSSVideos(string TypeofSS, string CompanyName, string Category, string City, string PName,
                            string PDesg, string SMonth, string SYear, string PhotoName, string PhotoContentType,
                            string VideoName, string VideoContentType,
                            DateTime Postdate, string Postedby, Int32 DataId, string State,Int32 SSId)
    {
        try
        {
            con.Open();
            SqlTransaction myTrans = con.BeginTransaction();
            SqlParameter[] parms = new SqlParameter[17];
            parms[0] = new SqlParameter("@TypeofSS", SqlDbType.NVarChar);
            parms[0].Value = TypeofSS;
            parms[1] = new SqlParameter("@CompanyName", SqlDbType.NVarChar);
            parms[1].Value = CompanyName;
            parms[2] = new SqlParameter("@Category", SqlDbType.NVarChar);
            parms[2].Value = Category;
            parms[3] = new SqlParameter("@City", SqlDbType.NVarChar);
            parms[3].Value = City;
            parms[4] = new SqlParameter("@PName", SqlDbType.NVarChar);
            parms[4].Value = PName;
            parms[5] = new SqlParameter("@PDesg", SqlDbType.NVarChar);
            parms[5].Value = PDesg;
            parms[6] = new SqlParameter("@SMonth", SqlDbType.NVarChar);
            parms[6].Value = SMonth;
            parms[7] = new SqlParameter("@SYear", SqlDbType.NVarChar);
            parms[7].Value = SYear;
            parms[8] = new SqlParameter("@PhotoName", SqlDbType.NVarChar);
            parms[8].Value = PhotoName;
            parms[9] = new SqlParameter("@PhotoContentType", SqlDbType.NVarChar);
            parms[9].Value = PhotoContentType;
            parms[10] = new SqlParameter("@VideoName", SqlDbType.NVarChar);
            parms[10].Value = VideoName;
            parms[11] = new SqlParameter("@VideoContentType", SqlDbType.NVarChar);
            parms[11].Value = VideoContentType;
            parms[12] = new SqlParameter("@Postdate", SqlDbType.DateTime);
            parms[12].Value = Postdate;
            parms[13] = new SqlParameter("@Postedby", SqlDbType.NVarChar);
            parms[13].Value = Postedby;
            parms[14] = new SqlParameter("@DataId", SqlDbType.Int);
            parms[14].Value = DataId;
            parms[15] = new SqlParameter("@State", SqlDbType.NVarChar);
            parms[15].Value = State;
            parms[16] = new SqlParameter("@SSId", SqlDbType.Int);
            parms[16].Value = SSId;
            DBOperations.ExecuteNonQuery(myTrans, CommandType.StoredProcedure, "UpdateSSVideo_SP", parms);
            myTrans.Commit();
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        finally
        {
            con.Close();
        }
        return true;
    }
    public DataSet GetImgName(string ImgName)
    {
        try{
        string qry = "select * from SuccessStories where PhotoName='"+ImgName+"'";
        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet GetCompanyName(string companyname)
    {
        //con.Open();
        //SqlTransaction myTrans = con.BeginTransaction();
        ////SqlParameter[] parms1 = new SqlParameter[1];
        ////parms1[0] = new SqlParameter("@comp", SqlDbType.NVarChar);
        ////parms1[0].Value = companyname;  
        //SqlParameter[] parms = new SqlParameter[1];
        //parms[0] = new SqlParameter("@companyname", SqlDbType.NVarChar);
        //parms[0].Value = companyname;        
        //DBOperations.ExecuteNonQuery(myTrans, CommandType.StoredProcedure, "selectSSCompany", parms);
        //myTrans.Commit();
        //con.Close();        
        //return ds;
        try{
        string qry = "select * from SuccessStories where CompanyName='" + companyname + "'";
        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet GetVideoName(string VideoName)
    {
        try{
        string qry = "select * from SuccessStories where VideoName='" + VideoName + "'";
        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet GetSS()
    {
        try{
        string qry = "select * from SuccessStories order by ssId desc";
        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet GetSS_byCity(string city,string type)
    {
        try{
        string qry = "select *,DATALENGTH(PartnerSpeak) as textlengh,case when(DATALENGTH(PartnerSpeak)>150) Then (substring(PartnerSpeak,1,149)+'...') else PartnerSpeak end pspeak from SuccessStories where City='" + city + "' and TypeofSS='"+type+"' order by ssId desc";
        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet GetSS_byId(string Id)
    {
        try{
        string qry = "select * from SuccessStories where ssId='"+Id+"' order by ssId desc";
        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet GetSS_Fillcities(string type)
    {
        try{
        string qry = "select distinct city from SuccessStories where TypeofSS='" + type + "' and (city='Mumbai' or city='Delhi' or city='Bangalore' or city='Kolkata' or city='Chennai' or city='Hyderabad' or city='Ahmedabad' or city='Pune')";
        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet GetSS_Fillothcities(string type)
    {
        try{
        string qry = "select distinct city from SuccessStories where TypeofSS='" + type + "' and (city!='Mumbai' and city!='Delhi' and city!='Bangalore' and city!='Kolkata' and city!='Chennai' and city!='Hyderabad' and city!='Ahmedabad' and city!='Pune')";
        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet tag_mob(string mob)
    {
        DataSet dsregnames = new DataSet();
        string qry1 = string.Empty;
        try
        {
            string qry = "select id,name,mob from register where mob='" + mob + "'";
            ds = obj.ExcuteQry(qry);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string reg_name = Convert.ToString(ds.Tables[0].Rows[i]["name"]);
                if (reg_name.Length > 1)
                {
                    qry1 = "select *,rname=stuff(name,4,5,'*****') from register where mob='" + mob + "'";
                    dsregnames = obj.ExcuteQry(qry1);
                }
                else
                {
                    qry1 = "select id,mob,*,rname=name from register where mob='" + mob + "'";
                    dsregnames = obj.ExcuteQry(qry1);
                }
            }
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return dsregnames;
    }
    public DataSet tag_Loginmob(int rid)
    {
        try
        {
            string qry = "select * from register where id=" + rid;
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet tag_Friends(int regid)
    {
        try
        {
            string qry = "select * from Tagyourfriends where regid=" + regid;
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet tag_FriendsRatings(int regid)
    {
        try
        {
           // string qry = "select * from PostReview where reg_id=" + regid + " order by 1 desc";
            string qry = "select p.*,m.id,m.State,m.City,m.address from PostReview p inner join ModulesData m on p.dataid=m.id where reg_id=" + regid;
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public string tagFriends_rid(string mobile)
    {
        string reg_id=string.Empty;
        try
        {
            string qry = "select * from register where mob='" + mobile + "'";
            ds = obj.ExcuteQry(qry);
            if(ds.Tables.Count>0 && ds.Tables[0].Rows.Count>0)
            {
                reg_id=Convert.ToString(ds.Tables[0].Rows[0]["id"]);
            }
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return reg_id;
    }
    public DataSet tag_fratingsCount(string frid)
    {
         try
        {
           
        //    SqlCommand cmd = new SqlCommand("tagfriends_ratings", con);
        //cmd.CommandType = CommandType.StoredProcedure;
        //cmd.Parameters.AddWithValue("@id", frid);
            string qry = " select r.id,r.name,count(p.rid) as count from register r left outer join PostReview p on r.id=p.reg_id where r.id in (" + frid + ") group by r.name,r.id order by r.id desc";

       SqlDataAdapter sdafratings = new SqlDataAdapter(qry,con);
        //sdafratings.SelectCommand = cmd;
              sdafratings.Fill(dsfratings);
          
        }
         catch (Exception ex)
         {
             script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
         }
         return dsfratings;
    }  
    public DataSet Show_morefriends(string frid)
    {
        try
        {

            //    SqlCommand cmd = new SqlCommand("tagfriends_ratings", con);
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.AddWithValue("@id", frid);
            string qry = " select r.id,r.name,r.email,r.mob,count(p.rid) as count from register r left outer join PostReview p on r.id=p.reg_id where r.id in (" + frid + ") group by r.email,r.mob,r.name,r.id order by r.name desc";

            SqlDataAdapter sdafratings = new SqlDataAdapter(qry, con);
            //sdafratings.SelectCommand = cmd;
            sdafratings.Fill(dsfratings);

        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return dsfratings;
    }
    public DataSet tag_CheckFriendsmobile(string tagfmobile,int regid)
    {
        try
        {
            string qry = "select * from Tagyourfriends where friend_mobile='" + tagfmobile + "' and regid=" + regid;
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public bool untag_taggedfriend(string mob)
    {
        try
        {
        con.Open();
        SqlTransaction myTrans = con.BeginTransaction();
        SqlParameter[] parms = new SqlParameter[1];
        parms[0] = new SqlParameter("@friend_mobile", SqlDbType.NVarChar);
        parms[0].Value = mob;
             DBOperations.ExecuteNonQuery(myTrans, CommandType.StoredProcedure, "delete_taggedfriend", parms);
            myTrans.Commit();
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        finally
        {
            con.Close();
        }
        return true;
    }
}
