<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Freelisting.aspx.cs" Inherits="Freelisting" %>
<%@ Register Assembly="MSCaptcha" Namespace="MSCaptcha" TagPrefix="cc1" %>
<%@ Register Src="usercontrols/signin.ascx" TagName="signin" TagPrefix="aa1"  %>
<%@ Register Src="usercontrols/catageories.ascx" TagName="catag" TagPrefix="aa6" %>
<%@ Register Src="usercontrols/footer1.ascx" TagName="footer1" TagPrefix="aa10" %>
<%@ Register Src="usercontrols/footer2.ascx" TagName="footer2" TagPrefix="aa11" %>
<%@ Register Src="usercontrols/BottomContent.ascx" TagName="Bottomcontent" TagPrefix="bcon" %>
<%@ Register Src="usercontrols/BottomMidContent.ascx" TagName="Contentmid" TagPrefix="bcm" %>
<%@ Register Src="usercontrols/SearchNew.ascx" TagName="SearchNew" TagPrefix="New" %>
<%@ Register Src="usercontrols/small_logo.ascx" TagName="logo" TagPrefix="S_logo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<%--<title>:: Justcalluz :: Home page</title>--%>
<title>Free Listing - JustCalluz | List In Your Business For Free</title>
<meta name='Title' content='Free Listing - JustCalluz | List In Your Business For Free' />
<meta name='description' content='Place a free listing on Justcalluz and reach out to millions of people by attract new customers as well as provide valuable information to existing customers.Fill out a simple form and join instantly.' />
<meta name='keywords' content='justcalluz free listing, justcalluz advertising, online business promotion, online advertising, free ads online, local business marketing, local business promotion' />
		
<link href="css/style.css" rel="stylesheet" type="text/css" />
<link href="css/inner_style.css" rel="stylesheet" type="text/css" />
</head>
<body>
<form id="form1" runat="server">
<script type="text/javascript">
    function onlyNos(e, t) {
        try {
            if (window.event) {
                var charCode = window.event.keyCode;
            }
            else if (e) {
                var charCode = e.which;
            }
            else { return true; }
            if (charCode > 31 && (charCode < 48 || charCode > 57)) {
                return false;
            }
            return true;
        }
        catch (err) {
            alert(err.Description);
        }
    }
        </script>
         <script type="text/javascript">
             function Alphabets(nkey) {
                 var keyval
                 if (navigator.appName == "Microsoft Internet Explorer") {
                     keyval = window.event.keyCode;
                 }
                 else if (navigator.appName == 'Netscape') {
                     nkeycode = nkey.which;
                     keyval = nkeycode;
                 }
                 //For A-Z
                 if (keyval >= 65 && keyval <= 90) {
                     return true;
                 }
                 //For a-z
                 else if (keyval >= 97 && keyval <= 122) {
                     return true;
                 }
                 //For Backspace
                 else if (keyval == 8) {
                     return true;
                 }
                 //For General
                 else if (keyval == 0) {
                     return true;
                 }
                 //For Space
                 else if (keyval == 32) {
                     return true;
                 }
                 else {
                     return false;
                 }
             } // End of the function


    </script>
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
<div class="content_innermid" style="width:100%">
<%--<div class="contentmid_box" >--%>
  <div class="contentmid_boxmid" style="width:77.5%; padding:none; background:none; border:dotted 1px #666"><table width="100%" border="0" bgcolor="#ECF9FF">
  <tr><td height="15">
   <asp:Label ID="lblMessage" runat="server"></asp:Label>
    <asp:Label ID="lblerror" runat="server"></asp:Label>
   </td></tr>
    <tr>
      <td><table width="100%" border="0" bgcolor="">
        <tr>
          <td height="35" colspan="3" style="background:url(images/search_midtop.png) no-repeat"><table width="100%" border="0">
