<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Admin_Movies.aspx.cs" Inherits="admin_Admin_Movies" %>
<%@ Register Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" TagPrefix="cc3"  %>
<%@ Register Src="~/admin/user_control/Admin_Headermenu.ascx" TagName="Headermenu" TagPrefix="cc1" %>
<%@ Register Src="~/admin/user_control/Admin_LeftMenu.ascx" TagName="LeftMenu" TagPrefix="cc4" %>
<%@ Register Src="~/admin/user_control/Admin_MoviesHeader.ascx" TagName="MovieHeader" TagPrefix="cc2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<title>Justcalluz - Admin Control Panel - Movies Home</title>
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
              
        <script type="text/javascript" src="js/tab.js"></script>
       <%-- <script type="text/javascript">
function poponload()
{
    testwindow = window.open("http://www.justcalluz.com/Movies.aspx?mname=null&mlang=null", "mywindow", "location=1,status=1,scrollbars=1,width=500,height=500");
    testwindow.moveTo(400,-2000);
}
</script>--%>
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
                    <td>                      
                      <cc2:MovieHeader ID="mheader" runat="server" />
                    </td>
                    </tr> 
                    <tr><td height="5px"></td></tr>
                      <tr>
                            <td colspan="2" align="right">
                                <asp:ScriptManager ID="ScriptManager1" runat="server">
                                </asp:ScriptManager>
                                 <a  target="_blank" href="http://www.justcalluz.com/Movies.aspx?mname=null&mlang=null" ><img src="images/Click Here For SiteView.png" alt="Site View" /></a>
                                <%--<asp:ImageButton ID="imgsite" runat="server" OnClientClick="justcalluz:poponload();" ImageUrl="images/Click Here For SiteView.png"/>--%>
                            </td>
                        </tr>         
                    <tr>
                        <td align="center" colspan="2">
                          <span style="font-size:21px; font-weight:bold; color:DarkBlue"> Movies Home</span> 
                        </td>
                      </tr>                     
                                                             
                        <tr>
                            <td colspan="2">
                                <asp:Label ID="lblMessage" runat="server" ForeColor="OrangeRed" Font-Bold="true" Font-Size="Medium"></asp:Label>
                                <div style="float:right; width:50px; padding-right:20px;">
                             <asp:LinkButton ID="lnkBack" runat="server" Text="Back"  OnClick="lnkBack_Click"></asp:LinkButton></div>
                            </td>
                        </tr>  
                        <tr>
                            <td>
                                <asp:Label ID="lblrecords" runat="server" ForeColor="OrangeRed" Font-Bold="true" Font-Size="Medium"></asp:Label>                                
                            </td>
                        </tr>   
                        <tr>
                            <td colspan="2" align="center">
                                <table>
                                     <tr>
                                      <td class="adminform" align="right">State</td>
                                      <td align="center"> &nbsp;&nbsp;:&nbsp;&nbsp;</td>
                                      <td align="left">                               
                                          <asp:DropDownList ID="ddlState" runat="server" Width="186px" 
                                              onselectedindexchanged="ddlState_SelectedIndexChanged" AutoPostBack="true">
                                          </asp:DropDownList>                                          
                                          <%--<asp:RequiredFieldValidator ID="rfvState" runat="server" 
                                              ControlToValidate="ddlState" ErrorMessage="Please select State" 
                                              InitialValue="Select State" ValidationGroup="PostData">*</asp:RequiredFieldValidator>
                                           <cc3:ValidatorCalloutExtender ID="valoalextnState" runat="server" Enabled="true" TargetControlID="rfvState">
                                                          </cc3:ValidatorCalloutExtender>--%>
                                      </td>
                                    </tr>  
                                    <tr>
                                      <td class="adminform" align="right">City</td>
                                      <td align="center"> &nbsp;&nbsp;:&nbsp;&nbsp;</td>
                                      <td align="left">                               
                                          <asp:DropDownList ID="ddlCity" runat="server" Width="186px" 
                                              >
                                          </asp:DropDownList>                                          
                                         <%-- <asp:RequiredFieldValidator ID="rfvCity" runat="server" 
                                              ControlToValidate="ddlCity" ErrorMessage="Please select City" 
                                              InitialValue="Select City" ValidationGroup="PostData">*</asp:RequiredFieldValidator>
                                           <cc3:ValidatorCalloutExtender ID="valcallextnCity" runat="server" Enabled="true" TargetControlID="rfvCity">
                                                          </cc3:ValidatorCalloutExtender>--%>
                                      </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                         <tr>
                            <td align="center">
                                <asp:LinkButton ID="lnkViewByMovie" runat="server" ForeColor="Crimson" 
                                    Font-Size="15px" onclick="lnkViewByMovie_Click">View By Movie Name</asp:LinkButton>                                                           
                                    &nbsp;  &nbsp;  &nbsp;  &nbsp;  &nbsp;  &nbsp; 
                                <asp:LinkButton ID="lnkViewByHall" runat="server" ForeColor="Crimson" 
                                    Font-Size="15px" onclick="lnkViewByHall_Click">View By Theatre Name</asp:LinkButton>
                            </td>
                            
                        </tr>   
                        <tr>
                            <td align="center">
                                <br />                               
                            </td>
                        </tr>                                      
            <tr>
                <td > 
                   <asp:DataList ID="dlMovies" DataKeyField="mid" runat="server" Width="100%" 
                        BorderColor="Brown" BorderWidth="1px" EnableViewState="true" OnItemDataBound="dlMovies_ItemDataBound"
    style="margin-left: 0px" >
                        <HeaderTemplate>
                        </HeaderTemplate>
                        <ItemTemplate>
                            <table width="100%" border="0px">
                            <tr style="background-color:#E0F8F7;">
                            <td style="padding-left:3px">                                                       
                            <asp:Label ID="Label1" runat="server" Text='<%#Eval("Movie_Name")%>' Font-Size="17px"></asp:Label>  
                            &nbsp;<span style="font-size:17px;">(<asp:Label ID="Label2" runat="server" Text='<%#Eval("Movie_Language")%>'></asp:Label> &nbsp;Movie)&nbsp;
                            <asp:Label ID="Label3" runat="server" Text='<%#Eval("Certify")%>'></asp:Label>  
                            </span>                                                    
                            </td>
                             <td width="5%" align="center" id="tdEd" runat="server"> 
                                           <a href="Admin_EditMovies.aspx?mid=<%# DataBinder.Eval(Container, "DataItem.mid")%>">
                                            <img src='images/edit.gif' width='16' height='16' border='0' />                                                                               
                                           </a>                                 
                                        </td>   
                                        <td  width="5%" align="center" id="tdDel" runat="server">
                                          <a onclick="return confirm('Are you sure to delete record ?');" href='Admin_DeleteMovies.aspx?mid=<%#Eval("mid") %>&city=<%#Eval("City") %>&state=<%#Eval("State") %>'>
                                        <img src="images/delete.gif" alt="delete" />
                                        </a>
                                        <%--<asp:ImageButton ID="imgdel" runat="server" ImageUrl="images/delete.gif" OnClientClick="return confirm('Are you sure to delete record ?');"
                                         PostBackUrl='<%# string.Format("Admin_DeleteMovies.aspx?mid=" + Eval("mid").ToString() + "&city=" + Eval("City").ToString() + "&state=" + Eval("State").ToString())%>' />--%>
                                        </td> 
                            <%--<td align=right>
                            <asp:ImageButton ID="imgdel" runat="server" ImageUrl="~/images/delete.gif" PostBackUrl='<%# string.Format("Admin_DeleteMovies.aspx?mid=" + Eval("mid").ToString())%>' />
                            </td>--%>
                            </tr>
                            <tr>
                                <td>
                                    
                                </td>
                            </tr>
                            <tr>
                            <td style="padding-left:5px" colspan="2">
                            <asp:DataList ID="dlMovieInfo" runat="server" onitemdatabound="dlMovieInfo_ItemDataBound" DataSource='<%# getHalls(Convert.ToString(Eval("Movie_Name")),Convert.ToString(Eval("Movie_Language")),Convert.ToString(Eval("City"))) %>' Width="100%" >
                                <EditItemStyle ForeColor="#CC3300" />
                                <AlternatingItemStyle ForeColor="#CC3300" />
                                <SelectedItemStyle ForeColor="#CC3300" />
                                <ItemTemplate>      
                                <table border="0px" width="100%" style="border-bottom-width:thin; border-bottom-color:Gray;">
                                    <tr>
                                        <td height="20px" colspan="2">
                                             <asp:LinkButton ID="lnkBtnHallName" runat="server" Font-Size="13px" Text='<%#Eval("CinemaHall_Name")%>' ForeColor="Blue" Font-Underline="true" CommandArgument='<%#Eval("HallId") %>' OnCommand="lnkGoHallInfo"></asp:LinkButton>, 
                                            <asp:Label ID="lblCity" runat="server" Text='<%#Eval("City")%>' ForeColor="Blue" Font-Size="13px" Font-Underline="true"></asp:Label>                                           
                                             &nbsp;                                             
                                            <asp:Label ID="lblURL" runat="server" Text='<%#Eval("URL")%>' Visible="false"></asp:Label>
                                            <asp:Label ID="lblHallId" runat="server" Text='<%#Eval("HallId")%>' Visible="false"></asp:Label>
                                            <asp:Label ID="lblHeading" runat="server" Font-Size="Large" ForeColor="#C910C9"></asp:Label>                                           
                                            <asp:Label ID="Label4" runat="server" CssClass="ui-rater">
                                                <asp:Label ID="Label2" runat="server" CssClass="ui-rater-starsOff" Width="90px" >
                                                    <asp:Label ID="testSpan0" runat="server" CssClass="ui-rater-starsOn">
                                                    </asp:Label>
                                                </asp:Label>            
                                            </asp:Label>                                                                                                               
                                        </td>                                        
                                    </tr>
                                    <tr>
                                        <td height="20px">
                                         <asp:Label ID="Label1" runat="server" Text='<%#Eval("Timings")%>' Font-Size="12px" ForeColor="DarkOrchid"></asp:Label> &nbsp;
                                         <asp:LinkButton ID="lnkBtnURL" runat="server" Text="Buy Tickets" PostBackUrl='<%#Eval("URL") %>' ForeColor="Chocolate" Visible="false"></asp:LinkButton>
                                         <asp:HyperLink ID="hlURL" runat="server" NavigateUrl='<%#Eval("URL") %>' Target="_blank" ForeColor="Chocolate" Text="Buy Tickets" Font-Underline="false" Visible="false"></asp:HyperLink> 
                                        </td>
                                        <td width="17%"><asp:Label ID="Label7" runat="server" Text='<%#Eval("Movie_Type")%>'></asp:Label></td>
                                    </tr>
                                </table>                                                                        
                                </ItemTemplate>
                            </asp:DataList>
                             </td>
                            </tr>
                            </table>
                        </ItemTemplate>                        
                    </asp:DataList>
                                                   
                </td>
            </tr>  
            <tr><td height="5px"></td></tr>
                  <tr id="tr1" runat="server">
          <td align="center">
            <asp:Button ID="cmdPrev1" runat="server" Text=" << " OnClick="cmdPrev1_Click" visible="false"></asp:Button>
              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="cmdNext1" runat="server" Text=" >> " OnClick="cmdNext1_Click" visible="false"></asp:Button>                              
          </td>
        </tr> 
        <tr><td></td></tr>
        <tr id="tr2" runat="server">
            <td align="right">
                <asp:Label ID="lblCurrentPage1" runat="server"></asp:Label>
            </td>
        </tr>
         <tr id="tr3" runat="server">
            <td align="center">
                <asp:Label ID="lblMsg1" runat="server"></asp:Label>
            </td>
        </tr>      
            <tr><td>          
        </td></tr>   
            <tr>
                <td>
                    <asp:DataList ID="dlHalls" DataKeyField="mid" runat="server" Width="100%" 
                        BorderColor="Brown" BorderWidth="1px"
    style="margin-left: 0px" >
                        <HeaderTemplate>
                        </HeaderTemplate>
                        <ItemTemplate>
                            <table width="100%" border="0px">
                            <tr style="background-color:#E0F8F7;">
                            <td style="padding-left:3px">       
                            <asp:LinkButton ID="lnkBtnHallName" runat="server" Font-Size="13px" Text='<%#Eval("CinemaHall_Name")%>' ForeColor="Blue" Font-Underline="true" CommandArgument='<%#Eval("HallId") %>' OnCommand="lnkGoHallInfo"></asp:LinkButton>&nbsp; 
                            <asp:Label ID="lblCity" runat="server" Text='<%#Eval("City")%>' ForeColor="Blue" Font-Size="13px" Font-Underline="true"></asp:Label>                                                                                                                                                                            
                            </td>
                            </tr>                           
                            <tr>
                            <td style="padding-left:5px" colspan="2">
                            <asp:DataList ID="dlMoviesinside" runat="server" onitemdatabound="dlMoviesinside_ItemDataBound" DataSource='<%# getMoviesinside(Convert.ToString(Eval("CinemaHall_Name")),Convert.ToString(Eval("HallId"))) %>' Width="100%" ForeColor="#CC00FF" >
                                <EditItemStyle ForeColor="#CC3300" />                               
                                <AlternatingItemStyle ForeColor="#009966" />
                                <SelectedItemStyle ForeColor="#CC3300" />
                                <ItemTemplate>      
                                <table border="0px" width="100%" style="border-bottom-width:12px; border-bottom-color:Black; border-width:thick">
                                    <tr>
                                        <td height="20px" width="95%">
                                             <asp:Label ID="Label6" runat="server" Text='<%#Eval("Movie_Name")%>' Font-Size="17px"></asp:Label>  
                                             &nbsp;<span style="font-size:17px;">(<asp:Label ID="Label5" runat="server" Text='<%#Eval("Movie_Language")%>'></asp:Label> &nbsp;Movie)&nbsp;
                                            (<asp:Label ID="Label3" runat="server" Text='<%#Eval("Certify")%>'></asp:Label>) 
                                            </span>                         &nbsp;                 
                                            <asp:Label ID="lblURL" runat="server" Text='<%#Eval("Movie_Type")%>'></asp:Label>  &nbsp;
                                            <asp:Label ID="Label8" runat="server" Text='<%#Eval("URL")%>' Visible="false"></asp:Label>                                                                                                                                                  
                                        </td>                                         
                                         <td width="5%" align="center" id="tdEdit" runat="server"> 
                                           <a href="Admin_EditMovies.aspx?mid=<%# DataBinder.Eval(Container, "DataItem.mid")%>">
                                            <img src='images/edit.gif' width='16' height='16' border='0' />                                                                               
                                           </a>                                 
                                        </td>                                       
                                    </tr>
                                    <tr>
                                        <td  width="95%">
                                         <asp:Label ID="Label1" runat="server" Text='<%#Eval("Timings")%>' Font-Size="12px" ForeColor="#660066"></asp:Label> &nbsp;
                                         <asp:LinkButton ID="lnkBtnURL" runat="server" Text="Buy Tickets" PostBackUrl='<%#Eval("URL") %>' ForeColor="Chocolate" Visible="false"></asp:LinkButton>
                                         <asp:HyperLink ID="hlURL" runat="server" NavigateUrl='<%#Eval("URL") %>' Target="_blank" ForeColor="Chocolate" Text="Buy Tickets" Font-Underline="false" Visible="false"></asp:HyperLink> 
                                        </td>
                                        <td  width="5%" align="center" id="tdDelete" runat="server">
                                        <a onclick="return confirm('Are you sure to delete record ?');" href='Admin_DeleteMovies.aspx?mid=<%#Eval("mid") %>&city=<%#Eval("City") %>&state=<%#Eval("State") %>'>
                                        <img src="images/delete.gif" alt="delete" />
                                        </a>
                                       <%-- <asp:ImageButton ID="imgdel" runat="server" ImageUrl="images/delete.gif" OnClientClick="return confirm('Are you sure to delete record ?');"
                                         PostBackUrl='<%# string.Format("Admin_DeleteMovies.aspx?mid=" + Eval("mid").ToString() + "&city=" + Eval("City").ToString() + "&state=" + Eval("State").ToString())%>' /> --%>                               
                                        </td>
                                    </tr>                                    
                                </table>                                                                        
                                </ItemTemplate>
                            </asp:DataList>
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
             <tr id="trnextpre" runat="server">
          <td align="center">
            <asp:Button ID="cmdPrev" runat="server" Text=" << " OnClick="cmdPrev_Click"  visible="false"></asp:Button>
              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="cmdNext" runat="server" Text=" >> " OnClick="cmdNext_Click"  visible="false"></asp:Button>                              
          </td>
        </tr> 
        <tr><td></td></tr>
        <tr id="trlblMessage" runat="server">
            <td align="right">
                <asp:Label ID="lblCurrentPage" runat="server"></asp:Label>
            </td>
        </tr>
         <tr id="trlblMsg" runat="server">
            <td align="center">
                <asp:Label ID="lblMsg" runat="server"></asp:Label>
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
