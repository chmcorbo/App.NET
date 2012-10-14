<%@ Page Title="" Language="C#" MasterPageFile="~/Modelo.Limpo.master" AutoEventWireup="true" CodeBehind="semAcesso.aspx.cs" Inherits="CaveWeb.semAcesso" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

  <div style="vertical-align: middle; text-align: center">
    <asp:Label ID="Label1" runat="server" CssClass="titulo2" 
          Text="Usuário não tem permissão para acessar essa página"></asp:Label>
  </div>
  <br />
  <br />
  <br />
  <br />
  <div style="height: 71px; vertical-align: middle; text-align: center;" 
  class="label">
    O seu perfil não tem permissão para acessar essa página<font face="Arial, Helvetica, Geneva, SunSans-Regular, sans-serif ">.
    <br />
    <br />
    Caso você deseje obter permissão, deverá solicitar ao administrador do sistema. </font></div>
  <div style="text-align: center">
        <img alt="" src="img/voltar_btn.gif" onclick="history.back();" />
  </div>

</asp:Content>
