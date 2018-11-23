/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package PacoteJavaExercicio;

/**
 *
 * @author LAB
 */
public class Ingresso {
    private double valor = 30;

    public double getValor() {
        return this.valor;
    }

    public void setValor(double valor) {
        this.valor = valor;
    }
    void imprimeValor(){
        System.out.println("o valor é :"+valor);
    }
}
