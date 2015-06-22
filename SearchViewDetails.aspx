<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SearchViewDetails.aspx.cs" Inherits="SearchViewDetails" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="AjaxToolkit" %>
<%@ Register Src="usercontrols/signin.ascx" TagName="signin" TagPrefix="aa1" %>
<%@ Register Src="usercontrols/topimage.ascx" TagName="topimage" TagPrefix="aa2" %>
<%@ Register Src="usercontrols/Search.ascx" TagName="catageories" TagPrefix="aa6" %>
<%@ Register Src="usercontrols/discountleft.ascx" TagName="discountleft" TagPrefix="discleft1" %>
<%@ Register Src="usercontrols/discountright.ascx" TagName="discountright" TagPrefix="discright3" %>
<%@ Register Src="usercontrols/footer1.ascx" TagName="footer1" TagPrefix="aa10" %>
<%@ Register Src="usercontrols/footer2.ascx" TagName="footer2" TagPrefix="aa11" %>
<%@ Register Src="usercontrols/Search.ascx" TagName="Search" TagPrefix="searchrecords" %>
<%@ Register Src="usercontrols/SponsoredLinks.ascx" TagName="Splinks" TagPrefix="aa3" %>
<%@ Register Src="usercontrols/BottomContent.ascx" TagName="bottomcontent" TagPrefix="aa4" %>
<%@ Register Src="usercontrols/BottomMidContent.ascx" TagName="bottomMidcontent" TagPrefix="aa5" %>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title>Justcalluz - Category Details View Page</title>
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
    <form id="f1" runat="server" >
<asp:ScriptManager ID="ScriptManager1" runat="server" EnablePageMethods="true">
    </asp:ScriptManager>
<!--begin of table-->
<div class="layout">

<div class="signin">
<aa1:signin ID="aaa" runat="server" />
</div>
<div class="logo" align="center">
<aa2:topimage ID="bbb" runat="server" />
</div>
<div class="search" align="center">
    <searchrecords:Search ID="search1" runat="server" />   
</div>
<div class="selection" align="center">
<aa6:catageories ID="fgu" runat="server" />
</div>

<div class="content_inner">

<!-- start the inner left-->
<div class="content_innerleft">
<div class="contenbox">
<div class="contentbox_top">Category List</div>
<div class="contentbox_mid"> 
<table width="100%" border="0">
         <tr>
            <td>
                <asp:DataList ID="DLBindCatData"   RepeatDirection="Vertical" CellPadding="4"  runat="server" 
                        Height="117px" Width="170px"  OnItemCommand="DLBindCatData_ItemCommand" >
                <HeaderTemplate>
                </HeaderTemplate>
                <ItemTemplate>
                    <div>
                    <table border="0">
                        <tr>
                            <td><img src="images/arrow2.jpg" />&nbsp;&nbsp;</td>
                            <td valign="top" class="side_menu">
                               <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%#Eval("category")%>'
                                 Text ='<%# Eval("category") %>' CommandName="select">
                                   
                                </asp:LinkButton>
                            </td>
                        </tr>
                        <tr>
                            <td height="2px"></td>
                        </tr>
                    </table>
                    </div>
               </ItemTemplate>
                </asp:DataList>
          </td>
       </tr>
    </table>
</div>
<div class="contentbox_bottam"></div>
</div>
</div>

<!-- ending the left -->
  <div class="content_innermid">
<div class="contentmid_box">
  <div class="contentmid_boxtop"><a href="Default.aspx" style="text-decoration:none;color:White">Home>></a><asp:Label ID="Label8"
          runat="server" Text="Popular Search Categories"></asp:Label></div>
  <div class="contentmid_boxmid"><table width="100%" border="0">
<tr>
    <td height="30" colspan="2" align="right" class="headings" style="padding-right:5px;">Description for </td>
    <td width="1%"><font color="#000000"><strong>:</strong></font></td>
    <td width="56%"><strong class="side_menu">
        <asp:Label ID="lblCompanyname" runat="server"></asp:Label></strong></td>
  </tr>
  <tr>
    <td colspan="4"><table width="100%" border="0">

