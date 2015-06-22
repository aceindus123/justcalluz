<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Admin_SSHeader.ascx.cs" Inherits="admin_user_control_Admin_SSHeader" %>
<table cellpadding="5px" width="100%" style="border:0px  solid #B8962E ">
  <tr>
    <td style="background-color:#B40404" bgcolor="#CC0000" width="25%" align="center" class="subheading">
    <asp:LinkButton ID="lnkbtnHome" runat="server" onclick="lnkbtnHome_Click" Font-Size="14px" ForeColor="White" Font-Underline="false">Success Stories Home</asp:LinkButton>
    </td>    
    <td style="background-color:#B40404" bgcolor="#CC0000" width="25%" align="center" id="tdPostAds" runat="server" class="subheading">
    <asp:LinkButton ID="lnkbtnPostSS" runat="server" Font-Size="14px" 
            ForeColor="White" Font-Underline="false" onclick="lnkbtnPostSS_Click">To Post Success Stories</asp:LinkButton>
    </td>
    <td style="background-color:#B40404" bgcolor="#CC0000" width="25%" align="center" id="td1" runat="server" class="subheading">
    <asp:LinkButton ID="lnkBtnPostSSVideos" runat="server" Font-Size="14px" 
            ForeColor="White" Font-Underline="false" onclick="lnkBtnPostSSVideos_Click">To Post Success Videos</asp:LinkButton>
    </td>
     <td style="background-color:#B40404" bgcolor="#CC0000" width="25%" align="center" id="td2" runat="server" class="subheading">
    <asp:LinkButton ID="lnkBtnViewVideos" runat="server" Font-Size="14px" 
            ForeColor="White" Font-Underline="false" onclick="lnkBtnViewVideos_Click">To View Success Videos</asp:LinkButton>
    </td>
  </tr>
</table>