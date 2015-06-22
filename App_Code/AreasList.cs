using System.Collections.Generic;
using System.Linq;
using System.Web.Services;
using System.Web.Script.Services;
using System;

[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
[ScriptService]

public class AreasList : System.Web.Services.WebService
{
    [WebMethod]
    public List<Areas> FetchAreasList(string area, string City)
   {
        //Areas m = new Areas();
        //string City = Convert.ToString(System.Web.HttpContext.Current.Session["City"]);
        var emp = new Areas();
        var fetchArea = emp.GetAreasList(City,area).Where(m => m.areaname.ToLower().Contains(area.ToString()));
        return fetchArea.ToList();
    }
    [WebMethod]
    public List<Areas> FetchAreasList1(string sear, string City)
    {

        var emp = new Areas();
        var fetchArea = emp.GetAreasList1(City).Where(m => m.searchn.ToLower().StartsWith(sear.ToLower()));
        return fetchArea.ToList();
    }

    [WebMethod]
    public List<Areas> FetchSearchList(string sear, string City, string Type)
    {
       
        var emp = new Areas();
        var fetchArea = emp.GetSearchList(City, sear, Type).Where(m => m.searchn.ToLower().Contains(sear.ToString()));
        return fetchArea.ToList();
    }

    [WebMethod]
    public List<Areas> FetchCitiesList(string city)
    {
        var emp = new Areas();
        var fetchCity = emp.GetCitiesList().Where(m => m.Cityname.ToLower().Contains(city.ToLower()));
        return fetchCity.ToList();
    }
   
}

