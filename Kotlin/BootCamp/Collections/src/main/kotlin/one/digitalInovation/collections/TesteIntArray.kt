package one.digitalInovation.collections

fun main(){
    val values = IntArray(5)
    values[0] = 1
    values[1] = 2
    values[2] = 3
    values[3] = 4
    values[4] = 5

    for (valor in values){
        println(valor)
    }
    println("------------------")
    println("Com forEach")

    values.forEach{ valor ->
       // println(it) // o it faz o papel da variavel valor nesse caso
        println(valor)
    }

    println("-----------------")
    println("Indice")

    for (pos in values.indices){
        println(values[pos])
    }

    println("-----------------")
    println("Utilizando o recurso sort")

    values.sort()//O recurso Sort serve para ordenar o Array em ordem crescente.
    for (valor in values){
        println(valor)
    }

}