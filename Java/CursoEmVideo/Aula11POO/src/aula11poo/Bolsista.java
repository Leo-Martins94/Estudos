package aula11poo;

/**
 *
 * @author leona
 */
public class Bolsista extends Aluno {
    private float bolsa;
    
    public void renovarBolsa(){
        System.out.println("Bolsa renovada para " + this.getNome());
    }
    
    @Override
    public void pagarMensalidade(){
        System.out.println("Mensalidade paga com desconto de bolsa");
    }

    public float getBolsa() {
        return bolsa;
    }

    public void setBolsa(float bolsa) {
        this.bolsa = bolsa;
    }
    
    
    
}
