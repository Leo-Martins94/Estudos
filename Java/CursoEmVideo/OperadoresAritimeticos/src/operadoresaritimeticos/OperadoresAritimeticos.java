/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package operadoresaritimeticos;

/**
 *
 * @author leona
 */
public class OperadoresAritimeticos {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        int n1 = 3;
        int n2 = 5;
        float m = (n1 + n2) /2;
        System.out.println("A media é " + m);
        
        int numero = 0;
        ++numero;
        System.out.println(numero);
        
        int x = 4;
        x +=2;
        x /= 2;
        System.out.println(x);
        
        float raiz = (float) Math.sqrt(x);
        System.out.println("A Raiz de X é "+ raiz);
        
        float xy = 5.3f;
        float arF = (float) Math.floor(xy);
        float arC = (float) Math.ceil(xy);
        float arR = (float) Math.round(xy);
        System.out.println("Xy é: " + xy);
        System.out.println("Xy arredondado para baixo: " + arF);
        System.out.println("Xy arredondado para cima: " + arC);
        System.out.println("Xy arredondado: " + arR);
        
        double ale = Math.random();
        int resul = (int) (0 + ale * (21-0));
        System.out.println("O numero aleatorio é: " + resul);
    }
    
}
