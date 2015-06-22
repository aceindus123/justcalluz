<%@ Page Language="C#" AutoEventWireup="true" CodeFile="joblinks.aspx.cs" Inherits="joblinks" %>
<%@ Register Src="usercontrols/signin.ascx" TagName="signin" TagPrefix="aa1" %>
<%@ Register Src="usercontrols/topimage.ascx" TagName="topimage" TagPrefix="aa2" %>
<%@ Register Src="usercontrols/Search.ascx" TagName="catageories" TagPrefix="aa6" %>
<%@ Register Src="usercontrols/footer1.ascx" TagName="footer1" TagPrefix="aa10" %>
<%@ Register Src="usercontrols/footer2.ascx" TagName="footer2" TagPrefix="aa11" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="AjaxToolkit" %>
<%@ Register Src="usercontrols/jobsleft.ascx" TagName="leftjob" TagPrefix="lj" %>
<%@ Register Src="usercontrols/SearchNew.ascx" TagName="newsearch" TagPrefix="nsearch"%>
<%@ Register Src="usercontrols/BottomContent.ascx" TagName="bottomcontent" TagPrefix="aa4" %>
<%@ Register Src="usercontrols/BottomMidContent.ascx" TagName="bottomMidcontent" TagPrefix="aa5" %>
<%@ Register Src="usercontrols/SponsoredLinks.ascx" TagName="Splinks" TagPrefix="aa3" %>
<%--<%@ Register Src="usercontrols/jobright.ascx" TagName="rightjob" TagPrefix="rjob" %>
--%><%@ Register Src="usercontrols/small_logo.ascx" TagName="logosmall" TagPrefix="lgsmall" %>
<%@ Register Src="usercontrols/rightsearch.ascx" TagName="rightsrch" TagPrefix="rsearch" %>
<%@ Import Namespace="System.Web.Routing" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
 <%--<meta http-equiv="Content-Type" content="text/html; charset=utf-8" :: Justcalluz :: Joblinks</title>--%>
 <title>Justcalluz | Job opportunities in your city | we provide updated information on all your local search</title>
<meta name='description' content='Jobs opportunities,IT jobs,Management Jobs find the contact of Hot employers in your city' />
<meta name='keywords' content='Justcalluz, Real Estate Business,1BHK flat, yellow pages, online yellow pages, yellow pages india, India trade directory,  yellow pages directory, city yellow pages, indian search engine, JustCalluz customer care, JustCalluz customer support' />
<link href="css/style.css" rel="stylesheet" type="text/css" />
<link href="css/inner_style.css" rel="Stylesheet" type="text/css" />

<link href="includes/SpryAccordion.css" rel="Stylesheet" type="text/css" />
<script type="text/javascript" src="js/SpryAccordion.js"></script>
</head>
<body>
<form id="f1" runat="server" >
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
<div class="contentbox_top">Refined Search By</div>
<div class="contentbox_mid" style="padding-left:15px;"> 
<lj:leftjob ID="jl" runat="server" />
</div>
    <div class="contentbox_bottam"></div>
</div>
<!-- start the mid Box-->
  <div class="content_innermid">
  <div class="contentmid_boxtop"><a href="<%$RouteUrl:RouteName=HomeRoute%>" style="text-decoration:none;color:White" runat="server">Home>></a><a href="<%$RouteUrl:RouteName=jobs,cname=jobs%>" style="color:#FFF; text-decoration:none;" runat="server">Jobs>></a>Joblinks</div>
  <div class="contentmid_boxmid"><table width="100%" border="0">
  <tr>
    <td height="30" colspan="2" align="right" class="headings" style="padding-right:5px;">Result for</td>
    <td width="1%"><font color="#000000"><strong>:</strong></font></td>
    <td width="56%" align="left"><strong class="side_menu">
   <asp:Label ID="Label10" runat="server" ></asp:Label>  
   <asp:Label ID="Label12" runat="server" Text="Specified Jobs"></asp:Label></strong></td>
  </tr>
 <%--<tr>
<td height="30" class="mid2_menu" style="background:url(images/job_search3.png)center no-repeat;" align="center"><a href="post_job.aspx" class="location"><font color="#FFFFFF">
    click here to post the job</font></a></td>
</tr>--%>
 </table>
  <table width="100%" border="0">
 <tr><td>
 <table border="0" width="100%">
<tr><td height="30" class="mid2_menu" style="background:url(images/job_search3.png)left no-repeat; padding-left:10px;" align="left" width="55%">
<asp:HyperLink ID="Hypcmpname" runat="server" ForeColor="#FFFFFF" Text="Click here to post the job" NavigateUrl="<%$RouteUrl:RouteName=PostJob,cname=jobs%>"></asp:HyperLink>
<%--<a href="post_job.aspx?cname=jobs"><font color="#FFFFFF">
<b>Click here to post the job </b></font>&nbsp;</a>--%></td>
<td width="35%" align="right" style=" padding-right:12px;">
 <asp:ImageButton ID="imgarchieve" runat="server" ImageUrl="images/Archieve.png" PostBackUrl="<%$RouteUrl:RouteName=archieve,cname=jobs%>" AlternateText="Archive" />
   <%-- <asp:ImageButton ID="imgarchieve" runat="server" ImageUrl="images/Archieve.png" 
        PostBackUrl="job_archieve.aspx?cname=jobs" AlternateText="Archive"/>--%></td>
