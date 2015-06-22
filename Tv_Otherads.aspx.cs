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

public partial class Tv_Otherads : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    SqlDataAdapter da;
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        string qry = "select * from Vedios ";
        da = new SqlDataAdapter(qry,con);
        DataSet ds = new DataSet();
        da.Fill(ds);
        if (!ds.Tables[0].Rows.Count.Equals(0))
        {
            dlvideos.DataSource = ds;
            dlvideos.DataBind();
        }
        else
        {
            lblmsg.Text = "Currently no videos ar available <br/><span class=side_menu>Suggestion:</span> ";
            lblmsg.CssClass = "sub_menu";
        }
        con.Close();
    }
}
