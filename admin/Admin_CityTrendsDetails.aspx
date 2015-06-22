<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Admin_CityTrendsDetails.aspx.cs" Inherits="admin_Admin_CityTrendsDetails" %>
<%@ Register Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" TagPrefix="cc3"  %>
<%@ Register Src="~/admin/user_control/Admin_Headermenu.ascx" TagName="Headermenu" TagPrefix="cc1" %>
<%@ Register Src="~/admin/user_control/Admin_LeftMenu.ascx" TagName="LeftMenu" TagPrefix="cc4" %>
<%@ Register Src="~/admin/user_control/Admin_CityTrendsHeader.ascx" TagName="CTHeader" TagPrefix="CTH" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<title>Justcalluz - Admin Control Panel - City Trends Details</title>
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
  if (confirm("Are you sure you want to delete this Movie?")==true)
    document.location='Admin_DeleteMovies.aspx?mid=' +uid;
  else
    return false;
}
	function alertdelete()
{
alert("Selected Movie has been deleted Successfully");
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
     
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
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
                      <CTH:CTHeader ID="Cth1" runat="server" />
                    </td>
                    </tr> 
                      <tr>
                            <td colspan="3" align="right" style="padding-right:5px;">
                                <a href="http://www.justcalluz.com/City%20trends_Main.aspx" target="_blank"><img src="images/Click Here For SiteView.png" alt="Siteview"/></a>
                            </td>
                        </tr>  
                    <tr>
                        <td align="center" colspan="3" style="padding-top:5px;">
                          <span style="font-size:14px; font-weight:bold; font-family:Verdana; color:DarkBlue">Brief Description of City Trends in the Category of
                              <asp:Label ID="lblHeader" runat="server" ForeColor="Red"></asp:Label>
                          </span> 
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
                            <td align="right" colspan="6" style="padding-right:12px;padding-bottom:3px;">
                             <asp:LinkButton ID="lnkBack" runat="server" Text="Back" OnClick="lnkBack_Click"></asp:LinkButton> 
                        </td>
                        </tr>
                        <tr><td colspan="3" >
                        <table width="100%" style="border-color:#993366; border-width:1px; border-style:dotted;width:98.5%;">
                         <tr>
                            <td colspan="3" >
                                <asp:DataList ID="dlCT" runat="server" Width="100%" 
                                    onitemdatabound="dlCT_ItemDataBound">
                                    <ItemTemplate>
                                        <table width="100%" border="0px">
                                            <tr>
                                                <td>
                                                    <asp:Label ID="lblmod" runat="server" Text='<%#Eval("mod") %>' Visible="false"></asp:Label>
                                                    <asp:Label ID="lblCtId" runat="server" Text='<%#Eval("ctId") %>' Visible="false"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr id="trMovies" runat="server">
                                                <td width="95%" style="padding-left:7px;">                                                     
                                                     <span style="font-size:large; font-weight:bold; color:#cc3300">
                                                        <asp:Label ID="Label1" runat="server" Text='<%#Eval("title") %>'></asp:Label>
                                                        &nbsp;-&nbsp;
                                                        <asp:Label ID="Label2" runat="server" Text='<%#Eval("posteddate") %>'></asp:Label>
                                                     </span>                                                                                                        
                                                </td>                                                
                                            </tr>
                                            <tr id="trOther" runat="server">
                                                <td width="95%" style="padding-left:7px;">                                                     
                                                     <span style="font-size:large; font-weight:bold; color:#cc3300">
                                                        <asp:Label ID="Label7" runat="server" Text='<%#Eval("title") %>'></asp:Label>                                                      
                                                     </span>                                                                                                   
                                                </td>                                                
                                            </tr>
                                            <tr id="trBusiness" runat="server">
                                                <td width="95%" style="padding-left:7px;">
                                                     <span style="font-size:large; font-weight:bold; color:#cc3300">
                                                        <asp:Label ID="Label8" runat="server" Text='<%#Eval("title") %>'></asp:Label>
                                                        &nbsp;-&nbsp;
                                                        <asp:Label ID="lblBusList" runat="server" Text='<%#Eval("listings") %>'></asp:Label>                                                  
                                                     </span>                                                    
                                                </td>                                                
                                            </tr>
                                            <tr><td height="5px" colspan="2"></td></tr>
                                             <tr>
                                                <td width="95%" style="padding-left:7px;" colspan="2">
                                                    <asp:Label ID="Label3" runat="server" Text='<%#Eval("posteddate") %>' Font-Size="Small"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;
                                                    <asp:Label ID="Label4" runat="server" Text='<%#Eval("postedby") %>' Font-Size="Small"></asp:Label>
                                                </td>                                                
                                            </tr>
                                            <tr><td height="5px" colspan="2"></td></tr>
                                            <tr>
                                                <td style="padding-left:7px;">
                                                    <asp:Label ID="Label6" runat="server" Text='<%#Eval("description")%>' ForeColor="Maroon"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td height="5px" colspan="2">
                                                    <asp:Label ID="lblListing" runat="server" Text='<%#Eval("listings")%>' ForeColor="Maroon" Visible="false"></asp:Label>
                                                    <asp:Label ID="lbldataId" runat="server" Text='<%#Eval("dataIds_lang")%>' ForeColor="Maroon" Visible="false"></asp:Label>
                                                </td>
                                            </tr> 
                                            <tr>
                                                <td height="10px"></td>
                                            </tr> 
                                             <tr id="trSubtitle" runat="server" visible="false">
                                                <td style="padding-left:7px;">
                                                    <asp:Label ID="lblsubtitle" runat="server" Text='<%#Eval("SubTitle")%>' Font-Size="Large" Font-Bold="true" Visible="false"></asp:Label>                                                    
                                                </td>
                                            </tr>                                                                                      
                                        </table>
                                    </ItemTemplate>
                                </asp:DataList>                                
                            </td>
                        </tr> 
                         <tr id="trvisible" runat="server" visible="false">
                            <td>
                                <asp:Label ID="lblListings" runat="server" Visible="false"></asp:Label>
                                <asp:Label ID="lblDataIds" runat="server" Visible="false"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td height="10px"></td>
                        </tr>
                        <tr>
                            <td style="padding-left:7px;">
                                <asp:DataList ID="dlMovieDetails" runat="server" Width="100%" >
                                    <ItemTemplate>
                                        <table width="100%" border="0px">
                                            <tr>
                                                <td>                                                                                                                                                         
                                                    <asp:Label ID="Label1" runat="server" Text='<%#Eval("Movie_Name") %>' ForeColor="#33CCFF"></asp:Label>&nbsp;:&nbsp;                                                                                                   
                                                    <asp:Label ID="Label2" runat="server" Text='<%#Eval("Movie_Desc") %>' ForeColor="Black"></asp:Label>                                                                                                     
                                                </td>                                                
                                            </tr>
                                            <tr><td height="10px"></td></tr>
                                        </table>
                                    </ItemTemplate>
                                </asp:DataList>
                            </td>
                        </tr>
                        <tr>
                            <td style="padding-left:7px;">
                                <asp:DataList ID="dlBusinesDetails" runat="server" Width="100%" >
                                    <ItemTemplate>
                                        <table width="100%" border="0px">
                                            <tr>
                                                <td>                                                                                                                                                         
                                                    <asp:Label ID="Label1" runat="server" Text='<%#Eval("company_name") %>' ForeColor="#33CCFF"></asp:Label>&nbsp;:&nbsp;                                                                                                   
                                                    <asp:Label ID="Label2" runat="server" Text='<%#Eval("company_profile") %>' ForeColor="Black"></asp:Label>                                                                                                     
                                                </td>                                                
                                            </tr>
                                            <tr><td height="10px"></td></tr>
                                        </table>
                                    </ItemTemplate>
                                </asp:DataList>
                            </td>
                        </tr>    
                        <tr>
                            <td style="padding-left:7px;">
                                <asp:DataList ID="dlOtherCatDetails" runat="server" Width="100%" >
                                    <ItemTemplate>
                                        <table width="100%" border="0px">
                                            <tr>
                                                <td>                                                                                                                                                         
                                                    <asp:Label ID="Label1" runat="server" Text='<%#Eval("MTitle") %>' ForeColor="#cc3300" Font-Bold="true" Font-Size="20px"></asp:Label>                 
                                                </td>                                                
                                            </tr>
                                            <tr><td height="10px"></td></tr>
                                            <tr>
                                                <td>                                                                                                                                                         
                                                    <asp:Label ID="Label9" runat="server" Text='<%#Eval("MInfo") %>' ForeColor="Black"></asp:Label>                 
                                                </td>                                                
                                            </tr>
                                            <tr><td height="10px"></td></tr>
                                        </table>
                                    </ItemTemplate>
                                </asp:DataList>
                            </td>
                        </tr> 
                        </table>  </td></tr>                                                                     
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
