package aula10poo;

public class Funcionario extends Pessoa{
    private String setor;
    private boolean trabalhando;
    
    public Funcionario(String setor, boolean trabalhando){
        this.setor = setor;
        this.trabalhando = trabalhando;
    }
    
    public void trabalahndo(){
       if(this.getTrabalhando() == true){
           this.setTrabalhando(false);
       }else{
           this.setTrabalhando(true);
       }
    }
    
    public String getSetor(){
        return this.setor;
    }
    
    public boolean getTrabalhando(){
        return this.trabalhando;
    }
    
    public void setSetor(String setor){
        this.setor = setor;
    }
    
    public void setTrabalhando(boolean trabalhando){
        this.trabalhando = trabalhando;
    }
    
}
