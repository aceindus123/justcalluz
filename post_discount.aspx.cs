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
using JustCallUsData.Data;
using System.IO;
using System.Collections.Generic;
using System.Net;
using System.Net.NetworkInformation;
using System.Web.Routing;

public partial class post_discount : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    string strScript = string.Empty;
    InsertData obj = new InsertData();
    DataCS data = new DataCS();
    Binddata objBd = new Binddata();
    bool t;
    SqlDataAdapter sda;
    DataSet dsUserId = new DataSet();
    string Module_Name = string.Empty;
    string Categoty_Name = string.Empty;

    string MonDur = "";
    string TuesDur = "";
    string WedDur = "";
    string ThursDur = "";
    string FriDur = "";
    string SatDur = "";
    string SunDur = "";
    string Monday = "";
    string Tuesday = "";
    string Wednesday = "";
    string Thursday = "";
    string Friday = "";
    string Satday = "";
    string Sunday = "";
    string Payment = "";
    string AdtInfo = "";
    char[] separatorcomma = new char[] { ',' };
    char[] separatorspace = new char[] { ' ' };
    string imgLogoName;
    string ImgLogoContentType;
    string photoname;
    string photopath;
    static string excep_page = "post_discount.aspx";
    /// <summary>
    /// While viewing discount ,To check whether the user is loggedin or not if so ,is he is registered as business type ? assuming that may session will get closed.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            string userid = Convert.ToString(Session["USERID"]);
            trlblintimation.Visible = false;
            moreinfopanel.Visible = false;
            ccjoin.Visible = true;
            trMonDur.Visible = false;
            trTuesDur.Visible = false;
            trWedDur.Visible = false;
            trThursDur.Visible = false;
            trFriDur.Visible = false;
            trSatDur.Visible = false;
            trSunDur.Visible = false;
            trSubcat.Visible = false;
            string regtype = Convert.ToString(Session["RegType"]);
            try
            {
                if (userid != "" && regtype == "Business")
                {

                }
                else if (userid != "" && regtype == "Individual")
                {
                    //Response.RedirectToRoute("AuthenticationMsg.aspx?msg=Discount",false);
                    Response.RedirectToRoute("AuthenticationMsg", new { msg = "Discount" });
                }
                else
                    //Response.RedirectToRoute("signin.aspx?Qname=Discount",false);
                    Response.RedirectToRoute("Signin", new { Qname = "Discount" });
            }
            catch (Exception ex)
            {
                obj.insert_exception(ex, excep_page);
                Response.Redirect("HttpErrorPage.aspx");
            }

            if (!IsPostBack)
            {
                BindCatDropdown();
                data.FillStates(ddlstate);
                data.FillCompEstablishYr(ddlyearestablish);
                ViewState["previouspage"] = Request.UrlReferrer;
                data.FillHours(ddlMonHrFr);
                data.FillHours(ddlMonHrT);
                data.FillMinutes(ddlMonMinFr);
                data.FillMinutes(ddlMonMinT);
                data.FillHours(ddlTuesHrFr);
                data.FillMinutes(ddlTuesMinFr);
                data.FillHours(ddlTuesHrT);
                data.FillMinutes(ddlTuesMinT);
                data.FillHours(ddlWedHrFr);
                data.FillHours(ddlWedHrT);
                data.FillMinutes(ddlWedMinFr);
                data.FillMinutes(ddlWedMinT);
                data.FillHours(ddlThursHrFr);
                data.FillHours(ddlThursHrT);
                data.FillMinutes(ddlThursMinFr);
                data.FillMinutes(ddlThursMinT);
                data.FillHours(ddlFriHrFr);
                data.FillHours(ddlFriHrT);
                data.FillMinutes(ddlFriMinFr);
                data.FillMinutes(ddlFriMinT);
                data.FillHours(ddlSaturHrFr);
                data.FillHours(ddlSaturHrT);
                data.FillMinutes(ddlSaturMinFr);
                data.FillMinutes(ddlSaturMinT);
                data.FillHours(ddlSunHrFr);
                data.FillHours(ddlSunHrT);
                data.FillMinutes(ddlSunMinFr);
                data.FillMinutes(ddlSunMinT);

            }

            DataTable dtMon = new DataTable();
            dtMon = CreateDataTable();
            Session["dtMonday"] = dtMon;

            DataTable dtTues = new DataTable();
            dtTues = CreateDataTable();
            Session["dtTuesday"] = dtTues;

            DataTable dtWed = new DataTable();
            dtWed = CreateDataTable();
            Session["dtWedday"] = dtWed;

            DataTable dtThurs = new DataTable();
            dtThurs = CreateDataTable();
            Session["dtThursday"] = dtThurs;

            DataTable dtFri = new DataTable();
            dtFri = CreateDataTable();
            Session["dtFriday"] = dtFri;

            DataTable dtSatur = new DataTable();
            dtSatur = CreateDataTable();
            Session["dtSaturday"] = dtSatur;

            DataTable dtSun = new DataTable();
            dtSun = CreateDataTable();
            Session["dtSunday"] = dtSun;
            //Applying validations on dates 
            //con.Open();
            try
            {
                string getdate = "select startmindate=DATEADD(mi,750,GETDATE()), startdatemax=DATEADD(dd,90,DATEADD(mi,750,GETDATE())),enddatemax=DATEADD(dd,365,DATEADD(mi,750,GETDATE())),jobexpdate=DATEADD(dd,60,DATEADD(mi,750,GETDATE()))";
                SqlDataAdapter ada = new SqlDataAdapter(getdate, con);
                DataSet ds = new DataSet();
                ada.Fill(ds);
                //con.Close();
                if (!ds.Tables[0].Rows.Count.Equals(0))
                {
                    string startdatemin = ds.Tables[0].Rows[0]["startmindate"].ToString();
                    string startdatemax = ds.Tables[0].Rows[0]["startdatemax"].ToString();
                    string enddatemax = ds.Tables[0].Rows[0]["enddatemax"].ToString();
                    string jobexpdate = ds.Tables[0].Rows[0]["jobexpdate"].ToString();
                    // Giving max and min values to the range validators at run time
                    rngone.MinimumValue = Convert.ToDateTime(startdatemin).ToShortDateString();
                    rngone.MaximumValue = Convert.ToDateTime(startdatemax).ToShortDateString();
                    rngone.ErrorMessage = " Please select from the date" + " " + Convert.ToDateTime(startdatemin).ToShortDateString() + " To " + Convert.ToDateTime(startdatemax).ToShortDateString();

                }
            }
            catch (Exception ex)
            {
                obj.insert_exception(ex, excep_page);
                Response.Redirect("HttpErrorPage.aspx");
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    /// <summary>
    /// To bind the category dropdownlist
    /// </summary>
    public void BindCatDropdown()
    {
        try
        {
            //con.Open();
            Module_Name = "Category";
            DataSet dsCategory = new DataSet();
            dsCategory = objBd.getDiscountCate(Module_Name);
            ddlCategory.DataSource = dsCategory;
            ddlCategory.DataTextField = "Category";
            ddlCategory.DataValueField = "Category";
            ddlCategory.DataBind();
            ddlCategory.Items.Insert(0, "Select Category");
            //con.Close();
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }

    }
    public void fillSubCategories(string Category_Name)
    {
        try
        {
            DataSet dsSubCat = new DataSet();
            dsSubCat = objBd.GetDiscountSubCate(Category_Name);
            ddlSubcat.DataSource = dsSubCat;
            ddlSubcat.DataValueField = "cat";
            ddlSubcat.DataTextField = "cat";
            ddlSubcat.DataBind();
            ddlSubcat.Items.Insert(0, "Select SubCategory");
            //con.Close();
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }

    }
    /// <summary>
    /// To bind the state dropdownlist
    /// </summary>
    protected void ddlstate_selectedindexchanged(object sender, EventArgs e)
    {
        try
        {
            string statename = ddlstate.SelectedItem.ToString();
            DataSet dsCities = new DataSet();
            dsCities = objBd.GetDiscountCities(statename);
            ddlcity.DataSource = dsCities;
            ddlcity.DataTextField = "city_name";
            ddlcity.DataValueField = "city_name";
            ddlcity.DataBind();
            ddlcity.Items.Insert(0, "select");
           
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }

    }
    /// <summary>
    /// To store the entered data into the database after clicking on post button  
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void post_discount_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            ccjoin.ValidateCaptcha(txtvid.Text);
            // If condition executes when you entered invalid capcha otherwise executes else statements
            if (!ccjoin.UserValidated)
            {
                strScript = "alert('You have to enter as like in the image.');";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                //Inform user that his input was wrong ...
                txtvid.Text = "";
                return;

            }
            else
            {
                try
                {
                    if ((txtmob.Text != "" || txtlandline.Text != "") && txtvid.Text != "")
                    {
                        DataSet ds = new DataSet();
                        string userid = Convert.ToString(Session["USERID"]);

                        int appstatus = 0;
                        string module = "Discounts";
                        string cname = txtcname.Text;
                        string cat = ddlCategory.SelectedItem.ToString();
                        string subcat = ddlSubcat.SelectedItem.ToString();
                        string event_Dur = ddltyp.SelectedItem.ToString();
                        string sdate = "";
                        string edate = "";
                        if (ddltyp.SelectedIndex == 1)
                        {
                            sdate = txtone.Text;
                            txtmulti.Text = "";
                        }
                        else
                        {
                            sdate = txtone.Text;
                            edate = txtmulti.Text;
                        }
                        string descr = txtdes.Text;
                        string addr = txtaddr.Text;
                        string loc = txtlocality.Text;
                        string lanmar = txtlandmark.Text;
                        string time = txttim.Text;
                        string city = ddlcity.SelectedItem.ToString();
                        string state = ddlstate.SelectedItem.ToString();
                        string conper = txtcont.Text;
                        string mob = txtcode.Text + txtmob.Text;
                        string landno = txtlandline.Text;
                        string fax = txtfax.Text;
                        string web = txtweb.Text;
                        string email = txtmail.Text;
                        string pin = txtpin.Text;

                        DateTime pdate = DateTime.Now.Date;
                        DateTime expdate = DateTime.Now.Date.AddDays(Convert.ToDouble(30));

                        ds = obj.insert_post_discount(userid, appstatus, module, cname, cat, subcat, sdate, edate, descr, event_Dur, addr, loc, lanmar, time, city, state, conper, mob, landno, fax, web, email, pdate, expdate, pin);
                        //SendMail(userid);
                        strScript = "alert('Thank you! You have successfully posted the discount.')";
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                        tblpost.Visible = false;
                        trlblintimation.Visible = true;
                        ddlCategory.SelectedIndex = 0;
                        ddlSubcat.SelectedIndex = 0;
                        ddlstate.SelectedIndex = 0;
                        ddlcity.SelectedIndex = 0;
                        //oth.Visible = false;
                        txtaddr.Text = "";
                        txtcname.Text = "";
                        txtcont.Text = "";
                        txtdes.Text = "";
                        ddltyp.SelectedIndex = 0;
                        txtone.Visible = false;
                        txtmulti.Visible = false;
                        txtfax.Text = "";
                        txtlandline.Text = "";
                        txtlandmark.Text = "";
                        txtlocality.Text = "";
                        txtmail.Text = "";
                        txtmob.Text = "";
                        txtpin.Text = "";
                        txttim.Text = "";
                        txtweb.Text = "";
                        txtvid.Text = "";
                    }
                    else
                    {
                        strScript = "alert('Please enter mobile number or landline number')";
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
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }

    }

    /// <summary>
    /// To send the mail to intimate that discount has been posted
    /// </summary>
    /// <param name="userid"></param>
    public void SendMail(string userid)
    {
        try
        {
            string Msg = "";

            MailMessage mm = new MailMessage();
            mm.From = new MailAddress("info@justcalluz.com");
            //mm.To = "test_indus@yahoo.com";
            mm.To.Add(userid);
            Msg += "You have successfully posted the Discount " + "<br>For further details please visit our site www.justcalluz.com or call on +9166136226." +
                        "<br><br>Warm Regards," +
                        "<br> Team JustCalluz"; ;
            mm.Subject = "Intimation about posted Discount";
            mm.IsBodyHtml = true;
            mm.Body = Msg;
            SmtpClient smtp = new SmtpClient();
            smtp.Send(mm);
            //Response.Redirect("Register.aspx?ret=ok");
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }

    }
    //protected void cancel_Click(object sender, ImageClickEventArgs e)
    //{
    //    redirect("Discounts.aspx?cname=discounts", false);
    //}
    protected void btnUploadPhotos_Click1(object sender, ImageClickEventArgs e)
    {
        try
        {
            string userid = Convert.ToString(Session["USERID"]);

            string id;
            dsUserId = objBd.GetUserId(userid);
            id = dsUserId.Tables[0].Rows[0]["id"].ToString();
            SqlCommand cmd = new SqlCommand("InsertPhotos", con);
            cmd.CommandType = CommandType.StoredProcedure;
            if (uploadPhotos.HasFile)
            {
                string imgPhotoName = System.IO.Path.GetFileName(uploadPhotos.PostedFile.FileName);
                DataSet dsphoto = new DataSet();
                dsphoto = data.getPhotoName(imgPhotoName);
                if (!dsphoto.Tables[0].Rows.Count.Equals(0))
                {
                    strScript = "alert('Image name already existed please change Image Name');";
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                }
                else
                {
                    if (uploadPhotos.PostedFile.ContentLength <= 100000)
                    {
                        photoname = Path.GetFileName(uploadPhotos.PostedFile.FileName);
                        photopath = uploadPhotos.PostedFile.ContentType;
                        uploadPhotos.PostedFile.SaveAs(Server.MapPath("../Photos/" + photoname));
                        using (System.Drawing.Image Img = System.Drawing.Image.FromFile(Server.MapPath("../Photos/" + photoname)))
                        {

                            if (Img.Width <= 250 && Img.Height <= 300)
                            {
                                cmd.Parameters.AddWithValue("@PhotoName", photoname);
                                cmd.Parameters.AddWithValue("@PhotoContType", photopath);
                                cmd.Parameters.AddWithValue("dId", SqlDbType.Int).Value = id;
                                cmd.Parameters.AddWithValue("@Caption", DBNull.Value);
                                try
                                {
                                    con.Open();
                                    cmd.ExecuteNonQuery();
                                    strScript = "alert('Photo is uploaded Successfully');";
                                    Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
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

                            }
                            else
                            {
                                strScript = "alert('sorry! Secified Logo cannot be uploaded , make sure that width=250 and height=300.');";
                                Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                            }
                        }
                    }
                    else
                    {
                        strScript = "alert('sorry! Secified Logo cannot be uploaded , make sure that size is lessthan 100kb.');";
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                    }
                }
            }

             moreinfopanel.Visible = true;
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }

    }
    protected void btnskip_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            if (ViewState["previouspage"] != null)
            {
               redirect(ViewState["previouspage"].ToString(),false);
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }

    }
    protected void btnAddMoreInfo_Click1(object sender, ImageClickEventArgs e)
    {
        try
        {
            string userid = Convert.ToString(Session["USERID"]);
            string Did;
            dsUserId = objBd.GetUserId(userid);
            Did = dsUserId.Tables[0].Rows[0]["id"].ToString();

            Conditions();

            data.dMonday = ddlMonday.SelectedItem.Text;
            data.dMon_Dur = MonDur;
            data.dTuesday = ddlTuesday.SelectedItem.Text;
            data.dTues_Dur = TuesDur;
            data.dWednesday = ddlWednesday.SelectedItem.Text;
            data.dWed_Dur = WedDur;
            data.dThursday = ddlThursday.SelectedItem.Text;
            data.dThurs_Dur = ThursDur;
            data.dFriday = ddlFriday.SelectedItem.Text;
            data.dFri_Dur = FriDur;
            data.dSaturday = ddlSaturday.SelectedItem.Text;
            data.dSatur_Dur = SatDur;
            data.dSunday = ddlSunday.SelectedItem.Text;
            data.dSun_Dur = SunDur;
            data.pId = Convert.ToInt32(Did);
            data.dPayment = Payment;
            data.dAdtInfo = txtAdtInfo.Text;
            data.dcertification = txtcertificate.Text;
            data.dNoofEmp = txtemp.Text;
            data.dProf_Accosi = txtprofass.Text;
            data.dYearEstab = ddlyearestablish.SelectedItem.Text;
            data.MoreInfo_Insert(data.dMonday, data.dMon_Dur, data.dTuesday, data.dTues_Dur, data.dWednesday, data.dWed_Dur,
                                data.dThursday, data.dThurs_Dur, data.dFriday, data.dFri_Dur, data.dSaturday, data.dSatur_Dur,
                                data.dSunday, data.dSun_Dur, data.pId, data.dPayment, data.dAdtInfo, data.dYearEstab,
                                data.dProf_Accosi, data.dcertification, data.dNoofEmp);
            string strScript = "";
            strScript = "alert('Your Additional Information is Posted Successfully');location.replace('Discounts-discounts');";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }

    }
    protected void imgbutclickhere_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            tblpost.Visible = false;
            lblintimation.Visible = false;
            moreinfopanel.Visible = true;
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }

    }
    protected void ddltyp_selectedIndexChanged(object sender, EventArgs e)
    {
        try
        {

            if (ddltyp.SelectedIndex == 1)
            {
                txtone.Visible = true;
                txtmulti.Visible = false;
            }
            else
            {
                txtone.Visible = true;
                txtmulti.Visible = true;
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }

    }
    protected void btnUploadLogo_Click1(object sender, ImageClickEventArgs e)
    {
        try
        {
            string userid = Convert.ToString(Session["USERID"]);

            string id;
            dsUserId = objBd.GetUserId(userid);
            id = dsUserId.Tables[0].Rows[0]["id"].ToString();

            SqlCommand cmd = new SqlCommand("UpdateLogoSP", con);
            cmd.CommandType = CommandType.StoredProcedure;
            if (uploadLogo.HasFile)
            {
                imgLogoName = Path.GetFileName(uploadLogo.PostedFile.FileName);
                DataSet dsLogo = new DataSet();
                dsLogo = data.getLogoName(imgLogoName);
                if (!dsLogo.Tables[0].Rows.Count.Equals(0))
                {
                    strScript = "alert('Image name already existed please change Image Name');";
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                }
                else
                {
                    if (uploadLogo.PostedFile.ContentLength <= 30000)
                    {
                        imgLogoName = Path.GetFileName(uploadLogo.PostedFile.FileName);
                        ImgLogoContentType = uploadLogo.PostedFile.ContentType;
                        uploadLogo.PostedFile.SaveAs(Server.MapPath("../Logos/" + imgLogoName));
                        using (System.Drawing.Image Img = System.Drawing.Image.FromFile(Server.MapPath("../Logos/" + imgLogoName)))
                        {

                            if (Img.Width <= 100 && Img.Height <= 75)
                            {
                                cmd.Parameters.AddWithValue("@ImgName", imgLogoName);
                                cmd.Parameters.AddWithValue("@ImgContType", ImgLogoContentType);
                                cmd.Parameters.AddWithValue("@dId", id);
                                try
                                {
                                    con.Open();
                                    cmd.ExecuteNonQuery();
                                    strScript = "alert('Logo is uploaded Successfully');";
                                    Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                                    uploadLogo.Enabled = false;
                                }
                                catch (Exception ex)
                                {
                                    obj.insert_exception(ex, excep_page);
                                    Response.Redirect("HttpErrorPage.aspx");
                                }
                                finally
                                {
                                    cmd.Dispose();
                                    con.Close();
                                }
                            }
                            else
                            {
                                strScript = "alert('sorry! Secified Logo cannot be uploaded , make sure that width=100 and height=75.');";
                                Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                            }
                        }
                    }
                    else
                    {
                        strScript = "alert('sorry! Secified Logo cannot be uploaded , make sure that size is lessthan 30kb.');";
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                    }
                }

            }
            else
            {
                cmd.Parameters.AddWithValue("@ImgName", SqlDbType.NVarChar).Value = 0;
                cmd.Parameters.AddWithValue("@ImgContType", SqlDbType.NVarChar).Value = 0;
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
            }
            moreinfopanel.Visible = true;
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }

    }
    private DataTable CreateDataTable()
    {
        DataTable myDataTable = new DataTable();
        DataColumn myDataColumn;
        myDataColumn = new DataColumn();
        try
        {
            myDataColumn.DataType = Type.GetType("System.Int32");
            myDataColumn.ColumnName = "id";
            myDataTable.Columns.Add(myDataColumn);
            //specify it as auto increment field
            myDataColumn.AutoIncrement = true;
            myDataColumn.AutoIncrementSeed = 1;
            myDataColumn.ReadOnly = true;


            myDataColumn = new DataColumn();
            myDataColumn.DataType = Type.GetType("System.String");
            myDataColumn.ColumnName = "Hr_Fr";
            myDataTable.Columns.Add(myDataColumn);

            myDataColumn = new DataColumn();
            myDataColumn.DataType = Type.GetType("System.String");
            myDataColumn.ColumnName = "Min_Fr";
            myDataTable.Columns.Add(myDataColumn);

            myDataColumn = new DataColumn();
            myDataColumn.DataType = Type.GetType("System.String");
            myDataColumn.ColumnName = "Type_Fr";
            myDataTable.Columns.Add(myDataColumn);

            myDataColumn = new DataColumn();
            myDataColumn.DataType = Type.GetType("System.String");
            myDataColumn.ColumnName = "Hr_T";
            myDataTable.Columns.Add(myDataColumn);

            myDataColumn = new DataColumn();
            myDataColumn.DataType = Type.GetType("System.String");
            myDataColumn.ColumnName = "Min_T";
            myDataTable.Columns.Add(myDataColumn);

            myDataColumn = new DataColumn();
            myDataColumn.DataType = Type.GetType("System.String");
            myDataColumn.ColumnName = "Type_T";
            myDataTable.Columns.Add(myDataColumn);

         }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
        return myDataTable;

    }
    private void AddDataToTable(string Hr_Fr, string Min_Fr, string Type_Fr, string Hr_T, string Min_T, string Type_T, DataTable myTable)
    {
        try
        {
            DataRow row;
            row = myTable.NewRow();

            row["Hr_Fr"] = Hr_Fr;
            row["Min_Fr"] = Min_Fr;
            row["Type_Fr"] = Type_Fr;
            row["Hr_T"] = Hr_T;
            row["Min_T"] = Min_T;
            row["Type_T"] = Type_T;

            myTable.Rows.Add(row);
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }

    }
    protected void lnkMonTimings_Click(object sender, EventArgs e)
    {
        try
        {
            lblLnkMon.Text = "Clicked";
            trLstMon.Visible = true;
            string TimingMon = "";
            AddDataToTable(this.ddlMonHrFr.Text.Trim(), this.ddlMonMinFr.Text.Trim(), this.ddlMonType1.Text.Trim(), this.ddlMonHrT.Text.Trim(), this.ddlMonMinT.Text.Trim(), this.ddlMonType2.Text.Trim(), (DataTable)Session["dtMonday"]);
            DataTable dtMon = ((DataTable)Session["dtMonday"]);
            if (dtMon.Rows.Count > 0)
            {
                for (int i = 0; i < dtMon.Rows.Count; i++)
                {
                    DataRow rowMon = dtMon.Rows[i];
                    string MonHr_Fr = rowMon["Hr_Fr"].ToString();
                    string MonMin_Fr = rowMon["Min_Fr"].ToString();
                    string MonType_Fr = rowMon["Type_Fr"].ToString();
                    string MonHr_T = rowMon["Hr_T"].ToString();
                    string MonMin_T = rowMon["Min_T"].ToString();
                    string MonType_T = rowMon["Type_T"].ToString();
                    TimingMon = MonHr_Fr + " : " + MonMin_Fr + " " + MonType_Fr + " - " + MonHr_T + " : " + MonMin_T + " " + MonType_T;
                }

                lblMonTime.Text += TimingMon + ",";
            }
            string[] strMonArr = TimingMon.Split(separatorcomma);
            foreach (string arrstrrMon in strMonArr)
            {
                ltrMonTime.Text += arrstrrMon + "<br />";
            }
            //Working End
            if (lblMonTime.Text.Length > 119)
            {
                //lnkMonTimings.Enabled = false;
                lnkMonTimings.Disabled = true;
            }
            moreinfopanel.Visible = true;
            trMonDur.Visible = true;
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }


    }
    protected void lnkTuesTimings_Click(object sender, EventArgs e)
    {
        try
        {
            //Working Start
            lblLnkTues.Text = "Clicked";
            trLstTues.Visible = true;
            string TimingTues = "";
            AddDataToTable(this.ddlTuesHrFr.Text.Trim(), this.ddlTuesMinFr.Text.Trim(), this.ddlTuesType1.Text.Trim(), this.ddlTuesHrT.Text.Trim(), this.ddlTuesMinT.Text.Trim(), this.ddlTuesType2.Text.Trim(), (DataTable)Session["dtTuesday"]);
            DataTable dtTues = ((DataTable)Session["dtTuesday"]);
            if (dtTues.Rows.Count > 0)
            {
                for (int i = 0; i < dtTues.Rows.Count; i++)
                {
                    DataRow rowTues = dtTues.Rows[i];
                    string TuesHr_Fr = rowTues["Hr_Fr"].ToString();
                    string TuesMin_Fr = rowTues["Min_Fr"].ToString();
                    string TuesType_Fr = rowTues["Type_Fr"].ToString();
                    string TuesHr_T = rowTues["Hr_T"].ToString();
                    string TuesMin_T = rowTues["Min_T"].ToString();
                    string TuesType_T = rowTues["Type_T"].ToString();
                    TimingTues = TuesHr_Fr + " : " + TuesMin_Fr + " " + TuesType_Fr + " - " + TuesHr_T + " : " + TuesMin_T + " " + TuesType_T;
                }

                lblTuesTime.Text += TimingTues + ",";
            }
            string[] strTuesArr = TimingTues.Split(separatorcomma);
            foreach (string arrstrrTues in strTuesArr)
            {
                ltrTuesTime.Text += arrstrrTues + "<br />";
            }
            //Working End
            if (lblTuesTime.Text.Length > 119)
            {
                lnkTuesTimings.Disabled = true;
            }
            moreinfopanel.Visible = true;
            trTuesDur.Visible = true;
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }

    }
    protected void lnkWedTimings_Click(object sender, EventArgs e)
    {
        try
        {
            //Working Start
            lblLnkWed.Text = "Clicked";
            trLstWed.Visible = true;
            string TimingWed = "";
            AddDataToTable(this.ddlWedHrFr.Text.Trim(), this.ddlWedMinFr.Text.Trim(), this.ddlWedType1.Text.Trim(), this.ddlWedHrT.Text.Trim(), this.ddlWedMinT.Text.Trim(), this.ddlWedType2.Text.Trim(), (DataTable)Session["dtWedday"]);
            DataTable dtWed = ((DataTable)Session["dtWedday"]);
            if (dtWed.Rows.Count > 0)
            {
                for (int i = 0; i < dtWed.Rows.Count; i++)
                {
                    DataRow rowWed = dtWed.Rows[i];
                    string WedHr_Fr = rowWed["Hr_Fr"].ToString();
                    string WedMin_Fr = rowWed["Min_Fr"].ToString();
                    string WedType_Fr = rowWed["Type_Fr"].ToString();
                    string WedHr_T = rowWed["Hr_T"].ToString();
                    string WedMin_T = rowWed["Min_T"].ToString();
                    string WedType_T = rowWed["Type_T"].ToString();
                    TimingWed = WedHr_Fr + " : " + WedMin_Fr + " " + WedType_Fr + " - " + WedHr_T + " : " + WedMin_T + " " + WedType_T;
                }

                lblWedTime.Text += TimingWed + ",";
            }
            string[] strWedArr = TimingWed.Split(separatorcomma);
            foreach (string arrstrrWed in strWedArr)
            {
                ltrWedTime.Text += arrstrrWed + "<br />";
            }
            //Working End
            if (lblWedTime.Text.Length > 119)
            {
                lnkWedTimings.Disabled = true;
            }
            moreinfopanel.Visible = true;
            trWedDur.Visible = true;
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }

    }
    protected void lnkThursTimings_Click(object sender, EventArgs e)
    {
        try
        {
            //Working Start
            lblLnkThurs.Text = "Clicked";
            trLstThurs.Visible = true;
            string TimingThurs = "";
            AddDataToTable(this.ddlThursHrFr.Text.Trim(), this.ddlThursMinFr.Text.Trim(), this.ddlThursType1.Text.Trim(), this.ddlThursHrT.Text.Trim(), this.ddlThursMinT.Text.Trim(), this.ddlThursType2.Text.Trim(), (DataTable)Session["dtThursday"]);
            DataTable dtThurs = ((DataTable)Session["dtThursday"]);
            if (dtThurs.Rows.Count > 0)
            {
                for (int i = 0; i < dtThurs.Rows.Count; i++)
                {
                    DataRow rowThurs = dtThurs.Rows[i];
                    string ThursHr_Fr = rowThurs["Hr_Fr"].ToString();
                    string ThursMin_Fr = rowThurs["Min_Fr"].ToString();
                    string ThursType_Fr = rowThurs["Type_Fr"].ToString();
                    string ThursHr_T = rowThurs["Hr_T"].ToString();
                    string ThursMin_T = rowThurs["Min_T"].ToString();
                    string ThursType_T = rowThurs["Type_T"].ToString();
                    TimingThurs = ThursHr_Fr + " : " + ThursMin_Fr + " " + ThursType_Fr + " - " + ThursHr_T + " : " + ThursMin_T + " " + ThursType_T;
                }

                lblThursTime.Text += TimingThurs + ",";
            }
            string[] strThursArr = TimingThurs.Split(separatorcomma);
            foreach (string arrstrrThurs in strThursArr)
            {
                ltrThursTime.Text += arrstrrThurs + "<br />";
            }
            //Working End
            if (lblThursTime.Text.Length > 119)
            {
                lnkThursTimings.Disabled = true;
            }
            moreinfopanel.Visible = true;
            trThursDur.Visible = true;
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }

    }
    protected void lnkFriTimings_Click(object sender, EventArgs e)
    {
        try
        {
            //Working Start
            lblLnkFri.Text = "Clicked";
            trLstFri.Visible = true;
            string TimingFri = "";
            AddDataToTable(this.ddlFriHrFr.Text.Trim(), this.ddlFriMinFr.Text.Trim(), this.ddlFriType1.Text.Trim(), this.ddlFriHrT.Text.Trim(), this.ddlFriMinT.Text.Trim(), this.ddlFriType2.Text.Trim(), (DataTable)Session["dtFriday"]);
            DataTable dtFri = ((DataTable)Session["dtFriday"]);
            if (dtFri.Rows.Count > 0)
            {
                for (int i = 0; i < dtFri.Rows.Count; i++)
                {
                    DataRow rowFri = dtFri.Rows[i];
                    string FriHr_Fr = rowFri["Hr_Fr"].ToString();
                    string FriMin_Fr = rowFri["Min_Fr"].ToString();
                    string FriType_Fr = rowFri["Type_Fr"].ToString();
                    string FriHr_T = rowFri["Hr_T"].ToString();
                    string FriMin_T = rowFri["Min_T"].ToString();
                    string FriType_T = rowFri["Type_T"].ToString();
                    TimingFri = FriHr_Fr + " : " + FriMin_Fr + " " + FriType_Fr + " - " + FriHr_T + " : " + FriMin_T + " " + FriType_T;
                }

                lblFriTime.Text += TimingFri + ",";
            }
            string[] strFriArr = TimingFri.Split(separatorcomma);
            foreach (string arrstrrFri in strFriArr)
            {
                ltrFriTime.Text += arrstrrFri + "<br />";
            }
            //Working End
            if (lblFriTime.Text.Length > 119)
            {
                lnkFriTimings.Disabled = true;
            }
            moreinfopanel.Visible = true;
            trFriDur.Visible = true;
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }

    }
    protected void lnkSaturTimings_Click(object sender, EventArgs e)
    {
        try
        {
            //Working Start
            lblLnkSatur.Text = "Clicked";
            trLstSatur.Visible = true;
            string TimingSatur = "";
            AddDataToTable(this.ddlSaturHrFr.Text.Trim(), this.ddlSaturMinFr.Text.Trim(), this.ddlSaturType1.Text.Trim(), this.ddlSaturHrT.Text.Trim(), this.ddlSaturMinT.Text.Trim(), this.ddlSaturType2.Text.Trim(), (DataTable)Session["dtSaturday"]);
            DataTable dtSatur = ((DataTable)Session["dtSaturday"]);
            if (dtSatur.Rows.Count > 0)
            {
                for (int i = 0; i < dtSatur.Rows.Count; i++)
                {
                    DataRow rowSatur = dtSatur.Rows[i];
                    string SaturHr_Fr = rowSatur["Hr_Fr"].ToString();
                    string SaturMin_Fr = rowSatur["Min_Fr"].ToString();
                    string SaturType_Fr = rowSatur["Type_Fr"].ToString();
                    string SaturHr_T = rowSatur["Hr_T"].ToString();
                    string SaturMin_T = rowSatur["Min_T"].ToString();
                    string SaturType_T = rowSatur["Type_T"].ToString();
                    TimingSatur = SaturHr_Fr + " : " + SaturMin_Fr + " " + SaturType_Fr + " - " + SaturHr_T + " : " + SaturMin_T + " " + SaturType_T;
                }

                lblSaturTime.Text += TimingSatur + ",";
            }
            string[] strSaturArr = TimingSatur.Split(separatorcomma);
            foreach (string arrstrrSatur in strSaturArr)
            {
                ltrSaturTime.Text += arrstrrSatur + "<br />";
            }
            //Working End
            if (lblSaturTime.Text.Length > 119)
            {
                lnkSaturTimings.Disabled = true;
            }
            moreinfopanel.Visible = true;
            trSatDur.Visible = true;
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }

    }
    protected void lnkSunTimings_Click(object sender, EventArgs e)
    {
        try
        {
            //Working Start

            lblLnkSun.Text = "Clicked";
            trLstSun.Visible = true;
            string TimingSun = "";
            AddDataToTable(this.ddlSunHrFr.Text.Trim(), this.ddlSunMinFr.Text.Trim(), this.ddlSunType1.Text.Trim(), this.ddlSunHrT.Text.Trim(), this.ddlSunMinT.Text.Trim(), this.ddlSunType2.Text.Trim(), (DataTable)Session["dtSunday"]);
            DataTable dtSun = ((DataTable)Session["dtSunday"]);
            if (dtSun.Rows.Count > 0)
            {
                for (int i = 0; i < dtSun.Rows.Count; i++)
                {
                    DataRow rowSun = dtSun.Rows[i];
                    string SunHr_Fr = rowSun["Hr_Fr"].ToString();
                    string SunMin_Fr = rowSun["Min_Fr"].ToString();
                    string SunType_Fr = rowSun["Type_Fr"].ToString();
                    string SunHr_T = rowSun["Hr_T"].ToString();
                    string SunMin_T = rowSun["Min_T"].ToString();
                    string SunType_T = rowSun["Type_T"].ToString();
                    TimingSun = SunHr_Fr + " : " + SunMin_Fr + " " + SunType_Fr + " - " + SunHr_T + " : " + SunMin_T + " " + SunType_T;
                }

                lblSunTime.Text += TimingSun + ",";
            }
            string[] strSunArr = TimingSun.Split(separatorcomma);
            foreach (string arrstrrSun in strSunArr)
            {
                ltrSunTime.Text += arrstrrSun + "<br />";
            }
            //Working End
            if (lblSunTime.Text.Length > 119)
            {
                lnkSunTimings.Disabled = true;
            }
            ltrSunTime.Visible = true;
            moreinfopanel.Visible = true;
            trSunDur.Visible = true;
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }

    }
    protected void ddlMonday_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {

            if (ddlMonday.SelectedItem.Text == "Time Duration")
            {
                trMonDur.Visible = true;
            }
            else
            {
                trMonDur.Visible = false;
            }
            moreinfopanel.Visible = true;
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }

    }
    protected void ddlTuesday_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (ddlTuesday.SelectedItem.Text == "Time Duration")
            {
                trTuesDur.Visible = true;

            }
            else
            {
                trTuesDur.Visible = false;
            }
            moreinfopanel.Visible = true;
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }

    }
    protected void ddlWednesday_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (ddlWednesday.SelectedItem.Text == "Time Duration")
            {
                trWedDur.Visible = true;
            }
            else
            {
                trWedDur.Visible = false;
            }
            moreinfopanel.Visible = true;
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }

    }
    protected void ddlThursday_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (ddlThursday.SelectedItem.Text == "Time Duration")
            {
                trThursDur.Visible = true;
            }
            else
            {
                trThursDur.Visible = false;
            }
            moreinfopanel.Visible = true;
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }

    }
    protected void ddlFriday_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (ddlFriday.SelectedItem.Text == "Time Duration")
            {
                trFriDur.Visible = true;
            }
            else
            {
                trFriDur.Visible = false;
            }
            moreinfopanel.Visible = true;
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }

    }
    protected void ddlSaturday_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (ddlSaturday.SelectedItem.Text == "Time Duration")
            {
                trSatDur.Visible = true;
            }
            else
            {
                trSatDur.Visible = false;
            }
            moreinfopanel.Visible = true;
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }

    }
    protected void ddlSunday_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (ddlSunday.SelectedItem.Text == "Time Duration")
            {
                trSunDur.Visible = true;
            }
            else
            {
                trSunDur.Visible = false;
            }
            moreinfopanel.Visible = true;
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }

    }
    protected void lnkBtnClearSuntimings_Click(object sender, EventArgs e)
    {
        lblSunTime.Text = "";
        ltrSunTime.Text = "";
        trLstSun.Visible = false;
        moreinfopanel.Visible = true;

    }
    protected void lnkBtnClearSatTimings_Click(object sender, EventArgs e)
    {
        lblSaturTime.Text = "";
        ltrSaturTime.Text = "";
        trLstSatur.Visible = false;
        moreinfopanel.Visible = true;
    }
    protected void lnkBtnClearFriTimings_Click(object sender, EventArgs e)
    {
        lblFriTime.Text = "";
        ltrFriTime.Text = "";
        trLstFri.Visible = false;
        moreinfopanel.Visible = true;
    }
    protected void lnkBtnClearThursTimings_Click(object sender, EventArgs e)
    {
        lblThursTime.Text = "";
        ltrThursTime.Text = "";
        trLstThurs.Visible = false;
        moreinfopanel.Visible = true;
    }
    protected void lnkBtnClearWedTimings_Click(object sender, EventArgs e)
    {
        lblWedTime.Text = "";
        ltrWedTime.Text = "";
        trLstWed.Visible = false;
        moreinfopanel.Visible = true;
    }
    protected void lnkBtnClearTuesTimings_Click(object sender, EventArgs e)
    {
        lblTuesTime.Text = "";
        ltrTuesTime.Text = "";
        trLstTues.Visible = false;
        moreinfopanel.Visible = true;
    }
    protected void lnkBtnClearMonTimings_Click(object sender, EventArgs e)
    {
        lblMonTime.Text = "";
        ltrMonTime.Text = "";
        trLstMon.Visible = false;
        moreinfopanel.Visible = true;
    }
    public void Conditions()
    {
        try
        {
            if (ddlMonday.SelectedValue == "Time Duration")
            {
                try
                {
                    trMonDur.Visible = true;
                    if (ltrMonTime.Text == "")
                    {
                        trLstMon.Visible = false;
                    }
                    else
                    {
                        trLstMon.Visible = true;
                    }
                    if (lblMonTime.Text.Length > 30)
                    {
                        lblLnkMon.Text = "Clicked";
                    }
                    if (lblMonTime.Text.Length > 120)
                    {
                        lnkMonTimings.Disabled = true;
                    }
                    if (lblLnkMon.Text == "Clicked")
                    {
                        MonDur = lblMonTime.Text;
                    }
                    else
                    {
                        lblMonTime.Text = ddlMonHrFr.Text + " : " + ddlMonMinFr.Text + " " + ddlMonType1.Text + " - " + ddlMonHrT.Text + " : " + ddlMonMinT.Text + " " + ddlMonType2.Text + ",";
                        MonDur = lblMonTime.Text;
                    }
                }
                catch (Exception ex)
                {
                    obj.insert_exception(ex, excep_page);
                    Response.Redirect("HttpErrorPage.aspx");
                }


            }
            else
            {
                trMonDur.Visible = false;
                trLstMon.Visible = false;
                MonDur = "";
            }
            if (ddlTuesday.SelectedValue == "Time Duration")
            {
                try
                {
                    trTuesDur.Visible = true;
                    if (ltrTuesTime.Text == "")
                    {
                        trLstTues.Visible = false;
                    }
                    else
                    {
                        trLstTues.Visible = true;
                    }
                    if (lblTuesTime.Text.Length > 30)
                    {
                        lblLnkTues.Text = "Clicked";
                    }
                    if (lblTuesTime.Text.Length > 120)
                    {
                        lnkTuesTimings.Disabled = true;
                    }
                    if (lblLnkTues.Text == "Clicked")
                    {
                        TuesDur = lblTuesTime.Text;
                    }
                    else
                    {
                        lblTuesTime.Text = ddlTuesHrFr.Text + " : " + ddlMonMinFr.Text + " " + ddlTuesType1.Text + " - " + ddlTuesHrT.Text + " : " + ddlTuesMinT.Text + " " + ddlTuesType2.Text + ",";
                        TuesDur = lblTuesTime.Text;
                    }
                }
                catch (Exception ex)
                {
                    obj.insert_exception(ex, excep_page);
                    Response.Redirect("HttpErrorPage.aspx");
                }


            }
            else
            {
                trTuesDur.Visible = false;
                trLstTues.Visible = false;
                TuesDur = "";
            }
            if (ddlWednesday.SelectedValue == "Time Duration")
            {
                try
                {
                    trWedDur.Visible = true;
                    if (ltrWedTime.Text == "")
                    {
                        trLstWed.Visible = false;
                    }
                    else
                    {
                        trLstWed.Visible = true;
                    }
                    if (lblWedTime.Text.Length > 30)
                    {
                        lblLnkWed.Text = "Clicked";
                    }
                    if (lblWedTime.Text.Length > 120)
                    {
                        lnkWedTimings.Disabled = true;
                    }
                    if (lblLnkWed.Text == "Clicked")
                    {
                        WedDur = lblWedTime.Text;
                    }
                    else
                    {
                        lblWedTime.Text = ddlWedHrFr.Text + " : " + ddlWedMinFr.Text + " " + ddlWedType1.Text + " - " + ddlWedHrT.Text + " : " + ddlWedMinT.Text + " " + ddlWedType2.Text + ",";
                        WedDur = lblWedTime.Text;
                    }
                }
                catch (Exception ex)
                {
                    obj.insert_exception(ex, excep_page);
                    Response.Redirect("HttpErrorPage.aspx");
                }


            }
            else
            {
                trWedDur.Visible = false;
                trLstWed.Visible = false;
                WedDur = "";
            }
            if (ddlThursday.SelectedValue == "Time Duration")
            {
                try
                {
                    trThursDur.Visible = true;
                    if (ltrThursTime.Text == "")
                    {
                        trLstThurs.Visible = false;
                    }
                    else
                    {
                        trLstThurs.Visible = true;
                    }
                    if (lblThursTime.Text.Length > 30)
                    {
                        lblLnkThurs.Text = "Clicked";
                    }
                    if (lblThursTime.Text.Length > 120)
                    {
                        lnkThursTimings.Disabled = true;
                    }
                    if (lblLnkThurs.Text == "Clicked")
                    {
                        ThursDur = lblThursTime.Text;
                    }
                    else
                    {
                        lblThursTime.Text = ddlThursHrFr.Text + " : " + ddlThursMinFr.Text + " " + ddlThursType1.Text + " - " + ddlThursHrT.Text + " : " + ddlThursMinT.Text + " " + ddlThursType2.Text + ",";
                        ThursDur = lblThursTime.Text;
                    }
                }
                catch (Exception ex)
                {
                    obj.insert_exception(ex, excep_page);
                    Response.Redirect("HttpErrorPage.aspx");
                }


            }
            else
            {
                trThursDur.Visible = false;
                trLstThurs.Visible = false;
                ThursDur = "";
            }
            if (ddlFriday.SelectedValue == "Time Duration")
            {
                try
                {
                    trFriDur.Visible = true;
                    if (ltrFriTime.Text == "")
                    {
                        trLstFri.Visible = false;
                    }
                    else
                    {
                        trLstFri.Visible = true;
                    }
                    if (lblFriTime.Text.Length > 30)
                    {
                        lblLnkFri.Text = "Clicked";
                    }
                    if (lblFriTime.Text.Length > 120)
                    {
                        lnkFriTimings.Disabled = true;
                    }
                    if (lblLnkFri.Text == "Clicked")
                    {
                        FriDur = lblFriTime.Text;
                    }
                    else
                    {
                        lblFriTime.Text = ddlFriHrFr.Text + " : " + ddlFriMinFr.Text + " " + ddlFriType1.Text + " - " + ddlFriHrT.Text + " : " + ddlFriMinT.Text + " " + ddlFriType2.Text + ",";
                        FriDur = lblFriTime.Text;
                    }
                }
                catch (Exception ex)
                {
                    obj.insert_exception(ex, excep_page);
                    Response.Redirect("HttpErrorPage.aspx");
                }


            }
            else
            {
                trFriDur.Visible = false;
                trLstFri.Visible = false;
                FriDur = "";
            }
            if (ddlSaturday.SelectedValue == "Time Duration")
            {
                try
                {
                    trSatDur.Visible = true;
                    if (ltrSaturTime.Text == "")
                    {
                        trLstSatur.Visible = false;
                    }
                    else
                    {
                        trLstSatur.Visible = true;
                    }
                    if (lblSaturTime.Text.Length > 30)
                    {
                        lblLnkSatur.Text = "Clicked";
                    }
                    if (lblSaturTime.Text.Length > 120)
                    {
                        lnkSaturTimings.Disabled = true;
                    }
                    if (lblLnkSatur.Text == "Clicked")
                    {
                        SatDur = lblSaturTime.Text;
                    }
                    else
                    {
                        lblSaturTime.Text = ddlSaturHrFr.Text + " : " + ddlSaturMinFr.Text + " " + ddlSaturType1.Text + " - " + ddlSaturHrT.Text + " : " + ddlSaturMinT.Text + " " + ddlSaturType2.Text + ",";
                        SatDur = lblSaturTime.Text;
                    }
                }
                catch (Exception ex)
                {
                    obj.insert_exception(ex, excep_page);
                    Response.Redirect("HttpErrorPage.aspx");
                }

            }
            else
            {
                trSatDur.Visible = false;
                trLstSatur.Visible = false;
                SatDur = "";
            }
            if (ddlSunday.SelectedValue == "Time Duration")
            {
                try
                {
                    trSunDur.Visible = true;
                    if (ltrSunTime.Text == "")
                    {
                        trLstSun.Visible = false;
                    }
                    else
                    {
                        trLstSun.Visible = true;
                    }
                    if (lblSunTime.Text.Length > 30)
                    {
                        lblLnkSun.Text = "Clicked";
                    }
                    if (lblSunTime.Text.Length > 120)
                    {
                        lnkSunTimings.Disabled = true;
                    }
                    if (lblLnkSun.Text == "Clicked")
                    {
                        SunDur = lblSunTime.Text;
                    }
                    else
                    {
                        lblSunTime.Text = ddlSunHrFr.Text + " : " + ddlSunMinFr.Text + " " + ddlSunType1.Text + " - " + ddlSunHrT.Text + " : " + ddlSunMinT.Text + " " + ddlSunType2.Text + ",";
                        SunDur = lblSunTime.Text;
                    }
                }
                catch (Exception ex)
                {
                    obj.insert_exception(ex, excep_page);
                    Response.Redirect("HttpErrorPage.aspx");
                }

            }
            else
            {
                trSunDur.Visible = false;
                trLstSun.Visible = false;
                SunDur = "";
            }

            for (int i = 0; i < modecheck.Items.Count; i++)
            {
                if (modecheck.Items[i].Selected == true)
                {
                    Payment += modecheck.Items[i].Text + ",";
                }

            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }

    }
    protected void imgbutnothanks_Click(object sender, ImageClickEventArgs e)
    {

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
    protected void ddlCategory_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (ddlCategory.SelectedIndex != 0)
            {
                Categoty_Name = Convert.ToString(ddlCategory.SelectedValue);
                trSubcat.Visible = true;
                fillSubCategories(Categoty_Name);
            }
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
