<%@ Page Language="C#" AutoEventWireup="true" CodeFile="gridview.aspx.cs" Inherits="gridview" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
            
                <table cellspacing="5" style="height: 564px; width: 574px; margin-left: 0px">
              <tr>
               <td align="right" colspan="3">
                   &nbsp;&nbsp;&nbsp;
               </td>
              </tr>
                <tr>
              <td class="adminform">Name</td>
              <td align="center"> &nbsp;&nbsp;:&nbsp;&nbsp;</td>
              <td>
              
   
              <asp:TextBox ID="txtname" runat="server" Width="186px"></asp:TextBox>
              
              
              
       
             <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" ControlToValidate="txtname">
              </asp:RequiredFieldValidator>
              </td>
              </tr>
              
              <tr>
              <td class="adminform">Category</td>
              <td align="center"> &nbsp;&nbsp;:&nbsp;&nbsp;</td>
              <td>
                  <asp:TextBox ID="TextBox1" runat="server" Width="187px"></asp:TextBox>
                  <asp:RequiredFieldValidator ID="reqf1" runat="server" ErrorMessage="*" ControlToValidate="TextBox1">
                      </asp:RequiredFieldValidator></td>
              </tr>
              
              <tr>
              <td class="adminform">Area</td>
              <td align="center">:</td>
              <td>
              <asp:TextBox ID="txtarea" runat="server" Width="187px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="reqf2" runat="server" ErrorMessage="*" ControlToValidate="txtarea">
              </asp:RequiredFieldValidator>
              </td>
              </tr>
              
              <tr>
              <td class="adminform">Phone</td>
              <td align="center">:</td>
              <td>
              <asp:TextBox ID="txtph" runat="server" Width="188px"></asp:TextBox>
              <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*" ControlToValidate="txtph">
              </asp:RequiredFieldValidator>
              </td>
              </tr>
              
               <tr>
              <td class="adminform">Mobile</td>
              <td align="center">:</td>
              <td>
              <asp:TextBox ID="txtmobile" runat="server" Width="186px"></asp:TextBox>
             <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="*" ControlToValidate="txtmobile">
              </asp:RequiredFieldValidator>
              </td>
              </tr>
              
             <tr>
              <td class="adminform">Address</td>
              <td align="center">:</td>
              <td>
              <asp:TextBox ID="txtaddr" runat="server" Width="197px" TextMode="MultiLine"></asp:TextBox>
              <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="*" ControlToValidate="txtaddr">
              </asp:RequiredFieldValidator>
              </td>
              </tr>
             
             <tr>
              <td class="adminform">State</td>
              <td align="center">:</td>
              <td>
              <asp:TextBox ID="txtstate" runat="server" Width="186px" ></asp:TextBox>
              <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="*" ControlToValidate="txtstate">
              </asp:RequiredFieldValidator>
              </td>
              </tr>
             
             
             <tr>
              <td class="adminform">Contact Person</td>
              <td align="center">:</td>
              <td>
              <asp:TextBox ID="txtcp" runat="server" Width="187px" ></asp:TextBox>
              <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="*" ControlToValidate="txtcp">
              </asp:RequiredFieldValidator>
              </td>
              </tr>
             
             
             <tr>
              <td class="adminform">Email</td>
              <td align="center">:</td>
              <td>
              <asp:TextBox ID="txtemail" runat="server" Width="189px" ></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="*" ControlToValidate="txtemail">
              </asp:RequiredFieldValidator>
              </td>
              </tr>
             
            
              <tr>
              <td class="adminform">City</td>
              <td align="center">:</td>
              <td>
              <asp:TextBox ID="txtcity" runat="server" Width="187px" ></asp:TextBox>
             <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ErrorMessage="*" ControlToValidate="txtcity">
              </asp:RequiredFieldValidator>
              </td>
              </tr>
             
             
             <tr>
              <td class="adminform">company Details</td>
              <td align="center">:</td>
              <td>
              <asp:TextBox ID="txtcomp" runat="server" Width="189px" ></asp:TextBox>
             <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ErrorMessage="*" ControlToValidate="txtcomp">
              </asp:RequiredFieldValidator>
              </td>
              </tr>
              
              <tr>
              <td></td>
              <td></td>
              <td align="center">
              <asp:Button ID="bt1" runat="server" Text="Submit" onclick="bt1submit_Click" 
                      style="height: 26px"  />
              <asp:Button ID="bt2" runat="server" Text="Reset" onclick="bt2reset_Click" 
                      style="height: 26px"  />
              </td>
              </tr>
              
              
              
              </table>
            
                <asp:GridView ID="GridView1" Runat="server" 
         DataSourceID="SqlDataSource" AutoGenerateColumns="False" AutoPostBack="true"
            AllowSorting="True" BorderWidth="1px" BackColor="White" CellPadding="4" 
            BorderStyle="None" BorderColor="#CC9966" DataKeyNames="id"
            AllowPaging="True" EnableSortingAndPagingCallbacks="True" 
            Font-Size="Small" AutoGenerateDeleteButton="True" 
            AutoGenerateEditButton="True">
            <FooterStyle ForeColor="#330099" 
               BackColor="#FFFFCC"></FooterStyle>
            <PagerStyle ForeColor="#330099" HorizontalAlign="Center" 
               BackColor="#FFFFCC"></PagerStyle>
            <HeaderStyle ForeColor="#FFFFCC" Font-Bold="True" 
               BackColor="#990000"></HeaderStyle>
            <Columns>
                <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" 
                    ReadOnly="True" SortExpression="id" />
                <asp:BoundField DataField="cname" HeaderText="cname" SortExpression="cname" />
                <asp:BoundField DataField="cat" HeaderText="cat" SortExpression="cat" />
                <asp:BoundField DataField="area" HeaderText="area" SortExpression="area" />
                <asp:BoundField DataField="ph" HeaderText="ph" SortExpression="ph" />
                <asp:BoundField DataField="mob" HeaderText="mob" SortExpression="mob" />
                <asp:BoundField DataField="city" HeaderText="city" SortExpression="city" />
                <asp:BoundField DataField="addr" HeaderText="addr" SortExpression="addr" />
                <asp:BoundField DataField="state" HeaderText="state" SortExpression="state" />
                <asp:BoundField DataField="conper" HeaderText="conper" 
                    SortExpression="conper" />
                <asp:BoundField DataField="email" HeaderText="email" SortExpression="email" />
                <asp:BoundField DataField="compdet" HeaderText="compdet" 
                    SortExpression="compdet" />
            </Columns>
            <SelectedRowStyle ForeColor="#663399" Font-Bold="True" 
                 BackColor="#FFCC66"></SelectedRowStyle>
            <RowStyle ForeColor="#330099" BackColor="White"></RowStyle>
        </asp:GridView>
            
            </ContentTemplate>
        
        </asp:UpdatePanel>
        
                
        <asp:SqlDataSource ID="SqlDataSource" runat="server" 
                ConnectionString="<%$ ConnectionStrings:sidardhConnectionString %>" 
                SelectCommand="SELECT * FROM [data]"
                UpdateCommand="UPDATE data SET cname = @cname, cat = @cat, area = @area, ph = @ph, mob = @mob, city = @city, addr = @addr, state = @state, conper = @conper, email = @email, compdet = @compdet where id= @id" 
                DeleteCommand="DELETE FROM data WHERE  id = @id">
        </asp:SqlDataSource>

                
        
        
        
                
       <font style="font-family:Berlin Sans FB; font-size:medium; color:#990000">You are viewing page
        <%=GridView1.PageIndex + 1%>
        of
        <%=GridView1.PageCount%>
        </font>
    </div>

    </form>
</body>
</html>
