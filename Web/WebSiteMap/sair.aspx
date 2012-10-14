<%@ Page Title="" Language="C#" MasterPageFile="~/Modelo.Master" AutoEventWireup="true" CodeBehind="sair.aspx.cs" Inherits="WebSiteMap.sair" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphCorpo" runat="server">
  <p>
  Você tem certeza que que deseja sair?</p>
<p>
  <asp:Button ID="btnSim" runat="server" onclick="btnSim_Click" Text="Sim" />
  <asp:Button ID="btnNao" runat="server" onclick="btnNao_Click" Text="Não" />
</p>
</asp:Content>
