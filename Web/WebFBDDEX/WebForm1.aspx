﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebFBDDEX.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="btnTestarConexao" runat="server" 
            onclick="btnTestarConexao_Click" Text="Testar Conexão" />
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Voltar" />
        <br />
        <asp:Label ID="Label1" runat="server" Font-Names="Verdana" Font-Size="X-Small" 
            ForeColor="Red" Text="Label" Visible="False"></asp:Label>
    
    </div>
    </form>
</body>
</html>