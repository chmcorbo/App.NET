<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CFuelWeb._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div> 
      <h1 style="text-align: center"> CFuel - Controle de Abastecimento </h1>
    </div>
    <div> 
      <h2 style="text-align: left"> Consulta </h2>
    </div>
    
    <div>
    
      <asp:Button ID="BtnBuscar" runat="server" onclick="Button1_Click" 
        Text="Buscar" />
      <asp:Button ID="BtnNovo" runat="server" Text="Novo" onclick="BtnNovo_Click" />
      <br />
      <br />
      <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        DataSourceID="ObjectDataSource1" AllowPaging="True" CellPadding="4" 
        ForeColor="#333333" GridLines="None">
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <Columns>
          <asp:HyperLinkField DataNavigateUrlFields="ID" 
            DataNavigateUrlFormatString="pgAbastecimento.aspx?op=A&amp;id={0}" 
            DataTextField="ID" Text="Identificação" />
          <asp:BoundField DataField="data_abastec" HeaderText="Data" 
            SortExpression="data_abastec" DataFormatString="{0:dd/MM/yyyy}" />
          <asp:BoundField DataField="hora_abastec" HeaderText="Hora" 
            SortExpression="hora_abastec" DataFormatString="{0:hh:mm}" />
          <asp:BoundField DataField="km" HeaderText="Km" SortExpression="km" 
            DataFormatString="{0:D}" >
          <HeaderStyle HorizontalAlign="Center" />
          <ItemStyle HorizontalAlign="Right" />
          </asp:BoundField>
          <asp:BoundField DataField="litragem" HeaderText="Litragem" 
            SortExpression="litragem" DataFormatString="{0:N2}" >
          <HeaderStyle HorizontalAlign="Center" />
          <ItemStyle HorizontalAlign="Right" />
          </asp:BoundField>
          <asp:BoundField DataField="km_litro" HeaderText="KM / Lt" 
            SortExpression="km_litro" DataFormatString="{0:N2}" >
          <HeaderStyle HorizontalAlign="Center" />
          <ItemStyle HorizontalAlign="Right" />
          </asp:BoundField>
          <asp:BoundField DataField="valor_unit" HeaderText="Valor Unitário" 
            SortExpression="valor_unit" DataFormatString="{0:C2}" >
          <HeaderStyle HorizontalAlign="Center" />
          <ItemStyle HorizontalAlign="Right" />
          </asp:BoundField>
          <asp:BoundField DataField="valor_total" HeaderText="Valor Total" 
            SortExpression="valor_total" DataFormatString="{0:C2}" >
          <HeaderStyle HorizontalAlign="Center" />
          <ItemStyle HorizontalAlign="Right" />
          </asp:BoundField>
          <asp:BoundField DataField="observacao" HeaderText="Observação" 
            SortExpression="observacao" />
        </Columns>
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <EditRowStyle BackColor="#999999" />
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
      </asp:GridView>
      <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
        DataObjectTypeName="CFuelCorboLib.dominio.Abastecimento" SelectMethod="getList" 
        TypeName="CFuelWeb.Facade.DAOFacadeAbastecimento"></asp:ObjectDataSource>
      <br />
    
    </div>
    </form>
</body>
</html>
