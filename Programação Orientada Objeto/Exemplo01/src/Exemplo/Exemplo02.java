package Exemplo;
import java.util.Scanner;
public class Exemplo02 {
public static void main(String[] args) {
Scanner sc = new Scanner(System.in);
double r, h, v;
double pi = 3.14159;

System.out.print("Digite o valor do raio: ");
r = sc.nextDouble(); // r = raio
System.out.print("Digite o valor da altura: ");
h = sc.nextDouble(); // h = altura

v = pi * (r * r) * h; // Parênteses desnecessário

System.out.println("Volume da lata = " + v);

}
}