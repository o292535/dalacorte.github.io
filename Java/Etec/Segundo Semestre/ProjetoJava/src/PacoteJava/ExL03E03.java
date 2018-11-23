package PacoteJava;

import javax.swing.*;

public class ExL03E03 {

    public static void main(String[] args) {
        double pessoa[][] = new double[2][2];
        char Sexo[] = new char[2];
        int contFeminino = 0;
        double altFeminino = 0;
        double idadeHomem[] = new double[2];
        double idadeMulher[] = new double[2];
        int i = 0;
        double aux2 = 0;
        for (i = 0; i < 2; i++) {
            String aux = JOptionPane.showInputDialog(null, "Digite a idade da " + (i + 1) + "º pessoa");
            pessoa[i][0] = Integer.parseInt(aux);
            aux = JOptionPane.showInputDialog(null, "Digite a altura da " + (i + 1) + "º pessoa");
            pessoa[0][i] = Integer.parseInt(aux);
            aux = JOptionPane.showInputDialog(null, "Digite o sexo " + (i + 1) + "º pessoa");
            Sexo[i] = aux.charAt(0);
            if (Sexo[i] == 'F' || Sexo[i] == 'f') {
                idadeMulher[i] = pessoa[i][0];
                contFeminino++;
                altFeminino = altFeminino + pessoa[0][i];
            } else if (Sexo[i] == 'M' || Sexo[i] == 'm') {
                idadeHomem[i] += pessoa[i][0];
            }
        }
        for (i = 0; i < 1; i++) {
            for (int j = 0; j < 1; j++) {
                if (pessoa[0][j] > pessoa[0][j + 1]) {
                    aux2 = pessoa[0][j];
                    pessoa[0][j] = pessoa[0][j + 1];
                    pessoa[0][j + 1] = aux2;
                }
            }
        }
        System.out.println("Maior Altura: " + pessoa[0][i]);
        for (i = 0; i < 1; i++) {
            for (int j = 0; j < 1; j++) {
                if (pessoa[0][j] < pessoa[0][j + 1]) {
                    aux2 = pessoa[0][j + 1];
                    pessoa[0][j + 1] = pessoa[0][j];
                    pessoa[0][j] = aux2;
                }
            }
        }
        System.out.println("Menor Altura: " + pessoa[0][i]);
        for (i = 0; i < 1; i++) {
            for (int j = 0; j < 1; j++) {
                if (idadeHomem[j] > idadeHomem[j + 1]) {
                    aux2 = idadeHomem[j + 1];
                    idadeHomem[j + 1] = idadeHomem[j];
                    idadeHomem[j] = aux2;
                }
            }
        }
        System.out.println("Homem com maior idade: " + idadeHomem[i]);
      
        System.out.println("Mulher com menor idade: " + idadeMulher[i]);
        altFeminino = altFeminino / contFeminino;
        System.out.println("Media de Altura das mulheres: " + altFeminino);
    }
}
