package l1e10;
import java.util.Scanner;
public class L1E10 {
    public static void main(String[] args) {
        Scanner entrada = new Scanner (System.in);
        
            int x = 0;
            int z = 0;
            int A = 0;
            int B = 0;
            x = entrada.nextInt();
            z = x/2;
            A = z;
            B = z;
            A = A+3;
            B = B+5;
            System.out.println(A);
            System.out.println(B);
    }
    
}
