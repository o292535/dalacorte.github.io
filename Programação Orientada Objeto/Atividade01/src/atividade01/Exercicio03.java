package atividade01;
import javax.swing.*;
public class Exercicio03 extends Calculo{
    public static void main(String[] args) {
        Calculo c = new Calculo();
        String valor = JOptionPane.showInputDialog(null, "Informe o raio da circunferencia:");
        double raio = Double.parseDouble(valor);
        c.Volume(0, raio);
        c.Perimetro(0, raio);
        c.Area(0, raio);    
    }
}
