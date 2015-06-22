<%@ Page Language="C#" AutoEventWireup="true" CodeFile="JC_OnMobile.aspx.cs" Inherits="JC_OnMobile" %>
<%@ Register Src="usercontrols/footer1.ascx" TagName="footer1" TagPrefix="aa10" %>
<%@ Register Src="usercontrols/footer2.ascx" TagName="footer2" TagPrefix="aa11" %>
<%@ Register Src="usercontrols/BottomContent.ascx" TagName="bottomcontent" TagPrefix="aa4" %>
<%@ Register Src="usercontrols/BottomMidContent.ascx" TagName="bottomMidcontent" TagPrefix="aa5" %>
<%@ Register Src="usercontrols/SearchNew.ascx" TagName="SearchNew" TagPrefix="New" %>
<%@ Register Src="usercontrols/small_logo.ascx" TagName="logo" TagPrefix="S_logo" %>
<%@ Register Src="usercontrols/signin.ascx" TagName="signin" TagPrefix="aa1" %>
<%@ Register Src="usercontrols/Search.ascx" TagName="catag" TagPrefix="aa6" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>:: Just Calluz :: JC  Mobile page</title>
<link href="css/inner_style.css" rel="stylesheet" type="text/css" />
<link href="css/style.css" rel="stylesheet" type="text/css" />
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
<!-- start The Content-->
<div class="content" style="padding:0; margin:0;">
<table width="100%" border="0">
  <tr>
    <td height="26" colspan="5" align="left" class="mobile" style="padding-left:5px"><a href="index.html">Home</a>&nbsp; &gt; &nbsp;Justcalluz on Mobile</td>
    </tr>
  <tr>
  <td height="40" align="center" class="mobile">Justcalluz<samp>  Mobile Search</samp></td>
    <td>&nbsp;</td>
    <td align="center" class="mobile"> Justcalluz  <samp>Mobile Apps</samp></td>
    <td>&nbsp;</td>
    <td align="center" class="mobile"><samp>SMS Search</samp></td>
  </tr>
  <tr>
    <td align="center"><img src="images/phone01.png" width="171" height="298" /></td>
    <td>&nbsp;</td>
    <td align="center"><img src="images/phone02.png" width="399" height="305" /></td>
    <td>&nbsp;</td>
    <td align="center"><img src="images/phone03.png" width="171" height="298" /></td>
  </tr>
  <tr>
    <td height="50" align="center"><a href="#"><img src="images/send_link.png" width="138" height="33" /></a></td>
    <td>&nbsp;</td>
    <td align="center"><a href="#"><img src="images/downlod_now.png" width="138" height="33" /></a></td>
    <td>&nbsp;</td>
    <td align="center"><a href="#"><img src="images/view_demo.png" width="138" height="33" /></a></td>
  </tr>
</table>
 
</div>
<div class="content_midbootam" >
<aa5:bottomMidcontent ID="mid1" runat="server" />

</div>
<div class="content_bootam_center">
<aa4:bottomcontent ID="bottomcontent1" runat="server" />

</div>

<div align="center" style="padding-top:5px; " >
  <aa10:footer1 ID="footer1" runat="server" />
 <aa11:footer2 ID="footer2" runat="server" />

</div>
<!-- end of the content-->

</div>
    </form>
</body>
</html>
