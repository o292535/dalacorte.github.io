package Exemplo;
import javax.swing.JOptionPane;

public class Exemplo14 {
public static void main(String[] args) {
double num, soma = 0, media = 0;
int cont = 0;

do {
num = Double.parseDouble (JOptionPane.showInputDialog("Digite um número:"));
if(num >= 0){ // se o número digitado for MAIOR que zero, executa a conta
soma = num + soma; // soma o valor digitado AGORA com o digitado ANTES
cont++; // conta quantas vezes o usuário digitou um número

}
} while (num >= 0); // se o número digitado for MAIOR que zero, faz o LOOP novamente

media = soma / cont; // vai calcular a média entre a soma e a quantidade de nos digitadospelo usuário
JOptionPane.showMessageDialog(null, "A soma é " + soma + "\nA quantidade de númerosdigitados foi " + cont + "\nA média é " + media);
}
}