<%@ Page Title="" Language="C#" MasterPageFile="~/Modelo.Limpo.master" AutoEventWireup="true" CodeBehind="paginaConstrucao.aspx.cs" Inherits="CaveWeb.paginaConstrucao" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

  <div style="vertical-align: middle; text-align: center">
    <asp:Label ID="Label1" runat="server" CssClass="titulo2" 
          Text="Página em construção"></asp:Label>
  </div>
  <br />
  <br />
  <br />
  <br />
  <div style="height: 19px; vertical-align: middle; text-align: center;" 
  class="label">
    Página que você acessou encontra-se ainda em construção. <font face="Arial, Helvetica, Geneva, SunSans-Regular, sans-serif ">
    </font></div>
  <div style="text-align: center">
        <img alt="" src="img/voltar_btn.gif" onclick="history.back();" 
          style="text-align: center" />
  </div>

</asp:Content>
