<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Admin_ToCreateWebAdmins.aspx.cs" Inherits="Admin_ToCreateWebAdmins" %>
<%@ Register Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" TagPrefix="cc3"  %>
<%@ Register Src="~/admin/user_control/Admin_Headermenu.ascx" TagName="Headermenu" TagPrefix="cc1" %>
<%@ Register Src="~/admin/user_control/Admin_LeftMenu.ascx" TagName="LeftMenu" TagPrefix="cc4" %>
<%@ Register Src="~/admin/user_control/Admin_WebAdminHeader.ascx" TagName="webadminHeader" TagPrefix="WAHeader"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<title>Justcalluz - Admin Control Panel - Creation of Web Admin / Home</title>  
  <link href="~/admin/includes/style.css" rel="Stylesheet" type="text/css" />
    <script type="text/javasrcipt" src="http://ajax.googleapis.com/ajax/libs/jquery/1.6.2/jquery.min.js"></script>
    <script src="js/statesopt.js" type="text/javascript"></script>
    <script src="js/jquery_1_4_2_head.js" type="text/javascript"></script>
<script src="js/jquery_checkall_1_0_forjquery_1_4_2_head.js" type="text/javascript"></script>
    <%--<SCRIPT language="javascript">
        $(function () {

            // add multiple select / deselect functionality
            $("#selectall").click(function () {
                $('.case').attr('checked', this.checked);
            });

            // if all checkbox are selected, check the selectall checkbox
            // and viceversa
            $(".case").click(function () {

                if ($(".case").length == $(".case:checked").length) {
                    $("#selectall").attr("checked", "checked");
                } else {
                    $("#selectall").removeAttr("checked");
                }

            });
        });
</SCRIPT>--%>
    <style type="text/css">
        .style39
        {
            width: 195px;
        }        
        .style40
        {
            width: 261px;
        }
         #ViewGridWbAdmin td
        {
        	border-color:Black;
        	border:1px;
        }
        #ViewGridWbAdmin th
        {
        	border:1px solid black;
        }
       
        </style>
        <script type="text/javascript" src="js/tab.js"></script>	
          <script type="text/javascript">
              function ConfirmationBox(frm) {
                  var result = confirm('Are you sure you want to delete user record ?');
                  if (result) {

                      return true;
                  }
                  else {
                      return false;
                  }
              }
              </script>
 <script type="text/javascript" language="javascript">
     function isNumberKey(evt) {
         var charCode = (evt.which) ? evt.which : event.keyCode
         if (charCode != 46 && charCode > 31
            && (charCode < 48 || charCode > 57))
             return false;

         return true;
     }

     function Sample() {
         var n = document.getElementById("ViewGridWbAdmin").rows.length;
         var i;
         var j = 0;
         for (i = 3; i <= n; i++) {
             if (i < 10) {
                 if (document.getElementById("ViewGridWbAdmin_ctl0" + i + "_CheckBoxreq").checked == true) {
                     if (j > 0) {
                         alert('you can select only one...');
                         document.getElementById("ViewGridWbAdmin_ctl0" + i + "_CheckBoxreq").checked = false;
                     }
                     else {
                         j++;
                     }
                 }
             }
             else {
                 if (document.getElementById("ViewGridWbAdmin_ctl0" + i + "_CheckBoxreq").checked == true) {
                     if (j > 0) {
                         alert('you can select only one...');
                         document.getElementById("ViewGridWbAdmin_ctl0" + i + "_CheckBoxreq").checked = false;
                     }
                     else {
                         j++;
                     }
                 }
             }
         }
     }

  </script>
  <script type="text/javascript" language="javascript">
      function selectOne(frm) {
          for (i = 0; i < frm.length; i++) {
              if (frm.elements[i].checked) {
                  return true;
              }
          }
          alert('select atleast one Checkbox for View / Edit!');
          return false;
      }
</script>
<script type="text/javascript" language="javascript">
    function selectOneenable(frm) {
        for (i = 0; i < frm.length; i++) {
            if (frm.elements[i].checked) {
                return true;
            }
        }
        alert('select atleast one Checkbox to enable the user!');
        return false;
    }
</script>
<script language="javascript" type="text/javascript">

    function alertdelete12() {
        alert("You don't have rights to done this task !!!");
    }    
    </script>
<script type="text/javascript" language="javascript">
    function selectOnedisable(frm) {
        for (i = 0; i < frm.length; i++) {
            if (frm.elements[i].checked) {
                return true;
            }
        }
        alert('select atleast one Checkbox to disable the user!');
        return false;
    }
</script>
<script type="text/javascript" language="javascript">
    function confirmMessageDelete(frm) {
        for (i = 0; i < frm.length; i++) {
            if (frm.elements[i].checked) {
                return confirm("Are you sure you want to delete the selected record?");
                return true;
            }
        }
        alert('select atleast one Checkbox for Delete!');
        return false;
    }

  
</script>
<script type="text/javascript" language="javascript">

    function selectOne(frm, parent) {
        parent.checked = true;
        for (var i = 0; i < frm.length; i++) {
            if (frm[i].checked) {

            }
            else {
                parent.checked = false;
            }
        }

    }
    </script>
      </head>
