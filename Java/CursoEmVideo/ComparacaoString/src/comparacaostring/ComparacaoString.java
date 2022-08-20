/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package comparacaostring;

/**
 *
 * @author leona
 */
public class ComparacaoString {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        String nome1 = "Leonardo";
        String nome2 = "Leonardo";
        String nome3 = new String("Leonardo");
        String res;
        
        //res = (nome1==nome3)?"Igual":"Diferente";
        res = (nome1.equals(nome3))?"Igual":"Diferente";
        
        System.out.println(res);
    }
    
}
