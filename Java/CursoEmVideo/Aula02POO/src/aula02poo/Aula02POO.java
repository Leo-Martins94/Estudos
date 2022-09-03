/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package aula02poo;

/**
 *
 * @author leona
 */
public class Aula02POO {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        Caneta c1 = new Caneta();
        
        c1.modelo = "Esteriografica";
        c1.cor = "Azul";
        c1.ponta = 1.0f;
        c1.carga = 100;
        c1.tampada = true;
        
        c1.status();
        
        c1.rabiscar();
        
        c1.destampar();
        c1.rabiscar();
        
        
    }
    
}
