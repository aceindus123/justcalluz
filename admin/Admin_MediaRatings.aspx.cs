using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
/// <summary>
/// class to view media speak ratings
/// </summary>
public partial class admin_Admin_MediaRatings : System.Web.UI.Page
{
    //declaration of variables and creation of object for class
    Int32 MSId;
    DataSet ds = new DataSet();
    MediaCS obj = new MediaCS();
    string ATitle;
    Int32 MRId;
    Int32 t;
    string strScript;
    string Lang;
    string UserId;
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
        MSId = Convert.ToInt32(Request.QueryString["msId"].ToString());
        ds=obj.GetPerticularMedia(Convert.ToString(MSId));
        if(!ds.Tables[0].Rows.Count.Equals(0))
        {
            ATitle = ds.Tables[0].Rows[0]["Title"].ToString();
            Lang = ds.Tables[0].Rows[0]["LanguageSpeak"].ToString();
            lblHeading.Text = Title;
        }
        DataSet ds1 = new DataSet();
        ds1 = obj.GetMediaRating(MSId);
        if (!ds1.Tables[0].Rows.Count.Equals(0))
        {
            dlMediaRatings.DataSource = ds1;
            dlMediaRatings.DataBind();
        }
        else
        {
            lblNoDataFound.Text = "have No Ratings";
        }
    }
    /// <summary>
    /// event to delete media rating
    /// </summary>
    /// <param name="sendet"></param>
    /// <param name="e"></param>
    protected void lnkDelete(object sendet, CommandEventArgs e)
    {
        MRId = Convert.ToInt32(e.CommandArgument.ToString());
        t = obj.DeleteMediaRating(MRId);
        if (t == 1)
        {
            strScript = "alert('The record has been deleted successfully');location.replace('Admin_Media.aspx?lang="+Lang+"');";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertbox", strScript, true);
        }
    }
}
