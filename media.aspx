<%@ Page Language="C#" AutoEventWireup="true" CodeFile="media.aspx.cs" Inherits="media" %>
<%@ Register Src="usercontrols/footer1.ascx" TagName="footer1" TagPrefix="aa10" %>
<%@ Register Src="usercontrols/footer2.ascx" TagName="footer2" TagPrefix="aa11" %>
<%@ Register Src="usercontrols/BottomContent.ascx" TagName="bottomcontent" TagPrefix="aa4" %>
<%@ Register Src="usercontrols/BottomMidContent.ascx" TagName="bottomMidcontent" TagPrefix="aa5" %>
<%@ Register Src="usercontrols/media_left.ascx" TagName="lftmedia" TagPrefix="lmedia" %>
<%@ Register Src="usercontrols/SearchNew.ascx" TagName="newsearch" TagPrefix="nsearch"%>
<%@ Register Src="usercontrols/Search.ascx" TagName="catageories" TagPrefix="aa6" %>
<%@ Register Src="usercontrols/signin.ascx" TagName="signin" TagPrefix="aa1" %>
<%@ Register Src="usercontrols/small_logo.ascx" TagName="logosmall" TagPrefix="lgsmall" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<%--<title>:: Just Calluz :: Media page</title>--%>
<title>Press Articles and Press Videos| JustCalluz</title>
<meta name='Title' content='Press Articles and Press Videos| JustCalluz' />
<meta name='description' content='Press articles and videos share JustCalluz achievements, milestones and establishments. Find JustCalluz accomplishments since its foundation in media releases.' />
<meta name='keywords' content='JustCalluz in media, Press release of JustCalluz, justcalluz press coverage, justcalluz press release, press release justcalluz, Press videos JustCalluz' />
		
<link href="css/inner_style.css" rel="Stylesheet" type="text/css" />
<link href="css/style.css" rel="Stylesheet" type="text/css" />
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
<%--<div class="header_top"></div>--%>
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
<!-- start The Content-->
<div class="content" style="padding:0; margin:0;">
<div class="content_innerleft">
<lmedia:lftmedia ID="leftmedia" runat="server" />
</div>
<div class="content_innermid" style="width:79%;">
  <table width="100%" cellspacing="0" cellpadding="0" border="0" class="media">
    <tbody>
      <tr>
        <td height="20" align="center"><b>Media Contact:</b> Subbu | +91-22-2888 4060 (Ext.: 2240) | 9967355726 |<a href="#">media@justcalluz.com</a></td>
      </tr>
      <tr>
        <td style="width:79%; padding-left:10px;"><!-- <table class="setblartcllist" width="100%" border="1" cellspacing="0" cellpadding="0" >				SAMIR			-->
          <table width="100%" cellspacing="0" cellpadding="0" border="0">
           <tr>
             <td align="center">
                    <asp:GridView ID="mediagrid" runat="server" AutoGenerateColumns="false"
                      AlternatingRowStyle-BackColor="SkyBlue" GridLines="Horizontal" Width="787px"
                      BorderStyle="Dotted" HeaderStyle-BorderStyle="Dotted" HeaderStyle-BackColor="SkyBlue"
                      HeaderStyle-HorizontalAlign="Left">
                    <Columns>
                    <asp:BoundField HeaderText="#" DataField="Medid" />
                    <asp:TemplateField>
                    <HeaderTemplate>Article Title</HeaderTemplate>
                    <ItemTemplate>
                   <%-- <asp:Button ID="lnkmedia" runat="server" Text='<%#Eval("Title")%>' 
                      CommandArgument='<%#Eval("Medid")%>' OnCommand="media_det" BorderStyle="None" BackColor="White"/>--%>
                      <asp:HyperLink ID="lnkmedia" runat="server" NavigateUrl='<%# GetUrl(Eval("Medid"))%>' Text='<%#Eval("Title")%>'>
                      </asp:HyperLink>
                    </ItemTemplate>
                    </asp:TemplateField>
                    <%--<asp:BoundField HeaderText="Article Title" DataField="Title" />--%>
                    <asp:BoundField HeaderText="Date" DataField="Postdate" />
                    <asp:TemplateField>
                    <HeaderTemplate>Ratings(out of 5)</HeaderTemplate>
                    <ItemTemplate>
                    <asp:Label ID="lblrating" runat="server" Text='<%#Eval("Ratings")%>'></asp:Label>
                    (<asp:Label ID="lblvote" runat="server" Text='<%#Eval("Votes")%>'></asp:Label>Vote(s))
                    </ItemTemplate>
                    </asp:TemplateField>
                    <%--<asp:BoundField HeaderText="Ratings(out of 5)" DataField="Ratings" />--%>
                    <asp:BoundField HeaderText="Hits" DataField="Hits" />
                    </Columns>
                    </asp:GridView>
                </td>
                
              </tr>
          <%--</tbody>--%>
          </table></td>
      </tr>
    </tbody>
    <tr>
    <td style="padding-left:15px;">
    <asp:Label ID="lblmsg" runat="server"></asp:Label>
    </td>
    </tr>
  </table>
</div>
</div>
<!-- end of the content-->
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
    </form>
</body>
</html>
