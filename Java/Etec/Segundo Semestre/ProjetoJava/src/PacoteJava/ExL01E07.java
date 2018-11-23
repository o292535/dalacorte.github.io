package PacoteJava;
import javax.swing.*;
public class ExL01E07 {
    public static void main(String[] args) {
         try{
         String aux = JOptionPane.showInputDialog(null, "Entre com o valor da hora da aula:");
         double horaaula = Double.parseDouble(aux);
         aux = JOptionPane.showInputDialog(null, "Quantidades de aulas dadas no mês:");
         double horames = Double.parseDouble(aux);
         aux = JOptionPane.showInputDialog(null, "Valor de desconto do INSS: \n(favor usar 0.valor de desconto):");
         double inss = Double.parseDouble(aux);
         horames = horames * horaaula;
         JOptionPane.showMessageDialog(null, "Valor total somente com as aulas, sem desconto: "+horames);
         inss = horames * inss;
         JOptionPane.showMessageDialog(null, "Desconto do INSS: "+inss);}
         catch(Exception ex){
            System.out.println("Erro:" + ex);
        }
    }
}
