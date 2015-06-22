<%@ Page Language="C#" AutoEventWireup="true" CodeFile="careers_Department.aspx.cs" Inherits="careers_Department" %>
<%@ Register Src="usercontrols/signin.ascx" TagName="signin" TagPrefix="aa1" %>
<%@ Register Src="usercontrols/Search.ascx" TagName="catag" TagPrefix="aa6" %>
<%@ Register Src="usercontrols/footer1.ascx" TagName="footer1" TagPrefix="aa10" %>
<%@ Register Src="usercontrols/footer2.ascx" TagName="footer2" TagPrefix="aa11" %>
<%@ Register Src="usercontrols/BottomContent.ascx" TagName="bottomcontent" TagPrefix="aa4" %>
<%@ Register Src="usercontrols/BottomMidContent.ascx" TagName="bottomMidcontent" TagPrefix="aa5" %>
<%@ Register Src="usercontrols/Testimonials_Left.ascx" TagName="TestLeft" TagPrefix="aa15" %>
<%@ Register Src="usercontrols/small_logo.ascx" TagName="logo" TagPrefix="S_logo" %>
<%@ Register Src="usercontrols/SearchNew.ascx" TagName="SearchNew" TagPrefix="New" %>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
  <%--<title>:: Justcalluz :: careers Department page</title>--%>
   <title>Career Opportunities | JustCalluz</title>
	<meta name='Title' content='Career Opportunities | JustCalluz' />
	<meta name='description' content='JustCalluz jobs, career opportunities & current openings in JustCalluzl offices located in various cities. Apply for jobs by uploading resume and filling up basic information.' />
	<meta name='keywords' content='JustCalluz jobs, justcalluz careers, justcalluz openings, justcalluz vacanies' />
		
 <link href="css/style.css" rel="Stylesheet" type="text/css" />
  <link href="css/inner_style.css" rel="Stylesheet" type="text/css" />
 <script src="Scripts/swfobject_modified.js" type="text/javascript">
 </script>
</head>
<body>
  <form id="form1" runat="server">
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
  <div class="content_innermid" style="width:79%">
   <table width="100%" border="0">
    <tr>
     <td style="background:url(images/Testimonials.png) no-repeat" height="36">
    <table width="100%" border="0" >
    <tr>
     <td width="49%" class="bottam" style="padding-left:12px;"><font color="#FFFFFF" class="location">Careers at Justcalluz</font></td>
     <td width="5%"><asp:Image ID="Image2" AlternateText="sampleImage" ImageUrl="images/pencial.png" width="20" height="20" runat="server"/></td>
     <td width="46%"><font color="#FFFFFF"> Listing  Your job in Careers at Justcalluz</font></td>
   </tr>
   </table>
   </td>
   </tr>
   <tr>
   <td class="mid_menu" style="padding-left:4.5px;">
  <a href="<%$RouteUrl:RouteName=CareersDepartment %>" style="font-size:small;" runat="server">Job Categories</a>
 </td>
   </tr>
   <tr>
     <td>
   <table border="0" cellspacing="0" cellpadding="0" 
             style="border-top:1px solid Black; width: 100%; padding-left:4.5px; height:30px;">
    <tr style="background-color:#D5E6F9;">
      <td align="center" valign="middle" style="padding-left:4.5px;">
     <span class="location" style="font-size:small">
     <font color="black">Job Categories</font>
     </span> 
     </td>
    </tr>
    </table>
      </td>
    </tr>
    <tr>
     <td valign="top" colspan="4" class="side_menu" align="center">
      <table width="100%" border="0">
       <asp:DataList ID="dlCat" RepeatDirection="Horizontal" CellPadding="1" RepeatColumns="2" runat="server" 
             DataKeyField="Category" Height="107px" Width="100%" Font-Size="Small"> 
         <HeaderTemplate>
         </HeaderTemplate>
         <ItemTemplate>
         <div class="side_menu">
            <table>
             <tr>
              <td class="side_menu">
                 <%--<asp:HyperLink ID="lnkCate" Text='<%# Eval("category") %>' runat="server" NavigateUrl='<%# string.Format("careers_jobcategorylist.aspx?cat=" + Eval("category").ToString())%>'></asp:HyperLink>--%>
                 <asp:HyperLink ID="lnkCate" Text='<%# Eval("category") %>' runat="server" NavigateUrl='<%# GetUrl(Eval("category")) %>'></asp:HyperLink>
                  (<asp:Label ID="lbljobs" runat="server" Text='<%#Eval("Count_jobs") %>'></asp:Label>)
              </td>
              </tr>
            </table>
          </div> 
      </ItemTemplate>
   </asp:DataList>
  </table>
  </td>
  </tr>
  <tr>
  <td colspan="4">
  <asp:Label ID="lblError" runat="server"></asp:Label>
    </td>
    </tr> 
  </table>
  </div>
  <div class="content_midbootam" >
  <aa5:bottomMidcontent ID="mid1" runat="server" />
  </div>
  <div class="content_bootam_center">
  <aa4:bottomcontent ID="bottomcontent1" runat="server" />
  </div>
  <div class="footer" align="center" style="padding-top:5px;">
   <aa10:footer1 ID="footer1" runat="server" />
  <aa11:footer2 ID="footer2" runat="server" />  
  </div>
  </div>
</div>
  </div>
 </form>
</body>
</html>
