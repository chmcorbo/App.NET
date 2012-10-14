<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="menu.ascx.cs" Inherits="CaveWeb.menu" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<telerik:RadMenu ID="RadMmPrincipal" Runat="server" Skin="Web20" 
  onitemclick="RadMmPrincipal_ItemClick" 
  style="top: 0px; left: 0px; width: 765px" CausesValidation="False">
<CollapseAnimation Type="OutQuint" Duration="200"></CollapseAnimation>
</telerik:RadMenu>
