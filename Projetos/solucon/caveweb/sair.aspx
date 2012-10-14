<%@ Page Title="" Language="C#" MasterPageFile="~/Modelo.master" AutoEventWireup="true" CodeBehind="sair.aspx.cs" Inherits="CaveWeb.sair" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

  <div style="vertical-align: middle; text-align: center">
    <asp:Label ID="Label1" runat="server" CssClass="titulo2" 
          Text="Você deseja realmente sair?"></asp:Label>
  </div>
  <br />
  <br />
  <div style="height: 20px; vertical-align: middle; text-align: center;" 
  class="label">
        <asp:ImageButton ID="ibtSim" runat="server" ImageUrl="~/img/sim_btn.gif" 
          onclick="ibtSim_Click" />
        <asp:ImageButton ID="ibtNao" runat="server" ImageUrl="~/img/nao_btn.gif" 
          onclick="ibtNao_Click" />
  </div>
  <div style="text-align: center">
        &nbsp;</div>

</asp:Content>
