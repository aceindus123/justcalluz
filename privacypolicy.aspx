<%@ Page Language="C#" AutoEventWireup="true" CodeFile="privacypolicy.aspx.cs" Inherits="privacypolicy" %>
<%@ Register Src="usercontrols/signin.ascx" TagName="signin" TagPrefix="aa1"  %>
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
<title>Privacy Policy - Just Calluz</title>
<meta name='Title' content='Privacy Policy - Just Calluz' />
		
<link href="css/style.css" rel="stylesheet" type="text/css" />
<link href="css/inner_style.css" rel="Stylesheet" type="text/css" />
<script src="SpryAssets/SpryTabbedPanels.js" type="text/javascript"></script>
<link href="SpryAssets/SpryTabbedPanels.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <div class="layout">
<div class="signin">
<aa1:signin ID="awea" runat="server" />
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
<div class="content_innermid" style="width:100%;">
<div class="middle_search1">
<div class="middle_searchtop1">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Welcome to JustCallUz </div>
 <div class="middle_searchmid1"><table width="100%" border="0">
      <tr>
    <td class="mid2_menu" style="padding-left:30px; padding-top:10px; line-height:30px;"><font color="#002C40">
    <p align="justify">The sole motive of preparing the privacy policy is to maintain a cordial relationship between us and our users. In this document JustCallUz will be referred to as 'we', 'us', 'our' and 'ours'. Our users and clients will be referred to as 'theirs', 'them', 'you' and 'yours’. The privacy of your information is utmost important to us. Ultimately, this document will give you a clear perspective as to in which particular scenarios will your information be held confidential, and also what are the scenarios wherein your information will be shared.</p><hr/></font></td>
  </tr>
  <tr>
    <td class="sub_menu" style="padding-left:20px;"><font color="#C10000">Your Personal Information</font></td>
  </tr>
  <tr>
    <td class="mid2_menu" style="padding-left:30px; padding-top:10px; line-height:30px;"><font color="#002C40">
    <p align="justify">Your personal information such as your contact details, business relevant details and other necessary information pertaining to doing trade with JustCallUz will only be collected. Your personal information is utmost important to us, as the mode of communication becomes more easy and any important business function that has to be discussed, can be had through your personal information.</p><hr/></font></td>
  </tr>
  <tr>
     <td height="26" class="sub_menu" style="padding-left:20px;"><font color="#C10000">Sharing your information</font></td>
  </tr>
  <tr>
     <td  class="mid2_menu" style="padding-left:30px; padding-top:10px; line-height:30px;"><font color="#002C40">
         <p align="justify">There might be some scenarios, wherein sharing your personal information might be beneficial to both of us. A third-party member might be interested to trade with you and hence might require your information, as he foresees a viable business opportunity. However, it ultimately depends upon you whether you want to share your information, and based upon your consent only will we share your information.</p></font><hr/></td>
  </tr>

       <tr>
     <td height="26" class="sub_menu" style="padding-left:20px;"><font color="#C10000">Your financial transactions</font></td>
  </tr>
  <tr>
     <td  class="mid2_menu" style="padding-left:30px; padding-top:10px; line-height:30px;"><font color="#002C40">
         <p align="justify">When it comes to the payment part, we expect correct details of your card or otherwise, so that the entire payment process is carried out in a smooth manner without any flaws whatsoever. However once the transactions are carried out flawlessly, then after we will provide you the receipt or other relevant financial documentation.</p></font><hr/></td>
  </tr>
       <tr>
     <td height="26" class="sub_menu" style="padding-left:20px;"><font color="#C10000">When you may be contacted</font></td>
  </tr>
  <tr>
     <td  class="mid2_menu" style="padding-left:30px; padding-top:10px; line-height:30px;"><font color="#002C40">
         <p align="justify">In some situations, the advertisers/agents/subscribers might contact you in order to purchase the product or service or both that you are selling. The contact will be for business purposes only. This type of contact will be beneficial to you, as there are many other advertisers/agents/subscribers who might be interested to purchase your products or services.</p></font><hr/></td>
  </tr>
       <tr>
     <td height="26" class="sub_menu" style="padding-left:20px;"><font color="#C10000">Your Account</font></td>
  </tr>
  <tr>
     <td  class="mid2_menu" style="padding-left:30px; padding-top:10px; line-height:30px;"><font color="#002C40">
         <p align="justify">Once you are registered with JustCallUz and have been provided your account. Once your account has been created and the necessary login and other details provided to you, then after you will be solely responsible to maintain your account. If there are any technical glitches, then for sure our technical support team will help you with.</p></font><hr/></td>
  </tr>
        <tr>
     <td height="26" class="sub_menu" style="padding-left:20px;"><font color="#C10000">Information Security</font></td>
  </tr>
  <tr>
     <td  class="mid2_menu" style="padding-left:30px; padding-top:10px; line-height:30px;"><font color="#002C40">
         <p align="justify">JustCallUz implies the necessary technical and management procedures in order to secure your information online. We take effective and compliant steps in order to secure and store your information. If there is any technical malfunction due to an unavoidable situation then we will not be held responsible.</p></font><hr/></td>
  </tr>
       <tr>
     <td height="26" class="sub_menu" style="padding-left:20px;"><font color="#C10000">Policy Changes</font></td>
  </tr>
  <tr>
     <td  class="mid2_menu" style="padding-left:30px; padding-top:10px; line-height:30px;"><font color="#002C40">
         <p align="justify">The privacy policy document might be changing certain points in a future period of time. We encourage all our customers to kindly revisit this page frequently, so that they can be well equipped with our policies and hence can conduct business in a more efficient manner.</p></font><hr/></td>
  </tr>
      <tr>
     <td height="26" class="sub_menu" style="padding-left:20px;"><font color="#C10000">Dispute Resolution</font></td>
  </tr>
  <tr>
     <td  class="mid2_menu" style="padding-left:30px; padding-top:10px; line-height:30px;"><font color="#002C40">
         <p align="justify">If there are any disputes arising between us and our customers, then it will be entirely handled as per the court of law.</p></font><hr/></td>
  </tr>
</table>
</div>
 <div class="middle_searchbottam1"></div>
  
</div>
</div>
<!-- end of the mid Box-->
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
var TabbedPanels1 = new Spry.Widget.TabbedPanels("TabbedPanels1");
//-->
</script>
    </form>
</body>
</html>
