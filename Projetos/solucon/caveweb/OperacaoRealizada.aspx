<%@ Page Title="" Language="C#" MasterPageFile="~/Modelo.master" AutoEventWireup="true" CodeBehind="OperacaoRealizada.aspx.cs" Inherits="CaveWeb.OperacaoRealizada" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <br />
    <br />
    <p style="text-align: center">
    <asp:Label ID="lblMensagem" runat="server" CssClass="titulo2" 
      Text="Gravação realizada com sucesso"></asp:Label>
    </p>
    <br />
    <p style="text-align: center; font-family: Arial, Helvetica, sans-serif; font-size: x-small;">
      Aguarde a página será redirecionada
    </p>
    <br />
    <br />
    <asp:Timer ID="Timer1" runat="server" 
      Interval="2000" ontick="Timer1_Tick">
    </asp:Timer>
</asp:Content>
