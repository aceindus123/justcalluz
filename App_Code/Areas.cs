using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System;
using System.Web;

/// <summary>
/// Summary description for Area
/// </summary>
public class Areas
{
    public int id { get; set; }
    public string areaname { get; set; }
    public string searchn { get; set; }
    InsertData obj = new InsertData();
    static string excep_page = "Cities appcode";
    public int cityid { get; set; }
    public string Cityname { get; set; }
    public List<Areas> GetAreasList(string City,string area)
    {
        List<Areas> Areanames = new List<Areas>();

        try
        {
            
           SqlConnection con1 = new SqlConnection(ConfigurationManager.AppSettings["connectionstring"]);
            con1.Open();
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1;
            da1 = new SqlDataAdapter("select Distinct(Area),City from modulesdata where City='" + City + "' and Area like '" + "%" + area + "%" + "' order by Area Asc", con1);
            //da1 = new SqlDataAdapter("select Distinct(Area),City from modulesdata where City='" + City + "'", con1);
            da1.Fill(dt1);

            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                Areanames.Add(new Areas() { areaname = Convert.ToString(dt1.Rows[i]["Area"]) });
            }

            return Areanames;
        }
        catch (Exception e)
        {
            e.ToString();
            return null;
        }

    }
    public List<Areas> GetAreasList1(string City)
    {
        List<Areas> searchname = new List<Areas>();

        try
        {

            SqlConnection con1 = new SqlConnection(ConfigurationManager.AppSettings["connectionstring"]);
            con1.Open();
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1;
            da1 = new SqlDataAdapter("select distinct(Category) from modulesdata where City='" + City + "' order by Category asc", con1);
            //da1 = new SqlDataAdapter("select Distinct(Area),City from modulesdata where City='" + City + "'", con1);
            da1.Fill(dt1);

            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                searchname.Add(new Areas() { searchn = Convert.ToString(dt1.Rows[i]["Category"]) });
            }

            return searchname;
        }
        catch (Exception e)
        {
            e.ToString();
            return null;
        }

    }
    public List<Areas> GetSearchList(string City,string cate,string rbtype)
    {
        List<Areas> searchname = new List<Areas>();

        try
        {

            SqlConnection con1 = new SqlConnection(ConfigurationManager.AppSettings["connectionstring"]);
            if(rbtype=="rb1comp")
            {
                con1.Open();
                DataTable dtcomp = new DataTable();
                SqlDataAdapter dacomp;
                dacomp = new SqlDataAdapter("select distinct(company_name) from modulesdata where City='" + City + "' and (company_name like '" + "%" + cate + "%" + "') order by company_name asc", con1);
                //da1 = new SqlDataAdapter("select Distinct(Area),City from modulesdata where City='" + City + "'", con1);
                dacomp.Fill(dtcomp);
                if (dtcomp.Rows.Count > 0)
                {
                    for (int i = 0; i < dtcomp.Rows.Count; i++)
                    {
                        searchname.Add(new Areas() { searchn = Convert.ToString(dtcomp.Rows[i]["company_name"]) });
                    }
                }
              
                   
            }
            else if (rbtype == "rb2cat")
            {
                //con1.Open();
                DataTable dt1 = new DataTable();
                SqlDataAdapter da1;
                SqlDataAdapter dasub;
                DataTable dtsub = new DataTable();
                da1 = new SqlDataAdapter("select distinct(Category) from modulesdata where City='" + City + "' and (Category like '" + "%" + cate + "%" + "') order by Category asc", con1);
                //da1 = new SqlDataAdapter("select Distinct(Area),City from modulesdata where City='" + City + "'", con1);
                da1.Fill(dt1);
                if (dt1.Rows.Count > 0)
                {
                    for (int i = 0; i < dt1.Rows.Count; i++)
                    {
                        searchname.Add(new Areas() { searchn = Convert.ToString(dt1.Rows[i]["Category"]) });
                    }
                }
                else
                {
                    dasub = new SqlDataAdapter("select distinct(SubCategory) from modulesdata where City='" + City + "' and (SubCategory like '" + "%" + cate + "%" + "') order by SubCategory asc", con1);
                    //da1 = new SqlDataAdapter("select Distinct(Area),City from modulesdata where City='" + City + "'", con1);
                    dasub.Fill(dtsub);
                    if (dtsub.Rows.Count > 0)
                    {
                        for (int i = 0; i < dtsub.Rows.Count; i++)
                        {
                            searchname.Add(new Areas() { searchn = Convert.ToString(dtsub.Rows[i]["SubCategory"]) });
                        }
                    }
                }
            }

            return searchname;
        }
        catch (Exception e)
        {
            e.ToString();
            return null;
        }

    }
    public List<Areas> GetCitiesList()
    {
        List<Areas> citynames = new List<Areas>();
        try
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["connectionstring"]);
            con.Open();
            SqlCommand cmd = new SqlCommand("select city_Id,city_name from cities", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                citynames.Add(new Areas() { cityid = Convert.ToInt32(dt.Rows[i]["city_Id"]), Cityname = Convert.ToString(dt.Rows[i]["city_name"]) });
            }

            return citynames;
        }
        catch (Exception e)
        {
            e.ToString();
            return null;
        }
    }
}


