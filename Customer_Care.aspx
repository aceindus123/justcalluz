<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Customer_Care.aspx.cs" Inherits="Customer_Care" %>
<%@ Register Src="usercontrols/footer1.ascx" TagName="footer1" TagPrefix="aa10" %>
<%@ Register Src="usercontrols/footer2.ascx" TagName="footer2" TagPrefix="aa11" %>
<%@ Register Src="usercontrols/BottomContent.ascx" TagName="bottomcontent" TagPrefix="aa4" %>
<%@ Register Src="usercontrols/BottomMidContent.ascx" TagName="bottomMidcontent" TagPrefix="aa5" %>
<%@ Register Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" TagPrefix="cc3"  %>
<%@ Register Src="usercontrols/SearchNew.ascx" TagName="SearchNew" TagPrefix="New" %>
<%@ Register Src="usercontrols/small_logo.ascx" TagName="logo" TagPrefix="S_logo" %>
<%@ Register Src="usercontrols/signin.ascx" TagName="signin" TagPrefix="aa1" %>
<%@ Register Src="usercontrols/Search.ascx" TagName="catag" TagPrefix="aa6" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<%--<title>:: Just Calluz :: Customer Care  page</title>--%>
<title>JustCalluz Customer Care</title>
<meta name='Title' content='JustCalluz Customer Care' />
<link href="css/inner_style.css" rel="stylesheet" type="text/css" />
<link href="css/style.css" rel="Stylesheet" type="text/css" />
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
<div class="header_search" style="width:790px;">
  <table width="100%" border="0">
    <tr>
      <td width="77%">&nbsp;</td>
      <td width="23%" align="right" valign="middle"><img alt="ContactNumber" src="images/66136226.png" width="175" height="51" /></td>
    </tr>
  </table>
</div>
<!-- start The Content-->
<div class="content" style="padding:0; margin:0;">
<div class="content_innermid" style="width:100%;">
  <table width="100%" border="0">
    <tr>
       <td height="30"><strong><a href="<%$RouteUrl:RouteName=HomeRoute %>" runat="server">Home</a></strong> &gt; Customer Care</td>
    </tr>
    <tr>
      <td height="30" class="mobile">In order to serve you better, please verify yourself</td>
    </tr>
    <tr>
      <td height="100" align="center" valign="middle"><table width="58%" border="0">
        <tr>
          <td width="25%"><strong>City</strong></td>
          <td width="0%">&nbsp;</td>
          <td width="66%"><strong>Enter your company name, and select the same from the list</strong></td>
          <td width="1%">&nbsp;</td>
          <td width="28%">&nbsp;</td>
        </tr>
        <tr>
          <td><asp:TextBox ID="txtcity" runat="server" Height="30px" AutoPostBack="true" 
                  Text="Hyderabad" ontextchanged="txtcity_TextChanged"></asp:TextBox></td>
           
          <td>&nbsp;</td>
          <td><asp:TextBox ID="txtcmp" runat="server" Width="380px" Height="30px"></asp:TextBox></td>
          <td>&nbsp;</td>
          <td><asp:ImageButton ID="imggo" AlternateText="Gobutton" runat="server" ImageUrl="images/go.jpg" 
                  onclick="imggo_Click" /></td>
        </tr>
      </table>
     
      </td>
    </tr>
   <%-- <tr><td><asp:Label ID="lblexception" runat="server"></asp:Label></td></tr>--%>
  </table>
<cc3:AutoCompleteExtender ID="autoselectcity" runat="server" TargetControlID="txtcity" MinimumPrefixLength="1" EnableCaching="true" CompletionSetCount="1" CompletionInterval="500" ServiceMethod="Getcities" ShowOnlyCurrentWordInCompletionListItem="true">
    </cc3:AutoCompleteExtender>
    <cc3:AutoCompleteExtender ID="autoselectcompany" runat="server" TargetControlID="txtcmp" MinimumPrefixLength="1" EnableCaching="true" CompletionSetCount="1" CompletionInterval="500" ServiceMethod="Getcompanies" ShowOnlyCurrentWordInCompletionListItem="true">
    </cc3:AutoCompleteExtender>
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
