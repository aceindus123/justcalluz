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
using System.Web.Routing;

public partial class usercontrols_videoctrl : System.Web.UI.UserControl
{
    public string swfFileName;
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            string sid = Convert.ToString(Page.RouteData.Values["id"].ToString());
            SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["connectionstring"]);
            SqlDataAdapter da = new SqlDataAdapter("select * from vedios where dataid='" + sid + "'", con);
            DataSet dsvideo = new DataSet();
            da.Fill(dsvideo);
            if (!dsvideo.Tables[0].Rows.Count.Equals(0))
            {
                string videoname = dsvideo.Tables[0].Rows[0]["VedioName"].ToString();
                swfFileName = "../Videos/" + videoname;
            }
       
        }

        catch (Exception ex) { this.Response.Write(ex.ToString()); }

    }

}
