<%@ Page Title="" Language="C#" MasterPageFile="~/Modelo.master" AutoEventWireup="true" CodeBehind="relModeloAbastecimento.aspx.cs" Inherits="CaveWeb.relModeloAbastecimento" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
    
    <div class=titulo2>
      Relatório de Abastecimento Consolidado por Veículo
    </div>

    <br />    

    <asp:Literal ID="Literal1" runat="server"></asp:Literal>
    <table style="width: 100%">
        <tr>
            <td style="width: 42px">
                Placa:</td>
            <td style="width: 67px">
                <asp:TextBox ID="txbPlaca" runat="server" CssClass="input_peq" 
                  ontextchanged="txbPlaca_TextChanged" Width="60px" AutoPostBack="True"></asp:TextBox>
            </td>
            <td style="width: 28px">
                <img alt="" src="img/buscar_btn.gif" style="width: 30px; height: 22px" 
                  onclick="ShowLoginWindow(&quot;BuscaVeiculo.aspx&quot;);" />
            </td>
            <td style="width: 47px">
                Marca</td>
            <td style="width: 202px">
                <asp:TextBox ID="txbMarca" runat="server" CssClass="textbox_desabilitado" 
                  Width="195px"></asp:TextBox>
            </td>
            <td style="width: 63px">
                Modelo</td>
            <td>
                <asp:TextBox ID="txbModelo" runat="server" CssClass="textbox_desabilitado" 
                  Width="195px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 42px">
                Período:</td>
            <td colspan="3">
                <asp:TextBox ID="txbDtInicial" runat="server" CssClass="input_peq" Width="60px"></asp:TextBox>
                <cc1:CalendarExtender ID="txbDtInicial_CalendarExtender" runat="server" 
                    Enabled="True" TargetControlID="txbDtInicial">
                </cc1:CalendarExtender>
&nbsp; a&nbsp;
                <asp:TextBox ID="txbDtFinal" runat="server" CssClass="input_peq" Width="60px"></asp:TextBox>
                <cc1:CalendarExtender ID="txbDtFinal_CalendarExtender" runat="server" 
                    Enabled="True" TargetControlID="txbDtFinal">
                </cc1:CalendarExtender>
            </td>
            <td colspan="3">
                <asp:ImageButton ID="ibtVisualizar" runat="server" 
                  ImageUrl="~/img/visualizar_btn.gif" onclick="ibtVisualizar_Click" />
            </td>
        </tr>
    </table>
    <p>
    </p>
</asp:Content>
