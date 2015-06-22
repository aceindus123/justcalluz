<%@ Control Language="C#" AutoEventWireup="true" CodeFile="toplife.ascx.cs" Inherits="usercontrols_toplife" %>
 <tr>
    <td><table width="100%" border="0">
  <tr>
    <td width="16%" align="center"><asp:ImageButton ID="jwell" runat="server" 
            ImageUrl="../images/jewellery.gif" width="100" height="100" 
            onclick="jwell_Click" />
    </td>
    <td width="16%" align="center"><asp:ImageButton ID="car" runat="server" 
            ImageUrl="../images/car.gif" width="100" height="100" onclick="car_Click"/>
    </td>
    <td width="17%" align="center"><asp:ImageButton ID="lugg" runat="server" 
            ImageUrl="../images/luggage.gif" width="100" height="100" onclick="lugg_Click"/>
    </td>
    <td width="17%" align="center"><asp:ImageButton ID="watch" runat="server" 
            ImageUrl="../images/wrist_watch.gif" width="100" height="100" 
            onclick="watch_Click"/>
    </td>
    <td width="18%" align="center"><asp:ImageButton ID="fashion" runat="server" 
            ImageUrl="../images/fashion_designer_stores.gif" width="100" height="100" 
            onclick="fashion_Click"/>
    </td>
    <td width="16%" align="center"><asp:ImageButton ID="sunglass" runat="server" 
            ImageUrl="../images/sunglass.gif" width="100" height="100" 
            onclick="sunglass_Click"/>
    </td>
  </tr>
  <tr>
    <td align="center" class="side_menu"><a href="<%$RouteUrl:RouteName=LifeStyle_Sub,cat=Jewellery%>" runat="server">Jewellery</a></td>
    <td align="center" class="side_menu"><a href="<%$RouteUrl:RouteName=LifeStyle_Sub,cat=Car%>" runat="server">Car</a></td>
    <td align="center" class="side_menu"><a href="<%$RouteUrl:RouteName=LifeStyle_Sub,cat=Luggage%>" runat="server">Luggage</a></td>
    <td align="center" class="side_menu"><a href="<%$RouteUrl:RouteName=LifeStyle_Sub,cat=Wrist Watch%>" runat="server">Wrist Watch</a></td>
    <td align="center" class="side_menu"><a href="<%$RouteUrl:RouteName=LifeStyle_Sub,cat=Fashion Designer Stores%>" runat="server">Fashion Designer Stores</a></td>
    <td align="center" class="side_menu"><a href="<%$RouteUrl:RouteName=LifeStyle_Sub,cat=Sunglass%>" runat="server">Sunglass</a></td>
  </tr>
</table>
</td>
  </tr>