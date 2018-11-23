package PacoteJava;
import javax.swing.*;
public class Exemplo03 {
    public static void escrevendo(){
    int num1, num2, num3;
    String aux = " ";
    aux = JOptionPane.showInputDialog(null,"Insira um número");
    num1 = Integer.parseInt(aux);
    JOptionPane.showMessageDialog(null,"Seu númoer é: \n"+ num1);
    }
}
