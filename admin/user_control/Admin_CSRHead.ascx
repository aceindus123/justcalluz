<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Admin_CSRHead.ascx.cs" Inherits="admin_user_control_Admin_CSRHead" %>
<table cellpadding="5px" width="100%" style="border:0px  solid #B8962E">
  <tr>
    <td style="background-color:#B40404" bgcolor="#CC0000" width="50%" align="center" class="subheading">
        <asp:LinkButton ID="lnkbtnHome" runat="server" onclick="lnkbtnHome_Click" Font-Size="14px" ForeColor="White" Font-Underline="false">CSR Home</asp:LinkButton>
    </td>    
    <td style="background-color:#B40404" bgcolor="#CC0000" width="50%" id="tdPostCSR" runat="server"  align="center" class="subheading">
        <asp:LinkButton ID="lnkbtnPostCSR" runat="server" Font-Size="14px" 
            ForeColor="White" Font-Underline="false" onclick="lnkbtnPostCSR_Click">Post CSR</asp:LinkButton>
    </td>
  </tr>
</table>