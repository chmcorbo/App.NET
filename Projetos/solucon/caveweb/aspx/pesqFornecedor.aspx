<%@ Page Title="" Language="C#" MasterPageFile="~/Modelo.master" AutoEventWireup="true" CodeBehind="pesqFornecedor.aspx.cs" Inherits="CaveWeb.pesqFornecedor" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <p>
    <asp:Label ID="Label1" runat="server" CssClass="titulo2" 
      Text="PESQUISA DE FORNECEDOR"></asp:Label>
  <br />
  <table class="tabela" style="width: 72%">
    <tr>
      <td style="width: 79px">
        Razão Social</td>
      <td style="width: 278px">
        <asp:TextBox ID="txbRazao_social" runat="server" CssClass="textbox" Width="250px" 
          MaxLength="50"></asp:TextBox>
      </td>
      <td style="width: 345px">&nbsp;
          </td>
    </tr>
    <tr>
      <td style="width: 79px; height: 27px;">
        CNPJ</td>
      <td style="width: 278px; height: 27px;">
        <asp:TextBox ID="txbCNPJ" runat="server" CssClass="textbox" MaxLength="10" 
          Width="250px"></asp:TextBox>
      </td>
      <td style="height: 27px; width: 345px;">
        <asp:ImageButton ID="ibtBuscar" runat="server" 
          ImageUrl="~/img/buscar_btn.gif" Height="22px" ImageAlign="Bottom" 
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

    <telerik:RadGrid ID="RadGrid1" runat="server" AutoGenerateColumns="False" 
      GridLines="None" Skin="Web20" Width="552px" AllowPaging="True" 
      AllowSorting="True" onitemdatabound="RadGrid1_ItemDataBound">
<MasterTableView>
<RowIndicatorColumn Visible="False">
<HeaderStyle Width="20px"></HeaderStyle>
</RowIndicatorColumn>

<ExpandCollapseColumn Visible="False" Resizable="False">
<HeaderStyle Width="20px"></HeaderStyle>
</ExpandCollapseColumn>

  <Columns>
    <telerik:GridBoundColumn DataField="ID" HeaderText="ID" UniqueName="ID">
      <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
    </telerik:GridBoundColumn>
    <telerik:GridBoundColumn DataField="RAZAO_SOCIAL" HeaderText="Razão Social" 
      UniqueName="column1">
      <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
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
