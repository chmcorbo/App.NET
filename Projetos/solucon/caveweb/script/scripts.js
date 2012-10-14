function voltar_pagina()
{
  history.back();
}
function abrir_emissaoOE()
{
  window.open("RelatorioOE.aspx", "detalhe","width=670,height=660,top=0,left=0,resizable=0,statusbar=0,scrollbars=YES,Menubar=YES");
 // window.open("RelatorioOE.aspx", "detalhe");
}

function fechar()
{
  window.close();
}
// formata data no padrão dd/mm/yyyy
function formatadata(campo, evt) {
//dd/mm/yyyy
evt = getevent(evt);
var tecla = getkeycode(evt);
if (!teclavalida(tecla))
return;
vr = campo.value = filtranumeros(filtracampo(campo));
tam = vr.length;
if (tam >= 2 && tam < 4)
campo.value = vr.substr(0, 2) + '/' + vr.substr(2);
if (tam == 4)
campo.value = vr.substr(0, 2) + '/' + vr.substr(2, 2) + '/';
if (tam > 4)
campo.value = vr.substr(0, 2) + '/' + vr.substr(2, 2) + '/' + vr.substr(4);
//if (tam >= 5 && tam <= 10)
// campo.value = vr.substr(0, 2) + '/' + vr.substr(2, 2) + '/' + vr.substr(4, 4);
}

// formata só números
function formatainteiro(campo, evt) {
//1234567890
evt = getevent(evt);
var tecla = getkeycode(evt);
if (!teclavalida(tecla))
return;
campo.value = filtranumeros(filtracampo(campo));
}

// formata hora no padrao hh:mm
function formatahora(campo, evt) {
//hh:mm
evt = getevent(evt);
var tecla = getkeycode(evt);
if (!teclavalida(tecla))
return;
vr = campo.value = filtranumeros(filtracampo(campo));
if (tam == 2)
campo.value = vr.substr(0, 2) + ':';
if (tam > 2 && tam < 5)
campo.value = vr.substr(0, 2) + ':' + vr.substr(2);
}

// formata o campo quando é digitado somente o mês e o ano
function formatamesano(campo, evt) {
//mm/yyyy
evt = getevent(evt);
var tecla = getkeycode(evt);
if (!teclavalida(tecla))
return;
vr = campo.value = filtranumeros(filtracampo(campo));
tam = vr.length;
if (tam > 2 && tam < 5)
campo.value = vr.substr(0, tam - 2) + '/' + vr.substr(tam - 2, tam);
if (tam >= 5 && tam <= 10)
campo.value = vr.substr(0, 2) + '/' + vr.substr(2, 4);
}

// formata o campo cnpj
function formatacnpj(campo, evt) {
//99.999.999/9999-99
evt = getevent(evt);
var tecla = getkeycode(evt);
if (!teclavalida(tecla))
return;
vr = campo.value = filtranumeros(filtracampo(campo));
tam = vr.length;
if (tam <= 2) {
campo.value = vr;
}
if ((tam > 2) && (tam <= 6)) {
campo.value = vr.substr(0, tam - 2) + '-' + vr.substr(tam - 2, tam);
}
if ((tam >= 7) && (tam <= 9)) {
campo.value = vr.substr(0, tam - 6) + '/' + vr.substr(tam - 6, 4) + '-' + vr.substr(tam - 2, tam);
}
if ((tam >= 10) && (tam <= 12)) {
campo.value = vr.substr(0, tam - 9) + '.' + vr.substr(tam - 9, 3) + '/' + vr.substr(tam - 6, 4) + '-' + vr.substr(tam - 2, tam);
}
if ((tam >= 13) && (tam <= 14)) {
campo.value = vr.substr(0, tam - 12) + '.' + vr.substr(tam - 12, 3) + '.' + vr.substr(tam - 9, 3) + '/' + vr.substr(tam - 6, 4) + '-' + vr.substr(tam - 2, tam);
}
if ((tam >= 15) && (tam <= 17)) {
campo.value = vr.substr(0, tam - 14) + '.' + vr.substr(tam - 14, 3) + '.' + vr.substr(tam - 11, 3) + '.' + vr.substr(tam - 8, 3) + '.' + vr.substr(tam - 5, 3) + '-' + vr.substr(tam - 2, tam);
}
}
// formata o campo cpf
function formatacpf(campo, evt) {
//999.999.999-99
evt = getevent(evt);
var tecla = getkeycode(evt);
if (!teclavalida(tecla))
return;
vr = campo.value = filtranumeros(filtracampo(campo));
tam = vr.length;
if (tam <= 2) {
campo.value = vr;
}
if (tam > 2 && tam <= 5) {
campo.value = vr.substr(0, tam - 2) + '-' + vr.substr(tam - 2, tam);
}
if (tam >= 6 && tam <= 8) {
campo.value = vr.substr(0, tam - 5) + '.' + vr.substr(tam - 5, 3) + '-' + vr.substr(tam - 2, tam);
}
if (tam >= 9 && tam <= 11) {
campo.value = vr.substr(0, tam - 8) + '.' + vr.substr(tam - 8, 3) + '.' + vr.substr(tam - 5, 3) + '-' + vr.substr(tam - 2, tam);
}
}

