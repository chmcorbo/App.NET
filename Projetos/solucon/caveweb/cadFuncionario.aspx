<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cadFuncionario.aspx.cs" Inherits="CaveWeb.cadFuncionario" MasterPageFile="~/Modelo.master" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Label ID="Label1" runat="server" CssClass="titulo2" 
      Text="CADASTRO DE FUNCIONÁRIO"></asp:Label>
    <br />
    <br />
            <table style="width: 100%" class="tabela">
                <tr>
                    <td style="width: 83px">
                        Matrícula</td>
                    <td style="width: 135px">
                        <asp:TextBox ID="txtMatricula" runat="server" CssClass="textbox" Width="63px"></asp:TextBox>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td style="width: 83px">
                        Nome</td>
                    <td style="width: 135px">
                        <asp:TextBox ID="txtNome" runat="server" CssClass="input_gdr"></asp:TextBox>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td style="width: 83px">
                        Data adimissão</td>
                    <td style="width: 135px">
                        <asp:TextBox ID="txtDataAdmicao" runat="server" CssClass="input_peq" 
                          Width="60px"></asp:TextBox>
                        <cc1:MaskedEditExtender ID="MaskedEdit1" runat="server" 
                          CultureAMPMPlaceholder="" CultureCurrencySymbolPlaceholder="" 
                          CultureDateFormat="" CultureDatePlaceholder="" CultureDecimalPlaceholder="" 
                          CultureThousandsPlaceholder="" CultureTimePlaceholder="" Enabled="True" 
                          Mask="99/99/9999" MaskType="Date" PromptCharacter="#" 
                          TargetControlID="txtDataAdmicao" UserDateFormat="DayMonthYear">
                        </cc1:MaskedEditExtender>
                        <cc1:CalendarExtender ID="CalendarExtender1" runat="server" Enabled="True" 
                          FirstDayOfWeek="Sunday" PopupButtonID="ibtCalendar1" 
                          PopupPosition="BottomRight" TargetControlID="txtDataAdmicao">
                        </cc1:CalendarExtender>
                        <asp:ImageButton ID="ibtCalendar1" runat="server" 
                          ImageUrl="~/img/Calendar.JPG" />
                        <asp:CompareValidator ID="CompareValidator1" runat="server" 
                          ControlToValidate="txtDataAdmicao" ErrorMessage="Data de admissão inválida" 
                          Operator="DataTypeCheck" SetFocusOnError="True" Type="Date">*</asp:CompareValidator>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td style="width: 83px">
                        Data demissão</td>
                    <td style="width: 135px">
                        <asp:TextBox ID="txtDataDemissao" runat="server" CssClass="input_peq" 
                          Width="60px"></asp:TextBox>
                        <cc1:MaskedEditExtender ID="MaskedEdit2" runat="server" 
                          CultureAMPMPlaceholder="" CultureCurrencySymbolPlaceholder="" 
                          CultureDateFormat="" CultureDatePlaceholder="" CultureDecimalPlaceholder="" 
                          CultureThousandsPlaceholder="" CultureTimePlaceholder="" Enabled="True" 
                          Mask="99/99/9999" MaskType="Date" PromptCharacter="#" 
                          TargetControlID="txtDataDemissao" UserDateFormat="DayMonthYear">
                        </cc1:MaskedEditExtender>
                        <cc1:CalendarExtender ID="Calendar2" runat="server" Enabled="True" 
                          PopupButtonID="ibtCalendar2" PopupPosition="BottomRight" 
                          TargetControlID="txtDataDemissao">
                        </cc1:CalendarExtender>
                        <asp:ImageButton ID="ibtCalendar2" runat="server" 
                          ImageUrl="~/img/Calendar.JPG" />
                        <asp:CompareValidator ID="CompareValidator2" runat="server" 
                          ControlToValidate="txtDataDemissao" ErrorMessage="Data de demissão inválida" 
                          Operator="DataTypeCheck" SetFocusOnError="True" Type="Date">*</asp:CompareValidator>
                        <asp:CompareValidator ID="CompareValidator3" runat="server" 
                          ControlToCompare="txtDataAdmicao" ControlToValidate="txtDataDemissao" 
                          ErrorMessage="A data de admissão não pode ser superior que a data de demissão" 
                          Operator="GreaterThan" SetFocusOnError="True" Type="Date">*</asp:CompareValidator>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td style="width: 83px">
                        Num. CNH</td>
                    <td style="width: 135px">
                        <asp:TextBox ID="txtNumCNH" runat="server" CssClass="input_peq"></asp:TextBox>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td style="width: 83px">
                        Classe CNH</td>
                    <td style="width: 135px">
                        <asp:DropDownList ID="ddClasseCNH" runat="server" CssClass="combo_box_peq">
                            <asp:ListItem>Selecione</asp:ListItem>
                            <asp:ListItem>AB</asp:ListItem>
                            <asp:ListItem>AC</asp:ListItem>
                            <asp:ListItem>AD</asp:ListItem>
                            <asp:ListItem>AE</asp:ListItem>
                            <asp:ListItem>B</asp:ListItem>
                            <asp:ListItem>C</asp:ListItem>
                            <asp:ListItem>D</asp:ListItem>
                            <asp:ListItem>E</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td style="width: 83px">
                        Venc. CNH</td>
                    <td style="width: 135px">
                        <asp:TextBox ID="txtVencCNH" runat="server" CssClass="input_peq" Width="60px"></asp:TextBox>
                        <cc1:MaskedEditExtender ID="MaskedEdit3" runat="server" 
                          CultureAMPMPlaceholder="" CultureCurrencySymbolPlaceholder="" 
                          CultureDateFormat="" CultureDatePlaceholder="" CultureDecimalPlaceholder="" 
                          CultureThousandsPlaceholder="" CultureTimePlaceholder="" Enabled="True" 
                          Mask="99/99/9999" MaskType="Date" PromptCharacter="#" 
                          TargetControlID="txtVencCNH" UserDateFormat="DayMonthYear">
                        </cc1:MaskedEditExtender>
                        <cc1:CalendarExtender ID="Calendar3" runat="server" Enabled="True" 
                          PopupButtonID="ibtCalendar3" TargetControlID="txtVencCNH">
                        </cc1:CalendarExtender>
                        <asp:ImageButton ID="ibtCalendar3" runat="server" 
                          ImageUrl="~/img/Calendar.JPG" />
                        <asp:CompareValidator ID="CompareValidator4" runat="server" 
                          ControlToValidate="txtVencCNH" CssClass="alerta_min" 
                          ErrorMessage="Vencimento do CNH é inválido" Operator="DataTypeCheck" 
                          Type="Date">*</asp:CompareValidator>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td style="width: 83px">
                        Função:</td>
                    <td style="width: 135px">
                        <asp:DropDownList ID="ddFuncao" runat="server" CssClass="combo_box_med" 
                            DataTextField="nome" DataValueField="ID">
                        </asp:DropDownList>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
            </table>
            <br />
            <div>
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
                  CssClass="alerta_min" DisplayMode="List" />
                <asp:Label ID="lbMsgErro" runat="server" CssClass="alerta_min" Text="lbMsgErro" 
                    Visible="False"></asp:Label>
                <br />
                <asp:ImageButton ID="ibtAlterar" runat="server" CausesValidation="False" 
                    Height="22px" ImageUrl="~/img/alterar_btn.gif" onclick="ibtAlterar_Click" />
                <asp:ImageButton ID="ibtGravar" runat="server" ImageUrl="~/img/gravar_btn.gif" 
                    onclick="ibtGravar_Click" />
                <asp:ImageButton ID="ibtExcluir" runat="server" 
                    ImageUrl="~/img/excluir_btn.gif" onclick="ibtExcluir_Click" 
                  onclientclick="return confirm('Confirma eliminação desse registro?'); " />
                <asp:ImageButton ID="ibtCancelar" runat="server" CausesValidation="False" 
                    ImageUrl="~/img/cancelar_btn.gif" onclick="ibtCancelar_Click" />
            </div>

</asp:Content>