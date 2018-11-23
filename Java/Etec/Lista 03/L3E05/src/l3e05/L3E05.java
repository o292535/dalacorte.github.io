package l3e05;
import java.util.Scanner;
public class L3E05 {

    public static void main(String[] args) {
        Scanner entrada = new Scanner (System.in);
            
            int w = 0;
            int x = 0;
            int y = 0;
            int z = 0;
            x=entrada.nextInt();
            y=entrada.nextInt();
            w=x*10;
            z=y*10;
            if(x+y<20){
                System.out.println(w);
                System.out.println(z);
            }
        
        
        
        
    }
    
}
