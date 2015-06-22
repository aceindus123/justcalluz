<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Discount_Details.aspx.cs" Inherits="Discount_Details" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="AjaxToolkit"%>
<%@ Register Src="usercontrols/signin.ascx" TagName="signin" TagPrefix="aa1" %>
<%@ Register Src="usercontrols/catageories.ascx" TagName="catag" TagPrefix="aa6" %>
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
<%--<title>:: Justcalluz :: Discount Details page</title>--%>
<title>Justcalluz | Find Discount and coupon code in your city | we provide updated information on all your local search</title>
<meta name='description' content='Discount rates,sale,Event Management'/>
<meta name='keywords' content='Justcalluz,Discount rates,sale,Event Management,online yellow pages, yellow pages india, India trade directory,  yellow pages directory, city yellow pages, indian search engine, JustCalluz customer care, JustCalluz customer support' />
<link href="css/style.css" rel="stylesheet" type="text/css" />
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
    <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePageMethods="true">
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
<div class="contentbox_top">Popular Search</div>
<div class="contentbox_mid"> 
<!-- start the inner left-->
<ldsc:leftdiscount id="Ldiscount" runat="server"></ldsc:leftdiscount>
<!-- end of the inner left-->
</div>
<div class="contentbox_bottam"></div>
</div>
<!-- start the mid Box-->
<div class="content_innermid">
<div class="contentmid_boxtop"><asp:HyperLink ID="hypDefault" runat="server" NavigateUrl="<%$RouteUrl:RouteName=HomeRoute%>" Text="Home" Font-Underline="false" ForeColor="White"></asp:HyperLink>
    &gt;&gt; Discounts</div>
<div class="contentmid_boxmid"><table width="100%" border="0">
<tr>
<td width="48%" height="30" align="right" class="headings" style="padding-right:5px;">
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
          ImageUrl="images/go.png" onclick="go_Click" AlternateText="imgbtnGo" /></td>
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
    <a id="weekbut" runat="server" onserverclick="tombut_Click">Tomorrow</a>
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
<td colspan="3" align="right" style="padding-right:3px">
   <%--<asp:HyperLink ID="post" runat="server" Text="Post Your Discount" Font-Size="11px" NavigateUrl="post_discount.aspx?cname=discounts" 
        CssClass="side_menu" Font-Bold="true" Font-Underline="false" ForeColor="Red" ></asp:HyperLink>--%>
      <asp:HyperLink ID="post" runat="server" Text="Post Your Discount" Font-Size="11px" NavigateUrl="<%$RouteUrl:RouteName=PostDiscount,cname=discounts%>" 
        CssClass="side_menu" Font-Bold="true" Font-Underline="false" ForeColor="Red" ></asp:HyperLink>
</td>
                                             
</tr>
<tr><td colspan="3">
    <asp:Label ID="lblerror" runat="server" ForeColor="Blue"></asp:Label></td></tr>
<tr>
<td colspan="3">
<asp:Panel ID="panel1" runat="server">
  <asp:DataList ID="DataList1" runat="server" Width="520px" OnItemDataBound="DataList1_ItemDataBound" >
    <HeaderTemplate>
    </HeaderTemplate>
    <ItemTemplate>
  <tr>
    <td colspan="3" style="background: url(images/event_send.png) no-repeat" height="50">
    <table width="100%" border="0">
  <tr>
    <td width="14%" height="40">&nbsp;</td>
    <td width="86%" class="side_menu">
    <asp:Label ID="cmpName" runat="server" Text ='<%# Eval("company_name") %>'></asp:Label></td>
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
      <asp:Image ID="imgReviewer" AlternateText="CompanyLogo" runat="server"  ImageUrl='<%# Eval("ImageName", "../Logos\\{0}") %>' Width="99"  Height="68"/>
   </td>
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
     <%--<asp:LinkButton ID="friend" runat="server" Text="Share with your friend"></asp:LinkButton>--%>
     <asp:HyperLink ID="friend" runat="server" Text="Share with your friend" CssClass="pointer"></asp:HyperLink>
        &nbsp;&nbsp;&nbsp;
    <asp:ImageButton ID="sendmailsms" runat="server" ImageUrl="images/send-_button.png" AlternateText="imgSendMail" /></td>
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
    <td colspan="3"><table width="100%" border="0" bgcolor="#FFEEE1">
      <tr>
        <td width="6%" class="mid_menu" height="25">
          <asp:Label ID="CmpInfo" runat="server" Text="Company Info"></asp:Label></td>
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
    <asp:Image ImageUrl="images/phone3.jpg" runat="server" AlternateText="imgMobileNo" />
    <%#DataBinder.Eval(Container.DataItem, "mob")%><br />
    <asp:Image ImageUrl="images/phone2.jpg" runat="server" AlternateText="imgLandPhone" />
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
  <td align="left">
  <asp:HyperLink ID="lnkMoreInfo" runat="server" ForeColor="#003366" Font-Bold="true" Font-Size="Medium" CssClass="pointer">More Info</asp:HyperLink>
  <%-- <asp:LinkButton ID="lnkMoreInfo" runat="server" Text="More Info" ForeColor="#003366" Font-Bold="true" Font-Size="Medium"></asp:LinkButton>--%>
  </td>
   <td align="right">
    <asp:HyperLink ID="lnkmap" runat="server" ForeColor="#003366" Font-Bold="true" Font-Size="Medium" CssClass="pointer">View Map</asp:HyperLink>
    <%--<asp:LinkButton ID="lnkmap" runat="server" Text="View Map" ForeColor="#003366" Font-Bold="true" Font-Size="Medium"></asp:LinkButton>--%>
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
           <AjaxToolkit:ModalPopupExtender ID="ModalPopupExtender4" runat="server" TargetControlID="lnkMoreInfo" BackgroundCssClass="modalbackground" PopupControlID="dvMoreInfo" DropShadow="false" CancelControlID="ImgBtnClose">
          </AjaxToolkit:ModalPopupExtender>
   </ItemTemplate>
 </asp:DataList>
  <asp:Panel ID="pnlmap" runat="server">
     <fieldset>
     <asp:DataList ID="dlmap" runat="server" DataKeyField="id">
     <ItemTemplate>
     <table border="0" width="100%">
     <tr>
      <td width="60%" class="bottam"><strong class="side_menu">
            <%#DataBinder.Eval(Container.DataItem, "map")%>
            </strong></td>
     </tr>
     </table>
     </ItemTemplate>
     </asp:DataList>
         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
     <asp:Button ID="cancel" runat="server" Text="Close" BackColor="#16C56E" />
     </fieldset></asp:Panel>
