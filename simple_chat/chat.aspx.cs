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

public partial class chat : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string msg = (string)Application["msg"];

        TextBox1.Text = msg;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string name = TextBox2.Text;
        string message = TextBox3.Text;
        string my = name + "::" + message;

        Application["msg"] = Application["msg"] + my + Environment.NewLine;

        TextBox1.Text = Application["msg"].ToString();

        TextBox3.Text = "";
        Response.AppendHeader("Refresh", "2");
    }
}
