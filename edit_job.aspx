<%@ Page Language="C#" AutoEventWireup="true" CodeFile="edit_job.aspx.cs" Inherits="edit_job" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%@ Register Src="usercontrols/signin.ascx" TagName="signin" TagPrefix="aa1"  %>
<%--<%@ Register Src="usercontrols/topimage.ascx" TagName="topimage" TagPrefix="aa2" %>--%>
<%@ Register Src="usercontrols/Search.ascx" TagName="catageories" TagPrefix="aa6" %>
<%@ Register Src="usercontrols/footer1.ascx" TagName="footer1" TagPrefix="aa10" %>
<%@ Register Src="usercontrols/footer2.ascx" TagName="footer2" TagPrefix="aa11" %>
<%@ Register Assembly="MSCaptcha" Namespace="MSCaptcha" TagPrefix="cc1" %>
<%@ Register Src="usercontrols/BottomContent.ascx" TagName="bottomcontent" TagPrefix="aa4" %>
<%@ Register Src="usercontrols/BottomMidContent.ascx" TagName="bottomMidcontent" TagPrefix="aa5" %>
<%@ Register Src="usercontrols/jobsleft.ascx" TagName="leftjob" TagPrefix="lj" %>
<%@ Register Src="usercontrols/SponsoredLinks.ascx" TagName="splinks" TagPrefix="splnk" %>
<%@ Register Src="usercontrols/SearchNew.ascx" TagName="newsearch" TagPrefix="nsearch"%>
<%@ Register Src="usercontrols/small_logo.ascx" TagName="logosmall" TagPrefix="lgsmall" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">

<head id="Head1" runat="server">
<title>Justcalluz | Job opportunities in your city | we provide updated information on all your local search</title>
<meta name='description' content='Jobs opportunities,IT jobs,Management Jobs find the contact of Hot employers in your city' />
<meta name='keywords' content='Justcalluz, Real Estate Business,1BHK flat, yellow pages, online yellow pages, yellow pages india, India trade directory,  yellow pages directory, city yellow pages, indian search engine, JustCalluz customer care, JustCalluz customer support' />
<%--<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>Justcalluz :: Edit job</title>--%>
<link href="css/style.css"rel="stylesheet" type="text/css" />
<link href="css/inner_style.css" rel="Stylesheet" type="text/css" />

