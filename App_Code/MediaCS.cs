using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using JustCallUsData.Data;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using IndusAbroad.DataAccessLayer;
/// <summary>
/// Summary description for MediaCS
/// </summary>
public class MediaCS
{
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    public DataCS obj = new DataCS();
    public DataAccess daccess=new DataAccess();
    DataSet ds = new DataSet();
    string script = string.Empty;
    string qry;
	public MediaCS()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    private Int32 Id;
    private string Title;
    private string Lang;
    private string Cat;
    private string OtherCat;
    private string ImageContent;
    private string ImgContentType;
    private Int32 Rating;
    private Int32 Hits;
    private Int32 Votes;
    private DateTime Postdate;

    public Int32 MsId
    {
        get { return Id; }
        set { Id = value; }
    }
    public string MsTitle
    {
        get { return Title; }
        set { Title = value; }
    }
    public string MsLang
    {
        get { return Lang; }
        set { Lang = value; }
    }
    public string MsCat
    {
        get { return Cat; }
        set { Cat = value; }
    }
    public string MsOtherCat
    {
        get { return OtherCat; }
        set { OtherCat = value; }
    }
    public string MsImageContent
    {
        get { return ImageContent; }
        set { ImageContent = value; }
    }
    public string MsImgContentType
    {
        get { return ImgContentType; }
        set { ImgContentType = value; }
    }
    public Int32 MsRatings
    {
        get { return Rating; }
        set { Rating = value; }
    }
    public Int32 MsHits
    {
        get { return Hits; }
        set { Hits = value; }
    }
    public Int32 MsVotes
    {
        get { return Votes; }
        set { Votes = value; }
    }
    public DateTime MsPostdate
    {
        get { return Postdate; }
        set { Postdate = value; }
    }

    public void FillLanguage(DropDownList dpc)
    {
        try{
            obj.FillDrop(dpc, "select mlid,ms_language from Media_Language", "ms_language", "ms_language", "Select Language");
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
    }
    public void FillMediaNames(string MLang,DropDownList ddlMedia)
    {
        DataSet dsmedia = new DataSet();
        try
        {
            qry = "select * from MediaCat where lang='" + MLang + "' order by cat";
            con.Open();
            SqlDataAdapter ada = new SqlDataAdapter(qry, con);
            //ada.Fill(ds, "MediaNames");
            ada.Fill(dsmedia);
            if (!dsmedia.Tables[0].Rows.Count.Equals(0))
            {
                
                ddlMedia.DataValueField = "cat";
                ddlMedia.DataTextField = "cat";
                ddlMedia.DataSource = dsmedia;
                ddlMedia.DataBind();
                ddlMedia.Items.Insert(0, "Select Media Name");
            }
            else
            {
                ddlMedia.Items.Insert(0, "Select Media Name");
                ddlMedia.Items.Insert(1, "Others");
            }
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        finally
        {
            con.Close();
        }     
    }
    public bool MediaPost(string MesLang, string MesCat, string MesOtherCat, string MesTitle,
                          string MesContent, string MesContentType, DateTime MesPostDate)
    {
        try
        {
            con.Open();
            SqlTransaction myTrans = con.BeginTransaction();
            SqlParameter[] parms = new SqlParameter[10];
            parms[0] = new SqlParameter("@MesLang", SqlDbType.NVarChar);
            parms[0].Value = MesLang;
            parms[1] = new SqlParameter("@MesCat", SqlDbType.NVarChar);
            parms[1].Value = MesCat;
            parms[2] = new SqlParameter("@MesOtherCat", SqlDbType.NVarChar);
            parms[2].Value = MesOtherCat;
            parms[3] = new SqlParameter("@MesTitle", SqlDbType.NVarChar);
            parms[3].Value = MesTitle;
            parms[4] = new SqlParameter("@MesContent", SqlDbType.NVarChar);
            parms[4].Value = MesContent;
            parms[5] = new SqlParameter("@MesContentType", SqlDbType.NVarChar);
            parms[5].Value = MesContentType;
            parms[6] = new SqlParameter("@MesRating", SqlDbType.Int);
            parms[6].Value = 0;
            parms[7] = new SqlParameter("@MesHits", SqlDbType.Int);
            parms[7].Value = 0;
            parms[8] = new SqlParameter("@MesVotes", SqlDbType.Int);
            parms[8].Value = 0;
            parms[9] = new SqlParameter("@MesPostDate", SqlDbType.DateTime);
            parms[9].Value = MesPostDate;

            DBOperations.ExecuteNonQuery(myTrans, CommandType.StoredProcedure, "MediaSpeakPostSP", parms);
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
    public bool MediaUpdate(string MesLang, string MesCat, string MesOtherCat, string MesTitle,
                          string MesContent, string MesContentType,Int32 MedId)
    {
        try
        {
            con.Open();
            SqlTransaction myTrans = con.BeginTransaction();
            SqlParameter[] parms = new SqlParameter[7];
            parms[0] = new SqlParameter("@MesLang", SqlDbType.NVarChar);
            parms[0].Value = MesLang;
            parms[1] = new SqlParameter("@MesCat", SqlDbType.NVarChar);
            parms[1].Value = MesCat;
            parms[2] = new SqlParameter("@MesOtherCat", SqlDbType.NVarChar);
            parms[2].Value = MesOtherCat;
            parms[3] = new SqlParameter("@MesTitle", SqlDbType.NVarChar);
            parms[3].Value = MesTitle;
            parms[4] = new SqlParameter("@MesContent", SqlDbType.NVarChar);
            parms[4].Value = MesContent;
            parms[5] = new SqlParameter("@MesContentType", SqlDbType.NVarChar);
            parms[5].Value = MesContentType;
            parms[6] = new SqlParameter("@MedId", SqlDbType.Int);
            parms[6].Value = MedId;

            DBOperations.ExecuteNonQuery(myTrans, CommandType.StoredProcedure, "MediaSpeakUpdateSP", parms);
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
    public DataSet GetImageName(string ImgName)
    {
        try{
        qry = "select * from Media_Data where Content_image='" + ImgName + "'";

        ds = daccess.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet GetMedia(string lang)
    {
        try{
        qry = "select * from Media_Data where LanguageSpeak='"+lang+"'";

        ds = daccess.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet GetPerticularMedia(string Id)
    {
        try{
        qry = "select *,convert(varchar,postdate,106) as posted_date,datename(dw,Postdate) as day from Media_Data where Medid='" + Id + "'";

        ds = daccess.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public void increment_hit(int count, string id)
    {
        try{
        qry = "update Media_Data set Hits=" + count + "where Medid='" + id + "'";

        ds = daccess.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
    }
    public void increment_rate(int count, string id, int vote)
    {
        try{
        qry = "update Media_Data set Ratings=" + count + ",Votes=" + vote + "where Medid='" + id + "'";

        ds = daccess.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
    }
    public DataSet media_rate(string address, string id)
    {
        try{
        string qry = "select * from mediaRating where Ip_address='" + address + "'and MS_Id='" + id + "'";
        ds = daccess.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet GetMediaRating(Int32 MsId)
    {
        try{
        qry = "select * from MediaRating where MS_Id='" + MsId + "'";
       
        ds = daccess.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public int DeleteMediaRating(Int32 rateId)
    {
        int t = 0;
        try{
        string qry = "select * from MediaRating where mrId=" + rateId;
        t = daccess.ExecuteNonQuery(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return t;
    }
}
