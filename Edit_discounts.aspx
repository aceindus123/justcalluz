<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Edit_discounts.aspx.cs" Inherits="Edit_discounts" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="AjaxToolkit"%>
<%@ Register Src="usercontrols/signin.ascx" TagName="signin" TagPrefix="aa1" %>
<%@ Register Src="usercontrols/SearchNew.ascx" TagName="SearchNew" TagPrefix="New" %>
<%@ Register Src="usercontrols/small_logo.ascx" TagName="logo" TagPrefix="S_logo" %>
<%@ Register Src="usercontrols/catageories.ascx" TagName="catag" TagPrefix="aa6" %>
<%@ Register Src="usercontrols/footer1.ascx" TagName="footer1" TagPrefix="aa10" %>
<%@ Register Src="usercontrols/footer2.ascx" TagName="footer2" TagPrefix="aa11" %>
<%@ Register Src="usercontrols/BottomContent.ascx" TagName="bottomcontent" TagPrefix="aa4" %>
<%@ Register Src="usercontrols/BottomMidContent.ascx" TagName="bottomMidcontent" TagPrefix="aa5" %>
<%@ Register Src="usercontrols/discount_left.ascx" TagName="leftdiscount" TagPrefix="ldsc" %>
<%@ Register Src="usercontrols/SponsoredLinks.ascx" TagName="spd_Links" TagPrefix="SpLinks" %>
<%@ Register Assembly="MSCaptcha" Namespace="MSCaptcha" TagPrefix="cc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
   <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<%--<title>:: Justcalluz :: Edit Discount page</title>--%>
