package PacoteJava;
import javax.swing.*;
public class ExL01E03 {
    public static void main (String[]args ){
        try{
        String valor = JOptionPane.showInputDialog(null, "Informe o raio da circunferencia:");
        double raio = Double.parseDouble(valor);
       double resposta =  2 * 3.1416 * raio;      
   JOptionPane.showMessageDialog(null,"O Raio é: "+raio+" A Circuferencia e de: "+resposta);}
    catch(Exception ex){
            System.out.println("Erro:" + ex);
        }
}
}

