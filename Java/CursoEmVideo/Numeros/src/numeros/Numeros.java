/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package numeros;

import java.util.Scanner;

/**
 *
 * @author leona
 */
public class Numeros {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here.
        Scanner teclado = new Scanner(System.in);
        String resp;
        int n, s = 0;
        
        do{
            System.out.print("Digite um número: ");
            n = teclado.nextInt();
            s +=n;
            System.out.print("Quer continuar? s/n");
            resp = teclado.next();
        } while (resp.equals("s"));
        
        System.out.println("A soma de todos os valores digitados é " + s);
        
    }
    
}