<tr>
    <td class="location"  height="35" style="padding-left:15px; background:url(images/search_midtop.png) no-repeat "><font color="white">Welcome to Just Call Uz :: FreeListing</font></td>
  </tr>
</table>
</td>
          </tr>
        <tr>
          <td height="20" colspan="3" align="left" style="padding-left:10px;"><img src="images/pencil-icon.png" alt="" width="24" height="24" />
            <label style="color:#000" ><span class="sub_menu"><b>contact person information </b></span></label></td>
        </tr>
        <tr>
          <td height="20" colspan="3" align="left" style="padding-left:10px;"><hr/></td>
        </tr>
        
        <tr>
          <td width="24%" align="right"> <span class="star">*</span><span class="list">Name </span></td>
          <td width="3%" align="center"><strong>:</strong></td>
          <td width="73%" height="35" align="left"><span class="row">
             <asp:TextBox ID="txtfname" runat="server" Width="190px" onkeypress="return Alphabets(event);"></asp:TextBox>                
    <asp:RequiredFieldValidator ID="rfName" runat="server" 
            ErrorMessage="please enter Name" ControlToValidate="txtfname" ValidationGroup="FreeListing" Text="*"></asp:RequiredFieldValidator>
    
            </span></td>
          </tr>
        <tr>
          <td align="right"><span class="star">*</span><span class="list">Email address</span></td>
          <td align="center"><strong>:</strong></td>
          <td height="35" align="left"><span class="row">
            <asp:TextBox ID="txtemail" runat="server" Width="190px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfEmail" runat="server" 
            ErrorMessage="please enter Email Id" ControlToValidate="txtemail" Text="*" ValidationGroup="FreeListing"></asp:RequiredFieldValidator>                
            <asp:RegularExpressionValidator ID="revEmail" runat="server" 
                    ErrorMessage="Please enter valid email address" ControlToValidate="txtemail" 
                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
                    ValidationGroup="FreeListing">*</asp:RegularExpressionValidator>
            </span></td>
          </tr>
        <tr>
          <td align="right" ><span class="star">*</span><span class="list"> Mobile</span></td>
          <td align="center" ><strong>:</strong></td>
          <td height="35" align="left"><span class="row">
          <asp:TextBox ID="txtcode" runat="server" ReadOnly="true" Text="+91" Width="30px"></asp:TextBox>-
             <asp:TextBox ID="txtmob" runat="server" Width="153px" MaxLength="10" onkeypress="return onlyNos(event,this);"></asp:TextBox><b style="font-size:11px;">
                (E.g:- 09000465921)</b>           
                <asp:RequiredFieldValidator ID="rfMob" runat="server" 
            ErrorMessage="please enter Mobile Number" ControlToValidate="txtmob" Text="*" ValidationGroup="FreeListing">*</asp:RequiredFieldValidator>
             <asp:RegularExpressionValidator ID="revMob" runat="server" 
            ErrorMessage="Enter mobile number only ten digits(starting number should starts from 1 to 9 digits)" 
            ControlToValidate="txtmob" ValidationExpression="^[01]?[- .]?(\([1-9]\d{2}\)|[1-9]\d{2})[- .]?\d{3}[- .]?\d{4}$" Display="Dynamic"
            ValidationGroup="FreeListing"></asp:RegularExpressionValidator>
        <%--<asp:RangeValidator ID="rvMob" runat="server" MaximumValue="1" MinimumValue="0" 
            ErrorMessage="Mobile number should start with zero" ControlToValidate="txtmob" 
            ValidationGroup="FreeListing">*</asp:RangeValidator>--%></span></td>
          </tr>
        <tr>
          <td align="right"><%--<span class="star">*</span>--%> <span class="list">Landline </span></td>
          <td align="center"><strong>:</strong></td>
          <td height="35" align="left"><span class="row"><asp:TextBox ID="txtlanl" runat="server" Width="190px" MaxLength="11" onkeypress="return onlyNos(event,this);"></asp:TextBox><b style="font-size:11px;">
                (E.g:- 04066136226)</b>
                 <asp:RangeValidator ID="rvLandline" runat="server" MaximumValue="1" MinimumValue="0" 
            ErrorMessage="Phone number should start with zero" ControlToValidate="txtlanl" 
            ValidationGroup="FreeListing">*</asp:RangeValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
            ErrorMessage="Please enter mobile number of 11 digits" 
            ControlToValidate="txtlanl" ValidationExpression="\d{11}" 
            ValidationGroup="FreeListing">*</asp:RegularExpressionValidator></span></td>
          </tr>
        </table></td>
      </tr>
    <tr>
      <td><div class="contentmid_boxmid" style="width:100%; background:none; padding:none" ><table width="100%" border="0">
        <tr>
          <td><table width="100%" border="0">
            <tr>
                    <td height="20" colspan="3" align="left" style="padding-left:10px;"><img alt="pencil-icon" src="images/pencil-icon.png" alt="" width="24" height="24" /><label style="color:#000" ><span class="sub_menu"><b>Business/ company information</b></span></label></td>
                  </tr>
                  <tr>
                    <td  colspan="3" ><hr/></td>
                    </tr>
                  <tr>
                    <td width="24%" align="right"><span class="star">*</span> <span class="list">Title of the process</span></td>
                    <td width="3%" align="center"><strong>:</strong></td>
                    <td width="73%" height="35" align="left"><asp:TextBox ID="txtbname" runat="server" Width="190px" onkeypress="return Alphabets(event);"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvTitle" runat="server" 
            ErrorMessage="please enter type" ControlToValidate="txtbname" ValidationGroup="FreeListing">*</asp:RequiredFieldValidator>
                </td>
                  </tr>
                  <tr>
                    <td align="right"><span class="star">*</span><span class="list">kind of listing</span></td>
                    <td align="center"><strong>:</strong></td>
                    <td height="35" align="left"><span class="row">
                     <asp:DropDownList ID="ddlCategory" runat="server" Width="190px" 
                              onselectedindexchanged="ddlCategory_SelectedIndexChanged" AutoPostBack="true">
                          </asp:DropDownList>
                
                <asp:RequiredFieldValidator ID="rfCat" runat="server" 
            ErrorMessage="Please select Kind of Business" ControlToValidate="ddlCategory" 
                    Text="*" ValidationGroup="FreeListing" InitialValue="Select Listing"></asp:RequiredFieldValidator>
               
                    </span></td>
                  </tr>
                  <tr>
                    <td align="right"><span class="star">*</span> <span class="list">Speciality </span></td>
                    <td align="center"><strong>:</strong></td>
                    <td height="29" align="left">   <span class="row">
                      <asp:DropDownList ID="ddlSubCat" runat="server" Width="190px"  >
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="rfSubCat" runat="server" 
                    ErrorMessage="Please select Speciality" InitialValue="Select Speciality" 
                    Text="*" ValidationGroup="FreeListing" ControlToValidate="ddlSubCat"></asp:RequiredFieldValidator>
                   
                    </span></td>
                  </tr>
                  <tr>
                    <td align="right"><%--<span class="star">*</span>--%> <span class="list">Website</span></td>
                    <td align="center"><strong>:</strong></td>
                    <td height="35" align="left"><span class="row">
                     <asp:TextBox ID="txtweb" runat="server" Width="190px"></asp:TextBox>
                <asp:RegularExpressionValidator ID="revWebsite" runat="server" 
                    ErrorMessage="Please enter Website correctly Eg: http://www.justcalluz.com" ControlToValidate="txtweb" 
                    ValidationExpression="http(s)?://([\w-]+\.)+[\w-]+(/[\w- ./?%&amp;=]*)?" 
                    ValidationGroup="FreeListing">*</asp:RegularExpressionValidator>
                    </span></td>
                  </tr>
                  <tr>
                    <td align="right"><span class="star">*</span> <span class="list">Address</span></td>
                    <td align="center"><strong>:</strong></td>
                    <td height="30" align="left"> <asp:TextBox ID="txtaddr" runat="server" TextMode="MultiLine" Width="190px" 
            Height="50px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfAddress" runat="server" 
            ErrorMessage="Please enter Address" ControlToValidate="txtaddr" 
            ValidationGroup="FreeListing">*</asp:RequiredFieldValidator>  Enter the address</td>
                  </tr>
                  <tr>
                    <td align="right"><span class="star">*</span> <span class="list">Area </span></td>
                    <td align="center"><strong>:</strong></td>
                    <td height="35" align="left"><span class="row">
                       <asp:TextBox ID="txtArea" runat="server" Width="190px" onkeypress="return Alphabets(event);"></asp:TextBox><%--<b style="font-size:11px;">
                (E.g:- 04066136226)</b>--%>
                <asp:RequiredFieldValidator ID="rfArea" runat="server" 
                    ErrorMessage="Please enter Area" ControlToValidate="txtArea" 
                    ValidationGroup="FreeListing">*</asp:RequiredFieldValidator>
                    </span></td>
                  </tr>
                  <tr>
                    <td align="right"><span class="star"></span> <span class="list">LandMark</span></td>
                    <td align="center"><strong>:</strong></td>
                    <td height="35" align="left"><span class="row">
                       <asp:TextBox ID="txtlanm" runat="server" Width="190px"></asp:TextBox>
                    </span></td>
                  </tr>
                  <tr>
                    <td align="right"><span class="star">*</span> <span class="list">state</span></td>
                    <td align="center"><strong>:</strong></td>
                    <td height="35" align="left"><span class="row">
                       <asp:DropDownList ID="ddlState" runat="server" Width="190px" 
                              onselectedindexchanged="ddlState_SelectedIndexChanged" AutoPostBack="true">
               </asp:DropDownList>    
                <asp:RequiredFieldValidator ID="rfState" runat="server" 
            ErrorMessage="please enter State" ControlToValidate="ddlState" 
                    InitialValue="Select State" ValidationGroup="FreeListing">*</asp:RequiredFieldValidator>
                    </span></td>
                  </tr>
                  <tr>
                    <td align="right"><span class="star">*</span> <span class="list">Select City </span></td>
                    <td align="center"><strong>:</strong></td>
                    <td height="35" align="left"><span class="row">
                      <asp:DropDownList ID="ddlCity" runat="server" Width="190px">
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="rfCity" runat="server" 
            ErrorMessage="please select  City" ControlToValidate="ddlCity" 
                    ValidationGroup="FreeListing" InitialValue="Select City">*</asp:RequiredFieldValidator>
                    </span></td>
                  </tr>
                  <tr>
                    <td align="right" ><span class="star">*</span> <span class="list">Pincode</span></td>
                    <td align="center" ><strong>:</strong></td>
                    <td height="35" align="left"><asp:TextBox ID="txtPincode" runat="server" Width="190px" MaxLength="6" onkeypress="return onlyNos(event,this);"></asp:TextBox><b style="font-size:11px;">
                (E.g:- 500073)</b>
                <asp:RequiredFieldValidator ID="rfPincode" runat="server" 
                    ErrorMessage="Please enter Pincode" ControlToValidate="txtPincode" 
                    ValidationGroup="FreeListing">*</asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="revPincode" runat="server" 
                    ErrorMessage="Enter pincode number only 6 digits(starting number should starts from 1 to 9 digits)" 
                    ControlToValidate="txtPincode" ValidationExpression="^[01]?[- .]?(\([1-9]\d{1}\)|[1-9]\d{1})[- .]?\d{2}[- .]?\d{2}$" Display="Dynamic"  
                    ValidationGroup="FreeListing"></asp:RegularExpressionValidator></td>
                  </tr>
                  <tr>
                    <td align="right"><span class="star"></span><span class="list">specify in any</span></td>
                    <td align="center"><strong>:</strong></td>
                    <td height="35" align="left"> <asp:TextBox ID="txtsia" runat="server" Width="190px"></asp:TextBox></td>
                  </tr>
                  <tr>
                    <td align="right">  
                    <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
                        <ContentTemplate>  
                    <cc1:CaptchaControl ID="ccjoin" runat="server" BackColor="AntiqueWhite" 
                     CaptchaBackgroundNoise="None" CaptchaHeight="40" CaptchaLength="5" 
                     CaptchaWidth="120" CaptchaLineNoise="None" CaptchaMinTimeout="5" 
                     CaptchaMaxTimeout="200" Width="120px" />
                     </ContentTemplate>
                     </asp:UpdatePanel>
                     </td>
                    <td align="center"><strong>:</strong></td>
                    <td height="35" align="left"> <asp:TextBox ID="txtvid" runat="server" Width="190px"></asp:TextBox></td>
                  </tr>
                  <tr>
                    <td align="right">
                     
                        <asp:Button ID="btnRefreshCapcha" runat="server" Text="Refresh Image" 
                           onclick="btnRefreshCapcha_Click" />
                      </td>
                    <td align="center">&nbsp;</td>
                    <td height="40" align="left">&nbsp;</td>
                  </tr>
                  <tr>
                    <td colspan="3"><hr/></td>
                  </tr>
                  <tr>
                    <td height="30" colspan="3" align="center" class="right_tab" style="padding-top:10px;" ><font color="#E14900">By clicking &quot;Post&quot; you agree and consent to 
                      Justcalluz.com Terms of Use and receive required notices from uz.</font></td>
                  </tr>
                  <tr>
                    <td height="30" colspan="3" align="center">
                    <asp:ImageButton ID="imgBtnAgree" runat="server" AlternateText="iagreeimgButton" ImageUrl="images/i-agree.png" onclick="imgBtnAgree_Click" ValidationGroup="FreeListing" /></td>
                    </tr>
                  <tr>
                    <td height="30" colspan="3" align="center" class="right_tab" style="padding-top:5px;"><font class="side_menu" color:"#005B88">Dear Guest, kindly submit all the marked details. Its kind of</font>  <span class="mid_menu"><strong class="mid_menu"><font color="#E84B00">mandatory</font></strong>. </span><span class="side_menu">What to</span> <span class="side_menu">do! Its not our fault. We are here to provide   the best of our services<strong> </strong></span><span class="mid_menu"><strong><font color="#E84B00"> 24*7</font></strong></span></td>
                  </tr>
            </table></td>
          </tr>
  </table>
  </div></td>
      </tr>
  </table>
</div>
<div class="content_innerright">
<div class="contentbox_top">Sponsor Ads</div>
<div class="contentbox_mid">
  <table width="100%" border="0">
    <tr>
      <td width="100%" valign="top">
      <img src="images/event/add2.png" width="175" alt="FreelistingSponserAds" height="600" /><br />
        <img src="images/event/search-job-2.png" alt="FreelistingSponserAds" width="175" height="300" /><br />
     </td>
    </tr>
    <tr>
      <td></td>
    </tr>
   
  </table>
</div>
<div class="contentbox_bottam"></div>
</div>
<%--</div>--%>
</div>
<div class="content_midbootam" >
<bcm:Contentmid ID="contentmid" runat="server" />
</div>
<div class="content_midbootam" ><table width="100%" border="0">
  <tr>
    <td height="" ></td>
  </tr>
</table>
</div>
<div class="content_bootam_center">
<bcon:Bottomcontent ID="bottomcontent" runat="server" />

</div>
<div class="footer" align="center" style="padding-top:5px; " >
    <aa10:footer1 ID="sdsa" runat="server" />
    <aa11:footer2 ID="poshv" runat="server" />
</div>
</div>
</div>
    </form>
</body>
</html>
