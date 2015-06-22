<%@ Page Language="C#" AutoEventWireup="true" CodeFile="jobdetails.aspx.cs" Inherits="jobdetails" EnableEventValidation="false" %>
<%@ Register Src="usercontrols/signin.ascx" TagName="signin" TagPrefix="aa1" %>
<%@ Register Src="usercontrols/topimage.ascx" TagName="topimage" TagPrefix="aa2" %>
<%@ Register Src="usercontrols/catageories.ascx" TagName="catageories" TagPrefix="aa6" %>
<%@ Register Src="usercontrols/footer1.ascx" TagName="footer1" TagPrefix="aa10" %>
<%@ Register Src="usercontrols/footer2.ascx" TagName="footer2" TagPrefix="aa11" %>
<%@ Register Src="usercontrols/jobsleft.ascx" TagName="leftjob" TagPrefix="lj" %>
<%@ Register Src="usercontrols/SponsoredLinks.ascx" TagName="Splinks" TagPrefix="splnk" %>
<%@ Register Src="usercontrols/SearchNew.ascx" TagName="newsearch" TagPrefix="nsearch"%>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="AjaxToolkit" %>
<%@ Register Src="usercontrols/BottomContent.ascx" TagName="bottomcontent" TagPrefix="aa4" %>
<%@ Register Src="usercontrols/BottomMidContent.ascx" TagName="bottomMidcontent" TagPrefix="aa5" %>
<%@ Register Src="usercontrols/small_logo.ascx" TagName="logosmall" TagPrefix="lgsmall" %>
<%@ Register Src="usercontrols/rightsearch.ascx" TagName="rightsrch" TagPrefix="rsearch" %>
<%@ Import Namespace="System.Web.Routing" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<%--<title>Justcalluz/Job details</title>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />--%>
<title>Justcalluz | Job opportunities in your city | we provide updated information on all your local search</title>
<meta name='description' content='Jobs opportunities,IT jobs,Management Jobs find the contact of Hot employers in your city' />
<meta name='keywords' content='Justcalluz, Real Estate Business,1BHK flat, yellow pages, online yellow pages, yellow pages india, India trade directory,  yellow pages directory, city yellow pages, indian search engine, JustCalluz customer care, JustCalluz customer support' />
<link href="css/style.css" rel="stylesheet" type="text/css" />
<link href="css/inner_style.css" rel="Stylesheet" type="text/css" />
<script type="text/javascript" src="js/jquery-1.2.6.min.js"></script>
<script type="text/javascript" src="js/jquery.rater.js"></script>

<script type="text/javascript">
$(function() {
$('#testRater');
});
</script>
<script type="text/javascript">function postbackFromJS(sender, e) 
{
var postBack = new Sys.Preview.PostBackAction();
postBack.set_target(sender);
postBack.set_eventArgument(e);
postBack.performAction();
}      
 </script>

</head>
<body>
<form id="f1" runat="server" >
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
<asp:ScriptManager ID="ScriptManager1" runat="server">
</asp:ScriptManager>
<!--begin of table-->

<div class="layout">
    <div class="signin">
<aa1:signin ID="SignIn1" runat="server" />
</div>
<div class="header">
<%--<div class="header_top"></div>
--%><div class="header_logo">
<lgsmall:logosmall ID="lglogo" runat="server" />
</div>
<div class="header_search">

<nsearch:newsearch ID="search" runat="server" />
</div>
</div>
<div class="category_box">
<aa6:catageories ID="dff" runat="server" />
</div>

<div class="content" style="padding:0; margin:0;">

<!-- start the inner left-->
<div class="content_innerleft">
<div>
<div class="contentbox_top">Refined Search By</div>
<div class="contentbox_mid" style="padding-left:15px;"> 
<%--<table width="100%" border="0">
  <tr>
   <td class="side_menu">--%>
 
<lj:leftjob ID="jl" runat="server" />

