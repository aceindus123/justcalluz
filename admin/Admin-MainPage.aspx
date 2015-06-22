<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Admin-MainPage.aspx.cs" ValidateRequest="false" Inherits="admin_Admin_MainPage" %>
<%@ Register Src="~/admin/user_control/Admin_Headermenu.ascx" TagName="Headermenu" TagPrefix="cc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>Justcalluz - Admin Control Panel - Login
</title>
<link href="includes/style.css" rel="stylesheet" type="text/css" />
 <style type="text/css">
 
 .text4
{
font-family:Verdana;
font-size:13px;
font-weight:bold;
color:Green;
}
  </style> 
  </head>
<body>
    <form id="form1" runat="server">
    <div>
        <!--begin of table-->
<table width="960" border="0" bordercolor="#003366"cellpadding="0" cellspacing="0" align="center">
<tr>
<td>
<table width="970" cellspacing="0" cellpadding="0">  
    <tr>
        <td align="left" >
            <cc1:headermenu ID="header" runat="server" />           
        </td>
        <td align="right" class="ent2" >
        </td>
    </tr>
    <tr>
        <td style="height:3px; background-color:#CC0000" colspan="2"></td>
    </tr>
</table>
 <table width="927" border="0" cellpadding="0" cellspacing="0" align="center"  style="margin-left:20px;"  >
