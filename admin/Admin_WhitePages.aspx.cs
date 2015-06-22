using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using JustCallUsData.Data;
public partial class admin_Admin_WhitePages : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    DataCS obj = new DataCS();
    DataSet ds = new DataSet();
    string UserId;
    int edit, delete;
    Int32 id = 0;
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
            ItemsGet();
        }
    }
    protected void ViewGrid_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        ViewGrid.PageIndex = e.NewPageIndex;
        ItemsGet();
    }
    private void ItemsGet()
    {
        //to open sql connection
        con.Open();
        //to fill dataset        
        ds = obj.BindAdmin_WP();
        DataView dtView = ds.Tables[0].DefaultView;
        //Condition to check dataset has files or not. If dataset has files it enters into if part or it enters into else part
        if (!ds.Tables[0].Rows.Count.Equals(0))
        {                       
            //Binding grid with database values
            ViewGrid.DataSource = ds;
            ViewGrid.DataBind();
            edit = Convert.ToInt32(Session["WPEdit"].ToString());
            if (edit == 1)
            {
                btnVieworEdit.Visible = true;
            }
            else
            {
                btnVieworEdit.Visible = false;
            }
            delete = Convert.ToInt32(Session["WPDel"].ToString());
            if (delete == 1)
            {
                btnDelete.Visible = true;
            }
            else
            {
                btnDelete.Visible = false;
            }
        }
        else
        {
            lblMessage.Text = "No White Pages to Display";
        }
        //to close connection
        con.Close();
    }
    protected void ViewDetails_Click(object sender, EventArgs e)
    {
        for (int i = 0; i < ViewGrid.Rows.Count; i++)
        {
            CheckBox cbox = (CheckBox)ViewGrid.Rows[i].FindControl("CheckBoxreq");
            Button btnview = (Button)sender;
            if (cbox.Checked)
            {

                id = Convert.ToInt32(ViewGrid.DataKeys[i].Values[0].ToString());
            }
        }
        if (id != 0)
            Response.Redirect("Admin_WhitePagesEdit.aspx?wpid=" + id);
    }
    protected void lnkDelete_Click(object sender, EventArgs e)
    {
        for (int i = 0; i < ViewGrid.Rows.Count; i++)
        {
            CheckBox cbox = (CheckBox)ViewGrid.Rows[i].FindControl("CheckBoxreq");
            if (cbox.Checked)
            {
                id = Convert.ToInt32(ViewGrid.DataKeys[i].Values[0].ToString());
            }
        }
        if (id != 0)
            Response.Redirect("Admin_DeleteWP.aspx?cid=" + id);
        
    }
    protected void lnkBack_Click(object sender, EventArgs e)
    {
        string designation;
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
