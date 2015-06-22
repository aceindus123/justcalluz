using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;
using IndusAbroad.DataAccessLayer;
namespace CallUsRegistration.Registration
{
    /// <summary>
    /// Summary description for RegistrationCS
    /// </summary>
    public class RegistrationCS
    {
        public DataAccess obj = new DataAccess();
        SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
        DataSet ds = new DataSet();
        string script = string.Empty;
        public RegistrationCS()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        private Int32 rid;
        private string iUserId;
        private string BusinessName;
        private string KindofBusiness;
        private string WebSite;
        private string Description;
        private string UserName;
        private string LastName;
        private string Mobile;
        private string Password;        
        private string EmailId;
        private string City;
        private string Address;
        private string LandMark;
        private string State;
        private string PinCode;
        private string LandLine;
        private string Fax;
        private DateTime RDate;
        private DateTime EDate;
        private string ActivaId;
        private Int32 Status;
        private string RegType;
        private Int32 loginStatus;
        //careers types

        private Int16 Job_Id;
        private string Title1;
        private string Firstname;
        private string Lastname;
        private string Email;
        private string Landline_num;
        private string Cell_num1;
        private string Category1;
        private string Specialization1;
        private string Exp_years;
        private string Exp_months;
        private string Current_ctc;
        private string Expected_ctc;
        private string Jobtype;
        private string BasicEducation1;
        private string Curriculam_vitaeName;
        private string Curriculam_vitaePath;
        private string Ajobid;

        public Int32 loginstat
        {
            get { return loginStatus; }
            set { loginStatus = value; }
        }
        public int pId
        {
            get { return rid; }
            set { rid = value; }
        }
        public string pUserid
        {
            get { return iUserId; }
            set { iUserId = value; }
        }
        public string rBusinessName
        {
            get { return BusinessName; }
            set { BusinessName = value; }
        }
        public string rKindofBusiness
        {
            get { return KindofBusiness; }
            set { KindofBusiness = value; }

        }
        public string rWebSite
        {
            get { return WebSite; }
            set { WebSite = value; }

        }
        public string rDescription
        {
            get { return Description; }
            set { Description = value; }

        }
        public string rUserName
        {
            get { return UserName; }
            set { UserName = value; }

        }
        public string rLastName
        {
            get { return LastName; }
            set { LastName = value; }

        }
        public string rMobile
        {
            get { return Mobile; }
            set { Mobile = value; }

        }
        public string rPassword
        {
            get { return Password; }
            set { Password = value; }

        }
        public string rEmailId
        {
            get { return EmailId; }
            set { EmailId = value; }

        }
        public string rCity
        {
            get { return City; }
            set { City = value; }

        }
        public string rAddress
        {
            get { return Address; }
            set { Address = value; }

        }
        public string rLandMark
        {
            get { return LandMark; }
            set { LandMark = value; }

        }
        public string rState
        {
            get { return State; }
            set { State = value; }

        }
        public string rPinCode
        {
            get { return PinCode; }
            set { PinCode = value; }

        }
        public string rLandLine
        {
            get { return LandLine; }
            set { LandLine = value; }

        }
        public string rFax
        {
            get { return Fax; }
            set { Fax = value; }

        }
        public DateTime regDate
        {
            get { return RDate; }
            set { RDate = value; }
        }
        public DateTime expDate
        {
            get { return EDate; }
            set { EDate = value; }
        }
        public string vActiveId
        {
            get { return ActivaId; }
            set { ActivaId = value; }
        }
        public Int32 pStatus
        {
            get { return Status; }
            set { Status = value; }

        }
        public string rRegType
        {
            get { return RegType; }
            set { RegType = value; }
        }

