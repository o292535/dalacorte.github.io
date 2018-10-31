package atividade01;
import javax.swing.*;
public class Exercicio01 extends Animal{
    public static void main (String [] args){
        double valor=0;
        Animal a = new Animal();
        String animal = " ";
        String gato = "gato";
        String cachorro = "cachorro";
        String gatoecachorro = "gato e cachorro";
        animal = JOptionPane.showInputDialog(null,"Escolha um animal ou os dois:");
        if(animal.equals(gato)){
        animal = JOptionPane.showInputDialog(null,"Informe a quantidade de gramas da racao:");
        valor = Double.parseDouble(animal);
            a.Gato(0, valor);           
    }
        if(animal.equals(cachorro)){
        animal = JOptionPane.showInputDialog(null,"Informe a quantidade de gramas de racao:");
        valor = Double.parseDouble(animal);
            a.Cachorro(0, valor);
        }
        if(animal.equals(gatoecachorro)){
        animal = JOptionPane.showInputDialog(null,"Informe a quantidade de gramas de racao do gato:");
        valor = Double.parseDouble(animal);
        animal = JOptionPane.showInputDialog(null,"Informe a quantidade de gramas de racao do cachorro:");
        double valor2 = Double.parseDouble(animal);
            a.Gato(0, valor);
            a.Cachorro(0, valor2);
        }
    }
}
