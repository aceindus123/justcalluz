using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
/// <summary>
/// Class to post media speak
/// </summary>
public partial class admin_Admin_MediaPost : System.Web.UI.Page
{
    //declaration of variables and creation of object for class
    MediaCS med = new MediaCS();
    string Lang;
    string MediaName;
    string ImgContent;
    string ImgContentType;
    string strScript;
    bool t;
    string UserId;
    DataSet dsGetPhoto = new DataSet();
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
        if (!IsPostBack)
        {
            med.FillLanguage(ddlLang);
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
            med.FillMediaNames(Lang,ddlMediaName);
        }
        else
        {
            ddlLang.Items.Clear();
            ddlLang.Items.Insert(0, "Select Language");
        }
    }
    /// <summary>
    ///  Click event to post media speak
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void imgBtnPostMediaSpeak_Click(object sender, ImageClickEventArgs e)
    {
        med.MsLang =Convert.ToString(ddlLang.SelectedValue);
        med.MsCat = Convert.ToString(ddlMediaName.SelectedValue);
        med.MsOtherCat = Convert.ToString(txtOtherMedia.Text);
        med.MsPostdate=System.DateTime.Now;
        med.MsTitle = Convert.ToString(txtTitle.Text);
        if(MediaImageUpload.HasFile)
        {
            ImgContent=System.IO.Path.GetFileName(MediaImageUpload.PostedFile.FileName);
            dsGetPhoto=med.GetImageName(ImgContent);
            if (!dsGetPhoto.Tables[0].Rows.Count.Equals(0))
            {
                strScript = "alert('Image name already existed please change Image Name');";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
            }
            else
            {
                if(MediaImageUpload.PostedFile.ContentLength<500000)
                {
                    using(System.Drawing.Image Img=System.Drawing.Image.FromStream(MediaImageUpload.PostedFile.InputStream))
                    {
                        MediaImageUpload.PostedFile.SaveAs(Server.MapPath("~/MediaImg/" + ImgContent));
                        ImgContentType=MediaImageUpload.PostedFile.ContentType;
                        med.MsImageContent=Convert.ToString(ImgContent);
                        med.MsImgContentType=Convert.ToString(ImgContentType);
                        t=med.MediaPost(med.MsLang,med.MsCat,med.MsOtherCat,med.MsTitle,
                                        med.MsImageContent,med.MsImgContentType,med.MsPostdate);
                        if(t==true)
                        {
                            strScript = "alert('Media Speak is posted Sucessfully');";
                            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);                            
                        }
                    }
                }
                else
                {
                    strScript = "alert('You can not Upload the Image because size of the image exeeds the limit');";
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);                            
                }
            }
        }
        else
        {
            strScript = "alert('Please Upload an Image');";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);   
        }        
    }
    /// <summary>
    /// Executes whenever media name selection is changed
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void ddlMediaName_SelectedIndexChanged(object sender, EventArgs e)
    {
        MediaName=ddlMediaName.SelectedValue;
        if (MediaName == "Others")
        {
            trOtherCat.Visible = true;
        }
        else
        {
            trOtherCat.Visible = false;
        }
    }
}
