<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Admin_ViewHallsData.aspx.cs" Inherits="admin_Admin_ViewHallsData" %>
<%@ Register Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" TagPrefix="cc3"  %>
<%@ Register Src="~/admin/user_control/Admin_Headermenu.ascx" TagName="Headermenu" TagPrefix="cc1" %>
<%@ Register Src="~/admin/user_control/Admin_LeftMenu.ascx" TagName="LeftMenu" TagPrefix="cc4" %>
<%@ Register Src="~/admin/user_control/Admin_MoviesHeader.ascx" TagName="MovieHeader" TagPrefix="cc2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<title>Justcalluz - Admin Control Panel - View Theatre Data</title>    
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
        .style40
        {
            height: 16px;
        }
        .style41
        {
            height: 23px;
        }
         #dGridHalldata td
        {
        	border-color:Black;
        	border:1px;
        }
        #dGridHalldata th
        {
        	border:1px solid black;
        }
        </style>
           <script language="javascript" type="text/javascript">
  
  	function confirm_delete()
{
    if (confirm("Are you sure you want to delete this Classified?") == true)
        return true;
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
     <script type="text/javascript" language="javascript">
         function selectOne(frm) {
             for (i = 0; i < frm.length; i++) {
                 if (frm.elements[i].checked) {
                     return true;
                 }
             }
             alert('select atleast one Checkbox for  Edit!');
             return false;
         }
</script>
<script type="text/javascript" language="javascript">
    function confirmMessageDelete(frm) {
        for (i = 0; i < frm.length; i++) {
            if (frm.elements[i].checked) {
                return confirm("Are you sure you want to delete the selected record?");
                return true;
            }
        }
        alert('select atleast one Checkbox for Delete!');
        return false;
    }
</script>
<script language="javascript" type="text/javascript" >
    function Sample() {
        var n = document.getElementById("dGridHalldata").rows.length;
        var i;
        var j = 0;
        for (i = 2; i <= n; i++) {
            if (i < 10) {
                if (document.getElementById("dGridHalldata_ctl0" + i + "_CheckBoxreq").checked == true) {
                    if (j > 0) {
                        alert('you can select only one...');
                        document.getElementById("dGridHalldata_ctl0" + i + "_CheckBoxreq").checked = false;
                    }
                    else {
                        j++;
                    }
                }
            }
            else if (i < 12) {
                if (document.getElementById("dGridHalldata_ctl" + i + "_CheckBoxreq").checked == true) {
                    if (j > 0) {
                        alert('you can select only one...');
                        document.getElementById("dGridHalldata_ctl" + i + "_CheckBoxreq").checked = false;
                    }
                    else {
                        j++;
                    }
                }
            }
        }
    }
</script>
 
        <script type="text/javascript" src="js/tab.js"></script>
       <%-- <script type="text/javascript">
function poponload()
{
    testwindow = window.open("http://www.justcalluz.com", "mywindow", "location=1,status=1,scrollbars=1,width=500,height=500");
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
                    <table width="750px" style="margin-bottom: 0px">
                    <tr>
                    <td>                      
                      <cc2:MovieHeader ID="mheader" runat="server" />
                    </td>
                    </tr> 
                    <tr><td height="5px"></td></tr> 
                     <tr>
                            <td colspan="2" align="right">
                                <asp:ScriptManager ID="ScriptManager1" runat="server">
                                </asp:ScriptManager>
                                 <a  target="_blank" href="http://www.justcalluz.com/Movies.aspx?mname=null&mlang=null" ><img src="images/Click Here For SiteView.png" alt="Site View" /></a>
                                <%--<asp:ImageButton ID="imgsite" runat="server" OnClientClick="justcalluz:poponload();" ImageUrl="images/Click Here For SiteView.png"/>--%>
                            </td>
                        </tr>     
                    <tr>
                        <td align="center" colspan="3">
                          <span style="font-size:21px; font-weight:bold; color:DarkBlue"> View Cinema Hall Details</span> 
                        </td>
                      </tr>                     
                                                                 
                        <tr>
                            <td colspan="2">
                                <asp:Label ID="lblMessage" runat="server" ForeColor="OrangeRed" Font-Bold="true" Font-Size="Medium"></asp:Label>
                                <div style="float:right; width:50px; padding-right:20px;">
                            <a href="Admin_Movies.aspx" style="text-decoration:underline;">Back</a>                             
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
                          <td align="left"  colspan="2">
                          <asp:Button ID="btnVieworEdit" runat="server" Text="Edit" OnClientClick="return selectOne(this.form);"
                                 OnClick="ViewDetails_Click" style="border-radius:1px solid black;" />
                              
                                                
                            <asp:Button ID="btnDelete" runat="server" Text="Delete"  
                                 OnClick="lnkDelete_Click" style="border-radius:1px solid black;" OnClientClick="return confirmMessageDelete(this.form);"/>                          
                                
                          </td>  
                          </tr>                                   
            <tr>
                <td colspan="2"> 
                   <asp:GridView ID="dGridHalldata" runat="server" AutoGenerateColumns="false" CellPadding="4"
                                            GridLines="None" ForeColor="#333333" Width="500px"  
                        AllowPaging="true" PageSize="10"   DataKeyNames="id" 
                        onpageindexchanging="dGridHalldata_PageIndexChanged"  onrowdatabound="dGridHalldata_ItemDataBound"  >

                                                <FooterStyle BackColor="#84bec2" ForeColor="White" Font-Bold="True" />
                                            <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                                            <PagerStyle ForeColor="White" HorizontalAlign="Center" BackColor="#84bec2" />
                                            <RowStyle BackColor="#E3EAEB" Font-Size="12px" BorderColor="Black" BorderWidth="1" BorderStyle="Solid"/>
                                            <HeaderStyle BackColor="#007a7d" Font-Size="11px" Font-Names="verdana" Font-Bold="True" ForeColor="White" HorizontalAlign="left" BorderColor="Black" Height="30px"/>
                                            <AlternatingRowStyle BackColor="White" />
                                            <EditRowStyle BackColor="#7C6F57" />
                                            <Columns>
                                             <asp:TemplateField ItemStyle-BorderColor="Black" ItemStyle-BorderStyle="Solid" ItemStyle-BorderWidth="1"
                                                            HeaderStyle-HorizontalAlign="Center"  ItemStyle-HorizontalAlign="Center">
                                                       
                                                       <ItemTemplate>                                                                                                                      
                                                            <asp:CheckBox ID="CheckBoxreq" runat="server" onclick="Sample()" />                                  
                                                        </ItemTemplate>
                                                    </asp:TemplateField> 
                                                <asp:TemplateField HeaderText="Theatre Name" ItemStyle-BorderWidth="1">
                                                    <ItemTemplate>
                                                        <a href="Admin_Data_Details.aspx?did=<%# DataBinder.Eval(Container, "DataItem.id")%>" style="color:Black">
                                                            <%# DataBinder.Eval(Container, "DataItem.company_name")%>
                                                        </a>
                                                    </ItemTemplate>
                                                </asp:TemplateField>                                                
                                               
                                                 <asp:TemplateField HeaderText="Address"  ItemStyle-BorderWidth="1">
                                                    <ItemTemplate>
                                                      
                                                         <asp:Label ID="Labadd" runat="server" ForeColor="Black">
                                                         <%#Eval("address") %>,<%#Eval("Pincode") %>
                                                         </asp:Label>                                                                              
                                                   
                                                    </ItemTemplate>
                                                </asp:TemplateField>                                                
                                              <%--   <asp:BoundColumn DataField="address" HeaderText="Address" ></asp:BoundColumn> 
                                              <asp:BoundColumn DataField="area" HeaderText="Address" ></asp:BoundColumn>  
                                                <asp:BoundColumn DataField="land_mark" HeaderText="Landmark" ></asp:BoundColumn>                               
                                                <asp:BoundColumn DataField="City" HeaderText="City" ></asp:BoundColumn>
                                                <asp:BoundColumn DataField="Pincode" HeaderText="Pincode" ></asp:BoundColumn>
                                                 <asp:BoundField DataField="web" HeaderText="Website" ItemStyle-BorderWidth="1"></asp:BoundField> 
                                                   <asp:BoundField DataField="SubCategory" HeaderText="Type" ItemStyle-BorderWidth="1"></asp:BoundField>   --%>
                                                <asp:BoundField DataField="Email" HeaderText="Email Id" ItemStyle-BorderWidth="1"></asp:BoundField>
                                                <asp:BoundField DataField="mob" HeaderText="Mobile" ItemStyle-BorderWidth="1"></asp:BoundField> 
                                                 <asp:TemplateField HeaderText="Website" ItemStyle-Width="50px" ItemStyle-BorderWidth="1" ItemStyle-HorizontalAlign="Center" >
                                                    <ItemTemplate>
                                                       <a href="<%# Eval("web")%>" target="_blank">
                                                        click here                                                                             
                                                    </a>
                                                    </ItemTemplate>
                                                </asp:TemplateField> 
                                                                                                                      
                                                                                             
                                                <asp:TemplateField HeaderText="No. of Reviews" ItemStyle-Width="50px" ItemStyle-BorderWidth="1" ItemStyle-HorizontalAlign="Center" >
                                                    <ItemTemplate>
                                                       <a href="Admin_ViewReviews.aspx?id=<%# DataBinder.Eval(Container, "DataItem.id")%>">
                                                         <asp:Label ID="Label1" runat="server" Text='<%#Eval("record_count") %>' ForeColor="Black"></asp:Label>                                                                              
                                                    </a>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Map Location Status" ItemStyle-Width="50px" ItemStyle-BorderWidth="1" ItemStyle-ForeColor="Black">
                                                    <ItemTemplate>
                                                        <asp:Label ID="lblId" runat="server" Text='<%#Eval("id") %>' Visible="false"></asp:Label>
                                                       <a href="Admin_ToPointAddressOnMap.aspx?id=<%# DataBinder.Eval(Container, "DataItem.id")%>">
                                                         <asp:Label ID="lblMap" runat="server" ForeColor="Black"></asp:Label>                                                                              
                                                    </a>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                              <%--  <asp:TemplateField HeaderText="Edit">
                                                <ItemTemplate>
                                                    <a href="Admin_ToEditCinemaHallDetails.aspx?chid=<%# DataBinder.Eval(Container, "DataItem.id")%>">
                                                    <img src='images/edit.gif' width='16' height='16' border='0' />                                                                                                   
                                                        </a>
                                                </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Delete" ItemStyle-Width="50px">
                                                <ItemTemplate>
                                                    <img src='images/delete.gif' width='16' height='16' border='0' onclick='javascript:confirm_delete(" +<%# DataBinder.Eval(Container, "DataItem.id")%>+");' />                                        
                                                        </a>
                                                </ItemTemplate>
                                                </asp:TemplateField>  --%>                                              
                                            </Columns>
                                          
                                        </asp:GridView>                                                             
                </td>
            </tr>            
            <tr>
                <td>          
                </td>
            </tr>
            <tr>
                <td>
          
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
