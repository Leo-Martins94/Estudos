package aula05poo;

public class ContaCorrente {
  private String nome;
  private int cpf;
  private float saldo;
  
  public ContaCorrente(String n, int cpf){
      this.setNome(n);
      this.setCpf(cpf);
      this.setSaldo(0.00f);
      
  }
  
  public String getNome(){
      return this.nome;
  }
  
  public int getCpf(){
      return this.cpf;
  }
  
  public double getSaldo(){
      return this.saldo;
  }
  
  public void setNome(String n){
      this.nome = n;
  }
  
  public void setCpf (int cpf){
      this.cpf = cpf;
  }
  
  public void setSaldo (float s){
      this.saldo = s;
  }
  
  public void deposito(float dep){
      this.saldo += dep;
  }
  
  public void saque(float saq){
      this.saldo -= saq;
  }
  
  
  public void getStatus(){
      System.out.println("Extrato");
      System.out.println("Correntista: " + this.getNome());
      System.out.println("C.P.F: " + this.getCpf());
      System.out.println("Saldo: " + this.getSaldo());
      System.out.println("----------------------------------");
  }
  
}
