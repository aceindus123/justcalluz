<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Admin_ToEditCityTrends.aspx.cs" Inherits="admin_Admin_ToEditCityTrends" %>
<%@ Register Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" TagPrefix="cc3"  %>
<%@ Register Src="~/admin/user_control/Admin_Headermenu.ascx" TagName="Headermenu" TagPrefix="cc1" %>
<%@ Register Src="~/admin/user_control/Admin_LeftMenu.ascx" TagName="LeftMenu" TagPrefix="cc4" %>
<%@ Register Src="~/admin/user_control/Admin_CityTrendsHeader.ascx" TagName="CTHeader" TagPrefix="CTH" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="AjaxToolkit" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<title>Justcalluz - Admin Control Panel - Update City Trends</title>
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
        .style1
        {
            width: 211px;
        }
     .style23
     {
         width: 103px;
         height: 83px;
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

                  function confirm_delete(uid) {
                      if (confirm("Are you sure you want to delete this Movie?") == true)
                          document.location = 'Admin_DeleteMovies.aspx?mid=' + uid;
                      else
                          return false;
                  }
                  function alertdelete() {
                      alert("Selected Movie has been deleted Successfully");
                  }
                  function alertaccept() {
                      alert("Selected Classified has been Accepted");
                  }
    </script>
     <script language=javascript type="text/javascript">
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
             document.aform1.txtLinkTitle.value = txt;
         }

</script>
     <script type="text/javascript">
         function hide() {
             document.getElementById('modpopup4').style.visibility = 'hidden';
         }
         function show() {
             document.getElementById('modpopup4').style.visibility = 'visible';
         }
    </script>
     <script language=javascript type="text/javascript">
         function Inserlink() {
             var x = document.getElementById('txtLinkTitle').value;
             var y = document.getElementById('txtLink').value;
             document.getElementById('txtMoreInfoDesc').focus();
             document.getElementById('txtMoreInfoDesc').select();
             document.getElementById('txtMoreInfoDesc').value = document.getElementById('txtMoreInfoDesc').value.replace(x, (x.link(y)));
             hide();
         }

</script>	
        <script type="text/javascript" src="js/tab.js"></script>
        <script type="text/javascript">
            function poponload() {
                testwindow = window.open("http://www.justcalluz.com/City%20trends_Main.aspx", "mywindow", "location=1,status=1,scrollbars=1,width=500,height=500");
                testwindow.moveTo(400, -2000);
            }
</script>
<script type="text/javascript">
    function Alphabets(nkey) {
        var keyval
        if (navigator.appName == "Microsoft Internet Explorer") {
            keyval = window.event.keyCode;
        }
        else if (navigator.appName == 'Netscape') {
            nkeycode = nkey.which;
            keyval = nkeycode;
        }
        //For A-Z
        if (keyval >= 65 && keyval <= 90) {
            return true;
        }
        //For a-z
        else if (keyval >= 97 && keyval <= 122) {
            return true;
        }
        //For Backspace
        else if (keyval == 8) {
            return true;
        }
        //For General
        else if (keyval == 0) {
            return true;
        }
        //For Space
        else if (keyval == 32) {
            return true;
        }
        else {
            return false;
        }
    } // End of the function
  
 </script>
        </head>
