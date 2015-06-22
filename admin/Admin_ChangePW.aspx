<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Admin_ChangePW.aspx.cs" Inherits="admin_Admin_ChangePW" %>
<%@ Register Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" TagPrefix="cc3"  %>
<%@ Register Src="~/admin/user_control/Admin_Headermenu.ascx" TagName="Headermenu" TagPrefix="cc1" %>
<%@ Register Src="~/admin/user_control/Admin_LeftMenu.ascx" TagName="LeftMenu" TagPrefix="cc4" %>
<%@ Register Src="~/admin/user_control/Admin_ProfileHeader.ascx" TagName="ProfileHeader" TagPrefix="profile" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="AjaxToolkit" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<title>Justcalluz - Admin Control Panel - Change Password</title>
    <link href="includes/style.css" rel="Stylesheet" type="text/css" />
    <script type="text/javasrcipt" src="http://ajax.googleapis.com/ajax/libs/jquery/1.6.2/jquery.min.js"></script>
    <script src="js/statesopt.js"></script>
    
    <style type="text/css">
        .style37
        {
            width: 900px;
        }
        .style39
        {
            width: 100px;
        }        
        </style>              	
        <script type="text/javascript" src="js/tab.js"></script></head>
<body onload="new Accordian('basic-accordian',5,'header_highlight');">
    <form id="form1" runat="server">
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
                <td class="style39" valign="top" style="padding-top:10px">                        
                 <cc4:LeftMenu ID="LeftMenu1" runat="server" />
                </td>
                <td valign="top">&nbsp;</td>
                <td valign="top" style="padding-left:10px; background-color:#F2FAFC">  
                    <table width="750px">
                      <tr>
                        <td colspan="3">      
                           <profile:ProfileHeader ID="profilehead" runat="server" />                                   
                        </td>
                      </tr>
                      <tr><td height="25px" colspan="3">
                          <asp:ScriptManager ID="ScriptManager1" runat="server">
                          </asp:ScriptManager>
                      </td></tr>
                      <tr>
                        <td align="center" colspan="3">
                          <span style="font-size:21px; font-weight:bold; color:DarkBlue"> Change password</span> 
                        </td>
                      </tr>
                      <tr>
                      <td height="15px" colspan="3"></td>
                      </tr>
                      <tr>
                        <td colspan="3">
                            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                <ContentTemplate>
                                    <table width="100%" class="adminform">
                                      <tr>
                                        <td align="center" colspan="3">
                                           <span style="font-weight:bold">Note:</span> you can't reuse your old password once you change it!
                                        </td>
                                      </tr>
                                      <tr><td colspan="3" height="10px"></td></tr>
                                      <tr>
                                        <td align="right">
                                            Current password
                                        </td>
                                        <td align="center">:</td>
                                        <td> 
                                            <asp:TextBox ID="txtoldPW" runat="server" TextMode="Password"></asp:TextBox>
                                        </td>
                                      </tr>
                                      <tr height="30px">
                                          <td colspan="2"></td>
                                          <td> 
                                              <asp:Label ID="lbloldmsg" runat="server" ForeColor="Red"></asp:Label>                                                                      
                                          </td>
                                      </tr>
                                      <tr>
                                        <td align="right">
                                            New password
                                        </td>
                                        <td align="center">:</td>
                                        <td>
                                            <asp:TextBox ID="txtnewPW" runat="server" TextMode="Password"></asp:TextBox>
                                        </td>
                                      </tr>
                                      <tr height="30px">
                                          <td colspan="2"></td>
                                          <td>
                                              <asp:Label ID="lblnewmsg" runat="server" ForeColor="Red"></asp:Label>                                             
                                          </td>
                                      </tr>
                                      <tr>
                                        <td align="right">
                                            Confirm new password
                                        </td>
                                        <td align="center">:</td>
                                        <td>
                                            <asp:TextBox ID="txtConfirmNewPw" runat="server" TextMode="Password"></asp:TextBox>
                                        </td>
                                      </tr>
                                      <tr height="30px">
                                          <td colspan="2"></td>
                                          <td>
                                              <asp:Label ID="lblConPW" runat="server" ForeColor="Red"></asp:Label>                                             
                                          </td>
                                      </tr> 
                                   </table>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                            
                        </td>
                      </tr>
                      
                      <tr>
                        <td colspan="3" align="center">
                            <asp:ImageButton ID="btnSave" runat="server" ImageUrl="~/admin/images/save.png" ValidationGroup="ChangePWAdmin" 
                                onclick="btnSave_Click" />
                          &nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:ImageButton ID="btnCancel" runat="server" 
                                ImageUrl="~/admin/images/cancel.png" onclick="btnCancel_Click" />                          
                        </td>
                      </tr>                    
                    </table>
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
