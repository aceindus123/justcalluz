<%@ Control Language="C#" AutoEventWireup="true" CodeFile="footer1.ascx.cs" Inherits="usercontrols_footer1" %>
<%--<table width="930px" border="0" cellpadding="0" cellspacing="0">
<tr><td height="50"></td></tr>
<tr>
<td class="footer" align="center">
    <a href="Default.aspx" style="text-decoration:none;">Home</a>&nbsp;&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;&nbsp;
    <a href="Aboutus.aspx" style="text-decoration:none;">About Us</a>&nbsp;&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;&nbsp;
    <a href="contactus.aspx" style="text-decoration:none;">Contact Us</a>&nbsp;&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;&nbsp;    
    <a href="Disclaimer.aspx" style="text-decoration:none;">Disclaimer</a>&nbsp;&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;&nbsp;    
    <a href="Feedback.aspx" style="text-decoration:none;">Feedback</a>&nbsp;&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;&nbsp;    
    <a href="privacypolicy.aspx" style="text-decoration:none;">Privacy Policy</a>
</td>

</tr>
<!--end of footer-->
<tr><td height="5"></td></tr></table>--%>
<table width="100%" border="0"  bgcolor="#002F5E">
    <tr>
      <%--<td width="6%" align="center" ><a href="Default.aspx"><font color="#FFFFFF">Home</font></a></td>
      <td width="1%" ><font color="#FFFFFF">|</font></td>--%>
      <td width="7%" align="center"><asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="<%$RouteUrl:RouteName=Aboutjcalluz%>" Font-Underline="false" Target="_blank" ForeColor="White">About Us</asp:HyperLink></td>
      <td width="1%"><font color="#FFFFFF">|</font></td>
      <td width="8%" align="center"><asp:HyperLink ID="HyperLink55" runat="server" NavigateUrl="<%$RouteUrl:RouteName=desclaimer %>" Font-Underline="false" Target="_blank" ForeColor="White">Disclaimer</asp:HyperLink></td>
      <td width="1%"><font color="#FFFFFF">|</font></td>
      <td width="7%" align="center"><asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="<%$RouteUrl:RouteName=feedback %>" Font-Underline="false" Target="_blank" ForeColor="White">Feedback</asp:HyperLink></td>
      <td width="1%"><font color="#FFFFFF">|</font></td>
      <td width="10%" align="center"><asp:HyperLink ID="HyperLink38" runat="server" NavigateUrl="<%$RouteUrl:RouteName=private %>" Font-Underline="false" Font-Size="10" Target="_blank" ForeColor="White">Privacy Policy</asp:HyperLink></td>
      
      <td width="1%"><font color="#FFFFFF">|</font></td>
      <td width="8%" align="center">      
     <asp:HyperLink ID="lnkedu" runat="server" NavigateUrl="<%$RouteUrl:RouteName=Education,cname=Education and Training %>" Text="Education" ForeColor="White" Target="_blank"></asp:HyperLink>
      </td>
      <td width="1%"><font color="#FFFFFF">|</font></td>
      <td width="5%" align="center">     
      <asp:HyperLink ID="lnktravel" runat="server" NavigateUrl="<%$RouteUrl:RouteName=Travels,cname=Travel Services %>" Text="Travel" ForeColor="White" Target="_blank"></asp:HyperLink>     
      </td>
      <td width="1%"><font color="#FFFFFF">|</font></td>
      <td width="8%" align="center">
      <asp:HyperLink ID="lnkcomp" runat="server" NavigateUrl="<%$RouteUrl:RouteName=Computers,cname=Computers and Peripherals %>" Text="Computers" ForeColor="White" Target="_blank"></asp:HyperLink>     
      </td>
      <td width="1%"><font color="#FFFFFF">|</font></td>
      <td width="7%" align="center">
      <a id="A1" href="<%$RouteUrl:RouteName=Builders,cname=Builders%>" runat="server" target="_blank"><asp:Label ID="Label6" Text="Real Estate" runat="server" ForeColor="White"></asp:Label></a>          
      </td>
      <td width="1%"><font color="#FFFFFF">|</font></td>
      <td width="8%" align="center"><a href="<%$RouteUrl:RouteName=discounts,cname=discounts%>" runat="server" target="_blank"><font color="#FFFFFF">Discounts</font></a></td>
      <td width="1%"><font color="#FFFFFF">|</font></td>
      <td width="5%" align="center"><a href= "<%$RouteUrl:RouteName=Events,cname=events%>" runat="server" target="_blank"><font color="#FFFFFF">Events</font></a></td>
      <td width="1%"><font color="#FFFFFF">|</font></td>
      <td width="10%" align="center"><a href="<%$RouteUrl:RouteName=contact%>" runat="server" target="_blank"><font color="#FFFFFF">Contact Us</font></a></td>
      </tr>
    </table>
