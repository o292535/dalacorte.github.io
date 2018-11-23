package PacoteJava;
import javax.swing.*;
public class ExL02E10 {
    public static double calculaHoras(int HE,int ME,int HS,int MS){
        HE = HE * 60 + ME;
        HS = HS * 60 + MS;
        int total = HS - HE;
        int aux=0;
        double preco = 0;
        if (total/ 60 <= 1 && total <= 60){
        JOptionPane.showMessageDialog(null, "Valor a ser pago: R$4,00");
        }
        else if (total/ 60 <= 2 && total <= 120){
        JOptionPane.showMessageDialog(null, "Valor a ser pago: R$6,00");
        }
        else{
        total -= 120;
        aux = 0;
        for(int i = 0; i <= total; i++){
        if (i%60 == 0){
        aux += 1;
        }
        }
        JOptionPane.showMessageDialog(null, "Valor a ser pago: R$" + (6 + aux) + ",00");
        }
        return preco;
        }
    public static void main(String[] args) {
        try{
        String aux = JOptionPane.showInputDialog(null, "Informe a hora de entrada: ");
        int horaE = Integer.parseInt(aux);
        aux = JOptionPane.showInputDialog(null, "Informe os minutos de entrada: ");
        int minutosE = Integer.parseInt(aux);
        aux = JOptionPane.showInputDialog(null, "Informe a hora de saída: ");
        int horaS = Integer.parseInt(aux);
        aux = JOptionPane.showInputDialog(null, "Informe os minutos de saída: ");
        int minutosS = Integer.parseInt(aux);
        calculaHoras(horaE, minutosE, horaS, minutosS);
        }
        catch(Exception ex){
        System.out.println("Erro:" + ex);
        } 
    }    
}
