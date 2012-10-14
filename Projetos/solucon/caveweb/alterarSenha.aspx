<%@ Page Language="C#" MasterPageFile="~/Modelo.master" AutoEventWireup="true" CodeBehind="alterarSenha.aspx.cs" Inherits="CaveWeb.alterarSenha" Title="CAVE - Alteração de Senha" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <p class="tabela">
    <asp:Label ID="Label1" runat="server" CssClass="titulo2" 
      Text="CADASTRO DE USUÁRIO"></asp:Label>
    <br />
    <table style="width: 100%">
      <tr>
        <td style="width: 112px">
          <b>Login</b></td>
        <td style="width: 190px">
          <asp:Label ID="lbLogin" runat="server" Text="Label"></asp:Label>
        </td>
        <td>
          &nbsp;</td>
      </tr>
      <tr>
        <td style="width: 112px">
          <b>Nome</b></td>
        <td style="width: 190px">
          <asp:Label ID="lbNome" runat="server" Text="Label"></asp:Label>
        </td>
        <td>
          &nbsp;</td>
      </tr>
      <tr>
        <td style="width: 112px">
          <b>Perfil</b></td>
        <td style="width: 190px">
          <asp:Label ID="lbPerfil" runat="server" Text="lbPerfil"></asp:Label>
        </td>
        <td>
          &nbsp;</td>
      </tr>
      <tr>
        <td style="width: 112px">
          <b>Senha</b></td>
              <td style="width: 190px">
                <asp:TextBox ID="txbSenha" runat="server" CssClass="textbox" MaxLength="10" 
                  TextMode="Password"></asp:TextBox>
              </td>
              <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                  ControlToValidate="txbSenha" ErrorMessage="Senha não informada"></asp:RequiredFieldValidator>
              </td>
            </tr>
            <tr>
              <td style="width: 112px">
                <b>Confirma Senha</b></td>
        <td style="width: 190px">
          <asp:TextBox ID="txbConfirmaSenha" runat="server" CssClass="textbox" 
            MaxLength="10" TextMode="Password"></asp:TextBox>
        </td>
        <td>
          <asp:CompareValidator ID="CompareValidator1" runat="server" 
            ControlToCompare="txbSenha" ControlToValidate="txbConfirmaSenha" 
            ErrorMessage="Senhas não conferem"></asp:CompareValidator>
        </td>
      </tr>
      <tr>
        <td style="width: 112px">
          &nbsp;</td>
        <td style="width: 190px">
          <asp:ImageButton ID="ibtGravar" runat="server" ImageUrl="~/img/gravar_btn.gif" 
            onclick="ibtGravar_Click" />
        &nbsp;<asp:ImageButton ID="ibtCancelar" runat="server" CausesValidation="False" 
            ImageUrl="~/img/cancelar_btn.gif" 
            onclientclick="history.back();" onclick="ibtCancelar_Click" />
        </td>
        <td>
          &nbsp;</td>
      </tr>
    </table>
  </p>
  <br />
</asp:Content>
