package Exemplo;
import javax.swing.JOptionPane;
public class Exemplo12 {
public static void main(String[] args) {
String nome = null;
while (nome == null || nome.equals("")) {
nome = JOptionPane.showInputDialog("Qual o seu nome?");

if (nome == null || nome.equals("")) {
JOptionPane.showMessageDialog(null,"Você não respondeu a pergunta.");
}
}
JOptionPane.showMessageDialog(null, "Olá " + nome + "!");
}
}