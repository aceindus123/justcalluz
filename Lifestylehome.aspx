<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Lifestylehome.aspx.cs" Inherits="Lifestylehome" %>
<%@ Register Src="usercontrols/lifestyleleft.ascx" TagName="life" TagPrefix="left" %>
<%@ Register Src="usercontrols/footer1.ascx" TagName="footer1" TagPrefix="aa10" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="AjaxToolkit" %>
<%@ Register Assembly="MSCaptcha" Namespace="MSCaptcha" TagPrefix="cc1" %>
<%@ Register Src="usercontrols/footer2.ascx" TagName="footer2" TagPrefix="aa11" %>
<%@ Register Src="usercontrols/Search.ascx" TagName="catag" TagPrefix="aa6" %>
<%@ Register Src="usercontrols/signin.ascx" TagName="signin" TagPrefix="sig" %>
<%@ Register Src="usercontrols/BottomContent.ascx" TagName="Bottomcontent" TagPrefix="bcon" %>
<%@ Register Src="usercontrols/BottomMidContent.ascx" TagName="Contentmid" TagPrefix="bcm" %>
<%@ Register Src="usercontrols/SearchNew.ascx" TagName="SearchNew" TagPrefix="New" %>
<%@ Register Src="usercontrols/small_logo.ascx" TagName="logo" TagPrefix="S_logo" %>
<%@ Register Src="usercontrols/SponsoredLinks.ascx" TagName="Sp_Links" TagPrefix="spLinks_Right" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title id="pgtitle" runat="server"></title>
<link href="css/style.css" rel="stylesheet" type="text/css" />
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
<link href="css/inner_style.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="layout">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <div class="layout">
<div class="signin">
<sig:signin ID="sig1" runat="server" />
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
<div class="content" style="padding:0; margin:0;">
<!-- start the inner left-->
<div class="content_innerleft">
<div class="contentbox_top">Lifestyle</div>
<div class="contentbox_mid" style="padding:none">
<left:life ID="lifestyleleft" runat="server" />
 </div>
