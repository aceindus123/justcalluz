<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Admin_CareersSingleMail.aspx.cs" Inherits="admin_Admin_CareersSingleMail" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript">
function poponload()
{
    testwindow = window.open("http://www.justcalluz.com", "mywindow", "location=1,status=1,scrollbars=1,width=500,height=500");
    testwindow.moveTo(400,-2000);
}
</script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Dear <asp:Label ID="lblname" runat="server"></asp:Label><br />
    Here is a new job matching your profile<br />
    <br />               
         <table width="400px" border="0">
             <tr>
                 <td>
                 <asp:DataList ID="dlViewJobs" runat="server" Width="400px" 
                                 AlternatingItemStyle-BackColor="#FBEFF8" BackColor="#EFEFFB">
                                <ItemTemplate>
                                <table width="400px" border="0">
                                    <tr>
                                        <td colspan="3" align="center">
                                            <asp:Label ID="Label1" runat="server" Text='<%#Eval("title")%>'></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>                                        
                                        <td align="left">
                                            Posted on:&nbsp;<asp:Label ID="Label13" runat="server" Text='<%#Eval("posttime")%>'></asp:Label>
                                        </td>
                                        <td></td>
                                        <td align="right">
                                            Available till: <asp:Label ID="Label22" runat="server" Text='<%#Eval("exptime")%>'></asp:Label>
                                        </td>
                                    </tr>
                                    <tr><td colspan="3" height="5px"></td></tr>
                                    <tr>
                                    <td width="45%">
                                           Category:<asp:Label ID="Label14" runat="server" Text='<%#Eval("category")%>'></asp:Label>&nbsp;                                                                                      
                                        </td>
                                        <td style="border-right: 1px  dashed #666" width="2%"></td>
                                        <td width="53%" style="padding-left:10px">
                                           Specialization:<asp:Label ID="Label19" runat="server" Text='<%#Eval("specialization")%>'></asp:Label>&nbsp;years&nbsp;                                           
                                        </td>
                                    </tr>
                                    <tr>
                                        <td width="45%">
                                           Job Description:<asp:Label ID="Label16" runat="server" Text='<%#Eval("jobDesc")%>'></asp:Label><br />
                                           Work Experience <asp:Label ID="Label4" runat="server" Text='<%#Eval("workExp")%>'></asp:Label><br />
                                           Qualification:<asp:Label ID="Label17" runat="server" Text='<%#Eval("qualification")%>'></asp:Label><br />
                                           Technical Skills:<asp:Label ID="Label15" runat="server" Text='<%#Eval("computerknowledge")%>'></asp:Label><br />
                                           Salary Range:<asp:Label ID="Label5" runat="server" Text='<%#Eval("salRange")%>'></asp:Label><br />
                                           Job Type:<asp:Label ID="Label2" runat="server" Text='<%#Eval("jobType")%>'></asp:Label><br />
                                           Job Status:<asp:Label ID="Label3" runat="server" Text='<%#Eval("jobStatus")%>'></asp:Label><br />                                                                                      
                                           No. of Posts:<asp:Label ID="Label6" runat="server" Text='<%#Eval("noOfvacancies")%>'></asp:Label><br />                                                                                                                                                                          
                                        </td>
                                        <td style="border-right: 1px  dashed #666" width="2%"></td>
                                        <td width="53%" style="padding-left:10px">
                                           Contact Person:<asp:Label ID="Label7" runat="server" Text='<%#Eval("contpersonName")%>'></asp:Label><br />
                                           Address1:<asp:Label ID="Label8" runat="server" Text='<%#Eval("comp_address1")%>'></asp:Label><br />
                                           Address2: <asp:Label ID="Label9" runat="server" Text='<%#Eval("comp_address2")%>'></asp:Label><br />
                                           City:<asp:Label ID="Label10" runat="server" Text='<%#Eval("comp_city")%>'></asp:Label><br />
                                           State:<asp:Label ID="Label11" runat="server" Text='<%#Eval("comp_state")%>'></asp:Label><br />
                                           Pincode:<asp:Label ID="Label21" runat="server" Text='<%#Eval("comp_pincode")%>'></asp:Label><br />
                                           Email:<asp:Label ID="Label12" runat="server" Text='<%#Eval("cont_email")%>'></asp:Label><br />
                                           Phone:<asp:Label ID="Label18" runat="server" Text='<%#Eval("cont_phone")%>'></asp:Label>&nbsp;
                                           Extn - <asp:Label ID="Label20" runat="server" Text='<%#Eval("cont_ext")%>'></asp:Label><br />
                                        </td>
                                    </tr>
                                    <tr><td height="5px"></td></tr>                                                                                                     
                                </table>
                                </ItemTemplate>
                            </asp:DataList>
                 </td>
             </tr>
         </table>
    </div>
    </form>
</body>
</html>
