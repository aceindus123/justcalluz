<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Search.ascx.cs" Inherits="usercontrols_Search" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="AjaxToolkit" %>

  <%--/* Autocomplete extender code */--%>
<%-- <link href="http://ajax.googleapis.com/ajax/libs/jqueryui/1.8.1/themes/base/jquery-ui.css" rel="stylesheet" type="text/css"/>--%>
 <%--   <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.4.2/jquery.min.js"></script>
    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jqueryui/1.8.1/jquery-ui.min.js"></script>  
<link href="css/jquery-ui.css" rel="stylesheet" type="text/css" />--%>

   <%-- <script type="text/javascript" language="javascript">
        $(function () {
            $(".tblsci").autocomplete({
                source: function (request, response) {
                    $.ajax({
                        url: "AreasList.asmx/FetchCitiesList",
                        data: "{ 'city': '" + request.term + "' }",
                        dataType: "json",
                        type: "POST",
                        contentType: "application/json; charset=utf-8",
                        dataFilter: function (data) { return data; },
                        success: function (data) {
                            response($.map(data.d, function (item) {
                                return {
                                    value: item.Cityname
                                }
                            }))
                        },
                        error: function (XMLHttpRequest, textStatus, errorThrown) {
                            alert(textStatus);
                        }
                    });
                },
                minLength: 2
            });
        });
        </script>
    <script type="text/javascript" language="javascript">
        $(function () {
            $(".tblarea1").autocomplete({
                source: function (request, response) {
                    $.ajax({
                        url: "AreasList.asmx/FetchAreasList",
                        // data: "{ 'area': '" + request.term + "'}",
                        data: "{ 'area': '" + request.term + "' ," +
                          "'City': '" + $('.tblsci').val() + "'}",
                        //                        City: "{ 'City': '" + $('#txtSelectCity').val() + "' }",
                        dataType: "json",
                        type: "POST",
                        contentType: "application/json; charset=utf-8",
                        dataFilter: function (data) { return data; },
                        success: function (data) {
                            response($.map(data.d, function (item) {
                                return {
                                    value: item.areaname
                                }
                            }))
                        },
                        error: function (XMLHttpRequest, textStatus, errorThrown) {
                            alert(textStatus);
                        }
                    });
                },
                minLength: 2
            });
        });
        </script>
    <script type="text/javascript" language="javascript">
        $(function () {
            $(".tblsearch").autocomplete({
                source: function (request, response) {
                   // var status = $('#rdbcheck').is(':checked');
                    ////var status = $('#rb1comp').attr('checked') ? true : false;
                    var status= $('[name$="r1"]:radio:checked').val();
                    if (status == null)
                    {
                       alert('Please check company name or Category');
                      
                    }
                    //else
                    //{
                    //    alert(status);
                    //}
                   
                    $.ajax({
                        url: "AreasList.asmx/FetchSearchList",
                        data: "{ 'sear': '" + request.term + "' ," +
                          "'City': '" + $('.tblsci').val() + "' ," +
                           "'Type':'" + status + "'}",
                        //City: "{ 'City': '" + $('#txtSelectCity').val() + "' }",
                        dataType: "json",
                        type: "POST",
                        contentType: "application/json; charset=utf-8",
                        dataFilter: function (data) { return data; },
                        success: function (data) {
                            response($.map(data.d, function (item) {
                                return {
                                    value: item.searchn
                                }
                            }))
                        },
                        error: function (XMLHttpRequest, textStatus, errorThrown) {
                       alert(errorThrown);
                        }
                    });
                        
                },
                minLength: 2
            });
        });

                    //alert(status)
    </script>--%>
    <script type="text/javascript" language="javascript">
        function emptytxt(cntrls) {
            cntrls.value = "";
        }
    </script>
<%--/* web service for autocomplete*/--%>
<script src="http://ajax.googleapis.com/ajax/libs/jquery/1.4/jquery.min.js"

type = "text/javascript"></script> 

<script src="http://ajax.googleapis.com/ajax/libs/jqueryui/1.8/jquery-ui.min.js"

type = "text/javascript"></script> 

<%--<link href="http://ajax.googleapis.com/ajax/libs/jqueryui/1.8/themes/base/jquery-ui.css" 

rel = "Stylesheet" type="text/css" />--%> 
<link href="css/jquery-ui.css" rel="stylesheet" type="text/css" />

