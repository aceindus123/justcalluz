<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Admin_ToPostCityTrends.aspx.cs" Inherits="admin_Admin_ToPostCityTrends" %>
<%@ Register Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" TagPrefix="cc3"  %>
<%@ Register Src="~/admin/user_control/Admin_Headermenu.ascx" TagName="Headermenu" TagPrefix="cc1" %>
<%@ Register Src="~/admin/user_control/Admin_LeftMenu.ascx" TagName="LeftMenu" TagPrefix="cc4" %>
<%@ Register Src="~/admin/user_control/Admin_CityTrendsHeader.ascx" TagName="CTHeader" TagPrefix="CTH" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<title>Justcalluz - Admin Control Panel - Post City Trends</title>
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
        <script type="text/javascript">
            function Alphabets(nkey) {
                var keyval
                if (navigator.appName == "Microsoft Internet Explorer") {
                    keyval = window.event.keyCode;
                }
                else if (navigator.appName == 'Netscape') {
                    nkeycode = nkey.which;
                    keyval = nkeycode;
                }
                //For A-Z
                if (keyval >= 65 && keyval <= 90) {
                    return true;
                }
                //For a-z
                else if (keyval >= 97 && keyval <= 122) {
                    return true;
                }
                //For Backspace
                else if (keyval == 8) {
                    return true;
                }
                //For General
                else if (keyval == 0) {
                    return true;
                }
                //For Space
                else if (keyval == 32) {
                    return true;
                }
                else {
                    return false;
                }
            } // End of the function
  
 </script>
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
        <script type="text/javascript">
function poponload()
{
    testwindow = window.open("http://www.justcalluz.com/City%20trends_Main.aspx", "mywindow", "location=1,status=1,scrollbars=1,width=500,height=500");
    testwindow.moveTo(400,-2000);
}
</script>
        </head>
