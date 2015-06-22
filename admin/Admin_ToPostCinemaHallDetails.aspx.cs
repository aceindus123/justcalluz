using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;
using JustCallUsData.Data;
/// <summary>
///  class to post cinema hall details
/// </summary>
public partial class admin_Admin_ToPostCinemaHallDetails : System.Web.UI.Page
{
    //making connection
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    //declaration of variables and creation of objects for classes
    MoviesCS obj = new MoviesCS();
    DataSet dsGetLogo = new DataSet();
    DataCS data = new DataCS();
    string imgName;
    string imgContentType;
    bool hallname;
    string UserId;
    string strScripts;
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
            data.FillStates(ddlState);
        }
    }
    /// <summary>
    /// to fill cities based on states
    /// </summary>
    /// <param name="StateName"></param>
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
    /// <summary>
    /// executes when state selection is changed
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
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
    /// <summary>
    /// to fill areas based on city selection
    /// </summary>
    /// <param name="City"></param>
    public void fillAreas(string City)
    {
        try
        {
            string Connection = ConfigurationManager.AppSettings["ConnectionString"];
            SqlConnection oCon = new SqlConnection(Connection);
            string s = "select * from Movie_Areas where city= '" + City + "' order by area";
            SqlCommand cmd = new SqlCommand(s, oCon);
            oCon.Open();
            SqlDataAdapter da = new SqlDataAdapter(s, oCon);
            DataSet ds = new DataSet();
            da.Fill(ds, "Area");
            //DlCities.SelectedIndex = 0;

            ddlArea.DataSource = ds.Tables["Area"];
            ddlArea.DataValueField = "area";
            ddlArea.DataTextField = "area";
            ddlArea.DataBind();
            ddlArea.Items.Insert(0, "Select Area");
            oCon.Close();
        }
        catch (Exception ex)
        {
            lblMessage.Text = ex.Message.ToString();
        }
    }
    /// <summary>
    /// executes when city selection is changed
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void ddlCity_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlCity.SelectedIndex != 0)
        {
            string City_Name = Convert.ToString(ddlCity.SelectedValue);
            fillAreas(City_Name);
        }
        else
        {
            ddlArea.Items.Clear();
            ddlArea.Items.Insert(0, "Select Area");
        }
    }
    /// <summary>
    /// click event to post cinema hall details
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void imgbtnPost_Click(object sender, ImageClickEventArgs e)
    {
        if (Session["LoginId"] != null)
        {
            if (Imgupload.HasFile)
            {
                //Str = uploadLogo.PostedFile.FileName;
                imgName = System.IO.Path.GetFileName(Imgupload.PostedFile.FileName);
                con.Open();
                dsGetLogo = data.getLogoName(imgName);
                if (!dsGetLogo.Tables[0].Rows.Count.Equals(0))
                {
                    strScripts = "alert('Image name already existed please change Image Name');";
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScripts, true);
                }
                else
                {
                    if (Imgupload.PostedFile.ContentLength < 30000)
                    {
                        using (System.Drawing.Image Img = System.Drawing.Image.FromStream(Imgupload.PostedFile.InputStream))
                        {
                            if (Img.Width <= 100 & Img.Height <= 75)
                            {
                                Imgupload.PostedFile.SaveAs(Server.MapPath("~/Logos/" + imgName));
                                //imgName = System.IO.Path.GetFileName(Imgupload.PostedFile.FileName);
                                imgContentType = Imgupload.PostedFile.ContentType;

                                obj.mAddress = Convert.ToString(txtAddress.Text);
                                obj.mArea = Convert.ToString(ddlArea.SelectedValue);
                                obj.mCat = Convert.ToString(ddlCat.SelectedValue);
                                obj.mCity = Convert.ToString(ddlCity.SelectedValue);
                                obj.mEmail = Convert.ToString(txtEmail.Text);
                                obj.mPostDate = DateTime.Now.Date;
                                obj.mExpDate = (obj.mPostDate.AddDays(Convert.ToDouble(30)));
                                obj.mHallName = Convert.ToString(txtHallName.Text);
                                obj.mImgContentType = imgContentType;
                                obj.mImgName = imgName;
                                obj.mLandmark = Convert.ToString(txtLandMark.Text);
                                obj.mLoginId = UserId;
                                obj.mMob = Convert.ToString(txtMob.Text);
                                obj.mPhno = Convert.ToString(txtPhone.Text);
                                obj.mPincode = Convert.ToString(txtPincode.Text);
                                obj.mState = Convert.ToString(ddlState.SelectedValue);
                                obj.mWebsite = Convert.ToString(txtWebsite.Text);
                                hallname = obj.CinemaHallData_Insert(obj.mCat, obj.mHallName, obj.mAddress, obj.mLandmark, obj.mArea, obj.mCity,
                                                                   obj.mState, obj.mPincode, obj.mEmail, obj.mPhno, obj.mMob, obj.mWebsite,
                                                                   obj.mPostDate, obj.mExpDate, obj.mLoginId, obj.mImgName, obj.mImgContentType);
                                string getID = "select top 1 id from Modulesdata where UserLoginId='" + UserId + "' order by id desc";
                                SqlDataAdapter adaId = new SqlDataAdapter(getID, con);
                                DataSet dsId = new DataSet();
                                adaId.Fill(dsId);
                                if (!dsId.Tables[0].Rows.Count.Equals(0))
                                {
                                    string dId = dsId.Tables[0].Rows[0]["id"].ToString();
                                    strScripts = "alert('Your Data is posted Successfully');location.replace('Admin_ToEditCinemaHallDetails.aspx?chid=" + dId + "#trMAP');";
                                    Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScripts, true);
                                }
                            }
                            else
                            {
                                strScripts = "alert('You can not Upload the  Image because dimensions of the image Exceeds');";
                                Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScripts, true);
                            }
                        }
                    }
                    else
                    {
                        strScripts = "alert('File size exceeds maximum limit 30KB.');";
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScripts, true);
                    }
                }
                con.Close();
            }
            else
            {
                con.Open();
                obj.mAddress = Convert.ToString(txtAddress.Text);
                obj.mArea = Convert.ToString(ddlArea.SelectedValue);
                obj.mCat = Convert.ToString(ddlCat.SelectedValue);
                obj.mCity = Convert.ToString(ddlCity.SelectedValue);
                obj.mEmail = Convert.ToString(txtEmail.Text);
                obj.mPostDate = DateTime.Now.Date;
                obj.mExpDate = (obj.mPostDate.AddDays(Convert.ToDouble(30)));
                obj.mHallName = Convert.ToString(txtHallName.Text);
                obj.mImgContentType = "0";
                obj.mImgName = "0";
                obj.mLandmark = Convert.ToString(txtLandMark.Text);
                obj.mLoginId = UserId;
                obj.mMob = Convert.ToString(txtMob.Text);
                obj.mPhno = Convert.ToString(txtPhone.Text);
                obj.mPincode = Convert.ToString(txtPincode.Text);
                obj.mState = Convert.ToString(ddlState.SelectedValue);
                obj.mWebsite = Convert.ToString(txtWebsite.Text);
                hallname = obj.CinemaHallData_Insert(obj.mCat, obj.mHallName, obj.mAddress, obj.mLandmark, obj.mArea, obj.mCity,
                                                   obj.mState, obj.mPincode, obj.mEmail, obj.mPhno, obj.mMob, obj.mWebsite,
                                                   obj.mPostDate, obj.mExpDate, obj.mLoginId, obj.mImgName, obj.mImgContentType);

                string getID = "select top 1 id from Modulesdata where UserLoginId='" + UserId + "' order by id desc";
                SqlDataAdapter adaId = new SqlDataAdapter(getID, con);
                DataSet dsId = new DataSet();
                adaId.Fill(dsId);
                if (!dsId.Tables[0].Rows.Count.Equals(0))
                {
                    string dId = dsId.Tables[0].Rows[0]["id"].ToString();
                    strScripts = "alert('Your Data is posted Successfully');location.replace('Admin_ToEditCinemaHallDetails.aspx?chid=" + dId + "#trMAP');";
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScripts, true);
                }
                con.Close();
            }            
        }
        
    }    
    
}
