using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using IndusAbroad.DataAccessLayer;
/// <summary>
/// Summary description for CSRCS
/// </summary>
public class CSRCS
{
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    DataAccess da = new DataAccess();
    DataSet ds = new DataSet();
    string script = string.Empty;
	public CSRCS()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    private Int32 csrId;
    private string ImgName;
    private string ImgContentType;
    private string Introduction;
    private string Title;
    private string Para1;
    private string Para2;
    private string Para3;
    private string Para4;
    private string Para5;
    private string Postedby;
    private DateTime Postdate;
    public Int32 acsrId
    {
        get { return csrId; }
        set { csrId = value; }
    }
    public string aImgName
    {
        get { return ImgName; }
        set { ImgName = value; }
    }
    public string aImgContentType
    {
        get { return ImgContentType; }
        set { ImgContentType = value; }
    }
    public string aIntroduction
    {
        get { return Introduction; }
        set { Introduction = value; }
    }
    public string aTitle
    {
        get { return Title; }
        set { Title = value; }
    }
    public string aPara1
    {
        get { return Para1; }
        set { Para1 = value; }
    }
    public string aPara2
    {
        get { return Para2; }
        set { Para2 = value; }
    }
    public string aPara3
    {
        get { return Para3; }
        set { Para3 = value; }
    }
    public string aPara4
    {
        get { return Para4; }
        set { Para4 = value; }
    }
    public string aPara5
    {
        get { return Para5; }
        set { Para5 = value; }
    }
    public string aPostedby
    {
        get { return Postedby; }
        set { Postedby = value; }
    }
    public DateTime aPostedate
    {
        get { return Postdate; }
        set { Postdate = value; }
    }
    public DataSet GetImgName(string imgName)
    {
        try
        {
        string qry = "select * from CSRGallery where ImgName='"+imgName+"'";

        ds = da.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataTable GetCSRImg_ById(string Id)
    {
        DataTable dt = new DataTable();

        try
        {
        string qry = "select * from CSRGallery where csrId='" + Id + "'";
        dt = da.ExcuteQrydt(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return dt;
    }
    public DataSet GetCSRImgById(string Id)
    {
        try
        {
        string qry = "select * from CSRGallery where csrId='" + Id + "'";

        ds = da.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet GetCSR()
    {
        try
        {
        string qry = "select * from CSRData order by csrId desc";

        ds = da.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet GetCSR_byId(string Id)
    {
        try
        {
        string qry = "select * from CSRData where csrId='"+Id+"' order by csrId desc";

        ds = da.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet GetTopId(string userid)
    {
        try
        {
        string qry = "select top 1 csrId from CSRData where postedby='" + userid + "' order by csrId desc";

        ds = da.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public bool CSRPost(string introduction, string title,string para1,string para2,string para3,string para4,string para5,string postedby,DateTime postdate)
    {
        try
        {

            con.Open();
            SqlTransaction myTrans = con.BeginTransaction();
            SqlParameter[] parms = new SqlParameter[9];
            parms[0] = new SqlParameter("@introduction", SqlDbType.NVarChar);
            parms[0].Value = introduction;
            parms[1] = new SqlParameter("@title", SqlDbType.NVarChar);
            parms[1].Value = title;
            parms[2] = new SqlParameter("@para1", SqlDbType.NVarChar);
            parms[2].Value = para1;
            parms[3] = new SqlParameter("@para2", SqlDbType.NVarChar);
            parms[3].Value = para2;
            parms[4] = new SqlParameter("@para3", SqlDbType.NVarChar);
            parms[4].Value = para3;
            parms[5] = new SqlParameter("@para4", SqlDbType.NVarChar);
            parms[5].Value = para4;
            parms[6] = new SqlParameter("@para5", SqlDbType.NVarChar);
            parms[6].Value = para5;
            parms[7] = new SqlParameter("@postedby", SqlDbType.NVarChar);
            parms[7].Value = postedby;
            parms[8] = new SqlParameter("@postdate", SqlDbType.DateTime);
            parms[8].Value = postdate;
            DBOperations.ExecuteNonQuery(myTrans, CommandType.StoredProcedure, "CSRPost_SP", parms);
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
    public bool CSRUpdate(string introduction, string title, string para1, string para2, string para3, string para4, string para5, string postedby, DateTime postdate,Int32 csrId)
    {
        try
        {

            con.Open();
            SqlTransaction myTrans = con.BeginTransaction();
            SqlParameter[] parms = new SqlParameter[10];
            parms[0] = new SqlParameter("@introduction", SqlDbType.NVarChar);
            parms[0].Value = introduction;
            parms[1] = new SqlParameter("@title", SqlDbType.NVarChar);
            parms[1].Value = title;
            parms[2] = new SqlParameter("@para1", SqlDbType.NVarChar);
            parms[2].Value = para1;
            parms[3] = new SqlParameter("@para2", SqlDbType.NVarChar);
            parms[3].Value = para2;
            parms[4] = new SqlParameter("@para3", SqlDbType.NVarChar);
            parms[4].Value = para3;
            parms[5] = new SqlParameter("@para4", SqlDbType.NVarChar);
            parms[5].Value = para4;
            parms[6] = new SqlParameter("@para5", SqlDbType.NVarChar);
            parms[6].Value = para5;
            parms[7] = new SqlParameter("@postedby", SqlDbType.NVarChar);
            parms[7].Value = postedby;
            parms[8] = new SqlParameter("@postdate", SqlDbType.DateTime);
            parms[8].Value = postdate;
            parms[9] = new SqlParameter("@csrId", SqlDbType.Int);
            parms[9].Value = csrId;
            DBOperations.ExecuteNonQuery(myTrans, CommandType.StoredProcedure, "CSRUpdate_SP", parms);
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
    public bool CSRGalleryPost(string ImageName,string ImageContentType,Int32 CSRId,string Postedby,DateTime Postdate)
    {
        try
        {
            con.Open();
            SqlTransaction myTrans = con.BeginTransaction();
            SqlParameter[] parms = new SqlParameter[5];
            parms[0] = new SqlParameter("@ImageName", SqlDbType.NVarChar);
            parms[0].Value = ImageName;
            parms[1] = new SqlParameter("@ImageContentType", SqlDbType.NVarChar);
            parms[1].Value = ImageContentType;
            parms[2] = new SqlParameter("@CSRId", SqlDbType.Int);
            parms[2].Value = CSRId;
            parms[3] = new SqlParameter("@Postedby", SqlDbType.NVarChar);
            parms[3].Value = Postedby;
            parms[4] = new SqlParameter("@Postdate", SqlDbType.DateTime);
            parms[4].Value = Postdate;
            DBOperations.ExecuteNonQuery(myTrans, CommandType.StoredProcedure, "CSRGalleryPost_SP", parms);
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
    public bool CSRGalleryDelete(Int32 Id)
    {
        try
        {
            con.Open();
            SqlTransaction myTrans = con.BeginTransaction();
            SqlParameter[] parms = new SqlParameter[1];
            parms[0] = new SqlParameter("@Id", SqlDbType.Int);
            parms[0].Value = Id;
            DBOperations.ExecuteNonQuery(myTrans, CommandType.StoredProcedure, "CSRGalleryDelete_SP", parms);
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
    public bool CSRDelete(Int32 csrId)
    {
        try
        {
            con.Open();
            SqlTransaction myTrans = con.BeginTransaction();
            SqlParameter[] parms = new SqlParameter[1];
            parms[0] = new SqlParameter("@csrId", SqlDbType.Int);
            parms[0].Value = csrId;
            DBOperations.ExecuteNonQuery(myTrans, CommandType.StoredProcedure, "CSRDelete_SP", parms);
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
    public DataSet GetCSR_byname(string name)
    {
        try
        {
        string qry = "select * from CSRData c inner join csrgallery g on c.csrId=g.csrId and Title='" + name + "' order by c.csrId desc";

        ds = da.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet GetImgName_specific(int id)
    {
        try
        {
        string qry = "select ImgName from CSRGallery where csrId='" + id + "'";

        ds = da.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
}
