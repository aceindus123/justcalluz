using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
using System.Web.SessionState;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Mail;

/// <summary>
/// class to post banner ads
/// </summary>
public partial class admin_Admin_ToPostBannerAds : System.Web.UI.Page
{
     
    //declaration of variables and making connection
    string Str;
    bool t;
    string UserId;
    SqlConnection Connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    SqlDataReader dr;
    /// <summary>
    /// The actions perform when page is loaded
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
        //Panel1.Visible = false;
        if (!IsPostBack)
        {
            //AdPostLogic olg = new AdPostLogic();
            //olg.FillCountries(ddlCountries);
            //olg.FillImgCategory(ddlcategory);

        }
    }

    /// <summary>
    /// Binding the cities for the correponding Countries
    /// </summary>
    /// <param name="CountryId"></param>
    public void citiesbind(string CountryId)
    {
        string Connection = ConfigurationManager.AppSettings["ConnectionString"];
        SqlConnection oCon = new SqlConnection(Connection);
        string s = "select iCityId,vCityName from ia_ECities1 where iCountryId= '" + CountryId + "'";
        oCon.Open();
        SqlCommand cmd = new SqlCommand(s, oCon);
        SqlDataAdapter da = new SqlDataAdapter(s, oCon);
        DataSet ds = new DataSet();
        da.Fill(ds, "Cities");
        ddlcities.Items.Clear();
        ddlcities.DataSource = ds.Tables["cities"];
        ddlcities.DataTextField = "vCityName";
        ddlcities.DataValueField = "vCityName";
        ddlcities.DataBind();
        ddlcities.Items.Insert(0, "Select");
        oCon.Close();

    }
    /// <summary>
    /// Perform when the countries selection is changed
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void ddlCountries_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlCountries.SelectedIndex != 0)
        {
            string CountryId = Convert.ToString(ddlCountries.SelectedValue);
            citiesbind(CountryId);
        }
        else
        {
            ddlcities.Items.Clear();
            ddlcities.Items.Insert(0, "Select");
        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {

        StartUpLoad();

    }


    private bool IsImage(HttpPostedFile file)
    {
        // This checks for image type... you could also do filename extension checks and other things 
        // but this is just an example to get you on your way 
        return ((file != null) && System.Text.RegularExpressions.Regex.IsMatch(file.ContentType, "image/\\S+") && (file.ContentLength > 0));
    }

    private void StartUpLoad()
    {

        if (FileUpload1.HasFile)
        {
            //if (FileUpload1.PostedFile.ContentLength < 300000)
            //{
            try
            {
                //get the file name of the posted image

                Str = FileUpload1.PostedFile.FileName;
                string imgName = System.IO.Path.GetFileName(FileUpload1.PostedFile.FileName);
                Connection.Open();
                string s = "select imagename from categoryAds where imagename='" + imgName + "'";
                SqlCommand cmd = new SqlCommand(s, Connection);
                dr = cmd.ExecuteReader();
                string ImageName = string.Empty;

                while (dr.Read())
                {
                    ImageName = Convert.ToString(dr["imagename"]);
                }
                Connection.Close();
                if (imgName == ImageName)
                {
                    lblmsg.Text = " Image name already existed please change Image Name";
                }
                else
                {
                    //sets the image path
                    FileUpload1.PostedFile.SaveAs(Server.MapPath("~/Ads/" + imgName));



                    //sets the image path

                    string imgPath = "~/Ads/" + imgName;


                    //then save it to the Folder

                    FileUpload1.SaveAs(Server.MapPath(imgPath));


                    //validates the posted file before saving

                    if (FileUpload1.PostedFile != null && FileUpload1.PostedFile.FileName != "")
                    {

                        using (System.Drawing.Image Img = System.Drawing.Image.FromFile(Server.MapPath("~/Ads/" + imgName)))
                        {
                            if (ddllocation.SelectedValue == "RightMenu")
                            {
                                if (ddlcategory.SelectedValue == "Home")
                                {
                                    if (FileUpload1.PostedFile.ContentLength < 50000)
                                    {
                                        if (Img.Width == 180 & Img.Height == 150)
                                        {
                                            Stream imgStream = FileUpload1.PostedFile.InputStream;
                                            int imgLen = FileUpload1.PostedFile.ContentLength;
                                            string imgContentType = FileUpload1.PostedFile.ContentType;
                                            byte[] imgBinaryData = new byte[imgLen];
                                            int n = imgStream.Read(imgBinaryData, 0, imgLen);
                                            ExecuteInsert(imgName, imgPath);
                                            lblmsg.Text = "";
                                            string strScript = "";
                                            strScript = "alert('Ad has been posted Successfully.');";
                                            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                                            txtimagesize.Text = "";
                                            txtUrl.Text = "";
                                            //txtDesc.Text = "";
                                            txtAdTitle.Text = "";
                                            ddlcities.SelectedIndex = 0;
                                            ddlcategory.SelectedIndex = 0;
                                            ddllocation.SelectedIndex = 0;
                                            ddlCountries.SelectedIndex = 0;
                                            txtAdvertiserAdress.Text = "";
                                            txtAdvertiserName.Text = "";
                                            txtEmailId.Text = "";
                                            txtPhoneNumber.Text = "";
                                        }
                                        else
                                        {

                                            lblmsg.Text = "U can't Upload the  Image because dimensions of the image 180 X 150 Exceeds or Depriciate";

                                        }
                                    }
                                    else
                                    {
                                        lblmsg.Text = "File size exceeds maximum limit 50KB.";
                                    }


                                }
                                else
                                {
                                    if (FileUpload1.PostedFile.ContentLength < 15000)
                                    {
                                        if (Img.Width == 200 & Img.Height == 80)
                                        {
                                            Stream imgStream = FileUpload1.PostedFile.InputStream;
                                            int imgLen = FileUpload1.PostedFile.ContentLength;
                                            string imgContentType = FileUpload1.PostedFile.ContentType;
                                            byte[] imgBinaryData = new byte[imgLen];
                                            int n = imgStream.Read(imgBinaryData, 0, imgLen);
                                            ExecuteInsert(imgName, imgPath);
                                            lblmsg.Text = "";
                                            string strScript = "";
                                            strScript = "alert('Ad has been posted Successfully.');";
                                            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                                            txtimagesize.Text = "";
                                            txtUrl.Text = "";
                                            //txtDesc.Text = "";
                                            txtAdTitle.Text = "";
                                            ddlcities.SelectedIndex = 0;
                                            ddlcategory.SelectedIndex = 0;
                                            ddllocation.SelectedIndex = 0;
                                            ddlCountries.SelectedIndex = 0;
                                            txtAdvertiserAdress.Text = "";
                                            txtAdvertiserName.Text = "";
                                            txtEmailId.Text = "";
                                            txtPhoneNumber.Text = "";
                                        }
                                        else
                                        {

                                            lblmsg.Text = "U can't Upload the  Image because dimensions(200 X 80) of the image Exceeds or Depriciate";

                                        }
                                    }
                                    else
                                    {
                                        lblmsg.Text = "File size exceeds maximum limit 15KB.";
                                    }
                                }
                            }
                            else if (ddllocation.SelectedValue == "LeftMenu")
                            {
                                if (ddlcategory.SelectedValue == "Classifieds")
                                {
                                    if (FileUpload1.PostedFile.ContentLength < 10000)
                                    {
                                        if (Img.Width == 140 & Img.Height == 35)
                                        {
                                            Stream imgStream = FileUpload1.PostedFile.InputStream;
                                            int imgLen = FileUpload1.PostedFile.ContentLength;
                                            string imgContentType = FileUpload1.PostedFile.ContentType;
                                            byte[] imgBinaryData = new byte[imgLen];
                                            int n = imgStream.Read(imgBinaryData, 0, imgLen);
                                            ExecuteInsert(imgName, imgPath);
                                            lblmsg.Text = "";
                                            string strScript = "";
                                            strScript = "alert('Ad has been posted Successfully.');";
                                            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                                            txtimagesize.Text = "";
                                            txtUrl.Text = "";
                                            //txtDesc.Text = "";
                                            txtAdTitle.Text = "";
                                            ddlcities.SelectedIndex = 0;
                                            ddlcategory.SelectedIndex = 0;
                                            ddllocation.SelectedIndex = 0;
                                            ddlCountries.SelectedIndex = 0;
                                            txtAdvertiserAdress.Text = "";
                                            txtAdvertiserName.Text = "";
                                            txtEmailId.Text = "";
                                            txtPhoneNumber.Text = "";
                                        }
                                        else
                                        {

                                            lblmsg.Text = "U can't Upload the  Image because dimensions(140 X 35) of the image Exceeds or Depriciate";

                                        }
                                    }
                                    else
                                    {
                                        lblmsg.Text = "File size exceeds maximum limit 10KB.";
                                    }
                                }
                                else if (ddlcategory.SelectedValue == "Home")
                                {
                                    if (FileUpload1.PostedFile.ContentLength < 100000)
                                    {
                                        if (Img.Width == 145 & Img.Height == 370)
                                        {
                                            Stream imgStream = FileUpload1.PostedFile.InputStream;
                                            int imgLen = FileUpload1.PostedFile.ContentLength;
                                            string imgContentType = FileUpload1.PostedFile.ContentType;
                                            byte[] imgBinaryData = new byte[imgLen];
                                            int n = imgStream.Read(imgBinaryData, 0, imgLen);
                                            ExecuteInsert(imgName, imgPath);
                                            lblmsg.Text = "";
                                            string strScript = "";
                                            strScript = "alert('Ad has been posted Successfully.');";
                                            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                                            txtimagesize.Text = "";
                                            txtUrl.Text = "";
                                            //txtDesc.Text = "";
                                            txtAdTitle.Text = "";
                                            ddlcities.SelectedIndex = 0;
                                            ddlcategory.SelectedIndex = 0;
                                            ddllocation.SelectedIndex = 0;
                                            ddlCountries.SelectedIndex = 0;
                                            txtAdvertiserAdress.Text = "";
                                            txtAdvertiserName.Text = "";
                                            txtEmailId.Text = "";
                                            txtPhoneNumber.Text = "";
                                        }
                                        else
                                        {

                                            lblmsg.Text = "U can't Upload the  Image because dimensions(145 X 370) of the image Exceeds or Depriciate";

                                        }
                                    }
                                    else
                                    {
                                        lblmsg.Text = "File size exceeds maximum limit 100KB.";
                                    }
                                }
                            }
                            else if (ddllocation.SelectedValue == "BottomMenu")
                            {
                                if (FileUpload1.PostedFile.ContentLength < 50000)
                                {
                                    if (Img.Width == 600 & Img.Height == 50)
                                    {
                                        Stream imgStream = FileUpload1.PostedFile.InputStream;
                                        int imgLen = FileUpload1.PostedFile.ContentLength;
                                        string imgContentType = FileUpload1.PostedFile.ContentType;
                                        byte[] imgBinaryData = new byte[imgLen];
                                        int n = imgStream.Read(imgBinaryData, 0, imgLen);
                                        ExecuteInsert(imgName, imgPath);
                                        lblmsg.Text = "";
                                        string strScript = "";
                                        strScript = "alert('Ad has been posted Successfully.');";
                                        Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                                        txtimagesize.Text = "";
                                        txtUrl.Text = "";
                                        //txtDesc.Text = "";
                                        txtAdTitle.Text = "";
                                        ddlcities.SelectedIndex = 0;
                                        ddlcategory.SelectedIndex = 0;
                                        ddllocation.SelectedIndex = 0;
                                        ddlCountries.SelectedIndex = 0;
                                        txtAdvertiserAdress.Text = "";
                                        txtAdvertiserName.Text = "";
                                        txtEmailId.Text = "";
                                        txtPhoneNumber.Text = "";
                                    }
                                    else
                                    {
                                        lblmsg.Text = "U can't Upload the  Image because dimensions(600 X 50) of the image Exceeds or Depriciate";
                                    }
                                }
                                else
                                {
                                    lblmsg.Text = "File size exceeds maximum limit 50KB.";
                                }


                            }
                            else if (ddllocation.SelectedValue == "Right Topmost Img")
                            {
                                if (FileUpload1.PostedFile.ContentLength < 50000)
                                {
                                    if (Img.Width == 450 & Img.Height == 60)
                                    {
                                        Stream imgStream = FileUpload1.PostedFile.InputStream;
                                        int imgLen = FileUpload1.PostedFile.ContentLength;
                                        string imgContentType = FileUpload1.PostedFile.ContentType;
                                        byte[] imgBinaryData = new byte[imgLen];
                                        int n = imgStream.Read(imgBinaryData, 0, imgLen);
                                        ExecuteInsert(imgName, imgPath);
                                        lblmsg.Text = "";
                                        string strScript = "";
                                        strScript = "alert('Ad has been posted Successfully.');";
                                        Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                                        txtimagesize.Text = "";
                                        txtUrl.Text = "";
                                        //txtDesc.Text = "";
                                        txtAdTitle.Text = "";
                                        ddlcities.SelectedIndex = 0;
                                        ddlcategory.SelectedIndex = 0;
                                        ddllocation.SelectedIndex = 0;
                                        ddlCountries.SelectedIndex = 0;
                                        txtAdvertiserAdress.Text = "";
                                        txtAdvertiserName.Text = "";
                                        txtEmailId.Text = "";
                                        txtPhoneNumber.Text = "";
                                    }
                                    else
                                    {

                                        lblmsg.Text = "U can't Upload the  Image because dimensions(450 X 60) of the image Exceeds or Depriciate";

                                    }
                                }
                                else
                                {
                                    lblmsg.Text = "File size exceeds maximum limit 50KB.";
                                }

                            }
                            else if (ddllocation.SelectedValue == "Inside Advertising")
                            {
                                if (FileUpload1.PostedFile.ContentLength < 50000)
                                {
                                    if (Img.Width == 300 & Img.Height == 130)
                                    {
                                        Stream imgStream = FileUpload1.PostedFile.InputStream;
                                        int imgLen = FileUpload1.PostedFile.ContentLength;
                                        string imgContentType = FileUpload1.PostedFile.ContentType;
                                        byte[] imgBinaryData = new byte[imgLen];
                                        int n = imgStream.Read(imgBinaryData, 0, imgLen);
                                        ExecuteInsert(imgName, imgPath);
                                        lblmsg.Text = "";
                                        string strScript = "";
                                        strScript = "alert('Ad has been posted Successfully.');";
                                        Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                                        txtimagesize.Text = "";
                                        txtUrl.Text = "";
                                        //txtDesc.Text = "";
                                        txtAdTitle.Text = "";
                                        ddlcities.SelectedIndex = 0;
                                        ddlcategory.SelectedIndex = 0;
                                        ddllocation.SelectedIndex = 0;
                                        ddlCountries.SelectedIndex = 0;
                                        txtAdvertiserAdress.Text = "";
                                        txtAdvertiserName.Text = "";
                                        txtEmailId.Text = "";
                                        txtPhoneNumber.Text = "";
                                    }
                                    else
                                    {

                                        lblmsg.Text = "U can't Upload the  Image because dimensions(300 X 130) of the image Exceeds or Depriciate";

                                    }
                                }
                                else
                                {
                                    lblmsg.Text = "File size exceeds maximum limit 50KB.";
                                }

                            }
                            else if (ddllocation.SelectedValue == "Below Main Menu")
                            {
                                if (FileUpload1.PostedFile.ContentLength < 30000)
                                {
                                    if (Img.Width == 330 & Img.Height == 70)
                                    {
                                        Stream imgStream = FileUpload1.PostedFile.InputStream;
                                        int imgLen = FileUpload1.PostedFile.ContentLength;
                                        string imgContentType = FileUpload1.PostedFile.ContentType;
                                        byte[] imgBinaryData = new byte[imgLen];
                                        int n = imgStream.Read(imgBinaryData, 0, imgLen);
                                        ExecuteInsert(imgName, imgPath);
                                        lblmsg.Text = "";
                                        string strScript = "";
                                        strScript = "alert('Ad has been posted Successfully.');";
                                        Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                                        txtimagesize.Text = "";
                                        txtUrl.Text = "";
                                        //txtDesc.Text = "";
                                        txtAdTitle.Text = "";
                                        ddlcities.SelectedIndex = 0;
                                        ddlcategory.SelectedIndex = 0;
                                        ddllocation.SelectedIndex = 0;
                                        ddlCountries.SelectedIndex = 0;
                                        txtAdvertiserAdress.Text = "";
                                        txtAdvertiserName.Text = "";
                                        txtEmailId.Text = "";
                                        txtPhoneNumber.Text = "";
                                    }
                                    else
                                    {

                                        lblmsg.Text = "U can't Upload the  Image because dimensions(330 X 70) of the image Exceeds or Depriciate";

                                    }
                                }
                                else
                                {
                                    lblmsg.Text = "File size exceeds maximum limit 30KB.";
                                }

                            }
                            else
                            {
                                if (FileUpload1.PostedFile.ContentLength < 20000)
                                {
                                    if (Img.Width == 320 & Img.Height == 50)
                                    {
                                        Stream imgStream = FileUpload1.PostedFile.InputStream;
                                        int imgLen = FileUpload1.PostedFile.ContentLength;
                                        string imgContentType = FileUpload1.PostedFile.ContentType;
                                        byte[] imgBinaryData = new byte[imgLen];
                                        int n = imgStream.Read(imgBinaryData, 0, imgLen);
                                        ExecuteInsert(imgName, imgPath);
                                        lblmsg.Text = "";
                                        string strScript = "";
                                        strScript = "alert('Ad has been posted Successfully.');";
                                        Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                                        txtimagesize.Text = "";
                                        txtUrl.Text = "";
                                        //txtDesc.Text = "";
                                        txtAdTitle.Text = "";
                                        ddlcities.SelectedIndex = 0;
                                        ddlcategory.SelectedIndex = 0;
                                        ddllocation.SelectedIndex = 0;
                                        ddlCountries.SelectedIndex = 0;
                                        txtAdvertiserAdress.Text = "";
                                        txtAdvertiserName.Text = "";
                                        txtEmailId.Text = "";
                                        txtPhoneNumber.Text = "";
                                    }
                                    else
                                    {

                                        lblmsg.Text = "U can't Upload the  Image because dimensions(320 X 50) of the image Exceeds or Depriciate";

                                    }
                                }
                                else
                                {
                                    lblmsg.Text = "File size exceeds maximum limit 20KB.";
                                }

                            }

                        }

                    }

                }
            }
            catch (Exception ex)
            {

                lblmsg.Text = "ERROR: " + ex.Message.ToString();
            }
            finally
            {
                Connection.Close();
            }
        }
    }


    private void ExecuteInsert(string name, string path)
    {
        string status = "1";
        SqlConnection conn = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);

        DateTime theDate = DateTime.Now;
        DateTime exp_date = theDate.AddDays(Convert.ToDouble(30));
        string format = "d MMM yyyy";
        string AdPostDate = theDate.ToString(format);
        string AdExpDate = exp_date.ToString(format);

        string Adv_Name = string.Empty;
        string Adv_LastName = string.Empty;
        string Adv_Address = string.Empty;
        string Adv_PhNo = string.Empty;
        string Adv_EmailId = string.Empty;
        string Ad_Title = string.Empty;
        string Ad_Desc = string.Empty;
        string Ad_URL = string.Empty;
        string Ad_Category = string.Empty;
        string City = string.Empty;
        string Country = string.Empty;

        Adv_Address = Convert.ToString(txtAdvertiserAdress.Text);
        Adv_EmailId = Convert.ToString(txtEmailId.Text);
        Adv_Name = Convert.ToString(txtAdvertiserName.Text);
        Adv_LastName = Convert.ToString(txtAdvertiserLName.Text);
        Adv_PhNo = Convert.ToString(txtPhoneNumber.Text);
        Ad_Category = Convert.ToString(ddlcategory.SelectedValue);
        //Ad_Desc = Convert.ToString(txtDesc.Text);
        Ad_Title = Convert.ToString(txtAdTitle.Text);
        Ad_URL = Convert.ToString(txtUrl.Text);
        City = Convert.ToString(ddlcities.SelectedValue);
        Country = Convert.ToString(ddlCountries.SelectedValue);


        SqlCommand cmd = new SqlCommand("CategoryAdsPro", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@imgname", SqlDbType.NVarChar, 50).Value = name;
        cmd.Parameters.Add("@ImgPath", SqlDbType.NVarChar, 100).Value = path;
        cmd.Parameters.Add("@category", SqlDbType.NVarChar, 50).Value = ddlcategory.SelectedValue;
        cmd.Parameters.Add("@country", SqlDbType.NVarChar, 50).Value = ddlCountries.SelectedValue;
        cmd.Parameters.Add("@city", SqlDbType.NVarChar, 50).Value = ddlcities.SelectedValue;
        cmd.Parameters.Add("@position", SqlDbType.NVarChar, 50).Value = ddllocation.SelectedValue;
        cmd.Parameters.Add("@adtitle", SqlDbType.NVarChar, 50).Value = txtAdTitle.Text;
        //cmd.Parameters.Add("@desc", SqlDbType.NVarChar, 50).Value = txtDesc.Text;
        cmd.Parameters.Add("@url", SqlDbType.NVarChar, 50).Value = txtUrl.Text;
        cmd.Parameters.Add("@imgDimensions", SqlDbType.NVarChar, 50).Value = txtimagesize.Text;
        cmd.Parameters.Add("@Advertiser_EmailId", SqlDbType.NVarChar, 50).Value = txtEmailId.Text;
        cmd.Parameters.Add("@DateofAdvertising", SqlDbType.NVarChar, 50).Value = AdPostDate;
        cmd.Parameters.Add("@DateofAdExpire", SqlDbType.NVarChar, 50).Value = AdExpDate;
        cmd.Parameters.Add("@Advertiser_Name", SqlDbType.NVarChar, 50).Value = txtAdvertiserName.Text;
        cmd.Parameters.Add("@Advertiser_Address", SqlDbType.NVarChar, 50).Value = txtAdvertiserAdress.Text;
        cmd.Parameters.Add("@PhNo", SqlDbType.NVarChar, 50).Value = txtPhoneNumber.Text;
        cmd.Parameters.Add("@Status", SqlDbType.NVarChar, 50).Value = status;
        cmd.Parameters.Add("@Advertiser_LName", SqlDbType.NVarChar, 50).Value = txtAdvertiserLName.Text;
        cmd.Parameters.Add("@id", SqlDbType.Int);
        cmd.Parameters["@id"].Direction = ParameterDirection.Output;
        cmd.Parameters.Add("@msg", SqlDbType.NVarChar, 50);
        cmd.Parameters["@msg"].Direction = ParameterDirection.Output;
        cmd.Connection = conn;
        string msg = null;
        int results = 0;
        try
        {

            conn.Open();
            cmd.ExecuteNonQuery();
            SendMail(Adv_Name, Adv_LastName, Adv_Address, Adv_EmailId, Adv_PhNo, Ad_Category, Ad_Title, Ad_Desc, Ad_URL, City, Country);
            results = (int)cmd.Parameters["@id"].Value;
            SqlCommand cmdademail = new SqlCommand("CategoryAdsEmailIdsPro", conn);
            cmdademail.CommandType = CommandType.StoredProcedure;
            cmdademail.Parameters.Add("@id", SqlDbType.Int).Value = results;
            cmdademail.Parameters.Add("@Advertiser_EmailId", SqlDbType.NVarChar).Value = txtEmailId.Text;
            cmdademail.Parameters.Add("@DateofAdvertising", SqlDbType.NVarChar).Value = AdPostDate;
            cmdademail.Parameters.Add("@DateofAdExpire", SqlDbType.NVarChar).Value = AdExpDate;
            cmdademail.ExecuteNonQuery();

        }

        catch (System.Data.SqlClient.SqlException ex)
        {

            string mesg = "Insert Error:";

            mesg += ex.Message;

            throw new Exception(mesg);

        }

        finally
        {

            conn.Close();

        }

    }

    protected void ddlcategory_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlcategory.SelectedIndex != 0)
        {
            string Category = Convert.ToString(ddlcategory.SelectedValue);
            PositionBind(Category);
        }
        else
        {
            ddllocation.Items.Clear();
            ddllocation.Items.Insert(0, "Select");
        }
    }
    public void PositionBind(string Category)
    {
        string Connection = ConfigurationManager.AppSettings["ConnectionString"];
        SqlConnection oCon = new SqlConnection(Connection);
        string s = "select PId,Position,Category from Image_Position where Category= '" + Category + "'";
        oCon.Open();
        SqlCommand cmd = new SqlCommand(s, oCon);
        SqlDataAdapter da = new SqlDataAdapter(s, oCon);
        DataSet ds = new DataSet();
        da.Fill(ds, "Image_Position");
        ddllocation.Items.Clear();
        ddllocation.DataSource = ds.Tables["Image_Position"];
        ddllocation.DataTextField = "Position";
        ddllocation.DataValueField = "Position";
        ddllocation.DataBind();
        ddllocation.Items.Insert(0, "Select");
        oCon.Close();

    }
    protected void ddllocation_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddllocation.SelectedValue == "RightMenu")
        {
            if (ddlcategory.SelectedValue == "Home")
            {
                txtimagesize.Text = "180 X 150";
            }
            else
            {
                txtimagesize.Text = "200 X 80";
            }
        }
        else if (ddllocation.SelectedValue == "LeftMenu")
        {
            if (ddlcategory.SelectedValue == "Home")
            {
                txtimagesize.Text = "145 X 370";
            }
            else if (ddlcategory.SelectedValue == "Classifieds")
            {
                txtimagesize.Text = "140 X 35";
            }
        }
        else if (ddllocation.SelectedValue == "BottomMenu")
        {
            txtimagesize.Text = "600 X 50";
        }
        else if (ddllocation.SelectedValue == "Right Topmost Img")
        {
            txtimagesize.Text = "450 X 60";
        }
        else if (ddllocation.SelectedValue == "Below Main Menu")
        {
            txtimagesize.Text = "330 X 70";
        }
        else if (ddllocation.SelectedValue == "Inside Advertising")
        {
            txtimagesize.Text = "300 X 130";
        }
        else
        {
            txtimagesize.Text = "320 X 50";
        }
    }
    private void SendMail(string Adv_Name, string Adv_LastName, string Adv_Address, string Adv_EmailId, string Adv_PhNo, string Ad_Category, string Ad_Title, string Ad_Desc, string Ad_URL, string City, string Country)
    {
        string Msg = "";

        try
        {
            MailMessage mm = new MailMessage();
            mm.From = new MailAddress("info@aceindus.in");
            mm.To.Add(Adv_EmailId);
            Msg += "Dear " + Adv_Name + " " + Adv_LastName + ",<br>" +
                    "<br>Your Advertisement have been posted successfully.<br>" +
                    "<br><b> Your Advertisement Details : </b> <br>" +
                    "<br> Ad Tile :" + Ad_Title +
                    "<br> Ad Description :" + Ad_Desc +
                    "<br> Category of Ad :" + Ad_Category +
                    "<br> Website :" + Ad_URL +
                    "<br><br><b>Your Personal Details : </b><br>" +
                    "<br> Advertiser Name :" + Adv_Name +
                    "<br> Advertiser Adderss :" + Adv_Address +
                    "<br> Advertiser Email Id :" + Adv_EmailId +
                    "<br> Phone Number :" + Adv_PhNo +
                    "<br> City :" + City +
                    "<br> Country :" + Country +
                    "<br><br>For general inquiries, please email us to info@wawalive.net<br>" +
                    "<br>For technical difficulties, suggestions and queries, please email us to support@wawalive.net<br>" +
                    "<br>For suggestions and innovative ideas to improve the portal, please email us to webmaster@wawalive.net";
            ;
            mm.Subject = "Subject : Your Ad Posted Successfully";
            mm.IsBodyHtml = true;
            mm.Body = Msg;
            SmtpClient smtp = new SmtpClient();
            smtp.Send(mm);
        }
        catch (Exception ex)
        {
            lblmsg.Text = ex.Message;
        }
    }
}
