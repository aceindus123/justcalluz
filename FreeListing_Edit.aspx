<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FreeListing_Edit.aspx.cs" Inherits="FreeListing_Edit" %>


<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc2" %>
<%@ Register Assembly="MSCaptcha" Namespace="MSCaptcha" TagPrefix="cc1" %>
<%@ Register Src="usercontrols/signin.ascx" TagName="signin" TagPrefix="aa1"  %>
<%@ Register Src="usercontrols/Search.ascx" TagName="catag" TagPrefix="aa6" %>
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
<%--<title>Free Listing Business Info</title>--%>
<title>Free Listing - JustCalluz | List In Your Business For Free</title>
<meta name='Title' content='Free Listing - JustCalluz | List In Your Business For Free' />
<meta name='description' content='Place a free listing on Justcalluz and reach out to millions of people by attract new customers as well as provide valuable information to existing customers.Fill out a simple form and join instantly.' />
<meta name='keywords' content='justcalluz free listing, justcalluz advertising, online business promotion, online advertising, free ads online, local business marketing, local business promotion' />
	
<link href="css/style.css" rel="stylesheet" type="text/css" />
<link href="css/inner_style.css" rel="stylesheet" type="text/css" />
<style type="text/css">
        .modalBackground
        {  
        	background-color: Gray;  
        	filter: alpha(opacity=50);  
        	opacity: 0.50;
        }
       .updateProgress
       {  
       	border-width: 1px; 
        border-style: solid; 
        background-color: White;  
        position: absolute;  
        width: 180px;  
        height: 65px;
       }  
        .style1
        {
            width: 211px;
        }
     .style23
     {
         width: 103px;
         height: 83px;
     }
     </style>
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
    <td class="location"  height="35" style="padding-left:15px; background:url(images/search_midtop.png) no-repeat "><font color="white">Welcome to Just Call Uz :: Edit FreeListing</font></td>
  </tr>
</table>
</td>
          </tr>
        <tr>
          <td height="20" colspan="3" align="left" style="padding-left:10px;"><img alt="pencil-icon" src="images/pencil-icon.png" alt="" width="24" height="24" />
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
          <td align="right"><span class="star">*</span><span class="list"> Mobile</span></td>
          <td align="center"><strong>:</strong></td>
          <td height="35" align="left"><span class="row">
          <asp:TextBox ID="txtcode" runat="server" ReadOnly="true" Text="+91" Width="30px"></asp:TextBox>-
              <asp:TextBox ID="txtmob" runat="server" Width="153px" MaxLength="10" onkeypress="return onlyNos(event,this);"></asp:TextBox><b style="font-size:11px;">
                (E.g:- 9000465921)</b>           
