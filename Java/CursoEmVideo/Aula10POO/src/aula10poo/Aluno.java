package aula10poo;

/**
 *
 * @author leona
 */
public class Aluno extends Pessoa {
    private int mat;
    private String curso;
    
    public Aluno(int mat, String curso){
        this.mat = mat;
        this.curso = curso;
    }
    
    public void cancelarMatricula(){
        this.setMat(0);
        this.setCurso(this.getCurso() + " Trancado");
        System.out.println("Matricula trancada");
    }
    
    public int getMat(){
        return this.mat;
    }
    
    public String getCurso(){
        return this.curso;
    }
    
    public void setMat(int mat){
       this.mat = mat; 
    }
    
    public void setCurso(String curso){
        this.curso = curso;
    }
    
}
