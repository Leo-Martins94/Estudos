/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package vetor03;

import java.util.Arrays;

/**
 *
 * @author leona
 */
public class Vetor03 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        double v [] = {3.6, 7.9, 8.9, 3.7};
        
        Arrays.sort(v);
        
        for(double valor:v){
            System.out.println("Valor: " + valor);
        }
        
    }
    
}
