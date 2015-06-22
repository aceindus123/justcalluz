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


public partial class Movie_mails : System.Web.UI.Page
{
    InsertData obj = new InsertData();
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["connectionstring"].ToString());
    static string excep_page = "Movie_mails.aspx";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            try
            {
                lblmovie.Text = Convert.ToString(Request.QueryString["moviename"]);
                lbllang.Text = Convert.ToString(Request.QueryString["movielanguage"]);
                lblname.Text = Convert.ToString(Request.QueryString["name"]);
                //con.Open();
                SqlDataAdapter damailmovie = new SqlDataAdapter("select * from modulesdata m inner join movies mov on m.id=mov.Hallid and mov.Movie_Name='" + lblmovie.Text + "' and mov.Movie_Language='" + lbllang.Text + "'", con);
                DataSet dsmailmovie = new DataSet();
                damailmovie.Fill(dsmailmovie);
                dlmoviemail.DataSource = dsmailmovie;
                dlmoviemail.DataBind();
            }
            catch (Exception ex)
            {
                obj.insert_exception(ex, excep_page);
                Response.Redirect("HttpErrorPage.aspx");
            }
        }
    }
}
