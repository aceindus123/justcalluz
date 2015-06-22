<%@ Page Language="C#" AutoEventWireup="true" CodeFile="site_exceptions.aspx.cs" Inherits="admin_site_exceptions" %>
<%@ Register Src="~/admin/user_control/Admin_LeftMenu.ascx" TagName="LeftMenu" TagPrefix="cc4" %>
<%@ Register Src="~/admin/user_control/Admin_Headermenu.ascx" TagName="Headermenu" TagPrefix="cc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Admin-Exception</title>
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
              <a href="http://www.justcalluz.com/Default.aspx" target="_blank">
              <img  src="images/Click Here For SiteView.png" alt="Siteview"/></a>
            </td></tr>
              <tr><td colspan="2" align="right" style="padding-right:8px;padding-top:5px;">    
               <asp:LinkButton ID="lnkBack" runat="server" Text="Back"  OnClick="lnkBack_Click"></asp:LinkButton>   
            </td></tr>
              <tr>
                 <td width="91%" valign="top" style="border:1px dotted black;">
                <b style="color:Red;font-weight:bold; font-family:Verdana;font-size:16px;vertical-align:top;text-align:center; ">Details of Exceptions occured in the site </b><br /><br />
                    <asp:DataList ID="dlReview" runat="server" Width="100%" 
                        onitemdatabound="dlReview_ItemDataBound">
                    <ItemTemplate>
                   <table width="100%" border="0">
                  <tr>
   
                    <td width="91%" class="select_menu" height="20" id="tddetails" runat="server" align="center" style="color:Maroon;font-size:14px;"> 
                     <b style="font-size:12px; font-family:Verdana">Status :</b>&nbsp;&nbsp; <asp:Label ID="lblstatus" runat="server" Text='<%#Eval("Excep_status") %>' ></asp:Label>
                    </td>
                    <td>
                    <asp:LinkButton ID="lnkact" runat="server" Text="Solved" ForeColor="Green" CommandArgument='<%#Eval("Excep_id")%>' OnCommand="activate_command"></asp:LinkButton>
                    <asp:LinkButton ID="lnkdeact" runat="server" Text="Unsolved" ForeColor="Red" CommandArgument='<%#Eval("Excep_id")%>' OnCommand="deactivate_command"></asp:LinkButton>
                    </td>
                      </tr>
 
                  <tr>
                     <tr>
                    <td class="select_menu" height="35" id="tdview" runat="server" align="left">
                     <asp:Label ID="lblview" runat="server" Text='<%#Eval("Excep_desc") %>'></asp:Label></td>
    
                  </tr>
                  <tr><td align="left">
                  Exception in :&nbsp;&nbsp;<asp:Label ID="lblpg" runat="server" Text='<%#Eval("Excep_page")%>'></asp:Label></br>
                  Line Number :&nbsp;&nbsp;<asp:Label ID="lblline" runat="server" Text='<%#Eval("Line_No")%>'></asp:Label>
                  </td></tr>
                  <tr>
                  <td colspan="2" align="right" id="tddate" runat="server">
                  <asp:Label ID="lbldate" runat="server"  ForeColor="Silver" Text='<%#Eval("Excep_PostDate") %>'></asp:Label>
  
                  </td></tr>
                  <tr>
                    <td colspan="2"><hr /></td>
                  </tr>
                </table>
                               </ItemTemplate>
                              </asp:DataList>
                                    </td>
                                   
            </tr>
            <tr>
          <td align="center">
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
      </td></tr></table>
    </div>
    </center>
    </form>
</body>
</html>
