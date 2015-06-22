<%@ Page Language="C#" AutoEventWireup="true" CodeFile="sessionstore.aspx.cs" Inherits="sessionstore" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%@ Register Src="usercontrols/signin.ascx" TagName="signin" TagPrefix="aa1" %>
<%@ Register Src="usercontrols/Search.ascx" TagName="catageories" TagPrefix="aa6" %>
<%@ Register Src="usercontrols/footer1.ascx" TagName="footer1" TagPrefix="aa10" %>
<%@ Register Src="usercontrols/footer2.ascx" TagName="footer2" TagPrefix="aa11" %>
<%@ Register Src="usercontrols/SearchNew.ascx" TagName="newsearch" TagPrefix="nsearch"%><%@ Register Src="usercontrols/SponsoredLinks.ascx" TagName="Splinks" TagPrefix="aa3" %>
<%@ Register Src="usercontrols/BottomMidContent.ascx" TagName="Contentmid" TagPrefix="bcm" %>
<%@ Register Src="usercontrols/BottomContent.ascx" TagName="Bottomcontent" TagPrefix="bcon" %>
<%@ Register Src="usercontrols/small_logo.ascx" TagName="logosmall" TagPrefix="lgsmall" %>
<%@ Register TagPrefix="OAR" TagName="Overalratin" Src="usercontrols/OverallRatings.ascx"%>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<%--<title>:: Justcalluz :: SessionStore page</title>--%>
<title id="pgtitle" runat="server"></title>

<link href="style.css" rel="Stylesheet" type="text/css" />
<script type="text/javascript" src="js/commanfunction.js"></script>
<link href="css/style.css" rel="stylesheet" type="text/css" />
<link href="css/inner_style.css" rel="Stylesheet" type="text/css" />
<%--<script src="Scripts/swfobject_modified.js" type="text/javascript"></script>--%>
<script type="text/javascript" src="js/jquery-1.2.6.min.js"></script>
<script type="text/javascript" src="js/jquery.rater.js"></script>

<%--<script src="SpryAssets/SpryTabbedPanels.js" type="text/javascript"></script>
<link href="SpryAssets/SpryTabbedPanels.css" rel="stylesheet" type="text/css" />--%>
<link href="css/tab.css" rel="stylesheet" type="text/css" />
<%--<script type="text/javascript" src="SpryAssets/accordian.pack.js"></script>
<script type="text/javascript" src="SpryAssets/accordian-src.js"></script>--%>
<script type="text/javascript">
    //[id*=btnModalPopup]
    $(document).ready(function () {
        numbersonly("#txtAMobile1");
        emailformat("#txtAUserid1");
        $("#btnLogin1").click(function () {
            return true;
        });
    });
    $(".anchors").live("click", function () {
//        document.getElementById("Label1").value = this.title;
//        storetext("Label1", "sessionstore.aspx", "assinglbl");
        $(".popupdiv").dialog({
            title: "Please fill the below credentials ",
            buttons: {
                Login: function () {
                    $("[id*=btnLogin1]").click();
                    },
                Close: function () {
                    $(this).dialog('X');
                }
            },
            modal: true
        });
        return false;
    });
    function txtchanged(txt) {
        storetext(txt, "sessionstore.aspx", "assignstring");
    }

    $(document).ready(function () {
        numbersonly("txtAMobile2");
        emailformat("#txtAUserid2");
        $("#btnLogin2").click(function () {
            return true;
        });
    });
    $(".anchors1").live("click", function () {
//        document.getElementById("Label2").value = this.title;
//        storetext("Label2", "sessionstore.aspx", "assinglbl");
        $(".popupdiv1").dialog({
            title: "Please fill the below credentials ",
            buttons: {
                Login: function () {
                    $("[id*=btnLogin2]").click();
                },
                Close: function () {
                    $(this).dialog('X');
                }
            },
            modal: true
        });
        return false;
    });
    function txtchanged1(txt) {
        storetext(txt, "sessionstore.aspx", "assignstring1");
    }
  

    $(document).ready(function () {
        numbersonly("txtAMobile");
        emailformat("#txtAUserid");
        $("#btnMyratings").click(function () {
            return true;
        });
    });
    $(".anchors2").live("click", function () {
//        document.getElementById("Label4").value = this.title;
//        storetext("Label4", "sessionstore.aspx", "assinglbl");
        $(".popupdiv2").dialog({
            title: "Please fill the below credentials ",
            buttons: {
                Login: function () {
                    $("[id*=btnMyratings]").click();
                },
                Close: function () {
                    $(this).dialog('X');
                }
            },
            modal: true
        });
        return false;
    });
    function txtchanged2(txt) {
        storetext(txt, "sessionstore.aspx", "assignstring2");
    }

</script>
<script type="text/javascript">
    function showmodalpopup() {
        $("#popupdiv").dialog({
            title: "",
            width: 430,
            height: 550,
            modal: true,
            buttons: {
                Close: function () {
                    $(this).dialog('close');
                }
            }
        });

    };

    function showmodalpopup1() {
        $("#popupdiv1").dialog({
            title: "",
            width: 430,
            height: 550,
            modal: true,
            buttons: {
                Close: function () {
                    $(this).dialog('close');
                }
            }
        });
    };

    function showmodalpopup2() {
        $("#popupdiv2").dialog({
            title: "",
            width: 430,
            height: 550,
            modal: true,
            buttons: {
                Close: function () {
                    $(this).dialog('close');
                }
            }
        });
    };




</script>
<script type="text/javascript">
$(function() {
$('#testRater');
});


</script>
<script src="http://ajax.googleapis.com/ajax/libs/jquery/1.11.1/jquery.min.js" type="text/javascript"></script>
<script type="text/javascript">
    $(document).ready(function () {
        $("#test1-header").click(function () {
            $("test2-content").hide();
            $("test1-content").show();
            $("#test1-header").addClass("accordion_headings  header_highlight");
            $("#test2-header").removeClass("header_highlight");
        });
        $("#test2-header").click(function () {
            $("test1-content").hide();
            $("test2-content").show();
            $("#test2-header").addClass("accordion_headings  header_highlight");
            $("#test1-header").removeClass("header_highlight");
        });
    });
</script>


    <script type="text/javascript">

        function Display() {

            document.getElementById("browndiv").className = "brown";

            document.getElementById("skybluediv").className = "skyblue";

        }

        function HidePopup() {

            document.getElementById("skybluediv").className = "hidepopup";

            document.getElementById("browndiv").className = "hidepopup";

            return false;

        }
        function Display1() {

            document.getElementById("browndiv1").className = "brown";

            document.getElementById("skybluediv1").className = "skyblue";

        }

        function HidePopup1() {

            document.getElementById("skybluediv1").className = "hidepopup";

            document.getElementById("browndiv1").className = "hidepopup";

            return false;

        }
        function Display2() {

            document.getElementById("browndiv2").className = "brown";

            document.getElementById("skybluediv2").className = "skyblue";

        }

        function HidePopup2() {

            document.getElementById("skybluediv2").className = "hidepopup";

            document.getElementById("browndiv2").className = "hidepopup";

            return false;

        }

</script>
 <script type="text/javascript">
     function Alphabets(nkey) {
         var keyval
         if (navigator.appName == "Microsoft Internet Explorer") {
             keyval = window.event.keyCode;
         }
         else if (navigator.appName == 'Netscape') {
             nkeycode = nkey.which;
             keyval = nkeycode;
         }
         //For A-Z
         if (keyval >= 65 && keyval <= 90) {
             return true;
         }
         //For a-z
         else if (keyval >= 97 && keyval <= 122) {
             return true;
         }
         //For Backspace
         else if (keyval == 8) {
             return true;
         }
         //For General
         else if (keyval == 0) {
             return true;
         }
         //For Space
         else if (keyval == 32) {
             return true;
         }
         else {
             return false;
         }
     } // End of the function


    </script>
    <script type="text/javascript">
        function onlyNos(e, t) {
            try {
                if (window.event) {
                    var charCode = window.event.keyCode;
                }
                else if (e) {
                    var charCode = e.which;
                }
                else { return true; }
                if (charCode > 31 && (charCode < 48 || charCode > 57)) {
                    return false;
                }
                return true;
            }
            catch (err) {
                alert(err.Description);
            }
        }
        </script>

 <link type="text/css" rel="stylesheet" href="http://code.jquery.com/ui/1.10.3/themes/smoothness/jquery-ui.css" />
<script type="text/javascript" src="http://code.jquery.com/jquery-1.8.2.js"></script>
<script type="text/javascript" src="http://code.jquery.com/ui/1.10.3/jquery-ui.js"></script>
<%--//Jquery popup--%>
 

<style type="text/css">
            #overlay {
            position: fixed;
            top: 0;
            left: 0;
            width: 100%;
            height: 100%;
            background-color: #000;
            filter:alpha(opacity=70);
            -moz-opacity:0.7;
            -khtml-opacity: 0.7;
            opacity: 0.7;
            z-index: 100;
            display: none;
            }
            .content1 a{
            text-decoration: none;
            }
            .popup{
            width: 100%;
            margin: 0 auto;
            display: none;
            position: fixed;
            z-index: 101;
            }
            .content1{
            min-width: 600px;
            width: 600px;
            min-height: 150px;
            margin: 100px auto;
            background: #f3f3f3;
            position: relative;
            z-index: 103;
            padding: 10px;
            border-radius: 5px;
            box-shadow: 0 2px 5px #000;
            }
            .content1 p{
            clear: both;
            color: #555555;
            text-align: justify;
            }
            .content1 p a{
            color: #d91900;
            font-weight: bold;
            }
            .content1 .x{
            float: right;
            height: 35px;
            left: 7px;
            position: relative;
            top: -5px;
            width: 34px;
            color:Red;

            }
            .content1 .x:hover{
            cursor: pointer;
            }
</style>
<script type="text/javascript" src="js/jquery-1.8.2.js"></script>

