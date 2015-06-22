<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LifeStyle_details.aspx.cs" Inherits="LifeStyle_details" %>

<%@ Register TagPrefix="OAR" TagName="Overalratin" Src="usercontrols/OverallRatings.ascx"%>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%@ Register Src="usercontrols/signin.ascx" TagName="signin" TagPrefix="aa1" %>
<%@ Register Src="usercontrols/Search.ascx" TagName="catag" TagPrefix="aa6" %>
<%@ Register Src="usercontrols/footer1.ascx" TagName="footer1" TagPrefix="aa10" %>
<%@ Register Src="usercontrols/footer2.ascx" TagName="footer2" TagPrefix="aa11" %>
<%@ Register Src="usercontrols/SponsoredLinks.ascx" TagName="Splinks" TagPrefix="aa3" %>
<%@ Register Src="usercontrols/BottomMidContent.ascx" TagName="Contentmid" TagPrefix="bcm" %>
<%@ Register Src="usercontrols/BottomContent.ascx" TagName="Bottomcontent" TagPrefix="bcon" %>
<%@ Register Src="usercontrols/SearchNew.ascx" TagName="SearchNew" TagPrefix="New" %>
<%@ Register Src="usercontrols/small_logo.ascx" TagName="logo" TagPrefix="S_logo" %>
<%@ Register Src="usercontrols/report_left.ascx" TagName="leftreport" TagPrefix="lftrpt" %>
<%@ Register Src="usercontrols/videoctrl.ascx" TagName="video"  TagPrefix="video" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>:: Justcalluz :: Home page</title>
<link href="css/style.css" rel="stylesheet" type="text/css" />
<link href="css/inner_style.css" rel="stylesheet" type="text/css" />
<script src="Scripts/swfobject_modified.js" type="text/javascript"></script>
<script type="text/javascript" src="js/jquery-1.2.6.min.js"></script>
<script type="text/javascript" src="js/jquery.rater.js"></script>
<script type="text/javascript">
$(function() {
$('#testRater');
});
</script>
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
        </style>
     <style type="text/css">
    @import url("http://www.google.com/uds/solutions/mapsearch/gsmapsearch.css");
  </style>
   <style type="text/css">
    @import url("http://www.google.com/uds/css/gsearch.css");
  </style>
  <style type="text/css">
    .gsmsc-mapDiv {
      height : 300px;
    }
 
    .gsmsc-idleMapDiv {
      height : 300px;
    }
 
    #mapsearch {
      width : 550px;
      margin: 10px;
      padding: 4px;
    }
  </style> 
