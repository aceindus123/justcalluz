<%@ Control Language="C#" AutoEventWireup="true" CodeFile="BottomMidContent.ascx.cs" Inherits="usercontrols_BottomMidContent" %>
<table width="100%" border="0">
  <tr>
    <td width="6%" align="right"><img alt="FreeListingIcon" src="images/free_ listing.png" width="28" height="28" /></td>
    <td width="21%" class="bottam" style="padding-left:10px;">
    <span class="bottam" style="padding-left:5px;">
    <asp:HyperLink ID="hlfreelist" runat="server" NavigateUrl="<%$RouteUrl:RouteName=Free%>" Font-Underline="false" ForeColor="#CC0000">Free Listing</asp:HyperLink>
        
    </span></td>
    <td width="4%" align="center"><img alt="SharingViews" src="images/pencial.png" width="32" height="32" /></td>
    <td width="34%" class="sub_menu">
    <font color="#CC0000" class="mid_menu">
    <asp:HyperLink ID="HyperLink24" runat="server" NavigateUrl="~/testimonials.aspx#shareViews" Font-Underline="false" ForeColor="#CC0000">Share Your Views About Justcalluz</asp:HyperLink>     
    </font>
    </td>
    <td width="5%" align="center"><img alt="AdvertiseIcon" src="images/advaties.png" width="32" height="32" /></td>
    <td width="30%" class="bottam" >
        <asp:HyperLink ID="hlAdvertise" runat="server" NavigateUrl="<%$RouteUrl:RouteName=Advertise %>" Font-Underline="false" ForeColor="#CC0000">Advertise</asp:HyperLink>   
       
    </td>
  </tr>
  <tr>
    <td colspan="6" height="" ><hr/></td>
    </tr>
</table>