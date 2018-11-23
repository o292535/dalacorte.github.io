package l4e05;
import java.util.Scanner;
public class L4E05 {
    public static void main(String[] args) {
        Scanner entrada = new Scanner (System.in);
        
            int x = 0;
            int y = 0;
            int z = 0;
            x = entrada.nextInt();
            y = entrada.nextInt();
            z = entrada.nextInt();           
            if(x<y)
            {
                if(x<z)
                {
                    x=x+5;
                    System.out.println(x);
                }
                else 
                {
                    z=z+5;
                    System.out.println(z);
                }
            }
            else 
            { 
                if(y<z)
                {
                    y=y+5;
                    System.out.println(y);
                }
                else
                {
                    z=z+5;
                    System.out.println(z);
                }
            }
    }
    
}
