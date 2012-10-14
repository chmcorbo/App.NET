<%@ Page Title="" Language="C#" MasterPageFile="~/Modelo.Limpo.master" AutoEventWireup="true" CodeBehind="usuarioSemFornecedor.aspx.cs" Inherits="CaveWeb.usuarioSemFornecedor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

  <div style="vertical-align: middle; text-align: center">
    <asp:Label ID="Label1" runat="server" CssClass="titulo2" 
          Text="Não é possível fazer lançamentos de abastecimentos"></asp:Label>
  </div>
  <br />
  <br />
  <br />
  <br />
  <div style="height: 71px; vertical-align: middle; text-align: center;" 
  class="label">
    Seu login de usuário precisa estar associado à um fornecedor/posto para ter acesso à essa opção.<font face="Arial, Helvetica, Geneva, SunSans-Regular, sans-serif ">.
    <br />
    <br />
    Caso você deseje obter essa permissão, deverá solicitar ao administrador do sistema associá-lo à um fornecedor. </font></div>
  <div style="text-align: center">
        &nbsp;<asp:ImageButton ID="ibtVoltar" runat="server" 
          ImageUrl="~/img/voltar_btn.gif" PostBackUrl="~/principal.aspx" />
  </div>
  
</asp:Content>
