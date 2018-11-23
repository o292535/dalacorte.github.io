package javaapplication8;
import java.util.Scanner;
public class JavaApplication8 {
    public static void main(String[] args) {
             Scanner entrada = new Scanner (System.in);
            
            char palavra [] = new char [20];
            char alfabeto[] = {'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'};
            char crip [] = new char [20];
            for (int x=0;x<20;x++)
                
            { 
                palavra[x] =entrada.next().charAt(0);
                
                if(palavra[x]=='0'){x=20;}     
                else{
                    for (int s = 0; s < 26; s++) {
                         if (palavra[x]==alfabeto[s]){
                             for (int a = 0; a < 10; a++) {
                                 crip[a]=alfabeto[s+3]; 
                                 
                             }
                             
                        
                    }
                    
                    
                    
                    }
                    
                for (int i = 0; i < 1; i++) {
                                 System.out.print(crip[i]);
                             }
                }
            
            
            }  
            
}
}
