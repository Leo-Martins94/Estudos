/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package aula11poo;

/**
 *
 * @author leona
 */
public class Aluno extends Pessoa {
    private int matricula;
    private String curso;
    
    
    public void pagarMensalidade(){
        System.out.println("Mensalidade paga pelo aluno " + this.getNome());
    }

    public int getMatricula() {
        return matricula;
    }

    public void setMatricula(int matricula) {
        this.matricula = matricula;
    }

    public String getCurso() {
        return curso;
    }

    public void setCurso(String curso) {
        this.curso = curso;
    }
    
    
    
    
    
}
