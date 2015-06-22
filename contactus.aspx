<%@ Page Language="C#" AutoEventWireup="true" CodeFile="contactus.aspx.cs" Inherits="contactus" %>
<%@ Register Src="usercontrols/signin.ascx" TagName="signin" TagPrefix="aa1"  %>
<%@ Register Src="usercontrols/Search.ascx" TagName="catag" TagPrefix="aa6" %>
<%@ Register Src="usercontrols/footer1.ascx" TagName="footer1" TagPrefix="aa10" %>
<%@ Register Src="usercontrols/footer2.ascx" TagName="footer2" TagPrefix="aa11" %>
<%@ Register Src="usercontrols/BottomContent.ascx" TagName="bottomcontent" TagPrefix="aa4" %>
<%@ Register Src="usercontrols/BottomMidContent.ascx" TagName="bottomMidcontent" TagPrefix="aa5" %>
<%@ Register Src="usercontrols/SearchNew.ascx" TagName="SearchNew" TagPrefix="New" %>
<%@ Register Src="usercontrols/small_logo.ascx" TagName="logo" TagPrefix="S_logo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>:: Justcalluz :: Contact Us</title>
<link href="css/style.css" rel="stylesheet" type="text/css" />
<link href="css/inner_style.css" rel="Stylesheet" type="text/css" />
<link href="css/main.css" rel="stylesheet" type="text/css" />

<script type="text/javascript" src="js/jquery-1.3.1.min.js"></script>
<script type="text/javascript" src="js/jquery.scrollTo.js"></script>

<script type="text/javascript">

$(document).ready(function() {	

	//Get the height of the first item
	$('#mask').css({'height':$('#panel-1').height()});	
	
	//Calculate the total width - sum of all sub-panels width
	//Width is generated according to the width of #mask * total of sub-panels
	$('#panel').width(parseInt($('#mask').width() * $('#panel div').length));
	
	//Set the sub-panel width according to the #mask width (width of #mask and sub-panel must be same)
	$('#panel div').width($('#mask').width());
	
	//Get all the links with rel as panel
	$('a[rel=panel]').click(function () {
	
		//Get the height of the sub-panel
		var panelheight = $($(this).attr('href')).height();
		
		//Set class for the selected item
		$('a[rel=panel]').removeClass('selected');
		$(this).addClass('selected');
		
		//Resize the height
		$('#mask').animate({'height':panelheight},{queue:false, duration:500});			
		
		//Scroll to the correct panel, the panel id is grabbed from the href attribute of the anchor
		$('#mask').scrollTo($(this).attr('href'), 800);		
		
		//Discard the link default behavior
		return false;
	});
	
});
</script>

</head>
<body>
<form id="f1" runat="server" >
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
<div class="content" style="padding:0; margin:0;">
 <div class="content_innermid" style="width:79%;">
<%--<div class="bottam_menu" id="scroller-header">--%>
 <table width="995" border="0" height="700">
 <tr>
   <td valign="top"
    style="background:url(images/Contact-Address-bg.png) no-repeat; padding: 10px 0px 0px 15px;">
<%--<font color="#004080">Welcome to JustCallUz</font>
--%><%--</div>--%>
<%--<div id="scroller-body"> 
  <div id="mask">--%>
