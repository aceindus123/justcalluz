<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Admin_CareersEdit.aspx.cs" Inherits="admin_Admin_CareersEdit" %>
<%@ Register Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" TagPrefix="cc3"  %>
<%@ Register Src="~/admin/user_control/Admin_Headermenu.ascx" TagName="Headermenu" TagPrefix="cc1" %>
<%@ Register Src="~/admin/user_control/Admin_LeftMenu.ascx" TagName="LeftMenu" TagPrefix="cc4" %>
<%@ Register Src="~/admin/user_control/Admin_CareersHeader.ascx" TagName="CareersHeader" TagPrefix="Careers" %>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
  <title>Justcalluz - Admin Control Panel - Careers_Update</title>
    <link href="includes/style.css" rel="Stylesheet" type="text/css" />
    <script src="js/statesopt.js"></script>
    <script type="text/javascript" src="js/tab.js"></script>
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
        .style41
        {
            height: 26px;
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
    testwindow = window.open("http://www.justcalluz.com/Careers_Location.aspx", "mywindow", "location=1,status=1,scrollbars=1,width=500,height=500");
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
      </head>
<body onload="new Accordian('basic-accordian',5,'header_highlight');">

   <form id="form1" runat="server">
   <asp:ScriptManager ID="ScriptManager1" runat="server"> </asp:ScriptManager>
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
                    <td colspan="3">                      
                       <Careers:CareersHeader ID="Careers" runat="server" />
                    </td>
                    </tr>
                   <%-- <tr><td height="5px"></td></tr>--%>  
                     <%-- <tr>--%>
                       
                              
                       <%-- </tr>--%>

                          <tr>
                      
                        <td align="right" style="padding-right:10px; width:20%" >
                        <a href="http://www.justcalluz.com/Careers_Location.aspx" target="_blank"> 
                           <img src="images/Click Here For SiteView.png"/>
                        </a></td> 
                      </tr>

                        <tr>
                        <td align="center"  colspan="2">
                          <span style="font-size:21px; font-weight:bold; color:DarkBlue">Update Careers</span> 
                      </td>
                                             
                      </tr>    

                   
                           
                                                                    
                        <tr>
                            <td colspan="3">
                                <asp:Label ID="Label1" runat="server"></asp:Label>
                                
                            </td>
                        </tr>
                         <tr><td height="20px"  colspan="3" align="right" style="padding-right:8px;">
                                  <asp:LinkButton ID="lnkBack" runat="server" Text="Back" PostBackUrl="Admin_Careers.aspx"></asp:LinkButton>
                        </td></tr>   
                  <tr>
                    <td colspan="3" align="center">
                        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                            <ContentTemplate>  
                            <table border="0" cellspacing="5" style="width: 700px; margin-left: 0px">                                    
                     <tr>
                       <td align="left" colspan="3">                                
                           <asp:Label ID="lblMessage" runat="server"></asp:Label>             
           
                       </td>
                     </tr>
                      <tr>
                      <td class="adminform" align="right">Job Title</td>
                      <td align="center"> &nbsp;&nbsp;:&nbsp;&nbsp;</td>
                      <td align="left">                               
                          <asp:TextBox ID="txtJTitle" runat="server" Width="186px" onkeypress="return Alphabets(event);"></asp:TextBox>                                                                              
                          <asp:RequiredFieldValidator ID="rfvTitle" runat="server" 
                              ErrorMessage="Please enter Job Title" ValidationGroup="EditCareers" 
                              ControlToValidate="txtJTitle">*</asp:RequiredFieldValidator>
                                                                              
                      </td>
                      </tr>
                      
                      <tr>
                      <td class="adminform" align="right">Category</td>
                      <td align="center"> &nbsp;&nbsp;:&nbsp;&nbsp;</td>
                      <td align="left">                               
                          <asp:DropDownList ID="ddlCategory" runat="server" Width="192px" 
                              onselectedindexchanged="ddlCategory_SelectedIndexChanged" AutoPostBack="true">
                          </asp:DropDownList>
                          
                          <asp:RequiredFieldValidator ID="rfvCat" runat="server" 
                              ControlToValidate="ddlCategory" ErrorMessage="Please select Category" 
                              InitialValue="----- Select -----" ValidationGroup="EditCareers">*</asp:RequiredFieldValidator>
                           <cc3:ValidatorCalloutExtender ID="ValidatorCalloutExtender1" runat="server" Enabled="true" TargetControlID="rfvCat">
                                          </cc3:ValidatorCalloutExtender>
                      </td>
                      </tr>
                      <tr>
                      <td class="adminform" align="right">Specialisation</td>
                      <td align="center"> &nbsp;&nbsp;:&nbsp;&nbsp;</td>
                      <td align="left">                               
                          <asp:DropDownList ID="ddlSubCat" runat="server" Width="192px">
                          </asp:DropDownList>
                          
                          <asp:RequiredFieldValidator ID="rfvSubCat" runat="server" 
                              ControlToValidate="ddlSubCat" ErrorMessage="Please select Specialization" 
                              InitialValue="----- Select -----" ValidationGroup="EditCareers">*</asp:RequiredFieldValidator>
                           <cc3:ValidatorCalloutExtender ID="ValidatorCalloutExtender2" runat="server" Enabled="true" TargetControlID="rfvSubCat">
                                          </cc3:ValidatorCalloutExtender>
                      </td>
                      </tr>
                      <tr>
                      <td class="adminform" align="right">Job Type</td>
                      <td align="center"> &nbsp;&nbsp;:&nbsp;&nbsp;</td>
                      <td align="left">                               
                          <asp:DropDownList ID="ddlJobType" runat="server" Width="192px">
                          </asp:DropDownList>
                          
                          <asp:RequiredFieldValidator ID="rfvJobType" runat="server" 
                              ControlToValidate="ddlJobType" ErrorMessage="Please select Job Type" 
                              InitialValue="----- Select -----" ValidationGroup="EditCareers">*</asp:RequiredFieldValidator>
                           <cc3:ValidatorCalloutExtender ID="ValidatorCalloutExtender3" runat="server" Enabled="true" TargetControlID="rfvSubCat">
                                          </cc3:ValidatorCalloutExtender>
                      </td>
                      </tr>
                      <tr>
                      <td class="adminform" align="right">Job Status</td>
                      <td align="center"> &nbsp;&nbsp;:&nbsp;&nbsp;</td>
                      <td align="left">                               
                          <asp:DropDownList ID="ddlJobStatus" runat="server" Width="192px">
                          <asp:ListItem>----- Select -----</asp:ListItem>
                          <asp:ListItem>Interviewing</asp:ListItem>
                          <asp:ListItem>Sourcing</asp:ListItem>
                          <asp:ListItem>Closed to New Applicants</asp:ListItem>                          
                          </asp:DropDownList>
                          
                          <asp:RequiredFieldValidator ID="rfvJobStatus" runat="server" 
                              ControlToValidate="ddlJobStatus" ErrorMessage="Please select Job Status" 
                              InitialValue="----- Select -----" ValidationGroup="EditCareers">*</asp:RequiredFieldValidator>
                           <cc3:ValidatorCalloutExtender ID="ValidatorCalloutExtender4" runat="server" Enabled="true" TargetControlID="rfvSubCat">
                                          </cc3:ValidatorCalloutExtender>
                      </td>
                      </tr>
                      <tr>
                      <td class="adminform" align="right">Work Experience</td>
                      <td align="center"> &nbsp;&nbsp;:&nbsp;&nbsp;</td>
                      <td align="left">                               
                          <asp:DropDownList ID="ddlMax" runat="server" Width="78px">                                                  
                          </asp:DropDownList> &nbsp; 
                          <asp:Label ID="Label2" runat="server" Text="to" Font-Size="Medium" Height="25px"></asp:Label> &nbsp;
                          <asp:DropDownList ID="ddlMin" runat="server" Width="78px">                                                  
                          </asp:DropDownList>
                          <asp:RequiredFieldValidator ID="rfvMaxExp" runat="server" 
                              ControlToValidate="ddlMax" ErrorMessage="Please select Max Experience" 
                              InitialValue="--Select--" ValidationGroup="EditCareers">*</asp:RequiredFieldValidator>
                              <asp:RequiredFieldValidator ID="rfvMinExp" runat="server" 
                              ControlToValidate="ddlMin" ErrorMessage="Please select Min Experience" 
                              InitialValue="--Select--" ValidationGroup="EditCareers">*</asp:RequiredFieldValidator>
                           <cc3:ValidatorCalloutExtender ID="ValidatorCalloutExtender5" runat="server" Enabled="true" TargetControlID="rfvSubCat">
                                          </cc3:ValidatorCalloutExtender>
                      </td>
                      </tr>
                      <tr>
                      <td class="adminform" align="right">Salary Range</td>
                      <td align="center"> &nbsp;&nbsp;:&nbsp;&nbsp;</td>
                      <td align="left">                               
                          <asp:DropDownList ID="ddlSal" runat="server" Width="192px">                                                  
                          </asp:DropDownList>
                                                    
                          <asp:RequiredFieldValidator ID="rfvSal" runat="server" 
                              ControlToValidate="ddlSal" ErrorMessage="Please select Salary Range" 
                              InitialValue="----- Select -----" ValidationGroup="EditCareers">*</asp:RequiredFieldValidator>
                           <cc3:ValidatorCalloutExtender ID="ValidatorCalloutExtender6" runat="server" Enabled="true" TargetControlID="rfvSubCat">
                                          </cc3:ValidatorCalloutExtender>
                      </td>
                      </tr>
                      <tr>
                      <td class="adminform" align="right">No. of Positions</td>
                      <td align="center"> &nbsp;&nbsp;:&nbsp;&nbsp;</td>
                      <td align="left">                               
                          <asp:TextBox ID="txtPositions" runat="server" Width="189px" onkeypress="return onlyNos(event,this);"></asp:TextBox>                                                    
                           <asp:RequiredFieldValidator ID="rfvPos" runat="server" 
                              ControlToValidate="txtPositions" 
                              ErrorMessage="Please enter No. of Positions available" 
                              ValidationGroup="EditCareers">*</asp:RequiredFieldValidator>
                           <cc3:ValidatorCalloutExtender ID="ValidatorCalloutExtender10" runat="server" Enabled="true" TargetControlID="rfvSubCat">
                                          </cc3:ValidatorCalloutExtender>
                      </td>
                      </tr>
                      <tr>
                      <td class="adminform" align="right">Job Description</td>
                      <td align="center"> &nbsp;&nbsp;:&nbsp;&nbsp;</td>
                      <td align="left">                               
                          <asp:TextBox ID="txtJobDesc" runat="server" TextMode="MultiLine" Width="189px"></asp:TextBox>                                                    
                          <asp:RequiredFieldValidator ID="rfvJobDesc" runat="server" 
                              ErrorMessage="Please enter Job Description" ValidationGroup="EditCareers" 
                              ControlToValidate="txtJobDesc">*</asp:RequiredFieldValidator>
                      </td>
                      </tr>
                      <tr>
                      <td class="adminform" align="right">Computer Knowledge</td>
                      <td align="center"> &nbsp;&nbsp;:&nbsp;&nbsp;</td>
                      <td align="left">                               
                          <asp:TextBox ID="txtComputerK" runat="server" Width="189px"></asp:TextBox> 
                          <asp:RequiredFieldValidator ID="rfvCK" runat="server" 
                              ErrorMessage="Please enter Computer Knowledge Required" ValidationGroup="EditCareers" 
                              ControlToValidate="txtComputerK">*</asp:RequiredFieldValidator>                                                   
                      </td>
                      </tr>
                       <tr>
                      <td class="adminform" align="right">Basic Education</td>
                      <td align="center"> &nbsp;&nbsp;:&nbsp;&nbsp;</td>
                      <td align="left">                               
                          <asp:DropDownList ID="ddlEducation" runat="server" Width="192px">                                                  
                          </asp:DropDownList>
                                                    
                          <asp:RequiredFieldValidator ID="rfvEducation" runat="server" 
                              ControlToValidate="ddlEducation" ErrorMessage="Please select Basic Education required" 
                              InitialValue="----- Select -----" ValidationGroup="EditCareers">*</asp:RequiredFieldValidator>
                           <cc3:ValidatorCalloutExtender ID="ValidatorCalloutExtender7" runat="server" Enabled="true" TargetControlID="rfvSubCat">
                                          </cc3:ValidatorCalloutExtender>
                      </td>
                      </tr>
                      <tr>
                      <td class="adminform"  align="right" style="padding-right:350px;" colspan="3">Company Information</td>
                      </tr>
                      <tr>
                      <td class="adminform" align="right">Address1</td>
                      <td align="center"> &nbsp;&nbsp;:&nbsp;&nbsp;</td>
                      <td align="left">                               
                          <asp:TextBox ID="txtAddress1" runat="server" Width="189px"></asp:TextBox>  
                          <asp:RequiredFieldValidator ID="rfvAddress1" runat="server" 
                              ErrorMessage="Please enter Company Address Line1" ValidationGroup="EditCareers" 
                              ControlToValidate="txtAddress1">*</asp:RequiredFieldValidator>                                                  
                      </td>
                      </tr>
                      <tr>
                      <td class="adminform" align="right">Address2</td>
                      <td align="center"> &nbsp;&nbsp;:&nbsp;&nbsp;</td>
                      <td align="left">                               
                          <asp:TextBox ID="txtAddress2" runat="server" Width="189px"></asp:TextBox>  
                                                                            
                      </td>
                      </tr>
                      <tr>
                      <td class="adminform" align="right">State</td>
                      <td align="center"> &nbsp;&nbsp;:&nbsp;&nbsp;</td>
                      <td align="left">                               
                          <asp:DropDownList ID="ddlState" runat="server" Width="192px" 
                              onselectedindexchanged="ddlState_SelectedIndexChanged" AutoPostBack="true">
                          </asp:DropDownList>
                          
                          <asp:RequiredFieldValidator ID="rfvState" runat="server" 
                              ControlToValidate="ddlState" ErrorMessage="Please select State" 
                              InitialValue="Select State" ValidationGroup="EditCareers">*</asp:RequiredFieldValidator>
                           <cc3:ValidatorCalloutExtender ID="ValidatorCalloutExtender8" runat="server" Enabled="true" TargetControlID="rfvState">
                                          </cc3:ValidatorCalloutExtender>
                      </td>
                      </tr>
                      
                      <tr>
                      <td class="adminform" align="right">City</td>
                      <td align="center"> &nbsp;&nbsp;:&nbsp;&nbsp;</td>
                      <td align="left">                               
                          <asp:DropDownList ID="ddlCity" runat="server" Width="192px">
                          </asp:DropDownList>
                          
                          <asp:RequiredFieldValidator ID="rfvCity" runat="server" 
                              ControlToValidate="ddlCity" ErrorMessage="Please select City" 
                              InitialValue="Select City" ValidationGroup="EditCareers">*</asp:RequiredFieldValidator>
                           <cc3:ValidatorCalloutExtender ID="ValidatorCalloutExtender9" runat="server" Enabled="true" TargetControlID="rfvCity">
                                          </cc3:ValidatorCalloutExtender>
                      </td>
                      </tr>
                      <tr>
                      <td class="adminform" align="right">Zip</td>
                      <td align="center"> &nbsp;&nbsp;:&nbsp;&nbsp;</td>
                      <td align="left">                               
                          <asp:TextBox ID="txtZip" runat="server" Width="189px" onkeypress="return onlyNos(event,this);" MaxLength="6"></asp:TextBox>                                                    
                          <asp:RequiredFieldValidator ID="rfvZip" runat="server" 
                              ErrorMessage="Please enter Zip" ValidationGroup="EditCareers" 
                              ControlToValidate="txtZip">*</asp:RequiredFieldValidator>
                              <asp:RegularExpressionValidator ID="RegZipcode" runat="server" 
                              ControlToValidate="txtZip" 
                              ErrorMessage="Enter Zipcode number only 6 digits(starting number should starts from 1 to 9 digits)"
                              ValidationExpression="^[01]?[- .]?(\([1-9]\d{1}\)|[1-9]\d{1})[- .]?\d{2}[- .]?\d{2}$" Display="Dynamic" 
                              ValidationGroup="EditCareers"></asp:RegularExpressionValidator>

                      </td>
                      </tr>
                      <tr>
                      <td class="adminform" align="right" style="padding-right:350px;" colspan="3">Contact Information</td>
                      </tr>
                      <tr>
                      <td class="adminform" align="right">Contact Person Name</td>
                      <td align="center"> &nbsp;&nbsp;:&nbsp;&nbsp;</td>
                      <td align="left">                               
                          <asp:TextBox ID="txtContName" runat="server" Width="189px" onkeypress="return Alphabets(event);"></asp:TextBox>   
                          <asp:RequiredFieldValidator ID="rfvContName" runat="server" 
                              ErrorMessage="Please enter Contact Person Name" ValidationGroup="EditCareers" 
                              ControlToValidate="txtContName">*</asp:RequiredFieldValidator>                                                 
                      </td>
                      </tr>
                      <tr>
                      <td class="adminform" align="right">Contact Person Email Id</td>
                      <td align="center"> &nbsp;&nbsp;:&nbsp;&nbsp;</td>
                      <td align="left">                               
                          <asp:TextBox ID="txtEmail" runat="server" Width="189px"></asp:TextBox>   
                          <asp:RequiredFieldValidator ID="rfvContEmail" runat="server" 
                              ErrorMessage="Please enter Contact Email" ValidationGroup="EditCareers" 
                              ControlToValidate="txtEmail">*</asp:RequiredFieldValidator>                                                 
                          <asp:RegularExpressionValidator ID="revEmail" runat="server" 
                              ControlToValidate="txtEmail" 
                              ErrorMessage="Please enter a valid Email Id.  Eg : xxxx@xxx.xx" 
                              ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
                              ValidationGroup="EditCareers">*</asp:RegularExpressionValidator>
                      </td>
                      </tr>
                      <tr>
                      <td class="adminform" align="right">Phone Number</td>
                      <td align="center"> &nbsp;&nbsp;:&nbsp;&nbsp;</td>
                      <td align="left">  
                      <asp:TextBox ID="txtcode" runat="server" ReadOnly="true" Text="+91" Width="30px"></asp:TextBox>-                             
                          <asp:TextBox ID="txtPh" runat="server" Width="147px" onkeypress="return onlyNos(event,this);"></asp:TextBox>   
                          <asp:RequiredFieldValidator ID="rfvPh" runat="server" 
                              ErrorMessage="Please enter Phone Number" ValidationGroup="EditCareers" 
                              ControlToValidate="txtPh">*</asp:RequiredFieldValidator>
                              <asp:RegularExpressionValidator ID="Regph" runat="server" 
                              ControlToValidate="txtPh" 
                              ErrorMessage="Enter mobile number only ten digits(starting number should starts from 1 to 9 digits)"
                              ValidationExpression="^[01]?[- .]?(\([1-9]\d{2}\)|[1-9]\d{2})[- .]?\d{3}[- .]?\d{4}$" Display="Dynamic"  
                              ValidationGroup="PostCareers"></asp:RegularExpressionValidator>                                                   
                      </td>
                      </tr>
                      <tr>
                      <td class="adminform" align="right">Extension Number</td>
                      <td align="center"> &nbsp;&nbsp;:&nbsp;&nbsp;</td>
                      <td align="left">                               
                          <asp:TextBox ID="txtExtn" runat="server" Width="189px" onkeypress="return onlyNos(event,this);" MaxLength="4"></asp:TextBox>                                                    
                      </td>
                      </tr>
                      <tr>
                      <td class="adminform" align="right" style="padding-right:350px;" colspan="3">Job Expiry Details</td>
                      </tr>                         
                      <tr>
                      <td class="adminform" align="right">Job expired on</td>
                      <td align="center"> &nbsp;&nbsp;:&nbsp;&nbsp;</td>
                      <td align="left">                               
                          <asp:TextBox ID="txtJobExpiryDate" runat="server" Width="186px"></asp:TextBox>                                                    
                          <asp:RequiredFieldValidator ID="rfvJobExpire" runat="server" 
                              ErrorMessage="Please mension after how many days job to be expired" ValidationGroup="EditCareers" 
                              ControlToValidate="txtJobExpiryDate">*</asp:RequiredFieldValidator> 
                              <cc3:ValidatorCalloutExtender ID="ValidatorCalloutExtender33" runat="server" Enabled="true" TargetControlID="rfvJobExpire">
                                          </cc3:ValidatorCalloutExtender>
                              <cc3:CalendarExtender ID="CalendarExtender1" runat="server" TargetControlID="txtJobExpiryDate" OnClientShowing="CurrentDateShowing">
                                          </cc3:CalendarExtender>
                                     <asp:RangeValidator ID="rangeValJobExpire" runat="server" 
                                               Type="Date" 
                                              ControlToValidate="txtJobExpiryDate" ValidationGroup="EditCareers">*</asp:RangeValidator>
                                              <cc3:ValidatorCalloutExtender ID="ValidatorCalloutExtender35" runat="server" Enabled="true" TargetControlID="rangeValJobExpire">
                                          </cc3:ValidatorCalloutExtender> 
                      </td>
                      </tr>                                     
                      </table>                                                                                                                  
                            </ContentTemplate>
                        </asp:UpdatePanel>   
                     </td>
                  </tr>
                  <tr>
                      <td class="adminform" align="center" colspan="3">
                          <asp:ImageButton ID="ImgBtnSubmit" runat="server" 
                              ImageUrl="images/update.png" onclick="ImgBtnSubmit_Click" 
                              ValidationGroup="EditCareers" /> 
                               &nbsp; &nbsp;
                                <asp:ImageButton ID="imbBtnCancel" runat="server" 
                                ImageUrl="~/admin/images/cancel.png" onclick="imbBtnCancel_Click"/>                             
                      </td>
                      </tr>
                      <tr>
                      <td class="adminform" align="left" colspan="3">
                          <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
                              ShowMessageBox="True" ShowSummary="False" ValidationGroup="EditCareers" />
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
