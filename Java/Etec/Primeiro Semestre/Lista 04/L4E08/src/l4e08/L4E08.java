package l4e08;
import java.util.Scanner;
public class L4E08 {
    public static void main(String[] args) {
        Scanner entrada = new Scanner (System.in);
            
            int x = 0;
            x = entrada.nextInt();
            
            if(x>10)
                {
                    x=x+5;
                    System.out.println(x);
                }
            
            else
            {
                if(x<=10)
                {
                    x=x+20;
                        
                    if(x>25)
                    {
                     System.out.println(x);
                    }
                }
            }
    }
    
}
