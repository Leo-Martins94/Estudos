function calculadora(){
    const operacao = Number(prompt("Escolha uma operação\n 1 - Soma (+)\n 2 - Subtração (-)\n 3 - Multiplicação (*)\n 4 - Divisão (*)\n 5 - Potencia(**) "));
    console.log(operacao)

    let n1 = Number(prompt("Insira o primeiro valor: "));
    let n2 = Number(prompt("Insira o segundo valor: "));
    let resultado;

    function soma(){
        resultado = n1 + n2;
        alert(`${n1} + ${n2} = ${resultado}`);
        console.log(resultado);
    }

    function subtracao(){
        resultado = n1 - n2;
        alert(`${n1} - ${n2} = ${resultado}`);
        console.log(resultado);
    }

    function multiplicacao(){
        resultado = n1 * n2;
        alert(`${n1} X ${n2} = ${resultado}`);
        console.log(resultado)
    }

    function divisao(){
        resultado = n1 / n2;
        alert(`${n1} / ${n2} = ${resultado}`);
        console.log(resultado)
    }

    function potencia(){
        resultado = n1 ** n2;
        alert(`${n1} ^ ${n2} = ${resultado}`);
        console.log(resultado)
    }

    if(operacao == 1){
        soma();
    }else if(operacao == 2){
        subtracao();
    }else if(operacao == 3){
        multiplicacao();
    }else if(operacao == 4){
        divisao();
    } else if(operacao == 5){
        potencia();
    }else{
        alert("Operação invalida. Reinicie e escolha uma operação ente 1 e 5")
    }
}

calculadora();
