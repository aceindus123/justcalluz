using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class admin_Admin_CSRView : System.Web.UI.Page
{   
    CSRCS obj = new CSRCS();
    DataSet ds = new DataSet();
    string csrId;
    string UserId;
    DataTable dt = new DataTable();
    DataSet dsphoto = new DataSet();
    PagedDataSource pds = new PagedDataSource();
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
        csrId = Convert.ToString(Request.QueryString["csrid"]);
        if (!Page.IsPostBack)
        {
            ds = obj.GetCSR_byId(csrId);
            if (!ds.Tables[0].Rows.Count.Equals(0))
            {
                dlCSR.DataSource = ds;
                dlCSR.DataBind();
            }
            //BindGallery();   
            dsphoto = obj.GetCSRImgById(csrId);
            if (!dsphoto.Tables[0].Rows.Count.Equals(0))
            {
                dlPhotos.DataSource = dsphoto;
                dlPhotos.DataBind();
            }
        }
    }
    public string GetDetail(object objEmplayeeId)
    {
        //int EmplayeeId = int.Parse(objEmplayeeId.ToString());
        string imgName = objEmplayeeId.ToString();
        string path = "../CSR_Photos/" + imgName;
        return path;        
    }

    public string title(object objEmployeeName)
    {
        string employeename = objEmployeeName.ToString();
        return employeename;
    }
    //public void BindGallery()
    //{
    //    dt = obj.GetCSRImg_ById(csrId);
    //    if (dt.Rows.Count > 0)
    //    {
    //        pds.DataSource = dt.DefaultView;
    //        pds.AllowPaging = true;
    //        pds.PageSize = 2;
    //        pds.CurrentPageIndex = CurrentPage;
    //        lnkbtnNext.Enabled = !pds.IsLastPage;
    //        lnkbtnPrevious.Enabled = !pds.IsFirstPage;
    //        dlPhotos.DataSource = pds;
    //        dlPhotos.DataBind();
    //    }
    //}
    ///// <summary>
    ///// To put current page status
    ///// </summary>
    //public int CurrentPage
    //{
    //    get
    //    {
    //        if (this.ViewState["CurrentPage"] == null)
    //            return 0;
    //        else
    //            return Convert.ToInt16(this.ViewState["CurrentPage"].ToString());
    //    }
    //    set
    //    {
    //        this.ViewState["CurrentPage"] = value;
    //    }
    //}
    
    ////protected void dlPaging_ItemCommand(object source, DataListCommandEventArgs e)
    ////{
    ////    if (e.CommandName.Equals("lnkbtnPaging"))
    ////    {
    ////        CurrentPage = Convert.ToInt16(e.CommandArgument.ToString());
    ////        BindGrid();
    ////        leftrestaurant(scname);
    ////        leftrestaurant(rname);
    ////        //BindGrid1();
    ////    }
    ////}
    ///// <summary>
    ///// Function to go prevoius page
    ///// </summary>
    ///// <param name="sender"></param>
    ///// <param name="e"></param>
    //protected void lnkbtnPrevious_Click1(object sender, EventArgs e)
    //{
    //    CurrentPage -= 1;
    //    BindGallery();        
    //    //BindGrid1();
    //}
    ///// <summary>
    ///// Function to go next page
    ///// </summary>
    ///// <param name="sender"></param>
    ///// <param name="e"></param>
    //protected void lnkbtnNext_Click1(object sender, EventArgs e)
    //{
    //    CurrentPage += 1;
    //    BindGallery();
    //    //BindGrid1();
    //}
    ///// <summary>
    ///// To change page size
    ///// </summary>
    ///// <param name="sender"></param>
    ///// <param name="e"></param>
    //protected void ddlPageSize_SelectedIndexChanged(object sender, EventArgs e)
    //{
    //    CurrentPage = 0;
    //    BindGallery();
    //    //BindGrid1();
    //}
}