<body onload="new Accordian('basic-accordian',5,'header_highlight');">
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">  </asp:ScriptManager>

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
                           <img src="images/Click Here For SiteView.png" alt="Main Site View"/>
                        </a>
                            </td>
                        </tr>    
                    <tr>
                        <td align="center" colspan="2">
                          <span style="font-size:21px; font-weight:bold; color:DarkBlue"> Update City Trends in the Category of
                              <asp:Label ID="lblModule" runat="server"></asp:Label>
                          </span> 
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
                        <tr><td height="20px"  colspan="2" align="right" style="padding-right:8px;">
                                  <asp:LinkButton ID="lnkBack" runat="server" Text="Back" PostBackUrl="Admin_CityTrends.aspx"></asp:LinkButton>
                        </td></tr> 
                        <tr>
                            <td style="padding-left:50px; padding-right:50px;">
                               <table width="100%">
                               <tr id="tr1" runat="server">
                                    <td class="adminform">
                                        City trends Module
                                    </td>
                                    <td>
                                        :
                                    </td>
                                    <td>
                                        <asp:DropDownList ID="ddlMod" runat="server" 
                                            onselectedindexchanged="ddlMod_SelectedIndexChanged" AutoPostBack="true" Width="175px">
                                        </asp:DropDownList>
                                        <asp:RequiredFieldValidator ID="rfvMod" runat="server" 
                                            ControlToValidate="ddlMod" ErrorMessage="Please select Module" 
                                            ValidationGroup="UpdateCityTrends" InitialValue="Select Module">*</asp:RequiredFieldValidator>
                                    </td>
                                </tr>
                                <tr id="trCat" runat="server" visible="false">
                                    <td class="adminform">
                                        City trends Category
                                    </td>
                                    <td>
                                        :
                                    </td>
                                    <td>
                                        <asp:DropDownList ID="ddlCat" runat="server" Width="175px" 
                                            onselectedindexchanged="ddlCat_SelectedIndexChanged" AutoPostBack="true">
                                        </asp:DropDownList>
                                         <asp:RequiredFieldValidator ID="rfvCat" runat="server" 
                                            ControlToValidate="ddlCat" ErrorMessage="Please select Category" 
                                            ValidationGroup="UpdateCityTrends" InitialValue="Select Category">*</asp:RequiredFieldValidator>
                                    </td>
                                </tr>
                                <tr id="trSubCat" runat="server" visible="false">
                                    <td class="adminform">
                                        City trends Sub Category
                                    </td>
                                    <td>
                                        :
                                    </td>
                                    <td>
                                        <asp:DropDownList ID="ddlSubCat" runat="server" Width="175px">
                                        </asp:DropDownList>
                                         <asp:RequiredFieldValidator ID="rfvSubCat" runat="server" 
                                            ControlToValidate="ddlSubCat" ErrorMessage="Please select Sub Category" 
                                            ValidationGroup="UpdateCityTrends" InitialValue="Select SubCategory">*</asp:RequiredFieldValidator>
                                    </td>
                                </tr>
                                <tr id="trState" runat="server">
                                    <td class="adminform">
                                       State 
                                    </td>
                                    <td>
                                        :
                                    </td>
                                    <td>
                                        <asp:DropDownList ID="ddlState" runat="server" 
                                            onselectedindexchanged="ddlState_SelectedIndexChanged" AutoPostBack="true" Width="175px">
                                        </asp:DropDownList>
                                         <asp:RequiredFieldValidator ID="rfvState" runat="server" 
                                            ControlToValidate="ddlState" ErrorMessage="Please select State" 
                                            ValidationGroup="UpdateCityTrends" InitialValue="Select State">*</asp:RequiredFieldValidator>
                                    </td>
                                </tr>
                                <tr id="trCity" runat="server">
                                    <td class="adminform">
                                      City
                                    </td>
                                    <td>
                                        :
                                    </td>
                                    <td>
                                        <asp:DropDownList ID="ddlCity" runat="server" 
                                            onselectedindexchanged="ddlCity_SelectedIndexChanged" AutoPostBack="true" Width="175px">
                                        </asp:DropDownList>
                                         <asp:RequiredFieldValidator ID="rfvCity" runat="server" 
                                            ControlToValidate="ddlCity" ErrorMessage="Please select City" 
                                            ValidationGroup="UpdateCityTrends" InitialValue="Select City">*</asp:RequiredFieldValidator>
                                    </td>
                                    
                                </tr>
                                <tr id="trTitle" runat="server" visible="false">
                                    <td class="adminform">
                                        Title
                                    </td>
                                    <td>
                                        :
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtTitle" runat="server" Width="175px"  onkeypress="return Alphabets(event);"></asp:TextBox> 
                                        <asp:RequiredFieldValidator ID="rfvTitle" runat="server" 
                                            ControlToValidate="txtTitle" ErrorMessage="Please enter title" 
                                            ValidationGroup="UpdateCityTrends">*</asp:RequiredFieldValidator>
                                    </td>
                                </tr>
                                <tr id="trList" runat="server">
                                    <td class="adminform">
                                        Select Top
                                        <asp:Label ID="lblselecttop" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        :
                                    </td>
                                    <td>
                                        <asp:ListBox ID="lstCompNames" runat="server" Width="180px" 
                                            SelectionMode="Multiple" 
                                           ></asp:ListBox> 
                                        <asp:CustomValidator ID="CustomValidator1" runat="server" 
                                            ErrorMessage="Please select 5 items only." Display="Dynamic" 
                                            onservervalidate="CustomValidator1_ServerValidate" 
                                            ValidationGroup="UpdateCityTrends"></asp:CustomValidator>
                                        <asp:Label ID="lblInfo" runat="server"></asp:Label>
                                         <%--<asp:RequiredFieldValidator ID="rfvList" runat="server" 
                                            ControlToValidate="lstCompNames" ErrorMessage="Please select" 
                                            ValidationGroup="UpdateCityTrends">*</asp:RequiredFieldValidator>--%>
                                    </td>
                                </tr>
                                <tr id="trddlList" runat="server" visible="false">
                                    <td class="adminform">
                                        Select 
                                        <asp:Label ID="lbl" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        :
                                    </td>
                                    <td>
                                        <asp:DropDownList ID="ddlCompNames" runat="server" Width="175px">
                                        </asp:DropDownList>
                                        <asp:RequiredFieldValidator ID="rfvddlcompname" runat="server" 
                                            ControlToValidate="ddlCompNames" ErrorMessage="Please select company name" 
                                            ValidationGroup="UpdateCityTrends">*</asp:RequiredFieldValidator>
                                    </td>
                                </tr>
                                <tr id="trArea" runat="server">
                                    <td class="adminform">                                       
                                        Area of the Listing held
                                    </td>
                                    <td>
                                        :
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtArea" runat="server" Width="173"></asp:TextBox> 
                                         <asp:RequiredFieldValidator ID="rfvArea" runat="server" 
                                            ControlToValidate="txtArea" ErrorMessage="Please enter description" 
                                            ValidationGroup="PostCityTrends">*</asp:RequiredFieldValidator>
                                    </td>
                                </tr>
                                <tr id="trGDesc" runat="server">
                                    <td class="adminform">
                                    <asp:Label ID="lblcompdesc" runat="server"></asp:Label>
                                        Description
                                    </td>
                                    <td>
                                        :
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtDesc" runat="server" TextMode="MultiLine" Width="400px" Height="200px"></asp:TextBox> 
                                         <asp:RequiredFieldValidator ID="rfvDesc" runat="server" 
                                            ControlToValidate="txtDesc" ErrorMessage="Please enter description" 
                                            ValidationGroup="UpdateCityTrends">*</asp:RequiredFieldValidator>
                                    </td>
                                </tr>                                                                                  
                               </table> 
                            </td>
                        </tr>
                        <tr>
                            <td colspan="3" align="center">
                            <asp:Button ID="btnUpdate" runat="server" Text="Update" 
                              style="height: 26px"  OnClick="btnUpdate_Click" ValidationGroup="UpdateCityTrends"  /> &nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:Button ID="btnCancel" runat="server" Text="Cancel"
                               style="height: 26px" OnClick="btnCancel_Click"   />
                            </td>
                        </tr> 
                        <tr><td height="20px"></td></tr> 
                         <tr>
                            <td align="center">
                                <asp:Label ID="lblDisplay" runat="server" ForeColor="Magenta" Font-Bold="true" Font-Size="Large"></asp:Label>
                            </td>
                         </tr> 
                         <tr>
                            <td height="10px"></td>
                        </tr>                         
                        <tr>
                            <td height="20px" align="center">
                                <asp:Label ID="lbldis" runat="server"></asp:Label>&nbsp;
                                <asp:LinkButton ID="lnkMoreInfo" runat="server" Font-Bold="true" 
                                    Font-Size="Medium" ForeColor="Blue" onclick="lnkMoreInfo_Click">Click here to add more information</asp:LinkButton>
                            </td>
                        </tr> 
                       
                        <tr>
                            <td style="padding-left:7px;">
                                <asp:DataList ID="dlMovieDetails" runat="server" Width="100%" >
                                    <ItemTemplate>
                                        <table width="100%" border="0px">
                                            <tr>
                                                <td>                                                                                                                                                         
                                                    <asp:Label ID="Label1" runat="server" Text='<%#Eval("Movie_Name") %>' ForeColor="#33CCFF"></asp:Label>&nbsp;:&nbsp;                                                                                                   
                                                    <asp:Label ID="Label2" runat="server" Text='<%#Eval("Movie_Desc") %>' ForeColor="Black"></asp:Label>                                                                                                     
                                                </td>                                                
                                            </tr>
                                            <tr>
                                                <td align="center">
                                                    <asp:LinkButton ID="lnkBtnEdit" runat="server" Font-Bold="false" ForeColor="Blue" Font-Underline="false" Text="Click here to edit Movie Description" CommandArgument='<%#Eval("Movie_Name") +","+ Eval("Movie_Language")+","+ Eval("Movie_Desc") %>' OnCommand="lnkEditMovieDescription"></asp:LinkButton> 
                                                </td>
                                            </tr>
                                            <tr>
                                                <td height="10px">
                                                   
                                                </td>
                                            </tr>
                                        </table>
                                    </ItemTemplate>
                                </asp:DataList>
                            </td>
                        </tr>
                        <tr>
                            <td style="padding-left:7px;">
                                <asp:DataList ID="dlBusinesDetails" runat="server" Width="100%">
                                    <ItemTemplate>
                                        <table width="100%" border="0px">
                                            <tr>
                                                <td>                                                                                                                                                                                                             
                                                    <asp:Label ID="lblBusCompName" runat="server" Text='<%#Eval("company_name") %>' ForeColor="#33CCFF"></asp:Label>&nbsp;:&nbsp;                                                                                                   
                                                    <asp:Label ID="lblBusCompProfile" runat="server" Text='<%#Eval("company_profile") %>' ForeColor="Black"></asp:Label> 
                                                </td>                                                
                                            </tr>
                                            <tr>
                                                <td align="center">
                                                    <asp:LinkButton ID="lnkBtnEditBusDesc" runat="server" Font-Bold="false" ForeColor="Blue" Font-Underline="false" Text="Edit Company Profile" CommandArgument='<%#Eval("id")%>' OnCommand="lnkEditBusinessDescription"></asp:LinkButton> 
                                                </td>                                                
                                            </tr>
                                            <tr><td height="10px"></td></tr>
                                        </table>
                                    </ItemTemplate>
                                </asp:DataList>
                            </td>
                        </tr>    
                        <tr>
                            <td style="padding-left:7px;border:1px dotted Black;">
                                <asp:DataList ID="dlOtherCatDetails" runat="server" Width="100%">
                                    <ItemTemplate>
                                        <table width="100%" border="0px">
                                            <tr>
                                                <td width="85%">                                                                                                                                                         
                                                    <asp:Label ID="lblMoreTitle" runat="server" Text='<%#Eval("MTitle") %>' ForeColor="#cc3300" Font-Bold="true" Font-Size="20px"></asp:Label>                 
                                                </td>  
                                                <td width="15%">
                                                  <asp:LinkButton ID="lnkBtnEditMInfo" runat="server" Font-Bold="false" ForeColor="Blue" Font-Underline="false" Text="Edit More Info" CommandArgument='<%#Eval("ctMoreid")%>' OnCommand="lnkEditMoreInfo"></asp:LinkButton>   
                                                </td>                                              
                                            </tr>
                                            <tr><td height="10px"></td></tr>
                                            <tr>
                                                <td colspan="2">                                                                                                                                                         
                                                    <asp:Label ID="lblMoreInfo" runat="server" Text='<%#Eval("MInfo") %>' ForeColor="Black"></asp:Label>                 
                                                </td>                                                
                                            </tr>
                                            <tr><td height="10px"></td></tr>
                                        </table>
                                    </ItemTemplate>
                                </asp:DataList>
                            </td>
                        </tr>    
                        <tr>
                            <td>
                            <input id="btnDummy" runat="server" type="button" style="display: none;" />
                                <AjaxToolkit:ModalPopupExtender ID="ModalPopupExtender1" runat="server"  
             PopupControlID="modpopup1" BackgroundCssClass="modalBackground" TargetControlID="btnDummy"
            OkControlID="btnDummy" CancelControlID="btnDummy"
            DropShadow="false" PopupDragHandleControlID="panel4"></AjaxToolkit:ModalPopupExtender>    
                                <asp:Panel ID="modpopup1" runat="server" Width="430px" Height="276px">
                                    <fieldset style="width: 402px">
                <asp:Panel ID="Panel4" runat="server">
                </asp:Panel>            
                    <table align="center" width="400" height="30" style="background:green; border:width 1px color:white; font-size:13px;" >
                    <tr style="background-color:Green;">
                        <td style="width:400px" align="center">
                           <span style="color:White">To Edit description for <asp:Label ID="lblMovieName" runat="server"></asp:Label> <br /> &nbsp;</span>                       
                           <asp:Label ID="lblMLang" runat="server" Visible="false"></asp:Label>       
                        </td>                               
                    </tr>                             
                 </table>                          
                 <table align="center" width="400" style="background:white; height: 184px;" >               
                   <tr>
                    <td width="100%">
                        <asp:TextBox ID="txtMoviedesc" runat="server" Width="370px" Height="170px" TextMode="MultiLine"></asp:TextBox>                        
                    </td>
                    </tr>
                    <tr>
                        <td align="center">
                            <asp:RequiredFieldValidator ID="rfvMoviDesc" runat="server" 
                            ErrorMessage="Please enter Movie Description" 
                            ControlToValidate="txtMoviedesc" ValidationGroup="moviedesc"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr align="left" style="margin-left:5px">
                        <td align="center">
                            <asp:Button ID="btnMDescSubmit" runat="server" Text="Submit"  />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Button ID="btnMDescCancel" runat="server" Text="Cancel" onclick="btnMDescCancel_Click" />
                        </td>
                    </tr>                                 
                </table>
            </fieldset>
                                </asp:Panel> 
                            </td>
                        </tr>  
                        <tr>
                            <td>
                             <input id="btnDummy1" runat="server" type="button" style="display: none;" />
                                <AjaxToolkit:ModalPopupExtender ID="ModalPopupExtender2" runat="server"  
             PopupControlID="modpopup2" BackgroundCssClass="modalBackground" TargetControlID="btnDummy1"
            OkControlID="btnDummy1" CancelControlID="btnDummy1"
            DropShadow="false" PopupDragHandleControlID="panel2"></AjaxToolkit:ModalPopupExtender>    
                                <asp:Panel ID="modpopup2" runat="server" Width="430px" Height="276px">
                                    <fieldset style="width: 402px">
                <asp:Panel ID="Panel2" runat="server">
                </asp:Panel>            
                    <table align="center" width="400" height="30" style="background:green; border:width 1px color:white; font-size:13px;" >
                    <tr style="background-color:Green;">
                        <td style="width:400px" align="center">
                           <span style="color:White">To Edit description for <asp:Label ID="lblbName" runat="server"></asp:Label> <br /> &nbsp;</span>                       
                           <asp:Label ID="lblbId" runat="server" Visible="false"></asp:Label>       
                        </td>                               
                    </tr>                             
                 </table>                          
                 <table align="center" width="400" style="background:white; height: 184px;" >               
                   <tr>
                    <td width="100%">
                        <asp:TextBox ID="txtBusDescription" runat="server" Width="370px" Height="170px" TextMode="MultiLine"></asp:TextBox>                        
                    </td>
                    </tr>
                    <tr>
                        <td align="center">
                            <asp:RequiredFieldValidator ID="rfvBDesc" runat="server" 
                                ErrorMessage="Please enter Company Profile" 
                                ControlToValidate="txtBusDescription" ValidationGroup="busdesc"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr align="left" style="margin-left:5px">
                        <td align="center">
                            <asp:Button ID="btnBProfileSubmit" runat="server" Text="Submit" 
                                ValidationGroup="busdesc" Width="62px" onclick="btnBProfileSubmit_Click"  />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Button ID="btnBProfileCancel" runat="server" Text="Cancel" onclick="btnBProfileCancel_Click" />
                        </td>
                    </tr>                                  
                </table>
            </fieldset>
                                </asp:Panel> 
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
