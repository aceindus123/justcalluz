<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Admin_AdsReviews.aspx.cs" Inherits="admin_Admin_AdsReviews" %>
<%@ Register Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" TagPrefix="cc3"  %>
<%@ Register Src="~/admin/user_control/Admin_Headermenu.ascx" TagName="Headermenu" TagPrefix="cc1" %>
<%@ Register Src="~/admin/user_control/Admin_LeftMenu.ascx" TagName="LeftMenu" TagPrefix="cc4" %>
<%@ Register Src="~/admin/user_control/Admin_AdsHeader.ascx" TagName="AdsHeader" TagPrefix="Ads" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<title>Justcalluz - Admin Control Panel - Ads - View Comments</title>
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

          function confirm_delete() {
              if (confirm("Are you sure you want to delete this Ad?") == true)
                  document.location = 'Admin_DeleteAd.aspx
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
        <script type="text/javascript" src="js/tab.js"></script>
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
                    <td colspan="2">                      
                       <Ads:AdsHeader ID="ads1" runat="server" />
                    </td>
                    </tr> 
                    <tr><td height="5px"  colspan="2"></td></tr>  
                    <tr>
                        <td align="right" width="60%">
                          <span style="font-size:21px; font-weight:bold; color:DarkBlue">Ads - Comments</span> 
                        </td>
                        <td align="right" style="padding-right:10px;"  width="40%">
                        <a href="http://www.justcalluz.com/tv_ads.aspx" target="_blank"> 
                           <img src="images/Click Here For SiteView.png"/>
                        </a></td>                        
                      </tr>                     
                        <tr>
                            <td colspan="2">
                                <asp:ScriptManager ID="ScriptManager1" runat="server">
                                </asp:ScriptManager>
                            </td>
                        </tr>                                              
                        <tr>
                            <td colspan="2">
                                <asp:Label ID="lblMessage" runat="server" ForeColor="OrangeRed" Font-Bold="true" Font-Size="Medium"></asp:Label>
                            </td>
                        </tr>  
                        <tr>
                            <td  colspan="2">
                                <asp:Label ID="lblrecords" runat="server" ForeColor="OrangeRed" Font-Bold="true" Font-Size="Medium"></asp:Label>                                
                            </td>
                        </tr>    
                        <%--<tr>
                            <td align="center" colspan="2">
                                <br />                               
                            </td>
                        </tr>     --%>                     
                        <tr><td height="20px"  colspan="2" align="right" style="padding-right:8px;">
                                  <asp:LinkButton ID="lnkBack" runat="server" Text="Back" PostBackUrl="Admin_Ads.aspx"></asp:LinkButton>
                        </td></tr>                                              
                        <tr>
                            <td  colspan="2">
                               <asp:DataList ID="dlreviews" runat="server" Width="100%" 
                                    style="margin-bottom: 0px" >
                                    <ItemTemplate>
                                        <table width="100%" border="0" style=" border:1px #999 solid; background-color:#FEF2F2">
                                          <tr>
                                            <td width="4%" bgcolor="#EBEBEB">
                                            <img src="images/user-comment-icon1.png" width="28" height="28" />
                                            </td>
                                            <td width="71%" class="bottam_menu">
                                                <%#DataBinder.Eval(Container.DataItem, "Name")%>
                                            </td>
                                            <td width="25%" class="bottam_menu">
                                                <font color="#002D59">
                                                    <%#DataBinder.Eval(Container.DataItem, "postdate")%>
                                                </font>
                                            </td>
                                            <td>
                                                <asp:ImageButton ID="imgBtnDelete" runat="server" ImageUrl="~/admin/images/delete.gif" OnClientClick="javascript:return confirm('Are you sure!You want to delete the record permanently?');" OnCommand="lnkDelete" CommandArgument='<%#Eval("id") %>' /></td>
                                          </tr>
                                          <tr>
                                            <td colspan="4" bgcolor="#E8FDFA"class="bottam_menu" height="40" style="padding-left:10px;">
                                                <font color="#002D59"> 
                                                    <%#DataBinder.Eval(Container.DataItem, "Comments")%>
                                                </font>
                                            </td>
                                          </tr>
                                        </table>
                                </ItemTemplate>
                               </asp:DataList> 
                            </td>
                        </tr> 
                        <tr>
                            <td width="10%" align="center">
                                <asp:LinkButton ID="lnkbtnPrevious" runat="server" OnClick="lnkbtnPrevious_Click1" 
                                    Font-Bold="True" Font-Size="Medium" Font-Underline="False" ForeColor="#FF6600" Visible="false">Previous</asp:LinkButton>
                            </td>
                            <td width="10%" align="center">
                                <asp:LinkButton ID="lnkbtnNext" runat="server" OnClick="lnkbtnNext_Click1" Font-Bold="True" Font-Size="Medium" Font-Underline="False" ForeColor="#FF6600" Visible="false">Next</asp:LinkButton>
                            </td>
                        </tr>
                        <tr id="trlblMessage" runat="server">
                            <td align="right" colspan="2">
                                <asp:Label ID="lblCurrentPage" runat="server" Visible="false"></asp:Label>
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
