/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package aula13poo;

/**
 *
 * @author leona
 */
public class Cachorro extends Lobo {
    
    @Override
    public void emitirSom() {
        System.out.println("Au Au Au");
    }
    
    public void reagir(String frase){
        if(frase.equals("Pega o petisco")|| frase.equals("Olá")){
            System.out.println("Abanar o Rabo");
        }else{
            System.out.println("Rosnar");
        }
    }
    
    public void reagir(int hora, int min){
        if( hora < 12){
            System.out.println("Abanar no rabo");
        }else if(hora >= 18){
            System.out.println("Ignorar");
        }else{
            System.out.println("Latir");
        }
    }
    
    public void reagir(boolean dono){
        if(dono == true){
            System.out.println("Abanar");
        }else{
            System.out.println("ROsnar e Latir");
        }
    }
    
    public void reagir(int idade, float peso){
        if(idade < 5){
            if(peso < 10){
                System.out.println("Abanar");
            }else{
                System.out.println("Latir");
            }
        } else{
            if(peso < 10){
                System.out.println("Rosnar");
            }else{
                System.out.println("Ignorar");
            }
        }
    }
}
