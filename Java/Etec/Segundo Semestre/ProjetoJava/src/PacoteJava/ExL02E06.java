package PacoteJava;
import javax.swing.*;
public class ExL02E06 {
    public static void main(String[] args) {
        try{
        String aux = JOptionPane.showInputDialog(null, "Digite um ano:");
        double numero = Double.parseDouble(aux);
        if (numero%4 == 0){
            JOptionPane.showMessageDialog(null, "O ano é bissexto");
        }else {
            JOptionPane.showMessageDialog(null, "O ano não é bissexto"); 
        }}catch(Exception ex){
            System.out.println("Erro:" + ex);
        }
    }
}
