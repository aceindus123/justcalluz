<%@ Page Language="C#" AutoEventWireup="true" CodeFile="jobs.aspx.cs" Inherits="_jobs" EnableEventValidation="false" %>
<%@ Register Src="usercontrols/signin.ascx" TagName="signin" TagPrefix="aa1" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%@ Register Src="usercontrols/topimage.ascx" TagName="topimage" TagPrefix="aa2" %>
<%@ Register Src="usercontrols/Search.ascx" TagName="catageories" TagPrefix="aa6" %>
<%@ Register Src="usercontrols/footer1.ascx" TagName="footer1" TagPrefix="aa10" %>
<%@ Register Src="usercontrols/footer2.ascx" TagName="footer2" TagPrefix="aa11" %>
<%@ Register Src="usercontrols/jobsleft.ascx" TagName="leftjob" TagPrefix="lj" %>
<%@ Register Src="usercontrols/SearchNew.ascx" TagName="newsearch" TagPrefix="nsearch"%>
<%@ Register Src="usercontrols/BottomContent.ascx" TagName="bottomcontent" TagPrefix="aa4" %>
<%@ Register Src="usercontrols/BottomMidContent.ascx" TagName="bottomMidcontent" TagPrefix="aa5" %>
<%@ Register Src="usercontrols/rightsearch.ascx" TagName="rightsrch" TagPrefix="rsearch" %>
<%@ Register Src="usercontrols/small_logo.ascx" TagName="logosmall" TagPrefix="lgsmall" %>
<%@ Register Src="usercontrols/SponsoredLinks.ascx" TagName="SpLinks" TagPrefix="Sp_ads" %>
<%@ Import Namespace="System.Web.Routing" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<%--<title>Justcalluz/ Jobs Home</title>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />--%>
<title>Justcalluz | Job opportunities in your city | we provide updated information on all your local search</title>
<meta name='description' content='Jobs opportunities,IT jobs,Management Jobs find the contact of Hot employers in your city' />
<meta name='keywords' content='Justcalluz, Real Estate Business,1BHK flat, yellow pages, online yellow pages, yellow pages india, India trade directory,  yellow pages directory, city yellow pages, indian search engine, JustCalluz customer care, JustCalluz customer support' />
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
     .starrating
    {
    	background-image:url(images/ratestar2.png);
    	width:18px;
    	height:18px;
    }
    .starfill
    {
    	background-image:url(images/ratestar2.png);
    	width:18px;
    	height:18px;
    }
    .starempty
    {
    	background-image:url(images/starash3.png);
    	width:18px;
    	height:18px;
    }
 </style>
     
     
<script type="text/javascript">function postbackFromJS(sender, e) 
{
var postBack = new Sys.Preview.PostBackAction();
postBack.set_target(sender);
postBack.set_eventArgument(e);
postBack.performAction();
}      
</script>
<link href="css/style.css" rel="Stylesheet" type="text/css" />
<link href="css/inner_style.css" rel="Stylesheet" type="text/css" />

<link href="includes/SpryAccordion.css" rel="Stylesheet" type="text/css" />
<script type="text/javascript" src="js/SpryAccordion.js"></script>
</head>
<body>
<form id="f1" runat="server" >
<asp:ScriptManager ID="ScriptManager1" runat="server" EnablePageMethods="true">
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
</div><div class="header_search">

<nsearch:newsearch ID="search" runat="server" />
</div>
</div>
<div class="category_box">
<aa6:catageories ID="dff" runat="server" />
</div>
<!-- start the inner left-->
<div class="content_innerleft">
<%--<table width="100%" border="0" style="background:url(images/write-new.png) no-repeat" height="30">
        <tr>
          <td style="padding-left:26px;" class="button_list">
          <asp:LinkButton ID="lnkarchieve" runat="server" Text="Archieve" 
                 PostBackUrl="job_archieve.aspx"></asp:LinkButton>
          </td>
          </tr>
  </table>--%>
 <div class="contentbox_top">Refined Search By</div>
