<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Testimonials_Left.ascx.cs" Inherits="usercontrols_Testimonials_Left" %>
<%--<table width="100%" border="0" >
      <tr>
        <td  align="center" valign="top" style="background:url(images/write-new-2.png) no-repeat" height="1000"><table width="100%" border="0">
  <tr>
    <td height="19" align="left" class="location"  style="padding-top:3px; padding-left:18px">
        About Us</td>
  </tr>
  
  <tr>
    <td valign="top"><table width="100%" border="0" >
  <tr>
    <td align="left" class="mid_menu" style="padding-left:12px;" height="22"><a href="#">
        Overview</a></td>
  </tr>
  <tr>
    <td align="left" class="mid_menu" style="padding-left:12px;"height="22"><a href="#"><font>Ads</font></a></td>
  </tr>
  <tr>
     <td align="left" style="padding-left:12px;"height="22" class="mid_menu">
      <ul type="circle" class="movie_menu" style="padding-left:10px;"><li>
      <a href="#">Behind the scenes</a></li>
<ul style="padding-left:10px;"><li><a href="#">The Making - Day 2</a></li>
<li><a href="#">The Making - Day 1</a></li></ul>
<li><a href="tv_ads.aspx">TV Ads</font></a></li>
<ul style="padding-left:10px;"><li><asp:LinkButton ID="lnkabnew" runat="server" 
        Text="AB Ad Films (New)" onclick="lnkabnew_Click"></asp:LinkButton></li>
<li><asp:LinkButton ID="lnkabold" runat="server" Text="AB Ad Films" 
        onclick="lnkabold_Click"></asp:LinkButton></li>
<li><asp:LinkButton ID="lnkother" runat="server" Text="Others" 
        onclick="lnkother_Click"></asp:LinkButton></li></ul>
<li><asp:LinkButton ID="lnkradio" runat="server" Text="Radio Ads" OnClick="lnkradio_Click"></asp:LinkButton></li>
<li><asp:LinkButton ID="lnkprint" runat="server" Text="Print Ads" OnClick="lnkprint_Click"></asp:LinkButton></li></ul></td>
  </tr>
  <tr>
   <td align="left" class="mid_menu" style="padding-left:12px;" height="22">
       <a href="testimonials.aspx">Testimonials</a>
   </td>
  </tr>
  <tr>
    <td align="left" class="mid_menu" style="padding-left:12px;" height="22"> 
        <a href="testimonials.aspx#shareViews">Share Your Views About Justcalluz</a>
    </td>
  </tr>
  <tr>
   <td align="left" class="mid_menu" style="padding-left:12px;" height="22"><a href="#"> 
       Success Stories</a></td>
  </tr>
  <tr>
    <td align="left" class="mid_menu" style="padding-left:12px;" height="22"><a href="#"> 
        Careers</a><br />
         <ul type="disc" class="movie_menu" style="padding-left:25px;">
          <li><a href="Careers_Location.aspx">Jobs @ JustCalluz</a></li>
          <ul type="circle" style="padding-left:10px;">
          <li><a href="Careers_Location.aspx">By Location</a></li> 
         <li> <a href="careers_Department.aspx">By Department</a></li>
         <li><a href="careers_postresume.aspx">Post Your Resume</a></li>
         <li><a href="career_feedback.aspx">Career Feedback</a> </li>
        </ul>
       <li ><a href="careers_Contact HR.aspx">Contact HR</a></li>
       <li><a href="#">Working @ Justcalluz</a> </li>
      </ul>
    </td>
        
  </tr>
  <tr>
   <td align="left" class="mid_menu" style="padding-left:12px;" height="22"><a href="#"> 
       Contact Us</a></td>
  </tr>
  <tr>
   <td align="left" class="mid_menu" style="padding-left:12px;" height="22"><a href="#">  
       Customer Care</a></td>
  </tr>
  <tr>
     <td align="left" class="mid_menu" style="padding-left:12px;" height="22"><a href="#"> 
         Reseller</a></td>
  </tr>
  <tr>
    <td>&nbsp;</td>
  </tr>
 
</table>
</td>
  </tr>
  <tr>
    <td style="background:url(images/write-new-1.png) no-repeat" height="32">
    
<table>
<tr>
     <td height="24" align="left" class="location"  style=" padding-left:18px">Media 
         Speak</td>
  </tr>
<tr>
<td>
<asp:DataList ID="dlmedia" runat="server" OnItemDataBound="media_details">
<ItemTemplate>
<table>
<tr><td align="left" class="mid_menu" style="padding-left:12px;" height="22">
<asp:LinkButton ID="lnklang" runat="server" Text='<%#Eval("LanguageSpeak")%>' CommandArgument='<%#Eval("LanguageSpeak")%>' OnCommand="bindlang">
</asp:LinkButton>
<%--<asp:Label ID="lbllang" runat="server" Text='<%#Eval("LanguageSpeak")%>'></asp:Label>--%>
<%--</td></tr>
<tr>
<td align="left" class="movie_menu" style="padding-left:25px;">
<asp:DataList ID="dltitle" runat="server">
<ItemTemplate>
>><asp:LinkButton ID="lnktitle" runat="server" Text='<%#Eval("Title")%>' CommandArgument='<%#Eval("Medid")%>' OnCommand="title_command"></asp:LinkButton>
</ItemTemplate>
</asp:DataList>
</td>
</tr>
</table>
</ItemTemplate>
</asp:DataList>
</td>
</tr>
</table>
</td>
  </tr>
  <tr>
    <td >&nbsp;</td>
  </tr>
  <tr>
    <td >&nbsp;</td>
  </tr>
