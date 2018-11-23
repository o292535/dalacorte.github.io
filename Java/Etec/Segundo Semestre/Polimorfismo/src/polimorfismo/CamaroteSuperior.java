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
public class CamaroteSuperior extends VIP {
    double valor = super.getValor()+10;
    String localizacao = "São Paulo";
    
    @Override
    public double getValor() {
         return valor;//To change body of generated methods, choose Tools | Templates.
    }
    
   @Override
  public void setValor(double valor) {
        this.valor = valor;
    }

     @Override
    public String getLocalizacao() {
        System.out.println("Localização do Ingresso: " + this.localizacao);
        return localizacao;
    }


    @Override
    public void setLocalizacao(String localizacao) {
        this.localizacao = localizacao;
    }
  
  
}
