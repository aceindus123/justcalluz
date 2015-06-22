<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Show-moreTaggedfriends.aspx.cs" Inherits="Show_moreTaggedfriends" %>
<%@ Register Src="usercontrols/footer1.ascx" TagName="footer1" TagPrefix="aa10" %>
<%@ Register Src="usercontrols/footer2.ascx" TagName="footer2" TagPrefix="aa11" %>
<%@ Register Src="usercontrols/BottomContent.ascx" TagName="bottomcontent" TagPrefix="aa4" %>
<%@ Register Src="usercontrols/BottomMidContent.ascx" TagName="bottomMidcontent" TagPrefix="aa5" %>
<%@ Register Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" TagPrefix="cc3"  %>
<%@ Register Src="usercontrols/signin.ascx" TagName="signin" TagPrefix="aa1" %>
<%@ Register Src="usercontrols/Search.ascx" TagName="catag" TagPrefix="aa6" %>
<%@ Register Src="usercontrols/SearchNew.ascx" TagName="SearchNew" TagPrefix="New" %>
<%@ Register Src="usercontrols/small_logo.ascx" TagName="logo" TagPrefix="S_logo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<%--<title>:: Just Calluz :: Tag Your Friend</title>--%>
<title>Register - JustCalluz | Sign Up & Tag Your Friends to Access Their Reviews</title>
<meta name='Title' content='Register - JustCalluz | Sign Up & Tag Your Friends to Access Their Reviews' />
<meta name='description' content='Register on JustCalluz for free and tag your friends to know about their reviews and ratings for Movies, Events, Restaurants, Pubs etc. Simply enter your contact number to start the process.' />
<meta name='keywords' content='justcalluz registration, justcalluz sign up, justcalluz registration, justcalluz register, justcalluz free registeration, justcalluz tagging, local search, yellow pages listing, business listing' />
		
<link href="css/inner_style.css" rel="stylesheet" type="text/css" />
<link href="css/style.css" rel="Stylesheet" type="text/css" />
	<link rel="stylesheet" href="pop-up/reveal.css" />
    <script type="text/javascript" src="js/jquery.rater.js"></script>    
   <link href="starrater.css" type="text/css" rel="Stylesheet" />
    <script type="text/javascript" src="http://code.jquery.com/jquery-1.6.min.js"></script>
		<script type="text/javascript" src="pop-up/jquery.reveal.js"></script>
         <script type="text/javascript" language="javascript">
             function isNumberKey(evt) {
                 var charCode = (evt.which) ? evt.which : event.keyCode
                 if (charCode != 46 && charCode > 31
            && (charCode < 48 || charCode > 57))
                     return false;

                 return true;
             }
     </script>
     <style type="text/css">
  
  .click3 {   color:#1274c0;  text-decoration:none; 
  font-family:Arial, Helvetica, sans-serif;
  font-size:12px; }


  .click3 a:link{  color:#1274c0;  text-decoration:none;
  font-family:Arial, Helvetica, sans-serif;
font-size:12px;}

  .click3 a:hover{  color:#ff6c00;  text-decoration:none;
  font-family:Arial, Helvetica, sans-serif;
font-size:12px;}

br.clear{ clear:both;}

