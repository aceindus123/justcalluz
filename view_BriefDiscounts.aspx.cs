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
using JustCallUsData.Data;
using System.Net;
using System.Net.NetworkInformation;
using System.Web.Routing;

public partial class view_BriefDiscounts : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    string uid;
    char[] separatorcomma = new char[] { ',' };
    char[] separatorspace = new char[] {' '};
    DataCS dcs = new DataCS();
    Binddata objBd = new Binddata();
    InsertData obj = new InsertData();
    static string excep_page = "view_BriefDiscounts.aspx";
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            uid = Convert.ToString(Session["USERID"]);
            string regtype = Convert.ToString(Session["RegType"]);
            if (uid != "" && regtype == "Business")
            {

            }
            else if (uid != "" && regtype == "Individual")
            {
               //redirect("AuthenticationMsg.aspx?msg=Discount",false);
                Response.RedirectToRoute("AuthenticationMsg", new { msg = "Discount" });
            }
            else
            {
                //redirect("signin.aspx?Qname=ViewBriefDiscount",false);
                Response.RedirectToRoute("", new { Qname = "ViewBriefDiscount" });
            }
            if (!IsPostBack)
            {
                getphotos();
                ItemList();

            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }


    }
    public void ItemList()
    {
        try
        {
           
            int sid = Convert.ToInt32(Page.RouteData.Values["id"]);
            if (Session["USERID"] != "")
            {
                string strname = string.Empty;
                uid = Convert.ToString(Session["USERID"]);
                strname = "Discounts";
                if (strname == null)
                {

                    lblMsg.Visible = true;
                    lblMsg.Text = "Welcome to JustCalluz..! Select Your Postings To have a look";

                }
                else
                {
                    try
                    {
                        SqlCommand cmd1 = new SqlCommand("view_DiscountDetails", con);
                        cmd1.Parameters.AddWithValue("@UserLoginId", SqlDbType.NVarChar).Value = uid;
                        cmd1.Parameters.AddWithValue("@id", SqlDbType.Int).Value = sid;
                        cmd1.CommandType = CommandType.StoredProcedure;
                        SqlDataAdapter discountdet = new SqlDataAdapter(cmd1);
                        DataSet dsdiscount = new DataSet();
                        discountdet.Fill(dsdiscount);

                        if (!dsdiscount.Tables[0].Rows.Count.Equals(0))
                        {
                            dlData.DataSource = dsdiscount.Tables[0];
                            dlData.DataBind();
                            dlmoreinfo.Visible = true;
                            dlmoreinfo.DataSource = dsdiscount.Tables[0];
                            dlmoreinfo.DataBind();
                        }
                        else if (!dsdiscount.Tables[1].Rows.Count.Equals(0))
                        {
                            trMoreinfo.Visible = false;
                            trPImages.Visible = false;
                            trPName.Visible = false;
                            dlData.DataSource = dsdiscount.Tables[1];
                            dlData.DataBind();
                        }
                    }
                    catch (Exception ex)
                    {
                        obj.insert_exception(ex, excep_page);
                        Response.Redirect("HttpErrorPage.aspx");
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
    protected void lnkUpdate_Click(object sender, EventArgs e)
    {
        try
        {
            int sid = Convert.ToInt32(Page.RouteData.Values["id"]);
            //redirect("Edit_discounts.aspx?id=" + sid + "&cname=discounts",false);
            Response.RedirectToRoute("EditDiscount", new { id = sid, cname = "discounts" });
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }

    }
    public void getphotos()
    {
        try
        {
            int sid = Convert.ToInt32(Page.RouteData.Values["id"]);
            DataSet dsphoto = new DataSet();
            dsphoto = dcs.getPhotos(sid);
             dlphoto.DataSource = dsphoto;
            dlphoto.DataBind();
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }

    }
    protected void dlData_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        try
        {
            Label lblStatus = (Label)e.Item.FindControl("lblStatus");
            if (lblStatus != null)
            {
                string status = Convert.ToString(lblStatus.Text);
                if (status == "0")
                {
                    lblStatus.Text = "Thank you for posting!Please wait for Approval";

                }
                else if (status == "1")
                {
                    lblStatus.Text = "Your data is approved";
                }
                else if (status == "2")
                {
                    lblStatus.Text = "You entered violated data!Please update your data";
                }
                else if (status == "3")
                {
                    lblStatus.Text = "You have updated the data!Please wait for Approval";
                }
            }

            Label lblcmpy = (Label)e.Item.FindControl("lblcompany");
            if (lblcmpy != null)
            {
                if (lblcmpy.Text != "")
                {
                    lblcmpy.Text = lblcmpy.Text;
                }
                else
                {
                    lblcmpy.Text = "Not Mentioned";
                    lblcmpy.ForeColor = System.Drawing.Color.Red;
                }
            }
            Label lbladrs = (Label)e.Item.FindControl("lbladres");
            if (lbladrs != null)
            {
                if (lbladrs.Text != "")
                {
                    lbladrs.Text = lbladrs.Text;
                }
                else
                {
                    lbladrs.Text = "Not Mentioned";
                    lbladrs.ForeColor = System.Drawing.Color.Red;
                }
            }
            Label lbllmark = (Label)e.Item.FindControl("lbllmark");
            if (lbllmark != null)
            {
                if (lbllmark.Text != "")
                {
                    lbllmark.Text = lbllmark.Text;
                }
                else
                {
                    lbllmark.Text = "Not Mentioned ";
                    lbllmark.ForeColor = System.Drawing.Color.Red;
                }
            }
            Label lblcode = (Label)e.Item.FindControl("lblpincode");
            if (lblcode != null)
            {
                if (lblcode.Text != "")
                {
                    lblcode.Text = lblcode.Text;
                }
                else
                {
                    lblcode.Text = "Not Mentioned";
                    lblcode.ForeColor = System.Drawing.Color.Red;
                }
            }
            Label lblcperson = (Label)e.Item.FindControl("lblcperson");
            if (lblcperson != null)
            {
                if (lblcperson.Text != "")
                {
                    lblcperson.Text = lblcperson.Text;
                }
                else
                {
                    lblcperson.Text = "Not Mentioned";
                    lblcperson.ForeColor = System.Drawing.Color.Red;
                }
            }
            Label lblmob = (Label)e.Item.FindControl("lblmob");
            if (lblmob != null)
            {
                if (lblmob.Text != "")
                {
                    lblmob.Text = lblmob.Text;
                }
                else
                {
                    lblmob.Text = "Not Mentioned";
                    lblmob.ForeColor = System.Drawing.Color.Red;
                }
            }
            Label lblcmail = (Label)e.Item.FindControl("lblemail");
            if (lblcmail != null)
            {
                if (lblcmail.Text != "")
                {
                    lblcmail.Text = lblcmail.Text;
                }
                else
                {
                    lblcmail.Text = "Not Mentioned";
                    lblcmail.ForeColor = System.Drawing.Color.Red;
                }
            }
            Label lblwebsite = (Label)e.Item.FindControl("lblwebsite");
            if (lblwebsite != null)
            {
                if (lblwebsite.Text != "")
                {
                    lblwebsite.Text = lblwebsite.Text;
                }
                else
                {
                    lblwebsite.Text = "Not Mentioned";
                    lblwebsite.ForeColor = System.Drawing.Color.Red;
                }
            }
            Label lblsDate = (Label)e.Item.FindControl("lblfDate");
            if (lblsDate != null)
            {
                if (lblsDate.Text != "")
                {
                    DateTime sdate = Convert.ToDateTime(lblsDate.Text);
                    string sdate1 = Convert.ToString(sdate.ToShortDateString());
                    lblsDate.Text = sdate1;

                }
                else
                {
                    lblsDate.Text = "Not Mentioned";
                    lblsDate.ForeColor = System.Drawing.Color.Red;
                }
            }
            Label lbllDate = (Label)e.Item.FindControl("lbllDate");
            if (lbllDate != null)
            {
                if (lbllDate.Text != "")
                {
                    DateTime ldate = Convert.ToDateTime(lbllDate.Text);
                    string edate = Convert.ToString(ldate.ToShortDateString());
                    lbllDate.Text = edate; ;
                }
                else
                {
                    lbllDate.Text = "Not Mentioned";
                    lbllDate.ForeColor = System.Drawing.Color.Red;
                }
            }

            Label lblfax = (Label)e.Item.FindControl("lblfax");
            if (lblfax != null)
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
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
        HtmlTableRow trLogo = (HtmlTableRow)e.Item.FindControl("trLogo");
        Label imgname = (Label)e.Item.FindControl("lblImgName");
        try
        {
            if (imgname != null)
            {
                if (imgname.Text == "NULL" || imgname.Text == "0" || imgname.Text == "" || imgname.Text == "null")
                {
                    trLogo.Visible = false;
                }
                else
                {
                    trLogo.Visible = true;
                }
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }

    }
    [System.Web.Script.Services.ScriptMethod()]
    [System.Web.Services.WebMethod]
    public static List<string> Getcities(string prefixText)
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["connectionstring"]);
        con.Open();
        SqlCommand cmd = new SqlCommand("select * from cities where city_name like @Name+'%'", con);
        cmd.Parameters.AddWithValue("@Name", prefixText);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        da.Fill(dt);
        List<string> citynames = new List<string>();
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            citynames.Add(dt.Rows[i][1].ToString());
        }
        return citynames;
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
    //protected string GetEditUrl(object Eid)
    //{
    //    string EdiscountId = Eid.ToString();
    //    return Page.GetRouteUrl("EditDiscount", new { id = EdiscountId, cname = "discounts" });
    //}
 }