<!--end of top row-->
<!--end of 1 column-->
<%--</td></tr></table>--%>
</div>
<div class="contentbox_bottam"></div>
</div>
</div>
<!-- ending the left -->
  <div class="content_innermid">
  <div class="contentmid_boxtop"><a href="<%$RouteUrl:RouteName=HomeRoute%>" style="text-decoration:none;color:White" runat="server">Home&gt;&gt;</a><a href="<%$RouteUrl:RouteName=jobs,cname=jobs%>" style="color:#FFF; text-decoration:none;" runat="server">Jobs</a>&gt;&gt;Job 
    Details</div>
  <div class="contentmid_boxmid">
  <table width="100%" border="0">
          <tr>
    <td valign="top">
    <div class="job_midle">
    <div class="job_midlemid">
  <table width="100%" border="0">
  <tr>
    <td height="30" colspan="2" align="right" class="headings" style="padding-right:5px;">Description for</td>
    <td width="1%"><font color="#000000"><strong>:</strong></font></td>
    <td width="56%"><strong class="side_menu">
    <asp:Label ID="lbljobdesc" runat="server"></asp:Label></strong></td>
  </tr>
 <tr>
 <td colspan="4"><table border="0" width="100%"><tr><td><asp:Label ID="lblerror" runat="server"></asp:Label></td></tr></table>
      <asp:DataList ID="dlcenter" runat="server" onitemdatabound="dlData_ItemDataBound" Width="100%">
       <HeaderTemplate>
        </HeaderTemplate>
        <ItemTemplate>

    <table width="100%" border="0">
