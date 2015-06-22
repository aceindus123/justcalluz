<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Admin_CareersMail.aspx.cs" Inherits="admin_Admin_CareersMail" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    Dear <asp:Label ID="lblname" runat="server"></asp:Label><br />
    Here are new jobs matching your profile<br />
    <br />               
         <table width="400px" border="0">
             <tr>
                 <td>
                 <asp:DataList ID="dlViewRelatedJobs" runat="server" Width="400px" 
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
                                            Posted on:&nbsp;<%#DataBinder.Eval(Container.DataItem, "postdate")%>
                                        </td>
                                        <td></td>
                                        <td align="right">
                                            Available till:<%#DataBinder.Eval(Container.DataItem, "expiredate")%>
                                    </tr>
                                    <tr><td colspan="3" height="5px"></td></tr>
                                    <tr>
                                    <td width="45%">
                                           Category:<%#DataBinder.Eval(Container.DataItem, "category")%>&nbsp;                                                                                      
                                        </td>
                                        <td style="border-right: 1px  dashed #666" width="2%"></td>
                                        <td width="53%" style="padding-left:10px">
                                           Specialization:<%#DataBinder.Eval(Container.DataItem, "specialization")%>&nbsp;years&nbsp;                                           
                                        </td>
                                    </tr>
                                    <tr>
                                        <td width="45%">
                                           Job Description:<%#DataBinder.Eval(Container.DataItem, "jobDesc")%><br />
                                           Work Experience:<%#DataBinder.Eval(Container.DataItem, "workExp")%><br />
                                           Qualification:<%#DataBinder.Eval(Container.DataItem, "qualification")%><br />
                                           Technical Skills:<%#DataBinder.Eval(Container.DataItem, "computerknowledge")%><br />
                                           Salary Range:<%#DataBinder.Eval(Container.DataItem, "salRange")%><br />
                                           Job Type:<%#DataBinder.Eval(Container.DataItem, "jobType")%><br />
                                           Job Status:<%#DataBinder.Eval(Container.DataItem, "jobStatus")%><br />                                                                                      
                                           No. of Posts:<%#DataBinder.Eval(Container.DataItem, "noOfvacancies")%><br />                                                                                                                                                                          
                                        </td>
                                        <td style="border-right: 1px  dashed #666" width="2%"></td>
                                        <td width="53%" style="padding-left:10px">
                                           Contact Person:<%#DataBinder.Eval(Container.DataItem, "contpersonName")%><br />
                                           Address1:<%#DataBinder.Eval(Container.DataItem, "comp_address1")%><br />
                                           Address2:<%#DataBinder.Eval(Container.DataItem, "comp_address2")%><br />
                                           City:<%#DataBinder.Eval(Container.DataItem, "comp_city")%><br />
                                           State:<%#DataBinder.Eval(Container.DataItem, "comp_state")%><br />
                                           Pincode:<%#DataBinder.Eval(Container.DataItem, "comp_pincode")%><br />
                                           Email:<%#DataBinder.Eval(Container.DataItem, "cont_email")%><br />
                                           Phone:<%#DataBinder.Eval(Container.DataItem, "cont_phone")%>&nbsp;
                                           Extn - <%#DataBinder.Eval(Container.DataItem, "cont_ext")%><br />
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
