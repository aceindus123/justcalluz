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
using System.Web.Routing;

//using JustCallUsData.Data;

public partial class post_lifestyle : System.Web.UI.Page
{
    
    string Str;
    bool t;
    DataCS data = new DataCS();
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    string strScript = string.Empty;
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
    string VideoName;
    string VideoContentType;
    InsertData obj = new InsertData();
    static string excep_page = "post_lifestyle.aspx";
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
            string regtype = Convert.ToString(Session["RegType"]);
            //trsubcat.Visible = false;
            try
            {
                if (userid != "" && regtype == "Business")
                {

                }

                else if (userid != "" && regtype == "Individual")
                {

                    //redirect("AuthenticationMsg.aspx?msg=LifeStyle",false);
                     Response.RedirectToRoute("AuthenticationMsg", new { msg = "LifeStyle" });

                }

                else
                    //redirect("signin.aspx?Qname=LifeStyle",false);
                    Response.RedirectToRoute("Signin", new { Qname = "LifeStyle" });

            }
            catch (Exception ex)
            {
                obj.insert_exception(ex, excep_page);
                Response.Redirect("HttpErrorPage.aspx");
            }

            if (!IsPostBack)
            {
                try
                {
                    Bindcatdropdown();
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

                    //ViewState["previouspage"] = Request.UrlReferrer;
                    //Bindcatdropdown();
                    //Bindstatedropdown();
                    //bindyear();
                }
                catch (Exception ex)
                {
                    obj.insert_exception(ex, excep_page);
                    Response.Redirect("HttpErrorPage.aspx");
                }

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
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }

    /// <summary>
    /// To bind the category dropdownlist from the database
    /// </summary>

