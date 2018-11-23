package exercicio02;
//import java.util.Scanner;
import javax.swing.*;
public class  NumeroMaior {
    public void doisNumeros(double num1,double num2){
    try{
    //Scanner novo = new Scanner(System.in);
    //int num1,num2;
    //System.out.println("Insira o primeiro Numero");
    //num1 = novo.nextInt();
    //System.out.println("Insira o Segundo Numero");
    //num2 = novo.nextInt();
    String aux = JOptionPane.showInputDialog(null,"Digite o primeiro numero: ");
    num1 = Double.parseDouble(aux);
    aux = JOptionPane.showInputDialog(null,"Digite o segundo numero: ");
    num2 = Double.parseDouble(aux);
    if(num1 > num2){
    //System.out.println(num1);
    JOptionPane.showMessageDialog(null,"O maior numero é: "+num1);
    }
    else if(num1 == num2){
    JOptionPane.showMessageDialog(null,"Os numero são identicos: "+num1+" "+num2);
    }
    else{   
    //System.out.println(num2);
    JOptionPane.showMessageDialog(null,"O maior Numero é: "+num2);
    } 
    }
    catch(Exception ex){     
    JOptionPane.showMessageDialog(null,"eR");
    }
}
}