<div class="box" id="dvMoreInfo" runat="server" visible="false">
<div class="box_top">
  <table width="100%" border="0">
    <tr>
      <td width="93%" height="30">More Information</td>
      <td width="7%"><asp:Image ID="ImgBtnClose" ImageUrl="images/box_closebuttan.png" width="28" height="28" runat="server" AlternateText="imgbtnclose" /></td>
    </tr>
  </table>
</div>
<div class="box_mid">
  <table width="97%" border="0">
    <tr>
      <td height="30" colspan="3" class="box_hedings">Hours Of Operation</td>
      </tr>
    <tr>
      <td width="25%" align="right"><span>Monday</span></td>
      <td width="5%" align="center">:</td>
      <td width="70%"><asp:Label ID="lblMonday" runat="server" ></asp:Label></td>
    </tr>
    <tr>
      <td align="right"><span>Tuesday</span></td>
      <td align="center">:</td>
      <td><asp:Label ID="lblTuesday" runat="server"></asp:Label></td>
    </tr>
    <tr>
      <td align="right"><span>Wednesday</span></td>
      <td align="center">:</td>
      <td><asp:Label ID="lblWednesday" runat="server"></asp:Label></td>
    </tr>
    <tr>
      <td align="right"><span>Thursday</span></td>
      <td align="center">:</td>
      <td><asp:Label ID="lblThursday" runat="server"></asp:Label></td>
    </tr>
    <tr>
      <td align="right"><span>Friday</span></td>
      <td align="center">:</td>
      <td><asp:Label ID="lblFriday" runat="server"></asp:Label></td>
    </tr>
    <tr>
      <td align="right"><span>Saturday</span></td>
      <td align="center">:</td>
      <td><asp:Label ID="lblSaturday" runat="server"></asp:Label></td>
    </tr>
    <tr>
      <td align="right"><span>Sunday</span></td>
      <td align="center">:</td>
      <td><asp:Label ID="lblSunday" runat="server"></asp:Label></td>
    </tr>
    <tr>
      <td height="40" colspan="3" class="box_hedings">Payment Modes</td>
      </tr>
    <tr>
      <td colspan="3"><asp:Label ID="lblpaymodes" runat="server"></asp:Label></td>
      </tr>
    <tr>
      <td height="40" colspan="3" class="box_hedings">Company Information</td>
      </tr>
    <tr>
      <td>Year Established</td>
      <td align="center">:</td>
      <td><asp:Label ID="lblyrestd" runat="server"></asp:Label></td>
    </tr>
    <tr>
      <td>No of Employees</td>
      <td align="center">:</td>
      <td><asp:Label ID="lblempcount" runat="server"></asp:Label></td>
    </tr>
    <tr>
      <td>&nbsp;</td>
      <td>&nbsp;</td>
      <td>&nbsp;</td>
    </tr>
  </table>
