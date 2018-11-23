package PacoteJava;

import javax.swing.*;

public class ExL03E02 {

    public static void main(String[] args) {
        try {
            int i, j, k;
            int contAprovado = 0;
            int contReprovado = 0;
            int contExame = 0;
            double mediareal = 0;
            double nota[] = new double[2];
            double media[] = new double[1];
            String aluno[] = new String[6];
            for (i = 0; i < aluno.length; i++) {
                String aux = JOptionPane.showInputDialog(null, "Digite o nome do aluno: ");
                aluno[i] = aux;
                for (k = 0; k < nota.length; k++) {
                    aux = JOptionPane.showInputDialog(null, "Digite a nota do aluno: ");
                    nota[k] = Double.parseDouble(aux);
                }
                for (j = 0; j < media.length; j++) {
                    String condicao = "";
                    media[j] = (nota[0] + nota[1]) / 2;
                    mediareal = mediareal + media[j];
                    if (media[j] < 3) {
                        condicao = "Reprovado";
                        contReprovado++;
                    } else if (media[j] >= 3 && media[j] <= 7) {
                        contExame++;
                        condicao = "Exame";
                    } else if (media[j] > 7) {
                        contAprovado++;
                        condicao = "Aprovado";
                    }
                    JOptionPane.showMessageDialog(null, "Nome do Aluno: " + aluno[0] + "\n1ºNota: " + nota[0] + "\n" + "2ºNota: " + nota[1] + "\n" + "Média: " + media[j] + " = " + condicao);
                }
            }
            mediareal = mediareal / 6;
            JOptionPane.showMessageDialog(null, "Alunos Aprovado: " + contAprovado + "\n Alunos De Exame: " + contExame + "\n Alunos Reprovados: " + contReprovado + "\n Media da Classe: " + mediareal);
        } catch (Exception ex) {
            System.out.println("Erro:" + ex);
        }
    }
}
