package one.digitalInovation.collections

fun main (){
    val values = intArrayOf(0,33, 27, 42, 55, 56,78,89,60,62,61)

    values.sort()
   values.forEach {
       println(it)
   }
}