<body onload="new Accordian('basic-accordian',5,'header_highlight');">
    <form id="form1" runat="server">
   <asp:ScriptManager ID="ScriptManager1" runat="server">
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
            <table cellpadding="0" cellspacing="0" width="100%">
              <tr>
                <td class="style39" valign="top" style="padding-top:6px">                        
                 <cc4:LeftMenu ID="LeftMenu1" runat="server" />
                </td>
                <td valign="top">&nbsp;</td>
                <td valign="top" align="center" style="padding-left:10px; background-color:#F2FAFC ; width:100%;">
                    <table width="100%" id="create" runat="server">
                    <tr>
                        <td colspan="6">
                            <WAHeader:webadminHeader ID="wahead1" runat="server" />
                        </td>
                    </tr>
                  
                     <tr><td colspan="6" align="center" style="padding-top:15px;">                                                
                            <asp:Label ID="Label2" runat="server" Text="Create User" ForeColor="OrangeRed" Font-Bold="true" Font-Size="14px" Font-Names="verdana"></asp:Label>
                        </td></tr>
                        <tr><td colspan="6" align="right" style="padding-right:10px; font-size:14px;height:20px;">
                          <a href="Admin-UserDetails.aspx"><asp:Label ID="lblBack" runat="server" Text="Back"></asp:Label></a>
                          </td></tr>
                        <tr>
                        <td colspan="6" style="width:100%;">
                             <table width="50%" border="0" align="left" style="padding-left:5%; height:250px;">
                          <tr>
                            <td  align="left" style="color:#174eb4;font-family:Verdana; font-size:13px;">
                                First Name
                            </td>
                             <td ><strong>&nbsp;:&nbsp;</strong></td>
                            <td align="left" >
                                <asp:TextBox ID="txtFName" runat="server" Width="138px"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rfvFName" runat="server" 
                                    ErrorMessage="Please enter First Name" ControlToValidate="txtFName" 
                                    ValidationGroup="WebAdminCreation">*</asp:RequiredFieldValidator>
                            </td>
                            
                        </tr>                                                

                          <tr>
                            <td  align="left" style="color:#174eb4;font-family:Verdana; font-size:13px;">
                               Designation
                            </td>
                            <td><strong>&nbsp;:&nbsp;</strong></td>
                            <td align="left">
                               <asp:DropDownList ID="ddlUsertype" runat="server" Width="144px">
                    <asp:ListItem Text="Select" Selected="True">Select</asp:ListItem>
                    <asp:ListItem Text="Web Admin" >Web Admin</asp:ListItem>
                    <asp:ListItem Text="Developer" >Developer</asp:ListItem>
                    <asp:ListItem Text="Analyst" >Analyst</asp:ListItem>
                    <asp:ListItem Text="Sales" >Sales</asp:ListItem>
                    <asp:ListItem Text="Customer Service">Customer Service</asp:ListItem>
                     <asp:ListItem Text="Support" >Support</asp:ListItem>
                    <asp:ListItem Text="Business Development" >Business Development</asp:ListItem>
                                               
                  </asp:DropDownList>
                  <asp:RequiredFieldValidator ID="rfvddlUsertype" runat="server" ErrorMessage="Select user type" 
                          ValidationGroup="WebAdminCreation" ControlToValidate="ddlUsertype" InitialValue="Select">*</asp:RequiredFieldValidator>
                                
                            </td>
                           
                        </tr> 
                         <tr>
                            <td  align="left" style="color:#174eb4;font-family:Verdana; font-size:13px;">
                                User Id
                            </td>
                             <td ><strong>&nbsp;:&nbsp;</strong></td>
                            <td align="left" >
                                <asp:TextBox ID="txtUserid" runat="server" Width="138px" 
                                              ontextchanged="txtUserId_TextChanged" AutoPostBack="true"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                    ErrorMessage="Please enter user id" ControlToValidate="txtUserid" 
                                    ValidationGroup="WebAdminCreation">*</asp:RequiredFieldValidator><asp:Label ID="lblStatus" 
                                    runat="server" Font-Size ="10px"></asp:Label>
                            </td>
                            
                        </tr>  
                        <tr>
                           <td align="left" style=" color:#174eb4; font-family:Verdana; font-size:13px;">
                             Password
                           </td>
                           <td><strong>&nbsp;:&nbsp;</strong></td>
                           <td align="left">
                              <asp:TextBox ID="txtPwd" runat="server" Width="138px" TextMode="Password"></asp:TextBox>
                              <asp:RequiredFieldValidator ID="rfvtxtpwd" runat="server" ErrorMessage="Please enter password"
                                  ControlToValidate="txtpwd" ValidationGroup="webAdminCreation">*</asp:RequiredFieldValidator>
                           </td>
                        </tr>
                         <tr>
                          <td align="left" style="color:#174eb4; font-family:Verdana; font-size:13px;">
                             Address
                          </td>
                          <td><strong>&nbsp;:&nbsp;</strong></td>
                          <td align="left">
                            <asp:TextBox ID="txtaddress" runat="server" Width="138px"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="rfvAddress" runat="server" ControlToValidate="txtaddress" ErrorMessage="Please enter address"
                                 ValidationGroup="webAdminCreation">*</asp:RequiredFieldValidator>
                          </td>
                        </tr>
                        <tr>
                            <td  align="left" style="color:#174eb4;font-family:Verdana; font-size:13px;">
                               Contact
                            </td>
                            <td><strong>&nbsp;:&nbsp;</strong></td>
                            <td align="left">
                               <asp:TextBox ID="txtContact" runat="server"  Width="138px" MaxLength="11" 
                                    onkeypress="return isNumberKey(event)"></asp:TextBox>
                                 <asp:RequiredFieldValidator ID="rfvEmail" runat="server" 
                                    ControlToValidate="txtContact" ErrorMessage="Please enter contact number" 
                                    ValidationGroup="WebAdminCreation">*</asp:RequiredFieldValidator>
                                     <asp:RegularExpressionValidator Display = "Dynamic" ControlToValidate = "txtContact" 
                                         ID="RegularExpressionValidator2" ValidationExpression = "^[\s\S]{11,}$" runat="server" 
                                                ErrorMessage="Minimum 11 digits required." ValidationGroup="WebAdminCreation">*</asp:RegularExpressionValidator>
                                                 
                            </td>
                           
                        </tr>
                        </table>
                             <table width="50%" border="0" align="right" style="height:250px;">
                          <tr>
                            <td  align="left" style="color:#174eb4;font-family:Verdana; font-size:13px;">
                               Last Name
                            </td>
                             <td ><strong>&nbsp;:&nbsp;</strong></td>
                            <td align="left" >
                                <asp:TextBox ID="txtLName" runat="server" Width="138px"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                    ControlToValidate="txtLName" ErrorMessage="Please enter Last Name" 
                                    ValidationGroup="WebAdminCreation">*</asp:RequiredFieldValidator>
                            </td>
                        </tr>                                                
                         <tr>
                       
                            <td  align="left" style="color:#174eb4;font-family:Verdana; font-size:13px;">
                               Country
                            </td>
                            <td><strong>&nbsp;:&nbsp;</strong></td>
                            <td align="left">
                            <asp:DropDownList ID="ddlCountry" runat="server" Width="144px">
                    <asp:ListItem Text="Select" Selected="True">Select</asp:ListItem>
                    <asp:ListItem Text="India" >India</asp:ListItem>
                    <asp:ListItem Text="USA" >USA</asp:ListItem>
                    <asp:ListItem Text="UK" >UK</asp:ListItem>
                    <asp:ListItem Text="Australia" >Australia</asp:ListItem>
                    <asp:ListItem Text="Singapoor" >Singapore</asp:ListItem>
                                                                 
                  </asp:DropDownList>
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Select country" 
                          ValidationGroup="WebAdminCreation" ControlToValidate="ddlCountry" InitialValue="Select">*</asp:RequiredFieldValidator>
                            </td>
                        </tr> 
                         <tr>
                            <td  align="left" style="color:#174eb4;font-family:Verdana; font-size:13px;">
                               EmailId
                            </td>
                            <td><strong>&nbsp;:&nbsp;</strong></td>
                            <td align="left">
                          
                                <asp:TextBox ID="txtEmail" runat="server"  Width="138px" 
                                      ontextchanged="txtEmail_TextChanged" AutoPostBack="true"></asp:TextBox>
                                <%--<asp:Label ID="lblemailExtension" runat="server" Text="@justcalluz.com"></asp:Label>--%>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
                                    ControlToValidate="txtEmail" ErrorMessage="Please enter Emai Id" 
                                    ValidationGroup="WebAdminCreation">*</asp:RequiredFieldValidator>
                                     <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" 
                                                 ErrorMessage="Please Enter valid email id" 
                                                 ControlToValidate="txtEmail" 
                                                 ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 

                                                 ValidationGroup="WebAdminCreation">*</asp:RegularExpressionValidator><asp:Label ID="lblEmailstatus" 
                                    runat="server" Font-Size ="10px"></asp:Label>
                                              
                            </td>
                           
                        </tr>                       
                       
                           <tr>
                             <td  align="left" style="color:#174eb4;font-family:Verdana; font-size:13px;">
                               Confirm Password
                            </td>
                             <td><strong>&nbsp;:&nbsp;</strong></td>
                            <td align="left">
                                <asp:TextBox ID="txtcPwd" runat="server" Width="138px" TextMode="Password"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                                    ControlToValidate="txtcPwd" ErrorMessage="Enter confirm password" 
                                    ValidationGroup="WebAdminCreation">*</asp:RequiredFieldValidator>
                                    <asp:CompareValidator ID="cmpCpwd" runat="server" ControlToValidate="txtcPwd" ControlToCompare="txtPwd"
                                      ValidationGroup="WebAdminCreation" ErrorMessage="Invalid Password">*</asp:CompareValidator>
                            </td>
                        </tr>  
                         <tr>
                             <td  align="left" style="color:#174eb4;font-family:Verdana; font-size:13px;">
                               Mobile
                            </td>
                             <td><strong>&nbsp;:&nbsp;</strong></td>
                            <td align="left">
                                <asp:TextBox ID="txtmobile" runat="server" Width="138px" MaxLength="10" 
                                               onkeypress="return isNumberKey(event)"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                                    ControlToValidate="txtmobile" ErrorMessage="Enter mobile number" 
                                    ValidationGroup="WebAdminCreation">*</asp:RequiredFieldValidator>
                                    <asp:RegularExpressionValidator Display = "Dynamic" ControlToValidate = "txtmobile" ID="RegularExpressionValidator1" ValidationExpression = "^[\s\S]{10,}$" runat="server" 
                                                ErrorMessage="Minimum 10 digits required." ValidationGroup="WebAdminCreation">*</asp:RegularExpressionValidator>
                            </td>
                        </tr> 
                          <tr>
                            <td  align="left" style="color:#174eb4;font-family:Verdana; font-size:13px;">
                               &nbsp;
                            </td>
                             <td ><strong>&nbsp;</strong></td>
                            <td align="left" >
                               &nbsp;
                            </td>
                            
                        </tr> 
                        </table>
                        </td>                          
                         </tr>
                         <tr><td colspan="6">&nbsp;</td></tr>
                         <tr>
                            <td colspan="6">
                                <table width="97%" border="0">
                                    <tr>
                    <td class="datab" width="30%" valign="top">
                    <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                             <ContentTemplate> 
                             
                        <table id="tblBModule">
                            <tr>
                                <td  style="width: 60%;" align="left">Business Category </td>
                                <td class="style4" style="width:40%;" align="right">
                                    <asp:RadioButton ID="rbBYes" runat="server" GroupName="gB" Text="Yes" AutoPostBack="True"/>
                                    <asp:RadioButton ID="rbBNo" Checked="true" runat="server" GroupName="gB" Text="No" AutoPostBack="True" />
                                </td>
                            </tr>  
                            <tr id="trIBModule" runat="server">
                                <td colspan="2">
                               
                                    <table width="100%" id="bctab">
                                    
                                    <tr id="trBAll" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lblBAll" runat="server" Text="Select All"></asp:Label>
                                </td>
                                <td class="style4" style="width:100px;">
                                <asp:CheckBox ID="chkBAll" runat="server" 
                                   AutoPostBack="true" OnCheckedChanged="chkBAll_CheckedChanged"/>
                                  
                                </td>
                            </tr>
                                        <tr id="trBPost" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lblBPost" runat="server" Text="Post"></asp:Label>
                                </td>
                                <td class="style4" style="width:100px;">
                              
                                   <asp:CheckBox ID="chkbxBPost" runat="server"  onchange="selectOne(document.getElementById('bctab').getElementsByTagName('INPUT'),document.getElementById('chkBAll'));" />
                                </td>
                            </tr>
                                        <tr id="trBEdit" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lblBEdit" runat="server" Text="Edit"></asp:Label>
                                </td>
                                <td class="style4" style="width:100px;">
                                
                                    <asp:CheckBox ID="chkbxBEdit" runat="server" onchange="selectOne(document.getElementById('bctab').getElementsByTagName('INPUT'),document.getElementById('chkBAll'));"/>
                                </td>
                            </tr>
                                        <tr id="trBDel" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lblBDel" runat="server" Text="Delete"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                               
                                    <asp:CheckBox ID="chkbxBDel" runat="server" onchange="selectOne(document.getElementById('bctab').getElementsByTagName('INPUT'),document.getElementById('chkBAll'));"/>
                                </td>
                            </tr>
                                        <tr id="trBPreview" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lblBPreview" runat="server" Text="Preview"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                
                                     <asp:CheckBox ID="chkbxBPreview" runat="server" onchange="selectOne(document.getElementById('bctab').getElementsByTagName('INPUT'),document.getElementById('chkBAll'));"/>
                                </td>
                            </tr>   
                                        <tr id="trBApproval" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lblBApproval" runat="server" Text="Approval"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                  <asp:CheckBox ID="chkbxBApproval" runat="server" onchange="selectOne(document.getElementById('bctab').getElementsByTagName('INPUT'),document.getElementById('chkBAll'));"/>
                                </td>
                            </tr>  
                                    </table>
                                     
                                </td>
                            </tr>                                                                              
                        </table>
                       
                        </ContentTemplate>
                           </asp:UpdatePanel>
                    </td>
                    <td class="datab" width="30%" valign="top" >
                    <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                             <ContentTemplate> 
                        <table id="tblB2Bmodule">
                            <tr>
                                <td style="width: 60%;" align="left">
                                    B2B Category 
                                </td>
                                <td class="style4" style="width:40%;" align="right">
                                    <asp:RadioButton ID="rbB2BYes" runat="server" GroupName="gB2B" Text="Yes" AutoPostBack="True" />
                                    <asp:RadioButton ID="rbB2BNo" Checked="true" runat="server" GroupName="gB2B" Text="No" AutoPostBack="True" />
                                </td>
                            </tr>
                            <tr id="trIB2BModule" runat="server">
                                <td colspan="2">
                                    <table width="100%" id="wb2bcat">
                                    <tr id="trB2BAll" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lblB2BAll" runat="server" Text="Select All"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                   <asp:CheckBox ID="chkB2BAll" runat="server" 
                                        oncheckedchanged="chkB2BAll_CheckedChanged" AutoPostBack="true" />
                                </td>
                            </tr>
                                        <tr id="trB2BPost" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lblB2BPost" runat="server" Text="Post"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:CheckBox ID="chkbxB2BPost" runat="server" onchange="selectOne(document.getElementById('wb2bcat').getElementsByTagName('INPUT'),document.getElementById('chkB2BAll'));"/>
                                </td>
                            </tr>
                                        <tr id="trB2BEdit" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lblB2BEdit" runat="server" Text="Edit"></asp:Label>
                                </td>
                                <td style="height: 20px; width: 100px;">
                                    <asp:CheckBox ID="chkbxB2BEdit" runat="server"  onchange="selectOne(document.getElementById('wb2bcat').getElementsByTagName('INPUT'),document.getElementById('chkB2BAll'));"/>
                                </td>
                            </tr>
                                        <tr id="trB2BDel" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lblB2BDel" runat="server" Text="Delete"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:CheckBox ID="chkbxB2BDel" runat="server"  onchange="selectOne(document.getElementById('wb2bcat').getElementsByTagName('INPUT'),document.getElementById('chkB2BAll'));"/>
                                </td>
                            </tr>
                                        <tr id="trB2BPreview" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lblB2Bview" runat="server" Text="Preview"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:CheckBox ID="chkbxB2Bview" runat="server"  onchange="selectOne(document.getElementById('wb2bcat').getElementsByTagName('INPUT'),document.getElementById('chkB2BAll'));"/>
                                </td>
                            </tr>
                                        <tr id="trB2BApproval" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lblB2BApproval" runat="server" Text="Approval"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                     <asp:CheckBox ID="chkbxB2BApproval" runat="server"  onchange="selectOne(document.getElementById('wb2bcat').getElementsByTagName('INPUT'),document.getElementById('chkB2BAll'));" />
                                </td>
                            </tr> 
                                    </table>
                                </td>
                            </tr>                                                        
                        </table>
                        </ContentTemplate>
                           </asp:UpdatePanel>
                    </td>
                    <td class="datab" width="30%" valign="top">
                    <asp:UpdatePanel ID="UpdatePanel4" runat="server">
                             <ContentTemplate> 
                        <table id="tblJobsmodule">
                            <tr>
                                <td  style="width: 60%;" align="left">
                                    Jobs 
                                </td>
                                <td class="style4" style="width:40%;" align="right">
                                    <asp:RadioButton ID="rbJobsYes" runat="server" GroupName="gJobs" Text="Yes" AutoPostBack="True" />
                                    <asp:RadioButton ID="rbJobsNo" Checked="true" runat="server" GroupName="gJobs" Text="No" AutoPostBack="True" />
                                </td>
                            </tr>
                            <tr id="trIJobsModule" runat="server">
                                <td colspan="2">
                                    <table width="100%" id="jobstab">
                                    <tr id="trJobsAll" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lblJobsAll" runat="server" Text="Select All"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                   <asp:CheckBox ID="chkJobsAll" runat="server" 
                                        oncheckedchanged="chkJobsAll_CheckedChanged" AutoPostBack="true"/>
                                </td>
                            </tr>
                                         <tr id="trJobsPost" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lblJobsPost" runat="server" Text="Post"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:CheckBox ID="chkbxJobsPost" runat="server"  onchange="selectOne(document.getElementById('jobstab').getElementsByTagName('INPUT'),document.getElementById('chkJobsAll'));"/>
                                </td>
                            </tr>
                                         <tr id="trJobsEdit" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lblJobsEdit" runat="server" Text="Edit"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:CheckBox ID="chkbxJobsEdit" runat="server" onchange="selectOne(document.getElementById('jobstab').getElementsByTagName('INPUT'),document.getElementById('chkJobsAll'));"/>
                                </td>
                            </tr>
                                         <tr id="trJobsDel" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lblJobsDel" runat="server" Text="Delete"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:CheckBox ID="chkbxJobsDel" runat="server" onchange="selectOne(document.getElementById('jobstab').getElementsByTagName('INPUT'),document.getElementById('chkJobsAll'));"/>
                                </td>
                            </tr>
                                         <tr id="trJobsPreview" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lblJobsview" runat="server" Text="Preview"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:CheckBox ID="chkbxJobsview" runat="server" onchange="selectOne(document.getElementById('jobstab').getElementsByTagName('INPUT'),document.getElementById('chkJobsAll'));"/>
                                </td>
                            </tr>
                                         <tr id="trJobsApproval" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lblJobsApproval" runat="server" Text="Approval"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                     <asp:CheckBox ID="chkbxJobsApproval" runat="server" onchange="selectOne(document.getElementById('jobstab').getElementsByTagName('INPUT'),document.getElementById('chkJobsAll'));"/>
                                </td>
                            </tr>                 
                                    </table>
                                </td>
                            </tr>                           
                        </table>
                        </ContentTemplate>
                           </asp:UpdatePanel>
                    </td>
                  </tr>
                    </table>
                            </td>
                        </tr>
                         <tr>
                            <td colspan="6">
                            <asp:UpdatePanel ID="UpdatePanel5" runat="server">
                             <ContentTemplate> 
                                <table width="97%" border="0">
                <tr>
                    <td class="datab" width="30%" valign="top">
                        <table id="tblEveModule" >
                            <tr>
                                <td style="width: 60%;" align="left">Events</td>
                                <td class="style4" style="width:40%;" align="right">
                                    <asp:RadioButton ID="rbEveYes" runat="server" GroupName="gEve" Text="Yes" AutoPostBack="True"/>
                                    <asp:RadioButton ID="rbEveNo" Checked="true" runat="server" GroupName="gEve" Text="No" AutoPostBack="True" />
                                </td>
                            </tr>
                            <tr id="trIEveModule" runat="server">
                                <td colspan="2">
                                    <table width="100%" id="Evetab">
                                    <tr id="trEveAll" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lblEveAll" runat="server" Text="Select All"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                   <asp:CheckBox ID="chkEveAll" runat="server" 
                                        oncheckedchanged="chkEveAll_CheckedChanged" AutoPostBack="true" />
                                </td>
                            </tr>
                                         <tr id="trEvePost" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lblEvePost" runat="server" Text="Post"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                   <asp:CheckBox ID="chkbxEvePost" runat="server" onchange="selectOne(document.getElementById('Evetab').getElementsByTagName('INPUT'),document.getElementById('chkEveAll'));"/>
                                </td>
                            </tr>
                                         <tr id="trEveEdit" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lblEveEdit" runat="server" Text="Edit"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:CheckBox ID="chkbxEveEdit" runat="server" onchange="selectOne(document.getElementById('Evetab').getElementsByTagName('INPUT'),document.getElementById('chkEveAll'));"/>
                                </td>
                            </tr>
                                         <tr id="trEveDel" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lblEveDel" runat="server" Text="Delete"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:CheckBox ID="chkbxEveDel" runat="server" onchange="selectOne(document.getElementById('Evetab').getElementsByTagName('INPUT'),document.getElementById('chkEveAll'));" />
                                </td>
                            </tr>
                                         <tr id="trEvePreview" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lblEveview" runat="server" Text="Preview"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                     <asp:CheckBox ID="chkbxEveview" runat="server" onchange="selectOne(document.getElementById('Evetab').getElementsByTagName('INPUT'),document.getElementById('chkEveAll'));"/>
                                </td>
                            </tr> 
                                         <tr id="trEveApproval" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lblEveApproval" runat="server" Text="Approval"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                     <asp:CheckBox ID="chkbxEveApproval" runat="server" onchange="selectOne(document.getElementById('Evetab').getElementsByTagName('INPUT'),document.getElementById('chkEveAll'));"/>
                                </td>
                            </tr>  
                                    </table>
                                </td>
                            </tr>                                                 
                        </table>
                    </td>
                    <td class="datab" width="30%" valign="top">
                        <table id="tblDismodule">
                            <tr>
                                <td  style="width: 60%;" align="left">
                                    Discounts
                                </td>
                                <td class="style4" style="width:40%;" align="right">
                                    <asp:RadioButton ID="rbDisYes" runat="server" GroupName="gDis" Text="Yes" AutoPostBack="True" />
                                    <asp:RadioButton ID="rbDisNo" Checked="true" runat="server" GroupName="gDis" Text="No" AutoPostBack="True" />
                                </td>
                            </tr>
                            <tr id="trIDisModule" runat="server">
                                <td colspan="2">
                                    <table width="100%" id="disctab">
                                    <tr id="trDisAll" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lblDisAll" runat="server" Text="Select All"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                   <asp:CheckBox ID="chkDisAll" runat="server" 
                                        oncheckedchanged="chkDisAll_CheckedChanged" AutoPostBack="true" />
                                </td>
                            </tr>
                                         <tr id="trDisPost" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lblDisPost" runat="server" Text="Post"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:CheckBox ID="chkbxDisPost" runat="server" onchange="selectOne(document.getElementById('disctab').getElementsByTagName('INPUT'),document.getElementById('chkDisAll'));"/>
                                </td>
                            </tr>
                                         <tr id="trDisEdit" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lblDisEdit" runat="server" Text="Edit"></asp:Label>
                                </td>
                                <td style="height: 20px; width: 100px;">
                                    <asp:CheckBox ID="chkbxDisEdit" runat="server" onchange="selectOne(document.getElementById('disctab').getElementsByTagName('INPUT'),document.getElementById('chkDisAll'));" />
                                </td>
                            </tr>
                                         <tr id="trDisDel" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lblDisDel" runat="server" Text="Delete"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:CheckBox ID="chkbxDisDel" runat="server" onchange="selectOne(document.getElementById('disctab').getElementsByTagName('INPUT'),document.getElementById('chkDisAll'));"/>
                                </td>
                            </tr>
                                         <tr id="trDisPreview" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lblDisview" runat="server" Text="Preview"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:CheckBox ID="chkbxDisview" runat="server" onchange="selectOne(document.getElementById('disctab').getElementsByTagName('INPUT'),document.getElementById('chkDisAll'));"/>
                                </td>
                            </tr> 
                                         <tr id="trDisApproval" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lblDisApproval" runat="server" Text="Approval"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                     <asp:CheckBox ID="chkbxDisApproval" runat="server" onchange="selectOne(document.getElementById('disctab').getElementsByTagName('INPUT'),document.getElementById('chkDisAll'));"/>
                                </td>
                            </tr>  
                                    </table>
                                </td>
                            </tr>
                                                    
                        </table>
                    </td>
                    <td class="datab" width="30%" valign="top">
                        <table id="tblLSmodule">
                            <tr>
                                <td style="width: 60%;" align="left">
                                    Life Style 
                                </td>
                                <td class="style4" style="width:40%;" align="right">
                                    <asp:RadioButton ID="rbLSYes" runat="server" GroupName="gLS" Text="Yes" AutoPostBack="True" />
                                    <asp:RadioButton ID="rbLSNo" Checked="true" runat="server" GroupName="gLS" Text="No" AutoPostBack="True" />
                                </td>
                            </tr>
                            <tr id="trILSModule" runat="server">
                                <td colspan="2">
                                    <table width="100%" id="liftab">
                                    <tr id="trLSAll" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lblLSAll" runat="server" Text="Select All"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                   <asp:CheckBox ID="chkLSAll" runat="server" 
                                        oncheckedchanged="chkLSAll_CheckedChanged" AutoPostBack="true" />
                                </td>
                            </tr>
                                        <tr id="trLSPost" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lblLSPost" runat="server" Text="Post"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:CheckBox ID="chkbxLSPost" runat="server" onchange="selectOne(document.getElementById('liftab').getElementsByTagName('INPUT'),document.getElementById('chkLSAll'));"/>
                                </td>
                            </tr>
                                        <tr id="trLSEdit" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lblLSEdit" runat="server" Text="Edit"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:CheckBox ID="chkbxLSEdit" runat="server" onchange="selectOne(document.getElementById('liftab').getElementsByTagName('INPUT'),document.getElementById('chkLSAll'));"/>
                                </td>
                            </tr>
                                        <tr id="trLSDel" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lblLSDel" runat="server" Text="Delete"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:CheckBox ID="chkbxLSDel" runat="server" onchange="selectOne(document.getElementById('liftab').getElementsByTagName('INPUT'),document.getElementById('chkLSAll'));"/>
                                </td>
                            </tr>
                                        <tr id="trLSPreview" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lblLSview" runat="server" Text="Preview"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:CheckBox ID="chkbxLSview" runat="server" onchange="selectOne(document.getElementById('liftab').getElementsByTagName('INPUT'),document.getElementById('chkLSAll'));" />
                                </td>
                            </tr> 
                                        <tr id="trLSApproval" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lblLSApproval" runat="server" Text="Approval"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                     <asp:CheckBox ID="chkbxLSApproval" runat="server" onchange="selectOne(document.getElementById('liftab').getElementsByTagName('INPUT'),document.getElementById('chkLSAll'));"/>
                                </td>
                            </tr>  
                                    </table>
                                </td>
                            </tr>                                                                    
                        </table>
                    </td>
                </tr>
            </table>
            </ContentTemplate>
                           </asp:UpdatePanel>
                            </td>
                        </tr>
                         <tr>
                            <td colspan="6">
                                <table width="97%" border="0">
                <tr>
                    <td class="datab" width="30%" valign="top">
                    <asp:UpdatePanel ID="UpdatePanel6" runat="server">
                             <ContentTemplate> 
                        <table id="tblCareers">
                            <tr>
                                <td style="width: 60%;" align="left">Careers</td>
                                <td class="style4" style="width:40%;" align="right">
                                    <asp:RadioButton ID="rbCareersYes" runat="server" GroupName="gCareers" Text="Yes" AutoPostBack="True"/>
                                    <asp:RadioButton ID="rbCareersNo" Checked="true" runat="server" GroupName="gCareers" Text="No" AutoPostBack="True" />
                                </td>
                            </tr>
                            <tr id="trICareers" runat="server">
                                <td colspan="2">
                                    <table width="100%" id="caretab">
                                    <tr id="trCareersAll" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lblCareersAll" runat="server" Text="Select All"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                   <asp:CheckBox ID="chkCareersAll" runat="server" 
                                        oncheckedchanged="chkCareersAll_CheckedChanged" AutoPostBack="true" />
                                </td>
                            </tr>
                                         <tr id="trCareersPost" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lblCareersPost" runat="server" Text="Post"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                   <asp:CheckBox ID="chkbxCareersPost" runat="server" onchange="selectOne(document.getElementById('caretab').getElementsByTagName('INPUT'),document.getElementById('chkCareersAll'));"/>
                                </td>
                            </tr>
                                         <tr id="trCareersEdit" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lblCareersEdit" runat="server" Text="Edit"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:CheckBox ID="chkbxCareersEdit" runat="server" onchange="selectOne(document.getElementById('caretab').getElementsByTagName('INPUT'),document.getElementById('chkCareersAll'));"/>
                                </td>
                            </tr>
                                         <tr id="trCareersDel" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lblCareersDel" runat="server" Text="Delete"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:CheckBox ID="chkbxCareersDel" runat="server" onchange="selectOne(document.getElementById('caretab').getElementsByTagName('INPUT'),document.getElementById('chkCareersAll'));"/>
                                </td>
                            </tr>
                                         <tr id="trCareersPreview" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lblCareersview" runat="server" Text="Preview"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                     <asp:CheckBox ID="chkbxCareersview" runat="server" onchange="selectOne(document.getElementById('caretab').getElementsByTagName('INPUT'),document.getElementById('chkCareersAll'));"/>
                                </td>
                            </tr>  
                            <tr id="trCareersApproval" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lblCareersApproval" runat="server" Text="Approval"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                     <asp:CheckBox ID="chkCareersApproval" runat="server" onchange="selectOne(document.getElementById('caretab').getElementsByTagName('INPUT'),document.getElementById('chkCareersAll'));"/>
                                </td>
                            </tr>         
                                    </table>
                                </td>
                            </tr>
                                           
                        </table>
                        </ContentTemplate>
                           </asp:UpdatePanel>
                    </td>
                    <%--<td class="datab" width="30%" valign="top">
                    <asp:UpdatePanel ID="UpdatePanel7" runat="server">
                             <ContentTemplate> 
                        <table id="tblBannermodule">
                            <tr>
                                <td class="datab" style="width: 60%;" align="left">
                                   Banner Ads
                                </td>
                                <td class="style4" style="width:40%;" align="right">
                                    <asp:RadioButton ID="rbBAdsYes" runat="server" GroupName="gBAds" Text="Yes" AutoPostBack="True" />
                                    <asp:RadioButton ID="rbBAdsNo" Checked="true" runat="server" GroupName="gBAds" Text="No" AutoPostBack="True" />
                                </td>
                            </tr>
                            <tr id="trIBannerAds" runat="server">
                                <td colspan="2">
                                    <table width="100%">
                                    <tr id="trBAdsAll" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lblBAdsAll" runat="server" Text="Select All"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                   <asp:CheckBox ID="chkBAdsAll" runat="server" 
                                        oncheckedchanged="chkBAdsAll_CheckedChanged" AutoPostBack="true" />
                                </td>
                            </tr>
                                        <tr id="trBAdsPost" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lblBAdsPost" runat="server" Text="Post"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:CheckBox ID="chkbxBAdsPost" runat="server" />
                                </td>
                            </tr>
                                        <tr id="trBAdsEdit" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lblBAdsEdit" runat="server" Text="Edit"></asp:Label>
                                </td>
                                <td style="height: 20px; width: 100px;">
                                    <asp:CheckBox ID="chkbxBAdsEdit" runat="server" />
                                </td>
                            </tr>
                                        <tr id="trBAdsDel" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lblBAdsDel" runat="server" Text="Delete"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:CheckBox ID="chkbxBAdsDel" runat="server" />
                                </td>
                            </tr>
                                        <tr id="trBAdsPreview" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lblBAdsview" runat="server" Text="Preview"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:CheckBox ID="chkbxBAdsview" runat="server" />
                                </td>
                            </tr>                                          
                                    </table>
                                </td>
                            </tr>
                                                    
                        </table>
                        </ContentTemplate>
                           </asp:UpdatePanel>
                    </td>--%>
                    <td class="datab" width="30%" valign="top">
                    <asp:UpdatePanel ID="UpdatePanel8" runat="server">
                             <ContentTemplate> 
                        <table id="tblUserInfomodule">
                            <tr>
                                <td style="width: 60%;" align="left">
                                    Users Info
                                </td>
                                <td class="style4" style="width:40%;" align="right">
                                    <asp:RadioButton ID="rbUInfoYes" runat="server" GroupName="gUInfo" Text="Yes" AutoPostBack="True" />
                                    <asp:RadioButton ID="rbUInfoNo" Checked="true" runat="server" GroupName="gUInfo" Text="No" AutoPostBack="True" />
                                </td>
                            </tr>
                            <tr id="trIUInfo" runat="server">
                                <td colspan="2">
                                    <table width="100%" id="usetab">
                                    <tr id="trUInfoAll" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lblUInfoAll" runat="server" Text="Select All"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                   <asp:CheckBox ID="chkUInfoAll" runat="server" 
                                        oncheckedchanged="chkUInfoAll_CheckedChanged" AutoPostBack="true" />
                                </td>
                            </tr>
                                    <tr id="trUInfoPost" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lblUInfoPost" runat="server" Text="Post"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:CheckBox ID="chkUInfoPost" runat="server" onchange="selectOne(document.getElementById('usetab').getElementsByTagName('INPUT'),document.getElementById('chkUInfoAll'));"/>
                                </td>
                            </tr>
                                    <tr id="trUInfoEdit" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lblUInfoEdit" runat="server" Text="Edit"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:CheckBox ID="chkUInfoEdit" runat="server" onchange="selectOne(document.getElementById('usetab').getElementsByTagName('INPUT'),document.getElementById('chkUInfoAll'));"/>
                                </td>
                            </tr>
                                    <tr id="trUInfoDel" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lblUInfoDel" runat="server" Text="Delete"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:CheckBox ID="chkUInfoDel" runat="server" onchange="selectOne(document.getElementById('usetab').getElementsByTagName('INPUT'),document.getElementById('chkUInfoAll'));" />
                                </td>
                            </tr>
                                    <tr id="trUInfoPreview" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lblUInfoview" runat="server" Text="Preview"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:CheckBox ID="chkUInfoview" runat="server" onchange="selectOne(document.getElementById('usetab').getElementsByTagName('INPUT'),document.getElementById('chkUInfoAll'));"/>
                                </td>
                            </tr>  
                             <tr id="trUInfoActDeact" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lblUInfoActDeact" runat="server" Text="Approval"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:CheckBox ID="chkUInfoActDeact" runat="server" onchange="selectOne(document.getElementById('usetab').getElementsByTagName('INPUT'),document.getElementById('chkUInfoAll'));" />
                                </td>
                            </tr>                                         
                                    </table>
                                </td>
                            </tr>                                                                 
                        </table>
                        </ContentTemplate>
                           </asp:UpdatePanel>
                    </td>
                      <td class="datab" width="30%" valign="top">
                        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                             <ContentTemplate> 
                                <table id="Table6">
                            <tr>
                                <td style="width: 60%;" align="left">
                                    Exceptions
                                </td>
                                <td class="style4" style="width:40%;" align="right">
                                     <asp:RadioButton ID="rbexyes" runat="server" GroupName="gex" Text="Yes" 
                                        AutoPostBack="True" />
                                    <asp:RadioButton ID="rbexno" runat="server" GroupName="gex" Text="No" 
                                        AutoPostBack="True" Checked="true" />
                                </td>
                            </tr>
                            <tr id="trExceptions" runat="server">
                                <td colspan="2">
                                    <table width="100%" id="excetab">
                                     <tr id="trExceptionsAll"  runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lblExceptionsAll"  runat="server" Text="Select All"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                   <asp:CheckBox ID="chkExceptionsAll" runat="server" 
                                        AutoPostBack="true" oncheckedchanged="chkslall_CheckedChanged" />
                                </td>
                            </tr>
                                         <tr id="trExceptionsPost" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lblExceptionsPost" runat="server" Text="Post"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:CheckBox ID="chkExceptionsPost" runat="server" onchange="selectOne(document.getElementById('excetab').getElementsByTagName('INPUT'),document.getElementById('chkExceptionsAll'));"/>
                                </td>
                            </tr>
                                         <tr id="trExceptionsEdit" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lblExceptionsEdit" runat="server" Text="Edit"></asp:Label>
                                </td>
                                <td style="height: 20px; width: 100px;">
                                    <asp:CheckBox ID="chkExceptionsEdit" runat="server"  onchange="selectOne(document.getElementById('excetab').getElementsByTagName('INPUT'),document.getElementById('chkExceptionsAll'));"/>
                                </td>
                            </tr>
                                         <tr id="trExceptionsDelete" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lblExceptionsDelete" runat="server" Text="Delete"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:CheckBox ID="chkExceptionsDelete" runat="server"  onchange="selectOne(document.getElementById('excetab').getElementsByTagName('INPUT'),document.getElementById('chkExceptionsAll'));"/>
                                </td>
                            </tr>
                               <tr id="trExceptionsPreview" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lblExceptionsPreview" runat="server" Text="Preview"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:CheckBox ID="chkExceptionsPreview"  runat="server"  onchange="selectOne(document.getElementById('excetab').getElementsByTagName('INPUT'),document.getElementById('chkExceptionsAll'));"/>
                                </td>
                            </tr> 
                               <tr id="trExceptionsApproval"  runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lblExceptionsApproval" runat="server" Text="Approval"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:CheckBox ID="chkExceptionsApproval" runat="server"  onchange="selectOne(document.getElementById('excetab').getElementsByTagName('INPUT'),document.getElementById('chkExceptionsAll'));"/>
                                </td>
                            </tr>      
                                    </table>
                                </td>
                            </tr>
                                                    
                        </table>
                             </ContentTemplate>
                             </asp:UpdatePanel>
                                </td>
         
                </tr>
            </table>
                            </td>
                        </tr>
                         <tr>
                            <td colspan="6">
                            <asp:UpdatePanel ID="UpdatePanel9" runat="server">
                             <ContentTemplate> 
                                <table width="97%" border="0">
                <tr>
                    <td class="datab" width="30%" valign="top">
                        <table id="tblMovies">
                            <tr>
                                <td style="width: 60%;" align="left">Movies</td>
                                <td class="style4" style="width: 100px">
                                    <asp:RadioButton ID="rbMYes" runat="server" GroupName="gMovie" Text="Yes" AutoPostBack="True"/>
                                    <asp:RadioButton ID="rbMNo" Checked="true" runat="server" GroupName="gMovie" Text="No" AutoPostBack="True" />
                                </td>
                            </tr>
                            <tr id="trMovies" runat="server">
                                <td colspan="2">
                                    <table width="100%" id="mvtab">
                                    <tr id="trMoviesAll" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="Label3" runat="server" Text="Select All"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                   <asp:CheckBox ID="chkMoviesAll" runat="server" 
                                         AutoPostBack="true" oncheckedchanged="chkMoviesAll_CheckedChanged" />
                                </td>
                            </tr>
                                         <tr id="trMoviesPost" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="Label4" runat="server" Text="Post"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                   <asp:CheckBox ID="chkMoviesPost" runat="server"  onchange="selectOne(document.getElementById('mvtab').getElementsByTagName('INPUT'),document.getElementById('chkMoviesAll'));"/>
                                </td>
                            </tr>
                                         <tr id="trMoviesEdit" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="Label5" runat="server" Text="Edit"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:CheckBox ID="chkMoviesEdit" runat="server" onchange="selectOne(document.getElementById('mvtab').getElementsByTagName('INPUT'),document.getElementById('chkMoviesAll'));"/>
                                </td>
                            </tr>
                                         <tr id="trMoviesDelete" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="Label6" runat="server" Text="Delete"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:CheckBox ID="chkMoviesDelete" runat="server" onchange="selectOne(document.getElementById('mvtab').getElementsByTagName('INPUT'),document.getElementById('chkMoviesAll'));"/>
                                </td>
                            </tr>
                             <tr id="trMoviesView" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="Label7" runat="server" Text="Preview"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                     <asp:CheckBox ID="ChkMoviesView" runat="server" onchange="selectOne(document.getElementById('mvtab').getElementsByTagName('INPUT'),document.getElementById('chkMoviesAll'));"/>
                                </td>
                            </tr>  
                             <tr id="trMoviesApproval" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lblMoviesApproval" runat="server" Text="Approval"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                     <asp:CheckBox ID="chkMoviesApproval" runat="server" onchange="selectOne(document.getElementById('mvtab').getElementsByTagName('INPUT'),document.getElementById('chkMoviesAll'));"/>
                                </td>
                            </tr>                                            
                             </table>
                                </td>
                            </tr>                                                 
                        </table>
                    </td>
                    <td class="datab" width="30%" valign="top">
                        <table id="tblCT">
                            <tr>
                                <td  style="width: 60%;" align="left">
                                    City Trends
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:RadioButton ID="rbCTYes" runat="server" GroupName="gCT" Text="Yes" AutoPostBack="True" />
                                    <asp:RadioButton ID="rbCTNo" Checked="true" runat="server" GroupName="gCT" Text="No" AutoPostBack="True" />
                                </td>
                            </tr>
                            <tr id="trCT" runat="server">
                                <td colspan="2">
                                    <table width="100%" id="cittab">
                                    <tr id="trCTAll" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="Label9" runat="server" Text="Select All"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                   <asp:CheckBox ID="chkCTAll" runat="server" 
                                         AutoPostBack="true" oncheckedchanged="chkCTAll_CheckedChanged" />
                                </td>
                            </tr>
                                         <tr id="trCTPost" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="Label10" runat="server" Text="Post"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:CheckBox ID="chkCTPost" runat="server" onchange="selectOne(document.getElementById('cittab').getElementsByTagName('INPUT'),document.getElementById('chkCTAll'));"/>
                                </td>
                            </tr>
                                         <tr id="trCTEdit" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="Label11" runat="server" Text="Edit"></asp:Label>
                                </td>
                                <td style="height: 20px; width: 100px;">
                                    <asp:CheckBox ID="chkCTEdit" runat="server" onchange="selectOne(document.getElementById('cittab').getElementsByTagName('INPUT'),document.getElementById('chkCTAll'));"/>
                                </td>
                            </tr>
                                         <tr id="trCTDelete" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="Label12" runat="server" Text="Delete"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:CheckBox ID="chkCTDelete" runat="server" onchange="selectOne(document.getElementById('cittab').getElementsByTagName('INPUT'),document.getElementById('chkCTAll'));"/>
                                </td>
                            </tr>
                              <tr id="trCTView" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="Label13" runat="server" Text="Preview"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:CheckBox ID="chkCTView" runat="server" onchange="selectOne(document.getElementById('cittab').getElementsByTagName('INPUT'),document.getElementById('chkCTAll'));"/>
                                </td>
                             </tr>  
                               <tr id="trCTApproval" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lblCTApproval" runat="server" Text="Approval"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                     <asp:CheckBox ID="chkCTApproval" runat="server" onchange="selectOne(document.getElementById('cittab').getElementsByTagName('INPUT'),document.getElementById('chkCTAll'));"/>
                                </td>
                              </tr>                                           
                            </table>
                                </td>
                            </tr>
                                                    
                        </table>
                    </td>
                    <td class="datab" width="30%" valign="top">
                        <table id="tblMS">
                            <tr>
                                <td  style="width: 60%;" align="left">
                                    Media Speak
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:RadioButton ID="rbMSYes" runat="server" GroupName="gMS" Text="Yes" AutoPostBack="True" />
                                    <asp:RadioButton ID="rbMSNo" Checked="true" runat="server" GroupName="gMS" Text="No" AutoPostBack="True" />
                                </td>
                            </tr>
                            <tr id="trMS" runat="server">
                                <td colspan="2">
                                    <table width="100%" id="mdtab">
                                    <tr id="trMSAll" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="Label15" runat="server" Text="Select All"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                   <asp:CheckBox ID="chkMSAll" runat="server" 
                                         AutoPostBack="true" oncheckedchanged="chkMSAll_CheckedChanged" />
                                </td>
                            </tr>
                                         <tr id="trMSPost" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="Label16" runat="server" Text="Post"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:CheckBox ID="chkMSPost" runat="server" onchange="selectOne(document.getElementById('mdtab').getElementsByTagName('INPUT'),document.getElementById('chkMSAll'));"/>
                                </td>
                            </tr>
                                         <tr id="trMSEdit" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="Label17" runat="server" Text="Edit"></asp:Label>
                                </td>
                                <td style="height: 20px; width: 100px;">
                                    <asp:CheckBox ID="chkMSEdit" runat="server" onchange="selectOne(document.getElementById('mdtab').getElementsByTagName('INPUT'),document.getElementById('chkMSAll'));"/>
                                </td>
                            </tr>
                                         <tr id="trMSDelete" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="Label18" runat="server" Text="Delete"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:CheckBox ID="chkMSDelete" runat="server" onchange="selectOne(document.getElementById('mdtab').getElementsByTagName('INPUT'),document.getElementById('chkMSAll'));"/>
                                </td>
                            </tr>
                              <tr id="trMSView" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="Label19" runat="server" Text="Preview"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:CheckBox ID="chkMSView" runat="server" onchange="selectOne(document.getElementById('mdtab').getElementsByTagName('INPUT'),document.getElementById('chkMSAll'));"/>
                                </td>
                            </tr> 
                             <tr id="trMSApproval" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lblMSApproval" runat="server" Text="Approval"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                     <asp:CheckBox ID="chkMSApproval" runat="server" onchange="selectOne(document.getElementById('mdtab').getElementsByTagName('INPUT'),document.getElementById('chkMSAll'));"/>
                                </td>
                              </tr>                                              
                              </table>
                                </td>
                            </tr>                                                                    
                        </table>
                    </td>
                </tr>
            </table>
            </ContentTemplate>
                           </asp:UpdatePanel>
                            </td>
                        </tr>
                         <tr>
                            <td colspan="6">
                            <asp:UpdatePanel ID="UpdatePanel10" runat="server">
                             <ContentTemplate> 
                                <table width="97%" border="0">
                         <tr>
                    <td class="datab" width="30%" valign="top">
                        <table id="tblAds">
                            <tr>
                                <td  style="width: 60%;" align="left">Ads</td>
                                <td class="style4" style="width: 100px">
                                    <asp:RadioButton ID="rbAdsYes" runat="server" GroupName="gAds" Text="Yes" AutoPostBack="True"/>
                                    <asp:RadioButton ID="rbAdsNo" Checked="true" runat="server" GroupName="gAds" Text="No" AutoPostBack="True" />
                                </td>
                            </tr>
                            <tr id="trAds" runat="server">
                                <td colspan="2">
                                    <table width="100%" id="adtab">
                                    <tr id="trAdsAll" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="Label21" runat="server" Text="Select All"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                   <asp:CheckBox ID="chkAdsAll" runat="server" 
                                        AutoPostBack="true" oncheckedchanged="chkAdsAll_CheckedChanged" />
                                </td>
                            </tr>
                                         <tr id="trAdsPost" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="Label22" runat="server" Text="Post"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                   <asp:CheckBox ID="chkAdsPost" runat="server" onchange="selectOne(document.getElementById('adtab').getElementsByTagName('INPUT'),document.getElementById('chkAdsAll'));"/>
                                </td>
                            </tr>
                                         <tr id="trAdsEdit" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="Label23" runat="server" Text="Edit"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:CheckBox ID="chkAdsEdit" runat="server" onchange="selectOne(document.getElementById('adtab').getElementsByTagName('INPUT'),document.getElementById('chkAdsAll'));"/>
                                </td>
                            </tr>
                                         <tr id="trAdsDelete" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="Label24" runat="server" Text="Delete"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:CheckBox ID="chkAdsDelete" runat="server" onchange="selectOne(document.getElementById('adtab').getElementsByTagName('INPUT'),document.getElementById('chkAdsAll'));"/>
                                </td>
                            </tr>
                                         <tr id="trAdsView" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="Label25" runat="server" Text="Preview"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                     <asp:CheckBox ID="chkAdsView" runat="server" onchange="selectOne(document.getElementById('adtab').getElementsByTagName('INPUT'),document.getElementById('chkAdsAll'));"/>
                                </td>
                            </tr>
                             <tr id="trAdsApproval" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lblAdsApproval" runat="server" Text="Approval"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                     <asp:CheckBox ID="chkAdsApproval" runat="server" onchange="selectOne(document.getElementById('adtab').getElementsByTagName('INPUT'),document.getElementById('chkAdsAll'));"/>
                                </td>
                              </tr>                                       
                              </table>
                                </td>
                            </tr>                                                 
                        </table>
                    </td>
                    <td class="datab" width="30%" valign="top">
                        <table id="tblFL">
                            <tr>
                                <td  style="width: 60%;" align="left">
                                    Free Listing
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:RadioButton ID="rbFLYes" runat="server" GroupName="gFL" Text="Yes" AutoPostBack="True" />
                                    <asp:RadioButton ID="rbFLNo" Checked="true" runat="server" GroupName="gFL" Text="No" AutoPostBack="True" />
                                </td>
                            </tr>
                            <tr id="trFL" runat="server">
                                <td colspan="2">
                                    <table width="100%" id="frtab">
                                    <tr id="trFLAll" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="Label27" runat="server" Text="Select All"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                   <asp:CheckBox ID="chkFreelistAll" runat="server" 
                                        AutoPostBack="true" oncheckedchanged="chkFreelistAll_CheckedChanged" />
                                </td>
                            </tr>
                                         <tr id="trFLPost" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="Label28" runat="server" Text="Post"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:CheckBox ID="chkFreelistPost" runat="server" onchange="selectOne(document.getElementById('frtab').getElementsByTagName('INPUT'),document.getElementById('chkFreelistAll'));"/>
                                </td>
                            </tr>
                                         <tr id="trFLEdit" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="Label29" runat="server" Text="Edit"></asp:Label>
                                </td>
                                <td style="height: 20px; width: 100px;">
                                    <asp:CheckBox ID="chkFreelistEdit" runat="server" onchange="selectOne(document.getElementById('frtab').getElementsByTagName('INPUT'),document.getElementById('chkFreelistAll'));"/>
                                </td>
                            </tr>
                                         <tr id="trFLDelete" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="Label30" runat="server" Text="Delete"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:CheckBox ID="chkFreelistDelete" runat="server" onchange="selectOne(document.getElementById('frtab').getElementsByTagName('INPUT'),document.getElementById('chkFreelistAll'));"/>
                                </td>
                            </tr>
                                         <tr id="trFLView" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="Label31" runat="server" Text="Preview"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:CheckBox ID="chkFreelistView" runat="server" onchange="selectOne(document.getElementById('frtab').getElementsByTagName('INPUT'),document.getElementById('chkFreelistAll'));"/>
                                </td>
                            </tr> 
                                         <tr id="trFLApprove" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="Label32" runat="server" Text="Approval"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                     <asp:CheckBox ID="chkFLApprove" runat="server" onchange="selectOne(document.getElementById('frtab').getElementsByTagName('INPUT'),document.getElementById('chkFreelistAll'));"/>
                                </td>
                            </tr>  
                                    </table>
                                </td>
                            </tr>
                                                    
                        </table>
                    </td>
                    <td class="datab" width="30%" valign="top">
                                    <asp:UpdatePanel ID="UpdatePanel13" runat="server">
                             <ContentTemplate> 
                                <table id="tblwp">
                            <tr>
                                <td style="width: 60%;" align="left">
                                    White Pages
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:RadioButton ID="rbwpyes" runat="server" GroupName="gwp" Text="Yes" AutoPostBack="True" />
                                    <asp:RadioButton ID="rbwpno" runat="server" GroupName="gwp" Text="No" AutoPostBack="True" Checked="true" />
                                </td>
                            </tr>
                            <tr id="trwp" runat="server">
                                <td colspan="2">
                                    <table width="100%" id="wttab">
                                    <tr id="trwpall" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="Label8" runat="server" Text="Select All"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                   <asp:CheckBox ID="chkwhiteall" runat="server" 
                                        AutoPostBack="true" oncheckedchanged="chkwhiteall_CheckedChanged" />
                                </td>
                            </tr>
                                         <tr id="trwhitepost" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="Label14" runat="server" Text="Post"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:CheckBox ID="chkwhitepost" runat="server" onchange="selectOne(document.getElementById('wttab').getElementsByTagName('INPUT'),document.getElementById('chkwhiteall'));"/>
                                </td>
                            </tr>
                                         <tr id="trwhiteedit" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="Label20" runat="server" Text="Edit"></asp:Label>
                                </td>
                                <td style="height: 20px; width: 100px;">
                                    <asp:CheckBox ID="chkwhiteedit" runat="server" onchange="selectOne(document.getElementById('wttab').getElementsByTagName('INPUT'),document.getElementById('chkwhiteall'));"/>
                                </td>
                            </tr>
                                         <tr id="trwhitedelete" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="Label26" runat="server" Text="Delete"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:CheckBox ID="chkwhitedelete" runat="server" onchange="selectOne(document.getElementById('wttab').getElementsByTagName('INPUT'),document.getElementById('chkwhiteall'));"/>
                                </td>
                            </tr>
                               <tr id="trwhitepreview" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="Label33" runat="server" Text="Preview"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:CheckBox ID="chkwhitepreview" runat="server" onchange="selectOne(document.getElementById('wttab').getElementsByTagName('INPUT'),document.getElementById('chkwhiteall'));" />
                                </td>
                            </tr> 
                             <tr id="trwhiteApproval" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lblwhiteApproval" runat="server" Text="Approval"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                     <asp:CheckBox ID="chkwhiteApproval" runat="server" onchange="selectOne(document.getElementById('wttab').getElementsByTagName('INPUT'),document.getElementById('chkwhiteall'));"/>
                                </td>
                              </tr> 
                                        
                                    </table>
                                </td>
                            </tr>
                                                    
                        </table>
                             </ContentTemplate>
                             </asp:UpdatePanel>
                                </td>
                                </tr>
                                </table>
                                </ContentTemplate>
                                </asp:UpdatePanel>
                                </td>
                         </tr>
                         <tr>
                         <td colspan="6">
                            <asp:UpdatePanel ID="UpdatePanel7" runat="server">
                             <ContentTemplate> 
                                <table width="97%" border="0">
                                  <tr>
                                <td class="datab" width="30%" valign="top">
                                    <asp:UpdatePanel ID="UpdatePanel16" runat="server">
                             <ContentTemplate> 
                                <table id="Table2">
                            <tr>
                                <td class="tblsuccess" style="width: 60%;" align="left">
                                    Success Stories
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:RadioButton ID="rbssyes" runat="server" GroupName="gss" Text="Yes" AutoPostBack="True" />
                                    <asp:RadioButton ID="rbssno" runat="server" GroupName="gss" Text="No" AutoPostBack="True" Checked="true" />
                                </td>
                            </tr>
                            <tr id="trsuccess" runat="server">
                                <td colspan="2">
                                    <table width="100%" id="suctab">
                                    <tr id="trsuccessall" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="Label34" runat="server" Text="Select All"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                   <asp:CheckBox ID="chksuccessall" runat="server" 
                                        AutoPostBack="true" oncheckedchanged="chksuccessall_CheckedChanged" />
                                </td>
                            </tr>
                                         <tr id="trsuccesspost" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="Label35" runat="server" Text="Post"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:CheckBox ID="chksuccesspost" runat="server" onchange="selectOne(document.getElementById('suctab').getElementsByTagName('INPUT'),document.getElementById('chksuccessall'));"/>
                                </td>
                            </tr>
                                         <tr id="trsuccessedit" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="Label36" runat="server" Text="Edit"></asp:Label>
                                </td>
                                <td style="height: 20px; width: 100px;">
                                    <asp:CheckBox ID="chksuccessedit" runat="server" onchange="selectOne(document.getElementById('suctab').getElementsByTagName('INPUT'),document.getElementById('chksuccessall'));"/>
                                </td>
                            </tr>
                                         <tr id="trsuccessdelete" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="Label37" runat="server" Text="Delete"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:CheckBox ID="chksuccessdelete" runat="server" onchange="selectOne(document.getElementById('suctab').getElementsByTagName('INPUT'),document.getElementById('chksuccessall'));"/>
                                </td>
                            </tr>
                              <tr id="trsuccesspreview" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="Label38" runat="server" Text="Preview"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:CheckBox ID="chksuccesspreview" runat="server" onchange="selectOne(document.getElementById('suctab').getElementsByTagName('INPUT'),document.getElementById('chksuccessall'));"/>
                                </td>
                            </tr> 
                              <tr id="trsuccessApproval" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lblsuccessApproval" runat="server" Text="Approval"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                     <asp:CheckBox ID="chksuccessApproval" runat="server" onchange="selectOne(document.getElementById('suctab').getElementsByTagName('INPUT'),document.getElementById('chksuccessall'));"/>
                                </td>
                              </tr> 
                             </table>
                                </td>
                            </tr>
                                                    
                        </table>
                             </ContentTemplate>
                             </asp:UpdatePanel>
                                </td>
                                <td class="datab" width="30%" valign="top">
                                    <asp:UpdatePanel ID="UpdatePanel17" runat="server">
                             <ContentTemplate> 
                                <table id="tblcsr">
                            <tr>
                                <td  style="width: 60%;" align="left">
                                    Social Welfare Info.
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:RadioButton ID="rbcsryes" runat="server" GroupName="gcsr" Text="Yes" AutoPostBack="True" />
                                    <asp:RadioButton ID="rbcsrno" runat="server" GroupName="gcsr" Text="No" AutoPostBack="True" Checked="true" />
                                </td>
                            </tr>
                            <tr id="trscr" runat="server">
                                <td colspan="2">
                                    <table width="100%" id="sociatab">
                                    <tr id="trscrall" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="Label40" runat="server" Text="Select All"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                   <asp:CheckBox ID="chkcsrall" runat="server" 
                                        AutoPostBack="true" oncheckedchanged="chkcsrall_CheckedChanged" />
                                </td>
                            </tr>
                                         <tr id="trscrpost" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="Label41" runat="server" Text="Post"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:CheckBox ID="chkcsrpost" runat="server" onchange="selectOne(document.getElementById('sociatab').getElementsByTagName('INPUT'),document.getElementById('chkcsrall'));"/>
                                </td>
                            </tr>
                                         <tr id="trscredit" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="Label42" runat="server" Text="Edit"></asp:Label>
                                </td>
                                <td style="height: 20px; width: 100px;">
                                    <asp:CheckBox ID="chkcsredit" runat="server" onchange="selectOne(document.getElementById('sociatab').getElementsByTagName('INPUT'),document.getElementById('chkcsrall'));"/>
                                </td>
                            </tr>
                                         <tr id="trscrdelete" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="Label43" runat="server" Text="Delete"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:CheckBox ID="chkcsrdelete" runat="server" onchange="selectOne(document.getElementById('sociatab').getElementsByTagName('INPUT'),document.getElementById('chkcsrall'));"/>
                                </td>
                            </tr>
                                         <tr id="trscrpreview" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="Label44" runat="server" Text="Preview"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:CheckBox ID="chkcsrpreview" runat="server" onchange="selectOne(document.getElementById('sociatab').getElementsByTagName('INPUT'),document.getElementById('chkcsrall'));"/>
                                </td>
                            </tr> 
                              <tr id="trscrApproval" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lblscrApproval" runat="server" Text="Approval"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:CheckBox ID="chkscrApproval" runat="server" onchange="selectOne(document.getElementById('sociatab').getElementsByTagName('INPUT'),document.getElementById('chkcsrall'));"/>
                                </td>
                            </tr> 
                                        
                                    </table>
                                </td>
                            </tr>
                                                    
                        </table>
                             </ContentTemplate>
                             </asp:UpdatePanel>
                                </td>
                                <td class="datab" width="30%" valign="top">
                                    <asp:UpdatePanel ID="UpdatePanel18" runat="server">
                             <ContentTemplate> 
                                <table id="tblsnf">
                            <tr>
                                <td style="width: 60%;" align="left">
                                    Search not found
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:RadioButton ID="rbsnfyes" runat="server" GroupName="gsnf" Text="Yes" AutoPostBack="True" />
                                    <asp:RadioButton ID="rbsnfno" runat="server" GroupName="gsnf" Text="No" AutoPostBack="True" Checked="true" />
                                </td>
                            </tr>
                            <tr id="trsnf" runat="server">
                                <td colspan="2">
                                    <table width="100%" id="seantab">
                                    <tr id="trsnfall" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="Label46" runat="server" Text="Select All"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                   <asp:CheckBox ID="chksnfall" runat="server" 
                                        AutoPostBack="true" oncheckedchanged="chksnfall_CheckedChanged" />
                                </td>
                            </tr>
                                         <tr id="trsnfpost" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="Label47" runat="server" Text="Post"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:CheckBox ID="chksnpost" runat="server" onchange="selectOne(document.getElementById('seantab').getElementsByTagName('INPUT'),document.getElementById('chksnfall'));"/>
                                </td>
                            </tr>
                                         <tr id="trsnfEdit" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lblsnfEdit" runat="server" Text="Edit"></asp:Label>
                                </td>
                                <td style="height: 20px; width: 100px;">
                                    <asp:CheckBox ID="chksnfEdit" runat="server"  onchange="selectOne(document.getElementById('seantab').getElementsByTagName('INPUT'),document.getElementById('chksnfall'));"/>
                                </td>
                            </tr>
                                         <tr id="trsnfdelete" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="Label49" runat="server" Text="Delete"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:CheckBox ID="chksnfdelete" runat="server" onchange="selectOne(document.getElementById('seantab').getElementsByTagName('INPUT'),document.getElementById('chksnfall'));" />
                                </td>
                            </tr>
                                         <tr id="trsnfPreview" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lblsnfPreview" runat="server" Text="Preview"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:CheckBox ID="chksnfPreview" runat="server"  onchange="selectOne(document.getElementById('seantab').getElementsByTagName('INPUT'),document.getElementById('chksnfall'));"/>
                                </td>
                            </tr> 
                              <tr id="trsnfApproval" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lblsnfApproval" runat="server" Text="Approval"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:CheckBox ID="chksnfApproval" runat="server"  onchange="selectOne(document.getElementById('seantab').getElementsByTagName('INPUT'),document.getElementById('chksnfall'));" />
                                </td>
                            </tr> 
                            </table>
                                </td>
                            </tr>
                                                    
                        </table>
                             </ContentTemplate>
                             </asp:UpdatePanel>
                                </td>
                                 </tr>
                                </table>
                           </ContentTemplate> 
                               </asp:UpdatePanel>
                                </td>
                    
                </tr>
                         <tr>
                         <td colspan="6">
                            <asp:UpdatePanel ID="UpdatePanel15" runat="server">
                             <ContentTemplate> 
                                <table width="97%" border="0">
                                  <tr>
                        <td class="datab" width="30%" valign="top">
                            <asp:UpdatePanel ID="UpdatePanel11" runat="server">
                        <ContentTemplate> 
                        <table id="tblslinks">
                    <tr>
                        <td style="width: 60%;" align="left">
                            Sponsered Links
                        </td>
                        <td class="style4" style="width: 100px">
                            <asp:RadioButton ID="rbslyes" runat="server" GroupName="gsl" Text="Yes" AutoPostBack="True" />
                            <asp:RadioButton ID="rbslno" runat="server" GroupName="gsl" Text="No" AutoPostBack="True" Checked="true" />
                        </td>
                    </tr>
                    <tr id="trslink" runat="server">
                        <td colspan="2">
                            <table width="100%" id="sponstab">
                            <tr id="trslall" runat="server">
                        <td class="datap5">
                            <asp:Label ID="Label39" runat="server" Text="Select All"></asp:Label>
                        </td>
                        <td class="style4" style="width: 100px">
                            <asp:CheckBox ID="chkslall" runat="server" 
                                AutoPostBack="true" oncheckedchanged="chkslall_CheckedChanged" />
                        </td>
                    </tr>
                                    <tr id="trslpost" runat="server">
                        <td class="datap5">
                            <asp:Label ID="Label45" runat="server" Text="Post"></asp:Label>
                        </td>
                        <td class="style4" style="width: 100px">
                            <asp:CheckBox ID="chkslpost" runat="server"  onchange="selectOne(document.getElementById('sponstab').getElementsByTagName('INPUT'),document.getElementById('chkslall'));"/>
                        </td>
                    </tr>
                                    <tr id="trsledit" runat="server">
                        <td class="datap5">
                            <asp:Label ID="Label48" runat="server" Text="Edit"></asp:Label>
                        </td>
                        <td style="height: 20px; width: 100px;">
                            <asp:CheckBox ID="chksledit" runat="server" onchange="selectOne(document.getElementById('sponstab').getElementsByTagName('INPUT'),document.getElementById('chkslall'));"/>
                        </td>
                    </tr>
                                    <tr id="trsldel" runat="server">
                        <td class="datap5">
                            <asp:Label ID="Label50" runat="server" Text="Delete"></asp:Label>
                        </td>
                        <td class="style4" style="width: 100px">
                            <asp:CheckBox ID="chksldel" runat="server" onchange="selectOne(document.getElementById('sponstab').getElementsByTagName('INPUT'),document.getElementById('chkslall'));"/>
                        </td>
                    </tr>
                        <tr id="trslview" runat="server">
                        <td class="datap5">
                            <asp:Label ID="Label51" runat="server" Text="Preview"></asp:Label>
                        </td>
                        <td class="style4" style="width: 100px">
                            <asp:CheckBox ID="chkslview" runat="server" onchange="selectOne(document.getElementById('sponstab').getElementsByTagName('INPUT'),document.getElementById('chkslall'));"/>
                        </td>

                    </tr> 
                        <tr id="trslApproval" runat="server">
                        <td class="datap5">
                            <asp:Label ID="lblslApproval" runat="server" Text="Approval"></asp:Label>
                        </td>
                        <td class="style4" style="width: 100px">
                            <asp:CheckBox ID="chkslApproval" runat="server" onchange="selectOne(document.getElementById('sponstab').getElementsByTagName('INPUT'),document.getElementById('chkslall'));"/>
                        </td>

                    </tr> 
                                        
                            </table>
                        </td>
                    </tr>
                                                    
                </table>
                        </ContentTemplate>
                        </asp:UpdatePanel>
                        </td>
                        <td class="datab" width="30%" valign="top">
                            <asp:UpdatePanel ID="UpdatePanel12" runat="server">
                        <ContentTemplate> 
                        <table id="tbltest">
                    <tr>
                        <td  style="width: 60%;" align="left">
                            Testimonials
                        </td>
                        <td class="style4" style="width: 100px">
                            <asp:RadioButton ID="rbtestyes" runat="server" GroupName="gtest" Text="Yes" 
                                AutoPostBack="True"  />
                            <asp:RadioButton ID="rbtestno" runat="server" GroupName="gtest" Text="No" 
                                AutoPostBack="True" Checked="true" />
                        </td>
                    </tr>
                    <tr id="trtest" runat="server">
                        <td colspan="2">
                            <table width="100%" id="testitab">
                            <tr id="tr10" runat="server">
                        <td class="datap5">
                            <asp:Label ID="Label57" runat="server" Text="Select All"></asp:Label>
                        </td>
                        <td class="style4" style="width: 100px">
                            <asp:CheckBox ID="chktestAll" runat="server" 
                                AutoPostBack="true" oncheckedchanged="chkslall_CheckedChanged" />
                        </td>
                    </tr>
                                    <tr id="trtestimonialPost" runat="server">
                        <td class="datap5">
                            <asp:Label ID="lbltestimonialPost" runat="server" Text="Post"></asp:Label>
                        </td>
                        <td class="style4" style="width: 100px">
                            <asp:CheckBox ID="chktesPost" runat="server" onchange="selectOne(document.getElementById('testitab').getElementsByTagName('INPUT'),document.getElementById('chktestAll'));"/>
                        </td>
                    </tr>
                                    <tr id="trtestimonialEdit" runat="server">
                        <td class="datap5">
                            <asp:Label ID="lbltestimonialEdit" runat="server" Text="Edit"></asp:Label>
                        </td>
                        <td style="height: 20px; width: 100px;">
                            <asp:CheckBox ID="chktesEdit" runat="server" onchange="selectOne(document.getElementById('testitab').getElementsByTagName('INPUT'),document.getElementById('chktestAll'));"/>
                        </td>
                    </tr>
                                    <tr id="trtestimonialDelete" runat="server">
                        <td class="datap5">
                            <asp:Label ID="lbltestimonialDelete" runat="server" Text="Delete"></asp:Label>
                        </td>
                        <td class="style4" style="width: 100px">
                            <asp:CheckBox ID="chktesDelete" runat="server" onchange="selectOne(document.getElementById('testitab').getElementsByTagName('INPUT'),document.getElementById('chktestAll'));"/>
                        </td>
                    </tr>
                                    <tr id="trtestimonialPreview" runat="server">
                        <td class="datap5">
                            <asp:Label ID="lbltestimonialPreview" runat="server" Text="Preview"></asp:Label>
                        </td>
                        <td class="style4" style="width: 100px">
                            <asp:CheckBox ID="chktesPreview" runat="server" onchange="selectOne(document.getElementById('testitab').getElementsByTagName('INPUT'),document.getElementById('chktestAll'));"/>
                        </td>
                    </tr> 
                                <tr id="trtestimonialApproval" runat="server">
                        <td class="datap5">
                            <asp:Label ID="lbltestimonialApproval" runat="server" Text="Approval"></asp:Label>
                        </td>
                        <td class="style4" style="width: 100px">
                            <asp:CheckBox ID="chktestApproval" runat="server" onchange="selectOne(document.getElementById('testitab').getElementsByTagName('INPUT'),document.getElementById('chktestAll'));"/>
                        </td>
                    </tr>     
                            </table>
                        </td>
                    </tr>
                                                    
                </table>
                        </ContentTemplate>
                        </asp:UpdatePanel>
                        </td>
                        <td class="datab" width="30%" valign="top">
                            <asp:UpdatePanel ID="UpdatePanel14" runat="server">
                        <ContentTemplate> 
                        <table id="Table3">
                    <tr>
                        <td style="width: 60%;" align="left">
                            Customer Care
                        </td>
                        <td class="style4" style="width: 100px">
                            <asp:RadioButton ID="rbccareyes" runat="server" GroupName="gcc" Text="Yes" 
                                AutoPostBack="True"  />
                            <asp:RadioButton ID="rbccareno" runat="server" GroupName="gcc" Text="No" 
                                AutoPostBack="True" Checked="true" 
                                />
                        </td>
                    </tr>
                    <tr id="trCustomers" runat="server">
                        <td colspan="2">
                            <table width="100%" id="custtab">
                            <tr id="trCustAll" runat="server">
                        <td class="datap5">
                            <asp:Label ID="lblCustAll" runat="server" Text="Select All"></asp:Label>
                        </td>
                        <td class="style4" style="width: 100px">
                            <asp:CheckBox ID="chkCustAll" runat="server" 
                                AutoPostBack="true" oncheckedchanged="chkslall_CheckedChanged" />
                        </td>
                    </tr>
                                    <tr id="trCustPost" runat="server">
                        <td class="datap5">
                            <asp:Label ID="lblCustPost" runat="server" Text="Post"></asp:Label>
                        </td>
                        <td class="style4" style="width: 100px">
                            <asp:CheckBox ID="chkCustPost" runat="server" onchange="selectOne(document.getElementById('custtab').getElementsByTagName('INPUT'),document.getElementById('chkCustAll'));"/>
                        </td>
                    </tr>
                                    <tr id="trCustEdit" runat="server">
                        <td class="datap5">
                            <asp:Label ID="lblCustEdit" runat="server" Text="Edit"></asp:Label>
                        </td>
                        <td style="height: 20px; width: 100px;">
                            <asp:CheckBox ID="chkCustEdit" runat="server" onchange="selectOne(document.getElementById('custtab').getElementsByTagName('INPUT'),document.getElementById('chkCustAll'));"/>
                        </td>
                    </tr>
                                    <tr id="trCustDelete" runat="server">
                        <td class="datap5">
                            <asp:Label ID="lblCustDelete" runat="server" Text="Delete"></asp:Label>
                        </td>
                        <td class="style4" style="width: 100px">
                            <asp:CheckBox ID="chkCustDelete" runat="server" onchange="selectOne(document.getElementById('custtab').getElementsByTagName('INPUT'),document.getElementById('chkCustAll'));"/>
                        </td>
                    </tr>
                        <tr id="trCustPreview" runat="server">
                        <td class="datap5">
                            <asp:Label ID="lblCustPreview" runat="server" Text="Preview"></asp:Label>
                        </td>
                        <td class="style4" style="width: 100px">
                            <asp:CheckBox ID="chkCustPreview" runat="server" onchange="selectOne(document.getElementById('custtab').getElementsByTagName('INPUT'),document.getElementById('chkCustAll'));"/>
                        </td>
                    </tr> 
                        <tr id="trcustApproval" runat="server">
                        <td class="datap5">
                            <asp:Label ID="lblcustApproval" runat="server" Text="Approval"></asp:Label>
                        </td>
                        <td class="style4" style="width: 100px">
                            <asp:CheckBox ID="chkcustApproval" runat="server" onchange="selectOne(document.getElementById('custtab').getElementsByTagName('INPUT'),document.getElementById('chkCustAll'));"/>
                        </td>
                    </tr> 
                                        
                            </table>
                        </td>
                    </tr>
                                                    
                </table>
                        </ContentTemplate>
                        </asp:UpdatePanel>
                        </td>
                          </tr>
                          </table>
                        </ContentTemplate>
                           </asp:UpdatePanel>
                            </td>
                        </tr>

                                               
                        <tr><td colspan="6" style="height:50px;padding-top:8px;" align="center">
                            <asp:Button ID="btnCreate" runat="server" Text="Create User" 
                                onclick="btnCreate_Click" ValidationGroup="WebAdminCreation" /></td></tr>
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
