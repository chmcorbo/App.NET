﻿<%@ Page Language="C#" MasterPageFile="~/Modelo.master" AutoEventWireup="true" CodeBehind="cadMarca.aspx.cs" Inherits="CaveWeb.cadMarca" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <p>
    <asp:Label ID="Label1" runat="server" CssClass="titulo2" 
      Text="CADASTRO DE MARCA"></asp:Label>
    <br />
  </p>
  <table style="width: 100%">
    <tr>
      <td style="width: 59px">
        ID</td>
      <td style="width: 220px">
        <asp:Label ID="lbID" runat="server" Text="0"></asp:Label>
      </td>
      <td>
        &nbsp;</td>
    </tr>
    <tr>
      <td style="width: 59px">
        Descrição</td>
      <td style="width: 220px">
        <asp:TextBox ID="txbDescricao" runat="server" CssClass="textbox_desabilitado" 
          MaxLength="50" Width="210px"></asp:TextBox>
      </td>
      <td>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
          CssClass="alerta_min" ErrorMessage="Descrição não informada" 
          ControlToValidate="txbDescricao"></asp:RequiredFieldValidator>
      </td>
    </tr>
  </table>
  <br/>
  <div>
        <asp:Label ID="lbMsgErro" runat="server" CssClass="alerta_min" Text="lbMsgErro" 
          Visible="False"></asp:Label>
        <br />
        <asp:ImageButton ID="ibtAlterar" runat="server" 
          ImageUrl="~/img/alterar_btn.gif" onclick="ibtAlterar_Click" />
        <asp:ImageButton ID="ibtGravar" runat="server" 
          ImageUrl="~/img/gravar_btn.gif" onclick="ibtGravar_Click" />
        <asp:ImageButton ID="ibtExcluir" runat="server" 
          ImageUrl="~/img/excluir_btn.gif" onclick="ibtExcluir_Click" 
          onclientclick="return confirm('Confirma eliminação desse registro?'); "  />
        <asp:ImageButton ID="ibtCancelar" runat="server" 
          ImageUrl="~/img/cancelar_btn.gif" onclick="ibtCancelar_Click" 
          CausesValidation="False" />
  </div>

</asp:Content>
