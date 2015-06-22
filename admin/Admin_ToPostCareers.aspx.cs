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
using CallUsCareers.career;
/// <summary>
/// class to post careers of justcalluz.com
/// </summary>
public partial class admin_ToPostCareers : System.Web.UI.Page
{
    //making connection
    SqlConnection con=new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    //declaration of variables and creation of objects for classes
    DataCS data = new DataCS();
    CareersCS careers = new CareersCS();
    bool allCareers = false;
    string strScript;
    string UserId;
    string Title;
    string Cat;
    string SubCat;
    string JType;
    string JStatus;
    string ExpMax;
    string ExpMin;
    string Exp;
    string Sal;
    string Vacancy;
    string Jdesc;
    string ComputerK;
    string Qualification;
    string Add1;
    string Add2;
    string City;
    string State;
    string Zip;
    string ContName;
    string ContEmail;
    string ContPh;
    string ContPhExtn;
    /// <summary>
    /// Executes whenever page loads
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Page_Load(object sender, EventArgs e)
    {
        UserId = Convert.ToString(Session["LogInId"]);
        if (UserId != "")
        {
            // it will stays in the same page
        }

        else
        {
            //After login into the account it will go Post ad
            Response.Redirect("Default.aspx");

        }
        //loads the page without postbacking the values
        if (!IsPostBack)
        {
            //fill states
            data.FillStates(ddlState);
            //fill categories
            careers.FillCareers_Category(ddlCategory);
            //fill education
            careers.FillCareers_Education(ddlEducation);
            //fill maximum experience in years
            //careers.FillCareers_ExpYr(ddlMax);
            //fill minimum experience in years
            careers.FillCareers_ExpYr(ddlMin);
            //fill type of the job
            careers.FillCareers_JobType(ddlJobType);
            //fill salary range
            careers.FillCareers_AdminSalRange(ddlSal);
        }
    }
    /// <summary>
    /// To fill the cities for the corresponding States
    /// </summary>
    /// <param name="StateName"></param>
    public void fillCities(string StateName)
    {
        try
        {
            string Connection = ConfigurationManager.AppSettings["ConnectionString"];
            SqlConnection oCon = new SqlConnection(Connection);
            string s = "select city_Id,city_name from Cities where state_name= '" + StateName + "'";
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
    /// Executes whenever state drop down selection changed
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
    /// Function to bind the categories for the respective module
    /// </summary>
    /// <param name="Module_Name"></param>
    public void fillSubCategories(string Cat_Name)
    {
        try
        {
            string Connection = ConfigurationManager.AppSettings["ConnectionString"];
            SqlConnection oCon = new SqlConnection(Connection);
            string s = "select * from Careers_SubCat where Cat= '" + Cat_Name + "'";
            SqlCommand cmd = new SqlCommand(s, oCon);
            oCon.Open();
            SqlDataAdapter da = new SqlDataAdapter(s, oCon);
            DataSet ds = new DataSet();
            da.Fill(ds, "Category");
            ddlSubCat.DataSource = ds.Tables["Category"];
            ddlSubCat.DataValueField = "SubCat";
            ddlSubCat.DataTextField = "SubCat";
            ddlSubCat.DataBind();
            ddlSubCat.Items.Insert(0, "----- Select -----");
            oCon.Close();
        }
        //To catch exception
        catch (Exception ex)
        {
            lblMessage.Text = ex.Message.ToString();
        }
    }
    /// <summary>
    /// executes whenever category selection is changed
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void ddlCategory_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlCategory.SelectedIndex != 0)
        {
            string Cat_Name = Convert.ToString(ddlCategory.SelectedValue);
            fillSubCategories(Cat_Name);
        }
        else
        {
            ddlSubCat.Items.Clear();
            ddlSubCat.Items.Insert(0, "----- Select -----");
        }
    }
    /// <summary>
    /// click event to post careers
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void ImgBtnSubmit_Click(object sender, ImageClickEventArgs e)
    {
         Title = Convert.ToString(txtJTitle.Text);
         Cat = Convert.ToString(ddlCategory.SelectedValue);
         SubCat = Convert.ToString(ddlSubCat.SelectedValue);
         JType = Convert.ToString(ddlJobType.SelectedValue);
         JStatus = Convert.ToString(ddlJobStatus.SelectedValue);
         ExpMax = Convert.ToString(ddlMax.SelectedValue);
         ExpMin = Convert.ToString(ddlMin.SelectedValue);
         if (ExpMax != "--Select--")
         {
             Exp = ExpMin + " to " + ExpMax + " years";
         }
         else
         {
             Exp = ExpMin + " years";
         }                  
         Sal = Convert.ToString(ddlSal.SelectedValue);
         Vacancy = Convert.ToString(txtPositions.Text);
         Jdesc = Convert.ToString(txtJobDesc.Text);
         ComputerK = Convert.ToString(txtComputerK.Text);
         Qualification = Convert.ToString(ddlEducation.SelectedValue);
         Add1=Convert.ToString(txtAddress1.Text);
         Add2 = Convert.ToString(txtAddress2.Text);
         City = Convert.ToString(ddlCity.SelectedValue);
         State = Convert.ToString(ddlState.SelectedValue);
         Zip = Convert.ToString(txtZip.Text);
         ContName = Convert.ToString(txtContName.Text);
         ContEmail = Convert.ToString(txtEmail.Text);
         ContPh = Convert.ToString(txtcode.Text + txtPh.Text);
         ContPhExtn = Convert.ToString(txtExtn.Text);
        string getdate = "select PostDate=DATEADD(mi,750,GETDATE()), ExpDate=DATEADD(dd,"+txtJobExpiryDays.Text+",DATEADD(mi,750,GETDATE()))";
        con.Open();
        SqlDataAdapter ada = new SqlDataAdapter(getdate, con);
        DataSet ds = new DataSet();
        ada.Fill(ds);
        con.Close();
        if (!ds.Tables[0].Rows.Count.Equals(0))
        {
            DateTime PostDate = Convert.ToDateTime(ds.Tables[0].Rows[0]["PostDate"].ToString());
            DateTime ExpDate = Convert.ToDateTime(ds.Tables[0].Rows[0]["ExpDate"].ToString());
       
        careers.cC_Title = Title;
        careers.Category = Cat;
        careers.Specialization = SubCat;
        careers.jobtype = JType;
        careers.cC_JStatus = JStatus;
        careers.exp_years = Exp;
        careers.current_ctc = Sal;
        careers.cC_NoVac = Vacancy;
        careers.cC_JDesc = Jdesc;
        careers.cC_CompKnow = ComputerK;
        careers.BasicEducation = Qualification;
        careers.cC_add1 = Add1;
        careers.cC_aad2 = Add2;
        careers.cC_City = City;
        careers.cC_Zip = Zip;
        careers.cC_State = State;
        careers.cC_ContName = ContName;
        careers.cC_ContEmail = ContEmail;
        careers.cC_ContPhone = ContPh;
        careers.cC_ContPhExtn = ContPhExtn;
        careers.cPostDate = PostDate;
        careers.cExpDate = ExpDate;
        con.Open();
        allCareers = careers.CareersPost(careers.cC_Title, careers.Category, careers.Specialization,
                   careers.jobtype, careers.cC_JStatus, careers.cC_JDesc, careers.exp_years, careers.current_ctc,
                   careers.cC_NoVac, careers.cC_CompKnow, careers.BasicEducation, careers.cC_add1, careers.cC_aad2, careers.cC_City,
                   careers.cC_State, careers.cC_Zip, careers.cC_ContName, careers.cC_ContEmail,
                   careers.cC_ContPhone, careers.cC_ContPhExtn, careers.cPostDate, careers.cExpDate);
        con.Close();
       
        }
        strScript = "alert('New Career is Posted Successfully.');location.replace('Admin_Careers.aspx');";
        Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
    }
    protected void ddlMin_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlMin.SelectedIndex != 0)
        {
            ExpMin = Convert.ToString(ddlMin.SelectedValue);
            fillExpMax(ExpMin);
        }
        else
        {
            ddlSubCat.Items.Clear();
            ddlSubCat.Items.Insert(0, "----- Select -----");
        }
    }
    public void fillExpMax(string MinExp)
    {
        try
        {
            int minexperience = Convert.ToInt32(MinExp);
            string Connection = ConfigurationManager.AppSettings["ConnectionString"];
            SqlConnection oCon = new SqlConnection(Connection);
            string s = "select * from Careers_ExpYr where expyr>"+minexperience;
            SqlCommand cmd = new SqlCommand(s, oCon);
            oCon.Open();
            SqlDataAdapter da = new SqlDataAdapter(s, oCon);
            DataSet ds = new DataSet();
            da.Fill(ds, "MaxExp");
            //DlCities.SelectedIndex = 0;
            ddlMax.DataSource = ds.Tables["MaxExp"];
            ddlMax.DataValueField = "expyr";
            ddlMax.DataValueField = "expyr";
            ddlMax.DataTextField = "";
            ddlMax.DataBind();
            ddlMax.Items.Insert(0, "--Select--");
            oCon.Close();
        }
        catch (Exception ex)
        {
            lblMessage.Text = ex.Message.ToString();
        }
    }
}
