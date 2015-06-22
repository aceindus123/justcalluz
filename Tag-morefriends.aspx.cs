using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Collections;
using System.Drawing;
using System.Net.Mail;

public partial class Tag_morefriends : System.Web.UI.Page
{
    string strscript = string.Empty;
    int reg_id;
    string username = string.Empty;
    string FrdMobile = string.Empty;
    ArrayList arryFemails = new ArrayList();
    ArrayList arryFname= new ArrayList();
    string FrdEmail = string.Empty;
    SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    DataSet dsFrdMobile=new DataSet();
    DataSet dsFriends = new DataSet();
    DataSet dsFriendsnames = new DataSet();
    SSCS obj1 = new SSCS();
    List<string> Listfrids = new List<string> { };
    ArrayList Listnamesndrates = new ArrayList();
   // List<string> Listnamesndrates = new List<string> { };
    int count;
    DataSet dstagfrndchk = new DataSet();
    DataSet ds_tag = new DataSet();
    DataSet dsfratings = new DataSet();
    DataSet dsfratings1 = new DataSet();
    DataTable dtfrate = new DataTable();
    string ResultString = string.Empty;
    int freg_id;
    InsertData obj = new InsertData();
    static string excep_page = "Tag-morefriends.aspx";
    PagedDataSource pdspage = new PagedDataSource();
    protected void Page_Load(object sender, EventArgs e)
    {
       // lbluname.Text = Convert.ToString(Page.RouteData.Values["uname"].ToString());
        reg_id = Convert.ToInt32(Page.RouteData.Values["tagid"].ToString());
        dsFriends = obj1.tag_Friends(reg_id);
        DataSet ds_logindetails = obj1.tag_Loginmob(reg_id);
        if (ds_logindetails.Tables[0].Rows.Count > 0)
        {
            Session["USERID"] = Convert.ToString(ds_logindetails.Tables[0].Rows[0]["email"]);
            Session["PASSWORD"] = Convert.ToString(ds_logindetails.Tables[0].Rows[0]["password"]);
            Session["mobile"] = Convert.ToString(ds_logindetails.Tables[0].Rows[0]["mob"]);
            lbluname.Text = Convert.ToString(ds_logindetails.Tables[0].Rows[0]["name"]);

        }
        if (!dsFriends.Tables[0].Rows.Count.Equals(0))
        {
            for (int index = 0; index < dsFriends.Tables[0].Rows.Count; index++)
            {
                if (Convert.ToString(dsFriends.Tables[0].Rows[index]["friend_mobile"])!="")
                {
                    Listfrids.Add(obj1.tagFriends_rid(Convert.ToString(dsFriends.Tables[0].Rows[index]["friend_mobile"])));
                }
                txtmyname.Text = Convert.ToString(lbluname.Text);
                txtmymobile.Text = Convert.ToString(ds_logindetails.Tables[0].Rows[0]["mob"]);
            }
            for (int index1 = 0; index1 < Listfrids.Count; index1++)
            {
                ResultString += Listfrids[index1] + ",";
            }
        }
       ResultString = ResultString.Substring(0, ResultString.Length - 1);
       // ResultString = ResultString.Substring(ResultString.Length - 1,1);

        dsfratings = obj1.tag_fratingsCount(ResultString);
        if (dsfratings.Tables.Count > 0 && dsfratings.Tables[0].Rows.Count > 0)
        {
            pdspage.DataSource = dsfratings.Tables[0].DefaultView;
            pdspage.AllowPaging = true;
            pdspage.PageSize = 4;
            dlFriendReview.DataSource = pdspage;
            dlFriendReview.DataBind();
        }

    }   
    protected void btnFinish_Click(object sender, EventArgs e)
    {
        try
        {
            if (txtmbl1.Text != "" || txtmbl2.Text != "" || txtmbl3.Text != "" || txtmbl4.Text != "" || txtmbl5.Text != "")
            {
                FrdEmail = "";
                if (txtmbl1.Text != "")
                {
                    arryFemails.Add(txtmbl1.Text);
                }
                if (txtmbl2.Text != "")
                {
                    arryFemails.Add(txtmbl2.Text);
                }
                if (txtmbl3.Text != "")
                {
                    arryFemails.Add(txtmbl3.Text);
                }
                if (txtmbl4.Text != "")
                {
                    arryFemails.Add(txtmbl4.Text);
                }
                if (txtmbl5.Text != "")
                {
                    arryFemails.Add(txtmbl5.Text);
                }

                for (int i = 0; i < arryFemails.Count; i++)
                {
                    dsFrdMobile = obj1.tag_mob(arryFemails[i].ToString());
                    reg_id = Convert.ToInt32(Page.RouteData.Values["tagid"].ToString());
                    SqlCommand cmd = new SqlCommand("tag_friends", sqlConnection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@friend_mobile", arryFemails[i]);
                    cmd.Parameters.AddWithValue("@friend_Email", FrdEmail);
                    cmd.Parameters.AddWithValue("@regid", reg_id);
                    cmd.Parameters.AddWithValue("@postdate", System.DateTime.Now.ToString());
                    sqlConnection.Open();
                    cmd.ExecuteNonQuery();
                    sqlConnection.Close();
                }

                strscript = "alert('Thank you to tag your friends');location.replace('Tagmorefriends-" + reg_id + "');";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "alertbox", strscript, true);
                txtmbl1.Text = "";
                txtmbl2.Text = "";
                txtmbl3.Text = "";
                txtmbl4.Text = "";
                txtmbl5.Text = "";

            }
            else
            {
                strscript = "alert('You havent tagged any one yet.Please click ok to continue.');";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "alertbox", strscript, true);
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void txtmbl1_TextChanged(object sender, EventArgs e)
    {
        try
        {
            reg_id = Convert.ToInt32(Page.RouteData.Values["tagid"].ToString());
            lblmessage.Visible = true;
            if (txtmbl1.Text == Convert.ToString(Session["mobile"]))
            {
                lblmessage.Text = "Cannot tag your own number";
                txtmbl1.Text = "";
                lblmessage.ForeColor = Color.Red;
                trlblbox1.Visible = false;
                trtxtbox1.Visible = true;
            }
            else
            {
                dsFrdMobile = obj1.tag_mob(txtmbl1.Text);
                dstagfrndchk = obj1.tag_CheckFriendsmobile(txtmbl1.Text, reg_id);

                ds_tag = obj1.tag_mob(txtmbl1.Text);
                if (dstagfrndchk.Tables[0].Rows.Count.Equals(0))
                {
                    if (!dsFrdMobile.Tables[0].Rows.Count.Equals(0))
                    {
                        lblmessage.Text = "Existed";
                        lblmessage.ForeColor = Color.Green;
                        trlblbox1.Visible = true;
                        trtxtbox1.Visible = false;

                        if (!ds_tag.Tables[0].Rows.Count.Equals(0))
                        {

                            lblname1.Text = Convert.ToString(ds_tag.Tables[0].Rows[0]["rname"]);
                        }
                    }
                    else
                    {
                        lblmessage.Text = "Not Existed";
                        txtmbl1.Text = "";
                        lblmessage.ForeColor = Color.Red;
                        trlblbox1.Visible = false;
                        trtxtbox1.Visible = true;
                        //strscript = "alert('Number not found');";
                        //Page.ClientScript.RegisterStartupScript(this.GetType(), "alertbox", strscript, true);

                    }
                }
                else
                {
                    lblmessage.Text = "Already tagged";
                    txtmbl1.Text = "";
                    lblmessage.ForeColor = Color.Blue;
                    trlblbox1.Visible = false;
                    trtxtbox1.Visible = true;
                    //strscript = "alert('This number already tagged you');";
                    //Page.ClientScript.RegisterStartupScript(this.GetType(), "alertbox", strscript, true);
                }
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void txtmbl2_TextChanged(object sender, EventArgs e)
    {
        try
        {
            reg_id = Convert.ToInt32(Page.RouteData.Values["tagid"].ToString());
            lblmessage1.Visible = true;
            if (txtmbl2.Text == Convert.ToString(Session["mobile"]))
            {
                lblmessage1.Text = "Cannot tag your own number";
                txtmbl2.Text = "";
                lblmessage1.ForeColor = Color.Red;
                trlblbox2.Visible = false;
                trtxtbox2.Visible = true;
            }
            else
            {
                dstagfrndchk = obj1.tag_CheckFriendsmobile(txtmbl1.Text, reg_id);
                ds_tag = obj1.tag_mob(txtmbl2.Text);
                if (dstagfrndchk.Tables[0].Rows.Count.Equals(0))
                {
                    dsFrdMobile = obj1.tag_mob(txtmbl2.Text);
                    if (!dsFrdMobile.Tables[0].Rows.Count.Equals(0))
                    {
                        lblmessage1.Text = "Existed";
                        lblmessage1.ForeColor = Color.Green;
                        trlblbox2.Visible = true;
                        trtxtbox2.Visible = false;

                        if (!ds_tag.Tables[0].Rows.Count.Equals(0))
                        {

                            lblname2.Text = Convert.ToString(ds_tag.Tables[0].Rows[0]["rname"]);
                        }
                    }
                    else
                    {
                        lblmessage1.Text = "Not Existed";
                        lblmessage1.ForeColor = Color.Red;
                        trlblbox2.Visible = false;
                        trtxtbox2.Visible = true;
                        txtmbl2.Text = "";
                    }
                }
                else
                {
                    lblmessage1.Text = "Already tagged";
                    lblmessage1.ForeColor = Color.Blue;
                    trlblbox2.Visible = false;
                    trtxtbox2.Visible = true;
                    txtmbl2.Text = "";
                }
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void txtmbl3_TextChanged(object sender, EventArgs e)
    {
        try { 
        reg_id = Convert.ToInt32(Page.RouteData.Values["tagid"].ToString());
        lblmessage2.Visible = true;
        if (txtmbl3.Text == Convert.ToString(Session["mobile"]))
        {
            lblmessage2.Text = "Cannot tag your own number";
            txtmbl3.Text = "";
            lblmessage2.ForeColor = Color.Red;
            trlblbox3.Visible = false;
            trtxtbox3.Visible = true;
        }
        else
        {
            dstagfrndchk = obj1.tag_CheckFriendsmobile(txtmbl3.Text, reg_id);
            ds_tag = obj1.tag_mob(txtmbl3.Text);
            if (dstagfrndchk.Tables[0].Rows.Count.Equals(0))
            {
                dsFrdMobile = obj1.tag_mob(txtmbl1.Text);
                if (!dsFrdMobile.Tables[0].Rows.Count.Equals(0))
                {
                    lblmessage2.Text = "Existed";
                    trlblbox3.Visible = true;
                    lblmessage2.ForeColor = Color.Green;
                    trtxtbox3.Visible = false;

                    if (!ds_tag.Tables[0].Rows.Count.Equals(0))
                    {

                        lblname3.Text = Convert.ToString(ds_tag.Tables[0].Rows[0]["rname"]);
                    }
                }
                else
                {
                    lblmessage2.Text = "Not Existed";
                    lblmessage2.ForeColor = Color.Red;
                    trlblbox3.Visible = false;
                    trtxtbox3.Visible = true;
                    txtmbl3.Text = "";
                }
            }
            else
            {
                lblmessage2.Text = "Already tagged";
                lblmessage2.ForeColor = Color.Blue;
                trlblbox3.Visible = false;
                trtxtbox3.Visible = true;
                txtmbl3.Text = "";
            }
        }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void txtmbl4_TextChanged(object sender, EventArgs e)
    {
        try { 
        reg_id = Convert.ToInt32(Page.RouteData.Values["tagid"].ToString());
        lblmessage3.Visible = true;
        if (txtmbl4.Text == Convert.ToString(Session["mobile"]))
        {
            lblmessage3.Text = "Cannot tag your own number";
            txtmbl4.Text = "";
            lblmessage.ForeColor = Color.Red;
            trlblbox4.Visible = false;
            trtxtbox4.Visible = true;
        }
        else
        {
            dsFrdMobile = obj1.tag_mob(txtmbl1.Text);
            dstagfrndchk = obj1.tag_CheckFriendsmobile(txtmbl4.Text, reg_id);
            ds_tag = obj1.tag_mob(txtmbl4.Text);
            if (dstagfrndchk.Tables[0].Rows.Count.Equals(0))
            {
                if (!dsFrdMobile.Tables[0].Rows.Count.Equals(0))
                {
                    lblmessage3.Text = "Existed";
                    lblmessage3.ForeColor = Color.Green;
                    trlblbox4.Visible = true;
                    trtxtbox4.Visible = false;

                    if (!ds_tag.Tables[0].Rows.Count.Equals(0))
                    {

                        lblname4.Text = Convert.ToString(ds_tag.Tables[0].Rows[0]["rname"]);
                    }
                }
                else
                {
                    lblmessage3.Text = "Not Existed";
                    lblmessage3.ForeColor = Color.Red;
                    trlblbox4.Visible = false;
                    trtxtbox4.Visible = true;
                    txtmbl4.Text = "";
                }
            }
            else
            {
                lblmessage3.Text = "Already tagged";
                lblmessage3.ForeColor = Color.Blue;
                trlblbox4.Visible = false;
                trtxtbox4.Visible = true;
                txtmbl4.Text = "";
            }
        }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void txtmbl5_TextChanged(object sender, EventArgs e)
    {
        try { 
        reg_id = Convert.ToInt32(Page.RouteData.Values["tagid"].ToString());
        lblmessage4.Visible = true;
        if (txtmbl1.Text == Convert.ToString(Session["mobile"]))
        {
            lblmessage4.Text = "Cannot tag your own number";
            txtmbl5.Text = "";
            lblmessage4.ForeColor = Color.Red;
            trlblbox5.Visible = false;
            trtxtbox5.Visible = true;
        }
        else
        {
            dsFrdMobile = obj1.tag_mob(txtmbl1.Text);
            dstagfrndchk = obj1.tag_CheckFriendsmobile(txtmbl5.Text, reg_id);
            ds_tag = obj1.tag_mob(txtmbl5.Text);
            if (dstagfrndchk.Tables[0].Rows.Count.Equals(0))
            {
                if (!dsFrdMobile.Tables[0].Rows.Count.Equals(0))
                {
                    lblmessage4.Text = "Existed";
                    lblmessage4.ForeColor = Color.Green;
                    trlblbox5.Visible = true;
                    trtxtbox5.Visible = false;

                    if (!ds_tag.Tables[0].Rows.Count.Equals(0))
                    {

                        lblname5.Text = Convert.ToString(ds_tag.Tables[0].Rows[0]["rname"]);
                    }
                }
                else
                {
                    lblmessage4.Text = "Not Existed";
                    lblmessage4.ForeColor = Color.Red;
                    trlblbox5.Visible = false;
                    trtxtbox5.Visible = true;
                    txtmbl5.Text = "";
                }
            }
            else
            {
                lblmessage4.Text = "Already tagged";
                lblmessage4.ForeColor = Color.Blue;
                trlblbox5.Visible = false;
                trtxtbox5.Visible = true;
                txtmbl5.Text = "";
            }
        }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void btnsendinvitation_Click(object sender, EventArgs e)
    {
        try
        {
            reg_id = Convert.ToInt32(Page.RouteData.Values["tagid"].ToString());

            if (txtfriendname.Text != "" && txtfriendmail.Text != "" || txtfriendname1.Text != "" && txtfriendmail1.Text != "" || txtfriendname2.Text != "" && txtfriendmail2.Text != "" || txtfriendname3.Text != "" && txtfriendmail3.Text != "")
            {

                if (txtfriendname.Text != "" && txtfriendmail.Text != "")
                {
                    arryFemails.Add( txtfriendmail.Text);
                   arryFname.Add(txtfriendname.Text);
                }
                if (txtfriendname1.Text != "" && txtfriendmail1.Text != "")
                {
                    arryFemails.Add(txtfriendmail1.Text);
                    arryFname.Add(txtfriendname1.Text);
                }
                if (txtfriendname2.Text != "" && txtfriendmail2.Text != "")
                {
                    arryFemails.Add(txtfriendmail2.Text);
                    arryFname.Add(txtfriendname2.Text);
                }
                if (txtfriendname3.Text != "" && txtfriendmail3.Text != "")
                {
                    arryFemails.Add(txtfriendmail3.Text);
                    arryFname.Add(txtfriendname3.Text);
                }
               for (int i = 0; i < arryFemails.Count; i++)
                {
                    SqlCommand cmd = new SqlCommand("insert_invited_friendsdetails", sqlConnection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@friend_Email", arryFemails[i]);
                    cmd.Parameters.AddWithValue("@friend_name", arryFname[i]);
                    cmd.Parameters.AddWithValue("@regid", reg_id);
                    cmd.Parameters.AddWithValue("@postdate", System.DateTime.Now.ToString());
                    sqlConnection.Open();
                    cmd.ExecuteNonQuery();
                    sqlConnection.Close();
                    SendInvitationToFriend(arryFname[i].ToString(), arryFemails[i].ToString(), txtmyname.Text, Convert.ToString(Session["USERID"]));
                    strscript = "alert('Thank you.An email invitation has been sent to the friend/friends selected by you! ');";
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "alertbox", strscript, true);
                }
            }
            else
            {
                strscript = "alert('Please fill the Required fields.');";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "alertbox", strscript, true);
                MPEDisplayInvitation.Show();
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    private void SendInvitationToFriend(string fname,string femail,string Lname,string Lemail)
    {

        string Msg = "";
        try
        {
            try
            {
               
                string siteurl = "http://www.justcalluz.com";
                 MailMessage mm = new MailMessage();
                mm.From = new MailAddress(Lemail);
                //mm.CC.Add("info@justcalluz.com");
                mm.To.Add(femail);

                Msg += "Dear " + fname + ",";

                Msg += "<br><br> Your friend has sent you a request. If you are a registered Justcalluz member, then you can accept the request and get to know ratings and reviews on restaurants, theatres, clothing and accessories, Smartphone’s from your tagged friends. If you are not a registered member of Justcalluz, then register now. <br>" +
                       "<br><br>Please login or register using this link " + siteurl + 
                       "<br><br>Warm Regards," +
                       "<br> Just Call Uz Team";

                mm.Subject = "Just Call Uz Send invitation";
                mm.IsBodyHtml = true;
                mm.Body = Msg;
                SmtpClient smtp = new SmtpClient();
                smtp.Send(mm);


            }
            catch (Exception ex1)
            {
                obj.insert_exception(ex1, excep_page);
                Response.Redirect("HttpErrorPage.aspx");
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void FriendsRatings(object sender, CommandEventArgs e)
    {
        try
        {
            reg_id = Convert.ToInt32(Page.RouteData.Values["tagid"].ToString());
            freg_id = Convert.ToInt32(e.CommandArgument.ToString());
            Response.RedirectToRoute("tag_friendsRatings", new { reg_rateid = freg_id, loginid = reg_id });
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void dlFriendReview_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        try
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {

            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    protected void lnkShowallfrnds_Click(object sender, EventArgs e)
    {
        reg_id = Convert.ToInt32(Page.RouteData.Values["tagid"].ToString());
        Response.RedirectToRoute("Show_more", new {loginid = reg_id });
    }
    protected void lnkclickhereforInvitation_Click(object sender, EventArgs e)
    {
        MPEDisplayInvitation.Show();

    }
    protected void btnclose_Click(object sender, EventArgs e)
    {
        MPEDisplayInvitation.Hide();
    }
}