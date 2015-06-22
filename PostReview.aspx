<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PostReview.aspx.cs" Inherits="PostReview" %>
<%@ Register Src="usercontrols/signin.ascx" TagName="signin" TagPrefix="aa1" %>
<%@ Register Src="usercontrols/footer1.ascx" TagName="footer1" TagPrefix="aa10" %>
<%@ Register Src="usercontrols/footer2.ascx" TagName="footer2" TagPrefix="aa11" %>
<%@ Register Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" TagPrefix="cc3"  %>
<%@ Register Src="usercontrols/Search.ascx" TagName="Search" TagPrefix="searchrecords" %>
<%@ Register Src="usercontrols/Search.ascx" TagName="categories" TagPrefix="cat" %>
<%@ Register Src="usercontrols/SponsoredLinks.ascx" TagName="Splinks" TagPrefix="aa3" %>
<%@ Register Src="usercontrols/BottomMidContent.ascx" TagName="Contentmid" TagPrefix="bcm" %>
<%@ Register Src="usercontrols/BottomContent.ascx" TagName="Bottomcontent" TagPrefix="bcon" %>
<%@ Register Src="~/usercontrols/topimage.ascx" TagName="topimage" TagPrefix="aa2" %>
<%@ Import Namespace="System.Data" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>:: Justcalluz :: Home page</title>
<link href="css/style.css" rel="stylesheet" type="text/css" />

</head>
<body>
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <div class="layout">
<aa1:signin ID="SignIn1" runat="server" />
<aa2:topimage ID="iud" runat="server" />
<div class="search" align="center">
 <searchrecords:Search ID="search1" runat="server" />
</div>
<div class="selection" align="center">
<cat:categories ID="categories" runat="server" />
</div>

<!-- staart the Content-->
<div class="content">
<div class="content_left" style="width:75%">
<table width="100%" border="0"  >
  
  <tr>
    <td class="select_menu" style="padding-left:3px;">Home
    >
    <asp:Label ID="Label1" runat="server" BackColor="#ECCEF5"></asp:Label>
    ><span id="breadcrumbSpan" itemprop="title">Rate this listing</span></td>
  </tr>
  <tr>
    <td style="background:url(images/event_send1.png) no-repeat" height="39" valign="center"><table width="100%" border="0">
  <tr>
    <td width="9%">&nbsp;</td>
    <td width="91%" class="bottam">Rate - <asp:Label ID="lblCompanyName" runat="server" BackColor="#ECCEF5"></asp:Label></td>
    </tr>
