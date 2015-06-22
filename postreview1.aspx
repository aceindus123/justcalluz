<%@ Page Language="C#" AutoEventWireup="true" CodeFile="postreview1.aspx.cs" Inherits="postreview" %>
<%@ Register Src="usercontrols/signin.ascx" TagName="signin" TagPrefix="aa1"  %>
<%--<%@ Register Src="usercontrols/topimage.ascx" TagName="topimage" TagPrefix="aa2" %>--%>
<%--<%@ Register Src="usercontrols/boxes.ascx" TagName="boxes" TagPrefix="aa5" %>--%>
<%@ Register Src="usercontrols/Search.ascx" TagName="catag" TagPrefix="aa6" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="AjaxToolkit" %>
<%@ Register Src="usercontrols/footer1.ascx" TagName="footer1" TagPrefix="aa10" %>
<%@ Register Src="usercontrols/footer2.ascx" TagName="footer2" TagPrefix="aa11" %>
<%@ Register Src="usercontrols/BottomContent.ascx" TagName="Bottomcontent" TagPrefix="bcon" %>
<%@ Register Src="usercontrols/BottomMidContent.ascx" TagName="Contentmid" TagPrefix="bcm" %>
<%@ Register Src="usercontrols/SearchNew.ascx" TagName="newsearch" TagPrefix="nsearch"%><%@ Register Src="usercontrols/SponsoredLinks.ascx" TagName="Splinks" TagPrefix="aa3" %>
<%@ Register Src="usercontrols/small_logo.ascx" TagName="logosmall" TagPrefix="lgsmall" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />

    <title>Justcalluz/Post Review</title>
    <%--<link href="includes/style1.css" rel="Stylesheet" type="text/css" />--%>
     <link href="css/style.css" rel="stylesheet" type="text/css" />
  <link href="css/inner_style.css" rel="Stylesheet" type="text/css" />
  <style type="text/css">
.ratingEmpty
{
background-image: url(images/empty.png);
width:30px;
height:30px;
}
.ratingFilled
{
background-image: url(images/active.png);
width:30px;
height:30px;
}
.ratingSaved
{
 background-image: url(images/active.png);
width:30px;
height:30px;
}
</style>
</head>
<body>
 <form id="form1" runat="server">
 <asp:ScriptManager ID="ScriptManager1" runat="server">
 </asp:ScriptManager>
 <div class="layout">
 <div class="signin">
<aa1:signin ID="SignIn1" runat="server" />
</div>
<div class="header">
<%--<div class="header_top"></div>--%>
<div class="header_logo">
<lgsmall:logosmall ID="lglogo" runat="server" />
</div>
<div class="header_search">
<nsearch:newsearch ID="search" runat="server" />
</div>
</div>
<div class="category_box">
<aa6:catag ID="dff" runat="server" />
</div>
<%--<div class="logo" style="width:934px; height:62px; float:left; padding:15px;">
  <a href="#"><img src="images/logo_small.jpg" width="200" height="62" style="border:none" /></a></div>--%>
 <div class="content" style="padding:0; margin:0;">
