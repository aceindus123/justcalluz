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

namespace CallUsCareers.career
{
   /// <summary>
/// Summary description for CareersCS
/// </summary>
    public class CareersCS
    {
        DataAccess obj = new DataAccess();
        //InsertData obj1 = new InsertData();
        //static string excep_page = "CareersCS.cs";
        string script = string.Empty;
        DataSet ds = new DataSet();
        SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
        public CareersCS()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        //Careers Posting Properties
        private Int16 C_JobId;
        private string C_Title;        
        private string C_JStatus;
        private string C_NoVac;
        private string C_JDesc;
        private string C_CompKnow;
        private string C_add1;
        private string C_aad2;
        private string C_City;
        private string C_State;
        private string C_Zip;
        private string C_ContName;
        private string C_ContEmail;
        private string C_ContPhone;
        private string C_ContPhExtn;
        private DateTime PostDate;
        private DateTime ExpDate;

        public Int16 jobid
        {
            get { return C_JobId; }
            set { C_JobId = value; }
        }
        public string cC_Title
        {
            get { return C_Title; }
            set { C_Title = value; }
        }        
        public string cC_JStatus
        {
            get { return C_JStatus; }
            set { C_JStatus = value; }
        }
        public string cC_NoVac
        {
            get { return C_NoVac; }
            set { C_NoVac = value; }
        }
        public string cC_JDesc
        {
            get { return C_JDesc; }
            set { C_JDesc = value; }
        }
        public string cC_CompKnow
        {
            get { return C_CompKnow; }
            set { C_CompKnow = value; }
        }
        public string cC_add1
        {
            get { return C_add1; }
            set { C_add1 = value; }
        }
        public string cC_aad2
        {
            get { return C_aad2; }
            set { C_aad2 = value; }
        }
        public string cC_City
        {
            get { return C_City; }
            set { C_City = value; }
        }
        public string cC_State
        {
            get { return C_State; }
            set { C_State = value; }
        }
        public string cC_Zip
        {
            get { return C_Zip; }
            set { C_Zip = value; }
        }
        public string cC_ContName
        {
            get { return C_ContName; }
            set { C_ContName = value; }
        }
        public string cC_ContEmail
        {
            get { return C_ContEmail; }
            set { C_ContEmail = value; }
        }
        public string cC_ContPhone
        {
            get { return C_ContPhone; }
            set { C_ContPhone = value; }
        }
        public string cC_ContPhExtn
        {
            get { return C_ContPhExtn; }
            set { C_ContPhExtn = value; }
        }
        public DateTime cPostDate
        {
            get { return PostDate; }
            set { PostDate = value; }
        }
        public DateTime cExpDate
        {
            get { return ExpDate; }
            set { ExpDate = value; }
        }
        //JobApply properties
       
