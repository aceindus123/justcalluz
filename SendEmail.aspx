<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SendEmail.aspx.cs" Inherits="SendEmail" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Email | Justcalluz</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table width="450px">
        <tr>
        <td>
            Dear 
            <asp:Label ID="lblName" runat="server"></asp:Label> ,<br /><br />

            Please find below the information you had requested:<br /><br />

            Contacts listed under 
            <asp:Label ID="lblCat" runat="server" Font-Bold="true" ForeColor="Red"></asp:Label><br /><br />


            Whenever you call please mention that you got this info from Justcalluz.com<br />
        </td>
        </tr>
        <tr>
            <td>
                <asp:DataList ID="DLBindCatData" DataKeyField="id" runat="server" Width="450px" 
                style="margin-left: 0px" onitemdatabound="DLBindCatData_ItemDataBound" AlternatingItemStyle-BackColor="#FBEFF8" BackColor="#EFEFFB">
                  <HeaderTemplate> 
                     
                  </HeaderTemplate>                
                  <ItemTemplate>  
                   <table width="450px" border="0">
                    <tr><td height="4px"></td></tr>
                    <tr>
                        <td>    
            <table width="450px" cellpadding="0px" cellspacing="0px" border="0">                  
                  <tr>
                    <td valign="middle" width="80%" colspan="2" style="padding-left:8px; padding-top:5px; border-right-style:dashed; border-right-color:Gray; border-right-width:1px; font-weight:bold" align="left">                            
                            <asp:HyperLink ID="HyperLink2" runat="server" Text='<%# Eval("company_name") %>'  
                                NavigateUrl='<%# string.Format("http://www.justcalluz.com/sessionstore.aspx?id=" + Eval("id").ToString()+"&cname="+Eval("company_name").ToString()+"&comp=View") %>'></asp:HyperLink>&nbsp;
                            <span  style="color:Black;"> ( <asp:Label ID="lblnoofratings" runat="server"></asp:Label>&nbsp; ratings )</span>
                         </td> 
                        <%--<td width="30%" style="padding-left:4px; padding-top:5px;" height="20" colspan="2" align="left">
                                 
                        <asp:Label ID="lblStarRating" runat="server" CssClass="ui-rater">
                            <asp:Label ID="Label2" runat="server" CssClass="ui-rater-starsOff" Width="90px" >
                                <asp:Label ID="testSpan0" runat="server" CssClass="ui-rater-starsOn">
                                </asp:Label>
                            </asp:Label>            
                        </asp:Label>&nbsp;
                          
                         </td>--%>
                         <td width="20%" style="padding-top:5px; padding-right:8px" align="center"> 
                         <asp:Label ID="lblDataId" runat="server" Text='<%#Eval("id")%>' Visible="false"></asp:Label>
                         
                         <asp:HyperLink ID="HyperLink1" runat="server" Text="Rate This"  NavigateUrl='<%# string.Format("http://www.justcalluz.com/PostReviewCat.aspx?DataId=" + Eval("id").ToString()+"&name=Rating") %>'></asp:HyperLink>                                                           
                        </td>
                  </tr>
                    <tr><td colspan="3" height="10px"></td></tr>
                     <tr>                      
                        <td style="height:5px;padding-left:15px" colspan="4" align="left">
                            <table width="450px">
                                <tr>
                                    <td>
                                        Address:
                                    </td>
                                    <td>
                                        <asp:Label ID="lbladdress" runat="server" Text ='<%# Eval("address") %>'></asp:Label>
                                        <asp:Label ID="lblcomma" runat="server" Text=","></asp:Label>
                                        <asp:Label ID="lblcity" runat="server" Text ='<%# Eval("City") %>'></asp:Label>
                                        <asp:Label ID="lblcomma1" runat="server" Text=","></asp:Label>
                                        <asp:Label ID="lblstate" runat="server" Text ='<%# Eval("State") %>'></asp:Label>
                                         <asp:Label ID="lblcomma2" runat="server" Text=","></asp:Label>
                                        <asp:Label ID="lblpincode" runat="server" Text ='<%# Eval("Pincode") %>'></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        Contact:
                                    </td>
                                    <td>
                                        <asp:Label ID="lblmob" runat="server" Text ='<%# Eval("contact_person") %>'></asp:Label>&nbsp;|
                                        <asp:Label ID="lbllandphone" runat="server" Text ='<%# Eval("mob") %>'></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        Email:
                                    </td>
                                    <td>
                                        <asp:Label ID="Label1" runat="server" Text ='<%# Eval("emailid") %>'></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="4" align="left"><span>View Map</span>&nbsp;|&nbsp;<asp:HyperLink ID="hyp1" runat="server" Text="View Details"  
                                        NavigateUrl='<%# string.Format("http://www.justcalluz.com/sessionstore.aspx?id=" + Eval("id").ToString()+"&cname="+Eval("company_name").ToString()+"&comp=View") %>'></asp:HyperLink>
                                    </td>
                                </tr>
                                </table>                                                       
                            </td>
                         </tr>
                     
                       <tr><td colspan="4">&nbsp;</td></tr>                     
                  </table> 
              </td>
        </tr>  
                   </table>                               
                  </ItemTemplate>
                  <FooterTemplate>                      
                  </FooterTemplate>
                </asp:DataList>
            </td>
         </tr>
         <tr>
            <td>
                Please read terms of use at http://justcalluz.com/terms before acting on the above information.<br /><br />

                We hope the above information is in line with your request.<br /><br />

                Kindly feel free to search for more information on 
                <asp:HyperLink ID="HyperLink1" runat="server" Text="Rate This"  NavigateUrl='<%# "http://www.justcalluz.com/" %>'>www.justcalluz.com</asp:HyperLink> <br /><br />

                Warm Regards,
                Team JustCalluz
            </td>
         </tr>
       </table>
    </div>
    </form>
</body>
</html>
