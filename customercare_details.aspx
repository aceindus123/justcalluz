<%@ Page Language="C#" AutoEventWireup="true" CodeFile="customercare_details.aspx.cs" Inherits="customercare_details" %>
<%@ Register Src="usercontrols/footer1.ascx" TagName="footer1" TagPrefix="aa10" %>
<%@ Register Src="usercontrols/footer2.ascx" TagName="footer2" TagPrefix="aa11" %>
<%@ Register Src="usercontrols/BottomContent.ascx" TagName="bottomcontent" TagPrefix="aa4" %>
<%@ Register Src="usercontrols/BottomMidContent.ascx" TagName="bottomMidcontent" TagPrefix="aa5" %>
<%@ Register Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" TagPrefix="cc3"  %>
<%@ Register Src="usercontrols/SearchNew.ascx" TagName="SearchNew" TagPrefix="New" %>
<%@ Register Src="usercontrols/small_logo.ascx" TagName="logo" TagPrefix="S_logo" %>
<%@ Register Src="usercontrols/signin.ascx" TagName="signin" TagPrefix="aa1" %>
<%@ Register Src="usercontrols/Search.ascx" TagName="catag" TagPrefix="aa6" %>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<%--<title>:: Just Calluz :: Customer Care  page</title>--%>
<title>JustCalluz Customer Care</title>
<meta name='Title' content='JustCalluz Customer Care' />

<link href="css/inner_style.css" rel="stylesheet" type="text/css" />
<link href="css/style.css" rel="Stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
<div class="layout">
<div class="signin">
<aa1:signin ID="suy" runat="server" />
</div>
<div class="header">
<%--<div class="header_top"></div>--%>
<div class="header_logo"><S_logo:logo ID="logo" runat="server" /></div>
<div class="header_search">
 <New:SearchNew ID="New" runat="server" />
 </div>
 </div>
<div class="category_box">
 <aa6:catag ID="uye" runat="server" />
</div>
<div class="content" style="padding:0; margin:0;">
<div class="header_search" style="width:790px;">
  <table width="100%" border="0">
    <tr>
      <td width="77%">&nbsp;</td>
      <td width="23%" align="right" valign="middle"><img src="images/66136226.png" alt="contactNumber" width="175" height="51" /></td>
    </tr>
  </table>
</div>
<!-- start The Content-->
<div class="content_innermid" style="width:100%;">
 <table width="100%" border="0">
    <tr>
       <td height="30"><strong><a href="<%$RouteUrl:RouteName=HomeRoute %>" runat="server">Home</a></strong> &gt; Customer Care</td>
    </tr>
    <tr>
      <td height="30" class="mobile">In order to serve you better, please verify yourself</td>
    </tr>
    <tr>
      <td height="100" align="center" valign="middle"><table width="58%" border="0">
        <tr>
          <td style="border:1px #CCC solid; background:#FEF3E2; padding:10px;">
          <asp:DataList ID="dlcustomerlist" runat="server" DataKeyField="id">
          <ItemTemplate><br />
          <h1>
            <asp:Label ID="cmpname" runat="server" Text='<%#Eval("company_name")%>'></asp:Label>
           <%-- <asp:LinkButton ID="lnkcmp_name" runat="server" 
            Text='<%#Eval("company_name")%>' CommandArgument='<%#Eval("id")%>' OnCommand="company_det"></asp:LinkButton>--%>
           </h1><br />
          <%#DataBinder.Eval(Container.DataItem,"address") %>,<%#DataBinder.Eval(Container.DataItem,"city")%>,<%#DataBinder.Eval(Container.DataItem,"State")%>,<%#DataBinder.Eval(Container.DataItem,"Pincode")%>
          <br />
          <h2><b>category :<%#DataBinder.Eval(Container.DataItem,"Category")%></b></h2><br />
          
          ---------------------------------------------------------------------------------------------
          </ItemTemplate>
          </asp:DataList>
          
           
            
            </td>
          </tr>
        <tr id="ver_msg" runat="server">
          <td height="25">Please verify to confirm you own this listing. </td>
        </tr>
        <tr id="ver_img" runat="server">
          <td height="30">
          <asp:ImageButton ID="imgverification_code" AlternateText="Verification_CodeImage" runat="server" ImageUrl="images/Verification_Code.png" />
          </td>
        </tr>
        <tr id="ver_msg1" runat="server">
          <td height="25">(The verification SMS will be sent on the Mobile number registered with Justdial)<asp:Panel ID="pnlverification" runat="server">
    <fieldset style="width:500px">
    <table width="100%" style="background-color:#FEF3E2;">
    <tr><td colspan="3" align="right">
    <asp:ImageButton ID="img_cancel" AlternateText="Cancelbutton" runat="server" ImageUrl="images/cencel.png" />
    </td></tr>
    <tr><td colspan="3" align="center">
    <asp:Label ID="lblmob" runat="server" Text="Mobile Verification" Font-Bold="true" Font-Size="Large"></asp:Label>
    </td>
    </tr>
    <tr>
    <td>
    
Enter the verification code that we have sent to you In order to confirm you own this listing, we have sent a verification code on <asp:Label ID="client_mob" runat="server" Text='<%#Eval("mob")%>'></asp:Label> please enter the verification code below and click "Verify" (In case <asp:Label ID="lblclient_vermob" runat="server" Text='<%#Eval("mob")%>'></asp:Label> is not your number. Call us on 022-61607080)

    </td>
    </tr>
    <tr><td></td></tr>
    <tr>
    <td align="center">
    <asp:TextBox ID="txtverification" runat="server"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:ImageButton ID="imgverification" AlternateText="Verifybutton" runat="server" ImageUrl="images/Verify.png" />
    </td>
    </tr>
    
    </table>
    </fieldset>
    </asp:Panel>
                                    </td>
          </tr>
           <tr><td align="center">
               &nbsp;</td></tr>
      </table>
       <cc3:ModalPopupExtender ID="mobile_verification" runat="server" PopupControlID="pnlverification" TargetControlID="imgverification_code" 
     CancelControlID="img_cancel" BackgroundCssClass="modalBackground" DropShadow="false"></cc3:ModalPopupExtender>
      </td>
    </tr>
   <%--</td></tr>--%>
  </table>
</div>
</div>
<!-- end of the content-->
<div class="content_midbootam" >
<aa5:bottomMidcontent ID="mid1" runat="server" />
</div>
<div class="content_bootam_center">
<aa4:bottomcontent ID="bottomcontent1" runat="server" />
</div>
<div class="footer" align="center" style="padding-top:5px; " >
<aa10:footer1 ID="tevfd" runat="server" />
<aa11:footer2 ID="eqwr" runat="server" />
</div>
</div>

</form>
</body>
</html>
