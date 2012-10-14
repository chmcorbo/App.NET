<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebFBDDEX._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
    </head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="BtnConectar" runat="server" onclick="BtnConectar_Click" 
            Text="Testar Conexão com Firebird" Width="250px" />
        <br />
        <asp:Button ID="btnVisualizar" runat="server" onclick="btnVisualizar_Click" 
            Text="Visualização de Dados com Firebird" Width="250px" />
        <br />
    
    </div>
    </form>
</body>
</html>
