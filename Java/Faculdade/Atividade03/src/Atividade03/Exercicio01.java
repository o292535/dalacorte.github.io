package atividade03;
import javax.swing.*;
public class Exercicio01 {
    public static void main(String[] args) {
        int vendas[][][] = new int[6][6][6];
        int quantDoces = 0, quantSalgados = 0, quantBolos = 0;
        String aux1 = "", aux2 = "", aux3 = "";
        int i=03;
            for(i=0;i<6;i++){
                String aux = JOptionPane.showInputDialog(null,"Digite a quantidade de doces vendidos no "+(i+1)+"º mês");
                vendas [i][1][1] = Integer.parseInt(aux);
                aux = JOptionPane.showInputDialog(null,"Digite a quantidade de salgados vendidos no "+(i+1)+"º mês");
                vendas [1][i][1] = Integer.parseInt(aux); 
                aux = JOptionPane.showInputDialog(null,"Digite a quantidade de bolos vendidos no "+(i+1)+"º mês");
                vendas [1][1][i] = Integer.parseInt(aux);
            }    
            for(i=0;i<6;i++){ 
                aux1 += vendas[i][1][1] + "\n";
                aux2 += vendas[1][i][1] + "\n";
                aux3 += vendas[1][1][i] + "\n";
                quantDoces += vendas[i][1][1];
                quantSalgados += vendas[1][i][1];
                quantBolos += vendas[1][1][i];
            }
            JOptionPane.showMessageDialog(null, "Valores doces: " + aux1 + "\tValores salgados: " + aux2 + "\tValores bolos: " + aux3);
            JOptionPane.showMessageDialog(null, "Quantidade total de doces: "+ quantDoces+ "\nQuantidade total de salgados: " + quantSalgados + 
                    "\nQuantidade total de bolos: " + quantBolos + "\n\nQuantidade total: " +(quantDoces+quantSalgados+quantBolos));
         }
}
