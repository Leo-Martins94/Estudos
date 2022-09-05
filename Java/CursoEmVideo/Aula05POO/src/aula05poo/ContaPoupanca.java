package aula05poo;

public class ContaPoupanca {
    private String nome;
    private int cpf;
    private float saldo;
    private float rendimento = 10.30f;
    
    public ContaPoupanca(String nome, int cpf){
       this.setNome(nome);
       this.setCpf(cpf);
       this.saldo = 0.00f;
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
    
    public double getRendimento(){
        return this.rendimento;
    }
    
    public void setNome(String n){
        this.nome = n;
    }
    
    public void setCpf(int cpf){
        this.cpf = cpf;
    }
    
    public void deposito(float dep){
        this.saldo += dep;
        this.saldo = this.saldo+((saldo*this.rendimento)/100f);
    }
    
    public void getStatus(){
        System.out.println("Extrato");
        System.out.println("Nome: " + this.getNome());
        System.out.println("CPF: " + this.getCpf());
        System.out.println("Saldo: " + this.getSaldo());
        if(this.saldo > 0){
            System.out.println("O seu dinheiro já está rendendo " +
                    this.getRendimento() + " ao mês");
        }else{
            System.out.println("Faça seu primeiro deposito para ter seu"
                    + "dinheiro rendendo todo mês");
        }
        System.out.println("----------------------------");
    }
    
}
