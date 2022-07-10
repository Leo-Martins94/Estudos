package one.digitalInovation.collections

fun main (){
    val salarios = DoubleArray(3)
    salarios[0] = 1000.00
    salarios[1] = 3000.00
    salarios[2] = 5000.00



    salarios.forEachIndexed{ index, salario ->
        salarios[index] = salario *1.12
    }
    salarios.forEach{
        println(it)
    }

    val salarios2 = doubleArrayOf(10500.0, 3500.0, 4500.0)

    salarios2.sort()
    salarios2.forEach{
        println(it)
    }


}