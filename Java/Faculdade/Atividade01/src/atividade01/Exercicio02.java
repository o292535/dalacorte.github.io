package atividade01;
import javax.swing.*;
public class Exercicio02 extends Temperatura{
    public static void main(String[] args) {
        String temperatura = " ";
        double celsius;
        Temperatura t = new Temperatura();
        temperatura = JOptionPane.showInputDialog(null,"Informe a temperatura em celsius");
        celsius = Double.parseDouble(temperatura);
        t.Kelvin(0, celsius);
        t.Fahrenheit(0, celsius);
    }
}
