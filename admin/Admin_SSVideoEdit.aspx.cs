using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using JustCallUsData.Data;
public partial class admin_Admin_SSVideoEdit : System.Web.UI.Page
{
    string CompanyName;
    string cat;
    string city;
    string state;
    string dataid;
    string PhotoName;
    string PhotoContentType;
    string VideoName;
    string VideoContentType;
    string year;
    string month;
    string strScript;
    string PName;
    string PDesg;
    bool t;
    string UserId;
    DataSet ds = new DataSet();
    DataSet ds1 = new DataSet();
    DataSet dsGetPhotoName = new DataSet();
    DataSet dsGetVideoName = new DataSet();
    Binddata obj = new Binddata();
    DataCS data = new DataCS();
    SSCS ss = new SSCS();
    string ssid;
    DataSet dsGetSSData = new DataSet();
    public string swfFileName;
    SqlConnection conn = new SqlConnection(ConfigurationManager.AppSettings["connectionstring"]);
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
        ssid = Convert.ToString(Request.QueryString["ssid"]);
        if (!Page.IsPostBack)
        {
            data.FillStates(ddlState);
            dsGetSSData = ss.GetSS_byId(ssid);
            if (!dsGetSSData.Tables[0].Rows.Count.Equals(0))
            {
                state = dsGetSSData.Tables[0].Rows[0]["State"].ToString();
                city = dsGetSSData.Tables[0].Rows[0]["City"].ToString();
                CompanyName = dsGetSSData.Tables[0].Rows[0]["CompanyName"].ToString();
                cat = dsGetSSData.Tables[0].Rows[0]["Category"].ToString();
                year = dsGetSSData.Tables[0].Rows[0]["SYear"].ToString();
                month = dsGetSSData.Tables[0].Rows[0]["SMonth"].ToString();
                PName = dsGetSSData.Tables[0].Rows[0]["PName"].ToString();
                PDesg = dsGetSSData.Tables[0].Rows[0]["PDesg"].ToString();
                PhotoName = dsGetSSData.Tables[0].Rows[0]["PhotoName"].ToString();
                PhotoContentType = dsGetSSData.Tables[0].Rows[0]["PhotoContentType"].ToString();
                VideoName = dsGetSSData.Tables[0].Rows[0]["VideoName"].ToString();
                VideoContentType = dsGetSSData.Tables[0].Rows[0]["VideoContentType"].ToString();
                dataid = dsGetSSData.Tables[0].Rows[0]["dataid"].ToString();
            }
            for (int i = 0; i < ddlState.Items.Count; i++)
            {
                if (ddlState.Items[i].Value == state.ToString())
                {
                    ddlState.SelectedValue = ddlState.Items[i].Value;
                    break;
                }
            }
            fillCities(state);
            for (int i = 0; i < ddlCity.Items.Count; i++)
            {
                if (ddlCity.Items[i].Value == city.ToString())
                {
                    ddlCity.SelectedValue = ddlCity.Items[i].Value;
                    break;
                }
            }
            txtCompanyName.Text = CompanyName;
            txtCat.Text = cat;
            txtYear.Text = year;
            txtMonth.Text = month;
            txtPName.Text = PName;
            txtPDesg.Text = PDesg;
            Photo.ImageUrl = "../SS_Photos/" + PhotoName;
            imgName.Text = PhotoName;
            imgContentType.Text = PhotoContentType;
            swfFileName = "../SS_Videos/" + VideoName;
            video_Name.Text = VideoName;
            vContentType.Text = VideoContentType;
            lblId.Text = dataid;
            if (PhotoContentType == "image/pjpeg" || PhotoContentType == "image/gif" || PhotoContentType == "image/jpeg")
            {
                lblImageUploadStatus.Text = "true";
            }
            if (VideoContentType == "video/x-ms-wmv")
            {
                lblVedioAudioUploadStatus.Text = "true";
            }
        }
    }
    public void fillCities(string StateName)
    {
        try
        {
            string Connection = ConfigurationManager.AppSettings["ConnectionString"];
            SqlConnection oCon = new SqlConnection(Connection);
            string s = "select city_Id,city_name from Cities where state_name= '" + StateName + "' order by city_name";
            SqlCommand cmd = new SqlCommand(s, oCon);
            oCon.Open();
            SqlDataAdapter da = new SqlDataAdapter(s, oCon);
            DataSet ds = new DataSet();
            da.Fill(ds, "Cities");
            //DlCities.SelectedIndex = 0;

            ddlCity.DataSource = ds.Tables["Cities"];
            ddlCity.DataValueField = "city_name";
            ddlCity.DataTextField = "city_name";
            ddlCity.DataBind();
            ddlCity.Items.Insert(0, "Select City");
            oCon.Close();
        }
        catch (Exception ex)
        {
            lblMessage.Text = ex.Message.ToString();
        }
    }
    protected void hdnValue_ValueChanged(object sender, EventArgs e)
    {
        bindData();
    }
    protected void bindData()
    {
        CompanyName = Convert.ToString(txtCompanyName.Text);
        ds1 = ss.GetCompanyName(CompanyName);

        ds = obj.bindCompaniesData(CompanyName);
        if (!ds.Tables[0].Rows.Count.Equals(0))
        {
            if (!ds1.Tables[0].Rows.Count.Equals(0))
            {
                lblMessage.Text = "Company name already existed.";
            }
            else
            {
                cat = ds.Tables[0].Rows[0]["SubCategory"].ToString();
                //city = ds.Tables[0].Rows[0]["City"].ToString();
                //state = ds.Tables[0].Rows[0]["State"].ToString();
                dataid = ds.Tables[0].Rows[0]["id"].ToString();
                month = ds.Tables[0].Rows[0]["month"].ToString();
                year = ds.Tables[0].Rows[0]["year"].ToString();
                txtMonth.Text = month;
                txtYear.Text = year;
                txtCat.Text = cat;
                //txtCity.Text = city;
                //txtState.Text = state;
                lblId.Text = dataid;
                lblMessage.Text = "";
            }
        }
        else
        {
            lblMessage.Text = "Please select correct company name";
            txtCompanyName.Text = "";
        }
    }
    protected void txtCompanyName_TextChanged(object sender, EventArgs e)
    {
        bindData();
    }
    /// <summary>
    /// Validation for extension of image uploading
    /// </summary>
    /// <param name="source"></param>
    /// <param name="args"></param>
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
    /// <summary>
    /// Validation for extension of file uploading
    /// </summary>
    /// <param name="source"></param>
    /// <param name="args"></param>
    protected void CVVideoUpload_ServerValidate(object source, ServerValidateEventArgs args)
    {
        string fileext = System.IO.Path.GetExtension(VideoUpload.PostedFile.FileName);
        if (fileext == ".wmv")
        {
            lblVedioAudioUploadStatus.Text = "true";
            args.IsValid = true;
        }
        else
        {
            lblVedioAudioUploadStatus.Text = "false";
            CVVideoUpload.ErrorMessage = "Please upload .wmv file only";
            args.IsValid = false;
        }
    }
    protected void ddlState_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlState.SelectedIndex != 0)
        {
            string State_Name = Convert.ToString(ddlState.SelectedValue);
            fillCities(State_Name);
        }
        else
        {
            ddlCity.Items.Clear();
            ddlCity.Items.Insert(0, "Select City");
        }
    }
    [System.Web.Script.Services.ScriptMethod()]
    [System.Web.Services.WebMethod]
    public static List<string> GetCompanyNames(string prefixText, string contextKey)
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["connectionstring"]);
        con.Open();
        if (prefixText == "")
        {
            prefixText = "a";
        }
        else
        {

        }

        SqlCommand cmd = new SqlCommand("select distinct company_name from modulesdata where (company_name like @Name+'%') and (module='Category' or module='B2B Category' or module='FreeListing') and (City=@City)", con);
        cmd.Parameters.AddWithValue("@Name", prefixText);
        cmd.Parameters.AddWithValue("@City", contextKey);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        da.Fill(dt);
        List<string> companynames = new List<string>();
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            companynames.Add(dt.Rows[i][0].ToString());
        }
        return companynames;
    }
    protected void imgBtnUpdateSSVideo_Click(object sender, ImageClickEventArgs e)
    {
        string city = Convert.ToString(ddlCity.SelectedValue);
        string state = Convert.ToString(ddlState.SelectedValue);
        ss.aTypeofSS = "SSVideo";
        ss.aCompanyName = Convert.ToString(txtCompanyName.Text);
        ss.aCategory = Convert.ToString(txtCat.Text);
        ss.aCity = Convert.ToString(ddlCity.SelectedValue);
        ss.aState = Convert.ToString(ddlState.SelectedValue);
        ss.aPName = Convert.ToString(txtPName.Text);
        ss.aPDesg = Convert.ToString(txtPDesg.Text);
        ss.aSMonth = Convert.ToString(txtMonth.Text);
        ss.aSYear = Convert.ToString(txtYear.Text);
        ss.aPostdate = System.DateTime.Now;
        ss.aPostedby = UserId;
        ss.aDataId = Convert.ToInt32(lblId.Text);
        ss.aSSId = Convert.ToInt32(ssid);        
        if (ImgUpload.HasFile)
        {
            if (lblImageUploadStatus.Text == "true")
            {
                PhotoName = System.IO.Path.GetFileName(ImgUpload.PostedFile.FileName);
                dsGetPhotoName = ss.GetImgName(PhotoName); ;
                if (!dsGetPhotoName.Tables[0].Rows.Count.Equals(0))
                {
                    strScript = "alert('Image name already existed please change name');";
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "alertbox", strScript, true);
                }
                else
                {
                    ImgUpload.PostedFile.SaveAs(Server.MapPath("~/SS_Photos/" + PhotoName));
                    PhotoContentType = ImgUpload.PostedFile.ContentType;
                    ss.aPhotoName = PhotoName;
                    ss.aPhotoContentType = PhotoContentType;
                }
            }            
        }
        else
        {
            ss.aPhotoContentType = Convert.ToString(imgName.Text);
            ss.aPhotoName = Convert.ToString(imgContentType.Text);
        }

        if (VideoUpload.HasFile)
        {
            if (lblVedioAudioUploadStatus.Text == "true")
            {
                VideoName = System.IO.Path.GetFileName(VideoUpload.PostedFile.FileName);
                dsGetVideoName = ss.GetVideoName(VideoName); ;
                if (!dsGetVideoName.Tables[0].Rows.Count.Equals(0))
                {
                    strScript = "alert('Video name already existed please change name');";
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "alertbox", strScript, true);
                }
                else
                {
                    VideoUpload.PostedFile.SaveAs(Server.MapPath("~/SS_Videos/" + VideoName));
                    VideoContentType = VideoUpload.PostedFile.ContentType;
                    ss.aVideoName = VideoName;
                    ss.aVideoContentType = VideoContentType;
                }
            }
        }
        else
        {
            ss.aVideoName = Convert.ToString(video_Name.Text);
            ss.aVideoContentType = Convert.ToString(vContentType.Text);
        }
        if (ss.aVideoName != null && ss.aPhotoName != null)
        {
            t = ss.UpdateSSVideos(ss.aTypeofSS, ss.aCompanyName, ss.aCategory, ss.aCity, ss.aPName, ss.aPDesg,
                                ss.aSMonth, ss.aSYear, ss.aPhotoName, ss.aPhotoContentType, ss.aVideoName, ss.aVideoContentType,
                                ss.aPostdate, ss.aPostedby, ss.aDataId, ss.aState,ss.aSSId);
            strScript = "alert('Success Story Video is updated successfully.');location.replace('Admin_SuccessStories.aspx?Type=SSVideo&s=" + state + "&c=" + city + "');";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertbox", strScript, true);
        }
    }
    protected void imbBtnCancel_Click(object sender, ImageClickEventArgs e)
    {
        string city = Convert.ToString(ddlCity.SelectedValue);
        string state = Convert.ToString(ddlState.SelectedValue);
        Response.Redirect("Admin_SuccessStories.aspx?Type=SSVideo&s=" + state + "&c=" + city);
    }
}