<tr><td>
<table width="100%"><tr><td><asp:Label ID="lblerror" runat="server"></asp:Label></td>
<%--<td class="sub_menu" align="right" style="padding-right:20px" ><asp:LinkButton ID="friend" runat="server" Text="Share with your friend" Font-Size="12px"></asp:LinkButton></td>--%>
</tr></table>
    
    <%-- <asp:Panel ID="Panel1" runat="server" BorderWidth="1" BorderColor="Black" style="margin-left: 11px"> --%>
    <div class="job_midle">
    <div class="job_midlemid">
        <table width="500px" border="0">
            <tr id="trCompName" runat="server">
            <td colspan="3">                  
                   <table id="Table1" class="stat" width="100%">
                        <tr class="headings">
                            <td>
                                <asp:Label ID="lblCompName" runat="server" Font-Bold="true" Font-Size="Small" Font-Underline="true"></asp:Label> &nbsp;&nbsp;&nbsp;&nbsp;                                          
                            </td>
                        </tr>
                           <%-- <tr class="side_menu" align="center"><td>
                            <span class="ui-rater">
                            <span class="ui-rater-starsOff" style="width:90px;"><span class="ui-rater-starsOn" runat="server" id="testSpan1"></span></span>
                            <span class="ui-rater-rating" id="Span2" runat="server"></span>&#160;<span class="ui-rater-rateCount" id="Span3" runat="server"></span>
                            </span>
                            <asp:Label ID="lblratingh" runat="server" Font-Bold="true" Font-Size="Smaller"></asp:Label>&nbsp;
                            <asp:Label ID="Label12" runat="server" Text="Rating(s)" Font-Bold="true" Font-Size="Smaller"></asp:Label>
                    </td></tr>--%>
                    </table>         
            </td>
            </tr>        
            <tr id="trComProfile" runat="server" class="side_menu">
            <td style="font-family:font-family:Rockwell Condensed; font-size:12px;" width="40%" align="right">Company Profile</td>
            <td width="15%" align="center">:&nbsp;</td>
            <td width="45%">
             <asp:Label ID="lblCompProfile" runat="server"></asp:Label>        
            </td>
            </tr>
              
            <tr id="trIndustry" runat="server" class="side_menu">
                <td style="font-family:font-family:Rockwell Condensed; font-size:12px" align="right">Industry</td>
                <td align="center">:&nbsp;</td>
                <td>
                     <asp:Label ID="lblInd" runat="server"></asp:Label>                
                </td>
            </tr>
            <tr id="trFunArea" runat="server" class="side_menu">
                <td style="font-family:font-family:Rockwell Condensed; font-size:12px" align="right">Functional Area</td>
                <td align="center">:&nbsp;</td>
                <td>
                     <asp:Label ID="lblFunArea" runat="server"></asp:Label>                
                </td>
            </tr>
            <tr id="trRole" runat="server" class="side_menu">
                <td style="font-family:font-family:Rockwell Condensed; font-size:12px" align="right">Role</td>
                <td align="center">:&nbsp;</td>
                <td>
                     <asp:Label ID="lblRole" runat="server"></asp:Label>                
                </td>
            </tr>
            <tr id="trQual" runat="server" class="side_menu">
                <td style="font-family:font-family:Rockwell Condensed; font-size:12px" align="right">Qualification</td>
                <td align="center">:&nbsp;</td>
                <td>
                     <asp:Label ID="lblQual" runat="server"></asp:Label>                
                </td>
            </tr>
            <tr id="trJobExp" runat="server" class="side_menu">
                <td style="font-family:font-family:Rockwell Condensed; font-size:12px" align="right">Job Experience</td>
                <td align="center">:&nbsp;</td>
                <td>
                     <asp:Label ID="lblExp" runat="server"></asp:Label>                
                </td>
            </tr>
            <tr id="trSal" runat="server" class="side_menu">
                <td style="font-family:font-family:Rockwell Condensed; font-size:12px" align="right">Salary</td>
                <td align="center">:&nbsp;</td>
                <td>
                 <asp:Label ID="lblSal" runat="server"></asp:Label>                 
                </td>
            </tr>
            <tr id="trKeySkills" runat="server" class="side_menu">
                <td style="font-family:font-family:Rockwell Condensed; font-size:12px" align="right">Key Skills</td>
                <td align="center">:&nbsp;</td>
                <td>
                 <asp:Label ID="lblKeyskill" runat="server"></asp:Label>                 
                </td>
            </tr>
            <tr id="trJobDesc" runat="server" class="side_menu">
                <td style="font-family:font-family:Rockwell Condensed; font-size:12px" align="right">Job Description</td>
                <td align="center">:&nbsp;</td>
                <td>
                 <asp:Label ID="lblJobDesc" runat="server"></asp:Label>                 
                </td>
            </tr>      
           <tr id="trEventName" runat="server" class="side_menu">
           <td colspan="3">
            <table id="Table2" class="stat" width="100%">
                        <tr class="headings">
                            <td>
                               <asp:Label ID="lblEventName" runat="server" Font-Bold="true" Font-Size="Small" Font-Underline="true"></asp:Label>         
                            </td>
                        </tr>
                   </table> 
             
            </td>
            </tr> 
            <tr id="trEvePlace" runat="server" class="side_menu"> 
            <td style="font-family:font-family:Rockwell Condensed; font-size:12px;" align="right">Place of the Event</td>
            <td align="center">:&nbsp;</td>
            <td>
             <asp:Label ID="lblEvePlace" runat="server"></asp:Label>        
            </td>
            </tr> 
            <tr id="trEventDesc" runat="server" class="side_menu">
            <td style="font-family:font-family:Rockwell Condensed; font-size:12px" align="right">Event Description</td>
            <td align="center">:</td>
            <td>
             <asp:Label ID="lblEveDesc" runat="server"></asp:Label>        
            </td>
            </tr>   
            <tr id="trEventDate" runat="server" class="side_menu">
            <td style="font-family:font-family:Rockwell Condensed; font-size:12px" align="right">Date of the Event</td>
            <td align="center">:</td>
            <td>
             <asp:Label ID="lblEventDate" runat="server"></asp:Label>        
            </td>
            </tr>
            <tr id="trEveStartDate" runat="server" class="side_menu">
            <td style="font-family:font-family:Rockwell Condensed; font-size:12px" align="right">Start Date of Event</td>
            <td align="center">:</td>
            <td>
             <asp:Label ID="lblEveStartDate" runat="server"></asp:Label>        
            </td>
            </tr>
            <tr id="trEveEndDate" runat="server" class="side_menu">
            <td style="font-family:font-family:Rockwell Condensed; font-size:12px" align="right">End Date of Event</td>
            <td align="center">:</td>
            <td>
             <asp:Label ID="lblEveEndDate" runat="server"></asp:Label>        
            </td>
            </tr>
            <tr id="trEveTime" runat="server" class="side_menu">
            <td style="font-family:font-family:Rockwell Condensed; font-size:12px" align="right">Time of the Event</td>
            <td align="center">:</td>
            <td>
             <asp:Label ID="lblEveTime" runat="server"></asp:Label>        
            </td>
            </tr>  
            <tr id="trDisDesc" runat="server" class="side_menu">
            <td style="font-family:font-family:Rockwell Condensed; font-size:12px" align="right">Discount Description</td>
            <td align="center">:</td>
            <td>
             <asp:Label ID="lblDisDesc" runat="server"></asp:Label>        
            </td>
            </tr>   
            <tr id="trDisDate" runat="server" class="side_menu">
            <td style="font-family:font-family:Rockwell Condensed; font-size:12px" align="right">Date of the Discount</td>
            <td align="center">:</td>
            <td>
             <asp:Label ID="lblDisDate" runat="server"></asp:Label>        
            </td>
            </tr>
            <tr id="trDisStartDate" runat="server" class="side_menu">
            <td style="font-family:font-family:Rockwell Condensed; font-size:12px" align="right">Start Date of Discount</td>
            <td align="center">:</td>
            <td>
             <asp:Label ID="lblDisStartDate" runat="server"></asp:Label>        
            </td>
            </tr>
            <tr id="trDisEndDate" runat="server" class="side_menu">
            <td style="font-family:font-family:Rockwell Condensed; font-size:12px" align="right">End Date of Discount</td>
            <td align="center">:</td>
            <td>
             <asp:Label ID="lblDisEndDate" runat="server"></asp:Label>        
            </td>
            </tr>
            <tr id="trDisTime" runat="server" class="side_menu">
            <td style="font-family:font-family:Rockwell Condensed; font-size:12px" align="right">Time of the Discount</td>
            <td align="center">:</td>
            <td>
             <asp:Label ID="lblDisTime" runat="server"></asp:Label>        
            </td>
            </tr>                                                                              
            <tr id="trContPerson" runat="server" class="side_menu">
         <td style="font-family:font-family:Rockwell Condensed; font-size:12px" align="right">Contact Person </td>
         <td align="center">:</td>
        <td>
            <asp:Label ID="lblContPerson" runat="server"></asp:Label>
        </td>
        </tr> 
            <tr id="trAddress" runat="server" class="side_menu">
            <td style="font-family:font-family:Rockwell Condensed; font-size:12px" align="right">Address</td>
            <td align="center">:</td>
            <td>
                <asp:Label ID="lblAddress" runat="server"></asp:Label>           
            </td>
            </tr>   
            <tr id="trState" runat="server" class="side_menu">
             <td style="font-family:font-family:Rockwell Condensed; font-size:12px" align="right">State</td>
             <td align="center">:</td>
            <td>
             <asp:Label ID="lblState" runat="server"></asp:Label>            
            </td>
            </tr>      
            <tr id="trEmail" runat="server" class="side_menu">
             <td style="font-family:font-family:Rockwell Condensed; font-size:12px" align="right">Email</td>
             <td align="center">:</td>
            <td>
             <asp:Label ID="lblEmail" runat="server"></asp:Label>         
            </td>
            </tr>  
            <tr id="trFax" runat="server" class="side_menu">
             <td style="font-family:font-family:Rockwell Condensed; font-size:12px" align="right">Fax</td>
             <td align="center">:</td>
            <td>
             <asp:Label ID="lblFax" runat="server" Text="Not Mentioned"></asp:Label>         
            </td>
            </tr>         
        </table>
        <table width="380" border="0">
            <tr>
                <td>
                    <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="images/phone2.jpg" />           
                </td>
                <td align="left" class="side_menu">
                    <asp:Label ID="lblLandPhone" runat="server" Text="Not Mentioned"></asp:Label>                   
                </td>
                <td>
                    <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="images/phone.png" />
                </td>
                <td align="left" class="side_menu">
                 <asp:Label ID="lblMob" runat="server" Text="Not Mentioned"></asp:Label>                    
                </td>
                <td width="30"></td>
            </tr>
        </table>            
        <table width="100%">
        <tr id="trSendMail" runat="server">
        <td align="center">
            <asp:ImageButton ID="imgbtnSendMail" runat="server" ImageUrl="images/send-_button.png" />
        </td><%--<td width="30"> 
            <asp:LinkButton ID="lnkBtnViewMap" runat="server"  >View Map</asp:LinkButton></td>--%>
        <td align="center">
        
            <asp:ImageButton ID="imgbtnPostReview" runat="server" 
                ImageUrl="images/postreview.jpg" onclick="imgbtnPostReview_Click"/></td>
        </tr>
        </table>
              
        
      <asp:Panel ID="Panel2" runat="server" Width="100%">
      <table border="0" width="100%">
         <tr>
    <td colspan="3" class="sub_menu"><hr/></td>
        </tr>
         <tr>
    <td colspan="3" class="sub_menu">Reviews:</td>
        </tr>
         <tr>
    <td colspan="3" class="sub_menu"><hr/></td>
         </tr>
         <tr id="trAllRatingHeading" runat="server">
        <td align="center" class="sub_menu" bgcolor="#D9ECFF" height="30">        
        <table id="testRater" class="stat">
        <tr><td>
        <label for="rating">Overall Ratings (<asp:Label ID="lblrating" runat="server" Text="Label"></asp:Label>)</label> &nbsp;&nbsp;&nbsp;&nbsp;       
        <span class="ui-rater">
        <span class="ui-rater-starsOff" style="width:90px;"><span class="ui-rater-starsOn" runat="server" id="testSpan"></span></span>
        <span class="ui-rater-rating" id="avgrating" runat="server"></span>&#160;<span class="ui-rater-rateCount" id="userscount" runat="server"></span>
        </span>
