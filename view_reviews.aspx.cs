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

public partial class view_reviews : System.Web.UI.Page
{
    
    InsertData obj = new InsertData();
    string sid = string.Empty;
    int id;
    Binddata obj1 = new Binddata();
    int total;
    protected void Page_Load(object sender, EventArgs e)
    {
        DataList2.Visible = true;
        DataSet ds1 = new DataSet();
        ds1 = obj.bindcat();
        DataList2.DataSource = ds1;
        DataList2.DataBind();


        DataList3.Visible = true;
        DataSet ds2 = new DataSet();
        //ds2 = obj.bindsponseredlinks();
        DataList3.DataSource = ds2;
        DataList3.DataBind();

        reviewdl.Visible = true;
        DataSet ds = new DataSet();
        sid = Convert.ToString(Request.QueryString["id"]);
        ds = obj1.postreview(sid);

        if (!ds.Tables[0].Rows.Count.Equals(0))
        {
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                total += Convert.ToInt32(ds.Tables[0].Rows[i]["Stars_Rating"].ToString());
            }
            int average = total / (ds.Tables[0].Rows.Count);
            avgrating.CurrentRating = average;
            reviewdl.DataSource = ds;
            reviewdl.DataBind();

        }
        else
        {
            Response.Redirect("search_notfound.aspx");
        }
       

        
    }
    protected void reviewdl_ItemDataBound(object sender, DataListItemEventArgs e)
    {

        Label lbl = (Label)e.Item.FindControl("lblcmp");
        lbl.Text = Convert.ToString(Session["companyname"]);
        Label lblrate = (Label)e.Item.FindControl("lblrating");
        Label rate = (Label)e.Item.FindControl("rates");
        int rates = Convert.ToInt32(rate.Text);
        for (int i = 0; i < rates; i++)
        {

            lblrate.Text += "<img src=images/ratestar2.png>";
        }
        for (int j = rates; j < 5; j++)
        {
            lblrate.Text += "<img src=images/starash3.png>";
        }



    }

    protected void DataList3_ItemCommand(object source, System.Web.UI.WebControls.DataListCommandEventArgs e)
    {
        Session["name"] = e.CommandArgument.ToString();
        string name = "";
        name = e.CommandArgument.ToString();
        Response.Redirect("linkcontroller.aspx?cname=" + name + "");
    }

    protected void DataList2_ItemCommand(object source, DataListCommandEventArgs e)
    {
        Session["name"] = e.CommandArgument.ToString();
        string name = "";
        name = e.CommandArgument.ToString();
        Response.Redirect("Discountlink.aspx?cname=" + name + "");
    }

    
}
