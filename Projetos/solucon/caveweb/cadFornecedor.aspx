<%@ Page Title="" Language="C#" MasterPageFile="~/Modelo.master" AutoEventWireup="true" CodeBehind="cadFornecedor.aspx.cs" Inherits="CaveWeb.cadFornecedor" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">




    <p>
    <asp:Label ID="Label1" runat="server" CssClass="titulo2" 
      Text="CADASTRO DE FORNECEDOR"></asp:Label>
    </p>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <table class="tabela" style="width: 100%">
                <tr>
                    <td style="width: 75px">
                        Razão Social</td>
                    <td style="width: 298px">
                        <asp:TextBox ID="txbRazaoSocial" runat="server" CssClass="textbox" 
                          Width="293px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                          ControlToValidate="txbRazaoSocial" ErrorMessage="Razão social não informado" 
                          SetFocusOnError="True">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td style="width: 75px">
                        CNPJ</td>
                    <td style="width: 298px">
                        <asp:TextBox ID="txbCNPJ" runat="server" CssClass="input_med" Width="110px"></asp:TextBox>
                        <cc1:MaskedEditExtender ID="MaskedEdit" runat="server" 
                          CultureAMPMPlaceholder="" CultureCurrencySymbolPlaceholder="" 
                          CultureDateFormat="" CultureDatePlaceholder="" CultureDecimalPlaceholder="" 
                          CultureThousandsPlaceholder="" CultureTimePlaceholder="" Enabled="True" 
                          Mask="99,999,999/9999-99" PromptCharacter="#" TargetControlID="txbCNPJ">
                        </cc1:MaskedEditExtender>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                          ControlToValidate="txbCNPJ" CssClass="alerta_min" 
                          ErrorMessage="CNPJ não informado">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td style="width: 75px">
                        Insc. Estadual</td>
                    <td style="width: 298px">
                        <asp:TextBox ID="txbInscEstadual" runat="server" CssClass="input_med" 
                          Width="80px"></asp:TextBox>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td style="width: 75px">
                        Insc Municipal</td>
                    <td style="width: 298px">
                        <asp:TextBox ID="txbInscMunicipal" runat="server" CssClass="input_med" 
                          Width="80px"></asp:TextBox>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
            </table>
        </ContentTemplate>
    </asp:UpdatePanel>
  <div>
        <asp:Label ID="lbMsgErro" runat="server" CssClass="alerta_min" Text="lbMsgErro" 
          Visible="False"></asp:Label>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
          CssClass="alerta_min" DisplayMode="List" />
  </div>
  <div>
        <asp:ImageButton ID="ibtAlterar" runat="server" Height="22px" 
          ImageUrl="~/img/alterar_btn.gif"  
          CausesValidation="False" onclick="ibtAlterar_Click" />
        <asp:ImageButton ID="ibtGravar" runat="server" 
          ImageUrl="~/img/gravar_btn.gif" onclick="ibtGravar_Click" />
        <asp:ImageButton ID="ibtExcluir" runat="server" 
          ImageUrl="~/img/excluir_btn.gif" onclick="ibtExcluir_Click" 
          onclientclick="return confirm('Confirma eliminação desse registro?'); "  />
        <asp:ImageButton ID="ibtCancelar" runat="server" 
          ImageUrl="~/img/cancelar_btn.gif" CausesValidation="False" 
          onclick="ibtCancelar_Click" />
  </div>
    <p>
    </p>
</asp:Content> 