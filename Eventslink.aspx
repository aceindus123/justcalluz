<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Eventslink.aspx.cs" Inherits="Eventslink" %>
<%@ Register Src="usercontrols/eventleft.ascx" TagName="leftevent" TagPrefix="el" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="AjaxToolkit"%>
<%@ Register Src="usercontrols/SponsoredLinks.ascx" TagName="eventright" TagPrefix="ever" %>
<%@ Register Src="usercontrols/footer1.ascx" TagName="footer1" TagPrefix="aa10" %>
<%@ Register Src="usercontrols/footer2.ascx" TagName="footer2" TagPrefix="aa11" %>
<%@ Register Src="usercontrols/Search.ascx" TagName="catag" TagPrefix="aa6" %>
<%@ Register Src="usercontrols/signin.ascx" TagName="signin" TagPrefix="sig" %>
<%@ Register Src="usercontrols/topimage.ascx" TagName="topimage" TagPrefix="aa2" %>
<%@ Register Src="usercontrols/SearchNew.ascx" TagName="SearchNew" TagPrefix="New" %>
<%@ Register Src="usercontrols/small_logo.ascx" TagName="logo" TagPrefix="S_logo" %><%@ Register Src="usercontrols/BottomContent.ascx" TagName="bottomcontent" TagPrefix="aa4" %>
<%@ Register Src="usercontrols/BottomMidContent.ascx" TagName="bottomMidcontent" TagPrefix="aa5" %>
<%@ Register Src="usercontrols/rightsearch.ascx" TagName="rightsrch" TagPrefix="rsearch" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<%--<title>:: Justcalluz :: Home page</title>--%>
<title>Justcalluz | Find Events in your city | we provide updated information on all your local search</title>
<meta name='description' content='Event in your city,Event Management'/>
<meta name='keywords' content='Justcalluz, Event in your city,Event Management, yellow pages, online yellow pages, yellow pages india, India trade directory,  yellow pages directory, city yellow pages, indian search engine, JustCalluz customer care, JustCalluz customer support' />
<link href="css/style.css" rel="Stylesheet" type="text/css" />
<link href="css/inner_style.css" rel="Stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
</asp:ScriptManager>
<div class="layout">
 <div class="signin">   
<sig:signin ID="sig1" runat="server" />
</div>
<div class="header">
<%--<div class="header_top"></div>--%>
<div class="header_logo">
<S_logo:logo ID="logo" runat="server" /></div>
<div class="header_search">
 <New:SearchNew ID="New" runat="server" />
 </div>
 </div>
<div class="category_box">
 <aa6:catag ID="uye" runat="server" />
</div>
<div class="content" style="padding:0; margin:0;">
<div class="content_innerleft">
<div class="contentbox_top">Events</div>
<div class="contentbox_mid"> 
<!-- start the inner left-->
<el:leftevent ID="left" runat="server" />
</div>
<div class="contentbox_bottam"></div>
</div>
<!-- end of the inner left-->

<!-- start the mid Box-->
  <div class="content_innermid">
  <div class="contentmid_boxtop"><asp:HyperLink ID="hyplink" runat="server" NavigateUrl="<%$RouteUrl:RouteName=HomeRoute %>" Text="Home" 
       Font-Underline="false" ForeColor="White"></asp:HyperLink>&gt;&gt; Events</div>
  <div class="contentmid_boxmid">
  <table width="100%" border="0">
  <tr>
    <td width="48%" height="30" align="right" class="headings" style="padding-right:5px;">Result for</td>
    <td width="1%"><font color="#000000"><strong>:</strong></font></td>
    <td width="51%"><font color="#006393" class="side_menu">Events</font></td>
  </tr>
  <tr>
    <td colspan="3" style="background:url(images/events-search.png) no-repeat" valign="top">
   <table width="100%" border="0">
        <tr>
          <td colspan="2" rowspan="2" valign="top" ><table width="100%" border="0">
            <tr>
              <td height="20" colspan="4" class="sub_menu" style="padding-left:20px;">Choose A Date</td>
            </tr>
            <tr>
              <td width="13%" class="headings1" style="padding-left:40px;">From</td>
              <td width="29%" align="center"><asp:TextBox ID="txtfrom" runat="server"></asp:TextBox></td>
              <td width="6%" class="headings1" align="center"><span style="padding-left:10px; padding-top:10px;">To</span></td>
              <td width="29%"><asp:TextBox ID="txtto" runat="server"></asp:TextBox></td>
              <td width="23%" style="padding-left:5px;"><asp:ImageButton ID="go" runat="server" 
                      ImageUrl="images/go.png" onclick="go_Click" /></td>
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
      </table>
