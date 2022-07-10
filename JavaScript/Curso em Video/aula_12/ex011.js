const horas = () =>{   
    let res = document.getElementById("hora")
    let agora = new Date()
    let hora = agora.getHours();

    res.innerHTML += `<p>Agora são exatamente ${hora} horas.</p>`
    console.log(`Agora são exatamente ${hora} horas.`);

    if (hora < 12){
        console.log(`Bom dia.`)
    }else if(hora <= 18){
        res.innerHTML += `<p> Tenha uma Boa Tarde. </p>`
        console.log(`Boa tarde.`)
    }else{
        console.log(`Boa Noite.`)
    }
}