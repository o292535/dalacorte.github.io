package l6e02;
import java.util.Scanner;
public class L6E02 {
    public static void main(String[] args) {
      Scanner entrada = new Scanner (System.in);
      
            int x = 0;
            x = entrada.nextInt();
            if(x<21)
            {
                while(x<21)
                {
                    System.out.println(x);
                    x=x+1;
                }
            }
            else
            {
                while(x>19)
                {
                    System.out.println(x);
                    x=x-1;
                }
            }
    }
    
}
