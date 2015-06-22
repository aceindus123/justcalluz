<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Discounts.aspx.cs" Inherits="Discounts" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="AjaxToolkit"%>
<%@ Register Src="usercontrols/signin.ascx" TagName="signin" TagPrefix="aa1" %>
<%@ Register Src="usercontrols/Search.ascx" TagName="catag" TagPrefix="aa6" %>
<%@ Register Src="usercontrols/footer1.ascx" TagName="footer1" TagPrefix="aa10" %>
<%@ Register Src="usercontrols/footer2.ascx" TagName="footer2" TagPrefix="aa11" %>
<%@ Register Src="usercontrols/BottomContent.ascx" TagName="bottomcontent" TagPrefix="aa4" %>
<%@ Register Src="usercontrols/BottomMidContent.ascx" TagName="bottomMidcontent" TagPrefix="aa5" %>
<%@ Register Src="usercontrols/discount_left.ascx" TagName="leftdiscount" TagPrefix="ldsc" %>
<%@ Register Src="usercontrols/SponsoredLinks.ascx" TagName="spd_Links" TagPrefix="SpLinks" %>
<%@ Register Src="usercontrols/SearchNew.ascx" TagName="SearchNew" TagPrefix="New" %>
<%@ Register Src="usercontrols/small_logo.ascx" TagName="logo" TagPrefix="S_logo" %>
<%@ Register Src="usercontrols/rightsearch.ascx" TagName="rightsrch" TagPrefix="rsearch" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<%--<title>:: Justcalluz :: Discounts page</title>--%>
<title>Justcalluz | Find Discount and coupon code in your city | we provide updated information on all your local search</title>
<meta name='description' content='Discount rates,sale,Event Management'/>
<meta name='keywords' content='Justcalluz,Discount rates,sale,Event Management,online yellow pages, yellow pages india, India trade directory,  yellow pages directory, city yellow pages, indian search engine, JustCalluz customer care, JustCalluz customer support' />
<link href="css/style.css" rel="stylesheet" type="text/css" />
<link href="css/inner_style.css" rel="Stylesheet" type="text/css" />
<%--<link href="includes/style.css" rel="Stylesheet" type="text/css" />--%>
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
<div class="content" style="padding:0; margin:0;">
<div class="content_innerleft">
<div>
<div class="contentbox_top">Popular Search</div>
<div class="contentbox_mid"> 
<!-- start the inner left-->
<ldsc:leftdiscount id="Ldiscount" runat="server"></ldsc:leftdiscount>
<!-- end of the inner left-->
</div>
<div class="contentbox_bottam"></div>
</div>
</div>
<!-- start the mid Box-->
<div class="content_innermid">
<div>
<div class="contentmid_boxtop"><%--<asp:HyperLink ID="hyplink" runat="server" NavigateUrl="Default.aspx" Text="Home" Font-Underline="false" ForeColor="White"></asp:HyperLink>--%>
  <asp:HyperLink ID="hyplink" runat="server" NavigateUrl="<%$RouteUrl:RouteName=HomeRoute%>" Text="Home" Font-Underline="false" ForeColor="White"></asp:HyperLink>
    &gt;&gt; Discounts</div>
<div class="contentmid_boxmid">
<table width="100%" border="0">
<tr>
<td width="48%" height="30" align="right" class="headings">
    Result for</td>
<td width="1%"><font color="#000000"><strong>:</strong></font></td>
<td width="51%"><font color="#006393" class="side_menu">Discounts</font></td>
</tr>
<tr>
<td colspan="3" style="background:url(images/events-search.png) no-repeat" valign="top">
<table width="100%" border="0">
<tr>
<td colspan="2" rowspan="2" valign="top" >
<table width="100%" border="0">
<tr>
  <td height="20" colspan="4" class="sub_menu" style="padding-left:20px;">Choose A 
      Date</td>
