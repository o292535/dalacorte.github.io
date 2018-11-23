package PacoteJavaOO;

/**
 *
 * @author windyS e FourtZ
 */

public class Caneta {
    
    public Caneta(String m, String c){
        this.modelo = c;
        this.cor = m;
        tampar();
        mostrar();
    }
    
    public String modelo;
    public String cor;
    private double ponta;
    private int carga;
    protected boolean tampada;

    public boolean isTampada() {
        return tampada;
    }

    public void setTampada(boolean tampada) {
        this.tampada = tampada;
    }

    public void escrever() {

    }

    public void rabiscar() {

    }

    public void pintar() {

    }

    public void tampar() {
        this.tampada = true;
        System.out.println("Caneta tampada: " + this.tampada);
    }

    public void destampar() {
        this.tampada = false;
        System.out.println("Caneta destampada: " + this.tampada);
    }

    public void mostrar() {
        System.out.println("Modelo é: " + this.modelo);
        System.out.println("Caneta está: " + this.tampada);
        System.out.println("Cor da Caneta: "+this.cor);
        status();
        setPonta(0.5);
        setCarga(10);
        System.out.println("Caraga da Caneta: "+ getCarga());
        System.out.println("Ponta da Caneta: "+ getPonta());
    }

    public void status() {
        if (this.tampada == true) {
            tampar();
        } else {
            destampar();
        }
    }

    public double getPonta() {
        return ponta;
    }

    public void setPonta(double ponta) {
        this.ponta = ponta;
    }

    public int getCarga() {
        return carga;
    }

    public void setCarga(int carga) {
        this.carga = carga;
    }

}