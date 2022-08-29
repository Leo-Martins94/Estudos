/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package vetor02;

import java.time.LocalDate;

/**
 *
 * @author leona
 */
public class Vetor02 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        LocalDate dataAtual = LocalDate.now();
        int anoAtual = dataAtual.getYear();
        String mes[] = {"Janeiro", "Fevereiro", "Marco", "Abril", "Maio", "Junho",
        "Julho", "Agosto","Setembro", "Outubro","Novembro","Dezembro"};
        int tot[] = {31,28,31,30,31,30,31,31,30,31,30,31};
        //anoAtual = 2000;
        
        if(anoAtual%4 == 0){
            tot[1] = 29;
        }
        
        System.out.println(anoAtual);
        for(int cont =0; cont < mes.length; cont++){
            System.out.println("O mês "+mes[cont]+" Tem "+tot[cont]+" dias");
            
        }
        
    }
    
}
