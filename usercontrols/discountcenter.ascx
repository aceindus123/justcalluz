<%@ Control Language="C#" AutoEventWireup="true" CodeFile="discountcenter.ascx.cs" Inherits="usercontrols_discountcenter" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="AjaxToolkit" %>
<td>
<table width="425" border="0" cellpadding="0" cellspacing="0">
<tr><td valign="top"><object id="FlashID" classid="clsid:D27CDB6E-AE6D-11cf-96B8-444553540000" width="418" height="100">
  <param name="movie" value="images/Discounts.swf" />
  <param name="quality" value="high" />
  <param name="wmode" value="opaque" />
  <param name="swfversion" value="6.0.65.0" />
  <!-- This param tag prompts users with Flash Player 6.0 r65 and higher to download the latest version of Flash Player. Delete it if you don’t want users to see the prompt. -->
  <param name="expressinstall" value="Scripts/expressInstall.swf" />
  <!-- Next object tag is for non-IE browsers. So hide it from IE using IECC. -->
  <!--[if !IE]>-->
  <object type="application/x-shockwave-flash" data="images/Discounts.swf" width="418" height="100">
    <!--<![endif]-->
    <param name="quality" value="high" />
    <param name="wmode" value="opaque" />
    <param name="swfversion" value="6.0.65.0" />
    <param name="expressinstall" value="Scripts/expressInstall.swf" />
    

    <!-- The browser displays the following alternative content for users with Flash Player 6.0 and older. -->
    <div>
      <h4>Content on this page requires a newer version of Adobe Flash Player.</h4>
      <embed src="flash.swf" quality="high" pluginspage="http://www.adobe.com/shockwave/download/download.cgi?P1_Prod_Version=ShockwaveFlash" type="application/x-shockwave-flash" width="418" height="100"></embed>

    </div>
    <!--[if !IE]>-->
  </object>
  <!--<![endif]-->
</object></td></tr></table>
<table width="425" border="0" cellpadding="0" cellspacing="0" align="center" style="margin-top:5px;" class="middle">
<tr>
<td width="350" valign="top">
<table width="430" border="0" cellpadding="0" cellspacing="0" align="center" class="middle">
    <tr>
        <td class="refinedsearch">
           <b><a href="index.aspx" style="color:#FFF; text-decoration:none;">Home>></a><a href="Discount.aspx" style="color:#FFF; text-decoration:none;">Discount</a></b>
        </td>
    </tr>
</table>
    <table width="350" border="1" height="auto" bordercolor="#003366" cellpadding="0" cellspacing="0" style="margin-top:10px;">
<tr>
<td class="text" style="text-align:center;" valign="top"><b>Result for :<font color="#336633"> Discounts in Hyderabad</font></b>
    <table width="300" border="0">
