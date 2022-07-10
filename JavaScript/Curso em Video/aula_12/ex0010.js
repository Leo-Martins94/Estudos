const verificar = () =>{
    let txtidade = document.getElementById("txtida");
    let idade = Number(txtidade.value)
    let res = document.getElementById("res")
    res.innerHTML= `<p>Quem tem ${idade} anos de idade </p>`
    if(idade < 16){
        res.innerHTML += `<p>Ainda não pode votar</p>`
        //console.log(`Não vota`)
    }else if (idade < 18 || idade > 67 ) {
        res.innerHTML += `<p>Pode votar de forma facultativa. Exerça seu direito de voto</p>`
        //console.log(`Voto opicional`)
        }else {
         res.innerHTML += `<p>Deve exercer o diereito de voto obrigatoriamente. </p>`
         //console.log(`Voto obrigatorio`)
    }
}