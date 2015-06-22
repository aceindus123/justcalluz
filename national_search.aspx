<%@ Page Language="C#" AutoEventWireup="true" CodeFile="national_search.aspx.cs" Inherits="national_search" %>
<%@ Register Src="usercontrols/footer1.ascx" TagName="footer1" TagPrefix="aa10" %>
<%@ Register Src="usercontrols/footer2.ascx" TagName="footer2" TagPrefix="aa11" %>
<%@ Register Src="usercontrols/BottomContent.ascx" TagName="bottomcontent" TagPrefix="aa4" %>
<%@ Register Src="usercontrols/BottomMidContent.ascx" TagName="bottomMidcontent" TagPrefix="aa5" %>
<%@ Register Src="usercontrols/SearchNew.ascx" TagName="newsearch" TagPrefix="nsearch"%>
<%@ Register Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" TagPrefix="cc3"  %>
<%@ Register Src="usercontrols/nationalsearch_right.ascx" TagName="nsearch" TagPrefix="nsearch" %>
<%@ Register Src="usercontrols/signin.ascx" TagName="signin" TagPrefix="aa1" %>
<%@ Register Src="usercontrols/small_logo.ascx" TagName="logo" TagPrefix="S_logo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
  <title>National Search - JustCalluz | Perform Your Search All Over India</title>
 <meta name='description' content='JustCalluz India's No.1 local search engine provides comprehensive updated information on all B2B and B2C Products & Services. Search for any business all over India and find the best match.' />
 <meta name='keywords' content='justcalluz national search, justcalluz india search, yellow pages india, indian search engine, indian directory, indian business directory, indian local search engine, national yellow pages' />
		
<%--<title>:: Just Calluz :: National Search</title>--%>
<link href="css/inner_style.css" rel="stylesheet" type="text/css" />
<link href="css/style.css" rel="Stylesheet" type="text/css" />
<link href="css/menu_css.css" rel="stylesheet" type="text/css" />
<script  type="text/javascript">
         function  fixform() {
            if  (opener.document.getElementById("form1").target != "_blank") return;

            opener.document.getElementById("form1").target = "";
            opener.document.getElementById("form1").action = opener.location.href;
            }
</script>
</head>
<body>
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
<div class="layout">
<div class="signin">
<aa1:signin ID="suy" runat="server" />
</div>
<div class="header">
<%--<div class="header_top"></div>--%>
<div class="header_logo"><S_logo:logo ID="logo" runat="server" /></div>
<div class="header_search">
<nsearch:newsearch ID="search" runat="server" />
</div>
</div>
<div class="national_header">
  <table width="100%" border="0">
    <tr>
      <td width="32%" align="center"><h1><asp:HyperLink ID="hlfreelist" runat="server" NavigateUrl="<%$RouteUrl:RouteName=Free%>" Font-Underline="false" ForeColor="#CC0000">Free Listing</asp:HyperLink></h1>
        List your business free on Justcalluz</td>
      <td width="2%">&nbsp;</td>
      <td width="32%" align="center"><h1><a href="#">Win iPad2</a></h1>
        Win an iPad 2 everyday* </td>
      <td width="2%">&nbsp;</td>
      <td width="32%" align="center"><h1><a href="#">Quick Quotes</a></h1>
        Coming soon...</td>
    </tr>
  </table>
</div>
<!-- start The Content-->
<div class="content" style="padding:0; margin:0;">
<div class="content_innermid" style="width:79%;">
  <table width="100%" border="0" style="border-right:1px #999 dotted">
    <tr>
      <td height="40" style="background:#FFF9EA;">
<%--<ul class="arrowunderline">
<li class="selected"><asp:LinkButton ID="lnkmovie" runat="server" Text="Movies" 
        onclick="lnkmovie_Click" OnClientClick="form1.target='_blank';" ></asp:LinkButton></li>
<li><asp:LinkButton ID="lnkrest" runat="server" Text="Restaurants" 
        onclick="lnkrest_Click" OnClientClick="form1.target='_blank';" ></asp:LinkButton></li>
<li><asp:LinkButton ID="lnkhotel" runat="server" Text="Hotels" 
        onclick="lnkhotel_Click" OnClientClick="form1.target='_blank';" ></asp:LinkButton></li>
<li><asp:LinkButton ID="lnkauction" runat="server" Text="Reverse Auction" 
        onclick="lnkauction_Click" OnClientClick="form1.target='_blank';" ></asp:LinkButton></li>
