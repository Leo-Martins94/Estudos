package one.digitalInovation.collections

fun main (){
    val pair : Pair<String, Double> = Pair("Leo", 5000.0)
    val mapI = mapOf(pair)

    mapI.forEach{ (k,v) ->
        println("Chave: $k - Valor: $v")
    }

    println("-------------------")

    val mapII = mapOf(
        "Ana" to 3000.0,
        "Estela" to 1000.0
    )

    mapII.forEach { (k, v) ->
        println(
            "Chave: $k - Valor: $v"
        )
    }

}