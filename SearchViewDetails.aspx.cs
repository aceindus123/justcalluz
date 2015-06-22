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
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
/// <summary>
/// Class to view details of search results
/// </summary>
public partial class SearchViewDetails : System.Web.UI.Page
{
    //To make connection
    SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    // To create object for insert data class
    InsertData obj1 = new InsertData();
    int id;
    // To create object for bind data class
    Binddata obj = new Binddata();
    string sid = string.Empty;
    DataSet dsDataDetails = new DataSet();
    /// <summary>
    /// Executes the when ever page loads
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Page_Load(object sender, EventArgs e)
    {
        sid = (Request.QueryString["id"].ToString());
        // Page loads without post backing the values
        if (!IsPostBack)
        {
            SqlDataAdapter imgtext = new SqlDataAdapter("select * from ModulesData where id='" + sid + "'", sqlConnection);
            //To fill the dataset
            imgtext.Fill(dsDataDetails, "Data");
            // To get the values from dataset and assigned them to strings
            if (!dsDataDetails.Tables[0].Rows.Count.Equals(0))
            {

                lblCompName.Text = dsDataDetails.Tables[0].Rows[0]["company_name"].ToString();
                lblCompProfile.Text = dsDataDetails.Tables[0].Rows[0]["company_profile"].ToString();
                lblInd.Text = dsDataDetails.Tables[0].Rows[0]["job_industry"].ToString();
                lblFunArea.Text = dsDataDetails.Tables[0].Rows[0]["job_functional_area"].ToString();
                lblRole.Text = dsDataDetails.Tables[0].Rows[0]["job_role"].ToString();
                lblQual.Text = dsDataDetails.Tables[0].Rows[0]["job_Qualification"].ToString();
                lblExp.Text = dsDataDetails.Tables[0].Rows[0]["job_exp"].ToString();
                lblSal.Text = dsDataDetails.Tables[0].Rows[0]["job_sal"].ToString();
                lblKeyskill.Text = dsDataDetails.Tables[0].Rows[0]["job_keyskills"].ToString();
                lblJobDesc.Text = dsDataDetails.Tables[0].Rows[0]["job_desc"].ToString();
                lblEvePlace.Text = dsDataDetails.Tables[0].Rows[0]["event_place"].ToString();
                lblEventName.Text = dsDataDetails.Tables[0].Rows[0]["event_name"].ToString();
                lblEveDesc.Text = dsDataDetails.Tables[0].Rows[0]["event_desc"].ToString();
                lblEventDate.Text = dsDataDetails.Tables[0].Rows[0]["event_startdate"].ToString();
                lblEveStartDate.Text = dsDataDetails.Tables[0].Rows[0]["event_startdate"].ToString();
                lblEveEndDate.Text = dsDataDetails.Tables[0].Rows[0]["event_enddate"].ToString();
                lblEveTime.Text = dsDataDetails.Tables[0].Rows[0]["event_time"].ToString();
                lblDisDate.Text = dsDataDetails.Tables[0].Rows[0]["event_startdate"].ToString();
                lblDisDesc.Text = dsDataDetails.Tables[0].Rows[0]["event_desc"].ToString();
                lblDisEndDate.Text = dsDataDetails.Tables[0].Rows[0]["event_startdate"].ToString();
                lblDisStartDate.Text = dsDataDetails.Tables[0].Rows[0]["event_enddate"].ToString();
                lblDisTime.Text = dsDataDetails.Tables[0].Rows[0]["event_time"].ToString();
                lblContPerson.Text = dsDataDetails.Tables[0].Rows[0]["contact_person"].ToString();
                lblEmail.Text = dsDataDetails.Tables[0].Rows[0]["emailid"].ToString();
                lblLandPhone.Text = dsDataDetails.Tables[0].Rows[0]["landphno"].ToString();
                lblMob.Text = dsDataDetails.Tables[0].Rows[0]["mob"].ToString();
                lblState.Text = dsDataDetails.Tables[0].Rows[0]["State"].ToString();
                lblAddress.Text = dsDataDetails.Tables[0].Rows[0]["address"].ToString();
                lblFax.Text = dsDataDetails.Tables[0].Rows[0]["fax"].ToString();
                Session["EventName"] = lblEventName.Text;
                Session["CompanyName"] = lblCompName.Text;
                Session["CatName"] = dsDataDetails.Tables[0].Rows[0]["Category"].ToString();
                Session["Module"] = dsDataDetails.Tables[0].Rows[0]["module"].ToString();
                Session["TypeofDuration"] = dsDataDetails.Tables[0].Rows[0]["evedi_DurationType"].ToString();
                //if(Address.Text=="")
                //Address.Text = lblAddress.Text;
                Session["AddressMap"] = dsDataDetails.Tables[0].Rows[0]["address"].ToString(); ;

            }
            Label8.Text = Session["CatName"].ToString();

            if (Convert.ToString(Session["CompanyName"]) == "")
            {
                lblCompanyname.Text = Session["EventName"].ToString();
            }
            else
            {
                lblCompanyname.Text = Session["CompanyName"].ToString();
            }

            string cat = Convert.ToString(Session["CatName"]);
            string mod = Convert.ToString(Session["Module"]);
            string durType = Convert.ToString(Session["TypeofDuration"]);

            if (mod == "Category")
            {
                trCompName.Visible = true;
                trComProfile.Visible = true;
                trIndustry.Visible = false;
                trFunArea.Visible = false;
                trRole.Visible = false;
                trQual.Visible = false;
                trJobExp.Visible = false;
                trSal.Visible = false;
                trKeySkills.Visible = false;
                trJobDesc.Visible = false;
                trEventName.Visible = false;
                trEvePlace.Visible = false;
                trEventDate.Visible = false;
                trEveStartDate.Visible = false;
                trEveEndDate.Visible = false;
                trEventDesc.Visible = false;
                trEveTime.Visible = false;
                trDisDesc.Visible = false;
                trDisDate.Visible = false;
                trDisStartDate.Visible = false;
                trDisEndDate.Visible = false;
                trDisTime.Visible = false;
                trContPerson.Visible = true;
                trAddress.Visible = true;
                trState.Visible = true;
                trEmail.Visible = true;
                trFax.Visible = true;
                trSendMail.Visible = true;
                Panel2.Visible = true;
                Panel3.Visible = true;
               
            }
            else if (mod == "Discounts")
            {
                trCompName.Visible = true;
                trComProfile.Visible = true;
                trIndustry.Visible = false;
                trFunArea.Visible = false;
                trRole.Visible = false;
                trQual.Visible = false;
                trJobExp.Visible = false;
                trSal.Visible = false;
                trKeySkills.Visible = false;
                trJobDesc.Visible = false;
                trEventName.Visible = false;
                trEvePlace.Visible = false;
                trEventDate.Visible = false;
                trEveStartDate.Visible = false;
                trEveEndDate.Visible = false;
                trEventDesc.Visible = false;
                trEveTime.Visible = false;
                trDisDesc.Visible = true;
                if (durType == "One Day Event")
                {
                    trDisDate.Visible = true;
                    trDisStartDate.Visible = false;
                    trDisEndDate.Visible = false;
                }
                if (durType == "Multi Day Event")
                {
                    trDisDate.Visible = false;
                    trDisStartDate.Visible = true;
                    trDisEndDate.Visible = true;
                }
                trDisTime.Visible = true;
                trContPerson.Visible = true;
                trAddress.Visible = true;
                trState.Visible = true;
                trEmail.Visible = true;
                trFax.Visible = true;
                trSendMail.Visible = false;
                Panel3.Visible = false;
                Panel2.Visible = false;
              
            }
            else if (mod == "Events")
            {
                trCompName.Visible = false;
                trComProfile.Visible = false;
                trIndustry.Visible = false;
                trFunArea.Visible = false;
                trRole.Visible = false;
                trQual.Visible = false;
                trJobExp.Visible = false;
                trSal.Visible = false;
                trKeySkills.Visible = false;
                trJobDesc.Visible = false;
                trEventName.Visible = true;
                trEvePlace.Visible = true;
                if (durType == "One Day Event")
                {
                    trEventDate.Visible = true;
                    trEveStartDate.Visible = false;
                    trEveEndDate.Visible = false;
                }
                if (durType == "Multi Day Event")
                {
                    trEventDate.Visible = false;
                    trEveStartDate.Visible = true;
                    trEveEndDate.Visible = true;
                }
                trEventDesc.Visible = true;
                trEveTime.Visible = true;
                trDisDesc.Visible = false;
                trDisDate.Visible = false;
                trDisStartDate.Visible = false;
                trDisEndDate.Visible = false;
                trDisTime.Visible = false;
                trContPerson.Visible = true;
                trAddress.Visible = true;
                trState.Visible = true;
                trEmail.Visible = true;
                trFax.Visible = true;
                trSendMail.Visible = false;
                Panel3.Visible = false;
                Panel2.Visible = false;
              
            }
            else if (mod == "Jobs")
            {
                trCompName.Visible = true;
                trComProfile.Visible = true;
                trIndustry.Visible = true;
                trFunArea.Visible = true;
                trRole.Visible = true;
                trQual.Visible = true;
                trJobExp.Visible = true;
                trSal.Visible = true;
                trKeySkills.Visible = true;
                trJobDesc.Visible = true;
                trEventName.Visible = false;
                trEvePlace.Visible = false;
                trEventDate.Visible = false;
                trEveStartDate.Visible = false;
                trEveEndDate.Visible = false;
                trEventDesc.Visible = false;
                trEveTime.Visible = false;
                trDisDesc.Visible = false;
                trDisDate.Visible = false;
                trDisStartDate.Visible = false;
                trDisEndDate.Visible = false;
                trDisTime.Visible = false;
                trContPerson.Visible = true;
                trAddress.Visible = true;
                trState.Visible = true;
                trEmail.Visible = true;
                trFax.Visible = true;
                trSendMail.Visible = false;
                Panel3.Visible = false;
                Panel2.Visible = false;
               
            }
            BindReview();

        }

        SqlCommand cmd = new SqlCommand("Select count(rid) as NumberOfUsers,sum(Stars_Rating) as Total from PostReview where dataid='" + sid + "'", sqlConnection);
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
        testSpan.Style.Add("width", result + "px");
        //testSpan1.Style.Add("width", result + "px");
        //userscount.InnerText = "5";

        DataSet ds = new DataSet();

        DLBindCatData.Visible = true;
        DataSet ds1 = new DataSet();
        ds1 = obj1.bindcategory();
        DLBindCatData.DataSource = ds1;
        DLBindCatData.DataBind();

        //dlsponsoredlinks.Visible = true;
        //DataSet ds2 = new DataSet();
        //ds2 = obj1.bindsponseredlinks();
        //dlsponsoredlinks.DataSource = ds2;
        //dlsponsoredlinks.DataBind();


        //strname = Session["name"].ToString();

        sqlConnection.Close();


    }
    /// <summary>
    /// To bind the review
    /// </summary>
    public void BindReview()
    {
        sqlConnection.Open();
        string Record_Count = string.Empty;
        string str = "Select rid,mob=stuff(rmob,4,5,'*****'),rname,email=stuff(remail,4,6,'****'),rating,review,ImageName,ImageContentType,Stars_Rating from PostReview where dataid='" + sid + "' order by rid desc";
        SqlCommand cmd = new SqlCommand(str, sqlConnection);
        DataSet dsreview = new DataSet();
        SqlDataAdapter ada = new SqlDataAdapter(str, sqlConnection);
        ada.Fill(dsreview);
        int rating1 = 0;
        DataTable dt = new DataTable();
        ada.Fill(dt);
        PagedDataSource objPds = new PagedDataSource();
        if (!dsreview.Tables[0].Rows.Count.Equals(0))
        {
            objPds.DataSource = dsreview.Tables[0].DefaultView;
            objPds.AllowPaging = true;
            objPds.PageSize = 3;
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
            trAllRatingHeading.Visible = false;
            cmdPrev.Visible = false;
            cmdNext.Visible = false;
        }

        DataSet dsCount = new DataSet();
        string str1 = "select count(*) as record_count from PostReview where dataid='" + sid + "'";
        SqlCommand cmd1 = new SqlCommand(str1, sqlConnection);
        SqlDataReader dr;

        dr = cmd1.ExecuteReader();
        while (dr.Read())
        {
            Record_Count = Convert.ToString(dr["Record_Count"].ToString());

        }
        lblrating.Text = Record_Count;
        //lblratingh.Text = Record_Count;
        sqlConnection.Close();
    }
    /// <summary>
    /// To go prevous page
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void cmdPrev_Click(object sender, EventArgs e)
    {
        CurrentPage -= 1;
        BindReview();
    }
    /// <summary>
    /// To go next page
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void cmdNext_Click(object sender, EventArgs e)
    {
        CurrentPage += 1;
        BindReview();
    }
    /// <summary>
    /// To know current page
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
    /// <summary>
    /// To cancel send sms
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnXSendSMS_Click(object sender, EventArgs e)
    {
        Panel3.Visible = false;
    }
    /// <summary>
    /// To display category data
    /// </summary>
    /// <param name="source"></param>
    /// <param name="e"></param>
    protected void DLBindCatData_ItemCommand(object source, System.Web.UI.WebControls.DataListCommandEventArgs e)
    {
        Session["name"] = e.CommandArgument.ToString();
        string name = "";
        name = e.CommandArgument.ToString();
        Response.Redirect("linkcontroller.aspx?cname=" + name + "");

    }
    /// <summary>
    /// To display sponsored links data
    /// </summary>
    /// <param name="source"></param>
    /// <param name="e"></param>
    protected void dlsponsoredlinks_ItemCommand(object source, System.Web.UI.WebControls.DataListCommandEventArgs e)
    {
        Session["name"] = e.CommandArgument.ToString();
        string name = "";
        name = e.CommandArgument.ToString();
        Response.Redirect("linkcontroller.aspx?cname=" + name + "");


    }
    /// <summary>
    /// To send search details to a mail id
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void submitbuttonMail_Click(object sender, EventArgs e)
    {
        if (Session["USERID"] != null)
        {
            string NameToSend = txtnameToSend.Text;
            string EmailToSend = txtemailToSend.Text;
            string PhoneToSend = txtmobToSend.Text;
            SqlDataAdapter imgtext = new SqlDataAdapter("select * from ModulesData where id='" + sid + "'", sqlConnection);
            imgtext.Fill(dsDataDetails, "SearchData");
            string CompanyName = string.Empty;
            string CompanyProfile = string.Empty;
            string Ind = string.Empty;
            string FunArea = string.Empty;
            string Role = string.Empty;
            string Qual = string.Empty;
            string Exp = string.Empty;
            string Sal = string.Empty;
            string KeySkills = string.Empty;
            string JobDesc = string.Empty;
            string EvePlace = string.Empty;
            string EveName = string.Empty;
            string EveDiDesc = string.Empty;
            string EveDiStartDate = string.Empty;
            string EveDiEndDate = string.Empty;
            string EveDiTime = string.Empty;
            string ContactPerson = string.Empty;
            string Address = string.Empty;
            string LandMark = string.Empty;
            string State = string.Empty;
            string Mobile = string.Empty;
            string Email = string.Empty;
            string Phone = string.Empty;
            string Fax = string.Empty;
            string Cat = string.Empty;
            string mod = string.Empty;
            string durType = string.Empty;

            if (!dsDataDetails.Tables[0].Rows.Count.Equals(0))
            {
                CompanyName = dsDataDetails.Tables[0].Rows[0]["company_name"].ToString();
                CompanyProfile = dsDataDetails.Tables[0].Rows[0]["company_profile"].ToString();
                Ind = dsDataDetails.Tables[0].Rows[0]["job_industry"].ToString();
                FunArea = dsDataDetails.Tables[0].Rows[0]["job_functional_area"].ToString();
                Role = dsDataDetails.Tables[0].Rows[0]["job_role"].ToString();
                Qual = dsDataDetails.Tables[0].Rows[0]["job_Qualification"].ToString();
                Exp = dsDataDetails.Tables[0].Rows[0]["job_exp"].ToString();
                Sal = dsDataDetails.Tables[0].Rows[0]["job_sal"].ToString();
                KeySkills = dsDataDetails.Tables[0].Rows[0]["job_keyskills"].ToString();
                JobDesc = dsDataDetails.Tables[0].Rows[0]["job_desc"].ToString();
                EvePlace = dsDataDetails.Tables[0].Rows[0]["event_place"].ToString();
                EveName = dsDataDetails.Tables[0].Rows[0]["event_name"].ToString();
                EveDiDesc = dsDataDetails.Tables[0].Rows[0]["event_desc"].ToString();
                EveDiStartDate = dsDataDetails.Tables[0].Rows[0]["event_startdate"].ToString();
                EveDiEndDate = dsDataDetails.Tables[0].Rows[0]["event_enddate"].ToString();
                EveDiTime = dsDataDetails.Tables[0].Rows[0]["event_time"].ToString();
                ContactPerson = dsDataDetails.Tables[0].Rows[0]["contact_person"].ToString();
                Address = dsDataDetails.Tables[0].Rows[0]["address"].ToString();
                LandMark = dsDataDetails.Tables[0].Rows[0]["land_mark"].ToString();
                State = dsDataDetails.Tables[0].Rows[0]["State"].ToString();
                Phone = dsDataDetails.Tables[0].Rows[0]["landphno"].ToString();
                Mobile = dsDataDetails.Tables[0].Rows[0]["mob"].ToString();
                Email = dsDataDetails.Tables[0].Rows[0]["emailid"].ToString();
                Phone = dsDataDetails.Tables[0].Rows[0]["landphno"].ToString();
                Cat = dsDataDetails.Tables[0].Rows[0]["Category"].ToString();
                mod = dsDataDetails.Tables[0].Rows[0]["module"].ToString();
                durType = dsDataDetails.Tables[0].Rows[0]["evedi_DurationType"].ToString();
                sqlConnection.Open();
                string str = "Insert into sendmail(name,email,ph,companyname,adid) values('" + NameToSend + "','" + EmailToSend + "','" + PhoneToSend + "','" + CompanyName + "','" + sid + "')";
                SqlCommand cmd = new SqlCommand(str, sqlConnection);
                cmd.ExecuteNonQuery();
                if (mod == "Category")
                {
                    SendMailCategory(NameToSend, EmailToSend, PhoneToSend, CompanyName, CompanyProfile, ContactPerson, Address, LandMark, State, Email, Mobile, Phone, Fax);
                }
                else if (mod == "Discounts")
                {
                    if (durType == "One Day Event")
                    {
                        SendMailDiscounts(NameToSend, EmailToSend, PhoneToSend, CompanyName, CompanyProfile, EveDiStartDate, EveDiDesc, EveDiTime, ContactPerson, Address, LandMark, State, Email, Mobile, Phone, Fax);
                    }
                    else if (durType == "Multi Day Event")
                    {
                        SendMailDiscountsDuration(NameToSend, EmailToSend, PhoneToSend, CompanyName, CompanyProfile, EveDiStartDate, EveDiEndDate, EveDiDesc, EveDiTime, ContactPerson, Address, LandMark, State, Email, Mobile, Phone, Fax);
                    }
                }
                else if (mod == "Events")
                {
                    if (durType == "One Day Event")
                    {
                        SendMailEvents(NameToSend, EmailToSend, PhoneToSend, EveName, EvePlace, EveDiStartDate, EveDiDesc, EveDiTime, ContactPerson, Address, LandMark, State, Email, Mobile, Phone, Fax);
                    }
                    else if (durType == "Multi Day Event")
                    {
                        SendMailEventsDuration(NameToSend, EmailToSend, PhoneToSend, EveName, EvePlace, EveDiStartDate, EveDiEndDate, EveDiDesc, EveDiTime, ContactPerson, Address, LandMark, State, Email, Mobile, Phone, Fax);
                    }

                }
                else if (mod == "Jobs")
                {
                    SendMailJobs(NameToSend, EmailToSend, PhoneToSend, CompanyName, CompanyProfile, Ind, FunArea, Role, Qual, Exp, Sal, KeySkills, JobDesc, ContactPerson, Address, LandMark, State, Email, Mobile, Phone, Fax);
                }
                sqlConnection.Close();
            }
            string strScript = "";
            strScript = "alert('Your Mail is Sent Successfully.');";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
            txtemailToSend.Text = "";
            txtmobToSend.Text = "";
            txtnameToSend.Text = "";
        }
        else
        {
            string strScript = "";
            strScript = "alert('Inorder to send mail/sms you need to login.');";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
        }
    }
    /// <summary>
    /// To send mail for category data
    /// </summary>
    /// <param name="NameToSend"></param>
    /// <param name="EmailToSend"></param>
    /// <param name="PhoneToSend"></param>
    /// <param name="CompanyName"></param>
    /// <param name="CompanyProfile"></param>
    /// <param name="ContactPerson"></param>
    /// <param name="Address"></param>
    /// <param name="LandMark"></param>
    /// <param name="State"></param>
    /// <param name="Email"></param>
    /// <param name="Mobile"></param>
    /// <param name="Phone"></param>
    /// <param name="Fax"></param>
    private void SendMailCategory(string NameToSend, string EmailToSend, string PhoneToSend, string CompanyName, string CompanyProfile, string ContactPerson, string Address, string LandMark, string State, string Email, string Mobile, string Phone, string Fax)
    {
        try
        {
            string Msg = "";

            try
            {
                MailMessage mm = new MailMessage();
                //mm.From = "info@aceindus.in";
                //mm.To = "test_indus@yahoo.com";
                //mm.To = EmailToSend;
                mm.From = new MailAddress("info@justcalluz.com");
                mm.To.Add(EmailToSend);
                Msg += "Dear <b>" + NameToSend + "</b> ," +
                            "<br>Please find below the information you had requested:<br>" +
                            "<br>Whenever you call please mention that you got this info from Justcalluz.com" +
                            "<br><br><a href=http://www.justcalluz.com/SearchViewDetails.aspx?id=" + sid + ">" + CompanyName + "</a>" + "</b> " +
                            "<br><br><table width=100%>" +
                            "<tr><td align=left>Company Profile</td><td>:</td><td>" + CompanyProfile + "</td></tr><br>" +
                            "<tr><td align=left>Contact Person</td><td>:</td><td>" + ContactPerson + "</td></tr>" +
                            "<tr><td align=left>Address</td><td>:</td><td>" + Address + "</td></tr>" +
                            "<tr><td align=left>Land Mark</td><td>:</td><td>" + LandMark + "</td></tr>" +
                            "<tr><td align=left>State</td><td>:</td><td>" + State + "</td></tr>" +
                            "<tr><td align=left>Phone</td><td>:</td><td>" + Mobile + "," + Phone + "</td></tr>" +
                            "<tr><td align=left>Email</td><td>:</td><td>" + Email + "</td></tr>" +
                            "<tr><td align=left>Fax</td><td>:</td><td>" + Fax + "</td></tr>" +
                            "</table>" +
                            "<br>We hope the above information is in line with your request." +
                            "<br>Kindly feel free to search for more information on <a href=http://www.justcalluz.com/>www.justcalluz.com</a> or call on +9166136226." +
                            "<br><br>Warm Regards," +
                            "<br> Team JustCalluz";

                //mm.BodyFormat = MailFormat.Html;
                //mm.Body = Msg;
                //SmtpMail.SmtpServer = ConfigurationSettings.AppSettings["MySMTPServer"];
                //SmtpMail.Send(mm); 
                mm.Subject = "Addresses";
                mm.IsBodyHtml = true;
                mm.Body = Msg;
                SmtpClient smtp = new SmtpClient();
                smtp.Send(mm);
            }
            catch (Exception ex)
            {
                lblerror.Text = ex.Message;
            }
        }
        catch (Exception ee)
        {
            lblerror.Text = ee.Message;
        }
    }
    /// <summary>
    ///  To send mail for Discounts data without duration of discount
    /// </summary>
    /// <param name="NameToSend"></param>
    /// <param name="EmailToSend"></param>
    /// <param name="PhoneToSend"></param>
    /// <param name="CompanyName"></param>
    /// <param name="CompanyProfile"></param>
    /// <param name="EveDiStartDate"></param>
    /// <param name="EveDiDesc"></param>
    /// <param name="EveDiTime"></param>
    /// <param name="ContactPerson"></param>
    /// <param name="Address"></param>
    /// <param name="LandMark"></param>
    /// <param name="State"></param>
    /// <param name="Email"></param>
    /// <param name="Mobile"></param>
    /// <param name="Phone"></param>
    /// <param name="Fax"></param>
    private void SendMailDiscounts(string NameToSend, string EmailToSend, string PhoneToSend, string CompanyName, string CompanyProfile, string EveDiStartDate, string EveDiDesc, string EveDiTime, string ContactPerson, string Address, string LandMark, string State, string Email, string Mobile, string Phone, string Fax)
    {
        try
        {
            string Msg = "";

            try
            {
                MailMessage mm = new MailMessage();
                //mm.From = "info@aceindus.in";
                //mm.To = "test_indus@yahoo.com";
                //mm.To = EmailToSend;
                mm.From = new MailAddress("info@justcalluz.com");
                mm.To.Add(EmailToSend);
                Msg += "Dear <b>" + NameToSend + "</b> ," +
                            "<br>Please find below the information you had requested:<br>" +
                            "<br>Whenever you call please mention that you got this info from Justcalluz.com" +
                            "<br><a href=http://www.justcalluz.com/SearchViewDetails.aspx?id=" + sid + ">" + CompanyName + "</a>" + "</b> " +
                            "<br><table width=100%>" +
                            "<tr><td align=left>Company Profile</td><td>:</td><td>" + CompanyProfile + "</td></tr><br>" +
                            "<tr><td align=left>Discount on</td><td>:</td><td>" + EveDiStartDate + "</td></tr><br>" +
                            "<tr><td align=left>Discount Time</td><td>:</td><td>" + EveDiTime + "</td></tr><br>" +
                            "<tr><td align=left>Discount Description</td><td>:</td><td>" + EveDiDesc + "</td></tr><br>" +
                            "<tr><td align=left>Contact Person</td><td>:</td><td>" + ContactPerson + "</td></tr>" +
                            "<tr><td align=left>Address</td><td>:</td><td>" + Address + "</td></tr>" +
                            "<tr><td align=left>Land Mark</td><td>:</td><td>" + LandMark + "</td></tr>" +
                            "<tr><td align=left>State</td><td>:</td><td>" + State + "</td></tr>" +
                            "<tr><td align=left>Phone</td><td>:</td><td>" + Mobile + "," + Phone + "</td></tr>" +
                            "<tr><td align=left>Email</td><td>:</td><td>" + Email + "</td></tr>" +
                            "<tr><td align=left>Fax</td><td>:</td><td>" + Fax + "</td></tr>" +
                            "</table>" +
                            "<br>We hope the above information is in line with your request." +
                            "<br>Kindly feel free to search for more information on <a href=http://www.justcalluz.com/>www.justcalluz.com</a> or call on +9166136226." +
                            "<br><br>Warm Regards," +
                            "<br> Team JustCalluz";

                mm.Subject = "Discount Details";
                mm.IsBodyHtml = true;
                mm.Body = Msg;
                SmtpClient smtp = new SmtpClient();
                smtp.Send(mm);
            }
            catch (Exception ex)
            {
                lblerror.Text = ex.Message;
            }
        }
        catch (Exception ee)
        {
            lblerror.Text = ee.Message;
        }
    }
    /// <summary>
    ///  To send mail for Discounts data with duration of discount
    /// </summary>
    /// <param name="NameToSend"></param>
    /// <param name="EmailToSend"></param>
    /// <param name="PhoneToSend"></param>
    /// <param name="CompanyName"></param>
    /// <param name="CompanyProfile"></param>
    /// <param name="EveDiStartDate"></param>
    /// <param name="EveDiEndDate"></param>
    /// <param name="EveDiDesc"></param>
    /// <param name="EveDiTime"></param>
    /// <param name="ContactPerson"></param>
    /// <param name="Address"></param>
    /// <param name="LandMark"></param>
    /// <param name="State"></param>
    /// <param name="Email"></param>
    /// <param name="Mobile"></param>
    /// <param name="Phone"></param>
    /// <param name="Fax"></param>
    private void SendMailDiscountsDuration(string NameToSend, string EmailToSend, string PhoneToSend, string CompanyName, string CompanyProfile, string EveDiStartDate, string EveDiEndDate, string EveDiDesc, string EveDiTime, string ContactPerson, string Address, string LandMark, string State, string Email, string Mobile, string Phone, string Fax)
    {
        try
        {
            string Msg = "";

            try
            {
                MailMessage mm = new MailMessage();
                //mm.From = "info@aceindus.in";
                //mm.To = "test_indus@yahoo.com";
                //mm.To = EmailToSend;
                mm.From = new MailAddress("info@aceindus.in");
                mm.To.Add(EmailToSend);
                Msg += "Dear <b>" + NameToSend + "</b> ," +
                            "<br>Please find below the information you had requested:<br>" +
                            "<br>Whenever you call please mention that you got this info from Justcalluz.com" +
                            "<br><a href=http://www.justcalluz.com/SearchViewDetails.aspx?id=" + sid + ">" + CompanyName + "</a>" + "</b> " +
                            "<br><table width=100%>" +
                            "<tr><td align=left>Company Profile</td><td>:</td><td>" + CompanyProfile + "</td></tr><br>" +
                            "<tr><td align=left>Discount start on</td><td>:</td><td>" + EveDiStartDate + "</td></tr><br>" +
                            "<tr><td align=left>Discount Ends on</td><td>:</td><td>" + EveDiEndDate + "</td></tr><br>" +
                            "<tr><td align=left>Discount Time</td><td>:</td><td>" + EveDiTime + "</td></tr><br>" +
                            "<tr><td align=left>Discount Description</td><td>:</td><td>" + EveDiDesc + "</td></tr><br>" +
                            "<tr><td align=left>Contact Person</td><td>:</td><td>" + ContactPerson + "</td></tr>" +
                            "<tr><td align=left>Address</td><td>:</td><td>" + Address + "</td></tr>" +
                            "<tr><td align=left>Land Mark</td><td>:</td><td>" + LandMark + "</td></tr>" +
                            "<tr><td align=left>State</td><td>:</td><td>" + State + "</td></tr>" +
                            "<tr><td align=left>Phone</td><td>:</td><td>" + Mobile + "," + Phone + "</td></tr>" +
                            "<tr><td align=left>Email</td><td>:</td><td>" + Email + "</td></tr>" +
                            "<tr><td align=left>Fax</td><td>:</td><td>" + Fax + "</td></tr>" +
                            "</table>" +
                            "<br>We hope the above information is in line with your request." +
                            "<br>Kindly feel free to search for more information on <a href=http://www.justcalluz.com/>www.justcalluz.com</a> or call on +9166136226." +
                            "<br><br>Warm Regards," +
                            "<br> Team JustCalluz";

                //mm.BodyFormat = MailFormat.Html;
                //mm.Body = Msg;
                //SmtpMail.SmtpServer = ConfigurationSettings.AppSettings["MySMTPServer"];
                //SmtpMail.Send(mm);
                mm.Subject = "Discount Details";
                mm.IsBodyHtml = true;
                mm.Body = Msg;
                SmtpClient smtp = new SmtpClient();
                smtp.Send(mm);
            }
            catch (Exception ex)
            {
                lblerror.Text = ex.Message;
            }
        }
        catch (Exception ee)
        {
            lblerror.Text = ee.Message;
        }

    }
    /// <summary>
    /// To send mail for Events data without duration of event
    /// </summary>
    /// <param name="NameToSend"></param>
    /// <param name="EmailToSend"></param>
    /// <param name="PhoneToSend"></param>
    /// <param name="EveName"></param>
    /// <param name="EvePlace"></param>
    /// <param name="EveDiStartDate"></param>
    /// <param name="EveDiDesc"></param>
    /// <param name="EveDiTime"></param>
    /// <param name="ContactPerson"></param>
    /// <param name="Address"></param>
    /// <param name="LandMark"></param>
    /// <param name="State"></param>
    /// <param name="Email"></param>
    /// <param name="Mobile"></param>
    /// <param name="Phone"></param>
    /// <param name="Fax"></param>
    private void SendMailEvents(string NameToSend, string EmailToSend, string PhoneToSend, string EveName, string EvePlace, string EveDiStartDate, string EveDiDesc, string EveDiTime, string ContactPerson, string Address, string LandMark, string State, string Email, string Mobile, string Phone, string Fax)
    {
        try
        {
            string Msg = "";

            try
            {
                MailMessage mm = new MailMessage();
                //mm.From = "info@aceindus.in";
                //mm.To = "test_indus@yahoo.com";
                //mm.To = EmailToSend;
                mm.From = new MailAddress("info@aceindus.in");
                mm.To.Add(EmailToSend);
                Msg += "Dear <b>" + NameToSend + "</b> ," +
                            "<br>Please find below the information you had requested:<br>" +
                            "<br>Whenever you call please mention that you got this info from Justcalluz.com" +
                            "<br><a href=http://www.justcalluz.com/SearchViewDetails.aspx?id=" + sid + ">" + EveName + "</a>" + "</b> " +
                            "<br><table width=100%>" +
                            "<tr><td align=left>Place of the Event</td><td>:</td><td>" + EvePlace + "</td></tr><br>" +
                            "<tr><td align=left>Event on</td><td>:</td><td>" + EveDiStartDate + "</td></tr><br>" +
                            "<tr><td align=left>Event Time</td><td>:</td><td>" + EveDiTime + "</td></tr><br>" +
                            "<tr><td align=left>Event Description</td><td>:</td><td>" + EveDiDesc + "</td></tr><br>" +
                            "<tr><td align=left>Contact Person</td><td>:</td><td>" + ContactPerson + "</td></tr>" +
                            "<tr><td align=left>Address</td><td>:</td><td>" + Address + "</td></tr>" +
                            "<tr><td align=left>Land Mark</td><td>:</td><td>" + LandMark + "</td></tr>" +
                            "<tr><td align=left>State</td><td>:</td><td>" + State + "</td></tr>" +
                            "<tr><td align=left>Phone</td><td>:</td><td>" + Mobile + "," + Phone + "</td></tr>" +
                            "<tr><td align=left>Email</td><td>:</td><td>" + Email + "</td></tr>" +
                            "<tr><td align=left>Fax</td><td>:</td><td>" + Fax + "</td></tr>" +
                            "</table>" +
                            "<br>We hope the above information is in line with your request." +
                            "<br>Kindly feel free to search for more information on <a href=http://www.justcalluz.com/>www.justcalluz.com</a> or call on +9166136226." +
                            "<br><br>Warm Regards," +
                            "<br> Team JustCalluz";

                //mm.BodyFormat = MailFormat.Html;
                //mm.Body = Msg;
                //SmtpMail.SmtpServer = ConfigurationSettings.AppSettings["MySMTPServer"];
                //SmtpMail.Send(mm);
                mm.Subject = "Event Details";
                mm.IsBodyHtml = true;
                mm.Body = Msg;
                SmtpClient smtp = new SmtpClient();
                smtp.Send(mm);
            }
            catch (Exception ex)
            {
                lblerror.Text = ex.Message;
            }
        }
        catch (Exception ee)
        {
            lblerror.Text = ee.Message;
        }

    }
    /// <summary>
    /// To send mail for Events data with duration of events
    /// </summary>
    /// <param name="NameToSend"></param>
    /// <param name="EmailToSend"></param>
    /// <param name="PhoneToSend"></param>
    /// <param name="EveName"></param>
    /// <param name="EvePlace"></param>
    /// <param name="EveDiStartDate"></param>
    /// <param name="EveDiEndDate"></param>
    /// <param name="EveDiDesc"></param>
    /// <param name="EveDiTime"></param>
    /// <param name="ContactPerson"></param>
    /// <param name="Address"></param>
    /// <param name="LandMark"></param>
    /// <param name="State"></param>
    /// <param name="Email"></param>
    /// <param name="Mobile"></param>
    /// <param name="Phone"></param>
    /// <param name="Fax"></param>
    private void SendMailEventsDuration(string NameToSend, string EmailToSend, string PhoneToSend, string EveName, string EvePlace, string EveDiStartDate, string EveDiEndDate, string EveDiDesc, string EveDiTime, string ContactPerson, string Address, string LandMark, string State, string Email, string Mobile, string Phone, string Fax)
    {
        try
        {
            string Msg = "";

            try
            {
                MailMessage mm = new MailMessage();
                //mm.From = "info@aceindus.in";
                //mm.To = "test_indus@yahoo.com";
                //mm.To = EmailToSend;
                mm.From = new MailAddress("info@aceindus.in");
                mm.To.Add(EmailToSend);
                Msg += "Dear <b>" + NameToSend + "</b> ," +
                            "<br>Please find below the information you had requested:<br>" +
                            "<br>Whenever you call please mention that you got this info from Justcalluz.com" +
                            "<br><a href=http://www.justcalluz.com/SearchViewDetails.aspx?id=" + sid + ">" + EveName + "</a>" + "</b> " +
                            "<br><table width=100%>" +
                            "<tr><td align=left>Place of the Event</td><td>:</td><td>" + EvePlace + "</td></tr><br>" +
                            "<tr><td align=left>Event Starts on</td><td>:</td><td>" + EveDiStartDate + "</td></tr><br>" +
                            "<tr><td align=left>Event Ends on</td><td>:</td><td>" + EveDiEndDate + "</td></tr><br>" +
                            "<tr><td align=left>Event Time</td><td>:</td><td>" + EveDiTime + "</td></tr><br>" +
                            "<tr><td align=left>Event Description</td><td>:</td><td>" + EveDiDesc + "</td></tr><br>" +
                            "<tr><td align=left>Contact Person</td><td>:</td><td>" + ContactPerson + "</td></tr>" +
                            "<tr><td align=left>Address</td><td>:</td><td>" + Address + "</td></tr>" +
                            "<tr><td align=left>Land Mark</td><td>:</td><td>" + LandMark + "</td></tr>" +
                            "<tr><td align=left>State</td><td>:</td><td>" + State + "</td></tr>" +
                            "<tr><td align=left>Phone</td><td>:</td><td>" + Mobile + "," + Phone + "</td></tr>" +
                            "<tr><td align=left>Email</td><td>:</td><td>" + Email + "</td></tr>" +
                            "<tr><td align=left>Fax</td><td>:</td><td>" + Fax + "</td></tr>" +
                            "</table>" +
                            "<br>We hope the above information is in line with your request." +
                            "<br>Kindly feel free to search for more information on <a href=http://www.justcalluz.com/>www.justcalluz.com</a> or call on +9166136226." +
                            "<br><br>Warm Regards," +
                            "<br> Team JustCalluz";

                //mm.BodyFormat = MailFormat.Html;
                //mm.Body = Msg;
                //SmtpMail.SmtpServer = ConfigurationSettings.AppSettings["MySMTPServer"];
                //SmtpMail.Send(mm);
                mm.Subject = "Event Details";
                mm.IsBodyHtml = true;
                mm.Body = Msg;
                SmtpClient smtp = new SmtpClient();
                smtp.Send(mm);
            }
            catch (Exception ex)
            {
                lblerror.Text = ex.Message;
            }
        }
        catch (Exception ee)
        {
            lblerror.Text = ee.Message;
        }

    }
    /// <summary>
    /// To send mail for Jobs data 
    /// </summary>
    /// <param name="NameToSend"></param>
    /// <param name="EmailToSend"></param>
    /// <param name="PhoneToSend"></param>
    /// <param name="CompanyName"></param>
    /// <param name="CompanyProfile"></param>
    /// <param name="Ind"></param>
    /// <param name="FunArea"></param>
    /// <param name="Role"></param>
    /// <param name="Qual"></param>
    /// <param name="Exp"></param>
    /// <param name="Sal"></param>
    /// <param name="KeySkills"></param>
    /// <param name="JobDesc"></param>
    /// <param name="ContactPerson"></param>
    /// <param name="Address"></param>
    /// <param name="LandMark"></param>
    /// <param name="State"></param>
    /// <param name="Email"></param>
    /// <param name="Mobile"></param>
    /// <param name="Phone"></param>
    /// <param name="Fax"></param>
    private void SendMailJobs(string NameToSend, string EmailToSend, string PhoneToSend, string CompanyName, string CompanyProfile, string Ind, string FunArea, string Role, string Qual, string Exp, string Sal, string KeySkills, string JobDesc, string ContactPerson, string Address, string LandMark, string State, string Email, string Mobile, string Phone, string Fax)
    {
        try
        {
            string Msg = "";

            try
            {
                MailMessage mm = new MailMessage();
                //mm.From = "info@aceindus.in";
                //mm.To = "test_indus@yahoo.com";
                //mm.To = EmailToSend;
                mm.From = new MailAddress("info@aceindus.in");
                mm.To.Add(EmailToSend);
                Msg += "Dear <b>" + NameToSend + "</b> ," +
                            "<br>Please find below the information you had requested:<br>" +
                            "<br>Whenever you call please mention that you got this info from Justcalluz.com" +
                            "<br><a href=http://www.justcalluz.com/SearchViewDetails.aspx?id=" + sid + ">" + CompanyName + "</a>" + "</b> " +
                            "<br><table width=100%>" +
                            "<tr><td align=left width=140px>Company Profile</td><td>:</td><td>" + CompanyProfile + "</td></tr><br>" +
                            "<tr><td align=left>Industry</td><td>:</td><td>" + Ind + "</td></tr><br>" +
                            "<tr><td align=left>Functional Area</td><td>:</td><td>" + FunArea + "</td></tr><br>" +
                            "<tr><td align=left>Role</td><td>:</td><td>" + Role + "</td></tr><br>" +
                            "<tr><td align=left>Qualification</td><td>:</td><td>" + Qual + "</td></tr><br>" +
                            "<tr><td align=left>Experience</td><td>:</td><td>" + Exp + "</td></tr><br>" +
                            "<tr><td align=left>Key Skills</td><td>:</td><td>" + KeySkills + "</td></tr><br>" +
                            "<tr><td align=left>Job Description</td><td>:</td><td>" + JobDesc + "</td></tr><br>" +
                            "<tr><td align=left>Salary</td><td>:</td><td>" + Sal + "</td></tr><br>" +
                            "<tr><td align=left>Contact Person</td><td>:</td><td>" + ContactPerson + "</td></tr>" +
                            "<tr><td align=left>Address</td><td>:</td><td>" + Address + "</td></tr>" +
                            "<tr><td align=left>Land Mark</td><td>:</td><td>" + LandMark + "</td></tr>" +
                            "<tr><td align=left>State</td><td>:</td><td>" + State + "</td></tr>" +
                            "<tr><td align=left>Phone</td><td>:</td><td>" + Mobile + "," + Phone + "</td></tr>" +
                            "<tr><td align=left>Email</td><td>:</td><td>" + Email + "</td></tr>" +
                            "<tr><td align=left>Fax</td><td>:</td><td>" + Fax + "</td></tr>" +
                            "</table>" +
                            "<br>We hope the above information is in line with your request." +
                            "<br>Kindly feel free to search for more information on <a href=http://www.justcalluz.com/>www.justcalluz.com</a> or call on +9166136226." +
                            "<br><br>Warm Regards," +
                            "<br> Team JustCalluz";

                //mm.BodyFormat = MailFormat.Html;
                //mm.Body = Msg;
                //SmtpMail.SmtpServer = ConfigurationSettings.AppSettings["MySMTPServer"];
                //SmtpMail.Send(mm);
                mm.Subject = "Job Details";
                mm.IsBodyHtml = true;
                mm.Body = Msg;
                SmtpClient smtp = new SmtpClient();
                smtp.Send(mm);
            }
            catch (Exception ex)
            {
                lblerror.Text = ex.Message;
            }
        }
        catch (Exception ee)
        {
            lblerror.Text = ee.Message;
        }

    }
    /// <summary>
    /// Function to go previous page
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnBack_Click(object sender, EventArgs e)
    {
        if (Session["cname"] != null && Session["city"] != null)
        {
            Response.Redirect("linkresults.aspx?cname=" + Session["cname"].ToString() + "&city=" + Session["city"]);
        }
        else
        {
            Response.Redirect("jobs.aspx");
        }
    }
    /// <summary>
    /// Function to post reviews
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void imgbtnPostReview_Click(object sender, ImageClickEventArgs e)
    {
        sid = (Request.QueryString["id"].ToString());
        Response.Redirect("PostReview.aspx?DataId=" + sid);
    }
    /// <summary>
    /// To bound review items
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void dlReview_ItemDataBound(object sender, DataListItemEventArgs e)
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
    public void SendMail(string name, string fname, string email)
    {
        try
        {
            string Msg = "";

            try
            {
                MailMessage mm = new MailMessage();
                mm.From = new MailAddress("info@aceindus.in");
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
            catch (Exception ex)
            {
                lblerror.Text = ex.Message;
            }
        }
        catch (Exception ee)
        {
            lblerror.Text = ee.Message;
        }
    }


    protected void submitbutton1_Click(object sender, EventArgs e)
    {
        //string name = txtname1.Text;
        //string fname = txtfname.Text;
        //string email = txtfmail.Text;
        //SendMail(name, fname, email);
        //string strScript = string.Empty;
        //strScript = "alert('Thank you! You have successfully shared with your friend.');";
        //Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
    }

}
