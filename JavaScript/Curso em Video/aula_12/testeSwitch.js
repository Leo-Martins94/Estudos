 const consultar = () =>{   
    let res = document.getElementById("res");
    let agora = new Date();
    let dia = agora.getDay();

    switch (dia) {
        case 0:
            console.log(`Domingo`)
            break;
        case 1:
            console.log(`Segunda`)
            break;
        case 2:
            console.log(`Terça`)
            break;
        case 3:
            console.log(`Quarta`)
            break;
        case 4:
            console.log(`Quinta`)
            break;
        case 5:
            res.innerHTML += `<p>Hoje é sexta - feira</p>`
            console.log(`Sexta`)
            break;
        case 6:
            console.log(`Sábado`)
            break;
        default:
            console.log(`Erro, dia invalido`)
            break;
    }
 }