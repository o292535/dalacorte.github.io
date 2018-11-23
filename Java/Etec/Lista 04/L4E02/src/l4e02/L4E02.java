package l4e02;
import java.util.Scanner;
public class L4E02 {
    public static void main(String[] args) {
        Scanner entrada = new Scanner (System.in);
        
            int x = 0;
            int y = 0;
            System.out.println("Digite números diferentes");
            x = entrada.nextInt();
            y = entrada.nextInt();
            
            if(x<y){x=x+5;}
            
            else {y=y+5;}
            
            if(x>y){
                System.out.println(x);
            }
            
            else {
                System.out.println(y);
            }
    }
    
}
