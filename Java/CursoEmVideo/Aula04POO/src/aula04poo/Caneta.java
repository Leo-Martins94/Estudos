package aula04poo;

public class Caneta {
    private String modelo;
    private String cor;
    private float ponta;
    private boolean tampada;
    
    public Caneta(String m, float p){
        setModelo(m);
        setPonta(p);
        this.cor = "Azul";
        this.tampar();
        
        
    }
    
    public String getModelo(){
        return this.modelo;
    }
    
    public float getPonta(){
        return this.ponta;
    }
    
    public boolean getTampada(){
        return this.tampada;
    }
    
    public void getStatus(){
        System.out.println("É uma caneta");
        System.out.println("Modelo: " + this.getModelo());
        System.out.println("Ponta: " + this.getPonta());
        System.out.println("Cor: " + this.cor);
        System.out.println("Está tampada ? " + this.getTampada());
    }
    
    public void setModelo(String m){
        this.modelo = m;
    }
    
    public void setPonta(float p){
        this.ponta = p;
    }
    
    public void tampar(){
        this.tampada = true;
    }
    
    public void destampar(){
        this.tampada = false;
    }
    
    
    
    
}
