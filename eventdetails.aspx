<%@ Page Language="C#" AutoEventWireup="true" CodeFile="eventdetails.aspx.cs" Inherits="Event_details" %>
<%@ Register Src="usercontrols/eventleft.ascx" TagName="leftevent" TagPrefix="el" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="AjaxToolkit"%>
<%@ Register Src="usercontrols/SponsoredLinks.ascx" TagName="eventright" TagPrefix="ever" %>
<%@ Register Src="usercontrols/footer1.ascx" TagName="footer1" TagPrefix="aa10" %>
<%@ Register Src="usercontrols/footer2.ascx" TagName="footer2" TagPrefix="aa11" %>
<%@ Register Src="usercontrols/catageories.ascx" TagName="catag" TagPrefix="aa6" %>
<%@ Register Src="usercontrols/signin.ascx" TagName="signin" TagPrefix="sig" %>
<%@ Register Src="usercontrols/BottomContent.ascx" TagName="bottomcontent" TagPrefix="aa4" %>
<%@ Register Src="usercontrols/BottomMidContent.ascx" TagName="bottomMidcontent" TagPrefix="aa5" %>
<%@ Register Src="usercontrols/SearchNew.ascx" TagName="SearchNew" TagPrefix="New" %>
<%@ Register Src="usercontrols/small_logo.ascx" TagName="logo" TagPrefix="S_logo" %>
<%@ Register Src="usercontrols/rightsearch.ascx" TagName="rightsrch" TagPrefix="rsearch" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<%--<title>:: Justcalluz :: Events Details page</title>--%>
<title>Justcalluz | Find Events in your city | we provide updated information on all your local search</title>
<meta name='description' content='Event in your city,Event Management'/>
<meta name='keywords' content='Justcalluz, Event in your city,Event Management, yellow pages, online yellow pages, yellow pages india, India trade directory,  yellow pages directory, city yellow pages, indian search engine, JustCalluz customer care, JustCalluz customer support' />
<link href="css/style.css" rel="Stylesheet" type="text/css" />
<link href="includes/style.css" rel="Stylesheet" type="text/css" />
<link href="css/inner_style.css" rel="Stylesheet" type="text/css" />
</head>
<body>
  <form id="form1" runat="server">
  <script type="text/javascript">
      function Alphabets(nkey) {
          var keyval
          if (navigator.appName == "Microsoft Internet Explorer") {
              keyval = window.event.keyCode;
          }
          else if (navigator.appName == 'Netscape') {
              nkeycode = nkey.which;
              keyval = nkeycode;
          }
          //For A-Z
          if (keyval >= 65 && keyval <= 90) {
              return true;
          }
          //For a-z
          else if (keyval >= 97 && keyval <= 122) {
              return true;
          }
          //For Backspace
          else if (keyval == 8) {
              return true;
          }
          //For General
          else if (keyval == 0) {
              return true;
          }
          //For Space
          else if (keyval == 32) {
              return true;
          }
          else {
              return false;
          }
      } // End of the function
  
 </script>
 <script type="text/javascript">
     function onlyNos(e, t) {
         try {
             if (window.event) {
                 var charCode = window.event.keyCode;
             }
             else if (e) {
                 var charCode = e.which;
             }
             else { return true; }
             if (charCode > 31 && (charCode < 48 || charCode > 57)) {
                 return false;
             }
             return true;
         }
         catch (err) {
             alert(err.Description);
         }
     }
        </script>
  <asp:ScriptManager ID="ScriptManager1" runat="server">
  </asp:ScriptManager>
