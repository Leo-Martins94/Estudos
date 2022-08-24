/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package pkgswitch;

import java.util.Scanner;

/**
 *
 * @author leona
 */
public class Switch {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        Scanner teclado = new Scanner(System.in);
        int pernas;
        String tipo;
        
        System.out.print("Digite a quantidade de patas ou pernas:");
        pernas = teclado.nextInt();
        System.out.print("Isso é um :");
        switch(pernas){
            case 2:
                tipo = "Bipede";
                break;
            case 3:
                tipo = "Tripede (talvez exista)";
                break;
            case 4:
                tipo = "Quadrupedi";
                break;
            case 6:
                tipo = "Araquinideo";
                break;
            default:
                tipo = "Indefinido";
                break;
        }
        System.out.println(tipo);
    }
    
}
