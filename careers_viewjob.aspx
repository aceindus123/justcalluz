<%@ Page Language="C#" AutoEventWireup="true" CodeFile="careers_viewjob.aspx.cs" Inherits="viewjob" %>
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
 <link href="css/style.css" rel="stylesheet" type="text/css" />
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
  
 <div class="content_innermid" style="width:79%;">
   <table width="100%" border="0">
    <tr>
    <td style="background:url(images/Testimonials.png) no-repeat" height="36">
    <table width="100%" border="0">
  <tr>
    <td width="49%" class="bottam" style="padding-left:12px;"><font color="#FFFFFF" class="location">Careers at Justcalluz</font></td>
    <td width="5%"><asp:Image ID="Image1" AlternateText="SampleImage" ImageUrl="images/pencial.png" width="20" height="20" runat="server" /></td>
    <td width="46%"><font color="#FFFFFF"> Listing  Your job in Careers at Justcalluz</font></td>
  </tr>
  </table>
  </td>
   </tr>
    <tr>
    <td class="mid_menu" style="padding-left:5px;">
    <%-- <asp:LinkButton ID="lnkcate1" runat="server" Text="Job Categories" 
          PostBackUrl="careers_Department.aspx" Font-Underline="false" Font-Size="Small">
     </asp:LinkButton>&nbsp;&nbsp;&gt; 
     <asp:LinkButton ID="lnkcatelist" runat="server" Text="Jobs List by Category" 
           Font-Underline="false" Font-Size="Small" OnClick="lnkcatelist_Click">
     </asp:LinkButton>&nbsp;&nbsp;&gt;
     <asp:LinkButton ID="lnkviewjob" runat="server" Text="View Job"
           Enabled="false" ForeColor="Black" Font-Underline="false" Font-Size="Small">
     </asp:LinkButton>  --%>
     <a id="lnkcate1" href="careers_Department.aspx" style="font-size:small;">Job Categories</a>&nbsp;&nbsp;&gt;                            
     <a id="lnkcatelist" runat="server" style="font-size:small;" onserverclick="lnkcatelist_Click">Jobs List by Category</a>&nbsp;&nbsp;&gt;
     <asp:HyperLink ID="lnkviewjob" runat="server" Font-Size="Small" Font-Underline="false" 
             ForeColor="Black" Text="View Job"></asp:HyperLink>
   </td>
   </tr>
    <tr>
    <td>
    <table border="0" cellspacing="0" cellpadding="0" 
             style="border-top:1px solid Black; width: 100%; padding-left:7px;">
    <tr style="background-color:#D5E6F9;">
     <td align="center" valign="top" style="padding-left:4.5px; height:30px;">
     <span class="location" style="font-size:small">
     <font color="black">Job Information</font>
     </span> 
     </td>
    </tr>
    </table>
    </td>
    </tr>
