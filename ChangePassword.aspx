<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ChangePassword.aspx.cs" Inherits="ChangePassword" %>
<%@ Register Src="usercontrols/BottomContent.ascx" TagName="bottomcontent" TagPrefix="aa4" %>
<%@ Register Src="usercontrols/BottomMidContent.ascx" TagName="bottomMidcontent" TagPrefix="aa5" %>
<%--<%@ Register Src="usercontrols/bottomimage.ascx" TagName="bottomimg" TagPrefix="aa6" %>--%>
<%@ Register Src="usercontrols/SearchNew.ascx" TagName="SearchNew" TagPrefix="New" %>
<%@ Register Src="usercontrols/small_logo.ascx" TagName="logo" TagPrefix="S_logo" %>
<%@ Register Src="usercontrols/Search.ascx" TagName="catag" TagPrefix="aa6" %>
<%@ Register Src="usercontrols/footer1.ascx" TagName="footer1" TagPrefix="aa10" %>
<%@ Register Src="usercontrols/footer2.ascx" TagName="footer2" TagPrefix="aa11" %>
<%@ Register Src="usercontrols/signin.ascx" TagName="signin" TagPrefix="aa1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>Change Password Page | Justcalluz</title>
<link href="css/style.css" rel="stylesheet" type="text/css" />
<link href="css/inner_style.css" rel="Stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
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
 <aa6:catag ID="uye" runat="server" />
</div>
<div class="content" style="padding:0; margin:0;">
<div class="content_innerleft">&nbsp;</div>
<div class="content_innermid">
<div class="contentmid_boxtop"><a href="Default.aspx" style="text-decoration:none;color:White">
  Home&gt;&gt;</a><asp:Label ID="Label5"
      runat="server" Text="Change Password"></asp:Label></div>
<div class="contentmid_boxmid">
<table width="100%" border="0" cellpadding="0" cellspacing="0" align="center">
<tr>
<td valign="top" align="center">
<table border="0" width="100%">
   <tr>
        <td colspan="3" align="center" class="headings" valign="top">
            Change Password
        </td>
   </tr>
   <tr>
        <td colspan="3"> 
            <asp:Label ID="lblmsg" runat="server" ForeColor="Red" ></asp:Label>
            <asp:Label ID="lblerror" runat="server" Height="17px" Width="246px" ForeColor="Red"></asp:Label>
        </td>
    </tr>
      <tr>
      <td class="sub_menu" width="45%" align="right" style="padding-right:10px">
        <asp:Label ID="email" runat="server" Text="Email ID "></asp:Label>
      </td>
      <td width="5%"><strong>:</strong></td>
      <td class="side_menu" height="20px" width="50%">              
        <asp:Label ID="lblemail" runat="server" CssClass="data" Width="164px" ValidationGroup="r1"></asp:Label>
      </td>
    </tr>                
    <tr>
        <td colspan="3" height="10px"></td>
    </tr>
    <tr>
      <td class="sub_menu" align="right" style="padding-right:10px">
        <asp:Label ID="Label4" runat="server" Text="Mobile Number "></asp:Label>
      </td>
      <td><strong>:</strong></td>
      <td class="side_menu" height="20px">              
        <asp:Label ID="lblmob" runat="server" CssClass="data" Width="164px" ValidationGroup="r1"></asp:Label>
      </td>
    </tr>                
    <tr>
        <td colspan="3" height="10px"></td>
    </tr>
    <tr>
      <td class="sub_menu" align="right">
          <asp:Label ID="lbloldpwd" runat="server" Text="Old Password "></asp:Label>
          <asp:Label ID="Label1" runat="server" Text="*" ForeColor="Red"></asp:Label>
      </td>
      <td><strong>:</strong></td>
      <td class="side_menu" height="10px">
        <asp:TextBox ID="oldpassword" runat="server" CssClass="data" Width="164px" TextMode="Password" ValidationGroup="r1"></asp:TextBox>
          &nbsp;<asp:RequiredFieldValidator 
              ID="rfvoldpwd" runat="server" ControlToValidate="oldpassword" ErrorMessage="*" 
              Font-Bold="True" Font-Size="Smaller" Width="7px" ValidationGroup="ChangePWDgroup"></asp:RequiredFieldValidator>
      </td>
    </tr>
    <tr>
        <td colspan="3" height="10px"></td>
    </tr>
    <tr>
        <td class="sub_menu" align="right">
            <asp:Label ID="lblnewpwd" runat="server" Text="New Password "></asp:Label>
            <asp:Label ID="Label2" runat="server" Text="*" ForeColor="Red"></asp:Label>
        </td>
        <td><strong>:</strong></td>
        <td class="side_menu" height="10px">
          <asp:TextBox ID="newpassword" runat="server" CssClass="data" Width="164px" TextMode="Password" ValidationGroup="r1"></asp:TextBox>
          <asp:RequiredFieldValidator ID="rfvnewPWD" runat="server" ControlToValidate="newpassword"
          ErrorMessage="*" Font-Bold="True" Font-Size="Smaller" 
                ValidationGroup="ChangePWDgroup"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td colspan="3" height="10px"></td>
    </tr>
    <tr>
        <td class="sub_menu" align="right">
            <asp:Label ID="lblcnfpwd" runat="server" Text="Confirm Password "></asp:Label>
            <asp:Label ID="Label3" runat="server" Text="*" ForeColor="Red"></asp:Label>
        </td>
        <td><strong>:</strong></td>
        <td class="side_menu">
            <asp:TextBox ID="confirmpassword" runat="server" CssClass="data" Width="164px" TextMode="Password" ValidationGroup="r1"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvConPWD" runat="server" ControlToValidate="confirmpassword"
               ErrorMessage="*" Font-Bold="True" Font-Size="Smaller" 
                ValidationGroup="ChangePWDgroup"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td height="10px" colspan="3"></td>
    </tr>
    <tr>
      <td colspan="3" align="center"><label> </label>
          <div align="center">
              
              <asp:Button ID="btnSubmitChangePWD" runat="server" Text="Change Password" 
                  onclick="btnSubmitChangePWD_Click" ValidationGroup="ChangePWDgroup" />
              &nbsp;&nbsp;<asp:Button ID="btnCancel" runat="server" Text="Cancel" 
                  onclick="btnCancel_Click" />
          </div>
      </td>
    </tr>
    <tr>
        <td colspan="3">&nbsp;</td>
    </tr>
</table>
<!--end of content-->
</td>
</tr>
</table>
</div>
<div class="contentmid_boxbottam"></div>
</div>
<div class="content_innerright">&nbsp;</div>
</div>
<div class="content_midbootam" >
<aa5:bottomMidcontent ID="mid1" runat="server" />
</div>
<div class="content_bootam_center">
<aa4:bottomcontent ID="bottomcontent1" runat="server" />
</div>
<div class="footer" align="center" style="padding-top:5px">
    <aa10:footer1 ID="footer1" runat="server" />
 <aa11:footer2 ID="footer2" runat="server" />
</div>
</div>
</form>
</body>
</html>
