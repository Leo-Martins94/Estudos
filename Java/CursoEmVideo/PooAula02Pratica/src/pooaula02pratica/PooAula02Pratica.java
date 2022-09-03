package pooaula02pratica;
public class PooAula02Pratica {
    public static void main(String[] args) {
       
        Borracha b1 = new Borracha();
        Reuniao r1 = new Reuniao();
        
        b1.tamanho =100;
        r1.data = "10.08.2022";
        r1.horario = 16.30f;
        r1.assunto = "Reunião de planejamento semanal";
        r1.setor = "TEC";
        r1.prioridade = "Obrigatoria";
        
        b1.status();
        b1.apagar();
        b1.status();
        
        r1.desmarcar();
        r1.status();
        
    }
    
}
