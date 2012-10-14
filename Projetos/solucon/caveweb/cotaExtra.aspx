<%@ Page Title="" Language="C#" MasterPageFile="~/Modelo.master" AutoEventWireup="true" CodeBehind="cotaExtra.aspx.cs" Inherits="CaveWeb.CotaExtra" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    <asp:Label ID="Label1" runat="server" CssClass="titulo2" 
      Text="DEFINIÇÃO DE COTA EXTRA"></asp:Label>
    <br />
  </p>

  <asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>
      <table class="tabela">
        <tr>
          <td style="width: 87px; text-align: left; height: 26px;">
            Matrícula</td>
          <td style="height: 26px">
            <asp:TextBox ID="txbMatricula" runat="server" CssClass="input_peq" 
          MaxLength="10" Width="70px" AutoPostBack="True" 
              ontextchanged="txbMatricula_TextChanged">0123456789</asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
              ControlToValidate="txbMatricula" ErrorMessage="Matrícula não informada" 
              SetFocusOnError="True">*</asp:RequiredFieldValidator>
          </td>
          <td style="height: 26px">
            <img ID="imgBuscaFunc" alt="" 
              onclick="ShowLoginWindow(&quot;BuscaFunc.aspx&quot;);" src="img/buscar_btn.gif" 
              style="width: 30px; height: 22px; cursor:hand;" 
              title="Busca rápida de funcionários" /></td>
          <td style="height: 26px">
            Nome</td>
          <td style="height: 26px">
            <asp:TextBox ID="txbNomeFunc" runat="server" CssClass="textbox_desabilitado" 
              Enabled="False" Width="317px">012345678901234567890123456789012345678901234567890</asp:TextBox>
          </td>
        </tr>
        <tr>
          <td style="width: 87px; text-align: left; height: 10px;">
            </td>
          <td style="height: 10px">
            </td>
          <td style="height: 10px">
            </td>
          <td style="height: 10px">
            Função</td>
          <td style="height: 10px">
            <asp:TextBox ID="txbFuncao" runat="server" CssClass="textbox_desabilitado" 
              Enabled="False" MaxLength="50" Width="317px">012345678901234567890123456789012345678901234567890</asp:TextBox>
          </td>
        </tr>
        <tr>
          <td style="width: 87px; height: 22px; text-align: left;">
            Data</td>
          <td>
            <asp:TextBox ID="txbData" runat="server" CssClass="input_peq" Width="60px"></asp:TextBox>
            <cc1:MaskedEditExtender ID="MaskedEditExtender" runat="server" 
              CultureAMPMPlaceholder="" CultureCurrencySymbolPlaceholder="" 
              CultureDateFormat="" CultureDatePlaceholder="" CultureDecimalPlaceholder="" 
              CultureThousandsPlaceholder="" CultureTimePlaceholder="" Enabled="True" 
              Mask="99/99/9999" MaskType="Date" PromptCharacter="#" TargetControlID="txbData">
            </cc1:MaskedEditExtender>
            <cc1:CalendarExtender ID="CalendarExtender" runat="server" Enabled="True" 
              PopupButtonID="ibtCalendar" PopupPosition="Right" TargetControlID="txbData">
            </cc1:CalendarExtender>
            <asp:ImageButton ID="ibtCalendar" runat="server" 
              ImageUrl="~/img/Calendar.JPG" CausesValidation="False" />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
              ControlToValidate="txbData" ErrorMessage="Data não informada" 
              SetFocusOnError="True">*</asp:RequiredFieldValidator>
          </td>
          <td>
            &nbsp;</td>
          <td>
            Quantidade</td>
          <td>
            <asp:TextBox ID="txbQuantidade" runat="server" AutoCompleteType="Disabled" 
              CssClass="input_peq_numerico" MaxLength="3" Width="70px">0</asp:TextBox>
            <asp:CompareValidator ID="CompareValidator2" runat="server" 
              ControlToValidate="txbQuantidade" 
              ErrorMessage="O valor digitado para o campo quantidade não é válido" 
              Operator="DataTypeCheck" SetFocusOnError="True" Type="Integer">*</asp:CompareValidator>
            <asp:CompareValidator ID="CompareValidator1" runat="server" 
              ControlToValidate="txbQuantidade" 
              ErrorMessage="A quantidade não poderá igual ou inferior à zero (0)." 
              Operator="GreaterThan" Type="Integer" ValueToCompare="0">*</asp:CompareValidator>
          </td>
        </tr>
      </table>  
      </ContentTemplate>
      </asp:UpdatePanel>

      <table>
        <tr>
          <td class="tabela" style="width: 88px">
            Justificativa<asp:RequiredFieldValidator ID="RequiredFieldValidator3" 
              runat="server" ControlToValidate="txbJustificativa" 
              ErrorMessage="Justificativa não informada" SetFocusOnError="True">*</asp:RequiredFieldValidator>
          </td>
          <td class="tabela" style="width: 562px">
            <asp:TextBox ID="txbJustificativa" runat="server" CssClass="input_textarea_gdr" 
              Height="109px" MaxLength="100" TextMode="MultiLine" Width="560px"></asp:TextBox>
          </td>
        </tr>
      </table>  
      
      <div>
        <asp:Label ID="lbMsgErro" runat="server" CssClass="alerta_min" Text="lbMsgErro" 
          Visible="False"></asp:Label>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
          CssClass="alerta_min" DisplayMode="List" />
      </div>
  <div>
        <asp:ImageButton ID="ibtGravar" runat="server" ImageUrl="~/img/gravar_btn.gif" 
          onclick="ibtGravar_Click" />
        <asp:ImageButton ID="ibtLimpar" runat="server" 
          ImageUrl="~/img/limpar_btn.gif" onclick="ibtLimpar_Click" 
          CausesValidation="False" />
        <img id="imgVoltar" alt="" src="img/voltar_btn.gif" 
          style="width: 64px; height: 22px" onclick="javascript:location.href=principal.aspx"/></div>
</asp:Content>
