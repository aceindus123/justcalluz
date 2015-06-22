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
/// Class to edit sponsored links
/// </summary>
public partial class admin_Admin_SponsoredLinksEdit : System.Web.UI.Page
{
    //To make connection
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    DataCS data = new DataCS();
    SqlDataReader dr;
    Int16 SId = 0;
    string UserId;
    static string mod, cat, ad_type; 
    /// <summary>
    /// Executes whenever page loads
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Page_Load(object sender, EventArgs e)
    {
        UserId = Convert.ToString(Session["LogInId"]);
        if (UserId != "")
        {
            // it will stays in the same page
        }

        else
        {
            //After login into the account it will go Post ad
            Response.Redirect("Default.aspx");

        }
        SId=Convert.ToInt16(Request.QueryString["Id"]);
        //To get Data from the database without pospacking the values
        if(!Page.IsPostBack)
        {
            
            con.Open();
            string str = "select * from sponseredlinks where id=" + SId;
            SqlCommand cmd = new SqlCommand(str, con);
            dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                txtspcmp.Text = Convert.ToString(dr["heading"]);
                txtSponLink.Text = Convert.ToString(dr["sponser_name"]);
                txtno.Text = Convert.ToString(dr["contact_no"]);
                txtAddress.Text = Convert.ToString(dr["heading1"]);
                txtWebsite.Text = Convert.ToString(dr["website"]);
                mod = Convert.ToString(dr["module"]);
                cat = Convert.ToString(dr["categories"]);
                ad_type = Convert.ToString(dr["ad_type"]);
            }
            if (ad_type == "Banner ads")
            {
                trbanner.Visible = true;
            }
            else
            {
                trbanner.Visible = false;
            }
            for (int i = 0; i < ddladtype.Items.Count; i++)
            {
                if (ddladtype.Items[i].Text == ad_type)
                {
                    ddladtype.SelectedItem.Text = ad_type;
                    break;
                }
            }
            for (int i = 0; i < ddlmod.Items.Count; i++)
            {
                if (ddlmod.Items[i].Text == mod)
                {
                    ddlmod.SelectedItem.Text = mod;
                    break;
                }
            }
            fillCategories(mod);
            for (int i = 0; i < ddlcat.Items.Count; i++)
            {
                if (ddlcat.Items[i].Text == cat)
                {
                    ddlcat.SelectedItem.Text = cat;
                    break;
                }
            }
            con.Close();
        }
    }
    /// <summary>
    /// Function to update sponsored links
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnUpdateSponLinks_Click(object sender, EventArgs e)
    {
        if (ddladtype.SelectedItem.Text == "Banner ads")
        {
            if (bnr.HasFile)
            {
                if (bnr.PostedFile.ContentLength <= 30000)
                {
                    string imgName = System.IO.Path.GetFileName(bnr.PostedFile.FileName);
                    bnr.PostedFile.SaveAs(Server.MapPath("~/Banner_Images/" + imgName));
                    using (System.Drawing.Image Imgsp = System.Drawing.Image.FromFile(Server.MapPath("~/Banner_Images/" + imgName)))
                    {
                        if (Imgsp.Width <= 200 & Imgsp.Height <= 60)
                        {
                            //string Strimg = bnr.PostedFile.FileName;
                            imgName = System.IO.Path.GetFileName(bnr.PostedFile.FileName);
                            string imgContentType = bnr.PostedFile.ContentType;
                            update_ad(imgName, imgContentType);
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
            update_ad("", "");
        }
    }
    protected void update_ad(string imagename,string img_content)
    {
        string str1 = "Update sponseredlinks set heading='" + txtspcmp.Text + "', heading1='" + txtAddress.Text + "', website='" + txtWebsite.Text + "', sponser_name='" + txtSponLink.Text + "', contact_no='" + txtno.Text + "', module='" + ddlmod.SelectedItem.Text + "', ad_type='" + ddladtype.SelectedItem.Text + "', categories='" + ddlcat.SelectedItem.Text + "', ad_img='" + imagename + "', ad_img_cnt='" + img_content + "' where id=" + SId;
        con.Open();
        SqlCommand cmd1 = new SqlCommand(str1, con);
        cmd1.ExecuteNonQuery();
        con.Close();
        string stralert = "alert('you have successfully updated the ad');location.replace('Admin_SponsoredLinks.aspx');";
        Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", stralert, true);
        //Response.Redirect("Admin_SponsoredLinks.aspx");
    }
    /// <summary>
    /// Function to cancel update
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnCancelUpdate_Click(object sender, EventArgs e)
    {
        Response.Redirect("Admin_SponsoredLinks.aspx");
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
            else if (ddlmod.SelectedValue == "Movies")
            {
                ddlcat.Items.Clear();
                ddlcat.Items.Add(new ListItem("Select Category", "Select Category"));
                ddlcat.Items.Add(new ListItem("Entertainment", "Entertainment"));
            }
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
    public void fillCategories(string Module_Name)
    {
        try
        {
            string Connection = ConfigurationManager.AppSettings["ConnectionString"];
            SqlConnection oCon = new SqlConnection(Connection);
            if (Module_Name == "Discounts")
            {
                Module_Name = "Category";
            }
            else
            {
            }
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
   }
