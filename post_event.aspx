<%@ Page Language="C#" AutoEventWireup="true" CodeFile="post_event.aspx.cs" Inherits="post_events" %>
<%@ Register Src="usercontrols/eventleft.ascx" TagName="leftevent" TagPrefix="el" %>
<%@ Register Src="usercontrols/SponsoredLinks.ascx" TagName="eventright" TagPrefix="ever" %>
<%@ Register Src="usercontrols/footer1.ascx" TagName="footer1" TagPrefix="aa10" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="AjaxToolkit" %>
<%@ Register Assembly="MSCaptcha" Namespace="MSCaptcha" TagPrefix="cc1" %>
<%@ Register Src="usercontrols/footer2.ascx" TagName="footer2" TagPrefix="aa11" %>
<%@ Register Src="usercontrols/catageories.ascx" TagName="catag" TagPrefix="aa6" %>
<%@ Register Src="usercontrols/signin.ascx" TagName="signin" TagPrefix="sig" %>
<%@ Register Src="usercontrols/BottomContent.ascx" TagName="bottomcontent" TagPrefix="aa4" %>
<%@ Register Src="usercontrols/BottomMidContent.ascx" TagName="bottomMidcontent" TagPrefix="aa5" %>
<%@ Register Src="usercontrols/SearchNew.ascx" TagName="SearchNew" TagPrefix="New" %>
<%@ Register Src="usercontrols/small_logo.ascx" TagName="logo" TagPrefix="S_logo" %>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
  <%-- <title>:: Justcalluz :: Post Event</title>--%>
  <title>Justcalluz | Find Events in your city | we provide updated information on all your local search</title>
<meta name='description' content='Event in your city,Event Management'/>
<meta name='keywords' content='Justcalluz, Event in your city,Event Management, yellow pages, online yellow pages, yellow pages india, India trade directory,  yellow pages directory, city yellow pages, indian search engine, JustCalluz customer care, JustCalluz customer support' />
   <link href="css/style.css" rel="stylesheet" type="text/css" />
     <link href="css/inner_style.css" rel="Stylesheet" type="text/css" />
<style type="text/css">
<!--
.style9 {
        width: 20%;
        height: 10px;
    }
.style9 {        height: 10px;
        width: 372px;
}
    .style10
    {
        width: 20%;
    }
-->
</style>
</head>
<body>
    <form id="form1" runat="server">
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
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
 <div class="layout">
<div class="signin">
<sig:signin ID="sig1" runat="server" />
</div>
<div class="header">
<%--<div class="header_top"></div>
--%><div class="header_logo"><S_logo:logo ID="logo" runat="server" /></div>
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
<div>
<div class="contentbox_top">Events</div>
<div class="contentbox_mid"> 
<!-- start the inner left-->
<el:leftevent ID="left" runat="server" />
</div>
<div class="contentbox_bottam"></div>
</div>
</div>
<!-- end of the inner left-->

