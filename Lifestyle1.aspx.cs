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
public partial class Lifestyle1 : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    protected void Page_Load(object sender, EventArgs e)
    {
        subrelated.Visible = true;
        dlsubcat.Visible = true;
        string cat = Request.QueryString["cat"];
        Session["Category"] = cat;
        con.Open();
        SqlDataAdapter da = new SqlDataAdapter("select SubCategeory from lifestyle where Categeory='" + cat + "' order by SubCategeory", con);
        DataSet ds = new DataSet();
        da.Fill(ds);
        if (!ds.Tables[0].Rows.Count.Equals(0))
        {
            dlsubcat.DataSource = ds;
            dlsubcat.DataBind();
            con.Close();

        }
        else
            Response.Redirect("Lifestylehome.aspx?catname=" + cat + "");
        con.Close();

    }
    protected void linkcor_Click(object sender, EventArgs e)
    {
        
       


    }
    }

