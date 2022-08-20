/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package programaidade;

import java.util.Scanner;

/**
 *
 * @author leona
 */
public class ProgramaIdade {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        Scanner teclado = new Scanner(System.in);
        int anoNasc,anoAtual, idade;
        
        anoAtual = 2022;
        System.out.print("Em que ano você nasceu: ");
        anoNasc = teclado.nextInt();
        idade = anoAtual - anoNasc;
        
        System.out.println("Voce tem " + idade);
        if ( idade < 18){
            System.out.println("Você é menor de idade");
        }else{
            System.out.println("Você é maior de idade");
        }
        
    }
    
}
