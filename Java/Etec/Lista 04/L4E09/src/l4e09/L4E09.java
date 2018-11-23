package l4e09;
import java.util.Scanner;
public class L4E09 {
    public static void main(String[] args) {
        Scanner entrada = new Scanner (System.in);
            
            int w = 0;
            int x = 0;
            int y = 0;
            int z = 0;
            w = entrada.nextInt();
            x = entrada.nextInt(); 
            y = entrada.nextInt();
            z = entrada.nextInt();
            x=x+w;
            y=y-z;
            x=x+y;
            
            if(x>10)
            {
                System.out.println("Resultado maior que 10");
            }
            else 
            {
                System.out.println("Resultado igual ou menor que 10");
            }
    }
    
}
