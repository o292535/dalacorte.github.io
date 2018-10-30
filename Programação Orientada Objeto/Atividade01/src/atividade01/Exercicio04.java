package atividade01;
import javax.swing.*;

public class Exercicio04 extends Doces{
    
    public static void main(String[]Args){
        
        Doces d = new Doces();
        int quant = 0;
        String doce;
        JCheckBox brigadeiro = new JCheckBox("Brigadeiro");
        JCheckBox pacoquinha = new JCheckBox("Paçoquinha");
        JCheckBox paoDeMel = new JCheckBox("Pão-de-mel");
        JCheckBox mariaMole = new JCheckBox("Maria-mole");

String message = "Qual (is) doce (s) você deseja comprar?";
Object[] doces = {message, brigadeiro, pacoquinha, paoDeMel, mariaMole};
int n = JOptionPane.showConfirmDialog(null, doces, "Doceria que vende doces", JOptionPane.OK_CANCEL_OPTION);
//boolean dontShow = checkbox.isSelected();
if (brigadeiro.isSelected()){
    doce = JOptionPane.showInputDialog(null,"Informe a quantidade de brigadeiros que deseja comprar:");
    quant = Integer.parseInt(doce);
    d.Brigadeiro(0,quant);
}

if (pacoquinha.isSelected()){
    doce = JOptionPane.showInputDialog(null,"Informe a quantidade de paçoquinhas que deseja comprar:");
    quant = Integer.parseInt(doce);
    d.Pacoquinha(0,quant);
}

if (paoDeMel.isSelected()){
    doce = JOptionPane.showInputDialog(null,"Informe a quantidade de pães-de-mel que deseja comprar:");
    quant = Integer.parseInt(doce);
    d.PaoDeMel(0,quant);
}

if (mariaMole.isSelected()){
    doce = JOptionPane.showInputDialog(null,"Informe a quantidade de maria-moles que deseja comprar:");
    quant = Integer.parseInt(doce);
    d.MariaMole(0,quant);
}
if(d.resultados.length() > 1){
JOptionPane.showMessageDialog(null, d.resultados + "\nTotal: R$" + d.total);
}
    }
}
