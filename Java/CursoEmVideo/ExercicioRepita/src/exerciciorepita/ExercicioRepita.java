/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package exerciciorepita;

import javax.swing.JOptionPane;

/**
 *
 * @author leona
 */
public class ExercicioRepita {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        int n, s=0, par = 0, impar = 0, cem=0,cont= 0, media;
        do{
           n = Integer.parseInt(JOptionPane.showInputDialog(null,
                   "Informe um numero (Digite 0 para interromper): ")); 
           s += n;
           if(n%2 == 0){
               par++;
           }else{
               impar++;
           }
           if(n > 100){
               cem++;
           }
           cont++;
        }while( n != 0);
        media = s/cont;
        JOptionPane.showMessageDialog(null,
                "<html> Resultado final<br/><hr/>"+
                "<br/>Soma dos valores foi: " + s +
                "<br/>Numeros pares: " + par +
                "<br/>Numeros impares: " + impar +
                "<br/>Valores maiores que cem: "+ cem +
                "<br/>Media de todos os valores: "+ media+
                "</html>"       
                );
        
        
    }
    
}
