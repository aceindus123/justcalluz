<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MoviePage.aspx.cs" Inherits="MoviePage" %>

<%--<%@ Register Src="usercontrols/moviesearch.ascx" TagName="movie_search" TagPrefix="movsrch" %>--%>
<%--<%@ Register Src="usercontrols/right_Movie.ascx" TagName="rightmov" TagPrefix="ritemov" %>--%>
<%@ Register Src="usercontrols/footer1.ascx" TagName="footer1" TagPrefix="aa10" %>
<%@ Register Src="usercontrols/footer2.ascx" TagName="footer2" TagPrefix="aa11" %>
<%@ Register Src="usercontrols/BottomContent.ascx" TagName="Bottomcontent" TagPrefix="bcon" %>
<%@ Register Src="usercontrols/BottomMidContent.ascx" TagName="Contentmid" TagPrefix="bcm" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%@ Register Src="usercontrols/signin.ascx" TagName="signin" TagPrefix="aa1" %>
<%@ Register Src="usercontrols/topimage.ascx" TagName="topimage" TagPrefix="aa2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
   <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>:: Justcalluz :: Movie Masti</title>
<%--<link href="css/style.css" rel="stylesheet" type="text/css" />
--%>
<link href="includes/style.css" rel="stylesheet" type="text/css" />
<link href="css/inner_style.css" rel="Stylesheet" type="text/css" />
<link href="starrater.css" rel="Stylesheet" type="text/css" />
<link href="css/style.css" rel="Stylesheet" type="text/css" />
<script type="text/javascript" src="js/jquery-1.2.6.min.js"></script>
<script type="text/javascript" src="js/jquery.rater.js"></script>
<script type="text/javascript">
    $(function () {
        $('#testRater');
    });
</script>
<script type="text/javascript">
   
    function YourChangeFun() {
        var ddl = document.getElementById("ddlSort");
        if (ddl.selectedIndex == 1) {
            document.getElementById("tdgen").disabled = false;
            //document.getElementById("ddlgen").style.verticalAlign = 'middle';
        }
        else
            document.getElementById("tdgen").disabled = true;
            
        
    }
</script>
<script type="text/javascript">    function postbackFromJS(sender, e) {
        var postBack = new Sys.Preview.PostBackAction();
        postBack.set_target(sender);
        postBack.set_eventArgument(e);
        postBack.performAction();
    }      
 </script>
 <script type="text/javascript">
     function aclick(urls) {

         var element = document.getElementById("myytplayer");
         element.setAttribute("data", urls + "?autoplay=0&amp;wmode=transparent&amp;rel=0");
         // window.open("movies.aspx?ul=" + urls);
     }

</script>
 <script src="js/swfobject_modified(movie).js" type="text/javascript"></script>
 <style >
 .movie
 {
     font-family:Arial;
     font-size:10pt;
     color:#036;
 }
 .movie a
 {
     font-family:Arial;
     font-size:10pt;
     color:Blue;
 }
 </style>