        private string Title1;
        private string Firstname;
        private string Lastname;
        private string Email;
        private string Landline_num;
        private string Cell_num1;
        private string Category1;
        private string Specialization1;
        private string Exp_years;
        private string Exp_toyears;
        private string Exp_fromyears;
        private string Exp_months;
        private string Current_ctc;
        private string Expected_ctc;
        private string Jobtype;
        private string BasicEducation1;
        private string Curriculam_vitaeName;
        private string Curriculam_vitaePath;
        private string Ajobid;
        private string Userid;     

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
        public string exp_toyears
        {
            get { return Exp_toyears; }
            set { Exp_toyears = value; }
        }
        public string exp_fromyears
        {
            get { return Exp_fromyears; }
            set { Exp_fromyears = value; }
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
        public string userid
        {
            get { return Userid; }
            set { Userid = value; }
        }

        //careersfeedback
        private Int16 id1;
        private string Name;
        private string email1;
        private string mobile_num1;
        private string State;
        private string City;
        private string Feedback;

        //careersfeedback properties
        public Int16 id
        {
            get { return id1; }
            set { id1 = value; }
        }
        public string name
        {
            get { return Name; }
            set { Name = value; }
        }
        public string emailaddress
        {
            get { return email1; }
            set { email1 = value; }
        }
        public string mobile_num
        {
            get { return mobile_num1; }
            set { mobile_num1 = value; }
        }
        public string state
        {
            get { return State; }
            set { State = value; }
        }
        public string city
        {
            get { return City; }
            set { City = value; }
        }
        public string feedback
        {
            get { return Feedback; }
            set { Feedback = value; }
        }
        public bool CareersPost(string CTitle, string CCategory , string CSubCat, string CJType, string CJStatus, string CJDesc,
                                       string CExp, string CSal, string CVacancies, string CComputerK, string CQualification,
                                       string CAdd1, string CAdd2, string City, string State, string CZip, string CContName,
                                       string CContEmail, string CContPh, string CContPhExtn, DateTime PostDate, DateTime ExpDate)
        {

            //SqlConnection conn = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
            try
            {
                con.Open();
                SqlTransaction trans = con.BeginTransaction();
                SqlParameter[] arParam = new SqlParameter[22];
                arParam[0] = new SqlParameter("@CTitle", SqlDbType.NVarChar, 50);
                arParam[0].Value = CTitle;
                arParam[1] = new SqlParameter("@CCategory", SqlDbType.NVarChar, 50);
                arParam[1].Value = CCategory;
                arParam[2] = new SqlParameter("@CSubCat", SqlDbType.NVarChar, 50);
                arParam[2].Value = CSubCat;
                arParam[3] = new SqlParameter("@CJType", SqlDbType.NVarChar, 50);
                arParam[3].Value = CJType;
                arParam[4] = new SqlParameter("@CJStatus", SqlDbType.NVarChar, 50);
                arParam[4].Value = CJStatus;
                arParam[5] = new SqlParameter("@CJDesc", SqlDbType.NVarChar, 50);
                arParam[5].Value = CJDesc;
                arParam[6] = new SqlParameter("@CExp", SqlDbType.NVarChar, 50);
                arParam[6].Value = CExp;
                arParam[7] = new SqlParameter("@CSal", SqlDbType.NVarChar, 50);
                arParam[7].Value = CSal;
                arParam[8] = new SqlParameter("@CVacancies", SqlDbType.NVarChar, 50);
                arParam[8].Value = CVacancies;
                arParam[9] = new SqlParameter("@CComputerK", SqlDbType.NVarChar, 50);
                arParam[9].Value = CComputerK;
                arParam[10] = new SqlParameter("@CQualification", SqlDbType.NVarChar, 50);
                arParam[10].Value = CQualification;
                arParam[11] = new SqlParameter("@CAdd1", SqlDbType.NVarChar, 50);
                arParam[11].Value = CAdd1;
                arParam[12] = new SqlParameter("@CAdd2", SqlDbType.NVarChar, 100);
                arParam[12].Value = CAdd2;
                arParam[13] = new SqlParameter("@City", SqlDbType.NVarChar, 100);
                arParam[13].Value = City;
                arParam[14] = new SqlParameter("@State", SqlDbType.NVarChar, 50);
                arParam[14].Value = State;
                arParam[15] = new SqlParameter("@CZip", SqlDbType.NVarChar, 50);
                arParam[15].Value = CZip;
                arParam[16] = new SqlParameter("@CContName", SqlDbType.NVarChar, 50);
                arParam[16].Value = CContName;
                arParam[17] = new SqlParameter("@CContEmail", SqlDbType.NVarChar, 50);
                arParam[17].Value = CContEmail;
                arParam[18] = new SqlParameter("@CContPh", SqlDbType.NVarChar, 50);
                arParam[18].Value = CContPh;
                arParam[19] = new SqlParameter("@CContPhExtn", SqlDbType.NVarChar, 50);
                arParam[19].Value = CContPhExtn;
                arParam[20] = new SqlParameter("@PostDate", SqlDbType.DateTime);
                arParam[20].Value = PostDate;
                arParam[21] = new SqlParameter("@ExpDate", SqlDbType.DateTime);
                arParam[21].Value = ExpDate;
                DBOperations.ExecuteNonQuery(trans, CommandType.StoredProcedure, "careers_postSP", arParam);
                trans.Commit();
                // conn.Close();
            }
            catch (Exception ex)
            {
                script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
            }
            finally
            {
                con.Close();
            }
            return true;

        }
        public bool CareersUpdate(string CTitle, string CCategory, string CSubCat, string CJType, string CJStatus, string CJDesc,
                                       string CExp, string CSal, string CVacancies, string CComputerK, string CQualification,
                                       string CAdd1, string CAdd2, string City, string State, string CZip, string CContName,
                                       string CContEmail, string CContPh, string CContPhExtn, DateTime ExpDate,Int16 JId)
        {

            //SqlConnection conn = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
            try
            {
                con.Open();
                SqlTransaction trans = con.BeginTransaction();
                SqlParameter[] arParam = new SqlParameter[22];
                arParam[0] = new SqlParameter("@CTitle", SqlDbType.NVarChar, 50);
                arParam[0].Value = CTitle;
                arParam[1] = new SqlParameter("@CCategory", SqlDbType.NVarChar, 50);
                arParam[1].Value = CCategory;
                arParam[2] = new SqlParameter("@CSubCat", SqlDbType.NVarChar, 50);
                arParam[2].Value = CSubCat;
                arParam[3] = new SqlParameter("@CJType", SqlDbType.NVarChar, 50);
                arParam[3].Value = CJType;
                arParam[4] = new SqlParameter("@CJStatus", SqlDbType.NVarChar, 50);
                arParam[4].Value = CJStatus;
                arParam[5] = new SqlParameter("@CJDesc", SqlDbType.NVarChar, 50);
                arParam[5].Value = CJDesc;
                arParam[6] = new SqlParameter("@CExp", SqlDbType.NVarChar, 50);
                arParam[6].Value = CExp;
                arParam[7] = new SqlParameter("@CSal", SqlDbType.NVarChar, 50);
                arParam[7].Value = CSal;
                arParam[8] = new SqlParameter("@CVacancies", SqlDbType.NVarChar, 50);
                arParam[8].Value = CVacancies;
                arParam[9] = new SqlParameter("@CComputerK", SqlDbType.NVarChar, 50);
                arParam[9].Value = CComputerK;
                arParam[10] = new SqlParameter("@CQualification", SqlDbType.NVarChar, 50);
                arParam[10].Value = CQualification;
                arParam[11] = new SqlParameter("@CAdd1", SqlDbType.NVarChar, 50);
                arParam[11].Value = CAdd1;
                arParam[12] = new SqlParameter("@CAdd2", SqlDbType.NVarChar, 100);
                arParam[12].Value = CAdd2;
                arParam[13] = new SqlParameter("@City", SqlDbType.NVarChar, 100);
                arParam[13].Value = City;
                arParam[14] = new SqlParameter("@State", SqlDbType.NVarChar, 50);
                arParam[14].Value = State;
                arParam[15] = new SqlParameter("@CZip", SqlDbType.NVarChar, 50);
                arParam[15].Value = CZip;
                arParam[16] = new SqlParameter("@CContName", SqlDbType.NVarChar, 50);
                arParam[16].Value = CContName;
                arParam[17] = new SqlParameter("@CContEmail", SqlDbType.NVarChar, 50);
                arParam[17].Value = CContEmail;
                arParam[18] = new SqlParameter("@CContPh", SqlDbType.NVarChar, 50);
                arParam[18].Value = CContPh;
                arParam[19] = new SqlParameter("@CContPhExtn", SqlDbType.NVarChar, 50);
                arParam[19].Value = CContPhExtn;
                arParam[20] = new SqlParameter("@ExpDate", SqlDbType.DateTime);
                arParam[20].Value = ExpDate;
                arParam[21] = new SqlParameter("@CID", SqlDbType.Int);
                arParam[21].Value = JId;

                DBOperations.ExecuteNonQuery(trans, CommandType.StoredProcedure, "careers_UpdateSP", arParam);
                trans.Commit();
            }
            catch (Exception ex)
            {
                script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
            }
            finally
            {
                con.Close();
            }
            return true;

        }
        public bool insertdetails(string Title, string firstname, string lastname, string email, string landline_num,
                             string Cell_num, string cate, string spec, string exp_years, string exp_months, string current_ctc,
                             string expected_ctc, string jobtype, string BasicEducation, string curriculam_vitaeName,
                             string curriculam_vitaePath, string ajobid, DateTime pDate)
        {

           // SqlConnection conn = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
            try
            {
                con.Open();
                SqlTransaction trans = con.BeginTransaction();
                SqlParameter[] arParam = new SqlParameter[18];
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
                arParam[6] = new SqlParameter("@Category", SqlDbType.NVarChar, 50);
                arParam[6].Value = cate;
                arParam[7] = new SqlParameter("@Specialization", SqlDbType.NVarChar, 50);
                arParam[7].Value = spec;
                arParam[8] = new SqlParameter("@exp_years", SqlDbType.NVarChar, 50);
                arParam[8].Value = exp_years;
                arParam[9] = new SqlParameter("@exp_months", SqlDbType.NVarChar, 50);
                arParam[9].Value = exp_months;
                arParam[10] = new SqlParameter("@current_ctc", SqlDbType.NVarChar, 50);
                arParam[10].Value = current_ctc;
                arParam[11] = new SqlParameter("@expected_ctc", SqlDbType.NVarChar, 50);
                arParam[11].Value = expected_ctc;
                arParam[12] = new SqlParameter("@jobtype", SqlDbType.NVarChar, 50);
                arParam[12].Value = jobtype;
                arParam[13] = new SqlParameter("@BasicEducation", SqlDbType.NVarChar, 50);
                arParam[13].Value = BasicEducation;
                arParam[14] = new SqlParameter("@curriculam_vitaeName", SqlDbType.NVarChar, 100);
                arParam[14].Value = curriculam_vitaeName;
                arParam[15] = new SqlParameter("@curriculam_vitaePath", SqlDbType.NVarChar, 100);
                arParam[15].Value = curriculam_vitaePath;
                arParam[16] = new SqlParameter("@ajobid", SqlDbType.NVarChar, 50);
                arParam[16].Value = ajobid;
                arParam[17] = new SqlParameter("@cPostDate", SqlDbType.DateTime);
                arParam[17].Value = pDate;
                DBOperations.ExecuteNonQuery(trans, CommandType.StoredProcedure, "careers_insert", arParam);
                trans.Commit();
            }
            catch (Exception ex)
            {
                script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
            }
            finally
            {
                con.Close();
            }
            return true;

        }
        public bool PostDetails(string Title, string firstname, string lastname, string email, string landline_num,
                            string Cell_num, string cate, string spec, string exp_toyears, string exp_fromyears, string current_ctc,
                            string expected_ctc, string jobtype, string BasicEducation, string curriculam_vitaeName,
                            string curriculam_vitaePath, DateTime pDate, string uid)
        {

           // SqlConnection conn = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
            try
            {
                con.Open();
                SqlTransaction trans = con.BeginTransaction();
                SqlParameter[] arParam = new SqlParameter[18];
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
                arParam[6] = new SqlParameter("@Category", SqlDbType.NVarChar, 50);
                arParam[6].Value = cate;
                arParam[7] = new SqlParameter("@Specialization", SqlDbType.NVarChar, 50);
                arParam[7].Value = spec;
                arParam[8] = new SqlParameter("@exp_toyears", SqlDbType.NVarChar, 50);
                arParam[8].Value = exp_toyears;
                arParam[9] = new SqlParameter("@exp_fromyears", SqlDbType.NVarChar, 50);
                arParam[9].Value = exp_fromyears;
                arParam[10] = new SqlParameter("@current_ctc", SqlDbType.NVarChar, 50);
                arParam[10].Value = current_ctc;
                arParam[11] = new SqlParameter("@expected_ctc", SqlDbType.NVarChar, 50);
                arParam[11].Value = expected_ctc;
                arParam[12] = new SqlParameter("@jobtype", SqlDbType.NVarChar, 50);
                arParam[12].Value = jobtype;
                arParam[13] = new SqlParameter("@BasicEducation", SqlDbType.NVarChar, 50);
                arParam[13].Value = BasicEducation;
                arParam[14] = new SqlParameter("@curriculam_vitaeName", SqlDbType.NVarChar, 100);
                arParam[14].Value = curriculam_vitaeName;
                arParam[15] = new SqlParameter("@curriculam_vitaePath", SqlDbType.NVarChar, 100);
                arParam[15].Value = curriculam_vitaePath;
                arParam[16] = new SqlParameter("@cPostDate", SqlDbType.DateTime);
                arParam[16].Value = pDate;
                arParam[17] = new SqlParameter("@userid", SqlDbType.NVarChar, 50);
                arParam[17].Value = uid;
                DBOperations.ExecuteNonQuery(trans, CommandType.StoredProcedure, "careers_postdetailsSp", arParam);
                trans.Commit();
            }
            catch (Exception ex)
            {
                script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
            }
            finally
            {
                con.Close();
            }
            return true;

        }
        public bool submitfeedback(string uname, string Eaddress, string mobilenum, string ustate,
                                    string ucity, string fback, DateTime postdate)
        {
            //SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
            try
            {
                con.Open();
                SqlTransaction mytrans = con.BeginTransaction();
                SqlParameter[] myparam = new SqlParameter[7];
                myparam[0] = new SqlParameter("@name", SqlDbType.NVarChar, 50);
                myparam[0].Value = uname;
                myparam[1] = new SqlParameter("@emailaddress", SqlDbType.NVarChar, 50);
                myparam[1].Value = Eaddress;
                myparam[2] = new SqlParameter("@mobile_num", SqlDbType.NVarChar, 50);
                myparam[2].Value = mobilenum;
                myparam[3] = new SqlParameter("@state", SqlDbType.NVarChar);
                myparam[3].Value = ustate;
                myparam[4] = new SqlParameter("@city", SqlDbType.NVarChar);
                myparam[4].Value = ucity;
                myparam[5] = new SqlParameter("@feedback", SqlDbType.NVarChar);
                myparam[5].Value = fback;
                myparam[6] = new SqlParameter("@cPostDate", SqlDbType.DateTime);
                myparam[6].Value = postdate;
                DBOperations.ExecuteNonQuery(mytrans, CommandType.StoredProcedure, "career_submitfeedback", myparam);
                mytrans.Commit();
            }
            catch (Exception ex)
            {
                script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
            }
            finally
            {
                con.Close();
            }
            return true;

        }
        public bool FillDrop(System.Web.UI.WebControls.DropDownList dp, string stm, string ValueFld, string TextFld, string dfltTxt)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(stm, con);
            SqlDataReader rdr = cmd.ExecuteReader();
            try
            {
                dp.DataValueField = ValueFld;
                dp.DataTextField = TextFld;
                dp.DataSource = rdr;
                dp.DataBind();
            }
            catch (Exception ex)
            {
                script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
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
                con.Close();
            }
            return true;
        }
        //To populate Drop Down List with 
        public void FillCareers_Category(DropDownList dpc)
        {
            try
            {
                FillDrop(dpc, "select * from Careers_Category", "Category", "Category", "----- Select -----");
            }
            catch (Exception ex)
            {
                script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
            }
        }
        public void FillCareers_JobType(DropDownList dpc)
        {
            try
            {
                FillDrop(dpc, "select * from Careers_JobType", "JobType", "JobType", "----- Select -----");
            }
            catch (Exception ex)
            {
                script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
            }
        }
        public void FillCareers_ExpYr(DropDownList dpc)
        {
            try
            {
                FillDrop(dpc, "select * from Careers_ExpYr", "expyr", "expyr", "--Select--");
            }
            catch (Exception ex)
            {
                script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
            }
        }
        public void FillCareers_AdminSalRange(DropDownList dpc)
        {
            try
            {
                FillDrop(dpc, "select * from Careers_SalRange", "salrange", "salrange", "----- Select -----");
            }
            catch (Exception ex)
            {
                script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
            }
        }
        public void FillCareers_Education(DropDownList dpc)
        {
            try
            {
                FillDrop(dpc, "select * from Careers_Education", "Education", "Education", "----- Select -----");
            }
            catch (Exception ex)
            {
                script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
            }
        }
        public void FillCareers_AdminSalRange1(DropDownList dpc)
        {
            try
            {
                FillDrop(dpc, "select * from Careers_SalRange where sid between 2 and 31", "salrange", "salrange", "----- Select -----");
            }
            catch (Exception ex)
            {
                script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
            }
        }
        public DataSet bindjobAppliersdata(Int16 Id)
        {
            try
            {
                string qry = "select * from careers_resume where ajobid=" + Id;
                ds = obj.ExcuteQry(qry);
            }
            catch (Exception ex)
            {
                script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
            }
            return ds;
        }
        public DataSet bindjobAppliersresdata(Int16 Id)
        {
            try
            {
                string qry = "select * from careers_resume where Jobid=" + Id;
                ds = obj.ExcuteQry(qry);
            }
            catch (Exception ex)
            {
                script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
            }
            return ds;
        }
        public DataSet Hyd_Location(string loc)
        {
            try
            {
                string qry = "select Distinct(comp_city) from careers_contInformation";
                ds = obj.ExcuteQry(qry);
            }
            catch (Exception ex)
            {
                script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
            }
            return ds;
        }
        public Int32 CheckResumeName(string resumename)
        {
            Int32 count = 0;
            try
            {
                //SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
                con.Open();
                SqlCommand sqlcmd = new SqlCommand("select count(*) from careers_resume where curriculam_vitaeName = '" + resumename + "'", con);
                 count = Convert.ToInt32(sqlcmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
            }
            finally
            {
                con.Close();

            }
            return count;
        }
        public Int32 CheckPostResumeName(string resumename)
        {
            Int32 count = 0;
            try
            {
                //SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
                con.Open();
                SqlCommand sqlcmd = new SqlCommand("select count(*) from careers_PostResume where curriculam_vitaeName = '" + resumename + "'", con);
                count = Convert.ToInt32(sqlcmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
            }
            finally
            {
                con.Close();
            }
            return count;
        }
        
        public DataSet bindnoofJobApplicants(Int16 Id)
        {
            try
            {
                string qry = "select c.*,count(ajobid) as applications from careers_resume as pr full outer join jcalluzcareers as c on c.jobid=pr.ajobid where c.jobid=" + Id +
                         " group by c.jobid,c.title,c.category,c.specialization,c.jobType,c.jobStatus,c.workExp,c.salRange,c.noOfvacancies,c.jobDesc,c.computerknowledge,c.qualification," +
                         "c.comp_address1,c.comp_address2,c.comp_city,c.comp_state,c.comp_pincode,c.contpersonName,c.cont_email,c.cont_phone,c.cont_ext,c.post_date,c.expire_date";
               ds = obj.ExcuteQry(qry);

            }
            catch (Exception ex)
            {
                script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
            }
            return ds;
        }
        public DataSet bindperticularApplicantResumeName(Int32 Id)
        {
            try
            {
                string qry = "select * from careers_resume where Jobid=" + Id;
                ds = obj.ExcuteQry(qry);
            }
            catch (Exception ex)
            {
                script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
            }
            return ds;
        }
        public DataSet bindResumesPostedDirectly()
        {
            try
            {
                string qry = "select cp.*,count(jobid) as jobs from jcalluzcareers as career right outer join careers_PostResume as cp on career.category=cp.Category "
                            + "group by cp.id,cp.Title,cp.firstname,cp.lastname,cp.email,cp.landline_num,cp.Cell_num,"
                            + "cp.Category,cp.Specialization,cp.exp_toyears,cp.exp_fromyears,cp.current_ctc,cp.expected_ctc,cp.jobtype,cp.BasicEducation,"
                            + "cp.curriculam_vitaeName,cp.curriculam_vitaePath,cp.cPostDate,cp.userid";
               ds = obj.ExcuteQry(qry);
            }
            catch (Exception ex)
            {
                script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
            }
            return ds;
        }       
        public DataSet bindparticularResumePostedDirectly(Int16 id)
        {
            try
            {
                string qry = "select * from careers_PostResume where id=" + id;
                ds = obj.ExcuteQry(qry);
            }
            catch (Exception ex)
            {
                script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
            }
            return ds;
        }
        public DataTable GetRelatedJobsforCat(string cat)
        {
            DataTable dt = new DataTable();
            try
            {
                string qry = "select *,convert(varchar,expire_date,105) as expiredate, convert(varchar,post_date,105) as postdate from jcalluzCareers where category='" + cat + "'";
                dt = obj.ExcuteQrydt(qry);

            }
            catch (Exception ex)
            {
                script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
            }
            return dt;
        }
        public DataSet GetRelatedJobsforCatDS(string cat)
        {
            try
            {
                string qry = "select *,convert(varchar,expire_date,105) as expiredate, convert(varchar,post_date,105) as postdate from jcalluzCareers where category='" + cat + "'";
                ds = obj.ExcuteQry(qry);
            }
            catch (Exception ex)
            {
                script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
            }
            return ds;
        }
        public DataSet CheckCareerExpiry(string cat)
        {
            try
            {
                string qry = "select * from jcalluzCareers where category='" + cat + "'";
                ds = obj.ExcuteQry(qry);
            }
            catch (Exception ex)
            {
                script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
            }
            return ds;
        }   
        public Int32 DeleteCareers(Int32 Id)
        {
            Int32 count = 0;
            try
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
                con.Open();
                SqlCommand sqlcmd = new SqlCommand("delete from jcalluzcareers where jobid=" + Id, con);
                 count = Convert.ToInt32(sqlcmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
            }
            finally
            {
                con.Close();

            }
            return count;
        }
         //careers
        public DataSet Location(string loc)
        {
            
            try
            {
                string qry = "select Distinct(comp_city) from jcalluzCareers";
                ds = obj.ExcuteQry(qry);
            }
            catch (Exception ex)
            {
                script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
            }
            return ds;
        }
        public DataSet careersinfo(int id)
        {
           
            try
            {
                string qry = "select *,posttime=convert(varchar,post_date, 105),exptime=Convert(varchar,dateadd(dd,-1,convert(varchar,expire_date,106)),105) from jcalluzCareers where jobid=" + id;
                ds = obj.ExcuteQry(qry);

            }
            catch (Exception ex)
            {
                script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
            }
            return ds;
        }
        public DataSet GetJobDetails(string id)
        {
           
            try
            {
                string qry = "select * from jcalluzCareers  where jobid ='" + id + "'";
                ds = obj.ExcuteQry(qry);
            }
            catch (Exception ex)
            {
                script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
            }
            return ds;
        }
        public DataSet GetJobs(string fname)
        {
            
            try
            {
                string qry = "SELECT * from jcalluzCareers where comp_city like '%" + fname + "%' order by jobid desc";
                ds = obj.ExcuteQry(qry);

            }
            catch (Exception ex)
            {
                script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
            }
            return ds;
        }
        public DataSet BindCountTitles()
        {
          
            try
            {
                string qry = "select category,count(title) as Count_jobs from jcalluzCareers group by category";
                ds = obj.ExcuteQry(qry);
            }
            catch (Exception ex)
            {
                script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
            }
            return ds;
        }
        public DataSet getCategories(string Cate)
        {
            try
            {
                string qry = "select *,posttime=convert(varchar,post_date, 105) from jcalluzCareers where category ='" + Cate + "' order by jobid desc";
                ds = obj.ExcuteQry(qry);
            }
            catch (Exception ex)
            {
                script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
            }
            return ds;
        }
        public DataSet getTitleOrder(string category,DateTime current)
        {
           try
            {
                string qry = "select *,posttime=convert(varchar,post_date, 105) from jcalluzCareers where category='" + category + "' and expire_date>='" + current + "' order by title desc";
                ds = obj.ExcuteQry(qry);

            }
            catch (Exception ex)
            {
                script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
            }
            return ds;
        }
        public DataSet getJTypeOrder(string category,DateTime current)
        {
           
            try
            {
                string qry = "select *,posttime=convert(varchar,post_date, 105) from jcalluzCareers where category='" + category + "' and expire_date>='" + current + "' order by jobType desc";
                ds = obj.ExcuteQry(qry);
            }
            catch (Exception ex)
            {
                script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
            }
            return ds;
        }
        public DataSet getJStatusOrder(string category,DateTime current)
        {
                     
            try
            {
                string qry = "select *,posttime=convert(varchar,post_date, 105) from jcalluzCareers where category='" + category + "' and expire_date>='" + current + "' order by jobStatus desc";
                ds = obj.ExcuteQry(qry);
            }
            catch (Exception ex)
            {
                script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
            }
            return ds;
        }
        public DataSet getSalRangeOrder(string category,DateTime current)
        {
           try
            {
                string qry = "select *,posttime=convert(varchar,post_date, 105) from jcalluzCareers where category='" + category + "' and expire_date>='" + current + "' order by salRange desc";
                ds = obj.ExcuteQry(qry);
            }
            catch (Exception ex)
            {
                script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
            }
            return ds;
        }
        public DataSet getPDateOrder(string category,DateTime current)
        {
           try
            {
                string qry = "select *,posttime=convert(varchar,post_date, 105) from jcalluzCareers where category='" + category + "' and expire_date>='" + current + "' order by posttime desc";
                ds = obj.ExcuteQry(qry);
            }
            catch (Exception ex)
            {
                script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
            }
            return ds;
        }
        public DataSet GetStates()
        {
           try
            {
                string qry = "select sid,state_name from States";
                ds = obj.ExcuteQry(qry);

            }
            catch (Exception ex)
            {
                script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
            }
            return ds;
        }
        public DataSet GetCities(string statename)
        {
           try
            {
                string qry = "select city_name from Cities where state_name='" + statename + "'";
                ds = obj.ExcuteQry(qry);
            }
            catch (Exception ex)
            {
                script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
            }
            return ds;
        }
        public DataSet GetEmails(string cmpCity)
        {
           try
            {
                string qry = "select Distinct(cont_email),comp_city from careers_contInformation where comp_city ='" + cmpCity + "'";
                ds = obj.ExcuteQry(qry);
            }
            catch (Exception ex)
            {
                script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
            }
            return ds;
        }
        public DataSet GetContpersonName(string cmpCity1)
        {
            try
            {
                string qry = "select Distinct(contpersonName),comp_city from careers_contInformation where comp_city ='" + cmpCity1 + "'";
                ds = obj.ExcuteQry(qry);
            }
            catch (Exception ex)
            {
                script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
            }
             return ds;
        }
        public DataSet GetAddressInfo(string cmpCity2)
        {
            try
            {
                string qry = "select id,comp_address1,comp_address2,comp_city,comp_state,comp_pincode,cont_num,cont_ext,time from careers_contInformation where comp_city ='" + cmpCity2 + "'";
                ds = obj.ExcuteQry(qry);
            }
            catch (Exception ex)
            {
                script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
            }

            return ds;
        }
        public DataSet GetSubCate(string categoryname)
        {
            try
            {
                string qry = "select SubCat from  Careers_SubCat where Cat='" + categoryname + "'";
                ds = obj.ExcuteQry(qry);
            }
            catch (Exception ex)
            {
                script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
            }
            return ds;
        }    
    }
}
