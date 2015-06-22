<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Restaurants.aspx.cs" Inherits="Restaurants" %>
<%@ Register Src="usercontrols/signin.ascx" TagName="signin" TagPrefix="aa1" %>
<%@ Register Src="usercontrols/Search.ascx" TagName="catag" TagPrefix="aa6" %>
<%@ Register Src="usercontrols/footer1.ascx" TagName="footer1" TagPrefix="aa10" %>
<%@ Register Src="usercontrols/footer2.ascx" TagName="footer2" TagPrefix="aa11" %>
<%@ Register Src="usercontrols/BottomContent.ascx" TagName="bottomcontent" TagPrefix="aa4" %>
<%@ Register Src="usercontrols/BottomMidContent.ascx" TagName="bottomMidcontent" TagPrefix="aa5" %>
<%@ Register Src="usercontrols/SearchNew.ascx" TagName="SearchNew" TagPrefix="New" %>
<%@ Register Src="usercontrols/small_logo.ascx" TagName="logo" TagPrefix="S_logo" %>
<%@ Register Src="usercontrols/SponsoredLinks.ascx" TagName="SpLinks" TagPrefix="SpAds" %>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>Restaurants | Justcalluz</title>
<meta name='Title' content='Restaurants | JustCalluz' />
<link href="css/style.css" rel="stylesheet" type="text/css" />
<link href="css/inner_style.css" rel="Stylesheet" type="text/css" />
<script src="Scripts/swfobject_modified.js" type="text/javascript"></script>
<link href="css/red_style.css" rel="stylesheet" type="text/css" media="screen" />
<script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.3.1/jquery.min.js"></script>
<script type="text/javascript">
$(function(){
	var slideHeight = 250; // px
	var defHeight = $('#wrap').height();
	if(defHeight >= slideHeight){
		$('#wrap').css('height' , slideHeight + 'px');
		$('#read-more').append('<a href="#">More</a>');
		$('#read-more a').click(function(){
			var curHeight = $('#wrap').height();
			if(curHeight == slideHeight){
				$('#wrap').animate({
				  height: defHeight
				}, "normal");
				$('#read-more a').html('Less');
				$('#gradient').fadeOut();
			}else{
				$('#wrap').animate({
				  height: slideHeight
				}, "normal");
				$('#read-more a').html('More');
				$('#gradient').fadeIn();
			}
			return false;
		});		
	}
});
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
 <New:SearchNew ID="New" runat="server" />
 </div>
 </div>
<div class="category_box">
 <aa6:catag ID="uye" runat="server" />
