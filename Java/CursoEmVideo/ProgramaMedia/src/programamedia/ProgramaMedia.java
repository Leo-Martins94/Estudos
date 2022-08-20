/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package programamedia;

import java.util.Scanner;

/**
 *
 * @author leona
 */
public class ProgramaMedia {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        Scanner teclado = new Scanner(System.in);
        float n1, n2, media;
        
        System.out.print("Digite a primeira nota: ");
        n1 = teclado.nextFloat();
        System.out.print("Digite a segunda nota:");
        n2 = teclado.nextFloat();
        media = (n1+n2)/2;
        
        System.out.println("Sua media foi " + media);
        if (media > 9){
            System.out.println("Parabens");
        }
        
    }
    
}
