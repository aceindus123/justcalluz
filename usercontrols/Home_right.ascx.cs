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

public partial class usercontrols_Home_right : System.Web.UI.UserControl
{
    InsertData obj = new InsertData();
    PagedDataSource pds = new PagedDataSource();
    string strname = string.Empty;
    static string excep_page = "Home_right.ascx";
    SqlConnection sqlConnection =new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            try
            {
                BindReview();
            }
            catch (Exception ex)
            {
                obj.insert_exception(ex, excep_page);
                Response.Redirect("HttpErrorPage.aspx");
            }
        }
    }
    public void BindReview()
    {
        try
        {
            sqlConnection.Open();
            string Record_Count = string.Empty;
            Binddata obj = new Binddata();
            DataSet dsreview = new DataSet();
            dsreview = obj.bindreview();

            if (!dsreview.Tables[0].Rows.Count.Equals(0))
            {
                dlReview.DataKeyField = "rid";
                dlReview.DataSource = dsreview;
                dlReview.DataBind();
                if (dsreview.Tables[0].Rows.Count > 0)
                {
                    //Session["id"] = id;
                    pds.DataSource = dsreview.Tables[0].DefaultView;
                    pds.AllowPaging = true;
                    //pds.PageSize = Convert.ToInt16(ddlPageSize.SelectedValue);
                    pds.PageSize = 15;
                    if (dsreview.Tables[0].Rows.Count <= pds.PageSize)
                    {
                        pds.CurrentPageIndex = CurrentPage;
                        dlReview.DataSource = pds;
                        dlReview.DataBind();
                        //imgbtnSendMAIL.Visible = true;
                    }
                    else
                    {
                        paging.Visible = true;
                        pds.CurrentPageIndex = CurrentPage;
                        Next.Enabled = !pds.IsLastPage;
                        Prev.Enabled = !pds.IsFirstPage;
                        dlReview.DataSource = pds;
                        dlReview.DataBind();
                        //imgbtnSendMAIL.Visible = true;
                    }

                }
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
        
    }
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
    protected void Prev_Click(object sender, EventArgs e)
    {
        //try
        //{
            CurrentPage -= 1;
            //if (strname != "")
            {
                BindReview();
            }
           
         
        }
        //catch (Exception ex)
        //{
        //    obj.insert_exception(ex, excep_page);
        //    Response.Redirect("HttpErrorPage.aspx");
        //}
    //}
    protected void Next_Click(object sender, EventArgs e)
    {
        //try
        //{
        CurrentPage += 1;
        //if (strname != "")
        //{
        BindReview();
        //}


        //}
        //catch (Exception ex)
        //{
        //    obj.insert_exception(ex, excep_page);
        //    Response.Redirect("HttpErrorPage.aspx");
        //}
    }
    /// <summary>
    /// To bound review rating bound
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void dlReview_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        try
        {
            Label rating = (Label)e.Item.FindControl("lblrating");
            Label Rate = (Label)e.Item.FindControl("lblRate");
            int StarRating = Convert.ToInt32(Rate.Text);
            for (int i = 0; i < StarRating; i++)
            {
                rating.Text += "<img src=images/starorange.png>";

            }
            for (int j = StarRating; j < 5; j++)
            {
                rating.Text += "<img src=images/star_empty.png>";
            }
            Label name = (Label)e.Item.FindControl("lblRName");
            Label byname = (Label)e.Item.FindControl("lblbyName");
            if (name != null)
            {
                try
                {
                    string Rname = Convert.ToString(name.Text);
                    int length = Rname.Length;
                    if (length <= 7)
                    {
                        name.Visible = true;
                    }
                    else
                    {
                        if (byname != null)
                        {
                            byname.Visible = true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    obj.insert_exception(ex, excep_page);
                    Response.Redirect("HttpErrorPage.aspx");
                }
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
  
   
}
