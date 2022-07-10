
package resoulcaodatela;

import java.awt.Dimension;
import java.awt.Toolkit;

/**
 *
 * @author lion
 */
public class ResoulcaoDaTela {

    public static void main(String[] args) {
       Dimension tela = Toolkit.getDefaultToolkit().getScreenSize();
       int lar = (int) tela.getWidth();
       int alt = (int) tela.getHeight();
       System.out.println("Sua tela tem a seguinte com=nfiguração: ");
        System.out.println(lar + " De altura");
        System.out.println(alt + " De Largura");
    }
    
}
