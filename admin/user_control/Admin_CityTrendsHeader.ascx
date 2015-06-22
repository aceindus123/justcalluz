<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Admin_CityTrendsHeader.ascx.cs" Inherits="admin_user_control_Admin_CityTrendsHeader" %>
<table cellpadding="5px" width="100%" style="border:0px  solid #B8962E ">
  <tr>
    <td style="background-color:#B40404" bgcolor="#CC0000" width="50%" align="center" class="subheading">
    <asp:LinkButton ID="lnkbtnHome" runat="server" onclick="lnkbtnHome_Click" Font-Size="14px" ForeColor="White" Font-Underline="false">City Trends Home</asp:LinkButton>
    </td>
    <td style="background-color:#B40404" bgcolor="#CC0000" width="50%" id="td1" runat="server" align="center" class="subheading">
    <asp:LinkButton ID="lnkBtnPostCT" runat="server" onclick="lnkBtnPostCT_Click" Font-Size="14px" ForeColor="White" Font-Underline="false"
           >Post City Trends</asp:LinkButton>
    </td>   
  </tr>
</table>