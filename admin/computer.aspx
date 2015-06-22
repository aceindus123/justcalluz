<%@ Page Language="C#" AutoEventWireup="true" CodeFile="computer.aspx.cs" Inherits="computer" %>
<%@ Register Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" TagPrefix="cc3"  %>
<%@ Register Src="user control/Header menu.ascx" TagName="Headermenu" TagPrefix="cc1" %>
<%@ Register Src="user control/WebUserControl.ascx" TagName="smenu" TagPrefix="cc4"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Indus Times ---- Admin Control Panel</title>
    <link href="includes/style.css" rel="Stylesheet" type="text/css" />
    <style type="text/css">
        .style37
        {
            width: 664px;
        }
        .style39
        {
            width: 195px;
        }
      </style>
      <script type="text/javascript">
function poponload()
{
    testwindow = window.open("http://www.justcalluz.com/Default.aspx", "mywindow", "location=1,status=1,scrollbars=1,width=500,height=500");
    testwindow.moveTo(400,-2000);
}
</script>
</head>
<body>
      <form id="form1" runat="server">
    <div>
    <asp:ScriptManager ID="script1" runat="server"></asp:ScriptManager>
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
            <td class="style39">
            
            <%--<cc2:SideMenu ID="SideMenu1" runat="server" />--%>
           <cc4:smenu ID="sidemenu" runat="server" />
            </td>
            <td valign="top">&nbsp;</td>
            <td valign="top" style="padding:10px; padding-left:50px" class="style37">
            
              <table cellspacing="5" style="height: 564px; width: 574px; margin-left: 0px">
              
                <tr>
              <td class="adminform">Name</td>
              <td align="center"> &nbsp;&nbsp;:&nbsp;&nbsp;</td>
              <td>
              <asp:TextBox ID="txtname" runat="server" Width="186px"></asp:TextBox>
              <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" ControlToValidate="txtname">
              </asp:RequiredFieldValidator>
              </td>
              </tr>
              
              
              
              <tr>
              <td class="adminform">Category</td>
              <td align="center"> &nbsp;&nbsp;:&nbsp;&nbsp;</td>
              <td>
              <asp:DropDownList ID="ddlcat" runat="server" Width="187px" Height="27px" 
                      style="margin-bottom: 8px">
              <asp:ListItem>Computer</asp:ListItem>
              </asp:DropDownList>
              <asp:RequiredFieldValidator ID="reqf1" runat="server" ErrorMessage="*" ControlToValidate="ddlcat" InitialValue="----Select----">
              </asp:RequiredFieldValidator>
              </td>
              </tr>
              
              <tr>
              <td class="adminform">Area</td>
              <td align="center">:</td>
              <td>
              <asp:TextBox ID="txtarea" runat="server" Width="187px"></asp:TextBox>
              <asp:RequiredFieldValidator ID="reqf2" runat="server" ErrorMessage="*" ControlToValidate="txtarea">
              </asp:RequiredFieldValidator>
              </td>
              </tr>
              
              <tr>
              <td class="adminform">Phone</td>
              <td align="center">:</td>
              <td>
              <asp:TextBox ID="txtph" runat="server" Width="188px"></asp:TextBox>
              <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*" ControlToValidate="txtph">
              </asp:RequiredFieldValidator>
              </td>
              </tr>
              
               <tr>
              <td class="adminform">Mobile</td>
              <td align="center">:</td>
              <td>
              <asp:TextBox ID="txtmobile" runat="server" Width="186px"></asp:TextBox>
              <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="*" ControlToValidate="txtmobile">
              </asp:RequiredFieldValidator>
              </td>
              </tr>
              
             <tr>
              <td class="adminform">Address</td>
              <td align="center">:</td>
              <td>
              <asp:TextBox ID="txtaddr" runat="server" Width="197px" TextMode="MultiLine"></asp:TextBox>
              <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="*" ControlToValidate="txtaddr">
              </asp:RequiredFieldValidator>
              </td>
              </tr>
             
             <tr>
              <td class="adminform">State</td>
              <td align="center">:</td>
              <td>
              <asp:TextBox ID="txtstate" runat="server" Width="186px" ></asp:TextBox>
              <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="*" ControlToValidate="txtstate">
              </asp:RequiredFieldValidator>
              </td>
              </tr>
             
             
             <tr>
              <td class="adminform">Contact Person</td>
              <td align="center">:</td>
              <td>
              <asp:TextBox ID="txtcp" runat="server" Width="187px" ></asp:TextBox>
              <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="*" ControlToValidate="txtcp">
              </asp:RequiredFieldValidator>
              </td>
              </tr>
             
             
             <tr>
              <td class="adminform">Email</td>
              <td align="center">:</td>
              <td>
              <asp:TextBox ID="txtemail" runat="server" Width="189px" ></asp:TextBox>
              <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="*" ControlToValidate="txtemail">
              </asp:RequiredFieldValidator>
              </td>
              </tr>
             
             
             <tr>
              <td class="adminform">operational Timings</td>
              <td align="center">:</td>
              <td>
              <asp:TextBox ID="txtopt" runat="server" Width="189px" ></asp:TextBox>
                 <cc3:CalendarExtender ID="cal1" runat="server" TargetControlID="txtopt"></cc3:CalendarExtender>
              <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ErrorMessage="*" ControlToValidate="txtopt">
              </asp:RequiredFieldValidator>
              </td>
              </tr>
              <tr>
              <td  colspan="3" align="center">
              <asp:Button ID="bt1" runat="server" Text="SUBMIT" onclick="bt1submit_Click"  />
              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
              </td>
              </tr>
              <tr><td></td></tr>
              <tr><td colspan="3" align="center">
        <asp:ImageButton ID="imgsite" runat="server" OnClientClick="justcalluz:poponload();" ImageUrl="images/Click Here For SiteView.png"/>
        </td></tr>
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





