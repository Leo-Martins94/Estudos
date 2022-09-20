package aula11poo;

public class Aula11POO {

    public static void main(String[] args) {
        Visitante v1 = new Visitante();
        
        Aluno a1 = new Aluno();
        
        Bolsista b1 = new Bolsista();
        
        
        v1.setNome("Leo");
        
        a1.setNome("Leonardo");
        a1.setIdade(28);
        a1.setSexo("M");
        a1.setMatricula(12356);
        
        a1.setCurso("Ciencia da computação");
        
        System.out.println( a1.toString());
        a1.pagarMensalidade();
        
        
        
        
        
    }
    
}
