<%@ Page Title="" Language="C#" MasterPageFile="~/Modelo.Limpo.master" AutoEventWireup="true" CodeBehind="paginaNaoEncontrada.aspx.cs" Inherits="CaveWeb.paginaNaoEncontrada" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

  <div style="vertical-align: middle; text-align: center">
    <asp:Label ID="Label1" runat="server" CssClass="alerta_max" 
          Text="Página que está tentando acessar não está disponível"></asp:Label>
  </div>
  <br />
  <br />
  <br />
  <br />
  <div style="height: 71px; vertical-align: middle; text-align: center;" 
  class="alerta_min">
    <font face="Arial, Helvetica, Geneva, SunSans-Regular, sans-serif ">A página que 
    você está procurando (ou uma de suas dependências) não pôde ser encontrado, seu 
    nome foi alterado ou está temporariamente indisponível. Examine o URL e 
    certifique-se de que está digitado corretamente. </font>
    <br />
    <br />
    Caso o problema persista contate ao departamento de suporte.</div>
  <br />
  <br />
  <br />    
  <div style="text-align: center">
        <img alt="" src="img/voltar_btn.gif" onclick="history.back();" />
  </div>

</asp:Content>
