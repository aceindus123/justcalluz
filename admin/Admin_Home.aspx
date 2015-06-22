<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Admin_Home.aspx.cs" Inherits="admin_Admin_Home" %>
<%@ Register Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" TagPrefix="cc3"  %>
<%@ Register Src="~/admin/user_control/Admin_Headermenu.ascx" TagName="Headermenu" TagPrefix="cc1" %>
<%@ Register Src="~/admin/user_control/Admin_LeftMenu.ascx" TagName="LeftMenu" TagPrefix="cc4" %>
<%@ Register Src="~/admin/user_control/Admin_DataHeader.ascx" TagName="dataHeader" TagPrefix="dataHead" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title>Justcalluz - Admin Control Panel - Home</title>
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
    <%--<script language="javascript" type="text/javascript">
    function HandleOnClose(e)

{
if (event.clientY < 0)

{
if((document.getElementById('ctl00_c1_signIn')!=null) || (document.getElementById("ctl00$c1$Login1$LoginButton")!=null))

{ sendXMLHTTRequest(100);}

else

{sendXMLHTTRequest(101); }

}

}

//The following is the javascript code, the function catches the ID(i.e whether the user is logged in or not) here I am using XMLHTTPREQUEST so that I can make the session  abandon, without postback(manual AJAX), so here no need to use any popup window to close the sessions.
function sendXMLHTTRequest(ID)

{
/*100-window close without user logged In

101- browser close after the user is logged In 

*/
if(ID >100)

{

//alert('ID='+ ID);
var objXMLHttp = new ActiveXObject("Microsoft.XMLHTTP");

objXMLHttp.open("POST", "../Common/SessionTracker.aspx?ParamID=" + ID , false);
// in sessiontracker.aspx I am killing the sessions

objXMLHttp.send(new ActiveXObject("Microsoft.XmlDOM")); // Passing the XMLDom Object is required

}

}

//The following is the javascript code, when the user tries to close the browser using alt-f4
document.onkeydown = function()

