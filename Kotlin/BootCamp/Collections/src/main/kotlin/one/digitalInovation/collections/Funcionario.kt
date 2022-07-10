package one.digitalInovation.collections

data class Funcionario (
    val nome: String,
    val salario: Double,
    val cargo: String
){
    override fun toString(): String =
        """
           Nome: $nome
           Salario: $salario
           Cargo: $cargo
        """.trimIndent()

}