<title>Justcalluz | Find Discount and coupon code in your city | we provide updated information on all your local search</title>
<meta name='description' content='Discount rates,sale,Event Management'/>
<meta name='keywords' content='Justcalluz,Discount rates,sale,Event Management,online yellow pages, yellow pages india, India trade directory,  yellow pages directory, city yellow pages, indian search engine, JustCalluz customer care, JustCalluz customer support' />
<link href="css/style.css" rel="stylesheet" type="text/css" />
<link rel="Stylesheet" type="text/css" href="css/inner_style.css" />
<style type="text/css">
 .style10
    {
        width: 20%;
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
<!-- start the mid Box-->
 <div class="content" style="padding:0; margin:0;">
 <div class="content_innermid" style="width:100%;">
  <div class="contentmid_boxmid" style="width:77.5%; padding:none; background:none; border:dotted 1px #666">
  <table width="100%" border="0" bgcolor="#ECF9FF">
     <tr>
      <td height="35" colspan="3" style="background:url(images/search_midtop.png) no-repeat">
       <table width="100%" border="0">
       <tr>
        <td class="location"  height="35" style="padding-left:15px; background:url(images/search_midtop.png) no-repeat "><font color="white">Welcome to Just Call Uz :: Discounts</font></td>
       </tr>
      </table>
      </td>
     </tr>
     <tr>
      <td height="30" align="center" class="bottam" style="padding-right:5px;">Welcome to Justcalluz</td>
    </tr>
    <tr>
    <td valign="top"> 
     <div class="events">
      <table width="100%" border="0" id="tblpost" runat="server">
          <tr>
            <td height="25" align="left" style="padding-left:10px;"><label style="color:#000" ><span class="sub_menu"><b>Post Your Discount</b></span></label>
              <span class="sub_menu"></span></td>
          </tr>
          <tr>
            <td width="100%"><hr /><hr /></td>
           </tr>
           <tr>
                <td height="30" align="center" valign="top">
                 <table width="100%" border="0" bgcolor="">
                  <tr>
                    <td align="right" style="width:25%;"><span class="star">*</span><span class="list">Category</span></td>
                    <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
                    <td height="30" align="left" style="width:75%;">
                       <asp:DropDownList ID="ddlCategory" runat="server" Height="21px" 
                          Width="197px" AutoPostBack="true" OnSelectedIndexChanged="ddlCategory_SelectedIndexChanged"></asp:DropDownList>
                            <asp:RequiredFieldValidator ID="rfvddlCategory" runat="server" 
                            ErrorMessage="please select the Category" Text="*" ControlToValidate="ddlCategory" 
                            ValidationGroup="validatediscount" InitialValue="select">*</asp:RequiredFieldValidator>
                    </td>
                   </tr>
                   <tr>
                    <td align="right" class="style10"><span class="star">*</span><span class="list"> Sub Category</span></td>
                    <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
                    <td height="30" align="left">
                       <asp:DropDownList ID="ddlSubcat" runat="server" Height="21px" Width="197px"></asp:DropDownList>
                            <asp:RequiredFieldValidator ID="rfvddlSubcat" runat="server" 
                            ErrorMessage="please select the Sub Category" Text="*" ControlToValidate="ddlSubcat" 
                            ValidationGroup="validatediscount" InitialValue="select">*</asp:RequiredFieldValidator>
                    </td>
                  </tr>
                  <tr>
                    <td align="right" class="style10"><span class="star">*</span><span class="list">Company Name</span></td>
                    <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
                    <td height="30" align="left">
                       <asp:TextBox ID="txtcname" runat="server" Width="196px" onkeypress="return Alphabets(event);"></asp:TextBox>
                     <asp:RequiredFieldValidator ID="rf1" runat="server" 
                    ErrorMessage="please enter the Company Name" Text="*" ControlToValidate="txtcname" ValidationGroup="validatediscount">
                  </asp:RequiredFieldValidator>
                  </td>
                   </tr>
                 <tr>
                    <td align="right" class="style10"><span class="star">*</span><span class="list">Description</span></td>
                    <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
                    <td height="30" align="left">
                    <asp:TextBox ID="txtdes" runat="server" Width="196px" TextMode="MultiLine"></asp:TextBox>
                   <asp:RequiredFieldValidator ID="rfvDesc" runat="server" 
                      ErrorMessage="please enter Description" ControlToValidate="txtdes" 
                      ValidationGroup="validatediscount">*</asp:RequiredFieldValidator>
                      </td>
                  </tr>
                   <tr>
                     <td align="right" class="style10"><span class="star">*</span><span class="list">Type of Discount</span></td>
                    <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
                    <td height="30" align="left">
                       <asp:DropDownList ID="ddltyp" runat="server" AutoPostBack="true" Height="21px" 
                          Width="197px" ValidationGroup="validatediscount" OnSelectedIndexChanged="ddltyp_selectedIndexChanged">
                          <asp:ListItem>select</asp:ListItem>
                          <asp:ListItem>Oneday Discount</asp:ListItem>
                          <asp:ListItem>Multiday Discount</asp:ListItem>
                          </asp:DropDownList>
                         <asp:RequiredFieldValidator ID="rfvddltyp" runat="server" 
                          ErrorMessage="Please specify the type of Discount" InitialValue="select" 
                          ControlToValidate="ddltyp"  ValidationGroup="validatediscount">*</asp:RequiredFieldValidator>
                     </td>
                  </tr>
                   <tr><td align="right"></td>
                     <td align="left" ></td>
                     <td align="left" >
                          <asp:TextBox ID="txtone" runat="server" Visible="false" Height="20px" 
                              Width="85px" ValidationGroup="validatediscount"></asp:TextBox>
                              <asp:RangeValidator ID="rngone" runat="server" 
                                      ControlToValidate="txtone" 
                                      ValidationGroup="validatediscount" Type="Date">*</asp:RangeValidator>
                               <asp:RequiredFieldValidator ID="rfvtxtone" runat="server" 
                                   ErrorMessage="Specify the event date" ControlToValidate="txtone"  ValidationGroup="validatediscount">*</asp:RequiredFieldValidator>
                              <asp:TextBox ID="txtmulti" runat="server" Visible="false" Height="20px" 
                                   Width="86px" ValidationGroup="events"></asp:TextBox> 
                              <asp:RequiredFieldValidator ID="rfvtxtmulti" runat="server" 
                              ErrorMessage="Please enter the end date" ControlToValidate="txtmulti"  ValidationGroup="validatediscount">*</asp:RequiredFieldValidator>
                    </td>
                              <AjaxToolkit:CalendarExtender Animated="true" ID="calenderExtender1" runat="server" TargetControlID="txtone"></AjaxToolkit:CalendarExtender>
                              <AjaxToolkit:CalendarExtender Animated="true" ID="CalendarExtender2" runat="server" TargetControlID="txtmulti"></AjaxToolkit:CalendarExtender>
                               <AjaxToolkit:TextBoxWatermarkExtender ID="TextBoxWatermarkExtender1" runat="server" TargetControlID="txtone" WatermarkText="Start Date">
                             </AjaxToolkit:TextBoxWatermarkExtender>
                             <AjaxToolkit:TextBoxWatermarkExtender ID="TextBoxWatermarkExtender2" runat="server" TargetControlID="txtmulti" WatermarkText="End Date">
                             </AjaxToolkit:TextBoxWatermarkExtender>  
    
                  </tr>
                   <tr>
                    <td align="right" class="style10"><span class="star">*</span><span class="list">Address</span></td>
                    <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
                    <td height="30" align="left">
                       <asp:TextBox ID="txtaddr" runat="server" Width="196px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" 
                          ErrorMessage="please enter Address" ControlToValidate="txtaddr" 
                         ValidationGroup="validatediscount" Text="*">*</asp:RequiredFieldValidator>
                   </td>
                  </tr>
                   <tr>
                    <td align="right" class="style10"><span class="star">*</span><span class="list">Locality</span></td>
                    <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
                    <td height="30" align="left">
                      <asp:TextBox ID="txtlocality" runat="server" Width="196px"  onkeypress="return Alphabets(event);"></asp:TextBox>
                    </td>
                  </tr>
                  <tr>
                    <td align="right" class="style10"><span class="star">*</span><span class="list">LandMark</span></td>
                    <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
                    <td height="30" align="left">
                       <asp:TextBox ID="txtlandmark" runat="server" Width="196px"></asp:TextBox><b style="color:#093; font-size:11px;"></b>
                   </td>
                  </tr>
                   <tr>
                    <td align="right" class="style10"><span class="star">*</span><span class="list">Timings</span></td>
                    <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
                    <td height="30" align="left">
                     <asp:TextBox ID="txttim" runat="server" Width="196px"></asp:TextBox>
                   </td>
                  </tr>
                   <tr>
                    <td align="right" class="style10"><span class="star">*</span><span class="list">State</span></td>
                    <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
                    <td height="30" align="left">
                     <asp:DropDownList ID="ddlstate" runat="server" AutoPostBack="true" 
                          Height="21px" 
                       Width="197px" OnSelectedIndexChanged="ddlstate_selectedindexchanged"></asp:DropDownList>
                     <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                              ErrorMessage="please select state" ControlToValidate="ddlstate" 
                              ValidationGroup="validatediscount" Text="*" InitialValue="select">*</asp:RequiredFieldValidator>
                    </td>
                  </tr>
                   <tr>
                    <td align="right" class="style10"><span class="star">*</span><span class="list"> City</span></td>
                    <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
                    <td height="30" align="left">
                     <asp:DropDownList ID="ddlcity" runat="server" AutoPostBack="false" 
                     Height="21px" 
                     Width="197px"></asp:DropDownList>
                     <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" 
                         ControlToValidate="ddlcity" ErrorMessage="please select city" 
                         ValidationGroup="validatediscount" InitialValue="select">*</asp:RequiredFieldValidator>
                   </td>
                  </tr>
                   <tr>
                    <td align="right" class="style10"><span class="star">*</span><span class="list">Pincode</span></td>
                    <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
                    <td height="30" align="left">
                      <asp:TextBox ID="txtpin" runat="server" MaxLength="6" onkeypress="return onlyNos(event,this);" Width="196px"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                     ControlToValidate="txtpin" ErrorMessage="Enter pincode number only 6 digits(starting number should starts from 1 to 9 digits)" 
                       ValidationExpression="^[01]?[- .]?(\([1-9]\d{1}\)|[1-9]\d{1})[- .]?\d{2}[- .]?\d{2}$" Display="Dynamic"></asp:RegularExpressionValidator>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                       ErrorMessage="please enter pin number" ControlToValidate="txtpin" 
                       ValidationGroup="validatediscount">*</asp:RequiredFieldValidator>
                    
                      </td>
                   </tr>
                    <tr>
                    <td align="right" class="style10"><span class="star">*</span><span class="list"> Contact Person</span></td>
                    <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
                    <td height="30" align="left">
                     <asp:TextBox ID="txtcont" runat="server" Width="196px" onkeypress="return Alphabets(event);"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
                       ErrorMessage="please enter the Contact Person" 
                       ControlToValidate="txtcont" ValidationGroup="validatediscount">*</asp:RequiredFieldValidator>
                    </td>
                  </tr>
                  <tr>
                    <td align="right" class="style10"><span class="star">*</span> <span class="list">Mobile</span></td>
                    <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
                    <td height="30" align="left" class="mid1_menu">
                     <asp:TextBox ID="txtcode" runat="server" ReadOnly="true" Text="+91" Width="30px"></asp:TextBox>-
                       <asp:TextBox ID="txtmob" runat="server" Width="158px" MaxLength="10" onkeypress="return onlyNos(event,this);"></asp:TextBox>
                    <%-- <asp:RangeValidator ID="RangeValidator1" runat="server" 
                       ControlToValidate="txtmob" ErrorMessage="Mobile Number must start with zero " 
                       ValidationGroup="validatediscount" MaximumValue="1" MinimumValue="0">*</asp:RangeValidator>--%>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
                       ErrorMessage="Enter mobile number only ten digits(starting number should starts from 1 to 9 digits)" ValidationExpression="^[01]?[- .]?(\([1-9]\d{2}\)|[1-9]\d{2})[- .]?\d{3}[- .]?\d{4}$" Display="Dynamic"
                       ValidationGroup="validatediscount" ControlToValidate="txtmob"></asp:RegularExpressionValidator>
                    <%--<asp:RequiredFieldValidator ID="validmob" runat="server" 
                       ErrorMessage="please enter your mobile number " ControlToValidate="txtmob" 
                       ValidationGroup="validatediscount">*</asp:RequiredFieldValidator>--%>
                    </td>
                  </tr>
                  <tr>
                    <td align="right">&nbsp;</td>
                    <td align="center">&nbsp;</td>
                    <td align="left"><b class="side_menu">(E.g:- 9000465921)</b></td>
                  </tr>
                  <tr>
                    <td align="right" class="style10"><span class="star"></span> <span class="list">LandLine</span></td>
                    <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
                    <td height="30" align="left">
                      <asp:TextBox ID="txtlandline" runat="server" onkeypress="return onlyNos(event,this);" MaxLength="10" Width="196px"></asp:TextBox>            
                     <%--<asp:RangeValidator ID="RangeValidator2" runat="server" 
                       ControlToValidate="txtlandline" ErrorMessage="Landline Number must start with zero " 
                       ValidationGroup="validatediscount" MaximumValue="1" MinimumValue="0">*</asp:RangeValidator>--%>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" 
                    ErrorMessage="Only numbers are allowed for landline" ValidationExpression="\d{10}" 
                    ValidationGroup="validatediscount" ControlToValidate="txtlandline">*</asp:RegularExpressionValidator>
                   </td>
                  </tr>
                  <tr>
                    <td align="right" class="style10"><span class="star">*</span> <span class="list">Email</span></td>
                    <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
                    <td height="30" align="left">
                      <asp:TextBox ID="txtmail" runat="server" Width="196px"></asp:TextBox>
                   <b style="color:#093; font-size:11px;"></b>
                  <asp:RegularExpressionValidator ID="fmtemail" runat="server" 
                    ErrorMessage="Invalid Format of email address" 
                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
                    ValidationGroup="validatediscount" ControlToValidate="txtmail">*</asp:RegularExpressionValidator>
                   <asp:RequiredFieldValidator ID="validemail" runat="server" 
                    ErrorMessage="please enter email" ControlToValidate="txtmail" 
                    ValidationGroup="validatediscount">*</asp:RequiredFieldValidator> </td>
                  </tr>
                  <tr>
                    <td align="right" class="style10"><span class="star"></span> <span class="list">Fax</span></td>
                    <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
                    <td height="30" align="left">
                      <asp:TextBox ID="txtfax" runat="server" Width="196px" onkeypress="return onlyNos(event,this);" MaxLength="11"></asp:TextBox>
                      <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" 
                         ControlToValidate="txtfax" ErrorMessage="Only numbers are allowed for fax" 
                         ValidationExpression="\d{11}" ValidationGroup="validatediscount">*</asp:RegularExpressionValidator>
                      </td>
                   </tr>
                   <tr>
                    <td align="right" valign="top" class="style10"><span class="star"></span><span class="list">website</span></td>
                    <td align="center" valign="top"><strong>&nbsp;:&nbsp;</strong></td>
                    <td height="30" align="left" class="mid1_menu"> 
                     <asp:TextBox ID="txtweb" runat="server" Width="196px"></asp:TextBox>
                      <asp:RegularExpressionValidator ID="RegularExpressionValidator6" runat="server" 
                          ControlToValidate="txtweb" ErrorMessage="Invalid Format of website" 
                          ValidationExpression="http(s)?://([\w-]+\.)+[\w-]+(/[\w- ./?%&amp;=]*)?" 
                          ValidationGroup="validatediscount">*</asp:RegularExpressionValidator>
                    </td>
                    </tr>
                    <tr>
                    <td align="right">&nbsp;</td>
                    <td align="center">&nbsp;</td>
                    <td align="left"><b class="side_menu">(E.g:- http://www.Justcalluz.com )</b>
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
                          ShowMessageBox="True" ShowSummary="False" ValidationGroup="validatediscount" />
                     </td>
                    </tr>
                    <tr>
                    <td align="right" class="style10">&nbsp;</td>
                   </tr>
                    <tr id="truploadLogo" runat="server" visible="false">
                        <td align="right" valign="top" class="style10"><span class="star"></span><span class="list"> To upload Logo</span></td>
                        <td align="center" valign="top"><strong>:</strong></td>
                        <td height="30" align="left" class="mid1_menu"> 
                        <asp:FileUpload ID="uploadLogo" runat="server" />
                         <asp:Button ID="btnUploadLogo" runat="server" Text="Upload Logo" 
                                                onclick="btnUploadLogo_Click" Width="100px" />
                        </td>
                    </tr>
                    <tr id="trDisplayLogo" runat="server">
                                <td colspan="2">&nbsp;</td>
                                <td align="left">
                                  <asp:Image ID="ImgLogo" runat="server" Width="100px" Height="75px" AlternateText="companyLogo"/> 
                                  <asp:Button ID="btnLogochange" runat="server" Text="Change Logo" 
                                      OnClick="btnLogochange_Click" Width="100px"/>
                                 </td> 
                    </tr>
                     <tr>
                            <td colspan="2"></td>
                            <td align="center">
                                <asp:Label ID="lblLogo" runat="server" ForeColor="Red"></asp:Label>
                           </td>
                     </tr>
                      <tr id="tr1" runat="server">
                            <td align="right" valign="top" class="style10"><span class="star"></span><span class="list">  To upload Photos </span></td>
                            <td align="center" valign="top"><strong>&nbsp;:&nbsp;</strong></td>
                            <td height="30" align="left" class="mid1_menu"> 
                            <asp:FileUpload ID="uploadPhotos" runat="server" />
                             <asp:Button ID="btnUploadPhotos" runat="server" Text="Upload Photos" 
                                                    onclick="btnUploadPhotos_Click" Width="100px" />
                            </td>
                      </tr>
                       <tr>
                            <td colspan="2"></td>
                            <td align="center">
                                <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>
                             </td>
                      </tr>
                      <tr id="trDlphoto" runat="server" align="left">
                            <td  align="right" valign="top" class="style10">
                                <asp:DataList ID="dlPhoto" runat="server" RepeatDirection="Horizontal" DataKeyField="id">
                                    <ItemTemplate> 
                                      <table>
                                        <tr>
                                            <td>                                    
                                            <asp:Image ID="ImgPhoto" runat="server" Width="100px" Height="75px" AlternateText="CompanyPhotos" 
                                                ImageUrl='<%# Eval("PhotoName", "../Photos\\{0}") %>' />                                                                              
                                            </td>
                                        </tr>
                                        <tr>
                                             <td align="center">
                                            <asp:Button ID="lnkdelphoto" runat="server" Text="Delete" BackColor="#ECF9FF" OnCommand="lnkdelphoto" CommandArgument='<%#Eval("id") %>'
                                                 OnClientClick="Are you sure!To delete the photo?" />
                                           </td>
                                        </tr>
                                     </table> 
                                    </ItemTemplate> 
                               </asp:DataList>
                             </td>
                      </tr>
                      <tr>
                       <td colspan="4"></td>
                      </tr>
                     </table>
                   </td></tr>
                   <tr>
                     <td colspan="3">
                       <table width="100%">
                         <tr><td class="side_menu" colspan="3" style="font-size:medium; background-color:White" align="left">Hours of Operation :</td></tr>
                         <tr>
                              <td style="font-family:Arial" align="right">Monday</td>
                              <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
                              <td align="left">
                                  <asp:DropDownList ID="ddlMonday" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlMonday_SelectedIndexChanged">
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
                                  <td colspan="2"></td>
                                  <td valign="middle" style="font-family:Arial">
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
                                        &nbsp;<%--<asp:LinkButton ID="lnkMonTimings" runat="server" ForeColor="Red" 
                                          onclick="lnkMonTimings_Click">Add Timings</asp:LinkButton>--%>
                                     <a id="lnkMonTimings" runat="server" style="color:Red;" onserverclick="lnkMonTimings_Click">Add Timings</a>                                                                          
                                      <asp:Label ID="lblLnkMon" runat="server" Visible="false"></asp:Label>
                                  </td>
                            </tr>
                            <tr id="trLstMon" runat="server">
                                    <td colspan="2"></td>
                                    <td valign="middle">
                                    <table><tr><td style="font-family:Arial">
                                     <asp:Literal ID="ltrMonTime" runat="server"></asp:Literal>   
                                     <a id="lnkBtnClearMonTimings" runat="server" style="color:Red;" onserverclick="lnkBtnClearMonTimings_Click">Clear Timings</a>                                 
                                    </td>
                                    <td>
                                           <asp:Label ID="lblMonTime" runat="server" Visible="false"></asp:Label>
                                    </td></tr></table>                                                                    
                                      </td>
                                  </tr>
                             <tr>
                                  <td style="font-family:Arial" align="right">Tuesday</td>
                                  <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
                                  <td align="left">
                                      <asp:DropDownList ID="ddlTuesday" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlTuesday_SelectedIndexChanged">
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
                                  <td valign="middle" style="font-family:Arial">
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
                                </td>
                           </tr>
                           <tr id="trLstTues" runat="server">
                                <td colspan="2"></td>
                                <td valign="middle">
                                <table><tr><td style="font-family:Arial">
                                 <asp:Literal ID="ltrTuesTime" runat="server"></asp:Literal>   
                                <%-- <asp:LinkButton ID="lnkBtnClearTuesTimings" runat="server" 
                                     ForeColor="Red" onclick="lnkBtnClearTuesTimings_Click">Clear Timings</asp:LinkButton> --%> 
                                  <a id="lnkBtnClearTuesTimings" runat="server" style="color:Red;" onserverclick="lnkBtnClearTuesTimings_Click">Clear Timings</a>                               
                                </td>
                                <td>
                                       <asp:Label ID="lblTuesTime" runat="server" Visible="false"></asp:Label>
                                </td></tr></table>                                                                    
                                  </td>
                          </tr>
                          <tr>
                              <td style="font-family:Arial" align="right">Wednesday</td>
                              <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
                              <td align="left">
                                  <asp:DropDownList ID="ddlWednesday" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlWednesday_SelectedIndexChanged">
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
                              <td valign="middle" style="font-family:Arial">
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
                                  &nbsp;<%--<asp:LinkButton ID="lnkWedTimings" runat="server" 
                                       ForeColor="Red" onclick="lnkWedTimings_Click">Add Timings</asp:LinkButton>--%>
                                   <a id="lnkWedTimings" runat="server" style="color:Red;" onserverclick="lnkWedTimings_Click">Add Timings</a>                                                                
                                  <asp:Label ID="lblLnkWed" runat="server" Visible="false"></asp:Label>
                                  
                              </td>
                          </tr>
                          <tr id="trLstWed" runat="server">
                                    <td colspan="2"></td>
                                    <td valign="middle" style="font-family:Arial">
                                    <table><tr><td style="font-family:Arial">
                                     <asp:Literal ID="ltrWedTime" runat="server"></asp:Literal>       
                                    <%-- <asp:LinkButton ID="lnkBtnClearWedTimings" runat="server" 
                                           ForeColor="Red" onclick="lnkBtnClearWedTimings_Click">Clear Timings</asp:LinkButton>--%> 
                                      <a id="lnkBtnClearWedTimings" runat="server" style="color:Red;" onserverclick="lnkBtnClearWedTimings_Click">Clear Timings</a>                                                                                                                                      
                                    </td>
                                    <td>
                                           <asp:Label ID="lblWedTime" runat="server" Visible="false"></asp:Label>
                                    </td></tr></table>                                                                    
                                      </td>
                           </tr>
                           <tr>
                              <td style="font-family:Arial" align="right">Thursday</td>
                              <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
                              <td align="left">
                                  <asp:DropDownList ID="ddlThursday" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlThursday_SelectedIndexChanged">
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
                              <td valign="middle" style="font-family:Arial">
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
                                  &nbsp;<%--<asp:LinkButton ID="lnkThursTimings" runat="server" 
                                       ForeColor="Red" onclick="lnkThursTimings_Click">Add Timings</asp:LinkButton>--%>
                                    <a id="lnkThursTimings" runat="server" style="color:Red;" onserverclick="lnkThursTimings_Click">Add Timings</a>                                                                                                                                                                             
                                  <asp:Label ID="lblLnkThurs" runat="server" Visible="false"></asp:Label>
                            </td>
                          </tr>
                          <tr id="trLstThurs" runat="server">
                                <td colspan="2"></td>
                                <td valign="middle">
                                <table><tr><td style="font-family:Arial">
                                 <asp:Literal ID="ltrThursTime" runat="server"></asp:Literal>
                                 <%--<asp:LinkButton ID="lnkBtnClearThursTimings" runat="server" ForeColor="Red" onclick="lnkBtnClearThursTimings_Click">Clear Timings</asp:LinkButton> --%>
                                      <a id="lnkBtnClearThursTimings" runat="server" style="color:Red;" onserverclick="lnkBtnClearThursTimings_Click">Clear Timings</a>                                                                                                                                                                             
                                                                    
                                </td>
                                <td>
                                       <asp:Label ID="lblThursTime" runat="server" Visible="false"></asp:Label>
                                </td></tr></table>                                                                    
                                  </td>
                           </tr>
                           <tr>
                                  <td style="font-family:Arial" align="right">Friday</td>
                                  <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
                                  <td align="left">
                                      <asp:DropDownList ID="ddlFriday" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlFriday_SelectedIndexChanged">
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
                              <td valign="middle" style="font-family:Arial">
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
                                  &nbsp;<%--<asp:LinkButton ID="lnkFriTimings" runat="server" 
                                     ForeColor="Red" onclick="lnkFriTimings_Click">Add Timings</asp:LinkButton>--%>
                                      <a id="lnkFriTimings" runat="server" style="color:Red;" onserverclick="lnkFriTimings_Click">Add Timings</a>                                                                                                                                                                             
                                     
                                  <asp:Label ID="lblLnkFri" runat="server" Visible="false"></asp:Label>
                            </td>
                         </tr>
                        <tr id="trLstFri" runat="server">
                        <td colspan="2"></td>
                        <td valign="middle">
                        <table><tr><td style="font-family:Arial">
                         <asp:Literal ID="ltrFriTime" runat="server"></asp:Literal>     
                        <%-- <asp:LinkButton ID="lnkBtnClearFriTimings" runat="server" 
                            ForeColor="Red" onclick="lnkBtnClearFriTimings_Click">Clear Timings</asp:LinkButton>   --%> 
                          <a id="lnkBtnClearFriTimings" runat="server" style="color:Red;" onserverclick="lnkBtnClearFriTimings_Click">Clear Timings</a>                                                                                                                                                                             
                                                       
                        </td>
                        <td>
                               <asp:Label ID="lblFriTime" runat="server" Visible="false"></asp:Label>
                        </td></tr></table>                                                                    
                          </td>
                       </tr>
                       <tr>
                       <td style="font-family:Arial" align="right">Saturday</td>
                       <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
                       <td align="left">
                          <asp:DropDownList ID="ddlSaturday" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlSaturday_SelectedIndexChanged">
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
                          <td valign="middle" style="font-family:Arial">
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
                              &nbsp;<%--<asp:LinkButton ID="lnkSaturTimings" runat="server" 
                                 ForeColor="Red" onclick="lnkSaturTimings_Click">Add Timings</asp:LinkButton>--%>
                          <a id="lnkSaturTimings" runat="server" style="color:Red;" onserverclick="lnkSaturTimings_Click">Add Timings</a>                                                                                                                                                                             
                                 
                              <asp:Label ID="lblLnkSatur" runat="server" Visible="false"></asp:Label>
                              
                          </td>
                      </tr> 
                      <tr id="trLstSatur" runat="server">
                        <td colspan="2"></td>
                        <td valign="middle">
                        <table><tr><td style="font-family:Arial">
                         <asp:Literal ID="ltrSaturTime" runat="server"></asp:Literal>
                         <%-- <asp:LinkButton ID="lnkBtnClearSatTimings" runat="server" 
                              ForeColor="Red" onclick="lnkBtnClearSatTimings_Click">Clear Timings</asp:LinkButton>--%>   
                          <a id="lnkBtnClearSatTimings" runat="server" style="color:Red;" onserverclick="lnkBtnClearSatTimings_Click">Clear Timings</a>                                                                                                                                                                             
                                                              
                        </td>
                        <td>
                               <asp:Label ID="lblSaturTime" runat="server" Visible="false"></asp:Label>
                        </td></tr></table>                                                                    
                          </td>
                      </tr>                                                                                  
                      <tr>
                      <td style="font-family:Arial" align="right">Sunday</td>
                      <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
                      <td align="left">
                          <asp:DropDownList ID="ddlSunday" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlSunday_SelectedIndexChanged">
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
                          <td valign="middle" style="font-family:Arial">
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
                              &nbsp;<%--<asp:LinkButton ID="lnkSunTimings" runat="server" ForeColor="Red" onclick="lnkSunTimings_Click">Add Timings</asp:LinkButton>--%>
                              <a id="lnkSunTimings" runat="server" style="color:Red;" onserverclick="lnkSunTimings_Click">Add Timings</a>                                                                                                                                                                             
                                
                              <asp:Label ID="lblLnkSun" runat="server" Visible="false"></asp:Label>
                           </td>
                      </tr>
                      <tr id="trLstSun" runat="server">
                        <td colspan="2"></td>
                        <td valign="middle">
                        <table><tr><td style="font-family:Arial">
                         <asp:Literal ID="ltrSunTime" runat="server"></asp:Literal>   
                         <%--<asp:LinkButton ID="lnkBtnClearSuntimings" runat="server" ForeColor="Red" onclick="lnkBtnClearSuntimings_Click">Clear Timings</asp:LinkButton>--%>                                 
                           <a id="lnkBtnClearSuntimings" runat="server" style="color:Red;" onserverclick="lnkBtnClearSuntimings_Click">Clear Timings</a>                                                                                                                                                                             
                         
                        </td>
                        <td>
                               <asp:Label ID="lblSunTime" runat="server" Visible="false"></asp:Label>
                        </td></tr></table>                                                                    
                          </td>
                      </tr>
                     <tr><td class="side_menu" colspan="3" style="font-size:medium; background-color:White" align="left">Mode Of Payment :</td></tr>
                      <tr id="trPayment" runat="server">
                          <td colspan="2"></td>
                          <td align="left" style="font-family:Arial;">
                              <asp:CheckBoxList ID="modecheck" runat="server" RepeatColumns="2" Font-Names="Arial">
                              <asp:ListItem>  American Express Card</asp:ListItem>
                              <asp:ListItem>  Cash</asp:ListItem>
                              <asp:ListItem>  Cheques</asp:ListItem>
                              <asp:ListItem>  Credit Card</asp:ListItem>
                              <asp:ListItem>  Debit Card</asp:ListItem>
                              <asp:ListItem>  Financind Available</asp:ListItem>
                              <asp:ListItem>  Master Card</asp:ListItem>
                              <asp:ListItem>  Money Orders</asp:ListItem>
                              <asp:ListItem>  Travelers Check</asp:ListItem>
                              <asp:ListItem>  Visa Card</asp:ListItem>
                             </asp:CheckBoxList>
                          </td>
                      </tr>
                      <tr><td colspan="3" style="font-family:Arial">Additional Information</td></tr>
                      <tr id="tr2" runat="server">
                          <td colspan="2"></td>
                          <td valign="middle">
                              <asp:TextBox ID="txtAdtInfo" runat="server" TextMode="MultiLine" Width="190px"></asp:TextBox>
                          </td>
                      </tr>
                       <tr><td></td></tr>
                      <tr><td class="side_menu" colspan="3" style="font-size:medium; background-color:White" align="left">Company Profile :</td></tr>
                      <tr><td></td></tr>
                      <tr><td style="font-family:Arial" align="right">Year Of Establishment</td>
                      <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
                      <td align="left">
                          <asp:DropDownList ID="ddlyearestblish" runat="server" Width="191px">
                          </asp:DropDownList>
                      </td>
                      </tr>
                      <tr><td style="font-family:Arial" align="right">Professional Association</td>
                     <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
                      <td align="left"><asp:TextBox ID="txtprofass" runat="server" Width="190px"></asp:TextBox></td>
                      </tr>
                      <tr>
                      <td style="font-family:Arial" align="right">Certification</td>
                     <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
                      <td align="left"><asp:TextBox ID="txtcertificate" runat="server" Width="190px"></asp:TextBox></td>
                      </tr>
                      <tr><td style="font-family:Arial" align="right">No.of.Employees</td>
                      <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
                      <td align="left"><asp:TextBox ID="txtemp" runat="server" Width="190px"></asp:TextBox></td>
                      </tr>
                      <tr><td></td></tr>
                      <tr><td class="side_menu" colspan="3" style="font-size:medium; background-color:White" align="left">Verification Code :</td></tr>
                       <tr><td>&nbsp;</td></tr>
                       <tr>
                        <td align="right" style="font-family:Arial" >
                         <asp:UpdatePanel ID="UpdatePanel2" runat="server" UpdateMode="Conditional">
                          <ContentTemplate> 
                            <cc1:CaptchaControl ID="ccjoin" runat="server" BackColor="AntiqueWhite" 
                                 CaptchaBackgroundNoise="None" CaptchaHeight="35" CaptchaLength="4" 
                                 CaptchaWidth="90" CaptchaLineNoise="None" CaptchaMinTimeout="5" 
                                 CaptchaMaxTimeout="200" Width="90px" />
                           </ContentTemplate>
                           </asp:UpdatePanel>
                            </td>
                           <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
                            <td align="left">
                              <asp:TextBox ID="txtvid" runat="server" Width="190px"></asp:TextBox>
                            </td>
                       </tr>
                      <tr><td>
                      </td></tr>
                      </table>
                     </td>
                   </tr>
                   <tr>
                     <td height="30" colspan="3">
                        <table width="100%" border="0">
                          <tr>
                        <td width="36%" align="right" height="30" style="padding-right:3px;"><asp:ImageButton ID="btnupdate" runat="server" 
                                 ImageUrl="images/update.png" onclick="btnupdate_Click" ValidationGroup="validatediscount" />
                        </td>
                        <td width="40%" align="left"><asp:ImageButton ID="GotoPreviousPage" runat="server" ImageUrl="images/cancel-button.png" 
                             AlternateText="PreviousPage" PostBackUrl="<%$RouteUrl:RouteName=ViewDiscount%>"/></td>
                          </tr>
                        </table>
                     </td>
                   </tr>
                   <tr>
                      <td height="30" colspan="3" align="center" class="right_tab" style="padding-top:5px;">
                            <font class="side_menu" color="#005B88">Dear Guest, kindly submit all the
                             
                                marked details. Its kind of</font><span class="mid_menu"><strong class="mid_menu">
                            <font color="#E84B00">mandatory</font></strong>. </span><span class="side_menu">What to</span> 
                            <span class="side_menu">do! Its not our fault. We are here to provide the best of our services<strong> 
                             </strong></span><span class="mid_menu"><strong><font color="#E84B00"> 24*7</font></strong></span></td>
                   </tr>
                   <tr>
                      <td height="30" align="right">&nbsp;</td>
                   </tr>
            </table>
     </div>
     </td>
     </tr>
     </table>
     </div>
 <div class="content_innerright" >
<div class="contentbox_top">Sponsor Ads</div>
<div class="contentbox_mid">
<table width="100%" border="0">
      <tr>
         <td class="right_tab">
           <SpLinks:spd_Links ID="right_ads" runat="server" />
         </td>
    </tr>
</table>
</div>
<div class="contentbox_bottam"></div>
</div>
</div>
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
 </form>
</body>
</html>
