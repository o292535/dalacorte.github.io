package Exemplo;
import java.util.Scanner;
public class Exemplo01 {
public static void main(String[] args) {
Scanner sc = new Scanner(System.in);
String tipo;

System.out.print("TIPOS SANGUÍNEOS:\n\nA+ (para sangue A+)\nA- (para sangue A-)\nAB+ (para sangue AB+)\nAB- (para sangue AB-)\nB+ (para sangue B+)\nB- (para sangue B-)\nO+ (para sangue O+)\nO- (para sangue O-)\n\nDigite uma das opções acima: ");
tipo = sc.next();

switch(tipo){
case "A+": case "a+":
System.out.println("\nSeu sangue é tipo A+!\nVocê pode doar para: AB+ e A+!\nVocêpode receber doação de: A+, A-, O+ e O-!");
break;

case "A-": case "a-":
System.out.println("\nSeu sangue é tipo A-!\nVocê pode doar para: A+, A-, Ab+ e AB-!\nVocê pode receber doação de: A- e O-!");

break;

case "AB+": case "ab+":
System.out.println("\nSeu sangue é tipo AB+!\nVocê pode doar para: AB+!\nVocêpode receber doação de: A+, B+, O+, AB+, A-, B-, O- e AB- (todos)!");
break;

case "AB-": case "ab-":
System.out.println("\nSeu sangue é tipo AB-!\nVocê pode doar para: AB+ e AB-!\nVocê pode receber doação de: A-, B-, O- e AB-!");
break;

case "B+": case "b+":
System.out.println("\nSeu sangue é tipo B+!\nVocê pode doar para: B+ e AB+!\nVocêpode receber doação de: B+,B-, O+ e O-!");
break;

case "B-": case "b-":
System.out.println("\nSeu sangue é tipo B-!\nVocê pode doar para: B+, B-, AB+ e AB-!\nVocê pode receber doação de: B- e O-!");
break;

case "O+": case "o+":
System.out.println("\nSeu sangue é tipo O+!\nVocê pode doar para: A+, B+, O+ eAB+!\nVocê pode receber doação de: O+ e O-!");
break;

case "O-": case "o-":
System.out.println("\nSeu sangue é tipo O-!\nVocê pode doar para: A+, B+, O+, AB+,A-, B-, O- e AB- (todos)!\nVocê pode receber doação de: O-!");
break;

default:

System.out.println("\nVocê digitou uma opção inválida. Tipo sanguíneo inexistente!");
}
}
}