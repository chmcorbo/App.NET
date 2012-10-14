<%@ Page Title="" Language="C#" MasterPageFile="~/Modelo.master" AutoEventWireup="true" CodeBehind="lancaAbastecAvulso.aspx.cs" Inherits="CaveWeb.Lancamento.AbastecAvulso" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <div class=titulo2>
    Lançamento de Abastecimento Avulso<br />
 </div>
 <div>
   <asp:UpdatePanel ID="UpdatePanel1" runat="server">
   <ContentTemplate>
   <table style="height: 182px;" class="tabela">
     <tr>
       <td style="width: 44px">
         Posto<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
           ControlToValidate="txbID_Fornecedor" ErrorMessage="Posto não informado" 
           SetFocusOnError="True">*</asp:RequiredFieldValidator>
       </td>
       <td style="width: 64px">
         <asp:TextBox ID="txbID_Fornecedor" runat="server" AutoPostBack="True" 
           CssClass="input_peq" ontextchanged="txbID_Fornecedor_TextChanged" Width="60px">29</asp:TextBox>
       </td>
       <td style="width: 18px">
         <img ID="imgBuscaFornec" alt="" 
           onclick="ShowLoginWindow(&quot;BuscaFornec.aspx&quot;);" src="img/buscar_btn.gif" 
           style="width: 30px; height: 22px; cursor:hand;" 
           title="Busca rápida de fornecedores/postos" /></td>
       <td style="width: 401px">
         Razão Social</td>
       <td colspan="4">
         <asp:TextBox ID="txbRazaoSocial" runat="server" CssClass="textbox_desabilitado" 
           ReadOnly="True" Width="270px">POSTO DE SERVICO ESTANCIA DE RIBEIRAO LTDA</asp:TextBox>
       </td>
       <td style="width: 31px">
         &nbsp;</td>
       <td style="width: 77px">
         &nbsp;</td>
     </tr>
     <tr>
       <td style="width: 44px">
         Placa<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
           ControlToValidate="txbPlaca" ErrorMessage="Veículo não informado" 
           SetFocusOnError="True">*</asp:RequiredFieldValidator>
       </td>
       <td style="width: 64px">
         <asp:TextBox ID="txbPlaca" runat="server" AutoPostBack="True" 
           CssClass="input_peq" MaxLength="10" ontextchanged="txbPlaca_TextChanged" 
           Width="60px"></asp:TextBox>
       </td>
       <td style="width: 18px">
         <img ID="imgBuscaVeiculo" alt="" 
           onclick="ShowLoginWindow(&quot;BuscaVeiculo.aspx&quot;);" 
           src="img/buscar_btn.gif" 
           style="width: 30px; height: 22px; cursor:hand;" 
           title="Busca rápida de veículos" /></td>
       <td style="width: 401px">
         Marca</td>
       <td colspan="4">
         <asp:TextBox ID="txbMarca" runat="server" CssClass="textbox_desabilitado" 
           ReadOnly="True" Width="270px">GM</asp:TextBox>
       </td>
       <td style="width: 31px">
         Modelo</td>
       <td style="width: 77px">
         <asp:TextBox ID="txbModelo" runat="server" CssClass="textbox_desabilitado" 
           ReadOnly="True" Width="180px"></asp:TextBox>
       </td>
     </tr>
     <tr>
       <td style="width: 44px">
         Funcionário<asp:RequiredFieldValidator ID="RequiredFieldValidator2" 
           runat="server" ControlToValidate="txbMatricula" 
           ErrorMessage="Funcionário não informado" SetFocusOnError="True">*</asp:RequiredFieldValidator>
       </td>
       <td style="width: 64px">
         <asp:TextBox ID="txbMatricula" runat="server" CssClass="input_peq" Width="60px" 
           AutoPostBack="True" ontextchanged="txbMatricula_TextChanged">8202</asp:TextBox>
       </td>
       <td style="width: 18px">
         <img ID="imgBuscaFunc" alt="" src="img/buscar_btn.gif" 
           style="width: 30px; height: 22px; cursor:hand;" title="Busca rápida de funcionários" 
           onclick="ShowLoginWindow(&quot;BuscaFunc.aspx&quot;);" 
           /></td>
       <td style="width: 401px">
         Nome</td>
       <td colspan="4">
         <asp:TextBox ID="txbNomeFunc" runat="server" CssClass="textbox_desabilitado" 
           ReadOnly="True" Width="270px">12345678901234567890123456789012345678901234567890</asp:TextBox>
       </td>
       <td style="width: 31px">
         Função</td>
       <td style="width: 77px">
         <asp:TextBox ID="txbFuncao" runat="server" CssClass="textbox_desabilitado" 
           ReadOnly="True" Width="180px"></asp:TextBox>
       </td>
     </tr>
     <tr>
       <td style="width: 44px; height: 36px;">
         KM<asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
           ControlToValidate="txbKM" ErrorMessage="Km não informado" 
           SetFocusOnError="True">*</asp:RequiredFieldValidator>
         <asp:CompareValidator ID="CompareValidator3" runat="server" 
           ControlToValidate="txbKM" 
           ErrorMessage="A quilometragem do hodômetro deverá ser inteira" 
           Operator="DataTypeCheck" SetFocusOnError="True" Type="Integer">*</asp:CompareValidator>
       </td>
       <td style="width: 64px; height: 36px;">
         <asp:TextBox ID="txbKM" runat="server" CssClass="input_peq" Width="60px"></asp:TextBox>
       </td>
       <td style="width: 18px; height: 36px;">

       </td>
       <td style="width: 401px; height: 36px;">
         Data<asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
           ControlToValidate="txbData" ErrorMessage="Data não informada" 
           SetFocusOnError="True">*</asp:RequiredFieldValidator>
         <asp:CompareValidator ID="CompareValidator4" runat="server" 
           ControlToValidate="txbData" 
           ErrorMessage="A data do abastecimento digitada não é válida" 
           Operator="DataTypeCheck" Type="Date">*</asp:CompareValidator>
       </td>
       <td style="width: 210px; height: 36px;">
         <asp:TextBox ID="txbData" runat="server" CssClass="input_peq" Width="60px" 
           AutoPostBack="True" ontextchanged="txbData_TextChanged"></asp:TextBox>
         <cc1:MaskedEditExtender ID="MaskedEditExtender" runat="server" 
           CultureAMPMPlaceholder="" CultureCurrencySymbolPlaceholder="" 
           CultureDateFormat="" CultureDatePlaceholder="" CultureDecimalPlaceholder="" 
           CultureThousandsPlaceholder="" CultureTimePlaceholder="" Enabled="True" 
           MaskType="Date" PromptCharacter="#" TargetControlID="txbData" 
           UserDateFormat="DayMonthYear" Mask="99/99/9999">
         </cc1:MaskedEditExtender>
         <cc1:CalendarExtender ID="CalendarExtender" runat="server" Enabled="True" 
           PopupButtonID="ibtCalendar" PopupPosition="BottomRight" 
           TargetControlID="txbData">
         </cc1:CalendarExtender>
         <asp:ImageButton ID="ibtCalendar" runat="server" 
           ImageUrl="~/img/Calendar.JPG" CausesValidation="False" />
       </td>
       <td colspan="2" style="height: 36px">
         Saldo Funcionário 
       </td>
       <td style="width: 63px; height: 36px;">
         <telerik:RadNumericTextBox ID="txbSaldo" Runat="server" 
           CssClass="textbox_desabilitado_numerico" Culture="Portuguese (Brazil)" 
           InvalidStyleDuration="100" ReadOnly="True" Value="74" Width="60px">
