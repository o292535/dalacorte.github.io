/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package PacoteJavaExercicio3;

/**
 *
 * @author Okarin
 */
public class Caixa extends Cartao implements Funcionario {

    double valor = super.getPreco() * super.getQuantidade();

    public Caixa(String tp, double p, double q) {
        super(tp, p, q);
        p = p * q;
    }

    String formaPagamento(String pagamento){
        
        if(pagamento == "cartao"){
            System.out.println("digite a senha do cartao: ");
        }else if (pagamento == "dinheiro"){
            System.out.println("pague o dinheiro para a pessoa!");
        }else{
            System.out.println("forma de pagamento nao selecionada");
        }
        
        return pagamento;
    }

    @Override
    public String setFuncionario(String funcionario) {  
        return funcionario;
    }

    
}
