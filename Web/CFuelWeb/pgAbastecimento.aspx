<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="pgAbastecimento.aspx.cs" Inherits="CFuelWeb.pgAbastecimento" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
    <style type="text/css">
      .style1
      {
        width: 25%;
      }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div> 
      <h1 style="text-align: center"> CFuel - Controle de Abastecimento </h1>
    </div>
    <div> 
      <h2 style="text-align: left"> Lançamento de Abastecimento </h2>
    </div>
    <div>
    
      <table class="style1">
        <tr>
          <td>
            ID</td>
          <td>
            <asp:Label ID="lbID" runat="server" Text="0"></asp:Label>
          </td>
          <td>
            &nbsp;</td>
        </tr>
        <tr>
          <td>
            Data</td>
          <td>
            <asp:TextBox ID="txtData" runat="server"></asp:TextBox>
          </td>
          <td>
            &nbsp;</td>
        </tr>
        <tr>
          <td>
            Hora</td>
          <td>
            <asp:TextBox ID="txtHora" runat="server"></asp:TextBox>
          </td>
          <td>
            &nbsp;</td>
        </tr>
        <tr>
          <td>
            Combustível</td>
          <td>
            <asp:DropDownList ID="ddCombustivel" runat="server" DataTextField="descricao" 
              DataValueField="ID" Width="300px">
            </asp:DropDownList>
          </td>
          <td>
            &nbsp;</td>
        </tr>
        <tr>
          <td>
            KM</td>
          <td>
            <asp:TextBox ID="txtKM" runat="server" AutoPostBack="True" 
              ontextchanged="txtLitragem_TextChanged"></asp:TextBox>
          </td>
          <td>
            &nbsp;</td>
        </tr>
        <tr>
          <td>
            Litragem</td>
          <td>
            <asp:TextBox ID="txtLitragem" runat="server" AutoPostBack="True" 
              ontextchanged="txtLitragem_TextChanged"></asp:TextBox>
          </td>
          <td>
            &nbsp;</td>
        </tr>
        <tr>
          <td>
            Km / Litro</td>
          <td>
            <asp:Label ID="lbKmLitro" runat="server" Text="0"></asp:Label>
          </td>
          <td>
            &nbsp;</td>
        </tr>
        <tr>
          <td>
            Valor Unitário</td>
          <td>
            <asp:TextBox ID="txtValorUnit" runat="server" AutoPostBack="True" 
              ontextchanged="txtValorUnit_TextChanged"></asp:TextBox>
          </td>
          <td>
            &nbsp;</td>
        </tr>
        <tr>
          <td>
            Valor Total</td>
          <td>
            <asp:Label ID="lbValor_total" runat="server" Text="0"></asp:Label>
          </td>
          <td>
            &nbsp;</td>
        </tr>
        <tr>
          <td>
            Posto</td>
          <td>
            <asp:DropDownList ID="ddPosto" runat="server" DataTextField="nome" 
              DataValueField="id" Width="300px">
            </asp:DropDownList>
          </td>
          <td>
            &nbsp;</td>
        </tr>
        <tr>
          <td>
            Observação</td>
          <td>
            <asp:TextBox ID="txtObservacao" runat="server" Height="93px" TextMode="MultiLine" 
              Width="591px"></asp:TextBox>
          </td>
          <td>
            &nbsp;</td>
        </tr>
        <tr>
          <td>
            &nbsp;</td>
          <td>
            <asp:Label ID="lblMsgErro" runat="server" Font-Size="Smaller" ForeColor="Red" 
              Text="Label" Visible="False"></asp:Label>
          </td>
          <td>
            &nbsp;</td>
        </tr>
      </table>
    
    </div>
    <table class="style1">
      <tr>
        <td>
          <asp:Button ID="btnGravar" runat="server" Text="Gravar" 
            onclick="btnGravar_Click" />
        </td>
        <td>
          <asp:Button ID="btnExcluir" runat="server" Text="Excluir" 
            onclick="btnExcluir_Click" />
        </td>
        <td>
          <asp:Button ID="btnVoltar" runat="server" Text="Voltar" 
            onclick="btnVoltar_Click" />
        </td>
      </tr>
    </table>
    </form>
</body>
</html>
