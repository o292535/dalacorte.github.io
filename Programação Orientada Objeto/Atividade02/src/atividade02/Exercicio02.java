package atividade02;

import javax.swing.*;

public class Exercicio02 {

    public static void main(String[] args) {
        double vetor1[] = new double[5];
        double vetor2[] = new double[5];
        double vetor3[] = new double[5];
        String aux1 = "", aux2 = "";
        for (int i = 0; i < 5; i++) {
            String aux = JOptionPane.showInputDialog(null, "Informe o " + (i + 1) + "º valor: ");
            vetor1[i] = Double.parseDouble(aux);
        }

        for (int i = 0; i < 5; i++) {
            for (int j = 0; j < 4; j++) {
                if (vetor1[j] > vetor1[j + 1]) {
                    double aux3 = vetor1[j];
                    vetor1[j] = vetor1[j + 1];
                    vetor1[j + 1] = aux3;
                }
            }
        }

        for (int i = 0; i < 5; i++) {
            vetor2[i] = vetor1[i];
            aux1 += " " + vetor2[i] + "\n";
        }
        JOptionPane.showMessageDialog(null, "Vetor em ordem crescente: \n" + aux1);

        for (int i = 5; i > 0; i--) {
            for (int j = 4; j > 0; j--) {
                if (vetor1[j] > vetor1[j - 1]) {
                    double aux3 = vetor1[j];
                    vetor1[j] = vetor1[j - 1];
                    vetor1[j - 1] = aux3;
                }
            }
        }

        for (int i = 0; i < 5; i++) {
            vetor3[i] = vetor1[i];
            aux2 += " " + vetor3[i] + "\n";
        }
        JOptionPane.showMessageDialog(null, "Vetor em ordem decrescente: \n" + aux2);

    }
}
