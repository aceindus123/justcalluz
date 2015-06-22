﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using JustCallUsData.Data;
using System.Globalization;
public partial class admin_Admin_SSPost : System.Web.UI.Page
{
    string CompanyName;
    string cat;
    string city;
    string state;
    string dataid;
    string PhotoName;
    string PhotoContentType;
    string year;
    string month;
    string strScript;
    string compname;
    bool t;
    string UserId;
    DataSet ds = new DataSet();
    DataSet ds1 = new DataSet();
    DataSet dsGetPhotoName = new DataSet();
    Binddata obj = new Binddata();
    DataCS data = new DataCS();
    SSCS ss = new SSCS();    
    CultureInfo CInfo = new CultureInfo("hi-IN");
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
        if (!Page.IsPostBack)
        {
            data.FillStates(ddlState);            
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
    protected void imgBtnPostSS_Click(object sender, ImageClickEventArgs e)
    {
        ss.aTypeofSS="SSText";
        ss.aCompanyName = Convert.ToString(txtCompanyName.Text);
        ss.aCategory = Convert.ToString(txtCat.Text);
        ss.aCity = Convert.ToString(ddlCity.SelectedValue);
        ss.aState = Convert.ToString(ddlState.SelectedValue);
        ss.aPName = Convert.ToString(txtPName.Text);
        ss.aPDesg = Convert.ToString(txtPDesg.Text);
        ss.aSMonth = Convert.ToString(txtMonth.Text);
        ss.aSYear = Convert.ToString(txtYear.Text);
        string fy;
        string cy;
        fy = Convert.ToString(txtIFirstYear.Text);        
        ss.aFirstYear = Convert.ToString(Convert.ToDecimal(fy).ToString("N0", CInfo));
        cy = Convert.ToString(txtICurrentYear.Text);
        ss.aCurrentYear = Convert.ToString(Convert.ToDecimal(cy).ToString("N0", CInfo));
        ss.aPartnerSpeak = Convert.ToString(txtSpeak.Text);
        ss.aPostdate = System.DateTime.Now;
        ss.aPostedby = UserId;
        ss.aDataId = Convert.ToInt32(lblId.Text);
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
                    t = ss.PostSS(ss.aTypeofSS, ss.aCompanyName, ss.aCategory, ss.aCity, ss.aPName, ss.aPDesg,
                                ss.aSMonth, ss.aSYear, ss.aFirstYear, ss.aCurrentYear, ss.aPartnerSpeak,
                                ss.aPhotoName, ss.aPhotoContentType, ss.aPostdate, ss.aPostedby, ss.aDataId,ss.aState);
                    strScript = "alert('Success Story is posted successfully.');location.replace('Admin_SuccessStories.aspx');";
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "alertbox", strScript, true);
                }
            }
        }
    }    
    
    protected void hdnValue_ValueChanged(object sender, EventArgs e)
    {
        bindData();
    }
    protected void bindData()
    {
        CompanyName = Convert.ToString(txtCompanyName.Text);
        //compname = CompanyName.Replace("'", "''");
        //SqlParameter param = new SqlParameter();
        //param.ParameterName = "@CN";
        //SqlCommand cmd = new SqlCommand("select @CN='" + compname + "'", conn);
        //string cn=Convert.ToString(cmd.ExecuteScalar());
        ds1 = ss.GetCompanyName(CompanyName);        
        ds = obj.bindCompaniesData(CompanyName);
            if (!ds.Tables[0].Rows.Count.Equals(0))
            {
                if (!ds1.Tables[0].Rows.Count.Equals(0))
                {
                    lblMessage.Text="Company name already existed.";                                       
                }
                else
                {
                    cat = ds.Tables[0].Rows[0]["SubCategory"].ToString();                   
                    dataid = ds.Tables[0].Rows[0]["id"].ToString();
                    month = ds.Tables[0].Rows[0]["month"].ToString();
                    year = ds.Tables[0].Rows[0]["year"].ToString();
                    txtMonth.Text = month;
                    txtYear.Text = year;
                    txtCat.Text = cat;                    
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
    public static List<string> GetCompanyNames(string prefixText,string contextKey)
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

        SqlCommand cmd = new SqlCommand("select distinct company_name from modulesdata where (company_name like @Name+'%') and (module='Category' or module='B2B Category' or module='FreeListing') and (City=@City)  ", con); 
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
}
