<%@ Page Language="C#" AutoEventWireup="true" CodeFile="view_jobs.aspx.cs" Inherits="view_jobs" %>
<%@ Register Src="usercontrols/signin.ascx" TagName="signin" TagPrefix="aa1"  %>
<%@ Register Src="usercontrols/topimage.ascx" TagName="topimage" TagPrefix="aa2" %>
<%@ Register Src="usercontrols/SearchNew.ascx" TagName="newsearch" TagPrefix="nsearch"%>
<%@ Register Src="usercontrols/Search.ascx" TagName="catageories" TagPrefix="aa6" %>
<%@ Register Src="usercontrols/footer1.ascx" TagName="footer1" TagPrefix="aa10" %>
<%@ Register Src="usercontrols/footer2.ascx" TagName="footer2" TagPrefix="aa11" %>
<%@ Register Src="usercontrols/BottomContent.ascx" TagName="Bottomcontent" TagPrefix="bcon" %>
<%@ Register Src="usercontrols/BottomMidContent.ascx" TagName="Contentmid" TagPrefix="bcm" %>
<%@ Register Src="usercontrols/CheckPostLeftMenu.ascx" TagName="leftcheckpost" TagPrefix="lcp" %>
<%@ Register Src="usercontrols/small_logo.ascx" TagName="logosmall" TagPrefix="lgsmall" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>Justcalluz | Job opportunities in your city | we provide updated information on all your local search</title>
<meta name='description' content='Jobs opportunities,IT jobs,Management Jobs find the contact of Hot employers in your city' />
<meta name='keywords' content='Justcalluz, Real Estate Business,1BHK flat, yellow pages, online yellow pages, yellow pages india, India trade directory,  yellow pages directory, city yellow pages, indian search engine, JustCalluz customer care, JustCalluz customer support' />
<link href="css/style.css" rel="Stylesheet" type="text/css" />
<link href="css/inner_style.css" rel="Stylesheet" type="text/css" />

<link href="includes/SpryAccordion.css" rel="Stylesheet" type="text/css" />
<script type="text/javascript" src="js/SpryAccordion.js"></script><script src="SpryAssets/SpryTabbedPanels.js" type="text/javascript"></script>
<link href="SpryAssets/SpryTabbedPanels.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
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
<%--<div class="contenbox">--%>
<div class="contentbox_top">My Postings</div>
<div class="contentbox_mid">
 <lcp:leftcheckpost ID="leftcheckpost" runat="server" />
 </div>
<div class="contentbox_bottam"></div>
<%--</div>--%>
</div>
<!-- end of the inner left-->

<!-- start the mid Box-->
  <div class="content_innermid" style="width:70%">
