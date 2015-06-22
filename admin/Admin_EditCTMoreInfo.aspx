<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Admin_EditCTMoreInfo.aspx.cs" Inherits="admin_Admin_EditCTMoreInfo" %>
<%@ Register Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" TagPrefix="cc3"  %>
<%@ Register Src="~/admin/user_control/Admin_Headermenu.ascx" TagName="Headermenu" TagPrefix="cc1" %>
<%@ Register Src="~/admin/user_control/Admin_LeftMenu.ascx" TagName="LeftMenu" TagPrefix="cc4" %>
<%@ Register Src="~/admin/user_control/Admin_CityTrendsHeader.ascx" TagName="CTHeader" TagPrefix="CTH" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="AjaxToolkit" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<title>Justcalluz - Admin Control Panel - City Trends_Post More details</title>
    <link href="starrater.css" rel="Stylesheet" type="text/css" />
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
        </style>
       <script language="javascript" type="text/javascript">
          
  	        function confirm_delete(uid)
        {
          if (confirm("Are you sure you want to delete this Movie?")==true)
            document.location='Admin_DeleteMovies.aspx?mid=' +uid;
          else
            return false;
        }
	        function alertdelete()
        {
        alert("Selected Movie has been deleted Successfully");
        }
        function alertaccept()
        {
        alert("Selected Classified has been Accepted");
        }
      </script>	
       <script type="text/javascript">
        function validate() {
            //if validation sucess return true otherwise return false.
            if (document.getElementById("txtLink").value != "") 
            {
                if (document.getElementById("txtLinkTitle").value != "")
                {
                    Insertlink();
                }
                else 
                {
                    document.getElementById("txtLinkTitle").value = document.getElementById("txtLink").value;
                    Insertlink();
                }     
                return true;                
            }
            alert('Enter a value');
            return false;
        }
    </script>
     
          <script type=text/javascript>
          function hide() {
              document.getElementById('modpopup1').style.visibility = 'hidden';
          }
          function show() {
              document.getElementById('modpopup1').style.visibility = 'visible';
          }
    </script>
     <script language=javascript>
         function getSelText() {
             var txt = '';
             if (window.getSelection) {
                 txt = window.getSelection();                
             }
             else if (document.getSelection) {
                 txt = document.getSelection();
             }
             else if (document.selection) {
             txt = document.selection.createRange().text;
         }        
             else return;
             document.aform2.txtLinkTitle.value = txt;
         }
</script>
     
     <script language=javascript>
        function Insertlink() {
            var x = document.getElementById('txtLinkTitle').value;
            var y = document.getElementById('txtLink').value;            
            document.getElementById('txtDesc').focus();
            document.getElementById('txtDesc').select();
            if (document.getElementById('txtDesc').value.match(x)) {
                document.getElementById('txtDesc').value = document.getElementById('txtDesc').value.replace(x, (x.link(y)));
            }
            else {
                var z = x.link(y).toString();
                var u = document.getElementById('txtDesc');
//                u.text = 'append' + z;
                //                document.getElementById('txtDesc').innerHTML+=z;
                u.value = u.value + z;
            }
            hide();
        }

</script>
        <script type="text/javascript" src="js/tab.js"></script>
        <script type="text/javascript">
function poponload()
{
    testwindow = window.open("http://www.justcalluz.com", "mywindow", "location=1,status=1,scrollbars=1,width=500,height=500");
    testwindow.moveTo(400,-2000);
}
</script>
        </head>
