package PacoteJava;

import javax.swing.*;

public class ExL03E03V2 {

    public static void main(String[] args) {
        int idade[] = new int[50];
        double altura[] = new double[50];
        char Sexo[] = new char[50];
        int contFeminino = 0;
        double altFeminino = 0;
        double idadeHomem[] = new double[50];
        double idadeMulher[] = new double[50];
        int i = 0;
        double aux2 = 0;
        for (i = 0; i < 50; i++) {
            String aux = JOptionPane.showInputDialog(null, "Digite a idade da " + (i + 1) + "º pessoa");
            idade[i] = Integer.parseInt(aux);
            aux = JOptionPane.showInputDialog(null, "Digite a altura da " + (i + 1) + "º pessoa");
            altura[i] = Integer.parseInt(aux);
            aux = JOptionPane.showInputDialog(null, "Digite o sexo " + (i + 1) + "º pessoa");
            Sexo[i] = aux.charAt(0);
            
            if (Sexo[i] == 'F' || Sexo[i] == 'f') {
                idadeMulher[i] = idade[i];
                contFeminino++;
                altFeminino = altFeminino + altura[i];
            } else if (Sexo[i] == 'M' || Sexo[i] == 'm') {
                idadeHomem[i] += idade[i];
            }
        }
        altFeminino = altFeminino / contFeminino;
        for (i = 0; i < 49; i++) {
            for (int j = 0; j < 49; j++) {
                if (altura[j] > altura[j + 1]) {
                    aux2 = altura[j];
                    altura[j] = altura[j + 1];
                    altura[j + 1] = aux2;
                
            }
        }
        System.out.println("Maior Altura: " + altura[i]);
        for (i = 0; i < 49; i++) {
            for (int j = 0; j < 49; j++) {
                if (altura[j] < altura[j + 1]) {
                    aux2 = altura[j + 1];
                    altura[j + 1] = altura[j];
                    altura[j] = aux2;
                }
            }
        }
        System.out.println("Menor Altura: " + altura[i]);
        for (i = 0; i < 49; i++) {
            for (int j = 0; j < 49; j++) {
                if (idadeHomem[j] > idadeHomem[j + 1]) {
                    aux2 = idadeHomem[j + 1];
                    idadeHomem[j + 1] = idadeHomem[j];
                    idadeHomem[j] = aux2;
                }
            }
        }
       for (i = 0; i < 49; i++) {
            for (int j = 0; j < 49; j++) {
                if (idadeMulher[j] < idadeMulher[j + 1]) {
                    aux2 = idadeMulher[j + 1];
                    idadeMulher[j + 1] = idadeMulher[j];
                    idadeMulher[j] = aux2;
                }
            }
        }
        System.out.println("Homem com maior idade: " + idadeHomem[i]);
        System.out.println("Mulher com menor idade: " + idadeMulher[i]);
        System.out.println("Media de Altura das mulheres: " + altFeminino);
    }
}
}