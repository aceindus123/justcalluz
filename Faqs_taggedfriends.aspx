<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Faqs_taggedfriends.aspx.cs" Inherits="Faqs_taggedfriends" %>
<%@ Register Src="usercontrols/footer1.ascx" TagName="footer1" TagPrefix="aa10" %>
<%@ Register Src="usercontrols/footer2.ascx" TagName="footer2" TagPrefix="aa11" %>
<%@ Register Src="usercontrols/BottomContent.ascx" TagName="bottomcontent" TagPrefix="aa4" %>
<%@ Register Src="usercontrols/BottomMidContent.ascx" TagName="bottomMidcontent" TagPrefix="aa5" %>
<%@ Register Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" TagPrefix="cc3"  %>
<%@ Register Src="usercontrols/signin.ascx" TagName="signin" TagPrefix="aa1" %>
<%@ Register Src="usercontrols/Search.ascx" TagName="catag" TagPrefix="aa6" %>
<%@ Register Src="usercontrols/SearchNew.ascx" TagName="SearchNew" TagPrefix="New" %>
<%@ Register Src="usercontrols/small_logo.ascx" TagName="logo" TagPrefix="S_logo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<%--<title>:: Just Calluz :: Tag Your Friend</title>--%>
<title>Register - JustCalluz | Sign Up & Tag Your Friends to Access Their Reviews</title>
<meta name='Title' content='Register - JustCalluz | Sign Up & Tag Your Friends to Access Their Reviews' />
<meta name='description' content='Register on JustCalluz for free and tag your friends to know about their reviews and ratings for Movies, Events, Restaurants, Pubs etc. Simply enter your contact number to start the process.' />
<meta name='keywords' content='justcalluz registration, justcalluz sign up, justcalluz registration, justcalluz register, justcalluz free registeration, justcalluz tagging, local search, yellow pages listing, business listing' />
		
<link href="css/inner_style.css" rel="stylesheet" type="text/css" />
<link href="css/style.css" rel="Stylesheet" type="text/css" />
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
<div class="content_innermid" style="width:100%;">
  <table width="100%" border="0">
    <tr>
       <td height="30"><strong><a href="Default.aspx">Home</a></strong> &gt; Register</td>
    </tr>
    <tr>
      <td align="left">
         <div class="line">   FAQs </div>

<div class="text_content" >
<br/>
 <p>  <b> 1. What is Tag Your Friend? </b>  <br/>
 Tag Your Friend is an exciting feature that lets you know ratings and reviews of restaurants, theatres, pubs or any service that your tagged friends have given. 
Eg: Your tagged friend has written a review or rated Mainland China Restaurant. In the friends review section of Mainland China you can view your friends review
 </p>
 
<p>  <b>  2.Do I need to have a Justdial account for using this feature? </b> <br/>
  Yes, you would need a Justdial account for using this feature. This is an easy process, just click on the New User Sign Up link and follow the steps. It is Free.</p>
  
 <p><b> 3.How do I tag a friend? </b></p>	
  <p ><ul style="padding-left:5%;">
  <li> Log into Justdial.com </li>
   <li> Go to the 'Tag Your Friend' page.</li>
    <li> Enter your friend's Mobile number. </li>
     <li> The friend will be added to tagged friends list.</li>
      <li> Congrats! You have tagged your friend.</li>
       <li> In case you cannot find your friends, click on 'Did Not Find Your Friend?'</li>
      <li> You can also tag your friends by sending them an email invite.</li>

  </ul></p>
<p>  <b> 4.Apart from my reviews/ratings what other information can be seen by my network?	</b> <br/>
  Your network of friends can see your Name, your uploaded photo and your reviews. No personal information is displayed.</p>
  
  
 <p>  <b> 5.Do I need to provide my Mobile number? </b> <br/>
  You have to register through your mobile number. You can edit your number from edit profile section after log in.	<br/> </p>
  
  <p> <b>  6.Can I edit my profile? </b> <br/>
  You can edit your profile anytime once you sign in. Ensure that you keep your profile information updated. </p><br />
      </div>

      </td>
    </tr>
    </table>
</div>
</div>
<!-- end of the content-->
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
