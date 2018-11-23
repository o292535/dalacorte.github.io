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
public class CamaroteInferior extends VIP {

    private String localizacao = "São Bento";

    

    @Override
    public String getLocalizacao() {
        System.out.println("Localização do Ingresso: " + getLocalizacao());
        return localizacao;
    }

    @Override
    public void setLocalizacao(String localizacao) {
        this.localizacao = localizacao;
    }

}
