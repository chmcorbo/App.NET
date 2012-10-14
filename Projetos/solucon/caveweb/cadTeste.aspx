<%@ Page Title="" Language="C#" MasterPageFile="~/Modelo.master" AutoEventWireup="true" CodeBehind="cadTeste.aspx.cs" Inherits="CaveWeb.cadTeste" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>
      <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
      <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
      <asp:Button ID="Button1" runat="server" Text="Button" />
    </ContentTemplate>
  </asp:UpdatePanel>
</asp:Content>
