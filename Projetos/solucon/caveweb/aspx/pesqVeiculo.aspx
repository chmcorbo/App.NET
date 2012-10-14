<%@ Page Title="" Language="C#" MasterPageFile="~/Modelo.master" AutoEventWireup="true" CodeBehind="pesqVeiculo.aspx.cs" Inherits="CaveWeb.pesqVeiculo" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <div>
    <p>
      <asp:Label ID="Label1" runat="server" CssClass="titulo2" 
      Text="PESQUISA DE VEÍCULO"></asp:Label>
      <br />
    </p>
  </div>
  
<div>
  
    
      <table class="tabela" style="width: 100%">
        <tr>
          <td style="width: 44px">
            Placa</td>
          <td style="width: 206px">
            <asp:TextBox ID="txbPlaca" runat="server" CssClass="input_peq" Width="200px" 
          MaxLength="10"></asp:TextBox>
          </td>
          <td>&nbsp;
            </td>
        </tr>
        <tr>
          <td style="width: 44px">
            Marca</td>
          <td style="width: 206px">
            <asp:DropDownList ID="ddMarca" runat="server" CssClass="combo_box_med" 
          DataTextField="Descricao" DataValueField="ID" 
          onselectedindexchanged="ddMarca_SelectedIndexChanged" AutoPostBack="True">
            </asp:DropDownList>
          </td>
          <td>
          </td>
        </tr>
        <tr>
          <td style="width: 44px">
            Modelo</td>
          <td style="width: 206px">
            <asp:DropDownList ID="ddModelo" runat="server" CssClass="combo_box_med" 
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
  
  
  
  </div>
  <div>
  
      <telerik:RadGrid ID="RadGrid1" runat="server" AllowPaging="True" 
          AllowSorting="True" AutoGenerateColumns="False" GridLines="None" 
          Skin="Web20" onitemdatabound="RadGrid1_ItemDataBound">
<MasterTableView>
<RowIndicatorColumn Visible="False">
<HeaderStyle Width="20px"></HeaderStyle>
</RowIndicatorColumn>

<ExpandCollapseColumn Visible="False" Resizable="False">
<HeaderStyle Width="20px"></HeaderStyle>
</ExpandCollapseColumn>

    <Columns>
        <telerik:GridBoundColumn DataField="ID" HeaderText="ID" UniqueName="ID">
          <HeaderStyle HorizontalAlign="Center" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="PLACA" HeaderText="Placa" 
            UniqueName="column1">
          <HeaderStyle HorizontalAlign="Center" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="MARCA" HeaderText="Marca" 
            UniqueName="column2">
          <HeaderStyle HorizontalAlign="Center" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="MODELO" HeaderText="Modelo" 
            UniqueName="column3">
          <HeaderStyle HorizontalAlign="Center" />
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
