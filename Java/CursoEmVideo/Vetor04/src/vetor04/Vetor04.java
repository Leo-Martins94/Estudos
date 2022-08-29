/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package vetor04;

import java.util.Arrays;

/**
 *
 * @author leona
 */
public class Vetor04 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        int v [] = {3, 5, 87, 65, 4, 9, 8, 2, 3, 58};
        int p = Arrays.binarySearch(v,1);
        System.out.println("Entrei o o valor na posição " + p);
    }
    
}
