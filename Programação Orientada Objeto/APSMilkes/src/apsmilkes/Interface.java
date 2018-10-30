package apsmilkes;

import javax.swing.*;

public class Interface {

    public static void main(String[] args) {
        String aux = JOptionPane.showInputDialog(null, "Digite um valor qualquer: ");
        double valor1 = Double.parseDouble(aux);
        aux = JOptionPane.showInputDialog(null, "Digite outro valor qualquer: ");
        double valor2 = Double.parseDouble(aux);
        double valor3 = valor1 + valor2;
        JOptionPane.showMessageDialog(null, "Valores somados: " + valor3);
        double valor4 = valor1 - valor2;
        JOptionPane.showMessageDialog(null, "Valores subtraidos: " + valor4);
        double valor5 = valor1 / valor2;
        JOptionPane.showMessageDialog(null, "Valores divididos: " + valor5);
        double valor6 = valor1 - valor2;
        JOptionPane.showMessageDialog(null, "Valores multiplicados: " + valor6);
    }
}
