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
/// <summary>
/// To display a particular career in detailes manner
/// </summary>
public partial class admin_Admin_CareersDetails : System.Web.UI.Page
{
    //To make connection
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    string UserId;
    /// <summary>
    /// Executes whenever page loads
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Page_Load(object sender, EventArgs e)
    {
        // Checking Status of Login
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
        // loads the page without postbacking the values
        if (!IsPostBack)
        {
            //get particular career id
            Int16 id = Convert.ToInt16(Request.QueryString["cjid"]);
            //create object
            DataSet ds = new DataSet();
            Binddata obj = new Binddata();
            //Open sql connection
            con.Open();
            //Fill dataset with a particulr career
            ds = obj.bindAdminCareersDetais(id);
            // Bind data list with a particular career values
            dlCareers.DataSource = ds;
            dlCareers.DataBind();
            //Close sql connection
            con.Close();

        }
    }
    /// <summary>
    /// To bind the available only data to the data list from database
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void dlCareers_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        // create a lable by finding control in datalist
        Label lblsalRange = (Label)e.Item.FindControl("lblsalRange");
        // according to this condition display of salary will change
        if (lblsalRange != null)
        {
            string salrange = Convert.ToString(lblsalRange.Text);
            if (salrange == "As per company policy")
            {
                lblsalRange.Text = salrange;
            }
            else
            {
                lblsalRange.Text = salrange + " CTC per annum";
            }
        }
            
    }
    /// <summary>
    /// To go previous page
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void imgBtnBack_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("Admin_Careers.aspx");
    }
}