</div>
<div class="box_bottom"></div>
</div>
<asp:DataList ID="ddldiscounts" DataKeyField="id" runat="server" Width="100%" OnItemDataBound="ddldiscounts_ItemDataBound">
    <HeaderTemplate>
    </HeaderTemplate>
    <ItemTemplate>
    <table width="100%" border="0">
      <tr>
    <td valign="top" style="background:url(images/event_send03.png) no-repeat; height:200px;">
    <table width="100%" border="0">
        <tr>
            <td width="60%" class="headings" valign="top" align="left" style="padding-left:5px; padding-top:3px;">
            <strong class="sub_menu">
               <asp:HyperLink ID="Hypcmpname" runat="server" Text='<%# Eval("company_name") %>' NavigateUrl='<%# GetUrl(Eval("id")) %>'></asp:HyperLink>  
              <%-- <asp:HyperLink ID="Hypcmpname" runat="server" Text='<%# Eval("company_name") %>' NavigateUrl='<%# string.Format("Discount_Details.aspx?id=" + Eval("id").ToString()+ "&cname=discounts") %>'></asp:HyperLink>  --%>       
             </strong>
             </td> 
            <td height="20" valign="middle" align="right" style="padding-right:9px; padding-top:3px;"><strong class="sub_menu">
             <asp:HyperLink ID="hypRatethis" runat="server" NavigateUrl='<%# GetCatUrl( Eval("id"))%>' Text="Rate this"></asp:HyperLink>            
            </strong>
            </td>    
         </tr>
         <tr>
          <td colspan="15" height="118" style="padding-left:5px" class="side_menu"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
           <table><tr>
            <td width="23%" rowspan="3" style="padding-bottom:10px 10px 10px 10px;" id="tdlogo" runat="server" visible="false">
               <asp:Label ID="lblImgName" runat="server" Text='<%# Eval("ImageName") %>' Visible="false"></asp:Label>
               <asp:Image  ID="imgReviewer"  runat="server" AlternateText="CompanyLogo" ImageUrl='<%# Eval("ImageName", "../Logos\\{0}") %>' 
                    Width="98"  Height="68"/>
            </td>
            <td style="height:30px;">
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
              <td class="side_menu" align="left" style="height:30px;"><asp:Literal ID="Literal3" runat="server" Text='<%#Eval("event_desc")%>' /></td>
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
   <%--<tr><td>&nbsp;</td></tr>--%>
   </table>
  </ItemTemplate>
  <FooterTemplate>
</FooterTemplate>
</asp:DataList>
 </asp:Panel>
<asp:Panel ID="friendpanel" runat="server" Width="350px">
<div class="dilogbox">
<table width="350px">
<tr>
<td align="center" valign="top" 
        
        style="font-family:Arial; font-size:large; color:#003366; padding-top: 5px;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Share with your 
    friend &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
   <asp:ImageButton ID="btncancel" ImageUrl="images/panel/cencel.png" width="21" height="22" runat="server" AlternateText="imgCancel"/></td>
