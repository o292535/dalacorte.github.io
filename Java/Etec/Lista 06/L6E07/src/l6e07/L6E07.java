package l6e07;
import java.util.Scanner;
public class L6E07 {
    public static void main(String[] args) {
        Scanner entrada = new Scanner (System.in);
        
            int x = 0;
            int w = 0;
            int y = 0;
            while(w==0) 
            {
                x = entrada.nextInt();
                if(x<5)
                {
                    y = entrada.nextInt();
                    while(y<10)
                    {
                        y = entrada.nextInt();
                    }
                    w = 2;
                }
                
                else
                {
                    if(x>10)
                    {
                        y = entrada.nextInt();
                        while(y>5)
                        {
                            y = entrada.nextInt();
                        }
                        w = 2;
                    }
                }
            }
                    System.out.println(x);
                    System.out.println(y);
            
    }
    
}
