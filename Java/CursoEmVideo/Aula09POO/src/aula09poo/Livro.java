package aula09poo;

public class Livro implements Publicacao {
    private String titulo;
    private String autor;
    private int totPaginas;
    private int pagAtual;
    private boolean aberto;
    private Pessoa leitor;
    
    public Livro(String t, String a, int tot, Pessoa l){
        this.setTitulo(t);
        this.setAutor(a);
        this.setTotPaginas(tot);
        this.setPagAtual(0);
        this.setAberto(false);
        this.setLeitor(l);
        
    }
    
    public void detalhes(){
        System.out.println("Autor: " + this.getAutor());
        System.out.println("Titulo: " + this.getTitulo());
        System.out.println("Total de páginas: " + this.getTotPaginas());
        System.out.println("Leitor: " + this.getLeitor().getNome());
    }
    
    public String getTitulo(){
        return this.titulo;
    }
    
    public String getAutor(){
        return this.autor;    
    }
    
    public int getTotPaginas(){
        return this.totPaginas;
    }
    
    public int getPagAtual(){
        return this.pagAtual;
    }
    
    public boolean isAberto(){
        return this.aberto;
    }
    
    public Pessoa getLeitor(){
        return this.leitor;
    }
    
    public void setTitulo( String t){
        this.titulo = t;
    }
    
    public void setAutor(String a){
        this.autor = a;
    }
    
    public void setTotPaginas(int totp){
        this.totPaginas = totp;
    }
    
    public void setPagAtual(int pa){
        this.pagAtual = pa;
    }
    
    public void setAberto(boolean ab){
        this.aberto = ab;
    }
    
    public void setLeitor(Pessoa l){
        this.leitor = l;
    }

    @Override
    public void abrir() {
        if(this.isAberto() == true){
            System.out.println("O livro já está aberto");
        }else{
            this.setAberto(true);
            System.out.println("Livro aberto");
        }
    }

    @Override
    public void fechar() {
        if(isAberto() == false){
            System.out.println("O livro já está fechado");
        }else{
           this.setAberto(false);
            System.out.println("Livro fechado");
        }
    }

    @Override
    public void avancarPag() {
        if(this.isAberto() == true){
           if(this.getPagAtual() < this.getTotPaginas()){
                this.setPagAtual(this.getPagAtual()+1);
                System.out.println("Indo para proxima pagina...");
                System.out.println("Estamos agora na pagina " + this.getPagAtual());
            }else{
               System.out.println("Fim do livro");
           } 
        }else{
            System.out.println("O livro está fechado, abra para ler");
        }
        
    }

    @Override
    public void voltarPag() {
        if(this.isAberto() == true){
            if(this.getPagAtual() == 0){
                System.out.println("Já estamos na primiera pagina");
            }else{
                this.setPagAtual(this.getPagAtual()+1);
                System.out.println("Voltando uma pagina...");
                System.out.println("Estamos agora na pagina " + this.getPagAtual());
            }
        }
    }

    @Override
    public void folhear() {
        System.out.println("Folheando.....");
       this.setPagAtual(this.getPagAtual() + 5);
       if(this.getPagAtual() > this.getTotPaginas()){
           this.setPagAtual(this.getTotPaginas());
       }
        System.out.println("Esamos agora na pagina " + this.getPagAtual());
    }   
       
    
}