</td>
  </tr>
  <tr>
    <td colspan="3" align="right" style="padding-right:2px">
     <asp:HyperLink ID="post" runat="server" Text="Post Your Event" Font-Size="11px" NavigateUrl="<%$RouteUrl:RouteName=postEvent,cname=events %>" Font-Underline="false" CssClass="side_menu" Font-Bold="true" ForeColor="Red" ></asp:HyperLink></td>
 </tr>
  <asp:DataList ID="ddlevents" DataKeyField="id" runat="server" Width="100%">
          <HeaderTemplate>
        </HeaderTemplate>
          <ItemTemplate>
        <tr>
          <td valign="top"  style="background:url(images/event_send3.png) no-repeat top; width:536px; height:200px">
            <div style="padding: 0px; margin:0px">
               <table width="100%" border="0">
               <tr>
                    <td width="60%" class="headings" style="padding-left:5px; height:30px;">
                     <asp:HyperLink ID="Hypcmpname" runat="server" ForeColor="Red" Text='<%# Eval("event_name") %>' NavigateUrl='<%# GetCompUrl(Eval("id")) %>'></asp:HyperLink>
                    </td>  
                    <td colspan="2" align="right" style="padding-right:30px;" class="sub_menu">
                    <asp:HyperLink ID="friend" runat="server" Text="Share with your friend"></asp:HyperLink>
                    </td>
                 </tr>
                 <tr>
                    <td colspan="15" height="20" style="padding-left:5px" class="side_menu">
                                   
                    <table border="0" width="100%">
                    <tr><td width="23%" rowspan="3" align="left" style="padding-bottom:20px;">
                    <asp:Image  ID="imgReviewer" AlternateText="images" runat="server"  ImageUrl='<%# Eval("ImageName", "../Event_Images\\{0}") %>'  Width="99"  Height="68"/>
                    </td>
                    <td colspan="5">
                    <table border="0" width="100%">
                    <tr>
                    <td>
                    <asp:Label ID="lbladdress" runat="server" Text ='<%# Eval("address") %>'></asp:Label>
                    </td>
                    </tr>
                    <tr>
                    <td>
                    <asp:Label ID="lblcity" runat="server" Text ='<%# Eval("City") %>'></asp:Label>
                    </td>
                    </tr>
                    <tr>
                    <td>
                    <asp:Label ID="lblstate" runat="server" Text ='<%# Eval("State") %>'></asp:Label>
                    </td>
                    </tr>
                    <tr>
                    <td>
                    <asp:Label ID="lblpincode" runat="server" Text ='<%# Eval("Pincode") %>'></asp:Label>
                    </td>
                    </tr>
                    <tr>
                    <td>
                    <strong class="sub_menu">Contact</strong>&nbsp;<span class="side_menu">:</span><span class="side_menu"><asp:Label ID="lblmob" runat="server" Text ='<%# Eval("contact_person") %>'></asp:Label>&nbsp;|
                        <asp:Label ID="lbllandphone" runat="server" Text ='<%# Eval("mob") %>'></asp:Label></span>
                    </td>
                    </tr>
                    <tr>
                    <td>
                    <strong class="sub_menu">Venue</strong>&nbsp;<span class="side_menu">:</span><span class="side_menu"><asp:Literal ID="Literal2" runat="server" Text='<%#Eval("event_place")%>' /></span>
                    </td>
                    </tr>
                    <tr>
                    <td colspan="8" align="right">
                    <asp:HyperLink ID="details" runat="server" Text="View Details" Font-Size="11px" NavigateUrl='<%# GetCompUrl(Eval("id")) %>' ForeColor="Brown" ></asp:HyperLink>
                    </td>
                    </tr>
                    </table>
                   
                    </td>
                    </tr>
                    </table>
                    
                    </td>
                 </tr>
             </table>  
            </div>         
                </td>
            </tr>
           <AjaxToolkit:ModalPopupExtender ID="ModalPopupExtender1" runat="server" TargetControlID="friend" BackgroundCssClass="modalbackground" PopupControlID="friendpanel" OkControlID="cancel" DropShadow="false">
              </AjaxToolkit:ModalPopupExtender>
           </ItemTemplate>
          <FooterTemplate>
           
        </FooterTemplate>
        
        
        </asp:DataList>
        <tr><td>
     <table>
     <tr><td><asp:Label ID="lblmsg" runat="server"></asp:Label></td></tr>
     </table></td></tr>
     <tr>
     <td>
         <table border="0" width="100%" id="trpagesize" runat="server">
         <tr><td>&nbsp;</td></tr>
         <tr>
          <td align="right" style="padding-right:5px;">
            <asp:ImageButton ID="imgPrevious" runat="server" AlternateText="btnPrevious" ImageUrl="images/arrow_2.png" OnClick="imgPrevious_Click"/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:ImageButton ID="imgNext" runat="server" AlternateText="btnNext" ImageUrl="images/arrow_1.png" OnClick="imgNext_Click" />
          </td>
         </tr>
        </table>
     </td></tr>
    </table>
 
  <asp:Panel ID="friendpanel" runat="server" Width="350px">
<div class="dilogbox">
<table width="350px">
<tr>
<td colspan="3" align="center" valign="top" 
        style="font-family:Arial; font-size:large; color:#003366; padding-top:5px;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Share with your friend
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
   <asp:ImageButton ID="cancel" ImageUrl="../images/panel/cencel.png" width="21" AlternateText="imgbtnCancel" height="22" runat="server"/></td>
