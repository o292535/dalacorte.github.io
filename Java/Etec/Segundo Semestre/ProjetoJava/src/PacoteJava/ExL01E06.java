package PacoteJava;
import javax.swing.*;
public class ExL01E06 {
    public static void main(String[] args) {
        try{
        String aux = JOptionPane.showInputDialog(null, "Entre com o valor do produto:");
        double valor = Double.parseDouble(aux);
        
         double valor2 = valor * 0.09;
        JOptionPane.showMessageDialog(null,"Valor do desconto: "+valor2+" \n O valor do produto foi de: "+valor );}
        catch(Exception ex){
            System.out.println("Erro:" + ex);
        }
    }
}
