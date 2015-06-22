<%@ Control Language="C#" AutoEventWireup="true" CodeFile="CheckPostLeftMenu.ascx.cs" Inherits="usercontrols_CheckPostLeftMenu" %>
<table width="100%" border="0">
  
  <tr>
    <td height="10" colspan="2" align="left" class="sub_menu">Posting List</td>
    </tr>
  <tr>
    <td colspan="2" align="left" style="padding-left:5px;">
    <img alt="displayLine" src="images/under-line.png" width="160" height="6" />
    </td>
   </tr>
  <tr id="trAdvertise" runat="server">
    <%--<td align="right"><img src="images/arrow2.png" width="10" height="8" /></td>
    <td width="84%" height="22" class="side_menu">--%>
    <td>
   <ul style="padding-left:15px;">
  <li>
   <%-- <asp:LinkButton ID="lnkBtnBusInfo" runat="server" Font-Underline="false" onclick="lnkBtnBusInfo_Click">Advertise With Us Info</asp:LinkButton>--%>
    <a id="lnkBtnBusInfo" runat="server" onserverclick="lnkBtnBusInfo_Click">Advertise With Us Info</a>
    </li>
    </ul>
    </td>
   <%-- </td>--%>
  </tr>
  <tr id="trDiscounts" runat="server">
   <%--<td align="right"><img src="images/arrow2.png" width="10" height="8" /></td>
    <td class="side_menu" height="22">--%>
    <td>
    <ul style="padding-left:15px;">
    <li>
    <%--<asp:LinkButton ID="lnkBtnDiscounts" runat="server" Font-Underline="false" 
                        onclick="lnkBtnDiscounts_Click">Discounts</asp:LinkButton>--%>
    <a id="lnkBtnDiscounts" runat="server" onserverclick="lnkBtnDiscounts_Click">Discounts</a>
                        
    </li></ul>
    </td>
  </tr>
  <tr id="trEvents" runat="server">
   <%-- <td align="right"><img src="images/arrow2.png" width="10" height="8" /></td>
    <td class="side_menu" height="22">--%>
    <td>
    <ul style="padding-left:15px;">
    <li>
    <%--<asp:LinkButton ID="lnkbtnEvents" runat="server" Font-Underline="false" 
                        onclick="lnkbtnEvents_Click">Events</asp:LinkButton>--%>
    <a id="lnkbtnEvents" runat="server" onserverclick="lnkbtnEvents_Click">Events</a>
                        
     </li></ul>
    </td>
  </tr>
  <tr id="trFreeListing" runat="server">
<%--<td align="right"><img src="images/arrow2.png" width="10" height="8" /></td>
    <td class="side_menu" height="22">--%>
    <td>
    <ul style="padding-left:15px;">
   <li>
   <%-- <asp:LinkButton ID="lnkBtnFreeListing" runat="server" Font-Underline="false" 
                        onclick="lnkBtnFreeListing_Click">Free Listing</asp:LinkButton>--%>
    <a id="lnkBtnFreeListing" runat="server" onserverclick="lnkBtnFreeListing_Click">Free Listing</a>
                        
    </li></ul>
    </td>
  </tr>
  <tr id="trJobs" runat="server">
  <%--<td align="right"><img src="images/arrow2.png" width="10" height="8" /></td>
    <td class="side_menu" height="22">--%>
    <td>
    <ul style="padding-left:15px;">
    <li>
    <%--<asp:LinkButton ID="lnkBtnJobs" runat="server" Font-Underline="false" 
                        onclick="lnkBtnJobs_Click">Jobs</asp:LinkButton>--%>
    <a id="lnkBtnJobs" runat="server" onserverclick="lnkBtnJobs_Click">Jobs</a>
    
     </li></ul>
    </td>
  </tr>
 <%--   <tr id="trLifeStyle" runat="server">
    <td align="right"><img src="images/arrow2.png" width="10" height="8" /></td>
    <td class="side_menu" height="22">
    <td>
    <ul style="padding-left:15px;">
    <li>
      <asp:LinkButton ID="lnklifestylebtn" runat="server" Font-Underline="false" 
                        onclick="lnklifestylebtn_Click">LifeStyle</asp:LinkButton>
    <a id="lnklifestylebtn" runat="server" onserverclick="lnklifestylebtn_Click">LifeStyle</a>
     
    </li></ul>
    </td>
  </tr>--%>
</table>