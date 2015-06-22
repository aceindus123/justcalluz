<%@ Page Language="C#" AutoEventWireup="true" CodeFile="customerdetails.aspx.cs" Inherits="admin_customerdetails" %>
<%@ Register Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" TagPrefix="cc3"  %>
<%@ Register Src="~/admin/user_control/Admin_Headermenu.ascx" TagName="Headermenu" TagPrefix="cc1" %>
<%@ Register Src="~/admin/user_control/Admin_LeftMenu.ascx" TagName="LeftMenu" TagPrefix="cc4" %>
<%@ Register Src="~/admin/user_control/Admin_MoviesHeader.ascx" TagName="MovieHeader" TagPrefix="cc2" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>customer details</title>
    <link href="starrater.css" rel="Stylesheet" type="text/css" />
    <link href="includes/style.css" rel="Stylesheet" type="text/css" />
    <script type="text/javasrcipt" src="http://ajax.googleapis.com/ajax/libs/jquery/1.6.2/jquery.min.js"></script>
    <script src="js/statesopt.js"></script>
    <style type="text/css">
        .modalBackground
        {  
        	background-color: Gray;  
        	filter: alpha(opacity=50);  
        	opacity: 0.50;
        }
       .updateProgress
       {  
       	border-width: 1px; 
        border-style: solid; 
        background-color: White;  
        position: absolute;  
        width: 180px;  
        height: 65px;
       }  
        .style1
        {
            width: 211px;
        }
     .style23
     {
         width: 103px;
         height: 83px;
     }
     </style>
    <style type="text/css">
        .style37
        {
            width: 750px;
        }
        .style39
        {
            width: 100px;
        }        
        </style>
              
        <script type="text/javascript" src="js/tab.js"></script>
        <script type="text/javascript">
