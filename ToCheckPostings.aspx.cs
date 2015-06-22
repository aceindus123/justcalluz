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
using System.Web.Routing;
/// <summary>
/// Class to check postings by user after log in into their account
/// </summary>
public partial class ToCheckPostings : System.Web.UI.Page
{
    //To make connection
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    DataSet ds = new DataSet();
    InsertData obj = new InsertData();
    string uid = string.Empty;
    static string excep_page = "ToCheckPostings.aspx";
    /// <summary>
    /// Executes Whenever Page Loads
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            // Page loads witout postbacking values
            if (!Page.IsPostBack)
            {
                if (Convert.ToString(Session["USERID"]) != "")
                {
                    ItemsGet();
                }
                else
                {
                    //redirect("signin.aspx",false);
                    Response.RedirectToRoute("usignin");
                }
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }

    }
    public void ItemsGet()
    {
        try
        {
            if (Convert.ToString(Session["USERID"]) != "")
            {
                string strname = string.Empty;
               
                   string uid1 = Convert.ToString(Page.RouteData.Values["id"]);
                    uid1 = uid1.Replace("-", "@");
                    uid1 = uid1.Replace("Dot", ".");
              
                    uid = Convert.ToString(Session["USERID"]);

                    if (Convert.ToString(Session["FreeListing"]) != "")
                    {
                        strname = Convert.ToString(Session["FreeListing"]);
                    }
                    else
                    {
                        strname = Convert.ToString(Page.RouteData.Values["cname"]);
                    }
                if (strname == null)
                {
                    cmdNext.Visible = false;
                    cmdPrev.Visible = false;
                    lblMsg.Visible = true;
                    lblMsg.Text = "Welcome to JustCalluz..! Select Your Postings To have a look";
                }
                else
                {
                    SqlConnection con1 = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
                    SqlDataAdapter da1 = new SqlDataAdapter("select * from ModulesData where module='" + strname + "' and UserLoginId='" + uid + "'", con1);
                    //da1.Fill(ds1, "data");
                   // con1.Open();
                    DataTable dt = new DataTable();
                    da1.Fill(dt);
                    DataSet ds1 = new DataSet();
                    da1.Fill(ds1);
                    DataView dtView = ds1.Tables[0].DefaultView;
                    if (ds1.Tables[0].Rows.Count != 0)
                    {
                       
                            string status = ds1.Tables[0].Rows[0]["ApprovedStatus"].ToString();
                            PagedDataSource objPds1 = new PagedDataSource();
                            dtView.Sort = "id DESC";
                            objPds1.AllowPaging = true;
                            objPds1.PageSize = 1;
                            objPds1.DataSource = dtView;
                            objPds1.CurrentPageIndex = CurrentPage;
                            lblCurrentPage.Text = "Page:" + (CurrentPage + 1).ToString() + " of " + objPds1.PageCount.ToString();
                            cmdPrev.Enabled = !objPds1.IsFirstPage;
                            cmdNext.Enabled = !objPds1.IsLastPage;
                            if (strname == "Category")
                            {
                                lblHeading1.Text = "Advertise With Us Listing";
                            }
                            else
                            {
                                lblHeading1.Text = "Free Listing";
                            }

                            dlData.DataSource = objPds1;
                            dlData.DataBind();
                    
                    }
                    else
                    {
                        lblMsg.Text = "No records found.";
                        cmdNext.Visible = false;
                        cmdPrev.Visible = false;
                    }
                    //con.Close();
                }
            }
            else
            {
                //redirect("signin.aspx",false);
                Response.RedirectToRoute("usignin");

            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    /// <summary>
    /// To get the current page status
    /// </summary>
    public int CurrentPage
    {
        get
        {
            // look for current page in ViewState
            object o = this.ViewState["_CurrentPage"];
            if (o == null)
                return 0; // default to showing the first page
            else
                return (int)o;
        }
        set
        {
            this.ViewState["_CurrentPage"] = value;
        }
    }
    /// <summary>
    /// To perform action when you click on the previous button
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void cmdPrev_Click(object sender, System.EventArgs e)
    {
        try
        {
            // Set viewstate variable to the previous page
            CurrentPage -= 1;
            // Reload control
            ItemsGet();
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    /// <summary>
    /// To perform action when you click on the Next button
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void cmdNext_Click(object sender, System.EventArgs e)
    {
        try
        {
            // Set viewstate variable to the next page
            CurrentPage += 1;
            // Reload control
            ItemsGet();
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    /// <summary>
    /// To update the listings
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lnkUpdate(object sender, CommandEventArgs e)
    {
        try
        {
            if (Convert.ToString(Session["USERID"]) != "")
            {
                int Id = Convert.ToInt32(e.CommandArgument.ToString());
                string strname = Convert.ToString(Page.RouteData.Values["cname"]);
                if (strname == "Category")
                {
                   // redirect("Advertise_Edit.aspx?DID=" + Id,false);
                    Response.RedirectToRoute("AdvertiseEdit", new { DID = Id });
                }
                else if (strname == "FreeListing")
                {
                   // redirect("FreeListing_Edit.aspx?DID=" + Id,false);
                    Response.RedirectToRoute("FreeListingEdit", new { did = Id });
                }
            }
            else
            {
                string strScript = "";
                strScript = "alert('Your session is expired. Please Relogin');location.replace('signin');";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "alertbox", strScript, true);
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void dlData_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        Label lblStatus = (Label)e.Item.FindControl("lblStatus");
        if (lblStatus != null)
        {
            try
            {
                string status = Convert.ToString(lblStatus.Text);

                if (status == "0")
                {
                    lblStatus.Text = "Thank you for posting! Please wait for the Approval";
                }
                else if (status == "1")
                {
                    lblStatus.Text = "Your data is Approved";
                }
                else if (status == "2")
                {
                    lblStatus.Text = "You entered violated data. Please update the data";
                }
                else if (status == "3")
                {
                    lblStatus.Text = "You have updated the data. So please wait for the approval";
                }
            }
            catch (Exception ex)
            {
                obj.insert_exception(ex, excep_page);
                Response.Redirect("HttpErrorPage.aspx");
            }
        }
        Label lblLandPh = (Label)e.Item.FindControl("lblPhNo");
        if (lblLandPh != null)
        {
            try
            {
                if (lblLandPh.Text != "")
                {
                    lblLandPh.Text = lblLandPh.Text;
                }
                else
                {
                    lblLandPh.Text = "Not Mentioned";
                    lblLandPh.ForeColor = System.Drawing.Color.Red;
                }
            }
            catch (Exception ex)
            {
                obj.insert_exception(ex, excep_page);
                Response.Redirect("HttpErrorPage.aspx");
            }
        }

        Label lblWeb = (Label)e.Item.FindControl("lblWebsite");
        if (lblWeb != null)
        {
            try
            {
                if (lblWeb.Text != "")
                {
                    lblWeb.Text = lblWeb.Text;
                }
                else
                {
                    lblWeb.Text = "Not Mentioned";
                    lblWeb.ForeColor = System.Drawing.Color.Red;
                }
            }
            catch (Exception ex)
            {
                obj.insert_exception(ex, excep_page);
                Response.Redirect("HttpErrorPage.aspx");
            }
        }
        Label lblLandMark = (Label)e.Item.FindControl("lblLandMark");
        if (lblLandMark != null)
        {
            try
            {
                if (lblLandMark.Text != "")
                {
                    lblLandMark.Text = lblLandMark.Text;
                }
                else
                {
                    lblLandMark.Text = "Not Mentioned";
                    lblLandMark.ForeColor = System.Drawing.Color.Red;
                }
            }
            catch (Exception ex)
            {
                obj.insert_exception(ex, excep_page);
                Response.Redirect("HttpErrorPage.aspx");
            }
        }
        Label lblfax = (Label)e.Item.FindControl("lblFax");
        if (lblfax != null)
        {
            try
            {
                if (lblfax.Text != "")
                {
                    lblfax.Text = lblfax.Text;
                }
                else
                {
                    lblfax.Text = "Not Mentioned";
                    lblfax.ForeColor = System.Drawing.Color.Red;
                }
            }
            catch (Exception ex)
            {
                obj.insert_exception(ex, excep_page);
                Response.Redirect("HttpErrorPage.aspx");
            }
        }
        Label lblBdesc = (Label)e.Item.FindControl("lblBdesc");
        if (lblBdesc != null)
        {
            try
            {
                if (lblBdesc.Text != "")
                {
                    lblBdesc.Text = lblBdesc.Text;
                }
                else
                {
                    lblBdesc.Text = "Not Mentioned";
                    lblBdesc.ForeColor = System.Drawing.Color.Red;
                }
            }
            catch (Exception ex)
            {
                obj.insert_exception(ex, excep_page);
                Response.Redirect("HttpErrorPage.aspx");
            }
        }

    }
    public void redirect(string url, bool val)
    {
        if (!val)
        {
            HttpContext.Current.Response.Redirect(url, false);
            HttpContext.Current.ApplicationInstance.CompleteRequest();
        }
        else
        {
            HttpContext.Current.Server.ClearError();
            HttpContext.Current.Response.Redirect(url, false);
            HttpContext.Current.Server.ClearError();
        }

    }
}
