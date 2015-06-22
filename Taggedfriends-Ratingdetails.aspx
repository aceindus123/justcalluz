<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Taggedfriends-Ratingdetails.aspx.cs" Inherits="Taggedfriends_Ratingdetails" %>
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
     <style>
  
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
		<span style="padding-right: 76%; float: right;padding-top:8px;"><asp:HyperLink id="A2" NavigateUrl="<%$RouteUrl:RouteName=HomeRoute %>" runat="server"><font>Home</font></asp:HyperLink>&nbsp;>>Tagged friends ratings&nbsp;</span>
        
         </div>
<!----------------  tagged_left --------------> 
                        <div class="color_box">
                            <asp:DataList ID="dlFRatings" runat="server" Width="100%" OnItemDataBound="dlFRatings_ItemDataBound">

                                <ItemTemplate>
<span style="width:55px; height:110px; float:left; padding-left:15px;"> 
<img src="images/fri_icon.png" width="46" height="46" align="left"  vspace="10" hspace="5" alt="TagfriendIcon"/>
</span>


<span style="width:630px;  float:left;">

<div style="border-bottom:1px solid #dfdfdf; clear:both; padding-top:10px; margin-left:10px;">
<span class="click3" style="padding-left:10px;"> <asp:Label ID="lblrname" runat="server" Text='<%#Eval("rname") %>'></asp:Label>
</span>
<span style="font:12px/18px Verdana, Geneva, sans-serif; color:#666;"> rated <asp:Label ID="Label1" runat="server" Text='<%#Eval("postdate") %>'></asp:Label> </span>
     <asp:Label ID="lblDataId" runat="server" Text='<%#Eval("id")%>' Visible="false"></asp:Label>
     <asp:Label ID="lblStarRating" runat="server" CssClass="ui-rater">
                            <asp:Label ID="Label2" runat="server" CssClass="ui-rater-starsOff" Width="90px" >
                                <asp:Label ID="testSpan0" runat="server" CssClass="ui-rater-starsOn">
                                </asp:Label>
                            </asp:Label>            
                        </asp:Label>
</div>

<p> 
<span class="click3"> <a href="#"> <b style="float:left;"><asp:HyperLink ID="lnkcompanytitle" runat="server" Text='<%#Eval("title") %>' NavigateUrl='<%# GetViewUrl(Eval("dataid")) %>'></asp:HyperLink>, <asp:Label ID="Label4" runat="server" Text='<%#Eval("City") %>'></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  </b>  
&nbsp;&nbsp;&nbsp;                 
<br/>
<asp:Label ID="Label5" runat="server" Text='<%#Eval("address") %>'></asp:Label>, <asp:Label ID="Label6" runat="server" Text='<%#Eval("City") %>'></asp:Label>,<asp:Label ID="Label7" runat="server" Text='<%#Eval("State") %>'></asp:Label> <br/>
</span>
<asp:Label ID="Label8" runat="server" Text='<%#Eval("review") %>'></asp:Label></p></span>

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
    <asp:Label ID="lblCurrentPage" runat="server"></asp:Label>
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