<div class="layout">
<div class="signin">
<sig:signin ID="sig1" runat="server" />
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
       Font-Underline="false" ForeColor="White"></asp:HyperLink>&gt;&gt;Events</div>
  <div class="contentmid_boxmid">
  <table width="100%" border="0">
  <tr>
    <td width="48%" height="30" align="right" class="headings" style="padding-right:5px;">
        Result for</td>
    <td width="1%"><font color="#000000"><strong>:</strong></font></td>
    <td width="51%"><font color="#006393" class="side_menu">Events</font></td>
  </tr>
  <tr>
    <td colspan="3" style="background:url(images/events-search.png) no-repeat" valign="top" >
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
              <td width="29%"><asp:TextBox ID="txtfrom" runat="server"></asp:TextBox></td>
              <td width="6%" class="headings1" align="center"><span style="padding-left:10px; padding-top:10px;">
                  To</span></td>
              <td width="29%"><asp:TextBox ID="txtto" runat="server"></asp:TextBox></td>
              <td width="23%" style="padding-left:5px;"><asp:ImageButton ID="go" runat="server" 
                      ImageUrl="images/go.png" AlternateText="imageGo" onclick="go_Click" /></td>
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
       <tr>
        <td colspan="3" align="right" style="padding-right:3px;">
        <asp:HyperLink ID="post" runat="server" Text="Post Your Event" Font-Underline="false" Font-Size="11px" NavigateUrl="<%$RouteUrl:RouteName=postEvent,cname=events%>" CssClass="side_menu" Font-Bold="true" ForeColor="Red" ></asp:HyperLink></td>
       </tr>
      <%--</table>--%>
      <AjaxToolkit:CalendarExtender Animated="true" ID="CalendarExtender1" runat="server" TargetControlID="txtfrom"></AjaxToolkit:CalendarExtender>
      <AjaxToolkit:CalendarExtender Animated="true" ID="CalendarExtender3" runat="server" TargetControlID="txtto"></AjaxToolkit:CalendarExtender>
  <tr><td colspan="3">
  <asp:Panel ID="panel1" runat="server">
  <asp:DataList ID="DataList1" runat="server" Width="520px" 
          OnItemDataBound="DataList1_ItemDataBound">
    <HeaderTemplate>
    </HeaderTemplate>
    <ItemTemplate>
  <tr>
    <td colspan="3" style="background:url(images/event_send.png) no-repeat" height="50">
    <table width="100%" border="0">
  <tr>
    <td width="14%" height="40">&nbsp;</td>
    <td width="86%" class="side_menu">
      <font>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="evename" runat="server" Text ='<%# Eval("event_name") %>'></asp:Label>
        &nbsp;At&nbsp;<asp:Label ID="eveplace" runat="server" Text ='<%# Eval("event_place") %>'></asp:Label></font>
   </td>
  </tr>
</table>
</td>
  </tr>
  <tr>
    <td colspan="3" style="padding:6px;">
    <table width="100%" border="0">
  <tr>
    <td width="65%" align="left"><span class="mid_menu"></td>
    <td width="35%" rowspan="5" style="padding-bottom:8px;">
    <asp:Image  ID="imgReviewer" AlternateText="images" runat="server"  ImageUrl='<%# Eval("ImageName", "../Event_Images\\{0}") %>'   Width="99"  Height="68"/></td>
  </tr>
  <tr>
    <td><hr/></td>
    </tr>
  <tr>
    <td height="20" style="padding-top:5px;"><span class="mid_menu" >Date &amp; Timings</span><br/>
      <span class="mid1_menu"><font color="#000000"><asp:Label ID="lblstart" runat="server" Text='<%#Eval("event_startdate")%>'></asp:Label>
        &nbsp;-&nbsp;<asp:Label ID="enddate" runat="server" Text='<%#Eval("event_enddate")%>'></asp:Label></font></span><br/>
      <span class="mid1_menu"><font color="#000000"><%#DataBinder.Eval(Container.DataItem, "event_time")%></font></span></td>
    </tr>
  <tr>
    <td><hr/></td>
    </tr>
  <tr>
    <td style="padding-top:5px; height:20;"><span class="mid_menu">Description</span><br/>

      <span class="mid1_menu"><font color="#000000" >
                 <%#DataBinder.Eval(Container.DataItem, "event_desc")%>
                </font></span>
    </td>
  </tr>
  <tr>
    <td colspan="2" align="right" style="padding-right:40px;" class="sub_menu">
     <asp:HyperLink ID="friend" runat="server" Text="Share with your friend" CssClass="pointer"></asp:HyperLink>
     &nbsp;&nbsp;&nbsp;
    <asp:ImageButton ID="sendmailsms" AlternateText="btnmail" runat="server" ImageUrl="images/send-_button.png" /></td>
    </tr>