<div class="contentbox_bottam"></div>
</div>
<!-- end of the inner left-->
<!-- start the mid Box-->
  <div class="content_innermid">
  <div class="contentmid_boxtop"><a href="<%$RouteUrl:RouteName=HomeRoute%>" style="color:White;" runat="server">Home</a>&gt;&gt; Lifestyle</div>
  <div class="contentmid_boxmid">
  <table width="537px" border="0">
  <tr>
    <td  height="30" align="center" class="headings" style="font-family:Arial;">Result for&nbsp;:&nbsp;&nbsp;<asp:Label ID="LifestyleCate" runat="server"></asp:Label></td>
    
  </tr>
   <tr>
    <td align="right"><asp:HyperLink ID="post" runat="server" Text="Advertise your company" Font-Size="11px" NavigateUrl="<%$RouteUrl:RouteName=PostLife,cname=LifeStyle%>" CssClass="side_menu" Font-Bold="true" ForeColor="Red" ></asp:HyperLink></td>
  </tr>
  <tr><td>
  <asp:DataList ID="dllifestyle" DataKeyField="SubCategory" runat="server" Width="520px" OnItemDataBound="dllifestyle_ItemDataBound" Visible="true">
  <ItemTemplate>
     <table width="100%" border="0">
               <tr>
                <td  style="background:url(images/event_send03.png) no-repeat; width:500px; height:200px;" valign="top">
                 <div style="padding: 0px; margin: 0px;">
                   <table width="560px" border="0">
                    <tr><td style="font-family:Arial;">
                    <asp:Label ID="notfound" runat="server" Text="Sorry ! No details available" Font-Names="MonotypeCorsiva" ForeColor="Red" Font-Size="Medium" Visible="false"></asp:Label>
                    </td></tr>
                    <tr>
                    <td width="40%" class="headings" style="font-family:Arial;">&nbsp;&nbsp;
                    <%--  <asp:HyperLink  ID="hypCompName" ForeColor="Red" runat="server" NavigateUrl='<% #string.Format("LifeStyle_details.aspx?id=" + Eval("id").ToString())%>' 
                            Text ='<%# Eval("compname") %>' ToolTip='<%# Eval("company_name") %>'></asp:HyperLink>--%>
                       <asp:HyperLink  ID="hypCompName" ForeColor="Red" runat="server" NavigateUrl='<%# GetLifeDetailsUrl(Eval("id"))%>' 
                            Text ='<%# Eval("compname") %>' ToolTip='<%# Eval("company_name") %>'></asp:HyperLink>
                   </td>
                   <td width="35%" style="padding-left:4px; padding-top:5px; padding-right:8px;" height="20" colspan="2" align="right">
                   <asp:Label ID="lblDataId" runat="server" Text='<%#Eval("id")%>' Visible="false"></asp:Label>         
                   <asp:Label ID="lblStarRating" runat="server" CssClass="ui-rater">
                   <asp:Label ID="Label2" runat="server" CssClass="ui-rater-starsOff" Width="90px" >
                    <asp:Label ID="testSpan0" runat="server" CssClass="ui-rater-starsOn">
                    </asp:Label>
                </asp:Label>            
            </asp:Label>&nbsp;
              <span class="sub_menu" style="color:Black"><asp:Label ID="lblnoofratings" runat="server"></asp:Label>&nbsp; ratings</span>
             </td>
              </tr>
               <tr>
                    <td style="height:5px" colspan="2"></td>
                </tr>
                <tr>
                 <td colspan="0">
                 <table border="0" width="100%">
                 <tr>
                 <td width="20%" id="tdlogo" runat="server" rowspan="6" valign="top" style="padding-top:3px; padding-left:5px;" >&nbsp;&nbsp;
                 <asp:Label ID="lblImgName" runat="server" Text='<%#Eval("ImageName")%>' Visible="false"></asp:Label>
                 <asp:Image  ID="imglogo"  runat="server" AlternateText="companyLogo" ImageUrl='<%# Eval("ImageName", "../Logos\\{0}") %>'  Width="100"  Height="85"/></td>
                    <td height="20" style="font-family:Arial;"><%--<p>--%>
                    <strong class="side_menu">Location</strong>&nbsp;:<span class="headings1"><asp:Literal ID="Literal2" runat="server" Text='<%#Eval("address")%>' /></span><%--</p>--%></td>
                 </tr>
                 <tr><td style="font-family:Arial;padding-left:5px;" width="80%" height="30"><asp:Image ID="imgmob" runat="server" ImageUrl="images/phone.png" />
                  &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Literal ID="Literal1" runat="server" Text='<%#Eval("mob")%>'></asp:Literal></td></tr>
                  <tr><td align="left" style="font-family:Arial;padding-left:5px;" height="30"><asp:Image ID="imgmail" runat="server" ImageUrl="~/images/mail1.png" />
                  &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Literal ID="Literal4" runat="server" Text='<%#Eval("emailid")%>'></asp:Literal> </td>
                  </tr>
                   <tr><td height="30" style="font-family:Arial;">
                    <strong class="side_menu">City</strong>&nbsp;:<span class="headings1"><asp:Literal ID="Literal3" runat="server" Text='<%#Eval("city")%>' /></span></td>
                  </tr>
                  <tr>
                   <td height="30" colspan="8" align="left" style="font-family:Arial;padding-left:5px;">
                    <table border="0" width="100%">
                   <%-- <tr>
                    <td></td>
                    <td colspan="5" style="padding-left:5px;"><asp:Literal ID="Literal3" runat="server" Text='<%#Eval("city")%>'></asp:Literal></td>
                    </tr>--%>
                    <tr>
                    <td>&nbsp;</td>
                    <td align="right" colspan="8" style="padding-right:8px;padding-bottom:10px;">
                     <asp:HyperLink ID="lnkdetails" runat="server" Text="ViewDetails" NavigateUrl='<%# GetLifeDetailsUrl(Eval("id"))%>' ForeColor="Brown"></asp:HyperLink></td>
                    </tr>
                    </table>
                 </td>
                 </tr>
                </table>
                </td></tr>
               </table>           
              </div>
             </td>
           </tr>
          </table>
  </ItemTemplate>
 </asp:DataList>
 </td></tr>
 <tr>
    <td colspan="3">
    <table border="0" width="100%" id="trpagesize" runat="server">
  <tr><td>&nbsp;</td></tr>
  <tr id="trPaging" runat="server">
  <td align="right" style="padding-right:8px;">
    <asp:ImageButton ID="imgPrevious" runat="server" AlternateText="btnPrevious" ImageUrl="images/arrow_2.png" OnClick="imgPrevious_Click"/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:ImageButton ID="imgNext" runat="server" AlternateText="btnNext" ImageUrl="images/arrow_1.png" OnClick="imgNext_Click" />
  </td>
 </tr>
</table></td>
  </tr>
  </table></div>
  <div class="contentmid_boxbottam"></div>
 </div>
<!-- end of the mid Box-->  
<div class="content_innerright">
<%--<div class="contenbox">--%>
<div class="contentbox_top">Sponsor Ads</div>
<div class="contentbox_mid">
  <table width="100%" border="0">
    <tr>
      <td valign="top" class="right_tab">
       <spLinks_Right:Sp_Links ID="Ads" runat="server" />
      </td>
    </tr>
    <tr>
      <td></td>
    </tr>
   
  </table>
</div>
<div class="contentbox_bottam"></div>
<%--<div class="contentbox_top">Sponsor Ads</div>
<div class="contentbox_mid">
  <table width="100%" border="0">
    <tr>
      <td width="100%" valign="top">
      
      <img src="images/lifestyleadd2 (1).png" alt="LifestyleAds" width="175" height="600" /><br />
      <img src="images/lifestyleadd2 (2).png" alt="LifestyleAds" width="175" height="300" /><br />
      </td>
    </tr>
    <tr>
      <td></td>
    </tr>
   
  </table>
</div>
<div class="contentbox_bottam"></div>--%>
<%--</div>--%></div>
</div>
<div class="content_midbootam" >
<bcm:contentmid ID="contentmid" runat="server" />
</div>
<div class="content_midbootam" ><table width="100%" border="0">
  <tr>
    <td height="" ></td>
  </tr>
</table>
</div>
<div class="content_bootam_center">
<bcon:bottomcontent ID="bottomcontent" runat="server" />

</div>


<div class="footer" align="center" style="padding-top:5px; " >
    <aa10:footer1 ID="sdsa" runat="server" />
    <aa11:footer2 ID="poshv" runat="server" />
</div>
  </div>
  </div>

    </form>
</body>
</html>


