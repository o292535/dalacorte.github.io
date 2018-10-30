package Exemplo;
import javax.swing.JOptionPane;
public class Exemplo13 {
public static void main(String[] args) {
int F1, F2, total;

F1 = Integer.parseInt(JOptionPane.showInputDialog("Digite os pontos da 1a fase:"));
F2 = Integer.parseInt(JOptionPane.showInputDialog("Digite os pontos da 2a fase:"));

total = F1 + F2;

if (total >= 10){
JOptionPane.showMessageDialog(null, "Total de pontos acumulados: " + total + "\nOK!Poderá transpor o portal!");

} else {
JOptionPane.showMessageDialog(null, "Total de pontos acumulados: " + total + "\nNãopoderá transpor o portal!");
}
}
}