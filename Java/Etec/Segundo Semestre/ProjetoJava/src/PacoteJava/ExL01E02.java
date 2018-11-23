package PacoteJava;
import javax.swing.*;
public class ExL01E02 {
    public static void main (String[]args ){  
        try{
  String al = JOptionPane.showInputDialog(null,"Valor do Salario bruto","Insira o Seu Salario bruto",1);
   double salario = Double.parseDouble(al);
    al = JOptionPane.showInputDialog(null,"Valor da Prestação","Insira o Valor da Prestação",1);
   double prestacao = Double.parseDouble(al);
    double salario30porc = (salario*30)/100 ;
    if(prestacao>salario30porc){
    JOptionPane.showMessageDialog(null,"Valor da Prestação Maior que 30% do seu salario="+salario30porc+"\n Não pode ser concedida="+prestacao+"\n Salario="+salario);
    }    
    else{
   JOptionPane.showMessageDialog(null,"Prestação Concedida de="+prestacao+"\n Valor Maximo="+salario30porc);    
            }
        }
    catch(Exception ex){
            System.out.println("Erro:" + ex);
        }
    }
 }