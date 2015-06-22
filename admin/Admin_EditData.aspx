<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Admin_EditData.aspx.cs" Inherits="admin_Admin_EditCatData" %>

<%@ Register Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" TagPrefix="cc3"  %>
<%@ Register Src="~/admin/user_control/Admin_Headermenu.ascx" TagName="Headermenu" TagPrefix="cc1" %>
<%@ Register Src="~/admin/user_control/Admin_LeftMenu.ascx" TagName="LeftMenu" TagPrefix="cc4" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="AjaxToolkit" %>
<%@ Register Src="~/admin/user_control/Admin_DataHeader.ascx" TagName="dataHeader" TagPrefix="dataHead" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title>Justcalluz - Admin Control Panel - To update data</title>
    <link href="includes/style.css" rel="Stylesheet" type="text/css" />
    <script type="text/javasrcipt" src="http://ajax.googleapis.com/ajax/libs/jquery/1.6.2/jquery.min.js"></script>
    <script src="js/statesopt.js"></script>
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
        .style39
        {
            width: 195px;
        }        
        .style40
        {
            height: 23px;
        }
        .style41
        {
            font-family: Arial, Helvetica, sans-serif;
            font-size: 12px;
            color: #054997;
            font-weight: normal;
            height: 25px;
        }
        </style> 
        <script language="javascript" type="text/javascript">
  
  	function confirm_delete(uid)
{
  if (confirm("Are you sure you want to delete this Classified?")==true)
    document.location='Admin_DeletePhoto.aspx?cid=' +uid;
  else
    return false;
}
	function alertdelete()
{
alert("Selected Classified has been deleted Successfully");
}
function alertaccept()
{
alert("Selected Classified has been Accepted");
}
    </script>	
        <script type="text/javascript">
function CurrentDateShowing(e)
{
      if (!e.get_selectedDate() || !e.get_element().value)

      e._selectedDate = (new Date()).getDateOnly();
}    
</script>  
<script language="Javascript">
       <!--
    function isNumberKey(evt) {
        var charCode = (evt.which) ? evt.which : event.keyCode
        if (charCode != 46 && charCode > 31
            && (charCode < 48 || charCode > 57))
            return false;

        return true;
    }
       //-->
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
        <script type="text/javascript" src="js/tab.js"></script>

        </head>
