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
public class PessoaJuridica10 extends Contribuentes  {
    
    double rendaBrutaEmp;
    
   public PessoaJuridica10(double r){
       this.rendaBrutaEmp = r;
       System.out.println("O valor do Imposto vai ser de: "+resultado());
   }
    public double getRendaBrutaEmp() {
        return rendaBrutaEmp;
    }

    public void setRendaBrutaEmpressa(double rendaBrutaEmp) {
       this.rendaBrutaEmp = getRendaBruta();
    }
    public double resultado(){
        double valor = getRendaBrutaEmp() * 0.10;
        return valor;
    }
}
