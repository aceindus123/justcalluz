<%@ Page Language="C#" AutoEventWireup="true" CodeFile="media_details.aspx.cs" Inherits="media_details" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="AjaxToolkit" %>
<%@ Register Src="usercontrols/footer1.ascx" TagName="footer1" TagPrefix="aa10" %>
<%@ Register Src="usercontrols/footer2.ascx" TagName="footer2" TagPrefix="aa11" %>
<%@ Register Src="usercontrols/BottomContent.ascx" TagName="bottomcontent" TagPrefix="aa4" %>
<%@ Register Src="usercontrols/BottomMidContent.ascx" TagName="bottomMidcontent" TagPrefix="aa5" %>
<%@ Register Src="usercontrols/media_left.ascx" TagName="lftmedia" TagPrefix="lmedia" %>
<%@ Register Src="usercontrols/SearchNew.ascx" TagName="SearchNew" TagPrefix="New" %>
<%@ Register Src="usercontrols/small_logo.ascx" TagName="logo" TagPrefix="S_logo" %>
<%@ Register Src="usercontrols/signin.ascx" TagName="signin" TagPrefix="aa1" %>
<%@ Register Src="usercontrols/Search.ascx" TagName="catag" TagPrefix="aa6" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>:: Just Calluz :: Media Details page</title>
<link href="css/inner_style.css" rel="stylesheet" type="text/css" />
 <link href="css/style.css" rel="stylesheet" type="text/css" />
<link href="css/menu.css" rel="stylesheet" type="text/css" /> 
    <style type="text/css">
.starrating
    {
    	background-image:url(images/ratestar2.png);
    	width:18px;
    	height:18px;
    }
    .starfill
    {
    	background-image:url(images/ratestar2.png);
    	width:18px;
    	height:18px;
    }
    .starempty
    {
    	background-image:url(images/starash3.png);
    	width:18px;
    	height:18px;
    }
</style>
<script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.4.2/jquery.min.js"></script>

<script type="text/javascript" src="SpryAssets/ddaccordion.js">
</script>


<script type="text/javascript">


ddaccordion.init({
	headerclass: "submenuheader", //Shared CSS class name of headers group
	contentclass: "submenu", //Shared CSS class name of contents group
	revealtype: "click", //Reveal content when user clicks or onmouseover the header? Valid value: "click", "clickgo", or "mouseover"
	mouseoverdelay: 200, //if revealtype="mouseover", set delay in milliseconds before header expands onMouseover
	collapseprev: true, //Collapse previous content (so only one open at any time)? true/false 
	defaultexpanded: [], //index of content(s) open by default [index1, index2, etc] [] denotes no content
	onemustopen: false, //Specify whether at least one header should be open always (so never all headers closed)
	animatedefault: false, //Should contents open by default be animated into view?
	persiststate: true, //persist state of opened contents within browser session?
	toggleclass: ["", ""], //Two CSS classes to be applied to the header when it's collapsed and expanded, respectively ["class1", "class2"]
	togglehtml: ["suffix", "<img src='images/plus.gif' class='statusicon' />", "<img src='images/minus.gif' class='statusicon' />"], //Additional HTML added to the header when it's collapsed and expanded, respectively  ["position", "html1", "html2"] (see docs)
	animatespeed: "fast", //speed of animation: integer in milliseconds (ie: 200), or keywords "fast", "normal", or "slow"
	oninit:function(headers, expandedindices){ //custom code to run when headers have initalized
		//do nothing
	},
	onopenclose:function(header, index, state, isuseractivated){ //custom code to run whenever a header is opened or closed
		//do nothing
	}
})


