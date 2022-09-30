package aula12poo;

/**
 *
 * @author leona
 */
public class Ave extends Animal {
    private String corDaPena;
    
    public void construirUmNinho(){
        System.out.println("Construiu um ninho");
    }
    
    public String getCorDaPena() {
        return corDaPena;
    }

    public void setCorDaPena(String corDaPena) {
        this.corDaPena = corDaPena;
    }

    
    
    @Override
    public void locomover() {
        System.out.println("Voando");
    }

    @Override
    public void alimentar() {
        System.out.println("Comendo Frutas");
    }

    @Override
    public void emitirSom() {
        throw new UnsupportedOperationException("Not supported yet."); // Generated from nbfs://nbhost/SystemFileSystem/Templates/Classes/Code/GeneratedMethodBody
    }
}
