using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
/// <summary>
/// class to display media speak
/// </summary>
public partial class admin_Admin_Media : System.Web.UI.Page
{
    //declaration of variables and creation of object for class
    string Lang;
    string UserId;
    Int32 MedId;
    DataSet ds = new DataSet();
    MediaCS obj = new MediaCS();
    string MSEdit;
    string MSDel;
    Int32 id = 0;
    //making connection
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
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
        //Getting web admin permissions
        MSEdit = Convert.ToString(Session["MSEdit"]);
        MSDel = Convert.ToString(Session["MSDel"]);
        //loads the page without postbacking the values
        if (!Page.IsPostBack)
        {
            obj.FillLanguage(ddlLang);
            if (Request.QueryString["lang"] != null)
            {
                Lang = Convert.ToString(Request.QueryString["lang"]);
                ddlLang.SelectedValue = Lang;
            }
            else
            {                
                    Lang = "English";
                    ddlLang.SelectedValue = Lang;               
            }
           // GridVisibilityConditions();
            GetMedia(Lang);
        }
    }
    /// <summary>
    /// To get media data based on laguage
    /// </summary>
    /// <param name="language"></param>
    private void GetMedia(string language)
    {
        ds = obj.GetMedia(language);
        if (!ds.Tables[0].Rows.Count.Equals(0))
        {
            gdvMedia.DataSource = ds;
            gdvMedia.DataBind();
        }
    }
    /// <summary>
    /// executes whenever language selection is changed
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void ddlLang_SelectedIndexChanged(object sender, EventArgs e)
    {
        Lang = Convert.ToString(ddlLang.SelectedValue);
        GetMedia(Lang);
    }
    /// <summary>
    /// Click event to view ratings
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lnkGoToRatings(object sender, CommandEventArgs e)
    {
        MedId = Convert.ToInt32(e.CommandArgument.ToString());
        Response.Redirect("Admin_MediaRatings.aspx?msId=" + MedId);
    }
    /// <summary>
    /// Visibility conditions of grid columns based on web admin permissions
    /// </summary>
    public void GridVisibilityConditions()
    {
        if (MSEdit == "1")
        {
            btnVieworEdit.Enabled = true;
        }
        else
        {
            btnVieworEdit.Enabled = false;
        }
        if (MSDel == "1")
        {
            btnDelete.Enabled = true;
        }
        else
        {
            btnDelete.Enabled = false;
        }
    }
    protected void ViewDetails_Click(object sender, EventArgs e)
    {
        //for (int i = 0; i < gdvMedia.Rows.Count; i++)
        //{
        //    CheckBox cbox = (CheckBox)gdvMedia.Rows[i].FindControl("CheckBoxreq");
        //    Button btnview = (Button)sender;
        //    if (cbox.Checked)
        //    {

        //        id = Convert.ToInt32(gdvMedia.DataKeys[i].Values[0].ToString());
        //    }
        //}
        id = gridid();
        if (id != 0)
            Response.Redirect("Admin_MediaEdit.aspx?medid=" + id);
    }
    protected void lnkDelete_Click(object sender, EventArgs e)
    {
        id = gridid();
        if (id != 0)
            Response.Redirect("Admin_MediaDelete.aspx?cid=" + id);

    }
    public int gridid()
    {
        for (int i = 0; i < gdvMedia.Rows.Count; i++)
        {
            CheckBox cbox = (CheckBox)gdvMedia.Rows[i].FindControl("CheckBoxreq");
            if (cbox.Checked)
            {
                id = Convert.ToInt32(gdvMedia.DataKeys[i].Values[0].ToString());
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