<body onload="new Accordian('basic-accordian',5,'header_highlight');">
 
    <form id="form1" runat="server">  <center>
    <asp:ScriptManager ID="ScriptManager2" runat="server">
    </asp:ScriptManager>
  
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
                    <td colspan="2">                      
                      <CTH:CTHeader ID="Cth1" runat="server" />
                    </td>
                    </tr> 
                    <tr><td height="5px"></td></tr>  
                    <tr>
                        
                      </tr>                     
                        <tr>
                            <td align="right"  style="padding-right:10px; width:40%">
                               <a href="http://www.justcalluz.com/City%20trends_Main.aspx" target="_blank"> 
                           <img src="images/Click Here For SiteView.png"/>
                        </a>
                            </td>
                            </tr>
                            <tr>
                            <td align="center"  colspan="2">
                          <span style="font-size:21px; font-weight:bold; color:DarkBlue"> Post City Trends </span> 
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
                        <tr><td height="20px"  colspan="2" align="right" style="padding-right:8px;">
                                  <asp:LinkButton ID="lnkBack" runat="server" Text="Back" PostBackUrl="Admin_CityTrends.aspx"></asp:LinkButton>
                        </td></tr>  
                        <tr>
                            <td style="padding-left:50px; padding-right:50px;">
                               <table width="100%">
                               <tr id="tr1" runat="server">
                                    <td class="adminform">
                                        City trends Module
                                    </td>
                                    <td>
                                        :
                                    </td>
                                    <td>
                                        <asp:DropDownList ID="ddlMod" runat="server" 
                                            onselectedindexchanged="ddlMod_SelectedIndexChanged" AutoPostBack="true" Width="175px">
                                        </asp:DropDownList>
                                        <asp:RequiredFieldValidator ID="rfvMod" runat="server" 
                                            ControlToValidate="ddlMod" ErrorMessage="Please select Module" 
                                            ValidationGroup="PostCityTrends" InitialValue="Select Module">*</asp:RequiredFieldValidator>
                                    </td>
                                </tr>
                                <tr id="trCat" runat="server" visible="false">
                                    <td class="adminform">
                                        City trends Category
                                    </td>
                                    <td>
                                        :
                                    </td>
                                    <td>
                                        <asp:DropDownList ID="ddlCat" runat="server" Width="175px" 
                                            onselectedindexchanged="ddlCat_SelectedIndexChanged" AutoPostBack="true">
                                        </asp:DropDownList>
                                         <asp:RequiredFieldValidator ID="rfvCat" runat="server" 
                                            ControlToValidate="ddlCat" ErrorMessage="Please select Category" 
                                            ValidationGroup="PostCityTrends" InitialValue="Select Category">*</asp:RequiredFieldValidator>
                                    </td>
                                </tr>
                                <tr id="trSubCat" runat="server" visible="false">
                                    <td class="adminform">
                                        City trends Sub Category
                                    </td>
                                    <td>
                                        :
                                    </td>
                                    <td>
                                        <asp:DropDownList ID="ddlSubCat" runat="server" Width="175px">
                                        </asp:DropDownList>
                                         <asp:RequiredFieldValidator ID="rfvSubCat" runat="server" 
                                            ControlToValidate="ddlSubCat" ErrorMessage="Please select Sub Category" 
                                            ValidationGroup="PostCityTrends" InitialValue="Select SubCategory">*</asp:RequiredFieldValidator>
                                    </td>
                                </tr>
                                <tr id="trState" runat="server">
                                    <td class="adminform">
                                       State 
                                    </td>
                                    <td>
                                        :
                                    </td>
                                    <td>
                                        <asp:DropDownList ID="ddlState" runat="server" 
                                            onselectedindexchanged="ddlState_SelectedIndexChanged" AutoPostBack="true" Width="175px">
                                        </asp:DropDownList>
                                         <asp:RequiredFieldValidator ID="rfvState" runat="server" 
                                            ControlToValidate="ddlState" ErrorMessage="Please select State" 
                                            ValidationGroup="PostCityTrends" InitialValue="Select State">*</asp:RequiredFieldValidator>
                                    </td>
                                </tr>
                                <tr id="trCity" runat="server">
                                    <td class="adminform">
                                      City
                                    </td>
                                    <td>
                                        :
                                    </td>
                                    <td>
                                        <asp:DropDownList ID="ddlCity" runat="server" 
                                            onselectedindexchanged="ddlCity_SelectedIndexChanged" AutoPostBack="true" Width="175px">
                                        </asp:DropDownList>
                                         <asp:RequiredFieldValidator ID="rfvCity" runat="server" 
                                            ControlToValidate="ddlCity" ErrorMessage="Please select City" 
                                            ValidationGroup="PostCityTrends" InitialValue="Select City">*</asp:RequiredFieldValidator>
                                    </td>
                                    
                                </tr>
                                <tr id="trTitle" runat="server" visible="false">
                                    <td class="adminform">
                                        Title
                                    </td>
                                    <td>
                                        :
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtTitle" runat="server" Width="175px"  onkeypress="return Alphabets(event);"></asp:TextBox> 
                                        <asp:RequiredFieldValidator ID="rfvTitle" runat="server" 
                                            ControlToValidate="txtTitle" ErrorMessage="Please enter title" 
                                            ValidationGroup="PostCityTrends">*</asp:RequiredFieldValidator>
                                    </td>
                                </tr>
                                 <tr id="trList" runat="server">
                                    <td class="adminform">
                                        Select Top
                                        <asp:Label ID="lblselecttop" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        :
                                    </td>
                                    <td>
                                        <asp:ListBox ID="lstCompNames" runat="server" Width="179px" 
                                            SelectionMode="Multiple" 
                                           ></asp:ListBox> 
                                        <asp:CustomValidator ID="CustomValidator1" runat="server" 
                                            ErrorMessage="Please select 5 items only." Display="Dynamic" 
                                            onservervalidate="CustomValidator1_ServerValidate" 
                                            ValidationGroup="PostCityTrends"></asp:CustomValidator>
                                        <asp:Label ID="lblInfo" runat="server"></asp:Label>
                                         <asp:RequiredFieldValidator ID="rfvList" runat="server" 
                                            ControlToValidate="lstCompNames" ErrorMessage="Please select" 
                                            ValidationGroup="PostCityTrends">*</asp:RequiredFieldValidator>
                                    </td>
                                </tr>
                              
                               
                                <tr id="trddlList" runat="server" visible="false">
                                    <td class="adminform">
                                        Select 
                                        <asp:Label ID="lbl" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        :
                                    </td>
                                    <td>
                                        <asp:DropDownList ID="ddlCompNames" runat="server" Width="175px" 
                                            onselectedindexchanged="ddlCompNames_SelectedIndexChanged" AutoPostBack="true">
                                        </asp:DropDownList>
                                        <asp:RequiredFieldValidator ID="rfvddlcompname" runat="server" 
                                            ControlToValidate="ddlCompNames" ErrorMessage="Please select company name" InitialValue="Select Listing" 
                                            ValidationGroup="PostCityTrends">*</asp:RequiredFieldValidator>
                                    </td>
                                </tr>
                                <tr id="trArea" runat="server">
                                    <td class="adminform">                                       
                                        Area of the Listing held
                                    </td>
                                    <td>
                                        :
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtArea" runat="server" Width="175px" onkeypress="return Alphabets(event);"></asp:TextBox> 
                                         <asp:RequiredFieldValidator ID="rfvArea" runat="server" 
                                            ControlToValidate="txtArea" ErrorMessage="Please enter description" 
                                            ValidationGroup="PostCityTrends">*</asp:RequiredFieldValidator>
                                    </td>
                                </tr>
                                  <tr id="trGDesc" runat="server">
                                    <td class="adminform">
                                        <asp:Label ID="lblcompdesc" runat="server"></asp:Label>
                                        Description
                                    </td>
                                    <td>
                                        :
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtDesc" runat="server" TextMode="MultiLine" Width="400px" Height="200px"></asp:TextBox> 
                                         <asp:RequiredFieldValidator ID="rfvDesc" runat="server" 
                                            ControlToValidate="txtDesc" ErrorMessage="Please enter description" 
                                            ValidationGroup="PostCityTrends">*</asp:RequiredFieldValidator>
                                    </td>
                                </tr>                               
                               </table> 
                            </td>
                        </tr>
                        <tr>
                            <td colspan="3" align="center">
                                <asp:ImageButton ID="imgBtnPost" runat="server" 
                                    ImageUrl="~/admin/images/post.png" onclick="imgBtnPost_Click" 
                                    ValidationGroup="PostCityTrends" />
                                    &nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:ImageButton ID="imgBtn_Cancel" runat="server" 
                                ImageUrl="~/admin/images/cancel.png" onclick="imgBtn_Cancel_Click" 
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
    </center>
    </form>
</body>
</html>