        //careers properties
        public Int16 jobid
        {
            get { return Job_Id; }
            set { Job_Id = value; }
        }
        public string Title
        {
            get { return Title1; }
            set { Title1 = value; }
        }
        public string firstname
        {
            get { return Firstname; }
            set { Firstname = value; }
        }
        public string lastname
        {
            get { return Lastname; }
            set { Lastname = value; }
        }
        public string email
        {
            get { return Email; }
            set { Email = value; }
        }
        public string landline_num
        {
            get { return Landline_num; }
            set { Landline_num = value; }
        }
        public string Cell_num
        {
            get { return Cell_num1; }
            set { Cell_num1 = value; }
        }
        public string Category
        {
            get { return Category1; }
            set { Category1 = value; }
        }
        public string Specialization
        {
            get { return Specialization1; }
            set { Specialization1 = value; }
        }
        public string exp_years
        {
            get { return Exp_years; }
            set { Exp_years = value; }
        }
        public string exp_months
        {
            get { return Exp_months; }
            set { Exp_months = value; }
        }
        public string current_ctc
        {
            get { return Current_ctc; }
            set { Current_ctc = value; }
        }

        public string expected_ctc
        {
            get { return Expected_ctc; }
            set { Expected_ctc = value; }
        }
        public string jobtype
        {
            get { return Jobtype; }
            set { Jobtype = value; }
        }
        public string BasicEducation
        {
            get { return BasicEducation1; }
            set { BasicEducation1 = value; }
        }
        public string curriculam_vitaeName
        {
            get { return Curriculam_vitaeName; }
            set { Curriculam_vitaeName = value; }
        }
        public string curriculam_vitaePath
        {
            get { return Curriculam_vitaePath; }
            set { Curriculam_vitaePath = value; }
        }
        public string ajobid
        {
            get { return Ajobid; }
            set { Ajobid = value; }
        }

