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
using JustCallUsData.Data;
/// <summary>
/// Class to post sponsored links
/// </summary>
public partial class admin_Admin_ToPostSponsoredLinks : System.Web.UI.Page
{
    string UserId;
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    DataCS data = new DataCS();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            UserId = Convert.ToString(Session["LogInId"]);
            ddlcat.Enabled = false;
            trbanner.Visible = false;
            //lnkchange.Visible = false;
            if (UserId != "")
            {
                // it will stays in the same page
            }

            else
            {
                //After login into the account it will go Post ad
                Response.Redirect("Default.aspx");

            }
        }
    }
    /// <summary>
    /// Function to post sponsored links
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnPostSponLinks_Click(Object sender, EventArgs e)
    {
        try
        {
            DateTime theDate = DateTime.Now;
            DateTime theExpDate = DateTime.Now.Date.AddDays(Convert.ToDouble(30));
            //string format = "d MMM yyyy";
            string format = "dd/MM/yyyy";
            string Post_Date = theDate.ToString(format);
            string Expire_Date = theExpDate.ToString(format);

            string str = "Insert Into sponseredlinks(heading,heading1,website,PostDate,ExpireDate,module,ad_type,ad_img,ad_img_cnt,sponser_name,contact_no,categories) values(@cmp_name,@Addess,@WebSite,@PostDate,@ExpiredDate,@module,@ad_type,@ad_img,@ad_img_cnt,@sponser_name,@contact_no,@categories)";
            con.Open();
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.Parameters.AddWithValue("@cmp_name", txtspcmp.Text);
            cmd.Parameters.AddWithValue("@Addess", txtAddress.Text);
            cmd.Parameters.AddWithValue("@WebSite", txtWebsite.Text);
            cmd.Parameters.AddWithValue("@PostDate", Post_Date);
            cmd.Parameters.AddWithValue("@ExpiredDate", Expire_Date);
            cmd.Parameters.AddWithValue("@module", ddlmod.SelectedItem.Text);
            if (ddladtype.SelectedItem.Text == "Banner ads")
            {
                cmd.Parameters.AddWithValue("@ad_type", ddladtype.SelectedItem.Text);
                if (bnr.HasFile)
                {
                    if (bnr.PostedFile.ContentLength <= 100000)
                    {
                        string imgName = System.IO.Path.GetFileName(bnr.PostedFile.FileName);
                        bnr.PostedFile.SaveAs(Server.MapPath("~/Banner_Images/" + imgName));
                        using (System.Drawing.Image Imgsp = System.Drawing.Image.FromFile(Server.MapPath("~/Banner_Images/" + imgName)))
                        {
                            if (Imgsp.Width <= 160 & Imgsp.Height <= 230)
                            {
                                //string Strimg = bnr.PostedFile.FileName;
                                imgName = System.IO.Path.GetFileName(bnr.PostedFile.FileName);
                                string imgContentType = bnr.PostedFile.ContentType;
                                cmd.Parameters.AddWithValue("@ad_img", imgName);
                                cmd.Parameters.AddWithValue("@ad_img_cnt", imgContentType);
                                bnr.Enabled = false;
                                //lnkchange.Visible = true;
                            }
                            else
                            {
                                string stralert = "alert('Make sure that width and height of the banner should be <= 140 and 40');";
                                Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", stralert, true);
                            }
                        }
                    }
                    else
                    {
                        string stralert = "alert('content length should be lessthan 20kb');";
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", stralert, true);
                    }
                }
                else
                {
                    string stralert = "alert('Please Upload Banner');";
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", stralert, true);
                }
            }
            else
            {
                cmd.Parameters.AddWithValue("@ad_type", ddladtype.SelectedItem.Text);
                cmd.Parameters.AddWithValue("@ad_img", "");
                cmd.Parameters.AddWithValue("@ad_img_cnt", "");
            }

            cmd.Parameters.AddWithValue("@sponser_name", txtSponLink.Text);
            cmd.Parameters.AddWithValue("@contact_no", txtno.Text);
            if (ddlcat.SelectedItem.Text != "")
                cmd.Parameters.AddWithValue("@categories", ddlcat.SelectedItem.Text);
            else
                cmd.Parameters.AddWithValue("@categories", "");
            cmd.ExecuteNonQuery();
            con.Close();
            txtAddress.Text = "";
            txtno.Text = "";
            txtspcmp.Text = "";
            txtSponLink.Text = "";
            txtWebsite.Text = "";
            ddlcat.SelectedIndex = 0;
            ddlmod.SelectedIndex = 0;
            ddladtype.SelectedIndex = 0;

            string strScript = "";
            strScript = "alert('Your SponsoredAd data is Posted Successfully'); location.replace('Admin_SponsoredLinks.aspx');";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
        }
        catch (Exception ex)
        {

        }

    }

    protected void ddlmod_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlmod.SelectedIndex != 0)
        {
            ddlcat.Enabled = true;
            if (ddlmod.SelectedValue == "B2B Category")
            {
                string Module_Name = Convert.ToString(ddlmod.SelectedValue);
                DataCS data = new DataCS();
                //To bind Categories
                data.FillB2BCategory(ddlcat);
            }
            else if (ddlmod.SelectedValue == "LifeStyle")
            {
                data.FillLifeStyleCategory(ddlcat);
            }
            else if (ddlmod.SelectedValue == "Movies")
            {
                ddlcat.Items.Clear();
                ddlcat.Items.Add(new ListItem("Select Category", "Select Category"));
                ddlcat.Items.Add(new ListItem("Entertainment", "Entertainment"));
            }
            //else if (ddlmod.SelectedValue == "Movies")
            //{
            //    ddlcat.Items.Clear();
            //    ddlcat.Items.Add(new ListItem("Select Category", "Select Category"));
            //    ddlcat.Items.Add(new ListItem("Entertainment", "Entertainment"));
            //}
            else
            {
                string Module_Name = Convert.ToString(ddlmod.SelectedValue);
                fillCategories(Module_Name);
            }
        }
        else
        {
            ddlcat.Items.Clear();
            ddlcat.Items.Insert(0, "Select Category");
        }

    }
    protected void ddladtype_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddladtype.SelectedItem.Text == "Banner ads")
        {
            trbanner.Visible = true;
        }
        else
        {
            trbanner.Visible = false;
        }
    }
    public void fillCategories(string Module_Name)
    {
        try
        {
            string Connection = ConfigurationManager.AppSettings["ConnectionString"];
            SqlConnection oCon = new SqlConnection(Connection);
            //if (Module_Name == "Discounts")
            //{
            //    Module_Name = "Category";
            //}
            //else
            //{
            //}
            string s = "(select Category from Categories where Module= '" + Module_Name + "') except (select Category from Categories where Category='Movies') order by Category";
            SqlCommand cmd = new SqlCommand(s, oCon);
            oCon.Open();
            SqlDataAdapter da = new SqlDataAdapter(s, oCon);
            DataSet ds = new DataSet();
            da.Fill(ds, "Category");
            ddlcat.DataSource = ds.Tables["Category"];
            ddlcat.DataValueField = "Category";
            ddlcat.DataTextField = "Category";
            ddlcat.DataBind();
            ddlcat.Items.Insert(0, "Select Category");
            oCon.Close();
        }
        // To catch exception
        catch (Exception ex)
        {
            //lblMessage.Text = ex.Message.ToString();
        }
    }
    //protected void lnkchange_Click(object sender, EventArgs e)
    //{

    //}
}
