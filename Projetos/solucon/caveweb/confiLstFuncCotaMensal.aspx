<%@ Page Title="" Language="C#" MasterPageFile="~/Modelo.master" AutoEventWireup="true" CodeBehind="confiLstFuncCotaMensal.aspx.cs" Inherits="CaveWeb.ConfiLstFuncCotaMensal" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  
  <div class="titulo2">
    Funcionários selecionados
  </div>
  
  <div>
  
    <telerik:RadGrid ID="RadGrid1" runat="server" AllowPaging="True" 
      AllowSorting="True" AutoGenerateColumns="False" 
      DataSourceID="ObjectDataSource1" GridLines="None" Skin="Web20">
<MasterTableView DataSourceID="ObjectDataSource1">
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
    <telerik:GridBoundColumn DataField="Matricula" HeaderText="Matrícula" 
      UniqueName="column1">
      <HeaderStyle HorizontalAlign="Center" />
    </telerik:GridBoundColumn>
    <telerik:GridBoundColumn DataField="Nome" HeaderText="Nome" UniqueName="column">
      <HeaderStyle HorizontalAlign="Center" />
    </telerik:GridBoundColumn>
    <telerik:GridTemplateColumn HeaderText="Função" UniqueName="TemplateColumn">
      <ItemTemplate>
        <asp:Label ID="lbFuncao" runat="server" CssClass="label" 
          Text='<%# Eval("Funcao.Nome") %>'></asp:Label>
      </ItemTemplate>
      <HeaderStyle HorizontalAlign="Center" />
    </telerik:GridTemplateColumn>
  </Columns>

<EditFormSettings>
<PopUpSettings ScrollBars="None"></PopUpSettings>
</EditFormSettings>
</MasterTableView>
    </telerik:RadGrid>
  
  </div>

  <div>
  
    <table class="tabela" style="width: 89%">
      <tr>
        <td>
          Mês</td>
        <td style="width: 74px">
          <asp:TextBox ID="txbMes" runat="server" CssClass="textbox_desabilitado" 
            ReadOnly="True" Width="71px"></asp:TextBox>
        </td>
        <td>
          Ano</td>
        <td align="center" style="width: 67px">
          <asp:TextBox ID="txbAno" runat="server" CssClass="textbox_desabilitado" 
            ReadOnly="True" Width="61px" Height="18px"></asp:TextBox>
        </td>
        <td style="width: 57px">
          Quantidade</td>
        <td style="width: 66px; text-align: center;">
          <telerik:RadNumericTextBox ID="txbQuantidade" Runat="server" CssClass="input_peq_numerico" 
            MaxValue="1000" MinValue="0" 
            ToolTip="Digite a quantidade referente a cota de combustível" 
            ontextchanged="txbQuantidade_TextChanged" Width="50px" Value="0">
<NumberFormat AllowRounding="True"></NumberFormat>
          </telerik:RadNumericTextBox>
        </td>
        <td style="width: 128px">
          <asp:ImageButton ID="ibtGravar" runat="server" ImageUrl="~/img/gravar_btn.gif" 
            onclick="ibtGravar_Click" />
          <asp:ImageButton id="ibtVoltar" runat="server" ImageUrl="~/img/voltar_btn.gif" 
            style="height: 22px; width: 57px" CausesValidation="False" 
            PostBackUrl="~/cotaMensal.aspx" /></td>
        <td>
          <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
            ControlToValidate="txbQuantidade" ErrorMessage="Cota não informada" 
            SetFocusOnError="True"></asp:RequiredFieldValidator>
          <br />
          <asp:RangeValidator ID="RangeValidator1" runat="server" 
            ControlToValidate="txbQuantidade" 
            ErrorMessage="Quantidade fora da faixa (1-1000)" MaximumValue="1000" 
            MinimumValue="1" SetFocusOnError="True" Type="Double"></asp:RangeValidator>
        </td>
      </tr>
    </table>
  
  </div>
  
  <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
    SelectMethod="getFuncCotaMens" TypeName="CaveWeb.ConfiLstFuncCotaMensal" 
    DataObjectTypeName="Cave.Dominio.RH.Funcionario">
  </asp:ObjectDataSource>
  
  </asp:Content>
