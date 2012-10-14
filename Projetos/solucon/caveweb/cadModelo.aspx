<%@ Page Language="C#" MasterPageFile="~/Modelo.master" AutoEventWireup="true" CodeBehind="cadModelo.aspx.cs" Inherits="CaveWeb.cadModelo" Title="CAVE - Cadastro de Modelo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

  <p>
    <asp:Label ID="Label1" runat="server" CssClass="titulo2" 
      Text="CADASTRO DE MODELO"></asp:Label>
    <br />
  </p>
  <table style="width: 100%" class="tabela">
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
          MaxLength="50" Width="198px"></asp:TextBox>
      </td>
      <td>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
          CssClass="alerta_min" ErrorMessage="Descrição não informada" 
          ControlToValidate="txbDescricao"></asp:RequiredFieldValidator>
      </td>
    </tr>
    <tr>
      <td style="width: 59px">
        Marca</td>
      <td style="width: 220px">
        <asp:DropDownList ID="ddMarca" runat="server" CssClass="combo_box_med" 
          DataTextField="Descricao" DataValueField="ID">
        </asp:DropDownList>
      </td>
      <td>
        &nbsp;</td>
    </tr>
  </table>
  <br/>
  <div>
        <asp:Label ID="lbMsgErro" runat="server" CssClass="alerta_min" Text="lbMsgErro" 
          Visible="False"></asp:Label>
        <br />
        <asp:ImageButton ID="ibtAlterar" runat="server" Height="22px" 
          ImageUrl="~/img/alterar_btn.gif" onclick="ibtAlterar_Click" />
        <asp:ImageButton ID="ibtGravar" runat="server" 
          ImageUrl="~/img/gravar_btn.gif" onclick="ibtGravar_Click" 
          style="height: 22px" />
        <asp:ImageButton ID="ibtExcluir" runat="server" 
          ImageUrl="~/img/excluir_btn.gif" onclick="ibtExcluir_Click" 
          onclientclick="return confirm('Confirma eliminação desse registro?'); "  />
        <asp:ImageButton ID="ibtCancelar" runat="server" 
          ImageUrl="~/img/cancelar_btn.gif" CausesValidation="False" 
          onclick="ibtCancelar_Click" />
  </div>


</asp:Content>
