using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class admin_Admin_CSREdit : System.Web.UI.Page
{   
    DataSet ds = new DataSet();
    CSRCS obj = new CSRCS();
    string UserId;
    string CSRId;
    string introduction;
    string title;
    string para1;
    string para2;
    string para3;
    string para4;
    string para5;
    bool t;
    string strScript;
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
        CSRId = Convert.ToString(Request.QueryString["csrid"]);
        if (!Page.IsPostBack)
        {
            ds = obj.GetCSR_byId(CSRId);
            if (!ds.Tables[0].Rows.Count.Equals(0))
            {
                introduction = ds.Tables[0].Rows[0]["Introduction"].ToString();
                title = ds.Tables[0].Rows[0]["Title"].ToString();
                para1 = ds.Tables[0].Rows[0]["para1"].ToString();
                para2 = ds.Tables[0].Rows[0]["para2"].ToString();
                para3 = ds.Tables[0].Rows[0]["para3"].ToString();
                para4 = ds.Tables[0].Rows[0]["para4"].ToString();
                para5 = ds.Tables[0].Rows[0]["para5"].ToString();
            }
            txtIntroduction.Text = Convert.ToString(introduction);
            txtTitle.Text = Convert.ToString(title);
            txtData1.Text = Convert.ToString(para1);
            txtData2.Text = Convert.ToString(para2);
            txtData3.Text = Convert.ToString(para3);
            txtData4.Text = Convert.ToString(para4);
            txtData5.Text = Convert.ToString(para5);
        }
    }
    protected void imgBtnUpdateCSR_Click(object sender, ImageClickEventArgs e)
    {
        obj.acsrId = Convert.ToInt32(CSRId);
        obj.aIntroduction = Convert.ToString(txtIntroduction.Text);
        obj.aTitle = Convert.ToString(txtTitle.Text);
        obj.aPara1 = Convert.ToString(txtData1.Text);
        obj.aPara2 = Convert.ToString(txtData2.Text);
        obj.aPara3 = Convert.ToString(txtData3.Text);
        obj.aPara4 = Convert.ToString(txtData4.Text);
        obj.aPara5 = Convert.ToString(txtData5.Text);
        obj.aPostedate=System.DateTime.Now;
        obj.aPostedby=UserId;
        t = obj.CSRUpdate(obj.aIntroduction, obj.aTitle, obj.aPara1, obj.aPara2, obj.aPara3, obj.aPara4, obj.aPara5, obj.aPostedby, obj.aPostedate, obj.acsrId);
        if (t == true)
        {
            strScript = "alert('Your CSR is Updated Successfully.');location.replace('Admin_CorporateSocial.aspx');";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
        }

    }
    protected void imbBtnCancel_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("Admin_CorporateSocial.aspx");
    }
}
