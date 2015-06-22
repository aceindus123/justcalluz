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

/// <summary>
/// Summary description for Deletedata
/// </summary>
public class Deletedata
{
    DataAccess obj = new DataAccess();
    public Deletedata()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public DataSet delete_Automobile(int pid)
    {
        string qry = "delete from Automobile where id='" + pid + "'";
        DataSet ds = new DataSet();
        ds = obj.ExcuteQry(qry);
        return ds;

    }


    public DataSet delete_Advertising(int pid)
    {
        string qry = "delete from Advertising where id='" + pid + "'";
        DataSet ds = new DataSet();
        ds = obj.ExcuteQry(qry);
        return ds;

    }



    public DataSet delete_Ayurvedic(int pid)
    {
        string qry = "delete from Ayurvedic where id='" + pid + "'";
        DataSet ds = new DataSet();
        ds = obj.ExcuteQry(qry);
        return ds;

    }



    public DataSet delete_Beautyparlour(int pid)
    {
        string qry = "delete from Beautyparlour where id='" + pid + "'";
        DataSet ds = new DataSet();
        ds = obj.ExcuteQry(qry);
        return ds;

    }



    public DataSet delete_Builders(int pid)
    {
        string qry = "delete from Builders where id='" + pid + "'";
        DataSet ds = new DataSet();
        ds = obj.ExcuteQry(qry);
        return ds;

    }




    public DataSet delete_Computers(int pid)
    {
        string qry = "delete from Computers where id='" + pid + "'";
        DataSet ds = new DataSet();
        ds = obj.ExcuteQry(qry);
        return ds;

    }



    public DataSet delete_Categories(int pid)
    {
        string qry = "delete from Categories where id='" + pid + "'";
        DataSet ds = new DataSet();
        ds = obj.ExcuteQry(qry);
        return ds;

    }



    public DataSet delete_Construction(int pid)
    {
        string qry = "delete from Construction where id='" + pid + "'";
        DataSet ds = new DataSet();
        ds = obj.ExcuteQry(qry);
        return ds;

    }



    public DataSet delete_Discount(int pid)
    {
        string qry = "delete from Discount where id='" + pid + "'";
        DataSet ds = new DataSet();
        ds = obj.ExcuteQry(qry);
        return ds;

    }




    public DataSet delete_Education(int pid)
    {
        string qry = "delete from Education where id='" + pid + "'";
        DataSet ds = new DataSet();
        ds = obj.ExcuteQry(qry);
        return ds;

    }




    public DataSet delete_Electrical(int pid)
    {
        string qry = "delete from Electrical where id='" + pid + "'";
        DataSet ds = new DataSet();
        ds = obj.ExcuteQry(qry);
        return ds;

    }



    public DataSet delete_Electronics(int pid)
    {
        string qry = "delete from Electronics where id='" + pid + "'";
        DataSet ds = new DataSet();
        ds = obj.ExcuteQry(qry);
        return ds;

    }



    public DataSet delete_Engineering(int pid)
    {
        string qry = "delete from Engineering where id='" + pid + "'";
        DataSet ds = new DataSet();
        ds = obj.ExcuteQry(qry);
        return ds;

    }




    public DataSet delete_Events(int pid)
    {
        string qry = "delete from Events where id='" + pid + "'";
        DataSet ds = new DataSet();
        ds = obj.ExcuteQry(qry);
        return ds;

    }




    public DataSet delete_Footwear(int pid)
    {
        string qry = "delete from Footwear where id='" + pid + "'";
        DataSet ds = new DataSet();
        ds = obj.ExcuteQry(qry);
        return ds;

    }




    public DataSet delete_Hardware(int pid)
    {
        string qry = "delete from Hardware where id='" + pid + "'";
        DataSet ds = new DataSet();
        ds = obj.ExcuteQry(qry);
        return ds;

    }



    public DataSet delete_Hospital(int pid)
    {
        string qry = "delete from Hospital where id='" + pid + "'";
        DataSet ds = new DataSet();
        ds = obj.ExcuteQry(qry);
        return ds;

    }



    public DataSet delete_Hostel(int pid)
    {
        string qry = "delete from Hostel where id='" + pid + "'";
        DataSet ds = new DataSet();
        ds = obj.ExcuteQry(qry);
        return ds;

    }




    public DataSet delete_Hotels(int pid)
    {
        string qry = "delete from Hotels where id='" + pid + "'";
        DataSet ds = new DataSet();
        ds = obj.ExcuteQry(qry);
        return ds;

    }



    public DataSet delete_Insurance(int pid)
    {
        string qry = "delete from Insurance where id='" + pid + "'";
        DataSet ds = new DataSet();
        ds = obj.ExcuteQry(qry);
        return ds;

    }




    public DataSet delete_Jobs(int pid)
    {
        string qry = "delete from Jobs where id='" + pid + "'";
        DataSet ds = new DataSet();
        ds = obj.ExcuteQry(qry);
        return ds;

    }



    public DataSet delete_Media(int pid)
    {
        string qry = "delete from Media where id='" + pid + "'";
        DataSet ds = new DataSet();
        ds = obj.ExcuteQry(qry);
        return ds;

    }




    public DataSet delete_overseasconsultant(int pid)
    {
        string qry = "delete from overseasconsultant where id='" + pid + "'";
        DataSet ds = new DataSet();
        ds = obj.ExcuteQry(qry);
        return ds;

    }




    public DataSet delete_Resorts(int pid)
    {
        string qry = "delete from Resorts where id='" + pid + "'";
        DataSet ds = new DataSet();
        ds = obj.ExcuteQry(qry);
        return ds;

    }





    public DataSet delete_Saloon(int pid)
    {
        string qry = "delete from Saloon where id='" + pid + "'";
        DataSet ds = new DataSet();
        ds = obj.ExcuteQry(qry);
        return ds;

    }





    public DataSet delete_School(int pid)
    {
        string qry = "delete from School where id='" + pid + "'";
        DataSet ds = new DataSet();
        ds = obj.ExcuteQry(qry);
        return ds;

    }




    public DataSet delete_Training(int pid)
    {
        string qry = "delete from Training where id='" + pid + "'";
        DataSet ds = new DataSet();
        ds = obj.ExcuteQry(qry);
        return ds;

    }



    public DataSet delete_Travels(int pid)
    {
        string qry = "delete from Travels where id='" + pid + "'";
        DataSet ds = new DataSet();
        ds = obj.ExcuteQry(qry);
        return ds;

    }







    public DataSet bind_computers()
    {
        string qry = "select * from computer";
        DataSet ds = new DataSet();
        ds = obj.ExcuteQry(qry);
        return ds;
    }



    public DataSet get_computers(string uid)
    {
        string qry = "select * from computers where id='" + uid + "'";
        DataSet ds = new DataSet();
        ds = obj.ExcuteQry(qry);
        return ds;


    }

    public DataSet get_computers1()
    {
        string qry = "select * from computers";
        DataSet ds = new DataSet();
        ds = obj.ExcuteQry(qry);
        return ds;


    }


    public DataSet get_construction(string uid)
    {
        string qry = "select * from construction where id='" + uid + "'";
        DataSet ds = new DataSet();
        ds = obj.ExcuteQry(qry);
        return ds;


    }

    public DataSet get_construction1()
    {
        string qry = "select * from construction1";
        DataSet ds = new DataSet();
        ds = obj.ExcuteQry(qry);
        return ds;


    }

  

  

  

}






































































































































































































































































