<%@ Page Title="" Language="C#" MasterPageFile="~/Modelo.master" AutoEventWireup="true" CodeBehind="cotaMensal.aspx.cs" Inherits="CaveWeb.CotaMensal" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

  <asp:Label ID="Label1" runat="server" CssClass="titulo2" 
    Text="Definir Cota Mensal para Funcionário"></asp:Label>
  <br />
  <table class="tabela">
    <tr>
      <td style="width: 48px; text-align: left;">
        Matricula</td>
      <td style="text-align: left; width: 217px;">
        <asp:TextBox ID="txbMatricula" runat="server" CssClass="textbox" MaxLength="10" 
          Width="61px"></asp:TextBox>
      </td>
      <td style="width: 29px; text-align: left;">
        Função</td>
      <td style="width: 55px">
        <asp:DropDownList ID="ddFuncao" runat="server" CssClass="combo_box_med" 
          DataTextField="NOME" DataValueField="ID">
        </asp:DropDownList>
      </td>
    </tr>
    <tr>
      <td style="width: 48px; text-align: left;">
        Nome</td>
      <td style="text-align: left; width: 217px;">
        <asp:TextBox ID="txbNome" runat="server" CssClass="textbox" Width="286px"></asp:TextBox>
        
      </td>
      <td style="width: 29px; text-align: left;">
        Mês</td>
      <td style="width: 55px">
        <asp:DropDownList ID="ddMes" runat="server" CssClass="combo_box_peq">
          <asp:ListItem Value="1">Janeiro</asp:ListItem>
          <asp:ListItem Value="2">Fevereiro</asp:ListItem>
          <asp:ListItem Value="3">Março</asp:ListItem>
          <asp:ListItem Value="4">Abril</asp:ListItem>
          <asp:ListItem Value="5">Maio</asp:ListItem>
          <asp:ListItem Value="6">Junho</asp:ListItem>
          <asp:ListItem Value="7">Julho</asp:ListItem>
          <asp:ListItem Value="8">Agosto</asp:ListItem>
          <asp:ListItem Value="9">Setembro</asp:ListItem>
          <asp:ListItem Value="10">Outubro</asp:ListItem>
          <asp:ListItem Value="11">Novembro</asp:ListItem>
          <asp:ListItem Value="12">Dezembro</asp:ListItem>
        </asp:DropDownList>
      </td>
    </tr>
    <tr>
      <td colspan="2">
        <asp:ImageButton ID="ibtBuscar" runat="server" 
          ImageUrl="~/img/consultar_btn.gif" Height="22px" ImageAlign="Bottom" 
          Width="67px" onclick="ibtBuscar_Click" />
        <asp:ImageButton ID="ibtVoltar" runat="server" CausesValidation="False" 
          Height="22px" ImageUrl="~/img/voltar_btn.gif" onclick="ibtVoltar_Click" 
          onclientclick="history.back()" Width="67px" />
      </td>
      <td style="width: 29px; text-align: left;">
        Ano</td>
      <td style="width: 55px">
        <asp:DropDownList ID="ddAno" runat="server" CssClass="combo_box_peq" 
          Height="19px">
          <asp:ListItem>2008</asp:ListItem>
          <asp:ListItem>2009</asp:ListItem>
        </asp:DropDownList>
      </td>
    </tr>
    </table>

  <div class="paragrafo" > 
     * Somente os funcionários que não tiverem cota no mês / ano especificados e não 
     estiverem demtidos. 
  </div> 
  <asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>
      <telerik:RadGrid ID="RadGrid1" runat="server" AutoGenerateColumns="False" 
    GridLines="None" Skin="Web20" AllowPaging="True" AllowSorting="True" 
    PageSize="8">
        <MasterTableView>
          <RowIndicatorColumn Visible="False">
            <HeaderStyle Width="20px"></HeaderStyle>
          </RowIndicatorColumn>
          <ExpandCollapseColumn Visible="False" Resizable="False">
            <HeaderStyle Width="20px"></HeaderStyle>
          </ExpandCollapseColumn>
          <Columns>
            <telerik:GridTemplateColumn HeaderText="Seleção" UniqueName="TemplateColumn">
              <HeaderTemplate>
                <asp:CheckBox ID="cbSelecionarTudo" runat="server" AutoPostBack="True" 
          oncheckedchanged="cbSelectAll_CheckedChanged" />
              </HeaderTemplate>
              <ItemTemplate>
                <asp:CheckBox ID="cbSelecao" runat="server" />
              </ItemTemplate>
              <HeaderStyle HorizontalAlign="Left" />
            </telerik:GridTemplateColumn>
            <telerik:GridBoundColumn DataField="ID" HeaderText="ID" UniqueName="ID">
              <HeaderStyle HorizontalAlign="Center" />
            </telerik:GridBoundColumn>
            <telerik:GridBoundColumn DataField="Matricula" HeaderText="Matrícula" 
      UniqueName="column1">
              <HeaderStyle HorizontalAlign="Center" />
            </telerik:GridBoundColumn>
            <telerik:GridBoundColumn DataField="Nome" HeaderText="Nome" 
      UniqueName="column2">
              <HeaderStyle HorizontalAlign="Center" />
            </telerik:GridBoundColumn>
            <telerik:GridTemplateColumn HeaderText="Função" UniqueName="TemplateColumn1">
              <ItemTemplate>
                <asp:Label ID="lbFuncao" runat="server" CssClass="label" 
                  Text='<%# Eval("Funcao.Nome") %>'></asp:Label>
              </ItemTemplate>
              <HeaderStyle HorizontalAlign="Center" />
            </telerik:GridTemplateColumn>
          </Columns>
          <EditFormSettings>
            <PopUpSettings ScrollBars="None">
            </PopUpSettings>
          </EditFormSettings>
        </MasterTableView>
      </telerik:RadGrid>
    </ContentTemplate>
  </asp:UpdatePanel>

<div>
        <asp:ImageButton ID="ibtAdicionar" runat="server" Height="22px" ImageAlign="Bottom" 
          ImageUrl="~/img/adicionar_btn.gif" Width="67px" 
          onclick="ibtAdicionar_Click" Visible="False" />


        <asp:ImageButton ID="ibtProximo" runat="server" 
          ImageUrl="~/img/proximo_btn.gif" onclick="ibtProximo_Click" 
          Visible="False" />
        <asp:Label ID="lbMens" runat="server" CssClass="alerta_min" Text="lbMens" 
          Visible="False"></asp:Label>


  <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
    DataObjectTypeName="Cave.Dominio.RH.Funcionario" 
    DeleteMethod="excluirItemSecao" SelectMethod="getListFuncCota" 
    TypeName="CaveWeb.CotaMensal"></asp:ObjectDataSource>

</div>


</asp:Content>