<li><asp:LinkButton ID="lnkreseller" runat="server" Text="Reseller" 
        onclick="lnkreseller_Click" OnClientClick="form1.target='_blank';" ></asp:LinkButton></li>	
<li><asp:LinkButton ID="lnktrends" runat="server" Text="JD Trends" 
        onclick="lnktrends_Click" OnClientClick="form1.target='_blank';" ></asp:LinkButton></li>
<li><asp:LinkButton ID="lnklifestyle" runat="server" Text="Lifestyle" 
        onclick="lnklifestyle_Click" OnClientClick="form1.target='_blank';" ></asp:LinkButton></li>	
</ul>--%>
<ul class="arrowunderline">
<li class="selected"><asp:Button ID="lnkmovie" runat="server" Text="Movies" 
        onclick="lnkmovie_Click" OnClientClick="form1.target='_blank';" BorderStyle="None" BackColor="#FFF9EA" CssClass="pointer" /></li>
<li><asp:Button ID="lnkrest" runat="server" Text="Restaurants" 
        onclick="lnkrest_Click" OnClientClick="form1.target='_blank';" BorderStyle="None" BackColor="#FFF9EA" CssClass="pointer" /></li>
<li><asp:Button ID="lnkhotel" runat="server" Text="Hotels" 
        onclick="lnkhotel_Click" OnClientClick="form1.target='_blank';" BorderStyle="None" BackColor="#FFF9EA" CssClass="pointer"  /></li>
<li><asp:Button ID="lnkauction" runat="server" Text="Reverse Auction" 
        onclick="lnkauction_Click" OnClientClick="form1.target='_blank';" BorderStyle="None" BackColor="#FFF9EA" CssClass="pointer"  /></li>
<li><asp:Button ID="lnkreseller" runat="server" Text="Reseller" 
        onclick="lnkreseller_Click" OnClientClick="form1.target='_blank';" BorderStyle="None" BackColor="#FFF9EA" CssClass="pointer"  /></li>	
<li><asp:Button ID="lnktrends" runat="server" Text="JC Trends" 
        onclick="lnktrends_Click" OnClientClick="form1.target='_blank';" BorderStyle="None" BackColor="#FFF9EA" CssClass="pointer"  /></li>
<%--<li><asp:Button ID="lnklifestyle" runat="server" Text="Lifestyle" 
        onclick="lnklifestyle_Click" OnClientClick="form1.target='_blank';" BorderStyle="None" BackColor="#FFF9EA" CssClass="pointer"  /></li>--%>	
</ul>
</td>
    </tr>
    <tr>
      <td><table width="100%" border="0">
        <tr id="movies" runat="server">
          <td><img src="images/movies.png" alt="MoviesImage" width="125" height="125" /></td>
          <td>&nbsp;</td>
          <td valign="top"><ul style="list-style:none">
            <li>- Your favorite movies!</li>
            <li>- Show timings at theatres in your city!</li>
            <li>- Movie reservations at selected theatres</li></ul><br />
            For Movies, <a href="#">Click Here </a></td>
        </tr>
        <tr>
          <td>&nbsp;</td>
          <td>&nbsp;</td>
          <td valign="top">&nbsp;</td>
        </tr>
        <tr id="restaurants" runat="server">
          <td><img src="images/restaurant.png" alt="RestaurantImage" width="125" height="125" /></td>
          <td>&nbsp;</td>
          <td valign="top"><ul style="list-style:none">
<li>- Foodies, this one's for you!</li>
<li>- Comprehensive listings of Restaurants in your city!</li>
<li>- Choose by Cuisine!</li>
<li>- Choose by Price!</li>
<li>- Reviews & Ratings by lakhs of Justdial users!</li></ul>
  For Restaurants, <a href="#">Click Here</a></td>
        </tr>
        <tr>
          <td>&nbsp;</td>
          <td>&nbsp;</td>
          <td valign="top">&nbsp;</td>
        </tr>
        <tr id="hotel" runat="server">
          <td><img src="images/hotal.png" width="125" height="125" /></td>
          <td>&nbsp;</td>
          <td valign="top"><table width="100%" border="0">
  <tr>
    <td width="20%" height="92" valign="top">
    Ahmedabad<br />
    Bangalore<br />
      Chandigarh<br />
      Chennai<br />
      Coimbatore<br />
             </td>
    <td width="4%">&nbsp;</td>
    <td width="18%" valign="top">
 Delhi<br />
 Ernakulam<br />
 Goa<br />
 Hyderabad<br />
 Indore<br />
     </td>
    <td width="18%" valign="top">
