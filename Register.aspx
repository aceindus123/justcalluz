<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" %>
<%@ Register Src="usercontrols/signin.ascx" TagName="signin" TagPrefix="aa1"  %>
<%@ Register Src="usercontrols/topimage.ascx" TagName="topimage" TagPrefix="aa2" %>
<%@ Register Src="usercontrols/SearchNew.ascx" TagName="newsearch" TagPrefix="nsearch"%><%@ Register Src="usercontrols/catageories.ascx" TagName="catag" TagPrefix="aa6" %>
<%@ Register Src="usercontrols/footer1.ascx" TagName="footer1" TagPrefix="aa10" %>
<%@ Register Src="usercontrols/footer2.ascx" TagName="footer2" TagPrefix="aa11" %>
<%@ Register Src="usercontrols/BottomContent.ascx" TagName="Bottomcontent" TagPrefix="bcon" %>
<%@ Register Src="usercontrols/BottomMidContent.ascx" TagName="Contentmid" TagPrefix="bcm" %>
<%@ Register Src="usercontrols/catageories.ascx" TagName="catageories" TagPrefix="aa6" %>
<%@ Register Src="usercontrols/small_logo.ascx" TagName="logosmall" TagPrefix="lgsmall" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<%--<script type="text/javascript">
    var specialKeys = new Array();
    specialKeys.push(8); //Backspace
    function IsNumeric(e) {
        var keyCode = e.which ? e.which : e.keyCode
        var ret = ((keyCode >= 48 && keyCode <= 57) || specialKeys.indexOf(keyCode) != -1);
        document.getElementById("error").style.display = ret ? "none" : "inline";
        return ret;
    }
    </script>--%>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>Register page | JustCalluz</title>
<link href="css/style.css" rel="stylesheet" type="text/css" />
<link href="css/inner_style.css" rel="Stylesheet" type="text/css" />
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
<aa1:signin ID="SignIn1" runat="server" />
</div>
<div class="header">
<%--<div class="header_top"></div>--%>
<div class="header_logo">
<lgsmall:logosmall ID="lglogo" runat="server" />
</div><div class="header_search">

<nsearch:newsearch ID="search" runat="server" />
</div>
</div>
<div class="category_box">
<aa6:catageories ID="dff" runat="server" />
</div>
<!-- start the Content-->
<div class="content" style="padding:0; margin:0;">
<div style="width:100%">
  <div class="contentmid_boxmid" style="width:77.5%; padding:none; background:none; border:dotted 1px #666"><table width="100%" border="0" bgcolor="#ECF9FF">
  <tr><td height="15">
   <asp:Label ID="lblMessage" runat="server"></asp:Label>
    <asp:Label ID="lblerror" runat="server"></asp:Label>
    <asp:Label ID="lblValid" runat="server"></asp:Label>
   </td></tr>
    <tr>
      <td><table width="100%" border="0" bgcolor="">
        <tr>
          <td height="35" colspan="3" style="background:url(images/search_midtop.png) no-repeat"><table width="100%" border="0">
<tr>
    <td class="location"  height="35" style="padding-left:15px; background:url(images/search_midtop.png) no-repeat "><font color="white">
        Welcome to JustCallUz :: Registration</font></td>
  </tr>
