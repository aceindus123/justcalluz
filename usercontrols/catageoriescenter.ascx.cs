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

public partial class usercontrols_catageoriescenter : System.Web.UI.UserControl
{
    InsertData obj = new InsertData();
    string sid = string.Empty;
    int id;
    protected void Page_Load(object sender, EventArgs e)
    {
        DataList1.Visible = true;
        DataSet ds = new DataSet();
        ds = obj.bindatoc();
        DataList1.DataSource = ds;
        DataList1.DataBind();


        DataList2.Visible = true;
        DataSet ds1 = new DataSet();
        ds1 = obj.binddtof();
        DataList2.DataSource = ds1;
        DataList2.DataBind();


        DataList3.Visible = true;
        DataSet ds2 = new DataSet();
        ds2 = obj.bindgtoi();
        DataList3.DataSource = ds2;
        DataList3.DataBind();


        DataList4.Visible = true;
        DataSet ds3 = new DataSet();
        ds3 = obj.bindjtol();
        DataList4.DataSource = ds3;
        DataList4.DataBind();


        DataList5.Visible = true;
        DataSet ds4 = new DataSet();
        ds4 = obj.bindmtoo();
        DataList5.DataSource = ds4;
        DataList5.DataBind();


        DataList1.Visible = true;
        DataSet ds5 = new DataSet();
        ds5 = obj.bindptor();
        DataList6.DataSource = ds5;
        DataList6.DataBind();


        DataList1.Visible = true;
        DataSet ds6 = new DataSet();
        ds6 = obj.bindstou();
        DataList7.DataSource = ds6;
        DataList7.DataBind();


        DataList1.Visible = true;
        DataSet ds7 = new DataSet();
        ds7 = obj.bindvtoz();
        DataList8.DataSource = ds7;
        DataList8.DataBind();


        
        
        Panel1.Visible = true;
        Panel2.Visible = true;
        Panel3.Visible = false;
        Panel4.Visible = false;
        Panel5.Visible = false;
        Panel6.Visible = false;
        Panel7.Visible = false;
        Panel8.Visible = false;
        Panel9.Visible = false;
        

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Panel1.Visible = true;
        Panel2.Visible = true;
        Panel3.Visible = false;
        Panel4.Visible = false;
        Panel5.Visible = false;
        Panel6.Visible = false;
        Panel7.Visible = false;
        Panel8.Visible = false;
        Panel9.Visible = false;
        
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Panel1.Visible = true;
        Panel2.Visible = false; 
        Panel3.Visible = true; 
        Panel4.Visible = false;
        Panel5.Visible = false;
        Panel6.Visible = false;
        Panel7.Visible = false;
        Panel8.Visible = false;
        Panel9.Visible = false;
        
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Panel1.Visible = true;
        Panel2.Visible = false;
        Panel3.Visible = false;
        Panel4.Visible = true;
        Panel5.Visible = false;
        Panel6.Visible = false;
        Panel7.Visible = false;
        Panel8.Visible = false;
        Panel9.Visible = false;
        

    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        Panel1.Visible = true;
        Panel2.Visible = false;
        Panel3.Visible = false;
        Panel4.Visible = false;
        Panel5.Visible = true;
        Panel6.Visible = false;
        Panel7.Visible = false;
        Panel8.Visible = false;
        Panel9.Visible = false;
        
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        Panel1.Visible = true;
        Panel2.Visible = false;
        Panel3.Visible = false;
        Panel4.Visible = false;
        Panel5.Visible = false;
        Panel6.Visible = true;
        Panel7.Visible = false;
        Panel8.Visible = false;
        Panel9.Visible = false;
        

    }
    protected void Button6_Click(object sender, EventArgs e)
    {
        Panel1.Visible = true;
        Panel2.Visible = false;
        Panel3.Visible = false;
        Panel4.Visible = false;
        Panel5.Visible = false;
        Panel6.Visible = false;
        Panel7.Visible = true;
        Panel8.Visible = false;
        Panel9.Visible = false;
        
    }
    protected void Button7_Click(object sender, EventArgs e)
    {
        Panel1.Visible = true;
        Panel2.Visible = false;
        Panel3.Visible = false;
        Panel4.Visible = false;
        Panel5.Visible = false;
        Panel6.Visible = false;
        Panel7.Visible = false;
        Panel8.Visible = true;
        Panel9.Visible = false;
        
    }
    protected void Button8_Click(object sender, EventArgs e)
    {
        Panel1.Visible = true;
        Panel2.Visible = false;
        Panel3.Visible = false;
        Panel4.Visible = false;
        Panel5.Visible = false;
        Panel6.Visible = false;
        Panel7.Visible = false;
        Panel8.Visible = false;
        Panel9.Visible = true;
        

    }
    protected void Button9_Click(object sender, EventArgs e)
    {
        Panel1.Visible = true;
        Panel2.Visible = false;
        Panel3.Visible = false;
        Panel4.Visible = false;
        Panel5.Visible = false;
        Panel6.Visible = false;
        Panel7.Visible = false;
        Panel8.Visible = false;
        Panel9.Visible = false;
        
    }
    protected void DataList1_ItemCommand(object source, System.Web.UI.WebControls.DataListCommandEventArgs e)
    {
        Session["name"] = e.CommandArgument.ToString();
        string name = "";
        name = e.CommandArgument.ToString();
        Response.Redirect("linkcontroller.aspx?cname=" + name + "");


    }

    protected void DataList2_ItemCommand(object source, System.Web.UI.WebControls.DataListCommandEventArgs e)
    {
        Session["name"] = e.CommandArgument.ToString();
        string name = "";
        name = e.CommandArgument.ToString();
        Response.Redirect("linkcontroller.aspx?cname=" + name + "");


    }


    protected void DataList3_ItemCommand(object source, System.Web.UI.WebControls.DataListCommandEventArgs e)
    {
        Session["name"] = e.CommandArgument.ToString();
        string name = "";
        name = e.CommandArgument.ToString();
        Response.Redirect("linkcontroller.aspx?cname=" + name + "");


    }


    protected void DataList4_ItemCommand(object source, System.Web.UI.WebControls.DataListCommandEventArgs e)
    {
        Session["name"] = e.CommandArgument.ToString();
        string name = "";
        name = e.CommandArgument.ToString();
        Response.Redirect("linkcontroller.aspx?cname=" + name + "");


    }


    protected void DataList5_ItemCommand(object source, System.Web.UI.WebControls.DataListCommandEventArgs e)
    {
        Session["name"] = e.CommandArgument.ToString();
        string name = "";
        name = e.CommandArgument.ToString();
        Response.Redirect("linkcontroller.aspx?cname=" + name + "");


    }


    protected void DataList6_ItemCommand(object source, System.Web.UI.WebControls.DataListCommandEventArgs e)
    {
        Session["name"] = e.CommandArgument.ToString();
        string name = "";
        name = e.CommandArgument.ToString();
        Response.Redirect("linkcontroller.aspx?cname=" + name + "");


    }


    protected void DataList7_ItemCommand(object source, System.Web.UI.WebControls.DataListCommandEventArgs e)
    {
        Session["name"] = e.CommandArgument.ToString();
        string name = "";
        name = e.CommandArgument.ToString();
        Response.Redirect("linkcontroller.aspx?cname=" + name + "");


    }


    protected void DataList8_ItemCommand(object source, System.Web.UI.WebControls.DataListCommandEventArgs e)
    {
        Session["name"] = e.CommandArgument.ToString();
        string name = "";
        name = e.CommandArgument.ToString();
        Response.Redirect("linkcontroller.aspx?cname=" + name + "");


    }
   

}
