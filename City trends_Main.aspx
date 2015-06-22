<%@ Page Language="C#" AutoEventWireup="true" CodeFile="City trends_Main.aspx.cs" Inherits="City_trends1_Main" %>
<%@ Register Src="usercontrols/signin.ascx" TagName="signin" TagPrefix="aa1" %>
<%@ Register Src="usercontrols/footer1.ascx" TagName="footer1" TagPrefix="aa10" %>
<%@ Register Src="usercontrols/footer2.ascx" TagName="footer2" TagPrefix="aa11" %>
<%@ Register Src="usercontrols/BottomContent.ascx" TagName="bottomcontent" TagPrefix="aa4" %>
<%@ Register Src="usercontrols/BottomMidContent.ascx" TagName="bottomMidcontent" TagPrefix="aa5" %>
<%@ Register Src="usercontrols/SearchNew.ascx" TagName="SearchNew" TagPrefix="New" %>
<%@ Register Src="usercontrols/small_logo.ascx" TagName="logo" TagPrefix="S_logo" %>
<%@ Register Src="usercontrols/Search.ascx" TagName="catag" TagPrefix="aa6" %>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<%--<title>:: Justcalluz :: CitytrendsMain Home page</title>--%>
    <title>City Trends - Current trends of major cities in India | JustCalluz</title>
	<meta name="title" content="City Trends - Current trends of major cities in India | JustCalluz" />
	<meta name="DESCRIPTION" content="JustCalluz City Trends brings you the option to find local top featuring trends for movies, fashion, clothing, home decor and more in the major cities in India. Select the desired city and view local trends based on the combination of reviews and ratings." />
	<meta name="keywords" content="city trends, local trends, latest trends, justcalluz city trends, business trends, company trends, movie trends, justcalluz trends" />
	
	
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
<!-- start The Content-->
<div class="content" style="padding:0; margin:0;">
<div class="content_innerleft">
<div class="contentbox_top">Select Your City</div>
<div class="contentbox_mid"  style="padding-left:15px;">
 <table width="100%" border="0">
   <tr>
    <td width="100%" valign="top">
     <asp:DataList ID="DlPopCities1" runat="server" DataKeyField="cname" 
        RepeatDirection="Vertical" Width="100%">
       <ItemTemplate>
       <ul><li>
         <asp:HyperLink ID="lnkpopcity" runat="server" Text='<%#Eval("cname")%>' 
               NavigateUrl='<%# GetUrl(Eval("cname")) %>' Font-Size="10" Font-Names="Arial" Font-Bold="false">
         </asp:HyperLink>
       </li></ul>
       </ItemTemplate>
     </asp:DataList>
    </td>
  </tr>
</table>
</div>
<div class="contentbox_bottam"></div>
</div>
<div class="content_innermid" style="width:79%; padding-left: 4px;">
  <table width="100%" border="0">
  <tr>
    <td align="center"><h1>Select Your City To View Local Trends</h1></td>
  </tr>
  <tr>
    <td><div id="local_trends">Select Your City To View Local TrendsView Local Trends 
        across major cities in India. These trends are combination of Reviews and 
        Ratings voted by users like you helping local searching more fun and accurate! 
        You can view local trends for Movies, Clothing, Fashion, Entertainment and 
        more... Just select your city and view top featuring trends for that city!</div></td>
  </tr>
  <tr>
    <td height="30">&nbsp;</td>
  </tr>
  <tr>
    <td align="center" >
     <table width="60%" border="0" style="background: url(images/city_bg.png) no-repeat; width:400px; height:130px" >
      <tr>
          <td width="100%" height="60px" valign="top" style="padding:8px;" >
             <asp:DataList ID="DlPopCities" runat="server" DataKeyField="cname" RepeatColumns="3"
                RepeatDirection="Vertical" Height="117px" Width="100%">
               <ItemTemplate>
                 <asp:HyperLink ID="lnkpopcity" runat="server" Text='<%#Eval("cname")%>'  
                      NavigateUrl='<%# GetUrl(Eval("cname")) %>'>
                 </asp:HyperLink>
               </ItemTemplate>
             </asp:DataList>
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
<div align="center" style="padding-top:5px; " >
  <aa10:footer1 ID="footer1" runat="server" />
 <aa11:footer2 ID="footer2" runat="server" />
</div>
</div>
<!-- end of the content-->
 </form>
</body>
</html>