<asp:RequiredFieldValidator ID="rfMob" runat="server" 
            ErrorMessage="please enter Mobile Number" ControlToValidate="txtmob" Text="*" ValidationGroup="FreeListing"></asp:RequiredFieldValidator>
             <asp:RegularExpressionValidator ID="revMob" runat="server" 
            ErrorMessage="Enter mobile number only ten digits(starting number should starts from 1 to 9 digits)" 
            ControlToValidate="txtmob" ValidationExpression="^[01]?[- .]?(\([1-9]\d{2}\)|[1-9]\d{2})[- .]?\d{3}[- .]?\d{4}$" Display="Dynamic"
            ValidationGroup="FreeListing"></asp:RegularExpressionValidator>
       <%-- <asp:RangeValidator ID="rvMob" runat="server" MaximumValue="1" MinimumValue="0" 
            ErrorMessage="Mobile number should start with zero" ControlToValidate="txtmob" 
            ValidationGroup="FreeListing">*</asp:RangeValidator>--%></span></td>
          </tr>
        <tr>
          <td align="right"><span class="star">*</span> <span class="list">Landline </span></td>
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
                    <td height="20" colspan="3" align="left" style="padding-left:10px;"><img src="images/pencil-icon.png" alt="" width="24" height="24" /><label style="color:#000" ><span class="sub_menu"><b>Business/ company information</b></span></label></td>
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
                    <td align="right"><span class="star">*</span> <span class="list">Website</span></td>
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
                    <td height="30" align="left"><asp:TextBox ID="txtaddr" runat="server" TextMode="MultiLine" Width="190px" 
            Height="50px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfAddress" runat="server" 
            ErrorMessage="Please enter Address" ControlToValidate="txtaddr" 
            ValidationGroup="FreeListing">*</asp:RequiredFieldValidator> Enter the address</td>
                  </tr>
                  <tr>
                    <td align="right"><span class="star">*</span> <span class="list">Area </span></td>
                    <td align="center"><strong>:</strong></td>
                    <td height="35" align="left"><span class="row">
                      <asp:TextBox ID="txtArea" runat="server" Width="190px" onkeypress="return Alphabets(event);"></asp:TextBox><b style="color:#093; font-size:11px;">
                </b>
                <asp:RequiredFieldValidator ID="rfArea" runat="server" 
                    ErrorMessage="Please enter Area" ControlToValidate="txtArea" 
                    ValidationGroup="FreeListing">*</asp:RequiredFieldValidator>
                    </span></td>
                  </tr>
                  <tr>
                    <td align="right"><span class="star"></span> <span class="list">LandMark</span></td>
                    <td align="center"><strong>:</strong></td>
                    <td height="35" align="left"><span class="row">
                        <asp:TextBox ID="txtlanmark" runat="server" Width="190px"></asp:TextBox>
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
                    <td align="right"><span class="star">*</span> <span class="list">Pincode</span></td>
                    <td align="center"><strong>:</strong></td>
                    <td height="35" align="left"><asp:TextBox ID="txtPincode" runat="server" Width="190px" MaxLength="6" onkeypress="return onlyNos(event,this);"></asp:TextBox><b style="font-size:11px;">
                (E.g:- 530075)</b>
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
                    <td height="35" align="left"><asp:TextBox ID="txtsia" runat="server" Width="190px"></asp:TextBox></td>
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
                    <td height="35" align="left"><asp:TextBox ID="txtvid" runat="server" Width="190px"></asp:TextBox></td>
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
                    <td colspan="3">&nbsp;</td>
                  </tr>
                  <tr>
                    <td height="30" colspan="3" align="center">
                   <asp:ImageButton ID="imgBtnUpdate" runat="server" 
        ImageUrl="images/update.png" AlternateText="UpdateimgButton"
        ValidationGroup="FreeListing" onclick="imgBtnUpdate_Click" />
         &nbsp;&nbsp;&nbsp;&nbsp;
     <asp:ImageButton ID="imgBtnCancel" runat="server" AlternateText="CancelImgButton"
        ImageUrl="images/cancel-button.png"
       onclick="imgBtnCancel_Click" /></td>
                    </tr>
             <tr><td colspan="3"></td></tr>
            </table></td>
          </tr>
  </table>
   <table width="100%" border="0">
    <tr>
        <td width="30%" class="mid_menu" align="right">
          To upload Logo
        </td>
        <td width="2%" class="mid_menu">:</td>
        <td width="40%">
            <asp:FileUpload ID="uploadLogo" runat="server" />
        </td>
        <td width="28%">
            <asp:ImageButton ID="btnUploadLogo" AlternateText="UploadLogoImgButton" runat="server"  ImageUrl="images/Upload-Logo.png" />
        </td>
    </tr>
    <tr>
    <td colspan="2">&nbsp;</td>
    <td colspan="2">
        <asp:DataList ID="ddlLogo" runat="server" RepeatDirection="Horizontal" RepeatColumns="4">
            <ItemTemplate>                                     
                <asp:Image ID="ImgLogo" AlternateText="CompanyLogo" runat="server" Width="100px" Height="75px" ImageUrl='<%# Eval("ImageName", "../Logos\\{0}") %>' />                                                                              
            </ItemTemplate>                                   
        </asp:DataList>
        <asp:Label ID="lblNoLogo" runat="server" ForeColor="Green"></asp:Label>
    </td>
    </tr>
    <tr>
        <td class="mid_menu" align="right">
          To upload Photos
        </td>
        <td class="mid_menu">:</td>
        <td>
            <asp:FileUpload ID="uploadPhotos" runat="server" />
            <br />
            <asp:TextBox ID="txtCaption" runat="server" Width="220px"></asp:TextBox>
            <cc2:TextBoxWatermarkExtender ID="txtExtenderCaption" runat="server" TargetControlID="txtCaption" WatermarkText="Enter Caption for Image">
            </cc2:TextBoxWatermarkExtender>
            </td>
         
            <td>
         <asp:ImageButton ID="btnUploadPhotos" runat="server" AlternateText="UploadPhotoimgButton" onclick="btnUploadPhotos_Click" ImageUrl="images/Upload-Photos.png" />
            </td>
    </tr>
    <tr>
    <td colspan="2"></td>
    <td colspan="2">
        <asp:DataList ID="dlPhotos" runat="server" RepeatDirection="Horizontal" RepeatColumns="4">
            <ItemTemplate>     
            <table>
                <tr>
                    <td align="center" class="sub_menu">
                        <asp:Label ID="lblCaption" runat="server" Text='<%#Eval("Caption")%>'></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Image ID="ImgPhoto" AlternateText="companyPhotos" runat="server" Width="100px" Height="75px" ImageUrl='<%# Eval("PhotoName", "../Photos\\{0}") %>' />                                                                             
                    </td>
                </tr>
                <tr>
                    <td align="center">
                        <asp:Button ID="lnkDelete" runat="server" OnCommand="lnkPhotoDelete" CommandArgument='<%#Eval("id")%>' BorderStyle="None" BackColor="#ECF9FF" 
                              ForeColor="Blue" OnClientClick="return confirm('Are you sure to delete this Photo?')" Text="Delete" />                                              
                    </td>
                </tr>
                  <tr>
                    <td align="center">
                        <asp:Button ID="lnkbtnChange" runat="server" OnCommand="lnkPhotoChangeCaption" Text="Change/Add Caption" 
                            CommandArgument='<%#Eval("id")%>' ForeColor="Blue" BorderStyle="None" BackColor="#ECF9FF"   />
                
                    </td>
                </tr>
            </table>                                                                        
            </ItemTemplate>                                                                                              
        </asp:DataList>
        <asp:Label ID="lblNoPhotos" runat="server" ForeColor="Green"></asp:Label>
    </td>
    </tr>
    <tr>
    <td colspan="4">
        <asp:Label ID="lblException" runat="server"></asp:Label></td>
    </tr>
    <%--<tr>
        <td class="mid_menu" align="right">
            To upload Videos
        </td>
        <td class="mid_menu">:</td>
        <td>
            <asp:FileUpload ID="uploadVedios" runat="server" />
        </td>
        <td>
            <asp:ImageButton ID="btnUploadVedios" AlternateText="UploadVideos" runat="server" onclick="btnUploadVedios_Click" ImageUrl="images/Upload-Video.png" />
            </td>
    </tr>--%>
    <%--<tr>
    <td colspan="2"></td>
    <td colspan="2">
        <asp:DataList ID="ddlVideo" runat="server" RepeatDirection="Horizontal" RepeatColumns="4">
            <ItemTemplate>     
            <table>
                <tr>
                    <td>                                            
                        <object><embed></embed></object>
                        <asp:Image ID="Video" AlternateText="videos" runat="server" Width="100px" Height="75px" ImageUrl='<%# Eval("VideoName", "../Videos\\{0}") %>' />                                                                             
                    </td>
                </tr>
                <tr>
                    <td align="center">
                        <asp:Button ID="lnkDelete" runat="server" OnCommand="lnkPhotoDelete" CommandArgument='<%#Eval("id")%>' BorderStyle="None" BackColor="#ECF9FF"  
                             ForeColor="Blue" OnClientClick="return confirm('Are you sure to delete this Photo?')" Text="Delete " />                                              
                    </td>
                </tr>
            </table>                                                                        
            </ItemTemplate>                                                                                              
        </asp:DataList>
        <asp:Label ID="lblNoVideos" runat="server" ForeColor="Green"></asp:Label>
    </td>
    </tr>--%>
