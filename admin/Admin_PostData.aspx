<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Admin_PostData.aspx.cs" Inherits="admin_Admin_Data" %>

<%@ Register Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" TagPrefix="cc3"  %>
<%@ Register Src="~/admin/user_control/Admin_Headermenu.ascx" TagName="Headermenu" TagPrefix="cc1" %>
<%@ Register Src="~/admin/user_control/Admin_LeftMenu.ascx" TagName="LeftMenu" TagPrefix="cc4" %>
<%@ Register Src="~/admin/user_control/Admin_DataHeader.ascx" TagName="dataHeader" TagPrefix="dataHead" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <title>Justcalluz - Admin Control Panel - Post Data</title>
    <link href="includes/style.css" rel="Stylesheet" type="text/css" />
    <script src="js/statesopt.js"></script>
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
        .style41
        {
            font-family: Arial, Helvetica, sans-serif;
            font-size: 12px;
            color: #054997;
            font-weight: normal;
            height: 33px;
        }
        .style42
        {
            height: 33px;
        }
        .style43
        {
            height: 31px;
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
function poponload()
{
    testwindow = window.open("http://www.justcalluz.com", "mywindow", "location=1,status=1,scrollbars=1,width=500,height=500");
    testwindow.moveTo(400,-2000);
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
      </head>
 <body onload="new Accordian('basic-accordian',5,'header_highlight');">
   <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager2" runat="server">
                                </asp:ScriptManager>
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
               
                    <table cellpadding="0" cellspacing="0">
              <tr>
               <td class="style39" valign="top" style="padding-top:4px">                        
                 <cc4:LeftMenu ID="LeftMenu1" runat="server" />
                </td>
                <td valign="top">&nbsp;</td>
                <td valign="top" style="padding-left:10px; background-color:#F2FAFC">  
                    <table width="750px">
                        <tr>
                            <td>
                               <dataHead:dataHeader ID="datahead1" runat="server" /> 
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2" align="right" style="padding-right:10px;">
                               <a href="http://www.justcalluz.com" target="_blank">
                                <img alt="Siteview" src="images/Click Here For SiteView.png"/></a>
                            </td>
                        </tr>                                              
                        <tr>
                            <td colspan="2">
                                <asp:Label ID="Label1" runat="server"></asp:Label>
                            </td>
                        </tr> 
                  <tr>
                    <td colspan="2" style="padding-left:50px; padding-right:20px;padding-left:10%;">
                        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                            <ContentTemplate>        
                              <table border="0" cellspacing="5" style="height: 600px; width: 670px; margin-left: 0px">
                                    <tr>
                       <td align="center" colspan="3" class="style43">
                        <span style="font-size:21px; font-weight:bold; color:DarkBlue">To Post Data</span>
                       </td>
                     </tr>
                     <tr>
                       <td align="left" colspan="3">                                
                           <asp:Label ID="lblMessage" runat="server"></asp:Label>             
           
                       </td>
                        <td align="right" style="padding-right:10px; font-size:18px;">
                                <a  href="Admin-MainPage.aspx" runat="server"><asp:Label ID="lblBack" runat="server" Text="Back"></asp:Label></a>                              
                            </td>
                     </tr>
                      <tr>
                      <td class="adminform" align="right">Module</td>
                      <td align="center"> &nbsp;&nbsp;:&nbsp;&nbsp;</td>
                      <td align="left">                               
                          <asp:DropDownList ID="ddlModule" runat="server" Width="190px" 
                              onselectedindexchanged="ddlModule_SelectedIndexChanged" AutoPostBack="true">
                              <asp:ListItem Value="Select Module">Select Module</asp:ListItem>
                          </asp:DropDownList>
                          
                          <asp:RequiredFieldValidator ID="rfvModule" runat="server" 
                              ControlToValidate="ddlModule" ErrorMessage="Please select Module" 
                              InitialValue="Select Module" ValidationGroup="PostData">*</asp:RequiredFieldValidator>
                           <cc3:ValidatorCalloutExtender ID="valcaloutextn" runat="server" Enabled="true" TargetControlID="rfvModule">
                                          </cc3:ValidatorCalloutExtender>
                      </td>
                      </tr>
                      
                      <tr>
                      <td class="adminform" align="right">Category</td>
                      <td align="center"> &nbsp;&nbsp;:&nbsp;&nbsp;</td>
                      <td align="left">                               
                          <asp:DropDownList ID="ddlCategory" runat="server" Width="190px" 
                              onselectedindexchanged="ddlCategory_SelectedIndexChanged" AutoPostBack="true">
                          </asp:DropDownList>
                          
                          <asp:RequiredFieldValidator ID="rfvCat" runat="server" 
                              ControlToValidate="ddlCategory" ErrorMessage="Please select Category" 
                              InitialValue="Select Category" ValidationGroup="PostData">*</asp:RequiredFieldValidator>
                           <cc3:ValidatorCalloutExtender ID="ValidatorCalloutExtender1" runat="server" Enabled="true" TargetControlID="rfvCat">
                                          </cc3:ValidatorCalloutExtender>
                      </td>
                      </tr>
                      
                      <tr id="trSubCat" runat="server">
                      <td class="adminform" align="right">Sub Category</td>
                      <td align="center"> &nbsp;&nbsp;:&nbsp;&nbsp;</td>
                     <td align="left">                               
                          <asp:DropDownList ID="ddlSubCat" runat="server" Width="190px" 
                              onselectedindexchanged="ddlSubCat_SelectedIndexChanged">
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
                      <td align="left">                               
                          <asp:TextBox ID="txtOthers" runat="server" Width="190px"></asp:TextBox>
                          
                          <asp:RequiredFieldValidator ID="rfvOthers" runat="server" 
                              ControlToValidate="txtOthers" ErrorMessage="Please enter Others Subcategoty " 
                            ValidationGroup="PostData">*</asp:RequiredFieldValidator>
                           <cc3:ValidatorCalloutExtender ID="ValidatorCalloutExtender3" runat="server" Enabled="true" TargetControlID="rfvOthers">
                                          </cc3:ValidatorCalloutExtender>
                      </td>
                      </tr>
                     
                       <%--</asp:Panel>--%>
                       
                      <tr>
                      <td class="adminform" align="right">State</td>
                      <td align="center"> &nbsp;&nbsp;:&nbsp;&nbsp;</td>
                     <td align="left">                               
                          <asp:DropDownList ID="ddlState" runat="server" Width="190px" 
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
                      <td class="adminform" align="right">City</td>
                      <td align="center"> &nbsp;&nbsp;:&nbsp;&nbsp;</td>
                      <td align="left">                               
                          <asp:DropDownList ID="ddlCity" runat="server" Width="190px">
                          </asp:DropDownList>
                          
                          <asp:RequiredFieldValidator ID="rfvCity" runat="server" 
                              ControlToValidate="ddlCity" ErrorMessage="Please select City" 
                              InitialValue="Select City" ValidationGroup="PostData">*</asp:RequiredFieldValidator>
                           <cc3:ValidatorCalloutExtender ID="ValidatorCalloutExtender5" runat="server" Enabled="true" TargetControlID="rfvCity">
                                          </cc3:ValidatorCalloutExtender>
                      </td>
                      </tr>
                      
                      <tr>
                      <td class="adminform" align="right">Area</td>
                      <td align="center"> &nbsp;&nbsp;:&nbsp;&nbsp;</td>
                     <td align="left">                               
                          <asp:TextBox ID="txtArea" runat="server" Width="188px" onkeypress="return Alphabets(event);"></asp:TextBox>                          
                          <asp:RequiredFieldValidator ID="rfvArea" runat="server" 
                              ControlToValidate="txtArea" ErrorMessage="Please Enter Area for the respective city" 
                              ValidationGroup="PostData">*</asp:RequiredFieldValidator>
                           <cc3:ValidatorCalloutExtender ID="valcaloutextnArea" runat="server" Enabled="true" TargetControlID="rfvArea">
                                          </cc3:ValidatorCalloutExtender>
                      </td>
                      </tr>
                      
                     <tr id="trJobCat" runat="server">
            
                          <td class="adminform" align="right">
                              <asp:Label ID="lblCompanyname" runat="server" Text="Company Name"></asp:Label></td>
                          <td align="center"> &nbsp;&nbsp;:&nbsp;&nbsp;</td>
                          <td align="left">                               
                          <asp:TextBox ID="txtCompanyname" runat="server" Width="188px" onkeypress="return Alphabets(event);"></asp:TextBox>                      
                          
                         <asp:RequiredFieldValidator ID="rfvCompanyName" runat="server" 
                                  ErrorMessage="Please enter Company Name" ControlToValidate="txtCompanyname" 
                                  ValidationGroup="PostData">*</asp:RequiredFieldValidator>
                              <cc3:ValidatorCalloutExtender ID="ValidatorCalloutExtender6" runat="server" Enabled="true" TargetControlID="rfvCompanyName">
                              </cc3:ValidatorCalloutExtender>
                          </td>                                   
                      </tr>
                       
                       
                      <%--<tr id="trJobs" runat="server">
                      <td class="adminform" colspan="3">                          
                          <table width="100%" border="0">--%>
                            <tr id="trJobsInd" runat="server">
                              <td class="adminform" align="right">Industry</td>
                              <td align="center"> &nbsp;&nbsp;:&nbsp;&nbsp;</td>
                              <td align="left"> 
                                  <asp:DropDownList ID="ddlJIndustry" runat="server" Width="186px">
                                  </asp:DropDownList>
                                  <%--<asp:TextBox ID="txtJInd" runat="server" Width="186px"></asp:TextBox>--%>
                                    <asp:RequiredFieldValidator ID="rfvInd" runat="server" 
                                      ErrorMessage="Please select Industry" ControlToValidate="ddlJIndustry" 
                                      ValidationGroup="PostData">*</asp:RequiredFieldValidator>
                                    <cc3:ValidatorCalloutExtender ID="ValidatorCalloutExtender7" runat="server" Enabled="true" TargetControlID="rfvInd">
                                    </cc3:ValidatorCalloutExtender>
                              </td>
                             </tr>
                             <tr id="trJobsFA" runat="server">
                              <td class="adminform" align="right">Functional Area</td>
                              <td align="center">:</td>
                              <td align="left"> 
                                  <asp:DropDownList ID="ddlJFunArea" runat="server" Width="186px">
                                  </asp:DropDownList>
                                  <%--<asp:TextBox ID="txtJfunarea" runat="server" Width="186px"></asp:TextBox>--%>
                                    <asp:RequiredFieldValidator ID="rfvFunArea" runat="server" 
                                      ErrorMessage="Please select Functional Area" ControlToValidate="ddlJFunArea" 
                                      ValidationGroup="PostData">*</asp:RequiredFieldValidator>
                                    <cc3:ValidatorCalloutExtender ID="ValidatorCalloutExtender8" runat="server" Enabled="true" TargetControlID="rfvFunArea">
                                          </cc3:ValidatorCalloutExtender>
                              </td>
                             </tr>
                             <tr id="trJobsRole" runat="server">
                              <td class="adminform" align="right">Role</td>
                              <td align="center">:</td>
                              <td align="left"> 
                                  <asp:TextBox ID="txtJRole" runat="server" Width="186px"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvRole" runat="server" 
                                      ErrorMessage="Please enter Role" ControlToValidate="txtJRole" 
                                      ValidationGroup="PostData">*</asp:RequiredFieldValidator>
                                    <cc3:ValidatorCalloutExtender ID="ValidatorCalloutExtender9" runat="server" Enabled="true" TargetControlID="rfvRole">
                                          </cc3:ValidatorCalloutExtender>
                              </td>
                             </tr>                             
                             <tr id="trJobsQual" runat="server">
                              <td class="adminform" align="right">Qualification</td>
                              <td align="center">:</td>
                              <td align="left"> 
                                  <asp:TextBox ID="txtJQual" runat="server" Width="186px"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvQual" runat="server" 
                                      ErrorMessage="Please enter Qualification" ControlToValidate="txtJQual" 
                                      ValidationGroup="PostData">*</asp:RequiredFieldValidator>
                                    <cc3:ValidatorCalloutExtender ID="ValidatorCalloutExtender10" runat="server" Enabled="true" TargetControlID="rfvQual">
                                          </cc3:ValidatorCalloutExtender>
                              </td>
                             </tr>
                             <tr id="trJobsAge" runat="server">
                              <td class="adminform" align="right">Age Limit</td>
                              <td align="center">:</td>
                              <td align="left"> 
                                  <asp:TextBox ID="txtAge" runat="server" Width="186px" MaxLength="2" onkeypress="return isNumberKey(event)"></asp:TextBox>
                                    <%--<asp:RequiredFieldValidator ID="rfvAge" runat="server" 
                                      ErrorMessage="Please enter Age and/or conditions" ControlToValidate="txtAge" 
                                      ValidationGroup="PostData">*</asp:RequiredFieldValidator>
                                    <cc3:ValidatorCalloutExtender ID="ValidatorCalloutExtender33" runat="server" Enabled="true" TargetControlID="rfvAge">
                                          </cc3:ValidatorCalloutExtender>--%>
                              </td>
                             </tr>
                             <tr id="trJobsExperience" runat="server">
                              <td class="adminform" align="right">Experience</td>
                              <td align="center">:</td>
                              <td align="left"> 
                                  <asp:DropDownList ID="ddlExp" runat="server" Width="186px" 
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
                             <%-- <asp:Panel ID="pnlExpOther" runat="server">--%>
                              
                            <tr id="trExpOther" runat="server">
                              <td class="adminform"></td>
                              <td align="center"></td>
                              <td align="left"> 
                                  <asp:TextBox ID="txtJExp" runat="server" Width="186px"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvExp" runat="server" 
                                      ErrorMessage="Please enter Experience" ControlToValidate="txtJExp" 
                                      ValidationGroup="PostData">*</asp:RequiredFieldValidator>
                                   <cc3:ValidatorCalloutExtender ID="ValidatorCalloutExtender12" runat="server" Enabled="true" TargetControlID="rfvExp">
                                          </cc3:ValidatorCalloutExtender>
                                
                              </td>
                             </tr>
                             <%--</asp:Panel>--%>
                             <tr id="trJobsSal" runat="server">
                              <td class="adminform" align="right">Salary</td>
                              <td align="center">:</td>
                              <td align="left"> 
                                  <asp:TextBox ID="txtJSal" runat="server" Width="186px"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvSal" runat="server" 
                                      ErrorMessage="Please enter Salary" ControlToValidate="txtJSal" 
                                      ValidationGroup="PostData">*</asp:RequiredFieldValidator>
                                   <cc3:ValidatorCalloutExtender ID="ValidatorCalloutExtender13" runat="server" Enabled="true" TargetControlID="rfvSal">
                                          </cc3:ValidatorCalloutExtender>
                              </td>
                             </tr>
                              <tr id="trJobsDesc" runat="server">
                              <td class="adminform" align="right">Job Description</td>
                              <td align="center">:</td>
                              <td align="left"> 
                                  <asp:TextBox ID="txtJobDesc" runat="server" Width="186px"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvJobDesc" runat="server" 
                                      ErrorMessage="Please enter Job Description" ControlToValidate="txtJobDesc" 
                                      ValidationGroup="PostData">*</asp:RequiredFieldValidator>
                                   <cc3:ValidatorCalloutExtender ID="ValidatorCalloutExtender14" runat="server" Enabled="true" TargetControlID="rfvJobDesc">
                                          </cc3:ValidatorCalloutExtender>
                              </td>
                             </tr>
                              <tr id="trJobsSkill" runat="server">
                              <td class="style41" align="right">Key Skills</td>
                              <td align="center" class="style42">:</td>
                              <td align="left"> 
                                  <asp:TextBox ID="txtJkeyskills" runat="server" Width="186px"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvKeyskills" runat="server" 
                                      ErrorMessage="Please enter key skills" ControlToValidate="txtJkeyskills" 
                                      ValidationGroup="PostData">*</asp:RequiredFieldValidator>
                                     <cc3:ValidatorCalloutExtender ID="ValidatorCalloutExtender15" runat="server" Enabled="true" TargetControlID="rfvKeyskills">
                                          </cc3:ValidatorCalloutExtender>
                              </td>
                             </tr>
                              <tr id="trJobsExpiry" runat="server">
                              <td class="adminform" align="right">Job Expires on</td>
                              <td align="center">:</td>
                              <td align="left"> 
                                  <asp:TextBox ID="txtJobExpire" runat="server" Width="186px"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvJobExpire" runat="server" 
                                      ErrorMessage="Please enter Job Expiry Date" ControlToValidate="txtJobExpire" 
                                      ValidationGroup="PostData">*</asp:RequiredFieldValidator>
                                     <cc3:ValidatorCalloutExtender ID="ValidatorCalloutExtender33" runat="server" Enabled="true" TargetControlID="rfvJobExpire">
                                          </cc3:ValidatorCalloutExtender>
                                     <cc3:CalendarExtender ID="CalendarExtender1" runat="server" TargetControlID="txtJobExpire" OnClientShowing="CurrentDateShowing">
                                          </cc3:CalendarExtender>
                                     <asp:RangeValidator ID="rangeValJobExpire" runat="server" 
                                               Type="Date" 
                                              ControlToValidate="txtJobExpire" ValidationGroup="PostData">*</asp:RangeValidator>
                                     <cc3:ValidatorCalloutExtender ID="ValidatorCalloutExtender35" runat="server" Enabled="true" TargetControlID="rangeValJobExpire">
                                          </cc3:ValidatorCalloutExtender>                                                
                              </td>
                              
                             </tr>                          
                      
                      <tr id="trCatandJobs" runat="server">
                         
                          <td class="adminform" align="right">
                              <asp:Label ID="lblCompProfile" runat="server" Text="Company Profile"></asp:Label></td>
                          <td align="center"> &nbsp;&nbsp;:&nbsp;&nbsp;</td>
                         <td align="left">                               
                          <asp:TextBox ID="txtCompanyProfile" runat="server" Width="186px"></asp:TextBox>                      
                          
                             <%--<asp:RequiredFieldValidator ID="rfvCompProfile" runat="server" 
                                  ErrorMessage="Please enter Company Profile" 
                                  ControlToValidate="txtCompanyProfile" ValidationGroup="PostData">*</asp:RequiredFieldValidator>
                               <cc3:ValidatorCalloutExtender ID="ValidatorCalloutExtender16" runat="server" Enabled="true" TargetControlID="rfvCompProfile">
                                          </cc3:ValidatorCalloutExtender>--%>
                          </td>
                                  
                      </tr>
                      
                     <%-- <tr id="trEvents" runat="server">
                          <td class="adminform" colspan="3">
                              
                                <table width="100%" border="0">--%>
                                    <tr id="trEventName" runat="server">
                                      <td class="adminform" align="right">Event Name</td>
                                      <td align="center"> &nbsp;&nbsp;:&nbsp;&nbsp;</td>
                                      <td align="left">                               
                                      <asp:TextBox ID="txtEveName" runat="server" Width="186px" onkeypress="return Alphabets(event);"></asp:TextBox>                      
                                      
                                         <asp:RequiredFieldValidator ID="rfvEveName" runat="server" 
                                              ErrorMessage="Please enter Name of the Event" ControlToValidate="txtEveName" 
                                              ValidationGroup="PostData">*</asp:RequiredFieldValidator>
                                         <cc3:ValidatorCalloutExtender ID="ValidatorCalloutExtender17" runat="server" Enabled="true" TargetControlID="rfvEveName">
                                          </cc3:ValidatorCalloutExtender>
                                      </td>
                                    </tr>
                                    <tr id="trEventsPlace" runat="server">
                                      <td class="adminform" align="right">Place of Event</td>
                                      <td align="center"> &nbsp;&nbsp;:&nbsp;&nbsp;</td>
                                      <td align="left">                               
                                      <asp:TextBox ID="txtEvePlace" runat="server" Width="186px" onkeypress="return Alphabets(event);"></asp:TextBox>                      
                                      
                                         <asp:RequiredFieldValidator ID="rfvEvePlace" runat="server" 
                                              ErrorMessage="Please enter place of an Event" ControlToValidate="txtEvePlace" 
                                              ValidationGroup="PostData">*</asp:RequiredFieldValidator>
                                         <cc3:ValidatorCalloutExtender ID="ValidatorCalloutExtender18" runat="server" Enabled="true" TargetControlID="rfvEvePlace">
                                          </cc3:ValidatorCalloutExtender>
                                      </td>
                                    </tr>
                               <%--       
                                </table>
                          </td>
                      </tr>--%>
                      
                      <%-- <tr id="trEventsDiscounts" runat="server">
                          <td class="adminform" colspan="3">
                             
                                <table width="100%" border="0"> --%>
                                     <tr id="trEvDiDuration" runat="server">
                                      <td class="adminform" align="right">Duration type of event</td>
                                      <td align="center"> &nbsp;&nbsp;:&nbsp;&nbsp;</td>
                                     <td align="left">                               
                                          <asp:DropDownList ID="ddlDurationType" runat="server" Width="186px" 
                                              onselectedindexchanged="ddlDurationType_SelectedIndexChanged" AutoPostBack="true">
                                          <asp:ListItem Value="Select One">Select One</asp:ListItem>    
                                          <asp:ListItem Value="One Day Event">One Day Event</asp:ListItem>
                                          <asp:ListItem Value="Multi Day Event">Multi Day Event</asp:ListItem>
                                          </asp:DropDownList>                                                       
                                         <asp:RequiredFieldValidator ID="rfvdurationtype" runat="server" 
                                              ErrorMessage="Please select Duration type of event" ControlToValidate="ddlDurationType" 
                                              ValidationGroup="PostData" InitialValue="Select One">*</asp:RequiredFieldValidator>
                                          <cc3:ValidatorCalloutExtender ID="ValidatorCalloutExtender24" runat="server" Enabled="true" TargetControlID="rfvdurationtype">
                                          </cc3:ValidatorCalloutExtender>                                                                                                                              
                                      </td>
                                    </tr>                                  
                                     <tr id="trEvDiStartDate" runat="server">
                                      <td class="adminform" style="width:146px" align="right">Start Date</td>
                                      <td align="center" style="width:52px"> &nbsp;&nbsp;:&nbsp;&nbsp;</td>
                                      <td align="left">                               
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
                                    <tr id="trEndDate" runat="server">
                                      <td class="adminform" align="right">End Date</td>
                                      <td align="center"> &nbsp;&nbsp;:&nbsp;&nbsp;</td>
                                      <td align="left">                               
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
                                    <tr id="trEvDiDesc" runat="server">
                                      <td class="adminform" align="right">Description</td>
                                      <td align="center"> &nbsp;&nbsp;:&nbsp;&nbsp;</td>
                                      <td align="left">                               
                                      <asp:TextBox ID="txtEveDiDesc" runat="server" Width="186px"></asp:TextBox>                      
                                      
                                         <asp:RequiredFieldValidator ID="rfvEveDesc" runat="server" 
                                              ErrorMessage="Please enter Description" ControlToValidate="txtEveDiDesc" 
                                              ValidationGroup="PostData">*</asp:RequiredFieldValidator>
                                               <cc3:ValidatorCalloutExtender ID="ValidatorCalloutExtender21" runat="server" Enabled="true" TargetControlID="rfvEveDesc">
                                          </cc3:ValidatorCalloutExtender>
                                      </td>
                                    </tr>
                                    <tr  id="trEvDiEventTime" runat="server">
                                      <td class="adminform" align="right">Time of Event</td>
                                      <td align="center"> &nbsp;&nbsp;:&nbsp;&nbsp;</td>
                                      <td align="left">                               
                                      <asp:TextBox ID="txtEveDiTime" runat="server" Width="186px"></asp:TextBox>                      
                                      
                                         <asp:RequiredFieldValidator ID="rfvEveTime" runat="server" 
                                              ErrorMessage="Please enter Time Duration" ControlToValidate="txtEveDiTime" 
                                              ValidationGroup="PostData">*</asp:RequiredFieldValidator>
                                               <cc3:ValidatorCalloutExtender ID="ValidatorCalloutExtender22" runat="server" Enabled="true" TargetControlID="rfvEveTime">
                                          </cc3:ValidatorCalloutExtender>
                                      </td>
                                    </tr>                                        
                                <%--</table>
                                
                          </td>
                      </tr>--%>
                      <tr>
                      <td class="adminform" align="right">Address</td>
                      <td align="center">:</td>
                      <td align="left"> 
                      <asp:TextBox ID="txtaddr" runat="server" Width="184px" TextMode="MultiLine"></asp:TextBox>
                      <asp:RequiredFieldValidator ID="rfvAddr" runat="server" 
                              ErrorMessage="Please enter address" ControlToValidate="txtaddr" 
                              ValidationGroup="PostData">*</asp:RequiredFieldValidator>
                               <cc3:ValidatorCalloutExtender ID="ValidatorCalloutExtender23" runat="server" Enabled="true" TargetControlID="rfvAddr">
                                          </cc3:ValidatorCalloutExtender>
                      </td>
                      </tr>
                      
                      <tr>
                      <td class="adminform" align="right">Land Mark</td>
                      <td align="center">:</td>
                      <td align="left"> 
                      <asp:TextBox ID="txtLandMark" runat="server" Width="188px"></asp:TextBox>
                      <%--<asp:RequiredFieldValidator ID="rfvLandMark" runat="server" 
                              ErrorMessage="Please enter Land mark" ControlToValidate="txtLandMark" 
                              ValidationGroup="PostData">*</asp:RequiredFieldValidator>
                               <cc3:ValidatorCalloutExtender ID="ValidatorCalloutExtender24" runat="server" Enabled="true" TargetControlID="rfvLandMark">
                                          </cc3:ValidatorCalloutExtender>--%>
                      </td>
                      </tr>
                      <tr>
                      <td class="adminform" align="right">Pin Code</td>
                      <td align="center">:</td>
                      <td align="left"> 
                      <asp:TextBox ID="txtPinCode" runat="server" Width="188px" MaxLength="6" onkeypress="return isNumberKey(event)"></asp:TextBox>
                      <asp:RequiredFieldValidator ID="rfvPincode" runat="server" 
                              ErrorMessage="Please enter Pincode" ControlToValidate="txtPinCode" 
                              ValidationGroup="PostData">*</asp:RequiredFieldValidator>
                               <cc3:ValidatorCalloutExtender ID="ValidatorCalloutExtender34" runat="server" Enabled="true" TargetControlID="rfvPincode">
                                        </cc3:ValidatorCalloutExtender>
                          <asp:RegularExpressionValidator ID="revPinCode" runat="server" 
                              ErrorMessage="Enter pincode number only 6 digits(starting number should starts from 1 to 9 digits)" ControlToValidate="txtPinCode" 
                              ValidationExpression="^[01]?[- .]?(\([1-9]\d{1}\)|[1-9]\d{1})[- .]?\d{2}[- .]?\d{2}$" Display="Dynamic" ValidationGroup="PostData"></asp:RegularExpressionValidator>                 
                              <cc3:ValidatorCalloutExtender ID="ValidatorCalloutExtender37" runat="server" Enabled="true" TargetControlID="revPinCode">
                                        </cc3:ValidatorCalloutExtender>            
                      </td>
                      </tr>
                      <tr>
                      <td class="adminform" align="right">Contact Person</td>
                      <td align="center">:</td>
                      <td align="left"> 
                      <asp:TextBox ID="txtContPerson" runat="server" Width="188px"  onkeypress="return Alphabets(event);"></asp:TextBox>
                      <%--<asp:RequiredFieldValidator ID="rfvContPerson" runat="server" 
                              ErrorMessage="Please enter Name of the Contact Person" 
                              ControlToValidate="txtContPerson" ValidationGroup="PostData">*</asp:RequiredFieldValidator>
                               <cc3:ValidatorCalloutExtender ID="ValidatorCalloutExtender25" runat="server" Enabled="true" TargetControlID="rfvContPerson">
                                          </cc3:ValidatorCalloutExtender>--%>
                          <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Only charecters will be allowed"
                           ValidationExpression="\w+[a-zA-Z\s]+$" ControlToValidate="txtContPerson" ValidationGroup="PostData">*</asp:RegularExpressionValidator>
                          
                      
                          <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
                              ValidationGroup="PostData" ShowMessageBox="True" ShowSummary="False" />
                      </td>
                      </tr>
                     
                     
                     <tr>
                      <td class="adminform" align="right">Email</td>
                      <td align="center">:</td>
                      <td align="left"> 
                      <asp:TextBox ID="txtemail" runat="server" Width="188px" ></asp:TextBox>
                    <%--<asp:RequiredFieldValidator ID="rfvEmail" runat="server" 
                              ErrorMessage="Please enter Email Id" ControlToValidate="txtemail" 
                              ValidationGroup="PostData">*</asp:RequiredFieldValidator>
                               <cc3:ValidatorCalloutExtender ID="ValidatorCalloutExtender26" runat="server" Enabled="true" TargetControlID="rfvEmail">
                                          </cc3:ValidatorCalloutExtender>--%>
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
                      <td class="adminform" align="right">Phone</td>
                      <td align="center">:</td>
                      <td align="left"> 
                      <asp:TextBox ID="txtph" runat="server" Width="189px" onkeypress="return isNumberKey(event)" MaxLength="11"></asp:TextBox>
                      <asp:RangeValidator ID="rangevalPh" runat="server" 
                            ErrorMessage="Phone number should start with zero" MinimumValue="0" ControlToValidate="txtph" 
                            MaximumValue="1" ValidationGroup="PostData">*</asp:RangeValidator>
                             <cc3:ValidatorCalloutExtender ID="ValidatorCalloutExtender28" runat="server" Enabled="true" TargetControlID="rangevalPh">
                                          </cc3:ValidatorCalloutExtender>
                          <asp:RegularExpressionValidator ID="revph" runat="server" 
                              ErrorMessage="The number shoud be 11 digits" ControlToValidate="txtph" 
                              ValidationExpression="^[01]?[- .]?(\([1-9]\d{2}\)|[1-9]\d{2})[- .]?\d{3}[- .]?\d{4}$"  ValidationGroup="PostData">*</asp:RegularExpressionValidator>
                               <cc3:ValidatorCalloutExtender ID="ValidatorCalloutExtender29" runat="server" Enabled="true" TargetControlID="revph">
                                          </cc3:ValidatorCalloutExtender>
                      </td>
                      </tr>
                      
                       <tr>
                      <td class="adminform" align="right">Mobile</td>
                      <td align="center">:</td>
                      <td align="left"> 
                      <asp:TextBox ID="txtcode" runat="server" ReadOnly="true" Text="+91" Width="29px"></asp:TextBox>-
                      <asp:TextBox ID="txtmobile" runat="server" Width="147px" onkeypress="return onlyNos(event,this);" MaxLength="10"></asp:TextBox>
                     <%--<asp:RequiredFieldValidator ID="rfvMob" runat="server" 
                              ErrorMessage="Please enter Mobile Number" ControlToValidate="txtmobile"  
                              ValidationGroup="PostData">*</asp:RequiredFieldValidator>
                               <cc3:ValidatorCalloutExtender ID="ValidatorCalloutExtender30" runat="server" Enabled="true" TargetControlID="rfvMob">
                                          </cc3:ValidatorCalloutExtender>--%>
                             <%--<asp:RangeValidator ID="rangevalMob" runat="server" 
                            ErrorMessage="Phone number should start with zero" MinimumValue="0" ControlToValidate="txtmobile" 
                            MaximumValue="1" ValidationGroup="PostData">*</asp:RangeValidator> 
                             <cc3:ValidatorCalloutExtender ID="ValidatorCalloutExtender31" runat="server" Enabled="true" TargetControlID="rangevalMob">
                                          </cc3:ValidatorCalloutExtender> --%>
                            <asp:RegularExpressionValidator ID="revmob" runat="server" 
                              ErrorMessage="Enter mobile number only ten digits(starting number should starts from 1 to 9 digits)" ControlToValidate="txtmobile" 
                              ValidationExpression="^[01]?[- .]?(\([1-9]\d{2}\)|[1-9]\d{2})[- .]?\d{3}[- .]?\d{4}$" Display="Dynamic"  ValidationGroup="PostData"></asp:RegularExpressionValidator>
                               <cc3:ValidatorCalloutExtender ID="ValidatorCalloutExtender32" runat="server" Enabled="true" TargetControlID="revmob">
                                          </cc3:ValidatorCalloutExtender>
                      </td>
                      </tr>
                                           
                      <tr>
                      <td class="adminform" align="right">Fax</td>
                      <td align="center">:</td>
                      <td align="left"> 
                      <asp:TextBox ID="txtFax" runat="server" Width="190px" onkeypress="return isNumberKey(event)" MaxLength="11" ></asp:TextBox>   
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
                      <tr>
                      <td class="adminform" align="right">Website</td>
                      <td align="center">:</td>
                      <td align="left"> 
                      <asp:TextBox ID="txtWebsite" runat="server" Width="190px" ></asp:TextBox>                      
                          <asp:RegularExpressionValidator ID="revWebsite" runat="server" 
                              ControlToValidate="txtWebsite" ErrorMessage="Please enter valid URL. Eg:http://www.justcalluz.com" 
                              ValidationExpression="http(s)?://([\w-]+\.)+[\w-]+(/[\w- ./?%&amp;=]*)?" 
                              ValidationGroup="PostData">*</asp:RegularExpressionValidator>
                              <cc3:ValidatorCalloutExtender ID="ValidatorCalloutExtender36" runat="server" Enabled="true" TargetControlID="revWebsite">
                                          </cc3:ValidatorCalloutExtender>   
                      </td>
                      </tr>                      
                      <tr id="trUploadPhoto" runat="server">
                      <td class="adminform" align="right">Upload&nbsp;
                          <asp:Label ID="lblPhoto" runat="server"></asp:Label>&nbsp;(Optional)</td>
                      <td align="center">:</td>
                      <td align="left"> 
                        <asp:FileUpload ID="Imgupload" runat="server" />
                          <asp:LinkButton ID="lnkfileupload" runat="server" Text="clear" 
                              onclick="lnkfileupload_Click" ></asp:LinkButton>
                      </td>
                      </tr>                     
                      </table>                      
                            </ContentTemplate>
                        </asp:UpdatePanel>   
                     </td>
                  </tr>
                  <tr><td height="5px"></td></tr>
                  <tr>              
                      <td align="center" style="width:600px; padding-left:50px">
                      <asp:ImageButton ID="btnSubmit" runat="server" 
                                    ImageUrl="~/admin/images/post.png" onclick="btnSubmit_Click" 
                                    ValidationGroup="PostData" />                                     
                      </td>
                  </tr>
                  <tr><td>                      
                  </td></tr>
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
