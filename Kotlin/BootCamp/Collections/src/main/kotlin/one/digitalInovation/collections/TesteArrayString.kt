package one.digitalInovation.collections

fun main(){
    val nomes = Array(5){""}
    nomes[0] = "Ana"
    nomes[1] = "Amanda"
    nomes[2] = "Estela"
    nomes[3] = "Leo"

    nomes.forEach {
        println(it)
    }
println("---------------------")
println("Ordem alfabetica")
    nomes.sort()
nomes.forEach { println(it) }

println("---------------------")
println("ArrayOf")
    val nome = arrayOf("Leo", "Ana", "Estela", "Paulo", "Celina")

    nome.sort()
    nome.forEach { println(it) }

}