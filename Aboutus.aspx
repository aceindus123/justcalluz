<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Aboutus.aspx.cs" Inherits="Aboutus" %>
<%@ Register Src="usercontrols/signin.ascx" TagName="signin" TagPrefix="aa1" %>
<%@ Register Src="usercontrols/Search.ascx" TagName="catag" TagPrefix="aa6" %>
<%@ Register Src="usercontrols/footer1.ascx" TagName="footer1" TagPrefix="aa10" %>
<%@ Register Src="usercontrols/footer2.ascx" TagName="footer2" TagPrefix="aa11" %>
<%@ Register Src="usercontrols/BottomContent.ascx" TagName="bottomcontent" TagPrefix="aa4" %>
<%@ Register Src="usercontrols/BottomMidContent.ascx" TagName="bottomMidcontent" TagPrefix="aa5" %>
<%@ Register Src="usercontrols/SearchNew.ascx" TagName="SearchNew" TagPrefix="New" %>
<%@ Register Src="usercontrols/small_logo.ascx" TagName="logo" TagPrefix="S_logo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>Company Overview – Facts, Mission & Corporate information | JustCalluz</title>
<meta name='description' content='JustCalluz company overview with facts, mission, company information, investors and key highlights. Find complete company information about JustCalluz – No.1 local search engine.' />
<meta name='keywords' content='justcalluz company overview, justcalluz overview, justcalluz company information, justcalluz corporate information, justcalluz facts, justcalluz mission' />
		

<%--<title>:: Justcalluz :: About Us</title>--%>
<link href="css/style.css" rel="stylesheet" type="text/css" />
<link href="css/inner_style.css" rel="Stylesheet" type="text/css" />
<script src="SpryAssets/SpryTabbedPanels.js" type="text/javascript"></script>
<link href="SpryAssets/SpryTabbedPanels.css" rel="stylesheet" type="text/css" />
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
<div class="content_innermid" style="width:100%;">
<div class="middle_search1">
<div class="middle_searchtop1">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Welcome to JustCallUz</div>
 <div class="middle_searchmid1" >
 <table width="100%" border="0">
  <tr>
    <td class="sub_menu" style="padding-left:20px;">About us</td>
  </tr>
  <tr>
    <td class="sub_menu" style="padding-left:20px;" height="30"><font color="#006600"><strong>Corporate Address</strong></font></td>
  </tr>
  <tr align="justify">
    <td class="mid2_menu"  style="padding-left:30px; padding-top:2px; line-height:30px;"><font color="#002C40">JustCalluz is a fastest growing local search engine, operating from Hyderabad, India. Coterie of minds started this idea with the name Anta Online later it changed to<span class="location"><font color="#A60000"> Callus Online Ad service Private Limited.</font></span><br/>
    <strong ><font  color="#C10000">Vision :</font></strong>Serving people and businesses by fulfilling their needs to make them local across the globe.<br/>
    <strong ><font color="#C10000">Mission :</font></strong>Providing quality local information and eligible business leads with a greater score of satisfaction for both business providers and end users.<hr/>
    <p align="justify" style="padding-left:1px;">JustCalluz is a commercial internet medium. A JustCalluz visitor can get the desired business information instantly by selecting a location name from the given options and enter the search keyword in the search option. In addition, JustCalluz also provides a visitor to expand the track by the area code for a search result, for a search result of the whole state. JustCalluz is both user-friendly and more convenient for its visitors. Simply saying, Callus will remove all the hurdles for the local information seeker through a user-friendly search option and provides instant information. It is trying to create a mark in local search businesses globally by providing quality service and gaining customer satisfaction.</p><hr/>
   <p align="justify" style="padding-left:1px;">We aspire to be the best supplier of quality big business leads in all our markets. Across our services we offer high-quality leads to our advertisers through a range of channels which comprise local guides, classified directories, search engines, online local search, and operator assisted phone services.<hr/></p><p align="justify" style="padding-left:1px;">JustCalluz works 24/7 to find innovative ways and make local search much easier & simpler, we welcome people with creative ideas and zeal to learn & develop.</p></font><hr/></td>
  </tr>
</table>
</div>
 <div class="middle_searchbottam1"></div>
  
</div>
</div>
<!-- end of the mid Box-->
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
var TabbedPanels1 = new Spry.Widget.TabbedPanels("TabbedPanels1");
//-->
</script>
    </form>
</body>
</html>
