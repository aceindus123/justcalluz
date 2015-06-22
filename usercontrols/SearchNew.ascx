<%@ Control Language="C#" AutoEventWireup="true" CodeFile="SearchNew.ascx.cs" Inherits="usercontrols_SearchNew" %>
<%@ Import Namespace="System.Web.Routing" %>
<%--<link href="../css/home_style.css" type="text/css" rel="stylesheet" />--%>
<table width="100%" border="0">
  <tr>
    <td width="3%" align="center"><img src="../images/Popular_Search_Categories.jpg" width="24" height="24" /></td>
    <td width="17%"><a id="A1" href="<%$RouteUrl:RouteName=HomeRoute%>" runat="server" target="_blank"><asp:Label ID="lblPCat" Text="Popular Search Categories" runat="server"></asp:Label></a></td>
    <td width="3%"><img src="../images/B2B-Categories.jpg" width="24" height="24" /></td>
    <td width="10%"><a id="A2" href= "<%$RouteUrl:RouteName=HomeRoute%>" runat="server" target="_blank"><asp:Label ID="Label1" Text="B2B Categories" runat="server"></asp:Label></a></td>
    <td width="3%"><img src="../images/Events.jpg" width="24" height="24" /></td>
    <td width="4%"><a id="A3" href= "<%$RouteUrl:RouteName=Events,cname=Events%>" runat="server" target="_blank"><asp:Label ID="Label2" Text="Events" runat="server"></asp:Label></a></td>
    <td width="3%"><img src="../images/Discounts.jpg" width="24" height="24" /></td>
    <td width="7%"><%--<a href="Discounts.aspx?cname=discounts" style="color:#003366;"><asp:Label ID="Label3" Text="Discounts" runat="server" Font-Bold="false"></asp:Label></a>--%>
       <a id="A4" href="<%$RouteUrl:RouteName=discounts,cname=Discounts%>" runat="server" target="_blank"><asp:Label ID="Label3" Text="Discounts" runat="server"></asp:Label></a>
    </td>
    <td width="3%"><img src="../images/Hotels.jpg" width="24" height="24" /></td>
    <td width="4%"><a id="A5" href="<%$RouteUrl:RouteName=Hotels,pageid=Hotels%>" runat="server" target="_blank"><asp:Label ID="Label4" Text="Hotels" runat="server"></asp:Label></a></td>
    <td width="3%"><img src="../images/JOBS.jpg" width="24" height="24" /></td>
    <td width="4%"><a id="A6" href="<%$RouteUrl:RouteName=jobs,cname=jobs%>" runat="server" target="_blank"><asp:Label ID="Label5" Text="Jobs" runat="server"></asp:Label></a></td>
    <td width="3%"><img src="../images/Builders.jpg" width="24" height="24" /></td>
    <td width="6%"><%--<asp:Button ID="lnkbuild" runat="server" Text="Builders" CommandArgument="Builders" OnCommand="Category" BackColor="White" BorderStyle="None" CssClass="pointer" ></asp:Button>--%>
     <%--<asp:HyperLink ID="lnkbuild" runat="server" NavigateUrl="<%$RouteUrl:RouteName=Builders,cname=Builders %>" Text="Builders"></asp:HyperLink>--%>
     <a id="A7" href="<%$RouteUrl:RouteName=Builders,cname=Builders%>" runat="server" target="_blank"><asp:Label ID="Label6" Text="Builders" runat="server"></asp:Label></a>
    </td>
    <td width="3%"><img src="../images/computers.jpg" width="24" height="24" /></td>
    <td width="7%">
      <%--<asp:Button ID="lnkcomp" runat="server" Text="Computers" CommandArgument="Computers & Peripherals" OnCommand="Category" BackColor="White" BorderStyle="None" CssClass="pointer"  ></asp:Button>--%>
       <asp:HyperLink ID="lnkcomp" runat="server" NavigateUrl="<%$RouteUrl:RouteName=Computers,cname=Computers and Peripherals %>" Text="Computers" target="_blank"></asp:HyperLink>
      </td>
    <td width="3%"><img src="../images/Education.jpg" width="24" height="25" /></td>
    <td width="6%">
     <%--<asp:Button ID="lnkedu" runat="server" Text="Education" CommandArgument="Education & Training" OnCommand="Category" BackColor="White" BorderStyle="None" CssClass="pointer"></asp:Button>--%>
     <asp:HyperLink ID="lnkedu" runat="server" NavigateUrl="<%$RouteUrl:RouteName=Education,cname=Education and Training %>" Text="Education" target="_blank"></asp:HyperLink>
     </td>
    <td width="3%"><img src="../images/travels.jpg" width="24" height="24" /></td>
    <td width="5%" height="50">
    <%--<asp:Button ID="lnktravel" runat="server" Text="Travel" CommandArgument="Travel Services" OnCommand="Category" BackColor="White" BorderStyle="None" CssClass="pointer" ></asp:Button>--%>
     <asp:HyperLink ID="lnktravel" runat="server" NavigateUrl="<%$RouteUrl:RouteName=Travels,cname=Travel Services %>" Text="Travel" target="_blank"></asp:HyperLink>
    
    </td>
  </tr>
</table>
<div class="clr"></div>