package PacoteJava;
import javax.swing.*;
public class ExL02E08 {
    public static void main(String[] args) {
        try{
        String aux = JOptionPane.showInputDialog(null, "Informe o código do produto: \n 001 \n 002 \n 003");
        double produto = Double.parseDouble(aux);
        if(produto == 001){
            JOptionPane.showMessageDialog(null,"O produto é um parafuso");
        }
        else if(produto == 002){
            JOptionPane.showMessageDialog(null,"O produto é um porca");
        }
        else if(produto == 003){
            JOptionPane.showMessageDialog(null,"O produto é um prego");
        }
        else if(produto%1 == 0){
            JOptionPane.showMessageDialog(null,"Diversos");
        }}catch(Exception ex){
            System.out.println("Erro:" + ex);
        }
    }
}