</table>
</td>
  </tr>
  <tr>
    <td colspan="3" style="padding:6px;"><hr/></td>
  </tr>
  <tr>
    <td colspan="3" style="padding:8px;"></td>
  </tr>
  <tr>
    <td colspan="3">
     <table width="100%" border="0" bgcolor="#FFEEE1">
      <tr>
        <td width="6%" class="mid_menu" height="25">
        <asp:Label ID="ven" runat="server" Text="Venue"></asp:Label></td>
     </tr>
    </table>
   </td>
  </tr>
  <tr>
    <td>
    <span class="side_menu" style="padding-left:5px;">
    <%#DataBinder.Eval(Container.DataItem, "address")%><br />
    <span style="padding-top:5px; padding-left:5px">
    <asp:Label ID="mark" runat="server" Text="LandMark" CssClass="mid_menu"></asp:Label></span><br />
    <%#DataBinder.Eval(Container.DataItem, "land_mark")%><br />
   <hr/>
   <asp:Label ID="det" runat="server" Text="Contact Details" CssClass="mid_menu"></asp:Label><br />
    <%#DataBinder.Eval(Container.DataItem, "contact_person")%><br /><br />
    <img src="images/phone3.jpg" alt="imgPhone" />
    <%#DataBinder.Eval(Container.DataItem, "mob")%><br />
    <img src="images/phone2.jpg" alt="imgPhone2" />
    <%#DataBinder.Eval(Container.DataItem, "landphno")%><br />
    <asp:Image ID="mail" runat="server" ImageUrl="images/mail1.png" AlternateText="imgMail" />
    <%#DataBinder.Eval(Container.DataItem, "emailid")%><br /><br />
        Fax&nbsp;&nbsp;&nbsp;&nbsp;
    <%#DataBinder.Eval(Container.DataItem, "fax")%><br /><br />
    <hr />
    </span>
   <tr>
   <td>
     <asp:Label ID="charge" runat="server" Text="Charges applied" Visible="false"></asp:Label>
     <span class="side_menu" style="padding-top:10px;">web site :</span>
      <%#DataBinder.Eval(Container.DataItem, "Website")%> 
    </td>
  </tr>
  </tr>
  <tr>
    <td height="30" colspan="3" class="mid_menu" >&nbsp;</td>
  </tr>
  <tr>
    <td colspan="3" >&nbsp;</td>
  </tr>
  <tr>
   <td align="right">
   <asp:HyperLink ID="lnkmap" runat="server" Text="View Map" ForeColor="#003366" Font-Bold="true" Font-Size="Medium"></asp:HyperLink>
     </td>
 </tr>
  <tr>
    <td colspan="3">&nbsp;</td>
  </tr>
          <AjaxToolkit:ModalPopupExtender ID="ModalPopupExtender1" runat="server" TargetControlID="sendmailsms" BackgroundCssClass="modalbackground" PopupControlID="mailpanel" OkControlID="cancelbtn" DropShadow="false" PopupDragHandleControlID="panel1">
          </AjaxToolkit:ModalPopupExtender>
          <AjaxToolkit:ModalPopupExtender ID="ModalPopupExtender2" runat="server" TargetControlID="friend" BackgroundCssClass="modalbackground" PopupControlID="friendpanel" OkControlID="btncancel" DropShadow="false" PopupDragHandleControlID="panel1">
          </AjaxToolkit:ModalPopupExtender>
           <AjaxToolkit:ModalPopupExtender ID="ModalPopupExtender3" runat="server" TargetControlID="lnkmap" BackgroundCssClass="modalbackground" PopupControlID="pnlmap" DropShadow="false" CancelControlID="cancel">
          </AjaxToolkit:ModalPopupExtender>
   </ItemTemplate>
 </asp:DataList>
  <asp:Panel ID="pnlmap" runat="server">
 <fieldset>
 <asp:DataList ID="dlmap" runat="server" DataKeyField="id">
 <ItemTemplate>
 
 <table border="0">

 
 <tr>
  <td width="40%" class="bottam"><strong class="side_menu">
        <%#DataBinder.Eval(Container.DataItem, "map")%>
        </strong></td>
        
        
 </tr>
 </table>
 </ItemTemplate>
 </asp:DataList>
     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
 <asp:Button ID="cancel" runat="server" Text="Close" />
 </fieldset></asp:Panel>
  <asp:DataList ID="ddlevents" DataKeyField="id" runat="server" Width="100%">
    <HeaderTemplate>
    </HeaderTemplate>
    <ItemTemplate>
     <table width="100%" border="0">
       <tr>
      <td valign="top"  style="background:url(images/event_send03.png) no-repeat top; height:200px">
        <table width="100%" border="0">
            <tr>
             <td width="60%" class="headings" style="padding-left:5px; height:30px;">
                     <%--<asp:HyperLink ID="Hypcmpname" runat="server" ForeColor="Red" Text='<%# Eval("event_name") %>' 
                       NavigateUrl='<%# string.Format("eventdetails.aspx?id="+ Eval("id").ToString() + "&cname=events") %>'></asp:HyperLink>--%>
                       <asp:HyperLink ID="Hypcmpname" runat="server" ForeColor="Red" Text='<%# Eval("event_name") %>' 
                       NavigateUrl='<%# GetCompUrl(Eval("id")) %>'></asp:HyperLink>
             </td> 
               <td colspan="2" align="right" style="padding-right:10px;" class="sub_menu">
              <%-- <a id="friend1" runat="server" onserverclick="friend1_Click">Share with your friend</a>--%>
              <asp:HyperLink ID="friend1" runat="server" Text="Share with your friend"></asp:HyperLink>
              </td>
           </tr>
           <tr>
            <td colspan="15" height="20" style="padding-left:5px" class="side_menu">
             <table border="0" width="100%">
              <tr>
               <td width="23%" rowspan="3" align="left" style="padding-bottom:20px;">
                <asp:Image  ID="imgReviewer" AlternateText="imags" runat="server"  ImageUrl='<%# Eval("ImageName", "../Event_Images\\{0}") %>'  Width="99"  Height="68"/>
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
                    <td colspan="8" align="right" style="padding-right:10px;">
                    <asp:HyperLink ID="details" runat="server" Text="View Details" Font-Size="11px" NavigateUrl='<%# GetCompUrl(Eval("id")) %>' ForeColor="Brown" ></asp:HyperLink>
                    </td>
                    </tr>
                    </table>
                   
                    </td>
                    </tr>
                    </table>
                    
                    </td>
                    </tr>
                <AjaxToolkit:ModalPopupExtender ID="ModalPopupExtender4" runat="server" TargetControlID="friend1" BackgroundCssClass="modalbackground" PopupControlID="friendpanel1" OkControlID="btnFcancel" DropShadow="false" PopupDragHandleControlID="panel1">
         </AjaxToolkit:ModalPopupExtender>
           </table>  
      </td>
    </tr>
     </table>
     </ItemTemplate>
     <FooterTemplate>
     </FooterTemplate>
  </asp:DataList>
