<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Admin_DeleteData.aspx.cs" Inherits="admin_Admin_DeleteCatData" %>
<%@ Register Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" TagPrefix="cc3"  %>
<%@ Register Src="~/admin/user_control/Admin_Headermenu.ascx" TagName="Headermenu" TagPrefix="cc1" %>
<%@ Register Src="~/admin/user_control/Admin_LeftMenu.ascx" TagName="LeftMenu" TagPrefix="cc4" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title>Justcalluz - Admin Control Panel - Delete data</title>
    <link href="includes/style.css" rel="Stylesheet" type="text/css" />
    <script type="text/javasrcipt" src="http://ajax.googleapis.com/ajax/libs/jquery/1.6.2/jquery.min.js"></script>
    <script src="js/statesopt.js"></script>
    <style type="text/css">
        .style37
        {
            width: 664px;
        }
        .style39
        {
            width: 195px;
        }        
        </style>             
        <script type="text/javascript" src="js/tab.js"></script>
</head>
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
                <td valign="top" style="padding:10px; padding-left:50px" class="style37">  
                    <table width="100%">
                        <tr>
                            <td>                                
                                <asp:LinkButton ID="lnkbtnHome" runat="server" ForeColor="Blue" 
                                    Font-Size="Small" onclick="lnkbtnHome_Click">Admin Home</asp:LinkButton>
                            </td>
                            <td align="right">
                                <asp:LinkButton ID="lnkbtnPostData" runat="server" ForeColor="Blue" 
                                    Font-Size="Small" onclick="lnkbtnPostData_Click">To Post Data</asp:LinkButton>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <asp:ScriptManager ID="ScriptManager1" runat="server">
                                </asp:ScriptManager>
                            </td>
                        </tr>                                              
                        <tr>
                            <td colspan="2">
                                <asp:Label ID="lblMessage" runat="server"></asp:Label>
                            </td>
                        </tr>                                              
            <tr>
                <td>
                    
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