<%--  <div class="searchmid_box">--%>
  <div class="searchmid_boxtop1"><a href="Default.aspx" style="text-decoration:none;color:White">
      Home</a>&gt;&gt;<a id="lnkBtnTocheckPostings" runat="server" onserverclick="lnkBtnTocheckPostings_Click" style="color:White;">My Postings</a>&gt;&gt;Jobs</div>
  <div class="searchmid_boxmid1">
    <table width="100%" border="0">
      <tr id="trHeading" runat="server" class="sub_menu">
        <td colspan="3" align="center">
        <asp:Label ID="lblHeading1" runat="server" Font-Size="Medium" Text="Jobs Posted By You"></asp:Label>
        </td>
      </tr>
      <tr>
        <td colspan="3" style="width:500px; margin:0px auto; padding-top:2px;">
         <asp:DataList ID="dldata" DataKeyField="id" runat="server" Width="100%" style="margin-left:0px">
          <HeaderTemplate>
       <table width="100%" border="0">
          </HeaderTemplate>
          <ItemTemplate>
          <tr><td colspan="3" align="center" class="sub_menu">Status : <asp:Label ID="lblstatus" runat="server" Text='<%#Eval("Status")%>'></asp:Label></td></tr>
          <tr><td class="job_bg" style="margin:0px auto; float:none; background:url(images/job_search-002.png) center no-repeat;  height:225px;">     
          <table width="100%" border="0">
            <tr>
    <td width="44%" height="15" class="sub_menu" style="padding-left:30px;">
    <%-- <asp:HyperLink ID="Hypcmpname" runat="server" Text='<%# Eval("company_name") %>'  NavigateUrl='<%# string.Format("jobdetails.aspx?id=" + Eval("id").ToString()+ "&cname=jobs") %>' ></asp:HyperLink>--%>
    <asp:HyperLink ID="Hypcmpname" runat="server" Text='<%#Eval("company_name")%>' Font-Size="11px" NavigateUrl='<%# GetCompUrl(Eval("id")) %>'></asp:HyperLink>
    </td>
    <td width="33%" class="sub_menu"><asp:Literal ID="lit" runat="server" Text='<%#Eval("job_exp")%>'/></td>
    <td width="33%" class="sub_menu" style="padding-left:80px;">
      <%--<asp:HyperLink ID="lnkedit" runat="server" Text="Edit" NavigateUrl='<%# string.Format("edit_job.aspx?id=" + Eval("id").ToString()+ "&cname=jobs") %>'></asp:HyperLink>--%>
      <asp:HyperLink ID="lnkedit" runat="server" Text=" Edit " Font-Size="11px" NavigateUrl='<%# GetEditUrl(Eval("id")) %>'></asp:HyperLink>
   </td>
  </tr>
   <tr>
    <td height="124" colspan="3" valign="top" style="padding-left:30px;padding-right:15px;">
    <table width="100%" border="0">
      <tr>
       <td width="69%" class="mid1_menu" colspan="3"><font color="#00162D" > 
        <p><asp:Literal ID="Literal7" runat="server" Text='<%#Eval("job_desc")%>' /></font></p>
        </td>
      </tr>
      <tr>
        <td class="select_menu" height="15" align="right">Location</td>
        <td><strong>:</strong></td>
        <td  class="mid1_menu"><font color="#00162D" >
        <asp:Literal ID="Literal8" runat="server" Text='<%#Eval("city")%>' /></font></td>
      </tr>
      <tr>
        <td class="select_menu" height="18" align="right">Last date</td>
        <td><strong>:</strong></td>
        <td  class="mid1_menu"><font color="#00162D" > <asp:Literal ID="Literal2" runat="server" Text='<%#Eval("Job_ExpiryDate")%>' />
            &nbsp;(mm/dd/yyyy)</font></td>
      </tr>
      <tr>
        <td class="select_menu" align="right"><asp:Image ImageUrl="images/phone.png" width="21" height="18" runat="server" ID="imgPhone" AlternateText="Phone"/></td>
        <td><strong>:</strong></td>
        <td  class="mid1_menu" ><font color="#00162D" > <asp:Literal ID="Literal1" runat="server" Text='<%#Eval("mob")%>'  /></font></td>
      </tr>
      <tr>
        <td height="18" class="select_menu" align="right">&nbsp;&nbsp;<asp:Image ImageUrl="images/mail1.png" width="21" height="18" runat="server" ID="imgMail" AlternateText="Mail" /></td>
        <td><strong>:</strong></td>
        <td  class="mid1_menu"><font color="#00162D" ><asp:Literal ID="Literal3" runat="server" Text='<%#Eval("emailid")%>' /></font></td>
      </tr>
    </table></td>
    </tr>
  <tr>
    <td colspan="3" align="right" style="padding-right:40px;"><span style="padding-left:15px;" class="side_menu">
    <%-- <asp:HyperLink ID="hyp1" runat="server" Text="View Details"  NavigateUrl='<%# "jobdetails.aspx?pageid=jobs &id=" + Eval("id").ToString()%>' Font-Size="12px"></asp:HyperLink></span></td>--%>
    <asp:HyperLink ID="hyp1" runat="server" Text="View Details" NavigateUrl='<%# GetCompUrl(Eval("id"))%>'></asp:HyperLink>
  </tr>
  </table></td></tr>
  
     </ItemTemplate>
          <FooterTemplate>
            </table>
        </FooterTemplate>
               
        </asp:DataList>
        </td>
        
      </tr>
      <tr>
     <td  align="left" style="padding-left:32px;">&nbsp;&nbsp;<asp:label id="lblCurrentPage" runat="server"></asp:label></td>
     
        <td align="right" style="padding-right:30px;">
        
            <asp:ImageButton ID="imgPrevious" runat="server" AlternateText="btnPrevious" ImageUrl="images/arrow_2.png" OnClick="imgPrevious_Click"/>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:ImageButton ID="imgNext" runat="server" AlternateText="btnNext" ImageUrl="images/arrow_1.png" OnClick="imgNext_Click" />
        </td>
      </tr>
       <tr class="side_menu">
       
        </tr>
        <tr>
        <td align="center" valign="middle" style="padding-top:0px; font-size:medium" colspan="3">
                  <asp:Label ID="lblMsg" runat="server"></asp:Label>
       </td>
       </tr>

    </table>
  </div>
  <div class="searchmid_boxbottam1"></div>
<%--  </div>--%>
  </div>

<!-- end of the mid Box-->
</div>
<div class="content_midbootam" >
<bcm:Contentmid ID="contentmid" runat="server" />
</div>

<div class="content_bootam_center">
<bcon:Bottomcontent ID="bottomcontent" runat="server" />
</div>

<div class="footer" align="center">
<aa10:footer1 ID="sdsa" runat="server" />
<aa11:footer2 ID="poshv" runat="server" />
</div>

</div>
    </form>
</body>
</html>