<%--  <tr>
    <td colspan="3" class="side_menu">
       <span class="ui-rater">
          &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <span class="ui-rater-starsOff" style="width:90px;"><span class="ui-rater-starsOn" runat="server" id="testSpan0"></span></span>
                <span class="ui-rater-rating" id="Span2" runat="server"></span>&#160;<span class="ui-rater-rateCount" id="Span3" runat="server"></span>
                </span>
    <asp:Label ID="lblratingh" runat="server" Font-Bold="true" Text="0" ForeColor="CornflowerBlue"></asp:Label>
         <asp:Label ID="Label12" runat="server" Text="Rating(s)" Font-Bold="true" ForeColor="CornflowerBlue"></asp:Label>
    </td>
  </tr>--%>
   <tr>
    <td colspan="3">
   <hr />
    </td>
    </tr>
  <tr>
    <td colspan="2" class="sub_menu" height="30">
     <asp:Image  ID="imgReviewer"  runat="server" AlternateText="Reviewer" ImageUrl='<%# Eval("ImageName", "../Logos\\{0}") %>'  Width="30"  Height="30"/>
    <%#DataBinder.Eval(Container.DataItem, "company_name")%>
    </td>
    <td class="sub_menu" align="right" style="padding-right:20px" ><%--<asp:LinkButton ID="friend" runat="server" Text="Share with your friend" Font-Size="12px"></asp:LinkButton>--%>
    <asp:HyperLink ID="friend" runat="server" Text="Share with your friend" Font-Size="12px" CssClass="pointer"></asp:HyperLink>
    </td> <AjaxToolkit:ModalPopupExtender ID="ModalPopupExtender1" runat="server" TargetControlID="friend" BackgroundCssClass="modalbackground" PopupControlID="friendpanel" OkControlID="imgbtnCancel" DropShadow="false" PopupDragHandleControlID="panel1">
              </AjaxToolkit:ModalPopupExtender>
    </tr>
  <tr>
    <td colspan="3"><table width="100%" border="0">
      <tr>
        <td width="29%" class="mid_menu" style="padding-left:2px;"><span class="mid_menu" style="padding-left:2px;">Industry</span></td>
        <td width="4%"><strong>:</strong></td>
        <td width="67%" class="mid_menu1"> <%#DataBinder.Eval(Container.DataItem, "job_industry")%></td>
      </tr>
      <tr>
        <td class="mid_menu" style="padding-left:2px;" height="25">Functional Area</td>
        <td><strong>:</strong></td>
        <td class="mid_menu1"><%#DataBinder.Eval(Container.DataItem, "job_functional_area")%></td>
      </tr>
      <tr>
        <td class="mid_menu" style="padding-left:2px;"  height="25">Job Role</td>
        <td><strong>:</strong></td>
        <td class="mid_menu1"><%#DataBinder.Eval(Container.DataItem, "job_role")%></td>
      </tr>
      <tr>
        <td class="mid_menu" style="padding-left:2px;"  height="25"><span class="mid_menu" style="padding-left:2px;">Location</span></td>
        <td><strong>:</strong></td>
        <td class="mid_menu1"><%#DataBinder.Eval(Container.DataItem, "city")%></td>
      </tr>
      <tr>
        <td class="mid_menu" style="padding-left:2px;"  height="25">Experience</td>
        <td><strong>:</strong></td>
        <td class="mid_menu1"> <%#DataBinder.Eval(Container.DataItem, "job_exp")%></td>
      </tr>
      <tr>
        <td class="mid_menu" style="padding-left:2px;"  height="25">Salary</td>
        <td><strong>:</strong></td>
        <td class="mid_menu1"><%#DataBinder.Eval(Container.DataItem, "job_sal")%></td>
      </tr>
      <tr>
        <td class="mid_menu" style="padding-left:2px;" height="25">Job Description</td>
        <td><strong>:</strong></td>
        <td class="mid_menu1"><%#DataBinder.Eval(Container.DataItem, "job_desc")%></td>
      </tr>
      <tr>
        <td class="mid_menu" style="padding-left:2px;" height="25">Job Post Date</td>
        <td><strong>:</strong></td>
        <td class="mid_menu1"><%#DataBinder.Eval(Container.DataItem, "postdate")%></td>
      </tr>
      <tr>
        <td class="mid_menu" style="padding-left:2px;" height="25">Last Date</td>
        <td><strong>:</strong></td>
        <td class="mid_menu1">
            <asp:Label ID="lbllastdate" runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "Job_ExpiryDate")%>'>
            </asp:Label>
        </td>
      </tr>
      <tr>
        <td colspan="3" class="mid_menu" style="padding-left:2px;"><hr/></td>
        </tr>
    </table></td>
    </tr>
  <tr>
    <td colspan="3" class="sub_menu" height="30">Desired Candidate Profile</td>
    </tr>
  <tr>
    <td colspan="3"><table width="100%" border="0">
      <tr>
        <td width="29%" class="mid_menu" style="padding-left:2px;"><span class="mid_menu" style="padding-left:2px;">Key Skills</span></td>
        <td width="4%"><strong>:</strong></td>
        <td width="67%" class="mid_menu1"><strong><%#DataBinder.Eval(Container.DataItem, "job_keyskills")%></strong></td>
      </tr>
      <tr>
        <td class="mid_menu" style="padding-left:2px;" height="25">Qualification</td>
        <td><strong>:</strong></td>
        <td class="mid_menu1"><%#DataBinder.Eval(Container.DataItem, "job_Qualification")%></td>
      </tr>
    
      <tr>
        <td colspan="3" class="mid_menu" style="padding-left:2px;"><hr/></td>
        </tr>
    </table></td>
    </tr>
  <tr>
    <td colspan="3" class="sub_menu" height="30">Company Profile</td>
    </tr>
  <tr>
    <td colspan="3"><table width="100%" border="0">
      <tr>
        <td colspan="3" style="padding-left:2px; color:Black;"> <%#DataBinder.Eval(Container.DataItem, "company_profile")%></td>
      </tr>
      <tr>
        <td class="mid_menu" style="padding-left:2px;" height="25">Contact Person</td>
        <td><strong>:</strong></td>
        <td class="mid_menu1"> <%#DataBinder.Eval(Container.DataItem, "contact_person")%></td>
      </tr>
      <tr>
        <td class="mid_menu" style="padding-left:2px;"  height="25">email</td>
        <td><strong>:</strong></td>
        <td class="mid_menu1"><%#DataBinder.Eval(Container.DataItem, "emailid")%></td>
      </tr>
      <tr>
        <td class="mid_menu" style="padding-left:2px;"  height="25">Phone No</td>
        <td><strong>:</strong></td>
        <td class="mid_menu1"><strong><%#DataBinder.Eval(Container.DataItem, "mob")%></strong></td>
      </tr>
      <tr>
        <td class="mid_menu" style="padding-left:2px;"  height="25">Address</td>
        <td><strong>:</strong></td>
        <td class="mid_menu1"><strong> <%#DataBinder.Eval(Container.DataItem, "address")%></strong></td>
      </tr>
      <tr>
        <td class="mid_menu" style="padding-left:2px;"  height="25"><span class="mid_menu" style="padding-left:2px;">Fax</span></td>
        <td><strong>:</strong></td>
        <td class="mid_menu1">
            <asp:Label ID="lblfax" runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "fax")%>'></asp:Label></td>
      </tr>
    </table></td>
    </tr>
 </table>

          </ItemTemplate>
         <FooterTemplate>
        </FooterTemplate>
       </asp:DataList>
       <asp:Panel ID="pnlmap" runat="server"  BackColor="#EAF1F6">
 <fieldset>
 <asp:DataList ID="dlmap" runat="server" DataKeyField="id">
 <ItemTemplate>
 
 <table border="0" width="100px" style="height:199px;">

 <tr><td></td></tr>
 <tr>
  <td width="40%" class="bottam"><strong class="side_menu">
        <%#DataBinder.Eval(Container.DataItem, "map")%>
        </strong></td>
 </tr>
 </table>
 </ItemTemplate>
 </asp:DataList>
 <br />
 <asp:Label ID="lblnorecords" runat="server" Text="No Map Found" ForeColor="Red"></asp:Label>
  <asp:Button ID="cancel" runat="server" Text="Close"/>
 </fieldset>
 </asp:Panel>
      <table width="100%">
         <tr>
         <td class="mid_menu" align="center" colspan="3">
          <asp:ImageButton ID="imgbtnApply" runat="server" ImageUrl="images/apply_job.png" AlternateText="Apply Job" OnClick="imgapply_Click"/>
        </td>
   
        <td class="mid_menu" align="center" colspan="3">
          <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="images/send-_button.png" AlternateText="SendButton" />
        </td>
      <td >
    <asp:ImageButton ID="rptabuse" runat="server" AlternateText="ReportAbuse" ImageUrl="images/Report_Abuse.png" />
    </td>
      </tr>
      <tr>
       <td align="right" colspan="9">
        <%-- <asp:LinkButton ID="lnkmap" runat="server" Text="View Map" ForeColor="#003366" Font-Bold="true" Font-Size="Medium"></asp:LinkButton>--%>
        <asp:HyperLink ID="lnkmap" runat="server" Text="View Map" Font-Bold="true" ForeColor="#003366" Font-Size="Medium"></asp:HyperLink>
        </td>
       </tr>
        </table>
      <asp:Panel ID="Panel4" runat="server" Width="100%">       
         <table border="0" width="100%">
         <tr>
    <td class="sub_menu"><hr/></td>
    </tr>
         
  <tr>
    <td class="sub_menu"><hr/></td>
    </tr>
  
        </table> 
      </asp:Panel>
 <asp:Panel ID="pnlreportabuse" runat="server" Width="350px">
