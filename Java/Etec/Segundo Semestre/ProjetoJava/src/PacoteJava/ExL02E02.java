package PacoteJava;
import javax.swing.*;
public class ExL02E02 {
    public static void main(String[] args) {
        try{
        String aux = JOptionPane.showInputDialog(null, "Digite um número:");
        double numero = Double.parseDouble(aux);
        if (numero%2 == 0){
            JOptionPane.showMessageDialog(null, "O número é primo");
        }else {
            JOptionPane.showMessageDialog(null, "O número é não é primo"); 
        }}catch(Exception ex){
            System.out.println("Erro:" + ex);
        }
    }
}