</table>
</td>
      </tr>
      <tr>
        <td  valign="top">&nbsp;</td>
      </tr>
      <tr>
        <td  align="center" valign="top">&nbsp;</td>
      </tr>
      <tr>
        <td  align="center" valign="top">&nbsp;</td>
      </tr>
      <tr>
        <td  align="center" valign="top">&nbsp;</td>
      </tr>
      <tr>
        <td  align="center" valign="top">&nbsp;</td>
      </tr>
      <tr>
        <td></td>
      </tr>
    </table>--%>

<div class="contentbox_top">ABOUT US</div>
<div class="contentbox_mid">
<ul style="padding-left: 15px;">
    <li><a href="<%$RouteUrl:RouteName=Aboutjcalluz%>" runat="server" target="_blank"><b>Overview</b></a></li>
   <%-- <li style=" font-size:medium;"><a href="<%$RouteUrl:RouteName=Ads%>" runat="server"><b>Ads</b></a>
       <ul class="contentbox_mid01">
        <li><a href="#" runat="server" >Behind the scens</a></li>
        <li><a href="#" runat="server" >The Making - Day 2</a></li>
        <li><a href="#" runat="server" >The Making - Day 1</a></li>
       </ul>
    </li>--%>
    <%-- <li><a href="<%$RouteUrl:RouteName=Ads%>" runat="server" >TV Ads</a>
      <ul style="padding-left: 15px;" type="square">
        <li>
               <a id="lnkabnew" runat="server" onserverclick="lnkabnew_Click" >
                <asp:Label ID="Label2" runat="server" Text="AB Ad Films (New)" ></asp:Label></a>
        </li>
        <li>
             <a id="lnkabold" runat="server" onserverclick="lnkabold_Click" >
                <asp:Label ID="Label3" runat="server" Text="AB Ad Films" ></asp:Label></a>
        </li>
        <li>
              <a id="lnkother" runat="server" onserverclick="lnkother_Click" >
                <asp:Label ID="Label4" runat="server" Text="Others" ></asp:Label></a>
        </li>
      </ul>    
    </li>--%>
  <%--  <li>
    <a id="lnkradio" runat="server" onserverclick="lnkradio_Click"><asp:Label ID="lblRadio" runat="server" Text="Radio Ads" ></asp:Label></a>
    </li>
    <li>
     <a id="lnkprint" runat="server" onserverclick="lnkprint_Click" visible="false"><asp:Label ID="Label1" runat="server" Text="Print Ads" ></asp:Label></a>
    </li>--%>
    <li><a href="<%$RouteUrl:RouteName=Test%>" runat="server" target="_blank"><b>Testimonials</b></a></li>
    <li style="line-height:20px; font-size:medium;"><a href="testimonials.aspx#shareViews"><b>Share Your Views About Justcalluz</b></a></li>
    <%--<li style="line-height:20px;"><a href="<%$RouteUrl:RouteName=csr%>" runat="server" ><b>Corporate Social Responsibility</b></a></li>--%>
   <%-- <li><a href="<%$RouteUrl:RouteName=success%>" runat="server" ><b>Success Stories</b></a></li>--%>
    <li><a href="<%$RouteUrl:RouteName=careersloc%>" runat="server" target="_blank"><b>Careers</b></a>
              <ul type="square" style="padding-left:15px;">
              <li><a href="<%$RouteUrl:RouteName=careersloc%>" runat="server" target="_blank">Jobs @ JustCalluz</a></li>
              <li><a href="<%$RouteUrl:RouteName=careersloc%>" runat="server" target="_blank">By Location</a></li> 
              <li> <a href="<%$RouteUrl:RouteName=CareersDepartment%>" runat="server" target="_blank">By Department</a></li>
              <li><a href="<%$RouteUrl:RouteName=PostResume1%>" runat="server" target="_blank">Post Your Resume</a></li>
              <li><a href="<%$RouteUrl:RouteName=CareersFeedback%>" runat="server" target="_blank">Career Feedback</a> </li>
              <li ><a href="<%$RouteUrl:RouteName=careerhr%>" runat="server" target="_blank">Contact HR</a></li>
              <%--<li><a href="#">Working @ Justcalluz</a> </li>--%>
             </ul>
    </li>
    <li><a href="<%$RouteUrl:RouteName=contact %>" runat="server" target="_blank"><b>Contact Us</b></a></li>
    <%--<li><a href="<%$RouteUrl:RouteName=customer%>" runat="server"><b>Customer Care</b></a></li>--%>
    <%--<li><a href="reseller.aspx"><b>Reseller</b></a></li>--%>
</ul>
</div>
<div class="contentbox_bottam"></div>

<%--<div class="contentbox_top">MEDIA SPEAK</div>
<div class="contentbox_mid">
<asp:DataList ID="dlmedia" runat="server" OnItemDataBound="media_details">
<ItemTemplate>
<ul style="padding-left:15px;"><li>
  <asp:HyperLink ID="lnklang" runat="server" Font-Bold="true" Font-Size="Small" Text='<%#Eval("LanguageSpeak")%>' NavigateUrl='<%# bindlang(Eval("LanguageSpeak")) %>'></asp:HyperLink>
 <asp:DataList ID="dltitle" runat="server">
   <ItemTemplate>
     <ul><li>
        <asp:HyperLink ID="lnktitle" runat="server" Text='<%#Eval("Title")%>' NavigateUrl='<%# title_command(Eval("Medid")) %>'></asp:HyperLink>
    </li></ul>
   </ItemTemplate>
  </asp:DataList>
</li></ul>
 </ItemTemplate>
</asp:DataList>
</div>
<div class="contentbox_bottam"></div>--%>


