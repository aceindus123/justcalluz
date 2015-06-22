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
//using CallUsJobs.Jobs;
using System.Data.SqlClient;

public partial class admin_Admin_Jobs : System.Web.UI.Page
{
    bool Jobsdata = false;
    string UserId;
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
        if (!Page.IsPostBack)
        {
            //JobsCS jobs = new JobsCS();
            ////To bind Job Categories
            //jobs.FillJobCategories(ddlJobCat);
            txtexp.Visible = false;
            rfvtxtexp.Visible = false;
        }
    }
    public void fillJobSubCat(string CatName)
    {
        try
        {
            string Connection = ConfigurationManager.AppSettings["ConnectionString"];
            SqlConnection oCon = new SqlConnection(Connection);
            string s = "select sid,subcategory_name from JobSubCategories where category_name= '" + CatName + "'";
            SqlCommand cmd = new SqlCommand(s, oCon);
            oCon.Open();
            SqlDataAdapter da = new SqlDataAdapter(s, oCon);
            DataSet ds = new DataSet();
            da.Fill(ds, "SubCat");            
            ddlJobSubCat.DataSource = ds.Tables["SubCat"];
            ddlJobSubCat.DataValueField = "subcategory_name";
            ddlJobSubCat.DataTextField = "subcategory_name";
            ddlJobSubCat.DataBind();
            ddlJobSubCat.Items.Insert(0, "Select Job Sub Category");
            oCon.Close();
        }
        catch (Exception ex)
        {
            lblMessage.Text = ex.Message.ToString();
        }
    }
    protected void btnSubmitJobs_Click(object sender, EventArgs e)
    {
            string CompanyName = "";
            string IndustryName = "";
            string FunctionalArea = "";
            string Location = "";
            string Experience = "";
            string Salary = "";
            string JobDesc = "";
            string KeySkills = "";
            string CompanyProfile = "";
            string ContactPerson = "";
            string EmailId = "";
            string Phone = "";
            string Fax = "";
            string Cat = "";
            string SubCat = "";

            if (ddlExp.SelectedValue == "Experience")
            {
                Experience = Convert.ToString(txtexp.Text);
            }
            else
            {
                Experience = Convert.ToString(ddlExp.SelectedValue);
            }

            CompanyName = Convert.ToString(txtcompanyname.Text);
            IndustryName = Convert.ToString(txtIndName.Text);
            FunctionalArea = Convert.ToString(txtfunarea.Text);
            Location = Convert.ToString(txtLocation.Text);            
            Salary = Convert.ToString(txtSal.Text);
            JobDesc = Convert.ToString(txtJobDesc.Text);
            KeySkills = Convert.ToString(txtkeyskills.Text);
            CompanyProfile = Convert.ToString(txtCompProfile.Text);
            ContactPerson = Convert.ToString(txtContPerson.Text);
            EmailId = Convert.ToString(txtEmailId.Text);
            Phone = Convert.ToString(txtph.Text);
            Fax = Convert.ToString(txtFax.Text);
            Cat = Convert.ToString(ddlJobCat.SelectedValue);
            SubCat = Convert.ToString(ddlJobSubCat.SelectedValue);

            //JobsCS job = new JobsCS();
            //job.jCompany_Name = CompanyName;
            //job.jIndustry_Name = IndustryName;
            //job.jFun_Area = FunctionalArea;
            //job.jLoc = Location;
            //job.jExp = Experience;
            //job.jSal = Salary;
            //job.jJob_Desc = JobDesc;
            //job.jSkills = KeySkills;
            //job.jCompany_Profile = CompanyProfile;
            //job.jContact_Person = ContactPerson;
            //job.jEmail = EmailId;
            //job.jPhNumber = Phone;
            //job.jFaxNo = Fax;
            //job.jPostDate = DateTime.Now.Date;
            //job.jExpDate=(job.jPostDate.AddDays(Convert.ToDouble(30)));
            //job.jCategory = Cat;
            //job.jSubCategory = SubCat;

            //Jobsdata = job.Job_Insert(job.jCompany_Name, job.jIndustry_Name, job.jFun_Area, job.jLoc, job.jExp, job.jSal, job.jJob_Desc,
            //    job.jSkills, job.jCompany_Profile, job.jContact_Person, job.jEmail, job.jPhNumber, job.jFaxNo, job.jPostDate, job.jExpDate,job.jCategory,job.jSubCategory);
            string strScript = "";
            strScript = "alert('Job Posted Successfully.');";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
            txtcompanyname.Text = "";
            txtCompProfile.Text = "";
            txtContPerson.Text = "";
            txtEmailId.Text = "";
            txtexp.Text = "";
            txtFax.Text = "";
            txtfunarea.Text = "";
            txtIndName.Text = "";
            txtJobDesc.Text = "";
            txtkeyskills.Text = "";
            txtLocation.Text = "";
            txtph.Text = "";
            txtSal.Text = "";
            ddlExp.SelectedIndex = 0;
            ddlJobCat.SelectedIndex = 0;
            ddlJobSubCat.SelectedIndex = 0;
            
    }

    protected void  ddlExp_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlExp.SelectedValue == "Experience")
        {           
            txtexp.Visible = true;
            rfvtxtexp.Visible = true;
        }
        else
        {
            txtexp.Visible = false;
            rfvtxtexp.Visible = false;
        }
    }
    protected void ddlJobCat_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlJobCat.SelectedIndex != 0)
        {
            string JCat_Name = Convert.ToString(ddlJobCat.SelectedValue);
            fillJobSubCat(JCat_Name);
        }
        else
        {
            ddlJobSubCat.Items.Clear();
            ddlJobSubCat.Items.Insert(0, "Select Job Sub Category");
        }
    }
}