        string str = string.Empty;
        string str1 = string.Empty;
        public bool Insert(string UserName,string LastName, string Mobile, string Password, string EmailId, string City, string Address, string LandMark,
                                string State,string PinCode, string LandLine, string Fax, string BusinessName, string KindofBusiness,
                                string WebSite, string Description, DateTime regDate, DateTime expDate, string RegType)
        {
            try
            {
               // SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
                connection.Open();
                SqlTransaction myTrans = connection.BeginTransaction();
                SqlParameter[] arParms = new SqlParameter[23];

                arParms[0] = new SqlParameter("@UName", SqlDbType.NVarChar);
                arParms[0].Value = UserName;
                arParms[1] = new SqlParameter("@UMobile", SqlDbType.NVarChar);
                arParms[1].Value = Mobile;
                arParms[2] = new SqlParameter("@UPwd", SqlDbType.NVarChar);
                arParms[2].Value = Password;
                arParms[3] = new SqlParameter("@UEmailId", SqlDbType.NVarChar);
                arParms[3].Value = EmailId;
                arParms[4] = new SqlParameter("@UCity", SqlDbType.NVarChar);
                arParms[4].Value = City;
                arParms[5] = new SqlParameter("@UAddress", SqlDbType.NVarChar);
                arParms[5].Value = Address;
                arParms[6] = new SqlParameter("@ULandMark", SqlDbType.NVarChar);
                arParms[6].Value = LandMark;
                arParms[7] = new SqlParameter("@UState", SqlDbType.NVarChar);
                arParms[7].Value = State;
                arParms[8] = new SqlParameter("@ULandline", SqlDbType.NVarChar);
                arParms[8].Value = LandLine;
                arParms[9] = new SqlParameter("@UFax", SqlDbType.NVarChar);
                arParms[9].Value = Fax;
                arParms[10] = new SqlParameter("@UBusiName", SqlDbType.NVarChar);
                arParms[10].Value = BusinessName;
                arParms[11] = new SqlParameter("@UKOB", SqlDbType.NVarChar);
                arParms[11].Value = KindofBusiness;
                arParms[12] = new SqlParameter("@UWebsite", SqlDbType.NVarChar);
                arParms[12].Value = WebSite;
                arParms[13] = new SqlParameter("@UDesc", SqlDbType.NVarChar);
                arParms[13].Value = Description;

                arParms[14] = new SqlParameter("@RegDate", SqlDbType.DateTime);
                arParms[14].Value = regDate;
                arParms[15] = new SqlParameter("@ExpDate", SqlDbType.DateTime);
                arParms[15].Value = expDate;
                arParms[16] = new SqlParameter("@Status", SqlDbType.Int);
                arParms[16].Value = "0";
                arParms[17] = new SqlParameter("@bDelete", SqlDbType.Int);
                arParms[17].Value = "0";
                arParms[18] = new SqlParameter("@LName", SqlDbType.NVarChar);
                arParms[18].Value = LastName;

                Random rsMob = new Random();
                str1 = Convert.ToString(rsMob.Next(20000));
                if (str1 != "")
                {
                    arParms[19] = new SqlParameter("@VMobActiveId", SqlDbType.NVarChar);
                    arParms[19].Value = str1;
                }
                else
                {
                    arParms[19] = new SqlParameter("@VMobActiveId", SqlDbType.NVarChar);
                    arParms[19].Value = "NotGenerated";
                }
                Random rs = new Random();
                str = Convert.ToString(rs.Next(10000));
                if (str != "")
                {
                    arParms[20] = new SqlParameter("@vEmailActiveId", SqlDbType.NVarChar);
                    arParms[20].Value = str;
                }
                else
                {
                    arParms[20] = new SqlParameter("@vEmailActiveId", SqlDbType.NVarChar);
                    arParms[20].Value = "NotGenerated";
                }

                arParms[21] = new SqlParameter("@pincode", SqlDbType.NVarChar);
                arParms[21].Value = PinCode;
                arParms[22] = new SqlParameter("@Regtype", SqlDbType.NVarChar);
                arParms[22].Value = RegType;
                DBOperations.ExecuteNonQuery(myTrans, CommandType.StoredProcedure, "RegistrationSP", arParms);
                myTrans.Commit();
            }
            catch (Exception ex)
            {
                script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
            }
            finally
            {
                connection.Close();
            }
            return true;
        }
        public bool ActivateUser(string uid, string aid, Int32 statusid)
        {
            try
            {

                //SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
                connection.Open();
                SqlTransaction myTrans = connection.BeginTransaction();
                SqlParameter[] arParms = new SqlParameter[3];

                arParms[0] = new SqlParameter("@iUserId", SqlDbType.NVarChar);
                arParms[0].Value = uid;
                arParms[1] = new SqlParameter("@vActiveId", SqlDbType.NVarChar);
                arParms[1].Value = aid;
                arParms[2] = new SqlParameter("@iStatus", SqlDbType.Int);
                arParms[2].Value = statusid;


                DBOperations.ExecuteNonQuery(myTrans, CommandType.StoredProcedure, "Sp_ActivateUser", arParms);
                myTrans.Commit();
                connection.Close();
            }
            catch (Exception ex)
            {
                script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
            }
            finally
            {
                connection.Close();
            }
            return true;
        }
        public Int32 CheckValidUser(string uid, string aid, int sid)
        {
            Int32 count = 0;
            try
            {
                // SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
                connection.Open();
                SqlCommand sqlcmd = new SqlCommand("select count(*) from register where id = '" + uid + "' and iActiveId = '" + aid + "' and iStatus = " + sid + "", connection);
                count = Convert.ToInt32(sqlcmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
            }
            finally
            {
                connection.Close();
            }
            return count;
        }
        public DataSet getNewUserDetails(string email, string pwd)
        {
            DataSet dsUDetails = new DataSet();
            try{
             SqlDataAdapter sqlda = new SqlDataAdapter("select * from register where email = '" + email + "' and password = '" + pwd + "'", connection);
            sqlda.Fill(dsUDetails, "UserDetails");
            }
            catch (Exception ex)
            {
                script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
            }
            return dsUDetails;
        }
        public bool FillDrop(System.Web.UI.WebControls.DropDownList dp, string stm, string ValueFld, string TextFld, string dfltTxt)
        {
            
            connection.Open();
            SqlCommand cmd = new SqlCommand(stm, connection);
            SqlDataReader rdr = cmd.ExecuteReader();
            try
            {
                dp.DataValueField = ValueFld;
                dp.DataTextField = TextFld;
                dp.DataSource = rdr;
                dp.DataBind();
            }
            finally
            {
                if (!(rdr == null))
                {
                    rdr.Close();
                }
                dp.Items.Insert(0, dfltTxt);
                dp.SelectedIndex = 0;
                cmd.Dispose();
                connection.Close();
            }
            return true;
        }
        public Int32 CheckEmailid(string emailid)
        {
            Int32 count = 0;
            try
            {
                //SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
                connection.Open();
                SqlCommand sqlcmd = new SqlCommand("select count(*) from register where email = '" + emailid + "'", connection);
                 count = Convert.ToInt32(sqlcmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
            }
            finally
            {
                connection.Close();
            }
            return count;
        }
        public Int32 CheckMobileNumber(string mobno)
        {
            Int32 count = 0;
            try
            {
                //SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
                connection.Open();
                SqlCommand sqlcmd = new SqlCommand("select count(*) from register where mob = '" + mobno + "'", connection);
                count = Convert.ToInt32(sqlcmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
            }
            finally
            {
                connection.Close();
            }
            return count;
        }
        //To populate Drop Down List with States
        public void FillStates(DropDownList dpc)
        {
            try{
                FillDrop(dpc, "select sid,state_name from States", "state_name", "state_name", "Select State");
            }
            catch (Exception ex)
            {
                script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
            }
        }

        public bool Profile_Update(string rid,string FName,string Lname,string Address,string LandMark,string State,string City, string Pincode, string PhNo,string Fax,string BName,string BProfile,string KOB,string website,string mobile,string email)
        {
            try
            {
                //SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
                connection.Open();
                SqlTransaction myTrans = connection.BeginTransaction();
                SqlParameter[] arParms = new SqlParameter[16];

                arParms[0] = new SqlParameter("@UId", SqlDbType.NVarChar);
                arParms[0].Value = rid;
                arParms[1] = new SqlParameter("@UFName", SqlDbType.NVarChar);
                arParms[1].Value = FName;
                arParms[2] = new SqlParameter("@ULName", SqlDbType.NVarChar);
                arParms[2].Value = Lname;
                arParms[3] = new SqlParameter("@UAddress", SqlDbType.NVarChar);
                arParms[3].Value = Address;
                arParms[4] = new SqlParameter("@ULandMark", SqlDbType.NVarChar);
                arParms[4].Value = LandMark;
                arParms[5] = new SqlParameter("@UState", SqlDbType.NVarChar);
                arParms[5].Value = State;
                arParms[6] = new SqlParameter("@UCity", SqlDbType.NVarChar);
                arParms[6].Value = City;
                arParms[7] = new SqlParameter("@UPincode", SqlDbType.NVarChar);
                arParms[7].Value = Pincode;
                arParms[8] = new SqlParameter("@UPhNo", SqlDbType.NVarChar);
                arParms[8].Value = PhNo;
                arParms[9] = new SqlParameter("@UFax", SqlDbType.NVarChar);
                arParms[9].Value = Fax;
                arParms[10] = new SqlParameter("@UBname", SqlDbType.NVarChar);
                arParms[10].Value = BName;
                arParms[11] = new SqlParameter("@UBProf", SqlDbType.NVarChar);
                arParms[11].Value = BProfile;
                arParms[12] = new SqlParameter("@UKOB", SqlDbType.NVarChar);
                arParms[12].Value = KOB;
                arParms[13] = new SqlParameter("@UWebSite", SqlDbType.NVarChar);
                arParms[13].Value = website;
                arParms[14] = new SqlParameter("@UMOB", SqlDbType.NVarChar);
                arParms[14].Value = mobile;
                arParms[15] = new SqlParameter("@UEMAIL", SqlDbType.NVarChar);
                arParms[15].Value = email;
                DBOperations.ExecuteNonQuery(myTrans, CommandType.StoredProcedure, "Profile_Update", arParms);
                myTrans.Commit();
            }
            catch (Exception ex)
            {
                script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
            }
            finally
            {
                connection.Close();
            }
            return true;
        }
        public bool insertdetails(string Title, string firstname, string lastname, string email, string landline_num, string Cell_num,
                                   string exp_years, string exp_months, string current_ctc, string expected_ctc, string jobtype,
                                   string BasicEducation, string curriculam_vitaeName, string curriculam_vitaePath, string ajobid)
        {
            try
            {
                //SqlConnection conn = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
                connection.Open();
                SqlTransaction trans = connection.BeginTransaction();
                SqlParameter[] arParam = new SqlParameter[15];
                arParam[0] = new SqlParameter("@Title", SqlDbType.NVarChar, 50);
                arParam[0].Value = Title;
                arParam[1] = new SqlParameter("@firstname", SqlDbType.NVarChar, 50);
                arParam[1].Value = firstname;
                arParam[2] = new SqlParameter("@lastname", SqlDbType.NVarChar, 50);
                arParam[2].Value = lastname;
                arParam[3] = new SqlParameter("@email", SqlDbType.NVarChar, 50);
                arParam[3].Value = email;
                arParam[4] = new SqlParameter("@landline_num", SqlDbType.NVarChar, 50);
                arParam[4].Value = landline_num;
                arParam[5] = new SqlParameter("@Cell_num", SqlDbType.NVarChar, 50);
                arParam[5].Value = Cell_num;
                arParam[6] = new SqlParameter("@exp_years", SqlDbType.NVarChar, 50);
                arParam[6].Value = exp_years;
                arParam[7] = new SqlParameter("@exp_months", SqlDbType.NVarChar, 50);
                arParam[7].Value = exp_months;
                arParam[8] = new SqlParameter("@current_ctc", SqlDbType.NVarChar, 50);
                arParam[8].Value = current_ctc;
                arParam[9] = new SqlParameter("@expected_ctc", SqlDbType.NVarChar, 50);
                arParam[9].Value = expected_ctc;
                arParam[10] = new SqlParameter("@jobtype", SqlDbType.NVarChar, 50);
                arParam[10].Value = jobtype;
                arParam[11] = new SqlParameter("@BasicEducation", SqlDbType.NVarChar, 50);
                arParam[11].Value = BasicEducation;
                arParam[12] = new SqlParameter("@curriculam_vitaeName", SqlDbType.NVarChar, 100);
                arParam[12].Value = curriculam_vitaeName;
                arParam[13] = new SqlParameter("@curriculam_vitaePath", SqlDbType.NVarChar, 100);
                arParam[13].Value = curriculam_vitaePath;
                arParam[14] = new SqlParameter("@ajobid", SqlDbType.NVarChar, 50);
                arParam[14].Value = ajobid;
                DBOperations.ExecuteNonQuery(trans, CommandType.StoredProcedure, "careers_insert", arParam);
                trans.Commit();
            }
            catch (Exception ex)
            {
                script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
            }
            finally
            {
                connection.Close();
            }
            return true;

        }
        public DataSet getWebsiteUserStatus(int rid)
        {
            try{
            string qry = "select * from register where id=" + rid;

            ds = obj.ExcuteQry(qry);
            }
            catch (Exception ex)
            {
                script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
            }
            return ds;

        }
        public bool User_ChangeStatus(Int32 id, Int32 Status)
        {
            try
            {
                // SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
                connection.Open();
                SqlTransaction myTrans = connection.BeginTransaction();
                SqlParameter[] arParms = new SqlParameter[2];

                arParms[0] = new SqlParameter("@rid", SqlDbType.Int);
                arParms[0].Value = id;
                arParms[1] = new SqlParameter("@rStatus", SqlDbType.Int);
                arParms[1].Value = Status;

                DBOperations.ExecuteNonQuery(myTrans, CommandType.StoredProcedure, "[ChangeStatusSP]", arParms);
                myTrans.Commit();
            }
            catch (Exception ex)
            {
                script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
            }
            finally
            {
                connection.Close();
            }
            return true;
        }
        public bool LoginStatus(string loginid, Int32 loginStatus)
        {
            try
            {
                //SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
                connection.Open();
                SqlTransaction myTrans = connection.BeginTransaction();
                SqlParameter[] arParms = new SqlParameter[2];

                arParms[0] = new SqlParameter("@loginid", SqlDbType.NVarChar);
                arParms[0].Value = loginid;
                arParms[1] = new SqlParameter("@loginStatus", SqlDbType.Int);
                arParms[1].Value = loginStatus;

                DBOperations.ExecuteNonQuery(myTrans, CommandType.StoredProcedure, "[LoginStaus]", arParms);
                myTrans.Commit();
            }
            catch (Exception ex)
            {
                script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
            }
            finally
            {
                connection.Close();
            }
            return true;
        }
    }
}
