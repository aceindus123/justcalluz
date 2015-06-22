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
using System.Net.Mail;
using System.Net;
using System.IO;
using System.Text;
using System.Web.Services;

public partial class _jobs : System.Web.UI.Page
{
    InsertData obj = new InsertData();
    string sid = string.Empty;
    int id;
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!Page.IsPostBack)



            dldata.Visible = true;
        mailpanel.Visible = true;



        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sidardhConnectionString"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("select id,company_name,job_exp,job_desc,city,mob from modulesdata where module='Jobs'", con);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        con.Close();
        dldata.DataSource = ds;
        dldata.DataBind();
        ddlPageSize.Visible = false;
        mailpanel.Visible = true;
        //modpopup2.Visible = true;
        //modalpopup3.Visible = true;
        if (!IsPostBack)
        {
            BindGrid();
        }

    }

    /// <summary>
    /// // Applying paging to the form
    /// </summary>
    PagedDataSource pds = new PagedDataSource();
    public void BindGrid()
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
        SqlDataAdapter da = new SqlDataAdapter("select id,company_name,job_exp,job_desc,city,mob from modulesdata where module='Jobs'", con);
        DataTable dt = new DataTable();
        da.Fill(dt);
        Session["id"] = id;
        pds.DataSource = dt.DefaultView;
        pds.AllowPaging = true;
        pds.PageSize = 3;
        //pds.PageSize = Convert.ToInt16(ddlPageSize.SelectedValue);
        pds.CurrentPageIndex = CurrentPage;
        lnkbtnNext.Enabled = !pds.IsLastPage;
        lnkbtnPrevious.Enabled = !pds.IsFirstPage;
        dldata.DataSource = pds;
        dldata.DataBind();
        doPaging();
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
    private void doPaging()
    {
        DataTable dt = new DataTable();
        dt.Columns.Add("PageIndex");
        dt.Columns.Add("PageText");
        for (int i = 0; i < pds.PageCount; i++)
        {
            DataRow dr = dt.NewRow();
            dr[0] = i;
            dr[1] = i + 1;
            dt.Rows.Add(dr);
        }
        dlPaging.DataSource = dt;
        dlPaging.DataBind();
    }

    protected void dlPaging_ItemCommand(object source, DataListCommandEventArgs e)
    {
        if (e.CommandName.Equals("lnkbtnPaging"))
        {
            CurrentPage = Convert.ToInt16(e.CommandArgument.ToString());
            BindGrid();
        }
    }
    protected void lnkbtnPrevious_Click1(object sender, EventArgs e)
    {
        CurrentPage -= 1;
        BindGrid();
    }
    protected void lnkbtnNext_Click1(object sender, EventArgs e)
    {
        CurrentPage += 1;
        BindGrid();
    }
    protected void ddlPageSize_SelectedIndexChanged(object sender, EventArgs e)
    {
        CurrentPage = 0;
        BindGrid();
    }
    protected void dlPaging_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        LinkButton lnkbtnPage = (LinkButton)e.Item.FindControl("lnkbtnPaging");
        if (lnkbtnPage.CommandArgument.ToString() == CurrentPage.ToString())
        {
            lnkbtnPage.Enabled = false;
            lnkbtnPage.Font.Bold = true;
        }
    }






    // sending mail

    public void SendMail(string name, string email, string cname, string exp, string desc, string loc, string mob, string no)
    {
        try
        {
            string Msg = "";

            try
            {
                MailMessage mm = new MailMessage();
                mm.From = new MailAddress("info@aceindus.in");
                //mm.To = "test_indus@yahoo.com";
                mm.To.Add(email);
                Msg += "Dear <b>" + name + "</b> ," +
                            "<br>Please find below the information you have requested:<br>" +
                            "<br>Whenever you call , please mention that you got this info from Justcalluz.com" +
                            "<br><table width=100%>" +
                            "<tr><td align=left>Company Name</td><td>:</td><td>" + cname + "</td></tr>" +
                            "<tr><td align=left>Job Description</td><td>:</td><td>" + desc + "</td></tr>" +
                            "<tr><td align=left>Experience</td><td>:</td><td>" + exp + "</td></tr>" +
                            "<tr><td align=left>Location</td><td>:</td><td>" + loc + "</td></tr>" +
                            "<tr><td align=left>Phone</td><td>:</td><td>" + mob + "</td></tr>" +
                            "</table>" +
                            "br>We hope the above information is in line with your request." +
                            "<br>For further details please follow the link <a href=http://www.justcalluz.com/jobs.aspx?id="+no+">www.justcalluz.com</a> or call on +9166136226." +
                            "<br><br>Warm Regards," +
                            "<br> Team JustCalluz";
                mm.Subject = " Job Vacency ";
                mm.IsBodyHtml = true;
                mm.Body = Msg;
                SmtpClient smtp = new SmtpClient();
                smtp.Send(mm);
            
                


            }
            catch (Exception ex)
            {
                lblerror.Text = ex.Message;
            }
        }
        catch (Exception ee)
        {
            lblerror.Text = ee.Message;
        }
        //Response.Redirect("Register.aspx?ret=ok");


    }


    public void submitbutton_Click(object sender, EventArgs e)
    {

        string strname = string.Empty;
        strname = Convert.ToString(Session["name"]);
        string name = txtname1.Text;
        string email = txtmob.Text;
        SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
        con.Open();
        SqlCommand cmd = new SqlCommand("select id,company_name,job_exp,job_desc,city,mob from modulesdata where SubCategory=('" + strname + "')", con);
        sid = Convert.ToString(Request.QueryString["id"]);
        SqlDataReader dr = cmd.ExecuteReader();
        string cname = string.Empty; ;
        string exp = string.Empty;
        string desc = string.Empty;
        string loc = string.Empty;
        string mob = string.Empty;
        string no = string.Empty;
        while (dr.Read())
        {
            cname = Convert.ToString(dr["company_name"]);
            exp = Convert.ToString(dr["job_exp"]);
            desc = Convert.ToString(dr["job_desc"]);
            loc = Convert.ToString(dr["city"]);
            mob = Convert.ToString(dr["mob"]);
            no = Convert.ToString(dr["id"]);

            SendMail(name, email, cname, exp, desc, loc, mob, no);
            string strScript = string.Empty;
            strScript = "alert('Thank you! You have successfully sent the details.');location.replace('jobs.aspx');";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
          
        }
        con.Close();

    }
}
    //protected void postbutton_Click(object sender, EventArgs e)
    //{

    //    SendSMS();
    //}
    //public void SendSMS()
    //{
    //    UriBuilder urlbuilder = new UriBuilder();
    //    urlbuilder.Host = "192.168.1.8";
    //    urlbuilder.Port = 8800;
    //    string phonenumber = "8143279668";
    //    string message = "sms test";
    //    urlbuilder.Query = string.Format("phonenumber=%2B" + phonenumber + "&Text" + message);
    //    HttpWebRequest httpreq = (HttpWebRequest)WebRequest.Create(new Uri(urlbuilder.ToString(), false));
    //    HttpWebResponse httpres = (HttpWebResponse)(httpreq.GetResponse());
    //}
    

