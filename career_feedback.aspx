<%@ Page Language="C#" AutoEventWireup="true" CodeFile="career_feedback.aspx.cs" Inherits="career_feedback" %>
<%@ Register Src="usercontrols/signin.ascx" TagName="signin" TagPrefix="aa1" %>
<%@ Register Src="usercontrols/catageories.ascx" TagName="catag" TagPrefix="aa6" %>
<%@ Register Src="usercontrols/footer1.ascx" TagName="footer1" TagPrefix="aa10" %>
<%@ Register Src="usercontrols/footer2.ascx" TagName="footer2" TagPrefix="aa11" %>
<%@ Register Src="usercontrols/SearchNew.ascx" TagName="SearchNew" TagPrefix="New" %>
<%@ Register Src="usercontrols/BottomContent.ascx" TagName="bottomcontent" TagPrefix="aa4" %>
<%@ Register Src="usercontrols/BottomMidContent.ascx" TagName="bottomMidcontent" TagPrefix="aa5" %>
<%@ Register Src="usercontrols/Testimonials_Left.ascx" TagName="TestLeft" TagPrefix="aa15" %>
<%@ Register Src="usercontrols/small_logo.ascx" TagName="logo" TagPrefix="S_logo" %>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
 <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
 <title>FeedBack | JustCalluz</title>
 <link href="css/style.css" rel="Stylesheet" type="text/css" />
  <link href="css/inner_style.css" rel="Stylesheet" type="text/css" />
 <script src="Scripts/swfobject_modified.js" type="text/javascript">
 </script>
 <style type="text/css">
            .style1
            {
                height: 45px;
            }
            .style2
            {
                height: 38px;
            }
            .style3
            {
                width: 3%;
            }
            .style4
            {
                height: 45px;
                width: 3%;
            }
            .style5
            {
                height: 38px;
                width: 3%;
            }
        </style>
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
  <aa1:signin ID="signIn" runat="server" />
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
  <div class="content_innerleft">
      <aa15:TestLeft ID="content" runat="server" />
