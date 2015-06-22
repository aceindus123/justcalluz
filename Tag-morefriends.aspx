<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Tag-morefriends.aspx.cs" Inherits="Tag_morefriends" %>
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
     function movetoNext(current, nextFieldID) {

         if (current.value.length >= current.maxLength) {

             document.getElementById(nextFieldID).focus();

         }

     }
     </script>
    <style type="text/css">
        .modalBackground {
            background-color: Gray;
            filter: alpha(opacity=60);
            opacity: 0.6;
        }
        .table_bg
        {
            position: fixed; 
		height: 100%;
		width: 100%;
		background: rgba(0,0,0,.8);
		z-index: 100;
		/*display: none; opacity:0.9px;*/
		top: 0;
		left: 0; 

        }
        .table_class{ width:84%; background:#eef6ff; 
font: 12px/20px Verdana, Geneva, sans-serif;
color:#333;
/*padding:0px 0px 10px 20px;*/ margin:0px 0px 0px 10px;
border:#CCC solid 1px;

position: absolute;
		z-index: 101;
		padding: 8px 40px 44px;
		-moz-border-radius: 5px;
		-webkit-border-radius: 5px;
		border-radius: 5px;
		-moz-box-shadow: 0 0 10px rgba(0,0,0,.4);
		-webkit-box-shadow: 0 0 10px rgba(0,0,0,.4);
		-box-shadow: 0 0 10px rgba(0,0,0,.4);
}
        .symbol
        {
            cursor:pointer;
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
  <%--  <tr>
       <td height="30"><strong><a href="Default.aspx">Home</a></strong> &gt; Register</td>
    </tr>--%>
    <tr> 
       <td colspan="2" >
             	<div class="tagged_left">
    		 <span style="padding-top:15px;"><img src="images/tag_frilogo.png" width="58px" height="30px" align="left"  alt="tagfriend"/></span>
		<span style="padding-right: 79%; float: right;padding-top:8px;"><asp:HyperLink id="A2" NavigateUrl="<%$RouteUrl:RouteName=HomeRoute %>" runat="server"><font>Home</font></asp:HyperLink>&nbsp;>>Tag-your-friends&nbsp;</span>
    </div>
       </td>
    </tr>
    <tr>
      <td align="left" style="width:60%;">
      <div class="left_box">
  
  <!--       tagged_left -->  
    <div class="rounded_box">
<h1 style="padding-left:8px; color:Black; font-weight:normal; font-size:14px; padding-top:10px;"> <b>Hi <asp:Label ID="lbluname" runat="server"></asp:Label></b> , Many of your Friends are users of JustCalluz. </h1>
    <ul style="padding-left:20px;">
    <li> Tag More Friends by entering their mobile number. </li>
    <li style="padding-bottom:10px;"> Tag only genuine friends. </li>
    </ul>
       
      <table style="padding:0px 0px 0px 20px;width:65%;">
   <tr id="trtxtbox1" runat="server">
   <td align="center" style="padding-bottom:5%;">1</td>
   <td style="height:30px;width:37%" align="center" > <p>
      <asp:TextBox ID="txtmbl1" runat="server" MaxLength="11" onkeypress="return isNumberKey(event)" onkeyup="movetoNext(this, 'txtmbl1')"
           class="searchtag1" style="height:20px;" ontextchanged="txtmbl1_TextChanged"  AutoPostBack="true"></asp:TextBox> </p>
             <asp:RegularExpressionValidator ID="revtxtmbl1" runat="server" 
            ControlToValidate="txtmbl1" ErrorMessage="Only numbers are allowed for mobile" 
            ValidationExpression="\d{11}" ValidationGroup="tag">*</asp:RegularExpressionValidator>
         <asp:RangeValidator ID="rvtxtmbl1" runat="server" 
            ErrorMessage=" Mobile Number must start with 0" ControlToValidate="txtmbl1"  
            MaximumValue="1" MinimumValue="0" 
            ValidationGroup="tag">*</asp:RangeValidator>
           </td>
           <td align="left" style="width:343px;padding-left:17%;padding-bottom:5%;"><asp:Label ID="lblmessage" runat="server" Visible="false" ></asp:Label></td>
   </tr>
    <tr id="trlblbox1" runat="server" visible="false">
   <td align="center" style="padding-bottom:5%;"></td>
   <td style="height:30px;width:37%" align="left" colspan="3"> <p>
        <asp:Image ID="imgReviewer" runat="server" ImageUrl="~/images/he.gif" Width="32" Height="32"/>
         <span style="padding-bottom:5%;text-align:center;" class="select_menu"><asp:Label ID="lblname1" runat="server" Text='<%#Eval("name") %>'></asp:Label></span> 
     </p></td>
   </tr>
   
   <tr id="trtxtbox2" runat="server">
   <td align="center" style="padding-bottom:5%;"> 2</td>
   <td style="height:30px;width:37%" align="center"><p> <asp:TextBox ID="txtmbl2" runat="server" MaxLength="11" onkeypress="return isNumberKey(event)" onkeyup="movetoNext(this, 'txtmbl2')"
           class="searchtag1" style="height:20px;" ontextchanged="txtmbl2_TextChanged" AutoPostBack="true"></asp:TextBox> </p>
            <asp:RegularExpressionValidator ID="revtxtmbl2" runat="server" 
            ControlToValidate="txtmbl2" ErrorMessage="Only numbers are allowed for mobile" 
            ValidationExpression="\d{11}" ValidationGroup="tag">*</asp:RegularExpressionValidator>
            <asp:RangeValidator ID="rvtxtmbl2" runat="server" 
            ErrorMessage="Mobile Number must start with 0" ControlToValidate="txtmbl2"  
            MaximumValue="1" MinimumValue="0" 
            ValidationGroup="tag">*</asp:RangeValidator>
           </td>
            <td align="left" style="width:343px;padding-left:17%;padding-bottom:5%;"><asp:Label ID="lblmessage1" runat="server" Visible="false"></asp:Label></td>
   </tr>
    <tr id="trlblbox2" runat="server" visible="false">
   <td align="center" style="padding-bottom:5%;"></td>
   <td style="height:30px;width:37%" align="left" colspan="3"> <p>
        <asp:Image ID="Image1" runat="server" ImageUrl="~/images/he.gif" Width="32" Height="32"/>
         <span class="select_menu" height="20" ><asp:Label ID="lblname2" runat="server" Text='<%#Eval("name") %>'></asp:Label></span> 
     </p></td>
   </tr>
   
    <tr id="trtxtbox3" runat="server">
   <td align="center" style="padding-bottom:5%;"> 3</td>
   <td style="height:30px;width:37%" align="center"><p> <asp:TextBox ID="txtmbl3" runat="server" MaxLength="11" onkeypress="return isNumberKey(event)" onkeyup="movetoNext(this, 'txtmbl3')"
           class="searchtag1" style="height:20px;" ontextchanged="txtmbl3_TextChanged" AutoPostBack="true"></asp:TextBox></p>
              <asp:RegularExpressionValidator ID="revtxtmbl3" runat="server" 
            ControlToValidate="txtmbl3" ErrorMessage="Only numbers are allowed for mobile" 
            ValidationExpression="\d{11}" ValidationGroup="tag">*</asp:RegularExpressionValidator>
         <asp:RangeValidator ID="rvtxtmbl3" runat="server" 
            ErrorMessage=" Mobile Number must start with 0" ControlToValidate="txtmbl3"  
            MaximumValue="1" MinimumValue="0" 
            ValidationGroup="tag">*</asp:RangeValidator>
           </td>
             <td align="left" style="width:343px;padding-left:17%;padding-bottom:5%;"><asp:Label ID="lblmessage2" runat="server" Visible="false"></asp:Label></td>
   </tr>
    <tr id="trlblbox3" runat="server" visible="false">
   <td align="center" style="padding-bottom:5%;"></td>
   <td style="height:30px;width:37%" align="left" colspan="3"> <p>
        <asp:Image ID="Image2" runat="server" ImageUrl="~/images/he.gif" Width="32" Height="32"/>
         <span style="padding-bottom:5%;text-align:center;" class="select_menu"><asp:Label ID="lblname3" runat="server" Text='<%#Eval("name") %>'></asp:Label></span> 
     </p></td>
   </tr>
   
   
    <tr id="trtxtbox4" runat="server">
   <td align="center" style="padding-bottom:5%;">4</td>
   <td style="height:30px;width:37%" align="center"><p> 
 <%--  <asp:UpdatePanel ID="UpdatePanel1" runat="server"  style="width:86%; padding-left:12%;">
 <ContentTemplate >--%>
   <asp:TextBox ID="txtmbl4" runat="server" MaxLength="11" onkeypress="return isNumberKey(event)" onkeyup="movetoNext(this, 'txtmbl4')"
           class="searchtag1" style="height:20px;" ontextchanged="txtmbl4_TextChanged" AutoPostBack="true"></asp:TextBox>
 <%--  </ContentTemplate>
  </asp:UpdatePanel>  --%>      
   </p>
              <asp:RegularExpressionValidator ID="revtxtmbl4" runat="server" 
            ControlToValidate="txtmbl4" ErrorMessage="Only numbers are allowed for mobile" 
            ValidationExpression="\d{11}" ValidationGroup="tag">*</asp:RegularExpressionValidator>
         <asp:RangeValidator ID="rvtxtmbl4" runat="server" 
            ErrorMessage=" Mobile Number must start with 0" ControlToValidate="txtmbl4"  
            MaximumValue="1" MinimumValue="0" 
            ValidationGroup="tag">*</asp:RangeValidator>
           </td>
             <td align="left" style="width:343px;padding-left:17%;padding-bottom:5%;"><asp:Label ID="lblmessage3" runat="server" Visible="false"></asp:Label></td>
   </tr>
    <tr id="trlblbox4" runat="server" visible="false">
   <td align="center" style="padding-bottom:5%;"></td>
   <td style="height:30px;width:37%" align="left" colspan="3"> <p>
        <asp:Image ID="Image3" runat="server" ImageUrl="~/images/he.gif" Width="32" Height="32"/>
         <span style="padding-bottom:5%;text-align:center;" class="select_menu"><asp:Label ID="lblname4" runat="server" Text='<%#Eval("name") %>'></asp:Label></span> 
     </p></td>
   </tr>
   
    <tr id="trtxtbox5" runat="server">
   <td align="center" style="padding-bottom:5%;">5</td>
   <td style="height:30px;width:37%" align="center"><p>
  <%-- <asp:UpdatePanel ID="UpdatePanel2" runat="server"  style="width:86%; padding-left:12%;">
 <ContentTemplate >--%>
     <asp:TextBox ID="txtmbl5" runat="server" MaxLength="11" onkeypress="return isNumberKey(event)" 
           class="searchtag1" style="height:20px;" ontextchanged="txtmbl5_TextChanged" ></asp:TextBox>
<%-- </ContentTemplate>
 </asp:UpdatePanel>--%>
  </p>
              <asp:RegularExpressionValidator ID="revtxtmbl5" runat="server" 
            ControlToValidate="txtmbl5" ErrorMessage="Only numbers are allowed for mobile" 
            ValidationExpression="\d{11}" ValidationGroup="tag">*</asp:RegularExpressionValidator>
         <asp:RangeValidator ID="rvtxtmbl5" runat="server" 
            ErrorMessage=" Mobile Number must start with 0" ControlToValidate="txtmbl5"  
            MaximumValue="1" MinimumValue="0" 
            ValidationGroup="tag">*</asp:RangeValidator>
           </td>
             <td align="left" style="width:343px;padding-left:17%;padding-bottom:5%;"><asp:Label ID="lblmessage4" runat="server" Visible="false"></asp:Label></td>
   </tr>
    <tr id="trlblbox5" runat="server" visible="false">
   <td align="center" style="padding-bottom:5%;"></td>
   <td style="height:30px;width:37%" align="left" colspan="3"> <p>
        <asp:Image ID="Image4" runat="server" ImageUrl="~/images/he.gif" Width="32" Height="32"/>
         <span style="padding-bottom:5%;text-align:center;" class="select_menu"><asp:Label ID="lblname5" runat="server" Text='<%#Eval("name") %>'></asp:Label></span> 
     </p></td>
   </tr>
   
      <tr>
   <td></td>
   <td style="height:30px;"><p><asp:Button ID="btnFinish" runat="server" Text="Finish" Width="80px"
           style="margin-left:10px;"  class="inputtag" onclick="btnFinish_Click" ValidationGroup="tag"/></p>
           <asp:ValidationSummary ID="ValidationSummary" runat="server" ShowMessageBox="true" ShowSummary="false" ValidationGroup="tag" />
           </td>
   </tr>
   
   </table>
   
   <p> To know more about benifits of tagging your Friend,  
	<a href="#"  data-reveal-id="myModal">Click Here
	</a>
</p>




<p style="padding-bottom:10px;"> Did not find your friend,     
        	<%--<a href="#" data-reveal-id="myModal2">--%>
			<asp:LinkButton ID="lnkclickhereforInvitation" runat="server" OnClick="lnkclickhereforInvitation_Click">Click Here</asp:LinkButton> 
		<%--</a>--%>
</p>


	<div id="myModal" class="reveal-modal">
			<h1> <b> Benefits of Tagging </b> </h1>
            <ul>
            <li> Sign up and tag your friends to know about their reviews and ratings for Movies, Events, Restaurants, Pubs etc</li>
            <li> JustCalluz has over 44 million plus ratings and reviews.</li>
		    <li> Tag your Friend allows easy access to your friends' reviews assisting you in making an informed choice</li>
            <li> Tagged friends will be informed via email, with a link to tag you back</li>
            </ul>
            
            <img src="images/popup_img.png" width="527" height="367" >
			<a class="close-reveal-modal">&#215;</a>
		</div>
      
        <asp:Panel id="myModal2" CssClass="table_class"  runat="server" Width="550px" Height="450px">
           <div align="right"><b style="text-align:right;">
               <asp:Button ID="btnclose" runat="server" Text="X" Width="30px" Height="30px" ForeColor="Red" CssClass="symbol"
                   BackColor="#eef6ff" BorderStyle="None" Font-Size="14px" OnClick="btnclose_Click" /> </b> </div>
			<h1 style="padding-top:20px;"> <b style="text-align:left;">   Tag Your Friends </b></h1>
            
            <p style="text-align:justify;padding-bottom:10px;">
            Want to invite your Friend to http://www.justcalluz.com/home? It is easy! Just enter the requested details below, click the "Send invitation" button and your friend shall receive your invitation. On acceptance, you can know the ratings & reviews of restaurants, theatres, pubs or any establishments that your tagged friends have given
            </p>
			<%--<a class="close-reveal-modal">&#215;</a>--%>
            
      <%--<form id="contact_form"  method="POST" onsubmit="return validateForm();" enctype="multipart/form-data">--%>
            <table class="table_class">
            <tr>
            <td> Your Name <sub> * </sub></td>
            <td> Your Login <sub> * </sub></td>
            </tr>
            <tr>
            <td><asp:TextBox ID="txtmyname" runat="server" class="searchtag" style="height:20px;" ></asp:TextBox>
    <%--<span id="name_validation" class="error"></span>--%> </td>
              <td>  <asp:TextBox ID="txtmymobile" runat="server" class="searchtag" style="height:20px;"></asp:TextBox>
   <%-- <span id="login_validation" class="error"></span> --%></td>
            <td></td>
           </tr>
            
             <tr>
            <td> Friend's Name <sub> * </sub> </td>
            <td> Friend's Email<sub> * </sub></td>
            </tr>
           <tr>
            <td style="height:30px;"> 
                <asp:TextBox ID="txtfriendname" runat="server" class="searchtag" style="height:20px;" ></asp:TextBox>
                <%-- <span id="friendname_validation" class="error"></span>--%> </td>
              <td style="height:30px;"> 
                  <asp:TextBox ID="txtfriendmail" runat="server"  class="searchtag" style="height:20px;"></asp:TextBox>
                   <asp:RegularExpressionValidator ID="revtxtfriendmail" runat="server" 
                        ErrorMessage="Please Enter valid email address" ControlToValidate="txtfriendmail" 
                        SetFocusOnError="True" 
                        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
                        Font-Bold="True" ValidationGroup="Invitation">*</asp:RegularExpressionValidator>  
 <%--   <span id="friendmail_validation" class="error"></span>--%></td>
            <td style="height:30px;"></td>
           </tr>
            
               <tr>
            <td style="height:30px;"> 
                <asp:TextBox ID="txtfriendname1" runat="server" class="searchtag" style="height:20px;"></asp:TextBox>

            </td>
              <td style="height:30px;">
                  <asp:TextBox ID="txtfriendmail1" runat="server" class="searchtag" style="height:20px;" ></asp:TextBox> 
                    <asp:RegularExpressionValidator ID="revtxtfriendmail1" runat="server" 
                        ErrorMessage="Please Enter valid email address" ControlToValidate="txtfriendmail1" 
                        SetFocusOnError="True" 
                        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
                        Font-Bold="True" ValidationGroup="Invitation">*</asp:RegularExpressionValidator>  
              </td>
            <td style="height:30px;"></td>
           </tr>
           
              <tr>
            <td style="height:30px;"> 
                <asp:TextBox ID="txtfriendname2" runat="server" class="searchtag" style="height:20px;"></asp:TextBox>

            </td>
              <td style="height:30px;"> 
                  <asp:TextBox ID="txtfriendmail2" runat="server" class="searchtag" style="height:20px;" /> 
                    <asp:RegularExpressionValidator ID="revtxtfriendmail2" runat="server" 
                        ErrorMessage="Please Enter valid email address" ControlToValidate="txtfriendmail2" 
                        SetFocusOnError="True" 
                        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
                        Font-Bold="True" ValidationGroup="Invitation">*</asp:RegularExpressionValidator>  
              </td>
            <td style="height:30px;"></td>
           </tr>
           
              <tr>
            <td style="height:30px;">
                <asp:TextBox ID="txtfriendname3" runat="server" class="searchtag" style="height:20px;"></asp:TextBox>

            </td>
              <td style="height:30px;"> 
                  <asp:TextBox ID="txtfriendmail3" runat="server" class="searchtag" style="height:20px;" />
                   <asp:RegularExpressionValidator ID="revtxtfriendmail3" runat="server" 
                        ErrorMessage="Please Enter valid email address" ControlToValidate="txtfriendmail3" 
                        SetFocusOnError="True" 
                        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
                        Font-Bold="True" ValidationGroup="Invitation">*</asp:RegularExpressionValidator>  
              </td>
            <td style="height:30px;"></td>
           </tr>
            
		<tr>
        <td style="height:30px;padding-left:36%;padding-top:20px;" align="center">  
         <asp:Button ID="btnsendinvitation" runat="server" Text="Send Invitation" OnClick="btnsendinvitation_Click" ValidationGroup="Invitation" style="background:#53b1e5; color:#FFF;
         height:20px; width:108px; border:none; cursor:pointer;" class="inputtag" />
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" ShowMessageBox="true" ShowSummary="false"  ValidationGroup="Invitation"/>
        </td>
        </tr>
 
           </table>
            <%--</form>--%>
		</asp:Panel>

         <cc3:ModalPopupExtender ID="MPEDisplayInvitation" runat="server" TargetControlID="lnkclickhereforInvitation" PopupControlID="myModal2" BackgroundCssClass="modalBackground"></cc3:ModalPopupExtender> 
      
      </div>
      
      <!--        rounded_box  -->    

  </div>
     </td>
      <td align="right" style="width:40%;">
         <%--<div class="right_box"></div>--%>
  <!--  right_box end  -->  



   <div class="tagged_right"> <img src="images/top.png" width="223" height="27" align="middle"/>   
   <table width="100%">  
    <tr>
    <td align="left" style="width:100%;">
     <asp:DataList ID="dlFriendReview" runat="server" Width="100%" 
            onitemdatabound="dlFriendReview_ItemDataBound" DataKeyField="id">
       <ItemTemplate>
        <table width="100%" border="0">
          <tr>
            <td width="18%"  style="padding-left:3%;padding-top:3px;" ><asp:Image ID="imgReviewer" runat="server" ImageUrl="~/images/he.gif" Width="32" Height="32"/></td>
            <td width="82%" class="select_menu" height="30" style="padding-left:3%;"> 
                 <asp:LinkButton ID="lblname" runat="server" Text='<%#Eval("name") %>' CommandArgument='<%#Eval("id") %>' Font-Underline="false" OnCommand="FriendsRatings"></asp:LinkButton><br />
            (<asp:LinkButton ID="lblRating" runat="server" Text='<%#Eval("count") %>' CommandArgument='<%#Eval("id") %>' OnCommand="FriendsRatings" Font-Underline="false"></asp:LinkButton>)
            
            </td>
   
          </tr>
      </table>
    </ItemTemplate>
   </asp:DataList>
  <%-- <td> <img src="images/fri_icon.png" width="50" height="49" align="left" style="margin-top:10px;" /></td>
   <td> <a href="#" class="names"> Ravi Sirigiri </a> </td>
   </tr>
   
   <tr>
   <td> <img src="images/fri_icon.png" width="50" height="49" align="left" style="margin-top:10px;" /></td>
   <td> <a href="#" class="names"> Vasanthkumar Chilukuri</a> </td>
   </tr>
   
    <tr>
   <td> <img src="images/fri_icon.png" width="50" height="49" align="left" style="margin-top:10px;" /></td>
   <td> <a href="#" class="names"> Ravi Sirigiri </a> </td>--%>
  </td></tr>
   </table>
   
    <%-- <a href="#" class="names">--%> 
       <b> <asp:LinkButton ID="lnkShowallfrnds" runat="server" CssClass="names" OnClick="lnkShowallfrnds_Click">Show All Friends</asp:LinkButton> </b> <%--</a> --%>

   
   </div>

     </td>
    </tr>
   <%--<tr>    
      <td style="width:100%;">

         <asp:Panel ID="pnlRatings" runat="server">
             <asp:DataList ID="dlratings" runat="server">
               <ItemTemplate>
                   <div class="left_box">
   	                    <div class="tagged_left">
                        <table>
                         <tr>                        
                        <td align="left" style="width:5%;">
		                    <img src="images/tag_frilogo.png"  height="30" align="left" vspace="3" hspace="3" /></td>
                        <td align="left" >
                        <asp:HyperLink id="HyperLink1" NavigateUrl="<%$RouteUrl:RouteName=HomeRoute %>" runat="server"><font style="padding-left:5px;">Home</font></asp:HyperLink>
                            &nbsp; &gt;&gt;&nbsp; <asp:Label ID="lblTagFriend" runat="server" Text="Tag Your Friends"></asp:Label></td>
                        </tr>
                     </table>
        
         </div>
<!----------------  tagged_left --------------> 
                        <div class="color_box">

<span style="width:55px; height:110px; float:left;"> 
<img src="images/fri_icon.png" width="46" height="46" align="left"  vspace="10" hspace="5"/>
</span>


<span style="width:630px;  float:left;"> 

<div style="border-bottom:1px solid #dfdfdf; clear:both; padding-top:10px; margin-left:10px;">
<span class="click3" style="padding-left:10px;"> <a href="#">  ashoka </a>
</span>
<span style="font:12px/18px Verdana, Geneva, sans-serif; color:#666;"> rated 5th Sep, 2014 </span>
</div>

<p> 
<span class="click3"> <a href="#"> <b style="float:left;"> Edvice Educational 
    Services Llp, Hyderabad&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  </b>  
&nbsp;&nbsp;&nbsp;                  <img src="images/star.jpg" width="99" height="23" align="left" />
<br/>
CBSE Schools | West Marredpally, Hyderabad  </a><br/>
</span>
Very Good.</p>

</div>

<!--color_box end -->
                   </div>
               
               </ItemTemplate>
             
             </asp:DataList>
         
         </asp:Panel>
    
    </td>
    
    </tr>--%>
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
<aa10:footer1 ID="tevfd" runat="server" />
<aa11:footer2 ID="eqwr" runat="server" />
</div>
</div>


    </form>
    <script type="text/javascript">
        function validateForm() {
            var valid = 1;
            var login = document.getElementById('login');
            var login_validation = document.getElementById("login_validation");
            var name = document.getElementById('name');
            var name_validation = document.getElementById("name_validation");
            var friendname = document.getElementById('friendname');
            var friendname_validation = document.getElementById("friendname_validation");
            var friendmail = document.getElementById('friendmail');
            var friendmail_validation = document.getElementById("friendmail_validation");
            var message_validation = document.getElementById("message_validation");
            var filter = /^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+$/;

            if (name.value === "") {
                valid = 0;
                name_validation.innerHTML = "Field Required";
                name_validation.style.display = "block";
                name_validation.parentNode.style.backgroundColor = "#";
            } else {
                name_validation.style.display = "none";
                name_validation.parentNode.style.backgroundColor = "transparent";
            }
            if (login.value === "") {
                valid = 0;
                login_validation.innerHTML = "Field Required";
                login_validation.style.display = "block";
                login_validation.parentNode.style.backgroundColor = "#";
            } else {
                login_validation.style.display = "none";
                login_validation.parentNode.style.backgroundColor = "transparent";
            }
            if (friendname.value === "") {
                valid = 0;
                friendname_validation.innerHTML = "Field Required";
                friendname_validation.style.display = "block";
                friendname_validation.parentNode.style.backgroundColor = "#";
            } else {
                friendname_validation.style.display = "none";
                friendname_validation.parentNode.style.backgroundColor = "transparent";
            }
            if (friendmail.value === "") {
                valid = 0;
                friendmail_validation.innerHTML = "Field Required";
                friendmail_validation.style.display = "block";
                friendmail_validation.parentNode.style.backgroundColor = "#";
            } else {
                friendmail_validation.style.display = "none";
                friendmail_validation.parentNode.style.backgroundColor = "transparent";
            }


            if (!valid)
                return false;
        }
</script>
</body>
</html>