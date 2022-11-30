// Tipos primitivos

//boolean
var vDuF = false;
console.log(typeof(vDuF))

//number
var numeroQualquer = 1;
console.log(typeof(numeroQualquer))

//string
var nome = 'leo';
console.log(typeof(nome));

let varTypeLet = "uma valiavel local e de bloco";
console.log(varTypeLet);

const constante = "Constantes são imutavies";
console.log(constante);

//constante = "novo argumento";

var escopoGlobal = 'Global';
console.log(escopoGlobal);

function bloco(){
    let escopoLocal = "Local"
    console.log(escopoLocal)
}

bloco();
//console.log(escopoLocal)

//comparação
var comparcao = '0' == 0;
console.log(comparcao)

//identico
var identico = "0" === 0;
console.log(identico)

//operadores aritimeticos

var adicao = 1+1;
console.log(adicao)

var subtracao = 1-1;
console.log(subtracao);

var multiplicacao = 2*2;
console.log(multiplicacao);

var divisao = 4/2;
console.log(divisao);

var resto = 5%2;
console.log(resto);

var potencia = 3**2;
console.log(potencia);

//operadores relacionais

var maior = 4 > 2;
console.log(maior);

var menor = 8 < 7;
console.log(menor);

var maiorIgual = 10 >= 10;
console.log(maiorIgual);

var menorIgual = 5 <= 6;
console.log(menorIgual);

// operadores relacionais

var e = true && false;
console.log(e);

var ou = true || false;
console.log(ou);

var nao =  !true;
console.log(nao);
