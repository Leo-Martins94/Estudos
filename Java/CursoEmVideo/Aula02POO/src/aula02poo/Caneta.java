/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package aula02poo;

/**
 *
 * @author leona
 */
public class Caneta {
    String modelo;
    String cor;
    float ponta;
    int carga;
    boolean tampada;
    
    void status(){
        System.out.println("Uma caneta " + this.cor);
        System.out.println("Que está tamapada? " + this.tampada);
        System.out.println("Com carga em " + this.carga + "%");
    }
    
    void rabiscar(){
        
        if(this.tampada == true){
            System.out.println("Caneta tampada, por favor destampe para usar");
        } else{
            System.out.println("Rabisco --------");
        }
        
    }
    
    void destampar(){
        
        this.tampada = false;
        System.out.println("Caneta destampada.");
        
    }
    
    void tampar(){
        
        System.out.println("Caneta tampada");
        this.tampada = true;
        
    }
    
}