<%--<script type="text/javascript" src="http://maps.googleapis.com/maps/api/js?sensor=false"></script>
<script language="javascript" type="text/javascript">

    var map;
    var geocoder;
    function InitializeMap() {

        var latlng = new google.maps.LatLng(-34.397, 150.644);
        var myOptions =
        {
            zoom: 13,
            center: latlng,
            mapTypeId: google.maps.MapTypeId.ROADMAP,
            disableDefaultUI: false
        };
        map = new google.maps.Map(document.getElementById("divMap"), myOptions);
    }

    function FindLocaiton(lat,lng,addr) {
    
        InitializeMap();
        geocoder = new google.maps.Geocoder();
        var latlng = new google.maps.LatLng(lat,lng);
        map.setCenter(latlng);
        var marker = new google.maps.Marker({
            map: map,
            draggable:false,
            animation: google.maps.Animation.DROP,
            position: latlng
        });

        var infowindow = new google.maps.InfoWindow({
            content: '<div style =width:350px; height:200px; class=side_menu>Location info:<br/>'+ addr + '</div>'
        });
            google.maps.event.addListener(marker, 'click', function (){
            infowindow.open(map, marker);
            if (marker.getAnimation() != null)
              {
               marker.setAnimation(null);
              } 
            else
             {
                marker.setAnimation(google.maps.Animation.BOUNCE);
             }
             });

           return false;
    }
    window.onload = InitializeMap;

</script>
<script language="javascript" type="text/javascript">
function openpopup(id){
      //Calculate Page width and height
      var pageWidth = window.innerWidth;
      var pageHeight = window.innerHeight;
      if (typeof pageWidth != "number"){
      if (document.compatMode == "CSS1Compat"){
            pageWidth = document.documentElement.clientWidth;
            pageHeight = document.documentElement.clientHeight;
      } else {
            pageWidth = document.body.clientWidth;
            pageHeight = document.body.clientHeight;
      }
      } 
      //Make the background div tag visible...
//      var divbg = document.getElementById('bg');
//      divbg.style.visibility = "visible";
       
      var divobj = document.getElementById(id);
      divobj.style.visibility = "visible";
      if (navigator.appName=="Microsoft Internet Explorer")
      computedStyle = divobj.currentStyle;
      else computedStyle = document.defaultView.getComputedStyle(divobj, null);
      //Get Div width and height from StyleSheet
      var divWidth = computedStyle.width.replace('px', '');
      var divHeight = computedStyle.height.replace('px', '');
      var divLeft = (pageWidth - divWidth) / 2;
      var divTop = (pageHeight - divHeight) / 2;
      //Set Left and top coordinates for the div tag
      divobj.style.left = divLeft + "px";
      divobj.style.top = divTop + "px";
      //Put a Close button for closing the popped up Div tag
      if(divobj.innerHTML.indexOf("closepopup('" + id +"')") < 0 )
      divobj.innerHTML = "<a href=\"#\" onclick=\"closepopup('" + id +"')\"><span class=\"close_button\">X</span></a>" + divobj.innerHTML;
}
function closepopup(id){
//      var divbg = document.getElementById('bg');
//      divbg.style.visibility = "hidden";
      var divobj = document.getElementById(id);
      divobj.style.visibility = "hidden";
}
</script> 
<style type="text/css">
<!--
.popup {
      height: 253px;
      position: absolute;
      padding: 5px; overflow: auto;
      z-index: 2;
}
.popup_bg {
      position: absolute;
      visibility: hidden;
      height: 100%; width: 100%;
      left: 0px; top: 0px;
      filter: alpha(opacity=70); /* for IE */
      opacity: 0.7; /* CSS3 standard */
      background-color: #999;
      z-index: 1;
}
.close_button {
      font-family: Verdana, Geneva, sans-serif;
      font-size: small; font-weight: bold;
      float: right; color: #666;
      display: block; text-decoration: none;
      border: 2px solid #666;
      padding: 0px 3px 0px 3px;
}
body { margin: 0px; }
-->
</style>--%>
<style type="text/css">
        .modalBackground
        {  
        	background-color: Gray;  
        	filter: alpha(opacity=50);  
        	opacity: 0.50;
        }
       .updateProgress
       {  
       	border-width: 1px; 
        border-style: solid; 
        background-color: White;  
        position: absolute;  
        width: 180px;  
        height: 65px;
       }  
        .style24
    {
        height: 20px;
    }
     </style>
     <script language="Javascript" type="text/javascript">
       <!--
    function isNumberKey(evt) {
        var charCode = (evt.which) ? evt.which : event.keyCode
        if (charCode != 46 && charCode > 31
            && (charCode < 48 || charCode > 57))
            return false;

        return true;
    }
       //-->
    function hideshow() {
        document.getElementById('test1-content').style.display = 'block';
        document.getElementById('test2-content').style.display = 'none';
    }
    function hideshow1() {
        document.getElementById('test2-content').style.display = 'block';
        document.getElementById('test1-content').style.display = 'none';
    }
    </script>
</head>
<body >
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePageMethods="true">
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
<!-- staart the Content-->
<div class="content" style="padding:0; margin:0;">
<div class="content_innermid" style="width:79%">
<table width="100%" border="0">
 <tr>
 <td>
 <asp:DataList ID="dlData1" runat="server" Width="100%" 
             onitemdatabound="dlData1_ItemDataBound">
 <HeaderTemplate></HeaderTemplate>
 <ItemTemplate>
 <table border="0" width="100%">
  <tr>
 <td class="select_menu" style="padding-left:3px;">
 <a href="<%$RouteUrl:RouteName=HomeRoute%>" style="text-decoration:none" runat="server">Home</a> &gt; <%#DataBinder.Eval(Container.DataItem, "company_name")%> 
</td>
  </tr>
  <tr>
    <td style="background:url(images/event_send2.png) no-repeat" height="39" valign="middle">
     <table width="100%" border="0">
  <tr>
    <td width="9%">&nbsp;</td>
    <td width="20%" class="bottam"><strong class="side_menu">
        <%#DataBinder.Eval(Container.DataItem, "company_name")%>
        </strong>
     </td>
     <td width="18%">
            <span class="ui-rater">         
                <span class="ui-rater-starsOff" style="width:90px;"><span class="ui-rater-starsOn" runat="server" id="testSpan0"></span></span>
                <span class="ui-rater-rating" id="Span2" runat="server"></span>&nbsp;<span class="ui-rater-rateCount" id="Span3" runat="server"></span>
                </span>
    </td> 
    <td width="12%" class="mid_menu"><asp:Label ID="lblratingh" runat="server" Font-Bold="true"></asp:Label> 
        Rating(s)</td>
     <td width="3%"><asp:Image ImageUrl="images/rate those.png" runat="server" AlternateText="rateIcon" width="20" height="20" /></td>
      <td width="11%" class="mid_menu">
        <asp:HyperLink ID="lnkBtnRatethis" runat="server" NavigateUrl='<%# string.Format("PostReviewCat-" + Eval("id").ToString()) %>'>Rate 
          This</asp:HyperLink>
          <%--<asp:HyperLink ID="lnkBtnRatethis" runat="server" NavigateUrl='<%# GetReviewUrl(Eval("id")) %>'>Rate 
          This</asp:HyperLink>--%>
          </td>
     
      <td width="3%" align="right"><asp:Image ImageUrl="images/edit-icon.png" runat="server" AlternateText="EditIcon" width="20" height="20" /></td>
      <td width="11%" class="mid_menu" align="right" style="padding-right:10px">
      <%--<asp:LinkButton ID="lnkeditlisting" runat="server" Font-Underline="false" OnCommand="linkedit">Edit 
          Listing</asp:LinkButton>--%>
          <a id="lnkeditlisting" runat="server" onserverclick="linkedit_Click">Edit Listing</a>
          <cc1:ModalPopupExtender ID="poprptabuse" runat="server" TargetControlID="lnkeditlisting" PopupControlID="pnleditlisting"
      BackgroundCssClass="modalBackground" DropShadow="false" CancelControlID="btnclose">
          </cc1:ModalPopupExtender>
   </td>
    
  </tr>
</table>
</td>
  </tr>
  <tr>
    <td ><table width="100%" border="0">
  <tr>
    <td width="6%" align="center" style="padding-top:8px;"><asp:Image ImageUrl="images/contact.png" runat="server" AlternateText="contactIcon" width="24" height="24" /></td>
    <td width="25%" class="mid_menu" style="padding-top:8px;"> <asp:Label ID="Label2" runat="server" Text='<%#Eval("mob") %>'></asp:Label></td>
    <td width="3%" align="center" style="padding-top:8px;"><asp:Image ImageUrl="images/computer.png" runat="server" AlternateText="computerIcon" width="20" height="20" /></td>
    <td width="66%" class="mid_menu" style="padding-top:8px;"> <asp:Label ID="Label4" runat="server" Text='<%#Eval("emailid") %>'></asp:Label></td>
  </tr>
  <tr>
    <td height="28" colspan="4" ><hr/> </td>
    </tr>
