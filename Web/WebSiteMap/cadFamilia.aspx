<%@ Page Title="" Language="C#" MasterPageFile="~/Modelo.Master" AutoEventWireup="true" CodeBehind="cadFamilia.aspx.cs" Inherits="WebSiteMap.cadFamilia" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphCorpo" runat="server">
  <h3>
    Essa é a página de família de produtos
  </h3>
  <br />
  <p>
    <input id="btnVoltar" title="Voltar a página anterior" type="button" 
      value="Voltar" onclick="history.back();" />
  </p>

</asp:Content>
