<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ThankYou.aspx.cs" Inherits="ThankYou" %>
<%@ Register Src="usercontrols/signin.ascx" TagName="signin" TagPrefix="aa1" %>
<%@ Register Src="usercontrols/SearchNew.ascx" TagName="SearchNew" TagPrefix="New" %>
<%@ Register Src="usercontrols/small_logo.ascx" TagName="logo" TagPrefix="S_logo" %>
<%@ Register Src="usercontrols/Search.ascx" TagName="catag" TagPrefix="aa6" %>
<%@ Register Src="usercontrols/footer1.ascx" TagName="footer1" TagPrefix="aa10" %>
<%@ Register Src="usercontrols/footer2.ascx" TagName="footer2" TagPrefix="aa11" %>
<%@ Register Src="usercontrols/BottomContent.ascx" TagName="bottomcontent" TagPrefix="aa4" %>
<%@ Register Src="usercontrols/BottomMidContent.ascx" TagName="bottomMidcontent" TagPrefix="aa5" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Justcalluz--Thank you page</title>
    <link href="style.css" rel="stylesheet" type="text/css" />
    <link href="css/style.css" rel="stylesheet" type="text/css" />
    <link href="css/inner_style.css" rel="Stylesheet" type="text/css" />

</head>
<body>
    <form id="form1" runat="server">
      <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
   <div class="layout">
<div class="signin">
<aa1:signin ID="Signin1" runat="server" />
</div>
<div class="header">
<%--<div class="header_top"></div>--%>
<div class="header_logo"><S_logo:logo ID="logo" runat="server" /></div>
<div class="header_search">
 <New:SearchNew ID="New" runat="server" />
</div>
 </div>
<div class="category_box">
 <aa6:catag ID="Catag1" runat="server" />
</div>
<div class="content" style="padding:0; margin:0;">
<div class="content_innermid" style="width:100%;">
     <table width="960" border="0" bordercolor="#003366"cellpadding="0" cellspacing="0" align="center">
<tr>
<td>
    <%--<asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
<aa1:signin ID="suy" runat="server" />
<aa2:topimage ID="uypo" runat="server" />
<aa5:boxes ID="fbhu" runat="server" />
<aa6:catag ID="uye" runat="server" />--%>

<table width="927" border="0" cellpadding="0" cellspacing="0" align="center"  style="margin-left:20px;"  >
<tr>
<td valign="top" style="padding-left:20px" align="center">
    <table width="100%" border="0" style="background:url(images/ThankU.jpg) no-repeat; height:600px; width:600px;">
        <tr>
            <td height="90" colspan="2" valign="middle" align="center">
            
                <asp:Label ID="lblMsg" runat="server"></asp:Label>
            
            <%--<font size="+1">Thank you for registering into Justcalluz.<br />
        <br />
Please go through your mail id to activate your account.<br />
<br />
Enjoy Our Services!</font>--%>
            </td>
        </tr>
    </table>  
<!--end of content-->
</td>
</tr>
</table>
</td>
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
    </form>
</body>
</html>
