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
/// Summary description for AdsCS
/// </summary>
public class AdsCS
{
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    public DataAccess obj = new DataAccess();
    public DataCS data = new DataCS();
    string qry;
    DataSet ds=new DataSet();
    DataTable dt = new DataTable();
    string script = string.Empty;
	public AdsCS()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    private Int32 Id;
    private Int32 AdId;
    private string AdType;
    private string AdSubType;
    private string AdSubTypeNew;
    private string AdLang;
    private string AdCity;
    private string AdTitle;
    private string AdPaperName;
    private string AdImgContent;
    private string AdImgContentType;
    private string AdFileContentName;
    private string AdFileContentType;
    private DateTime AdPostdate;
    private string AdPostedby;
    public Int32 aId
    {
        get { return Id; }
        set { Id = value; }
    }
    public Int32 aAdId
    {
        get { return AdId; }
        set { AdId = value; }
    }
    public string aAdType
    {
        get { return AdType; }
        set { AdType = value; }
    }
    public string aAdSubType
    {
        get { return AdSubType; }
        set { AdSubType = value; }
    }
    public string aAdSubTypeOtherId
    {
        get { return AdSubTypeNew; }
        set { AdSubTypeNew = value; }
    }
    public string aAdLang
    {
        get { return AdLang; }
        set { AdLang = value; }
    }
    public string aAdCity
    {
        get { return AdCity; }
        set { AdCity = value; }
    }
    public string aAdTitle
    {
        get { return AdTitle; }
        set { AdTitle = value; }
    }
    public string aAdPaperName
    {
        get { return AdPaperName; }
        set { AdPaperName = value; }
    }
    public string aImgContent
    {
        get { return AdImgContent; }
        set { AdImgContent = value; }
    }
    public string aImgContentType
    {
        get { return AdImgContentType; }
        set { AdImgContentType = value; }
    }
    public string aFileContentName
    {
        get { return AdFileContentName; }
        set { AdFileContentName = value; }
    }
    public string aFileContentType
    {
        get { return AdFileContentType; }
        set { AdFileContentType = value; }
    }
    public string aAdPostedby
    {
        get { return AdPostedby; }
        set { AdPostedby = value; }
    }
    public DateTime aPostdate
    {
        get { return AdPostdate; }
        set { AdPostdate = value; }
    }

