using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;
using JustCallUsData.Data;
using System.Web.Services;
using System.Collections.Generic;
using System.Web.Routing;

public partial class Advanced_Search : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["connectionstring"]);
    DataCS obj1 = new DataCS();
    DataSet dsadv_search = new DataSet();
    static string excep_page = "Advanced_Search.aspx";
    InsertData obj = new InsertData();
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            string city = Convert.ToString(Page.RouteData.Values["city"].ToString());
            txtcity.Text = city;
            Session["city"] = txtcity.Text;
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
        
    }
    protected void imgsrch_Click(object sender, ImageClickEventArgs e)
    {
        //try
        //{
            string pageid = "adv_search";
            //con.Open();
            string city, comp, cnctper, phone;
            city = txtcity.Text;
            if (txtcomp.Text != "")
            {
                comp = txtcomp.Text;
            }
            else
            {
                comp = "null";
            }
            if (txtcnctper.Text != "")
            {
                cnctper = txtcnctper.Text;
            }
            else
            {
                cnctper = "null";
            }
            if (txtphone.Text != "")
            {
                phone = txtphone.Text;
            }
            else
            {
                phone = "null";
            }

            try
            {
                if (city != "" && comp != "null" && cnctper != "null" && phone != "null")
                {
                    //dsadv_search = obj.searchbyall(city, comp, cnctper, phone);
                   //redirect("linkresults.aspx?pageid=" + pageid + "&compname=" + comp + "&city=" + city + "&cnctper=" + cnctper + "&phone=" + phone + "",false);
                    Response.RedirectToRoute("Ad_lnkresults", new { pageid = pageid, compname = comp, city = city, cnctper = cnctper, phone = phone });
                }
                else if (city != "" && comp != "null" && phone != "null")
                {
                    //redirect("linkresults.aspx?pageid=" + pageid + "&compname=" + comp + "&city=" + city + "&cnctper=" + cnctper + "&phone=" + phone + "",false);
                    Response.RedirectToRoute("Ad_lnkresults", new { pageid = pageid, compname = comp, city = city, cnctper = cnctper, phone = phone });

                }
                else if (city != "" && comp != "null" && cnctper != "null")
                {
                   //redirect("linkresults.aspx?pageid=" + pageid + "&compname=" + comp + "&city=" + city + "&cnctper=" + cnctper + "&phone=" + phone + "",false);
                    Response.RedirectToRoute("Ad_lnkresults", new { pageid = pageid, compname = comp, city = city, cnctper = cnctper, phone = phone });

                }
                else if (city != "" && cnctper != "null" && phone != "null")
                {
                    //redirect("linkresults.aspx?pageid=" + pageid + "&compname=" + comp + "&city=" + city + "&cnctper=" + cnctper + "&phone=" + phone + "",false);
                    Response.RedirectToRoute("Ad_lnkresults", new { pageid = pageid, compname = comp, city = city, cnctper = cnctper, phone = phone });

                }
                else if (city != "" && comp != "null")
                {
                   //redirect("linkresults.aspx?pageid=" + pageid + "&compname=" + comp + "&city=" + city + "&cnctper=" + cnctper + "&phone=" + phone + "",false);
                    Response.RedirectToRoute("Ad_lnkresults", new { pageid = pageid, compname = comp, city = city, cnctper = cnctper, phone = phone });

                }
                else if (city != "" && cnctper != "null")
                {
                   // redirect("linkresults.aspx?pageid=" + pageid + "&compname=" + comp + "&city=" + city + "&cnctper=" + cnctper + "&phone=" + phone + "",false);
                    Response.RedirectToRoute("Ad_lnkresults", new { pageid = pageid, compname = comp, city = city, cnctper = cnctper, phone = phone });

                }
                else if (city != "" && phone != "null")
                {
                   // redirect("linkresults.aspx?pageid=" + pageid + "&compname=" + comp + "&city=" + city + "&cnctper=" + cnctper + "&phone=" + phone + "",false);
                    Response.RedirectToRoute("Ad_lnkresults", new { pageid = pageid, compname = comp, city = city, cnctper = cnctper, phone = phone });

                }
            }
            catch (Exception ex)
            {
                obj.insert_exception(ex, excep_page);
                Response.Redirect("HttpErrorPage.aspx");
            }
        }
    //    catch (Exception ex)
    //    {
    //        obj.insert_exception(ex, excep_page);
    //        Response.Redirect("HttpErrorPage.aspx");
    //    }
    //}
    [System.Web.Script.Services.ScriptMethod()]
    [System.Web.Services.WebMethod(EnableSession = true)]
    public static List<string> Getcities(string prefixText)
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["connectionstring"]);
        con.Open();
        SqlCommand cmd = new SqlCommand("select * from cities where city_name like @Name+'%'", con);
        cmd.Parameters.AddWithValue("@Name", prefixText);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        da.Fill(dt);
        List<string> citynames = new List<string>();
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            citynames.Add(dt.Rows[i][1].ToString());
        }
        return citynames;

    }
   

}
