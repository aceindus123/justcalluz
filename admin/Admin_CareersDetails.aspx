<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Admin_CareersDetails.aspx.cs" Inherits="admin_Admin_CareersDetails" %>
<%@ Register Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" TagPrefix="cc3"  %>
<%@ Register Src="~/admin/user_control/Admin_Headermenu.ascx" TagName="Headermenu" TagPrefix="cc1" %>
<%@ Register Src="~/admin/user_control/Admin_LeftMenu.ascx" TagName="LeftMenu" TagPrefix="cc4" %>
<%@ Register Src="~/admin/user_control/Admin_CareersHeader.ascx" TagName="CareersHeader" TagPrefix="Careers" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<title>Justcalluz - Admin Control Panel - Careers_Details</title>
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
                          <span style="font-size:21px; font-weight:bold; color:DarkBlue"> Careers Home - Job Information</span> 
                        </td>
                      </tr> 
                    <tr>
                        <td height="10px" align="right"><asp:ImageButton ID="imgsite" runat="server" OnClientClick="justcalluz:poponload();" ImageUrl="images/Click Here For SiteView.png"/></td>
                    </tr>                       
                        <tr>
                            <td>
                                <asp:DataList ID="dlCareers" runat="server" Width="100%" BackColor=" #FEF1EB" 
                                    onitemdatabound="dlCareers_ItemDataBound">
                                    <ItemTemplate>
                                        <table width="100%">
                                            
                                            <tr style="background-color:#D9E8FF">
                                                <td>
                                                    Job Title
                                                </td>                                                
                                                <td align="left">
                                                    <asp:Label ID="Label1" runat="server" Text='<%#Eval("title") %>'></asp:Label>
                                                </td>
                                            </tr>
                                            <tr><td height="7px"></td></tr>
                                            <tr>
                                                <td>
                                                    Category
                                                </td>                                              
                                                <td align="left">
                                                    <asp:Label ID="Label2" runat="server" Text='<%#Eval("category") %>'></asp:Label>
                                                </td>
                                            </tr>
                                            <tr><td height="7px"></td></tr>
                                            <tr  style="background-color: #D9E8FF">
                                                <td align="left">
                                                    Specialization
                                                </td>                                               
                                                <td align="left">
                                                    <asp:Label ID="Label3" runat="server" Text='<%#Eval("specialization") %>'></asp:Label>
                                                </td>
                                            </tr>
                                            <tr><td height="7px"></td></tr>
                                            <tr style="background-color:">
                                                <td>
                                                    Job Type
                                                </td>                                               
                                                <td align="left">
                                                    <asp:Label ID="Label4" runat="server" Text='<%#Eval("jobType") %>'></asp:Label>
                                                </td>
                                            </tr>
                                            <tr><td height="7px"></td></tr>
                                            <tr style="background-color: #D9E8FF">
                                                <td>
                                                    Job Status
                                                </td>                                               
                                                <td align="left">
                                                    <asp:Label ID="Label5" runat="server" Text='<%#Eval("jobStatus") %>'></asp:Label>
                                                </td>
                                            </tr>
                                            <tr><td height="7px"></td></tr>
                                            <tr>
                                                <td >
                                                    Work Experience
                                                </td>                                               
                                                <td align="left">
                                                    <asp:Label ID="Label6" runat="server" Text='<%#Eval("workExp") %>'></asp:Label>
                                                </td>
                                            </tr>
                                            <tr><td height="7px"></td></tr>
                                            <tr style="background-color: #D9E8FF">
                                                <td >
                                                    Salary
                                                </td>                                                
                                                <td align="left">                                                    
                                                    <asp:Label ID="lblsalRange" runat="server" Text='<%#Eval("salRange") %>'></asp:Label>
                                                </td>
                                            </tr>
                                            <tr><td height="7px"></td></tr>
                                            <tr>
                                                <td >
                                                    No. of Vacancies
                                                </td>                                               
                                                <td align="left">
                                                    <asp:Label ID="Label8" runat="server" Text='<%#Eval("noOfvacancies") %>'></asp:Label>
                                                </td>
                                            </tr>
                                            <tr><td height="7px"></td></tr>
                                            <tr style="background-color: #D9E8FF">
                                                <td >
                                                    Date Posted
                                                </td>                                               
                                                <td align="left">
                                                    <asp:Label ID="Label22" runat="server" Text='<%#Eval("posttime") %>'></asp:Label>
                                                </td>
                                            </tr>
                                            <tr><td height="7px"></td></tr>
                                            <tr>
                                                <td >
                                                    Job Description
                                                </td>                                                
                                                <td align="left">
                                                    <asp:Label ID="Label9" runat="server" Text='<%#Eval("jobDesc") %>'></asp:Label>
                                                </td>
                                            </tr>
                                            <tr><td height="7px"></td></tr>
                                            <tr style="background-color: #D9E8FF">
                                                <td >
                                                    Computer Knowledge
                                                </td>                                               
                                                <td align="left">
                                                    <asp:Label ID="Label10" runat="server" Text='<%#Eval("computerknowledge") %>'></asp:Label>
                                                </td>
                                            </tr>
                                            <tr><td height="7px"></td></tr>
                                            <tr>
                                                <td >
                                                    Basic Education
                                                </td>                                               
                                                <td align="left">
                                                    <asp:Label ID="Label11" runat="server" Text='<%#Eval("qualification") %>'></asp:Label>
                                                </td>
                                            </tr>
                                            <tr><td height="7px"></td></tr>
                                            <tr style="background-color: #D9E8FF">
                                                <td  valign="top">
                                                    Company Information
                                                </td>                                               
                                                <td align="left">
                                                <table>
                                                    <tr>
                                                        <td>
                                                        Address 1 :
                                                        
                                                        <asp:Label ID="Label12" runat="server" Text='<%#Eval("comp_address1") %>'></asp:Label>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                <td>
                                                    Address 2 :
                                                
                                                    <asp:Label ID="Label13" runat="server" Text='<%#Eval("comp_address2") %>'></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td >
                                                    City :
                                                
                                                    <asp:Label ID="Label14" runat="server" Text='<%#Eval("comp_city") %>'></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    State :
                                                
                                                    <asp:Label ID="Label15" runat="server" Text='<%#Eval("comp_state") %>'></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="right">
                                                   Pin Code :                                                
                                                    <asp:Label ID="Label16" runat="server" Text='<%#Eval("comp_pincode") %>'></asp:Label>
                                                </td>
                                            </tr>
                                                </table>                                                 
                                                </td>
                                            </tr> 
                                            <tr><td height="7px"></td></tr>                                           
                                            <tr>
                                                <td >
                                                   Contact Email
                                                </td>                                               
                                                <td align="left">
                                                    <asp:Label ID="Label18" runat="server" Text='<%#Eval("cont_email") %>'></asp:Label>
                                                </td>
                                            </tr>
                                            <tr><td height="7px"></td></tr>
                                            <tr style="background-color: #D9E8FF">                                           
                                                <td valign="top">
                                                    Contact Information
                                                </td>                                               
                                                <td align="left" valign="top">
                                                    <table>
                                                        <tr>
                                                            <td colspan="3">                                                            
                                                                <asp:Label ID="Label17" runat="server" Text='<%#Eval("contpersonName") %>'></asp:Label>
                                                            </td>
                                                        </tr>
                                                         <tr>                                               
                                                <td align="left">
                                                    <asp:Label ID="Label19" runat="server" Text='<%#Eval("cont_phone") %>'></asp:Label>
                                                </td>
                                                <td align="right">
                                                    Ext :
                                                </td>                                                
                                                <td align="left">
                                                    <asp:Label ID="Label20" runat="server" Text='<%#Eval("cont_ext") %>'></asp:Label>
                                                </td>
                                            </tr>                                                                                      
                                                    </table>
                                                    
                                                </td>                                                
                                            </tr>   
                                            <tr><td height="7px"></td></tr>
                                            <tr>
                                                <td >
                                                   Job Available till
                                                </td>                                               
                                                <td align="left">
                                                    <asp:Label ID="Label23" runat="server" Text='<%#Eval("exptime") %>'></asp:Label>
                                                </td>
                                            </tr>                                       
                                        </table>
                                    </ItemTemplate>
                                </asp:DataList>
                            </td>
                        </tr>
                        <tr>
                            <td height="5px"></td>
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
