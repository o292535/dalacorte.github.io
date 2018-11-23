package l6e10;
import java.util.Scanner;
public class L6E10 {
    public static void main(String[] args) {
       Scanner entrada = new Scanner (System.in);
       
            int x = 0;
            x = entrada.nextInt();
            if (x>5)
            {
                while(x>=10)
                {
                    System.out.println("Digite novamente");
                    x = entrada.nextInt();
                }
                System.out.println(x);
            }
            else 
            {
                if(x<10)
                {
                    while (x<=5)
                    {
                        System.out.println("Digite novamente");
                        x = entrada.nextInt();
                    }
                    System.out.println(x);
                }
            }
    }
    
}
