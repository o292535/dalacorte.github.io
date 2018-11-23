package PacoteJava;
import javax.swing.*;
public class ExL02E05 {
    public static void main(String[] args) {
        try{
        String aux = JOptionPane.showInputDialog(null, "Informe a velocidade do carro:");
        double velocidade = Double.parseDouble(aux);
        aux = JOptionPane.showInputDialog(null, "Informa a velocidade da rua:");
        int rua = Integer.parseInt(aux);
        if(velocidade <= rua){
            JOptionPane.showMessageDialog(null, "Voce não pagará multa. \n Sua velocidade é: "+ velocidade +"\n Velocidade da rua: "+rua);
        }
        if(velocidade >= rua && rua+10 <= velocidade){
         JOptionPane.showMessageDialog(null, "Voce pagará multa de R$50,00. \n Sua velocidade é: "+ velocidade +"\n Velocidade da rua: "+rua);    
        }
        if(velocidade >= rua+11 && rua+30 <= velocidade){
         JOptionPane.showMessageDialog(null, "Voce pagará multa de R$100,00. \n Sua velocidade é: "+ velocidade +"\n Velocidade da rua: "+rua);    
        }      
    }catch(Exception ex){
            System.out.println("Erro:" + ex);
        }
}
}
