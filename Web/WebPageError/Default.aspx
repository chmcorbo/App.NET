<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebPageError._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
    <style type="text/css">
      .style1
      {
        width: 100%;
        height: 182px;
      }
      .style2
      {
        width: 147px;
      }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
      &nbsp;
      <table class="style1">
        <tr>
          <td class="style2">
            Digite o Valor 1</td>
          <td>
            <asp:TextBox ID="txtValor1" runat="server"></asp:TextBox>
          </td>
        </tr>
        <tr>
          <td class="style2">
                  Operação</td>
          <td>
      <asp:DropDownList ID="ddpOperacao" runat="server">
        <asp:ListItem Value="somar">+</asp:ListItem>
        <asp:ListItem Value="substrair">-</asp:ListItem>
        <asp:ListItem Value="multiplicar">X</asp:ListItem>
        <asp:ListItem Value="dividir">/</asp:ListItem>
      </asp:DropDownList>
          </td>
        </tr>
        <tr>
          <td class="style2">
            Digite o Valor 2te o Valor 2</td>
          <td>
            <asp:TextBox ID="txtValor2" runat="server"></asp:TextBox>
          </td>
        </tr>
        <tr>
          <td class="style2">
      <asp:Button ID="btnCalcularResultado" runat="server" onclick="Button1_Click" 
        Text="Resultado" />
          </td>
          <td>
      <asp:Label ID="LbResultado" runat="server" ForeColor="Red" Text="Label"></asp:Label>
    
          </td>
        </tr>
      </table>
      <br />
    
    </div>
    </form>
</body>
</html>
