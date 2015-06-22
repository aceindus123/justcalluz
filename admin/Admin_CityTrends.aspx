<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Admin_CityTrends.aspx.cs" Inherits="admin_Admin_CityTrends" %>
<%@ Register Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" TagPrefix="cc3"  %>
<%@ Register Src="~/admin/user_control/Admin_Headermenu.ascx" TagName="Headermenu" TagPrefix="cc1" %>
<%@ Register Src="~/admin/user_control/Admin_LeftMenu.ascx" TagName="LeftMenu" TagPrefix="cc4" %>
<%@ Register Src="~/admin/user_control/Admin_CityTrendsHeader.ascx" TagName="CTHeader" TagPrefix="CTH" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<title>Justcalluz - Admin Control Panel - City Trends Home</title>
    <link href="starrater.css" rel="Stylesheet" type="text/css" />
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
            width: 750px;
        }
        .style39
        {
            width: 100px;
        }        
        </style>
              <script language="javascript" type="text/javascript">  
  	function confirm_delete(uid)
{
  if (confirm("Are you sure you want to delete this City Trend?")==true)
    document.location='Admin_DeleteCityTrends.aspx?mid=' +uid;
  else
    return false;
}
	function alertdelete()
{
alert("Selected City Trend has been deleted Successfully");
}
function alertaccept()
{
alert("Selected City Trend has been Accepted");
}
    </script>	
        <script type="text/javascript" src="js/tab.js"></script>

        </head>
