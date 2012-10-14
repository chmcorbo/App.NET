<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebRadControls._Default" %>

<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
      <asp:ScriptManager ID="ScriptManager1" runat="server">
      </asp:ScriptManager>    
    <div>
    
      <asp:TextBox ID="TextBox1" runat="server" AutoPostBack="True" 
        ontextchanged="TextBox1_TextChanged"></asp:TextBox>
      <asp:CompareValidator ID="CompareValidator1" runat="server" 
        ControlToValidate="TextBox1" 
        ErrorMessage="O valor desse campo deve ser do tipo inteiro." 
        Operator="DataTypeCheck" Type="Integer"></asp:CompareValidator>
    
    </div>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
      ConnectionString="<%$ ConnectionStrings:CAVE_ONLINEConnectionString %>" 
      SelectCommand="SELECT [ID], [LOGIN], [NOME] FROM [USUARIO]">
    </asp:SqlDataSource>
    
      <input id="Submeter" type="submit" value="submit" /></form>
</body>
</html>
