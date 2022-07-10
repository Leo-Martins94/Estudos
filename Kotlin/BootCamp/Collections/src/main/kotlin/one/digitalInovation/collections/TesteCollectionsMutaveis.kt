package one.digitalInovation.collections

fun main(){
    val leo = Funcionario("Leonardo", 3000.0, "Desenvolvedor")
    val ana = Funcionario("Ana", 5000.0, "Desenvolvedores")
    val manda = Funcionario("Amanda", 5000.0, "Gerente")
    val angelica = Funcionario("Angelica", 3000.0, "Desenvolvedor")

    val desenvolvedores = mutableListOf( angelica, ana)

    desenvolvedores.forEach {
        println(it)
        println("---------------")

    }

    println("Multable Set Of")

    val gerente = mutableSetOf(manda)

    gerente.add(leo)

    gerente.forEach {
        println(it)
        println("---------------")
    }

}