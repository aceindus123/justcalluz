<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="admin_Default" %>
<%@ Register Src="~/admin/user_control/Admin_Headermenu.ascx" TagName="Headermenu" TagPrefix="cc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
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
<asp:Panel ID="PnlLoginPage" runat="server" DefaultButton="btnLogin">
 <table width="927" border="0" cellpadding="0" cellspacing="0" align="center"  style="margin-left:20px;"  >
<tr>
<td class="content22" valign="top">
   <div align="center">    
     <table border="0" cellspacing="0" cellpadding="0"  style="margin-top:30px;">
        <tr>
        <td colspan="3" style="font-family:Bookman Old Style; font-size:18px; color:maroon;" align="center"><u><b>Admin Login</b></u>
          <table border="0" cellpadding="0" cellspacing="0" 
                style="margin-top:60px; height:158px; width: 448px;">
           <%-- <tr>
                <td colspan="3">
                 <table width="100%">
                    <tr>
                        <td>
                            <asp:RadioButton ID="rbtnadmin" runat="server" Text="Admin" GroupName="login" />   
                        </td>
                        <td>
                            <asp:RadioButton ID="rbtnwebadmin" runat="server" Text="Web Admin" GroupName="login" />
                        </td>
                    </tr>
                 </table>
                    
                </td>
            </tr>--%>
             <tr>
              <td align="center" class="text4">&nbsp;User Type</td>
              <td class="text4" >&nbsp; : &nbsp;</td>
              <td align="left">
                  <asp:DropDownList ID="ddlUsertype" runat="server" Width="172px">
                    <asp:ListItem Text="Select" Selected="True">Select</asp:ListItem>
                    <asp:ListItem Text="Admin" >Admin</asp:ListItem>
                    <asp:ListItem Text="Web Admin" >Web Admin</asp:ListItem>
                    <asp:ListItem Text="Developer" >Developer</asp:ListItem>
                    <asp:ListItem Text="Analyst" >Analyst</asp:ListItem>
                    <asp:ListItem Text="Sales" >Sales</asp:ListItem>
                    <asp:ListItem Text="Customer Service">Customer Service</asp:ListItem>
                     <asp:ListItem Text="Support" >Support</asp:ListItem>
                    <asp:ListItem Text="Business Development" >Business Development</asp:ListItem>
                                               
                  </asp:DropDownList>
                  <asp:RequiredFieldValidator ID="rfvddlUsertype" runat="server" ErrorMessage="Select user type" 
                          ValidationGroup="login" ControlToValidate="ddlUsertype" InitialValue="Select">*</asp:RequiredFieldValidator>
                  
              </td>
            </tr>
             <tr>
              <td align="center" class="text4">&nbsp;&nbsp;&nbsp; Country</td>
              <td class="text4" >&nbsp; : &nbsp;</td>
              <td align="left">
                  <asp:DropDownList ID="ddlCountry" runat="server" Width="172px">
                    <asp:ListItem Text="Select" Selected="True">Select</asp:ListItem>
                    <asp:ListItem Text="India" >India</asp:ListItem>
                    <asp:ListItem Text="USA" >USA</asp:ListItem>
                    <asp:ListItem Text="UK" >UK</asp:ListItem>
                    <asp:ListItem Text="Australia" >Australia</asp:ListItem>
                    <asp:ListItem Text="Singapoor" >Singapore</asp:ListItem>
                                                                 
                  </asp:DropDownList>
                  <asp:RequiredFieldValidator ID="rfvddlCountry" runat="server" ErrorMessage="Select country" 
                          ValidationGroup="login" ControlToValidate="ddlCountry" InitialValue="Select">*</asp:RequiredFieldValidator>
                  
              </td>
            </tr>
            <tr>
              <td align="center" class="text4">&nbsp;&nbsp;&nbsp;&nbsp; User Id</td>
              <td class="text4" >&nbsp; : &nbsp;</td>
              <td align="left">
                  <asp:TextBox ID="txtUserId" runat="server" Width="167px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvtxtUserId" runat="server" ErrorMessage="Select User id" 
                          ValidationGroup="login" ControlToValidate="txtUserId" >*</asp:RequiredFieldValidator>
                  
              </td>
            </tr>
            <tr>
              <td align="center" class="text4">Password</td>
              <td class="text4" >&nbsp; : &nbsp&nbsp;</td>
              <td align="left">
                  <asp:TextBox ID="txtPwd" runat="server" Width="167px" TextMode="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvtxtPwd" runat="server" ErrorMessage="Enter password" 
                          ValidationGroup="login" ControlToValidate="txtPwd" >*</asp:RequiredFieldValidator>
              </td>
            </tr>
            <tr>
              <td align="center" colspan="3">
                  <asp:Button ID="btnLogin" runat="server" Text="Login" Width="87px" 
                      Font-Size="13px" ForeColor="white" BackColor="Chocolate" 
                      onclick="btnLogin_Click" ValidationGroup="login"/>                  
              </td>
            </tr>
             <tr>
              <td align="center" colspan="3">
                 <asp:ValidationSummary ID="ValidationSummary1" runat="server"  ShowMessageBox="true" ShowSummary="false"
                            ValidationGroup="login"/>                  
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
</asp:Panel>
    </td>
</tr>
</table>
    </div>
    </form>
</body>
</html>
