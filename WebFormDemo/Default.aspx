<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebFormDemo.Default" %>



  

   

<form id="form1" runat="server">
    <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Height="165px" Width="100%" style="text-align: left" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
        <AlternatingRowStyle BackColor="White" />
        <EditRowStyle BackColor="#2461BF" />
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#EFF3FB" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F5F7FB" />
        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
        <SortedDescendingCellStyle BackColor="#E9EBEF" />
        <SortedDescendingHeaderStyle BackColor="#4870BE" />
    </asp:GridView>
    <br />
    <asp:Button ID="GetData" runat="server" Text="Refresh" OnClick="GetData_Click" />
    <p>
        &nbsp;</p>
    <p>
        <asp:Label ID="Label1" runat="server" Text="Insert Data"></asp:Label>
    </p>
    <p>
        <asp:TextBox ID="TextBoxName" placeholder="Enter Name" runat="server" OnTextChanged="TextBoxName_TextChanged"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBoxDescription" placeholder="Enter Description"  runat="server" OnTextChanged="TextBoxDescription_TextChanged"></asp:TextBox>
    &nbsp;&nbsp;
        <asp:TextBox ID="TextBoxAmount" placeholder="Enter Amount"  runat="server" OnTextChanged="TextBoxAmount_TextChanged"></asp:TextBox>
    &nbsp;&nbsp;
        <asp:TextBox ID="TextBoxTC" placeholder="Enter Term & Condittion"  runat="server" OnTextChanged="TextBoxTC_TextChanged"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="InsertData" runat="server" Text="Insert" OnClick="InsertData_Click" />
    </p>
    <p>
        &nbsp;</p>
    <asp:Label ID="Label2" runat="server" Text="Update Data"></asp:Label>
    <p>
        <asp:TextBox ID="TextBoxUpdateId" placeholder="Enter ID"  runat="server" OnTextChanged="TextBoxUpdateId_TextChanged"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBoxUpdateName" placeholder="Enter Name"  runat="server" OnTextChanged="TextBoxUpdateName_TextChanged"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBoxUpdateDescription" placeholder="Enter Description"  runat="server" OnTextChanged="TextBoxUpdateDescription_TextChanged"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBoxUpdateAmount" placeholder="Enter Amount"  runat="server" OnTextChanged="TextBoxUpdateAmount_TextChanged"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBoxUpdateTC" placeholder="Enter Term & Condittion" runat="server" OnTextChanged="TextBoxUpdateTC_TextChanged"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="UpdateData" runat="server" Text="Update" OnClick="UpdateData_Click" />
    </p>
    <p>
        &nbsp;</p>
    <asp:Label ID="Label3" runat="server" Text="Delete Data"></asp:Label>
    &nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBoxDeleteId" placeholder="Enter ID" runat="server" OnTextChanged="TextBoxDeleteId_TextChanged"></asp:TextBox>
    <br />
    <br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
    <asp:Button ID="DeleteDasta" runat="server" Text="Delete" OnClick="DeleteData_Click"  />
    <br />
</form>




  

   

