<%@ Page Title="" Language="C#" MasterPageFile="~/Modelo.master" AutoEventWireup="true" CodeBehind="relFuncionarioAbastecimento.aspx.cs" Inherits="CaveWeb.relFuncionarioAbastecimento" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class=titulo2>
      Relatório Saldo de Combustível de Funcionário
    </div>
    <br />    
    <asp:Literal ID="Literal1" runat="server"></asp:Literal>
    <table style="width: 100%" class="tabela">
        <tr>
            <td style="width: 50px">
                Ano:</td>
            <td style="width: 64px">
                <asp:DropDownList ID="ddlANo" runat="server" CssClass="combo_box_peq" 
                  Width="60px">
                    <asp:ListItem Value="2009">2009</asp:ListItem>
                    <asp:ListItem Value="2008">2008</asp:ListItem>
                    <asp:ListItem Value="2007">2007</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
                &nbsp;</td>
            <td class="tabela" style="width: 38px">
                Mês</td>
            <td>
                <asp:DropDownList ID="ddlMes" runat="server" CssClass="combo_box_peq" 
                  Width="70px">
                    <asp:ListItem Value="1">Janeiro</asp:ListItem>
                    <asp:ListItem Value="2">Fevereiro</asp:ListItem>
                    <asp:ListItem Value="3">Março</asp:ListItem>
                    <asp:ListItem Value="4">Abril</asp:ListItem>
                    <asp:ListItem Value="5">Maio</asp:ListItem>
                    <asp:ListItem Value="11">Novembro</asp:ListItem>
                    <asp:ListItem Value="12">Dezembro</asp:ListItem>
                    <asp:ListItem Value="6">Junho</asp:ListItem>
                    <asp:ListItem Value="7">Julho</asp:ListItem>
                    <asp:ListItem Value="08">Agosto</asp:ListItem>
                    <asp:ListItem Value="9">Setembro</asp:ListItem>
                    <asp:ListItem Value="10">Outubro</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td style="width: 50px">
                Matrícula:</td>
            <td style="width: 64px">
                <asp:TextBox ID="txbMatricula" runat="server" CssClass="input_peq" 
                  ontextchanged="txbMatricula_TextChanged" Width="60px" AutoPostBack="True"></asp:TextBox>
                &nbsp;</td>
            <td style="width: 34px">
                <img alt="" src="img/buscar_btn.gif" style="width: 30px; height: 22px" 
                 onclick="ShowLoginWindow(&quot;BuscaFunc.aspx&quot;);" />
            </td>
            <td class="tabela" style="width: 38px">
                Nome</td>
            <td>
                <asp:TextBox ID="txbNomeFunc" runat="server" CssClass="textbox_desabilitado" 
                  ReadOnly="True" Width="200px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 50px">
                &nbsp;</td>
            <td colspan="4">
                <asp:ImageButton ID="ibtVisualizar" runat="server" 
                  ImageUrl="~/img/visualizar_btn.gif" onclick="ibtVisualizar_Click" />
            </td>
        </tr>
    </table>
</asp:Content>
