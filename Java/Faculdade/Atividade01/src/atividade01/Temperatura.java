package atividade01;
public class Temperatura {
    public double Kelvin (double temperatura, double celsius){
        temperatura = celsius + 273;
        System.out.println("Temperatura em Kelvin: " + temperatura);
        return (temperatura);
    }
    public double Fahrenheit (double temperatura, double celsius){
        temperatura = (celsius*9)/5 + 32;
        System.out.println("Temperatura em Fahrenheit: " + temperatura);
        return (temperatura);
    }
}
