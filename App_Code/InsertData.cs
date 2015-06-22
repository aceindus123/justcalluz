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
/// <summary>
/// Summary description for Class1
/// </summary>
public class InsertData
{
    public DataAccess obj = new DataAccess();
    static string excep_date = DateTime.Now.ToShortDateString();
    static int excep_status = 0;
    string script = string.Empty;
    DataSet ds = new DataSet();
    public InsertData()
    {
        //
        // TODO: Add constructor logic here
        //
    }



    public DataSet insert_Data(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, string city, string comp)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            //parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            //if (optim.ToString() == "01/01/0001 12:00:00 AM")
            //{
            //    parm[9].Value = DBNull.Value;
            //}
            //else
            //{
            //    parm[9].Value = optim;
            //}
            parm[9] = new SqlParameter("@city", city);
            parm[10] = new SqlParameter("@comp", comp);

            ds = obj.ExecuteSQL("insert_Data", parm);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }

    public DataSet insert_exception(string exp_msg, string exp_date, int exp_status, string exp_pg, string line)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[5];
            parm[0] = new SqlParameter("@Excep_desc", exp_msg);
            parm[1] = new SqlParameter("@Excep_postdate", exp_date);
            parm[2] = new SqlParameter("@Excep_status", exp_status);
            parm[3] = new SqlParameter("@Excep_page", exp_pg);
            parm[4] = new SqlParameter("@lineno", line);
            ds = obj.ExecuteSQL("exception", parm);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        //catch (Exception ex)
        //{
        //    ex.ToString();
        //}
        return ds;
    }
    public DataSet insert_exception(Exception ex, string excep_page)
    {
        DataSet ds = new DataSet();
        try
        {
            string exception_msg = ex.Message;
            string excep1 = ex.StackTrace.ToString();
            string line = excep1.Substring(excep1.LastIndexOf("line"), (excep1.Length - excep1.LastIndexOf("line")));
            SqlParameter[] parm = new SqlParameter[5];
            parm[0] = new SqlParameter("@Excep_desc", exception_msg);
            parm[1] = new SqlParameter("@Excep_postdate", excep_date);
            parm[2] = new SqlParameter("@Excep_status", excep_status);
            parm[3] = new SqlParameter("@Excep_page", excep_page);
            parm[4] = new SqlParameter("@lineno", line);
            ds = obj.ExecuteSQL("exception", parm);
        }
        catch (Exception ex1)
        {
            script = "<script type=\"text/javascript\">alert('" + ex1.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet insert_data(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, string city, string compdet)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            //parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            //if (optim.ToString() == "01/01/0001 12:00:00 AM")
            //{
            //    parm[9].Value = DBNull.Value;
            //}
            //else
            //{
            //    parm[9].Value = optim;
            //}
            parm[9] = new SqlParameter("@city", city);
            parm[10] = new SqlParameter("@compdet", compdet);

            ds = obj.ExecuteSQL("insert_data", parm);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }


    public DataSet insert_post_discount(string userid, int appstatus, string module, string cname, string cat, string subcat,
            string sdate, string edate, string descr, string event_dur, string addr, string loc,
            string lanmar, string time, string city, string state, string conper, string mob, string landno, string fax, string web, string email, DateTime pdate, DateTime expdate, string pin)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[25];
            parm[0] = new SqlParameter("UserLoginId", userid);
            parm[1] = new SqlParameter("ApprovedStatus", appstatus);
            parm[2] = new SqlParameter("module", module);
            parm[3] = new SqlParameter("company_name", cname);
            parm[4] = new SqlParameter("Category", cat);
            parm[5] = new SqlParameter("SubCategory", subcat);
            parm[6] = new SqlParameter("event_startdate", sdate);
            parm[7] = new SqlParameter("event_enddate", edate);
            parm[8] = new SqlParameter("event_desc", descr);
            parm[9] = new SqlParameter("evedi_DurationType", event_dur);
            parm[10] = new SqlParameter("address", addr);
            parm[11] = new SqlParameter("Area", loc);
            parm[12] = new SqlParameter("land_mark", lanmar);
            parm[13] = new SqlParameter("event_time", time);
            parm[14] = new SqlParameter("city", city);
            parm[15] = new SqlParameter("state", state);
            parm[16] = new SqlParameter("contact_person", conper);
            parm[17] = new SqlParameter("mob", mob);
            parm[18] = new SqlParameter("landphno", landno);
            parm[19] = new SqlParameter("fax", fax);
            parm[20] = new SqlParameter("Website", web);
            parm[21] = new SqlParameter("emailid", email);
            parm[22] = new SqlParameter("postdate", pdate);
            parm[23] = new SqlParameter("expdate", expdate);
            parm[24] = new SqlParameter("pincode", pin);

            ds = obj.ExecuteSQL("insert_post_discount", parm);

        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet insert_post_events(string ename, string placeevent, string esdate, string eedate, string descr, string addr, string loc, string lanmar, string timi, string city, string state, string conper, string mob, string landno)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[14];
            parm[0] = new SqlParameter("@ename", ename);
            parm[1] = new SqlParameter("@placeevent", placeevent);
            parm[2] = new SqlParameter("@esdate", esdate);
            parm[3] = new SqlParameter("@eedate", eedate);
            parm[4] = new SqlParameter("@descr", descr);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@loc", loc);
            parm[7] = new SqlParameter("@lanmar", lanmar);
            parm[8] = new SqlParameter("@timi", timi);
            parm[9] = new SqlParameter("@city", city);
            parm[10] = new SqlParameter("@state", state);
            parm[11] = new SqlParameter("@conper", conper);
            parm[12] = new SqlParameter("@mob", mob);
            parm[13] = new SqlParameter("@landno", landno);

            ds = obj.ExecuteSQL("insert_post_events", parm);

        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }

    public DataSet insert_Accountingservices(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_AccountingServices", parm);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }

    public DataSet insert_Acdealers(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Acdealers", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }
    public DataSet insert_AcousticEnclosure(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_AcousticEnclosure", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }

    public DataSet insert_Adhesives(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Adhesives", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }

    public DataSet insert_AdhesiveTape(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_AdhesiveTape", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }




    public DataSet insert_Advertiseform(string fname, string email, string mob, string lanl, string bname, string bprofile, string kob, string spec, string web, string addr, string lanm, string area, string city, string state, string userid, string pincode, string mod, DateTime PostDate, DateTime ExpireDate, string fax)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[21];
            parm[0] = new SqlParameter("@fname", fname);
            //parm[1] = new SqlParameter("@lname", lname);
            parm[1] = new SqlParameter("@email", email);
            parm[2] = new SqlParameter("@mob", mob);
            parm[3] = new SqlParameter("@lanl", lanl);
            parm[4] = new SqlParameter("@bname", bname);
            parm[5] = new SqlParameter("@bprofile", bprofile);
            parm[6] = new SqlParameter("@kob", kob);
            parm[7] = new SqlParameter("@spec", spec);
            parm[8] = new SqlParameter("@web", web);
            parm[9] = new SqlParameter("@addr", addr);
            parm[10] = new SqlParameter("@lanm", lanm);
            parm[11] = new SqlParameter("@area", area);
            parm[12] = new SqlParameter("@city", city);
            parm[13] = new SqlParameter("@state", state);
            parm[14] = new SqlParameter("@reguserId", userid);
            parm[15] = new SqlParameter("@approveStatus", SqlDbType.Int);
            parm[15].Value = "0";
            parm[16] = new SqlParameter("@pincode", pincode);
            parm[17] = new SqlParameter("@mod", mod);
            parm[18] = new SqlParameter("@postdate", PostDate);
            parm[19] = new SqlParameter("@expdate", ExpireDate);
            parm[20] = new SqlParameter("@fax", fax);
            //parm[21] = new SqlParameter("@brand", brand);
            //parm[22] = new SqlParameter("@subcatbrand", subcatbrand);


            ds = obj.ExecuteSQL("insert_Advertiseform", parm);


        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Advertising(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Advertising", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }

    public DataSet insert_Advocate(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Advocate", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }
    public DataSet insert_Advocatelawyers(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Advocatelawyers", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }

    public DataSet insert_Aerospace(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Aerospace", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }
    public DataSet insert_Agarbatti(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Agarbatti", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }
    public DataSet insert_Agency(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Agency", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }
    public DataSet insert_Agriculture(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Agriculture", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }

    public DataSet insert_Aircompressor(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Aircompressor", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }
    public DataSet insert_Aircompressors(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Aircompressors", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }

    public DataSet insert_Airconditioners(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Airconditioners", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }
    public DataSet insert_Airfilters(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Airfilters", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }
    public DataSet insert_Airlines(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Airlines", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_Alcoholwines(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Alcoholwines", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }
    public DataSet insert_AlternateEnergy(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_AlternateEnergy", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }
    public DataSet insert_AlternativeEnergy(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_AlternativeEnergy", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }

    public DataSet insert_Aluminium(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Aluminium", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }
    public DataSet insert_Ambulance(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Ambulance", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }

    public DataSet insert_AmbulanceServices(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_AmbulanceServices", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }

    public DataSet insert_Animal(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Animal", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }

    public DataSet insert_Animalhusbandry(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Animalhusbandry", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }

    public DataSet insert_Antivibration(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Antivibration", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }

    public DataSet insert_Apparel(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Apparel", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }

    public DataSet insert_AquaCulture(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_AquaCulture", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }
    public DataSet insert_AquaEquipment(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_AquaEquipment", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }
    public DataSet insert_ArmsAmmunition(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_ArmsAmmunition", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }
    public DataSet insert_ArtGallery(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_ArtGallery", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_Artscrafts(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Artscrafts", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }
    public DataSet insert_Asbestos(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Asbestos", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }
    public DataSet insert_Ashram(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Ashram", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }
    public DataSet insert_Atm(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Atm", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }

    public DataSet insert_AudioVideo(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_AudioVideo", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }

    public DataSet insert_Automobile(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Automobile", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }
    public DataSet insert_Automobiles(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Automobiles", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }
    public DataSet insert_Ayurvedic(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Ayurvedic", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }
    public DataSet insert_Bag(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Bag", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }

    public DataSet insert_Bakery(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Bakery", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_Bank(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Bank", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }

    public DataSet insert_Banquethall(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Banquethall", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }
    public DataSet insert_BarRestaurant(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_BarRestaurant", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }
    public DataSet insert_Battery(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Battery", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }
    public DataSet insert_Beautyparlour(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Beautyparlour", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_Bellows(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Bellows", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }

    public DataSet insert_Billingmachine(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Billingmachine", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }
    public DataSet insert_Biological(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Biological", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }
    public DataSet insert_Biotech(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Biotech", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }

    public DataSet insert_Blasting(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Blasting", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_Boat(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Boat", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }

    public DataSet insert_Boilers(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Boilers", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }

    public DataSet insert_Bolt(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Bolt", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }

    public DataSet insert_Boltsnuts(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Boltsnuts", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }

    public DataSet insert_Book(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Book", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }

    public DataSet insert_Borewell(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Borewell", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }

    public DataSet insert_Boutiques(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Boutiques", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }
    public DataSet insert_BPOcompanies(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_BPOcompanies", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }
    public DataSet insert_Bricks(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Bricks", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }
    public DataSet insert_Broker(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Broker", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }

    public DataSet insert_Brokers(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Brokers", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }

    public DataSet insert_Builders(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Builders", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }

    public DataSet insert_Building(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Building", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }
    public DataSet insert_Bureau(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Bureau", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }
    public DataSet insert_Business(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Business", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }

    public DataSet insert_Camera(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Camera", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }

    public DataSet insert_Canvassing(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Canvassing", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }

    public DataSet insert_Car(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Car", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }
    public DataSet insert_Carbon(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Carbon", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }

    public DataSet insert_CardDealers(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_CardDealers", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }
    public DataSet insert_CardsDealer(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_CardsDealer", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }

    public DataSet insert_Carecentre(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Carecentre", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }

    public DataSet insert_Cargo(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Cargo", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_Carparkinglift(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Carparkinglift", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }

    public DataSet insert_Carpenter(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Carpenter", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }

    public DataSet insert_Cars(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Cars", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }

    public DataSet insert_Caterers(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Caterers", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_Categories(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Categories", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Cement(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Cement", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }

    public DataSet insert_Ceramic(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Ceramic", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }

    public DataSet insert_Ceramics(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Ceramics", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }

    public DataSet insert_CFagents(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_CFagents", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }

    public DataSet insert_Charity(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Charity", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }

    public DataSet insert_Chemical(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Chemical", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }

    public DataSet insert_ChineseRestaurant(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_ChineseRestaurant", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }

    public DataSet insert_Civil(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Civil", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }

    public DataSet insert_CleaningServices(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_CleaningServices", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }

    public DataSet insert_Clinic(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Clinic", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }

    public DataSet insert_ClinicBloodbank(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_ClinicBloodbank", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }

    public DataSet insert_Cloth(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Cloth", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }

    public DataSet insert_Club(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Club", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }

    public DataSet insert_Clubs(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Clubs", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_Clubsparks(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Clubsparks", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_Coffee(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Coffee", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }

    public DataSet insert_Coirefibre(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Coirefibre", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }

    public DataSet insert_College(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_College", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }

    public DataSet insert_Commercial(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Commercial", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }

    public DataSet insert_Communication(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Communication", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_Communications(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Communications", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }

    public DataSet insert_Company(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Company", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_Compressor(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Compressor", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }

    public DataSet insert_Computer(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Computer", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }

    public DataSet insert_Computers(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Computers", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_Concrete(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Concrete", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_Construction(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Construction", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_Constructions(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Constructions", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }

    public DataSet insert_Consultant(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Consultant", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }

    public DataSet insert_Consultants(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Consultants", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_Contol(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Contol", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }

    public DataSet insert_Contolpanels(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Contolpanels", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }

    public DataSet insert_Contractor(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Contractor", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }

    public DataSet insert_Conveyer(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Conveyer", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }

    public DataSet insert_Conveyers(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Conveyers", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }

    public DataSet insert_Conveyors(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Conveyors", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_Conveyorsystems(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Conveyorsystems", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_Corporate(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Corporate", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }

    public DataSet insert_Corrugatedbox(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Corrugatedbox", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }

    public DataSet insert_Cosmetic(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Cosmetic", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }

    public DataSet insert_Cotton(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Cotton", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_Counselling(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Counselling", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_Courier(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Courier", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }

    public DataSet insert_CourierLogistics(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_CourierLogistics", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_Crafts(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Crafts", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_Crane(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Crane", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }

    public DataSet insert_Credit(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Credit", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_Cycle(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Cycle", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_CycleStores(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_CycleStores", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Dairy(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Dairy", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_Dance(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Dance", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Dealer(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Dealer", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Dental(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Dental", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_Designer(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Designer", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_Designers(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Designers", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_Designgraphics(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Designgraphics", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_Detectiveagencies(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Detectiveagencies", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_Diagnostics(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Diagnostics", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_Digital(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Digital", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_post_discount(string bname, string cat, DateTime sdate, DateTime edate, string descr, string addr, string loc, string lanmar, DateTime timi, string city, string state, string conper, string mob, string landno, string fax)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[15];
            parm[0] = new SqlParameter("@bname", bname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@sdate", SqlDbType.DateTime, 30, "sdate");
            if (sdate.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[2].Value = DBNull.Value;
            }
            else
            {
                parm[2].Value = sdate;
            }
            parm[3] = new SqlParameter("@edate", SqlDbType.DateTime, 30, "edate");
            if (edate.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[3].Value = DBNull.Value;

            }
            else
            {
                parm[3].Value = edate;
            }
            parm[4] = new SqlParameter("@descr", descr);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@loc", loc);
            parm[7] = new SqlParameter("@lanmar", lanmar);
            parm[8] = new SqlParameter("@timi", SqlDbType.DateTime, 30, "timi");
            if (timi.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[8].Value = DBNull.Value;

            }
            else
            {
                parm[8].Value = timi;
            }
            parm[9] = new SqlParameter("@city", city);
            parm[10] = new SqlParameter("@state", state);
            parm[11] = new SqlParameter("@conper", conper);
            parm[12] = new SqlParameter("@mob", mob);
            parm[13] = new SqlParameter("@landno", landno);
            parm[14] = new SqlParameter("@fax", fax);
            ds = obj.ExecuteSQL("insert_post_discount", parm);

        }
        catch (Exception ex)
        {
            ex.ToString();
        }
        return ds;

    }


    public DataSet insert_post_discount1(string bname, string cat, string sdate, string edate, string descr, string addr, string loc, string lanmar, string timi, string city, string state, string conper, string mob, string landno, string fax)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[15];
            parm[0] = new SqlParameter("@bname", bname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@sdate", sdate);

            parm[3] = new SqlParameter("@edate", edate);

            parm[4] = new SqlParameter("@descr", descr);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@loc", loc);
            parm[7] = new SqlParameter("@lanmar", lanmar);
            parm[8] = new SqlParameter("@timi", timi);

            parm[9] = new SqlParameter("@city", city);
            parm[10] = new SqlParameter("@state", state);
            parm[11] = new SqlParameter("@conper", conper);
            parm[12] = new SqlParameter("@mob", mob);
            parm[13] = new SqlParameter("@landno", landno);
            parm[14] = new SqlParameter("@fax", fax);
            ds = obj.ExecuteSQL("insert_post_discount1", parm);

        }
        catch (Exception ex)
        {
            ex.ToString();
        }
        return ds;

    }


    public DataSet insert_discount1(string dname, string cat, DateTime sdate, DateTime edate, string addr, string lanmar, string loc, string state, DateTime timi, string conper, string ph, string city, string descr, string pincode, string landno)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[15];
            parm[0] = new SqlParameter("@dname", dname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@sdate", SqlDbType.DateTime, 30, "sdate");
            if (sdate.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[2].Value = DBNull.Value;
            }
            else
            {
                parm[2].Value = sdate;
            }
            parm[3] = new SqlParameter("@edate", SqlDbType.DateTime, 30, "edate");
            if (edate.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[3].Value = DBNull.Value;

            }
            else
            {
                parm[3].Value = edate;
            }
            parm[4] = new SqlParameter("@addr", addr);
            parm[5] = new SqlParameter("@lanmar", lanmar);
            parm[6] = new SqlParameter("@loc", loc);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@timi", SqlDbType.DateTime, 30, "timi");
            if (timi.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[8].Value = DBNull.Value;

            }
            else
            {
                parm[8].Value = timi;
            }
            parm[9] = new SqlParameter("@conper", conper);
            parm[10] = new SqlParameter("@ph", ph);
            parm[11] = new SqlParameter("@city", city);
            parm[12] = new SqlParameter("@descr", descr);
            parm[13] = new SqlParameter("@pincode", pincode);
            parm[14] = new SqlParameter("@landno", landno);
            ds = obj.ExecuteSQL("insert_discount1", parm);

        }
        catch (Exception ex)
        {
            ex.ToString();
        }
        return ds;

    }




    public DataSet insert_discount2(string dname, string cat, string addr, string lanmar, string loc, string state, string conper, string ph, string city, string descr, string pincode, string landno)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[12];
            parm[0] = new SqlParameter("@dname", dname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@addr", addr);
            parm[3] = new SqlParameter("@lanmar", lanmar);
            parm[4] = new SqlParameter("@loc", loc);
            parm[5] = new SqlParameter("@state", state);

            parm[6] = new SqlParameter("@conper", conper);
            parm[7] = new SqlParameter("@ph", ph);
            parm[8] = new SqlParameter("@city", city);
            parm[9] = new SqlParameter("@descr", descr);
            parm[10] = new SqlParameter("@pincode", pincode);
            parm[11] = new SqlParameter("@landno", landno);
            ds = obj.ExecuteSQL("insert_discount2", parm);

        }
        catch (Exception ex)
        {
            ex.ToString();
        }
        return ds;

    }


    public DataSet insert_Distributors(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Distributors", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_Doctor(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Doctor", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Documentmanagement(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Documentmanagement", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_Drink(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Drink", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Drinkingwater(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Drinkingwater", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }





    public DataSet insert_Driving(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Driving", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Drugs(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Drugs", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }





    public DataSet insert_DTPworks(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_DTPworks", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }





    public DataSet insert_Dummy1(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Dummy1", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }

    public DataSet insert_Earthmovers(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Earthmovers", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_Education(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Education", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Eggretailshop(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Eggretailshop", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_Electrical(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Electrical", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_Electronic(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Electronic", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_Electronics(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Electronics", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Emergency(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Emergency", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }




    public DataSet insert_Emporium(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Emporium", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }




    public DataSet insert_Engine(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Engine", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Engineering(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Engineering", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_Environment(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Environment", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_EPABX(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_EPABX", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_Equipmenttools(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Equipmenttools", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_Esevacentre(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Esevacentre", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Estate(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Estate", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_EventManagement(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_EventManagement", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_EventMangement(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_EventMangement", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_EventOrganisers(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_EventOrganisers", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Events(string ename, string loc, string occa, DateTime estart, DateTime eend, string addr, string state, DateTime timi, string conper, string ph)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];
            parm[0] = new SqlParameter("@ename", ename);
            parm[1] = new SqlParameter("@loc", loc);
            parm[2] = new SqlParameter("@occa", occa);
            parm[3] = new SqlParameter("@estart", SqlDbType.DateTime, 30, "estart");
            if (estart.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[3].Value = DBNull.Value;

            }
            else
            {

                parm[3].Value = estart;
            }
            parm[4] = new SqlParameter("@eend", SqlDbType.DateTime, 30, "eend");
            if (eend.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[4].Value = DBNull.Value;

            }
            else
            {

                parm[4].Value = eend;
            }
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@timi", SqlDbType.DateTime, 30, "timi");
            if (timi.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[7].Value = DBNull.Value;

            }
            else
            {

                parm[7].Value = timi;
            }

            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@ph", ph);
            ds = obj.ExecuteSQL("insert_Events", parm);


        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;

    }



    public DataSet insert_ExhibitionStall(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_ExhibitionStall", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_Fabricatiion(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Fabrication", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_Fabrics(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Fabrics", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_Fashion(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Fashion", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Faxmachines(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Faxmachines", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Feedbackform(string fname, string mob, string ph, string email, string comm)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[5];

            parm[0] = new SqlParameter("@fname", fname);
            parm[1] = new SqlParameter("@mob", mob);
            parm[2] = new SqlParameter("@ph", ph);
            parm[3] = new SqlParameter("@email", email);
            parm[4] = new SqlParameter("@comm", comm);

            ds = obj.ExecuteSQL("insert_Feedbackform", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_Fertilizer(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Fertilizer", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_Fiber(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Fiber", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_Fibrefilters(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Fibrefilters", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Finance(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Finance", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Fire(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Fire", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_Fisheries(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Fisheries", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Flooring(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Flooring", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_Flooringservices(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Flooringservices", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_Flower(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Flower", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_Foodbeverages(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Foodbeverages", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Footwear(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Footwear", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_Formwork(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Formwork", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Foundryequipment(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Foundryequipment", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }




    public DataSet insert_Freelistingform(string fname, string email, string mob, string lanl, string bname, string kob, string spec, string web, string addr, string lanm, string city, string state, string sia, string pincode, string UserId, string Area)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[18];

            parm[0] = new SqlParameter("@fname", fname);
            parm[1] = new SqlParameter("@email", email);
            parm[2] = new SqlParameter("@mob", mob);
            parm[3] = new SqlParameter("@lanl", lanl);
            parm[4] = new SqlParameter("@bname", bname);
            parm[5] = new SqlParameter("@kob", kob);
            parm[6] = new SqlParameter("@spec", spec);
            parm[7] = new SqlParameter("@web", web);
            parm[8] = new SqlParameter("@addr", addr);
            parm[9] = new SqlParameter("@lanm", lanm);
            parm[10] = new SqlParameter("@city", city);
            parm[11] = new SqlParameter("@state", state);
            parm[12] = new SqlParameter("@sia", sia);
            parm[13] = new SqlParameter("@mod", SqlDbType.NVarChar);
            parm[13].Value = "FreeListing";
            parm[14] = new SqlParameter("@pincode", pincode);
            parm[15] = new SqlParameter("@userid", UserId);
            parm[16] = new SqlParameter("@approvedstatus", SqlDbType.NVarChar);
            parm[16].Value = "0";
            parm[17] = new SqlParameter("@area", Area);
            //parm[15] = new SqlParameter("@postdate", PostDate);
            //parm[16] = new SqlParameter("@expdate", ExpireDate);



            ds = obj.ExecuteSQL("insert_Freelistingform", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }










    public DataSet insert_Fruits(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Fruits", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Fruitsvegetables(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Fruitsvegetables", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Furnishings(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Furnishings", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Furniture(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Furniture", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_Games(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Games", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_GamesToys(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_GamesToys", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Garment(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Garment", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Garments(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Garments", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_Gas(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Gas", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_General(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_General", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Gift(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Gift", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Gifts(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Gifts", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Glass(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Glass", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Glaze(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Glaze", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_Governement(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Governement", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_Government(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Government", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Graphics(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Graphics", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Guesthouses(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Guesthouses", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Gym(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Gym", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_GymFitness(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_GymFitness", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_GymEquipment(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_GymEquipment", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Handicrafts(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Handicrafts", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Handloom(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Handloom", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Hardware(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Hardware", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_Hardwarenetworking(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Hardwarenetworking", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Hardwarenetworks(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Hardwarenetworks", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }

    public DataSet insert_Health(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Health", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Healthcare(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Healthcare", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Hologramproviders(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Hologramproviders", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Homeappliances(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Homeappliances", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_Homeopathy(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Homeopathy", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Horticulture(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Horticulture", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Hospital(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Hospital", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_HospitalEquipment(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_HospitalEquipment", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }




    public DataSet insert_Hospitals(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Hospitals", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }




    public DataSet insert_Hostel(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Hostel", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }





    public DataSet insert_Hotel(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Hotel", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Hotels(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Hotels", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }







    public DataSet insert_Housekeeping(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Housekeeping", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }








    public DataSet insert_Hrdconsultants(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Hrdconsultants", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }




    public DataSet insert_Hydraulic(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Hydraulic", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_HydraulicEquipment(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_HydraulicEquipment", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Ice(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Ice", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_IceCream(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_IceCream", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_Immigration(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Immigration", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_ImportExports(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_ImportExports", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_ImportsExports(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_ImportsExports", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Industries(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Industries", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Industry(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Industry", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Information(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Information", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }




    public DataSet insert_Insulation(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Insulation", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Insurance(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Insurance", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Interior(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Interior", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_Interiors(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Interiors", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_Internet(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Internet", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_Inverters(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Inverters", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_Investment(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Investment", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_Iron(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Iron", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Ironfabricators(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Ironfabricators", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_ISOconsultants(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_ISOconsultants", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Itites(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Itites", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_jewelers(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_jewelers", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_jewelery(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_jewelery", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_jewellery(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_jewellery", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_jigs(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_jigs", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_jobs(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_jobs", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_Kitchen(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Kitchen", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_Lab(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Lab", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }

    public DataSet insert_Laboratory(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Laboratory", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_Lamination(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Lamination", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_LaminationMachines(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_LaminationMachines", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_LandSurvey(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_LandSurvey", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }







    public DataSet insert_Laptops(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Laptops", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_LCDprojectors(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_LCDprojectors", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_Leather(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Leather", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }




    public DataSet insert_Legalservices(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Legalservices", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_Library(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Library", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Lic(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Lic", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_Loan(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Loan", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Loans(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Loans", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_LoansFinancing(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_LoansFinancing", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Lodge(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Lodge", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Logistics(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Logistics", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_Lorry(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Lorry", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_Lubricant(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Lubricant", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Luggage(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Luggage", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Machine(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Machine", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_Machinery(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Machinery", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_MallsStores(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_MallsStores", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Manufacturer(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Manufacturer", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Manufacturers(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Manufacturers", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_Marblegranite(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Marblegranite", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Marine(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Marine", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_Marketing(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Marketing", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_MarketingServices(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_MarketingServices", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_MarriageBureau(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_MarriageBureau", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Massage(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Massage", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Mattress(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Mattress", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_Mechanical(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Mechanical", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_Media(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Media", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Medical(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Medical", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_MeditationYoga(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_MeditationYoga", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Merchants(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Merchants", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_Metal(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Metal", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Mine(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Mine", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_Minerals(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Minerals", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_Mineralwater(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Mineralwater", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_Mining(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Mining", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_Mobile(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Mobile", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_Motor(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Motor", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_Motors(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Motors", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Movies(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Movies", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_Music(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Music", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_NamePlates(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_NamePlates", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }





    public DataSet insert_News(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_News", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }









    public DataSet insert_Nursery(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Nursery", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }




    public DataSet insert_OfficeFurniture(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_OfficeFurniture", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }





    public DataSet insert_Oil(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Oil", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }




    public DataSet insert_Oldagehomes(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Oldagehomes", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_Onlineservices(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Onlineservices", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Optical(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Optical", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Opticals(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Opticals", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Organics(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Organics", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_Orphanage(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Orphanage", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Orphanages(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Orphanages", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_Outsourcingcompany(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Outsourcingcompany", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }




    public DataSet insert_Outsourcingworks(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Outsourcingworks", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }

    public DataSet insert_Overseasconsultant(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Overseasconsultant", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }





    public DataSet insert_Packages(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Packages", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Packaging(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Packaging", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Packagingmaterial(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Packagingmaterial", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_PackersMovers(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_PackersMovers", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_Paint(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Paint", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Painters(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Painters", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_Paints(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Paints", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Paper(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Paper", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_PaperMill(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_PaperMill", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Parcels(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Parcels", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Pesticides(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Pesticides", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_Petroleum(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Petroleum", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Pharmacy(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Pharmacy", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Photo_studio(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Photo_studio", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }









    public DataSet insert_Photocopier(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Photocopier", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_PhotoFilms(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_PhotoFilms", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_PhotoStudio(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_PhotoStudio", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }




    public DataSet insert_Physiotherapy(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Physiotherapy", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Pips(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Pips", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Plastic(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Plastic", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }




    public DataSet insert_Plastics(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Plastics", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Plumber(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Plumber", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Plywood(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Plywood", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }




    public DataSet insert_Police(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Police", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Polyethylene(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Polyethylene", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Polyethyne(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Polyethyne", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_Poojastores(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Poojastores", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Ports(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Ports", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Postoffice(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Postoffice", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Powder(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Powder", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Power1(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Power1", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_Precious(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Precious", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Printers(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Printers", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_PrinterServices(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_PrinterServices", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_PrintersScanners(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_PrintersScanners", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_PrintingDyes(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_PrintingDyes", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }




    public DataSet insert_PrintingDyeslink(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_PrintingDyeslink", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Printingservices(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Printingservices", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Privatefinance(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Privatefinance", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Productionhouse(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Productionhouse", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Pumps(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Pumps", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }

    public DataSet insert_register(string bname, string kindofbusiness, string name, string password, string email, string city, string des, string website, string address, string landmark, string state, string mob, string landline, string fax)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[14];

            parm[0] = new SqlParameter("@bname", bname);
            parm[1] = new SqlParameter("@kindofbusiness", kindofbusiness);
            parm[2] = new SqlParameter("@name", name);
            parm[3] = new SqlParameter("@password", password);
            parm[4] = new SqlParameter("@email", email);
            parm[5] = new SqlParameter("@city", city);
            parm[6] = new SqlParameter("@des", des);
            parm[7] = new SqlParameter("@website", website);
            parm[8] = new SqlParameter("@addr", address);
            parm[9] = new SqlParameter("@landmark", landmark);
            parm[10] = new SqlParameter("@state", state);
            parm[11] = new SqlParameter("@mob", mob);
            parm[12] = new SqlParameter("@landline", landline);
            parm[13] = new SqlParameter("@fax", fax);

            ds = obj.ExecuteSQL("insert_register", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Railways(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Railways", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }




    public DataSet insert_RealEstate(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_RealEstate", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Refrigeration(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Refrigeration", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Refrigerator(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Refrigerator", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Refrigerators(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Refrigerators", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Registrationform(string rname, string mob, string pwd, string rpwd, string email, string city, string vid)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[7];

            parm[0] = new SqlParameter("@rname", rname);
            parm[1] = new SqlParameter("@mob", mob);
            parm[2] = new SqlParameter("@pwd", pwd);
            parm[3] = new SqlParameter("@rpwd", rpwd);
            parm[4] = new SqlParameter("@email", email);
            parm[5] = new SqlParameter("@city", city);
            parm[6] = new SqlParameter("@vid", vid);

            ds = obj.ExecuteSQL("insert_Registrationform", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }




    public DataSet insert_Resort(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Resort", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Resorts(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Resorts", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Restaurant(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Restaurant", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_Retail(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Retail", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Rexine(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Rexine", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Rice(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Rice", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Road(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Road", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }




    public DataSet insert_RoofingMaterial(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_RoofingMaterial", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }




    public DataSet insert_Rope(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Rope", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_RopesLifts(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_RopesLifts", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Rubber(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Rubber", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_Salesandservices(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Salesandservices", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }





    public DataSet insert_Salestax(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Salestax", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Saloon(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Saloon", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Salt(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Salt", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Sanitary(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Sanitary", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_SanitaryWare(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_SanitaryWare", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }




    public DataSet insert_SAP(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_SAP", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Saree(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Saree", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Sbi(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Sbi", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_School(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_School", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_Schools(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Schools", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_Science(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Science", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Scrap(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Scrap", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Screenprojection(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Screenprojection", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Securities(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Securities", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Security1(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Security1", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Securityguards(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Securityguards", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Securityservices(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Securityservices", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_SecuritySystems(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_SecuritySystems", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Seeds(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Seeds", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }




    public DataSet insert_SewingMachine(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_SewingMachine", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_ShareBroker(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_ShareBroker", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }




    public DataSet insert_Shipping(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Shipping", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_ShippingServices(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_ShippingServices", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Shutters(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Shutters", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }




    public DataSet insert_ShuttersGates(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_ShuttersGates", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Signboard(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Signboard", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }




    public DataSet insert_Singboard(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Singboard", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }




    public DataSet insert_Skinclinic(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Skinclinic", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Smartcard(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Smartcard", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }




    public DataSet insert_Softwarecompanies(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Softwarecompanies", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Softwarepackages(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Softwarepackages", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }




    public DataSet insert_Solarenergy(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Solarenergy", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Spices(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Spices", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Sports(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Sports", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_Spring(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Spring", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Springs(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Springs", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Stamp(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Stamp", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Stamps(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Stamps", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Stationery(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Stationery", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Steel(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Steel", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }




    public DataSet insert_Sticker(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Sticker", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_StockExchange(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_StockExchange", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Stone(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Stone", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }




    public DataSet insert_Storagetanks(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Storagetanks", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Store(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Store", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Stores(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Stores", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Studio(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Studio", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_Surgical(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Surgical", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Survey(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Survey", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_Surveygeology(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Surveygeology", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Surveyor(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Surveyor", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Sweets(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Sweets", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_Tailor(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Tailor", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }




    public DataSet insert_Tanks(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Tanks", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_Tarpaulin(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Tarpaulin", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Tax(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Tax", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_TaxConsultant(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_TaxConsultant", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Taxicabs(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Taxicabs", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Tea(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Tea", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Technologies(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Technologies", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_Telecommunication(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Telecommunication", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }




    public DataSet insert_TelecomSolutions(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_TelecomSolutions", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_Temple(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Temple", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_TestingEquipment(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_TestingEquipment", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_Textiles(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Textiles", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Theaters(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Theaters", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Theatre(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Theatre", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Tiles(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Tiles", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Timber(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Timber", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_TimeRecorders(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_TimeRecorders", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Tools(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Tools", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Toursandtravels(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Toursandtravels", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Tourstravels(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Tourstravels", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Trade(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Trade", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Training(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Training", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_TrainingWorks(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_TrainingWorks", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Transport(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Transport", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_Transporters(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Transporters", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_Trust(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Trust", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }


    public DataSet insert_Tyres(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Tyres", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_University(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_University", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Valuerappraiser(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Valuerappraiser", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }




    public DataSet insert_Veterinaryclinic(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Veterinaryclinic", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }




    public DataSet insert_Visualequipments(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Visualequipments", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Ware_House(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Ware_House", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Warehouse(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Warehouse", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Wastepaper(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Wastepaper", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }




    public DataSet insert_Watch(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Watch", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Water(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Water", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Waterproofing(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Waterproofing", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }




    public DataSet insert_Waterpurifier(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Waterpurifier", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Watertank(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Watertank", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Webservicesdealer(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Webservicesdealer", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_WebSolution(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_WebSolution", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Whiteboarddealers(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Whiteboarddealers", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Wines(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Wines", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Wiremesh(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Wiremesh", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }




    public DataSet insert_Wood(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Wood", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Workshop(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Workshop", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Xerox(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Xerox", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet insert_Yoga(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@cname", cname);
            parm[1] = new SqlParameter("@cat", cat);
            parm[2] = new SqlParameter("@area", area);
            parm[3] = new SqlParameter("@ph", ph);
            parm[4] = new SqlParameter("@mob", mob);
            parm[5] = new SqlParameter("@addr", addr);
            parm[6] = new SqlParameter("@state", state);
            parm[7] = new SqlParameter("@conper", conper);
            parm[8] = new SqlParameter("@email", email);
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");
            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

            ds = obj.ExecuteSQL("insert_Yoga", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }



    public DataSet bindAcdealers()
    {
        string qry = "select cname,cat,area from Acdealers";
        DataSet ds = new DataSet();
        ds = obj.ExcuteQry(qry);
        return ds;
    }

    public DataSet bindac1(string sid)
    {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from acdealers where id like '" + sid + "%'";
        DataSet ds = new DataSet();
        ds = obj.ExcuteQry(qry);
        return ds;



    }
    public DataSet countries()
    {
        string qry = "select cname from countries";
        DataSet ds = new DataSet();
        ds = obj.ExcuteQry(qry);
        return ds;


    }

    public DataSet viewphone()
    {
        string qry = "select mob from Acdealers";
        DataSet ds = new DataSet();
        ds = obj.ExcuteQry(qry);
        return ds;
    }

    public DataSet bindcomputers()
    {
        string qry = "select cname,cat,area from computers";
        DataSet ds = new DataSet();
        ds = obj.ExcuteQry(qry);
        return ds;
    }
    public DataSet bindcomputers1(string sid)
    {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from computers where id like '" + sid + "%'";
        DataSet ds = new DataSet();
        ds = obj.ExcuteQry(qry);
        return ds;
    }



    public DataSet bindph(string uid)
    {
        string qry = "select id,mob from acdealers where id like '" + uid + "%'";
        DataSet ds = new DataSet();
        ds = obj.ExcuteQry(qry);
        return ds;
    }



    public DataSet bindacdealer1(string sid)
    {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from acdealers where id like '" + sid + "%'";
        DataSet ds = new DataSet();
        ds = obj.ExcuteQry(qry);
        return ds;

    }
    public DataSet bindpopcat()
    {

        string qry = "select distinct stuff(\"Category\", 22, len(Category), '...') as Pcat,Category,module from modulesdata where module='Category'";
        DataSet ds = new DataSet();
        ds = obj.ExcuteQry(qry);
        return ds;

    }
    public DataSet bindcategory()
    {
        string qry = "select category from categorylist";
        DataSet ds = new DataSet();
        ds = obj.ExcuteQry(qry);
        return ds;

    }
    public DataSet bindFreelistingcategory()
    {
        string qry = "select category from FreeListing_Category";
        DataSet ds = new DataSet();
        ds = obj.ExcuteQry(qry);
        return ds;

    }
    public DataSet bindsponseredlinks(string module)
    {
        string qry = "select * from sponseredlinks where (module in ('" + module + "') or categories in ('" + module + "')) and ad_type='" + "Linked ads" + "'";
        DataSet ds = new DataSet();
        ds = obj.ExcuteQry(qry);
        return ds;
    }
    public DataSet bindbannerads(string module)
    {
        string qry = "select * from sponseredlinks where (module in ('" + module + "') or categories in ('" + module + "')) and ad_type='" + "Banner ads" + "'";
        DataSet ds = new DataSet();
        ds = obj.ExcuteQry(qry);
        return ds;
    }
    public DataSet get_sponser1(string subcat)
    {
        string qry = "select * from subcatageory where cat like'%" + subcat + "%'";
        //string qry = "select * from subcatageory where cat in ('" + subcat + "')";
        DataSet ds = new DataSet();
        ds = obj.ExcuteQry(qry);
        return ds;
    }
    public DataSet get_sponser(string subcat)
    {
        //string qry = "select * from subcatageory where cat like'%" + subcat + "%'";
        string qry = "select * from subcatageory where cat in ('" + subcat + "')";
        DataSet ds = new DataSet();
        ds = obj.ExcuteQry(qry);
        return ds;
    }
    public DataSet bindatoc()
    {
        string qry = "select varac from atoc";
        DataSet ds = new DataSet();
        ds = obj.ExcuteQry(qry);
        return ds;
    }

    public DataSet binddtof()
    {
        string qry = "select vardf from dtof";
        DataSet ds = new DataSet();
        ds = obj.ExcuteQry(qry);
        return ds;

    }

    public DataSet bindgtoi()
    {
        string qry = "select vargi from gtoi";
        DataSet ds = new DataSet();
        ds = obj.ExcuteQry(qry);
        return ds;

    }

    public DataSet bindjtol()
    {
        string qry = "select varjl from jtol";
        DataSet ds = new DataSet();
        ds = obj.ExcuteQry(qry);
        return ds;

    }

    public DataSet bindmtoo()
    {
        string qry = "select varmo from mtoo";
        DataSet ds = new DataSet();
        ds = obj.ExcuteQry(qry);
        return ds;

    }

    public DataSet bindptor()
    {
        string qry = "select varpr from ptor";
        DataSet ds = new DataSet();
        ds = obj.ExcuteQry(qry);
        return ds;

    }

    public DataSet bindstou()
    {
        string qry = "select varsu from stou";
        DataSet ds = new DataSet();
        ds = obj.ExcuteQry(qry);
        return ds;

    }

    public DataSet bindvtoz()
    {
        string qry = "select varvz from vtoz";
        DataSet ds = new DataSet();
        ds = obj.ExcuteQry(qry);
        return ds;

    }

    public DataSet bindcomp()
    {
        string qry = "select computer,symbol from subcat";
        DataSet ds = new DataSet();
        ds = obj.ExcuteQry(qry);
        return ds;

    }

    public DataSet bindpopcities()
    {
        string qry = "select popcities from pop_cities";
        DataSet ds = new DataSet();
        ds = obj.ExcuteQry(qry);
        return ds;

    }


    public DataSet bindA()
    {
        string qry = "select A from cities_A";
        DataSet ds = new DataSet();
        ds = obj.ExcuteQry(qry);
        return ds;

    }

    public DataSet bindB()
    {
        string qry = "select B from cities_B";
        DataSet ds = new DataSet();
        ds = obj.ExcuteQry(qry);
        return ds;

    }

    public DataSet bindC()
    {
        string qry = "select C from cities_C";
        DataSet ds = new DataSet();
        ds = obj.ExcuteQry(qry);
        return ds;

    }

    public DataSet bindD()
    {
        string qry = "select D from cities_D order by D";
        DataSet ds = new DataSet();
        ds = obj.ExcuteQry(qry);
        return ds;

    }

    public DataSet bindE()
    {
        string qry = "select E from cities_E";
        DataSet ds = new DataSet();
        ds = obj.ExcuteQry(qry);
        return ds;

    }

    public DataSet bindF()
    {
        string qry = "select F from cities_F";
        DataSet ds = new DataSet();
        ds = obj.ExcuteQry(qry);
        return ds;

    }

    public DataSet bindG()
    {
        string qry = "select G from cities_G";
        DataSet ds = new DataSet();
        ds = obj.ExcuteQry(qry);
        return ds;

    }

    public DataSet bindH()
    {
        string qry = "select H from cities_H";
        DataSet ds = new DataSet();
        ds = obj.ExcuteQry(qry);
        return ds;

    }

    public DataSet bindI()
    {
        string qry = "select I from cities_I";
        DataSet ds = new DataSet();
        ds = obj.ExcuteQry(qry);
        return ds;

    }

    public DataSet bindJ()
    {
        string qry = "select J from cities_J";
        DataSet ds = new DataSet();
        ds = obj.ExcuteQry(qry);
        return ds;

    }

    public DataSet bindK()
    {
        string qry = "select K from cities_K";
        DataSet ds = new DataSet();
        ds = obj.ExcuteQry(qry);
        return ds;

    }

    public DataSet bindL()
    {
        string qry = "select L from cities_L";
        DataSet ds = new DataSet();
        ds = obj.ExcuteQry(qry);
        return ds;

    }

    public DataSet bindM()
    {
        string qry = "select M from cities_M";
        DataSet ds = new DataSet();
        ds = obj.ExcuteQry(qry);
        return ds;

    }


    public DataSet bindN()
    {
        string qry = "select N from cities_N";
        DataSet ds = new DataSet();
        ds = obj.ExcuteQry(qry);
        return ds;

    }

    public DataSet bindO()
    {
        string qry = "select O from cities_O";
        DataSet ds = new DataSet();
        ds = obj.ExcuteQry(qry);
        return ds;

    }

    public DataSet bindP()
    {
        string qry = "select P from cities_P";
        DataSet ds = new DataSet();
        ds = obj.ExcuteQry(qry);
        return ds;

    }

    public DataSet bindQ()
    {
        string qry = "select Q from cities_Q";
        DataSet ds = new DataSet();
        ds = obj.ExcuteQry(qry);
        return ds;

    }

    public DataSet bindR()
    {
        string qry = "select R from cities_R";
        DataSet ds = new DataSet();
        ds = obj.ExcuteQry(qry);
        return ds;

    }

    public DataSet bindS()
    {
        string qry = "select S from cities_S";
        DataSet ds = new DataSet();
        ds = obj.ExcuteQry(qry);
        return ds;

    }

    public DataSet bindT()
    {
        string qry = "select T from cities_T";
        DataSet ds = new DataSet();
        ds = obj.ExcuteQry(qry);
        return ds;

    }

    public DataSet bindU()
    {
        string qry = "select U from cities_U";
        DataSet ds = new DataSet();
        ds = obj.ExcuteQry(qry);
        return ds;

    }

    public DataSet bindV()
    {
        string qry = "select v from cities_V";
        DataSet ds = new DataSet();
        ds = obj.ExcuteQry(qry);
        return ds;

    }

    public DataSet bindW()
    {
        string qry = "select W from cities_W";
        DataSet ds = new DataSet();
        ds = obj.ExcuteQry(qry);
        return ds;

    }

    public DataSet bindY()
    {
        string qry = "select Y from cities_Y";
        DataSet ds = new DataSet();
        ds = obj.ExcuteQry(qry);
        return ds;

    }

    public DataSet bindcathead()
    {
        string qry = "select category from categoryhead";
        DataSet ds = new DataSet();
        ds = obj.ExcuteQry(qry);
        return ds;

    }
    //public DataSet bindit()
    //{
    //    string qry = "select subcategory_name from JobSubCategories where category_name='IT'";
    //    DataSet ds = new DataSet();
    //    ds = obj.ExcuteQry(qry);
    //    return ds;
    //}
    //public DataSet bindmar()
    //{
    //    string qry = "select subcategory_name from JobSubCategories where category_name='Marketting'";
    //    DataSet ds = new DataSet();
    //    ds = obj.ExcuteQry(qry);
    //    return ds;
    //}
    //public DataSet bindfin()
    //{
    //    string qry = "select subcategory_name from JobSubCategories where category_name='Finance'";
    //    DataSet ds = new DataSet();
    //    ds = obj.ExcuteQry(qry);
    //    return ds;
    //}
    //public DataSet bindhr()
    //{
    //    string qry = "select subcategory_name from JobSubCategories where category_name='HR'";
    //    DataSet ds = new DataSet();
    //    ds = obj.ExcuteQry(qry);
    //    return ds;
    //}
    //public DataSet bindoth()
    //{
    //    string qry = "select subcategory_name from JobSubCategories where category_name='Others'";
    //    DataSet ds = new DataSet();
    //    ds = obj.ExcuteQry(qry);
    //    return ds;
    //}
    public DataSet bindleftjob()
    {
        string qry = "select *,stuff(\"cat\", 22, len(cat), '...') as JCate,cat from subcatageory where maincat='Jobs' order by JCate";
        DataSet ds = new DataSet();
        ds = obj.ExcuteQry(qry);
        return ds;
    }
    public DataSet bindjobs()
    {
        string qry = "select id,company_name,job_exp,job_desc,city,mob from modulesdata where module='jobs'";
        DataSet ds = new DataSet();
        ds = obj.ExcuteQry(qry);
        return ds;
    }
    //public DataSet bindcor()
    //{
    //    string qry = "select cat from subcatageory where maincat='corporate'";
    //    DataSet ds = new DataSet();
    //    ds = obj.ExcuteQry(qry);
    //    return ds;
    //}
    //public DataSet bindpvt()
    //{
    //    string qry = "select cat from subcatageory where maincat='private'";
    //    DataSet ds = new DataSet();
    //    ds = obj.ExcuteQry(qry);
    //    return ds;
    //}
    //public DataSet bindpub()
    //{
    //    string qry = "select cat from subcatageory where maincat='public'";
    //    DataSet ds = new DataSet();
    //    ds = obj.ExcuteQry(qry);
    //    return ds;
    //}
    public DataSet bindevent()
    {
        string qry = "select distinct stuff(\"cat\", 22, len(cat), '...') as Ecatname,cat from subcatageory where maincat='Events' order by Ecatname";
        DataSet ds = new DataSet();
        ds = obj.ExcuteQry(qry);
        return ds;
    }
    public DataSet bindcat()
    {
        string qry = "select cat from subcatageory where maincat='Discounts' order by cat";
        DataSet ds = new DataSet();
        ds = obj.ExcuteQry(qry);
        return ds;
    }
    public DataSet bindCategories(string Category)
    {
        string qry = "select Top 4 * from  subcatageory where maincat='" + Category + "' order by cat asc";
        DataSet ds = new DataSet();
        ds = obj.ExcuteQry(qry);
        return ds;
    }
    public DataSet bindCategories(int top, string Category)
    {
        string qry = "select Top " + top + " * from  subcatageory where maincat='" + Category + "' order by cat asc";
        DataSet ds = new DataSet();
        ds = obj.ExcuteQry(qry);
        return ds;
    }
    public DataSet bindCategories(string Category1, string Category2)
    {
        string qry = "select top 4 * from  subcatageory where maincat in('" + Category1 + "','" + Category2 + "') order by cat asc";
        DataSet ds = new DataSet();
        ds = obj.ExcuteQry(qry);
        return ds;
    }
    public DataSet bindCategories(int top, string Category1, string Category2)
    {
        string qry = "select top " + top + " * from  subcatageory where maincat in('" + Category1 + "','" + Category2 + "') order by cat asc";
        DataSet ds = new DataSet();
        ds = obj.ExcuteQry(qry);
        return ds;
    }
    public DataSet bindCategories(string Category1, string Category2, string Category3)
    {
        string qry = "select top 4 * from  subcatageory where maincat in('" + Category1 + "','" + Category2 + "','" + Category3 + "') order by cat asc";
        DataSet ds = new DataSet();
        ds = obj.ExcuteQry(qry);
        return ds;
    }
    public DataSet bindCategories(int top, string Category1, string Category2, string Category3)
    {
        string qry = "select top " + top + " * from  subcatageory where maincat in('" + Category1 + "','" + Category2 + "','" + Category3 + "') order by cat asc";
        DataSet ds = new DataSet();
        ds = obj.ExcuteQry(qry);
        return ds;
    }
    public DataSet bindb2bCategories(string Category)
    {
        string qry = "select Top 3 * from b2bcategories where maincat='" + Category + "' order by cat asc";
        DataSet ds = new DataSet();
        ds = obj.ExcuteQry(qry);
        return ds;
    }
    public DataSet bindb2bCategories(int top, string Category)
    {
        string qry = "select Top " + top + " * from b2bcategories where maincat='" + Category + "' order by cat asc";
        DataSet ds = new DataSet();
        ds = obj.ExcuteQry(qry);
        return ds;
    }
    public DataSet bindPopCat(string str)
    {
        string qry = "select cat from subcatageory where cat like'" + str + "%' order by cat asc";
        DataSet ds = new DataSet();
        ds = obj.ExcuteQry(qry);
        return ds;
    }

    public DataSet bindB2bCat(string str)
    {
        string qry = "select cat from b2bcategories  where cat like'" + str + "%' order by cat asc";
        DataSet ds = new DataSet();
        ds = obj.ExcuteQry(qry);
        return ds;
    }
    public DataSet bindlife()
    {
        string qry = "select cat from subcatageory where maincat='Lifestyle' order by cat";
        DataSet ds = new DataSet();
        ds = obj.ExcuteQry(qry);
        return ds;

    }
    public DataSet bindlifepopcat()
    {
        string qry = "select popcat from poplifestyle order by popcat";
        DataSet ds = new DataSet();
        ds = obj.ExcuteQry(qry);
        return ds;

    }


    public DataSet bindlifepopbrand()
    {
        string qry = "select popbrand from poplifestyle where popbrand!='null' order by popbrand";
        DataSet ds = new DataSet();
        ds = obj.ExcuteQry(qry);
        return ds;

    }
    public DataSet bindlifebrand()
    {
        string qry = "select distinct SubCategeory from Lifestyle order by SubCategeory";
        DataSet ds = new DataSet();
        ds = obj.ExcuteQry(qry);
        return ds;

    }
    public DataSet bindlifeleft(string cat)
    {
        string qry = "select distinct stuff(\"CatSub\", 22, len(CatSub), '...') as catSname,CatSub,Categeory from lifestyle where  Categeory like '" + "%" + cat + "%" + "'order by Categeory";
        DataSet ds = new DataSet();
        ds = obj.ExcuteQry(qry);
        return (ds);
    }
    public DataSet Hyd_Location(string loc)
    {
        string qry = "select Distinct(comp_city) from jcalluzCareers";
        DataSet ds = new DataSet();
        ds = obj.ExcuteQry(qry);
        return ds;
    }
    public DataSet careersinfo(int id)
    {
        string qry = "select * from jcalluzCareers where jobid=" + id;
        DataSet ds = new DataSet();
        ds = obj.ExcuteQry(qry);
        return ds;
    }
    public DataSet insert_searchnotfound(string city, string location, string name, string email, string company, string product, string comments)
    {

        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[7];

            parm[0] = new SqlParameter("@city", city);
            parm[1] = new SqlParameter("@location", location);
            parm[2] = new SqlParameter("@name", name);
            parm[3] = new SqlParameter("@email", email);
            parm[4] = new SqlParameter("@company", company);
            parm[5] = new SqlParameter("@product", product);
            parm[6] = new SqlParameter("@comments", comments);

            ds = obj.ExecuteSQL("insert_SearchnotFound", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
        return ds;
    }
    public DataSet bindcompanies(string comp)
    {
        try
        {
            string qry = "select distinct(company_name),id from ModulesData where city='" + comp + "'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet binddefaultmovies()
    {
        try
        {
            string qry = "select top 5 * from Movies order by mid desc";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet bindPopotherCities()
    {
        try
        {
            string qry = "select * from popcities_other order by id";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }

    //JC_ReverseAuction

    public DataSet bindJC_Area(string city)
    {
        try
        {
            string qry = "select Top 1 Category,Area,City from modulesdata where City='" + city + "'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet bindJC_Cate(string Category, string city)
    {
        try
        {
            string qry = "select distinct Top 6 SubCategory from modulesdata where Category='" + Category + "' and City='" + city + "'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet bindJC_Cate1(string Category1, string city1)
    {
        try
        {
            string qry = "select Distinct(SubCategory) from modulesdata where Category='" + Category1 + "' and City='" + city1 + "'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet bindJC_CmpDetails(string cate, string City)
    {
        try
        {
            string qry = "select top 5 * from modulesdata where SubCategory='" + cate + "' and City='" + City + "'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet bindJC_TopCmpDetails(string cate1, string City1)
    {
        try
        {
            string qry = "select Top 7 * from modulesdata where SubCategory='" + cate1 + "' and City='" + City1 + "'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    //Hotels
    public DataSet search_bindcities(string letter)
    {
        try
        {
            string qry = "select * from cities where city_name like'" + letter + "%" + "'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet gethotels(string city)
    {
        try
        {
            string qry = "select top 10 * from modulesdata where (Category='5 Star Hotels' or Category='Luxury Restaurants' or Category='Hotels & Resorts' or Category='Restaurant & Pubs') and City='" + city + "' and ApprovedStatus=1 order by 1 desc";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet gethotel_det(string city, string compname, string area)
    {
        try
        {
            if (area != "null")
            {
                string qry = "select *,stuff(\"company_name\", 22, len(company_name), '...') as compname,company_name from modulesdata where (Category like '" + "%" + compname + "%" + "' or company_name like '" + "%" + compname + "%" + "' or SubCategory like '" + "%" + compname + "%" + "') and City='" + city + "' and Area='" + area + "' and ApprovedStatus=1";
                ds = obj.ExcuteQry(qry);
            }
            else
            {
                string qry = "select *,stuff(\"company_name\", 22, len(company_name), '...') as compname,company_name from modulesdata where (Category like '" + "%" + compname + "%" + "' or company_name like '" + "%" + compname + "%" + "' or SubCategory like '" + "%" + compname + "%" + "') and City='" + city + "' and ApprovedStatus=1";
                ds = obj.ExcuteQry(qry);
            }
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    //Testimonials

    public DataSet BindTestimonial_Det()
    {
        try
        {
            string qry = "select Id,EmailAddress=stuff(EmailAddress,3,5,'*****'),MobileNo,State,City,ImageName,ImageContentType,Views,PostDate,Status,nick_name from TestimonialView where (Status=1 or Status=0) order By Id desc";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    /// <summary>
    /// Replace the special characters with user defined names for specific value 
    /// </summary>
    /// <param name="link_catname"></param>
    /// <returns></returns>
    public string ReplaceSpecialchars(string link_catname)
    {
        if (link_catname.Contains("&"))
        {
            link_catname = link_catname.Replace("&", "amprcent");
        }
        if (link_catname.Contains(" "))
        {
            link_catname = link_catname.Replace(" ", "space");
        }
        if (link_catname.Contains("."))
        {
            link_catname = link_catname.Replace(".", "Dot");
        }
        if (link_catname.Contains("/"))
        {
            link_catname = link_catname.Replace("/", "slash");
        }
        if (link_catname.Contains("_"))
        {
            link_catname = link_catname.Replace("_", "undrscore");
        }
        if (link_catname.Contains("-"))
        {
            link_catname = link_catname.Replace("-", "hypen");
        }
        return link_catname;
    }
    /// <summary>
    /// Replace the user defined names with corresponding symbols for value
    /// </summary>
    /// <param name="link_originalchars"></param>
    /// <returns></returns>
    public string ReplaceCatnamewithorginalchars(string link_originalchars)
    {
        if (link_originalchars.Contains("amprcent"))
        {
            link_originalchars = link_originalchars.Replace("amprcent", "&");
        }
        if (link_originalchars.Contains("space"))
        {
            link_originalchars = link_originalchars.Replace("space", " ");
        }
        if (link_originalchars.Contains("Dot"))
        {
            link_originalchars = link_originalchars.Replace("Dot", ".");
        }
        if (link_originalchars.Contains("slash"))
        {
            link_originalchars = link_originalchars.Replace("slash", "/");
        }
        if (link_originalchars.Contains("undrscore"))
        {
            link_originalchars = link_originalchars.Replace("undrscore", "_");
        }
        if (link_originalchars.Contains("hypen"))
        {
            link_originalchars = link_originalchars.Replace("hypen", "-");
        }
        return link_originalchars;
    }
}