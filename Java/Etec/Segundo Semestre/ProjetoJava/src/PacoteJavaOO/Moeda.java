
package PacoteJavaOO;

/**
 *
 * @author windyS e FourtZ
 */

public class Moeda {
    
    private double valor;
    private String nome;

    public Moeda(double v, String n){
        this.valor = v;
        this.nome = n;
        getValor(); getNome();
    }
    
    public double getValor() {
        System.out.println("Valor da moeda: "+ this.valor);
        return valor;
    }

    public void setValor(double valor) {
        this.valor = valor;
    }

    public String getNome() {
        System.out.println("Nome da moeda: "+ this.nome);
        return nome;
    }

    public void setNome(String nome) {
        this.nome = nome;
    }   
    
}
