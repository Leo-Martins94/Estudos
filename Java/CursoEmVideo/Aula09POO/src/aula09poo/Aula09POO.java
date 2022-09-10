package aula09poo;

public class Aula09POO {

    public static void main(String[] args) {
        Pessoa[] p = new Pessoa[2];
        Livro[] l = new Livro[3];
        
        p[0] = new Pessoa("Leo", 28, 'M');
        p[1] = new Pessoa("Maria", 19, 'F');
    
        
        l[0] = new Livro("Enrevista com o Vampiro", "Anne Rice", 500,p[0]);
        l[1] = new Livro("Harry Potter", "J.K.H", 600,p[1]);
        l[2] = new Livro("Turma da Monica", "Maricio de Souza", 10,p[0]);
        
        l[2].abrir();
        l[2].avancarPag();
        l[2].folhear();
        l[2].folhear();
        l[2].avancarPag();
        l[0].detalhes();
        
        
        
    }
    
}
