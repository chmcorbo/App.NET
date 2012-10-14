<%@ Page Language="C#" MasterPageFile="~/Modelo.master" AutoEventWireup="true" CodeBehind="relAbastecimentoVeiculo.aspx.cs" Inherits="CaveWeb.relAbastecimentoVeiculo" %>

<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class=titulo2>
      Relatório de Abastecimento Realizado por Veículo
    </div>

    <br />    

    <asp:Literal ID="Literal1" runat="server"></asp:Literal>
    <table class="tabela">
        <tr>
            <td valign="top" style="width: 65px">
                Funcionário:</td>
            <td valign="top" style="width: 8px">
                <asp:TextBox ID="txbMatricula" runat="server" CssClass="input_peq" 
                  AutoPostBack="True" ontextchanged="txbMatricula_TextChanged" Width="60px"></asp:TextBox>
            </td>
            <td valign="top" colspan="2">
                <img alt="" src="img/buscar_btn.gif" style="width: 30px; height: 22px" 
                  id="btnBuscarFunc" 
                  onclick="ShowLoginWindow(&quot;BuscaFunc.aspx&quot;);"
                  /></td>
            <td valign="top" colspan="2">
                Nome</td>
            <td valign="top" style="width: 30px">
                <asp:TextBox ID="txbNomeFunc" runat="server" CssClass="textbox_desabilitado" 
                  ReadOnly="True" Width="220px"></asp:TextBox>
            </td>
            <td valign="top">
                &nbsp;</td>
            <td valign="top">
                &nbsp;</td>
        </tr>
        <tr>
            <td valign="top" style="width: 65px">
                Veículo:</td>
            <td valign="top">
                <asp:TextBox ID="txbPlaca" runat="server" CssClass="input_peq" 
                  AutoPostBack="True" ontextchanged="txbPlaca_TextChanged" Width="60px"></asp:TextBox>
            </td>
            <td valign="top" colspan="2">
                <img alt="" src="img/buscar_btn.gif" style="width: 30px; height: 22px" 
                  onclick="ShowLoginWindow(&quot;BuscaVeiculo.aspx&quot;);"
                  id="btnBuscarVeiculo" /></td>
            <td valign="top" colspan="2">
                Marca</td>
            <td valign="top" style="width: 30px">
                <asp:TextBox ID="txbMarca" runat="server" CssClass="textbox_desabilitado" 
                  ReadOnly="True" Width="220px"></asp:TextBox>
            </td>
            <td valign="top">
                Modelo</td>
            <td valign="top">
                <asp:TextBox ID="txbModelo" runat="server" CssClass="textbox_desabilitado" 
                  ReadOnly="True" Width="220px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td valign="top" style="width: 65px">
                Fornecedor:</td>
            <td valign="top" colspan="2" style="width: 17px">
                <asp:TextBox ID="txbID_Fornecedor" runat="server" CssClass="input_peq" 
                  AutoPostBack="True" ontextchanged="txbID_Fornecedor_TextChanged" Width="60px"></asp:TextBox>
            </td>
            <td valign="top" style="width: 35px">
                <img alt="" src="img/buscar_btn.gif" style="width: 30px; height: 22px" 
                  onclick="ShowLoginWindow(&quot;BuscaFornec.aspx&quot;);"
                  id="btnBuscarFornec" /></td>
            <td valign="top" colspan="2">
                Razão Social</td>
            <td valign="top" style="width: 30px">
                <asp:TextBox ID="txbRazaoSocial" runat="server" CssClass="textbox_desabilitado" 
                  ReadOnly="True" Width="220px"></asp:TextBox>
            </td>
            <td>
            </td>
            <td>
              <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                ControlToValidate="txbID_Fornecedor" CssClass="alerta_min" 
                ErrorMessage="Fornecedor não informado"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td valign="top" style="width: 65px">
                Perídodo:</td>
            <td valign="top" colspan="4">
                <asp:TextBox ID="txbDtInicial" runat="server" CssClass="input_peq" Width="60px"></asp:TextBox>
                <cc1:CalendarExtender ID="txbDtInicial_CalendarExtender" runat="server" 
                    Enabled="True" TargetControlID="txbDtInicial">
                </cc1:CalendarExtender>
&nbsp; à&nbsp;
                <asp:TextBox ID="txbDtFinal" runat="server" CssClass="input_peq" Width="60px"></asp:TextBox>
                <cc1:CalendarExtender ID="txbDtFinal_CalendarExtender" runat="server" 
                    Enabled="True" TargetControlID="txbDtFinal">
                </cc1:CalendarExtender>
            </td>
            <td valign="top" colspan="2">
                <asp:ImageButton ID="ibtVisualizar" runat="server" 
                  ImageUrl="~/img/visualizar_btn.gif" onclick="ibtVisualizar_Click" />
            </td>
            <td valign="top" colspan="2">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 65px">
                &nbsp;</td>
            <td colspan="8">
                &nbsp;</td>
        </tr>
    </table>
       


   
    

</asp:Content> 