Mumbai<br />
Mysore<br />
Nagpur<br />
Jaipur<br />
Kolkata</td>
    <td width="4%" valign="top">&nbsp;</td>
    <td width="36%" valign="top"> Nashik<br />
Pune<br />
Surat</td>
  </tr>
 
  </table>
</td>
        </tr>
        <tr>
          <td>&nbsp;</td>
          <td>&nbsp;</td>
          <td valign="top">&nbsp;</td>
        </tr>
        <tr id="auction" runat="server">
          <td><img src="images/Reverse Auction 1.png" alt="ReverseAuctionImage" width="125" height="125" /></td>
          <td>&nbsp;</td>
          <td valign="top">The simplest way to get the lowest price on any product or service that you plan to purchase. 
Use JD Reverse Auction and we believe that 4 companies will compete for your business 
which will get you the Lowest Price.<br /><br />
 
<a href="#">Know More</a></td>
        </tr>
        <tr>
          <td>&nbsp;</td>
          <td>&nbsp;</td>
          <td valign="top">&nbsp;</td>
        </tr>
        <tr id="reseller" runat="server">
          <td><img src="images/Reseller.png" width="125" alt="ResellerImage" height="125" /></td>
          <td>&nbsp;</td>
          <td valign="top">You could be a college student looking for some pocket money, a homemaker looking to make 
better use of your valuable time,
 a full time professional looking for additional income or an insurance agent looking to make
 valuable contacts. We have the 
key to the door of your dreams.<br /><br />
 
<a href="#">Know More</a> |<a href="#"> Become a Reseller Now!</a></td>
        </tr>
        <tr>
          <td>&nbsp;</td>
          <td>&nbsp;</td>
          <td valign="top">&nbsp;</td>
        </tr>
        <tr id="trends" runat="server">
          <td><img src="images/jc trends.png" width="125" alt="JCTrendsImage" height="125" /></td>
          <td>&nbsp;</td>
          <td valign="top"><ul style="list-style:none"><li>- Latest Trends in your city! Regularly updated!</li>
          <li>- What's in vogue! What's popular! What's HOT!</li>
<li>- Top Brands! Top Movies! Top Restaurants! And lots more..!</li>
<li>- Truly democratic & real trends polled from lakhs of Justdial users!</li>
<li>For latest Trends, <a href="#">Click Here</a></li></ul></td>
        </tr>
        <tr>
          <td>&nbsp;</td>
          <td>&nbsp;</td>
          <td valign="top">&nbsp;</td>
        </tr>
        <tr id="lifestyle" runat="server">
          <td width="129"><img src="images/lifestyle.png" alt="LifestyleImage" width="125" height="125" /></td>
          <td width="10">&nbsp;</td>
          <td width="615" valign="top"><p>If your lifestyle celebrates the finer things in life, when a top brand goes hand in hand with your way of life,<br />
            then JD Lifestyle is your luxury destination. Get your lifestyle demands met here, from this exclusive list of <br />
            the best luxury products and service providers at just a click.
          </p>
            <p> <a href="#">Click Here</a></p></td>
          </tr>
      </table></td>
    </tr>
  </table> 
</div>
<%--<div class="content_innerright">
<nsearch:nsearch ID="nat_search" runat="server" />
</div>--%>
<div class="content_innerright1">
<div class="contentbox_top1">Sponsor Ads</div>
<div class="contentbox_mid1">
 <table width="100%" border="0">
   <tr>
     <td>
      <nsearch:nsearch ID="nat_search" runat="server" />
     </td>
    </tr>
  </table>
 </div>
<div class="contentbox_bottam1"></div>
</div>
</div>
<!-- end of the content-->
<div class="content_midbootam" >
<aa5:bottomMidcontent ID="mid1" runat="server" />
</div>
<div class="content_bootam_center">
<aa4:bottomcontent ID="bottomcontent1" runat="server" />
</div>

<div class="footer" align="center" style="padding-top:5px; " >
<aa10:footer1 ID="tevfd" runat="server" />
<aa11:footer2 ID="eqwr" runat="server" />
</div>
</div>
    </form>
</body>
</html>
