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

public partial class usercontrols_OverallRatings : System.Web.UI.UserControl
{
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
    InsertData obj = new InsertData();
    static string excep_page = "OverallRatings.ascx";
    private Int32 _iUserWidth = 300;
    private String[] _sYAxisItems;
    private Int32[] _iYAxisValues;

    public Int32 UserWidth
    {
        get { return _iUserWidth; }
        set { _iUserWidth = value; }
    }

    public Int32[] YAxisValues
    {
        get { return _iYAxisValues; }
        set { _iYAxisValues = value; }
    }

    public String[] YAxisItems
    {
        get { return _sYAxisItems; }
        set { _sYAxisItems = value; }
    }

 
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            // As long as we have values to display, do so
            if (_iYAxisValues != null)
            {

                // Color array
                String[] sColor = new String[5];
                sColor[0] = "skyblue";
                sColor[1] = "skyblue";
                sColor[2] = "skyblue";
                sColor[3] = "skyblue";
                sColor[4] = "skyblue";


                // Initialize the color category
                Int32 iColor = 0;

                // Get the largest value from the available items
                Int32 iMaxVal = 0;
                for (int i = 0; i < _iYAxisValues.Length; i++)
                {
                    if (_iYAxisValues[i] > iMaxVal)
                        iMaxVal = _iYAxisValues[i];
                }

                // Take the user-provided maximum width of the chart, and divide it by the
                // largest value in our valueset to obtain the modifier
                //Int32 iMod = Math.Abs(_iUserWidth / iMaxVal);

                // This will be the string holder for our actual bars.
                String sOut = "";
                Int32 sum = 0;
                for (int i = 0; i < _iYAxisValues.Length; i++)
                {
                    sum = sum + _iYAxisValues[i];
                }
                // Render a bar for each item
                for (int i = 0; i < _iYAxisValues.Length; i++)
                {
                    try
                    {

                        // Only display this item if we have a value to display
                        if (_iYAxisValues[i] >= 0)
                        {
                            if (sum != 0)
                            {
                                sOut += "<tr><td align=right class=side_menu>" + _sYAxisItems[i] + "</td>";
                                sOut += "<td>" + RenderItem1(_iYAxisValues[i], sum, sColor[iColor]) + "</td></tr>";
                                iColor++;
                            }
                            else
                            {
                                sOut += "<tr><td align=right class=side_menu>" + _sYAxisItems[i] + "</td>";
                                sOut += "<td>" + RenderItem(_iYAxisValues[i], sum, sColor[iColor]) + "</td></tr>";
                                iColor++;
                            }
                            // If we have reached the end of our color array, start over
                            if (iColor > 8) iColor = 0;
                        }
                    }
                    catch (Exception ex)
                    {
                        obj.insert_exception(ex, excep_page);
                        Response.Redirect("HttpErrorPage.aspx");
                    }

                }

                // Place the rendered string in the appropriate label
                lblItems.Text = sOut;


            }
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }

    }
    private String RenderItem1(Int32 iVal,Int32 sum, String sColor)
    {
        String sRet = "";
        try
        {
            if (iVal == 0)
            {
                sColor = "white";
                sRet += "<table border=0 bgcolor=" + sColor + " cellpadding=0 cellspacing=0><tr>";
                sRet += "<td align=center width=" + ((iVal * 100 / sum) * _iUserWidth) / 100 + "px nobr nowrap>";
                sRet += "</td><td><b>" + (iVal * 100 / sum) + "%</b>";
                sRet += "</td></tr></table>";
                return sRet;
            }

            sRet += "<table border=0 bgcolor=" + sColor + " cellpadding=0 cellspacing=0><tr>";
            sRet += "<td align=center width=" + ((iVal * 100 / sum) * _iUserWidth) / 100 + " nobr nowrap>";
            sRet += "</td><td><b>" + (iVal * 100 / sum) + "%</b>";
            sRet += "</td></tr></table>";
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }

        return sRet;
    }
    private String RenderItem(Int32 iVal, Int32 sum, String sColor)
    {
        String sRet = "";
        try
        {
            if (iVal == 0)
            {
                sColor = "white";
                sRet += "<table border=0 bgcolor=" + sColor + " cellpadding=0 cellspacing=0><tr>";
                sRet += "<td align=center width=" + (iVal * _iUserWidth) / 100 + "px nobr nowrap>";
                sRet += "</td><td><b>" + (iVal) + "%</b>";
                sRet += "</td></tr></table>";
                return sRet;
            }

            sRet += "<table border=0 bgcolor=" + sColor + " cellpadding=0 cellspacing=0><tr>";
            sRet += "<td align=center width=" + (iVal * _iUserWidth) / 100 + "px nobr nowrap>";
            sRet += "</td><td><b>" + (iVal) + "%</b>";
            sRet += "</td></tr></table>";
        }
        catch (Exception ex)
        {
            obj.insert_exception(ex, excep_page);
            Response.Redirect("HttpErrorPage.aspx");
        }

        return sRet;
    }
}