<%--<hr/>--%>
<div class="content_innermid" style="width:79%;">
 <table width="100%" border="0"  >
  <tr>
    <td style="background:url(images/event_send2.png) no-repeat" height="39" valign="center"><table width="100%" border="0">
      <tr>
        <td width="6%" align="left" style="padding-left:10px;"><a href="#"><img alt="HomeDecorIcon" src="images/icons/Home Decor &amp; Furnishings.png" width="32" height="32" style="border:none"  /></a></td>
        <td width="2%">&nbsp;</td>
        <td width="92%" align="left" valign="middle" class="mid_menu"> &nbsp;&nbsp;&nbsp;Write A Review </td>
      </tr>
    </table></td>
  </tr>
  <tr>
    <td height="30" style="font-family:Arial; color:green;">Please feel free to share your opinions on your very own personal experiences   about this business and help others choose the best.</td>
  </tr>
  <tr><td></td></tr>
  <tr><td></td></tr>
  <tr>
    <td height="30" style="font-family:Arial;"><table width="100%" border="0">
      <tr>
        <td width="19%" valign="top" align="right">Review For</td>
        <td width="4%" align="center" valign="top"><strong>:</strong></td>
        <td class="style1"><asp:TextBox ID="txtrev" runat="server" ReadOnly="true" Enabled="false" Width="219px"></asp:TextBox></td>
      </tr>
      <tr>
        <td>&nbsp;</td>
        <td align="center">&nbsp;</td>
        <td>(<span class="star">*</span> Fields are   mandatory.)</td>
      </tr>
      <tr>
        <td valign="top" align="right">Rate it<span class="star"> *</span></td>
        <td align="center" valign="top"><strong>:</strong></td>
         <td height="40px" class="style1" colspan="2">
  
       
      <AjaxToolkit:Rating ID="ratingcnt" runat="server" OnChanged="RatingControlChanged" 
  StarCssClass="ratingEmpty" WaitingStarCssClass="ratingSaved" EmptyStarCssClass="ratingEmpty" 
  FilledStarCssClass="ratingFilled">
        </AjaxToolkit:Rating>
        <asp:Label ID="lblmsg" runat="server" Text="Drag on no.of stars you want to vote" Font-Names="monotype corsiva" Font-Size="Medium" ForeColor="#003366"></asp:Label>
      </td>
      </tr>
      <tr>
        <td valign="top" align="right">Your Name <span class="star"> *</span></td>
        <td align="center" valign="top"><strong>:</strong></td>
        <td class="style3"><asp:TextBox ID="txtname" runat="server" Width="219px"></asp:TextBox>
      <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
          ErrorMessage="should not be empty" ControlToValidate="txtname" 
          ValidationGroup="postreview">*</asp:RequiredFieldValidator>
                                         </td>
      </tr>
       <tr>
        <td valign="top" align="right">City <span class="star"> *</span></td>
        <td align="center" valign="top"><strong>:</strong></td>
        <td class="style3"><asp:TextBox ID="txtcity" runat="server" Width="219px"></asp:TextBox>
      <asp:RequiredFieldValidator ID="reqcity" runat="server" 
          ErrorMessage="please enter the city" ControlToValidate="txtcity" 
          ValidationGroup="postreview">*</asp:RequiredFieldValidator>
                                         </td>
      </tr>
      <tr>
        <td valign="top" align="right">Your Email Id<span class="star"> *</span></td>
        <td align="center" valign="top"><strong>:</strong></td>
        <td height="30px" class="style1"><asp:TextBox ID="txtid" runat="server" Width="219px"></asp:TextBox>
      <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
          ErrorMessage="please enter email id" ControlToValidate="txtid" 
          ValidationGroup="postreview">*</asp:RequiredFieldValidator>
      <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
          ErrorMessage="invalid format of emailid" ControlToValidate="txtid" 
          ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
          ValidationGroup="postreview">*</asp:RegularExpressionValidator>
                                         </td>
      </tr>
       <tr><td align="right">Phone No<asp:Label ID="Label4" runat="server" Text="*" ForeColor="Red"></asp:Label></td>
       <td align="center" valign="top"><strong>:</strong></td>
  <td height="30px" class="style1"><asp:TextBox ID="txtno" runat="server" MaxLength="11" Width="219px"></asp:TextBox>
      <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
          ErrorMessage="Only numbers are allowed" ValidationExpression="\d{11}" 
          ControlToValidate="txtno" ValidationGroup="postreview">*</asp:RegularExpressionValidator>
      <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
          ErrorMessage="please enter Phone no" ControlToValidate="txtno" 
          ValidationGroup="postreview">*</asp:RequiredFieldValidator>
      <asp:RangeValidator ID="RangeValidator1" runat="server" 
          ControlToValidate="txtno" ErrorMessage="Number must start with 0" 
          MaximumValue="1" MinimumValue="0" ValidationGroup="postreview">*</asp:RangeValidator>
      <asp:RangeValidator ID="rngnoofdigits" runat="server" 
          ErrorMessage="Number must have 11 digits" MaximumValue="11" 
          MinimumValue="0" ControlToValidate="txtno" ValidationGroup="postreview">*</asp:RangeValidator>
                                         </td>
                                         
                                         
  </tr>
      <tr>
        <td>&nbsp;</td>
        <td align="center">&nbsp;</td>
        
      </tr>
      <tr>
        <td valign="top" align="right">Your Review<span class="star"> *</span></td>
        <td align="center" valign="top"><strong>:</strong></td>
        <td height="30px" class="style1">
        <asp:TextBox ID="txtreview" runat="server" TextMode="MultiLine" Height="76px" Width="219px"></asp:TextBox>
     <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
         ErrorMessage="Enter your comment here" ControlToValidate="txtreview" 
         ValidationGroup="postreview">*</asp:RequiredFieldValidator>
                                         </td>
      </tr>
      <tr>
        <td align="right">Upload Your 
Photo Here</td>
        <td align="center" valign="top"><strong>:</strong></td>
         <td class="style1"><asp:FileUpload ID="photo" runat="server" 
         Height="26px" Width="219px" />
         </td>
      </tr>
       <tr>
       <td></td>
       <td></td>
 <td class="style1">
     <asp:TextBox ID="txtcap" runat="server" Height="22px" 
         Width="219px" ForeColor="GrayText"></asp:TextBox></td>
     <AjaxToolkit:TextBoxWatermarkExtender ID="TextBoxWatermarkExtender1" runat="server" TargetControlID="txtcap" WatermarkText="Enter any caption here">
     </AjaxToolkit:TextBoxWatermarkExtender>
     
     </tr>
      <tr>
       
        <td height="45" colspan="3"><p><strong>Note : </strong>Justcalluz is not responsible or liable in any   way for ratings and</p>
          <p> reviews posted by its users.</p></td>
      </tr>
      <tr>
        
        <td align="center" colspan="3"><asp:ImageButton ID="ImageButton1" runat="server" 
             ImageUrl="images/submit.png" OnClick="submit_Click" AlternateText="SubmitButton" Height="35px" 
             ValidationGroup="postreview"/>&nbsp;&nbsp;&nbsp;
              <asp:ImageButton ID="back" runat="server" CausesValidation="false" AlternateText="BackButton" 
                 ImageUrl="images/back_review.png" OnClick="back_Click" Height="30px" Width="96px"/>
                 </td>
      </tr>
      <tr>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
      </tr>
      <tr><td> <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
                     ShowMessageBox="True" ShowSummary="False" ValidationGroup="postreview" /></td></tr>
    </table></td>
  </tr>
 
  </table>
 </div>
<div class="content_innerright">
<div class="contentbox_top">Sponsor Ads</div>
<div class="contentbox_mid">
  <table width="100%" border="0">
    <tr>
      <td width="100%" align="center" valign="top">
       <img src="images/sample.gif" alt="SponsorAds" width="175" height="600" /><br />
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
</div>
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
    
     
    </form>
</body>
</html>
