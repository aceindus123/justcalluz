using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class admin_Admin_CSRGallaryPost : System.Web.UI.Page
{
    string PhotoName;
    string PhotoContentType;
    string strScript;
    bool t;
    DataSet dsGetPhotoName = new DataSet();
    DataTable dt = new DataTable();
    CSRCS obj = new CSRCS();
    string csrID;
    string UserId;
    PagedDataSource pds = new PagedDataSource();
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
        csrID = Convert.ToString(Request.QueryString["csrid"]);
        if (!Page.IsPostBack)
        {
            BindPhotos();
        }
    }
    public void BindPhotos()
    {
        dt = obj.GetCSRImg_ById(csrID);
        if (dt.Rows.Count > 0)
        {
            //Session["id"] = id;
            pds.DataSource = dt.DefaultView;
            pds.AllowPaging = true;
            pds.PageSize = 5;
            pds.CurrentPageIndex = CurrentPage;
            lnkbtnNext.Enabled = !pds.IsLastPage;
            lnkbtnPrevious.Enabled = !pds.IsFirstPage;
            dlPhotos.DataSource = pds;
            dlPhotos.DataBind();
            lnkbtnNext.Visible = true;
            lnkbtnPrevious.Visible = true;
            lblMsg.Text = "";
        }
        else
        {
            lblMsg.Text = "No Images are uploaded. Please upload images";
        }
    }
    /// <summary>
    /// To put current page status
    /// </summary>
    public int CurrentPage
    {
        get
        {
            if (this.ViewState["CurrentPage"] == null)
                return 0;
            else
                return Convert.ToInt16(this.ViewState["CurrentPage"].ToString());
        }
        set
        {
            this.ViewState["CurrentPage"] = value;
        }
    }
   
    /// <summary>
    /// Function to go prevoius page
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lnkbtnPrevious_Click1(object sender, EventArgs e)
    {
        CurrentPage -= 1;
        BindPhotos();
    }
    /// <summary>
    /// Function to go next page
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lnkbtnNext_Click1(object sender, EventArgs e)
    {
        CurrentPage += 1;
        BindPhotos();    
    }
    /// <summary>
    /// To change page size
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void ddlPageSize_SelectedIndexChanged(object sender, EventArgs e)
    {
        CurrentPage = 0;
        BindPhotos();
    }    
    protected void imgBtnPostCSR_Click(object sender, ImageClickEventArgs e)
    {
        if (ImgUpload.HasFile)
        {
            if (lblImageUploadStatus.Text == "true")
            {
                PhotoName = System.IO.Path.GetFileName(ImgUpload.PostedFile.FileName);
                dsGetPhotoName = obj.GetImgName(PhotoName);
                if (!dsGetPhotoName.Tables[0].Rows.Count.Equals(0))
                {
                    strScript = "alert('Image name already existed please change name');";
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "alertbox", strScript, true);
                }
                else
                {
                    ImgUpload.PostedFile.SaveAs(Server.MapPath("~/CSR_Photos/" + PhotoName));
                    PhotoContentType = ImgUpload.PostedFile.ContentType;
                    obj.aImgName = PhotoName;
                    obj.aImgContentType = PhotoContentType;
                    obj.acsrId =Convert.ToInt32(csrID);
                    obj.aPostedby = UserId;
                    obj.aPostedate = System.DateTime.Now;
                    t = obj.CSRGalleryPost(obj.aImgName, obj.aImgContentType,obj.acsrId,obj.aPostedby,obj.aPostedate);
                    strScript = "alert('CSR is posted successfully.');location.replace('Admin_CSRGallaryPost.aspx?csrid="+csrID+"');";
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "alertbox", strScript, true);
                }
            }
        }
    }
    protected void CVImgUpload_ServerValidate(object source, ServerValidateEventArgs args)
    {
        string fileext1 = System.IO.Path.GetExtension(ImgUpload.PostedFile.FileName);
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
    protected void DeleteCSRImg(object sender, CommandEventArgs e)
    {
        Int32 Id = Convert.ToInt32(e.CommandArgument.ToString());
        bool r;
        r = obj.CSRGalleryDelete(Id);
        if (r == true)
        {
            strScript = "alert('Selected photo is deleted successfully.');location.replace('Admin_CSRGallaryPost.aspx?csrid="+csrID+"');";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertbox", strScript, true);
        }        
    }
    protected void imbBtnCancel_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("Admin_CorporateSocial.aspx");
    }
}
