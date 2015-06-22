<%@ Control Language="C#" AutoEventWireup="true" CodeFile="BottomContent.ascx.cs" Inherits="usercontrols_BottomContent" %>
<%@ Import Namespace="System.Web.Routing" %>
<table width="100%" border="0">
  <tr>
    <td style="padding:8px;"><table width="100%" border="0">
  <tr>
    <td width="15%" class="mid_menu" height="25"><strong>About us</strong></td>
    <%--<td width="13%" class="mid_menu">Media Speak</td>--%>
    <td width="14%" class="mid_menu"><strong>Popular Cities</strong></td>
    <td width="12%">&nbsp;</td>
    <td width="12%">&nbsp;</td>
    <td width="14%" class="mid_menu"><strong>Sitemap</strong></td>
    <td width="18%">&nbsp;</td>
    <td width="14%">&nbsp;</td>
  </tr>
  <tr>
    <td class="bottam_menu"><asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="<%$RouteUrl:RouteName=Aboutjcalluz%>" Font-Underline="false" >Overview</asp:HyperLink></td>
    <%--<td class="bottam_menu"><asp:HyperLink ID="HyperLink26" runat="server" NavigateUrl="<%$RouteUrl:RouteName=medialang,lang=English%>" Font-Underline="false" >English</asp:HyperLink></td>--%>
    <td class="bottam_menu"><asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="<%$RouteUrl:RouteName=cityhome,city=Ahmedabad%>" Font-Underline="false" >Ahmedabad</asp:HyperLink></td>
    <td class="bottam_menu"><asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="<%$RouteUrl:RouteName=cityhome,city=Kolkata%>" Font-Underline="false" >Kolkata</asp:HyperLink></td>
    <td class="bottam_menu"><asp:HyperLink ID="HyperLink15" runat="server" NavigateUrl="<%$RouteUrl:RouteName=cityhome,city=Ernakulam%>" Font-Underline="false" >Ernakulam</asp:HyperLink></td>
    <td class="bottam_menu"><asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="<%$RouteUrl:RouteName=HomeRoute%>" Font-Underline="false" >Home</asp:HyperLink></td>
   <%-- <td class="bottam_menu"><asp:HyperLink ID="HyperLink21" runat="server" NavigateUrl="<%$RouteUrl:RouteName=csr%>" Font-Underline="false"  Visible="false">Corporate Social Responsibility</asp:HyperLink></td>--%>
    <td class="bottam_menu"><asp:HyperLink ID="HyperLink50" runat="server" NavigateUrl="<%$RouteUrl:RouteName=careersloc %>" Font-Underline="false" >Careers</asp:HyperLink></td>
    <td class="bottam_menu"><a href="66136226.html">66136226</a></td>
  </tr>
  <tr>
    <%--<td class="bottam_menu"><asp:HyperLink ID="HyperLink22" runat="server" NavigateUrl="<%$RouteUrl:RouteName=Ads%>" Font-Underline="false"  Visible="false">Ads</asp:HyperLink></td>--%>
    <td class="bottam_menu"><asp:HyperLink ID="HyperLink51" runat="server" NavigateUrl="<%$RouteUrl:RouteName=searchtips %>" Font-Underline="false" >Search Tips</asp:HyperLink></td>
    <%--<td class="bottam_menu"><asp:HyperLink ID="HyperLink27" runat="server" NavigateUrl="<%$RouteUrl:RouteName=medialang,lang=English%>" Font-Underline="false" >Hindi</asp:HyperLink></td>--%>
    <td class="bottam_menu"><asp:HyperLink ID="HyperLink5" runat="server" NavigateUrl="<%$RouteUrl:RouteName=cityhome,city=Bangalore%>" Font-Underline="false" >Bangalore</asp:HyperLink></td>
    <td class="bottam_menu"><asp:HyperLink ID="HyperLink6" runat="server" NavigateUrl="<%$RouteUrl:RouteName=cityhome,city=Mumbai%>" Font-Underline="false" >Mumbai</asp:HyperLink></td>
    <td class="bottam_menu"><asp:HyperLink ID="HyperLink17" runat="server" NavigateUrl="<%$RouteUrl:RouteName=cityhome,city=Goa%>" Font-Underline="false" >Goa</asp:HyperLink></td>
    <td class="bottam_menu"><asp:HyperLink ID="HyperLink35" runat="server" NavigateUrl="<%$RouteUrl:RouteName=Movies,mname=null,mlang=null %>" Font-Underline="false" >Movies</asp:HyperLink></td>
    <%--<td class="bottam_menu"><asp:HyperLink ID="HyperLink37" runat="server" NavigateUrl="<%$RouteUrl:RouteName=Mobile %>" Font-Underline="false" >Justcalluz On Mobile</asp:HyperLink></td>--%>
    <td class="bottam_menu"><asp:HyperLink ID="HyperLink48" runat="server" NavigateUrl="<%$RouteUrl:RouteName=Reverse %>" Font-Underline="false" >Reverse Auction</asp:HyperLink></td>
    <td class="bottam_menu"><asp:HyperLink ID="HyperLink38" runat="server" NavigateUrl="<%$RouteUrl:RouteName=private %>" Font-Underline="false" >Privacy Policy</asp:HyperLink></td>
  </tr>
  <tr>
    <td class="bottam_menu"><asp:HyperLink ID="HyperLink23" runat="server" NavigateUrl="<%$RouteUrl:RouteName=Test%>" Font-Underline="false" >Testimonials</asp:HyperLink></td>
    <%--<td class="bottam_menu"><asp:HyperLink ID="HyperLink28" runat="server" NavigateUrl="<%$RouteUrl:RouteName=medialang,lang=Kannada%>" Font-Underline="false" >Kannada</asp:HyperLink></td>--%>
    <td class="bottam_menu"><asp:HyperLink ID="HyperLink7" runat="server" NavigateUrl="<%$RouteUrl:RouteName=cityhome,city=Chandigarh%>" Font-Underline="false" >Chandigarh</asp:HyperLink></td>
    <td class="bottam_menu"><asp:HyperLink ID="HyperLink8" runat="server" NavigateUrl="<%$RouteUrl:RouteName=cityhome,city=Mysore%>" Font-Underline="false" >Mysore</asp:HyperLink></td>
    <td class="bottam_menu"><asp:HyperLink ID="HyperLink19" runat="server" NavigateUrl="<%$RouteUrl:RouteName=cityhome,city=Hyderabad%>" Font-Underline="false" >Hyderabad</asp:HyperLink></td>
    <td class="bottam_menu"><asp:HyperLink ID="HyperLink25" runat="server" NavigateUrl="<%$RouteUrl:RouteName=Events,cname=events%>" Font-Underline="false" >Events</asp:HyperLink></td>
    <td class="bottam_menu"><asp:HyperLink ID="HyperLink41" runat="server" NavigateUrl="<%$RouteUrl:RouteName=Advertise %>" Font-Underline="false" >Advertise</asp:HyperLink></td>
    <td class="bottam_menu"><asp:HyperLink ID="HyperLink52" runat="server" NavigateUrl="<%$RouteUrl:RouteName=contact %>" Font-Underline="false" >Contact us</asp:HyperLink></td>
    
    
   <%-- <td class="bottam_menu"><asp:HyperLink ID="HyperLink39" runat="server" NavigateUrl="<%$RouteUrl:RouteName=media%>" Font-Underline="false" >Media</asp:HyperLink></td>--%>
  </tr>
  <tr>
    <td class="bottam_menu" rowspan="2"><asp:HyperLink ID="HyperLink24" runat="server" NavigateUrl="~/testimonials.aspx#shareViews" Font-Underline="false" >Share Your Views About Justcalluz</asp:HyperLink></td>
    <%--<td class="bottam_menu"><asp:HyperLink ID="HyperLink29" runat="server" NavigateUrl="<%$RouteUrl:RouteName=medialang,lang=Tamil%>" Font-Underline="false" >Tamil</asp:HyperLink></td>--%>
    <td class="bottam_menu"><asp:HyperLink ID="HyperLink9" runat="server" NavigateUrl="<%$RouteUrl:RouteName=cityhome,city=Chennai%>" Font-Underline="false" >Chennai</asp:HyperLink></td>
    <td class="bottam_menu"><asp:HyperLink ID="HyperLink10" runat="server" NavigateUrl="<%$RouteUrl:RouteName=cityhome,city=Nagpur%>" Font-Underline="false" >Nagpur</asp:HyperLink></td>
    <td class="bottam_menu"><asp:HyperLink ID="HyperLink16" runat="server" NavigateUrl="<%$RouteUrl:RouteName=cityhome,city=Surat%>" Font-Underline="false" >Surat</asp:HyperLink></td>
    <td class="bottam_menu"><asp:HyperLink ID="HyperLink36" runat="server" NavigateUrl="<%$RouteUrl:RouteName=Restaurants,cname=restaurants%>" Font-Underline="false" >Restaurants</asp:HyperLink></td>
    
    <td class="bottam_menu"><asp:HyperLink ID="HyperLink40" runat="server" NavigateUrl="<%$RouteUrl:RouteName=Free%>" Font-Underline="false" >FreeListing</asp:HyperLink></td>
      <td class="bottam_menu"><asp:HyperLink ID="HyperLink11" runat="server" NavigateUrl="<%$RouteUrl:RouteName=justcallterms%>" Font-Underline="false" >Terms of Use</asp:HyperLink></td>
         <%--<td id="reseller" runat="server" class="bottam_menu" visible="false"><asp:HyperLink ID="HyperLink42" runat="server" NavigateUrl="<%$RouteUrl:RouteName=reseller %>" Font-Underline="false" ForeColor="#003366" Font-Size="10" > Reseller</asp:HyperLink></td>--%>
  </tr>
  <tr>
    <%--<td class="bottam_menu" ><a href="#">About Justcalluz</a></td>--%>
   <%-- <td class="bottam_menu"><asp:HyperLink ID="HyperLink30" runat="server" NavigateUrl="<%$RouteUrl:RouteName=medialang,lang=Bengali%>" Font-Underline="false" >Bengali</asp:HyperLink></td>--%>
    <%--<td class="bottam_menu"><asp:HyperLink ID="HyperLink11" runat="server" NavigateUrl="<%$RouteUrl:RouteName=cityhome,city=Coimbatore%>" Font-Underline="false" >Coimbatore</asp:HyperLink></td>--%>
    <td class="bottam_menu"><asp:HyperLink ID="HyperLink12" runat="server" NavigateUrl="<%$RouteUrl:RouteName=cityhome,city=Nashik%>" Font-Underline="false" >Nashik</asp:HyperLink></td>
    <td class="bottam_menu"><asp:HyperLink ID="HyperLink18" runat="server" NavigateUrl="<%$RouteUrl:RouteName=cityhome,city=Vadodara%>" Font-Underline="false" >Vadodara</asp:HyperLink></td>
    <td class="bottam_menu"><asp:HyperLink ID="HyperLink43" runat="server" NavigateUrl="<%$RouteUrl:RouteName=Hotels,pageid=Hotels%>" Font-Underline="false" >Hotels</asp:HyperLink></td>
    <%--<td class="bottam_menu"><asp:HyperLink ID="HyperLink44" runat="server" NavigateUrl="<%$RouteUrl:RouteName=tag%>" Font-Underline="false"  Visible="false">Tag Your Friend</asp:HyperLink></td>--%>
    <td class="bottam_menu"><asp:HyperLink ID="HyperLink45" runat="server" NavigateUrl="<%$RouteUrl:RouteName=White%>" Font-Underline="false" >White Pages</asp:HyperLink></td>
  <td class="bottam_menu"><asp:HyperLink ID="HyperLink55" runat="server" NavigateUrl="<%$RouteUrl:RouteName=desclaimer %>" Font-Underline="false" >Disclaimer</asp:HyperLink></td>
  </tr>
  <tr>
    <td class="bottam_menu"><asp:HyperLink ID="HyperLink53" runat="server" NavigateUrl="<%$RouteUrl:RouteName=search %>" Font-Underline="false" >Search Not Found</asp:HyperLink></td>
    <%--<td class="bottam_menu"><asp:HyperLink ID="HyperLink46" runat="server" NavigateUrl="<%$RouteUrl:RouteName=success%>" Font-Underline="false" >Success Stories</asp:HyperLink></td>--%>
    <%--<td class="bottam_menu"><asp:HyperLink ID="HyperLink31" runat="server" NavigateUrl="<%$RouteUrl:RouteName=medialang,lang=Gujarati%>" Font-Underline="false" >Gujarati</asp:HyperLink></td>--%>
    <td class="bottam_menu"><asp:HyperLink ID="HyperLink13" runat="server" NavigateUrl="<%$RouteUrl:RouteName=cityhome,city=Delhi-NCR%>" Font-Underline="false" >Delhi / NCR</asp:HyperLink></td>
    <td class="bottam_menu"><asp:HyperLink ID="HyperLink14" runat="server" NavigateUrl="<%$RouteUrl:RouteName=cityhome,city=Pune%>" Font-Underline="false" >Pune</asp:HyperLink></td>
    <td class="bottam_menu"><asp:HyperLink ID="HyperLink20" runat="server" NavigateUrl="<%$RouteUrl:RouteName=cityhome,city=Vizag%>" Font-Underline="false" >Vizag</asp:HyperLink></td>
    <td class="bottam_menu"><%--<asp:HyperLink ID="HyperLink47" runat="server" NavigateUrl="<%$RouteUrl:RouteName=LifeStyle %>" Font-Underline="false" >Lifestyle</asp:HyperLink>--%></td>
    
    <td class="bottam_menu"><asp:HyperLink ID="HyperLink49" runat="server" NavigateUrl="<%$RouteUrl:RouteName=Citytrendzmain %>" Font-Underline="false" >City Trends</asp:HyperLink></td>
    <td width="14%" class="mid_menu"><%--<strong>Follow us</strong>--%></td>
    
  </tr>
  <%--<tr>
    <td class="bottam_menu"></td>
   
    <td class="bottam_menu"></td>
    <td class="bottam_menu"></td>
    <td class="bottam_menu"></td>
    <td class="bottam_menu"></td>
   <td class="bottam_menu"></td>
   <td class="bottam_menu"><a href="https://twitter.com/justcalluz"><img alt="twitterIcon" src="images/Twitter-icon.png" width="16" height="16" />&nbsp;Twitter</a></td>
  </tr>
  <tr>
  <td class="bottam_menu"></td>
    
   
    <td class="bottam_menu"></td>
    <td class="bottam_menu"></td>
    <td class="bottam_menu"></td>
     <td class="bottam_menu"></td>
    <td class="bottam_menu"></td>
     <td class="bottam_menu"><a href="http://www.facebook.com/pages/Justcalluz/196863167126254"><img alt="facebookIcon" src="images/facebook.png" width="16" height="16" />&nbsp;Facebook</a></td>
  </tr>
  <tr>
    
   <td class="bottam_menu"></td>
    
    <td class="bottam_menu"></td>
    <td class="bottam_menu"></td>
    
    <td class="bottam_menu"></td>
    <td class="bottam_menu"><asp:HyperLink ID="HyperLink55" runat="server" NavigateUrl="<%$RouteUrl:RouteName=desclaimer %>" Font-Underline="false" >Disclaimer</asp:HyperLink></td>
    
  </tr>--%>
</table>
</td>
  </tr>
</table>