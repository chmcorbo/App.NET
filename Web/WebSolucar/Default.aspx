<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default"%>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head><title> Protótipo CAVE Online - Controle de Abastecimento de Veículos </title>

<meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1" />
<style type="text/css">  BODY {
    BACKGROUND-IMAGE: url(imagens/bg.jpg);
    MARGIN: 0px;
    BACKGROUND-REPEAT: repeat-x;
    BACKGROUND-COLOR: #8190AF
  }
    .style1
    {
        width: 201px;
    }
    .textopadrao 
    {
     	  font-family: Verdana, Arial, Helvetica, sans-serif;
     	  font-size: 11px;
     	  line-height: 16px;
     	  color: #6f6f6f;
    }
    .link
    {
	      font-family: Verdana, Arial, Helvetica, sans-serif;
	      font-size: 11px;
	      line-height: 16px;
	      color: Blue;
    }
    .titulo 
    {
	      font-family: Verdana, Arial, Helvetica, sans-serif;
	      font-size: 14px;
	      font-weight: bold;
	      color: #6f6f6f;
	      font-variant: normal;
	      text-transform: uppercase;
	  }

</style>

</head>
<body>
	<form id="form1" runat="server">
	<div>
	<table width="100%" height="100%" border="0" cellpadding="0" cellspacing="0">
  <tr>
	<td valign="top"><table width="740" height="100" border="0" align="center" cellpadding="0" cellspacing="0">
	  <tr>
		<td width="10" valign="top" background="imagens/bg_shadow_esq.jpg">
                        <h5><img src="imagens/bg_shadow_esq_1.jpg" width="10" height="625"/></h5></td>
		<td width="720" valign="top"  bgcolor="#ffffff">
		  <table width="720" height="100%" border="0" cellpadding="0" cellspacing="0">
			<tr>
			  <td colspan="3"><table width="100%" border="0" cellpadding="0" cellspacing="0"><tr>
				<td style="HEIGHT: 14px"></td>
				<td style="HEIGHT: 14px"><div align="right">&nbsp;
</div></td>
			  </tr></table></td>
			</tr>


			<tr>
			  <td width="6" rowspan="6">&nbsp;
</td>
			  <td width="708" height="6" style="text-align: center">
                  <img src="imagens/aba.gif" style="width: 400px; height: 50px" /></td>
			  <td width="6" rowspan="6">&nbsp;
</td>
			</tr>
			<tr>
			  <td valign="top"><table width="708" height="100%" border="0" cellpadding="0" cellspacing="0">


				<tr>
				  <td width="708" height="500" valign="middle" align="center" class="titulo">
										<p>
										  <table cellspacing="1" cellpadding="1" border="0" style="width: 181px">
											  <tr>
												<td class="style1">&nbsp;</td>
											  </tr>
											  <tr>
												<td align="center" class="style1"><img alt="" src="imagens/bg_login.jpg" 
                                                        align="middle" dir="ltr" style="width: 175px; height: 109px;"></td>
											  </tr>
											  <tr>
												<td class="style1"></td>
											  </tr>
										  </table>&nbsp;<table class="tabela" cellspacing="0" cellpadding="0" width="100%" border="0">
        <tr>
          <td></td>
        </tr>
        <tr>
          <td></td>
        </tr>
    </table>


										  <hr width="100%" size="1" class="hr">
Autenticação 
<table cellspacing="1" cellpaddAutenticação 
<table cellspacing="1" cellpadding="1" width="513" border="0" title="Autenticação" rules="all" frame="above" style="WIDTH: 513px; HEIGHT: 114px" align="center" class="tabela">
                                              <tr>
                                                <td style="HEIGHT: 70px">
										<p align="center">
										  <table cellspacing="0" cellpadding="0" width="502" border="0" style="WIDTH: 502px; HEIGHT: 70px" class="tabela">
											  <tr>
												<td style="WIDTH: 176px"><div align="right" class="textopadrao">USUÁRIO:
