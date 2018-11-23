package javaapplication5;
import java.util.Scanner;
public class JavaApplication5 {

    public static void main(String[] args) {
        Scanner entrada = new Scanner (System.in);
        
            int Notas[] = new int [4];
            int i = 0;
            
            for(i=0;i<4;i++)
            {
                 Notas[i] = entrada.nextInt();
            }
            for(i=0;i<4;i++)
            {
                System.out.println("Nota"+i+"="+Notas[i]);
            }
            
    }
    
}
