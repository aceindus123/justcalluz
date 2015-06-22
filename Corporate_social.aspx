<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Corporate_social.aspx.cs" Inherits="Corporate_social" %>
<%@ Register Src="usercontrols/footer1.ascx" TagName="footer1" TagPrefix="aa10" %>
<%@ Register Src="usercontrols/footer2.ascx" TagName="footer2" TagPrefix="aa11" %>
<%@ Register Src="usercontrols/BottomContent.ascx" TagName="bottomcontent" TagPrefix="aa4" %>
<%@ Register Src="usercontrols/BottomMidContent.ascx" TagName="bottomMidcontent" TagPrefix="aa5" %>
<%@ Register Src="usercontrols/media_left.ascx" TagName="lftmedia" TagPrefix="lmedia" %>
<%@ Register Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" TagPrefix="cc3"  %>
<%@ Register Src="usercontrols/SearchNew.ascx" TagName="SearchNew" TagPrefix="New" %>
<%@ Register Src="usercontrols/small_logo.ascx" TagName="logo" TagPrefix="S_logo" %>
<%@ Register Src="usercontrols/signin.ascx" TagName="signin" TagPrefix="aa1" %>
<%@ Register Src="usercontrols/Search.ascx" TagName="catag" TagPrefix="aa6" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<%--<title>:: Just Calluz :: Corporate Social Responsibility</title>--%>
<title>Corporate Social Responsibility (CSR) | JustCalluz</title>
<meta name='description' content='JustCalluz Corporate Social Responsibility (CSR) initiatives towards education has earned trust and respect of the society. Find the detailed CSR initiatives of JustCalluz.' />
<meta name='keywords' content='csr at justcalluz, Corporate Social Responsibility justcalluz, justcalluz Corporate Social Responsibility' />
		

<link href="css/inner_style.css" rel="stylesheet" type="text/css" />
<link href="css/style.css" rel="Stylesheet" type="text/css" />
<script language="javascript" type="text/javascript" src="js/jquery.min_1.0.js"></script>
<script language="javascript" type="text/javascript" src="js/auto_1.3.js"></script>
<script type="text/javascript" src="js/blockui_1.0.js"></script>
<script type="text/javascript">var onloadFn= "suggesstion";</script>

<%--<link href="css/csr.css" type="text/css" rel="stylesheet"/>


<script type="text/javascript">var totImg = 36;</script>
<script language="JavaScript" type="text/javascript" src="js/csr.js"></script>
<script language="JavaScript" type="text/javascript" src="js/jcarousellite.js"></script>
<script type="text/javascript">
$(document).ready(function() {	
    $('#imgeslideshow').attr("style","display:block");
       $(".slideshowmiddle").jCarouselLite({
         btnNext: ".blueright",
         btnPrev: ".greyleft" 
   });
});
</script>--%>
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
<div class="content_innerleft">
<lmedia:lftmedia ID="leftmedia" runat="server" />
</div>
<div class="content_innermid" style="width:77.5%; padding-left:15px;">
  <table width="100%" border="0">
  <tr>
    <td style="border-bottom:2px #F90 solid"><h1>Corporate Social Responsibility</h1></td>
  </tr>
  <tr>
  <td>
  <asp:DataList ID="dltitle" runat="server" RepeatColumns="8">
  <ItemTemplate>
  <asp:Button ID="lnktitle" runat="server" BackColor="White" BorderStyle="None"
   Text='<%#Eval("Title")%>' CommandArgument='<%#Eval("Title")%>' OnCommand="getdata" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
  </ItemTemplate>
  </asp:DataList>
  </td>
  </tr>
  <tr>
    <td height="150" align="center">
 <div class="article-content">
<link href="css/csr.css" type="text/css" rel="stylesheet"/>


<script type="text/javascript">var totImg = 36;</script>
<script language="JavaScript" type="text/javascript" src="js/csr.js"></script>
<script language="JavaScript" type="text/javascript" src="js/jcarousellite.js"></script>
<script type="text/javascript">
$(document).ready(function() {	
    $('#imgeslideshow').attr("style","display:block");
       $(".slideshowmiddle").jCarouselLite({
         btnNext: ".blueright",
         btnPrev: ".greyleft" 
   });
});
</script>
<div style="display:block" id="imgeslideshow" class="imageslideshow">
  <span class="slideshowleft"><span id="greyleft" class="greyleft blueleft"></span></span>
  <div class="slideshowmiddle" style="visibility: visible; overflow: hidden; position: relative; z-index: 0; left: 0px; ">
    <ul id="my-list" style="margin: 0px; padding: 0px; position: relative; list-style-type: none; z-index: 0; width: 6048px; left: -1176px; ">
	 <asp:DataList ID="dlPhotos" runat="server" RepeatDirection="Horizontal">
	 <ItemTemplate>
	 <li>
	 <a href="javascript:Gallery('1');">
	 <asp:ImageButton ID="imgcollection" AlternateText="corporateSocialPhotos" runat="server" ImageUrl='<%# Eval("ImgName", "../CSR_Photos\\{0}") %>' Width="150"  Height="90" CommandArgument='<%#Eval("ImgName")%>' OnCommand="getimage"/>
	  </a>
	  </li>
	 </ItemTemplate>
	 </asp:DataList>
	 </ul>
  </div>
  <span class="slideshowright"><span id="blueright" class="blueright"></span></span>