</script>
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
<div class="content" style="padding:0; margin:0;">
<div class="content_innerleft">
<lmedia:lftmedia ID="leftmedia" runat="server" />
</div>
<div class="content_innermid" style="width:79%;">
  <table width="790px" border="0" style="padding-left:10px;">
    <tr>
    <td colspan="2">
    <asp:Label ID="lbltitle" runat="server" Width="700px"></asp:Label>
    </td>
    </tr>
    <tr>
    <td colspan="2" style="background-color:Silver;">
    <asp:Label ID="lblday" runat="server"></asp:Label>,<asp:Label ID="lbldate" runat="server"></asp:Label>
    <asp:label ID="lblname" runat="server"></asp:label>
    </td>
    </tr>
    <tr>
    <td>
        <table width="100%" border="0" id="tblrate" runat="server">
  <tr>
    <td colspan="3">
       
    <AjaxToolkit:Rating ID="avgrating" runat="server" AutoPostBack="true" StarCssClass="starempty" FilledStarCssClass="starrating" WaitingStarCssClass="starfill" EmptyStarCssClass="starempty" OnChanged="insert_rating"></AjaxToolkit:Rating>
   
  <b> <asp:Label ID="lbl1rate" runat="server" ForeColor="#003366"></asp:Label></b>
  <asp:Label ID="lbladmsg" runat="server"></asp:Label>
    
    </td>
    </tr>
    <tr>
    
    <td width="70%">Click on stars to rate</td>
    <td width="4%"><img  alt="usercommentIcon" src="images/user-comment-icon.png" width="32" height="32" /></td>
    <td width="25%" class="movie_menu">
      <%--<asp:LinkButton ID="lnkcomment" runat="server" Text="Write a Comment" OnClick="comment_click"></asp:LinkButton>--%>
      <a id="lnkcomment" runat="server" onserverclick="comment_click">Write a Comment</a>
    </td>
    </tr>
  <tr>
  <td colspan="3">
  <asp:Image ID="imgmedia" AlternateText="media" runat="server"/>
  </td>
  </tr>
  <tr><td colspan="3">
  <table id="tblmediacomment" runat="server" width="100%"><tr><td>
 <div class="glossymenu">
<a class="menuitem submenuheader" href="http://www.dynamicdrive.com/style/" >Write a Comment</a>
<div class="submenu" style="width:770px; height:260px; background:#E8F4FF">	
<table border="0" width="100%">
<tr><td align="right" style="padding-top:5px;">Name<span style="color:Red">*</span></td>
   <td align="center"><strong>&nbsp;:&nbsp;</strong></td><td>
    <asp:TextBox ID="txtname" runat="server" Width="300px"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RFVname" runat="server" ErrorMessage="Please Enter Your Name" SetFocusOnError="true" ControlToValidate="txtname" ValidationGroup="comments">*</asp:RequiredFieldValidator></td></tr>
<tr><td align="right">Email</td>
 <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
 <td><asp:TextBox ID="txtemail" runat="server" Width="300px"></asp:TextBox></td></tr>
<tr><td align="right">Comments<span style="color:Red">*</span></td>
 <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
<td><asp:TextBox ID="txtcomments" runat="server" TextMode="MultiLine" Rows="10" Columns="35"></asp:TextBox>
<asp:RequiredFieldValidator ID="RFVcomments" runat="server" ErrorMessage="Please Enter Your Comments" SetFocusOnError="true" ControlToValidate="txtcomments" ValidationGroup="comments">*</asp:RequiredFieldValidator></td></tr>
<tr><td>&nbsp;</td><td>&nbsp;</td><td>
    <asp:ImageButton ID="submit" AlternateText="SubmitButton" runat="server" ImageUrl="images/submit.png" onclick="submit_Click"  ValidationGroup="comments"/></td></tr>
</table>
</div>
</div>
</td></tr></table>
</td>
</tr>
<tr>
    <td colspan="3">
        <asp:DataList ID="dlreviews" runat="server" Width="100%">
        <ItemTemplate>
    <table width="100%" border="0" style=" border:1px #999 solid; background-color:#EBEBEB">
      <tr>
        <td width="4%" bgcolor="#EBEBEB"><img src="images/user-comment-icon1.png" alt="usercommentIcon" width="28" height="28" /></td>
        <td width="71%" class="bottam_menu"> <%#DataBinder.Eval(Container.DataItem, "Name")%></td>
        <td width="25%" class="bottam_menu" align="right"><font color="#002D59"> <%#DataBinder.Eval(Container.DataItem, "postdate")%></font></td>
      </tr>
      <tr>
        <td colspan="3" bgcolor="#EAF9FF"class="bottam_menu" height="40" style="padding-left:10px;"><font color="#002D59"> <%#DataBinder.Eval(Container.DataItem, "Comments")%></font></td>
      </tr>
    </table>
    </ItemTemplate>
        </asp:DataList>
  
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
