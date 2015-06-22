<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Admin_CSRView.aspx.cs" Inherits="admin_Admin_CSRView" %>
<%@ Register Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" TagPrefix="cc3"  %>
<%@ Register Src="~/admin/user_control/Admin_Headermenu.ascx" TagName="Headermenu" TagPrefix="cc1" %>
<%@ Register Src="~/admin/user_control/Admin_LeftMenu.ascx" TagName="LeftMenu" TagPrefix="cc4" %>
<%@ Register Src="~/admin/user_control/Admin_CSRHead.ascx" TagName="CSRHead" TagPrefix="CSR" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="AjaxToolkit" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<title>Justcalluz - Admin Control Panel - Ads Home</title>
    <script type="text/javascript" src="js/jquery-1.2.6.min.js"></script>
   
    <link href="includes/style.css" rel="Stylesheet" type="text/css" />
    <script type="text/javasrcipt" src="http://ajax.googleapis.com/ajax/libs/jquery/1.6.2/jquery.min.js"></script>
     
    <script src="js/statesopt.js" type="text/javascript"></script>
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
        </style>
    <style type="text/css">
        .style39
        {
            width: 100px;
        }  
        .stylealign
        {
           align:center
        }        
        </style>       	
       <script type="text/javascript" src="js/tab.js"></script>
      <script type="text/javascript" src="js/home-common.js"></script>
       <%-- <script type="text/javascript">
