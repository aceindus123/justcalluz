<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Admin_SearchNotFound.aspx.cs" Inherits="admin_Admin_SearchNotFound" %>
<%@ Register Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" TagPrefix="cc3"  %>
<%@ Register Src="~/admin/user_control/Admin_Headermenu.ascx" TagName="Headermenu" TagPrefix="cc1" %>
<%@ Register Src="~/admin/user_control/Admin_LeftMenu.ascx" TagName="LeftMenu" TagPrefix="cc4" %>
<%@ Register Src="~/admin/user_control/Admin_AdsHeader.ascx" TagName="AdsHeader" TagPrefix="Ads" %>

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

//          function confirm_delete(uid) {
//              if (confirm("Are you sure you want to delete this Ad?") == true)
//                  document.location = 'Admin_DeleteAd.aspx?cid=' + uid;
//              else
//                  return false;
          //          }
          function confirm_delete() {
              if (confirm("Are you sure you want to delete this Ad?") == true)
                  return true;
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
        <script type="text/javascript">
function poponload()
{
    testwindow = window.open("http://www.justcalluz.com", "mywindow", "location=1,status=1,scrollbars=1,width=500,height=500");
    testwindow.moveTo(400,-2000);
}
</script>
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
                       <%--<Ads:AdsHeader ID="ads1" runat="server" />--%>
                    </td>
                    </tr> 
                    <tr><td height="5px"></td></tr> 
                     <tr>
                            <td colspan="2" align="right">
                                <asp:ScriptManager ID="ScriptManager1" runat="server">
                                </asp:ScriptManager>
                                <a  target="_blank" href=" http://www.justcalluz.com/Corporate_social.aspx" ><img src="images/Click Here For SiteView.png" alt="Site View" /></a>
                               <%-- <asp:ImageButton ID="imgsite" runat="server" OnClientClick="justcalluz:poponload();" ImageUrl="images/Click Here For SiteView.png"/>--%>
                            </td>
                        </tr>  
                    <tr>
                        <td align="center" colspan="3">
                          <span style="font-size:21px; font-weight:bold; color:DarkBlue">Search Not Found
                          <br />The information which is not found in Justcalluz while searching
                          </span> 
                        </td>
                      </tr>                     
                                                                    
                        <tr>
                            <td colspan="2">
                                <asp:Label ID="lblMessage" runat="server" ForeColor="OrangeRed" Font-Bold="true" Font-Size="Medium"></asp:Label>
                                 <div style="float:right; width:50px; padding-right:20px;">
                             <asp:LinkButton ID="lnkBack" runat="server" Text="Back"  OnClick="lnkBack_Click"></asp:LinkButton>                            
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
                        <%-- <tr>
                                                    
                            <td align="center">
                               Select Category : &nbsp; 
                               <asp:DropDownList ID="ddlAdType" runat="server" Width="150px" AutoPostBack="true"
                                    onselectedindexchanged="ddlAdType_SelectedIndexChanged" ValidationGroup="select">
                                </asp:DropDownList>
                                <asp:RequiredFieldValidator ID="rfvCat" runat="server" 
                                    ErrorMessage="Please select Category" ControlToValidate="ddlAdType" 
                                    InitialValue="Select Ad Type" ValidationGroup="select">*</asp:RequiredFieldValidator>
                            </td>
                        </tr> --%>
                        <tr><td height="20px"></td></tr>                                              
                        <%--<tr>
                            <td style="background-color:#F2FAFC">
                                <table width="100%">
                                    <tr>
                                        <td>
                                           <asp:GridView ID="ViewGrid" runat="server" AutoGenerateColumns="false" CellPadding="4"
                                                GridLines="None" ForeColor="#333333" Width="750px" AllowPaging="true" 
                                                PageSize="10" onpageindexchanging="ViewGrid_PageIndexChanging"                        
                                                >
                                                <FooterStyle BackColor="#1C5E55" ForeColor="White" Font-Bold="True" />
                                                
                                                <PagerStyle ForeColor="White" HorizontalAlign="Center" BackColor="#666666" />
                                                
                                                <HeaderStyle BackColor="#1C5E55" Font-Size="10px" Font-Bold="True" ForeColor="White" HorizontalAlign="Left" />
                                                <Columns> 
                                                    <asp:TemplateField>
                                                        <HeaderTemplate>
                                                            <asp:Label ID="lblHAdType" runat="server" Text="Category"></asp:Label>
                                                        </HeaderTemplate>
                                                        <ItemTemplate>                                                                                                                      
                                                            <asp:Label ID="lblAdType" runat="server" Text='<%#Eval("AdType")%>'></asp:Label>                                    
                                                        </ItemTemplate>
                                                    </asp:TemplateField>                                                                           
                                                    <asp:BoundField DataField="AdSubType" HeaderText="SubCategory"></asp:BoundField>
                                                    <asp:BoundField DataField="AdLanguage" HeaderText="Laguage of the Ad"></asp:BoundField>                           
                                                    <asp:BoundField DataField="TitleToDisplay" HeaderText="Title"></asp:BoundField>                            
                                                    <asp:BoundField DataField="City" HeaderText="City"></asp:BoundField>                                                                                   
                                                    <asp:BoundField DataField="PaperName" HeaderText="News Paper Name" ></asp:BoundField> 
                                                    <asp:TemplateField>
                                                        <HeaderTemplate>
                                                            <asp:Label ID="lblHContentName" runat="server" Text="File Name"></asp:Label>
                                                        </HeaderTemplate>
                                                        <ItemTemplate>                                                                                                                      
                                                            <asp:Label ID="lblContentName" runat="server" Text='<%#Eval("Content_Name")%>'></asp:Label>                                    
                                                        </ItemTemplate>
                                                    </asp:TemplateField> 
                                                    <asp:TemplateField>
                                                        <HeaderTemplate>
                                                            <asp:Label ID="lblHContentType" runat="server" Text="File Type"></asp:Label>
                                                        </HeaderTemplate>
                                                        <ItemTemplate>                                                                                                                      
                                                            <asp:Label ID="lblContentType" runat="server" Text='<%#Eval("Content_Type")%>'></asp:Label>                                    
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField>
                                                        <HeaderTemplate>
                                                            <asp:Label ID="lblHCaptureContentName" runat="server" Text="Image Name"></asp:Label>
                                                        </HeaderTemplate>
                                                        <ItemTemplate>                                                                                                                      
                                                            <asp:Label ID="lblCaptureContentName" runat="server" Text='<%#Eval("CaptureContent_Name")%>'></asp:Label>                                    
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField>
                                                        <HeaderTemplate>
                                                            <asp:Label ID="lblHCaptureContentType" runat="server" Text="Image Type"></asp:Label>
                                                        </HeaderTemplate>
                                                        <ItemTemplate>                                                                                                                      
                                                            <asp:Label ID="lblCaptureContentType" runat="server" Text='<%#Eval("CaptureContent_Type")%>'></asp:Label>                                    
                                                        </ItemTemplate>
                                                    </asp:TemplateField>                                                                                   
                                                    <asp:BoundField DataField="PostDate" HeaderText="PostDate" ></asp:BoundField> 
                                                    <asp:TemplateField HeaderText="View/Edit">
                                                        <ItemTemplate>                                                                                                                      
                                                            <a href="Admin_AdsEdit.aspx?adid=<%# DataBinder.Eval(Container, "DataItem.adId")%>">
                                                                <img src='images/edit.gif' width='16' height='16' border='0' />                                                                                                   
                                                            </a>
                                                        </ItemTemplate>
                                                        </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="Delete">                                        
                                                        <ItemTemplate>  
                                                             <img src='images/delete.gif' width='16' height='16' border='0' onclick='javascript:confirm_delete(" +<%# DataBinder.Eval(Container, "DataItem.adId")%>+");' />                                        
                                                        </ItemTemplate>
                                                    </asp:TemplateField>                                                          
                                                </Columns>                        
                                            </asp:GridView> 
                                        </td>
                                    </tr>                                    
                                </table>
                            </td>
                        </tr>--%>
                        <tr>
                            <td>
                                <asp:DataList ID="dlSearchNotFound" DataKeyField="id" runat="server" Width="100%"
                                    style="margin-left: 0px" AlternatingItemStyle-BackColor="#FBEFF8" 
                                    BackColor="#EFEFFB" onitemdatabound="dlSearchNotFound_ItemDataBound">
                                    <HeaderTemplate>                                      
                                    </HeaderTemplate>
                                    <ItemTemplate>
                                      <table width="100%" style="padding-left:10px" valign="top" border="0">
                                        <tr><td style="height:5px"></td></tr>
                                        <tr id="trName" runat="server">
                                            <td colspan="2">
                                               Company Name: &nbsp;<asp:Label ID="lblName" runat="server" Text='<%#Eval("company") %>'></asp:Label>                                         
                                            </td> 
                                             <td align="center" style="width:5%" id="tddel" runat="server">
                                                <asp:LinkButton ID="lnlBtnDelete" runat="server" OnClientClick="return confirm_delete();" OnCommand="lnkDeleteReport" CommandArgument='<%#Eval("id") %>'>
                                                <img src='images/delete.gif' width='16' height='16' border='0'/>
                                                </asp:LinkButton>
                                                
                                            </td>                                                                                       
                                        </tr>
                                        <tr><td style="height:5px"></td></tr>
                                        <tr>
                                            <td colspan="2">
                                                Category :&nbsp;<asp:Label ID="Label1" runat="server" Text='<%#Eval("product") %>'></asp:Label>                                         
                                            </td>                                                                                      
                                        </tr> 
                                        <tr><td style="height:5px"></td></tr>
                                        <tr id="trEmailId" runat="server">
                                            <td style="width:50%">
                                                City:&nbsp;<asp:Label ID="lblEmail" runat="server" Text='<%#Eval("city") %>'></asp:Label>                                         
                                            </td>
                                            <td style="width:50%">
                                                Located in :&nbsp;<asp:Label ID="lblContNo" runat="server" Text='<%#Eval("location") %>'></asp:Label>                                         
                                            </td>
                                        </tr>
                                        <tr><td style="height:5px"></td></tr>
                                        <tr>
                                            <td colspan="2">
                                                Comments :&nbsp;<asp:Label ID="Label2" runat="server" Text='<%#Eval("comments") %>'></asp:Label>                                         
                                            </td>                                                                                      
                                        </tr> 
                                        <tr><td style="height:5px"></td></tr>
                                        <tr>
                                            <td colspan="2">
                                                Posted by :&nbsp;<asp:Label ID="Label3" runat="server" Text='<%#Eval("email") %>'></asp:Label>
                                               ( <asp:Label ID="Label4" runat="server" Text='<%#Eval("name") %>'></asp:Label> )                                       
                                            </td>                                                                                      
                                        </tr>   
                                        <tr><td style="height:5px"></td></tr>
                                        <tr style="background-color:White"><td height="2px" colspan="2"></td></tr>                                                                           
                                        </table>
                                    </ItemTemplate>
                                    <FooterTemplate>                                     
                                    </FooterTemplate>
                                </asp:DataList>
                            </td>
                        </tr>
                        <tr><td style="height:15px"></td></tr>
                          <tr id="trnextpre" runat="server">
          <td align="center">
            <asp:Button ID="cmdPrev" runat="server" Text=" << " OnClick="cmdPrev_Click"></asp:Button>
              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="cmdNext" runat="server" Text=" >> " OnClick="cmdNext_Click"></asp:Button>                              
          </td>
        </tr> 
        <tr><td></td></tr>
        <tr id="trlblMessage" runat="server">
            <td align="right">
                <asp:Label ID="lblCurrentPage" runat="server"></asp:Label>
            </td>
        </tr>
         <tr id="trlblMsg" runat="server">
            <td align="center">
                <asp:Label ID="lblMsg" runat="server"></asp:Label>
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
