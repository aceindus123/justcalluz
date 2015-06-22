<%@ Page Language="C#" AutoEventWireup="true" CodeFile="job_archieve.aspx.cs" Inherits="job_archieve" %>
<%@ Register Src="usercontrols/signin.ascx" TagName="signin" TagPrefix="aa1" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%@ Register Src="usercontrols/topimage.ascx" TagName="topimage" TagPrefix="aa2" %>
<%@ Register Src="usercontrols/Search.ascx" TagName="catageories" TagPrefix="aa6" %>
<%@ Register Src="usercontrols/footer1.ascx" TagName="footer1" TagPrefix="aa10" %>
<%@ Register Src="usercontrols/footer2.ascx" TagName="footer2" TagPrefix="aa11" %>
<%--<%@ Register Src="usercontrols/catageoriescenter.ascx" TagName="catcenter" TagPrefix="acatacenter2" %>--%>
<%@ Register Src="usercontrols/jobsleft.ascx" TagName="leftjob" TagPrefix="lj" %>
<%@ Register Src="usercontrols/SearchNew.ascx" TagName="newsearch" TagPrefix="nsearch"%>
<%@ Register Src="usercontrols/BottomContent.ascx" TagName="bottomcontent" TagPrefix="aa4" %>
<%@ Register Src="usercontrols/BottomMidContent.ascx" TagName="bottomMidcontent" TagPrefix="aa5" %>
<%@ Register Src="usercontrols/SponsoredLinks.ascx" TagName="SpLinks" TagPrefix="Sp_ads" %>
<%@ Register Src="usercontrols/small_logo.ascx" TagName="logosmall" TagPrefix="lgsmall" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<title>Justcalluz | Job opportunities in your city | we provide updated information on all your local search</title>
<meta name='description' content='Jobs opportunities,IT jobs,Management Jobs find the contact of Hot employers in your city' />
<meta name='keywords' content='Justcalluz, Real Estate Business,1BHK flat, yellow pages, online yellow pages, yellow pages india, India trade directory,  yellow pages directory, city yellow pages, indian search engine, JustCalluz customer care, JustCalluz customer support' />
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
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
  <a href="<%$RouteUrl:RouteName=HomeRoute%>" style="text-decoration:none;color:White" runat="server">Home>></a><%--<asp:Label ID="Label5"
          runat="server" Text="Jobs"></asp:Label>--%><a href="<%$RouteUrl:RouteName=jobs,cname=jobs%>" style="text-decoration:none;color:White" runat="server">Jobs>></a>Archive</div>
  <div class="contentmid_boxmid">
<table width="100%" border="0">
<tr>
<td>
<table border="0" width="100%">
<tr><td height="30" class="mid2_menu" style="background:url(images/job_search3.png)left no-repeat; padding-left:10px;" align="left" width="55%">
<asp:HyperLink ID="Hypcmpname" runat="server" ForeColor="#FFFFFF" Text="Click here to post the job" NavigateUrl="<%$RouteUrl:RouteName=PostJob,cname=jobs%>"></asp:HyperLink>
<%--<a href="post_job.aspx?cname=jobs"><font color="#FFFFFF">
<b>Click here to post the job </b></font></a>--%></td>
<td width="5%">&nbsp;</td>
<td width="45%" align="right" style="padding-right:30px;">
   <asp:ImageButton ID="imgarchieve" runat="server" ImageUrl="images/jobs_home.png" PostBackUrl="<%$RouteUrl:RouteName=jobs,cname=jobs%>" AlternateText="imagArchive" /></td>
</tr>
</table>
</td>
</tr>
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
          <tr><td class="job_bg" style="padding-top:5px;">
          <table width="95%" border="0">
            <tr>
    <td height="30" style="font-size:small;" colspan="3">
     <asp:literal  ID="litrole" runat="server" 
         Text='<%# Eval("job_role") %>'/> - <asp:Literal ID="litskills" runat="server" Text='<%#Eval("job_keyskills")%>'/>
   ( <asp:Literal ID="lit" runat="server" Text='<%#Eval("job_exp")%>'/> )</td>
    
  </tr>
  <tr>
       <td colspan="3" style="font-size:small;">
         <%--<asp:HyperLink ID="Hypcmpname" runat="server" ForeColor="#993333" Text='<%# Eval("company_name") %>' NavigateUrl='<%# string.Format("jobdetails.aspx?id=" + Eval("id").ToString()+ "&cname=jobs") %>'></asp:HyperLink>--%>
         <asp:HyperLink ID="Hypcmpname" runat="server" ForeColor="#993333" Text='<%# Eval("company_name") %>' NavigateUrl='<%# GetViewUrl(Eval("id")) %>'></asp:HyperLink>
         <asp:Label ID="lblid" runat="server" Text='<%#Eval("id")%>' Visible="false"></asp:Label>
    </td>
    </tr>
    <tr>
    <td colspan="3"  style="color:Green; font-size:small;">
    <asp:Literal ID="litcity" runat="server" Text='<%#Eval("city")%>' />
    </td>
    </tr>
    <tr>
    <td  height="30" colspan="3" style="font-size:small; color:Black;">
    <asp:Literal ID="lit_jobdesc" runat="server" Text='<%#Eval("job_desc")%>' />
    </td>
    </tr>
    <tr><td></td></tr>
    <tr>
    <td colspan="3"  style="color:Red; font-size:small;">
    Lastdate to apply : <asp:Label ID="lbl_expiry" runat="server" Text='<%#Eval("Job_ExpiryDate")%>' ForeColor="Black"></asp:Label> 
    </td>
    </tr>
    <tr><td rowspan="2"></td></tr>
    <tr><td rowspan="2"></td></tr>
  <tr>
    <td align="center" colspan="2">
    <table>
    </table></td>
   <%-- <td><span class="side_menu"></span></td>--%>
    <td align="right" style="padding-right:10px;">
   <%-- <asp:HyperLink ID="hyp1" runat="server" Text="View Details"  NavigateUrl='<%# "jobdetails.aspx?id=" + Eval("id").ToString() + "&cname=jobs" %>'></asp:HyperLink>--%>
    <asp:HyperLink ID="hyp1" runat="server" Text="View Details"  NavigateUrl='<%# GetViewUrl(Eval("id")) %>'></asp:HyperLink>
    </td>
  </tr>
  </table></td></tr>
 </ItemTemplate>
 <FooterTemplate>
 </table>
 </FooterTemplate>
 </asp:DataList>
  <table border="0" width="100%">
    <tr>
      <td align="right" style="padding-right:30px;">
        <asp:ImageButton ID="imgPrevious" runat="server" AlternateText="btnPrevious" ImageUrl="images/arrow_2.png" OnClick="imgPrevious_Click"/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:ImageButton ID="imgNext" runat="server" AlternateText="btnNext" ImageUrl="images/arrow_1.png" OnClick="imgNext_Click" />
      </td>
    </tr>
  </table>
    </td>
    </tr> 
  </table>
</div>
 <div class="contentmid_boxbottam"></div>
 </div>
<!--- srart of right menu--->
<div class="content_innerright">
<div class="contentbox_top">Sponsor Ads</div>
<div class="contentbox_mid">
<table width="100%" border="0">
  <tr>
   <td class="right_tab">
     <Sp_ads:SpLinks id="Sp_ads" runat="server"/>
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
<aa10:footer1 ID="bvu" runat="server" />
<aa11:footer2 ID="ayh" runat="server" />

</div>
</div>
</form>
</body>
</html>
