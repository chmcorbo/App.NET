<%@ Page Language="C#" MasterPageFile="~/Modelo.master" AutoEventWireup="true" CodeBehind="cadUsuario.aspx.cs" Inherits="CaveWeb.cadUsuario" Title="CAVE - Cadastro de Usuário" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  
  <p>
    <asp:Label ID="Label1" runat="server" CssClass="titulo2" 
      Text="CADASTRO DE USUÁRIO"></asp:Label>
  <p>
  <table style="width: 100%" class="tabela" border="0">
    <tr>
      <td style="width: 89px">
        Login</span></td>
      <td style="width: 176px">
        <asp:TextBox ID="txbLogin" runat="server" CssClass="textbox" MaxLength="10"></asp:TextBox>
      </td>
      <td>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
          ControlToValidate="txbLogin" ErrorMessage="*">Login não informado</asp:RequiredFieldValidator>
      </td>
    </tr>
    <tr>
      <td style="width: 89px">
        Nome</td>
      <td style="width: 176px">
        <asp:TextBox ID="txbNome" runat="server" CssClass="textbox" Width="283px"></asp:TextBox>
      </td>
      <td>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
          ErrorMessage="*" ControlToValidate="txbNome">Nome não informado</asp:RequiredFieldValidator>
      </td>
    </tr>
    <tr>
      <td style="width: 89px">
        Senha</td>
      <td style="width: 176px">
        <asp:TextBox ID="txbSenha" runat="server" CssClass="textbox" MaxLength="10" 
          TextMode="Password"></asp:TextBox>
      </td>
      <td>
        &nbsp;</td>
    </tr>
    <tr>
      <td style="width: 89px">
        Confirma Senha</td>
      <td style="width: 176px">
        <asp:TextBox ID="txbConfSenha" runat="server" CssClass="textbox" MaxLength="10" 
          TextMode="Password"></asp:TextBox>
      </td>
      <td>
        &nbsp;</td>
    </tr>
    <tr>
      <td style="width: 89px; height: 16px">
        Perfil</td>
      <td style="width: 176px; height: 16px">
        <asp:DropDownList ID="ddPerfil" runat="server" CssClass="combo_box_med" 
          DataTextField="NOME" DataValueField="ID">
        </asp:DropDownList>
      </td>
      <td style="height: 16px">
        &nbsp;</td>
    </tr>
    <tr>
      <td style="width: 89px; height: 16px">
          Situação</td>
      <td style="width: 176px; height: 16px">
        <asp:DropDownList ID="ddAtivo" runat="server" CssClass="combo_box_peq" 
          Width="85px">
          <asp:ListItem Selected="True" Value="S">Ativo</asp:ListItem>
          <asp:ListItem Value="N">Inativo</asp:ListItem>
        </asp:DropDownList>
      </td>
      <td style="height: 16px">
        &nbsp;</td>
    </tr>
    </table>
  <div style="width: 100%">
        <asp:Label ID="lbMsgErro" runat="server" CssClass="alerta_min" Text="lbMsgErro" 
          Visible="False"></asp:Label>
        <br />
        <asp:ImageButton ID="ibtAlterar" runat="server" 
          ImageUrl="~/img/alterar_btn.gif" onclick="ibtAlterar_Click" />
        <asp:ImageButton ID="ibtGravar" runat="server" 
          ImageUrl="~/img/gravar_btn.gif" onclick="ibtGravar_Click" />
        <asp:ImageButton ID="ibtExcluir" runat="server" 
          ImageUrl="~/img/excluir_btn.gif" onclick="ibtExcluir_Click" 
          onclientclick="return confirm('Confirma eliminação desse registro?'); " />
        <asp:ImageButton ID="ibtCancelar" runat="server" 
          ImageUrl="~/img/cancelar_btn.gif" onclick="ibtCancelar_Click" 
          CausesValidation="False" Height="22px" 
          Width="65px" />
  </div>
</p>
</asp:Content>
