<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Admin_Data_Details.aspx.cs" Inherits="admin_Data_Details" %>
<%@ Register Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" TagPrefix="cc3"  %>
<%@ Register Src="~/admin/user_control/Admin_Headermenu.ascx" TagName="Headermenu" TagPrefix="cc1" %>
<%@ Register Src="~/admin/user_control/Admin_LeftMenu.ascx" TagName="LeftMenu" TagPrefix="cc4" %>
<%@ Register Src="~/admin/user_control/Admin_DataHeader.ascx" TagName="DataHeader" TagPrefix="datahead" %>
<%@ Register Src="~/admin/user_control/Admin_MoviesHeader.ascx" TagName="MovieHeader" TagPrefix="cc2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Justcalluz - Admin Control Panel - Data_in detailed manner</title>
    <link href="includes/style.css" rel="Stylesheet" type="text/css" />    
    <script src="js/statesopt.js" type="text/javascript"></script>
    <script type="text/javascript" src="js/tab.js"></script>
    <style type="text/css">
        .style39
        {
            width: 195px;
        }
        .cal_theme .ajax__calendar_active   

        {     
            color: Red;      
            font-weight: bold;      
            background-color: #ffffff; 
        } 
        .style40
        {
            width: 188px;
        }
        </style>
        <style type="text/css">
        .style37
        {
            width: 900px;
        }
        .style39
        {
            width: 100px;
        }        
        </style>
      <script type="text/javascript">
function CurrentDateShowing(e)
{
      if (!e.get_selectedDate() || !e.get_element().value)

      e._selectedDate = (new Date()).getDateOnly();
}    
</script>
 <script type="text/javascript">
