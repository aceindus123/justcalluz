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
/// <summary>
/// class to locate address on the map
/// </summary>
public partial class admin_Admin_ToPointAddressOnMap : System.Web.UI.Page
{
    //declaration of variables and creation of objects for classes 
    string UserId;
    Int32 chid;
    string qry;
    string strScripts;
    string mod;
    string cat;
    string Map;
    string Address;
    string City;
    string State;
    string compname;    
    MoviesCS obj = new MoviesCS();
    DataSet ds = new DataSet();
    //making connection
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
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
        chid = Convert.ToInt32(Request.QueryString["id"]);
        ds = obj.GetHallData(chid);
        if (!ds.Tables[0].Rows.Count.Equals(0))
        {
            mod = ds.Tables[0].Rows[0]["module"].ToString();
            cat = ds.Tables[0].Rows[0]["Category"].ToString();
            Map = ds.Tables[0].Rows[0]["map"].ToString();
            Address = ds.Tables[0].Rows[0]["address"].ToString();
            City = ds.Tables[0].Rows[0]["City"].ToString();
            State = ds.Tables[0].Rows[0]["State"].ToString();
            compname = ds.Tables[0].Rows[0]["company_name"].ToString();
        }
        if (mod == "Movies")
        {
            trDataHeader.Visible = false;
            trMovieHeader.Visible = true;
        }
        else
        {
            trDataHeader.Visible = true;
            trMovieHeader.Visible = false;
        }
        if (Map != "")
        {
            imgbtnmapUpdate.Visible = true;
            imgbtnSave.Visible = false;
        }
        else
        {
            imgbtnmapUpdate.Visible = false;
            imgbtnSave.Visible = true;
        }
        lblMap.Text = Map;
        lblCompName.Text = compname;
        lblAddress.Text = Address + ", " + City + ", " + State;
    }

    /// <summary>
    /// click event to locate address on map
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    
    protected void imgbtnSave_Click(object sender, ImageClickEventArgs e)
    {
        string mapPath = Convert.ToString(txtMapURL.Text);
        mapPath = mapPath.Replace("<small>View <a", "<small><a");
        //string mapPath ="<iframe width='690px' height='253px' frameborder='0' scrolling=no marginheight=0 marginwidth=0 src=http://maps.google.co.in/maps?f=q&amp;source=s_q&amp;hl=en&amp;geocode=&amp;q=Hyderabad&amp;aq=&amp;sll=16.496196,80.638935&amp;sspn=0.020533,0.027423&amp;ie=UTF8&amp;hq=&amp;hnear=Hyderabad,+Ranga+Reddy,+Andhra+Pradesh&amp;t=m&amp;z=10&amp;ll=17.385044,78.486671&amp;output=embed></iframe>";
        int len = mapPath.Length;       
        string[] mapstr = mapPath.Split(' ');
        mapstr[1] = "width=\"690px\"";
        mapstr[2] = "height=\"253px\"";
        for (int i = 0; i < len; i++)
        {
            lblSmallExceptLarge.Text += mapstr[i] + " ";
            if (mapstr[i] == "/><small><a")
            {
                len = i;
                break;
            }            
        }
        txtMapURL.Text = lblSmallExceptLarge.Text;
        
        try
        {
        qry = "update ModulesData set map=@text,Approved_map=1 where id=" + chid;
            SqlCommand cmd = new SqlCommand(qry, con);
            cmd.Parameters.AddWithValue("@text", txtMapURL.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            if (mod == "Movies")
            {
                strScripts = "alert('Your MapURL is submitted Successfully');location.replace('Admin_ViewHallsData.aspx');";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScripts, true);
            }
            else
            {
                strScripts = "alert('Your MapURL is submitted Successfully');location.replace('Admin_LinkControllerCategory.aspx?cat=" + cat + "&mod=" + mod + "');";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScripts, true);

            }
        }
        catch (Exception ex)
        {
            strScripts = ex.ToString();
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScripts, true);
        }
    }
}