<tr>
<td class="style1">
    <asp:DataList ID="DataList1" DataKeyField="id" runat="server" Width="290px" Height="400px"
        style="margin-left: 0px" >
          <HeaderTemplate>
            <table>
            
        </HeaderTemplate>
          <ItemTemplate>
            <tr>
                <td valign="top">
                    <table width="45%">
                        <tr>
                            <td>
                            </td>
                        </tr>
                         <tr>
                            <td width="25%" valign="top" align="left"  style=" border: 1px solid green; background-color:#FFFFcc; padding: 2px;">
                               <table width="70%" cellpadding="0px" cellspacing="0px">
                                    <tr>
                                        <td class="dashboardbg" style=" padding:10px;">
                                            <table cellpadding="0Px" cellspacing="0px" width="370PX" align="center">
                                               <tr>
                                                   <td valign="top" width="24%">
                                                       <div style="padding: 0px; margin: 0px;">
                                                                <table>
                                                                    <tr>
                                                                        <td colspan="3">
                                                                            <asp:LinkButton  ID="Linkbutton1" ForeColor="Red" runat="server" PostBackUrl='<%# string.Format("Discount1.aspx?val={0}", Eval("id")) %>' 
                                                                                 Text ='<%# Eval("bname") %>'  CommandName ="Select" ></asp:LinkButton>
                                                                        </td>     
                                                                     </tr>
                                                                     <tr>
                                                                        <td style="height:5px"></td>
                                                                     </tr>
                                                                     <tr>
                                                                        <td colspan="3" width="31%" class="dbtextcolr" style="color:orange; font-size:12px; font-family:Arial; font-weight:bold; text-decoration:none">
                                                                            <asp:Literal ID="Literal1" runat="server" Text='<%#Eval("descr")%>' />
                                                                        </td>    
                                                                     </tr>
                                                                     <tr>
                                                                        <td style="height:5px"></td>
                                                                     </tr>
                                                                     <tr>
                                                                    
                                                                        <td width="18%"  style="font-family: Arial; font-size: 12px; font-weight: bold;
                                                                            text-align: left; color: Green">
                                                                           Category&nbsp;
                                                                        </td>
                                                                        <td width="1%" class="dbcol" style="color:#036; font-size:12px; font-family:Arial; font-weight:bold">
                                                                            :
                                                                        </td>
                                                                       
                                                                        <td width="31%" class="dbtextcolr" style="color:orange; font-size:12px; font-family:Arial; font-weight:bold">
                                                                          
                                                                       <asp:LinkButton  ID="Linkbutton2" ForeColor="#993333" runat="server" PostBackUrl='<%# string.Format("Discount1.aspx?val={0}", Eval("id")) %>' 
                                                                             Text ='<%# Eval("cat") %>'  CommandName ="Select" ></asp:LinkButton>
                                                                        </td>
                                                                     </tr>
                                                                     <tr>
                                                                        <td></td>
                                                                     </tr>
                                                                     <tr>
                                                                    
                                                                        <td width="18%"  style="font-family: Arial; font-size: 12px; font-weight: bold;
                                                                            text-align: left; color: Green">
                                                                           Locality&nbsp;
                                                                        </td>
                                                                        <td width="1%" class="dbcol" style="color:#036; font-size:12px; font-family:Arial; font-weight:bold">
                                                                            :
                                                                        </td>
                                                                       
                                                                        <td width="31%" class="dbtextcolr" style="color:orange; font-size:12px; font-family:Arial; font-weight:bold">
                                                                          
                                                                       <asp:LinkButton  ID="Linkbutton3" CssClass="linkbutton"  ForeColor="#993333" runat="server" PostBackUrl='<%# string.Format("Discount1.aspx?val={0}", Eval("id")) %>' 
                                                                             Text ='<%# Eval("loc") %>'  CommandName ="Select" ></asp:LinkButton>
                                                                        </td>
                                                                     </tr>
                                                                     <tr>
                                                                        <td style="height:10px;"></td>
                                                                     </tr>
                                                                     <tr>
                                                                        <td colspan="3">
                                                                            <table border="0" width="350px">
                                                                                <tr>
                                                                                    <td style="width:80px">
                                                                                        <asp:Button ID="Button3" runat="server" CssClass="button" BorderStyle="None" />            
                                                                                        <asp:Button ID="Button4" runat="server" CssClass="button2" Text='<%# Eval("sdate") %>' CommandName ="Select"  BorderStyle="None" />
                                                                                    </td>
                                                                                    <td style="width:20px;"><img src="images/arrow_new.JPG"/></td>
                                                                                    <td style="width:80px" align="right">
                                                                                        <asp:Button ID="Button5" runat="server" CssClass="button1" BorderStyle="None" />            
                                                                                        <asp:Button ID="Button6" runat="server" CssClass="button2" Text='<%# Eval("edate") %>'  CommandName ="Select"  BorderStyle="None" />
                                                                                    </td>
                                                                                    <td style="width:100px" valign="bottom" align="right">
                                                                                         <asp:HyperLink ID="hyp1" runat="server" Text="View Details" Font-Size="13px" ForeColor="Maroon" NavigateUrl='<%# "Discount1.aspx?id=" + Eval("id").ToString() %>' ></asp:HyperLink>
                                                                                    </td>
                                                                                </tr>
                                                                            </table>
                                                                        </td>
                                                                     </tr>
                                                                  </table>           
                                                            </div>
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
           
        </ItemTemplate>
          <FooterTemplate>
            </table>
        </FooterTemplate>
        
        
        </asp:DataList>
        
     
       
 <table border="0" style="background-color:white; width: 100px; margin-right: 0px; height: 22px;">
            <tr>
                <td>
                    <asp:DropDownList ID="ddlPageSize" runat="server" 
                        OnSelectedIndexChanged="ddlPageSize_SelectedIndexChanged" 
                        style="height: 22px">
                    <asp:ListItem>3</asp:ListItem>
                    <asp:ListItem>5</asp:ListItem>
                    <asp:ListItem>10</asp:ListItem>
                    </asp:DropDownList>
                </td>
               <td>
                <asp:LinkButton ID="lnkbtnPrevious" runat="server" OnClick="lnkbtnPrevious_Click1" 
                        Font-Bold="True" Font-Size="Medium" Font-Underline="False" ForeColor="#FF6600">Previous</asp:LinkButton>
                </td>
                <td>
                <asp:DataList ID="dlPaging" runat="server" OnItemCommand="dlPaging_ItemCommand" 
                    OnItemDataBound="dlPaging_ItemDataBound" RepeatDirection="Horizontal" 
                        ForeColor="#996633">            
                    <ItemTemplate>
                        <asp:LinkButton ID="lnkbtnPaging" runat="server" 
                        CommandArgument='<%# Eval("PageIndex") %>' 
                        CommandName="lnkbtnPaging" 
                        Text='<%# Eval("PageText") %>'>LinkButton</asp:LinkButton>&nbsp;
                    </ItemTemplate>
               </asp:DataList>

                </td>
                <td>
                    <asp:LinkButton ID="lnkbtnNext" runat="server" OnClick="lnkbtnNext_Click1" Font-Bold="True" Font-Size="Medium" Font-Underline="False" ForeColor="#FF6600">Next</asp:LinkButton>
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
</td>