</div>
<div class="content_innermid" style="width:79%;">
  <table width="100%" border="0">
   <tr>
    <td style="background:url(images/Testimonials.png) no-repeat" height="36">
   <table width="100%" border="0" >
   <tr>
    <td width="49%" class="bottam" style="padding-left:12px;">
    <font color="#FFFFFF" class="location">Careers at Justcalluz</font>
    </td>
    <td width="5%"><asp:Image AlternateText="imgpencial" ImageUrl="images/pencial.png" width="20" height="20" runat="server" />
    </td>
    <td width="46%">
    <font color="#FFFFFF"> Listing  Your job in Careers at Justcalluz</font>
    </td>
  </tr>
   </table>
 </td>
 </tr>
  <tr>
   <td>
   <span class="location" style="padding-left:10px;">
    <font color="#00468C">Feedback</font>
    </span>
    </td>
   </tr>
    <tr>
      <td colspan="3" ><hr/></td>
    </tr>
    <tr>
     <td style="padding:5px;">
      <table width="101%" border="0"  style="background-color:#E1F5FF; border:dotted 1px #999" >
      <tr align="center">
      <td>
      <asp:Label ID="lblStatus" runat="server">
      </asp:Label>
      </td>
      </tr>
         
    <tr>
     <td width="25%" height="30" align="right">
      <span class="list">Name</span>
     </td>
     <td align="center" class="style3"><strong>:</strong>
     </td>
     <td width="73%" height="30" align="left" >
       <asp:TextBox ID="txtName" runat="server" 
           Width="400px" style="margin-left: 9px" onkeypress="return Alphabets(event);">
       </asp:TextBox>
                 &nbsp;&nbsp;&nbsp;&nbsp;
       <asp:RequiredFieldValidator ID="rfv1" runat="server" 
              ErrorMessage="please enter Name" ControlToValidate="txtName" 
              ValidationGroup="career_feedback">*</asp:RequiredFieldValidator>
     </td>
     </tr>
     <tr>
     <td height="30" align="right" >
      <span class="list">Email Address</span>
     </td>
      <td align="center" class="style3"><strong>:</strong></td>
      <td width="73%" height="30" align="left" >
        <asp:TextBox ID="txtEmailAddress" 
            runat="server" Width="400px" style="margin-left: 9px">
        </asp:TextBox>
        <asp:RequiredFieldValidator ID="rfv2" runat="server" ErrorMessage="please enter email address" 
        ControlToValidate="txtEmailAddress" ValidationGroup="career_feedback">*</asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="revEmailAddress" runat="server" 
            ErrorMessage="Please enter valid email address" ControlToValidate="txtEmailAddress" 
                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
                    ValidationGroup="career_feedback">*</asp:RegularExpressionValidator>
       </td>
      </tr>
       <tr>
        <td height="30" align="right">
         <span class="list">Mobile Number</span>
        </td>
        <td align="center" class="style3"><strong>:</strong></td>
        <td height="30" align="left">
          <asp:TextBox ID="txtMobileNo" runat="server" 
                       Width="400px" MaxLength="11" style="margin-left: 9px" onkeypress="return onlyNos(event,this);">
          </asp:TextBox><%--<b style="color:#093; font-size:11px;">(E.g:- 09985998659)</b> --%>
           <asp:RequiredFieldValidator ID="rfv3" runat="server" 
               ErrorMessage="please enter Mobile Number" ControlToValidate="txtMobileNo" 
               ValidationGroup="career_feedback">*</asp:RequiredFieldValidator>
           <asp:RegularExpressionValidator ID="revMobileNo" runat="server" 
                   ErrorMessage="Enter mobile number only ten digits(starting number should starts from 1 to 9 digits)"
                   ControlToValidate="txtMobileNo" ValidationExpression="^[01]?[- .]?(\([1-9]\d{2}\)|[1-9]\d{2})[- .]?\d{3}[- .]?\d{4}$" Display="Dynamic"
                   ValidationGroup="career_feedback"></asp:RegularExpressionValidator>
            <asp:RangeValidator ID="rvMobileNo" runat="server" MaximumValue="1" MinimumValue="0" 
                   ErrorMessage="Mobile number should start with zero" ControlToValidate="txtMobileNo" 
                   ValidationGroup="career_feedback">*</asp:RangeValidator>
        </td>
        </tr>
        <tr>
          <td height="30" align="right">
           <span class="list">Your State</span></td>
          <td align="center" class="style3"><strong>:</strong></td>
          <td height="30" align="left">
            <asp:DropDownList ID="ddlState" runat="server" 
                     Width="401px" OnSelectedIndexChanged="ddlState_SelectedIndexChanged" 
                     AutoPostBack="true" style="margin-left: 9px">
            </asp:DropDownList> 
           <asp:RequiredFieldValidator ID="rfv4" runat="server" 
                  ErrorMessage="please Select state" ControlToValidate="ddlState" 
                  ValidationGroup="career_feedback" InitialValue="select state">*</asp:RequiredFieldValidator>
          
          </td>
        </tr>
        <tr>
          <td align="right">
           <span class="list">Your City</span></td>
          <td align="center" class="style4"><strong>:</strong></td>
          <td align="left" class="style1">
            <asp:DropDownList ID="ddlCity" runat="server" 
                  Width="401px" AutoPostBack="false" style="margin-left: 9px">
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="rfv5" runat="server" 
                ErrorMessage="please Select City" ControlToValidate="ddlCity" 
                ValidationGroup="career_feedback" InitialValue="select city">*</asp:RequiredFieldValidator>
         
           </td>
        </tr>
        <tr>
          <td height="86" align="right" valign="top">
           <span class="list">Submit Your Feedback</span></td>
          <td align="center" class="style3">&nbsp;</td>
          <td height="86" align="left" >
            <asp:TextBox ID="txtfeedback" runat="server" TextMode="MultiLine" 
                 Width="400px" Height="120px" style="margin-left: 9px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfv6" runat="server" 
                ErrorMessage="please enter Your Feedback" ControlToValidate="txtfeedback" 
                ValidationGroup="career_feedback">*</asp:RequiredFieldValidator>
          </td>
        </tr>
        <tr>
         <td height="27" colspan="3" style="padding-top:4px;" align="center">
          <asp:ImageButton ID="btnSubmit" runat="server" ImageUrl="images/career-submit.png" AlternateText="submit"
               onclick="btnSubmit_Click" ValidationGroup="career_feedback" />
         </td>
        </tr>
        <tr>
          <td colspan="3" align="right">&nbsp;</td>
        </tr>
        <tr align="center">
          <td>
           <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
               ShowMessageBox="True" ShowSummary="False" ValidationGroup="career_feedback" />
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
 <aa4:bottomcontent ID="bottomcontent" runat="server" />
</div>
<div class="footer" align="center" style="padding-top:5px; " >
   <aa10:footer1 ID="f1" runat="server" />
   <aa11:footer2 ID="f2" runat="server" />
 </div>
 </div>
<script type="text/javascript">
<!--
swfobject.registerObject("FlashID");
//-->
</script>
 </form>
</body>
</html>
