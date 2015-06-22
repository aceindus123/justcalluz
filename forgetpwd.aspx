<%@ Page Language="C#" AutoEventWireup="true" CodeFile="forgetpwd.aspx.cs" Inherits="forgetpwd" %>
<%@ Register Src="usercontrols/signin.ascx" TagName="signin" TagPrefix="aa1"  %>
<%@ Register Src="usercontrols/catageories.ascx" TagName="catag" TagPrefix="aa6" %>
<%@ Register Src="usercontrols/footer1.ascx" TagName="footer1" TagPrefix="aa10" %>
<%@ Register Src="usercontrols/footer2.ascx" TagName="footer2" TagPrefix="aa11" %>
<%@ Register Src="usercontrols/SearchNew.ascx" TagName="SearchNew" TagPrefix="New" %>
<%@ Register Src="usercontrols/small_logo.ascx" TagName="logo" TagPrefix="S_logo" %>
<%@ Register Src="usercontrols/BottomContent.ascx" TagName="bottomcontent" TagPrefix="aa4" %>
<%@ Register Src="usercontrols/BottomMidContent.ascx" TagName="bottomMidcontent" TagPrefix="aa5" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
 <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>Justcalluz - Forget Password</title>
<link href="style.css" rel="stylesheet" type="text/css" />
<link href="css/inner_style.css" rel="Stylesheet" type="text/css" />
<link href="css/Style.css" rel="Stylesheet" type="text/css" />

</head>
<body>
<form id="f1" runat="server" >
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
<!--begin of table-->
<!--begin of buttons-->
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
<%-- <table width="960" border="0" bordercolor="#003366" cellpadding="0" cellspacing="0" align="center">
<tr>
<td>--%>
<div class="content" style="padding:0; margin:0;">
<div class="Content_innermid">
<table width="927" border="0" cellpadding="0" cellspacing="0" align="center"  style="margin-left:20px;">
<tr>
<td valign="top">
 <table width="870" border="0" cellpadding="0" cellspacing="0" style="margin-left:20px;"  >
 <tr><td height="15"></td></tr>
 <tr><td><b>Welcome to Justcalluz</b></td></tr><tr><td height="50"></td></tr>
 </table>
   <div align="center" style="margin-top:30px;">
    <table border="1" style="border-color:#cc9966"  cellspacing="0" cellpadding="0" height="250" align="center">
        <tr>
        <td colspan="3" valign="top" align="center"><b>Forgot Password</b>
        
        <table>
        <tr><td height="30"></td></tr>
        <tr><td colspan="3">
            <asp:Label ID="lblMsg" runat="server"></asp:Label>
        </td></tr>
        <tr><td height="30"></td></tr>
        <tr><td align="right">
            <asp:Label ID="Label2" runat="server" Text="Email Id"></asp:Label>
        </td>
        
        <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
        <td>
            <asp:TextBox ID="txtEmail" runat="server" Width="160px" Height="25px"></asp:TextBox>
            <asp:RegularExpressionValidator ID="regemail" runat="server" ControlToValidate="txtEmail" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ValidationGroup="txtEmail" ErrorMessage="enetr valid email id">*</asp:RegularExpressionValidator>
           
        </td>
        </tr>        
        <tr><td height="30" colspan="3"><asp:CustomValidator ID="custvalAnyone" runat="server" 
                ErrorMessage="Please enter either Email Id or Mobile number only" 
                ControlToValidate="txtEmail" ValidationGroup="ForgetPwd" 
                onservervalidate="custvalAnyone_ServerValidate" ValidateEmptyText="true" Font-Size="Small"></asp:CustomValidator></td></tr>
        <tr><td align="right">
            <asp:Label ID="Label1" runat="server" Text="Mobile Number"></asp:Label>
        </td>
        
        <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
        <td>
            <asp:TextBox ID="txtMobNo" runat="server" Width="160px" Height="25px" MaxLength="10" onkeypress="return onlyNos(event,this);"></asp:TextBox>
            <asp:RegularExpressionValidator ID="regmobno" runat="server" ControlToValidate="txtMobNo" ValidationGroup="ForgetPwd" ValidationExpression="^[01]?[- .]?(\([1-9]\d{2}\)|[1-9]\d{2})[- .]?\d{3}[- .]?\d{4}$"  ErrorMessage="please enter mobile number">*</asp:RegularExpressionValidator>
        </td>
        </tr>
        
        <tr>
        <td height="30"></td>
        </tr>
        <tr>
        <td align="center" colspan="3">
                  <asp:ImageButton ID="imgBtnSubmitForgetPassword" AlternateText="submitPassword" 
                      src="images/button3.jpg" runat="server" ValidationGroup="ForgetPwd" onclick="imgBtnSubmitForgetPassword_Click" 
                      /></td>
        </tr>                
        </table>
      </td></tr>
     </table>
        </div>
 </td>
</tr>
</table>
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
<%--<aa10:footer1 ID="sdsa" runat="server" />
   <aa11:footer2 ID="poshv" runat="server" />--%>
<%--</td>
</tr>
</table>--%>
</div>
  </form>  
</body>
</html>