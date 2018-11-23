package l4e03;
import java.util.Scanner;
public class L4E03 {
    public static void main(String[] args) {
      Scanner entrada = new Scanner (System.in);
        
        int x = 0;
        x = entrada.nextInt();
        
        if(x>10){System.out.println("Número maior que dez");}
        
        else {System.out.println("Número igual ou menor que dez");}
    }
    
}
