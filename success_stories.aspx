<%@ Page Language="C#" AutoEventWireup="true" CodeFile="success_stories.aspx.cs" Inherits="success_stories" %>
<%@ Register Src="usercontrols/footer1.ascx" TagName="footer1" TagPrefix="aa10" %>
<%@ Register Src="usercontrols/footer2.ascx" TagName="footer2" TagPrefix="aa11" %>
<%@ Register Src="usercontrols/BottomContent.ascx" TagName="bottomcontent" TagPrefix="aa4" %>
<%@ Register Src="usercontrols/BottomMidContent.ascx" TagName="bottomMidcontent" TagPrefix="aa5" %>
<%@ Register Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" TagPrefix="cc3"  %>
<%@ Register Src="usercontrols/media_left.ascx" TagName="lftmedia" TagPrefix="lmedia" %>
<%@ Register Src="usercontrols/SearchNew.ascx" TagName="SearchNew" TagPrefix="New" %>
<%@ Register Src="usercontrols/small_logo.ascx" TagName="logo" TagPrefix="S_logo" %>
<%@ Register Src="usercontrols/signin.ascx" TagName="signin" TagPrefix="aa1" %>
<%@ Register Src="usercontrols/Search.ascx" TagName="catag" TagPrefix="aa6" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<%--<title>Just Calluz | Success Stories</title>--%>
<title id="pgtitle" runat="server"></title>
<link href="css/inner_style.css" rel="stylesheet" type="text/css" />
<link href="css/style.css" rel="Stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
 <div class="layout">
