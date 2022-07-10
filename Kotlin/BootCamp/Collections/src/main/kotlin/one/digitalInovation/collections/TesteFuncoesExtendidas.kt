package one.digitalInovation.collections

fun main(){
val salarios = arrayOf("2000".toBigDecimal(), "3000.00".toBigDecimal(), "1200.0".toBigDecimal())

    println(salarios.somatoria())
    println("-------------------")
    println(salarios.media())

}