package aula10poo;

public class Aula10POO {

    public static void main(String[] args) {
        
        Pessoa p1 = new Pessoa();
        Aluno p2 = new Aluno(123, "Ciencia da computacao");
        Professor p3 = new Professor("Java", 10000.00f);
        Funcionario p4 = new Funcionario("Secretaria", false);
        
        p1.setNome("Pedro");
        p2.setNome("Maria");
        p3.setNome("Claudio");
        p4.setNome("Fabiana");
        
        System.out.println(p2.getCurso());
        System.out.println(p3.getSalario());
        System.out.println(p4.getSetor());
        
        
    }
    
}