</table>
</td>
  </tr>
 </table>
 </ItemTemplate>
 </asp:DataList>
 </td>
 </tr>
 <tr>
    <td>
    <table width="100%">
    <tr align="left">
    <td width="2%">
     <%--<asp:LinkButton ID="lnkBtnContact" runat="server" onclick="lnkBtnContact_Click" CssClass="sub_menu" Font-Underline="false">Contact</asp:LinkButton>--%>
     <a id="lnkBtnContact" runat="server" onserverclick="lnkBtnContact_Click" class="sub_menu">Contact</a>
    </td>
     <td width="1%">|</td><td width="8%">
    <%-- <asp:LinkButton ID="lnkmap" runat="server" CssClass="sub_menu" onclick="lnkmap_Click" Font-Underline="false" >View 
        Map</asp:LinkButton>--%>
        <a id="lnkmap" runat="server" class="sub_menu" onserverclick="lnkmap_Click">View Map</a>
     </td>
    <td width="1%">|</td>
    <td width="2%">
   <%-- <asp:LinkButton ID="lnkbtnphotos" 
            runat="server" onclick="lnkbtnphotos_Click" CssClass="sub_menu" Font-Underline="false">Photos</asp:LinkButton>--%>
        <a id="lnkbtnphotos" runat="server" class="sub_menu" onserverclick="lnkbtnphotos_Click">Photos</a>
     </td>
   <td width="1%">|</td>
    <td width="8%">
    <%-- <asp:LinkButton ID="lnkBtnMoreInfo" 
            runat="server" onclick="lnkBtnMoreInfo_Click" CssClass="sub_menu" Font-Underline="false">More 
        Info</asp:LinkButton>--%>
        <a id="lnkBtnMoreInfo" runat="server" class="sub_menu" onserverclick="lnkBtnMoreInfo_Click">More Info</a>       
   </td> <td width="1%">|</td>
   <td width="15%">
   <asp:LinkButton ID="lnkownlst" runat="server" CssClass="sub_menu" 
           Font-Underline="false"  onclick="lnkownlst_Click">Own this listing?</asp:LinkButton>
        <%--<a id="lnkownlst" runat="server" class="sub_menu" onserverclick="lnkownlst_Click">Own this listing?</a>--%>                  
   </td>
   <td width="15%">&nbsp;</td>
 
   <td width="10%">
  <%-- <asp:LinkButton ID="lnkreptabuse" runat="server" Text="Report Abuse" 
           CssClass="sub_menu" Font-Underline="false" onclick="lnkreptabuse_Click"></asp:LinkButton>--%>
        <a id="lnkreptabuse" runat="server" class="sub_menu" onserverclick="lnkreptabuse_Click">Report Abuse</a>                             
   </td>
  
   </tr>
   <tr><td>
    <cc1:ModalPopupExtender ID="poprptabuse" runat="server" TargetControlID="lnkreptabuse" PopupControlID="pnlreportabuse"
      BackgroundCssClass="modalBackground" DropShadow="false" CancelControlID="BtnRGo">
    </cc1:ModalPopupExtender></td></tr>
   </table>
   </td>
  </tr>
  <tr>
    <td><hr/></td>
  </tr>
 <tr> 
 <td>
 <asp:Label ID="lblerror" runat="server"></asp:Label>
    <asp:DataList ID="dlData" runat="server" Width="100%" 
         OnItemDataBound="dlData_ItemDataBound" 
         >
 <HeaderTemplate></HeaderTemplate>
 <ItemTemplate>
 <table border="0" width="100%">
  <tr>
    <td>
    <table width="100%" border="0">
  <tr>
    <td width="30%" rowspan="6" valign="top" style="padding-top:3px;" visible="false" id="tdlogo" runat="server">
     <asp:Label ID="lblImgName" runat="server" Text='<%# Eval("ImageName") %>' Visible="false"></asp:Label>
    <asp:Image  ID="imgReviewer"  runat="server" AlternateText="images" ImageUrl='<%# Eval("ImageName", "../Event_Images\\{0}") %>'  Width="200"  Height="150"/>
    </td>
    <td width="3%"><asp:Image ImageUrl="images/name.png" runat="server" AlternateText="nameIcon" width="20" height="20" /></td>
    <td width="67%" class="side_menu" height="21">
    <table width="100%">
    <tr>
    <td><%#DataBinder.Eval(Container.DataItem, "contact_person")%></td>
    <td align="right"><asp:ImageButton ID="imgbtnSendMAIL" AlternateText="btnSend" runat="server" ImageUrl="images/send-_button.png" OnClick="sendmailcommand"/>
          
   <cc1:ModalPopupExtender ID="ModalPopupExtender" runat="server"  
        TargetControlID="imgbtnSendMAIL" PopupControlID="Panel3" BackgroundCssClass="modalBackground" 
        OkControlID="imgCancel1" 
        DropShadow="false" PopupDragHandleControlID="panel4" ></cc1:ModalPopupExtender></td>
    </tr>
    </table>
    </td>
  </tr>
  <tr>
    <td><asp:Image ImageUrl="images/contact1.png" runat="server" AlternateText="contactIcon" width="20" height="20"/></td>
    <td class="side_menu" height="20"> <%#DataBinder.Eval(Container.DataItem, "landphno")%>|<%#DataBinder.Eval(Container.DataItem, "mob")%></td>
  </tr>
  <tr>
    <td><asp:Image ImageUrl="images/messanger.png" runat="server" AlternateText="MailIcon" width="20" height="20" /></td>
    <td height="20" class="side_menu">Send Enquiry by Email</td>
  </tr>
  <tr>
    <td><asp:Image ImageUrl="images/email.png" runat="server" AlternateText="emailIcon" width="20" height="20" /></td>
    <td height="30" class="side_menu">  <%#DataBinder.Eval(Container.DataItem, "Website")%></td>
  </tr>
  <tr>
    <td><asp:Image ImageUrl="images/homeafd.png" runat="server" AlternateText="HomeIcon" width="100%" height="20" /></td>
    <td class="side_menu"><%#DataBinder.Eval(Container.DataItem, "address")%><br /><%#DataBinder.Eval(Container.DataItem, "City")%>,<%#DataBinder.Eval(Container.DataItem, "State")%></td>
  </tr>
 <%-- <tr>
    <td>&nbsp;</td>
    <td height="40" class="mid_menu">Locate on Map &nbsp;|&nbsp;&nbsp;<span class="mid_menu">View Map</span></td>
  </tr>--%>
</table>
</td>
  </tr>
 </table>
 </ItemTemplate>
 </asp:DataList>
 <asp:Label ID="lblmovie" runat="server" Text="Movie Timings" ForeColor="Maroon" Font-Bold="true" Visible="false"></asp:Label>
 <br />
 <br />
 <asp:DataList ID="dltheatredetails" runat="server" Visible="false">
 <ItemTemplate>
 <table>
 <tr><td>
 <asp:Label ID="Label6" runat="server" Text='<%#Eval("Movie_Name")%>' Font-Size="12px" ForeColor="#003366" Font-Bold="true"></asp:Label>
 <asp:Label ID="Label8" runat="server" Text='<%#Eval("Movie_Language")%>' Font-Size="12px"></asp:Label>
 <asp:Label ID="Label4" runat="server" CssClass="ui-rater">
 <asp:Label ID="Label2" runat="server" CssClass="ui-rater-starsOff" Width="90px" >
  <asp:Label ID="testSpan0" runat="server" CssClass="ui-rater-starsOn">
  </asp:Label>
  </asp:Label>            
   </asp:Label> 
  </td>
 <tr>
  <td width="90%"><span class="list_data" style=" padding-right:10px; font: Georgia, 'Times New Roman', Times, serif">
  <asp:Label ID="Label1" runat="server" Text='<%#Eval("Timings")%>' Font-Size="12px"></asp:Label> </span>
      &nbsp;
  <span class="list_data" style=" padding-right:10px;"> 
  <span style="padding-top:10px;"><asp:ImageButton ID="lnkBtnURL" AlternateText="btnUrl" runat="server" ImageUrl="images/buy_ticket.png" Text="Buy Tickets" PostBackUrl='<%#Eval("URL") %>'/>
  </td>
   </tr>                                          
                                        
 </tr>
 </table>
 </ItemTemplate>
 </asp:DataList>
 	 <asp:DataList ID="dlphoto1" runat="server" RepeatDirection="Horizontal" 
         RepeatColumns="8">
            <ItemTemplate>     
            <table>
                <tr>
                    <td><a href='<%# Eval("PhotoName","Photos/{0}")%>' rel="prettyPhoto[pp_gal]" title='<%# Eval("Caption")%>'>
                    <img src='<%# Eval("PhotoName", "Photos/{0}") %>' alt='<%# Eval("PhotoName") %>' style="padding-right:5px" width="60" height="60" />
                      <%--  <asp:ImageButton ID="ImgPhoto" runat="server" Width="60" Height="60" ImageUrl='<%# Eval("PhotoName", "~/Photos\\{0}") %>'  OnClick="imgclick"/>--%>
                   </td>
                </tr>
            </table>                                                                        
            </ItemTemplate>                                                                                              
        </asp:DataList>
  <table id="sendbutton" width="100%"  runat="server"><tr><td align="right" style="padding-right:30px">
    
     </td></tr></table>
 <table border="0" width="100%" id="MorInfo" runat="server"> 
   <tr><td colspan="3"><span style="font-weight:bold; font-size:small; font-family:Arial">
      Hours Of Operation</span></td></tr>
<%--<tr><td colspan="7"></td></tr>--%>
<tr><td colspan="3">&nbsp;</td></tr>

  <tr style="vertical-align:middle" >
      <td  align="right" width="160px" height="30px">
      <span style="font-size:small; font-family:Arial">Monday</span>
      </td>  
      <td align="center" ><strong>&nbsp;:&nbsp;</strong></td>
      <td >          
          <asp:Label ID="lblMonday" runat="server"></asp:Label>
      </td>
  </tr>
  <tr><td colspan="3">&nbsp;</td></tr>
  <tr>
      <td align="right" width="160px" height="30px">
      <span style="font-size:small; font-family:Arial">Tuesday</span>
      </td>  
      <td align="center" ><strong>&nbsp;:&nbsp;</strong></td>
      <td>
          <asp:Label ID="lblTuesday" runat="server"></asp:Label></td>
  </tr>
  <tr><td colspan="3">&nbsp;</td></tr>
  <tr>
      <td align="right" width="160px" height="30px" >
      <span style="font-size:small; font-family:Arial">Wednesday</span>
      </td>  
      <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
      <td>
          <asp:Label ID="lblWednesday" runat="server"></asp:Label></td>
  </tr>
  <tr><td colspan="3">&nbsp;</td></tr>
  <tr>
      <td align="right" width="160px" height="30px" >
      <span style="font-size:small; font-family:Arial">Thursday</span>
      </td>  
      <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
      <td>
          <asp:Label ID="lblThursday" runat="server"></asp:Label></td>
  </tr>
  <tr><td colspan="3">&nbsp;</td></tr>
  <tr>
      <td align="right" width="160px" height="30px" >
      <span style="font-size:small; font-family:Arial">Friday</span>
      </td>  
      <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
      <td>
          <asp:Label ID="lblFriday" runat="server"></asp:Label></td>
  </tr>
  <tr><td colspan="3">&nbsp;</td></tr>
  <tr>
   <td align="right" width="160px" height="30px" >
     <span style="font-size:small; font-family:Arial;">Saturday</span>
   </td>
   <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
   <td><asp:Label ID="lblSaturday" runat="server"></asp:Label></td>
 </tr>
 <tr><td colspan="3">&nbsp;</td></tr>
 <%-- <tr>
      <td align="right" width="160px" height="30px">
      <span style="font-size:small; font-family:Arial">Saturday</span>
      </td>  
      <td align="center" width="15px"><strong>&nbsp;:&nbsp;</strong></td>
      <td>
          <asp:Label ID="lblSaturday" runat="server"></asp:Label></td>
  </tr>--%>
  <tr>
      <td align="right" width="160px" height="30px">
      <span style="font-size:small; font-family:Arial">Sunday</span>
      </td>  
      <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
      <td>
          <asp:Label ID="lblSunday" runat="server"></asp:Label></td>
  </tr> 
  <tr><td colspan="3">&nbsp;</td></tr>  
  <tr>
     <td colspan="3" style="background-image:url(images/hr.gif);background-repeat:repeat-x">
         &nbsp;</td>
  </tr>
   <tr>
   <td colspan="3">
   <span style="font-weight:bold; font-size:small; font-family:Arial">Payment Modes</span>
   </td>
   </tr>
   <tr><td align="right">
   <asp:Label ID="lblpaymodes" runat="server"></asp:Label>
   </td></tr>
  <tr>
     <td colspan="3" style="background-image:url(images/hr.gif);background-repeat:repeat-x">
         &nbsp;</td>
  </tr>
  <tr><td align="right"><span style="font-weight:bold; font-size:small; font-family:Arial">Year 
      Established</span></td>
  <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
  <td><asp:Label ID="lblyrestd" runat="server"></asp:Label></td>
  </tr>
 <tr><td align="right"><span style="font-weight:bold; font-size:small; font-family:Arial">No of 
     Employees</span></td>
 <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
 <td><asp:Label ID="lblempcount" runat="server"></asp:Label></td></tr>

 </table>
 </td>
 </tr>
 <tr><td>
   <asp:Panel ID="pnlMore" runat="server" Visible="false"> 
 <fieldset>
    <asp:Label ID="lblmore" runat="server" Text="No More Information is Available" ForeColor="Brown" Font-Bold="false" Font-Size="Medium"></asp:Label>
