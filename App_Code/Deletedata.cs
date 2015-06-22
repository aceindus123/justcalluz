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
    DataSet ds = new DataSet();
    string script = string.Empty;
    public Deletedata()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public DataSet delete_Automobile(int pid)
    {
        try{
        string qry = "delete from Automobile where id='" + pid + "'";
        
        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }


    public DataSet delete_Advertising(int pid)
    {
        try{
        string qry = "delete from Advertising where id='" + pid + "'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }



    public DataSet delete_Ayurvedic(int pid)
    {
        try{
        string qry = "delete from Ayurvedic where id='" + pid + "'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }



    public DataSet delete_Beautyparlour(int pid)
    {
        try{
        string qry = "delete from Beautyparlour where id='" + pid + "'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }



    public DataSet delete_Builders(int pid)
    {
        try{
        string qry = "delete from Builders where id='" + pid + "'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }




    public DataSet delete_Computers(int pid)
    {
        try{
        string qry = "delete from Computers where id='" + pid + "'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }



    public DataSet delete_Categories(int pid)
    {
        try{
        string qry = "delete from Categories where id='" + pid + "'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }



    public DataSet delete_Construction(int pid)
    {
        try{
        string qry = "delete from Construction where id='" + pid + "'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }



    public DataSet delete_Discount(int pid)
    {
        try{
        string qry = "delete from Discount where id='" + pid + "'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }




    public DataSet delete_Education(int pid)
    {
        try{
        string qry = "delete from Education where id='" + pid + "'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }




    public DataSet delete_Electrical(int pid)
    {
        try{
        string qry = "delete from Electrical where id='" + pid + "'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }



    public DataSet delete_Electronics(int pid)
    {
        try{
        string qry = "delete from Electronics where id='" + pid + "'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }



    public DataSet delete_Engineering(int pid)
    {
        try{
        string qry = "delete from Engineering where id='" + pid + "'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }




    public DataSet delete_Events(int pid)
    {
        try{
        string qry = "delete from Events where id='" + pid + "'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }




    public DataSet delete_Footwear(int pid)
    {
        try{
        string qry = "delete from Footwear where id='" + pid + "'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }




    public DataSet delete_Hardware(int pid)
    {
        try{
        string qry = "delete from Hardware where id='" + pid + "'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }



    public DataSet delete_Hospital(int pid)
    {
        try{
        string qry = "delete from Hospital where id='" + pid + "'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }



    public DataSet delete_Hostel(int pid)
    {
        try{
        string qry = "delete from Hostel where id='" + pid + "'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }




    public DataSet delete_Hotels(int pid)
    {
        try{
        string qry = "delete from Hotels where id='" + pid + "'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }



    public DataSet delete_Insurance(int pid)
    {
        try{
        string qry = "delete from Insurance where id='" + pid + "'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }




    public DataSet delete_Jobs(int pid)
    {
        try{
        string qry = "delete from Jobs where id='" + pid + "'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }



    public DataSet delete_Media(int pid)
    {
        try{
        string qry = "delete from Media where id='" + pid + "'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }




    public DataSet delete_overseasconsultant(int pid)
    {
        try{
        string qry = "delete from overseasconsultant where id='" + pid + "'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }




    public DataSet delete_Resorts(int pid)
    {
        try{
        string qry = "delete from Resorts where id='" + pid + "'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }





    public DataSet delete_Saloon(int pid)
    {
        try{
        string qry = "delete from Saloon where id='" + pid + "'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }





    public DataSet delete_School(int pid)
    {
        try{
        string qry = "delete from School where id='" + pid + "'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }




    public DataSet delete_Training(int pid)
    {
        try{
        string qry = "delete from Training where id='" + pid + "'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }



    public DataSet delete_Travels(int pid)
    {
        try{
        string qry = "delete from Travels where id='" + pid + "'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }







    public DataSet bind_computers()
    {
        try{
        string qry = "select * from computer";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }



    public DataSet get_computers(string uid)
    {
        try{
        string qry = "select * from computers where id='" + uid + "'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;


    }

    public DataSet get_computers1()
    {
        try{
        string qry = "select * from computers";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;


    }


    public DataSet get_construction(string uid)
    {
        try{
        string qry = "select * from construction where id='" + uid + "'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;


    }

    public DataSet get_construction1()
    {
        try{
        string qry = "select * from construction1";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;


    }

  

  

  

}






































































































































































































































































