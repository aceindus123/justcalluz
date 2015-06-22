<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Movie_ReadReviews.aspx.cs" Inherits="Movie_ReadReviews" %>
<%@ Register Src="usercontrols/moviesearch.ascx" TagName="movie_search" TagPrefix="movsrch" %>
<%@ Register Src="usercontrols/signin.ascx" TagName="signin" TagPrefix="sig" %>
<%@ Register Src="usercontrols/topimage.ascx" TagName="topimage" TagPrefix="aa2" %>
<%@ Register Src="usercontrols/right_Movie.ascx" TagName="rightmov" TagPrefix="ritemov" %>
<%@ Register Src="usercontrols/footer1.ascx" TagName="footer1" TagPrefix="aa10" %>
<%@ Register Src="usercontrols/footer2.ascx" TagName="footer2" TagPrefix="aa11" %>
<%@ Register Src="usercontrols/BottomContent.ascx" TagName="Bottomcontent" TagPrefix="bcon" %>
<%@ Register Src="usercontrols/BottomMidContent.ascx" TagName="Contentmid" TagPrefix="bcm" %>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Reviews for movies</title>
    <link href="starrater.css" rel="Stylesheet" type="text/css" />
   <link href="css/style.css" rel="stylesheet" type="text/css" />
<link href="style.css" rel="stylesheet" type="text/css" />
<script type="text/javascript" src="js/jquery-1.2.6.min.js"></script>
<script type="text/javascript" src="js/jquery.rater.js"></script>

<script type="text/javascript">
$(function() {
$('#testRater');
});
</script>
<script type="text/javascript">function postbackFromJS(sender, e) 
{
var postBack = new Sys.Preview.PostBackAction();
postBack.set_target(sender);
postBack.set_eventArgument(e);
postBack.performAction();
}      
 </script>
</head>
<body>
 <form id="form1" runat="server">
 <div class="layout">
 <div class="signin">
<sig:signin ID="sig1" runat="server" />
</div>
   <div class="logo" align="center" style="height:auto"><a href="Default.aspx">
   <img alt="real1Image" src="images/real1.png" width="960" height="209" /></a>
  </div>
<div class="search" align="center" style="padding-top:10px; height:auto">
<movsrch:movie_search ID="searchmovie" runat="server" />
</div>
<div>
<div class="content_left" style="width:75%; padding-left:none;">
   <%--<asp:Panel ID="Panel4" runat="server">  --%>     
 <table width="100%" border="0">
         <tr>
    <td colspan="3" class="sub_menu"><hr/></td>
    </tr>
         <tr>
    <td colspan="3" class="sub_menu">Reviews:</td>
  </tr>
  <tr>
    <td colspan="3" class="sub_menu"><hr/></td>
    </tr>
  <tr>
    <td colspan="3" align="center" class="sub_menu" bgcolor="#D9ECFF" height="30">
    <table width="100%" border="0">
    <tr id="trAllRatingHeading" runat="server">
        <td style="color:Black" align="center">        
        <table id="testRater" class="stat">
        <tr><td>
        <label for="rating">Overall Ratings (<asp:Label ID="lblrating" runat="server" Text="0"></asp:Label>)</label> &nbsp;&nbsp;&nbsp;&nbsp;       
         <asp:Label ID="Label4" runat="server" CssClass="ui-rater">
                                                <asp:Label ID="Label5" runat="server" CssClass="ui-rater-starsOff" Width="90px" >
                                                    <asp:Label ID="testSpan0" runat="server" CssClass="ui-rater-starsOn">
                                                    </asp:Label>
                                                </asp:Label>            
                                            </asp:Label>
    </td></tr>
    </table>
    </td>
   </tr>
   </table>
    </td>
    </tr>
     <tr>
    <td style="background:#E7F3FE; padding:10px;" >
      <asp:DataList ID="reviewdl" runat="server" RepeatDirection="Horizontal" OnItemDataBound="reviewdl_ItemDataBound"
               RepeatColumns="1" cellpadding="5" cellspacing="5" Width="100%"  
            Font-Size="Small" onselectedindexchanged="reviewdl_SelectedIndexChanged"> 
          <ItemTemplate><table width="100%"><tr><td height="183" valign="top" >
            <table width="100%" border="0">
     <%-- <tr>
        
        <td width="8%">&nbsp;</td>
        <td width="58%">&nbsp;</td>
      </tr>--%>
      <tr>
        <td height="30" colspan="4" valign="top" bgcolor="#000000" class="mobile" style="background:#FFC; border:1px solid #999; padding-left:5px;"><font color="#CC0000"><asp:Label ID="lblcmp" runat="server" Font-Bold="true" Font-Names="Arial" Font-Size="Large" ></asp:Label></font></td>
        </tr>
      <tr>
        
        <td width="8%" rowspan="3" valign="top" style="background:#E7F3FE; padding:10px;">
         <asp:Image  ID="imgReviewer" AlternateText="MovieImage"  runat="server"  ImageUrl='<%# Eval("ImageName", "../Review_Images\\{0}") %>'  Width="70"  Height="80"/><br/><br/>
        
        </td>
        
        <td style="background:#E7F3FE;"><span class="headings"> <%#DataBinder.Eval(Container.DataItem, "rname")%> Says</span><span><asp:Label ID="lblrating" runat="server" BorderColor="AliceBlue" BorderStyle="Dotted"></asp:Label>
        <asp:Label ID="rates" runat="server" Text='<%#Eval("Stars_Rating") %>' Visible="false"></asp:Label>
            
        <asp:Label ID="rate" runat="server" Text='<%#Eval("rating") %>' Visible="false"></asp:Label></span></td>
      </tr>
      <tr>
        
        <td colspan="2" style="background:#E7F3FE; padding:10px;" valign="top"> <%#DataBinder.Eval(Container.DataItem, "review")%></td>
      </tr>
             </table>
         </td></tr></table>
  
         </ItemTemplate>
     </asp:DataList>
    </td>
    </tr>
    <tr>
    <td>
    <asp:Label ID="lblmsg" runat="server" Text="No , Reviews Available. Be the first person to post review" Font-Bold="true" Font-Size="Medium" ForeColor="Maroon"></asp:Label>
    </td></tr>
    <tr>
          <td align="right" style="padding-left:30px">
            <asp:Button ID="cmdPrev" runat="server" Text=" << " OnClick="cmdPrev_Click"></asp:Button>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="cmdNext" runat="server" Text=" >> " OnClick="cmdNext_Click"></asp:Button>                              
       </td>
        </tr> 
          <tr>
         <td align="right" class="side_menu">
        <asp:Label ID="lblCurrentPage" runat="server"></asp:Label>
        </td>
        </tr>
        <tr><td><hr/></td></tr>
        <tr><td align="center">
             <asp:Button ID="btnBack" runat="server" Text="Back" onclick="btnBack_Click"/>
        </td></tr>
    
        
        </table> 
</div>
<div class="content_right" style="width:23%; padding:0px;">
  <ritemov:rightmov ID="right_Movie" runat="server" />
</div>
</div> 
      <%--</asp:Panel>--%>
 <div class="content_midbootam" >
<bcm:contentmid ID="contentmid" runat="server" />
</div>
<%--<div class="content_midbootam" >
</div>--%>
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