</tr>
<tr>
  <td height="184" colspan="3">
     <table align="center" style="height: 170px;">
      <tr>
        <td colspan="3" style="padding-left:5px;">
         <asp:Label ID="Label5" runat="server" Text="Tell your friend about this site ." ForeColor="#003366" ></asp:Label></td>
      </tr>
      <tr>
        <td align="right"><span class="star">*</span>
        <asp:Label ID="Label6" runat="server" Text="Your Name" ForeColor="Black" Font-Bold="false" ></asp:Label></td>
        <td><strong>&nbsp;:&nbsp;</strong></td>
        <td>
        <asp:TextBox ID="txtname1" runat="server" validationgroup="modal" Width="160px" Height="25px"></asp:TextBox>
          <asp:RequiredFieldValidator ID="rfvtxtname1" runat="server" 
                ErrorMessage="please enter your name" ControlToValidate="txtname1"  validationgroup="share">*</asp:RequiredFieldValidator></td>
      </tr>
      <tr>
        <td align="right"><span class="star">*</span>
        <asp:Label ID="Label7" runat="server" Text="Your's Friend Name" ForeColor="Black" Font-Bold="false" ></asp:Label></td>
        <td><strong>&nbsp;:&nbsp;</strong></td>
        <td>
        <asp:TextBox ID="txtfname" runat="server" validationgroup="modal" Width="160px" Height="25px"></asp:TextBox>
          <asp:RequiredFieldValidator ID="rfvtxtfname" runat="server" 
               ErrorMessage="please enter your friend's name" ControlToValidate="txtfname"  
                    validationgroup="share">*</asp:RequiredFieldValidator></td>
     </tr>
      <tr>
        <td align="right"><span class="star">*</span>
        <asp:Label ID="Label10" runat="server" Text="Your Friend's Mobile_No" ForeColor="Black" Font-Bold="false" ></asp:Label>          
       </td>
        <td><strong>&nbsp;:&nbsp;</strong></td>
        <td>
        <asp:TextBox ID="txtmob" runat="server" validationgroup="modal" Width="160px" Height="25px" MaxLength="11"></asp:TextBox>
          <asp:RegularExpressionValidator ID="revtxtmob" runat="server" 
         ControlToValidate="txtmob" ErrorMessage="Only numbers are allowed for mobile" 
          ValidationExpression="\d{11}" validationgroup="share">*</asp:RegularExpressionValidator>
          <asp:RequiredFieldValidator ID="rfvtxtmob" runat="server" 
             ErrorMessage="Please enter contact number" ControlToValidate="txtmob"  
                    validationgroup="share">*</asp:RequiredFieldValidator>
          <asp:RangeValidator ID="rgvtxtmob" runat="server" 
              ErrorMessage=" Mobile Number must start with 0" ControlToValidate="txtmob"  
                    MaximumValue="1" MinimumValue="0" 
               validationgroup="share">*</asp:RangeValidator>
       </td>
      </tr>
      <tr>
        <td align="right"><span class="star">*</span>
        <asp:Label ID="Label9" runat="server" Text="Your Friend's Email_Id" ForeColor="Black" Font-Bold="false" >
        </asp:Label>
        </td>
        <td><strong>&nbsp;:&nbsp;</strong></td>
        <td>
        <asp:TextBox ID="txtFEmail" runat="server" validationgroup="modal" Width="160px" Height="25px"></asp:TextBox>
          <asp:RequiredFieldValidator ID="rfvtxtFEmail" runat="server" ControlToValidate="txtFEmail" 
           ErrorMessage="please enter Email id"  validationgroup="share">*</asp:RequiredFieldValidator>
          <asp:RegularExpressionValidator ID="revtxtFEmail" runat="server" 
           ErrorMessage="Incorrect Format of email address" 
           ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
           validationgroup="share" ControlToValidate="txtFEmail" >*</asp:RegularExpressionValidator></td>
           <asp:ValidationSummary ID="ValidationSummary2" runat="server" 
                validationgroup="share" ShowMessageBox="True" ShowSummary="False" />
        </tr>
       </table>
     </td>
</tr>
<tr>
  <%--<td width="241" height="37">&nbsp;</td>--%>
  <td align="right" style="padding:5px 10px 5px 5px;">
  <asp:ImageButton ID="imggo" OnClick="imggo_Click" AlternateText="imgbtnGo" ImageUrl="../images/panel/dialog_buttan.png" width="98" height="35" runat="server" ValidationGroup="share"/></td></tr>
</table>
</div>
</asp:Panel>
        </div>
  <div class="contentmid_boxbottam"></div>
  </div>
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
<!-- begin the right -->
 <ever:eventright ID="eventright" runat="server" />    
 </td>
</tr>
</table>
<!--end of 3 column-->
</div>
  <div class="contentbox_bottam"></div>
</div>
</div>
<div class="content_midbootam" >
<aa5:bottomMidcontent ID="mid1" runat="server" />
</div>
<div class="content_bootam_center">
<aa4:bottomcontent ID="bottomcontent1" runat="server" />
</div>
<div class="footer" align="center"> 
<aa10:footer1 ID="footer" runat="server" />
<aa11:footer2 ID="ayh" runat="server" />
</div>
</div>

    </form>
</body>
</html>
