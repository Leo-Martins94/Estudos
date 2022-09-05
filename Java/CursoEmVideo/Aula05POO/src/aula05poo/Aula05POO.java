package aula05poo;

public class Aula05POO {

    public static void main(String[] args) {
        String cliente = "leo";
        String cliente2 = "leonardo";
        String cc = "cc";
        String cp = "cp";
        
        
        Conta c1 = new Conta(1,cc,cliente);
        Conta c2 = new Conta(2,cp,cliente2);
        Conta c3 = new Conta(2,"cx",cliente2);
        
        c3.extrato();
        c1.extrato();
        c2.extrato();
        c1.abrirConta();
        c1.fecharConta();
        c1.sacar(50);
        c1.pagarMensalidade();
        c1.fecharConta();
        c1.depositar(12);
        c1.fecharConta();
        //c1.extrato();
        
        
        /* String nomeCliente = "Leo";
        int cpfCliente = 256487025;
        
        ContaCorrente corrent1 = new ContaCorrente(nomeCliente, cpfCliente);
        ContaPoupanca poup1 = new ContaPoupanca(nomeCliente, cpfCliente);
        
        corrent1.getStatus();
        corrent1.deposito(35.63f);
        corrent1.getStatus();
        corrent1.saque(20.00f);
        corrent1.getStatus();
        
        poup1.getStatus();
        poup1.deposito(100.00f);
        poup1.getStatus();*/
        
        
        
    }
    
}
