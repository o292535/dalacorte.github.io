package PacoteJava;
import javax.swing.*;
public class ExL01E05 {
    public static void main(String[] args) {
        try{
        String valor = JOptionPane.showInputDialog(null, "Informe o Dia do seu Nacimento:");
        int dia = Integer.parseInt(valor);
        valor = JOptionPane.showInputDialog(null, "Informe o Mes do seu Nacimento:");
        int mes = Integer.parseInt(valor);
        valor = JOptionPane.showInputDialog(null, "Informe o Ano do seu Nacimento:");
        int ano = Integer.parseInt(valor);
        valor = JOptionPane.showInputDialog(null, "Informe o Dia Atual:");
        int datan = Integer.parseInt(valor);
        valor = JOptionPane.showInputDialog(null, "Informe o Mes Atual:");
        int mesn = Integer.parseInt(valor);
        valor = JOptionPane.showInputDialog(null, "Informe o Ano Atual:");
        int anon = Integer.parseInt(valor);
        int anor  = anon - ano;
        int mesr = mesn - mes;
        int diar = datan - dia;
        anor *= 365;
        mesr *= 30;
        int resposta=anor+mesr+diar;       
   JOptionPane.showMessageDialog(null,"Você esta vivo a:"+resposta);}
     catch(Exception ex){
            System.out.println("Erro:" + ex);
        }  
    }
}
