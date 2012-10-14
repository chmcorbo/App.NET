<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BuscaFunc.aspx.cs" Inherits="CaveWeb.BuscaFunc" %>

<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Busca rápida de funcionário</title>
    <link href="css/estilo.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
      .style1
      {
        width: 334px;
      }
      #frm
      {
        width: 635px;
      }
      #frmBuscaFunc
      {
        width: 659px;
      }
      .style2
      {
        width: 168px;
      }
      .style3
      {
        width: 45px;
      }
    </style>
</head>
<body>
    <form id="frmBuscaFunc" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server" 
      EnableScriptGlobalization="True">
      </asp:ScriptManager>
    <div>
      <table class="tabela">
        <tr>
          <td class="style3">
            Nome</td>
          <td class="style1">
            <asp:TextBox ID="txbNome" runat="server" CssClass="input_gdr"></asp:TextBox>
          </td>
          <td class="style2">
            <asp:ImageButton ID="ibtConsultar" runat="server" 
              ImageUrl="~/img/consultar_btn.gif" onclick="ibtConsultar_Click" />
          </td>
        </tr>
      </table>
    </div>
    <div style="width: 655px">
      <telerik:RadGrid ID="RadGrid1" runat="server" AllowPaging="True" 
        AllowSorting="True" AutoGenerateColumns="False" GridLines="None" 
        onselectedindexchanged="RadGrid1_SelectedIndexChanged" Skin="Web20" 
        Width="654px" PageSize="6" onitemdatabound="grdBuscaFunc_ItemDataBound">
<MasterTableView>
<RowIndicatorColumn Visible="False">
<HeaderStyle Width="20px"></HeaderStyle>
</RowIndicatorColumn>

<ExpandCollapseColumn Visible="False" Resizable="False">
<HeaderStyle Width="20px"></HeaderStyle>
</ExpandCollapseColumn>

  <Columns>
    <telerik:GridBoundColumn DataField="ID" HeaderText="ID" MaxLength="6" 
      UniqueName="column" DataType="System.Int32">
    </telerik:GridBoundColumn>
    <telerik:GridBoundColumn DataField="MATRICULA" HeaderText="Matrícula" 
      MaxLength="10" UniqueName="column1">
    </telerik:GridBoundColumn>
    <telerik:GridButtonColumn CommandName="Select" DataTextField="NOME" 
      HeaderText="Nome" UniqueName="column2">
    </telerik:GridButtonColumn>
    <telerik:GridBoundColumn DataField="NOME" HeaderText="Nome" MaxLength="50" 
      UniqueName="column3" Visible="False">
    </telerik:GridBoundColumn>
    <telerik:GridBoundColumn DataField="NOME_FUNCAO" HeaderText="Função" MaxLength="30" 
      UniqueName="column4">
    </telerik:GridBoundColumn>
  </Columns>

<EditFormSettings>
<PopUpSettings ScrollBars="None"></PopUpSettings>
</EditFormSettings>
</MasterTableView>
      </telerik:RadGrid>
    </div>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
    </form>
</body>
</html>
