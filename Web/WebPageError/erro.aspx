<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="erro.aspx.cs" Inherits="WebPageError.erro" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
    <style type="text/css">
      .style1
      {
        width: 100%;
      }
      .style2
      {
        width: 333px;
      }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    O valor digitado para operação não é válido.
      <br />
      <table class="style1">
        <tr>
          <td class="style2">
            Mensage</td>
          <td>
            <asp:Label ID="lblMessage" runat="server" Font-Size="Smaller" ForeColor="Red" 
              Text="lblMessage"></asp:Label>
          </td>
        </tr>
        <tr>
          <td class="style2">
            Source</td>
          <td>
            <asp:Label ID="lblSource" runat="server" Font-Size="Smaller" ForeColor="Red" 
              Text="lblSource"></asp:Label>
          </td>
        </tr>
        <tr>
          <td class="style2">
            StackTrace</td>
          <td>
            <asp:Label ID="lblStackTrace" runat="server" Font-Size="Smaller" 
              ForeColor="Red" Text="lblStackTrace"></asp:Label>
          </td>
        </tr>
        <tr>
          <td class="style2">
            TargetSite</td>
          <td>
            <asp:Label ID="lblTargetSite" runat="server" Font-Size="Smaller" 
              ForeColor="Red" Text="lblTargetSite"></asp:Label>
          </td>
        </tr>
        <tr>
          <td class="style2">
            URL</td>
          <td>
            <asp:Label ID="lblURL" runat="server" Font-Size="Smaller" ForeColor="Red" 
              Text="lblURL"></asp:Label>
          </td>
        </tr>
        <tr>
          <td class="style2">
            &nbsp;</td>
          <td>
            <input id="btnVoltar" type="button" value="Voltar" onclick="history.back()"/></td>
        </tr>
      </table>
    </div>
    </form>
</body>
</html>
