package aula03poo;

public class Aula03POO {

    public static void main(String[] args) {
      Caneta c1 = new Caneta();
       
      c1.modelo = "Bic Cristal";
      c1.cor = "Preta";
      //c1.ponta = 0.5f;
      c1.carga = 80;
      //c1.tampada = true;
      
      c1.tampar();
      c1.status();
      c1.destampar();
      c1.escrever();
      c1.tampar();
      
      
    }
    
}
