<%@ Page Language="C#" AutoEventWireup="true" CodeFile="careers_resumeform.aspx.cs" Inherits="careers_resumeform" %>
<%@ Register Src="usercontrols/signin.ascx" TagName="signin" TagPrefix="aa1" %>
<%@ Register Src="usercontrols/catageories.ascx" TagName="catag" TagPrefix="aa6" %>
<%@ Register Src="usercontrols/footer1.ascx" TagName="footer1" TagPrefix="aa10" %>
<%@ Register Src="usercontrols/footer2.ascx" TagName="footer2" TagPrefix="aa11" %>
<%@ Register Src="usercontrols/SearchNew.ascx" TagName="SearchNew" TagPrefix="New" %>
<%@ Register Src="usercontrols/BottomContent.ascx" TagName="bottomcontent" TagPrefix="aa4" %>
<%@ Register Src="usercontrols/BottomMidContent.ascx" TagName="bottomMidcontent" TagPrefix="aa5" %>
<%@ Register Src="usercontrols/Testimonials_Left.ascx" TagName="TestLeft" TagPrefix="aa15" %>
<%@ Register Src="usercontrols/small_logo.ascx" TagName="logo" TagPrefix="S_logo" %>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
 <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
  <title>:: Justcalluz :: careers ResumeForm page</title>
 <link href="css/style.css" rel="Stylesheet" type="text/css" />
  <link href="css/inner_style.css" rel="Stylesheet" type="text/css" />
 <script src="Scripts/swfobject_modified.js" type="text/javascript">
 </script>
    <style type="text/css">
        .style1
        {
            height: 30px;
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

    <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePageMethods="true">
    </asp:ScriptManager>
  <div>
   <div class="layout">
<div class="signin">
 <aa1:signin ID="sign" runat="server" />
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
  <div class="content_innerleft">
  <aa15:TestLeft ID="content" runat="server" />
  </div>
 <div class="content_innermid" style="width:79%;">
   <table width="100%" border="0">
    <tr>
     <td style="background:url(images/Testimonials.png) no-repeat" height="36">
    <table width="100%" border="0" >
    <tr>
     <td width="49%" class="bottam" style="padding-left:12px;"><font color="#FFFFFF" class="location">Careers at Justcalluz</font></td>
     <td width="5%"><asp:Image AlternateText="SampleImage" ID="imgpencial" ImageUrl="images/pencial.png" width="20" height="20" runat="server"/></td>
     <td width="46%"><font color="#FFFFFF"> Listing  Your job in Careers at Justcalluz</font></td>
   </tr>
  </table>
  </td>
  </tr>
  <tr>
    <td>
    <span class="location" style="padding-left:10px;">
    <font color="#00468C">Resume Form/File Upload </font>
    </span>
    </td>
  </tr>
  <tr>
    <td><hr/></td>
   </tr>
   <tr>
     <td style="padding:5px;">
     <table width="101%" border="0"  style="background-color:#E1F5FF; border:dotted 1px #999" >
         
   <tr>
     <td  class="side_menu"  style="padding-left:10px;" height="30">
     <span class="headings" >
     <font color="#CC0000">Denotes mandatory fields (Personal Information)</font>
     </span>
     </td>
     <td>&nbsp;</td>
    </tr>
    <tr>
      <td><hr/></td>
      <td><hr/></td>
    </tr>
    <tr>
     <td style="padding:8px;" valign="top">
       <table width="100%" border="0">
      <%--  <tr>
        <td>
        <asp:Label ID="lblMessage" runat="server" ></asp:Label>
        </td>
        </tr>--%>
     <tr>
     <td width="25%" align="right"> 
     <span class="list">Application Title</span>
     </td>
      <td width="4%" align="center"><strong>:</strong></td>
      <td width="71%" height="30" align="left">
        <asp:TextBox ID="txtTitle" runat="server" 
          Width="240px" style="margin-left: 9px" onkeypress="return Alphabets(event);">
        </asp:TextBox>
         &nbsp;&nbsp;&nbsp;&nbsp;<asp:RequiredFieldValidator ID="rf1" runat="server" 
              ErrorMessage="please enter title" ControlToValidate="txtTitle" 
              ValidationGroup="careers_resumeform">*</asp:RequiredFieldValidator>
              </td>
      </tr>
      <tr>
        <td align="right"><span class="star">*</span> <span class="list">First Name </span></td>
        <td align="center"><strong>:</strong></td>
        <td height="30" align="left">
         <asp:TextBox ID="txtFName" runat="server" 
              Width="240px" style="margin-left: 9px" onkeypress="return Alphabets(event);"></asp:TextBox>
          &nbsp;&nbsp;&nbsp;&nbsp;
          <asp:RequiredFieldValidator ID="rf2" runat="server" 
                  ErrorMessage="please enter firstname" ControlToValidate="txtFName" 
                  ValidationGroup="careers_resumeform">*</asp:RequiredFieldValidator>
                  </td>
       </tr>
       <tr>
         <td align="right"><span class="star">*</span><span class="list">Last Name</span></td>
         <td align="center"><strong>:</strong></td>
         <td height="30" align="left">
           <asp:TextBox ID="txtLName" runat="server" 
                 Width="240px" style="margin-left: 9px" onkeypress="return Alphabets(event);"></asp:TextBox>
             &nbsp;&nbsp;&nbsp;&nbsp;
             <asp:RequiredFieldValidator ID="rf3" runat="server" 
                ErrorMessage="please enter lastname" ControlToValidate="txtLName" 
                ValidationGroup="careers_resumeform">*</asp:RequiredFieldValidator> 
         </td>
        </tr>
        <tr>
            <td align="right"><span class="star">*</span> <span class="list">Email Address</span></td>
            <td align="center"><strong>:</strong></td>
            <td height="30" align="left">
             <asp:TextBox ID="txtEmailAddress" 
                  runat="server" Width="240px" style="margin-left: 9px"></asp:TextBox>
             <asp:RequiredFieldValidator ID="rf4" runat="server" ErrorMessage="please enter email address" 
                ControlToValidate="txtEmailAddress" ValidationGroup="careers_resumeform">*</asp:RequiredFieldValidator>
             <asp:RegularExpressionValidator ID="revEmailAddress" runat="server" 
                  ErrorMessage="Please enter valid email address" ControlToValidate="txtEmailAddress" 
                  ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
                  ValidationGroup="careers_resumeform">*</asp:RegularExpressionValidator></td>
         </tr>
         <tr>
            <td align="right"><span class="list">Home Phone</span></td>
            <td align="center"><strong>:</strong></td>
            <td height="30" align="left">
             <asp:TextBox ID="txtHPhone" runat="server" 
                   Width="240px" MaxLength="11" style="margin-left: 9px" onkeypress="return onlyNos(event,this);"></asp:TextBox><b style="color:#093; 
                   font-size:11px;">(E.g:-02228884060 )</b> 
             <asp:RegularExpressionValidator ID="revHPhone" runat="server" 
                 ErrorMessage="Enter mobile number only ten digits(starting number should starts from 1 to 9 digits)" 
                 ControlToValidate="txtHPhone" ValidationExpression="^[01]?[- .]?(\([1-9]\d{2}\)|[1-9]\d{2})[- .]?\d{3}[- .]?\d{4}$" Display="Dynamic" 
                 ValidationGroup="careers_resumeform"></asp:RegularExpressionValidator>
            <asp:RangeValidator ID="rvHPhone" runat="server" MaximumValue="1" MinimumValue="0" 
                    ErrorMessage="Home number should start with zero" ControlToValidate="txtHPhone" 
                    ValidationGroup="txtHPhone">*</asp:RangeValidator></td>
          </tr>
          <tr>
            <td align="right"><span class="star">*</span> <span class="list">Cell</span></td>
            <td align="center"><strong>:</strong></td>
            <td height="30" align="left">
            <asp:TextBox ID="txtCellNo" runat="server" 
               Width="240px" MaxLength="10" style="margin-left: 9px" onkeypress="return onlyNos(event,this);"></asp:TextBox>
               <b style="color:#093;font-size:11px;">(E.g:- 10 digit mobile number )</b> 
             <asp:RequiredFieldValidator ID="rf6" runat="server" 
                ErrorMessage="please enter Cell Number" ControlToValidate="txtCellNo" 
                ValidationGroup="careers_resumeform">*</asp:RequiredFieldValidator>
             <asp:RegularExpressionValidator ID="revCellNo" runat="server" 
                 ErrorMessage="Enter cell number only ten digits(starting number should starts from 1 to 9 digits)" 
                 ControlToValidate="txtCellNo" ValidationExpression="^[01]?[- .]?(\([1-9]\d{2}\)|[1-9]\d{2})[- .]?\d{3}[- .]?\d{4}$" Display="Dynamic" 
                 ValidationGroup="careers_resumeform"></asp:RegularExpressionValidator>
             </td>
           </tr>
           <tr>
            <td align="right">&nbsp;</td>
            <td align="center">&nbsp;</td>
            <td height="10" align="left" class="side_menu">Basic Information </td>
         </tr>
      </table>
      </td>
      </tr>
      <tr>
        <td><hr/></td>      
      </tr>
      <tr>
       <td style="padding:8px;">
       <table width="100%" border="0">
      <tr>
        <td width="25%" align="right"><span class="list">Category</span></td>
        <td width="4%" align="center"><strong>:</strong></td>
        <td width="71%" height="30" align="left">
        <asp:TextBox ID="txtCategory" runat="server" 
                 Width="240px" style="margin-left: 9px" ></asp:TextBox> &nbsp;&nbsp;
              <asp:RequiredFieldValidator ID="rfvcategory" runat="server" 
            ErrorMessage="please enter category" ControlToValidate="txtCategory" 
            ValidationGroup="careers_resumeform">*</asp:RequiredFieldValidator>
             &nbsp;&nbsp;
        </td>
      </tr>
      <tr>
        <td align="right"><span class="list">Specialization</span></td>
        <td align="center"><strong>:</strong></td>
        <td height="30" align="left">
        <asp:TextBox ID="txtSpecialization" runat="server" 
                 Width="240px" style="margin-left: 9px" >
        </asp:TextBox> &nbsp;&nbsp;
          <asp:RequiredFieldValidator ID="rfvSpecialization" runat="server" 
            ErrorMessage="please enter Specialization" ControlToValidate="txtSpecialization" 
            ValidationGroup="careers_resumeform">*</asp:RequiredFieldValidator>
             &nbsp;&nbsp;
        </td>
       </tr>
       
       <tr>
        <td align="right"><span class="list"> Work Experience</span></td>
        <td align="center"><strong>:</strong></td>
        <td height="30" align="left"><table width="100%" border="0">
       <tr>
         <td width="17%" height="28%">
          <asp:DropDownList ID="ddlyears" runat="server" Height="20px"
                Width="97px" style="margin-left: 7px;">
                        <asp:ListItem Value="select">-select-</asp:ListItem>
                        <asp:ListItem Value="0">0</asp:ListItem>
                        <asp:ListItem Value="1">1</asp:ListItem>
                        <asp:ListItem Value="2">2</asp:ListItem>
                        <asp:ListItem Value="3">3</asp:ListItem>
                        <asp:ListItem Value="4">4</asp:ListItem>
                        <asp:ListItem Value="5">5</asp:ListItem>
                        <asp:ListItem Value="6">6</asp:ListItem>
                        <asp:ListItem Value="7">7</asp:ListItem>
                        <asp:ListItem Value="8">8</asp:ListItem>
                        <asp:ListItem Value="9">9</asp:ListItem>
                        <asp:ListItem Value="10">10</asp:ListItem>
                        <asp:ListItem Value="11">11</asp:ListItem>
                        <asp:ListItem Value="12">12</asp:ListItem>
                        <asp:ListItem Value="13">13</asp:ListItem>
                        <asp:ListItem Value="14">14</asp:ListItem>
                        <asp:ListItem Value="15">15</asp:ListItem>
                        <asp:ListItem Value="16">16</asp:ListItem>
                        <asp:ListItem Value="17">17</asp:ListItem>
                        <asp:ListItem Value="18">18</asp:ListItem>
                        <asp:ListItem Value="19">19</asp:ListItem>
                        <asp:ListItem Value="20">20</asp:ListItem>
                
          </asp:DropDownList><br/></td>
                  
          <td width="4%" class="select_menu">Years</td>
          <td width="17%" height="28%" valign="middle">
         <asp:DropDownList ID="ddlmonths" runat="server" Height="20px"
              Width="97px" style="margin-left: 7px;">
                        <asp:ListItem Value="select">-select-</asp:ListItem>
                        <asp:ListItem Value="0">0</asp:ListItem>
                        <asp:ListItem Value="1">1</asp:ListItem>
                        <asp:ListItem Value="2">2</asp:ListItem>
                        <asp:ListItem Value="3">3</asp:ListItem>
                        <asp:ListItem Value="4">4</asp:ListItem>
                        <asp:ListItem Value="5">5</asp:ListItem>
                        <asp:ListItem Value="6">6</asp:ListItem>
                        <asp:ListItem Value="7">7</asp:ListItem>
                        <asp:ListItem Value="8">8</asp:ListItem>
                        <asp:ListItem Value="9">9</asp:ListItem>
                        <asp:ListItem Value="10">10</asp:ListItem>
                        <asp:ListItem Value="11">11</asp:ListItem>
                        <asp:ListItem Value="12">12</asp:ListItem>
          </asp:DropDownList></td>&nbsp;<td width="5%" class="select_menu">Months</td>
         <td width="48%">&nbsp;</td>
     </tr>
   </table>
   </td>
   </tr>
   <tr>
        <td align="right"><span class="star">*</span><span class="list"> Current CTC</span></td>
        <td align="center"><strong>:</strong></td>
        <td height="30" align="left">
        <asp:DropDownList ID="ddlCTC" runat="server" Width="243px" style="margin-left: 9px">
        </asp:DropDownList> 
            &nbsp;&nbsp;<asp:Label ID="lblperannum" runat="server" Text="per annum"></asp:Label> 
         <asp:RequiredFieldValidator ID="CTC" runat="server" 
             ErrorMessage="please select CTC" ControlToValidate="ddlCTC" 
             ValidationGroup="careers_resumeform" InitialValue="select">*</asp:RequiredFieldValidator>
                 &nbsp;&nbsp;</td>
        </tr>
        <tr>
            <td align="right"><span class="star">*</span><span class="list"> Expected CTC</span></td>
            <td align="center"><strong>:</strong></td>
            <td height="30" align="left">
             <asp:DropDownList ID="ddlECTC" runat="server" 
                        Width="243px" 
                        style="margin-left: 9px">
                              
             </asp:DropDownList> 
               &nbsp;&nbsp;<asp:Label ID="lblannum" runat="server" Text="per annum"></asp:Label> 
           <asp:RequiredFieldValidator ID="rf8" runat="server" 
                  ErrorMessage="please select CTC" ControlToValidate="ddlECTC" 
                  ValidationGroup="careers_resumeform" InitialValue="select">*</asp:RequiredFieldValidator>
                 &nbsp;&nbsp; </td>
          </tr>
          <tr>
           <td align="right"><span class="list"> Job Type</span>
           </td>
           <td align="center"><strong>:</strong>
           </td>
           <td height="30" align="left">
              <asp:DropDownList runat="server" ID="ddlJobtype" Width="243px" Height="20px" style="margin-left:9px">
              </asp:DropDownList>&nbsp;&nbsp;&nbsp;&nbsp;
              <asp:RequiredFieldValidator ID="rf9" runat="server" ErrorMessage="please select jobtype" 
                 ControlToValidate="ddlJobtype" ValidationGroup="careers_resumeform">*</asp:RequiredFieldValidator>
              </td>
          </tr>
          <tr>
            <td align="right"><span class="list"> Basic Education</span></td>
            <td align="center"><strong>:</strong></td>
            <td height="30" align="left">
            <asp:DropDownList ID="ddlEducation" runat="server" 
                     Width="243px" 
                         style="margin-left: 9px">
                              
           </asp:DropDownList> 
                 &nbsp;&nbsp;&nbsp;&nbsp;<asp:RequiredFieldValidator ID="rfvEducation" runat="server" 
                  ErrorMessage="please select basic education" ControlToValidate="ddlEducation" 
                 ValidationGroup="careers_resumeform">*</asp:RequiredFieldValidator>
                 </td>
        </tr>
        <tr>
            <td align="right">&nbsp;</td>
            <td align="center">&nbsp;</td>
            <td height="20" align="left" class="side_menu">Resume </td>
              </tr>
          
        <tr>
            <td align="right" valign="top" class="style1"><span class="star">*</span> <span class="list">Upload Your CV</span></td>
            <td align="center" valign="top" class="style1"><strong>:</strong></td>
            <td align="left" class="style1">
            <asp:FileUpload ID="UploadCv" 
              runat="server"  Width="243px" style="margin-left: 9px"/>
              &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RequiredFieldValidator ID="rfvCV" runat="server" 
                      ErrorMessage="please upload your CV" ControlToValidate="UploadCv" 
                      ValidationGroup="careers_resumeform">* <br />
                      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Allowed files: ".doc", ".txt"</asp:RequiredFieldValidator>
            </td>
        </tr>
        </table>
        </td>              
      </tr>
      <tr>
        <td align="center">
        <asp:ImageButton ID="imgSave" AlternateText="save" ImageUrl="images/career-save.png" runat="server" 
           OnClick="imgSave_click" ValidationGroup="careers_resumeform" Width="70px" /></td>     
        </tr>
        <tr>
           <td align="center">
           <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
               ShowMessageBox="True" ShowSummary="False" ValidationGroup="careers_resumeform" />
           </td>
        </tr>
        <tr>
           <td></td>
        </tr>
    </table>
    </td>
    </tr>
    </table>
  </div>
  
<%--</div>--%>
<div class="content_midbootam" >
<aa5:bottomMidcontent ID="mid1" runat="server" />
</div>
<div class="content_bootam_center">
<aa4:bottomcontent ID="bottomcontent1" runat="server" />
</div>
<div class="footer" align="center" style="padding-top:5px; " >
  <aa10:footer1 ID="footer1" runat="server" />
  <aa11:footer2 ID="footer2" runat="server" />  
   
</div>
<%--</div>--%>
<script type="text/javascript">
<!--
swfobject.registerObject("FlashID");
//-->
</script>
    </div>
      </div>
  </div>
   </form>
</body>
</html>