h3{ font:14px/18px Verdana, Geneva, sans-serif; color:#666; font-weight:bold;}

.color_box{ background:#f7f7f7; width:100%;  margin-top:10px;
border-radius:5px;
-webkit-border-radius: 5px;
-moz-border-radius: 5px;
border-radius: 5px;
}
  
  
.color_box p{ font:12px/18px Arial, Helvetica, sans-serif;
color:#666;
 float:left; margin-left:10px;
}


.more_rating{background:#d4ecff; width:700px; height:30px; margin-top:10px;
color:#1274c0; text-align:center; padding:10px 0px 0px 0px;
border-radius:5px;
-webkit-border-radius: 5px;
-moz-border-radius: 5px;
border-radius: 5px;
	}
  </style>
     <script language="javascript" type="text/javascript">

         function confirm_delete() {
             if (confirm("Are you sure you want to untag this friend?") == true) {
                 return true;
             }
             else
                 return false;
         }
         </script>
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
<div class="content_innermid" style="width:100%;">
  <table width="100%" border="0">
     <tr>    
      <td style="width:100%;">

         <asp:Panel ID="pnlRatings" runat="server">
            <%-- <asp:DataList ID="dlratings" runat="server">
               <ItemTemplate>--%>
                   <div class="left_box">
   	                    <div class="tagged_left">
                               <span style="padding-top:15px;"><img src="images/tag_frilogo.png" width="58px" height="30px" align="left"  alt="tagfriend"/></span>
		<span style="padding-right: 79%; float: right;padding-top:8px;"><asp:HyperLink id="A2" NavigateUrl="<%$RouteUrl:RouteName=HomeRoute %>" runat="server"><font>Home</font></asp:HyperLink>&nbsp;>>Show all friends&nbsp;</span>
        
         </div>
<!----------------  tagged_left --------------> 
                        <div class="color_box">
                            <asp:DataList ID="dlFRatings" runat="server" Width="99%"  GridLines="None" DataKeyField="id">

                                <ItemTemplate>
<%--<span style="width:55px; height:110px; float:left; padding-left:15px;"> 
<img src="images/fri_icon.png" width="46" height="46" align="left"  vspace="10" hspace="5" alt="TagfriendIcon"/>
</span>--%>
  <div style="border-bottom:1px solid #dfdfdf; clear:both; padding-top:10px; margin-left:10px;">
  <table style="width:100%;"> <tr>
      <td class="click3"  align="center" style="width:200px;">        
                  <asp:LinkButton ID="lblname" runat="server" Text='<%#Eval("name") %>' CommandArgument='<%#Eval("id") %>' Font-Underline="false" OnCommand="FriendsRatings"></asp:LinkButton>
           (<asp:LinkButton ID="lblRating" runat="server" Text='<%#Eval("count") %>' CommandArgument='<%#Eval("id") %>' OnCommand="FriendsRatings" Font-Underline="false"></asp:LinkButton>)
            
</td>
      <td class="click3"  align="center" style="width:380px;">
        <asp:Label ID="Label1" runat="server" Text='<%#Eval("email") %>'></asp:Label>
  </td>
      <td class="click3" align="center" >
          <asp:Label ID="Label2" runat="server" Text='<%#Eval("mob") %>'></asp:Label>
</td>
  <td class="click3"  align="center" >
        <asp:Button ID="btnUntagfrnd" runat="server" Text="Untag Friend" Width="120px"
           style="margin-left:10px;"  class="inputtag" OnClientClick="return confirm_delete();" CommandArgument='<%#Eval("mob") %>' OnCommand="btnUntagfrnd_command"/>
</td>

</tr></table>
 </div>
</div>
</ItemTemplate>
 </asp:DataList>

<!--color_box end -->
                   </div>
                       
             <%--  
               </ItemTemplate>
             
             </asp:DataList>--%>
                       </div>
             </asp:Panel>
    
    </td>
    
    </tr>
       <tr id="trmessage" runat="server" visible="false">
<td colspan="4" align="center" style="padding-right:7px;">
    <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>
   
</td></tr>
      <tr id="trPaging" runat="server" visible="false">
<td colspan="4" align="right" style="padding-right:7px;">
   <span style="padding-right:5%;"> <asp:Label ID="lblCurrentPage" runat="server"></asp:Label></span>
    <asp:Button ID="imgPrevious" runat="server" Text="<<"  OnClick="imgPrevious_Click"/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="imgNext" runat="server" Text=">>"  OnClick="imgNext_Click" />
</td></tr>
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
<%--<aa10:footer1 ID="tevfd" runat="server" />--%>
<%--<aa11:footer2 ID="eqwr" runat="server" />--%>
</div>
</div>


    </form>
    
</body>
</html>
