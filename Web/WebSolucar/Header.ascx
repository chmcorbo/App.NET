<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Header.ascx.cs" Inherits="WebUserControl" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<telerik:RadMenu ID="RadMenu1" Runat="server" Skin="Vista" Font-Size="Medium" 
  onitemclick="RadMenu1_ItemClick" 
  style="top: 0px; left: 0px; height: 30px; width: 634px">
<CollapseAnimation Type="OutQuint" Duration="200"></CollapseAnimation>
  <Items>
    <telerik:RadMenuItem runat="server" PostBack="False" Text="Home" 
      ToolTip="Página inicial da aplicação" Value="Home">
    </telerik:RadMenuItem>
    <telerik:RadMenuItem runat="server" PostBack="False" Text="Cadastros" 
      ToolTip="Cadastros gerais" Value="Cadastros">
      <Items>
        <telerik:RadMenuItem runat="server" Text="Função" 
          ToolTip="Funções/Cargos dos funcionários da empresa" Value="Funcao">
        </telerik:RadMenuItem>
        <telerik:RadMenuItem runat="server" Text="Funcionário" 
          ToolTip="Funcionários da empresa" Value="Funcionário">
        </telerik:RadMenuItem>
        <telerik:RadMenuItem runat="server" IsSeparator="True" Value="Separador2">
        </telerik:RadMenuItem>
        <telerik:RadMenuItem runat="server" Text="Fornecedor" 
          ToolTip="Postos de combustível credenciados" Value="Fornecedor">
        </telerik:RadMenuItem>
        <telerik:RadMenuItem runat="server" IsSeparator="True" PostBack="False" 
          Value="Separador1">
        </telerik:RadMenuItem>
        <telerik:RadMenuItem runat="server" Text="Marca" ToolTip="Marca de veículos" 
          Value="Marca">
        </telerik:RadMenuItem>
        <telerik:RadMenuItem runat="server" Text="Modelo" ToolTip="Modelos de Veículos" 
          Value="Modelo">
        </telerik:RadMenuItem>
        <telerik:RadMenuItem runat="server" Text="Veículo" 
          ToolTip="Veículos da empresa" Value="Veiculo">
        </telerik:RadMenuItem>
      </Items>
    </telerik:RadMenuItem>
    <telerik:RadMenuItem runat="server" PostBack="False" Text="Autorização" 
      ToolTip="Autorização de Abastecimentos" Value="Autorizacao">
      <Items>
        <telerik:RadMenuItem runat="server" Text="Cota mensal" 
          ToolTip="Cota de abastecimentos mensal" Value="Cota_Mensal">
        </telerik:RadMenuItem>
        <telerik:RadMenuItem runat="server" Text="Cota Extra" 
          ToolTip="Cota de combustível extra" Value="Cota_extra">
        </telerik:RadMenuItem>
      </Items>
    </telerik:RadMenuItem>
    <telerik:RadMenuItem runat="server" PostBack="False" Text="Lançamento" 
      ToolTip="Lançamento de abastecimentos" Value="Lancamento">
      <Items>
        <telerik:RadMenuItem runat="server" Text="Abastecimento Posto" 
          ToolTip="Abastecimentos feitos nos postos credenciados" Value="Abastecimento">
        </telerik:RadMenuItem>
        <telerik:RadMenuItem runat="server" Text="Abatecimento Avulso" 
          ToolTip="Abastecimentos feitos em postos não credenciados" 
          Value="Abastecimento_Avulso">
        </telerik:RadMenuItem>
      </Items>
    </telerik:RadMenuItem>
    <telerik:RadMenuItem runat="server" PostBack="False" Text="Relatórios" 
      ToolTip="Emissão de vários relatórios" Value="Relatorios">
      <Items>
        <telerik:RadMenuItem runat="server" Text="Abastecimento por veículos" 
          ToolTip="Relatórios de abastecimentos realizados por veículo" 
          Value="Rel_Abastecimento_veiculo">
        </telerik:RadMenuItem>
      </Items>
    </telerik:RadMenuItem>
    <telerik:RadMenuItem runat="server" Text="Logout" 
      ToolTip="Efetuar logout na aplicação" Value="Logout">
    </telerik:RadMenuItem>
  </Items>
</telerik:RadMenu>
