<%@ Page Language="C#" AutoEventWireup="true" CodeFile="success_videos.aspx.cs" Inherits="success_videos" %>
<%@ Register Src="usercontrols/signin.ascx" TagName="signin" TagPrefix="aa1" %>
<%@ Register Src="usercontrols/Search.ascx" TagName="catag" TagPrefix="aa6" %>
<%@ Register Src="usercontrols/footer1.ascx" TagName="footer1" TagPrefix="aa10" %>
<%@ Register Src="usercontrols/footer2.ascx" TagName="footer2" TagPrefix="aa11" %>
<%@ Register Src="usercontrols/BottomContent.ascx" TagName="bottomcontent" TagPrefix="aa4" %>
<%@ Register Src="usercontrols/BottomMidContent.ascx" TagName="bottomMidcontent" TagPrefix="aa5" %>
<%@ Register Src="usercontrols/Testimonials_Left.ascx" TagName="TestLeft" TagPrefix="aa15" %>
<%@ Register Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" TagPrefix="cc3"  %>
<%@ Register Src="usercontrols/SearchNew.ascx" TagName="SearchNew" TagPrefix="New" %>
<%@ Register Src="usercontrols/small_logo.ascx" TagName="logo" TagPrefix="S_logo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
   <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
   <title id="pgtitle" runat="server"></title>
<%--<title>:: Justcalluz :: Success Stories</title>--%>
<link href="css/style.css" rel="stylesheet" type="text/css" />
<link href="css/menu.css" rel="stylesheet" type="text/css" />
<link href="css/inner_style.css" rel="stylesheet" type="text/css" />

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
  <div class="content_innermid" style="width:78.4%;">
  <table width="100%" border="0">
   <tr>
    <td style="padding-left:10px;"><hr/><hr/></td>
  </tr>
  <tr>
      <td style="border-bottom:2px solid #C90"><h1>Success Videos</h1></td>
    </tr>
    <tr>
      <td>
      <table width="100%" border="0">
        <tr>
          <td colspan="2" height="30" align="right"><h2><a href="<%$RouteUrl:RouteName=successVideos%>" runat="server">Success Videos</a>&nbsp;|&nbsp;<a href="<%$RouteUrl:RouteName=success%>" runat="server">Success Stories</a></h2></td>
        </tr>
      </table></td>
    </tr>
  
  <tr>
    <td >&nbsp;</td>
  </tr>
 <tr>
      <td height="20" style="border-bottom:1px dotted #999" align="left" colspan="2">
     <table width="100%" border="0">
     <tr>
     <td>   <asp:DataList ID="dlcity" runat="server" RepeatColumns="10">
  <ItemTemplate>
    <asp:Button ID="lnkcity" runat="server" Text='<%#Eval("City")%>' CommandArgument='<%#Eval("City")%>' 
           OnCommand="lnk_to_othcities" BorderStyle="None" BackColor="White" CssClass="pointer" />
    &nbsp;|&nbsp;
  </ItemTemplate>
  </asp:DataList></td>
  
     <td width="300">
      <%-- <asp:LinkButton ID="lnkoth_cities" runat="server" Text="Other Cities"></asp:LinkButton>--%>
      <a id="lnkoth_cities" runat="server">Other Cities</a>
     </td>
     </tr></table>
     </td>
    </tr>
    <tr>
    <td>
    <asp:Panel ID="pnlcities" runat="server" BackColor="#DAD5D0" Width="375px">
    <fieldset>
    <table>
    <tr><td align="right"><asp:ImageButton AlternateText="CancelButton" ID="cancelbtn" runat="server" ImageUrl="../images/cencel.png" />
    </td></tr>
    <tr><td>
     <asp:DataList ID="dlother_cities" runat="server" RepeatColumns="4" Width="350px">
    <ItemTemplate>
    <asp:Button ID="lnkoth_cities_dl" runat="server" Text='<%#Eval("City")%>' CommandArgument='<%#Eval("City")%>'
         OnCommand="lnk_to_othcities" BorderStyle="None" BackColor="#DAD5D0" CssClass="pointer" />
     </ItemTemplate>
    </asp:DataList>
    </td></tr>
    </table>
    
   
    </fieldset>
    </asp:Panel>
    </td>
    </tr>
    <cc3:ModalPopupExtender ID="modpopup_cities" runat="server"  
        TargetControlID="lnkoth_cities" PopupControlID="Pnlcities" OnLoad="other_cities" BackgroundCssClass="modalBackground" 
          OkControlID="cancelbtn"
        DropShadow="false"></cc3:ModalPopupExtender>
  <tr>
  <td>
  <table border="0" width="100%">
  
  <tr>
  <td style="width:200px;">
  <asp:DataList ID="dlimages" runat="server" onitemdatabound="dlimages_ItemDataBound">
  <ItemTemplate>
  <table>
  <tr>
  <td>
  <asp:ImageButton ID="imgplaybtn" AlternateText="Photos" runat="server" CommandArgument='<%#Eval("ssId")%>' ImageUrl='<%# Eval("PhotoName", "../SS_Photos\\{0}") %>' Width="64" Height="64" OnCommand="imgplaybtn"/>
  </td>
  <td>
  <asp:Button ID="lnkcmp" runat="server" Text='<%#Eval("CompanyName")%>' CommandArgument='<%#Eval("ssId")%>' 
     OnCommand="imgplaybtn" BorderStyle="None" BackColor="White"  CssClass="pointer"/><br />
  <asp:Label ID="lblname" runat="server" Text='<%#Eval("PName")%>'></asp:Label><br />
  <asp:Label ID="lblcity" runat="server" Text='<%#Eval("City")%>'></asp:Label>
  
  </td>
  </tr>
  </table>
  
  <%--<asp:Image ID="imgReviewer" runat="server" ImageUrl='<%# Eval("Content_Name", "~/CaptureImages\\{0}") %>' Width="64" Height="64"/>--%>
  </ItemTemplate>
  </asp:DataList>
  </td>
  <td align="right">
  <object type="video/x-ms-wmv" data="<%=swfFileName%>" width="420" height="340">
   <param name="url" value="<%=swfFileName%>"/>
   <param name="src" value="<%=swfFileName%>" />
   <param name="autostart" value="false" />
   <param name="sound" value="false" />
   <param name="controller" value="true" />
   <embed id='embed1' src="<%=swfFileName%>" runat="server" name='mediaPlayer' type='application/x-mplayer2' pluginspage='http://microsoft.com/windows/mediaplayer/en/download/'  displaysize='4' autosize='-1' bgcolor='darkblue' showcontrols='true' showtracker='-1' showdisplay='0' showstatusbar='-1' videoborder3d='-1' width='500' height='405'  designtimesp='5311' loop='false'>
  </embed>
</object>
  
  </td>
  </tr>
  </table>
  </td>
  </tr>
  <tr>
  <td>
    <asp:Label ID="lblcity_out" runat="server" Visible="false"></asp:Label>
      <asp:Label ID="lblmsg" runat="server"></asp:Label>
      <table border="0" width="100%">
      <tr><td>&nbsp;</td></tr>
        <tr>
          <td align="right">
            <asp:ImageButton ID="imgPrevious" runat="server" AlternateText="btnPrevious" ImageUrl="images/arrow_2.png" OnClick="imgPrevious_Click"/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:ImageButton ID="imgNext" runat="server" AlternateText="btnNext" ImageUrl="images/arrow_1.png" OnClick="imgNext_Click" />
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
<script type="text/javascript">
<!--
swfobject.registerObject("FlashID");
//-->
</script>
    </form>
</body>
</html>
