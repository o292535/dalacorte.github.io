package atividade04;

import javax.swing.*;

public class Exercicio01 {

    public static void main(String[] args) {
        int doceDoGato[][][] = new int[4][6][3];
        int total[] = new int[3];
        int a1, a2, a3, s1 = 0, s2 = 0, s3 = 0, bebida = 0;
        String aux = "", aux2 = "", maior = "", menorBebida = "", loja = "";

        for (a1 = 0; a1 < 3; a1++) {
            total[a1] = 0;
        }
        for (a1 = 0; a1 < 3; a1++) {
            for (a2 = 0; a2 < 6; a2++) {
                for (a3 = 0; a3 < 4; a3++) {
                    if (a3 == 0) {
                        aux = "doces";
                    } else if (a3 == 1) {
                        aux = "salgados";
                    } else if (a3 == 2) {
                        aux = "bebidas";
                    } else if (a3 == 3) {
                        aux = "sorvetes";
                    }
                    doceDoGato[a3][a2][a1] = Integer.parseInt(JOptionPane.showInputDialog(null, "Loja " + (a1 + 1) + ":\nInforme a quantidade de " + aux + " vendidos no " + (a2 + 1) + "º mês: "));
                    total[a1] += doceDoGato[a3][a2][a1];
                }
            }
        }

        for (a1 = 0; a1 < 3; a1++) {
            for (a2 = 0; a2 < 6; a2++) {
                if (a2 == 0) {
                    aux2 += "\nLoja " + (a1 + 1) + "\n";
                }
                if (a2 != 0) {
                    aux2 += "\nMês " + (a2 + 1) + ": ";
                }
                for (a3 = 0; a3 < 4; a3++) {
                    if (a2 == 0 && a3 == 0) {
                        aux2 += "\nMês " + (a2 + 1) + ": " + doceDoGato[a3][a2][a1] + " \t";
                    } else {
                        aux2 += doceDoGato[a3][a2][a1] + " \t";
                    }
                }
            }
            aux2 += "\n";
        }

        if (total[0] > total[1] && total[0] > total[2]) {
            maior = "A loja que obteve mais vendas foi a loja 1, com " + total[0] + " vendas.";
        }
        if (total[1] > total[0] && total[1] > total[2]) {
            maior = "A loja que obteve mais vendas foi a loja 2, com " + total[1] + " vendas.";
        }
        if (total[2] > total[1] && total[2] > total[0]) {
            maior = "A loja que obteve mais vendas foi a loja 3, com " + total[2] + " vendas.";
        }

        for (a2 = 0; a2 < 6; a2++) {
            s1 += doceDoGato[3][a2][0];
            s2 += doceDoGato[3][a2][1];
            s3 += doceDoGato[3][a2][2];
        }

        if (s1 > s2 && s1 > s3) {
            maior += "\nA loja que obteve mais vendas de sorvetes foi a loja 1, com " + s1 + " vendas.";
        }
        if (s2 > s1 && s2 > s3) {
            maior += "\nA loja que obteve mais vendas de sorvetes foi a loja 2, com " + s2 + " vendas.";
        }
        if (s3 > s1 && s3 > s2) {
            maior += "\nA loja que obteve mais vendas de sorvetes foi a loja 3, com " + s3 + " vendas.";
        }

        for (a1 = 0; a1 < 6; a1++) {
            for (a2 = 0; a2 < 3; a2++) {
                if (a2 == 0) {
                    bebida = doceDoGato[2][a1][a2];
                    loja = "da loja " + (a2 + 1);
                } else if (doceDoGato[2][a1][a2] < bebida) {
                    bebida = doceDoGato[2][a1][a2];
                    loja = "da loja " + (a2 + 1);
                }
            }
            menorBebida += "Mês " + (a1 + 1) + ": " + bebida + " vendas - " + loja + "\n";
        }

        JOptionPane.showMessageDialog(null, aux2);
        JOptionPane.showMessageDialog(null, "\nQuantidade total de vendas: " + (total[0] + total[1] + total[2])
                + "\n" + maior + "\n" + menorBebida);

    }

}
