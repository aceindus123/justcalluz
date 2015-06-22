<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Admin_RegUsersDetails.aspx.cs" Inherits="admin_Admin_RegUsersDetails" %>
<%@ Register Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" TagPrefix="cc3"  %>
<%@ Register Src="~/admin/user_control/Admin_Headermenu.ascx" TagName="Headermenu" TagPrefix="cc1" %>
<%@ Register Src="~/admin/user_control/Admin_LeftMenu.ascx" TagName="LeftMenu" TagPrefix="cc4" %>
<%@ Register Src="~/admin/user_control/Admin_WebsiteUserHeader.ascx" TagName="WUInfo" TagPrefix="WebUInfo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<title>Justcalluz - Admin Control Panel - Registered user details</title>
    <link href="~/admin/includes/style.css" rel="Stylesheet" type="text/css" />
    <script type="text/javasrcipt" src="http://ajax.googleapis.com/ajax/libs/jquery/1.6.2/jquery.min.js"></script>
    <script type="text/javascript" src="js/tab.js"></script>
	
    </head>
<body onload="new Accordian('basic-accordian',5,'header_highlight');">
    <form id="form1" runat="server">
    <center>
    <div>
       <table cellpadding="0" cellspacing="0">
         <tr>
            <td>
             <cc1:headermenu ID="header" runat="server" />
            </td>
         </tr>
         <tr>
           <td align="center">                  
            <table cellpadding="0" cellspacing="0" width="770px">
              <tr>
                <td class="style39" valign="top" style="padding-top:4px">                         
                 <cc4:LeftMenu ID="LeftMenu1" runat="server" />
                </td>
                <td valign="top">&nbsp;</td>
                <td valign="top" align="center" style="background-color:#F2FAFC">                    
                    <table width="750px">
                        <tr>
                            <td colspan="2">
                                <WebUInfo:WUInfo ID="WUInfo1" runat="server" />
                            </td>
                        </tr>
                        <tr><td height="20px" align="right" colspan="2" style="padding-right:5px;">
                        <a href="http://www.justcalluz.com" target="_blank"><img src="images/Click Here For SiteView.png" alt="Siteview"/></a>
                        </td></tr>
                        <tr><td align="center" colspan="2">
                            <asp:Label ID="Label1" runat="server" Text="Details of Registered Customer" ForeColor="OrangeRed" Font-Bold="true" Font-Size="Medium"></asp:Label>
                        </td></tr>
                        <tr>
                          <td align="right" colspan="2" style="padding-right:10px;padding-bottom:3px;">
                             <asp:LinkButton ID="lnkBack" runat="server" Text="Back"  PostBackUrl="Admin_WesiteUsersInfo.aspx"></asp:LinkButton> 
                        </td>
                        </tr>
                        <tr>
                        <td style="width:25%;">&nbsp;</td>
                          <td align="center">
                             <asp:DataList ID="dlUsersInfo" runat="server" Width="100%" onitemdatabound="dlUsersInfo_ItemDataBound">
                                 <HeaderTemplate></HeaderTemplate>
                                 <ItemTemplate>
                                 <table border="0" width="100%" >                                                                                                                                     
                                  <tr id="trRegType" runat="server">
                                    <td align="left" style="width:25%;">Type of Registration</td>
                                    <td align="center" style="width:1%;"><strong>&nbsp;:&nbsp;</strong></td>
                                    <td height="30" align="left" style="width:55%;padding-left:3%;">  
                                        <asp:Label ID="lblRegType" runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "RegType")%>'></asp:Label>
                                    </td>  
                                  </tr> 
                                  <tr id="trPerInfoHead" runat="server"><td colspan="3" align="left">
                                  <span style="color:Maroon; font-size:medium;font-weight:bold;">Personal Information:</span></td></tr>
                                  <tr id="trName" runat="server">
                                    <td align="left">Name</td>
                                    <td align="center" style="width:1%;"><strong>&nbsp;:&nbsp;</strong></td>
                                    <td height="30" align="left" style="width:55%;padding-left:3%;">  
                                        <asp:Label ID="lblFName" runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "name")%>'></asp:Label> &nbsp;
                                        <asp:Label ID="lblLName" runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "LastName")%>'></asp:Label>
                                    </td>
                                  </tr> 
                                  <tr>
                                    <td align="left">Email Id/Log in Id</td>
                                    <td align="center" style="width:1%;"><strong>&nbsp;:&nbsp;</strong></td>
                                    <td height="30" align="left" style="width:55%;padding-left:3%;">  
                                        <asp:Label ID="lblEmail" runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "email")%>'></asp:Label>
                                    </td>
                                  </tr> 
                                  <tr>
                                    <td align="left">Mobile</td>
                                    <td align="center" style="width:1%;"><strong>&nbsp;:&nbsp;</strong></td>
                                    <td height="30" style="width:55%;padding-left:3%;" align="left">  
                                        <asp:Label ID="lblMob" runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "mob")%>'></asp:Label>
                                    </td>
                                  </tr> 
                                  <tr>
                                    <td align="left">Password</td>
                                    <td align="center" style="width:1%;"><strong>&nbsp;:&nbsp;</strong></td>
                                    <td height="30" style="width:55%;padding-left:3%;" align="left">  
                                        <asp:Label ID="lblPwd" runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "password")%>'></asp:Label>
                                    </td>
                                  </tr> 
                                  <tr id="trBInfoHead" runat="server">
                                  <td colspan="3" align="left"><span style="color:Maroon; font-size:medium;font-weight:bold;">Business Information:</span></td></tr>
                                  <tr id="trBName" runat="server">
                                    <td align="left">Name of the Business</td>
                                    <td align="center" style="width:1%;"><strong>&nbsp;:&nbsp;</strong></td>
                                    <td height="30" style="width:55%;padding-left:3%;" align="left">  
                                        <asp:Label ID="lblBName" runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "bname")%>'></asp:Label>
                                    </td>
                                  </tr> 
                                  <tr id="trKOB" runat="server">
                                    <td align="left">Kind of Business</td>
                                    <td align="center" style="width:1%;"><strong>&nbsp;:&nbsp;</strong></td>
                                    <td height="30" style="width:55%;padding-left:3%;" align="left">  
                                        <asp:Label ID="lblKOB" runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "kindofbusiness")%>'></asp:Label>
                                    </td>
                                  </tr> 
                                  
                                  <tr id="trBdesc" runat="server">
                                    <td align="left">Business Description</td>
                                    <td align="center" style="width:1%;"><strong>&nbsp;:&nbsp;</strong></td>
                                    <td height="30" style="width:55%;padding-left:3%;" align="left">  
                                        <asp:Label ID="lblBDesc" runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "des")%>'></asp:Label>
                                    </td>
                                  </tr> 
                                  <tr id="trAddress" runat="server">
                                    <td align="left">Address</td>
                                    <td align="center" style="width:1%;"><strong>&nbsp;:&nbsp;</strong></td>
                                    <td height="30" style="width:55%;padding-left:3%;" align="left"> 
                                        <asp:Label ID="lblAddress" runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "addr")%>'></asp:Label>                                    
                                    </td>
                                  </tr> 
                                  <tr id="trLandMark" runat="server">
                                    <td align="left">Land Mark</td>
                                    <td align="center" style="width:1%;"><strong>&nbsp;:&nbsp;</strong></td>
                                    <td height="30" style="width:55%;padding-left:3%;" align="left">  
                                        <asp:Label ID="lblLandMark" runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "landmark")%>'></asp:Label>
                                    </td>
                                  </tr> 
                                  <tr id="trCity" runat="server">
                                    <td align="left">City</td>
                                    <td align="center" style="width:1%;"><strong>&nbsp;:&nbsp;</strong></td>
                                    <td height="30" style="width:55%;padding-left:3%;" align="left">  
                                        <asp:Label ID="lblCity" runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "city")%>'></asp:Label>
                                    </td>
                                  </tr> 
                                  <tr id="trState" runat="server">
                                    <td align="left">State</td>
                                    <td align="center" style="width:1%;"><strong>&nbsp;:&nbsp;</strong></td>
                                    <td height="30" style="width:55%;padding-left:3%;" align="left">  
                                        <asp:Label ID="lblState" runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "state")%>'></asp:Label>
                                    </td>
                                  </tr>  
                                  <tr id="trPincode" runat="server">
                                    <td align="left">Pin Code</td>
                                    <td align="center" style="width:1%;"><strong>&nbsp;:&nbsp;</strong></td>
                                    <td height="30" style="width:55%;padding-left:3%;" align="left">  
                                        <asp:Label ID="lblPincode" runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "PinCode")%>'></asp:Label>
                                    </td>
                                  </tr> 
                                  <tr id="trLandPh" runat="server">
                                    <td align="left">Landline Number</td>
                                    <td align="center" style="width:1%;"><strong>&nbsp;:&nbsp;</strong></td>
                                    <td height="30" style="width:55%;padding-left:3%;" align="left">  
                                        <asp:Label ID="lblLandPh" runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "landline")%>'></asp:Label>
                                    </td>
                                  </tr> 
                                  <tr id="trFax" runat="server">
                                    <td align="left">Fax</td>
                                    <td align="center" style="width:1%;"><strong>&nbsp;:&nbsp;</strong></td>
                                    <td height="30" style="width:55%;padding-left:3%;" align="left">  
                                        <asp:Label ID="lblFax" runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "fax")%>'></asp:Label>
                                    </td>
                                  </tr> 
                                  <tr id="trURL" runat="server">
                                    <td align="left">Website</td>
                                    <td align="center" style="width:1%;"><strong>&nbsp;:&nbsp;</strong></td>
                                    <td height="30" style="width:55%;padding-left:3%;" align="left">  
                                        <asp:Label ID="lblURL" runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "website")%>'></asp:Label>
                                    </td>
                                  </tr>                                                                   
                                 </table>
                                 </ItemTemplate>
                                 </asp:DataList>
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
