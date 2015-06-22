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
/// To edit Ads posted from admin control
/// </summary>
public partial class admin_Admin_AdsEdit : System.Web.UI.Page
{
    //Creation of objects
    AdsCS obj=new AdsCS();
    DataSet dsgetfilename = new DataSet();
    DataSet ds = new DataSet();
    //Declaration of variables
    string AdType;
    string AdSubType;
    string AdSubType1;
    string AdLang;
    string AdTitle;
    string City;
    string VideoImageName;
    string VideoImgContentType;
    string FileName;
    string FileContentType;
    string strScript;
    string Paper;    
    bool t;
    string UserId;
    string AdId;
    string id;
    public string swfFileName;
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
        AdId = Convert.ToString(Request.QueryString["adid"]);
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
            //Getting perticular Ad information based on Id
            ds = obj.GetPerticularAd(AdId);
            if (Convert.ToString(Request.QueryString["type"]) == "View")
            {
                lblTitle.Text = "View Ad Details";
                pnlAdsInfo.Enabled = false;
            }
            else if (Convert.ToString(Request.QueryString["type"]) == "Edit")
            {
                lblTitle.Text = "Update Ad Details";
                pnlAdsInfo.Enabled = true;
            }
            if (!ds.Tables[0].Rows.Count.Equals(0))
            {
                AdType = ds.Tables[0].Rows[0]["AdType"].ToString();
                AdSubType = ds.Tables[0].Rows[0]["AdSubType"].ToString();
                AdLang = ds.Tables[0].Rows[0]["AdLanguage"].ToString();
                AdTitle = ds.Tables[0].Rows[0]["TitleToDisplay"].ToString();
                City = ds.Tables[0].Rows[0]["City"].ToString();
                Paper = ds.Tables[0].Rows[0]["PaperName"].ToString();
                FileName = ds.Tables[0].Rows[0]["Content_Name"].ToString();
                FileContentType = ds.Tables[0].Rows[0]["Content_Type"].ToString();
                VideoImageName = ds.Tables[0].Rows[0]["CaptureContent_Name"].ToString();
                VideoImgContentType = ds.Tables[0].Rows[0]["CaptureContent_Type"].ToString();               
            }
            // Bind the form fields with the respective database values
            //To bound database ad type value to the Ad type Dropdown list
            for (int i = 0; i < ddlAdType.Items.Count; i++)
            {
                if (ddlAdType.Items[i].Value == AdType.ToString())
                {
                    ddlAdType.SelectedValue = ddlAdType.Items[i].Value;
                    break;
                }
            }
            //Checking visibility conditions
            Conditions();
            lblAdSubType1.Text = AdSubType;
            if (AdSubType == "AB Ad Films(New)")
            {
                AdSubType1 = "AB Ad Films";
            }
            else if (AdSubType == "AB Ad Films")
            {
                AdSubType1 = "AB Ad Films";
            }
            else
            {
                AdSubType1 = AdSubType;
            }
            // To bound database Ad sub type value to the Ad sub type Dropdown list
            for (int i = 0; i < ddlAdSubType.Items.Count; i++)
            {
                if (ddlAdSubType.Items[i].Value == AdSubType1.ToString())
                {
                    ddlAdSubType.SelectedValue = ddlAdSubType.Items[i].Value;
                    break;
                }
            }
            // To bound database language of the ad value to the language Dropdown list
            for (int i = 0; i < ddlLanguage.Items.Count; i++)
            {
                if (ddlLanguage.Items[i].Value == AdLang.ToString())
                {
                    ddlLanguage.SelectedValue = ddlLanguage.Items[i].Value;
                    break;
                }
            }
            // To bound database City value to the City Dropdown list
            for (int i = 0; i < ddlCity.Items.Count; i++)
            {
                if (ddlCity.Items[i].Value == City.ToString())
                {
                    ddlCity.SelectedValue = ddlCity.Items[i].Value;
                    break;
                }
            }            
            txtTitle.Text = Title;
            txtPaper.Text = Paper;
            if (AdType == "Print Ads")
            {                              
                trVideoAudioDisplay.Visible = false;
                trImg.Visible = true;
                trImgThumbnail.Visible = false;
                img.ImageUrl = "../Ads/" + FileName;
            }
            else if (AdType == "TV Ads")
            {
                swfFileName = "../Ads/" + FileName;
                imgThumbnail.ImageUrl = "../CaptureImages/" + VideoImageName;
                trVideoAudioDisplay.Visible = true;
                trImg.Visible = false;
                trImgThumbnail.Visible = true;

            }
            else if (AdType == "Radio Ads")
            {
                swfFileName = "../Ads/" + FileName;
                trVideoAudioDisplay.Visible = true;
                trImg.Visible = false;
                trImgThumbnail.Visible = false;
            }
            lblFileName.Text = FileName;
            lblFileNameContent.Text=FileContentType;
            lblThumblineName.Text = VideoImageName;
            lblThumbContent.Text=VideoImgContentType;
        }
    }
    /// <summary>
    /// To update ads
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void imgBtnUpdateAd_Click(object sender, EventArgs e)
    {
        AdType = Convert.ToString(ddlAdType.SelectedValue);
        obj.aAdCity = Convert.ToString(ddlCity.SelectedValue);
        obj.aAdLang = Convert.ToString(ddlLanguage.SelectedValue);
        obj.aAdPaperName = Convert.ToString(txtPaper.Text);
        obj.aAdSubType = Convert.ToString(lblAdSubType1.Text);
        obj.aAdTitle = Convert.ToString(txtTitle.Text);
        obj.aAdType = Convert.ToString(ddlAdType.SelectedValue);       
        obj.aAdId = Convert.ToInt32(AdId);
        obj.aPostdate = System.DateTime.Now;
        obj.aAdPostedby = UserId;
        if (MediaAudioPrintAdUpload.HasFile)
        {
            FileName = System.IO.Path.GetFileName(MediaAudioPrintAdUpload.PostedFile.FileName);
            dsgetfilename = obj.GetFileName(FileName);
            if (!dsgetfilename.Tables[0].Rows.Count.Equals(0))
            {
                string id1 = ds.Tables[0].Rows[0]["adId"].ToString();
                if (id1 == AdId)
                {
                    MediaAudioPrintAdUpload.PostedFile.SaveAs(Server.MapPath("~/Ads/" + FileName));
                    FileContentType = MediaAudioPrintAdUpload.PostedFile.ContentType;
                    obj.aFileContentName = FileName;
                    obj.aFileContentType = FileContentType;
                    if (AdType == "TV Ads")
                    {
                        if (ImageUpload.HasFile)
                        {
                            VideoImageName = System.IO.Path.GetFileName(ImageUpload.PostedFile.FileName);
                            ds = obj.GetCaptureFileName(VideoImageName);
                            if (!ds.Tables[0].Rows.Count.Equals(0))
                            {
                                id = ds.Tables[0].Rows[0]["adId"].ToString();
                                if (id == AdId)
                                {
                                    using (System.Drawing.Image img1 = System.Drawing.Image.FromStream(ImageUpload.PostedFile.InputStream))
                                    {
                                        ImageUpload.PostedFile.SaveAs(Server.MapPath("~/CaptureImages/" + VideoImageName));
                                        VideoImgContentType = ImageUpload.PostedFile.ContentType;
                                        obj.aImgContent = VideoImageName;
                                        obj.aImgContentType = VideoImgContentType;
                                        t = obj.UpdateAds(obj.aAdType, obj.aAdSubType, obj.aAdLang, obj.aAdCity, obj.aAdTitle, obj.aAdPaperName,
                                             obj.aImgContent, obj.aImgContentType, obj.aFileContentName, obj.aFileContentType, obj.aAdId,obj.aAdPostedby,obj.aPostdate);
                                        strScript = "alert('Ad is Updated Successfully');location.replace('Admin_Ads.aspx?cat=" + AdType + "');";
                                        Page.ClientScript.RegisterStartupScript(this.GetType(), "alertbox", strScript, true);
                                    }

                                }
                                else
                                {
                                    strScript = "alert('File name already existed please change name');location.replace('Admin_AdsEdit.aspx?adid=" + AdId + "');";
                                    Page.ClientScript.RegisterStartupScript(this.GetType(), "alertbox", strScript, true);
                                }
                            }
                        }
                        else
                        {
                            VideoImageName = lblThumblineName.Text;
                            VideoImgContentType = lblThumbContent.Text;
                            obj.aImgContent = VideoImageName;
                            obj.aImgContentType = VideoImgContentType;
                            t = obj.UpdateAds(obj.aAdType, obj.aAdSubType, obj.aAdLang, obj.aAdCity, obj.aAdTitle, obj.aAdPaperName,
                                obj.aImgContent, obj.aImgContentType, obj.aFileContentName, obj.aFileContentType, obj.aAdId, obj.aAdPostedby, obj.aPostdate);
                            strScript = "alert('Ad is Updated Successfully');location.replace('Admin_Ads.aspx?cat=" + AdType + "');";
                            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertbox", strScript, true);
                        }

                    }
                    else
                    {
                        obj.aImgContent = "";
                        obj.aImgContentType = "";
                        t = obj.UpdateAds(obj.aAdType, obj.aAdSubType, obj.aAdLang, obj.aAdCity, obj.aAdTitle, obj.aAdPaperName,
                            obj.aImgContent, obj.aImgContentType, obj.aFileContentName, obj.aFileContentType, obj.aAdId, obj.aAdPostedby, obj.aPostdate);
                        strScript = "alert('Ad is Updated Successfully');location.replace('Admin_Ads.aspx?cat=" + AdType + "');";
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "alertbox", strScript, true);
                    }
                }
                else
                {
                    strScript = "alert('File name already existed please change name');location.replace('Admin_AdsEdit.aspx?adid=" + AdId + "');";
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "alertbox", strScript, true);
                }
            }
            else
            {
                MediaAudioPrintAdUpload.PostedFile.SaveAs(Server.MapPath("~/Ads/" + FileName));
                FileContentType = MediaAudioPrintAdUpload.PostedFile.ContentType;
                obj.aFileContentName = FileName;
                obj.aFileContentType = FileContentType;
                if (AdType == "TV Ads")
                {
                    if (ImageUpload.HasFile)
                    {
                        VideoImageName = System.IO.Path.GetFileName(ImageUpload.PostedFile.FileName);
                        ds = obj.GetCaptureFileName(VideoImageName);
                        if (!ds.Tables[0].Rows.Count.Equals(0))
                        {
                            id = ds.Tables[0].Rows[0]["adId"].ToString();
                            if (id == AdId)
                            {
                                using (System.Drawing.Image img1 = System.Drawing.Image.FromStream(ImageUpload.PostedFile.InputStream))
                                {
                                    ImageUpload.PostedFile.SaveAs(Server.MapPath("~/CaptureImages/" + VideoImageName));
                                    VideoImgContentType = ImageUpload.PostedFile.ContentType;
                                    obj.aImgContent = VideoImageName;
                                    obj.aImgContentType = VideoImgContentType;
                                    t = obj.UpdateAds(obj.aAdType, obj.aAdSubType, obj.aAdLang, obj.aAdCity, obj.aAdTitle, obj.aAdPaperName,
                                         obj.aImgContent, obj.aImgContentType, obj.aFileContentName, obj.aFileContentType, obj.aAdId, obj.aAdPostedby, obj.aPostdate);
                                    strScript = "alert('Ad is Updated Successfully');location.replace('Admin_Ads.aspx?cat=" + AdType + "');";
                                    Page.ClientScript.RegisterStartupScript(this.GetType(), "alertbox", strScript, true);
                                }
                            }
                            else
                            {
                                strScript = "alert('File name already existed please change name');location.replace('Admin_AdsEdit.aspx?adid=" + AdId + "');";
                                Page.ClientScript.RegisterStartupScript(this.GetType(), "alertbox", strScript, true);
                            }
                        }
                        else
                        {
                            using (System.Drawing.Image img1 = System.Drawing.Image.FromStream(ImageUpload.PostedFile.InputStream))
                            {
                                ImageUpload.PostedFile.SaveAs(Server.MapPath("~/CaptureImages/" + VideoImageName));
                                VideoImgContentType = ImageUpload.PostedFile.ContentType;
                                obj.aImgContent = VideoImageName;
                                obj.aImgContentType = VideoImgContentType;
                                t = obj.UpdateAds(obj.aAdType, obj.aAdSubType, obj.aAdLang, obj.aAdCity, obj.aAdTitle, obj.aAdPaperName,
                                     obj.aImgContent, obj.aImgContentType, obj.aFileContentName, obj.aFileContentType, obj.aAdId, obj.aAdPostedby, obj.aPostdate);
                                strScript = "alert('Ad is Updated Successfully');location.replace('Admin_Ads.aspx?cat=" + AdType + "');";
                                Page.ClientScript.RegisterStartupScript(this.GetType(), "alertbox", strScript, true);
                            }
                        }
                    }
                    else
                    {
                        VideoImageName = lblThumblineName.Text;
                        VideoImgContentType = lblThumbContent.Text;
                        obj.aImgContent = VideoImageName;
                        obj.aImgContentType = VideoImgContentType;
                        t = obj.UpdateAds(obj.aAdType, obj.aAdSubType, obj.aAdLang, obj.aAdCity, obj.aAdTitle, obj.aAdPaperName,
                            obj.aImgContent, obj.aImgContentType, obj.aFileContentName, obj.aFileContentType, obj.aAdId, obj.aAdPostedby, obj.aPostdate);
                        strScript = "alert('Ad is Updated Successfully');location.replace('Admin_Ads.aspx?cat=" + AdType + "');";
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "alertbox", strScript, true);
                    }

                }
                else
                {
                    obj.aImgContent = "";
                    obj.aImgContentType = "";
                    t = obj.UpdateAds(obj.aAdType, obj.aAdSubType, obj.aAdLang, obj.aAdCity, obj.aAdTitle, obj.aAdPaperName,
                        obj.aImgContent, obj.aImgContentType, obj.aFileContentName, obj.aFileContentType, obj.aAdId, obj.aAdPostedby, obj.aPostdate);
                    strScript = "alert('Ad is Updated Successfully');location.replace('Admin_Ads.aspx?cat=" + AdType + "');";
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "alertbox", strScript, true);
                }
            }
        }
        else
        {
            FileName = lblFileName.Text;
            FileContentType = lblFileNameContent.Text;
            obj.aFileContentName = FileName;
            obj.aFileContentType = FileContentType;
            if (AdType == "TV Ads")
            {
                if (ImageUpload.HasFile)
                {
                    VideoImageName = System.IO.Path.GetFileName(ImageUpload.PostedFile.FileName);
                    ds = obj.GetCaptureFileName(VideoImageName);
                    if (!ds.Tables[0].Rows.Count.Equals(0))
                    {
                        id = ds.Tables[0].Rows[0]["adId"].ToString();
                        if (id == AdId)
                        {
                            using (System.Drawing.Image img1 = System.Drawing.Image.FromStream(ImageUpload.PostedFile.InputStream))
                            {
                                ImageUpload.PostedFile.SaveAs(Server.MapPath("~/CaptureImages/" + VideoImageName));
                                VideoImgContentType = ImageUpload.PostedFile.ContentType;
                                obj.aImgContent = VideoImageName;
                                obj.aImgContentType = VideoImgContentType;
                                t = obj.UpdateAds(obj.aAdType, obj.aAdSubType, obj.aAdLang, obj.aAdCity, obj.aAdTitle, obj.aAdPaperName,
                                    obj.aImgContent, obj.aImgContentType, obj.aFileContentName, obj.aFileContentType, obj.aAdId, obj.aAdPostedby, obj.aPostdate);
                                strScript = "alert('Ad is Updated Successfully');location.replace('Admin_Ads.aspx?cat=" + AdType + "');";
                                Page.ClientScript.RegisterStartupScript(this.GetType(), "alertbox", strScript, true);
                            }
                        }
                        else
                        {
                            strScript = "alert('File name already existed please change name');location.replace('Admin_AdsEdit.aspx?adid=" + AdId + "');";
                            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertbox", strScript, true);
                        }
                    }
                    else
                    {
                        using (System.Drawing.Image img1 = System.Drawing.Image.FromStream(ImageUpload.PostedFile.InputStream))
                        {
                            ImageUpload.PostedFile.SaveAs(Server.MapPath("~/CaptureImages/" + VideoImageName));
                            VideoImgContentType = ImageUpload.PostedFile.ContentType;
                            obj.aImgContent = VideoImageName;
                            obj.aImgContentType = VideoImgContentType;
                            t = obj.UpdateAds(obj.aAdType, obj.aAdSubType, obj.aAdLang, obj.aAdCity, obj.aAdTitle, obj.aAdPaperName,
                                 obj.aImgContent, obj.aImgContentType, obj.aFileContentName, obj.aFileContentType, obj.aAdId, obj.aAdPostedby, obj.aPostdate);
                            strScript = "alert('Ad is Updated Successfully');location.replace('Admin_Ads.aspx?cat=" + AdType + "');";
                            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertbox", strScript, true);
                        }
                    }
                }
                else
                {
                    VideoImageName = lblThumblineName.Text;
                    VideoImgContentType = lblThumbContent.Text;
                    obj.aImgContent = VideoImageName;
                    obj.aImgContentType = VideoImgContentType;
                    t = obj.UpdateAds(obj.aAdType, obj.aAdSubType, obj.aAdLang, obj.aAdCity, obj.aAdTitle, obj.aAdPaperName,
                        obj.aImgContent, obj.aImgContentType, obj.aFileContentName, obj.aFileContentType, obj.aAdId, obj.aAdPostedby, obj.aPostdate);
                    strScript = "alert('Ad is Updated Successfully');location.replace('Admin_Ads.aspx?cat=" + AdType + "');";
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "alertbox", strScript, true);
                }
            }
            else
            {
                obj.aImgContent = "";
                obj.aImgContentType = "";
                t = obj.UpdateAds(obj.aAdType, obj.aAdSubType, obj.aAdLang, obj.aAdCity, obj.aAdTitle, obj.aAdPaperName,
                    obj.aImgContent, obj.aImgContentType, obj.aFileContentName, obj.aFileContentType, obj.aAdId, obj.aAdPostedby, obj.aPostdate);
                strScript = "alert('Ad is Updated Successfully');location.replace('Admin_Ads.aspx?cat=" + AdType + "');";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "alertbox", strScript, true);
            }            
        }                
    }
    /// <summary>
    /// Executes whenever we change ad type
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void ddlAdType_SelectedIndexChanged(object sender, EventArgs e)
    {
        Conditions();
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
    /// visibility conditions of the table
    /// </summary>
    public void Conditions()
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
        else if (ddlAdType.SelectedValue == "Radio Ads")
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
    /// Validation for extension of image uploading
    /// </summary>
    /// <param name="source"></param>
    /// <param name="args"></param>
    protected void CVImgUpload_ServerValidate(object source, ServerValidateEventArgs args)
    {
        string fileext1 = System.IO.Path.GetExtension(ImageUpload.PostedFile.FileName);
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
    protected void imbBtnCancel_Click(object sender, EventArgs e)
    {
        AdType = Convert.ToString(ddlAdType.SelectedValue);
        Response.Redirect("Admin_Ads.aspx?cat=" + AdType);
    }
}
