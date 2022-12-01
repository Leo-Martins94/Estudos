var jogador1, jogador2 = 0;
var placar;

jogador1=0;
jogador2=0;

jogador1 == 0  && jogador2 == 0 ? console.log("Jogadores validos, comece a partida") : console.log("jogadores invalidos, por gentileza zere o placar")

jogador1 = 1;

    if(jogador1 > 0){
        placar = jogador1 > jogador2
        console.log("Jogardor 1 marcou um ponto")
    }else if(jogador2 >0){
        placar = jogador1 < jogador2
        console.log("Jogador 2 marcou um ponto")
    
    }else{
        console.log("Niguém marcou ponto")
    }

switch (placar){
    case placar = jogador1 > jogador2:
        console.log("Jogador 1 venceu a partida");
    break;
    case placar = jogador1 < jogador2:
        console.log("Jogador 2 venceu a partida");
    break;
    default:
        console.log("A partida termina empatada")
}

console.log(jogador2) 

//repetições

let array = ['a', 'b', 'c', 'd', 'e'];
let objeto = {cor: "Azul", marca:"Ford", modelo:"Mustang"}

for ( indice = 0; indice < array.length; indice++ ){
    console.log(array[indice])
}

// for/in executa uma repetição a partir de uma propriedade
for(let i in array){
    console.log(i);
}

for (let i in objeto){
    console.log(i);
}

//for/of executa repetição a partir de valor
for(i of array){
    console.log(i);
}

//while executa uma ação enquanto o parametro for verdadeiro

var a = 0;

while(a < 10){
    a++;
    console.log(a);
}

//d
 var b = 0;
do{
    b++;
    console.log(b);
}while(b < 10)