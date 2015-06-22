<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Admin_MediaRatings.aspx.cs" Inherits="admin_Admin_MediaRatings" %>
<%@ Register Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" TagPrefix="cc3"  %>
<%@ Register Src="~/admin/user_control/Admin_Headermenu.ascx" TagName="Headermenu" TagPrefix="cc1" %>
<%@ Register Src="~/admin/user_control/Admin_LeftMenu.ascx" TagName="LeftMenu" TagPrefix="cc4" %>
<%@ Register Src="~/admin/user_control/Admin_MediaHeader.ascx" TagName="MediaHeader" TagPrefix="Media" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="AjaxToolkit" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<title>Justcalluz - Admin Control Panel - Media Ratings</title>
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
     .col
     {
        padding-right:10px;
        padding-left:50px;
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
    </style>
    <script language="javascript" type="text/javascript">

        function confirm_delete(uid)
        {
          if (confirm("Are you sure you want to delete this Classified?")==true)
            document.location='Admin_MediaDelete.aspx?cid=' +uid;
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
   <script type="text/javascript" src="js/tab.js"></script>
   
   <%--<script type="text/javascript">
function poponload()
{
    testwindow = window.open("http://www.justcalluz.com/media.aspx", "mywindow", "location=1,status=1,scrollbars=1,width=500,height=500");
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
                <td class="style39" valign="top" style="padding-top:10px">                        
                 <cc4:LeftMenu ID="LeftMenu1" runat="server" />
                </td>
                <td valign="top">&nbsp;</td>
                <td valign="top" style="padding-left:10px; background-color:#F2FAFC">  
                    <table width="750px">
                    <tr>
                    <td>                                        
                      <Media:MediaHeader id="media1" runat="server" />
                    </td>
                    </tr> 
                    <tr><td height="5px"></td></tr> 
                       <tr>
                            <td colspan="2" align="right">
                                <asp:ScriptManager ID="ScriptManager1" runat="server">
                                </asp:ScriptManager>
                                  <a  target="_blank" href="http://www.justcalluz.com/media.aspx" ><img src="images/Click Here For SiteView.png" alt="Site View" /></a>
                                <%--<asp:ImageButton ID="imgsite" runat="server" OnClientClick="justcalluz:poponload();" ImageUrl="images/Click Here For SiteView.png"/>--%>
                            </td>
                        </tr>    
                    <tr>
                        <td align="center" colspan="3">
                          <span style="font-size:21px; font-weight:bold; color:DarkBlue">Media Ratings</span> 
                        </td>
                      </tr>                     
                                                                
                        <tr>
                            <td colspan="2">
                                <asp:Label ID="lblMessage" runat="server" ForeColor="OrangeRed" Font-Bold="true" Font-Size="Medium"></asp:Label>
                                 <div style="float:right; width:50px; padding-right:20px;">
                            <a href="Admin_Media.aspx" style="text-decoration:underline;">Back</a>                             
                             </div>
                            </td>
                        </tr>  
                        <tr>
                            <td>
                                <asp:Label ID="lblrecords" runat="server" ForeColor="OrangeRed" Font-Bold="true" Font-Size="Medium"></asp:Label>                                
                            </td>
                        </tr>    
                        <tr>
                            <td align="center" colspan="2">
                                <br />                               
                            </td>
                        </tr>                        
                        <tr>
                            <td align="center" colspan="2" height="30px">
                                <asp:Label ID="lblHeading" runat="server"></asp:Label>                              
                            </td>
                        </tr>  
                          <tr>
                            <td align="center" colspan="2" height="30px">
                                                              
                            </td>
                        </tr>                   
                        <tr>
                            <td>                                                               
                                 <asp:DataList ID="dlMediaRatings" runat="server" Width="100%">
                                    <ItemTemplate>
                                        <table width="100%" border="0" style=" border:1px #999 solid; background-color:#FEF2F2">
                                          <tr>                                            
                                            <td width="95%" class="bottam_menu">  
                                                have rating of                                           
                                                <%#DataBinder.Eval(Container.DataItem, "star_rating")%> from IP Address :                                           
                                                    <%#DataBinder.Eval(Container.DataItem, "Ip_Address")%> on 
                                                    <%#DataBinder.Eval(Container.DataItem, "Postdate")%>
                                                </font>
                                            </td>
                                            <td align="center">
                                                <asp:ImageButton ID="imgBtnDelete" runat="server" ImageUrl="~/admin/images/delete.gif" OnClientClick="return confirm('Are you sure, to want delete this record ?');" OnCommand="lnkDelete" CommandArgument='<%#Eval("mrId") %>' /></td>
                                          </tr>                                          
                                        </table>
                                </ItemTemplate>
                               </asp:DataList>       
                            </td>
                        </tr>
                        <tr><td align="center">
                            <asp:Label ID="lblNoDataFound" runat="server"></asp:Label></td></tr>                                                                                                   
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