<body onload="new Accordian('basic-accordian',5,'header_highlight');">
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
               <td class="style39" valign="top" style="padding-top:4px">                        
                 <cc4:LeftMenu ID="LeftMenu1" runat="server" />
                </td>
                <td valign="top">&nbsp;</td>
                <td valign="top" style="padding-left:10px; background-color:#F2FAFC">  
                <table width="750px" id="hide" runat="server">
                <tr>
                            <td colspan="2">                                
                                <dataHead:dataHeader ID="datahead1" runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <td width="50%">
                                <asp:ScriptManager ID="ScriptManager2" runat="server">
                                </asp:ScriptManager>
                            </td>
                            <td width="50%" align="right">
                            <a href="http://www.justcalluz.com" target="_blank"><img src="images/Click Here For SiteView.png" alt="SiteView"/> </a> 
                            </td>
                        </tr>                                              
                        <tr>
                            <td colspan="2">
                                <asp:Label ID="Label1" runat="server"></asp:Label>
                            </td>
                        </tr> 
                  <tr>
                  <td colspan="3" align="left">
                  <table width="100%" style="padding-left:100px;">
                  <tr>
                    <td colspan="3" align="center">
                        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                            <ContentTemplate>        
                                 <table cellspacing="5" style="height: 564px; width: 100%; margin-left: 0px;">
                                    <tr>
                       <td align="center" colspan="3" style="padding-right:7%;">
                        <span style="color:Red; font-family:Verdana;font-size:14px;font-weight:bold;"> To Update Data</span>
                       </td>
                     </tr>
                     <tr>
                       <td align="left" colspan="3">                                
                           <asp:Label ID="lblMessage" runat="server"></asp:Label>             
           
                       </td>
                     </tr>
                       <tr><td align="right" colspan="3" style="padding-right:5px;padding-bottom:10px;">
                             <asp:LinkButton ID="lnkBack" runat="server" Text="Back"  OnClick="btnCancel_Click"></asp:LinkButton> 
                        </td></tr>
                    <%-- <tr>
                     <td colspan="3" align="right">
                     <asp:Button ID="btnCancel" runat="server" Text="Cancel Update" 
                              style="height: 26px"  onclick="btnCancel_Click" 
                              />
                     </td>
                     </tr>--%>
                      <tr>
                      <td class="adminform" align="right">Module</td>
                      <td align="center"> &nbsp;&nbsp;:&nbsp;&nbsp;</td>
                      <td>                               
                          <asp:DropDownList ID="ddlModule" runat="server" Width="190px" 
                              onselectedindexchanged="ddlModule_SelectedIndexChanged" AutoPostBack="true">
                          </asp:DropDownList>
                          
                          <asp:RequiredFieldValidator ID="rfvModule" runat="server" 
                              ControlToValidate="ddlModule" ErrorMessage="Please select Module" 
                              InitialValue="Select Module" ValidationGroup="EditData">*</asp:RequiredFieldValidator>
                           <cc3:ValidatorCalloutExtender ID="valcaloutextn" runat="server" Enabled="true" TargetControlID="rfvModule">
                                          </cc3:ValidatorCalloutExtender>
                      </td>
                      </tr>
                      
                      <tr>
                      <td class="adminform" align="right">Category</td>
                      <td align="center"> &nbsp;&nbsp;:&nbsp;&nbsp;</td>
                      <td>                               
                          <asp:DropDownList ID="ddlCategory" runat="server" Width="189px" 
                              onselectedindexchanged="ddlCategory_SelectedIndexChanged" AutoPostBack="true">
                          </asp:DropDownList>
                          
                          <asp:RequiredFieldValidator ID="rfvCat" runat="server" 
                              ControlToValidate="ddlCategory" ErrorMessage="Please select Category" 
                              InitialValue="Select Category" ValidationGroup="EditData">*</asp:RequiredFieldValidator>
                           <cc3:ValidatorCalloutExtender ID="ValidatorCalloutExtender1" runat="server" Enabled="true" TargetControlID="rfvCat">
                                          </cc3:ValidatorCalloutExtender>
                      </td>
                      </tr>
                      
                      <tr id="trSubCat" runat="server">
                      <td class="adminform" align="right">Sub Category</td>
                      <td align="center"> &nbsp;&nbsp;:&nbsp;&nbsp;</td>
                      <td>                               
                          <asp:DropDownList ID="ddlSubCat" runat="server" Width="190px" 
                              onselectedindexchanged="ddlSubCat_SelectedIndexChanged" AutoPostBack="true">
                          </asp:DropDownList>
                          
                          <asp:RequiredFieldValidator ID="rfvsubcat" runat="server" 
                              ControlToValidate="ddlSubCat" ErrorMessage="Please select Sub Category" 
                              InitialValue="Select Sub Category" ValidationGroup="EditData">*</asp:RequiredFieldValidator>
                           <cc3:ValidatorCalloutExtender ID="ValidatorCalloutExtender2" runat="server" Enabled="true" TargetControlID="rfvsubcat">
                                          </cc3:ValidatorCalloutExtender>
                      </td>
                      </tr>                                                                                              
                      <tr id="trOtherSubCat" runat="server">
                      <td class="adminform" align="right"></td>
                      <td align="center"> &nbsp;&nbsp;&nbsp;&nbsp;</td>
                      <td>                               
                          <asp:TextBox ID="txtOthers" runat="server" Width="186px"></asp:TextBox>
                          
                          <asp:RequiredFieldValidator ID="rfvOthers" runat="server" 
                              ControlToValidate="txtOthers" ErrorMessage="Please enter Others Subcategoty " 
                            ValidationGroup="EditData">*</asp:RequiredFieldValidator>
                           <cc3:ValidatorCalloutExtender ID="ValidatorCalloutExtender3" runat="server" Enabled="true" TargetControlID="rfvOthers">
                                          </cc3:ValidatorCalloutExtender>
                      </td>
                      </tr>
                      <tr>
                      <td class="adminform" align="right">State</td>
                      <td align="center"> &nbsp;&nbsp;:&nbsp;&nbsp;</td>
                      <td>                               
                          <asp:DropDownList ID="ddlState" runat="server" Width="190px" 
                              onselectedindexchanged="ddlState_SelectedIndexChanged" AutoPostBack="true">
                          </asp:DropDownList>
                          
                          <asp:RequiredFieldValidator ID="rfvState" runat="server" 
                              ControlToValidate="ddlState" ErrorMessage="Please select State" 
                              InitialValue="Select State" ValidationGroup="EditData">*</asp:RequiredFieldValidator>
                           <cc3:ValidatorCalloutExtender ID="ValidatorCalloutExtender4" runat="server" Enabled="true" TargetControlID="rfvState">
                                          </cc3:ValidatorCalloutExtender>
                      </td>
                      </tr>
                      
                      <tr>
                      <td class="adminform" align="right">City</td>
                      <td align="center"> &nbsp;&nbsp;:&nbsp;&nbsp;</td>
                      <td>                               
                          <asp:DropDownList ID="ddlCity" runat="server" Width="190px">
                          </asp:DropDownList>
                          
                          <asp:RequiredFieldValidator ID="rfvCity" runat="server" 
                              ControlToValidate="ddlCity" ErrorMessage="Please select City" 
                              InitialValue="Select City" ValidationGroup="EditData">*</asp:RequiredFieldValidator>
                           <cc3:ValidatorCalloutExtender ID="ValidatorCalloutExtender5" runat="server" Enabled="true" TargetControlID="rfvCity">
                                          </cc3:ValidatorCalloutExtender>
                      </td>
                      </tr>
                      <tr>
                      <td class="adminform" align="right">Area</td>
                      <td align="center"> &nbsp;&nbsp;:&nbsp;&nbsp;</td>
                      <td>                               
                          <asp:TextBox ID="txtArea" runat="server" Width="187px"  onkeypress="return Alphabets(event);"></asp:TextBox>                          
                          <asp:RequiredFieldValidator ID="rfvArea" runat="server" 
                              ControlToValidate="txtArea" ErrorMessage="Please Enter Area for the respective city" 
                              ValidationGroup="EditData">*</asp:RequiredFieldValidator>
                           <cc3:ValidatorCalloutExtender ID="valcaloutextnArea" runat="server" Enabled="true" TargetControlID="rfvArea">
                                          </cc3:ValidatorCalloutExtender>
                      </td>
                      </tr>
                     <tr id="trJobCat" runat="server">            
                          <td class="adminform" align="right" style="width:145px"><asp:Label ID="lblCompanyname" runat="server" Text="Company Name"></asp:Label></td>
                          <td align="center" style="width:49px"> &nbsp;&nbsp;:&nbsp;&nbsp;</td>
                          <td>                               
                          <asp:TextBox ID="txtCompanyname" runat="server" Width="187px"  onkeypress="return Alphabets(event);"></asp:TextBox>                      
                          
                         <asp:RequiredFieldValidator ID="rfvCompanyName" runat="server" 
                                  ErrorMessage="Please enter Company Name" ControlToValidate="txtCompanyname" 
                                  ValidationGroup="EditData">*</asp:RequiredFieldValidator>
                              <cc3:ValidatorCalloutExtender ID="ValidatorCalloutExtender6" runat="server" Enabled="true" TargetControlID="rfvCompanyName">
                              </cc3:ValidatorCalloutExtender>
                          </td>                                   
                      </tr>
                       
                      <tr id="trJobsInd" runat="server">
                              <td class="adminform" align="right">Industry</td>
                              <td align="center"> &nbsp;&nbsp;:&nbsp;&nbsp;</td>
                              <td>
                                  <asp:DropDownList ID="ddlJIndustry" runat="server" Width="188px">
                                  </asp:DropDownList>
                                    <asp:RequiredFieldValidator ID="rfvInd" runat="server" 
                                      ErrorMessage="Please select Industry" ControlToValidate="ddlJIndustry" 
                                      ValidationGroup="EditData" InitialValue="Select Industry">*</asp:RequiredFieldValidator>
                                    <cc3:ValidatorCalloutExtender ID="ValidatorCalloutExtender7" runat="server" Enabled="true" TargetControlID="rfvInd">
                                    </cc3:ValidatorCalloutExtender>
                              </td>
                             </tr>
                             <tr id="trJobsFA" runat="server">
                              <td class="adminform" align="right">Functional Area</td>
                              <td align="center">:</td>
                              <td>
                                  <asp:DropDownList ID="ddlJFunArea" runat="server" Width="190px">
                                  </asp:DropDownList>
                                    <asp:RequiredFieldValidator ID="rfvFunArea" runat="server" 
                                      ErrorMessage="Please select Functional Area" ControlToValidate="ddlJFunArea" 
                                      ValidationGroup="EditData" InitialValue="Select Functional Area">*</asp:RequiredFieldValidator>
                                    <cc3:ValidatorCalloutExtender ID="ValidatorCalloutExtender8" runat="server" Enabled="true" TargetControlID="rfvFunArea">
                                          </cc3:ValidatorCalloutExtender>
                              </td>
                             </tr>
                             <tr id="trJobsRole" runat="server">
                              <td class="adminform" align="right">Role</td>
                              <td align="center">:</td>
                              <td>
                                  <asp:TextBox ID="txtJRole" runat="server" Width="186px"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvRole" runat="server" 
                                      ErrorMessage="Please enter Role" ControlToValidate="txtJRole" 
                                      ValidationGroup="EditData">*</asp:RequiredFieldValidator>
                                    <cc3:ValidatorCalloutExtender ID="ValidatorCalloutExtender9" runat="server" Enabled="true" TargetControlID="rfvRole">
                                          </cc3:ValidatorCalloutExtender>
                              </td>
                             </tr>                             
                             <tr id="trJobsQual" runat="server">
                              <td class="adminform" align="right">Qualification</td>
                              <td align="center">:</td>
                              <td>
                                  <asp:TextBox ID="txtJQual" runat="server" Width="186px"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvQual" runat="server" 
                                      ErrorMessage="Please enter Qualification" ControlToValidate="txtJQual" 
                                      ValidationGroup="EditData">*</asp:RequiredFieldValidator>
                                    <cc3:ValidatorCalloutExtender ID="ValidatorCalloutExtender10" runat="server" Enabled="true" TargetControlID="rfvQual">
                                          </cc3:ValidatorCalloutExtender>
                              </td>
                             </tr>
                             <tr id="trJobsAge" runat="server">
                              <td class="adminform" align="right">Age Limit</td>
                              <td align="center">:</td>
                              <td>
                                  <asp:TextBox ID="txtAge" runat="server" Width="188px"></asp:TextBox>                                    
                              </td>
                             </tr>
                             <tr id="trJobsExperience" runat="server">
                              <td class="adminform" align="right">Experience</td>
                              <td align="center">:</td>
                              <td>
                                  <asp:DropDownList ID="ddlExp" runat="server" Width="188px" 
                                      onselectedindexchanged="ddlExp_SelectedIndexChanged" AutoPostBack="true">
                                    <asp:ListItem>Select One</asp:ListItem>
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
                              
                            <tr id="trExpOther" runat="server">
                              <td class="adminform" align="right"></td>
                              <td align="center"></td>
                              <td>
                                  <asp:TextBox ID="txtJExp" runat="server" Width="188px"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvExp" runat="server" 
                                      ErrorMessage="Please enter Experience" ControlToValidate="txtJExp" 
                                      ValidationGroup="EditData">*</asp:RequiredFieldValidator>
                                   <cc3:ValidatorCalloutExtender ID="ValidatorCalloutExtender12" runat="server" Enabled="true" TargetControlID="rfvExp">
                                          </cc3:ValidatorCalloutExtender>
                              </td>
                             </tr>
                             <tr id="trJobsSal" runat="server">
                              <td class="adminform" align="right">Salary</td>
                              <td align="center">:</td>
                              <td>
                                  <asp:TextBox ID="txtJSal" runat="server" Width="188px"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvSal" runat="server" 
                                      ErrorMessage="Please enter Salary" ControlToValidate="txtJSal" 
                                      ValidationGroup="EditData">*</asp:RequiredFieldValidator>
                                   <cc3:ValidatorCalloutExtender ID="ValidatorCalloutExtender13" runat="server" Enabled="true" TargetControlID="rfvSal">
                                          </cc3:ValidatorCalloutExtender>
                              </td>
                             </tr>
                              <tr id="trJobsDesc" runat="server">
                              <td class="adminform" align="right">Job Description</td>
                              <td align="center">:</td>
                              <td>
                                  <asp:TextBox ID="txtJobDesc" runat="server" Width="188px"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvJobDesc" runat="server" 
                                      ErrorMessage="Please enter Job Description" ControlToValidate="txtJobDesc" 
                                      ValidationGroup="EditData">*</asp:RequiredFieldValidator>
                                   <cc3:ValidatorCalloutExtender ID="ValidatorCalloutExtender14" runat="server" Enabled="true" TargetControlID="rfvJobDesc">
                                          </cc3:ValidatorCalloutExtender>
                              </td>
                             </tr>
                              <tr id="trJobsSkill" runat="server">
                              <td class="adminform" align="right">Key Skills</td>
                              <td align="center">:</td>
                              <td>
                                  <asp:TextBox ID="txtJkeyskills" runat="server" Width="188px"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvKeyskills" runat="server" 
                                      ErrorMessage="Please enter key skills" ControlToValidate="txtJkeyskills" 
                                      ValidationGroup="EditData">*</asp:RequiredFieldValidator>
                                     <cc3:ValidatorCalloutExtender ID="ValidatorCalloutExtender15" runat="server" Enabled="true" TargetControlID="rfvKeyskills">
                                          </cc3:ValidatorCalloutExtender>
                              </td>
                             </tr>
                              <tr id="trJobsExpiry" runat="server">
                              <td class="adminform" align="right">Job Expires on</td>
                              <td align="center">:</td>
                              <td>
                                  <asp:TextBox ID="txtJobExpire" runat="server" Width="188px"></asp:TextBox> (mm/dd/yyy)  
                                    <asp:RequiredFieldValidator ID="rfvJobExpire" runat="server" 
                                      ErrorMessage="Please enter Job Expiry Date" ControlToValidate="txtJobExpire" 
                                      ValidationGroup="EditData">*</asp:RequiredFieldValidator>
                                     <cc3:ValidatorCalloutExtender ID="ValidatorCalloutExtender33" runat="server" Enabled="true" TargetControlID="rfvJobExpire">
                                          </cc3:ValidatorCalloutExtender>
                                     <cc3:CalendarExtender ID="CalendarExtender1" runat="server" TargetControlID="txtJobExpire" OnClientShowing="CurrentDateShowing">
                                          </cc3:CalendarExtender>
                                     <asp:RangeValidator ID="rangeValJobExpire" runat="server" 
                                               Type="Date" 
                                              ControlToValidate="txtJobExpire" ValidationGroup="EditData">*</asp:RangeValidator>
                                     <cc3:ValidatorCalloutExtender ID="ValidatorCalloutExtender35" runat="server" Enabled="true" TargetControlID="rangeValJobExpire">
                                          </cc3:ValidatorCalloutExtender>   
                                                                                    
                              </td>
                              
                             </tr>                          
                      
                      <tr id="trCatandJobs" runat="server">
                         
                          <td class="adminform" align="right" ><asp:Label ID="lblCompProfile" runat="server" Text="Company Profile"></asp:Label></td>
                          <td align="center"> &nbsp;&nbsp;:&nbsp;&nbsp;</td>
                          <td>                               
                          <asp:TextBox ID="txtCompanyProfile" runat="server" Width="186px"></asp:TextBox>                      
                          
                             <asp:RequiredFieldValidator ID="rfvCompProfile" runat="server" 
                                  ErrorMessage="Please enter Company Profile" 
                                  ControlToValidate="txtCompanyProfile" ValidationGroup="EditData">*</asp:RequiredFieldValidator>
                               <cc3:ValidatorCalloutExtender ID="ValidatorCalloutExtender16" runat="server" Enabled="true" TargetControlID="rfvCompProfile">
                                          </cc3:ValidatorCalloutExtender>
                          </td>
                                  
                      </tr>
                                           
                                    <tr id="trEventName" runat="server">
                                      <td class="adminform" align="right">Event Name</td>
                                      <td align="center"> &nbsp;&nbsp;:&nbsp;&nbsp;</td>
                                      <td>                               
                                      <asp:TextBox ID="txtEveName" runat="server" Width="186px"  onkeypress="return Alphabets(event);"></asp:TextBox>                      
                                      
                                         <asp:RequiredFieldValidator ID="rfvEveName" runat="server" 
                                              ErrorMessage="Please enter Name of the Event" ControlToValidate="txtEveName" 
                                              ValidationGroup="EditData">*</asp:RequiredFieldValidator>
                                         <cc3:ValidatorCalloutExtender ID="ValidatorCalloutExtender17" runat="server" Enabled="true" TargetControlID="rfvEveName">
                                          </cc3:ValidatorCalloutExtender>
                                      </td>
                                    </tr>
                                    <tr id="trEventsPlace" runat="server">
                                      <td class="adminform" align="right">Place of Event</td>
                                      <td align="center"> &nbsp;&nbsp;:&nbsp;&nbsp;</td>
                                      <td>                               
                                      <asp:TextBox ID="txtEvePlace" runat="server" Width="186px" onkeypress="return Alphabets(event);"></asp:TextBox>                      
                                      
                                         <asp:RequiredFieldValidator ID="rfvEvePlace" runat="server" 
                                              ErrorMessage="Please enter place of an Event" ControlToValidate="txtEvePlace" 
                                              ValidationGroup="EditData">*</asp:RequiredFieldValidator>
                                         <cc3:ValidatorCalloutExtender ID="ValidatorCalloutExtender18" runat="server" Enabled="true" TargetControlID="rfvEvePlace">
                                          </cc3:ValidatorCalloutExtender>
                                      </td>
                                    </tr>
                             
                                     <tr id="trEvDiDuration" runat="server">
                                      <td class="adminform" align="right">Duration type of event</td>
                                      <td align="center"> &nbsp;&nbsp;:&nbsp;&nbsp;</td>
                                      <td>                               
                                          <asp:DropDownList ID="ddlDurationType" runat="server" Width="186px" 
                                              onselectedindexchanged="ddlDurationType_SelectedIndexChanged" AutoPostBack="true">
                                          <asp:ListItem Value="Select One">Select One</asp:ListItem>    
                                          <asp:ListItem Value="One Day Event">One Day Event</asp:ListItem>
                                          <asp:ListItem Value="Multi Day Event">Multi Day Event</asp:ListItem>
                                          </asp:DropDownList>                                                       
                                         <asp:RequiredFieldValidator ID="rfvdurationtype" runat="server" 
                                              ErrorMessage="Please select Duration type of event" ControlToValidate="ddlDurationType" 
                                              ValidationGroup="EditData" InitialValue="Select One">*</asp:RequiredFieldValidator>
                                          <cc3:ValidatorCalloutExtender ID="ValidatorCalloutExtender24" runat="server" Enabled="true" TargetControlID="rfvdurationtype">
                                          </cc3:ValidatorCalloutExtender>                                                                                                                              
                                      </td>
                                    </tr>                                  
                                     <tr id="trEvDiStartDate" runat="server">
                                      <td class="adminform" align="right" style="width:146px">Start Date</td>
                                      <td align="center" style="width:52px"> &nbsp;&nbsp;:&nbsp;&nbsp;</td>
                                      <td>                               
                                      <asp:TextBox ID="txtEveDiStartDate" runat="server" Width="186px"></asp:TextBox>                                                            
                                         <asp:RequiredFieldValidator ID="rfvStartDate" runat="server" 
                                              ErrorMessage="Please Enter Start Date" ControlToValidate="txtEveDiStartDate" 
                                              ValidationGroup="EditData">*</asp:RequiredFieldValidator>
                                          <cc3:ValidatorCalloutExtender ID="ValidatorCalloutExtender19" runat="server" Enabled="true" TargetControlID="rfvStartDate">
                                          </cc3:ValidatorCalloutExtender>
                                          <cc3:CalendarExtender ID="calextStartDate" runat="server" TargetControlID="txtEveDiStartDate" OnClientShowing="CurrentDateShowing">
                                          </cc3:CalendarExtender>
                                          
                                          <asp:RangeValidator ID="rangevalStartDate" runat="server" 
                                               Type="Date" 
                                              ControlToValidate="txtEveDiStartDate" ValidationGroup="EditData">*</asp:RangeValidator>
                                              <cc3:ValidatorCalloutExtender ID="valcalextnStartDate" runat="server" Enabled="true" TargetControlID="rangevalStartDate">
                                          </cc3:ValidatorCalloutExtender>
                                      </td>
                                    </tr>
                                    <tr id="trEndDate" runat="server">
                                      <td class="adminform" align="right">End Date</td>
                                      <td align="center"> &nbsp;&nbsp;:&nbsp;&nbsp;</td>
                                      <td>                               
                                      <asp:TextBox ID="txtEveDiEndDate" runat="server" Width="186px"></asp:TextBox>                      
                                      
                                         <asp:RequiredFieldValidator ID="rfvEndDate" runat="server" 
                                              ErrorMessage="Please enter End Date" ControlToValidate="txtEveDiEndDate" 
                                              ValidationGroup="EditData">*</asp:RequiredFieldValidator>
                                          <cc3:ValidatorCalloutExtender ID="ValidatorCalloutExtender20" runat="server" Enabled="true" TargetControlID="rfvEndDate">
                                          </cc3:ValidatorCalloutExtender>
                                          <cc3:CalendarExtender ID="calextEndDate" runat="server" TargetControlID="txtEveDiEndDate" OnClientShowing="CurrentDateShowing">
                                          </cc3:CalendarExtender>  
                                            <asp:RangeValidator ID="rangevalEndDate" runat="server" 
                                              ErrorMessage="Please select after todays date" Type="Date" 
                                              ControlToValidate="txtEveDiEndDate" ValidationGroup="EditData">*</asp:RangeValidator>
                                               <cc3:ValidatorCalloutExtender ID="valcalextnEndDate" runat="server" Enabled="true" TargetControlID="rangevalEndDate">
                                          </cc3:ValidatorCalloutExtender>
                                      </td>
                                    </tr>
                                    <tr id="trEvDiDesc" runat="server">
                                      <td class="adminform" align="right">Description</td>
                                      <td align="center"> &nbsp;&nbsp;:&nbsp;&nbsp;</td>
                                      <td>                               
                                      <asp:TextBox ID="txtEveDiDesc" runat="server" Width="186px"></asp:TextBox>                      
                                      
                                         <asp:RequiredFieldValidator ID="rfvEveDesc" runat="server" 
                                              ErrorMessage="Please enter Description" ControlToValidate="txtEveDiDesc" 
                                              ValidationGroup="EditData">*</asp:RequiredFieldValidator>
                                               <cc3:ValidatorCalloutExtender ID="ValidatorCalloutExtender21" runat="server" Enabled="true" TargetControlID="rfvEveDesc">
                                          </cc3:ValidatorCalloutExtender>
                                      </td>
                                    </tr>
                                    <tr  id="trEvDiEventTime" runat="server">
                                      <td class="adminform" align="right">Time of Event</td>
                                      <td align="center"> &nbsp;&nbsp;:&nbsp;&nbsp;</td>
                                      <td>                               
                                      <asp:TextBox ID="txtEveDiTime" runat="server" Width="186px"></asp:TextBox>                      
                                      
                                         <asp:RequiredFieldValidator ID="rfvEveTime" runat="server" 
                                              ErrorMessage="Please enter Time Duration" ControlToValidate="txtEveDiTime" 
                                              ValidationGroup="EditData">*</asp:RequiredFieldValidator>
                                               <cc3:ValidatorCalloutExtender ID="ValidatorCalloutExtender22" runat="server" Enabled="true" TargetControlID="rfvEveTime">
                                          </cc3:ValidatorCalloutExtender>
                                      </td>
                                    </tr>                                        
                              
                      <tr>
                      <td class="adminform" align="right">Address</td>
                      <td align="center">:</td>
                      <td>
                      <asp:TextBox ID="txtaddr" runat="server" Width="184px" TextMode="MultiLine"></asp:TextBox>
                      <asp:RequiredFieldValidator ID="rfvAddr" runat="server" 
                              ErrorMessage="Please enter address" ControlToValidate="txtaddr" 
                              ValidationGroup="EditData">*</asp:RequiredFieldValidator>
                               <cc3:ValidatorCalloutExtender ID="ValidatorCalloutExtender23" runat="server" Enabled="true" TargetControlID="rfvAddr">
                                          </cc3:ValidatorCalloutExtender>
                      </td>
                      </tr>
                      
                      <tr>
                      <td class="adminform" align="right">Land Mark</td>
                      <td align="center">:</td>
                      <td>
                      <asp:TextBox ID="txtLandMark" runat="server" Width="188px"></asp:TextBox>                      
                      </td>
                      </tr>
                      <tr>
                      <td class="adminform" align="right">Pin Code</td>
                      <td align="center">:</td>
                      <td>
                      <asp:TextBox ID="txtPinCode" runat="server" Width="188px" MaxLength="6" onkeypress="return isNumberKey(event)"></asp:TextBox>
                      <asp:RequiredFieldValidator ID="rfvPincode" runat="server" 
                              ErrorMessage="Please enter Pincode" ControlToValidate="txtPinCode" 
                              ValidationGroup="EditData">*</asp:RequiredFieldValidator>
                               <cc3:ValidatorCalloutExtender ID="ValidatorCalloutExtender34" runat="server" Enabled="true" TargetControlID="rfvPincode">
                                        </cc3:ValidatorCalloutExtender>
                          <asp:RegularExpressionValidator ID="revPinCode" runat="server" 
                              ErrorMessage="Enter pincode number only 6 digits(starting number should starts from 1 to 9 digits)" ControlToValidate="txtPinCode" 
                              ValidationExpression="^[01]?[- .]?(\([1-9]\d{1}\)|[1-9]\d{1})[- .]?\d{2}[- .]?\d{2}$" Display="Dynamic" ValidationGroup="EditData"></asp:RegularExpressionValidator>                 
                              <cc3:ValidatorCalloutExtender ID="ValidatorCalloutExtender37" runat="server" Enabled="true" TargetControlID="revPinCode">
                                        </cc3:ValidatorCalloutExtender>            
                      </td>
                      </tr>
                      <tr>
                      <td class="adminform" align="right">Contact Person</td>
                      <td align="center">:</td>
                      <td>
                      <asp:TextBox ID="txtContPerson" runat="server" Width="188px"  onkeypress="return Alphabets(event);" ></asp:TextBox>
                      <asp:RequiredFieldValidator ID="rfvContPerson" runat="server" 
                              ErrorMessage="Please enter Name of the Contact Person" 
                              ControlToValidate="txtContPerson" ValidationGroup="EditData">*</asp:RequiredFieldValidator>
                               <cc3:ValidatorCalloutExtender ID="ValidatorCalloutExtender25" runat="server" Enabled="true" TargetControlID="rfvContPerson">
                                          </cc3:ValidatorCalloutExtender>
                      </td>
                      </tr>
                     
                     
                     <tr>
                      <td class="adminform" align="right">Email</td>
                      <td align="center">:</td>
                      <td>
                      <asp:TextBox ID="txtemail" runat="server" Width="188px" ></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvEmail" runat="server" 
                              ErrorMessage="Please enter Email Id" ControlToValidate="txtemail" 
                              ValidationGroup="EditData">*</asp:RequiredFieldValidator>
                               <cc3:ValidatorCalloutExtender ID="ValidatorCalloutExtender26" runat="server" Enabled="true" TargetControlID="rfvEmail">
                                          </cc3:ValidatorCalloutExtender>
                          <asp:RegularExpressionValidator ID="revEmail" runat="server" 
                              ControlToValidate="txtemail" 
                              ErrorMessage="Please enter Valid Email Id. Eg: XXXXX@xxx.xx" 
                              ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
                              ValidationGroup="EditData">*</asp:RegularExpressionValidator>
                               <cc3:ValidatorCalloutExtender ID="ValidatorCalloutExtender27" runat="server" Enabled="true" TargetControlID="revEmail">
                                          </cc3:ValidatorCalloutExtender>
                      </td>
                      </tr>
                      <tr>
                      <td class="adminform" align="right">Phone</td>
                      <td align="center">:</td>
                      <td>
                      <asp:TextBox ID="txtph" runat="server" Width="188px" onkeypress="return isNumberKey(event)" MaxLength="11"></asp:TextBox>
                      <asp:RangeValidator ID="rangevalPh" runat="server" 
                            ErrorMessage="Phone number should start with zero" MinimumValue="0" ControlToValidate="txtph" 
                            MaximumValue="1" ValidationGroup="EditData">*</asp:RangeValidator>
                             <cc3:ValidatorCalloutExtender ID="ValidatorCalloutExtender28" runat="server" Enabled="true" TargetControlID="rangevalPh">
                                          </cc3:ValidatorCalloutExtender>
                          <asp:RegularExpressionValidator ID="revph" runat="server" 
                              ErrorMessage="Enter mobile number only ten digits(starting number should starts from 1 to 9 digits)" ControlToValidate="txtph" 
                              ValidationExpression="^[01]?[- .]?(\([1-9]\d{2}\)|[1-9]\d{2})[- .]?\d{3}[- .]?\d{4}$" Display="Dynamic"  ValidationGroup="EditData"></asp:RegularExpressionValidator>
                               <cc3:ValidatorCalloutExtender ID="ValidatorCalloutExtender29" runat="server" Enabled="true" TargetControlID="revph">
                                          </cc3:ValidatorCalloutExtender>
                      </td>
                      </tr>
                      
                       <tr>
                      <td class="adminform" align="right">Mobile</td>
                      <td align="center">:</td>
                      <td>
                      <asp:TextBox ID="txtcode" runat="server" ReadOnly="true" Text="+91" Width="29px"></asp:TextBox>-
                      <asp:TextBox ID="txtmobile" runat="server" Width="146px" onkeypress="return isNumberKey(event)" MaxLength="10"></asp:TextBox>
                     <asp:RequiredFieldValidator ID="rfvMob" runat="server" 
                              ErrorMessage="Please enter Mobile Number" ControlToValidate="txtmobile"  
                              ValidationGroup="EditData">*</asp:RequiredFieldValidator>
                               <cc3:ValidatorCalloutExtender ID="ValidatorCalloutExtender30" runat="server" Enabled="true" TargetControlID="rfvMob">
                                          </cc3:ValidatorCalloutExtender>
                            <%-- <asp:RangeValidator ID="rangevalMob" runat="server" 
                            ErrorMessage="Phone number should start with zero" MinimumValue="0" ControlToValidate="txtmobile" 
                            MaximumValue="1" ValidationGroup="EditData">*</asp:RangeValidator> --%>
                            <%-- <cc3:ValidatorCalloutExtender ID="ValidatorCalloutExtender31" runat="server" Enabled="true" TargetControlID="rangevalMob">
                                          </cc3:ValidatorCalloutExtender> --%>
                            <asp:RegularExpressionValidator ID="revmob" runat="server" 
                              ErrorMessage="Enter mobile number only ten digits(starting number should starts from 1 to 9 digits)" ControlToValidate="txtmobile" 
                              ValidationExpression="^[01]?[- .]?(\([1-9]\d{2}\)|[1-9]\d{2})[- .]?\d{3}[- .]?\d{4}$" Display="Dynamic"  ValidationGroup="EditData"></asp:RegularExpressionValidator>
                               <cc3:ValidatorCalloutExtender ID="ValidatorCalloutExtender32" runat="server" Enabled="true" TargetControlID="revmob">
                                          </cc3:ValidatorCalloutExtender>
                      </td>
                      </tr>
                                           
                      <tr>
                      <td class="adminform" align="right">Fax</td>
                      <td align="center">:</td>
                      <td>
                      <asp:TextBox ID="txtFax" runat="server" Width="188px" onkeypress="return isNumberKey(event)" MaxLength="11" ></asp:TextBox>   
                            <asp:RangeValidator ID="rangevalFax" runat="server" 
                            ErrorMessage="Fax number should start with zero" MinimumValue="0" ControlToValidate="txtFax" 
                            MaximumValue="1" ValidationGroup="EditData">*</asp:RangeValidator> 
                             <cc3:ValidatorCalloutExtender ID="valcalextnFax" runat="server" Enabled="true" TargetControlID="rangevalFax">
                                          </cc3:ValidatorCalloutExtender> 
                            <asp:RegularExpressionValidator ID="revFax" runat="server" 
                              ErrorMessage="The number shoud be 11 digits" ControlToValidate="txtFax" 
                              ValidationExpression="\d{11}" ValidationGroup="EditData">*</asp:RegularExpressionValidator>
                               <cc3:ValidatorCalloutExtender ID="valcalextnrevFax" runat="server" Enabled="true" TargetControlID="revFax">
                                          </cc3:ValidatorCalloutExtender>                                       
                      </td>
                      </tr>                                                                                     
                      <tr>
                      <td class="adminform" align="right">Website</td>
                      <td align="center">:</td>
                      <td>
                      <asp:TextBox ID="txtWebsite" runat="server" Width="188px" ></asp:TextBox>                      
                          <asp:RegularExpressionValidator ID="revWebsite" runat="server" 
                              ControlToValidate="txtWebsite" ErrorMessage="Please enter valid URL. Eg:http://www.justcalluz.com" 
                              ValidationExpression="http(s)?://([\w-]+\.)+[\w-]+(/[\w- ./?%&amp;=]*)?" 
                              ValidationGroup="EditData">*</asp:RegularExpressionValidator>
                              <cc3:ValidatorCalloutExtender ID="ValidatorCalloutExtender36" runat="server" Enabled="true" TargetControlID="revWebsite">
                                          </cc3:ValidatorCalloutExtender>   
                      </td>
                      </tr>                                        
                      </table>                      
                            </ContentTemplate>
                        </asp:UpdatePanel>   
                     </td>
                  </tr>
                  <tr>              
                      <td align="center" colspan="2">
                      <asp:Button ID="btnSubmit" runat="server" Text="Update Data" 
                              style="height: 26px" ValidationGroup="EditData" onclick="btnSubmit_Click" 
                              /> &nbsp; &nbsp; &nbsp; &nbsp; 
                                               
                      </td>
                      
                  </tr>
                  </table></td>
                  </tr>
                  <tr>
                      <td colspan="2" align="center" class="style40">
                         <asp:Label ID="lblImageUploadStatus" runat="server" Visible="false"></asp:Label>
                          <asp:Label ID="lblLogouploadStatus" runat="server" Visible="false"></asp:Label>
                          <asp:Label ID="lblVedioAudioUploadStatus" runat="server" Visible="false"></asp:Label>
                      </td>
                      
                  </tr>
                   <tr>
                      <td colspan="2">
                        <table width="100%">
                            <tr>
                                <td class="adminform" >
                                   To upload Logo
                                </td>
                                <td>:</td>
                                <td>
                                    <asp:FileUpload ID="uploadLogo" runat="server" /><br />
                                    <asp:CustomValidator ID="cvLogo" runat="server" 
                                                    ErrorMessage="CV" ControlToValidate="uploadLogo" ValidateEmptyText="true" Display="Dynamic" 
                                                    onservervalidate="CVLogoUpload_ServerValidate" ValidationGroup="Logo"></asp:CustomValidator>
                                </td>
                                <td>
                                    <asp:Button ID="btnUploadLogo" runat="server" Text="Upload Logo" 
                                        onclick="btnUploadLogo_Click" ValidationGroup="Logo" /></td>
                            </tr>
                            <tr>
                            <td colspan="4"></td>
                            </tr>
                            <tr>
                            <td colspan="2"></td>
                            <td colspan="2">
                                <asp:DataList ID="ddlLogo" runat="server" RepeatDirection="Horizontal">
                                    <ItemTemplate>                                     
                                        <asp:Image ID="ImgLogo" runat="server" Width="100px" Height="75px" ImageUrl='<%# Eval("ImageName", "~/Logos\\{0}") %>' />                                                                              
                                    </ItemTemplate>                                   
                                </asp:DataList>
                                <asp:Label ID="lblNoLogo" runat="server" ForeColor="Green"></asp:Label>
                            </td>
                            </tr>
                            <tr id="trUploadPhoto" runat="server">
                                <td class="adminform" >
                                  To upload Photos for
                                </td>
                                <td>:</td>
                                <td>
                                    <table>
                                    <tr><td>
                                    <asp:FileUpload ID="uploadPhotos" runat="server" /><br />
                                    <asp:CustomValidator ID="CVImgUpload" runat="server" 
                                                    ErrorMessage="CV" ControlToValidate="uploadPhotos" ValidateEmptyText="true" Display="Dynamic" 
                                                    onservervalidate="CVImgUpload_ServerValidate" ValidationGroup="Photos"></asp:CustomValidator>
                                  </td>
                                  </tr>
                                  <tr><td>
                                    <asp:TextBox ID="txtCaption" runat="server"></asp:TextBox>
                                    <cc3:TextBoxWatermarkExtender ID="txtExtenderCaption" runat="server" TargetControlID="txtCaption" WatermarkText="Enter Caption for Image">
                                    </cc3:TextBoxWatermarkExtender>
                                    </td></tr></table>
                                </td>
                                <td>
                                    <asp:Button ID="btnUploadPhotos" runat="server" Text="Upload Photos" 
                                        onclick="btnUploadPhotos_Click" ValidationGroup="Photos" /></td>
                            </tr>
                            <tr id="trdisplayPhotos" runat="server">
                            <td colspan="2"></td>
                            <td colspan="2">
                                <asp:DataList ID="dlPhotos" runat="server" RepeatDirection="Horizontal">
                                    <ItemTemplate>     
                                    <table>
                                        <tr>
                                            <td align="center">
                                                <asp:Label ID="lblCaption" runat="server" Text='<%#Eval("Caption")%>'></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <asp:Image ID="ImgPhoto" runat="server" Width="100px" Height="75px" ImageUrl='<%# Eval("PhotoName", "~/Photos\\{0}") %>' />                                                                             
                                            </td>
                                        </tr>
                                        <tr>
                                            <td align="center">
                                                <asp:LinkButton ID="lnkDelete" runat="server" OnCommand="lnkPhotoDelete" CommandArgument='<%#Eval("id")%>' ForeColor="Blue" OnClientClick="return confirm('Are you sure to delete this Photo?')">Delete</asp:LinkButton>                                               
                                            </td>
                                        </tr>
                                         <tr>
                                            <td align="center">
                                                <asp:LinkButton ID="lnkbtnChange" runat="server" OnCommand="lnkPhotoChangeCaption" CommandArgument='<%#Eval("id")%>' ForeColor="Blue">Change/Add Caption</asp:LinkButton>                                               
                                            </td>
                                        </tr>
                                    </table>                                                                        
                                    </ItemTemplate>                                                                                              
                                </asp:DataList>
                                <asp:Label ID="lblNoPhotos" runat="server" ForeColor="Green"></asp:Label>
                            </td>
                            </tr>
                            <tr>
                            <td colspan="4">
                                <asp:Label ID="lblException" runat="server"></asp:Label></td>
                            </tr>
                            <%--<tr id="trUploadVedio" runat="server">
                                <td class="adminform" >
                                    To upload Vedios
                                </td>
                                <td>:</td>
                                <td>
                                    <asp:FileUpload ID="uploadVedios" runat="server" />
                                    <br />
                                    <asp:CustomValidator ID="CVVideoUpload" runat="server" ErrorMessage="CV" ValidateEmptyText="true" 
                                                    ControlToValidate="uploadVedios" Display="Dynamic" 
                                                    onservervalidate="CVVideoUpload_ServerValidate" ValidationGroup="Video"></asp:CustomValidator>
                                </td>
                                <td>
                                    <asp:Button ID="btnUploadVedios" runat="server" Text="Upload Vedios" 
                                        onclick="btnUploadVedios_Click" ValidationGroup="Video" /></td>
                            </tr>
                            <%--<tr id="trVedioDisplay" runat="server">
                            <td colspan="2"></td>
                            <td colspan="2">
                                                                                                                                
                                <object type="video/x-ms-wmv" data="<%=swfFileName%>" width="420" height="340">
   <param name="url" value="<%=swfFileName%>"/>
   <param name="src" value="<%=swfFileName%>" />
   <param name="autostart" value="false" />
   <param name="sound" value="false" />
   <param name="controller" value="true" />
   <embed id='embed1' src="<%=swfFileName%>" runat="server" name='mediaPlayer' type='application/x-mplayer2' pluginspage='http://microsoft.com/windows/mediaplayer/en/download/'  displaysize='4' autosize='-1' bgcolor='darkblue' showcontrols='true' showtracker='-1' showdisplay='0' showstatusbar='-1' videoborder3d='-1' width='500' height='405'  designtimesp='5311' loop='false'>
  </embed>
