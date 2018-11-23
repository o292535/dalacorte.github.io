package l1e09;
import java.util.Scanner;
public class L1E09 {
    public static void main(String[] args) {
        Scanner entrada = new Scanner (System.in);
        
            int x = 0;
            int y = 0;
            x = entrada.nextInt();
            y = x-3;
            x = x-y;
            System.out.println(x);
    }
    
}
