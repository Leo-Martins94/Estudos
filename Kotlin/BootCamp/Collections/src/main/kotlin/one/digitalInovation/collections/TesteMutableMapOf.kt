package one.digitalInovation.collections

fun main(){
    val leo = Funcionario("Leo", 3000.00, "Desenvolvedor")
    val ana = Funcionario("Ana", 10000.0, "Presidente")
    val manda = Funcionario("Amanda", 5000.0, "Devenvolvedor")

    val repositorio = Repositorio<Funcionario>()

    repositorio.create(leo.nome, leo)
    repositorio.create(ana.nome, ana)
    repositorio.create(manda.nome, manda)

    println(repositorio.findById(leo.nome))

    println("-----------------------------")

    repositorio.findAll().forEach {
        println(it)
        println("---------------------------")
    }

    repositorio.remove(leo.nome)

    repositorio.findAll().forEach {
        println(it)
        println("---------------------------")
    }

}