package one.digitalInovation.collections

fun main(){
    val salarios = doubleArrayOf(900.00,5000.0, 3500.0, 2000.0, 8000.0, 10000.0 )

    for (salario in salarios) {
        println(salario)
    }

    println("---------------------")

    println("Maior Salario é: ${salarios.maxOrNull()}")
    println("Menor Salario é: ${salarios.minOrNull()}")
    println("Media Salarial é: ${salarios.average()}")

    val salariosMaiorQueDoisMil = salarios.filter{ it > 2500.0}

    salariosMaiorQueDoisMil.forEach{
        println(it)
    }

    println("---------------------")

    println(salarios.count{ it in 2000.0..5000.00})

    println("---------------------")

    println(salarios.find { it == 900.00 })

    println("---------------------")
    println(salarios.any{ it == 900.0})
}