using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Globalization;
using JustCallUsData.Data;
using System.Web.UI.HtmlControls;

public partial class admin_Admin_SuccessStories : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    DataSet ds = new DataSet();
    SSCS obj = new SSCS();
    DataCS data = new DataCS();
    string Type;
    string state;
    string city;
    string UserId;
    public string swfFileName;
    PagedDataSource objPds = new PagedDataSource();
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
        
        Type = Convert.ToString(Request.QueryString["Type"]);
        state = Convert.ToString(Request.QueryString["s"]);
        city = Convert.ToString(Request.QueryString["c"]);
        if (!Page.IsPostBack)
        {
            binddatatables();
        } 
       
    }

    void binddatatables()
    {
        data.FillStates(ddlState);
        if (state != null && city != null)
        {
            ddlState.SelectedValue = state;
            fillCities(state);
            try
            {
                ddlCity.SelectedValue = city;
            }
            catch { }
            ds = obj.GetSS_byCity(city, Type);
            if (!ds.Tables[0].Rows.Count.Equals(0))
            {
                objPds.DataSource = ds.Tables[0].DefaultView;
                objPds.AllowPaging = true;
                objPds.PageSize = 2;
                objPds.CurrentPageIndex = CurrentPage;
                lblCurrentPage.Text = "Page: " + (CurrentPage + 1).ToString() + " of " + objPds.PageCount.ToString();
                // Disable Prev or Next buttons if necessary
                cmdPrev.Enabled = !objPds.IsFirstPage;
                cmdNext.Enabled = !objPds.IsLastPage;
              
              
                if (Type == "SSText")
                {
                    dlSS.DataKeyField = "ssId";
                    dlSS.DataSource = objPds;
                    dlSS.DataBind();
                    trwplayVideos.Visible = false;
                    // lnkBack.Visible = true;
                    anhBack.Visible = false;
                }
                else if (Type == "SSVideo")
                {
                    dlSSVideos.DataKeyField = "ssId";
                    dlSSVideos.DataSource = objPds;
                    dlSSVideos.DataBind();
                    trwplayVideos.Visible = true;
                    lnkBack.Visible = false;
                }
            }
            else
            {
                trnextpre.Visible = false;
            }
        }
        else
        {
           
        }
    }
    protected void cmdPrev_Click(object sender, EventArgs e)
    {
        CurrentPage -= 1;
        binddatatables();
    }
    /// <summary>
    /// To go next page
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void cmdNext_Click(object sender, EventArgs e)
    {
        CurrentPage += 1;
        binddatatables();
    }
    /// <summary>
    /// To get the current page status
    /// </summary>
    public int CurrentPage
    {
        get
        {
            object o = this.ViewState["_CurrentPage"];
            if (o == null)
                return 0;
            else
                return (int)o;
        }
        set
        {
            this.ViewState["_CurrentPage"] = value;
        }
    }
    protected void ddlCity_SelectedIndexChanged(object sender, EventArgs e)
    {
        city = Convert.ToString(ddlCity.SelectedValue);
        ds = obj.GetSS_byCity(city, Type);
        if (!ds.Tables[0].Rows.Count.Equals(0))
        {
            if (Type == "SSText")
            {
                dlSS.DataSource = ds;
                dlSS.DataBind();
                trwplayVideos.Visible = false;
            }
            else if (Type == "SSVideo")
            {
                dlSSVideos.DataSource = ds;
                dlSSVideos.DataBind();
                trwplayVideos.Visible = true;
            }
        }
    }
    protected void ddlState_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlState.SelectedIndex != 0)
        {
            string State_Name = Convert.ToString(ddlState.SelectedValue);
            fillCities(State_Name);
        }
        else
        {
            ddlCity.Items.Clear();
            ddlCity.Items.Insert(0, "Select City");
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
    
    protected void dlSS_ItemCommand(object source, DataListCommandEventArgs e)
    {
        
        LinkButton lnkBtnMore = (LinkButton)e.Item.FindControl("lnkBtnMore");
        Label lblpspeakMore = (Label)e.Item.FindControl("lblpspeakMore");
        Label lblpspeakmin = (Label)e.Item.FindControl("lblpspeakmin"); 
        
        if (e.CommandName == "More")
        {
            lblpspeakMore.Visible = true;
            lblpspeakmin.Visible = false;
            lnkBtnMore.Visible = false;
        }
        else
        {
            lblpspeakMore.Visible = false;
            lblpspeakmin.Visible = true;
            lnkBtnMore.Visible = false;
        }
         
    }
    protected void dlSS_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        Int32 length = 0;
        LinkButton lnkBtnMoredata = (LinkButton)e.Item.FindControl("lnkBtnMore");
        Label lblLength = (Label)e.Item.FindControl("lblLength");
        HtmlTableCell tdedit_ss = (HtmlTableCell)e.Item.FindControl("tdedit");
        HtmlTableCell tddel_ss = (HtmlTableCell)e.Item.FindControl("tddel");
        if (lblLength != null)
        {
            length = Convert.ToInt32(lblLength.Text);
            if (length > 150)
            {
                lnkBtnMoredata.Visible = true;
            }
            else
            {
                lnkBtnMoredata.Visible = false;
            }
        }
        if (Convert.ToInt32(Session["SSEdit"].ToString()) == 1)
        {
            tdedit_ss.Visible = true;
        }
        else
        {
            tdedit_ss.Visible = false; ;
        }
        if (Convert.ToInt32(Session["SSDel"].ToString()) == 1)
        {
            tddel_ss.Visible = true;
        }
        else
        {
            tddel_ss.Visible = false;
        }
    }

    //protected void PlayVideo(object sender, CommandEventArgs e)
    //{
    //    string VideoName =e.CommandArgument.ToString();
    //    swfFileName = "SS_Videos/" + VideoName; 
    //}

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
