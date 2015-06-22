<%@ Page Language="C#" AutoEventWireup="true" CodeFile="tv_ads.aspx.cs" Inherits="tv_ads" %>

<%@ Register Src="usercontrols/signin.ascx" TagName="signin" TagPrefix="aa1" %>
<%@ Register Src="usercontrols/Search.ascx" TagName="catag" TagPrefix="aa6" %>
<%@ Register Src="usercontrols/footer1.ascx" TagName="footer1" TagPrefix="aa10" %>
<%@ Register Src="usercontrols/footer2.ascx" TagName="footer2" TagPrefix="aa11" %>
<%@ Register Src="usercontrols/BottomContent.ascx" TagName="bottomcontent" TagPrefix="aa4" %>
<%@ Register Src="usercontrols/BottomMidContent.ascx" TagName="bottomMidcontent" TagPrefix="aa5" %>
<%@ Register Src="usercontrols/Testimonials_Left.ascx" TagName="TestLeft" TagPrefix="aa15" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="AjaxToolkit" %>
<%@ Register Src="usercontrols/SearchNew.ascx" TagName="SearchNew" TagPrefix="New" %>
<%@ Register Src="usercontrols/small_logo.ascx" TagName="logo" TagPrefix="S_logo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>:: Justcalluz :: Ads</title>
<link href="css/style.css" rel="stylesheet" type="text/css" />
<link href="css/menu.css" rel="stylesheet" type="text/css" />
<link href="css/inner_style.css" rel="Stylesheet" type="text/css" />
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
<!-- staart the Content-->
<div class="content" style="padding:0; margin:0;">
  <div class="content_innerleft">
       <aa15:TestLeft ID="text_Left" runat="server" />
</div>
  <div class="content_innermid" style="width:79%;">
  <table width="100%" border="0">
  <tr>
    <td class="bottam" style="padding-left:10px;"><asp:Label ID="lblcat" runat="server"></asp:Label></td>
    <td></td>
  </tr>
  <tr>
    <td style="padding-left:10px;"><hr/><hr/></td>
  </tr>
  <%-- <tr><td>
    <asp:UpdatePanel ID="ratingpnl" runat="server">
    <ContentTemplate>
    <table width="100%">
    <tr><td></td>
    <tr><td class="text6">Rating :</tr>
    
    <td>
       
    <AjaxToolkit:Rating ID="avgrating" runat="server" AutoPostBack="true" StarCssClass="starempty" FilledStarCssClass="starrating" WaitingStarCssClass="starfill" EmptyStarCssClass="starempty"></AjaxToolkit:Rating>
   
  <b> <asp:Label ID="lbl1rate" runat="server" ForeColor="#003366"></asp:Label></b>
    
    </td>
   
    </tr>
    <tr><td></td></tr>
    </table>
    </ContentTemplate>
    </asp:UpdatePanel>
    </td></tr>--%>
  <tr>
    <td><table width="100%" border="0" id="tblrate" runat="server">
  <tr>
    <td colspan="3">
       
    <AjaxToolkit:Rating ID="avgrating" runat="server" AutoPostBack="true" StarCssClass="starempty" FilledStarCssClass="starrating" WaitingStarCssClass="starfill" EmptyStarCssClass="starempty" OnChanged="insert_rating"></AjaxToolkit:Rating>
   
  <b> <asp:Label ID="lbl1rate" runat="server" ForeColor="#003366"></asp:Label></b>
  <asp:Label ID="lbladmsg" runat="server"></asp:Label>
    
    </td>
    </tr>
    <tr>
    <td></td>
    <td width="44%" class="movie_menu">Click on stars to rate</td>
    <td width="4%"><img alt="usercommentIcon" src="images/user-comment-icon.png" width="32" height="32" /></td>
    <td width="18%" class="movie_menu"><%--<a href="tv_ads.aspx#tblcomment">Write a Comment</a>--%><a href="<%$RouteUrl:RouteName=Ads%>" runat="server">Write a Comment</a></td>
    </tr>
  <tr>
    <td height="40" colspan="3" class="movie_menu"  style="padding-left:10px;"><font color="#005177">Click on thumbnail graphics on the left to view the respective ad film</font></td>
    <td colspan="2" height="30" align="right" style="padding-right:5px;"><img alt="ratingImage" src="images/rateing_image2.png" width="112" height="27" /></td>
    </tr>
