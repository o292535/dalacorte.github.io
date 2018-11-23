package l6e09;
import java.util.Scanner;
public class L6E09 {
    public static void main(String[] args) {
       Scanner entrada = new Scanner (System.in);
       
            int x = 0;
            int y = 1;
            x = entrada.nextInt();
            
            while(x<20)
            {
                System.out.println("Digite novamente");
                x = entrada.nextInt();
            }
            while (x>=1)
            {
                System.out.println(x);
                x=x-y;
            }
    }
    
}