</head>
<body onload="YourChangeFun();">
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
<div class="layout">
<div class="signin">
<aa1:signin ID="suy" runat="server" />
</div>
<div class="logo" align="center" >
<aa2:topimage ID="iud" runat="server" />
</div>
<div class="logo" align="center" style="height:auto">
<table width="984" border="0" >
  <tr>
    <td height="120" align="center"><table width="612" border="0">
      <tr>
        <td height="10">&nbsp;</td>
      </tr>
      <tr>
        <td width="606" height="101"><object id="FlashID" classid="clsid:D27CDB6E-AE6D-11cf-96B8-444553540000" width="984" height="95">
          <param name="movie" value="images/justcalluz-movie-Add3-ani.swf" />
          <param name="quality" value="high" />
          <param name="wmode" value="opaque" />
          <param name="swfversion" value="6.0.65.0" />
          <!-- This param tag prompts users with Flash Player 6.0 r65 and higher to download the latest version of Flash Player. Delete it if you don’t want users to see the prompt. -->
          <param name="expressinstall" value="Scripts/expressInstall.swf" />
          <!-- Next object tag is for non-IE browsers. So hide it from IE using IECC. -->
          <!--[if !IE]>-->
          <object type="application/x-shockwave-flash" data="images/justcalluz-movie-Add3-ani.swf" width="984" height="95">
            <!--<![endif]-->
            <param name="quality" value="high" />
            <param name="wmode" value="opaque" />
            <param name="swfversion" value="6.0.65.0" />
            <param name="expressinstall" value="Scripts/expressInstall.swf" />
            <!-- The browser displays the following alternative content for users with Flash Player 6.0 and older. -->
            <div>
              <h4>Content on this page requires a newer version of Adobe Flash Player.</h4>
              <p><a href="http://www.adobe.com/go/getflashplayer"><img src="http://www.adobe.com/images/shared/download_buttons/get_flash_player.gif" alt="Get Adobe Flash player" width="112" height="33" /></a></p>
            </div>
            <!--[if !IE]>-->
          </object>
          <!--<![endif]-->
        </object></td>
      </tr>
    </table></td>
  </tr>
