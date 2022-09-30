package aula12poo;

public class Aula12POO {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        
        Mamifero m = new Mamifero();
        Reptil r = new Reptil();
        Peixe p = new Peixe();
        Ave a = new Ave();
        
        m.setPeso(36.5f);
        m.setCorDoPelo("Marrom");
        m.alimentar();
        m.locomover();
        m.emitirSom();
        
    }
    
}