<!-- start the mid Box-->
  <div class="content_innermid">
  <div>
  <div class="contentmid_boxtop"><asp:HyperLink ID="hyplink" runat="server" NavigateUrl="Default.aspx" Text="Home" 
       Font-Underline="false" ForeColor="White"></asp:HyperLink>&gt;&gt;Post The Event </div>
  <div class="contentmid_boxmid">
  <table width="100%" border="0"> 
  <tr>
    <td height="30" align="center" class="bottam" style="padding-right:5px;">Welcome to Justcalluz</td>
    </tr>
  <tr>
    <td valign="top"> 
     <div class="events">
       <table width="100%" border="0" style="background-color:#D9EBFD;  border:dotted 1px #666">
              <tr>
                <td height="25" align="left" style="padding-left:10px;"><label style="color:#000" ><span class="sub_menu"><b>Post The Event </b></span></label>
                  <span class="sub_menu"></span></td>
              </tr>
              <tr>
                <td width="100%"><hr/><hr/></td>
                </tr>
              <tr>
                <td height="30" align="center" valign="top">
                 <table width="100%" border="0">
                  <tr>
                    <td align="right" class="style10"> <span class="star">*</span><span class="list">Category</span></td>
                    <td width="4%" align="center"><strong>:</strong></td>
                    <td width="71%" height="30" align="left"><span class="row">
                      <asp:DropDownList ID="ddlsubcat" runat="server" 
          AutoPostBack="true" Height="21px" 
          Width="203px"></asp:DropDownList>
      <asp:RequiredFieldValidator ID="reqsubcat" runat="server" ControlToValidate="ddlsubcat" 
          ErrorMessage="Please select SubCategory" ValidationGroup="postevent" 
          InitialValue="select">*</asp:RequiredFieldValidator>
                     
                    </span></td>
                    </tr>
                  <tr>
                    <td align="right" class="style10"><span class="star">*</span> <span class="list">State</span></td>
                    <td align="center"><strong>:</strong></td>
                    <td height="30" align="left"><span class="row">
                      <asp:DropDownList ID="ddlstate" 
          runat="server" AutoPostBack="true" 
           Height="21px" 
          Width="203px" OnSelectedIndexChanged="ddlstate_selectedindexchanged" 
          ></asp:DropDownList>
      <asp:RequiredFieldValidator ID="reqstate" runat="server" 
          ErrorMessage="Please select state" ControlToValidate="ddlstate"  
          ValidationGroup="postevent" InitialValue="select">*</asp:RequiredFieldValidator>
                   </span></td>
                    </tr>
                  <tr>
                    <td align="right" class="style10"><span class="star">*</span><span class="list"> city</span></td>
                    <td align="center"><strong>:</strong></td>
                    <td height="30" align="left"><span class="row">
                      <asp:DropDownList ID="ddlcity" runat="server" AutoPostBack="true" 
           Height="21px" 
          Width="203px" ValidationGroup="events"></asp:DropDownList>
      <asp:RequiredFieldValidator ID="reqcity" runat="server" 
          ErrorMessage="Please select city" ControlToValidate="ddlcity"  
          ValidationGroup="postevent" InitialValue="select">*</asp:RequiredFieldValidator>
                       </span></td>
                  </tr>
                  <tr>
                    <td align="right" class="style10"><span class="star">*</span> <span class="list">Area</span></td>
                    <td align="center"><strong>:</strong></td>
                    <td height="30" align="left"><asp:TextBox ID="txtarea" runat="server" Height="20px" 
          Width="203px" ValidationGroup="events" onkeypress="return Alphabets(event);" ></asp:TextBox>
      <asp:RequiredFieldValidator ID="reqara" runat="server" 
          ErrorMessage="please enter area" ControlToValidate="txtarea"  
          ValidationGroup="postevent">*</asp:RequiredFieldValidator> </td>
                  </tr>
                  <tr>
                    <td align="right" class="style10"><span class="star">*</span> <span class="list">Event Name</span></td>
                    <td align="center"><strong>:</strong></td>
                    <td height="30" align="left"><asp:TextBox ID="txtevename" runat="server" Height="20px" 
          Width="203px" ValidationGroup="events" ></asp:TextBox>
      <asp:RequiredFieldValidator ID="reqcmpnme" runat="server" 
          ErrorMessage="please specify the event name" ControlToValidate="txtevename"  ValidationGroup="postevent">*</asp:RequiredFieldValidator></td>
                  </tr>
                  <tr>
                    <td align="right" class="style10"><span class="star">*</span> <span class="list">Venue</span></td>
                    <td align="center"><strong>:</strong></td>
                    <td height="30" align="left"><asp:TextBox ID="txtven" runat="server" Height="20px" 
          Width="203px" ValidationGroup="events" onkeypress="return Alphabets(event);"></asp:TextBox>
      <asp:RequiredFieldValidator ID="reqind" runat="server" 
          ErrorMessage="Please enter the venue " ControlToValidate="txtven"  ValidationGroup="postevent">*</asp:RequiredFieldValidator></td>
                  </tr>
                  <tr>
                    <td align="center" class="style10"><span class="star">*</span><span class="list">Type of Event</span></td>
                    <td align="center"><strong>:</strong></td>
                    <td height="30" align="left"><span class="row">
                      <asp:DropDownList ID="ddltyp" runat="server" AutoPostBack="true" 
           Height="21px" 
          Width="203px" ValidationGroup="events" OnSelectedIndexChanged="ddltyp_selectedindexchanged">
          <asp:ListItem>select</asp:ListItem>
          <asp:ListItem>One Day Event</asp:ListItem>
          <asp:ListItem>Multi Day Event</asp:ListItem>
          </asp:DropDownList>
      <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
          ErrorMessage="Please specify the type of event" InitialValue="select" 
          ControlToValidate="ddltyp"  ValidationGroup="postevent">*</asp:RequiredFieldValidator>
                    </span></td>
                  </tr>
                  <tr><td align="right" class="style9"></td>
                     <td align="left" class="style16"></td>
                     <td>
                          <asp:TextBox ID="txtone" runat="server" Visible="false" Height="20px" 
                              Width="101.5px" ValidationGroup="events"></asp:TextBox>
                              <asp:RangeValidator ID="rngone" runat="server" 
                                      ControlToValidate="txtone" 
                                      ValidationGroup="postevent" Type="Date">*</asp:RangeValidator>
                               <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                              ErrorMessage="Specify the event date" ControlToValidate="txtone"  ValidationGroup="postevent">*</asp:RequiredFieldValidator>
                             
                               <asp:TextBox ID="txtmulti" runat="server" Visible="false" Height="20px" 
                              Width="101.5px" ValidationGroup="events"></asp:TextBox>
                              <asp:RangeValidator ID="rngmulti" runat="server" 
                                      ControlToValidate="txtmulti" 
                                      ValidationGroup="postevent" Type="Date">*</asp:RangeValidator>    
                              <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                              ErrorMessage="Please enter the end date" ControlToValidate="txtmulti"  ValidationGroup="postevent">*</asp:RequiredFieldValidator>
                             
                    </td>
                              <AjaxToolkit:CalendarExtender Animated="true" ID="calenderExtender1" runat="server" TargetControlID="txtone"></AjaxToolkit:CalendarExtender>
                              <AjaxToolkit:CalendarExtender Animated="true" ID="CalendarExtender2" runat="server" TargetControlID="txtmulti"></AjaxToolkit:CalendarExtender>
                               <AjaxToolkit:TextBoxWatermarkExtender ID="TextBoxWatermarkExtender1" runat="server" TargetControlID="txtone" WatermarkText="Start Date">
                             </AjaxToolkit:TextBoxWatermarkExtender>
                             <AjaxToolkit:TextBoxWatermarkExtender ID="TextBoxWatermarkExtender2" runat="server" TargetControlID="txtmulti" WatermarkText="End Date">
                             </AjaxToolkit:TextBoxWatermarkExtender>  
    
                </tr>                  
                  <tr>
                    <td align="right" class="style10"><span class="star">*</span> <span class="list">Event Description</span></td>
                    <td align="center"><strong>:</strong></td>
                    <td height="30" align="left">
                        <asp:TextBox ID="txtdesc" runat="server" Height="33px" 
          Width="203px" TextMode="MultiLine" ValidationGroup="events"></asp:TextBox>
      <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" 
          ControlToValidate="txtdesc" ErrorMessage="Enter event description" ValidationGroup="postevent">*</asp:RequiredFieldValidator></td>
                  </tr>
                  <tr>
                    <td align="right" class="style10"><span class="star">*</span> <span class="list">Time</span></td>
                    <td align="center"><strong>:</strong></td>
                    <td height="30" align="left"><asp:TextBox ID="txttime" runat="server" Height="20px" 
          Width="203px" ValidationGroup="events"></asp:TextBox>
      <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" 
          ErrorMessage=" Please enter time " ControlToValidate="txttime"  ValidationGroup="postevent">*</asp:RequiredFieldValidator></td>
                  </tr>
                  <tr>
                    <td align="right" class="style10"><span class="star">*</span> <span class="list">Address</span></td>
                    <td align="center"><strong>:</strong></td>
                    <td height="30" align="left"><asp:TextBox ID="txtadd" runat="server" Height="20px" 
          Width="203px" TextMode="MultiLine" ValidationGroup="events"></asp:TextBox>
      <asp:RequiredFieldValidator ID="RequiredFieldValidator13" runat="server" 
          ErrorMessage="Enter the address" ControlToValidate="txtadd"  ValidationGroup="postevent">*</asp:RequiredFieldValidator></td>
                  </tr>
                  <tr>
                    <td align="right" class="style10"><span class="list">LandMark</span></td>
                    <td align="center"><strong>:</strong></td>
                    <td height="30" align="left"><asp:TextBox ID="txtlndm" runat="server" Height="20px" Width="203px"></asp:TextBox></td>
                  </tr>
                  <tr>
                    <td align="right" class="style10"><span class="star">*</span> <span class="list">Pincode</span></td>
                    <td align="center"><strong>:</strong></td>
                    <td height="30" align="left"><asp:TextBox ID="txtpin" runat="server" Height="20px" Width="203px" MaxLength="6" onkeypress="return onlyNos(event,this);"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator17" runat="server" ErrorMessage="Please enter pincode" ControlToValidate="txtpin" 
                           ValidationGroup="postevent">*</asp:RequiredFieldValidator>
                 <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" 
                  ErrorMessage="Enter pincode number only 6 digits(starting number should starts from 1 to 9 digits)"  ControlToValidate="txtpin" 
                  ValidationExpression="^[01]?[- .]?(\([1-9]\d{1}\)|[1-9]\d{1})[- .]?\d{2}[- .]?\d{2}$" Display="Dynamic" ValidationGroup="postevent"></asp:RegularExpressionValidator>  
                      </td>
                  </tr>
                  <tr>
                    <td align="right" class="style10"><span class="star">*</span><span class="list"> Contact Person</span></td>
                    <td align="center"><strong>:</strong></td>
                    <td height="30" align="left"><asp:TextBox ID="txtcntp" runat="server" Height="20px" Width="203px" onkeypress="return Alphabets(event);"></asp:TextBox>
  <asp:RequiredFieldValidator ID="RequiredFieldValidator16" runat="server" 
          ControlToValidate="txtcntp" ErrorMessage="Please name of the contact person" 
          ValidationGroup="postevent">*</asp:RequiredFieldValidator></td>
                  </tr>
                  <tr>
                    <td align="right" class="style10"><span class="star">*</span> <span class="list">Email</span></td>
                    <td align="center"><strong>:</strong></td>
                    <td height="30" align="left"><asp:TextBox ID="txtemail" runat="server" Height="20px" 
          Width="203px"></asp:TextBox>
          <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
          ControlToValidate="txtemail" ErrorMessage="please enter the email address" 
          ValidationGroup="postevent">*</asp:RequiredFieldValidator>
      <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
          ErrorMessage="Incorrect Format" 
          ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
          ValidationGroup="postevent" ControlToValidate="txtemail" >*</asp:RegularExpressionValidator></td>
                  </tr>
                  <tr>
                    <td align="right" class="style10"><span class="list">LandLine</span></td>
                    <td align="center"><strong>:</strong></td>
                    <td height="30" align="left"><asp:TextBox ID="txtph" runat="server" Height="20px" Width="203px" MaxLength="11" onkeypress="return onlyNos(event,this);">
                      </asp:TextBox><asp:RangeValidator ID="RangeValidator2" runat="server" 
          ErrorMessage="Number must start with 0" ControlToValidate="txtph"  MaximumValue="1" MinimumValue="0" 
          ValidationGroup="postevent">*</asp:RangeValidator>
          <asp:RegularExpressionValidator ID="RegularExpressionValidator6" runat="server" 
          ControlToValidate="txtph" ErrorMessage="phone number must be numbers only" 
          ValidationExpression="\d{11}">*</asp:RegularExpressionValidator>
           </td>
                  </tr>
                  <tr>
                    <td>&nbsp;</td>
                    <td align="center">&nbsp;</td>
                    <td height="5" align="left">                      
            <b class="side_menu">(E.g:- 04066136226)</b></td>
                  </tr>
                  <tr>
                    <td align="right" class="style10"><span class="star">*</span> <span class="list">Mobile</span></td>
                    <td align="center"><strong>:</strong></td>
                    <td height="30" align="left" class="mid1_menu">
                    <asp:TextBox ID="txtcode" runat="server" ReadOnly="true" Text="+91" Width="30px"></asp:TextBox>-
                    <asp:TextBox ID="txtmob" runat="server" Height="20px" 
          Width="165px" MaxLength="10" ValidationGroup="events" onkeypress="return onlyNos(event,this);"></asp:TextBox>
          <asp:RequiredFieldValidator ID="RequiredFieldValidator18" runat="server" 
          ControlToValidate="txtmob" ErrorMessage="please enter the mobile number" 
          ValidationGroup="postevent">*</asp:RequiredFieldValidator>
          <%--<asp:RangeValidator ID="RangeValidator1" runat="server" 
          ErrorMessage="Number must start with 0" ControlToValidate="txtmob"  MaximumValue="1" MinimumValue="0" 
          ValidationGroup="postevent">*</asp:RangeValidator>--%>
          <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" 
          ControlToValidate="txtmob" ErrorMessage="Enter mobile number only ten digits(starting number should starts from 1 to 9 digits)" 
          ValidationExpression="^[01]?[- .]?(\([1-9]\d{2}\)|[1-9]\d{2})[- .]?\d{3}[- .]?\d{4}$"  Display="Dynamic" ValidationGroup="postevent"></asp:RegularExpressionValidator>
         <%-- <asp:RegularExpressionValidator ID="RegularExpressionValidator7" runat="server" ControlToValidate="txtmob" ErrorMessage="Minimum length is 10" ValidationExpression=".{10}.*" ValidationGroup="postevent">*</asp:RegularExpressionValidator>--%>
          </td>
                  </tr>  
                  <tr>
                    <td>&nbsp;</td>
                    <td align="center">&nbsp;</td>
                    <td height="5" align="left">                      
                    <b class="side_menu">(E.g:- 9000465921)</b></td>
                  </tr>                
                  <tr>
                    <td align="right" class="style10"><span class="list">fax</span></td>
                    <td align="center"><strong>:</strong></td>
                    <td height="30" align="left"><asp:TextBox ID="txtfax" runat="server" Height="20px" Width="203px" MaxLength="11" onkeypress="return onlyNos(event,this);"></asp:TextBox>
   <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" 
          ControlToValidate="txtfax" ErrorMessage="fax must be numbers only" 
          ValidationExpression="\d{11}">*</asp:RegularExpressionValidator>
                      </td>
                  </tr>
                  <tr>
                    <td align="right" class="style10"><span class="list">website</span></td>
                    <td align="center"><strong>:</strong></td>
                    <td height="30" align="left"><asp:TextBox ID="txtweb" runat="server" Height="20px" Width="203px"></asp:TextBox>
                      <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
          ControlToValidate="txtweb" ErrorMessage="Invalid format of website" 
          ValidationExpression="http(s)?://([\w-]+\.)+[\w-]+(/[\w- ./?%&amp;=]*)?" 
          ValidationGroup="postevent">*</asp:RegularExpressionValidator></td>
                  </tr>
                  <tr>
                    <td align="right" class="style10">&nbsp;</td>
                    <td align="center"></td>
                    <td height="5" align="left" class="mid1_menu"> 
                     <b class="side_menu">(E.g:- http://www.Justcalluz.com )</b>
     
     
     </td>
                  </tr>
                  <tr>
                    <td align="right" class="style10">&nbsp;</td>
                    <td align="center"></td>
                    <td> <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
          ValidationGroup="postevent" ShowMessageBox="True" ShowSummary="False" /></td>
                  </tr>
                  <tr>
                    <td align="right" class="style10"><span class="star"></span><span class="list">upload Invitation</span></td>
                    <td align="center"><strong>:</strong></td>
                    <td height="30" align="left" class="side_menu"><asp:FileUpload ID="photo" runat="server" />
    <b class="side_menu"><br />Invitation must be 250x300 with less than 
      100kb of size</b>  </td>
                  </tr>              
                  <tr>
                    <td height="30" colspan="3" align="center" class="right_tab" style="padding-top:10px;"><font color="#E14900">By clicking &quot;Post&quot; you agree and consent to 
              Justcalluz.com Terms of Use and receive required notices from uz.</font></td>
                    </tr>
                  <tr>
  <td align="right">
 <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
      <ContentTemplate> 
        
        <cc1:CaptchaControl ID="ccjoin" runat="server" BackColor="AntiqueWhite" 
        CaptchaBackgroundNoise="None" CaptchaHeight="35" CaptchaLength="4" 
        CaptchaWidth="90" CaptchaLineNoise="None" CaptchaMinTimeout="5" 
        CaptchaMaxTimeout="200" Width="90px" />
       </ContentTemplate>
       </asp:UpdatePanel>
        </td>
        <td >&nbsp;<strong>:</strong>&nbsp;</td>
        <td>
            <asp:TextBox ID="txtvid" runat="server" Width="203px"></asp:TextBox>
        </td>
  </tr>
                  <tr>
                    <td height="30" colspan="3"><table width="100%" border="0">
                      <tr>
                        <td width="36%" align="right" height="40" style="padding-right:3px;">
                        <asp:ImageButton ID="postbtn" runat="server" ImageUrl="images/post-button.png"
                             onclick="postbtn_Click" ValidationGroup="postevent" AlternateText="btnPost" /></td>
                        <td width="24%" align="center"><asp:ImageButton ID="viewbtn" runat="server" ImageUrl="images/view-eventbutton.png" 
                             PostBackUrl="<%$RouteUrl:RouteName=viewEvents%>" AlternateText="btnView" /></td>
                        <td width="40%" align="left"><asp:ImageButton ID="cancel" AlternateText="imgbtnCancel" runat="server" ImageUrl="images/cancel-button.png" onclick="cancel_Click"
         
           /></td>
                      </tr>
                    </table></td>
                    </tr>
                  <tr>
                    <td height="30" colspan="3" align="center" class="right_tab" style="padding-top:5px;"><font class="side_menu" color:"#005B88">Dear Guest, kindly submit all the
                     
                        marked details. Its kind of</font>  <span class="mid_menu"><strong class="mid_menu"><font color="#E84B00">mandatory</font></strong>. </span><span class="side_menu">What to</span> <span class="side_menu">do! Its not our fault. We are here to provide   the best of our services<strong> </strong></span><span class="mid_menu"><strong><font color="#E84B00"> 24*7</font></strong></span></td>
                  </tr>
                  <tr>
                    <td height="30" colspan="3" align="right">&nbsp;</td>
                    </tr>
                  </table>
                </td>
              </tr>            
        </table>
       </div>
     </td>
  </tr>
  </table>
  </div>
  <div class="contentmid_boxbottam"></div>
  
  </div>
  
  </div>
  
<!-- end of the mid Box-->  
<div class="content_innerright">
<!-- end of the mid Box-->  
<div>
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
</div>
    </form>
</body>
</html>
