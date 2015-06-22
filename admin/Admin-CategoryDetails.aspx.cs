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
using CallUsStatus.DataStatus;
using IndusAbroad.safeConvert;
using System.Net.Mail;
using System.Net;
using System.Net.Mime;
using JustCallUsData.Data;

/// <summary>
/// Class to display the data of hotels posted by the user from just call uz site.
/// </summary>
public partial class admin_Admin_CategoryDetails : System.Web.UI.Page
{
     string UserId;
    string strScript = "";
    string City;
    string State;
    string statement;
    DataCS data = new DataCS();
       int viewordeleteid;
    int result;
    int result1;
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    /// <summary>
    /// code to display whenever page loads
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
        // loads the page without refreshing
        if (!IsPostBack)
        {
            data.FillStates(ddlState);
            ItemsGet();
        }
       
    }
    /// <summary>
    /// For page change
    /// </summary>
    /// <param name="source"></param>
    /// <param name="e"></param>
    protected void ViewGrid_PageIndexChanging(object source, GridViewPageEventArgs e)
    {
        ViewGrid.PageIndex = e.NewPageIndex;
        ItemsGet();
    }
    /// <summary>
    ///  Function to get the data from database when we click on the link
    private void ItemsGet()
    {
        City = ddlCity.SelectedValue;
        State = ddlState.SelectedValue;
      
         
            DataSet ds = new DataSet();
            string con = ConfigurationManager.AppSettings["ConnectionString"];
            SqlConnection sqlConnection = new SqlConnection(con);
            sqlConnection.Open();
            if (Convert.ToString(Request.QueryString["cate"]) != null)
            {
                string Category = Convert.ToString(Request.QueryString["cate"]);
                if (Category == "Hotels")
                {
                    if (State != "Select State")
                    {
                        btnDelete.Visible = true;
                        btnView.Visible = true;

                        if (City != "Select City")
                        {
                            statement = "select * from modulesdata where (Category='5 Star Hotels' or Category='Luxury Restaurants' or Category='Hotels & Resorts' or Category='Restaurant & Pubs') and City='" + City + "' and ApprovedStatus=1 order by company_name ASC";
                        }
                        else
                        {
                            statement = statement = "select * from modulesdata where (Category='5 Star Hotels' or Category='Luxury Restaurants' or Category='Hotels & Resorts' or Category='Restaurant & Pubs') and ApprovedStatus=1 order by company_name ASC";
                        }
                    }
                    else
                    {
                        statement = "select * from modulesdata where (Category='5 Star Hotels' or Category='Luxury Restaurants' or Category='Hotels & Resorts' or Category='Restaurant & Pubs') and ApprovedStatus=1 order by company_name ASC";
                    }
                }
                else
                {
                    if (Category == "Builders")
                    {
                        
                    }
                    else if (Category == "Computers and Peripherals")
                    {
                        
                    }
                    else if (Category == "Education and Training")
                    {
                        
                    }
                    else if (Category == "Education and Training")
                    {
                       
                    }
                    else if (Category == "Travel Services")
                    {
                       
                    }
                    if (State != "Select State")
                    {
                        if (City != "Select City")
                        {
                            statement = "select *,stuff(\"company_name\", 22, len(company_name), '...') as compname from ModulesData where (Category=('" + Category + "') or company_name=('" + Category + "') or SubCategory=('" + Category + "')) and City='" + City + "' and ApprovedStatus='1' order by company_name ASC";
                        }
                        else
                        {
                            statement = statement = "select *,stuff(\"company_name\", 22, len(company_name), '...') as compname from ModulesData where (Category=('" + Category + "') or company_name=('" + Category + "') or SubCategory=('" + Category + "')) and ApprovedStatus='1' order by company_name ASC";
                        }
                    }
                    else
                    {
                        statement = "select *,stuff(\"company_name\", 22, len(company_name), '...') as compname from ModulesData where (Category=('" + Category + "') or company_name=('" + Category + "') or SubCategory=('" + Category + "')) and ApprovedStatus='1' order by company_name ASC";
                    }
                }

                SqlDataAdapter imgtext = new SqlDataAdapter(statement, sqlConnection);
                imgtext.Fill(ds, "categoryData");
                DataView dtView = ds.Tables[0].DefaultView;
                if (!ds.Tables[0].Rows.Count.Equals(0))
                {
                    string mod = "";
                    mod = ds.Tables[0].Rows[0]["Category"].ToString();
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        ViewGrid.Visible = true;
                        ViewGrid.DataSource = ds;
                        ViewGrid.DataBind();
                        lblCaterec.Text = "<b>Records for the module of " + Category + "</b>";

                    }
                }
                else
                {
                    lblrecords.Text = "<b>Records for the module of " + Category + " are not found</b>";
                    ViewGrid.Visible = false;
                    lblCaterec.Visible = false;
                    btnDelete.Visible = false;
                    btnView.Visible = false;
                }

                sqlConnection.Close();
            }
    }

    protected void ViewDetails_Click(object sender, EventArgs e)
    {
        foreach (GridViewRow gvrow in ViewGrid.Rows)
        {
            CheckBox chk = (CheckBox)gvrow.FindControl("CheckBoxreq");
            if (chk != null & chk.Checked)
            {
                viewordeleteid = Convert.ToInt32(ViewGrid.DataKeys[gvrow.RowIndex].Value.ToString());
            }
        }
        Response.Redirect("Admin_EditData.aspx?did=" + viewordeleteid);
    }
    protected void lnkDelete_Click(object sender, EventArgs e)
    {
        string module = Convert.ToString(Session["Modulename"]);
        string category = Convert.ToString(Session["CatName"]);
        foreach (GridViewRow gvrow in ViewGrid.Rows)
        {
            CheckBox chk = (CheckBox)gvrow.FindControl("CheckBoxreq");
            if (chk != null & chk.Checked)
            {
                viewordeleteid = Convert.ToInt32(ViewGrid.DataKeys[gvrow.RowIndex].Value.ToString());
            }
        }
       
        data.pId = viewordeleteid;
        bool t;
        t = data.Data_Delete(data.pId);
        if (t == true)
        {
            string Category = Convert.ToString(Request.QueryString["cate"]);
            strScript = "alert('Delete has been done successfully');location.replace('Admin-CategoryDetails.aspx?cate=" + Category + "');";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertbox", strScript, true);
        }

    }
    //protected void lnkDelete(object sender, CommandEventArgs e)
    //{
    //    int Id = Convert.ToInt32(e.CommandArgument.ToString());
    //    data.pId = Id;
    //    bool t;
    //    t = data.Data_Delete(data.pId);
    //    if (t == true)
    //    {
    //        strScript = "alert('Delete has been done successfully');location.replace('Admin-CategoryDetails.aspx')";
    //        Page.ClientScript.RegisterStartupScript(this.GetType(), "alertbox", strScript, true);
    //    }
    //}
    protected void ddlState_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlState.SelectedIndex != 0)
        {
            string State_Name = Convert.ToString(ddlState.SelectedValue);
            fillCities(State_Name);
            ItemsGet();
        }
        else
        {
            ddlCity.Items.Clear();
            ddlCity.Items.Insert(0, "Select City");
            ItemsGet();
        }
    }
    public void fillCities(string StateName)
    {
        try
        {
            string Connection = ConfigurationManager.AppSettings["ConnectionString"];
            SqlConnection oCon = new SqlConnection(Connection);
            string s = "select city_Id,city_name from Cities where state_name= '" + StateName + "' order by city_name";
            SqlCommand cmd = new SqlCommand(s, oCon);
            oCon.Open();
            SqlDataAdapter da = new SqlDataAdapter(s, oCon);
            DataSet ds = new DataSet();
            da.Fill(ds, "Cities");
            //DlCities.SelectedIndex = 0;

            ddlCity.DataSource = ds.Tables["Cities"];
            ddlCity.DataValueField = "city_name";
            ddlCity.DataTextField = "city_name";
            ddlCity.DataBind();
            ddlCity.Items.Insert(0, "Select City");
            oCon.Close();
        }
        catch (Exception ex)
        {
            lblMessage.Text = ex.Message.ToString();
        }
    }
    protected void ddlCity_SelectedIndexChanged(object sender, EventArgs e)
    {
        ItemsGet();
    }

    //protected void ViewGrid_ItemDataBound(object sender, DataGridItemEventArgs e)
    //{
    //    if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
    //    {
    //        //identifying the control in DataGrid
    //        LinkButton imgbtnDelete = (LinkButton)e.Item.FindControl("lnkBtnDelete");
    //        //raising javascript confirmationbox whenver user clicks on ImageButton
    //        imgbtnDelete.Attributes.Add("onclick", "javascript:return ConfirmationBox()");
    //    } 
    //}

}