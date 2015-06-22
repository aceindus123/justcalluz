<%@ Page Language="C#" AutoEventWireup="true" CodeFile="More.aspx.cs" Inherits="More" %>
<%@ Register Src="usercontrols/SearchNew.ascx" TagName="SearchNew" TagPrefix="New" %>
<%@ Register Src="usercontrols/small_logo.ascx" TagName="logo" TagPrefix="S_logo" %>
<%@ Register Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" TagPrefix="cc3"  %>
<%@ Register Src="usercontrols/signin.ascx" TagName="signin" TagPrefix="aa1" %>
<%@ Register Src="usercontrols/footer1.ascx" TagName="footer1" TagPrefix="aa10" %>
<%@ Register Src="usercontrols/footer2.ascx" TagName="footer2" TagPrefix="aa11" %>
<%@ Register Src="usercontrols/BottomContent.ascx" TagName="bottomcontent" TagPrefix="aa4" %>
<%@ Register Src="usercontrols/BottomMidContent.ascx" TagName="bottomMidcontent" TagPrefix="aa5" %>
<%@ Register Src="usercontrols/Home_right.ascx" TagName="homeright" TagPrefix="aa7" %>
<%@ Register Src="usercontrols/Search.ascx" TagName="catag" TagPrefix="aa6" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<%--<title>:: Justcalluz :: More Categories page</title>--%>
<title id="pgtitle" runat="server"></title>
<link href="css/style.css" rel="stylesheet" type="text/css" />
<link href="css/inner_style.css" rel="Stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
      <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePageMethods="true">
    </asp:ScriptManager>
    <div class="layout">    
<div class="signin">
<aa1:signin ID="SignIn1" runat="server" />
</div>
<div class="header">
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
<div class="content_innermid" style="width:77%; padding: 0px 5px 0px 0px;">
<table width="100%" border="0"  >
  <!--requisiters.png-->
  <tr>
    <td class="mid_menu" height="39" style="padding-left:15px; background:url(images/event_send2.png) no-repeat " valign="middle">
    <a href="<%$RouteUrl:RouteName=HomeRoute%>" runat="server"><font style="padding-left:45px;">Home</font></a>>><asp:Label ID="lblcat" runat="server"></asp:Label>
    <span class="side_menu"><font>&nbsp;&nbsp;&nbsp;( Refine your search by clicking any of the links below )</font></span></td>
  </tr>
  <%--<tr>
    <td  class="bottam_menu"  valign="top">
    <table width="100%" border="0px">--%>
  <tr>
    <td width="100%"  class="select_menu" style="padding-left:5px; line-height:28px;" valign="top"><br/>
    <asp:DataList ID="dlcat" RepeatDirection="Vertical" CellPadding="4" runat="server" RepeatColumns="2"> 
                <HeaderTemplate>
                </HeaderTemplate>
                <ItemTemplate>
                    <div class="innertext2">
                    <table border="0px" width="100%">
                          <tr style="padding-left:10px; border-right-style:dotted; border-right-width:1px">                             
                           <td valign="top" style="padding-left:10px">
                               <%-- <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%#Eval("cat")%>'
                                 Text ='<%# Eval("cat") %>' OnCommand="GotoLinkController" Width="250px">
                                </asp:LinkButton>--%>
                                 <asp:HyperLink ID="hyplink" runat="server" NavigateUrl='<%# GetUrl(Eval("cat"))%>'
                                     Text ='<%# Eval("cat") %>' Width="250px">
                                </asp:HyperLink>
                            </td>
                            <td height="10px"></td>
                        </tr>
                    </table>
                   </div> 
               </ItemTemplate>
             </asp:DataList>
    </td>
    <%--<td width="3%" style="border-right: 1px  dashed #666">&nbsp;</td>
     <td width="51%"  class="select_menu" style="padding-left:25px; line-height:28px;">      
       </td>--%>
  </tr>
<%--</table>
</td>
  </tr>--%>
</table>
 </div>
<%--<div class="content_right" style="width:30%">
  <table width="100%" border="0">
    <tr>
      <td width="100%" class="headings">Reviews &amp; Ratings<br /><br /></td>
    </tr>
    <tr>
      <td></td>
    </tr>
   
  </table>
</div>--%>
<div class="content_innerright1">
<div class="contentbox_top1">&nbsp;&nbsp;&nbsp;Reviews &amp; Ratings</div>
<div class="contentbox_mid1">
  <table width="100%" border="0">
   <tr>
     <td>
       <aa7:homeright ID="homeright" runat="server" />
    </td>
    </tr>
  </table>
</div>
<div class="contentbox_bottam1"></div>
</div>
</div>
<div class="content_midbootam" >
<aa5:bottomMidcontent ID="mid1" runat="server" />
</div>
<div class="content_bootam_center">
<aa4:bottomcontent ID="bottomcontent1" runat="server" />
</div>
<div class="footer" align="center" style="padding-top:5px; " >
  <aa10:footer1 ID="footer1" runat="server" />
 <aa11:footer2 ID="footer2" runat="server" />
</div>
</div>
    </form>
</body>
</html>
