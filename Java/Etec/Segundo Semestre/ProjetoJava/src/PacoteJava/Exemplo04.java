package PacoteJava;
import javax.swing.*;
public class Exemplo04 {
    public static void escrevendo(){
    double num1, num2, num3;
    String aux = " ";
    aux = JOptionPane.showInputDialog(null,"Insira um número","Inserir",1);
    num1 = Double.parseDouble(aux);
    JOptionPane.showMessageDialog(null,"Seu número é: \n"+ num1);
    lol();
    }
    public static void lol(){
        System.out.println("LOL");
    }
}