</fieldset>
 </asp:Panel>
 </td></tr>
   <tr><td>
   <div id="divMap" runat="server" style="height:253px">
   <%--<asp:Label ID="lblMap" runat="server"></asp:Label>--%>
   <iframe width="690px" height="253px" frameborder="0" scrolling="no" marginheight="0" marginwidth="0" src="http://maps.google.co.in/maps?f=q&amp;source=s_q&amp;hl=en&amp;q=Balakampet,+Hyderabad,+Andhra+Pradesh&amp;aq=&amp;sll=21.125498,81.914063&amp;sspn=22.7822,28.256836&amp;ie=UTF8&amp;geocode=FbEkCgEdXhGtBA&amp;split=0&amp;hq=&amp;hnear=Balakampet,+Hyderabad,+Andhra+Pradesh&amp;t=m&amp;z=14&amp;ll=17.441969,78.451038&amp;output=embed"></iframe><br />
  
   </div>
    <table id="tblmapctrl" runat="server" width="100%">
    <tr>
    <td>
        <a href="http://maps.google.co.in/maps?f=q&amp;source=s_q&amp;hl=en&amp;q=Balakampet,+Hyderabad,+Andhra+Pradesh&amp;aq=&amp;sll=21.125498,81.914063&amp;sspn=22.7822,28.256836&amp;ie=UTF8&amp;geocode=FbEkCgEdXhGtBA&amp;split=0&amp;hq=&amp;hnear=Balakampet,+Hyderabad,+Andhra+Pradesh&amp;t=m&amp;z=14&amp;ll=17.441969,78.451038&amp;output=embed" style="text-align:left;width:900px; height:400px" class="mid_menu">
        View Larger Map</a>
        &nbsp;&nbsp;&nbsp;&nbsp;
       <a href="#" class="mid_menu">Correct the location</a></td>
     </tr>
     </table>

   </td></tr>
   <tr>
   <td>
    <div id="divfotos" runat="server" style="height:350px">
   <table id="tblphotos" width="100%" runat="server">
       <tr>
   <td>
   
  <div id="basic-accordian" style="width:670px;height:330px"><!--Parent of the Accordion-->
<div style="width:180px; float:left;">
  <div id="test1-header" class="accordion_headings" onclick="hideshow()">company logo</div>
  <div id="test2-header" class="accordion_headings" onclick="hideshow1()" >Photos</div>
 </div>
<div style="float:right; width:485px;">
  <div id="test1-content">
	<div class="accordion_child" style="line-height:1.5;height:250px">
   	<asp:DataList ID="ddlLogo" runat="server" RepeatDirection="Vertical" 
            >
            <ItemTemplate> 
             <asp:ImageButton ID="ImgLogo" AlternateText="Logo" runat="server" ImageUrl='<%# Eval("ImageName", "~/Logos\\{0}") %>' Height="250"
                Style="border: 1px solid black;width:auto"/>                                    
              
            </ItemTemplate>                                   
        </asp:DataList>
        <asp:Label ID="lblNoLogo" runat="server" ForeColor="Green"></asp:Label>
   	</div>
  </div>
  
  <div id="test2-content" style="display:none">
	<div class="accordion_child" style="line-height:1.5;height:250px">
	 <div style="text-align:center">
     <%--  OnClick="imgShowImage_Click"--%>
            <asp:ImageButton ID="imgShowImage" runat="server" 
                Height="220" AlternateText="showImage"
                Style="border: 1px solid black; width:410px"/>
           
            <asp:Label runat="Server" ID="imageLabel1" CssClass="sub_menu"/><br /><br />
            <asp:Button runat="Server" ID="prevButton" Text="Prev" Font-Size="Small"/>
            <asp:Button runat="Server" ID="playButton" Text="Play" Font-Size="Small" />
            <asp:Button runat="Server" ID="nextButton" Text="Next" Font-Size="Small" />
           
        <cc1:SlideShowExtender ID="SlideShowExtender1" runat="server" 
                TargetControlID="imgShowImage"
                SlideShowServiceMethod="GetSlides"
                AutoPlay="false"
                ImageDescriptionLabelID="imageLabel1"
                NextButtonID="nextButton"
                PlayButtonText="Play"
                StopButtonText="Stop"
                PreviousButtonID="prevButton"
                PlayButtonID="playButton"
                Loop="true">
        </cc1:SlideShowExtender>
        </div>
	 
    </div>
  </div>

</div>
</div>
   </td>
   </tr>
   </table>
   </div>
   </td>
   </tr>
   <tr>
   <td>
   <div style="height:253px" id="divOwn" runat="server">
   <table border="0" width="100%">
   <tr><td>
       <asp:Panel ID="pnlupload" runat="server" BorderColor="White">
        <fieldset>
        <table width="100%" border="0">
        <tr align="center">
        <td width="12%">
        <asp:Image ImageUrl="images/logo.png" runat="server" AlternateText="LogoIcon" width="60" height="72" />
        </td>
        <td width="12%">
         <asp:Image ImageUrl="images/photos.png" runat="server" AlternateText="photosIcon" width="60" height="72" />
        </td>
       <%-- <td width="12%">
        <asp:Image ImageUrl="images/videos.png" runat="server" AlternateText="videosIcon" width="60" height="72" />
        </td>--%>
        <td width="7%">&nbsp;</td>
        <td width="60%" align="left">
        <p class="mid_menu">
            Enhance your listing by uploading your Logo and Pictures. This gives you 
            enhanced visibility and a great competitive edge. 
        </p>
        </td>
        </tr>
           <tr align="center">
        <td class="sub_menu">
            LOGO
        </td>
        <td class="sub_menu">
            PICTURES
        </td>
       <%-- <td class="sub_menu">
            VIDEOS
        </td>--%>
         <td>&nbsp;</td>
         <td>&nbsp;</td>
        </tr>
        <tr>
        <td colspan="4">&nbsp;</td>
        <td align="center" >
        <asp:LinkButton ID="lnkuploadphoto" runat="server" 
                Text="Upload" CssClass="sub_menu" Font-Underline="false" class="anchors1" OnClick="upload_click"></asp:LinkButton>
       <%-- <a id="lnkuploadphoto1" runat="server" class="sub_menu"><asp:Label ID="lblUpload" runat="server" Text="upload" CssClass="pointer" ForeColor="Red"></asp:Label></a>--%>
       </td>
       </tr> 
        </table>
        </fieldset>
        </asp:Panel>
    
        <asp:Panel ID="pnluploadphoto" runat="server">
        <fieldset>
        <table border="0" width="100%">
        <tr>
        <td>
        <table>
        <tr><td class="sub_menu">Upload Photo</td></tr>
        <tr>
        <td align="center">
            <asp:FileUpload ID="photoupload" runat="server"/>
            <asp:RequiredFieldValidator ID="RFVphotos" runat="server" ValidationGroup="photos" ControlToValidate="photoupload">*</asp:RequiredFieldValidator>
            <br />
         <asp:TextBox ID="txtCaption" runat="server" Width="220px"></asp:TextBox>
          <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ValidationGroup="photos" ControlToValidate="txtCaption">*</asp:RequiredFieldValidator>
            <cc1:TextBoxWatermarkExtender ID="txtExtenderCaption" runat="server" TargetControlID="txtCaption" WatermarkText="Enter Caption for Image">
            </cc1:TextBoxWatermarkExtender>
        </td>
         <td><asp:ImageButton ID="imgphoto" runat="server" AlternateText="imagPhoto" ImageUrl="images/Upload-Photos.png" onclick="btnUploadPhotos_Click" ValidationGroup="photos" />
               <%-- &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:ImageButton ID="imgcancel" runat="server" 
                 ImageUrl="images/cancel-button.png" onclick="imgcancel_Click" />--%>
        </td>
        </tr>
     
        </table>
        </td>
        </tr>
        <tr><td>&nbsp;</td></tr>
        <%--<tr>
        <td>
        <table>
        <tr><td class="sub_menu">Upload Video</td></tr>
        <tr>
        <td align="center">
            <asp:FileUpload ID="videoupload" runat="server" />
             <asp:RequiredFieldValidator ID="RFVvideo" runat="server" ValidationGroup="video" ControlToValidate="videoupload">*</asp:RequiredFieldValidator>
        </td>
          <td><asp:ImageButton ID="imgvideo" AlternateText="imagvideo" runat="server" ImageUrl="images/Upload-Video.png" onclick="btnUploadVedios_Click" ValidationGroup="video" /></td>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:ImageButton ID="ImageButton2" runat="server" 
                 ImageUrl="images/cancel-button.png" onclick="imgcancel_Click" />
        </tr>
        </table></td></tr>--%>
         <tr><td>&nbsp;</td></tr>
        <tr>
        <td>
        <table>
        <tr><td class="sub_menu">Upload Logo</td></tr>
        <tr>
        <td align="center">
            <asp:FileUpload ID="logoupload" runat="server" />
            <asp:RequiredFieldValidator ID="RFVlogo" runat="server" ValidationGroup="logo" ControlToValidate="logoupload">*</asp:RequiredFieldValidator>
        </td>
        <td>
         <asp:ImageButton ID="imglogo" AlternateText="imgelogo" runat="server" ImageUrl="images/Upload-Logo.png" onclick="btnUploadLogo_Click" ValidationGroup="logo" />
        </td>
        </tr>
        <tr><td><asp:ImageButton ID="imgcancel" runat="server" AlternateText="imgeCancel" 
                 ImageUrl="images/cancel-button.png" onclick="imgcancel_Click" /></td></tr>
             <tr><td>
                 <asp:Label ID="lblMessage" runat="server"></asp:Label></td></tr>
        </table></td>
        </tr>
        </table>
        </fieldset>
        </asp:Panel>
   </td></tr>
   
  
  </table>
   </div>
   </td>
  </tr>
   <tr><td>
 <asp:Panel ID="pnlNoMap" runat="server"> 
 <fieldset>
    <asp:Label ID="lblmap" runat="server" Text="No preview Available" ForeColor="Brown" Font-Bold="false" Font-Size="Medium"></asp:Label>
 </fieldset>
 </asp:Panel>
