﻿using System;
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

public partial class usercontrols_SearchNew : System.Web.UI.UserControl
{
    InsertData obj = new InsertData();
    static string excep_page;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    //protected void Category(object sender, CommandEventArgs e)
    //{
    //    try
    //    {
    //        string cat = e.CommandArgument.ToString();
    //        if (cat == "Builders")
    //        {
    //            redirect("Builders.aspx?cname=" + Server.UrlEncode(cat), false);
    //            excep_page = "" + cat + " link in catageories usercontrol";
    //        }
    //        else if (cat == "Computers & Peripherals")
    //        {
    //            redirect("computers.aspx?cname=" + Server.UrlEncode(cat), false);
    //            excep_page = "" + cat + " link in catageories usercontrol";
    //        }
    //        else if (cat == "Travel Services")
    //        {
    //            redirect("Travels.aspx?cname=" + Server.UrlEncode(cat), false);
    //            excep_page = "" + cat + " link in catageories usercontrol";
    //        }
    //        else if (cat == "Education & Training")
    //        {
    //            redirect("Education.aspx?cname=" + Server.UrlEncode(cat), false);
    //            excep_page = "" + cat + " link in catageories usercontrol";
    //        }
    //        else
    //        {
    //            excep_page = "catageories usercontrol";
    //        }
    //    }
    //    catch (Exception ex)
    //    {
    //        obj.insert_exception(ex, excep_page);
    //        Response.Redirect("HttpErrorPage.aspx");
    //    }
    //}
    //public void redirect(string url, bool val)
    //{
    //    if (!val)
    //    {
    //        HttpContext.Current.Response.Redirect(url, false);
    //        HttpContext.Current.ApplicationInstance.CompleteRequest();
    //    }
    //    else
    //    {
    //        HttpContext.Current.Server.ClearError();
    //        HttpContext.Current.Response.Redirect(url, false);
    //        HttpContext.Current.Server.ClearError();
    //    }

    //}
}

   