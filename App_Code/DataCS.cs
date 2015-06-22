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
using IndusAbroad.DataAccessLayer;
using System.Data.SqlClient;
using System.Net;
using System.Net.NetworkInformation;
using System.Management;
using System.Management.Instrumentation;
using System.Security;
using System.Security.Permissions;
using System.IO;
using System.Runtime.Serialization;

[assembly: System.Security.AllowPartiallyTrustedCallers]
namespace JustCallUsData.Data
{
    
    /// <summary>
    /// Summary description for DataCS
    /// </summary>
    public class DataCS
    {
        public DataAccess obj = new DataAccess();
        SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
        DataSet ds = new DataSet();
        string script = string.Empty;
        public DataCS()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        private int Id;
        private string Module;
        private string Category;
        private string SubCategory;
        private string SubCategory_Other;
        private string State;
        private string City;
        private string Area;
        private string Company_Name;
        private string Industry;
        private string Fun_Area;
        private string Role;
        private string Qualification;
        private string Age;
        private string Exp;
        private string Sal;
        private string Job_Desc;        
        private string Skills;
        private DateTime Job_Expiry;
        private string Company_Profile;
        private string EventName;
        private string EventPlace;
        private string EventDurationType;
        private DateTime StartDate;
        private DateTime EndDate;
        private string Description;
        private string TimeDuration;
        private string Address;
        private string LandMark;
        private string Contact_Person;
        private string Email;
        private string PhNumber;
        private string Mobile;
        private string FaxNo;
        private string WebSite;
        private DateTime PostDate;
        private DateTime ExpDate;
        private string PinCode;
        private string ImgName;
        private string ImgContentType;
        private string LoginId;
        private string SpecifyIfAny;
        private string CatSub;

        private string Monday; 
	    private string Mon_Dur; 
        private string Tuesday;	
        private string Tues_Dur; 
        private string Wednesday; 
        private string Wed_Dur;
        private string Thursday;
        private string Thurs_Dur; 
        private string Friday;
        private string Fri_Dur; 
        private string Saturday;
        private string Satur_Dur;
        private string Sunday;
        private string Sun_Dur;
        private string Payment;
        private string AdtInfo;
        private string YearEstab;
        private string Prof_Accosi;
        private string certification;
        private string NoofEmp;
        private string Caption;
        private string PostedBy;        
	
        public int pId
        {
            get { return Id; }
            set { Id = value; }
        }
        public string dModule
        {
            get { return Module; }
            set { Module = value; }

        }
        public string dCategory
        {
            get { return Category; }
            set { Category = value; }

        }
        public string dSubCategory
        {
            get { return SubCategory; }
            set { SubCategory = value; }

        }
        public string dSubCategory_Other
        {
            get { return SubCategory_Other; }
            set { SubCategory_Other = value; }

        }
        public string dState
        {
            get { return State; }
            set { State = value; }

        }
        public string dCity
        {
            get { return City; }
            set { City = value; }

        }
        public string dArea
        {
            get { return Area; }
            set { Area = value; }

        }
        public string jcdCompany_Name
        {
            get { return Company_Name; }
            set { Company_Name = value; }
        }
        public string jIndustry
        {
            get { return Industry; }
            set { Industry = value; }

        }
        public string jFun_Area
        {
            get { return Fun_Area; }
            set { Fun_Area = value; }

        }
        public string jRole
        {
            get { return Role; }
            set { Role = value; }

        }
        public string jQualification
        {
            get { return Qualification; }
            set { Qualification = value; }

        }
        public string jAge
        {
            get { return Age; }
            set { Age = value; }

        }
        public string jExp
        {
            get { return Exp; }
            set { Exp = value; }

        }
        public string jSal
        {
            get { return Sal; }
            set { Sal = value; }

        }
        public string jJob_Desc
        {
            get { return Job_Desc; }
            set { Job_Desc = value; }

        }
        public string jSkills
        {
            get { return Skills; }
            set { Skills = value; }

        }
        public DateTime jJob_Expiry
        {
            get { return Job_Expiry; }
            set { Job_Expiry = value; }

        }
        public string jcdCompany_Profile
        {
            get { return Company_Profile; }
            set { Company_Profile = value; }

        }
        public string eEventName
        {
            get { return EventName; }
            set { EventName = value; }

        }
        public string eEventPlace
        {
            get { return EventPlace; }
            set { EventPlace = value; }

        }
        public string ediDurationType
        {
            get { return EventDurationType; }
            set { EventDurationType = value; }

        }
        public DateTime ediStartDate
        {
            get { return StartDate; }
            set { StartDate = value; }

        }
        public DateTime ediEndDate
        {
            get { return EndDate; }
            set { EndDate = value; }

        }
        public string ediDescription
        {
            get { return Description; }
            set { Description = value; }

        }
        public string ediTimeDuration
        {
            get { return TimeDuration; }
            set { TimeDuration = value; }

        }
        public string dAddress
        {
            get { return Address; }
            set { Address = value; }

        }
        public string dLandMark
        {
            get { return LandMark; }
            set { LandMark = value; }

        }
        public string dPinCode
        {
            get { return PinCode; }
            set { PinCode = value; }

        }
        public string dContact_Person
        {
            get { return Contact_Person; }
            set { Contact_Person = value; }

        }
        public string dEmail
        {
            get { return Email; }
            set { Email = value; }

        }
        public string dPhNumber
        {
            get { return PhNumber; }
            set { PhNumber = value; }

        }
        public string dMobile
        {
            get { return Mobile; }
            set { Mobile = value; }

        }
        public string dFaxNo
        {
            get { return FaxNo; }
            set { FaxNo = value; }

        }
        public string dWebSite
        {
            get { return WebSite; }
            set { WebSite = value; }

        }
        public string dLoginId
        {
            get { return LoginId; }
            set { LoginId = value; }

        }
        public DateTime dPostDate
        {
            get { return PostDate; }
            set { PostDate = value; }
        }
        public DateTime dExpDate
        {
            get { return ExpDate; }
            set { ExpDate = value; }
        }
        public string dImgName
        {
            get { return ImgName; }
            set { ImgName = value; }

        }
        public string dImgContType
        {
            get { return ImgContentType; }
            set { ImgContentType = value; }

        }
        public string dSpecifyIfAny
        {
            get { return SpecifyIfAny; }
            set { SpecifyIfAny = value; }

        }
        public string dCatSub
        {
            get { return CatSub; }
            set { CatSub = value; }

        }
        public string dMonday
        {
            get { return Monday ; }
            set { Monday = value; }

        }
        public string dMon_Dur
        {
            get { return Mon_Dur ; }
            set { Mon_Dur = value; }

        }
        public string dTuesday
        {
            get { return Tuesday ; }
            set { Tuesday = value; }

        }
        public string dTues_Dur
        {
            get { return Tues_Dur ; }
            set { Tues_Dur = value; }

        }
        public string dWednesday
        {
            get { return Wednesday ; }
            set { Wednesday = value; }

        }
        public string dWed_Dur
        {
            get { return Wed_Dur ; }
            set { Wed_Dur = value; }

        }
        public string dThursday
        {
            get { return Thursday ; }
            set { Thursday = value; }

        }
        public string dThurs_Dur
        {
            get { return Thurs_Dur ; }
            set { Thurs_Dur = value; }

        }
        public string dFriday
        {
            get { return Friday ; }
            set { Friday = value; }

        }
        public string dFri_Dur
        {
            get { return Fri_Dur ; }
            set { Fri_Dur = value; }

        }
        public string dSaturday
        {
            get { return Saturday ; }
            set { Saturday = value; }

        }
        public string dSatur_Dur
        {
            get { return Satur_Dur ; }
            set { Satur_Dur = value; }

        }
        public string dSunday
        {
            get { return Sunday ; }
            set { Sunday = value; }

        }
        public string dSun_Dur
        {
            get { return Sun_Dur ; }
            set { Sun_Dur = value; }

        }
        public string dPayment
        {
            get { return Payment; }
            set { Payment = value; }

        }
        public string dAdtInfo
        {
            get { return AdtInfo; }
            set { AdtInfo = value; }

        }
        public string dYearEstab
        {
            get { return YearEstab; }
            set { YearEstab = value; }

        }
        public string dProf_Accosi
        {
            get { return Prof_Accosi; }
            set { Prof_Accosi = value; }

        }
        public string dcertification
        {
            get { return certification; }
            set { certification = value; }

        }
        public string dNoofEmp
        {
            get { return NoofEmp; }
            set { NoofEmp = value; }

        }
        public string dCaption
        {
            get { return Caption; }
            set { Caption = value; }

        }
        public string dPostedBy
        {
            get { return PostedBy; }
            set { PostedBy = value; }

        }
         //White Pages

        Int32 wpId;
        string Para1;
        string Para2;
        string Para3;
        string Para4;
        string Para5;
        string wpCity;

        public Int32 awpId
        {
            get { return wpId; }
            set { wpId = value; }
        }
        public string aPara1
        {
            get { return Para1; }
            set { Para1 = value; }
        }
        public string aPara2
        {
            get { return Para2; }
            set { Para2 = value; }
        }
        public string aPara3
        {
            get { return Para3; }
            set { Para3 = value; }
        }
        public string aPara4
        {
            get { return Para4; }
            set { Para4 = value; }
        }
        public string aPara5
        {
            get { return Para5; }
            set { Para5 = value; }
        }
        public string awpCity
        {
            get { return wpCity; }
            set { wpCity = value; }
        }
        //JcReverseAuction
        private string Jname1;
        private string Jemail1;
        private string Jph1;
        private string Jcompanyname1;
        private string Jadid1;
        private string Jtype1;
        private string Jip_address1;
        private DateTime Jpostdate1;        

