using System.Collections.Generic;
using System.Linq;
using System.Web.Services;
using System.Web.Script.Services;

[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
[ScriptService]
public class CitiesList : System.Web.Services.WebService
{
    [WebMethod]
    public List<Cities> FetchCitiesList(string city)
    {
        var emp = new Cities();
        var fetchCity = emp.GetCitiesList()
        .Where(m => m.Cityname.ToLower().StartsWith(city.ToLower()));
        return fetchCity.ToList();
    }
}

