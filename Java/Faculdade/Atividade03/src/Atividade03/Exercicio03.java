package atividade03;
import javax.swing.*;
public class Exercicio03 {
    public static void main(String[] args) {
        int pokebolas[][][] = new int[6][6][6];
        int quantPB = 0, quantGB = 0, quantUB = 0;
        String aux1 = "", aux2 = "", aux3 = "";
        int i=03;
            for(i=0;i<6;i++){
                String aux = JOptionPane.showInputDialog(null,"Digite a quantidade de poke ball na sua bolsa: "+(i+1));
                pokebolas [i][1][1] = Integer.parseInt(aux);
                aux = JOptionPane.showInputDialog(null,"Digite a quantidade de great ball na sua bolsa: "+(i+1));
                pokebolas [1][i][1] = Integer.parseInt(aux); 
                aux = JOptionPane.showInputDialog(null,"Digite a quantidade de ultra ball na sua bolsa: "+(i+1));
                pokebolas [1][1][i] = Integer.parseInt(aux);
            }    
            for(i=0;i<6;i++){ 
                aux1 += pokebolas[i][1][1] + "\n";
                aux2 += pokebolas[1][i][1] + "\n";
                aux3 += pokebolas[1][1][i] + "\n";
                quantPB += pokebolas[i][1][1];
                quantGB += pokebolas[1][i][1];
                quantUB += pokebolas[1][1][i];
            }
            JOptionPane.showMessageDialog(null, "Quantidade de poke ball: " + aux1 + "\tQuantidade de great ball: " + aux2 + "\tQuantidade de ultra ball: " + aux3);
            JOptionPane.showMessageDialog(null, "Quantidade total de poke ball: "+ quantPB + "\nQuantidade total de great ball: "+quantGB+"\nQuantidade total de ultra ball: "+
                    quantUB+"\n\nQuantidade total de poke balls: "+(quantPB+quantGB+quantUB));
         }
}
