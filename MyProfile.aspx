<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MyProfile.aspx.cs" Inherits="MyProfile" %>
<%@ Register Src="usercontrols/signin.ascx" TagName="signin" TagPrefix="aa1" %>
<%@ Register Src="usercontrols/Search.ascx" TagName="catag" TagPrefix="aa6" %>
<%@ Register Src="usercontrols/footer1.ascx" TagName="footer1" TagPrefix="aa10" %>
<%@ Register Src="usercontrols/footer2.ascx" TagName="footer2" TagPrefix="aa11" %>
<%@ Register Src="usercontrols/BottomContent.ascx" TagName="Bottomcontent" TagPrefix="bcon" %>
<%@ Register Src="usercontrols/BottomMidContent.ascx" TagName="Contentmid" TagPrefix="bcm" %>
<%@ Register Src="usercontrols/SearchNew.ascx" TagName="SearchNew" TagPrefix="New" %>
<%@ Register Src="usercontrols/small_logo.ascx" TagName="logo" TagPrefix="S_logo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>:: Justcalluz :: Profile page</title>
<link href="css/style.css" rel="stylesheet" type="text/css" />
<link href="css/inner_style.css" rel="Stylesheet" type="text/css" />
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
<%--<div class="content_inner">--%>

<!-- start the inner left-->
<div class="content" style="padding:0; margin:0;">
<div class="content_innerleft">
<div class="contentbox_top">My Profile</div>
<div class="contentbox_mid"> 
<table width="100%" border="0">
  <tr>
   <%-- <td align="right"><img src="images/arrow2.png" width="10" height="8" /></td>--%>
    <td width="84%" height="22" class="side_menu">
    <ul><li>
    <%--<asp:LinkButton ID="lnkBtnProfileEdit" runat="server" Font-Underline="false" 
                        onclick="lnkBtnProfileEdit_Click">Edit Profile</asp:LinkButton>--%>
       <a id="lnkBtnProfileEdit" runat="server" onserverclick="lnkBtnProfileEdit_Click">Edit Profile</a>
     </li></ul>                   
    </td>
  </tr>
  <tr>
   <%--<td align="right"><img src="images/arrow2.png" width="10" height="8" /></td>--%>
    <td class="side_menu" height="22">
    <ul><li>
   <%-- <asp:LinkButton ID="lnkBtnChangePW" runat="server" Font-Underline="false" onclick="lnkBtnChangePW_Click">Change Password</asp:LinkButton>--%>
   <a id="lnkBtnChangePW" runat="server" onserverclick="lnkBtnChangePW_Click">Change Password</a>
    </li></ul>
    </td>
  </tr>
   <tr>
    <td height="22" colspan="2" style=" padding-left:8px;">&nbsp;</td>
    
  </tr>
</table></div>
<div class="contentbox_bottam"></div>
</div>
<!-- end of the inner left-->