<div class="contentbox_mid" style="padding-left:15px;"> 
<lj:leftjob ID="jl" runat="server" />
</div>
<div class="contentbox_bottam"></div>
</div>
<!--end of top row-->
<!--end of 1 column-->
  <div class="content_innermid">
  <div class="contentmid_boxtop">
  <a href="<%$RouteUrl:RouteName=HomeRoute%>" style="text-decoration:none;color:White" runat="server">Home&gt;&gt;</a><asp:Label ID="Label5"
     runat="server" Text="Jobs"></asp:Label></div>
  <div class="contentmid_boxmid">
<table width="100%" border="0">
<tr>
<td>
<table border="0" width="100%">
<tr>
<td height="30" class="mid2_menu" style="background:url(images/job_search3.png)left no-repeat; padding-left:10px;" align="left" width="55%">
<asp:HyperLink ID="Hypcmpname" runat="server" ForeColor="#FFFFFF" Text="Click here to post the job" NavigateUrl="<%$RouteUrl:RouteName=PostJob,cname=jobs%>"></asp:HyperLink>
<%--<a href="post_job.aspx?cname=jobs"><font color="#FFFFFF">
<b>Click here to post the job </b></font></a>--%></td>
<td width="5%">&nbsp;</td>
<td width="35%" align="right" style=" padding-right:12px;">
 <asp:ImageButton ID="imgarchieve" runat="server" ImageUrl="images/Archieve.png" PostBackUrl="<%$RouteUrl:RouteName=archieve,cname=jobs%>" AlternateText="Archive" />
