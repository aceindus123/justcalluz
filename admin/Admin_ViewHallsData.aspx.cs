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
/// class to view cinema halls data in detailed manner
/// </summary>
public partial class admin_Admin_ViewHallsData : System.Web.UI.Page
{
    //making sql connection
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    //declaration of variables and creation of objects for classes
    MoviesCS obj = new MoviesCS();
    DataSet ds = new DataSet();
    string UserId;
    string strScripts;
    Int32 chid;
    string Map;
    int id = 0;
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

        //loads the page without postbacking the values
        if (!Page.IsPostBack)
        {
            ItemsGet();
        }
    }
    /// <summary>
    /// To get halls data
    /// </summary>
    private void ItemsGet()
    {
        ds = obj.GetData();
        if (!ds.Tables[0].Rows.Count.Equals(0))
        {
            dGridHalldata.DataSource = ds;
            dGridHalldata.DataBind();
            if (Convert.ToInt32(Session["MoviesEdit"].ToString()) == 1)
            {
                btnVieworEdit.Enabled = true;
            }
            else
            {
                btnVieworEdit.Enabled = false;
            }
            if (Convert.ToInt32(Session["MoviesDel"].ToString()) == 1)
            {
                 btnDelete.Enabled = true;
            }
            else
            {
                btnDelete.Enabled = false;
            }
        }
    }
    /// <summary>
    /// when page changed
    /// </summary>
    /// <param name="source"></param>
    /// <param name="e"></param>
    protected void dGridHalldata_PageIndexChanged(object source, GridViewPageEventArgs e)
    {
        dGridHalldata.PageIndex = e.NewPageIndex;
        ItemsGet();
    }
    /// <summary>
    /// Binding data dynamically
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void dGridHalldata_ItemDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            Label lblId = (Label)e.Row.FindControl("lblId");
            Label lblMap = (Label)e.Row.FindControl("lblMap");
            if (lblId != null)
            {
                if (lblId.Text != "")
                {
                    chid = Convert.ToInt32(lblId.Text.ToString());
                    ds = obj.GetHallData(chid);
                    if (!ds.Tables[0].Rows.Count.Equals(0))
                    {
                        Map = ds.Tables[0].Rows[0]["map"].ToString();
                        if (Map != "")
                        {
                            if (Convert.ToInt32(Session["MoviesEdit"].ToString()) == 1)
                            {
                                lblMap.Text = "View & Edit";
                            }
                            else
                            {
                                lblMap.Text = "";
                            }

                        }
                        else
                        {
                            if (Convert.ToInt32(Session["MoviesPost"].ToString()) == 1)
                            {
                                lblMap.Text = "Save Map";
                            }
                            else
                            {
                                lblMap.Text = "";
                            }
                        }
                    }
                }
            }
        }
       
        
    }
    protected void ViewDetails_Click(object sender, EventArgs e)
    {
        id = values();
        if (id != 0)
            Response.Redirect("Admin_ToEditCinemaHallDetails.aspx?chid=" + id);
    }
    protected void lnkDelete_Click(object sender, EventArgs e)
    {
        id = values();
        if (id != 0)
            Response.Redirect("Admin_DeleteData.aspx?cid=" + id);

    }
    public int values()
    {
        for (int i = 0; i < dGridHalldata.Rows.Count; i++)
        {
            CheckBox cbox = (CheckBox)dGridHalldata.Rows[i].FindControl("CheckBoxreq");
            if (cbox.Checked)
            {
                id = Convert.ToInt32(dGridHalldata.DataKeys[i].Values[0].ToString());
            }
        }
        return id;
    }
}
