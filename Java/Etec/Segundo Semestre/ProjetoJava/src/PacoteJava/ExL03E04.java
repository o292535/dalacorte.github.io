package PacoteJava;

import javax.swing.*;

public class ExL03E04 {

    public static void main(String[] args) {
        try{
        int mesa[] = new int[41];
        for (int i = 0; i < mesa.length; i++) {
            mesa[i] = 6;
        }//Passando Valores
        for (int i = 0; i < 1;) {
            String aux = JOptionPane.showInputDialog(null, "Informe o numero da mesa desejada: \nDigite 0 para sair do programa");
            int numeroMesa = Integer.parseInt(aux);
            if (numeroMesa == 0) {//Sair
                System.exit(i);
            }
            if (mesa[numeroMesa] < 6) {//Numero diferente de 6 Mesa Inacessivel
                System.out.println("Mesa Inacessivel");
            } else { //Mesa Acessivel 
                aux = JOptionPane.showInputDialog(null, "Informe o numero de cadeiras desejadas: \nDigite 0 para sair do programa");
                int numeroCadeiras = Integer.parseInt(aux);
                if (numeroCadeiras == 0) { //Sair
                    System.exit(i);
                } else { //Calculo se todas forem verdadeiras
                    //Ideia Fazer um for que faça a conta com uma variavel e desconte 6 na mesa e passe para proxima até a variavel ficar negativa
                    if (numeroCadeiras <= 6) {
                        mesa[numeroMesa] = mesa[numeroMesa] - numeroCadeiras;
                    } else {
                            for(;numeroCadeiras > 6;){
                        numeroCadeiras = numeroCadeiras - 6;
                        mesa[numeroMesa] = 0;
                        numeroMesa++;
                            }
                        //QUANDO FOR IGUAL A 6 OU MENOR
                        mesa[numeroMesa] = mesa[numeroMesa] - numeroCadeiras;
                        System.out.println(mesa[numeroMesa]);
                    }
                }
            }
        }//Else Calculo Fechar
    }
  catch(NumberFormatException ex){
            System.out.println("Erro:" + ex);
        }
        //Else Numero Cadeiras Fechar
}}//For Programa Fechar