</table>
</td>
  </tr>
  <tr>
    <td >&nbsp;</td>
  </tr>
 <tr>
  <td>
  <asp:DataList ID="dllang" runat="server" RepeatColumns="10">
  <ItemTemplate>
 <%-- <asp:Button ID="lnklang" runat="server" Text='<%#Eval("AdLanguage")%>' BorderStyle="None" BackColor="White" 
       CommandArgument='<%#Eval("AdLanguage")%>' OnCommand="langads" />--%>
   <asp:HyperLink ID="lnklang" runat="server" NavigateUrl='<%# TvAds(Eval("AdLanguage"))%>' Text='<%#Eval("AdLanguage")%>'>
   </asp:HyperLink>
   &nbsp;|&nbsp;
  </ItemTemplate>
  </asp:DataList>
  </td>
  </tr>
  <tr>
  <td>
  <table border="0" width="100%">
  
  <tr>
  <td style="width:400px;">
  <asp:DataList ID="dlimages" runat="server">
  <ItemTemplate>
  <asp:ImageButton ID="imgplaybtn" AlternateText="CaptureImages" runat="server" CommandArgument='<%#Eval("adId")%>' ImageUrl='<%# Eval("CaptureContent_Name", "~/CaptureImages\\{0}") %>' Width="64" Height="64" OnCommand="imgplaybtn"/>
  </ItemTemplate>
  </asp:DataList>
  </td>
  <td>
  <object type="video/x-ms-wmv" data="<%=swfFileName%>" width="420" height="340">
   <param name="url" value="<%=swfFileName%>"/>
   <param name="src" value="<%=swfFileName%>" />
   <param name="autostart" value="false" />
   <param name="sound" value="false" />
   <param name="controller" value="true" />
   <embed id='embed1' src="<%=swfFileName%>" runat="server" name='mediaPlayer' type='application/x-mplayer2' pluginspage='http://microsoft.com/windows/mediaplayer/en/download/'  displaysize='4' autosize='-1' bgcolor='darkblue' showcontrols='true' showtracker='-1' showdisplay='0' showstatusbar='-1' videoborder3d='-1' width='500' height='405'  designtimesp='5311' loop='false'>
  </embed>
</object>
  <%--<asp:literal id="Literal1" runat="server"></asp:literal>--%> 
  </td>
  </tr>
  </table>
  </td>
  </tr>
  
  <%--<tr>
    <td style="padding-left:10px;"><img src="images/AB1.jpg" width="134" height="82" /></td>
  </tr>
  <tr>
    <td style="padding-left:10px; padding-top:20px;" height="40"><img src="images/AB2.jpg" width="134" height="82" /></td>
  </tr>
  <tr>
    <td style="padding-left:10px; padding-top:20px;" height="40"><img src="images/AB3.jpg" width="134" height="82" /></td>
  </tr>
  <tr>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td align="center" class="bottam_menu">Watch Big B in Action!</td>
  </tr>
  <tr>
    <td>&nbsp;</td>
  </tr>--%>
  <tr>
    <td style="padding-left:10px;">
    <table id="tblcomment" width="100%"><tr><td>
    <div class="glossymenu">
<a class="menuitem submenuheader" href="http://www.dynamicdrive.com/style/" >Write a Comment</a>
<div class="submenu" style="width:774px; height:300px; background:#E8F4FF; border-bottom:1px #cc9 solid">	
<table border="0" width="100%">
<tr><td align="right">Name<span style="color:Red">*</span></td><td align="center"><strong>&nbsp;:&nbsp;</strong></td><td>
    <asp:TextBox ID="txtname" runat="server" Width="300px" Height="25px"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RFVname" runat="server" ErrorMessage="Please Enter Your Name" SetFocusOnError="true" ControlToValidate="txtname" ValidationGroup="comments">*</asp:RequiredFieldValidator></td></tr>&nbsp;
<tr><td align="right">Email</td><td align="center"><strong>&nbsp;:&nbsp;</strong></td><td><asp:TextBox ID="txtemail" runat="server" Width="300px" Height="25px"></asp:TextBox></td></tr>
<tr><td align="right">Comments<span style="color:Red">*</span></td><td align="center"><strong>&nbsp;:&nbsp;</strong></td><td>
<asp:TextBox ID="txtcomments" runat="server" TextMode="MultiLine" Rows="10" Columns="35"></asp:TextBox>
<asp:RequiredFieldValidator ID="RFVcomments" runat="server" ErrorMessage="Please Enter Your Comments" SetFocusOnError="true" ControlToValidate="txtcomments" ValidationGroup="comments">*</asp:RequiredFieldValidator></td></tr>
<tr><td>&nbsp;</td><td>&nbsp;</td><td>
    <asp:ImageButton ID="submit" runat="server" AlternateText="submitButton" ImageUrl="images/submit.png" onclick="submit_Click"  ValidationGroup="comments"/></td></tr>