<tr>
<td class="content22" valign="top">
        <div class="content"> 
            <asp:Panel ID="Panel1" runat="server" Width="990px" tyle="background-image:url(images/rcbg2.jpg)" CssClass="button1" align="center">
                <table border="0" width="80%" align="center">
                 <tr><td colspan="7" height="50px">&nbsp;</td></tr>
                    <tr>
                        <td align="center" class="style1"><asp:ImageButton ID="imgrc" ImageUrl="../admin/images/Admin.png" PostBackUrl="Admin_Home.aspx" runat="server" /></td>
                        <td class="style1"></td>
                        <td align="center" class="style1"><asp:ImageButton ID="imgservices" ImageUrl="../admin/images/user.png" runat="server" PostBackUrl="Admin-UserDetails.aspx"  /></td>
                        <td class="style1"></td>
                        <td align="center" class="style1"><asp:ImageButton ID="imgsupport" ImageUrl="../admin/images/Categories.png" runat="server" PostBackUrl="Admin_Home.aspx?mod=Category" /></td>
                        <td class="style1"></td>
                        <td align="center" class="style1"><asp:ImageButton ID="imgbtnpostjobs" ImageUrl="../admin/images/Categories2.png" runat="server" PostBackUrl="Admin_Home.aspx?mod=B2B Category"/></td>
                       
                    </tr>
                    <tr>
                        <td align="center">
                            <a href="Admin_Home.aspx"><font color='darkblue' style="font-size:14px;font-family:Verdana;font-family:Verdana;">Admin</font></a>
                        </td>
                        <td>&nbsp;</td>
                        <td align="center">
                            <a href="Admin-UserDetails.aspx"><font color='darkblue'  style="font-size:14px;font-family:Verdana;">Users</font></a>
                        </td>
                        <td>&nbsp;</td>
                        <td align="center">
                            <a href="Admin_Home.aspx?mod=Category"><font color='darkblue'  style="font-size:14px;font-family:Verdana;">Popular Categories</font></a>
                        </td>
                         <td>&nbsp;</td>
                        <td align="center">
                            <a href="Admin_Home.aspx?mod=B2B Category"><font color='darkblue'  style="font-size:14px;font-family:Verdana;">B2B Categories</font></a>
                        </td>
                       
                     </tr>
                     <tr><td colspan="7" height="40px">&nbsp;</td></tr>
                     <tr>
                        <td align="center"><asp:ImageButton ID="imgpermission" ImageUrl="../admin/images/Events.png" PostBackUrl="Admin_Home.aspx?mod=Events" runat="server" /></td>    
                        <td>&nbsp;</td>
                        <td align="center"><asp:ImageButton ID="imgads" ImageUrl="../admin/images/Discounts2.png" PostBackUrl="Admin_Home.aspx?mod=Discounts" runat="server" /></td>
                        <td>&nbsp;</td>
                        <td align="center"><asp:ImageButton ID="imgjobfairs" ImageUrl="../admin/images/hotel.png" PostBackUrl="Admin-CategoryDetails.aspx?cate=Hotels"  runat="server" /></td>
                         <td>&nbsp;</td>
                        <td align="center"><asp:ImageButton ID="ImageButton2" ImageUrl="../admin/images/job.png" PostBackUrl="Admin_Home.aspx?mod=Jobs" runat="server" /></td>
                       
                    </tr>
                    <tr>
                        <td align="center">
                            <a href="Admin_Home.aspx?mod=Events"><font color='darkblue'  style="font-size:14px;font-family:Verdana;">Events</font></a>
                        </td>
                        <td>&nbsp;</td>
                        <td align="center">
                            <a href="Admin_Home.aspx?mod=Discounts"><font color='darkblue'  style="font-size:14px;font-family:Verdana;">Discounts</font></a>
                        </td>
                        <td>&nbsp;</td>
                        <td align="center">
                            <a href="Admin-CategoryDetails.aspx?cate=Hotels"><font color='darkblue'  style="font-size:14px;font-family:Verdana;">Hotels</font></a>
                        </td>
                         <td>&nbsp;</td>
                        <td align="center">
                            <a href="Admin_Home.aspx?mod=Jobs"><font color='darkblue'  style="font-size:14px;font-family:Verdana;">Jobs</font></a>
                        </td>
                       
                    </tr>
                     <tr><td colspan="7" height="40px">&nbsp;</td></tr>
                       <tr>
                        <td align="center"><asp:ImageButton ID="ImageButton1" ImageUrl="../admin/images/Builders2.png" PostBackUrl="Admin-CategoryDetails.aspx?cate=Builders" runat="server" /></td>    
                        <td>&nbsp;</td>
                        <td align="center"><asp:ImageButton ID="ImageButton3" ImageUrl="../admin/images/Computers.png" PostBackUrl="Admin-CategoryDetails.aspx?cate=Computers and Peripherals"  runat="server" /></td>
                        <td>&nbsp;</td>
                        <td align="center"><asp:ImageButton ID="ImageButton4" ImageUrl="../admin/images/Education.png" PostBackUrl="Admin-CategoryDetails.aspx?cate=Education and Training"  runat="server" /></td>
                         <td>&nbsp;</td>
                        <td align="center"><asp:ImageButton ID="ImageButton5" ImageUrl="../admin/images/Travel.png" PostBackUrl="Admin-CategoryDetails.aspx?cate=Travel Services" runat="server" /></td>
                       
                    </tr>
                    <tr>
                        <td align="center">
                            <a href="Admin-CategoryDetails.aspx?cate=Builders"><font color='darkblue'  style="font-size:14px;font-family:Verdana;">Builders</font></a>
                        </td>
                        <td>&nbsp;</td>
                        <td align="center">
                            <a href="Admin-CategoryDetails.aspx?cate=Computers and Peripherals"><font color='darkblue'  style="font-size:14px;font-family:Verdana;">Computers</font></a>
                        </td>
                        <td>&nbsp;</td>
                        <td align="center">
                            <a href="Admin-CategoryDetails.aspx?cate=Education and Training"><font color='darkblue'  style="font-size:14px;font-family:Verdana;">Education</font></a>
                        </td>
                         <td>&nbsp;</td>
                        <td align="center">
                            <a href="Admin-CategoryDetails.aspx?cate=Travel Services"><font color='darkblue'  style="font-size:14px;font-family:Verdana;">Travels</font></a>
                        </td>
                       
                    </tr>
                </table>
            </asp:Panel>
        </div>
  
</td>
</tr>
</table> 
    </td>
</tr>
</table>
    </div>
    </form>
</body>
</html>