        //JcReverseAuction properties
        public string Jname
        {
            get { return Jname1; }
            set { Jname1 = value; }
        }
        public string Jemail
        {
            get { return Jemail1; }
            set { Jemail1 = value; }
        }
        public string Jph
        {
            get { return Jph1; }
            set { Jph1 = value; }
        }
        public string Jcompanyname
        {
            get { return Jcompanyname1; }
            set { Jcompanyname1 = value; }
        }
        public string Jadid
        {
            get { return Jadid1; }
            set { Jadid1 = value; }
        }
        public string Jtype
        {
            get { return Jtype1; }
            set { Jtype1 = value; }
        }
        public string Jip_address
        {
            get { return Jip_address1; }
            set { Jip_address1 = value; }
        }
        public DateTime Jpostdate
        {
            get { return Jpostdate1; }
            set { Jpostdate1 = value; }
        }
        string str = string.Empty;


        //Reports
        private string ReportType;
        private string IPAddress;
        private string PhysicalAddress;
        private string Comment;
        public string dReportType
        {
            get { return ReportType; }
            set { ReportType = value; }
        }
        public string dIPAddress
        {
            get { return IPAddress; }
            set { IPAddress = value; }
        }
        public string dPhysicalAddress
        {
            get { return PhysicalAddress; }
            set { PhysicalAddress = value; }
        }
        public string dComment
        {
            get { return Comment; }
            set { Comment = value; }
        }
         public bool Data_Insert(string Module, string Category, string SubCategory, string SubCategory_Other, string State, string City, string Area, string Company_Name,
                                string Industry, string Fun_Area, string Role, string Qualification,string Age, string Exp, string Sal,
                                string Job_Desc, string Skills,DateTime JobExpiry, string Company_Profile, string EventName, string EventPlace,string EventDurationType,
                                DateTime StartDate, DateTime EndDate, string Description, string TimeDuration, string Address,
                                string LandMark, string Contact_Person, string Email, string PhNumber,string Mobile,
                                string FaxNo,string WebSite, DateTime PostDate, DateTime ExpDate,string Pincode,string LoginId,string ImgName,string ImgContentType,string CatSub)
        {
            try
            {

                //SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
                connection.Open();
                SqlTransaction myTrans = connection.BeginTransaction();
                SqlParameter[] arParms = new SqlParameter[42];

                arParms[0] = new SqlParameter("@DModule", SqlDbType.NVarChar);
                arParms[0].Value = Module;
                arParms[1] = new SqlParameter("@DCategory", SqlDbType.NVarChar);
                arParms[1].Value = Category;
                arParms[2] = new SqlParameter("@DSubCat", SqlDbType.NVarChar);
                arParms[2].Value = SubCategory;
                arParms[3] = new SqlParameter("@DState", SqlDbType.NVarChar);
                arParms[3].Value = State;
                arParms[4] = new SqlParameter("@DCity", SqlDbType.NVarChar);
                arParms[4].Value = City;
                arParms[5] = new SqlParameter("@DCompName", SqlDbType.NVarChar);
                arParms[5].Value = Company_Name;
                arParms[6] = new SqlParameter("@JIndustry", SqlDbType.NVarChar);
                arParms[6].Value = Industry;
                arParms[7] = new SqlParameter("@JFunArea", SqlDbType.NVarChar);
                arParms[7].Value = Fun_Area;
                arParms[8] = new SqlParameter("@JRole", SqlDbType.NVarChar);
                arParms[8].Value = Role;
                arParms[9] = new SqlParameter("@JQualification", SqlDbType.NVarChar);
                arParms[9].Value = Qualification;
                arParms[10] = new SqlParameter("@JExp", SqlDbType.NVarChar);
                arParms[10].Value = Exp;
                arParms[11] = new SqlParameter("@JSal", SqlDbType.NVarChar);
                arParms[11].Value = Sal;
                arParms[12] = new SqlParameter("@JJobDesc", SqlDbType.NVarChar);
                arParms[12].Value = Job_Desc;
                arParms[13] = new SqlParameter("@JSkills", SqlDbType.NVarChar);
                arParms[13].Value = Skills;
                arParms[14] = new SqlParameter("@DCompProfile", SqlDbType.NVarChar);
                arParms[14].Value = Company_Profile;
                arParms[15] = new SqlParameter("@EventName", SqlDbType.NVarChar);
                arParms[15].Value = EventName;
                arParms[16] = new SqlParameter("@EventPlace", SqlDbType.NVarChar);
                arParms[16].Value = EventPlace;
                if (StartDate == DateTime.MinValue)
                {
                    arParms[17] = new SqlParameter("@EDiStartDate", SqlDbType.DateTime);
                    arParms[17].Value = DBNull.Value;
                }
                else
                {
                    arParms[17] = new SqlParameter("@EDiStartDate", SqlDbType.DateTime);
                    arParms[17].Value = StartDate;
                }

                if (EndDate == DateTime.MinValue)
                {
                    arParms[18] = new SqlParameter("@EDiEndDate", SqlDbType.DateTime);
                    arParms[18].Value = DBNull.Value;
                }
                else
                {
                    arParms[18] = new SqlParameter("@EDiEndDate", SqlDbType.DateTime);
                    arParms[18].Value = EndDate;
                }
                arParms[19] = new SqlParameter("@EDiDesc", SqlDbType.NVarChar);
                arParms[19].Value = Description;
                arParms[20] = new SqlParameter("@EDiTime", SqlDbType.NVarChar);
                arParms[20].Value = TimeDuration;
                arParms[21] = new SqlParameter("@DAddress", SqlDbType.NVarChar);
                arParms[21].Value = Address;
                arParms[22] = new SqlParameter("@DLandMark", SqlDbType.NVarChar);
                arParms[22].Value = LandMark;
                arParms[23] = new SqlParameter("@DContPerson", SqlDbType.NVarChar);
                arParms[23].Value = Contact_Person;
                arParms[24] = new SqlParameter("@DEmail", SqlDbType.NVarChar);
                arParms[24].Value = Email;
                arParms[25] = new SqlParameter("@DPhNo", SqlDbType.NVarChar);
                arParms[25].Value = PhNumber;
                arParms[26] = new SqlParameter("@DMob", SqlDbType.NVarChar);
                arParms[26].Value = Mobile;
                arParms[27] = new SqlParameter("@DFax", SqlDbType.NVarChar);
                arParms[27].Value = FaxNo;
                arParms[28] = new SqlParameter("@DPostDate", SqlDbType.DateTime);
                arParms[28].Value = PostDate;
                arParms[29] = new SqlParameter("@DExpDate", SqlDbType.DateTime);
                arParms[29].Value = ExpDate;
                arParms[30] = new SqlParameter("@DSubCat_Other", SqlDbType.NVarChar);
                arParms[30].Value = SubCategory_Other;
                arParms[31] = new SqlParameter("@DArea", SqlDbType.NVarChar);
                arParms[31].Value = Area;
                arParms[32] = new SqlParameter("@EDiDurationType", SqlDbType.NVarChar);
                arParms[32].Value = EventDurationType;
                if (JobExpiry == DateTime.MinValue)
                {
                    arParms[33] = new SqlParameter("@JobExpiry", SqlDbType.DateTime);
                    arParms[33].Value = DBNull.Value;
                }
                else
                {
                    arParms[33] = new SqlParameter("@JobExpiry", SqlDbType.DateTime);
                    arParms[33].Value = JobExpiry;
                }
                arParms[34] = new SqlParameter("@JAge", SqlDbType.NVarChar);
                arParms[34].Value = jAge;
                arParms[35] = new SqlParameter("@DWebSite", SqlDbType.NVarChar);
                arParms[35].Value = WebSite;
                arParms[36] = new SqlParameter("@ApprovedStatus", SqlDbType.Int);
                arParms[36].Value = "1";
                arParms[37] = new SqlParameter("@pinCode", SqlDbType.NVarChar);
                arParms[37].Value = Pincode;
                arParms[38] = new SqlParameter("@loginId", SqlDbType.NVarChar);
                arParms[38].Value = LoginId;

                arParms[39] = new SqlParameter("@ImgName", SqlDbType.NVarChar);
                arParms[39].Value = ImgName;

                arParms[40] = new SqlParameter("@ImgContType", SqlDbType.NVarChar);
                arParms[40].Value = ImgContentType;

                arParms[41] = new SqlParameter("@CatSub", SqlDbType.NVarChar);
                arParms[41].Value = CatSub;
                DBOperations.ExecuteNonQuery(myTrans, CommandType.StoredProcedure, "Data_InsertSP", arParms);
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
        public bool Data_Update(int Id,string Module, string Category, string SubCategory, string SubCategory_Other, string State, string City, string Company_Name,
                                string Industry, string Fun_Area, string Role, string Qualification,string JAge, string Exp, string Sal,
                                string Job_Desc, string Skills,DateTime Job_Expiry, string Company_Profile, string EventName, string EventPlace,
                                DateTime StartDate, DateTime EndDate, string Description, string TimeDuration, string Address,
                                string LandMark,string PinCode, string Contact_Person, string Email, string PhNumber, string Mobile,
                                string FaxNo, string website, string CatSub, string Area, string EventDurationType,DateTime UpdateDate, string UpdatedBy)
        {
            try
            {

                //SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
                connection.Open();
                SqlTransaction myTrans = connection.BeginTransaction();
                SqlParameter[] arParms = new SqlParameter[39];

                arParms[0] = new SqlParameter("@DModule", SqlDbType.NVarChar);
                arParms[0].Value = Module;
                arParms[1] = new SqlParameter("@DCategory", SqlDbType.NVarChar);
                arParms[1].Value = Category;
                arParms[2] = new SqlParameter("@DSubCat", SqlDbType.NVarChar);
                arParms[2].Value = SubCategory;
                arParms[3] = new SqlParameter("@DState", SqlDbType.NVarChar);
                arParms[3].Value = State;
                arParms[4] = new SqlParameter("@DCity", SqlDbType.NVarChar);
                arParms[4].Value = City;
                arParms[5] = new SqlParameter("@DCompName", SqlDbType.NVarChar);
                arParms[5].Value = Company_Name;
                arParms[6] = new SqlParameter("@JIndustry", SqlDbType.NVarChar);
                arParms[6].Value = Industry;
                arParms[7] = new SqlParameter("@JFunArea", SqlDbType.NVarChar);
                arParms[7].Value = Fun_Area;
                arParms[8] = new SqlParameter("@JRole", SqlDbType.NVarChar);
                arParms[8].Value = Role;
                arParms[9] = new SqlParameter("@JQualification", SqlDbType.NVarChar);
                arParms[9].Value = Qualification;
                arParms[10] = new SqlParameter("@JExp", SqlDbType.NVarChar);
                arParms[10].Value = Exp;
                arParms[11] = new SqlParameter("@JSal", SqlDbType.NVarChar);
                arParms[11].Value = Sal;
                arParms[12] = new SqlParameter("@JJobDesc", SqlDbType.NVarChar);
                arParms[12].Value = Job_Desc;
                arParms[13] = new SqlParameter("@JSkills", SqlDbType.NVarChar);
                arParms[13].Value = Skills;
                arParms[14] = new SqlParameter("@DCompProfile", SqlDbType.NVarChar);
                arParms[14].Value = Company_Profile;
                arParms[15] = new SqlParameter("@EventName", SqlDbType.NVarChar);
                arParms[15].Value = EventName;
                arParms[16] = new SqlParameter("@EventPlace", SqlDbType.NVarChar);
                arParms[16].Value = EventPlace;
                if (StartDate == DateTime.MinValue)
                {
                    arParms[17] = new SqlParameter("@EDiStartDate", SqlDbType.DateTime);
                    arParms[17].Value = DBNull.Value;
                }
                else
                {
                    arParms[17] = new SqlParameter("@EDiStartDate", SqlDbType.DateTime);
                    arParms[17].Value = StartDate;
                }

                if (EndDate == DateTime.MinValue)
                {
                    arParms[18] = new SqlParameter("@EDiEndDate", SqlDbType.DateTime);
                    arParms[18].Value = DBNull.Value;
                }
                else
                {
                    arParms[18] = new SqlParameter("@EDiEndDate", SqlDbType.DateTime);
                    arParms[18].Value = EndDate;
                }
                arParms[19] = new SqlParameter("@EDiDesc", SqlDbType.NVarChar);
                arParms[19].Value = Description;
                arParms[20] = new SqlParameter("@EDiTime", SqlDbType.NVarChar);
                arParms[20].Value = TimeDuration;
                arParms[21] = new SqlParameter("@DAddress", SqlDbType.NVarChar);
                arParms[21].Value = Address;
                arParms[22] = new SqlParameter("@DLandMark", SqlDbType.NVarChar);
                arParms[22].Value = LandMark;
                arParms[23] = new SqlParameter("@DContPerson", SqlDbType.NVarChar);
                arParms[23].Value = Contact_Person;
                arParms[24] = new SqlParameter("@DEmail", SqlDbType.NVarChar);
                arParms[24].Value = Email;
                arParms[25] = new SqlParameter("@DPhNo", SqlDbType.NVarChar);
                arParms[25].Value = PhNumber;
                arParms[26] = new SqlParameter("@DMob", SqlDbType.NVarChar);
                arParms[26].Value = Mobile;
                arParms[27] = new SqlParameter("@DFax", SqlDbType.NVarChar);
                arParms[27].Value = FaxNo;
                arParms[28] = new SqlParameter("@DSubCat_Other", SqlDbType.NVarChar);
                arParms[28].Value = SubCategory_Other;
                if (Id != -1)
                {
                    arParms[29] = new SqlParameter("@id", SqlDbType.Int);
                    arParms[29].Value = Id;
                }
                else
                {
                    arParms[29] = new SqlParameter("@id", SqlDbType.Int);
                    arParms[29].Value = System.DBNull.Value;
                }

                arParms[30] = new SqlParameter("@DWebsite", SqlDbType.NVarChar);
                arParms[30].Value = website;
                arParms[31] = new SqlParameter("@DAge", SqlDbType.NVarChar);
                arParms[31].Value = JAge;
                if (Job_Expiry == DateTime.MinValue)
                {
                    arParms[32] = new SqlParameter("@DJExpireDate", SqlDbType.DateTime);
                    arParms[32].Value = DBNull.Value;
                }
                else
                {
                    arParms[32] = new SqlParameter("@DJExpireDate", SqlDbType.DateTime);
                    arParms[32].Value = Job_Expiry;
                }
                arParms[33] = new SqlParameter("@DPincode", SqlDbType.NVarChar);
                arParms[33].Value = PinCode;
                arParms[34] = new SqlParameter("@DCatSub", SqlDbType.NVarChar);
                arParms[34].Value = CatSub;
                arParms[35] = new SqlParameter("@DArea", SqlDbType.NVarChar);
                arParms[35].Value = Area;
                arParms[36] = new SqlParameter("@EDiDurationType", SqlDbType.NVarChar);
                arParms[36].Value = EventDurationType;
                arParms[37] = new SqlParameter("@DUpdateDate", SqlDbType.DateTime);
                arParms[37].Value = UpdateDate;
                arParms[38] = new SqlParameter("@UpdatedBy", SqlDbType.NVarChar);
                arParms[38].Value = UpdatedBy;

                DBOperations.ExecuteNonQuery(myTrans, CommandType.StoredProcedure, "Data_UpdateSP", arParms);
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
        public bool Data_Delete(int Id)
        {
            try
            {

                //SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
                connection.Open();
                SqlTransaction myTrans = connection.BeginTransaction();
                SqlParameter[] arParms = new SqlParameter[1];

                arParms[0] = new SqlParameter("@DataId", SqlDbType.Int);
                arParms[0].Value = Id;

                DBOperations.ExecuteNonQuery(myTrans, CommandType.StoredProcedure, "Data_DeleteSP", arParms);
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
                connection.Close();
            }
            return true;
        }
        //To populate Drop Down List with Modules
        public void FillModule(DropDownList dpc)
        {
            try
            {
            FillDrop(dpc, "select mod_id,module_name from Module order by module_name", "module_name", "module_name", "Select Module");
            }
            catch (Exception ex)
            {
                script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
            }
        }
        //To populate Drop Down List with States
        public void FillStates(DropDownList dpc)
        {
            try{
                FillDrop(dpc, "select sid,state_name from States order by state_name", "state_name", "state_name", "Select State");
            }
            catch (Exception ex)
            {
                script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
            }
        }
        //To populate Drop Down List with Languages
        public void FillLanguage(DropDownList dpc)
        {
            try
            {
                FillDrop(dpc, "select lid,Language_Name from Language order by Language_Name", "Language_Name", "Language_Name", "Select Movie Language");
            }
            catch (Exception ex)
            {
                script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
            }
        }
        public void FillTheatres(DropDownList dpc)
        {
            try
            {
                FillDrop(dpc, "select id,company_name from ModulesData where module='Movies' order by company_name", "id", "company_name", "Select Theatre");
            }
            catch (Exception ex)
            {
                script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
            }
        }
        //To populate Drop Down List with States
        public void FillCategory(DropDownList dpc)
        {
            try
            {
                FillDrop(dpc, "select id,Category from Categories where Module='Category' order by Category", "Category", "Category", "Select Category");
            }
            catch (Exception ex)
            {
                script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
            }
        }
        public void FillFreeListCat(DropDownList dpc)
        {
            try{
            FillDrop(dpc, "select id,category from FreeListing_Category order by category", "category", "category", "Select Lising");
            }
            catch (Exception ex)
            {
                script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
            }
        }
        public void FillB2BCategory(DropDownList dpc)
        {
            try
            {
            FillDrop(dpc, "select id,Category from Categories where Module='B2B Category' order by Category", "Category", "Category", "Select Category");
            }
            catch (Exception ex)
            {
                script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
            }
        }
        public void FillFreeListing(DropDownList dpc)
        {
            try{
            FillDrop(dpc, "select * from FreeListing_Category order by category", "category", "category", "Select Category");
            }
            catch (Exception ex)
            {
                script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
            }
        }
        
        public void FillLifeStyleCategory(DropDownList dpc)
        {
            try{
            FillDrop(dpc, "select id,cat from subcatageory where maincat='LifeStyle' order by cat", "cat", "cat", "Select Category");
            }
            catch (Exception ex)
            {
                script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
            }
        }
        public void FillPaymentMode(ListBox lstbox)
        {
            try{
                FillList(lstbox, "select * from PaymentModes order by Paymentmode", "Paymentmode", "Paymentmode");
            }
            catch (Exception ex)
            {
                script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
            }
        }
        public void FillIndustry(DropDownList dpc)
        {
            try{
                FillDrop(dpc, "select id,IndustryType from IndustryType order by IndustryType", "IndustryType", "IndustryType", "Select Industry");
            }
            catch (Exception ex)
            {
                script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
            }
        }
        public void FillFunctionalArea(DropDownList dpc)
        {
            try{
                FillDrop(dpc, "select id,FunArea from FunctionalArea order by FunArea", "FunArea", "FunArea", "Select Functional Area");
            }
            catch (Exception ex)
            {
                script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
            }
        }
        public void FillHours(DropDownList dpc)
        {
            try{
                FillDrop(dpc, "select * from Hours order by hours", "hours", "hours", "00");
            }
            catch (Exception ex)
            {
                script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
            }
        }
        public void FillMinutes(DropDownList dpc)
        {
            try{
                FillDrop(dpc, "select * from Minutes order by minutes", "minutes", "minutes", "00");
            }
            catch (Exception ex)
            {
                script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
            }
        }
        public void FillCompEstablishYr(DropDownList dpc)
        {
            try{
                FillDrop(dpc, "select * from CompanyEstablished order by yearEstablished", "yearEstablished", "yearEstablished", "Select Year");
            }
            catch (Exception ex)
            {
                script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
            }
        }
        public void FillCityTrends_Cat(DropDownList dpc)
        {
            try{
                FillDrop(dpc, "select * from Citytrends_Cat order by Category", "Category", "Category", "Select Module");
            }
            catch (Exception ex)
            {
                script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
            }
        } 
        //Fill popular cities for White pages
        public void FillPopularCities(DropDownList dpc)
        {
            try{
                FillDrop(dpc, "select popcities from pop_cities order by popcities", "popcities", "popcities", "Select City");
            }
            catch (Exception ex)
            {
                script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
            }
        }
        public void FillMonthNames(DropDownList dpc)
        {
            try{
                FillDrop(dpc, "select monthname from months", "monthname", "monthname", "Select Month");
            }
            catch (Exception ex)
            {
                script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
            }
        } 
        public bool FillList(System.Web.UI.WebControls.ListBox lst, string stm, string ValueFld, string TextFld)
        {
            
            connection.Open();
            SqlCommand cmd = new SqlCommand(stm, connection);
            SqlDataReader rdr = cmd.ExecuteReader();
            try
            {                
                lst.DataValueField = ValueFld;
                lst.DataTextField = TextFld;
                lst.DataSource = rdr;
                lst.DataBind();
            }
            finally
            {
                if (!(rdr == null))
                {
                    rdr.Close();
                }
                //dp.Items.Insert(0, dfltTxt);
                //lst.SelectedIndex = 0;
                cmd.Dispose();
                connection.Close();
            }
            return true;
        }
        public bool Advertise_Update(int Id, string Category, string SubCategory, string State, string City, string Company_Name,
                                string Company_Profile, string Address,string LandMark, string Contact_Person, string Email,
                                string PhNumber, string Mobile,string FaxNo,string Area,string Pincode,string website,string UserId)
        {
            try
            {

                //SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
                connection.Open();
                SqlTransaction myTrans = connection.BeginTransaction();
                SqlParameter[] arParms = new SqlParameter[19];

                arParms[0] = new SqlParameter("@Id", SqlDbType.Int);
                arParms[0].Value = Id;
                arParms[1] = new SqlParameter("@DCategory", SqlDbType.NVarChar);
                arParms[1].Value = Category;
                arParms[2] = new SqlParameter("@DSubCat", SqlDbType.NVarChar);
                arParms[2].Value = SubCategory;
                arParms[3] = new SqlParameter("@DState", SqlDbType.NVarChar);
                arParms[3].Value = State;
                arParms[4] = new SqlParameter("@DCity", SqlDbType.NVarChar);
                arParms[4].Value = City;
                arParms[5] = new SqlParameter("@DCompName", SqlDbType.NVarChar);
                arParms[5].Value = Company_Name;
                arParms[6] = new SqlParameter("@DCompProfile", SqlDbType.NVarChar);
                arParms[6].Value = Company_Profile;
                arParms[7] = new SqlParameter("@DAddress", SqlDbType.NVarChar);
                arParms[7].Value = Address;
                arParms[8] = new SqlParameter("@DLandMark", SqlDbType.NVarChar);
                arParms[8].Value = LandMark;
                arParms[9] = new SqlParameter("@DContPerson", SqlDbType.NVarChar);
                arParms[9].Value = Contact_Person;
                arParms[10] = new SqlParameter("@DEmail", SqlDbType.NVarChar);
                arParms[10].Value = Email;
                arParms[11] = new SqlParameter("@DPhNo", SqlDbType.NVarChar);
                arParms[11].Value = PhNumber;
                arParms[12] = new SqlParameter("@DMob", SqlDbType.NVarChar);
                arParms[12].Value = Mobile;
                arParms[13] = new SqlParameter("@DFax", SqlDbType.NVarChar);
                arParms[13].Value = FaxNo;
                arParms[14] = new SqlParameter("@DArea", SqlDbType.NVarChar);
                arParms[14].Value = Area;
                arParms[15] = new SqlParameter("@DPincode", SqlDbType.NVarChar);
                arParms[15].Value = Pincode;
                arParms[16] = new SqlParameter("@DWebSite", SqlDbType.NVarChar);
                arParms[16].Value = website;
                arParms[17] = new SqlParameter("@DStatus", SqlDbType.Int);
                arParms[17].Value = "3";
                arParms[18] = new SqlParameter("@DUserId", SqlDbType.NVarChar);
                arParms[18].Value = UserId;

                DBOperations.ExecuteNonQuery(myTrans, CommandType.StoredProcedure, "Advertise_Update", arParms);
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
        public bool FreeListing_Update(int Id, string Category, string SubCategory, string State, string City, string Company_Name,
                                string Address, string LandMark, string Contact_Person, string Email,
                                string PhNumber, string Mobile, string SpecifAny, string Area, string Pincode, string website, string UserId)
        {
            try
            {

                //SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
                connection.Open();
                SqlTransaction myTrans = connection.BeginTransaction();
                SqlParameter[] arParms = new SqlParameter[18];

                arParms[0] = new SqlParameter("@Id", SqlDbType.Int);
                arParms[0].Value = Id;
                arParms[1] = new SqlParameter("@DCategory", SqlDbType.NVarChar);
                arParms[1].Value = Category;
                arParms[2] = new SqlParameter("@DSubCat", SqlDbType.NVarChar);
                arParms[2].Value = SubCategory;
                arParms[3] = new SqlParameter("@DState", SqlDbType.NVarChar);
                arParms[3].Value = State;
                arParms[4] = new SqlParameter("@DCity", SqlDbType.NVarChar);
                arParms[4].Value = City;
                arParms[5] = new SqlParameter("@DCompName", SqlDbType.NVarChar);
                arParms[5].Value = Company_Name;
                arParms[6] = new SqlParameter("@DAddress", SqlDbType.NVarChar);
                arParms[6].Value = Address;
                arParms[7] = new SqlParameter("@DLandMark", SqlDbType.NVarChar);
                arParms[7].Value = LandMark;
                arParms[8] = new SqlParameter("@DContPerson", SqlDbType.NVarChar);
                arParms[8].Value = Contact_Person;
                arParms[9] = new SqlParameter("@DEmail", SqlDbType.NVarChar);
                arParms[9].Value = Email;
                arParms[10] = new SqlParameter("@DPhNo", SqlDbType.NVarChar);
                arParms[10].Value = PhNumber;
                arParms[11] = new SqlParameter("@DMob", SqlDbType.NVarChar);
                arParms[11].Value = Mobile;
                arParms[12] = new SqlParameter("@DSpecifany", SqlDbType.NVarChar);
                arParms[12].Value = SpecifAny;
                arParms[13] = new SqlParameter("@DArea", SqlDbType.NVarChar);
                arParms[13].Value = Area;
                arParms[14] = new SqlParameter("@DPincode", SqlDbType.NVarChar);
                arParms[14].Value = Pincode;
                arParms[15] = new SqlParameter("@DWebSite", SqlDbType.NVarChar);
                arParms[15].Value = website;
                arParms[16] = new SqlParameter("@DStatus", SqlDbType.Int);
                arParms[16].Value = "3";
                arParms[17] = new SqlParameter("@DUserId", SqlDbType.NVarChar);
                arParms[17].Value = UserId;

                DBOperations.ExecuteNonQuery(myTrans, CommandType.StoredProcedure, "edit_Freelistingform", arParms);
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
        public bool MoreInfo_Insert(string Monday, string Mon_Dur, string Tuesday, string Tues_Dur, string Wednesday, string Wed_Dur,
                                    string Thursday, string Thurs_Dur, string Friday, string Fri_Dur, string Saturday, string Satur_Dur, string Sunday, string Sun_Dur, int dataid, string PaymentMode, string AdtInfo, string YrEst, string profAssoc, string certifi, string NoofEmployees)
        {
            try
            {

                //SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
                connection.Open();
                SqlTransaction myTrans = connection.BeginTransaction();
                SqlParameter[] arParms = new SqlParameter[21];

                arParms[0] = new SqlParameter("@dId", SqlDbType.Int);
                arParms[0].Value = dataid;
                arParms[1] = new SqlParameter("@dMonday", SqlDbType.NVarChar);
                arParms[1].Value = Monday;
                arParms[2] = new SqlParameter("@dMon_Dur", SqlDbType.NVarChar);
                arParms[2].Value = Mon_Dur;
                arParms[3] = new SqlParameter("@dTuesday", SqlDbType.NVarChar);
                arParms[3].Value = Tuesday;
                arParms[4] = new SqlParameter("@dTues_Dur", SqlDbType.NVarChar);
                arParms[4].Value = Tues_Dur;
                arParms[5] = new SqlParameter("@dWednesday", SqlDbType.NVarChar);
                arParms[5].Value = Wednesday;
                arParms[6] = new SqlParameter("@dWed_Dur", SqlDbType.NVarChar);
                arParms[6].Value = Wed_Dur;
                arParms[7] = new SqlParameter("@dThursday", SqlDbType.NVarChar);
                arParms[7].Value = Thursday;
                arParms[8] = new SqlParameter("@dThurs_Dur", SqlDbType.NVarChar);
                arParms[8].Value = Thurs_Dur;
                arParms[9] = new SqlParameter("@dFriday", SqlDbType.NVarChar);
                arParms[9].Value = Friday;
                arParms[10] = new SqlParameter("@dFri_Dur", SqlDbType.NVarChar);
                arParms[10].Value = Fri_Dur;
                arParms[11] = new SqlParameter("@dSaturday", SqlDbType.NVarChar);
                arParms[11].Value = Saturday;
                arParms[12] = new SqlParameter("@dSatur_Dur", SqlDbType.NVarChar);
                arParms[12].Value = Satur_Dur;
                arParms[13] = new SqlParameter("@dSunday", SqlDbType.NVarChar);
                arParms[13].Value = Sunday;
                arParms[14] = new SqlParameter("@dSun_Dur", SqlDbType.NVarChar);
                arParms[14].Value = Sun_Dur;
                arParms[15] = new SqlParameter("@dPayment", SqlDbType.NVarChar);
                arParms[15].Value = PaymentMode;
                arParms[16] = new SqlParameter("@dAdtInfo", SqlDbType.NVarChar);
                arParms[16].Value = AdtInfo;
                arParms[17] = new SqlParameter("@dyearesta", SqlDbType.NVarChar);
                arParms[17].Value = YrEst;
                arParms[18] = new SqlParameter("@dprof_Assoc", SqlDbType.NVarChar);
                arParms[18].Value = profAssoc;
                arParms[19] = new SqlParameter("@dcertifications", SqlDbType.NVarChar);
                arParms[19].Value = certifi;
                arParms[20] = new SqlParameter("@dnemployees", SqlDbType.NVarChar);
                arParms[20].Value = NoofEmployees;
                DBOperations.ExecuteNonQuery(myTrans, CommandType.StoredProcedure, "AddMoreInfoSP", arParms);
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
        public bool MoreInfo_Update(string Monday, string Mon_Dur, string Tuesday, string Tues_Dur, string Wednesday, string Wed_Dur,
                                    string Thursday, string Thurs_Dur, string Friday, string Fri_Dur, string Saturday, string Satur_Dur, string Sunday, string Sun_Dur, int dataid,
                                    string PaymentMode,string AdtInfo,string YrEst,string profAssoc,string certifi,string NoofEmployees)
        {
            try
            {

                //SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
                connection.Open();
                SqlTransaction myTrans = connection.BeginTransaction();
                SqlParameter[] arParms = new SqlParameter[21];

                arParms[0] = new SqlParameter("@dId", SqlDbType.Int);
                arParms[0].Value = dataid;
                arParms[1] = new SqlParameter("@dMonday", SqlDbType.NVarChar);
                arParms[1].Value = Monday;
                arParms[2] = new SqlParameter("@dMon_Dur", SqlDbType.NVarChar);
                arParms[2].Value = Mon_Dur;
                arParms[3] = new SqlParameter("@dTuesday", SqlDbType.NVarChar);
                arParms[3].Value = Tuesday;
                arParms[4] = new SqlParameter("@dTues_Dur", SqlDbType.NVarChar);
                arParms[4].Value = Tues_Dur;
                arParms[5] = new SqlParameter("@dWednesday", SqlDbType.NVarChar);
                arParms[5].Value = Wednesday;
                arParms[6] = new SqlParameter("@dWed_Dur", SqlDbType.NVarChar);
                arParms[6].Value = Wed_Dur;
                arParms[7] = new SqlParameter("@dThursday", SqlDbType.NVarChar);
                arParms[7].Value = Thursday;
                arParms[8] = new SqlParameter("@dThurs_Dur", SqlDbType.NVarChar);
                arParms[8].Value = Thurs_Dur;
                arParms[9] = new SqlParameter("@dFriday", SqlDbType.NVarChar);
                arParms[9].Value = Friday;
                arParms[10] = new SqlParameter("@dFri_Dur", SqlDbType.NVarChar);
                arParms[10].Value = Fri_Dur;
                arParms[11] = new SqlParameter("@dSaturday", SqlDbType.NVarChar);
                arParms[11].Value = Saturday;
                arParms[12] = new SqlParameter("@dSatur_Dur", SqlDbType.NVarChar);
                arParms[12].Value = Satur_Dur;
                arParms[13] = new SqlParameter("@dSunday", SqlDbType.NVarChar);
                arParms[13].Value = Sunday;
                arParms[14] = new SqlParameter("@dSun_Dur", SqlDbType.NVarChar);
                arParms[14].Value = Sun_Dur;
                arParms[15] = new SqlParameter("@dPayment", SqlDbType.NVarChar);
                arParms[15].Value = PaymentMode;
                arParms[16] = new SqlParameter("@dAdtInfo", SqlDbType.NVarChar);
                arParms[16].Value = AdtInfo;
                arParms[17] = new SqlParameter("@dyearesta", SqlDbType.NVarChar);
                arParms[17].Value = YrEst;
                arParms[18] = new SqlParameter("@dprof_Assoc", SqlDbType.NVarChar);
                arParms[18].Value = profAssoc;
                arParms[19] = new SqlParameter("@dcertifications", SqlDbType.NVarChar);
                arParms[19].Value = certifi;
                arParms[20] = new SqlParameter("@dnemployees", SqlDbType.NVarChar);
                arParms[20].Value = NoofEmployees;

                DBOperations.ExecuteNonQuery(myTrans, CommandType.StoredProcedure, "UpdateMoreInfoSP", arParms);
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
        public bool Logo_Update(int dataid, string ImgName, string ImgContentType)
        {
            try
            {
                //SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
                connection.Open();
                SqlTransaction myTrans = connection.BeginTransaction();
                SqlParameter[] arParms = new SqlParameter[3];

                arParms[0] = new SqlParameter("@dId", SqlDbType.Int);
                arParms[0].Value = dataid;
                arParms[1] = new SqlParameter("@ImgName", SqlDbType.NVarChar);
                arParms[1].Value = ImgName;
                arParms[2] = new SqlParameter("@ImgContType", SqlDbType.NVarChar);
                arParms[2].Value = ImgContentType;

                DBOperations.ExecuteNonQuery(myTrans, CommandType.StoredProcedure, "UpdateLogoSP", arParms);
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
        public bool Photo_Insert(int dataid, string ImgName, string ImgContentType,string Caption)
        {
            try
            {
                //SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
                connection.Open();
                SqlTransaction myTrans = connection.BeginTransaction();
                SqlParameter[] arParms = new SqlParameter[4];

                arParms[0] = new SqlParameter("@dId", SqlDbType.Int);
                arParms[0].Value = dataid;
                arParms[1] = new SqlParameter("@PhotoName", SqlDbType.NVarChar);
                arParms[1].Value = ImgName;
                arParms[2] = new SqlParameter("@PhotoContType", SqlDbType.NVarChar);
                arParms[2].Value = ImgContentType;
                arParms[3] = new SqlParameter("@Caption", SqlDbType.NVarChar);
                arParms[3].Value = Caption;
                DBOperations.ExecuteNonQuery(myTrans, CommandType.StoredProcedure, "InsertPhotos", arParms);
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
        public bool Vedio_Insert(int dataid, string VideoName, string VideoContentType)
        {
            try
            {
                // SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
                connection.Open();
                SqlTransaction myTrans = connection.BeginTransaction();
                SqlParameter[] arParms = new SqlParameter[3];

                arParms[0] = new SqlParameter("@dId", SqlDbType.Int);
                arParms[0].Value = dataid;
                arParms[1] = new SqlParameter("@VideoName", SqlDbType.NVarChar);
                arParms[1].Value = VideoName;
                arParms[2] = new SqlParameter("@VideoContType", SqlDbType.NVarChar);
                arParms[2].Value = VideoContentType;

                DBOperations.ExecuteNonQuery(myTrans, CommandType.StoredProcedure, "InsertVideos", arParms);
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
        public DataSet getLogoName(string ImgName)
        {
            try{
            string qry = "select * from ModulesData where ImageName='"+ImgName+"'";

            ds = obj.ExcuteQry(qry);
            }
            catch (Exception ex)
            {
                script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
            }
            return ds;

        }
        public DataSet getLogo(int Did)
        {
            try{
            string qry = "select ImageName from ModulesData where id="+Did;

            ds = obj.ExcuteQry(qry);
            }
            catch (Exception ex)
            {
                script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
            }
            return ds;

        }
        public DataSet getDesc(string Did)
        {
            try{
            string qry = "select module,company_profile,Area from ModulesData where id='" + Did+"'";

            ds = obj.ExcuteQry(qry);
            }
            catch (Exception ex)
            {
                script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
            }
            return ds;

        }
        public DataSet getPhotoName(string ImgName)
        {
            try{
            string qry = "select * from Photos where PhotoName='" + ImgName + "'";

            ds = obj.ExcuteQry(qry);
            }
            catch (Exception ex)
            {
                script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
            }
            return ds;

        }
        public DataSet getPhotos(int Did)
        {
            try{
            string qry = "select * from Photos where dataid=" + Did;

            ds = obj.ExcuteQry(qry);
            }
            catch (Exception ex)
            {
                script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
            }
            return ds;

        }
        public DataSet getReport(Int32 Did,string type)
        {
            try{
            string qry = "select * from report where report_type='"+type+"' and dataid=" + Did;

            ds = obj.ExcuteQry(qry);
            }
            catch (Exception ex)
            {
                script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
            }
            return ds;

        }
        public DataTable FetchData(Int32 Did)
        {
            DataTable dt = new DataTable();

            try{
            string qry = "select * from Photos where dataid=" + Did;
            dt = obj.ExcuteQrydt(qry);
            }
            catch (Exception ex)
            {
                script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
            }
            return dt;
        }
        public bool Insert_userupdate(string Module, string Category, string SubCategory, string State, string City, string Area, string Company_Name,
                                string Address, string LandMark, string Contact_Person, string Email, string PhNumber, string Mobile,
                                string FaxNo, string WebSite, DateTime PostDate, string Pincode, string CatSub,
                                string Monday, string Mon_Dur, string Tuesday, string Tues_Dur, string Wednesday, string Wed_Dur,
                                string Thursday, string Thurs_Dur, string Friday, string Fri_Dur, string Saturday, string Satur_Dur, string Sunday, string Sun_Dur, int dataid,
                                string PaymentMode, string AdtInfo, string YrEst, string profAssoc, string certifi, string NoofEmployees)
        {
            try
            {
                //SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["connectionstring"]);
                connection.Open();
                SqlTransaction usertran = connection.BeginTransaction();
                SqlParameter[] user = new SqlParameter[39];
                user[0] = new SqlParameter("@DModule", SqlDbType.NVarChar);
                user[0].Value = Module;
                user[1] = new SqlParameter("@DCategory", SqlDbType.NVarChar);
                user[1].Value = Category;
                user[2] = new SqlParameter("@DSubCat", SqlDbType.NVarChar);
                user[2].Value = SubCategory;
                user[3] = new SqlParameter("DState", SqlDbType.NVarChar);
                user[3].Value = State;
                user[4] = new SqlParameter("@Dcity", SqlDbType.NVarChar);
                user[4].Value = City;
                user[5] = new SqlParameter("@DArea", SqlDbType.NVarChar);
                user[5].Value = Area;
                user[6] = new SqlParameter("@DCompName", SqlDbType.NVarChar);
                user[6].Value = Company_Name;
                user[7] = new SqlParameter("@DAddress", SqlDbType.NVarChar);
                user[7].Value = Address;
                user[8] = new SqlParameter("@DLandMark", SqlDbType.NVarChar);
                user[8].Value = LandMark;
                user[9] = new SqlParameter("@DContPerson", SqlDbType.NVarChar);
                user[9].Value = Contact_Person;
                user[10] = new SqlParameter("@DEmail", SqlDbType.NVarChar);
                user[10].Value = Email;
                user[11] = new SqlParameter("@DPhNumber", SqlDbType.NVarChar);
                user[11].Value = PhNumber;
                user[12] = new SqlParameter("@DMob", SqlDbType.NVarChar);
                user[12].Value = Mobile;
                user[13] = new SqlParameter("@DFax", SqlDbType.NVarChar);
                user[13].Value = FaxNo;
                user[14] = new SqlParameter("@DWebSite", SqlDbType.NVarChar);
                user[14].Value = WebSite;
                user[15] = new SqlParameter("@DPostDate", SqlDbType.NVarChar);
                user[15].Value = PostDate;
                user[16] = new SqlParameter("@pincode", SqlDbType.NVarChar);
                user[16].Value = Pincode;
                user[17] = new SqlParameter("@CatSub", SqlDbType.NVarChar);
                user[17].Value = CatSub;
                user[18] = new SqlParameter("@dMonday", SqlDbType.NVarChar);
                user[18].Value = Monday;
                user[19] = new SqlParameter("@dMon_Dur", SqlDbType.NVarChar);
                user[19].Value = Mon_Dur;
                user[20] = new SqlParameter("@dTuesday", SqlDbType.NVarChar);
                user[20].Value = Tuesday;
                user[21] = new SqlParameter("@dTues_Dur", SqlDbType.NVarChar);
                user[21].Value = Tues_Dur;
                user[22] = new SqlParameter("@dWednesday", SqlDbType.NVarChar);
                user[22].Value = Wednesday;
                user[23] = new SqlParameter("@dWed_Dur", SqlDbType.NVarChar);
                user[23].Value = Wed_Dur;
                user[24] = new SqlParameter("@dThursday", SqlDbType.NVarChar);
                user[24].Value = Thursday;
                user[25] = new SqlParameter("@dThurs_Dur", SqlDbType.NVarChar);
                user[25].Value = Thurs_Dur;
                user[26] = new SqlParameter("@dFriday", SqlDbType.NVarChar);
                user[26].Value = Friday;
                user[27] = new SqlParameter("@dFri_Dur", SqlDbType.NVarChar);
                user[27].Value = Fri_Dur;
                user[28] = new SqlParameter("@dSaturday", SqlDbType.NVarChar);
                user[28].Value = Saturday;
                user[29] = new SqlParameter("@dSatur_Dur", SqlDbType.NVarChar);
                user[29].Value = Satur_Dur;
                user[30] = new SqlParameter("@dSunday", SqlDbType.NVarChar);
                user[30].Value = Sunday;
                user[31] = new SqlParameter("@dSun_Dur", SqlDbType.NVarChar);
                user[31].Value = Sun_Dur;
                user[32] = new SqlParameter("@dPayment", SqlDbType.NVarChar);
                user[32].Value = PaymentMode;
                user[33] = new SqlParameter("@dAdtInfo", SqlDbType.NVarChar);
                user[33].Value = AdtInfo;
                user[34] = new SqlParameter("@dyearesta", SqlDbType.NVarChar);
                user[34].Value = YrEst;
                user[35] = new SqlParameter("@dprof_Assoc", SqlDbType.NVarChar);
                user[35].Value = profAssoc;
                user[36] = new SqlParameter("@dcertifications", SqlDbType.NVarChar);
                user[36].Value = certifi;
                user[37] = new SqlParameter("@dnemployees", SqlDbType.NVarChar);
                user[37].Value = NoofEmployees;
                user[38] = new SqlParameter("@ddataid", SqlDbType.Int);
                user[38].Value = dataid;
                DBOperations.ExecuteNonQuery(usertran, CommandType.StoredProcedure, "user_insert", user);
                usertran.Commit();
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
        public bool Insert_WhitePagesData(string city,string para1,string para2,string para3,string para4,string para5,DateTime postdate,string postedby)
        {
            try
            {
                // SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["connectionstring"]);
                connection.Open();
                SqlTransaction wptran = connection.BeginTransaction();
                SqlParameter[] wp = new SqlParameter[8];
                wp[0] = new SqlParameter("@city", SqlDbType.NVarChar);
                wp[0].Value = city;
                wp[1] = new SqlParameter("@para1", SqlDbType.NVarChar);
                wp[1].Value = para1;
                wp[2] = new SqlParameter("@para2", SqlDbType.NVarChar);
                wp[2].Value = para2;
                wp[3] = new SqlParameter("@para3", SqlDbType.NVarChar);
                wp[3].Value = para3;
                wp[4] = new SqlParameter("@para4", SqlDbType.NVarChar);
                wp[4].Value = para4;
                wp[5] = new SqlParameter("@para5", SqlDbType.NVarChar);
                wp[5].Value = para5;
                wp[6] = new SqlParameter("@postdate", SqlDbType.DateTime);
                wp[6].Value = postdate;
                wp[7] = new SqlParameter("@postedby", SqlDbType.NVarChar);
                wp[7].Value = postedby;
                DBOperations.ExecuteNonQuery(wptran, CommandType.StoredProcedure, "WhitePages_Insert", wp);
                wptran.Commit();
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
        public bool Update_WhitePagesData(Int32 wpid, string para1, string para2, string para3, string para4, string para5, DateTime postdate, string updatedby)
        {
            try
            {
                //SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["connectionstring"]);
                connection.Open();
                SqlTransaction wptran = connection.BeginTransaction();
                SqlParameter[] wp = new SqlParameter[8];
                wp[0] = new SqlParameter("@wpid", SqlDbType.Int);
                wp[0].Value = wpid;
                wp[1] = new SqlParameter("@para1", SqlDbType.NVarChar);
                wp[1].Value = para1;
                wp[2] = new SqlParameter("@para2", SqlDbType.NVarChar);
                wp[2].Value = para2;
                wp[3] = new SqlParameter("@para3", SqlDbType.NVarChar);
                wp[3].Value = para3;
                wp[4] = new SqlParameter("@para4", SqlDbType.NVarChar);
                wp[4].Value = para4;
                wp[5] = new SqlParameter("@para5", SqlDbType.NVarChar);
                wp[5].Value = para5;
                wp[6] = new SqlParameter("@postdate", SqlDbType.DateTime);
                wp[6].Value = postdate;
                wp[7] = new SqlParameter("@updatedby", SqlDbType.NVarChar);
                wp[7].Value = updatedby;
                DBOperations.ExecuteNonQuery(wptran, CommandType.StoredProcedure, "WhitePages_Update", wp);
                wptran.Commit();
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

        public DataSet getWPCity(string City)
        {
            try{
            string qry = "select * from WhitepagesData where City='"+City+"'";

            ds = obj.ExcuteQry(qry);
            }
            catch (Exception ex)
            {
                script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
            }
            return ds;
        }
        public DataSet getWPCategories(string City)
        {
            try{
            string qry = "select distinct Category,module from modulesdata where City='" + City + "' and ((module='Category') or (module='B2B Category') or (module='FreeListing'))";

            ds = obj.ExcuteQry(qry);
            }
            catch (Exception ex)
            {
                script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
            }
            return ds;
        }
        public DataSet BindWhitePages(string city)
        {
            try{
            string qry = "select * from WhitepagesData where City='"+city+"'";

            ds = obj.ExcuteQry(qry);
            }
            catch (Exception ex)
            {
                script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
            }
            return ds;
        }
        public DataSet BindAdmin_WP()
        {
            try{
            string qry = "select *,case when(Para1!='') Then (substring(Para1,1,25)+' ....') else 'nill' end  as aPara1,case when(Para2!='') Then (substring(Para2,1,25)+' ....') else 'nill' end  as aPara2,case when(Para3!='') Then (substring(Para3,1,25)+' ....') else 'nill' end  as aPara3,case when(Para4!='') Then (substring(Para4,1,25)+' ....') else 'nill' end  as aPara4,case when(Para5!='') Then (substring(Para5,1,25)+' ....') else 'nill' end  as aPara5 from WhitepagesData";

            ds = obj.ExcuteQry(qry);
            }
            catch (Exception ex)
            {
                script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
            }
            return ds;
        }
        public DataSet BindPerticular_WP(Int32 wpid)
        {
            try{
            string qry = "select * from WhitepagesData where wpId="+wpid;

            ds = obj.ExcuteQry(qry);
            }
            catch (Exception ex)
            {
                script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
            }
            return ds;
        }       
        // coding related to advanced search .
        public DataSet searchbyall(string city, string comp, string cnctper, string phone)
        {
            try{
            string qry = "select *,stuff(\"company_name\", 22, len(company_name), '...') as compname from modulesdata where City='" + city + "' and company_name='" + comp + "' and contact_person='" + cnctper + "'and ( mob='" + phone + "' or landphno='" + phone + "')";

            ds = obj.ExcuteQry(qry);
            }
            catch (Exception ex)
            {
                script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
            }
            return ds;
        }
        public DataSet searchbycomphone(string city, string comp, string phone)
        {
            try{
            string qry = "select *,stuff(\"company_name\", 22, len(company_name), '...') as compname from modulesdata where City='" + city + "' and company_name='" + comp + "' and ( mob='" + phone + "' or landphno='" + phone + "')";

            ds = obj.ExcuteQry(qry);
            }
            catch (Exception ex)
            {
                script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
            }
            return ds;
        }
        public DataSet searchbycomper(string city, string comp, string cnctper)
        {
            try{
            string qry = "select *,stuff(\"company_name\", 22, len(company_name), '...') as compname from modulesdata where City='" + city + "' and company_name='" + comp + "' and contact_person='" + cnctper + "'";

            ds = obj.ExcuteQry(qry);
            }
            catch (Exception ex)
            {
                script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
            }
            return ds;
        }
        public DataSet searchbyperphone(string city, string cnctper, string phone)
        {
            try{
            string qry = "select *,stuff(\"company_name\", 22, len(company_name), '...') as compname from modulesdata where City='" + city + "' and contact_person='" + cnctper + "' and ( mob='" + phone + "' or landphno='" + phone + "')";

            ds = obj.ExcuteQry(qry);
            }
            catch (Exception ex)
            {
                script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
            }
            return ds;
        }
        public DataSet searchbycomp(string city, string comp)
        {
            try{
            string qry = "select *,stuff(\"company_name\", 22, len(company_name), '...') as compname from modulesdata where City='" + city + "' and company_name='" + comp + "'";

            ds = obj.ExcuteQry(qry);
            }
            catch (Exception ex)
            {
                script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
            }
            return ds;
        }
        public DataSet searchbyper(string city, string cnctper)
        {
            try
            {
                string qry = "select *,stuff(\"company_name\", 22, len(company_name), '...') as compname from modulesdata where City='" + city + "' and contact_person='" + cnctper + "'";

                ds = obj.ExcuteQry(qry);
            }
            catch (Exception ex)
            {
                script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
            }
            return ds;
        }
        public DataSet searchbyphone(string city, string phone)
        {
            try{
            string qry = "select *,stuff(\"company_name\", 22, len(company_name), '...') as compname from modulesdata where City='" + city + "' and ( mob='" + phone + "' or landphno='" + phone + "')";

            ds = obj.ExcuteQry(qry);
            }
            catch (Exception ex)
            {
                script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
            }
            return ds;
        }
        //coding related to customercare
        public DataSet custom(string cmp, string area, string city)
        {
            try{
            string qry = "select * from modulesdata where company_name='" + cmp + "' and area='" + area + "' and City='" + city + "'";

            ds = obj.ExcuteQry(qry);
            }
            catch (Exception ex)
            {
                script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
            }
            return ds;
        }
        public DataSet custom_det(int id)
        {
            try{
            string qry = "select * from modulesdata where id=" + id;

            ds = obj.ExcuteQry(qry);
            }
            catch (Exception ex)
            {
                script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
            }
            return ds;
        }
        public DataSet GetCurrentYear()
        {
            try{
            string qry = "select datepart(year,DATEADD(mi,750,GETDATE())) as cyear";

            ds = obj.ExcuteQry(qry);
            }
            catch (Exception ex)
            {
                script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
            }
            return ds;
        }
       
        public DataSet GetEstablishedyear(string year)
        {
            try{
            string qry = "select * from CompanyEstablished where yearEstablished='"+year+"'";

            ds = obj.ExcuteQry(qry);
            }
            catch (Exception ex)
            {
                script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
            }
            return ds;
        }
        public bool InsertCurrentYear(string year)
        {
            try
            {
                // SqlConnection conn = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
                connection.Open();
                SqlTransaction trans = connection.BeginTransaction();
                SqlParameter[] parm = new SqlParameter[1];
                parm[0] = new SqlParameter("@cyear", SqlDbType.NVarChar, 50);
                parm[0].Value = year;
                DBOperations.ExecuteNonQuery(trans, CommandType.StoredProcedure, "InsertCurrentYear", parm);
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
        public bool JC_insertMailDetails(string Jname, string Jemail, string Jph, string Jcompanyname, string Jadid, string Jtype, string Jip_address, DateTime Jpostdate)
        {
            try
            {
                // SqlConnection conn = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
                connection.Open();
                SqlTransaction trans = connection.BeginTransaction();
                SqlParameter[] parm = new SqlParameter[8];

                parm[0] = new SqlParameter("@name", SqlDbType.NVarChar, 50);
                parm[0].Value = Jname;
                parm[1] = new SqlParameter("@email", SqlDbType.NVarChar, 100);
                parm[1].Value = Jemail;
                parm[2] = new SqlParameter("@ph", SqlDbType.NVarChar, 20);
                parm[2].Value = Jph;
                parm[3] = new SqlParameter("@companyname", SqlDbType.NVarChar, 50);
                parm[3].Value = Jcompanyname;
                parm[4] = new SqlParameter("@adid", SqlDbType.NVarChar, 100);
                parm[4].Value = Jadid;
                parm[5] = new SqlParameter("@type", SqlDbType.NVarChar, 100);
                parm[5].Value = Jtype;
                parm[6] = new SqlParameter("@ip_address", SqlDbType.NVarChar, 100);
                parm[6].Value = Jip_address;
                parm[7] = new SqlParameter("@postdate", SqlDbType.DateTime);
                parm[7].Value = Jpostdate;
                DBOperations.ExecuteNonQuery(trans, CommandType.StoredProcedure, "JcReverseAuction_InsertMailDetails", parm);
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
        public DataSet GetModuleData(Int32 uid)
        {
             try{      
            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@Did", SqlDbType.Int);
            parm[0].Value = uid;
            ds = DBOperations.ExecuteDataset(connection, CommandType.StoredProcedure, "GetModulesData", parm);
             }
             catch (Exception ex)
             {
                 script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
             }
            return ds;
        }
        public bool Delete_Report(Int32 id)
        {
            try
            {
                //SqlConnection conn = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
                connection.Open();
                SqlTransaction trans = connection.BeginTransaction();
                SqlParameter[] parm = new SqlParameter[1];
                parm[0] = new SqlParameter("@id", SqlDbType.Int);
                parm[0].Value = id;
                DBOperations.ExecuteNonQuery(trans, CommandType.StoredProcedure, "DeleteReport", parm);
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
        public DataSet Get_SearchNotFound()
        {
           try{

               ds = DBOperations.ExecuteDataset(connection, CommandType.StoredProcedure, "GetSearchNotFound");
           }
           catch (Exception ex)
           {
               script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
           }
            return ds;            
        }
        public bool Delete_SearchNotFound(Int32 id)
        {
            try
            {
                // SqlConnection conn = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
                connection.Open();
                SqlTransaction trans = connection.BeginTransaction();
                SqlParameter[] parm = new SqlParameter[1];
                parm[0] = new SqlParameter("@id", SqlDbType.Int);
                parm[0].Value = id;
                DBOperations.ExecuteNonQuery(trans, CommandType.StoredProcedure, "Delete_SearchNotFound", parm);
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
        public DataSet GetRequiredData(string Category,string City)
        {
          try{  
                        
            SqlParameter[] parm = new SqlParameter[2];
            parm[0] = new SqlParameter("@Category", SqlDbType.NVarChar);
            parm[0].Value = Category;
            parm[1] = new SqlParameter("@City", SqlDbType.NVarChar);
            parm[1].Value = City;
            ds = DBOperations.ExecuteDataset(connection, CommandType.StoredProcedure, "GetRequiredData", parm);
          }
          catch (Exception ex)
          {
              script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
          }
            return ds;
        }
        public DataSet GetDataNRate(string Category, string City)
        {
            try
            {

                SqlParameter[] parm = new SqlParameter[2];
                parm[0] = new SqlParameter("@Category", SqlDbType.NVarChar);
                parm[0].Value = Category;
                parm[1] = new SqlParameter("@City", SqlDbType.NVarChar);
                parm[1].Value = City;
                ds = DBOperations.ExecuteDataset(connection, CommandType.StoredProcedure, "GetDataNRate", parm);
            }
            catch (Exception ex)
            {
                script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
            }
            return ds;
        }
        //Reports
        public bool Insert_ReportAbuse(Int32 dataid, string name, string contactno, string emailid, string comment, string reportType, string ipaddress, DateTime postdate)
        {
            try
            {
                //SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
                connection.Open();
                SqlTransaction myTrans = connection.BeginTransaction();
                SqlParameter[] arParms = new SqlParameter[8];
                arParms[0] = new SqlParameter("@dataid", SqlDbType.Int);
                arParms[0].Value = dataid;
                arParms[1] = new SqlParameter("@rname", SqlDbType.NVarChar);
                arParms[1].Value = name;
                arParms[2] = new SqlParameter("@contactno", SqlDbType.NVarChar);
                arParms[2].Value = contactno;
                arParms[3] = new SqlParameter("@emailid", SqlDbType.NVarChar);
                arParms[3].Value = emailid;
                arParms[4] = new SqlParameter("@comment", SqlDbType.NVarChar);
                arParms[4].Value = comment;
                arParms[5] = new SqlParameter("@reportType", SqlDbType.NVarChar);
                arParms[5].Value = reportType;
                arParms[6] = new SqlParameter("@ipaddress", SqlDbType.NVarChar);
                arParms[6].Value = ipaddress;
                //arParms[7] = new SqlParameter("@physicaladdress", SqlDbType.NVarChar);
                //arParms[7].Value = physicaladdress;
                arParms[7] = new SqlParameter("@postdate", SqlDbType.DateTime);
                arParms[7].Value = postdate;
                DBOperations.ExecuteNonQuery(myTrans, CommandType.StoredProcedure, "InsertReportAbuse", arParms);
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
        public bool Insert_ReportIncorrect(Int32 dataid, string comment, string reportType, string ipaddress, DateTime postdate)
        {
            try
            {
                //SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
                connection.Open();
                SqlTransaction myTrans = connection.BeginTransaction();
                SqlParameter[] arParms = new SqlParameter[5];
                arParms[0] = new SqlParameter("@dataid", SqlDbType.Int);
                arParms[0].Value = dataid;
                arParms[1] = new SqlParameter("@comment", SqlDbType.NVarChar);
                arParms[1].Value = comment;
                arParms[2] = new SqlParameter("@reportType", SqlDbType.NVarChar);
                arParms[2].Value = reportType;
                arParms[3] = new SqlParameter("@ipaddress", SqlDbType.NVarChar);
                arParms[3].Value = ipaddress;
                //arParms[4] = new SqlParameter("@physicaladdress", SqlDbType.NVarChar);
                //arParms[4].Value = physicaladdress;
                arParms[4] = new SqlParameter("@postdate", SqlDbType.DateTime);
                arParms[4].Value = postdate;
                DBOperations.ExecuteNonQuery(myTrans, CommandType.StoredProcedure, "InsertReportIncorrect", arParms);
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
        public bool Report_Shutdown(Int32 id,string ipaddress,DateTime postdate,string reportType)
        {
            try
            {
                //SqlConnection conn = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
                connection.Open();
                SqlTransaction trans = connection.BeginTransaction();
                SqlParameter[] parm = new SqlParameter[4];
                parm[0] = new SqlParameter("@id", SqlDbType.Int);
                parm[0].Value = id;
                parm[1] = new SqlParameter("@ipaddress", SqlDbType.NVarChar);
                parm[1].Value = ipaddress;
                //parm[2] = new SqlParameter("@physicaladdress", SqlDbType.NVarChar);
                //parm[2].Value = physicaladdress;            
                parm[2] = new SqlParameter("@postdate", SqlDbType.DateTime);
                parm[2].Value = postdate;
                parm[3] = new SqlParameter("@reportType", SqlDbType.NVarChar);
                parm[3].Value = reportType;
                DBOperations.ExecuteNonQuery(trans, CommandType.StoredProcedure, "ReportShutdown", parm);
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
        public DataSet Check_ReportData(Int32 dataid,string reportType,string IpAddress)
        {
            try
            {
                SqlParameter[] parm = new SqlParameter[3];
                parm[0] = new SqlParameter("@dataid", SqlDbType.Int);
                parm[0].Value = dataid;
                parm[1] = new SqlParameter("@reportType", SqlDbType.NVarChar);
                parm[1].Value = reportType;
                parm[2] = new SqlParameter("@IpAddress", SqlDbType.NVarChar);
                parm[2].Value = IpAddress;
                ds = DBOperations.ExecuteDataset(connection, CommandType.StoredProcedure, "CheckReportData", parm);
            }
            catch (Exception ex)
            {
                script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
            }
            return ds;
        }
        public DataSet Check_AbusedData(Int32 dataid, string reportType, string IpAddress,string nowdate)
        {
           try{
            
            SqlParameter[] parm = new SqlParameter[4];
            parm[0] = new SqlParameter("@dataid", SqlDbType.Int);
            parm[0].Value = dataid;
            parm[1] = new SqlParameter("@reportType", SqlDbType.NVarChar);
            parm[1].Value = reportType;
            parm[2] = new SqlParameter("@IpAddress", SqlDbType.NVarChar);
            parm[2].Value = IpAddress;
            parm[3] = new SqlParameter("@nowdate", SqlDbType.NVarChar);
            parm[3].Value = nowdate;
            ds = DBOperations.ExecuteDataset(connection, CommandType.StoredProcedure, "CheckAbusedData", parm);
           }
           catch (Exception ex)
           {
               script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
           }
            return ds;
        }
        
        //public string GetMACAddress()
        //{
        //    //ManagementObjectSearcher objMOS = new ManagementObjectSearcher("Win32_NetworkAdapterConfiguration");
        //    //ManagementObjectCollection objMOC = objMOS.Get();
        //    //string MACAddress = String.Empty;
        //    //foreach (ManagementObject objMO in objMOC)
        //    //{
        //    //    if (MACAddress == String.Empty) // only return MAC Address from first card   
        //    //    {
        //    //        MACAddress = objMO["MacAddress"].ToString();
        //    //    }
        //    //    objMO.Dispose();
        //    //}
        //    //MACAddress = MACAddress.Replace(":", "");
        //    //return MACAddress;

        //    //String mac = string.Empty;
        //    //System.Management.ManagementClass objMgmtCls = new System.Management.ManagementClass("Win32_NetworkAdapter");

        //    //foreach (System.Management.ManagementObject objMgmt in objMgmtCls.GetInstances())
        //    //{
        //    //    mac = Convert.ToString(objMgmt["MACAddress"]);

        //    //}
        //    //return mac;
        //    IPGlobalProperties computerProperties = IPGlobalProperties.GetIPGlobalProperties();
        //    NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
        //    String sMacAddress = string.Empty;
        //    foreach (NetworkInterface adapter in nics)
        //    {
        //        if (sMacAddress == String.Empty)// only return MAC Address from first card  
        //        {
        //            IPInterfaceProperties properties = adapter.GetIPProperties();
        //            sMacAddress = adapter.GetPhysicalAddress().ToString();
        //        }
        //    } return sMacAddress;
        //}
        public string GetNetWorkIPAddress()
        {
            string result = string.Empty;
            string ip = HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];
            try{
            if (!string.IsNullOrEmpty(ip))
            {
                string[] ipRange = ip.Split(',');
                int le = ipRange.Length - 1;
                result = ipRange[0];
            }
            else
            {
                result = HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"];
            }
            }
            catch (Exception ex)
            {
                script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
            }
            return result;
        }
        //Bar Graph Rating Start       
        private string rating;
       
        public string prating
        {
            get { return rating; }
            set { rating = value; }
        }
        public DataSet GetRatingCount(Int32 dataId, string Rating)
        {
            try
            {

                SqlParameter[] parm = new SqlParameter[2];
                parm[0] = new SqlParameter("@dataId", SqlDbType.Int);
                parm[0].Value = dataId;
                parm[1] = new SqlParameter("@Rating", SqlDbType.NVarChar);
                parm[1].Value = Rating;
                ds = DBOperations.ExecuteDataset(connection, CommandType.StoredProcedure, "GetRatingCount", parm);
            }
            catch (Exception ex)
            {
                script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
            }
            return ds;
        }
        public DataSet GetOverallRatingCount(Int32 dataId)
        {
            try{
            
            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@dataId", SqlDbType.Int);
            parm[0].Value = dataId;

            ds = DBOperations.ExecuteDataset(connection, CommandType.StoredProcedure, "GetOverallRatingCount", parm);
            }
            catch (Exception ex)
            {
                script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
            }
            return ds;
        }
        public string sendSms(string Iname, string Cate, string Loca, DataList dtlist)
        {
            try
            {
                string sb = "Dear " + Iname + ", your searching report :" + Cate + " in " + Loca + "  \n\n";
                int i = 0;
                foreach (DataListItem item in dtlist.Items)
                {
                    double d = Convert.ToDouble(((Label)(item.FindControl("testSpan0"))).Width.Value);
                    d = d / 18;
                    string sd;
                    if (d == 0)
                        sd = d.ToString();
                    else
                        sd = d.ToString("#.#");
                    ++i;
                    sb += Convert.ToString(i) + ":" + ((HyperLink)(item.FindControl("hypCompany"))).Text.Replace("&", "and") + "(" +
                        sd + "*/5)," + ((Label)(item.FindControl("lblVarea"))).Text.Replace("&", "and") + ", " + ((Label)(item.FindControl("lbllandphone"))).Text + ". \n\n";
                }
                return sb += "plz, say justcalluz.com to callers.";
            }
            catch
            {
                return "";
            }

            //string sb = "Dear " + Iname + ", Information About :" + Cate + "  ";
            //DataSet ds = new DataSet();
            //ds = GetDataNRate(Cate, Loca);
            //if (ds.Tables[0].Rows.Count > 0)
            //{
            //    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            //    {
            //        string rate = "0";
            //        if (ds.Tables[0].Rows[i]["rate"].ToString() != "")
            //            rate = ds.Tables[0].Rows[i]["rate"].ToString();
            //        sb += Convert.ToString(i + 1) + ":" + ds.Tables[0].Rows[i]["Company_name"].ToString().Replace("&","and") + " (" + rate + "*/5), " +
            //            ds.Tables[0].Rows[i]["area"].ToString() + "," + Loca + " " + ds.Tables[0].Rows[i]["mob"].ToString() + ".    ";
            //    }
            //    return sb;
            //}
           // else
               
        }
        /// <summary>
        /// Get visitors data
        /// </summary>
        /// <param name="dataId"></param>
        /// <returns></returns>
        public DataSet GetVisitorsDetails()
        {
            try
            {
                ds = DBOperations.ExecuteDataset(connection, CommandType.StoredProcedure, "SiteVisitors");
            }
            catch (Exception ex)
            {
                script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
            }
            return ds;
        }
        //Bar Graph Rating End
    } 
  

}
