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
public class IngressoExercicio05 {

    private int ingresso = 1;
    private int tipoIngresso = 2;
    private int imovel = 1;

    public int getIngresso() {
        return ingresso;
    }

    public void setIngresso(int ingresso) {
        this.ingresso = ingresso;
    }

    void ingresso() {
        if (this.ingresso == 1) {
            System.out.println("Voce comprou um ingresso normal");
        } else if (this.ingresso == 2) {
            System.out.println("Voce comprou um ingresso VIP");
            if (this.tipoIngresso == 1) {
                System.out.println("Voce comprou camarote superior");
            } else if (this.tipoIngresso == 2) {
                System.out.println("Voce comprou camarote inferior");
            }
        }
        if (this.imovel == 1) {
            System.out.println("O imovel é novo");
        } else if (this.imovel == 2) {
            System.out.println("O imovel é velho");
        }
    }
}
