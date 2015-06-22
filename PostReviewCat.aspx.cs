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
using System.IO;
using System.Collections.Generic;
using System.Web.Routing;

public partial class PostReviewCat : System.Web.UI.Page
{
    SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    string did = string.Empty;
    string Rating = string.Empty;
    int RatingNo = 0;
    string Str;
    string imgName;
    string imgContentType;
    string CompName = string.Empty;
    string Module = string.Empty;
    string strScript = string.Empty;
    InsertData obj = new InsertData();
    static string excep_page = "PostReviewCat.aspx";
    int regid;
    int tagid;
    SqlDataAdapter sdaLogin;
    /// <summary>
    /// executes when page loads
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            DataSet dsUserDetails = new DataSet();
           // SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
            //connection.Open();
            string sid = string.Empty;

            if (Page.RouteData.Values.Count() > 0)
            {
                sid = Convert.ToString(Page.RouteData.Values["DataId"]);
            }
            else if (Convert.ToString(Request.QueryString["name"]) == "Rating")
            {
                sid = Convert.ToString(Request.QueryString["DataId"]);
            }     
               
            if (!IsPostBack)
            {
                SqlDataAdapter imgtext = new SqlDataAdapter("select * from ModulesData where id='" + sid + "'", connection);
                imgtext.Fill(dsUserDetails, "ModulesData");
                if (!dsUserDetails.Tables[0].Rows.Count.Equals(0))
                {
                    lblCompanyName.Text = dsUserDetails.Tables[0].Rows[0]["company_name"].ToString();
                    lblcompany.Text = dsUserDetails.Tables[0].Rows[0]["company_name"].ToString();
                    CompName = dsUserDetails.Tables[0].Rows[0]["company_name"].ToString();
                    Module = dsUserDetails.Tables[0].Rows[0]["module"].ToString();
                    Session["module"] = Module;
                    Session["CompName"] = CompName;
                    lblCompanyName.Text = CompName;
                }
            }
            //connection.Close();
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }

    }
    /// <summary>
    /// Function to post review for the Categories
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void ImgBtnSubmitReview_Click(object sender, ImageClickEventArgs e)
    {
        //string status = Session["Checked"].ToString();
        //if (status == "True")
        //{
        try
        {
            if (radBtnExcellent.Checked == true)
            {
                Rating = radBtnExcellent.Text;
                RatingNo = 5;
            }
            else if (radBtnVeryGud.Checked == true)
            {
                Rating = radBtnVeryGud.Text;
                RatingNo = 4;
            }
            else if (radBtnGud.Checked == true)
            {
                Rating = radBtnGud.Text;
                RatingNo = 3;
            }
            else if (radBtnAvg.Checked == true)
            {
                Rating = radBtnAvg.Text;
                RatingNo = 2;
            }
            else if (radBtnPoor.Checked == true)
            {
                Rating = radBtnPoor.Text;
                RatingNo = 1;
            }
            //To check the photo is uploaded or not
            try
            {
                if (Imgupload.HasFile)
                {
                    Str = Imgupload.PostedFile.FileName;
                    imgName = System.IO.Path.GetFileName(Imgupload.PostedFile.FileName);
                    Imgupload.PostedFile.SaveAs(Server.MapPath("Review_Images/" + imgName));
                    imgContentType = Imgupload.PostedFile.ContentType;
                }
                else
                {
                    imgName = "he.gif";
                    imgContentType = "image/gif";
                }
            }
            catch (Exception ex)
            {
                obj.insert_exception(ex, excep_page);
                Response.Redirect("HttpErrorPage.aspx");
            }
            string title = Convert.ToString(Session["CompName"]);
            string mod = Convert.ToString(Session["module"]);

            string getdate = "select postdate=DATEADD(mi,750,GETDATE())";
            SqlDataAdapter ada = new SqlDataAdapter(getdate, connection);
            DataSet ds1 = new DataSet();
            ada.Fill(ds1);
            try
            {
                if (!ds1.Tables[0].Rows.Count.Equals(0))
                {
                    string date = ds1.Tables[0].Rows[0]["postdate"].ToString();
                    Session["Date"] = date;
                }
            }
            catch (Exception ex)
            {
                obj.insert_exception(ex, excep_page);
                Response.Redirect("HttpErrorPage.aspx");
            }

            did = Convert.ToString(Page.RouteData.Values["DataId"].ToString());
            //connection.Open();
            string  uid = Convert.ToString(Session["USERID"]);
            string pwd = Convert.ToString(Session["PASSWORD"]);
            string mobilenum = Convert.ToString(Session["Mob"]);
            if (uid != "" && pwd != "")
            {
                sdaLogin = new SqlDataAdapter("select id,password from register where email='" + uid + "' and password='" + pwd + "' and mob='" + mobilenum + "' and iStatus=1", connection);
            }
            else
            {
                uid = txtemailid.Text;
                Session["USERID"] = uid;
                mobilenum = txtmobno.Text;
                sdaLogin = new SqlDataAdapter("select id,password from register where email='" + uid + "' and mob='" + mobilenum + "' and iStatus=1", connection);
            }
            
                DataSet dsLogin = new DataSet();
                sdaLogin.Fill(dsLogin);
                if(dsLogin.Tables[0].Rows.Count>0)
                {
                    regid = Convert.ToInt32(dsLogin.Tables[0].Rows[0]["id"]);
                    Session["PASSWORD"] = Convert.ToString(dsLogin.Tables[0].Rows[0]["password"]);
                    
                    //tagid = 0;
                }
            string postdate = Convert.ToString(Session["Date"]);
            SqlCommand cmd = new SqlCommand("Insert into PostReview(rname,remail,rmob,rating,dataid,review,ImageName,ImageContentType,Stars_Rating,module,title,postdate,regid,reg_id) values('" + txtName.Text + "','" + txtemailid.Text + "', '" + txtmobno.Text + "','" + Rating + "','" + did + "','" + txtReview.Text + "','" + imgName + "', '" + imgContentType + "'," + RatingNo + ",'" + mod + "','" + title + "','" + postdate + "'," + tagid + ", " + regid + ")", connection);
            try
            {
                connection.Open();
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
                connection.Close();
            }
            try
            {
                if (Convert.ToString(Page.RouteData.Values["mod"]) != "")
                {
                    string module = Convert.ToString(Page.RouteData.Values["mod"]);
                    if (module == "LifeStyle")
                    {
                        strScript = "alert('Thank You! Your Review is posted Successfully.');location.replace('LifestyleDetails-" + did + "');";//('LifeStyle_details.aspx?id=" + did + "');";
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                    }
                    else if (module == "Discounts")
                    {
                        strScript = "alert('Thank You! Your Review is posted Successfully.');location.replace('Discount-" + did + "-discounts');"; //'Discount_Details.aspx?id=" + did + "&cname=discounts'
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                    }
                }
                else
                {
                    strScript = "alert('Thank You! Your Review is posted Successfully.');location.replace('S_sessionstore-" + did + "');";//('sessionstore.aspx?id=" + did + "');";
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                }
            }
            catch (Exception ex)
            {
                obj.insert_exception(ex, excep_page);
                Response.Redirect("HttpErrorPage.aspx");
            }

            //}
            //else
            //{
            //    string strScript = "";
            //    strScript = "alert('Please select any one of the rating');";
            //    Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
            //}
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }


    }
    /// <summary>
    /// To check the the which radio button is checked
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    //protected void radBtnRequired_ServerValidate(object sender, ServerValidateEventArgs e)
    //{
    //    e.IsValid = radBtnExcellent.Checked || radBtnVeryGud.Checked || radBtnGud.Checked || radBtnAvg.Checked || radBtnPoor.Checked;
    //    Session["Checked"] = e.IsValid;
    //}
    /// <summary>
    /// To cancel the Post review
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void ImgBtnBackReview_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            did = Convert.ToString(Page.RouteData.Values["DataId"]);
            //redirect("sessionstore.aspx?id=" + did,false);
            Response.RedirectToRoute("CT_sessionstore", new { id = did });
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
}

