package l6e06;
import java.util.Scanner;
public class L6E06 {
    public static void main(String[] args) {
        Scanner entrada = new Scanner (System.in);
        
            int x = 0;
            x = entrada.nextInt();
            
            while(x>10)
            {
                System.out.println("invalido, digite novamente");
                x = entrada.nextInt();
                
            }
    }
    
}
