package l1e08;
import java.util.Scanner;
public class L1E08 {
    public static void main(String[] args) {
        Scanner entrada = new Scanner (System.in);
        
            int x = 0;
            int y = 0;
            int w = 0;
            x = entrada.nextInt();
            x = x+10;
            y = entrada.nextInt();
            y = y-5;
            w = entrada.nextInt();
            w = w*2;
            System.out.println(x);
            System.out.println(y);
            System.out.println(w);
    }
    
}