<asp:Panel ID="pnlmap" runat="server"> 
 <fieldset>
 <asp:DataList ID="dlmap" runat="server" DataKeyField="id">
 <ItemTemplate>
 <table>
 <tr><td colspan="5" align="right">
 <asp:Label ID="lblmap" runat="server" Text="No preview Available" ForeColor="Brown" Font-Bold="false" Font-Size="Medium" Visible="false"></asp:Label>
 </td></tr>
 <tr>
  <td width="40%" class="bottam"><strong class="side_menu">
        <%#DataBinder.Eval(Container.DataItem, "map")%>
        </strong></td>
 </tr>
 </table>
 </ItemTemplate>
 </asp:DataList>
 </fieldset>
 </asp:Panel>

 </td></tr>
  <tr>
    <td  height="30" style="background:url(images/rating.png) no-repeat"><table width="100%" border="0">
     
  <tr>
    <td width="10%" class="mid_menu" style="padding-left:8px;">
     <asp:LinkButton ID="lnkAllRatings" runat="server" onclick="lnkAllRatings_Click" >All Ratings(<asp:Label ID="lblrating1" runat="server" Text="0"></asp:Label>)</asp:LinkButton>
    </td>
    <td width="1%">|</td>
    <td width="12%" class="mid_menu">
       <asp:LinkButton ID="lnkFratings" runat="server" class="anchors" OnClick="lnkFratings_Click">Friends Ratings</asp:LinkButton>
    </td>
    <td width="1%">|</td>
    <td width="18%" class="mid_menu">
       <asp:LinkButton ID="lnkMyRatings" runat="server"  OnClick="lnkMyRatings_Click" class="anchors2">My Ratings </asp:LinkButton>
    </td>
    <td width="4%">&nbsp;</td>
    <td width="4%">&nbsp;</td>
   <%-- <td width="1%" align="right"><asp:Image ImageUrl="images/rating.1.png" AlternateText="imgRating" runat="server" width="24" height="24"/></td>
    <td width="14%" class="mid_menu" align="left" style="padding-right:0px">
      <asp:HyperLink ID="lnkRateThis1" runat="server" NavigateUrl='<%# string.Format("PostReviewCat.aspx?DataId=" + Eval("id").ToString()) %>'>Rate 
        this</asp:HyperLink>
    </td>--%>
  </tr>
</table>
</td></tr>
 <tr>
  <td><table width="100%" border="0">
   <tr id="trAllRatingHeading" runat="server">
        <td align="center">        
            <table id="testRater" class="stat">
            <tr><td class="side_menu">
            <label for="rating">Overall Ratings
             <span class="ui-rater">         
                    <span class="ui-rater-starsOff" style="width:90px;"><span class="ui-rater-starsOn" runat="server" id="testSpan0"></span></span>
                    <span class="ui-rater-rating" id="Span2" runat="server"></span>&nbsp;<span class="ui-rater-rateCount" id="Span3" runat="server"></span>
                    </span>
                     (<asp:Label ID="lblrating" runat="server" Text="Label"></asp:Label>)
                     </label> &nbsp;&nbsp;&nbsp;&nbsp;       
              </td></tr>
            </table>
       </td>
   </tr>
  <tr>
     <td align="center" width="48%" style="padding-top:10px;" valign="top">
      <OAR:Overalratin ID="overallrating" UserWidth="200" runat="server" />
    </td>
  </tr>
</table>
</td>
  </tr>
 <tr><td align="center">
     &nbsp;
    </td></tr>
 </table>
 
 <table width="100%" border="0"><tr>
    <td>
     <asp:DataList ID="dlReview" runat="server" Width="100%" OnItemDataBound="dlReview_ItemDataBound">
             <ItemTemplate>
             <table width="100%" border="0">
  <tr>
    <td width="12%" rowspan="4" style="padding-bottom:20px;" ><asp:Image ID="imgReviewer" runat="server" ImageUrl='<%# Eval("ImageName", "~/Review_Images\\{0}") %>' Width="64" Height="64"/></td>
    <td width="73%" class="select_menu" height="20"> <asp:Label ID="lblname" runat="server" Text='<%#Eval("rname") %>'></asp:Label></td>
    <td width="15%"> <asp:Label ID="lblrating" runat="server" ></asp:Label>
                               <asp:Label ID="lblRate" runat="server" Text='<%#Eval("Stars_Rating") %>' Visible="false"></asp:Label></td>
  </tr>
  <tr>
    <td class="select_menu" height="30"><font color="#E10000"><asp:Label ID="Label4" runat="server" Text='<%#Eval("email") %>'></asp:Label>
        |<asp:Label ID="Label2" runat="server" Text='<%#Eval("mob") %>'></asp:Label></font><br/><hr/></td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td class="select_menu" height="35"><asp:Label ID="Label7" runat="server" Text='<%#Eval("review") %>'></asp:Label></td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td colspan="2"><hr /></td>
  </tr>
</table>
  </ItemTemplate>
</asp:DataList>
</td>
</tr>
<tr>
  <td align="right">
  <asp:ImageButton ID="imgPrevious" runat="server" AlternateText="btnPrevious" ImageUrl="images/arrow_2.png" OnClick="imgPrevious_Click"/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:ImageButton ID="imgNext" runat="server" AlternateText="btnNext" ImageUrl="images/arrow_1.png" OnClick="imgNext_Click" />
    <%--<asp:Button ID="cmdPrev" runat="server" Text=" << " OnClick="cmdPrev_Click"></asp:Button>
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="cmdNext" runat="server" Text=" >> " OnClick="cmdNext_Click"></asp:Button>  --%>                            
  </td>
</tr> 
        <tr><td></td></tr>
<tr>
    <td align="center" class="style24">
        <asp:Label ID="lblCurrentPage" runat="server"></asp:Label>
    </td>
</tr>
</table>
<table>
  <tr><td>&nbsp;
    <asp:Panel ID="Panel3" runat="server" Width="350px">
 <asp:Panel ID="Panel4" runat="server">
 </asp:Panel>
<div class="dilogbox">
  <table width="350px">
    <tr>
      <td colspan="2" align="center" valign="top" 
        style="font-family:Arial; font-size:large; color:#003366; padding-top:3px;">Get Information by sms/email
        &nbsp;&nbsp;&nbsp;
      <asp:ImageButton ID="imgCancel1" AlternateText="Cancel" ImageUrl="images/panel/cencel.png" width="21" height="22" runat="server"/></td>
   </tr>
   <tr><td>&nbsp;</td></tr>
   <tr>
   <td height="174" colspan="2">
    <table align="center" width="400px" style="height: 154px;">
     <tr>
       <td align="right">
       <span class="star">*</span>
        <asp:Label ID="Label3" runat="server" Text="Name" Font-Bold="false" ForeColor="Black" ></asp:Label>
        </td>
        <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
       <td>
        <asp:TextBox ID="txtname" runat="server" ValidationGroup="modal" Width="160px" Height="25px" onkeypress="return Alphabets(event);"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvtxtname" runat="server" 
            ControlToValidate="txtname" ErrorMessage="Enter Name" 
            ValidationGroup="sendmail">*</asp:RequiredFieldValidator>
     </td>
     </tr>
      <tr>
        <td align="right">
        <span class="star">*</span>
            <asp:Label ID="Label5" runat="server" Text="Mobile_No" ForeColor="Black" Font-Bold="false" ></asp:Label>
        </td>
        <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
        <td>
            <asp:TextBox ID="txtmob" runat="server" ValidationGroup="sendmail" Width="160px" Height="25px" MaxLength="11" onkeypress="return onlyNos(event,this);"></asp:TextBox>
         <asp:RegularExpressionValidator ID="revtxtmob" runat="server" 
            ControlToValidate="txtmob" ErrorMessage="Enter mobile number only ten digits(starting number should starts from 1 to 9 digits)" 
            ValidationExpression="^[01]?[- .]?(\([1-9]\d{2}\)|[1-9]\d{2})[- .]?\d{3}[- .]?\d{4}$" Display="Dynamic" ValidationGroup="sendmail"></asp:RegularExpressionValidator>
         <asp:RequiredFieldValidator ID="rfvtxtmob" runat="server" 
            ErrorMessage="Please enter contact number" ControlToValidate="txtmob"  
            ValidationGroup="sendmail">*</asp:RequiredFieldValidator>
        <asp:RangeValidator ID="rvtxtmob" runat="server" 
            ErrorMessage=" Mobile Number must start with 0" ControlToValidate="txtmob"  
            MaximumValue="1" MinimumValue="0" 
            ValidationGroup="sendmail">*</asp:RangeValidator>
       </td>
      </tr>
     <tr>
        <td align="right">
        <span class="star">*</span>
            <asp:Label ID="Label7" runat="server" Text="Email_Id" ForeColor="Black" Font-Bold="false" ></asp:Label>
        </td>
        <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
        <td>
            <asp:TextBox ID="txtemail" runat="server" ValidationGroup="modal" Width="160px" Height="25px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvtxtemail" runat="server" ControlToValidate="txtemail" 
            ErrorMessage="please enter Email id"  ValidationGroup="sendmail">*</asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="revtxtemail" runat="server" 
            ErrorMessage="Incorrect Format of email address" 
            ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
            ValidationGroup="sendmail" ControlToValidate="txtemail" >*</asp:RegularExpressionValidator>
             <asp:ValidationSummary ID="ValidationSummary3" runat="server" 
              ValidationGroup="sendmail" ShowMessageBox="True" ShowSummary="False" />
        </td>
    </tr>
    </table>
    </td>
  </tr>
  <tr>
  <td width="241" height="37">&nbsp;</td>
  <td width="163" valign="top">
  <asp:ImageButton ID="imgbtnGo" OnClick="imgbtnGo_Click" AlternateText="Go" ImageUrl="images/panel/dialog_buttan.png" width="98" height="35" runat="server" ValidationGroup="sendmail"/>
  </td>
