<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Catageories.aspx.cs" Inherits="Catageories" %>
<%@ Register Src="usercontrols/signin.ascx" TagName="signin" TagPrefix="aa1" %>
<%@ Register Src="usercontrols/topimage.ascx" TagName="topimage" TagPrefix="aa2" %>
<%@ Register Src="usercontrols/boxes3.ascx" TagName="boxes3" TagPrefix="aa5" %>
<%@ Register Src="usercontrols/bottomimage.ascx" TagName="bottomimage" TagPrefix="homebottomimg1" %>
<%@ Register Src="usercontrols/footer1.ascx" TagName="footer1" TagPrefix="aa10" %>
<%@ Register Src="usercontrols/footer2.ascx" TagName="footer2" TagPrefix="aa11" %>
<%@ Register Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" TagPrefix="cc3"  %>
<%@ Register Src="usercontrols/Search.ascx" TagName="Search" TagPrefix="searchrecords" %>
<%@ Register Src="usercontrols/Search.ascx" TagName="categories" TagPrefix="cat" %>
<%@ Register Src="usercontrols/SponsoredLinks.ascx" TagName="Splinks" TagPrefix="aa3" %>
<%@ Register Src="usercontrols/BottomContent.ascx" TagName="bottomcontent" TagPrefix="aa4" %>
<%@ Register Src="usercontrols/BottomMidContent.ascx" TagName="bottomMidcontent" TagPrefix="aa5" %>
<%@ Import Namespace="System.Data" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>:: Justcalluz :: Home page</title>
<link href="css/style.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePageMethods="true">
    </asp:ScriptManager>

<div class="layout">
<aa1:signin ID="SignIn1" runat="server" />
<aa2:topimage ID="iud" runat="server" />
<div class="search" align="center">
<searchrecords:Search ID="search1" runat="server" />
</div>
<div class="selection" align="center">
<cat:categories ID="categories" runat="server" />
</div>


<div class="content_inner">

<!-- start the inner left-->
<div class="content_innerleft">
<div class="contenbox">
<div class="contentbox_top">Category List</div>
<div class="contentbox_mid"> 
<table width="100%" border="0">
  <tr>
   <td class="side_menu">
         <asp:DataList ID="DataList2"   RepeatDirection="Vertical" CellPadding="4"  runat="server" 
                Height="117px" Width="170px" OnItemCommand="DataList2_ItemCommand">
            <HeaderTemplate>
            </HeaderTemplate>
            <ItemTemplate>
                <div class="innertext">
                <table border="0">
                    <tr>
                        <td><img src="images/arrow2.jpg" />&nbsp;&nbsp;</td>
                        <td valign="top">
                            <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%#Eval("category")%>'
                             Text ='<%# Eval("category") %>' CommandName="select">
                            </asp:LinkButton>
                    </td>
                    </tr>
                    <%--<tr>
                        <td height="10px"></td>
                    </tr>--%>
                </table>
                </div>
           </ItemTemplate>
            </asp:DataList>
      </td>

  </tr>
  <tr>
    <td height="22" colspan="2" style="padding-left:5px; padding-top:10px"><span style="padding-left:5px; padding-top:10px"><img src="images/free-listing.png" width="132" height="32" /></span>&nbsp;</td>
    </tr>
<tr>
  <td class="side_menu">
    <asp:DataList ID="DataList3" RepeatDirection="Vertical" CellPadding="4"  runat="server" 
                Height="50px" Width="165px" OnItemCommand="DataList1_ItemCommand">
        <HeaderTemplate>
        </HeaderTemplate>
        <ItemTemplate>
            <div class="innertext">
            <table border="0">
                <tr>
                    <td><img src="images/arrow2.jpg" />&nbsp;&nbsp;</td>
                    <td valign="top">
                        <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%#Eval("category")%>'
                         Text ='<%# Eval("category") %>' CommandName="select">
                        </asp:LinkButton>
                    </td>
                </tr>                                       
            </table>
            </div>
       </ItemTemplate>
        </asp:DataList>
  </td>
</tr>
  <tr>
    <td height="22" colspan="2" style="padding-left:7px; padding-top:8px">&nbsp;</td>
  </tr>
  <tr>
    <td height="22" colspan="2" style=" padding-left:8px;">&nbsp;</td>
    
  </tr>