</table>
<%--<a href="Default.aspx"><img src="images/real1.png" width="960" height="209" /></a>--%>
</div>
<div class="search" align="center" style="padding-top:2px; height:auto;">
<%--<movsrch:movie_search ID="searchmovie" runat="server" />--%>
  <table width="100%" border="0">
    <tr>
      <td width="930" style=" width:935px; height:32px; background: #ECF9FF; border: solid #93DCFF 1px;" >
      <table width="100%" border="0">        
        <tr>
          <td  height="32">&nbsp;</td>
          <%--<td  class="mid_menu" align="left" style="background:#FC0; border: #FFD9C6 solid 2px; padding-left:5px;"></td>--%>
          <td  style="background:#FC0; border: #FFD9C6 solid 2px; padding-left:5px;"><span class="row"><font color="black"> City:</font> &emsp;
          <asp:DropDownList ID="ddlcities" runat="server"  >  <%--AutoPostBack="true"
                 onselectedindexchanged="ddlcities_SelectedIndexChanged">--%>
          
          </asp:DropDownList>
          <asp:RequiredFieldValidator ID="requ1" runat="server" InitialValue="select city" ControlToValidate="ddlcities" ValidationGroup="grp1" ErrorMessage="Select City From The List"  >*</asp:RequiredFieldValidator>
                      </span></td>
                       <td width="16%" style="background:#FC0; border: #FFD9C6 solid 2px; padding-left:5px;"><span class="row">
                       <asp:TextBox ID="txtArea" runat="server" Width="120"></asp:TextBox>
                       <cc1:TextBoxWatermarkExtender ID="txtwatmar" runat="server" TargetControlID="txtArea" WatermarkText="Enter Area"></cc1:TextBoxWatermarkExtender>
                      <%--<asp:DropDownList ID="ddlarea" runat="server" AutoPostBack="false"></asp:DropDownList>--%>
                    </span></td>
          <td  style="background:#FC0; border: #FFD9C6 solid 2px; padding-left:5px;"><span class="row">
                     <asp:DropDownList ID="ddlday" runat="server" AutoPostBack="false" Width="120">
                    
                     </asp:DropDownList>
                     </span>
                     <%--<asp:RequiredFieldValidator ID="requ2" runat="server" ControlToValidate="ddlday" InitialValue="select Day" ValidationGroup="grp1" ErrorMessage="Select Day From The List" >*</asp:RequiredFieldValidator>--%>
                     </td>
          <td  style="background:#FC0; border: #FFD9C6 solid 2px; padding-left:5px;"><span class="row">
                      <asp:DropDownList ID="ddlmovies" runat="server" AutoPostBack="false" Width="120">
                      <asp:ListItem Value="0" Text="All"></asp:ListItem>
                      <asp:ListItem Value="1" Text="Morning"></asp:ListItem>
                      <asp:ListItem Value="2" Text="Afternoon"></asp:ListItem>
                      <asp:ListItem Value="3" Text="Evening"></asp:ListItem>
                      <asp:ListItem Value="4" Text="Late"></asp:ListItem>
                      </asp:DropDownList>
                    </span>
                    <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="ddlmovies" InitialValue="All" ValidationGroup="grp1" ErrorMessage="Select Show Time" >*</asp:RequiredFieldValidator>--%>
                    </td>
                     <td  style="background:#FC0; border: #FFD9C6 solid 2px; padding-left:5px;"><span class="row">
                      <asp:DropDownList ID="ddlSort" runat="server"  Width="100" onchange="YourChangeFun();">
                      <asp:ListItem Value="0" Text="Theater"></asp:ListItem>
                      <asp:ListItem Value="1" Text="Movies"></asp:ListItem>                      
                      </asp:DropDownList>
                    </span>
                    <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="ddlmovies" InitialValue="All" ValidationGroup="grp1" ErrorMessage="Select Show Time" >*</asp:RequiredFieldValidator>--%>
                    </td>
                     <td id="tdgen" width="110" height="32" style="background:#FC0; border: #FFD9C6 solid 2px; padding-left:5px; ">
                    <span class="row">
                      <asp:DropDownList ID="ddlgen" runat="server" AutoPostBack="false" Width="100" >
                      <asp:ListItem Value="All" Text="All"></asp:ListItem>
                      <asp:ListItem Value="action" Text="action"></asp:ListItem>
                      <asp:ListItem Value="animation" Text="animation"></asp:ListItem>
                      <asp:ListItem Value="biography" Text="biography"></asp:ListItem>
                      <asp:ListItem Value="comedy" Text="comedy"></asp:ListItem>
                       <asp:ListItem Value="drama" Text="drama"></asp:ListItem>
                      <asp:ListItem Value="family" Text="family"></asp:ListItem>
                      <asp:ListItem Value="history" Text="history"></asp:ListItem>
                      <asp:ListItem Value="romance" Text="romance"></asp:ListItem>
                       <asp:ListItem Value="science fiction" Text="science fiction"></asp:ListItem>
                      <asp:ListItem Value="thriller" Text="thriller"></asp:ListItem>
                      </asp:DropDownList>                   
                    </span>
                    </td>
         

          <td ><asp:ImageButton ID="btngo" runat="server" 
                  ImageUrl="images/go.png" onclick="btngo_Click" Height="30" ValidationGroup="grp1" />
                  <asp:ValidationSummary ID="validsum" runat="server" ShowMessageBox="true" ShowSummary="false" ValidationGroup="grp1" />
          </td>
         <%-- <td width="16%" style="background: #BFEBFF; border: #BFEBFE solid 2px;"><span class="row">
                      <asp:DropDownList ID="ddlcinemahalls" runat="server" AutoPostBack="false" ></asp:DropDownList>
                    </span></td>
          <td width="5%"><asp:ImageButton ID="hallgo" runat="server" 
                  ImageUrl="images/go.png"  /></td>--%><%-- onclick="hallgo_Click"--%>
          <td width="5">&nbsp;</td>
          </tr>
  </table>
  </td>
    </tr>
  </table>
</div>
<!-- staart the Content-->
<div style="float:left; border:1px solid #0080c0;">
<table width="100%" runat="server">
<tr>
<td valign="top">
<object id="myytplayer"  data="http://www.youtube.com/embed/neeZNrN5Csw?autoplay=0&amp;wmode=transparent&amp;rel=0"
   width="400" height="500"></object>
</td>
<td>
<asp:Panel ID="pnlmovie" runat="server" Width="585" Height="500" ScrollBars="Vertical"  >
<table width="100%" style="padding-left:5px;">
<tr>
<td id="plchldrVideo" runat="server"></td>
</tr>
</table>
</asp:Panel>
</td>
</tr>
</table>
</div>

<script type="text/javascript">

    //swfobject.registerObject("FlashID");
    ////-->
</script>
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
    </form>
</body>
</html>
