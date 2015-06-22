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
using System.Security.Cryptography;
using System.Text;
using System.Web.Routing;

public partial class MyProfile : System.Web.UI.Page
{ //To make connection
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    DataSet dsUserProfile = new DataSet();
    InsertData obj = new InsertData();
    static string excep_page = "MyProfile.aspx";
    string uid = string.Empty;
    /// <summary>
    /// executes whenever page loads
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            //UnicodeEncoding ByteConverter = new UnicodeEncoding();

           string uid1 = Convert.ToString(Page.RouteData.Values["uid"]);
           uid = Convert.ToString(Session["USERID"]);
            //RSACryptoServiceProvider myRsa = new RSACryptoServiceProvider();
            //byte[] se = ByteConverter.GetBytes(userid);
            ////byte[] messageBytes = Encoding.Unicode.GetBytes(userid);
            ////byte[] encryptedMessage = myRsa.Encrypt(messageBytes, false);
            //byte[] decryptedBytes = myRsa.Decrypt(Convert.FromBase64String(userid), false);
            //string uid = Convert.ToString(Encoding.Unicode.GetString(decryptedBytes));
             SqlDataAdapter ada = new SqlDataAdapter("select * from register where email='" + uid + "'", con);//uid
             ////SqlDataAdapter ada = new SqlDataAdapter("select * from register where name='" + uid + "'", con);//uid
             //To fill the dataset
            ada.Fill(dsUserProfile, "UserProfile");
            // To get the values from dataset and assigned them to strings
            if (!dsUserProfile.Tables[0].Rows.Count.Equals(0))
            {
                try
                {
                    string BName = dsUserProfile.Tables[0].Rows[0]["bname"].ToString();
                    string KOB = dsUserProfile.Tables[0].Rows[0]["kindofbusiness"].ToString();
                    string BDesc = dsUserProfile.Tables[0].Rows[0]["des"].ToString();
                    string FName = dsUserProfile.Tables[0].Rows[0]["name"].ToString();
                    string LName = dsUserProfile.Tables[0].Rows[0]["LastName"].ToString();
                    string Email = dsUserProfile.Tables[0].Rows[0]["email"].ToString();
                    string City = dsUserProfile.Tables[0].Rows[0]["city"].ToString();
                    string State = dsUserProfile.Tables[0].Rows[0]["state"].ToString();
                    string WebSite = dsUserProfile.Tables[0].Rows[0]["website"].ToString();
                    string Address = dsUserProfile.Tables[0].Rows[0]["addr"].ToString();
                    string LandMark = dsUserProfile.Tables[0].Rows[0]["landmark"].ToString();
                    string Mob = dsUserProfile.Tables[0].Rows[0]["mob"].ToString();
                    string Ph = dsUserProfile.Tables[0].Rows[0]["landline"].ToString();
                    string Fax = dsUserProfile.Tables[0].Rows[0]["fax"].ToString();
                    string PinCode = dsUserProfile.Tables[0].Rows[0]["PinCode"].ToString();
                    string RegType = dsUserProfile.Tables[0].Rows[0]["RegType"].ToString();

                    lblName.Text = FName + " " + LName;
                    lblEmail.Text = Email;
                    if (Address != "")
                    {
                        lblAddress.Text = Address;
                    }
                    else
                    {
                        lblAddress.Text = "--- Nill ---";
                    }
                    if (LandMark != "")
                    {
                        lblLandMark.Text = LandMark;
                    }
                    else
                    {
                        lblLandMark.Text = "--- Nill ---";
                    }
                    lblCity.Text = City;
                    lblState.Text = State;
                    lblPincode.Text = PinCode;
                    lblMobNo.Text = Mob;
                    if (Ph != "")
                    {
                        lblPhNo.Text = Ph;
                    }
                    else
                    {
                        lblPhNo.Text = "--- Nill ---";
                    }
                    if (Fax != "")
                    {
                        lblFax.Text = Fax;
                    }
                    else
                    {
                        lblFax.Text = "--- Nill ---";
                    }
                    lblKOB.Text = KOB;
                    lblBname.Text = BName;
                    lblBdesc.Text = BDesc;
                    if (WebSite != "")
                    {
                        lblWebsite.Text = WebSite;
                    }
                    else
                    {
                        lblWebsite.Text = "--- Nill ---";
                    }

                    if (RegType == "Individual")
                    {
                        trPerInfo.Visible = false;
                        trAdres.Visible = false;
                        trbName.Visible = false;
                        trBusDesc.Visible = false;
                        trCity.Visible = true;
                        trEmail.Visible = true;
                        trFax.Visible = false;
                        trHeadBus.Visible = false;
                        trKOB.Visible = false;
                        trLmark.Visible = false;
                        trMobNo.Visible = true;
                        trName.Visible = true;
                        trPhNo.Visible = false;
                        trPincode.Visible = true;
                        trState.Visible = true;
                        trURL.Visible = false;
                    }
                    else if (RegType == "Business")
                    {
                        trPerInfo.Visible = true;
                        trAdres.Visible = true;
                        trbName.Visible = true;
                        trBusDesc.Visible = true;
                        trCity.Visible = true;
                        trEmail.Visible = true;
                        trFax.Visible = true;
                        trHeadBus.Visible = true;
                        trKOB.Visible = true;
                        trLmark.Visible = true;
                        trMobNo.Visible = true;
                        trName.Visible = true;
                        trPhNo.Visible = true;
                        trPincode.Visible = true;
                        trState.Visible = true;
                        trURL.Visible = true;
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
    /// To edit the profile
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lnkBtnProfileEdit_Click(object sender, EventArgs e)
    {
        try
        {
            uid = Convert.ToString(Page.RouteData.Values["uid"]);
            if (Session["USERID"] != null)
            {
                //redirect("ProfileEdit.aspx?id=" + uid,false);
                Response.RedirectToRoute("ProfileEdit", new { id = uid });
            }
            else
            {
                string strScript = "";
                strScript = "alert('Your session is expired. Please Relogin');location.replace('signin');";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "alertbox", strScript, true);
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
    /// <summary>
    /// Function to change password
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lnkBtnChangePW_Click(object sender, EventArgs e)
    {
        try
        {
            if (Session["USERID"] != null)
            {
                Response.RedirectToRoute("ChangePassword");
            }
            else
            {
                string strScript = "";
                strScript = "alert('Your session is expired. Please Relogin');location.replace('signin');";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "alertbox", strScript, true);
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }
    }
   
}
