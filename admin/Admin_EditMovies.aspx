<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Admin_EditMovies.aspx.cs" Inherits="admin_Admin_EditMovies" %>
<%@ Register Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" TagPrefix="cc3"  %>
<%@ Register Src="~/admin/user_control/Admin_Headermenu.ascx" TagName="Headermenu" TagPrefix="cc1" %>
<%@ Register Src="~/admin/user_control/Admin_LeftMenu.ascx" TagName="LeftMenu" TagPrefix="cc4" %>
<%@ Register Src="~/admin/user_control/Admin_MoviesHeader.ascx" TagName="MovieHeader" TagPrefix="cc2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<title>Justcalluz - Admin Control Panel - Update Movies</title>
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
    testwindow = window.open("http://www.justcalluz.com", "mywindow", "location=1,status=1,scrollbars=1,width=500,height=500");
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
                          <span style="font-size:21px; font-weight:bold; color:DarkBlue"> Update Movies</span> 
                        </td>
                      </tr>                     
                                                                  
                        <tr>
                            <td colspan="2">
                                <asp:Label ID="lblMessage" runat="server" ForeColor="OrangeRed" Font-Bold="true" Font-Size="Medium"></asp:Label>
                                <div style="float:right; width:50px; padding-right:20px;">
                            <a href="Admin_Movies.aspx" style="text-decoration:underline;">Back</a>                             
                             </div>
                            </td>
                        </tr>  
                        <tr>
                            <td>
                                <asp:Label ID="lblrecords" runat="server" ForeColor="OrangeRed" Font-Bold="true" Font-Size="Medium"></asp:Label>                                
                            </td>
                        </tr>   
                        <tr>
                            <td colspan="2"> 
                              <table width="100%">                                     
                                <tr>
                        <td align="right" class="adminform">
                           Movie Name 
                        </td>
                        <td align="center">
                           : 
                        </td>
                        <td align="left">
                            <asp:TextBox ID="txtMovieName" runat="server" Width="200px"></asp:TextBox> 
                            <asp:RequiredFieldValidator ID="rfvMovieName" runat="server" 
                                ControlToValidate="txtMovieName" 
                                ErrorMessage="Please enter Movie Name" 
                                ValidationGroup="UpdateMovie">*</asp:RequiredFieldValidator>
                        </td>
                     </tr>
                         <tr>
                        <td align="right" class="adminform">
                           Brief Description of Movie
                        </td>
                        <td align="center">
                           : 
                        </td>
                        <td align="left">
                            <asp:TextBox ID="txtMDesc" runat="server" Width="200px" Height="100px" TextMode="MultiLine"></asp:TextBox>                             
                        </td>
                     </tr>
                                <tr>
                        <td align="right" class="adminform">
                           Movie Language 
                        </td>
                        <td align="center">
                           : 
                        </td>
                        <td align="left">
                            <asp:DropDownList ID="ddlMLanguage" runat="server" Width="206px">
                            </asp:DropDownList>
                            <asp:RequiredFieldValidator ID="rfvMLangauage" runat="server" 
                                ControlToValidate="ddlMLanguage" ErrorMessage="Please select Language of Movie" 
                                ValidationGroup="UpdateMovie">*</asp:RequiredFieldValidator>
                        </td>
                     </tr>
                      <tr>
                        <td align="right" class="adminform">
                           Movie Status 
                        </td>
                        <td align="center">
                           : 
                        </td>
                        <td align="left">
                            <asp:DropDownList ID="ddlMStatus" runat="server" Width="206px">
                                <asp:ListItem Value="Status">Status</asp:ListItem>
                                <asp:ListItem Value="Currently Showing">Currently Showing</asp:ListItem>
                                <asp:ListItem Value="Forth Coming">Forth Coming</asp:ListItem>
                            </asp:DropDownList>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" InitialValue="Select" 
                                ControlToValidate="ddlMLanguage" ErrorMessage="Please select Language of Movie" 
                                ValidationGroup="PostMovieDetails">*</asp:RequiredFieldValidator>
                        </td>
                     </tr>
                                <tr>
                        <td align="right" class="adminform">
                          Movie for
                        </td>
                        <td align="center">
                           : 
                        </td>
                        <td align="left">
                            <asp:DropDownList ID="ddlMoviefor" runat="server" Width="206px">
                            <asp:ListItem Value="Select">Select</asp:ListItem>
                            <asp:ListItem Value="U">U</asp:ListItem>
                            <asp:ListItem Value="A">A</asp:ListItem>
                            <asp:ListItem Value="U/A">U/A</asp:ListItem>
                            </asp:DropDownList>
                            <asp:RequiredFieldValidator ID="rfvMoviefor" runat="server" InitialValue="Select" 
                                ControlToValidate="ddlMoviefor" ErrorMessage="Please enter Landmark" 
                                ValidationGroup="UpdateMovie">*</asp:RequiredFieldValidator>
                        </td>
                     </tr>
                                <tr>
                        <td align="right" class="adminform">
                          State
                        </td>
                        <td align="center">
                           : 
                        </td>
                        <td align="left">
                            <asp:DropDownList ID="ddlState" runat="server" Width="206px"
                                onselectedindexchanged="ddlState_SelectedIndexChanged" AutoPostBack="true">
                            </asp:DropDownList> 
                            <asp:RequiredFieldValidator ID="rfvState" runat="server"  InitialValue="Select State"
                                ControlToValidate="ddlState" ErrorMessage="Please select state" 
                                ValidationGroup="UpdateMovie">*</asp:RequiredFieldValidator>
                        </td>
                     </tr>
                                <tr>
                        <td align="right" class="adminform">
                          City
                        </td>
                        <td align="center">
                           : 
                        </td>
                        <td align="left">
                            <asp:DropDownList ID="ddlCity" runat="server" Width="206px" 
                            onselectedindexchanged="ddlCity_SelectedIndexChanged" AutoPostBack="true">
                            </asp:DropDownList>
                            <asp:RequiredFieldValidator ID="rfvCity" runat="server" InitialValue="Select City" 
                                ControlToValidate="ddlCity" ErrorMessage="Please select city" 
                                ValidationGroup="UpdateMovie">*</asp:RequiredFieldValidator>
                        </td>
                     </tr>   
                      <tr>
                        <td align="right" class="adminform">
                          Theatre Name
                        </td>
                        <td align="center">
                           : 
                        </td>
                        <td align="left">
                            <asp:DropDownList ID="ddlTheatre" runat="server" Width="206px" 
                                AutoPostBack="true" onselectedindexchanged="ddlTheatre_SelectedIndexChanged">
                            </asp:DropDownList> 
                            <asp:RequiredFieldValidator ID="rfvTheatre" runat="server" InitialValue="Select Theatre" 
                                ControlToValidate="ddlTheatre" ErrorMessage="Please Select Theater Name" 
                                ValidationGroup="PostMovieDetails">*</asp:RequiredFieldValidator>
                        </td>
                     </tr>  
                     <tr>
                        <td align="right" class="adminform">
                          Area of Theatre
                        </td>
                        <td align="center">
                           : 
                        </td>
                        <td align="left">
                            <asp:TextBox ID="txtTheatreArea" runat="server" ReadOnly="true" Width="202px"></asp:TextBox>
                           
                        </td>
                     </tr>                                  
                                <tr>
                        <td align="right" class="adminform">
                          Movie timings
                        </td>
                        <td align="center">
                           : 
                        </td>
                        <td align="left">
                            <asp:TextBox ID="txtTimings" runat="server" Width="202px"></asp:TextBox> 
                            <asp:RequiredFieldValidator ID="rfvTimings" runat="server" 
                                ControlToValidate="txtTimings" ErrorMessage="Please enter Show Timings" 
                                ValidationGroup="UpdateMovie">*</asp:RequiredFieldValidator>                                                                                                                                             
                        </td>
                     </tr>  
                                <tr>
                        <td align="right" class="adminform">
                         URL of Theatre to book tickets
                        </td>
                        <td align="center">
                           : 
                        </td>
                        <td align="left">
                            <asp:TextBox ID="txtURL" runat="server" Width="202px"></asp:TextBox>                                          
                            <asp:RegularExpressionValidator ID="revURL" runat="server" 
                                ControlToValidate="txtURL" ErrorMessage="Please enter valid URL" ValidationGroup="UpdateMovie" 
                                ValidationExpression="http(s)?://([\w-]+\.)+[\w-]+(/[\w- ./?%&amp;=]*)?">*</asp:RegularExpressionValidator>
                        </td>
                     </tr>                                                                             
                                <tr>
                                 <td height="10px" colspan="3">                        
                                 </td>
                                </tr>
                                <tr>            
                        <td align="center" colspan="3">
                            <asp:ImageButton ID="imgbtnUpdateMovie" runat="server" 
                                ImageUrl="~/admin/images/update.png"
                                ValidationGroup="UpdateMovie" onclick="imgbtnUpdateMovie_Click" /> 
                                &nbsp; &nbsp;
                                <asp:ImageButton ID="imbBtnCancel" runat="server" 
                                ImageUrl="~/admin/images/cancel.png" onclick="imbBtnCancel_Click"/>   
                                <asp:ValidationSummary ID="validsumms" runat="server" ShowMessageBox="true" ShowSummary="false" ValidationGroup="UpdateMovie" />     
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
    </center>
    </form>
</body>
</html>