function poponload()
{
    testwindow = window.open("http://www.justcalluz.com/Corporate_social.aspx", "mywindow", "location=1,status=1,scrollbars=1,width=500,height=500");
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
             <cc1:headermenu ID="header" runat="server"/>
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
                       <CSR:CSRHead ID="CSRHead1" runat="server" />
                    </td>
                    </tr> 
                    <tr><td height="5px"></td></tr>  
                    <tr>
                            <td colspan="3" align="right">
                                <asp:ScriptManager ID="ScriptManager1" runat="server">
                                </asp:ScriptManager>
                                 <a  target="_blank" href="http://www.justcalluz.com/Corporate_social.aspx" ><img src="images/Click Here For SiteView.png" alt="Site View" /></a>
                                <%--<asp:ImageButton ID="imgsite" runat="server" OnClientClick="justcalluz:poponload();" ImageUrl="images/Click Here For SiteView.png"/>--%>
                           </td>
                        </tr>     
                    <tr>
                        <td align="center" colspan="3">
                          <span style="font-size:21px; font-weight:bold; color:DarkBlue">  Social Welfare Information - Detailed View</span> 
                        </td>
                      </tr>                     
                                                                 
                        <tr>
                            <td colspan="3">
                                <asp:Label ID="lblMessage" runat="server" ForeColor="OrangeRed" Font-Bold="true" Font-Size="Medium"></asp:Label>
                                <div style="float:right; width:50px; padding-right:20px;">
                            <a href="Admin_CorporateSocial.aspx" style="text-decoration:underline;">Back</a>                             
                             </div>
                            </td>
                        </tr>  
                        <tr>
                            <td colspan="3">
                                <asp:Label ID="lblrecords" runat="server" ForeColor="OrangeRed" Font-Bold="true" Font-Size="Medium"></asp:Label>                                
                            </td>
                        </tr>    
                        <tr>
                            <td align="center" colspan="3">
                                <br />                               
                            </td>
                        </tr>                          
                        <tr><td height="20px"></td></tr>  
                        <tr>
                            <td>
                            <%--<asp:LinkButton ID="lnkbtnPrevious" runat="server" OnClick="lnkbtnPrevious_Click1" 
                    Font-Bold="True" Font-Size="Medium" Font-Underline="False" ForeColor="#FF6600">Previous</asp:LinkButton>--%>
                    </td>
                            <td style="padding-left:50px" >
                                <div id="main-container">
        <div id="container">
            <div id="myspan">
                <div id="example1_wrap" >
                    <ul id="example1">
                        <asp:DataGrid ID="dlPhotos" runat="server" DataKeyField="Id" AutoGenerateColumns="False"
                            ShowHeader="true" CellPadding="5">
                            <Columns>
                                <asp:TemplateColumn HeaderText="Photo">
                                    <ItemTemplate>
                                        <li><a href='<%#GetDetail(DataBinder.Eval(Container.DataItem,"ImgName"))%>' rel=Stylesheet
                                            title='<%#title(DataBinder.Eval(Container.DataItem,"ImgName"))%>' target="_blank">
                                            <img width="225" height="175" border="0" src='<%#GetDetail(DataBinder.Eval(Container.DataItem,"ImgName"))%>' />
                                        </a></li>
                                    </ItemTemplate>
                                </asp:TemplateColumn>
                            </Columns>
                        </asp:DataGrid>                                
                                </ul>
                </div>
            </div>
        </div>
    </div>
                            </td>
                            <td>                           
                            </td>
                        </tr>
                        <tr><td height="20px"></td></tr>                                               
                        <tr>
                            <td style="background-color:#F2FAFC" colspan="3">
                                <table width="100%">
                                    <tr>
                                        <td>
                                            
                                        </td>
                                    </tr>                  <asp:DataList ID="dlCSR" runat="server" Width="100%" EditItemStyle-HorizontalAlign="Justify">
                                                <ItemTemplate>
                                                    <table width="100%" border="0px">
                                                            <tr>
                                                            <td align="left" style="padding-left:10px" valign="middle">
                                                            <p style="text-align:justify;color:DarkSlateGray;"><%#DataBinder.Eval(Container.DataItem,"Introduction") %></p>
                                                            </td>                                                                                                                       
                                                        </tr>
                                                        <tr><td height="5px"></td></tr>
                                                        <tr>
                                                            <td align="left" style="padding-left:10px" valign="middle">
                                                           <span style="color:Blue"><strong><%#DataBinder.Eval(Container.DataItem,"Title") %></strong></span>
                                                            </td>                                                                                                                       
                                                        </tr>
                                                        <tr><td height="5px"></td></tr>
                                                        <tr>
                                                            <td align="left" style="padding-left:10px" valign="top">
                                                              <p style="text-align:justify;color:DarkSlateGray;"><%#DataBinder.Eval(Container.DataItem,"para1") %></p>
                                                            </td>                                                                                                                       
                                                        </tr>
                                                        <tr><td height="5px" colspan="2"></td></tr>
                                                         <tr>
                                                            <td align="left" style="padding-left:10px" valign="top">
                                                              <p style="text-align:justify;color:DarkSlateGray;">  <%#DataBinder.Eval(Container.DataItem,"para2") %></p>
                                                            </td>                                                                                                                       
                                                        </tr>
                                                        <tr><td height="5px"></td></tr>
                                                         <tr>
                                                            <td align="left" style="padding-left:10px" valign="top">
                                                              <p style="text-align:justify;color:DarkSlateGray;">  <%#DataBinder.Eval(Container.DataItem,"para3") %></p>
                                                            </td>                                                                                                                       
                                                        </tr>
                                                        <tr><td height="5px"></td></tr>
                                                         <tr>
                                                            <td align="left" style="padding-left:10px" valign="top">
                                                               <p style="text-align:justify;color:DarkSlateGray;">  <%#DataBinder.Eval(Container.DataItem,"para4") %></p>
                                                            </td>                                                                                                                       
                                                        </tr>
                                                        <tr><td height="5px"></td></tr>
                                                         <tr>
                                                            <td align="left" style="padding-left:10px" valign="top">
                                                              <p style="text-align:justify;color:DarkSlateGray;">  <%#DataBinder.Eval(Container.DataItem,"para5") %></p>
                                                            </td>                                                                                                                       
                                                        </tr>
                                                        <tr><td height="5px"></td></tr>
                                                        
                                                    </table>
                                                </ItemTemplate>
                                            </asp:DataList>                  
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
