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
using System.Collections.Generic;

public partial class Catageories : System.Web.UI.Page
{
    InsertData obj = new InsertData();
    DataSet ds;
    string str;
    string type;
    protected void Page_Load(object sender, EventArgs e)
    {
        type = Convert.ToString(Request.QueryString["str"]);
        Label1.Text = type;
        Label2.Text = type;
        if (!IsPostBack)
        {
            if (type == "Popular Search Categories")
            {
                str = "A";
                DataList1.Visible = true;
                ds = new DataSet();
                ds = obj.bindPopCat(str);
                DataList1.DataSource = ds;
                DataList1.DataBind();
            }
            else if (type == "B2B Categories")
            {
                str = "A";
                DataList1.Visible = true;
                ds = new DataSet();
                ds = obj.bindB2bCat(str);
                DataList1.DataSource = ds;
                DataList1.DataBind();
            }
            else
            {
                str = "A";
                DataList1.Visible = true;
                ds = new DataSet();
                ds = obj.bindPopCat(str);
                DataList1.DataSource = ds;
                DataList1.DataBind();
            }
        }
        //dlsponsoredlinks.Visible = true;
        //DataSet ds2 = new DataSet();
        //ds2 = obj.bindsponseredlinks();
        //dlsponsoredlinks.DataSource = ds2;
        //dlsponsoredlinks.DataBind();

        DataList2.Visible = true;
        ds = new DataSet();
        ds = obj.bindcategory();
        DataList2.DataSource = ds;
        DataList2.DataBind();

        DataList3.Visible = true;
        ds = new DataSet();
        ds = obj.bindFreelistingcategory();
        DataList3.DataSource = ds;
        DataList3.DataBind();

    }
    protected void dlsponsoredlinks_ItemCommand(object source, System.Web.UI.WebControls.DataListCommandEventArgs e)
    {
        Session["name"] = e.CommandArgument.ToString();
        string name = "";
        name = e.CommandArgument.ToString();
        Response.Redirect("linkcontroller.aspx?cname=" + Server.UrlEncode(name) + "");
    }
    protected void DataList2_ItemCommand(object source, System.Web.UI.WebControls.DataListCommandEventArgs e)
    {
        Session["name"] = e.CommandArgument.ToString();
        string name = "";
        name = e.CommandArgument.ToString();
        Response.Redirect("linkcontroller.aspx?cname=" + Server.UrlEncode(name) + "");

    }
    protected void DataList1_ItemCommand(object source, System.Web.UI.WebControls.DataListCommandEventArgs e)
    {
        Session["name"] = e.CommandArgument.ToString();
        string name = "";
        name = e.CommandArgument.ToString();
        Response.Redirect("linkcontroller.aspx?cname=" + Server.UrlEncode(name) + "");


    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {  
        str = "A";
        DataList1.Visible = true;
        ds = new DataSet();
        if (type == "Popular Search Categories")
        {
            ds = obj.bindPopCat(str);
        }
        else if (type == "B2B Categories")
        {
            ds = obj.bindB2bCat(str);
        }
        else { ds = obj.bindPopCat(str); }
     
        DataList1.DataSource = ds;
        DataList1.DataBind();

    }
   
    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
        str = "B";
        DataList1.Visible = true;
        ds = new DataSet();
        if (type == "Popular Search Categories")
        {
            ds = obj.bindPopCat(str);
        }
        else if (type == "B2B Categories")
        {
            ds = obj.bindB2bCat(str);
        }
        else { ds = obj.bindPopCat(str); }
        DataList1.DataSource = ds;
        DataList1.DataBind();

    }
    protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
    {
        str = "C";
        DataList1.Visible = true;
        ds = new DataSet();
        if (type == "Popular Search Categories")
        {
            ds = obj.bindPopCat(str);
        }
        else if (type == "B2B Categories")
        {
            ds = obj.bindB2bCat(str);
        }
        else { ds = obj.bindPopCat(str); }
        DataList1.DataSource = ds;
        DataList1.DataBind();
    }
    protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
    {
        str = "D";
        DataList1.Visible = true;
        ds = new DataSet();
        if (type == "Popular Search Categories")
        {
            ds = obj.bindPopCat(str);
        }
        else if (type == "B2B Categories")
        {
            ds = obj.bindB2bCat(str);
        }
        else { ds = obj.bindPopCat(str); }
        DataList1.DataSource = ds;
        DataList1.DataBind();
    }
    protected void ImageButton5_Click(object sender, ImageClickEventArgs e)
    {
        str = "E";
        DataList1.Visible = true;
        ds = new DataSet();
        if (type == "Popular Search Categories")
        {
            ds = obj.bindPopCat(str);
        }
        else if (type == "B2B Categories")
        {
            ds = obj.bindB2bCat(str);
        }
        else { ds = obj.bindPopCat(str); }
        DataList1.DataSource = ds;
        DataList1.DataBind();
    }
    protected void ImageButton6_Click(object sender, ImageClickEventArgs e)
    {
        str = "F";
        DataList1.Visible = true;
        ds = new DataSet();
        if (type == "Popular Search Categories")
        {
            ds = obj.bindPopCat(str);
        }
        else if (type == "B2B Categories")
        {
            ds = obj.bindB2bCat(str);
        }
        else { ds = obj.bindPopCat(str); }
        DataList1.DataSource = ds;
        DataList1.DataBind();
    }
    protected void ImageButton7_Click(object sender, ImageClickEventArgs e)
    {
        str = "G";
        DataList1.Visible = true;
        ds = new DataSet();
        if (type == "Popular Search Categories")
        {
            ds = obj.bindPopCat(str);
        }
        else if (type == "B2B Categories")
        {
            ds = obj.bindB2bCat(str);
        }
        else { ds = obj.bindPopCat(str); }
        DataList1.DataSource = ds;
        DataList1.DataBind();
    }
    protected void ImageButton8_Click(object sender, ImageClickEventArgs e)
    {
        str = "H";
        DataList1.Visible = true;
        ds = new DataSet();
        if (type == "Popular Search Categories")
        {
            ds = obj.bindPopCat(str);
        }
        else if (type == "B2B Categories")
        {
            ds = obj.bindB2bCat(str);
        }
        else { ds = obj.bindPopCat(str); }
        DataList1.DataSource = ds;
        DataList1.DataBind();
    }
    protected void ImageButton9_Click(object sender, ImageClickEventArgs e)
    {
        str = "I";
        DataList1.Visible = true;
        ds = new DataSet();
        if (type == "Popular Search Categories")
        {
            ds = obj.bindPopCat(str);
        }
        else if (type == "B2B Categories")
        {
            ds = obj.bindB2bCat(str);
        }
        else { ds = obj.bindPopCat(str); }
        DataList1.DataSource = ds;
        DataList1.DataBind();
    }
    protected void ImageButton10_Click(object sender, ImageClickEventArgs e)
    {
        str = "J";
        DataList1.Visible = true;
        ds = new DataSet();
        if (type == "Popular Search Categories")
        {
            ds = obj.bindPopCat(str);
        }
        else if (type == "B2B Categories")
        {
            ds = obj.bindB2bCat(str);
        }
        else { ds = obj.bindPopCat(str); }
        DataList1.DataSource = ds;
        DataList1.DataBind();
    }
    protected void ImageButton11_Click(object sender, ImageClickEventArgs e)
    {
        str = "K";
        DataList1.Visible = true;
        ds = new DataSet();
        if (type == "Popular Search Categories")
        {
            ds = obj.bindPopCat(str);
        }
        else if (type == "B2B Categories")
        {
            ds = obj.bindB2bCat(str);
        }
        else { ds = obj.bindPopCat(str); }
        DataList1.DataSource = ds;
        DataList1.DataBind();
    }
    protected void ImageButton12_Click(object sender, ImageClickEventArgs e)
    {
        str = "L";
        DataList1.Visible = true;
        ds = new DataSet();
        if (type == "Popular Search Categories")
        {
            ds = obj.bindPopCat(str);
        }
        else if (type == "B2B Categories")
        {
            ds = obj.bindB2bCat(str);
        }
        else { ds = obj.bindPopCat(str); }
        DataList1.DataSource = ds;
        DataList1.DataBind();
    }
    protected void ImageButton13_Click(object sender, ImageClickEventArgs e)
    {
        str = "M";
        DataList1.Visible = true;
        ds = new DataSet();
        if (type == "Popular Search Categories")
        {
            ds = obj.bindPopCat(str);
        }
        else if (type == "B2B Categories")
        {
            ds = obj.bindB2bCat(str);
        }
        else { ds = obj.bindPopCat(str); }
        DataList1.DataSource = ds;
        DataList1.DataBind();
    }
    protected void ImageButton14_Click(object sender, ImageClickEventArgs e)
    {
        str = "N";
        DataList1.Visible = true;
        ds = new DataSet();
        if (type == "Popular Search Categories")
        {
            ds = obj.bindPopCat(str);
        }
        else if (type == "B2B Categories")
        {
            ds = obj.bindB2bCat(str);
        }
        else { ds = obj.bindPopCat(str); }
        DataList1.DataSource = ds;
        DataList1.DataBind();
    }
    protected void ImageButton15_Click(object sender, ImageClickEventArgs e)
    {
        str = "O";
        DataList1.Visible = true;
        ds = new DataSet();
        if (type == "Popular Search Categories")
        {
            ds = obj.bindPopCat(str);
        }
        else if (type == "B2B Categories")
        {
            ds = obj.bindB2bCat(str);
        }
        else { ds = obj.bindPopCat(str); }
        DataList1.DataSource = ds;
        DataList1.DataBind();
    }
    protected void ImageButton16_Click(object sender, ImageClickEventArgs e)
    {
        str = "P";
        DataList1.Visible = true;
        ds = new DataSet();
        if (type == "Popular Search Categories")
        {
            ds = obj.bindPopCat(str);
        }
        else if (type == "B2B Categories")
        {
            ds = obj.bindB2bCat(str);
        }
        else { ds = obj.bindPopCat(str); }
        DataList1.DataSource = ds;
        DataList1.DataBind();
    }
    protected void ImageButton17_Click(object sender, ImageClickEventArgs e)
    {
        str = "Q";
        DataList1.Visible = true;
        ds = new DataSet();
        if (type == "Popular Search Categories")
        {
            ds = obj.bindPopCat(str);
        }
        else if (type == "B2B Categories")
        {
            ds = obj.bindB2bCat(str);
        }
        else { ds = obj.bindPopCat(str); }
        DataList1.DataSource = ds;
        DataList1.DataBind();
    }
    protected void ImageButton18_Click(object sender, ImageClickEventArgs e)
    {
        str = "R";
        DataList1.Visible = true;
        ds = new DataSet();
        if (type == "Popular Search Categories")
        {
            ds = obj.bindPopCat(str);
        }
        else if (type == "B2B Categories")
        {
            ds = obj.bindB2bCat(str);
        }
        else { ds = obj.bindPopCat(str); }
        DataList1.DataSource = ds;
        DataList1.DataBind();
    }
    protected void ImageButton19_Click(object sender, ImageClickEventArgs e)
    {
        str = "S";
        DataList1.Visible = true;
        ds = new DataSet();
        if (type == "Popular Search Categories")
        {
            ds = obj.bindPopCat(str);
        }
        else if (type == "B2B Categories")
        {
            ds = obj.bindB2bCat(str);
        }
        else { ds = obj.bindPopCat(str); }
        DataList1.DataSource = ds;
        DataList1.DataBind();
    }
    protected void ImageButton20_Click(object sender, ImageClickEventArgs e)
    {
        str = "T";
        DataList1.Visible = true;
        ds = new DataSet();
        if (type == "Popular Search Categories")
        {
            ds = obj.bindPopCat(str);
        }
        else if (type == "B2B Categories")
        {
            ds = obj.bindB2bCat(str);
        }
        else { ds = obj.bindPopCat(str); }
        DataList1.DataSource = ds;
        DataList1.DataBind();

    }
    protected void ImageButton21_Click(object sender, ImageClickEventArgs e)
    {
        str = "U";
        DataList1.Visible = true;
        ds = new DataSet();
        if (type == "Popular Search Categories")
        {
            ds = obj.bindPopCat(str);
        }
        else if (type == "B2B Categories")
        {
            ds = obj.bindB2bCat(str);
        }
        else { ds = obj.bindPopCat(str); }
        DataList1.DataSource = ds;
        DataList1.DataBind();
    }
    protected void ImageButton22_Click(object sender, ImageClickEventArgs e)
    {
        str = "V";
        DataList1.Visible = true;
        ds = new DataSet();
        if (type == "Popular Search Categories")
        {
            ds = obj.bindPopCat(str);
        }
        else if (type == "B2B Categories")
        {
            ds = obj.bindB2bCat(str);
        }
        else { ds = obj.bindPopCat(str); }
        DataList1.DataSource = ds;
        DataList1.DataBind();
    }
    protected void ImageButton23_Click(object sender, ImageClickEventArgs e)
    {
        str = "W";
        DataList1.Visible = true;
        ds = new DataSet();
        if (type == "Popular Search Categories")
        {
            ds = obj.bindPopCat(str);
        }
        else if (type == "B2B Categories")
        {
            ds = obj.bindB2bCat(str);
        }
        else { ds = obj.bindPopCat(str); }
        DataList1.DataSource = ds;
        DataList1.DataBind();
    }
    protected void ImageButton24_Click(object sender, ImageClickEventArgs e)
    {
        str = "X";
        DataList1.Visible = true;
        ds = new DataSet();
        if (type == "Popular Search Categories")
        {
            ds = obj.bindPopCat(str);
        }
        else if (type == "B2B Categories")
        {
            ds = obj.bindB2bCat(str);
        }
        else { ds = obj.bindPopCat(str); }
        DataList1.DataSource = ds;
        DataList1.DataBind();
    }
    protected void ImageButton25_Click(object sender, ImageClickEventArgs e)
    {
        str = "Y";
        DataList1.Visible = true;
        ds = new DataSet();
        if (type == "Popular Search Categories")
        {
            ds = obj.bindPopCat(str);
        }
        else if (type == "B2B Categories")
        {
            ds = obj.bindB2bCat(str);
        }
        else { ds = obj.bindPopCat(str); }
        DataList1.DataSource = ds;
        DataList1.DataBind();
    }
    protected void ImageButton26_Click(object sender, ImageClickEventArgs e)
    {
        str = "Z";
        DataList1.Visible = true;
        ds = new DataSet();
        if (type == "Popular Search Categories")
        {
            ds = obj.bindPopCat(str);
        }
        else if (type == "B2B Categories")
        {
            ds = obj.bindB2bCat(str);
        }
        else { ds = obj.bindPopCat(str); }
        DataList1.DataSource = ds;
        DataList1.DataBind();
    }
    [System.Web.Script.Services.ScriptMethod()]
    [System.Web.Services.WebMethod]
    public static List<string> Getcities(string prefixText)
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["connectionstring"]);
        con.Open();
        SqlCommand cmd = new SqlCommand("select * from cities where city_name like @Name+'%'", con);
        cmd.Parameters.AddWithValue("@Name", prefixText);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        da.Fill(dt);
        List<string> citynames = new List<string>();
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            citynames.Add(dt.Rows[i][1].ToString());
        }
        return citynames;
    }
}
