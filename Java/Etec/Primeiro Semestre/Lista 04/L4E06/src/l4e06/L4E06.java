package l4e06;
import java.util.Scanner;
public class L4E06 {
    public static void main(String[] args) {
        Scanner entrada = new Scanner (System.in);
            
            int x = 0;
            int y = 0;
            x = entrada.nextInt();
            y = entrada.nextInt();
            
            if(x<y)
            {
                System.out.println(x);
                System.out.println(y);
            }
            else
            {
                System.out.println(y);
                System.out.println(x);
            }
    }
    
}
