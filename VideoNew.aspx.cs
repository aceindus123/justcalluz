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
using System.IO;
using System.Web.Routing;

public partial class VideoNew : System.Web.UI.Page
{
    DataSet dsvideo = new DataSet();
    SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    public string swfFileName = "";
    InsertData obj = new InsertData();
    static string excep_page = "VideoNew.aspx";
    protected void Page_Load(object sender, EventArgs e)
    {        
        BindVedio();
    }
    public void BindVedio()
    {
        try
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from Vedios where dataid=216", connection);
            da.Fill(dsvideo);
            if (!dsvideo.Tables[0].Rows.Count.Equals(0))
            {
                string videoname = dsvideo.Tables[0].Rows[0]["VedioName"].ToString();                
                swfFileName = "../Videos/" + videoname;
                //Response.Write(swfFileName);         
            }
            else
            {
                //lblNoVideos.Text = "No Vedio Available";
            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }

        //catch (Exception ex)
        //{
        //    //this.Response.Write("Error : " + ex.Message);
        //}

    }
}