<script type="text/javascript">

    $(document).ready(function () {

        $("#<%=txtSearchFor.ClientID %>").autocomplete({

            source: function (request, response) {
                var status = $('[name$="r1"]:radio:checked').val();

                $.ajax({

                    url: '<%=ResolveUrl("~/WebService.asmx/GetCategories") %>',

                    data: "{ 'prefix': '" + request.term + "',"+
                     "'City': '" + $('.tblsci').val() + "' ,"+
                     "'Type':'" + status + "'}",

                    dataType: "json",

                    type: "POST",

                    contentType: "application/json; charset=utf-8",

                    success: function (data) {

                        response($.map(data.d, function (item) {

                            return {
                               // label:item[0]

                                label: item.split('-')[0],

                                //val: item.split('-')[1]

                            }

                        }))

                    },

                    error: function (response) {

                        alert(response.responseText);

                    },

                    failure: function (response) {

                        alert(response.responseText);

                    }

                });

            },

            select: function (e, i) {

                $("#<%=hfCustomerId.ClientID %>").val(i.item.val);

            },

            minLength: 1

        });

    });

    $(document).ready(function () {

        $("#<%=txtSelectCity.ClientID %>").autocomplete({

             source: function (request, response) {

                 $.ajax({

                     url: '<%=ResolveUrl("~/WebService.asmx/GetCities") %>',

                    data: "{ 'prefix': '" + request.term + "'}",

                    dataType: "json",

                    type: "POST",

                    contentType: "application/json; charset=utf-8",

                    success: function (data) {

                        response($.map(data.d, function (item) {

                            return {

                                label: item.split('-')[0]

                                //val: item.split('-')[1]

                            }

                        }))

                    },

                    error: function (response) {

                        alert(response.responseText);

                    },

                    failure: function (response) {

                        alert(response.responseText);

                    }

                });

            },

            select: function (e, i) {

                $("#<%=hfCustomerId.ClientID %>").val(i.item.val);

            },

            minLength: 1

        });

    });
    $(document).ready(function () {

        $("#<%=txtWhereIn.ClientID %>").autocomplete({

                source: function (request, response) {

                    $.ajax({

                        url: '<%=ResolveUrl("~/WebService.asmx/GetAreas") %>',

                    data: "{ 'prefix': '" + request.term + "'," +
                     "'City': '" + $('.tblsci').val() + "'}",

                    dataType: "json",

                    type: "POST",

                    contentType: "application/json; charset=utf-8",

                    success: function (data) {

                        response($.map(data.d, function (item) {

                            return {

                                label: item.split('-')[0]

                                //val: item.split('-')[1]

                            }

                        }))

                    },

                    error: function (response) {

                        alert(response.responseText);

                    },

                    failure: function (response) {

                        alert(response.responseText);

                    }

                });

            },

            select: function (e, i) {

                $("#<%=hfCustomerId.ClientID %>").val(i.item.val);

            },

            minLength: 1

        });

        });

</script>

    <%--/* Autocomplete extender code */--%>

<asp:UpdatePanel ID="UpdatePanel1" runat="server" ChildrenAsTriggers="true">
    <ContentTemplate>
         <asp:HiddenField ID="hfCustomerId" runat="server" />
<table width="100%" border="0">
  <tr>
    <td width="25%" align="left"><strong>City</strong></td>
    <td width="3%">&nbsp;</td>
    <td width="44%" height="20" align="left">
    <table width="100%" border="0">
      <tr>
        <td width="20%" height="20"><strong>Search for&nbsp;&nbsp;&nbsp;</strong></td>
        <td width="5%" align="right"><strong>
          <asp:RadioButton ID="rb1comp" runat="server" GroupName="r1" AutoPostBack="true" Text="." ForeColor="White"/>
           <%-- <input type="radio" id="rdbcheck" value="India" name="r1"/>India--%>
        </strong></td>
        <td width="34%" align="left"><strong>Company Name&nbsp;&nbsp;</strong></td>
        <td width="5%" align="right"><strong>
           <asp:RadioButton ID="rb2cat" runat="server" GroupName="r1" Checked="true" AutoPostBack="true" Text="." ForeColor="White"/>
        </strong></td>
        <td width="46%" align="left"><strong>Category</strong></td>
      </tr>
    </table>
     
    </td>
    <td width="2%">&nbsp;</td>
    <td width="36%" align="left"><strong><asp:Label ID="lblarea" runat="server" Width="200px" Height="20px" Text="Where in City?"></asp:Label></strong></td>
    <td width="2%">&nbsp;</td>
    <td width="4%">&nbsp;</td>

  <asp:ValidationSummary ID="ValSumSearch" runat="server" ShowMessageBox="True" 
            ShowSummary="False" ValidationGroup="SearchGroup" />
              </tr>
  <tr>
    <td valign="top">
     <asp:TextBox ID="txtSelectCity" runat="server" Height="30px" Width="200px"  AutoPostBack="true" CssClass="tblsci"></asp:TextBox>    
     <AjaxToolkit:TextBoxWatermarkExtender ID="txtcitywater" runat="server" TargetControlID="txtSelectCity" WatermarkText="Enter City" WatermarkCssClass="water1"></AjaxToolkit:TextBoxWatermarkExtender>
    <td>&nbsp;</td>
    <td><asp:TextBox ID="txtSearchFor" runat="server" Width="387px"  Height="30px"></asp:TextBox>
         <AjaxToolkit:TextBoxWatermarkExtender ID="TWEtxtSearchFor" runat="server" TargetControlID="txtSearchFor" WatermarkText="Enter companyname or category" WatermarkCssClass="water1"></AjaxToolkit:TextBoxWatermarkExtender>
      <a href="<%$RouteUrl:RouteName=N_Search%>" runat="server">National Search</a>&nbsp; |&nbsp;
    <asp:LinkButton 
            ID="adv_search" runat="server" Text="Advanced Search" 
            OnClick="adv_search_Click"></asp:LinkButton>
    <asp:RequiredFieldValidator ID="rfvSearchFor" runat="server" 
        ErrorMessage="Please enter a keyword to search" 
        ControlToValidate="txtSearchFor" ValidationGroup="SearchGroup">*</asp:RequiredFieldValidator>
    <td>&nbsp;</td>
    <td valign="top">
    <asp:TextBox ID="txtWhereIn" runat="server" Width="230px"  Height="30px"></asp:TextBox>
    <br />
    <asp:CheckBox ID="chkremember" runat="server" Text="Remember My Location" />
         <AjaxToolkit:TextBoxWatermarkExtender ID="txttxtWhereIn" runat="server" TargetControlID="txtWhereIn" WatermarkText="Enter area" WatermarkCssClass="water1"></AjaxToolkit:TextBoxWatermarkExtender>
    <td>&nbsp;</td>
    <td align="left" valign="top"><asp:ImageButton ID="BtnSearch" runat="server" ImageUrl="../images/go.jpg" 
            onclick="BtnSearch_Click" 
            ValidationGroup="SearchGroup" /></td>
  </tr>
</table>
</ContentTemplate>
    </asp:UpdatePanel>
 
   
  