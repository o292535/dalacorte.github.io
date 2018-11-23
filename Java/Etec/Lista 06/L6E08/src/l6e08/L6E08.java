package l6e08;
import java.util.Scanner;
public class L6E08 {
    public static void main(String[] args) {
        Scanner entrada = new Scanner (System.in);
        
            int x = 0;
            
            x = entrada.nextInt();
            
            if(x<5)
            {
                while(x<=20)
                {   
                    if(x%2==0)
                    {
                        System.out.println(x);
                        x=x+2;
                    }
      
                }
            }
    
            
      }
    
}
