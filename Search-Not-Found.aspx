<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Search-Not-Found.aspx.cs" Inherits="Search_Not_Found" %>
<%@ Register Assembly="MSCaptcha" Namespace="MSCaptcha" TagPrefix="cc1" %>
<%@ Register Src="usercontrols/signin.ascx" TagName="signin" TagPrefix="aa1" %>
<%@ Register Src="usercontrols/Search.ascx" TagName="catag" TagPrefix="aa6" %>
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
<title>Search Not Found | Justcalluz</title>
<meta name='Title' content='Search Not Found | JustCalluz' />
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
<!-- staart the Content-->
<div class="content" style="padding:0; margin:0;">
<div class="content_innermid" style="width:79%">
<table width="100%" border="0">
  
  <tr>
    <td class="select_menu" style="padding-left:3px;"><a href="<%$RouteUrl:RouteName=HomeRoute%>" runat="server">Home</a>&gt;search 
        not found</td>
  </tr>
  <tr>
    <td style="background:url(images/event_send2.png) no-repeat" height="39" valign="middle"><table width="100%" border="0">
  <tr>
    <td width="9%">&nbsp;</td>
    <td width="91%" ><span class="bottam">search not found</span><%--<font class="select_menu" style="padding-left:250px;"><font color="#ff7100" class="star">*</font>denotes 
        mandatory fields</font>--%></td>
    </tr>