</tr>
    </table>
</div>
</asp:Panel> 
 </td>
  </tr>
  <tr><td>
<asp:Panel ID="pnlreportabuse" runat="server" Width="350px">
<div class="dilogbox">
<table width="350px">
<tr>
<td colspan="2" align="center" valign="top" 
        
        style="font-family:Arial; font-size:large; color:#003366; padding-top: 5px;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Report Abuse !
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;
   <asp:ImageButton ID="BtnRGo" AlternateText="RCancel" ImageUrl="images/panel/cencel.png" width="21" height="22" runat="server"/></td>
</tr>
<tr>
  <td height="190px" colspan="2">
     <table align="center" width="400px" style="height: 174px;">
      <tr>
        <td align="right">
         <span class="star">*</span><asp:Label ID="lblname" runat="server" Text="Name" ForeColor="Black" Font-Bold="false" ></asp:Label>
        </td>
         <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
        <td>
         <asp:TextBox ID="txtrname" runat="server" Width="160px" Height="25px" onkeypress="return Alphabets(event);"></asp:TextBox>
         <asp:RequiredFieldValidator ID="rfvtxtrname" runat="server" 
             ControlToValidate="txtrname" ErrorMessage="Please enter your Name" 
             ValidationGroup="abuse">*</asp:RequiredFieldValidator>
       </td>
      </tr>
      <tr>
        <td align="right">
         <span class="star">*</span><asp:Label ID="lblcontno" runat="server" Text="Contact No" ForeColor="Black" Font-Bold="false"></asp:Label>
        </td>
         <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
        <td>
         <asp:TextBox ID="txtcntno" runat="server" MaxLength="11" Width="160px" Height="25px" onkeypress="return onlyNos(event,this);"></asp:TextBox>
         <asp:RegularExpressionValidator ID="revtxtcntno" runat="server" 
             ControlToValidate="txtcntno" ErrorMessage="Enter contact number only ten digits(starting number should starts from 1 to 9 digits)" 
             ValidationExpression="^[01]?[- .]?(\([1-9]\d{2}\)|[1-9]\d{2})[- .]?\d{3}[- .]?\d{4}$" Display="Dynamic" ValidationGroup="abuse"></asp:RegularExpressionValidator>
         <asp:RequiredFieldValidator ID="rfvtxtcntno" runat="server" 
             ControlToValidate="txtcntno" ErrorMessage="Please enter your contact number" 
             ValidationGroup="abuse">*</asp:RequiredFieldValidator>
             <asp:RangeValidator ID="rgvtxtcntno" runat="server" 
          ControlToValidate="txtcntno" ErrorMessage="Number must start with 0" 
          MaximumValue="1" MinimumValue="0" ValidationGroup="abuse">*</asp:RangeValidator></td>
        </tr>
      <tr>
        <td align="right">
        <span class="star">*</span><asp:Label ID="lblemail" runat="server" Text="Email Id" ForeColor="Black" Font-Bold="false"></asp:Label></td>
         <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
        <td>
         <asp:TextBox ID="txtmail" runat="server" Width="160px" Height="25px"></asp:TextBox>
         <asp:RequiredFieldValidator ID="rfvtxtmail" runat="server" 
             ControlToValidate="txtmail" ErrorMessage="please enter your email id" 
             ValidationGroup="abuse">*</asp:RequiredFieldValidator>
         <asp:RegularExpressionValidator ID="revtxtmail" runat="server" 
             ControlToValidate="txtmail" ErrorMessage="incorrect format of email id" 
             ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
             ValidationGroup="abuse">*</asp:RegularExpressionValidator>
        </td>
        </tr>
      <tr>
        <td align="right">
        <span class="star">*</span><asp:Label ID="lblcomment" runat="server" Text="Comment" ForeColor="Black" Font-Bold="false"></asp:Label>
        </td>
        <td><strong>&nbsp;:&nbsp;</strong></td>
        <td>
        <asp:TextBox ID="txtcmnt" runat="server" TextMode="MultiLine" Width="160px" Height="25px"></asp:TextBox>
         <asp:RequiredFieldValidator ID="rfvtxtcmnt" runat="server" 
             ControlToValidate="txtcmnt" ErrorMessage="Please report your abuse" 
             ValidationGroup="abuse">*</asp:RequiredFieldValidator>
          <asp:ValidationSummary ID="ValidationSummary2" runat="server" 
                validationgroup="abuse" ShowMessageBox="True" ShowSummary="False" />
      </td>
      </tr>
      </table>
 </td>
</tr>
<tr>
  <td width="241" height="37">&nbsp;</td>
  <td width="163" valign="top" style="padding:0px 0px 5px opx;">
  <asp:ImageButton ID="imgAbuseGo" AlternateText="RGo" OnClick="imgAbuseGo_Click" ImageUrl="images/panel/dialog_buttan.png" width="98" height="35" runat="server" ValidationGroup="abuse"/>
  </td>
</tr>
</table>
</div>
</asp:Panel>
  
<asp:Panel ID="pnleditlisting" runat="server" Width="350px" BorderColor="Gray">
<div class="dilogbox">
<table width="100%" border="0">
  <tr>
    <td width="60%" class="sub_menu">&nbsp;&nbsp; &nbsp;<asp:Label ID="Label6" runat="server" Text="Help us Improve this Listing"></asp:Label></td>
    <td width="37%" height="38" align="right">
        <asp:ImageButton ID="btnclose" AlternateText="EClose" runat="server" ImageUrl="images/panel/cencel.png" Width="21" Height="22" />
   </td>
    <td width="3%">&nbsp;</td>
  </tr>
<tr>
    <td height="176" colspan="3">
    <table width="100%" border="0">
     <tr><td colspan="2" class="side_menu" style="padding-left:5px;">Select from the operation below :</td></tr>
     <tr>
     <td height="30" style="padding-left:5px;">
       <asp:RadioButton ID="RBInaccurate" runat="server" GroupName="rb" ValidationGroup="editlisting" />
     </td>
     <td>Report as inaccurate </td>
     </tr>
        <tr>
     <td height="30" style="padding-left:5px;">
       <asp:RadioButton ID="RBEditbusins" runat="server" GroupName="rb" ValidationGroup="editlisting"/>
     </td>
     <td>Edit this Business </td>
     </tr>
        <tr>
     <td height="30" style="padding-left:5px;">
       <asp:RadioButton ID="RBLocatemap" runat="server" GroupName="rb" ValidationGroup="editlisting" />
     </td>
     <td>Locate this Business on map </td>
     </tr>
        <tr>
     <td height="30" style="padding-left:5px;">
       <asp:RadioButton ID="RBBusiShutdown" runat="server" GroupName="rb" ValidationGroup="editlisting" />
     </td>
     <td>Report that Business has shutdown</td>
     </tr>
    </table>
    </td>
   
  </tr>
  <tr>
   <td height="41" align="right" colspan="2">
   <asp:ImageButton ID="ImgEditlisting" runat="server" AlternateText="imgEListing" 
             ImageUrl="images/panel/dialog_buttan.png" ValidationGroup="editlisting" 
            onclick="ImgEditlisting_Click" Width="98" Height="35"/>
  </td>
    <td>&nbsp;</td>
  </tr>
</table>
</div>
 </asp:Panel>
              
 <asp:Panel ID="Pnlusertype" runat="server" Width="350px" BorderColor="Gray">
  <div class="dilogbox">
<table width="100%" border="0">
  <tr>
    <td width="60%" class="sub_menu">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label ID="Label12" runat="server" Text="Edit Listing" CssClass="sub_menu"></asp:Label></td>
    <td width="37%" height="38" align="right">
        <asp:ImageButton ID="btncan" runat="server" ImageUrl="images/panel/cencel.png" Width="21" Height="22" />
    </td>
    <td width="3%">&nbsp;</td>
  </tr>
    <tr>
    <td height="176" colspan="3" valign="top">
    <table width="100%" border="0">
     <tr><td class="side_menu" style="padding-left:5px;">
         Select the appropriate option and click submit <br /><br />
         Please select an appropriate option from below to make changes</td></tr>
  <tr><td>
   <table width="100%">
   <tr><td height="30" style="padding-left:5px;">
     <asp:RadioButton ID="RBOwnlisting" runat="server" ValidationGroup="user" GroupName="usertype"/></td>
     <td>I own this listing / I work here. </td></tr>
     <tr><td height="30" style="padding-left:5px;"><asp:RadioButton ID="RBUser" runat="server" GroupName="usertype" ValidationGroup="user"/></td>
     <td>I am a User.</td></tr></table>
  </td></tr>
    </table>
    </td>
   
  </tr>
  <tr>
   <td height="41" align="right" colspan="2">
   <asp:ImageButton ID="Btnusertype" runat="server" AlternateText="btnUType" 
            ImageUrl="images/panel/submit.png" ValidationGroup="user" Width="98" 
           Height="35" onclick="Btnusertype_Click"/>
  </td>
    <td>&nbsp;</td>
  </tr>