</table>
</div>
</div>
</td></tr></table>
</td>
  </tr>
  <tr>
    <td style="padding-left:10px;">
        <asp:DataList ID="dlreviews" runat="server" Width="100%">
        <ItemTemplate>
    <table width="100%" border="0" style=" border:1px #999 solid; background-color:#EBEBEB">
      <tr>
        <td width="4%" bgcolor="#EBEBEB"><img alt="usercommentIcon" src="images/user-comment-icon1.png" width="28" height="28" /></td>
        <td width="71%" class="bottam_menu"> <%#DataBinder.Eval(Container.DataItem, "Name")%></td>
        <td width="25%" class="bottam_menu"><font color="#002D59"> <%#DataBinder.Eval(Container.DataItem, "postdate")%></font></td>
      </tr>
      <tr>
        <td colspan="3" bgcolor="#EAF9FF"class="bottam_menu" height="40" style="padding-left:10px;"><font color="#002D59"> <%#DataBinder.Eval(Container.DataItem, "Comments")%></font></td>
      </tr>
    </table>
    </ItemTemplate>
        </asp:DataList>
  
    </td>
  </tr>
<%--  <tr>
    <td style="padding-left:10px;"><table width="100%" border="0" style=" border:1px #999 solid; background-color:#EBEBEB">
      <tr>
        <td width="4%" bgcolor="#EBEBEB"><img src="images/user-comment-icon1.png" width="28" height="28" /></td>
        <td width="74%" class="bottam_menu">SHIV KUMAR YADAV</td>
        <td width="22%" class="bottam_menu"><font color="#002D59">2012-08-13 14:23:23</font></td>
      </tr>
      <tr>
        <td colspan="3" bgcolor="#FFFFEA" class="bottam_menu" height="40" style="padding-left:10px;"><font color="#002D59">Thanks</font></td>
        </tr>
    </table></td>
  </tr>
  <tr>
    <td style="padding-left:10px;"><table width="100%" border="0" style=" border:1px #999 solid; background-color:#EBEBEB">
      <tr>
        <td width="4%" bgcolor="#EBEBEB"><img src="images/user-comment-icon1.png" width="28" height="28" /></td>
        <td width="74%" class="bottam_menu">Anil</td>
        <td width="22%" class="bottam_menu"><font color="#002D59">2012-08-13 14:23:23</font></td>
      </tr>
      <tr>
        <td colspan="3" bgcolor="#FFFFEA" class="bottam_menu" height="40" style="padding-left:10px;"><font color="#002D59">Nice One!!</font></td>
        </tr>
    </table></td>
  </tr>
  <tr>
   <td style="padding-left:10px;"><table width="100%" border="0" style=" border:1px #999 solid; background-color:#EBEBEB">
      <tr>
        <td width="4%" bgcolor="#EBEBEB"><img src="images/user-comment-icon1.png" width="28" height="28" /></td>
        <td width="74%" class="bottam_menu">ayub j sindhi</td>
        <td width="22%" class="bottam_menu"><font color="#002D59">2012-08-13 14:23:23</font></td>
      </tr>
      <tr>
        <td colspan="3" bgcolor="#FFFFEA" class="bottam_menu" height="40" style="padding-left:10px;"><font color="#002D59">You are too good Justdial. Do anything & everything for ......every one</font></td>
        </tr>
    </table></td>
  </tr>
  <tr>
   <td style="padding-left:10px;"><table width="100%" border="0" style=" border:1px #999 solid; background-color:#EBEBEB">
      <tr>
        <td width="4%" bgcolor="#EBEBEB"><img src="images/user-comment-icon1.png" width="28" height="28" /></td>
        <td width="74%" class="bottam_menu">raj</td>
        <td width="22%" class="bottam_menu"><font color="#002D59">2012-08-13 14:23:23</font></td>
      </tr>
      <tr>
        <td colspan="3" bgcolor="#FFFFEA" class="bottam_menu" height="40" style="padding-left:10px;"><font color="#002D59">Excellent, JD people rocks....!!!!!</font></td>
        </tr>
    </table></td>
  </tr>
  <tr>
    <td style="padding-left:10px;"><table width="100%" border="0" style=" border:1px #999 solid; background-color:#EBEBEB">
      <tr>
        <td width="4%" bgcolor="#EBEBEB"><img src="images/user-comment-icon1.png" width="28" height="28" /></td>
        <td width="74%" class="bottam_menu">gajendra singh k</td>
        <td width="22%" class="bottam_menu"><font color="#002D59">2012-08-13 14:23:23</font></td>
      </tr>
      <tr>
        <td colspan="3" bgcolor="#FFFFEA" class="bottam_menu" height="40" style="padding-left:10px;"><font color="#002D59">good information and service</font></td>
        </tr>
    </table></td>
  </tr>
  <tr>
    <td style="padding-left:10px;"><table width="100%" border="0" style=" border:1px #999 solid; background-color:#EBEBEB">
      <tr>
        <td width="4%" bgcolor="#EBEBEB"><img src="images/user-comment-icon1.png" width="28" height="28" /></td>
        <td width="74%" class="bottam_menu">chetan</td>
        <td width="22%" class="bottam_menu"><font color="#002D59">2012-08-13 14:23:23</font></td>
      </tr>
      <tr>
        <td colspan="3" bgcolor="#FFFFEA" class="bottam_menu" height="40" style="padding-left:10px;"><font color="#002D59">2012-08-13 14:23:23</font></td>
        </tr>
    </table></td>
  </tr>
  <tr>
    <td style="padding-left:10px;"><table width="100%" border="0" style=" border:1px #999 solid; background-color:#EBEBEB">
      <tr>
        <td width="4%" bgcolor="#EBEBEB"><img src="images/user-comment-icon1.png" width="28" height="28" /></td>
        <td width="74%" class="bottam_menu">sana</td>
        <td width="22%" class="bottam_menu"><font color="#002D59">2012-08-13 14:23:23</font></td>
      </tr>
      <tr>
        <td colspan="3" bgcolor="#FFFFEC"class="bottam_menu" height="40" style="padding-left:10px;"><font color="#002D59">U R awesome.</font></td>
        </tr>
    </table></td>
  </tr>
  <tr>
    <td style="padding-left:10px;"><table width="100%" border="0" style=" border:1px #999 solid; background-color:#EBEBEB">
      <tr>
        <td width="4%" bgcolor="#EBEBEB"><img src="images/user-comment-icon1.png" width="28" height="28" /></td>
        <td width="74%" class="bottam_menu">sana</td>
        <td width="22%" class="bottam_menu"><font color="#002D59">2012-08-13 14:23:23</font></td>
      </tr>
      <tr>
        <td colspan="3" bgcolor="#FFFFEC"class="bottam_menu" height="40" style="padding-left:10px;"><font color="#002D59">U R awesome.</font></td>
        </tr>
    </table></td>
  </tr>
  <tr>
    <td style="padding-left:10px;"><table width="100%" border="0" style=" border:1px #999 solid; background-color:#EBEBEB">
      <tr>
        <td width="4%" bgcolor="#EBEBEB"><img src="images/user-comment-icon1.png" width="28" height="28" /></td>
        <td width="74%" class="bottam_menu">sana</td>
        <td width="22%" class="bottam_menu"><font color="#002D59">2012-08-13 14:23:23</font></td>
      </tr>
      <tr>
        <td colspan="3" bgcolor="#FFFFEC"class="bottam_menu" height="40" style="padding-left:10px;"><font color="#002D59">U R awesome.</font></td>
        </tr>
    </table></td>
  </tr>
  <tr>
    <td style="padding-left:10px;"><table width="100%" border="0" style=" border:1px #999 solid; background-color:#EBEBEB">
      <tr>
        <td width="4%" bgcolor="#EBEBEB"><img src="images/user-comment-icon1.png" width="28" height="28" /></td>
        <td width="74%" class="bottam_menu">sana</td>
        <td width="22%" class="bottam_menu"><font color="#002D59">2012-08-13 14:23:23</font></td>
      </tr>
      <tr>
        <td colspan="3" bgcolor="#FFFFEC"class="bottam_menu" height="40" style="padding-left:10px;"><font color="#002D59">U R awesome.</font></td>
        </tr>
    </table></td>
  </tr>
  <tr>
   <td style="padding-left:10px;"><table width="100%" border="0" style=" border:1px #999 solid; background-color:#EBEBEB">
      <tr>
        <td width="4%" bgcolor="#EBEBEB"><img src="images/user-comment-icon1.png" width="28" height="28" /></td>
        <td width="74%" class="bottam_menu">sana</td>
        <td width="22%" class="bottam_menu"><font color="#002D59">2012-08-13 14:23:23</font></td>
      </tr>
      <tr>
        <td colspan="3" bgcolor="#FFFFEC"class="bottam_menu" height="40" style="padding-left:10px;"><font color="#002D59">U R awesome.</font></td>
        </tr>
    </table></td>
  </tr>
  <tr>
   <td style="padding-left:10px;"><table width="100%" border="0" style=" border:1px #999 solid; background-color:#EBEBEB">
      <tr>
        <td width="4%" bgcolor="#EBEBEB"><img src="images/user-comment-icon1.png" width="28" height="28" /></td>
        <td width="74%" class="bottam_menu">sana</td>
        <td width="22%" class="bottam_menu"><font color="#002D59">2012-08-13 14:23:23</font></td>
      </tr>
      <tr>
        <td colspan="3" bgcolor="#FFFFEC"class="bottam_menu" height="40" style="padding-left:10px;"><font color="#002D59">U R awesome.</font></td>
        </tr>
    </table></td>
  </tr>--%>
  <tr>
    <td>&nbsp;</td>
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
<script type="text/javascript">
<!--
swfobject.registerObject("FlashID");
//-->
</script>
    </form>
</body>
</html>
