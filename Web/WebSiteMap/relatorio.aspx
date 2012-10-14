<%@ Page Title="" Language="C#" MasterPageFile="~/Modelo.Master" AutoEventWireup="true" CodeBehind="relatorio.aspx.cs" Inherits="WebSiteMap.relatorio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphCorpo" runat="server">
  <h3>
    Essa é a página de relatórios
  </h3>
  <br />
  <p>
    <input id="btnVoltar" title="Voltar a página anterior" type="button" 
      value="Voltar" onclick="history.back();" />
  </p>

</asp:Content>
