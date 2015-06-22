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
/// To update a particular career
/// </summary>
public partial class admin_Admin_CareersEdit : System.Web.UI.Page
{
    //Making connection
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    //Creating objects for classes
    DataCS data = new DataCS();
    CareersCS careers = new CareersCS();    
    Binddata obj = new Binddata();
    DataSet ds = new DataSet();
    //Declaration of variables
    Int16 id;
    bool allCareers = false;
    string strScript;
    string UserId;
    string JTitle;
    string Cat;
    string SubCat;
    string JType;
    string JStatus;
    string Exp;
    string ExpMax;
    string ExpMin;       
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
    string Expirydate;
    string JExpiry;
    DateTime JobExpiry;
    string mob_no = string.Empty;
    char[] separatorspace = new char[] { ' ' };
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
        // Giving max, min values and error messages to Range validators 
        rangeValJobExpire.MinimumValue = System.DateTime.Now.ToShortDateString();
        rangeValJobExpire.MaximumValue = System.DateTime.Now.AddDays(90).ToShortDateString();
        rangeValJobExpire.ErrorMessage = " Please select " + System.DateTime.Now.ToShortDateString() + " Onwards and till " + System.DateTime.Now.AddDays(90).ToShortDateString();
        // loads the page without postbacking the values
        if (!IsPostBack)
        {
            // Filling states,category,education,max exp,min exp, job type, job status dropdown lists
            data.FillStates(ddlState);
            careers.FillCareers_Category(ddlCategory);
            careers.FillCareers_Education(ddlEducation);
            careers.FillCareers_ExpYr(ddlMax);
            careers.FillCareers_ExpYr(ddlMin);
            careers.FillCareers_JobType(ddlJobType);
            careers.FillCareers_AdminSalRange(ddlSal);
            //Open connection
            con.Open();
            //Getting careers id
            id = Convert.ToInt16(Request.QueryString["cid"].ToString());
            //Fill dataset
            ds = obj.bindAdminCareersDetais(id);
            //Check the data if it has values get the values and bound the with respective form fields
            if (!ds.Tables[0].Rows.Count.Equals(0))
            {
                JTitle = ds.Tables[0].Rows[0]["title"].ToString();
                Cat = ds.Tables[0].Rows[0]["category"].ToString();
                SubCat = ds.Tables[0].Rows[0]["specialization"].ToString();
                JType = ds.Tables[0].Rows[0]["jobType"].ToString();
                JStatus = ds.Tables[0].Rows[0]["jobStatus"].ToString();
                Exp = ds.Tables[0].Rows[0]["workExp"].ToString();
                Sal = ds.Tables[0].Rows[0]["salRange"].ToString();
                Vacancy = ds.Tables[0].Rows[0]["noOfvacancies"].ToString();
                Jdesc = ds.Tables[0].Rows[0]["jobDesc"].ToString();
                ComputerK = ds.Tables[0].Rows[0]["computerknowledge"].ToString();
                Qualification = ds.Tables[0].Rows[0]["qualification"].ToString();
                Add1 = ds.Tables[0].Rows[0]["comp_address1"].ToString();
                Add2 = ds.Tables[0].Rows[0]["comp_address2"].ToString();
                City = ds.Tables[0].Rows[0]["comp_city"].ToString();
                State = ds.Tables[0].Rows[0]["comp_state"].ToString();
                Zip = ds.Tables[0].Rows[0]["comp_pincode"].ToString();
                ContName = ds.Tables[0].Rows[0]["contpersonName"].ToString();
                ContEmail = ds.Tables[0].Rows[0]["cont_email"].ToString();
                string Mob = ds.Tables[0].Rows[0]["cont_phone"].ToString();
                string mobile = Mob.Substring(0, 1);
                if (mobile == "+")
                {
                    mob_no = Mob.Substring(3, 10);
                }
                else if (mobile == "-")
                {
                    mob_no = Mob.Substring(1, 10);
                }
                ContPh = mob_no;
                ContPhExtn = ds.Tables[0].Rows[0]["cont_ext"].ToString();
                Expirydate = ds.Tables[0].Rows[0]["expire_date"].ToString();
                DateTime Expiry = Convert.ToDateTime(Expirydate);
                string format="MM/dd/yyyy";     
                // Converting format of date
                JExpiry = Expiry.ToString(format);
                // Splitting the string according to space
                string[] ExpArr = Exp.Split(separatorspace);
                ExpMin = ExpArr[0];
                ExpMax = ExpArr[1];
                txtJTitle.Text = JTitle;
                //To bind the categegory value from database to dropdownlist
                for (int i = 0; i < ddlCategory.Items.Count; i++)
                {
                    if (ddlCategory.Items[i].Value == Cat.ToString())
                    {
                        ddlCategory.SelectedValue = ddlCategory.Items[i].Value;
                        break;
                    }
                }
                fillSubCategories(Cat);
                // To bind the sub categegory value from database to dropdownlist
                for (int i = 0; i < ddlSubCat.Items.Count; i++)
                {
                    if (ddlSubCat.Items[i].Value == SubCat.ToString())
                    {
                        ddlSubCat.SelectedValue = ddlSubCat.Items[i].Value;
                        break;
                    }
                    else
                    {
                        ddlSubCat.SelectedIndex = 0;
                    }
                }
                //To bind Job Type from database
                for (int i = 0; i < ddlJobType.Items.Count; i++)
                {
                    if (ddlJobType.Items[i].Value == JType.ToString())
                    {
                        ddlJobType.SelectedValue = ddlJobType.Items[i].Value;
                        break;
                    }
                }
                //To bind Job Status from database
                for (int i = 0; i < ddlJobStatus.Items.Count; i++)
                {
                    if (ddlJobStatus.Items[i].Value == JStatus.ToString())
                    {
                        ddlJobStatus.SelectedValue = ddlJobStatus.Items[i].Value;
                        break;
                    }
                }
                //To bind Minimum Experience from database
                for (int i = 0; i < ddlMin.Items.Count; i++)
                {
                    if (ddlMin.Items[i].Value == ExpMin.ToString())
                    {
                        ddlMin.SelectedValue = ddlMin.Items[i].Value;
                        break;
                    }
                }
                //To bind Maximum Experience from database
                for (int i = 0; i < ddlMax.Items.Count; i++)
                {
                    if (ddlMax.Items[i].Value == ExpMax.ToString())
                    {
                        ddlMax.SelectedValue = ddlMax.Items[i].Value;
                        break;
                    }
                }
                //To bind Salary Range from database
                for (int i = 0; i < ddlSal.Items.Count; i++)
                {
                    if (ddlSal.Items[i].Value == Sal.ToString())
                    {
                        ddlSal.SelectedValue = ddlSal.Items[i].Value;
                        break;
                    }
                }
                txtPositions.Text = Vacancy;
                txtJobDesc.Text = Jdesc;
                txtComputerK.Text = ComputerK;
                //To bind Basic Education from database
                for (int i = 0; i < ddlEducation.Items.Count; i++)
                {
                    if (ddlEducation.Items[i].Value == Qualification.ToString())
                    {
                        ddlEducation.SelectedValue = ddlEducation.Items[i].Value;
                        break;
                    }
                }
                txtAddress1.Text = Add1;
                txtAddress2.Text = Add2;
                // To bound database state value to the State Dropdown list
                for (int i = 0; i < ddlState.Items.Count; i++)
                {
                    if (ddlState.Items[i].Value == State.ToString())
                    {
                        ddlState.SelectedValue = ddlState.Items[i].Value;
                        break;
                    }
                }
                //Calling function To fill cities
                fillCities(State);
                // To bound database city value to the city Dropdown list
                for (int i = 0; i < ddlCity.Items.Count; i++)
                {
                    if (ddlCity.Items[i].Value == City.ToString())
                    {
                        ddlCity.SelectedValue = ddlCity.Items[i].Value;
                        break;
                    }
                    else
                    {
                        ddlCity.SelectedIndex = 0;
                    }
                }
                txtZip.Text = Zip;
                txtContName.Text = ContName;
                txtEmail.Text = ContEmail;
                txtPh.Text = ContPh;
                txtExtn.Text = ContPhExtn;
                txtJobExpiryDate.Text = JExpiry;
            }
            con.Close();  
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
    /// Execute whenever we change category
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
    /// Updating a particular career
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void ImgBtnSubmit_Click(object sender, ImageClickEventArgs e)
    {
        id = Convert.ToInt16(Request.QueryString["cid"].ToString());
        JTitle = Convert.ToString(txtJTitle.Text);
        Cat = Convert.ToString(ddlCategory.SelectedValue);
        SubCat = Convert.ToString(ddlSubCat.SelectedValue);
        JType = Convert.ToString(ddlJobType.SelectedValue);
        JStatus = Convert.ToString(ddlJobStatus.SelectedValue);
        ExpMax = Convert.ToString(ddlMax.SelectedValue);
        ExpMin = Convert.ToString(ddlMin.SelectedValue);
        Exp = ExpMin + " to " + ExpMax + " years";
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
        Expirydate=Convert.ToString(txtJobExpiryDate.Text);
        JobExpiry=Convert.ToDateTime(Expirydate);      
        careers.cC_Title = JTitle;
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
        careers.cExpDate = JobExpiry;
        careers.jobid=id;
        //open connection
        con.Open();
        //To update a particular career
        allCareers = careers.CareersUpdate(careers.cC_Title, careers.Category, careers.Specialization,
                   careers.jobtype, careers.cC_JStatus, careers.cC_JDesc, careers.exp_years, careers.current_ctc,
                   careers.cC_NoVac, careers.cC_CompKnow, careers.BasicEducation, careers.cC_add1, careers.cC_aad2, careers.cC_City,
                   careers.cC_State, careers.cC_Zip, careers.cC_ContName, careers.cC_ContEmail,
                   careers.cC_ContPhone, careers.cC_ContPhExtn, careers.cExpDate,careers.jobid);
        //close connection
        con.Close();
        // alert if successfully career is updated
        if (allCareers == true)
        {           
            strScript = "alert('Career is Updated Successfully.');location.replace('Admin_Careers.aspx');";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
        }
    }
    protected void imbBtnCancel_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("Admin_Careers.aspx");
    }
}
