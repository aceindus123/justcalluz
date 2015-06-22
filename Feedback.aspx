<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Feedback.aspx.cs" Inherits="Feedback" %>
<%@ Register Assembly="MSCaptcha" Namespace="MSCaptcha" TagPrefix="cc1" %>
<%@ Register Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" TagPrefix="cc3"  %>
<%@ Register Src="usercontrols/signin.ascx" TagName="signin" TagPrefix="aa1" %>
<%@ Register Src="usercontrols/catageories.ascx" TagName="catag" TagPrefix="aa6" %>
<%@ Register Src="usercontrols/footer1.ascx" TagName="footer1" TagPrefix="aa10" %>
<%@ Register Src="usercontrols/footer2.ascx" TagName="footer2" TagPrefix="aa11" %>
<%@ Register Src="usercontrols/BottomContent.ascx" TagName="bottomcontent" TagPrefix="aa4" %>
<%@ Register Src="usercontrols/BottomMidContent.ascx" TagName="bottomMidcontent" TagPrefix="aa5" %>
<%@ Register Src="usercontrols/SearchNew.ascx" TagName="SearchNew" TagPrefix="New" %>
<%@ Register Src="usercontrols/small_logo.ascx" TagName="logo" TagPrefix="S_logo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>Justcalluz | FeedBack </title>
<link href="css/style.css" rel="stylesheet" type="text/css" />
<link href="css/inner_style.css" rel="Stylesheet" type="text/css" />
<script src="SpryAssets/SpryTabbedPanels.js" type="text/javascript"></script>
<link href="SpryAssets/SpryTabbedPanels.css" rel="stylesheet" type="text/css" />
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
<div class="signin"><aa1:signin ID="fghg" runat="server" />
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
<!-- staart the Content-->
<div class="content" style="padding:0; margin:0;">
<div class="content_innermid" style="width:100%;">
<div class="middle_search1">
<div class="middle_searchtop1">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Welcome to JustCallUz</div>
 <div class="middle_searchmid1">
 <table width="100%" border="0">
  <tr>
    <td class="sub_menu" style="padding-left:20px;"><strong>Feedback Form</strong></td>
  </tr>
  <tr>
    <td class="sub_menu" style="padding-left:20px;" height="30"><font color="#006600"><strong>Corporate Address</strong></font></td>
  </tr>
  <tr>
    <td  style="padding-left:20px;" height="40"><table width="100%" border="0">
  <tr>
    <td width="24%" align="right"> <span class="star">*</span><span class="bottam_menu"><font color="#00254A">Name</font></span></td>
   <td width="2%" align="center"><strong>:</strong></td>
    <td width="42%" height="40" align="left"><asp:TextBox ID="txtname" runat="server" Width="231px" onkeypress="return Alphabets(event);"></asp:TextBox>
     <asp:RequiredFieldValidator ID="rfName" runat="server" 
            ErrorMessage="please enter Name" ControlToValidate="txtname" 
              ValidationGroup="Post Feedback">*</asp:RequiredFieldValidator>
    <cc3:ValidatorCalloutExtender ID="valcaloutextnName" runat="server" Enabled="true" TargetControlID="rfName">
    </cc3:ValidatorCalloutExtender>
    </td>
    <td width="32%" rowspan="10"><img src="images/feedback2x2.png" width="269" height="315" /></td>
  </tr>
  <tr>
    <td width="24%" align="right" height="38"> <span class="star">*</span><span class="bottam_menu"><font color="#00254A">Mobile Number</font></span></td>
     <td width="2%" align="center"><strong>:</strong></td>
    <td><asp:TextBox ID="txtmob" runat="server" Width="231px" onkeypress="return onlyNos(event,this);"  MaxLength="11"></asp:TextBox>
    <asp:RequiredFieldValidator ID="rfvMob" runat="server" 
            ErrorMessage="please enter your mobile number" ControlToValidate="txtmob" 
              ValidationGroup="Post Feedback" Text="*"></asp:RequiredFieldValidator>
        <cc3:ValidatorCalloutExtender ID="valcaloutextnrfvMob" runat="server" Enabled="true" TargetControlID="rfvMob">
             </cc3:ValidatorCalloutExtender>
            <asp:RegularExpressionValidator ID="revMob" runat="server" 
              ErrorMessage="Enter mobile number only ten digits(starting number should starts from 1 to 9 digits)" ControlToValidate="txtmob" 
              ValidationExpression="^[01]?[- .]?(\([1-9]\d{2}\)|[1-9]\d{2})[- .]?\d{3}[- .]?\d{4}$" Display="Dynamic"  ValidationGroup="Post Feedback"></asp:RegularExpressionValidator>
             <cc3:ValidatorCalloutExtender ID="valcaloutextnrevMob" runat="server" Enabled="true" TargetControlID="revMob">
             </cc3:ValidatorCalloutExtender>
          <asp:RangeValidator ID="rangevalMob" runat="server" 
              ControlToValidate="txtmob" ErrorMessage="Phone number should start with zero" 
              MaximumValue="1" MinimumValue="0" ValidationGroup="Post Feedback">*</asp:RangeValidator>
           <cc3:ValidatorCalloutExtender ID="valcaloutextnrangevalMob" runat="server" Enabled="true" TargetControlID="rangevalMob">
           </cc3:ValidatorCalloutExtender>
    
    </td>
    </tr>
  <tr>
    <td width="24%" align="right" height="30"> <span class="star">*</span><span class="bottam_menu"><font color="#00254A">Phone Number</font></span></td>
   <td width="2%" align="center"><strong>:</strong></td>
    <td><asp:TextBox ID="txtph" runat="server" Width="231px" onkeypress="return onlyNos(event,this);" MaxLength="11"></asp:TextBox>
    <asp:RegularExpressionValidator ID="rfvPh" runat="server" 
              ErrorMessage="Enter mobile number only ten digits(starting number should starts from 1 to 9 digits)" ControlToValidate="txtph" 
              ValidationExpression="^[01]?[- .]?(\([1-9]\d{2}\)|[1-9]\d{2})[- .]?\d{3}[- .]?\d{4}$" Display="Dynamic" ValidationGroup="Post Feedback"></asp:RegularExpressionValidator>
           <cc3:ValidatorCalloutExtender ID="valcaloutextnrfvPh" runat="server" Enabled="true" TargetControlID="rfvPh">
           </cc3:ValidatorCalloutExtender>
          <asp:RangeValidator ID="rangeValPh" runat="server" 
              ControlToValidate="txtph" ErrorMessage="Phone number should start with zero" 
              MaximumValue="1" MinimumValue="0" ValidationGroup="Post Feedback">*</asp:RangeValidator>
           <cc3:ValidatorCalloutExtender ID="valcaloutextnrangeValPh" runat="server" Enabled="true" TargetControlID="rangeValPh">
           </cc3:ValidatorCalloutExtender>
    <br/></td>
    </tr>
  <tr>
    <td width="24%" align="right" height="41"> <span class="star">*</span><span class="bottam_menu"><font color="#00254A">Email</font></span></td>
    <td width="2%" align="center"><strong>:</strong></td>
    <td><asp:TextBox ID="txtemail" runat="server" Width="231px"></asp:TextBox>
    <asp:RequiredFieldValidator ID="rfvEmail" runat="server" 
            ErrorMessage="please enter your email" ControlToValidate="txtemail" 
              ValidationGroup="Post Feedback" Text="*"></asp:RequiredFieldValidator>
             <cc3:ValidatorCalloutExtender ID="valcalloutextnrfvEmail" runat="server" Enabled="true" TargetControlID="rfvEmail">
           </cc3:ValidatorCalloutExtender> 
          <asp:RegularExpressionValidator ID="revEmail" runat="server" 
              ErrorMessage="Please enter Valid Email Id. Eg: XXXXX@xxx.xx" 
              ControlToValidate="txtemail" 
              ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
              ValidationGroup="Post Feedback">*</asp:RegularExpressionValidator>
           <cc3:ValidatorCalloutExtender ID="valcaloutextnrevEmail" runat="server" Enabled="true" TargetControlID="revEmail">
           </cc3:ValidatorCalloutExtender>
    </td>
    </tr>
  <tr>
   <td width="24%" align="right" height="30"> <span class="star">*</span><span class="bottam_menu"><font color="#00254A">Comments</font></span></td>
    <td width="2%" align="center"><strong>:</strong></td>
    <td><asp:TextBox ID="txtcomm" runat="server" TextMode="MultiLine" Height="83px" 
            Width="231px"></asp:TextBox>
             <asp:RequiredFieldValidator ID="rfvComment" runat="server" 
            ErrorMessage="please enter your valuable feedback" 
              ControlToValidate="txtcomm" ValidationGroup="Post Feedback" Text="*"></asp:RequiredFieldValidator>
           <cc3:ValidatorCalloutExtender ID="valcaloutextnrfvComment" runat="server" Enabled="true" TargetControlID="rfvComment">
            </cc3:ValidatorCalloutExtender></td>
  </tr>
  <tr>
    <td > <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
      <ContentTemplate>  
        <cc1:CaptchaControl ID="ccJoin" runat="server" BackColor="AliceBlue" CaptchaBackgroundNoise="none" CaptchaLength="5" CaptchaHeight="60" CaptchaWidth="200" CaptchaLineNoise="None" CaptchaMinTimeout="5" CaptchaMaxTimeout="240" />            
        </ContentTemplate>
      </asp:UpdatePanel> </td>
    <td width="2%" align="center"><strong>:</strong></td>
    <td> <asp:TextBox ID="txtvid" runat="server" Width="228px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                ControlToValidate="txtvid" 
                ErrorMessage="You have to enter ads like in the image" 
                ValidationGroup="Post Feedback">*</asp:RequiredFieldValidator></td>
  </tr>
  <tr>
    <td  align="right" height="32"><form id="form2" name="form1" method="post" action="">
      <asp:Button ID="btnRefresh" runat="server" Text="Refresh" 
          onclick="btnRefresh_Click" />
    </form></td>
   <td width="2%" align="center">&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td >&nbsp;</td>
    <td >&nbsp;</td>
    <td><asp:ImageButton ID="ImgBtnSubmit" runat="server" AlternateText="submitfeedback" 
              ImageUrl="images/submit2.png" onclick="ImgBtnSubmit_Click" 
              ValidationGroup="Post Feedback" width="61" height="27"/>&nbsp;&nbsp;&nbsp;
       <asp:ImageButton ID="ImgBtnReset" runat="server" ImageUrl="images/reset.png" AlternateText="ResetDetails" 
              onclick="ImgBtnReset_Click" width="110" height="27"/></td>
  </tr>
  <tr><td height="10">
    <asp:Label ID="lblerror" runat="server"></asp:Label></td></tr>
