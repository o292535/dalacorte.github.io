package PacoteJavaOO;

/**
 *
 * @author windyS e FourtZ
 */

public class Conta {
    
    private int numero;
    private double saldo;
    private double limite;
    private String nome;
    
    public Conta(double valor,double saca,double deposita){
        this.setSaldo(valor);
        mostrar();
        sacar(saca);
        depositar(deposita);
    }
    
    public void mostrar(){
        System.out.println("o Valor da conta é: "+getSaldo());
    }
    
    public int getNumero() {
        return numero;
    }

    public void setNumero(int numero) {
        this.numero = numero;
    }

    public double getSaldo() {
        return saldo;
    }

    public void setSaldo(double saldo) {
        this.saldo = saldo;
    }

    public double getLimite() {
        return limite;
    }

    public void setLimite(double limite) {
        this.limite = limite;
    }

    public String getNome() {
        return nome;
    }

    public void setNome(String nome) {
        this.nome = nome;
    }
    
    public double sacar(double valor){
        this.saldo -= valor;
        System.out.println("Você Sacou "+valor+" e seu saldo é de : "+getSaldo());
        return valor;
    }
    
    public double depositar(double valor){
        this.saldo += valor;
        System.out.println("Você depositou "+valor+" e seu saldo é de: "+getSaldo());
        return valor;
    }
    
}
