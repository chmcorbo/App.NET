<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BuscaUsuario.aspx.cs" Inherits="CaveWeb.buscaUsuario" %>

<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Busca rápida de usuários</title>
    <link href="css/estilo.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
      #frmBuscaUsuario
      {
        width: 650px;
      }
      .style1
      {
        width: 302px;
      }
      .style2
      {
        width: 68px;
      }
      .style3
      {
        width: 97px;
      }
    </style>
</head>
<body>
    <form id="frmBuscaUsuario" runat="server">
    
    <asp:ScriptManager ID="ScriptManager1" runat="server">
      </asp:ScriptManager>
      
    <div style="width: 651px">
    
      
    
      <table class="tabela">
        <tr>
          <td class="style3">
            Nome do usuário:</td>
          <td class="style1">
            <asp:TextBox ID="txbNome" runat="server" CssClass="input_gdr"></asp:TextBox>
          </td>
          <td class="style2">
            <asp:ImageButton ID="ibtConsultar" runat="server" 
              ImageUrl="~/img/consultar_btn.gif" onclick="ibtConsultar_Click" />
          </td>
          <td>
            &nbsp;</td>
        </tr>
      </table>
    
      
    
    </div>
    <div>
    
      <telerik:RadGrid ID="RadGrid1" runat="server" AutoGenerateColumns="False" 
        GridLines="None" onselectedindexchanged="RadGrid1_SelectedIndexChanged" 
        Skin="Web20" AllowPaging="True" AllowSorting="True" PageSize="6">
<MasterTableView>
<RowIndicatorColumn Visible="False">
<HeaderStyle Width="20px"></HeaderStyle>
</RowIndicatorColumn>

<ExpandCollapseColumn Visible="False" Resizable="False">
<HeaderStyle Width="20px"></HeaderStyle>
</ExpandCollapseColumn>

  <Columns>
    <telerik:GridBoundColumn DataField="ID" HeaderText="ID" MaxLength="3" 
      UniqueName="column4" Visible="False">
    </telerik:GridBoundColumn>
    <telerik:GridBoundColumn DataField="LOGIN" HeaderText="Login" MaxLength="10" 
      UniqueName="column1">
    </telerik:GridBoundColumn>
    <telerik:GridButtonColumn CommandName="Select" DataTextField="NOME" 
      HeaderText="Nome" UniqueName="column">
    </telerik:GridButtonColumn>
    <telerik:GridBoundColumn DataField="NOME" HeaderText="Nome" MaxLength="50" 
      UniqueName="column2" Visible="False">
    </telerik:GridBoundColumn>
    <telerik:GridBoundColumn DataField="NOME_PERFIL" HeaderText="Perfil" MaxLength="30" 
      UniqueName="column3">
    </telerik:GridBoundColumn>
  </Columns>

<EditFormSettings>
<PopUpSettings ScrollBars="None"></PopUpSettings>
</EditFormSettings>
</MasterTableView>
      </telerik:RadGrid>
    
    </div>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
    </form>
</body>
</html>
