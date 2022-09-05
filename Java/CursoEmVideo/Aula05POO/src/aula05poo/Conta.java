package aula05poo;

public class Conta {
    public int numConta;
    protected String tipo;
    private String dono;
    private int saldo;
    private boolean status;
    
    public Conta( int num, String t, String dono){
        this.setnumConta(num);
        this.setTipo(t);
        this.setDono(dono);
        this.setSaldo(0);
        this.status = false;
    }
    
    public void abrirConta(){
        if(this.status == true){
            System.out.println("Sua conta já está aberta");
        }else{
            this.status = true;
            if(this.tipo == "cc"){
                this.saldo +=50;
            }else{
                this.saldo += 150;
            }
            System.out.println("Conta aberta com sucesso");
        }
        
    }
    
    public void fecharConta(){
        if(this.saldo > 0){
            System.out.println("Você ainda possui dinheiro na conta, "
            + this.saldo + " Saque para poder encerrar sua conta");
        }else if (this.saldo < 0){
            System.out.println("Você tem um debito " 
            + this.saldo + " Pague para poder fechar sua conta");
        }else{
            System.out.println("Conta encerrada");
           this.status = false; 
        }
    }
    
    public void depositar(int d){
        this.saldo += d;
    }
    
    public void sacar(int s){
        if(this.saldo <= s){
            this.saldo -= s;
        }else{
            System.out.println("Desculpe, você não possui saldo suficiente "
            + this.saldo);
        }
    }
    
    public void extrato(){
        System.out.println("Extrato");
        System.out.println("Numero da conta: " + this.getNumConta());
        System.out.println("Nome: " + this.getDono());
        System.out.println("Tipo de conta: " + this.getTipo());
        System.out.println("Saldo: " + getSaldo());
        System.out.println("Status: " + getStatus());
    }
    
    public void pagarMensalidade(){
        if(this.tipo == "cc"){
            this.saldo -= 12;
        }else{
            this.saldo += 20;
        }
    }
    
    public int getNumConta(){
        return this.numConta;
    }
    
    public String getTipo(){
        return this.tipo;
    }
    
    public String getDono(){
        return this.dono;
    }
    
    public int getSaldo(){
        return this.saldo;
    }
    
    public boolean getStatus(){
        return this.status;
    }
    
    public void setnumConta(int num){
        this.numConta = num;
    }
    
    public void setTipo(String t){
        if(t == "cc"){
            this.tipo = t;
        }else if(t == "cp"){
            this.tipo = t;
        } else{
            System.out.println("Tipo invalido por favor, indique 'cc' para"
                    + " conta corrente e 'cp' para conta poupança");
        }
    }
    
    public void setDono(String dono){
        this.dono = dono;
    }
    
    public void setSaldo(int s){
        this.saldo = s;
    }
    
}