<script type="text/javascript" src="http://maps.googleapis.com/maps/api/js?sensor=false"></script>
<script language="javascript" type="text/javascript">
    var map;
    var geocoder;
    var marker;
    var infowindow = new google.maps.InfoWindow();
    function InitializeMap()
    {
        geocoder = new google.maps.Geocoder();
        var latlng = new google.maps.LatLng(17.363196172398258, 78.50145421875004);
        var myOptions =
        {
            zoom: 13,
            center: latlng,
            mapTypeId: google.maps.MapTypeId.ROADMAP,
            disableDefaultUI: false
        };
        map = new google.maps.Map(document.getElementById("div1"), myOptions);
    }

    function FindLocaiton(lat,lng,addr) 
    {
    
        InitializeMap();
        geocoder = new google.maps.Geocoder();
        var latlng = new google.maps.LatLng(lat,lng);
        map.setCenter(latlng);
        var marker = new google.maps.Marker({
            map: map,
            draggable:true,
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
          
</script>
<script type="text/javascript">
var geocoder = new google.maps.Geocoder();

function geocodePosition(pos) {
  geocoder.geocode({
    latLng: pos
  }, function(responses) {
    if (responses && responses.length > 0) {
      updateMarkerAddress(responses[0].formatted_address);
    } else {
      updateMarkerAddress('Cannot determine address at this location.');
    }
  });
}

function updateMarkerStatus(str) {
  document.getElementById('markerStatus').innerHTML = str;
}

function updateMarkerPosition(latLng)
{
var lats=latLng.lat();
var lngs=latLng.lng();
//document.getElementById('txtlat').value=latLng.lat();
//document.getElementById('txtlong').value=latLng.lng();

  document.getElementById('info').innerHTML = [
  latLng.lat(),
  latLng.lng()
 ].join(', ');
}

function updateMarkerAddress(str) {
  document.getElementById('address').innerHTML = str;
}

function initialize() 
{
  var latLng = new google.maps.LatLng(17.363196172398258, 78.50145421875004);
  var map = new google.maps.Map(document.getElementById('divMap'), {
    zoom: 8,
    center: latLng,
    mapTypeId: google.maps.MapTypeId.ROADMAP
  });
  var marker = new google.maps.Marker({
    position: latLng,
    title: 'Point A',
    map: map,
    draggable: true
  });
  
  // Update current position info.
  updateMarkerPosition(latLng);
  geocodePosition(latLng);
  
  // Add dragging event listeners.
  google.maps.event.addListener(marker, 'dragstart', function() {
    updateMarkerAddress('Dragging...');
  });
  
  google.maps.event.addListener(marker, 'drag', function() {
    updateMarkerStatus('Dragging...');
    updateMarkerPosition(marker.getPosition());
  });
  
  google.maps.event.addListener(marker, 'dragend', function() {
    updateMarkerStatus('Drag ended');
    geocodePosition(marker.getPosition());
    
  });
}

// Onload handler to fire off the app.
google.maps.event.addDomListener(window, 'load', initialize);
</script>

</head>
<body>
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePageMethods="true">
    </asp:ScriptManager>
    <div class="layout">
    <div class="signin">
<aa1:signin ID="aaa" runat="server" />
</div>
<div class="header">
<%--<div class="header_top"></div>--%>
<div class="header_logo"><S_logo:logo ID="logo" runat="server" /></div>
<div class="header_search">
 <New:SearchNew ID="New" runat="server" />
 </div>
 </div>
<div class="category_box">
 <aa6:catag ID="dff" runat="server" />
</div>
<!-- staart the Content-->
<div class="content" style="margin:0; padding:0;">
<!-- start the inner left-->
 <div class="content_innerleft" >
  <lftrpt:leftreport id="rpt" runat="server"/>
 </div>
  <!-- end of the inner left-->
 <div class="content_innermid">
<table width="100%" border="0">
<tr>
    <td height="28" colspan="4" ><hr/> </td>
    </tr>
<tr>
    <td>
    <span class="sub_menu"><%--<asp:LinkButton ID="lnkcnt" runat="server"  Text="Contact" 
            onclick="lnkcnt_Click"></asp:LinkButton>--%>
        <a id="lnkcnt" runat="server" onserverclick="lnkcnt_Click">Contact</a>&nbsp; </span>
        | &nbsp;<span class="sub_menu">&nbsp;<%--<asp:LinkButton ID="lnkphoto" 
            runat="server" Text="Photo" OnClick="lnkphoto_Click"></asp:LinkButton>--%>
             <a id="lnkphoto" runat="server" onserverclick="lnkphoto_Click">Photo</a></span><span class="side_menu">
        &nbsp;</span>
        |&nbsp;<span class="sub_menu">&nbsp;
       <%-- <asp:LinkButton ID="lnkBtnMoreInfo" runat="server" Text="More Info" OnClick="lnkBtnMoreInfo_Click"></asp:LinkButton>--%>
        <a id="lnkBtnMoreInfo" runat="server" onserverclick="lnkBtnMoreInfo_Click">More Info</a>
       </span><span class="side_menu">
        &nbsp;</span>&nbsp; &nbsp; |&nbsp;&nbsp;<span class="sub_menu"><%--<asp:LinkButton ID="lnkmap" runat="server" 
            Text="View Map" onclick="lnkmap_Click"></asp:LinkButton>--%>
            <a id="lnkmap" runat="server" onserverclick="lnkmap_Click">View Map</a></span>&nbsp; &nbsp; |&nbsp;&nbsp;<span class="sub_menu"><asp:LinkButton ID="lnkown" runat="server" Text="Own Your Listing?"></asp:LinkButton></span>
     </td>
  </tr>
  <tr>
    <td height="28" colspan="4" ><hr/> </td>
    </tr>
 <tr>
 <td>
 <asp:Label ID="lblerror" runat="server"></asp:Label>
 <%--<asp:Panel ID="pnlupload1" runat="server">
 <fieldset>
  <asp:DataList ID="dluploadphoto" runat="server" RepeatColumns="2" DataKeyField="PhotoName">
 <ItemTemplate>
 <asp:Image ID="imgphoto" runat="server" ImageUrl='<%# Eval("PhotoName", "~/Photos\\{0}") %>' Width="250px" Height="300px" />
 </ItemTemplate>
 </asp:DataList>
 <asp:Label ID="nophoto1" runat="server" Text="Sorry ! photos are not yet uploaded by you "></asp:Label>
 <asp:LinkButton ID="lnkuploadphoto" runat="server" Text="Upload Photos" ForeColor="#003366"></asp:LinkButton>
 </fieldset>
 </asp:Panel>--%>
 <%--<div id="test2-content">
	<div class="accordion_child" style="line-height:1.5;height:250px">
	 <div style="text-align:center">--%>
       <%--OnClick="imgShowImage_Click"--%>
       <asp:Panel ID="pnlupload" runat="server">
       <fieldset>
       
            <asp:ImageButton ID="imgShowImage" runat="server"  
                Height="220"
                Style="border: 1px solid black;width:420px"
                AlternateText="SlideShowImages"/>
           
            <asp:Label runat="Server" ID="imageLabel1" CssClass="sub_menu"/><br /><br />
            <asp:Button runat="Server" ID="prevButton" Text="Prev" Font-Size="Small"/>
            <asp:Button runat="Server" ID="playButton" Text="Play" Font-Size="Small" />
            <asp:Button runat="Server" ID="nextButton" Text="Next" Font-Size="Small" />
           <%--<asp:LinkButton ID="lnkuploadphoto" runat="server" Text="Upload Photo"></asp:LinkButton>--%>
           <a id="lnkuploadphoto" runat="server">Upload Photo</a>
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
     <%--<cc1:ModalPopupExtender ID="popphoto" runat="server" TargetControlID="lnkphoto" PopupControlID="pnlupload"></cc1:ModalPopupExtender> --%>
     </fieldset>
       </asp:Panel>
     <%--</div>
	 
    </div>
  </div>--%>
<asp:DataList ID="dlData" runat="server" Width="100%" 
             onitemdatabound="dlData_ItemDataBound">
 <HeaderTemplate></HeaderTemplate>
 <ItemTemplate>
 <table border="0" width="100%"><tr>
 <td class="select_menu" style="padding-left:3px;">
 <a href="Default.aspx" style="text-decoration:none">Home</a> &gt; <%#DataBinder.Eval(Container.DataItem, "company_name")%>
 
</td>
  </tr>
  <tr>
    <td style="background:url(images/event_send1.png) no-repeat" height="39" valign="center">
    <table width="100%" border="0">
  <tr>
    <td width="9%">&nbsp;</td>
    <td width="40%" class="bottam"><strong class="side_menu">
        <%#DataBinder.Eval(Container.DataItem, "company_name")%>
        </strong></td>
    <td width="16%" class="mid_menu"><asp:Label ID="lblratingh" runat="server" Font-Bold="true"></asp:Label> 
        Rating(s)</td>
     <td width="3%"><img alt="rateImage" src="images/rate those.png" width="20" height="20" /></td>
      <td width="11%" class="mid_menu"><asp:HyperLink ID="lnkBtnRatethis" runat="server" NavigateUrl='<%# string.Format("PostReviewCat.aspx?DataId=" + Eval("id").ToString() + "&mod=LifeStyle")%>'>Rate 
          This</asp:HyperLink></td>
      <td width="3%" align="center"><img alt="EditIcon" src="images/edit-icon.png" width="20" height="20" /></td>
      <td width="18%" class="mid_menu"><%--<asp:LinkButton ID="lnkedit" 
                  runat="server" Text="Edit Listing" onclick="lnkedit_Click"></asp:LinkButton>--%>
                  <a id="lnkedit" runat="server" onserverclick="lnkedit_Click">Edit Listing</a></td>
    
  </tr>
</table>
</td>
  </tr>
 
  
 
  <tr>
    <td ><table width="100%" border="0">
  <tr>
    <td id="tdlogo" runat="server" width="30%" rowspan="6" valign="top" style="padding-top:3px;" ><asp:Image  ID="imglogo"  runat="server"  ImageUrl='<%# Eval("ImageName", "../Logos\\{0}") %>'  Width="198"  Height="120"/></td>
    <td width="3%"><img alt="nameIcon" src="images/name.png" width="20" height="20" /></td>
    <td width="67%" colspan="5" height="21"><%#DataBinder.Eval(Container.DataItem, "contact_person")%>
    
                                                     </td>
  </tr>
  <tr>
    <td><img alt="ContactIcon" src="images/contact1.png" width="20" height="20"/></td>
    <td class="side_menu" height="20"> <%#DataBinder.Eval(Container.DataItem, "landphno")%>|<%#DataBinder.Eval(Container.DataItem, "mob")%></td>
  </tr>
  <tr>
    <td><img alt="messangerIcon" src="images/messanger.png" width="20" height="20" /></td>
    <td height="20" class="side_menu">Send Enquiry by Email</td>
  </tr>
   <tr>
    <td><img alt="computerIcon" src="images/computer.png" width="20" height="20" /></td>
    <td height="20" class="side_menu"><%#DataBinder.Eval(Container.DataItem, "emailid")%></td>
  </tr>
  <tr>
    <td><img alt="EmailIcon" src="images/email.png" width="20" height="20" /></td>
    <td height="30" class="side_menu">  <%#DataBinder.Eval(Container.DataItem, "Website")%></td>
  </tr>
  <tr>
    <td><img alt="homeafdIcon" src="images/homeafd.png" width="20" height="20" /></td>
    <td class="mid1_menu"><%#DataBinder.Eval(Container.DataItem, "address")%></td>
  </tr>
 
</table>
</td>
  </tr>
  <tr>
     <td>&nbsp;</td>
  </tr>
  <tr>
    <td  height="30" style="background:url(images/rating.png) no-repeat"><table width="100%" border="0">
     
  <tr>
    <td width="82%" class="mid_menu" style="padding-left:8px;"><a href="#" class="side_menu">
        All Ratings (28)</a>&nbsp;&nbsp;|&nbsp;&nbsp;<span class="side_menu"><a href="#">Friends Ratings</a>&nbsp;</span>&nbsp;|&nbsp;&nbsp;<a href="#" class="side_menu">My 
        Ratings </a></td>
    <%--<td width="4%"><img alt="ratingImage" src="images/rating.1.png" width="24" height="24" /></td>
    <td width="14%" class="side_menu"><asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl='<%# string.Format("PostReviewCat.aspx?DataId=" + Eval("id").ToString())%>'>Rate 
        This</asp:LinkButton></td>--%>
  </tr>
</table>
</td></tr>

 </table>
 </ItemTemplate>
 </asp:DataList>
 </td>
 </tr>
 <tr><td>
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
 <tr><td>
 <asp:Panel ID="pnluploadlogo" runat="server">
 <fieldset>
 <table>
 <tr><td>
 <asp:FileUpload ID="uploadLogo" runat="server" />
 </td>
 </tr>
 <tr><td></td></tr>
 <tr><td></td></tr>
 <tr><td align="center"><asp:ImageButton AlternateText="Upload-Logobutton" ID="btnuploadlogo" 
         runat="server" ImageUrl="../images/Upload-Logo.png" 
         onclick="btnuploadlogo_Click" /></td></tr>
 </table>
 </fieldset>
 </asp:Panel>
 </td></tr>
 <tr><td>
 <asp:Panel ID="pnluploadvideo" runat="server">
 <fieldset>
 <table>
 <tr><td>
 <asp:FileUpload ID="uploadVideos" runat="server" />
 </td></tr>
 <tr><td></td></tr>
 <tr><td></td></tr>
 <tr><td align="center"><asp:ImageButton ID="btnvideo" runat="server"  AlternateText="Upload-Videobutton"
         ImageUrl="../images/Upload-Video.png" onclick="btnvideo_Click" /></td></tr>
 </table>
 </fieldset>
 </asp:Panel>
 </td></tr>
  <tr><td>
      &nbsp;</td></tr>
 <tr><td>
  <table>
       <tr>
       <td></td>
       <td></td>
       <td></td>
       <td></td>
       <td></td>
       <td>
       <asp:Panel ID="pnlown" runat="server">
       <fieldset style="width: 344px">
       <table style="line-height:50px;">
       <tr align="center"><td>
       <asp:ImageButton ID="imglogo" runat="server" ImageUrl="../images/icons/logo.png" 
               onclick="imglogo_Click" AlternateText="btnLogoIcon" /><br />
           Upload Logo
       </td>
       <td></td>
       <td></td>
       <td></td>
       <td></td>
       <td></td>
       <td></td>
       <td></td>
       <td></td>
       <td></td>
       <td>
       <asp:ImageButton ID="imgownphoto" runat="server" AlternateText="btnPictures-icon" 
               ImageUrl="../images/icons/Pictures-icon (1).png" onclick="imgownphoto_Click"/><br />
           Upload Photo
       </td>
       <td></td>
       <td></td>
       <td></td>
       <td></td>
       <td></td>
       <td></td>
       <td></td>
       <td></td>
       <td></td>
       <td>
       <asp:ImageButton ID="uploadvideo" runat="server" AlternateText="btnvideoIcon" 
               ImageUrl="../images/icons/video.png" onclick="uploadvideo_Click" /><br />
           Upload video
       </td>
       <td></td>
       <td></td>
       <td></td>
       <td></td>
       
       
       </tr>
       </table>
        
       </fieldset>
       </asp:Panel>
       </td>
       </tr>
       </table> 
 </td></tr>
 <tr><td>
  <table>
        <tr>
        <td colspan="2" align="center">
        <asp:Panel ID="pnluploadphoto" runat="server">
        <fieldset>
        <table>
        <tr><td>Upload Photo</td></tr>
        <tr><td></td></tr>
        <tr>
        <td align="center">
            <asp:FileUpload ID="photoupload" runat="server" />
        </td>
        </tr>
        <tr><td></td></tr>
        <tr align="center">
         <td><asp:ImageButton ID="imgphoto" runat="server" 
                ImageUrl="../images/Upload-Photos.png" onclick="imgphoto_Click" AlternateText="btnUpload-Photos" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:ImageButton ID="imgcancel" runat="server" 
                 ImageUrl="../images/cancel-button.png" onclick="imgcancel_Click" AlternateText="btnCancel" /></td>
        </tr>
        <tr><td></td></tr>
        <tr><td></td></tr>
        </table>
        </fieldset>
        </asp:Panel>
        </td>
        </tr>
        </table>
        
 </td></tr>
 
 <tr>
 <td>
 
 <table border="0" width="100%" id="MorInfo" runat="server" visible="false"> 
  <tr><td colspan="3"><span style="font-weight:bold; font-size:small; font-family:Arial">
      Hours Of Operation :</span>
  </td>  
  
  </tr>
  <tr>
  <td style="width:60px" align="right"><span style="font-size:small; font-family:Arial">Monday</span></td>
  <td style="width:10px" align="center"><strong>&nbsp;:&nbsp;</strong></td>
  <td style="width:150px">          
      <asp:Label ID="lblMonday" runat="server" ></asp:Label>
  </td>
  </tr>
   <tr>
  <td align="right">
  <span style="font-size:small; font-family:Arial">Tuesday</span>
  </td>  
  <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
  <td>
      <asp:Label ID="lblTuesday" runat="server"></asp:Label></td>
  </tr>
   <tr>
  <td align="right">
  <span style="font-size:small; font-family:Arial">Wednesday</span>
  </td>  
  <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
  <td>
      <asp:Label ID="lblWednesday" runat="server"></asp:Label></td>
  </tr>
   <tr>
  <td align="right">
  <span style="font-size:small; font-family:Arial">Thursday</span>
  </td>  
  <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
  <td>
      <asp:Label ID="lblThursday" runat="server"></asp:Label></td>
  </tr>
   <tr>
  <td align="right">
  <span style="font-size:small; font-family:Arial">Friday</span>
  </td>  
  <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
  <td>
      <asp:Label ID="lblFriday" runat="server"></asp:Label></td>
  </tr>
   <tr>
  <td align="right">
  <span style="font-size:small; font-family:Arial">Saturday</span>
  </td>  
  <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
  <td>
      <asp:Label ID="lblSaturday" runat="server"></asp:Label></td>
  </tr>
   <tr>
  <td align="right">
  <span style="font-size:small; font-family:Arial">Sunday</span>
  </td>  
  <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
  <td>
      <asp:Label ID="lblSunday" runat="server"></asp:Label></td>
  </tr>   
  <tr>
     <td>&nbsp;</td>
  </tr>
   <tr>
  <td>
  <span style="font-size:small; font-family:Arial">Mode of payment</span>
  </td>  
  <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
  <td style="width:300px">
      <asp:Label ID="lblpayment" runat="server"></asp:Label></td>
  </tr> 

 </table>
 </td></tr>
 <tr>
 <td><table width="100%" border="0">
   <tr id="trAllRatingHeading" runat="server">
        <td align="center">        
        <table id="testRater" class="stat">
        <tr><td class="side_menu">
        <label for="rating">Overall Ratings (<asp:Label ID="lblrating" runat="server" Text="Label"></asp:Label>
            )</label> &nbsp;&nbsp;&nbsp;&nbsp;       
        <span class="ui-rater">
        <span class="ui-rater-starsOff" style="width:90px;"><span class="ui-rater-starsOn" runat="server" id="testSpan"></span></span>
        <span class="ui-rater-rating" id="avgrating" runat="server"></span>&nbsp;<span class="ui-rater-rateCount" id="userscount" runat="server"></span>
        </span>
        </td></tr>
        </table></td>
        </tr>
 <%-- <tr>
    <td class="sub_menu">Overall Ratings
      <img src="images/rating-4.8.gif" width="60" height="11" /></td>
    <td class="sub_menu">Ratings Over Time<img src="images/rating-4.8.gif" width="60" height="11" /></td>
  </tr>--%>
  <tr>
    <td align="center" width="48%" style="padding-top:10px;" valign="top">
      <OAR:Overalratin ID="overallrating" UserWidth="200" runat="server" />
     </td>
    
  </tr>
</table>
</td>
  </tr>
 <tr><td align="center">
     <asp:ImageButton ID="imgbtnSendMAIL" runat="server" 
         ImageUrl="images/send-_button.png"/>
          &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="friend" runat="server" Text="Share with your friend" Font-Size="12px" BackColor="White" Font-Underline="true" 
           ForeColor="#003366" Font-Bold="true" Font-Names="Arial" BorderStyle="None" />
         <%--<a id="friend" runat="server" style="font-size:12px; color:#003366; font-family:Arial;">Share with your friend</a>--%>
    </td></tr>
 </table>
 
<table width="100%" border="0"><tr>
    <td> 
    
     <asp:DataList ID="dlReview" runat="server" Width="100%" OnItemDataBound="dlReview_ItemDataBound">
             <ItemTemplate>
             <table width="100%" border="0">
  <tr>
    <td width="12%" rowspan="4" style="padding-bottom:20px;" ><asp:Image AlternateText="userimage" ID="imgReviewer" runat="server" ImageUrl='<%# Eval("ImageName", "../Review_Images\\{0}") %>' Width="64" Height="64"/></td>
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
            <asp:Button ID="cmdPrev" runat="server" Text=" << " OnClick="cmdPrev_Click"></asp:Button>
              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="cmdNext" runat="server" Text=" >> " OnClick="cmdNext_Click"></asp:Button>                              
          </td>
        </tr> 
        <tr><td></td></tr>
<tr>
    <td align="right">
        <asp:Label ID="lblCurrentPage" runat="server"></asp:Label>
    </td>
</tr>
</table>
<table ><tr><td>&nbsp;
 <asp:Panel ID="Pnllogin" runat="server" Width="300px" Height="241px">
        <%--<fieldset style="width: 300px">--%>
            <asp:Panel ID="Panel4" runat="server">
            </asp:Panel>
           <table style="background-color:#999999" width="300px"><tr><td align="center" style="line-height:40px;">
            <asp:Login ID="Login1" runat="server" BackColor="Silver" BorderColor="DeepSkyBlue" 
                   ForeColor="Black" UserNameLabelText="UserId :" DisplayRememberMe="false" 
                   InstructionText="Please fill the below credentials" 
                   onauthenticate="Login1_Authenticate"  BorderWidth="1px">
                <LayoutTemplate>
                    <table border="0" cellpadding="1" cellspacing="0" 
                        style="border-collapse:collapse;">
                        <tr>
                            <td>
                                <table border="0" cellpadding="0">
                                    <tr>
                                        <td align="center" colspan="2">
                                            Log In</td>
                                    </tr>
                                    <tr>
                                        <td align="center" colspan="2">
                                            Please fill the below credentials</td>
                                    </tr>
                                    <tr>
                                        <td align="right">
                                            <asp:Label ID="UserNameLabel" runat="server" AssociatedControlID="UserName">UserId 
                                            :</asp:Label>
                                        </td>
                                        <td>
                                            <asp:TextBox ID="UserName" runat="server"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" 
                                                ControlToValidate="UserName" ErrorMessage="User Name is required." 
                                                ToolTip="User Name is required." ValidationGroup="Login1">*</asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="right">
                                            <asp:Label ID="PasswordLabel" runat="server" AssociatedControlID="Password">Password:</asp:Label>
                                            
                                        </td>
                                        <td>
                                            <asp:TextBox ID="Password" runat="server" TextMode="Password"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" 
                                                ControlToValidate="Password" ErrorMessage="Password is required." 
                                                ToolTip="Password is required." ValidationGroup="Login1">*</asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="center" colspan="2" style="color:Red;">
                                            <asp:Literal ID="FailureText" runat="server" EnableViewState="False"></asp:Literal>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:Button ID="LoginButton" runat="server" CommandName="Login" Text="Log In to upload photo" 
                                                ValidationGroup="Login1" OnClick="LoginButton_Click" />
                                        </td>
                                        <td><asp:Button ID="btnown" runat="server" ValidationGroup="Login1" CommandName="Login" Text="Log In if u own this listing?"
                                         OnClick="btnown_Click" />
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                    </table>
                </LayoutTemplate>
            </asp:Login>
            </td></tr>
            <tr><td align="center"><asp:Button ID="lnkclose" runat="server" Text="CLOSE" ForeColor="White" Font-Bold="true" BorderStyle="None" BackColor="#999999" /></td></tr>
            </table>
            
          
        <%--</fieldset>--%></asp:Panel>
   
   <cc1:ModalPopupExtender ID="ModalPopupExtender" runat="server"  
        TargetControlID="lnkuploadphoto" PopupControlID="Pnllogin" BackgroundCssClass="modalBackground" 
          OkControlID="lnkclose"
        DropShadow="false" PopupDragHandleControlID="panel4" ></cc1:ModalPopupExtender>
       <cc1:ModalPopupExtender ID="ModalPopupExtender1" runat="server"  
        TargetControlID="lnkown" PopupControlID="Pnllogin" BackgroundCssClass="modalBackground" 
          OkControlID="lnkclose"
        DropShadow="false" PopupDragHandleControlID="panel4" ></cc1:ModalPopupExtender>
        </td></tr></table>
<table>
        <tr><td>
<asp:Panel ID="mailpanel" runat="server" Width="350px">
<div class="dilogbox">
  <table width="350px">
    <tr>
      <td colspan="2" align="center" valign="top" 
        style="font-family:Arial; font-size:large; color:#003366; padding-top:5px;">Get Information by sms/email
        &nbsp;&nbsp;&nbsp;&nbsp;
      <asp:ImageButton ID="cancelbtn" AlternateText="CancelButton" ImageUrl="images/panel/cencel.png" width="21" height="22" runat="server"/></td>
   </tr>
   <tr><td>&nbsp;</td></tr>
   <tr>
   <td height="170" colspan="2">
    <table align="center" width="400px" style="height: 144px;">
     <tr style="margin-left:5px">
       <td align="right">
       <span class="star">*</span>
        <asp:Label ID="Label1" runat="server" Text="Name" Font-Bold="false" ForeColor="Black" ></asp:Label>
        </td>
        <td align="center"><strong>&nbsp;:&nbsp;</strong></td>
       <td>
        <asp:TextBox ID="txtname" runat="server" ValidationGroup="modal" Width="160px" Height="25px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvtxtname" runat="server" 
            ControlToValidate="txtname" ErrorMessage="Enter Name" 
            ValidationGroup="sendmail">*</asp:RequiredFieldValidator>
     </td>
     </tr>
     <tr style="margin-left:5px">
        <td align="right">
        <span class="star">*</span>
            <asp:Label ID="Label9" runat="server" Text="Mobile_No" ForeColor="Black" Font-Bold="false" ></asp:Label>
        </td>
        <td><strong>&nbsp;:&nbsp;</strong></td>
        <td>
            <asp:TextBox ID="txtmob" runat="server" ValidationGroup="sendmail" Width="160px" Height="25px" MaxLength="11"></asp:TextBox>
         <asp:RegularExpressionValidator ID="revtxtmob" runat="server" 
            ControlToValidate="txtmob" ErrorMessage="Only numbers are allowed for mobile" 
            ValidationExpression="\d{11}" ValidationGroup="sendmail">*</asp:RegularExpressionValidator>
         <asp:RequiredFieldValidator ID="rfvtxtmob" runat="server" 
            ErrorMessage="Please enter contact number" ControlToValidate="txtmob"  
            ValidationGroup="sendmail">*</asp:RequiredFieldValidator>
        <asp:RangeValidator ID="rgvtxtmob" runat="server" 
            ErrorMessage=" Mobile Number must start with 0" ControlToValidate="txtmob"  
            MaximumValue="1" MinimumValue="0" 
            ValidationGroup="sendmail">*</asp:RangeValidator>
        </td>
      </tr>
      <tr style="margin-left:5px">
        <td align="right">
        <span class="star">*</span>
            <asp:Label ID="Label7" runat="server" Text="Email_Id" ForeColor="Black" Font-Bold="false" ></asp:Label>
        </td>
        <td><strong>&nbsp;:&nbsp;</strong></td>
        <td>
            <asp:TextBox ID="txtSEmail" runat="server" ValidationGroup="modal" Width="160px" Height="25px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvtxtSEmail" runat="server" ControlToValidate="txtSEmail" 
            ErrorMessage="please enter Email id"  ValidationGroup="sendmail">*</asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="revtxtSEmail" runat="server" 
            ErrorMessage="Incorrect Format of email address" 
            ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
            ValidationGroup="sendmail" ControlToValidate="txtSEmail" >*</asp:RegularExpressionValidator>
             <asp:ValidationSummary ID="ValidationSummary2" runat="server" 
              ValidationGroup="sendmail" ShowMessageBox="True" ShowSummary="False" />
        </td>
     </tr>
    </table>
    </td>
    </tr>
  <tr>
  <td width="241" height="37">&nbsp;</td>
  <td width="163" valign="top">
  <asp:ImageButton ID="imggo1" OnClick="imggo1_Click" AlternateText="Gobutton" ImageUrl="images/panel/dialog_buttan.png" width="98" height="35" runat="server" ValidationGroup="sendmail"/>
  </td>
</tr>
    </table>
</div>
</asp:Panel>  
        <cc1:ModalPopupExtender ID="mdlmail" PopupControlID="mailpanel" runat="server" 
        TargetControlID="imgbtnSendMAIL" BackgroundCssClass="modalBackground"
         DropShadow="false" PopupDragHandleControlID="pnl" OkControlID="cancelbtn">
         </cc1:ModalPopupExtender>
         </td></tr>
        </table>      
<table><tr><td>
<asp:Panel ID="friendpanel" runat="server" Width="350px">
<div class="dilogbox">
<table width="350px">
<tr>
<td colspan="2" align="center" valign="top" 
        
        style="font-family:Arial; font-size:large; color:#003366; padding-top:5px;">
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Share with your friend &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:ImageButton ID="btncancel" AlternateText="Cancelbutton" ImageUrl="images/panel/cencel.png" width="21" height="22" runat="server"/></td>
</tr>
<tr>
  <td height="170" colspan="2">
     <table  width="370px" style="height: 184px;">
      <tr>
        <td colspan="3" style="padding-left:5px;">
         <asp:Label ID="Label3" runat="server" Text="Tell your friend about this site ." ForeColor="#003366" ></asp:Label></td>
      </tr>
      <tr>
        <td align="right"><span class="star">*</span><asp:Label ID="Label2" runat="server" Text="Your Name" ForeColor="Black" Font-Bold="false" ></asp:Label></td>
        <td><strong>&nbsp;:&nbsp;</strong></td>
        <td>
         <asp:TextBox ID="txtname1" runat="server" validationgroup="modal" Width="160px" Height="25px"></asp:TextBox>
          <asp:RequiredFieldValidator ID="rfvtxtname1" runat="server" 
                ErrorMessage="please enter your name" ControlToValidate="txtname1"  validationgroup="share">*</asp:RequiredFieldValidator></td>
      </tr>
      <tr>
        <td align="right"><span class="star">*</span><asp:Label ID="Label5" runat="server" Text="Your's Friend Name" ForeColor="Black" Font-Bold="false" ></asp:Label></td>
        <td><strong>&nbsp;:&nbsp;</strong></td>
        <td>
        <asp:TextBox ID="txtfname" runat="server" validationgroup="modal" Width="160px" Height="25px"></asp:TextBox>
          <asp:RequiredFieldValidator ID="rfvtxtfname" runat="server" 
               ErrorMessage="please enter your friend's name" ControlToValidate="txtfname"  
                    validationgroup="share">*</asp:RequiredFieldValidator></td>
      </tr>
       <tr>
        <td align="right"><span class="star">*</span><asp:Label ID="Label8" runat="server" Text="Your Friend's Mobile_No" ForeColor="Black" Font-Bold="false" ></asp:Label>
        </td>
        <td><strong>&nbsp;:&nbsp;</strong></td>
        <td>
        <asp:TextBox ID="txtmob1" runat="server" validationgroup="modal" Width="160px" Height="25px" MaxLength="11"></asp:TextBox>
          <asp:RegularExpressionValidator ID="revtxtmob1" runat="server" 
         ControlToValidate="txtmob1" ErrorMessage="Only numbers are allowed for mobile" 
          ValidationExpression="\d{11}" validationgroup="share">*</asp:RegularExpressionValidator>
          <asp:RequiredFieldValidator ID="rfvtxtmob1" runat="server" 
             ErrorMessage="Please enter contact number" ControlToValidate="txtmob1"  
                    validationgroup="share">*</asp:RequiredFieldValidator>
          <asp:RangeValidator ID="rgvtxtmob1" runat="server" 
              ErrorMessage=" Mobile Number must start with 0" ControlToValidate="txtmob1"  
                    MaximumValue="1" MinimumValue="0" 
               validationgroup="share">*</asp:RangeValidator>
       </td>
      </tr>
      <tr>
        <td align="right"><span class="star">*</span><asp:Label ID="Label4" runat="server" Text="Your Friend's Email_Id" ForeColor="Black" Font-Bold="false" ></asp:Label>
         <%--<asp:Label ID="Label6" runat="server"></asp:Label>--%>
        </td>
        <td><strong>&nbsp;:&nbsp;</strong></td>
        <td>
        <asp:TextBox ID="txtFEmail" runat="server" validationgroup="modal" Width="160px" Height="25px"></asp:TextBox>
          <asp:RequiredFieldValidator ID="rfvtxtFEmail" runat="server" ControlToValidate="txtFEmail" 
           ErrorMessage="please enter Email id"  validationgroup="share">*</asp:RequiredFieldValidator>
          <asp:RegularExpressionValidator ID="revtxtFEmail" runat="server" 
           ErrorMessage="Incorrect Format of email address" 
           ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
           validationgroup="share" ControlToValidate="txtFEmail" >*</asp:RegularExpressionValidator>
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
                validationgroup="share" ShowMessageBox="True" ShowSummary="False" />
         </td>
        </tr>
     </table>
 </td>
</tr>
<tr>
  <td width="240" height="37">&nbsp;</td>
  <td width="130" valign="middle" style="padding:5px 5px 5px 5px;">
  <asp:ImageButton ID="imggo" OnClick="imggo_Click" AlternateText="Gobutton" ImageUrl="images/panel/dialog_buttan.png" width="98" height="35" runat="server" ValidationGroup="share"/>
  </td>
</tr>
</table>
</div>
</asp:Panel>
<cc1:ModalPopupExtender ID="mdlshare" runat="server" PopupControlID="friendpanel" TargetControlID="friend"
          BackgroundCssClass="modalBackground" DropShadow="false" PopupDragHandleControlID="panel2" OkControlID="btncancel"></cc1:ModalPopupExtender>
 </td></tr></table>
         
</div>
 <div class="content_innerright" align="center">
<table>
<tr>
<td>
<video:Video ID="runvideo" runat="server" />
</td>
</tr>
</table>
<div class="contentbox_top">Sponsor Ads</div>
<div class="contentbox_mid">
  <table width="100%" border="0">
    <tr>
      <td width="100%" valign="top">
       <img src="images/citi-bank.png" width="175" height="600" /><br />
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
<div class="content_bootam" align="center">

</div>
<div class="footer" align="center" style="padding-top:5px; " >
   <aa10:footer1 ID="footer1" runat="server" />
  <aa11:footer2 ID="footer2" runat="server" />
</div>
</div>
</form>
<script type="text/javascript">
//<!--
//swfobject.registerObject("FlashID");
//-->
</script>
</body>
</html>