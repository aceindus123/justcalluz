<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Disclaimer.aspx.cs" Inherits="Disclaimer" %>
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
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>:: Justcalluz :: Disclaimer</title>
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
<aa1:signin ID="awea" runat="server" />
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
 <div class="middle_searchmid1"><table width="100%" border="0">
  <tr>
    <td class="sub_menu" style="padding-left:20px;"><font color="#C10000">Disclaimer</font></td>
  </tr>
  <tr>
    <td class="mid2_menu"  style="padding-left:30px; padding-top:5px; line-height:30px;"><font color="#002C40">
     <p align="justify"> This information is purely directive and is a reproduction of contents available on the websites/web pages of the respective manufacturers and suppliers of the products and services described. All contents are the copyright of their respective authors/owners. Further, we cannot and do not warrant that the information on this server is absolutely latest although every effort is made to ensure that it is kept as latest as possible. If you are the owner/author of content displayed on our site and do not wish that such content should be displayed, kindly inform the administrator at info@JustCalluz.com.</p><hr/>
<p align="justify"> We cannot and do not warrant the accuracy of these documents beyond certain level, although we do make every attempt to work from authoritative sources.</p></font></td>
  </tr>
</table>
</div>
 <div class="middle_searchbottam1"></div>
  
</div>
</div>
<!-- end of the mid Box-->
</div>
<div class="content_midbootam">
<aa5:bottomMidcontent ID="mid1" runat="server" />
</div>
<div class="content_bootam_center">
<aa4:bottomcontent ID="bottomcontent1" runat="server" />
</div>
<div class="footer" align="center" style="padding-top:5px; " >
<aa10:footer1 ID="sdsa" runat="server" />
<aa11:footer2 ID="poshv" runat="server" />
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