</table></div>
<div class="contentbox_bottam"></div>
</div>
</div>
<!-- end of the inner left-->

<!-- start the mid Box-->
  <div class="content_innermid">
  <div class="contentmid_box">
  <div class="contentmid_boxtop"><a href="Default.aspx" style="text-decoration:none;color:White">
      Home&gt;&gt;</a><asp:Label ID="Label2"
          runat="server" Text="Popular Search Categories"></asp:Label></div>
  <div class="contentmid_boxmid"><table width="100%" border="0">
 
  <tr>
    <td height="30" colspan="2" align="right" class="headings" style="padding-right:5px;">
        Result for</td>
    <td width="1%"><font color="#000000"><strong>:</strong></font></td>
    <td width="56%"><strong class="side_menu">
        <asp:Label ID="Label1" runat="server" Text="Popular Search Categories"></asp:Label></strong></td>
  </tr>
  <tr>
    <td colspan="4"><table width="100%" border="0">
  <tr>
    <td width="7%" style="padding-left:30px;">
        <asp:ImageButton ID="ImageButton1" runat="server" 
            ImageUrl="images/icons/A.png"  Width="32" Height="32" 
            onclick="ImageButton1_Click"/>
    </td>
    <td width="7%">
        <asp:ImageButton ID="ImageButton2" runat="server" 
            ImageUrl="images/icons/B.png"  Width="32" Height="32" 
            onclick="ImageButton2_Click"/>
    </td>
    <td width="7%">
    <asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="images/icons/c.png"  
            Width="32" Height="32" onclick="ImageButton3_Click"/>
     </td>
    <td width="7%">
    <asp:ImageButton ID="ImageButton4" runat="server" ImageUrl="images/icons/D.png"  
            Width="32" Height="32" onclick="ImageButton4_Click"/>
   
    </td>
    <td width="7%">
    <asp:ImageButton ID="ImageButton5" runat="server" ImageUrl="images/icons/E.png"  
            Width="32" Height="32" onclick="ImageButton5_Click"/>
    
    </td>
    <td width="7%">
    <asp:ImageButton ID="ImageButton6" runat="server" ImageUrl="images/icons/F.png"  
            Width="32" Height="32" onclick="ImageButton6_Click"/>
  
    </td>
    <td width="7%">
    
    <asp:ImageButton ID="ImageButton7" runat="server" ImageUrl="images/icons/G.png"  
            Width="32" Height="32" onclick="ImageButton7_Click"/>
   
    </td>
    <td width="7%">
    <asp:ImageButton ID="ImageButton8" runat="server" ImageUrl="images/icons/H.png"  
            Width="32" Height="32" onclick="ImageButton8_Click"/>
    
    </td>
    <td width="7%">
    <asp:ImageButton ID="ImageButton9" runat="server" ImageUrl="images/icons/I.png"  
            Width="32" Height="32" onclick="ImageButton9_Click"/>
    
    </td>
    <td width="7%">
    <asp:ImageButton ID="ImageButton10" runat="server" ImageUrl="images/icons/J.png"  
            Width="32" Height="32" onclick="ImageButton10_Click"/>
  
    </td>
    <td width="7%">
    <asp:ImageButton ID="ImageButton11" runat="server" ImageUrl="images/icons/K.png"  
            Width="32" Height="32" onclick="ImageButton11_Click"/>
   
    </td>
    <td width="7%">
    <asp:ImageButton ID="ImageButton12" runat="server" ImageUrl="images/icons/L.png"  
            Width="32" Height="32" onclick="ImageButton12_Click"/>

    </td>
    <td width="8%">
    <asp:ImageButton ID="ImageButton13" runat="server" ImageUrl="images/icons/M.png"  
            Width="32" Height="32" onclick="ImageButton13_Click"/>

    </td>
      <td width="8%">&nbsp;</td>
      
  </tr>
  <tr>
    <td style="padding-left:30px;">
     <asp:ImageButton ID="ImageButton14" runat="server" ImageUrl="images/icons/N.png"  
            Width="32" Height="32" onclick="ImageButton14_Click"/>
   
    </td>
    <td>
     <asp:ImageButton ID="ImageButton15" runat="server" ImageUrl="images/icons/O.png"  
            Width="32" Height="32" onclick="ImageButton15_Click"/>
   
    </td>
    <td>
     <asp:ImageButton ID="ImageButton16" runat="server" ImageUrl="images/icons/P.png"  
            Width="32" Height="32" onclick="ImageButton16_Click"/>
   
    </td>
    <td>
     <asp:ImageButton ID="ImageButton17" runat="server" ImageUrl="images/icons/Q.png"  
            Width="32" Height="32" onclick="ImageButton17_Click"/>

    </td>
    <td>
     <asp:ImageButton ID="ImageButton18" runat="server" ImageUrl="images/icons/R.png"  
            Width="32" Height="32" onclick="ImageButton18_Click"/>
  
    </td>
    <td>
     <asp:ImageButton ID="ImageButton19" runat="server" ImageUrl="images/icons/S.png"  
            Width="32" Height="32" onclick="ImageButton19_Click"/>

    </td>
    <td>
     <asp:ImageButton ID="ImageButton20" runat="server" ImageUrl="images/icons/T.png"  
            Width="32" Height="32" onclick="ImageButton20_Click"/>

    </td>
    <td>
     <asp:ImageButton ID="ImageButton21" runat="server" ImageUrl="images/icons/U.png"  
            Width="32" Height="32" onclick="ImageButton21_Click"/>
   
    </td>
    <td>
     <asp:ImageButton ID="ImageButton22" runat="server" ImageUrl="images/icons/V.png"  
            Width="32" Height="32" onclick="ImageButton22_Click"/>
  
    </td>
    <td>
     <asp:ImageButton ID="ImageButton23" runat="server" ImageUrl="images/icons/W.png"  
            Width="32" Height="32" onclick="ImageButton23_Click"/>
  
    </td>
    <td>
     <asp:ImageButton ID="ImageButton24" runat="server" ImageUrl="images/icons/X.png"  
            Width="32" Height="32" onclick="ImageButton24_Click"/>

    </td>
    <td>
     <asp:ImageButton ID="ImageButton25" runat="server" ImageUrl="images/icons/Y.png"  
            Width="32" Height="32" onclick="ImageButton25_Click"/>
  
    </td>
    <td>
     <asp:ImageButton ID="ImageButton26" runat="server" ImageUrl="images/icons/Z.png"  
            Width="32" Height="32" onclick="ImageButton26_Click"/>
  
    </td>
      <td width="8%"></td>
  </tr>
