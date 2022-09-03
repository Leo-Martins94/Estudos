package pooaula02pratica;

public class Reuniao {
  String data;
  String assunto;
  String setor;
  String prioridade;
  float horario;
  boolean confirmacao; 
  
  void status(){
      System.out.println("Data: " + this.data);
      System.out.println("Horario: " + this.horario);
      System.out.println("Assunto: " + this.assunto);
      System.out.println("Prioridade: " + this.prioridade);
      System.out.println("Confirmada? " + this.confirmacao);
  }
  
  void confirmar(){
      this.confirmacao = true;
  }
  
  void desmarcar(){
      this.confirmacao = false;
  }
  
}
