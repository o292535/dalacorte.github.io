
package l3e07;
import java.util.Scanner;
public class L3E07 {
    public static void main(String[] args) {
        Scanner entrada = new Scanner (System.in);
        
            int x = 0;
            int y = 0;
            int z = 0;
            x = entrada.nextInt();
            y = entrada.nextInt();
            z = entrada.nextInt();
            x=x+y+z;
            
            if(x>20){
                System.out.println(x);
            }
    }
    
}