</td>
</tr>
</table>
</td>
</tr>
<%--<asp:ImageButton ID="imgarchieve" runat="server" ImageUrl="images/Archieve.png" PostBackUrl="job_archieve.aspx" />--%>
<tr><td>
<asp:Label ID="lblnotfound" runat="server" Font-Names="verdana"></asp:Label>
</td></tr>
<tr>
<td valign="top">
<asp:DataList ID="dldata" DataKeyField="id" runat="server" Width="100%" 
        style="margin-left:0px">
          <HeaderTemplate>
       <table width="100%" border="0">
          </HeaderTemplate>
          <ItemTemplate>
          <tr><td>
          <table border="0" width="100%" class="job_bg">
          <tbody>
            <tr>
              <td><asp:literal  ID="litrole" runat="server" 
                Text='<%# Eval("job_role") %>'/> - <asp:Literal ID="litskills" runat="server" Text='<%#Eval("job_keyskills")%>'/>
                 ( <asp:Literal ID="lit" runat="server" Text='<%#Eval("job_exp")%>'/> )
              </td>
            </tr>
            <tr>
              <td style="font-weight:bold;">
              <asp:HyperLink ID="Hypcmpname" runat="server" ForeColor="#993333" Text='<%# Eval("company_name") %>' NavigateUrl='<%# GetUrl(Eval("id")) %>'></asp:HyperLink>
                <%--<asp:LinkButton  ID="linkcmpname" ForeColor="#993333" runat="server" PostBackUrl= '<%# string.Format("jobdetails.aspx?id=" + Eval("id").ToString() + "&cname=jobs")%>' Text='<%# Eval("company_name") %>' CommandName ="Select"></asp:LinkButton>--%>
              </td>
            </tr>
            <tr>
              <td> <asp:Literal ID="litcity" runat="server" Text='<%#Eval("city")%>' /> </td>
            </tr>
            <tr>
              <td> <asp:Literal ID="lit_jobdesc" runat="server" Text='<%#Eval("job_desc")%>' /></td>
            </tr>
            <tr>
              <td> Lastdate to apply : <span id="dldata_ctl01_lbl_expiry" style="color:Black;"><asp:Label ID="lbl_expiry" runat="server" Text='<%#Eval("Job_ExpiryDate")%>' ForeColor="Black"></asp:Label> </span></td>
            </tr>
            <tr>
              <td>&nbsp;</td>
            </tr>
            <tr>
              <td width="20%" align="right" valign="middle"><table width="100%">
                <tr>
                  <td width="20%"><asp:ImageButton ID="sendmail" runat="server" ImageUrl="images/send-_button.png" AlternateText="imgSendMail" PostBackUrl='<%# GetUrl(Eval("id")) %>' /></td>
                  <td width="3%">&nbsp;</td>
                  <td width="26%"><asp:ImageButton ID="rptabuse" runat="server" ImageUrl="images/Report_Abuse.png" AlternateText="ReportAbuse" PostBackUrl='<%# GetUrl(Eval("id")) %>' /></td>
                  <td width="34%">&nbsp;</td>
                  <td width="17%" align="center" style="padding-right:10px;">
                  <asp:HyperLink ID="HyperLink1" runat="server" ForeColor="#993333" Text="View Details" NavigateUrl='<%# GetUrl(Eval("id")) %>'></asp:HyperLink>
                    <%--<asp:HyperLink ID="hyp1" runat="server" Text="View Details"  NavigateUrl='<%# string.Format("jobdetails.aspx?id=" + Eval("id").ToString()+ "&cname=jobs") %>'></asp:HyperLink>--%>
                  </td>
                </tr>
              </table></td>
            </tr>
          </tbody>
        </table>
          
          </td></tr>
 <%-- <cc1:ModalPopupExtender ID="poprptabuse" runat="server" TargetControlID="rptabuse" PopupControlID="pnlreportabuse"
      BackgroundCssClass="modalBackground" DropShadow="false" CancelControlID="btncancel"></cc1:ModalPopupExtender>--%>
      </ItemTemplate>
          <FooterTemplate>
            </table>
        </FooterTemplate>
      </asp:DataList>
        <%--<table border="0" style="background-color:white; width: 100px; margin-right: 0px; height: 22px;" id="tblPaging" runat="server">
            <tr>
                <td>
                    <asp:DropDownList ID="ddlPageSize" runat="server" 
                        OnSelectedIndexChanged="ddlPageSize_SelectedIndexChanged" 
                        style="height: 22px">
                    <asp:ListItem>3</asp:ListItem>
                    <asp:ListItem>5</asp:ListItem>
                    <asp:ListItem>10</asp:ListItem>
                    </asp:DropDownList>
                </td>
               <td class="sub_menu">
               <a id="lnkbtnPrevious" runat="server" onserverclick="lnkbtnPrevious_Click1" rel="Prev">Previous</a>&nbsp;
               <asp:LinkButton ID="lnkbtnPrevious" runat="server" OnClick="lnkbtnPrevious_Click1" 
                        Font-Bold="True" Font-Size="Medium" Font-Underline="False">Previous</asp:LinkButton>
                </td>
                <td align="center" valign="middle">
                <asp:DataList ID="dlPaging" runat="server" OnItemCommand="dlPaging_ItemCommand" 
                    OnItemDataBound="dlPaging_ItemDataBound" RepeatDirection="Horizontal" 
                        ForeColor="#996633">            
                    <ItemTemplate>
                      <asp:HyperLink ID="lnkbtnPaging" Text='<%# Eval("PageText") %>' runat="server" AccessKey='<%# Eval("PageIndex") %>'>HyperLink</asp:HyperLink>&nbsp;
                     <asp:LinkButton ID="lnkbtnPaging" runat="server" CommandArgument='<%# Eval("PageIndex") %>' 
                        CommandName="lnkbtnPaging" Text='<%# Eval("PageText") %>'>LinkButton</asp:LinkButton>
                    </ItemTemplate>
                 </asp:DataList>

                </td>
                <td class="sub_menu">
                 <a id="lnkbtnNext" runat="server" onserverclick="lnkbtnNext_Click1" rel="Next">Next</a>              
               </td>
            </tr>
        </table>--%>
       <table border="0" width="100%" id="tblPaging" runat="server">
        <tr>
          <td align="right" style="padding-right:13px;">
            <asp:ImageButton ID="imgPrevious" runat="server" ImageUrl="~/images/arrow_2.png" OnClick="imgPrevious_Click"/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:ImageButton ID="imgNext" runat="server" ImageUrl="~/images/arrow_1.png" OnClick="imgNext_Click" />
          </td>
        </tr>
       </table>
    </td>
    </tr> 
   <tr id="lastdate" runat="server">
  <td height="40" style="background:url(images/job_today.png)center no-repeat; padding-left:30px;" align="center">
       <a id="lnklastdate" runat="server" style="color:#FFFFFF; font-weight:bold;" 
              onserverclick="lnklastdate_Click">Today is a lastdate to apply,click here to view them</a>
  </td>
