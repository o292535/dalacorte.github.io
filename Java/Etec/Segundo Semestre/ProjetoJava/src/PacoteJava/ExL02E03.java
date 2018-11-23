package PacoteJava;
import javax.swing.*;
public class ExL02E03 {
    public static void main(String[] args) {
        try{
        String aux = JOptionPane.showInputDialog(null, "Digite o primeiro:");
        double numero1 = Double.parseDouble(aux);
        aux = JOptionPane.showInputDialog(null, "Digite o segundo:");
        double numero2 = Double.parseDouble(aux);
        if (numero1 > numero2){
            JOptionPane.showMessageDialog(null, "O maior numero é: "+numero1);
        }else {
            JOptionPane.showMessageDialog(null, "O maior numero é: "+numero2); 
        }}catch(Exception ex){
            System.out.println("Erro:" + ex);
        }
    }
}
