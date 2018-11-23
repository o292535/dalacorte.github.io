package l6e03;
import java.util.Scanner;
public class L6E03 {
    public static void main(String[] args) {
     Scanner entrada = new Scanner (System.in);
     
            int x = 0;
            int y = 0;
            x = entrada.nextInt();
            y = entrada.nextInt();
            
            if(x<y)
            {
                while(x<y)
                {
                    System.out.println(x);
                    x=x+1;
                    
                }
            }
            
            else
            {
                while(x>y)
                {
                    System.out.println(y);
                    y=y+1;
                    
                }
            }
        
    }
    
}