</table>
</td>
  </tr>
  <tr>
    <td style="padding-left:20px;" height="30"><table width="100%" border="0">
  <tr>
    <td height="30" colspan="2"><hr/></td>
    <tr>
    <td height="30" colspan="2"><strong class="bottam"><font color="#F24F00">Reach Us</font></strong><br/><hr/></td>
    <tr>
    <td width="53%" class="select_menu"><span class="mid_menu">Global Head Quarters - USA
    </span><br/>
    Indus Group Incorporated,
1039 Sterling Road, Ste# 205,<br/>
Herndon-VA-20170. USA.<br/>
Washington DC Metro Area.
<br/>
<strong><font color="#D90000">Voice</font></strong> : <strong> 703-263-7278 </strong><br/>
<strong><font color="#D90000">Fax</font></strong>: <strong>703-935-8849</strong> <br/><br/>
<strong><font color="#004891">Email</font></strong><br/>
<strong><font color="#D90000">For general inquiries</font></strong> : <strong>info@mnhbs.com</strong><br/>
<strong><font color="#D90000">For Clients</font></strong> :  <strong>sales@mnhbs.com </strong><br/>
<strong><font color="#D90000">For Consultants</font></strong>:  <strong>resume@mnhbs.com </strong></td>
    <td width="47%" class="select_menu" valign="top"><p><span class="mid_menu">India </span><br/>Plot # 1323, Behind Saradhi Studios,
      Ameerpet, Yellareddyguda,
      Hyderabad-AP-520073.<br/> India.<br/>

   <strong><font color="#D90000">Voice</font></strong> : <strong> 91-406-613-6226 </strong><br/>
        <strong><font color="#D90000">Fax</font></strong>  : <strong>91-406-613-6446</strong><br/><br/>
        <strong><font color="#004891">Email</font></strong><br/>
        <strong><font color="#D90000">For general inquiries</font></strong> : <strong>info@mnhbs.com</strong><br/>
        <strong><font color="#D90000">For Clients</font></strong>:  <strong>sales@mnhbs.com </strong><br/>
       <strong><font color="#D90000">For Consultants</font></strong> :  <strong>resume@mnhbs.com </strong></td>
 
</table>
</td>
  </tr>
</table>
</div>
 <div class="middle_searchbottam1"></div>
  
</div>
</div>
<!-- end of the mid Box-->
</div>

<div class="content_midbootam" >
<aa5:bottomMidcontent ID="mid1" runat="server" />

</div>
<div class="content_bootam_center">
<aa4:bottomcontent ID="bottomcontent1" runat="server" />

</div>
<div class="footer" align="center" style="padding-top:5px; " >
<aa10:footer1 ID="tqw" runat="server" />
<aa11:footer2 ID="uyef" runat="server" />
</div>
</div>
<script type="text/javascript">
<!--
var TabbedPanels1 = new Spry.Widget.TabbedPanels("TabbedPanels1");
//-->
</script>
    </form>
</body>
</html>
