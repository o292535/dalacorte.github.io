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
public class PessoaFisica10 extends Contribuentes {
       double rendaBrutaFisica;

    public double getRendaBrutaFisica() {
        return rendaBrutaFisica;
    }

    public void setRendaBrutaFisica(double rendaBrutaFisica) {
        this.rendaBrutaFisica = rendaBrutaFisica;
    }
        public PessoaFisica10(double r){
       this.rendaBrutaFisica = r;
       double imposto = getRendaBrutaFisica()-resultado();
       System.out.println("O valor do seu salario é :"+getRendaBrutaFisica()+"\n Com impostos sera de :"+resultado()+"\n O Imposto foi de: "+imposto);
        }
        double resultado(){
            double aliquota = 0;
            double parcela = 0;
            if(getRendaBrutaFisica() >= 1400.01 && getRendaBrutaFisica() <= 2100.00){
            aliquota = getRendaBrutaFisica()*0.10;;
            parcela = 100;
            } 
            else if(getRendaBrutaFisica() >= 2100.01 && getRendaBrutaFisica() <= 2800.00){
            aliquota = getRendaBrutaFisica()*0.15;
            parcela = 270; 
            }
            else if(getRendaBrutaFisica() >= 2800.01 && getRendaBrutaFisica() <= 3600.00){
            aliquota = getRendaBrutaFisica()*0.25;
            parcela = 500; 
            }
            else if(getRendaBrutaFisica() >3600.01){
            aliquota = getRendaBrutaFisica()*0.30;
            parcela = 700; 
            }
            double resultado = (getRendaBrutaFisica()- aliquota) - parcela;
            return resultado;
        }
        
}

        

