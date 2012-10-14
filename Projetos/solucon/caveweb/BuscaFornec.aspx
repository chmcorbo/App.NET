<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BuscaFornec.aspx.cs" Inherits="CaveWeb.BuscarFornec" %>

<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title> Busca rápida de veículos </title>
    <link href="css/estilo.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="frmBuscaFornecedor" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    
    <div style="width: 653px">
    
    
      <table class="tabela">
        <tr>
          <td>
            Razão Social:</td>
          <td>
            <asp:TextBox ID="txbRazao_Social" runat="server" CssClass="input_gdr" 
              MaxLength="50"></asp:TextBox>
          </td>
          <td>
            <asp:ImageButton ID="ibtConsultar" runat="server" 
              ImageUrl="~/img/consultar_btn.gif" onclick="ibtConsultar_Click" />
          </td>
        </tr>
      </table>
    
    
    </div>
    <div style="width: 654px">
    
      <telerik:RadGrid ID="RadGrid1" runat="server" AutoGenerateColumns="False" 
        GridLines="None" onselectedindexchanged="RadGrid1_SelectedIndexChanged" 
        Skin="Web20" Width="653px" AllowPaging="True" AllowSorting="True" 
        onneeddatasource="RadGrid1_NeedDataSource" PageSize="6">
<MasterTableView>
<RowIndicatorColumn Visible="False">
<HeaderStyle Width="20px"></HeaderStyle>
</RowIndicatorColumn>

<ExpandCollapseColumn Visible="False" Resizable="False">
<HeaderStyle Width="20px"></HeaderStyle>
</ExpandCollapseColumn>

  <Columns>
    <telerik:GridBoundColumn DataField="ID" HeaderText="ID" UniqueName="column2">
    </telerik:GridBoundColumn>
    <telerik:GridBoundColumn DataField="RAZAO_SOCIAL" HeaderText="Razão Social" 
      UniqueName="column1" Visible="False">
    </telerik:GridBoundColumn>
    <telerik:GridButtonColumn CommandName="Select" DataTextField="RAZAO_SOCIAL" 
      HeaderText="Razão Social" UniqueName="column">
    </telerik:GridButtonColumn>
  </Columns>

<EditFormSettings>
<PopUpSettings ScrollBars="None"></PopUpSettings>
</EditFormSettings>
</MasterTableView>
      </telerik:RadGrid>
      <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
    
    </div>

    </form>
</body>
</html>
