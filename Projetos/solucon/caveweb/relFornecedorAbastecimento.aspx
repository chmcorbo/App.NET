<%@ Page Title="" Language="C#" MasterPageFile="~/Modelo.master" AutoEventWireup="true" CodeBehind="relFornecedorAbastecimento.aspx.cs" Inherits="CaveWeb.relFornecedorAbastecimento" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class=titulo2>
      Relatório Abastecimento Consolidado por Posto/Fornecedor<br />
    </div>
    
    <p>
        <asp:Literal ID="Literal1" runat="server"></asp:Literal>
    </p>
    <div>
    
      <table class="tabela">
        <tr>
          <td>
            Combustível</td>
          <td colspan="4">
                <asp:DropDownList ID="ddCombustivel" runat="server" 
                    AppendDataBoundItems="True" CssClass="combo_box_med" DataTextField="NOME" 
                    DataValueField="ID">
                    <asp:ListItem Value="%">TODOS</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
          <td>
            Fornecedor</td>
          <td style="width: 74px">
         <asp:TextBox ID="txbID_Fornecedor" runat="server" AutoPostBack="True" 
           CssClass="input_peq" ontextchanged="txbID_Fornecedor_TextChanged" Width="60px"></asp:TextBox>
            </td>
          <td align="center" style="width: 30px">
         <img ID="imgBuscaFornec" alt="" 
           onclick="ShowLoginWindow(&quot;BuscaFornec.aspx&quot;);" src="img/buscar_btn.gif" 
           style="width: 30px; height: 22px; cursor:hand;" 
           title="Busca rápida de fornecedores/postos" __designer:mapid="82" /></td>
          <td style="width: 73px">
            Razão Social</td>
          <td>
         <asp:TextBox ID="txbRazaoSocial" runat="server" CssClass="textbox_desabilitado" 
           ReadOnly="True" Width="270px"></asp:TextBox>
                </td>
        </tr>
        <tr>
          <td>
            Período</td>
          <td style="width: 74px">
                <asp:TextBox ID="txbDtInicial" runat="server" CssClass="input_peq" 
              Width="60px"></asp:TextBox>
                <cc1:CalendarExtender ID="txbDtInicial_CalendarExtender" runat="server" 
                    Enabled="True" TargetControlID="txbDtInicial">
                </cc1:CalendarExtender>
          </td>
          <td align="center" style="width: 30px">
            <p align="center">à</p></td>
          <td style="width: 73px">
                <asp:TextBox ID="txbDtFinal" runat="server" CssClass="input_peq" 
              Width="60px"></asp:TextBox>
                <cc1:CalendarExtender ID="txbDtFinal_CalendarExtender" runat="server" 
                    Enabled="True" TargetControlID="txbDtFinal">
                </cc1:CalendarExtender>
          </td>
          <td>
                <asp:ImageButton ID="ibtVisualizar" runat="server" 
                    ImageUrl="~/img/visualizar_btn.gif" onclick="ImageButton1_Click" />
                </td>
        </tr>
      </table>
    
    </div>
    
</asp:Content>