</table>
</td>
  </tr>
  <tr>
    <td ><table width="100%" border="0">
  <tr>
    <td width="100%" height="28" valign="top" ><table width="100%" border="0">
          <tr>
            <td width="19%" height="25" align="right" valign="top" ><font color="#ff7100" class="star">*</font><span class="list">Rate it</span></td>
            <td width="3%" align="center" valign="top"><strong>:</strong></td>
            <td width="78%" height="30" align="left"><table width="100%" border="0">
              <tr>
                <td width="4%">
                     <asp:RadioButton ID="radBtnExcellent" runat="server" GroupName="Rating"/> 
                </td>
                <td width="16%" height="25">Excellent</td>
                <td width="80%">&nbsp;</td>
              </tr>
              <tr>
                <td><asp:RadioButton ID="radBtnVeryGud" runat="server" GroupName="Rating" /></td>
                <td height="25">Very Good </td>
                <td>&nbsp;</td>
              </tr>
              <tr>
                <td><asp:RadioButton ID="radBtnGud" runat="server" GroupName="Rating" /></td>
                <td height="25">Good</td>
                <td>&nbsp;</td>
              </tr>
              <tr>
                <td><asp:RadioButton ID="radBtnAvg" runat="server"  GroupName="Rating" /></td>
                <td height="25">Average </td>
                <td>&nbsp;</td>
              </tr>
              <tr>
                <td><asp:RadioButton ID="radBtnPoor" runat="server" GroupName="Rating" class="style2" /> </td>
                <td height="25">Poor </td>
                <td>&nbsp;</td>
              </tr>
              <tr>
                <td height="25" colspan="3"><span id="ratingErr"><asp:CustomValidator ID="radBtnRequired" runat="server" EnableClientScript="true" OnServerValidate="radBtnRequired_ServerValidate" ValidationGroup="PostReview">*</asp:CustomValidator>
            </span></td>
                </tr>
            </table></td>
          </tr>
          <tr>
            <td height="37" align="right"><font color="#ff7100" class="star">*</font><span class="list">Name</span></td>
            <td align="center"><strong>:</strong></td>
            <td height="37" align="left"><span class="row">
               <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvName" runat="server" ErrorMessage="Please enter Name" ControlToValidate="txtName" 
            ValidationGroup="PostReview">*</asp:RequiredFieldValidator>
            </span></td>
          </tr>
          <tr>
            <td height="36" align="right"><font color="#ff7100" class="star">*</font><span class="list">Mobile No</span></td>
            <td align="center"><strong>:</strong></td>
            <td height="36" align="left"><span class="row">
             <asp:TextBox ID="txtmobno" runat="server" MaxLength="11"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvMob" runat="server" 
            ControlToValidate="txtmobno" ErrorMessage="Please enter Mobile Number" ValidationGroup="PostReview">*</asp:RequiredFieldValidator>
            <asp:RangeValidator ID="rangvalMob" runat="server" ErrorMessage="The Mobile number should start with zero" MinimumValue="0" ControlToValidate="txtmobno" 
                            MaximumValue="1" ValidationGroup="PostReview">*</asp:RangeValidator>
            </span></td>
          </tr>
          <tr>
            <td height="37" align="right"><font color="#ff7100" class="star">*</font><span class="list">Email ID</span></td>
            <td align="center"><strong>:</strong></td>
            <td height="37" align="left"><span class="row">
              <asp:TextBox ID="txtemailid" runat="server"></asp:TextBox>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtemailid" 
            ErrorMessage="Please enter valid email id Eg: XXX@xx.xxx" 
            ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
            ValidationGroup="PostReview">*</asp:RegularExpressionValidator>
            </span></td>
          </tr>
          <tr>
            <td height="89" align="right" valign="top"><font color="#ff7100" class="star">*</font><span class="list">Review</span></td>
            <td align="center" valign="top"><strong>:</strong></td>
            <td height="89" align="left"> <asp:TextBox ID="txtReview" runat="server" TextMode="MultiLine" Columns="50" Rows="5"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvReview" runat="server" 
            ControlToValidate="txtReview" ErrorMessage="Please enter Review" 
            ValidationGroup="PostReview">*</asp:RequiredFieldValidator></td>
          </tr>
          <tr>
            <td height="38" align="right"><font color="#ff7100" class="star">*</font><span class="list">Upload Your Photo(Optional)</span></td>
            <td>&nbsp;</td>
            <td align="left"><span class="row">
              <asp:FileUpload ID="Imgupload" runat="server" />
            </span></td>
          </tr>
          <tr>
            <td height="25">&nbsp;</td>
            <td>&nbsp;</td>
            <td align="left"><table width="100%" border="0">
              <tr>
                <td width="12%" height="30"><asp:ImageButton ID="ImgBtnSubmitReview" runat="server" 
            ImageUrl="images/button3.jpg" onclick="ImgBtnSubmitReview_Click" ValidationGroup="PostReview" /></td>
                <td width="88%">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:ImageButton ID="ImgBtnBackReview" runat="server" 
            ImageUrl="images/back.png" onclick="ImgBtnBackReview_Click" /></td>
              </tr>
            </table></td>
          </tr>
        </table></td>
  </tr>
</table>
</td>
  </tr>

</table>
 </div>
<div class="content_right" style="width:20%">
  <table width="100%" border="0">
    <tr>
      <td  align="center"><img src="images/image_gallery.gif" width="160" height="500" /></td>
    </tr>
    <tr>
      <td></td>
    </tr>
   
  </table>
</div>
</div>
<div class="content_midbootam" >
<bcm:Contentmid ID="contentmid" runat="server" />
</div>
<div class="content_midbootam" ><table width="100%" border="0">
  <tr>
    <td height="" ><hr/></td>
  </tr>
</table>
</div>
<div class="content_bootam_center">
<bcon:Bottomcontent ID="bottomcontent" runat="server" />

</div>

<div class="footer" align="center" style="padding-top:5px; " >
  <aa10:footer1 ID="footer1" runat="server" />
  <aa11:footer2 ID="footer2" runat="server" />
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
