package atividade01;
public class Calculo {
    public double Volume (double resposta, double raio){
        resposta = (4/3) * 3.1416 * Math.pow(raio, 3);
        System.out.println(resposta);
        return(resposta);
    }    
    public double Perimetro (double resposta, double raio){
        resposta = 2 * 3.1416 * raio;
        System.out.println(resposta);
        return(resposta);
    }
    public double Area (double resposta, double raio){
        resposta = 3.1416 * Math.pow(raio, 2);
        System.out.println(resposta);
        return(resposta);
    }
}
