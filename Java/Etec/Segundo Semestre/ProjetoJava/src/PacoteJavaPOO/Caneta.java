package PacoteJavaPOO;

/**
 *
 * @author windyS e Julio
 */
public class Caneta {

    public String modelo;
    public String cor;
    private double ponta;
    private int carga;
    protected boolean tampada;

    public void escrever() {

    }

    public void rabiscar() {

    }

    public void pintar() {

    }

    public void tampar() {
        System.out.println("Caneta tampada: " + this.tampada);
    }

    public void destampar() {
        System.out.println("Caneta destampada: " + this.tampada);
    }

    public void mostrar() {
        System.out.println("Modelo é: " + this.modelo);
        System.out.println("Caneta está: " + this.tampada);
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
