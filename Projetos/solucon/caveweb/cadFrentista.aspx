<%@ Page Title="" Language="C#" MasterPageFile="~/Modelo.master" AutoEventWireup="true" CodeBehind="cadFrentista.aspx.cs" Inherits="CaveWeb.associaFrentista" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
    <asp:Label ID="Label1" runat="server" CssClass="titulo2" 
      Text="CADASTRAR FRENTISTA"></asp:Label>

  </div>

  <div>
    <table style="width: 75%" class="tabela">
      <tr>
        <td style="width: 122px">
          Usuário<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
            ControlToValidate="txbUsuario" ErrorMessage="Usuário não informado" 
            SetFocusOnError="True">*</asp:RequiredFieldValidator>
        </td>
        <td style="width: 84px">
          <asp:TextBox ID="txbUsuario" runat="server" CssClass="input_peq" 
            AutoPostBack="True" ontextchanged="txbUsuario_TextChanged" MaxLength="10" 
            Width="70px"></asp:TextBox>
        </td>
        <td style="width: 34px">
          <img runat="server" id="btnBuscarUsuario" alt="" src="img/buscar_btn.gif" 
              style="width: 30px; height: 22px" onclick="ShowLoginWindow(&quot;BuscaUsuario.aspx&quot;);" /></td>
        <td style="width: 248px">
          <asp:TextBox ID="txbNomeUsuario" runat="server" CssClass="textbox_desabilitado" 
            Width="300px"></asp:TextBox>
        </td>
      </tr>
      <tr>
        <td style="width: 122px">
          Fornecedor / Posto<asp:RequiredFieldValidator ID="RequiredFieldValidator2" 
            runat="server" ControlToValidate="txbId_fornecedor" CssClass="alerta_min" 
            ErrorMessage="Fornecedor / Posto não informado" SetFocusOnError="True">*</asp:RequiredFieldValidator>
        </td>
        <td style="width: 84px">
          <asp:TextBox ID="txbId_fornecedor" runat="server" CssClass="input_peq" 
            AutoPostBack="True" ontextchanged="txbId_fornecedor_TextChanged" 
            MaxLength="5" Width="71px"></asp:TextBox>
        </td>
        <td style="width: 34px">
          <img runat="server" alt="" src="img/buscar_btn.gif" style="width: 30px; height: 22px" 
            id="btnBuscarFornec" onclick="ShowLoginWindow(&quot;BuscaFornec.aspx&quot;);" /></td>
        <td style="width: 248px">
          <asp:TextBox ID="txbRazaoSocial" runat="server" CssClass="textbox_desabilitado" 
            Width="300px"></asp:TextBox>
          </td>
      </tr>
      </table>
  </div>
  <div>
        <asp:Label ID="lbMsgErro" runat="server" CssClass="alerta_min" Text="lbMsgErro" 
          Visible="False"></asp:Label>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
      CssClass="alerta_min" DisplayMode="List" Width="569px" />
  </div>
  <div>
  
    <asp:ImageButton ID="ibtAlterar" runat="server" 
      ImageUrl="~/img/alterar_btn.gif" onclick="ibtAlterar_Click" />
    <asp:ImageButton ID="ibtGravar" runat="server" 
      ImageUrl="~/img/gravar_btn.gif" onclick="ibtGravar_Click" />
    <asp:ImageButton ID="ibtExcluir" runat="server" 
      ImageUrl="~/img/excluir_btn.gif" onclick="ibtExcluir_Click" 
      onclientclick="return confirm('Confirma eliminação desse registro?'); " 
      CausesValidation="False" />
    &nbsp;<asp:ImageButton ID="ibtCancelar" runat="server" CausesValidation="False" 
      ImageUrl="~/img/cancelar_btn.gif" onclick="ibtCancelar_Click" />
    </div>

</asp:Content>