<!-- start the mid Box-->
<div>
  <div class="content_innermid" style="width:79%;">
  <div class="searchmid_box">
  <div class="searchmid_boxtop1"><a href="<%$RouteUrl:RouteName=HomeRoute %>" style="text-decoration:none;color:White" runat="server">Home</a>&gt;&gt; My Profile</div>
  <div class="searchmid_boxmid1">
    <table width="100%" border="0">
      <tr id="trHeading" runat="server" class="sub_menu">
        <td colspan="3" align="center">
        <asp:Label ID="lblHeading1" runat="server" Font-Size="Medium"></asp:Label>
        </td>
      </tr>
      <tr>
        <td colspan="3" align="center">
         <table width="100%" border="0">         
          <tr>                   
           <td colspan="3" align="center">
            <table width="100%" border="0">             
                     
             <tr id="trPerInfo" runat="server">
                <td colspan="2" align="right" class="sub_menu">
                    <asp:Label ID="Label20" runat="server" Text="Personal Information"></asp:Label>
                </td>
             </tr>
             <tr id="trName" runat="server" class="side_menu" >
                <td align="right" style="width:250px">Name</td>
                <td style="width:5px">:</td>
                <td align="left"  style="width:300px" >
                    <asp:Label ID="lblName" runat="server"></asp:Label>
                </td>
            </tr>
            <tr id="trEmail" runat="server" class="side_menu">
                <td align="right">Email Id</td>
                <td>:</td>
                <td align="left">
                    <asp:Label ID="lblEmail" runat="server"></asp:Label>   
                </td>
            </tr> 
             <tr id="trAdres" runat="server" class="side_menu">
                <td align="right">Address</td>
                <td>:</td>
                <td align="left">
                    <asp:Label ID="lblAddress" runat="server"></asp:Label>                     
                </td>
            </tr>
              <tr id="trLmark" runat="server" class="side_menu">
                <td align="right">Land Mark</td>
                <td>:</td>
                <td align="left">
                    <asp:Label ID="lblLandMark" runat="server"></asp:Label>                     
                </td>
            </tr>
             <tr id="trCity" runat="server" class="side_menu">
                <td align="right">City</td>
                <td>:</td>
                <td align="left">
                    <asp:Label ID="lblCity" runat="server"></asp:Label>                     
                </td>
            </tr>
             <tr id="trState" runat="server" class="side_menu">
                <td align="right">State</td>
                <td>:</td>
                <td align="left">
                    <asp:Label ID="lblState" runat="server"></asp:Label>                     
                </td>
            </tr>
                   <tr id="trPincode" runat="server" class="side_menu">
                <td align="right">Pincode</td>
                <td>:</td>
                <td align="left">
                    <asp:Label ID="lblPincode" runat="server"></asp:Label>  
                </td>
            </tr>            
            <tr id="trMobNo" runat="server" class="side_menu"> 
                <td align="right">Mobile Number</td>
                <td>:</td>
                <td align="left">
                    <asp:Label ID="lblMobNo" runat="server"></asp:Label>  
                </td>
            </tr>
            <tr id="trPhNo" runat="server" class="side_menu">
                <td align="right">Phone Number</td>
                <td>:</td>
                <td align="left">
                    <asp:Label ID="lblPhNo" runat="server"></asp:Label>  
                </td>
            </tr>
            <tr id="trFax" runat="server" class="side_menu">
                <td align="right">Fax</td>
                <td>:</td>
                <td align="left">
                    <asp:Label ID="lblFax" runat="server"></asp:Label>  
                </td>
            </tr>                       
            
            
            <tr id="trHeadBus" runat="server"><td colspan="2" align="right" class="sub_menu"><asp:Label ID="Label21" runat="server" Text="Business Information"></asp:Label></td></tr>            
           <tr id="trKOB" runat="server" class="side_menu">
                <td align="right">Kind of Business</td>
                <td>:</td>
                <td align="left">
                    <asp:Label ID="lblKOB" runat="server"></asp:Label>  
                </td>
            </tr>
            <tr id="trbName" runat="server" class="side_menu">
                <td align="right">Business Name</td>
                <td>:</td>
                <td align="left">
                    <asp:Label ID="lblBname" runat="server"></asp:Label>
                </td>
            </tr>
            <tr id="trBusDesc" runat="server" class="side_menu">
                <td align="right">Business Description</td>
                <td>:</td>
                <td align="left">
                    <asp:Label ID="lblBdesc" runat="server"></asp:Label>  
                </td>
            </tr>                        
            <tr id="trURL" runat="server" class="side_menu">
                <td align="right">WebSite</td>
                <td>:</td>
                <td align="left">
                    <asp:Label ID="lblWebsite" runat="server"></asp:Label>  
                </td>
            </tr>
            <tr><td colspan="3" align="center">&nbsp;</td></tr>
            <tr><td colspan="3" align="center">&nbsp;</td></tr>  
           </table> 
           </td></tr>
           </table>
        </td>
        
      </tr>
    </table>
  </div>
  <div class="searchmid_boxbottam1"></div>
  </div>
  </div>
</div> 
</div>
<!-- end of the mid Box-->
<%--</div>--%>
<div class="content_midbootam" >
<bcm:Contentmid ID="contentmid" runat="server" />
</div>

<div class="content_bootam_center">
<bcon:Bottomcontent ID="bottomcontent" runat="server" />

</div>

<div class="footer" align="center">
<aa10:footer1 ID="sdsa" runat="server" />
<aa11:footer2 ID="poshv" runat="server" />
</div>

</div>
</form>
</body>
</html>
