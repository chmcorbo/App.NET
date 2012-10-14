<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CaveWeb._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>CAVE - Controle de Abastecimento de Veículos</title>
<link href="css/estilo.css" rel="stylesheet" type="text/css" />
<script language=jscript src="script/scripts.js" type="text/jscript"> </script>
  <style type="text/css">
    .style5
    {
      width: 33px;
    }
    .style6
    {
      width: 211px;
    }
  </style>
</head>

<body>
<div id="header"></div>
<div id="menu"><img src="img/bar.gif" height="35" style="width: 772px" /></div>

<div id="box_conteudo">
  <div id="login">
  <p>&nbsp;</p>
    <p align="center"><img src="img/login.gif" alt="Login" width="200" height="93" /></p>
    <form id="form2" runat="server">
    <table border="0" align="center" style="height: 73px; width: 157px">
      <tr>
        <td class="style5">Login:</td>
        <td class="style6">
          <asp:TextBox ID="txbLogin" runat="server" CssClass="input_login"></asp:TextBox>
        </td>
      </tr>
      <tr>
        <td class="style5">Senha:</td>
        <td class="style6">
          <asp:TextBox ID="txbSenha" runat="server" CssClass="input_login" 
            TextMode="Password"></asp:TextBox>
        </td>
      </tr>
      <tr align="center" colspan="2" >
        <td colspan="2" align="center">
          <asp:ImageButton ID="ibtOK" runat="server" ImageUrl="~/img/ok_btn.png" 
            style="text-align: left; height: 19px" onclick="ImageButton1_Click" />
        </td>
      </tr>
      <tr align="center" colspan="2" >
        <td colspan="2" align="center">
          <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
            CssClass="alerta_min" ErrorMessage="*" ControlToValidate="txbLogin">Login não 
          informado</asp:RequiredFieldValidator>
          <br />
          <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
            CssClass="alerta_min" ErrorMessage="*" ControlToValidate="txbSenha">Senha não 
          informada</asp:RequiredFieldValidator>
          <br />
          <asp:Label ID="lbMsgErro" runat="server" CssClass="alerta_min" Text="Label" 
            Visible="False"></asp:Label>
        </td>
      </tr>
    </table>
    </form>
  </div>
</div>

<div id="footer">
<div id="footer_txt">
  © 2009 - SOLUCON - Soluções, Consultoria e desenvolvimento de Sistemas. Contato: <a href="mailto:suporte@solucon.com.br">
  solucon@solucon.com.br</a>
</div>
</div>
</body>
</html>