</div>
<!-- start the Content-->
<div class="content" style="padding:0; margin:0;">
<div class="content_innermid" style="width:79%">
<table width="100%" border="0"  >
 <tr>
    <td><table width="100%" border="0">
  <tr>
    <td height="30" colspan="6" align="center" class="bottam" style="background:url(images/resturent.png) no-repeat">Restaurants</td>
    </tr>
  <tr>
    <td width="16%" align="center"><img  src="images/buffet.gif" alt="FoodItemImage" width="100" height="100" /></td>
    <td width="16%" align="center"><img src="images/chiness.gif" alt="FoodItemImage" width="100" height="100" /></td>
    <td width="17%" align="center"><img src="images/fastfood.gif" alt="FoodItemImage" width="100" height="100" /></td>
    <td width="17%" align="center"><img src="images/multicu.gif" alt="FoodItemImage" width="100" height="100" /></td>
    <td width="18%" align="center"><img src="images/northindian.gif" alt="FoodItemImage" width="100" height="100" /></td>
    <td width="16%" align="center"><img src="images/south-indian.gif" alt="FoodItemImage" width="100" height="100" /></td>
  </tr>
  <tr>
    <%--<td align="center" class="side_menu"><a href="linkcontroller.aspx?rcname=Buffet Restaurants">Buffet</a></td>
    <td align="center" class="side_menu"><a href="linkcontroller.aspx?rcname=Chinese Restaurants">Chinese </a></td>
    <td align="center" class="side_menu"><a href="linkcontroller.aspx?rcname=Fast Food Restaurants">Fast Food </a></td>
    <td align="center" class="side_menu"><a href="linkcontroller.aspx?rcname=Multicuisine Restaurants">Multicuisine</a></td>
    <td align="center" class="side_menu"><a href="linkcontroller.aspx?rcname=North indian Restaurants">North indian</a></td>
    <td align="center" class="side_menu"><a href="linkcontroller.aspx?rcname=South Indian Restaurants">South Indian </a></td>--%>
    <td align="center" class="side_menu"><a href="<%$RouteUrl:RouteName=Rest_Link,rcname=Buffet Restaurants,rname=Restaurants %>" runat="server">Buffet</a></td>
    <td align="center" class="side_menu"><a href="<%$RouteUrl:RouteName=Rest_Link,rcname=Chinese Restaurants,rname=Restaurants %>" runat="server">Chinese </a></td>
    <td align="center" class="side_menu"><a href="<%$RouteUrl:RouteName=Rest_Link,rcname=Fast Food Restaurants,rname=Restaurants%>" runat="server">Fast Food </a></td>
    <td align="center" class="side_menu"><a href="<%$RouteUrl:RouteName=Rest_Link,rcname=Multicuisine Restaurants,rname=Restaurants %>" runat="server">Multicuisine</a></td>
    <td align="center" class="side_menu"><a href="<%$RouteUrl:RouteName=Rest_Link,rcname=North indian Restaurants,rname=Restaurants %>" runat="server">North indian</a></td>
    <td align="center" class="side_menu"><a href="<%$RouteUrl:RouteName=Rest_Link,rcname=South Indian Restaurants,rname=Restaurants %>" runat="server">South Indian </a></td>
  </tr>
</table>
</td>
  </tr>
  <tr>
    <td class="sub_menu" height="30">Select Your Favourite Cuisine</td>
  
  </tr>
  <tr>
    <td ><div id="container">
	  <div id="wrap">
<div>
     <asp:DataList ID="dlrestaurants" DataKeyField="cat" runat="server" Width="100%" Height="100%"
         RepeatColumns="4" CellSpacing="0" Visible="false">
            <ItemTemplate>
                <table border="0">
                    <tr>
                        <td style="width:100%;" class="mid_menu">
                            <%-- <a href='<%# string.Format("RestaurantDetails-" + Eval("cat").ToString()) +" Restaurants"%>' runat="server">
                                  <%#DataBinder.Eval(Container.DataItem, "cat")%></a>  --%>
                           <asp:HyperLink ID="hyplRestaurants" runat="server" Text='<%# Eval("cat") %>' NavigateUrl='<%# GetrestCatUrl(Eval("cat")) %>' ></asp:HyperLink>    
                        </td>
                    </tr>
                </table>    
                                           
                </ItemTemplate>                         
      </asp:DataList>
</div>
			<div id="gradient"></div>
		</div>
		<div id="read-more" align="right"></div>
	</div></td>
  </tr>
  <tr>
    <td >&nbsp;</td>
  </tr>
</table>
 </div>
 <div class="content_innerright">
<div class="contentbox_top">Sponsor Ads</div>
<div class="contentbox_mid">
  <table width="100%" border="0">
    <tr>
      <td width="100%" valign="top">
        <SpAds:SpLinks ID="ads" runat="server" />
            <%--<img src="images/la-est-banner.jpg" width="180" height="600" /><br />--%>
      </td>
    </tr>
    <tr>
      <td></td>
    </tr>
   </table>
</div>
<div class="contentbox_bottam"></div>
</div>
</div>
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
<script type="text/javascript">
<!--
swfobject.registerObject("FlashID");
//-->
</script>
    </form>
</body>
</html>
