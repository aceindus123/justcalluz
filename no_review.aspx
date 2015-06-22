<%@ Page Language="C#" AutoEventWireup="true" CodeFile="no_review.aspx.cs" Inherits="no_review" %>
<%@ Register Src="usercontrols/signin.ascx" TagName="signin" TagPrefix="aa1"  %>
<%@ Register Src="usercontrols/topimage.ascx" TagName="topimage" TagPrefix="aa2" %>
<%@ Register Src="usercontrols/boxes.ascx" TagName="boxes" TagPrefix="aa5" %>
<%@ Register Src="usercontrols/Search.ascx" TagName="catag" TagPrefix="aa6" %>
<%@ Register Src="usercontrols/footer1.ascx" TagName="footer1" TagPrefix="aa10" %>
<%@ Register Src="usercontrols/footer2.ascx" TagName="footer2" TagPrefix="aa11" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Justcalluz/No Review</title>
    <link href="includes/style1.css" rel="stylesheet" type="text/css" />

</head>
<body>
    <form id="form1" runat="server">
    <table width="960" border="0" bordercolor="#003366"cellpadding="0" cellspacing="0" align="center">
<tr>
<td>
<!--begin of buttons-->
<aa1:signin ID="awea" runat="server" />
   <aa2:topimage ID="cvx" runat="server" />
  
   <aa5:boxes  ID="thw" runat="server" />
   <aa6:catag ID="hhf" runat="server" />
  
  
 <asp:Image ID="review" runat="server" ImageUrl="~/images/vreviews.jpg" />
  
  
    <aa10:footer1 ID="sdsa" runat="server" />
    <aa11:footer2 ID="poshv" runat="server" />
    </td>
</tr>
</table>
    </form>
</body>
</html>
