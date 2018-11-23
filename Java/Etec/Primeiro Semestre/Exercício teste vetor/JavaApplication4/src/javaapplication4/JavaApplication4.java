package javaapplication4;
import java.util.Scanner;
public class JavaApplication4 {

    public static void main(String[] args) {
        Scanner entrada = new Scanner (System.in);
            
            int notas[] = new int [4];
            int nota = 0;
            int media = 0;
            
            for(int i = 0; i<4;i++)
            {
                nota = entrada.nextInt();
                notas[i]=nota;
                media=media+notas[i];
            }
            media=media/4;
            System.out.println("Nota 1 = "+notas[0]);
            System.out.println("Nota 2 = "+notas[1]);
            System.out.println("Nota 3 = "+notas[2]);
            System.out.println("Nota 4 = "+notas[3]);
            System.out.println("Média = "+media);
            
     }         
 
}


























//Notas[0] = entrada.nextInt();
            //Notas[1] = entrada.nextInt();
            //Notas[2] = entrada.nextInt();
            //Notas[3] = entrada.nextInt();
            //System.out.println("Nota 01 =" + Notas[0]);
            //System.out.println("Nota 02 =" + Notas[1]);
            //System.out.println("Nota 03 =" + Notas[2]);
            //System.out.println("Nota 04 =" + Notas[3]);
