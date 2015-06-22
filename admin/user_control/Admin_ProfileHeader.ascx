<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Admin_ProfileHeader.ascx.cs" Inherits="admin_user_control_Admin_ProfileHeader" %>
<table cellpadding="5px" width="100%" style="border:0px  solid #B8962E ">
  <tr>
    <td style="background-color:#B40404" bgcolor="#CC0000" width="50%" align="center" class="subheading">
    <asp:LinkButton ID="lnkProfile" runat="server" Font-Size="14px" ForeColor="White" Font-Underline="false" 
            onclick="lnkProfile_Click">Profile</asp:LinkButton>
    </td>
    <td style="background-color:#B40404" bgcolor="#CC0000" width="50%" align="center" id="tdPostCareers" runat="server" class="subheading">
    <asp:LinkButton ID="lnkbChangePW" runat="server" Font-Size="14px" ForeColor="White" Font-Underline="false"
            onclick="lnkbChangePW_Click">Change Password</asp:LinkButton>
    </td>
  </tr>
</table>