    public void FillAdType(DropDownList dpc)
    {
        try
        {
            data.FillDrop(dpc, "select * from AdType", "adtype", "adtype", "Select Ad Type");
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
    }
    public void FillAdSubType(DropDownList dpc)
    {
        try
        {
            data.FillDrop(dpc, "select * from AdSubType", "adsubtype", "adsubtype", "Select");
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
    }
    public void FillAdLanguage(DropDownList dpc)
    {
        try
        {
            data.FillDrop(dpc, "select * from Ads_Language", "adLanguage", "adLanguage", "Select Language");
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
    }
    public void FillAdCity(DropDownList dpc)
    {
        try
        {
            data.FillDrop(dpc, "select distinct City from City_NewsPapers", "City", "City", "Select City");
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
    }    
    public void FillAdNewsPaper(string City, DropDownList ddlPapaer)
    {
        try
        {
            qry = "select * from City_NewsPapers where City='" + City + "'";
            //con.Open();
            SqlDataAdapter ada = new SqlDataAdapter(qry, con);
            ada.Fill(ds, "Paper");
            if (!ds.Tables[0].Rows.Count.Equals(0))
            {
                ddlPapaer.DataSource = ds;
                ddlPapaer.DataValueField = "PaperName";
                ddlPapaer.DataTextField = "PaperName";
                ddlPapaer.DataBind();
                ddlPapaer.Items.Insert(0, "Select News Paper");
            }
            else
            {
                ddlPapaer.Visible = false;
            }
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        //con.Close();
    }
    public bool PostAds(string TypeAd, string SubType, string Lang, string City, string Title, string PaperName, string ImgContent,
                        string ImgContentType, string FileContentName, string FileContentType, DateTime Postdate,string PostedBy)
    {
        try
        {
            con.Open();
            SqlTransaction myTrans = con.BeginTransaction();
            SqlParameter[] parms = new SqlParameter[12];
            parms[0] = new SqlParameter("@TypeAd", SqlDbType.NVarChar);
            parms[0].Value = TypeAd;
            parms[1] = new SqlParameter("@SubType", SqlDbType.NVarChar);
            parms[1].Value = SubType;
            parms[2] = new SqlParameter("@Lang", SqlDbType.NVarChar);
            parms[2].Value = Lang;
            parms[3] = new SqlParameter("@City", SqlDbType.NVarChar);
            parms[3].Value = City;
            parms[4] = new SqlParameter("@Title", SqlDbType.NVarChar);
            parms[4].Value = Title;
            parms[5] = new SqlParameter("@PaperName", SqlDbType.NVarChar);
            parms[5].Value = PaperName;
            parms[6] = new SqlParameter("@ImgContent", SqlDbType.NVarChar);
            parms[6].Value = ImgContent;
            parms[7] = new SqlParameter("@ImgContentType", SqlDbType.NVarChar);
            parms[7].Value = ImgContentType;
            parms[8] = new SqlParameter("@FileContentName", SqlDbType.NVarChar);
            parms[8].Value = FileContentName;
            parms[9] = new SqlParameter("@FileContentType", SqlDbType.NVarChar);
            parms[9].Value = FileContentType;
            parms[10] = new SqlParameter("@Postdate", SqlDbType.DateTime);
            parms[10].Value = Postdate;
            parms[11] = new SqlParameter("@PostedBy", SqlDbType.NVarChar);
            parms[11].Value = PostedBy;
            DBOperations.ExecuteNonQuery(myTrans, CommandType.StoredProcedure, "PostAdsSP", parms);
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
    public bool PostAdsIf3(string TypeAd, string SubType, string Lang, string City, string Title, string PaperName, string ImgContent,
                        string ImgContentType, string FileContentName, string FileContentType, DateTime Postdate,Int32 IdToUpdate,string SubTypeOtherId)
    {
        try
        {
            con.Open();
            SqlTransaction myTrans = con.BeginTransaction();
            SqlParameter[] parms = new SqlParameter[13];
            parms[0] = new SqlParameter("@TypeAd", SqlDbType.NVarChar);
            parms[0].Value = TypeAd;
            parms[1] = new SqlParameter("@SubType", SqlDbType.NVarChar);
            parms[1].Value = SubType;
            parms[2] = new SqlParameter("@Lang", SqlDbType.NVarChar);
            parms[2].Value = Lang;
            parms[3] = new SqlParameter("@City", SqlDbType.NVarChar);
            parms[3].Value = City;
            parms[4] = new SqlParameter("@Title", SqlDbType.NVarChar);
            parms[4].Value = Title;
            parms[5] = new SqlParameter("@PaperName", SqlDbType.NVarChar);
            parms[5].Value = PaperName;
            parms[6] = new SqlParameter("@ImgContent", SqlDbType.NVarChar);
            parms[6].Value = ImgContent;
            parms[7] = new SqlParameter("@ImgContentType", SqlDbType.NVarChar);
            parms[7].Value = ImgContentType;
            parms[8] = new SqlParameter("@FileContentName", SqlDbType.NVarChar);
            parms[8].Value = FileContentName;
            parms[9] = new SqlParameter("@FileContentType", SqlDbType.NVarChar);
            parms[9].Value = FileContentType;
            parms[10] = new SqlParameter("@Postdate", SqlDbType.DateTime);
            parms[10].Value = Postdate;
            parms[11] = new SqlParameter("@IdToUpdate", SqlDbType.Int);
            parms[11].Value = IdToUpdate;
            parms[12] = new SqlParameter("@SubTypeOtherId", SqlDbType.NVarChar);
            parms[12].Value = SubTypeOtherId;
            DBOperations.ExecuteNonQuery(myTrans, CommandType.StoredProcedure, "PostAdsIf3SP", parms);
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
    public bool UpdateAds(string TypeAd, string SubType, string Lang, string City, string Title, string PaperName, string ImgContent,
                       string ImgContentType, string FileContentName, string FileContentType,Int32 Id,string editedby,DateTime editdate)
    {
        try
        {
            con.Open();
            SqlTransaction myTrans = con.BeginTransaction();
            SqlParameter[] parms = new SqlParameter[13];
            parms[0] = new SqlParameter("@TypeAd", SqlDbType.NVarChar);
            parms[0].Value = TypeAd;
            parms[1] = new SqlParameter("@SubType", SqlDbType.NVarChar);
            parms[1].Value = SubType;
            parms[2] = new SqlParameter("@Lang", SqlDbType.NVarChar);
            parms[2].Value = Lang;
            parms[3] = new SqlParameter("@City", SqlDbType.NVarChar);
            parms[3].Value = City;
            parms[4] = new SqlParameter("@Title", SqlDbType.NVarChar);
            parms[4].Value = Title;
            parms[5] = new SqlParameter("@PaperName", SqlDbType.NVarChar);
            parms[5].Value = PaperName;
            parms[6] = new SqlParameter("@ImgContent", SqlDbType.NVarChar);
            parms[6].Value = ImgContent;
            parms[7] = new SqlParameter("@ImgContentType", SqlDbType.NVarChar);
            parms[7].Value = ImgContentType;
            parms[8] = new SqlParameter("@FileContentName", SqlDbType.NVarChar);
            parms[8].Value = FileContentName;
            parms[9] = new SqlParameter("@FileContentType", SqlDbType.NVarChar);
            parms[9].Value = FileContentType;
            parms[10] = new SqlParameter("@Id", SqlDbType.Int);
            parms[10].Value = Id;
            parms[11] = new SqlParameter("@editedby", SqlDbType.NVarChar);
            parms[11].Value = editedby;
            parms[12] = new SqlParameter("@editdate", SqlDbType.DateTime);
            parms[12].Value = editdate;
            DBOperations.ExecuteNonQuery(myTrans, CommandType.StoredProcedure, "UpdateAdsSP", parms);
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
    public DataSet GetFileName(string filename)
    { 
        try
        {
        qry = "select * from Ads where Content_Name='" + filename + "'";
        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet GetCaptureFileName(string filename)
    {
        try
        {
        qry = "select * from Ads where CaptureContent_Name='" + filename + "'";
        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet GetAds(string Cat)
    {
        try
        {
        qry = "select * from Ads where AdType='"+Cat+"'";
        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet GetPerticularAd(string id)
    {
        try
        {
        qry = "select * from Ads where adId='" + id + "'";
        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataTable GetAdReviews()
    {
        try{
        qry = "Select * from Adreviews order by id desc";
        dt = obj.ExcuteQrydt(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return dt;
    }
    public int DeleteReviewComments(Int32 RId)
    {
        int t = 0;
        try
        {
        qry = "delete Adreviews where id=" + RId;
        t = obj.ExecuteNonQuery(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return t;
    }
    public DataSet printad_cities()
    {
        try
        {
        string qry = "select distinct city from Ads where AdType='Print Ads'";
        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet print_paper(string city)
    {
        try
        {
        string qry = "select PaperName,Content_Name from Ads where AdType='Print Ads' and City='" + city + "'";
        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet print_paperad(string paperad, string city)
    {
        try
        {
        string qry = "select Content_Name from Ads where AdType='Print Ads' and PaperName='" + paperad + "' and City='" + city + "'";
        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet bindradioads(string lang)
    {
        try
        {
        qry = "select * from Ads where AdType='Radio Ads' and AdLanguage='" + lang + "'";
        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet bindtvads(string subad, string lang)
    {
        try
        {
        string qry = "select * from Ads where AdSubType='" + subad + "'and AdType='TV Ads' and AdLanguage='" + lang + "'";
        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet tvad_lang(string subtype)
    {
        try
        {
        string qry = "select distinct AdLanguage from Ads where AdType='TV Ads' and AdSubType='" + subtype + "'";
        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet radio_lang()
    {
        try{
        string qry = "select distinct AdLanguage from Ads where AdType='Radio Ads'";
        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet tvad_rate(string address, string ad)
    {
        try{
        string qry = "select * from Tvad_Reviews where Ip_address='" + address + "'and AdsubType='" + ad + "'";
        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataTable GetTVAdRatings()
    {
        try
        {
        string qry = "select *,CONVERT(varchar, post_date, 106) as postdate from Tvad_Reviews order by Id desc";
        dt = obj.ExcuteQrydt(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return dt;
    }
    public int DeleteTVAdRatings(Int32 rateId)
    {
        int t = 0; ;
        try{
        string qry =" delete Tvad_Reviews where Id="+rateId;
        t = obj.ExecuteNonQuery(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return t;       
    }
    public DataSet GetNewTVAds()
    {
        try
        {
        string qry = "select adid from Ads where AdSubType='AB Ad Films(New)' order by adid";
        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
}