</tr>
</table>
<%--<asp:Panel ID="pnlreportabuse" runat="server" Width="324px" BackColor="White">
     <fieldset>
     <table width="500px" style="line-height:40px; background-color:White;">
    
     <tr><td colspan="3" align="right"><asp:Label ID="lblabuse" runat="server" Text="Report Abuse !"></asp:Label>
     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
   
     <asp:Button ID="btncancel" runat="server" Text="X" />
         </td>
     </tr>
    
     <tr><td>
     <asp:Label ID="lblname" runat="server" Text="Name *" ForeColor="#003366"></asp:Label>
     </td>
     <td>:</td>
     
     <td><asp:TextBox ID="txtname" runat="server"></asp:TextBox>
         <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
             ControlToValidate="txtname" ErrorMessage="Please enter your Name" 
             ValidationGroup="abuse">*</asp:RequiredFieldValidator>
         </td>
     </tr>
     <tr><td>
     <asp:Label ID="lblcontno" runat="server" Text="Contact No *" ForeColor="#003366"></asp:Label>
     </td>
     <td>:</td>
     <td><asp:TextBox ID="txtcntno" runat="server" MaxLength="11"></asp:TextBox>
         <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
             ControlToValidate="txtcntno" ErrorMessage="only numbera are allowed" 
             ValidationExpression="\d{11}" ValidationGroup="abuse">*</asp:RegularExpressionValidator>
         <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
             ControlToValidate="txtcntno" ErrorMessage="Please enter your contact number" 
             ValidationGroup="abuse">*</asp:RequiredFieldValidator>
             <asp:RangeValidator ID="RangeValidator1" runat="server" 
          ControlToValidate="txtcntno" ErrorMessage="Number must start with 0" 
          MaximumValue="1" MinimumValue="0" ValidationGroup="abuse">*</asp:RangeValidator>
         </td></tr>
     <tr><td>
     <asp:Label ID="lblemail" runat="server" Text="Email Id *" ForeColor="#003366"></asp:Label>
     </td>
     <td>:</td>
     <td><asp:TextBox ID="txtmail" runat="server"></asp:TextBox>
         <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
             ControlToValidate="txtmail" ErrorMessage="please enter your email id" 
             ValidationGroup="abuse">*</asp:RequiredFieldValidator>
         <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
             ControlToValidate="txtmail" ErrorMessage="incorrect format of email id" 
             ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
             ValidationGroup="abuse">*</asp:RegularExpressionValidator>
         </td>
     </tr>
     <tr>
     <td><asp:Label ID="lblcomment" runat="server" Text="Comment *" ForeColor="#003366"></asp:Label></td>
     <td>:</td>
     <td><asp:TextBox ID="txtcmnt" runat="server" TextMode="MultiLine"></asp:TextBox>
         <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
             ControlToValidate="txtcmnt" ErrorMessage="Please report your abuse" 
             ValidationGroup="abuse">*</asp:RequiredFieldValidator>
         </td>
     </tr>
     
     <tr><td colspan="6" align="center">
         <asp:ValidationSummary ID="ValidationSummary2" runat="server" 
             ShowMessageBox="True" ShowSummary="False" ValidationGroup="abuse" />
         <asp:ImageButton ID="imgsubmit1" runat="server" 
             ImageUrl="~/images/submit2.png" onclick="imgsubmit1_Click" 
             ValidationGroup="abuse" /></td></tr>
     </table>
     </fieldset>
     </asp:Panel>--%>
</div>
 <div class="contentmid_boxbottam"></div>
  </div>
<!--- start of right menu--->
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
      <Sp_ads:SpLinks ID="Sp_ads" runat="server" />
     </td>
    </tr>
  </table>
</div>
<div class="contentbox_bottam"></div>
</div>
<div class="content_midbootam" >
<aa5:bottomMidcontent ID="mid1" runat="server" />
</div>
<div class="content_bootam_center">
<aa4:bottomcontent ID="bottomcontent1" runat="server" />
</div>
<div class="footer" align="center"> 
<aa10:footer1 ID="footer" runat="server" />
<aa11:footer2 ID="ayh" runat="server" />
</div>
</div>
</form>
</body>
</html>
