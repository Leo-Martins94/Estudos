package aula07poo;

import java.util.Random;

public class Luta implements evento {
    
    private Lutador desafiado;
    private Lutador desafiante;
    private int rounds;
    private boolean aprovado;
    
    public Luta(int r){
        this.setRounds(r);
    }
    
    public void marcarLuta(Lutador l1, Lutador l2) {
        if(l1.getCategoria().equals(l2.getCategoria()) && l1 != l2){
            this.setAprovado(true);
            this.setDesafiado(l1);
            this.setDesafiante(l2);
        }else{
            this.setAprovado(false);
            this.setDesafiado(null);
            this.setDesafiante(null);
        }
    }
    
    public Lutador getDesafiado(){
        return this.desafiado;
    }
    
    public Lutador getDesafiante(){
        return this.desafiante;
    }
    
    public int getRounds(){
        return this.rounds;
    }
    
    public boolean getAprovado(){
        return this.aprovado;
    }
    
    public void setDesafiado(Lutador ldd){
        this.desafiado = ldd;
    }
    
    public void setDesafiante(Lutador ldt){
        this.desafiante = ldt;
    }
    
    public void setRounds(int r){
        this.rounds = r;
    }
    
    public void setAprovado(boolean a){
        this.aprovado = a;
    }

    @Override
    public void lutar() {
        if(this.getAprovado() == true){
            System.out.println("Helo Heloo Heeeloooo!!!!");
            System.out.println("E na noite de hoje o desafiado ");
            this.desafiado.apresentar();
            System.out.println("vai enfentrar o desafiante ");
            this.desafiante.apresentar();
            
            Random aleatorio = new Random();
            int vencedor = aleatorio.nextInt(3);
            
            switch(vencedor){
                case 0:
                    System.out.println("Após uma verdadeira batalha a luta acaba empatada");
                    this.desafiado.empatarLuta();
                    this.desafiante.empatarLuta();
                    break;
                case 1:
                    System.out.println("Após um batalha e mocionante o " + 
                            this.desafiado.getNome() + " vence");
                    this.desafiado.ganharLuta();
                    this.desafiante.perderLuta();
                    break;
                case 2:
                    System.out.println("Após uma luta eletrisante " +
                            this.desafiante.getNome() + "leva a luta");
                    this.desafiado.perderLuta();
                    this.desafiante.ganharLuta();
                    break;
                
            }
            
            
        }else{
            System.out.println("Luta reprovada");
        }
    }
    
}
