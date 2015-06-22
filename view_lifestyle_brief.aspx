<%@ Page Language="C#" AutoEventWireup="true" CodeFile="view_lifestyle_brief.aspx.cs" Inherits="view_lifestyle_brief" %>
<%@ Register Src="usercontrols/signin.ascx" TagName="signin" TagPrefix="aa1"  %>
<%@ Register Src="usercontrols/Search.ascx" TagName="catag" TagPrefix="aa6" %>
<%@ Register Src="usercontrols/footer1.ascx" TagName="footer1" TagPrefix="aa10" %>
<%@ Register Src="usercontrols/footer2.ascx" TagName="footer2" TagPrefix="aa11" %>
<%@ Register Src="usercontrols/BottomContent.ascx" TagName="Bottomcontent" TagPrefix="bcon" %>
<%@ Register Src="usercontrols/BottomMidContent.ascx" TagName="Contentmid" TagPrefix="bcm" %>
<%--<%@ Register Src="usercontrols/bottomimage.ascx" TagName="bottomimg" TagPrefix="aa6" %>
--%>
<%@ Register Src="usercontrols/CheckPostLeftMenu.ascx" TagName="leftcheckpost" TagPrefix="lcp" %>
<%@ Register Src="usercontrols/SearchNew.ascx" TagName="SearchNew" TagPrefix="New" %>
<%@ Register Src="usercontrols/small_logo.ascx" TagName="logo" TagPrefix="S_logo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>:: Justcalluz :: LifeStyle</title>
    <link href="css/style.css" rel="stylesheet" type="text/css" />
    <link href="css/inner_style.css" rel="stylesheet" type="text/css" />
