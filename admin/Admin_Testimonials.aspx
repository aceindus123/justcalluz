<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Admin_Testimonials.aspx.cs" Inherits="admin_Admin_Testimonials" %>
<%@ Register Src="~/admin/user_control/Admin_Headermenu.ascx" TagName="Headermenu" TagPrefix="cc1" %>
<%@ Register Src="~/admin/user_control/Admin_LeftMenu.ascx" TagName="LeftMenu" TagPrefix="cc4" %>
<%@ Register Src="~/admin/user_control/Admin_DataHeader.ascx" TagName="dataHeader" TagPrefix="dataHead" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Justcalluz - Admin Control Panel - Testimonials</title>
    <link href="~/admin/includes/style.css" rel="Stylesheet" type="text/css" />
    <script type="text/javasrcipt" src="http://ajax.googleapis.com/ajax/libs/jquery/1.6.2/jquery.min.js"></script>
    <script src="js/statesopt.js"></script>
    <style type="text/css">
        .style37
        {
            width: 664px;
        }
        .style39
        {
            width: 195px;
        }        
        .style40
        {
            height: 22px;
        }
        </style>
        <script type="text/javascript" src="js/tab.js"></script>
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
    <script language="javascript" type="text/javascript">
window.onunload = function ()

{

 if((window.event.clientX<0) && (window.event.clientY<0)) {
      
       window.open("Admin_Logout.aspx");     
         
      }

}
</script>

</head>
<body onload="new Accordian('basic-accordian',5,'header_highlight');">
    <form id="form1" runat="server">
    <center>
    <div>
    <asp:ScriptManager ID="ScriptManager1" runat="server">
                                </asp:ScriptManager>
         <table cellpadding="0" cellspacing="0">
         <tr>
            <td align="left">
             <cc1:headermenu ID="header" runat="server" />
            </td>
         </tr>
         <tr>
           <td>                  
            <table cellpadding="0" cellspacing="0">
              <tr>
                <td class="style39" valign="top" style="padding-top:4px">                        
                 <cc4:LeftMenu ID="LeftMenu2" runat="server" />
                </td>
                <td valign="top">&nbsp;</td>
                <td valign="top" style="padding-left:10px; background-color:#F2FAFC">  
           <table width="750px">
            
            <tr><td colspan="2" align="right" style="padding-right:8px;padding-top:5px;">      
              <a href="http://www.justcalluz.com/testimonials.aspx" target="_blank">
              <img  src="images/Click Here For SiteView.png" alt="Siteview"/></a>
            </td></tr>
              <tr>
              <td colspan="2" align="center" style=" color:DarkBlue;font-family:Verdana; font-size:16px; font-weight:bold;">
                <asp:Label ID="lblTest" runat="server" Text="Testimonials"></asp:Label>
              </td>
              </tr>
              <tr>
               <td align="right" style="padding-right:8px;padding-top:5px;" colspan="2">    
               <asp:LinkButton ID="lnkBack" runat="server" Text="Back"  OnClick="lnkBack_Click"></asp:LinkButton>   
            </td></tr>
             <tr>
                  
                <td width="100%" valign="top" style="padding-top:5px;padding-right:10px; " colspan="2">
                 <table width="100%">
             <tr><td  style="border:1px dotted black; width:100%; padding-right:5px;" align="left">
                 <asp:DataList ID="dlReview" runat="server" Width="100%" 
                                            onitemdatabound="dlReview_ItemDataBound">
             <ItemTemplate>
            
             <table width="100%" border="0" >
  <tr>
    <td width="12%" rowspan="4" style="padding-bottom:20px;" id="tdimage" runat="server"><asp:Image ID="imgReviewer" runat="server" ImageUrl='<%# Eval("ImageName", "../testimonial_images\\{0}") %>' Width="64" Height="64"/></td>
    <td width="73%"  height="20" id="tddetails" runat="server" align="left"> <asp:Label ID="lblname" style="color:Maroon; font-size:14px; font-family:Verdana; font-weight:bold;" 
          runat="server" Text='<%#Eval("nick_name")%>'></asp:Label>&nbsp;<asp:Label ID="says" runat="server" 
               Text="Says"  style="color:#3366cc; font-size:12px; font-family:Verdana;"></asp:Label>
    <asp:Label ID="lblstatus" runat="server" Visible="false" Text='<%#Eval("Status") %>' ></asp:Label>
    </td>
    <td align="right">
    <asp:LinkButton ID="lnkact" runat="server" Text="Activate" ForeColor="Green" CommandArgument='<%#Eval("Id")%>' OnCommand="activate_command"></asp:LinkButton>
    <asp:LinkButton ID="lnkdeact" runat="server" Text="Deactivate" ForeColor="Red" CommandArgument='<%#Eval("Id")%>' OnCommand="deactivate_command"></asp:LinkButton>
    </td>
      </tr>
 
  <tr>
     <tr>
    <td class="select_menu" height="35" id="tdview" runat="server" align="left">
    <p style="text-align:justify;">
    <asp:Label ID="lblview" runat="server" Text='<%#Eval("Views") %>'></asp:Label></p>
    </td>
    
  </tr>
  <tr>
  <td colspan="2" align="right" id="tddate" runat="server">
  <asp:Label ID="lbldate" runat="server"  ForeColor="Silver" Text='<%#Eval("PostDate") %>'></asp:Label>
  
  </td></tr>
  <tr>
    <td colspan="3" style="width:100%;"><hr /></td>
  </tr>
</table>
            
          </ItemTemplate>
        </asp:DataList>
        </td></tr>
            </table>
              </td>
                                   
            </tr>
             <tr>
          <td>
            <asp:Button ID="cmdPrev" runat="server" Text=" << " OnClick="cmdPrev_Click"></asp:Button>
              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="cmdNext" runat="server" Text=" >> " OnClick="cmdNext_Click"></asp:Button>                              
          </td>
        </tr> 
             <tr>
        <td align="right">
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
    </div>
    </center>
    </form>
</body>
</html>
