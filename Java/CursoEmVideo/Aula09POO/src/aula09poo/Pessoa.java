package aula09poo;

public class Pessoa {
    private String nome;
    private int idade;
    private char sexo;
    
    public Pessoa(String n, int i, char s){
        this.setNome(n);
        this.setIdade(i);
        this.setSexo(s);
    }
    
    public void fazerAniversario(){
        this.setIdade(this.getIdade() +1);
    }
    
    public String getNome(){
        return this.nome;
    }
    
    public int getIdade(){
        return this.idade;
    }
    
    public char getSexo(){
        return this.sexo;
    }
    
    public void setNome(String n){
        this.nome = n;
    }
    
    public void setIdade(int i){
        this.idade = i;
    }
    
    public void setSexo(char s){
        this.sexo = s;
    }
    
    
    
}
