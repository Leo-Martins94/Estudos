
package aula07poo;

public class Lutador  implements Card{
    
    private String nome;
    private String nacionalidade;
    private int idade;
    private float altura;
    private float peso;
    private String categoria;
    private int vitorias;
    private int derrotas;
    private int empates;
    
    
    public Lutador( String no, String na, int id, float al, float pe, int vi,
        int de, int em){
        
        this.setNome(no);
        this.setNacionalidade(na);
        this.setIdade(id);
        this.setAltura(al);
        this.setPeso(pe);
        this.setVitorias(vi);
        this.setDerrotas(de);
        this.setempates(em);
        
        
    }
    
    
    public String getNome(){
        return this.nome;
    }
    
    public String getNacionalidade(){
        return this.nacionalidade;
    }
    
    public int getIdade(){
        return this.idade;
    }
    
    public float getAltura(){
        return this.altura;
    }
    
    public float getPeso(){
        return this.peso;
    }
    
    public String getCategoria(){
        return this.categoria;
    }
    
    public int getVitorias(){
        return this.vitorias;
    }
    
    public int getDerrotas(){
        return this.derrotas;
    }
    
    public int getEmpates(){
        return this.empates;
    }
    
    public void setNome(String n){
        this.nome = n;
    } 
    
    public void setNacionalidade(String nasci){
        this.nacionalidade = nasci;
    }
    
    public void setIdade(int idade){
        this.idade = idade;
    }
    
    public void setAltura(float alt){
        this.altura = alt;
    }
    
    public void setPeso(float peso){
        this.peso = peso;
        this.setCategoria();
    }
    
    private void setCategoria(){
        if(this.peso <52.2){
            this.categoria = "Invalido muito leve";
        } else if(this.peso <= 70.3){
            this.categoria = "Leve";
        } else if(this.peso <= 83.9){
            this.categoria = "Medio";
        } else if(this.peso <= 120.2){
            this.categoria = "Pesado";
        }else{
            this.categoria = "Invalido fora de peso";
        }
        
    }
    
    public void setVitorias(int vit){
        this.vitorias = vit;
    }
    
    public void setDerrotas(int der){
        this.derrotas = der;
    }
    
    public void setempates(int empates){
        this.empates = empates;
    }

    @Override
    public void apresentar() {
        System.out.println("Helo Heloo Heeeloooo!!!!");
        System.out.println("From " + this.getNacionalidade());
        System.out.println("Com " + this.getIdade() + "anos de idade");
        System.out.println("Medindo " + this.getAltura());
        System.out.println("Pesando " + this.getPeso());
        System.out.println("Com: ");
        System.out.println(this.getVitorias() + " Vitorias");
        System.out.println(this.getEmpates() + " Empates");
        System.out.println(this.getDerrotas() + " Derrotas");
        System.out.println("Theeee!!!! " + this.getNome());
    }

    @Override
    public void status() {
        System.out.println("Nome: " + this.getNome());
        System.out.println("Categoria: " + this.getCategoria());
        System.out.println("Virotias: " + this.getVitorias());
        System.out.println("Empates: " + this.getEmpates());
        System.out.println("Derrotas: " + this.getDerrotas());
    }

    @Override
    public void ganharLuta() {
        this.setVitorias(this.getVitorias()+1);
    }

    @Override
    public void perderLuta() {
        this.setDerrotas(this.getDerrotas()+1);
    }

    @Override
    public void empatarLuta() {
        this.setempates(this.getEmpates()+1);
    }
    
}
