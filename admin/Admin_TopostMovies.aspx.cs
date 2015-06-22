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
/// class to post movies
/// </summary>
public partial class admin_Admin_TopostMovies : System.Web.UI.Page
{
    //making sql connection
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    //declaration of variables and creation of objects for classes
    MoviesCS obj = new MoviesCS();
    DataCS data = new DataCS();      
    string UserId;
    bool t;
    string strScript;
    string HallLoc;
    string Website;
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
        //loads the page without postbacking the values
        if (!Page.IsPostBack)
        {
            //fill states
            data.FillStates(ddlState);
            //fill language
            data.FillLanguage(ddlMLanguage);           
        }
    }
    /// <summary>
    /// Fill cities based on state
    /// </summary>
    /// <param name="StateName"></param>
    public void fillCities(string StateName)
    {
        try
        {
            string Connection = ConfigurationManager.AppSettings["ConnectionString"];
            SqlConnection oCon = new SqlConnection(Connection);
            string s = "select city_Id,city_name from Cities where state_name= '" + StateName + "' order by city_name";
            SqlCommand cmd = new SqlCommand(s, oCon);
            oCon.Open();
            SqlDataAdapter da = new SqlDataAdapter(s, oCon);
            DataSet ds = new DataSet();
            da.Fill(ds, "Cities");
            //DlCities.SelectedIndex = 0;

            ddlCity.DataSource = ds.Tables["Cities"];
            ddlCity.DataValueField = "city_name";
            ddlCity.DataTextField = "city_name";
            ddlCity.DataBind();
            ddlCity.Items.Insert(0, "Select City");
            oCon.Close();
        }
        catch (Exception ex)
        {
            lblMessage.Text = ex.Message.ToString();
        }
    }
    /// <summary>
    ///  fill theatres based on city
    /// </summary>
    /// <param name="CityName"></param>
    public void fillTheatre(string CityName)
    {
        try
        {
            string Connection = ConfigurationManager.AppSettings["ConnectionString"];
            SqlConnection oCon = new SqlConnection(Connection);
            string s = "select id,company_name from ModulesData where module='Movies' and City='"+CityName+"' order by company_name";
            SqlCommand cmd = new SqlCommand(s, oCon);
            oCon.Open();
            SqlDataAdapter da = new SqlDataAdapter(s, oCon);
            DataSet ds = new DataSet();
            da.Fill(ds, "Theatre");
            //DlCities.SelectedIndex = 0;

            ddlTheatre.DataSource = ds.Tables["Theatre"];
            ddlTheatre.DataValueField = "id";
            ddlTheatre.DataTextField = "company_name";
            ddlTheatre.DataBind();
            ddlTheatre.Items.Insert(0, "Select Theatre");
            oCon.Close();
        }
        catch (Exception ex)
        {
            lblMessage.Text = ex.Message.ToString();
        }
    }
    /// <summary>
    /// fill location of theatre
    /// </summary>
    /// <param name="DId"></param>
    public void fillTheatreLoc(Int32 DId)
    {
        try
        {
            string Connection = ConfigurationManager.AppSettings["ConnectionString"];
            SqlConnection oCon = new SqlConnection(Connection);
            string s = "select * from ModulesData where id="+DId;
            SqlCommand cmd = new SqlCommand(s, oCon);
            oCon.Open();
            SqlDataAdapter da = new SqlDataAdapter(s, oCon);
            DataSet ds = new DataSet();
            da.Fill(ds, "Theatre");
            //DlCities.SelectedIndex = 0;
            if (!ds.Tables[0].Rows.Count.Equals(0))
            {
                txtTheatreArea.Text = ds.Tables[0].Rows[0]["Area"].ToString();
                txtURL.Text = ds.Tables[0].Rows[0]["Website"].ToString();
            }           
            oCon.Close();
        }
        catch (Exception ex)
        {
            lblMessage.Text = ex.Message.ToString();
        }
    }
    /// <summary>
    /// executes whenever state selection is changed
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void ddlState_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlState.SelectedIndex != 0)
        {
            string State_Name = Convert.ToString(ddlState.SelectedValue);
            fillCities(State_Name);
        }
        else
        {
            ddlCity.Items.Clear();
            ddlCity.Items.Insert(0, "Select City");
        }
    }
    /// <summary>
    /// executes whenever city selection is changed
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void ddlCity_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlCity.SelectedIndex != 0)
        {
            string City_Name = Convert.ToString(ddlCity.SelectedValue);
            fillTheatre(City_Name);
        }
        else
        {
            ddlTheatre.Items.Clear();
            ddlTheatre.Items.Insert(0, "Select Theatre");
        }
    }
    protected void imgbtnPostMovie_Click(object sender, ImageClickEventArgs e)
    {
        obj.mMFor = Convert.ToString(ddlMoviefor.SelectedValue);
        obj.mMLanguage = Convert.ToString(ddlMLanguage.SelectedValue);
        obj.mMoviename = Convert.ToString(txtMovieName.Text);
        obj.mMTimings = Convert.ToString(txtTimings.Text);
        obj.mTheatreName = Convert.ToString(ddlTheatre.SelectedItem.Text);
        obj.mState = Convert.ToString(ddlState.SelectedValue);
        obj.mCity = Convert.ToString(ddlCity.SelectedValue);
        obj.mMHallid = Convert.ToString(ddlTheatre.SelectedValue);
        obj.mMTheatreURL = Convert.ToString(txtURL.Text);
        obj.mMArea = Convert.ToString(txtTheatreArea.Text);
        obj.mLoginId = UserId;
        obj.mMDesc = Convert.ToString(txtMDesc.Text);
        obj.mMStaus= Convert.ToString(ddlMStatus.SelectedValue);
        t = obj.Movies_Insert(obj.mMoviename, obj.mMLanguage, obj.mMFor, obj.mTheatreName, obj.mMTimings, obj.mCity, obj.mState, obj.mMHallid, obj.mMTheatreURL, obj.mMArea, obj.mMStaus, obj.mMDesc, obj.mLoginId);

        //ddlMLanguage.SelectedIndex = 0;
        //ddlMoviefor.SelectedIndex = 0;
        //ddlState.SelectedIndex = 0;
        //ddlCity.SelectedIndex = 0;
        ddlTheatre.SelectedIndex = 0;
        txtTimings.Text = "";
        txtURL.Text = "";
        txtTheatreArea.Text = "";
        strScript = "alert('Movie is Posted Successfully.');location.replace('Admin_Movies.aspx');";
        Page.ClientScript.RegisterStartupScript(this.GetType(), "alertBox", strScript, true);
    }
    /// <summary>
    /// executes whenever Theatre selection is changed
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void ddlTheatre_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlTheatre.SelectedIndex != 0)
        {
            Int32 HallId  = Convert.ToInt32(ddlTheatre.SelectedValue);
            fillTheatreLoc(HallId);
        }
        else
        {
            
        }
    }
}