<div class="dilogbox">
<table width="350px">
<tr>
<td colspan="2" align="center" valign="top" 
        style="font-family:Arial; font-size:large; color:#003366; padding-top:5px;">&nbsp; Report Abuse !
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
   <asp:ImageButton ID="BtnRGo" ImageUrl="images/panel/cencel.png" width="21" height="22" runat="server" AlternateText="Go"/></td>
</tr>
<tr>
  <td height="190" colspan="2">
     <table align="center" width="400px" style="height: 174px;">
      <tr style="margin-left:5px">
        <td align="right">
         <span class="star">*</span><asp:Label ID="lblname" runat="server" Text="Name" ForeColor="Black" Font-Bold="false"></asp:Label>
        </td>
        <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
        <td>
         <asp:TextBox ID="txtname" runat="server" Width="160px" Height="25px" onkeypress="return Alphabets(event);"></asp:TextBox>
         <asp:RequiredFieldValidator ID="rfvtxtname" runat="server" 
             ControlToValidate="txtname" ErrorMessage="Please enter your Name" 
             ValidationGroup="abuse">*</asp:RequiredFieldValidator>
       </td>
      </tr>
      <tr style="margin-left:5px">
        <td align="right">
         <span class="star">*</span><asp:Label ID="lblcontno" runat="server" Text="Contact No" ForeColor="Black" Font-Bold="false"></asp:Label>
        </td>
        <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
        <td>
         <asp:TextBox ID="txtcntno" runat="server" MaxLength="11" Width="160px" Height="25px" onkeypress="return onlyNos(event,this);"></asp:TextBox>
         <asp:RegularExpressionValidator ID="revtxtcntno" runat="server" 
             ControlToValidate="txtcntno" ErrorMessage="only numbera are allowed" 
             ValidationExpression="^[01]?[- .]?(\([1-9]\d{2}\)|[1-9]\d{2})[- .]?\d{3}[- .]?\d{4}$" ValidationGroup="abuse">*</asp:RegularExpressionValidator>
         <asp:RequiredFieldValidator ID="rfvtxtcntno" runat="server" 
             ControlToValidate="txtcntno" ErrorMessage="Please enter your contact number" 
             ValidationGroup="abuse">*</asp:RequiredFieldValidator>
             <asp:RangeValidator ID="rgvtxtcntno" runat="server" 
          ControlToValidate="txtcntno" ErrorMessage="Number must start with 0" 
          MaximumValue="1" MinimumValue="0" ValidationGroup="abuse">*</asp:RangeValidator></td>
        </tr>
      <tr style="margin-left:5px">
        <td align="right"><span class="star">*</span><asp:Label ID="lblemail" runat="server" Text="Email Id" ForeColor="Black" Font-Bold="false"></asp:Label></td>
        <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
        <td>
         <asp:TextBox ID="txtmail" runat="server" Width="160px" Height="25px"></asp:TextBox>
         <asp:RequiredFieldValidator ID="reqmail" runat="server" 
             ControlToValidate="txtmail" ErrorMessage="please enter your email id" 
             ValidationGroup="abuse">*</asp:RequiredFieldValidator>
         <asp:RegularExpressionValidator ID="regmail" runat="server" 
             ControlToValidate="txtmail" ErrorMessage="incorrect format of email id" 
             ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
             ValidationGroup="abuse">*</asp:RegularExpressionValidator>
        </td>
        </tr>
      <tr style="margin-left:5px;">
        <td align="right"><span class="star">*</span><asp:Label ID="lblcomment" runat="server" Text="Comment" ForeColor="Black" Font-Bold="false"></asp:Label>
        </td>
       <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
        <td>
        <asp:TextBox ID="txtcmnt" runat="server" TextMode="MultiLine" Width="160px" Height="25px"></asp:TextBox>
         <asp:RequiredFieldValidator ID="reqcmnt" runat="server" 
             ControlToValidate="txtcmnt" ErrorMessage="Please report your abuse" 
             ValidationGroup="abuse">*</asp:RequiredFieldValidator>
          <asp:ValidationSummary ID="ValidationSummary2" runat="server" 
                validationgroup="abuse" ShowMessageBox="True" ShowSummary="False" />
      </td>
      </tr>
      </table>
 </td>
