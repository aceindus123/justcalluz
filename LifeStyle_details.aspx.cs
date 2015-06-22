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
using System.Web.Routing;

public partial class LifeStyle_details : System.Web.UI.Page
{
    // To make connection
    SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    SqlCommand cmd;
    private static DataTable tblData = new DataTable();
       //Creation of object for insert data class
    InsertData obj = new InsertData();
    int id;
    //Creation of object for bind data class
    Binddata obj1 = new Binddata();
    string sid = string.Empty;
    DataSet dsUserDetails = new DataSet();
    char[] separatorcomma = new char[] { ',' };
    string strScript = string.Empty;
    string VideoName;
    string VideoContentType;
    DataCS data = new DataCS();
    static string excep_page = "LifeStyle_details.aspx";
    /// <summary>
    /// Executes whenever page loads
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            //mailpanel.Visible = false;
            //friendpanel.Visible = false;
            pnluploadlogo.Visible = false;
            pnluploadphoto.Visible = false;
            // nophoto.Visible = false;
            pnlupload.Visible = false;
            pnlown.Visible = false;
            pnluploadvideo.Visible = false;
            pnlmap.Visible = false;
            MorInfo.Visible = false;
            sid = Convert.ToString(Page.RouteData.Values["id"]);
            Session["sid"] = sid;
            //Pnllogin.Visible = false;
            // page loads without post backing form values

            String[] sItems = new String[5];
            Int32[] iValue = new Int32[5];

            // Populate our variables
            sItems[0] = "Excellent";
            sqlConnection.Open();
            string q1 = "Select Count(*) from postreview where Stars_Rating='" + 5 + "'and dataid='" + sid + "'";
            cmd = new SqlCommand(q1, sqlConnection);
            iValue[0] = Convert.ToInt32(cmd.ExecuteScalar());
            sqlConnection.Close();

            sItems[1] = "Very Good";
            sqlConnection.Open();
            string q2 = "Select Count(*) from postreview where Stars_Rating='" + 4 + "'and dataid='" + sid + "'";
            cmd = new SqlCommand(q2, sqlConnection);
            iValue[1] = Convert.ToInt32(cmd.ExecuteScalar());
            sqlConnection.Close();

            sItems[2] = "Good";
            sqlConnection.Open();
            string q3 = "Select Count(*) from postreview where Stars_Rating='" + 3 + "'and dataid='" + sid + "'";
            cmd = new SqlCommand(q3, sqlConnection);
            iValue[2] = Convert.ToInt32(cmd.ExecuteScalar());
            sqlConnection.Close();

            sItems[3] = "Average";
            sqlConnection.Open();
            string q4 = "Select Count(*) from postreview where Stars_Rating='" + 2 + "'and dataid='" + sid + "'";
            cmd = new SqlCommand(q4, sqlConnection);
            iValue[3] = Convert.ToInt32(cmd.ExecuteScalar());
            sqlConnection.Close();

            sItems[4] = "Poor";
            sqlConnection.Open();
            string q5 = "Select Count(*) from postreview where Stars_Rating='" + 1 + "'and dataid='" + sid + "'";
            cmd = new SqlCommand(q5, sqlConnection);
            iValue[4] = Convert.ToInt32(cmd.ExecuteScalar());
            sqlConnection.Close();

            // Set our axis values
            overallrating.YAxisValues = iValue;

            // Set our axis strings
            overallrating.YAxisItems = sItems;
            if (!IsPostBack)
            {
                try
                {
                    contact();
                    BindReview();
                    Int16 did = Convert.ToInt16(sid);
                    tblData = data.FetchData(did);
                    if (tblData.Rows.Count > 0)
                    {
                        string imgPath = "../Photos/" + tblData.Rows[0]["PhotoName"].ToString();
                        imgShowImage.ImageUrl = imgPath;
                    }
                }
                catch (Exception ex)
                {
                    obj.insert_exception(ex, excep_page);
                    Response.Redirect("HttpErrorPage.aspx");
                }

            }

