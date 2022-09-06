package aula06poo;

public class ControleRemoto implements Controlador {
    private int volume;
    private boolean ligado;
    private boolean tocando;
    
    public ControleRemoto(){
        volume = 50;
        ligado = false;
        tocando = false;
    }
    
    public int getVolume(){
        return this.volume;
    }
    
    public boolean isLigado(){
        return this.ligado;
    }
    
    public boolean isTocando(){
        return this.tocando;
    }
    
    public void setVolume(int v){
        this.volume = v;
    }
    
    public void setLigado(boolean l){
        this.ligado = l;
    }
    
    public void setTocando(boolean t){
        this.tocando = t;
    }

    @Override
    public void ligar() {
        this.setLigado(true);
    }

    @Override
    public void desligar() {
        this.setLigado(false);
    }

    @Override
    public void abrirMenu() {
        System.out.println("Está ligado? " + this.isLigado());
        System.out.println("Está tocando? " + this.isTocando());
        System.out.println("Volume: " + this.getVolume());
        System.out.print(this.getVolume());
        for (int cont =0; cont <= this.getVolume(); cont += 10){
            System.out.print("| ");
        }
        
    }

    @Override
    public void fecharMenu() {
        System.out.println("Fechando Menu...");
    }

    @Override
    public void maisVolume() {
       if(this.isLigado() == true){
           this.setVolume(this.getVolume() + 1);
       } 
    }

    @Override
    public void menosVolume() {
        if(this.isLigado() == true){
            this.setVolume(this.getVolume() - 1);
        }
    }

    @Override
    public void ligarMudo() {
        if(this.isLigado() == true && this.getVolume() > 0){
            this.setVolume(0);
        }
    }

    @Override
    public void desligarMudo() {
        if(this.isLigado() == true && this.getVolume() == 0){
            this.setVolume(50);
        }
    }

    @Override
    public void play() {
        if(this.isLigado() && !(this.isTocando())){
            this.setTocando(true);
        }
    }

    @Override
    public void pause() {
        if(this.isLigado() && this.isTocando()){
            this.setTocando(false);
        }
    }
    
    
}
