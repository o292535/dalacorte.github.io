package l4e01;
import java.util.Scanner;
public class L4E01 {
    public static void main(String[] args) {
        Scanner entrada = new Scanner (System.in);
            
            int x = 0;
            int y = 0;
            System.out.println("Digite números diferentes");
            x = entrada.nextInt();
            y = entrada.nextInt();
            
            if(x<y){
                System.out.println(x);
            }
            
            else{
                System.out.println(y);
            }
            
    }
    
}
