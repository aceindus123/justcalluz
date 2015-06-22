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

public partial class careers_resumeform : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    DataSet ds=new DataSet();
    SqlCommand cmd;
    SqlDataReader dr;
    SqlDataAdapter da;
    string id=string.Empty;
   // int jobid;
    string jobid = string.Empty;
    string cat=string.Empty;
    string dCat=string.Empty;
    string SubCat = string.Empty;
    string fileext;
    string filename;
    string filepath;
    string strScript;
    InsertData obj = new InsertData();
    static string excep_page = "careers_resumeform.aspx";
    CareersCS objresume = new CareersCS();

   protected void Page_Load(object sender, EventArgs e)
   {
       try
       {
           DateTime current = DateTime.Now;
           //if (!Page.IsPostBack)
           //{
               //code for department file
               if (Convert.ToString(Page.RouteData.Values["id"]) != "")
               {
                   id = Convert.ToString(Page.RouteData.Values["id"].ToString());
                   ds = objresume.GetJobDetails(id);
                   if (!ds.Tables[0].Rows.Count.Equals(0))
                   {
                       dCat = ds.Tables[0].Rows[0]["category"].ToString();
                       txtCategory.Text = dCat;
                       txtSpecialization.Text = ds.Tables[0].Rows[0]["specialization"].ToString();
                   }
               }
               //code for location file
               else if (Convert.ToString(Page.RouteData.Values["jobid"]) != "")
               {
                   cat = Convert.ToString(Page.RouteData.Values["cate"].ToString());
                   cat = cat.Replace("and", "/");
                   jobid = Convert.ToString(Page.RouteData.Values["jobid"]);
                   //cat = Convert.ToString(Page.RouteData.Values["cate"].ToString());
                   //cat = cat.Replace("-", "/");
                   SubCat = Convert.ToString(Page.RouteData.Values["Subcat"].ToString());
                   txtCategory.Text = cat;
                   txtSpecialization.Text = SubCat;

               }
               CareersCS carecs = new CareersCS();
               if (!IsPostBack)
               {

                   carecs.FillCareers_AdminSalRange1(ddlCTC);
                   carecs.FillCareers_AdminSalRange(ddlECTC);
                   carecs.FillCareers_JobType(ddlJobtype);
                   carecs.FillCareers_Education(ddlEducation);
               }
           //}
       }
       catch (Exception ex)
       {
           obj.insert_exception(ex, excep_page);
           Response.Redirect("HttpErrorPage.aspx");
       }
    }
    protected void imgSave_click(object sender, ImageClickEventArgs e)
    {
            CareersCS ccs = new CareersCS();
            fileext=System.IO.Path.GetExtension(UploadCv.FileName);
            //inserting the values based on department file
            if (Convert.ToString(Page.RouteData.Values["id"]) != "")
            {
                id = Convert.ToString(Page.RouteData.Values["id"].ToString());
                if (UploadCv.HasFile)
                {

                    try
                    {
                        if (fileext != ".doc" && fileext != ".txt")
                        {
                            strScript = "";
                            strScript = "alert('You can upload only .doc and .txt files')";
                            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                        }
                        else
                        {
                            string str = UploadCv.PostedFile.FileName;
                            filename = System.IO.Path.GetFileName(str);

                            CareersCS cacs= new CareersCS();
                            Int32 rname = Convert.ToInt32(cacs.CheckResumeName(filename));
                                

                            if (rname!=0)
                            {
                                strScript = "alert('The given Resume Name. " + filename + "  Already Exists, \\n Please modify resume name');";
                                Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                                filename = "";
                            }

                            UploadCv.PostedFile.SaveAs(Server.MapPath("~/resume/" + filename));
                            filepath = "~/resume/" + filename;
                            UploadCv.SaveAs(Server.MapPath(filepath));

                            ccs.Title = SafeConvert.ToString(txtTitle.Text.Trim());
                            ccs.firstname = SafeConvert.ToString(txtFName.Text.Trim());
                            ccs.lastname = SafeConvert.ToString(txtLName.Text.Trim());
                            ccs.email = SafeConvert.ToString(txtEmailAddress.Text.Trim());
                            ccs.landline_num = SafeConvert.ToString(txtHPhone.Text.Trim());
                            ccs.Cell_num = SafeConvert.ToString(txtCellNo.Text.Trim());
                            ccs.Category = SafeConvert.ToString(txtCategory.Text);
                            ccs.Specialization = SafeConvert.ToString(txtSpecialization.Text);
                            ccs.exp_years = SafeConvert.ToString(ddlyears.SelectedValue);
                            ccs.exp_months = SafeConvert.ToString(ddlmonths.SelectedValue);
                            ccs.current_ctc = SafeConvert.ToString(ddlCTC.SelectedValue);
                            ccs.expected_ctc = SafeConvert.ToString(ddlECTC.SelectedValue);
                            ccs.jobtype = SafeConvert.ToString(ddlJobtype.SelectedValue);
                            ccs.BasicEducation = SafeConvert.ToString(ddlEducation.SelectedValue);
                            ccs.curriculam_vitaeName = SafeConvert.ToString(filename);
                            ccs.curriculam_vitaePath = SafeConvert.ToString(filepath);
                            ccs.ajobid = SafeConvert.ToString(id);
                           
                            ccs.cPostDate = SafeConvert.ToDateTime(System.DateTime.Now.ToString("dd MMM,yyyy hh:mm:ss tt"));

                            CareersCS crcs = new CareersCS();
                            bool res = crcs.insertdetails(ccs.Title, ccs.firstname, ccs.lastname, ccs.email, ccs.landline_num,
                            ccs.Cell_num, ccs.Category, ccs.Specialization, ccs.exp_years, ccs.exp_months, ccs.current_ctc, ccs.expected_ctc,
                            ccs.jobtype, ccs.BasicEducation, ccs.curriculam_vitaeName, ccs.curriculam_vitaePath, ccs.ajobid, ccs.cPostDate);

                            if (res == true)
                            {
                                //lblMessage.Text = "Details are inserted sucessfully";
                                strScript = "alert('Your details are inserted sucessfully');location.replace('ResumeForm');";
                                Page.ClientScript.RegisterStartupScript(this.GetType(), "alertbox", strScript, true);
                            }
                            else
                            {
                                strScript = "alert('Your details are not inserted sucessfully');";
                                Page.ClientScript.RegisterStartupScript(this.GetType(), "alertbox", strScript, true);
                            }

                        }

                    }
                    catch (Exception ex)
                    {
                        obj.insert_exception(ex, excep_page);
                        Response.Redirect("HttpErrorPage.aspx");
                    }
                    //catch (Exception ex)
                    //{
                    //    lblMessage.Text = "";
                    //    lblMessage.Text = ex.Message.ToString();
                    //}
                }
 
            }
            //inserting the values based on location file
           
             else if (Convert.ToString(Page.RouteData.Values["jobid"])!="")
            {
                jobid = Convert.ToString(Page.RouteData.Values["jobid"]);

                if (UploadCv.HasFile)
                {

                    try
                    {
                        if (fileext != ".doc" && fileext != ".txt")
                        {
                            strScript = "";
                            strScript = "alert('You can upload only .doc and .txt files')";
                            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);

                        }
                        else
                        {
                            string str = UploadCv.PostedFile.FileName;
                            filename = System.IO.Path.GetFileName(str);

                            CareersCS cars = new CareersCS();
                            Int32 rname = Convert.ToInt32(cars.CheckResumeName(filename));


                            if (rname != 0)
                            {
                                strScript = "alert('The given Resume Name. " + filename + "  Already Exists, \\n Please modify resume name');";
                                Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                                filename = "";
                            }

                            UploadCv.PostedFile.SaveAs(Server.MapPath("~/resume/" + filename));
                            filepath = "~/resume/" + filename;
                            UploadCv.SaveAs(Server.MapPath(filepath));

                            ccs.Title = SafeConvert.ToString(txtTitle.Text.Trim());
                            ccs.firstname = SafeConvert.ToString(txtFName.Text.Trim());
                            ccs.lastname = SafeConvert.ToString(txtLName.Text.Trim());
                            ccs.email = SafeConvert.ToString(txtEmailAddress.Text.Trim());
                            ccs.landline_num = SafeConvert.ToString(txtHPhone.Text.Trim());
                            ccs.Cell_num = SafeConvert.ToString(txtCellNo.Text.Trim());
                            ccs.Category = SafeConvert.ToString(txtCategory.Text);
                            ccs.Specialization = SafeConvert.ToString(txtSpecialization.Text);
                            ccs.exp_years = SafeConvert.ToString(ddlyears.SelectedValue);
                            ccs.exp_months = SafeConvert.ToString(ddlmonths.SelectedValue);
                            ccs.current_ctc = SafeConvert.ToString(ddlCTC.SelectedValue);
                            ccs.expected_ctc = SafeConvert.ToString(ddlECTC.SelectedValue);
                            ccs.jobtype = SafeConvert.ToString(ddlJobtype.SelectedValue);
                            ccs.BasicEducation = SafeConvert.ToString(ddlEducation.SelectedValue);
                            ccs.curriculam_vitaeName = SafeConvert.ToString(filename);
                            ccs.curriculam_vitaePath = SafeConvert.ToString(filepath);
                            ccs.ajobid = SafeConvert.ToString(jobid);
                            ccs.cPostDate = SafeConvert.ToDateTime(System.DateTime.Now.ToString("dd MMM,yyyy hh:mm:ss tt"));

                            CareersCS crcs = new CareersCS();
                            bool res = crcs.insertdetails(ccs.Title, ccs.firstname, ccs.lastname, ccs.email, ccs.landline_num,
                            ccs.Cell_num, ccs.Category, ccs.Specialization, ccs.exp_years, ccs.exp_months, ccs.current_ctc, ccs.expected_ctc,
                            ccs.jobtype, ccs.BasicEducation, ccs.curriculam_vitaeName, ccs.curriculam_vitaePath, ccs.ajobid, ccs.cPostDate);

                            if (res == true)
                            {
                                strScript = "alert('Your details are inserted sucessfully');location.replace('ResumeForm');";
                                Page.ClientScript.RegisterStartupScript(this.GetType(), "alertbox", strScript, true);
                            }
                            else
                            {
                                strScript = "alert('Your details are not inserted sucessfully');";
                                Page.ClientScript.RegisterStartupScript(this.GetType(), "alertbox", strScript, true);
                            }

                         }

                    }
                    catch (Exception ex)
                    {
                        obj.insert_exception(ex, excep_page);
                        Response.Redirect("HttpErrorPage.aspx");
                    }
                    //catch (Exception ex)
                    //{
                    //    lblMessage.Text = "";
                    //    lblMessage.Text = ex.Message.ToString();
                    //}
                }
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

