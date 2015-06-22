<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Eventshome.aspx.cs" Inherits="Eventshome" %>
<%@ Register Src="usercontrols/eventleft.ascx" TagName="leftevent" TagPrefix="el" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="AjaxToolkit"%>
<%@ Register Src="usercontrols/everight.ascx" TagName="eventright" TagPrefix="ever" %>
<%@ Register Src="usercontrols/footer1.ascx" TagName="footer1" TagPrefix="aa10" %>
<%@ Register Src="usercontrols/footer2.ascx" TagName="footer2" TagPrefix="aa11" %>
<%@ Register Src="usercontrols/Search.ascx" TagName="catageories" TagPrefix="aa6" %>
<%@ Register Src="usercontrols/signin.ascx" TagName="signin" TagPrefix="sig" %>
<%@ Register Src="usercontrols/topimage.ascx" TagName="topimage" TagPrefix="aa2" %>
<%@ Register Src="usercontrols/Search.ascx" TagName="searchjob" TagPrefix="sj" %>
<%@ Register Src="usercontrols/BottomContent.ascx" TagName="bottomcontent" TagPrefix="aa4" %>
<%@ Register Src="usercontrols/BottomMidContent.ascx" TagName="bottomMidcontent" TagPrefix="aa5" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>:: Justcalluz :: Home page</title>

