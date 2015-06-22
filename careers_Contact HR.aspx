<%@ Page Language="C#" AutoEventWireup="true" CodeFile="careers_Contact HR.aspx.cs" Inherits="example6" %>
<%@ Register Src="usercontrols/signin.ascx" TagName="signin" TagPrefix="aa1" %>
<%@ Register Src="usercontrols/Search.ascx" TagName="catag" TagPrefix="aa6" %>
<%@ Register Src="usercontrols/footer1.ascx" TagName="footer1" TagPrefix="aa10" %>
<%@ Register Src="usercontrols/footer2.ascx" TagName="footer2" TagPrefix="aa11" %>
<%@ Register Src="usercontrols/BottomContent.ascx" TagName="bottomcontent" TagPrefix="aa4" %>
<%@ Register Src="usercontrols/BottomMidContent.ascx" TagName="bottomMidcontent" TagPrefix="aa5" %>
<%@ Register Src="usercontrols/Testimonials_Left.ascx" TagName="TestLeft" TagPrefix="aa15" %>
<%@ Register Src="usercontrols/SearchNew.ascx" TagName="SearchNew" TagPrefix="New" %>
<%@ Register Src="usercontrols/small_logo.ascx" TagName="logo" TagPrefix="S_logo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
  <%--<title>:: Justcalluz :: careers contact HR page</title>--%>
  <title>Contact HR | JustCalluz</title>
	<meta name='Title' content='Contact HR | JustCalluz' />
	<meta name='description' content='Contact human resources department of JustCalluz. Find contact addresses and numbers, email addresses and timings of JustCalluz HR departments in various cities.' />
	<meta name='keywords' content='JustCalluz HR, Contact JustCalluz HR, JustCalluz human resources' />
		
 <link href="css/style.css" rel="Stylesheet" type="text/css" />
  <link href="css/inner_style.css" rel="Stylesheet" type="text/css" />
 <script src="Scripts/swfobject_modified.js" type="text/javascript">
 </script>
     <style type="text/css">
         .style1
         {
             width: 69%;
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
  <aa1:signin ID="signIn1" runat="server" />
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
    <td width="49%" class="bottam" style="padding-left:12px;"><font color="#FFFFFF" class="location">
        Careers at Justcalluz</font></td>
    <td width="5%"><asp:Image ID="Image1" ImageUrl="images/pencial.png" width="20px" 
            height="20px" runat="server" /></td>
    <td width="46%"><font color="#FFFFFF"> Listing Your job in Careers at Justcalluz</font></td>
   </tr>
   </table>
   </td>
  </tr>
  <tr>
   <td class="side_menu"  style="padding-left:8px;font-family:Arial;font-weight:normal;font-size:200%; color:Black;" height="30">
   <%--<span class="location">
    <font color="black" size="4.5%">--%> 
       Contact HR<%--</font>
   </span>--%></td>
   <td>&nbsp;</td>
  </tr>
  <tr>
   <td style="padding-left:5px;"><hr/></td>
  </tr>
  </table>
      
  <table width="100%" border="0">
   <tr>
   <td style="padding-left:12px;" colspan="2">
   <asp:Label ID="lblclick" runat="server" Text="click here to display CompanyDetails" ForeColor="#cc66ff">
   </asp:Label>
   </td>
   </tr>
   <tr>
    <td class="mid_menu" style="padding-left:13px; width:40%" align="left" valign="top">
      <asp:DataList ID="dlloc" runat="server" RepeatDirection="Vertical" 
            Font-Size="Small" DataKeyField="comp_city">
       <ItemTemplate>
          <%--<asp:HyperLink ID="hypCity" runat="server" NavigateUrl='<%# string.Format("careers_Contact HR.aspx?cityname=" + Eval("comp_city").ToString())%>' Text='<%#Eval("comp_city") %>'></asp:HyperLink>--%>
          <asp:HyperLink ID="hypCity" runat="server" NavigateUrl='<%# GetUrlCity(Eval("comp_city")) %>' Text='<%#Eval("comp_city") %>'></asp:HyperLink>
       </ItemTemplate>
      </asp:DataList>
    </td>
    <td style="border-right:Solid Black; border-right-width:thin;">
     <%--<hr />--%>
    </td>
   
     <td style="padding-left:25px; width:60%" class="mid_menu" valign="top" align="left" runat="server">
      <asp:Panel ID="plDetails" runat="server" Width="90%"> 
       <table width="99%" border="0">
              <tr>
                <td align="left" class="style1" style="color:Black;">
                   <asp:DataList ID="dlContName" runat="server" Width="20%" RepeatDirection="Horizontal">
                       <ItemTemplate>
                        <asp:Label ID="lblcontpersonName" runat="server" Text='<%#Eval("contpersonName")%>' 
                                 ForeColor="Black" Font-Size="Small" Font-Names="Arial Baltic"></asp:Label>
                       </ItemTemplate>
                   <SeparatorTemplate>/</SeparatorTemplate>
                 </asp:DataList>
                 </td>
                </tr>
                 <tr id="compdetails" runat="server">
                   <td align="left" style="font-family:Arial Baltic;font-weight:lighter;color:Black;">
                         <asp:Label ID="lbladdress1" runat="server" Text='<%#Eval("comp_address1")%>' 
                              ForeColor="Black" Font-Size="Small"></asp:Label><br />
                           <asp:Label ID="lbladdress2" runat="server" Text='<%#Eval("comp_address2")%>' 
                                   ForeColor="Black" Font-Size="Small"></asp:Label>
                                
                           <asp:Label ID="lblstate" runat="server" Text='<%#Eval("comp_state")%>' 
                                   ForeColor="Black" Font-Size="Small"></asp:Label>
                           <asp:Label ID="lblcomma" runat="server" Text=","></asp:Label>
                            
                          <asp:Label ID="lblcity" runat="server" Text='<%#Eval("comp_city")%>' 
                                   ForeColor="Black" Font-Size="Small"></asp:Label>
                          <asp:Label ID="lbl" runat="server" Text="-"></asp:Label> 
                          
                           <asp:Label ID="lblcode" runat="server" Text='<%#Eval("comp_pincode")%>' 
                                   ForeColor="Black" Font-Size="Small"></asp:Label>
                   </td>
                  </tr>
                  <tr>
                   <td class="style1" style="font-family:Arial Baltic;">
                     <asp:DataList ID="dlEmail" runat="server" Width="100%">
                     
                       <ItemTemplate>
                        <asp:Label ID="lbleid" runat="server" Text="Email Id :" ForeColor="Black" 
                              Font-Size="Small"></asp:Label>
                               
                         <asp:Label ID="lblemail" runat="server" Text='<%#Eval("cont_email")%>' 
                              Font-Names="Arial" Font-Bold="false" Font-Size="Small"></asp:Label>
                       </ItemTemplate>
                       
                     </asp:DataList> 
                   </td>
                  </tr>
                 <tr id="phonedetails" runat="server">
                     <td align="left" class="style1">
                        <asp:Label ID="lblphone" runat="server" Text="Call :" ForeColor="Black" 
                              Font-Size="Small"></asp:Label>
                              
                        <asp:Label ID="lblphonenum" runat="server" Text='<%#Eval("cont_num")%>' 
                              ForeColor="Black" Font-Names="Arial" Font-Bold="false" 
                              Font-Size="Small"></asp:Label>
                              
                        <asp:Label ID="lblcont_ext" runat="server" Text="Ext :" ForeColor="Black" 
                              Font-Size="Small" Font-Names="Arial" Font-Bold="false"></asp:Label>
                              
                        <asp:Label ID="lblext" runat="server" Text='<%#Eval("cont_ext")%>' 
                              ForeColor="Black" Font-Names="Arial" Font-Bold="false" Font-Size="Small"></asp:Label>
                     </td> 
                  </tr> 
                  <tr>
                   <td align="left" class="style1">
                    <asp:Label ID="lblDate" runat="server" Text="Timings :" ForeColor="Black" 
                              Font-Size="Small" Font-Names="Arial"></asp:Label>
                              
                    <asp:Label ID="lblpDate" runat="server" Text='<%#Eval("time")%>' 
                              ForeColor="Black" Font-Names="Arial" Font-Bold="false" Font-Size="Small"></asp:Label>
                  </td>
                </tr>
          </table>
          </asp:Panel>
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
<div class="footer" align="center" style="padding-top:5px; " >
 <aa10:footer1 ID="footer1" runat="server" />
 <aa11:footer2 ID="footer2" runat="server" />
</div>

 </div>
   </div>
    </div>
    </form>
</body>
</html>