</div>
</td>
												<td align="left">
												  <asp:TextBox id="tbxUsuario" runat="server" width="128px" 
                                                        causesvalidation="True"  cssclass="textopadrao" 
                            maxlength="10"></asp:TextBox>
                                                            &nbsp;<asp:RequiredFieldValidator id="RequiredFieldValidator1" 
                                                        runat="server" errormessage="Usuário não informado" font-size="XX-Small" 
                                                        controltovalidate="tbxUsuario">Usuário não informado</asp:RequiredFieldValidator></td>
											  </tr>
											  <tr>
												<td style="WIDTH: 176px"><div align="right" class="textopadrao">Senha:</div>
</td>
												<td align="left">
													<asp:TextBox id="tbxSenha" runat="server" causesvalidation="True" width="130px" 
                                                        textmode="Password" cssclass="textopadrao" 
                            maxlength="10"></asp:TextBox>
                                                    &nbsp;<asp:RequiredFieldValidator id="RequiredFieldValidator2" runat="server" errormessage="RequiredFieldValidator" font-size="XX-Small" controltovalidate="tbxSenha">Senha 
                                                    não informada</asp:RequiredFieldValidator>
                                                </td>
											  </tr>
										

										  </table>
                                                    <asp:Label id="lblErro" runat="server" font-size="X-Small" 
                                                forecolor="Red"></asp:Label>
</p></td>

											  </tr>
											  <tr>
												<td>
                                                  <div align="center">
													<asp:Button id="BtnEntrar" runat="server" text="Entrar" cssclass="botao" onclick="BtnEntrar_Click"></asp:Button>
                                                  </div></td>

											  </tr>
										  </table>
										  <hr width="100%" size="1" class="hr">			  




</td>
				  </tr>
				<tr>
				  <td width="708" height="1" background="imagens/tracejado.gif"></td>
				  </tr>
				<tr>
				  <td width="708" height="3"></td>
				  </tr>
				<tr>
				  <td width="708" height="9" background="imagens/linhasdiagonais.gif"></td>
				  </tr>
				<tr>
				  <td width="708" height="3"></td>
				  </tr>
				<tr>
				  <td width="708" height="1" background="imagens/tracejado.gif"></td>
				  </tr>
				<tr>
				  <td width="708" height="40" align="center">&nbsp; 
<div class="textopadrao" style="DISPLAY: inline; WIDTH: 100%; POSITION: relative; HEIGHT: 14px" 
                          ms_positioning="FlowLayout">
    © 2009 - SOLUCON - Soluções, Consultoria e desenvolvimento de Sistemas. Contato:
    <a href="mailto:suporte@maxprocess.com.br" class="link">solucon@solucon.com.br</div>
    <a href="mailto:suporte@maxprocess.com.br">&nbsp;</td>
                  </tr>
				<tr>
				  <td width="708" height="1" background="imagens/tracejado.gif"></td>
				  </tr>
				<tr>
				  <td width="708" height="3"></td>
				  </tr>
				<tr>
				  <td width="708" height="9" background="imagens/linhasdiagonais.gif"></td>
				  </tr>
				<tr>
				  <td width="708" height="3"></td>
				  </tr>
				<tr>
				  <td width="708" height="1" background="imagens/tracejado.gif"></td>
				  </tr>
                </table>             </td>
            </tr>
            <tr>
              <td height="6"></td>
            </tr>
            <tr>
              <td height="9" background="imagens/linhasdiagonais.gif"></td>
            </tr>
            <tr>
              <td height="6"></td>
            </tr>
            <tr>
              <td></td>
            </tr>
          </table>
          </td>
        <td width="10" valign="top" background="imagens/bg_shadow_dir.jpg"><img src="imagens/bg_shadow_dir_1.jpg" width="10" height="625"></td>
	  </tr>
    </table></td>
  </tr>
</table>

    
    
    </div>
    </form>
</body>
</html>