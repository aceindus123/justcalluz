<%@ Page Language="C#" AutoEventWireup="true" CodeFile="view_events.aspx.cs" Inherits="view_events" %>
<%@ Register Src="usercontrols/signin.ascx" TagName="signin" TagPrefix="aa1"  %>
<%@ Register Src="usercontrols/Search.ascx" TagName="catag" TagPrefix="aa6" %>
<%@ Register Src="usercontrols/footer1.ascx" TagName="footer1" TagPrefix="aa10" %>
<%@ Register Src="usercontrols/footer2.ascx" TagName="footer2" TagPrefix="aa11" %>
<%@ Register Src="usercontrols/BottomContent.ascx" TagName="Bottomcontent" TagPrefix="bcon" %>
<%@ Register Src="usercontrols/BottomMidContent.ascx" TagName="Contentmid" TagPrefix="bcm" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="AjaxToolkit"%>
<%@ Register Src="usercontrols/CheckPostLeftMenu.ascx" TagName="leftcheckpost" TagPrefix="lcp" %>
<%@ Register Src="usercontrols/SearchNew.ascx" TagName="SearchNew" TagPrefix="New" %>
<%@ Register Src="usercontrols/small_logo.ascx" TagName="logo" TagPrefix="S_logo" %>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<%--<title>:: Justcalluz :: Home page</title>--%>
<title>Justcalluz | Find Events in your city | we provide updated information on all your local search</title>
<meta name='description' content='Event in your city,Event Management'/>
<meta name='keywords' content='Justcalluz, Event in your city,Event Management, yellow pages, online yellow pages, yellow pages india, India trade directory,  yellow pages directory, city yellow pages, indian search engine, JustCalluz customer care, JustCalluz customer support' />
<link href="css/style.css" rel="stylesheet" type="text/css" />
<link href="css/inner_style.css" rel="Stylesheet" type="text/css" />
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
<div class="content" style="padding:0; margin:0;">
<!-- start the inner left-->
<div class="content_innerleft">
<div class="contentbox_top">My Postings</div>
<div class="contentbox_mid">
<lcp:leftcheckpost ID="leftcheckpost" runat="server" />
</div>
<div class="contentbox_bottam"></div>
</div>
  <div class="content_innermid" style="width:79%;">
  <div class="searchmid_box">
  <div class="searchmid_boxtop1"><a href="Default.aspx" style="text-decoration:none;color:White">
      Home</a>&gt;&gt;
  <a id="lnkBtnTocheckPostings" runat="server" onserverclick="lnkBtnTocheckPostings_Click" style="color:White;">My Postings</a>&gt;&gt;My Events</div>
  <div class="searchmid_boxmid1">
  <table width="100%" border="0">
    <tr><td align="center">
    <asp:DataList ID="vieweventdl" DataKeyField="id" runat="server" Width="100%" 
            onitemdatabound="vieweventdl_ItemDataBound">
  <HeaderTemplate>
  </HeaderTemplate>
  <ItemTemplate>
 <table width="100%" cellpadding="0px" cellspacing="0px">
 <tr>
  <td style=" padding:10px;">