</table>
</div>
 </asp:Panel>

       <cc1:ModalPopupExtender ID="ModalPopupExtender3" runat="server" TargetControlID="btnclose1" PopupControlID="pnlConfirm"
          BackgroundCssClass="modalBackground" DropShadow="false" CancelControlID="btncanc">
        </cc1:ModalPopupExtender>
         <cc1:ModalPopupExtender ID="ModalPopupExtender2" runat="server" TargetControlID="btndummy" PopupControlID="Pnlusertype"
          BackgroundCssClass="modalBackground" DropShadow="false" CancelControlID="btncan">
        </cc1:ModalPopupExtender>
        <input id="btndummy" runat="server" type="button" style="display: none;" />
        <cc1:ModalPopupExtender ID="ModalPopupExtender1" runat="server" TargetControlID="RBInaccurate" PopupControlID="pnlincorrect"
          BackgroundCssClass="modalBackground" DropShadow="false" CancelControlID="btncancel">
        </cc1:ModalPopupExtender>
    <asp:Panel ID="pnlincorrect" runat="server" BorderColor="Gray">
    <div class="dilogbox">
<table width="100%" border="0">
  <tr>
    <td width="60%" class="sub_menu"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="lblreport" runat="server" Text="Report Incorrect ?" CssClass="sub_menu"></asp:Label></td>
    <td width="37%" height="38" align="right">
        <asp:ImageButton ID="btncancel" runat="server" Width="21" Height="22" ImageUrl="images/panel/cencel.png"/>
   </td>
    <td width="3%">&nbsp;</td>
  </tr>
<tr>
    <td height="176" colspan="3">
    <table width="100%" border="0">
     <tr><td class="side_menu" style="padding-left:5px;">  If you find any details incorrect, let us know by 
         entering a comment here.</td></tr>
      <tr><td align="center">
    <asp:TextBox ID="txtrpt" runat="server" TextMode="MultiLine" Rows="5" Columns="30"></asp:TextBox>
            
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
            ControlToValidate="txtrpt" ErrorMessage="Please enter comment" 
            ValidationGroup="incorrect">*</asp:RequiredFieldValidator>
            
    </td></tr>
    <tr><td style="padding-left:5px;">
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" Height="16px" 
            ShowMessageBox="True" ShowSummary="False" ValidationGroup="incorrect" 
            Width="287px" />
        Eg: Invalid phone number </td></tr>
  
    </table>
    </td>
   
  </tr>
  <tr>
   <td height="41" align="right" colspan="2">
   <asp:ImageButton ID="imgsubmit" runat="server" AlternateText="Submit" 
            ImageUrl="images/panel/submit.png" onclick="imgsubmit_Click" 
            ValidationGroup="incorrect" Width="98" Height="35"/>
  </td>
    <td>&nbsp;</td>
  </tr>
</table>
</div>
  </asp:Panel>
  <asp:Panel ID="pnlConfirm" runat="server" Width="350px" BackColor="White">
    <fieldset>
       <table width="100%" border="0">
    <tr>
    <td width="90%">&nbsp;</td>
    <td width="20%" align="right" style="padding-right:3px;">
      <asp:ImageButton ID="btncanc" AlternateText="CancelBtn" runat="server" Width="15" Height="16" ImageUrl="images/panel/cencel.png"/></td>
    </tr>
    <tr>
    <td colspan="2" align="center">
        <asp:Label ID="lblConfirmation" runat="server"></asp:Label>    
    </td>
    </tr>
    <tr><td colspan="2" style="height:4px"></td></tr>
    <tr>
    <td colspan="2" align="right" valign="middle"><asp:Button ID="btnclose1" runat="server" Text="Ok" OnClick="btnclose1_Click" /></td>
    </tr>
    </table>
    </fieldset>
     </asp:Panel>
    
   

         </td></tr>                
       
 </table>

    
 </div>
 <div class="content_innerright">
<div class="contentbox_top">Sponsor Ads</div>
<div class="contentbox_mid">
  <table width="100%" border="0">
    <tr>
      <td width="100%" align="center" valign="top">
      <asp:Image ImageUrl="images/image_gallery.gif" runat="server" AlternateText="Gallery" width="175" height="300" /><br />
      <asp:Image ImageUrl="images/sample.gif" runat="server" AlternateText="SampleImg" width="175" height="300" /><br />
      <asp:Image ImageUrl="images/b.php.jpeg" runat="server" AlternateText="PhoneImg" width="175" height="300" /><br />
     </td>
    </tr>
    <tr>
      <td></td>
    </tr>
   
  </table>
</div>
<div class="contentbox_bottam"></div>
</div>
</div>
<div class="content_midbootam" >
<bcm:Contentmid ID="contentmid" runat="server" />
</div>
<div class="content_bootam_center">
<bcon:Bottomcontent ID="bottomcontent" runat="server" />
</div>

<div class="footer" align="center" style="padding-top:5px; " >
   <aa10:footer1 ID="footer1" runat="server" />
  <aa11:footer2 ID="footer2" runat="server" />
</div>
</div>
 <div class="popup">
        <div class="content1">
        <asp:Button runat="server" CssClass="x" ID="btnjclose1" Text="X"/>
       
        </div>
        </div> 
        <%--<div class="tablediv" style="width:502px; display:none" >
   <table width="500" class="tblstyle">
   <tr>
   <td colspan="3" align="center" class="tbltitle">Please Enter Basic Details</td>
   </tr>
   <tr>
   <td class="tdfont">&emsp;Email</td>
   <td width="10"><b>:</b></td>
   <td align="left"><asp:TextBox ID="txtAUserid1" runat="server" CssClass="tbox" onchange="txtchanged('txtAUserid1')"></asp:TextBox>
   &nbsp;
   <asp:RequiredFieldValidator ID="reqired1" runat="server" ControlToValidate="txtAUserid1" SetFocusOnError="true" ValidationGroup="de1" >*</asp:RequiredFieldValidator>
   </td>
   </tr>
   <tr>
   <td class="tdfont">&emsp;Password</td>
   <td width="10"><b>:</b></td>
   <td align="left"><asp:TextBox ID="txtAPwd1" runat="server" CssClass="tbox"   onchange="txtchanged('txtAPwd1')"></asp:TextBox>
   &nbsp;
   <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtAPwd1" SetFocusOnError="true" ValidationGroup="de1" >*</asp:RequiredFieldValidator>
   </td>
   </tr>
   <tr>
   <td class="tdfont">&emsp;Mobile No</td>
   <td width="10"><b>:</b></td>
   <td align="left"><asp:TextBox ID="txtAMobile1" runat="server" CssClass="tbox"   onchange="txtchanged('txtAMobile1')" MaxLength="10"></asp:TextBox>
   &nbsp;
   <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtAMobile1" SetFocusOnError="true" ValidationGroup="de1" >*</asp:RequiredFieldValidator>
   <asp:RegularExpressionValidator ID="regul1" runat="server" ControlToValidate="txtAPwd1" ValidationGroup="de1" ValidationExpression="\d{10}" ErrorMessage="10 digit number"></asp:RegularExpressionValidator>
   </td>
   </tr>
   <tr style="height:10px;">
   <td colspan="3"></td>  
   </tr>
   <tr>
   <td colspan="3" align="center">
   <asp:Button ID="btnSend" runat="server" Text="Send" CssClass="btnstyle" ValidationGroup="de1" UseSubmitBehavior="false" OnClick="Login_FriendsRatings"/> 
   </td>  
   </tr>
   <tr style="height:10px;">
   <td colspan="3"></td>  
   </tr>
   </table>
  <asp:Label ID="Label1" runat="server" Text="" ForeColor="White"  />          
   </div> --%>
        <div id="popupdiv" title="Login" style="display: none">
            <table  width="500px" class="login"><tr><td align="center">
        
           
     <%-- <h1 style="text-align:center;">Login </h1>--%>
       <h2> Please fill the below credentials </h2>
         <p style="height:35px;padding:15px;"><font style="padding-bottom:5px; ">Email id</font>
         <asp:TextBox ID="txtAUserid1" runat="server" CssClass="input1" ClientIDMode="Static" onchange="txtchanged('txtAUserid1')"></asp:TextBox>
             <asp:RequiredFieldValidator ID="rfvUid1" runat="server" ErrorMessage="Please enter email id" ControlToValidate="txtAUserid1" ValidationGroup="AUDetails1">*</asp:RequiredFieldValidator>
          <asp:RegularExpressionValidator ID="revemailm" runat="server" ErrorMessage="Enter valid email id" ControlToValidate="txtAUserid1" 
           ValidationExpression=".*@.*\..*" ValidationGroup="AUDetails1">*</asp:RegularExpressionValidator>
         </p>
         <p style="height:35px;padding:15px;"><font style="padding-bottom:5px;padding-top:5px;">Password</font>
         <asp:TextBox ID="txtAPwd1" runat="server" CssClass="input1" ClientIDMode="Static" onchange="txtchanged('txtAPwd1')" TextMode="Password" Height="35px" Width="300px" ></asp:TextBox>
               <asp:RequiredFieldValidator ID="rfvPwd1" runat="server" ErrorMessage="Please enter Password" ControlToValidate="txtAPwd1" ValidationGroup="AUDetails1">*</asp:RequiredFieldValidator>
               
         </p>
         <p style="height:35px;padding:15px;"><font style="padding-bottom:5px; padding-top:5px;">Mobile number</font>
         <asp:TextBox ID="txtAMobile1" runat="server" CssClass="input1" ClientIDMode="Static" onchange="txtchanged('txtAMobile1')" onkeypress="return onlyNos(event,this);"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvMobile1" runat="server" ErrorMessage="Please enter Mobile number" ControlToValidate="txtAMobile1" ValidationGroup="AUDetails1">*</asp:RequiredFieldValidator>          
           <asp:RangeValidator ID="rvtxtAMobile1" runat="server" MaximumValue="1" MinimumValue="0" 
                        ErrorMessage="mobile number should start with zero" ControlToValidate="txtAMobile1" 
                        ValidationGroup="AUDetails1">*</asp:RangeValidator>
             <asp:RegularExpressionValidator ID="revtxtAMobile1" runat="server" 
                        ErrorMessage="Please enter mobile number of 11 digits" 
                        ControlToValidate="txtAMobile1" ValidationExpression="^[01]?[- .]?(\([1-9]\d{2}\)|[1-9]\d{2})[- .]?\d{3}[- .]?\d{4}$" 
                        ValidationGroup="AUDetails1">*</asp:RegularExpressionValidator> 
         
         </p>
          <p class="submit" style="height:35px;padding:15px;padding-top:11%;">
         <asp:Button ID="btnLogin1" runat="server" Text="Login" OnClick="Login_FriendsRatings" ValidationGroup="AUDetails1" UseSubmitBehavior="false"  />
         <asp:ValidationSummary ID="ValidationSummary5" runat="server" ValidationGroup="AUDetails1" ShowMessageBox="true" ShowSummary="false" />
            
          <asp:hiddenfield id="hndtxt_email" runat="server" />
            </td></tr>
          </table>
