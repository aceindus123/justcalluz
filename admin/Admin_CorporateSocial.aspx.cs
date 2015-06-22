using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.HtmlControls;
public partial class admin_Admin_CorporateSocial : System.Web.UI.Page
{
    CSRCS obj = new CSRCS();
    DataSet ds = new DataSet();
    string UserId;
    string strScript;
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
        ds = obj.GetCSR();
        if (!ds.Tables[0].Rows.Count.Equals(0))
        {
            dlCSR.DataSource = ds;
            dlCSR.DataBind();
        }
    }
    protected void lnBtnDeleteCSR(object sender, CommandEventArgs e)
    {
        Int32 Id = Convert.ToInt32(e.CommandArgument.ToString());
        bool r;
        r = obj.CSRDelete(Id);
        if (r == true)
        {
            strScript = "alert('CSR is deleted successfully.');location.replace('Admin_CorporateSocial.aspx');";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertbox", strScript, true);
        }
    }
    protected void dlCSR_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        HtmlImage img_edit = (HtmlImage)e.Item.FindControl("imgedit");
        ImageButton img_del = (ImageButton)e.Item.FindControl("imgbtnDelete");
        if (Convert.ToInt32(Session["CSREdit"].ToString()) == 1)
        {
            img_edit.Visible = true;
        }
        else
        {
            img_edit.Visible = false;
        }
        if (Convert.ToInt32(Session["CSRDel"].ToString()) == 1)
        {
            img_del.Visible = true;
        }
        else
        {
            img_del.Visible = false;
        }
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
