<%@ Page Language="C#" AutoEventWireup="true" CodeFile="jc_reverseauctionMail.aspx.cs" Inherits="jc_reverseauctionMail" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd" />

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
 <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title> Jc_ReverseAuctionMail page</title>
    <link href="css/inner_style.css" rel="stylesheet" type="text/css" />
    <link href="starrater.css" type="text/css" rel="Stylesheet" />
    <link href="css/style.css" rel="stylesheet" type="text/css" />
    <%--<script type="text/javascript" src="js/jquery-1.2.6.min.js"></script>
    <script type="text/javascript" src="js/jquery.rater.js"></script>--%>
    <script type="text/javascript">
        function alertdelete() {
            alert("Selected Classified has been deleted Successfully");
        }
</script>
</head>
<body>
    <form id="form1" runat="server">
   <div id="dvMail" runat="server" visible="false">
   <asp:Panel ID="pnlMail" runat="server" BorderColor="Black" BorderWidth="1" BorderStyle="Dotted" Width="90%" Visible="false">
    <table border="0" width="100%"><tr><td style="padding-left:5px;">
    &nbsp;Dear <asp:Label ID="lblname" runat="server" Font-Bold="true"></asp:Label>,<br />
        <br />
    
      &nbsp;Please find below the information you had requested.<br /><br />
      &nbsp;Contacts listed under&nbsp;&nbsp;<asp:Label ID="lblcateName" runat="server" ForeColor="Red" Font-Bold="true"></asp:Label>.<br /><br />
           
       &nbsp;Note : Whenever you call please mention that you got information from justcalluz .
        </td></tr></table>
        <table width="100%" border="0">
         <tr><td>
         
         <asp:DataList ID="DlCategorymail" runat="server" Width="100%" BackColor="#F0F8FF" AlternatingItemStyle-BackColor="#D5E6F9"
              DataKeyField="id" OnItemDataBound="DlCategorymail_ItemDataBound">
         <ItemTemplate>
           <table border="0" width="100%">
              <tr>
                 <td style="padding-left:5px; width:60%;">
                      <asp:HyperLink ID="HplCompanyName" runat="server" Text='<%# Eval("company_name") %>' ForeColor="Red" Font-Bold="true" Font-Underline="false" 
                       NavigateUrl='<%# string.Format("http://www.justcalluz.com/sessionstore.aspx?id=" + Eval("id").ToString()+"&cname="+Eval("company_name").ToString()+"&comp=View") %>'></asp:HyperLink>
                       <%--<asp:LinkButton ID="HplCompanyName" runat="server" Text='<%# Eval("company_name") %>' ForeColor="Red" Font-Bold="true" Font-Underline="false" 
                         OnClientClick="javascript:return alertdelete();"></asp:LinkButton>--%>
                      <%--<asp:HyperLink ID="HplCompanyName" runat="server" Text='<%# Eval("company_name") %>' ForeColor="Red" Font-Bold="true" Font-Underline="false" 
                       NavigateUrl='<%# GetCompanyUrl(Eval("id"),Eval("company_name")) %>'></asp:HyperLink>--%>

                 </td>
                 <td align="right" style="width:40%;">
                   <asp:Label ID="lblDataId" runat="server" Text='<%#Eval("id")%>' Visible="false"></asp:Label> 
                     <span class="ui-rater">         
                     <span class="ui-rater-starsOff" style="width:90px;"><span class="ui-rater-starsOn" runat="server" id="testSpan0"></span></span>
                     <span class="ui-rater-rating" id="Span2" runat="server"></span>&nbsp;<span class="ui-rater-rateCount" id="Span3" runat="server"></span>
                     </span>
                          (<span class="sub_menu" style="color:Black"><asp:Label ID="lblnoofratings" runat="server"></asp:Label>&nbsp; ratings</span>)&nbsp;&nbsp;|                                       
                      <asp:HyperLink ID="HplRateThis" runat="server" ForeColor="Red" Font-Bold="true" Font-Underline="false"
                               NavigateUrl='<%# string.Format("http://www.justcalluz.com/PostReviewCat.aspx?DataId=" + Eval("id").ToString()+"&name=Rating") %>'>Rate This</asp:HyperLink>
                                <%--<asp:HyperLink ID="HplRateThis" runat="server" ForeColor="Red" Font-Bold="true" Font-Underline="false"
                                     NavigateUrl='<%# GetRatingUrl(Eval("id")) %>'>Rate This</asp:HyperLink>--%>
                   </a>
               </td>
              </tr>
             </table>
             <table border="0" width="100%">
              <tr>
                 <td style="padding-left:5px;">Address</td>
                  <td>:</td>
                   <td height="30">
                    <asp:Label ID="lblAddress" runat="server" Text='<%#Eval("address")%>'></asp:Label>,
                    <asp:Label ID="lblCity" runat="server" Text='<%#Eval("City")%>'></asp:Label>-
                    <asp:Label ID="lblPincode" runat="server" Text='<%#Eval("Pincode")%>'></asp:Label>
                  </td>
                </tr>
                <tr>
                   <td style="padding-left:5px;">Tel.</td>
                   <td>:</td>
                   <td width="94%" height="30">
                    <asp:Label ID="lblLandPhone" runat="server" Text='<%#Eval("landphno")%>'></asp:Label>
                  </td>
                </tr>
                <tr>
                <td style="padding-left:5px;">Email</td>
                <td>:</td>
                  <td height="30">
                    <asp:Label ID="lblMail" runat="server" Text='<%#Eval("emailid")%>'></asp:Label>
                  </td>
                </tr>
                <tr>
                <td style="padding-left:5px;">Website</td>
                <td>:</td>
                  <td height="30">
                    <asp:Label ID="lblWebsite" runat="server" Text='<%#Eval("Website")%>'></asp:Label>
                  </td>
                </tr>
              </table>
         </ItemTemplate>
         </asp:DataList>
        </td></tr>
         </table>
         <table border="0" width="100%"><tr><td>
                &nbsp; Please read terms of use at <a href="http://www.justcalluz.com">http://www.justcalluz.com</a> before acting on the above information.<br /><br />

                &nbsp; We hope the above information is in line with your request.<br /><br />

                &nbsp; Kindly feel free to search for more information on www.justcalluz.com or call on +9166136226.<br /><br />

               &nbsp; Warm Regards,<br />
               &nbsp; Team JustCalluz.
       </td></tr></table>
       </asp:Panel>
    </div>
   </form>
</body>
</html>
