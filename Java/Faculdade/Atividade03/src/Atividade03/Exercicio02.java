package atividade03;
import javax.swing.*;
public class Exercicio02 {
    public static void main(String[] args) {
        int a[][] = new int[4][4];
        int b[][] = new int[4][4];
        int i, j, k, dp, ds, dt, aux3;
        String aux1 = "", aux2 = "";
        
        for (i = 0; i < a.length; i++) {
            for (j = 0; j < a.length; j++) {
                String aux = JOptionPane.showInputDialog(null,"Informe o valor [" + (i+1) + "][" + (j+1) + "] da matriz a:");
                a[i][j] = Integer.parseInt(aux);
                aux = JOptionPane.showInputDialog(null,"Informe o valor [" + (i+1) + "][" + (j+1) + "] da matriz b:");
                b[i][j] = Integer.parseInt(aux);  
            }           
        }
        
        for (i = 0; i < a.length; i++) {
            aux3 = 0;
            for (j = 0; j < a.length; j++) {
                aux1 += a[i][j] + b[i][j] + " \t"; 
            }           
            aux1 += "\n";  
        }
        
        for (i = 0; i < a.length; i++) {
            for (j = 0; j < a.length; j++) {
                aux3 = 0;
                for (k = 0; k < a.length; k++) {
                    aux3 += a[i][k] * b[k][j];                 
                }
                aux2 += aux3 + " \t";
            }
            aux2 += "\n";
        }
        
        JOptionPane.showMessageDialog(null, "Soma das matrizes: \n" + aux1);
        JOptionPane.showMessageDialog(null, "Multiplicação das matrizes: \n" + aux2);
        dp = a[0][0] * a[1][1] * a[2][2] * a[3][3] + a[0][1] * a[1][2] * a[2][3] * a[3][0] +
                a[0][2] * a[3][1] * a[2][0] * a[3][1];
        ds = a[3][0] * a[2][1] * a[1][2] * a[0][3] + a[3][1] * a[2][2] * a[1][3] * a[0][0] +
                a[3][2] * a[2][3] * a[1][0] * a[0][1];
        dt = dp - ds;
        if (dt < 0){
            dt = dt * (-1);
        }
        JOptionPane.showMessageDialog(null, "Determinante da matriz A: " + dt);
        dp = b[0][0] * b[1][1] * b[2][2] * b[3][3] + b[0][1] * b[1][2] * b[2][3] * b[3][0] +
                b[0][2] * b[3][1] * b[2][0] * b[3][1];
        ds = b[3][0] * b[2][1] * b[1][2] * b[0][3] + b[3][1] * b[2][2] * b[1][3] * b[0][0] +
                b[3][2] * b[2][3] * b[1][0] * b[0][1];
        dt = dp - ds;
        if (dt < 0){
            dt = dt * (-1);
        }
        JOptionPane.showMessageDialog(null, "Determinante da matriz B: " + dt);
    }
}
