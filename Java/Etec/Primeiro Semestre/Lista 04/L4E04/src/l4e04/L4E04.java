package l4e04;
import java.util.Scanner;
public class L4E04 {
    public static void main(String[] args) {
        Scanner entrada = new Scanner (System.in);
        
            int x = 0;
            int y = 0;
            int z = 0;
            x = entrada.nextInt();
            y = entrada.nextInt();
            z = entrada.nextInt();
            
            if(x>y)
            {
                if (x>z)
                {
                    System.out.println(x);
                } 
                else 
                {
                    System.out.println(z);
                }
            }            
            else 
            {
                if(y>z)
                {
                    System.out.println(y);
                }
            else 
                {
                    System.out.println(z);
                }
            }
    }
    
}
