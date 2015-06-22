﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Tv_Radioads.aspx.cs" Inherits="Tv_Radioads" %>
<%@ Register Src="usercontrols/signin.ascx" TagName="signin" TagPrefix="aa1" %>
<%@ Register Src="usercontrols/Search.ascx" TagName="catag" TagPrefix="aa6" %>
<%@ Register Src="usercontrols/footer1.ascx" TagName="footer1" TagPrefix="aa10" %>
<%@ Register Src="usercontrols/footer2.ascx" TagName="footer2" TagPrefix="aa11" %>
<%@ Register Src="usercontrols/BottomContent.ascx" TagName="bottomcontent" TagPrefix="aa4" %>
<%@ Register Src="usercontrols/BottomMidContent.ascx" TagName="bottomMidcontent" TagPrefix="aa5" %>
<%@ Register Src="usercontrols/Testimonials_Left.ascx" TagName="TestLeft" TagPrefix="aa15" %>
<%@ Register Src="usercontrols/SearchNew.ascx" TagName="SearchNew" TagPrefix="New" %>
<%@ Register Src="usercontrols/small_logo.ascx" TagName="logo" TagPrefix="S_logo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>:: Justcalluz :: Home page</title>
<link href="css/style.css" rel="stylesheet" type="text/css" />
<link href="css/inner_style.css" rel="Stylesheet" type="text/css" />
<link href="css/menu.css" rel="stylesheet" type="text/css" />
<script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.4.2/jquery.min.js"></script>

<script type="text/javascript" src="SpryAssets/ddaccordion.js">
</script>
<script type="text/javascript">
ddaccordion.init({
	headerclass: "submenuheader", //Shared CSS class name of headers group
	contentclass: "submenu", //Shared CSS class name of contents group
	revealtype: "click", //Reveal content when user clicks or onmouseover the header? Valid value: "click", "clickgo", or "mouseover"
	mouseoverdelay: 200, //if revealtype="mouseover", set delay in milliseconds before header expands onMouseover
	collapseprev: true, //Collapse previous content (so only one open at any time)? true/false 
	defaultexpanded: [], //index of content(s) open by default [index1, index2, etc] [] denotes no content
	onemustopen: false, //Specify whether at least one header should be open always (so never all headers closed)
	animatedefault: false, //Should contents open by default be animated into view?
	persiststate: true, //persist state of opened contents within browser session?
	toggleclass: ["", ""], //Two CSS classes to be applied to the header when it's collapsed and expanded, respectively ["class1", "class2"]
	togglehtml: ["suffix", "<img src='images/plus.gif' class='statusicon' />", "<img src='images/minus.gif' class='statusicon' />"], //Additional HTML added to the header when it's collapsed and expanded, respectively  ["position", "html1", "html2"] (see docs)
	animatespeed: "fast", //speed of animation: integer in milliseconds (ie: 200), or keywords "fast", "normal", or "slow"
	oninit:function(headers, expandedindices){ //custom code to run when headers have initalized
		//do nothing
	},
	onopenclose:function(header, index, state, isuseractivated){ //custom code to run whenever a header is opened or closed
		//do nothing
	}
})


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

<!-- staart the Content-->
<div class="content" style="padding:0; margin:0;">
  <div class="content_innerleft">
    <aa15:TestLeft ID="text_Left" runat="server" />
</div>
  <div class=" content_innermid" style="width:79%;">
  <table width="100%" border="0">
  <tr>
    <td  style="padding-left:10px;">Media Contact: Subu | +91-22-2888 4060 (Ext.: 2240) 
        | 9967355726 | media@justdial.com</td>
  </tr>
  <tr>
    <td style="padding-left:10px;"><hr/><hr/></td>
  </tr>
  <tr>
    <td><table width="100%" border="0">
  
  <tr>
    <td colspan="5" class="mid_menu"  style="padding-left:15px;" height="40"><a href="#">
        Bengali</a>| <a href="#"> Kannada </a>| <a href="#">Malayalam </a>|<a href="#"> 
        Marathi</a> | <a href="#">Tamil </a>| <a href="#">Telugu</a></td>
  </tr>
  <tr>
    <td colspan="5" class="mid_menu"  style="padding-left:15px;" height="30"><a href="#"><input type="image" src="images/numbers.jpg" width="230" height="26" /> </a></td>
    </tr>
  
</table>
</td>
  </tr>
  <tr>
    <td ><table width="100%" border="0">
  <tr>
    <td colspan="2" style="padding-left:30px; line-height:2"><ul type="circle" style="padding-left:10px;" ><li class="select_menu"><a href="#">
        Loan</a></li>
	<li class="select_menu"><a href="#">Agent</a></li>
	<li class="select_menu"><a href="#">Education</a></li>
	<li class="select_menu"><a href="#">Kuch Bhi, Kahin Bhi, Khabi Bhi</a></li>
	<li class="select_menu"><a href="#">Equipments</a></li>
	<li class="select_menu"><a href="#">Furniture</a></li>
	<li class="select_menu"><a href="#">Industrial Instruments</a></li>
	<li class="select_menu"><a href="#">Party Organiser</a></li>
	<li class="select_menu"><a href="#">Hangout</a></li>
	<li class="select_menu"><a href="#">Invertors</a></li></ul></td>
    <td width="57%" valign="top"><img src="images/mediaplayer1.png" width="254" height="102" /><br/>
      <span class="bottam_menu">&nbsp;&nbsp;<font color="#002E5B">Radio players</font></span><br/></td>
  </tr>
  </table>
</td>
  </tr>
  <tr>
    <td   class="mid_menu"  style="padding-left:15px;" height="40"><a href="#"><input type="image" src="images/numbers.jpg" width="230" height="26" /> </a></td>
  </tr>
  
</table>
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