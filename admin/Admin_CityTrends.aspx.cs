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
using JustCallUsData.Data;
using System.IO;
/// <summary>
/// To display city trends
/// </summary>
public partial class admin_Admin_CityTrends : System.Web.UI.Page
{
    //creation of objects and declaration of variables
    char[] separatorcomma = new char[] { ',' };
    string buslist;
    string UserId;
    string mod;
    string designation;
    DataCS data = new DataCS();
    DataSet ds = new DataSet();
    CityTrendsCS obj = new CityTrendsCS();
    string CTEdit;
    string CTDel;
    PagedDataSource pds = new PagedDataSource();
    SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
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
        //Getting Web admin permissions
        CTEdit = Convert.ToString(Session["CTEdit"]);
        CTDel = Convert.ToString(Session["CTDel"]);
        //loads the page without postbacking the values
        if (!IsPostBack)
        {
            // Fill dropdown list of city trends category
            data.FillCityTrends_Cat(ddlCat);
            if (Request.QueryString["mod"] !=null)
            {
                mod = Convert.ToString(Request.QueryString["mod"]);
                lblHeader.Text = mod;
                heading.Visible = true;
                //fill the categories and display the database value
                for (int i = 0; i < ddlCat.Items.Count; i++)
                {
                    if (ddlCat.Items[i].Value == mod.ToString())
                    {
                        ddlCat.SelectedValue = ddlCat.Items[i].Value;
                        break;
                    }
                }
                //calling function to bind city trends
                GetCT(mod);
            }            
        }
        
    }
    /// <summary>
    /// wherever category selection changed
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void ddlCat_SelectedIndexChanged(object sender, EventArgs e)
    {
        mod = ddlCat.SelectedValue;
        lblHeader.Text = mod;
        heading.Visible = true;
        GetCT(mod);
    }
    /// <summary>
    /// To bind city trends based on module
    /// </summary>
    /// <param name="Mod"></param>
    private void GetCT(string Mod)
    {
       
        connection.Open();
        ds = obj.GetCTrends(Mod);
        DataTable dt = ds.Tables[0];
        if (!ds.Tables[0].Rows.Count.Equals(0))
        {
            pds.DataSource = dt.DefaultView;
            pds.AllowPaging = true;
            pds.PageSize = 4;
            pds.CurrentPageIndex = CurrentPage;
            lblCurrentPage.Text = "Page: " + (CurrentPage + 1).ToString() + " of " + pds.PageCount.ToString();
            lnkbtnNext.Enabled = !pds.IsLastPage;
            lnkbtnPrevious.Enabled = !pds.IsFirstPage;
            dlCT.DataSource = pds;
            dlCT.DataBind();
            lnkbtnNext.Visible = true;
            lnkbtnPrevious.Visible = true;
            lblCurrentPage.Visible = true;          
        }
    }
    /// <summary>
    /// Binding fields of the datalist dynamically
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void dlCT_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        Label lblmod = (Label)e.Item.FindControl("lblmod");
        Label lblCtId = (Label)e.Item.FindControl("lblCtId");
        mod = lblmod.Text;
        HtmlTableRow trOther = (HtmlTableRow)e.Item.FindControl("trOther");
        HtmlTableRow trMovies = (HtmlTableRow)e.Item.FindControl("trMovies");
        HtmlTableRow trBusiness = (HtmlTableRow)e.Item.FindControl("trBusiness");
        Label lblBusList = (Label)e.Item.FindControl("lblBusList");
        HtmlTableCell tdMEdit = (HtmlTableCell)e.Item.FindControl("tdMEdit");
        HtmlTableCell tdOtherEdit = (HtmlTableCell)e.Item.FindControl("tdOtherEdit");
        HtmlTableCell tdBEdit = (HtmlTableCell)e.Item.FindControl("tdBEdit");
        HtmlTableCell tdDelete = (HtmlTableCell)e.Item.FindControl("tdDelete");
        Repeater rp1 = (Repeater)e.Item.FindControl("rptlist");                 
        if (lblBusList != null)
        {
            string Listing =Convert.ToString(lblBusList.Text);
            string[] strSplitArr = Listing.Split(separatorcomma);
            var strcount = from s in strSplitArr
                    select s;           
            DataTable dt = new DataTable();
            dt.Columns.Add("list");
            dt.Columns.Add("ctid");
            for (int i = 0; i < strSplitArr.Count(); i++)
            {
                dt.Rows.Add();
                dt.Rows[i]["list"] = strSplitArr[i].ToString();
                dt.Rows[i]["ctid"] = lblCtId.Text.ToString();
            }
            rp1.DataSource = dt;
            rp1.DataBind();
            int c = strcount.Count();
            if (c > 2)
            {
                buslist = strSplitArr[0] + "," + strSplitArr[1] + " & More";
                lblBusList.Text = buslist;
            }
            else
            {
                buslist = Listing.Remove(Listing.Length - 1, 1);
                lblBusList.Text = buslist;
            }                        
        }
        if (mod == "Businesses")
        {
            trBusiness.Visible = true;
            trOther.Visible = false;
            trMovies.Visible = false;
            if (CTEdit == "1")
            {
                tdBEdit.Visible = true;
            }
            else
            {
                tdBEdit.Visible = false;
            }
        }
        else if (mod == "Companies")
        {
            trBusiness.Visible = false;
            trOther.Visible = true;
            trMovies.Visible = false;
            if (CTEdit == "1")
            {
                tdOtherEdit.Visible = true;
            }
            else
            {
                tdOtherEdit.Visible = false;
            }
        }
        else if (mod == "Education")
        {
            trBusiness.Visible = false;
            trOther.Visible = true;
            trMovies.Visible = false;
            if (CTEdit == "1")
            {
                tdOtherEdit.Visible = true;
            }
            else
            {
                tdOtherEdit.Visible = false;
            }
        }
        else if (mod == "Health")
        {
            trBusiness.Visible = false;
            trOther.Visible = true;
            trMovies.Visible = false;
            if (CTEdit == "1")
            {
                tdOtherEdit.Visible = true;
            }
            else
            {
                tdOtherEdit.Visible = false;
            }
        }
        else if (mod == "Hotels & Restaurants")
        {
            trBusiness.Visible = false;
            trOther.Visible = true;
            trMovies.Visible = false;
            if (CTEdit == "1")
            {
                tdOtherEdit.Visible = true;
            }
            else
            {
                tdOtherEdit.Visible = false;
            }
        }
        else if (mod == "Tours and Travel")
        {
            trBusiness.Visible = false;
            trOther.Visible = true;
            trMovies.Visible = false;
            if (CTEdit == "1")
            {
                tdOtherEdit.Visible = true;
            }
            else
            {
                tdOtherEdit.Visible = false;
            }
        }
        else if (mod == "Movies")
        {
            trBusiness.Visible = false;
            trMovies.Visible = true;
            trOther.Visible = false;
            if (CTEdit == "1")
            {
                tdMEdit.Visible = true;
            }
            else
            {
                tdMEdit.Visible = false;
            }
        }
        if (CTDel == "1")
        {
            tdDelete.Visible = true;
        }
        else
        {
            tdDelete.Visible = false;
        }        
    }
    protected void lnkBack_Click(object sender, EventArgs e)
    {
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
    /// <summary>
    /// To put current page status
    /// </summary>
    public int CurrentPage
    {
        get
        {
            if (this.ViewState["CurrentPage"] == null)
                return 0;
            else
                return Convert.ToInt16(this.ViewState["CurrentPage"].ToString());
        }
        set
        {
            this.ViewState["CurrentPage"] = value;
        }
    }

    /// <summary>
    /// Function to go prevoius page
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lnkbtnPrevious_Click1(object sender, EventArgs e)
    {
        CurrentPage -= 1;
        mod = Convert.ToString(Request.QueryString["mod"]);
        GetCT(mod);
    }
    /// <summary>
    /// Function to go next page
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lnkbtnNext_Click1(object sender, EventArgs e)
    {
        mod = Convert.ToString(Request.QueryString["mod"]);
        CurrentPage += 1;
        GetCT(mod);
    }

}
