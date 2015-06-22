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

public partial class usercontrols_jobright : System.Web.UI.UserControl
{
    InsertData obj = new InsertData();
    protected void Page_Load(object sender, EventArgs e)
    {
        dlsponsoredlinks.Visible = true;
        DataSet ds6 = new DataSet();
        //ds6 = obj.bindsponseredlinks();
        dlsponsoredlinks.DataSource = ds6;
        dlsponsoredlinks.DataBind();
    }
   
}