<body onload="new Accordian('basic-accordian',5,'header_highlight');">
    <form id="aform2" runat="server">
    <asp:ScriptManager ID="ScriptManager2" runat="server">
                                </asp:ScriptManager> 
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
                    <table width="750px">
                    <tr>
                    <td>                      
                     <CTH:CTHeader ID="Cth1" runat="server" />
                    </td>
                    </tr> 
                    <tr><td height="5px"></td></tr>
                     <tr>
                            <td colspan="2" align="right">
                                 <a href="http://www.justcalluz.com/City%20trends_Main.aspx" target="_blank"> 
                           <img src="images/Click Here For SiteView.png"/>
                        </a>
                            </td>
                        </tr>          
                    <tr>
                        <td align="center" colspan="2">
                          <span style="font-size:21px; font-weight:bold; color:DarkBlue"> Update More Details of Category 
                              <asp:Label ID="lblHead" runat="server"></asp:Label>&nbsp; in City Trends </span> 
                        </td>
                      </tr>                     
                                                                   
                        <tr>
                            <td colspan="2">
                                <asp:Label ID="lblMessage" runat="server" ForeColor="OrangeRed" Font-Bold="true" Font-Size="Medium"></asp:Label>
                            </td>
                        </tr>  
                        <tr>
                            <td>
                                <asp:Label ID="lblrecords" runat="server" ForeColor="OrangeRed" Font-Bold="true" Font-Size="Medium"></asp:Label>                                
                            </td>
                        </tr>
                        <tr>
                            <td style="padding-left:50px; padding-right:50px;">
                               <table width="100%">
                                <tr id="trTitle" runat="server" height="40px">
                                    <td>
                                        More Information Title
                                    </td>
                                    <td>
                                        :
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtTitle" runat="server" Width="175px"></asp:TextBox> 
                                        <asp:RequiredFieldValidator ID="rfvTitle" runat="server" 
                                            ControlToValidate="txtTitle" ErrorMessage="Please enter title" 
                                            ValidationGroup="EditCTMoreInfo">*</asp:RequiredFieldValidator>
                                    </td>
                                </tr>
                                <tr>
                                    <td height="20px" colspan="3" align="right">
                                         <asp:ImageButton ID="imgBtnLink" runat="server" 
                                             ImageUrl="~/admin/images/link.gif" OnClientClick="getSelText();" onclick="imgBtnLink_Click"/>                
                                    </td>
                                </tr>
                                <tr id="trDesc" runat="server">
                                    <td valign="top">
                                        Description
                                    </td>
                                    <td valign="top">
                                        :
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtDesc" runat="server" TextMode="MultiLine" Width="450px" Height="300px"></asp:TextBox> 
                                         <asp:RequiredFieldValidator ID="rfvDesc" runat="server" 
                                            ControlToValidate="txtDesc" ErrorMessage="Please enter description" 
                                            ValidationGroup="EditCTMoreInfo">*</asp:RequiredFieldValidator>
                                    </td>
                                </tr>
                               </table> 
                            </td>
                        </tr>
                        <tr>
                            <td height="20px"></td>
                        </tr>
                        <tr>
                            <td colspan="3" align="center">
                                <asp:Button ID="BtnUpdateMore" runat="server" Text="Update" 
                                    
                                    ValidationGroup="EditCTMoreInfo" onclick="BtnUpdateMore_Click" />
                                     &nbsp; &nbsp;
                                <asp:Button ID="BtnCancel" runat="server" Text="Cancel"
                                 onclick="BtnCancel_Click"/>
                            </td>
                        </tr> 
                         <tr>            
            <td> 
             <input id="btnDummy" runat="server" type="button" style="display: none;" />
            <AjaxToolkit:ModalPopupExtender ID="ModalPopupExtender1" runat="server"  
         PopupControlID="modpopup1" BackgroundCssClass="modalBackground" TargetControlID="btnDummy"
        OkControlID="btnDummy" CancelControlID="btnDummy" BehaviorID="mpeBehavior"
        DropShadow="false" PopupDragHandleControlID="panel4"></AjaxToolkit:ModalPopupExtender>    
            <asp:Panel ID="modpopup1" runat="server" Width="430px" Height="276px">
        <fieldset style="width: 402px">
            <asp:Panel ID="Panel4" runat="server">
            </asp:Panel>
            
                <table align="center" width="400" height="30" style="background:green; border:width 1px color:white; font-size:13px;" >
                <tr style="background-color:Green;">
                    <td style="width:400px" align="center">
                       <span style="color:White;">To Insert/Edit Link <br /> &nbsp;</span>                        
                    </td>                           
                </tr>               
             </table>                
        
             <table align="center" width="400" style="background:white; height: 184px;" >               
                <tr>
                <td width="30%">
                 <asp:Label ID="lblId" runat="server" Visible="false"></asp:Label>
               Link URL            
                </td>
                <td>:</td>
                <td width="70%">
                    <asp:TextBox ID="txtLink" runat="server" Width="150px" 
                       ></asp:TextBox>                   
                </td>
                </tr>
                 <tr>
                <td width="30%">                
              Title        
                </td>
                <td>:</td>
                <td width="70%">
                    <asp:TextBox ID="txtLinkTitle" runat="server" Width="150px"></asp:TextBox>                   
                </td>
                </tr>
                <tr align="left" >
                    <td align="center" class="style4" colspan="3" style="padding-left:25px;">
                        <asp:Button ID="submitbutton" runat="server" Text="Submit"  
                             Width="62px" ValidationGroup="modal" 
                            OnClientClick="javascript:return validate();"/>
                    &nbsp;&nbsp;&nbsp;
                       <asp:Button ID="cancelbutton" runat="server" Text="Cancel" 
                             onclick="cancelbutton_Click" />
                    </td>
                </tr> 
                <tr>
                    <td colspan="3">                     
                    </td>
                </tr>               
            </table>
        </fieldset></asp:Panel>          
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
    </form>
</body>
</html>
