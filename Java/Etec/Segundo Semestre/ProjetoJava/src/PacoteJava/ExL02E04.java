package PacoteJava;

import javax.swing.*;

public class ExL02E04 {

    public static void main(String[] args) {
        try {
            int vetor1[] = new int[4];
            int aux = 0, i=0, j=0;
            String aux2 = "";
            for (i = 0; i < 4; i++) {
                aux2 = JOptionPane.showInputDialog(null, "Digite o valor " + i + " do vetor:");
                vetor1[i] = Integer.parseInt(aux2);
            }

            for ( i = 0; i < 5; i++) {
            for (j = 0; j < 4; j++) {
                if (vetor1[j] > vetor1[j + 1]) {
                    int aux3 = vetor1[j];
                    vetor1[j] = vetor1[j + 1];
                    vetor1[j + 1] = aux3;
                }
            }
        }

        for (i = 0; i < 5; i++) {
            vetor1[i] = vetor1[i];
        }
            JOptionPane.showMessageDialog(null, "Menor posição:" + vetor1[0]);
        } catch (Exception ex) {
            System.out.println("Erro:" + ex);
        }
    }
}