// formata campo flutuante, permite números e somente uma vírgula
function formatadouble(campo, evt) {
//18,53012
evt = getevent(evt);
var tecla = getkeycode(evt);
if (!teclavalida(tecla))
return;
campo.value = filtranumeroscomvirgula(campo.value);
}

// formata campo telefone
function formatatelefone(campo, evt) {
//0000-0000
evt = getevent(evt);
var tecla = getkeycode(evt);
if (!teclavalida(tecla))
return;
vr = campo.value = filtracampo(campo);
tam = vr.length;
if (tam <= 4)
campo.value = vr;
if (tam > 4)
campo.value = vr.substr(0, tam - 4) + '-' + vr.substr(tam - 4, tam);
}

// formata o campo cep
function formatacep(campo, evt) {
//312555-650
evt = getevent(evt);
var tecla = getkeycode(evt);
if (!teclavalida(tecla))
return;
vr = campo.value = filtranumeros(filtracampo(campo));
tam = vr.length;
if (tam <= 3)
    campo.value = vr;
if (tam > 2)
    campo.value = vr.substr(0, tam - 2) + '-' + vr.substr(tam - 2, tam);
}

// formata o campo cartão de crédito
function formatacartaocredito(campo, evt) {
//0000.0000.0000.0000
evt = getevent(evt);
var tecla = getkeycode(evt);
if (!teclavalida(tecla))
return;
var vr = campo.value = filtranumeros(filtracampo(campo));
var tammax = 16;
var tam = vr.length;
if (tam < tammax && tecla != 8)
{ tam = vr.length + 1; }
if (tam < 5)
{ campo.value = vr; }
if ((tam > 4) && (tam < 9))
{ campo.value = vr.substr(0, 4) + '.' + vr.substr(4, tam - 4); }
if ((tam > 8) && (tam < 13))
{ campo.value = vr.substr(0, 4) + '.' + vr.substr(4, 4) + '.' + vr.substr(8, tam - 4); }
if (tam > 12)
{ campo.value = vr.substr(0, 4) + '.' + vr.substr(4, 4) + '.' + vr.substr(8, 4) + '.' + vr.substr(12, tam - 4); }
}

// limpa todos os caracteres especiais do campo solicitado
function filtracampo(campo) {
var s = "";
var cp = "";
vr = campo.value;
tam = vr.length;
for (i = 0; i < tam; i++) {
if (vr.substring(i, i + 1) != "/"
&& vr.substring(i, i + 1) != "-"
&& vr.substring(i, i + 1) != "."
&& vr.substring(i, i + 1) != ":"
&& vr.substring(i, i + 1) != ",") {
s = s + vr.substring(i, i + 1);
}
}
return s;
//return campo.value.replace("/", "").replace("-", "").replace(".", "").replace(",", "")
}

// limpa todos caracteres que não são números
function filtranumeros(campo) {
var s = "";
var cp = "";
vr = campo;
tam = vr.length;
for (i = 0; i < tam; i++) {
if (vr.substring(i, i + 1) == "0" ||
vr.substring(i, i + 1) == "1" ||
vr.substring(i, i + 1) == "2" ||
vr.substring(i, i + 1) == "3" ||
vr.substring(i, i + 1) == "4" ||
vr.substring(i, i + 1) == "5" ||
vr.substring(i, i + 1) == "6" ||
vr.substring(i, i + 1) == "7" ||
vr.substring(i, i + 1) == "8" ||
vr.substring(i, i + 1) == "9") {
s = s + vr.substring(i, i + 1);
}
}
return s;
//return campo.value.replace("/", "").replace("-", "").replace(".", "").replace(",", "")
}

// limpa todos caracteres que não são números, menos a vírgula
function filtranumeroscomvirgula(campo) {
var s = "";
var cp = "";
vr = campo;
tam = vr.length;
var complemento = 0; //flag paga contar o número de virgulas
for (i = 0; i < tam; i++) {
if ((vr.substring(i, i + 1) == "," && complemento == 0 && s != "") ||
vr.substring(i, i + 1) == "0" ||
vr.substring(i, i + 1) == "1" ||
vr.substring(i, i + 1) == "2" ||
vr.substring(i, i + 1) == "3" ||
vr.substring(i, i + 1) == "4" ||
vr.substring(i, i + 1) == "5" ||
vr.substring(i, i + 1) == "6" ||
vr.substring(i, i + 1) == "7" ||
vr.substring(i, i + 1) == "8" ||
vr.substring(i, i + 1) == "9") {
if (vr.substring(i, i + 1) == ",")
complemento = complemento + 1;
s = s + vr.substring(i, i + 1);
}
}
return s;
}

