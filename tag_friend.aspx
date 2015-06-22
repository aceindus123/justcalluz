<%@ Page Language="C#" AutoEventWireup="true" CodeFile="tag_friend.aspx.cs" Inherits="tag_friend" %>
<%@ Register Src="usercontrols/footer1.ascx" TagName="footer1" TagPrefix="aa10" %>
<%@ Register Src="usercontrols/footer2.ascx" TagName="footer2" TagPrefix="aa11" %>
<%@ Register Src="usercontrols/BottomContent.ascx" TagName="bottomcontent" TagPrefix="aa4" %>
<%@ Register Src="usercontrols/BottomMidContent.ascx" TagName="bottomMidcontent" TagPrefix="aa5" %>
<%@ Register Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" TagPrefix="cc3"  %>
<%@ Register Src="usercontrols/signin.ascx" TagName="signin" TagPrefix="aa1" %>
<%@ Register Src="usercontrols/Search.ascx" TagName="catag" TagPrefix="aa6" %>
<%@ Register Src="usercontrols/SearchNew.ascx" TagName="SearchNew" TagPrefix="New" %>
<%@ Register Src="usercontrols/small_logo.ascx" TagName="logo" TagPrefix="S_logo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<%--<title>:: Just Calluz :: Tag Your Friend</title>--%>
<title>Register - JustCalluz | Sign Up & Tag Your Friends to Access Their Reviews</title>
<meta name='Title' content='Register - JustCalluz | Sign Up & Tag Your Friends to Access Their Reviews' />
<meta name='description' content='Register on JustCalluz for free and tag your friends to know about their reviews and ratings for Movies, Events, Restaurants, Pubs etc. Simply enter your contact number to start the process.' />
<meta name='keywords' content='justcalluz registration, justcalluz sign up, justcalluz registration, justcalluz register, justcalluz free registeration, justcalluz tagging, local search, yellow pages listing, business listing' />
		
<link href="css/inner_style.css" rel="stylesheet" type="text/css" />
<link href="css/style.css" rel="Stylesheet" type="text/css" />
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
<!-- start The Content-->
<div class="content" style="padding:0; margin:0;">
<div class="content_innermid" style="width:100%;">
  <table width="100%" border="0">
    <tr>
       <td height="30"><strong><a href="Default.aspx">Home</a></strong> &gt; Register</td>
    </tr>
    <tr>
      <td align="left"><div class="tag">
        <table width="100%" border="0">
          <tr>
            <td width="45%" rowspan="4">&nbsp;</td>
            <td width="55%" height="121">&nbsp;</td>
          </tr>
          <tr>
            <td align="center"><strong>Enter your mobile number below</strong></td>
          </tr>
          <tr>
            <td ><table width="100%" border="0">
              <tr>
                <td width="77%" align="center"><asp:TextBox ID="txtmob" runat="server" Height="30px" Width="360px" Font-Bold="true" Font-Size="X-Large" MaxLength="11"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator18" runat="server" 
          ControlToValidate="txtmob" ErrorMessage="please enter the mobile number" 
          ValidationGroup="tagfriend">*</asp:RequiredFieldValidator>
            <asp:RangeValidator ID="RangeValidator1" runat="server" 
          ErrorMessage="Number must start with 0" ControlToValidate="txtmob"  MaximumValue="1" MinimumValue="0" 
          ValidationGroup="tagfriend">*</asp:RangeValidator>
          <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" 
          ControlToValidate="txtmob" ErrorMessage="mobile number must be numbers only" 
          ValidationExpression="\d{11}" ValidationGroup="tagfriend">*</asp:RegularExpressionValidator>
                </td>
                  
                <td width="23%" valign="top"><asp:ImageButton ID="img_go" runat="server" AlternateText="GoButton" 
                        ImageUrl="images/go.jpg" onclick="img_go_Click" ValidationGroup="tagfriend" />
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
                        ShowMessageBox="True" ShowSummary="False" ValidationGroup="tagfriend" />   
                        </td>
                </tr>
                <cc3:TextBoxWatermarkExtender ID="textwater" runat="server" TargetControlID="txtmob" WatermarkText="Eg : 09848022338" WatermarkCssClass="water"></cc3:TextBoxWatermarkExtender>
            </table></td>
          </tr>
          <tr>
            <td height="60" align="center"><strong>
                FAQ of tagging your friends,  <a href="Faqs_taggedfriends.aspx"  class="click2">FAQ </a></strong></td>
          </tr>
        </table>
      </div></td>
    </tr>
    </table>
</div>
</div>
<!-- end of the content-->
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


    </form>
</body>
</html>