<div class="signin">
<aa1:signin ID="suy" runat="server" />
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
<!-- start The Content-->
<div class="content" style="padding:0; margin:0;">
<div class="content_innerleft">
<lmedia:lftmedia ID="leftmedia" runat="server" />
</div>
<div class="content_innermid" style="width:78.4%;">
  <table width="790px" border="0" style="padding-left:15px;">
    <tr>
      <td style="border-bottom:2px solid #C90"><h1>Success Stories</h1></td>
    </tr>
    <tr>
      <td><table width="100%" border="0">
        <tr>
          <td colspan="2" height="30" align="right"><h2><a href="<%$RouteUrl:RouteName=successVideos %>" runat="server">Success Videos</a>&nbsp;|&nbsp;<a href="<%$RouteUrl:RouteName=success %>" runat="server">Success Stories</a></h2></td>
        </tr>
      </table></td>
    </tr>
    <tr>
      <td height="30" align="center"><h2>To Register Your Business Call<span class="mobile"> 66136226  </span>Now</h2></td>
    </tr>
    <tr>
      <td height="20" style="border-bottom:1px dotted #999" align="left" colspan="2">
     <table width="100%" border="0">
     <tr>
     <td>   
     <asp:DataList ID="dlcity" runat="server" RepeatColumns="10">
    <ItemTemplate>
    <asp:Button ID="lnkcity" runat="server" Text='<%#Eval("City")%>' BorderStyle="None" BackColor="White" 
        CommandArgument='<%#Eval("City")%>' OnCommand="lnk_to_othcities" CssClass="pointer" />
      <%--<asp:HyperLink ID="lnkcity" runat="server" Text='<%#Eval("City")%>'   
         NavigateUrl='<%# lnk_to_othcities(Eval("City")) %>'></asp:HyperLink>--%>
         &nbsp;|&nbsp;
  </ItemTemplate>
  </asp:DataList></td>
  
     <td width="300">
     <%--<asp:LinkButton ID="lnkoth_cities" runat="server" Text="Other Cities"></asp:LinkButton>--%>
     <a id="lnkoth_cities" runat="server">Other Cities</a>
     </td>
     
     </tr></table>
     </td>
    </tr>
    <tr>
    <td align="right" >
    <asp:Panel ID="pnlcities" runat="server" BackColor="#DAD5D0" Width="375px" style="margin-top:-55px; margin-left:-1px;position:relative; clear:both;">
    <fieldset>
    <table>
    <tr><td align="right"><asp:ImageButton ID="cancelbtn" AlternateText="CancelButton" runat="server" ImageUrl="../images/cencel.png" />
    </td></tr>
    <tr><td>
     <asp:DataList ID="dlother_cities" runat="server" RepeatColumns="4" Width="350px">
    <ItemTemplate>
    <asp:Button ID="lnkoth_cities_dl" runat="server" Text='<%#Eval("City")%>' CommandArgument='<%#Eval("City")%>' 
         OnCommand="lnk_to_othcities" BorderStyle="None" BackColor="#DAD5D0" CssClass="pointer"/>
       <%--<asp:HyperLink ID="lnkoth_cities_dl" runat="server" Text='<%#Eval("City")%>' NavigateUrl='<%# lnk_to_othcities(Eval("City"))%>'></asp:HyperLink>--%>
    </ItemTemplate>
    </asp:DataList>
    </td></tr>
    </table>
    </fieldset>
    </asp:Panel>
    </td>
    </tr>
    <cc3:ModalPopupExtender ID="modpopup_cities" runat="server"  
        TargetControlID="lnkoth_cities" PopupControlID="Pnlcities" OnLoad="other_cities" BackgroundCssClass="modalBackground" 
          OkControlID="cancelbtn"
        DropShadow="false"></cc3:ModalPopupExtender>
    <tr>
      <td height="40"><b>The best of the business houses have chosen to partner with us. Here is what they have to say about us.</b></td>
    </tr>
    <tr>
      <td colspan="2">
      <asp:DataList ID="dlsuccessdata" runat="server" Width="100%" DataKeyField="ssId" 
              onitemdatabound="dlsuccessdata_ItemDataBound">
      <ItemTemplate>
     
      <table width="100%" border="0">
      <tr><td></td></tr>
      <tr><td></td></tr>
        <tr>
          <td width="29%" height="80" rowspan="5" align="left" valign="top" align="right" style="padding-left:30px;"><asp:Image ID="imgphoto" AlternateText="ClientPhoto" runat="server" CommandArgument='<%#Eval("ssId")%>' ImageUrl='<%# Eval("PhotoName", "~/SS_Photos\\{0}") %>' Width="160" Height="120"/></td>
          <td width="71%" height="25">Customer Since <%#DataBinder.Eval(Container.DataItem, "SMonth")%>&nbsp;<%#DataBinder.Eval(Container.DataItem, "SYear")%></td>
        </tr>
        <tr>
          <td height="25">Investment with Justcalluz:</td>
        </tr>
        <tr>
          <td height="25">First Year: <strong>Rs. <%#DataBinder.Eval(Container.DataItem, "FirstYear")%> P. A.</strong></td>
        </tr>
        <tr>
          <td height="25">Current Year: <strong>Rs. <%#DataBinder.Eval(Container.DataItem, "CurrentYear")%> P. A.</strong></td>
        </tr>
        <tr>
          <td height="28">&quot;<%#DataBinder.Eval(Container.DataItem, "PartnerSpeak")%></td>
        </tr>
        <tr>
          <td width="29%" align="center">
          <%#DataBinder.Eval(Container.DataItem, "PName")%>&nbsp;,&nbsp;<%#DataBinder.Eval(Container.DataItem, "PDesg")%><br />
            <asp:LinkButton ID="lnkcompny" runat="server"  CommandArgument='<%# Eval("CompanyName") %>' OnCommand="GetCompDetails"><%#DataBinder.Eval(Container.DataItem, "CompanyName")%></asp:LinkButton>&nbsp;,&nbsp;<asp:Label ID="lblcity" runat="server" Text='<%#Eval("City")%>'></asp:Label><br />
            <strong><%#DataBinder.Eval(Container.DataItem, "Category")%></strong></td>
          <td >&nbsp;</td>
        </tr>
      </table>
      <hr />
       </ItemTemplate>
      </asp:DataList>
      <asp:Label ID="lblcity_out" runat="server" Visible="false"></asp:Label>
      <asp:Label ID="lblmsg" runat="server"></asp:Label>
       <table border="0" width="100%">
        <tr>
          <td align="right">
            <asp:ImageButton ID="imgPrevious" runat="server" AlternateText="btnPrevious" ImageUrl="images/arrow_2.png" OnClick="imgPrevious_Click"/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:ImageButton ID="imgNext" runat="server" AlternateText="btnNext" ImageUrl="images/arrow_1.png" OnClick="imgNext_Click" />
          </td>
       </tr>
      </table>
      </td>
    </tr>
    </table>
     </div>
   
</div>
<!-- end of the content-->
<%--<div class="footer" align="center" style="padding-top:5px; " >--%>
<div class="content_midbootam" >
<aa5:bottomMidcontent ID="mid1" runat="server" />
</div>
<div class="content_bootam_center">
<aa4:bottomcontent ID="bottomcontent1" runat="server" />
</div>

<div class="footer" align="center" style="padding-top:5px; " >
<aa10:footer1 ID="tevfd" runat="server" />
<aa11:footer2 ID="eqwr" runat="server" />
</div>
</div>
<%--</div>--%>

    </form>
</body>
</html>
