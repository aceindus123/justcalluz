<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Admin_Login.aspx.cs" Inherits="Admin_Login" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>Justcallus</title>
<link href="style.css" rel="stylesheet" type="text/css" />
 <style type="text/css">
 
 .text4
{
font-family:Bookman Old Style;
font-size:13px;
font-weight:bold;
color:Green;
}
  </style> 
</head>
<body>
<form id="f1" runat="server" >
<!--begin of table-->
<table width="960" border="0" bordercolor="#003366"cellpadding="0" cellspacing="0" align="center">
<tr>
<td>
<table width="970" cellspacing="0" cellpadding="0">
   <%-- <tr align="right">
        <td>
            <asp:Label ID="l1" runat="server" Text="LogIn:" Font-Size="medium" ForeColor="Chocolate" Font-Bold="true"></asp:Label>
            <asp:Label ID="l2" runat="server" Font-Size="medium"></asp:Label>
        </td>
    </tr>--%>
    <tr>
        <td align="left" >
            <a id="A1" href="Default.aspx" runat="server"><img src="images/Adimin control.jpg" style="border:none" width="100%"></a>
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
   <div align="center">
    
     <table border="0" cellspacing="0" cellpadding="0"  style="margin-top:30px;">
        <tr>
        <td colspan="3" style="font-family:Bookman Old Style; font-size:18px; color:maroon;"><u><b>Admin Login</b></u>
          <table border="0" cellpadding="0" cellspacing="0" 
                style="margin-top:60px; height:158px; width: 448px;">
            <tr>
              <td align="center" class="text4">USER ID</td>
              <td class="text4" >&nbsp; : &nbsp;</td>
              <td align="left">
                  <asp:TextBox ID="txtUserId" runat="server" Width="167px"></asp:TextBox></td>
            </tr>
            <tr>
              <td align="center" class="text4">PASSWORD</td>
              <td class="text4" >&nbsp; : &nbsp&nbsp;</td>
              <td align="left">
                  <asp:TextBox ID="txtPWD" runat="server" Width="167px" TextMode="Password"></asp:TextBox></td>
            </tr>
            <tr>
              <td align="center" colspan="3">
                  <asp:Button ID="AdminLogin" runat="server" Text="Login" Width="87px" 
                      Font-Size="13px" ForeColor="white" BackColor="Chocolate" 
                      onclick="AdminLogin_Click" />
                  <%--<asp:ImageButton ID="ImageAdmin_Login" runat="server" ImageUrl="~/images/button2.jpg" />--%>
              </td>
            </tr>
             <tr>
       <td id="tdmsg" colspan="3"  align="right" runat="server" style="height: 23px">
           
       </td>
   </tr>
              </table>
          
          
          </td></tr>
     </table>
   </div>

 
<!--end of content-->
</td>
</tr>
</table>
 
    </td>
</tr>
</table>
  </form>  
</body>
</html>

