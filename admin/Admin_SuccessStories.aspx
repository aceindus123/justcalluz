<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Admin_SuccessStories.aspx.cs" Inherits="admin_Admin_SuccessStories" %>
<%@ Register Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" TagPrefix="cc3"  %>
<%@ Register Src="~/admin/user_control/Admin_Headermenu.ascx" TagName="Headermenu" TagPrefix="cc1" %>
<%@ Register Src="~/admin/user_control/Admin_LeftMenu.ascx" TagName="LeftMenu" TagPrefix="cc4" %>
<%@ Register Src="~/admin/user_control/Admin_SSHeader.ascx" TagName="SSHeader" TagPrefix="SS" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="AjaxToolkit" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<title>Justcalluz - Admin Control Panel - Ads Home</title>
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
              if (confirm("Are you sure you want to delete this Success story?") == true)
                  document.location = 'Admin_SSDelete.aspx?cid=' + uid;
              else
                  return false;
          }
          function alertdelete() {
              alert("Selected Success story has been deleted Successfully");
          }
          function alertaccept() {
              alert("Selected Success story has been Accepted");
          }
    </script>	
        <script type="text/javascript" src="js/tab.js"></script>
       <%-- <script type="text/javascript">
function poponload()
{
    testwindow = window.open("http://www.justcalluz.com/success_stories.aspx", "mywindow", "location=1,status=1,scrollbars=1,width=500,height=500");
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
                    <td colspan="2">                      
                       <SS:SSHeader id="SSHead1" runat="server" />
                    </td>
                    </tr> 
                    <tr><td height="5px"></td></tr> 
                     <tr>
                            <td colspan="2" align="right">
                                <asp:ScriptManager ID="ScriptManager1" runat="server">
                                </asp:ScriptManager>
                                 <a  target="_blank" href="http://www.justcalluz.com/success_stories.aspx" ><img src="images/Click Here For SiteView.png" alt="Site View" /></a>
                               <%-- <asp:ImageButton ID="imgsite" runat="server" OnClientClick="justcalluz:poponload();" ImageUrl="images/Click Here For SiteView.png"/>--%>
                            </td>
                        </tr>    
                    <tr>
                        <td align="center" colspan="3">
                          <span style="font-size:21px; font-weight:bold; color:DarkBlue">Success Stories Home</span> 
                        </td>
                      </tr>                     
                                                             
                        <tr>
                            <td >
                                <asp:Label ID="lblMessage" runat="server" ForeColor="OrangeRed" Font-Bold="true" Font-Size="Medium"></asp:Label>
                            </td>
                            <td align="right" style="padding-right:20px;">
                             <asp:LinkButton ID="lnkBack" runat="server" Text="Back"  OnClick="lnkBack_Click"></asp:LinkButton>
                             <a id="anhBack" runat="server" href="Admin_SuccessStories.aspx?Type=SSText&s=Andhra Pradesh&c=Hyderabad" style="text-decoration:underline;">Back</a>    
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
                            <td align="right" width="40%">
                               Select State :
                            </td>
                            <td align="left" width="60%">
                                <asp:DropDownList ID="ddlState" runat="server" 
                                    onselectedindexchanged="ddlState_SelectedIndexChanged" AutoPostBack="true" Width="200px">
                                </asp:DropDownList>
                                <asp:RequiredFieldValidator ID="rfvddlState" runat="server" 
                                    ErrorMessage="Please Select State" ControlToValidate="ddlState" 
                                    InitialValue="Select State" ValidationGroup="PostSS"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>                                                    
                            <td align="right" width="40%">
                               Select City : 
                                </td>
                            <td align="left" width="60%">
                               <asp:DropDownList ID="ddlCity" runat="server" Width="200px" AutoPostBack="true"
                                     ValidationGroup="select" 
                                    onselectedindexchanged="ddlCity_SelectedIndexChanged">
                                </asp:DropDownList>
                                <asp:RequiredFieldValidator ID="rfvCity" runat="server" 
                                    ErrorMessage="Please select City" ControlToValidate="ddlCity" 
                                    InitialValue="Select City" ValidationGroup="select"></asp:RequiredFieldValidator>
                            </td>
                        </tr> 
                        <tr><td height="10px" colspan="2"></td></tr>
                        <tr>
                            <td colspan="3" height="0px" style="background-color:Gray;">                                                                                               
                            </td>
                        </tr> 
                        <tr><td height="10px" colspan="2"></td></tr>                                               
                        <tr>
                            <td style="background-color:#F2FAFC" colspan="2">
                                <asp:DataList ID="dlSS" runat="server" Width="100%" 
                                    onitemcommand="dlSS_ItemCommand" onitemdatabound="dlSS_ItemDataBound">
                                    <ItemTemplate>
                                       <table width="100%" border="0" style="padding-top:20px">
                                        <tr>
                                          <td width="29%" height="80" rowspan="5" align="left" valign="top">
                                          <asp:Image ID="ImgLogo" runat="server" Width="200px" Height="149px" ImageUrl='<%# Eval("PhotoName", "~/SS_Photos\\{0}") %>' />
                                          </td>
                                          <td width="71%" height="25">Customer Since <%#DataBinder.Eval(Container.DataItem,"SMonth") %> <%#DataBinder.Eval(Container.DataItem,"SYear") %></td>
                                          <td id="tdedit" runat="server"> 
                                            <a href="Admin_SSEdit.aspx?ssid=<%# DataBinder.Eval(Container, "DataItem.ssId")%>">
                                                <img src='images/edit.gif' width='16' height='16' border='0' />                                                                                                   
                                            </a>
                                          </td>
                                        </tr>
                                        <tr>
                                          <td height="25">Investment with Justdial:</td>
                                          <td id="tddel" runat="server"><asp:Label ID="lblLength" runat="server" Text='<%#Eval("textlengh") %>' Visible="false"></asp:Label>
                                            <img src='images/delete.gif' width='16' height='16' border='0' onclick='javascript:confirm_delete(" +<%# DataBinder.Eval(Container, "DataItem.ssId")%>+");' />                                        
                                          </td>
                                        </tr>
                                        <tr>
                                          <td height="25" colspan="2">First Year: <strong>Rs. <%#DataBinder.Eval(Container.DataItem,"FirstYear") %>P. A.</strong></td>
                                        </tr>
                                        <tr>
                                          <td height="25" colspan="2">Current Year: <strong>Rs. <%#DataBinder.Eval(Container.DataItem,"CurrentYear") %>P. A.</strong></td>
                                        </tr>
                                        <tr>
                                          <td height="28" colspan="2" rowspan="2" valign="top">
                                              <img src="images/leftquote.gif" /> <asp:Label ID="lblpspeakmin" runat="server" Text='<%#Eval("pspeak") %>'></asp:Label>                                                                                    
                                              <asp:LinkButton ID="lnkBtnMore" runat="server" CommandName="More" Visible="false">More</asp:LinkButton> 
                                              <asp:Label ID="lblpspeakMore" runat="server" Text='<%#Eval("PartnerSpeak") %>' Visible="false"></asp:Label> <img src="images/rightquote.gif" />
                                          </td>
                                        </tr>
                                        <tr> 
                                          <td width="29%" align="center"><%#DataBinder.Eval(Container.DataItem,"PName") %>, <%#DataBinder.Eval(Container.DataItem,"PDesg") %><br />
                                            <a href="Admin_Data_Details.aspx?did=<%# DataBinder.Eval(Container, "DataItem.dataid")%>" style="text-decoration:none"><%#DataBinder.Eval(Container.DataItem,"CompanyName") %>, <%#DataBinder.Eval(Container.DataItem,"City") %></a><br />
                                            <strong><%#DataBinder.Eval(Container.DataItem,"Category") %></strong></td>                                      
                                        </tr>
                                         <tr>
                                            <td colspan="3" height="10px">                                                                                               
                                            </td>
                                        </tr> 
                                        <tr>
                                            <td colspan="3" height="0px" style="background-color:Gray">                                                                                               
                                            </td>
                                        </tr>  
                                         <tr>
                                            <td colspan="3" height="10px">                                                                                               
                                            </td>
                                        </tr>                                  
                                      </table>                                      
                                    </ItemTemplate>
                                </asp:DataList>                                                                
                            </td>
                        </tr>
                        <tr id="trwplayVideos" runat="server">
                            <td style="background-color:#F2FAFC"  colspan="2">
                                <asp:DataList ID="dlSSVideos" runat="server" Width="100%">
                                    <ItemTemplate>
                                       <table width="100%" border="0" style="padding-top:20px">
                                        <tr>
                                          <td width="30%" height="80"  align="left" valign="top">
                                              <asp:ImageButton ID="ImgThumbnail" runat="server" Width="100px" Height="100px" ImageUrl='<%# Eval("PhotoName", "~/SS_Photos\\{0}") %>' CommandArgument='<%#Eval("VideoName") %>'  />                                          
                                          </td>
                                          <td width="60%" align="left" style="padding-left:10px" valign="top">
                                            <a href="Admin_Data_Details.aspx?did=<%# DataBinder.Eval(Container, "DataItem.dataid")%>" style="text-decoration:none"><%#DataBinder.Eval(Container.DataItem,"CompanyName") %></a><br />
                                            <%#DataBinder.Eval(Container.DataItem,"PName") %> (<%#DataBinder.Eval(Container.DataItem,"PDesg") %>)<br />
                                            <%#DataBinder.Eval(Container.DataItem,"City") %>
                                          </td> 
                                          <td align="right" width="7%" valign="top"> 
                                            <a href="Admin_SSVideoEdit.aspx?ssid=<%# DataBinder.Eval(Container, "DataItem.ssId")%>">
                                                <img src='images/edit.gif' width='16' height='16' border='0' />                                                                                                   
                                            </a><br />
                                            <img src='images/delete.gif' width='16' height='16' border='0' onclick='javascript:confirm_delete(" +<%# DataBinder.Eval(Container, "DataItem.ssId")%>+");' />                                        
                                          </td>
                                      <%--  </tr>                                                                                                                      
                                         <tr>--%>
                                            <td height="10px" style="width:380px"> 
                                                 <embed id='embed1s' runat="server" name='mediaPlayer' type='application/x-mplayer2' pluginspage='http://microsoft.com/windows/mediaplayer/en/download/'  
                                                 displaysize='4' autosize='-1' bgcolor='darkblue' src='<%#"http://justcalluz.com/ss_videos/" + Eval("VideoName") %>'
                                                  showcontrols='true' showtracker='-1' showdisplay='0' showstatusbar='-1' videoborder3d='-1' width='350' height='300'  designtimesp='5311' loop='true'>
                                                  </embed>
                                                 
                                            </td>
                                        </tr> 
                                        <tr>
                                            <td colspan="4" height="0px" style="background-color:Gray">                                                                                               
                                            </td>
                                        </tr>  
                                         <tr>
                                            <td colspan="4" height="10px">                                                                                               
                                            </td>
                                        </tr>                                  
                                      </table>                                      
                                    </ItemTemplate>
                                </asp:DataList>                                                                
                            </td>
                          
                        </tr> 
                         <tr id="trnextpre" runat="server">
          <td align="center" colspan="2">
            <asp:Button ID="cmdPrev" runat="server" Text=" << " OnClick="cmdPrev_Click"></asp:Button>
              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="cmdNext" runat="server" Text=" >> " OnClick="cmdNext_Click"></asp:Button>                              
          </td>
        </tr> 
        <tr><td colspan="2"></td></tr>
                          <tr id="trlblMessage" runat="server">
            <td align="right" colspan="2">
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
