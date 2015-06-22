<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Lifestylesub.aspx.cs" Inherits="Lifestylesub" %>
<%@ Register Src="usercontrols/footer1.ascx" TagName="footer1" TagPrefix="aa10" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="AjaxToolkit" %>
<%@ Register Assembly="MSCaptcha" Namespace="MSCaptcha" TagPrefix="cc1" %>
<%@ Register Src="usercontrols/footer2.ascx" TagName="footer2" TagPrefix="aa11" %>
<%@ Register Src="usercontrols/Search.ascx" TagName="catag" TagPrefix="aa6" %>
<%@ Register Src="usercontrols/signin.ascx" TagName="signin" TagPrefix="sig" %>
<%@ Register Src="usercontrols/BottomContent.ascx" TagName="Bottomcontent" TagPrefix="bcon" %>
<%@ Register Src="usercontrols/BottomMidContent.ascx" TagName="Contentmid" TagPrefix="bcm" %>
<%@ Register Src="usercontrols/toplife.ascx" TagName="toplife" TagPrefix="toplife" %>
<%@ Register Src="usercontrols/SearchNew.ascx" TagName="SearchNew" TagPrefix="New" %>
<%@ Register Src="usercontrols/small_logo.ascx" TagName="logo" TagPrefix="S_logo" %>
<%@ Register Src="usercontrols/Home_right.ascx" TagName="homeright" TagPrefix="aa7" %>

<%--<%@ Register Src="usercontrols/SponsoredLinks.ascx" TagName="sp_links" TagPrefix="sp_ads" %>--%>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title id="pgtitle" runat="server"></title>
<link href="includes/style.css" rel="Stylesheet" type="text/css" />
<link href="css/style.css" rel="Stylesheet" type="text/css" />
<link href="css/inner_style.css" rel="Stylesheet" type="text/css" />
<link href="includes/red_style.css" rel="Stylesheet" type="text/css" />
<script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.3.1/jquery.min.js"></script>
<script type="text/javascript">
$(function(){
	var slideHeight = 250; // px
	var defHeight = $('#wrap').height();
	if(defHeight >= slideHeight){
		$('#wrap').css('height' , slideHeight + 'px');
		$('#read-more').append('<a href="#">Read More</a>');
		$('#read-more a').click(function(){
			var curHeight = $('#wrap').height();
			if(curHeight == slideHeight){
				$('#wrap').animate({
				  height: defHeight
				}, "normal");
				$('#read-more a').html('Less');
				$('#gradient').fadeOut();
			}else{
				$('#wrap').animate({
				  height: slideHeight
				}, "normal");
				$('#read-more a').html('Read More');
				$('#gradient').fadeIn();
			}
			return false;
		});		
	}
});
</script>
</head>
<body>
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <div class="layout">
<div class="signin">
  <sig:signin ID="sig1" runat="server" />
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
<!-- start the Content-->
<div class="content" style="padding:0; margin:0px;">
<div class="content_innermid" style="width:77%;">
<table width="100%" border="0">
 <toplife:toplife ID="toplifestyle" runat="server" />
 <tr><td>
 <table id="subrelated" runat="server" visible="false">
  <tr><td class="sub_menu" height="30">
  Select any option from the below list
  <br />
  <br />
  <asp:DataList ID="dlsubcat" DataKeyField="SubCategeory" runat="server" Width="100%" Height="100%"
         RepeatColumns="1" CellSpacing="0">
    <ItemTemplate>
        <table border="0">
            <tr>
                <td style="width:100%" colspan="2">
                   <%-- <asp:Button ID="linkcor" runat="server" CommandArgument='<%#Eval("SubCategeory") %>' Text='<%#Eval("SubCategeory") %>' 
                           PostBackUrl='<%# string.Format("Lifestylehome.aspx?cat=" + Eval("SubCategeory").ToString()+ "&cname=LifeStyle")%>'  
                           ForeColor="#003366" Font-Names="Arial" CommandName="select" BorderStyle="None" BackColor="White" />--%>
                     <%-- <asp:HyperLink ID="linkcor" runat="server" Text='<%#Eval("SubCategeory") %>' 
                           NavigateUrl='<%# string.Format("Lifestylehome.aspx?cat=" + Eval("SubCategeory").ToString()+ "&cname=LifeStyle")%>'  
                           ForeColor="#003366" Font-Names="Arial"></asp:HyperLink> --%> 
                            <asp:HyperLink ID="HyperLink1" runat="server" Text='<%#Eval("SubCategeory") %>' 
                           NavigateUrl='<%#GethomeLife(Eval("SubCategeory")) %>'  
                           ForeColor="#003366" Font-Names="Arial"></asp:HyperLink>                   
                           
                </td>
            </tr>
        </table>    
    </ItemTemplate>                         
 </asp:DataList>
  </td></tr>
  </table>
 </td></tr>
 <tr>
    <td class="style1"><asp:HyperLink ID="post" runat="server" Text="Advertise your company" Font-Size="11px" NavigateUrl="<%$RouteUrl:RouteName=PostLife,cname=LifeStyle %>" CssClass="side_menu" Font-Bold="true" ForeColor="Red" ></asp:HyperLink></td>
 </tr>
</table>
 </div>
 <div class="content_innerright1">
<div class="contentbox_top1">&nbsp;&nbsp;&nbsp;Reviews &amp; Ratings</div>
<div class="contentbox_mid1">
  <table width="100%" border="0">
   <tr>
     <td>
       <aa7:homeright ID="homeright" runat="server" />
    </td>
    </tr>
  </table>
</div>
<div class="contentbox_bottam1"></div>
</div>
 </div>
<!-- end of the mid Box-->  
<!-- end of the mid Box-->  
<div class="content_midbootam" >
<bcm:contentmid ID="contentmid" runat="server" />
</div>
<div class="content_midbootam" ><table width="100%" border="0">
  <tr>
    <td height="" ></td>
  </tr>
</table>
</div>
<div class="content_bootam_center">
<bcon:bottomcontent ID="bottomcontent" runat="server" />
</div>
<div class="footer" align="center" style="padding-top:5px; " >
    <aa10:footer1 ID="sdsa" runat="server" />
    <aa11:footer2 ID="poshv" runat="server" />
</div>
</div>
</form>
</body>
</html>
