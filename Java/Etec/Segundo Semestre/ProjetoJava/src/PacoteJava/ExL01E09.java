package PacoteJava;
import javax.swing.*;
public class ExL01E09 {
    public static void main(String[] args) {
        try{
        String aux = JOptionPane.showInputDialog(null, "Informe o tempo gasto na viagem:");
        double tempoviagem = Double.parseDouble(aux);
        aux = JOptionPane.showInputDialog(null, "Informe a velocidade média da viagem:");
        double velocidadeviagem = Double.parseDouble(aux);
        double distancia = tempoviagem * velocidadeviagem;
        double litrosusados = distancia/12;
        JOptionPane.showInputDialog(null, "Quantidade de combustível gasto: "+litrosusados);}
        catch(Exception ex){
            System.out.println("Erro:" + ex);
        }
    }
}
