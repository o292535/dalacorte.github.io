package Exemplo;
import javax.swing.JOptionPane;
public class Exemplo09 {
public static void main(String[] args) {
for(int cont = 10; cont >= 1; cont--){ // Esse cont vai de 10 até 1 (inclusive); cont-- é omesmo que escrever cont = cont - 1
JOptionPane.showMessageDialog(null, cont);
}
}
}