</tr>
<tr>
  <td width="241" height="37">&nbsp;</td>
  <td width="163" valign="top">
  <asp:ImageButton ID="imgAbuseGo" OnClick="imgAbuseGo_Click" AlternateText="AbuseGo" ImageUrl="images/panel/dialog_buttan.png" width="98" 
           height="35" runat="server" ValidationGroup="abuse"/>
  </td>
</tr>
</table>
</div>
  </asp:Panel> &nbsp;
 <asp:Panel ID="friendpanel" runat="server" Width="350px">
<div class="dilogbox">
<table width="350px">
<tr>
<td colspan="2" align="center" valign="top" 
        
        style="font-family:Arial; font-size:large; color:#003366; padding-top:5px;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Share with your friend
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
   <asp:ImageButton ID="imgbtnCancel" ImageUrl="images/panel/cencel.png" AlternateText="imgCancel" width="21" height="22" runat="server"/></td>
</tr>
<tr>
  <td height="190" colspan="2">
    <table align="center" style="height: 170px;">
      <tr>
        <td colspan="3" style="padding-left:10px;">
         <asp:Label ID="Label5" runat="server" Text="Tell your friend about this site ." ForeColor="#003366" ></asp:Label></td>
      </tr>
      <tr style="margin-left:5px">
        <td align="right"><span class="star">*</span>
        <asp:Label ID="Label1" runat="server" Text="Your Name" ForeColor="Black" Font-Bold="false" ></asp:Label></td>
        <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
        <td>
        <asp:TextBox ID="txtyourname" runat="server" validationgroup="modal" Width="160px" Height="25px"  onkeypress="return Alphabets(event);"></asp:TextBox>
          <asp:RequiredFieldValidator ID="rfvtxtyourname" runat="server" 
                ErrorMessage="please enter your name" ControlToValidate="txtyourname"  validationgroup="share">*</asp:RequiredFieldValidator></td>
      </tr>
      <tr style="margin-left:5px">
        <td align="right"><span class="star">*</span>
        <asp:Label ID="Label2" runat="server" Text="Your's Friend Name" ForeColor="Black" Font-Bold="false"></asp:Label></td>
        <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
        <td>
        <asp:TextBox ID="txtfname" runat="server" validationgroup="modal" Width="160px" Height="25px"  onkeypress="return Alphabets(event);"></asp:TextBox>
          <asp:RequiredFieldValidator ID="rfvtxtfname" runat="server" 
               ErrorMessage="please enter your friend's name" ControlToValidate="txtfname"  
                    validationgroup="share">*</asp:RequiredFieldValidator></td>
     </tr>
      <tr style="margin-left:5px">
        <td align="right"><span class="star">*</span>
        <asp:Label ID="Label10" runat="server" Text="Your Friend's Mobile_No" ForeColor="Black" Font-Bold="false"></asp:Label>
        </td>
        <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
        <td>
        <asp:TextBox ID="txtmob" runat="server" validationgroup="modal" Width="160px" Height="25px" MaxLength="11" onkeypress="return onlyNos(event,this);"></asp:TextBox>
          <asp:RegularExpressionValidator ID="revtxtmob" runat="server" 
         ControlToValidate="txtmob" ErrorMessage="Only numbers are allowed for mobile" 
          ValidationExpression="^[01]?[- .]?(\([1-9]\d{2}\)|[1-9]\d{2})[- .]?\d{3}[- .]?\d{4}$" validationgroup="share">*</asp:RegularExpressionValidator>
          <asp:RequiredFieldValidator ID="rfvtxtmob" runat="server" 
             ErrorMessage="Please enter contact number" ControlToValidate="txtmob"  
                    validationgroup="share">*</asp:RequiredFieldValidator>
          <asp:RangeValidator ID="rgvtxtmob" runat="server" 
              ErrorMessage=" Mobile Number must start with 0" ControlToValidate="txtmob"  
                    MaximumValue="1" MinimumValue="0" 
               validationgroup="share">*</asp:RangeValidator>
       </td>
      </tr>
      <tr style="margin-left:5px">
        <td align="right"><span class="star">*</span>
        <asp:Label ID="Label4" runat="server" Text="Your Friend's Email_Id" ForeColor="Black" Font-Bold="false"></asp:Label></td>
        <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
        <td>
        <asp:TextBox ID="txtfemail" runat="server" validationgroup="modal" Width="160px" Height="25px"></asp:TextBox>
          <asp:RequiredFieldValidator ID="rfvtxtfemail" runat="server" ControlToValidate="txtfemail" 
           ErrorMessage="please enter Email id"  validationgroup="share">*</asp:RequiredFieldValidator>
          <asp:RegularExpressionValidator ID="revtxtfemail" runat="server" 
           ErrorMessage="Incorrect Format of email address" 
           ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
           validationgroup="share" ControlToValidate="txtfemail" >*</asp:RegularExpressionValidator></td>
           <asp:ValidationSummary ID="ValidationSummary3" runat="server" 
                validationgroup="share" ShowMessageBox="True" ShowSummary="False" />
        </tr>
       </table>
   </td>