</td></tr>
</table>       </td>
        </tr>
        <tr>
            <td align="center">
            <asp:DataList ID="dlReview" runat="server" Width="100%" OnItemDataBound="dlReview_ItemDataBound">
             <ItemTemplate>
                <table width="100%" border="0" style="background:url(images/job_search6.png) no-repeat" height="183">
                 <tr>
                  <td style="width:20%" align="center">
                      <asp:Image ID="imgReviewer" runat="server" ImageUrl='<%# Eval("ImageName", "~/Review_Images\\{0}") %>' Width="64" Height="64"  />                    
                  </td>
                 
                  <td style="width:80%"> 
                   <table width="100%" style="color:#007ab8">   
                    <tr>
                     <td>
                      <table width="100%" style="border-bottom-style:dotted; border-bottom-width:1px">
                        <tr>
                           <td height="26" align="left" valign="top" colspan="3">
                                                                                                                          
                               <asp:Label ID="lblname" runat="server" Text='<%#Eval("rname") %>'></asp:Label>         
                                 <%--<table id="Table3" class="stat" width="100%" runat="server">                        
                                    <tr><td>
                                    <span class="ui-rater">
                                    <span class="ui-rater-starsOff" style="width:90px;">--%>
                                      <%--<span class="ui-rater-starsOn" runat="server" id="testSpan2">--%>
                                          <asp:Label ID="lblrating" runat="server" ></asp:Label>
                               <asp:Label ID="lblRate" runat="server" Text='<%#Eval("Stars_Rating") %>' Visible="false"></asp:Label>
                                          <%--</span>--%><%--</span>--%>
                                    <%--<span class="ui-rater-rating" id="Span4" runat="server"></span>&#160;<span class="ui-rater-rateCount" id="Span5" runat="server"></span>
                                    </span>                                    
                                </td></tr>
                                </table> --%>
                            </td>
                            
                        </tr>
                        <tr><td><table width="100%">
                        <tr>
                            <td style="width:50%" align="left">
                                
                                    <asp:Label ID="Label4" runat="server" Text='<%#Eval("email") %>'></asp:Label>
                                
                            </td>
                            <td style="width:10%">
                                <asp:Label ID="Label6" runat="server" Text="|"></asp:Label>
                            </td>
                            <td align="center" style="width:40%" >
                                <asp:Label ID="Label2" runat="server" Text='<%#Eval("mob") %>'></asp:Label>
                            </td>
                        </tr>
                        </table></td></tr>
                        </table>
                     </td>
                    </tr>                    
                        <tr>
                       <td height="26" align="left" valign="top" colspan="3">
                    <asp:Label ID="Label7" runat="server" Text='<%#Eval("review") %>'></asp:Label>         
                    </td>
                        
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
            <asp:Button ID="cmdPrev" runat="server" Text=" << " OnClick="cmdPrev_Click"></asp:Button>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="cmdNext" runat="server" Text=" >> " OnClick="cmdNext_Click"></asp:Button>                              
          </td>
        </tr> 
        <tr><td></td></tr>
        <tr>
    <td align="left">
        <asp:Label ID="lblCurrentPage" runat="server"></asp:Label>
    </td>
