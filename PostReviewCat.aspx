<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PostReviewCat.aspx.cs" Inherits="PostReviewCat" %>
<%@ Register Src="usercontrols/signin.ascx" TagName="signin" TagPrefix="aa1" %>
<%@ Register Src="usercontrols/footer1.ascx" TagName="footer1" TagPrefix="aa10" %>
<%@ Register Src="usercontrols/footer2.ascx" TagName="footer2" TagPrefix="aa11" %>
<%@ Register Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" TagPrefix="cc3"  %>
<%@ Register Src="usercontrols/Search.ascx" TagName="catag" TagPrefix="cat" %>
<%@ Register Src="usercontrols/SponsoredLinks.ascx" TagName="Splinks" TagPrefix="aa3" %>
<%@ Register Src="usercontrols/BottomMidContent.ascx" TagName="Contentmid" TagPrefix="bcm" %>
<%@ Register Src="usercontrols/BottomContent.ascx" TagName="Bottomcontent" TagPrefix="bcon" %>
<%@ Register Src="usercontrols/SearchNew.ascx" TagName="SearchNew" TagPrefix="New" %>
<%@ Register Src="usercontrols/small_logo.ascx" TagName="logo" TagPrefix="S_logo" %>

<%@ Import Namespace="System.Data" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>:: Justcalluz ::Post Review for Categories Page</title>
<link href="css/style.css" rel="stylesheet" type="text/css" />
<link href="css/inner_style.css" rel="Stylesheet" type="text/css" />
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
<aa1:signin ID="SignIn1" runat="server" />
</div>
<div class="header">
<%--<div class="header_top"></div>--%>
<div class="header_logo"><S_logo:logo ID="logo" runat="server" /></div>
<div class="header_search">
 <New:SearchNew ID="New" runat="server" />
 </div>
 </div>
<div class="category_box">
 <cat:catag ID="uye" runat="server" />
</div>
<!-- staart the Content-->
<div class="content" style="padding:0; margin:0;">
<div class="content_innermid" style="width:79%;">
<table width="100%" border="0">
 <tr>
    <td class="select_menu" style="padding-left:3px;"><a href="<%$RouteUrl:RouteName=HomeRoute%>" style="text-decoration:none" runat="server">Home</a>
    ><asp:Label ID="lblcompany" runat="server"></asp:Label> >
   <span id="breadcrumbSpan">Rate this listing</span></td>
  </tr>
  <tr>
    <td style="background:url(images/event_send2.png) no-repeat" height="39" valign="middle"><table width="100%" border="0">
  <tr>
    <td width="9%">&nbsp;</td>
    <td width="91%" class="bottam">Rate -<asp:Label ID="lblCompanyName" runat="server" BackColor="#ECCEF5"></asp:Label></td>
    </tr>
