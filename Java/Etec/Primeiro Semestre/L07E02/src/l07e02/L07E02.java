package l07e02;
import java.util.Scanner;
public class L07E02 {
    public static void main(String[] args) {
        Scanner entrada = new Scanner (System.in);
        
            int num[] = new int [5];
            int x = 0;
            int troca = 1;
            int n = 0;
            int i = 0;
            
            
            while(troca == 1)
            {
                troca=0;
                while(i<4)
                {
                    if(num[i]>num[i+1])
                    {
                        troca = 1;
                        x = num[i];
                        num[i]=num[i+1];
                        num[i+1]=x;
                    }
                    else
                    {
                        i=i+1;
                    }
                }
            }
            System.out.println();
            
            
    }
    
}
