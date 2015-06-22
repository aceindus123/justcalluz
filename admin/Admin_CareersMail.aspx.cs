using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using CallUsCareers.career;
public partial class admin_Admin_CareersMail : System.Web.UI.Page
{
    DataSet ds = new DataSet();
    CareersCS obj = new CareersCS();
    string cat;
    string fname;
    string lname;
    protected void Page_Load(object sender, EventArgs e)
    {
        cat = Convert.ToString(Request.QueryString["cat"]);
        fname = Convert.ToString(Request.QueryString["fname"]);
        lname = Convert.ToString(Request.QueryString["lname"]);
        lblname.Text = fname + " " + lname;
        GetRelatedJobs();
    }
    public void GetRelatedJobs()
    {
        ds = obj.GetRelatedJobsforCatDS(cat);
        dlViewRelatedJobs.DataSource = ds;
        dlViewRelatedJobs.DataBind();            
    }
}
