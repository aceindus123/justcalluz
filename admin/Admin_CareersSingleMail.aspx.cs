using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using CallUsCareers.career;

public partial class admin_Admin_CareersSingleMail : System.Web.UI.Page
{
    DataSet ds = new DataSet();
    Binddata obj = new Binddata();
    Int16 Id;
    string fname;
    string lname;
    protected void Page_Load(object sender, EventArgs e)
    {
        Id = Convert.ToInt16(Request.QueryString["id"].ToString());
        fname = Convert.ToString(Request.QueryString["fname"]);
        lname = Convert.ToString(Request.QueryString["lname"]);
        lblname.Text = fname + " " + lname;
        GetRelatedJobs();
    }
    public void GetRelatedJobs()
    {
        ds = obj.bindAdminCareersDetais(Id);
        dlViewJobs.DataSource = ds;
        dlViewJobs.DataBind();
    }
}
