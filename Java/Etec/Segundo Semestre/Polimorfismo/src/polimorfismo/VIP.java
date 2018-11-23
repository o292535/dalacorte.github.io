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
public abstract class VIP extends Ingresso{
   double valor = super.getValor()+5;
   String localizacao;

    public String getLocalizacao() {
        return localizacao;
    }

    public void setLocalizacao(String localizacao) {
        this.localizacao = localizacao;
    }
   
    @Override
    public double getValor() {
         return this.valor;//To change body of generated methods, choose Tools | Templates.
    }
    
   @Override
  public void setValor(double valor) {
        this.valor = valor;
    }
 
      
}
