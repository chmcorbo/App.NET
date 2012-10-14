<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebDataBinds._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
      <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Button" />
      <br />
      <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" 
        CellPadding="3" GridLines="Vertical">
        <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
        <Columns>
          <asp:BoundField DataField="id" HeaderText="id" SortExpression="id" />
          <asp:BoundField DataField="nome" HeaderText="nome" SortExpression="nome" />
          <asp:BoundField DataField="ramal" HeaderText="ramal" SortExpression="ramal" />
          <asp:BoundField DataField="data_cadastro" DataFormatString="{0:dd/MM/yyyy}" 
            HeaderText="data_cadastro" SortExpression="data_cadastro" />
          <asp:BoundField DataField="hora_cadastro" HeaderText="hora_cadastro" 
            SortExpression="hora_cadastro" />
        </Columns>
        <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
        <AlternatingRowStyle BackColor="#DCDCDC" />
      </asp:GridView>
      <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
        DataObjectTypeName="WebDataBinds.Model.Funcionario" SelectMethod="listar" 
        TypeName="WebDataBinds.DAO.DAOFuncionario"></asp:ObjectDataSource>
    
    </div>
    </form>
</body>
</html>
