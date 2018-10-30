package atividade01;
import javax.swing.*;
public class Exercicio05 {
    public static void main(String[] args) {
        String numero = JOptionPane.showInputDialog(null, "Insira um número qualquer");
        double numero2 = Double.parseDouble(numero);
        int numero3 = JOptionPane.showConfirmDialog(null, "Esse é o seu numero: "+numero+"", "Confirmacao",JOptionPane.YES_NO_OPTION, JOptionPane.QUESTION_MESSAGE);
        String[] options = {"gatos", "sao", "muito", "fofos"};
        int numero4 = JOptionPane.showOptionDialog(null, "A verdade tem que ser dita","G A T O S",JOptionPane.DEFAULT_OPTION, JOptionPane.INFORMATION_MESSAGE, null, options, options[0]);
    }
}