<script src="SpryAssets/SpryTabbedPanels.js" type="text/javascript"></script>
<link href="SpryAssets/SpryTabbedPanels.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
<div class="layout">
<div class="signin">
<aa1:signin ID="awea" runat="server" />
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
<div class="contentbox_top">My Postings</div>
<div class="contentbox_mid">
<lcp:leftcheckpost ID="leftcheckpost" runat="server" />
</div>
<div class="contentbox_bottam"></div>
</div>
  <div class="content_innermid" style="width:79%;">
   <div class="searchmid_boxtop1"><a href="<%$RouteUrl:RouteName=HomeRoute%>" style="text-decoration:none;color:White" runat="server">
      Home</a>&gt;&gt;
  <%--<asp:LinkButton ID="LinkButton2" runat="server" ForeColor="White" Font-Underline="false" onclick="lnkBtnTocheckPostings_Click">My 
      Postings</asp:LinkButton>--%><a id="lnkBtnTocheckPostings" runat="server" onserverclick="lnkBtnTocheckPostings_Click" style="color:White;">My 
      Postings</a>&gt;&gt;LifeStyle</div>
  <div class="searchmid_boxmid1">
  <table width="100%" border="0">
    <tr><td align="center">
    <asp:DataList ID="viewlifestyledl" DataKeyField="id" runat="server" Width="100%" OnItemDataBound="viewlifestyledl_ItemDataBound">
     <ItemTemplate>
       <table width="100%" cellpadding="0px" cellspacing="0px">
        <tr>
         <td style=" padding:10px;">
          <table cellpadding="0Px" cellspacing="0px" width="100%" align="center" border="1">
           <tr>
            <td valign="top" width="100%">
              <div style="padding: 0px; margin: 0px;">
               <table width="100%" border="0">
                <tr>
                   <td width="15%" rowspan="3" style="padding:10px 10px 10px 15px;" valign="middle" id="tdlogo" runat="server">
                   <asp:Label ID="lblImgName" runat="server" Text='<%# Eval("ImageName") %>' Visible="false"></asp:Label>
                    <asp:Image ID="imglogo" AlternateText="companyLogo" runat="server" ImageUrl='<%# Eval("ImageName", "../Logos\\{0}") %>' Width="100" Height="100" />
                    </td>
                    <td width="63%" class="headings" align="left" style="padding-left:5px; height:30px; padding-top: 5px;">
                     <%--<asp:HyperLink  ID="Linkbutton1" ForeColor="Red" runat="server" NavigateUrl='<%# "LifeStyle_details.aspx?id=" + Eval("id").ToString() %>'
                          Text ='<%# Eval("company_name") %>' CommandName ="Select"></asp:HyperLink>--%>
                          <asp:HyperLink  ID="Linkbutton1" ForeColor="Red" runat="server" NavigateUrl='<%# GetUrl(Eval("id")) %>'
                          Text ='<%# Eval("company_name") %>' CommandName ="Select"></asp:HyperLink><br />
                          <strong>Location&nbsp;:&nbsp;</strong><span class="side_menu"><asp:Literal ID="Literal5" runat="server" Text='<%#Eval("address")%>' /></span><br/>
                          <asp:Image ID="Image3" AlternateText="PhoneIcon" runat="server" ImageUrl="images/phone.png" />
                     <span class="side_menu"><asp:Literal ID="Literal6" runat="server" Text='<%#Eval("mob")%>' /></span><br />
                     <asp:Image ID="Image4" runat="server" AlternateText="mailIcon" ImageUrl="images/mail1.png" />
                     <span class="side_menu"><asp:Literal ID="Literal7" runat="server" Text='<%#Eval("emailid")%>' /></span><br />
                     <strong>City&nbsp;:&nbsp;</strong><span class="side_menu">
                     <asp:Literal ID="Literal8" runat="server" Text='<%#Eval("city")%>' /></span>
                    </td> 
                    <td align="right" valign="top" style="padding-right:5px;"><span class="mid_menu">Status&nbsp;:</span>
                      <asp:Label ID="lblstatus" runat="server" Visible="true" Text='<%#Eval("ApprovedStatus") %>' 
                          CssClass="sub_menu"></asp:Label></strong>
                    </td>  
               </tr>
                <tr>
                 <td colspan="6" align="right" class="side_menu" style="padding-right:5px;">
                   <asp:HyperLink ID="editbtn" runat="server" Text=" Edit " Font-Size="11px"  NavigateUrl='<%# GetEditUrl(Eval("id")) %>'></asp:HyperLink>
                    &nbsp;&nbsp;&nbsp;
                   <asp:HyperLink ID="details" runat="server" Text="View Details" Font-Size="11px" NavigateUrl='<%# GetUrl(Eval("id")) %>' ></asp:HyperLink>
                 </td>
               </tr>
              </table>           
              </div>
            </td>
           </tr>
          </table>
         </td>
        </tr>
       </table>
    </ItemTemplate>
   </asp:DataList>
    <table border="0" width="100%" id="trpagesize" runat="server">
     <tr>
      <td align="right" style="padding-right:13px;">
        <asp:ImageButton ID="imgPrevious" runat="server" AlternateText="btnPrevious" ImageUrl="images/arrow_2.png" OnClick="imgPrevious_Click"/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:ImageButton ID="imgNext" runat="server" AlternateText="btnNext" ImageUrl="images/arrow_1.png" OnClick="imgNext_Click" />
      </td>
     </tr>
   </table>

    <%--<table border="0" style="background-color:white; width: 100px; margin-right: 0px; height: 22px;">
            <tr>
                <td>
                    <asp:DropDownList ID="ddlPageSize" runat="server" 
                        OnSelectedIndexChanged="ddlPageSize_SelectedIndexChanged" 
                        style="height: 22px">
                    <asp:ListItem>5</asp:ListItem>
                    <asp:ListItem>10</asp:ListItem>
                    <asp:ListItem>15</asp:ListItem>
                    </asp:DropDownList>
                </td>
               <td>
                <asp:LinkButton ID="lnkbtnPrevious" runat="server" OnClick="lnkbtnPrevious_Click1" 
                        Font-Bold="True" Font-Size="Medium" Font-Underline="False" ForeColor="#FF6600">Previous</asp:LinkButton>
                </td>
                <td>
                <asp:DataList ID="dlPaging" runat="server" OnItemCommand="dlPaging_ItemCommand" 
                    OnItemDataBound="dlPaging_ItemDataBound" RepeatDirection="Horizontal" 
                        ForeColor="#996633">            
                    <ItemTemplate>
                        <asp:LinkButton ID="lnkbtnPaging" runat="server" 
                        CommandArgument='<%# Eval("PageIndex") %>' 
                        CommandName="lnkbtnPaging" 
                        Text='<%# Eval("PageText") %>'>LinkButton</asp:LinkButton>&nbsp;
                    </ItemTemplate>
               </asp:DataList>

                </td>
                <td>
                    <asp:LinkButton ID="lnkbtnNext" runat="server" OnClick="lnkbtnNext_Click1" Font-Bold="True" Font-Size="Medium" Font-Underline="False" ForeColor="#FF6600">Next</asp:LinkButton>
                </td>
            </tr>
        </table>--%>
    </td></tr>
    </table>
  </div>
  <div class="searchmid_boxbottam1"></div>
 </div>
<!-- end of the mid Box-->
</div>
<div class="content_midbootam" >
<bcm:contentmid ID="contentmid" runat="server" />
</div>
<div class="content_midbootam" >
<table width="100%" border="0">
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
    </form>
</body>
</html>
