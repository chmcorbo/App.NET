<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebSP1._Default" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 100%;
            margin-bottom: 4px;
        }
        .style2
        {
            width: 93px;
        }
    </style>
  <script src="scripts.js" type="text/javascript"></script>
</head>
<body>
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server" 
      EnableScriptGlobalization="True">
          </asp:ScriptManager>
    <div>
    
        <p style="height: 19px; width: 725px"> 
          
        </p>
    <table class="style1">
        <tr>
            <td class="style2">
                Campo1
            </td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                  ControlToValidate="TextBox1" ErrorMessage="Campo requerido"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="style2">
                Campo 2</td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                <cc1:CalendarExtender ID="CalendarExtender" runat="server" Enabled="True" 
                  FirstDayOfWeek="Sunday" PopupButtonID="ImageButton1" 
                  PopupPosition="BottomRight" TargetControlID="TextBox2">
                </cc1:CalendarExtender>
                <cc1:MaskedEditExtender ID="MaskedEditExtender" runat="server" 
                  AutoCompleteValue="111" CultureAMPMPlaceholder="" 
                  CultureCurrencySymbolPlaceholder="" CultureDateFormat="" 
                  CultureDatePlaceholder="" CultureDecimalPlaceholder="" 
                  CultureThousandsPlaceholder="" CultureTimePlaceholder="" Enabled="True" 
                  ErrorTooltipEnabled="True" Mask="99/99/9999" MaskType="Date" 
                  PromptCharacter="#" TargetControlID="TextBox2">
                </cc1:MaskedEditExtender>
                <asp:ImageButton ID="ImageButton1" runat="server" 
                  ImageUrl="~/Calendar_scheduleHS.png" />
            </td>
        </tr>
        <tr>
            <td class="style2">
                Campo 3</td>
            <td>
                <asp:DropDownList ID="DropDownList1" runat="server" Width="175px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="style2">
                Campo 4</td>
            <td>
                <asp:ListBox ID="ListBox1" runat="server" Width="255px"></asp:ListBox>
            </td>
        </tr>
        <tr>
            <td class="style2">
                <asp:Button ID="Button1" runat="server" Text="Gravar" />
            </td>
            <td>
                <asp:Button ID="Button2" runat="server" Text="Cancelar" />
                <asp:Button ID="Button3" runat="server" CausesValidation="False" 
                  onclick="Button3_Click" Text="Button" UseSubmitBehavior="False" />
            </td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
    
    
    </div>
    </form>
</body>
</html>