</div>
<div id="popupdiv1" title="Login" style="display: none">
                  <table  width="500px" class="login"><tr><td align="center">
        
           
      
       <h2> Please fill the below credentials </h2>
          <p style="height:35px;padding:15px;"><font style="padding-bottom:5px; ">Email id</font>
         <asp:TextBox ID="txtAUserid2" runat="server" CssClass="input1" ClientIDMode="Static" onchange="txtchanged1('txtAUserid2')"></asp:TextBox>
       
         <asp:RequiredFieldValidator ID="rfvUid2" runat="server" ErrorMessage="Please enter email id" ControlToValidate="txtAUserid2" ValidationGroup="AUDetails2">*</asp:RequiredFieldValidator>
         <asp:RegularExpressionValidator ID="revemail2" runat="server" ErrorMessage="Enter valid email id" ControlToValidate="txtAUserid2" 
           ValidationExpression=".*@.*\..*" ValidationGroup="AUDetails2">*</asp:RegularExpressionValidator>
         </p>
          <p style="height:35px;padding:15px;"><font style="padding-bottom:5px;padding-top:5px;" >Password</font>
         <asp:TextBox ID="txtAPwd2" runat="server" CssClass="input1" ClientIDMode="Static" onchange="txtchanged1('txtAPwd2')" TextMode="Password" Height="35px" Width="300px"></asp:TextBox>
           <asp:RequiredFieldValidator ID="rfvPwd2" runat="server" ErrorMessage="Please enter Password" ControlToValidate="txtAPwd2" ValidationGroup="AUDetails2">*</asp:RequiredFieldValidator>
         </p>
        <p style="height:35px;padding:15px;"><font style="padding-bottom:5px; padding-top:5px;">Mobile number</font>
         <asp:TextBox ID="txtAMobile2" runat="server" CssClass="input1" MaxLength="11" ClientIDMode="Static" onchange="txtchanged1('txtAMobile2')" onkeypress="return onlyNos(event,this);"></asp:TextBox>
               <asp:RequiredFieldValidator ID="rfvMobile2" runat="server" ErrorMessage="Please enter Mobile number" ControlToValidate="txtAMobile2" ValidationGroup="AUDetails2">*</asp:RequiredFieldValidator>          
               <asp:RangeValidator ID="rvtxtAMobile2" runat="server" MaximumValue="1" MinimumValue="0" 
                        ErrorMessage="mobile number should start with zero" ControlToValidate="txtAMobile2" 
                        ValidationGroup="AUDetails2">*</asp:RangeValidator>
             <asp:RegularExpressionValidator ID="revtxtAMobile2" runat="server" 
                        ErrorMessage="Please enter mobile number of 11 digits" 
                        ControlToValidate="txtAMobile2" ValidationExpression="^[01]?[- .]?(\([1-9]\d{2}\)|[1-9]\d{2})[- .]?\d{3}[- .]?\d{4}$" 
                        ValidationGroup="AUDetails2">*</asp:RegularExpressionValidator> 
         </p>
          <p class="submit" style="height:35px;padding:15px;padding-top:11%;">
         <asp:Button ID="btnLogin2" runat="server" Text="Login" OnClick="Login_Upload" ValidationGroup="AUDetails2" UseSubmitBehavior="false"/>
         <asp:ValidationSummary ID="ValidationSummary6" runat="server" ValidationGroup="AUDetails2" ShowMessageBox="true" ShowSummary="false" />           
      
            </td></tr>
          </table>
           <asp:Label ID="Label2" runat="server" Text="" ForeColor="White"  />  
</div>
<div id="popupdiv2" title="Login"  style="display:none;">

<table  width="500px" class="login"><tr><td align="center">                
      
       <h2> Please fill the below credentials </h2>
         <p style="height:35px;padding:15px;"><font style="padding-bottom:5px; ">Email id</font>
         <asp:TextBox ID="txtAUserid" runat="server" CssClass="input1" onchange="txtchanged2('txtAUserid')" ClientIDMode="Static"></asp:TextBox>
           <asp:RequiredFieldValidator ID="rfvUid" runat="server" ErrorMessage="Please enter email id" ControlToValidate="txtAUserid" ValidationGroup="AUDetails">*</asp:RequiredFieldValidator>
           <asp:RegularExpressionValidator ID="revEmail" runat="server" ErrorMessage="Enter valid email id" ControlToValidate="txtAUserid" 
           ValidationExpression=".*@.*\..*" ValidationGroup="AUDetails">*</asp:RegularExpressionValidator>
         </p>
         <p style="height:35px;padding:15px;"><font style="padding-bottom:5px;padding-top:5px;">Password</font>
         <asp:TextBox ID="txtAPwd" runat="server" CssClass="input1" TextMode="Password" Height="35px" Width="300px" onchange="txtchanged2('txtAPwd')" ClientIDMode="Static"></asp:TextBox>
             <asp:RequiredFieldValidator ID="rfvPwd" runat="server" ErrorMessage="Please enter Password" ControlToValidate="txtAPwd" ValidationGroup="AUDetails">*</asp:RequiredFieldValidator>
         </p>
         <p style="height:35px;padding:15px;"><font style="padding-bottom:5px; padding-top:5px;">Mobile number</font>
         <asp:TextBox ID="txtAMobile" runat="server" CssClass="input1" MaxLength="11" onkeypress="return onlyNos(event,this);" onchange="txtchanged2('txtAMobile')" ClientIDMode="Static"></asp:TextBox>
             <asp:RequiredFieldValidator ID="rfvMobile" runat="server" ErrorMessage="Please enter Mobile number" ControlToValidate="txtAMobile" ValidationGroup="AUDetails">*</asp:RequiredFieldValidator>          
             <asp:RangeValidator ID="rvmymobile" runat="server" MaximumValue="1" MinimumValue="0" 
                        ErrorMessage="mobile number should start with zero" ControlToValidate="txtAMobile" 
                        ValidationGroup="AUDetails">*</asp:RangeValidator>
             <asp:RegularExpressionValidator ID="revmymobile" runat="server" 
                        ErrorMessage="Please enter mobile number of 11 digits" 
                        ControlToValidate="txtAMobile" ValidationExpression="^[01]?[- .]?(\([1-9]\d{2}\)|[1-9]\d{2})[- .]?\d{3}[- .]?\d{4}$" 
                        ValidationGroup="AUDetails">*</asp:RegularExpressionValidator> 
         </p>
         <p class="submit" style="height:35px;padding:15px;padding-top:11%;">
         <asp:Button ID="btnMyratings" runat="server" Text="Login" OnClick="btnMyratings_Click" ValidationGroup="AUDetails" UseSubmitBehavior="false" Visible="true" />
         <asp:ValidationSummary ID="ValidationSummary4" runat="server" ValidationGroup="AUDetails" ShowMessageBox="true" ShowSummary="false" />
           </td></tr>     
         </table>
          <asp:Label ID="Label4" runat="server" Text="" ForeColor="White"  />  
        
</div>

        
</form>
<%--<script type="text/javascript">
<!--
swfobject.registerObject("FlashID");
//-->
</script>--%>

<%--<script type="text/javascript"
        src="http://code.jquery.com/jquery-latest.js">
    </script>
 
    <script type="text/javascript">
        $(document).ready(function () {
            $('#btnMyratings').click(function () {
                location.reload();
            });
        });     
    </script>--%>
<style type="text/css" >
   .watermark { color: #999; }
</style>
<script type="text/javascript">


//    $(document).ready(function () {

//       // var watermark = 'Enter fields';

////        //init, set watermark text and class
////        $('#txtAUserid,#txtAPwd,#txtAMobile').val(watermark).addClass('watermark');

////        //if blur and no value inside, set watermark text and class again.
////        $('#txtAUserid,#txtAPwd,#txtAMobile').blur(function () {
////            if ($(this).val().length == 0) {
////                $(this).val(watermark).addClass('watermark');
////            }
////        });

////        //if focus and text is watermrk, set it to empty and remove the watermark class
////        $('#txtAUserid,#txtAPwd,#txtAMobile').focus(function () {
////            if ($(this).val() == watermark) {
////                $(this).val('').removeClass('watermark');
////            }
//        //        });
//        bindtext('Enter email address', '#txtAUserid2');
//        bindtext('Enter password', '#txtAPwd2');
//        bindtext('Enter mobile number', '#txtAMobile2');
//        bindtext('Enter email address', '#txtAUserid1');
//        bindtext('Enter password', '#txtAPwd1');
//        bindtext('Enter mobile number', '#txtAMobile1');
//        bindtext('Enter email address', '#txtAUserid');
//        bindtext('Enter password', '#txtAPwd');
//        bindtext('Enter mobile number', '#txtAMobile');

//    });
//    function bindtext(water, id) {
//        //init, set watermark text and class
//        $(id).val(water).addClass('watermark');

//        //if blur and no value inside, set watermark text and class again.
//        $(id).blur(function () {
//            if ($(this).val().length == 0) {
//                $(this).val(water).addClass('watermark');
//            }
//        });

//        //if focus and text is watermrk, set it to empty and remove the watermark class
//        $(id).focus(function () {
//            if ($(this).val() == water) {
//                $(this).val('').removeClass('watermark');
//            }
//        });
//    }
    //
     </script> 


 

 
</body>
</html>