</div>
<asp:HiddenField ID="hid" runat="server" />

<!-- START of joscomment --><!-- END of joscomment -->
 <div id="main-container">
        <div id="container">
            <div id="myspan">
                <div id="example1_wrap" >
                    <ul id="example1" style="float:left; padding-left:50px;">
                        <asp:DataGrid ID="dlspecific_img" runat="server" DataKeyField="ImgName" AutoGenerateColumns="False"
                            ShowHeader="true" CellPadding="3" PageSize="1" AllowPaging="true" PagerStyle-Font-Bold="true"
                             PagerStyle-Mode="NextPrev" PagerStyle-NextPageText="Next" PagerStyle-PrevPageText="Prev"
                              PagerStyle-HorizontalAlign="Center" onpageindexchanged="dlspecific_img_PageIndexChanged">
                            <Columns>
                                <asp:TemplateColumn>
                                    <ItemTemplate>
                                            <li>
                                             <asp:Image ID="img_specific" AlternateText="corporateSocialPhoto" runat="server" ImageUrl='<%#Eval("ImgName","../CSR_Photos\\{0}")%>' Width="600px" Height="300px"/>
                                            </li>
                                    </ItemTemplate>
                                </asp:TemplateColumn>
                            </Columns>
                        </asp:DataGrid> 
                        <asp:Button ID="btnclose" runat="server" Text="Close" />                               
                                </ul>
                                
                </div>
            </div>
        </div>
    </div>
    </div>

    </td>
  </tr>
  <cc3:ModalPopupExtender ID="popupimage" runat="server" TargetControlID="hid" BackgroundCssClass="modalBackground" DropShadow="false"
 PopupControlID="dlspecific_img" CancelControlID="btnclose"></cc3:ModalPopupExtender>
  <tr>
    <td>
    <asp:DataList ID="dlCSR" runat="server">
    <ItemTemplate>
    <%#DataBinder.Eval(Container.DataItem,"Introduction")%><br /><br />
    <h2><%#DataBinder.Eval(Container.DataItem,"Title") %></h2><br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<%#DataBinder.Eval(Container.DataItem,"para1") %><br /><br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<%#DataBinder.Eval(Container.DataItem,"para2") %><br /><br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<%#DataBinder.Eval(Container.DataItem,"para3") %><br /><br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<%#DataBinder.Eval(Container.DataItem,"para4") %><br /><br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<%#DataBinder.Eval(Container.DataItem,"para5") %><br /><br />
    </ItemTemplate>
    </asp:DataList>
    <%--At Justdial, we view Corporate Social Responsibility (CSR) as a true effort to influence social order in a manner that earns the trust and respect of stakeholders and society. This belief in positive behavior has been embedded in our work culture and is a timeless promise we adhere to in order to make a meaningful difference in the lives of people.<br /><br />

<h2>EDUCATION</h2><br />

Justdial has adopted a school run by the Art of Living Foundation, Sri Sri Ravi Shankar Vidhya Mandir at Dharavi, Mumbai. It is an English Medium school, aided by modern education techniques and schools over 290 kids from the nearby slums. Costs of the entire functioning of this school and all the necessary support and resource mobilization in many areas, including infrastructure, facilities support, monitoring and evaluation, providing computer as well as food and nutrition i.e. all its operational costs will be borne by Justdial. The thrust of the project involves bettering the education and learning experience of the child.<br /><br />

From hereon, Justdial will support activities like renovation and general infrastructure repair and maintenance, landscaping and environmental beautification and supply of furniture, nutritious food, books and equipment to improve conditions of learning. Justdial will also work towards upgrading the teaching methods to an enhanced level to aid in the holistic development of the children.<br /><br />

According to Mr. VSS Mani, Founder and Managing Director of Justdial, "Each child represents a million ideas and we are just an enabling factor to help them realize their true potential. After all, the power and belief in an idea and the power of simplicity is what drives Just Dial."<br /><br />

Our contribution to this cause reflects our business culture of sharing corporate benefits with the community and growing together. We intend to walk forward on this path and make a marked <br /><br />
--%>
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
<!-- end of the content-->
<div class="footer" align="center" style="padding-top:5px; " >
<aa10:footer1 ID="tevfd" runat="server" />
<aa11:footer2 ID="eqwr" runat="server" />
</div>
</div>
    </form>
</body>
</html>
