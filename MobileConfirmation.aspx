<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MobileConfirmation.aspx.cs" Inherits="MobileConfirmation" %>
<%@ Register Src="usercontrols/signin.ascx" TagName="signin" TagPrefix="aa1"  %>
<%@ Register Src="usercontrols/Search.ascx" TagName="catag" TagPrefix="aa6" %>
<%@ Register Src="usercontrols/footer1.ascx" TagName="footer1" TagPrefix="aa10" %>
<%@ Register Src="usercontrols/footer2.ascx" TagName="footer2" TagPrefix="aa11" %>
<%@ Register Src="usercontrols/BottomContent.ascx" TagName="bottomcontent" TagPrefix="aa4" %>
<%@ Register Src="usercontrols/BottomMidContent.ascx" TagName="bottomMidcontent" TagPrefix="aa5" %>
<%@ Register Src="usercontrols/SearchNew.ascx" TagName="SearchNew" TagPrefix="New" %>
<%@ Register Src="usercontrols/small_logo.ascx" TagName="logo" TagPrefix="S_logo" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
 <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
   <style type="text/css">
    
.clsPanel legend  
{
color:#cc6600;
font-size:Medium;

}

.clsPanel fieldset
{
border: solid 1px purple;
width:670px;
height:200px;
margin-left:40px;
}

  .clsPanel1 legend  
{
color:#cc6600;
font-size:Medium;

}

.clsPanel1 fieldset
{
border: solid 1px purple;
width:670px;
height:570px;
margin-left:40px;
}

       </style>

<script type="text/javascript" src="js/statesopt.js"></script>
<link href="style.css" rel="stylesheet" type="text/css" />
<link href="css/inner_style.css" rel="Stylesheet" type="text/css" />
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
 <div class="content" style="padding:0; margin:0;border:1px solid #003366;""> 
 <table width="990"  cellpadding="0" cellspacing="0" align="center">
<%-- <tr>
<td style="padding-top:10px; " align="center">
  <!--begin of the content-->
     <asp:Label ID="lblVCode" runat="server" Visible="false"></asp:Label>
<!--end of the content-->
</td>
</tr>--%>
<tr>
<td style="height:100px;width:55%;" align="right">
<asp:Label ID="lblVCode" runat="server" Visible="false"></asp:Label>
  <!--begin of the content-->
     <asp:TextBox ID="txtVerification" runat="server" Height="30px"></asp:TextBox>
     <cc1:TextBoxWatermarkExtender ID="TextBoxWatermarkExtender1" runat="server" TargetControlID="txtVerification" WatermarkText="Enter Verification Code" WatermarkCssClass="water1"></cc1:TextBoxWatermarkExtender>&nbsp;
   
<!--end of the content-->
</td>
<td style="height:100px;width:45%;" align="left">  
   <asp:ImageButton ID="imgBtn" runat="server" ImageUrl="~/images/go.png" Height="23px" Width="60px"
        onclick="imgBtn_Click" /></td>
</tr>
</table>
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
