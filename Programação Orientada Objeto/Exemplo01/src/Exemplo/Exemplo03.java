package Exemplo;
import java.util.Scanner;

public class Exemplo03 {
public static void main(String[] args) {
Scanner sc = new Scanner(System.in);
double r, h, v;

System.out.print("Digite o valor do raio: ");
r = sc.nextDouble(); // r = raio
System.out.print("Digite o valor da altura: ");
h = sc.nextDouble(); // h = altura

v = 3.14159 * (r * r) * h; // Parênteses desnecessário ; 3.14159 foi substituido diretamente no lugar do PI na fórmula

System.out.printf("Volume da lata = %.2f\n", v);
}
}