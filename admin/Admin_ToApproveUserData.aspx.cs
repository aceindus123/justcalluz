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
using CallUsStatus.DataStatus;
using IndusAbroad.safeConvert;
using System.Net.Mail;
using System.Net;
using System.Net.Mime;
using JustCallUsData.Data;

/// <summary>
/// Class to approve the data posted by the authenticated user from just call uz site
/// </summary>
public partial class admin_Admin_ToApproveUserData : System.Web.UI.Page
{
    string UserId;
    string strScript = "";
    string City;
    string State;
    string statement;
    string Edit;
    string Delete;
    string Edit1;
    string Delete1;
    string Edit2;
    string Delete2;
    string Edit3;
    string Delete3;
    string Edit4;
    string Delete4;
    string Edit5;
    string Delete5;
    string Edit6;
    string Delete6;
    DataCS data = new DataCS();
    int Id;
    static string excep_page = "Advanced_Search.aspx";
    InsertData objexception = new InsertData();
    string designation;
    /// <summary>
    /// code to display whenever page loads
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


        // loads the page without refreshing
        if (!IsPostBack)
        {
            data.FillStates(ddlState);
            ItemsGet();
        }
    }
    /// <summary>
    ///  Function to get the data from database when we click on the link
    private void ItemsGet()
    {
        City = ddlCity.SelectedValue;
        State = ddlState.SelectedValue;
        if (Request.QueryString["mod"] != null)
        {
            string modulename = Convert.ToString(Request.QueryString["mod"]);
            //if (Request.QueryString["mod1"] != null)
            //{
            string module = Convert.ToString(Request.QueryString["mod1"]);
            //}
            string catname = Convert.ToString(Request.QueryString["cat"]);
            DataSet ds = new DataSet();
            string con = ConfigurationManager.AppSettings["ConnectionString"];
            SqlConnection sqlConnection = new SqlConnection(con);
            sqlConnection.Open();
            if (State != "Select State")
            {
                btnActivate.Visible = true;
                btnDeactivate.Visible = true;
                btnDelete.Visible = true;
                if (City != "Select City")
                {
                    statement = "select m.*,Case when m.ApprovedStatus=1 Then 'Approved' When m.ApprovedStatus=2  Then 'Rejected' When m.ApprovedStatus=3  Then 'Updated' Else 'Posted' End  Status," +
                                   "count(dataid)as record_count from PostReview as p full outer join ModulesData as m on m.id=p.dataid " +
                                   "where (m.module='" + modulename + "'or m.module='" + module + "') and (m.ApprovedStatus='0' or m.ApprovedStatus='2' or m.ApprovedStatus='3') and m.City='" + City + "' and m.State='" + State + "' " +
                                "group by m.id,m.module,m.Category,m.SubCategory,m.State,m.City,m.company_name,m.job_industry,m.job_functional_area,m.job_exp,m.job_sal,m.job_desc,m.job_keyskills,m.company_profile," +
                                "m.event_name,m.event_place,m.event_startdate,m.event_enddate,m.event_desc,m.event_time,m.address,m.land_mark,m.contact_person,m.emailid,m.mob,m.landphno,m.fax," +
                                "m.postdate,m.expdate,m.job_role,m.job_Qualification,m.Other_SubCat,m.Area,m.evedi_DurationType,m.Job_ExpiryDate,m.Age,m.Website,m.UserLoginId,m.ApprovedStatus,m.Pincode,m.ImageName,m.ImageContentType,m.free_specifany,m.CatSub,m.map,m.Approved_map order by m.id desc";
                }
                else
                {
                    statement = "select m.*,Case when m.ApprovedStatus=1 Then 'Approved' When m.ApprovedStatus=2  Then 'Rejected' When m.ApprovedStatus=3  Then 'Updated' Else 'Posted' End  Status," +
                                    "count(dataid)as record_count from PostReview as p full outer join ModulesData as m on m.id=p.dataid " +
                                    "where (m.module='" + modulename + "'or m.module='" + module + "') and (m.ApprovedStatus='0' or m.ApprovedStatus='2' or m.ApprovedStatus='3') and m.State='" + State + "' " +
                                 "group by m.id,m.module,m.Category,m.SubCategory,m.State,m.City,m.company_name,m.job_industry,m.job_functional_area,m.job_exp,m.job_sal,m.job_desc,m.job_keyskills,m.company_profile," +
                                 "m.event_name,m.event_place,m.event_startdate,m.event_enddate,m.event_desc,m.event_time,m.address,m.land_mark,m.contact_person,m.emailid,m.mob,m.landphno,m.fax," +
                                 "m.postdate,m.expdate,m.job_role,m.job_Qualification,m.Other_SubCat,m.Area,m.evedi_DurationType,m.Job_ExpiryDate,m.Age,m.Website,m.UserLoginId,m.ApprovedStatus,m.Pincode,m.ImageName,m.ImageContentType,m.free_specifany,m.CatSub,m.map,m.Approved_map order by m.id desc";
                }
            }
            else
            {
                statement = "select m.*,Case when m.ApprovedStatus=1 Then 'Approved' When m.ApprovedStatus=2  Then 'Rejected' When m.ApprovedStatus=3  Then 'Updated' Else 'Posted' End  Status," +
                                    "count(dataid)as record_count from PostReview as p full outer join ModulesData as m on m.id=p.dataid  where (m.module='" + modulename + "'or m.module='" + module + "') and (m.ApprovedStatus='1' or m.ApprovedStatus='0' or m.ApprovedStatus='2' or m.ApprovedStatus='3')" +
                                 "group by m.id,m.module,m.Category,m.SubCategory,m.State,m.City,m.company_name,m.job_industry,m.job_functional_area,m.job_exp,m.job_sal,m.job_desc,m.job_keyskills,m.company_profile," +
                                 "m.event_name,m.event_place,m.event_startdate,m.event_enddate,m.event_desc,m.event_time,m.address,m.land_mark,m.contact_person,m.emailid,m.mob,m.landphno,m.fax," +
                                 "m.postdate,m.expdate,m.job_role,m.job_Qualification,m.Other_SubCat,m.Area,m.evedi_DurationType,m.Job_ExpiryDate,m.Age,m.Website,m.UserLoginId,m.ApprovedStatus,m.Pincode,m.ImageName,m.ImageContentType,m.free_specifany,m.CatSub,m.map,m.Approved_map order by m.id desc";
            }

            SqlDataAdapter imgtext = new SqlDataAdapter(statement, sqlConnection);
            imgtext.Fill(ds, "categoryData");
            DataView dtView = ds.Tables[0].DefaultView;
            if (!ds.Tables[0].Rows.Count.Equals(0))
            {
                string mod = "";
                string UserId = "";
                mod = ds.Tables[0].Rows[0]["module"].ToString();
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    
                  
                        ViewGrid.DataSource = ds;
                        ViewGrid.DataBind();
                   
                    if (mod == "Jobs")
                    {
                        ViewGrid.Columns[1].Visible = false;
                        ViewGrid.Columns[5].Visible = false;
                        ViewGrid.Columns[6].Visible = false;
                        ViewGrid.Columns[7].Visible = false;
                     
                        //Enable or disable permissions to edit data
                        Delete = Convert.ToString(Session["JobDel"]);
                        if (Delete == "1")
                        {
                            btnDelete.Enabled = true;
                        }
                        else
                        {
                            btnDelete.Enabled = false;
                        }


                                               
                    }
                    else if (mod == "Events")
                    {
                       
                        ViewGrid.Columns[1].Visible = false;
                        ViewGrid.Columns[2].Visible = false;
                        ViewGrid.Columns[3].Visible = false;
                        ViewGrid.Columns[4].Visible = false;
                        ViewGrid.Columns[8].Visible = false;

                        //Enable or disable permissions to edit data
                        Delete = Convert.ToString(Session["EveDel"]);
                        if (Delete == "1")
                        {
                            btnDelete.Enabled = true;
                        }
                        else
                        {
                            btnDelete.Enabled = false;
                        }
                    }
                    else if (mod == "Discounts")
                    {
                        ViewGrid.Columns[3].Visible = false;
                        ViewGrid.Columns[4].Visible = false;
                        ViewGrid.Columns[5].Visible = false;
                        ViewGrid.Columns[6].Visible = false;
                        ViewGrid.Columns[7].Visible = false;

                        //Enable or disable permissions to edit data
                        Delete = Convert.ToString(Session["DisDel"]);
                        if (Delete == "1")
                        {
                            btnDelete.Enabled = true;
                        }
                        else
                        {
                            btnDelete.Enabled = false;
                        }
                        
                    }
                    else
                    {
                        //Enable or disable permissions to edit data
                        Delete = Convert.ToString(Session["LSDel"]);
                        Delete1 = Convert.ToString(Session["FLDel"]);
                        Delete2 = Convert.ToString(Session["B2BDel"]);
                        Delete3 = Convert.ToString(Session["BDel"]);

                        if (Delete == "1")
                        {
                            btnDelete.Enabled = true;
                        }                                            
                        else  if (Delete1 == "1")
                        {
                            btnDelete.Enabled = true;
                        }
                        else if (Delete2 == "1")
                        {
                            btnDelete.Enabled = true;
                        }
                        else if (Delete3 == "1")
                        {
                            btnDelete.Enabled = true;
                        }
                        else
                        {
                            btnDelete.Enabled = false;
                        }

                        ViewGrid.Columns[3].Visible = false;
                        ViewGrid.Columns[4].Visible = false;
                        ViewGrid.Columns[5].Visible = false;
                        ViewGrid.Columns[6].Visible = false;
                        ViewGrid.Columns[7].Visible = false;
                        
                    }
                }
                if (State != "Select State")
                {
                    if (City != "Select City")
                    {

                        lblrecords.Text = "Records for the module of " + mod + " To Approve / Reject in " + City + ", " + State;
                    }
                    else
                    {
                        lblrecords.Text = "Records for the module of " + mod + " To Approve / Reject in " + State;
                    }
                }
                else
                {
                    lblrecords.Text = "Records for the module of " + mod + " To Approve / Reject";
                }
                trFilter.Visible = true;
                trFilterHead.Visible = true;

            }
            else
            {
                lblrecords.Text = "<b>Records for the module of " + modulename + " are not found To Approve / Reject </b>";
                ViewGrid.Visible = false;
                trFilter.Visible = true;
                trFilterHead.Visible = true;
                btnActivate.Visible = false;
                btnDeactivate.Visible = false;
                btnDelete.Visible = false;
            }
            Session["CatName"] = catname;
            Session["Modulename"] = modulename;
            sqlConnection.Close();
        }
    }
    /// <summary>
    /// To approve the data
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lnkApprove_Click(object sender, EventArgs e)
    {
        string LoginId = Convert.ToString(Session["LogInId"]);
        string userEmailId = "";
        Approve_Reject_UpDateCS obj = new Approve_Reject_UpDateCS();
        string modulename1 = Convert.ToString(Request.QueryString["mod"]);
        for (int i = 0; i < ViewGrid.Rows.Count; i++)
        {
            CheckBox cbox = (CheckBox)ViewGrid.Rows[i].FindControl("CheckBoxreq");
            if (cbox.Checked)
            {
                Id = Convert.ToInt32(ViewGrid.DataKeys[i].Values[0].ToString());
            }
        }
       

        DataSet dsApprove = new DataSet();
        SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
        con.Open();
        string statement = "select * from ModulesData where id=" + Id;
        SqlDataAdapter adaApprove = new SqlDataAdapter(statement, con);
        adaApprove.Fill(dsApprove, "categoryData");
        DataView dtView1 = dsApprove.Tables[0].DefaultView;
        if (!dsApprove.Tables[0].Rows.Count.Equals(0))
        {
            if (Convert.ToInt32(dsApprove.Tables[0].Rows[0]["ApprovedStatus"]) == 0 || Convert.ToInt32(dsApprove.Tables[0].Rows[0]["ApprovedStatus"]) == 2)
            {
                obj.pDataId = Id;
                obj.UEmailId = LoginId;
                obj.Data_ApprovalStatus(obj.pDataId, obj.UEmailId);

                userEmailId = dsApprove.Tables[0].Rows[0]["UserLoginId"].ToString();
                DataSet dsUName = new DataSet();
                string query = "select * from register where email='" + userEmailId + "'";
                SqlDataAdapter adaUName = new SqlDataAdapter(query, con);
                adaUName.Fill(dsUName, "Register");
                DataView dtview2 = dsUName.Tables[0].DefaultView;
                if (!dsUName.Tables[0].Rows.Count.Equals(0))
                {
                    string FName = dsUName.Tables[0].Rows[0]["name"].ToString();
                    string LName = dsUName.Tables[0].Rows[0]["LastName"].ToString();

                    if (modulename1 == "Category")
                    {
                        SendMailBusApproval(userEmailId, FName, LName);
                    }
                    else if (modulename1 == "Jobs")
                    {
                        try
                        {
                            string exper = dsApprove.Tables[0].Rows[0]["job_exp"].ToString();
                            //write here code to send data about the jobs into careersgen database . 
                            SqlConnection careercon = new SqlConnection(ConfigurationManager.AppSettings["career_connectionstring"]);
                            careercon.Open();
                            SqlCommand cmd = new SqlCommand("Insert_Postcareers_Jobs", careercon);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@p_jobtitle", "With the reference of Justcalluz.com");
                            cmd.Parameters.AddWithValue("@p_walkin", SqlDbType.Int).Value = 1;
                            cmd.Parameters.AddWithValue("@p_designation", dsApprove.Tables[0].Rows[0]["job_role"].ToString());
                            cmd.Parameters.AddWithValue("@p_skills", dsApprove.Tables[0].Rows[0]["job_keyskills"].ToString());
                            if (exper == "Fresher")
                            {
                                cmd.Parameters.AddWithValue("@p_minexp", 0);
                                cmd.Parameters.AddWithValue("@p_maxexp", 0);
                            }
                            else
                            {
                                int len = exper.Length;
                                string[] ex = exper.Split('-', ' ');
                                if (len == 2)
                                {
                                    cmd.Parameters.AddWithValue("@p_minexp", 0);
                                    cmd.Parameters.AddWithValue("@p_maxexp", ex[0]);
                                }
                                else if (len == 5)
                                {
                                    cmd.Parameters.AddWithValue("@p_minexp", ex[0]);
                                    cmd.Parameters.AddWithValue("@p_maxexp", ex[1]);
                                }
                            }
                            if (City == "Hyderabad" || City == "Secunderabad")
                            {
                                cmd.Parameters.AddWithValue("@p_location", "Hyderabad/Secunderabad,");
                                cmd.Parameters.AddWithValue("@p_hiringoff", "Hyderabad/Secunderabad,");
                            }
                            else
                            {
                                cmd.Parameters.AddWithValue("@p_location", dsApprove.Tables[0].Rows[0]["City"].ToString() + ",");
                                cmd.Parameters.AddWithValue("@p_hiringoff", dsApprove.Tables[0].Rows[0]["City"].ToString() + ",");
                            }
                            cmd.Parameters.AddWithValue("@p_ctc", "INR");
                            cmd.Parameters.AddWithValue("@p_ctc_lak", "Lakhs");
                            cmd.Parameters.AddWithValue("@p_ctc_thous", "Thousands");
                            cmd.Parameters.AddWithValue("@p_ctc1_lak", "Lakhs");
                            cmd.Parameters.AddWithValue("@p_ctc1_thous", "Thousands");
                            cmd.Parameters.AddWithValue("@p_ctc2_hunthous", "select");
                            cmd.Parameters.AddWithValue("@p_ctc2_thous", "select");
                            cmd.Parameters.AddWithValue("@p_ctc2_hunthous1", "select");
                            cmd.Parameters.AddWithValue("@p_ctc2_thous1", "select");
                            cmd.Parameters.AddWithValue("@p_ctc_hundthous", "select");
                            cmd.Parameters.AddWithValue("@p_ctc_thous1", "select");
                            cmd.Parameters.AddWithValue("@p_ctc1_hunthous", "select");
                            cmd.Parameters.AddWithValue("@p_ctc1_thous1", "select");
                            cmd.Parameters.AddWithValue("@p_hidecandidates", dsApprove.Tables[0].Rows[0]["job_sal"].ToString());
                            cmd.Parameters.AddWithValue("@p_perks", "Empty");
                            cmd.Parameters.AddWithValue("@p_vacancies", SqlDbType.Int).Value = 1;
                            cmd.Parameters.AddWithValue("@p_gender", "Select");
                            cmd.Parameters.AddWithValue("@p_farea", dsApprove.Tables[0].Rows[0]["job_functional_area"].ToString());
                            cmd.Parameters.AddWithValue("@p_industry", dsApprove.Tables[0].Rows[0]["job_industry"].ToString());
                            cmd.Parameters.AddWithValue("@p_graduate", "Any Graduate");
                            cmd.Parameters.AddWithValue("@p_graduatecours", "Any Specialization");
                            cmd.Parameters.AddWithValue("@p_graduatecoursspec", "Graduation Not Required");
                            cmd.Parameters.AddWithValue("@p_pg", "Not Required");
                            cmd.Parameters.AddWithValue("@p_pgcourse", dsApprove.Tables[0].Rows[0]["job_Qualification"].ToString());
                            cmd.Parameters.AddWithValue("@p_pgcoursspec", "Post Graduation Not Required");
                            cmd.Parameters.AddWithValue("@p_gother", "select");
                            cmd.Parameters.AddWithValue("@p_pgother", "select");
                            cmd.Parameters.AddWithValue("@p_hirecomp", dsApprove.Tables[0].Rows[0]["company_name"].ToString());
                            cmd.Parameters.AddWithValue("@p_compname", "Ace Indus Tech Sol India Pvt. Ltd");
                            cmd.Parameters.AddWithValue("@p_address", dsApprove.Tables[0].Rows[0]["address"].ToString());
                            cmd.Parameters.AddWithValue("@p_contact", dsApprove.Tables[0].Rows[0]["mob"].ToString() + "/" + dsApprove.Tables[0].Rows[0]["landphno"].ToString());
                            cmd.Parameters.AddWithValue("@p_Executname", dsApprove.Tables[0].Rows[0]["contact_person"].ToString());
                            cmd.Parameters.AddWithValue("@p_days", "select");
                            cmd.Parameters.AddWithValue("@p_times", "select");
                            cmd.Parameters.AddWithValue("@p_emailid", dsApprove.Tables[0].Rows[0]["emailid"].ToString());
                            cmd.Parameters.AddWithValue("@p_mail_parameters", "Empty,Empty,Empty,Empty,Empty,Empty,Empty");
                            cmd.Parameters.AddWithValue("@p_refcode", "Empty");
                            cmd.Parameters.AddWithValue("@p_onekeys", "Empty");
                            cmd.Parameters.AddWithValue("@p_allkeys", "Empty");
                            cmd.Parameters.AddWithValue("@p_mail_matchparams", "Empty,,Empty,Empty,Empty,Empty");
                            cmd.Parameters.AddWithValue("@p_rdo_recvjobs", "Recieve Only Relavent Jobs");
                            cmd.Parameters.AddWithValue("@p_rdo_hirecomp", "Hiring Company List");
                            cmd.Parameters.AddWithValue("@p_aboutcomp", dsApprove.Tables[0].Rows[0]["company_profile"].ToString());
                            cmd.Parameters.AddWithValue("@p_aboutmycomp", "Empty");
                            cmd.Parameters.AddWithValue("@p_expiredate", dsApprove.Tables[0].Rows[0]["Job_ExpiryDate"].ToString());
                            cmd.Parameters.AddWithValue("@p_relocatgender", "select");
                            cmd.Parameters.AddWithValue("@job_poston", dsApprove.Tables[0].Rows[0]["postdate"].ToString());
                            cmd.Parameters.AddWithValue("@login_id", "jcalluz");
                            cmd.Parameters.AddWithValue("@app_received", "Empty");
                            cmd.Parameters.AddWithValue("@app_view", "Empty");
                            cmd.Parameters.AddWithValue("@p_url", dsApprove.Tables[0].Rows[0]["Website"].ToString());
                            cmd.Parameters.AddWithValue("@CompanyLogo", "Empty");
                            cmd.Parameters.AddWithValue("@Logopath", "Empty");
                            cmd.Parameters.AddWithValue("@p_nonekeys", "Empty");
                            cmd.Parameters.AddWithValue("@p_restype", "Key Skills");
                            cmd.Parameters.AddWithValue("@p_hiremycomp", dsApprove.Tables[0].Rows[0]["company_name"].ToString());
                            cmd.Parameters.AddWithValue("@p_jobdescription", dsApprove.Tables[0].Rows[0]["job_desc"].ToString());
                            cmd.Parameters.AddWithValue("@p_desiredprofile", "Empty");
                            cmd.Parameters.AddWithValue("@p_status", SqlDbType.Int).Value = 1;
                            cmd.Parameters.AddWithValue("@p_jobtype", "company");
                            cmd.ExecuteNonQuery();
                            SqlCommand cmdcareer = new SqlCommand("get_careerid", careercon);
                            cmdcareer.CommandType = CommandType.StoredProcedure;
                            cmdcareer.Parameters.AddWithValue("@cmp_name", dsApprove.Tables[0].Rows[0]["company_name"].ToString());
                            SqlDataAdapter dacareer = new SqlDataAdapter(cmdcareer);
                            DataSet dscareer = new DataSet();
                            dacareer.Fill(dscareer);
                            careercon.Close();
                            SqlCommand cmdinsert = new SqlCommand("job_careers", con);
                            cmdinsert.CommandType = CommandType.StoredProcedure;
                            cmdinsert.Parameters.AddWithValue("@job_id", Convert.ToInt32(dsApprove.Tables[0].Rows[0]["id"].ToString()));
                            cmdinsert.Parameters.AddWithValue("@careers_id", Convert.ToInt32(dscareer.Tables[0].Rows[0]["p_jobcode"].ToString()));
                            cmdinsert.ExecuteNonQuery();
                            SendMailJobApproval(userEmailId, FName, LName);
                        }
                        catch (Exception ex)
                        {
                            ex.Message.ToString();
                        }
                    }
                    else if (modulename1 == "Events")
                    {
                        SendMailEventsApproval(userEmailId, FName, LName);
                    }
                    else if (modulename1 == "Discounts")
                    {
                        SendMailDiscountsApproval(userEmailId, FName, LName);
                    }
                    else if (modulename1 == "FreeListing")
                    {
                        SendMailFreeListingApproval(userEmailId, FName, LName);
                    }

                }

                con.Close();
                strScript = "alert('Approval has been done successfully');location.replace('Admin_ToApproveUserData.aspx?mod=" + modulename1 + "')";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "alertbox", strScript, true);
            }
            else
            {
                con.Close();
                strScript = "alert('Selected category already approved');location.replace('Admin_ToApproveUserData.aspx?mod=" + modulename1 + "')";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "alertbox", strScript, true);
            }
           

        }
       
    }
    protected void lnkDelete_Click(object sender, EventArgs e)
    {
        for (int i = 0; i < ViewGrid.Rows.Count; i++)
        {
            CheckBox cbox = (CheckBox)ViewGrid.Rows[i].FindControl("CheckBoxreq");
            if (cbox.Checked)
            {
                Id = Convert.ToInt32(ViewGrid.DataKeys[i].Values[0].ToString());
            }
        }
        string modulename1 = Convert.ToString(Request.QueryString["mod"]);
        data.pId = Id;
        bool t;
        t = data.Data_Delete(data.pId);
        if (t == true)
        {
            strScript = "alert('Delete has been done successfully');location.replace('Admin_ToApproveUserData.aspx?mod=" + modulename1 + "')";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertbox", strScript, true);
        }
    }
    /// <summary>
    /// To send mail to the user while admin made approval regarding business
    /// </summary>
    /// <param name="UserEmailId"></param>
    /// <param name="FName"></param>
    /// <param name="LName"></param>
    private void SendMailBusApproval(string UserEmailId, string FName, string LName)
    {
        try
        {
            string Msg = "";

            MailMessage mm = new MailMessage();
            //mm.From = new MailAddress("info@aceindus.in");
            mm.From = new MailAddress("info@justcalluz.com");
            mm.To.Add(UserEmailId);
            Msg += "Dear <b>" + FName + " " + LName + "</b>," +

                "<br><br>Your Business was Approved.<br>" +
                "Thanks for your interest with Just Call Uz" +
                "<br><br>Warm Regards," +
                "<br> Just Call Uz Team";
            mm.Subject = "Confirmation of approval for Your Business with Just Call Uz ";
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
    /// <summary>
    /// To send mail to the user while admin made approval regarding jobs
    /// </summary>
    /// <param name="UserEmailId"></param>
    /// <param name="FName"></param>
    /// <param name="LName"></param>
    private void SendMailJobApproval(string UserEmailId, string FName, string LName)
    {
        try
        {
            string Msg = "";

            MailMessage mm = new MailMessage();
            //mm.From = new MailAddress("info@aceindus.in");
            mm.From = new MailAddress("info@justcalluz.com");
            mm.To.Add(UserEmailId);
            Msg += "Dear <b>" + FName + " " + LName + "</b>," +

                "<br><br>Job posted by you is Approved.<br>" +
                "Thanks for your interest with Just Call Uz" +
                "<br><br>Warm Regards," +
                "<br> Just Call Uz Team";
            mm.Subject = "Confirmation of approval for Job posted by you in Just Call Uz ";
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
    /// <summary>
    /// To send mail to the user while admin made approval regarding events
    /// </summary>
    /// <param name="UserEmailId"></param>
    /// <param name="FName"></param>
    /// <param name="LName"></param>
    private void SendMailEventsApproval(string UserEmailId, string FName, string LName)
    {
        try
        {
            string Msg = "";

            MailMessage mm = new MailMessage();
            //mm.From = new MailAddress("info@aceindus.in");
            mm.From = new MailAddress("info@justcalluz.com");
            mm.To.Add(UserEmailId);
            Msg += "Dear <b>" + FName + " " + LName + "</b>," +

                "<br><br>Event posted by you is Approved.<br>" +
                "Thanks for your interest with Just Call Uz" +
                "<br><br>Warm Regards," +
                "<br> Just Call Uz Team";
            mm.Subject = "Confirmation of approval for Event posted by you in Just Call Uz ";
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
    /// <summary>
    /// To send mail to the user while admin made approval regarding discounts
    /// </summary>
    /// <param name="UserEmailId"></param>
    /// <param name="FName"></param>
    /// <param name="LName"></param>
    private void SendMailDiscountsApproval(string UserEmailId, string FName, string LName)
    {
        try
        {
            string Msg = "";

            MailMessage mm = new MailMessage();
            //mm.From = new MailAddress("info@aceindus.in");
            mm.From = new MailAddress("info@justcalluz.com");
            mm.To.Add(UserEmailId);
            Msg += "Dear <b>" + FName + " " + LName + "</b>," +

                "<br><br>Discount posted by you is Approved.<br>" +
                "Thanks for your interest with Just Call Uz" +
                "<br><br>Warm Regards," +
                "<br> Just Call Uz Team";
            mm.Subject = "Confirmation of approval for Dicount posted by you in Just Call Uz ";
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
    /// <summary>
    /// To send mail to the user while admin made approval regarding freelisting
    /// </summary>
    /// <param name="UserEmailId"></param>
    /// <param name="FName"></param>
    /// <param name="LName"></param>
    private void SendMailFreeListingApproval(string UserEmailId, string FName, string LName)
    {
        try
        {
            string Msg = "";

            MailMessage mm = new MailMessage();
            //mm.From = new MailAddress("info@aceindus.in");
            mm.From = new MailAddress("info@justcalluz.com");
            mm.To.Add(UserEmailId);
            Msg += "Dear <b>" + FName + " " + LName + "</b>," +

                "<br><br>The Listing posted by you is Approved.<br>" +
                "Thanks for your interest with Just Call Uz" +
                "<br><br>Warm Regards," +
                "<br> Just Call Uz Team";
            mm.Subject = "Confirmation of approval for Listing posted by you in Just Call Uz ";
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
    /// <summary>
    /// Function to reject he data
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lnkReject_Click(object sender, EventArgs e)
    {
        for (int i = 0; i < ViewGrid.Rows.Count; i++)
        {
            CheckBox cbox = (CheckBox)ViewGrid.Rows[i].FindControl("CheckBoxreq");
            if (cbox.Checked)
            {
                Id = Convert.ToInt32(ViewGrid.DataKeys[i].Values[0].ToString());
            }
        }
        string LogInId = Convert.ToString(Session["LogInId"]);
        string userEmailId = "";
        Approve_Reject_UpDateCS obj = new Approve_Reject_UpDateCS();
        string modulename1 = Convert.ToString(Request.QueryString["mod"]);
        //Id = 0;
       

        DataSet dsApprove = new DataSet();
        SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
        con.Open();
        string statement = "select * from ModulesData where id=" + Id;
        SqlDataAdapter adaApprove = new SqlDataAdapter(statement, con);
        adaApprove.Fill(dsApprove, "ModulesData");
        DataView dtView1 = dsApprove.Tables[0].DefaultView;
        if (!dsApprove.Tables[0].Rows.Count.Equals(0))
        {
            if (Convert.ToInt32(dsApprove.Tables[0].Rows[0]["ApprovedStatus"]) != 2)
            {
                obj.pDataId = Id;
                obj.UEmailId = LogInId;
                obj.Data_RejectionStatus(obj.pDataId, obj.UEmailId);
                userEmailId = dsApprove.Tables[0].Rows[0]["UserLoginId"].ToString();
                DataSet dsUName = new DataSet();
                string query = "select * from register where email='" + userEmailId + "'";
                SqlDataAdapter adaUName = new SqlDataAdapter(query, con);
                adaUName.Fill(dsUName, "Register");
                DataView dtview2 = dsUName.Tables[0].DefaultView;
                if (!dsUName.Tables[0].Rows.Count.Equals(0))
                {
                    string FName = dsUName.Tables[0].Rows[0]["name"].ToString();
                    string LName = dsUName.Tables[0].Rows[0]["LastName"].ToString();

                    if (modulename1 == "Category")
                    {
                        SendMailBusReject(userEmailId, FName, LName);
                    }
                    else if (modulename1 == "Jobs")
                    {
                        SendMailJobReject(userEmailId, FName, LName);
                    }
                    else if (modulename1 == "Events")
                    {
                        SendMailEventsReject(userEmailId, FName, LName);
                    }
                    else if (modulename1 == "Discounts")
                    {
                        SendMailDiscountsReject(userEmailId, FName, LName);
                    }
                    else if (modulename1 == "FreeListing")
                    {
                        SendMailFreeListingReject(userEmailId, FName, LName);
                    }
                }
                con.Close();
                strScript = "alert('Rejection has been done successfully');location.replace('Admin_ToApproveUserData.aspx?mod=" + modulename1 + "')";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "alertbox", strScript, true);

            }
            else
            {
                con.Close();
                strScript = "alert('Selected category already Rejected');location.replace('Admin_ToApproveUserData.aspx?mod=" + modulename1 + "')";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "alertbox", strScript, true);
            }
           
        }
        
       
    }
    /// <summary>
    /// To send mail to the user while admin made rejection regarding business.
    /// </summary>
    /// <param name="UserEmailId"></param>
    /// <param name="FName"></param>
    /// <param name="LName"></param>
    private void SendMailBusReject(string UserEmailId, string FName, string LName)
    {
        try
        {
            string Msg = "";

            MailMessage mm = new MailMessage();
            //mm.From = new MailAddress("info@aceindus.in");
            mm.From = new MailAddress("info@justcalluz.com");
            mm.To.Add(UserEmailId);
            Msg += "Dear <b>" + FName + " " + LName + "</b>," +

                "<br><br>Sorry to say, you entered violated Business data. Please update the data correctly. So that we can approve your data<br>" +
                "Thanks for your interest with Just Call Uz" +
                "<br><br>Warm Regards," +
                "<br> Just Call Uz Team";
            mm.Subject = "Notification for the violation of data entered in Just Call Uz ";
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
    /// <summary>
    /// To send mail to the user while admin made reject regarding jobs
    /// </summary>
    /// <param name="UserEmailId"></param>
    /// <param name="FName"></param>
    /// <param name="LName"></param>
    private void SendMailJobReject(string UserEmailId, string FName, string LName)
    {
        try
        {
            string Msg = "";

            MailMessage mm = new MailMessage();
            //mm.From = new MailAddress("info@aceindus.in");
            mm.From = new MailAddress("info@justcalluz.com");
            mm.To.Add(UserEmailId);
            Msg += "Dear <b>" + FName + " " + LName + "</b>," +

                "<br><br>Sorry to say, you entered violated Job data. Please update the data correctly. So that we can approve your data<br>" +
                "Thanks for your interest with Just Call Uz" +
                "<br><br>Warm Regards," +
                "<br> Just Call Uz Team";
            mm.Subject = "Notification for the violation of data entered in Just Call Uz ";
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
    /// <summary>
    /// To send mail to the user while admin made rejection regarding events
    /// </summary>
    /// <param name="UserEmailId"></param>
    /// <param name="FName"></param>
    /// <param name="LName"></param>
    private void SendMailEventsReject(string UserEmailId, string FName, string LName)
    {
        try
        {
            string Msg = "";

            MailMessage mm = new MailMessage();
            //mm.From = new MailAddress("info@aceindus.in");
            mm.From = new MailAddress("info@justcalluz.com");
            mm.To.Add(UserEmailId);
            Msg += "Dear <b>" + FName + " " + LName + "</b>," +

                "<br><br>Sorry to say, you entered violated Event data. Please update the data correctly. So that we can approve your data<br>" +
                "Thanks for your interest with Just Call Uz" +
                "<br><br>Warm Regards," +
                "<br> Just Call Uz Team";
            mm.Subject = "Notification for the violation of data entered in Just Call Uz ";
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
    /// <summary>
    /// To send mail to the user while admin made rejection regarding discounts
    /// </summary>
    /// <param name="UserEmailId"></param>
    /// <param name="FName"></param>
    /// <param name="LName"></param>
    private void SendMailDiscountsReject(string UserEmailId, string FName, string LName)
    {
        try
        {
            string Msg = "";

            MailMessage mm = new MailMessage();
            mm.From = new MailAddress("info@justcalluz.com");
            mm.To.Add(UserEmailId);
            Msg += "Dear <b>" + FName + " " + LName + "</b>," +

                "<br><br>Sorry to say, you entered violated Discount data. Please update the data correctly. So that we can approve your data<br>" +
                "Thanks for your interest with Just Call Uz" +
                "<br><br>Warm Regards," +
                "<br> Just Call Uz Team";
            mm.Subject = "Notification for the violation of data entered in Just Call Uz ";
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
    /// <summary>
    /// To send mail to the user while admin made rejection regarding free listings
    /// </summary>
    /// <param name="UserEmailId"></param>
    /// <param name="FName"></param>
    /// <param name="LName"></param>
    private void SendMailFreeListingReject(string UserEmailId, string FName, string LName)
    {
        try
        {
            string Msg = "";

            MailMessage mm = new MailMessage();
            mm.From = new MailAddress("info@justcalluz.com");
            mm.To.Add(UserEmailId);
            Msg += "Dear <b>" + FName + " " + LName + "</b>," +

                "<br><br>Sorry to say, you entered violated Listing data. Please update the data correctly. So that we can approve your data<br>" +
                "Thanks for your interest with Just Call Uz" +
                "<br><br>Warm Regards," +
                "<br> Just Call Uz Team";
            mm.Subject = "Notification for the violation of data entered in Just Call Uz ";
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
    protected void ddlState_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlState.SelectedIndex != 0)
        {
            string State_Name = Convert.ToString(ddlState.SelectedValue);
            fillCities(State_Name);
            ItemsGet();
        }
        else
        {
            ddlCity.Items.Clear();
            ddlCity.Items.Insert(0, "Select City");
            ItemsGet();
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
    protected void ddlCity_SelectedIndexChanged(object sender, EventArgs e)
    {
        ItemsGet();
    }
    protected void ViewGrid_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            //identifying the control in GridView
            Label lblESDate = (Label)e.Row.FindControl("lblESDate");
            if (lblESDate != null)
            {
                if (lblESDate.Text != "")
                {
                    string eventsdate = DateTime.Parse(lblESDate.Text).ToString("MMM dd yyyy");
                    lblESDate.Text = eventsdate;
                }
            }
        }
    }
    /// <summary>
    /// For page change
    /// </summary>
    /// <param name="source"></param>
    /// <param name="e"></param>
    protected void ViewGrid_PageIndexChanging(object source, GridViewPageEventArgs e)
    {
        //if (ViewGrid.CurrentPageIndex >= ViewGrid.PageCount)
        //{
        //    ViewGrid.CurrentPageIndex -= 1;
        //    ViewGrid.DataBind();
        //}
        ViewGrid.PageIndex = e.NewPageIndex;
        ItemsGet();
    }
    //protected void ViewGrid_ItemDataBound(object sender, DataGridItemEventArgs e)
    //{
    //    if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
    //    {
    //        Label lblStatus = (Label)e.Item.FindControl("lblStatus");
    //        if (Convert.ToInt32(lblStatus.Text) == 1)
    //        {
    //            lblStatus.Text = "Approved";
    //        }
    //        else if (Convert.ToInt32(lblStatus.Text) == 2)
    //        {
    //            lblStatus.Text = "Approved";
    //        }
    //    }
    //}
    protected void lnkBack_Click(object sender, EventArgs e)
    {
        if (Session["LoginId"] != null)
        {
            designation = Convert.ToString(Session["Designation"]);
            if (designation == "Admin")
            {
                Response.Redirect("Admin-MainPage.aspx");
            }
            else
            {
                Response.Redirect("Admin_Home.aspx");
            }
        }
    }
}
