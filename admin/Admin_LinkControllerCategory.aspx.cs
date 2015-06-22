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

/// <summary>
/// Class to display modules data
/// </summary>
public partial class admin_Admin_LinkController : System.Web.UI.Page
{
    string UserId;
    string Edit;
    string Delete;
    Int32 chid;
    DataSet dsmap = new DataSet();
    MoviesCS obj = new MoviesCS();
    string Map;
    string City;
    string State;
    string statement;
    string designation;
    DataCS data = new DataCS();
    int viewordeleteid;
    int result;
    int result1;
    string scatname = string.Empty;
    string catname = string.Empty;
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    /// <summary>
    /// code to display whenever page loads
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Page_Load(object sender, EventArgs e)
    {
        UserId = Convert.ToString(Session["LogInId"]);
        btnDelete.Visible = false;
        btnEdit.Visible = false;
        if (UserId != "")
        {
            // it will stays in the same page
        }

        else
        {
            //After login into the account it will go Post ad
            Response.Redirect("Default.aspx");

        }
        // loads the page without postbacking the values
        if (!IsPostBack)
        {
            data.FillStates(ddlState);
            ItemsGet();
            
        }
    }  
    /// <summary>
    /// For page change
    /// </summary>
    /// <param name="source"></param>
    /// <param name="e"></param>
    protected void ViewGrid_PageIndexChanging(object source, GridViewPageEventArgs e)
    {
        ViewGrid.PageIndex = e.NewPageIndex;
        ItemsGet();
    }
    /// <summary>
    ///  Function to get the data from database when we click on the link
    private void ItemsGet()
    {        
        City = ddlCity.SelectedValue;
        State = ddlState.SelectedValue;
        SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
        if (Request.QueryString["cat"] != null & Request.QueryString["mod"] != null)
        { 
       
            string modulename = Convert.ToString(Request.QueryString["mod"]);
             
            if (Request.QueryString["scat"] != null)
            {
                scatname = Convert.ToString(Request.QueryString["scat"]);
                catname = Convert.ToString(Request.QueryString["cat"]);
            }
            else
            {
                if (modulename == "Jobs")
                {
                    catname = Convert.ToString(Request.QueryString["cat"]);
                    scatname = catname;
                    catname = "Jobs";
                }
                else if (modulename == "Events")
                {
                    catname = Convert.ToString(Request.QueryString["cat"]);
                    scatname = catname;
                    catname = "Events";
                }
                else
                {
                    catname = Convert.ToString(Request.QueryString["cat"]);
                }
                //SqlDataAdapter sdasubcat = new SqlDataAdapter("select id,SubCategory from ModulesData where module='" + modulename + "' and Category='" + catname + "'", con);
                //DataSet datasetsubcate = new DataSet();
                //sdasubcat.Fill(datasetsubcate);
                //if (datasetsubcate.Tables[0].Rows.Count > 0)
                //{
                //    scatname = Convert.ToString(datasetsubcate.Tables[0].Rows[0]["SubCategory"]);
                //}
            }
           
            DataSet ds = new DataSet();
            con.Open();
            if (State != "Select State")
            {
                if (City != "Select City")
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
                                      "where (m.Category='" + catname + "' or m.SubCategory='" + catname + "') and m.module='" + modulename + "' and m.ApprovedStatus='1' and City='" + City + "' and State='" + State + "' " +
                                      "group by m.id,m.module,m.Category,m.SubCategory,m.State,m.City,m.company_name,m.job_industry,m.job_functional_area,m.job_exp,m.job_sal,m.job_desc,m.job_keyskills,m.company_profile," +
                                      "m.event_name,m.event_place,m.event_startdate,m.event_enddate,m.event_desc,m.event_time,m.address,m.land_mark,m.contact_person,m.emailid,m.mob,m.landphno,m.fax," +
                                      "m.postdate,m.expdate,m.job_role,m.job_Qualification,m.Other_SubCat,m.Area,m.evedi_DurationType,m.Job_ExpiryDate,m.Age,m.Website,m.UserLoginId,m.ApprovedStatus,m.Pincode,m.ImageName,m.ImageContentType,m.free_specifany,m.CatSub,m.map,m.Approved_map order by m.id desc";
                    lblrecords.Text = "Records for the category <b>" + catname + "</b> of module <b>" + modulename + "</b> in <b>" + City + "</b>, <b>"+State+"</b> are";
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
                                      "where (m.Category='" + catname + "' or m.SubCategory='" + catname + "') and m.module='" + modulename + "' and m.ApprovedStatus='1' and State='" + State + "' " +
                                      "group by m.id,m.module,m.Category,m.SubCategory,m.State,m.City,m.company_name,m.job_industry,m.job_functional_area,m.job_exp,m.job_sal,m.job_desc,m.job_keyskills,m.company_profile," +
                                      "m.event_name,m.event_place,m.event_startdate,m.event_enddate,m.event_desc,m.event_time,m.address,m.land_mark,m.contact_person,m.emailid,m.mob,m.landphno,m.fax," +
                                      "m.postdate,m.expdate,m.job_role,m.job_Qualification,m.Other_SubCat,m.Area,m.evedi_DurationType,m.Job_ExpiryDate,m.Age,m.Website,m.UserLoginId,m.ApprovedStatus,m.Pincode,m.ImageName,m.ImageContentType,m.free_specifany,m.CatSub,m.map,m.Approved_map order by m.id desc";
                    lblrecords.Text = "Records for the category <b>" + catname + "</b> of module <b>" + modulename + "</b> in <b>"+State+"</b> are";
                }
            }
            else
            {

                if (modulename == "Jobs")
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
                                       "where (m.Category='" + catname + "' and m.SubCategory='" + scatname + "') and m.module='" + modulename + "' and m.ApprovedStatus='1' " +
                                       "group by m.id,m.module,m.Category,m.SubCategory,m.State,m.City,m.company_name,m.job_industry,m.job_functional_area,m.job_exp,m.job_sal,m.job_desc,m.job_keyskills,m.company_profile," +
                                       "m.event_name,m.event_place,m.event_startdate,m.event_enddate,m.event_desc,m.event_time,m.address,m.land_mark,m.contact_person,m.emailid,m.mob,m.landphno,m.fax," +
                                       "m.postdate,m.expdate,m.job_role,m.job_Qualification,m.Other_SubCat,m.Area,m.evedi_DurationType,m.Job_ExpiryDate,m.Age,m.Website,m.UserLoginId,m.ApprovedStatus,m.Pincode,m.ImageName,m.ImageContentType,m.free_specifany,m.CatSub,m.map,m.Approved_map order by m.id desc";
                    lblrecords.Text = "Records for the category <b>" + scatname + "</b> of module <b>" + modulename + "</b> are";

                }
                else if (modulename == "Events")
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
                                       "where (m.Category='" + catname + "' and m.SubCategory='" + scatname + "') and m.module='" + modulename + "' and m.ApprovedStatus='1' " +
                                       "group by m.id,m.module,m.Category,m.SubCategory,m.State,m.City,m.company_name,m.job_industry,m.job_functional_area,m.job_exp,m.job_sal,m.job_desc,m.job_keyskills,m.company_profile," +
                                       "m.event_name,m.event_place,m.event_startdate,m.event_enddate,m.event_desc,m.event_time,m.address,m.land_mark,m.contact_person,m.emailid,m.mob,m.landphno,m.fax," +
                                       "m.postdate,m.expdate,m.job_role,m.job_Qualification,m.Other_SubCat,m.Area,m.evedi_DurationType,m.Job_ExpiryDate,m.Age,m.Website,m.UserLoginId,m.ApprovedStatus,m.Pincode,m.ImageName,m.ImageContentType,m.free_specifany,m.CatSub,m.map,m.Approved_map order by m.id desc";
                    lblrecords.Text = "Records for the category <b>" + scatname + "</b> of module <b>" + modulename + "</b> are";

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
                                       "where (m.Category='" + catname + "' or m.SubCategory='" + catname + "') and m.module='" + modulename + "' and m.ApprovedStatus='1' " +
                                       "group by m.id,m.module,m.Category,m.SubCategory,m.State,m.City,m.company_name,m.job_industry,m.job_functional_area,m.job_exp,m.job_sal,m.job_desc,m.job_keyskills,m.company_profile," +
                                       "m.event_name,m.event_place,m.event_startdate,m.event_enddate,m.event_desc,m.event_time,m.address,m.land_mark,m.contact_person,m.emailid,m.mob,m.landphno,m.fax," +
                                       "m.postdate,m.expdate,m.job_role,m.job_Qualification,m.Other_SubCat,m.Area,m.evedi_DurationType,m.Job_ExpiryDate,m.Age,m.Website,m.UserLoginId,m.ApprovedStatus,m.Pincode,m.ImageName,m.ImageContentType,m.free_specifany,m.CatSub,m.map,m.Approved_map order by m.id desc";
                    lblrecords.Text = "Records for the category <b>" + catname + "</b> of module <b>" + modulename + "</b> are";
                }
            }

            SqlDataAdapter imgtext= new SqlDataAdapter(statement, con);
            imgtext.Fill(ds, "categoryData");                     
            DataView dtView = ds.Tables[0].DefaultView;
            if (!ds.Tables[0].Rows.Count.Equals(0))
            {
                string mod = "";                
                mod = ds.Tables[0].Rows[0]["module"].ToString();                                
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {                    
                    ViewGrid.DataSource = ds;
                    ViewGrid.DataBind();
                    if (mod == "Category")
                    {
                       
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

                        //Enable or disable permissions to edit data
                        Edit = Convert.ToString(Session["BEdit"]);
                        if (Edit == "1")
                        {
                            btnEdit.Enabled = true;
                        }
                        else
                        {
                            btnEdit.Enabled = false;
                        }
                        //Enable or disable permissions to delete data
                        Delete = Convert.ToString(Session["BDel"]);
                        if (Delete == "1")
                        {
                            btnDelete.Enabled = true;
                        }
                        else
                        {
                            btnDelete.Enabled = false;
                        }
                   
                    }
                    else if (mod == "B2B Category")
                    {
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

                        //Enable or disable permissions to edit data
                        Edit = Convert.ToString(Session["B2BEdit"]);
                        if (Edit == "1")
                        {
                            btnEdit.Enabled = true;
                        }
                        else
                        {
                            btnEdit.Enabled = false;
                        }
                        //Enable or disable permissions to edit data
                        Delete = Convert.ToString(Session["B2BDel"]);
                        if (Delete == "1")
                        {
                            btnDelete.Enabled = true;
                        }
                        else
                        {
                            btnDelete.Enabled = false;
                        }
                       
                    }
                    else if (mod == "Jobs")
                    {
                        ViewGrid.Columns[2].Visible = false;
                        ViewGrid.Columns[3].Visible = false;
                        ViewGrid.Columns[4].Visible = false;
                        ViewGrid.Columns[7].Visible = false;
                        ViewGrid.Columns[8].Visible = false;
                        ViewGrid.Columns[9].Visible = false;
                        ViewGrid.Columns[10].Visible = false;
                        ViewGrid.Columns[11].Visible = false;
                        ViewGrid.Columns[12].Visible = false;
                        ViewGrid.Columns[16].Visible = false;
                        ViewGrid.Columns[18].Visible = false;

                        //Enable or disable permissions to edit data
                        Edit = Convert.ToString(Session["JobEdit"]);
                        if (Edit == "1")
                        {
                            btnEdit.Enabled = true;
                        }
                        else
                        {
                            btnEdit.Enabled = false;
                        }
                        //Enable or disable permissions to edit data
                        Delete = Convert.ToString(Session["JobDel"]);
                        if (Delete == "1")
                        {
                             btnDelete.Enabled = true;
                        }
                        else
                        {
                             btnDelete.Enabled = false;
                        }


                    }
                    else if (mod == "Events")
                    {
                        ViewGrid.Columns[1].Visible = false;
                        ViewGrid.Columns[2].Visible = false;
                        ViewGrid.Columns[3].Visible = false;
                        ViewGrid.Columns[4].Visible = false;
                        ViewGrid.Columns[5].Visible = false;
                        ViewGrid.Columns[6].Visible = false;
                        ViewGrid.Columns[7].Visible = false;
                        ViewGrid.Columns[8].Visible = false;                     
                        ViewGrid.Columns[12].Visible = false;
                        ViewGrid.Columns[16].Visible = false;
                        ViewGrid.Columns[17].Visible = false;
                        ViewGrid.Columns[18].Visible = false;

                        //Enable or disable permissions to edit data
                        Edit = Convert.ToString(Session["EveEdit"]);
                        if (Edit == "1")
                        {
                            btnEdit.Enabled = true;
                        }
                        else
                        {
                            btnEdit.Enabled = false;
                        }
                        //Enable or disable permissions to edit data
                        Delete = Convert.ToString(Session["EveDel"]);
                        if (Delete == "1")
                        {
                             btnDelete.Enabled = true;
                        }
                        else
                        {
                             btnDelete.Enabled = false;
                        }

                    }
                    else if (mod == "Discounts")
                    {
                      
                        ViewGrid.Columns[2].Visible = false;
                        ViewGrid.Columns[3].Visible = false;
                        ViewGrid.Columns[4].Visible = false;
                        ViewGrid.Columns[5].Visible = false;
                        ViewGrid.Columns[6].Visible = false;
                        ViewGrid.Columns[7].Visible = false;
                        ViewGrid.Columns[8].Visible = false;
                        ViewGrid.Columns[9].Visible = false;
                        ViewGrid.Columns[10].Visible = false;
                        ViewGrid.Columns[12].Visible = false;

                        //Enable or disable permissions to edit data
                        Edit = Convert.ToString(Session["DisEdit"]);
                        if (Edit == "1")
                        {
                            btnEdit.Enabled = true;
                        }
                        else
                        {
                            btnEdit.Enabled = false;
                        }
                        //Enable or disable permissions to edit data
                        Delete = Convert.ToString(Session["DisDel"]);
                        if (Delete == "1")
                        {
                             btnDelete.Enabled = true;
                        }
                        else
                        {
                             btnDelete.Enabled = false;
                        }
                   
 
                    }
                    else if (mod == "LifeStyle")
                    {
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

                        //Enable or disable permissions to edit data
                        Edit = Convert.ToString(Session["LSEdit"]);
                        if (Edit == "1")
                        {
                            btnEdit.Enabled = true;
                        }
                        else
                        {
                            btnEdit.Enabled = false;
                        }
                        //Enable or disable permissions to edit data
                        Delete = Convert.ToString(Session["LSDel"]);
                        if (Delete == "1")
                        {
                             btnDelete.Enabled = true;
                        }
                        else
                        {
                             btnDelete.Enabled = false;
                        }
                    }
                    else if (mod == "FreeListing")
                    {
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

                        ////Enable or disable permissions to edit data
                        Edit = Convert.ToString(Session["FLEdit"]);
                        if (Edit == "1")
                        {
                            btnEdit.Enabled = true;
                        }
                        else
                        {
                            btnEdit.Enabled = false;
                        }
                        //Enable or disable permissions to edit data
                        Delete = Convert.ToString(Session["FLDel"]);
                        if (Delete == "1")
                        {
                             btnDelete.Enabled = true;
                        }
                        else
                        {
                             btnDelete.Enabled = false;
                        }

                    }

                }
               
               ViewGrid.Visible = true;
               trFilter.Visible = true;
               trFilterHead.Visible = true;
               btnDelete.Visible = true;
               btnEdit.Visible = true;
            }
            else
            {
               lblrecords.Text="<b>Records for the category of " + catname + " in the " + modulename + " module are not found. </b>";
               ViewGrid.Visible = false;
               //trFilter.Visible = false;
               //trFilterHead.Visible = false;
               btnDelete.Visible = false;
               btnEdit.Visible = false;
            }
            Session["CatName"] = catname;
            Session["Modulename"] = modulename;
            con.Close();
        }
    }
    /// <summary>
    /// To go home page
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lnkbtnHome_Click(object sender, EventArgs e)
    {
        Response.Redirect("Admin_Home.aspx");
    }
    /// <summary>
    /// To post data
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lnkbtnPostData_Click(object sender, EventArgs e)
    {
        Response.Redirect("Admin_PostData.aspx");
    }
    /// <summary>
    /// Binding Gridview data dynamically
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void ViewGrid_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            Label lblId = (Label)e.Row.FindControl("lblDataId");
            Label lblMap = (Label)e.Row.FindControl("lblMap");
            Label lblsDate = (Label)e.Row.FindControl("lblsDate");
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
                if (lblsDate.Text != "")
                {
                    string startdate = DateTime.Parse(lblsDate.Text).ToString("MMM dd yyyy");
                    lblsDate.Text = startdate;
                }
            }
        }
    }
    protected void ddlState_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlState.SelectedIndex != 0)
        {
            string State_Name = Convert.ToString(ddlState.SelectedValue);
            fillCities(State_Name);
            ItemsGet();
        }
        else
        {
            ddlCity.Items.Clear();
            ddlCity.Items.Insert(0, "Select City");
            ItemsGet();
        }
    }
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
    protected void ddlCity_SelectedIndexChanged(object sender, EventArgs e)
    {
        ItemsGet();
    }
    protected void ViewDetails_Click(object sender, EventArgs e)
    {
        foreach (GridViewRow gvrow in ViewGrid.Rows)
        {
            CheckBox chk = (CheckBox)gvrow.FindControl("CheckBoxreq");
            if (chk != null & chk.Checked)
            {
                viewordeleteid = Convert.ToInt32(ViewGrid.DataKeys[gvrow.RowIndex].Value.ToString());
            }
        }
        Response.Redirect("Admin_EditData.aspx?did=" + viewordeleteid);
    }
    protected void lnkDelete_Click(object sender, EventArgs e)
    {
        string module = Convert.ToString(Session["Modulename"]);
        string category = Convert.ToString(Session["CatName"]);
        foreach (GridViewRow gvrow in ViewGrid.Rows)
        {
            CheckBox chk = (CheckBox)gvrow.FindControl("CheckBoxreq");
            if (chk != null & chk.Checked)
            {
                viewordeleteid = Convert.ToInt32(ViewGrid.DataKeys[gvrow.RowIndex].Value.ToString());
            }
        }
        string s3 = "select * from PostReview where dataid =" + viewordeleteid;
        SqlDataAdapter sda = new SqlDataAdapter(s3, con);
        DataSet dsfillid = new DataSet();
        sda.Fill(dsfillid);
        if (dsfillid.Tables[0].Rows.Count > 0)
        {
            con.Open();
            string s1 = "delete from PostReview where dataid =" + viewordeleteid;
            SqlCommand cmddelete1 = new SqlCommand(s1, con);
            result1 = Convert.ToInt32(cmddelete1.ExecuteNonQuery());
            con.Close();
            con.Open();
            string s = "delete from modulesdata where id =" + viewordeleteid;
            SqlCommand cmddelete = new SqlCommand(s, con);
            result = Convert.ToInt32(cmddelete.ExecuteNonQuery());
            con.Close();
        }
        else
        {
            con.Open();
            string s = "delete from modulesdata where id =" + viewordeleteid;
            SqlCommand cmddelete = new SqlCommand(s, con);
            result = Convert.ToInt32(cmddelete.ExecuteNonQuery());
            con.Close();
        }

        if (result1 == 1 && result == 1)
        {
            string strScript = "alert('Selected record deleted successfully');location.replace('Admin_LinkControllerCategory.aspx?cat=" + category + "&mod=" + module + "');";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);

        }
        else if (result == 1)
        {

            string strScript = "alert('Selected record deleted successfully');location.replace('Admin_LinkControllerCategory.aspx?cat=" + category + "&mod=" + module + "');";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
        }
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
