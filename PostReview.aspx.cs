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

public partial class PostReview : System.Web.UI.Page
{
    SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    string did = string.Empty;
    string Rating = string.Empty;
    int RatingNo = 0;
    string Str;
    string imgName;
    string imgContentType;
    /// <summary>
    /// Executes when page loads
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            string CompName = string.Empty;
            string Module = string.Empty;

            DataSet dsUserDetails = new DataSet();
            //SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
            //connection.Open();
            string sid = string.Empty;
            sid = Convert.ToString(Page.RouteData.Values["DataId"].ToString());
            if (!IsPostBack)
            {
                SqlDataAdapter imgtext = new SqlDataAdapter("select * from ModulesData where id='" + sid + "'", connection);
                imgtext.Fill(dsUserDetails, "ModulesData");

                if (!dsUserDetails.Tables[0].Rows.Count.Equals(0))
                {
                    CompName = dsUserDetails.Tables[0].Rows[0]["company_name"].ToString();
                    Module = dsUserDetails.Tables[0].Rows[0]["module"].ToString();
                    Session["module"] = Module;
                    Session["CompName"] = CompName;
                    lblCompanyName.Text = CompName;
                    Label1.Text = CompName;
                }
            }
        }
        catch (Exception ex)
        {
            //obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
        //connection.Close();
    }

    /// <summary>
    /// Function to post review for the listings
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void ImgBtnSubmitReview_Click(object sender, ImageClickEventArgs e)
    {
        try
        {

            string status = Session["Checked"].ToString();
            if (status == "True")
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
                string title = Convert.ToString(Session["CompName"]);
                string mod = Convert.ToString(Session["module"]);

                string getdate = "select postdate=DATEADD(mi,750,GETDATE())";
                SqlDataAdapter ada = new SqlDataAdapter(getdate, connection);
                DataSet ds1 = new DataSet();
                ada.Fill(ds1);
                if (!ds1.Tables[0].Rows.Count.Equals(0))
                {
                    string date = ds1.Tables[0].Rows[0]["postdate"].ToString();
                    Session["Date"] = date;
                }

                //To check the photo is uploaded or not
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

                did = Convert.ToString(Page.RouteData.Values["DataId"].ToString());
                string postdate = Convert.ToString(Session["Date"]);
                SqlCommand cmd = new SqlCommand("Insert into PostReview(rname,remail,rmob,rating,dataid,review,ImageName,ImageContentType,Stars_Rating,module,title,postdate) values('" + txtName.Text + "','" + txtemailid.Text + "', '" + txtmobno.Text + "','" + Rating + "','" + did + "','" + txtReview.Text + "','" + imgName + "', '" + imgContentType + "'," + RatingNo + ",'" + mod + "','" + title + "','" + postdate + "')", connection);
                try
                {
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    //obj.insert_exception(ex, excep_page);
                    Response.Redirect("HttpErrorPage.aspx");
                }
                finally
                {
                    cmd.Dispose();
                    connection.Close();
                }
                string strScript = "";
                strScript = "alert('Thank You! Your Review is posted Successfully.');location.replace('Search-Not-Found.aspx?id=" + did + "');"; //SearchViewDetails.aspx?id=" + did + "');";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);

            }
            else
            {
                string strScript = "";
                strScript = "alert('Please select any one of the rating');";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
            }
        }
        catch (Exception ex)
        {
            //obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }


    }
    /// <summary>
    /// To check the the which radio button is checked
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void radBtnRequired_ServerValidate(object sender, ServerValidateEventArgs e)
    {
        e.IsValid = radBtnExcellent.Checked || radBtnVeryGud.Checked || radBtnGud.Checked || radBtnAvg.Checked || radBtnPoor.Checked;
        Session["Checked"] = e.IsValid;
    }
    /// <summary>
    /// To cancel the Post review
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void ImgBtnBackReview_Click(object sender, ImageClickEventArgs e)
    {
        did = (Request.QueryString["DataId"].ToString());
        Response.Redirect("SearchViewDetails.aspx?id=" + did);
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
