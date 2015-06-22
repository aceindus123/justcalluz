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
/// Class to display sponsored links
/// </summary>
public partial class admin_Admin_SponsoredLinks : System.Web.UI.Page
{
    SqlConnection con =new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    string UserId;
    Int32 id = 0;
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
        // Page loads without postbacking values
        if (!Page.IsPostBack)
        {
            BindSponsoredLinks();
        }

    }
    /// <summary>
    /// To bind sponsored links
    /// </summary>
    protected void BindSponsoredLinks()
    {
        con.Open();
        DataSet ds = new DataSet();
        Binddata obj = new Binddata();
        ds = obj.bindAdminSponsoredLinks();
        dgSponLiksHome.DataSource = ds;
        dgSponLiksHome.DataBind();
        if (Convert.ToInt32(Session["sp_lnkedit"]) == 1)
        {
            btnVieworEdit.Visible = true;
        }
        else
        {
            btnVieworEdit.Visible = false;
        }
        if (Convert.ToInt32(Session["sp_lnkdel"]) == 1)
        {
            btnDelete.Visible = true;
        }
        else
        {
            btnDelete.Visible = false;
        }
        con.Close();
    }
    protected void dgSponLiksHome_PageIndexChanged(object source, GridViewPageEventArgs e)
    {
        dgSponLiksHome.PageIndex = e.NewPageIndex;
        BindSponsoredLinks();
    }
    /// <summary>
    /// To edit sponsored links
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    //protected void imgBtnEdit_Click(Object sender,EventArgs e)
    //{
    //    ImageButton imgeBtnEdit=sender as ImageButton;
    //    Int32 sid1 = Convert.ToInt32(imgeBtnEdit.CommandArgument);
    //    Response.Redirect("Admin_SponsoredLinksEdit.aspx?Id=" + sid1);
    //}
    /// <summary>
    /// To delete sponsored links
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    //protected void imbBtndelete_Click(Object sender, EventArgs e)
    //{
    //    ImageButton imgBtnDel=sender as ImageButton;
    //    Int32 sid = Convert.ToInt32(imgBtnDel.CommandArgument);
    //    string str="Delete from sponseredlinks where id="+ sid;
    //    SqlCommand cmd=new SqlCommand(str,con);
    //    con.Open();
    //    cmd.ExecuteNonQuery();
    //    con.Close();
    //    BindSponsoredLinks();
    //    string stralertdel = "alert('You have successfully deleted the ad');";
    //    Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", stralertdel, true);
    //}
    /// <summary>
    /// To renew the sponsored links
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void imgBtnRenew_Click(Object sender, EventArgs e)
    {
        //ImageButton imgeBtnRenew = sender as ImageButton;
        //Int32 sid2 = Convert.ToInt32(imgeBtnRenew.CommandArgument);
        id = findcheck();
        if (id != 0)
            Response.Redirect("Admin_SponsoredLinksRenew.aspx?Id=" + id);
    }
    /// <summary>
    /// To post sponsered links
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lnkbtnPostsponslinks_Click(object sender, EventArgs e)
    {
        if (Convert.ToInt32(Session["sp_lnkpost"]) == 1)
        {
            Response.Redirect("Admin_ToPostSponsoredLinks.aspx");
        }
        else
        {
            string stralert = "alert('Sorry ! You don't have the permissions to post the ads');";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", stralert, true);
        }
    }
    protected void ViewDetails_Click(object sender, EventArgs e)
    {
        id = findcheck();
        if (id != 0)
            Response.Redirect("Admin_SponsoredLinksEdit.aspx?Id=" + id);
    }
    protected void lnkDelete_Click(object sender, EventArgs e)
    {
        id = findcheck();
        if (id != 0)
        {
            string str = "Delete from sponseredlinks where id=" + id;
            SqlCommand cmd = new SqlCommand(str, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            BindSponsoredLinks();
            string stralertdel = "alert('You have successfully deleted the sponser Ad');";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", stralertdel, true);
        }

    }

    public int findcheck()
    {
        for (int i = 0; i < dgSponLiksHome.Rows.Count; i++)
        {
            CheckBox cbox = (CheckBox)dgSponLiksHome.Rows[i].FindControl("CheckBoxreq");
            if (cbox.Checked)
            {
                id = Convert.ToInt32(dgSponLiksHome.DataKeys[i].Values[0].ToString());
            }
        }
        return id;
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
