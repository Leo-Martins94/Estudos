package aula10poo;

public class Professor extends Pessoa {
    private String especialista;
    private float salario;
    
    public Professor(String especialista, float salario){
        this.especialista = especialista;
        this.salario = salario;
    }
    
    public void receberAum(float aum){
        this.setSalario(this.getSalario()+ aum);
    }
    
    public String getEspecialista(){
        return this.especialista;
    }
    
    public float getSalario(){
       return this.salario;
    }
    
    public void setEspecialista(String especialista){
        this.especialista = especialista;
    }
    
    public void setSalario(float salario){
        this.salario = salario;
    }
    
}