</asp:Panel>
<%-- <input id="btnDummy" runat="server" type="button" style="display:none;" />
         <AjaxToolkit:ModalPopupExtender ID="ModalPopupExtender4" runat="server" TargetControlID="btnDummy" BackgroundCssClass="modalbackground" PopupControlID="friendpanel" OkControlID="btncancel" DropShadow="false" PopupDragHandleControlID="panel1">
         </AjaxToolkit:ModalPopupExtender>--%>
 <table>
  <tr>
  <td align="center" colspan="5"><asp:Label ID="lblmsg" runat="server" Text="No result found" Font-Bold="true" ForeColor="Maroon" Font-Size="Large"></asp:Label></td>
  </tr></table>
<asp:Panel ID="friendpanel" runat="server" Width="350px">
<div class="dilogbox">
<table width="350px">
<tr>
<td align="center" valign="top" 
        
        style="font-family:Arial; font-size:large; color:#003366; padding-top: 5px;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Share with your friend
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
   <asp:ImageButton ID="btncancel" ImageUrl="images/panel/cencel.png" width="21" height="22" runat="server" AlternateText="imgbtnCancel"/></td>
</tr>
<tr>
  <td height="184">
     <table align="center" style="height: 170px;">
      <tr>
        <td colspan="3" style="padding-left:5px;">
         <asp:Label ID="Label1" runat="server" Text="Tell your friend about this site ." ForeColor="#003366" ></asp:Label></td>
      </tr>
      <tr>
        <td align="right"><span class="star">*</span><asp:Label ID="Label2" runat="server" Text="Your Name" ForeColor="Black" Font-Bold="false" ></asp:Label></td>
        <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
        <td>
         <asp:TextBox ID="txtname" runat="server" validationgroup="modal" Width="160px" Height="25px" onkeypress="return Alphabets(event);"></asp:TextBox>
          <asp:RequiredFieldValidator ID="rfvtxtname" runat="server" 
                ErrorMessage="please enter your name" ControlToValidate="txtname"  validationgroup="share">*</asp:RequiredFieldValidator></td>
      </tr>
      <tr>
        <td align="right"><span class="star">*</span><asp:Label ID="Label3" runat="server" Text="Your's Friend Name" ForeColor="Black" Font-Bold="false" ></asp:Label></td>
        <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
        <td>
        <asp:TextBox ID="txtfname" runat="server" validationgroup="modal" Width="160px" Height="25px" onkeypress="return Alphabets(event);"></asp:TextBox>
          <asp:RequiredFieldValidator ID="rfvtxtfname" runat="server" 
               ErrorMessage="please enter your friend's name" ControlToValidate="txtfname"  
                    validationgroup="share">*</asp:RequiredFieldValidator></td>
      </tr>
       <tr>
        <td align="right"><span class="star">*</span><asp:Label ID="Label8" runat="server" Text="Your Friend's Mobile_No" ForeColor="Black" Font-Bold="false" ></asp:Label>
        </td>
        <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
        <td>
        <asp:TextBox ID="txtmob" runat="server" validationgroup="modal" Width="160px" Height="25px" MaxLength="11" onkeypress="return onlyNos(event,this);"></asp:TextBox>
          <asp:RegularExpressionValidator ID="revtxtmob" runat="server" 
         ControlToValidate="txtmob" ErrorMessage="Only numbers are allowed for mobile" 
          ValidationExpression="^[01]?[- .]?(\([1-9]\d{2}\)|[1-9]\d{2})[- .]?\d{3}[- .]?\d{4}$" validationgroup="share">*</asp:RegularExpressionValidator>
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
        <td align="right"><span class="star">*</span><asp:Label ID="Label4" runat="server" Text="Your Friend's Email_Id" ForeColor="Black" Font-Bold="false" ></asp:Label>
         <asp:Label ID="lblerror" runat="server"></asp:Label>
        </td>
        <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
        <td>
        <asp:TextBox ID="txtFEmail" runat="server" validationgroup="modal" Width="160px" Height="25px"></asp:TextBox>
          <asp:RequiredFieldValidator ID="rfvtxtFEmail" runat="server" ControlToValidate="txtFEmail" 
           ErrorMessage="please enter Email id"  validationgroup="share">*</asp:RequiredFieldValidator>
          <asp:RegularExpressionValidator ID="revtxtFEmail" runat="server" 
           ErrorMessage="Incorrect Format of email address" 
           ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
           validationgroup="share" ControlToValidate="txtFEmail" >*</asp:RegularExpressionValidator>
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
                validationgroup="share" ShowMessageBox="True" ShowSummary="False" />
         </td>
        </tr>
     </table>
 </td>
