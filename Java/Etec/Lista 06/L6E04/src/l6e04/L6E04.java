package l6e04;
import java.util.Scanner;
public class L6E04 {
    public static void main(String[] args) {
       Scanner entrada = new Scanner (System.in);
       
            int x = 0;
            int y = 1;
            int z = 0;
            x = entrada.nextInt();
            
            while(y<=10)
            {
                
                z=y*x;
                System.out.println(z);
                y=y+1;
                z=y*z;
                
                
            }
            
            
    }
    
}
