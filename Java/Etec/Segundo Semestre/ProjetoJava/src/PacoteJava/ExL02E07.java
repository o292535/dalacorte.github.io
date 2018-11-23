package PacoteJava;
import javax.swing.*;
public class ExL02E07 {
    public static void main(String[] args) {
        try{
        String aux = JOptionPane.showInputDialog(null, "Informe o valor pago: R$");
        double pago = Double.parseDouble(aux);
        aux = JOptionPane.showInputDialog(null, "Informe o valor do produto: R$");
        double produto = Double.parseDouble(aux);
        pago = pago - produto;
        JOptionPane.showMessageDialog(null, "O seu troco é de R$: "+ pago);}
    catch(Exception ex){
            System.out.println("Erro:" + ex);
        }
    }
}