<table cellpadding="0Px" cellspacing="0px" width="100%" align="center" border="1">
   <tr>
    <td valign="top" width="100%">
      <div style="padding: 0px; margin: 0px;">
       <table width="100%" border="0">
        <tr>
           <td width="15%" rowspan="3" style="padding:10px 10px 10px 10px;" valign="middle" id="tdlogo" runat="server">
           <asp:Label ID="lblImgName" runat="server" Text='<%# Eval("ImageName") %>' Visible="false"></asp:Label>
            <asp:Image ID="imglogo" AlternateText="CompanyLogo" runat="server" ImageUrl='<%# Eval("ImageName", "../Event_Images\\{0}") %>' Width="98" Height="68" />
            </td>
            <td width="63%" class="headings" align="left" style="padding-left:5px; height:30px;">
               <%--<asp:HyperLink ID="Hypcmpname" runat="server" ForeColor="Red" Text='<%# Eval("event_name") %>' 
                      NavigateUrl='<%# string.Format("eventdetails.aspx?id="+ Eval("id").ToString() + "&cname=events") %>'></asp:HyperLink>--%>          
               <asp:HyperLink ID="Hypcmpname" runat="server" ForeColor="Red" Text='<%# Eval("event_name") %>' 
                      NavigateUrl='<%# GetCompUrl(Eval("id")) %>'></asp:HyperLink>
            </td> 
            <td align="right" style="padding-right:5px;"><span class="mid_menu">Status&nbsp;:</span>
              <asp:Label ID="lblstatus" runat="server" Visible="true" Text='<%#Eval("ApprovedStatus") %>' 
                  CssClass="sub_menu"></asp:Label></strong>
            </td>  
       </tr>
      <tr>
          <td align="left" colspan="2" style="padding-left:5px; height:30px;"><strong>Venue&nbsp;:&nbsp;</strong><span class="side_menu">
          <asp:Literal ID="Literal2" runat="server" Text='<%#Eval("event_place")%>' /></span></td>
       </tr>
       <tr>
         <td align="left" colspan="2" style="padding-left:5px; height:30px;" class="side_menu"><asp:Literal ID="Literal3" runat="server" Text='<%#Eval("event_desc")%>' /></td>
       </tr>
       <tr>
         <td colspan="6" align="right" class="side_menu" style="padding-right:5px;">
           <%--<asp:HyperLink ID="editbtn" runat="server" Text=" Edit " Font-Size="11px" NavigateUrl='<%# String.Format("edit_events.aspx?id="+ Eval("id").ToString() + "&cname=events") %>'></asp:HyperLink>--%>
           <asp:HyperLink ID="editbtn" runat="server" Text=" Edit " Font-Size="11px" NavigateUrl='<%# GetEditUrl(Eval("id")) %>'></asp:HyperLink>
            &nbsp;&nbsp;&nbsp;
           <asp:HyperLink ID="details" runat="server" Text="View Details" Font-Size="11px" NavigateUrl='<%# GetCompUrl(Eval("id"))%>'></asp:HyperLink>
         </td>
       </tr>
      </table>           
      </div>
    </td>
   </tr>
</table>
</td>
</tr>
</table>
<%--<AjaxToolkit:ModalPopupExtender ID="ModalPopupExtender1" runat="server" TargetControlID="friend" BackgroundCssClass="modalbackground" PopupControlID="friendpanel" CancelControlID="cancelbutton" OkControlID="x1" DropShadow="false" PopupDragHandleControlID="panel1">
</AjaxToolkit:ModalPopupExtender>--%>
 </ItemTemplate>
<FooterTemplate>
</FooterTemplate>
</asp:DataList>
 <table border="0" width="100%" id="trpagesize" runat="server">
     <tr>
      <td align="right" style="padding-right:13px;">
        <asp:ImageButton ID="imgPrevious" runat="server" AlternateText="btnPrevious" ImageUrl="images/arrow_2.png" OnClick="imgPrevious_Click"/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:ImageButton ID="imgNext" runat="server" AlternateText="btnNext" ImageUrl="images/arrow_1.png" OnClick="imgNext_Click" />
      </td>
     </tr>
 </table>
</td></tr>
</table>
</div>
 <div class="searchmid_boxbottam1"></div>
 </div>
 </div>

<!-- end of the mid Box-->
</div>
<div class="content_midbootam" >
<bcm:Contentmid ID="contentmid" runat="server" />
</div>

<div class="content_bootam_center">
<bcon:Bottomcontent ID="bottomcontent" runat="server" />
</div>

<div class="footer" align="center">
<aa10:footer1 ID="sdsa" runat="server" />
<aa11:footer2 ID="poshv" runat="server" />
</div>

</div>
    </form>
</body>
</html>
