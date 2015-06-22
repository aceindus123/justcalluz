<%@ Control Language="C#" AutoEventWireup="true" CodeFile="media_left.ascx.cs" Inherits="usercontrols_media_left" %>

<div class="contentbox_top">ABOUT US</div>
<div class="contentbox_mid">
<ul style="padding-left:15px;">
    <li><a href="<%$RouteUrl:RouteName=Aboutjcalluz%>" runat="server" target="_blank"><b>Overview</b></a></li>
   <%-- <li><a href="<%$RouteUrl:RouteName=Ads%>" runat="server"><b>Ads</b></a></li>--%>
    <li><a href="<%$RouteUrl:RouteName=Test%>" runat="server" target="_blank"><b>Testimonials</b></a></li>
    <li style="line-height:20px;"><a href="testimonials.aspx#shareViews"><b>Share Your Views About Justcalluz</b></a></li>
    <%--<li style="line-height:20px;"><a href="<%$RouteUrl:RouteName=csr%>" runat="server"><b>Corporate Social Responsibility</b></a></li>
    <li><a href="<%$RouteUrl:RouteName=success%>" runat="server"><b>Success Stories</b></a></li>--%>
    <li><a href="<%$RouteUrl:RouteName=careersloc%>" runat="server" target="_blank"><b>Careers</b></a></li>
    <li><a href="<%$RouteUrl:RouteName=contact%>" runat="server" target="_blank"><b>Contact Us</b></a></li>
   <%-- <li><a href="<%$RouteUrl:RouteName=customer%>" runat="server"><b>Customer Care</b></a></li>
    <li><a href="<%$RouteUrl:RouteName=reseller%>" runat="server"><b>Reseller</b></a></li>--%>
</ul>
</div>
<div class="contentbox_bottam"></div>

<%--<div class="contentbox_top">MEDIA SPEAK</div>
<div class="contentbox_mid">
<asp:DataList ID="dlmedia" runat="server" OnItemDataBound="media_details">
<ItemTemplate>
<ul style="padding-left:15px; line-height:1.5px;"><li>
 <asp:HyperLink ID="lnklang" runat="server" Font-Bold="true" Font-Size="Small" Text='<%#Eval("LanguageSpeak")%>' NavigateUrl='<%# GetUrlmedia(Eval("LanguageSpeak")) %>'></asp:HyperLink>
  <asp:DataList ID="dltitle" runat="server">
    <ItemTemplate>
     <ul><li>
       <asp:HyperLink ID="HyperLink1" runat="server" Text='<%#Eval("Title")%>' NavigateUrl='<%# GetUrlmedia_details(Eval("Medid")) %>'></asp:HyperLink>
     </li></ul>
    </ItemTemplate>
  </asp:DataList>
</li></ul>
</ItemTemplate>
</asp:DataList>
</div>
<div class="contentbox_bottam"></div>--%>



