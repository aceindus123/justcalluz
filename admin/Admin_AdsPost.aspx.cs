using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Security.Permissions;
using System.Security;
using System.Configuration;
/// <summary>
/// To post ads from the admin control
/// </summary>
public partial class admin_Admin_AdsPost : System.Web.UI.Page
{
    // creation of object of class
    AdsCS obj=new AdsCS();
    string AdType;
    string VideoImageName;
    string VideoImgContentType;
    string FileName;
    string FileContentType;
    string strScript;
    string Paper;
    string PostedBy;
    DataSet dsgetfilename=new DataSet();
    DataSet ds=new DataSet();    
    bool t;
    string UserId;
    Int32 tvadId;
    string AdSubType;
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
        //loads the page without postbacking the values
        if (!Page.IsPostBack)
        {
            //Fill dropdown list with Type of the ad
            obj.FillAdType(ddlAdType);
            // Fill dropdown list with language of the ad
            obj.FillAdLanguage(ddlLanguage);
            //Fill dropdown list with Cities
            obj.FillAdCity(ddlCity);
            //Fill dropdown list with sub Type of the ad
            obj.FillAdSubType(ddlAdSubType);            
        }
    }
    /// <summary>
    /// Executes whenever we change ad type and checks visibility conditions
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void ddlAdType_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlAdType.SelectedValue == "TV Ads")
        {
            trSubType.Visible = true;
            trLanguage.Visible = true;
            trPaper.Visible = false;            
            trThumbnail.Visible = true;
            trTitle.Visible = false;
            txtTitle.Text = "";
            trUpload.Visible = true;
            trCity.Visible = false;
            ddlCity.SelectedIndex = 0;
            
        }
        else if(ddlAdType.SelectedValue=="Radio Ads")
        {
            trSubType.Visible = false;
            ddlAdSubType.SelectedIndex = 0;
            trLanguage.Visible = true;
            trPaper.Visible = false;            
            trThumbnail.Visible = false;
            trTitle.Visible = true;
            trUpload.Visible = true;
            trCity.Visible = false;
            ddlCity.SelectedIndex = 0;
            
        }
        else if (ddlAdType.SelectedValue == "Print Ads")
        {
            trSubType.Visible = false;
            ddlAdSubType.SelectedIndex = 0;
            trLanguage.Visible = false;
            ddlLanguage.SelectedIndex = 0;
            trPaper.Visible = true;
            trThumbnail.Visible = false;
            trTitle.Visible = false;
            txtTitle.Text = "";
            trUpload.Visible = true;
            trCity.Visible = true;
                    
        }
    }
    /// <summary>
    /// To post form data
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void imgBtnPostAd_Click(object sender, ImageClickEventArgs e)
    {       
        AdType = Convert.ToString(ddlAdType.SelectedValue);
        AdSubType = Convert.ToString(ddlAdSubType.SelectedValue);
        obj.aAdCity = Convert.ToString(ddlCity.SelectedValue);
        obj.aAdLang = Convert.ToString(ddlLanguage.SelectedValue);        
        obj.aAdPaperName = Convert.ToString(txtPaper.Text);       
        obj.aAdTitle = Convert.ToString(txtTitle.Text);
        obj.aAdType = Convert.ToString(ddlAdType.SelectedValue);
        obj.aAdSubType = Convert.ToString(ddlAdSubType.SelectedValue);
        obj.aPostdate = System.DateTime.Now;
        obj.aAdPostedby = UserId;
        if (lblVedioAudioUploadStatus.Text == "true")
        {
            if (MediaAudioPrintAdUpload.HasFile)
            {
                FileName = System.IO.Path.GetFileName(MediaAudioPrintAdUpload.PostedFile.FileName);
                dsgetfilename = obj.GetFileName(FileName);
                if (!dsgetfilename.Tables[0].Rows.Count.Equals(0))
                {
                    strScript = "alert('File name already existed please change name');";
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "alertbox", strScript, true);
                }
                else
                {
                    MediaAudioPrintAdUpload.PostedFile.SaveAs(Server.MapPath("~/Ads/" + FileName));
                    FileContentType = MediaAudioPrintAdUpload.PostedFile.ContentType;
                    obj.aFileContentName = FileName;
                    obj.aFileContentType = FileContentType;

                    if (AdType == "TV Ads")
                    {
                        if (lblImageUploadStatus.Text == "true")
                        {
                            if (ImageUpload.HasFile)
                            {
                                VideoImageName = System.IO.Path.GetFileName(ImageUpload.PostedFile.FileName);
                                ds = obj.GetCaptureFileName(VideoImageName);
                                if (!ds.Tables[0].Rows.Count.Equals(0))
                                {
                                    strScript = "alert('File name already existed please change name');";
                                    Page.ClientScript.RegisterStartupScript(this.GetType(), "alertbox", strScript, true);
                                }
                                else
                                {
                                    using (System.Drawing.Image img1 = System.Drawing.Image.FromStream(ImageUpload.PostedFile.InputStream))
                                    {
                                        ImageUpload.PostedFile.SaveAs(Server.MapPath("~/CaptureImages/" + VideoImageName));
                                        VideoImgContentType = ImageUpload.PostedFile.ContentType;
                                        obj.aImgContent = VideoImageName;
                                        obj.aImgContentType = VideoImgContentType;
                                        if (AdSubType == "AB Ad Films")
                                        {
                                            DataSet dsId = new DataSet();
                                            dsId = obj.GetNewTVAds();
                                            if (dsId.Tables[0].Rows.Count.Equals(3))
                                            {
                                                tvadId = Convert.ToInt32(dsId.Tables[0].Rows[0]["adid"].ToString());
                                                obj.aAdSubTypeOtherId = "AB Ad Films";
                                                obj.aAdSubType = "AB Ad Films(New)";
                                                obj.aId = tvadId;
                                                t = obj.PostAdsIf3(obj.aAdType, obj.aAdSubType, obj.aAdLang, obj.aAdCity, obj.aAdTitle, obj.aAdPaperName,
                                                                    obj.aImgContent, obj.aImgContentType, obj.aFileContentName, obj.aFileContentType,
                                                                    obj.aPostdate, obj.aId, obj.aAdSubTypeOtherId);
                                            }
                                            else
                                            {
                                                obj.aAdSubType = "AB Ad Films(New)";
                                                t = obj.PostAds(obj.aAdType, obj.aAdSubType, obj.aAdLang, obj.aAdCity, obj.aAdTitle, obj.aAdPaperName,
                                          obj.aImgContent, obj.aImgContentType, obj.aFileContentName, obj.aFileContentType, obj.aPostdate,obj.aAdPostedby);
                                                strScript = "alert('Ad is Posted Successfully');location.replace('Admin_Ads.aspx?cat=" + AdType + "');";
                                                Page.ClientScript.RegisterStartupScript(this.GetType(), "alertbox", strScript, true);
                                            }                                            
                                        }
                                        else
                                        {
                                            t = obj.PostAds(obj.aAdType, obj.aAdSubType, obj.aAdLang, obj.aAdCity, obj.aAdTitle, obj.aAdPaperName,
                                          obj.aImgContent, obj.aImgContentType, obj.aFileContentName, obj.aFileContentType, obj.aPostdate,obj.aAdPostedby);
                                            strScript = "alert('Ad is Posted Successfully');location.replace('Admin_Ads.aspx?cat=" + AdType + "');";
                                            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertbox", strScript, true);
                                        }
                                       
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        obj.aImgContent = "";
                        obj.aImgContentType = "";
                        t = obj.PostAds(obj.aAdType, obj.aAdSubType, obj.aAdLang, obj.aAdCity, obj.aAdTitle, obj.aAdPaperName,
                                  obj.aImgContent, obj.aImgContentType, obj.aFileContentName, obj.aFileContentType, obj.aPostdate,obj.aAdPostedby);
                        strScript = "alert('Ad is Posted Successfully');location.replace('Admin_Ads.aspx?cat=" + AdType + "');";
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "alertbox", strScript, true);
                    }
                }
            }
        }
    }
    /// <summary>
    /// Service for Getting the related text by entering text
    /// </summary>
    /// <param name="prefixText"></param>
    /// <returns></returns>
    [System.Web.Script.Services.ScriptMethod()]
    [System.Web.Services.WebMethod]
    public static List<string> GetNewsPaper(string prefixText)
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["connectionstring"]);
        con.Open();
        SqlCommand cmd1 = new SqlCommand("select distinct PaperName from Ads where PaperName like @Name+'%'", con);
        cmd1.Parameters.AddWithValue("@Name", prefixText);
        SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
        DataTable dt1 = new DataTable();
        da1.Fill(dt1);
        List<string> papernames = new List<string>();
        for (int i = 0; i < dt1.Rows.Count; i++)
        {
            papernames.Add(dt1.Rows[i]["PaperName"].ToString());
        }
        con.Close();
        return papernames;
    }
    /// <summary>
    /// Validation for extension of image uploading
    /// </summary>
    /// <param name="source"></param>
    /// <param name="args"></param>
    protected void CVImgUpload_ServerValidate(object source, ServerValidateEventArgs args)
    {              
        string fileext1 =System.IO.Path.GetExtension(ImageUpload.PostedFile.FileName);
        if (fileext1 == ".gif" || fileext1 == ".jpg" || fileext1 == ".jpeg" || fileext1 == ".GIF" || fileext1 == ".JPG" || fileext1 == ".JPEG")
        {
            lblImageUploadStatus.Text = "true";
            args.IsValid = true;
        }
        else
        {
            lblImageUploadStatus.Text = "false";
            CVImgUpload.ErrorMessage = "Please upload .jpg, .jpeg or .gif files only";
            args.IsValid = false;            
        }
    }
    /// <summary>
    /// Validation for extension of file uploading
    /// </summary>
    /// <param name="source"></param>
    /// <param name="args"></param>
    protected void CVFile_ServerValidate(object source, ServerValidateEventArgs args)
    {       
        string fileext = System.IO.Path.GetExtension(MediaAudioPrintAdUpload.PostedFile.FileName);
        AdType = Convert.ToString(ddlAdType.SelectedValue);
        if (AdType == "TV Ads")
        {
            if (fileext == ".wmv")
            {
                lblVedioAudioUploadStatus.Text = "true";
                args.IsValid = true;
            }
            else
            {
                lblVedioAudioUploadStatus.Text = "false";
                CVFile.ErrorMessage = "Please upload .wmv file only";
                args.IsValid = false;
            }
        }
        else if (AdType == "Radio Ads")
        {
            if (fileext == ".mp3")
            {
                lblVedioAudioUploadStatus.Text = "true";
                args.IsValid = true;
            }
            else
            {
                lblVedioAudioUploadStatus.Text = "false";
                CVFile.ErrorMessage = "Please upload .mp3 file only";
                args.IsValid = false;
            }
        }
        else if (AdType == "Print Ads")
        {
            if (fileext == ".gif" || fileext == ".jpg" || fileext == ".jpeg" || fileext == ".GIF" || fileext == ".JPG" || fileext == ".JPEG")
            {
                lblVedioAudioUploadStatus.Text = "true";
                args.IsValid = true;
            }
            else
            {
                lblVedioAudioUploadStatus.Text = "false";
                CVFile.ErrorMessage = "Please upload .jpg, .jpeg or .gif files only";
                args.IsValid = false;
            }
        }               
    }   
}    

