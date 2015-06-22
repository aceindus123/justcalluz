<%@ Page Language="C#" AutoEventWireup="true" CodeFile="White_Page.aspx.cs" Inherits="White_Page" %>
<%@ Register Src="usercontrols/signin.ascx" TagName="signin" TagPrefix="aa1" %>
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

<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<%--<title>:: Justcalluz :: White Page</title>--%>
<title>White Pages - JustCalluz | Search for Top Companies in Desired City</title>
<meta name="DESCRIPTION" content="JustCalluz brings you the option to view the details of any company located in any city by letting you select your desired city and giving you a list of all the top companies in your selected city." />
<meta name="keywords" content="justcalluz white pages, company names list, local search, company white pages, city white pages, find a business, find business address, company search, white pages reverse lookup, white pages online" />

<link href="css/style.css" rel="stylesheet" type="text/css" />
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
<!-- staart the Content-->
<div class="content" style="padding:0; margin:0;">
<div class="content_innerleft" style="width:79%">
<table width="100%" border="0">
  <tr>
    <td style="background: url(images/search_midtop.png) no-repeat" height="39" valign="center"><table width="100%" border="0">
  <tr>
    <td width="2%">&nbsp;</td>
    <td width="98%" ><span class="bottam"><font color="#FFFFFF">Select Your City To View Company Searches</font></span></td>
    </tr>
</table>
</td>
  </tr>
  <tr>
    <td >
  <table width="100%" border="0">
  <tr>
    <td width="100%" height="28" valign="top">
    <table width="100%" border="0" style="border:dotted 1px #666;  background: #F0FAFF; height:500px;">
      <tr>
      <td>
       <asp:DataList ID="dlpopcities" RepeatDirection="Vertical" CellPadding="4"  
              runat="server" Width="100%" RepeatColumns="3">
                <HeaderTemplate>
                </HeaderTemplate>
                <ItemTemplate>
                    <table border="0" width="100%">
                        <tr>
                            <td valign="top" style="padding-left:80px;padding-top:10px" class="side_menu">
                                <%--<asp:HyperLink ID="hyppopcities" runat="server" NavigateUrl='<%# string.Format("White_page_details.aspx?city=" + Eval("popcities").ToString()) %>' 
                                       Text='<%#DataBinder.Eval(Container.DataItem, "popcities")%>'></asp:HyperLink>--%>
                                <asp:HyperLink ID="hyppopcities" runat="server" NavigateUrl='<%# GetUrl(Eval("popcities")) %>' 
                                       Text='<%#DataBinder.Eval(Container.DataItem, "popcities")%>'></asp:HyperLink>
                            </td>
                        </tr>
                     </table>
                  </ItemTemplate>
         </asp:DataList>
      </td>
  <%-- <td width="31%"  align="left" class="select_menu" style="padding-left:70px; padding-top:10px;" valign="top">
  <a href="#">Agra</a><br/><br/>
  <a href="#">Ahmedabad</a><br/><br/>
  <a href="#">Bangalore</a><br/><br/>
  <a href="#">Bhopal</a><br/><br/>
  <a href="#">Bhubaneshwar</a><br/><br/>
  <a href="#">Chandigarh</a><br/><br/>
  <a href="#">Chennai</a><br/><br/>
  <a href="#">Coimbatore</a><br/><br/>
  <a href="#">Delhi</a><br/><br/>
  <a href="#">Ernakulam</a><br/><br/>
  <a href="#">Goa</a><br/><br/>
  <a href="#">Hubli</a><br/><br/>
  <a href="#">Hyderabad</a><br/><br/>
  <a href="#">Indore</a><br/><br/>
  <a href="#">Jaipur</a></td>
        <td width="4%" style="border-right: 1px  dashed #666" valign="top">&nbsp;</td>
        <td width="31%" align="left" class="select_menu" style="padding-left:70px; padding-top:10px;">
  <a href="#">Jalandhar</a><br/><br/>
  <a href="#">Jamnagar</a><br/><br/>
  <a href="#">Jamshedpur</a><br/><br/>
  <a href="#">Jodhpur</a><br/><br/>
  <a href="#">Kanpur</a><br/><br/>
  <a href="#">Kolhapur</a><br/><br/>
  <a href="#">Kozhikode</a><br/><br/>
  <a href="#">Lucknow</a><br/><br/>
  <a href="#">Ludhiana</a><br/><br/>
  <a href="#">Madurai</a><br/><br/>
  <a href="#">Mangalore</a><br/><br/>
  <a href="#">Mumbai</a><br/><br/>
  <a href="#">Mysore</a><br/><br/>
  <a href="#">Nagpur</a><br/><br/>
  <a href="#">Nashik</a><br/><br/>
  <a href="#">Patna</a>
  </td>
        <td width="2%" style="border-right: 1px  dashed #666" valign="top">&nbsp;</td>
        <td width="32%"  align="left" class="select_menu" style="padding-left:60px; padding-top:10px;" valign="top">
  <a href="#">Pondicherry</a><br/><br/>
  <a href="#">Pune</a><br/><br/>
  <a href="#">Rajkot</a><br/><br/>
  <a href="#">Ranchi</a><br/><br/>
  <a href="#">Salem</a><br/><br/>
  <a href="#">Surat</a><br/><br/>
  <a href="#">Thiruvananthapuram</a><br/><br/>
  <a href="#">Tirunelveli</a><br/><br/>
  <a href="#">Vadodara</a><br/><br/>
  <a href="#">Varanasi</a><br/><br/>
  <a href="#">vijayawada</a><br/><br/>
  <a href="#">Vizag</a>
  </td>--%>
        </tr>
      </table></td>
  </tr>
</table>
</td>
  </tr>
 </table>
 </div>
<div class="content_innerright">
<div class="contentbox_top">Sponsor Ads</div>
<div class="contentbox_mid">
  <table width="100%" border="0">
    <tr>
      <td width="100%" valign="top">
        <img src="images/event/add2.png" alt="Ads" width="180" height="600" />
      </td>
    </tr>
    <tr>
      <td></td>
    </tr>
  </table>
</div>
<div class="contentbox_bottam"></div>
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