</table>
</td>
  </tr>
  <tr>
    <td ><table width="100%" border="0">
  <tr>
    <td width="100%" height="28" valign="top" ><table width="100%" border="0">
          <tr>
            <td width="19%" height="25" align="right" valign="top" ><font color="#ff7100" class="star">*</font><span class="list">Rate it</span></td>
            <td width="3%" align="center" valign="top"><strong>:</strong></td>
            <td width="78%" height="30" align="left"><table width="100%" border="0">
              <tr>
                <td width="4%">                
                 <asp:RadioButton ID="radBtnExcellent" runat="server" GroupName="Rating" Checked="true"/>
               </td>
                <td width="16%" height="25">Excellent</td>
                <td width="80%">&nbsp;</td>
              </tr>
              <tr>
                <td><asp:RadioButton ID="radBtnVeryGud" runat="server" GroupName="Rating" /></td>
                <td height="25">Very Good </td>
                <td>&nbsp;</td>
              </tr>
              <tr>
                <td><asp:RadioButton ID="radBtnGud" runat="server" GroupName="Rating" /></td>
                <td height="25">Good</td>
                <td>&nbsp;</td>
              </tr>
              <tr>
                <td><asp:RadioButton ID="radBtnAvg" runat="server" GroupName="Rating" /></td>
                <td height="25">Average </td>
                <td>&nbsp;</td>
              </tr>
              <tr>
                <td><asp:RadioButton ID="radBtnPoor" runat="server" GroupName="Rating" class="style2" /></td>
                <td height="25">Poor </td>
                <td>&nbsp;</td>
              </tr>
              <tr>
                <td height="25" colspan="3"><span id="ratingErr">
                <%--<asp:CustomValidator ID="radBtnRequired" runat="server" EnableClientScript="true" OnServerValidate="radBtnRequired_ServerValidate" ValidationGroup="PostReview">*</asp:CustomValidator>--%>
            </span></td>
                </tr>
            </table></td>
          </tr>
          <tr>
            <td height="37" align="right"><font color="#ff7100" class="star">*</font><span class="list">Name</span></td>
            <td align="center"><strong>:</strong></td>
            <td height="37" align="left"><span class="row">
              <asp:TextBox ID="txtName" runat="server" onkeypress="return Alphabets(event);"></asp:TextBox>
        
        <asp:RequiredFieldValidator ID="rfvName" runat="server" 
            ErrorMessage="Please enter Name" ControlToValidate="txtName" 
            ValidationGroup="PostReview">*</asp:RequiredFieldValidator>
            </span></td>
          </tr>
          <tr>
            <td height="36" align="right"><font color="#ff7100" class="star">*</font><span class="list">Mobile No</span></td>
            <td align="center"><strong>:</strong></td>
            <td height="36" align="left"><span class="row">
              <asp:TextBox ID="txtmobno" runat="server" MaxLength="11" onkeypress="return onlyNos(event,this);"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvMob" runat="server" 
            ControlToValidate="txtmobno" ErrorMessage="Please enter Mobile Number" 
            ValidationGroup="PostReview">*</asp:RequiredFieldValidator>
              <asp:RegularExpressionValidator ID="Regmobile" runat="server" 
            ControlToValidate="txtmobno" 
            ErrorMessage="Enter Mobile number only ten digits(starting number should starts from 1 to 9 digits)" 
            ValidationExpression="^[01]?[- .]?(\([1-9]\d{2}\)|[1-9]\d{2})[- .]?\d{3}[- .]?\d{4}$" Display="Dynamic"
            ValidationGroup="PostReview"></asp:RegularExpressionValidator>
            <asp:RangeValidator ID="rangvalMob" runat="server" 
                            ErrorMessage="The Mobile number should start with zero" MinimumValue="0" ControlToValidate="txtmobno" 
                            MaximumValue="1" ValidationGroup="PostReview">*</asp:RangeValidator>
            </span></td>
          </tr>
          <tr>
            <td height="37" align="right"><font color="#ff7100" class="star">*</font><span class="list">Email ID</span></td>
            <td align="center"><strong>:</strong></td>
            <td height="37" align="left"><span class="row">
                <asp:TextBox ID="txtemailid" runat="server"></asp:TextBox>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
            ControlToValidate="txtemailid" 
            ErrorMessage="Please enter valid email id Eg: XXX@xx.xxx" 
            ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
            ValidationGroup="PostReview">*</asp:RegularExpressionValidator>
            </span></td>
          </tr>
          <tr>
            <td height="89" align="right" valign="top"><font color="#ff7100" class="star">*</font><span class="list">Review</span></td>
            <td align="center" valign="top"><strong>:</strong></td>
            <td height="89" align="left"><asp:TextBox ID="txtReview" runat="server" TextMode="MultiLine" Columns="50" Rows="5"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvReview" runat="server" 
            ControlToValidate="txtReview" ErrorMessage="Please enter Review" 
            ValidationGroup="PostReview">*</asp:RequiredFieldValidator></td>
          </tr>
           <tr>
            <td height="38" align="right"><span class="list">Upload Your Photo(Optional)</span></td>
           <td align="center"><strong>:</strong></td>
            <td align="left"><span class="row">
              <asp:FileUpload ID="Imgupload" runat="server" />
            </span></td>
          </tr>
          <tr>
            <td height="25">&nbsp;</td>
            <td>&nbsp;</td>
            <td align="left"><table width="100%" border="0">
              <tr>
                <td width="12%" height="30"> 
                <asp:ValidationSummary ID="Valid" runat="server" 
          ValidationGroup="PostReview" ShowMessageBox="True" ShowSummary="False" />
                <asp:ImageButton ID="ImgBtnSubmitReview" runat="server" 
            ImageUrl="../images/button3.jpg" AlternateText="SubmitReviewButton" onclick="ImgBtnSubmitReview_Click" ValidationGroup="PostReview" /></td>
                <td width="88%">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:ImageButton ID="ImgBtnBackReview" AlternateText="BackReviewButton" runat="server" 
            ImageUrl="../images/back.png" onclick="ImgBtnBackReview_Click" /> </td>
              </tr>
            </table></td>
          </tr>
        </table></td>
  </tr>
</table>
</td>
  </tr>

</table>
 </div>
<div class="content_innerright">
<div class="contentbox_top">Sponsor Ads</div>
<div class="contentbox_mid">
  <table width="100%" border="0">
    <tr>
      <td width="100%" valign="top">
     <img src="images/image_gallery.gif" alt="SponserAds" width="175" height="600" /><br />
     </td>
    </tr>
    <tr>
      <td></td>
    </tr>
   
  </table>
</div>
<div class="contentbox_bottam"></div>
</div>
</div>
<div class="content_midbootam" >
<bcm:Contentmid ID="contentmid" runat="server" />
</div>
<div class="content_midbootam" ><table width="100%" border="0">
  <tr>
    <td height="" ></td>
  </tr>
</table>
</div>
<div class="content_bootam_center">
<bcon:Bottomcontent ID="bottomcontent" runat="server" />
</div>
<div class="footer" align="center" style="padding-top:5px; " >
  <aa10:footer1 ID="footer1" runat="server" />
  <aa11:footer2 ID="footer2" runat="server" />
   </div>
</div>
</form>
<script type="text/javascript">
//swfobject.registerObject("FlashID");
</script>
</body>
</html>
