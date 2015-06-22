<%@ Page Language="C#" AutoEventWireup="true" CodeFile="careers_jobcategorylist.aspx.cs" Inherits="careers_jobcategorylist" %>
<%@ Register Src="usercontrols/signin.ascx" TagName="signin" TagPrefix="aa1" %>
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
  <title id="pgtitle" runat="server"></title>
 <link href="css/style.css" rel="Stylesheet" type="text/css" />
 <link href="css/inner_style.css" rel="Stylesheet" type="text/css" />
 <script src="Scripts/swfobject_modified.js" type="text/javascript">
 </script>
         <style type="text/css">
             .style1
             {
                 width: 351px;
             }
             .style2
             {
                 width: 163px;
             }
             .style3
             {
                 width: 39%;
             }
             .style4
             {
                 font-family: Verdana, Geneva, sans-serif;
                 font-size: 12px;
                 font-weight: bold;
                 color: #004080;
                 width: 39%;
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
     <td style="background:url(images/Testimonials.png) no-repeat" height="36" 
            class="style3">
    <table width="100%" border="0">
    <tr>
     <td width="49%" class="bottam" style="padding-left:12px;">
     <font color="#FFFFFF" class="location">Careers at Justcalluz</font></td>
     <td width="5%">
     <asp:Image ID="Image2" AlternateText="SampleImage" ImageUrl="images/pencial.png" width="20" height="20" runat="server"/></td>
     <td width="46%"><font color="#FFFFFF"> Listing  Your job in Careers at Justcalluz</font></td>
   </tr>
  </table>
  </td>
  </tr>
   <tr>
    <td class="style4" style="padding-left:5px;">
    <a id="lnkcate1" href="<%$RouteUrl:RouteName=CareersDepartment %>" style="font-size:small;" runat="server">Job Categories</a>&nbsp;&nbsp;&gt;
    <asp:HyperLink ID="lnkcatelist" runat="server" Text="Jobs List by Category" Font-Underline="false" Font-Size="Small"></asp:HyperLink>
   </td>
   </tr>
   <tr id="trcat" runat="server">
   <td class="style3">
      <table border="0" cellspacing="0" cellpadding="0" 
                 style="border-top:1px solid Black; width: 100%; padding-left:4.5px; height:30px;">
        <tr style="background-color:#D5E6F9; padding-left:4.5px;">
         <td align="center" valign="middle" >
          <span class="location" style="font-size:small;">
         <font color="black">Category :</font>
         <asp:Label ID="lblcategory" runat="server" ForeColor="Black"></asp:Label></span>
        </td>
        </tr>
      </table>
    </td>
    </tr>
    <tr id="trcate" runat="server">
    <td align="center">
     SortBy :&nbsp;
       <a id="lnkTitle" runat="server" onserverclick="lnkTitle_Click" style="font-size:small;">Title</a> &nbsp; |
       <a id="lnkJobType" runat="server" onserverclick="lnkJobType_Click" style="font-size:small;">Job Type</a> &nbsp; |
       <a id="lnkJobStatus" runat="server" onserverclick="lnkJobStatus_Click" style="font-size:small;">Job Status</a> &nbsp; |
       <a id="lnkSalaryRange" runat="server" onserverclick="lnkSalaryRange_Click" style="font-size:small;">Salary Range</a> &nbsp; |  
       <a id="lnkDatePosted" runat="server" onserverclick="lnkDatePosted_Click" style="font-size:small;">Date Posted</a> 
    </td>
   </tr>
   <tr>
   <td>
     <asp:Label ID="lblMessage" runat="server" Visible="false"></asp:Label>
   </td>
  </tr>
   <tr>
  <td valign="top" colspan="4" class="side_menu" align="center">
  <table width="100%" border="0">
  <asp:DataList ID="dlcategorylist" RepeatDirection="Vertical" CellPadding="1" runat="server" 
          Height="170px" Width="100%" BackColor="#D5E6F9" AlternatingItemStyle-BackColor="AliceBlue" 
          ForeColor="Black" DataKeyField="jobid"> 
      <HeaderTemplate>
      </HeaderTemplate>
      <ItemTemplate>
      <table width="100%" border="0" style="height:160px;">
         <tr>
             <td align="left" style="width:18%;">
                  Title</td>
              <td align="left"><strong>&nbsp;:&nbsp;</strong></td>
              <td align="left" style="width:30%;font-family:Arial;font-weight:lighter; font-size:small;">
                  <%#DataBinder.Eval(Container.DataItem, "title")%>
              </td>
              
              
          <td align="left" style="width:23%;">
              Specialization</td>
           <td align="left"><strong>&nbsp;:&nbsp;</strong></td>
          <td align="left" style="width:25%;font-family:Arial;font-weight:lighter;font-size:small;">
              <%#DataBinder.Eval(Container.DataItem, "specialization")%>
         </td>
         </tr>
          <tr>
              <td align="left" style="width:18%;">
                  Job Type</td>
               <td align="left"><strong>&nbsp;:&nbsp;</strong></td>
              <td align="left" style="width:30%; font-family:Arial;font-weight:lighter;font-size:small;">
                  <%#DataBinder.Eval(Container.DataItem, "jobType")%>
              </td>
             
              <td align="left" style="width:23%;">
                  Job status</td>
                <td align="left"><strong>&nbsp;:&nbsp;</strong></td>
               <td align="left" style="width:25%; font-family:Arial;font-weight:lighter;font-size:small;">
                  <%#DataBinder.Eval(Container.DataItem, "jobStatus")%>
              </td>
           </tr>  
           <tr>
              <td align="left" style="width:18%;">
                  Date Posted</td>
               <td align="left"><strong>&nbsp;:&nbsp;</strong></td>
              <td align="left" style="width:30%; font-family:Arial;font-weight:lighter;font-size:small;">
                  <%#DataBinder.Eval(Container.DataItem, "posttime")%>
              </td>
         
              <td align="left" style="width:23%;">
                  No of Positions</td>
               <td align="left"><strong>&nbsp;:&nbsp;</strong></td>
              <td align="left" style="width:25%; font-family:Arial;font-weight:lighter;font-size:small;">
                  <%#DataBinder.Eval(Container.DataItem, "noOfvacancies")%>
              </td>
          </tr>
          <tr>
           <td align="left" style="width:18%;">
                State</td>
            <td align="left"><strong>&nbsp;:&nbsp;</strong></td>
          <td align="left" style="width:30%; font-family:Arial;font-weight:lighter;font-size:small;">
              <%#DataBinder.Eval(Container.DataItem, "comp_state")%>
         </td>
        
          <td align="left" style="width:23%;">
                 City</td>
           <td align="left"><strong>&nbsp;:&nbsp;</strong></td>
          <td align="left" style="width:25%; font-family:Arial;font-weight:lighter;font-size:small;" >
             <%#DataBinder.Eval(Container.DataItem, "comp_city")%>
         </td>
         </tr>
         <tr>
         <td colspan="6">
           <table width="100%" border="0">
             <tr><td align="right" style="padding-right:5px;">
            <asp:ImageButton ID="lnkView" runat="server" ImageUrl="images/View-1.png" 
               CommandArgument='<%#Eval("jobid")%>' CommandName="select" 
                PostBackUrl='<%# GetUrlJob(Eval("jobid")) %>' />&nbsp;&nbsp;

             <asp:ImageButton ID="lnkApplyNow" runat="server" ImageUrl="images/Apply-Now.png"
              CommandArgument='<%#Eval("jobid")%>'
              CommandName="select" PostBackUrl='<%# GetUrl(Eval("jobid")) %>' />
             </td></tr>
           </table>
         </td>
       </tr>
      </table>
    </ItemTemplate>
   </asp:DataList>
  </table>
  </td>
  </tr>
   <tr id="trline" runat="server">
   <td>
   <table width="99%">
   <tr>
        <td style="padding-left:15px;" class="style3">
           <hr />
        </td>
     </tr>
   </table>
   </td>
   </tr> 
   <tr>
   <td class="style4" id="trpaging" runat="server">
   <table width="100%" border="0">
   <tr><td>&nbsp;</td></tr>
       <tr>
         <td align="right">
          <asp:ImageButton ID="imgPrevious" runat="server" AlternateText="btnPrevious" ImageUrl="images/arrow_2.png" OnClick="imgPrevious_Click"/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
          <asp:ImageButton ID="imgNext" runat="server" AlternateText="btnNext" ImageUrl="images/arrow_1.png" OnClick="imgNext_Click" />
         </td>
       </tr>
      </table> 
      </td>
     </tr>
     <tr> 
      <td class="style3" id="trpagesize" runat="server">
     <table width="100%" border="0">
     <tr>
      <td class="style2" align="left" style="padding-left:15px;">
        display# &nbsp;
        <asp:DropDownList ID="ddlPageSize" runat="server" AutoPostBack="true" 
               OnSelectedIndexChanged="ddlPageSize_SelectedIndexChanged" Visible="true">
            <asp:ListItem Value="5">5</asp:ListItem>
            <asp:ListItem Value="10">10</asp:ListItem>
            <asp:ListItem Value="15">15</asp:ListItem>
            <asp:ListItem Value="20">20</asp:ListItem>
            <asp:ListItem Value="25">25</asp:ListItem>
            <asp:ListItem Value="30">30</asp:ListItem>
            <asp:ListItem Value="35">35</asp:ListItem>
            <asp:ListItem Value="50">50</asp:ListItem>
            <asp:ListItem Value="100">100</asp:ListItem>
            <asp:ListItem Value="1">All</asp:ListItem>
       </asp:DropDownList>
       </td>
       <td align="center" class="style1">
       </td>
         <td style="padding-right:8px;" align="right">
          <asp:Label ID="lblCurrentPage" runat="server"></asp:Label>
        </td>
        </tr>
      </table> 
       </td>
    </tr>
  </table>
  </div>
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
   </form>
</body>
</html>
