using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System;

/// <summary>
/// Summary description for Employee
/// </summary>
public class Cities
{
    public int cityid { get; set; }
    public string Cityname { get; set; }

    public List<Cities> GetCitiesList()
    {
        List<Cities> citynames = new List<Cities>();

        SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["connectionstring"]);
        con.Open();
        SqlCommand cmd = new SqlCommand("select city_Id,city_name from cities", con);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        da.Fill(dt);
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            citynames.Add(new Cities() { cityid = Convert.ToInt32(dt.Rows[i]["city_Id"]), Cityname = Convert.ToString(dt.Rows[i]["city_name"]) });
        }
        //empList.Add(new Cities() { ID = 1, Email = "Mary@somemail.com" });
        //empList.Add(new Cities() { ID = 2, Email = "John@somemail.com" });
        //empList.Add(new Cities() { ID = 3, Email = "Amber@somemail.com" });
        //empList.Add(new Cities() { ID = 4, Email = "Kathy@somemail.com" });
        //empList.Add(new Cities() { ID = 5, Email = "Lena@somemail.com" });
        //empList.Add(new Cities() { ID = 6, Email = "Susanne@somemail.com" });
        //empList.Add(new Cities() { ID = 7, Email = "Johnjim@somemail.com" });
        //empList.Add(new Cities() { ID = 8, Email = "Jonay@somemail.com" });
        //empList.Add(new Cities() { ID = 9, Email = "Robert@somemail.com" });
        //empList.Add(new Cities() { ID = 10, Email = "Krishna@somemail.com" });

        return citynames;
    }

}