<link href="css/style.css" rel="Stylesheet" type="text/css" />
<link href="css/inner_style.css" rel="Stylesheet" type="text/css" /> 
    <style type="text/css">
        .style1
        {
            width: 7px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
</asp:ScriptManager>
    <div class="layout">
<div class="signin">
<sig:signin ID="sig1" runat="server" />
</div>
<div class="logo" align="center">
<aa2:topimage ID="bbb" runat="server" />
</div>
<div class="search" align="center">
 <sj:searchjob ID="sjs" runat="server" />
</div>

<div class="selection" align="center">
<aa6:catageories ID="fgu" runat="server" />
</div>

<div class="content_inner">

<!-- start the inner left-->
<div class="content_innerleft">
<div class="contenbox">
<div class="contentbox_top">Events</div>
<div class="contentbox_mid"> 
<!-- start the inner left-->
<el:leftevent ID="left" runat="server" />
</div>
<div class="contentbox_bottam"></div>
</div>
</div>

<!-- end of the inner left-->

<!-- start the mid Box-->
  <div class="content_innermid">
  <div class="contentmid_box">
  <div class="contentmid_boxtop">Home&gt;&gt; Events</div>
  <div class="contentmid_boxmid">
  <table width="100%" border="0">
  <tr>
    <td width="48%" height="30" align="right" class="headings" style="padding-right:5px;">Result for</td>
    <td width="1%"><font color="#000000"><strong>:</strong></font></td>
    <td width="51%" align="light"><font color="#006393" class="side_menu"><a href="#">Events</a></font></td>
  </tr>
  <tr>
    <td colspan="3" style="background:url(images/events-search.png) no-repeat" valign="top" ><table width="100%" border="0">
        <tr>
          <td colspan="2" rowspan="2" valign="top" ><table width="100%" border="0">
            <tr>
              <td height="20" colspan="4" class="sub_menu" style="padding-left:20px;">Choose A Date</td>
            </tr>
            <tr>
              <td width="13%" class="headings1" style="padding-left:40px;">From</td>
              <td width="29%"><asp:TextBox ID="txtfrom" runat="server"></asp:TextBox></td>
              <td width="6%" class="headings1" align="center"><span style="padding-left:10px; padding-top:10px;">To</span></td>
              <td width="29%"><asp:TextBox ID="txtto" runat="server"></asp:TextBox></td>
              <td width="23%" style="padding-left:5px;"><asp:ImageButton ID="go" runat="server" 
                      ImageUrl="~/images/go.png" onclick="go_Click" /></td>
            </tr>
          </table>
           <AjaxToolkit:CalendarExtender Animated="true" ID="calenderExtender1" runat="server" TargetControlID="txtfrom"></AjaxToolkit:CalendarExtender>
      <AjaxToolkit:CalendarExtender Animated="true" ID="CalendarExtender2" runat="server" TargetControlID="txtto"></AjaxToolkit:CalendarExtender>
          </td>
          <td width="1%" height="30">&nbsp;</td>
        </tr>
        <tr>
          <td height="27">&nbsp;</td>
        </tr>
        <tr>
          <td width="81%" height="40" style="padding-left:15px;"><span class="side_menu"><asp:linkbutton ID="todaybut" runat="server" Text="Today" OnClick="todaybut_Click"></asp:linkbutton></span>&nbsp; | <span class="side_menu">&nbsp;<asp:linkbutton ID="tombut" runat="server" Text="Tomorrow" OnClick="tombut_Click"></asp:linkbutton>&nbsp; &nbsp;</span>| &nbsp;<span class="side_menu">&nbsp;<asp:linkbutton ID="weekbut" runat="server" Text="This Weekend" OnClick="weekbut_Click"></asp:linkbutton></span><span class="side_menu">&nbsp;</span> |&nbsp;<span class="side_menu">&nbsp;<asp:linkbutton ID="nweekbut" runat="server" Text="Next Weekend" OnClick="nweekbut_Click"></asp:linkbutton></span><span class="side_menu">&nbsp;</span>&nbsp;|&nbsp;&nbsp;</td>
          <td width="18%" valign="middle" style="padding-left:15px;">&nbsp;</td>
          <td>&nbsp;</td>
        </tr>
      </table></td>
  </tr>
  <tr>
    <td colspan="3" style="padding:8px;">
    <table width="100%" border="0">
    <tr><td>
    <asp:DataList ID="ddlevents" DataKeyField="id" runat="server" Width="520px"
         >
          <HeaderTemplate>
            <table border="1" width="500px">
            
        </HeaderTemplate>
          <ItemTemplate>
            <tr>
                <td valign="top">
                    <table width="45%">
                        <tr>
                            <td>
                            </td>
                        </tr>
                        <table width="45%">
                        <tr>
                            <td>
                            </td>
                        </tr>
                         <tr>
                            <td>
                               <table width="70%" cellpadding="0px" cellspacing="0px">
                                    <tr>
                                        <td class="dashboardbg" style=" padding:10px;">
                                            <table cellpadding="0Px" cellspacing="0px" width="370PX" align="center">
                                               <tr>
                                                   <td valign="top" width="24%">
                                                       <div style="padding: 0px; margin: 0px;">
                                                                <table width="500px" border="0">
                                                                    <tr>
                                                                        <td width="23%" rowspan="3" align="center" style="padding-bottom:20px;"><img src="images/event/2.png" width="99" height="68" /></td>
                                                                         <td width="60%" class="headings">
                                                                            <asp:LinkButton  ID="Linkbutton1" ForeColor="Red" runat="server" PostBackUrl='<%# string.Format("eventdetails.aspx?id="+ Eval("id").ToString()) %>' 
                                                                                 Text ='<%# Eval("event_name") %>'  CommandName ="Select" ></asp:LinkButton>
                                                                        </td> 
                                                                        <td height="20"><p><strong class="side_menu">
                                                                                                                                                   
                                                                        <asp:LinkButton  ID="LinkButton4" runat="server" PostBackUrl='<%# string.Format("postreview1.aspx?id=" + Eval("id").ToString())%>'   
                                                                                     Text="Rate this"  CommandName ="Select" ></asp:LinkButton>
                                                                                     </strong>
                                                                        </td>    
                                                                     </tr>
                                                                     <tr>
                                                                        <td style="height:5px"></td>
                                                                     </tr>
                                                                     <tr>
                                                                        <td height="20"><p><strong class="side_menu">Venue</strong>&nbsp;:<span class="headings1"><asp:Literal ID="Literal2" runat="server" Text='<%#Eval("event_place")%>' /></span></p></td>
                                                                     </tr>
                                                                      <tr>
                                                                      <td></td>
                                                                        <td height="20" colspan="5"><asp:Literal ID="Literal3" runat="server" Text='<%#Eval("event_desc")%>' /></td>
                                                                      </tr>
                                                                    <tr><td height="5px">&nbsp;</td></tr>
                                                                    <tr><td colspan="6" align="right" class="side_menu">
                                                                        <asp:LinkButton ID="friend" runat="server" Text="Share with your friend" Font-Size="11px"></asp:LinkButton>
                                                                                &nbsp;&nbsp;&nbsp;
                                                                                <asp:HyperLink ID="details" runat="server" Text="View Details" Font-Size="11px" NavigateUrl='<%# "Event_details.aspx?id=" + Eval("id").ToString() %>' ></asp:HyperLink></td>
                                                                     
                                                                     
                                                                    </td></tr>
                                                                  </table>           
                                                            </div>
                                                    </td>
                                               </tr>
                                            </table>
                                        </td>
                                    </tr>
                               </table>
                             </td>
                         </tr>
                     
                    </table>
                </td>
            </tr>
           <AjaxToolkit:ModalPopupExtender ID="ModalPopupExtender1" runat="server" TargetControlID="friend" BackgroundCssClass="modalbackground" PopupControlID="friendpanel" OkControlID="btncancel" DropShadow="false" PopupDragHandleControlID="panel1">
              </AjaxToolkit:ModalPopupExtender>
              
           
        </ItemTemplate>
          <FooterTemplate>
            </table>
        </FooterTemplate>
        
        
        </asp:DataList>
<asp:Panel ID="friendpanel" runat="server" Width="350px">
<fieldset>
<div class="dilogbox">
<table width="350px">
<tr>
<td colspan="3" align="center" valign="top" 
        style="font-family:Arial; font-size:large; color:#003366;">&nbsp; Share with your friend
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
   <asp:ImageButton ID="btncancel" ImageUrl="../images/panel/cencel.png" width="21" height="22" runat="server"/></td>
</tr>
<tr>
  <td height="194" colspan="3">
     <table align="center" width="400px" style="height: 184px;">
      <tr>
        <td colspan="3">
         <asp:Label ID="Label1" runat="server" Text="Tell your friend about this site ." ForeColor="#003366" ></asp:Label></td>
      </tr>
      <tr align="left" style="margin-left:5px">
        <td style="width:160px;">&nbsp;<span class="star">*</span><asp:Label ID="Label2" runat="server" Text="Your Name" ForeColor="Black" Font-Bold="false" ></asp:Label></td>
        <td class="style1">&nbsp;:</td>
        <td style="width:240px;">
         <asp:TextBox ID="txtname" runat="server" validationgroup="modal" Width="140px"></asp:TextBox>
          <asp:RequiredFieldValidator ID="rfvtxtname" runat="server" 
                ErrorMessage="please enter your name" ControlToValidate="txtname"  validationgroup="share">*</asp:RequiredFieldValidator></td>
      </tr>
      <tr align="left" style="margin-left:5px">
        <td>&nbsp;<span class="star">*</span><asp:Label ID="Label3" runat="server" Text="Your's Friend Name" ForeColor="Black" Font-Bold="false" ></asp:Label></td>
        <td class="style1">&nbsp;:</td>
        <td>
        <asp:TextBox ID="txtfname" runat="server" validationgroup="modal" Width="140px"></asp:TextBox>
          <asp:RequiredFieldValidator ID="rfvtxtfname" runat="server" 
               ErrorMessage="please enter your friend's name" ControlToValidate="txtfname"  
                    validationgroup="share">*</asp:RequiredFieldValidator></td>
      </tr>
       <tr align="left" style="margin-left:5px">
        <td width="67" height="29">&nbsp;<span class="star">*</span><asp:Label ID="Label8" runat="server" Text="Your Friend's Mobile_No" ForeColor="Black" Font-Bold="false" ></asp:Label>
        </td>
        <td class="style1">&nbsp;:</td>
        <td>
        <asp:TextBox ID="txtmob" runat="server" validationgroup="modal" Width="140px" MaxLength="11"></asp:TextBox>
          <asp:RegularExpressionValidator ID="revtxtmob" runat="server" 
         ControlToValidate="txtmob" ErrorMessage="Only numbers are allowed for mobile" 
          ValidationExpression="\d{11}" validationgroup="share">*</asp:RegularExpressionValidator>
          <asp:RequiredFieldValidator ID="rfvtxtmob" runat="server" 
             ErrorMessage="Please enter contact number" ControlToValidate="txtmob"  
                    validationgroup="share">*</asp:RequiredFieldValidator>
          <asp:RangeValidator ID="rgvtxtmob" runat="server" 
              ErrorMessage=" Mobile Number must start with 0" ControlToValidate="txtmob"  
                    MaximumValue="1" MinimumValue="0" 
               validationgroup="share">*</asp:RangeValidator>
       </td>
      </tr>
      <tr align="left" style="margin-left:5px">
        <td>&nbsp;<span class="star">*</span><asp:Label ID="Label4" runat="server" Text="Your Friend's Email_Id" ForeColor="Black" Font-Bold="false" ></asp:Label>
         <asp:Label ID="lblerror" runat="server"></asp:Label>
        </td>
        <td class="style1">&nbsp;:</td>
        <td>
        <asp:TextBox ID="txtFEmail" runat="server" validationgroup="modal" Width="140px"></asp:TextBox>
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
  <td width="241" height="37">&nbsp;</td>
  <td width="163" valign="top">
  <asp:ImageButton ID="imggo" OnClick="imggo_Click" ImageUrl="../images/panel/dialog_buttan.png" width="98" height="35" runat="server" ValidationGroup="share"/>
  </td>
</tr>
</table>
</div>
</fieldset>
</asp:Panel>
  <table border="0" style="background-color:white; width: 100px; margin-right: 0px; height: 22px;">
            <tr>
                <td>
                    <asp:DropDownList ID="ddlPageSize" runat="server" 
                        OnSelectedIndexChanged="ddlPageSize_SelectedIndexChanged" 
                        style="height: 22px">
                    <asp:ListItem>3</asp:ListItem>
                    <asp:ListItem>5</asp:ListItem>
                    <asp:ListItem>10</asp:ListItem>
                    </asp:DropDownList>
                </td>
               <td>
                <asp:LinkButton ID="lnkbtnPrevious" runat="server" OnClick="lnkbtnPrevious_Click1" 
                        Font-Bold="True" Font-Size="Medium" Font-Underline="False" ForeColor="#FF6600">Previous</asp:LinkButton>
                </td>
                <td>
                <asp:DataList ID="dlPaging" runat="server" OnItemCommand="dlPaging_ItemCommand" 
                    OnItemDataBound="dlPaging_ItemDataBound" RepeatDirection="Horizontal" 
                        ForeColor="#996633">            
                    <ItemTemplate>
                        <asp:LinkButton ID="lnkbtnPaging" runat="server" 
                        CommandArgument='<%# Eval("PageIndex") %>' 
                        CommandName="lnkbtnPaging" 
                        Text='<%# Eval("PageText") %>'>LinkButton</asp:LinkButton>&nbsp;
                    </ItemTemplate>
               </asp:DataList>

                </td>
                <td>
                    <asp:LinkButton ID="lnkbtnNext" runat="server" OnClick="lnkbtnNext_Click1" Font-Bold="True" Font-Size="Medium" Font-Underline="False" ForeColor="#FF6600">Next</asp:LinkButton>
                </td>
            </tr>
        </table>
        
      </td></tr>
    </table>
    
    </td>
  </tr>
  <tr>
    <td colspan="3">&nbsp;</td>
  </tr>
  </table>
  </div>
  <div class="contentmid_boxbottam"></div>
  
  </div>
  
  </div>
  
  <div class="content_innerright">
<div class="contenbox">
<div class="contentbox_top">Sponsor Ads</div>
<div class="contentbox_mid">

  <ever:eventright ID="eventright" runat="server" />
  </div>
<div class="contentbox_bottam"></div>
</div></div>

<div class="content_midbootam" >
<aa5:bottomMidcontent ID="mid1" runat="server" />
</div>
<div class="content_bootam_center">
<aa4:bottomcontent ID="bottomcontent1" runat="server" />
</div>


<div class="footer" align="center"> 
<aa10:footer1 ID="footer" runat="server" />
<aa11:footer2 ID="ayh" runat="server" />
</div>
</div>
</div>
    </form>
</body>
</html>