{
if(window.event.keyCode == 115 && event.altKey == true)

{
if((document.getElementById('ctl00_c1_signIn')!=null) || (document.getElementById("ctl00$c1$Login1$LoginButton")!=null))

{sendXMLHTTRequest(100);}

else

{sendXMLHTTRequest(101);}

}

} 
</script>--%>
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
       <table cellpadding="0" cellspacing="0">
         <tr>
            <td>
             <cc1:headermenu ID="header" runat="server" />
            </td>
         </tr>
         <tr>
           <td>                  
            <table cellpadding="0" cellspacing="0" width="770px">
              <tr>
                <td class="style39" valign="top" style="padding-top:4px">                        
                 <cc4:LeftMenu ID="LeftMenu1" runat="server" />
                </td>
                <td valign="top">&nbsp;</td>
                <td valign="top" style="padding-left:10px; background-color:#F2FAFC">  
                    <table width="750px">
                        <tr>
                            <td colspan="2">
                            <dataHead:dataHeader ID="datahead1" runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:ScriptManager ID="ScriptManager1" runat="server">
                                </asp:ScriptManager>
                            </td>
                        </tr>
                        <tr>
                            <td align="center" colspan="2">
                                <asp:Label ID="lblAdminHome" runat="server" Text="ADMIN HOME" Font-Size="Large"></asp:Label>                           
                            </td>
                        </tr>                        
                        <tr>
                            <td align="left" style="width:50%;">
                                <asp:Label ID="lblMessage" runat="server"></asp:Label>                                
                            </td>
                             <td align="right" style="padding-right:10px; font-size:14px;">
                                <%--<a href="Admin-MainPage.aspx" runat="server"><asp:Label ID="lblBack" runat="server" Text="Back"></asp:Label></a>--%>  
                                <asp:LinkButton ID="lnkBack" runat="server" Text="Back"  OnClick="lnkBack_Click"></asp:LinkButton>                            
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <asp:Label ID="lblerror" runat="server" CssClass="ErrMsg"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td align="center" colspan="2">
                                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                <ContentTemplate>
                                
                                <table width="500px">
                                    <tr>
                                      <td class="adminform" align="right">Module</td>
                                      <td align="center"> &nbsp;&nbsp;:&nbsp;&nbsp;</td>
                                      <td align="left">                               
                                          <asp:DropDownList ID="ddlModule" runat="server" Width="186px" 
                                              onselectedindexchanged="ddlModule_SelectedIndexChanged" AutoPostBack="true" >   
                                              <asp:ListItem Value="Select Module">Select Module</asp:ListItem>                                           
                                          </asp:DropDownList>
                                          
                                          <asp:RequiredFieldValidator ID="rfvModule" runat="server" 
                                              ControlToValidate="ddlModule" ErrorMessage="Please select Module" 
                                              InitialValue="Select Module" ValidationGroup="PostData">*</asp:RequiredFieldValidator>
                                           <cc3:ValidatorCalloutExtender ID="valcaloutextn" runat="server" Enabled="true" TargetControlID="rfvModule">
                                                          </cc3:ValidatorCalloutExtender>
                                      </td>
                                    </tr>
                                      
                                    <tr>
                                      <td class="adminform" align="right">Category</td>
                                      <td align="center"> &nbsp;&nbsp;:&nbsp;&nbsp;</td>
                                      <td align="left">                               
                                          <asp:DropDownList ID="ddlCategory" runat="server" Width="186px" 
                                              onselectedindexchanged="ddlCategory_SelectedIndexChanged" AutoPostBack="true">
                                          </asp:DropDownList>
                                          
                                          <asp:RequiredFieldValidator ID="rfvCat" runat="server" 
                                              ControlToValidate="ddlCategory" ErrorMessage="Please select Category" 
                                              InitialValue="Select Category" ValidationGroup="PostData">*</asp:RequiredFieldValidator>
                                           <cc3:ValidatorCalloutExtender ID="ValidatorCalloutExtender1" runat="server" Enabled="true" TargetControlID="rfvCat">
                                                          </cc3:ValidatorCalloutExtender>
                                      </td>
                                    </tr>
                                      
                                    <tr id="trSubCat" runat="server">
                                      <td class="adminform" align="right">Sub Category</td>
                                      <td align="center"> &nbsp;&nbsp;:&nbsp;&nbsp;</td>
                                      <td align="left">                               
                                          <asp:DropDownList ID="ddlSubCat" runat="server" Width="186px">
                                          </asp:DropDownList>                                          
                                          <asp:RequiredFieldValidator ID="rfvsubcat" runat="server" 
                                              ControlToValidate="ddlSubCat" ErrorMessage="Please select Sub Category" 
                                              InitialValue="Select Sub Category" ValidationGroup="PostData">*</asp:RequiredFieldValidator>
                                           <cc3:ValidatorCalloutExtender ID="ValidatorCalloutExtender2" runat="server" Enabled="true" TargetControlID="rfvsubcat">
                                                          </cc3:ValidatorCalloutExtender>
                                      </td>
                                    </tr>  
                                    <tr>
                                      <td class="adminform" align="right">State</td>
                                      <td align="center"> &nbsp;&nbsp;:&nbsp;&nbsp;</td>
                                      <td align="left">                               
                                          <asp:DropDownList ID="ddlState" runat="server" Width="186px" 
                                              onselectedindexchanged="ddlState_SelectedIndexChanged" AutoPostBack="true">
                                          </asp:DropDownList>                                          
                                          <asp:RequiredFieldValidator ID="rfvState" runat="server" 
                                              ControlToValidate="ddlState" ErrorMessage="Please select State" 
                                              InitialValue="Select State" ValidationGroup="PostData">*</asp:RequiredFieldValidator>
                                           <cc3:ValidatorCalloutExtender ID="valoalextnState" runat="server" Enabled="true" TargetControlID="rfvState">
                                                          </cc3:ValidatorCalloutExtender>
                                      </td>
                                    </tr>  
                                    <tr>
                                      <td class="adminform" align="right">City</td>
                                      <td align="center"> &nbsp;&nbsp;:&nbsp;&nbsp;</td>
                                      <td align="left">                               
                                          <asp:DropDownList ID="ddlCity" runat="server" Width="186px">
                                          </asp:DropDownList>                                          
                                          <asp:RequiredFieldValidator ID="rfvCity" runat="server" 
                                              ControlToValidate="ddlCity" ErrorMessage="Please select City" 
                                              InitialValue="Select City" ValidationGroup="PostData">*</asp:RequiredFieldValidator>
                                           <cc3:ValidatorCalloutExtender ID="valcallextnCity" runat="server" Enabled="true" TargetControlID="rfvCity">
                                                          </cc3:ValidatorCalloutExtender>
                                      </td>
                                    </tr>  
                                </table>
                                </ContentTemplate>
                                </asp:UpdatePanel>
                            </td>
                        </tr>
                        <tr>
                            <td align="center" colspan="2">
                                <asp:Button ID="btnGetData" runat="server" Text="To Get Data" 
                                    onclick="btnGetData_Click" ValidationGroup="PostData" />
                            </td>
                        </tr>
                        <tr>
                            <td align="center" colspan="2">
                                <br />
                             </td>
                        </tr>
                        <tr>
                        <td align="center" style="color:Green; font-family:Monotype Corsiva; font-size:large; font-weight:bold;" colspan="2">
                        <asp:Label ID="lblcount" runat="server" ></asp:Label>&nbsp;&nbsp; Users viewed this site .
                        </td>
                        </tr>
                        <tr><td align="center" colspan="2">
                          <a href="http://www.justcalluz.com" target="_blank"><img src="images/Click Here For SiteView.png" /></a>                          </td></tr>
                        <tr>
                            <td align="center" colspan="2">
                                <asp:Label ID="lblrecords" runat="server" ForeColor="Red" Font-Bold="true" Font-Size="Large"></asp:Label>                                
                            </td>
                        </tr>  
                        <tr>
                        <td colspan="2">
                            <table width="700px">                    
                                <tr>
                                    <td>
                                        <asp:DataGrid ID="ViewGrid" runat="server" AutoGenerateColumns="false" CellPadding="4"
                                            GridLines="None" ForeColor="#333333" Width="720px" AllowPaging="true" PageSize="10" OnPageIndexChanged="ViewGrid_PageIndexChanged"
                                            onitemdatabound="ViewGrid_ItemDataBound">
                                            <FooterStyle BackColor="#1C5E55" ForeColor="White" Font-Bold="True" />
                                            <SelectedItemStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                                            <PagerStyle ForeColor="White" HorizontalAlign="Center" BackColor="#666666" />
                                            <ItemStyle BackColor="#E3EAEB" Font-Size="12px" />
                                            <HeaderStyle BackColor="#1C5E55" Font-Size="10px" Font-Bold="True" ForeColor="White" HorizontalAlign="Left" />
                                            <Columns>
                                                 <asp:TemplateColumn HeaderText="Title" ItemStyle-Width="50px">
                                                    <ItemTemplate>
                                                        <a href="Admin_Data_Details.aspx?did=<%# DataBinder.Eval(Container, "DataItem.id")%>" style="color:Black">
                                                            <%# DataBinder.Eval(Container, "DataItem.company_name")%>
                                                        </a>
                                                    </ItemTemplate>
                                                </asp:TemplateColumn>
                                                <asp:TemplateColumn HeaderText="Company Name">
                                                    <ItemTemplate>
                                                        <a href="Admin_Data_Details.aspx?did=<%# DataBinder.Eval(Container, "DataItem.id")%>" style="color:Black">
                                                            <%# DataBinder.Eval(Container, "DataItem.company_name")%>
                                                        </a>
                                                    </ItemTemplate>
                                                </asp:TemplateColumn> 
                                                <asp:BoundColumn DataField="job_industry" HeaderText="Industry"></asp:BoundColumn>
                                                <asp:BoundColumn DataField="job_functional_area" HeaderText="Functional Area"></asp:BoundColumn>
                                                <asp:BoundColumn DataField="job_role" HeaderText="Role"></asp:BoundColumn>
                                                <asp:BoundColumn DataField="job_Qualification" HeaderText="Qualification" ></asp:BoundColumn>
                                                <asp:BoundColumn DataField="job_exp" HeaderText="Experience" ></asp:BoundColumn>
                                                <asp:BoundColumn DataField="job_sal" HeaderText="Salary" ></asp:BoundColumn>
                                                <asp:BoundColumn DataField="job_desc" HeaderText="Job Description" ></asp:BoundColumn>
                                                <asp:BoundColumn DataField="job_keyskills" HeaderText="Key Skills"></asp:BoundColumn>
                                                 <asp:TemplateColumn HeaderText="Event Name" ItemStyle-Width="50px">
                                                    <ItemTemplate>
                                                        <a href="Admin_Data_Details.aspx?did=<%# DataBinder.Eval(Container, "DataItem.id")%>" style="color:Black">
                                                            <%# DataBinder.Eval(Container, "DataItem.event_name")%>
                                                        </a>
                                                    </ItemTemplate>
                                                </asp:TemplateColumn>                             
                                                <asp:BoundColumn DataField="event_place" HeaderText="Event Place" ></asp:BoundColumn>
                                                <asp:BoundColumn DataField="event_startdate" HeaderText="Start Date" ></asp:BoundColumn>
                                                <asp:BoundColumn DataField="event_enddate" HeaderText="End Date" ></asp:BoundColumn>
                                                <asp:BoundColumn DataField="event_time" HeaderText="Time of Event" ></asp:BoundColumn>
                                                <asp:BoundColumn DataField="event_desc" HeaderText="Description" ></asp:BoundColumn>                                         
                                                <asp:BoundColumn DataField="company_profile" HeaderText="Company Profile"></asp:BoundColumn>                            
                                                <asp:BoundColumn DataField="contact_person" HeaderText="Contact Person" ></asp:BoundColumn>                            
                                                <asp:BoundColumn DataField="address" HeaderText="Address" ></asp:BoundColumn>                            
                                                <asp:BoundColumn DataField="City" HeaderText="City" ></asp:BoundColumn>
                                                <asp:BoundColumn DataField="emailid" HeaderText="Email Id" ></asp:BoundColumn>
                                                <asp:BoundColumn DataField="mob" HeaderText="Mobile" ></asp:BoundColumn>                            
                                                <asp:BoundColumn DataField="fax" HeaderText="Fax" ></asp:BoundColumn>
                                                <asp:BoundColumn DataField="SubCategory" HeaderText="Sub Category" ></asp:BoundColumn>
                                                <asp:BoundColumn DataField="Status" HeaderText="Status"></asp:BoundColumn>
                                                <asp:TemplateColumn HeaderText="No. of Reviews" ItemStyle-Width="50px" ItemStyle-HorizontalAlign="Center" >
                                                    <ItemTemplate>
                                                       <a href="Admin_ViewReviews.aspx?id=<%# DataBinder.Eval(Container, "DataItem.id")%>">
                                                         <asp:Label ID="Label1" runat="server" Text='<%#Eval("Review_Count") %>' ForeColor="Black"></asp:Label>                                                                              
                                                    </a>
                                                    </ItemTemplate>
                                                </asp:TemplateColumn>
                                                <asp:TemplateColumn HeaderText="Abused Reports" ItemStyle-Width="50px" ItemStyle-HorizontalAlign="Center" >
                                                    <ItemTemplate>
                                                       <a href="Admin_ViewReports.aspx?id=<%# DataBinder.Eval(Container, "DataItem.id")%>&type=abuse">
                                                         <asp:Label ID="lblreport" runat="server" Text='<%#Eval("abuse_Count") %>' ForeColor="Black"></asp:Label>                                                                              
                                                    </a>
                                                    </ItemTemplate>
                                                </asp:TemplateColumn>
                                                <asp:TemplateColumn HeaderText="Incorrect Reports" ItemStyle-Width="50px" ItemStyle-HorizontalAlign="Center" >
                                                    <ItemTemplate>
                                                       <a href="Admin_ViewReports.aspx?id=<%# DataBinder.Eval(Container, "DataItem.id")%>&type=incorrect">
                                                         <asp:Label ID="lblincorrect" runat="server" Text='<%#Eval("incorrect_Count") %>' ForeColor="Black"></asp:Label>                                                                              
                                                    </a>
                                                    </ItemTemplate>
                                                </asp:TemplateColumn>
                                                <asp:TemplateColumn HeaderText="Map Location Status" ItemStyle-Width="50px" >
                                                    <ItemTemplate>
                                                        <asp:Label ID="lblDataId" runat="server" Text='<%#Eval("id") %>' Visible="false"></asp:Label>
                                                       <a href="Admin_ToPointAddressOnMap.aspx?id=<%# DataBinder.Eval(Container, "DataItem.id")%>">
                                                         <asp:Label ID="lblMap" runat="server" ForeColor="Black"></asp:Label>                                                                              
                                                    </a>
                                                    </ItemTemplate>
                                                </asp:TemplateColumn>
                                                <asp:TemplateColumn HeaderText="Edit">
                                                <ItemTemplate>
                                                    <asp:LinkButton ID="lnkBtnEdit" runat="server" OnCommand="lnkBtnEditData" CommandArgument='<%#Eval("id") %>'>
                                                    <img src='images/edit.gif' width='16' height='16' border='0' />
                                                    </asp:LinkButton>                                                   
                                                </ItemTemplate>
                                                </asp:TemplateColumn>
                                                <asp:TemplateColumn HeaderText="Delete" ItemStyle-Width="50px">
                                                <ItemTemplate>
                                                    <img src='images/delete.gif' width='16' height='16' border='0' onclick='javascript:confirm_delete(" +<%# DataBinder.Eval(Container, "DataItem.id")%>+");' />                                        
                                                        </a>
                                                </ItemTemplate>
                                                </asp:TemplateColumn>                                                
                                            </Columns>
                                            <EditItemStyle BackColor="#7C6F57" />
                                            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" Mode="NumericPages"/>
                                            <AlternatingItemStyle BackColor="White" />
                                        </asp:DataGrid>
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
