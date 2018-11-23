/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package polimorfismo;

/**
 *
 * @author LAB
 */
public class DVD extends LivroCdDvd {

    public DVD(String n,double p,double d){
    super.setNome(n);
    super.setPreco(p);
    setDuracao(d);
        System.out.println(toString());
    }
    
    private double duracao;

    public double getDuracao() {
        return duracao;
    }

    public void setDuracao(double duracao) {
        this.duracao = duracao;
    }

    @Override
    public String toString() {
        return "DVD" + "\nNome do DVD=" + getNome() + "\nPreco do DVD=" + getPreco() + "\nDuracao do DVD=" + getDuracao();
    }

}
