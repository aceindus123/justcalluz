<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Admin_WhitePagesEdit.aspx.cs" Inherits="admin_Admin_WhitePagesEdit" %>
<%@ Register Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" TagPrefix="cc3"  %>
<%@ Register Src="~/admin/user_control/Admin_Headermenu.ascx" TagName="Headermenu" TagPrefix="cc1" %>
<%@ Register Src="~/admin/user_control/Admin_LeftMenu.ascx" TagName="LeftMenu" TagPrefix="cc4" %>
<%@ Register Src="~/admin/user_control/Admin_WPHeader.ascx" TagName="WPHead" TagPrefix="WPHeader" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<title>Justcalluz - Admin Control Panel - Update White Pages data</title>
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
        .stylealign
        {
           align:center
        }        
        </style>
      <script language="javascript" type="text/javascript">

          function confirm_delete(uid) {
              if (confirm("Are you sure you want to delete this Ad?") == true)
                  document.location = 'Admin_DeleteAd.aspx?cid=' + uid;
              else
                  return false;
          }
          function alertdelete() {
              alert("Selected Ad has been deleted Successfully");
          }
          function alertaccept() {
              alert("Selected Ad has been Accepted");
          }
    </script>
    <script language="jscript" type="text/jscript">
        function checkTextAreaMaxLength(textBox, e, length) {

            var mLen = textBox["MaxLength"];
            if (null == mLen)
                mLen = length;

            var maxLength = parseInt(mLen);
            if (!checkSpecialKeys(e)) {
                if (textBox.value.length > maxLength - 1) {
                    if (window.event)//IE
                    {
                        e.returnValue = false;
                        return false;
                    }
                    else//Firefox
                        e.preventDefault();
                }
            }
        }
        function checkSpecialKeys(e) {
            if (e.keyCode != 8 && e.keyCode != 46 && e.keyCode != 35 && e.keyCode != 36 && e.keyCode != 37 && e.keyCode != 38 && e.keyCode != 39 && e.keyCode != 40)
                return false;
            else
                return true;
        }     
    </script>	
        <script type="text/javascript" src="js/tab.js"></script>
       <%-- <script type="text/javascript">
