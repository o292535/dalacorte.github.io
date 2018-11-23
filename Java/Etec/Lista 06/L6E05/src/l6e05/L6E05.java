package l6e05;
import java.util.Scanner;
public class L6E05 {
    public static void main(String[] args) {
        Scanner entrada = new Scanner (System.in);
        
            int x = 0;
            int y = 0;
            int z = 0;
            x = entrada.nextInt();
            y = entrada.nextInt();
            z = entrada.nextInt();
            
            if(x<y)
            {
                if(x<z)
                {
                    if(y<z)
                    {
                        while(y<z)
                        {
                            System.out.println(y);
                            y=y+1;
                        }
                    }
                    else
                    {
                        while(z<y)
                        {
                        System.out.println(z);
                        z=z+1;
                        }
                    }
                }
                else
                {
                    while(x<y)
                    {
                        System.out.println(x);
                        x=x+1;
                    }
                }
            }
            else
            {
                if(y<z)
                {
                    if(x<z)
                    {
                        while(x<z)
                        {
                            System.out.println(x);
                            x=x+1;  
                        }
                    }
                    else
                    {
                        while(z<x)
                        {
                            System.out.println(z);
                            z=z+1;
                        }
                    }
                }
                else
                {
                    while(y<x)
                    {
                        System.out.println(y);
                        y=y+1;
                    }
                }
            }
    }
    
}
