using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
/// <summary>
/// Class to update media speak
/// </summary>
public partial class admin_Admin_MediaEdit : System.Web.UI.Page
{
    //declaration of variables and creation of object for class
    MediaCS med = new MediaCS();
    string Lang;
    string MediaName;
    string ArticleTitle;
    string MediaNameOther;
    string ImgContent;
    string ImgContentType;
    string strScript;
    bool t;
    string UserId;
    Int32 MSId;
    DataSet dsGetPhoto = new DataSet();
    DataSet ds = new DataSet();
    Int32 Id;
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
        MSId = Convert.ToInt32(Request.QueryString["medid"].ToString());
        //loads the page without postbacking the values
        if (!IsPostBack)
        {
            //fill laguage of the media speak
            med.FillLanguage(ddlLang);
            // get perticlar media speak data
            ds = med.GetPerticularMedia(Convert.ToString(MSId));
            // assigning form fields with database values
            if (!ds.Tables[0].Rows.Count.Equals(0))
            {
                Lang = ds.Tables[0].Rows[0]["LanguageSpeak"].ToString();
                ArticleTitle = ds.Tables[0].Rows[0]["Title"].ToString();
                MediaName = ds.Tables[0].Rows[0]["Category"].ToString();
                MediaNameOther = ds.Tables[0].Rows[0]["OtherCat"].ToString();
                ImgContent = ds.Tables[0].Rows[0]["Content_Image"].ToString();
                ImgContentType = ds.Tables[0].Rows[0]["Content_ImageType"].ToString();
            }           
            txtTitle.Text = ArticleTitle;
            for (int i = 0; i < ddlLang.Items.Count; i++)
            {
                if (ddlLang.Items[i].Value == Lang.ToString())
                {
                    ddlLang.SelectedValue = ddlLang.Items[i].Value;
                    Lang = ddlLang.SelectedItem.Text;
                }
            }
            med.FillMediaNames(Lang, ddlMediaName);
            for (int i = 0; i < ddlMediaName.Items.Count; i++)
            {
                if (ddlMediaName.Items[i].Value == MediaName.ToString())
                {
                    ddlMediaName.SelectedValue = ddlMediaName.Items[i].Value;
                }
            }
            txtOtherMedia.Text = MediaNameOther;
            imgMediaSpeak.ImageUrl = "../MediaImg/" + ImgContent;
            lblImgContent.Text = ImgContent;
            lblImgContentType.Text = ImgContentType;
        }
    }
    /// <summary>
    /// Executes whenever language selection is changed
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void ddlLang_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlLang.SelectedIndex != 0)
        {
            Lang = ddlLang.SelectedValue.ToString();
            med.FillMediaNames(Lang, ddlMediaName);
        }
        else
        {
            ddlLang.Items.Clear();
            ddlLang.Items.Insert(0, "Select Language");
        }
    }
    /// <summary>
    /// Executes whenever media name selection is changed
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void ddlMediaName_SelectedIndexChanged(object sender, EventArgs e)
    {
        MediaName = ddlMediaName.SelectedValue;
        if (MediaName == "Others")
        {
            trOtherCat.Visible = true;
        }
        else
        {
            trOtherCat.Visible = false;
        }
    }
    /// <summary>
    /// Click event to update media speak
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void imgBtnUpdateMediaSpeak_Click(object sender, ImageClickEventArgs e)
    {
        Lang=Convert.ToString(ddlLang.SelectedValue);
        med.MsLang = Convert.ToString(ddlLang.SelectedValue);
        med.MsCat = Convert.ToString(ddlMediaName.SelectedValue);
        med.MsOtherCat = Convert.ToString(txtOtherMedia.Text);
        med.MsPostdate = System.DateTime.Now;
        med.MsTitle = Convert.ToString(txtTitle.Text);
        med.MsId=MSId;
        if (MediaImageUpload.HasFile)
        {
            ImgContent = System.IO.Path.GetFileName(MediaImageUpload.PostedFile.FileName);
            dsGetPhoto = med.GetImageName(ImgContent);
            if (!dsGetPhoto.Tables[0].Rows.Count.Equals(0))
            {
                Id = Convert.ToInt32(dsGetPhoto.Tables[0].Rows[0]["Medid"].ToString());
                if (Id == MSId)
                {
                    if (MediaImageUpload.PostedFile.ContentLength < 500000)
                    {
                        using (System.Drawing.Image Img = System.Drawing.Image.FromStream(MediaImageUpload.PostedFile.InputStream))
                        {
                            MediaImageUpload.PostedFile.SaveAs(Server.MapPath("~/MediaImg/" + ImgContent));
                            ImgContentType = MediaImageUpload.PostedFile.ContentType;
                            med.MsImageContent = Convert.ToString(ImgContent);
                            med.MsImgContentType = Convert.ToString(ImgContentType);
                            t = med.MediaUpdate(med.MsLang, med.MsCat, med.MsOtherCat, med.MsTitle,
                                            med.MsImageContent, med.MsImgContentType, med.MsId);
                            if (t == true)
                            {
                                strScript = "alert('Media Speak is updated Sucessfully');location.replace('Admin_Media.aspx?lang=" + Lang + "');";
                                Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                            }
                        }
                    }
                    else
                    {
                        strScript = "alert('You can not Upload the Image because size of the image exeeds the limit');location.replace('Admin_MediaEdit.aspx?medid=" + MSId + "');";
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                    }

                }
                else
                {
                    strScript = "alert('Image name already existed please change Image Name');location.replace('Admin_MediaEdit.aspx?medid=" + MSId + "');";
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                }
            }
            else
            {
                if (MediaImageUpload.PostedFile.ContentLength < 500000)
                {
                    using (System.Drawing.Image Img = System.Drawing.Image.FromStream(MediaImageUpload.PostedFile.InputStream))
                    {
                        MediaImageUpload.PostedFile.SaveAs(Server.MapPath("~/MediaImg/" + ImgContent));
                        ImgContentType = MediaImageUpload.PostedFile.ContentType;
                        med.MsImageContent = Convert.ToString(ImgContent);
                        med.MsImgContentType = Convert.ToString(ImgContentType);
                        t = med.MediaUpdate(med.MsLang, med.MsCat, med.MsOtherCat, med.MsTitle,
                                        med.MsImageContent, med.MsImgContentType, med.MsId);
                        if (t == true)
                        {
                            strScript = "alert('Media Speak is updated Sucessfully');location.replace('Admin_Media.aspx?lang=" + Lang + "');";
                            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                        }
                    }
                }
                else
                {
                    strScript = "alert('You can not Upload the Image because size of the image exeeds the limit');location.replace('Admin_MediaEdit.aspx?medid=" + MSId + "');";
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                }
            }
        }
        else
        {
            med.MsImageContent = Convert.ToString(lblImgContent.Text);
            med.MsImgContentType = Convert.ToString(lblImgContentType.Text);
            t = med.MediaUpdate(med.MsLang, med.MsCat, med.MsOtherCat, med.MsTitle,
                            med.MsImageContent, med.MsImgContentType, med.MsId);
            if (t == true)
            {
                strScript = "alert('Media Speak is updated Sucessfully');location.replace('Admin_Media.aspx?lang=" + Lang + "');";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
            }
        }        
    }
    protected void imbBtnCancel_Click(object sender, ImageClickEventArgs e)
    {
        Lang = Convert.ToString(ddlLang.SelectedValue);
        Response.Redirect("Admin_Media.aspx?lang=" + Lang);
    }
}
