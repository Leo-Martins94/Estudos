package one.digitalInovation.collections

fun main(){
    val leo = Funcionario("Leo", 3000.00, "Desenvolvedor")
    val ana = Funcionario("Ana", 10000.0, "Presidente")
    val manda = Funcionario("Amanda", 5000.0, "Devenvolvedor")

    val desenvolvedores = setOf(leo, manda)
    val diretoria = setOf(ana)

    val uniao = desenvolvedores.union(diretoria)

    uniao.forEach {
        println(it)
    }

    println("--------------------------")

    val funcionarios = setOf(leo, manda,ana)
    val demissao = funcionarios.subtract(diretoria)
    demissao.forEach {
        println(it)
    }

    println("--------------------------")

    val funcionarios1 = setOf(leo, manda,ana)
    val cont = funcionarios1.intersect(desenvolvedores)
    cont.forEach {
        println(it)
    }


}