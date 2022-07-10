/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package linguagemdosistema;

import java.util.Locale;

/**
 *
 * @author lion
 */
public class LinguagemDoSistema {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
       Locale loc = Locale.getDefault();
       System.out.println("A Linguagem do sistema é: ");
       System.out.println(loc.getDisplayLanguage());
       System.out.println(loc.getLanguage());
       
    }
    
}
