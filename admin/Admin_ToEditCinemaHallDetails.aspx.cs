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
/// class to update cinema hall details
/// </summary>
public partial class admin_Admin_ToEditCinemaHallDetails : System.Web.UI.Page
{
    //making connection
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    //declaration of variables and creation of objects for classes
    DataSet ds = new DataSet();
    MoviesCS obj = new MoviesCS();
    DataCS data = new DataCS();
    DataSet dsGetLogo = new DataSet();
    Int32 chid;
    bool t;
    string qry;
    string UserId;
    string strScripts;

    string Cat;
    string HallName;
    string Address;
    string Landmark;
    string Area;
    string City;
    string State;
    string Pincode;
    string Mob;
    string Phno;
    string Email;
    string Website;
    string ImgName;
    string ImgContentType;
    string Map;
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
        chid = Convert.ToInt32(Request.QueryString["chid"]);
        //loads the page without postbacking the values
        if (!Page.IsPostBack)
        {
            data.FillStates(ddlState);
            con.Open();
            ds = obj.GetHallData(chid);
            if (!ds.Tables[0].Rows.Count.Equals(0))
            {
                Cat = ds.Tables[0].Rows[0]["SubCategory"].ToString();
                HallName = ds.Tables[0].Rows[0]["company_name"].ToString();
                Address = ds.Tables[0].Rows[0]["address"].ToString();
                Landmark = ds.Tables[0].Rows[0]["land_mark"].ToString();
                Area = ds.Tables[0].Rows[0]["Area"].ToString();
                City = ds.Tables[0].Rows[0]["City"].ToString();
                State = ds.Tables[0].Rows[0]["State"].ToString();
                Pincode = ds.Tables[0].Rows[0]["Pincode"].ToString();
                Mob = ds.Tables[0].Rows[0]["mob"].ToString();
                Phno = ds.Tables[0].Rows[0]["landphno"].ToString();
                Email = ds.Tables[0].Rows[0]["emailid"].ToString();
                Website = ds.Tables[0].Rows[0]["Website"].ToString();
                Map = ds.Tables[0].Rows[0]["map"].ToString();

            }
            txtAddress.Text = Address;
            txtEmail.Text = Email;
            txtHallName.Text = HallName;
            txtLandMark.Text = Landmark;
            txtMob.Text = Mob;
            txtPhone.Text = Phno;
            txtPincode.Text = Pincode;
            txtWebsite.Text = Website;
            lblMap.Text = Map;
                        
            for (int i = 0; i < ddlCat.Items.Count; i++)
            {
                if (ddlCat.Items[i].Value == Cat.ToString())
                {
                    ddlCat.SelectedValue = ddlCat.Items[i].Value;
                    break;
                }
            }
            for (int i = 0; i < ddlState.Items.Count; i++)
            {
                if (ddlState.Items[i].Value == State.ToString())
                {
                    ddlState.SelectedValue = ddlState.Items[i].Value;
                    break;
                }
            }
            fillCities(State);
            // To bound database city value to the city Dropdown list
            for (int i = 0; i < ddlCity.Items.Count; i++)
            {
                if (ddlCity.Items[i].Value == City.ToString())
                {
                    ddlCity.SelectedValue = ddlCity.Items[i].Value;
                    break;
                }
                else
                {
                    ddlCity.SelectedIndex = 0;
                }
            }
            fillAreas(City);
            for (int i = 0; i < ddlArea.Items.Count; i++)
            {
                if (ddlArea.Items[i].Value == Area.ToString())
                {
                    ddlArea.SelectedValue = ddlArea.Items[i].Value;
                    break;
                }
                else
                {
                    ddlArea.SelectedIndex = 0;
                }
            }
            if (Map != "")
            {
                imgbtnmapUpdate.Visible = true;
                imgbtnSave.Visible = false;
            }
            else
            {
                imgbtnmapUpdate.Visible = false;
                imgbtnSave.Visible = true;
            }
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
    /// click event to update cinema hall details
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void imgbtnUpdate_Click(object sender, ImageClickEventArgs e)
    {
        if (Session["LoginId"] != null)
        {
            if (Imgupload.HasFile)
            {
                //Str = uploadLogo.PostedFile.FileName;
                ImgName = System.IO.Path.GetFileName(Imgupload.PostedFile.FileName);
                con.Open();
                dsGetLogo = data.getLogoName(ImgName);
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
                                Imgupload.PostedFile.SaveAs(Server.MapPath("~/Logos/" + ImgName));
                                //imgName = System.IO.Path.GetFileName(Imgupload.PostedFile.FileName);
                                ImgContentType = Imgupload.PostedFile.ContentType;

                                obj.mAddress = Convert.ToString(txtAddress.Text);
                                obj.mArea = Convert.ToString(ddlArea.SelectedValue);
                                obj.mCat = Convert.ToString(ddlCat.SelectedValue);
                                obj.mCity = Convert.ToString(ddlCity.SelectedValue);
                                obj.mEmail = Convert.ToString(txtEmail.Text);                              
                                obj.mHallName = Convert.ToString(txtHallName.Text);
                                obj.mImgContentType = ImgContentType;
                                obj.mImgName = ImgName;
                                obj.mLandmark = Convert.ToString(txtLandMark.Text);                                
                                obj.mMob = Convert.ToString(txtMob.Text);
                                obj.mPhno = Convert.ToString(txtPhone.Text);
                                obj.mPincode = Convert.ToString(txtPincode.Text);
                                obj.mState = Convert.ToString(ddlState.SelectedValue);
                                obj.mWebsite = Convert.ToString(txtWebsite.Text);
                                obj.mId = chid;
                                obj.mPostDate = DateTime.Now.Date;
                                obj.mLoginId = UserId;
                                //hallname = obj.CinemaHallData_Insert(obj.mCat, obj.mHallName, obj.mAddress, obj.mLandmark, obj.mArea, obj.mCity,
                                //                                   obj.mState, obj.mPincode, obj.mEmail, obj.mPhno, obj.mMob, obj.mWebsite,
                                //                                   obj.mPostDate, obj.mExpDate, obj.mLoginId, obj.mImgName, obj.mImgContentType);
                                t = obj.CinemaHallData_Update(obj.mCat, obj.mHallName, obj.mAddress, obj.mLandmark, obj.mArea, obj.mCity, obj.mState, obj.mPincode,
                                                            obj.mEmail, obj.mPhno, obj.mMob, obj.mWebsite, obj.mPostDate, obj.mLoginId, obj.mImgName, obj.mImgContentType, obj.mId);
                                string getID = "select top 1 id from Modulesdata where UserLoginId='" + UserId + "' order by id desc";
                                SqlDataAdapter adaId = new SqlDataAdapter(getID, con);
                                DataSet dsId = new DataSet();
                                adaId.Fill(dsId);
                                if (!dsId.Tables[0].Rows.Count.Equals(0))
                                {
                                    string dId = dsId.Tables[0].Rows[0]["id"].ToString();
                                    strScripts = "alert('Your Data is Updated Successfully');location.replace('Admin_ViewHallsData.aspx');";
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
                obj.mId = chid;
                t = obj.CinemaHallData_Update(obj.mCat, obj.mHallName, obj.mAddress, obj.mLandmark, obj.mArea, obj.mCity, obj.mState, obj.mPincode,
                                                            obj.mEmail, obj.mPhno, obj.mMob, obj.mWebsite, obj.mPostDate, obj.mLoginId, obj.mImgName, obj.mImgContentType, obj.mId);

                string getID = "select top 1 id from Modulesdata where UserLoginId='" + UserId + "' order by id desc";
                SqlDataAdapter adaId = new SqlDataAdapter(getID, con);
                DataSet dsId = new DataSet();
                adaId.Fill(dsId);
                if (!dsId.Tables[0].Rows.Count.Equals(0))
                {
                    string dId = dsId.Tables[0].Rows[0]["id"].ToString();
                    strScripts = "alert('Your Data is Updated Successfully');location.replace('Admin_ViewHallsData.aspx');";
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScripts, true);
                }
                con.Close();
            }
        }

    }
    /// <summary>
    /// update/insert map location
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void imgbtnSave_Click(object sender, ImageClickEventArgs e)
    {
        string mapPath = Convert.ToString(txtMapURL.Text);
        //string mapPath ="<iframe width='690px' height='253px' frameborder='0' scrolling=no marginheight=0 marginwidth=0 src=http://maps.google.co.in/maps?f=q&amp;source=s_q&amp;hl=en&amp;geocode=&amp;q=Hyderabad&amp;aq=&amp;sll=16.496196,80.638935&amp;sspn=0.020533,0.027423&amp;ie=UTF8&amp;hq=&amp;hnear=Hyderabad,+Ranga+Reddy,+Andhra+Pradesh&amp;t=m&amp;z=10&amp;ll=17.385044,78.486671&amp;output=embed></iframe>";
        int len=mapPath.Length;
        string[] mapstr = mapPath.Split(' ');
        mapstr[1] = "width=\"690px\"";
        mapstr[2] = "height=\"253px\"";
        for (int i = 0; i < len; i++)
        {
            lblSmallExceptLarge.Text += mapstr[i] + " ";
            if (mapstr[i] == "/><small><a")
            {
                len = i;
                break;
            }
        }

        txtMapURL.Text = lblSmallExceptLarge.Text;
        qry = "update ModulesData set map='" + txtMapURL.Text + "',Approved_map=1 where id=" + chid;
        SqlCommand cmd = new SqlCommand(qry, con);
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();
        strScripts = "alert('Your MapURL is submitted Successfully');location.replace('Admin_Movies.aspx');";
        Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScripts, true);      
    }
    protected void imbBtnCancel_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("Admin_ViewHallsData.aspx");
    }
}
