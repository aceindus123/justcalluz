<%@ Page Language="C#" AutoEventWireup="true" CodeFile="search_tips.aspx.cs" Inherits="search_tips" %>
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
<title>Search Tips - JustCalluz - Get Assistance on Using JustCalluz's Search</title>
<meta name="title" content="Search Tips - JustCalluz - Get Assistance on Using JustCalluz's Search" />
<meta name="DESCRIPTION" content="Get assistance on how to use JustCalluz's search feature like filling up the search fields efficiently, sending search results to your Mobile via SMS or to your Inbox via Email etc." />
<meta name="keywords" content="justcalluz search tips, justcalluz search help, search justcalluz, justcalluz help, search business, justcalluz tips, justcalluz lookup, local search engine" />
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
<div class="content_innermid" style="width:79%">
<table width="100%" border="0"  >
  <tr>
    <td class="select_menu" style="padding-left:3px;"><a href="Default.aspx">Home</a>&gt;Search Tips</td>
  </tr>
  <tr>
    <td style="background:url(images/event_send2.png) no-repeat" height="39" valign="middle"><table width="100%" border="0">
  <tr>
    <td width="9%">&nbsp;</td>
    <td width="91%" ><span class="bottam">Search Tips</span></td>
    </tr>
</table>
</td>
  </tr>
  <tr>
    <td ><table width="100%" border="0">
  <tr>
    <td height="40" valign="top" style="font-family:Verdana, Geneva, sans-serif;" >
    <ul type="square" style="padding-left:30px; line-height:2">
    <li style="color:#00458A">When to use What?</li>
    <li style="color:#00458A">When to use Where?</li>
    <li style="color:#00458A">How to use send to Mobile / Email feature?</li> 
    </ul> </td>
  </tr>
  <tr>
    <td valign="top"  style="background-image:url(images/hr.gif);background-repeat:repeat-x" >
        &nbsp;</td>
  </tr>
  <tr>
    <td width="100%" height="28" valign="top" style="font-family:Verdana, Geneva, sans-serif" ><strong><font color="#004566">
        .When to use What?</font></strong><br/><br/>
        <p align="justify"> you are looking for information pertaining to a particular company, 
        restaurant, movie hall, institution, organization, product, service etc make use 
        of</p>
<strong><font color="#004566">&#39;What&#39;</font></strong><br/><br/>
        (Example-Mainland China restaurant)<br/><br/>
<p align="justify"><strong>What: </strong>.Let&#39;s say you want to dine out in a particular restaurant- <strong>
        Mainland China </strong>restaurant located at Andheri in Mumbai. Start by 
        selecting or typing in the City <strong>Eg: Mumbai.</strong> Next, click on the <strong>
        What</strong> field. Enter <strong>Mainland China Restaurant</strong> in the 
        search box. Enter<strong>Andheri</strong>in the <strong>Where </strong>box then 
        click on <strong>Go!</strong> You will instantly find <strong>what</strong> you 
        are looking for. If you are not sure<strong> where </strong>you want to eat, you 
        can leave the<strong>Where </strong>field empty and you will get the complete 
        list of all Mainland China restaurants in Mumbai.</p>

<strong><font color="#004566">.When to use Where?</font></strong><br/><br/>

        <p align="justify">If you are looking for information at a particular place pertaining to a 
        particular product or service or if you are looking for a list of restaurants, 
        movie halls, institutions, organizations etc. make use of <strong>Where.</p></strong>

        <p align="justify">(Example-Chinese restaurants)<strong>Where:</strong>  Let&#39;s take the same 
        example. Say you want to dine out, you want to have Chinese food but nearby your 
        home, but do not have a particular restaurant in mind. Start by selecting or 
        typing in the City<strong> Eg: Mumbai, </strong>then click on the <strong>What </strong>
        field enter <strong>Chinese Restaurant</strong> in the search box. Then start 
        typing in the place of your choice in the Where box, for e.g. <strong>Andheri.</strong>Then 
        click on Go! You will find a list of Chinese Restaurants wherein you can further 
        refine your search by the price. Once you click on the price of your choice, 
        instantly you get a list of restaurants to choose from.</p><br/>
<br/>

<strong><font color="#004566">.How to use send to Mobile / Email feature?</font></strong><br/><br/>
        <p align="justify">Now from the website itself you can send the information that you are looking 
        for to your Mobile via SMS or to your Inbox via Email. This relieves you of the 
        hassles of noting down the numbers and names. It&#39;s safe in your Mobile/Inbox.</p>

<strong>Send top results to Mobile / Email</strong> This feature is used <strong>when</strong> 
        you want the top results of <strong>what</strong> you are looking for.<br/><br/>

        Let&#39;s take an example. Say you are looking out for an Estate Agent, at Malad in 
        Mumbai.<br/><br/>

        <p align="justify">Start by selecting the City Eg: Mumbai. Click on the <strong>what</strong>  
        field enter Estate Agent in the search box. Next, enter the area in the Where 
        box Eg: Malad. Then click on Go! You will find Estate Agents Categories wherein 
        you can further refine your search by the type of Estate Agent you are looking 
        out for. Once you click on your choice, instantly you get a list of Estate 
        Agents to choose from.</p>


<ol type="1" style="padding-left:30px; line-height:2"><li>Now click on the link <strong>
    Send top results to Mobile / Email</strong></li>
<li>Enter your <strong>Mobile number / Email Id </strong>and click on <strong>Send</strong></li>
<li>An instant SMS / Email of the top results is sent to you</li></ol><br/>
<strong>Send to Mobile / Email </strong>This feature is used<strong> when </strong>you 
        want the information of a particular result.<br/><br/>
        Let&#39;s take the same example. Say you are looking out for an Estate Agent, at 
        Malad in Mumbai.<br/><br/>

<ol type="1" style="padding-left:30px; line-height:2"><li>You will start by 
    selecting the City Eg: Mumbai.</li>
<li>Click on the <strong>what</strong> field</li>
<li>Enter Estate Agent in the search box.</li>
<li>Next, enter the area you prefer in the <strong>Where </strong>box Eg: Malad</li>
<li>Then click on Go!</li>
<li>You will find Estate Agents Categories wherein you can further refine your 
    search by the type of Estate Agent you are looking out for.</li>
<li>Once you click on your choice, instantly you get a list of Estate Agents to 
    choose from. Click on the Estate Agent you want to go in for</li>
<li>Click on the link Send to<strong> Mobile / Email </strong>Enter your <strong>
    Mobile number / Email Id</strong> and click on <strong>Send</strong></li>
<li>An instant SMS / Email is sent to you with the name and number of that 
    particular estate agent.</li></ol><br/></td>
  </tr>
</table>
</td>
  </tr>
 
</table>
 </div>
<%--<div class="content_right" style="width:20%">
  <table width="100%" border="0">
    <tr>
      <td  align="center"><img src="images/image_gallery.gif" width="160" height="500" /><br/><br/>
        <img src="images/citi-bank.png" width="160" height="600" /></td>
    </tr>
    <tr>
      <td></td>
    </tr>
   
  </table>
</div>--%>
 <div class="content_innerright">
<div class="contentbox_top">Sponsor Ads</div>
<div class="contentbox_mid">
  <table width="100%" border="0">
    <tr>
      <td width="100%" valign="top">
      <img src="images/image_gallery.gif" alt="image_galleryImage" width="175" height="600" /><br />
       <img src="images/citi-bank.png" alt="citi-bankimage" width="175" height="700" /><br />
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
