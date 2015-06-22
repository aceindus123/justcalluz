<%@ Page Language="C#" AutoEventWireup="true" CodeFile="signin.aspx.cs" Inherits="signin" %>
<%@ Register Src="usercontrols/signin.ascx" TagName="signin" TagPrefix="aa1" %>
<%@ Register Src="usercontrols/SearchNew.ascx" TagName="newsearch" TagPrefix="nsearch"%><%@ Register Src="usercontrols/Search.ascx" TagName="catag" TagPrefix="aa6" %>
<%@ Register Src="usercontrols/footer1.ascx" TagName="footer1" TagPrefix="aa10" %>
<%@ Register Src="usercontrols/footer2.ascx" TagName="footer2" TagPrefix="aa11" %>
<%@ Register Src="usercontrols/BottomContent.ascx" TagName="bottomcontent" TagPrefix="aa4" %>
<%@ Register Src="usercontrols/BottomMidContent.ascx" TagName="bottomMidcontent" TagPrefix="aa5" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%@ Register Src="usercontrols/SponsoredLinks.ascx" TagName="Splinks" TagPrefix="aa3" %>
<%@ Register Src="usercontrols/Search.ascx" TagName="catageories" TagPrefix="aa6" %>
<%@ Register Src="usercontrols/small_logo.ascx" TagName="logosmall" TagPrefix="lgsmall" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>:: Justcalluz :: Signin page</title>
<link href="css/style.css" rel="stylesheet" type="text/css" />
<link href="css/inner_style.css" rel="Stylesheet" type="text/css" />
</head>
<body>
<form id="form1" runat="server">
<asp:ScriptManager ID="ScriptManager1" runat="server">
</asp:ScriptManager>
<div class="layout">
<%--<div class="signin">
<aa1:signin ID="SignIn1" runat="server" />
</div>--%>
<div class="header" style="padding-top:5px;">
<%--<div class="header_top"></div>--%>
<div class="header_logo">
<lgsmall:logosmall ID="lglogo" runat="server" />
</div>
<div class="header_search">
<nsearch:newsearch ID="search" runat="server" />
</div>
</div>
<div class="category_box">
<aa6:catageories ID="dff" runat="server" />
</div>
<!-- staart the Content-->
<div class="content" style="padding:0; margin:0;">
<div class="content_innerleft" style="width:100%">
<asp:Panel ID="PnlLoginPage" runat="server" DefaultButton="imgBtnLogIn">
  <table width="100%" border="0">
    <tr>
      <td width="57%"><img src="images/seekers_login.jpg" width="425" height="314" /></td>
      <td width="42%">
      <table width="370" border="0" style="background:url(images/employer%27s_login.png) top no-repeat; width:384px; height:275px">
      <tr><td>
                <asp:Label ID="lblMessage" runat="server"></asp:Label>
      </td></tr>
 
    <tr>
      <td height="43" align="center" valign="top"><asp:TextBox ID="txtEmail" runat="server" CssClass="employe_input"></asp:TextBox>
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                      ErrorMessage="Please enter Email Id" ControlToValidate="txtEmail" 
                      ValidationGroup="Register">*</asp:RequiredFieldValidator>
                  <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
                      ErrorMessage="Please enter valid emal id" ControlToValidate="txtEmail" 
                      ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
                      ValidationGroup="Register">*</asp:RegularExpressionValidator>
                      <cc1:TextBoxWatermarkExtender ID="username" runat="server" TargetControlID="txtEmail" WatermarkText="Email Id"></cc1:TextBoxWatermarkExtender>
                      </td>
    </tr>
    <tr>
      <td height="42" align="center" valign="top" style="padding-left:8px"><asp:TextBox ID="txtMob" runat="server" MaxLength="11" CssClass="employe_input"></asp:TextBox>
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                      ControlToValidate="txtMob" ErrorMessage="Please enter Mobile number" 
                      ValidationGroup="Register">*</asp:RequiredFieldValidator>
                      <asp:RangeValidator ID="RangeValidator1" runat="server" 
                            ErrorMessage="The Mobile number should start with zero" MinimumValue="0" ControlToValidate="txtMob" 
                            MaximumValue="1" ValidationGroup="Register">*</asp:RangeValidator>
                  <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                      ErrorMessage="Please enter mobile no. of 11 digits only" 
                      ControlToValidate="txtMob" ValidationExpression="\d{11}" 
                      ValidationGroup="Register">*</asp:RegularExpressionValidator>
                      <cc1:TextBoxWatermarkExtender ID="mobile" runat="server" TargetControlID="txtMob" WatermarkText="Mobile Number"></cc1:TextBoxWatermarkExtender>
                      </td>
    </tr>
    <tr>
      <td height="32" align="center" valign="top" style="padding-right:10px"><asp:TextBox ID="txtPwd" runat="server" TextMode="Password" CssClass="employe_input"></asp:TextBox>
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                      ControlToValidate="txtPwd" ErrorMessage="Please enter password" 
                      ValidationGroup="Register">*</asp:RequiredFieldValidator>
                      <cc1:TextBoxWatermarkExtender ID="password" runat="server" WatermarkText=".........." TargetControlID="txtPwd"></cc1:TextBoxWatermarkExtender>
                      </td>
    </tr>
  <%--  <tr>
      <td height="29" style="padding-left:60px"><input type="checkbox" />&nbsp;&nbsp;Remember me</td>
    </tr>--%>
    <tr>
      <td height="25" style="padding-top:20px">
      <table width="100%" border="0">
        <tr>
          <td width="76%" height="32" valign="top" style="padding-left:18px; padding-top:4px;"><font color="#FFFFFF">
              Don’t have an account? <a href="<%$RouteUrl:RouteName=register %>" style="color:#22fc4b" runat="server"><b>
              Register!</b></a></font><br />
            <a href="<%$RouteUrl:RouteName=Password %>" style="color:#FFF; text-decoration:underline" runat="server">Forgot your 
              password?</a></td>
          <td width="24%" style="padding-top:10px; padding-right:10px;" valign="top"><asp:ImageButton ID="imgBtnLogIn" runat="server" 
                      ImageUrl="images/enter.png" ValidationGroup="Register" OnClick="imgBtnLogIn_Click"/></td>
        </tr>
      </table></td>
    </tr>
    <tr><td height="3px">
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
            ShowMessageBox="True" ShowSummary="False" ValidationGroup="Register" />
       </td></tr>
  </table></td>
      <td width="1%">&nbsp;</td>
    </tr>
  </table>
 </asp:Panel> 
</div>
</div>
<div class="content_bootam_center"></div>
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
var TabbedPanels1 = new Spry.Widget.TabbedPanels("TabbedPanels1");
//-->
</script>
    </form>
</body>
</html>
