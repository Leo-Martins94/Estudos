


const calcular =() =>{
    var txtv = document.getElementById('txtvel')
    var  vel = Number(txtv.value)
    var res = document.getElementById('res')
    res.innerHTML = `<p>Sua velocidade foi de ${vel} </p>`
    if(vel>60){
        res.innerHTML += `<p><strong> Voce ultrapassou o limite de velocidade. Multado !!</strong></p>`
    }
    res.innerHTML += `<p>Dirija sempre com o cinto de segurança</p> ` 
}


/*if(vel > 60){
  console.log(`Voce ultapassou a velocidade permitida. MULTADO!!`)  
} */

//console.log(`Dirija sempre usando o cinto de segurança`);
//console.log(`A velocidade do seu carro é ${vel} km/h`);
