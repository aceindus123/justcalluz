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

public partial class testimonials : System.Web.UI.Page
{
    int id;
    PagedDataSource pds = new PagedDataSource();
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    InsertData obj = new InsertData();
    DataCS objDs = new DataCS();
    Binddata objBd = new Binddata();
    DataSet dsViews = new DataSet();
    static string excep_page = "testimonials.aspx";
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!Page.IsPostBack)
            {
                DlData.Visible = true;
                ViewState["previouspage"] = Request.UrlReferrer;
            }
            //ddlPageSize.Visible = false;

            if (!IsPostBack)
            {
                objDs.FillStates(ddlState);
            }
            BindGrid();
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void ddlState_SelectedIndexChanged(object sender, EventArgs e)
    {
        string statename = ddlState.SelectedItem.ToString();
        con.Open();
        DataSet dsCities = new DataSet();
        dsCities = objBd.GetDiscountCities(statename);
        con.Close();
        ddlCity.DataSource = dsCities;
        ddlCity.DataValueField = "city_name";
        ddlCity.DataTextField = "city_name";
        ddlCity.DataBind();
        ddlCity.Items.Insert(0, "Select city");
    }
    protected void imgPrevious_Click(object sender, ImageClickEventArgs e)
    {
        CurrentPage -= 1;
        BindGrid();
    }
    protected void imgNext_Click(object sender, ImageClickEventArgs e)
    {
        CurrentPage += 1;
        BindGrid();
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
    public void BindGrid()
    {
        try
        {
            con.Open();
            DataSet dsDetails = new DataSet();
            dsDetails = obj.BindTestimonial_Det();
            con.Close();
            if (dsDetails.Tables[0].Rows.Count > 0)
            {
                lblResult.Visible = false;
                Session["id"] = id;
                pds.DataSource = dsDetails.Tables[0].DefaultView;
                pds.AllowPaging = true;
                pds.PageSize = 5;
                pds.CurrentPageIndex = CurrentPage;
                imgNext.Enabled = !pds.IsLastPage;
                imgPrevious.Enabled = !pds.IsFirstPage;
                DlData.DataSource = pds;
                DlData.DataBind();
                //doPaging();
            }
            else
            {
                lblResult.Text = "No views are available";
                tblpaging.Visible = false;
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void btnSubmit_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            string pdate = System.DateTime.Now.ToString("dd MMM,yyyy hh:mm:ss tt");
            SqlCommand cmd = new SqlCommand("pro_testimonials", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Name", txtName.Text);
            cmd.Parameters.AddWithValue("@nick_name", txtNickName.Text);
            cmd.Parameters.AddWithValue("@EmailAddress", txtEmailAddress.Text);
            cmd.Parameters.AddWithValue("@MobileNo", txtMobileNo.Text);
            cmd.Parameters.AddWithValue("@State", ddlState.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@City", ddlCity.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@Views", txtViews.Text);
            cmd.Parameters.AddWithValue("@PostDate", SqlDbType.NVarChar).Value = pdate;
            cmd.Parameters.AddWithValue("@Status", SqlDbType.Int).Value = 0;

            if (photo.HasFile)
            {
                if (photo.PostedFile.ContentLength <= 100000)
                {

                    string filename = System.IO.Path.GetFileName(photo.PostedFile.FileName);
                    string contenttype = photo.PostedFile.ContentType;
                    photo.PostedFile.SaveAs(Server.MapPath("~/testimonial_images/" + filename));
                    using (System.Drawing.Image Img = System.Drawing.Image.FromFile(Server.MapPath("~/testimonial_images/" + filename)))
                    {
                        if (Img.Width == 250 && Img.Height == 300)
                        {

                            cmd.Parameters.AddWithValue("@ImageName", filename);
                            cmd.Parameters.AddWithValue("@ImageContentType", contenttype);
                            try
                            {
                                con.Open();
                                cmd.ExecuteNonQuery();
                            }
                            catch (Exception ex)
                            {
                                obj.insert_exception(ex, excep_page);
                                Response.Redirect("HttpErrorPage.aspx");
                            }
                            finally
                            {
                                cmd.Dispose();
                                if (con != null)
                                {
                                    con.Close();
                                }
                            }

                            string strscript = string.Empty;
                            strscript = "alert('Your image is successfully uploaded');location.replace('Justcalluz-Testimonials');";
                            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strscript, true);
                            txtName.Text = "";
                            txtNickName.Text = "";
                            txtEmailAddress.Text = "";
                            txtMobileNo.Text = "";
                            ddlState.SelectedIndex = 0;
                            ddlCity.SelectedIndex = 0;
                            txtViews.Text = "";
                        }
                        else
                        {
                            string strScript = string.Empty;
                            strScript = "alert('sorry! Secified invitation cannot be uploaded , make sure that width=250 and height=300.');";
                            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                        }
                    }

                }
                else
                {
                    string strScript = string.Empty;
                    strScript = "alert('sorry! Secified invitation cannot be uploaded , make sure that content length must be greaterthan or equal to 100000.');";
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                }
            }
            else
            {
                cmd.Parameters.AddWithValue("@ImageName", SqlDbType.NVarChar).Value = "he.gif";
                cmd.Parameters.AddWithValue("@ImageContentType", SqlDbType.NVarChar).Value = "image/gif";
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    obj.insert_exception(ex, excep_page);
                    Response.Redirect("HttpErrorPage.aspx");
                }
                finally
                {
                    cmd.Dispose();
                    if (con != null)
                    {
                        con.Close();
                    }
                }
                string strscript = string.Empty;
                strscript = "alert('Thank You! For sharing your views your thought would be listed here after a while');location.replace('Justcalluz-Testimonials');";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strscript, true);
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
}

