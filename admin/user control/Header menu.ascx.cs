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

public partial class user_control_Header_menu : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string strHostName = System.Net.Dns.GetHostName();
        string strIp = System.Net.Dns.GetHostAddresses(strHostName).GetValue(0).ToString();
        l2.Text = strIp;
    }
}
