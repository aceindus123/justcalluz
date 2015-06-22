<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Admin_WebAdminViewEdit.aspx.cs" Inherits="admin_Admin_WebAdminViewEdit" %>
<%@ Register Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" TagPrefix="cc3"  %>
<%@ Register Src="~/admin/user_control/Admin_Headermenu.ascx" TagName="Headermenu" TagPrefix="cc1" %>
<%@ Register Src="~/admin/user_control/Admin_LeftMenu.ascx" TagName="LeftMenu" TagPrefix="cc4" %>
<%@ Register Src="~/admin/user_control/Admin_WebAdminHeader.ascx" TagName="webadminHeader" TagPrefix="WAHeader"%>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<title>Justcalluz - Admin Control Panel - Update Web Admin</title>
    <link href="~/admin/includes/style.css" rel="Stylesheet" type="text/css" />
    <script type="text/javasrcipt" src="http://ajax.googleapis.com/ajax/libs/jquery/1.6.2/jquery.min.js"></script>
    <script src="js/statesopt.js"></script>
    <style type="text/css">
        .style39
        {
            width: 195px;
        }        
        .style42
        {
            height: 23px;
        }
        </style>
        <script type="text/javascript" src="js/tab.js"></script>
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
    <div>
       <table cellpadding="0" cellspacing="0">
         <tr>
            <td>
             <cc1:headermenu ID="header" runat="server" />
            </td>
         </tr>
         <tr>
           <td>                  
            <table cellpadding="0" cellspacing="0" width="770px">
              <tr>
                <td class="style39" valign="top" style="padding-top:10px">                         
                 <cc4:LeftMenu ID="LeftMenu1" runat="server" />
                </td>
                <td valign="top">&nbsp;</td>
                <td valign="top" align="center"  style="padding-left:10px; background-color:#F2FAFC">
                    <table width="750px">
                    <tr>
                        <td colspan="6">
                            <WAHeader:webadminHeader ID="wahead1" runat="server" />
                        </td>
                    </tr>
                    <tr><td>
                        <asp:ScriptManager ID="ScriptManager1" runat="server">
                        </asp:ScriptManager>
                    </td></tr>
                        <tr><td colspan="6" class="style42">                                                
                            <asp:Label ID="Label2" runat="server" Text="To View Web Admin User details and to Edit Permissions" Font-Bold="true" Font-Size="Medium" ForeColor="OrangeRed"></asp:Label>
                        </td></tr>
                        <tr><td colspan="6" style="height:20px" ></td></tr>
                        <tr>
                            <td class="datab" align="right">
                                First Name
                            </td>
                            <td>:</td>
                            <td align="left">
                                <asp:Label ID="lblFName" runat="server"></asp:Label>                                
                            </td>
                            <td class="datab" align="right">
                               Last Name
                            </td>
                            <td>:</td>
                            <td align="left">                               
                                    <asp:Label ID="lblLName" runat="server"></asp:Label>
                            </td>
                        </tr>                                                
                        <tr><td colspan="6" style="height:5px"></td></tr>
                        <tr>
                            <td class="datab" align="right">
                               EmailId
                            </td>
                            <td>:</td>
                            <td align="left">                           
                           <asp:Label ID="lblEmail" runat="server"></asp:Label>
                            </td>
                            <td class="datab" align="right">
                               Password
                            </td>
                            <td>:</td>
                            <td align="left">                               
                                    <asp:Label ID="lblPwd" runat="server" Text="Label"></asp:Label>
                            </td>
                        </tr>
                        <tr><td colspan="6" style="height:20px"></td></tr>                       
                        <tr>
                            <td colspan="6">
                              <table width="90%" border="0">
                                <tr>
                                    <td class="datab" width="30%">
                                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                             <ContentTemplate> 
                                        <table id="tblBModule">
                                            <tr>
                                                <td class="datab" style="width: 97px">Business Category Module</td>
                                                <td class="style4" style="width: 100px">
                                                    <asp:RadioButton ID="rbBYes" runat="server" GroupName="gB" Text="Yes" AutoPostBack="True"/>
                                                    <asp:RadioButton ID="rbBNo" runat="server" GroupName="gB" Text="No" AutoPostBack="True" />
                                                </td>
                                            </tr>  
                                            <tr id="trIBModule" runat="server">
                                                <td colspan="2">
                                                    <table width="100%">
                                                    
                                                    <tr id="trBAll" runat="server">
                                                <td class="datap5">
                                                    <asp:Label ID="lblBAll" runat="server" Text="Select All"></asp:Label>
                                                </td>
                                                <td class="style4" style="width: 100px">
                                                   <asp:CheckBox ID="chkBAll" runat="server" 
                                                        oncheckedchanged="chkBAll_CheckedChanged" AutoPostBack="true" />
                                                </td>
                                            </tr>
                                                        <tr id="trBPost" runat="server">
                                                <td class="datap5">
                                                    <asp:Label ID="lblBPost" runat="server" Text="Post"></asp:Label>
                                                </td>
                                                <td class="style4" style="width: 100px">
                                                   <asp:CheckBox ID="chkbxBPost" runat="server" />
                                                </td>
                                            </tr>
                                                        <tr id="trBEdit" runat="server">
                                                <td class="datap5">
                                                    <asp:Label ID="lblBEdit" runat="server" Text="Edit"></asp:Label>
                                                </td>
                                                <td class="style4" style="width: 100px">
                                                    <asp:CheckBox ID="chkbxBEdit" runat="server" />
                                                </td>
                                            </tr>
                                                        <tr id="trBDel" runat="server">
                                                <td class="datap5">
                                                    <asp:Label ID="lblBDel" runat="server" Text="Delete"></asp:Label>
                                                </td>
                                                <td class="style4" style="width: 100px">
                                                    <asp:CheckBox ID="chkbxBDel" runat="server" />
                                                </td>
                                            </tr>
                                                        <tr id="trBPreview" runat="server">
                                                <td class="datap5">
                                                    <asp:Label ID="lblBPreview" runat="server" Text="Preview"></asp:Label>
                                                </td>
                                                <td class="style4" style="width: 100px">
                                                     <asp:CheckBox ID="chkbxBPreview" runat="server" />
                                                </td>
                                            </tr>   
                                                        <tr id="trBApproval" runat="server">
                                                <td class="datap5">
                                                    <asp:Label ID="lblBApproval" runat="server" Text="Approval"></asp:Label>
                                                </td>
                                                <td class="style4" style="width: 100px">
                                                     <asp:CheckBox ID="chkbxBApproval" runat="server" />
                                                </td>
                                            </tr>  
                                                    </table>
                                                </td>
                                            </tr>                                                                              
                                        </table>
                                       </ContentTemplate>
                                       </asp:UpdatePanel>
                                    </td>
                                    <td class="datab" width="30%">
                                    <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                                             <ContentTemplate> 
                                        <table id="tblB2Bmodule">
                                            <tr>
                                                <td class="datab" style="width: 97px">
                                                    B2B Category Module
                                                </td>
                                                <td class="style4" style="width: 100px">
                                                    <asp:RadioButton ID="rbB2BYes" runat="server" GroupName="gB2B" Text="Yes" AutoPostBack="True" />
                                                    <asp:RadioButton ID="rbB2BNo" runat="server" GroupName="gB2B" Text="No" AutoPostBack="True" />
                                                </td>
                                            </tr>
                                            <tr id="trIB2BModule" runat="server">
                                                <td colspan="2">
                                                    <table width="100%">
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
                                                    <asp:CheckBox ID="chkbxB2BPost" runat="server" />
                                                </td>
                                            </tr>
                                                        <tr id="trB2BEdit" runat="server">
                                                <td class="datap5">
                                                    <asp:Label ID="lblB2BEdit" runat="server" Text="Edit"></asp:Label>
                                                </td>
                                                <td style="height: 20px; width: 100px;">
                                                    <asp:CheckBox ID="chkbxB2BEdit" runat="server" />
                                                </td>
                                            </tr>
                                                        <tr id="trB2BDel" runat="server">
                                                <td class="datap5">
                                                    <asp:Label ID="lblB2BDel" runat="server" Text="Delete"></asp:Label>
                                                </td>
                                                <td class="style4" style="width: 100px">
                                                    <asp:CheckBox ID="chkbxB2BDel" runat="server" />
                                                </td>
                                            </tr>
                                                        <tr id="trB2BPreview" runat="server">
                                                <td class="datap5">
                                                    <asp:Label ID="lblB2Bview" runat="server" Text="Preview"></asp:Label>
                                                </td>
                                                <td class="style4" style="width: 100px">
                                                    <asp:CheckBox ID="chkbxB2Bview" runat="server" />
                                                </td>
                                            </tr>
                                                        <tr id="trB2BApproval" runat="server">
                                                <td class="datap5">
                                                    <asp:Label ID="lblB2BApproval" runat="server" Text="Approval"></asp:Label>
                                                </td>
                                                <td class="style4" style="width: 100px">
                                                     <asp:CheckBox ID="chkbxB2BApproval" runat="server" />
                                                </td>
                                            </tr> 
                                                    </table>
                                                </td>
                                            </tr>                                                        
                                        </table>
                                        </ContentTemplate>
                                       </asp:UpdatePanel>
                                    </td>
                                    <td class="datab" width="30%">
                                    <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                                             <ContentTemplate> 
                                        <table id="tblJobsmodule">
                                            <tr>
                                                <td class="datab" style="width: 97px">
                                                    Jobs Module
                                                </td>
                                                <td class="style4" style="width: 100px">
                                                    <asp:RadioButton ID="rbJobsYes" runat="server" GroupName="gJobs" Text="Yes" AutoPostBack="True" />
                                                    <asp:RadioButton ID="rbJobsNo" runat="server" GroupName="gJobs" Text="No" AutoPostBack="True" />
                                                </td>
                                            </tr>
                                            <tr id="trIJobsModule" runat="server">
                                                <td colspan="2">
                                                    <table width="100%">
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
                                                    <asp:CheckBox ID="chkbxJobsPost" runat="server" />
                                                </td>
                                            </tr>
                                                         <tr id="trJobsEdit" runat="server">
                                                <td class="datap5">
                                                    <asp:Label ID="lblJobsEdit" runat="server" Text="Edit"></asp:Label>
                                                </td>
                                                <td class="style4" style="width: 100px">
                                                    <asp:CheckBox ID="chkbxJobsEdit" runat="server" />
                                                </td>
                                            </tr>
                                                         <tr id="trJobsDel" runat="server">
                                                <td class="datap5">
                                                    <asp:Label ID="lblJobsDel" runat="server" Text="Delete"></asp:Label>
                                                </td>
                                                <td class="style4" style="width: 100px">
                                                    <asp:CheckBox ID="chkbxJobsDel" runat="server" />
                                                </td>
                                            </tr>
                                                         <tr id="trJobsPreview" runat="server">
                                                <td class="datap5">
                                                    <asp:Label ID="lblJobsview" runat="server" Text="Preview"></asp:Label>
                                                </td>
                                                <td class="style4" style="width: 100px">
                                                    <asp:CheckBox ID="chkbxJobsview" runat="server" />
                                                </td>
                                            </tr>
                                                         <tr id="trJobsApproval" runat="server">
                                                <td class="datap5">
                                                    <asp:Label ID="lblJobsApproval" runat="server" Text="Approval"></asp:Label>
                                                </td>
                                                <td class="style4" style="width: 100px">
                                                     <asp:CheckBox ID="chkbxJobsApproval" runat="server" />
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
                            <table width="90%" border="0">
                                <tr>
                                    <td class="datab" width="30%">
                                        <asp:UpdatePanel ID="UpdatePanel14" runat="server">
                                         <ContentTemplate> 
                                            <table id="tblEveModule">
                            <tr>
                                <td class="datab" style="width: 97px">Events Module</td>
                                <td class="style4" style="width: 100px">
                                    <asp:RadioButton ID="rbEveYes" runat="server" GroupName="gEve" Text="Yes" AutoPostBack="True"/>
                                    <asp:RadioButton ID="rbEveNo" runat="server" GroupName="gEve" Text="No" AutoPostBack="True" />
                                </td>
                            </tr>
                            <tr id="trIEveModule" runat="server">
                                <td colspan="2">
                                    <table width="100%">
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
                                   <asp:CheckBox ID="chkbxEvePost" runat="server" />
                                </td>
                            </tr>
                                         <tr id="trEveEdit" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lblEveEdit" runat="server" Text="Edit"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:CheckBox ID="chkbxEveEdit" runat="server" />
                                </td>
                            </tr>
                                         <tr id="trEveDel" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lblEveDel" runat="server" Text="Delete"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:CheckBox ID="chkbxEveDel" runat="server" />
                                </td>
                            </tr>
                                         <tr id="trEvePreview" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lblEveview" runat="server" Text="Preview"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                     <asp:CheckBox ID="chkbxEveview" runat="server" />
                                </td>
                            </tr> 
                                         <tr id="trEveApproval" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lblEveApproval" runat="server" Text="Approval"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                     <asp:CheckBox ID="chkbxEveApproval" runat="server" />
                                </td>
                            </tr>  
                                    </table>
                                </td>
                            </tr>                                                 
                        </table>
                                         </ContentTemplate>
                                     </asp:UpdatePanel>
                                     </td>
                                    <td class="datab" width="30%">
                                        <asp:UpdatePanel ID="UpdatePanel4" runat="server">
                             <ContentTemplate> 
                                <table width="100%" border="0">
                <tr>
                    <td class="datab" >
                        <table id="tblDismodule">
                            <tr>
                                <td class="datab" style="width: 97px">
                                    Discounts Module
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:RadioButton ID="rbDisYes" runat="server" GroupName="gDis" Text="Yes" AutoPostBack="True" />
                                    <asp:RadioButton ID="rbDisNo" runat="server" GroupName="gDis" Text="No" AutoPostBack="True" />
                                </td>
                            </tr>
                            <tr id="trIDisModule" runat="server">
                                <td colspan="2">
                                    <table width="100%">
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
                                    <asp:CheckBox ID="chkbxDisPost" runat="server" />
                                </td>
                            </tr>
                                         <tr id="trDisEdit" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lblDisEdit" runat="server" Text="Edit"></asp:Label>
                                </td>
                                <td style="height: 20px; width: 100px;">
                                    <asp:CheckBox ID="chkbxDisEdit" runat="server" />
                                </td>
                            </tr>
                                         <tr id="trDisDel" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lblDisDel" runat="server" Text="Delete"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:CheckBox ID="chkbxDisDel" runat="server" />
                                </td>
                            </tr>
                                         <tr id="trDisPreview" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lblDisview" runat="server" Text="Preview"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:CheckBox ID="chkbxDisview" runat="server" />
                                </td>
                            </tr> 
                                         <tr id="trDisApproval" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lblDisApproval" runat="server" Text="Approval"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                     <asp:CheckBox ID="chkbxDisApproval" runat="server" />
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
                                    <td class="datab" width="30%">
                                        <asp:UpdatePanel ID="UpdatePanel15" runat="server">
                             <ContentTemplate> 
                                <table width="100%" border="0">
                <tr>
                    <td class="datab" >
                        <table id="tblLSmodule">
                            <tr>
                                <td class="datab" style="width: 97px">
                                    LifeStyle Module
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:RadioButton ID="rbLSYes" runat="server" GroupName="gLS" Text="Yes" AutoPostBack="True" />
                                    <asp:RadioButton ID="rbLSNo" runat="server" GroupName="gLS" Text="No" AutoPostBack="True" />
                                </td>
                            </tr>
                            <tr id="trILSModule" runat="server">
                                <td colspan="2">
                                    <table width="100%">
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
                                    <asp:CheckBox ID="chkbxLSPost" runat="server" />
                                </td>
                            </tr>
                                        <tr id="trLSEdit" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lblLSEdit" runat="server" Text="Edit"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:CheckBox ID="chkbxLSEdit" runat="server" />
                                </td>
                            </tr>
                                        <tr id="trLSDel" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lblLSDel" runat="server" Text="Delete"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:CheckBox ID="chkbxLSDel" runat="server" />
                                </td>
                            </tr>
                                        <tr id="trLSPreview" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lblLSview" runat="server" Text="Preview"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:CheckBox ID="chkbxLSview" runat="server" />
                                </td>
                            </tr> 
                                        <tr id="trLSApproval" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lblLSApproval" runat="server" Text="Approval"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                     <asp:CheckBox ID="chkbxLSApproval" runat="server" />
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
                                </table>
                                </td>
                                </tr>
                         <tr>
                            <td colspan="6">
                                <table width="90%" border="0">
                <tr>
                    <td class="datab" width="30%">
                    <asp:UpdatePanel ID="UpdatePanel5" runat="server">
                             <ContentTemplate> 
                        <table id="tblCareers">
                            <tr>
                                <td class="datab" style="width: 97px">Careers</td>
                                <td class="style4" style="width: 100px">
                                    <asp:RadioButton ID="rbCareersYes" runat="server" GroupName="gCareers" Text="Yes" AutoPostBack="True"/>
                                    <asp:RadioButton ID="rbCareersNo" runat="server" GroupName="gCareers" Text="No" AutoPostBack="True" />
                                </td>
                            </tr>
                            <tr id="trICareers" runat="server">
                                <td colspan="2">
                                    <table width="100%">
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
                                   <asp:CheckBox ID="chkbxCareersPost" runat="server" />
                                </td>
                            </tr>
                                         <tr id="trCareersEdit" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lblCareersEdit" runat="server" Text="Edit"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:CheckBox ID="chkbxCareersEdit" runat="server" />
                                </td>
                            </tr>
                                         <tr id="trCareersDel" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lblCareersDel" runat="server" Text="Delete"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:CheckBox ID="chkbxCareersDel" runat="server" />
                                </td>
                            </tr>
                                         <tr id="trCareersPreview" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="lblCareersview" runat="server" Text="Preview"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                     <asp:CheckBox ID="chkbxCareersview" runat="server" />
                                </td>
                            </tr>                                                   
                                    </table>
                                </td>
                            </tr>
                                           
                        </table>
                        </ContentTemplate>
                       </asp:UpdatePanel>
                    </td>
                    
                    <td class="datab" width="30%">
                        <asp:UpdatePanel ID="UpdatePanel7" runat="server">
                             <ContentTemplate> 
                        <table id="tblUserInfomodule">
                            <tr>
                                <td class="datab" style="width: 97px">
                                    Users Info
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:RadioButton ID="rbUInfoYes" runat="server" GroupName="gUInfo" Text="Yes" AutoPostBack="True" />
                                    <asp:RadioButton ID="rbUInfoNo" runat="server" GroupName="gUInfo" Text="No" AutoPostBack="True" />
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
                                <table width="90%" border="0">
                            <tr>
                                <td class="datab" width="30%">
                                    <asp:UpdatePanel ID="UpdatePanel8" runat="server">
                             <ContentTemplate> 
                                <table id="tblMovies">
                            <tr>
                                <td class="datab" style="width: 97px">Movies</td>
                                <td class="style4" style="width: 100px">
                                    <asp:RadioButton ID="rbMYes" runat="server" GroupName="gMovie" Text="Yes" AutoPostBack="True"/>
                                    <asp:RadioButton ID="rbMNo" runat="server" GroupName="gMovie" Text="No" AutoPostBack="True" />
                                </td>
                            </tr>
                            <tr id="trMovies" runat="server">
                                <td colspan="2">
                                    <table width="100%">
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
                                   <asp:CheckBox ID="chkMoviesPost" runat="server" />
                                </td>
                            </tr>
                                         <tr id="trMoviesEdit" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="Label5" runat="server" Text="Edit"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:CheckBox ID="chkMoviesEdit" runat="server" />
                                </td>
                            </tr>
                                         <tr id="trMoviesDelete" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="Label6" runat="server" Text="Delete"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:CheckBox ID="chkMoviesDelete" runat="server" />
                                </td>
                            </tr>
                                         <tr id="trMoviesView" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="Label7" runat="server" Text="Preview"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                     <asp:CheckBox ID="ChkMoviesView" runat="server" />
                                </td>
                            </tr>                                          
                                    </table>
                                </td>
                            </tr>                                                 
                        </table>
                             </ContentTemplate>
                             </asp:UpdatePanel>
                                </td>
                                <td class="datab" width="30%">
                                    <asp:UpdatePanel ID="UpdatePanel9" runat="server">
                             <ContentTemplate> 
                                <table id="tblCT">
                            <tr>
                                <td class="datab" style="width: 97px">
                                    City Trends
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:RadioButton ID="rbCTYes" runat="server" GroupName="gCT" Text="Yes" AutoPostBack="True" />
                                    <asp:RadioButton ID="rbCTNo" runat="server" GroupName="gCT" Text="No" AutoPostBack="True" />
                                </td>
                            </tr>
                            <tr id="trCT" runat="server">
                                <td colspan="2">
                                    <table width="100%">
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
                                    <asp:CheckBox ID="chkCTPost" runat="server" />
                                </td>
                            </tr>
                                         <tr id="trCTEdit" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="Label11" runat="server" Text="Edit"></asp:Label>
                                </td>
                                <td style="height: 20px; width: 100px;">
                                    <asp:CheckBox ID="chkCTEdit" runat="server" />
                                </td>
                            </tr>
                                         <tr id="trCTDelete" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="Label12" runat="server" Text="Delete"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:CheckBox ID="chkCTDelete" runat="server" />
                                </td>
                            </tr>
                                         <tr id="trCTView" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="Label13" runat="server" Text="Preview"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:CheckBox ID="chkCTView" runat="server" />
                                </td>
                            </tr>                                          
                                    </table>
                                </td>
                            </tr>
                                                    
                        </table>
                             </ContentTemplate>
                             </asp:UpdatePanel>
                                </td>
                                <td class="datab" width="30%">
                                    <asp:UpdatePanel ID="UpdatePanel10" runat="server">
                             <ContentTemplate> 
                                <table id="tblMS">
                            <tr>
                                <td class="datab" style="width: 97px">
                                    Media Speak
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:RadioButton ID="rbMSYes" runat="server" GroupName="gMS" Text="Yes" AutoPostBack="True" />
                                    <asp:RadioButton ID="rbMSNo" runat="server" GroupName="gMS" Text="No" AutoPostBack="True" />
                                </td>
                            </tr>
                            <tr id="trMS" runat="server">
                                <td colspan="2">
                                    <table width="100%">
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
                                    <asp:CheckBox ID="chkMSPost" runat="server" />
                                </td>
                            </tr>
                                         <tr id="trMSEdit" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="Label17" runat="server" Text="Edit"></asp:Label>
                                </td>
                                <td style="height: 20px; width: 100px;">
                                    <asp:CheckBox ID="chkMSEdit" runat="server" />
                                </td>
                            </tr>
                                         <tr id="trMSDelete" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="Label18" runat="server" Text="Delete"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:CheckBox ID="chkMSDelete" runat="server" />
                                </td>
                            </tr>
                                         <tr id="trMSView" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="Label19" runat="server" Text="Preview"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:CheckBox ID="chkMSView" runat="server" />
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
                                <table width="90%" border="0">
                            <tr>
                                <td class="datab" width="30%">
                                    <asp:UpdatePanel ID="UpdatePanel11" runat="server">
                             <ContentTemplate> 
                                <table id="tblAds">
                            <tr>
                                <td class="datab" style="width: 97px">Ads</td>
                                <td class="style4" style="width: 100px">
                                    <asp:RadioButton ID="rbAdsYes" runat="server" GroupName="gAds" Text="Yes" AutoPostBack="True"/>
                                    <asp:RadioButton ID="rbAdsNo" runat="server" GroupName="gAds" Text="No" AutoPostBack="True" />
                                </td>
                            </tr>
                            <tr id="trAds" runat="server">
                                <td colspan="2">
                                    <table width="100%">
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
                                   <asp:CheckBox ID="chkAdsPost" runat="server" />
                                </td>
                            </tr>
                                         <tr id="trAdsEdit" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="Label23" runat="server" Text="Edit"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:CheckBox ID="chkAdsEdit" runat="server" />
                                </td>
                            </tr>
                                         <tr id="trAdsDelete" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="Label24" runat="server" Text="Delete"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:CheckBox ID="chkAdsDelete" runat="server" />
                                </td>
                            </tr>
                                         <tr id="trAdsView" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="Label25" runat="server" Text="Preview"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                     <asp:CheckBox ID="chkAdsView" runat="server" />
                                </td>
                            </tr>                                          
                                    </table>
                                </td>
                            </tr>                                                 
                        </table>
                             </ContentTemplate>
                             </asp:UpdatePanel>
                                </td>
                                <td class="datab" width="30%">
                                    <asp:UpdatePanel ID="UpdatePanel12" runat="server">
                             <ContentTemplate> 
                                <table id="tblFL">
                            <tr>
                                <td class="datab" style="width: 97px">
                                    Free Listing
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:RadioButton ID="rbFLYes" runat="server" GroupName="gFL" Text="Yes" AutoPostBack="True" />
                                    <asp:RadioButton ID="rbFLNo" runat="server" GroupName="gFL" Text="No" AutoPostBack="True" />
                                </td>
                            </tr>
                            <tr id="trFL" runat="server">
                                <td colspan="2">
                                    <table width="100%">
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
                                    <asp:CheckBox ID="chkFreelistPost" runat="server" />
                                </td>
                            </tr>
                                         <tr id="trFLEdit" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="Label29" runat="server" Text="Edit"></asp:Label>
                                </td>
                                <td style="height: 20px; width: 100px;">
                                    <asp:CheckBox ID="chkFreelistEdit" runat="server" />
                                </td>
                            </tr>
                                         <tr id="trFLDelete" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="Label30" runat="server" Text="Delete"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:CheckBox ID="chkFreelistDelete" runat="server" />
                                </td>
                            </tr>
                                         <tr id="trFLView" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="Label31" runat="server" Text="Preview"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:CheckBox ID="chkFreelistView" runat="server" />
                                </td>
                            </tr> 
                                         <tr id="trFLApprove" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="Label32" runat="server" Text="Approval"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                     <asp:CheckBox ID="chkFLApprove" runat="server" />
                                </td>
                            </tr>  
                                    </table>
                                </td>
                            </tr>
                                                    
                        </table>
                             </ContentTemplate>
                             </asp:UpdatePanel>
                                </td>
                                <td class="datab" width="30%">
                                    <asp:UpdatePanel ID="UpdatePanel13" runat="server">
                             <ContentTemplate> 
                                <table id="tblwp">
                            <tr>
                                <td class="datab" style="width: 97px">
                                    White Pages
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:RadioButton ID="rbwpyes" runat="server" GroupName="gwp" Text="Yes" AutoPostBack="True" />
                                    <asp:RadioButton ID="rbwpno" runat="server" GroupName="gwp" Text="No" AutoPostBack="True" />
                                </td>
                            </tr>
                            <tr id="trwp" runat="server">
                                <td colspan="2">
                                    <table width="100%">
                                    <tr id="trwpall" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="Label1" runat="server" Text="Select All"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                   <asp:CheckBox ID="chkwhiteall" runat="server" 
                                        AutoPostBack="true" oncheckedchanged="chkwhiteall_CheckedChanged" />
                                </td>
                            </tr>
                                         <tr id="trwhitepost" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="Label8" runat="server" Text="Post"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:CheckBox ID="chkwhitepost" runat="server" />
                                </td>
                            </tr>
                                         <tr id="trwhiteedit" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="Label14" runat="server" Text="Edit"></asp:Label>
                                </td>
                                <td style="height: 20px; width: 100px;">
                                    <asp:CheckBox ID="chkwhiteedit" runat="server" />
                                </td>
                            </tr>
                                         <tr id="trwhitedelete" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="Label20" runat="server" Text="Delete"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:CheckBox ID="chkwhitedelete" runat="server" />
                                </td>
                            </tr>
                                         <tr id="trwhitepreview" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="Label26" runat="server" Text="Preview"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:CheckBox ID="chkwhitepreview" runat="server" />
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
                                <td class="datab" width="30%">
                                    <asp:UpdatePanel ID="UpdatePanel16" runat="server">
                             <ContentTemplate> 
                                <table id="Table2">
                            <tr>
                                <td class="tblsuccess" style="width: 97px">
                                    Success Stories
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:RadioButton ID="rbssyes" runat="server" GroupName="gss" Text="Yes" AutoPostBack="True" />
                                    <asp:RadioButton ID="rbssno" runat="server" GroupName="gss" Text="No" AutoPostBack="True" />
                                </td>
                            </tr>
                            <tr id="trsuccess" runat="server">
                                <td colspan="2">
                                    <table width="100%">
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
                                    <asp:CheckBox ID="chksuccesspost" runat="server" />
                                </td>
                            </tr>
                                         <tr id="trsuccessedit" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="Label36" runat="server" Text="Edit"></asp:Label>
                                </td>
                                <td style="height: 20px; width: 100px;">
                                    <asp:CheckBox ID="chksuccessedit" runat="server" />
                                </td>
                            </tr>
                                         <tr id="trsuccessdelete" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="Label37" runat="server" Text="Delete"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:CheckBox ID="chksuccessdelete" runat="server" />
                                </td>
                            </tr>
                                         <tr id="trsuccesspreview" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="Label38" runat="server" Text="Preview"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:CheckBox ID="chksuccesspreview" runat="server" />
                                </td>
                            </tr> 
                                         
                                    </table>
                                </td>
                            </tr>
                                                    
                        </table>
                             </ContentTemplate>
                             </asp:UpdatePanel>
                                </td>
                                <td class="datab" width="30%">
                                    <asp:UpdatePanel ID="UpdatePanel17" runat="server">
                             <ContentTemplate> 
                                <table id="tblcsr">
                            <tr>
                                <td class="datab" style="width: 97px">
                                    Corporate & Social Responsibility
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:RadioButton ID="rbcsryes" runat="server" GroupName="gcsr" Text="Yes" AutoPostBack="True" />
                                    <asp:RadioButton ID="rbcsrno" runat="server" GroupName="gcsr" Text="No" AutoPostBack="True"  />
                                </td>
                            </tr>
                            <tr id="trscr" runat="server">
                                <td colspan="2">
                                    <table width="100%">
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
                                    <asp:CheckBox ID="chkcsrpost" runat="server" />
                                </td>
                            </tr>
                                         <tr id="trscredit" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="Label42" runat="server" Text="Edit"></asp:Label>
                                </td>
                                <td style="height: 20px; width: 100px;">
                                    <asp:CheckBox ID="chkcsredit" runat="server" />
                                </td>
                            </tr>
                                         <tr id="trscrdelete" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="Label43" runat="server" Text="Delete"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:CheckBox ID="chkcsrdelete" runat="server" />
                                </td>
                            </tr>
                                         <tr id="trscrpreview" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="Label44" runat="server" Text="Preview"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:CheckBox ID="chkcsrpreview" runat="server" />
                                </td>
                            </tr> 
                                        
                                    </table>
                                </td>
                            </tr>
                                                    
                        </table>
                             </ContentTemplate>
                             </asp:UpdatePanel>
                                </td>
                                <td class="datab" width="30%">
                                    <asp:UpdatePanel ID="UpdatePanel18" runat="server">
                             <ContentTemplate> 
                                <table id="tblsnf">
                            <tr>
                                <td class="datab" style="width: 97px">
                                    Search not found
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:RadioButton ID="rbsnfyes" runat="server" GroupName="gsnf" Text="Yes" AutoPostBack="True" />
                                    <asp:RadioButton ID="rbsnfno" runat="server" GroupName="gsnf" Text="No" AutoPostBack="True" />
                                </td>
                            </tr>
                            <tr id="trsnf" runat="server">
                                <td colspan="2">
                                    <table width="100%">
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
                                    <asp:CheckBox ID="chksnpost" runat="server" />
                                </td>
                            </tr>
                                <tr id="trsnfdelete" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="Label49" runat="server" Text="Delete"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:CheckBox ID="chksnfdelete" runat="server" />
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
                <td class="datab" width="30%">
                                    <asp:UpdatePanel ID="UpdatePanel19" runat="server">
                             <ContentTemplate> 
                                <table id="tblslinks">
                            <tr>
                                <td class="datab" style="width: 97px">
                                    Sponsered Links
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:RadioButton ID="rbslyes" runat="server" GroupName="gsl" Text="Yes" AutoPostBack="True" />
                                    <asp:RadioButton ID="rbslno" runat="server" GroupName="gsl" Text="No" AutoPostBack="True" />
                                </td>
                            </tr>
                            <tr id="trslink" runat="server">
                                <td colspan="2">
                                    <table width="100%">
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
                                    <asp:CheckBox ID="chkslpost" runat="server" />
                                </td>
                            </tr>
                                         <tr id="trsledit" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="Label48" runat="server" Text="Edit"></asp:Label>
                                </td>
                                <td style="height: 20px; width: 100px;">
                                    <asp:CheckBox ID="chksledit" runat="server" />
                                </td>
                            </tr>
                                         <tr id="trsldel" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="Label50" runat="server" Text="Delete"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:CheckBox ID="chksldel" runat="server" />
                                </td>
                            </tr>
                                         <tr id="trslview" runat="server">
                                <td class="datap5">
                                    <asp:Label ID="Label51" runat="server" Text="Preview"></asp:Label>
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:CheckBox ID="chkslview" runat="server" />
                                </td>
                            </tr> 
                                        
                                    </table>
                                </td>
                            </tr>
                                                    
                        </table>
                             </ContentTemplate>
                             </asp:UpdatePanel>
                                </td>
                                <td class="datab" width="30%">
                                    <asp:UpdatePanel ID="UpdatePanel20" runat="server">
                             <ContentTemplate> 
                                <table id="tbltest">
                            <tr>
                                <td class="datab" style="width: 97px">
                                    Testimonials
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:RadioButton ID="rbtestyes" runat="server" GroupName="gtest" Text="Yes" 
                                          AutoPostBack="true"/>
                                    <asp:RadioButton ID="rbtestno" runat="server" GroupName="gtest" Text="No" AutoPostBack="true" 
                                       />
                                </td>
                            </tr>
                            <tr id="trtest" runat="server">
                                <td colspan="2">
                                   
                                </td>
                            </tr>
                                                    
                        </table>
                             </ContentTemplate>
                             </asp:UpdatePanel>
                                </td>
                                <td class="datab" width="30%">
                                    <asp:UpdatePanel ID="UpdatePanel21" runat="server">
                             <ContentTemplate> 
                                <table id="Table3">
                            <tr>
                                <td class="datab" style="width: 97px">
                                    Customer Care
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:RadioButton ID="rbccareyes" runat="server" GroupName="gcc" Text="Yes" 
                                        AutoPostBack="True"  />
                                    <asp:RadioButton ID="rbccareno" runat="server" GroupName="gcc" Text="No" 
                                        AutoPostBack="True"  
                                        />
                                </td>
                            </tr>
                            <tr id="tr7" runat="server">
                                <td colspan="2">
                                    
                                </td>
                            </tr>
                                                    
                        </table>
                             </ContentTemplate>
                             </asp:UpdatePanel>
                                </td>
                </tr>
            <tr>
                        <td class="datab" width="30%">
                                    <asp:UpdatePanel ID="UpdatePanel22" runat="server">
                             <ContentTemplate> 
                                <table id="Table4">
                            <tr>
                          
                                <td class="datab" style="width: 97px">
                                    Exceptions
                                </td>
                                <td class="style4" style="width: 100px">
                                    <asp:RadioButton ID="rbexyes" runat="server" GroupName="gex" Text="Yes" 
                                        AutoPostBack="True" />
                                    <asp:RadioButton ID="rbexno" runat="server" GroupName="gex" Text="No" 
                                        AutoPostBack="True"/>
                                </td>
                            </tr>
                            <tr id="tr13" runat="server">
                                <td colspan="2">
                                   
                                </td>
                            </tr>
                                                    
                        </table>
                             </ContentTemplate>
                             </asp:UpdatePanel>
                                </td>
                        </tr>
                        </table>
          <%-- </ContentTemplate>
                           </asp:UpdatePanel>--%>
                            </td>
                        </tr>
                        <tr>
                        <td colspan="3" style="height:50px">
                            <asp:Button ID="btnEdit" runat="server" Text="Update Web Admin Permissions" onclick="btnEdit_Click"/>
                       </td>
                       <td colspan="3" style="height:50px">
                           <asp:Button ID="CancelUpdate" runat="server" Text="Cancel Update" 
                               onclick="CancelUpdate_Click" />
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