</tr>
<tr>
 <%-- <td width="241" height="37">&nbsp;</td>--%>
  <td align="right" style="padding:5px 10px 5px 5px;">
  <asp:ImageButton ID="imggo" OnClick="imggo_Click" AlternateText="btnGo" ImageUrl="images/panel/dialog_buttan.png" width="98" height="35" runat="server" ValidationGroup="share"/>
  </td>
</tr>
</table>
</div>
</asp:Panel>&nbsp;
<asp:Panel ID="friendpanel1" runat="server" Width="350px">
<div class="dilogbox">
<table width="350px">
<tr>
<td align="center" valign="top" 
        
        style="font-family:Arial; font-size:large; color:#003366; padding-top: 5px;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Share with your friend
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
   <asp:ImageButton ID="btnFcancel" ImageUrl="images/panel/cencel.png" width="21" height="22" runat="server" AlternateText="imgbtnCancel"/></td>
</tr>
<tr>
  <td height="184">
     <table align="center" style="height: 170px;">
      <tr>
        <td colspan="3" style="padding-left:5px;">
         <asp:Label ID="Label5" runat="server" Text="Tell your friend about this site ." ForeColor="#003366" ></asp:Label></td>
      </tr>
      <tr>
        <td align="right"><span class="star">*</span><asp:Label ID="Label10" runat="server" Text="Your Name" ForeColor="Black" Font-Bold="false" ></asp:Label></td>
        <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
        <td>
         <asp:TextBox ID="txtSName1" runat="server" validationgroup="modal" Width="160px" Height="25px" onkeypress="return Alphabets(event);"></asp:TextBox>
          <asp:RequiredFieldValidator ID="rfvtxtSName1" runat="server" 
                ErrorMessage="please enter your name" ControlToValidate="txtSName1"  validationgroup="share">*</asp:RequiredFieldValidator></td>
      </tr>
      <tr>
        <td align="right"><span class="star">*</span><asp:Label ID="Label11" runat="server" Text="Your's Friend Name" ForeColor="Black" Font-Bold="false" ></asp:Label></td>
        <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
        <td>
        <asp:TextBox ID="txtSFName1" runat="server" validationgroup="modal" Width="160px" Height="25px" onkeypress="return Alphabets(event);"></asp:TextBox>
          <asp:RequiredFieldValidator ID="rfvtxtSFName1" runat="server" 
               ErrorMessage="please enter your friend's name" ControlToValidate="txtSFName1"  
                    validationgroup="share">*</asp:RequiredFieldValidator></td>
      </tr>
       <tr>
        <td align="right"><span class="star">*</span><asp:Label ID="Label12" runat="server" Text="Your Friend's Mobile_No" ForeColor="Black" Font-Bold="false" ></asp:Label>
        </td>
        <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
        <td>
        <asp:TextBox ID="txtSMobile1" runat="server" validationgroup="modal" Width="160px" Height="25px" MaxLength="11" onkeypress="return onlyNos(event,this);"></asp:TextBox>
          <asp:RegularExpressionValidator ID="revtxtSMobile1" runat="server" 
         ControlToValidate="txtSMobile1" ErrorMessage="Only numbers are allowed for mobile" 
          ValidationExpression="^[01]?[- .]?(\([1-9]\d{2}\)|[1-9]\d{2})[- .]?\d{3}[- .]?\d{4}$" validationgroup="share">*</asp:RegularExpressionValidator>
          <asp:RequiredFieldValidator ID="rfvtxtSMobile1" runat="server" 
             ErrorMessage="Please enter contact number" ControlToValidate="txtSMobile1"  
                    validationgroup="share">*</asp:RequiredFieldValidator>
          <asp:RangeValidator ID="rgvtxtSMobile1" runat="server" 
              ErrorMessage=" Mobile Number must start with 0" ControlToValidate="txtSMobile1"  
                    MaximumValue="1" MinimumValue="0" 
               validationgroup="share">*</asp:RangeValidator>
       </td>
      </tr>
      <tr>
        <td align="right"><span class="star">*</span><asp:Label ID="Label13" runat="server" Text="Your Friend's Email_Id" ForeColor="Black" Font-Bold="false" ></asp:Label>
         <asp:Label ID="Label14" runat="server"></asp:Label>
        </td>
        <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
        <td>
        <asp:TextBox ID="txtSEmail1" runat="server" validationgroup="modal" Width="160px" Height="25px"></asp:TextBox>
          <asp:RequiredFieldValidator ID="rfvtxtSEmail1" runat="server" ControlToValidate="txtSEmail1" 
           ErrorMessage="please enter Email id"  validationgroup="share">*</asp:RequiredFieldValidator>
          <asp:RegularExpressionValidator ID="revtxtSEmail1" runat="server" 
           ErrorMessage="Incorrect Format of email address" 
           ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
           validationgroup="share" ControlToValidate="txtSEmail1" >*</asp:RegularExpressionValidator>
            <asp:ValidationSummary ID="ValidationSummary3" runat="server" 
                validationgroup="share" ShowMessageBox="True" ShowSummary="False" />
         </td>
        </tr>
     </table>
 </td>
