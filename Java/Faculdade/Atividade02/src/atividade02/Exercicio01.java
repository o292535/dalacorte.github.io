package atividade02;
import javax.swing.*;
public class Exercicio01{
    public static void main (String [] args){
        int doces[] = new int[10];
        int salgados[] = new int[10];
        int somadoce = 0, somasalgado = 0;
        String aux2 = "", aux3 = "";
        for (int i=0;i<10;i++){
        String aux = JOptionPane.showInputDialog(null,"Doces comprados no " + (i+1) +"º dia"); 
        doces[i] = Integer.parseInt(aux);
        aux = JOptionPane.showInputDialog(null,"Salgados comprados no " + (i+1) +"º dia"); 
        salgados[i] = Integer.parseInt(aux);
        }
        for (int i=0;i<10;i++){
        
        aux2 += "Valor dos doce nos "+(i+1) +"º dia: R$"+ doces[i]*2 + ",00\n";   
        aux3 += "Valor dos salgados no "+(i+1) +"º dia: R$"+ salgados[i]*3 + ",00\n";
        somadoce += doces[i];
        somasalgado += salgados[i];
        }
        JOptionPane.showMessageDialog(null,aux2);
        JOptionPane.showMessageDialog(null,aux3);
        JOptionPane.showMessageDialog(null,"Soma total dos doces: R$" + somadoce * 2 + ",00\n" +
                "Soma total dos salgados: R$"+ somasalgado * 3 + ",00\n" +
                "Média total dos doces: R$"+ (somadoce*2)/10 + "\n" +
                "Média total dos salgados: R$"+ (somasalgado*3)/10 + "\n" +
                "Valor total: R$" + (somadoce * 2 + somasalgado * 3) + ",00");
    }
}
