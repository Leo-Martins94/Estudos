package one.digitalInovation.collections

fun main(){
    val leo = Funcionario("Leo", 3000.00, "Desenvolvedor")
    val ana = Funcionario("Ana", 10000.0, "Presidente")
    val manda = Funcionario("Amanda", 5000.0, "Devenvolvedor")

    val funcionarios = listOf(leo, ana, manda)

    funcionarios.forEach{
        println(it)
        println("------------")
    }

    println(funcionarios.find{it.nome == "Leo"})

    println("------------------")

    funcionarios.sortedBy { it.salario }.forEach {
        println(it)
    }

    println("------------------")

    funcionarios.sortedBy { it.cargo }.forEach {
        println(it)

    }

}


