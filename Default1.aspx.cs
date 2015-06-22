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
using System.Collections.Specialized;
using System.Reflection;
using System.Collections.Generic;
using System.Net;
using System.Web.Routing;

public partial class _Default1 : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
   // SqlDataAdapter cmd1;
    InsertData obj = new InsertData();
    DataSet ds = new DataSet();
    static string excep_page = "Default.aspx";
    
    protected void Page_Load(object sender, EventArgs e)
    {
        //Response.Write(TimeZoneInfo.FindSystemTimeZoneById(TimeZoneInfo.Local.Id).StandardName);
        //if (!IsPostBack)
        //{
        string id = Convert.ToString(Page.RouteData.Values["id"]);
        if (id != "")
        {
            if (id == "1")
            {
                body1.Attributes.Add("onload", "new Spry.Widget.TabbedPanels(TabbedPanels1,0)");
            }
            if (id == "2")
            {
                body1.Attributes.Add("onload", "new Spry.Widget.TabbedPanels(TabbedPanels1,1)");
            }
        }
        else
        {
            body1.Attributes.Add("onload", "new Spry.Widget.TabbedPanels(TabbedPanels1,0)");
        }
            try
            {                
                //panel1.Visible = true;
                //panel2.Visible = false;
                string sys_ipaddress = GetIP();
                Session["IPaddr1"] = sys_ipaddress;
                string date = DateTime.Now.ToShortDateString();
                string time = DateTime.Now.ToShortTimeString();
                SqlCommand cmdcount = new SqlCommand("insert into sitecount(Date,ip_address,Time) values(@date,@sys_ipaddress,@time)", con);
                cmdcount.Parameters.AddWithValue("@date", date);
                cmdcount.Parameters.AddWithValue("@sys_ipaddress", sys_ipaddress);
                cmdcount.Parameters.AddWithValue("@time", time);
                try
                {
                    con.Open();
                    cmdcount.ExecuteNonQuery();
                }

                catch (Exception ex)
                {
                    obj.insert_exception(ex, excep_page);
                    Response.Redirect("HttpErrorPage.aspx");
                }

                finally
                {
                    cmdcount.Dispose();
                    con.Close();
                }

                string Category1r = "Hotels and Resorts";
                string Category2r = "Lodging and Boarding";
                ds = obj.bindCategories(7,Category1r,Category2r);
                Repeater1.DataSource = ds;
                Repeater1.DataBind();

                string Category1 = "Restaurant and Pubs";
                ds = obj.bindCategories(6,Category1);
                Repeater2.DataSource = ds;
                Repeater2.DataBind();

                string Category2 = "Wedding Requisites";
                ds = obj.bindCategories(5,Category2);
                Repeater3.DataSource = ds;
                Repeater3.DataBind();

                //string Category3 = "Cars";
                //ds = obj.bindCategories(Category3);
                //Repeater4.DataSource = ds;
                //Repeater4.DataBind();

                string Category4 = "Computers and Peripherals";
                ds = obj.bindCategories(3,Category4);
                Repeater5.DataSource = ds;
                Repeater5.DataBind();


                string Category5 = "Doctors and Specialists";
                ds = obj.bindCategories(6,Category5);
                Repeater6.DataSource = ds;
                Repeater6.DataBind();


                string Category6 = "Logistics Services";
                ds = obj.bindCategories(4,Category6);
                Repeater7.DataSource = ds;
                Repeater7.DataBind();


                string Category7 = "Schools and Colleges";
                ds = obj.bindCategories(6,Category7);
                Repeater8.DataSource = ds;
                Repeater8.DataBind();


                string Category8 = "Housekeeping and Cleaning";
                ds = obj.bindCategories(Category8);
                Repeater9.DataSource = ds;
                Repeater9.DataBind();

                string Category9 = "Consumer Electronics";
                string Category9A = "Kitchen and Home Appliances";
                ds = obj.bindCategories(6,Category9, Category9A);
                Repeater10.DataSource = ds;
                Repeater10.DataBind();


                string Category10 = "Jewellers and Jewellery";
                string Category10R = "Apparel and Clothing";
                ds = obj.bindCategories(3,Category10, Category10R);
                Repeater11.DataSource = ds;
                Repeater11.DataBind();

                string Category11 = "Loans";
                ds = obj.bindCategories(6,Category11);
                Repeater12.DataSource = ds;
                Repeater12.DataBind();

                string Category12 = "Taxis - Car and Bus Rentals";
                ds = obj.bindCategories(6,Category12);
                Repeater13.DataSource = ds;
                Repeater13.DataBind();


                string Category13 = "Shops and Stores";
                ds = obj.bindCategories(6,Category13);
                Repeater14.DataSource = ds;
                Repeater14.DataBind();


                string Category14 = "Travel Services";
                ds = obj.bindCategories(5,Category14); ;
                Repeater15.DataSource = ds;
                Repeater15.DataBind();



                //string Category15 = "Lodging and Boarding";
                //ds = obj.bindCategories(Category15);
                //Repeater16.DataSource = ds;
                //Repeater16.DataBind();


                //string Category16 = "Institutes";
                //ds = obj.bindCategories(Category16);
                //Repeater17.DataSource = ds;
                //Repeater17.DataBind();


                string Category17 = "Hospitals and Healthcare";
                string Category17A = "Chemists and Druggists";
                string Category17R = "Diagnostics Centres";
                ds = obj.bindCategories(7,Category17, Category17A, Category17R);
                Repeater18.DataSource = ds;
                Repeater18.DataBind();



                string Category18 = "Security and Protection";
                ds = obj.bindCategories(4,Category18);
                Repeater19.DataSource = ds;
                Repeater19.DataBind();


                string Category19 = "Insurance";
                ds = obj.bindCategories(5,Category19);
                Repeater20.DataSource = ds;
                Repeater20.DataBind();


                string Category20 = "Cellular Phone and Accessories";
                ds = obj.bindCategories(3,Category20);
                Repeater21.DataSource = ds;
                Repeater21.DataBind();


                string Category21 = "Health Clubs";
                string Category21A="Clubs and Societies";
                string Category21R="Entertainment";
                ds = obj.bindCategories(6,Category21, Category21A, Category21R);
                Repeater22.DataSource = ds;
                Repeater22.DataBind();


                //string Category22 = "Kitchen and Home Appliances";
                //ds = obj.bindCategories(Category22);
                //Repeater23.DataSource = ds;
                //Repeater23.DataBind();

                string Category23 = "General Services";
                ds = obj.bindCategories(4,Category23);
                Repeater24.DataSource = ds;
                Repeater24.DataBind();

                string Category24 = "Books and Magazines";
                ds = obj.bindCategories(6,Category24);
                Repeater25.DataSource = ds;
                Repeater25.DataBind();


                string Category25 = "Cellular Phone Repairs";
                ds = obj.bindCategories(4,Category25);
                Repeater26.DataSource = ds;
                Repeater26.DataBind();

                //string Category26 = "Chemists and Druggists";
                //ds = obj.bindCategories(Category26);
                //Repeater27.DataSource = ds;
                //Repeater27.DataBind();

                //string Category27 = "Clubs and Societies";
                //ds = obj.bindCategories(Category27);
                //Repeater28.DataSource = ds;
                //Repeater28.DataBind();


                string Category28 = "Computers Repairs";
                ds = obj.bindCategories(3,Category28);
                Repeater29.DataSource = ds;
                Repeater29.DataBind();

                string Category29 = "Real Estate";
                ds = obj.bindCategories(Category29);
                Repeater30.DataSource = ds;
                Repeater30.DataBind();

                string Category30 = "Furniture and Fixtures";
                ds = obj.bindCategories(5,Category30);
                Repeater31.DataSource = ds;
                Repeater31.DataBind();


                string Category31 = "Consultants";
                ds = obj.bindCategories(5,Category31);
                Repeater32.DataSource = ds;
                Repeater32.DataBind();

                string Category32r = "Education and Training";
                string Category33r = "Institutes"; 
                ds = obj.bindCategories(4,Category32r,Category33r);
                Repeater33.DataSource = ds;
                Repeater33.DataBind();

                string Category33 = "Emergency Services";
                ds = obj.bindCategories(Category33);
                Repeater34.DataSource = ds;
                Repeater34.DataBind();


                string Category34 = "Electronics Repairs and Services";
                string Category34R = "Automobile Repairs";
                ds = obj.bindCategories(3,Category34, Category34R);
                Repeater35.DataSource = ds;
                Repeater35.DataBind();

                string Category35 = "Legal and Financial Services";
                ds = obj.bindCategories(5,Category35);
                Repeater36.DataSource = ds;
                Repeater36.DataBind();

                string Category36 = "Automobiles";
                string Category36R = "Cars";
                ds = obj.bindCategories(5,Category36, Category36R);
                Repeater37.DataSource = ds;
                Repeater37.DataBind();


                string Category37 = "Money Transfer";
                ds = obj.bindCategories(5,Category37);
                Repeater38.DataSource = ds;
                Repeater38.DataBind();

                string Category38 = "Hobby Classes";
                ds = obj.bindCategories(6,Category38);
                Repeater39.DataSource = ds;
                Repeater39.DataBind();

                string Category39 = "Gifts and Crafts";
                ds = obj.bindCategories(6,Category39);
                Repeater40.DataSource = ds;
                Repeater40.DataBind();


                string Category40 = "Beauty Salons and Spa";
                ds = obj.bindCategories(5,Category40);
                Repeater41.DataSource = ds;
                Repeater41.DataBind();

                string Category41 = "Internet and Services";
                ds = obj.bindCategories(Category41);
                Repeater42.DataSource = ds;
                Repeater42.DataBind();

                //string Category42 = "Diagnostics Centres";
                //ds = obj.bindCategories(Category42);
                //Repeater43.DataSource = ds;
                //Repeater43.DataBind();

                string Category43 = "Home Decor and Furnishings";
                ds = obj.bindCategories(5,Category43);
                Repeater44.DataSource = ds;
                Repeater44.DataBind();

                string Category44 = "Food and Beverage Products";//&
                ds = obj.bindCategories(6,Category44);
                Repeater45.DataSource = ds;
                Repeater45.DataBind();

                //string Category45 = "Apparel and Clothing";
                //ds = obj.bindCategories(Category45);
                //Repeater46.DataSource = ds;
                //Repeater46.DataBind();


                string Category46 = "Placements and Careers";
                ds = obj.bindCategories(Category46);
                Repeater47.DataSource = ds;
                Repeater47.DataBind();

                string Category47 = "Pets and Accessories";
                ds = obj.bindCategories(5,Category47);
                Repeater48.DataSource = ds;
                Repeater48.DataBind();

                string Category48 = "Pizza";
                ds = obj.bindCategories(Category48);
                Repeater49.DataSource = ds;
                Repeater49.DataBind();


                string Category49 = "Printing and Publishing";
                ds = obj.bindCategories(3,Category49);
                Repeater50.DataSource = ds;
                Repeater50.DataBind();

                //string Category50 = "Automobile Repairs";
                //ds = obj.bindCategories(Category50);
                //Repeater51.DataSource = ds;
                //Repeater51.DataBind();

                string Category51 = "Motorcycles";
                ds = obj.bindCategories(Category51);
                Repeater52.DataSource = ds;
                Repeater52.DataBind();

                string Category52 = "Telecom Services";
                ds = obj.bindCategories(Category52);
                Repeater53.DataSource = ds;
                Repeater53.DataBind();

                string Category53 = "Jobs";
                ds = obj.bindCategories(8,Category53);
                Repeater54.DataSource = ds;
                Repeater54.DataBind();

                //string Category54 = "Entertainment";
                //ds = obj.bindCategories(Category54);
                //Repeater55.DataSource = ds;
                //Repeater55.DataBind();
                
                
                string Category57 = "Security and Protection";
                ds = obj.bindb2bCategories(5,Category57);
                Repeater58.DataSource = ds;
                Repeater58.DataBind();


                string Category58 = "Printing and Publishing";
                ds = obj.bindb2bCategories(5,Category58);
                Repeater59.DataSource = ds;
                Repeater59.DataBind();

                string Category59 = "Real Estate";
                ds = obj.bindb2bCategories(7, Category59);
                Repeater60.DataSource = ds;
                Repeater60.DataBind();

                string Category60 = "Legal and Financial Services";
                ds = obj.bindCategories(5,Category60);
                Repeater61.DataSource = ds;
                Repeater61.DataBind();

                string Category56 = "Food and Beverages";
                ds = obj.bindb2bCategories(4,Category56);
                Repeater57.DataSource = ds;
                Repeater57.DataBind();

                string Category55 = "Consumer Electronics";
                ds = obj.bindb2bCategories(Category55);
                Repeater56.DataSource = ds;
                Repeater56.DataBind();

                string Category61 = "Information Technology";
                ds = obj.bindb2bCategories(3,Category61);
                Repeater62.DataSource = ds;
                Repeater62.DataBind();

                string Category62 = "Logistics Services";
                ds = obj.bindb2bCategories(5,Category62);
                Repeater63.DataSource = ds;
                Repeater63.DataBind();

                string Category63 = "Business Services";
                ds = obj.bindb2bCategories(5,Category63);
                Repeater64.DataSource = ds;
                Repeater64.DataBind();


                string Category64 = "Electrical Equipments";
                ds = obj.bindb2bCategories(Category64);
                Repeater65.DataSource = ds;
                Repeater65.DataBind();

                string Category65 = "Health and Medical";
                ds = obj.bindb2bCategories(2,Category65);
                Repeater66.DataSource = ds;
                Repeater66.DataBind();

                string Category66 = "Chemicals";
                ds = obj.bindb2bCategories(4,Category66);
                Repeater67.DataSource = ds;
                Repeater67.DataBind();


                string Category67 = "Construction Supplies";
                ds = obj.bindb2bCategories(4,Category67);
                Repeater68.DataSource = ds;
                Repeater68.DataBind();

                string Category68 = "Building and Construction ";
                ds = obj.bindb2bCategories(4,Category68);
                Repeater69.DataSource = ds;
                Repeater69.DataBind();

                string Category69 = "Home and Garden";
                ds = obj.bindb2bCategories(Category69);
                Repeater70.DataSource = ds;
                Repeater70.DataBind();


                string Category70 = "Equipments On Hire";
                ds = obj.bindb2bCategories(2,Category70);
                Repeater71.DataSource = ds;
                Repeater71.DataBind();

                string Category71 = "Construction Machinery";
                ds = obj.bindb2bCategories(Category71);
                Repeater72.DataSource = ds;
                Repeater72.DataBind();

                string Category72 = "Metals";
                ds = obj.bindb2bCategories(4,Category72);
                Repeater73.DataSource = ds;
                Repeater73.DataBind();


                string Category73 = "Hardware and Tools";
                ds = obj.bindb2bCategories(2,Category73);
                Repeater74.DataSource = ds;
                Repeater74.DataBind();

                string Category74 = "Packaging and Paper";
                ds = obj.bindb2bCategories(4,Category74);
                Repeater75.DataSource = ds;
                Repeater75.DataBind();

                string Category75 = "Agriculture";
                ds = obj.bindb2bCategories(4,Category75);
                Repeater76.DataSource = ds;
                Repeater76.DataBind();


                string Category76 = "Engineering Components";
                ds = obj.bindb2bCategories(2,Category76);
                Repeater77.DataSource = ds;
                Repeater77.DataBind();

                string Category77 = "Plant and Machinery";
                ds = obj.bindb2bCategories(4,Category77);
                Repeater78.DataSource = ds;
                Repeater78.DataBind();

                string Category78 = "Fitness and Sports";
                ds = obj.bindb2bCategories(Category78);
                Repeater79.DataSource = ds;
                Repeater79.DataBind();


                string Category79 = "Industrial Supplies";
                ds = obj.bindb2bCategories(5,Category79);
                Repeater80.DataSource = ds;
                Repeater80.DataBind();

                string Category80 = "Scientific Instruments";
                ds = obj.bindb2bCategories(5,Category80);
                Repeater81.DataSource = ds;
                Repeater81.DataBind();

                string Category81 = "Office Supplies";
                ds = obj.bindb2bCategories(4,Category81);
                Repeater82.DataSource = ds;
                Repeater82.DataBind();


                string Category82 = "Automobiles";
                ds = obj.bindb2bCategories(Category82);
                Repeater83.DataSource = ds;
                Repeater83.DataBind();

                string Category83 = "Plastic and PVC";
                ds = obj.bindb2bCategories(4,Category83);
                Repeater84.DataSource = ds;
                Repeater84.DataBind();

                string Category84 = "Pharmaceutical";
                ds = obj.bindb2bCategories(Category84);
                Repeater85.DataSource = ds;
                Repeater85.DataBind();


                string Category85 = "Apparel and Clothing";
                ds = obj.bindb2bCategories(3,Category85);
                Repeater86.DataSource = ds;
                Repeater86.DataBind();

                string Category86 = "Gifts and Toys";
                ds = obj.bindb2bCategories(4,Category86);
                Repeater87.DataSource = ds;
                Repeater87.DataBind();

                string Category87 = "Telecommunication";
                ds = obj.bindb2bCategories(Category87);
                Repeater88.DataSource = ds;
                Repeater88.DataBind();


                string Category88 = "Luggage and Bags";
                ds = obj.bindb2bCategories(4,Category88);
                Repeater89.DataSource = ds;
                Repeater89.DataBind();

                string Category89 = "Furniture and Fixtures";
                ds = obj.bindb2bCategories(4,Category89);
                Repeater90.DataSource = ds;
                Repeater90.DataBind();

                string Category90 = "Beauty and Personal Care";
                ds = obj.bindb2bCategories(3,Category90);
                Repeater91.DataSource = ds;
                Repeater91.DataBind();


                string Category91 = "Film Production";
                ds = obj.bindb2bCategories(6,Category91);
                Repeater92.DataSource = ds;
                Repeater92.DataBind();

                string Category92 = "Event Management";
                ds = obj.bindb2bCategories(4,Category92);
                Repeater93.DataSource = ds;
                Repeater93.DataBind();

                string Category93 = "Textiles and Leather";
                ds = obj.bindb2bCategories(6,Category93);
                Repeater94.DataSource = ds;
                Repeater94.DataBind();


                string Category94 = "Fashion Accessories";
                ds = obj.bindb2bCategories(4,Category94);
                Repeater95.DataSource = ds;
                Repeater95.DataBind();

                string Category95 = "Petroleum and Petrochemical";
                ds = obj.bindb2bCategories(4,Category95);
                Repeater96.DataSource = ds;
                Repeater96.DataBind();

                string Category96 = "Gems, Jewels and Timepieces";
                ds = obj.bindb2bCategories(Category96);
                Repeater97.DataSource = ds;
                Repeater97.DataBind();


                string Category97 = "Consultants";
                ds = obj.bindb2bCategories(Category97);
                Repeater98.DataSource = ds;
                Repeater98.DataBind();

                string Category98 = "Energy and Gas";
                ds = obj.bindb2bCategories(Category98);
                Repeater99.DataSource = ds;
                Repeater99.DataBind();

                string Category99 = "Export and Import";
                ds = obj.bindb2bCategories(5,Category99);
                Repeater100.DataSource = ds;
                Repeater100.DataBind();


                //string Category100 = "Lifestyle";
                //ds = obj.bindCategories(11,Category100);
                //Repeater101.DataSource = ds;
                //Repeater101.DataBind();

                string Category101 = "Events";
                ds = obj.bindCategories(6,Category101);
                Repeater102.DataSource = ds;
                Repeater102.DataBind();


                ds = obj.binddefaultmovies();
                Repeater103.DataSource = ds;
                Repeater103.DataBind();
            }
            catch (Exception ex)
            {
                obj.insert_exception(ex, excep_page);
                Response.Redirect("HttpErrorPage.aspx");
            }
            


            //string Category103 = "Lifestyle";
            //ds = obj.bindCategories(Category103);
            //Repeater104.DataSource = ds;
            //Repeater104.DataBind();

            //string Category104 = "Events";
            //ds = obj.bindCategories(Category104);
            //Repeater105.DataSource = ds;
            //Repeater105.DataBind();
        }
    //}
    protected void Repeater103_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        try
        {
            Label Movname = (Label)e.Item.FindControl("Movie_name");
            Label movlang = (Label)e.Item.FindControl("Movie_Language");

            if (Movname != null && movlang != null)
            {
                string mname = Movname.Text;
                string mlang = movlang.Text;
                SqlCommand cmd1 = new SqlCommand("Select count(rid) as NumberOfUsers,sum(Stars_Rating) as Total from Movie_Reviews where Movie_Name='" + mname + "'and Movie_Language='" + mlang + "'", con);
                SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                float count = 0, rating = 0, result = 0;
                if (Convert.ToInt32(dt1.Rows[0]["NumberOfUsers"].ToString()) != 0)
                {
                    count = float.Parse(dt1.Rows[0]["NumberOfUsers"].ToString());
                    rating = float.Parse(dt1.Rows[0]["Total"].ToString());
                    result = Convert.ToInt32(Math.Ceiling((rating / count) * 10));
                    //avgrating.InnerText = Math.Round((rating / count), 1).ToString();

                }
                else
                {
                    //avgrating.InnerText = "0";
                }
                Label testSpan0 = (Label)e.Item.FindControl("testSpan0");
                if (testSpan0 != null)
                {
                    testSpan0.Style.Add("width", result + "px");
                }

            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    [System.Web.Script.Services.ScriptMethod()]
    [System.Web.Services.WebMethod]
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
    protected string GetIP()
    {

        try
        {
            string Sinfo;
            HttpRequest currentRequest = HttpContext.Current.Request;
            Sinfo = currentRequest.ServerVariables["HTTP_X_FORWARDED_FOR"];

            if (Sinfo == null || Sinfo.ToLower() == "unknown")
            {
                Sinfo = currentRequest.ServerVariables["REMOTE_ADDR"];
                Sinfo += "/" + currentRequest.ServerVariables["LOGON_USER"];
            }
            string[] computerinfo = Sinfo.Split('/');

            return computerinfo[0];
        }
        catch (Exception ex)
        {
            throw ex;
        }

    }
    //protected string GetIP()
    //{
    //    IPAddress[] addr = new IPAddress[0];
    //    try
    //    {
    //        string strHostName = "";


    //        strHostName = System.Net.Dns.GetHostName();

    //        IPHostEntry ipEntry = System.Net.Dns.GetHostEntry(strHostName);

    //         addr = ipEntry.AddressList;
    //    }
    //    catch (Exception ex)
    //    {
    //        obj.insert_exception(ex, excep_page);
    //        Response.Redirect("HttpErrorPage.aspx");
    //    }
    //          return addr[addr.Length - 1].ToString();

    //}
    [System.Web.Script.Services.ScriptMethod()]
    [System.Web.Services.WebMethod]
    public static List<string> GetCateOrCmpy(string prefixText)
    {
        try
        {
            string CateCity = HttpContext.Current.Session["City"].ToString();
            SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["connectionstring"]);
            con.Open();
            List<string> catnames = new List<string>();
            DataTable dt = new DataTable();
            SqlCommand cmd;
            SqlDataAdapter da;
            cmd = new SqlCommand("select distinct(Category) from modulesdata where City='" + CateCity + "' and Category like @Cat+'%'", con);
            cmd.Parameters.AddWithValue("@Cat", prefixText);
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                catnames.Add(dt.Rows[i]["Category"].ToString());
            }
            return catnames;
        }
        catch (Exception e)
        {
            e.ToString();
            return null;
        }
    }
    [System.Web.Script.Services.ScriptMethod()]
    [System.Web.Services.WebMethod]
    public static List<string> GetArea(string prefixText)
    {
        try
        {
            string city = HttpContext.Current.Session["City"].ToString();
            List<string> AreaNames = new List<string>();
            SqlConnection con1 = new SqlConnection(ConfigurationManager.AppSettings["connectionstring"]);
            con1.Open();
            SqlCommand Areacmd = new SqlCommand("select Distinct(Area),City from modulesdata where City='" + city + "'and Area like @AreaName+'%'", con1);
            Areacmd.Parameters.AddWithValue("@AreaName", prefixText);
            SqlDataAdapter da = new SqlDataAdapter(Areacmd);
            DataTable dtArea = new DataTable();
            da.Fill(dtArea);
            for (int i = 0; i < dtArea.Rows.Count; i++)
            {
                AreaNames.Add(dtArea.Rows[i]["Area"].ToString());
            }
            return AreaNames;
        }
        catch (Exception e)
        {

            e.ToString();
            return null;
        }
    }
    public void redirect(string url, bool val)
    {
        if (!val)
        {
            HttpContext.Current.Response.Redirect(url, false);
            HttpContext.Current.ApplicationInstance.CompleteRequest();
        }
        else
        {
            HttpContext.Current.Server.ClearError();
            HttpContext.Current.Response.Redirect(url, false);
            HttpContext.Current.Server.ClearError();
        }

    }
    protected void mov_click(object sender, EventArgs e)
    {
    }
    protected string GetUrl(object name, object lang)
    {
        string movlang = lang.ToString();
        string movname = name.ToString();
        return Page.GetRouteUrl("NewMoviesdata", new { location = "null", day = 0, time = 0, sort = 0, mid = "mvs_" + movname, MovId = "null" });
        //return Page.GetRouteUrl("Movies", new { mname = movname, mlang = movlang });
    }
    protected string GetCatUrl(object name)
    {
        string catname = name.ToString();
        if (catname.Contains("&"))
        {
            catname = catname.Replace("&", "amprcent");
        }
        if (catname.Contains(" "))
        {
            catname = catname.Replace(" ", "space");
        }
        if (catname.Contains("."))
        {
            catname = catname.Replace(".", "Dot");
        }
        if (catname.Contains("/"))
        {
            catname = catname.Replace("/", "slash");
        }
        if (catname.Contains("_"))
        {
            catname = catname.Replace("_", "undrscore");
        }
        
        return Page.GetRouteUrl("Link", new { cname = catname });
    }
    protected string GetUrlevent(object category)
    {
        string catname = category.ToString();
        return Page.GetRouteUrl("Event_links", new { cname = catname });
    }
    protected string GetUrl_LifeStyle(object Lifecat)
    {
        string catname = Lifecat.ToString();
        return Page.GetRouteUrl("LifeStyle_Sub", new { cat = catname });
    }
    protected string GetUrl_jobs(object jobcat)
    {
        string cname = jobcat.ToString();
        return Page.GetRouteUrl("job_link", new { catname = cname });
    }
  }
