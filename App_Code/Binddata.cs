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
/// Summary description for Binddata
/// </summary>
public class Binddata
{
    public DataAccess obj = new DataAccess();
    string script = string.Empty;
    DataSet ds = new DataSet();
   
	public Binddata()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public DataSet AccountingServices(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from AccountingServices where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet ACdealers(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from ACdealers where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet AcousticEnclosure(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from AcousticEnclosure where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet AdhesiveTape(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from AdhesiveTape where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Adhesives(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Adhesives where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Advertising(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Advertising where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Advocate(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from  Advocate where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Advocatelawyers(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Advocatelawyers where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Agarbatti(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Agarbatti where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Agency(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Agency where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Agriculture(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Agriculture where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Aircompressor(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Aircompressor where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Aircompressors(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Aircompressors where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Airconditioners(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Airconditioners where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Airfilters(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Airfilters where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Airlines(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from  Airlines where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Aerospace(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from  Aerospace where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Alcoholwines(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Alcoholwines where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet AlternateEnergy(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from AlternateEnergy where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet AlternativeEnergy(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from AlternativeEnergy where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Aluminium(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Aluminium where id like '" + sid + "%'";
           ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Ambulance(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Ambulance where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet AmbulanceServices(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from AmbulanceServices where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Animal(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from  Animal where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet AnimalHusbandry(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from AnimalHusbandry where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet AntiVibration(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from AntiVibration where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Apparel(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Apparel where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet AquaCulture(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from AquaCulture where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet AquaEquipment(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from AquaEquipment where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet ArmsAmmunition(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from ArmsAmmunition where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet ArtGallery(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from ArtGallery where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Artscrafts(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Artscrafts where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Asbestos(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Asbestos where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Ashram(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from  Ashram where id like '" + sid + "%'";
           ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Atm(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Atm where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet AudioVideo(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from AudioVideo where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Automobile(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Automobile where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Automobiles(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Automobiles where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Ayurvedic(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Ayurvedic where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Bag(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Bag where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Bakery(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from  Bakery where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Bank(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Bank where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Banquethall(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Banquethall where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet BarNightclubs(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from BarNightclubs where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet BarRestaurant(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from BarRestaurant where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Battery(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Battery where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Beautyparlour(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Beautyparlour where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Bellows(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Bellows where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Billingmachine(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Billingmachine where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Biological(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Biological where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Biotech(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from  Biotech where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Blasting(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Blasting where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Boat(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Boat where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Boilers(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Boilers where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Bolt(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Bolt where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Boltsnuts(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Boltsnuts where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Book(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Book where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Borewell(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from  Borewell where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Boutiques(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Boutiques where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet BPOcompanies(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from BPOcompanies where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Bricks(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Bricks where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Broker(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Broker where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Brokers(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Brokers where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Builders(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Builders where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Building(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Building where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Bureau(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Bureau where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Business(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Business where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Camera(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from  Camera where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Canvassing(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Canvassing where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Car(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Car where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Carbon(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Carbon where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet CardDealers(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from CardDealers where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet CardsDealer(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from CardsDealer where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Carecentre(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Carecentre where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Cargo(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from  Cargo where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Carparkinglift(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Carparkinglift where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Carpenter(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Carpenter where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Cars(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Cars where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Categories(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Categories where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Caterers(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Caterers where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Cement(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Cement where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Ceramic(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Ceramic where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Ceramics(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Ceramics where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet CFagents(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from CFagents where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Charity(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from  Charity where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Chemical(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Chemical where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet ChineseRestaurant(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from ChineseRestaurant where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Civil(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Civil where id like '" + sid + "%'";
             ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet CleaningServices(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from CleaningServices where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Clinic(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Clinic where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet ClinicBloodbank(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from ClinicBloodbank where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Cloth(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from  Cloth where id like '" + sid + "%'";
           ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Club(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Club where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Clubs(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Clubs where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Clubsparks(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Clubsparks where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Coffee(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Coffee where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Coirefibre(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Coirefibre where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet College(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from College where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Commercial(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Commercial where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Communication(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Communication where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Communications(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Communications where id like '" + sid + "%'";
             ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Company(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from  Company where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Compressor(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Compressor where id like '" + sid + "%'";
             ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Computer(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Computer where id like '" + sid + "%'";
       
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet data(string sid)
    {
        try
        {
            string qry = "select * from ModulesData where id = '" + sid + "'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Concrete(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Concrete where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Construction(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Construction where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Constructions(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Constructions where id like '" + sid + "%'";
           ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Consultant(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from  Consultant where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Consultants(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Consultants where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Contractor(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Contractor where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Control(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Control where id like '" + sid + "%'";
             ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Controlpanels(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Controlpanels where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Conveyer(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Conveyer where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);

        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Conveyers(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Conveyers where id like '" + sid + "%'";
             ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Conveyors(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Conveyors where id like '" + sid + "%'";
             ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Conveyorsystems(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Conveyorsystems where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Corporate(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Corporate where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Corrugatedbox(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from  Corrugatedbox where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Cosmetic(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Cosmetic where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Cotton(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Cotton where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Counselling(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Counselling where id like '" + sid + "%'";
             ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet countries(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from countries where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Courier(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Courier where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet CourierLogistics(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from CourierLogistics where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Crafts(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from  Crafts where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Crane(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Crane where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Credit(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Credit where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Cycle(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Cycle where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet CycleStores(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from CycleStores where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Dairy(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Dairy where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Dance(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Dance where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Dealer(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Dealer where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Dental(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Dental where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Designer(string sid)
    {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Designer where id like '" + sid + "%'";
        
        ds = obj.ExcuteQry(qry);
        return ds;
    }
    public DataSet Designers(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Designers where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Designgraphics(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Designgraphics where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Detectiveagencies(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Detectiveagencies where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Diagnostics(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Diagnostics where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Digital(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from  Digital where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Discount(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Discount where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Distributors(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Distributors where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Doctor(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Doctor where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Documentmanagement(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Documentmanagement where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Drink(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Drink where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Drinkingwater(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Drinkingwater where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Driving(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Driving where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet Drugs(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Drugs where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet DTPworks(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from DTPworks where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Dummy1(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Dummy1 where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Earthmovers(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Earthmovers where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Education(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Education where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Eggretailshop(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Eggretailshop where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Electrical(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Electrical where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Electronic(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Electronic where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Electronics(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Electronics where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Elevators(string sid)
    {
        try{
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from  Elevators where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Emergency(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Emergency where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Emporium(string sid)
    {
        try{
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Emporium where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Engine(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Engine where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Engineering(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Engineering where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Environment(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Environment where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet EPABX(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from EPABX where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet EquipmentTools(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from EquipmentTools where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Esevacentre(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Esevacentre where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Estate(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Estate where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet EventManagement(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from  EventManagement where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet EventMangement(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from EventMangement where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet EventOrganisers(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from EventOrganisers where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Events(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Events where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet ExhibitionStall(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from ExhibitionStall where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Fabrication(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Fabrication where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Fabrics(string sid)
    {
        try{
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Fabrics where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Fashion(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from  Fashion where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Faxmachines(string sid)
    {
        try{
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Faxmachines where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Fertilizer(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Fertilizer where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Fiber(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Fiber where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Fibrefilters(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Fibrefilters where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Finance(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Finance where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Fire(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Fire where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Fisheries(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Fisheries where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Flooring(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Flooring where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Flooringservices(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Flooringservices where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Flower(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from  Flower where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Foodbevarages(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Foodbevarages where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Footwear(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Footwear where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Formwork(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Formwork where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Foundryequipment(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Foundryequipment where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Fruits(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Fruits where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Fruitsvegetables(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Fruitsvegetables where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet furance(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from  furance where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet Furnishings(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Furnishings where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Furniture(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Furniture where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Games(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Games where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet GamesToys(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from GamesToys where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Garment(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Garment where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Garments(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Garments where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Gas(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Gas where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet General(string sid)
    {
        try{
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from General where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Gift(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Gift where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Gifts(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from  Gifts where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Glass(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Glass where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Glaze(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Glaze where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Governement(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Governement where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Government(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Government where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Graphics(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Graphics where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Guesthouses(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Guesthouses where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Gym(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from  Gym where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet GymEquipment(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from GymEquipment where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet GymFitness(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from GymFitness where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Handicrafts(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Handicrafts where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Handloom(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Handloom where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Hardware(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Hardware where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Hardwarenetworking(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Hardwarenetworking where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Hardwarenetworks(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Hardwarenetworks where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Health(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Health where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet HealthCare(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from HealthCare where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Hologramproviders(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from  Hologramproviders where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Homeappliances(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Homeappliances where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Homeopathy(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Homeopathy where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Horticulture(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Horticulture where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Hospital(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Hospital where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet HospitalEquipment(string sid)
    {
        try{
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from HospitalEquipment where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Hospitals(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Hospitals where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Hostel(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from  Hostel where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Hotel(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Hotel where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Hotels(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Hotels where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Housekeeping(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Housekeeping where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Hrdconsultants(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Hrdconsultants where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Hydraulic(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Hydraulic where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet HydraulicEquipment(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from HydraulicEquipment where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Ice(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Ice where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet IceCream(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from IceCream where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Immigration(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Immigration where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet ImportExport(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from  ImportExport where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet ImportsExports(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from ImportsExports where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Industries(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Industries where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Industry(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Industry where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Information(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Information where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Insulation(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Insulation where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Insurance(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Insurance where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Interior(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from  Interior where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Interiors(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Interiors where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Internet(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Internet where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Inverters(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Inverters where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Investment(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Investment where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Iron(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Iron where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Ironfabricators(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Ironfabricators where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet ISOconsultants(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from ISOconsultants where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Itites(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Itites where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet jewelers(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from jewelers where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet jewelery(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from  jewelery where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet jewellery(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from jewellery where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet jigs(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from jigs where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Kitchen(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Kitchen where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Lab(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Lab where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Laboratory(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Laboratory where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Lamination(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from  Lamination where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet LaminationMachines(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from LaminationMachines where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet LandSurvey(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from LandSurvey where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        
       
        return ds;
    }
    public DataSet Laptops(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Laptops where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet LCDprojectors(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from LCDprojectors where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Leather(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Leather where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Legalservices(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Legalservices where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Library(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Library where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Lic(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Lic where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Loan(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Loan where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Loans(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from  Loans where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet LoansFinancing(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from LoansFinancing where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Marine(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Marine where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Marketing(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Marketing where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet MarketingServices(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from MarketingServices where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet MarriageBureau(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from MarriageBureau where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Massage(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Massage where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Mattress(string sid)
    {
        try{
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Mattress where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Mechanical(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Mechanical where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Media(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Media where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Medical(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from  Medical where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet MeditationYoga(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from MeditationYoga where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Merchants(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Merchants where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Metal(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Metal where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Mine(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Mine where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Minerals(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Minerals where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Mineralwater(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Mineralwater where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Mining(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Mining where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Mobile(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Mobile where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Motor(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Motor where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Motors(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Motors where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Movies(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Movies where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Music(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Music where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet NamePlates(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from NamePlates where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet News(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from News where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Nursery(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Nursery where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet OfficeFurniture(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from OfficeFurniture where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet oil(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Oil where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet oldagehomes(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from oldagehomes where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet onlineservices(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from onlineservices where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet optical(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from optical where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet opticals(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from opticals where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Organics(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Organics where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Orphanage(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from  Orphanage where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Orphanages(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Orphanages where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Outsourcingcompany(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Outsourcingcompany where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Outsourcingworks(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Outsourcingworks where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Overseasconsultant(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Overseasconsultant where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet packages(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from packages where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet packaging(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from packaging where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet packagingmaterial(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from packagingmaterial where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet packersMovers(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from packersMovers where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }

    public DataSet paint(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from paint where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet painters(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from painters where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }



    public DataSet paints(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from paints where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet paper(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from paper where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet paperMill(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from paperMill where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet parcels(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from parcels where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet pesticides(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from pesticides where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet petroleum(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from petroleum where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }

    public DataSet pharmacy(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from  pharmacy where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet photo_studio(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from photo_studio where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet photocopier(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from photocopier where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet photoFilms(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from photoFilms where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet photoStudio(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from photoStudio where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet Physiotherapy(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Physiotherapy where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }

    public DataSet pips(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from pips where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet plastic(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from plastic where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet plastics(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from plastics where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet plumber(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from plumber where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet plywood(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from  plywood where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }









    public DataSet police(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from police where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet polyethylene(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from polyethylene where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet polyethyne(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from polyethyne where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet poojastores(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from poojastores where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet Popularcities(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Popularcities where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet ports(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from ports where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }

    public DataSet postoffice(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from  postoffice where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet powder(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from powder where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet power1(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from power1 where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet precious(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from precious where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet printers(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from printers where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet printerServices(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from printerServices where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }

    public DataSet printersScanners(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from printersScanners where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet printingDyes(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from printingDyes where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet printingDyesink(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from printingDyesink where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet printingservices(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from printingservices where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet privatefinance(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from  privatefinance where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }






    public DataSet productionhouse(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from productionhouse where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet pumps(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from pumps where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet Railways(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Railways where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet RealEstate(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from RealEstate where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet Refrigeration(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Refrigeration where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet Refrigerator(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Refrigerator where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }

    public DataSet Refrigerators(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from  Refrigerators where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet Resort(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Resort where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet Resorts(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Resorts where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet Restaurant(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Restaurant where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet Retail(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Retail where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet Rexine(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Rexine where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }

    public DataSet Rice(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Rice where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet Road(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Road where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet RoofingMaterial(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from RoofingMaterial where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet Rope(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Rope where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet RopesLifts(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from  RopesLifts where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }









    public DataSet Rubber(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Rubber where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet Salesandservices(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Salesandservices where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        
        
        return ds;

    }
    public DataSet Salestax(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Salestax where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet Saloon(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Saloon where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet Salt(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Salt where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet Sanitary(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Sanitary where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }

    public DataSet SanitaryWare(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from  SanitaryWare where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet SAP(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from SAP where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet Saree(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Saree where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet Sbi(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Sbi where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet School(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from School where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet Schools(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Schools where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }

    public DataSet Science(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Science where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet Scrap(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Scrap where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet Screenprojection(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Screenprojection where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet Securities(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Securities where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet Security1(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from  Security1 where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet Securityguards(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Securityguards where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        
       
        return ds;

    }
    public DataSet Securityservices(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Securityservices where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet Securitysystems(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Securitysystems where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet Seeds(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Seeds where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet SewingMachine(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from SewingMachine where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet ShareBroker(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from ShareBroker where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }

    public DataSet Shipping(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from  Shipping where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet ShippingServices(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from ShippingServices where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet Shutters(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Shutters where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet ShuttersGates(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from ShuttersGates where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet Signboard(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Signboard where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet Singboard(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Singboard where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }

    public DataSet Skinclinic(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Skinclinic where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet Smartcard(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Smartcard where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet Softwarecompanies(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Softwarecompanies where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet SoftwarePackages(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from SoftwarePackages where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet Solarenergy(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from  Solarenergy where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }

    public DataSet Spices(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Spices where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet Sports(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Sports where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet Spring(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Spring where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet Springs(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Springs where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet Stamp(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Stamp where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet Stamps(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Stamps where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }

    public DataSet Stationery(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from  Stationery where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet Steel(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Steel where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet Sticker(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Sticker where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet StockExchange(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from StockExchange where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet Stone(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Stone where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet Storagetanks(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Storagetanks where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }

    public DataSet Store(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Store where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet Stores(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Stores where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet Studio(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Studio where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet Surgical(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Surgical where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet Survey(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from  Survey where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }


    public DataSet Surveygeology(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Surveygeology where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet Surveyor(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Surveyor where id like '" + sid + "%'";
        
        ds = obj.ExcuteQry(qry); }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet Sweets(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Sweets where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet scrapdealer(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from scrapdealer where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet sanitarydealers(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from sanitarydealers where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet Tailor(string sid)
    {
        try{
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Tailor where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet Tanks(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Tanks where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet Tarpaulin(string sid)
    {
        try{
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Tarpaulin where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }

    public DataSet Tax(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from  Tax where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet TaxConsultant(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from TaxConsultant where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet Taxicabs(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Taxicabs where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet Tea(string sid)
    {
        try
        {
        string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Tea where id like '" + sid + "%'";

        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet Technologies(string sid)
    {
       
            try
            {
                string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Technologies where id like '" + sid + "%'";

                ds = obj.ExcuteQry(qry);
            }
            catch (Exception ex)
            {
                script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
            }
       
        return ds;

    }
    public DataSet Telecommunication(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Telecommunication where id like '" + sid + "%'";

            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }

    public DataSet TelecomSolutions(string sid)
    {
        
            try
            {
                string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from TelecomSolutions where id like '" + sid + "%'";
                ds = obj.ExcuteQry(qry);
            }
            catch (Exception ex)
            {
                script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
            }
       
        return ds;

    }
    public DataSet Temple(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Temple where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet TestingEquipment(string sid)
    {
       
            try
            {
                string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from TestingEquipment where id like '" + sid + "%'";
                ds = obj.ExcuteQry(qry);
            }
            catch (Exception ex)
            {
                script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
            }
      
        return ds;

    }
    public DataSet Textiles(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Textiles where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    
    public DataSet Theatre(string sid)
    {
       
            try
            {
                string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Theatre where id like '" + sid + "%'";
                ds = obj.ExcuteQry(qry);
            }
            catch (Exception ex)
            {
                script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
            }
      
        return ds;

    }
    public DataSet Tiles(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Tiles where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet Timber(string sid)
    {
       
            try
            {
                string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Timber where id like '" + sid + "%'";
                ds = obj.ExcuteQry(qry);
            }
            catch (Exception ex)
            {
                script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
            }
           return ds;

    }
    public DataSet TimeRecorders(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from TimeRecorders where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet Tools(string sid)
    {
        
            try
            {
                string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Tools where id like '" + sid + "%'";
                ds = obj.ExcuteQry(qry);
            }
            catch (Exception ex)
            {
                script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
            }
            return ds;

    }
    public DataSet Toursandtravels(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Toursandtravels where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }

    public DataSet Tourstravels(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from  Tourstravels where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet Trade(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Trade where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet Training(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Training where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet TrainingWorks(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from TrainingWorks where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet Transport(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Transport where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet Transporters(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Transporters where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }

    public DataSet Trust(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Trust where id like '" + sid + "%'";
           ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet Tyres(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Tyres where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet University(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from University where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }

    public DataSet valuerappraiser(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from valuerappraiser where id like '" + sid + "%'";
           ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet veterinaryclinic(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from veterinaryclinic where id like '" + sid + "%'";
           ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet visualequipments(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from visualequipments where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet Ware_House(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Ware_House where id like '" + sid + "%'";
           ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet Warehouse(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from  Warehouse where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }


    public DataSet WashingMachine(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from WashingMachine where id like '" + sid + "%'";
           ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet Wastepaper(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Wastepaper where id like '" + sid + "%'";
           ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet Watch(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Watch where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet Water(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Water where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet Waterproofing(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Waterproofing where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet Waterpurifier(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Waterpurifier where id like '" + sid + "%'";
           ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }

    public DataSet Watertank(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from  Watertank where id like '" + sid + "%'";
           ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet WebServicesdealer(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from WebServicesdealer where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet WebSolution(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from WebSolution where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet Whiteboarddealers(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Whiteboarddealers where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet Wines(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Wines where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet Wiremesh(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Wiremesh where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }

    public DataSet Wood(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Wood where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet Workshop(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Workshop where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet Xerox(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Xerox where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet Yoga(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Yoga where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet Theaters(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from  Theaters where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Lodge(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Lodge where id like '" + sid + "%'";
             ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet Logistics(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Logistics where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet Lorry(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Lorry where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet Lubricant(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Lubricant where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet Luggage(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Luggage where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }

    public DataSet Machine(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from  Machine where id like '" + sid + "%'";
          ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet Machinery(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Machinery where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet MallsStores(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from MallsStores where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet Manufacturer(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Manufacturer where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet Manufacturers(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Manufacturers where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet Marblegranite(string sid)
    {
        try
        {
            string qry = "select id,cname,addr,state,conper,email,ph,mob,optim from Marblegranite where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }

    public DataSet post_discount(string sid)
    {
        try
        {
            string qry = "select id,bname,cat,sdate,edate,descr,addr,loc,lanmar,timi,city,state,conper,mob,landno,fax from post_discount where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }

    public DataSet post_events(string sid)
    {
        try
        {
            string qry = "select id,ename,placeevent,esdate,eedate,descr,addr,loc,lanmar,timi,city,state,conper,mob,landno from post_events where id like '" + sid + "%'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
   
    public DataSet BindProfile(string sid)
    {
        try
        {
            string qry = "select * from register where email='" + sid + "'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }       
    public DataSet bindAdvertiseData(string did)
    {
        try
        {
            string qry = "select * from ModulesData where id='" + did + "'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet bindFreeListingData(string did)
    {
        try
        {
            string qry = "select * from ModulesData where id='" + did + "'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet events(string sid)
    {
        try
        {
            string qry = "select id,SubCategory,event_name,event_place,event_startdate,event_enddate,event_desc,address,city,event_time,state,mob,landphno,emailid,land_mark,contact_person,fax,Website,ImageName,ImageContentType from modulesdata where id = '" + sid + "'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet jobs(string sid)
    {
        try
        {
            string qry = "select id,company_name,job_industry,job_functional_area,city,job_exp,job_sal,job_desc,job_keyskills,company_profile,contact_person,emailid,mob,fax,postdate,expdate,job_role,job_qualification,address from modulesdata where id='" + sid + "'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }

    public DataSet discounts(string sid)
    {
        try
        {
            string qry = "select id,company_name,land_mark,contact_person,event_desc,Category,event_startdate,event_enddate,address,city,state,event_time,landphno,mob,fax,emailid,Website from modulesdata where id='" + sid + "'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }

    public DataSet postreview(string sid)
    {
        try
        {
            string qry = "select rid,rname,rating,email=stuff(remail,3,5,'*****'),mob=stuff(rmob,4,5,'*****'),review,ImageName,ImageContentType,Img_Caption,Stars_Rating from postreview where dataid='" + sid + "'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet bindreview()
    {
        try
        {
        string qry = "select top 50 p.*,time=RIGHT(convert(varchar, p.postdate, 100),7),m.City,substring(p.rname,1,7)+'...' as byname from ModulesData as m full outer join PostReview as p on p.dataid=m.id where m.module='Category' or m.module='B2B Category' order by p.rid desc";
        
        ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }

    /*----------------------------------------- Admin Control---------------------------------*/

    //To bind Categories of Category to left menu of admin

    public DataSet bindAdminCategoryCat()
    {
        try
        {
            string qry = "select * from Categories where Module='Category' order by Category";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet bindAdminB2BCat()
    {
        try
        {
            string qry = "select * from Categories where Module='B2B Category' order by Category";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }

    //To bind Categories of Jobs to left menu of admin

    public DataSet bindAdminJobsCat()
    {
        try
        {
            string qry = "select s.*,c.Module,c.Category from Categories as c full outer join subcatageory as s on s.maincat=c.Category where s.maincat='Jobs' order by c.Category";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }

    //To bind Categories of Events to left menu of admin

    public DataSet bindAdminEventsCat()
    {
        try
        {
            string qry = "select s.*,c.Module,c.Category from Categories as c full outer join subcatageory as s on s.maincat=c.Category where s.maincat='Events' order by c.Category";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }

    //To bind Categories of Discounts to left menu of admin

    public DataSet bindAdminDiscountsCat()
    {
        try
        {
            string qry = "select s.*,c.Module,c.Category from Categories as c full outer join subcatageory as s on s.maincat=c.Category where s.maincat='Discounts' order by c.Category";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet bindAdminLifeStyle()
    {
        try
        {
            string qry = "select * from subcatageory where maincat='Lifestyle' order by cat";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet bindAdminFreeListing()
    {
        try
        {
            string qry = "select * from FreeListing_Category order by category";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet bindAdminSponsoredLinks()
    {
        try
        {
            string qry = "select * from sponseredlinks order by 1 desc";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;

    }
    public DataSet bindRegisteredUsers()
    {
        try
        {
            string qry = "select *,Case when iStatus=1 Then 'Active' Else 'In Active' End Status from register order by iStatus desc,id desc";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet bindRegisteredusersDetails(int id)
    {
        try
        {
            string qry = "select * from register where id=" + id;
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet bindAdminCareers()
    {
        try
        {
            string qry = "select c.*,convert(varchar,expire_date,106) as expiredate,count(ajobid) as applications from careers_resume as pr full outer join jcalluzcareers as c on c.jobid=pr.ajobid" +
                         " group by c.jobid,c.title,c.category,c.specialization,c.jobType,c.jobStatus,c.workExp,c.salRange,c.noOfvacancies,c.jobDesc,c.computerknowledge,c.qualification," +
                         "c.comp_address1,c.comp_address2,c.comp_city,c.comp_state,c.comp_pincode,c.contpersonName,c.cont_email,c.cont_phone,c.cont_ext,c.post_date,c.expire_date order by c.jobid desc";
           ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet bindAdminCareersDetais(Int16 Id)
    {
        try
        {
            string qry = "select *,posttime=convert(varchar,post_date, 105),exptime=convert(varchar,expire_date,105) from jcalluzCareers where jobid=" + Id + " order by jobid desc";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet bindlifestyle(string sid)
    {
        try
        {
            string qry = "select id,company_name,event_place,contact_person,landphno,mob,Website,address,ImageName,ImageContentType,emailid,UserLoginId from modulesdata where id='" + sid + "'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet bindDiscounts(int sid)
    {
        try
        {
            string qry = " select * from modulesdata where id=" + sid;
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet bindtvads(string subad)
    {
        try
        {
            string qry = "select * from Ads where AdSubType='" + subad + "'and AdType='TV Ads'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet moviereviews(string mname, string mlang, string sid)
    {
        try
        {
            string qry = "select rid,rname,rating,email=stuff(remail,3,5,'*****'),mob=stuff(rmob,4,5,'*****'),review,ImageName,ImageContentType,Img_Caption,Stars_Rating,City from Movie_Reviews where Movie_Name='" + mname + "'and Movie_Language='" + mlang + "'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet bindCompaniesData(string companyname)
    {
        try
        {
            string qry = "select *,datename(month,postdate) as month,datepart(year,postdate) as year from Modulesdata where company_name='" + companyname + "' and (module='Category' or module='B2B Category' or module='FreeListing')";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet GetCurrentDate()
    {
        try
        {
            string qry = "select DATEADD(mi,750,GETDATE()) as cdate";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    //discounts
    public DataSet GetMoreInfo(int id)
    {
        try
        {
            string qry = "select * from AddMoreInfo where dataid=" + id;
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet BindLoginDetails()
    {
        try
        {
            string qry = "select email,password,iStatus from register where iStatus=1";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet BindReviews(int sid)
    {
        try
        {
            string qry = "Select rid,mob=stuff(rmob,4,5,'*****'),rname,email=stuff(remail,4,6,'****'),rating,review,ImageName,ImageContentType,Stars_Rating from PostReview where dataid=" + sid + " order by rid desc";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet BindMap(int sid)
    {
        try
        {
            string qry = "select id,map,Approved_map from modulesdata where id=" + sid + " and Approved_map=1";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet BindRatings(int sid)
    {
        try
        {
            string qry = "Select count(rid) as NumberOfUsers,sum(Stars_Rating) as Total from PostReview where dataid=" + sid;
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet GetsubCatData(string strname, string current1, string city)
    {
        try
        {
            string qry = "select * from modulesdata where module='Discounts' and SubCategory=('" + strname + "') and event_enddate>='" + current1 + "' and City='" + city + "' and ApprovedStatus='1' order by id desc";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet BindPopCityData(string city, string current1)
    {
        try
        {
            string qry = "select * from modulesdata where module='Discounts' and city=('" + city + "') and event_enddate>='" + current1 + "' and ApprovedStatus='1' order by id desc";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
            return ds;
    }
    public DataSet GetSDateAndEDateDetails(string from, string to, string city)
    {
        try
        {
            string qry = "select * from modulesdata where module='Discounts' and event_startdate>='" + from + "' and (event_enddate>='" + to + "' or event_enddate>='" + from + "'or event_startdate>='" + to + "') and City='" + city + "' and ApprovedStatus='1' order by id desc";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet GetSDateDetails(string from, string city)
    {
        try
        {
            string qry = "select * from modulesdata where module='Discounts' and (event_startdate>='" + from + "' or event_enddate>='" + from + "') and City='" + city + "' and ApprovedStatus='1' order by id desc";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet GetEDateDetails(string to, string city)
    {
        try
        {
            string qry = "select * from modulesdata where module='Discounts' and (event_startdate>='" + to + "' or event_enddate>='" + to + "')and City='" + city + "' and ApprovedStatus='1' order by id desc";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet GetCurrentDetails(string current1, string city)
    {
        try
        {
            string qry = "select * from modulesdata where module='Discounts' and (event_enddate>='" + current1 + "' or event_startdate>='" + current1 + "') and City='" + city + "' and ApprovedStatus='1' order by id desc";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet getViewRecords(string sid)
    {
        try
        {
            string qry = "select * from modulesdata where id='" + sid + "' order by id desc";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet getDiscountCate(string Module_Name)
    {
        try
        {
            string qry = "(select *,stuff(\"Category\", 22, len(Category), '...') as catname,Category from Categories where Module= '" + Module_Name + "') except (select *,stuff(\"Category\", 22, len(Category), '...') as catname,Category from Categories where Category='Movies') order by catname";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet GetDiscountSubCate(string Category_Name)
    {
        try
        {
            string qry = "select Distinct(cat) from subcatageory where maincat='" + Category_Name + "' order by cat";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet GetDiscountCities(string statename)
    {
        try
        {
            string qry = "select city_name from cities where state_name='" + statename + "'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet GetPhotoCount(int id)
    {
        try
        {
            string qry = "select count(dataid) as count from photos where dataid=" + id;
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet GetCountMoreInfo(int id)
    {
        try
        {
            string qry = "select count(id) as count from AddMoreInfo where dataid=" + id;
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet GetUserId(string userid)
    {
        try
        {
            string qry = "select top 1 id,UserLoginId from modulesdata where UserLoginId='" + userid + "' order by id desc";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet BindInitialValues(string curnt, string city)
    {
        try
        {
            string qry = "select * from modulesdata where module='Discounts' and City='" + city + "' and (( event_enddate>='" + curnt + "' and event_startdate>='" + curnt + "') or ( event_startdate>='" + curnt + "' or event_enddate>='" + curnt + "')) and ApprovedStatus=1 order by id desc";
             ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet BindDLCatDetails(string strname, string city, string current1)
    {
        try
        {
            string qry = "select * from modulesdata where module='Discounts' and Category=('" + strname + "') and (event_enddate>='" + current1 + "' or event_startdate>='" + current1 + "') and City='" + city + "' and ApprovedStatus='1' order by id desc";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet BindDLSubCat(string strname)
    {
        try
        {
            string qry = "select Distinct stuff(\"SubCategory\", 22, len(SubCategory), '...') as Scatname,SubCategory from modulesdata where Category='" + strname + "'";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
    public DataSet BindDLSubCatDetails(string strname, string city, string current1)
    {
        try
        {
            string qry = "select * from modulesdata where module='Discounts' and SubCategory=('" + strname + "') and (event_enddate>='" + current1 + "' or event_startdate>='" + current1 + "') and City='" + city + "' and ApprovedStatus='1' order by id desc";
            ds = obj.ExcuteQry(qry);
        }
        catch (Exception ex)
        {
            script = "<script type=\"text/javascript\">alert('" + ex.Message + "');</script> ";
        }
        return ds;
    }
}








