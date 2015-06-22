<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Admin_AdsHeader.ascx.cs" Inherits="admin_user_control_Admin_AdsHeader" %>
<table cellpadding="5px" width="100%" style="border:0px  solid #B8962E">
  <tr>
    <td style="background-color:#B40404" bgcolor="#CC0000" width="25%" align="center" class="subheading">
        <asp:LinkButton ID="lnkbtnHome" runat="server" onclick="lnkbtnHome_Click" Font-Size="14px" ForeColor="White" Font-Underline="false">Ads Home</asp:LinkButton>
    </td>
    <td style="background-color:#B40404" bgcolor="#CC0000" width="25%"  align="center" id="td1" runat="server" class="subheading">
        <asp:LinkButton ID="lnkBtnComments" runat="server" onclick="lnkBtnComments_Click" Font-Size="14px" ForeColor="White" Font-Underline="false" 
           >View Comments</asp:LinkButton>
    </td>
    <td style="background-color:#B40404" bgcolor="#CC0000" width="25%" id="td2" runat="server"  align="center" class="subheading">
        <asp:LinkButton ID="lnkBtnViewRatings" runat="server" Font-Size="14px" ForeColor="White" Font-Underline="false" onclick="lnkBtnViewRatings_Click"  
           >View Ratings</asp:LinkButton>
    </td>
    <td style="background-color:#B40404" bgcolor="#CC0000" width="25%" id="tdPostAds" runat="server"  align="center" class="subheading">
        <asp:LinkButton ID="lnkbtnPostAds" runat="server" onclick="lnkbtnPostAds_Click" Font-Size="14px" ForeColor="White" Font-Underline="false">Post Ads</asp:LinkButton>
    </td>
  </tr>
</table>