</table>
</td>
  </tr>
   <tr>
    <td>
    <table id="tbldata" width="100%" border="0" runat="server">
    <tr>
    <td style="font-family:verdana,geneva,sans-serif;font-size:12px;line-height:18px"><table width="100%" border="0">
    <tr><td>
        <asp:Label ID="lblMessage" runat="server"></asp:Label>
    <p><b>Your search for - "<asp:Label ID="lblcat" runat="server"></asp:Label>" located in "<asp:Label ID="lblcity" runat="server"></asp:Label>" - did not match any records.</b></p>
    </td></tr>
    <tr><td><p>Dear User,</p></td></tr>
    <tr><td><p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;	As you read this, our National Database is getting updated with more and more information.It is our constant endeavor that we enrich our database with all that you seek. So keep looking out for more!
	</p></td></tr>
	<tr><td>&nbsp;</td></tr>
	<tr><td><p>JustCallUz Team.</p><br /></td></tr>
	<tr><td><p><b>Search Tips:</b></p></td></tr>
	<tr><td>
	<ul style="padding-left:25px">
	    <li>Check for spelling mistakes in the search keywords.</li>
	    <li>Try using alternate terms (synonyms) for your search keywords.</li>
	    <li>Try specific product and/or service names.</li>
	    <li>Try more keywords. </li>
	</ul><br /><p><b>OR</b></p>
	</td></tr>
	<tr><td>&nbsp;</td></tr>
	<tr><td><p><b>Please submit the form telling us exactly what you were searching for?</b></p></td></tr>
	</table>
	</td>
    </tr>
    </table>
    </td>
    </tr>
  
   <tr><td align="left"><font class="select_menu" style="padding-left:8px;"><font color="#ff7100" class="star">*</font>denotes 
            mandatory fields</font></td></tr>
  
  
  <tr>
    <td><table width="100%" border="0">
  <tr>
    <td width="100%" height="28" valign="top" >
      <table width="100%" border="0">
          <tr>
            <td width="19%" height="37" align="right"><font color="#ff7100" class="star">*</font><span class="list">city </span></td>
            <td width="3%" align="center"><strong>:</strong></td>
            <td width="78%" height="37" align="left"><span class="row">
                <asp:DropDownList ID="ddlCity" runat="server" Width="200px" Enabled="false">
                </asp:DropDownList>
                </span></td>
          </tr>
          <tr>
            <td height="36" align="right"><span class="list">located In</span></td>
            <td align="center"><strong>:</strong></td>
            <td height="36" align="left"><span class="row">
                <asp:TextBox ID="txtlocation" runat="server" Width="200px" onkeypress="return Alphabets(event);"></asp:TextBox>
            </span></td>
          </tr>
          <tr>
            <td height="37" align="right"><font color="#ff7100" class="star">*</font><span class="list">your 
                name</span></td>
            <td align="center"><strong>:</strong></td>
            <td height="37" align="left"><span class="row">
                <asp:TextBox ID="txtname" runat="server" Width="200px" onkeypress="return Alphabets(event);"></asp:TextBox> 
                 <asp:RequiredFieldValidator ID="rfName" runat="server" 
            ErrorMessage="please enter Name" ControlToValidate="txtname" ValidationGroup="search" Text="*"></asp:RequiredFieldValidator>
            </span></td>
          </tr>
          <tr>
            <td height="37" align="right"><font color="#ff7100" class="star">*</font><span class="list">your 
                email</span></td>
            <td align="center"><strong>:</strong></td>
            <td height="37" align="left"><span class="row">
                <asp:TextBox ID="txtemail" runat="server" Width="200px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfEmail" runat="server" 
            ErrorMessage="please enter Email Id" ControlToValidate="txtemail" Text="*" ValidationGroup="search"></asp:RequiredFieldValidator>                
            <asp:RegularExpressionValidator ID="revEmail" runat="server" 
                    ErrorMessage="Please enter valid email address" ControlToValidate="txtemail" 
                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
                    ValidationGroup="search">*</asp:RegularExpressionValidator>
            </span></td>
          </tr>
          <tr>
            <td height="37" align="right"><font color="#ff7100" class="star">*</font><span class="list">company 
                name</span></td>
            <td align="center"><strong>:</strong></td>
            <td height="37" align="left"><span class="row">
                <asp:TextBox ID="txtcompname" runat="server" Width="200px" onkeypress="return Alphabets(event);"></asp:TextBox>
                 <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
            ErrorMessage="please enter company Name" ControlToValidate="txtcompname" ValidationGroup="search" Text="*"></asp:RequiredFieldValidator>
            </span></td>
          </tr>
          <tr>
            <td height="37" align="right"><font color="#ff7100" class="star">*</font><span class="list"> 
                product/ services</span></td>
            <td align="center"><strong>:</strong></td>
            <td height="37" align="left"><span class="row">
                <asp:TextBox ID="txtproduct" runat="server" Width="200px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
            ErrorMessage="please enter product /services" ControlToValidate="txtproduct" ValidationGroup="search" Text="*"></asp:RequiredFieldValidator>
            
            </span></td>
          </tr>
          <tr>
            <td height="89" align="right"><span class="list">comment</span></td>
            <td align="center"><strong>:</strong></td>
            <td height="89" align="left">
                <asp:TextBox ID="txtcomments" runat="server" TextMode="MultiLine" Rows="3" Columns="30" Width="200px"></asp:TextBox>
             </td>
          </tr>
          <tr>
            <td height="38" align="right">
             <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
      <ContentTemplate> 
           <cc1:CaptchaControl ID="ccjoin" runat="server" BackColor="AntiqueWhite" 
        CaptchaBackgroundNoise="None" CaptchaHeight="35" CaptchaLength="4" 
        CaptchaWidth="90" CaptchaLineNoise="None" CaptchaMinTimeout="5" 
        CaptchaMaxTimeout="200" Width="90px" />
       </ContentTemplate>
       </asp:UpdatePanel>
       </td> 
            <td align="center"><strong>:</strong></td>
            <td align="left" height="37">
            <asp:TextBox ID="txtvid" runat="server" Width="200px"></asp:TextBox></td>
          </tr>
          <tr><td height="37" align="right"> 
            <asp:Button ID="btnRefreshCapcha" runat="server" Text="Refresh Image" 
                     onclick="btnRefreshCapcha_Click" />
          </td>
          <td>&nbsp;</td>
          <td>&nbsp;</td>
          </tr>
          <tr>
            <td height="25">&nbsp;</td>
            <td>&nbsp;</td>
            <td align="left"><table width="100%" border="0">
              <tr>
                <td width="10%" height="30">&nbsp;</td>
                <td width="90%">
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" ValidationGroup="search" ShowSummary="false" ShowMessageBox="true" />
                    <asp:ImageButton ID="imgsubmit" AlternateText="SubmitButton" runat="server" src="images/submit.png" ValidationGroup="search" onclick="imgsubmit_Click" />
                </td>
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
<%--<div class="content_right" style="width:20%">
  <table width="100%" border="0">
    <tr>
      <td  align="center"><img src="images/image_gallery.gif" width="160" height="500" /></td>
    </tr>
    <tr>
      <td></td>
    </tr>
   
  </table>
</div>--%>
 <div class="content_innerright">
<div class="contentbox_top">Sponsor Ads</div>
<div class="contentbox_mid">
  <table width="100%" border="0">
    <tr>
      <td width="100%" valign="top">
      <img src="images/image_gallery.gif" alt="image_gallery" width="175" height="600" />
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
<script type="text/javascript">
<!--
swfobject.registerObject("FlashID");
//-->
</script>
    </form>
</body>
</html>
