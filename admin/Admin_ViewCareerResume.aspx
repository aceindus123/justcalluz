<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Admin_ViewCareerResume.aspx.cs" Inherits="admin_Admin_ViewCareerResume" %>
<%@ Register Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" TagPrefix="cc3"  %>
<%@ Register Src="~/admin/user_control/Admin_Headermenu.ascx" TagName="Headermenu" TagPrefix="cc1" %>
<%@ Register Src="~/admin/user_control/Admin_LeftMenu.ascx" TagName="LeftMenu" TagPrefix="cc4" %>
<%@ Register Src="~/admin/user_control/Admin_CareersHeader.ascx" TagName="CareersHeader" TagPrefix="Careers" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="AjaxToolkit" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<title>Justcalluz - Admin Control Panel - View Resumes</title>  
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
        .style1
        {
            width: 211px;
        }
     .style23
     {
         width: 103px;
         height: 83px;
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

        </head>
<body onload="new Accordian('basic-accordian',5,'header_highlight');">
    <form id="form1" runat="server">
      <center>
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
  
       <div>
        <table cellpadding="0" cellspacing="0" >
         <tr>
            <td width="100%">
             <cc1:headermenu ID="header" runat="server" />
            </td>
         </tr>
         <tr>
           <td width="100%">                  
            <table cellpadding="0" cellspacing="0">
              <tr>
                <td class="style39" valign="top" style="padding-top:4px">                        
                 <cc4:LeftMenu ID="LeftMenu1" runat="server" />
                </td>
                <td valign="top">&nbsp;</td>
                <td valign="top" style="padding-left:10px; background-color:#F2FAFC">  
                    <table width="750px">
                    <tr>
                    <td style="width:100%;" colspan="2">                      
                       <Careers:CareersHeader ID="Careers" runat="server" />
                    </td>
                    </tr> 
                     <tr>
                            <td colspan="2" align="right">
                               <a href="http://www.justcalluz.com/Careers_Location.aspx" target="_blank"><img src="images/Click Here For SiteView.png" alt="Siteview"/></a>
                            </td>
                        </tr>   
                    <tr>
                        <td align="center" colspan="3">
                          <span style="font-size:21px; font-weight:bold; color:DarkBlue"> Careers Home - View Resumes which are posted directly in careers</span> 
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
                             <td align="right" style="padding-right:10px;">
                             <asp:LinkButton ID="lnkBack" runat="server" Text="Back"  PostBackUrl="Admin_Careers.aspx"></asp:LinkButton> 
                        
                         </td>
                        </tr>                                                              
             <tr>
                <td colspan="2"> 
                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                        <ContentTemplate>
                            <asp:DataList ID="dlViewApplicants" runat="server" Width="98%" 
                                onitemdatabound="dlViewApplicants_ItemDataBound" 
                                onitemcommand="dlViewApplicants_ItemCommand" AlternatingItemStyle-BackColor="#FBEFF8" BackColor="#EFEFFB">
                                <ItemTemplate>
                                <table width="98%" border="0">
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
                                        <td align="center" colspan="3">
                                            No. of Careers available for this Qualification :&nbsp; 
                                            <asp:LinkButton ID="lnkBtnCareers" runat="server" Text='<%#Eval("jobs")%>' ForeColor="Blue" CommandArgument='<%#Eval("id") %>' OnCommand="ViewJobs"></asp:LinkButton>
                                        </td>
                                    </tr>
                                    <tr><td height="5px"></td></tr>
                                    <tr>
                                        <td align="center" colspan="3">
                                            <asp:Label ID="lblFileName" runat="server" Text='<%#Eval("curriculam_vitaeName") %>' Visible="false"></asp:Label>
                                            <asp:Label ID="lblFilePath" runat="server" Text='<%#Eval("curriculam_vitaePath") %>' Visible="false"></asp:Label>                                           
                                            <asp:LinkButton ID="lnkBtnDownload" runat="server" CommandArgument='<%#Eval("id") %>' OnCommand="lnkDownload" ForeColor="Red">Download Resume</asp:LinkButton>
                                         </td>                                         
                                    </tr>
                                    <tr>
                                         <td colspan="3" align="center">  
                                            <asp:TextBox ID="txtresume" runat="server" TextMode="MultiLine" Height="250px" Width="90%" Visible="false"></asp:TextBox>                      
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
            <tr>
                <td align="center" class="style40">
                     <asp:Label ID="lblMsg" runat="server" Font-Bold="true" ForeColor="#5858FA"></asp:Label>
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
