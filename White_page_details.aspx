<%@ Page Language="C#" AutoEventWireup="true" CodeFile="White_page_details.aspx.cs" Inherits="White_page_details" %>
<%@ Register Src="usercontrols/signin.ascx" TagName="signin" TagPrefix="aa1" %>
<%@ Register Src="usercontrols/Search.ascx" TagName="catag" TagPrefix="aa6" %>
<%@ Register Src="usercontrols/footer1.ascx" TagName="footer1" TagPrefix="aa10" %>
<%@ Register Src="usercontrols/footer2.ascx" TagName="footer2" TagPrefix="aa11" %>
<%@ Register Src="usercontrols/BottomContent.ascx" TagName="bottomcontent" TagPrefix="aa4" %>
<%@ Register Src="usercontrols/BottomMidContent.ascx" TagName="bottomMidcontent" TagPrefix="aa5" %>
<%@ Register Src="usercontrols/SearchNew.ascx" TagName="SearchNew" TagPrefix="New" %>
<%@ Register Src="usercontrols/small_logo.ascx" TagName="logo" TagPrefix="S_logo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
   <title id="pgtitle" runat="server"></title>
<%--<title>:: Justcalluz :: Home page</title>--%>
<link href="css/style.css" rel="stylesheet" type="text/css" />
<link href="css/inner_style.css" rel="Stylesheet" type="text/css" />

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
<!-- staart the Content-->
<div class="content" style="padding:0; margin:0;">
<div class="content_innerleft" style="width:100%">
<table width="100%" border="0">
  
  <tr>
    <td class="select_menu" style="padding-left:3px;"><a href="Default.aspx">Home</a>&gt;<a href="White_Page.aspx">White Pages</a>&gt;
        <asp:Label ID="lblcity" runat="server"></asp:Label>
    </td>
  </tr>
  <tr>
    <td style="background: url(images/selection3.png) no-repeat" height="39">
    <table width="100%" border="0">
  <tr>
    <td style="padding-left:10px;"><span class="bottam"><font color="#FFFFFF">Top Companies In 
        <asp:Label ID="lblcity1" runat="server"></asp:Label> - Justcalluz</font></span></td>
    </tr>
</table>
</td>
  </tr>
  <tr>
    <td width="100%" valign="top" style="font-family:Verdana, Geneva, sans-serif; padding-left:5px; font-size:small" ><br/>
        <asp:DataList ID="dlData" runat="server" Width="100%" 
            onitemdatabound="dlData_ItemDataBound">
            <ItemTemplate>
                <table width="100%">
                    <tr id="trPara1" runat="server">
                        <td><p style="text-align:justify;">
                            <asp:Label ID="lblPara1" runat="server" ForeColor="Black" Text='<%#Eval("Para1") %>'></asp:Label><br /></p>
                        </td>
                    </tr>                    
                    <tr id="trPara2" runat="server">
                        <td><p style="text-align:justify;">
                            <asp:Label ID="lblPara2" runat="server" ForeColor="Black" Text='<%#Eval("Para2") %>'></asp:Label><br /></p>
                        </td>
                    </tr>
                    <tr id="trPara3" runat="server">
                        <td><p style="text-align:justify;">
                            <asp:Label ID="lblPara3" runat="server" ForeColor="Black" Text='<%#Eval("Para3") %>'></asp:Label><br /></p>
                        </td>
                    </tr>
                    <tr id="trPara4" runat="server">
                        <td><p style="text-align:justify;">
                            <asp:Label ID="lblPara4" runat="server" ForeColor="Black" Text='<%#Eval("Para4") %>'></asp:Label><br /></p>
                        </td>
                    </tr>
                    <tr id="trPara5" runat="server">
                        <td><p style="text-align:justify;">
                            <asp:Label ID="lblPara5" runat="server" ForeColor="Black" Text='<%#Eval("Para5") %>'></asp:Label></p>
                        </td>
                    </tr>                    
                </table>                                        
            </ItemTemplate>
        </asp:DataList>
</td>
  </tr>
  <tr id="trline" runat="server">
    <td valign="top"  style="background-image:url(images/hr.gif); background-repeat:repeat-x;">&nbsp;</td>
  </tr>
  <tr id="trDetails" runat="server">
    <td width="100%" valign="top" style="font-family:Verdana, Geneva, sans-serif; padding-left:5px; line-height:1.5; letter-spacing:.3px;">
        <asp:Repeater ID="rpcompanies" runat="server">
        <ItemTemplate>
           <a id="lnkcomp" runat="server" href='<%# GetUrl(Eval("id"))%>' style="color:#005B88; font-size:medium;"><%#DataBinder.Eval(Container.DataItem, "company_name")%></a>
        </ItemTemplate>
        <AlternatingItemTemplate>
           <a id="lnkcomp1" runat="server" href='<%# GetUrl(Eval("id"))%>' style="color:#004080; font-size: small;"><%#DataBinder.Eval(Container.DataItem, "company_name")%></a>
        </AlternatingItemTemplate>
        <SeparatorTemplate>&nbsp;&nbsp;</SeparatorTemplate>
        </asp:Repeater>
   </td>
  </tr>
  <tr id="trMessage" runat="server">
    <td width="100%" align="center"><asp:Label ID="lblMessage" runat="server" Font-Size="14px"></asp:Label></td>
  </tr>
  <tr>
    <td >&nbsp;</td>
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
<aa10:footer1 ID="tevfd" runat="server" />
<aa11:footer2 ID="eqwr" runat="server" />
</div>
</div>
<script type="text/javascript">
<!--
swfobject.registerObject("FlashID");
//-->
</script>
</form>
</body>
</html>
