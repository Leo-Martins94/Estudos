package aula03poo;

public class Caneta {
  public String modelo;
  public String cor;
  private float ponta;
  protected int carga;
  private boolean tampada;
   
   public void status(){
       System.out.println("É uma caneta -");
       System.out.println("Modelo: " + this.modelo);
       System.out.println("Cor: " + this.cor);
       System.out.println("Ponta: " + this.ponta);
       System.out.println("Carga: " + this.carga + "%");
       System.out.println("Esta tampada? " + this.tampada);
   }
   
   public void escrever(){
       if(this.tampada == true){
           System.out.println("A caneta está tamapda, destampe para escrever");
       }else{
           System.out.println("Escrevendo....");
       }
   }
   
   public void tampar(){
       this.tampada = true;
       System.out.println("Caneta Tampada");
   }
   
   public void destampar(){
       this.tampada = false;
       System.out.println("Caneta Destampada");
   }
   
}
