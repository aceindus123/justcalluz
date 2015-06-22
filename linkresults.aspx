<%@ Page Language="C#" AutoEventWireup="true" CodeFile="linkresults.aspx.cs" Inherits="linkresults" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="AjaxToolkit" %>
<%@ Register Src="usercontrols/signin.ascx" TagName="signin" TagPrefix="aa1" %>
<%@ Register Src="usercontrols/topimage.ascx" TagName="topimage" TagPrefix="aa2" %>
<%@ Register Src="usercontrols/Search.ascx" TagName="catageories" TagPrefix="aa6" %>
<%--<%@ Register Src="usercontrols/discountright.ascx" TagName="discountright" TagPrefix="discright3" %>--%>
<%@ Register Src="usercontrols/footer1.ascx" TagName="footer1" TagPrefix="aa10" %>
<%@ Register Src="usercontrols/footer2.ascx" TagName="footer2" TagPrefix="aa11" %>
<%@ Register Src="usercontrols/SearchNew.ascx" TagName="newsearch" TagPrefix="nsearch"%><%@ Register Src="usercontrols/SponsoredLinks.ascx" TagName="Splinks" TagPrefix="aa3" %>
<%@ Register Src="usercontrols/BottomContent.ascx" TagName="bottomcontent" TagPrefix="aa4" %>
<%@ Register Src="usercontrols/BottomMidContent.ascx" TagName="bottomMidcontent" TagPrefix="aa5" %>
<%@ Register Src="usercontrols/linkcontroll_innerleft.ascx" TagName="innerleft" TagPrefix="link_innerleft" %>
<%@ Register Src="usercontrols/small_logo.ascx" TagName="logosmall" TagPrefix="lgsmall" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <%--<title>Justcalluz - Search Results Page</title>--%>
  <title id="pgtitle" runat="server"></title>
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
     .style23
     {
         width: 103px;
         height: 83px;
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

<link href="starrater.css" type="text/css" rel="Stylesheet" />
<link href="css/style.css" rel="stylesheet" type="text/css" />
<link href="css/inner_style.css" rel="stylesheet" type="text/css" />
</head>
<body>
  <form id="form1" runat="server">    
   <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePageMethods="true">
    </asp:ScriptManager>
    <div class="layout">
<%--<asp:UpdatePanel ID="UpdatePanel1" runat="server">
 <ContentTemplate>  
<table width="100%" border="0" align="center">
<tr>
<td>--%>
<div class="signin">
<aa1:signin ID="SignIn1" runat="server" />
</div>
<div class="header">
<div class="header_logo">
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
<link_innerleft:innerleft ID="content_inner" runat="server" />
</div>
<!-- ending the left -->
<div class="content_innermid">
<div class="contentmid_boxtop"><a href="<%$RouteUrl:RouteName=HomeRoute%>" style="text-decoration:none;color:White" runat="server">Home>></a><asp:Label ID="Label11"
      runat="server" Text="Popular Search Categories"></asp:Label></div>
<div class="contentmid_boxmid">
<table width="100%" border="0">
<tr>
<td height="30" colspan="4" align="center" class="headings" style="padding-right:5px;">
Your search for&nbsp; "<strong><asp:Label ID="Label10" runat="server" CssClass="mid_menu"></asp:Label></strong>"&nbsp; located in &nbsp;"
    <strong><asp:Label ID="Label12" runat="server" CssClass="mid_menu"></asp:Label></strong>"&nbsp;</td>
</tr>
<tr>
<td align="center" valign="top" style="padding-top:10px" colspan="4">
<asp:DataList ID="dlSearchResults" DataKeyField="id" runat="server" Width="100%"
    style="margin-left: 0px" onitemdatabound="dlSearchResults_ItemDataBound" >
      <HeaderTemplate> 
      </HeaderTemplate>
      <ItemTemplate> 
      <table width="100%" border="0">  
      <%--<tr><td height="4px"></td></tr>--%>
         <tr>
            <td style="background:url(images/event_send03.png) no-repeat; height:200px;" valign="top">    
            <table width="100%" border="0">  
               <tr>
                    <td valign="middle" width="50%" colspan="2" class="sub_menu" style="padding-left:8px; padding-top:5px;">
                       <%-- <asp:HyperLink ID="hypCompName" runat="server" Text='<%# Eval("compname") %>' ToolTip='<%# Eval("company_name") %>'
                           NavigateUrl='<%# string.Format("sessionstore.aspx?id=" + Eval("id").ToString()+"&cname="+Eval("company_name").ToString()) %>'></asp:HyperLink>--%>
                      <asp:HyperLink ID="hypCompName" runat="server" Text='<%# Eval("compname") %>' ToolTip='<%# Eval("company_name") %>'
                           NavigateUrl='<%# GetViewUrl(Eval("id")) %>'></asp:HyperLink>
                    </td> 
                    <td width="35%" style="padding-left:4px; padding-top:5px;" height="20" colspan="2" align="left">
                        <asp:Label ID="lblDataId" runat="server" Text='<%#Eval("id")%>' Visible="false"></asp:Label>         
                        <asp:Label ID="lblStarRating" runat="server" CssClass="ui-rater">
                            <asp:Label ID="Label2" runat="server" CssClass="ui-rater-starsOff" Width="90px" >
                                <asp:Label ID="testSpan0" runat="server" CssClass="ui-rater-starsOn">
                                </asp:Label>
                            </asp:Label>            
                        </asp:Label>&nbsp;
                          <span class="sub_menu" style="color:Black"><asp:Label ID="lblnoofratings" runat="server"></asp:Label>&nbsp; ratings</span>
                    </td>
                    <td width="15%" class="sub_menu" style="padding-top:5px; padding-right:8px">                                    
                        <asp:HyperLink ID="lnkBtnRatethis" runat="server"  NavigateUrl='<%# string.Format("PostReviewCat-" + Eval("id").ToString()) %>'>Rate This</asp:HyperLink> 
                        <%--<asp:HyperLink ID="lnkBtnRatethis" runat="server" NavigateUrl='<%# GetRatingUrl(Eval("id")) %>'>Rate This</asp:HyperLink>--%>                                            
                                                                   
                    </td>
                </tr>
                <%--<tr><td colspan="3" height="10px"></td></tr>--%>
               <tr class="side_menu">
                      <td width="23%" rowspan="3" style="padding-bottom:20px; padding-top:5px;" id="tdlogo" runat="server" visible="false" align="center">
                           <asp:Label ID="lblImgName" runat="server" Text='<%# Eval("ImageName") %>' Visible="false"></asp:Label>
                           <asp:Image  ID="imgReviewer" AlternateText="images" runat="server" ImageUrl='<%# Eval("ImageName", "../Event_Images\\{0}") %>' 
                                Width="99"  Height="68"/>
                        </td>
                        <td style="padding-left:5px; height:30px; padding-top:5px;" colspan="4" align="left">
                            <asp:Label ID="lbladdress" runat="server" Text ='<%# Eval("address") %>'></asp:Label>
                            <asp:Label ID="lblcomma" runat="server" Text=","></asp:Label>
                            <asp:Label ID="lblcity" runat="server" Text ='<%# Eval("City") %>'></asp:Label>
                            <asp:Label ID="lblcomma1" runat="server" Text=","></asp:Label>
                            <asp:Label ID="lblstate" runat="server" Text ='<%# Eval("State") %>'></asp:Label>
                             <asp:Label ID="lblcomma2" runat="server" Text=","></asp:Label>
                            <asp:Label ID="lblpincode" runat="server" Text ='<%# Eval("Pincode") %>'></asp:Label>
                        </td>
                 </tr>
                 <tr>
                        <td  style="padding-left:5px; height:30px;" colspan="4" align="left" class="side_menu">
                            Contact&nbsp;:&nbsp;<asp:Label ID="lblmob" runat="server" Text ='<%# Eval("contact_person") %>'></asp:Label>&nbsp;|
                            <asp:Label ID="lbllandphone" runat="server" Text ='<%# Eval("mob") %>'></asp:Label>
                        </td>
                 </tr>
                 <tr>
                 </tr>
                 <tr><td colspan="4">&nbsp;</td></tr>
                 <tr><td colspan="4">&nbsp;</td></tr>
                  <tr><td colspan="6" style="width:100%; height:30px;">
                       <table width="100%" border="0">
                          <tr>
                             <td width="408" align="left" style="padding-left:8px;"><asp:ImageButton ID="img1" AlternateText="btnSend" ImageUrl="images/send-_button.png" runat="server" width="120" height="24" PostBackUrl='<%# GetViewUrl(Eval("id")) %>'/></td>
                            <td width="84" align="left" valign="top"><asp:HyperLink ID="hyp1" runat="server" Text="View Details" NavigateUrl='<%# GetViewUrl(Eval("id")) %>'></asp:HyperLink></td>
                            <td width="9" align="left" valign="top"><asp:Label ID="lblSlash" runat="server" Text="|"></asp:Label></td>
                            <td width="81" align="left" valign="top"><asp:LinkButton ID="lnkmap" runat="server" ForeColor="#003366" CommandArgument='<%# Eval("id") %>' CssClass="pointer" 
                                           OnCommand="lnkmap_Click">View Map</asp:LinkButton> </td>
                          </tr>
                       </table></td></tr>
                <%-- <tr>
                     <td  style="padding-right:10px; height:30px;" colspan="6" align="right">
                      <asp:ImageButton ID="img1" AlternateText="btnsend" runat="server" ImageUrl="images/send-_button.png" PostBackUrl='<%# GetCompUrl(Eval("id"),Eval("company_name")) %>' />
                      <span class="side_menu"><asp:HyperLink ID="lnkmap" runat="server" ForeColor="#003366" CssClass="pointer">View Map</asp:HyperLink></span>&nbsp;|&nbsp;<asp:HyperLink ID="hyp1" runat="server" Text="View Details"  NavigateUrl='<%# GetCompUrl(Eval("id"),Eval("company_name")) %>'></asp:HyperLink>
                      <asp:HyperLink ID="hyp1" runat="server" Text="View Details"  NavigateUrl='<%# "sessionstore.aspx?id=" + Eval("id").ToString() %>'></asp:HyperLink>
                     </td>
                   </tr>--%>
            </table> 
       </td>
      </tr>
     </table>
    <%-- <AjaxToolkit:ModalPopupExtender ID="ModalPopupExtender4" runat="server" TargetControlID="lnkmap" BackgroundCssClass="modalbackground" PopupControlID="pnlmap" DropShadow="false" CancelControlID="cancel">
          </AjaxToolkit:ModalPopupExtender> --%>                              
   </ItemTemplate>
    <FooterTemplate>  
            
    </FooterTemplate>
 </asp:DataList>
 </td></tr>
 <asp:Button ID="btnmap" runat="server" style="display:none;" />
  <AjaxToolkit:ModalPopupExtender ID="ModalPopupExtender3" runat="server" TargetControlID="btnmap" BackgroundCssClass="modalbackground" PopupControlID="pnlmap" DropShadow="false" CancelControlID="cancel">
          </AjaxToolkit:ModalPopupExtender>   
 <tr><td>&nbsp;</td></tr>
<tr id="trPaging" runat="server">
<td colspan="4" align="right" style="padding-right:7px;">
    <asp:ImageButton ID="imgPrevious" runat="server" AlternateText="btnPrevious" ImageUrl="images/arrow_2.png" OnClick="imgPrevious_Click"/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:ImageButton ID="imgNext" runat="server" AlternateText="btnNext" ImageUrl="images/arrow_1.png" OnClick="imgNext_Click" />
 </td>
</tr>
<tr>
<td>
    <asp:Label ID="lblDatanotfound" runat="server"></asp:Label>
</td>
</tr>
<tr>
  <td>
    <asp:Panel ID="pnlmap" runat="server">
     <fieldset>
     <asp:DataList ID="dlmap" runat="server" DataKeyField="id">
     <ItemTemplate>
     <table border="0" width="100%">
     <tr>
      <td width="60%" class="bottam"><strong class="side_menu">
            <%#DataBinder.Eval(Container.DataItem, "map")%>
            </strong></td>
     </tr>
     </table>
     </ItemTemplate>
     </asp:DataList>
         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
     <asp:Button ID="cancel" runat="server" Text="Close" BackColor="#16C56E" />
     </fieldset></asp:Panel>
   </td>
</tr>
</table>
</div>
<div class="contentmid_boxbottam"></div>
</div>
<div class="content_innerright">
<div class="contentbox_top">Sponsor Ads</div>
<div class="contentbox_mid">
<table width="100%" border="0">
<tr>
 <td class="right_tab">
<!-- begin the right -->
<aa3:Splinks id="splinks1" runat="server" />       
 </td>
</tr>
</table>
<!--end of 3 column-->
</div>
<div class="contentbox_bottam"></div>
</div>
<div class="content_midbootam" >
<aa5:bottomMidcontent ID="mid1" runat="server" />
</div>
</div>
<div class="content_bootam_center">
<aa4:bottomcontent ID="bottomcontent1" runat="server" />
</div>
<div class="footer" align="center">
<aa10:footer1 ID="bvu" runat="server" />
<aa11:footer2 ID="ayh" runat="server" />
</div>
<%--</td>
</tr>
</table>
</ContentTemplate>
</asp:UpdatePanel>--%>
</div>
 </form>
</body>
</html>
