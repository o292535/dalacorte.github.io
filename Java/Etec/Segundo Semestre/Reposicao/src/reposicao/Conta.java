package reposicao;

public class Conta {

    public Conta(String nome){
    this.nome = nome;
        System.out.println("");
    }
    public Conta(){
        
    }
    private int conta;
    private int agencia;
    private String nome;
    private double saldo;

    public void sacar() {

    }

    public void depositar() {

    }

    public void transferir() {

    }

    public int getConta() {
        return conta;
    }

    public void setConta(int conta) {
        this.conta = conta;
    }

    public int getAgencia() {
        System.out.println(agencia);
        return agencia;
    }

    public void setAgencia(int agencia) {
        this.agencia = agencia;
    }

    public String getNome() {
        return nome;
    }

    public void setNome(String nome) {
        this.nome = nome;
    }

    public double getSaldo() {
        return saldo;
    }

    public void setSaldo(double saldo) {
        this.saldo = saldo;
    }

}
