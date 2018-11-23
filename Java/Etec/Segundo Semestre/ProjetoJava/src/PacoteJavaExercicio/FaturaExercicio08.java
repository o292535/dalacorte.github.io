package pacotejavaexercicio;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author LAB
 */
public class FaturaExercicio08 {
    private String numero;
    private String descricao;
    private int qtdeCompra;
    private double precoItem;

    public String getNumero() {
        return numero;
    }

    public void setNumero(String numero) {
        this.numero = numero;
    }

    public String getDescricao() {
        return descricao;
    }

    public void setDescricao(String descricao) {
        this.descricao = descricao;
    }

    public int getQtdeCompra() {
        return qtdeCompra;
    }

    public void setQtdeCompra(int qtdeCompra) {
        this.qtdeCompra = qtdeCompra;
    }

    public double getPrecoItem() {
        return precoItem;
    }

    public double getValorFatura() {
        
        return precoItem = this.qtdeCompra + this.precoItem;
    }
    
    public void setPrecoItem(double precoItem) {
        this.precoItem = precoItem;
    }

    public FaturaExercicio08(String numero, String descricao, int qtdeCompra, double precoItem){
        
    }
    
}