</table>
<table width="100%" border="0" style="padding-left:7px;">
    <tr>
    <td>
     <asp:DataList ID="dlviewjob" runat="server" Width="100%" BackColor="#F0F8FF">
       <ItemTemplate>
        <table width="100%" border="0">
          <tr style="font-size:small; background-color:#D5E6F9;">
             <td align="right" style="width:160px; height:30px;">
                  Title
             </td>
             <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
              <td align="left">
                  <%#DataBinder.Eval(Container.DataItem, "title")%>
              </td>
          </tr>
           <tr style="font-size:small;">
              <td align="right" style="width:160px; height:30px;">
                  Category
              </td>
              <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
              <td align="left">
                  <%#DataBinder.Eval(Container.DataItem, "category")%>
              </td>
          </tr>
          <tr style="font-size:small; background-color:#D5E6F9">
              <td align="right" style="width:160px; height:30px;">
                  Specialization
              </td>
              <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
              <td align="left">
                  <%#DataBinder.Eval(Container.DataItem, "specialization")%></td>
          </tr>
          <tr style="font-size:small;">
              <td align="right" style="width:160px; height:30px;">
                  Job Type
              </td>
              <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
              <td align="left">
                  <%#DataBinder.Eval(Container.DataItem, "jobType")%>
              </td>
          </tr>
          <tr style="font-size:small; background-color:#D5E6F9">
              <td align="right" style="width:160px; height:30px;">
                  Job status
              </td>
              <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
               <td align="left">
                  <%#DataBinder.Eval(Container.DataItem, "jobStatus")%>
              </td>
          </tr>
          <tr style="font-size:small;">
              <td align="right" style="width:160px; height:30px;">
                  Work Experience
             </td>
             <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
              <td align="left">
                  <%#DataBinder.Eval(Container.DataItem, "workExp")%>
              </td>
          </tr>
          <tr style="font-size:small; background-color:#D5E6F9">
              <td align="right" style="width:160px; height:30px;">
                  Salary Range
              </td>
              <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
              <td align="left">
                  <%#DataBinder.Eval(Container.DataItem, "salRange")%>
              </td>
          </tr>
          <tr style="font-size:small;">
              <td align="right" style="width:160px; height:30px;">
                  No of Positions
             </td>
             <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
              <td align="left">
                  <%#DataBinder.Eval(Container.DataItem, "noOfvacancies")%>
              </td>
          </tr>
          <tr style="font-size:small; background-color:#D5E6F9">
              <td align="right" style="width:160px; height:30px;">
                  Date Posted
              </td>
              <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
              <td align="left">
                  <%#DataBinder.Eval(Container.DataItem, "posttime")%>
              </td>
          </tr>
          <tr style="font-size:small;">
              <td align="right" style="width:160px; height:30px;">
                  Job Description
              </td>
              <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
              <td align="left">
                <%#DataBinder.Eval(Container.DataItem, "jobDesc")%>
              </td>
          </tr>
          <tr style="font-size:small; background-color:#D5E6F9">
              <td align="right" style="width:160px; height:30px;">
                  Computer Knowledge
              </td>
              <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
              <td align="left">
                  <%#DataBinder.Eval(Container.DataItem, "computerknowledge")%>
              </td>
          </tr>
          <tr style="font-size:small;">
              <td align="right" style="width:160px; height:30px;">
                  Basic Education
              </td>
              <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
              <td align="left">
                  <%#DataBinder.Eval(Container.DataItem, "qualification")%>
              </td>
          </tr>
          <tr style="font-size:small; background-color:#D5E6F9">
              <td align="right" style="width:160px; height:30px;">
                  Company Information
              </td>
              <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
              <td align="left">
                  <table>
                      <tr style="font-size:small;">
                          <td align="left">
                              Address1<strong>&nbsp;:&nbsp;</strong><%#DataBinder.Eval(Container.DataItem, "comp_address1")%></td>
                      </tr>
                     
                      <tr style="font-size:small;">
                          <td align="left">
                              Address2<strong>&nbsp;:&nbsp;</strong><%#DataBinder.Eval(Container.DataItem, "comp_address2")%></td>
                      </tr>
                      <tr style="font-size:small;">
                          <td align="left">
                              State<strong>&nbsp;:&nbsp;</strong><%#DataBinder.Eval(Container.DataItem, "comp_state")%></td>
                      </tr>
                      <tr style="font-size:small;">
                          <td align="left">
                              City<strong>&nbsp;:&nbsp;</strong><%#DataBinder.Eval(Container.DataItem, "comp_city")%></td>
                      </tr>
                      <tr style="font-size:small;">
                          <td align="left">
                              Pin Code<strong>&nbsp;:&nbsp;</strong><%#DataBinder.Eval(Container.DataItem, "comp_pincode")%>
                          </td>
                      </tr>
                 </table>
               </td>
            </tr>
            <tr style="font-size:small;">
                  <td align="right" style="width:160px; height:30px;">
                      Contact Email
                  </td>
                  <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
                  <td align="left">
                      <%#DataBinder.Eval(Container.DataItem, "cont_email")%>
                  </td>
            </tr>
            <tr style="font-size:small; background-color:#D5E6F9">
                  <td align="right" style="width:160px; height:30px;">
                      Contact Info
                  </td>
                  <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
                  <td align="left">
                 <table>
                  <tr style="font-size:small;">
                      <td align="left">
                          <%#DataBinder.Eval(Container.DataItem, "contpersonName")%></td>
                         
                  </tr>
                  <tr style="font-size:small;">
                      <td align="left">
                          <%#DataBinder.Eval(Container.DataItem, "cont_phone")%>
                          <td align="right">
                              Ext<strong>&nbsp;:&nbsp;</strong></td>
                          <td align="right">
                              <%#DataBinder.Eval(Container.DataItem, "cont_ext")%></td>
                      </td>
                   </tr>
                  </table>
                   </td>
            </tr>
            <tr style="font-size:small;">
                  <td align="right" style="width:160px; height:30px;">
                    Job available till
                 </td>
                  <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
                  <td align="left">
                   <%#DataBinder.Eval(Container.DataItem, "exptime")%>
                 </td>
            </tr>
                 </table>
              </ItemTemplate>
            </asp:DataList>
            <br />
            <table width="100%">
            <tr>
             <td colspan="3" align="center"> 
              <asp:ImageButton ID="btnapply" AlternateText="Apply" runat="server" ImageUrl="images/Apply-Now.png" 
                OnClick="btnapply_Click1" />
             </td>
            </tr>
           </table>
         </td>
    </tr>
  </table> 
  </div>
         
 <div class="content_midbootam" >
  <aa5:bottomMidcontent ID="mid2" runat="server" />      
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