</tr>
        </table>
      </asp:Panel>
      
      
      <asp:Panel ID="Panel3" runat="server" Width="300px" Height="241px" >
        <fieldset style="width: 300px">
            <asp:Panel ID="Panel4" runat="server">
            </asp:Panel>
            <table align="center" width="300" height="30" style="background:green; border:width 1px color:white; font-size:13px;" >
                <tr style="background-color:Green;">
                    <td style="width:200px" align="left">
                        <asp:Label ID="Label1" runat="server" Text="SMS TO YOUR MOBILE" ForeColor="white"></asp:Label>
                    </td>
                    <td align="right">
                        <asp:Button ID="btnXSendSMS" runat="server" Text="X" ForeColor="white" 
                            BorderStyle="None" BackColor="Green" onclick="btnXSendSMS_Click" />
                      
                    </td>        
                </tr>               
             </table>      
            <table align="center" width="300" style="background:white; height: 184px;" >
                
                <tr align="left" style="margin-left:5px">
                    <td style="width:100px">
                   
                     <asp:Label ID="Label3" runat="server" Text="Name" ForeColor="Black" Font-Bold="false" ></asp:Label>
                     <asp:Label ID="Label9" runat="server" Text="*" ForeColor="Red"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtnameToSend" runat="server" ValidationGroup="modal" Width="140px" ></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvName" runat="server" 
                            ErrorMessage="Please Enter Name" ControlToValidate="txtnameToSend" 
                            ValidationGroup="SendMail">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr align="left" style="margin-left:5px">
                    <td class="style4">
                        <asp:Label ID="Label4" runat="server" Text="Mobile No" ForeColor="Black" Font-Bold="false" ></asp:Label>
                        <asp:Label ID="Label10" runat="server" Text="*" ForeColor="Red"></asp:Label>
                       </td>
                    <td>
                        <asp:TextBox ID="txtmobToSend" runat="server" ValidationGroup="modal" Width="140px" MaxLength="11"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvMob" runat="server" 
                            ControlToValidate="txtmobToSend" ErrorMessage="Please enter Mobile number" 
                            ValidationGroup="SendMail">*</asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="revMob" runat="server" 
                            ControlToValidate="txtmobToSend" ErrorMessage="Please enter 11digits number" 
                            ValidationExpression="\d{11}" ValidationGroup="SendMail">*</asp:RegularExpressionValidator>
                             <asp:RangeValidator ID="rangevalMob" runat="server" 
                            ErrorMessage="The Mobile number should start with zero" MinimumValue="0" ControlToValidate="txtmobToSend" 
                            MaximumValue="1" ValidationGroup="SendMail">*</asp:RangeValidator>
                    </td>
                </tr>
                <tr align="left" style="margin-left:5px">
                    <td class="style4">
                        <asp:Label ID="Label5" runat="server" Text="Email" ForeColor="Black" Font-Bold="false" ></asp:Label>
                        <asp:Label ID="Label11" runat="server" Text="*" ForeColor="Red"></asp:Label>
                       </td>
                    <td>
                        <asp:TextBox ID="txtemailToSend" runat="server" ValidationGroup="modal" Width="140px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvEmail" runat="server" 
                            ControlToValidate="txtemailToSend" ErrorMessage="Please enter email id" 
                            ValidationGroup="SendMail">*</asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                            ControlToValidate="txtemailToSend" 
                            ErrorMessage="Please enter valid email id Eg :XXX@xxx.XX" 
                            ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
                            ValidationGroup="SendMail">*</asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td width="10"></td>
                </tr>
                <tr align="left" style="margin-left:5px">
                    <td align="center" style="padding-left:20px" colspan="2">
                        <asp:Button ID="submitbuttonMail" runat="server" Text="Submit" 
                            ValidationGroup="SendMail" CausesValidation="true" Width="62px" 
                            onclick="submitbuttonMail_Click" />
                    &nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="cancelbutton" runat="server" Text="Cancel" 
                            ValidationGroup="modal" CausesValidation="true"/>
                    </td>
                </tr>
                <tr align="left" style="margin-left:5px">
                    <td class="style4">
                    <asp:HyperLink ID="hyp1" runat="server" Text="Home Page" ForeColor="Blue" Font-Bold="false" 
                    NavigateUrl="~/Default.aspx"></asp:HyperLink>
                    </td>
                </tr>
            </table>
        </fieldset></asp:Panel>
        <%--<asp:Panel ID="friendpanel" runat="server" Width="400px" Height="276px">
      <fieldset style="width:"402px">
          <asp:Panel ID="Panel5" runat="server">
          </asp:Panel>
          <table align="center" width="400" height="30" style="background:#0379BD; border:width 1px color:white; font-size:13px;" >
                <tr style="background-color:#0379BD;">
                    <td style="width:200px" align="left">
                        <asp:Label ID="Label2" runat="server" Text="Share with your friend" ForeColor="white"></asp:Label>
                    </td>
                    <td align="right">
                        <asp:Button ID="Button1" runat="server" Text="X" ForeColor="white" 
                            BorderStyle="None" BackColor="#0379BD"/>
                     </td>        
                </tr>               
             </table>      
            <table align="center" width="400" style="background:white; height: 184px;" >
                
                <tr><td colspan="3"><asp:Label ID="share" runat="server" Text="Tell your friend about this site ." ForeColor="#003366" ></asp:Label></td></tr>
                <tr align="left" style="margin-left:5px">
                    <td class="style4" colspan="2" align="center">
                   
                     <asp:Label ID="Label12" runat="server" Text="Your Name*" ForeColor="Black" Font-Bold="false" ></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtname1" runat="server" ValidationGroup="modal" Width="140px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="reqcmpnme" runat="server" 
          ErrorMessage="please enter your name" ControlToValidate="txtname1"  ValidationGroup="share">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr align="left" style="margin-left:5px">
                    <td class="style4" colspan="2" align="center">
                   
                     <asp:Label ID="Label6" runat="server" Text="Your's Friend Name*" ForeColor="Black" Font-Bold="false" ></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtfname" runat="server" ValidationGroup="modal" Width="140px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
          ErrorMessage="please enter your friend's name" ControlToValidate="txtfname"  
                            ValidationGroup="share">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr align="left" style="margin-left:5px">
                    <td class="style4" colspan="2" align="center">
                        <asp:Label ID="Label7" runat="server" Text="Your Friend's Email_Id*" ForeColor="Black" Font-Bold="false" ></asp:Label>
                       </td>
                    <td>
                        <asp:TextBox ID="txtfmail" runat="server" ValidationGroup="modal" Width="140px"></asp:TextBox>
                   
                   <asp:RequiredFieldValidator ID="RequiredFieldValidator14" runat="server" ControlToValidate="txtfmail" 
          ErrorMessage="please enter Email id"  ValidationGroup="share">*</asp:RequiredFieldValidator>
      <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
          ErrorMessage="Incorrect Format of email address" 
          ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
          ValidationGroup="share" ControlToValidate="txtfmail" >*</asp:RegularExpressionValidator>
                    </td>
                </tr>
                 <tr align="left" style="margin-left:5px">
                    <td class="style4" colspan="2" align="center">
                        <asp:Label ID="Label13" runat="server" Text="Your Friend's Mobile_No*" ForeColor="Black" Font-Bold="false" ></asp:Label>
                       </td>
                    <td>
                        <asp:TextBox ID="txtmob" runat="server" ValidationGroup="modal" Width="140px" MaxLength="11"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" 
          ControlToValidate="txtmob" ErrorMessage="Only numbers are allowed for mobile" 
          ValidationExpression="\d{11}" ValidationGroup="share">*</asp:RegularExpressionValidator>
      <asp:RequiredFieldValidator ID="RequiredFieldValidator15" runat="server" 
          ErrorMessage="Please enter contact number" ControlToValidate="txtmob"  
                            ValidationGroup="share">*</asp:RequiredFieldValidator>
      <asp:RangeValidator ID="RangeValidator1" runat="server" 
          ErrorMessage=" Mobile Number must start with 0" ControlToValidate="txtmob"  
                            MaximumValue="1" MinimumValue="0" 
          ValidationGroup="share">*</asp:RangeValidator>
          <asp:ValidationSummary ID="ValidationSummary3" runat="server" 
          ValidationGroup="share" ShowMessageBox="True" ShowSummary="False" />
                    </td>
                </tr>
                
                <tr>
                    <td width="10"></td>
                </tr>
                <tr><td><asp:Label ID="Label14" runat="server"></asp:Label></td></tr>
                <tr align="left" style="margin-left:5px">
                    <td align="right" class="style4">
                        <asp:Button ID="Button2" runat="server" Text="Submit" 
                            ValidationGroup="share" CausesValidation="true" Width="62px" OnClick="submitbutton1_Click" />
                    </td>
                    <td>
                        <asp:Button ID="Button3" runat="server" Text="Cancel" ValidationGroup="modal" CausesValidation="true" />
                    </td>
                </tr>
                <tr align="left" style="margin-left:5px">
                    <td class="style4">
                    <asp:HyperLink ID="HyperLink1" runat="server" Text="Home Page" ForeColor="Blue" Font-Bold="false" 
                    NavigateUrl="Default.aspx"></asp:HyperLink>
                    </td>
                </tr>
            </table>
      </fieldset>
      </asp:Panel>--%>
       <%-- <AjaxToolkit:ModalPopupExtender ID="ModalPopupExtender1" runat="server"
         TargetControlID="friend" BackgroundCssClass="modalbackground" PopupControlID="friendpanel" 
         CancelControlID="cancelbutton" OkControlID="x1" DropShadow="false" PopupDragHandleControlID="panel5">
              </AjaxToolkit:ModalPopupExtender>
