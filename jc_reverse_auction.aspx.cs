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
using System.Drawing;
using System.IO;
using System.Net;
using JustCallUsData.Data;
using IndusAbroad.safeConvert;
using System.Net.NetworkInformation;
using System.Web.Routing;

public partial class jc_reverse_auction : System.Web.UI.Page
{
    SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    InsertData obj = new InsertData();
    DataSet ds = new DataSet();
    DataSet dscities = new DataSet();
    DataSet chds = new DataSet();
    DataSet cds = new DataSet();
    DataSet dsMore = new DataSet();
    DataCS objMail = new DataCS();
    SqlDataReader dr;
    PagedDataSource objPds = new PagedDataSource();
    string Category1;
    string Category;
    string maincate;
    string name;
    string cate = string.Empty;
    string chkitems = string.Empty;
    string chkitems1 = string.Empty;
    CheckBox ChkCategory;
    CheckBox ChkCategory1;
    CheckBox ChkMoreCategory;
    string strScript;
    string city1;
    string Tcity;
    Int32 count = 0;
    Int32 count1 = 3;
    Int32 countId;
    SqlDataAdapter data;
    char[] q_separator = new char[] { ',' };
    static string excep_page = "jc_reverse_auction.aspx";
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            ds = obj.bindPopotherCities();
            dlpopcities.DataSource = ds;
            dlpopcities.DataBind();
            if (!IsPostBack)
            {
                txtSelectCity.Text = "Hyderabad";
                lblarea.Text = txtSelectCity.Text + " ?";
                Session["City"] = txtSelectCity.Text;
                dscities = obj.search_bindcities("A");
                dl_bindcities.DataSource = dscities;
                dl_bindcities.DataBind();
                City(txtSelectCity.Text);
                if (Page.RouteData.Values["Tcity"] != null)
                {
                    Tcity = Convert.ToString(Page.RouteData.Values["Tcity"].ToString());
                    txtSelectCity.Text = Tcity;
                    City(Tcity);
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
    protected void imgPrevious_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            CurrentPage -= 1;
            MoreCategory();
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void imgNext_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            CurrentPage += 1;
            MoreCategory();
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    //protected void cmdNext_Click(object sender, EventArgs e)
    //{
    //    CurrentPage += 1;
    //    MoreCategory();
    //}
    //protected void cmdPrev_Click(object sender, EventArgs e)
    //{
    //    CurrentPage -= 1;
    //    MoreCategory();
    //}
    protected void get_city(object sender, CommandEventArgs e)
    {
        try
        {
            string pre = e.CommandArgument.ToString();
            dscities = obj.search_bindcities(pre);
            dl_bindcities.DataSource = dscities;
            dl_bindcities.DataBind();
            pop_search.Show();
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void selectcity(object sender, CommandEventArgs e)
    {
        try
        {
            txtSelectCity.Text = e.CommandArgument.ToString();
            City(txtSelectCity.Text);
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void City(string city)
    {
        try
        {
            txtSelectCity.Text = city;
            Session["City"] = city;
            DataSet dsArea = new DataSet();
            dsArea = obj.bindJC_Area(city);
            if (!dsArea.Tables[0].Rows.Count.Equals(0))
            {
                string symbol1 = " e.g ";
                txtwherewater.WatermarkText = Convert.ToString(symbol1.ToString()) + Convert.ToString(dsArea.Tables[0].Rows[0]["Area"].ToString());
                txtsearchwater.WatermarkText = Convert.ToString(symbol1.ToString()) + Convert.ToString(dsArea.Tables[0].Rows[0]["Category"].ToString());
                lblarea.Text = txtSelectCity.Text + "?";
            }
            else
            {
                lblarea.Text = txtSelectCity.Text + "?";
                txtwherewater.WatermarkText = " ";
                txtsearchwater.WatermarkText = " ";
                strScript = "alert('Categories are not available for selected city');";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);

            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void txtSelectCity_TextChanged(object sender, EventArgs e)
    {
        try
        {
            lblarea.Text = txtSelectCity.Text;
          City(txtSelectCity.Text);
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void imgBtnGoSearch_Click(object sender, EventArgs e)
    {
        try
        {
            pnlMoreCategory.Visible = false;
            tdCategory.Visible = true;
            Category = Convert.ToString(txtSearchFor.Text);
            Session["Category"] = Category;
            Session["City"] = txtSelectCity.Text;
            string cateCity = Session["City"].ToString();
            DataSet dscategory = new DataSet();
            dscategory = obj.bindJC_Cate(Category, cateCity);
            if (!dscategory.Tables[0].Rows.Count.Equals(0))
            {
                try
                {

                    SqlDataAdapter sdaMore = new SqlDataAdapter("select count(distinct(SubCategory)) as count from modulesdata where Category='" + Category + "' and City='" + cateCity + "'", connection);
                    sdaMore.Fill(dsMore);
                    if (dsMore.Tables[0].Rows.Count > 0)
                    {
                        tdCategory.Visible = true;
                        int count2 = Convert.ToInt32(dsMore.Tables[0].Rows[0]["count"].ToString());
                        if (count2 < 6)
                        {
                            trMorecategories.Visible = false;
                            tdMoreCate.Visible = false;
                            DlCategory.DataSource = dscategory;
                            DlCategory.DataBind();
                        }
                        else
                        {
                            tdMoreCate.Visible = true;
                            trMorecategories.Visible = true;
                            DlCategory.DataSource = dscategory;
                            DlCategory.DataBind();
                        }
                    }
                    else
                    {
                        tdCategory.Visible = false;
                        strScript = "alert('No records found');";
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);

                    }
                }
                catch (Exception ex)
                {
                    obj.insert_exception(ex, excep_page);
                    Response.Redirect("HttpErrorPage.aspx");
                }
                MoreCategory();
            }
            else
            {
                tdCategory.Visible = false;
            }
            
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void MoreCategory()
    {
        try
        {
            pnlMoreCategory.Visible = true;
            Category1 = Convert.ToString(txtSearchFor.Text);
            lblCategory.Text = Category1;
            Session["City"] = txtSelectCity.Text;
            string cateCity1 = Session["City"].ToString();
            DataSet dscategory1 = new DataSet();
            dscategory1 = obj.bindJC_Cate1(Category1, cateCity1);
            if (!dscategory1.Tables[0].Rows.Count.Equals(0))
            {
                objPds.DataSource = dscategory1.Tables[0].DefaultView;
                objPds.AllowPaging = true;
                objPds.PageSize = 27;
                objPds.CurrentPageIndex = CurrentPage;
                imgPrevious.Enabled = !objPds.IsFirstPage;
                imgNext.Enabled = !objPds.IsLastPage;
                DlMoreCategory.DataSource = objPds;
                DlMoreCategory.DataBind();
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void ChkMoreCategory_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            foreach (DataListItem li in DlMoreCategory.Items)
            {
                try
                {
                    ChkMoreCategory = li.FindControl("ChkMoreCategory") as CheckBox;
                    if (ChkMoreCategory != null)
                    {

                        if (ChkMoreCategory.Checked)
                        {
                            if (count < 3)
                            {
                                chkitems += ChkMoreCategory.Text + ",";
                                count += 1;
                            }
                            else
                            {
                                ChkMoreCategory.Checked = false;
                                strScript = "alert('You can Select Max.3 Categories');";
                                Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                            }
                        }
                        else
                        {
                            chkitems1 += ChkMoreCategory.Text + ",";
                        }
                    }
                }
                catch (Exception ex)
                {
                    obj.insert_exception(ex, excep_page);
                    Response.Redirect("HttpErrorPage.aspx");
                }
            }
            foreach (DataListItem li in DlCategory.Items)
            {
                try
                {
                    ChkCategory = li.FindControl("ChkCategory") as CheckBox;
                    if (ChkCategory != null)
                    {
                        string[] csplitstr = chkitems1.Split(q_separator);
                        foreach (string c_arrstrr in csplitstr)
                        {
                            if (c_arrstrr != "")
                            {
                                if (c_arrstrr == ChkCategory.Text)
                                {
                                    ChkCategory.Checked = false;
                                }
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
            foreach (DataListItem li in DlCategory.Items)
            {
                try
                {
                    ChkCategory = li.FindControl("ChkCategory") as CheckBox;
                    if (ChkCategory != null)
                    {
                        string[] csplitstr = chkitems.Split(q_separator);
                        foreach (string c_arrstrr in csplitstr)
                        {
                            if (c_arrstrr != "")
                            {
                                if (c_arrstrr == ChkCategory.Text)
                                {
                                    ChkCategory.Checked = true;
                                }
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
            if (chkitems != "")
            {
                try
                {
                    string[] csplitstr = chkitems.Split(q_separator);
                    foreach (string c_arrstrr in csplitstr)
                    {
                        if (c_arrstrr != "")
                        {
                            string str1 = "select distinct(SubCategory) from modulesdata where SubCategory='" + c_arrstrr + "'";
                            data = new SqlDataAdapter(str1, connection);
                            data.Fill(cds);
                        }
                    }
                    Dlcategory1.DataSource = cds;
                    Dlcategory1.DataBind();
                    dvcontentTop.Visible = true;
                    dvcontentmid.Visible = true;
                    dvmidbottam.Visible = true;
                    tdMessage.Visible = true;
                }
                catch (Exception ex)
                {
                    obj.insert_exception(ex, excep_page);
                    Response.Redirect("HttpErrorPage.aspx");
                }
            }
            else
            {
                Dlcategory1.DataSource = "";
                Dlcategory1.DataBind();
                dvcontentTop.Visible = false;
                dvcontentmid.Visible = false;
                dvmidbottam.Visible = false;
                tdMessage.Visible = false;
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void lnkMoreCategory_Click(object sender, EventArgs e)
    {
        try
        {
            tdCategory.Visible = false;
            trCity.Visible = false;
            trCaption.Visible = false;
            MoreCategory();
            foreach (DataListItem li in DlCategory.Items)
            {
                ChkCategory = li.FindControl("ChkCategory") as CheckBox;
                if (ChkCategory != null)
                {
                    try
                    {
                        if (ChkCategory.Checked)
                        {
                            foreach (DataListItem li1 in DlMoreCategory.Items)
                            {
                                ChkMoreCategory = li1.FindControl("ChkMoreCategory") as CheckBox;

                                if (ChkMoreCategory != null)
                                {
                                    if (ChkMoreCategory.Text == ChkCategory.Text)
                                    {
                                        ChkMoreCategory.Checked = true;
                                    }
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

            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void imgBtnCancel_Click(object sender, EventArgs e)
    {
        try
        {
            tdCategory.Visible = true;
            trCity.Visible = true;
            trCaption.Visible = true;
            if (tdMessage.Visible)
            {
                tdMessage.Visible = true;
            }
            pnlMoreCategory.Visible = false;
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void ChkCategory_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            foreach (DataListItem li in DlCategory.Items)
            {
                ChkCategory = li.FindControl("ChkCategory") as CheckBox;
                if (ChkCategory != null)
                {
                    try
                    {

                        if (ChkCategory.Checked)
                        {
                            if (count < 3)
                            {
                                chkitems += ChkCategory.Text + ",";
                                count += 1;
                            }
                            else
                            {
                                ChkCategory.Checked = false;
                                strScript = "alert('You can Select Max.3 Categories');";
                                Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
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
            if (chkitems != "")
            {
                try
                {
                    string[] csplitstr = chkitems.Split(q_separator);
                    foreach (string c_arrstrr in csplitstr)
                    {
                        if (c_arrstrr != "")
                        {
                            string str1 = "select distinct(SubCategory) from modulesdata where SubCategory='" + c_arrstrr + "'";
                            data = new SqlDataAdapter(str1, connection);
                            data.Fill(cds);
                        }
                    }
                    Dlcategory1.DataSource = cds;
                    Dlcategory1.DataBind();
                    dvcontentTop.Visible = true;
                    dvcontentmid.Visible = true;
                    dvmidbottam.Visible = true;
                    tdMessage.Visible = true;
                }
                catch (Exception ex)
                {
                    obj.insert_exception(ex, excep_page);
                    Response.Redirect("HttpErrorPage.aspx");
                }
            }
            else
            {
                Dlcategory1.DataSource = "";
                Dlcategory1.DataBind();
                dvcontentTop.Visible = false;
                dvcontentmid.Visible = false;
                dvmidbottam.Visible = false;
                tdMessage.Visible = false;
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void ChkCategory1_CheckedChanged(object sender, EventArgs e)
    {
        try
        {

            foreach (DataListItem li in Dlcategory1.Items)
            {
                ChkCategory1 = li.FindControl("ChkCategory1") as CheckBox;
                try
                {
                    if (ChkCategory1 != null)
                    {
                        if (ChkCategory1.Checked)
                        {
                            chkitems += ChkCategory1.Text + ",";
                        }
                        else
                        {
                            chkitems1 += ChkCategory1.Text + ",";
                        }
                    }
                }
                catch (Exception ex)
                {
                    obj.insert_exception(ex, excep_page);
                    Response.Redirect("HttpErrorPage.aspx");
                }
            }
            foreach (DataListItem li in DlCategory.Items)
            {
                ChkCategory = li.FindControl("ChkCategory") as CheckBox;
                try
                {
                    if (ChkCategory != null)
                    {
                        string[] csplitstr = chkitems1.Split(q_separator);
                        foreach (string c_arrstrr in csplitstr)
                        {
                            if (c_arrstrr != "")
                            {
                                if (c_arrstrr == ChkCategory.Text)
                                {
                                    ChkCategory.Checked = false;
                                }
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
            if (chkitems != "")
            {
                string[] csplitstr = chkitems.Split(q_separator);
                try
                {
                    foreach (string c_arrstrr in csplitstr)
                    {
                        if (c_arrstrr != "")
                        {
                            string str1 = "select distinct(SubCategory) from modulesdata where SubCategory='" + c_arrstrr + "'";
                            data = new SqlDataAdapter(str1, connection);
                            data.Fill(chds);
                        }
                    }
                    Dlcategory1.DataSource = chds;
                    Dlcategory1.DataBind();
                    dvcontentTop.Visible = true;
                    dvcontentmid.Visible = true;
                    dvmidbottam.Visible = true;
                    tdMessage.Visible = true;
                }
                catch (Exception ex)
                {
                    obj.insert_exception(ex, excep_page);
                    Response.Redirect("HttpErrorPage.aspx");
                }
            }
            else
            {
                Dlcategory1.DataSource = "";
                Dlcategory1.DataBind();
                dvcontentTop.Visible = false;
                dvcontentmid.Visible = false;
                dvmidbottam.Visible = false;
                tdMessage.Visible = false;
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
      
    }
    protected void imgBtnSubmit_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            Session["City"] = txtSelectCity.Text;
            city1 = Session["City"].ToString();
            string cmpname = string.Empty;
            string cid = string.Empty;
            name = txtName.Text;
            string emailTosend = txtEmailId.Text;
            string mobileid = txtMobileNo.Text;
            ccjoin.ValidateCaptcha(txtVid.Text);
            string type = "JCReverseAuction";
            string ipAddrs = HttpContext.Current.Request.UserHostAddress.ToString();
            if (!ccjoin.UserValidated)
            {
                strScript = "alert('You have entered the wrong verification code.Please try again!.');";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                //Inform user that his input was wrong ...
                txtVid.Text = "";
                return;
            }
            else
            {
                if ((txtMobileNo.Text != "" || txtEmailId.Text != "") && txtVid.Text != "")
                {
                    foreach (DataListItem li in DlCategory.Items)
                    {
                        ChkCategory = li.FindControl("ChkCategory") as CheckBox;

                        if (ChkCategory != null)
                        {
                            if (ChkCategory.Checked)
                            {
                                cate += ChkCategory.Text + ",";

                                count++;
                            }
                        }
                    }

                    string[] catesplitstr = cate.Split(q_separator);
                    try
                    {
                        foreach (string catearry in catesplitstr)
                        {
                            DataSet ds1 = new DataSet();
                            ds1 = obj.bindJC_CmpDetails(catearry, city1);
                            if (catearry != "")
                            {
                                if (ds1.Tables[0].Rows.Count > 0)
                                {
                                    string Chkcate = Convert.ToString(ds1.Tables[0].Rows[0]["SubCategory"].ToString());
                                    for (int i = 1; i <= ds1.Tables[0].Rows.Count; i++)
                                    {
                                        cid += ds1.Tables[0].Rows[i - 1]["id"].ToString() + ",";
                                        if (catearry == Chkcate)
                                        {
                                            StringWriter sw = new StringWriter();
                                            HtmlTextWriter htw = new HtmlTextWriter(sw);
                                            //Server.Execute("jc_reverseauctionMail.aspx?cate=" + Server.UrlEncode(catearry) + " &city=" + Server.UrlEncode(city1) + " &name=" + Server.UrlEncode(name), htw);
                                            Server.Execute("SendEmail.aspx?cat=" + Server.UrlEncode(catearry) + "&city=" + Server.UrlEncode(city1) + "&name=" + Server.UrlEncode(name), htw, true);
                                            Mail.sendmail("info@aceindus.in", emailTosend, "Response to your search for '" + catearry + "'", sw.ToString());

                                            string strScript = "";
                                            strScript = "alert('Your mail is sent successfully !!! SMS sent process not done at this time !!!');";

                                            
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        obj.insert_exception(ex, excep_page);
                        Response.Redirect("HttpErrorPage.aspx");
                    }
                    objMail.Jname = SafeConvert.ToString(txtName.Text.Trim());
                    objMail.Jemail = SafeConvert.ToString(txtEmailId.Text.Trim());
                    objMail.Jph = SafeConvert.ToString(txtMobileNo.Text.Trim());
                    objMail.Jcompanyname = SafeConvert.ToString(DBNull.Value);
                    objMail.Jadid = SafeConvert.ToString(cid);
                    objMail.Jtype = SafeConvert.ToString(type);
                    objMail.Jip_address = SafeConvert.ToString(ipAddrs);
                    objMail.Jpostdate = SafeConvert.ToDateTime(System.DateTime.Now);
                    DataCS sendMail = new DataCS();
                    bool result = sendMail.JC_insertMailDetails(objMail.Jname, objMail.Jemail, objMail.Jph, objMail.Jcompanyname, objMail.Jadid, objMail.Jtype, objMail.Jip_address, objMail.Jpostdate);
                    //redirect("jc_reverse_thankyouForm.aspx?cate=" + Server.UrlEncode(cate) + " &city=" + Server.UrlEncode(city1) + " &name=" + Server.UrlEncode(name),false);
                    Response.RedirectToRoute("ReverseDetails", new { cate = cate, city = city1, name = name, mobile = mobileid });
                    //Response.RedirectToRoute("Mail", new { cate = cate, city = city1, name = name });
                    
                }
                else
                {
                    try
                    {
                        if (txtEmailId.Text != "" || txtMobileNo.Text != "")
                        {
                            tdmsgVid.Visible = false;
                            tdVid.Visible = true;
                        }
                        else
                        {
                            strScript = "alert('Please enter your mobile number or email id.');";
                            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
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
   

    //[System.Web.Script.Services.ScriptMethod()]
    //[System.Web.Services.WebMethod]
    //public static List<string> Getcities(string prefixText){
    //    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["connectionstring"]);
    //    con.Open();
    //    SqlCommand cmd = new SqlCommand("select * from cities where city_name like '@Name%'", con);
    //    cmd.Parameters.AddWithValue("@Name", prefixText);
    //    SqlDataAdapter da = new SqlDataAdapter(cmd);
    //    DataTable dt = new DataTable();
    //    da.Fill(dt);
    //    List<string> citynames = new List<string>();
    //    for (int i = 0; i < dt.Rows.Count; i++)
    //    {
    //        citynames.Add(dt.Rows[i][1].ToString());
    //    }
    //    return citynames;
    //}
    [System.Web.Script.Services.ScriptMethod()]
    [System.Web.Services.WebMethod]
    public static List<string> GetCategories(string prefixText)
    {
        try
        {
            string CateCity = HttpContext.Current.Session["City"].ToString();
            //string CateArea = HttpContext.Current.Session["Area"].ToString();
            SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["connectionstring"]);
            con.Open();
            //string symbol = " [ + ] ";
            List<string> catnames = new List<string>();
            DataTable dt = new DataTable();
            SqlCommand cmd;
            SqlDataAdapter da;
            cmd = new SqlCommand("select distinct(Category) from modulesdata where City='" + CateCity + "' and Category like '" + prefixText + "%'", con);
            // cmd.Parameters.AddWithValue("@Cat", prefixText);
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    catnames.Add(dt.Rows[i]["Category"].ToString());// + symbol.ToString());
                }
                return catnames;
            }
            else

                return null;
        }
        catch (Exception e)
        {
            e.ToString();
            return null;
        }
    }
    //[System.Web.Script.Services.ScriptMethod()]
    //[System.Web.Services.WebMethod]
    //public static List<string> GetAreas(string prefixText)
    //{
    //    try
    //    {
    //        string city = HttpContext.Current.Session["City"].ToString();
    //        List<string> AreaNames = new List<string>();
    //        SqlConnection con1 = new SqlConnection(ConfigurationManager.AppSettings["connectionstring"]);
    //        con1.Open();
    //        SqlCommand Areacmd = new SqlCommand("select Distinct(Area),City from modulesdata where City='" + city + "' and Area like'" + prefixText + "%'", con1);
    //        //Areacmd.Parameters.AddWithValue("@AreaName", prefixText);
    //        SqlDataAdapter da = new SqlDataAdapter(Areacmd);
    //        DataTable dtArea = new DataTable();
    //        da.Fill(dtArea);
    //        if (dtArea.Rows.Count > 0)
    //        {
    //            for (int i = 0; i < dtArea.Rows.Count; i++)
    //            {
    //                AreaNames.Add(dtArea.Rows[i]["Area"].ToString());

    //            }
    //            return AreaNames;
    //        }
    //        else

    //            return null;
    //    }
    //    catch (Exception e)
    //    {

    //        e.ToString();
    //        return null;
    //    }

    //}
    protected void hdnValue_ValueChanged(object sender, EventArgs e)
    {
        try
        {
            string CatName = Convert.ToString(txtSearchFor.Text);
            char[] seperator = new char[] { '[' };
            string[] splitstr = CatName.Split(seperator);
            txtSearchFor.Text = splitstr[0];
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    //protected void txtWhereIn_TextChanged(object sender, EventArgs e)
    //{
    //    Session["Area"] = txtWhereIn.Text;
    //}

    protected void Dlcategory1_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        try
        {
            CheckBox ChkCategory1 = (CheckBox)e.Item.FindControl("ChkCategory1");
            ChkCategory1.Checked = true;
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