function poponload()
{
    testwindow = window.open("http://www.justcalluz.com", "mywindow", "location=1,status=1,scrollbars=1,width=500,height=500");
    testwindow.moveTo(400,-2000);
}
</script>
</head>
 <body onload="new Accordian('basic-accordian',5,'header_highlight');">
   <form id="form1" runat="server">
   <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
   <center>
    <div>
       <table cellpadding="0" cellspacing="0">
         <tr>
            <td>
             <cc1:headermenu ID="header" runat="server" />
            </td>
         </tr>
         <tr>
          <td>                  
           <table cellpadding="0" cellspacing="0" width="100%">
              <tr>
               <td class="style39" valign="top" style="padding-top:4px">                        
                 <cc4:LeftMenu ID="LeftMenu1" runat="server" />
                </td>
                <td valign="top">&nbsp;</td>
                <td valign="top" style="padding-left:10px; background-color:#F2FAFC">  
                    <table width="750px">
                    <tr id="trDataHeader" runat="server">
                    <td>                      
                       <datahead:DataHeader ID="datahead1" runat="server" />
                    </td>
                    </tr>
                    <tr id="trMovieHeader" runat="server">
                    <td>                      
                      <cc2:MovieHeader ID="mheader" runat="server" />
                    </td>
                    </tr>                        
                        <tr>
                            <td colspan="2" align="right" style="padding-right:8px;">
                               <a href="http://www.justcalluz.com" target="_blank"><img alt="SiteView" src="images/Click Here For SiteView.png" 
                               alt="Siteview"/></a>
                            </td>
                         <tr>
                            <td colspan="2" align="right" style="padding-right:8px;">
                              <asp:LinkButton ID="lnkBack" runat="server" onlick="lnkBack_Click" Text="Back" 
                                    onclick="lnkBack_Click"></asp:LinkButton>
                            </td>
                        </tr> 
                        </tr> 
                         <tr>
                            <td colspan="3" align="center">
                            <asp:Button ID="ImgBtnViewReview" runat="server" Text="View Review" 
                                 OnClick="ImgBtnViewReview_Click" style="border-radius:1px solid black;" />                          
                             &nbsp;
                            <asp:Button ID="BtnStatus" runat="server" Text="View Status of this advertise in detail"  
                                 OnClick="BtnStatus_Click" style="border-radius:1px solid black;" />                          
                                <%--<asp:ImageButton ID="ImgBtnBack" runat="server" 
                                    ImageUrl="~/admin/images/back.png" onclick="ImgBtnBack_Click" Height="30px"/>
                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;--%>
                                <%--<asp:ImageButton ID="ImgBtnViewReview" runat="server" 
                                    ImageUrl="~/admin/images/view_review.png" onclick="ImgBtnViewReview_Click" Height="25px" Width="91px"/>
                                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:Button ID="BtnStatus" runat="server" BackColor="#996699" ForeColor="White" Font-Bold="true" 
                                    Text="View Status of this advertise in detail" onclick="BtnStatus_Click"/>--%>
                            </td>
                            </tr>                                                                  
                        <tr>
                            <td colspan="2">
                             <table class="lable" width="98%">
                               <tr>
                               <td class="lable">
                                    <table id="tblData" runat="server" border="0" cellpadding="0" cellspacing="2" width="100%" style="background-color:#CEE3F6; border:double 1px #08088A;">
                                        <tr>
                                            <td colspan="3" align="center" class="headings">
                                                <h2 style="font-size:16px; font-family:Verdana;">
                                                   <asp:Label ID="lblComporEveName" runat="server"></asp:Label> 
                                                </h2>
                                            </td>
                                        </tr>
                                       
                                                    <tr>
                                                        <td colspan="3" class="mid_menu">
                                                             <asp:Label ID="lblMessage" runat="server"></asp:Label>
                                                        </td>
                                                    </tr>
                                                   
                                                                <tr id="trMod" class="mid_menu">
                                                                    <td valign="top" align="right" class="style40" width="33%">
                                                                    Module
                                                                    </td>
                                                                    <td valign="top" align="center" width="5%">
                                                                          &nbsp;:&nbsp;
                                                                    </td>
                                                                    <td valign="top" align="left">
                                                                        <asp:Label ID="lblModule" runat="server" ></asp:Label>                                                                       
                                                                    </td>
                                                                </tr>
                                                                                                                         
                                                                <tr id="trCat" class="mid_menu">
                                                                    <td valign="top" align="right" class="style40">
                                                                        Category
                                                                    </td>
                                                                    <td valign="top" align="center">
                                                                         &nbsp;:&nbsp;
                                                                    </td>
                                                                    <td valign="top" align="left">
                                                                        <asp:Label ID="lblCat" runat="server" ></asp:Label>                                                                       
                                                                    </td>
                                                                </tr>
                                                                <tr id="trSubCat" class="mid_menu">
                                                                    <td valign="top" align="right" class="style40">
                                                                        Sub Category
                                                                    </td>
                                                                    <td valign="top" align="center">
                                                                        &nbsp;:&nbsp;
                                                                    </td>
                                                                    <td valign="top" align="left">
                                                                        <asp:Label ID="lblSubCat" runat="server" ></asp:Label>                                                                       
                                                                    </td>
                                                                </tr>
                                                                <tr id="trHEveDetails" class="sub_menu">
                                                                    <td valign="top" colspan="1" align="right" style="text-decoration:underline;">
                                                                        <asp:Label ID="lblHEveDetails" runat="server" Text="Event Details " ForeColor="Red"></asp:Label>                                                                        
                                                                    </td>
                                                                    <td colspan="2">&nbsp;</td>
                                                                </tr>
                                                                <tr id="trEveName" class="mid_menu">
                                                                    <td valign="top" align="right" class="style40">
                                                                       Name of the event 
                                                                    </td>
                                                                    <td valign="top" align="center">
                                                                        &nbsp;:&nbsp;
                                                                    </td>
                                                                    <td valign="top" align="left">
                                                                        <asp:Label ID="lblEveName" runat="server"></asp:Label>                                                                       
                                                                    </td>
                                                                </tr>
                                                                <tr id="trEvePlace" class="mid_menu">
                                                                    <td valign="top" align="right" class="style40">
                                                                       Place of the Event 
                                                                    </td>
                                                                    <td valign="top" align="center">
                                                                       &nbsp;:&nbsp;
                                                                    </td>
                                                                    <td valign="top" align="left">
                                                                        <asp:Label ID="lblEvePlace" runat="server"></asp:Label>                                                                       
                                                                    </td>
                                                                </tr>
                                                                <tr id="trEveStartDate" class="mid_menu">
                                                                    <td valign="top" align="right" class="style40">
                                                                        Event Starts from Date
                                                                    </td>
                                                                    <td valign="top" align="center">
                                                                          &nbsp;:&nbsp;
                                                                    </td>
                                                                    <td valign="top" align="left">
                                                                        <asp:Label ID="lblEveStartDate" runat="server"></asp:Label>                                                                       
                                                                    </td>
                                                                </tr>
                                                                <tr id="treveEndsDate" class="mid_menu">
                                                                    <td valign="top" align="right" class="style40">
                                                                        Event Ends to Date
                                                                    </td>
                                                                    <td valign="top" align="center">
                                                                          &nbsp;:&nbsp;
                                                                    </td>
                                                                    <td valign="top" align="left">
                                                                        <asp:Label ID="lblEveEndDtae" runat="server"></asp:Label>                                                                       
                                                                    </td>
                                                                </tr>
                                                                <tr id="treveTime" class="mid_menu">
                                                                    <td valign="top" align="right" class="style40">
                                                                        Time of the Event
                                                                    </td>
                                                                    <td valign="top" align="center">
                                                                         &nbsp;:&nbsp;
                                                                    </td>
                                                                    <td valign="top" align="left">
                                                                        <asp:Label ID="lblEveTime" runat="server"></asp:Label>                                                                       
                                                                    </td>
                                                                </tr>
                                                                <tr id="treveDescription" class="mid_menu">
                                                                    <td valign="top" align="right" class="style40">
                                                                        Event Description
                                                                    </td>
                                                                    <td valign="top" align="center">
                                                                         &nbsp;:&nbsp;
                                                                    </td>
                                                                    <td valign="top" align="left" style="text-align:justify">
                                                                        <asp:Label ID="lblEveDescription" runat="server"></asp:Label>                                                                       
                                                                    </td>
                                                                </tr>
                                                                                                               
                                                                <tr id="trHDisDetails" class="sub_menu">
                                                                    <td valign="top" colspan="1" align="right" style="text-decoration:underline;">
                                                                        <asp:Label ID="lblHDisDetails" runat="server" Text="Discount Details " ForeColor="Red"></asp:Label>                                                                        
                                                                    </td>
                                                                    <td colspan="2">&nbsp;</td>
                                                                </tr>
                                                                <tr id="trdisStartDate" class="mid_menu">
                                                                    <td valign="top" align="right" class="style40">
                                                                        Discount Starts from Date
                                                                    </td>
                                                                    <td valign="top" align="center">
                                                                         &nbsp;:&nbsp;
                                                                    </td>
                                                                    <td valign="top" align="left">
                                                                        <asp:Label ID="lblDisStartDate" runat="server"></asp:Label>                                                                       
                                                                    </td>
                                                                </tr>
                                                                <tr id="trDisEndDate" class="mid_menu">
                                                                    <td valign="top" align="right" class="style40">
                                                                        Discount Ends to Date
                                                                    </td>
                                                                    <td valign="top" align="center">
                                                                         &nbsp;:&nbsp;
                                                                    </td>
                                                                    <td valign="top" align="left">
                                                                        <asp:Label ID="lblDisEndDate" runat="server"></asp:Label>                                                                       
                                                                    </td>
                                                                </tr>
                                                                <tr id="trDisTime" class="mid_menu">
                                                                    <td valign="top" align="right" class="style40">
                                                                        Time of the Discount exist
                                                                    </td>
                                                                    <td valign="top" align="center">
                                                                         &nbsp;:&nbsp;
                                                                    </td>
                                                                    <td valign="top" align="left">
                                                                        <asp:Label ID="lblDisTime" runat="server"></asp:Label>                                                                       
                                                                    </td>
                                                                </tr>
                                                                <tr id="trDisDetails" class="mid_menu" >
                                                                    <td valign="top" align="right" class="style40">
                                                                        Discount Description 
                                                                    </td>
                                                                    <td valign="top" align="center">
                                                                         &nbsp;:&nbsp;
                                                                    </td>
                                                                    <td valign="top" align="left" style="text-align:justify">
                                                                        <asp:Label ID="lblDisDetails" runat="server"></asp:Label>                                                                       
                                                                    </td>
                                                                </tr>                                            
                                                                <tr id="trHCompDetails" class="sub_menu">
                                                                    <td valign="top" colspan="1" align="right" style="text-decoration:underline;">
                                                                        <asp:Label ID="lblCompEveHeading1" runat="server" Text="Company Details " ForeColor="Red"></asp:Label>
                                                                        
                                                                    </td>
                                                                    <td colspan="2">&nbsp;</td>
                                                                </tr>
                                                                <tr id="trCompName" class="mid_menu">
                                                                    <td valign="top" align="right" class="style40">
                                                                        <asp:Label ID="lblCompHeading" runat="server" Text="Name of the Company"></asp:Label> 
                                                                    </td>
                                                                    <td valign="top" align="center">
                                                                         &nbsp;:&nbsp;
                                                                    </td>
                                                                    <td valign="top" align="left">
                                                                        <asp:Label ID="lblCompanyName" runat="server" ></asp:Label>                                                                        
                                                                    </td>
                                                                </tr>
                                                                <tr id="trComprofile" class="mid_menu">
                                                                    <td valign="top" align="right" class="style40">
                                                                        <asp:Label ID="lblCompanyProfile" runat="server" Text="Company Profile"></asp:Label> 
                                                                    </td>
                                                                    <td valign="top" align="center">
                                                                         &nbsp;:&nbsp;
                                                                    </td>
                                                                    <td valign="top" align="left" style="text-align:justify">
                                                                        <asp:Label ID="lblComprofile" runat="server" ></asp:Label>                                                                        
                                                                    </td>
                                                                </tr>  
                                                                                                             
                                                                <tr id="trAddress" class="mid_menu">
                                                                    <td valign="top" align="right" class="style40">
                                                                        Address
                                                                    </td>
                                                                    <td valign="top" align="center">
                                                                          &nbsp;:&nbsp;
                                                                    </td>
                                                                    <td valign="top" align="left">
                                                                        <table border="0" cellpadding="0" cellspacing="0" class="lable" width="199">
                                                                            <tr>
                                                                                <td valign="top">
                                                                                    <asp:Label ID="lblAddress" runat="server" ></asp:Label>                                                                                   
                                                                                    <br />
                                                                                </td>
                                                                            </tr>
                                                                            <tr>
                                                                                <td valign="top">
                                                                                    <asp:Label ID="lblArea" runat="server" ></asp:Label>                                                                                    
                                                                                    <br />
                                                                                </td>
                                                                            </tr>
                                                                            <tr>
                                                                                <td valign="top">
                                                                                    <asp:Label ID="lblCity" runat="server" ></asp:Label>                                                                                    
                                                                                    <br />
                                                                                </td>
                                                                            </tr>
                                                                            <tr>
                                                                                <td valign="top">
                                                                                    <asp:Label ID="lblState" runat="server" ></asp:Label>                                                                                   
                                                                                    <br />
                                                                                </td>
                                                                            </tr>
                                                                        </table>
                                                                    </td>
                                                                </tr>
                                                                <tr id="trLandMark" class="mid_menu">
                                                                    <td valign="top" align="right" class="style40">
                                                                        LandMark
                                                                    </td>
                                                                    <td valign="top" align="center">
                                                                          &nbsp;:&nbsp;
                                                                    </td>
                                                                    <td valign="top " align="left">
                                                                        <asp:Label ID="lblLandMark" runat="server" ></asp:Label>                                                                                   
                                                                        <br />
                                                                    </td>
                                                                </tr>
                                                                <tr id="trPincode" class="mid_menu">
                                                                    <td valign="top" align="right" class="style40">
                                                                       PinCode
                                                                    </td>
                                                                    <td valign="top" align="center">
                                                                         &nbsp;:&nbsp;
                                                                    </td>
                                                                    <td valign="top" align="left">
                                                                        <asp:Label ID="lblPinCode" runat="server"></asp:Label>                                                                       
                                                                    </td>
                                                                </tr>
                                                                <tr id="trContPer" class="mid_menu">
                                                                    <td valign="top" align="right" class="style40">
                                                                        Contact Person
                                                                    </td>
                                                                    <td valign="top" align="center">
                                                                         &nbsp;:&nbsp;
                                                                    </td>
                                                                    <td valign="top" align="left">
                                                                        <asp:Label ID="lblContPer" runat="server"></asp:Label>                                                                       
                                                                    </td>
                                                                </tr>
                                                                 <tr id="trEmail" class="mid_menu">
                                                                    <td valign="top" align="right" class="style40">
                                                                        Email
                                                                    </td>
                                                                    <td valign="top" align="center">
                                                                         &nbsp;:&nbsp;
                                                                    </td>
                                                                    <td valign="top" align="left">
                                                                        <asp:Label ID="lblEmail" runat="server"></asp:Label>                                                                        
                                                                    </td>
                                                                </tr>                                                                
                                                                <tr id="trMobile" class="mid_menu">
                                                                    <td valign="top" align="right" class="style40">
                                                                        Mobile 
                                                                    </td>
                                                                    <td valign="top" align="center">
                                                                         &nbsp;:&nbsp;
                                                                    </td>
                                                                    <td valign="top" align="left">
                                                                        <asp:Label ID="lblMobile" runat="server"></asp:Label>                                                                        
                                                                    </td>
                                                                </tr>
                                                                <tr id="trPhone" class="mid_menu">
                                                                    <td valign="top" align="right" class="style40">
                                                                        <span>Phone </span>
                                                                    </td>
                                                                    <td valign="top" align="center">
                                                                         &nbsp;:&nbsp;
                                                                    </td>
                                                                    <td valign="top" align="left">
                                                                        <asp:Label ID="lblPhone" runat="server"></asp:Label>                                                                        
                                                                    </td>
                                                                </tr>
                                                                <tr id="trFax" class="mid_menu">
                                                                    <td valign="top" align="right" class="style40">
                                                                        <span>Fax </span>
                                                                    </td>
                                                                    <td valign="top" align="center">
                                                                         &nbsp;:&nbsp;
                                                                    </td>
                                                                    <td valign="top" align="left">
                                                                        <asp:Label ID="lblFax" runat="server"></asp:Label>                                                                        
                                                                    </td>
                                                                </tr>
                                                                <tr id="trWebSite" class="mid_menu">
                                                                    <td valign="top" align="right" class="style40">
                                                                        WebSite
                                                                    </td>
                                                                    <td valign="top" align="center">
                                                                         &nbsp;:&nbsp;
                                                                    </td>
                                                                    <td valign="top" align="left">
                                                                        <asp:Label ID="lblWebsite" runat="server"></asp:Label>                                                                       
                                                                    </td>
                                                                </tr>
                                                               <tr id="trHJobDetails" class="sub_menu">
                                                                    <td valign="top" colspan="1" align="right">
                                                                        <asp:Label ID="lblHJobDetails" runat="server" Text="Job Details :" ForeColor="Red"></asp:Label>
                                                                        
                                                                    </td><td colspan="2"></td>
                                                                </tr>
                                                                <tr id="trInd" class="mid_menu">
                                                                    <td valign="top" align="right" class="style40">
                                                                        Industry 
                                                                    </td>
                                                                    <td valign="top" align="center">
                                                                          &nbsp;:&nbsp;
                                                                    </td>
                                                                    <td valign="top" align="left">
                                                                        <asp:Label ID="lblInd" runat="server"></asp:Label>                                                                        
                                                                    </td>
                                                                </tr>
                                                                <tr id="trFunArea" class="mid_menu">
                                                                    <td valign="top" align="right" class="style40">
                                                                        Functional Area
                                                                    </td>
                                                                    <td valign="top" align="center">
                                                                         &nbsp;:&nbsp;
                                                                    </td>
                                                                    <td valign="top" align="left">
                                                                        <asp:Label ID="lblFunArea" runat="server"></asp:Label>                                                                        
                                                                    </td>
                                                                </tr>
                                                                <tr id="trRole" class="mid_menu">
                                                                    <td valign="top" align="right" class="style40">
                                                                        Role
                                                                    </td>
                                                                    <td valign="top" align="center">
                                                                          &nbsp;:&nbsp;
                                                                    </td>
                                                                    <td valign="top" align="left">
                                                                        <asp:Label ID="lblRole" runat="server"></asp:Label>                                                                       
                                                                    </td>
                                                                </tr>
                                                                <tr id="trQual" class="mid_menu">
                                                                    <td valign="top" align="right" class="style40">
                                                                        Qualification
                                                                    </td>
                                                                    <td valign="top" align="center">
                                                                         &nbsp;:&nbsp;
                                                                    </td>
                                                                    <td valign="top" align="left">
                                                                        <asp:Label ID="lblQual" runat="server"></asp:Label>                                                                       
                                                                    </td>
                                                                </tr>
                                                                <tr id="trAge" class="mid_menu">
                                                                    <td valign="top" align="right" class="style40">
                                                                        Age
                                                                    </td>
                                                                    <td valign="top" align="center">
                                                                         &nbsp;:&nbsp;
                                                                    </td>
                                                                    <td valign="top" align="left">
                                                                        <asp:Label ID="lblAge" runat="server"></asp:Label>                                                                       
                                                                    </td>
                                                                </tr>
                                                                <tr id="trSkills" class="mid_menu">
                                                                    <td valign="top" align="right" class="style40">
                                                                        Key Skills
                                                                    </td>
                                                                    <td valign="top" align="center">
                                                                         &nbsp;:&nbsp;
                                                                    </td>
                                                                    <td valign="top " align="left">
                                                                        <asp:Label ID="lblSkills" runat="server"></asp:Label>                                                                       
                                                                    </td>
                                                                </tr>
                                                                <tr id="trJobDesc" class="mid_menu">
                                                                    <td valign="top" align="right" class="style40">
                                                                        Job Description
                                                                    </td>
                                                                    <td valign="top" align="center">
                                                                         &nbsp;:&nbsp;
                                                                    </td>
                                                                    <td valign="top" align="left">
                                                                        <asp:Label ID="lblJobDesc" runat="server"></asp:Label>                                                                       
                                                                    </td>
                                                                </tr>
                                                                <tr id="trExp" class="mid_menu">
                                                                    <td valign="top" align="right" class="style40">
                                                                        Experience
                                                                    </td>
                                                                    <td valign="top" align="center">
                                                                         &nbsp;:&nbsp;
                                                                    </td>
                                                                    <td valign="top" align="left">
                                                                        <asp:Label ID="lblExp" runat="server"></asp:Label>                                                                       
                                                                    </td>
                                                                </tr>
                                                                <tr id="trSal" class="mid_menu">
                                                                    <td valign="top" align="right" class="style40">
                                                                        Salary
                                                                    </td>
                                                                    <td valign="top" align="center">
                                                                          &nbsp;:&nbsp;
                                                                    </td>
                                                                    <td valign="top" align="left">
                                                                        <asp:Label ID="lblSal" runat="server"></asp:Label>                                                                       
                                                                    </td>
                                                                </tr>
                                                                <tr id="trJobPost" class="mid_menu">
                                                                    <td valign="top" align="right" class="style40">
                                                                        Job Post Date
                                                                    </td>
                                                                    <td valign="top" align="center">
                                                                         &nbsp;:&nbsp;
                                                                    </td>
                                                                    <td valign="top" align="left">
                                                                        <asp:Label ID="lblJobPost" runat="server"></asp:Label>                                                                       
                                                                    </td>
                                                                </tr>
                                                                <tr id="trJobExpire" class="mid_menu">
                                                                    <td valign="top" align="right" class="style40">
                                                                        Job Expired on
                                                                    </td>
                                                                    <td valign="top" align="center">
                                                                         &nbsp;:&nbsp;
                                                                    </td>
                                                                    <td valign="top" align="left">
                                                                        <asp:Label ID="lblJobExpire" runat="server"></asp:Label>                                                                       
                                                                    </td>
                                                                </tr>
                                                             </table>
                                                            </td>
                                <%--<td class="lable">
                                    <table id="tblData" runat="server" border="0" cellpadding="0" cellspacing="2" width="100%" 
                                      style="background-color:#CEE3F6; border:double 1px #08088A;padding-bottom: 7px;">
                                        <tr>
                                            <td colspan="3" align="center" class="headings">
                                                <h1 style="font-size:15px;">
                                                   <asp:Label ID="lblComporEveName" runat="server"></asp:Label> 
                                                </h1>
                                            </td>
                                        </tr>
                                       
                                                    <tr>
                                                        <td colspan="3" class="mid_menu">
                                                             <asp:Label ID="lblMessage" runat="server"></asp:Label>
                                                        </td>
                                                    </tr>

                                                   
                                                                <tr id="trMod" class="mid_menu">
                                                                    <td valign="top" align="right" class="style40" width="45%">
                                                                    Module
                                                                    </td>
                                                                    <td valign="top" align="center" width="5%">
                                                                          &nbsp;:&nbsp;
                                                                    </td>
                                                                    <td valign="top" width="50%">
                                                                        <asp:Label ID="lblModule" runat="server" ></asp:Label>                                                                       
                                                                    </td>
                                                                </tr>
                                                                                                                         
                                                                <tr id="trCat" class="mid_menu">
                                                                    <td valign="top" align="right" class="style40">
                                                                        Category
                                                                    </td>
                                                                    <td valign="top" align="center">
                                                                         &nbsp;:&nbsp;
                                                                    </td>
                                                                    <td valign="top">
                                                                        <asp:Label ID="lblCat" runat="server" ></asp:Label>                                                                       
                                                                    </td>
                                                                </tr>
                                                                <tr id="trSubCat" class="mid_menu">
                                                                    <td valign="top" align="right" class="style40">
                                                                        Sub Category
                                                                    </td>
                                                                    <td valign="top" align="center">
                                                                        &nbsp;:&nbsp;
                                                                    </td>
                                                                    <td valign="top">
                                                                        <asp:Label ID="lblSubCat" runat="server" ></asp:Label>                                                                       
                                                                    </td>
                                                                </tr>
                                                                <tr id="trHEveDetails" class="sub_menu">
                                                                    <td valign="top" colspan="1" align="right">
                                                                        <asp:Label ID="lblHEveDetails" runat="server" Text="Event Details :" ForeColor="Red"></asp:Label>                                                                        
                                                                    </td>
                                                                    <td colspan="2">&nbsp;</td>
                                                                </tr>
                                                                <tr id="trEveName" class="mid_menu">
                                                                    <td valign="top" align="right" class="style40">
                                                                       Name of the event 
                                                                    </td>
                                                                    <td valign="top" align="center">
                                                                        &nbsp;:&nbsp;
                                                                    </td>
                                                                    <td valign="top">
                                                                        <asp:Label ID="lblEveName" runat="server"></asp:Label>                                                                       
                                                                    </td>
                                                                </tr>
                                                                <tr id="trEvePlace" class="mid_menu">
                                                                    <td valign="top" align="right" class="style40">
                                                                       Place of the Event 
                                                                    </td>
                                                                    <td valign="top" align="center">
                                                                       &nbsp;:&nbsp;
                                                                    </td>
                                                                    <td valign="top">
                                                                        <asp:Label ID="lblEvePlace" runat="server"></asp:Label>                                                                       
                                                                    </td>
                                                                </tr>
                                                                <tr id="trEveStartDate" class="mid_menu">
                                                                    <td valign="top" align="right" class="style40">
                                                                        Event Starts from Date
                                                                    </td>
                                                                    <td valign="top" align="center">
                                                                          &nbsp;:&nbsp;
                                                                    </td>
                                                                    <td valign="top">
                                                                        <asp:Label ID="lblEveStartDate" runat="server"></asp:Label>                                                                       
                                                                    </td>
                                                                </tr>
                                                                <tr id="treveEndsDate" class="mid_menu">
                                                                    <td valign="top" align="right" class="style40">
                                                                        Event Ends to Date
                                                                    </td>
                                                                    <td valign="top" align="center">
                                                                          &nbsp;:&nbsp;
                                                                    </td>
                                                                    <td valign="top">
                                                                        <asp:Label ID="lblEveEndDtae" runat="server"></asp:Label>                                                                       
                                                                    </td>
                                                                </tr>
                                                                <tr id="treveTime" class="mid_menu">
                                                                    <td valign="top" align="right" class="style40">
                                                                        Time of the Event
                                                                    </td>
                                                                    <td valign="top" align="center">
                                                                         &nbsp;:&nbsp;
                                                                    </td>
                                                                    <td valign="top">
                                                                        <asp:Label ID="lblEveTime" runat="server"></asp:Label>                                                                       
                                                                    </td>
                                                                </tr>
                                                                <tr id="treveDescription" class="mid_menu">
                                                                    <td valign="top" align="right" class="style40">
                                                                        Event Description
                                                                    </td>
                                                                    <td valign="top" align="center">
                                                                         &nbsp;:&nbsp;
                                                                    </td>
                                                                    <td valign="top">
                                                                        <asp:Label ID="lblEveDescription" runat="server"></asp:Label>                                                                       
                                                                    </td>
                                                                </tr>
                                                                                                               
                                                                <tr id="trHDisDetails" class="sub_menu">
                                                                    <td valign="top" colspan="1" align="right">
                                                                        <asp:Label ID="lblHDisDetails" runat="server" Text="Discount Details :" ForeColor="Red"></asp:Label>                                                                        
                                                                    </td>
                                                                    <td colspan="2">&nbsp;</td>
                                                                </tr>
                                                                <tr id="trdisStartDate" class="mid_menu">
                                                                    <td valign="top" align="right" class="style40">
                                                                        Discount Starts from Date
                                                                    </td>
                                                                    <td valign="top" align="center">
                                                                         &nbsp;:&nbsp;
                                                                    </td>
                                                                    <td valign="top">
                                                                        <asp:Label ID="lblDisStartDate" runat="server"></asp:Label>                                                                       
                                                                    </td>
                                                                </tr>
                                                                <tr id="trDisEndDate" class="mid_menu">
                                                                    <td valign="top" align="right" class="style40">
                                                                        Discount Ends to Date
                                                                    </td>
                                                                    <td valign="top" align="center">
                                                                         &nbsp;:&nbsp;
                                                                    </td>
                                                                    <td valign="top">
                                                                        <asp:Label ID="lblDisEndDate" runat="server"></asp:Label>                                                                       
                                                                    </td>
                                                                </tr>
                                                                <tr id="trDisTime" class="mid_menu">
                                                                    <td valign="top" align="right" class="style40">
                                                                        Time of the Discount exist
                                                                    </td>
                                                                    <td valign="top" align="center">
                                                                         &nbsp;:&nbsp;
                                                                    </td>
                                                                    <td valign="top">
                                                                        <asp:Label ID="lblDisTime" runat="server"></asp:Label>                                                                       
                                                                    </td>
                                                                </tr>
                                                                <tr id="trDisDetails" class="mid_menu">
                                                                    <td valign="top" align="right" class="style40">
                                                                        Discount Description 
                                                                    </td>
                                                                    <td valign="top" align="center">
                                                                         &nbsp;:&nbsp;
                                                                    </td>
                                                                    <td valign="top">
                                                                        <asp:Label ID="lblDisDetails" runat="server"></asp:Label>                                                                       
                                                                    </td>
                                                                </tr>                                            
                                                                <tr id="trHCompDetails" class="sub_menu">
                                                                    <td valign="top" colspan="1" align="right">
                                                                        <asp:Label ID="lblCompEveHeading1" runat="server" Text="Company Details :" ForeColor="Red"></asp:Label>
                                                                        
                                                                    </td>
                                                                    <td colspan="2">&nbsp;</td>
                                                                </tr>
                                                                <tr id="trCompName" class="mid_menu">
                                                                    <td valign="top" align="right" class="style40">
                                                                        <asp:Label ID="lblCompHeading" runat="server" Text="Name of the Company"></asp:Label> 
                                                                    </td>
                                                                    <td valign="top" align="center">
                                                                         &nbsp;:&nbsp;
                                                                    </td>
                                                                    <td valign="top">
                                                                        <asp:Label ID="lblCompanyName" runat="server" ></asp:Label>                                                                        
                                                                    </td>
                                                                </tr>
                                                                <tr id="trComprofile" class="mid_menu">
                                                                    <td valign="top" align="right" class="style40">
                                                                        <asp:Label ID="lblCompanyProfile" runat="server" Text="Company Profile"></asp:Label> 
                                                                    </td>
                                                                    <td valign="top" align="center">
                                                                         &nbsp;:&nbsp;
                                                                    </td>
                                                                    <td valign="top">
                                                                        <asp:Label ID="lblComprofile" runat="server" ></asp:Label>                                                                        
                                                                    </td>
                                                                </tr>  
                                                                                                             
                                                                <tr id="trAddress" class="mid_menu">
                                                                    <td valign="top" align="right" class="style40">
                                                                        Address
                                                                    </td>
                                                                    <td valign="top" align="center">
                                                                          &nbsp;:&nbsp;
                                                                    </td>
                                                                    <td valign="top">
                                                                        <table border="0" cellpadding="0" cellspacing="0" class="lable" width="199">
                                                                            <tr>
                                                                                <td valign="top">
                                                                                    <asp:Label ID="lblAddress" runat="server" ></asp:Label>                                                                                   
                                                                                    <br />
                                                                                </td>
                                                                            </tr>
                                                                            <tr>
                                                                                <td valign="top">
                                                                                    <asp:Label ID="lblArea" runat="server" ></asp:Label>                                                                                    
                                                                                    <br />
                                                                                </td>
                                                                            </tr>
                                                                            <tr>
                                                                                <td valign="top">
                                                                                    <asp:Label ID="lblCity" runat="server" ></asp:Label>                                                                                    
                                                                                    <br />
                                                                                </td>
                                                                            </tr>
                                                                            <tr>
                                                                                <td valign="top">
                                                                                    <asp:Label ID="lblState" runat="server" ></asp:Label>                                                                                   
                                                                                    <br />
                                                                                </td>
                                                                            </tr>
                                                                        </table>
                                                                    </td>
                                                                </tr>
                                                                <tr id="trLandMark" class="mid_menu">
                                                                    <td valign="top" align="right" class="style40">
                                                                        LandMark
                                                                    </td>
                                                                    <td valign="top" align="center">
                                                                          &nbsp;:&nbsp;
                                                                    </td>
                                                                    <td valign="top">
                                                                        <asp:Label ID="lblLandMark" runat="server" ></asp:Label>                                                                                   
                                                                        <br />
                                                                    </td>
                                                                </tr>
                                                                <tr id="trPincode" class="mid_menu">
                                                                    <td valign="top" align="right" class="style40">
                                                                       PinCode
                                                                    </td>
                                                                    <td valign="top" align="center">
                                                                         &nbsp;:&nbsp;
                                                                    </td>
                                                                    <td valign="top">
                                                                        <asp:Label ID="lblPinCode" runat="server"></asp:Label>                                                                       
                                                                    </td>
                                                                </tr>
                                                                <tr id="trContPer" class="mid_menu">
                                                                    <td valign="top" align="right" class="style40">
                                                                        Contact Person
                                                                    </td>
                                                                    <td valign="top" align="center">
                                                                         &nbsp;:&nbsp;
                                                                    </td>
                                                                    <td valign="top">
                                                                        <asp:Label ID="lblContPer" runat="server"></asp:Label>                                                                       
                                                                    </td>
                                                                </tr>
                                                                 <tr id="trEmail" class="mid_menu">
                                                                    <td valign="top" align="right" class="style40">
                                                                        Email
                                                                    </td>
                                                                    <td valign="top" align="center">
                                                                         &nbsp;:&nbsp;
                                                                    </td>
                                                                    <td valign="top">
                                                                        <asp:Label ID="lblEmail" runat="server"></asp:Label>                                                                        
                                                                    </td>
                                                                </tr>                                                                
                                                                <tr id="trMobile" class="mid_menu">
                                                                    <td valign="top" align="right" class="style40">
                                                                        Mobile 
                                                                    </td>
                                                                    <td valign="top" align="center">
                                                                         &nbsp;:&nbsp;
                                                                    </td>
                                                                    <td valign="top" >
                                                                        <asp:Label ID="lblMobile" runat="server"></asp:Label>                                                                        
                                                                    </td>
                                                                </tr>
                                                                <tr id="trPhone" class="mid_menu">
                                                                    <td valign="top" align="right" class="style40">
                                                                        <span>Phone </span>
                                                                    </td>
                                                                    <td valign="top" align="center">
                                                                         &nbsp;:&nbsp;
                                                                    </td>
                                                                    <td valign="top">
                                                                        <asp:Label ID="lblPhone" runat="server"></asp:Label>                                                                        
                                                                    </td>
                                                                </tr>
                                                                <tr id="trFax" class="mid_menu">
                                                                    <td valign="top" align="right" class="style40">
                                                                        <span>Fax </span>
                                                                    </td>
                                                                    <td valign="top" align="center">
                                                                         &nbsp;:&nbsp;
                                                                    </td>
                                                                    <td valign="top">
                                                                        <asp:Label ID="lblFax" runat="server"></asp:Label>                                                                        
                                                                    </td>
                                                                </tr>
                                                                <tr id="trWebSite" class="mid_menu">
                                                                    <td valign="top" align="right" class="style40">
                                                                        WebSite
                                                                    </td>
                                                                    <td valign="top" align="center">
                                                                         &nbsp;:&nbsp;
                                                                    </td>
                                                                    <td valign="top" align="left">
                                                                        <asp:Label ID="lblWebsite" runat="server"></asp:Label>                                                                       
                                                                    </td>
                                                                </tr>
                                                               <tr id="trHJobDetails" class="sub_menu">
                                                                    <td valign="top" colspan="1" align="right">
                                                                        <asp:Label ID="lblHJobDetails" runat="server" Text="Job Details :" ForeColor="Red"></asp:Label>
                                                                        
                                                                    </td><td colspan="2"></td>
                                                                </tr>
                                                                <tr id="trInd" class="mid_menu">
                                                                    <td valign="top" align="right" class="style40">
                                                                        Industry 
                                                                    </td>
                                                                    <td valign="top" align="center">
                                                                          &nbsp;:&nbsp;
                                                                    </td>
                                                                    <td valign="top">
                                                                        <asp:Label ID="lblInd" runat="server"></asp:Label>                                                                        
                                                                    </td>
                                                                </tr>
                                                                <tr id="trFunArea" class="mid_menu">
                                                                    <td valign="top" align="right" class="style40">
                                                                        Functional Area
                                                                    </td>
                                                                    <td valign="top" align="center">
                                                                         &nbsp;:&nbsp;
                                                                    </td>
                                                                    <td valign="top">
                                                                        <asp:Label ID="lblFunArea" runat="server"></asp:Label>                                                                        
                                                                    </td>
                                                                </tr>
                                                                <tr id="trRole" class="mid_menu">
                                                                    <td valign="top" align="right" class="style40">
                                                                        Role
                                                                    </td>
                                                                    <td valign="top" align="center">
                                                                          &nbsp;:&nbsp;
                                                                    </td>
                                                                    <td valign="top">
                                                                        <asp:Label ID="lblRole" runat="server"></asp:Label>                                                                       
                                                                    </td>
                                                                </tr>
                                                                <tr id="trQual" class="mid_menu">
                                                                    <td valign="top" align="right" class="style40">
                                                                        Qualification
                                                                    </td>
                                                                    <td valign="top" align="center">
                                                                         &nbsp;:&nbsp;
                                                                    </td>
                                                                    <td valign="top" align="left">
                                                                        <asp:Label ID="lblQual" runat="server"></asp:Label>                                                                       
                                                                    </td>
                                                                </tr>
                                                                <tr id="trAge" class="mid_menu">
                                                                    <td valign="top" align="right" class="style40">
                                                                        Age
                                                                    </td>
                                                                    <td valign="top" align="center">
                                                                         &nbsp;:&nbsp;
                                                                    </td>
                                                                    <td valign="top" align="left">
                                                                        <asp:Label ID="lblAge" runat="server"></asp:Label>                                                                       
                                                                    </td>
                                                                </tr>
                                                                <tr id="trSkills" class="mid_menu">
                                                                    <td valign="top" align="right" class="style40">
                                                                        Key Skills
                                                                    </td>
                                                                    <td valign="top" align="center">
                                                                         &nbsp;:&nbsp;
                                                                    </td>
                                                                    <td valign="top">
                                                                        <asp:Label ID="lblSkills" runat="server"></asp:Label>                                                                       
                                                                    </td>
                                                                </tr>
                                                                <tr id="trJobDesc" class="mid_menu">
                                                                    <td valign="top" align="right" class="style40">
                                                                        Job Description
                                                                    </td>
                                                                    <td valign="top" align="center">
                                                                         &nbsp;:&nbsp;
                                                                    </td>
                                                                    <td valign="top">
                                                                        <asp:Label ID="lblJobDesc" runat="server"></asp:Label>                                                                       
                                                                    </td>
                                                                </tr>
                                                                <tr id="trExp" class="mid_menu">
                                                                    <td valign="top" align="right" class="style40">
                                                                        Experience
                                                                    </td>
                                                                    <td valign="top" align="center">
                                                                         &nbsp;:&nbsp;
                                                                    </td>
                                                                    <td valign="top">
                                                                        <asp:Label ID="lblExp" runat="server"></asp:Label>                                                                       
                                                                    </td>
                                                                </tr>
                                                                <tr id="trSal" class="mid_menu">
                                                                    <td valign="top" align="right" class="style40">
                                                                        Salary
                                                                    </td>
                                                                    <td valign="top" align="center">
                                                                          &nbsp;:&nbsp;
                                                                    </td>
                                                                    <td valign="top">
                                                                        <asp:Label ID="lblSal" runat="server"></asp:Label>                                                                       
                                                                    </td>
                                                                </tr>
                                                                <tr id="trJobPost" class="mid_menu">
                                                                    <td valign="top" align="right" class="style40">
                                                                        Job Post Date
                                                                    </td>
                                                                    <td valign="top" align="center">
                                                                         &nbsp;:&nbsp;
                                                                    </td>
                                                                    <td valign="top">
                                                                        <asp:Label ID="lblJobPost" runat="server"></asp:Label>                                                                       
                                                                    </td>
                                                                </tr>
                                                                <tr id="trJobExpire" class="mid_menu" >
                                                                    <td valign="top" align="right" class="style40">
                                                                        Job Expired on
                                                                    </td>
                                                                    <td valign="top" align="center">
                                                                         &nbsp;:&nbsp;
                                                                    </td>
                                                                    <td valign="top">
                                                                        <asp:Label ID="lblJobExpire" runat="server"></asp:Label>                                                                       
                                                                    </td>
                                                                </tr>
                                                               
                                                             </table>
                                                            </td>--%>
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
                                     
                                   </table>
                                </div>
   </center>
    </form>
    </body>
                            
</html>
