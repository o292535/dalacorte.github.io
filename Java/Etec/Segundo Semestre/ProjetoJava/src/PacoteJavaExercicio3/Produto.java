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
public abstract class Produto {

    Produto(String tp, double p, double q){
        setTipoProduto(tp);
        setPreco(p);
        setQuantidade(q);
    }
    
    Produto(){
        
    }
    
    private String tipoProduto = "";
    private double preco = 0;
    private double quantidade = 0;

    public double getPreco() {
        return preco;
    }

    public void setPreco(double preco) {
        this.preco = preco;
    }

    public double getQuantidade() {
        return quantidade;
    }

    public void setQuantidade(double quantidade) {
        this.quantidade = quantidade;
    }

    public String getTipoProduto() {
        return tipoProduto;
    }

    public void setTipoProduto(String tipoProduto) {
        this.tipoProduto = tipoProduto;
    }
    
}
