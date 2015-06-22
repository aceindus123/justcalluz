<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Careers_Location.aspx.cs" Inherits="Careers_Location" %>
<%@ Register Src="usercontrols/signin.ascx" TagName="signin" TagPrefix="aa1" %>
<%@ Register Src="usercontrols/topimage.ascx" TagName="topimage" TagPrefix="aa2" %>
<%@ Register Src="usercontrols/Search.ascx" TagName="catag" TagPrefix="aa6" %>
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
   <%--<title>:: Justcalluz :: Careers Location page</title>--%>
   <title id="pgtitle" runat="server">Career Opportunities | JustCalluz</title>
		
    <link href="css/style.css" rel="Stylesheet" type="text/css" />
    <link href="css/inner_style.css" rel="Stylesheet" type="text/css" />
    <script src="Scripts/swfobject_modified.js" type="text/javascript">
    </script>
    <style type="text/css">
        .style1
        {
            font-family: Verdana, Geneva, sans-serif;
            font-size: 12px;
            font-weight: bold;
            color: #004080;
            height: 23px;
        }
        .style2
        {
            height: 23px;
        }
    </style>
</head>
<body>
    
 <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePageMethods="true">
    </asp:ScriptManager>
 <div>
 <div class="layout">

 <div class="signin">
  <aa1:signin ID="signIn" runat="server" />
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
    <table width="100%" border="0">
    <tr>
    <td width="49%" class="bottam" style="padding-left:12px;"><font color="#FFFFFF" class="location">Careers at Justcalluz</font></td>
     <td width="51%">
        <asp:Image AlternateText="SampleImage" ImageUrl="images/pencial.png" width="20" height="20" runat="server" />
        <font color="#FFFFFF"> Listing  Your job in Careers at Justcalluz</font>
        </td>
   <%-- <td width="46%"><font color="#FFFFFF"> Listing  Your job in Careers at Justcalluz</font></td>--%>
   </tr>
   </table>
   </td>
  </tr>
  <tr>
   <td  class="side_menu"  style="padding-left:10px;" height="30"><span class="headings" ><font color="#CC0000">By Location</font></span></td>
   <td>&nbsp;</td>
  </tr>
  <tr>
   <td style="padding-left:5px;"><hr/></td>
  </tr>
  </table>
      
  <table width="100%" border="0">
   <tr>
   <td style="padding-left:12px;" colspan="2">
   <asp:Label ID="lblclick" runat="server" Text="click here to display jobDetails" ForeColor="#cc66ff">
   </asp:Label>
   </td>
   </tr>
   <tr>
    <td class="mid_menu" style="padding-left:13px; width:30%" align="left" valign="top">
   
      <asp:DataList ID="dlloc" runat="server" RepeatDirection="Vertical" 
            Font-Size="Small" DataKeyField="comp_city">
       <ItemTemplate>
         <%--<asp:HyperLink ID="hypCity" runat="server" NavigateUrl='<%# string.Format("Careers_Location.aspx?cityname=" + Eval("comp_city").ToString())%>' Text='<%#Eval("comp_city") %>'></asp:HyperLink>--%>
         <asp:HyperLink ID="hypCity" runat="server" NavigateUrl='<%# GetUrlCity(Eval("comp_city")) %>' Text='<%#Eval("comp_city") %>'></asp:HyperLink>
       </ItemTemplate>
      </asp:DataList>
    </td>
    <td style="padding-left:25px; width:70%" class="mid_menu" valign="top" align="left">        
      <asp:DataList ID="dllocation" runat="server" RepeatDirection="Vertical" 
            Font-Underline="true">
         <ItemTemplate>
             <ul type="disc">
             <li>
             <asp:HyperLink ID="hypTitle" runat="server" NavigateUrl='<%# GetUrlJob(Eval("jobid"))%>' Text='<%#Eval("title") %>'></asp:HyperLink>
             </li> 
            </ul>
      </ItemTemplate>
      </asp:DataList>
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

</div>
<script type="text/javascript">
<!--
swfobject.registerObject("FlashID");
//-->
</script>
    </div>
    </div>
    </form>
</body>
</html>
