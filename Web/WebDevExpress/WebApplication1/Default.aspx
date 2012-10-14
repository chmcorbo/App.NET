<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<%@ Register assembly="DevExpress.Web.ASPxEditors.v8.1, Version=8.1.4.0, Culture=neutral, PublicKeyToken=9b171c9fd64da1d1" namespace="DevExpress.Web.ASPxEditors" tagprefix="dxe" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
      <dxe:ASPxButton ID="ASPxButton1" runat="server" 
        CssFilePath="~/App_Themes/Office2003 Blue/{0}/styles.css" 
        CssPostfix="Office2003_Blue" Text="Buscar">
      </dxe:ASPxButton>
    
    </div>
    <dxe:ASPxButtonEdit ID="ASPxButtonEdit1" runat="server" 
      CssFilePath="~/App_Themes/Office2003 Blue/{0}/styles.css" 
      CssPostfix="Office2003_Blue" ImageFolder="~/App_Themes/Office2003 Blue/{0}/" 
      onbuttonclick="ASPxButtonEdit1_ButtonClick">
      <Buttons>
        <dxe:EditButton Text="teste">
        </dxe:EditButton>
        <dxe:EditButton Text="teste2">
        </dxe:EditButton>
      </Buttons>
    </dxe:ASPxButtonEdit>
    </form>
</body>
</html>
