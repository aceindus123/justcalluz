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
using System.Net.Mail;
using System.Net;
using JustCallUsData.Data;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Web.Routing;
using System.Text;


public partial class sessionstore : System.Web.UI.Page
{
    // To make connection
    SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    SqlCommand cmd;
    DataSet dslog = new DataSet();
    DataSet dsfrtings = new DataSet();
    DataSet dsFriends = new DataSet();
    //Creation of object for insert data class
    InsertData obj = new InsertData();
    DataCS data = new DataCS();
    DataSet dsGetPhoto = new DataSet();
    DataSet dsGetLogo = new DataSet();
    DataSet dsreport = new DataSet();
    private static DataTable tblData = new DataTable();
    int id;
    string Tname;
    string IPAddress;
    string PhysicalAddress;
    bool t;
    //Creation of object for bind data class
    Binddata obj1 = new Binddata();
    string sid = string.Empty;
    string cat;
    string imgLogoName;
    string ImgLogoContentType;
    string imgPhotoName;
    string imgPhotoContentType;
    string VideoName;
    string VideoContentType;
    string strScript = "";
    string Caption;
    Int32 Did;
    string Cname = string.Empty;
    DataSet dsUserDetails = new DataSet();
    char[] separatorcomma = new char[] { ',' };
    //static string baseUri = "http://maps.googleapis.com/maps/api/geocode/xml?latlng={0},{1}&sensor=false";
    string location = string.Empty;
    static string excep_page = "sessionstore.aspx";
    string Msg = "";
    string Msg1 = "";
    StringBuilder sb = new StringBuilder();
    string uid;
    string pwd;
    string str;
    string mobilenum;
    int regid;
    SSCS objtag = new SSCS();
    List<string> Listfrids = new List<string> { };
    string ResultString = string.Empty;
    private static string _sText1;
    private static string _sText2;
    private static string _sText3;
    string strratingcount = string.Empty;
    string viewratings = string.Empty;
    DataSet dsreview = new DataSet();

