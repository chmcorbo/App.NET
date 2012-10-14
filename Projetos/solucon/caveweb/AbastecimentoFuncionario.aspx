<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AbastecimentoFuncionario.aspx.cs" Inherits="CaveWeb.AbastecimentoFuncionario" %>

<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <rsweb:ReportViewer ID="ReportViewer1" runat="server" Font-Names="Verdana" 
            Font-Size="8pt" Height="598px" Width="1009px">
            <LocalReport ReportPath="relFuncionarioAbastecimento.rdlc">
                <DataSources>
                    <rsweb:ReportDataSource DataSourceId="ObjectDataSource1" 
                        Name="dsCave_DataTable5" />
                </DataSources>
            </LocalReport>
        </rsweb:ReportViewer>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
            OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" 
            TypeName="CaveWeb.dsCaveTableAdapters.DataTable5TableAdapter">
            <SelectParameters>
                <asp:SessionParameter Name="mes" SessionField="mes" Type="Int32" />
                <asp:SessionParameter Name="ano" SessionField="ano" Type="Int32" />
                <asp:SessionParameter Name="matricula" SessionField="matricula" Type="String" />
            </SelectParameters>
        </asp:ObjectDataSource>
    
    </div>
    </form>
</body>
</html>
