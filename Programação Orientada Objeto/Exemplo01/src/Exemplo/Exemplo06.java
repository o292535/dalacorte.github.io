package Exemplo;
import javax.swing.JOptionPane;

public class Exemplo06 {
public static void main(String[] args) {
int id, codPeca, qtde;
double pUnico=0, pTotal, comissao;

id = Integer.parseInt(JOptionPane.showInputDialog("Digite a identificação dovendedor:")); // id = identificação do vendedor
codPeca = Integer.parseInt(JOptionPane.showInputDialog("Digite o código da peça:")); //codPeca = código da peça
qtde = Integer.parseInt(JOptionPane.showInputDialog("Digite a quantidade vendida:")); //qtde = quantidade vendidapUnico = Integer.parseInt(JOptionPane.showInputDialog("Digite o preço único da peça:"));
// pUnico = preço único da peça

pTotal = pUnico * qtde;
comissao = pTotal * 0.05;

JOptionPane.showMessageDialog(null, "Comissão total = " + comissao);
}
}