            //sqlConnection.Open();
            cmd = new SqlCommand("Select count(rid) as NumberOfUsers,sum(Stars_Rating) as Total from PostReview where dataid='" + sid + "'", sqlConnection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt1 = new DataTable();
            da.Fill(dt1);
            float count = 0, rating = 0, result = 0;
            try
            {
                if (Convert.ToInt32(dt1.Rows[0]["NumberOfUsers"].ToString()) != 0)
                {
                    count = float.Parse(dt1.Rows[0]["NumberOfUsers"].ToString());
                    rating = float.Parse(dt1.Rows[0]["Total"].ToString());
                    result = Convert.ToInt32(Math.Ceiling((rating / count) * 18));
                    //avgrating.InnerText = Math.Round((rating / count), 1).ToString();

                }
                else
                {
                    //avgrating.InnerText = "0";
                }
            }
            catch (Exception ex)
            {
                obj.insert_exception(ex, excep_page);
                Response.Redirect("HttpErrorPage.aspx");
            }
            //testSpan.Style.Add("width", result + "px");

            //userscount.InnerText = "5";

            DataSet ds = new DataSet();

            ds = obj1.bindlifestyle(sid);
            try
            {
                if (!ds.Tables[0].Rows.Count.Equals(0))
                {
                    Session["imagename"] = ds.Tables[0].Rows[0]["ImageName"].ToString();
                    dlData.DataSource = ds;
                    dlData.DataBind();
                }
                string strname = string.Empty;
                strname = Session["Cat"].ToString();
            }
            catch (Exception ex)
            {
                obj.insert_exception(ex, excep_page);
                Response.Redirect("HttpErrorPage.aspx");
            }

            //Label8.Text = strname;
            //lblCompanyname.Text = Session["CompanyName"].ToString();

            sqlConnection.Close();
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    /// <summary>
    /// To bind Reviews
    /// </summary>
    public void BindReview()
    {
        try
        {
            sqlConnection.Open();
            string Record_Count = string.Empty;
            string str = "Select rid,mob=stuff(rmob,4,5,'*****'),rname,email=stuff(remail,4,6,'****'),rating,review,ImageName,ImageContentType,Stars_Rating from PostReview where dataid='" + sid + "' order by rid desc";
            cmd = new SqlCommand(str, sqlConnection);
            DataSet dsreview = new DataSet();
            SqlDataAdapter ada = new SqlDataAdapter(str, sqlConnection);
            ada.Fill(dsreview);
            //dlReview.DataSource = dsreview;
            //dlReview.DataBind();
            PagedDataSource objPds = new PagedDataSource();
            try
            {
                if (!dsreview.Tables[0].Rows.Count.Equals(0))
                {
                    objPds.DataSource = dsreview.Tables[0].DefaultView;
                    objPds.AllowPaging = true;
                    objPds.PageSize = 11;
                    objPds.CurrentPageIndex = CurrentPage;
                    lblCurrentPage.Text = "Page: " + (CurrentPage + 1).ToString() + " of " + objPds.PageCount.ToString();
                    // Disable Prev or Next buttons if necessary
                    cmdPrev.Enabled = !objPds.IsFirstPage;
                    cmdNext.Enabled = !objPds.IsLastPage;
                    dlReview.DataKeyField = "rid";
                    dlReview.DataSource = objPds;
                    dlReview.DataBind();
                }
                else
                {
                    lblCurrentPage.Text = "No  Reviews  available. Be  the  first  one  to  post  review  for  this  customer.";
                    //trAllRatingHeading.Visible = false;
                    cmdPrev.Visible = false;
                    cmdNext.Visible = false;
                }
            }
            catch (Exception ex)
            {
                obj.insert_exception(ex, excep_page);
                Response.Redirect("HttpErrorPage.aspx");
            }

            DataSet dsCount = new DataSet();
            string str1 = "select count(*) as record_count from PostReview where dataid='" + sid + "'";
            cmd = new SqlCommand(str1, sqlConnection);
            SqlDataReader dr;

            dr = cmd.ExecuteReader();
            try
            {
                while (dr.Read())
                {
                    Record_Count = Convert.ToString(dr["Record_Count"].ToString());
                    Session["RecordCount"] = Record_Count;
                }
            }
            catch (Exception ex)
            {
                obj.insert_exception(ex, excep_page);
                Response.Redirect("HttpErrorPage.aspx");
            }
            sqlConnection.Close();

            sqlConnection.Open();
            string str2 = "select count(*) as record_count from PostReview where dataid='" + sid + "'";
            cmd = new SqlCommand(str2, sqlConnection);
            lblrating.Text = Convert.ToString(cmd.ExecuteScalar());
            // To close connection
            sqlConnection.Close();
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
    protected void cmdPrev_Click(object sender, EventArgs e)
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
    protected void cmdNext_Click(object sender, EventArgs e)
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
        //Pnllogin.Visible = false;
    }
    /// <summary>
    /// To display category data
    /// </summary>
    /// <param name="source"></param>
    /// <param name="e"></param>
    //protected void DLBindCatData_ItemCommand(object source, System.Web.UI.WebControls.DataListCommandEventArgs e)
    //{
    //    try
    //    {
    //        Session["name"] = e.CommandArgument.ToString();
    //        string name = "";
    //        name = e.CommandArgument.ToString();
    //       redirect("linkcontroller.aspx?cname=" + name + "",false);
    //    }
    //    catch (Exception ex)
    //    {
    //        obj.insert_exception(ex, excep_page);
    //        Response.Redirect("HttpErrorPage.aspx");
    //    }


    //}
    /// <summary>
    /// To display sponsored links
    /// </summary>
    /// <param name="source"></param>
    /// <param name="e"></param>
    //protected void dlsponsoredlinks_ItemCommand(object source, System.Web.UI.WebControls.DataListCommandEventArgs e)
    //{
    //    try
    //    {
    //        Session["name"] = e.CommandArgument.ToString();
    //        string name = "";
    //        name = e.CommandArgument.ToString();
    //       redirect("linkcontroller.aspx?cname=" + name + "",false);
    //    }
    //    catch (Exception ex)
    //    {
    //        obj.insert_exception(ex, excep_page);
    //        Response.Redirect("HttpErrorPage.aspx");
    //    }
    //}
    /// <summary>
    /// To send form values to sendmail
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void imggo1_Click(object sender, EventArgs e)
    {
        try
        {
            //if (Session["USERID"] != null)
            //{

            string NameToSend = txtname.Text;
            string EmailToSend = txtSEmail.Text;
            string PhoneToSend = txtmob.Text;
            //SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
            //sqlConnection.Open();
            SqlDataAdapter imgtext = new SqlDataAdapter("select * from ModulesData where id='" + sid + "'", sqlConnection);
            imgtext.Fill(dsUserDetails, "Registration");
            string CompanyName = string.Empty;
            string ContactPerson = string.Empty;
            string Address = string.Empty;
            string LandMark = string.Empty;
            string Mobile = string.Empty;
            string Email = string.Empty;
            string Phone = string.Empty;
            try
            {
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
            }
            catch (Exception ex)
            {
                obj.insert_exception(ex, excep_page);
                Response.Redirect("HttpErrorPage.aspx");
            }
           // sqlConnection.Close();
            
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
            SendMail(NameToSend, EmailToSend, PhoneToSend, CompanyName, ContactPerson, Address, LandMark, Email, Mobile, Phone);

            strScript = "alert('Your Mail is Sent Successfully.');";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
            txtSEmail.Text = "";
            txtmob.Text = "";
            txtname.Text = "";

        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
        //else
        //{
        //    string strScript = "";
        //    strScript = "alert('Inorder to send mail/sms you need to login.');";
        //    Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
        //}
    
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
        string Msg = "";
        try
        {
            

            try
            {
                MailMessage mm = new MailMessage();
                mm.From = new MailAddress("info@justcalluz.com");
                mm.To.Add(EmailToSend);
                Msg += "Dear <b>" + NameToSend + "</b> ," +
                            "<br>Please find below the information you had requested:<br>" +
                            "<br>Whenever you call please mention that you got this info from Justcalluz.com" +
                            "<br><br><a href=http://www.justcalluz.com/sessionstore.aspx?id=" + sid + ">" + CompanyName + "</a>" + "</b> " +
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
                mm.Body = Msg;
                SmtpClient smtp = new SmtpClient();
                smtp.Send(mm);


            }
            catch (Exception ex1)
            {
                obj.insert_exception(ex1, excep_page);
                Response.Redirect("HttpErrorPage.aspx");
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }

    public void SendMail1(string name, string fname, string email)
    {
        string Msg = "";
        try
        {
            

            try
            {
                MailMessage mm = new MailMessage();
                mm.From = new MailAddress("info@justcalluz.com");
                //mm.To = "test_indus@yahoo.com";
                mm.To.Add(email);
                Msg += "Dear <b>" + fname + "</b> ," +

                            "<br>Your Friend " + name + "</b>," +
                            "<br> Suggested you to get through the site Justcalluz.com or dial 99166136226." +
                            "<br>To get an information regarding jobs,Real estates,discounts,events,Restaurents,Movies etc.," +
                            "<br>what not ? all within seconds" +

                            "<br><br> JustCalluz is a fastest growing local search engine, operating from Hyderabad, India.A JustCalluz visitor can get the desired business information instantly by selecting a location name from the given options and enter the search keyword in the search option." +
                            "<br><br>JustCalluz works 24/7 to find innovative ways and make local search much easier & simpler, we welcome people with creative ideas and zeal to learn & develop." +


                            "<br><br>Warm Regards," +
                            "<br> Team JustCalluz";
                mm.Subject = "suggestion of your friend";
                mm.IsBodyHtml = true;
                mm.Body = Msg;
                SmtpClient smtp = new SmtpClient();
                smtp.Send(mm);
            }
            catch (Exception ex1)
            {
                obj.insert_exception(ex1, excep_page);
                Response.Redirect("HttpErrorPage.aspx");
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }


    protected void imggo_Click(object sender, EventArgs e)
    {
        try
        {

            string name = txtname1.Text;
            string fname = txtfname.Text;
            string email = txtFEmail.Text;
            SendMail1(name, fname, email);
            string strScript = string.Empty;
            strScript = "alert('Thank you! You have successfully shared with your friend.');location.replace('LifeStyle-LifeStyle-" + "" + "');";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
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
    //    try
    //    {
    //        redirect("linkcontroller.aspx?cname=" + Session["Cat"].ToString(),false);
    //    }
    //    catch (Exception ex)
    //    {
    //        obj.insert_exception(ex, excep_page);
    //        Response.Redirect("HttpErrorPage.aspx");
    //    }
    //}
    /// <summary>
    /// To post review
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    //protected void ImgBtnPostReview_Click(object sender, ImageClickEventArgs e)
    //{
    //    try
    //    {
    //        sid = (Request.QueryString["id"].ToString());
    //        redirect("PostReviewCat.aspx?DataId=" + sid,false);
    //    }
    //    catch (Exception ex)
    //    {
    //        obj.insert_exception(ex, excep_page);
    //        Response.Redirect("HttpErrorPage.aspx");
    //    }
    //}
    /// <summary>
    /// To bound review data info
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void dlData_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        string logo = Session["imagename"].ToString();
       // SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
        //con.Open();
        cmd = new SqlCommand("Select count(rid) as NumberOfUsers,sum(Stars_Rating) as Total from PostReview where dataid='" + sid + "'", sqlConnection);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataTable dt1 = new DataTable();
        da.Fill(dt1);
        float count = 0, rating = 0, result = 0;
        try
        {
            if (Convert.ToInt32(dt1.Rows[0]["NumberOfUsers"].ToString()) != 0)
            {
                count = float.Parse(dt1.Rows[0]["NumberOfUsers"].ToString());
                rating = float.Parse(dt1.Rows[0]["Total"].ToString());
                result = Convert.ToInt32(Math.Ceiling((rating / count) * 18));

            }
            else
            {
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
        HtmlTableCell imglogo = (HtmlTableCell)e.Item.FindControl("tdlogo");
        if (imglogo != null)
        {
            try
            {
                if (logo == "0")
                {
                    imglogo.Visible = false;
                }
                else
                {
                    imglogo.Visible = true;
                }
            }
            catch (Exception ex)
            {
                obj.insert_exception(ex, excep_page);
                Response.Redirect("HttpErrorPage.aspx");
            }
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
            try
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
            catch (Exception ex)
            {
                obj.insert_exception(ex, excep_page);
                Response.Redirect("HttpErrorPage.aspx");
            }
        }
        HtmlTableRow trFax = (HtmlTableRow)e.Item.FindControl("trFax");
        if (trFax != null)
        {
            try
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
            catch (Exception ex)
            {
                obj.insert_exception(ex, excep_page);
                Response.Redirect("HttpErrorPage.aspx");
            }
        }
        HtmlTableRow trComProf = (HtmlTableRow)e.Item.FindControl("trComprofile");
        if (trComProf != null)
        {
            try
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
            catch (Exception ex)
            {
                obj.insert_exception(ex, excep_page);
                Response.Redirect("HttpErrorPage.aspx");
            }
        }
       // con.Close();

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

    
    protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
    {
        try
        {
            sid = Convert.ToString(Page.RouteData.Values["id"].ToString());
            dlData.Visible = false;
            if (logindetails(Login1.UserName, Login1.Password))
            {
                DataSet ds = new DataSet();
                ds = obj1.bindlifestyle(sid);
                if (!ds.Tables[0].Rows.Count.Equals(0))
                {
                    if (Login1.UserName == ds.Tables[0].Rows[0]["UserLoginId"].ToString())
                    {

                        //pnluploadphoto.Visible = true;
                    }
                    else
                    {
                        strScript = "alert('Sorry! You are not the authorized user to view or upload photos .');location.replace('LifeStyle');";
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                    }

                }
                else
                {
                    pnlupload.Visible = false;
                }
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }

    }

    private bool logindetails(string UserName, string PassWord)
    {
        bool logedin = false;
        try
        {
            //sqlConnection.Open();
           
            cmd = new SqlCommand("select email,password,iStatus from register where iStatus=1", sqlConnection);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ad.Fill(dsUserDetails, "register");
            if (!dsUserDetails.Tables[0].Rows.Count.Equals(0))
            {
                foreach (DataRow dr in dsUserDetails.Tables[0].Rows)
                {
                    for (int i = 0; i < dsUserDetails.Tables[0].Rows.Count; i++)
                    {
                        if ((UserName == dr["email"].ToString() && (PassWord == dr["password"].ToString())))
                        {
                            logedin = true;
                            break;
                        }

                    }
                }

                if (logedin == false)
                {
                    strScript = "alert('Sorry! Invalid Credentials.');location.replace('LifeStyle');";
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                    Pnllogin.Visible = false;
                }
                return logedin;

            }
            
            sqlConnection.Close();
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
        return logedin;
       
    }
    protected void lnkBtnMoreInfo_Click(object sender, EventArgs e)
    {
        try
        {
            dlData.Visible = false;
            MorInfo.Visible = true;
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
            Pnllogin.Visible = false;
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
            //sqlConnection.Open();
            string query = "select * from AddMoreInfo where dataid=" + sid;
            SqlDataAdapter adaMoreInfo = new SqlDataAdapter(query, sqlConnection);
            DataSet dsMoreInfo = new DataSet();
            adaMoreInfo.Fill(dsMoreInfo);
            if (!dsMoreInfo.Tables[0].Rows.Count.Equals(0))
            {
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
                lblpayment.Text = Payment;
                if (Monday == "Time Duration")
                {
                    try
                    {
                        string[] strMonArr = MonDur.Split(separatorcomma);
                        foreach (string arrstrrMon in strMonArr)
                        {
                            lblMonday.Text += arrstrrMon + "<br />";
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
                    lblMonday.Text = Monday;
                }
                if (Tuesday == "Time Duration")
                {
                    try
                    {
                        string[] strTuesArr = TuesDur.Split(separatorcomma);
                        foreach (string arrstrrTues in strTuesArr)
                        {
                            lblTuesday.Text += arrstrrTues + "<br />";
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
                    lblTuesday.Text = Tuesday;
                }
                if (Wednesday == "Time Duration")
                {
                    try
                    {
                        string[] strWedArr = WedDur.Split(separatorcomma);
                        foreach (string arrstrrWed in strWedArr)
                        {
                            lblWednesday.Text += arrstrrWed + "<br />";
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
                    lblWednesday.Text = Wednesday;
                }
                if (Thursday == "Time Duration")
                {
                    try
                    {
                        string[] strThursArr = ThursDur.Split(separatorcomma);
                        foreach (string arrstrrThurs in strThursArr)
                        {
                            lblThursday.Text += arrstrrThurs + "<br />";
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
                    lblThursday.Text = Thursday;
                }
                if (Friday == "Time Duration")
                {
                    try
                    {
                        string[] strFriArr = FriDur.Split(separatorcomma);
                        foreach (string arrstrrFri in strFriArr)
                        {
                            lblFriday.Text += arrstrrFri + "<br />";
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
                    lblFriday.Text = Friday;
                }
                if (Satday == "Time Duration")
                {
                    try
                    {
                        string[] strSatArr = SatDur.Split(separatorcomma);
                        foreach (string arrstrrSat in strSatArr)
                        {
                            lblSaturday.Text += arrstrrSat + "<br />";
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
                    lblSaturday.Text = Satday;
                }
                if (Sunday == "Time Duration")
                {
                    try
                    {
                        string[] strSunArr = SunDur.Split(separatorcomma);
                        foreach (string arrstrrSun in strSunArr)
                        {
                            lblSunday.Text += arrstrrSun + "<br />";
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
                    lblSunday.Text = Sunday;
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
    protected void lnkphoto_Click(object sender, EventArgs e)
    {
        try
        {
            mailpanel.Visible = false;
            friendpanel.Visible = false;
            dlData.Visible = false;

            pnlupload.Visible = true;
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
   }
    protected void imgphoto_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            photo();
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void imgcancel_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            pnluploadphoto.Visible = false;
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }

    protected void lnkcnt_Click(object sender, EventArgs e)
    {
        try
        {
            contact();
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    public void contact()
    {
        try
        {
            
            dlData.Visible = true;
            SqlDataAdapter imgtext = new SqlDataAdapter("select * from ModulesData where id='" + sid + "'", sqlConnection);
            imgtext.Fill(dsUserDetails, "Registration");

            if (!dsUserDetails.Tables[0].Rows.Count.Equals(0))
            {
                Session["CompanyName"] = dsUserDetails.Tables[0].Rows[0]["company_name"].ToString();
                Session["WebSite"] = dsUserDetails.Tables[0].Rows[0]["Website"].ToString();
                Session["Fax"] = dsUserDetails.Tables[0].Rows[0]["fax"].ToString();
                Session["Company_Profile"] = dsUserDetails.Tables[0].Rows[0]["company_profile"].ToString();
                Session["Cat"] = dsUserDetails.Tables[0].Rows[0]["Category"].ToString();

            }
           
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void LoginButton_Click(object sender, EventArgs e)
    {
        try
        {
            pnluploadphoto.Visible = true;
            pnluploadphoto.Visible = true;
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void btnown_Click(object sender, EventArgs e)
    {
        try
        {
            pnlown.Visible = true;
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void photo()
    {
        try
        {
            mailpanel.Visible = false;
            friendpanel.Visible = false;
            sid = Convert.ToString(Page.RouteData.Values["id"]);
            SqlDataAdapter daphoto = new SqlDataAdapter("select count(dataid) as count from photos where dataid=" + sid, sqlConnection);
            DataSet dsphoto = new DataSet();
            daphoto.Fill(dsphoto);
            int count = Convert.ToInt32(dsphoto.Tables[0].Rows[0]["count"]);
            if (count < 5)
            {
                SqlCommand cmd = new SqlCommand("insert into photos(PhotoName,PhotoContentType,dataid) values(@PhotoName,@PhotoContentType,@dataid)", sqlConnection);
                if (photoupload.HasFile)
                {
                    if (photoupload.PostedFile.ContentLength <= 100000)
                    {
                        string filename = System.IO.Path.GetFileName(photoupload.PostedFile.FileName);
                        string contenttype = photoupload.PostedFile.ContentType;
                        photoupload.PostedFile.SaveAs(Server.MapPath("../Photos/" + filename));
                        using (System.Drawing.Image Img = System.Drawing.Image.FromFile(Server.MapPath("../Photos/" + filename)))
                        {
                            try
                            {

                                if (Img.Width <= 250 && Img.Height <= 300)
                                {
                                    cmd.Parameters.AddWithValue("@PhotoName", filename);
                                    cmd.Parameters.AddWithValue("@PhotoContentType", contenttype);
                                    cmd.Parameters.AddWithValue("dataid", SqlDbType.Int).Value = sid;
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
                                        sqlConnection.Close();
                                    }

                                    strScript = "alert('Thank you ! You have successfully uploadedthe photo');";
                                    Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                                    
                                }
                                else
                                {
                                    strScript = "alert('sorry! Specified photo cannot be uploaded , make sure that width=250 and height=300.');";
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
                        strScript = "alert('sorry! Specified photo cannot be uploaded , make sure that size is lessthan 100kb.');";
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                    }
                }
            }
            else
            {
                strScript = "alert('sorry! You can upload only five photos . so , kindly delete some existing photos inorder to upload new photos');";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
            }
           // sqlConnection.Close();
            mailpanel.Visible = false;
            friendpanel.Visible = false;
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }

    protected void imgownphoto_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            pnluploadphoto.Visible = true;
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void imglogo_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            pnluploadlogo.Visible = true;
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
        
    }
    protected void btnuploadlogo_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            //sqlConnection.Open();
            sid = Convert.ToString(Page.RouteData.Values["id"]);

            SqlCommand cmd = new SqlCommand("update modulesdata set ImageName=@ImageName,ImagecontentType=@ImageContentType where id='" + sid + "'", sqlConnection);
            if (uploadLogo.HasFile)
            {
                if (uploadLogo.PostedFile.ContentLength <= 30000)
                {
                    string filename = System.IO.Path.GetFileName(uploadLogo.PostedFile.FileName);
                    string contenttype = uploadLogo.PostedFile.ContentType;
                    uploadLogo.PostedFile.SaveAs(Server.MapPath("Logos/" + filename));
                    using (System.Drawing.Image Img = System.Drawing.Image.FromFile(Server.MapPath("Logos/" + filename)))
                    {
                        try
                        {

                            if (Img.Width <= 100 && Img.Height <= 75)
                            {
                                cmd.Parameters.AddWithValue("@ImageName", filename);
                                cmd.Parameters.AddWithValue("@ImageContentType", contenttype);
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
                                strScript = "alert('Thank You! You have successfully uploaded the logo .');";
                                Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                            }
                            else
                            {
                                strScript = "alert('sorry! Secified Logo can't be uploaded , make sure that width=100 and height=75.');";
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
                    strScript = "alert('sorry! Secified Logo can't be uploaded , make sure that size is lessthan 30kb.');";
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                }
            }
            else
            {
                cmd.Parameters.AddWithValue("@ImageName", SqlDbType.NVarChar).Value = "Null";
                cmd.Parameters.AddWithValue("@ImageContentType", SqlDbType.NVarChar).Value = "Null";
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
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }

    protected void uploadvideo_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            pnluploadvideo.Visible = true;
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void btnvideo_Click(object sender, ImageClickEventArgs e)
    {
        try
        {

           // sqlConnection.Open();

            if (uploadVideos.HasFile)
            {
                string fileExt = System.IO.Path.GetExtension(uploadVideos.FileName);

                //if (fileExt == ".avi")
                //{
                try
                {
                    sid = (Request.QueryString["id"].ToString());
                    //sqlConnection.Open();
                    //SqlCommand cmd = new SqlCommand("update vedios set VedioName=@VideoName,@VedioContentType=@VedioContentType where dataid='" + sid + "'", sqlConnection);
                    //SqlCommand cmd = new SqlCommand("insert into vedios(VedioName,VedioContentType,dataid) values(@VedioName,@VedioContentType,@dataid)", sqlConnection);
                    SqlCommand cmd = new SqlCommand("InsertVideos", sqlConnection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    if (uploadVideos.HasFile)
                    {
                        VideoName = System.IO.Path.GetFileName(uploadVideos.PostedFile.FileName);
                        uploadVideos.PostedFile.SaveAs(Server.MapPath("../Videos/" + VideoName));
                        VideoContentType = uploadVideos.PostedFile.ContentType;
                        cmd.Parameters.AddWithValue("VideoName", VideoName);
                        cmd.Parameters.AddWithValue("VideoContType", VideoContentType);
                        cmd.Parameters.AddWithValue("did", sid);
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
                        strScript = "alert('Thank You! You have successfully uploaded the Video .');";
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                    }
                    else
                    {
                        strScript = "alert('Please select the video .');";
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                       // sqlConnection.Close();
                    }

                }
                catch (Exception ex)
                {
                    //lblException.Text = "ERROR: " + ex.Message.ToString();
                }
                //}
                //else
                //{
                //    lblException.Text = "Only .avi files allowed!";
                //}
            }
            else
            {
                Label1.Text = "You have not specified a file.";
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }

    
    [System.Web.Services.WebMethod]
    [System.Web.Script.Services.ScriptMethod]
    public static AjaxControlToolkit.Slide[] GetSlides()
    {
        AjaxControlToolkit.Slide[] slides = new AjaxControlToolkit.Slide[tblData.Rows.Count];

        for (int i = 0; i < tblData.Rows.Count; i++)
        {
            DataRow dr = tblData.Rows[i];
        
            slides[i] = new AjaxControlToolkit.Slide("Photos/" + dr["PhotoName"].ToString(), "ImageName", dr["PhotoName"].ToString());
        }
        return slides;
    }


    protected void lnkmap_Click(object sender, EventArgs e)
    {
        try
        {
            dlData.Visible = false;
            pnlmap.Visible = true;
            sid = Convert.ToString(Page.RouteData.Values["id"]);
            SqlDataAdapter mapadapter = new SqlDataAdapter("select id,map,Approved_map from modulesdata where id='" + sid + "' and Approved_map=1", sqlConnection);
            DataSet dsmap = new DataSet();
            mapadapter.Fill(dsmap);
            if (!dsmap.Tables[0].Rows.Count.Equals(0))
            {
                dlmap.Visible = true;
                dlmap.DataSource = dsmap;
                dlmap.DataBind();
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
                 
            
    }
    protected void lnkedit_Click(object sender, EventArgs e)
    {
        try
        {
            int id = Convert.ToInt32(Session["sid"]);
            //redirect("edit_LifeStyle.aspx?id=" + id,false);
            Response.RedirectToRoute("editlife", new { id = id, cname = "LifeStyle" });
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
}