</tr>
<tr>
  <td width="320" height="37">&nbsp;</td>
  <td style="padding:0px 5px 30px 0px;">
   <asp:ImageButton ID="imggo" OnClick="imggo_Click" AlternateText="imgGo" ImageUrl="images/panel/dialog_buttan.png" width="98" height="35" 
         runat="server" ValidationGroup="share"/>
  </td>
</tr>
</table>
</div>
</asp:Panel>
  &nbsp;
  <asp:Panel ID="mailpanel" runat="server" Width="320px">
 <div class="dilogbox">
  <table width="320px">
    <tr>
      <td colspan="2" align="center" valign="top" 
        style="font-family:Arial; font-size:large; color:#003366; padding-top:5px;">Get Information by sms/email
        &nbsp;&nbsp;&nbsp;&nbsp;
      <asp:ImageButton ID="cancelbtn" AlternateText="imgCancel" ImageUrl="images/panel/cencel.png" width="21" height="22" runat="server"/></td>
   </tr>
   <tr><td>&nbsp;</td></tr>
   <tr>
   <td height="170" colspan="2">
    <table align="center" width="400px" style="height: 170px;">
     <tr style="margin-left:5px">
       <td align="right">
       <span class="star">*</span>
        <asp:Label ID="Label6" runat="server" Text="Name" Font-Bold="false" ForeColor="Black" ></asp:Label>
        </td>
        <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
       <td>
        <asp:TextBox ID="txtname1" runat="server" ValidationGroup="modal" Width="160px" Height="25px"  onkeypress="return Alphabets(event);"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvtxtname1" runat="server" 
            ControlToValidate="txtname1" ErrorMessage="Enter Name" 
            ValidationGroup="sendmail">*</asp:RequiredFieldValidator>
     </td>
     </tr>
     <tr style="margin-left:5px">
        <td align="right">
        <span class="star">*</span>
            <asp:Label ID="Label9" runat="server" Text="Mobile_No" ForeColor="Black" Font-Bold="false" ></asp:Label>
        </td>
        <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
        <td>
            <asp:TextBox ID="txtmobile" runat="server" ValidationGroup="sendmail" Width="160px" Height="25px" MaxLength="11" onkeypress="return onlyNos(event,this);"></asp:TextBox>
         <asp:RegularExpressionValidator ID="revtxtmobile" runat="server" 
            ControlToValidate="txtmobile" ErrorMessage="Only numbers are allowed for mobile" 
            ValidationExpression="^[01]?[- .]?(\([1-9]\d{2}\)|[1-9]\d{2})[- .]?\d{3}[- .]?\d{4}$" ValidationGroup="sendmail">*</asp:RegularExpressionValidator>
         <asp:RequiredFieldValidator ID="rfvtxtmobile" runat="server" 
            ErrorMessage="Please enter contact number" ControlToValidate="txtmobile"  
            ValidationGroup="sendmail">*</asp:RequiredFieldValidator>
        <asp:RangeValidator ID="rgvtxtmobile" runat="server" 
            ErrorMessage=" Mobile Number must start with 0" ControlToValidate="txtmobile"  
            MaximumValue="1" MinimumValue="0" 
            ValidationGroup="sendmail">*</asp:RangeValidator>
        </td>
      </tr>
      <tr style="margin-left:5px">
        <td align="right">
        <span class="star">*</span>
            <asp:Label ID="Label7" runat="server" Text="Email_Id" ForeColor="Black" Font-Bold="false" ></asp:Label>
        </td>
        <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
        <td>
            <asp:TextBox ID="txtEmail" runat="server" ValidationGroup="modal" Width="160px" Height="25px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvtxtEmail" runat="server" ControlToValidate="txtEmail" 
            ErrorMessage="please enter Email id"  ValidationGroup="sendmail">*</asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="revtxtEmail" runat="server" 
            ErrorMessage="Incorrect Format of email address" 
            ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
            ValidationGroup="sendmail" ControlToValidate="txtEmail" >*</asp:RegularExpressionValidator>
             <asp:ValidationSummary ID="ValidationSummary4" runat="server" 
              ValidationGroup="sendmail" ShowMessageBox="True" ShowSummary="False" />
        </td>
     </tr>
     </table>
    </td>
    </tr>
    <tr>
      <td width="251" height="37">&nbsp;</td>
      <td width="153" valign="top" style="padding-right:5px;">
      <asp:ImageButton ID="imggo1" OnClick="imggo1_Click" AlternateText="imgbtnGo" ImageUrl="images/panel/dialog_buttan.png" width="98" height="35" 
              runat="server" ValidationGroup="sendmail"/>
      </td>
    </tr>
    </table>
