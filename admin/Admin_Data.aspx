﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Admin_Data.aspx.cs" Inherits="admin_Admin_Data" %>
<%@ Register Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" TagPrefix="cc3"  %>
<%@ Register Src="~/admin/user_control/Admin_Headermenu.ascx" TagName="Headermenu" TagPrefix="cc1" %>
<%@ Register Src="~/admin/user_control/Admin_LeftMenu.ascx" TagName="smenu" TagPrefix="cc4"%>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <title>Just callus ---- Admin Control Panel</title>
    <link href="includes/style.css" rel="Stylesheet" type="text/css" />
    <script src="js/statesopt.js"></script>
    <style type="text/css">
        .style37
        {
            width: 664px;
        }
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
            height: 8px;
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
 <body>
   <form id="form1" runat="server">
    <div>
       <table cellpadding="0" cellspacing="0">
         <tr>
            <td>
             <cc1:headermenu ID="header" runat="server" />
            </td>
         </tr>
         <tr>
           <td>   
               
                    <table cellpadding="0" cellspacing="0">
              <tr>
                <td class="style39">                        
                   <cc4:smenu ID="sidemenu" runat="server" />
                </td>
                <td valign="top">&nbsp;</td>
                <td valign="top" style="padding:10px; padding-left:50px" class="style37">  
                <table>
                  <tr>
                    <td>
                        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                            <ContentTemplate>        
                                 <table border="0" cellspacing="5" style="height: 564px; width: 574px; margin-left: 0px">
                                    <tr>
                       <td align="left" colspan="3">
                        To Post the Data
                       </td>
                     </tr>
                     <tr>
                       <td align="right" colspan="5">
                                <asp:ScriptManager ID="ScriptManager1" runat="server" 
                                    EnablePageMethods = "true">
                                </asp:ScriptManager>
                                <asp:ImageButton ID="imgsite" runat="server" OnClientClick="justcalluz:poponload();" ImageUrl="images/Click Here For SiteView.png"/>
                                   
           
                       </td>
                     </tr>
                     <tr><td>
                     <asp:Label ID="lblMessage" runat="server"></asp:Label>     
                     </td></tr>
                      <tr>
                      <td class="adminform">Module</td>
                      <td align="center"> &nbsp;&nbsp;:&nbsp;&nbsp;</td>
                      <td>                               
                          <asp:DropDownList ID="ddlModule" runat="server" Width="186px" 
                              onselectedindexchanged="ddlModule_SelectedIndexChanged" AutoPostBack="true">
                          </asp:DropDownList>
                          
                          <asp:RequiredFieldValidator ID="rfvModule" runat="server" 
                              ControlToValidate="ddlModule" ErrorMessage="Please select Module" 
                              InitialValue="Select Module" ValidationGroup="PostData">*</asp:RequiredFieldValidator>
                           <cc3:ValidatorCalloutExtender ID="valcaloutextn" runat="server" Enabled="true" TargetControlID="rfvModule">
                                          </cc3:ValidatorCalloutExtender>
                      </td>
                      </tr>
                      
                      <tr>
                      <td class="adminform">Category</td>
                      <td align="center"> &nbsp;&nbsp;:&nbsp;&nbsp;</td>
                      <td>                               
                          <asp:DropDownList ID="ddlCategory" runat="server" Width="186px" 
                              onselectedindexchanged="ddlCategory_SelectedIndexChanged" AutoPostBack="true">
                          </asp:DropDownList>
                          
                          <asp:RequiredFieldValidator ID="rfvCat" runat="server" 
                              ControlToValidate="ddlCategory" ErrorMessage="Please select Category" 
                              InitialValue="Select Category" ValidationGroup="PostData">*</asp:RequiredFieldValidator>
                           <cc3:ValidatorCalloutExtender ID="ValidatorCalloutExtender1" runat="server" Enabled="true" TargetControlID="rfvCat">
                                          </cc3:ValidatorCalloutExtender>
                      </td>
                      </tr>
                      
                      <tr>
                      <td class="adminform">Sub Category</td>
                      <td align="center"> &nbsp;&nbsp;:&nbsp;&nbsp;</td>
                      <td>                               
                          <asp:DropDownList ID="ddlSubCat" runat="server" Width="186px" 
                              onselectedindexchanged="ddlSubCat_SelectedIndexChanged" AutoPostBack="true">
                          </asp:DropDownList>
                          
                          <asp:RequiredFieldValidator ID="rfvsubcat" runat="server" 
                              ControlToValidate="ddlSubCat" ErrorMessage="Please select Sub Category" 
                              InitialValue="Select Sub Category" ValidationGroup="PostData">*</asp:RequiredFieldValidator>
                           <cc3:ValidatorCalloutExtender ID="ValidatorCalloutExtender2" runat="server" Enabled="true" TargetControlID="rfvsubcat">
                                          </cc3:ValidatorCalloutExtender>
                      </td>
                      </tr>  
                                          
                      <%--<asp:Panel ID="pnlOthers" runat="server">    --%> 
                                                  
                      <tr id="trOtherSubCat" runat="server">
                      <td class="adminform"></td>
                      <td align="center"> &nbsp;&nbsp;&nbsp;&nbsp;</td>
                      <td>                               
                          <asp:TextBox ID="txtOthers" runat="server" Width="186px"></asp:TextBox>
                          
                          <asp:RequiredFieldValidator ID="rfvOthers" runat="server" 
                              ControlToValidate="txtOthers" ErrorMessage="Please enter Others Subcategoty " 
                            ValidationGroup="PostData">*</asp:RequiredFieldValidator>
                           <cc3:ValidatorCalloutExtender ID="ValidatorCalloutExtender3" runat="server" Enabled="true" TargetControlID="rfvOthers">
                                          </cc3:ValidatorCalloutExtender>
                      </td>
                      </tr>
                     
                       <%--</asp:Panel>--%>
                       
                      <tr>
                      <td class="adminform">State</td>
                      <td align="center"> &nbsp;&nbsp;:&nbsp;&nbsp;</td>
                      <td>                               
                          <asp:DropDownList ID="ddlState" runat="server" Width="186px" 
                              onselectedindexchanged="ddlState_SelectedIndexChanged" AutoPostBack="true">
                          </asp:DropDownList>
                          
                          <asp:RequiredFieldValidator ID="rfvState" runat="server" 
                              ControlToValidate="ddlState" ErrorMessage="Please select State" 
                              InitialValue="Select State" ValidationGroup="PostData">*</asp:RequiredFieldValidator>
                           <cc3:ValidatorCalloutExtender ID="ValidatorCalloutExtender4" runat="server" Enabled="true" TargetControlID="rfvState">
                                          </cc3:ValidatorCalloutExtender>
                      </td>
                      </tr>
                      
                      <tr>
                      <td class="adminform">City</td>
                      <td align="center"> &nbsp;&nbsp;:&nbsp;&nbsp;</td>
                      <td>                               
                          <asp:DropDownList ID="ddlCity" runat="server" Width="186px">
                          </asp:DropDownList>
                          
                          <asp:RequiredFieldValidator ID="rfvCity" runat="server" 
                              ControlToValidate="ddlCity" ErrorMessage="Please select City" 
                              InitialValue="Select City" ValidationGroup="PostData">*</asp:RequiredFieldValidator>
                           <cc3:ValidatorCalloutExtender ID="ValidatorCalloutExtender5" runat="server" Enabled="true" TargetControlID="rfvCity">
                                          </cc3:ValidatorCalloutExtender>
                      </td>
                      </tr>
                      
                     <tr id="trJobCat" runat="server">
            
                          <td class="adminform" style="width:145px">Company Name</td>
                          <td align="center" style="width:49px"> &nbsp;&nbsp;:&nbsp;&nbsp;</td>
                          <td>                               
                          <asp:TextBox ID="txtCompanyname" runat="server" Width="186px"></asp:TextBox>                      
                          
                         <asp:RequiredFieldValidator ID="rfvCompanyName" runat="server" 
                                  ErrorMessage="Please enter Company Name" ControlToValidate="txtCompanyname" 
                                  ValidationGroup="PostData">*</asp:RequiredFieldValidator>
                              <cc3:ValidatorCalloutExtender ID="ValidatorCalloutExtender6" runat="server" Enabled="true" TargetControlID="rfvCompanyName">
                              </cc3:ValidatorCalloutExtender>
                          </td>                                   
                      </tr>
                       
                       
                      <tr id="trJobs" runat="server">
                      <td class="adminform" colspan="3">                          
                          <table width="100%" border="0">
                            <tr>
                              <td class="adminform" style="width:146px">Industry</td>
                              <td align="center" style="width:52px;"> &nbsp;&nbsp;:&nbsp;&nbsp;</td>
                              <td>
                                  <asp:TextBox ID="txtJInd" runat="server" Width="186px"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvInd" runat="server" 
                                      ErrorMessage="Please enter Industry" ControlToValidate="txtJInd" 
                                      ValidationGroup="PostData">*</asp:RequiredFieldValidator>
                                    <cc3:ValidatorCalloutExtender ID="ValidatorCalloutExtender7" runat="server" Enabled="true" TargetControlID="rfvInd">
                                    </cc3:ValidatorCalloutExtender>
                              </td>
                             </tr>
                             <tr>
                              <td class="adminform">Functional Area</td>
                              <td align="center">:</td>
                              <td>
                                  <asp:TextBox ID="txtJfunarea" runat="server" Width="186px"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvFunArea" runat="server" 
                                      ErrorMessage="Please enter Functional Area" ControlToValidate="txtJfunarea" 
                                      ValidationGroup="PostData">*</asp:RequiredFieldValidator>
                                    <cc3:ValidatorCalloutExtender ID="ValidatorCalloutExtender8" runat="server" Enabled="true" TargetControlID="rfvFunArea">
                                          </cc3:ValidatorCalloutExtender>
                              </td>
                             </tr>
                             <tr>
                              <td class="adminform">Role</td>
                              <td align="center">:</td>
                              <td>
                                  <asp:TextBox ID="txtJRole" runat="server" Width="186px"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvRole" runat="server" 
                                      ErrorMessage="Please enter Role" ControlToValidate="txtJRole" 
                                      ValidationGroup="PostData">*</asp:RequiredFieldValidator>
                                    <cc3:ValidatorCalloutExtender ID="ValidatorCalloutExtender9" runat="server" Enabled="true" TargetControlID="rfvRole">
                                          </cc3:ValidatorCalloutExtender>
                              </td>
                             </tr>                             
                             <tr>
                              <td class="adminform">Qualification</td>
                              <td align="center">:</td>
                              <td>
                                  <asp:TextBox ID="txtJQual" runat="server" Width="186px"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvQual" runat="server" 
                                      ErrorMessage="Please enter Qualification" ControlToValidate="txtJQual" 
                                      ValidationGroup="PostData">*</asp:RequiredFieldValidator>
                                    <cc3:ValidatorCalloutExtender ID="ValidatorCalloutExtender10" runat="server" Enabled="true" TargetControlID="rfvQual">
                                          </cc3:ValidatorCalloutExtender>
                              </td>
                             </tr>
                             <tr>
                              <td class="adminform">Experience</td>
                              <td align="center">:</td>
                              <td>
                                  <asp:DropDownList ID="ddlExp" runat="server" Width="186px" 
                                      onselectedindexchanged="ddlExp_SelectedIndexChanged" AutoPostBack="true">
                                    <asp:ListItem Value="Select One">Select One</asp:ListItem>
                                    <asp:ListItem Value="Fresher">Fresher</asp:ListItem>
                                    <asp:ListItem Value="Experience">Experience</asp:ListItem>
                                  </asp:DropDownList>
                      
                                  <asp:RequiredFieldValidator ID="rfvddlexp" runat="server" 
                                      ErrorMessage="Please Select One" ControlToValidate="ddlExp" 
                                      InitialValue="Select One" ValidationGroup="PostJob">*</asp:RequiredFieldValidator>                                         
                                  <cc3:ValidatorCalloutExtender ID="ValidatorCalloutExtender11" runat="server" Enabled="true" TargetControlID="rfvddlexp">
                                          </cc3:ValidatorCalloutExtender>
                            </td>
                            </tr>
                             <%-- <asp:Panel ID="pnlExpOther" runat="server">--%>
                              
                            <tr id="trExpOther" runat="server">
                              <td class="adminform"></td>
                              <td align="center"></td>
                              <td>
                                  <asp:TextBox ID="txtJExp" runat="server" Width="186px"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvExp" runat="server" 
                                      ErrorMessage="Please enter Experience" ControlToValidate="txtJExp" 
                                      ValidationGroup="PostData">*</asp:RequiredFieldValidator>
                                   <cc3:ValidatorCalloutExtender ID="ValidatorCalloutExtender12" runat="server" Enabled="true" TargetControlID="rfvExp">
                                          </cc3:ValidatorCalloutExtender>
                              </td>
                             </tr>
                             <%--</asp:Panel>--%>
                             <tr>
                              <td class="adminform">Salary</td>
                              <td align="center">:</td>
                              <td>
                                  <asp:TextBox ID="txtJSal" runat="server" Width="186px"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvSal" runat="server" 
                                      ErrorMessage="Please enter Salary" ControlToValidate="txtJSal" 
                                      ValidationGroup="PostData">*</asp:RequiredFieldValidator>
                                   <cc3:ValidatorCalloutExtender ID="ValidatorCalloutExtender13" runat="server" Enabled="true" TargetControlID="rfvSal">
                                          </cc3:ValidatorCalloutExtender>
                              </td>
                             </tr>
                              <tr>
                              <td class="adminform">Job Description</td>
                              <td align="center">:</td>
                              <td>
                                  <asp:TextBox ID="txtJobDesc" runat="server" Width="186px"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvJobDesc" runat="server" 
                                      ErrorMessage="Please enter Job Description" ControlToValidate="txtJobDesc" 
                                      ValidationGroup="PostData">*</asp:RequiredFieldValidator>
                                   <cc3:ValidatorCalloutExtender ID="ValidatorCalloutExtender14" runat="server" Enabled="true" TargetControlID="rfvJobDesc">
                                          </cc3:ValidatorCalloutExtender>
                              </td>
                             </tr>
                              <tr>
                              <td class="adminform">Key Skills</td>
                              <td align="center">:</td>
                              <td>
                                  <asp:TextBox ID="txtJkeyskills" runat="server" Width="186px"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvKeyskills" runat="server" 
                                      ErrorMessage="Please enter key skills" ControlToValidate="txtJkeyskills" 
                                      ValidationGroup="PostData">*</asp:RequiredFieldValidator>
                                     <cc3:ValidatorCalloutExtender ID="ValidatorCalloutExtender15" runat="server" Enabled="true" TargetControlID="rfvKeyskills">
                                          </cc3:ValidatorCalloutExtender>
                              </td>
                             </tr>
                          </table> <%-- </asp:Panel>--%>
                      </td>
                      
                      </tr>
                      
                      <tr id="trCatandJobs" runat="server">
                         
                          <td class="adminform" >Company Profile</td>
                          <td align="center"> &nbsp;&nbsp;:&nbsp;&nbsp;</td>
                          <td>                               
                          <asp:TextBox ID="txtCompanyProfile" runat="server" Width="186px"></asp:TextBox>                      
                          
                             <asp:RequiredFieldValidator ID="rfvCompProfile" runat="server" 
                                  ErrorMessage="Please enter Company Profile" 
                                  ControlToValidate="txtCompanyProfile" ValidationGroup="PostData">*</asp:RequiredFieldValidator>
                               <cc3:ValidatorCalloutExtender ID="ValidatorCalloutExtender16" runat="server" Enabled="true" TargetControlID="rfvCompProfile">
                                          </cc3:ValidatorCalloutExtender>
                          </td>
                                  
                      </tr>
                      
                      <tr id="trEvents" runat="server">
                          <td class="adminform" colspan="3">
                              <%--<asp:Panel ID="pnlEvents" runat="server">--%>
                                <table width="100%">
                                    <tr>
                                      <td class="adminform"  style="width:146px">Event Name</td>
                                      <td align="center"  style="width:52px"> &nbsp;&nbsp;:&nbsp;&nbsp;</td>
                                      <td>                               
                                      <asp:TextBox ID="txtEveName" runat="server" Width="186px"></asp:TextBox>                      
                                      
                                         <asp:RequiredFieldValidator ID="rfvEveName" runat="server" 
                                              ErrorMessage="Please enter Name of the Event" ControlToValidate="txtEveName" 
                                              ValidationGroup="PostData">*</asp:RequiredFieldValidator>
                                         <cc3:ValidatorCalloutExtender ID="ValidatorCalloutExtender17" runat="server" Enabled="true" TargetControlID="rfvEveName">
                                          </cc3:ValidatorCalloutExtender>
                                      </td>
                                    </tr>
                                    <tr>
                                      <td class="adminform">Place of Event</td>
                                      <td align="center"> &nbsp;&nbsp;:&nbsp;&nbsp;</td>
                                      <td>                               
                                      <asp:TextBox ID="txtEvePlace" runat="server" Width="186px"></asp:TextBox>                      
                                      
                                         <asp:RequiredFieldValidator ID="rfvEvePlace" runat="server" 
                                              ErrorMessage="Please enter place of an Event" ControlToValidate="txtEvePlace" 
                                              ValidationGroup="PostData">*</asp:RequiredFieldValidator>
                                         <cc3:ValidatorCalloutExtender ID="ValidatorCalloutExtender18" runat="server" Enabled="true" TargetControlID="rfvEvePlace">
                                          </cc3:ValidatorCalloutExtender>
                                      </td>
                                    </tr>
                                      
                                </table><%--</asp:Panel>--%>
                          </td>
                      </tr>
                      
                       <tr id="trEventsDiscounts" runat="server">
                          <td class="adminform" colspan="3">
                              <%--<asp:Panel ID="pnlEventsDiscounts" runat="server">--%>
                                <table width="100%">                                   
                                     <tr>
                                      <td class="adminform" style="width:146px">Start Date</td>
                                      <td align="center" style="width:52px"> &nbsp;&nbsp;:&nbsp;&nbsp;</td>
                                      <td>                               
                                      <asp:TextBox ID="txtEveDiStartDate" runat="server" Width="186px"></asp:TextBox>                                                            
                                         <asp:RequiredFieldValidator ID="rfvStartDate" runat="server" 
                                              ErrorMessage="Please Enter Start Date" ControlToValidate="txtEveDiStartDate" 
                                              ValidationGroup="PostData">*</asp:RequiredFieldValidator>
                                          <cc3:ValidatorCalloutExtender ID="ValidatorCalloutExtender19" runat="server" Enabled="true" TargetControlID="rfvStartDate">
                                          </cc3:ValidatorCalloutExtender>
                                          <cc3:CalendarExtender ID="calextStartDate" runat="server" TargetControlID="txtEveDiStartDate" OnClientShowing="CurrentDateShowing">
                                          </cc3:CalendarExtender>
                                          
                                          <asp:RangeValidator ID="rangevalStartDate" runat="server" 
                                               Type="Date" 
                                              ControlToValidate="txtEveDiStartDate" ValidationGroup="PostData">*</asp:RangeValidator>
                                              <cc3:ValidatorCalloutExtender ID="valcalextnStartDate" runat="server" Enabled="true" TargetControlID="rangevalStartDate">
                                          </cc3:ValidatorCalloutExtender>
                                      </td>
                                    </tr>
                                    <tr>
                                      <td class="adminform">End Date</td>
                                      <td align="center"> &nbsp;&nbsp;:&nbsp;&nbsp;</td>
                                      <td>                               
                                      <asp:TextBox ID="txtEveDiEndDate" runat="server" Width="186px"></asp:TextBox>                      
                                      
                                         <asp:RequiredFieldValidator ID="rfvEndDate" runat="server" 
                                              ErrorMessage="Please enter End Date" ControlToValidate="txtEveDiEndDate" 
                                              ValidationGroup="PostData">*</asp:RequiredFieldValidator>
                                          <cc3:ValidatorCalloutExtender ID="ValidatorCalloutExtender20" runat="server" Enabled="true" TargetControlID="rfvEndDate">
                                          </cc3:ValidatorCalloutExtender>
                                          <cc3:CalendarExtender ID="calextEndDate" runat="server" TargetControlID="txtEveDiEndDate" OnClientShowing="CurrentDateShowing">
                                          </cc3:CalendarExtender>  
                                            <asp:RangeValidator ID="rangevalEndDate" runat="server" 
                                              ErrorMessage="Please select after todays date" Type="Date" 
                                              ControlToValidate="txtEveDiEndDate" ValidationGroup="PostData">*</asp:RangeValidator>
                                               <cc3:ValidatorCalloutExtender ID="valcalextnEndDate" runat="server" Enabled="true" TargetControlID="rangevalEndDate">
                                          </cc3:ValidatorCalloutExtender>
                                      </td>
                                    </tr>
                                    <tr>
                                      <td class="adminform">Description</td>
                                      <td align="center"> &nbsp;&nbsp;:&nbsp;&nbsp;</td>
                                      <td>                               
                                      <asp:TextBox ID="txtEveDiDesc" runat="server" Width="186px"></asp:TextBox>                      
                                      
                                         <asp:RequiredFieldValidator ID="rfvEveDesc" runat="server" 
                                              ErrorMessage="Please enter Description" ControlToValidate="txtEveDiDesc" 
                                              ValidationGroup="PostData">*</asp:RequiredFieldValidator>
                                               <cc3:ValidatorCalloutExtender ID="ValidatorCalloutExtender21" runat="server" Enabled="true" TargetControlID="rfvEveDesc">
                                          </cc3:ValidatorCalloutExtender>
                                      </td>
                                    </tr>
                                    <tr>
                                      <td class="adminform">Time of Event</td>
                                      <td align="center"> &nbsp;&nbsp;:&nbsp;&nbsp;</td>
                                      <td>                               
                                      <asp:TextBox ID="txtEveDiTime" runat="server" Width="186px"></asp:TextBox>                      
                                      
                                         <asp:RequiredFieldValidator ID="rfvEveTime" runat="server" 
                                              ErrorMessage="Please enter Time Duration" ControlToValidate="txtEveDiTime" 
                                              ValidationGroup="PostData">*</asp:RequiredFieldValidator>
                                               <cc3:ValidatorCalloutExtender ID="ValidatorCalloutExtender22" runat="server" Enabled="true" TargetControlID="rfvEveTime">
                                          </cc3:ValidatorCalloutExtender>
                                      </td>
                                    </tr>                                        
                                </table>
                                <%--</asp:Panel>--%>
                          </td>
                      </tr>
                      <tr>
                      <td class="adminform">Address</td>
                      <td align="center">:</td>
                      <td>
                      <asp:TextBox ID="txtaddr" runat="server" Width="186px" TextMode="MultiLine"></asp:TextBox>
                      <asp:RequiredFieldValidator ID="rfvAddr" runat="server" 
                              ErrorMessage="Please enter address" ControlToValidate="txtaddr" 
                              ValidationGroup="PostData">*</asp:RequiredFieldValidator>
                               <cc3:ValidatorCalloutExtender ID="ValidatorCalloutExtender23" runat="server" Enabled="true" TargetControlID="rfvAddr">
                                          </cc3:ValidatorCalloutExtender>
                      </td>
                      </tr>
                      
                      <tr>
                      <td class="adminform">Land Mark</td>
                      <td align="center">:</td>
                      <td>
                      <asp:TextBox ID="txtLandMark" runat="server" Width="186px" TextMode="MultiLine"></asp:TextBox>
                      <asp:RequiredFieldValidator ID="rfvLandMark" runat="server" 
                              ErrorMessage="Please enter Land mark" ControlToValidate="txtLandMark" 
                              ValidationGroup="PostData">*</asp:RequiredFieldValidator>
                               <cc3:ValidatorCalloutExtender ID="ValidatorCalloutExtender24" runat="server" Enabled="true" TargetControlID="rfvLandMark">
                                          </cc3:ValidatorCalloutExtender>
                      </td>
                      </tr>
                      
                      <tr>
                      <td class="adminform">Contact Person</td>
                      <td align="center">:</td>
                      <td>
                      <asp:TextBox ID="txtContPerson" runat="server" Width="186px" ></asp:TextBox>
                      <asp:RequiredFieldValidator ID="rfvContPerson" runat="server" 
                              ErrorMessage="Please enter Name of the Contact Person" 
                              ControlToValidate="txtContPerson" ValidationGroup="PostData">*</asp:RequiredFieldValidator>
                               <cc3:ValidatorCalloutExtender ID="ValidatorCalloutExtender25" runat="server" Enabled="true" TargetControlID="rfvContPerson">
                                          </cc3:ValidatorCalloutExtender>
                      </td>
                      </tr>
                     
                     
                     <tr>
                      <td class="adminform">Email</td>
                      <td align="center">:</td>
                      <td>
                      <asp:TextBox ID="txtemail" runat="server" Width="186px" ></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvEmail" runat="server" 
                              ErrorMessage="Please enter Email Id" ControlToValidate="txtemail" 
                              ValidationGroup="PostData">*</asp:RequiredFieldValidator>
                               <cc3:ValidatorCalloutExtender ID="ValidatorCalloutExtender26" runat="server" Enabled="true" TargetControlID="rfvEmail">
                                          </cc3:ValidatorCalloutExtender>
                          <asp:RegularExpressionValidator ID="revEmail" runat="server" 
                              ControlToValidate="txtemail" 
                              ErrorMessage="Please enter Valid Email Id. Eg: XXXXX@xxx.xx" 
                              ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
                              ValidationGroup="PostData">*</asp:RegularExpressionValidator>
                               <cc3:ValidatorCalloutExtender ID="ValidatorCalloutExtender27" runat="server" Enabled="true" TargetControlID="revEmail">
                                          </cc3:ValidatorCalloutExtender>
                      </td>
                      </tr>
                      <tr>
                      <td class="adminform">Phone</td>
                      <td align="center">:</td>
                      <td>
                      <asp:TextBox ID="txtph" runat="server" Width="186px" onkeypress="javascript:fnNumbersOnly();" MaxLength="11"></asp:TextBox>
                      <asp:RangeValidator ID="rangevalPh" runat="server" 
                            ErrorMessage="Phone number should start with zero" MinimumValue="0" ControlToValidate="txtph" 
                            MaximumValue="1" ValidationGroup="PostData">*</asp:RangeValidator>
                             <cc3:ValidatorCalloutExtender ID="ValidatorCalloutExtender28" runat="server" Enabled="true" TargetControlID="rangevalPh">
                                          </cc3:ValidatorCalloutExtender>
                          <asp:RegularExpressionValidator ID="revph" runat="server" 
                              ErrorMessage="The number shoud be 11 digits" ControlToValidate="txtph" 
                              ValidationExpression="\d{11}" ValidationGroup="PostData">*</asp:RegularExpressionValidator>
                               <cc3:ValidatorCalloutExtender ID="ValidatorCalloutExtender29" runat="server" Enabled="true" TargetControlID="revph">
                                          </cc3:ValidatorCalloutExtender>
                      </td>
                      </tr>
                      
                       <tr>
                      <td class="adminform">Mobile</td>
                      <td align="center">:</td>
                      <td>
                      <asp:TextBox ID="txtmobile" runat="server" Width="186px" onkeypress="javascript:fnNumbersOnly();" MaxLength="11"></asp:TextBox>
                     <asp:RequiredFieldValidator ID="rfvMob" runat="server" 
                              ErrorMessage="Please enter Mobile Number" ControlToValidate="txtmobile"  
                              ValidationGroup="PostData">*</asp:RequiredFieldValidator>
                               <cc3:ValidatorCalloutExtender ID="ValidatorCalloutExtender30" runat="server" Enabled="true" TargetControlID="rfvMob">
                                          </cc3:ValidatorCalloutExtender>
                             <asp:RangeValidator ID="rangevalMob" runat="server" 
                            ErrorMessage="Phone number should start with zero" MinimumValue="0" ControlToValidate="txtmobile" 
                            MaximumValue="1" ValidationGroup="PostData">*</asp:RangeValidator> 
                             <cc3:ValidatorCalloutExtender ID="ValidatorCalloutExtender31" runat="server" Enabled="true" TargetControlID="rangevalMob">
                                          </cc3:ValidatorCalloutExtender> 
                            <asp:RegularExpressionValidator ID="revmob" runat="server" 
                              ErrorMessage="The number shoud be 11 digits" ControlToValidate="txtmobile" 
                              ValidationExpression="\d{11}" ValidationGroup="PostData">*</asp:RegularExpressionValidator>
                               <cc3:ValidatorCalloutExtender ID="ValidatorCalloutExtender32" runat="server" Enabled="true" TargetControlID="revmob">
                                          </cc3:ValidatorCalloutExtender>
                      </td>
                      </tr>
                                           
                      <tr>
                      <td class="adminform">Fax</td>
                      <td align="center">:</td>
                      <td>
                      <asp:TextBox ID="txtFax" runat="server" Width="186px" onkeypress="javascript:fnNumbersOnly();" MaxLength="11" ></asp:TextBox>   
                            <asp:RangeValidator ID="rangevalFax" runat="server" 
                            ErrorMessage="Fax number should start with zero" MinimumValue="0" ControlToValidate="txtFax" 
                            MaximumValue="1" ValidationGroup="PostData">*</asp:RangeValidator> 
                             <cc3:ValidatorCalloutExtender ID="valcalextnFax" runat="server" Enabled="true" TargetControlID="rangevalFax">
                                          </cc3:ValidatorCalloutExtender> 
                            <asp:RegularExpressionValidator ID="revFax" runat="server" 
                              ErrorMessage="The number shoud be 11 digits" ControlToValidate="txtFax" 
                              ValidationExpression="\d{11}" ValidationGroup="PostData">*</asp:RegularExpressionValidator>
                               <cc3:ValidatorCalloutExtender ID="valcalextnrevFax" runat="server" Enabled="true" TargetControlID="revFax">
                                          </cc3:ValidatorCalloutExtender>                                       
                      </td>
                      </tr>                                                                                     
                      
                      </table>                      
                            </ContentTemplate>
                        </asp:UpdatePanel>   
                     </td>
                  </tr>
                  <tr>              
                      <td align="center">
                      <asp:Button ID="btnSubmit" runat="server" Text="Submit" 
                              style="height: 26px" ValidationGroup="PostData" 
                              onclick="btnSubmit_Click" />                      
                      </td>
                  </tr>
                  <tr><td>
                      <%--<asp:ValidationSummary ID="ValidationSummary1" runat="server" 
                          ShowMessageBox="True" ShowSummary="False" ValidationGroup="PostData" />--%>
                  </td></tr>
                </table>
                </td>
                
              </tr>
                
            </table>   
                          
           </td>
         </tr>
         
       </table>
    </div>
   </form>
 </body>
</html>