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
using System.Web.Routing;

public partial class Corporate_social : System.Web.UI.Page
{
    CSRCS obj1 = new CSRCS();
    DataSet ds = new DataSet();
    DataSet dsphotos = new DataSet();
    DataTable dtcmp = new DataTable();
    String[] keycolumns;
    InsertData obj = new InsertData();
    static string excep_page = "Corporate_social.aspx";
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            btnclose.Visible = false;
            if (!IsPostBack)
            {
                //pnlimage.Visible = false;
                ds = obj1.GetCSR();
                if (!ds.Tables[0].Rows.Count.Equals(0))
                {

                    dltitle.DataSource = ds;
                    dltitle.DataBind();
                    ds = obj1.GetCSR_byname("Education");
                    dsphotos = obj1.GetCSR_byname("Education");
                    dtcmp = ds.Tables[0];
                    keycolumns = new String[] { "Title" };
                    RemoveDuplicates(dtcmp, keycolumns);
                    dlCSR.DataSource = dtcmp;
                    dlCSR.DataBind();
                    Session["id"] = ds.Tables[0].Rows[0]["csrId"].ToString();
                    dlPhotos.DataSource = dsphotos;
                    dlPhotos.DataBind();
                }
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void getdata(object sender, CommandEventArgs e)
    {
        try
        {
            string name = e.CommandArgument.ToString();
            ds = obj1.GetCSR_byname(name);
            dsphotos = obj1.GetCSR_byname(name);
            dtcmp = ds.Tables[0];
            keycolumns = new String[] { "Title" };
            RemoveDuplicates(dtcmp, keycolumns);
            dlCSR.DataSource = dtcmp;
            dlCSR.DataBind();
            if (!ds.Tables[0].Rows.Count.Equals(0))
            {
                Session["id"] = ds.Tables[0].Rows[0]["csrId"].ToString();
                dlPhotos.DataSource = dsphotos;
                dlPhotos.DataBind();
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
        
    }
    protected void getimage(object sender, CommandEventArgs e)
    {
        try
        {
            btnclose.Visible = true;
            DataTable dtimg = new DataTable();
            int id = Convert.ToInt32(Session["id"].ToString());
            string image = e.CommandArgument.ToString();
            ds = obj1.GetImgName_specific(id);
            dtimg = ds.Tables[0];
            keycolumns = new String[] { "ImgName" };
            RemoveDuplicates(dtimg, keycolumns);
            dlspecific_img.Visible = true;
            dlspecific_img.DataSource = ds;
            dlspecific_img.DataBind();
            popupimage.Show();
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }

    }
   
    static private DataTable RemoveDuplicates(DataTable tbl, String[] keyColumns)
    {
        InsertData obj = new InsertData();
        int rowNdx = 0;
        try
        {
            while (rowNdx < tbl.Rows.Count - 1)
            {
                DataRow[] dups = FindDups(tbl, rowNdx, keyColumns);
                if (dups.Length > 0)
                {
                    foreach (DataRow dup in dups)
                    {
                        tbl.Rows.Remove(dup);
                    }
                }
                else
                {
                    rowNdx++;

                }
            }
        }
        catch (Exception ex)
        {
            Corporate_social objcorprate = new Corporate_social();
            obj.insert_exception(ex, excep_page);
            objcorprate.redirect("HttpErrorPage.aspx",false);
        }
        return tbl;
    }

    static private DataRow[] FindDups(DataTable tbl, int sourceNdx, String[] keyColumns)
    {
        InsertData obj = new InsertData();
        ArrayList retVal = new ArrayList();
        try
        {
            DataRow sourceRow = tbl.Rows[sourceNdx];
            for (int i = sourceNdx + 1; i < tbl.Rows.Count; i++)
            {
                DataRow targetRow = tbl.Rows[i];
                if (IsDup(sourceRow, targetRow, keyColumns))
                {
                    if (retVal.Count.Equals(0))
                        retVal.Add(sourceRow);
                    //retVal.Add(targetRow);
                }
            }
        }
        catch (Exception ex)
        {
            Corporate_social objcrs = new Corporate_social();
            obj.insert_exception(ex, excep_page);
           objcrs.redirect("HttpErrorPage.aspx",false);
        }
        return (DataRow[])retVal.ToArray(typeof(DataRow));
    }

    static private bool IsDup(DataRow sourceRow, DataRow targetRow, String[] keyColumns)
    {
        InsertData obj = new InsertData();
        bool retVal = true;
        try
        {
            foreach (String column in keyColumns)
            {
                if (sourceRow.Table.Columns.Contains(column))
                {
                    retVal = retVal && sourceRow[column].Equals(targetRow[column]);
                    if (!retVal) break;
                }
            }
        }
        catch (Exception ex)
        {
            Corporate_social objcorSocial = new Corporate_social();
            obj.insert_exception(ex, excep_page);
            objcorSocial.redirect("HttpErrorPage.aspx",false);
        }
        return retVal;
    }
    protected void dlspecific_img_PageIndexChanged(object source, DataGridPageChangedEventArgs e)
    {
        try
        {
            btnclose.Visible = true;
            this.dlspecific_img.CurrentPageIndex = e.NewPageIndex;
            int id = Convert.ToInt32(Session["id"].ToString());
            ds = obj1.GetImgName_specific(id);
            dlspecific_img.Visible = true;
            //DataView source=ds.Tables[0].DefaultView;
            this.dlspecific_img.DataSource = ds;
            this.dlspecific_img.DataBind();
            popupimage.Show();
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
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
