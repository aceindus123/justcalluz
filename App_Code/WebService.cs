using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.Script.Services;
using System.Data;

///<summary>

/// Summary description for Service

///</summary>

[WebService(Namespace = "http://tempuri.org/")]

[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]

// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 

[System.Web.Script.Services.ScriptService]
public class WebService : System.Web.Services.WebService {
   public string areaname { get; set; }
    public string searchn { get; set; }
    InsertData obj = new InsertData();
    static string excep_page = "Cities appcode";
    public string Cityname { get; set; }

    public WebService () {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }
    [WebMethod]
    [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
    public string[] GetCategories(string prefix, string City,string Type)
    {

        List<string> categories = new List<string>();
        try
        {

            SqlConnection con1 = new SqlConnection(ConfigurationManager.AppSettings["connectionstring"]);
            if (Type == "rb1comp")
            {
               // con1.Open();
                DataTable dtcomp = new DataTable();
                SqlDataAdapter dacomp;
                dacomp = new SqlDataAdapter("select distinct(company_name) from modulesdata where City='" + City + "' and (company_name like '" + "%" + prefix + "%" + "') order by company_name asc", con1);
                //da1 = new SqlDataAdapter("select Distinct(Area),City from modulesdata where City='" + City + "'", con1);
                dacomp.Fill(dtcomp);
                if (dtcomp.Rows.Count > 0)
                {
                    for (int i = 0; i < dtcomp.Rows.Count; i++)
                    {
                        categories.Add(string.Format("{0}",Convert.ToString(dtcomp.Rows[i]["company_name"])));
                    }
                }


            }
            else if (Type == "rb2cat")
            {
                //con1.Open();
                DataTable dt1 = new DataTable();
                SqlDataAdapter da1;
                SqlDataAdapter dasub;
                DataTable dtsub = new DataTable();
                da1 = new SqlDataAdapter("select distinct(Category) from modulesdata where City='" + City + "' and (Category like '" + "%" + prefix + "%" + "') order by Category asc", con1);
                //da1 = new SqlDataAdapter("select Distinct(Area),City from modulesdata where City='" + City + "'", con1);
                da1.Fill(dt1);
                if (dt1.Rows.Count > 0)
                {
                    for (int i = 0; i < dt1.Rows.Count; i++)
                    {
                        categories.Add(string.Format("{0}", Convert.ToString(dt1.Rows[i]["Category"])));
                    }
                }
                else
                {
                    dasub = new SqlDataAdapter("select distinct(SubCategory) from modulesdata where City='" + City + "' and (SubCategory like '" + "%" + prefix + "%" + "') order by SubCategory asc", con1);
                    //da1 = new SqlDataAdapter("select Distinct(Area),City from modulesdata where City='" + City + "'", con1);
                    dasub.Fill(dtsub);
                    if (dtsub.Rows.Count > 0)
                    {
                        for (int i = 0; i < dtsub.Rows.Count; i++)
                        {
                            categories.Add(string.Format("{0}", Convert.ToString(dtsub.Rows[i]["SubCategory"])));
                        }
                    }
                }
            }
            else
            {
                DataTable dtjc = new DataTable();
                SqlDataAdapter dajc;
                SqlDataAdapter dasubjc;
                DataTable dtsubjc = new DataTable();
                dajc = new SqlDataAdapter("select distinct(Category) from modulesdata where City='" + City + "' and (Category like '" + "%" + prefix + "%" + "') order by Category asc", con1);
                //da1 = new SqlDataAdapter("select Distinct(Area),City from modulesdata where City='" + City + "'", con1);
                dajc.Fill(dtjc);
                if (dtjc.Rows.Count > 0)
                {
                    for (int i = 0; i < dtjc.Rows.Count; i++)
                    {
                        categories.Add(string.Format("{0}", Convert.ToString(dtjc.Rows[i]["Category"])));
                    }
                }
                else
                {
                    dasubjc = new SqlDataAdapter("select distinct(SubCategory) from modulesdata where City='" + City + "' and (SubCategory like '" + "%" + prefix + "%" + "') order by SubCategory asc", con1);
                    //da1 = new SqlDataAdapter("select Distinct(Area),City from modulesdata where City='" + City + "'", con1);
                    dasubjc.Fill(dtsubjc);
                    if (dtsubjc.Rows.Count > 0)
                    {
                        for (int i = 0; i < dtsubjc.Rows.Count; i++)
                        {
                            categories.Add(string.Format("{0}", Convert.ToString(dtsubjc.Rows[i]["SubCategory"])));
                        }
                    }
                }
            }

            return categories.ToArray();
        }
        catch (Exception e)
        {
            e.ToString();
            return null;
        }
        //DataTable dtcheck = new DataTable();
        //using (SqlConnection conn = new SqlConnection())
        //{

        //    conn.ConnectionString = ConfigurationManager.AppSettings["ConnectionString"];

        //    using (SqlCommand cmd = new SqlCommand())
        //    {
        //        if (Type == "rb2cat")
        //        {

        //            cmd.CommandText = "select distinct(Category) from modulesdata where " +

        //            "City='" + City + "' and Category like  '%' + @SearchText + '%' order by Category Asc";

        //            cmd.Parameters.AddWithValue("@SearchText", prefix);

        //            cmd.Connection = conn;

        //            conn.Open();

        //            using (SqlDataReader sdr2 = cmd.ExecuteReader())
        //            {
        //                dtcheck.Load(sdr2);
        //                if (dtcheck.Rows.Count > 0)
        //                {

        //                    for (int i = 0; i < dtcheck.Rows.Count; i++)
        //                    {
        //                        categories.Add(string.Format("{0}", dtcheck.Rows[i]["Category"].ToString()));

        //                    }
        //                  // conn.Close();
        //                }
        //                else
        //                {
        //                    cmd.CommandText = "select distinct(SubCategory) from modulesdata where " +

        //                        "City='" + City + "' and SubCategory like  '%' + @SearchText1 + '%' order by SubCategory Asc";

        //                    cmd.Parameters.AddWithValue("@SearchText1", prefix);

        //                    cmd.Connection = conn;

        //                  // conn.Open();

        //                    using (SqlDataReader sdr1 = cmd.ExecuteReader())
        //                    {
        //                        while (sdr1.Read())
        //                        {

        //                            categories.Add(string.Format("{0}", sdr1["SubCategory"]));

        //                        }

        //                    }

        //                }


        //                conn.Close();
        //            }
        //        }
        //        else if (Type == "rb1comp")
        //        {
        //            cmd.CommandText = "select distinct(company_name) from modulesdata where " +

        //              "City='" + City + "' and company_name like  '%' + @SearchText + '%' order by company_name Asc";

        //            cmd.Parameters.AddWithValue("@SearchText", prefix);

        //            cmd.Connection = conn;

        //            conn.Open();

        //            using (SqlDataReader sdr = cmd.ExecuteReader())
        //            {
        //                while (sdr.Read())
        //                {
        //                    categories.Add(string.Format("{0}", sdr["company_name"]));

        //                }
        //            }
        //            conn.Close();

        //        }
        //    }
        //    return categories.ToArray();
        //}

    }
    [WebMethod]
    [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
    public string[] GetCities(string prefix)
    {

        List<string> Cities = new List<string>();
        try
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["connectionstring"]);
            //con.Open();
            SqlCommand cmd = new SqlCommand("select city_name from cities city_name like '" + "%" + prefix + "%" + "' order by city_name Asc", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Cities.Add(string.Format("{0}",Convert.ToString(dt.Rows[i]["city_name"])));
            }

            return Cities.ToArray();
        }
        catch (Exception e)
        {
            e.ToString();
            return null;
        }

        //using (SqlConnection conn = new SqlConnection())
        //{

        //    conn.ConnectionString = ConfigurationManager.AppSettings["ConnectionString"];

        //    using (SqlCommand cmd = new SqlCommand())
        //    {
        //        cmd.CommandText = "select distinct(city_name) from cities where " +

        //        "city_name like  '%' + @SearchText + '%' order by city_name Asc";

        //        cmd.Parameters.AddWithValue("@SearchText", prefix);

        //        cmd.Connection = conn;

        //        conn.Open();

        //        using (SqlDataReader sdr = cmd.ExecuteReader())
        //        {

        //            while (sdr.Read())
        //            {

        //                Cities.Add(string.Format("{0}", sdr["city_name"]));

        //            }

        //        }

        //        conn.Close();

        //    }

        //    return Cities.ToArray();

        //}

    }
    [WebMethod]
    [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
    public string[] GetAreas(string prefix,string City)
    {
        List<string> Areas = new List<string>();

        try
        {

            SqlConnection con1 = new SqlConnection(ConfigurationManager.AppSettings["connectionstring"]);
           // con1.Open();
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1;
            da1 = new SqlDataAdapter("select Distinct(Area),City from modulesdata where City='" + City + "' and Area like '" + "%" + prefix + "%" + "' order by Area Asc", con1);
            //da1 = new SqlDataAdapter("select Distinct(Area),City from modulesdata where City='" + City + "'", con1);
            da1.Fill(dt1);

            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                Areas.Add(string.Format("{0}",Convert.ToString(dt1.Rows[i]["Area"])));
            }

            return Areas.ToArray();
        }
        catch (Exception e)
        {
            e.ToString();
            return null;
        }

        //List<string> Areas = new List<string>();

        //using (SqlConnection conn = new SqlConnection())
        //{

        //    conn.ConnectionString = ConfigurationManager.AppSettings["ConnectionString"];

        //    using (SqlCommand cmd = new SqlCommand())
        //    {
        //        cmd.CommandText = "select distinct(Area) from modulesdata where " +

        //        "City='" + City + "' and Area like  '%' + @SearchText + '%' order by Area Asc";

        //        cmd.Parameters.AddWithValue("@SearchText", prefix);

        //        cmd.Connection = conn;

        //        conn.Open();

        //        using (SqlDataReader sdr = cmd.ExecuteReader())
        //        {
        //            while (sdr.Read())
        //            {
        //                Areas.Add(string.Format("{0}", sdr["Area"]));
        //            }
        //        }
        //        conn.Close();
        //    }
        //    return Areas.ToArray();
        //}

    }
    
}
