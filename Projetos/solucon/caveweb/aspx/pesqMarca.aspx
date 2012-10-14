﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Modelo.master" AutoEventWireup="true" CodeBehind="pesqMarca.aspx.cs" Inherits="CaveWeb.pesqMarca" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

  <p>
    <asp:Label ID="Label1" runat="server" CssClass="titulo2" 
      Text="PESQUISA DE MARCA"></asp:Label>
  <br />
  <table class="tabela" style="width: 99%">
    <tr>
      <td style="width: 44px">
        Descricao</td>
      <td style="width: 183px">
        <asp:TextBox ID="txbDescricao" runat="server" CssClass="textbox" Width="250px" 
          MaxLength="50"></asp:TextBox>
      </td>
      <td style="width: 226px">
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
  <telerik:RadGrid ID="RadGrid1" runat="server" AllowPaging="True" 
    AllowSorting="True" AutoGenerateColumns="False" GridLines="None" 
    Skin="Web20" onitemdatabound="RadGrid1_ItemDataBound" Width="767px">
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
    <telerik:GridBoundColumn DataField="DESCRICAO" HeaderText="Descrição" 
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
