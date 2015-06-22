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

public partial class computer : System.Web.UI.Page
{
    InsertData obj = new InsertData();
    Editdata obj1 = new Editdata();
    Deletedata obj2 = new Deletedata();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void bt1submit_Click(object sender, EventArgs e)
    {
        try
        {
            DataSet ds = new DataSet();

            string cname = txtname.Text.ToString();
            string cat = ddlcat.SelectedItem.Value.ToString();
            string area = txtarea.Text.ToString();
            string ph = txtph.Text.ToString();
            string mob = txtmobile.Text.ToString();
            string addr = txtaddr.Text.ToString();
            string state = txtstate.Text.ToString();
            string conper = txtcp.Text.ToString();
            string email = txtemail.Text.ToString();
            DateTime optim = Convert.ToDateTime(txtopt.Text.ToString());
            ds = obj.insert_Computer(cname, cat, area, ph, mob, addr, state, conper, email, optim);
        }
        catch (Exception ex)
        {
            ex.ToString();

        }
    }

    
}

