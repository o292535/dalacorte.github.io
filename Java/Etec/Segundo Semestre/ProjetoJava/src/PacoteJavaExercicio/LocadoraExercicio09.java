/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pacotejavaexercicio;

/**
 *
 * @author LAB
 */
public class LocadoraExercicio09 {

    private String modelo;
    private String marca;
    private int ano;
    private double precoAlocacao;
    private int diasAlocacao;
    private String tipo;
    private double alocacao;

    String valorAlocacao(String alocacao) {
        if (alocacao == "utilitario") {
            this.alocacao = 40 * this.diasAlocacao;
            System.out.println("alocacao: " + alocacao);
        } else if (alocacao == "passeio") {
            this.alocacao = 20 * this.diasAlocacao;
            System.out.println("alocacao: " + alocacao);
        }

        return alocacao;
    }
}