</tr>
<tr>
  <td height="184">
     <table align="center" style="height: 174px;">
      <tr>
        <td colspan="3">
         <asp:Label ID="Label1" runat="server" Text="Tell your friend about this site ." ForeColor="#003366" ></asp:Label></td>
      </tr>
      <tr>
        <td align="right">
        <span class="star">*</span><asp:Label ID="Label2" runat="server" Text="Your Name" ForeColor="Black" Font-Bold="false" ></asp:Label></td>
        <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
        <td>
        <asp:TextBox ID="txtname" runat="server" validationgroup="modal" Width="160px" Height="25px" onkeypress="return Alphabets(event);"></asp:TextBox>
          <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                ErrorMessage="please enter your name" ControlToValidate="txtname"  validationgroup="share">*</asp:RequiredFieldValidator></td>
       </tr>
      <tr>
        <td align="right">
        <span class="star">*</span><asp:Label ID="Label3" runat="server" Text="Your's Friend Name" ForeColor="Black" Font-Bold="false" ></asp:Label></td>
        <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
        <td>
        <asp:TextBox ID="txtfname" runat="server" validationgroup="modal" Width="160px" Height="25px" onkeypress="return Alphabets(event);"></asp:TextBox>
          <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
               ErrorMessage="please enter your friend's name" ControlToValidate="txtfname"  
                    validationgroup="share">*</asp:RequiredFieldValidator></td>
      </tr>
       <tr>
        <td align="right">
        <span class="star">*</span>
        <asp:Label ID="Label8" runat="server" Text="Your Friend's Mobile_No" ForeColor="Black" Font-Bold="false" ></asp:Label>
        </td>
        <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
        <td>
        <asp:TextBox ID="txtFMobile" runat="server" validationgroup="modal" Width="160px" Height="25px" MaxLength="11" onkeypress="return onlyNos(event,this);"></asp:TextBox>
          <asp:RegularExpressionValidator ID="revtxtFMobile" runat="server" 
         ControlToValidate="txtFMobile" ErrorMessage="Only numbers are allowed for mobile" 
          ValidationExpression="^[01]?[- .]?(\([1-9]\d{2}\)|[1-9]\d{2})[- .]?\d{3}[- .]?\d{4}$" validationgroup="share">*</asp:RegularExpressionValidator>
          <asp:RequiredFieldValidator ID="rfvtxtFMobile" runat="server" 
             ErrorMessage="Please enter contact number" ControlToValidate="txtFMobile"  
                    validationgroup="share">*</asp:RequiredFieldValidator>
          <asp:RangeValidator ID="rgvtxtFMobile" runat="server" 
              ErrorMessage=" Mobile Number must start with 0" ControlToValidate="txtFMobile"  
                    MaximumValue="1" MinimumValue="0" 
               validationgroup="share">*</asp:RangeValidator>
       </td>
      </tr>
      <tr>
        <td align="right">
        <span class="star">*</span><asp:Label ID="Label4" runat="server" Text="Your Friend's Email_Id" ForeColor="Black" Font-Bold="false" ></asp:Label></td>
        <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
        <td>
        <asp:TextBox ID="txtEmail" runat="server" validationgroup="modal" Width="160px" Height="25px"></asp:TextBox>
          <asp:RequiredFieldValidator ID="rfvtxtEmail" runat="server" ControlToValidate="txtEmail" 
           ErrorMessage="please enter Email id"  validationgroup="share">*</asp:RequiredFieldValidator>
          <asp:RegularExpressionValidator ID="revtxtEmail" runat="server" 
           ErrorMessage="Incorrect Format of email address" 
           ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
           validationgroup="share" ControlToValidate="txtEmail" >*</asp:RegularExpressionValidator></td>
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
                validationgroup="share" ShowMessageBox="True" ShowSummary="False" />
      </tr>
     </table>
 </td>
</tr>
<tr>
  <%--<td width="241" height="37">&nbsp;</td>--%>
  <td align="right" style="padding:5px 10px 0px 0px;">
  <asp:ImageButton ID="imggo" OnClick="imggo_Click" AlternateText="imagGo" ImageUrl="images/panel/dialog_buttan.png" width="98" height="35" runat="server" ValidationGroup="share"/>
  </td>
</tr>
</table>
</div>
</asp:Panel> &nbsp;
<asp:Panel ID="mailpanel" runat="server" Width="320px">
<div class="dilogbox">
  <table width="320px">
    <tr>
      <td colspan="2" align="center" valign="top" 
        style="font-family:Arial; font-size:large; color:#003366; padding-top:5px;">Get Information by 
          sms/email &nbsp;&nbsp;&nbsp;&nbsp;
      <asp:ImageButton ID="cancelbtn" ImageUrl="images/panel/cencel.png" AlternateText="imgebtnCancel" width="21" height="22" runat="server"/></td>
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
        <asp:TextBox ID="txtname1" runat="server" ValidationGroup="modal"  Width="160px" Height="25px" onkeypress="return Alphabets(event);"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator16" runat="server" 
            ControlToValidate="txtname1" ErrorMessage="Enter Name" 
            ValidationGroup="sendmail">*</asp:RequiredFieldValidator>
       </td>
     </tr>
     <tr style="margin-left:5px">
        <td align="right">
        <span class="star">*</span>
            <asp:Label ID="Label9" runat="server" Text="Mobile_No" ForeColor="Black" Font-Bold="false" ></asp:Label>
        </td>
        <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
        <td>
            <asp:TextBox ID="txtmob1" runat="server" ValidationGroup="sendmail"  Width="160px" Height="25px" MaxLength="11" onkeypress="return onlyNos(event,this);"></asp:TextBox>
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
     <tr style="margin-left:5px">
        <td align="right">
        <span class="star">*</span>
            <asp:Label ID="Label7" runat="server" Text="Email_Id" ForeColor="Black" Font-Bold="false" ></asp:Label>
        </td>
        <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
        <td>
            <asp:TextBox ID="txtSEmail" runat="server" ValidationGroup="modal"  Width="160px" Height="25px"></asp:TextBox>
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
      <asp:ImageButton ID="imggo1" OnClick="imggo1_Click" AlternateText="imgeGo" ImageUrl="images/panel/dialog_buttan.png" width="98" height="35" runat="server" ValidationGroup="sendmail"/>
      </td>
    </tr>
    </table>
</div>
</asp:Panel>  
</td>
</tr>
</table></div>
<div class="contentmid_boxbottam"></div>

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
           <SpLinks:spd_Links ID="right_ads" runat="server" />
         </td>
    </tr>
</table>
</div>
<div class="contentbox_bottam"></div>
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
</div>
 </form>
 </body>
</html>
