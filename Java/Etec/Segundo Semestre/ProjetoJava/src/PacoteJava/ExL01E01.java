package PacoteJava;
import javax.swing.*;
public class ExL01E01 {
    public static void main (String[]args ){
        double salario,aumento,porcentagem;
        try{
    String al = JOptionPane.showInputDialog(null,"Valor do Salario","Insira o Seu Salario",1);
    al = al.replace(',','.');
    salario = Double.parseDouble(al);
    al = JOptionPane.showInputDialog(null,"Taxa do Aumento(%)","Insira o Aumento",1);
    al = al.replace(',','.');
    aumento = Double.parseDouble(al);
    porcentagem = (salario*aumento)/100;
    salario +=porcentagem;
    JOptionPane.showMessageDialog(null,"Valor do Aumento="+porcentagem+" Novo Salario="+salario);
        }
        catch(NumberFormatException ex){
          JOptionPane.showMessageDialog(null,"Por Favor Insira um Numero");
         ExL01E01.main(args);
        }
    }
}