</div>
  </asp:Panel> 
      <AjaxToolkit:ModalPopupExtender ID="ModalPopupExtender1" runat="server" 
            TargetControlID="ImageButton2" BackgroundCssClass="modalbackground" PopupControlID="mailpanel" 
            OkControlID="cancelbtn" DropShadow="false" PopupDragHandleControlID="panel2">
              </AjaxToolkit:ModalPopupExtender>
<AjaxToolkit:ModalPopupExtender ID="ModalPopupExtender3" runat="server" TargetControlID="lnkmap" BackgroundCssClass="modalbackground" PopupControlID="pnlmap" DropShadow="false" CancelControlID="cancel">
              </AjaxToolkit:ModalPopupExtender>
      <AjaxToolkit:ModalPopupExtender ID="poprptabuse" runat="server" TargetControlID="rptabuse" PopupControlID="pnlreportabuse"
      BackgroundCssClass="modalBackground" DropShadow="false" OkControlID="BtnRGo"></AjaxToolkit:ModalPopupExtender>
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
        ShowMessageBox="True" ShowSummary="False" ValidationGroup="SendMail" />
        </td></tr>
</table>
</div></div>
    </td>
  </tr></table>
  </div>
<div class="contentmid_boxbottam"></div>
</div>
<div class="content_innerright">
<div class="contentbox_top">Search By Cities</div>
<div class="contentbox_mid">
<rsearch:rightsrch ID="rjobsearch" runat="server" />
</div>
<div class="contentbox_bottam"></div>
<div class="contentbox_top">Sponsor Ads</div>
<div class="contentbox_mid">
<table width="100%" border="0">
<tr>
   <td class="right_tab">
<splnk:Splinks ID="sponseredlinks" runat="server" />
      </td>
    </tr>
  </table></div>
<div class="contentbox_bottam"></div>
</div> 

<div class="content_midbootam" >
<aa5:bottomMidcontent ID="mid1" runat="server" />

</div>
<div class="content_bootam_center">
<aa4:bottomcontent ID="bottomcontent1" runat="server" />

</div>


<div class="footer" align="center"> 
<aa10:footer1 ID="bvu" runat="server" />

<aa11:footer2 ID="ayh" runat="server" />
</div>
</div>
</div>

</form>
</body>
</html>