<NumberFormat AllowRounding="True"></NumberFormat>
         </telerik:RadNumericTextBox>
       </td>
       <td style="width: 31px; height: 36px;">
         Combustivel<asp:RequiredFieldValidator ID="RequiredFieldValidator8" 
           runat="server" ControlToValidate="ddTipoCombustivel" 
           ErrorMessage="Tipo de combustível não informado" SetFocusOnError="True">*</asp:RequiredFieldValidator>
       </td>
       <td style="width: 77px; height: 36px;">
         
         <asp:DropDownList ID="ddTipoCombustivel" runat="server" CssClass="dropdownlist" 
           AppendDataBoundItems="True" DataTextField="DESCRICAO" DataValueField="ID" 
           Width="180px">
         </asp:DropDownList>
         
       </td>     
     </tr>
     <tr>
     
       <td style="width: 44px; height: 37px;" class="tabela">
         Preço<asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
           ControlToValidate="txbPreco" ErrorMessage="Preço não informado" 
           SetFocusOnError="True">*</asp:RequiredFieldValidator>
         <asp:CompareValidator ID="CompareValidator2" runat="server" 
           ControlToValidate="txbPreco" 
           ErrorMessage="O preço deverá ser um valor superior à zero" 
           Operator="GreaterThan" SetFocusOnError="True" Type="Double" ValueToCompare="0">*</asp:CompareValidator>
       </td>

       <td style="width: 64px; height: 37px;" class="tabela">
         <telerik:RadNumericTextBox ID="txbPreco" Runat="server" 
           Culture="Portuguese (Brazil)" InvalidStyleDuration="100" Type="Currency" 
           Value="1.36" Width="60px" CssClass="input_peq_numerico">