</tr>
</table>
 </td></tr>
 <tr><td colspan="4">
      <asp:Label ID="lblerror" runat="server"></asp:Label></td></tr>
  <tr>
    <td colspan="4" valign="top">
    <asp:DataList ID="dldata" DataKeyField="id" runat="server" Width="100%" style="margin-left:0px">
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
   ( <asp:Literal ID="lit" runat="server" Text='<%#Eval("job_exp")%>'/> )</td>
            </tr>
            <tr>
              <td>
               <%--<asp:HyperLink ID="Hypcmpname" runat="server" Text='<%# Eval("company_name") %>'  NavigateUrl='<%# string.Format("jobdetails.aspx?id=" + Eval("id").ToString()+ "&cname=jobs") %>'></asp:HyperLink>--%>
              <asp:HyperLink ID="Hypcmpname" runat="server" Text='<%# Eval("company_name") %>'  NavigateUrl='<%# GetViewUrl(Eval("id")) %>'></asp:HyperLink>
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
                  <td width="20%"> <asp:ImageButton ID="sendmail" runat="server" ImageUrl="images/send-_button.png" AlternateText="imgSendMail" PostBackUrl='<%# GetViewUrl(Eval("id")) %>' /></td>
                  <td width="3%">&nbsp;</td>
                  <td width="26%"><asp:ImageButton ID="rptabuse" runat="server" ImageUrl="images/Report_Abuse.png" AlternateText="ReportAbuse" PostBackUrl='<%# GetViewUrl(Eval("id")) %>' /></td>
                  <td width="34%">&nbsp;</td>
                  <td width="17%" align="center"><asp:HyperLink ID="hyp1" runat="server" Text="View Details"  NavigateUrl='<%# GetViewUrl(Eval("id")) %>'></asp:HyperLink></td>
                </tr>
              </table></td>
            </tr>
          </tbody>
        </table>
          
          </td></tr>
<%--  --%>
     </ItemTemplate>
          <FooterTemplate>
            </table>
        </FooterTemplate>
               
        </asp:DataList>
       <%--<table border="0" style="background-color:white; margin-right: 0px; height: 22px;" width="100%">
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
               <td align="right">
                <asp:LinkButton ID="lnkbtnPrevious" runat="server" OnClick="lnkbtnPrevious_Click1" 
                        Font-Bold="True" Font-Size="Medium" Font-Underline="False">Previous</asp:LinkButton>
                </td>
                <td align="center">
                <asp:DataList ID="dlPaging" runat="server" OnItemCommand="dlPaging_ItemCommand" 
                    OnItemDataBound="dlPaging_ItemDataBound" RepeatDirection="Horizontal">            
                    <ItemTemplate>
                        <asp:LinkButton ID="lnkbtnPaging" runat="server" 
                        CommandArgument='<%# Eval("PageIndex") %>' 
                        CommandName="lnkbtnPaging" 
                        Text='<%# Eval("PageText") %>'>LinkButton</asp:LinkButton>&nbsp;
                    </ItemTemplate>
               </asp:DataList>
                </td>
                <td>
                    <asp:LinkButton ID="lnkbtnNext" runat="server" OnClick="lnkbtnNext_Click1" Font-Bold="True" Font-Size="Medium" Font-Underline="False" >Next</asp:LinkButton>
                </td>
            </tr>
            <tr><td colspan="4">
                <asp:Label ID="lblmsg" runat="server"></asp:Label></td></tr>
        </table>--%>
       <table border="0" width="100%">
        <tr>
           <td align="right" style="padding-right:13px;">
            <asp:ImageButton ID="imgPrevious" runat="server" ImageUrl="~/images/arrow_2.png" OnClick="imgPrevious_Click"/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:ImageButton ID="imgNext" runat="server" ImageUrl="~/images/arrow_1.png" OnClick="imgNext_Click" />
          </td>
        </tr>
         <tr><td colspan="4">
            <asp:Label ID="lblmsg" runat="server"></asp:Label>
        </td></tr>
       </table>
        </td>
        </tr>
         <tr id="lastdate" runat="server">
  <td height="40" style="background:url(images/job_today.png)center no-repeat; padding-left:30px;" align="center" colspan="4">
   <%-- <asp:LinkButton ID="lnklastdate" runat="server" 
        Text="Today is a lastdate to apply,click here to view them" ForeColor="#FFFFFF" Font-Bold="true"
        onclick="lnklastdate_Click"></asp:LinkButton>--%>
         <a id="lnklastdate" runat="server" style="color:#FFFFFF; font-weight:bold;" 
              onserverclick="lnklastdate_Click">Today is a lastdate to apply,click here to view them</a>
 </td>
</tr>
</table>
     </div>
      <div class="contentmid_boxbottam"></div>
 </div>
<!-- begin the right -->
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
     <aa3:Splinks id="jobr" runat="server"/>
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
  <div class="footer" align="center" style="padding-top:5px">  
<aa10:footer1 ID="bvu" runat="server" />

<aa11:footer2 ID="ayh" runat="server" />
</div>
</div>
</form>
</body>
</html>