</tr>
<tr>
  <td width="13%" class="headings1" style="padding-left:40px;">From</td>
  <td width="29%" align="center"><asp:TextBox ID="txtfrom" runat="server"></asp:TextBox></td>
  <td width="6%" class="headings1" align="center"><span style="padding-left:10px; padding-top:10px;">
      To</span></td>
  <td width="29%"><asp:TextBox ID="txtto" runat="server"></asp:TextBox></td>
 <td width="23%" style="padding-left:5px;"><asp:ImageButton ID="go" runat="server" 
          ImageUrl="images/go.png" onclick="go_Click" AlternateText="imgGo"/></td>
</tr>
</table>
<AjaxToolkit:CalendarExtender Animated="true" ID="calenderExtender1" runat="server" TargetControlID="txtfrom"></AjaxToolkit:CalendarExtender>
<AjaxToolkit:CalendarExtender Animated="true" ID="CalendarExtender2" runat="server" TargetControlID="txtto"></AjaxToolkit:CalendarExtender>
</td>
<td width="1%" height="30">&nbsp;</td>
</tr>
<tr>
<td height="27">&nbsp;</td>
</tr>
<tr>
<td width="81%" height="25px" style="padding-left:15px;">
  <span class="side_menu">
   <a id="todaybut" runat="server" onserverclick="todaybut_Click">Today</a>
  </span>&nbsp; | 
  <span class="side_menu">
   <a id="tombut" runat="server" onserverclick="tombut_Click">Tomorrow</a>
    &nbsp;</span>| &nbsp;
  <span class="side_menu">
   <a id="weekbut" runat="server" onserverclick="weekbut_Click">This Weekend</a>
    &nbsp;</span> |&nbsp;
  <span class="side_menu">
   <a id="nweekbut" runat="server" onserverclick="nweekbut_Click">Next Weekend</a>
    &nbsp;</span>| &nbsp;
</td>
<td width="18%" valign="middle" style="padding-left:15px;">&nbsp;</td>
<td>&nbsp;</td>
</tr>
</table></td>
</tr>
<tr>
<td colspan="3" align="right" style="padding-right:3px;">
  <asp:HyperLink ID="post" runat="server" Text="Post Your Discount" Font-Size="11px" NavigateUrl="<%$RouteUrl:RouteName=PostDiscount,cname=discounts%>" 
        CssClass="side_menu" Font-Bold="true" Font-Underline="false" ForeColor="Red" ></asp:HyperLink>
 <%--<asp:HyperLink ID="post" runat="server" Text="Post Your Discount" Font-Size="11px" NavigateUrl="post_discount.aspx?cname=discounts" 
        CssClass="side_menu" Font-Bold="true" Font-Underline="false" ForeColor="Red" ></asp:HyperLink>--%>
</td>
                                             
</tr>
<tr><td colspan="3">
    <asp:Label ID="lblerror" runat="server"></asp:Label></td></tr>