    protected void Bindcatdropdown()
    {
        try
        {
           
            SqlDataAdapter da = new SqlDataAdapter("select * from subcatageory where maincat='LifeStyle'", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            ddlcat.DataSource = ds;
            ddlcat.DataTextField = "cat";
            ddlcat.DataValueField = "id";
            ddlcat.DataBind();
            ddlcat.Items.Insert(0, "select");
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
        

    }
    //protected void bindyear()
    //{
    //    try
    //    {
    //        con.Open();
    //        SqlDataAdapter da = new SqlDataAdapter("select * from CompanyEstablished", con);
    //        DataSet ds = new DataSet();
    //        da.Fill(ds);
    //        con.Close();
    //        ddlyearestablish.DataSource = ds;
    //        ddlyearestablish.DataTextField = "yearEstablished";
    //        ddlyearestablish.DataValueField = "yearEstablished";
    //        ddlyearestablish.DataBind();
    //        ddlyearestablish.Items.Insert(0, "select");
    //    }
    //    catch (Exception ex)
    //    {
    //        obj.insert_exception(ex, excep_page);
    //        Response.Redirect("HttpErrorPage.aspx");
    //    }
    //}

    /// <summary>
    /// To bind the state dropdownlist from the database
    /// </summary>
    //protected void Bindstatedropdown()
    //{
    //    try
    //    {
    //        con.Open();
    //        SqlDataAdapter da = new SqlDataAdapter("select state_name from states", con);
    //        DataSet ds = new DataSet();
    //        da.Fill(ds);
    //        con.Close();
    //        ddlstate.DataSource = ds;
    //        ddlstate.DataTextField = "state_name";
    //        ddlstate.DataValueField = "state_name";
    //        ddlstate.DataBind();
    //        ddlstate.Items.Insert(0, "select");
    //        ddlcity.Items.Insert(0, "select");
    //    }
    //    catch (Exception ex)
    //    {
    //        obj.insert_exception(ex, excep_page);
    //        Response.Redirect("HttpErrorPage.aspx");
    //    }

    //}

    protected void ddlstate_selectedindexchanged(object sender, EventArgs e)
    {
        try
        {
            ddlcity.Enabled = true;
            string statename = ddlstate.SelectedItem.ToString();
            
            SqlDataAdapter da = new SqlDataAdapter("select city_name from cities where state_name='" + statename + "'", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
         
            ddlcity.DataSource = ds;
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

    protected void ddlcat_selectedindexchanged(object sender, EventArgs e)
    {
        try
        {

            string catg = ddlcat.SelectedItem.ToString();
           SqlDataAdapter da = new SqlDataAdapter("Select subcategeory from LifeStyle where categeory='" + catg + "'", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "LifeStyle");
            if (!ds.Tables[0].Rows.Count.Equals(0))
            {
                trsubcat.Visible = true;
                ddlsubcat.DataSource = ds.Tables["LifeStyle"];
                ddlsubcat.DataTextField = "subcategeory";
                ddlsubcat.DataValueField = "subcategeory";
                ddlsubcat.DataBind();
                ddlsubcat.Items.Insert(0, new ListItem("select", "0"));
            }
            else
            {
                trsubcat.Visible = false;
                ddlstate.Enabled = true;
            }
           
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }


    /// <summary>
    /// To store the posted event into the database
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>

    protected void postbtn_Click(object sender, ImageClickEventArgs e)
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
               string userid = Convert.ToString(Session["USERID"]);

                    string cat = ddlcat.SelectedItem.ToString();
                    DateTime pdate = DateTime.Now.Date;
                    SqlCommand cmd = new SqlCommand("post_LifeStyle", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@module", SqlDbType.NVarChar).Value = "LifeStyle";
                    cmd.Parameters.AddWithValue("@UserLoginId", SqlDbType.NVarChar).Value = userid;
                    cmd.Parameters.AddWithValue("@Category", ddlcat.SelectedItem.ToString());
                    try
                    {
                        if (ddlsubcat.SelectedValue == "")
                        {
                            cmd.Parameters.AddWithValue("@SubCategory", SqlDbType.NVarChar).Value = "null";
                            cmd.Parameters.AddWithValue("@catsub", SqlDbType.NVarChar).Value = "null";
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@SubCategory", ddlsubcat.SelectedItem.ToString());
                            cmd.Parameters.AddWithValue("@catsub", SqlDbType.NVarChar).Value = cat + "-" + ddlsubcat.SelectedItem.ToString();
                        }
                    }
                    catch (Exception ex)
                    {
                        obj.insert_exception(ex, excep_page);
                        Response.Redirect("HttpErrorPage.aspx");
                    }
                    cmd.Parameters.AddWithValue("@State", ddlstate.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@City", ddlcity.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Area", txtarea.Text);
                    cmd.Parameters.AddWithValue("@company_name", txtevename.Text);
                    cmd.Parameters.AddWithValue("@address", txtadd.Text);
                    cmd.Parameters.AddWithValue("@land_mark", txtlndm.Text);
                    cmd.Parameters.AddWithValue("@mob", txtcode.Text + txtmob.Text);
                    cmd.Parameters.AddWithValue("@landphno", txtph.Text);
                    cmd.Parameters.AddWithValue("@fax", txtfax.Text);
                    cmd.Parameters.AddWithValue("@Website", txtweb.Text);
                    cmd.Parameters.AddWithValue("@ApprovedStatus", SqlDbType.Int).Value = 0;
                    cmd.Parameters.AddWithValue("@contact_person", txtcntp.Text);
                    cmd.Parameters.AddWithValue("@emailid", txtemail.Text);
                    cmd.Parameters.AddWithValue("@pincode", txtpin.Text);
                    cmd.Parameters.AddWithValue("@postdate", SqlDbType.DateTime).Value = pdate;
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
                        con.Close();
                    }
                   SendMail(userid);
                    strScript = "alert('Thank you! You have successfully posted the LifeStyle.');";
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);

                    tblpost.Visible = false;
                    trlblintimation.Visible = true;

                    ddlcat.SelectedIndex = 0;
                    ddlsubcat.Visible = false;
                    ddlstate.SelectedIndex = 0;
                    ddlcity.SelectedIndex = 0;
                    txtarea.Text = "";
                    txtcntp.Text = "";
                    txtevename.Text = "";
                    txtemail.Text = "";
                    txtfax.Text = "";
                    txtmob.Text = "";
                    txtph.Text = "";
                    txtpin.Text = "";
                    txtweb.Text = "";
                    txtvid.Text = "";
                    txtadd.Text = "";
                    txtlndm.Text = "";
                }
            

        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    

    /// <summary>
    /// sending a mail to the corresponding authenticated user to intimate about the posted event
    /// </summary>
    /// <param name="userid"></param>
    public void SendMail(string userid)
    {

        string Msg = "";

        try
        {

            MailMessage mm = new MailMessage();
            mm.From = new MailAddress("info@justcalluz.com");
            //mm.To = "test_indus@yahoo.com";
            mm.To.Add(userid);
            Msg += "You have successfully posted the LifeStyle , Please wait for the approval " + "<br>For further details please visit our site www.justcalluz.com or call on +9166136226." +
                        "<br><br>Warm Regards," +
                        "<br> Team JustCalluz"; ;
            mm.Subject = "Intimation about posted LifeStyle";
            mm.IsBodyHtml = true;
            mm.Body = Msg;
            SmtpClient smtp = new SmtpClient();
            smtp.Send(mm);
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }


        //Response.Redirect("Register.aspx?ret=ok");

    }


    protected void cancel_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            //redirect("Lifestylehome.aspx",false);
            Response.RedirectToRoute("LifeStyle_home", new { cat = "null", cname = "LifeStyle" });
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void ddlsubcat_selectedindexchanged(object sender, EventArgs e)
    {
        try
        {
            trsubcat.Visible = true;
            ddlstate.Enabled = true;
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    //protected void btnUploadLogo_Click(object sender, EventArgs e)
    //{
    //    string userid = Convert.ToString(Session["USERID"]);
    //    con.Open();
    //    string id;
    //    SqlDataAdapter da = new SqlDataAdapter("select top 1 id,UserLoginId from modulesdata where UserLoginId='" + userid + "' order by id desc", con);
    //    DataSet ds = new DataSet();
    //    da.Fill(ds);
    //    id = ds.Tables[0].Rows[0]["id"].ToString();
        
    //    SqlCommand cmd = new SqlCommand("update modulesdata set ImageName=@ImageName,ImagecontentType=@ImageContentType where id='" + id + "'", con);
    //    if (uploadLogo.HasFile)
    //    {
    //        if (uploadLogo.PostedFile.ContentLength <= 30000)
    //        {
    //            string filename = System.IO.Path.GetFileName(uploadLogo.PostedFile.FileName);
    //            string contenttype = uploadLogo.PostedFile.ContentType;
    //            uploadLogo.PostedFile.SaveAs(Server.MapPath("Logos/" + filename));
    //            using (System.Drawing.Image Img = System.Drawing.Image.FromFile(Server.MapPath("Logos/" + filename)))
    //            {

    //                if (Img.Width <= 100 && Img.Height <= 75)
    //                {
    //                    cmd.Parameters.AddWithValue("@ImageName", filename);
    //                    cmd.Parameters.AddWithValue("@ImageContentType", contenttype);
    //                    cmd.ExecuteNonQuery();
    //                    con.Close();
    //                }
    //                else
    //                {
    //                    strScript = "alert('sorry! Secified Logo can't be uploaded , make sure that width=100 and height=75.');";
    //                    Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
    //                }
    //            }
    //        }
    //        else
    //        {
    //            strScript = "alert('sorry! Secified Logo can't be uploaded , make sure that size is lessthan 30kb.');";
    //            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
    //        }
    //    }
    //    else
    //    {
    //        cmd.Parameters.AddWithValue("@ImageName", SqlDbType.NVarChar).Value = "Null";
    //        cmd.Parameters.AddWithValue("@ImageContentType", SqlDbType.NVarChar).Value = "Null";
    //        cmd.ExecuteNonQuery();
    //        con.Close();
    //    }
    //    moreinfopanel.Visible = true;
    //    uploadLogo.Enabled = false;

                   
    //}
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
    protected void lnkBtnClearSuntimings_Click(object sender, EventArgs e)
    {
        try
        {
            lblSunTime.Text = "";
            ltrSunTime.Text = "";
            trLstSun.Visible = false;
            moreinfopanel.Visible = true;
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }

    }
    protected void lnkBtnClearSatTimings_Click(object sender, EventArgs e)
    {
        try
        {
            lblSaturTime.Text = "";
            ltrSaturTime.Text = "";
            trLstSatur.Visible = false;
            moreinfopanel.Visible = true;
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void lnkBtnClearFriTimings_Click(object sender, EventArgs e)
    {
        try
        {
            lblFriTime.Text = "";
            ltrFriTime.Text = "";
            trLstFri.Visible = false;
            moreinfopanel.Visible = true;
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void lnkBtnClearThursTimings_Click(object sender, EventArgs e)
    {
        try
        {
            lblThursTime.Text = "";
            ltrThursTime.Text = "";
            trLstThurs.Visible = false;
            moreinfopanel.Visible = true;
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void lnkBtnClearWedTimings_Click(object sender, EventArgs e)
    {
        try
        {
            lblWedTime.Text = "";
            ltrWedTime.Text = "";
            trLstWed.Visible = false;
            moreinfopanel.Visible = true;
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void lnkBtnClearTuesTimings_Click(object sender, EventArgs e)
    {
        try
        {
            lblTuesTime.Text = "";
            ltrTuesTime.Text = "";
            trLstTues.Visible = false;
            moreinfopanel.Visible = true;
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void lnkBtnClearMonTimings_Click(object sender, EventArgs e)
    {
        try
        {
            lblMonTime.Text = "";
            ltrMonTime.Text = "";
            trLstMon.Visible = false;
            moreinfopanel.Visible = true;
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
   
   
    //protected void btnUploadPhotos_Click(object sender, EventArgs e)
    //{
    //    string userid = Convert.ToString(Session["USERID"]);
    //    con.Open();
    //    string id;
    //    SqlDataAdapter da = new SqlDataAdapter("select top 1 id,UserLoginId from modulesdata where UserLoginId='" + userid + "' order by id desc", con);
    //    DataSet ds = new DataSet();
    //    da.Fill(ds);
    //    id = ds.Tables[0].Rows[0]["id"].ToString();
    //    SqlCommand cmd = new SqlCommand("insert into photos(PhotoName,PhotoContentType,dataid) values(@PhotoName,@PhotoContentType,@dataid)", con);
    //    if (uploadPhotos.HasFile)
    //    {
    //        if (uploadPhotos.PostedFile.ContentLength <= 100000)
    //        {
    //            string filename = System.IO.Path.GetFileName(uploadPhotos.PostedFile.FileName);
    //            string contenttype = uploadPhotos.PostedFile.ContentType;
    //            uploadPhotos.PostedFile.SaveAs(Server.MapPath("Photos/" + filename));
    //            using (System.Drawing.Image Img = System.Drawing.Image.FromFile(Server.MapPath("Photos/" + filename)))
    //            {

    //                if (Img.Width <= 250 && Img.Height <= 300)
    //                {
    //                    cmd.Parameters.AddWithValue("@PhotoName", filename);
    //                    cmd.Parameters.AddWithValue("@PhotoContentType", contenttype);
    //                    cmd.Parameters.AddWithValue("dataid", SqlDbType.Int).Value = id;
    //                    cmd.ExecuteNonQuery();
    //                    con.Close();
    //                }
    //                else
    //                {
    //                    strScript = "alert('sorry! Secified Logo can't be uploaded , make sure that width=250 and height=300.');";
    //                    Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
    //                }
    //            }
    //        }
    //        else
    //        {
    //            strScript = "alert('sorry! Secified Logo can't be uploaded , make sure that size is lessthan 100kb.');";
    //            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
    //        }
    //    }

    //    con.Close();
    //    moreinfopanel.Visible = true;
        
    //}
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
                //TuesDur = ddlTuesHrFr.Text + " : " + ddlTuesMinFr.Text + " am - " + ddlTuesHrT.Text + " : " + ddlTuesMinT.Text + " T";
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
                //WedDur = ddlWedHrFr.Text + " : " + ddlWedMinFr.Text + " am - " + ddlWedHrT.Text + " : " + ddlWedMinT.Text + " T";
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
                //ThursDur = ddlThursHrFr.Text + " : " + ddlThursMinFr.Text + " am - " + ddlThursHrT.Text + " : " + ddlThursMinT.Text + " T";
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
                //FriDur = ddlFriHrFr.Text + " : " + ddlFriMinFr.Text + " am - " + ddlFriHrT.Text + " : " + ddlFriMinT.Text + " T";
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
                //SatDur = ddlSaturHrFr.Text + " : " + ddlSaturMinFr.Text + " am - " + ddlSaturHrT.Text + " : " + ddlSaturMinT.Text + " T";
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
                //SunDur = ddlSunHrFr.Text + " : " + ddlSunMinFr.Text + " am - " + ddlSunHrT.Text + " : " + ddlSunMinT.Text + " T";
            }
            else
            {
                trSunDur.Visible = false;
                trLstSun.Visible = false;
                SunDur = "";
            }
            //for (int i = 0; i < lstBoxPayment.Items.Count; i++)      // Select Multiple items from Listbox
            //{
            //    if (lstBoxPayment.Items[i].Selected == true)
            //    {
            //        Payment += lstBoxPayment.Items[i].Text + ",";
            //    }
            //}
            for (int i = 0; i < modecheck.Items.Count; i++)
            {
                try
                {
                    if (modecheck.Items[i].Selected == true)
                    {
                        Payment += modecheck.Items[i].Text + ",";
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
    protected void btnAddMoreInfo_Click1(object sender, ImageClickEventArgs e)
    {
        try
        {
            string userid = Convert.ToString(Session["USERID"]);
            string Did;
            SqlDataAdapter da = new SqlDataAdapter("select top 1 id,UserLoginId from modulesdata where UserLoginId='" + userid + "' order by id desc", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            Did = ds.Tables[0].Rows[0]["id"].ToString();

            Conditions();

            data.dMonday = ddlMonday.SelectedValue;
            data.dMon_Dur = MonDur;
            data.dTuesday = ddlTuesday.SelectedValue;
            data.dTues_Dur = TuesDur;
            data.dWednesday = ddlWednesday.SelectedValue;
            data.dWed_Dur = WedDur;
            data.dThursday = ddlThursday.SelectedValue;
            data.dThurs_Dur = ThursDur;
            data.dFriday = ddlFriday.SelectedValue;
            data.dFri_Dur = FriDur;
            data.dSaturday = ddlSaturday.SelectedValue;
            data.dSatur_Dur = SatDur;
            data.dSunday = ddlSunday.SelectedValue;
            data.dSun_Dur = SunDur;
            data.pId = Convert.ToInt32(Did);
            data.dPayment = Payment;
            data.dAdtInfo = txtAdtInfo.Text;
            data.dcertification = txtcertificate.Text;
            data.dNoofEmp = txtemp.Text;
            data.dProf_Accosi = txtprofass.Text;
            data.dYearEstab = ddlyearestablish.SelectedValue;
            data.MoreInfo_Insert(data.dMonday, data.dMon_Dur, data.dTuesday, data.dTues_Dur, data.dWednesday, data.dWed_Dur,
                                data.dThursday, data.dThurs_Dur, data.dFriday, data.dFri_Dur, data.dSaturday, data.dSatur_Dur,
                                data.dSunday, data.dSun_Dur, data.pId, data.dPayment, data.dAdtInfo, data.dYearEstab,
                                data.dProf_Accosi, data.dcertification, data.dNoofEmp);
            string strScript = "";
            strScript = "alert('Your Additional Information is Posted Successfully');location.replace('LifeStyle');";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
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
           // con.Open();
            string id;
            SqlDataAdapter da = new SqlDataAdapter("select top 1 id,UserLoginId from modulesdata where UserLoginId='" + userid + "' order by id desc", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            id = ds.Tables[0].Rows[0]["id"].ToString();

            SqlCommand cmd = new SqlCommand("update modulesdata set ImageName=@ImageName,ImagecontentType=@ImageContentType where id='" + id + "'", con);
            if (uploadLogo.HasFile)
            {
                if (uploadLogo.PostedFile.ContentLength <= 30000)
                {
                    string filename = System.IO.Path.GetFileName(uploadLogo.PostedFile.FileName);
                    string contenttype = uploadLogo.PostedFile.ContentType;
                    uploadLogo.PostedFile.SaveAs(Server.MapPath("../Logos/" + filename));
                    try
                    {
                        using (System.Drawing.Image Img = System.Drawing.Image.FromFile(Server.MapPath("../Logos/" + filename)))
                        {

                            if (Img.Width <= 100 && Img.Height <= 75)
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
                                    con.Close();
                                }

                                strScript = "alert('Thank you! You have successfully uploaded the logo');";
                                Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                                //con.Close();
                            }
                            else
                            {
                                strScript = "alert('sorry! Secified Logo cannot be uploaded , make sure that width=100 and height=75.');";
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
                else
                {
                    strScript = "alert('sorry! Secified Logo cannot be uploaded , make sure that size is lessthan 30kb.');";
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                }
            }
            else
            {
                cmd.Parameters.AddWithValue("@ImageName", SqlDbType.NVarChar).Value = 0;
                cmd.Parameters.AddWithValue("@ImageContentType", SqlDbType.NVarChar).Value = 0;
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
                    con.Close();
                }
            }
            moreinfopanel.Visible = true;
            uploadLogo.Enabled = false;
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }

                   
    }
    protected void btnUploadPhotos_Click1(object sender, ImageClickEventArgs e)
    {
        try
        {
            string userid = Convert.ToString(Session["USERID"]);
            //con.Open();
            string id;
            SqlDataAdapter da = new SqlDataAdapter("select top 1 id,UserLoginId from modulesdata where UserLoginId='" + userid + "' order by id desc", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            id = ds.Tables[0].Rows[0]["id"].ToString();
            SqlDataAdapter daphoto = new SqlDataAdapter("select count(dataid) as count from photos where dataid=" + id, con);
            DataSet dsphoto = new DataSet();
            daphoto.Fill(dsphoto);
            int count = Convert.ToInt32(dsphoto.Tables[0].Rows[0]["count"]);
            if (count < 5)
            {
                SqlCommand cmd = new SqlCommand("insert into photos(PhotoName,PhotoContentType,dataid) values(@PhotoName,@PhotoContentType,@dataid)", con);
                if (uploadPhotos.HasFile)
                {
                    if (uploadPhotos.PostedFile.ContentLength <= 100000)
                    {
                        string filename = System.IO.Path.GetFileName(uploadPhotos.PostedFile.FileName);
                        string contenttype = uploadPhotos.PostedFile.ContentType;
                        uploadPhotos.PostedFile.SaveAs(Server.MapPath("../Photos/" + filename));
                        try
                        {
                            using (System.Drawing.Image Img = System.Drawing.Image.FromFile(Server.MapPath("../Photos/" + filename)))
                            {

                                if (Img.Width <= 250 && Img.Height <= 300)
                                {
                                    cmd.Parameters.AddWithValue("@PhotoName", filename);
                                    cmd.Parameters.AddWithValue("@PhotoContentType", contenttype);
                                    cmd.Parameters.AddWithValue("dataid", SqlDbType.Int).Value = id;
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
                                        con.Close();
                                    }
                                    strScript = "alert('Thank you! You have successfully uploaded the photo');";
                                    Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                                 }
                                else
                                {
                                    strScript = "alert('sorry! Secified photo cannot be uploaded , make sure that width=250 and height=300.');";
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
                    else
                    {
                        strScript = "alert('sorry! Secified photo cannot be uploaded , make sure that size is lessthan 100kb.');";
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                    }
                }
            }
            else
            {
                strScript = "alert('sorry! You can upload only five photos . so , kindly delete some existing photos inorder to upload new photos');";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
            }

            //con.Close();
            moreinfopanel.Visible = true;
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
        
    }
    protected void btnUploadVideos_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            string userid = Convert.ToString(Session["USERID"]);
            //con.Open();
            string id;
            SqlDataAdapter da = new SqlDataAdapter("select top 1 id,UserLoginId from modulesdata where UserLoginId='" + userid + "' order by id desc", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            id = ds.Tables[0].Rows[0]["id"].ToString();
            if (uploadVideos.HasFile)
            {
                string fileExt = System.IO.Path.GetExtension(uploadVideos.FileName);

                //if (fileExt == ".avi")
                //{
                try
                {
                    VideoName = System.IO.Path.GetFileName(uploadVideos.PostedFile.FileName);
                    uploadVideos.PostedFile.SaveAs(Server.MapPath("../Videos/" + VideoName));
                    //uploadVedios.SaveAs("~/Videos/" + System.IO.Path.GetFileName(uploadVedios.PostedFile.FileName));
                    //VideoName = System.IO.Path.GetFileName(uploadVedios.PostedFile.FileName);
                    VideoContentType = uploadVideos.PostedFile.ContentType;
                    data.dImgName = VideoName;
                    data.dImgContType = VideoContentType;
                    data.pId = Convert.ToInt32(id);
                    t = data.Vedio_Insert(data.pId, data.dImgName, data.dImgContType);
                    strScript = "alert('Video is uploaded Successfully');location.replace('LifeStyle-LifeStyle-" + id + "');";//('edit_LifeStyle.aspx?did=" + id + "');";
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
                }
                catch (Exception ex)
                {
                    obj.insert_exception(ex, excep_page);
                    Response.Redirect("HttpErrorPage.aspx");
                }
                //catch (Exception ex)
                //{
                //    lblException.Text = "ERROR: " + ex.Message.ToString();
                //}
                //}
                //else
                //{
                //    lblException.Text = "Only .avi files allowed!";
                //}
            }
            else
            {
                Label1.Text = "You have not specified a file.";
            }
            //con.Close();
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
    protected void imgbutnothanks_Click(object sender, ImageClickEventArgs e)
    {

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