function poponload()
{
    testwindow = window.open("http://www.justcalluz.com/White_Page.aspx", "mywindow", "location=1,status=1,scrollbars=1,width=500,height=500");
    testwindow.moveTo(400,-2000);
}
</script>	--%>
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
                       <WPHeader:WPHead ID="wpheader1" runat="server" />
                    </td>
                    </tr>                 
                    <tr><td height="5px"></td></tr>  
                      <tr>
                            <td  align="right">
                                <asp:ScriptManager ID="ScriptManager1" runat="server">
                                </asp:ScriptManager>
                                <a  target="_blank" href="http://www.justcalluz.com/White_Page.aspx" ><img src="images/Click Here For SiteView.png" alt="Site View" /></a>
                               <%-- <asp:ImageButton ID="imgsite" runat="server" OnClientClick="justcalluz:poponload();" ImageUrl="images/Click Here For SiteView.png"/>--%>
                            </td>
                        </tr>   
                    <tr>
                        <td align="center" >
                          <span style="font-size:21px; font-weight:bold; color:DarkBlue">Update White Pages data</span> 
                        </td>
                      </tr>                     
                                                                 
                        <tr>
                            <td >
                                <asp:Label ID="lblMessage" runat="server" ForeColor="OrangeRed" Font-Bold="true" Font-Size="Medium"></asp:Label>
                            <%--</td>
                            <td align="right" style="padding-right:20px;">--%>
                             <div style="float:right; width:50px; padding-right:20px;">
                            <a href="Admin_WhitePages.aspx" style="text-decoration:underline;">Back</a>                             
                             </div>
                            </td>
                        </tr>                                                                           
                        <tr><td height="20px"></td></tr>                                              
                        <tr>
                            <td style="background-color:#F2FAFC">
                                <table width="100%">
                                    <tr>
                                        <td class="adminform" align="right" width="20%">
                                          Popular City
                                        </td>
                                        <td width="5%" align="center">
                                            :
                                        </td>
                                        <td width="50%" align="left">
                                            <asp:DropDownList ID="ddlPopCity" runat="server" Width="200px" Enabled="false"                                               >
                                            </asp:DropDownList> 
                                            <asp:RequiredFieldValidator ID="rfvCity" runat="server" 
                                                ErrorMessage="Please select City" ControlToValidate="ddlPopCity" 
                                                InitialValue="Select City" ValidationGroup="UpdateWP"></asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr><td height="10px" colspan="3"></td></tr>
                                    <tr id="trcity" runat="server" visible="false">
                                        <td colspan="3" class="adminform" align="center">
                                            The categories which have information for the city 
                                            <asp:Label ID="lblCity" runat="server" ForeColor="Maroon" Font-Bold="true" Font-Size="12px"></asp:Label> are
                                            <asp:Label ID="lblRecord" runat="server" ForeColor="Maroon" Font-Bold="true" Font-Size="12px"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr><td height="10px" colspan="3"></td></tr>
                                    <tr id="trrepeater" runat="server" visible="false">
                                        <td colspan="3" class="adminform" align="center" style="text-align:justify;">
                                             <asp:Repeater ID="repeterCategories" runat="server" EnableViewState="False">
                                                 <ItemTemplate>                                                            
                                                     <a href="Admin_LinkControllerCategory.aspx?cat=<%#Eval("Category")%>&mod=<%#Eval("module") %>" style="text-decoration:none" target="_blank">
                                                     <asp:Label runat="server" ID="Label1" Text='<%# Eval("Category") %>' ForeColor="Maroon" Font-Bold="true" Font-Size="12px"></asp:Label>                                                     
                                                     </a>                                               
                                                 </ItemTemplate>     
                                                 <SeparatorTemplate>,</SeparatorTemplate>
                                             </asp:Repeater>                                            
                                        </td>
                                    </tr>
                                    <tr><td height="10px" colspan="3"></td></tr>
                                    <tr id="trinfo" runat="server" visible="false">
                                        <td colspan="3" class="adminform" align="center">
                                            Click on the Category to view records present in that.                                        </td>
                                    </tr>
                                    <tr><td height="10px" colspan="3"></td></tr>
                                    <tr>
                                        <td class="adminform" align="right" width="20%">
                                            Para - 1
                                        </td>
                                        <td width="5%" align="center">
                                            :
                                        </td>
                                        <td width="50%" align="left">
                                            <asp:TextBox ID="txtPara1" runat="server" TextMode="MultiLine" onkeyDown="return checkTextAreaMaxLength(this,event,'4000');" Height="100px" Width="300px"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="rfvpara1" runat="server" 
                                                ControlToValidate="txtPara1" ErrorMessage="Please enter data" 
                                                ValidationGroup="UpdateWP"></asp:RequiredFieldValidator>
                                        </td>
                                    </tr>  
                                    <tr><td height="10px" colspan="3"></td></tr>
                                    <tr>
                                        <td class="adminform" align="right" width="20%">
                                            Para - 2
                                        </td>
                                        <td width="5%" align="center">
                                            :
                                        </td>
                                        <td width="50%" align="left">
                                            <asp:TextBox ID="txtPara2" runat="server" TextMode="MultiLine" onkeyDown="return checkTextAreaMaxLength(this,event,'4000');" Height="100px" Width="300px"></asp:TextBox>
                                        </td>
                                    </tr> 
                                    <tr><td height="10px" colspan="3"></td></tr>
                                    <tr>
                                        <td class="adminform" align="right" width="20%">
                                            Para - 3
                                        </td>
                                        <td width="5%" align="center">
                                            :
                                        </td>
                                        <td width="50%" align="left">
                                            <asp:TextBox ID="txtPara3" runat="server" TextMode="MultiLine" onkeyDown="return checkTextAreaMaxLength(this,event,'4000');" Height="100px" Width="300px"></asp:TextBox>
                                        </td>
                                    </tr> 
                                    <tr><td height="10px" colspan="3"></td></tr>
                                    <tr>
                                        <td class="adminform" align="right" width="20%">
                                            Para - 4
                                        </td>
                                        <td width="5%" align="center">
                                            :
                                        </td>
                                        <td width="50%" align="left">
                                            <asp:TextBox ID="txtPara4" runat="server" TextMode="MultiLine" onkeyDown="return checkTextAreaMaxLength(this,event,'4000');" Height="100px" Width="300px"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr><td height="10px" colspan="3"></td></tr>   
                                    <tr>
                                        <td class="adminform" align="right" width="20%">
                                            Para - 5
                                        </td>
                                        <td width="5%" align="center">
                                            :
                                        </td>
                                        <td width="50%" align="left">
                                            <asp:TextBox ID="txtPara5" runat="server" TextMode="MultiLine" onkeyDown="return checkTextAreaMaxLength(this,event,'4000');" Height="100px" Width="300px"></asp:TextBox>
                                        </td>
                                    </tr>   
                                    <tr><td height="10px" colspan="3"></td></tr> 
                                    <tr>
                                        <td height="10px" colspan="3" align="center">
                                            <asp:ImageButton ID="imgBtnUpdate" runat="server" 
                                                ImageUrl="~/admin/images/update.png" onclick="imgBtnUpdate_Click" 
                                                ValidationGroup="UpdateWP"/>
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
