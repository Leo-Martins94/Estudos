package aula07poo;

public class Aula07POO {

    public static void main(String[] args) {
        String lutadores [] = {"Pretty Boy","PutScript","SnapShadow","Dead Code",
        "UFOCobol","Nerdart"};
        String nacionalidades [] = {"França","Brasil","EUA","Australia","Brasil",
        "EUA"};
        int idades [] = {31,29,35,28,37,30};
        float alturas [] = {1.75f, 1.68f,1.65f,1.93f,1.70f,1.81f};
        float pesos [] = {68.9f, 57.8f,80.9f,81.6f,119.3f,105.7f};
        int vitorias[] = {11, 14,12,13,5,12};
        int derrotas[] = {2, 2,2,0,4,2};
        int empates[] = {1, 3,1,2,3,4};
        
        Lutador l[] = new Lutador[6];
        
        l[0] = new Lutador(lutadores[0], nacionalidades[0], idades[0],alturas[0],
        pesos[1],vitorias[0],derrotas[0],empates[0]);
        
        l[1] = new Lutador(lutadores[1], nacionalidades[1], idades[1],alturas[1],
        pesos[1],vitorias[1],derrotas[1],empates[1]);
        
        l[2] = new Lutador(lutadores[2], nacionalidades[2], idades[2],alturas[2],
        pesos[2],vitorias[2],derrotas[2],empates[2]);
        
        l[3] = new Lutador(lutadores[3], nacionalidades[3], idades[3],alturas[3],
        pesos[3],vitorias[3],derrotas[3],empates[3]);
        
        l[4] = new Lutador(lutadores[4], nacionalidades[4], idades[4],alturas[4],
        pesos[4],vitorias[0],derrotas[4],empates[4])
                ;
        l[5] = new Lutador(lutadores[5], nacionalidades[5], idades[5],alturas[5],
        pesos[5],vitorias[5],derrotas[5],empates[5]);
        
        Luta UEC01 = new Luta(3);
        
       UEC01.marcarLuta(l[4], l[5]);
       UEC01.lutar();
        l[0].status();
    }
    
}
