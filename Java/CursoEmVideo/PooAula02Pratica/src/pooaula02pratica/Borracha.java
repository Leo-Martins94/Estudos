/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package pooaula02pratica;

/**
 *
 * @author leona
 */
public class Borracha {
    int tamanho;
    
    void status(){
        System.out.println("Tamanho da borracha: " + this.tamanho);
    }
    
    void apagar(){
        System.out.println("Apagnado...");
        this.tamanho -= 1;
    }
    
}
