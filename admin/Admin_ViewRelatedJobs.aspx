<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Admin_ViewRelatedJobs.aspx.cs" Inherits="admin_Admin_ViewRelatedJobs" %>
<%@ Register Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" TagPrefix="cc3"  %>
<%@ Register Src="~/admin/user_control/Admin_Headermenu.ascx" TagName="Headermenu" TagPrefix="cc1" %>
<%@ Register Src="~/admin/user_control/Admin_LeftMenu.ascx" TagName="LeftMenu" TagPrefix="cc4" %>
<%@ Register Src="~/admin/user_control/Admin_CareersHeader.ascx" TagName="CareersHeader" TagPrefix="Careers" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="AjaxToolkit" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<title>Justcalluz - Admin Control Panel - View related jobs</title>
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
            width: 100px;
        }        
        .style40
        {
            height: 5px;
        }
        .style41
        {
            height: 23px;
        }
        </style>
              <script language="javascript" type="text/javascript">
  
  	function confirm_delete(uid)
{
  if (confirm("Are you sure you want to delete this Classified?")==true)
    document.location='Admin_DeleteData.aspx?cid=' +uid;
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
        <script type="text/javascript" src="js/tab.js"></script></head>
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
                <td class="style39" valign="top" style="padding-top:10px">                        
                 <cc4:LeftMenu ID="LeftMenu1" runat="server" />
                </td>
                <td valign="top">&nbsp;</td>
                <td valign="top" style="padding-left:10px; background-color:#F2FAFC">  
                    <table width="750px">
                    <tr>
                    <td colspan="2">                      
                       <Careers:CareersHeader ID="Careers" runat="server" />
                    </td>
                    </tr> 
                    <tr><td height="5px" colspan="2"></td></tr>  
                    <tr>
                        <td align="center" colspan="2">
                          <span style="font-size:21px; font-weight:bold; color:DarkBlue"> Careers Home</span> 
                        </td>
                      </tr>                     
                        <tr>
                            <td colspan="2">
                                <asp:ScriptManager ID="ScriptManager1" runat="server">
                                </asp:ScriptManager>
                            </td>
                        </tr>                                              
                        <tr>
                            <td colspan="2">
                                <asp:Label ID="lblMessage" runat="server" ForeColor="OrangeRed" Font-Bold="true" Font-Size="Medium"></asp:Label>
                            </td>
                        </tr>  
                        <tr>
                            <td colspan="2">
                                <asp:Label ID="lblrecords" runat="server" ForeColor="OrangeRed" Font-Bold="true" Font-Size="Medium"></asp:Label>                                
                            </td>
                        </tr>    
                        <tr>
                            <td align="center" colspan="2">
                                <br />                               
                            </td>                            
                        </tr> 
                        <tr>
                            <td align="center" colspan="2">
                               <asp:Label ID="Label24" runat="server" Text="Job Applicant Details" ForeColor="Red" Font-Size="Large"></asp:Label>                            
                            </td>                            
                        </tr> 
                         <tr>
                            <td align="left" colspan="2">
                                  <asp:DataList ID="dlViewApplicants" runat="server" Width="100%">
                                <ItemTemplate>
                                <table width="100%" border="0">
                                    <tr>
                                        <td colspan="2">
                                            <asp:Label ID="Label1" runat="server" Text='<%#Eval("Title")%>'></asp:Label>
                                        </td>
                                        <td align="right">
                                            Applied on:&nbsp;<asp:Label ID="Label13" runat="server" Text='<%#Eval("cPostDate")%>'></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                    <td width="45%">
                                           Category:<asp:Label ID="Label14" runat="server" Text='<%#Eval("Category")%>'></asp:Label>&nbsp;                                                                                      
                                        </td>
                                        <td style="border-right: 1px  dashed #666" width="2%"></td>
                                        <td width="53%" style="padding-left:10px">
                                           Specialization:<asp:Label ID="Label19" runat="server" Text='<%#Eval("Specialization")%>'></asp:Label>&nbsp;years&nbsp;                                           
                                        </td>
                                    </tr>
                                    <tr>
                                        <td width="45%">
                                           Name:<asp:Label ID="Label2" runat="server" Text='<%#Eval("firstname")%>'></asp:Label>&nbsp;
                                           <asp:Label ID="Label3" runat="server" Text='<%#Eval("lastname")%>'></asp:Label><br />
                                           Email: <asp:Label ID="Label4" runat="server" Text='<%#Eval("email")%>'></asp:Label><br />
                                           Mobile:<asp:Label ID="Label5" runat="server" Text='<%#Eval("Cell_num")%>'></asp:Label><br />
                                           Landline:<asp:Label ID="Label6" runat="server" Text='<%#Eval("landline_num")%>'></asp:Label><br />
                                           
                                        </td>
                                        <td style="border-right: 1px  dashed #666" width="2%"></td>
                                        <td width="53%" style="padding-left:10px">
                                            Experience:<asp:Label ID="Label7" runat="server" Text='<%#Eval("exp_toyears")%>'></asp:Label>&nbsp;years&nbsp;
                                           <asp:Label ID="Label8" runat="server" Text='<%#Eval("exp_fromyears")%>'></asp:Label>&nbsp;months<br />
                                           Current CTC: <asp:Label ID="Label9" runat="server" Text='<%#Eval("current_ctc")%>'></asp:Label><br />
                                           Expected CTC:<asp:Label ID="Label10" runat="server" Text='<%#Eval("expected_ctc")%>'></asp:Label><br />
                                           Education:<asp:Label ID="Label11" runat="server" Text='<%#Eval("BasicEducation")%>'></asp:Label><br />
                                           Job Type:<asp:Label ID="Label12" runat="server" Text='<%#Eval("jobtype")%>'></asp:Label><br />
                                        </td>
                                    </tr>
                                    <tr><td height="5px"></td></tr>                                    
                                    <tr>
                                         <td colspan="3" align="center">  
                                            <asp:TextBox ID="txtresume" runat="server" TextMode="MultiLine" Height="250px" Width="90%" Visible="false"></asp:TextBox>                      
                                        </td>
                                    </tr>
                                </table>
                                </ItemTemplate>
                            </asp:DataList>                        
                            </td>
                        </tr>  
                        <tr><td height="5px" colspan="2"></td></tr>   
                        <tr>
                            <td align="center" colspan="2" class="style41">
                                <asp:Label ID="lblCat" runat="server" Visible="false"></asp:Label> 
                                 <asp:Label ID="lblEmail" runat="server" Visible="false"></asp:Label>  
                                 <asp:Label ID="lblFName" runat="server" Visible="false"></asp:Label>
                                 <asp:Label ID="lblLName" runat="server" Visible="false"></asp:Label>                           
                            </td>
                        </tr>    
                         <tr>
                            <td align="center" colspan="2">
                                <asp:Label ID="Label23" runat="server" Text="Related Jobs avialable for this Applicant" ForeColor="CadetBlue" Font-Size="Large"></asp:Label>                           
                            </td>
                        </tr> 
                        <tr><td colspan="2" class="style40"></td></tr> 
                        <tr>
                        <td colspan="2">
                            <asp:LinkButton ID="lnkSendAllJobs" runat="server" 
                                onclick="lnkSendAllJobs_Click">Send all available jobs to the Applicant</asp:LinkButton>
                        </td>
                        </tr>   
                        <tr><td height="5px" colspan="2"></td></tr>                                   
            <tr>
                <td colspan="2"> 
                   <asp:DataList ID="dlViewRelatedJobs" runat="server" Width="100%" 
                                 AlternatingItemStyle-BackColor="#FBEFF8" BackColor="#EFEFFB" 
                        onitemdatabound="dlViewRelatedJobs_ItemDataBound">
                                <ItemTemplate>
                                <table width="100%" border="0">
                                    <tr>
                                        <td colspan="3" align="center">
                                            <asp:Label ID="Label1" runat="server" Text='<%#Eval("title")%>'></asp:Label>
                                            <asp:Label ID="expiredate" runat="server" Text='<%#Eval("expire_date")%>' Visible="false"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>                                        
                                        <td align="left">
                                            Posted on:&nbsp;<asp:Label ID="Label13" runat="server" Text='<%#Eval("postdate")%>'></asp:Label>
                                        </td>
                                        <td></td>
                                        <td align="right">
                                            Available till: <asp:Label ID="lbl123" runat="server" Text='<%#Eval("expiredate")%>'></asp:Label>
                                        </td>
                                    </tr>
                                    <tr><td colspan="3" height="5px"></td></tr>
                                    <tr>
                                    <td width="45%">
                                           Category:<asp:Label ID="Label14" runat="server" Text='<%#Eval("category")%>'></asp:Label>&nbsp;                                                                                      
                                        </td>
                                        <td style="border-right: 1px  dashed #666" width="2%"></td>
                                        <td width="53%" style="padding-left:10px">
                                           Specialization:<asp:Label ID="Label19" runat="server" Text='<%#Eval("specialization")%>'></asp:Label>&nbsp;years&nbsp;                                           
                                        </td>
                                    </tr>
                                    <tr>
                                        <td width="45%">
                                           Job Description:<asp:Label ID="Label16" runat="server" Text='<%#Eval("jobDesc")%>'></asp:Label><br />
                                           Work Experience <asp:Label ID="Label4" runat="server" Text='<%#Eval("workExp")%>'></asp:Label><br />
                                           Qualification:<asp:Label ID="Label17" runat="server" Text='<%#Eval("qualification")%>'></asp:Label><br />
                                           Technical Skills:<asp:Label ID="Label15" runat="server" Text='<%#Eval("computerknowledge")%>'></asp:Label><br />
                                           Salary Range:<asp:Label ID="Label5" runat="server" Text='<%#Eval("salRange")%>'></asp:Label><br />
                                           Job Type:<asp:Label ID="Label2" runat="server" Text='<%#Eval("jobType")%>'></asp:Label><br />
                                           Job Status:<asp:Label ID="Label3" runat="server" Text='<%#Eval("jobStatus")%>'></asp:Label><br />                                                                                      
                                           No. of Posts:<asp:Label ID="Label6" runat="server" Text='<%#Eval("noOfvacancies")%>'></asp:Label><br />                                                                                                                                                                          
                                        </td>
                                        <td style="border-right: 1px  dashed #666" width="2%"></td>
                                        <td width="53%" style="padding-left:10px">
                                           Contact Person:<asp:Label ID="Label7" runat="server" Text='<%#Eval("contpersonName")%>'></asp:Label><br />
                                           Address1:<asp:Label ID="Label8" runat="server" Text='<%#Eval("comp_address1")%>'></asp:Label><br />
                                           Address2: <asp:Label ID="Label9" runat="server" Text='<%#Eval("comp_address2")%>'></asp:Label><br />
                                           City:<asp:Label ID="Label10" runat="server" Text='<%#Eval("comp_city")%>'></asp:Label><br />
                                           State:<asp:Label ID="Label11" runat="server" Text='<%#Eval("comp_state")%>'></asp:Label><br />
                                           Pincode:<asp:Label ID="Label21" runat="server" Text='<%#Eval("comp_pincode")%>'></asp:Label><br />
                                           Email:<asp:Label ID="Label12" runat="server" Text='<%#Eval("cont_email")%>'></asp:Label><br />
                                           Phone:<asp:Label ID="Label18" runat="server" Text='<%#Eval("cont_phone")%>'></asp:Label>&nbsp;
                                           Extn - <asp:Label ID="Label20" runat="server" Text='<%#Eval("cont_ext")%>'></asp:Label><br />
                                        </td>
                                    </tr>
                                    <tr><td height="5px"></td></tr>                                   
                                    <tr>
                                        <td align="center" colspan="3">                                           
                                            <asp:LinkButton ID="lnkBtnSendMail" runat="server" CommandArgument='<%#Eval("jobid") %>' OnCommand="lnkSendMail" ForeColor="Red">Send this job to Applicant for recruitment </asp:LinkButton>
                                         </td>                                         
                                    </tr>  
                                    <tr><td height="10px"></td></tr>                                 
                                </table>
                                </ItemTemplate>
                            </asp:DataList>         
                                                    
                </td>
            </tr>  
            <tr>
                            <td width="10%" align="center">
                                <asp:LinkButton ID="lnkbtnPrevious" runat="server" OnClick="lnkbtnPrevious_Click1" 
                                    Font-Bold="True" Font-Size="Medium" Font-Underline="False" ForeColor="#FF6600" Visible="false">Previous</asp:LinkButton>
                            </td>
                            <td width="10%" align="center">
                                <asp:LinkButton ID="lnkbtnNext" runat="server" OnClick="lnkbtnNext_Click1" Font-Bold="True" Font-Size="Medium" Font-Underline="False" ForeColor="#FF6600" Visible="false">Next</asp:LinkButton>
                            </td>
                        </tr>
                        <tr id="trlblMessage" runat="server">
                            <td align="right" colspan="2">
                                <asp:Label ID="lblCurrentPage" runat="server" Visible="false"></asp:Label>
                            </td>
                        </tr>              
            <tr><td colspan="2">
           <input id="btnDummy" runat="server" type="button" style="display: none;" />
        </td></tr>
            <%--<tr>            
            <td colspan="2">  
            <AjaxToolkit:ModalPopupExtender ID="ModalPopupExtender1" runat="server"  
         PopupControlID="modpopup1" BackgroundCssClass="modalBackground" TargetControlID="btnDummy"
        OkControlID="btnDummy" CancelControlID="btnDummy" BehaviorID="mpeBehavior"
        DropShadow="false" PopupDragHandleControlID="Panel4"></AjaxToolkit:ModalPopupExtender>    
            <asp:Panel ID="modpopup1" runat="server" Width="430px" Height="276px">
        <fieldset style="width: 402px">
            <asp:Panel ID="Panel4" runat="server">
            </asp:Panel>
             
                <table align="center" width="400" height="30" style="background:green; border:width 1px color:white; font-size:13px;" >
                <tr style="background-color:Green;">
                    <td style="width:400px" align="center">
                       <span style="color:White">Sent Job tiltled as <br /> &nbsp;</span> 
                       <asp:Label ID="lblJobTitle" runat="server" Font-Size="Large" Font-Bold="true" ForeColor="White"></asp:Label>                       
                    </td>
                           
                </tr>               
             </table>                
           
             <table align="center" width="100%" style="background:white; height: 184px;" >               
                <tr>
                    <td width="49%"> 
                    To                       
                    </td>
                    <td width="2%">
                    :
                    </td>
                    <td width="49%">
                        <asp:TextBox ID="txtToEmail" runat="server"></asp:TextBox>
                    </td>
                </tr>
                 <tr>
                    <td width="49%"> 
                    Subject:                       
                    </td>
                    <td width="2%">
                    :
                    </td>
                    <td width="49%">
                        <asp:TextBox ID="txtSubject" runat="server"></asp:TextBox>
                    </td>
                </tr>
                 <tr>
                    <td width="49%"> 
                    Message                       
                    </td>
                    <td width="2%">
                    :
                    </td>
                    <td width="49%">
                        <asp:TextBox ID="txtMsg" runat="server" TextMode="MultiLine"></asp:TextBox>
                    </td>
                </tr>
                <tr align="left" style="margin-left:5px">
                    <td align="center" class="style4" colspan="3">
                        <asp:Button ID="submitbutton" runat="server" Text="Submit" 
                            ValidationGroup="modal" CausesValidation="true" Width="62px" 
                            onclick="submitbutton_Click"/>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="cancelbutton" runat="server" Text="Cancel" 
                            onclick="cancelbutton_Click" />
                    </td>
                </tr> 
                <tr>
                    <td colspan="3">
                     <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
                        ShowMessageBox="True" ShowSummary="False" ValidationGroup="modal" />
                    </td>
                </tr>               
            </table>
        </fieldset></asp:Panel>          
            </td>
           </tr>--%>                                                       
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