</tr>
<tr>
  <td align="right" style="padding:5px 10px 5px 5px;">
  <asp:ImageButton ID="imgeGo" OnClick="imgeGo_Click" AlternateText="btnGo" ImageUrl="images/panel/dialog_buttan.png" width="98" height="35" runat="server" ValidationGroup="share"/>
  </td>
</tr>
</table>
</div>
</asp:Panel>&nbsp;
<asp:Panel ID="mailpanel" runat="server" Width="350px">
 <div class="dilogbox">
  <table width="350px">
    <tr>
      <td colspan="2" align="center" valign="top" 
        style="font-family:Arial; font-size:large; color:#003366; padding-top:5px;">Get Information by sms/email
        &nbsp;&nbsp;&nbsp;
      <asp:ImageButton ID="cancelbtn" ImageUrl="images/panel/cencel.png" AlternateText="btnCancel" width="21" height="22" runat="server"/></td>
   </tr>
   <tr><td>&nbsp;</td></tr>
   <tr>
   <td height="170" colspan="2">
    <table align="center" width="400px" style="height: 154px;">
     <tr style="margin-left:5px">
       <td align="right">
       <span class="star">*</span>
        <asp:Label ID="Label6" runat="server" Text="Name" Font-Bold="false" ForeColor="Black" ></asp:Label>
        </td>
        <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
       <td>
        <asp:TextBox ID="txtname1" runat="server" ValidationGroup="modal" Width="160px" Height="25px" onkeypress="return Alphabets(event);"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvtxtname1" runat="server" 
            ControlToValidate="txtname1" ErrorMessage="Enter Name" 
            ValidationGroup="sendmail">*</asp:RequiredFieldValidator>
     </td>
     </tr>
     <tr>
        <td align="right">
        <span class="star">*</span>
            <asp:Label ID="Label9" runat="server" Text="Mobile_No" ForeColor="Black" Font-Bold="false" ></asp:Label>
        </td>
         <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
        <td>
            <asp:TextBox ID="txtmob1" runat="server" ValidationGroup="sendmail" Width="160px" Height="25px" MaxLength="11" onkeypress="return onlyNos(event,this);"></asp:TextBox>
         <asp:RegularExpressionValidator ID="revtxtmob1" runat="server" 
            ControlToValidate="txtmob1" ErrorMessage="Only numbers are allowed for mobile" 
            ValidationExpression="^[01]?[- .]?(\([1-9]\d{2}\)|[1-9]\d{2})[- .]?\d{3}[- .]?\d{4}$" ValidationGroup="sendmail">*</asp:RegularExpressionValidator>
         <asp:RequiredFieldValidator ID="rfvtxtmob1" runat="server" 
            ErrorMessage="Please enter contact number" ControlToValidate="txtmob1"  
            ValidationGroup="sendmail">*</asp:RequiredFieldValidator>
        <asp:RangeValidator ID="rgvtxtmob1" runat="server" 
            ErrorMessage=" Mobile Number must start with 0" ControlToValidate="txtmob1"  
            MaximumValue="1" MinimumValue="0" 
            ValidationGroup="sendmail">*</asp:RangeValidator>
        </td>
      </tr>
      <tr>
        <td align="right">
        <span class="star">*</span>
            <asp:Label ID="Label7" runat="server" Text="Email_Id" ForeColor="Black" Font-Bold="false" ></asp:Label>
        </td>
        <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
        <td>
            <asp:TextBox ID="txtSEmail" runat="server" ValidationGroup="modal" Width="160px" Height="25px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvtxtSEmail" runat="server" ControlToValidate="txtSEmail" 
            ErrorMessage="please enter Email id"  ValidationGroup="sendmail">*</asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="revtxtSEmail" runat="server" 
            ErrorMessage="Incorrect Format of email address" 
            ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
            ValidationGroup="sendmail" ControlToValidate="txtSEmail" >*</asp:RegularExpressionValidator>
             <asp:ValidationSummary ID="ValidationSummary2" runat="server" 
              ValidationGroup="sendmail" ShowMessageBox="True" ShowSummary="False" />
        </td>
     </tr>
    </table>
    </td>
    </tr>
  <tr>
  <td width="241" height="37">&nbsp;</td>
  <td width="163" valign="top">
  <asp:ImageButton ID="imggo1" OnClick="imggo1_Click" AlternateText="btnGo" ImageUrl="images/panel/dialog_buttan.png" width="98" height="35" runat="server" ValidationGroup="sendmail"/>
  </td>
</tr>
    </table>
</div>
</asp:Panel>     
 </td>
      </tr>
  </table>
 </td></tr>
       </table>       
  </div>
  <div class="contentmid_boxbottam"></div>
</div>
 <!-- End of mid Box-->
 <!--Start of Right-->
<div class="content_innerright">
<div class="contentbox_top">Search By Cities</div>
<div class="contentbox_mid">
 <rsearch:rightsrch ID="rjobsearch" runat="server" />
</div>
<div class="contentbox_bottam"></div>
<div class="contentbox_top">Sponsor AdsAds</div>
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
