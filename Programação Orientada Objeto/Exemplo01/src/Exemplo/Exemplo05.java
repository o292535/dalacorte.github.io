package Exemplo;
import javax.swing.JOptionPane;

public class Exemplo05 {
public static void main(String[] args) {
String opcao;
double n1, n2, resultado;

n1 = Double.parseDouble(JOptionPane.showInputDialog("Digite o 1o número:"));
n2 = Double.parseDouble(JOptionPane.showInputDialog("Digite o 2o número:"));

opcao = JOptionPane.showInputDialog("A - Adição\nS - Subtração\nM - Multiplicação\nD -Divisão\n\nDigite uma das opções:");

switch(opcao){
case "A": case "a":
resultado = n1 + n2;
JOptionPane.showMessageDialog(null, "ADIÇÃO!\nResultado = " + resultado);
break;

case "S": case "s":
resultado = n1 - n2;
JOptionPane.showMessageDialog(null, "SUBTRAÇÃO!\nResultado = " + resultado);
break;

case "M": case "m":
resultado = n1 * n2;
JOptionPane.showMessageDialog(null, "MULTIPLICAÇÃO!\nResultado = " +
resultado);
break;

case "D": case "d":
if (n2 == 0){
JOptionPane.showMessageDialog(null, "ERRO: Divisão por zero não existe!",
"ERRO!", JOptionPane.ERROR_MESSAGE);
} else {
resultado = n1 / n2;
JOptionPane.showMessageDialog(null, "DIVISÃO!\nResultado = " + resultado);
}
break;

default:
JOptionPane.showMessageDialog(null, "ATENÇÃO: Você digitou uma opção inválida.",
"ERRO!", JOptionPane.ERROR_MESSAGE);
}
}
}