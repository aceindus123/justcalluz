<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Admin_DataHeader.ascx.cs" Inherits="admin_user_control_Admin_DataHeader" %>
<table cellpadding="5px" width="100%" style="border:0px  solid #B8962E ">
  <tr>
    <td style="background-color:#B40404" bgcolor="#CC0000" width="50%" align="center" class="subheading">                              
        <asp:LinkButton ID="lnkbtnHome" runat="server"
          Font-Size="14px" ForeColor="White" Font-Underline="false" onclick="lnkbtnHome_Click">Admin Home</asp:LinkButton>
    </td>
    <td style="background-color:#B40404" bgcolor="#CC0000" width="50%"  align="center" class="subheading">
        <asp:LinkButton ID="lnkbtnPostData" runat="server" 
           Font-Size="14px" ForeColor="White" Font-Underline="false" onclick="lnkbtnPostData_Click">Post Data</asp:LinkButton>
    </td>
  </tr>
</table>