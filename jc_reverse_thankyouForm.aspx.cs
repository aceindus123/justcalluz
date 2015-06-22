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
using System.Collections.Generic;
using System.Net;
using System.Net.NetworkInformation;
using System.Web.Routing;
using JustCallUsData.Data;

public partial class jc_reverse_thankyouForm : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    InsertData obj = new InsertData();
    string City = string.Empty;
    string cate = string.Empty;
    string name = string.Empty;
    string mobilenum = string.Empty;
    char[] q_separator = new char[] { ',' };
    char[] z_separator = new char[] { '0' };
    DataSet dsRecords = new DataSet();
    DataSet dsRecords1 = new DataSet();
    DataSet dsRecords2 = new DataSet();
   
    DataCS obj1 = new DataCS();
    static string excep_page = "jc_reverse_thankyouForm.aspx";
    string strScript;
    DataSet dstotalrecords = new DataSet();
    string msgtxt = string.Empty;
    protected void Page_Load(object sender, EventArgs e)
    {
        
            cate = Convert.ToString(Page.RouteData.Values["cate"]).Trim();
            City = Convert.ToString(Page.RouteData.Values["city"]).Trim();
            name = Convert.ToString(Page.RouteData.Values["name"]).Trim();
            mobilenum = Convert.ToString(Page.RouteData.Values["mobile"]).Trim();

            lblName.Text = name;
            if (!IsPostBack)
            {
                if (Convert.ToString(Page.RouteData.Values["cate"]) != null)
                {
                    GetDlCateInfo();
                }               
            }      
    }
    private void GetDlCateInfo()
    {
        try
        {
            cate = Convert.ToString(Page.RouteData.Values["cate"]).Trim();
            City = Convert.ToString(Page.RouteData.Values["city"]).Trim();
           
            string[] catesplitstr = cate.Split(q_separator);

            if (catesplitstr[0] != "" && catesplitstr[1] != "" && catesplitstr[2] != "")
            {
                dsRecords = obj.bindJC_CmpDetails(catesplitstr[0], City);
                lblCategory.Text = catesplitstr[0];
                trCateRecords.Visible = true;
                DlCateRecords.DataSource = dsRecords;
                DlCateRecords.DataBind();
                dsRecords1 = obj.bindJC_CmpDetails(catesplitstr[1], City);
                lblCategory1.Text = catesplitstr[1];
                trCateRecords1.Visible = true;
                DlCateRecords1.DataSource = dsRecords1;
                DlCateRecords1.DataBind();
                dsRecords2 = obj.bindJC_CmpDetails(catesplitstr[2], City);
                lblCategory2.Text = catesplitstr[2];
                trCateRecords2.Visible = true;
                DlCateRecords2.DataSource = dsRecords2;
                DlCateRecords2.DataBind();
                dstotalrecords.Clear();
                dstotalrecords.Merge(dsRecords);
                dstotalrecords.Merge(dsRecords1);
                dstotalrecords.Merge(dsRecords2);
                DataList1.DataSource = dstotalrecords;
                DataList1.DataBind();
              
            }
            else if (catesplitstr[0] != "" && catesplitstr[1] != "")
            {
                dsRecords = obj.bindJC_CmpDetails(catesplitstr[0], City);
                lblCategory.Text = catesplitstr[0];
                trCateRecords.Visible = true;
                DlCateRecords.DataSource = dsRecords;
                DlCateRecords.DataBind();
                dsRecords1 = obj.bindJC_CmpDetails(catesplitstr[1], City);
                lblCategory1.Text = catesplitstr[1];
                trCateRecords1.Visible = true;
                DlCateRecords1.DataSource = dsRecords1;
                DlCateRecords1.DataBind();
                dstotalrecords.Clear();
                dstotalrecords.Merge(dsRecords);
                dstotalrecords.Merge(dsRecords1);
                DataList1.DataSource = dstotalrecords;
                DataList1.DataBind();
               
            }
            else if (catesplitstr[0] != "")
            {
                dsRecords = obj.bindJC_CmpDetails(catesplitstr[0], City);
                lblCategory.Text = catesplitstr[0];
                trCateRecords.Visible = true;
                DlCateRecords.DataSource = dsRecords;
                DlCateRecords.DataBind();
               
                DataList1.DataSource = dsRecords;
                DataList1.DataBind();
               
            }
             msgtxt = sendSms(name, cate, City, DataList1);
            if (msgtxt != "")
            {
                SMSCAPI objSms = new SMSCAPI();
                objSms.SendSMS(Convert.ToString(ConfigurationManager.AppSettings["SmsUsername"]), Convert.ToString(ConfigurationManager.AppSettings["SmsPassword"]), mobilenum, msgtxt);
                strScript = "alert('You will receive Mail and SMS shortly.');";
            }
           
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
            trCate.Visible = false;
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    //protected void imgBtnBanner_Click(object sender, ImageClickEventArgs e)
    //{
    //    try
    //    {
    //        redirect("jc_reverse_auction.aspx?Tcity=" + City,false);
    //    }
    //    catch (Exception ex)
    //    {
    //        obj.insert_exception(ex, excep_page);
    //        Response.Redirect("HttpErrorPage.aspx");
    //    }
    //}
    public string sendSms(string Iname, string Cate, string Loca, DataList dtlist)
    {
        //try
        //{
            string sb = "Dear " + Iname + ", your searching report :" + Cate + " in " + Loca + "  \n\n";
            int i = 0;
           
            foreach (DataListItem item in dtlist.Items)
            {
                //double d = Convert.ToDouble(((Label)(item.FindControl("testSpan0"))).Width.Value);
                //d = d / 18;
                //string sd;
                //if (d == 0)
                //    sd = d.ToString();
                //else
                //    sd = d.ToString("#.#");
                ++i;
                

                sb += Convert.ToString(i) + ":" + ((Label)(item.FindControl("lblCompany"))).Text.Replace("&", "and") + "\n" +
                         ((Label)(item.FindControl("lblVarea"))).Text.Replace("&", "and") + ", " + ((Label)(item.FindControl("lblPhone"))).Text + ". \n\n";
               
            }
            return sb += "plz, say justcalluz.com to callers.";
        //}
        //catch
        //{
        //    return "";
        //}        

    }
    protected string GetBannerUrl()
    {
        return Page.GetRouteUrl("ReverseAuction", new { Tcity = City });
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
