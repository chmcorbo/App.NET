<%@ Page Title="" Language="C#" MasterPageFile="~/Modelo.master" AutoEventWireup="true" CodeBehind="pesqModelo.aspx.cs" Inherits="CaveWeb.pesqModelo" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

  <p>
    <asp:Label ID="Label1" runat="server" CssClass="titulo2" 
      Text="PESQUISA DE MODELO"></asp:Label>
  <br />
  <table class="tabela" style="width: 100%">
    <tr>
      <td style="width: 44px">
        Descricao</td>
      <td style="width: 254px">
        <asp:TextBox ID="txbDescricao" runat="server" CssClass="textbox" Width="250px" 
          MaxLength="50"></asp:TextBox>
      </td>
      <td>
        &nbsp;</td>
    </tr>
    <tr>
      <td style="width: 44px">
        Marca</td>
      <td style="width: 254px">
        <asp:DropDownList ID="ddMarca" runat="server" CssClass="combo_box_med" 
          DataTextField="Descricao" DataValueField="ID">
        </asp:DropDownList>
      </td>
      <td>
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
<div>

  <telerik:RadGrid ID="RadGrid1" runat="server" AllowPaging="True" 
    AllowSorting="True" AutoGenerateColumns="False" GridLines="None" 
    onitemdatabound="RadGrid1_ItemDataBound" Skin="Web20" Width="770px">
<MasterTableView>
<RowIndicatorColumn Visible="False">
<HeaderStyle Width="20px"></HeaderStyle>
</RowIndicatorColumn>

<ExpandCollapseColumn Visible="False" Resizable="False">
<HeaderStyle Width="20px"></HeaderStyle>
</ExpandCollapseColumn>

  <Columns>
    <telerik:GridBoundColumn DataField="ID" HeaderText="ID" UniqueName="ID">
    </telerik:GridBoundColumn>
    <telerik:GridBoundColumn DataField="DESCRICAO" HeaderText="Descricao" 
      UniqueName="column1">
    </telerik:GridBoundColumn>
    <telerik:GridBoundColumn DataField="DESC_MARCA" HeaderText="Marca" 
      UniqueName="column2">
    </telerik:GridBoundColumn>
  </Columns>

<EditFormSettings>
<PopUpSettings ScrollBars="None"></PopUpSettings>
</EditFormSettings>
</MasterTableView>
  </telerik:RadGrid>

</div>
<div>
  <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
</div>

</asp:Content>
