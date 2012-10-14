<%@ Page Title="CAVE - Cadastro de Veículos" Language="C#" MasterPageFile="~/Modelo.master" AutoEventWireup="true" CodeBehind="cadVeiculo.aspx.cs" Inherits="CaveWeb.CadVeiculo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  
    <p>
    <asp:Label ID="Label1" runat="server" CssClass="titulo2" 
      Text="CADASTRO DE VEICULO"></asp:Label>
    <br />
  </p>
  <asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>
      <table style="width: 100%" class="tabela">
        <tr>
          <td style="width: 79px">
            ID</td>
          <td style="width: 196px">
            <asp:Label ID="lbID" runat="server" Text="0"></asp:Label>
          </td>
          <td>
            &nbsp;</td>
        </tr>
        <tr>
          <td style="width: 79px">
            Placa</td>
          <td style="width: 196px">
            <asp:TextBox ID="txbPlaca" runat="server" CssClass="textbox_desabilitado" 
              MaxLength="50" Width="198px"></asp:TextBox>
          </td>
          <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
              ControlToValidate="txbPlaca" CssClass="alerta_min" 
              ErrorMessage="Placa não informada"></asp:RequiredFieldValidator>
          </td>
        </tr>
        <tr>
          <td style="width: 77px">
            Marca</td>
          <td style="width: 201px">
            <asp:DropDownList ID="ddMarca" runat="server" CssClass="combo_box_med" 
          DataTextField="Descricao" DataValueField="ID" AutoPostBack="True" 
                onselectedindexchanged="ddMarca_SelectedIndexChanged">
            </asp:DropDownList>
          </td>
          <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
          ErrorMessage="Marca não informada" ControlToValidate="ddMarca" 
                CssClass="alerta_min" SetFocusOnError="True"></asp:RequiredFieldValidator>
          </td>
        </tr>
        <tr>
          <td style="width: 77px">
            Modelo</td>
          <td style="width: 201px">
            <asp:DropDownList ID="ddModelo" runat="server" CssClass="combo_box_med" 
          DataTextField="Descricao" DataValueField="ID" AppendDataBoundItems="True">
            </asp:DropDownList>
          </td>
          <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
            ErrorMessage="Modelo não informado" ControlToValidate="ddModelo" 
            CssClass="alerta_min"></asp:RequiredFieldValidator>
          </td>
        </tr>
        <tr>
          <td style="width: 77px">
            Nº Chassi</td>
          <td style="width: 200px">
            <asp:TextBox ID="txbNumChassi" runat="server" CssClass="textbox"></asp:TextBox>
          </td>
          <td>
            &nbsp;</td>
        </tr>
        <tr>
          <td style="width: 77px">
            Cod. Renavam</td>
          <td style="width: 200px">
            <asp:TextBox ID="txbCodRenavam" runat="server" CssClass="textbox"></asp:TextBox>
          </td>
          <td>
            &nbsp;</td>
        </tr>
        <tr>
          <td style="width: 77px">
            Cor</td>
          <td style="width: 200px">
            <asp:TextBox ID="txbCor" runat="server" CssClass="textbox"></asp:TextBox>
          </td>
          <td>
            &nbsp;</td>
        </tr>
        <tr>
          <td style="width: 77px">
            Ano Fab.</td>
          <td style="width: 200px">
            <asp:DropDownList ID="ddAnoFab" runat="server" CssClass="combo_box_peq">
              <asp:ListItem Value="1999"></asp:ListItem>
              <asp:ListItem Value="2000"></asp:ListItem>
              <asp:ListItem Value="2001"></asp:ListItem>
              <asp:ListItem Value="2002"></asp:ListItem>
              <asp:ListItem Value="2003"></asp:ListItem>
              <asp:ListItem Value="2004"></asp:ListItem>
              <asp:ListItem Value="2005"></asp:ListItem>
              <asp:ListItem Value="2006"></asp:ListItem>
              <asp:ListItem Value="2007"></asp:ListItem>
              <asp:ListItem Value="2008"></asp:ListItem>
              <asp:ListItem Selected="True" Value="2009"></asp:ListItem>
              <asp:ListItem Value="2010"></asp:ListItem>
            </asp:DropDownList>
          </td>
          <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
          ControlToValidate="ddAnoFab" CssClass="alerta_min" 
          ErrorMessage="Ano de fabricação não informado" SetFocusOnError="True"></asp:RequiredFieldValidator>
          </td>
        </tr>
        <tr>
          <td style="width: 77px">
            Ano Mod.</td>
          <td style="width: 200px">
            <asp:DropDownList ID="ddAnoMod" runat="server" CssClass="combo_box_peq">
              <asp:ListItem Value="1999"></asp:ListItem>
              <asp:ListItem Value="2000"></asp:ListItem>
              <asp:ListItem Value="2001"></asp:ListItem>
              <asp:ListItem Value="2002"></asp:ListItem>
              <asp:ListItem Value="2003"></asp:ListItem>
              <asp:ListItem Value="2004"></asp:ListItem>
              <asp:ListItem Value="2005"></asp:ListItem>
              <asp:ListItem Value="2006"></asp:ListItem>
              <asp:ListItem Value="2007"></asp:ListItem>
              <asp:ListItem Value="2008"></asp:ListItem>
              <asp:ListItem Selected="True" Value="2009"></asp:ListItem>
            </asp:DropDownList>
          </td>
          <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
          ControlToValidate="ddAnoMod" CssClass="alerta_min" 
          ErrorMessage="Ano do modelo não informado" SetFocusOnError="True"></asp:RequiredFieldValidator>
          </td>
        </tr>
        <tr>
          <td style="width: 77px">
            Cidade</td>
          <td style="width: 200px">
            <asp:TextBox ID="txbCidade" runat="server" CssClass="textbox"></asp:TextBox>
          </td>
          <td>
            &nbsp;</td>
        </tr>
        <tr>
          <td style="width: 77px">
            UF</td>
          <td style="width: 200px">
            <asp:DropDownList ID="ddUF" runat="server" CssClass="combo_box_peq">
              <asp:ListItem selected="True"></asp:ListItem>
              <asp:ListItem value="AC">AC</asp:ListItem>
              <asp:ListItem value="AL">AL</asp:ListItem>
              <asp:ListItem value="AP">AP</asp:ListItem>
              <asp:ListItem value="AM">AM</asp:ListItem>
              <asp:ListItem value="BA">BA</asp:ListItem>
              <asp:ListItem value="CE">CE</asp:ListItem>
              <asp:ListItem value="DF">DF</asp:ListItem>
              <asp:ListItem value="ES">ES</asp:ListItem>
              <asp:ListItem value="GO">GO</asp:ListItem>
              <asp:ListItem value="MA">MA</asp:ListItem>
              <asp:ListItem value="MT">MT</asp:ListItem>
              <asp:ListItem value="MS">MS</asp:ListItem>
              <asp:ListItem value="MG">MG</asp:ListItem>
              <asp:ListItem value="PA">PA</asp:ListItem>
              <asp:ListItem value="PB">PB</asp:ListItem>
              <asp:ListItem value="PR">PR</asp:ListItem>
              <asp:ListItem value="PE">PE</asp:ListItem>
              <asp:ListItem value="PI">PI</asp:ListItem>
              <asp:ListItem value="RJ">RJ</asp:ListItem>
              <asp:ListItem value="RN">RN</asp:ListItem>
              <asp:ListItem value="RS">RS</asp:ListItem>
              <asp:ListItem value="RO">RO</asp:ListItem>
              <asp:ListItem value="RR">RR</asp:ListItem>
              <asp:ListItem value="SC">SC</asp:ListItem>
              <asp:ListItem value="SP">SP</asp:ListItem>
              <asp:ListItem value="SE">SE</asp:ListItem>
              <asp:ListItem value="TO">TO</asp:ListItem>
            </asp:DropDownList>
          </td>
          <td>
            &nbsp;</td>
        </tr>
        <tr>
          <td style="width: 77px">
            Nº Portas</td>
          <td style="width: 200px">
            <asp:TextBox ID="txbNumPortas" runat="server" CssClass="textbox"></asp:TextBox>
          </td>
          <td>
            &nbsp;</td>
        </tr>
        <tr>
          <td style="width: 77px">
            Litros Tanque</td>
          <td style="width: 200px">
            <asp:TextBox ID="txbLitrosTanque" runat="server" CssClass="textbox"></asp:TextBox>
          </td>
          <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
          ControlToValidate="txbLitrosTanque" CssClass="alerta_min" 
          ErrorMessage="Capacidade do tanque não informado" SetFocusOnError="True"></asp:RequiredFieldValidator>
          </td>
        </tr>
      </table>
    </ContentTemplate>
  </asp:UpdatePanel>
  <br />
  <div>
        <asp:Label ID="lbMsgErro" runat="server" CssClass="alerta_min" Text="lbMsgErro" 
          Visible="False"></asp:Label>
        <br />
        <asp:ImageButton ID="ibtAlterar" runat="server" Height="22px" 
          ImageUrl="~/img/alterar_btn.gif" onclick="ibtAlterar_Click" 
          CausesValidation="False" />
        <asp:ImageButton ID="ibtGravar" runat="server" 
          ImageUrl="~/img/gravar_btn.gif" onclick="ibtGravar_Click" />
        <asp:ImageButton ID="ibtExcluir" runat="server" 
          ImageUrl="~/img/excluir_btn.gif" onclick="ibtExcluir_Click" 
          onclientclick="return confirm('Confirma eliminação desse registro?'); "  />
        <asp:ImageButton ID="ibtCancelar" runat="server" 
          ImageUrl="~/img/cancelar_btn.gif" CausesValidation="False" 
          onclick="ibtCancelar_Click" />
  </div>

  
</asp:Content>