</object>
 <br />
                                <asp:Label ID="lblNoVideos" runat="server" ForeColor="Green"></asp:Label>
                            </td>
                            </tr>--%>
                        </table>
                      </td>                      
                  </tr>
                  <tr id="trMoreInfo" runat="server">
                  <td width="100%" colspan="2">
                    <table width="100%" id="HRO">
                        <tr><td class="style41"><span style="font-size:large; font-weight:bold">More Information</span></td></tr>
                        <tr><td height="10px"></td></tr>
                        <tr>
                            <td>
                                 <table width="100%">
                                 
                                    <tr><td colspan="3" class="adminform" ><span style="font-size:15px; font-weight:bold">Hours Of Operation</span></td></tr>
                                    <tr><td height="5px" colspan="3"></td></tr>
                                  <tr>
                                  <td class="adminform" >Monday</td>
                                  <td align="center">:</td>
                                  <td>
                                  <updatepanel>
                                      <asp:DropDownList ID="ddlMonday" runat="server" AutoPostBack="true">
                                      <asp:ListItem Value="Select">Select</asp:ListItem> 
                                      <asp:ListItem Value="Holiday">Holiday</asp:ListItem>
                                      <asp:ListItem Value="Open 24Hrs">Open 24Hrs</asp:ListItem>
                                      <asp:ListItem Value="Time Duration">Time Duration</asp:ListItem>
                                      </asp:DropDownList>
                                     
                                      <%--<asp:RequiredFieldValidator ID="rfvMon" runat="server" 
                                          ControlToValidate="ddlMonday" ErrorMessage="Please select any one" 
                                          InitialValue="Select" SkinID="Select" ValidationGroup="HRO">*</asp:RequiredFieldValidator>--%>
                                  </td>
                                  </tr>
                                  <tr id="trMonDur" runat="server">
                                      <td colspan="2"></td>
                                      <td valign="middle">
                                      
                                          <asp:DropDownList ID="ddlMonHrFr" runat="server" Width="50px">
                                          </asp:DropDownList>&nbsp;:&nbsp;
                                           <asp:DropDownList ID="ddlMonMinFr" runat="server"  Width="50px">
                                          </asp:DropDownList>&nbsp;
                                          <asp:DropDownList ID="ddlMonType1" runat="server"  Width="50px">
                                          <asp:ListItem>am</asp:ListItem>
                                          <asp:ListItem>pm</asp:ListItem>
                                          </asp:DropDownList>
                                          &nbsp;&nbsp;-&nbsp;&nbsp;
                                          <asp:DropDownList ID="ddlMonHrT" runat="server" Width="50px">
                                          </asp:DropDownList>&nbsp;:&nbsp;
                                          <asp:DropDownList ID="ddlMonMinT" runat="server" Width="50px">
                                          </asp:DropDownList>&nbsp;
                                          <asp:DropDownList ID="ddlMonType2" runat="server" Width="50px">
                                          <asp:ListItem>am</asp:ListItem>
                                          <asp:ListItem>pm</asp:ListItem>
                                          </asp:DropDownList>                                                                             
                                          &nbsp;<asp:LinkButton ID="lnkMonTimings" runat="server" ForeColor="Red" 
                                              onclick="lnkMonTimings_Click">Add Timings</asp:LinkButton>
                                          <asp:Label ID="lblLnkMon" runat="server" Visible="false"></asp:Label>
                                      </td>
                                  </tr>
                                  <tr id="trLstMon" runat="server">
                                    <td colspan="2"></td>
                                    <td valign="middle">
                                    <table><tr><td>
                                     <asp:Literal ID="ltrMonTime" runat="server"></asp:Literal>   
                                     <asp:LinkButton ID="lnkBtnClearMonTimings" runat="server" ForeColor="Red" onclick="lnkBtnClearMonTimings_Click"
                                             >Clear Timings</asp:LinkButton>                                 
                                    </td>
                                    <td>
                                           <asp:Label ID="lblMonTime" runat="server" Visible="false"></asp:Label>
                                    </td></tr></table>                                                                    
                                      </td>
                                  </tr>
                                  <tr>
                                  <td class="adminform">Tuesday</td>
                                  <td align="center">:</td>
                                  <td>
                                      <asp:DropDownList ID="ddlTuesday" runat="server" AutoPostBack="true">
                                      <asp:ListItem Value="Select">Select</asp:ListItem> 
                                      <asp:ListItem Value="Holiday">Holiday</asp:ListItem> 
                                      <asp:ListItem Value="Open 24Hrs">Open 24Hrs</asp:ListItem>
                                      <asp:ListItem Value="Time Duration">Time Duration</asp:ListItem>
                                      </asp:DropDownList>
                                      <%--<asp:RequiredFieldValidator ID="rfvTues" runat="server" 
                                          ControlToValidate="ddlTuesday" ErrorMessage="Please select any one" 
                                          InitialValue="Select" ValidationGroup="HRO">*</asp:RequiredFieldValidator>--%>
                                  </td>
                                  </tr>                                  
                                  <tr id="trTuesDur" runat="server">
                                      <td colspan="2"></td>
                                      <td valign="middle">
                                          <asp:DropDownList ID="ddlTuesHrFr" runat="server" Width="50px">
                                          </asp:DropDownList>&nbsp;:&nbsp;
                                           <asp:DropDownList ID="ddlTuesMinFr" runat="server"  Width="50px">
                                          </asp:DropDownList>&nbsp;
                                          <asp:DropDownList ID="ddlTuesType1" runat="server"  Width="50px">
                                          <asp:ListItem>am</asp:ListItem>
                                          <asp:ListItem>pm</asp:ListItem>
                                          </asp:DropDownList>
                                          &nbsp;&nbsp;-&nbsp;&nbsp;
                                          <asp:DropDownList ID="ddlTuesHrT" runat="server" Width="50px">
                                          </asp:DropDownList>&nbsp;:&nbsp;
                                          <asp:DropDownList ID="ddlTuesMinT" runat="server" Width="50px">
                                          </asp:DropDownList>&nbsp;
                                          <asp:DropDownList ID="ddlTuesType2" runat="server" Width="50px">
                                          <asp:ListItem>am</asp:ListItem>
                                          <asp:ListItem>pm</asp:ListItem>
                                          </asp:DropDownList>
                                          &nbsp;<asp:LinkButton ID="lnkTuesTimings" runat="server" ForeColor="Red" 
                                              onclick="lnkTuesTimings_Click">Add Timings</asp:LinkButton>
                                          <asp:Label ID="lblLnkTues" runat="server" Visible="false"></asp:Label>                                          
                                      </td>
                                  </tr>
                                  <tr id="trLstTues" runat="server">
                                    <td colspan="2"></td>
                                    <td valign="middle">
                                    <table><tr><td>
                                     <asp:Literal ID="ltrTuesTime" runat="server"></asp:Literal>   
                                     <asp:LinkButton ID="lnkBtnClearTuesTimings" runat="server" ForeColor="Red" onclick="lnkBtnClearTuesTimings_Click"
                                             >Clear Timings</asp:LinkButton>                                 
                                    </td>
                                    <td>
                                           <asp:Label ID="lblTuesTime" runat="server" Visible="false"></asp:Label>
                                    </td></tr></table>                                                                    
                                      </td>
                                  </tr>
                                  <tr>
                                  <td class="adminform">Wednesday</td>
                                  <td align="center">:</td>
                                  <td>
                                      <asp:DropDownList ID="ddlWednesday" runat="server" AutoPostBack="true">
                                      <asp:ListItem Value="Select">Select</asp:ListItem>
                                      <asp:ListItem Value="Holiday">Holiday</asp:ListItem>  
                                      <asp:ListItem Value="Open 24Hrs">Open 24Hrs</asp:ListItem>
                                      <asp:ListItem Value="Time Duration">Time Duration</asp:ListItem>
                                      </asp:DropDownList>
                                      <%--<asp:RequiredFieldValidator ID="rfvWed" runat="server" 
                                          ControlToValidate="ddlWednesday" ErrorMessage="Please select any one" 
                                          InitialValue="Select" ValidationGroup="HRO">*</asp:RequiredFieldValidator>--%>
                                  </td>
                                  </tr>
                                  <tr id="trWedDur" runat="server">
                                      <td colspan="2"></td>
                                      <td valign="middle">
                                          <asp:DropDownList ID="ddlWedHrFr" runat="server" Width="50px">
                                          </asp:DropDownList>&nbsp;:&nbsp;
                                           <asp:DropDownList ID="ddlWedMinFr" runat="server"  Width="50px">
                                          </asp:DropDownList>&nbsp;
                                          <asp:DropDownList ID="ddlWedType1" runat="server"  Width="50px">
                                          <asp:ListItem>am</asp:ListItem>
                                          <asp:ListItem>pm</asp:ListItem>
                                          </asp:DropDownList>
                                          &nbsp;&nbsp;-&nbsp;&nbsp;
                                          <asp:DropDownList ID="ddlWedHrT" runat="server" Width="50px">
                                          </asp:DropDownList>&nbsp;:&nbsp;
                                          <asp:DropDownList ID="ddlWedMinT" runat="server" Width="50px">
                                          </asp:DropDownList>&nbsp;
                                          <asp:DropDownList ID="ddlWedType2" runat="server" Width="50px">
                                          <asp:ListItem>am</asp:ListItem>
                                          <asp:ListItem>pm</asp:ListItem>
                                          </asp:DropDownList>
                                          &nbsp;<asp:LinkButton ID="lnkWedTimings" runat="server" ForeColor="Red" onclick="lnkWedTimings_Click" 
                                             >Add Timings</asp:LinkButton>
                                          <asp:Label ID="lblLnkWed" runat="server" Visible="false"></asp:Label>                                          
                                      </td>
                                  </tr>
                                  <tr id="trLstWed" runat="server">
                                    <td colspan="2"></td>
                                    <td valign="middle">
                                    <table><tr><td>
                                     <asp:Literal ID="ltrWedTime" runat="server"></asp:Literal>       
                                     <asp:LinkButton ID="lnkBtnClearWedTimings" runat="server" ForeColor="Red" onclick="lnkBtnClearWedTimings_Click"
                                             >Clear Timings</asp:LinkButton>                             
                                    </td>
                                    <td>
                                           <asp:Label ID="lblWedTime" runat="server" Visible="false"></asp:Label>
                                    </td></tr></table>                                                                    
                                      </td>
                                  </tr>
                                  <tr>
                                  <td class="adminform">Thursday</td>
                                  <td align="center">:</td>
                                  <td>
                                      <asp:DropDownList ID="ddlThursday" runat="server" AutoPostBack="true">
                                      <asp:ListItem Value="Select">Select</asp:ListItem>
                                      <asp:ListItem Value="Holiday">Holiday</asp:ListItem>  
                                      <asp:ListItem Value="Open 24Hrs">Open 24Hrs</asp:ListItem>
                                      <asp:ListItem Value="Time Duration">Time Duration</asp:ListItem>
                                      </asp:DropDownList>
                                      <%--<asp:RequiredFieldValidator ID="rfvThurs" runat="server" 
                                          ControlToValidate="ddlThursday" ErrorMessage="Please select any one" 
                                          InitialValue="Select" ValidationGroup="HRO">*</asp:RequiredFieldValidator>--%>
                                  </td>
                                  </tr>
                                  <tr id="trThursDur" runat="server">
                                      <td colspan="2"></td>
                                      <td valign="middle">
                                          <asp:DropDownList ID="ddlThursHrFr" runat="server" Width="50px">
                                          </asp:DropDownList>&nbsp;:&nbsp;
                                           <asp:DropDownList ID="ddlThursMinFr" runat="server"  Width="50px">
                                          </asp:DropDownList>&nbsp;
                                          <asp:DropDownList ID="ddlThursType1" runat="server"  Width="50px">
                                          <asp:ListItem>am</asp:ListItem>
                                          <asp:ListItem>pm</asp:ListItem>
                                          </asp:DropDownList>
                                          &nbsp;&nbsp;-&nbsp;&nbsp;
                                          <asp:DropDownList ID="ddlThursHrT" runat="server" Width="50px">
                                          </asp:DropDownList>&nbsp;:&nbsp;
                                          <asp:DropDownList ID="ddlThursMinT" runat="server" Width="50px">
                                          </asp:DropDownList>&nbsp;
                                          <asp:DropDownList ID="ddlThursType2" runat="server" Width="50px">
                                          <asp:ListItem>am</asp:ListItem>
                                          <asp:ListItem>pm</asp:ListItem>
                                          </asp:DropDownList>
                                          &nbsp;<asp:LinkButton ID="lnkThursTimings" runat="server" ForeColor="Red" onclick="lnkThursTimings_Click" 
                                             >Add Timings</asp:LinkButton>
                                          <asp:Label ID="lblLnkThurs" runat="server" Visible="false"></asp:Label>                                          
                                      </td>
                                  </tr>
                                  <tr id="trLstThurs" runat="server">
                                    <td colspan="2"></td>
                                    <td valign="middle">
                                    <table><tr><td>
                                     <asp:Literal ID="ltrThursTime" runat="server"></asp:Literal>
                                     <asp:LinkButton ID="lnkBtnClearThursTimings" runat="server" ForeColor="Red" onclick="lnkBtnClearThursTimings_Click"
                                             >Clear Timings</asp:LinkButton>                                    
                                    </td>
                                    <td>
                                           <asp:Label ID="lblThursTime" runat="server" Visible="false"></asp:Label>
                                    </td></tr></table>                                                                    
                                      </td>
                                  </tr>
                                  <tr>
                                  <td class="adminform">Friday</td>
                                  <td align="center">:</td>
                                  <td>
                                      <asp:DropDownList ID="ddlFriday" runat="server" AutoPostBack="true">
                                      <asp:ListItem Value="Select">Select</asp:ListItem> 
                                      <asp:ListItem Value="Holiday">Holiday</asp:ListItem> 
                                      <asp:ListItem Value="Open 24Hrs">Open 24Hrs</asp:ListItem>
                                      <asp:ListItem Value="Time Duration">Time Duration</asp:ListItem>
                                      </asp:DropDownList>
                                      <%--<asp:RequiredFieldValidator ID="rfvFri" runat="server" 
                                          ControlToValidate="ddlFriday" ErrorMessage="Please select any one" 
                                          InitialValue="Select" ValidationGroup="HRO">*</asp:RequiredFieldValidator>--%>
                                  </td>
                                  </tr>
                                  <tr id="trFriDur" runat="server">
                                      <td colspan="2"></td>
                                      <td valign="middle">
                                          <asp:DropDownList ID="ddlFriHrFr" runat="server" Width="50px">
                                          </asp:DropDownList>&nbsp;:&nbsp;
                                           <asp:DropDownList ID="ddlFriMinFr" runat="server"  Width="50px">
                                          </asp:DropDownList>&nbsp;
                                          <asp:DropDownList ID="ddlFriType1" runat="server"  Width="50px">
                                          <asp:ListItem>am</asp:ListItem>
                                          <asp:ListItem>pm</asp:ListItem>
                                          </asp:DropDownList>
                                          &nbsp;&nbsp;-&nbsp;&nbsp;
                                          <asp:DropDownList ID="ddlFriHrT" runat="server" Width="50px">
                                          </asp:DropDownList>&nbsp;:&nbsp;
                                          <asp:DropDownList ID="ddlFriMinT" runat="server" Width="50px">
                                          </asp:DropDownList>&nbsp;
                                          <asp:DropDownList ID="ddlFriType2" runat="server" Width="50px">
                                          <asp:ListItem>am</asp:ListItem>
                                          <asp:ListItem>pm</asp:ListItem>
                                          </asp:DropDownList>
                                          &nbsp;<asp:LinkButton ID="lnkFriTimings" runat="server" ForeColor="Red" onclick="lnkFriTimings_Click" 
                                             >Add Timings</asp:LinkButton>
                                          <asp:Label ID="lblLnkFri" runat="server" Visible="false"></asp:Label>                                          
                                      </td>
                                  </tr>
                                  <tr id="trLstFri" runat="server">
                                    <td colspan="2"></td>
                                    <td valign="middle">
                                    <table><tr><td>
                                     <asp:Literal ID="ltrFriTime" runat="server"></asp:Literal>     
                                     <asp:LinkButton ID="lnkBtnClearFriTimings" runat="server" ForeColor="Red" onclick="lnkBtnClearFriTimings_Click"
                                             >Clear Timings</asp:LinkButton>                               
                                    </td>
                                    <td>
                                           <asp:Label ID="lblFriTime" runat="server" Visible="false"></asp:Label>
                                    </td></tr></table>                                                                    
                                      </td>
                                  </tr>
                                  <tr>
                                  <td class="adminform">Saturday</td>
                                  <td align="center">:</td>
                                  <td>
                                      <asp:DropDownList ID="ddlSaturday" runat="server" AutoPostBack="true">
                                      <asp:ListItem Value="Select">Select</asp:ListItem>
                                      <asp:ListItem Value="Holiday">Holiday</asp:ListItem>  
                                      <asp:ListItem Value="Open 24Hrs">Open 24Hrs</asp:ListItem>
                                      <asp:ListItem Value="Time Duration">Time Duration</asp:ListItem>
                                      </asp:DropDownList>
                                      <%--<asp:RequiredFieldValidator ID="rfvSat" runat="server" 
                                          ControlToValidate="ddlSaturday" ErrorMessage="Please select any one" 
                                          InitialValue="Select" ValidationGroup="HRO">*</asp:RequiredFieldValidator>--%>
                                  </td>
                                  </tr>
                                  <tr id="trSatDur" runat="server">
                                      <td colspan="2"></td>
                                      <td valign="middle">
                                          <asp:DropDownList ID="ddlSaturHrFr" runat="server" Width="50px">
                                          </asp:DropDownList>&nbsp;:&nbsp;
                                           <asp:DropDownList ID="ddlSaturMinFr" runat="server"  Width="50px">
                                          </asp:DropDownList>&nbsp;
                                          <asp:DropDownList ID="ddlSaturType1" runat="server"  Width="50px">
                                          <asp:ListItem>am</asp:ListItem>
                                          <asp:ListItem>pm</asp:ListItem>
                                          </asp:DropDownList>
                                          &nbsp;&nbsp;-&nbsp;&nbsp;
                                          <asp:DropDownList ID="ddlSaturHrT" runat="server" Width="50px">
                                          </asp:DropDownList>&nbsp;:&nbsp;
                                          <asp:DropDownList ID="ddlSaturMinT" runat="server" Width="50px">
                                          </asp:DropDownList>&nbsp;
                                          <asp:DropDownList ID="ddlSaturType2" runat="server" Width="50px">
                                          <asp:ListItem>am</asp:ListItem>
                                          <asp:ListItem>pm</asp:ListItem>
                                          </asp:DropDownList>
                                          &nbsp;<asp:LinkButton ID="lnkSaturTimings" runat="server" ForeColor="Red" onclick="lnkSaturTimings_Click" 
                                             >Add Timings</asp:LinkButton>
                                          <asp:Label ID="lblLnkSatur" runat="server" Visible="false"></asp:Label>                                          
                                      </td>
                                  </tr> 
                                  <tr id="trLstSatur" runat="server">
                                    <td colspan="2"></td>
                                    <td valign="middle">
                                    <table><tr><td>
                                     <asp:Literal ID="ltrSaturTime" runat="server"></asp:Literal>
                                      <asp:LinkButton ID="lnkBtnClearSatTimings" runat="server" ForeColor="Red" onclick="lnkBtnClearSatTimings_Click"
                                             >Clear Timings</asp:LinkButton>                                   
                                    </td>
                                    <td>
                                           <asp:Label ID="lblSaturTime" runat="server" Visible="false"></asp:Label>
                                    </td></tr></table>                                                                   
                                      </td>
                                  </tr>                                                                                  
                                  <tr>
                                  <td class="adminform">Sunday</td>
                                  <td align="center">:</td>
                                  <td>
                                      <asp:DropDownList ID="ddlSunday" runat="server" AutoPostBack="true">
                                      <asp:ListItem Value="Select">Select</asp:ListItem>
                                      <asp:ListItem Value="Holiday">Holiday</asp:ListItem>  
                                      <asp:ListItem Value="Open 24Hrs">Open 24Hrs</asp:ListItem>
                                      <asp:ListItem Value="Time Duration">Time Duration</asp:ListItem>
                                      </asp:DropDownList>
                                      </updatepanel>
                                      <%--<asp:RequiredFieldValidator ID="rfvSun" runat="server" 
                                          ControlToValidate="ddlSunday" ErrorMessage="RequiredFieldValidator" 
                                          InitialValue="Select" ValidationGroup="HRO">*</asp:RequiredFieldValidator>--%>
                                  </td>
                                  </tr>
                                  <tr id="trSunDur" runat="server">
                                      <td colspan="2"></td>
                                      <td valign="middle">
                                          <asp:DropDownList ID="ddlSunHrFr" runat="server" Width="50px">
                                          </asp:DropDownList>&nbsp;:&nbsp;
                                           <asp:DropDownList ID="ddlSunMinFr" runat="server"  Width="50px">
                                          </asp:DropDownList>&nbsp;
                                          <asp:DropDownList ID="ddlSunType1" runat="server"  Width="50px">
                                          <asp:ListItem>am</asp:ListItem>
                                          <asp:ListItem>pm</asp:ListItem>
                                          </asp:DropDownList>
                                          &nbsp;&nbsp;-&nbsp;&nbsp;
                                          <asp:DropDownList ID="ddlSunHrT" runat="server" Width="50px">
                                          </asp:DropDownList>&nbsp;:&nbsp;
                                          <asp:DropDownList ID="ddlSunMinT" runat="server" Width="50px">
                                          </asp:DropDownList>&nbsp;
                                          <asp:DropDownList ID="ddlSunType2" runat="server" Width="50px">
                                          <asp:ListItem>am</asp:ListItem>
                                          <asp:ListItem>pm</asp:ListItem>
                                          </asp:DropDownList>
                                          &nbsp;<asp:LinkButton ID="lnkSunTimings" runat="server" ForeColor="Red" onclick="lnkSunTimings_Click" 
                                             >Add Timings</asp:LinkButton>
                                          <asp:Label ID="lblLnkSun" runat="server" Visible="false"></asp:Label>                                          
                                      </td>
                                  </tr>
                                  <tr id="trLstSun" runat="server">
                                    <td colspan="2"></td>
                                    <td valign="middle">
                                    <table><tr><td>
                                     <asp:Literal ID="ltrSunTime" runat="server"></asp:Literal>   
                                     <asp:LinkButton ID="lnkBtnClearSuntimings" runat="server" ForeColor="Red" onclick="lnkBtnClearSuntimings_Click"
                                             >Clear Timings</asp:LinkButton>                                 
                                    </td>
                                    <td>
                                           <asp:Label ID="lblSunTime" runat="server" Visible="false"></asp:Label>
                                    </td></tr></table>                                                                   
                                      </td>
                                  </tr>
                                  <tr><td height="5px"></td></tr>
                                  <tr><td colspan="3" class="adminform"><span style="font-size:15px; font-weight:bold">Payment Modes</span></td></tr>
                                  <tr id="trPayment" runat="server">
                                      <td colspan="2"></td>
                                      <td valign="middle">
                                          <asp:ListBox ID="lstBoxPayment" runat="server" SelectionMode="Multiple">                                           
                                          </asp:ListBox>
                                      </td>
                                  </tr>
                                  <tr><td colspan="3" class="adminform"><span style="font-size:15px; font-weight:bold">Additional Information</span></td></tr>
                                  <tr id="trAddInfo" runat="server">
                                      <td colspan="2"></td>
                                      <td valign="middle">
                                          <asp:TextBox ID="txtAdtInfo" runat="server" TextMode="MultiLine"></asp:TextBox>
                                      </td>
                                  </tr>
                                  <tr><td colspan="3" class="adminform"><span style="font-size:15px; font-weight:bold">Company Information</span></td></tr>
                                  <tr><td height="5px" colspan="3"></td></tr>
                                  <tr id="trYrEstab" runat="server">
                                      <td colspan="2" class="adminform">Year Established</td>
                                      <td valign="middle">
                                          <asp:DropDownList ID="ddlYearEstab" runat="server">                                          
                                          </asp:DropDownList>
                                      </td>
                                  </tr>
                                  <tr id="trProfAssoc" runat="server">
                                      <td colspan="2" class="adminform">Professional Associations</td>
                                      <td valign="middle">
                                          <asp:TextBox ID="txtProf_Assoc" runat="server"></asp:TextBox>
                                      </td>
                                  </tr>
                                  <tr id="trCertif" runat="server">
                                      <td colspan="2" class="adminform">Certifications</td>
                                      <td valign="middle">
                                          <asp:TextBox ID="txtCertifi" runat="server"></asp:TextBox>
                                      </td>
                                  </tr>
                                  <tr id="trNoofEmp" runat="server">
                                      <td colspan="2" class="adminform">No. of Employees</td>
                                      <td valign="middle">
                                          <asp:DropDownList ID="ddlNoofEmp" runat="server">
                                          <asp:ListItem>Select No of Employees</asp:ListItem>
                                          <asp:ListItem>1-10</asp:ListItem>
                                          <asp:ListItem>10-100</asp:ListItem>
                                          
                                          </asp:DropDownList>
                                      </td>
                                  </tr>
                                  <tr><td height="7px" colspan="3"></td></tr>
                                  <tr>
                                    <td colspan="3" align="center">
                                        <asp:Button ID="btnAddMoreInfo" runat="server" Text="To Add More Info" 
                                            onclick="btnAddMoreInfo_Click" ValidationGroup="HRO" />&nbsp; &nbsp;
                                        <asp:Button ID="btnUpdateMoreInfo" runat="server" Text="Update More Info" 
                                            onclick="btnUpdateMoreInfo_Click" ValidationGroup="HRO" />&nbsp; &nbsp;
                                        <asp:Button ID="btnSkip" runat="server" Text="Skip" onclick="btnSkip_Click" />
                                  </tr>
                                </table>
                            </td>
                        </tr>
                         <tr><td>
           <input id="btnDummy" runat="server" type="button" style="display: none;" />
        </td></tr>
            <tr>            
            <td>  
            <AjaxToolkit:ModalPopupExtender ID="ModalPopupExtender1" runat="server"  
         PopupControlID="modpopup1" BackgroundCssClass="modalBackground" TargetControlID="btnDummy"
        OkControlID="btnDummy" CancelControlID="btnDummy" BehaviorID="mpeBehavior"
        DropShadow="false" PopupDragHandleControlID="panel4"></AjaxToolkit:ModalPopupExtender>    
            <asp:Panel ID="modpopup1" runat="server" Width="430px" Height="276px">
        <fieldset style="width: 402px">
            <asp:Panel ID="Panel4" runat="server">
            </asp:Panel>             
             <table align="center" width="400" style="background:Green; height: 184px;" >               
               <tr style="background-color:Green;">
                    <td style="width:400px" align="center">                                       
                        <asp:Label ID="lblId" runat="server" Visible="false"></asp:Label>
                       <asp:TextBox ID="txtCaptionNew" runat="server" ></asp:TextBox> 
                    </td>
                    </tr>
               <tr>                     
                    <td align="center" class="style4">
                        <asp:Button ID="submitbutton" runat="server" Text="Change Caption" 
                            ValidationGroup="modal" CausesValidation="true" 
                            onclick="submitbutton_Click"/>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="cancelbutton" runat="server" Text="Cancel" 
                            onclick="cancelbutton_Click" />
                    </td>
                </tr> 
                <tr>
                    <td>
                     <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
                        ShowMessageBox="True" ShowSummary="False" ValidationGroup="modal" />
                    </td>
                </tr>               
            </table>
        </fieldset></asp:Panel>
                        <tr>
                            <td>
                                <table width="100%">
                                     <tr id="tr1" runat="server">
                                      <td></td>
                                      <td valign="middle">                                          
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
                
            </table>   
                          
           </td>
         </tr>
         
       </table>
    </div>
    </form>
</body>
</html>
