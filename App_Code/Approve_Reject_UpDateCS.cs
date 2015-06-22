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
namespace CallUsStatus.DataStatus
{
    /// <summary>
    /// Summary description for Approve_Reject_UpDateCS
    /// </summary>
    public class Approve_Reject_UpDateCS
    {
        public Approve_Reject_UpDateCS()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        private Int32 DataId;
        private Int32 Status;
        private string EmailId;


        public Int32 pDataId
        {
            get { return DataId; }
            set { DataId = value; }

        }
        public string UEmailId
        {
            get { return EmailId; }
            set { EmailId = value; }

        }
        public bool Data_ApprovalStatus(Int32 DataId, string EmailId)
        {

            SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
            connection.Open();
            SqlTransaction myTrans = connection.BeginTransaction();
            SqlParameter[] arParms = new SqlParameter[3];

            arParms[0] = new SqlParameter("@dataId", SqlDbType.Int);
            arParms[0].Value = DataId;
            arParms[1] = new SqlParameter("@iUserId", SqlDbType.NVarChar);
            arParms[1].Value = EmailId;
            arParms[2] = new SqlParameter("@dStatus", SqlDbType.Int);
            arParms[2].Value = "1";
            DBOperations.ExecuteNonQuery(myTrans, CommandType.StoredProcedure, "[ApprovalSP]", arParms);
            myTrans.Commit();
            connection.Close();
            return true;
        }
        public bool Data_RejectionStatus(Int32 DataId, string EmailId)
        {

            SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
            connection.Open();
            SqlTransaction myTrans = connection.BeginTransaction();
            SqlParameter[] arParms = new SqlParameter[3];

            arParms[0] = new SqlParameter("@dataId", SqlDbType.Int);
            arParms[0].Value = DataId;
            arParms[1] = new SqlParameter("@iUserId", SqlDbType.NVarChar);
            arParms[1].Value = EmailId;
            arParms[2] = new SqlParameter("@dStatus", SqlDbType.Int);
            arParms[2].Value = "2";
            DBOperations.ExecuteNonQuery(myTrans, CommandType.StoredProcedure, "[ApprovalSP]", arParms);
            myTrans.Commit();
            connection.Close();
            return true;
        }
    }
}