</table>
</td>
  </tr>
  <tr>
  <td valign="top" colspan="4" class="side_menu" align="center">
 <table width="100%" border="0" >
  <asp:DataList ID="DataList1" RepeatDirection="Horizontal" CellPadding="1" RepeatColumns="2" runat="server" 
                                Height="120px" Width="100%" OnItemCommand="DataList1_ItemCommand"> 
                <HeaderTemplate>
                </HeaderTemplate>
                <ItemTemplate>
                 <div class="side_menu">
                    <table>
                        <tr>
                        <td height="25" align="right"  style="padding-left:25px"><img src="images/arrow2.png" width="10" height="8" /></td>
                        <td class="side_menu">
                            <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%#Eval("cat")%>'
                                 Text ='<%# Eval("cat") %>' CommandName="select">
                            </asp:LinkButton>
                        </td>
                        </tr>
                    </table>
                   </div> 
               </ItemTemplate>
            </asp:DataList>
            </table>
            </td>
  
  </tr>
  <tr>
    <td colspan="4">&nbsp;</td>
  </tr>
  </table></div>
  <div class="contentmid_boxbottam"></div>
  
  </div>
  
  </div>
  
<!-- end of the mid Box-->  

<div class="content_innerright">
<div class="contenbox">
<div class="contentbox_top">Sponsor Ads</div>
<div class="contentbox_mid"><table width="100%" border="0">
      <tr>
         <td class="right_tab">
        <aa3:Splinks id="splinks1" runat="server" />    
         </td>
    </tr>
  </table></div>
<div class="contentbox_bottam"></div>
</div></div>
<div class="content_midbootam" >
<aa5:bottomMidcontent ID="mid1" runat="server" />

</div>
<div class="content_bootam_center">
<aa4:bottomcontent ID="bottomcontent1" runat="server" />

</div>
<div class="footer" align="center" style="padding-top:5px">
    <aa10:footer1 ID="footer1" runat="server" />
 <aa11:footer2 ID="footer2" runat="server" />

</div>
</div>
</div>
</form>
</body>
</html>
