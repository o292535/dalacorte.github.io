package l1e06;
import java.util.Scanner;
public class L1E06 {
    public static void main(String[] args) {
        Scanner entrada = new Scanner (System.in);
        
            int w = 0;
            int x = 0;
            int y = 0;
            int z = 0;
            x = entrada.nextInt();
            w=x-3;
            y = entrada.nextInt();
            z=y+2;
            w=w+z;
            x=x+y;
            x=w+x;
            x=x-1;
            System.out.println(x);
    }
    
}
