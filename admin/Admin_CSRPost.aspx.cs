using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class admin_Admin_CSRPost : System.Web.UI.Page
{   
    CSRCS obj = new CSRCS();
    DataSet ds = new DataSet();
    bool t;
    string UserId;
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
    }
    protected void imgBtnPostCSR_Click(object sender, ImageClickEventArgs e)
    {
        obj.aIntroduction = Convert.ToString(txtIntroduction.Text);
        obj.aTitle = Convert.ToString(txtTitle.Text);
        obj.aPara1 = Convert.ToString(txtData1.Text);
        obj.aPara2 = Convert.ToString(txtData2.Text);
        obj.aPara3 = Convert.ToString(txtData3.Text);
        obj.aPara4 = Convert.ToString(txtData4.Text);
        obj.aPara5 = Convert.ToString(txtData5.Text);
        obj.aPostedby = UserId;
        obj.aPostedate = System.DateTime.Now;
        t = obj.CSRPost(obj.aIntroduction, obj.aTitle, obj.aPara1, obj.aPara2, obj.aPara3, obj.aPara4, obj.aPara5,obj.aPostedby,obj.aPostedate);
        if (t == true)
        {
            DataSet dsId = new DataSet();
            dsId = obj.GetTopId(UserId);
            if (!dsId.Tables[0].Rows.Count.Equals(0))
            {
                string dId = dsId.Tables[0].Rows[0]["csrId"].ToString();
                strScript = "alert('Your CSR is Posted Successfully.');location.replace('Admin_CSRGallaryPost.aspx?csrid=" + dId + "');";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
            }
        }
    }
}
