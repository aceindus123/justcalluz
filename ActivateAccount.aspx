<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ActivateAccount.aspx.cs" Inherits="ActivateAccount" %>
<%@ Register Src="usercontrols/signin.ascx" TagName="signin" TagPrefix="aa1"  %>
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
    <title>Activate Account Page | Justcalluz</title>
    <link href="style.css" rel="stylesheet" type="text/css" />
    <link href="css/inner_style.css" rel="Stylesheet" type="text/css" />
    <script src="js/statesopt.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
<div class="layout">
<!--begin of buttons-->
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
<div class="content_innermid">
<table width="994" border="1" cellpadding="0" cellspacing="0" align="center" >
<tr>
<td valign="top">
<table width="100%" border="0">
   <tr><td>Activate Account :</td></tr>
   <tr>
     <td align="left" valign="middle">&nbsp;</td>
   </tr>
    <tr>
      <td align="center" valign="middle">
          <table width="100%" border="0" cellspacing="3" cellpadding="0">
            <tr>
                <td colspan="2"><asp:Label ID="lblMessage" runat="server" CssClass="ErrMsg"></asp:Label></td>
            </tr>
            <tr>
                <td align="center" colspan="2">
                    Welcome To Just Call Uz, Please Click below to Activate your Account and Enjoy our services.
                </td>
            </tr>
            <tr>
                <td height="8" colspan="2" align="center">
                    <br />
                </td>
            </tr>
            <tr>
                <td height="8" colspan="2" align="center">
                <asp:Button ID="btnActivate" Text="Activate Your Account" runat="server" OnClick="btnActivate_Click" />
                </td>
            </tr>
            <tr>
               <td colspan="2" class="lables">
                   
                </td>
            </tr>
            
        </table>
          <br /></td>
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
