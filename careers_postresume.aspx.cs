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
using CallUsCareers.career;
using IndusAbroad.safeConvert;
using System.Collections.Generic;
using System.Web.Routing;

public partial class careers_postresume : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    CareersCS carecs = new CareersCS();
    InsertData obj = new InsertData();
     string filename;
     string fileext;
     string filepath;
     string StrScript;
     string UserId = string.Empty;
     static string excep_page = "careers_postresume.aspx";
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            UserId = Convert.ToString(Session["USERID"]);
            if (UserId != "")
            {

            }
            else
            {
                //redirect("signin.aspx?Qname=Careers",false);
                Response.RedirectToRoute("Signin", new { Qname = "Careers" });
            }
            if (!IsPostBack)
            {

                carecs.FillCareers_Category(ddlcategory);
                carecs.FillCareers_ExpYr(ddlyears);
                carecs.FillCareers_AdminSalRange1(ddlCTC);
                carecs.FillCareers_AdminSalRange(ddlECTC);
                carecs.FillCareers_JobType(ddlJobtype);
                carecs.FillCareers_Education(ddlEducation);
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }

    }

    protected void Save_click(object sender, ImageClickEventArgs e)
    {
        fileext = System.IO.Path.GetExtension(UploadCv.FileName);

        if (UploadCv.HasFile)
        {
            try 
            {
                if (fileext == ".doc" && fileext == ".txt")
                {
                    StrScript = "alert('you can upload only .doc and .txt files');";
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", StrScript, true);

                }
                else 
                {
                    string str = UploadCv.PostedFile.FileName;
                    filename = System.IO.Path.GetFileName(str);

                    CareersCS cacs = new CareersCS();
                    Int32 rname = Convert.ToInt32(cacs.CheckPostResumeName(filename));


                    if (rname != 0)
                    {
                        string strScript = "alert('The given Resume Name. " + filename + "  Already Exists, \\n Please modify resume name');";
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                        filename = "";
                    }

                    UploadCv.PostedFile.SaveAs(Server.MapPath("~/postresumes/" + filename));
                    filepath = "~/postresumes/" + filename;
                    UploadCv.SaveAs(Server.MapPath(filepath));
                    carecs.Title = SafeConvert.ToString(txtTitle.Text.Trim());
                    carecs.firstname = SafeConvert.ToString(txtFName.Text.Trim());
                    carecs.lastname = SafeConvert.ToString(txtLName.Text.Trim());
                    carecs.email = SafeConvert.ToString(txtEmailAddress.Text.Trim());
                    carecs.landline_num = SafeConvert.ToString(txtHPhone.Text.Trim());
                    carecs.Cell_num = SafeConvert.ToString(txtCellNo.Text.Trim());
                    carecs.Category = SafeConvert.ToString(ddlcategory.SelectedValue);
                    carecs.Specialization = SafeConvert.ToString(ddlspecialization.SelectedValue);
                    carecs.exp_years = SafeConvert.ToString(ddlyears.SelectedValue);
                    carecs.exp_months = SafeConvert.ToString(ddlMonths.SelectedValue);
                    carecs.current_ctc = SafeConvert.ToString(ddlCTC.SelectedValue);
                    carecs.expected_ctc = SafeConvert.ToString(ddlECTC.SelectedValue);
                    carecs.jobtype = SafeConvert.ToString(ddlJobtype.SelectedValue);
                    carecs.BasicEducation = SafeConvert.ToString(ddlEducation.SelectedValue);
                    carecs.curriculam_vitaeName = SafeConvert.ToString(filename);
                    carecs.curriculam_vitaePath = SafeConvert.ToString(filepath);
                    carecs.cPostDate = SafeConvert.ToDateTime(System.DateTime.Now);
                    carecs.userid = SafeConvert.ToString(UserId);

                    CareersCS ccs = new CareersCS();
                    bool result=ccs.PostDetails(carecs.Title,carecs.firstname,carecs.lastname,carecs.email,
                        carecs.landline_num,carecs.Cell_num,carecs.Category,carecs.Specialization,carecs.exp_years,
                        carecs.exp_months,carecs.current_ctc,carecs.expected_ctc,carecs.jobtype,carecs.BasicEducation,
                        carecs.curriculam_vitaeName,carecs.curriculam_vitaePath,carecs.cPostDate,carecs.userid);
                    if (result == true)
                    {
                        StrScript = "alert('your details are inserted successfully');location.replace('SubmitResume');";
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", StrScript, true);

                    }
                    else
                    {
                        StrScript = "alert('your details are not inserted successfully');";
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", StrScript, true);
                    }
                    
                }
            }
            catch (Exception ex)
            {
                obj.insert_exception(ex, excep_page);
                Response.Redirect("HttpErrorPage.aspx");
            }
            //catch(Exception exe)
            //{
            //    lblMessage.Text="";
            //    lblMessage.Text=exe.Message.ToString();
            //}
        }

    }
    protected void ddlcategory_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            string categoryname = ddlcategory.SelectedItem.ToString();
            DataSet dscate = new DataSet();
            dscate = carecs.GetSubCate(categoryname);
            ddlspecialization.DataSource = dscate;
            ddlspecialization.DataValueField = "SubCat";
            ddlspecialization.DataTextField = "SubCat";
            ddlspecialization.DataBind();
            ddlspecialization.Items.Insert(0, "select");
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
