<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Admin_ToPointAddressOnMap.aspx.cs" Inherits="admin_Admin_ToPointAddressOnMap" ValidateRequest="false" %>
<%@ Register Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" TagPrefix="cc3"  %>
<%@ Register Src="~/admin/user_control/Admin_Headermenu.ascx" TagName="Headermenu" TagPrefix="cc1" %>
<%@ Register Src="~/admin/user_control/Admin_LeftMenu.ascx" TagName="LeftMenu" TagPrefix="cc4" %>
<%@ Register Src="~/admin/user_control/Admin_DataHeader.ascx" TagName="DataHeader" TagPrefix="datahead" %>
<%@ Register Src="~/admin/user_control/Admin_MoviesHeader.ascx" TagName="MovieHeader" TagPrefix="cc2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Justcalluz - Admin Control Panel - To locate address on Map</title>
    <link href="includes/style.css" rel="Stylesheet" type="text/css" />    
    <script src="js/statesopt.js" type="text/javascript"></script>
    <script type="text/javascript" src="js/tab.js"></script>
    <style type="text/css">
        .style39
        {
            width: 195px;
        }
        .cal_theme .ajax__calendar_active   

        {     
            color: Red;      
            font-weight: bold;      
            background-color: #ffffff; 
        } 
        .style40
        {
            width: 188px;
        }
        </style>
        <style type="text/css">
        .style37
        {
            width: 900px;
        }
        .style39
        {
            width: 100px;
        }        
        </style>
      <script type="text/javascript">
function CurrentDateShowing(e)
{
      if (!e.get_selectedDate() || !e.get_element().value)

      e._selectedDate = (new Date()).getDateOnly();
}    
</script>
<%--<script type="text/javascript">
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
                    <table cellpadding="0" cellspacing="0" width="100%">
              <tr>
               <td class="style39" valign="top" style="padding-top:10px">                        
                 <cc4:LeftMenu ID="LeftMenu1" runat="server" />
                </td>
                <td valign="top">&nbsp;</td>
                <td valign="top" style="padding-left:10px; background-color:#F2FAFC">  
                    <table width="750px">
                    <tr id="trDataHeader" runat="server">
                    <td>                      
                       <datahead:DataHeader ID="datahead1" runat="server" />
                    </td>
                    </tr>
                    <tr id="trMovieHeader" runat="server">
                    <td>                      
                      <cc2:MovieHeader ID="mheader" runat="server" />
                    </td>
                    </tr>
                       
                        <tr>
                            <td colspan="2" align="right">
                                <asp:ScriptManager ID="ScriptManager2" runat="server">
                                </asp:ScriptManager>
                                
                                        <a  target="_blank" href="http://www.justcalluz.com/Movies.aspx?mname=null&mlang=null" ><img src="images/Click Here For SiteView.png" alt="Site View" /></a>
                                    
                            </td>
                        </tr> 
                        <tr>
                            <td height="25px"></td>
                        </tr> 
                          <tr>
                            <td colspan="2">
                                <asp:Label ID="lblMessage" runat="server" ForeColor="OrangeRed" Font-Bold="true" Font-Size="Medium"></asp:Label>
                                <div style="float:right; width:50px; padding-right:20px;">
                                <span style="cursor:pointer;text-decoration:underline; color:#3366cc;" onclick="javascript:window.history.go(-1); ">Back</span>
                            <%--<a href="Admin_Movies.aspx" style="text-decoration:underline;">Back</a>--%>                             
                             </div>
                            </td>
                        </tr>  
                        <tr>
                            
                            <td height="50px">
                              Address : &nbsp;  <asp:Label ID="lblCompName" runat="server"></asp:Label>,&nbsp;
                                <asp:Label ID="lblAddress" runat="server"></asp:Label>
                            </td>
                        </tr>                                                                 
                        <tr>
                            <td colspan="2">
                                <table width="100%">
                                  <tr>
                                    <td colspan="3" class="adminform" align="center">
                                        <span style="font-weight:bold"> Please go through the Procedure to get Map URL</span>  
                                    </td>
                                  </tr>
                                  <tr>
                                    <td height="20px"></td>
                                </tr> 
                                  <tr>
                                    <td class="adminform" colspan="3" align="left">Step1:&nbsp;                       
                                    Please Click on &nbsp;<asp:HyperLink ID="HyperLink1" runat="server" ForeColor="Blue" NavigateUrl="http://maps.google.co.in/maps?hl=en&tab=wl" Target="_blank">Get Map URL</asp:HyperLink> .&nbsp; 
                                   
                                    </td>
                                  </tr>
                                   <tr>
                                    <td class="adminform" colspan="3" align="left">Step2:&nbsp;                       
                                   Click the Help button in the bottom right corner.
                                   </td>
                                  </tr>
                                   <tr>
                                    <td class="adminform" colspan="3" align="left">Step3:&nbsp;                       
                                   Click Return to classic Google Maps.
                                   </td>
                                  </tr>
                                   <tr>
                                    <td class="adminform" colspan="3" align="left">Step4:&nbsp;                       
                                     Click Yes in the notification bar that appears.
                                    </td>
                                  </tr>
                                   <tr>
                                    <td class="adminform" colspan="3" align="left">Step5:&nbsp;                       
                                      And paste the above address in search tab which is opened in the other window.
                                    </td>
                                  </tr>
                                  <tr>
                                    <td colspan="3" class="adminform" align="left">
                                        Step6: &nbsp;Please select image named Link then you will get a new box.
                                    </td>
                                  </tr>
                                  <tr>
                                    <td colspan="3"  class="adminform" align="left">
                                        Step7:There is an option "Paste HTML to embed in website". Copy the url into "Map URL" field which is present below
                                    </td>
                                  </tr>
                                  <tr>
                                    <td height="10px" colspan="3"></td>
                                  </tr>
                                  <tr>   
                                    <td align="center" style="padding-left:10px"  colspan="2">
                                        <table width="100%">
                                            <tr>
                                                 <td align="right" class="adminform">
                                                    Map URL
                                                </td>
                                                <td align="center">
                                                    :
                                                </td>
                                                <td align="left">
                                                    <asp:TextBox ID="txtMapURL" runat="server" Width="400"></asp:TextBox>
                                                    <asp:RequiredFieldValidator ID="rfvMapURL" runat="server" 
                                                        ControlToValidate="txtMapURL" ErrorMessage="Please enter Map URL" 
                                                        ValidationGroup="SaveHallmap">*</asp:RequiredFieldValidator>                                                        
                                                        &nbsp; &nbsp;
                                                        &nbsp; &nbsp;                                                                                                                   
                                                </td>
                                            </tr>
                                        </table>
                                    </td> 
                                    <td align="center" class="style40">
                                        <asp:ImageButton ID="imgbtnSave" runat="server" 
                                            ImageUrl="~/admin/images/save.png" onclick="imgbtnSave_Click" 
                                            ValidationGroup="SaveHallmap" /> 
                                         <asp:ImageButton ID="imgbtnmapUpdate" runat="server" 
                                            ImageUrl="~/admin/images/update.png" onclick="imgbtnSave_Click" 
                                            ValidationGroup="SaveHallmap" />   
                                    </td>                                                                     
                                 </tr> 
                                  <tr>
                                    <td colspan="4" class="style41">
                                        <asp:Label ID="lblSmallExceptLarge" runat="server" Visible="false"></asp:Label>
                                    </td>
                                  </tr>
                                
                                 
                                  <tr>
                                    <td height="280px" colspan="4" style="padding-right:10px;">
                                        <asp:Label ID="lblMap" runat="server"></asp:Label>
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

