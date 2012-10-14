<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AbastecimentoVeiculo.aspx.cs" Inherits="CaveWeb.AbastecimentoVeiculo" %>

<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
    <style type="text/css">

td{
font-family:Arial, Helvetica, sans-serif;
font-size:11px;
  text-align: left;
}
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <rsweb:ReportViewer ID="ReportViewer1" runat="server" Font-Names="Verdana" 
        Font-Size="8pt" Height="598px" Width="1009px" style="margin-right: 0px">
        <LocalReport ReportPath="relVeiculoAbastecimento.rdlc">
            <DataSources>
                <rsweb:ReportDataSource DataSourceId="ObjectDataSource1" 
                    Name="dsCave_DataTable1" />
            </DataSources>
        </LocalReport>
    </rsweb:ReportViewer>

    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
        OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" 
        TypeName="CaveWeb.dsCaveTableAdapters.DataTable1TableAdapter">
        <SelectParameters>
            <asp:SessionParameter DefaultValue="" Name="dtInicial" SessionField="dtInicial" 
                Type="DateTime" />
            <asp:SessionParameter Name="dtFinal" SessionField="dtFinal" Type="DateTime" />
            <asp:SessionParameter DefaultValue="%" Name="nome" SessionField="nome" />
            <asp:SessionParameter DefaultValue="%" Name="veiculo" SessionField="placa" />
            <asp:SessionParameter DefaultValue="" Name="fornecedor" 
                SessionField="fornecedor" />
        </SelectParameters>
    </asp:ObjectDataSource>
   


   
    

    <div>
    
    </div>
    </form>
</body>
</html>
