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
/// Summary description for Editdata
/// </summary>
public class Editdata
{
    DataAccess obj = new DataAccess();
	public Editdata()
	{
		//
		// TODO: Add constructor logic here
		//
	}


    public DataSet edit_AccountingServices(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_AccountingServices", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_ACdealers(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_ACdealers", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_AcousticEnclosure(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_AcousticEnclosure", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }


    public DataSet edit_Adhesives(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Adhesives", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_AdhesiveTape(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_AdhesiveTape", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Advertising(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Advertising", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }


    public DataSet edit_Advocate(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Advocate", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Advocatelawyers(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Advocatelawyers", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }

    public DataSet edit_Aerospace(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Aerospace", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Agarbatti(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Agarbatti", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }


    public DataSet edit_Agency(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Agency", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }


    public DataSet edit_Agriculture(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Agriculture", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }


    public DataSet edit_Aircompressor(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Aircompressor", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }


    public DataSet edit_Aircompressors(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Aircompressors", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Airconditioners(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Airconditioners", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Airfilters(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Airfilters", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Airlines(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Airlines", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Alcoholwines(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Alcoholwines", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_AlternateEnergy(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_AlternateEnergy", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }


    public DataSet edit_AlternativeEnergy(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_AlternativeEnergy", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }


    public DataSet edit_Aluminium(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Aluminium", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }


    public DataSet edit_Ambulance(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Ambulance", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }


    public DataSet edit_AmbulanceServices(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_AmbulanceServices", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }


    public DataSet edit_Animal(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Animal", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }


    public DataSet edit_AnimalHusbandry(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_AnimalHusbandry", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Antivibration(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Antivibration", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Apparel(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Apparel", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_AquaCulture(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_AquaCulture", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_AquaEquipment(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_AquaEquipment", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_ArmsAmmunition(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_ArmsAmmunition", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_ArtGallery(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_ArtGallery", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Artscrafts(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Artscrafts", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Asbestos(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Asbestos", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }


    public DataSet edit_Ashram(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Ashram", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Atm(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Atm", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_AudioVideo(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_AudioVideo", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }


    public DataSet edit_Automobile(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Automobile", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_Automobiles(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Automobiles", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_Ayurvedic(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Ayurvedic", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Bag(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Bag", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }


    public DataSet edit_Bakery(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Bakery", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }


    public DataSet edit_Bank(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Bank", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Banquethall(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Banquethall", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }


    public DataSet edit_BarNightclubs(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_BarNightclubs", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_BarRestaurant(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_BarRestaurant", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Battery(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Battery", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Beautyparlour(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Beautyparlour", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Bellows(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Bellows", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Billingmachine(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Billingmachine", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Biological(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Biological", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Biotech(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Biotech", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Blasting(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Blasting", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Boat(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Boat", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Boilers(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Boilers", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Bolt(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Bolt", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_Boltsnuts(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Boltsnuts", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Book(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Book", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_Borewell(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Borewell", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }





    public DataSet edit_Boutiques(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Boutiques", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_BPOcompanies(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_BPOcompanies", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_Bricks(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Bricks", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Broker(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Broker", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Brokers(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Brokers", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Builders(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Builders", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }


    public DataSet edit_Building(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Building", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Bureau(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Bureau", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }


    public DataSet edit_Business(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Business", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }


    public DataSet edit_Camera(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Camera", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }


    public DataSet edit_Canvassing(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Canvassing", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Car(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Car", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }


    public DataSet edit_Carbon(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Carbon", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }


    public DataSet edit_CardDealers(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_CardDealers", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }


    public DataSet edit_CardsDealer(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_CardsDealer", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Carecentre(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Carecentre", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Cargo(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Cargo", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Carparkinglift(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Carparkinglift", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }


    public DataSet edit_Carpenter(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Carpenter", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }

    public DataSet edit_Cars(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Cars", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Caterers(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Caterers", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }


    public DataSet edit_Categories(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Categories", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Cement(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Cement", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }


    public DataSet edit_Ceramic(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Ceramic", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }


    public DataSet edit_Ceramics(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Ceramics", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }


    public DataSet edit_CFagents(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_CFagents", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }


    public DataSet edit_Charity (int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Charity", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Chemical(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Chemical", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_ChineseRestaurant(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_ChineseRestaurant", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Civil(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Civil", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_CleaningServices(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_CleaningServices", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Clinic(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Clinic", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_ClinicBloodbank(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_ClinicBloodbank", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Cloth(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Cloth", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Club(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Club", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }


    public DataSet edit_Clubs(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Clubs", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Clubsparks(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Clubsparks", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Coffee(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Coffee", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Coirefibre(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Coirefibre", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_College(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_College", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Commercial(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Commercial", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_Communication(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Communication", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Communications(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Communications", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Company(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Company", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }


    public DataSet edit_Compressor(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Compressor", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Computer(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Computer", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Computers(string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim,string sid)
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
            parm[9] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[9].Value = DBNull.Value;
            }
            else
            {
                parm[9].Value = optim;
            }

               parm[10] = new SqlParameter("@id", sid);
            ds = obj.ExecuteSQL("edit_Computers", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Concrete(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Concrete", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Construction(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Construction", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_Constructions(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Constructions", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_Consultant(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Consultant", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Consultants(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Consultants", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_Contractor(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Contractor", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }

    public DataSet edit_Control(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Control", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Controlpanels(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Controlpanels", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }


    public DataSet edit_Conveyer(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Conveyer", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }

    public DataSet edit_Conveyers(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Conveyers", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }
    public DataSet edit_Conveyors(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Conveyors", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }


    public DataSet edit_Conveyorsystems(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Conveyorsystems", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }


    public DataSet edit_Corporate(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Corporate", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_Corrugatedbox(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Corrugatedbox", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_Cosmetic(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Cosmetic", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Cotton(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Cotton", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_Counselling(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Counselling", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Courier(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Courier", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_CourierLogistics(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_CourierLogistics", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_Crafts(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Crafts", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Crane(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Crane", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_Credit(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Credit", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Cycle(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Cycle", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_CycleStores(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_CycleStores", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_Dairy(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Dairy", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_Dance(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Dance", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Dealer(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Dealer", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Dental(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Dental", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Designer(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Designer", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }





    public DataSet edit_Designers(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Designers", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Designgraphics(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Designgraphics", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Detectiveagencies(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Detectiveagencies", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }


    public DataSet edit_Diagnostics(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Diagnostics", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Digital(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Digital", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }


    public DataSet edit_Discount(string dname, string cat, DateTime sdate, DateTime edate, string addr, string lanmar, string loc, string state, DateTime timi, string conper, string ph,int id)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[12];
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
            
            parm[9] = new SqlParameter("conper", conper);
            parm[10] = new SqlParameter("@ph", ph);
            parm[11] = new SqlParameter("@id", id);
            ds = obj.ExecuteSQL("eidt_Discount", parm);
        }
        catch (Exception ex)
        {
            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Distributors(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Distributors", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Doctor(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Doctor", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Documentmanagement(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Documentmanagement", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Drink(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Drink", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }





    public DataSet edit_Drinkingwater(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Drinkingwater", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_Driving(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Driving", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_Drugs(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Drugs", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }





    public DataSet edit_DTPworks(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_DTPworks", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }





    public DataSet edit_Dummy1(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Dummy1", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_Earthmovers(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Earthmovers", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Education(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Education", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_Eggretailshop(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Eggretailshop", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Electrical(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Electrical", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_Electronic(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Electronic", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_Electronics(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Electronics", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }


    public DataSet edit_Elevators(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Elevators", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }





    public DataSet edit_Emergency(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Emergency", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Emporium(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Emporium", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Engine(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Engine", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_Engineering(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Engineering", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Environment(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Environment", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_EPABX(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_EPABX", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }


    public DataSet edit_EquipmentTools(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_EquipmentTools", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Esevacentre(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Esevacentre", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Estate(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Estate", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_EventManagement(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_EventManagement", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_EventMangement(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_EventMangement", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_EventOrganisers(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_EventOrganisers", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Events(string ename, string loc, string occa, DateTime estart, DateTime eend, string addr, string state, DateTime timi, string conper, string ph)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[10];
            parm[0] = new SqlParameter("@ename", ename);
            parm[1] = new SqlParameter("@loc", loc);
            parm[2] = new SqlParameter("@occa", occa);
            parm[3] = new SqlParameter("@estart",SqlDbType.DateTime, 30, "estart");
            if (estart.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[3].Value = DBNull.Value;

            }
            else
            {

                parm[3].Value = estart;
            }
            parm[4] = new SqlParameter("@eend",SqlDbType.DateTime, 30, "eend");
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
            parm[7] = new SqlParameter("@timi",SqlDbType.DateTime, 30, "timi");
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
          
            ds = obj.ExecuteSQL("edit_Events", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;

    }





    public DataSet edit_ExhibitionStall(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_ExhibitionStall", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Fabrication(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Fabrication", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_Fabrics(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Fabrics", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Fashion(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Fashion", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Faxmachines(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Faxmachines", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_Fertilizer(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Fertilizer", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_Fiber(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Fiber", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Fibrefilters(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Fibrefilters", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_Finance(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Finance", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_Fire(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Fire", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }





    public DataSet edit_Fisheries(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Fisheries", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_Flooring(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Flooring", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_Flooringservices(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Flooringservices", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_Flower(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Flower", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Foodbeverages(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Foodbeverages", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Footwear(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Footwear", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }


    public DataSet edit_Formwork(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Formwork", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Foundryequipment(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Foundryequipment", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_Fruits(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Fruits", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Fruitsvegetables(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Fruitsvegetables", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Furnishings(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Furnishings", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Furniture(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Furniture", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_Games(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Games", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }





    public DataSet edit_GamesToys(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_GamesToys", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }





    public DataSet edit_Garment(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Garment", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_Garments(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Garments", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Gas(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Gas", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_General(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_General", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_Gift(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Gift", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Gifts(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Gifts", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_Glass(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Glass", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }





    public DataSet edit_Glaze(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Glaze", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_Governement(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Governement", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }





    public DataSet edit_Government(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Government", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Graphics(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Graphics", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_Guesthouses(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Guesthouses", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_Gym(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Gym", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_GymFitness(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_GymFitness", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }


    public DataSet edit_GymEquipment(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_GymEquipment", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }


    public DataSet edit_Handicrafts(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Handicrafts", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_Handloom(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Handloom", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_Hardware(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Hardware", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Hardwarenetworking(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Hardwarenetworking", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_Hardwarenetworks(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Hardwarenetworks", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_Health(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Health", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }





    public DataSet edit_HealthCare(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_HealthCare", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }





    public DataSet edit_Hologramproviders(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Hologramproviders", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }





    public DataSet edit_Homeappliances(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Homeappliances", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }





    public DataSet edit_Homeopathy(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Homeopathy", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Horticulture(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Horticulture", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_Hospital(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Hospital", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Hospitals(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Hospitals", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_HospitalEquipment(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_HospitalEquipment", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_Hostel(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Hostel", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_Hotel (int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Hotel", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }


    public DataSet edit_Hotels(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Hotels", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Housekeeping(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Housekeeping", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_Hrdconsultants(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Hrdconsultants", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Hydraulic(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Hydraulic", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }





    public DataSet edit_HydraulicEquipment(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_HydraulicEquipment", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }





    public DataSet edit_Ice(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Ice", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_IceCream(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_IceCream", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_Immigration(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Immigration", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }


    public DataSet edit_ImportExport(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_ImportExport", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }





    public DataSet edit_ImportsExports(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_ImportsExports", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_Industries(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Industries", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }





    public DataSet edit_Industry(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Industry", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_Information(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Information", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }





    public DataSet edit_Insulation(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Insulation", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_Insurance(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Insurance", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_Interior(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Interior", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_Interiors(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Interiors", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }





    public DataSet edit_Internet(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Internet", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_Inverters(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Inverters", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }





    public DataSet edit_Investment(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Investment", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }






    public DataSet edit_Iron(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Iron", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Ironfabricators(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Ironfabricators", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_ISOconsultants(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_ISOconsultants", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Itites(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Itites", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_jewelers(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_jewelers", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_jewelery(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_jewelery", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_jewellery(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_jewellery", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }





    public DataSet edit_jigs(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_jigs", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_jobs(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_jobs", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }





    public DataSet edit_Kitchen(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Kitchen", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_Lab(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Lab", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }


    public DataSet edit_Laboratory(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Laboratory", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }






    public DataSet edit_Lamination(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Lamination", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_LaminationMachines(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_LaminationMachines", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_LandSurvey(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_LandSurvey", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }





    public DataSet edit_Laptop(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Laptop", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_LCDprojectors(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_LCDprojectors", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }





    public DataSet edit_Leather(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Leather", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }





    public DataSet edit_Legalservices(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Legalservices", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }





    public DataSet edit_Library(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Library", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }





    public DataSet edit_Lic(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Lic", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }





    public DataSet edit_Loan(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Loan", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }





    public DataSet edit_Loans(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Loans", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_LoansFinancing(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_LoansFinancing", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_Lodge(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Lodge", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_Logistics(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Logistics", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }





    public DataSet edit_Lorry(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Lorry", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }





    public DataSet edit_Lubricant(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Lubricant", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }





    public DataSet edit_Luggage(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Luggage", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }





    public DataSet edit_Machine(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Machine", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_Machinery(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Machinery", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_MallsStores(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_MallsStores", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Manufacturer(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Manufacturer", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Manufacturers(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Manufacturers", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_Marblegranite(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Marblegranite", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Marine(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Marine", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Marketing(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Marketing", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_MarketingServices(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_MarketingServices", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_MarriageBureau(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_MarriageBureau", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Massage(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Massage", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_Mattress(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Mattress", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }





    public DataSet edit_Mechanical(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Mechanical", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_Media(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Media", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }





    public DataSet edit_Medical(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Medical", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_MeditationYoga(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_MeditationYoga", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }





    public DataSet edit_Merchants(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Merchants", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }





    public DataSet edit_Metal(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Metal", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }





    public DataSet edit_Mine(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Mine", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }





    public DataSet edit_Minerals(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Minerals", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_MineralWater(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_MineralWater", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_Mining(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Mining", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }


    public DataSet edit_Mobile(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Mobile", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_Motor(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Motor", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Motors(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Motors", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Movies(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Movies", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_Music(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Music", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_NamePlates(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_NamePlates", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_News(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_News", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_Nursery(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Nursery", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_OfficeFurniture(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_OfficeFurniture", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }






    public DataSet edit_Oil(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Oil", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_oldagehomes(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_oldagehomes", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_onlineservices(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_onlineservices", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_optical(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_optical", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_opticals(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_opticals", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_Organics(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Organics", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_Orphanage(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Orphanage", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_Orphanages(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Orphanages", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_Outsourcingcompany(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Outsourcingcompany", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_Outsourcingworks(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Outsourcingworks", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }

    public DataSet edit_Overseasconsultant(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Overseasconsultant", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_packages(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_packages", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_packaging(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_packaging", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_packagingmaterial(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_packagingmaterial", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_packersMovers(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_packersMovers", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_paint(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_paint", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_painters(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_painters", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_paints(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_paints", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_paper(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_paper", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_paperMill(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_paperMill", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_parcels(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_parcels", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }


    public DataSet edit_pesticides(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_pesticides", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_petroleum(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_petroleum", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_pharmacy(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_pharmacy", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_photo_studio(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_photo_studio", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_photocopier(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_photocopier", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_photoFilms(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_photoFilms", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_photoStudio(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_photoStudio", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_Physiotherapy(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Physiotherapy", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_pips(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_pips", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_plastic(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_plastic", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_plastics(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_plastics", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_plumber(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_plumber", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_plywood(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_plywood", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_police(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_police", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_polyethylene(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_polyethylene", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_polyethyne(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_polyethyne", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_poojastores(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_poojastores", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_ports(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_ports", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_postoffice(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_postoffice", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_powder(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_powder", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_power1(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_power1", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_precious(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_precious", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_printers(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_printers", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_printerServices(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_printerServices", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_printersScanners(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_printersScanners", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_printingDyes(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_printingDyes", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_printingDyesink(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_printingDyesink", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_printingservices(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_printingservices", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_privatefinance(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_privatefinance", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_productionhouse(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_productionhouse", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_pumps(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_pumps", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_Railways(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Railways", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_RealEstate(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_RealEstate", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Refrigeration(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Refrigeration", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_Refrigerator(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Refrigerator", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Refrigerators(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Refrigerators", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }


    public DataSet edit_Resort(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Resort", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Resorts(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Resorts", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_Restaurant(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Restaurant", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Retail(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Retail", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_Rexine(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Rexine", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_Rice(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Rice", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_Road(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Road", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_RoofingMaterial(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_RoofingMaterial", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Rope(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Rope", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_RopesLifts(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_RopesLifts", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_Rubber(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Rubber", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }





    public DataSet edit_Salesandservices(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Salesandservices", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }






    public DataSet edit_Salestax(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Salestax", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_Saloon(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Saloon", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Salt(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Salt", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }





    public DataSet edit_Sanitary(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Sanitary", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_SanitaryWare(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_SanitaryWare", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_SAP(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_SAP", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Saree(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Saree", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Sbi(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Sbi", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_School(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_School", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_Schools(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Schools", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_Science(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Science", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_Scrap(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Scrap", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }





    public DataSet edit_Screenprojection(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Screenprojection", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }





    public DataSet edit_Securities(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Securities", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }






    public DataSet edit_Security1(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Security1", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }





    public DataSet edit_Securityguards(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Securityguards", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_Securityservices(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Securityservices", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }





    public DataSet edit_Securitysystems(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Securitysystems", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Seeds(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Seeds", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_SewingMachine(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_SewingMachine", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_ShareBroker(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_ShareBroker", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Shipping(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Shipping", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_ShippingServices(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_ShippingServices", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Shutters(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Shutters", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_ShuttersGates(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_ShuttersGates", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Signboard(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Signboard", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_Singboard(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Singboard", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_Skinclnic(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Skinclinic", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_Smartcard(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Smartcard", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Softwarecompanies(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Softwarecompanies", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_SoftwarePackages(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_SoftwarePackages", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Solarenergy(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Solarenergy", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }





    public DataSet edit_Spices(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Spices", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_Sports(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Sports", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Spring(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Spring", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }





    public DataSet edit_Springs(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Springs", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_Stamp(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Stamp", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Stamps(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Stamps", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }





    public DataSet edit_Stationery(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Stationery", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_Steel(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Steel", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }


    public DataSet edit_Sticker(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Sticker", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_StockExchange(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_StockExchange", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_Stone(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Stone", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_Storagetanks(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Storagetanks", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_Store(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Store", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_Stores(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Stores", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Studio(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Studio", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_Surgical(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Surgical", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Survey(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Survey", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }





    public DataSet edit_Surveygeology(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Surveygeology", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_Surveyor(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Surveyor", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_Sweets(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Sweets", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_Tailor(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Tailor", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }





    public DataSet edit_Tanks(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Tanks", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_Tarpaulin(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Tarpaulin", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_Tax(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Tax", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_TaxConsultant(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_TaxConsultant", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Taxicabs(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Taxicabs", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_Tea(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Tea", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }





    public DataSet edit_Technologies(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Technologies", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_Telecommunication(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Telecommunication", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }





    public DataSet edit_TelecomSolutions(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_TelecomSolutions", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_Temple(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Temple", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_TestingEquipment(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_TestingEquipment", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Textiles(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Textiles", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }





    public DataSet edit_Theaters(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Theaters", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_Theatre(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Theatre", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_Tiles(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Tiles", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_Timber(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Timber", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_TimeRecorders(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_TimeRecorders", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Tools(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Tools", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_ToolsEquipment(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_ToolsEquipment", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_Toursandtravels(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Toursandtravels", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Tourstravels(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Tourstravels", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }






    public DataSet edit_Trade(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Trade", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }





    public DataSet edit_Training(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Training", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_TrainingWorks(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_TrainingWorks", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_Transport(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Transport", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_Transporters(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Transporters", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_Trust(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Trust", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_Tyres(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Tyres", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_University(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_University", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_valuerappraiser(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_valuerappraiser", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }





    public DataSet edit_veterinaryclinic(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_veterinaryclinic", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_visualequipments(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_visualequipments", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Ware_House(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Ware_House", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_Warehouse(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Warehouse", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_WashingMachine(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_WashingMachine", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Wastepaper(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Wastepaper", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_Watch(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Watch", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }





    public DataSet edit_Water(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Water", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Waterproofing(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Waterproofing", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_Waterpurifier(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Waterpurifier", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_Watertank(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Watertank", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_WebServicedealer(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_WebServicedealer", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_WebSolution(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_WebSolution", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_Whiteboarddealers(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Whiteboarddealers", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Wines(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Wines", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_Wiremesh(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Wiremesh", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }



    public DataSet edit_Wood(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Wood", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }




    public DataSet edit_Workshop(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Workshop", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }





    public DataSet edit_Xerox(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Xerox", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }





    public DataSet edit_Yoga(int id, string cname, string cat, string area, string ph, string mob, string addr, string state, string conper, string email, DateTime optim)
    {
        DataSet ds = new DataSet();
        try
        {
            SqlParameter[] parm = new SqlParameter[11];
            parm[0] = new SqlParameter("@id", id);
            parm[1] = new SqlParameter("@cname", cname);
            parm[2] = new SqlParameter("@cat", cat);
            parm[3] = new SqlParameter("@area", area);
            parm[4] = new SqlParameter("@ph", ph);
            parm[5] = new SqlParameter("@mob", mob);
            parm[6] = new SqlParameter("@addr", addr);
            parm[7] = new SqlParameter("@state", state);
            parm[8] = new SqlParameter("@conper", conper);
            parm[9] = new SqlParameter("@email", email);
            parm[10] = new SqlParameter("@optim", SqlDbType.DateTime, 30, "optim");

            if (optim.ToString() == "01/01/0001 12:00:00 AM")
            {
                parm[10].Value = DBNull.Value;
            }
            else
            {
                parm[10].Value = optim;
            }
            ds = obj.ExecuteSQL("edit_Yoga", parm);

        }
        catch (Exception ex)
        {

            ex.ToString();
        }
        return ds;
    }











































































































    




}  