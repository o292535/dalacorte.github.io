package l1e05;
import java.util.Scanner;
public class L1E05 {
    public static void main(String[] args) {
        Scanner entrada = new Scanner (System.in);
        
            int x = 0;
            int y = 0;
            x = entrada.nextInt();
            y = entrada.nextInt();        
            x=x-y;       
            x=x+10;  
            System.out.println (x);
    }
    
}