--%>
    <AjaxToolkit:ModalPopupExtender ID="ModalPopupExtender" runat="server"  
        TargetControlID="imgbtnSendMail" PopupControlID="Panel3" BackgroundCssClass="modalBackground" 
        OkControlID="btnXSendSMS" CancelControlID="cancelbutton" 
        DropShadow="false" PopupDragHandleControlID="panel4" ></AjaxToolkit:ModalPopupExtender>
    </div>
    </div>
     <%--   </asp:Panel>--%>
    <table width="100%"><tr align="center"><td>
     <asp:Button ID="btnBack" runat="server" Text="Back" onclick="btnBack_Click"/>
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
        ShowMessageBox="True" ShowSummary="False" ValidationGroup="SendMail" />
        </td></tr></table>
        </td></tr>
   </table>
   </td></tr>      
        
</table>
</div>
<div class="contentmid_boxbottam"></div>
</div>
</div>
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
</div>
<div class="content_midbootam" >
<aa5:bottomMidcontent ID="mid1" runat="server" />
</div>
<div class="content_bootam_center">
<aa4:bottomcontent ID="bottomcontent1" runat="server" />
</div>


<div class="footer" align="center" style="padding-top:5px">
<aa10:footer1 ID="bvu" runat="server" />
<aa11:footer2 ID="ayh" runat="server" />
</div>

</div>
</form>
</body>
</html>