</table>
</td>
          </tr>
           <tr>
          <td height="20" colspan="3" align="center" style="padding-left:10px;" class="sub_menu">
          <asp:RadioButton ID="radbtnBusiness" runat="server" GroupName="group" Checked="true" Text="Business" AutoPostBack="true" 
                    oncheckedchanged="radbtnBusiness_CheckedChanged" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
          <asp:RadioButton ID="radbtnIndividual" runat="server" Text="Individual" GroupName="group" AutoPostBack="true" 
                    oncheckedchanged="radbtnIndividual_CheckedChanged" />
          </td>
        </tr>
          
          
        
        <tr>
          <td height="20" colspan="3" align="left" style="padding-left:10px;"><hr/></td>
        </tr>
        
       <tr id="trbname" runat="server">
                    <td align="right" class="side_menu">Business Name<asp:Label ID="Label8" runat="server" Text="*" ForeColor="Red"></asp:Label></td>
                    <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
                    <td align="left" style="height:10px">
                        <asp:TextBox ID="txtbusiname" runat="server" Width="190px"  onkeypress="return Alphabets(event);"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                        ErrorMessage="please enter Business Name" ControlToValidate="txtbusiname" 
                            ValidationGroup="RegGroup">*</asp:RequiredFieldValidator>
                    </td>
        </tr>
         <tr><td height="5" colspan="3"></td></tr>
          <tr id="trkindofbusiness" runat="server">
                    <td align="right" class="side_menu">Kind of Business<asp:Label ID="Label9" runat="server" Text="*" ForeColor="Red"></asp:Label></td>
                    <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
                    <td align="left" style="height:10px">
                        <%--<asp:TextBox ID="txtkob" runat="server" Width="190px"></asp:TextBox> --%>
                         <asp:DropDownList ID="ddlCategory" runat="server" Width="190px">
                          </asp:DropDownList>
                           <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" 
                    ErrorMessage="please select Kind of Business" ControlToValidate="ddlCategory" 
                            ValidationGroup="UpdateProfile">*</asp:RequiredFieldValidator>
                        <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                    ErrorMessage="please enter Kind of Business" ControlToValidate="txtkob" 
                            ValidationGroup="RegGroup">*</asp:RequiredFieldValidator>--%>
                        </td>
                </tr>
                <tr><td height="5" colspan="3"></td></tr>
         <tr id="trwebsite" runat="server">
                    <td align="right" class="side_menu">Website</td>
                     <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
                    <td align="left" style="height:10px">
                        <asp:TextBox ID="txtweb" runat="server" Width="190px"></asp:TextBox><b style="color:#093; font-size:11px;"></b>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator6" runat="server" 
                            ErrorMessage="Please enter url Eg: http:www.justcalluz.com" 
                            ControlToValidate="txtweb" 
                            ValidationExpression="http(s)?://([\w-]+\.)+[\w-]+(/[\w- ./?%&amp;=]*)?" 
                            ValidationGroup="RegGroup">*</asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr><td height="5" colspan="3"></td></tr>
         <tr id="trdes" runat="server">
                    <td align="right" class="side_menu">Description<asp:Label ID="Label2" runat="server" Text="*" ForeColor="Red"></asp:Label></td>
                     <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
                    <td align="left" style="height:10px">
                        <asp:TextBox ID="txtdesc" runat="server" Width="190px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                         ErrorMessage="please enter Description." ControlToValidate="txtdesc" 
                            ValidationGroup="RegGroup">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr><td height="5" colspan="3"></td></tr>
                <tr id="trname" runat="server">
                    <td align="right" class="side_menu">First Name<asp:Label ID="Label1" runat="server" Text="*" ForeColor="Red"></asp:Label></td>
                     <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
                    <td align="left" style="height:10px">
                        <asp:TextBox ID="txtuname" runat="server" Width="190px"   onkeypress="return Alphabets(event);"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ErrorMessage="please enter First Name" ControlToValidate="txtuname" 
                            ValidationGroup="RegGroup">*</asp:RequiredFieldValidator>
                            <%-- <asp:RegularExpressionValidator ID="RegUname" runat="server" ErrorMessage="Only charecters will be allowed"
                           ValidationExpression="a-zA-Z ]*$" ControlToValidate="txtuname" 
                            ValidationGroup="RegGroup">*</asp:RegularExpressionValidator>--%>
                   </td>
                </tr>
                <tr><td height="5" colspan="3"></td></tr>
                 <tr id="trLname" runat="server">
                    <td align="right" class="side_menu">Last Name<asp:Label ID="Label13" runat="server" Text="*" ForeColor="Red"></asp:Label></td>
                     <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
                    <td align="left" style="height:10px">
                        <asp:TextBox ID="txtLatName" runat="server" Width="190px"  onkeypress="return Alphabets(event);"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" 
                    ErrorMessage="please enter Last Name" ControlToValidate="txtLatName" 
                            ValidationGroup="RegGroup">*</asp:RequiredFieldValidator>
                   </td>
                </tr>
                <tr><td height="5" colspan="3"></td></tr>
                <tr id="trmob" runat="server">
                    <td align="right" class="side_menu"><asp:Label ID="lblsms" runat="server" Visible="false"></asp:Label>Mobile<asp:Label ID="Label10" runat="server" Text="*" ForeColor="Red"></asp:Label></td>
                    <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
                    <td align="left" style="height:10px">
                        <asp:TextBox ID="txtmob" runat="server" Width="190px" MaxLength="11" onkeypress="return onlyNos(event,this);"></asp:TextBox>
                        <asp:Label ID="Label12" CssClass="side_menu" runat="server" Text="(Eg: 09847562355)"></asp:Label>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                         ErrorMessage="please enter Mob no." ControlToValidate="txtmob" 
                            ValidationGroup="RegGroup">*</asp:RequiredFieldValidator>  
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
                                ErrorMessage="Enter mobile number only ten digits(starting number should starts from 1 to 9 digits)" 
                                ControlToValidate="txtmob" ValidationExpression="^[01]?[- .]?(\([1-9]\d{2}\)|[1-9]\d{2})[- .]?\d{3}[- .]?\d{4}$" Display="Dynamic"
                                ValidationGroup="RegGroup"></asp:RegularExpressionValidator>                     
                        <asp:RangeValidator ID="RangeValidator1" runat="server" 
                            ErrorMessage="The Mobile number should start with zero" MinimumValue="0" ControlToValidate="txtmob" 
                            MaximumValue="1" ValidationGroup="RegGroup">*</asp:RangeValidator>
                        
                    </td>
                </tr>
                <tr><td height="5" colspan="3"></td></tr>
                  <tr id="trpwd" runat="server">
                    <td align="right" class="side_menu">Password<asp:Label ID="Label3" runat="server" Text="*" ForeColor="Red"></asp:Label></td>
                   <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
                    <td align="left" style="height:10px">
                        <asp:TextBox ID="txtpwd" runat="server" Width="190px" TextMode="Password"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
                        ErrorMessage="please enter Password." ControlToValidate="txtpwd" 
                            ValidationGroup="RegGroup">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr><td height="5" colspan="3"></td></tr>
                  <tr id="trrpwd" runat="server">
                    <td align="right" class="side_menu">Re-type Password<asp:Label ID="Label4" runat="server" Text="*" ForeColor="Red"></asp:Label></td>
                     <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
                    <td align="left" style="height:10px">
                        <asp:TextBox ID="txtrpwd" runat="server" Width="190px" TextMode="Password"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" 
                        ErrorMessage="please enter Retype Password." ControlToValidate="txtrpwd" 
                            ValidationGroup="RegGroup">*</asp:RequiredFieldValidator>
                        <asp:CompareValidator ID="CompareValidator1" runat="server" 
                            ErrorMessage="Please retype password correctly as like above" 
                            ControlToCompare="txtpwd" ControlToValidate="txtrpwd" 
                            ValidationGroup="RegGroup">*</asp:CompareValidator>
                    </td>
                </tr>
                <tr><td height="5" colspan="3"></td></tr>
               <tr id="tremail" runat="server">
                    <td align="right" class="side_menu">Email ID<asp:Label ID="Label5" runat="server" Text="*" ForeColor="Red"></asp:Label></td>
                     <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
                    <td align="left" style="height:10px">
                        <asp:TextBox ID="txtemail" runat="server" Width="190px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" 
                        ErrorMessage="please enter Email ID." ControlToValidate="txtemail" 
                            ValidationGroup="RegGroup">*</asp:RequiredFieldValidator>
                    
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                        ErrorMessage="Please Enter the Email Address" ControlToValidate="txtemail" 
                        SetFocusOnError="True" 
                        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
                        Font-Bold="True" ValidationGroup="RegGroup">*</asp:RegularExpressionValidator>                        
                </td>
               </tr>
                 <%--<tr><td height="5" colspan="3"></td></tr>
            <tr id="traddress" runat="server">
                <td align="right"  style="height:20px; padding-top:5px " valign="top" class="side_menu">
                    Address</td>
                <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
                <td align="left" style="height:10px">
                    <asp:TextBox ID="txtaddr" runat="server" TextMode="MultiLine" Width="190px" 
                        Height="60px"></asp:TextBox>
                </td>
            </tr>--%>
             <tr><td height="5" colspan="3"></td></tr>
             <tr id="traddress" runat="server">
                <td align="right" class="side_menu">Address</td>
                 <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
                <td align="left" style="height:10px">
                    <asp:TextBox ID="txtaddr" runat="server" Width="190px" TextMode="MultiLine"></asp:TextBox>
                </td>
            </tr>
            <tr><td height="5" colspan="3"></td></tr>
             <tr id="trlandmark" runat="server">
                <td align="right" class="side_menu">Land Mark</td>
                 <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
                <td align="left" style="height:10px">
                    <asp:TextBox ID="txtlanm" runat="server" Width="190px"></asp:TextBox>
                </td>
            </tr>
            <tr><td height="5" colspan="3"></td></tr>
            <tr id="trstate" runat="server">
                <td align="right" class="side_menu">State<asp:Label ID="Label11" runat="server" Text="*" ForeColor="Red"></asp:Label></td>
                <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
                <td align="left" style="height:10px">                    
                    <asp:DropDownList ID="ddlState" runat="server" Width="190px" 
                        onselectedindexchanged="ddlState_SelectedIndexChanged" AutoPostBack="true">
                    </asp:DropDownList>
                                        
                    <asp:RequiredFieldValidator ID="rfvState" runat="server" 
                        ControlToValidate="ddlState" ErrorMessage="Plese select State" 
                        InitialValue="Select State" ValidationGroup="RegGroup">*</asp:RequiredFieldValidator>                  
                </td>
            </tr>
            <tr><td height="5" colspan="3"></td></tr>
                <tr id="trcity" runat="server">
                    <td align="right" class="side_menu">City/Area<asp:Label ID="Label6" runat="server" Text="*" ForeColor="Red"></asp:Label></td>
                     <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
                    <td align="left" style="height:10px">
                        <asp:DropDownList ID="ddlCity" runat="server" Width="190px">
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                            ErrorMessage="Please Select City" ControlToValidate="ddlCity" 
                            InitialValue="Select City" ValidationGroup="RegGroup">*</asp:RequiredFieldValidator>                        
                    </td>
                </tr>
                <tr><td height="5" colspan="3"></td></tr>
                <tr id="trpincode" runat="server" class="side_menu">
                <td align="right" class="side_menu">Pincode<asp:Label ID="Label7" runat="server" Text="*" ForeColor="Red"></asp:Label></td>
                <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
                <td align="left" style="height:10px">
                    <asp:TextBox ID="txtPincode" runat="server" Width="190px" MaxLength="6" onkeypress="return onlyNos(event,this);"></asp:TextBox><b>
                    (E.g:- 530073)</b>
                    <asp:RequiredFieldValidator ID="rfvPinCode" runat="server" 
                ErrorMessage="Please enter PinCode" ControlToValidate="txtPincode" 
                ValidationGroup="RegGroup">*</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" 
                    ErrorMessage="Enter pincode number only 6 digits(starting number should starts from 1 to 9 digits)" 
                    ControlToValidate="txtPincode" ValidationExpression="^[01]?[- .]?(\([1-9]\d{1}\)|[1-9]\d{1})[- .]?\d{2}[- .]?\d{2}$" Display="Dynamic" 
                    ValidationGroup="RegGroup"></asp:RegularExpressionValidator> 
                </td>
            </tr>
            <tr><td height="5" colspan="3"></td></tr>
            <tr id="trlandline" runat="server" class="side_menu">
                <td align="right">Landline</td>
                 <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
                <td align="left" style="height:10px">
                    <asp:TextBox ID="txtlandline" runat="server" Width="190px" MaxLength="11" onkeypress="return onlyNos(event,this);"></asp:TextBox><b>
                    (E.g:- 04066136226)</b>
                     <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" 
                        ErrorMessage="Please enter phone number of 11 digits" 
                        ControlToValidate="txtlandline" ValidationExpression="\d{11}" 
                        ValidationGroup="RegGroup">*</asp:RegularExpressionValidator>
                    <asp:RangeValidator ID="RangeValidator2" runat="server" MaximumValue="1" MinimumValue="0" 
                        ErrorMessage="Phone number should start with zero" ControlToValidate="txtlandline" 
                        ValidationGroup="RegGroup">*</asp:RangeValidator>
                </td>
            </tr>
            <tr><td height="5" colspan="3"></td></tr>
            <tr id="trfax" runat="server">
                <td align="right" class="side_menu">Fax</td>
                <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
                <td align="left" style="height:10px">
                    <asp:TextBox ID="txtfax" runat="server" Width="190px" MaxLength="11" onkeypress="return onlyNos(event,this);"></asp:TextBox ><b style="color:#093; font-size:11px;"></b>
                    <asp:RangeValidator ID="RangeValidator3" runat="server" MaximumValue="1" MinimumValue="0" 
                        ErrorMessage="Fax should start with zero" ControlToValidate="txtfax" 
                        ValidationGroup="RegGroup">*</asp:RangeValidator>
                       <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" 
                        ErrorMessage="Please enter fax number of 11 digits" 
                        ControlToValidate="txtfax" ValidationExpression="\d{11}" 
                        ValidationGroup="RegGroup">*</asp:RegularExpressionValidator> 
                    </td>                    
            </tr>
            <tr><td height="5" colspan="3"></td></tr>
            <tr><td colspan="3">
             <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
                    ShowMessageBox="True" ShowSummary="False" ValidationGroup="RegGroup" />
            </td></tr>
           
  
        </table></td>
      </tr>
    <tr>
      <td><div class="contentmid_boxmid" style="width:100%; background:none; padding:none" ><table width="100%" border="0">
        <tr>
          <td><table width="100%" border="0">
                    <tr>
                    <td colspan="3"><hr/></td>
                  </tr>
                  <tr>
              <td class="side_menu" colspan="3">
                    <asp:CheckBox ID="ChkBoxAccept" runat="server" CausesValidation="True" Text="I Agree to the terms and conditions of Call us" />                        
                </td>
           </tr>
                  <tr>
                    <td height="30" colspan="3" align="center">
                   
                  <asp:ImageButton ID="ImgBtnSubmit" runat="server" AlternateText="SubmitButton" 
                      ImageUrl="images/button3.jpg" onclick="ImgBtnSubmit_Click" 
                      ValidationGroup="RegGroup" />
                        &nbsp;&nbsp;
                  <asp:ImageButton ID="ImgBtnReset" runat="server" AlternateText="ResetButton" 
                      ImageUrl="images/button4.jpg" onclick="ImgBtnReset_Click" />
           </td>
                    </tr>
                  <tr>
                    <td height="30" colspan="3" align="center" class="right_tab" style="padding-top:5px;"><font class="side_menu">
                        Dear Guest, kindly submit all the marked details. Its kind of</font><span class="mid_menu"><strong class="sub_menu"><font>mandatory</font></strong>. </span><span class="side_menu">
                        What to</span> <span class="side_menu">do! Its not our fault. We are here to 
                        provide the best of our services<strong>&nbsp;</strong></span><span class="mid_menu"><strong class="sub_menu"><font> 
                        24*7</font></strong></span></td>
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
     <img src="images/event/add2.png" alt="SponserdAds" width="175" height="600" /><br />
        <img src="images/event/search-job-2.png" width="175" height="300" alt="SponserdAds" /><br />
     </td>
    </tr>
    <tr>
      <td></td>
    </tr>
   
  </table>
</div>
<div class="contentbox_bottam"></div>
</div>
  <%--<div class="content_right" style="width:21%" >
    <table width="100%" border="0">
    <tr>
      <td width="100%" align="center" valign="top">
       <img src="images/event/add2.png" alt="SponserdAds" width="190" height="600" /><br />
        <img src="images/event/search-job-2.png" width="190" height="300" alt="SponserdAds" /><br /></td>
    </tr>
    <tr>
      <td></td>
    </tr>
   
  </table>
</div>--%>
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