<body onload="new Accordian('basic-accordian',5,'header_highlight');">
    <form id="form1" runat="server">
    <center>
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
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
                      <CTH:CTHeader ID="Cth1" runat="server" />
                    </td>
                    </tr> 
                     <tr>
                            <td colspan="3" align="right" style="padding-right:5px;">
                                <a href="http://www.justcalluz.com/City%20trends_Main.aspx" target="_blank"><img src="images/Click Here For SiteView.png" alt="Siteview"/></a>
                            </td>
                        </tr>  
                    <tr>
                        <td align="center" colspan="3">
                          <span style="font-size:16px; font-family:Verdana; font-weight:bold; color:DarkBlue"> City Trends - Home </span> 
                        </td>
                      </tr>                     
                                                                   
                        <tr>
                            <td colspan="3">
                                <asp:Label ID="lblMessage" runat="server" ForeColor="OrangeRed" Font-Bold="true" Font-Size="Medium"></asp:Label>
                            </td>
                        </tr>  
                        <tr>
                            <td colspan="3">
                                <asp:Label ID="lblrecords" runat="server" ForeColor="OrangeRed" Font-Bold="true" Font-Size="Medium"></asp:Label>                                
                            </td>
                        </tr>
                        <tr>
                            <td width="60%" align="right">
                              Select Category to view City Trends in the respective categories
                            </td>
                            <td align="center">
                               : 
                            </td>
                            <td align="left">
                                <asp:DropDownList ID="ddlCat" runat="server" 
                                    onselectedindexchanged="ddlCat_SelectedIndexChanged" AutoPostBack="true">                                    
                                </asp:DropDownList>
                            </td>
                        </tr>   
                        <tr>
                            <td align="right" colspan="4" style="padding-right:14px;padding-bottom:3px;">
                             <asp:LinkButton ID="lnkBack" runat="server" Text="Back"  OnClick="lnkBack_Click"></asp:LinkButton> 
                        </td>
                        </tr> 
                        <tr id="heading" runat="server" visible="false">
                            <td height="40px" colspan="3" align="center">
                                <span style="font-size:14px; font-family:Verdana; font-weight:bold; color:DarkOrange"> City Trends in the Category of 
                                    <asp:Label ID="lblHeader" runat="server" ForeColor="Red"></asp:Label>
                                </span> 
                            </td>
                        </tr>  
                         <tr>
                            <td colspan="3" align="left" style="width:100%;">
                                <asp:DataList ID="dlCT" runat="server" Width="100%" 
                                    onitemdatabound="dlCT_ItemDataBound">
                                    <ItemTemplate>
                                        <table style="border-color:#993366; border-width:1px; border-style:dotted;width:98%;">
                                            <tr>
                                                <td style="font-size:14px; font-family:Verdana; font-weight:bold;">
                                                    <asp:Label ID="lblmod" runat="server" Text='<%#Eval("mod") %>' Visible="false"></asp:Label>
                                                    <asp:Label ID="lblCtId" runat="server" Text='<%#Eval("ctId") %>' Visible="false"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr id="trMovies" runat="server">
                                                <td width="95%" style="padding-left:7px;">
                                                     <a href="Admin_CityTrendsDetails.aspx?ctId=<%#Eval("ctId")%>" style="text-decoration:none;">                                                    
                                                     <span style="font-size:14px; font-family:Verdana; font-weight:bold">
                                                        <asp:Label ID="Label1" runat="server" Text='<%#Eval("title") %>'></asp:Label>
                                                        &nbsp;-&nbsp;
                                                        <asp:Label ID="Label2" runat="server" Text='<%#Eval("posteddate") %>'></asp:Label>
                                                     </span>                                                    
                                                    </a>
                                                </td>
                                                <td width="5%" align="center" id="tdMEdit" runat="server">
                                                    <a href="Admin_ToEditCityTrends.aspx?CtId=<%# Eval("ctId")%>">
                                                    <img src='images/edit.gif' width='16' height='16' border='0' />                                                                                                   
                                                        </a>
                                                </td>
                                            </tr>
                                            <tr id="trOther" runat="server">
                                                <td width="95%" style="padding-left:7px;font-size:13px; font-family:Verdana;">
                                                     <a href="Admin_CityTrendsDetails.aspx?ctId=<%#Eval("ctId")%>" style="text-decoration:none;">                                                    
                                                     <span style="font-size:14px; font-family:Verdana; font-weight:bold">
                                                        <asp:Label ID="Label7" runat="server" Text='<%#Eval("title") %>'></asp:Label>                                                      
                                                     </span>                                                    
                                                    </a>
                                                </td>
                                                <td width="5%" align="center" id="tdOtherEdit" runat="server">
                                                    <a href="Admin_ToEditCityTrends.aspx?CtId=<%# Eval("ctId")%>">
                                                    <img src='images/edit.gif' width='16' height='16' border='0' />                                                                                                   
                                                        </a>
                                                </td>
                                            </tr>
                                            <tr id="trBusiness" runat="server">
                                                <td width="95%" style="padding-left:7px;">
                                                     <a href="Admin_CityTrendsDetails.aspx?CtId=<%#Eval("ctId")%>" style="text-decoration:none;">                                                    
                                                     <span style="font-size:14px; font-family:Verdana; font-weight:bold">
                                                        <asp:Label ID="Label8" runat="server" Text='<%#Eval("title") %>'></asp:Label>
                                                        &nbsp;-&nbsp;
                                                        <asp:Label ID="lblBusList" runat="server" Text='<%#Eval("listings") %>'></asp:Label>                                                  
                                                     </span>                                                    
                                                    </a>
                                                </td>
                                                <td width="5%" align="center" id="tdBEdit" runat="server">
                                                    <a href="Admin_ToEditCityTrends.aspx?CtId=<%# Eval("ctId")%>">
                                                    <img src='images/edit.gif' width='16' height='16' border='0' />                                                                                                   
                                                        </a>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td width="95%" style="padding-left:7px;">
                                                    <asp:Label ID="Label3" runat="server" Text='<%#Eval("posteddate") %>' Font-Size="Small"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;
                                                    <asp:Label ID="Label4" runat="server" Text='<%#Eval("postedby") %>' Font-Size="Small"></asp:Label>
                                                </td>
                                                <td width="5%" align="center" id="tdDelete" runat="server">
                                                    <img src='images/delete.gif' width='16' height='16' border='0' onclick='javascript:confirm_delete(" +<%# Eval("ctId")%>+");' /> 
                                                </td>
                                            </tr>
                                            <tr><td height="5px" colspan="2"></td></tr>
                                            <tr>
                                                <td style="padding-left:7px;">
                                                    <asp:Label ID="Label6" runat="server" Text='<%#Eval("Mdesc")%>' ForeColor="Maroon"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr><td height="5px" colspan="2"></td></tr>
                                            <tr>
                                                <td colspan="2" width="100%" style="padding-left:10px;">
                                                   <span style="color:#6699CC">Tagged</span>&nbsp;                                                                                                                                                     
                                                    <asp:Repeater ID="rptlist" runat="server" EnableViewState="False">
                                                      <ItemTemplate>    
                                                      <a href="Admin_CityTrendsDetails.aspx?CtId=<%#Eval("ctid")%>" style="text-decoration:none;">
                                                          <asp:Label ID="Label9" runat="server" Text='<%#Eval("list")%>' ForeColor="#6699FF"></asp:Label>
                                                      </a>                                                                                                                            
                                                      </ItemTemplate>     
                                                      <SeparatorTemplate><span style="color:#6699FF">,</span> </SeparatorTemplate>
                                                    </asp:Repeater>
                                                </td>
                                            </tr>
                                            <%--<tr><td width="100%" height="10px" colspan="2" style="border-bottom-color:Gray; border-bottom-width:1px; border-bottom-style:dotted;"></td></tr>--%>
                                        </table>
                                    </ItemTemplate>
                                </asp:DataList>                                                                
                            </td>
                        </tr>
                         <tr>
                           
                             <td  align="left" style="padding-left:10px;"><asp:Label ID="lblCurrentPage" runat="server" Visible="false"></asp:Label></td>
                              <td align="right" style="padding-right:30px;" colspan="2">  <asp:LinkButton ID="lnkbtnPrevious" runat="server" OnClick="lnkbtnPrevious_Click1" 
                                    Font-Bold="True" Font-Size="Medium" Font-Underline="False" ForeColor="#FF6600" Visible="false">Previous</asp:LinkButton>&nbsp;
                                    <asp:LinkButton ID="lnkbtnNext" runat="server" OnClick="lnkbtnNext_Click1" Font-Bold="True" Font-Size="Medium" Font-Underline="False" ForeColor="#FF6600" Visible="false">Next</asp:LinkButton>
                          
                            </td>
                        </tr>
                        <tr id="trlblMessage" runat="server">
                        <td align="right" colspan="2">
                            <asp:Label ID="Label5" runat="server" Visible="false"></asp:Label>
                               <%-- <asp:Label ID="lblCurrentPage" runat="server" Visible="false"></asp:Label>--%>
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
