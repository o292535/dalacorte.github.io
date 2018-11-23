/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package PacoteJavaExercicio2;

/**
 *
 * @author LAB
 */
public class Cliente {
    
    private int codigoLocadora;
    private String identificacaoMotorista;
    private String habilitacao;
    private int dataVencimento;
    private String tipo;

    public String getTipo() {
        return tipo;
    }

    public void setTipo(String tipo) {
        this.tipo = tipo;
    }
    public int getCodigoLocadora() {
        return codigoLocadora;
    }

    public void setCodigoLocadora(int codigoLocadora) {
        this.codigoLocadora = codigoLocadora;
    }

    public String getIdentificacaoMotorista() {
        return identificacaoMotorista;
    }

    public void setIdentificacaoMotorista(String identificacaoMotorista) {
        this.identificacaoMotorista = identificacaoMotorista;
    }

    public String getHabilitacao() {
        return habilitacao;
    }

    public void setHabilitacao(String habilitacao) {
        this.habilitacao = habilitacao;
    }

    public int getDataVencimento() {
        return dataVencimento;
    }

    public void setDataVencimento(int dataVencimento) {
        this.dataVencimento = dataVencimento;
    }
    
}
