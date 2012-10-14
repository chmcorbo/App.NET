<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebSiteMap._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
    <style type="text/css">
      .style1
      {
        width: 285px;
      }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <table class="style1">
      <tr>
        <td colspan="2">
          Login</td>
      </tr>
      <tr>
        <td>
          Usuário</td>
        <td>
          <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
        </td>
      </tr>
      <tr>
        <td>
          Senha</td>
        <td>
          <asp:TextBox ID="txtSenha" runat="server" TextMode="Password"></asp:TextBox>
        </td>
      </tr>
      <tr>
        <td colspan="2">
          <asp:Button ID="btnEntrar" runat="server" Text="Entrar" 
            onclick="btnEntrar_Click" />
        </td>
      </tr>
    </table>
    <div>
    
    </div>
    </form>
</body>
</html>