<%--<div id="panel">--%>
 
	<%--<div>--%>
	<%--<ul style="padding-left:25px;">
	<li class="sub_menu"><font color="#C10000">Contact Address</font></li>
	<li class="mid2_menu">--%>
	<table border="0" width="100%">
	<tr><td style="color:#004080; padding-top:15px;" class="sub_menu">Welcome to JustCallUz</td></tr>
	<tr><td style="color:#C10000;" class="sub_menu">Contact Address</td></tr>
	<tr><td style="border-bottom:dotted 1px #666; width:100%" colspan="2"></td></tr>
	<tr style="height:300px;">
	<td><table class="mid2_menu" style="color:#004080;">
	<tr><td colspan="3"><font color="#006600"><strong>Global Head Quarters - USA</strong></font></td></tr>
	<%--<tr><td colspan="3">Indus Group Incorporated,</td></tr>--%>
	<tr><td colspan="3">1039 Sterling Road, Ste# 205,</td></tr>
	<tr><td colspan="3">Herndon-VA-20170. USA. </td></tr>
	<tr><td colspan="3">Washington DC Metro Area.</td></tr>
	<%--<tr><td ">Voice</td><td> : </td><td>703-263-7278</td></tr>
	<tr><td >Fax </td><td> :</td><td>703-935-8849</td></tr>--%>
	<tr><td colspan="3" class="side_menu">Email:</td></tr>
	<tr><td>For general inquiries </td><td> :</td><td>info@mnhbs.com</td></tr>
	<tr><td >For Clients</td><td>  :</td><td>sales@mnhbs.com </td></tr>
    <tr><td>For Consultants</td><td>  :</td><td>resume@mnhbs.com </td></tr>
	</table>
	</td>
	<td>
	<table class="mid2_menu" style="color:#004080;">
	<tr><td colspan="3"><font color="#006600"><strong>INDIA</strong></font></td></tr>
	<tr><td colspan="3">Plot # 1323, Behind Saradhi Studios,</td></tr>
	<tr><td colspan="3">Ameerpet, Yellareddyguda,</td></tr>
	<tr><td colspan="3">Hyderabad-AP-520073. India.</td></tr>
	<%--<tr><td >Voice</td><td> :</td><td>91-406-613-6226 </td></tr>
	<tr><td >Fax </td><td>:</td><td>91-406-613-6446</td></tr>--%>
	<tr><td colspan="3" class="side_menu">Email :</td></tr>
	<tr><td>For general inquiries </td><td>:</td><td>infohyd@mnhbs.com</td></tr>
	<tr><td >For Clients </td><td>:</td><td>saleshyd@mnhbs.com </td></tr>
    <tr><td >For Consultants </td><td>:</td><td>resumehyd@mnhbs.com </td></tr>
     <tr><td colspan="3">&nbsp;</td></tr>
	</table>
	
	</td></tr> 
	<tr><td style="border-bottom:dotted 1px #666; width:100%" colspan="2"></td></tr>
	 <tr>
   <td class="mid2_menu" colspan="2" style="color:#004080; letter-spacing:1px;">
     Web definitions define the contact as close interaction and the state or condition of touching or of immediate proximity. Word address is defined as speak to; to dispatch or consign to an agent or factor. Looking at all these, dictionary speaks plenty of words but people consider as per their requirement. So people defined contact address as the interaction place to speak. In brief contact address means a mailing address at which a person affiliated with the organization will receive and transmit to the organization notices intended for the foreign or domestic corporation when it is either not practical to send such notices to the registered agent, or a duplicate notice is desirable. 
   </td>
 </tr>
 <tr><td style="border-bottom:dotted 1px #666; width:100%" colspan="2"></td></tr>
 <tr><td class="mid2_menu" colspan="2" style="color:#004080; letter-spacing:1px;">The contact address may be the principal place of business, if any, or the business or residence address of any person associated with the corporation or foreign corporation who has consented to serve, but shall not be the address of the registered agent. In computers technical knowledge, local search is a metaheuristic for solving computationally hard optimization tribulations. This can be used on problems that can be formulated as finding a solution maximizing a criterion among a number of candidate solutions.</td></tr>
 <tr><td style="border-bottom:dotted 1px #666; width:100%" colspan="2"></td></tr>
	</table>
	
	<%--</li>--%>
	<%--<li class="mid2_menu">Web definitions define the contact as close interaction and the state or condition of touching or of immediate proximity. Word address is defined as speak to; to dispatch or consign to an agent or factor. Looking at all these, dictionary speaks plenty of words but people consider as per their requirement. So people defined contact address as the interaction place to speak. In brief contact address means a mailing address at which a person affiliated with the organization will receive and transmit to the organization notices intended for the foreign or domestic corporation when it is either not practical to send such notices to the registered agent, or a duplicate notice is desirable. </font></span></li>
    <li class="mid2_menu">The contact address may be the principal place of business, if any, or the business or residence address of any person associated with the corporation or foreign corporation who has consented to serve, but shall not be the address of the registered agent. In computers technical knowledge, local search is a metaheuristic for solving computationally hard optimization tribulations. This can be used on problems that can be formulated as finding a solution maximizing a criterion among a number of candidate solutions. </li>
	</ul>--%>
	<%--</div>--%>
  </td>
 </tr>
 </table>	
<%--</div>--%>
<%--</div>
</div>--%>
<%--<div id="scroller-bottom">
</div>--%>
</div>
</div>
<div class="content_midbootam" style="padding-top:20px;" >
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
