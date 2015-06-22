<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Admin_WPHeader.ascx.cs" Inherits="admin_user_control_Admin_WPHeader" %>
<table cellpadding="5px" width="100%" style="border:0px  solid #B8962E ">
  <tr>
    <td style="background-color:#B40404" bgcolor="#CC0000" width="50%" align="center" class="subheading">
    <asp:LinkButton ID="lnkbtnHome" runat="server" onclick="lnkbtnHome_Click" Font-Size="14px" ForeColor="White" Font-Underline="false">White Pages Home</asp:LinkButton>
    </td>    
    <td style="background-color:#B40404" bgcolor="#CC0000" width="50%" align="center" id="tdPostAds" runat="server" class="subheading">
    <asp:LinkButton ID="lnkbtnPostWP" runat="server" onclick="lnkbtnPostWP_Click" Font-Size="14px" ForeColor="White" Font-Underline="false">To Post White Pages</asp:LinkButton>
    </td>
  </tr>
</table>