<style type="text/css">
.style10
{
height: 15px;
width: 372px;
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
<aa1:signin ID="SignIn1" runat="server" />
</div>
<div class="header">
<%--<div class="header_top"></div>
--%><div class="header_logo">
<lgsmall:logosmall ID="lglogo" runat="server" />
</div><div class="header_search">

<nsearch:newsearch ID="search" runat="server" />
</div>
</div>
<div class="category_box">
<aa6:catageories ID="dff" runat="server" />
</div>
<div class="content" style="padding:0; margin:0;">

<!-- start the inner left-->
<div class="content_innerleft">
<div class="contentbox_top">Jobs List</div>
<div class="contentbox_mid" style="padding-left:15px;"> 
<lj:leftjob ID="jl" runat="server" />
</div>
<div class="contentbox_bottam"></div>
</div>
<!-- end of the inner left-->

<!-- start the mid Box-->
  <div class="content_innermid">
  <div class="contentmid_boxtop">Home&gt;&gt;Edit The Job </div>
  <div class="contentmid_boxmid">
  <table width="100%" border="0">
 <tr>
    <td height="30" align="center" class="bottam" style="padding-right:5px;"><strong>Welcome to Justcalluz</strong></td>
</tr>
 <tr>
    <td valign="top"> <div class="events">
    <table width="100%" border="0" style="background-color:#D9EBFD;  border:dotted #666 1px">
              <tr>
                <td height="25" align="left" style="padding-left:10px;"><label style="color:#000" ><span class="sub_menu"><b>Edit The Job </b></span></label>
                  <span class="sub_menu"></span></td>
              </tr>
              <tr>
                <td width="100%"><hr/><hr/></td>
                </tr>
                  <tr>
                <td height="30" align="center" valign="top"><table width="100%" border="0">
                 <tr>
                    <td align="right" class="style10"> <span class="star">*</span><span class="list">Category</span></td>
                    <td width="4%" align="center"><strong>:</strong></td>
                    <td width="71%" height="30" align="left"><span class="row">
                      <asp:DropDownList ID="ddlcat" runat="server" Height="21px" 
          Width="203px" AutoPostBack="true" OnSelectedIndexChanged="ddlcat_selectedindexchanged"></asp:DropDownList>
      <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
          ErrorMessage="Please select Category" ControlToValidate="ddlcat" 
          InitialValue="select" ValidationGroup="postjob">*</asp:RequiredFieldValidator>
                     
                    </span></td>
                    </tr>
                     <tr>
                    <td align="right" class="style10"><span class="list">SubCategory</span></td>
                    <td width="4%" align="center"><strong>:</strong></td>
                    <td width="71%" height="30" align="left"><span class="row">
                    <asp:DropDownList ID="ddlsubcat" runat="server" 
          AutoPostBack="true" Height="21px" 
          Width="203px" ValidationGroup="postjob"></asp:DropDownList>
      <asp:RequiredFieldValidator ID="RequiredFieldValidator14" runat="server" ControlToValidate="ddlsubcat" 
          ErrorMessage="Please select SubCategory" ValidationGroup="postjob" 
          InitialValue="select">*</asp:RequiredFieldValidator>
                     
                    </span></td>
                    </tr>
                      <tr>
                    <td align="right" class="style10"> <span class="star">*</span><span class="list">State</span></td>
                    <td width="4%" align="center"><strong>:</strong></td>
                    <td width="71%" height="30" align="left"><span class="row">
                    <asp:DropDownList ID="ddlstate" runat="server" AutoPostBack="true" 
           Height="21px" 
          Width="203px" OnSelectedIndexChanged="ddlstate_selectedindexchanged"></asp:DropDownList>
      <asp:RequiredFieldValidator ID="reqstate" runat="server" 
          ErrorMessage="Please select state" ControlToValidate="ddlstate"  
          ValidationGroup="postjob" InitialValue="select">*</asp:RequiredFieldValidator>
                     
                    </span></td>
                    </tr>
                    <tr>
                    <td align="right" class="style10"> <span class="star">*</span><span class="list">city</span></td>
                    <td width="4%" align="center"><strong>:</strong></td>
                    <td width="71%" height="30" align="left"><span class="row">
                    <asp:DropDownList ID="ddlcity" runat="server" AutoPostBack="true" 
           Height="21px" 
          Width="203px"></asp:DropDownList>
      <asp:RequiredFieldValidator ID="reqcity" runat="server" 
          ErrorMessage="Please select city" ControlToValidate="ddlcity"  
          ValidationGroup="postjob" InitialValue="select">*</asp:RequiredFieldValidator>
                     
                    </span></td>
                    </tr>
                    
                    <tr>
                    <td align="right" class="style10"> <span class="star">*</span><span class="list">Area</span></td>
                    <td width="4%" align="center"><strong>:</strong></td>
                    <td width="71%" height="30" align="left"><span class="row">
                    <asp:TextBox ID="txtarea" runat="server" Height="20px" Width="203px"  onkeypress="return Alphabets(event);" ></asp:TextBox>
      <asp:RequiredFieldValidator ID="reqara" runat="server" 
          ErrorMessage="please enter area" ControlToValidate="txtarea"  
          ValidationGroup="postjob">*</asp:RequiredFieldValidator>
                     
                    </span></td>
                    </tr>
                    
                     <tr>
                    <td align="right" class="style10"> <span class="star">*</span><span class="list">Company Name</span></td>
                    <td width="4%" align="center"><strong>:</strong></td>
                    <td width="71%" height="30" align="left"><span class="row">
                   <asp:TextBox ID="txtcmp" runat="server" Height="20px" Width="203px"  onkeypress="return Alphabets(event);"> </asp:TextBox>
      <asp:RequiredFieldValidator ID="reqcmpnme" runat="server" 
          ErrorMessage="please enter company name" ControlToValidate="txtcmp"  ValidationGroup="postjob">*</asp:RequiredFieldValidator>
                     
                    </span></td>
                    </tr>
                    
                  <tr>
                    <td align="right" class="style10"><span class="star">*</span> <span class="list">Industry</span></td>
                    <td align="center"><strong>:</strong></td>
                    <td height="30" align="left"><span class="row">
                    <asp:DropDownList ID="ddlind" runat="server"  Height="21px" Width="203px"></asp:DropDownList>
           <asp:RequiredFieldValidator ID="reqind" runat="server" 
          ErrorMessage="enter type of industry" ControlToValidate="ddlind"  ValidationGroup="postjob">*</asp:RequiredFieldValidator></span></td>
                  </tr>
                    
                    <tr>
                    <td align="right" class="style10"><span class="star">*</span> <span class="list">Functional Area </span></td>
                    <td align="center"><strong>:</strong></td>
                    <td height="30" align="left"><span class="row">
                    <asp:DropDownList ID="ddlfunarea" runat="server" Height="21px" Width="203px"></asp:DropDownList>
           <asp:RequiredFieldValidator ID="reqrol" runat="server" 
          ErrorMessage="Enter role" ControlToValidate="ddlfunarea"  ValidationGroup="postjob">*</asp:RequiredFieldValidator></span></td>
                  </tr>   
                    <tr>
                    <td align="right" class="style10"><span class="list">Role</span></td>
                    <td width="4%" align="center"><strong>:</strong></td>
                    <td width="71%" height="30" align="left"><span class="row">
                 <asp:TextBox ID="txtrol" runat="server" Height="20px" Width="203px"></asp:TextBox>
      
                     
                    </span></td>
                    </tr>
                    
                    <tr>
                    <td align="right" class="style10"> <span class="star">*</span><span class="list">Qualification</span></td>
                    <td width="4%" align="center"><strong>:</strong></td>
                    <td width="71%" height="30" align="left"><span class="row">
                 <asp:TextBox ID="txtqul" runat="server" Height="20px" Width="203px"></asp:TextBox>
      <asp:RequiredFieldValidator ID="reqqulf" runat="server" 
          ErrorMessage="Please Enter Qualification" ControlToValidate="txtqul"  ValidationGroup="postjob">*</asp:RequiredFieldValidator>
                     
                    </span></td>
                    </tr>
                    
                    <tr>
                    <td align="right" class="style10"><span class="list">Age Limit</span></td>
                    <td width="4%" align="center"><strong>:</strong></td>
                    <td width="71%" height="30" align="left"><span class="row">
                 <asp:TextBox ID="txtage" runat="server" Height="20px" Width="203px" MaxLength="2" onkeypress="return onlyNos(event,this);" ></asp:TextBox>
                     
                    </span></td>
                    </tr>
                    
                    <tr>
                    <td align="right" class="style10"> <span class="star">*</span><span class="list">Experience</span></td>
                    <td width="4%" align="center"><strong>:</strong></td>
                    <td width="71%" height="30" align="left"><span class="row">
                 <asp:DropDownList ID="ddlexp" runat="server" AutoPostBack="true" 
           Height="21px" 
          Width="203px" OnSelectedIndexChanged="ddlexp_selectedindexchanged">
          <asp:ListItem>Fresher</asp:ListItem>
          <asp:ListItem>Experience</asp:ListItem>
          </asp:DropDownList>
      <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" InitialValue="select" ControlToValidate="ddlexp"  ValidationGroup="postjob" Text="*" ErrorMessage="Please select the Experience">*</asp:RequiredFieldValidator>
          
      <asp:TextBox ID="txtexp" runat="server" Visible="false" Height="20px" 
          Width="180px" ForeColor="GrayText"></asp:TextBox> 
      <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
          ErrorMessage="Should enter the years of experience" ControlToValidate="txtexp"  ValidationGroup="postjob">*</asp:RequiredFieldValidator>
   <cc1:TextBoxWatermarkExtender ID="TextBoxWatermarkExtender1" 
          runat="server" TargetControlID="txtexp" 
          WatermarkText="Enter required experience here"></cc1:TextBoxWatermarkExtender>
    
                     
                    </span></td>
                    </tr>
                
                    <tr>
                    <td align="right" class="style10"> <span class="star">*</span><span class="list">Salary</span></td>
                    <td width="4%" align="center"><strong>:</strong></td>
                    <td width="71%" height="30" align="left"><span class="row">
                 <asp:TextBox ID="txtsal" runat="server" Height="20px" Width="203px"></asp:TextBox>
      <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" 
          ErrorMessage="Please enter the salary" ControlToValidate="txtsal"  ValidationGroup="postjob">*</asp:RequiredFieldValidator>
                     
                    </span></td>
                    </tr>
                    
                     <tr>
                    <td align="right" class="style10"> <span class="star">*</span><span class="list">Job Description</span></td>
                    <td width="4%" align="center"><strong>:</strong></td>
                    <td width="71%" height="60" align="left"><span class="row">
                <asp:TextBox ID="txtdesc" runat="server" Height="50px" Width="203px" TextMode="MultiLine"></asp:TextBox>
      <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" 
          ControlToValidate="txtdesc" ErrorMessage="Enter job description" ValidationGroup="postjob">*</asp:RequiredFieldValidator>
                     
                    </span></td>
                    </tr>
                    
                    <tr>
                    <td align="right" class="style10"> <span class="star">*</span><span class="list">Key Skills</span></td>
                    <td width="4%" align="center"><strong>:</strong></td>
                    <td width="71%" height="30" align="left"><span class="row">
               <asp:TextBox ID="txtkey" runat="server" Height="20px" Width="203px"></asp:TextBox>
      <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" 
          ErrorMessage="Enter the required key skills " ControlToValidate="txtkey"  ValidationGroup="postjob">*</asp:RequiredFieldValidator>
                     
                    </span></td>
                    </tr>
                    
                    <tr>
                    <td align="right" class="style10"> <span class="star">*</span><span class="list">Company Profile</span></td>
                    <td width="4%" align="center"><strong>:</strong></td>
                    <td width="71%" height="60" align="left"><span class="row">
              <asp:TextBox ID="txtprf" runat="server" Height="50px" Width="203px" TextMode="MultiLine"></asp:TextBox>
      <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" 
          ErrorMessage="Please give company profile" ControlToValidate="txtprf"  ValidationGroup="postjob">*</asp:RequiredFieldValidator>
                    </span></td>
                    </tr>
                    
                    <tr>
                    <td align="right" class="style10"> <span class="star">*</span><span class="list">Job Expiry Date</span></td>
                    <td width="4%" align="center"><strong>:</strong></td>
                    <td width="71%" height="30" align="left"><span class="row">
              <asp:TextBox ID="txtexpiry" runat="server" Height="20px" Width="203px"></asp:TextBox>
   <asp:RangeValidator ID="rngdate" runat="server" 
                  ControlToValidate="txtexpiry" 
                  ValidationGroup="postjob" Type="Date">*</asp:RangeValidator>
      <asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" 
          ErrorMessage="Enter the date of expiry" ControlToValidate="txtexpiry"  ValidationGroup="postjob">*</asp:RequiredFieldValidator>
                      <cc1:CalendarExtender ID="expirydate" runat="server" 
              TargetControlID="txtexpiry"></cc1:CalendarExtender> 
                      
                      </span></td>
                    </tr>
                    
                    <tr>
                    <td align="right" class="style10"> <span class="star">*</span><span class="list">Address</span></td>
                    <td width="4%" align="center"><strong>:</strong></td>
                    <td width="71%" height="60" align="left"><span class="row">
             <asp:TextBox ID="txtadd" runat="server" Height="50px" Width="203px" TextMode="MultiLine"></asp:TextBox>
      <asp:RequiredFieldValidator ID="RequiredFieldValidator13" runat="server" 
          ErrorMessage="Enter the address" ControlToValidate="txtadd"  ValidationGroup="postjob">*</asp:RequiredFieldValidator></span></td>
                    </tr>
                    
                     <tr>
                    <td align="right" class="style10"><span class="list">LandMark</span></td>
                    <td width="4%" align="center"><strong>:</strong></td>
                    <td width="71%" height="30" align="left"><span class="row">
             <asp:TextBox ID="txtlndm" runat="server" Height="20px" Width="203px"></asp:TextBox>
             </span></td>
                    </tr>
                    
                       <tr>
                    <td align="right" class="style10"> <span class="star">*</span><span class="list">Pincode</span></td>
                    <td width="4%" align="center"><strong>:</strong></td>
                    <td width="71%" height="30" align="left"><span class="row">
            <asp:TextBox ID="txtpin" runat="server" Height="20px" Width="203px" onkeypress="return onlyNos(event,this);" MaxLength="6"></asp:TextBox>
   <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
          ErrorMessage="Enter the pincode" ControlToValidate="txtpin"  ValidationGroup="postjob">*</asp:RequiredFieldValidator>
          <asp:RegularExpressionValidator ID="repin" runat="server" ValidationGroup="postjob" ControlToValidate="txtpin" 
          ValidationExpression="^[01]?[- .]?(\([1-9]\d{1}\)|[1-9]\d{1})[- .]?\d{2}[- .]?\d{2}$" 
          ErrorMessage="Enter pincode number only 6 digits(starting number should starts from 1 to 9 digits)" Display="Dynamic"></asp:RegularExpressionValidator>
             </span></td>
                    </tr>
                    
                     <tr>
                    <td align="right" class="style10"> <span class="star">*</span><span class="list">Contact Person</span></td>
                    <td width="4%" align="center"><strong>:</strong></td>
                    <td width="71%" height="30" align="left"><span class="row">
           <asp:TextBox ID="txtcntp" runat="server" Height="20px" Width="203px"  onkeypress="return Alphabets(event);"></asp:TextBox>
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
       <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
          ErrorMessage="Please enter name of the contact person" ControlToValidate="txtcntp"  ValidationGroup="postjob">*</asp:RequiredFieldValidator>
  
             </span></td>
                    </tr>
                    
                      <tr>
                    <td align="right" class="style10"> <span class="star">*</span><span class="list">Email</span></td>
                    <td width="4%" align="center"><strong>:</strong></td>
                    <td width="71%" height="30" align="left"><span class="row">
           <asp:TextBox ID="txtemail" runat="server" Height="20px" Width="203px"></asp:TextBox>
     
      <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
          ErrorMessage="Please enter emailid" ControlToValidate="txtemail"  ValidationGroup="postjob">*</asp:RequiredFieldValidator>
           <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
          ErrorMessage="Incorrect Format of email address" 
          ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
          ValidationGroup="postjob" ControlToValidate="txtemail" >*</asp:RegularExpressionValidator>
             </span></td>
                    </tr>
                    
                      <tr>
                    <td align="right" class="style10"><span class="list">Phone</span></td>
                    <td width="4%" align="center"><strong>:</strong></td>
                    <td width="71%" height="30" align="left"><span class="row">
          <asp:TextBox ID="txtph" runat="server" Height="20px" Width="203px" onkeypress="return onlyNos(event,this);" MaxLength="11"></asp:TextBox>
   <asp:RegularExpressionValidator ID="RegularExpressionValidator6" runat="server" 
          ControlToValidate="txtph" ErrorMessage="Enter Phone number only ten digits(starting number should starts from 1 to 9 digits)" 
          ValidationExpression="^[01]?[- .]?(\([1-9]\d{2}\)|[1-9]\d{2})[- .]?\d{3}[- .]?\d{4}$" Display="Dynamic" ValidationGroup="postjob"></asp:RegularExpressionValidator>
          <asp:RangeValidator ID="RangeValidator2" runat="server" 
          ErrorMessage="Phone Number must start with 0" ControlToValidate="txtph"  MaximumValue="1" MinimumValue="0" 
          ValidationGroup="postjob">*</asp:RangeValidator>
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
  
             </span></td>
                    </tr>
                    
                     <tr>
                    <td align="right" class="style10"> <span class="star">*</span><span class="list">Mobile</span></td>
                    <td width="4%" align="center"><strong>:</strong></td>
                    <td width="71%" height="30" align="left"><span class="row">
                     <asp:TextBox ID="txtcode" runat="server" ReadOnly="true" Text="+91" Width="30px"></asp:TextBox>-
          <asp:TextBox ID="txtmob" runat="server" Height="20px" Width="203px" onkeypress="return onlyNos(event,this);" MaxLength="10"></asp:TextBox>
  <b class="side_menu">(E.g:- 9000465921)</b>
      <%--<asp:RangeValidator ID="RangeValidator1" runat="server" 
          ErrorMessage="Mobile Number must start with 0" ControlToValidate="txtmob"  MaximumValue="1" MinimumValue="0" 
          ValidationGroup="postjob">*</asp:RangeValidator>--%>
          <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" 
          ControlToValidate="txtmob" ErrorMessage="Enter mobile number only ten digits(starting number should starts from 1 to 9 digits)" 
          ValidationExpression="^[01]?[- .]?(\([1-9]\d{2}\)|[1-9]\d{2})[- .]?\d{3}[- .]?\d{4}$" Display="Dynamic" ValidationGroup="postjob"></asp:RegularExpressionValidator>
      <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Please enter your mobile number" ControlToValidate="txtmob" ValidationGroup="postjob">*</asp:RequiredFieldValidator>
             </span></td>
                    </tr>
                    
                     <tr>
                    <td align="right" class="style10"><span class="list">fax</span></td>
                    <td width="4%" align="center"><strong>:</strong></td>
                    <td width="71%" height="30" align="left"><span class="row">
          <asp:TextBox ID="txtfax" runat="server" Height="20px" Width="203px" onkeypress="return onlyNos(event,this);" MaxLength="11"></asp:TextBox>
   <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" 
          ErrorMessage="Accepts only digits for fax" ControlToValidate="txtfax" 
          ValidationExpression="\d{11}" ValidationGroup="postjob">*</asp:RegularExpressionValidator>
             </span></td>
                    </tr>
                    
                      <tr>
                    <td align="right" class="style10"><span class="list">website</span></td>
                    <td width="4%" align="center"><strong>:</strong></td>
                    <td width="71%" height="30" align="left"><span class="row">
         <asp:TextBox ID="txtweb" runat="server" Height="20px" Width="203px"></asp:TextBox>
  <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
          ControlToValidate="txtweb" ErrorMessage="Invalid format of website" 
          ValidationGroup="postjob" 
          ValidationExpression="http(s)?://([\w-]+\.)+[\w-]+(/[\w- ./?%&amp;=]*)?">*</asp:RegularExpressionValidator>
      <br />
  <b class="side_menu">(E.g:- http(s)://www.Justcalluz.com )</b>
      <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
          ValidationGroup="postjob" ShowMessageBox="True" ShowSummary="False" />
          
             </span></td>
                    </tr>
                    <tr>
                                <td style="font-family:Arial" colspan="2">
                                    To upload Logo :
                                </td>
                               
                                <td>
                                    <asp:FileUpload ID="uploadLogo" runat="server" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                    <asp:Button ID="btnlogo" runat="server" Text="UploadLogo" OnClick="btnlogo_Click" />
                                    
                                </td>
                               
                            </tr>
                            <tr><td>
                             <asp:Image  ID="imgReviewer"  runat="server" Width="30"  Height="30" AlternateText="imgReviewer"/>
                            </td></tr>
                           
                            <tr>
                            <td colspan="4"></td>
                            </tr>
                    
                     <tr>
                    <td align="right" class="style10"> <span class="star">*</span><span class="list">
 <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
      <ContentTemplate> 
        
        <cc1:CaptchaControl ID="ccjoin" runat="server" BackColor="AntiqueWhite" 
        CaptchaBackgroundNoise="None" CaptchaHeight="35" CaptchaLength="4" 
        CaptchaWidth="90" CaptchaLineNoise="None" CaptchaMinTimeout="5" 
        CaptchaMaxTimeout="200" Width="90px" />
       </ContentTemplate>
       </asp:UpdatePanel></span></td>
                    <td width="4%" align="center"><strong>:</strong></td>
                    <td width="71%" height="30" align="left"><span class="row">
         <asp:TextBox ID="txtvid" runat="server" Width="260px"></asp:TextBox>
             </span></td>
                    </tr>
                    </table></td></tr>
                    <tr><td colspan="3" align="center">
                    <asp:ImageButton ID="updatebtn" runat="server" ImageUrl="images/update.png" 
          ValidationGroup="postjob" onclick="updatebtn_Click" AlternateText="imgUpdate" />&nbsp;&nbsp;&nbsp;
          <asp:ImageButton ID="cancelbtn" runat="server" ImageUrl="images/cancel-button.png" 
              onclick="cancelbtn_Click" AlternateText="imgCancel"/>
                    </td></tr>
                    </table>
 
 </div></td></tr></table>
 </div>
 <div class="contentmid_boxbottam"></div>
</div>
<div class="content_innerright">
<!-- end of the mid Box-->  
<div class="contentbox_top">Sponsor Ads</div>
<div class="contentbox_mid">
<table width="100%" border="0">
      <tr>
         <td class="right_tab">
<splnk:splinks ID="sponseredlinks" runat="server" />
     </td>
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
<div class="footer" align="center"> 
<aa10:footer1 ID="sdsa" runat="server" />
    <aa11:footer2 ID="poshv" runat="server" />
</div>

</div>
</form>
</body>
</html>
