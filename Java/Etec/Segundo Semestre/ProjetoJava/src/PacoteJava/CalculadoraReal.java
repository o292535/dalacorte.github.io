package PacoteJava;
import javax.swing.*;

public class CalculadoraReal {

    public static void main (String[]args ){  
    double num1,num2,entradan=0;
    String vl = " ";
    vl = JOptionPane.showInputDialog(null,"Insira o 1º número");
    num1 = Double.parseDouble(vl);
    vl = JOptionPane.showInputDialog(null,"Insira o 2º número");
    num2 = Double.parseDouble(vl);
    int numd1 = 0; 
    do{
    vl = JOptionPane.showInputDialog(null,"Insira um numero de 1-4/1-Soma/2-Subtração/3-Vezes/4-Divisão");
    numd1 = Integer.parseInt(vl);
    }
    while(numd1 > 4 || numd1 <= 0);
    if(numd1 == 1){
        
    vl = "Soma";
   entradan = Operacoes.Somamais(num1, num2);
    }
    if(numd1 == 2){
        
    entradan = Operacoes.Somamenos(num1, num2);
    vl = "Menos";
    }
    if(numd1 == 3){
  
    entradan = Operacoes.SomaVezes(num1, num2);
    vl = "Vezes";
  
    }
    if(numd1 ==4){
    entradan = Operacoes.SomaDivi(num1,num2);
    vl = "Dividir";
    }
    Resposta.ResultadoMais(vl,entradan);
    }
} 


