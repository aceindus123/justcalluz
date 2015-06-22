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
using JustCallUsData.Data;
using System.Data.SqlClient;
/// <summary>
/// Home page of admin control & displays respective selection.
/// </summary>
public partial class admin_Admin_Home : System.Web.UI.Page
{
    WebAdminCreation web_admin = new WebAdminCreation();
    DataCS data = new DataCS();
    string UserId;
    DataSet ds = new DataSet();
    string mod;
    Int32 chid;
    DataSet dsmap = new DataSet();
    MoviesCS obj = new MoviesCS();
    string Map;
    string designation;
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    /// <summary>
    /// code to display whenever page loads
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Page_Load(object sender, EventArgs e)
    {
        UserId = Convert.ToString(Session["LogInId"]);
        if (UserId != "")
        {
           
            // loads the page without refreshing
            if (!Page.IsPostBack)
            {
                // it will stays in the same page
                if (Convert.ToString(Request.QueryString["mod"]) !=null)
                {
                    string category = Convert.ToString(Request.QueryString["mod"]);
                    GetModule(category);
                }
                else
                {
                    GetModule();
                }
                getcount();
                DataCS data = new DataCS();
                //To bind States
                data.FillStates(ddlState);
            }
        }
        else
        {
            //After login into the account it will go Post ad
            Response.Redirect("Default.aspx");

        }
       
          
    }
    /// <summary>
    /// Get module based on parameter
    /// </summary>
    public void GetModule(string module)
    {
        ds = web_admin.getWebAdminPermissions(UserId);
        if (!ds.Tables[0].Rows.Count.Equals(0))
        {
            //To bind Modules
            if (module == "Events")
            {
                ddlModule.Items.Add(module);
            }
            else if (module == "Discounts")
            {
                ddlModule.Items.Add(module);
            }
            else if (module == "Jobs")
            {
                ddlModule.Items.Add(module);
            }
            else if (module == "Category")
            {
                ddlModule.Items.Add(module);
            }
            else if (module == "B2B Category")
            {
                ddlModule.Items.Add(module);
            }
        }
    }
    /// <summary>
    /// Get module based on userid
    /// </summary>
    public void GetModule()
    {        
        ds = web_admin.getWebAdminPermissions(UserId);
        if (!ds.Tables[0].Rows.Count.Equals(0))
        {
            //To bind Modules
            string BView = ds.Tables[0].Rows[0]["B"].ToString();
            if (BView == "1")
            {
                ddlModule.Items.Add("Category");

            }

            string B2BView = ds.Tables[0].Rows[0]["B2BView"].ToString();
            if (B2BView == "1")
            {
                ddlModule.Items.Add("B2B Category");

            }
            string EveView = ds.Tables[0].Rows[0]["EveView"].ToString();
            if (EveView == "1")
            {
                ddlModule.Items.Add("Events");

            }
            string DisView = ds.Tables[0].Rows[0]["DisView"].ToString();
            if (DisView == "1")
            {
                ddlModule.Items.Add("Discounts");

            }
            string JobView = ds.Tables[0].Rows[0]["JobView"].ToString();
            if (JobView == "1")
            {
                ddlModule.Items.Add("Jobs");

            }
            string LSView = ds.Tables[0].Rows[0]["LSView"].ToString();
            if (LSView == "1")
            {
                ddlModule.Items.Add("LifeStyle");

            }
            string FLView = ds.Tables[0].Rows[0]["FLView"].ToString();
            if (FLView == "1")
            {
                ddlModule.Items.Add("FreeListing");
            }
            string MoviesView = ds.Tables[0].Rows[0]["MoviesView"].ToString();
            if (MoviesView == "1")
            {
                ddlModule.Items.Add("Movies");
            }
        }
    }
    /// <summary>
    /// Fill B2B categories
    /// </summary>
    /// <param name="Categoty_Name"></param>
    public void fillB2BSubCategories(string Categoty_Name)
    {
        try
        {
            string Connection = ConfigurationManager.AppSettings["ConnectionString"];
            SqlConnection oCon = new SqlConnection(Connection);
            string s = "select id,cat from B2BCategories where maincat= '" + Categoty_Name + "' order by cat";
            SqlCommand cmd = new SqlCommand(s, oCon);
            oCon.Open();
            SqlDataAdapter da = new SqlDataAdapter(s, oCon);
            DataSet ds = new DataSet();
            da.Fill(ds, "SubCategory");
            ddlSubCat.DataSource = ds.Tables["SubCategory"];
            ddlSubCat.DataValueField = "cat";
            ddlSubCat.DataTextField = "cat";
            ddlSubCat.DataBind();
            ddlSubCat.Items.Insert(0, "Select Sub Category");
            oCon.Close();
        }
        catch (Exception ex)
        {
            lblMessage.Text = ex.Message.ToString();
        }
    }
    public void fillFLSubCategories(string Categoty_Name)
    {
        try
        {
            string Connection = ConfigurationManager.AppSettings["ConnectionString"];
            SqlConnection oCon = new SqlConnection(Connection);
            string s = "select sid,Sub_Cat from FreeListing_SubCat where Cat= '" + Categoty_Name + "' order by cat";
            SqlCommand cmd = new SqlCommand(s, oCon);
            oCon.Open();
            SqlDataAdapter da = new SqlDataAdapter(s, oCon);
            DataSet ds = new DataSet();
            da.Fill(ds, "SubCategory");
            ddlSubCat.DataSource = ds.Tables["SubCategory"];
            ddlSubCat.DataValueField = "Sub_Cat";
            ddlSubCat.DataTextField = "Sub_Cat";
            ddlSubCat.DataBind();
            ddlSubCat.Items.Insert(0, "Select Sub Category");
            oCon.Close();
        }
        catch (Exception ex)
        {
            lblMessage.Text = ex.Message.ToString();
        }
    }
    /// <summary>
    ///  To fill the categories for the respective module selection made
    /// </summary>
    /// <param name="Module_Name"></param>
    public void fillCategories(string Module_Name)
    {         
        try
        {
            string Connection = ConfigurationManager.AppSettings["ConnectionString"];
            SqlConnection oCon = new SqlConnection(Connection);
            if (Module_Name == "Discounts")
            {
                Module_Name = "Category";
            }
            else
            {
            }
            string s = "(select Category from Categories where Module= '" + Module_Name + "') except (select Category from Categories where Category='Movies') order by Category";
            SqlCommand cmd = new SqlCommand(s, oCon);
            oCon.Open();
            SqlDataAdapter da = new SqlDataAdapter(s, oCon);
            DataSet ds = new DataSet();
            da.Fill(ds, "Category");
            ddlCategory.DataSource = ds.Tables["Category"];
            ddlCategory.DataValueField = "Category";
            ddlCategory.DataTextField = "Category";
            ddlCategory.DataBind();
            ddlCategory.Items.Insert(0, "Select Category");
            oCon.Close();
        }
        // To catch exception
        catch (Exception ex)
        {
            lblMessage.Text = ex.Message.ToString();
        }
    }
    /// <summary>
    /// Fill Life Style sub categories
    /// </summary>
    /// <param name="Categoty_Name"></param>
    public void fillLifeStyleSubCat(string Categoty_Name)
    {
        try
        {
            string Connection = ConfigurationManager.AppSettings["ConnectionString"];
            SqlConnection oCon = new SqlConnection(Connection);
            string s = "select id,SubCategeory from Lifestyle where Categeory= '" + Categoty_Name + "'";
            SqlCommand cmd = new SqlCommand(s, oCon);
            oCon.Open();
            SqlDataAdapter da = new SqlDataAdapter(s, oCon);
            DataSet ds = new DataSet();
            da.Fill(ds, "SubCategory");
            ddlSubCat.DataSource = ds.Tables["SubCategory"];
            ddlSubCat.DataValueField = "SubCategeory";
            ddlSubCat.DataTextField = "SubCategeory";
            ddlSubCat.DataBind();
            ddlSubCat.Items.Insert(0, "Select Sub Category");
            oCon.Close();
        }
        catch (Exception ex)
        {
            lblMessage.Text = ex.Message.ToString();
        }
    }
    /// <summary>
    /// To fill the sub categories for the respective categories selection made
    /// </summary>
    /// <param name="Categoty_Name"></param>
    public void fillSubCategories(string Categoty_Name)
    {
        try
        {
            string Connection = ConfigurationManager.AppSettings["ConnectionString"];
            SqlConnection oCon = new SqlConnection(Connection);
            string s = "select id,cat from subcatageory where maincat= '" + Categoty_Name + "' order by cat";
            SqlCommand cmd = new SqlCommand(s, oCon);
            oCon.Open();
            SqlDataAdapter da = new SqlDataAdapter(s, oCon);
            DataSet ds = new DataSet();
            da.Fill(ds, "SubCategory");
            ddlSubCat.DataSource = ds.Tables["SubCategory"];
            ddlSubCat.DataValueField = "cat";
            ddlSubCat.DataTextField = "cat";
            ddlSubCat.DataBind();
            ddlSubCat.Items.Insert(0, "Select Sub Category");
            oCon.Close();
        }
        catch (Exception ex)
        {
            lblMessage.Text = ex.Message.ToString();
        }
    }
    /// <summary>
    /// To fill the Cities for the respective States selection made
    /// </summary>
    /// <param name="StateName"></param>
    public void fillCities(string StateName)
    {
        try
        {
            string Connection = ConfigurationManager.AppSettings["ConnectionString"];
            SqlConnection oCon = new SqlConnection(Connection);
            string s = "select city_Id,city_name from Cities where state_name= '" + StateName + "' order by city_name";
            SqlCommand cmd = new SqlCommand(s, oCon);
            oCon.Open();
            SqlDataAdapter da = new SqlDataAdapter(s, oCon);
            DataSet ds = new DataSet();
            da.Fill(ds, "Cities");
            //DlCities.SelectedIndex = 0;

            ddlCity.DataSource = ds.Tables["Cities"];
            ddlCity.DataValueField = "city_name";
            ddlCity.DataTextField = "city_name";
            ddlCity.DataBind();
            ddlCity.Items.Insert(0, "Select City");
            oCon.Close();
        }
        catch (Exception ex)
        {
            lblMessage.Text = ex.Message.ToString();
        }
    }
    /// <summary>
    ///  execute when module selection made changed 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void ddlModule_SelectedIndexChanged(object sender, EventArgs e)
    {

        if (ddlModule.SelectedIndex != 0)
        {
            if (ddlModule.SelectedValue == "B2B Category")
            {
                string Module_Name = Convert.ToString(ddlModule.SelectedValue);
                DataCS data = new DataCS();
                //To bind Categories
                data.FillB2BCategory(ddlCategory);
            }
            else if (ddlModule.SelectedValue == "LifeStyle")
            {
                data.FillLifeStyleCategory(ddlCategory);
            }
            else if (ddlModule.SelectedValue == "Movies")
            {
                ddlCategory.Items.Clear();
                ddlCategory.Items.Add(new ListItem("Select Category", "Select Category"));
                ddlCategory.Items.Add(new ListItem("Entertainment","Entertainment")); 
            }
            else if (ddlModule.SelectedValue == "FreeListing")
            {
                string Module_Name = Convert.ToString(ddlModule.SelectedValue);
                DataCS data = new DataCS();
                //To bind Categories
                data.FillFreeListing(ddlCategory);
            }
            else 
            {
                string Module_Name = Convert.ToString(ddlModule.SelectedValue);
                fillCategories(Module_Name); 
            }
        }
        else
        {
            ddlCategory.Items.Clear();
            ddlCategory.Items.Insert(0, "Select Category");
        }
    }
    /// <summary>
    /// execute when Category selection made changed 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void ddlCategory_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlCategory.SelectedIndex != 0)
        {
            string Categoty_Name = Convert.ToString(ddlCategory.SelectedValue);
            if (ddlModule.SelectedValue == "LifeStyle")
            {
                string statement = "select * from Lifestyle where Categeory='" + ddlCategory.SelectedValue + "'";
                SqlDataAdapter adabrand = new SqlDataAdapter(statement, con);
                DataSet dsbrand = new DataSet();
                adabrand.Fill(dsbrand);
                if (!dsbrand.Tables[0].Rows.Count.Equals(0))
                {
                    trSubCat.Visible = true;
                    fillLifeStyleSubCat(Categoty_Name);
                }
                else
                {
                    trSubCat.Visible = false;
                    ddlSubCat.Items.Clear();
                    ddlSubCat.Items.Insert(0, "Select SubCategory");
                }               
            }
            else if (ddlModule.SelectedValue == "B2B Category")
            {
                string statement1 = "select * from B2BCategories where maincat='" + ddlCategory.SelectedValue + "'";
                SqlDataAdapter adab2b= new SqlDataAdapter(statement1, con);
                DataSet dsb2b = new DataSet();
                adab2b.Fill(dsb2b);
                if (!dsb2b.Tables[0].Rows.Count.Equals(0))
                {

                    trSubCat.Visible = true;
                    fillB2BSubCategories(Categoty_Name);
                }
                else
                {
                    trSubCat.Visible = false;
                    ddlSubCat.Items.Clear();
                    ddlSubCat.Items.Insert(0, "Select SubCategory");
                }  
            }
            else if (ddlModule.SelectedValue == "FreeListing")
            {
                string statement0 = "select * from FreeListing_SubCat where Cat='" + ddlCategory.SelectedValue + "'";
                con.Open();
                SqlDataAdapter adFL = new SqlDataAdapter(statement0, con);
                DataSet dsFL = new DataSet();
                adFL.Fill(dsFL);
                con.Close();
                if (!dsFL.Tables[0].Rows.Count.Equals(0))
                {
                    trSubCat.Visible = true;
                    fillFLSubCategories(Categoty_Name);
                }
                else
                {
                    trSubCat.Visible = false;
                    ddlSubCat.Items.Clear();
                    ddlSubCat.Items.Insert(0, "Select SubCategory");
                }
            }
            else if (ddlModule.SelectedValue == "Movies")
            {
                ddlSubCat.Items.Clear(); 
                ddlSubCat.Items.Add(new ListItem("Select SubCategory","Select SubCategory"));
                ddlSubCat.Items.Add(new ListItem("Cinema Halls","Cinema Halls"));
                ddlSubCat.Items.Add(new ListItem("Multiplex Cinema Halls", "Multiplex Cinema Halls"));                
            }
            else
            {
                string statement2 = "select * from subcatageory where maincat='" + ddlCategory.SelectedValue + "'";
                SqlDataAdapter adacat = new SqlDataAdapter(statement2, con);
                DataSet dscat = new DataSet();
                adacat.Fill(dscat);
                if (!dscat.Tables[0].Rows.Count.Equals(0))
                {
                    trSubCat.Visible = true;
                    fillSubCategories(Categoty_Name);
                }
                else
                {
                    trSubCat.Visible = false;
                    ddlSubCat.Items.Clear();
                    ddlSubCat.Items.Insert(0, "Select SubCategory");
                }    
                
            }
        }
        else
        {
            ddlSubCat.Items.Clear();
            ddlSubCat.Items.Insert(0, "Select Sub Category");
        }                   
    }
    /// <summary>
    /// execute when State selection made changed 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void ddlState_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlState.SelectedIndex != 0)
        {
            string State_Name = Convert.ToString(ddlState.SelectedValue);
            fillCities(State_Name);
        }
        else
        {
            ddlCity.Items.Clear();
            ddlCity.Items.Insert(0, "Select City");
        }
    }
    /// <summary>
    /// To click on the button Getdata button
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnGetData_Click(object sender, EventArgs e)
    {
        ItemsGet();
    }
    /// <summary>
    /// For page change
    /// </summary>
    /// <param name="source"></param>
    /// <param name="e"></param>
    protected void ViewGrid_PageIndexChanged(object source, DataGridPageChangedEventArgs e)
    {
        ViewGrid.CurrentPageIndex = e.NewPageIndex;        
        ItemsGet();
    }
    /// <summary>
    /// Function to get the data from database when we click on get data button
    /// </summary>
    private void ItemsGet()
    {
        string modulename = "";
        string category = "";
        string subcategory = "";
        string state="";
        string city="";
        modulename = Convert.ToString(ddlModule.SelectedValue);
        category = Convert.ToString(ddlCategory.SelectedValue);
        subcategory = Convert.ToString(ddlSubCat.SelectedValue);
        state=Convert.ToString(ddlState.SelectedValue);
        city=Convert.ToString(ddlCity.SelectedValue);
            DataSet ds = new DataSet();
            string con = ConfigurationManager.AppSettings["ConnectionString"];
            string statement;
            SqlConnection sqlConnection = new SqlConnection(con);
            sqlConnection.Open();
            if (subcategory != "Select SubCategory")
            {
                statement = "select m.*,Post_Date=Convert(varchar,m.postdate,105),Expire_Date=Convert(varchar,m.expdate,105),Case when m.ApprovedStatus=1 Then 'Approved' When m.ApprovedStatus=2  Then 'Rejected' When m.ApprovedStatus=3  Then 'Updated' Else 'Posted' End  Status," +
                               "(select count(p.rid) from PostReview p where m.id=p.dataid) as Review_Count," +
                               "(select count(r.id) from report r where r.report_type='abuse' and m.id=r.dataid) as abuse_Count," +
                               "(select count(r.id) from report r where r.report_type='incorrect' and m.id=r.dataid) as incorrect_Count " +
                               "from ModulesData as m " +
                               "full join PostReview as p " +
                               "on m.id=p.dataid " +
                               "full join report as r " +
                               "on m.id=r.dataid " +
                               "where m.module='" + modulename + "' and m.Category='" + category + "' and m.SubCategory='" + subcategory + "' and m.State='" + state + "' and m.City='" + city + "' and m.ApprovedStatus='1'" +
                               "group by m.id,m.module,m.Category,m.SubCategory,m.State,m.City,m.company_name,m.job_industry,m.job_functional_area,m.job_exp,m.job_sal,m.job_desc,m.job_keyskills,m.company_profile," +
                               "m.event_name,m.event_place,m.event_startdate,m.event_enddate,m.event_desc,m.event_time,m.address,m.land_mark,m.contact_person,m.emailid,m.mob,m.landphno,m.fax," +
                               "m.postdate,m.expdate,m.job_role,m.job_Qualification,m.Other_SubCat,m.Area,m.evedi_DurationType,m.Job_ExpiryDate,m.Age,m.Website,m.UserLoginId,m.ApprovedStatus,m.Pincode,m.ImageName,m.ImageContentType,m.free_specifany,m.CatSub,m.map,m.Approved_map order by m.id desc";
            }
            else
            {
                statement = "select m.*,Post_Date=Convert(varchar,m.postdate,105),Expire_Date=Convert(varchar,m.expdate,105),Case when m.ApprovedStatus=1 Then 'Approved' When m.ApprovedStatus=2  Then 'Rejected' When m.ApprovedStatus=3  Then 'Updated' Else 'Posted' End  Status," +
                               "(select count(p.rid) from PostReview p where m.id=p.dataid) as Review_Count," +
                               "(select count(r.id) from report r where r.report_type='abuse' and m.id=r.dataid) as abuse_Count," +
                               "(select count(r.id) from report r where r.report_type='incorrect' and m.id=r.dataid) as incorrect_Count " +
                               "from ModulesData as m " +
                               "full join PostReview as p " +
                               "on m.id=p.dataid " +
                               "full join report as r " +
                               "on m.id=r.dataid " +
                               "where m.module='" + modulename + "' and m.Category='" + category + "' and m.State='" + state + "' and m.City='" + city + "' and m.ApprovedStatus='1'" +
                               "group by m.id,m.module,m.Category,m.SubCategory,m.State,m.City,m.company_name,m.job_industry,m.job_functional_area,m.job_exp,m.job_sal,m.job_desc,m.job_keyskills,m.company_profile," +
                               "m.event_name,m.event_place,m.event_startdate,m.event_enddate,m.event_desc,m.event_time,m.address,m.land_mark,m.contact_person,m.emailid,m.mob,m.landphno,m.fax," +
                               "m.postdate,m.expdate,m.job_role,m.job_Qualification,m.Other_SubCat,m.Area,m.evedi_DurationType,m.Job_ExpiryDate,m.Age,m.Website,m.UserLoginId,m.ApprovedStatus,m.Pincode,m.ImageName,m.ImageContentType,m.free_specifany,m.CatSub,m.map,m.Approved_map order by m.id desc";
            }
            SqlDataAdapter imgtext = new SqlDataAdapter(statement, sqlConnection);
            imgtext.Fill(ds, "categoryData");
            DataView dtView = ds.Tables[0].DefaultView;
            if (!ds.Tables[0].Rows.Count.Equals(0))
            {               
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    ViewGrid.DataSource = ds;
                    ViewGrid.DataBind();
                    if (modulename == "Category")
                    {
                        ViewGrid.Columns[0].Visible = false;
                        ViewGrid.Columns[1].Visible = true;
                        ViewGrid.Columns[2].Visible = false;
                        ViewGrid.Columns[3].Visible = false;
                        ViewGrid.Columns[4].Visible = false;
                        ViewGrid.Columns[5].Visible = false;
                        ViewGrid.Columns[6].Visible = false;
                        ViewGrid.Columns[7].Visible = false;
                        ViewGrid.Columns[8].Visible = false;
                        ViewGrid.Columns[9].Visible = false;
                        ViewGrid.Columns[10].Visible = false;
                        ViewGrid.Columns[11].Visible = false;
                        ViewGrid.Columns[12].Visible = false;
                        ViewGrid.Columns[13].Visible = false;
                        ViewGrid.Columns[14].Visible = false;
                        ViewGrid.Columns[15].Visible = false;
                        ViewGrid.Columns[16].Visible = false;
                        ViewGrid.Columns[17].Visible = true;
                        ViewGrid.Columns[18].Visible = true;
                        ViewGrid.Columns[19].Visible = true;
                        ViewGrid.Columns[20].Visible = true;
                        ViewGrid.Columns[21].Visible = true;
                        ViewGrid.Columns[22].Visible = false;
                        ViewGrid.Columns[23].Visible = true;
                        ViewGrid.Columns[25].Visible = true;
                        ViewGrid.Columns[26].Visible = true;
                        ViewGrid.Columns[27].Visible = true;
                        string BEdit=Convert.ToString(Session["BEdit"]);
                        if (BEdit == "1")
                        {
                            ViewGrid.Columns[29].Visible = true;
                        }
                        else
                        {
                            ViewGrid.Columns[29].Visible = false;
                        }
                        string BDel = Convert.ToString(Session["BDel"]);
                        if (BDel == "1")
                        {
                            ViewGrid.Columns[30].Visible = true;
                        }
                        else
                        {
                            ViewGrid.Columns[30].Visible = false;
                        }
                    }
                    if (modulename == "FreeListing")
                    {
                        ViewGrid.Columns[0].Visible = true;
                        ViewGrid.Columns[1].Visible = false;
                        ViewGrid.Columns[2].Visible = false;
                        ViewGrid.Columns[3].Visible = false;
                        ViewGrid.Columns[4].Visible = false;
                        ViewGrid.Columns[5].Visible = false;
                        ViewGrid.Columns[6].Visible = false;
                        ViewGrid.Columns[7].Visible = false;
                        ViewGrid.Columns[8].Visible = false;
                        ViewGrid.Columns[9].Visible = false;
                        ViewGrid.Columns[10].Visible = false;
                        ViewGrid.Columns[11].Visible = false;
                        ViewGrid.Columns[12].Visible = false;
                        ViewGrid.Columns[13].Visible = false;
                        ViewGrid.Columns[14].Visible = false;
                        ViewGrid.Columns[15].Visible = false;
                        ViewGrid.Columns[16].Visible = false;
                        ViewGrid.Columns[17].Visible = true;
                        ViewGrid.Columns[18].Visible = true;
                        ViewGrid.Columns[19].Visible = true;
                        ViewGrid.Columns[20].Visible = true;
                        ViewGrid.Columns[21].Visible = true;
                        ViewGrid.Columns[22].Visible = false;
                        ViewGrid.Columns[23].Visible = true;
                        ViewGrid.Columns[25].Visible = true;
                        ViewGrid.Columns[26].Visible = true;
                        ViewGrid.Columns[27].Visible = true;
                        string FEdit = Convert.ToString(Session["FLEdit"]);
                        if (FEdit == "1")
                        {
                            ViewGrid.Columns[29].Visible = true;
                        }
                        else
                        {
                            ViewGrid.Columns[29].Visible = false;
                        }
                        string FDel = Convert.ToString(Session["FLDel"]);
                        if (FDel == "1")
                        {
                            ViewGrid.Columns[30].Visible = true;
                        }
                        else
                        {
                            ViewGrid.Columns[30].Visible = false;
                        }
                    }
                    else if (modulename == "Jobs")
                    {
                        ViewGrid.Columns[1].Visible = false;
                        ViewGrid.Columns[1].Visible = true;
                        ViewGrid.Columns[2].Visible = false;
                        ViewGrid.Columns[3].Visible = false;
                        ViewGrid.Columns[4].Visible = true;
                        ViewGrid.Columns[5].Visible = true;
                        ViewGrid.Columns[6].Visible = true;
                        ViewGrid.Columns[7].Visible = false;
                        ViewGrid.Columns[8].Visible = false;
                        ViewGrid.Columns[9].Visible = false;
                        ViewGrid.Columns[10].Visible = false;
                        ViewGrid.Columns[11].Visible = false;
                        ViewGrid.Columns[12].Visible = false;
                        ViewGrid.Columns[13].Visible = false;
                        ViewGrid.Columns[14].Visible = false;
                        ViewGrid.Columns[15].Visible = false;
                        ViewGrid.Columns[16].Visible = false;
                        ViewGrid.Columns[17].Visible = true;
                        ViewGrid.Columns[18].Visible = true;
                        ViewGrid.Columns[19].Visible = false;
                        ViewGrid.Columns[20].Visible = false;
                        ViewGrid.Columns[21].Visible = true;
                        ViewGrid.Columns[22].Visible = false;
                        ViewGrid.Columns[23].Visible = true;
                        ViewGrid.Columns[25].Visible = false;
                        ViewGrid.Columns[26].Visible = true;
                        ViewGrid.Columns[27].Visible = false;
                        string JobEdit = Convert.ToString(Session["JobEdit"]);
                        if (JobEdit == "1")
                        {
                            ViewGrid.Columns[29].Visible = true;
                        }
                        else
                        {
                            ViewGrid.Columns[29].Visible = false;
                        }
                        string JobDel = Convert.ToString(Session["JobDel"]);
                        if (JobDel == "1")
                        {
                            ViewGrid.Columns[30].Visible = true;
                        }
                        else
                        {
                            ViewGrid.Columns[30].Visible = false;
                        }

                    }
                    else if (modulename == "Events")
                    {
                        ViewGrid.Columns[0].Visible = false;
                        ViewGrid.Columns[1].Visible = false;
                        ViewGrid.Columns[2].Visible = false;
                        ViewGrid.Columns[3].Visible = false;
                        ViewGrid.Columns[4].Visible = false;
                        ViewGrid.Columns[5].Visible = false;
                        ViewGrid.Columns[6].Visible = false;
                        ViewGrid.Columns[7].Visible = false;
                        ViewGrid.Columns[8].Visible = false;
                        ViewGrid.Columns[9].Visible = false;
                        ViewGrid.Columns[10].Visible = true;
                        ViewGrid.Columns[11].Visible = true;
                        ViewGrid.Columns[12].Visible = true;
                        ViewGrid.Columns[13].Visible = true;
                        ViewGrid.Columns[14].Visible = true;
                        ViewGrid.Columns[15].Visible = false;
                        ViewGrid.Columns[16].Visible = false;
                        ViewGrid.Columns[17].Visible = true;
                        ViewGrid.Columns[18].Visible = true;
                        ViewGrid.Columns[19].Visible = false;
                        ViewGrid.Columns[20].Visible = false;
                        ViewGrid.Columns[21].Visible = true;
                        ViewGrid.Columns[22].Visible = false;
                        ViewGrid.Columns[23].Visible = true;
                        ViewGrid.Columns[25].Visible = false;
                        ViewGrid.Columns[26].Visible = false;
                        ViewGrid.Columns[27].Visible = false;
                        string EveEdit = Convert.ToString(Session["EveEdit"]);
                        if (EveEdit == "1")
                        {
                            ViewGrid.Columns[29].Visible = true;
                        }
                        else
                        {
                            ViewGrid.Columns[29].Visible = false;
                        }
                        string EveDel = Convert.ToString(Session["EveDel"]);
                        if (EveDel == "1")
                        {
                            ViewGrid.Columns[30].Visible = true;
                        }
                        else
                        {
                            ViewGrid.Columns[30].Visible = false;
                        }

                    }
                    else if (modulename == "Discounts")
                    {
                        ViewGrid.Columns[0].Visible = false;
                        ViewGrid.Columns[1].Visible = true;
                        ViewGrid.Columns[2].Visible = false;
                        ViewGrid.Columns[3].Visible = false;
                        ViewGrid.Columns[4].Visible = false;
                        ViewGrid.Columns[5].Visible = false;
                        ViewGrid.Columns[6].Visible = false;
                        ViewGrid.Columns[7].Visible = false;
                        ViewGrid.Columns[8].Visible = false;
                        ViewGrid.Columns[9].Visible = false;
                        ViewGrid.Columns[10].Visible = false;
                        ViewGrid.Columns[11].Visible = false;
                        ViewGrid.Columns[12].Visible = true;
                        ViewGrid.Columns[13].Visible = true;
                        ViewGrid.Columns[14].Visible = true;
                        ViewGrid.Columns[15].Visible = false;
                        ViewGrid.Columns[16].Visible = false;
                        ViewGrid.Columns[17].Visible = true;
                        ViewGrid.Columns[18].Visible = true;
                        ViewGrid.Columns[19].Visible = false;
                        ViewGrid.Columns[20].Visible = false;
                        ViewGrid.Columns[21].Visible = true;
                        ViewGrid.Columns[22].Visible = false;
                        ViewGrid.Columns[23].Visible = true;
                        ViewGrid.Columns[25].Visible = true;
                        ViewGrid.Columns[26].Visible = true;
                        ViewGrid.Columns[27].Visible = true;
                        string DisEdit = Convert.ToString(Session["DisEdit"]);
                        if (DisEdit == "1")
                        {
                            ViewGrid.Columns[29].Visible = true;
                        }
                        else
                        {
                            ViewGrid.Columns[29].Visible = false;
                        }
                        string DisDel = Convert.ToString(Session["DisDel"]);
                        if (DisDel == "1")
                        {
                            ViewGrid.Columns[30].Visible = true;
                        }
                        else
                        {
                            ViewGrid.Columns[30].Visible = false;
                        }

                    }
                    else if (modulename == "LifeStyle")
                    {
                        ViewGrid.Columns[0].Visible = false;
                        ViewGrid.Columns[1].Visible = true;
                        ViewGrid.Columns[2].Visible = false;
                        ViewGrid.Columns[3].Visible = false;
                        ViewGrid.Columns[4].Visible = false;
                        ViewGrid.Columns[5].Visible = false;
                        ViewGrid.Columns[6].Visible = false;
                        ViewGrid.Columns[7].Visible = false;
                        ViewGrid.Columns[8].Visible = false;
                        ViewGrid.Columns[9].Visible = false;
                        ViewGrid.Columns[10].Visible = false;
                        ViewGrid.Columns[11].Visible = false;
                        ViewGrid.Columns[12].Visible = false;
                        ViewGrid.Columns[13].Visible = false;
                        ViewGrid.Columns[14].Visible = false;
                        ViewGrid.Columns[15].Visible = false;
                        ViewGrid.Columns[16].Visible = false;
                        ViewGrid.Columns[17].Visible = true;
                        ViewGrid.Columns[18].Visible = true;
                        ViewGrid.Columns[19].Visible = true;
                        ViewGrid.Columns[20].Visible = true;
                        ViewGrid.Columns[21].Visible = true;
                        ViewGrid.Columns[22].Visible = false;
                        ViewGrid.Columns[23].Visible = true;
                        ViewGrid.Columns[25].Visible = true;
                        ViewGrid.Columns[26].Visible = true;
                        ViewGrid.Columns[27].Visible = true;
                        string LSEdit = Convert.ToString(Session["LSEdit"]);
                        if (LSEdit == "1")
                        {
                            ViewGrid.Columns[29].Visible = true;
                        }
                        else
                        {
                            ViewGrid.Columns[29].Visible = false;
                        }
                        string LSDel = Convert.ToString(Session["LSDel"]);
                        if (LSDel == "1")
                        {
                            ViewGrid.Columns[30].Visible = true;
                        }
                        else
                        {
                            ViewGrid.Columns[30].Visible = false;
                        }

                    }
                    else if (modulename == "B2B Category")
                    {
                        ViewGrid.Columns[0].Visible = false;
                        ViewGrid.Columns[1].Visible = true;
                        ViewGrid.Columns[2].Visible = false;
                        ViewGrid.Columns[3].Visible = false;
                        ViewGrid.Columns[4].Visible = false;
                        ViewGrid.Columns[5].Visible = false;
                        ViewGrid.Columns[6].Visible = false;
                        ViewGrid.Columns[7].Visible = false;
                        ViewGrid.Columns[8].Visible = false;
                        ViewGrid.Columns[9].Visible = false;
                        ViewGrid.Columns[10].Visible = false;
                        ViewGrid.Columns[11].Visible = false;
                        ViewGrid.Columns[12].Visible = false;
                        ViewGrid.Columns[13].Visible = false;
                        ViewGrid.Columns[14].Visible = false;
                        ViewGrid.Columns[15].Visible = false;
                        ViewGrid.Columns[16].Visible = false;
                        ViewGrid.Columns[17].Visible = true;
                        ViewGrid.Columns[18].Visible = true;
                        ViewGrid.Columns[19].Visible = true;
                        ViewGrid.Columns[20].Visible = true;
                        ViewGrid.Columns[21].Visible = true;
                        ViewGrid.Columns[22].Visible = false;
                        ViewGrid.Columns[23].Visible = true;
                        ViewGrid.Columns[25].Visible = true;
                        ViewGrid.Columns[26].Visible = true;
                        ViewGrid.Columns[27].Visible = true;
                        string B2BEdit = Convert.ToString(Session["B2BEdit"]);
                        if (B2BEdit == "1")
                        {
                            ViewGrid.Columns[29].Visible = true;
                        }
                        else
                        {
                            ViewGrid.Columns[29].Visible = false;
                        }
                        string B2BDel = Convert.ToString(Session["B2BDel"]);
                        if (B2BDel == "1")
                        {
                            ViewGrid.Columns[30].Visible = true;
                        }
                        else
                        {
                            ViewGrid.Columns[30].Visible = false;
                        }
                    }
                    else if (modulename == "Movies")
                    {
                        ViewGrid.Columns[0].Visible = false;
                        ViewGrid.Columns[1].Visible = true;
                        ViewGrid.Columns[2].Visible = false;
                        ViewGrid.Columns[3].Visible = false;
                        ViewGrid.Columns[4].Visible = false;
                        ViewGrid.Columns[5].Visible = false;
                        ViewGrid.Columns[6].Visible = false;
                        ViewGrid.Columns[7].Visible = false;
                        ViewGrid.Columns[8].Visible = false;
                        ViewGrid.Columns[9].Visible = false;
                        ViewGrid.Columns[10].Visible = false;
                        ViewGrid.Columns[11].Visible = false;
                        ViewGrid.Columns[12].Visible = false;
                        ViewGrid.Columns[13].Visible = false;
                        ViewGrid.Columns[14].Visible = false;
                        ViewGrid.Columns[15].Visible = false;
                        ViewGrid.Columns[16].Visible = false;
                        ViewGrid.Columns[17].Visible = true;
                        ViewGrid.Columns[18].Visible = true;
                        ViewGrid.Columns[19].Visible = true;
                        ViewGrid.Columns[20].Visible = true;
                        ViewGrid.Columns[21].Visible = true;
                        ViewGrid.Columns[22].Visible = false;
                        ViewGrid.Columns[23].Visible = true;
                        ViewGrid.Columns[25].Visible = true;
                        ViewGrid.Columns[26].Visible = true;
                        ViewGrid.Columns[27].Visible = true;
                        string BEdit = Convert.ToString(Session["BEdit"]);
                        if (BEdit == "1")
                        {
                            ViewGrid.Columns[29].Visible = true;
                        }
                        else
                        {
                            ViewGrid.Columns[29].Visible = false;
                        }
                        string BDel = Convert.ToString(Session["BDel"]);
                        if (BDel == "1")
                        {
                            ViewGrid.Columns[30].Visible = true;
                        }
                        else
                        {
                            ViewGrid.Columns[30].Visible = false;
                        }
                    }

                }
                lblrecords.Text = "Records for the category of " + category + " are";
                ViewGrid.Visible = true;
            }
            else
            {
                lblrecords.Text = "<b>Records for the category of " + category + " are not found. </b>";
                ViewGrid.Visible = false;
            }
            Session["CatName"] = category;
            Session["Modulename"] = modulename;
            sqlConnection.Close();
    }
    /// <summary>
    /// Page redirection for clicking Home of admin control
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lnkbtnHome_Click(object sender, EventArgs e)
    {
        Response.Redirect("Admin_Home.aspx");
    }
    /// <summary>
    /// Page redirection for clicking Post Data of admin control
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lnkbtnPostData_Click(object sender, EventArgs e)
    {
        Response.Redirect("Admin_PostData.aspx");
    }
    /// <summary>
    /// Conditions while click on edit
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lnkBtnEditData(object sender, CommandEventArgs e)
    {        
        string Id = Convert.ToString(e.CommandArgument);
        DataSet ds1 = new DataSet();
        ds1 = data.getDesc(Id);
        if (!ds1.Tables[0].Rows.Count.Equals(0))
        {
            mod = ds1.Tables[0].Rows[0]["module"].ToString();
        }
        if (mod == "Movies")
        {
            Response.Redirect("Admin_ToEditCinemaHallDetails.aspx?chid=" + Id);
        }
        else
        {
            Response.Redirect("Admin_EditData.aspx?did=" + Id);
        }
    }
    protected void ViewGrid_ItemDataBound(object sender, DataGridItemEventArgs e)
    {
        Label lblId = (Label)e.Item.FindControl("lblDataId");
        Label lblMap = (Label)e.Item.FindControl("lblMap");
        if (lblId != null)
        {
            if (lblId.Text != "")
            {
                chid = Convert.ToInt32(lblId.Text.ToString());
                dsmap = obj.GetHallData(chid);
                if (!dsmap.Tables[0].Rows.Count.Equals(0))
                {
                    Map = dsmap.Tables[0].Rows[0]["map"].ToString();
                    if (Map != "")
                    {
                        lblMap.Text = "View & Edit";
                    }
                    else
                    {
                        lblMap.Text = "Save Map";
                    }
                }
            }
        }
    }
    protected void getcount()
    {
        con.Open();
        SqlDataAdapter da = new SqlDataAdapter("select count(*) as count from sitecount", con);
        DataSet ds = new DataSet();
        da.Fill(ds);
        lblcount.Text = ds.Tables[0].Rows[0]["count"].ToString();
    }

    protected void lnkBack_Click(object sender, EventArgs e)
    {
        if (Session["LoginId"] != null)
        {
            designation = Convert.ToString(Session["Designation"]);
            if (designation == "Admin")
            {
                Response.Redirect("Admin-MainPage.aspx");
            }
            else
            {
                Response.Redirect("Admin_Home.aspx");
            }
        }
    }
}
