<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Admin_CareersAplications.aspx.cs" Inherits="admin_Admin_CareersAplications" %>
<%@ Register Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" TagPrefix="cc3"  %>
<%@ Register Src="~/admin/user_control/Admin_Headermenu.ascx" TagName="Headermenu" TagPrefix="cc1" %>
<%@ Register Src="~/admin/user_control/Admin_LeftMenu.ascx" TagName="LeftMenu" TagPrefix="cc4" %>
<%@ Register Src="~/admin/user_control/Admin_CareersHeader.ascx" TagName="CareersHeader" TagPrefix="Careers" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="AjaxToolkit" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title>Justcalluz - Admin Control Panel - Careers_Applications</title>
    <link href="includes/style.css" rel="Stylesheet" type="text/css" />
    <script type="text/javasrcipt" src="http://ajax.googleapis.com/ajax/libs/jquery/1.6.2/jquery.min.js"></script>
    <script src="js/statesopt.js"></script>
    
    <style type="text/css">
        .style37
        {
            width: 900px;
        }
        .style39
        {
            width: 100px;
        }        
        .style40
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
        <script type="text/javascript" src="js/tab.js"></script>
        <script type="text/javascript">
function poponload()
{
    testwindow = window.open("http://www.justcalluz.com/Careers_Location.aspx", "mywindow", "location=1,status=1,scrollbars=1,width=500,height=500");
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
            <table cellpadding="0" cellspacing="0">
              <tr>
                <td class="style39" valign="top" style="padding-top:10px">                        
                 <cc4:LeftMenu ID="LeftMenu1" runat="server" />
                </td>
                <td valign="top">&nbsp;</td>
                <td valign="top" style="padding-left:10px; background-color:#F2FAFC">  
                    <table width="750px">
                    <tr>
                    <td>                      
                       <Careers:CareersHeader ID="Careers" runat="server" />
                    </td>
                    </tr>
                         <tr><td height="5px"></td></tr>  
                    <tr>
                        <td align="center" colspan="3">
                          <span style="font-size:21px; font-weight:bold; color:DarkBlue"> Careers Home - Job Applications</span> 
                        </td>
                      </tr> 
                        <tr>
                            <td colspan="2" align="right">
                                <asp:ScriptManager ID="ScriptManager1" runat="server">
                                </asp:ScriptManager><asp:ImageButton ID="imgsite" runat="server" OnClientClick="justcalluz:poponload();" ImageUrl="images/Click Here For SiteView.png"/>
                            </td>
                        </tr>                                              
                        <tr>
                            <td colspan="2">
                                <asp:Label ID="lblMessage" runat="server" ForeColor="OrangeRed" Font-Bold="true" Font-Size="Medium"></asp:Label>
                            </td>
                        </tr>  
                        <tr>
                            <td>
                                <asp:Label ID="lblrecords" runat="server" ForeColor="OrangeRed" Font-Bold="true" Font-Size="Medium"></asp:Label>                                
                            </td>
                        </tr>    
                        <tr>
                            <td align="center" colspan="2">
                                <br />
                                <br />
                                <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                        <ContentTemplate>
                            <asp:DataList ID="dlCareersdata" runat="server" Width="100%">
                                <ItemTemplate>
                                <table width="100%">                                                                        
                                    <tr>
                                        <td align="center">
                                            <asp:Label ID="Label15" runat="server" Text="Job Specifications for the post" Font-Size="Large" ForeColor="#5858FA"></asp:Label>
                                            <asp:Label ID="Label23" runat="server" Font-Bold="true" Text='<%#Eval("title")%>' ForeColor="Maroon"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr><td height="10px"></td></tr>
                                    <tr>
                                        <td align="left">
                                           <table width="100%"  style="background-color:#EFFBFB">
                                            <tr>                                               
                                                <td colspan="2">
                                                    Specialization :&nbsp;<asp:Label ID="Label16" runat="server" Text='<%#Eval("category") %>'></asp:Label>,
                                                    <asp:Label ID="Label17" runat="server" Text='<%#Eval("specialization") %>'></asp:Label> 
                                                </td>
                                            </tr>                                            
                                            <tr>
                                                <td>
                                                    Work Experience :&nbsp;<asp:Label ID="Label18" runat="server" Text='<%#Eval("workExp") %>'></asp:Label>                                                   
                                                </td>
                                                 <td>
                                                    Job Type :&nbsp;<asp:Label ID="Label19" runat="server" Text='<%#Eval("jobType") %>'></asp:Label>                                                    
                                                </td>
                                            </tr>
                                            <tr>
                                                <td colspan="2">
                                                    Computer Skills :&nbsp;<asp:Label ID="Label22" runat="server" Text='<%#Eval("computerknowledge") %>'></asp:Label>                                                    
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    Qualification:&nbsp;<asp:Label ID="Label20" runat="server" Text='<%#Eval("workExp") %>'></asp:Label>                                                   
                                                </td>
                                                 <td>
                                                    Job Expired on :&nbsp;<asp:Label ID="Label21" runat="server" Text='<%#Eval("expire_date") %>'></asp:Label>                                                   
                                                </td>
                                            </tr>
                                           </table>
                                        </td>
                                    </tr>
                                    <tr><td height="30px"></td></tr>
                                    <tr>
                                      <td align="center">
                                       <span style="color:#0A98F7; font-size:larger; font-weight:bold">Applications for the post of &nbsp;</span><asp:Label ID="lblTitle" runat="server" Font-Bold="true" Text='<%#Eval("title")%>' ForeColor="#D39D13" Font-Size="Large"></asp:Label> ( <asp:Label ID="Label14" runat="server" Text='<%#Eval("applications")%>' ForeColor="#D39D13" Font-Bold="true"></asp:Label> )
                                      </td>
                                    </tr>
                                </table>
                                </ItemTemplate>
                            </asp:DataList>
                            
                        </ContentTemplate>
                    </asp:UpdatePanel>
                    <br />                            
                            </td>
                        </tr>  
                        <tr>
                            <td>
                                <asp:Label ID="lblEmail" runat="server" Visible="false"></asp:Label>  
                                 <asp:Label ID="lblFName" runat="server" Visible="false"></asp:Label>
                                 <asp:Label ID="lblLName" runat="server" Visible="false"></asp:Label>  
                                 <asp:Label ID="lblJobId" runat="server" Visible="false"></asp:Label> 
                                 <asp:Label ID="lblJobDesc" runat="server" Visible="false"></asp:Label>  
                            </td>
                        </tr>
                        <tr>
                <td align="center" class="style40">
                     <asp:Label ID="lblMsg" runat="server" Font-Bold="true" ForeColor="#5858FA"></asp:Label>
                </td>
            </tr>                                    
            <tr>
                <td colspan="2"> 
                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                        <ContentTemplate>
                            <asp:DataList ID="dlViewApplicants" runat="server" Width="100%" 
                                 AlternatingItemStyle-BackColor="#FBEFF8" BackColor="#EFEFFB">
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
                                        <td>
                                           Name:<asp:Label ID="Label2" runat="server" Text='<%#Eval("firstname")%>'></asp:Label>&nbsp;
                                           <asp:Label ID="Label3" runat="server" Text='<%#Eval("lastname")%>'></asp:Label><br />
                                           Email: <asp:Label ID="Label4" runat="server" Text='<%#Eval("email")%>'></asp:Label><br />
                                           Mobile:<asp:Label ID="Label5" runat="server" Text='<%#Eval("Cell_num")%>'></asp:Label><br />
                                           Landline:<asp:Label ID="Label6" runat="server" Text='<%#Eval("landline_num")%>'></asp:Label><br />
                                           
                                        </td>
                                        <td style="border-right: 1px  dashed #666"></td>
                                        <td>
                                            Experience:<asp:Label ID="Label7" runat="server" Text='<%#Eval("exp_years")%>'></asp:Label>&nbsp;years&nbsp;
                                           <asp:Label ID="Label8" runat="server" Text='<%#Eval("exp_months")%>'></asp:Label>&nbsp;months<br />
                                           Current CTC: <asp:Label ID="Label9" runat="server" Text='<%#Eval("current_ctc")%>'></asp:Label><br />
                                           Expected CTC:<asp:Label ID="Label10" runat="server" Text='<%#Eval("expected_ctc")%>'></asp:Label><br />
                                           Education:<asp:Label ID="Label11" runat="server" Text='<%#Eval("BasicEducation")%>'></asp:Label><br />
                                           Job Type:<asp:Label ID="Label12" runat="server" Text='<%#Eval("jobtype")%>'></asp:Label><br />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="center" colspan="3">
                                            <asp:Label ID="lblFileName" runat="server" Text='<%#Eval("curriculam_vitaeName") %>' Visible="false"></asp:Label>
                                            <asp:Label ID="lblFilePath" runat="server" Text='<%#Eval("curriculam_vitaePath") %>' Visible="false"></asp:Label>                                            
                                            <asp:LinkButton ID="lnkBtnDownload" runat="server" CommandArgument='<%#Eval("Jobid") %>' OnCommand="lnkDownload" ForeColor="Red">Download Resume</asp:LinkButton>
                                         </td>
                                    </tr>
                                    <tr>
                                         <td colspan="3" align="center">  
                                            <asp:TextBox ID="txtresume" runat="server" TextMode="MultiLine" Height="250px" Width="90%" Visible="false"></asp:TextBox>                      
                                        </td>
                                    </tr>
                                    <tr><td height="5px"></td></tr>
                                    <tr>
                                         <td colspan="3" align="center">  
                                            <asp:LinkButton ID="lnkbtnsendmail" runat="server" CommandArgument='<%#Eval("Jobid") %>' OnCommand="lnkSendMail" ForeColor="Red">Further Communication through mail</asp:LinkButton>
                                        </td>
                                    </tr>
                                </table>
                                </ItemTemplate>
                            </asp:DataList>                            
                        </ContentTemplate>
                    </asp:UpdatePanel>               
                                                    
                </td>
            </tr> 
           <tr id="trnextpre" runat="server">
          <td align="center">
            <asp:Button ID="cmdPrev" runat="server" Text=" << " OnClick="cmdPrev_Click"></asp:Button>
              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="cmdNext" runat="server" Text=" >> " OnClick="cmdNext_Click"></asp:Button>                              
          </td>
        </tr> 
        <tr><td></td></tr>
        <tr id="trlblMessage" runat="server">
            <td align="right">
                <asp:Label ID="lblCurrentPage" runat="server"></asp:Label>
            </td>
        </tr>   
            <tr>
                <td height="20px">
                
                </td>
            </tr>        
             <tr><td colspan="2">
           <input id="btnDummy" runat="server" type="button" style="display: none;" />
           <asp:Label ID="lblApplicantId" runat="server" Visible="false"></asp:Label>
        </td></tr>
            <tr>            
            <td colspan="2">  
            <AjaxToolkit:ModalPopupExtender ID="ModalPopupExtender1" runat="server"  
         PopupControlID="modpopup1" BackgroundCssClass="modalBackground" TargetControlID="btnDummy"
        OkControlID="btnDummy" CancelControlID="btnDummy" BehaviorID="mpeBehavior"
        DropShadow="false" PopupDragHandleControlID="Panel4"></AjaxToolkit:ModalPopupExtender>    
            <asp:Panel ID="modpopup1" runat="server" Width="400px" Height="276px">
        <fieldset style="width: 400px">
            <asp:Panel ID="Panel4" runat="server">
            </asp:Panel>
             
                <table align="center" width="400px" height="30" style="background:green; border:width 1px color:white; font-size:13px;" >
                <tr style="background-color:Green;">
                    <td style="width:400px" align="center">
                       <span style="color:White">Sent mail for recruitment <br /> &nbsp;</span> 
                       <asp:Label ID="lblJobTitle" runat="server" Font-Size="Large" Visible="true" Font-Bold="true" ForeColor="White"></asp:Label>                       
                    </td>                           
                </tr>               
             </table>                
           
             <table align="center" width="100%" style="background:white; height: 184px;" >               
                <tr>
                    <td width="18%"> 
                    To                       
                    </td>
                    <td width="2%">
                    :
                    </td>
                    <td width="80%">
                        <asp:Label ID="lbltoMail" runat="server" ForeColor="Black"></asp:Label>                       
                    </td>
                </tr>
                 <tr>
                    <td width="18%"> 
                    Subject:                       
                    </td>
                    <td width="2%">
                    :
                    </td>
                    <td width="80%">
                        <asp:TextBox ID="txtSubject" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ErrorMessage="Please enter subject" ControlToValidate="txtSubject" 
                            ValidationGroup="modal"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                 <tr>
                    <td width="18%"> 
                    Message                       
                    </td>
                    <td width="2%">
                    :
                    </td>
                    <td width="80%">
                        <asp:TextBox ID="txtMsg" runat="server" TextMode="MultiLine"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvMsg" runat="server" 
                    ErrorMessage="Please enter message" ControlToValidate="txtMsg" 
                            ValidationGroup="modal"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr align="left" style="margin-left:5px">
                    <td align="center" colspan="3">
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
           </tr>   
            <tr>            
            <td>                                       
            </td>
            </tr> 
            <tr>
                <td align="center">
                    <asp:ImageButton ID="imgBtnBack" runat="server" 
                        ImageUrl="~/admin/images/back.png" onclick="imgBtnBack_Click"
                        />
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
