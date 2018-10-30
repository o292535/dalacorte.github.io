package Exemplo;
import javax.swing.JOptionPane;

public class Exemplo07 {
public static void main(String[] args) {
int num, fat = 1, cont = 1;

do {
num = Integer.parseInt(JOptionPane.showInputDialog("Digite um no inteiro:"));
for (int i = 1 ; i <= num ; i++){
fat = fat * i;
}
JOptionPane.showMessageDialog(null, num + "!" + " = " + fat);
cont++;
} while (cont < 2);
}
}
