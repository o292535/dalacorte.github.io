package PacoteJava;
import javax.swing.*;
public class ExL01E08 {
    public static void main(String[] args) {
        try{
        String aux = JOptionPane.showInputDialog(null, "Informe o raio da late de óleo:");
        double raio = Double.parseDouble(aux);
        raio = (4/3) * 3.1416 * Math.pow(raio, 3);
        JOptionPane.showMessageDialog(null, "Volume: "+raio);}
        catch(Exception ex){
            System.out.println("Erro:" + ex);
        }
    }
}
