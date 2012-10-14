<%@ Page Title="" Language="C#" MasterPageFile="~/Modelo.Limpo.master" AutoEventWireup="true" CodeBehind="erro.aspx.cs" Inherits="CaveWeb.erro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <div style="vertical-align: middle; text-align: center">
    <asp:Label ID="Label1" runat="server" CssClass="alerta_max" 
          Text="Não foi possível executar essa operação"></asp:Label>
  </div>
  <br />
  <br />
  <br />
  <br />
  <div style="height: 88px; vertical-align: middle; text-align: center;">
    <table style="width: 100%; height: 83px;" class="tabela">
      <tr>
        <td style="width: 97px">
          Descrição do erro:</td>
        <td style="width: 619px; text-align: left;">
          <asp:Label ID="lbErro" runat="server" Text="lbErro" CssClass="alerta_min"></asp:Label></td>
      </tr>
      <tr>
        <td style="width: 97px">
          URL</td>
        <td style="width: 619px; text-align: left;">
          <asp:Label ID="lbURLErro" runat="server" Text="lbURLErro" CssClass="alerta_min"></asp:Label></td>
      </tr>
      <tr>
        <td style="width: 97px">
          &nbsp;</td>
        <td style="width: 619px; text-align: left;">
          <asp:Label ID="lbStackTrace" runat="server" CssClass="alerta_min" 
            Text="lbStackTrace"></asp:Label>
        </td>
      </tr>
      </table>
  </div>
  <br />
  <br />
  <br />    
  <div>
        <img alt="" src="img/voltar_btn.gif" onclick="history.back();" />
  </div>
</asp:Content>
