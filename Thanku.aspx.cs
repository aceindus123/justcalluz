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
using System.Net;
using System.IO;
using System.Text;
using System.Runtime.CompilerServices;
using System.Collections.Specialized;

public partial class Thanku : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //string requestPrice = "";
        


        
    }
    public void getdata()
    {
        string requestUriString = "https://www.sandbox.paypal.com/cgi-bin/webscr";
        // string requestUriString = Request.QueryString["PayPal"].ToString();        // Create the request back
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(requestUriString);

        // Set values for the request back


        string strFormValues = Encoding.ASCII.GetString(this.Request.BinaryRead(this.Request.ContentLength));
        request.Method = "POST";
        request.ContentType = "application/x-www-form-urlencoded";
        string obj2 = strFormValues + "&cmd=_notify-validate";
        request.ContentLength = obj2.Length;

        // Write the request back IPN strings
        StreamWriter writer = new StreamWriter(request.GetRequestStream(), Encoding.ASCII);
        writer.Write(RuntimeHelpers.GetObjectValue(obj2));
        writer.Close();

        //send the request, read the response
        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        Stream responseStream = response.GetResponseStream();
        Encoding encoding = Encoding.GetEncoding("utf-8");
        StreamReader reader = new StreamReader(responseStream, encoding);

        // Reads 256 characters at a time.

        char[] buffer = new char[0x101];
        int length = reader.Read(buffer, 0, 0x100);
        while (length > 0)
        {
            // Dumps the 256 characters to a string


            string IPNResponse = new string(buffer, 0, length);
            length = reader.Read(buffer, 0, 0x100);

            try
            {
                NameValueCollection these_argies = HttpUtility.ParseQueryString(strFormValues);
                string user_email = these_argies["payer_email"];
                string pay_stat = these_argies["payment_status"];
                Label1.Text = user_email + pay_stat;
                
            }
            catch (Exception exception)
            {
                //Carts.WriteFile("Error in IPNHandler: " + exception.Message);
                reader.Close();
                response.Close();
                return;
            }

        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string redirecturl = "";
        redirecturl="http://www.justcalluz.com/Oct_18_Webservices/service.asmx/PayWithPayPal?amount=20&itemInfo=ff&name=ff-f&phone=8790650929&email=mahi.gmail.com&currency=30&pcountry=india&pstate=AP&pcity=krishna&planid=11";
        //redirecturl = "http://indusemail.com/web%20service/Service.asmx/PayWithPayPal?amount=20&itemInfo=ff&name=ff-f&phone=8790650929&email=mahi.gmail.com&currency=30&pcountry=india&pstate=AP&pcity=krishna&planid=11";
        Response.Redirect(redirecturl);
        //getdata();
    }
}

   