<NumberFormat AllowRounding="True" DecimalDigits="4"></NumberFormat>
         </telerik:RadNumericTextBox>
       </td>
       
       <td style="width: 18px; height: 37px;" class="tabela">

       </td>
       
       <td style="width: 401px; height: 37px;" class="tabela">
         
         Qtde. Litros<asp:RequiredFieldValidator ID="RequiredFieldValidator6" 
           runat="server" ControlToValidate="txbQtdeLitros" 
           ErrorMessage="Qtde de litros não informado" SetFocusOnError="True">*</asp:RequiredFieldValidator>
         
         <asp:CompareValidator ID="CompareValidator1" runat="server" 
           ControlToValidate="txbQtdeLitros" 
           ErrorMessage="Quantidade de litros deve ser um número inteiro" 
           Operator="DataTypeCheck" SetFocusOnError="True" Type="Integer">*</asp:CompareValidator>
         
       </td>
       
       <td colspan="2" style="width: 48px; height: 37px;" class="tabela">

         <telerik:RadNumericTextBox ID="txbQtdeLitros" Runat="server" Value="40" 
           Width="60px" AutoPostBack="True" ontextchanged="txbQtdeLitros_TextChanged" 
           CssClass="input_peq_numerico">
<NumberFormat AllowRounding="True"></NumberFormat>
         </telerik:RadNumericTextBox>

       </td>
       
       <td style="width: 285px; height: 37px;" class="tabela">

         Total</td>
       
       <td style="width: 63px; height: 37px;" class="tabela">

         
         <telerik:RadNumericTextBox ID="txbTotal" Runat="server" CssClass="textbox_numerico" 
           Type="Currency" Value="54.4" Width="60px">
<NumberFormat AllowRounding="True"></NumberFormat>
         </telerik:RadNumericTextBox>
         
         
       </td>
       
       <td style="width: 31px; height: 37px;" class="tabela">
         </td>
       
       <td style="width: 77px; height: 37px;" class="tabela">
         
         
         </td>     
     
     </tr>
   </table>
   </ContentTemplate>
   </asp:UpdatePanel>
   
     <div>
         <asp:Label ID="lbMsgErro" runat="server" CssClass="alerta_min" Text="lbMsgErro" 
           Visible="False"></asp:Label>
         <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
           DisplayMode="List" CssClass="alerta_min" Height="51px" />
     </div>
 </div>
 
   <div>
        <br />
        <asp:ImageButton ID="ibtGravar" runat="server" 
          ImageUrl="~/img/gravar_btn.gif" onclick="ibtGravar_Click" />
        <asp:ImageButton ID="ibtLimpar" runat="server" 
          ImageUrl="~/img/limpar_btn.gif" onclick="ibtLimpar_Click" 
          CausesValidation="False" />
        <asp:ImageButton ID="ibtCancelar" runat="server" 
          ImageUrl="~/img/voltar_btn.gif" CausesValidation="False" 
          onclick="ibtCancelar_Click" Width="59px" />
  </div>

</asp:Content>
