package Exemplo;
import javax.swing.JOptionPane;
public class Exemplo04 {
public static void main(String[] args) {
double salario, aumento;

salario = Double.parseDouble (JOptionPane.showInputDialog("Digite o salário atual:"));

aumento = salario + (salario * 0.25);
JOptionPane.showMessageDialog(null, "O novo valor do salário é " + aumento);
}
}