//recupera tecla
//evita criar mascara quando as teclas são pressionadas
function teclavalida(tecla) {
if (tecla == 8 //backspace
|| tecla == 13 //tab 9
|| tecla == 45 //insert
|| tecla == 46 //delete
|| tecla == 36 //home
|| tecla == 37 //esquerda
|| tecla == 38 //cima
|| tecla == 39 //direita
|| tecla == 40)//baixo
return false;
else
return true;
}

// recupera o evento do form
function getevent(evt) {
if (!evt) evt = window.event; //ie
return evt;
}

//recupera o código da tecla que foi pressionado
function getkeycode(evt) {
var code;
if (typeof (evt.keycode) == 'number')
code = evt.keycode;
else if (typeof (evt.which) == 'number')
code = evt.which;
else if (typeof (evt.charcode) == 'number')
code = evt.charcode;
else
return 0;
return code;
}

function formatar(src, mask)
{
var i = src.value.length;
      var saida = mask.substring(0,1);
      var texto = mask.substring(i)
      if (texto.substring(0,1) != saida)
      {
         src.value += texto.substring(0,1);
      }
}

function digitadata(campo) {
var data = new string( campo.value );
var wdata = '';
var cont = 0;

for (i=0; i<data.length ; i++) {

if (i <= 1) {
if ( data.charat(i) >= '0' && data.charat(i) <= '9' ) {
wdata += data.charat(i);
}
else
{
cont++;
}
}

if (i == 2) {
if ( data.charat(i) == '/' ) {
wdata += data.charat(i);
}
else {
if ( data.charat(i) >= '0' && data.charat(i) <= '9' ) {
wdata += '/';
wdata += data.charat(i);
cont ++;
}
else {
wdata += '/';
cont ++;
}
}
}

if (i > 2 && i <= 4) {
if ( data.charat(i) >= '0' && data.charat(i) <= '9' ) {
wdata += data.charat(i);
}
else
{
cont++;
}
}

if (i == 5) {
if ( data.charat(i) == '/' ) {
wdata += data.charat(i);
}
else {
if ( data.charat(i) >= '0' && data.charat(i) <= '9' ) {
wdata += '/';
wdata += data.charat(i);
cont++;
}
else {
wdata += '/';
cont++;
}
}
}

if (i > 5 && i <= 9) {
if ( data.charat(i) >= '0' && data.charat(i) <= '9' ) {
wdata += data.charat(i);
}
else
{
cont++;
}
}

if (i > 9 )
{
cont++;
}

}

if ( cont > 0 )
{
// atualiza o campo
campo.value = wdata;
}
}

function expRegData(Obj) {
  var expReg = /^((0[1-9]|[12]\d)\/(0[1-9]|1[0-2])|30\/(0[13-9]|1[0-2])|31\/(0[13578]|1[02]))\/(19|20)?\d{2}$/;
  var aRet = true;
  if ((Obj) && (Obj.value.match(expReg)) && (Obj.value != '')) {
    var dia = Obj.value.substring(0,2);
    var mes = Obj.value.substring(3,5);
    var ano = Obj.value.substring(6,10);
    if (mes == 4 || mes == 6 || mes == 9 || mes == 11 && dia > 30) 
      aRet = false;
    else 
      if ((ano % 4) != 0 && mes == 2 && dia > 28) 
        aRet = false;
      else
        if ((ano%4) == 0 && mes == 2 && dia > 29)
          aRet = false;
  }  else 
    aRet = false;  
  return aRet;
}

function verificaDataValida(data) {
	if ((!expRegData(data)) && (data.value.substring(0,2)!=''))
    {
      alert('Data Inválida');
      data.focus();
    }

}
//Bloquea o Enter na página
function bloqEnter(objEvent) {
  var iKeyCode;
  iKeyCode = objEvent.keyCode;
  if(iKeyCode == 13)
    return false;
  else
    return true;
}

function validandodata(data1,obj) {
  var dataatual;
  var data = new Date();

  if (data1!='__/__/____')
  {   
      if (data.getDate()<10)
      {
        dataatual = '0';
        dataatual = dataatual+data.getDate()+'/';
      }
      else
        dataatual = data.getDate()+'/';

      if (data.getMonth()+1<10)
        dataatual = dataatual+'0';

      dataatual = dataatual+(data.getMonth()+1)+'/';

      dataatual = dataatual+data.getFullYear();

      data1     = data1.substr(6,4)+''+data1.substr(3,2)+''+data1.substr(0,2);// Inverte a 2ª data colocando como aaaammdd
      dataatual = dataatual.substr(6,4)+''+dataatual.substr(3,2)+''+dataatual.substr(0,2); // Inverte a 2ª data colocando como aaaammdd

      if (data1 > dataatual)
      {
        alert('A data informada é menor que data atual.');
        obj.focus();
      }
  }
}
