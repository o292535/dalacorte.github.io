package atividade04;
import java.util.Scanner;
public class Exercicio02 {
    public static void main(String[] args) {
        Scanner entrada = new Scanner (System.in);
        int i = 0;
        int tamanhoQuarteirao = -6;
        System.out.println("Digite a quantidade em metros do estacionamento: ");
        tamanhoQuarteirao = entrada.nextInt();
        tamanhoQuarteirao -= 6;
        int tamanhoVetor[] = new int [tamanhoQuarteirao];
        for(i=0;i<tamanhoVetor.length;i++){
            if(tamanhoQuarteirao != 0 || tamanhoQuarteirao <= -1){
                tamanhoQuarteirao += 1;
                tamanhoQuarteirao -= 5;
                System.out.println("Tamanho"+(tamanhoQuarteirao));
                System.out.println("Vagas disponiveis: "+(i+1));
            }
        }
    }
}
