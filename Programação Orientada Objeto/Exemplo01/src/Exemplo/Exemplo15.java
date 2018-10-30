package Exemplo;
import javax.swing.JOptionPane;

public class Exemplo15 {
public static void main(String[] args) {
double LA, LB, LC; // LA = Lado A ; LB = Lado B ; LC = Lado C

LA = Double.parseDouble (JOptionPane.showInputDialog("Digite o valor do Lado A:"));
LB = Double.parseDouble (JOptionPane.showInputDialog("Digite o valor do Lado B:"));
LC = Double.parseDouble (JOptionPane.showInputDialog("Digite o valor do Lado C:"));

if (LA <= (LB + LC)){
if (LB <= (LA + LC)){
if (LC <= (LA + LB)){
JOptionPane.showMessageDialog(null, "Lado A = " + LA + "\nLado B = " + LB +
"\nLado C = " + LC + "\n\nTriângulo OK!");
} else { // (LC < LA + LB)
if (LC > (LA + LB)){
JOptionPane.showMessageDialog(null, "Lado A = " + LA + "\nLado B = " + LB +
"\nLado C = " + LC);
JOptionPane.showMessageDialog(null, "ATENÇÃO!\nNão é triângulo!\n\nLado C> Lado A + Lado B!\n" + LC + " > " + (LA + LB), "ERRO!", JOptionPane.ERROR_MESSAGE);
}
}
} else {
if (LB > (LA + LC)){
JOptionPane.showMessageDialog(null, "Lado A = " + LA + "\nLado B = " + LB +
"\nLado C = " + LC);
JOptionPane.showMessageDialog(null, "ATENÇÃO!\nNão é triângulo!\n\nLado B >Lado A + Lado C!\n" + LB + " > " + (LA + LC), "ERRO!", JOptionPane.ERROR_MESSAGE);
}
}
} else {
if (LA > (LB + LC)){
JOptionPane.showMessageDialog(null, "Lado A = " + LA + "\nLado B = " + LB + "\nLadoC = " + LC);
JOptionPane.showMessageDialog(null, "ATENÇÃO!\nNão é triângulo!\n\nLado A >Lado B + Lado C!\n" + LA + " > " + (LB + LC), "ERRO!", JOptionPane.ERROR_MESSAGE);
}
}
}
}