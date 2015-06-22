<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Admin_MediaHeader.ascx.cs" Inherits="admin_user_control_Admin_MediaHeader" %>
<table cellpadding="5px" width="100%" style="border:0px  solid #B8962E ">
  <tr>
    <td style="background-color:#B40404" bgcolor="#CC0000" width="50%" align="center" class="subheading">
    <asp:LinkButton ID="lnkbtnHome" runat="server" onclick="lnkbtnHome_Click" Font-Size="14px" ForeColor="White" Font-Underline="false">Media Speak Home</asp:LinkButton>
    </td>    
    <td style="background-color:#B40404" bgcolor="#CC0000" width="50%" align="center" id="tdPostAds" runat="server" class="subheading">
    <asp:LinkButton ID="lnkbtnPostMedia" runat="server" onclick="lnkbtnPostMedia_Click" Font-Size="14px" ForeColor="White" Font-Underline="false">To Post Media Speak</asp:LinkButton>
    </td>
  </tr>
</table>