function poponload()
{
    testwindow = window.open("http://www.justcalluz.com/Customer_Care.aspx", "mywindow", "location=1,status=1,scrollbars=1,width=500,height=500");
    testwindow.moveTo(400,-2000);
}
</script>	
</head>
<body onload="new Accordian('basic-accordian',5,'header_highlight');">
    <form id="form1" runat="server">
    <center>
    <div>
    <table cellpadding="0" cellspacing="0">
         <tr>
            <td>
             <cc1:headermenu ID="header" runat="server" />
            </td>
         </tr>
         <tr>
           <td>                  
            <table cellpadding="0" cellspacing="0">
              <tr>
                <td class="style39" valign="top" style="padding-top:4px">                        
                 <cc4:LeftMenu ID="LeftMenu1" runat="server" />
                </td>
                <td valign="top">&nbsp;</td>
                <td valign="top" style="padding-left:10px; background-color:#F2FAFC">  
    <table width="750px">
    <tr><td></td></tr>
    <tr><td colspan="4" align="right" style="padding-right:8px;">
                     <a href="http://www.justcalluz.com/Customer_Care.aspx" target="_blank">
                     <img src="images/Click Here For SiteView.png" alt="Siteview"/></a>
                    </td></tr>
    <tr><td colspan="4" align="right" style="padding-right:8px;">
                    <asp:LinkButton ID="lnkBack" runat="server" Text="Back" PostBackUrl="customer.aspx"></asp:LinkButton>
                    </td></tr>
    <tr><td colspan="3" align="center">
     <asp:Label ID="lbluser" runat="server" Text="User Details" Width="700px" BackColor="Silver" Font-Bold="true" Font-Size="Medium"></asp:Label>
    </td></tr>
    <tr><td></td></tr>
    <tr>
    <td align="right" style="padding-right:15px;"><asp:Label ID="lblname" runat="server" Text="UserName"></asp:Label></td>
    <td>:</td>
    <td><asp:Label ID="lblnameval" runat="server" Text='<%#Eval("name")%>'></asp:Label></td>
    </tr>
    <tr>
    <td align="right" style="padding-right:15px;">
    <asp:Label ID="lbltype" runat="server" Text="Registered Type"></asp:Label>
    </td>
    <td>:</td>
    <td><asp:Label ID="lbltypeval" runat="server" Text='<%#Eval("RegType")%>'></asp:Label></td>
    </tr>
    <tr>
    <td align="right" style="padding-right:15px;">
    <asp:Label ID="lbldate" runat="server" Text="Registered on"></asp:Label>
    </td>
    <td>:</td>
    <td><asp:Label ID="lbldateval" runat="server" Text='<%#Eval("iRegDate")%>'></asp:Label></td>
    </tr>
    <tr>
    <td align="right" style="padding-right:15px;">
    <asp:Label ID="lblmob" runat="server" Text="Registered MobileNo"></asp:Label>
    </td>
    <td>:</td>
    <td><asp:Label ID="lblmobval" runat="server" Text='<%#Eval("mob")%>'></asp:Label></td>
    </tr>
    <tr>
    <td align="right" style="padding-right:15px;">
    <asp:Label ID="lblmail" runat="server" Text="Registered Mail"></asp:Label>
    </td>
    <td>:</td>
    <td><asp:Label ID="lblmailval" runat="server" Text='<%#Eval("email")%>'></asp:Label></td>
    </tr>
    <tr>
    <td align="right" style="padding-right:15px;">
    <asp:Label ID="lblcity" runat="server" Text="City"></asp:Label>
    </td>
    <td>
    :
    </td>
    <td><asp:Label ID="lblcityval" runat="server" Text='<%#Eval("city")%>'></asp:Label></td>
    </tr>
    <tr>
    <td align="right" style="padding-right:15px;">
    <asp:Label ID="lblstate" runat="server" Text="State"></asp:Label>
    </td>
    <td>:</td>
    <td><asp:Label ID="lblstateval" runat="server" Text='<%#Eval("state")%>'></asp:Label></td>
    </tr>
    <tr>
    <td align="right" style="padding-right:15px;"><asp:Label ID="lblpin" runat="server" Text="Pincode"></asp:Label></td>
    <td>:</td>
    <td><asp:Label ID="lblpinval" runat="server" Text='<%#Eval("PinCode")%>'></asp:Label></td>
    </tr>
    <tr>
    <td colspan="3" align="center">
    <asp:Label ID="lblbusiness" runat="server" Text="Business Details" Width="700px" BackColor="Silver" Font-Bold="true" Font-Size="Medium"></asp:Label>
    </td>
    </tr>
    <tr><td></td></tr>
    <tr>
    <td align="right" style="padding-right:15px;">
    <asp:Label ID="lblbname" runat="server" Text="Business Name"></asp:Label>
    </td>
    <td>:</td>
    <td><asp:Label ID="lblbnameval" runat="server" Text='<%#Eval("bname")%>'></asp:Label></td>
    </tr>
    <tr>
    <td align="right" style="padding-right:15px;"><asp:Label ID="lblkbusiness" runat="server" Text="Kind Of Business"></asp:Label>
    </td>
    <td>:</td>
    <td><asp:Label ID="lblkbusinessval" runat="server" Text='<%#Eval("kindofbusiness")%>'></asp:Label></td>
    </tr>
    <tr>
    <td align="right" style="padding-right:15px;">
    <asp:Label ID="lbldes" runat="server" Text="Description"></asp:Label>
    </td>
    <td>:</td>
    <td><asp:Label ID="lbldesval" runat="server" Text='<%#Eval("des")%>'></asp:Label></td>
    </tr>
    <tr>
    <td align="right" style="padding-right:15px;"><asp:Label ID="lblmodule" runat="server" Text="Module"></asp:Label></td>
    <td>:</td>
    <td><asp:Label ID="lblmoduleval" runat="server" Text='<%#Eval("module")%>'></asp:Label></td>
    </tr>
    <tr>
    <td align="right" style="padding-right:15px;"><asp:Label ID="lblCategory" runat="server" Text="Category"></asp:Label></td>
    <td>:</td>
    <td><asp:Label ID="lblCategoryval" runat="server" Text='<%#Eval("Category")%>'></asp:Label></td>
    </tr>
    <tr>
    <td align="right" style="padding-right:15px;"><asp:Label ID="lblsubcat" runat="server" Text="SubCategory"></asp:Label></td>
    <td>:</td>
    <td><asp:Label ID="lblsubcatval" runat="server" Text='<%#Eval("SubCategory")%>'></asp:Label></td>
    </tr>
    <tr><td align="right" style="padding-right:15px;">
    <asp:Label ID="lblStatus" runat="server" Text="Status"></asp:Label>
    </td>
    <td>:</td>
    <td><asp:Label ID="lblStatusval" runat="server" Text='<%#Eval("ApprovedStatus")%>'></asp:Label></td>
    </tr>
    <tr>
    <td align="right" style="padding-right:15px;"><asp:Label ID="lblwebsite" runat="server" Text="WebSite"></asp:Label></td>
    <td>:</td>
    <td><asp:Label ID="lblwebsiteval" runat="server" Text='<%#Eval("website")%>'></asp:Label></td>
    </tr>
    <tr>
    <td align="right" style="padding-right:15px;"><asp:Label ID="lblfax" runat="server" Text="Fax"></asp:Label></td>
    <td>:</td>
    <td><asp:Label ID="lblfaxval" runat="server" Text='<%#Eval("fax")%>'></asp:Label></td>
    </tr>
    <tr><td style="height:30px;"></td></tr>
    <tr><td colspan="3" align="center"><asp:LinkButton ID="lnkedit" runat="server" Text="Click here" CommandArgument='<%#Eval("dataid")%>' OnCommand="linkto_edit"></asp:LinkButton>&nbsp;&nbsp;for further modifications .</td></tr>
    </table>
    </td></tr></table>
    </td></tr></table>
    </div>
    </center>
    </form>
</body>
</html>