    /// <summary>
    /// Executes whenever page loads
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Page_Load(object sender, EventArgs e)
    {

        pnlmap.Visible = false;
        pnlNoMap.Visible = false;
        uid = Convert.ToString(Session["USERID"]);
        pwd = Convert.ToString(Session["PASSWORD"]);

        Pnlusertype.Visible = false;
        pnlConfirm.Visible = false;
        pnlincorrect.Visible = false;
        if (uid != "")
        {
        }
        if (Page.RouteData.Values.Count() > 0)
        {
            sid = Convert.ToString(Page.RouteData.Values["id"]);
            Did = Convert.ToInt32(Convert.ToString(Page.RouteData.Values["id"]));
        }
        else if (Convert.ToString(Request.QueryString["comp"]) == "View")
        {
            sid = Convert.ToString(Request.QueryString["id"]);
            Did = Convert.ToInt32(Convert.ToString(Request.QueryString["id"]));
        }
        // page loads without post backing form values
        String[] sItems = new String[5];
        Int32[] iValue = new Int32[5];
        // Populate our variables
        sItems[0] = "Excellent";
        sqlConnection.Open();
        string q1 = "Select Count(*) from postreview where Stars_Rating='" + 5 + "' and dataid='" + sid + "'";
        cmd = new SqlCommand(q1, sqlConnection);
        iValue[0] = Convert.ToInt32(cmd.ExecuteScalar());
        sqlConnection.Close();

        sItems[1] = "Very Good";
        sqlConnection.Open();
        string q2 = "Select Count(*) from postreview where Stars_Rating='" + 4 + "' and dataid='" + sid + "'";
        cmd = new SqlCommand(q2, sqlConnection);
        iValue[1] = Convert.ToInt32(cmd.ExecuteScalar());
        sqlConnection.Close();

        sItems[2] = "Good";
        sqlConnection.Open();
        string q3 = "Select Count(*) from postreview where Stars_Rating='" + 3 + "' and dataid='" + sid + "'";
        cmd = new SqlCommand(q3, sqlConnection);
        iValue[2] = Convert.ToInt32(cmd.ExecuteScalar());
        sqlConnection.Close();

        sItems[3] = "Average";
        sqlConnection.Open();
        string q4 = "Select Count(*) from postreview where Stars_Rating='" + 2 + "' and dataid='" + sid + "'";
        cmd = new SqlCommand(q4, sqlConnection);
        iValue[3] = Convert.ToInt32(cmd.ExecuteScalar());
        sqlConnection.Close();

        sItems[4] = "Poor";
        sqlConnection.Open();
        string q5 = "Select Count(*) from postreview where Stars_Rating='" + 1 + "' and dataid='" + sid + "'";
        cmd = new SqlCommand(q5, sqlConnection);
        iValue[4] = Convert.ToInt32(cmd.ExecuteScalar());
        sqlConnection.Close();

        //// Set our axis values
        overallrating.YAxisValues = iValue;

        //// Set our axis strings
        overallrating.YAxisItems = sItems;
        //BarGraphRating();



        //to retrive logo
        dsGetLogo = data.getLogo(Did);
        try
        {
            if (!dsGetLogo.Tables[0].Rows.Count.Equals(0))
            {

                string logoname = dsGetLogo.Tables[0].Rows[0]["ImageName"].ToString();
                if (logoname == "0")
                {
                    lblNoLogo.Visible = true;
                    ddlLogo.Visible = false;
                    lblNoLogo.Text = "No Logo is available.Please Upload";
                    lblNoLogo.CssClass = "sub_menu";
                }
                else if (logoname == "NULL")
                {
                    lblNoLogo.Visible = true;
                    ddlLogo.Visible = false;
                    lblNoLogo.Text = "No Logo is available.Please Upload";
                    lblNoLogo.CssClass = "sub_menu";
                }
                else if (logoname == "")
                {
                    lblNoLogo.Visible = true;
                    ddlLogo.Visible = false;
                    lblNoLogo.Text = "No Logo is available.Please Upload";
                    lblNoLogo.CssClass = "sub_menu";
                }
                else
                {
                    ddlLogo.Visible = true;
                    lblNoLogo.Visible = false;
                    ddlLogo.DataSource = dsGetLogo;
                    ddlLogo.DataBind();
                }
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
        //to retrive photos
        dsGetPhoto = data.getPhotos(Did);
        try
        {
            if (!dsGetPhoto.Tables[0].Rows.Count.Equals(0))
            {
                //dlPhotos.Visible = true;
                //lblNoPhotos.Visible = false;
                //dlPhotos.DataSource = dsGetPhoto;
                //dlPhotos.DataBind();
                dlphoto1.DataSource = dsGetPhoto;
                dlphoto1.DataBind();

            }
            else
            {
                //lblNoPhotos.Visible = true;
                ////dlPhotos.Visible = false;
                //lblNoPhotos.Text = "No Photo is available.Please Upload";
                //lblNoPhotos.CssClass = "sub_menu";
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
        if (!IsPostBack)
        {
            try
            {
                if (Page.RouteData.Values.Count() > 0)
                {
                    sid = Convert.ToString(Page.RouteData.Values["id"].ToString());
                }
                else if (Convert.ToString(Page.RouteData.Values["tname"]) != "")
                {
                    Tname = Convert.ToString(Page.RouteData.Values["tname"].ToString());
                }
                //Pnllogin.Visible = false;
                SqlDataAdapter imgtext = new SqlDataAdapter("select * from ModulesData where id='" + sid + "'", sqlConnection);
                imgtext.Fill(dsUserDetails, "Registration");

                if (!dsUserDetails.Tables[0].Rows.Count.Equals(0))
                {
                    metadata(dsUserDetails.Tables[0].Rows[0]["company_name"].ToString());
                    Session["CompanyName"] = dsUserDetails.Tables[0].Rows[0]["company_name"].ToString();
                    Session["WebSite"] = dsUserDetails.Tables[0].Rows[0]["Website"].ToString();
                    Session["Fax"] = dsUserDetails.Tables[0].Rows[0]["fax"].ToString();
                    Session["Company_Profile"] = dsUserDetails.Tables[0].Rows[0]["company_profile"].ToString();
                    cat = dsUserDetails.Tables[0].Rows[0]["Category"].ToString();
                    Session["Cat"] = cat;
                    string theatre = Convert.ToString(Session["CompanyName"]);
                    if (Tname == theatre)
                    {
                        hallinfo(Tname);
                    }
                }
                dlData.Visible = true;
                dlphoto1.Visible = true;
                if (uid != "" && pwd != "")
                {
                    if (Convert.ToString(Page.RouteData.Values["rname"]) != null)
                    {
                        viewratings = Convert.ToString(Page.RouteData.Values["rname"]);
                        BindRatings(Convert.ToString(Session["USERID"]), Convert.ToString(Session["PASSWORD"]), Convert.ToString(Session["Mob"]), viewratings);
                        BindReview();
                    }

                }
                else
                {
                    BindReview();
                }
                // BindMoreInfo();
                MorInfo.Visible = false;
                divMap.Visible = false;
                tblmapctrl.Visible = false;
                tblphotos.Visible = false;
                divfotos.Visible = false;
                divOwn.Visible = false;
                txtrname.Text = "";
                txtcmnt.Text = "";
                txtcntno.Text = "";
                txtmail.Text = "";
            }
            catch (Exception ex)
            {
                obj.insert_exception(ex, excep_page);
                Response.Redirect("HttpErrorPage.aspx");
            }

        }
        try
        {
            if (Convert.ToString(Page.RouteData.Values["tname"]) != "")
            {
                string hname = Convert.ToString(Page.RouteData.Values["tname"].ToString());
                hallinfo(hname);

            }
            tblData = data.FetchData(Did);
            if (tblData.Rows.Count > 0)
            {
                string imgPath = "Photos/" + tblData.Rows[0]["PhotoName"].ToString();
                imgShowImage.ImageUrl = imgPath;
            }
            //sid = Convert.ToString(Page.RouteData.Values["id"].ToString());
            SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
            con.Open();
            cmd = new SqlCommand("Select count(rid) as NumberOfUsers,sum(Stars_Rating) as Total from PostReview where dataid='" + sid + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            float count = 0, rating = 0, result = 0;

            if (Convert.ToInt32(dt.Rows[0]["NumberOfUsers"].ToString()) != 0)
            {
                count = float.Parse(dt.Rows[0]["NumberOfUsers"].ToString());
                rating = float.Parse(dt.Rows[0]["Total"].ToString());
                result = Convert.ToInt32(Math.Ceiling((rating / count) * 18));
                //avgrating.InnerText = Math.Round((rating / count), 1).ToString();
            }
            else
            {
                //avgrating.InnerText = "0";
            }
            //testSpan.Style.Add("width", result + "px");

            //userscount.InnerText = "5";

            DataSet dsd = new DataSet();
            dsd = obj1.data(sid);
            if (dsd.Tables[0].Rows.Count > 0)
            {

                dlData.DataSource = dsd;
                dlData.DataBind();
                dlData1.DataSource = dsd;
                dlData1.DataBind();
            }
            else
            {
                ClientScript.RegisterStartupScript(typeof(Page), "UnAvilable", "<script>alert('Sorry for the inconvenience');window.history.go(-1);</script>");

            }



            string strname = string.Empty;
            strname = cat;

            con.Close();
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }

    }
    //public static Coordinate GetCoordinates(string region)
    //{
    //    using (var client = new WebClient())
    //    {
    //        string uri = "http://maps.google.com/maps/geo?q='" + region + "'&output=csv&key=ABQIAAAAzr2EBOXUKnm_jVnk0OJI7xSosDVG8KKPE1-m51RBrvYughuyMxQ-i1QfUnH94QxWIa6N4U6MouMmBA";

    //        string[] geocodeInfo = client.DownloadString(uri).Split(',');

    //        return new Coordinate(Convert.ToDouble(geocodeInfo[2]), Convert.ToDouble(geocodeInfo[3]));
    //    }
    //}

    //public struct Coordinate
    //{
    //    private double lat;
    //    private double lng;

    //    public Coordinate(double latitude, double longitude)
    //    {
    //        lat = latitude;
    //        lng = longitude;

    //    }

    //    public double Latitude { get { return lat; } set { lat = value; } }
    //    public double Longitude { get { return lng; } set { lng = value; } }

    //}
    /// <summary>
    /// To bind Reviews
    /// </summary>
    public void BindReview()
    {
        try
        {
            //sid = Convert.ToString(Page.RouteData.Values["id"].ToString());
            sqlConnection.Open();
            string Record_Count = string.Empty;
            //uid = Convert.ToString(Session["USERID"]);
            //pwd = Convert.ToString(Session["PASSWORD"]);
            //mobilenum = Convert.ToString(Session["Mob"]);
            //if (uid != "" & pwd != "")
            //{
            //    SqlDataAdapter sdaLogin = new SqlDataAdapter("select id from register where email='" + uid + "' and password='" + pwd + "' and mob='" + mobilenum + "' and iStatus=1", sqlConnection);
            //    DataSet dsLogin = new DataSet();
            //    sdaLogin.Fill(dsLogin);
            //    if (dsLogin.Tables[0].Rows.Count > 0)
            //    {
            //        regid = Convert.ToInt32(dsLogin.Tables[0].Rows[0]["id"]);
            //        str = "Select rid,reg_id,mob=stuff(rmob,4,5,'*****'),rname,email=stuff(remail,4,6,'****'),rating,review,ImageName,ImageContentType,Stars_Rating from PostReview where dataid='" + sid + "' and reg_id=" + regid + " order by rid desc";
            //        strratingcount = "select count(*) as record_count from PostReview where dataid='" + sid + "' and reg_id=" + regid + "";
            //        dsfrtings = objtag.tag_Friends(regid);
            //        if (!dsfrtings.Tables[0].Rows.Count.Equals(0))
            //        {
            //            for (int index = 0; index < dsfrtings.Tables[0].Rows.Count; index++)
            //            {
            //                if (Convert.ToString(dsfrtings.Tables[0].Rows[index]["friend_mobile"]) != "")
            //                {
            //                    Listfrids.Add(objtag.tagFriends_rid(Convert.ToString(dsfrtings.Tables[0].Rows[index]["friend_mobile"])));
            //                }
            //            }
            //            for (int index1 = 0; index1 < Listfrids.Count; index1++)
            //            {
            //                ResultString += Listfrids[index1] + ",";
            //            }
            //            if (ResultString != null)
            //            {

            //                ResultString = ResultString.Substring(0, ResultString.Length - 1);

            //                str = "Select rid,reg_id,mob=stuff(rmob,4,5,'*****'),rname,email=stuff(remail,4,6,'****'),rating,review,ImageName,ImageContentType,Stars_Rating from PostReview where dataid='" + sid + "' and reg_id in (" + ResultString + ") order by rid desc";
            //            }
            //        }

            //    }

            //}
            //else
            //{
            str = "Select rid,reg_id,mob=stuff(rmob,4,5,'*****'),rname,email=stuff(remail,4,6,'****'),rating,review,ImageName,ImageContentType,Stars_Rating from PostReview where dataid='" + sid + "' and reg_id=0 order by rid desc";
            strratingcount = "select count(*) as record_count from PostReview where dataid='" + sid + "'";
            //}
            dsreview.Clear();
            cmd = new SqlCommand(str, sqlConnection);
            SqlDataAdapter ada = new SqlDataAdapter(str, sqlConnection);
            ada.Fill(dsreview);
            //dlReview.DataSource = dsreview;
            //dlReview.DataBind();
            PagedDataSource objPds = new PagedDataSource();
            if (!dsreview.Tables[0].Rows.Count.Equals(0))
            {
                objPds.DataSource = dsreview.Tables[0].DefaultView;
                objPds.AllowPaging = true;
                objPds.PageSize = 11;
                objPds.CurrentPageIndex = CurrentPage;
                lblCurrentPage.Text = "Page: " + (CurrentPage + 1).ToString() + " of " + objPds.PageCount.ToString();
                // Disable Prev or Next buttons if necessary
                imgPrevious.Enabled = !objPds.IsFirstPage;
                imgNext.Enabled = !objPds.IsLastPage;
                dlReview.DataKeyField = "rid";
                dlReview.DataSource = objPds;
                dlReview.DataBind();
            }
            else
            {
                lblCurrentPage.Text = "No  Reviews  available. Be  the  first  one  to  post  review  for  this  customer.";
                lblCurrentPage.CssClass = "sub_menu";
                imgNext.Visible = false;
                imgPrevious.Visible = false;
            }

            DataSet dsCount = new DataSet();
            SqlCommand cmd1 = new SqlCommand(strratingcount, sqlConnection);
            SqlDataReader dr;

            dr = cmd1.ExecuteReader();
            while (dr.Read())
            {
                Record_Count = Convert.ToString(dr["Record_Count"].ToString());
                Session["RecordCount"] = Record_Count;
            }
            lblrating.Text = Record_Count;
            lblrating1.Text = Record_Count;
            sqlConnection.Close();

            //sqlConnection.Open();
            //string str2 = "select count(*) as record_count from PostReview where dataid=" + sid;
            //cmd = new SqlCommand(str2, sqlConnection);
            //lblrating.Text = Convert.ToString(cmd.ExecuteScalar());
            //// To close connection
            //sqlConnection.Close();
            //lblrating1.Text = Record_Count;
            //// To close connection
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }


    }
    public void BindRatings(string ruid, string rpwd, string rmbl, string rtype)
    {
        if (rtype == "Myratings")
        {
            lblCurrentPage.Text = "No  Reviews  available. Be  the  first  one  to  post  review  for  this  customer.";
            lblCurrentPage.CssClass = "sub_menu";
            imgNext.Visible = false;
            imgPrevious.Visible = false;
        }
        else if (rtype == "Friendsratings")
        {
            lblCurrentPage.Text = "No  friends ratings are available.";
            lblCurrentPage.CssClass = "sub_menu";
            imgNext.Visible = false;
            imgPrevious.Visible = false;
        }
    }
    /// <summary>
    /// To go previous page
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void imgPrevious_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            CurrentPage -= 1;
            BindReview();
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }

    }
    /// <summary>
    /// To go next page
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void imgNext_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            CurrentPage += 1;
            BindReview();
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }

    }
    /// <summary>
    /// To get the current page status
    /// </summary>
    public int CurrentPage
    {
        get
        {
            object o = this.ViewState["_CurrentPage"];
            if (o == null)
                return 0;
            else
                return (int)o;
        }
        set
        {
            this.ViewState["_CurrentPage"] = value;
        }
    }
    protected void btnXSendSMS_Click(object sender, EventArgs e)
    {
        //Panel3.Visible = false;
    }
    /// <summary>
    /// To display category data
    /// </summary>
    /// <param name="source"></param>
    /// <param name="e"></param>
    //protected void DLBindCatData_ItemCommand(object source, System.Web.UI.WebControls.DataListCommandEventArgs e)
    //{
    //    Session["name"] = e.CommandArgument.ToString();
    //    string name = "";
    //    name = e.CommandArgument.ToString();
    //    Response.Redirect("linkcontroller.aspx?cname=" + name + "");


    //}
    /// <summary>
    /// To display sponsored links
    /// </summary>
    /// <param name="source"></param>
    /// <param name="e"></param>
    //protected void dlsponsoredlinks_ItemCommand(object source, System.Web.UI.WebControls.DataListCommandEventArgs e)
    //{
    //    Session["name"] = e.CommandArgument.ToString();
    //    string name = "";
    //    name = e.CommandArgument.ToString();
    //    Response.Redirect("linkcontroller.aspx?cname=" + name + "");


    //}
    /// <summary>
    /// To send form values to sendmail
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void imgbtnGo_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            string NameToSend = txtname.Text;
            string EmailToSend = txtemail.Text;
            string PhoneToSend = txtmob.Text;
            SqlDataAdapter imgtext = new SqlDataAdapter("select * from ModulesData where id='" + sid + "'", sqlConnection);
            imgtext.Fill(dsUserDetails, "Registration");
            string CompanyName = string.Empty;
            string ContactPerson = string.Empty;
            string Address = string.Empty;
            string LandMark = string.Empty;
            string Mobile = string.Empty;
            string Email = string.Empty;
            string Phone = string.Empty;
            if (!dsUserDetails.Tables[0].Rows.Count.Equals(0))
            {
                CompanyName = dsUserDetails.Tables[0].Rows[0]["company_name"].ToString();
                ContactPerson = dsUserDetails.Tables[0].Rows[0]["contact_person"].ToString();
                Address = dsUserDetails.Tables[0].Rows[0]["address"].ToString();
                LandMark = dsUserDetails.Tables[0].Rows[0]["land_mark"].ToString();
                Mobile = dsUserDetails.Tables[0].Rows[0]["mob"].ToString();
                Email = dsUserDetails.Tables[0].Rows[0]["emailid"].ToString();
                Phone = dsUserDetails.Tables[0].Rows[0]["landphno"].ToString();
            }

            string str = "Insert into sendmail(name,email,ph,companyname,adid) values('" + NameToSend + "','" + EmailToSend + "','" + PhoneToSend + "','" + CompanyName + "','" + sid + "')";
            SqlCommand cmd = new SqlCommand(str, sqlConnection);
            try
            {
                sqlConnection.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                obj.insert_exception(ex, excep_page);
                Response.Redirect("HttpErrorPage.aspx");
            }
            finally
            {
                cmd.Dispose();
                sqlConnection.Close();
            }

            SMSCAPI objSms = new SMSCAPI();
            Msg = "Please find below the information you had requested:" +
                "Whenever you call please mention that you got this info from Justcalluz.com" + "," + "Company name:" + CompanyName + "," +
                "Contact Person:" + ContactPerson + "," +
                "Address:" + Address + "," +
                "Land Mark:" + LandMark + "," +
                "Phone:" + Mobile + "," + Phone + "," +
                "Email:" + Email + "," +
                "We hope the above information is in line with your request." +
                "Kindly feel free to search for more information on www.justcalluz.com or call on +9166136226." +
                 "Warm Regards," +
                            "Team JustCalluz";
            objSms.SendSMS("montessori", "Gani1525", txtmob.Text, Msg);
            SendMail(NameToSend, EmailToSend, PhoneToSend, CompanyName, ContactPerson, Address, LandMark, Email, Mobile, Phone);
            string strScript = "";
            strScript = "alert('Your Mail is Sent Successfully.');";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
            txtemail.Text = "";
            txtmob.Text = "";
            txtname.Text = "";
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }

    }

    /// <summary>
    /// To send categories data as mail 
    /// </summary>
    /// <param name="NameToSend"></param>
    /// <param name="EmailToSend"></param>
    /// <param name="PhoneToSend"></param>
    /// <param name="CompanyName"></param>
    /// <param name="ContactPerson"></param>
    /// <param name="Address"></param>
    /// <param name="LandMark"></param>
    /// <param name="Email"></param>
    /// <param name="Mobile"></param>
    /// <param name="Phone"></param>
    private void SendMail(string NameToSend, string EmailToSend, string PhoneToSend, string CompanyName, string ContactPerson, string Address, string LandMark, string Email, string Mobile, string Phone)
    {

        try
        {
            MailMessage mm = new MailMessage();
            mm.From = new MailAddress("info@justcalluz.com");
            mm.To.Add(EmailToSend);
            Msg1 += "Dear <b>" + NameToSend + "</b> ," +
                        "<br>Please find below the information you had requested:<br>" +
                        "<br>Whenever you call please mention that you got this info from Justcalluz.com" +
                        "<br><br><a href=http://www.justcalluz.com/sessionstorebuilder-details-" + sid + ">" + CompanyName + "</a>" + "</b> " +
                        "<br><br><table width=100%>" +
                        "<tr><td align=left>Contact Person</td><td>:</td><td>" + ContactPerson + "</td></tr>" +
                        "<tr><td align=left>Address</td><td>:</td><td>" + Address + "</td></tr>" +
                        "<tr><td align=left>Land Mark</td><td>:</td><td>" + LandMark + "</td></tr>" +
                        "<tr><td align=left>Phone</td><td>:</td><td>" + Mobile + "," + Phone + "</td></tr>" +
                        "<tr><td align=left>Email</td><td>:</td><td>" + Email + "</td></tr>" +
                        "</table>" +
                        "<br>We hope the above information is in line with your request." +
                        "<br>Kindly feel free to search for more information on <a href=http://www.justcalluz.com/>www.justcalluz.com</a> or call on +9166136226." +
                        "<br><br>Warm Regards," +
                        "<br> Team JustCalluz";
            //mm.BodyFormat = MailFormat.Html;
            //mm.Body = Msg;
            //SmtpMail.SmtpServer = ConfigurationSettings.AppSettings["MySMTPServer"];
            //SmtpMail.Send(mm);
            mm.Subject = "Response to your search for " + CompanyName;
            mm.IsBodyHtml = true;
            mm.Body = Msg1;
            SmtpClient smtp = new SmtpClient();
            smtp.Send(mm);


        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    /// <summary>
    /// To go previous page
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    //protected void btnBack_Click(object sender, EventArgs e)
    //{
    //    Response.Redirect("linkcontroller.aspx?cname=" + cat);
    //}
    /// <summary>
    /// To post review
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    //protected void ImgBtnPostReview_Click(object sender, ImageClickEventArgs e)
    //{
    //    sid = (Request.QueryString["id"].ToString());
    //    Response.Redirect("PostReviewCat.aspx?DataId=" + sid);
    //}
    /// <summary>
    /// To bound review data info
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void dlData_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        try
        {
            //sid = Convert.ToString(Page.RouteData.Values["id"].ToString());
            //sqlConnection.Open();
            cmd = new SqlCommand("Select count(rid) as NumberOfUsers,sum(Stars_Rating) as Total from PostReview where dataid='" + sid + "'", sqlConnection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            float count = 0, rating = 0, result = 0;

            if (Convert.ToInt32(dt.Rows[0]["NumberOfUsers"].ToString()) != 0)
            {
                count = float.Parse(dt.Rows[0]["NumberOfUsers"].ToString());
                rating = float.Parse(dt.Rows[0]["Total"].ToString());
                result = Convert.ToInt32(Math.Ceiling((rating / count) * 18));
            }
            else
            {
            }

            HtmlGenericControl span = e.Item.FindControl("testSpan0") as HtmlGenericControl;
            if (span != null)
                span.Style.Add("width", result + "px");
            Label lblRating = (Label)e.Item.FindControl("lblratingh");
            if (lblRating != null)
                lblRating.Text = Convert.ToString(Session["RecordCount"]);

            HtmlTableRow trWebsite = (HtmlTableRow)e.Item.FindControl("trWebSite");
            if (trWebsite != null)
            {
                if (Convert.ToString(Session["WebSite"]) != "")
                {
                    trWebsite.Visible = true;
                }
                else
                {
                    trWebsite.Visible = false;
                }
            }
            HtmlTableRow trFax = (HtmlTableRow)e.Item.FindControl("trFax");
            if (trFax != null)
            {
                if (Convert.ToString(Session["Fax"]) != "")
                {
                    trFax.Visible = true;
                }
                else
                {
                    trFax.Visible = false;
                }
            }
            HtmlTableRow trComProf = (HtmlTableRow)e.Item.FindControl("trComprofile");
            if (trComProf != null)
            {
                if (Convert.ToString(Session["Company_Profile"]) != "")
                {
                    trComProf.Visible = true;
                }
                else
                {
                    trComProf.Visible = false;
                }
            }
            HtmlTableCell tdimge = (HtmlTableCell)e.Item.FindControl("tdlogo");
            Label imgname = (Label)e.Item.FindControl("lblImgName");
            if (imgname != null)
            {
                if (imgname.Text != "0")
                {
                    tdimge.Visible = true;
                }
                else
                {
                    tdimge.Visible = false;
                }
            }
            // sqlConnection.Close();
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }

    }
    /// <summary>
    /// To bound review rating bound
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void dlReview_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        try
        {
            Label rating = (Label)e.Item.FindControl("lblrating");
            Label Rate = (Label)e.Item.FindControl("lblRate");
            int StarRating = Convert.ToInt32(Rate.Text);
            for (int i = 0; i < StarRating; i++)
            {
                rating.Text += "<img src=images/starorange.png>";

            }
            for (int j = StarRating; j < 5; j++)
            {
                rating.Text += "<img src=images/star_empty.png>";
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }

    }

    protected void lnkBtnContact_Click(object sender, EventArgs e)
    {
        try
        {
            Panel3.Visible = true;
            dlData.Visible = true;
            dlphoto1.Visible = true;
            MorInfo.Visible = false;
            divMap.Visible = false;
            tblmapctrl.Visible = false;
            sendbutton.Visible = true;
            tblphotos.Visible = false;
            divfotos.Visible = false;
            divOwn.Visible = false;
            //Pnllogin.Visible = false;
            pnlMore.Visible = false;
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }

    }
    protected void lnkBtnMoreInfo_Click(object sender, EventArgs e)
    {
        try
        {
            BindMoreInfo();
            //Panel3.Visible = false;
            //dlData.Visible = false;
            //dlphoto1.Visible = false;
            //MorInfo.Visible = true;
            //divMap.Visible = false;
            //tblmapctrl.Visible = false;
            //sendbutton.Visible = false;
            //tblphotos.Visible = false;
            //divfotos.Visible = false;
            //divOwn.Visible = false;
            //Pnllogin.Visible = false;
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }

    protected void lnkbtnphotos_Click(object sender, EventArgs e)
    {
        try
        {
            Panel3.Visible = false;
            dlData.Visible = false;
            dlphoto1.Visible = false;
            MorInfo.Visible = false;
            divMap.Visible = false;
            tblmapctrl.Visible = false;
            sendbutton.Visible = false;
            tblphotos.Visible = true;
            divfotos.Visible = true;
            divOwn.Visible = false;
            //Pnllogin.Visible = false;
            pnlMore.Visible = false;
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void lnkownlst_Click(object sender, EventArgs e)
    {
        try
        {
            //string uid = Convert.ToString(Session["USERID"]);
            //string pwd = Convert.ToString(Session["PASSWORD"]);
            //if (uid != "" && pwd!="")
            //{
            //    Pnllogin.Visible = false;
            //    ModalPopupExtender.Hide();
            //}
            //else
            //{

            //    Pnllogin.Visible = true;
            //    ModalPopupExtender.Show();
            //}
            Panel3.Visible = false;
            dlData.Visible = false;
            dlphoto1.Visible = false;
            MorInfo.Visible = false;
            divMap.Visible = false;
            tblmapctrl.Visible = false;
            sendbutton.Visible = false;
            tblphotos.Visible = false;
            divfotos.Visible = false;
            divOwn.Visible = true;
            //Pnllogin.Visible = true;
            //Pnllogin1.Visible = false;
            pnlupload.Visible = true;
            pnluploadphoto.Visible = false;
            pnlMore.Visible = false;
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    public void BindMoreInfo()
    {
        try
        {
            //sid = Convert.ToString(Page.RouteData.Values["id"].ToString());
            string MonDur = "";
            string TuesDur = "";
            string WedDur = "";
            string ThursDur = "";
            string FriDur = "";
            string SatDur = "";
            string SunDur = "";
            string Monday = "";
            string Tuesday = "";
            string Wednesday = "";
            string Thursday = "";
            string Friday = "";
            string Satday = "";
            string Sunday = "";
            string Payment = "";
            string Established = "";
            string Emp_No = "";
            string query = "select * from AddMoreInfo where dataid=" + sid;
            SqlDataAdapter adaMoreInfo = new SqlDataAdapter(query, sqlConnection);
            DataSet dsMoreInfo = new DataSet();
            adaMoreInfo.Fill(dsMoreInfo);
            if (!dsMoreInfo.Tables[0].Rows.Count.Equals(0))
            {
                Panel3.Visible = false;
                dlData.Visible = false;
                dlphoto1.Visible = false;
                MorInfo.Visible = true;
                divMap.Visible = false;
                tblmapctrl.Visible = false;
                sendbutton.Visible = false;
                tblphotos.Visible = false;
                divfotos.Visible = false;
                divOwn.Visible = false;
                // Pnllogin.Visible = false;
                Monday = dsMoreInfo.Tables[0].Rows[0]["Monday"].ToString();
                Tuesday = dsMoreInfo.Tables[0].Rows[0]["Tuesday"].ToString();
                Wednesday = dsMoreInfo.Tables[0].Rows[0]["Wednesday"].ToString();
                Thursday = dsMoreInfo.Tables[0].Rows[0]["Thursday"].ToString();
                Friday = dsMoreInfo.Tables[0].Rows[0]["Friday"].ToString();
                Satday = dsMoreInfo.Tables[0].Rows[0]["Saturday"].ToString();
                Sunday = dsMoreInfo.Tables[0].Rows[0]["Sunday"].ToString();
                MonDur = dsMoreInfo.Tables[0].Rows[0]["Mon_Dur"].ToString();
                TuesDur = dsMoreInfo.Tables[0].Rows[0]["Tues_Dur"].ToString();
                WedDur = dsMoreInfo.Tables[0].Rows[0]["Wed_Dur"].ToString();
                ThursDur = dsMoreInfo.Tables[0].Rows[0]["Thurs_Dur"].ToString();
                FriDur = dsMoreInfo.Tables[0].Rows[0]["Fri_Dur"].ToString();
                SatDur = dsMoreInfo.Tables[0].Rows[0]["Satur_Dur"].ToString();
                SunDur = dsMoreInfo.Tables[0].Rows[0]["Sun_Dur"].ToString();
                Payment = dsMoreInfo.Tables[0].Rows[0]["PaymentMode"].ToString();
                Established = dsMoreInfo.Tables[0].Rows[0]["Year_Established"].ToString();
                Emp_No = dsMoreInfo.Tables[0].Rows[0]["No_of_employees"].ToString();
                if (Monday == "Time Duration")
                {
                    string[] strMonArr = MonDur.Split(separatorcomma);
                    foreach (string arrstrrMon in strMonArr)
                    {
                        //lblMonday.Text += arrstrrMon + "<br />";
                        lblMonday.Text += arrstrrMon;
                    }
                }
                else
                {
                    lblMonday.Text = Monday;
                }
                if (Tuesday == "Time Duration")
                {
                    string[] strTuesArr = TuesDur.Split(separatorcomma);
                    foreach (string arrstrrTues in strTuesArr)
                    {
                        //lblTuesday.Text += arrstrrTues + "<br />";
                        lblTuesday.Text += arrstrrTues;
                    }
                }
                else
                {
                    lblTuesday.Text = Tuesday;
                }
                if (Wednesday == "Time Duration")
                {
                    string[] strWedArr = WedDur.Split(separatorcomma);
                    foreach (string arrstrrWed in strWedArr)
                    {
                        //lblWednesday.Text += arrstrrWed + "<br />";
                        lblWednesday.Text += arrstrrWed;
                    }
                }
                else
                {
                    lblWednesday.Text = Wednesday;
                }
                if (Thursday == "Time Duration")
                {
                    string[] strThursArr = ThursDur.Split(separatorcomma);
                    foreach (string arrstrrThurs in strThursArr)
                    {
                        //lblThursday.Text += arrstrrThurs + "<br />";
                        lblThursday.Text += arrstrrThurs;
                    }
                }
                else
                {
                    lblThursday.Text = Thursday;
                }
                if (Friday == "Time Duration")
                {
                    string[] strFriArr = FriDur.Split(separatorcomma);
                    foreach (string arrstrrFri in strFriArr)
                    {
                        //lblFriday.Text += arrstrrFri + "<br />";
                        lblFriday.Text += arrstrrFri;
                    }
                }
                else
                {
                    lblFriday.Text = Friday;
                }
                if (Satday == "Time Duration")
                {
                    string[] strSatArr = SatDur.Split(separatorcomma);
                    foreach (string arrstrrSat in strSatArr)
                    {
                        //lblSaturday.Text += arrstrrSat + "<br />";
                        lblSaturday.Text += arrstrrSat;
                    }
                }
                else
                {
                    lblSaturday.Text = Satday;
                }
                if (Sunday == "Time Duration")
                {
                    string[] strSunArr = SunDur.Split(separatorcomma);
                    foreach (string arrstrrSun in strSunArr)
                    {
                        //lblSunday.Text += arrstrrSun + "<br />";
                        lblSunday.Text += arrstrrSun;
                    }
                }
                else
                {
                    lblSunday.Text = Sunday;
                }
                if (Payment != "")
                {
                    string[] strpayArr = Payment.Split(separatorcomma);
                    foreach (string Arrstrpay in strpayArr)
                    {
                        //lblpaymodes.Text += Arrstrpay + "<br />";
                        lblpaymodes.Text += Arrstrpay;
                    }
                }
                else
                {
                    lblpaymodes.Text = "Not Mentioned";
                }
                if (Established == "")
                {
                    lblyrestd.Text = "Not Mentioned";
                }
                else
                {
                    lblyrestd.Text = Established;
                }
                if (Emp_No == "")
                {
                    lblempcount.Text = "Not Mentioned";
                }
                else
                {
                    lblempcount.Text = Emp_No;
                }
            }
            else
            {
                Panel3.Visible = false;
                dlData.Visible = false;
                dlphoto1.Visible = false;
                divMap.Visible = false;
                tblmapctrl.Visible = false;
                sendbutton.Visible = false;
                tblphotos.Visible = false;
                divfotos.Visible = false;
                divOwn.Visible = false;
                //Pnllogin.Visible = false;
                MorInfo.Visible = false;
                pnlMore.Visible = true;

            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void imgAbuseGo_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
           
            string strscript = string.Empty;
            if (Page.RouteData.Values.Count() > 0)
            {
                Did = Convert.ToInt32(Convert.ToString(Page.RouteData.Values["id"]));

            }
            else if (Convert.ToString(Request.QueryString["comp"]) == "View")
            {
                Did = Convert.ToInt32(Convert.ToString(Request.QueryString["id"]));
            }
            data.pId = Did;
            data.dReportType = "abuse";
            data.dIPAddress = data.GetNetWorkIPAddress();
            //data.dPhysicalAddress = data.GetMACAddress();
            data.dPostDate = Convert.ToDateTime(System.DateTime.Now);
            data.dContact_Person = Convert.ToString(txtrname.Text);
            data.dPhNumber = Convert.ToString(txtcntno.Text);
            data.dEmail = Convert.ToString(txtmail.Text);
            data.dComment = Convert.ToString(txtcmnt.Text);
            t = data.Insert_ReportAbuse(data.pId, data.dContact_Person, data.dPhNumber, data.dEmail, data.dComment, data.dReportType, data.dIPAddress, data.dPostDate);
            if (t == true)
            {
                lblConfirmation.Text = "<span class=mid_menu>Report Abuse !</span><br/>Thank you, for taking out time to report abuse on Justcalluz, our team shall review this listing and take appropriate action within 72 hours. Justcalluz Team.";
                ModalPopupExtender3.Show();
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }

    protected void Login1_Authenticate(object sender, EventArgs e)
    {
        try
        {
            //sid = Convert.ToString(Page.RouteData.Values["id"]);

            //if (logindetails(Login1.UserName, Login1.Password)==true)
            if (logindetails(txtAUserid.Text, txtAMobile.Text, txtAPwd.Text) == true)
            {
                pnluploadphoto.Visible = true;
                pnlupload.Visible = false;
                // Pnllogin.Visible = false;

                //DataSet ds = new DataSet();
                //ds = obj1.bindlifestyle(sid);
                //if (!ds.Tables[0].Rows.Count.Equals(0))
                //{
                //    for (int i = 0; i < dsUserDetails.Tables[0].Rows.Count; i++)
                //    {
                //        if (Login1.UserName == ds.Tables[0].Rows[0]["UserLoginId"].ToString())
                //        {
                //            pnluploadphoto.Visible = true;
                //            pnlupload.Visible = false;
                //            break;
                //        }

                //        else
                //        {
                //            strScript = "alert('Sorry! You are not the authorized user to view or upload photos .');";
                //            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                //        }
                //    }
                // }
            }
            else
            {
                pnluploadphoto.Visible = false;
            }

        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    /// <summary>
    /// To bind login user Reviews
    /// </summary>
    public void BindLoginReview(string uemailid, string upawrd, string mblnum, string Myndfriendratings)
    {
        string strScripts;
        try
        {
            //sid = Convert.ToString(Page.RouteData.Values["id"].ToString());
            sqlConnection.Open();
            DataSet dsFriends = new DataSet();
            string Record_Count = string.Empty;
            //uid = Convert.ToString(Session["USERID"]);
            //pwd = Convert.ToString(Session["PASSWORD"]);
            //mobilenum = Convert.ToString(Session["Mob"]);
            Session["USERID"] = uemailid;
            Session["PASSWORD"] = upawrd;
            Session["Mob"] = mblnum;
            if (uemailid != "" & upawrd != "")
            {
                SqlDataAdapter sdaLogin = new SqlDataAdapter("select id from register where email='" + uemailid + "' and password='" + upawrd + "' and mob='" + mblnum + "' and iStatus=1", sqlConnection);
                DataSet dsLogin = new DataSet();
                sdaLogin.Fill(dsLogin);
                if (dsLogin.Tables[0].Rows.Count > 0)
                {
                    regid = Convert.ToInt32(dsLogin.Tables[0].Rows[0]["id"]);
                    if (Myndfriendratings == "AllRatings")
                    {
                        str = "Select rid,reg_id,mob=stuff(rmob,4,5,'*****'),rname,email=stuff(remail,4,6,'****'),rating,review,ImageName,ImageContentType,Stars_Rating from PostReview where dataid='" + sid + "' and reg_id=0 order by rid desc;";
                        strratingcount = "select count(*) as record_count from PostReview where dataid='" + sid + "'";

                      }

                    if (Myndfriendratings == "Myratings")
                    {
                     
                        str = "Select rid,reg_id,mob=stuff(rmob,4,5,'*****'),rname,email=stuff(remail,4,6,'****'),rating,review,ImageName,ImageContentType,Stars_Rating from PostReview where dataid='" + sid + "' and reg_id=" + regid + " order by rid desc";
                    }
                    else if (Myndfriendratings == "Friendsratings")
                    {
                        dsFriends = objtag.tag_Friends(regid);
                        if (!dsFriends.Tables[0].Rows.Count.Equals(0))
                        {
                            for (int index = 0; index < dsFriends.Tables[0].Rows.Count; index++)
                            {
                                if (Convert.ToString(dsFriends.Tables[0].Rows[index]["friend_mobile"]) != "")
                                {
                                    Listfrids.Add(objtag.tagFriends_rid(Convert.ToString(dsFriends.Tables[0].Rows[index]["friend_mobile"])));
                                }
                            }
                            for (int index1 = 0; index1 < Listfrids.Count; index1++)
                            {
                                ResultString += Listfrids[index1] + ",";
                            }
                            ResultString = ResultString.Substring(0, ResultString.Length - 1);

                            str = "Select rid,reg_id,mob=stuff(rmob,4,5,'*****'),rname,email=stuff(remail,4,6,'****'),rating,review,ImageName,ImageContentType,Stars_Rating from PostReview where dataid='" + sid + "' and reg_id in (" + ResultString + ") order by rid desc";
                        }

                        else
                        {
                            strScripts = "alert('add friends ratings');location.replace('ViewRatings-" + sid + "-" + Myndfriendratings + "');";
                            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScripts, true);
                            return;

                        }



                    }
                }
            }
            else
            {
                strScript = "alert('You havent given the ratings');";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "alertbox", strScript, true);
            }

            cmd = new SqlCommand(str, sqlConnection);
            SqlDataAdapter ada = new SqlDataAdapter(str, sqlConnection);
            ada.Fill(dsreview);
            PagedDataSource objPds = new PagedDataSource();
            if (!dsreview.Tables[0].Rows.Count.Equals(0))
            {
                dlReview.Visible = true;
                objPds.DataSource = dsreview.Tables[0].DefaultView;
                objPds.AllowPaging = true;
                objPds.PageSize = 11;
                objPds.CurrentPageIndex = CurrentPage;
                lblCurrentPage.Text = "Page: " + (CurrentPage + 1).ToString() + " of " + objPds.PageCount.ToString();
                imgPrevious.Enabled = !objPds.IsFirstPage;
                imgNext.Enabled = !objPds.IsLastPage;
                dlReview.DataKeyField = "rid";
                dlReview.DataSource = objPds;
                dlReview.DataBind();
                if (Convert.ToString(Session["Myratingslogin"]) == "first")
                {
                    Session["Myratingslogin"] = "";
                    Response.RedirectToRoute("CT_sessionstore", new { id = Did });
                }

                if (uemailid == "" & upawrd == "")
                {
                    Response.RedirectToRoute("CT_sessionstore", new { id = Did });
                }
            }
            else
            {
                lblCurrentPage.Text = "No  Reviews  available. Be  the  first  one  to  post  review  for  this  customer.";
                lblCurrentPage.CssClass = "sub_menu";
                imgNext.Visible = false;
                imgPrevious.Visible = false;
                dlReview.Visible = false;
                //if (Page.RouteData.Values.Count() > 0)
                //{
                //    sid = Convert.ToString(Page.RouteData.Values["id"]);
                //    Did = Convert.ToInt32(Convert.ToString(Page.RouteData.Values["id"]));
                //}
                //else if (Convert.ToString(Request.QueryString["comp"]) == "View")
                //{
                //    sid = Convert.ToString(Request.QueryString["id"]);
                //    Did = Convert.ToInt32(Convert.ToString(Request.QueryString["id"]));
                //}
                
                //Response.RedirectToRoute("CT_sessionstore", new { id = Did });


                if (Convert.ToString(Session["Myratingslogin"]) == "first")
                {
                    Session["Myratingslogin"] = "";
                    Response.RedirectToRoute("CT_sessionstore", new { id = Did });
                }

                if (uemailid == "" & upawrd == "")
                {
                    Response.RedirectToRoute("CT_sessionstore", new { id = Did });
                }




            }


            sqlConnection.Close();


        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }


    }
    /// <summary>
    /// static member variable
    /// </summary>
    public static string SText1
    {
        get { return _sText1; }
        set { _sText1 = value; }
    }
    /// <summary>
    /// static member variable
    /// </summary>
    public static string SText2
    {
        get { return _sText2; }
        set { _sText2 = value; }
    }
    /// <summary>
    /// static member variable
    /// </summary>
    public static string SText3
    {
        get { return _sText3; }
        set { _sText3 = value; }
    }
    /// <summary>
    /// assignstring service method for insert textboxs text to static string from jquery popup
    /// </summary>
    /// <param name="prefixText"></param>
    /// <returns></returns>
    [System.Web.Services.WebMethod]
    public static string assignstring(string prefixText)
    {

        if (SText1 == null)
            SText1 = prefixText + ",";
        else
            SText1 += prefixText + ",";
        return prefixText;
    }
    [System.Web.Services.WebMethod]
    public static string assignstring1(string prefixText)
    {
        if (SText2 == null)
            SText2 = prefixText + ",";
        else
            SText2 += prefixText + ",";
        return prefixText;
    }
    [System.Web.Services.WebMethod]
    public static string assignstring2(string prefixText)
    {
        if (SText3 == null)
            SText3 = prefixText + ",";
        else
            SText3 += prefixText + ",";
        return prefixText;
    }
    /// <summary>
    /// assinglbl servie method for insert selected package title to static sting from jquery click here functionality
    /// </summary>
    /// static members
    /// <param name="prefixText"></param>
    /// <returns></returns>
    //[System.Web.Services.WebMethod]
    //public static string assinglbl(string prefixText)
    //{
    //    SText2 = prefixText;
    //    return prefixText;
    //}


    protected void Login_FriendsRatings(object sender, EventArgs e)
    {
        string[] s = SText1.TrimEnd(',').Split(',');
        string femail = s[0];
        string fmob = s[2];
        string fpwd = s[1];

        if (logindetails(femail, fmob, fpwd) == true)
        {
            Session["Myratingslogin"] = "first";
            string friendratings = "Friendsratings";
            BindLoginReview(femail, fpwd, fmob, friendratings);
        }
    }
    protected void Login_Upload(object sender, EventArgs e)
    {
        string[] s2 = SText2.TrimEnd(',').Split(',');
        string uemail = s2[0];
        string umob = s2[2];
        string upwd = s2[1];
        if (logindetails(uemail, umob, upwd) == true)
        {
            DataSet ds = new DataSet();
            ds = obj1.bindlifestyle(sid);
            if (!ds.Tables[0].Rows.Count.Equals(0))
            {
                pnluploadphoto.Visible = true;
                pnlupload.Visible = false;
            }
            else
            {
                strScript = "alert('Sorry! You are not the authorized user to view or upload photos .');";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
            }
        }
    }
    protected void btnMyratings_Click(object sender, EventArgs e)
    {
        string[] s3 = SText3.TrimEnd(',').Split(',');
        string memail = s3[0];
        string mmob = s3[2];
        string mpwd = s3[1];
        if (logindetails(memail, mmob, mpwd) == true)
        {
            Session["Myratingslogin"] = "first";
            string myratings = "Myratings";
            BindLoginReview(memail, mpwd, mmob, myratings);
        }
    }
    public int Validate_Login(String email, String Mob, String Password)
    {
        int Results = 0;
        Session["USERID"] = email;
        Session["PASSWORD"] = Password;
        Session["Mob"] = Mob;
        try
        {
            // Making Connection
            SqlCommand cmdselect = new SqlCommand();
            cmdselect.CommandType = CommandType.StoredProcedure;
            cmdselect.CommandText = "[dbo].[loginSP]";
            cmdselect.Parameters.Add("@userid", SqlDbType.VarChar, 50).Value = email;
            cmdselect.Parameters.Add("@mobno", SqlDbType.VarChar, 50).Value = Mob;
            cmdselect.Parameters.Add("@userpwd", SqlDbType.VarChar, 50).Value = Password;
            cmdselect.Parameters.Add("@OutRes", SqlDbType.Int, 4);
            cmdselect.Parameters["@OutRes"].Direction = ParameterDirection.Output;
            cmdselect.Connection = sqlConnection;
            try
            {
                //To open connection
                sqlConnection.Open();
                cmdselect.ExecuteNonQuery();
                Results = (int)cmdselect.Parameters["@OutRes"].Value;
            }
            catch (SqlException ex)
            {
                //To catch exception
                lblMessage.Text = ex.Message;
            }
            finally
            {
                cmdselect.Dispose();
                if (sqlConnection != null)
                {
                    //To close Connection
                    sqlConnection.Close();
                }
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
        return Results;

    }
    public bool logindetails(string UserName, string Mobile, string PassWord)
    {
        bool logedin = false;
        Session["USERID"] = UserName;
        Session["PASSWORD"] = PassWord;
        Session["Mob"] = Mobile;
        try
        {
            // sqlConnection.Open();

            cmd = new SqlCommand("select email,password,mob,iStatus from register where email='" + UserName + "' and password='" + PassWord + "' and mob='" + Mobile + "' and iStatus=1", sqlConnection);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ad.Fill(dsUserDetails);
            if (!dsUserDetails.Tables[0].Rows.Count.Equals(0))
            {
                //    //foreach (DataRow dr in dsUserDetails.Tables[0].Rows)
                //    //{
                //        for (int i = 0; i < dsUserDetails.Tables[0].Rows.Count; i++)
                //        {
                //            if ((UserName == dsUserDetails.Tables[0].Rows[i]["email"].ToString() && (PassWord == dsUserDetails.Tables[0].Rows[i]["password"].ToString())))
                // 
                logedin = true;


            }
            else
            {
                logedin = false;
                strScript = "alert('Sorry! You are not the authorized user.');";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                //strScript = "alert('Sorry! Invalid Credentials.')";
                //Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                //Pnllogin.Visible = false;
            }

            //            }
            //        }
            //    //}

            return logedin;


        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
        return logedin;

    }
    protected void imgcancel_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            pnluploadphoto.Visible = false;
            pnlupload.Visible = true;
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void btnUploadLogo_Click(object sender, EventArgs e)
    {
        try
        {
            //Did = Convert.ToInt32(Page.RouteData.Values["id"]);

            if (Page.RouteData.Values.Count() > 0)
            {
                Did = Convert.ToInt32(Convert.ToString(Page.RouteData.Values["id"]));

            }
            else if (Convert.ToString(Request.QueryString["comp"]) == "View")
            {
                Did = Convert.ToInt32(Convert.ToString(Request.QueryString["id"]));
            }

            if (logoupload.HasFile)
            {
                //Str = uploadLogo.PostedFile.FileName;
                imgLogoName = System.IO.Path.GetFileName(logoupload.PostedFile.FileName);
                sqlConnection.Open();
                dsGetLogo = data.getLogoName(imgLogoName);
                if (!dsGetLogo.Tables[0].Rows.Count.Equals(0))
                {
                    strScript = "alert('Image name already existed please change Image Name');";
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                }
                else
                {
                    if (logoupload.PostedFile.ContentLength < 30000)
                    {
                        //uploadLogo.PostedFile.SaveAs(Server.MapPath("~/Logos/" + imgLogoName));

                        using (System.Drawing.Image Img = System.Drawing.Image.FromStream(logoupload.PostedFile.InputStream))
                        {
                            try
                            {
                                if (Img.Width <= 100 & Img.Height <= 75)
                                {
                                    logoupload.PostedFile.SaveAs(Server.MapPath("~/Logos/" + imgLogoName));
                                    imgLogoName = System.IO.Path.GetFileName(logoupload.PostedFile.FileName);
                                    ImgLogoContentType = logoupload.PostedFile.ContentType;
                                    data.dImgName = imgLogoName;
                                    data.dImgContType = ImgLogoContentType;
                                    data.pId = Did;
                                    t = data.Logo_Update(data.pId, data.dImgName, data.dImgContType);
                                    strScript = "alert('Your Logo is uploaded Successfully')";
                                    Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                                    pnlupload.Visible = true;
                                    pnluploadphoto.Visible = false;
                                }
                                else
                                {
                                    strScript = "alert('You can not Upload the  Image because dimensions of the image Exceeds');";
                                    Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                                }
                            }
                            catch (Exception ex)
                            {
                                obj.insert_exception(ex, excep_page);
                                Response.Redirect("HttpErrorPage.aspx");
                            }
                        }
                    }
                    else
                    {
                        strScript = "alert('File size exceeds maximum limit 30KB.');";
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                    }
                }

            }
            else
            {
                strScript = "alert('Please browse an Image');";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
            }
            // sqlConnection.Close();
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void btnUploadPhotos_Click(object sender, EventArgs e)
    {
        //Did = Convert.ToInt32(Page.RouteData.Values["id"]);
        try
        {
            if (Page.RouteData.Values.Count() > 0)
            {
                Did = Convert.ToInt32(Convert.ToString(Page.RouteData.Values["id"]));

            }
            else if (Convert.ToString(Request.QueryString["comp"]) == "View")
            {
                Did = Convert.ToInt32(Convert.ToString(Request.QueryString["id"]));
            }

            if (photoupload.HasFile)
            {
                //Str = uploadLogo.PostedFile.FileName;
                imgPhotoName = System.IO.Path.GetFileName(photoupload.PostedFile.FileName);
                sqlConnection.Open();
                dsGetPhoto = data.getPhotoName(imgPhotoName);
                if (!dsGetPhoto.Tables[0].Rows.Count.Equals(0))
                {
                    strScript = "alert('Image name already existed please change Image Name');";
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                }
                else
                {
                    //if (photoupload.PostedFile.ContentLength < 30000)
                    //{
                    //uploadPhotos.PostedFile.SaveAs(Server.MapPath("~/Photos/" + imgPhotoName));
                    using (System.Drawing.Image Img = System.Drawing.Image.FromStream(photoupload.PostedFile.InputStream))
                    {
                        try
                        {
                            //if (Img.Width <= 250 & Img.Height <= 300)
                            //{
                            photoupload.PostedFile.SaveAs(Server.MapPath("Photos/" + imgPhotoName));
                            //Str = uploadLogo.PostedFile.FileName;
                            imgPhotoName = System.IO.Path.GetFileName(photoupload.PostedFile.FileName);
                            imgPhotoContentType = photoupload.PostedFile.ContentType;
                            Caption = txtCaption.Text;
                            data.dImgName = imgPhotoName;
                            data.dImgContType = imgPhotoContentType;
                            data.pId = Did;
                            data.dCaption = Caption;
                            t = data.Photo_Insert(data.pId, data.dImgName, data.dImgContType, data.dCaption);
                            strScript = "alert('Photo is uploaded Successfully')";
                            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                            txtCaption.Text = "";
                            //}
                            //else
                            //{
                            //    strScript = "alert('You can not Upload the  Image because dimensions of the image 250 X 300 Exceeds or Depriciate');";
                            //    Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);

                            //}
                        }
                        catch (Exception ex)
                        {
                            obj.insert_exception(ex, excep_page);
                            Response.Redirect("HttpErrorPage.aspx");
                        }
                    }
                    //}
                    //else
                    //{
                    //    strScript = "alert('File size exceeds maximum limit 30KB.');";
                    //    Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                    //}
                }

            }
            else
            {
                strScript = "alert('Please browse an Image');";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
            }
            // sqlConnection.Close();
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    //protected void btnUploadVedios_Click(object sender, EventArgs e)
    //{
    //    //Did = Convert.ToInt32(Page.RouteData.Values["id"]);
    //    try
    //    {
    //        if (Page.RouteData.Values.Count() > 0)
    //        {
    //            Did = Convert.ToInt32(Convert.ToString(Page.RouteData.Values["id"]));

    //        }
    //        else if (Convert.ToString(Request.QueryString["comp"]) == "View")
    //        {
    //            Did = Convert.ToInt32(Convert.ToString(Request.QueryString["id"]));
    //        }
    //        //sqlConnection.Open();
    //        if (videoupload.HasFile)
    //        {
    //            string fileExt = System.IO.Path.GetExtension(videoupload.FileName);

    //            //if (fileExt == ".avi")
    //            //{
    //                VideoName = System.IO.Path.GetFileName(videoupload.PostedFile.FileName);
    //                videoupload.PostedFile.SaveAs(Server.MapPath("~/Videos/" + VideoName));
    //                //uploadVedios.SaveAs("~/Videos/" + System.IO.Path.GetFileName(uploadVedios.PostedFile.FileName));
    //                //VideoName = System.IO.Path.GetFileName(uploadVedios.PostedFile.FileName);
    //                VideoContentType = videoupload.PostedFile.ContentType;
    //                data.dImgName = VideoName;
    //                data.dImgContType = VideoContentType;
    //                data.pId = Did;
    //                t = data.Vedio_Insert(data.pId, data.dImgName, data.dImgContType);
    //                strScript = "alert('Video is uploaded Successfully');";
    //                Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
    //                pnlupload.Visible = true;
    //                pnluploadphoto.Visible = false;
    //            //}
    //            //catch (Exception ex)
    //            //{
    //            //    lblMessage.Text = "ERROR: " + ex.Message.ToString();
    //            //}
    //            //}
    //            //else
    //            //{
    //            //    lblException.Text = "Only .avi files allowed!";
    //            //}
    //        }
    //        else
    //        {
    //            lblMessage.Text = "You have not specified a file.";
    //        }
    //        sqlConnection.Close();
    //    }
    //    catch (Exception ex)
    //    {
    //        obj.insert_exception(ex, excep_page);
    //        Response.Redirect("HttpErrorPage.aspx");
    //    }
    //}
    [System.Web.Services.WebMethod]
    [System.Web.Script.Services.ScriptMethod]
    public static AjaxControlToolkit.Slide[] GetSlides()
    {
        AjaxControlToolkit.Slide[] slides = new AjaxControlToolkit.Slide[tblData.Rows.Count];
        for (int i = 0; i < tblData.Rows.Count; i++)
        {
            String[] imgPath = new String[tblData.Rows.Count];
            DataRow dr = tblData.Rows[i];
            imgPath[i] = "Photos/" + tblData.Rows[i]["PhotoName"].ToString();
            slides[i] = new AjaxControlToolkit.Slide(imgPath[i], "ImageName", dr["Caption"].ToString());
        }
        return slides;
    }
    protected void imgclick(object sender, EventArgs e)
    {
        try
        {
            dlData.Visible = false;
            dlphoto1.Visible = false;
            MorInfo.Visible = false;
            divMap.Visible = false;
            tblmapctrl.Visible = false;
            sendbutton.Visible = false;
            tblphotos.Visible = true;
            divfotos.Visible = true;
            divOwn.Visible = false;
            // Pnllogin.Visible = false;
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    [System.Web.Script.Services.ScriptMethod()]
    [System.Web.Services.WebMethod]
    public static List<string> Getcities(string prefixText)
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["connectionstring"]);
        con.Open();
        SqlCommand cmd = new SqlCommand("select * from cities where city_name like @Name+'%'", con);
        cmd.Parameters.AddWithValue("@Name", prefixText);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        da.Fill(dt);
        List<string> citynames = new List<string>();
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            citynames.Add(dt.Rows[i][1].ToString());
        }
        return citynames;
    }

    protected void lnkmap_Click(object sender, EventArgs e)
    {
        Map();
    }

    private void Map()
    {
        try
        {
            //string Map="";
            pnlmap.Visible = true;
            Panel3.Visible = false;
            //sid = Convert.ToString(Page.RouteData.Values["id"].ToString());
            // sqlConnection.Open();
            SqlDataAdapter mapadapter = new SqlDataAdapter("select id,map,Approved_map from modulesdata where id='" + sid + "' and Approved_map=1", sqlConnection);
            DataSet dsmap = new DataSet();
            mapadapter.Fill(dsmap);
            if (!dsmap.Tables[0].Rows.Count.Equals(0))
            {
                dlphoto1.Visible = false;
                dlData.Visible = false;
                MorInfo.Visible = false;
                divOwn.Visible = false;
                pnluploadphoto.Visible = false;
                pnlNoMap.Visible = false;
                dlmap.Visible = true;
                dlmap.DataSource = dsmap;
                dlmap.DataBind();
            }
            else
            {
                pnlNoMap.Visible = true;
                dlphoto1.Visible = false;
                dlData.Visible = false;
                MorInfo.Visible = false;
                divOwn.Visible = false;
                pnluploadphoto.Visible = false;
                pnlmap.Visible = false;
                tblphotos.Visible = false;
                divfotos.Visible = false;
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }

    }
    protected void ImgEditlisting_Click(object sender, ImageClickEventArgs e)
    {
       
        if (RBInaccurate.Checked)
        {
            try
            {
                
                if (Page.RouteData.Values.Count() > 0)
                {
                    Did = Convert.ToInt32(Convert.ToString(Page.RouteData.Values["id"]));

                }
                else if (Convert.ToString(Request.QueryString["comp"]) == "View")
                {
                    Did = Convert.ToInt32(Convert.ToString(Request.QueryString["id"]));
                }
                data.pId = Did;
                data.dReportType = "incorrect";
                data.dIPAddress = data.GetNetWorkIPAddress();
                //data.dPhysicalAddress = data.GetMACAddress();
                data.dPostDate = Convert.ToDateTime(System.DateTime.Now);
                dsreport = data.Check_ReportData(data.pId, data.dReportType, data.dIPAddress);
                if (!dsreport.Tables[0].Rows.Count.Equals(0))
                {
                    lblConfirmation.Text = "You have already reported this business as incorrect.";
                    ModalPopupExtender3.Show();
                }
                else
                {
                    ModalPopupExtender1.Show();
                }
            }
            catch (Exception ex)
            {
                obj.insert_exception(ex, excep_page);
                Response.Redirect("HttpErrorPage.aspx");
            }
        }
        else if (RBEditbusins.Checked)
        {
            try
            {
                if (Page.RouteData.Values.Count() > 0)
                {
                    Did = Convert.ToInt32(Convert.ToString(Page.RouteData.Values["id"]));

                }
                else if (Convert.ToString(Request.QueryString["comp"]) == "View")
                {
                    Did = Convert.ToInt32(Convert.ToString(Request.QueryString["id"]));
                }
                //ModalPopupExtender2.Show();
                //redirect("Advertise_Edit.aspx?DID=" + id1,false);
                Response.RedirectToRoute("AdvertiseEdit", new { DID = Did });
            }
            catch (Exception ex)
            {
                obj.insert_exception(ex, excep_page);
                Response.Redirect("HttpErrorPage.aspx");
            }
            //sqlConnection.Open();
            //cmd = new SqlCommand("select module from modulesdata where id="+sid,sqlConnection);
            //SqlDataReader dr = cmd.ExecuteReader();
            //while (dr.Read())
            //{
            //    businesstype = dr["module"].ToString();
            //}
            //sqlConnection.Close();
            //if (businesstype == "FreeListing")
            //{
            //    Response.Redirect("signin.aspx?QName=FreeListing_Edit&id=" + sid);
            //}
            //else if (businesstype == "Category")
            //{
            //    Response.Redirect("signin.aspx?QName=Advertise_Edit&id=" + sid);
            //}
            //else if (businesstype == "B2B Category")
            //{
            //    Response.Redirect("signin.aspx?QName=Advertise_Edit&id=" + sid);
            //}

        }
        else if (RBLocatemap.Checked)
        {
            Map();
        }
        else if (RBBusiShutdown.Checked)
        {
            pnleditlisting.Visible = false;
            // Pnllogin.Visible = false;
            Pnlusertype.Visible = false;
            pnlreportabuse.Visible = false;
            Panel3.Visible = false;
            pnlincorrect.Visible = false;
            try
            {
                if (Page.RouteData.Values.Count() > 0)
                {
                    Did = Convert.ToInt32(Convert.ToString(Page.RouteData.Values["id"]));

                }
                else if (Convert.ToString(Request.QueryString["comp"]) == "View")
                {
                    Did = Convert.ToInt32(Convert.ToString(Request.QueryString["id"]));
                }
                data.pId = Did;
                data.dReportType = "Shutdown";
                data.dIPAddress = data.GetNetWorkIPAddress();
                //data.dPhysicalAddress = data.GetMACAddress();
                data.dPostDate = Convert.ToDateTime(System.DateTime.Now);
                dsreport = data.Check_ReportData(data.pId, data.dReportType, data.dIPAddress);
                if (!dsreport.Tables[0].Rows.Count.Equals(0))
                {
                    lblConfirmation.Text = "You have already submitted the request to report this business as shutdown.";
                    ModalPopupExtender3.Show();
                }
                else
                {
                    t = data.Report_Shutdown(data.pId, data.dIPAddress, data.dPostDate, data.dReportType);
                    if (t == true)
                    {
                        lblConfirmation.Text = "<span class=mid_menu>Thank you</span> for your inputs. We will verify and update the same.";
                        ModalPopupExtender3.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                obj.insert_exception(ex, excep_page);
                Response.Redirect("HttpErrorPage.aspx");
            }
        }
        else
        {
            //Response.Write("<script>alert('Please select atleast one option!');</script>");
            //return;
            string strScripts = "alert('Please select atleast one option');";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScripts, true);
            
        }
    }
    protected void imgsubmit_Click(object sender, ImageClickEventArgs e)
    {
        pnleditlisting.Visible = false;
        //  Pnllogin.Visible = false;
        Pnlusertype.Visible = false;
        pnlreportabuse.Visible = false;
        Panel3.Visible = false;
        pnlincorrect.Visible = false;
        try
        {
            string strscript = string.Empty;
            if (Page.RouteData.Values.Count() > 0)
            {
                Did = Convert.ToInt32(Convert.ToString(Page.RouteData.Values["id"]));

            }
            else if (Convert.ToString(Request.QueryString["comp"]) == "View")
            {
                Did = Convert.ToInt32(Convert.ToString(Request.QueryString["id"]));
            }

            data.pId = Did;
            data.dReportType = "incorrect";
            data.dIPAddress = data.GetNetWorkIPAddress();
            //data.dPhysicalAddress = data.GetMACAddress();
            data.dPostDate = Convert.ToDateTime(System.DateTime.Now);
            data.dComment = Convert.ToString(txtcmnt.Text);
            t = data.Insert_ReportIncorrect(data.pId, data.dComment, data.dReportType, data.dIPAddress, data.dPostDate);
            if (t == true)
            {
                lblConfirmation.Text = "Thank You for your inputs. We will verify and update the same.";
                ModalPopupExtender3.Show();
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    public void hallinfo(string Tname)
    {
        try
        {

            SqlDataAdapter dahall = new SqlDataAdapter("select * from Movies where CinemaHall_Name='" + Tname + "'", sqlConnection);
            DataSet dshall = new DataSet();
            dahall.Fill(dshall);
            lblmovie.Visible = true;
            dltheatredetails.Visible = true;
            dltheatredetails.DataSource = dshall;
            dltheatredetails.DataBind();
            dshall.Dispose();
            dahall.Dispose();
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void linkedit_Click(object sender, EventArgs e)
    {
        try
        {
            poprptabuse.Show();
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void sendmailcommand(object sender, EventArgs e)
    {
        try
        {
            //ModalPopupExtender.Show();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "Display();", true);

        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void btnclose1_Click(object sender, EventArgs e)
    {
        ModalPopupExtender3.Hide();
        ModalPopupExtender3.Enabled = false;
    }
    protected void Btnusertype_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            if (RBUser.Checked)
            {
                if (Page.RouteData.Values.Count() > 0)
                {

                    if (Convert.ToString(Page.RouteData.Values["id"]) != null && Convert.ToString(Page.RouteData.Values["cname"]) != null)
                    {
                        Response.Redirect("EditListing.aspx?id=" + Request.QueryString["id"].ToString() + "&cname=" + Request.QueryString["cname"].ToString() + "");
                    }

                }
                else if (Convert.ToString(Request.QueryString["comp"]) == "View")
                {
                    Response.Redirect("EditListing.aspx?id=" + Request.QueryString["id"].ToString() + "&cname=" + Request.QueryString["cname"].ToString() + "");
                }
            }
            else
            {
                Response.Write("<script>alert('U Hav selected Own!');</script>");
                return;
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void lnkreptabuse_Click(object sender, EventArgs e)
    {
        try
        {
            DataSet dsabused = new DataSet();
            if (Page.RouteData.Values.Count() > 0)
            {
                Did = Convert.ToInt32(Convert.ToString(Page.RouteData.Values["id"]));

            }
            else if (Convert.ToString(Request.QueryString["comp"]) == "View")
            {
                Did = Convert.ToInt32(Convert.ToString(Request.QueryString["id"]));
            }
            data.pId = Did;
            data.dReportType = "abuse";
            data.dIPAddress = data.GetNetWorkIPAddress();
            //data.dPhysicalAddress = data.GetMACAddress();
            data.dPostDate = Convert.ToDateTime(System.DateTime.Now);
            string format = "dd-MM-yyyy";
            string currentdate = System.DateTime.Now.ToString(format);
            dsabused = data.Check_AbusedData(data.pId, data.dReportType, data.dIPAddress, currentdate);
            if (!dsabused.Tables[0].Rows.Count.Equals(0))
            {
                lblConfirmation.Text = "<span class=mid_menu>Report Abuse !</span><br/> You have already sent abuse report for the same company today. Justcalluz Team.";
                ModalPopupExtender3.Show();
            }
            else
            {
                poprptabuse.Show();
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void dlData1_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        try
        {
            if (Page.RouteData.Values.Count() > 0)
            {
                sid = Convert.ToString(Page.RouteData.Values["id"]);

            }
            else if (Convert.ToString(Request.QueryString["comp"]) == "View")
            {
                sid = Convert.ToString(Request.QueryString["id"]);
            }

            // sqlConnection.Open();
            cmd = new SqlCommand("Select count(rid) as NumberOfUsers,sum(Stars_Rating) as Total from PostReview where dataid='" + sid + "'", sqlConnection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            float count = 0, rating = 0, result = 0;

            if (Convert.ToInt32(dt.Rows[0]["NumberOfUsers"].ToString()) != 0)
            {
                count = float.Parse(dt.Rows[0]["NumberOfUsers"].ToString());
                rating = float.Parse(dt.Rows[0]["Total"].ToString());
                result = Convert.ToInt32(Math.Ceiling((rating / count) * 18));

            }
            else
            {
            }

            HtmlGenericControl span = e.Item.FindControl("testSpan0") as HtmlGenericControl;
            if (span != null)
                span.Style.Add("width", result + "px");
            Label lblRating = (Label)e.Item.FindControl("lblratingh");
            if (lblRating != null)
                lblRating.Text = Convert.ToString(Session["RecordCount"]);

            HtmlTableRow trWebsite = (HtmlTableRow)e.Item.FindControl("trWebSite");
            if (trWebsite != null)
            {
                if (Convert.ToString(Session["WebSite"]) != "")
                {
                    trWebsite.Visible = true;
                }
                else
                {
                    trWebsite.Visible = false;
                }
            }
            HtmlTableRow trFax = (HtmlTableRow)e.Item.FindControl("trFax");
            if (trFax != null)
            {
                if (Convert.ToString(Session["Fax"]) != "")
                {
                    trFax.Visible = true;
                }
                else
                {
                    trFax.Visible = false;
                }
            }
            HtmlTableRow trComProf = (HtmlTableRow)e.Item.FindControl("trComprofile");
            if (trComProf != null)
            {
                if (Convert.ToString(Session["Company_Profile"]) != "")
                {
                    trComProf.Visible = true;
                }
                else
                {
                    trComProf.Visible = false;
                }
            }
            HtmlTableCell tdimge = (HtmlTableCell)e.Item.FindControl("tdlogo");
            Label imgname = (Label)e.Item.FindControl("lblImgName");
            if (imgname != null)
            {
                if (imgname.Text != "0")
                {
                    tdimge.Visible = true;
                }
                else
                {
                    tdimge.Visible = false;
                }
            }
            // sqlConnection.Close();
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }

    }
    public void redirect(string url, bool val)
    {
        if (!val)
        {
            HttpContext.Current.Response.Redirect(url, false);
            HttpContext.Current.ApplicationInstance.CompleteRequest();
        }
        else
        {
            HttpContext.Current.Server.ClearError();
            HttpContext.Current.Response.Redirect(url, false);
            HttpContext.Current.Server.ClearError();
        }

    }
    protected void metadata(string modname)
    {
        try
        {
            pgtitle.Text = "Get the data about " + modname + " | justcalluz";
            HtmlHead head = (HtmlHead)Page.Header;
            HtmlMeta met1 = new HtmlMeta();
            HtmlMeta met2 = new HtmlMeta();
            met1.Name = "descriptions";
            met1.Content = "we provide updated information on all your local search";
            head.Controls.Add(met1);
            Header.Controls.Add(met1);
            met2.Name = "Keywords";
            met2.Content = "Justcalluz, Real Estate Business,1BHK flat, yellow pages, online yellow pages, yellow pages india, India trade directory,  yellow pages directory, city yellow pages, indian search engine, JustCalluz customer care, JustCalluz customer support";
            head.Controls.Add(met1);
        }
        catch (Exception ex)
        {
        }
    }
    protected void upload_click(object sender, EventArgs e)
    {
        //MPERatingsLogin.Hide();
        Pnlusertype.Visible = false;
        pnlConfirm.Visible = false;
        pnlincorrect.Visible = false;
        Panel3.Visible = false;
        pnlreportabuse.Visible = false;
        pnleditlisting.Visible = false;
        // PnlMyratings.Visible = false;
        uid = Convert.ToString(Session["USERID"]);
        pwd = Convert.ToString(Session["PASSWORD"]);
        if (uid != "" && pwd != "")
        {
            DataSet ds = new DataSet();
            ds = obj1.bindlifestyle(sid);
            if (!ds.Tables[0].Rows.Count.Equals(0))
            {

                pnluploadphoto.Visible = true;
                pnlupload.Visible = false;
            }
            //Pnllogin.Visible = false;
            //Pnllogin1.Visible = false;
            //ModalPopupExtender.Hide();

        }
        else
        {

            //Pnllogin.Visible = true;
            // Pnllogin1.Visible = false;
            // ModalPopupExtender.Show();
            ClientScript.RegisterStartupScript(this.GetType(), "Show Modal Popup", "showmodalpopup1();", true);
        }

    }
    protected void lnkMyRatings_Click(object sender, EventArgs e)
    {
        // ModalPopupExtender.Hide();
        Pnlusertype.Visible = false;
        pnlConfirm.Visible = false;
        pnlincorrect.Visible = false;
        Panel3.Visible = false;
        pnlreportabuse.Visible = false;
        pnleditlisting.Visible = false;

        uid = Convert.ToString(Session["USERID"]);
        pwd = Convert.ToString(Session["PASSWORD"]);
        mobilenum = Convert.ToString(Session["Mob"]);

        if (uid != "" && pwd != "")
        {
            string myratings = "Myratings";
            BindLoginReview(uid, pwd, mobilenum, myratings);
            //Pnllogin1.Visible = false;
            //Pnllogin.Visible = false;
            //PnlMyratings.Visible = false;

        }
        else
        {
            ClientScript.RegisterStartupScript(this.GetType(), "Show Modal Popup", "showmodalpopup2();", true);

            // Pnllogin1.Visible = false;
            // Pnllogin.Visible = false;
            //PnlMyratings.Visible = true;
            // ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "xx1();", true);
        }
    }
    protected void lnkFratings_Click(object sender, EventArgs e)
    {
        // ModalPopupExtender.Hide();
        Pnlusertype.Visible = false;
        pnlConfirm.Visible = false;
        pnlincorrect.Visible = false;
        Panel3.Visible = false;
        pnlreportabuse.Visible = false;
        pnleditlisting.Visible = false;
        uid = Convert.ToString(Session["USERID"]);
        pwd = Convert.ToString(Session["PASSWORD"]);
        mobilenum = Convert.ToString(Session["Mob"]);
        if (uid != "" && pwd != "")
        {
            string friendratings = "Friendsratings";
            BindLoginReview(uid, pwd, mobilenum, friendratings);
            //Pnllogin1.Visible = false;
            //Pnllogin.Visible = false;
            // PnlMyratings.Visible = false;
            //MPERatingsLogin.Hide();
        }
        else
        {

            // Pnllogin1.Visible = true;
            //PnlMyratings.Visible = true;
            ClientScript.RegisterStartupScript(this.GetType(), "Show Modal Popup", "showmodalpopup();", true);
            // Pnllogin.Visible = false;
            // MPERatingsLogin.Show();
        }
    }

    protected void lnkAllRatings_Click(object sender, EventArgs e)
    {
        Pnlusertype.Visible = false;
        pnlConfirm.Visible = false;
        pnlincorrect.Visible = false;
        Panel3.Visible = false;
        pnlreportabuse.Visible = false;
        pnleditlisting.Visible = false;
        uid = Convert.ToString(Session["USERID"]);
        pwd = Convert.ToString(Session["PASSWORD"]);
        mobilenum = Convert.ToString(Session["Mob"]);
        if (uid != "" && pwd != "")
        {
            string friendratings = "AllRatings";
            BindLoginReview(uid, pwd, mobilenum, friendratings);
            //Pnllogin1.Visible = false;
            //Pnllogin.Visible = false;
            // PnlMyratings.Visible = false;
            //MPERatingsLogin.Hide();
        }

    }
    public string getdatafriends(string Myndfriendratings)
    {
        if (Myndfriendratings == "AllRatings")
        {
            ResultString = Convert.ToString(regid);
            ResultString += ",";

        }
        dsFriends = objtag.tag_Friends(regid);
        if (!dsFriends.Tables[0].Rows.Count.Equals(0))
        {
            for (int index = 0; index < dsFriends.Tables[0].Rows.Count; index++)
            {
                string MOBILEFRND = "";
                MOBILEFRND += Convert.ToString(dsFriends.Tables[0].Rows[index]["friend_mobile"]);
                if (dsFriends.Tables[0].Rows[index]["friend_mobile"] != "")
                {
                    //string addstring = "";

                    Listfrids.Add(objtag.tagFriends_rid(Convert.ToString(dsFriends.Tables[0].Rows[index]["friend_mobile"])));
                }
                else
                {
                    lblCurrentPage.Text = "No  Reviews  available. Be  the  first  one  to  post  review  for  this  customer.";
                    lblCurrentPage.CssClass = "sub_menu";
                    // return;
                    // strScripts = "alert('add tagyourfriends their view friendsrating ');location.replace('ViewRatings-" + sid+ "-" + Myndfriendratings + "');";
                    // Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScripts, true);

                }
            }
            for (int index1 = 0; index1 < Listfrids.Count; index1++)
            {

                if (Listfrids[index1] == "")
                {
                    continue;
                }
                else
                {

                    ResultString += Listfrids[index1] + ",";

                }
            }
            ResultString = ResultString.Substring(0, ResultString.Length - 1);

            str = "Select rid,reg_id,mob=stuff(rmob,4,5,'*****'),rname,email=stuff(remail,4,6,'****'),rating,review,ImageName,ImageContentType,Stars_Rating from PostReview where dataid='" + sid + "' and reg_id in (" + ResultString + ") order by rid desc";

        }

        else
        {
            string strScripts = "alert('add tagyourfriends their view friendsrating ');location.replace('ViewRatings-" + sid + "-" + Myndfriendratings + "');";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScripts, true);
            //return;

        }
        return str;
    }


  
}

      
        

    

    
        
       
 
                    

               


     


