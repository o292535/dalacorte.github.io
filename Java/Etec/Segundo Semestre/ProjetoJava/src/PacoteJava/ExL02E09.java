package PacoteJava;
import javax.swing.*;
public class ExL02E09 {
    public static void main(String[] args) {
        try{
        String aux = JOptionPane.showInputDialog(null, "Informe primeiro lado do triangulo:");
        double lado1 = Double.parseDouble(aux);
        aux = JOptionPane.showInputDialog(null, "Informe segundo lado do triangulo:");
        double lado2 = Double.parseDouble(aux);
        aux = JOptionPane.showInputDialog(null, "Informe terceiro lado do triangulo:");
        double lado3 = Double.parseDouble(aux);
        if(lado1==0 || lado2==0 || lado3 == 0 || lado1 > lado2 + lado3 || lado2 > lado1 + lado3 ||lado3 > lado1+lado2){
               JOptionPane.showMessageDialog(null, "Isto não é um triangulo");        
        }
        if(lado1 == lado2 && lado2 == lado3){
            JOptionPane.showMessageDialog(null, "Triangulo Equilátero");        
       
        }
        else if(lado1 == lado2 && lado2 != lado3 || lado3 == lado1 && lado1 != lado2 || lado2 == lado3 && lado3 != lado1 ){
            JOptionPane.showMessageDialog(null, "Triangulo Isósceles");        
        }
        else if(lado1 != lado2 && lado2 != lado3 || lado2 != lado1 && lado1 != lado3 || lado3 != lado2 && lado2 != lado1 )
            
            JOptionPane.showMessageDialog(null, "Triangulo Escaleno");} 
        catch(Exception ex){
        System.out.println("Erro:" + ex);
        }
        
    }
}
