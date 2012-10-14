<%@ Page Language="C#" MasterPageFile="~/Modelo.master" AutoEventWireup="true" CodeBehind="pesqUsuario.aspx.cs" Inherits="CaveWeb.PesqUsuario" Title="CAVE - Pesquisa de Usuário" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    <asp:Label ID="Label1" runat="server" CssClass="titulo2" 
      Text="PESQUISA DE USUÁRIO"></asp:Label>
  <br />
  <table style="width: 100%" class="tabela">
    <tr>
      <td style="width: 44px; height: 19px;">
        Nome</td>
      <td style="width: 42px; height: 19px;">
        <asp:TextBox ID="txbNome" runat="server" CssClass="textbox" Width="250px" 
          MaxLength="50"></asp:TextBox>
      </td>
      <td style="width: 316px; height: 19px;">
          </td>
    </tr>
    <tr>
      <td style="width: 44px; height: 27px;">
        Login</td>
      <td style="width: 42px; height: 27px;">
        <asp:TextBox ID="txbLogin" runat="server" CssClass="textbox" MaxLength="10" 
          Width="250px"></asp:TextBox>
      </td>
      <td style="height: 27px; width: 316px;">
        <asp:ImageButton ID="ibtBuscar" runat="server" 
          ImageUrl="~/img/consultar_btn.gif" Height="22px" ImageAlign="Bottom" 
          Width="67px" onclick="ibtBuscar_Click" />
        <asp:ImageButton ID="ibtNovo" runat="server" Height="22px" ImageAlign="Bottom" 
          ImageUrl="~/img/novo_btn.gif" Width="67px" onclick="ibtNovo_Click" />
        <asp:ImageButton ID="ibtVoltar" runat="server" CausesValidation="False" 
          Height="22px" ImageUrl="~/img/voltar_btn.gif" onclick="ibtVoltar_Click" 
          onclientclick="history.back()" Width="67px" />
      </td>
    </tr>
  </table>
</p>
<telerik:RadGrid ID="RadGrid1" runat="server" Skin="Web20" AllowPaging="True" 
    AllowSorting="True" AutoGenerateColumns="False" GridLines="None" 
  onitemdatabound="RadGrid1_ItemDataBound" Width="760px">
<MasterTableView>
<RowIndicatorColumn Visible="False">
<HeaderStyle Width="20px"></HeaderStyle>
</RowIndicatorColumn>

<ExpandCollapseColumn Visible="False" Resizable="False">
<HeaderStyle Width="20px"></HeaderStyle>
</ExpandCollapseColumn>

  <Columns>
    <telerik:GridBoundColumn DataField="ID" DataType="System.Int32" HeaderText="ID" 
      UniqueName="ID">
    </telerik:GridBoundColumn>
    <telerik:GridBoundColumn DataField="LOGIN" HeaderText="Login" 
      UniqueName="column1">
    </telerik:GridBoundColumn>
    <telerik:GridBoundColumn DataField="NOME" HeaderText="Nome" 
      UniqueName="column2">
    </telerik:GridBoundColumn>
    <telerik:GridBoundColumn DataField="NOME_PERFIL" HeaderText="Perfil" 
      UniqueName="column3">
    </telerik:GridBoundColumn>
  </Columns>

<EditFormSettings>
<PopUpSettings ScrollBars="None"></PopUpSettings>
</EditFormSettings>
</MasterTableView>
</telerik:RadGrid>
<p>
  <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
</p>
</asp:Content>
