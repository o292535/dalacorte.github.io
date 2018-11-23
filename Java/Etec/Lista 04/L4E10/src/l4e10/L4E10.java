package l4e10;
import java.util.Scanner;
public class L4E10 {
    public static void main(String[] args) {
      Scanner entrada = new Scanner (System.in);
        
            int x = 0;
            int y = 0;
            x = entrada.nextInt();
            y = entrada.nextInt();
            
            if(x<y) 
            {
                x=x*10;
                y=y/2;
            }
            
            else
            {
                y=y*10;
                x=x/2;
            }
            
            x=x+y;
            x=x%2;
            
            if(x==0)
            {
                System.out.println("Resultado é par");
            }
            
            else
            {
                System.out.println("Resultado é impar");
            }
            
    }
    
}
