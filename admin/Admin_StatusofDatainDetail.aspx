<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Admin_StatusofDatainDetail.aspx.cs" Inherits="admin_Admin_StatusofDatainDetail" %>
<%@ Register Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" TagPrefix="cc3"  %>
<%@ Register Src="~/admin/user_control/Admin_Headermenu.ascx" TagName="Headermenu" TagPrefix="cc1" %>
<%@ Register Src="~/admin/user_control/Admin_LeftMenu.ascx" TagName="LeftMenu" TagPrefix="cc4" %>
<%@ Register Src="~/admin/user_control/Admin_DataHeader.ascx" TagName="dataHeader" TagPrefix="dataHead" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title>Justcalluz - Admin Control Panel - Log of Data</title>  
  <link href="~/admin/includes/style.css" rel="Stylesheet" type="text/css" />
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
            <table cellpadding="0" cellspacing="0" width="100%">
              <tr>
                <td class="style39" valign="top" style="padding-top:4px;">                         
                 <cc4:LeftMenu ID="LeftMenu1" runat="server" />
                </td>
                <td valign="top">&nbsp;</td>
                <td valign="top" style="padding-left:10px; background-color:#F2FAFC;width:100%;">  
                    <table width="100%"> 
                    <tr>
                            <td>                                
                               <dataHead:dataHeader ID="datahead1" runat="server" />
                            </td>
                        </tr>
                        <tr><td  align="right" style="padding-right:8px;">
                         <a href="http://www.justcalluz.com" target="_blank"><img src="images/Click Here For SiteView.png" alt="Siteview"/></a>
                        </td></tr>                               
                        <tr>
                            <td align="center" colspan="2" style="width:100%;">
                           
                                <asp:Label ID="lblMessage" runat="server"></asp:Label> 
                            </td>
                        </tr>  
                        <tr>
                            <td align="right" colspan="2" style="width:100%;padding-right:8px;">
                           <asp:LinkButton ID="lnkBack" runat="server" Text="Back" onclick="lnkBack_Click"></asp:LinkButton>
                            </td>
                        </tr>  
                        <tr>
                        <td colspan="2" style="width:100%;">
                            <table width="730px" border="0">                    
                               
                                <tr>
                                <td colspan="2" align="center" style="height:50px">
                                 Status of &nbsp;
                                    <asp:Label ID="lblName" runat="server" Font-Size="Medium" ForeColor="OrangeRed" Font-Bold="true"></asp:Label> 
                                    &nbsp; in the module of
                                <asp:Label ID="lblName1" runat="server" Font-Size="Medium" ForeColor="OrangeRed" Font-Bold="true"></asp:Label>
                                </td>
                                </tr>
                                                 
                            <tr>
                         <td colspan="2" style="width:100%;">
                          <asp:DataList ID="dlStatusDetails" runat="server" Width="100%" 
                                 onitemdatabound="dlStatusDetails_ItemDataBound">
                           <ItemTemplate>
                            <table width="100%" border="0" style="border-bottom:#036 1px groove; border-top:#036 1px groove;  padding:5px; background: url(images/menubg.jpg) top repeat-x; height:35px;">
                             <tr>                                                          
                              <td style="width:80%"> 
                                <asp:Label ID="lblstatus" runat="server" Text='<%#Eval("Statusin") %>'></asp:Label> &nbsp;
                                <asp:Label ID="lblEmaiid" runat="server" Text='<%#Eval("By_EmailId") %>'></asp:Label> &nbsp;on&nbsp;                                                  
                                <asp:Label ID="lblDte" runat="server" Text='<%#Eval("Date") %>'></asp:Label>                                                                                                                                                                     
                               </td>                               
                              </tr>                                                            
                             </table>                                                                                              
                            </ItemTemplate>                                                                           
                          </asp:DataList>           
                    </td>
                    </tr>                      
                    <tr>
                        <td style="width:100%;" colspan="2">
                           <asp:DataList ID="dlPostDetails" runat="server" Width="100%" 
                                onitemdatabound="dlPostDetails_ItemDataBound">
                           <ItemTemplate>
                            <table width="100%" border="0" style="border-bottom:#036 1px groove; border-top:#036 1px groove;  padding:5px; background: url(images/menubg.jpg) top repeat-x; height:35px;">
                             <tr>                                                          
                              <td style="width:80%"> 
                                <asp:Label ID="lblstatus1" runat="server" Text='<%#Eval("Status") %>'></asp:Label> &nbsp;
                                <asp:Label ID="lblEmaiid1" runat="server" Text='<%#Eval("UserLoginId") %>'></asp:Label> &nbsp;on&nbsp;                                                  
                                <asp:Label ID="lblDte1" runat="server" Text='<%#Eval("postdate") %>'></asp:Label>                                                                                                                                                                     
                               </td>                               
                              </tr>                                                            
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
                                <asp:Label ID="Label1" runat="server" Visible="false"></asp:Label>
                            </td>
                        </tr> 
                    <tr>
                        <td colspan="2" style="width:100%;" align="right">
                            <asp:Label ID="lblCurrentPage" runat="server"></asp:Label>
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