<tr>
<td colspan="3">
<asp:DataList ID="ddldiscounts" DataKeyField="id" runat="server" Width="100%" OnItemDataBound="ddldiscounts_ItemDataBound">
    <HeaderTemplate>
    </HeaderTemplate>
    <ItemTemplate>
    <table width="100%" border="0">
      <tr>
       <td valign="top" style="background:url(images/event_send03.png) no-repeat; height:200px;">
        <table width="100%" border="0">
        <tr>
          <td width="60%" class="headings" valign="middle" align="left" style="padding-left:6px; padding-top:3px;">
             <strong class="sub_menu">
              <asp:HyperLink ID="Hypcmpname" runat="server" Text='<%# Eval("company_name") %>' NavigateUrl='<%# GetUrl(Eval("id")) %>'></asp:HyperLink>
              <%-- <asp:HyperLink ID="Hypcmpname" runat="server" Text='<%# Eval("company_name") %>' NavigateUrl='<%# string.Format("Discount_Details.aspx?id=" + Eval("id").ToString()+ "&cname=discounts") %>'></asp:HyperLink>--%>
            </strong>
             </td> 
            <td height="20" valign="middle" align="right" style="padding-right:10px; padding-top:3px;">
             <strong class="sub_menu">
              <asp:HyperLink ID="hypRatethis" runat="server" NavigateUrl='<%# GetCatUrl( Eval("id"))%>' Text="Rate this"></asp:HyperLink>
            <%-- <asp:HyperLink ID="hypRatethis" runat="server" NavigateUrl='<%# string.Format("PostReviewCat.aspx?DataId=" + Eval("id").ToString() + "&mod=Discounts")%>' Text="Rate this"></asp:HyperLink>--%>
            </strong>
            </td>    
         </tr>
         <tr>
          <td colspan="15" height="125" style="padding-left:5px; padding-top:5px;" class="side_menu" valign="top"> 
              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
           <table>
           <tr>
            <td width="23%" rowspan="3" style="padding-bottom:20px;" id="tdlogo" runat="server" visible="false">
               <asp:Label ID="lblImgName" runat="server" Text='<%# Eval("ImageName") %>' Visible="false"></asp:Label>
               <asp:Image  ID="imgReviewer"  runat="server" AlternateText="Reviewer" ImageUrl='<%# Eval("ImageName", "../Logos\\{0}") %>' 
                    Width="99"  Height="68"/>
            </td>
            <td style="height:30px; padding-left:2px;">
                <asp:Label ID="lbladdress" runat="server" Text ='<%# Eval("address") %>'></asp:Label>
                <asp:Label ID="lblcomma" runat="server" Text=","></asp:Label>
                <asp:Label ID="lblcity" runat="server" Text ='<%# Eval("City") %>'></asp:Label>
                <asp:Label ID="lblcomma1" runat="server" Text=","></asp:Label>
                <asp:Label ID="lblstate" runat="server" Text ='<%# Eval("State") %>'></asp:Label>
                 <asp:Label ID="lblcomma2" runat="server" Text=","></asp:Label>
                <asp:Label ID="lblpincode" runat="server" Text ='<%# Eval("Pincode") %>'></asp:Label><br /><br />
                <strong class="sub_menu">Contact</strong>&nbsp;:&nbsp;<asp:Label ID="lblmob" runat="server" Text ='<%# Eval("contact_person") %>'></asp:Label>
                &nbsp;|
                <asp:Label ID="lbllandphone" runat="server" Text ='<%# Eval("mob") %>'></asp:Label>
             </td>
            </tr>
             <tr>
              <td class="side_menu" align="left" style="height:30px;">
               <asp:Literal ID="Literal3" runat="server" Text='<%#Eval("event_desc")%>' /></td>
             </tr>
           </table>
            </td>
         </tr>
         <%--<tr><td colspan="4">&nbsp;</td></tr>--%>
          <tr>
          <td colspan="6" align="right" class="sub_menu" style="padding-right:10px;">
              <asp:HyperLink ID="details" runat="server" Text="View Details" Font-Size="11px" NavigateUrl='<%# GetUrl(Eval("id")) %>' ></asp:HyperLink>
         </td>
         </tr>
     </table>
   </td>
   </tr>
   </table>
  </ItemTemplate>
</asp:DataList>
<table border="0" width="100%" id="trpagesize" runat="server">
<tr><td>&nbsp;</td></tr>
 <tr id="trPaging" runat="server">
  <td align="right" style="padding-right:13px;">
    <asp:ImageButton ID="imgPrevious" runat="server" AlternateText="btnPrevious" ImageUrl="images/arrow_2.png" OnClick="imgPrevious_Click"/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:ImageButton ID="imgNext" runat="server" AlternateText="btnNext" ImageUrl="images/arrow_1.png" OnClick="imgNext_Click" />
  </td>
 </tr>
</table>
</td>
</tr>
<tr>
<td colspan="3">&nbsp;</td>
</tr>
</table>
</div>
<div class="contentmid_boxbottam"></div>
</div>
</div>
<!-- end of the mid Box-->
<div class="content_innerright">
<div class="contentbox_top">Search By Cities</div>
<div class="contentbox_mid">
  <rsearch:rightsrch ID="rjobsearch" runat="server" />
</div>
<div class="contentbox_bottam"></div>
<div class="contentbox_top">Sponsor Ads</div>
<div class="contentbox_mid">
 <table width="100%" border="0">
   <tr>
     <td class="right_tab">
       <SpLinks:spd_Links ID="right_links" runat="server" />
     </td>
    </tr>
  </table>
 </div>
<div class="contentbox_bottam"></div>
</div>
<div 
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
</div>
 </form>
</body>
</html>
