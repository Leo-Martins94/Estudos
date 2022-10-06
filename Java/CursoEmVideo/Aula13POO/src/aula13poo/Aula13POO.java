/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package aula13poo;

/**
 *
 * @author leona
 */
public class Aula13POO {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        Lobo l = new Lobo();
        Cachorro caramelo = new Cachorro();
        l.emitirSom();
        caramelo.emitirSom();
        caramelo.reagir("Olá");
        caramelo.reagir("vai apanhar");
        caramelo.reagir(11,45);
        caramelo.reagir(21,00);
        caramelo.reagir(true);
        caramelo.reagir(false);
        caramelo.reagir(2, 12.5f);
        caramelo.reagir(17, 4.5f);
        
    }
    
}