</table>
<table width="100%" id="HRO">
    <tr><td class="sub_menu">More Information</td></tr>
    <tr>
            <td>
             <table width="100%">
                <tr class="mid_menu"><td colspan="3">Hours Of Operation</td></tr>
              <tr class="side_menu">
              <td width="25%" align="right">Monday</td>
              <td align="center" width="2%">:</td>
              <td width="73%">
                  <asp:DropDownList ID="ddlMonday" runat="server" AutoPostBack="true">
                  <asp:ListItem Value="Select">Select</asp:ListItem> 
                  <asp:ListItem Value="Holiday">Holiday</asp:ListItem>
                  <asp:ListItem Value="Open 24Hrs">Open 24Hrs</asp:ListItem>
                  <asp:ListItem Value="Time Duration">Time Duration</asp:ListItem>
                  </asp:DropDownList>
                  <asp:RequiredFieldValidator ID="rfvMon" runat="server" 
                      ControlToValidate="ddlMonday" ErrorMessage="Please select any one" 
                      InitialValue="Select" SkinID="Select" ValidationGroup="HRO">*</asp:RequiredFieldValidator>
              </td>
              </tr>
              <tr id="trMonDur" runat="server"> 
                  <td colspan="2">&nbsp;</td>
                  <td valign="middle">
                      <asp:DropDownList ID="ddlMonHrFr" runat="server" Width="50px">
                      </asp:DropDownList>&nbsp;:&nbsp;
                      <asp:DropDownList ID="ddlMonMinFr" runat="server"  Width="50px">
                      </asp:DropDownList>&nbsp;
                      <asp:DropDownList ID="ddlMonType1" runat="server"  Width="50px">
                      <asp:ListItem>am</asp:ListItem>
                      <asp:ListItem>pm</asp:ListItem>
                      </asp:DropDownList>
                      &nbsp;&nbsp;-&nbsp;&nbsp;
                      <asp:DropDownList ID="ddlMonHrT" runat="server" Width="50px">
                      </asp:DropDownList>&nbsp;:&nbsp;
                      <asp:DropDownList ID="ddlMonMinT" runat="server" Width="50px">
                      </asp:DropDownList>&nbsp;
                      <asp:DropDownList ID="ddlMonType2" runat="server" Width="50px">
                      <asp:ListItem>am</asp:ListItem>
                      <asp:ListItem>pm</asp:ListItem>
                      </asp:DropDownList>
                      <%--<asp:TextBox ID="txtMonHrAM" runat="server" Width="50px"></asp:TextBox>&nbsp;:&nbsp;
                      <asp:TextBox ID="txtMonMinAM" runat="server" Text="00"  Width="50px"></asp:TextBox>&nbsp;am
                      &nbsp;&nbsp;
                      <asp:TextBox ID="txtMonHrPM" runat="server"  Width="50px"></asp:TextBox>&nbsp;:&nbsp;
                      <asp:TextBox ID="txtMonMinPM" runat="server" Text="00"  Width="50px"></asp:TextBox>&nbsp;pm   --%>                                   
                      &nbsp;<%--<asp:LinkButton ID="lnkMonTimings" runat="server" ForeColor="Red" 
                          onclick="lnkMonTimings_Click">Add Timings</asp:LinkButton>--%>
                      <a id="lnkMonTimings" runat="server" style="color:Red;" onserverclick="lnkMonTimings_Click">Add Timings</a>                                                                          
                       
                      <asp:Label ID="lblLnkMon" runat="server" Visible="false"></asp:Label>
                  </td>
              </tr>
              <tr id="trLstMon" runat="server">
                <td colspan="2">&nbsp;</td>
                <td valign="middle">
                <table><tr><td>
                 <asp:Literal ID="ltrMonTime" runat="server"></asp:Literal>   
                 <%--<asp:LinkButton ID="lnkBtnClearMonTimings" runat="server" ForeColor="Red" onclick="lnkBtnClearMonTimings_Click"
                         >Clear Timings</asp:LinkButton>--%> 
                <a id="lnkBtnClearMonTimings" runat="server" style="color:Red;" onserverclick="lnkBtnClearMonTimings_Click">Clear Timings</a>                                 
                                                   
                </td>
                <td>
                       <asp:Label ID="lblMonTime" runat="server" Visible="false"></asp:Label>
                </td></tr></table>                                                                    
                  </td>
              </tr>
              <tr class="side_menu">
              <td align="right">Tuesday</td>
              <td align="center">:</td>
              <td>
                  <asp:DropDownList ID="ddlTuesday" runat="server" AutoPostBack="true">
                  <asp:ListItem Value="Select">Select</asp:ListItem> 
                  <asp:ListItem Value="Holiday">Holiday</asp:ListItem> 
                  <asp:ListItem Value="Open 24Hrs">Open 24Hrs</asp:ListItem>
                  <asp:ListItem Value="Time Duration">Time Duration</asp:ListItem>
                  </asp:DropDownList>
                  <asp:RequiredFieldValidator ID="rfvTues" runat="server" 
                      ControlToValidate="ddlTuesday" ErrorMessage="Please select any one" 
                      InitialValue="Select" ValidationGroup="HRO">*</asp:RequiredFieldValidator>
              </td>
              </tr>                                  
              <tr id="trTuesDur" runat="server">
                  <td colspan="2"></td>
                  <td valign="middle">
                      <asp:DropDownList ID="ddlTuesHrFr" runat="server" Width="50px">
                      </asp:DropDownList>&nbsp;:&nbsp;
                       <asp:DropDownList ID="ddlTuesMinFr" runat="server"  Width="50px">
                      </asp:DropDownList>&nbsp;
                      <asp:DropDownList ID="ddlTuesType1" runat="server"  Width="50px">
                      <asp:ListItem>am</asp:ListItem>
                      <asp:ListItem>pm</asp:ListItem>
                      </asp:DropDownList>
                      &nbsp;&nbsp;-&nbsp;&nbsp;
                      <asp:DropDownList ID="ddlTuesHrT" runat="server" Width="50px">
                      </asp:DropDownList>&nbsp;:&nbsp;
                      <asp:DropDownList ID="ddlTuesMinT" runat="server" Width="50px">
                      </asp:DropDownList>&nbsp;
                      <asp:DropDownList ID="ddlTuesType2" runat="server" Width="50px">
                      <asp:ListItem>am</asp:ListItem>
                      <asp:ListItem>pm</asp:ListItem>
                      </asp:DropDownList>
                      &nbsp;<%--<asp:LinkButton ID="lnkTuesTimings" runat="server" ForeColor="Red" 
                          onclick="lnkTuesTimings_Click">Add Timings</asp:LinkButton>--%>
                      <a id="lnkTuesTimings" runat="server" style="color:Red;" onserverclick="lnkTuesTimings_Click">Add Timings</a> 
                       
                      <asp:Label ID="lblLnkTues" runat="server" Visible="false"></asp:Label>
                      <%--<asp:TextBox ID="txtTuesHrAM" runat="server" Width="50px"></asp:TextBox>&nbsp;:&nbsp;
                      <asp:TextBox ID="txtTuesMinAM" runat="server" Text="00"  Width="50px"></asp:TextBox>&nbsp;am
                      &nbsp;&nbsp;
                      <asp:TextBox ID="txtTuesHrPM" runat="server"  Width="50px"></asp:TextBox>&nbsp;:&nbsp;
                      <asp:TextBox ID="txtTuesMinPM" runat="server" Text="00"  Width="50px"></asp:TextBox>&nbsp;pm--%>
                  </td>
              </tr>
              <tr id="trLstTues" runat="server">
                <td colspan="2"></td>
                <td valign="middle">
                <table><tr><td>
                 <asp:Literal ID="ltrTuesTime" runat="server"></asp:Literal>   
                 <%--<asp:LinkButton ID="lnkBtnClearTuesTimings" runat="server" ForeColor="Red" onclick="lnkBtnClearTuesTimings_Click"
                         >Clear Timings</asp:LinkButton>--%> 
                   <a id="lnkBtnClearTuesTimings" runat="server" style="color:Red;" onserverclick="lnkBtnClearTuesTimings_Click">Clear Timings</a>                               
                                                 
                </td>
                <td>
                       <asp:Label ID="lblTuesTime" runat="server" Visible="false"></asp:Label>
                </td></tr></table>                                                                    
                  </td>
              </tr>
              <tr class="side_menu">
              <td align="right">Wednesday</td>
              <td align="center">:</td>
              <td>
                  <asp:DropDownList ID="ddlWednesday" runat="server" AutoPostBack="true">
                  <asp:ListItem Value="Select">Select</asp:ListItem>
                  <asp:ListItem Value="Holiday">Holiday</asp:ListItem>  
                  <asp:ListItem Value="Open 24Hrs">Open 24Hrs</asp:ListItem>
                  <asp:ListItem Value="Time Duration">Time Duration</asp:ListItem>
                  </asp:DropDownList>
                  <asp:RequiredFieldValidator ID="rfvWed" runat="server" 
                      ControlToValidate="ddlWednesday" ErrorMessage="Please select any one" 
                      InitialValue="Select" ValidationGroup="HRO">*</asp:RequiredFieldValidator>
              </td>
              </tr>
              <tr id="trWedDur" runat="server">
                  <td colspan="2"></td>
                  <td valign="middle">
                      <asp:DropDownList ID="ddlWedHrFr" runat="server" Width="50px">
                      </asp:DropDownList>&nbsp;:&nbsp;
                       <asp:DropDownList ID="ddlWedMinFr" runat="server"  Width="50px">
                      </asp:DropDownList>&nbsp;
                      <asp:DropDownList ID="ddlWedType1" runat="server"  Width="50px">
                      <asp:ListItem>am</asp:ListItem>
                      <asp:ListItem>pm</asp:ListItem>
                      </asp:DropDownList>
                      &nbsp;&nbsp;-&nbsp;&nbsp;
                      <asp:DropDownList ID="ddlWedHrT" runat="server" Width="50px">
                      </asp:DropDownList>&nbsp;:&nbsp;
                      <asp:DropDownList ID="ddlWedMinT" runat="server" Width="50px">
                      </asp:DropDownList>&nbsp;
                      <asp:DropDownList ID="ddlWedType2" runat="server" Width="50px">
                      <asp:ListItem>am</asp:ListItem>
                      <asp:ListItem>pm</asp:ListItem>
                      </asp:DropDownList>
                      &nbsp;<%--<asp:LinkButton ID="lnkWedTimings" runat="server" ForeColor="Red" onclick="lnkWedTimings_Click" 
                         >Add Timings</asp:LinkButton>--%>
                      <a id="lnkWedTimings" runat="server" style="color:Red;" onserverclick="lnkWedTimings_Click">Add Timings</a>                                                                
                       
                      <asp:Label ID="lblLnkWed" runat="server" Visible="false"></asp:Label>
                      <%--<asp:TextBox ID="txtWedHrAM" runat="server" Width="50px"></asp:TextBox>&nbsp;:&nbsp;
                      <asp:TextBox ID="txtWedMinAM" runat="server" Text="00"  Width="50px"></asp:TextBox>&nbsp;am
                      &nbsp;&nbsp;
                      <asp:TextBox ID="txtWedHrPM" runat="server"  Width="50px"></asp:TextBox>&nbsp;:&nbsp;
                      <asp:TextBox ID="txtWedMinPM" runat="server" Text="00"  Width="50px"></asp:TextBox>&nbsp;pm--%>
                  </td>
              </tr>
              <tr id="trLstWed" runat="server">
                <td colspan="2"></td>
                <td valign="middle">
                <table><tr><td>
                 <asp:Literal ID="ltrWedTime" runat="server"></asp:Literal>       
                 <%--<asp:LinkButton ID="lnkBtnClearWedTimings" runat="server" ForeColor="Red" onclick="lnkBtnClearWedTimings_Click"
                         >Clear Timings</asp:LinkButton>--%> 
                  <a id="lnkBtnClearWedTimings" runat="server" style="color:Red;" onserverclick="lnkBtnClearWedTimings_Click">Clear Timings</a>                                                                                                                                      
                                               
                </td>
                <td>
                       <asp:Label ID="lblWedTime" runat="server" Visible="false"></asp:Label>
                </td></tr></table>                                                                    
                  </td>
              </tr>
              <tr class="side_menu">
              <td align="right">Thursday</td>
              <td align="center">:</td>
              <td>
                  <asp:DropDownList ID="ddlThursday" runat="server" AutoPostBack="true">
                  <asp:ListItem Value="Select">Select</asp:ListItem>
                  <asp:ListItem Value="Holiday">Holiday</asp:ListItem>  
                  <asp:ListItem Value="Open 24Hrs">Open 24Hrs</asp:ListItem>
                  <asp:ListItem Value="Time Duration">Time Duration</asp:ListItem>
                  </asp:DropDownList>
                  <asp:RequiredFieldValidator ID="rfvThurs" runat="server" 
                      ControlToValidate="ddlThursday" ErrorMessage="Please select any one" 
                      InitialValue="Select" ValidationGroup="HRO">*</asp:RequiredFieldValidator>
              </td>
              </tr>
              <tr id="trThursDur" runat="server">
                  <td colspan="2"></td>
                  <td valign="middle">
                      <asp:DropDownList ID="ddlThursHrFr" runat="server" Width="50px">
                      </asp:DropDownList>&nbsp;:&nbsp;
                       <asp:DropDownList ID="ddlThursMinFr" runat="server"  Width="50px">
                      </asp:DropDownList>&nbsp;
                      <asp:DropDownList ID="ddlThursType1" runat="server"  Width="50px">
                      <asp:ListItem>am</asp:ListItem>
                      <asp:ListItem>pm</asp:ListItem>
                      </asp:DropDownList>
                      &nbsp;&nbsp;-&nbsp;&nbsp;
                      <asp:DropDownList ID="ddlThursHrT" runat="server" Width="50px">
                      </asp:DropDownList>&nbsp;:&nbsp;
                      <asp:DropDownList ID="ddlThursMinT" runat="server" Width="50px">
                      </asp:DropDownList>&nbsp;
                      <asp:DropDownList ID="ddlThursType2" runat="server" Width="50px">
                      <asp:ListItem>am</asp:ListItem>
                      <asp:ListItem>pm</asp:ListItem>
                      </asp:DropDownList>
                      &nbsp;<%--<asp:LinkButton ID="lnkThursTimings" runat="server" ForeColor="Red" onclick="lnkThursTimings_Click" 
                         >Add Timings</asp:LinkButton>--%>
                       <a id="lnkThursTimings" runat="server" style="color:Red;" onserverclick="lnkThursTimings_Click">Add Timings</a>                                                                                                                                                                             
                       
                      <asp:Label ID="lblLnkThurs" runat="server" Visible="false"></asp:Label>
                      <%--<asp:TextBox ID="txtThursHrAM" runat="server" Width="50px"></asp:TextBox>&nbsp;:&nbsp;
                      <asp:TextBox ID="txtThursMinAM" runat="server" Text="00"  Width="50px"></asp:TextBox>&nbsp;am
                      &nbsp;&nbsp;
                      <asp:TextBox ID="txtThursHrPM" runat="server"  Width="50px"></asp:TextBox>&nbsp;:&nbsp;
                      <asp:TextBox ID="txtThursMinPM" runat="server" Text="00"  Width="50px"></asp:TextBox>&nbsp;pm--%>
                  </td>
              </tr>
              <tr id="trLstThurs" runat="server">
                <td colspan="2"></td>
                <td valign="middle">
                <table><tr><td>
                 <asp:Literal ID="ltrThursTime" runat="server"></asp:Literal>
                <%-- <asp:LinkButton ID="lnkBtnClearThursTimings" runat="server" ForeColor="Red" onclick="lnkBtnClearThursTimings_Click"
                         >Clear Timings</asp:LinkButton> --%>
                  <a id="lnkBtnClearThursTimings" runat="server" style="color:Red;" onserverclick="lnkBtnClearThursTimings_Click">Clear Timings</a>                                                                                                                                                                             
                                                     
                </td>
                <td>
                       <asp:Label ID="lblThursTime" runat="server" Visible="false"></asp:Label>
                </td></tr></table>                                                                    
                  </td>
              </tr>
              <tr class="side_menu">
              <td align="right">Friday</td>
              <td align="center">:</td>
              <td>
                  <asp:DropDownList ID="ddlFriday" runat="server" AutoPostBack="true">
                  <asp:ListItem Value="Select">Select</asp:ListItem> 
                  <asp:ListItem Value="Holiday">Holiday</asp:ListItem> 
                  <asp:ListItem Value="Open 24Hrs">Open 24Hrs</asp:ListItem>
                  <asp:ListItem Value="Time Duration">Time Duration</asp:ListItem>
                  </asp:DropDownList>
                  <asp:RequiredFieldValidator ID="rfvFri" runat="server" 
                      ControlToValidate="ddlFriday" ErrorMessage="Please select any one" 
                      InitialValue="Select" ValidationGroup="HRO">*</asp:RequiredFieldValidator>
              </td>
              </tr>
              <tr id="trFriDur" runat="server">
                  <td colspan="2"></td>
                  <td valign="middle">
                      <asp:DropDownList ID="ddlFriHrFr" runat="server" Width="50px">
                      </asp:DropDownList>&nbsp;:&nbsp;
                       <asp:DropDownList ID="ddlFriMinFr" runat="server"  Width="50px">
                      </asp:DropDownList>&nbsp;
                      <asp:DropDownList ID="ddlFriType1" runat="server"  Width="50px">
                      <asp:ListItem>am</asp:ListItem>
                      <asp:ListItem>pm</asp:ListItem>
                      </asp:DropDownList>
                      &nbsp;&nbsp;-&nbsp;&nbsp;
                      <asp:DropDownList ID="ddlFriHrT" runat="server" Width="50px">
                      </asp:DropDownList>&nbsp;:&nbsp;
                      <asp:DropDownList ID="ddlFriMinT" runat="server" Width="50px">
                      </asp:DropDownList>&nbsp;
                      <asp:DropDownList ID="ddlFriType2" runat="server" Width="50px">
                      <asp:ListItem>am</asp:ListItem>
                      <asp:ListItem>pm</asp:ListItem>
                      </asp:DropDownList>
                      &nbsp;<%--<asp:LinkButton ID="lnkFriTimings" runat="server" ForeColor="Red" onclick="lnkFriTimings_Click" 
                         >Add Timings</asp:LinkButton>--%>
                       <a id="lnkFriTimings" runat="server" style="color:Red;" onserverclick="lnkFriTimings_Click">Add Timings</a>                                                                                                                                                                             
                       
                      <asp:Label ID="lblLnkFri" runat="server" Visible="false"></asp:Label>
                      <%--<asp:TextBox ID="txtFriHrAM" runat="server" Width="50px"></asp:TextBox>&nbsp;:&nbsp;
                      <asp:TextBox ID="txtFriMinAM" runat="server" Text="00"  Width="50px"></asp:TextBox>&nbsp;am
                      &nbsp;&nbsp;
                      <asp:TextBox ID="txtFriHrPM" runat="server"  Width="50px"></asp:TextBox>&nbsp;:&nbsp;
                      <asp:TextBox ID="txtFriMinPM" runat="server" Text="00"  Width="50px"></asp:TextBox>&nbsp;pm--%>
                  </td>
              </tr>
              <tr id="trLstFri" runat="server">
                <td colspan="2"></td>
                <td valign="middle">
                <table><tr><td>
                 <asp:Literal ID="ltrFriTime" runat="server"></asp:Literal>     
                 <%--<asp:LinkButton ID="lnkBtnClearFriTimings" runat="server" ForeColor="Red" onclick="lnkBtnClearFriTimings_Click"
                         >Clear Timings</asp:LinkButton> --%>
                  <a id="lnkBtnClearFriTimings" runat="server" style="color:Red;" onserverclick="lnkBtnClearFriTimings_Click">Clear Timings</a>                                                                                                                                                                             
                                                 
                </td>
                <td>
                       <asp:Label ID="lblFriTime" runat="server" Visible="false"></asp:Label>
                </td></tr></table>                                                                    
                  </td>
              </tr>
              <tr class="side_menu">
              <td align="right">Saturday</td>
              <td align="center">:</td>
              <td>
                  <asp:DropDownList ID="ddlSaturday" runat="server" AutoPostBack="true">
                  <asp:ListItem Value="Select">Select</asp:ListItem>
                  <asp:ListItem Value="Holiday">Holiday</asp:ListItem>  
                  <asp:ListItem Value="Open 24Hrs">Open 24Hrs</asp:ListItem>
                  <asp:ListItem Value="Time Duration">Time Duration</asp:ListItem>
                  </asp:DropDownList>
                  <asp:RequiredFieldValidator ID="rfvSat" runat="server" 
                      ControlToValidate="ddlSaturday" ErrorMessage="Please select any one" 
                      InitialValue="Select" ValidationGroup="HRO">*</asp:RequiredFieldValidator>
              </td>
              </tr>
              <tr id="trSatDur" runat="server">
                  <td colspan="2"></td>
                  <td valign="middle">
                      <asp:DropDownList ID="ddlSaturHrFr" runat="server" Width="50px">
                      </asp:DropDownList>&nbsp;:&nbsp;
                       <asp:DropDownList ID="ddlSaturMinFr" runat="server"  Width="50px">
                      </asp:DropDownList>&nbsp;
                      <asp:DropDownList ID="ddlSaturType1" runat="server"  Width="50px">
                      <asp:ListItem>am</asp:ListItem>
                      <asp:ListItem>pm</asp:ListItem>
                      </asp:DropDownList>
                      &nbsp;&nbsp;-&nbsp;&nbsp;
                      <asp:DropDownList ID="ddlSaturHrT" runat="server" Width="50px">
                      </asp:DropDownList>&nbsp;:&nbsp;
                      <asp:DropDownList ID="ddlSaturMinT" runat="server" Width="50px">
                      </asp:DropDownList>&nbsp;
                      <asp:DropDownList ID="ddlSaturType2" runat="server" Width="50px">
                      <asp:ListItem>am</asp:ListItem>
                      <asp:ListItem>pm</asp:ListItem>
                      </asp:DropDownList>
                      &nbsp;<%--<asp:LinkButton ID="lnkSaturTimings" runat="server" ForeColor="Red" onclick="lnkSaturTimings_Click" 
                         >Add Timings</asp:LinkButton>--%>
                       <a id="lnkSaturTimings" runat="server" style="color:Red;" onserverclick="lnkSaturTimings_Click">Add Timings</a>                                                                                                                                                                             
                       
                      <asp:Label ID="lblLnkSatur" runat="server" Visible="false"></asp:Label>
                      <%--<asp:TextBox ID="txtSaturHrAM" runat="server" Width="50px"></asp:TextBox>&nbsp;:&nbsp;
                      <asp:TextBox ID="txtSaturMinAM" runat="server" Text="00"  Width="50px"></asp:TextBox>&nbsp;am
                      &nbsp;&nbsp;
                      <asp:TextBox ID="txtSaturHrPM" runat="server"  Width="50px"></asp:TextBox>&nbsp;:&nbsp;
                      <asp:TextBox ID="txtSaturMinPM" runat="server" Text="00"  Width="50px"></asp:TextBox>&nbsp;pm--%>
                  </td>
              </tr> 
              <tr id="trLstSatur" runat="server">
                <td colspan="2"></td>
                <td valign="middle">
                <table><tr><td>
                 <asp:Literal ID="ltrSaturTime" runat="server"></asp:Literal>
                 <%-- <asp:LinkButton ID="lnkBtnClearSatTimings" runat="server" ForeColor="Red" onclick="lnkBtnClearSatTimings_Click"
                         >Clear Timings</asp:LinkButton>--%> 
                  <a id="lnkBtnClearSatTimings" runat="server" style="color:Red;" onserverclick="lnkBtnClearSatTimings_Click">Clear Timings</a>                                                                                                                                                                             
                                                    
                </td>
                <td>
                       <asp:Label ID="lblSaturTime" runat="server" Visible="false"></asp:Label>
                </td></tr></table>                                                                    
                  </td>
              </tr>                                                                                  
              <tr class="side_menu">
              <td align="right">Sunday</td>
              <td align="center">:</td>
              <td>
                  <asp:DropDownList ID="ddlSunday" runat="server" AutoPostBack="true">
                  <asp:ListItem Value="Select">Select</asp:ListItem>
                  <asp:ListItem Value="Holiday">Holiday</asp:ListItem>  
                  <asp:ListItem Value="Open 24Hrs">Open 24Hrs</asp:ListItem>
                  <asp:ListItem Value="Time Duration">Time Duration</asp:ListItem>
                  </asp:DropDownList>
                  <asp:RequiredFieldValidator ID="rfvSun" runat="server" 
                      ControlToValidate="ddlSunday" ErrorMessage="RequiredFieldValidator" 
                      InitialValue="Select" ValidationGroup="HRO">*</asp:RequiredFieldValidator>
              </td>
              </tr>
              <tr id="trSunDur" runat="server">
                  <td colspan="2"></td>
                  <td valign="middle">
                      <asp:DropDownList ID="ddlSunHrFr" runat="server" Width="50px">
                      </asp:DropDownList>&nbsp;:&nbsp;
                       <asp:DropDownList ID="ddlSunMinFr" runat="server"  Width="50px">
                      </asp:DropDownList>&nbsp;
                      <asp:DropDownList ID="ddlSunType1" runat="server"  Width="50px">
                      <asp:ListItem>am</asp:ListItem>
                      <asp:ListItem>pm</asp:ListItem>
                      </asp:DropDownList>
                      &nbsp;&nbsp;-&nbsp;&nbsp;
                      <asp:DropDownList ID="ddlSunHrT" runat="server" Width="50px">
                      </asp:DropDownList>&nbsp;:&nbsp;
                      <asp:DropDownList ID="ddlSunMinT" runat="server" Width="50px">
                      </asp:DropDownList>&nbsp;
                      <asp:DropDownList ID="ddlSunType2" runat="server" Width="50px">
                      <asp:ListItem>am</asp:ListItem>
                      <asp:ListItem>pm</asp:ListItem>
                      </asp:DropDownList>
                      &nbsp<%--;<asp:LinkButton ID="lnkSunTimings" runat="server" ForeColor="Red" onclick="lnkSunTimings_Click" 
                         >Add Timings</asp:LinkButton>--%>
                       <a id="lnkSunTimings" runat="server" style="color:Red;" onserverclick="lnkSunTimings_Click">Add Timings</a>                                                                                                                                                                             
                      
                      <asp:Label ID="lblLnkSun" runat="server" Visible="false"></asp:Label>
                      <%--<asp:TextBox ID="txtSunHrAM" runat="server" Width="50px"></asp:TextBox>&nbsp;:&nbsp;
                      <asp:TextBox ID="txtSunMinAM" runat="server" Text="00"  Width="50px"></asp:TextBox>&nbsp;am
                      &nbsp;&nbsp;
                      <asp:TextBox ID="txtSunHrPM" runat="server"  Width="50px"></asp:TextBox>&nbsp;:&nbsp;
                      <asp:TextBox ID="txtSunMinPM" runat="server" Text="00"  Width="50px"></asp:TextBox>&nbsp;pm--%>
                  </td>
              </tr>
              <tr id="trLstSun" runat="server">
                <td colspan="2"></td>
                <td valign="middle">
                <table><tr><td>
                 <asp:Literal ID="ltrSunTime" runat="server"></asp:Literal>   
                <%-- <asp:LinkButton ID="lnkBtnClearSuntimings" runat="server" ForeColor="Red" onclick="lnkBtnClearSuntimings_Click"
                         >Clear Timings</asp:LinkButton>   --%> 
                    <a id="lnkBtnClearSuntimings" runat="server" style="color:Red;" onserverclick="lnkBtnClearSuntimings_Click">Clear Timings</a>                                                                                                                                                                             
                                               
                </td>
                <td>
                       <asp:Label ID="lblSunTime" runat="server" Visible="false"></asp:Label>
                </td></tr></table>                                                                    
                  </td>
              </tr>
              <tr class="sub_menu"><td colspan="3">Payment Modes&nbsp;:</td></tr>
              <tr id="trPayment" runat="server">
                  <td colspan="2"></td>
                  <td valign="middle">
                      <asp:ListBox ID="lstBoxPayment" runat="server" SelectionMode="Multiple">                                           
                      </asp:ListBox>
                  </td>
              </tr>
              <tr class="sub_menu"><td colspan="3">Additional Information&nbsp;:</td></tr>
              <tr id="trAddInfo" runat="server">
                  <td colspan="2"></td>
                  <td valign="middle">
                      <asp:TextBox ID="txtAdtInfo" runat="server" TextMode="MultiLine" Width="190px"></asp:TextBox>
                  </td>
              </tr>
              <tr class="sub_menu"><td colspan="3">Company Information&nbsp;:</td></tr>
              <tr id="trYrEstab" runat="server" class="side_menu">
                  <td align="right">Year Established</td>
                  <td align="center"><strong>:</strong></td>
                  <td align="left">
                      <asp:DropDownList ID="ddlYearEstab" runat="server" Width="191px">                                          
                      </asp:DropDownList>
                  </td>
              </tr>
              <tr id="trProfAssoc" runat="server" class="side_menu">
                  <td align="right">Professional Associations</td>
                  <td align="center"><strong>:</strong></td>
                  <td align="left">
                      <asp:TextBox ID="txtProf_Assoc" runat="server" Width="190px"></asp:TextBox>
                  </td>
              </tr>
              <tr id="trCertif" runat="server" class="side_menu">
                  <td align="right">Certifications</td>
                  <td align="center"><strong>:</strong></td>
                  <td align="left">
                      <asp:TextBox ID="txtCertifi" runat="server" Width="190px"></asp:TextBox>
                  </td>
              </tr>
              <tr id="trNoofEmp" runat="server" class="side_menu">
                  <td align="right">No. of Employees</td>
                  <td align="center"><strong>:</strong></td>
                  <td align="left">
                      <asp:DropDownList ID="ddlNoofEmp" runat="server" Width="191px">
                      <asp:ListItem>Select No of Employees</asp:ListItem>
                      <asp:ListItem>1-10</asp:ListItem>
                      <asp:ListItem>10-100</asp:ListItem>
                      
                      </asp:DropDownList>
                  </td>
              </tr>
                 
              <tr>
                <td colspan="3" align="center">
                    <asp:ImageButton ID="btnAddMoreInfo" runat="server" ImageUrl="images/Post-More-Info.png" 
                        onclick="btnAddMoreInfo_Click" ValidationGroup="HRO" AlternateText="PostMoreInfo" />
                 
                        <asp:ImageButton ID="btnUpdateMoreInfo" runat="server" Text="Update More Info" ImageUrl="images/Update-More-Info.png"
                        onclick="btnUpdateMoreInfo_Click" ValidationGroup="HRO" AlternateText="UpdateMoreInfo"/>
                   &nbsp;&nbsp;
                    <asp:ImageButton ID="btnSkip" AlternateText="GotoPreviousPage" runat="server" ImageUrl="images/Skip.png"  onclick="btnSkip_Click" />
                    
              </td>
              </tr>
               <tr><td colspan="3">
           <input id="btnDummy" runat="server" type="button" style="display: none;" />
        </td></tr>
              <tr>
              <td colspan="3">
                 <cc2:ModalPopupExtender ID="ModalPopupExtender1" runat="server" PopupControlID="modpopup1" BackgroundCssClass="modalBackground" TargetControlID="btnDummy"
        OkControlID="btnDummy" CancelControlID="cancelbutton" BehaviorID="mpeBehavior"
        DropShadow="false" PopupDragHandleControlID="panel4"></cc2:ModalPopupExtender>    
                                               
            <asp:Panel ID="modpopup1" runat="server" Width="430px" Height="276px">
        <fieldset style="width: 402px">
            <asp:Panel ID="Panel4" runat="server">
            </asp:Panel>             
             <table align="center" width="400" style="background:#0285D7; height: 184px;" >               
               <tr style="background-color:#0285D7;">
                    <td style="width:400px" align="center">                                       
                        <asp:Label ID="lblId" runat="server" Visible="false"></asp:Label>
                       <asp:TextBox ID="txtCaptionNew" runat="server" ></asp:TextBox> 
                    </td>
                    </tr>
               <tr>                     
                    <td align="center" class="style4">
                        <asp:Button ID="submitbutton" runat="server" Text="Change Caption" 
                            ValidationGroup="modal" CausesValidation="true" 
                            onclick="submitbutton_Click"/>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="cancelbutton" runat="server" Text="Cancel" 
                            onclick="cancelbutton_Click" />
                    </td>
                </tr> 
                <tr>
                    <td>
                     <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
                        ShowMessageBox="True" ShowSummary="False" ValidationGroup="modal" />
                    </td>
                </tr>               
            </table>
        </fieldset></asp:Panel>
              </td>
              </tr>
            </table>
        </td>
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
      <img src="images/event/add2.png" alt="FreeListingAds" width="175" height="600" /><br />
        <img src="images/event/search-job-2.png" alt="FreeListingAds" width="175" height="300" /><br />
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
